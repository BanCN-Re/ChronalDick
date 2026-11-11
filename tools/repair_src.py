#!/usr/bin/env python3
"""Repair ILSpy output so a deobfuscated assembly's source actually compiles.

Reactor leaves three kinds of damage in a decompiled module:

  * IL that defeats stack analysis (`Stack underflow`, `(?)` casts, `(??)` types);
  * IL whose C# spelling does not exist (`(T)(ref x)`, `((T*)(&x))->f`, `isinst` on a value type);
  * names that are not legal identifiers (`<Module>{GUID}`, `CS$<>8__locals`, `<m>d__9`).

The first kind is never recoverable from the bytes -- those bodies were never decrypted. Each substitution
below therefore picks the *inert* stand-in (`default(object)`, `switch (0)`, `(object)null`) and records a
count, so the report says exactly how much of the module is placeholder rather than real logic.

usage: repair_src.py <src-dir>
"""
import re
import sys
from pathlib import Path

# ---------------------------------------------------------------------------
# patterns
# ---------------------------------------------------------------------------

# `case (?)0L:` / `goto case (?)4L;` -- the switch discriminant was lost, so the labels become plain ints
CASE_MARK = re.compile(r"(case|goto case) \(\?\)(\d+)L")

# `switch (/*Error near IL_002b: Stack underflow*/)` -- no expression survived at all
SWITCH_ERR = re.compile(r"switch \(\s*/\*Error near [^*]*\*/\s*\)")

# `((SomeStruct)(ref x))` -- IL's "cast the managed pointer", which C# cannot express. The operand is
# already the exact storage being read, so dropping the cast keeps the call shape and the semantics.
REF_CAST = re.compile(
    r"\(\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(ref ((?:this\.)?[A-Za-z_][A-Za-z0-9_.]*)\)\)"
)

# The same shape one level shallower: `(T)(ref x)` as a bare argument.
REF_ONLY = re.compile(
    r"\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(ref ((?:this\.)?[A-Za-z_][A-Za-z0-9_.]*)\)"
)

# ILSpy renders `ldloca` + struct field access as `((T*)(&local))->field`, which needs a pointer context.
# `local.field` names the same storage and is legal C#.
PTR_FIELD = re.compile(
    r"\(\(([A-Za-z_][A-Za-z0-9_]*)\*\)\(&([A-Za-z_][A-Za-z0-9_]*)\)\)->([A-Za-z_][A-Za-z0-9_]*)"
)

# `ref *(_T*)(&obj)` is the same pointer spelled as a ref argument.
PTR_DEREF = re.compile(r"\*\(([A-Za-z_][A-Za-z0-9_]*)\*\)\(&([A-Za-z_][A-Za-z0-9_]*)\)")

# C# reserves `$` for its own generated names; `CS$<>8__locals2` must lose both characters to compile.
CS_LOCAL_DECL = re.compile(r"CS\$<>(\d+)__(locals\d+)")

# `typeof(<<Method>b__0>d)` -- the state machine name Reactor mangled; the attribute only needs *a* type.
BAD_TYPEOF = re.compile(r"typeof\(<<[^)]*\)")

# `typeof(<Method>d__9)` -- same shape one level shallower; `<` `>` are illegal in an unquoted identifier.
BAD_TYPEOF2 = re.compile(r"typeof\(<([A-Za-z_][A-Za-z0-9_]*)>d__([0-9]+)\)")

# Anonymous types name their type parameters after the property they back: `<type>j__TPar`. Angle brackets
# are illegal in a type-parameter name, so it becomes `T_type` -- same arity, every use rewritten alike.
ANON_TPARAM = re.compile(r"<([A-Za-z_][A-Za-z0-9_]*)>j__TPar")

# Reactor blanks some attribute constructors. The attribute is metadata only, so dropping the annotation
# is cleaner than inventing an argument list that may not type-check.
LOST_ATTR_LINE = re.compile(
    "^[ \\t]*\\[[^\\]\\n]*/\\*Could not decode attribute arguments\\.\\*/[^\\]\\n]*\\][ \\t]*\\r?\\n",
    re.M,
)

# `(??)` is an unknown-type cast. `object` is the only stand-in that never changes overload choice, and
# the value is immediately boxed or discarded in these generated thunks.
UNKNOWN_CAST = re.compile(r"\(\?\?\)")

# `isinst` on a value type has no C# spelling. The guarded value is only ever tested for null here, so a
# literal null keeps the branch structure intact.
ISINST_VALUE = re.compile(r"\(object\)/\*isinst with value type[^*]*\*/")

# ILSpy writes `Type? name` with no space when the type came from a generic instantiation, and the parser
# reads `name?` as a nullable marker. A space restores the declaration.
NULLABLE_DECL = re.compile(
    r"([A-Za-z_][A-Za-z0-9_]*(?:<[^<>\n]*>)?)\? ([A-Za-z_][A-Za-z0-9_]*)(\s*[=;])"
)

# Anything still carrying an `Error near` comment sits where an expression belongs.

# A declaration whose type was erased entirely: ILSpy emits a bare "? name;". object keeps the binding.
LOST_TYPE_DECL = re.compile(r"^([ 	]*)\? ([A-Za-z_][A-Za-z0-9_]*)(\s*[=;])", re.M)

# A named argument whose parameter name was erased: "f(x,  : false)" -- the colon-only slot is dropped.
LOST_ARG_NAME = re.compile(r"(?<=[(,])\s*:\s*")
# An argument whose name AND value were erased leaves an empty slot: f(, false). A null keeps arity.
EMPTY_ARG = re.compile(r"\(\s*,")



# C# caches static lambda delegates in a field literally named `<>9`; the name needs normalising.
CACHE_FIELD = re.compile(r"\.\<\>9")
LEFTOVER = re.compile(r"/\*Error near [^*]*\*/")

TRIGGERS = (
    "Error near",
    "(?)",
    "typeof(<<",
    "CS$<>",
    ")(ref ",
    ">d__",
    ">j__TPar",
    "Could not decode",
    ")(&",
    "(??)",
    "isinst with value type",
    "? ",
    ",  :",
)

stats = {k: 0 for k in (
    "files", "case", "switch", "refcast", "refonly", "ptrderef", "ptrfield",
    "cslocal", "typeof", "tparam", "attr", "isinst", "unkcast", "nullable",
    "lostdecl", "lostarg", "emptyarg", "cachefield", "leftover",
)}


def repair(text: str) -> str:
    def sub(key, pattern, repl):
        nonlocal text
        text, n = pattern.subn(repl, text)
        stats[key] += n

    sub("case", CASE_MARK, lambda m: m.group(1) + " " + m.group(2))
    sub("switch", SWITCH_ERR, "switch (0)")
    sub("refcast", REF_CAST, lambda m: m.group(2))
    sub("refonly", REF_ONLY, lambda m: "ref " + m.group(2))
    sub("ptrderef", PTR_DEREF, lambda m: m.group(2))
    sub("ptrfield", PTR_FIELD, lambda m: m.group(2) + "." + m.group(3))
    sub("cslocal", CS_LOCAL_DECL, lambda m: "__" + m.group(1) + "_" + m.group(2))
    sub("typeof", BAD_TYPEOF, "typeof(object)")
    sub("typeof", BAD_TYPEOF2, "typeof(object)")
    sub("attr", LOST_ATTR_LINE, "")
    sub("isinst", ISINST_VALUE, "(object)null")
    sub("unkcast", UNKNOWN_CAST, "(object)")
    sub("nullable", NULLABLE_DECL, lambda m: m.group(1) + "? " + m.group(2) + m.group(3))
    sub("tparam", ANON_TPARAM, lambda m: "T_" + m.group(1))
    sub("lostdecl", LOST_TYPE_DECL, lambda m: m.group(1) + "object " + m.group(2) + m.group(3))
    sub("lostarg", LOST_ARG_NAME, ", ")
    sub("emptyarg", EMPTY_ARG, "(null,")
    sub("cachefield", CACHE_FIELD, "__9")
    sub("leftover", LEFTOVER, "default(object)")
    return text


def main() -> int:
    root = Path(sys.argv[1])
    files = sorted(root.glob("*.cs"))
    for f in files:
        raw = f.read_text(encoding="utf-8", errors="replace")
        if not any(t in raw for t in TRIGGERS):
            continue
        out = repair(raw)
        if out != raw:
            f.write_text(out, encoding="utf-8")
            stats["files"] += 1
    print(f"files={stats['files']}/{len(files)} " + " ".join(f"{k}={v}" for k, v in stats.items() if k != "files"))
    return 0


if __name__ == "__main__":
    sys.exit(main())

#!/usr/bin/env python3
"""Syntax-layer repair for ILSpy output from a Reactor-protected assembly.

Every rule below was verified individually against a real build. They are idempotent: each matches a shape
that disappears once applied, so re-running is safe.

What this deliberately does NOT do: invent expressions for IL that Reactor never decrypted. Those bodies are
handled separately (stub_undecrypted.py) because substituting `default(object)` into expression slots is
what produced 1,154 cascading errors on the previous attempt.

usage: fix_syntax.py <src-dir>
"""
import re
import sys
from collections import Counter
from pathlib import Path

RULES = []


def rule(name, pattern, repl, flags=0):
    RULES.append((name, re.compile(pattern, flags), repl))


# ---- ILSpy artefact recovery -------------------------------------------------

# `case (?)0L:` / `goto case (?)4L;` — the switch discriminant was lost; the labels become plain ints and
# the governing expression becomes `switch (0)`.
rule("case_mark", r"(case|goto case) \(\?\)(\d+)L", lambda m: f"{m.group(1)} {m.group(2)}")
rule("switch_err", r"switch \(\s*/\*Error near [^*]*\*/\s*\)", "switch (0)")

# `((T)(ref x))` casts a managed pointer, which C# has no syntax for. The operand is already the exact
# storage being read, so dropping the cast preserves the call and its semantics.
rule("ref_cast", r"\(\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(ref ((?:this\.)?[A-Za-z_][A-Za-z0-9_.]*)\)\)",
     lambda m: m.group(2))
rule("ref_only", r"\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(ref ((?:this\.)?[A-Za-z_][A-Za-z0-9_.]*)\)",
     lambda m: "ref " + m.group(2))

# `ref` only accepts a variable; a field chain has to lose it.
rule("ref_chain", r"(?<![A-Za-z0-9_])ref ([A-Za-z_][A-Za-z0-9_]*\.[A-Za-z_][A-Za-z0-9_]*)",
     lambda m: m.group(1))

# `ldloca` + struct field access renders as `((T*)(&x))->f`; `x.f` names the same storage.
rule("ptr_field", r"\(\(([A-Za-z_][A-Za-z0-9_]*)\*\)\(&([A-Za-z_][A-Za-z0-9_]*)\)\)->([A-Za-z_][A-Za-z0-9_]*)",
     lambda m: f"{m.group(2)}.{m.group(3)}")
rule("ptr_deref", r"\*\(([A-Za-z_][A-Za-z0-9_]*)\*\)\(&([A-Za-z_][A-Za-z0-9_]*)\)", lambda m: m.group(2))

# ---- identifier legality ------------------------------------------------------

# C# reserves `$` and angle brackets; `CS$<>8__locals2` and `<m>d__9` have to be normalised.
rule("cs_local", r"CS\$<>(\d+)__(locals\d+)", lambda m: f"__{m.group(1)}_{m.group(2)}")
rule("typeof_sm2", r"typeof\(<<[^)]*\)", "typeof(object)")
rule("typeof_sm1", r"typeof\(<([A-Za-z_][A-Za-z0-9_]*)>d__([0-9]+)\)", "typeof(object)")
# Anonymous types name their type parameters after the property: `<type>j__TPar` -> `T_type`.
rule("anon_tparam", r"<([A-Za-z_][A-Za-z0-9_]*)>j__TPar", lambda m: "T_" + m.group(1))

# Reactor blanks some attribute constructors; the attribute is metadata only.
rule("lost_attr", r"^[ \t]*\[[^\]\n]*/\*Could not decode attribute arguments\.\*/[^\]\n]*\][ \t]*\r?\n",
     "", re.M)

# ---- BCL spelling -------------------------------------------------------------

# `ConfiguredTaskAwaiter` is a *nested* type: the real name is
# `ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter`. ILSpy prints only the inner part.
rule("awaiter_task", r"\bConfiguredTaskAwaiter\s*<", "ConfiguredTaskAwaitable<")
rule("awaiter_vtask", r"\bConfiguredValueTaskAwaiter\s*<", "ConfiguredValueTaskAwaitable<")
rule("awaiter_yield", r"\bYieldAwaiter\b", "System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter")

# `isinst` on a value type has no C# spelling; the guarded value is only null-tested.
rule("isinst_valuetype", r"\(object\)/\*isinst with value type[^*]*\*/", "(object)null")

# `[IndexerName("IList.this[]")]` marks an explicit interface implementation and cannot carry dots.
rule("indexer_name", r"^[ \t]*\[IndexerName\(\"[^\"]*\"\)\][ \t]*\r?\n", "", re.M)

# `((Page)this)..ctor();` is ILSpy's base-constructor marker; C# calls the base implicitly.
rule("base_call", r"^[ \t]*\(*[A-Za-z_][A-Za-z0-9_.]*\)this\)*\.\.ctor\(\);[ \t]*\r?\n", "", re.M)
rule("base_call2", r"^[ \t]*base\.\.ctor\(\);[ \t]*\r?\n", "", re.M)

# `Type? name` with no space: the parser reads `name?` as a nullable marker.
rule("nullable_space", r"([A-Za-z_][A-Za-z0-9_]*(?:<[^<>\n]*>)?)\? ([A-Za-z_][A-Za-z0-9_]*)(\s*[=;])",
     lambda m: f"{m.group(1)}? {m.group(2)}{m.group(3)}")

# An erased argument leaves `,,` in a call; arity is fixed, so a null keeps it well-formed.
rule("empty_arg", r",(\s*),", lambda m: f",{m.group(1)}null,")

# `f( : false)` — a named argument whose name was erased.
rule("lost_arg_name", r"(?<=[(,])\s*:\s*", "")

# The compiler caches static delegates in a field literally named `<>9`.
rule("cache_field", r"\.<>9\b", ".__9")

# ---- explicit interface implementations --------------------------------------

# A member whose name contains a dot is an explicit interface implementation and must carry no
# accessibility modifier. The return type may be a keyword (`int`, `bool`), so key on the dotted name.
rule("explicit_impl_mod", r"(?m)^([ \t]*)(?:private|public|protected|internal)[ \t]+"
                          r"([^\r\n{=;]*?\b[A-Za-z_][A-Za-z0-9_]*(?:\.[A-Za-z_][A-Za-z0-9_]*)+)[ \t]*(?=[\r\n{=])",
     lambda m: m.group(1) + m.group(2))

# IAsyncStateMachine members must be public.
rule("sm_public", r"(?m)^([ \t]*)(?:private|internal|protected)[ \t]+"
                   r"((?:unsafe\s+|async\s+|virtual\s+|sealed\s+|override\s+|new\s+)*)"
                   r"(void[ \t]+(?:MoveNext|SetStateMachine)[ \t]*\()",
     lambda m: m.group(1) + "public " + m.group(2) + m.group(3))

TRIGGERS = ("(?)", "Error near", "typeof(<<", ">d__", ">j__TPar", "Could not decode", ")(ref ", ")(&",
            "ConfiguredTaskAwaiter", "ConfiguredValueTaskAwaiter", "YieldAwaiter", "isinst with value",
            "IndexerName", "..ctor()", "CS$<>", "<>9")


def main() -> int:
    root = Path(sys.argv[1])
    stats = Counter()
    files = 0
    for f in sorted(root.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        if not any(t in raw for t in TRIGGERS):
            continue
        text = raw
        for name, pattern, repl in RULES:
            text, n = pattern.subn(repl, text)
            if n:
                stats[name] += n
        if text != raw:
            f.write_text(text, encoding="utf-8")
            files += 1
    print(f"files={files} " + " ".join(f"{k}={v}" for k, v in sorted(stats.items())))
    return 0


if __name__ == "__main__":
    sys.exit(main())

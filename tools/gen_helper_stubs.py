#!/usr/bin/env python3
"""Rebuild the static half of Reactor's helper types, using the metadata's real signatures.

The obfuscator declares each helper twice under one name: a delegate for the call signature and a static
class with the methods. ILSpy writes both to `<Name>.cs`, so the delegate wins and every call site fails
with "type has no member X".

A `params object[]` stand-in compiles the call sites but breaks them: `object` cannot be passed to a `ref`
parameter, cannot be `!`-ed, and does not convert to `int`. The signatures are therefore taken verbatim from
the typemap (`RetType(ParamType,...)`), and the parameter types are emitted as written.

usage: gen_helper_stubs.py <src-dir> <typemap.tsv>
"""
import re
import sys
from collections import defaultdict
from pathlib import Path

DELEGATE_ONLY = re.compile(
    r"^(?P<prefix>(?:using [^\n]*\n)*)\s*internal delegate (?P<ret>[^\n]*?) (?P<name>[A-Za-z_][A-Za-z0-9_]*)\s*\((?P<params>[^\n]*)\);\s*$"
)
SIG = re.compile(r"^(?P<ret>.+?)\((?P<params>.*)\)$")

# Types whose BCL spelling differs from the metadata name.
ALIAS = {
    "System.Void": "void", "System.Int32": "int", "System.UInt32": "uint",
    "System.Int64": "long", "System.UInt64": "ulong", "System.Int16": "short",
    "System.UInt16": "ushort", "System.Byte": "byte", "System.SByte": "sbyte",
    "System.Boolean": "bool", "System.Char": "char", "System.Single": "float",
    "System.Double": "double", "System.Decimal": "decimal", "System.String": "string",
    "System.Object": "object",
}


def cs_type(t: str) -> str:
    t = t.strip()
    t = ALIAS.get(t, t)
    # `System.Collections.Generic.List`1<System.String>` -> `List<string>`; keep the namespace qualifier off
    # and let the file's usings resolve it, which is what the decompiler output already relies on.
    t = re.sub(r"`\d+", "", t)
    t = re.sub(r"<([^<>]*)>", lambda m: "<" + ",".join(cs_type(x) for x in m.group(1).split(",")) + ">", t)
    if t.startswith("System.") and "<" not in t and "." not in t[len("System."):]:
        t = t[len("System."):]
    t = t.replace("/", ".")
    return t


def main() -> int:
    src = Path(sys.argv[1])
    type_members = defaultdict(lambda: {"methods": [], "fields": []})
    for line in Path(sys.argv[2]).read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 5:
            continue
        if p[0] == "METHOD":
            sig = p[5] if len(p) > 5 else ""
            type_members[p[2]]["methods"].append((p[3], sig))
        elif p[0] == "FIELD":
            type_members[p[2]]["fields"].append(p[3])

    written = 0
    for f in sorted(src.glob("*.cs")):
        text = f.read_text(encoding="utf-8", errors="replace")
        m = DELEGATE_ONLY.match(text)
        if not m:
            continue
        name = m.group("name")
        info = type_members.get(name)
        if not info:
            continue
        methods = [(n, s) for n, s in info["methods"]
                   if n not in ("Invoke", "_ctor", "_cctor", "BeginInvoke", "EndInvoke")]
        if not methods:
            continue

        body = [m.group("prefix").rstrip("\n"), ""]
        body.append(f"internal delegate {m.group('ret')} {name}_Invoke({m.group('params')});")
        body.append("")
        body.append(f"internal static class {name}")
        body.append("{")
        for fld in sorted(info["fields"]):
            body.append(f"\tinternal static object {fld};")
        for meth, sig in methods:
            sm = SIG.match(sig)
            if not sm:
                body.append(f"\n\tinternal static object {meth}(params object[] args) => null;")
                continue
            params = []
            for i, pt in enumerate(x for x in sm.group("params").split(",") if x.strip()):
                params.append(f"{cs_type(pt)} p{i}")
            body.append("")
            body.append(f"\tinternal static {cs_type(sm.group('ret'))} {meth}({', '.join(params)}) => default;")
        body.append("}")
        f.write_text("\n".join(body) + "\n", encoding="utf-8")
        written += 1

    print(f"helper types rebuilt: {written}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

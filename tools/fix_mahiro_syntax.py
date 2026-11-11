#!/usr/bin/env python3
"""Mahiro-specific syntax normalisation: assembly-qualified generics, primitive names,
angle-bracket identifiers, state-machine typeof, span ref-of-cast."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1])

PRIM = {
    "Char": "char", "Int32": "int", "Byte": "byte", "Object": "object", "String": "string",
    "Boolean": "bool", "UInt32": "uint", "Int64": "long", "UInt64": "ulong", "Int16": "short",
    "UInt16": "ushort", "SByte": "sbyte", "Double": "double", "Single": "float",
    "Decimal": "decimal", "IntPtr": "nint", "UIntPtr": "nuint",
}

n1 = n2 = n3 = n4 = n5 = files = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    raw = t
    # generic argument written as [Type, Assembly, ...]
    t, a = re.subn(r"([A-Za-z_][A-Za-z0-9_.`]*)<\[([^,\[\] ]+)(?:,[^\]]*)?\]>", r"\1<\2>", t); n1 += a
    # strip CLR arity markers that survived in generic names
    t, b = re.subn(r"([A-Za-z_][A-Za-z0-9_]*?)`\d+<", r"\1<", t); n2 += b
    # primitive names as whole tokens
    for k, v in PRIM.items():
        t = re.sub(r"\bSystem\." + k + r"\b", v, t)
    # angle-bracket identifiers (state machine ctor parameters)
    t, c = re.subn(r"<>([A-Za-z0-9_]+)", r"__\1", t); n3 += c
    # generic state machine type in typeof
    t, d = re.subn(r"typeof\(<[^()]*>d__\d+<>\)", "typeof(object)", t); n4 += d
    # ref of a casted char
    t, e = re.subn(r"new global::System\.ReadOnlySpan<char>\(ref \(char\)([A-Za-z_][A-Za-z0-9_.]*)\)",
                   r"new global::System.ReadOnlySpan<char>(new char[] { \1 })", t); n5 += e
    if t != raw:
        f.write_text(t, encoding="utf-8")
        files += 1

print(f"asm_generics={n1} arity={n2} angle_ids={n3} typeof_sm={n4} span_ref={n5} files={files}")

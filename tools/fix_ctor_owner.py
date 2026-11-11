#!/usr/bin/env python3
"""Repair constructors that were renamed to a *nested* type's name.

An earlier pass decided ownership from "nearest type declaration above the line", which is wrong after a
nested state machine closes: the next member belongs to the outer type again, so the outer type's
constructor ended up carrying the nested struct's name (`public _Foo_d__3()`) and C# rejects it as a
method without a return type.

Ownership is now decided by brace depth. A type frame records the depth *at its declaration line* and is
retained while the body is open; a constructor-shaped declaration whose name differs from the frame's type
is renamed to that type. Two shapes count as constructor-shaped: `<Name>(` with no return type, and the
`void _ctor` / `void _cctor` pseudo-methods ILSpy emits.

usage: fix_ctor_owner.py <src-dir>
"""
import re
import sys
from pathlib import Path

TYPE_DECL = re.compile(r"\b(?:record\s+(?:struct|class)|class|struct|interface)\s+([A-Za-z_][A-Za-z0-9_]*)")
DECL = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern|override|readonly|partial)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\("
)
PSEUDO_CTOR = re.compile(r"(?<![\w.])void\s+_ctor(?:_\d+)?\s*\(")
PSEUDO_CCTOR = re.compile(r"(?<![\w.])void\s+_cctor\s*\(\s*\)")
# A base-call spelling ILSpy emits that C# does not accept.
BASE_CALL = re.compile(r"\(\([A-Za-z_][A-Za-z0-9_.]*\)this\)\.\.ctor\s*\(\s*\)\s*;")

RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial", "static", "return",
    "await", "throw", "if", "for", "while", "switch", "using", "lock", "catch", "else", "try",
}


def repair(text: str) -> tuple[str, int]:
    lines = text.split("\n")
    frames: list[tuple[str, int]] = []
    depth = 0
    changed = 0
    out = []

    for line in lines:
        decl = TYPE_DECL.search(line)
        if decl:
            frames.append((decl.group(1), depth))

        if frames:
            owner = frames[-1][0]
            line, k = PSEUDO_CTOR.subn(owner + "(", line)
            changed += k
            line, k = PSEUDO_CCTOR.subn("void " + owner + "()", line)
            changed += k
            m = DECL.match(line)
            if m and m.group("name") not in RETURN_TYPES and m.group("name") != owner:
                # Only a name that is a type declared in this file can be a misnamed constructor.
                if re.search(r"\b(?:class|struct|record\s+\w+|interface)\s+" + re.escape(m.group("name")) + r"\b", text):
                    line = m.group("lead") + owner + line[m.end("name"):]
                    changed += 1
            line = BASE_CALL.sub("", line)
            if line.startswith(" " * 0):
                pass

        depth += line.count("{") - line.count("}")
        if "}" in line:
            while frames and depth <= frames[-1][1]:
                frames.pop()
        out.append(line)

    return "\n".join(out), changed


def main() -> int:
    root = Path(sys.argv[1])
    files = total = 0
    for f in sorted(root.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        text, n = repair(raw)
        if text != raw:
            f.write_text(text, encoding="utf-8")
            files += 1
            total += n
    print(f"files={files} renamed={total}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

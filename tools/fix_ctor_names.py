#!/usr/bin/env python3
"""Repair constructor names that an earlier pass rewrote against the wrong enclosing type.

A previous pass turned `void _ctor(...)` into `<first class in file>(...)`. For top-level types that is
right, but these files nest state machines and `<>c__DisplayClass` helpers inside their page class, so
every nested constructor got the *outer* type's name -- which C# reads as a method without a return type
(CS1520).

This pass walks the file with a brace-depth stack, knows which type owns each line, and renames any
constructor-shaped declaration to the type actually being declared there.

usage: fix_ctor_names.py <src-dir>
"""
import re
import sys
from pathlib import Path

TYPE_DECL = re.compile(r"\b(?:class|struct|record|interface)\s+([A-Za-z_][A-Za-z0-9_]*)")
# A constructor-shaped line: accessibility modifiers, then a bare type name, then `(`. Anything with a
# return type between the modifiers and the name is a normal method and is left alone.
CTOR_DECL = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\("
)
# Tokens that can legally sit where a constructor's name sits and mean "this is a method".
RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "new", "operator", "implicit", "explicit", "delegate", "event", "return", "await",
    "throw", "if", "for", "while", "switch", "using", "lock", "catch", "else", "do", "try",
}


def repair(text: str) -> tuple[str, int]:
    lines = text.split("\n")
    stack: list[tuple[str, int]] = []
    depth = 0
    changed = 0
    out = []

    for line in lines:
        decl = TYPE_DECL.search(line)
        if decl:
            stack.append((decl.group(1), depth + line.count("{") - line.count("}")))

        if stack:
            owner = stack[-1][0]
            m = CTOR_DECL.match(line)
            if m and m.group("name") not in RETURN_TYPES and m.group("name") != owner:
                # Only a name that is a type declared somewhere in this file can be a misnamed ctor.
                if re.search(r"\b(?:class|struct|record)\s+" + re.escape(m.group("name")) + r"\b", text):
                    line = m.group("lead") + owner + line[m.end("name"):]
                    changed += 1

        depth += line.count("{") - line.count("}")
        while stack and depth < stack[-1][1]:
            stack.pop()
        out.append(line)

    return "\n".join(out), changed


def main() -> int:
    root = Path(sys.argv[1])
    files = total = 0
    for f in sorted(root.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        if "(" not in raw:
            continue
        text, n = repair(raw)
        if text != raw:
            f.write_text(text, encoding="utf-8")
            files += 1
            total += n
    print(f"files={files} renamed={total}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

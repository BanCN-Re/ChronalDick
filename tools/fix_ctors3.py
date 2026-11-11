#!/usr/bin/env python3
"""Rename ILSpy's `_ctor[_N]` pseudo-methods to real constructors of their declaring type.

Reactor's blanked bodies make the decompiler emit constructors as ordinary methods named `_ctor`,
`_ctor_2`, ... . C# needs the type name. Scope handling: process the innermost type first, so an
outer pass cannot rename a nested type's ctor with the outer name.
usage: fix_ctors3.py <src-dir>
"""
import re
import sys
from pathlib import Path

from csbraces import deltas

DECL = re.compile(r"^(?P<indent>[ \t]*)(?:(?:public|private|internal|protected|static|sealed|abstract|partial|unsafe|readonly|ref)[ \t]+)*"
                  r"(?:class|struct|record)[ \t]+(?P<name>[A-Za-z_][A-Za-z0-9_]*)[^;{]*$")
CTOR = re.compile(r"\b_ctor(?:_\d+)?\b(?=\s*\()")


def main() -> int:
    src = Path(sys.argv[1])
    files = renamed = 0
    for f in sorted(src.glob("*.cs")):
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        bd = deltas("\n".join(lines))
        types = []
        for i, line in enumerate(lines):
            m = DECL.match(line)
            if not m:
                continue
            j = i + 1
            while j < len(lines) and not lines[j].strip():
                j += 1
            if j >= len(lines) or not lines[j].strip().startswith("{"):
                continue
            depth, k = 0, j
            while k < len(lines):
                depth += bd[k]
                if depth == 0:
                    break
                k += 1
            types.append((k - i, i, k, m.group("name")))
        types.sort()  # innermost (smallest span) first
        changed = False
        for _, start, end, name in types:
            for li in range(start, min(end, len(lines) - 1) + 1):
                new, n = CTOR.subn(name, lines[li])
                if n:
                    new = re.sub(r"void\s+(?=" + re.escape(name) + r"\s*\()", "", new)
                    lines[li] = new
                    renamed += n
                    changed = True
        if changed:
            f.write_text("\n".join(lines), encoding="utf-8")
            files += 1
    print(f"files={files} ctors_renamed={renamed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

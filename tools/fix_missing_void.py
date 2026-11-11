#!/usr/bin/env python3
"""Restore `void` on methods whose name happens to equal some unrelated type.

The previous pass stripped `void` from every declaration whose name matched any type name; only a
declaration inside its own type is a constructor. For each line, find the innermost enclosing type:
name == type -> constructor (leave), otherwise re-insert `void`.
usage: fix_missing_void.py <src-dir>
"""
import re
import sys
from pathlib import Path

from csbraces import deltas

DECL = re.compile(r"^(?P<indent>[ \t]*)(?:(?:public|private|internal|protected|static|sealed|abstract|partial|unsafe|readonly|ref)[ \t]+)*"
                  r"(?:class|struct|record(?:[ \t]+(?:class|struct))?)[ \t]+(?P<name>[A-Za-z_][A-Za-z0-9_]*)[^;{]*$")
MEMBER = re.compile(r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|virtual|sealed|override|unsafe|extern|async|new|partial|readonly)[ \t]+)*)(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\(")


def main() -> int:
    src = Path(sys.argv[1])
    files = fixed = 0
    for f in sorted(src.glob("*.cs")):
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        bd = deltas("\n".join(lines))
        scopes = []
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
            scopes.append((i, k, m.group("name")))
        if not scopes:
            continue
        owner = [None] * len(lines)
        for start, end, name in sorted(scopes, key=lambda s: s[1] - s[0]):
            for li in range(start, min(end, len(lines) - 1) + 1):
                if owner[li] is None:
                    owner[li] = name
        changed = False
        for li, line in enumerate(lines):
            if owner[li] is None:
                continue
            m = MEMBER.match(line)
            if not m or m.group("name") == owner[li]:
                continue
            # already has a return type? strip modifiers and see if anything remains
            pre = line[:m.start("name")]
            rest = re.sub(r"(?:public|private|internal|protected|static|virtual|sealed|override|unsafe|extern|async|new|partial|readonly)", "", pre).strip()
            if rest:
                continue
            lines[li] = pre + "void " + line[m.start("name"):]
            fixed += 1
            changed = True
        if changed:
            f.write_text("\n".join(lines), encoding="utf-8")
            files += 1
    print(f"files={files} void_restored={fixed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

#!/usr/bin/env python3
"""Repair ILSpy type placeholders that are not valid C#: `(??)` casts and `? name` locals."""
import re
import sys
from pathlib import Path

RULES = [
    (re.compile(r"\(\(\?\?\)"), "((object)"),
    (re.compile(r"(?m)^([ \t]*)\?\s+([A-Za-z_][A-Za-z0-9_]*)\s*;"), r"\1object \2 = null;"),
    (re.compile(r"(?m)^([ \t]*)\?\s+([A-Za-z_][A-Za-z0-9_]*)\s*="), r"\1object \2 ="),
]


def main() -> int:
    src = Path(sys.argv[1])
    files = hits = 0
    for f in src.glob("*.cs"):
        t = f.read_text(encoding="utf-8", errors="replace")
        raw = t
        n = 0
        for rx, rep in RULES:
            t, k = rx.subn(rep, t)
            n += k
        if t != raw:
            f.write_text(t, encoding="utf-8")
            files += 1
            hits += n
    print(f"files={files} placeholders_fixed={hits}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

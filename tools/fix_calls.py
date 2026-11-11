#!/usr/bin/env python3
"""Fix residual decompiler call shapes: (T)null, explicit accessor calls, explicit operators."""
import re
import sys
from pathlib import Path

RULES = [
    (re.compile(r"\((T_[A-Za-z0-9_]+)\)null\b"), r"default(\1)"),
    (re.compile(r"([A-Za-z_][A-Za-z0-9_.]*)\.get_([A-Za-z_][A-Za-z0-9_]*)\(\)"), r"\1.\2"),
    (re.compile(r"\bop_Implicit\(([^()]*)\)"), r"\1"),
    (re.compile(r"\bop_Explicit\(([^()]*)\)"), r"\1"),
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
    print(f"files={files} calls_fixed={hits}")
    return 0

if __name__ == "__main__":
    sys.exit(main())

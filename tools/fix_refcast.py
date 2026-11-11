#!/usr/bin/env python3
"""Collapse `((T)(ref X))` receivers left by ILSpy pointer recovery; C# has no such cast.
usage: fix_refcast.py <src-dir>
"""
import re
import sys
from pathlib import Path

RX = re.compile(r"\(\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(ref\s+([^()]+?)\)\)")

def main() -> int:
    src = Path(sys.argv[1])
    files = hits = 0
    for f in src.glob("*.cs"):
        t = f.read_text(encoding="utf-8", errors="replace")
        out, n = RX.subn(r"\2", t)
        if n:
            f.write_text(out, encoding="utf-8")
            files += 1
            hits += n
    print(f"files={files} refcasts_fixed={hits}")
    return 0

if __name__ == "__main__":
    sys.exit(main())

#!/usr/bin/env python3
"""Fix the Visibility rewrite: `(cond ? 1 : 0)` already selects the enum value; map it directly."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1])
A = re.compile(r"\(\((.*?)\) \? 1 : 0\) \? Visibility\.Visible : Visibility\.Collapsed")
B = re.compile(r"\(\((.*?)\) \? 0 : 1\) \? Visibility\.Visible : Visibility\.Collapsed")
C = re.compile(r"\((.*?) \? 1 : 0\) \? Visibility\.Visible : Visibility\.Collapsed")
D = re.compile(r"\((.*?) \? 0 : 1\) \? Visibility\.Visible : Visibility\.Collapsed")

n = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    raw = t
    for _ in range(4):
        t, a = A.subn(r"(\1) ? Visibility.Visible : Visibility.Collapsed", t)
        t, b = B.subn(r"(\1) ? Visibility.Collapsed : Visibility.Visible", t)
        t, c = C.subn(r"(\1) ? Visibility.Visible : Visibility.Collapsed", t)
        t, d = D.subn(r"(\1) ? Visibility.Collapsed : Visibility.Visible", t)
        n += a + b + c + d
        if not (a or b or c or d):
            break
    if t != raw:
        f.write_text(t, encoding="utf-8")
print(f"visibility_fixed={n}")

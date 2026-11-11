#!/usr/bin/env python3
"""Ninth pass: decimal interpolation artefacts and object locals involved in operator/conversion errors."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1]); LOG = Path(sys.argv[2])

def entries(codes):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error (CS\d+):(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m and m.group(3) in codes:
            out.append((Path(line[:m.start()]), int(m.group(1)), int(m.group(2)), m.group(3), m.group(4)))
    return out

# decimal.<local> artefacts from interpolated formatting
dec = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"\bdecimal\.(current|num|val|i|j|k|result)\b", r"\1", t)
    if n:
        f.write_text(t2, encoding="utf-8"); dec += n

# object locals used with operators/members/conversions -> dynamic
dyn = 0
for f, ln, col, code, msg in entries({"CS0019", "CS0023", "CS0026", "CS0266", "CS1061", "CS0029"}):
    if "object" not in msg and "dynamic" not in msg:
        continue
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", line)
    t = f.read_text(encoding="utf-8", errors="replace")
    changed = False
    for var in ids:
        pat = re.compile(r"(?m)^([ \t]*)object[ \t]+" + re.escape(var) + r"[ \t]*=")
        if pat.search(t):
            t = pat.sub(lambda m: f"{m.group(1)}dynamic {var} =", t, count=1)
            changed = True
            break
    if changed:
        f.write_text(t, encoding="utf-8"); dyn += 1

print(f"decimal_fixed={dec} dynamic_locals={dyn}")

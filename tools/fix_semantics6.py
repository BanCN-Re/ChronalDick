#!/usr/bin/env python3
"""Sixth pass: WinUI object-locals via dynamic fallback, plus the MainWindow AppWindow local."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1])
LOG = Path(sys.argv[2])


def entries(code):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error " + code + ":(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m:
            out.append((Path(line[:m.start()]), int(m.group(1)), int(m.group(2)), m.group(3)))
    return out


# MainWindow: the local holds AppWindow; retype it so Closing/SetIcon/Presenter resolve statically
mw = SRC / "MainWindow.cs"
if mw.exists():
    t = mw.read_text(encoding="utf-8", errors="replace")
    t = t.replace(
        "object obj = (_appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(",
        "Microsoft.UI.Windowing.AppWindow obj = (_appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(")
    mw.write_text(t, encoding="utf-8")

# Generic fallback: unknown member on an object-typed receiver -> dynamic dispatch at runtime
n = 0
for f, ln, col, msg in entries("CS1061"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    m = re.search(r"“([A-Za-z_][A-Za-z0-9_]*)”未包含“(.*?)”", msg)
    if not m:
        continue
    member = m.group(2)
    best = None
    for mm in re.finditer(r"(\(?)\b([A-Za-z_][A-Za-z0-9_]*)\b(\)?)\s*\.\s*" + re.escape(member) + r"\b", line):
        if mm.start() < col:
            best = mm
    if not best:
        continue
    if "((dynamic)" in line[max(0, best.start() - 12):best.start() + 4]:
        continue
    var = best.group(2)
    lines[ln - 1] = line[:best.start()] + f"((dynamic){var}).{member}" + line[best.end():]
    f.write_text("\n".join(lines), encoding="utf-8")
    n += 1

print(f"dynamic_receivers={n}")

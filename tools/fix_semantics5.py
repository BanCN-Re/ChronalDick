#!/usr/bin/env python3
"""Fifth pass: cast object receivers at use sites (CS1061) and repair ref-object locals (CS1503)."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1]); LOG = Path(sys.argv[2])
MAP = {
    "TryEnqueue": "Microsoft.UI.Dispatching.DispatcherQueue",
    "DispatcherQueue": "Microsoft.UI.Xaml.UIElement",
    "Uri": "Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs",
    "Arguments": "Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs",
    "Length": "string",
}

def entries(code):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error " + code + ":(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m:
            out.append((Path(line[:m.start()]), int(m.group(1)), int(m.group(2)), m.group(3)))
    return out

n_cast = 0
for f, ln, col, msg in entries("CS1061"):
    mem = None
    for k in MAP:
        if k in msg:
            mem = k; break
    if not mem:
        continue
    typ = MAP[mem]
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    best = None
    for m in re.finditer(r"(\(?)\b([A-Za-z_][A-Za-z0-9_]*)\b(\)?)\s*\.\s*" + mem + r"\b", line):
        if m.start() < col:
            best = m
    if not best:
        continue
    var = best.group(2)
    lines[ln - 1] = line[:best.start()] + f"(({typ}){var}).{mem}" + line[best.end():]
    f.write_text("\n".join(lines), encoding="utf-8")
    n_cast += 1

# CS1503: ref object -> ref bool; change the local declaration to bool
n_bool = 0
for f, ln, col, msg in entries("CS1503"):
    if "ref" not in msg:
        continue
    m = re.search(r"ref (bool|int|long|double)\b", msg)
    if not m:
        continue
    typ = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    vm = re.search(r"ref\s+([A-Za-z_][A-Za-z0-9_]*)", line)
    if not vm:
        continue
    var = vm.group(1)
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)object[ \t]+" + re.escape(var) + r"[ \t]*=[ \t]*[^;]+;",
                    rf"\1{typ} {var} = default;", t, count=1)
    if n:
        f.write_text(t2, encoding="utf-8"); n_bool += 1

print(f"receiver_casts={n_cast} ref_locals={n_bool}")

#!/usr/bin/env python3
"""Mechanical semantic repairs driven by the compiler log (CS0030/0571/0079/0177/0122/0103/1061)."""
import re
import sys
from collections import defaultdict
from pathlib import Path

LOG = Path(sys.argv[2]) if len(sys.argv) > 2 else Path("/tmp/build40.log")
SRC = Path(sys.argv[1])

def entries(code):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error " + code + ":")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if not m:
            continue
        head = line[:m.start()]
        msg = line[m.end():].strip()
        out.append((Path(head), int(m.group(1)), int(m.group(2)), msg))
    return out

stats = defaultdict(int)

# 1) qiPow pointer arithmetic (file-specific; IL used byte* + ldind)
q = SRC / "qiPowfLrI8h0QeonOQ0X.cs"
if q.exists():
    t = q.read_text(encoding="utf-8", errors="replace")
    t = t.replace("object obj = 0;", "double obj = 0;")
    t = t.replace("object obj2 = (object)P_0;", "nint obj2 = (nint)P_0;")
    t = re.sub(r"\(short\*\)\(nint\)\(obj2 \+ (\d+)\)", r"(short*)((byte*)obj2 + \1)", t)
    t = re.sub(r"\*\(short\*\)\(nint\)obj2", "*(short*)((byte*)obj2)", t)
    q.write_text(t, encoding="utf-8"); stats["qipow"] += 1

# 2) explicit accessor calls
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace"); raw = t
    t, n1 = re.subn(r"\.set_([A-Za-z_][A-Za-z0-9_]*)\(([^();]*)\)", r".\1 = \2", t)
    t, n2 = re.subn(r"\.add_([A-Za-z_][A-Za-z0-9_]*)\(([^();]*)\)", r".\1 += \2", t)
    t, n3 = re.subn(r"\.remove_([A-Za-z_][A-Za-z0-9_]*)\(([^();]*)\)", r".\1 -= \2", t)
    stats["set"] += n1; stats["add"] += n2; stats["remove"] += n3
    if t != raw: f.write_text(t, encoding="utf-8")

# 3) bool -> Visibility, targeted at CS0030 bool/Visibility errors
for f, ln, col, msg in entries("CS0030"):
    if "Visibility" not in msg: continue
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln-1 >= len(lines): continue
    line = lines[ln-1]
    new, n = re.subn(r"\(Visibility\)\(([^()]*)\)",
                     lambda m: f"(({m.group(1)}) ? Visibility.Visible : Visibility.Collapsed)", line, count=1)
    if n:
        lines[ln-1] = new; f.write_text("\n".join(lines), encoding="utf-8"); stats["visibility"] += n

# 4) App: the AppDomain handler uses the System event args, not WinUI's
app = SRC / "App.cs"
if app.exists():
    t = app.read_text(encoding="utf-8", errors="replace")
    t = t.replace("public static Microsoft.UI.Xaml.UnhandledExceptionEventHandler _2___OnAppDomainUnhandledException;",
                  "public static System.UnhandledExceptionEventHandler _2___OnAppDomainUnhandledException;")
    t = t.replace("OnAppDomainUnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)",
                  "OnAppDomainUnhandledException(object sender, System.UnhandledExceptionEventArgs e)")
    t = t.replace("new Microsoft.UI.Xaml.UnhandledExceptionEventHandler(OnAppDomainUnhandledException)",
                  "new System.UnhandledExceptionEventHandler(OnAppDomainUnhandledException)")
    app.write_text(t, encoding="utf-8")

# 5) CS0079: reading own event through the type name -> bare name
for f, ln, col, msg in entries("CS0079"):
    m = re.search(r"“([\w.]+)”", msg)
    if not m: continue
    full = m.group(1); ev = full.rsplit(".", 1)[-1]
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(re.escape(full) + r"\b", ev, t)
    if n: f.write_text(t2, encoding="utf-8"); stats["event_self"] += n

# 6) CS0177: assign out parameters at method start
for f, ln, col, msg in entries("CS0177"):
    m = re.search(r"“([^”]+)”", msg)
    if not m: continue
    param = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln-1 >= len(lines): continue
    j = ln
    while j < len(lines) and lines[j].strip() != "{": j += 1
    if j < len(lines):
        indent = re.match(r"[ \t]*", lines[j]).group(0) + "\t"
        lines.insert(j+1, f"{indent}{param} = default;")
        f.write_text("\n".join(lines), encoding="utf-8"); stats["out_assign"] += 1

# 7) CS0122: make the referenced private member public
for f, ln, col, msg in entries("CS0122"):
    m = re.search(r"“([\w.]+)”", msg)
    if not m: continue
    member = m.group(1).rsplit(".", 1)[-1]
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    changed = False
    for i, line in enumerate(lines):
        if member in line and re.search(r"\b(private|protected)\b", line):
            lines[i] = re.sub(r"\b(private|protected)\b", "public", line, count=1); changed = True
    if changed: f.write_text("\n".join(lines), encoding="utf-8"); stats["access"] += 1

# 8) `global::` inside interpolation holes is not accepted here
for f, ln, col, msg in entries("CS0103"):
    if "“global”" not in msg: continue
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln-1 < len(lines):
        lines[ln-1] = lines[ln-1].replace("{global::", "{")
        f.write_text("\n".join(lines), encoding="utf-8"); stats["interp_global"] += 1

print(" ".join(f"{k}={v}" for k, v in sorted(stats.items())))

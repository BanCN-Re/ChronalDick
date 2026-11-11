#!/usr/bin/env python3
"""Twelfth pass: QRCoder nested enums, missing backing field, XAML Block cast,
ref-bool lock local, and definite-assignment repairs at labels."""
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


# 1) QRCoder enums are nested in QRCodeGenerator
qr = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2 = t.replace("QRCoder.ECCLevel", "QRCodeGenerator.ECCLevel").replace("QRCoder.EciMode", "QRCodeGenerator.EciMode")
    if t2 != t:
        f.write_text(t2, encoding="utf-8")
        qr += 1

# 2) NavigationEntry: PageType auto-property is missing its backing field
nav = SRC / "NavigationEntry.cs"
if nav.exists():
    t = nav.read_text(encoding="utf-8", errors="replace")
    if "_PageType_k__BackingField;" not in t:
        t = t.replace("\t[field: CompilerGenerated]\n\tpublic global::System.Type PageType",
                      "\tprivate global::System.Type _PageType_k__BackingField;\n\n\t[field: CompilerGenerated]\n\tpublic global::System.Type PageType")
        nav.write_text(t, encoding="utf-8")

# 3) Announcement: the Paragraph is a XAML Block, not a Markdig one
ann = SRC / "AnnouncementMarkdownRenderer.cs"
if ann.exists():
    t = ann.read_text(encoding="utf-8", errors="replace")
    t = t.replace("val.Blocks.Add((Markdig.Syntax.Block)(object)val2);",
                  "val.Blocks.Add((Microsoft.UI.Xaml.Documents.Block)(object)val2);")
    ann.write_text(t, encoding="utf-8")

# 4) AppShell RegisterDisposable: lock state must be bool
app = SRC / "AppShell.cs"
if app.exists():
    lines = app.read_text(encoding="utf-8", errors="replace").split("\n")
    for i, line in enumerate(lines):
        if "Monitor.Enter(disposables, ref obj)" in line:
            j = i
            while j >= 0 and "object obj =" not in lines[j]:
                j -= 1
            if j >= 0:
                lines[j] = re.sub(r"object obj =", "bool obj =", lines[j], count=1)
                lines[j] = re.sub(r"= __O_12\._0___OnAuthenticationExpired;", "= false;", lines[j])
    app.write_text("\n".join(lines), encoding="utf-8")

# 5) CS0165 inside async MoveNext: assign the local at the jump label
n5 = 0
for f, ln, col, msg in entries("CS0165"):
    msg = msg.split("[")[0]
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", msg)
    if not ids:
        continue
    var = ids[-1]
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    idx = min(ln - 1, len(lines) - 1)
    label = None
    for j in range(idx, max(-1, idx - 80), -1):
        if re.match(r"^[ \t]*IL_[0-9A-Fa-f]+:", lines[j]):
            label = j
            break
    if label is not None:
        indent = re.match(r"[ \t]*", lines[label]).group(0) + "\t"
        if f"{var} = default;" not in lines[label + 1] if label + 1 < len(lines) else True:
            lines.insert(label + 1, f"{indent}{var} = default;")
            f.write_text("\n".join(lines), encoding="utf-8")
            n5 += 1

print(f"qrcoder={qr} label_defaults={n5}")

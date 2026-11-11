#!/usr/bin/env python3
"""Tenth pass: awaiter locals, balanced Visibility, Unsafe.As stores, enum case labels,
StringBuilder interpolation handler, QRCodeData and decimal-prefix artefacts."""
import re
import sys
from pathlib import Path

from rewrite_helpers import match_paren

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


# 1) awaiter locals declared without initializer
awa = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)([A-Za-z_][A-Za-z0-9_.<>?,]*)[ \t]+(_u__\d*|__u__\d*)[ \t]*;$",
                    r"\1\2 \3 = default;", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        awa += n

# 2) balanced (Visibility)(expr) -> ternary
vis = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    i = 0
    while True:
        idx = t.find("(Visibility)(", i)
        if idx < 0:
            break
        open_paren = idx + len("(Visibility)")
        try:
            close = match_paren(t, open_paren)
        except ValueError:
            break
        inner = t[open_paren + 1:close]
        repl = f"(({inner}) ? Visibility.Visible : Visibility.Collapsed)"
        t = t[:idx] + repl + t[close + 1:]
        vis += 1
        i = idx + len(repl)
    f.write_text(t, encoding="utf-8")

# 3) Unsafe.As<T,U>(ref X) = expr;  ->  X = default;
unsafe_n = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"global::System\.Runtime\.CompilerServices\.Unsafe\.As<[^>]+>\(ref ([A-Za-z_][A-Za-z0-9_.]*)\) = [^;]+;",
                    r"\1 = default;", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        unsafe_n += n

# 4) enum switch case labels: case 1: -> case (EnumType)1:
case_n = 0
for f, ln, col, msg in entries("CS0266"):
    m = re.search(r"“int”[^”]*“([A-Za-z_][A-Za-z0-9_.]+)”", msg)
    if not m:
        continue
    typ = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    new, n = re.subn(r"^([ \t]*)case[ \t]+(-?\d+):", rf"\1case ({typ})\2:", line)
    if n:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        case_n += n

# 5) object awaiter locals -> dynamic
dyn = 0
for f, ln, col, msg in entries("CS1061"):
    if "IsCompleted" not in msg and "GetResult" not in msg:
        continue
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    m = re.search(r"\b(_u__\d*|__u__\d*)\b", lines[ln - 1])
    if not m:
        continue
    var = m.group(1)
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)object[ \t]+" + re.escape(var) + r"\b", rf"\1dynamic {var}", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        dyn += n

# 6) QRCodeData belongs to QRCoder
qr = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?<![\w.])QRCodeData\b", "QRCoder.QRCodeData", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        qr += n

# 7) spurious `decimal.` before lowercase identifiers (fields/locals)
dec = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"\bdecimal\.(?=[a-z_])", "", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        dec += n

# 8) StringBuilder interpolated string handler type
sbh = 0
p = SRC / "BedrockMaterialPackConverterPage.cs"
if p.exists():
    t = p.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?<![\w.])AppendInterpolatedStringHandler\b", "StringBuilder.AppendInterpolatedStringHandler", t)
    if n:
        p.write_text(t2, encoding="utf-8")
        sbh += n

print(f"awaiters={awa} visibility={vis} unsafe_as={unsafe_n} case_casts={case_n} "
      f"dynamic_awaiter={dyn} qrcode={qr} decimal_prefix={dec} sb_handler={sbh}")

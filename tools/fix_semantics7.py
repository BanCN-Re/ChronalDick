#!/usr/bin/env python3
"""Seventh pass: purge bogus insertions, fix generic Enumerator locals, qualify enum types,
initialize flagged locals/out parameters."""
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


def msg_body(msg: str) -> str:
    return msg.split("[")[0]


# 1) bogus `csproj = default;` from an earlier out-parameter pass
removed = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^[ \t]*csproj[ \t]*=[^\n]*\r?\n", "", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        removed += n

# 2) `x..ctor(...)` statement artifacts
ctor = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^[ \t]*[A-Za-z_][A-Za-z0-9_.]*\.\.ctor\([^;\n]*\);[ \t]*\r?\n", "", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        ctor += n

# 3) generic Enumerator locals -> var
enum = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"\bEnumerator<[^;\n()]*?>\s+([A-Za-z_][A-Za-z0-9_]*)\s*=", r"var \1 =", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        enum += n

# 4) enum/type qualifications
qual = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace"); raw = t
    t = re.sub(r"(?<![\w.])SpecialFolder\b", "System.Environment.SpecialFolder", t)
    t = re.sub(r"(?<![\w.])ECCLevel\b", "QRCoder.ECCLevel", t)
    t = re.sub(r"(?<![\w.])EciMode\b", "QRCoder.EciMode", t)
    if t != raw:
        f.write_text(t, encoding="utf-8")
        qual += 1

# 5) CS0165: initialize the flagged local
init = 0
for f, ln, col, msg in entries("CS0165"):
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", msg_body(msg))
    if not ids:
        continue
    var = ids[-1]
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)([A-Za-z_][A-Za-z0-9_.<>?,\[\] ]*?)[ \t]+" + re.escape(var) + r"[ \t]*;",
                    r"\1\2 " + var + r" = default;", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        init += n

# 6) CS0269: initialize the out parameter at the start of its enclosing method
outini = 0
for f, ln, col, msg in entries("CS0269"):
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", msg_body(msg))
    if not ids:
        continue
    param = ids[-1]
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    start = min(ln - 1, len(lines) - 1)
    j = start
    while j >= 0 and not lines[j].rstrip().endswith(")"):
        j -= 1
    if j < 0:
        continue
    k = j + 1
    while k < len(lines) and lines[k].strip() != "{":
        k += 1
    if k < len(lines):
        indent = re.match(r"[ \t]*", lines[k]).group(0) + "\t"
        lines.insert(k + 1, f"{indent}{param} = default;")
        f.write_text("\n".join(lines), encoding="utf-8")
        outini += 1

print(f"csproj_lines={removed} ctor_artifacts={ctor} enum_locals={enum} qualified_files={qual} "
      f"init_locals={init} out_inits={outini}")

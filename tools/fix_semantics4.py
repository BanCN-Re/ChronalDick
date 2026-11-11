#!/usr/bin/env python3
"""Fourth semantic pass, driven by the latest compiler log."""
import re
import sys
from pathlib import Path

from rewrite_helpers import match_paren, split_args

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


# CS1620: ensure the argument carries the exact required keyword (ref or out)
n_ref = 0
for f, ln, col, msg in entries("CS1620"):
    m = re.search(r"参数 (\d+) .*?(ref|out)", msg)
    if not m:
        continue
    idx, kw = int(m.group(1)) - 1, m.group(2)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    best = None
    for i, ch in enumerate(line):
        if ch != "(" or i > col:
            continue
        try:
            close = match_paren(line, i)
        except ValueError:
            continue
        if close >= col and (best is None or i > best[0]):
            best = (i, close)
    if best is None:
        continue
    op, cl = best
    args = split_args(line[op + 1:cl])
    if idx >= len(args):
        continue
    arg = re.sub(r"^(ref|out|in)\s+", "", args[idx])
    args[idx] = kw + " " + arg
    lines[ln - 1] = line[:op + 1] + ", ".join(args) + line[cl:]
    f.write_text("\n".join(lines), encoding="utf-8")
    n_ref += 1

# CS0165: initialize the flagged local at its declaration
n_init = 0
for f, ln, col, msg in entries("CS0165"):
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", msg)
    if not ids:
        continue
    var = ids[-1]
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)([A-Za-z_][A-Za-z0-9_.<>?,\[\] ]*?)[ \t]+" + re.escape(var) + r"[ \t]*;",
                    r"\1\2 " + var + r" = default;", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        n_init += n

# CS0269: out parameter used before assignment -> init at method entry
n_out = 0
for f, ln, col, msg in entries("CS0269"):
    ids = re.findall(r"[A-Za-z_][A-Za-z0-9_]*", msg)
    if not ids:
        continue
    param = ids[-1]
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    j = ln
    while j < len(lines) and lines[j].strip() != "{":
        j += 1
    if j < len(lines):
        indent = re.match(r"[ \t]*", lines[j]).group(0) + "\t"
        lines.insert(j + 1, f"{indent}{param} = default;")
        f.write_text("\n".join(lines), encoding="utf-8")
        n_out += 1

# CS0030: (T)(long)expr where expr is already T; plus the isinst placeholder
n_cast = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace"); raw = t
    t = re.sub(r"\(([A-Za-z_][A-Za-z0-9_.<>]*)\)\(long\)", r"(\1)", t)
    t = t.replace("(Style)/*isinst with value type is only supported in some contexts*/", "null")
    if t != raw:
        f.write_text(t, encoding="utf-8"); n_cast += 1

# CS1929: `await <awaiterVar>;` -> `<awaiterVar>.GetResult();`
n_await = 0
for f, ln, col, msg in entries("CS1929"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    m = re.match(r"^([ \t]*)await ([A-Za-z_][A-Za-z0-9_]*);[ \t]*$", lines[ln - 1])
    if m:
        lines[ln - 1] = f"{m.group(1)}{m.group(2)}.GetResult();"
        f.write_text("\n".join(lines), encoding="utf-8"); n_await += 1

# a few concrete type repairs surfaced by CS1061/CS1540
app = SRC / "App.cs"
if app.exists():
    t = app.read_text(encoding="utf-8", errors="replace")
    t = t.replace("object obj = ht67KuL5y2wMk87Qy0yy.RPqLKGHxrab(", "string obj = ht67KuL5y2wMk87Qy0yy.RPqLKGHxrab(")
    t = t.replace("object obj2 = Kd4ZX3L5J4ICkvNmc7lt.RPqLKGHxrab(", "string obj2 = Kd4ZX3L5J4ICkvNmc7lt.RPqLKGHxrab(")
    t = t.replace("object obj2 = ((window != null) ? (window).DispatcherQueue : null);",
                  "Microsoft.UI.Dispatching.DispatcherQueue obj2 = ((window != null) ? (window).DispatcherQueue : null);")
    app.write_text(t, encoding="utf-8")
h = SRC / "HookLoginPage.cs"
if h.exists():
    t = h.read_text(encoding="utf-8", errors="replace")
    t = t.replace("((Page)this).OnNavigatedFrom(e);", "base.OnNavigatedFrom(e);")
    h.write_text(t, encoding="utf-8")
# Unsafe.As<T,U>(ref X) = (long)null;  ->  X = default;
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2 = re.sub(r"global::System\.Runtime\.CompilerServices\.Unsafe\.As<[^>]+>\(ref ([A-Za-z_][A-Za-z0-9_.]*)\) = \(long\)null;",
                r"\1 = default;", t)
    if t2 != t:
        f.write_text(t2, encoding="utf-8")

print(f"ref/out={n_ref} init_locals={n_init} out_init={n_out} cast_files={n_cast} await_getresult={n_await}")

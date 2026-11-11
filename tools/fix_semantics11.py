#!/usr/bin/env python3
"""Eleventh pass: awaitable-vs-awaiter types, enum switch arms/arithmetic, ref locals,
Unsafe.As stores, bool-to-enum casts, QRCoder type."""
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


# 1) `_u__` holds the *awaiter*, not the awaitable
n = 0
for f in SRC.glob("*.cs"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    changed = False
    for i, line in enumerate(lines):
        if "_u__" not in line and "AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable" not in line:
            continue
        new, k = re.subn(r"ConfiguredTaskAwaitable<([^<>]*(?:<[^<>]*>[^<>]*)*)>(?!\.ConfiguredTaskAwaiter)",
                         r"ConfiguredTaskAwaitable<\1>.ConfiguredTaskAwaiter", line)
        if k:
            lines[i] = new; n += k; changed = True
    if changed:
        f.write_text("\n".join(lines), encoding="utf-8")

# 2) enum switch-expression arms: `1 => ...`
n2 = 0
for f, ln, col, msg in entries("CS0266"):
    m = re.search(r"“int”[^”]*“([A-Za-z_][A-Za-z0-9_.]+)”", msg)
    if not m:
        continue
    typ = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    new, k = re.subn(r"^([ \t]*)(-?\d+)([ \t]*=>)", rf"\1({typ})\2\3", lines[ln - 1])
    if k:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        n2 += k

# 3) enum arithmetic: ident - int / ident | int
n3 = 0
for f, ln, col, msg in entries("CS0019"):
    m = re.search(r"“([A-Za-z_][A-Za-z0-9_.]*)”和“int”", msg)
    if not m:
        continue
    typ = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    new, k = re.subn(r"(?<![\w.)])" + r"([A-Za-z_][A-Za-z0-9_]*)\s*([-+*/%|&^])\s*(-?\d+)",
                     r"(int)\1 \2 \3", line)
    if k:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        n3 += k

# 4) ref locals with non-ref initializer
n4 = 0
for f, ln, col, msg in entries("CS8172"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    new, k = re.subn(r"^([ \t]*)ref[ \t]+", r"\1", lines[ln - 1])
    if k:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        n4 += k

# 5) Unsafe.As<T,U>(ref X) = expr;  (generic args may nest)
n5 = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, k = re.subn(r"global::System\.Runtime\.CompilerServices\.Unsafe\.As<.*?>\(ref ([A-Za-z_][A-Za-z0-9_.]*)\) = [^;]+;",
                    r"\1 = default;", t)
    if k:
        f.write_text(t2, encoding="utf-8")
        n5 += k

# 6) bool expression cast to an enum type -> ternary with 1/0
n6 = 0
for f, ln, col, msg in entries("CS0030"):
    m = re.search(r"“bool”转换为“([A-Za-z_][A-Za-z0-9_.]*)”", msg)
    if not m:
        continue
    typ = m.group(1)
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    new, k = re.subn(r"\(" + re.escape(typ) + r"\)(\([^;]*?\))(?=[;,)\s])",
                     rf"((\1) ? ({typ})1 : ({typ})0)", line)
    if k:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        n6 += k

print(f"awaiters={n} switch_arms={n2} enum_math={n3} ref_locals={n4} unsafe_as={n5} bool_enum={n6}")

#!/usr/bin/env python3
"""Mahiro semantic batch 1: constructors, static classes, operators, required members,
read-only wrappers, failed-type usings, assembly attributes, new modifiers, async visibility."""
import re
import shutil
import sys
from pathlib import Path

from csbraces import deltas

SRC = Path(sys.argv[1])
LOG = Path(sys.argv[2])
TOOLS = Path(__file__).resolve().parent


def entries(code):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error " + code + r":(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m:
            out.append((Path(line[:m.start()]), int(m.group(1)), int(m.group(2)), m.group(3)))
    return out


def owners(lines):
    bd = deltas("\n".join(lines))
    scopes = []
    decl = re.compile(r"^(?P<indent>[ \t]*)(?:(?:public|private|internal|protected|static|sealed|abstract|partial|unsafe|readonly|ref)[ \t]+)*"
                      r"(?:class|struct|record(?:[ \t]+(?:class|struct))?)[ \t]+(?P<name>[A-Za-z_][A-Za-z0-9_]*)[^;{]*$")
    for i, line in enumerate(lines):
        m = decl.match(line)
        if not m:
            continue
        j = i + 1
        while j < len(lines) and not lines[j].strip():
            j += 1
        if j >= len(lines) or not lines[j].strip().startswith("{"):
            continue
        depth, k = 0, j
        while k < len(lines):
            depth += bd[k]
            if depth == 0:
                break
            k += 1
        scopes.append((i, k, m.group("name")))
    owner = [None] * len(lines)
    for s, e, n in sorted(scopes, key=lambda x: x[1] - x[0]):
        for li in range(s, min(e, len(lines) - 1) + 1):
            if owner[li] is None:
                owner[li] = n
    return owner


# 1) constructors emitted as `void TypeName(...)`
ctor = 0
for f in SRC.glob("*.cs"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    own = owners(lines)
    changed = False
    for i, line in enumerate(lines):
        o = own[i]
        if not o:
            continue
        m = re.match(r"^(?P<pre>.*?)\bvoid[ \t]+" + re.escape(o) + r"[ \t]*\(", line)
        if m:
            lines[i] = m.group("pre") + o + "(" + line[m.end():]
            ctor += 1
            changed = True
    if changed:
        f.write_text("\n".join(lines), encoding="utf-8")

# 2) static classes used as types -> ordinary classes
names = set()
for code in ("CS0722", "CS0723"):
    for f, ln, col, msg in entries(code):
        m = re.search(r"“([A-Za-z_][A-Za-z0-9_]*)”", msg)
        if m:
            names.add(m.group(1))
des = 0
if names:
    pat = re.compile(r"\bstatic\s+class\s+(" + "|".join(map(re.escape, names)) + r")\b")
    for f in SRC.glob("*.cs"):
        t = f.read_text(encoding="utf-8", errors="replace")
        t2, n = pat.subn(r"class \1", t)
        if n:
            f.write_text(t2, encoding="utf-8")
            des += n

# 3) operators whose parameters are object? -> enclosing type
op = 0
for f, ln, col, msg in entries("CS0563"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 >= len(lines):
        continue
    own = owners(lines)
    o = own[ln - 1]
    if not o:
        continue
    new, n = re.subn(r"\(object\? ([A-Za-z_]\w*), object\? ([A-Za-z_]\w*)\)",
                     rf"({o}? \1, {o}? \2)", lines[ln - 1])
    if n:
        lines[ln - 1] = new
        f.write_text("\n".join(lines), encoding="utf-8")
        op += n

# 4) [RequiredMember] without `required`
req = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^[ \t]*\[RequiredMember\][ \t]*\r?\n", "", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        req += n

# 5) generated read-only collection wrappers
wr = 0
for name in ("__z__ReadOnlyArray_1.cs", "__z__ReadOnlySingleElementList_1.cs"):
    src = TOOLS / "assets" / name
    if src.exists():
        shutil.copy(src, SRC / name)
        wr += 1

# 6) usings for the five types that failed export
failed = ["KLKMEGXjFrFb9t3VaG3s", "Y9IOPZ2Or6f8KVLXj8N", "HxN1X4XfXnwG7LtgpU7q",
          "PqT7S6XPctmkx9ia0m4o", "ilOrlDXHcN1uPq9DGB2O"]
us = 0
for f in SRC.glob("*.cs"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    out = []
    changed = False
    for line in lines:
        m = re.match(r"^[ \t]*using\s+([A-Za-z_][A-Za-z0-9_.]*)\s*;\s*$", line)
        if m and m.group(1) in failed:
            out.append(f"// using {m.group(1)}; // type failed to export (BadImageFormatException)")
            changed = True
            us += 1
            continue
        out.append(line)
    if changed:
        f.write_text("\n".join(out), encoding="utf-8")

# 7) assembly attributes the SDK generates itself
asm = SRC / "AssemblyInfo.cs"
if asm.exists():
    t = asm.read_text(encoding="utf-8", errors="replace")
    t = re.sub(r"(?m)^.*(?:TargetFramework|RefSafetyRules).*\r?\n", "", t)
    asm.write_text(t, encoding="utf-8")

# 8) invalid `new` modifiers
nw = 0
for f, ln, col, msg in entries("CS0106"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 < len(lines):
        new, n = re.subn(r"\bnew\s+", "", lines[ln - 1], count=1)
        if n:
            lines[ln - 1] = new
            f.write_text("\n".join(lines), encoding="utf-8")
            nw += n

# 9) async state machine interface visibility
av = 0
for f, ln, col, msg in entries("CS0737"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 < len(lines):
        if "public" not in lines[ln - 1]:
            new, n = re.subn(r"^([ \t]*)(?!(?:public|private|protected|internal)\b)", r"\1public ", lines[ln - 1])
            if n:
                lines[ln - 1] = new
                f.write_text("\n".join(lines), encoding="utf-8")
                av += n

print(f"ctors={ctor} destatic={des} operators={op} required={req} wrappers={wr} usings={us} new={nw} async={av}")

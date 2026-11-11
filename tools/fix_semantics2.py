#!/usr/bin/env python3
"""Second semantic pass: balanced accessor calls, event self-reads, missing backing fields."""
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
            out.append((Path(line[:m.start()]), msg := m.group(3)))  # noqa: F841
    return out

# 1) balanced `.set_X(...)` / `.add_X(...)` / `.remove_X(...)`
ACC = re.compile(r"\.(set|add|remove)_([A-Za-z_][A-Za-z0-9_]*)\(")
changed = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    i = 0
    while True:
        m = ACC.search(t, i)
        if not m:
            break
        try:
            close = match_paren(t, m.end() - 1)
        except ValueError:
            break
        inner = t[m.end():close]
        op = {"set": " = ", "add": " += ", "remove": " -= "}[m.group(1)]
        repl = "." + m.group(2) + op + inner
        t = t[:m.start()] + repl + t[close + 1:]
        changed += 1
        i = m.start() + len(repl)
    f.write_text(t, encoding="utf-8")
print("accessor_calls=", changed)

# 2) event self-read: parse the event full name from the message without relying on quote glyphs
ev = 0
for f, msg in entries("CS0079"):
    toks = re.findall(r"[A-Za-z_][A-Za-z0-9_.]*", msg)
    full = next((x for x in toks if "." in x), None)
    if not full:
        continue
    bare = full.rsplit(".", 1)[-1]
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(re.escape(full) + r"\b", bare, t)
    if n:
        f.write_text(t2, encoding="utf-8")
        ev += n
print("event_self=", ev)

# 3) backing fields: infer the property type and declare the missing field before the property
fields = 0
for f, msg in entries("CS0103"):
    m = re.search(r"(_[A-Za-z0-9_]+_k__BackingField)", msg)
    if not m:
        continue
    field = m.group(1)
    prop = field[1:-len("_k__BackingField")]
    t = f.read_text(encoding="utf-8", errors="replace")
    if re.search(r"\b" + re.escape(field) + r"\b\s*[;=,]", t):
        continue
    pm = re.search(r"(?m)^([ \t]*)(public|internal|protected|private)?[ \t]*([A-Za-z_][A-Za-z0-9_.<>\[\],? \t]*?)[ \t]+" + re.escape(prop) + r"\b[ \t]*\r?\n?[ \t]*\{", t)
    if not pm:
        continue
    typ = pm.group(3).strip()
    decl = f"{pm.group(1)}private {typ} {field};\n"
    t = t[:pm.start()] + decl + t[pm.start():]
    f.write_text(t, encoding="utf-8")
    fields += 1
print("backing_fields=", fields)

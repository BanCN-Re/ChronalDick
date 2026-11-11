#!/usr/bin/env python3
"""Mahiro semantic batch 3: nested type accessibility, enumerator interface alignment,
static extension classes, optional-before-ref parameters, obsolete attributes."""
import re
import sys
from pathlib import Path

from csbraces import deltas

SRC = Path(sys.argv[1]); LOG = Path(sys.argv[2])


def entries(code):
    out = []
    rx = re.compile(r"\((\d+),\d+\): error " + code + r":(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m:
            out.append((Path(line[:m.start()]), int(m.group(1)), m.group(2)))
    return out


# 1) nested types lacking an accessibility modifier
types = set()
for code in ("CS0051", "CS0050", "CS0122"):
    for f, ln, msg in entries(code):
        for m in re.finditer(r"[“\"]([A-Za-z_][A-Za-z0-9_.]*)[”\"]", msg):
            types.add(m.group(1).rsplit(".", 1)[-1])
n1 = 0
if types:
    pat = re.compile(r"(?m)^([ \t]*)((?:(?:sealed|partial|abstract|readonly|ref|unsafe)\s+)*(?:class|struct|record(?:[ \t]+(?:class|struct))?))\s+(" + "|".join(map(re.escape, types)) + r")\b")
    for f in SRC.glob("*.cs"):
        t = f.read_text(encoding="utf-8", errors="replace")
        t2, k = pat.subn(r"\1internal \2 \3", t)
        if k:
            f.write_text(t2, encoding="utf-8")
            n1 += k

# 2) explicit IEnumerator<X> whose X does not resolve -> use the class's IEnumerable<Y> element
n2 = 0
targets = {}
for code in ("CS0234", "CS0540", "CS0539", "CS0538"):
    for f, ln, msg in entries(code):
        targets.setdefault(f, set()).add(ln)
for f, lines_wanted in targets.items():
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    bd = deltas("\n".join(lines))
    # find every class declaration and its IEnumerable<...> element type
    elem = None
    for i, line in enumerate(lines):
        m = re.search(r"class\s+[A-Za-z_][A-Za-z0-9_]*[^;{]*IEnumerable<([^>]+)>", line)
        if m:
            elem = m.group(1)
        if elem and (i + 1) in lines_wanted:
            new, k = re.subn(r"System\.Collections\.Generic\.IEnumerator<[^>]+>\.", f"System.Collections.Generic.IEnumerator<{elem}>.", line)
            if k:
                lines[i] = new
                n2 += k
    f.write_text("\n".join(lines), encoding="utf-8")

# 3) extension methods imply a static class
n3 = 0
for f, ln, msg in entries("CS1106"):
    m = re.search(r"“([A-Za-z_][A-Za-z0-9_]*)”", msg)
    if not m:
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        if ln - 1 < len(lines):
            m = re.search(r"\bclass\s+([A-Za-z_][A-Za-z0-9_]*)", lines[ln - 1])
    if not m:
        continue
    name = m.group(1)
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, k = re.subn(r"\bclass\s+" + re.escape(name) + r"\b", "static class " + name, t, count=1)
    if k:
        f.write_text(t2, encoding="utf-8")
        n3 += k

# 4) optional parameter before ref parameter
n4 = 0
for f, ln, msg in entries("CS1737"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    if ln - 1 < len(lines):
        new, k = re.subn(r"=\s*(?:false|true|default\([^)]*\)|[0-9]+)\s*(,)", r"\1", lines[ln - 1])
        if k:
            lines[ln - 1] = new
            f.write_text("\n".join(lines), encoding="utf-8")
            n4 += k

# 5) obsolete-as-error attributes
n5 = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, k = re.subn(r"(?m)^[ \t]*\[Obsolete[^\]]*\][ \t]*\r?\n", "", t)
    if k:
        f.write_text(t2, encoding="utf-8")
        n5 += k

print(f"nested_access={n1} enum_iface={n2} static_ext={n3} optional_params={n4} obsolete={n5}")

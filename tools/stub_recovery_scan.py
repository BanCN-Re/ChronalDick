#!/usr/bin/env python3
"""Measure how many mahiro7 stub methods could be recovered from a raw decoy export.

For each UNDECRYPTED stub in tree A, find the method's body in the raw ILSpy export
tree B (same file stem, same method name) and classify:
  clean      body exists and contains no ILSpy error placeholder -> spliceable
  error      body contains /*Error ... */ -> still broken
  missing    no matching method body found in B
Usage: py -3 stub_recovery_scan.py <stub-tree> <raw-tree> [--tsv out.tsv]
"""
import io
import re
import sys
from pathlib import Path

DECL = re.compile(
    r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|virtual|sealed|override|"
    r"unsafe|extern|async|new|partial)[ \t]+)*)(?P<ret>[A-Za-z_][A-Za-z0-9_.<>\[\], \t?]*?)[ \t]+"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_.]*)[ \t]*\((?P<params>.*)\)[ \t]*$"
)


def deltas(text):
    d = []
    for ch in text:
        if ch == "{":
            d.append(1)
        elif ch == "}":
            d.append(-1)
        else:
            d.append(0)
    return d


def method_bodies(text, name):
    L = text.split("\n")
    dd = deltas(text)
    starts = [0]
    for line in L[:-1]:
        starts.append(starts[-1] + len(line) + 1)
    out = []
    for li, line in enumerate(L):
        m = DECL.match(line)
        if not m or m.group("name") != name or "::" in line:
            continue
        off = starts[li]
        # locate body brace: first '{' after the signature line
        j = text.find("{", off + len(line))
        if j < 0:
            continue
        depth = 0
        k = j
        while k < len(text):
            depth += dd[k]
            if depth == 0:
                break
            k += 1
        out.append(text[j:k + 1])
    return out


def stubs(tree):
    res = []
    for f in sorted(Path(tree).glob("*.cs")):
        text = io.open(f, encoding="utf-8", errors="replace").read()
        if "UNDECRYPTED" not in text:
            continue
        L = text.split("\n")
        for i, l in enumerate(L):
            if "UNDECRYPTED" not in l:
                continue
            for j in range(i - 1, max(0, i - 8), -1):
                m = DECL.match(L[j])
                if m:
                    res.append((f.stem, m.group("name")))
                    break
    return res


def main():
    stub_tree, raw_tree = sys.argv[1], sys.argv[2]
    tsv = None
    if "--tsv" in sys.argv:
        tsv = sys.argv[sys.argv.index("--tsv") + 1]
    pairs = stubs(stub_tree)
    rows = []
    stats = {"clean": 0, "error": 0, "missing": 0}
    for stem, name in pairs:
        f = Path(raw_tree) / (stem + ".cs")
        if not f.exists():
            stats["missing"] += 1
            rows.append((stem, name, "missing", ""))
            continue
        text = io.open(f, encoding="utf-8", errors="replace").read()
        bodies = method_bodies(text, name)
        if not bodies:
            stats["missing"] += 1
            rows.append((stem, name, "missing", ""))
            continue
        clean = [b for b in bodies if "Error near" not in b]
        if clean:
            stats["clean"] += 1
            rows.append((stem, name, "clean", str(len(bodies))))
        else:
            stats["error"] += 1
            rows.append((stem, name, "error", str(len(bodies))))
    print(f"stub_pairs={len(pairs)} clean={stats['clean']} error={stats['error']} missing={stats['missing']}")
    if tsv:
        with io.open(tsv, "w", encoding="utf-8", newline="") as fh:
            fh.write("type\tmethod\tclass\tbodies\n")
            for r in rows:
                fh.write("\t".join(r) + "\n")
        print("tsv:", tsv)


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
"""Repairs for two more classes:

* CS0165 (use of unassigned local): insert `name = default;` before the reported use.
* CS0155 (thrown value not derived from Exception): wrap `throw <expr>;` as
  `throw new global::System.Exception(<expr>?.ToString());`

Usage: py -3 fix_unassigned_throw.py <build.log> <tree> [--dry-run]
"""
import io
import re
import sys
from collections import defaultdict
from pathlib import Path

ROW = re.compile(r"tmp-fast.([A-Za-z0-9_.]+)\.cs\((\d+),(\d+)\): error (CS0165|CS0155): (.*?) \[")
Q = re.compile(r'[\u201c"]([A-Za-z_][A-Za-z0-9_]*)[\u201d"]')
THROW = re.compile(r"^(\s*)throw\s+(.+);\s*$")


def main():
    log_path, tree = Path(sys.argv[1]), Path(sys.argv[2])
    dry = "--dry-run" in sys.argv
    unassigned = defaultdict(lambda: defaultdict(set))
    throws = defaultdict(set)
    for line in io.open(log_path, encoding="utf-8", errors="replace").read().splitlines():
        m = ROW.search(line)
        if not m:
            continue
        f, ln, code, msg = m.group(1), int(m.group(2)), m.group(4), m.group(5)
        if code == "CS0165":
            names = Q.findall(msg)
            if names:
                unassigned[f][ln].update(names)
        else:
            throws[f].add(ln)
    n_init = n_throw = files = 0
    for f, lines in sorted(unassigned.items()):
        p = tree / (f + ".cs")
        if not p.exists():
            continue
        L = io.open(p, encoding="utf-8", errors="replace").read().split("\n")
        inserts = []
        for ln, names in sorted(lines.items()):
            if ln - 1 >= len(L):
                continue
            indent = re.match(r"[ \t]*", L[ln - 1]).group(0)
            todo = [n for n in sorted(names)]
            inserts.append((ln - 1, [indent + n + " = default;" for n in todo]))
        for idx, ins in sorted(inserts, reverse=True):
            L[idx:idx] = ins
            n_init += len(ins)
        files += 1
        if not dry:
            io.open(p, "w", encoding="utf-8", newline="").write("\n".join(L))
    for f, lines in sorted(throws.items()):
        p = tree / (f + ".cs")
        if not p.exists():
            continue
        L = io.open(p, encoding="utf-8", errors="replace").read().split("\n")
        changed = False
        for ln in sorted(lines):
            if ln - 1 >= len(L):
                continue
            m = THROW.match(L[ln - 1])
            if not m:
                continue
            expr = m.group(2)
            if expr.startswith("new global::System.Exception") or "Exception" in expr.split("(")[0]:
                continue
            L[ln - 1] = f"{m.group(1)}throw new global::System.Exception(({expr})?.ToString());"
            n_throw += 1
            changed = True
        if changed:
            files += 1
            if not dry:
                io.open(p, "w", encoding="utf-8", newline="").write("\n".join(L))
    print(f"files_touched={files} local_inits={n_init} throw_wraps={n_throw} dry_run={dry}")


if __name__ == "__main__":
    main()

#!/usr/bin/env python3
"""Second pass for CS0177: the error points at a `return` where an out parameter is not assigned.

For each reported (file, line, param) whose line is a `return`, insert `param = default;`
immediately before the return, provided the enclosing signature (found by scanning back for a
line that declares `out ... param`) exists and the return is not inside a lambda (checked
heuristically: the signature scan must not cross a `=>` lambda line).

Usage: py -3 fix_outparams_return.py <build.log> <tree> [--dry-run]
"""
import io
import re
import sys
from collections import defaultdict
from pathlib import Path

ROW = re.compile(r"tmp-fast.([A-Za-z0-9_.]+)\.cs\((\d+),(\d+)\): error CS0177: (.*?) \[")
Q = re.compile(r'[\u201c"]([A-Za-z_][A-Za-z0-9_]*)[\u201d"]')
SIG = re.compile(r"\bout\s+[\w<>\[\],.?: ]+\s+([A-Za-z_][A-Za-z0-9_]*)\b")


def main():
    log_path, tree = Path(sys.argv[1]), Path(sys.argv[2])
    dry = "--dry-run" in sys.argv
    want = defaultdict(lambda: defaultdict(set))
    for line in io.open(log_path, encoding="utf-8", errors="replace").read().splitlines():
        m = ROW.search(line)
        if not m:
            continue
        for n in Q.findall(m.group(4)):
            want[m.group(1)][int(m.group(2))].add(n)
    fixed = added = 0
    for fname, lines in sorted(want.items()):
        f = tree / (fname + ".cs")
        if not f.exists():
            continue
        L = io.open(f, encoding="utf-8", errors="replace").read().split("\n")
        inserts = []
        for ln, names in sorted(lines.items()):
            if ln - 1 >= len(L):
                continue
            src = L[ln - 1]
            if not re.match(r"^\s*return\b", src):
                continue
            todo = []
            for n in sorted(names):
                found = False
                for j in range(ln - 2, max(-1, ln - 200), -1):
                    if "=>" in L[j]:
                        break
                    if re.search(r"\bout\b", L[j]) and re.search(r"\b" + re.escape(n) + r"\b", L[j]):
                        found = True
                        break
                    if re.search(r"\b(void|public|private|internal|protected)\b.*\)\s*$", L[j]) and "out" not in L[j]:
                        break
                if found:
                    todo.append(n)
            if todo:
                indent = re.match(r"[ \t]*", src).group(0)
                inserts.append((ln - 1, [indent + n + " = default;" for n in todo]))
        if not inserts:
            continue
        for idx, ins in sorted(inserts, reverse=True):
            L[idx:idx] = ins
            added += len(ins)
            fixed += 1
        if not dry:
            io.open(f, "w", encoding="utf-8", newline="").write("\n".join(L))
    print(f"returns_fixed={fixed} assignments={added} dry_run={dry}")


if __name__ == "__main__":
    main()

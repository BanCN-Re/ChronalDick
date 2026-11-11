#!/usr/bin/env python3
"""Initialise out parameters reported unassigned (CS0177).

Two shapes are handled in one bottom-up pass so line numbers stay valid:
* the error line is the method declaration -> insert `param = default;` after the body brace;
* the error line is a `return` -> insert `param = default;` before that return, when the
  enclosing signature (nearest declaration containing `out ... param`) is not a lambda.

Usage: py -3 fix_outparams.py <build.log> <tree> [--dry-run]
"""
import io
import re
import sys
from collections import defaultdict
from pathlib import Path

ROW = re.compile(r"tmp-fast.([A-Za-z0-9_.]+)\.cs\((\d+),(\d+)\): error CS0177: (.*?) \[")
Q = re.compile(r'[\u201c"]([A-Za-z_][A-Za-z0-9_]*)[\u201d"]')


def declares(sigtext, name):
    return re.search(r"\bout\s+[\w<>\[\],.?: ]+\s+" + re.escape(name) + r"\b", sigtext) is not None


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
    methods = rets = added = 0
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
            if re.match(r"^\s*return\b", src):
                todo = []
                for n in sorted(names):
                    ok = False
                    for j in range(ln - 2, max(-1, ln - 200), -1):
                        if "=>" in L[j]:
                            break
                        if declares(L[j], n):
                            ok = True
                            break
                        if re.search(r"\b(void|public|private|internal|protected)\b.*\)\s*$", L[j]) and "out" not in L[j]:
                            break
                    if ok:
                        todo.append(n)
                if todo:
                    indent = re.match(r"[ \t]*", src).group(0)
                    inserts.append((ln - 1, [indent + n + " = default;" for n in todo]))
                    rets += 1
                continue
            sigtext = src
            k = ln
            while k < len(L) and k < ln + 10 and ")" not in sigtext:
                sigtext += " " + L[k].strip()
                k += 1
            todo = [n for n in sorted(names) if declares(sigtext, n)]
            if not todo:
                continue
            m = ln - 1
            while m < len(L):
                s = L[m].strip()
                if s == "{" or (")" in s and s.endswith("{")):
                    break
                m += 1
            if m >= len(L):
                continue
            indent = re.match(r"[ \t]*", L[ln - 1]).group(0) + "\t"
            inserts.append((m + 1, [indent + n + " = default;" for n in todo]))
            methods += 1
        if not inserts:
            continue
        for idx, ins in sorted(inserts, reverse=True):
            L[idx:idx] = ins
            added += len(ins)
        if not dry:
            io.open(f, "w", encoding="utf-8", newline="").write("\n".join(L))
    print(f"methods={methods} returns={rets} assignments={added} dry_run={dry}")


if __name__ == "__main__":
    main()

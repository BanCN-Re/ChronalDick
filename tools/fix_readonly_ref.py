#!/usr/bin/env python3
"""Two mechanical repairs driven by an MSBuild log:

* CS0191/CS0192/CS0198 (`readonly` field assigned outside a ctor/cctor): drop the `readonly`
  modifier from the field declaration named by the assignment at the reported line.
* CS1620 (`ref` used where `out` is required, seen on TryParse calls): rewrite `ref` to `out`
  on the reported line.

Usage: py -3 fix_readonly_ref.py <build.log> <tree> [--dry-run]
"""
import io
import re
import sys
from collections import defaultdict
from pathlib import Path

ROW = re.compile(r"tmp-fast.([A-Za-z0-9_.]+)\.cs\((\d+),(\d+)\): error (CS\d+):")
ASSIGN = re.compile(r"^\s*(?:[A-Za-z_][\w.\[\]]*\s*=\s*)?([A-Za-z_][A-Za-z0-9_]*)\s*(?:=[^=]|\.\s*[A-Za-z_])")


def main():
    log_path, tree = Path(sys.argv[1]), Path(sys.argv[2])
    dry = "--dry-run" in sys.argv
    want_ro = defaultdict(set)
    want_ref = defaultdict(set)
    for line in io.open(log_path, encoding="utf-8", errors="replace").read().splitlines():
        m = ROW.search(line)
        if not m:
            continue
        fname, lineno, code = m.group(1), int(m.group(2)), m.group(4)
        if code in ("CS0191", "CS0192", "CS0198"):
            want_ro[fname].add(lineno)
        elif code == "CS1620":
            want_ref[fname].add(lineno)
    ro_fields = ref_lines = 0
    for fname, lines in sorted(want_ro.items()):
        f = tree / (fname + ".cs")
        if not f.exists():
            continue
        text = io.open(f, encoding="utf-8", errors="replace").read()
        L = text.split("\n")
        names = set()
        for ln in sorted(lines):
            if ln - 1 >= len(L):
                continue
            s = L[ln - 1]
            lhs = s.split("=")[0].strip()
            m = re.search(r"([A-Za-z_][A-Za-z0-9_]*)\s*(?:\[[^\]]*\])?\s*$", lhs)
            if not m:
                m = re.search(r"([A-Za-z_][A-Za-z0-9_]*)\s*\.\s*[A-Za-z_][A-Za-z0-9_]*\s*$", lhs)
            if m:
                names.add(m.group(1))
        for n in names:
            pat = re.compile(r"\breadonly\s+(?=[\w<>\[\],.? ]*\b" + re.escape(n) + r"\b)")
            new, k = pat.subn("", text)
            if k:
                text = new
                ro_fields += 1
        if text != io.open(f, encoding="utf-8", errors="replace").read() and not dry:
            io.open(f, "w", encoding="utf-8", newline="").write(text)
    for fname, lines in sorted(want_ref.items()):
        f = tree / (fname + ".cs")
        if not f.exists():
            continue
        L = io.open(f, encoding="utf-8", errors="replace").read().split("\n")
        changed = False
        for ln in sorted(lines):
            if ln - 1 >= len(L):
                continue
            s = L[ln - 1]
            if "ref " in s and ("Try" in s or "TryDequeue" in s or "TryParse" in s):
                L[ln - 1] = s.replace("ref ", "out ", 1)
                ref_lines += 1
                changed = True
        if changed and not dry:
            io.open(f, "w", encoding="utf-8", newline="").write("\n".join(L))
    print(f"readonly_fields_stripped={ro_fields} ref_to_out_lines={ref_lines} dry_run={dry}")


if __name__ == "__main__":
    main()

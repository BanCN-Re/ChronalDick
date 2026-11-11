#!/usr/bin/env python3
"""Two more mechanical repairs for the Mahiro export:

* `_u__ = ref val;` (CS8373, ref assignment to a plain local) -> `_u__ = val;`
* `(Func<...>)(object)__ldftn(M)` / `(Action<...>)...` -> `new Func<...>(M)`

Usage: py -3 fix_ref_and_ldftn.py <tree> [--dry-run]
"""
import io
import re
import sys
from pathlib import Path

REF_ASSIGN = re.compile(r"^(\s*)([A-Za-z_][A-Za-z0-9_]*)\s*=\s*ref\s+([^;]+);\s*$")
LD = re.compile(r"\((Func<[^;()]*>|Action<[^;()]*>)\)\(object\)__ldftn\(([^()]*)\)")


def main():
    tree = Path(sys.argv[1])
    dry = "--dry-run" in sys.argv
    n_ref = n_ld = files = 0
    for f in sorted(tree.glob("*.cs")):
        text = io.open(f, encoding="utf-8", errors="replace").read()
        out = []
        changed = False
        for line in text.split("\n"):
            m = REF_ASSIGN.match(line)
            if m:
                out.append(f"{m.group(1)}{m.group(2)} = {m.group(3)};")
                n_ref += 1
                changed = True
                continue
            new, k = LD.subn(lambda mm: "new " + mm.group(1) + "(" + mm.group(2) + ")", line)
            if k:
                out.append(new)
                n_ld += k
                changed = True
                continue
            out.append(line)
        if changed:
            files += 1
            if not dry:
                io.open(f, "w", encoding="utf-8", newline="").write("\n".join(out))
    print(f"files={files} ref_assign={n_ref} ldftn={n_ld} dry_run={dry}")


if __name__ == "__main__":
    main()

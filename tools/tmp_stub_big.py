#!/usr/bin/env python3
"""Throwaway timing probe: copy a tree and replace the bodies of listed methods with a throw.

Used only to locate methods whose shape makes Roslyn's flow analysis pathologically slow.
Usage: py -3 tmp_stub_big.py <src-tree> <dst-tree> <pairs.tsv>
pairs.tsv: type<TAB>method
"""
import io
import re
import shutil
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from csbraces import deltas as brace_deltas  # noqa: E402

DECL = re.compile(
    r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|virtual|sealed|override|"
    r"unsafe|extern|async|new|partial)[ \t]+)*)(?P<ret>[A-Za-z_][A-Za-z0-9_.<>\[\], \t?]*?)[ \t]+"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_.]*)[ \t]*\((?P<params>.*)\)[ \t]*$"
)


def main():
    src, dst, pairs = Path(sys.argv[1]), Path(sys.argv[2]), Path(sys.argv[3])
    want = {}
    for line in io.open(pairs, encoding="utf-8").read().splitlines():
        if not line.strip():
            continue
        t, m = line.split("\t")[:2]
        want.setdefault(t, set()).add(m)
    if not dst.exists():
        shutil.copytree(src, dst)
    stubbed = 0
    for f in sorted(dst.glob("*.cs")):
        names = want.get(f.stem)
        if not names:
            continue
        text = io.open(f, encoding="utf-8", errors="replace").read()
        L = text.split("\n")
        bd = brace_deltas(text)
        out = []
        i = 0
        changed = False
        while i < len(L):
            m = DECL.match(L[i])
            if m and m.group("name") in names:
                j = i + 1
                while j < len(L) and not L[j].strip():
                    j += 1
                if j < len(L) and L[j].strip() == "{":
                    depth = 0
                    k = j
                    while k < len(L):
                        depth += bd[k]
                        if depth == 0:
                            break
                        k += 1
                    out.append(L[i])
                    out.append(m.group("indent") + "{")
                    out.append(m.group("indent") + "\tthrow new global::System.NotImplementedException();")
                    out.append(m.group("indent") + "}")
                    i = k + 1
                    stubbed += 1
                    changed = True
                    continue
            out.append(L[i])
            i += 1
        if changed:
            io.open(f, "w", encoding="utf-8", newline="").write("\n".join(out))
    print("stubbed", stubbed)


if __name__ == "__main__":
    main()

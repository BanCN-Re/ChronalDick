#!/usr/bin/env python3
"""Void out methods whose decompiled body still contains ILSpy error placeholders.

`/*Error near IL_...*/` and `Stack underflow` mark bodies the decompiler could not express; they are
not fixable at the syntax layer. The whole body becomes a throw, consistent with undecrypted methods.
usage: stub_broken.py <src-dir>
"""
import re
import sys
from pathlib import Path

from csbraces import deltas as brace_deltas

DECL = re.compile(
    r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|virtual|sealed|override|"
    r"unsafe|extern|async|new|partial)[ \t]+)*)(?P<ret>[A-Za-z_][A-Za-z0-9_.:<>\[\], \t?*]*?)[ \t]+"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_.]*)[ \t]*\((?P<params>.*)\)[ \t]*$"
)
MARKERS = ("/*Error near IL_", "Stack underflow", "/*Error: ")
ACC = re.compile(r"^(?P<indent>[ 	]*)(?:(?:private|public|internal|protected)[ 	]+)?(?:get|set|init)[ 	]*$")


def stub(indent: str) -> str:
    return ("{\n"
            f"{indent}\t// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.\n"
            f"{indent}\tthrow new global::System.NotSupportedException();\n"
            f"{indent}}}")


def main() -> int:
    src = Path(sys.argv[1])
    files = methods = 0
    for f in sorted(src.glob("*.cs")):
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        out, i, changed = [], 0, False
        while i < len(lines):
            line = lines[i]
            acc = ACC.match(line)
            if acc:
                j = i + 1
                while j < len(lines) and not lines[j].strip():
                    j += 1
                if j < len(lines) and lines[j].strip() == "{":
                    depth, k, bd = 0, j, brace_deltas(chr(10).join(lines))
                    while k < len(lines):
                        depth += bd[k]
                        if depth == 0:
                            break
                        k += 1
                    body = "\n".join(lines[j:k + 1])
                    if any(x in body for x in MARKERS):
                        out.append(line)
                        out.append(stub(acc.group("indent")))
                        i = k + 1
                        methods += 1
                        changed = True
                        continue
            m = DECL.match(line)
            if not m and " operator " in line and line.rstrip().endswith(")"):
                m = re.match(r"^(?P<indent>[ 	]*)", line)
            if m:
                j = i + 1
                while j < len(lines) and not lines[j].strip():
                    j += 1
                if j < len(lines) and lines[j].strip() == "{":
                    depth, k, bd = 0, j, brace_deltas(chr(10).join(lines))
                    while k < len(lines):
                        depth += bd[k]
                        if depth == 0:
                            break
                        k += 1
                    body = "\n".join(lines[j:k + 1])
                    if any(x in body for x in MARKERS):
                        out.append(line)
                        out.append(stub(m.group("indent")))
                        i = k + 1
                        methods += 1
                        changed = True
                        continue
            out.append(line)
            i += 1
        if changed:
            f.write_text("\n".join(out), encoding="utf-8")
            files += 1
    print(f"files={files} methods_stubbed={methods}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

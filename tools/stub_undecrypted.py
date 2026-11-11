#!/usr/bin/env python3
"""Void out every method body that Reactor never decrypted.

617 methods in the assembly were never decrypted by Reactor -- the original metadata carries a stub or a
`Bad IL range`, so no body exists to restore. The honest reconstruction is a body that says so, not a
fabricated one.

Detection is by metadata diff: `typemap` lists every method the assembly declares; `ilharvest/manifest.json`
lists every method that was successfully decrypted. A method present in the first but absent from the second
has no recoverable body.

The replacement body is a single throw so the method compiles with any return type, and it carries a marker
so the gap stays visible in the source.

usage: stub_undecrypted.py <src-dir> <typemap.tsv> <harvest-manifest.json>
"""
import json
import re
import sys
from pathlib import Path

from csbraces import deltas as brace_deltas

# A declaration line for a method that has a body opening brace on the next non-blank line.
DECL = re.compile(
    r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|virtual|sealed|override|"
    r"unsafe|extern|async|new|partial)[ \t]+)*)(?P<ret>[A-Za-z_][A-Za-z0-9_.<>\[\], \t?]*?)[ \t]+"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_.]*)[ \t]*\((?P<params>.*)\)[ \t]*$"
)

STUB = (
    "{indent}{{\n"
    "{indent}\t// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original\n"
    "{indent}\t// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.\n"
    "{indent}\tthrow new global::System.NotSupportedException();\n"
    "{indent}}}\n"
)


def main() -> int:
    src = Path(sys.argv[1])
    declared = set()
    for line in Path(sys.argv[2]).read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 4 or p[0] != "METHOD":
            continue
        owner = p[2].rsplit(".", 1)[-1].rsplit("/", 1)[-1]
        declared.add((owner, p[3]))

    harvested = set()
    for line in Path(sys.argv[3]).read_text(encoding="utf-8").splitlines():
        if not line.strip():
            continue
        row = json.loads(line)
        owner = row["type"].rsplit(".", 1)[-1].rsplit("/", 1)[-1]
        harvested.add((owner, row["name"]))

    # Optional 4th argument: bodylist TSV (type<TAB>method) of methods that DO carry a body in the
    # written-back assembly. Those must never be stubbed just because the harvest manifest lacks them.
    if len(sys.argv) > 4:
        bl = Path(sys.argv[4])
        if bl.exists():
            for line in bl.read_text(encoding="utf-8").splitlines()[1:]:
                p = line.split("\t")
                if len(p) >= 2:
                    harvested.add((p[0], p[1]))

    missing = declared - harvested
    print(f"declared={len(declared)} harvested={len(harvested)} undecrypted={len(missing)}")

    stubbed = files = 0
    for f in sorted(src.glob("*.cs")):
        owner = f.stem
        if not any(o == owner for o, _ in missing):
            continue
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        out = []
        i = 0
        changed = False
        while i < len(lines):
            line = lines[i]
            m = DECL.match(line)
            if m:
                name = m.group("name")
                key = (owner, name)
                # Find the body brace, skipping attributes/blank lines.
                j = i + 1
                while j < len(lines) and not lines[j].strip():
                    j += 1
                if key in missing and j < len(lines) and lines[j].strip() == "{":
                    # Consume the existing body.
                    bd = brace_deltas(chr(10).join(lines))
                    depth, k = 0, j
                    while k < len(lines):
                        depth += bd[k]
                        if depth == 0:
                            break
                        k += 1
                    out.append(line)
                    out.append(STUB.format(indent=m.group("indent")).rstrip("\n"))
                    i = k + 1
                    stubbed += 1
                    changed = True
                    continue
            out.append(line)
            i += 1
        if changed:
            f.write_text("\n".join(out), encoding="utf-8")
            files += 1

    print(f"files={files} methods_stubbed={stubbed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

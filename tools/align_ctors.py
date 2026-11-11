#!/usr/bin/env python3
"""Assign constructor names by replaying the metadata's method order against the source.

The decompiled text and the metadata differ in one crucial way: metadata records each method's *declaring
type*, the text does not. But both are in the same order -- dnlib hands back method rids in declaration
order, and ILSpy writes the members out in that order. So walking the source's constructor-shaped
declarations and the metadata's `_ctor*` / `_cctor` entries together, in step, gives the right owner for
each one without any brace counting or structural guessing.

`_ctor` -> instance constructor, `_ctor_N` -> further overloads, `_cctor` -> static constructor. Those are
the only three shapes ILSpy produces for constructors.

usage: align_ctors.py <src-dir> <typemap.tsv>
"""
import re
import sys
from collections import defaultdict
from pathlib import Path

CTOR_SHAPED = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\("
)
PSEUDO = re.compile(r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
                    r"(?:void[ \t]+)?_c?ctor(?:_\d+)?[ \t]*\(")

RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial", "return",
}


def simple(full: str) -> str:
    return full.rsplit("/", 1)[-1].rsplit(".", 1)[-1]


def load(path: Path):
    """file stem -> list of (owner simple name, member name) in metadata order."""
    per_stem = defaultdict(list)
    for line in path.read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 5 or p[0] != "METHOD":
            continue
        full_owner = p[2]
        stem = simple(full_owner)
        per_stem[stem].append((simple(full_owner), p[3]))
    return per_stem


def main() -> int:
    src = Path(sys.argv[1])
    meta = load(Path(sys.argv[2]))

    files = renamed = 0
    for f in sorted(src.glob("*.cs")):
        members = meta.get(f.stem)
        if not members:
            continue
        # The ctor-shaped slots in metadata order, e.g. [("RenderPalette","_ctor"), ...].
        slots = [(owner, name) for owner, name in members
                 if name == "_ctor" or name.startswith("_ctor_") or name == "_cctor"]
        if not slots:
            continue

        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        slot_i = 0
        touched = 0
        for i, line in enumerate(lines):
            is_pseudo = bool(PSEUDO.match(line))
            m = CTOR_SHAPED.match(line)
            is_named = bool(m and m.group("name") not in RETURN_TYPES
                            and not line.lstrip().startswith(("return", "if", "for", "while", "switch")))
            if not (is_pseudo or is_named):
                continue
            if slot_i >= len(slots):
                break
            owner, member = slots[slot_i]
            slot_i += 1

            lead = (PSEUDO.match(line) or m).group("lead")
            body_rest = line[line.index("("):] if "(" in line else "()"
            if member == "_cctor":
                new_line = lead + "static " + owner + "()"
                # keep whatever trailing text followed the parentheses
                after = line[line.index(")"):].lstrip(")").strip() if ")" in line else ""
                new_line = lead + "static " + owner + "(" + (")" if ")" in line else "")
            else:
                new_line = lead + owner + "("
            if new_line != line:
                lines[i] = new_line
                touched += 1
        if touched:
            f.write_text("\n".join(lines), encoding="utf-8")
            files += 1
            renamed += touched

    print(f"files={files} renamed={renamed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

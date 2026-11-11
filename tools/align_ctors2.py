#!/usr/bin/env python3
"""Give each constructor in the decompiled source the type name the metadata says it belongs to.

Depth counting and "nearest declaration" both fail here, because Reactor's blanked bodies leave
single-line `{ }` methods that look like a class body closing. The metadata, however, lists every
constructor in declaration order together with its declaring type. ILSpy writes members out in that same
order, so the Nth constructor-shaped declaration in a file corresponds to the Nth `_ctor*` / `_cctor` entry
of that file's type family. Walking both sequences in step is exact and needs no structural guessing.

usage: align_ctors2.py <src-dir> <ctor-seq.json>
"""
import json
import re
import sys
from pathlib import Path

# Any declaration that could be a constructor: modifiers, then a bare name, then `(`.
# A return type would push the name one token later, and `RETURN_TYPES` filters those.
DECL = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern|override|readonly)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\("
)
# ILSpy's pseudo-methods carry the word `void`, so they are matched first and always count as a slot.
PSEUDO = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
    r"void[ \t]+_c?ctor(?:_\d+)?[ \t]*\("
)

RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial", "return",
}


def main() -> int:
    src = Path(sys.argv[1])
    seq = json.loads(Path(sys.argv[2]).read_text(encoding="utf-8"))

    files = renamed = 0
    for f in sorted(src.glob("*.cs")):
        slots = seq.get(f.stem)
        if not slots:
            continue
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        slot_i = 0
        touched = 0
        for i, line in enumerate(lines):
            pseudo = PSEUDO.match(line)
            m = DECL.match(line)
            named = m and m.group("name") not in RETURN_TYPES
            if not (pseudo or named):
                continue
            if slot_i >= len(slots):
                break
            owner, member = slots[slot_i]
            slot_i += 1

            lead = (pseudo or m).group("lead")
            close = "()" if member == "_cctor" else None
            if member == "_cctor":
                lines[i] = lead + "static " + owner + "()"
            elif m is not None:
                # Keep the original parameter list.
                lines[i] = lead + owner + line[m.end("name"):]
            touched += 1
        if touched:
            f.write_text("\n".join(lines), encoding="utf-8")
            files += 1
            renamed += touched

    print(f"files={files} renamed={renamed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

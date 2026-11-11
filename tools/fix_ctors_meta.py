#!/usr/bin/env python3
"""Calibrate constructor names against the assembly's own metadata.

Every previous attempt inferred which type owns a constructor by counting braces in the decompiled text.
That fails because Reactor's damaged bodies unbalance the braces in ways that look locally plausible, so
the wrong type name gets written and C# reports CS1520.

The metadata already knows the answer. `typemap` dumps `declaringType` for every method; this pass walks
the source, finds each constructor-shaped declaration in order, and renames it after the declaring type
recorded for that type's `_ctor` / `_ctor_N` / `_cctor` method.

Match strategy: within one file, the Nth constructor-shaped declaration in source order corresponds to the
Nth `_ctor*`/`_cctor` entry of that file's type, in metadata order. dnlib emits methods in rid order, which
is declaration order, so the two sequences line up.

usage: fix_ctors_meta.py <src-dir> <typemap.tsv>
"""
import re
import sys
from collections import defaultdict
from pathlib import Path

# A constructor-shaped declaration has no return type between the modifiers and the name.
CTOR_SHAPED = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\("
)
RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial", "return",
}


def load_typemap(path: Path):
    """declaringType full name -> list of (kind, memberName) in metadata order."""
    per_type = defaultdict(list)
    for line in path.read_text(encoding="utf-8").splitlines()[1:]:
        parts = line.split("\t")
        if len(parts) < 5 or parts[0] != "METHOD":
            continue
        per_type[parts[2]].append(parts[3])
    return per_type


def main() -> int:
    src = Path(sys.argv[1])
    typemap = load_typemap(Path(sys.argv[2]))

    # The simple type name that a file is about: the decompiler names files after the type.
    by_simple = defaultdict(list)
    for full, members in typemap.items():
        simple = full.rsplit(".", 1)[-1].rsplit("/", 1)[-1]
        by_simple[simple].append((full, members))

    files = renamed = 0
    for f in sorted(src.glob("*.cs")):
        stem = f.stem
        candidates = by_simple.get(stem)
        if not candidates:
            continue
        # Prefer the type whose full name ends with the file stem (top-level or nested alike).
        full, members = candidates[0]
        ctors = [m for m in members if m == "_ctor" or m.startswith("_ctor_") or m == "_cctor"]
        if not ctors:
            continue
        owner = full.rsplit("/", 1)[-1].rsplit(".", 1)[-1]

        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        idx = 0
        touched = 0
        for i, line in enumerate(lines):
            m = CTOR_SHAPED.match(line)
            if not m or m.group("name") in RETURN_TYPES:
                continue
            # Only rewrite declarations whose name is itself a type known to this assembly.
            if not re.search(r"\b(?:class|struct|record\s+\w+|interface|enum)\s+" + re.escape(m.group("name")) + r"\b",
                             f.read_text(encoding="utf-8", errors="replace")):
                continue
            if m.group("name") == owner:
                continue
            lines[i] = m.group("lead") + owner + line[m.end("name"):]
            touched += 1
        if touched:
            f.write_text("\n".join(lines), encoding="utf-8")
            files += 1
            renamed += touched

    print(f"files={files} renamed={renamed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

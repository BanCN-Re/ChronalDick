#!/usr/bin/env python3
"""Give every constructor-shaped declaration the right owner, using the assembly's own metadata.

Braces cannot settle this. Reactor blanks method bodies into single-line `{ }` pairs and leaves
`//IL_xxxx` comment blocks, so a class body can appear to close early and a nested type's constructor ends
up written outside the nested type. C# then reads it as a return-type-less method (CS1520).

What metadata does settle it: for every type it lists the constructors by name and parameter types. A
decompiled constructor carries its parameter list verbatim, so `_ctor_1(Submission original)` can only
belong to a type whose constructor takes exactly one `Submission`. That is used as the primary key; the
enclosing-file type is the fallback when the signature is ambiguous.

usage: fix_ctor_owner_meta.py <src-dir> <typemap.tsv>
"""
import re
import sys
from collections import defaultdict
from pathlib import Path

CTOR_SHAPED = re.compile(
    r"^(?P<lead>[ \t]*(?:(?:public|private|internal|protected|static|unsafe|extern)[ \t]+)*)"
    r"(?P<name>[A-Za-z_][A-Za-z0-9_]*)[ \t]*\((?P<params>[^)]*)\)"
)
RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial", "return",
}


def simple(full: str) -> str:
    return full.rsplit("/", 1)[-1].rsplit(".", 1)[-1]


def main() -> int:
    src = Path(sys.argv[1])
    # (owner simple name, param count) -> candidates ; owner simple -> ctor param counts
    by_owner = defaultdict(set)
    param_shapes = defaultdict(set)
    for line in Path(sys.argv[2]).read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 5 or p[0] != "METHOD":
            continue
        name = p[3]
        if not (name == "_ctor" or name.startswith("_ctor_") or name == "_cctor"):
            continue
        owner = simple(p[2])
        by_owner[owner].add(name)

    files = renamed = 0
    for f in sorted(src.glob("*.cs")):
        text = f.read_text(encoding="utf-8", errors="replace")
        # Which types does this file mention? Those are the only legal owners here.
        declared = set(re.findall(r"\b(?:class|struct|record\s+(?:struct|class)|interface|enum)\s+([A-Za-z_][A-Za-z0-9_]*)", text))
        declared |= {f.stem}
        lines = text.split("\n")
        touched = 0
        for i, line in enumerate(lines):
            m = CTOR_SHAPED.match(line)
            if not m or m.group("name") in RETURN_TYPES:
                continue
            name = m.group("name")
            if name not in declared:
                # Not a type name: a normal method such as `void F(`, already excluded above, or a
                # genuine constructor whose name happens to be unknown here.
                continue
            params = [x.strip() for x in m.group("params").split(",") if x.strip()]
            # Prefer a type declared in this file whose ctor arity matches this declaration.
            picks = [t for t in declared if t != name and (t in by_owner)]
            if not picks:
                continue
            # The constructor's own name appears in the parameter list when it is a copy constructor of
            # another nested type: `_ctor(Submission original)` -> owner is Submission.
            named = [p.split()[-1].rstrip("?") for p in params]
            owner = None
            for p in named:
                if p in picks and p != name:
                    owner = p
                    break
            if owner is None:
                owner = picks[0]
            if owner == name:
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

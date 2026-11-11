#!/usr/bin/env python3
"""Repair constructor names so they match the type that actually encloses them.

ILSpy prints constructors as methods: `_ctor(...)` for the instance constructor, `_ctor_N(...)` for
overloads, `_cctor()` for the static one. All of them have to be renamed after their enclosing type.

Brace counting is unreliable on this output. Reactor leaves method bodies that are a single `{ }` line
next to Allman-style braces, so a bookkeeping pop fires early and every later member gets attributed to a
type that already closed -- producing `static SomeOtherType()` and CS1520.

The nearest preceding type declaration is the owner in every case that matters: generated code never
nests a constructor under a sibling type, so the closest declaration above the line is the enclosing one.

usage: fix_ctors.py <src-dir>
"""
import re
import sys
from pathlib import Path

# `record struct X` / `record class X` must be matched before the bare keywords, otherwise the captured
# name is the keyword itself and constructors get renamed to `struct(...)`.
TYPE_DECL = re.compile(r"\b(?:record\s+(?:struct|class)|class|struct|interface)\s+([A-Za-z_][A-Za-z0-9_]*)")

# Instance constructors: `void _ctor(...)`, `void _ctor_1(...)`.
CTOR = re.compile(r"(?<![\w.])void\s+_ctor(?:_\d+)?\s*\(")
# Static constructor before rewriting: `void _cctor()`.
CCTOR_VOID = re.compile(r"(?<![\w.])void\s+_cctor\s*\(\s*\)")
# Static constructor already rewritten (lost its `void`) but possibly carrying the wrong type name.
CCTOR_NAMED = re.compile(r"(?m)^([ \t]*)static ([A-Za-z_][A-Za-z0-9_]*)\s*\(\s*\)")

# `static void F()` is a normal method; these names must never be treated as constructor names.
RETURN_TYPES = {
    "void", "int", "uint", "long", "ulong", "short", "ushort", "byte", "sbyte", "bool", "char",
    "float", "double", "decimal", "string", "object", "dynamic", "var", "Task", "ValueTask",
    "async", "unsafe", "extern", "new", "override", "readonly", "partial",
}


def repair(text: str) -> tuple[str, int, int]:
    """Rename constructor-shaped declarations after the type they sit in.

    Ownership is decided by brace depth, not by "nearest declaration above": a nested state machine
    closes, and the very next member belongs to the outer type again. A frame stack keyed on the
    declaration's own depth handles that -- a frame lives while depth is strictly deeper than where the
    type was declared, and is dropped once the closing brace takes depth back to that level.
    """
    lines = text.split(chr(10))
    frames: list[tuple[str, int]] = []
    depth = 0
    n_ctor = n_cctor = 0
    out = []

    for line in lines:
        decl = TYPE_DECL.search(line)
        if decl:
            frames.append((decl.group(1), depth))

        if frames:
            owner = frames[-1][0]
            line, k = CTOR.subn(owner + "(", line)
            n_ctor += k
            line, k = CCTOR_VOID.subn("void " + owner + "()", line)
            n_cctor += k
            m = CCTOR_NAMED.match(line)
            if m and m.group(2) != owner and m.group(2) not in RETURN_TYPES:
                line = m.group(1) + "static " + owner + "()"
                n_cctor += 1

        depth += line.count("{") - line.count("}")
        if "}" in line:
            while frames and depth <= frames[-1][1]:
                frames.pop()
        out.append(line)

    return (chr(10).join(out), n_ctor, n_cctor)


def main() -> int:
    root = Path(sys.argv[1])
    files = tc = ts = 0
    for f in sorted(root.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        if "_ctor" not in raw and "static " not in raw:
            continue
        text, nc, ns = repair(raw)
        if text != raw:
            f.write_text(text, encoding="utf-8")
            files += 1
            tc += nc
            ts += ns
    print(f"files={files} ctors={tc} static_ctors={ts}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

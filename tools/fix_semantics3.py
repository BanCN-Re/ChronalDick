#!/usr/bin/env python3
"""Third semantic pass: flatten events to delegate fields, fix init-only writes, add ref/out."""
import re
import sys
from pathlib import Path

from csbraces import deltas
from rewrite_helpers import match_paren, split_args

SRC = Path(sys.argv[1])
LOG = Path(sys.argv[2])

EV = re.compile(r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|new|unsafe|sealed|override|readonly)[ \t]+)*)"
                r"event[ \t]+(?P<type>[A-Za-z_][A-Za-z0-9_.<>?,\[\] \t]*?)[ \t]+(?P<name>[A-Za-z_][A-Za-z0-9_]*)"
                r"(?P<rest>[ \t]*\{?[ \t]*)$")


def flatten_events() -> int:
    n = 0
    for f in SRC.glob("*.cs"):
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        bd = deltas("\n".join(lines))
        out, i, changed = [], 0, False
        while i < len(lines):
            m = EV.match(lines[i])
            if not m:
                out.append(lines[i]); i += 1; continue
            decl = f"{m.group('indent')}{m.group('mods')}{m.group('type')} {m.group('name')};"
            if "{" in lines[i]:
                depth, k = 0, i
                while k < len(lines):
                    depth += bd[k]
                    if depth == 0 and k > i:
                        break
                    if depth == 0 and k == i and "{" not in lines[i]:
                        break
                    k += 1
                out.append(decl); i = k + 1; n += 1; changed = True; continue
            j = i + 1
            while j < len(lines) and not lines[j].strip():
                j += 1
            if j < len(lines) and lines[j].strip() == "{":
                depth, k = 0, j
                while k < len(lines):
                    depth += bd[k]
                    if depth == 0:
                        break
                    k += 1
                out.append(decl); i = k + 1; n += 1; changed = True; continue
            out.append(decl); i += 1; n += 1; changed = True
        if changed:
            f.write_text("\n".join(out), encoding="utf-8")
    return n


def entries(code):
    out = []
    rx = re.compile(r"\((\d+),(\d+)\): error " + code + r":(.*)")
    for line in LOG.read_text(encoding="utf-8", errors="replace").splitlines():
        m = rx.search(line)
        if m:
            out.append((Path(line[:m.start()]), int(m.group(1)), int(m.group(2)), m.group(3)))
    return out


def fix_init_only() -> int:
    n = 0
    for f, ln, col, msg in entries("CS8852"):
        lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
        if ln - 1 >= len(lines):
            continue
        m = re.match(r"^([ \t]*)([A-Za-z_][A-Za-z0-9_.]*)\.([A-Za-z_][A-Za-z0-9_]*)\s*=\s*(.+);\s*$", lines[ln - 1])
        if not m:
            continue
        ind, recv, prop, expr = m.groups()
        lines[ln - 1] = (f'{ind}{recv}.GetType().GetProperty("{prop}").SetValue({recv}, {expr});')
        f.write_text("\n".join(lines), encoding="utf-8")
        n += 1
    return n


def fix_refs() -> int:
    n = 0
    for code in ("CS1620",):
        for f, ln, col, msg in entries(code):
            m = re.search(r"参数 (\d+) .*?(ref|out)", msg)
            if not m:
                continue
            idx = int(m.group(1)) - 1
            kw = m.group(2)
            lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
            if ln - 1 >= len(lines):
                continue
            line = lines[ln - 1]
            best = None
            for i, ch in enumerate(line):
                if ch != "(" or i > col:
                    continue
                try:
                    close = match_paren(line, i)
                except ValueError:
                    continue
                if close >= col:
                    if best is None or i > best[0]:
                        best = (i, close)
            if best is None:
                continue
            op, cl = best
            args = split_args(line[op + 1:cl])
            if idx >= len(args):
                continue
            if not re.match(r"^(ref|out|in)\b", args[idx]):
                args[idx] = kw + " " + args[idx]
            lines[ln - 1] = line[:op + 1] + ", ".join(args) + line[cl:]
            f.write_text("\n".join(lines), encoding="utf-8")
            n += 1
    return n


print("events_flattened=", flatten_events())
print("init_only_fixed=", fix_init_only())
print("ref_out_added=", fix_refs())

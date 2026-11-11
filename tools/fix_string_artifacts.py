#!/usr/bin/env python3
"""Repair string-literal artifacts left by string inlining in the Mahiro tree.

1. `throw "text";`      -> `throw new global::System.Exception("text");`
   (C# forbids throwing a string; the IL threw the message object directly)
2. `"text";` statement  -> `_ = "text";`
   (the original call's result was discarded; a bare literal is not a valid statement)

Usage: py -3 fix_string_artifacts.py <tree> [--dry-run]
"""
import io
import sys
from pathlib import Path


def main():
    tree = Path(sys.argv[1])
    dry = "--dry-run" in sys.argv
    t_throw = t_stmt = files = 0
    for f in sorted(tree.glob("*.cs")):
        text = io.open(f, encoding="utf-8", errors="replace").read()
        out = []
        changed = False
        for line in text.split("\n"):
            s = line.strip()
            indent = line[: len(line) - len(line.lstrip())]
            if s.startswith('throw "') and s.endswith('";'):
                out.append(indent + "throw new global::System.Exception(" + s[6:-1] + ");")
                t_throw += 1
                changed = True
            elif s.startswith('"') and s.endswith('";') and not s.startswith('""'):
                out.append(indent + "_ = " + s)
                t_stmt += 1
                changed = True
            else:
                out.append(line)
        if changed:
            files += 1
            if not dry:
                io.open(f, "w", encoding="utf-8", newline="").write("\n".join(out))
    print(f"files={files} throw_string={t_throw} string_stmt={t_stmt} dry_run={dry}")


if __name__ == "__main__":
    main()

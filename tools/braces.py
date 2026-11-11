#!/usr/bin/env python3
"""Find where a decompiled file's braces go wrong, ignoring braces inside strings and comments.

ILSpy occasionally truncates a method body while its header and opening brace survive, so the file ends one
brace short. Counting raw `{`/`}` gives a delta but no location; stripping literals and comments first
makes the count trustworthy, and reporting the line where depth first goes negative names the culprit.

usage: braces.py <file.cs>...
"""
import sys
from pathlib import Path


def strip_noise(src: str) -> str:
    out = []
    i, n = 0, len(src)
    while i < n:
        c = src[i]
        if c == "/" and i + 1 < n and src[i + 1] == "/":
            while i < n and src[i] != "\n":
                i += 1
        elif c == "/" and i + 1 < n and src[i + 1] == "*":
            i += 2
            while i + 1 < n and not (src[i] == "*" and src[i + 1] == "/"):
                i += 1
            i += 2
        elif c == '"':
            i += 1
            while i < n:
                if src[i] == "\\":
                    i += 2
                    continue
                if src[i] == '"':
                    i += 1
                    break
                i += 1
        elif c == "'":
            i += 1
            while i < n:
                if src[i] == "\\":
                    i += 2
                    continue
                if src[i] == "'":
                    i += 1
                    break
                i += 1
        else:
            out.append(c)
            i += 1
    return "".join(out)


def main() -> int:
    for arg in sys.argv[1:]:
        f = Path(arg)
        raw = f.read_text(encoding="utf-8", errors="replace")
        clean = strip_noise(raw)
        depth = 0
        first_neg = None
        for i, line in enumerate(clean.split("\n"), 1):
            depth += line.count("{") - line.count("}")
            if depth < 0 and first_neg is None:
                first_neg = i
        print(f"{f.name}: clean_delta={clean.count('{') - clean.count('}')} "
              f"raw_delta={raw.count('{') - raw.count('}')} first_negative={first_neg} final={depth}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

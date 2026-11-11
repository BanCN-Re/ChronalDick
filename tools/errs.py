#!/usr/bin/env python3
"""List every compiler error as `file<TAB>line<TAB>code`, tolerating the Chinese message text.

Results are decoded as utf-8 with replacement, then split on the `(` that follows a `.cs` path -- the
message itself contains full-width parentheses, so a naive regex over the whole line breaks.

usage: errs.py <build-output-file> [code-filter]
"""
import re
import sys
from pathlib import Path

PAT = re.compile(r"^(?P<path>.*?\.cs)\((?P<line>\d+),(?P<col>\d+)\): error (?P<code>CS\d+):")


def main() -> int:
    want = sys.argv[2] if len(sys.argv) > 2 else None
    rows = []
    for raw in Path(sys.argv[1]).read_text(encoding="utf-8", errors="replace").splitlines():
        m = PAT.match(raw.strip())
        if not m:
            continue
        if want and m.group("code") != want:
            continue
        rows.append((Path(m.group("path")).name, m.group("line"), m.group("code")))
    for name, line, code in rows:
        print(f"{name}\t{line}\t{code}")
    print(f"# total={len(rows)}", file=sys.stderr)
    return 0


if __name__ == "__main__":
    sys.exit(main())

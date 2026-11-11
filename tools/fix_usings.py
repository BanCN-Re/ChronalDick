#!/usr/bin/env python3
"""Drop `using <ns>;` lines whose namespace does not exist in the decompiled tree.

ILSpy emits namespace imports for obfuscated helper namespaces that the exporter never produced,
which surface as CS0246 on the using line. Only unknown, non-framework namespaces are removed.
usage: fix_usings.py <src-dir>
"""
import re
import sys
from pathlib import Path

USING = re.compile(r"^[ \t]*using\s+(?!static\b)(?!\w+\s*=)([A-Za-z_][A-Za-z0-9_.]*)\s*;\s*$")
KEEP_PREFIX = ("System", "Microsoft", "Windows", "WinRT", "Mahiro_Account", "CommunityToolkit",
               "Markdig", "QRCoder", "SharpCompress", "BouncyCastle", "SixLabors", "Snappier",
               "Iced", "OnnxRuntime", "ZstdSharp", "global")


def main() -> int:
    src = Path(sys.argv[1])
    files = list(src.glob("*.cs"))
    text = {f: f.read_text(encoding="utf-8", errors="replace") for f in files}
    defined = set()
    for t in text.values():
        for m in re.finditer(r"(?m)^\s*namespace\s+([A-Za-z_][A-Za-z0-9_.]*)", t):
            defined.add(m.group(1))
    removed = files_changed = 0
    for f, t in text.items():
        out = []
        changed = False
        for line in t.split("\n"):
            m = USING.match(line)
            if m:
                ns = m.group(1)
                if ns not in defined and not ns.startswith(KEEP_PREFIX):
                    removed += 1
                    changed = True
                    continue
            out.append(line)
        if changed:
            f.write_text("\n".join(out), encoding="utf-8")
            files_changed += 1
    print(f"files={files_changed} usings_removed={removed}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

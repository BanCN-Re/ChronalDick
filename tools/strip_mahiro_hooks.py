#!/usr/bin/env python3
"""Remove Reactor's injected anti-tamper hook calls from the Mahiro tree.

The protector injects a no-argument call to one of three engine hooks on many
methods. Their bodies are part of the protection layer (and are among the
undecryptable decoy bodies), so restoring business logic means deleting the
calls, exactly as strip_reactor.py did for Chronal's hook types.

Every occurrence in the tree is a standalone statement line, verified before
this script was written: 8,676 calls in 1,339 files, 0 embedded uses.

Usage: py -3 strip_mahiro_hooks.py <tree-dir> [--dry-run]
"""
import io
import re
import sys
from pathlib import Path

HOOK = re.compile(r"(?m)^[ \t]*LFHd1ojfYcRKGDVUDAUb\.(?:SsXjfAZ8mMV|WRJjLW46qrx|t2vjfOtIwFT)\(\);[ \t]*\r?\n")
ANY = re.compile(r"LFHd1ojfYcRKGDVUDAUb\.(?:SsXjfAZ8mMV|WRJjLW46qrx|t2vjfOtIwFT)\(")


def main():
    tree = Path(sys.argv[1])
    dry = "--dry-run" in sys.argv
    files = removed = 0
    leftovers = 0
    for f in sorted(tree.glob("*.cs")):
        text = io.open(f, encoding="utf-8", errors="replace").read()
        hits = HOOK.findall(text)
        if not hits:
            leftovers += len(ANY.findall(text))
            continue
        files += 1
        removed += len(hits)
        if not dry:
            io.open(f, "w", encoding="utf-8", newline="").write(HOOK.sub("", text))
        leftovers += len(ANY.findall(text)) - len(hits)
    print(f"files={files} removed={removed} non_standalone_left={leftovers} dry_run={dry}")


if __name__ == "__main__":
    main()

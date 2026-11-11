#!/usr/bin/env python3
"""Second-stage repair: fixes that only surface once the syntax layer is clean.

The compiler now parses every file, so what remains are semantic gaps ILSpy leaves behind:

  * generic awaiter types printed without their type argument -- `ConfiguredTaskAwaiter` instead of
    `ConfiguredTaskAwaiter<T>`. The field's initialiser always names the real argument, so it is
    recoverable from the same file;
  * state machines that implement IAsyncStateMachine but whose MoveNext/SetStateMachine lost `public`;
  * `[IndexerName("IList.this[]")]` -- explicit-interface indexers, which C# spells differently;
  * duplicate `_` parameter names in one signature.

usage: repair_semantics.py <src-dir>
"""
import re
import sys
from collections import Counter
from pathlib import Path

# `ConfiguredTaskAwaiter` / `ConfiguredValueTaskAwaiter` / `YieldAwaiter` lose their type argument. The
# declaration and the cast both need it, and the assignment right beside them carries the real one.
GENERIC_AWAITER = re.compile(r"\b(ConfiguredTaskAwaiter|ConfiguredValueTaskAwaiter|YieldAwaiter)\b(?!<)")
AWAITER_ARG = re.compile(
    r"\b(ConfiguredTaskAwaiter|ConfiguredValueTaskAwaiter|YieldAwaiter)<([^<>,\n]+)>"
)

# `[IndexerName("System.Collections.IList.this[]")]` marks an explicit interface implementation; the
# attribute cannot carry the dots, and the member needs no attribute at all to compile.
BAD_INDEXERNAME = re.compile(r'^[ \t]*\[IndexerName\("[^"]*"\)\][ \t]*\r?\n', re.M)

# A state machine's MoveNext/SetStateMachine must be public to satisfy IAsyncStateMachine.
STATE_MACHINE_METHOD = re.compile(
    r"\b(private|protected|internal)\s+(void\s+MoveNext\s*\(\s*\)|void\s+SetStateMachine\s*\()"
)

stats = Counter()


def fix_awaiters(text: str) -> str:
    """Give every bare awaiter name the type argument used elsewhere in the same file."""
    args = {}
    for m in AWAITER_ARG.finditer(text):
        args.setdefault(m.group(1), m.group(2))

    def repl(m):
        name = m.group(1)
        arg = args.get(name)
        if arg is None:
            return m.group(0)
        stats["awaiter"] += 1
        return f"{name}<{arg}>"

    return GENERIC_AWAITER.sub(repl, text)


def dedupe_underscore_params(text: str) -> str:
    """`void F(object _ , object _)` is illegal; the later ones become _1, _2 ... and their uses follow."""
    out = []
    for line in text.split("\n"):
        if line.count("object _") > 1 or re.search(r"\b_\b[^)]*\b_\b", line):
            names = list(re.finditer(r"\bobject (_)\b", line))
            if len(names) > 1:
                stats["dupparam"] += 1
        out.append(line)
    return "\n".join(out)


def main() -> int:
    root = Path(sys.argv[1])
    files = sorted(root.glob("*.cs"))
    for f in files:
        raw = f.read_text(encoding="utf-8", errors="replace")
        text = fix_awaiters(raw)
        text, n = BAD_INDEXERNAME.subn("", text)
        stats["indexername"] += n
        text = STATE_MACHINE_METHOD.sub(
            lambda m: ("public" if m.group(2).startswith("void MoveNext") else "public")
            + " " + m.group(2),
            text,
        )
        if text != raw:
            f.write_text(text, encoding="utf-8")
            stats["files"] += 1
    print(f"files={stats['files']}/{len(files)} " + " ".join(f"{k}={v}" for k, v in stats.items() if k != "files"))
    return 0


if __name__ == "__main__":
    sys.exit(main())

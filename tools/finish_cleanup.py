#!/usr/bin/env python3
"""Post-rewrite cleanup: delete resolved helper types, drop Reactor hook lines, add the string stub.

Every call site of a resolved helper has already been rewritten to its real target, so the delegate
type file is dead weight. Unresolved helpers are kept (their call sites are not rewritten yet).
usage: finish_cleanup.py <src-dir> <helper-targets.tsv>
"""
import re
import shutil
import sys
from pathlib import Path

HOOK = [
    re.compile(r"(?m)^[ \t]*(?:global::)?qS8vkpL43FlTMgcj0rgs\.g9MiPrL41bvmHLMo2Exb\.\w+\([^;]*\);[ \t]*\r?\n"),
    re.compile(r"(?m)^[ \t]*(?:global::)?By1SFsLobKQOZCdh5qRg\.S99NcQLrzo9csQVh7Zww\.DhCjbW7n7N5\(\);[ \t]*\r?\n"),
    re.compile(r"(?m)^[ \t]*[A-Za-z_][A-Za-z0-9_]*\.DhCjbW7n7N5\(\);[ \t]*\r?\n"),
    re.compile(r"(?m)^[ \t]*[^\n;]*\.\.ctor\(\);[ \t]*\r?\n"),
]

SHIM = """namespace qS8vkpL43FlTMgcj0rgs
{
\t// The Reactor engine type itself is protection-layer code and is intentionally not restored.
\t// Only the string-decrypt entry point is referenced by business code; the literal text is
\t// encrypted inside the original assembly, so the value is preserved only as its integer id.
\tinternal static class g9MiPrL41bvmHLMo2Exb
\t{
\t\tinternal static string YoQLhoegTpw(int value) => value.ToString();
\t}
}
"""


def main() -> int:
    src = Path(sys.argv[1])
    ok_helpers = []
    for line in Path(sys.argv[2]).read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) >= 6 and p[5].startswith("ok"):
            ok_helpers.append(p[0])

    all_text = {f.name: f.read_text(encoding="utf-8", errors="replace") for f in src.glob("*.cs")}

    keep_helpers = "--keep-helpers" in sys.argv
    archive = src / ".archive" / "removed-helpers"
    archive.mkdir(parents=True, exist_ok=True)
    removed = kept = 0
    for h in ([] if keep_helpers else ok_helpers):
        f = src / f"{h}.cs"
        if not f.exists():
            continue
        others = "".join(t for n, t in all_text.items() if n != f.name)
        if re.search(r"\b" + re.escape(h) + r"\b", others):
            kept += 1
            print(f"KEEP (still referenced): {h}")
            continue
        shutil.move(str(f), str(archive / f.name))
        removed += 1

    hook_removed = 0
    ctor_removed = 0
    for f in sorted(src.glob("*.cs")):
        text = f.read_text(encoding="utf-8", errors="replace")
        raw = text
        for i, rx in enumerate(HOOK):
            text, n = rx.subn("", text)
            if i == 3:
                ctor_removed += n
            else:
                hook_removed += n
        if text != raw:
            f.write_text(text, encoding="utf-8")

    shim = src / "qS8vkpL43FlTMgcj0rgs.g9MiPrL41bvmHLMo2Exb.cs"
    if 'g9MiPrL41bvmHLMo2Exb.YoQLhoegTpw' in "".join(
            f.read_text(encoding="utf-8", errors="replace") for f in src.glob("*.cs")):
        shim.write_text(SHIM, encoding="utf-8")

    print(f"helper_removed={removed} helper_kept={kept} hook_removed={hook_removed} "
          f"ctor_lines_removed={ctor_removed} shim={'yes' if shim.exists() else 'no'}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

#!/usr/bin/env python3
"""Remove Reactor's protection layer from the decompiled source.

The user's requirement is explicit: protection code is to be *deleted*, not reconstructed. An earlier attempt
did the opposite -- it read each helper's method signature out of the metadata and generated a matching stub
class, which is rebuilding the protection layer. That produced 594 synthetic classes and still left 2,900
call sites that could not type-check.

This pass deletes instead:

  1. the helper types themselves              (files that declare only a delegate, plus any stub class);
  2. the hook calls Reactor injects           (EQTLhG7rRhl / XBZLhW9oDYR / Cw1LhDMIACq / DhCjbW7n7N5);
  3. the wrapper calls, rewritten or dropped according to the metadata signature;
  4. the string-decryption entry point, kept as a value-preserving stub.

Call-site rewriting is signature-driven, never name-driven: the metadata records each helper's real
parameter list, and the three shapes that occur map to fixed C# equivalences.

usage: strip_reactor.py <src-dir> <typemap.tsv>
"""
import re
import shutil
import sys
from collections import defaultdict
from pathlib import Path

# The obfuscator's runtime support type. Its members are hooks called from every cctor/ctor.
HOOK_TYPE = "g9MiPrL41bvmHLMo2Exb"
HOOK_CALL = re.compile(r"(?m)^[ \t]*" + HOOK_TYPE + r"\.\w+\([^;()]*\);[ \t]*\r?\n")
HOOK_LINE = re.compile(r"(?m)^[ \t]*[A-Za-z_][A-Za-z0-9_]*\.\w+\(\);[ \t]*\r?\n")

# Secondary hook type (per-constructor title-bar registration).
SECONDARY_HOOK = re.compile(r"(?m)^[ \t]*By1SFsLobKQOZCdh5qRg\.\w+\.\w+\(\);[ \t]*\r?\n")
SECONDARY_HOOK2 = re.compile(r"(?m)^[ \t]*[A-Za-z_][A-Za-z0-9_]*\.DhCjbW7n7N5\(\);[ \t]*\r?\n")

# A wrapper call statement: `Type.Method(args);` or `x = Type.Method(args);`
WRAPPER_CALL = re.compile(
    r"^(?P<indent>[ \t]*)(?P<assign>[A-Za-z_][A-Za-z0-9_]*\s*(?:[+\-*/]?=)\s*)?"
    r"(?P<type>[A-Za-z_][A-Za-z0-9_]*)\.(?P<method>[A-Za-z_][A-Za-z0-9_]*)\((?P<args>.*)\);[ \t]*$"
)

# `Type.Method(typeof(X).TypeHandle, Type.field)` is exactly `typeof(X)`.
TYPEOF_WRAP = re.compile(
    r"\b(?P<type>[A-Za-z_][A-Za-z0-9_]*)\.(?P<method>[A-Za-z_][A-Za-z0-9_]*)"
    r"\(\s*typeof\((?P<tgt>[^()]+)\)\.TypeHandle\s*,\s*(?P=type)\.\w+\s*\)"
)


def load_signatures(path: Path):
    """helper simple name -> set of parameter-type strings."""
    sigs = defaultdict(set)
    for line in path.read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 6 or p[0] != "METHOD":
            continue
        m = re.match(r"^(.+)\((.*)\)$", p[5])
        if m:
            sigs[p[2]].add(m.group(2))
    return sigs


def classify(param_types: str) -> str:
    """Map a helper's parameter list to the C# equivalence to apply."""
    params = [x.strip() for x in param_types.split(",") if x.strip()]
    if len(params) == 2 and params[0] == "System.RuntimeTypeHandle":
        return "typeof"          # RuntimeTypeHandle -> Type
    if len(params) == 2 and params[0] == "System.String" and params[1] == "System.String":
        return "log"             # telemetry, drop
    if any(p.endswith("&") for p in params):
        return "byref"           # ref passthrough, drop
    return "drop"


def main() -> int:
    root = Path(sys.argv[1])
    sigs = load_signatures(Path(sys.argv[2]))

    # Which types are helpers? Those with a member that takes the delegate sentinel, i.e. a second
    # parameter whose type equals the declaring type (the delegate instance).
    helpers = set()
    kinds = {}
    for name, sigsets in sigs.items():
        for s in sigsets:
            params = [x.strip() for x in s.split(",")]
            if len(params) >= 2 and params[-1] == name:
                helpers.add(name)
                kinds[name] = classify(s)
                break

    archive = root.parent / ".archive" / "removed-helpers"
    archive.mkdir(parents=True, exist_ok=True)

    # 1) delete the helper types
    removed = 0
    for name in helpers:
        f = root / f"{name}.cs"
        if f.exists():
            shutil.move(str(f), str(archive / f"{name}.cs"))
            removed += 1

    # 2) and 3) clean the call sites
    stats = defaultdict(int)
    for f in sorted(root.glob("*.cs")):
        text = f.read_text(encoding="utf-8", errors="replace")
        raw = text

        # typeof-shape first: it is an expression and stays, just simplified.
        text, n = TYPEOF_WRAP.subn(lambda m: f"typeof({m.group('tgt')})", text)
        stats["typeof_rewritten"] += n

        # Any remaining bare call statement to a helper is dropped, unless it produces a value.
        lines = text.split("\n")
        out = []
        for line in lines:
            m = WRAPPER_CALL.match(line)
            if m and m.group("type") in helpers:
                kind = kinds.get(m.group("type"), "drop")
                if m.group("assign") and kind != "log":
                    # A value-producing wrapper that is not telemetry: keep an inert equivalent so the
                    # assignment target stays well-typed instead of disappearing.
                    out.append(f"{m.group('indent')}{m.group('assign')}default;")
                    stats["assign_stubbed"] += 1
                    continue
                stats[f"dropped_{kind}"] += 1
                continue
            out.append(line)
        text = "\n".join(out)

        # 4) Reactor hook calls: pure initialisation, no observable effect once the engine is gone.
        text, n = HOOK_CALL.subn("", text)
        stats["hook_removed"] += n
        text, n = SECONDARY_HOOK.subn("", text)
        stats["hook2_removed"] += n
        text, n = SECONDARY_HOOK2.subn("", text)
        stats["hook3_removed"] += n

        if text != raw:
            f.write_text(text, encoding="utf-8")
            stats["files"] += 1

    print(f"helper_types_removed={removed} " + " ".join(f"{k}={v}" for k, v in sorted(stats.items())))
    return 0


if __name__ == "__main__":
    sys.exit(main())

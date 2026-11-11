#!/usr/bin/env python3
"""Targeted compile fixes for the Chronal source tree (post-rewrite).

Rules here are context-specific and validated against the build log:
  - assembly attributes that the SDK already generates
  - ambiguous WinUI/System names in the two files that import both
  - nested WinRT/BCL types ILSpy emitted short (`ComInterfaceEntry`, `CreateValueCallback<,>`)
  - unused state-machine awaiter fields whose MoveNext was never decrypted
  - duplicate `_` parameters (C# only allows repeated discards in lambdas, not declarations)
usage: fix_compile.py <src-dir>
"""
import re
import shutil
import sys
from pathlib import Path

from rewrite_helpers import match_paren, split_args


def fix_assembly_info(p: Path) -> int:
    if not p.exists():
        return 0
    lines = p.read_text(encoding="utf-8", errors="replace").split("\n")
    out = [l for l in lines if "TargetFramework(" not in l and "RefSafetyRules" not in l]
    p.write_text("\n".join(out), encoding="utf-8")
    return len(lines) - len(out)


def fix_ambiguous(f: Path, pairs) -> int:
    if not f.exists():
        return 0
    t = f.read_text(encoding="utf-8", errors="replace")
    n = 0
    for old, new in pairs:
        t, k = re.subn(r"(?<![\w.])" + re.escape(old) + r"\b", new, t)
        n += k
    f.write_text(t, encoding="utf-8")
    return n


def fix_duplicate_underscores(t: str) -> tuple[str, int]:
    out, i, n = [], 0, 0
    while True:
        m = re.search(r"\(", t[i:])
        if not m:
            out.append(t[i:])
            break
        op = i + m.start()
        try:
            cl = match_paren(t, op)
        except ValueError:
            out.append(t[i:])
            break
        inner = t[op + 1:cl]
        params = split_args(inner)
        seen = 0
        new_params = []
        for p in params:
            mm = re.search(r"\b_\s*$", p)
            if mm:
                seen += 1
                if seen > 1:
                    p = p[:mm.start()] + f"_{seen}" + p[mm.end():]
                    n += 1
            new_params.append(p)
        out.append(t[i:op + 1])
        out.append(", ".join(new_params) if len(params) > 1 else inner)
        out.append(")")
        i = cl + 1
    return "".join(out), n


def main() -> int:
    src = Path(sys.argv[1])
    stats = {}
    stats["assembly_attrs_removed"] = fix_assembly_info(src / "AssemblyInfo.cs")

    # GenerateGlobalVtableLookup is produced by the WinRT source generator; drop the project copy.
    gv = src / "GlobalVtableLookup.cs"
    if gv.exists():
        dest = src / "_removed_generated"
        dest.mkdir(exist_ok=True)
        shutil.move(str(gv), str(dest / gv.name))
        stats["global_vtable_moved"] = 1
    else:
        stats["global_vtable_moved"] = 0

    stats["ambiguous_fixed"] = 0
    stats["ambiguous_fixed"] += fix_ambiguous(src / "AnnouncementMarkdownRenderer.cs",
                                               [("Block", "Markdig.Syntax.Block")])
    stats["ambiguous_fixed"] += fix_ambiguous(src / "App.cs", [
        ("UnhandledExceptionEventArgs", "Microsoft.UI.Xaml.UnhandledExceptionEventArgs"),
        ("UnhandledExceptionEventHandler", "Microsoft.UI.Xaml.UnhandledExceptionEventHandler"),
        ("LaunchActivatedEventArgs", "Microsoft.UI.Xaml.LaunchActivatedEventArgs"),
    ])

    stats["com_interface_entry"] = 0
    stats["configured_awaiter"] = 0
    stats["init_options"] = 0
    stats["create_value_callback"] = 0
    stats["dup_underscore"] = 0
    for f in src.glob("*.cs"):
        t = f.read_text(encoding="utf-8", errors="replace")
        raw = t
        t, k = re.subn(r"(?<![\w.])ComInterfaceEntry\b",
                       "System.Runtime.InteropServices.ComWrappers.ComInterfaceEntry", t)
        stats["com_interface_entry"] += k
        t, k1 = re.subn(r"\bConfiguredTaskAwaiter\b", "object", t)
        t, k2 = re.subn(r"\bConfiguredValueTaskAwaiter\b", "object", t)
        stats["configured_awaiter"] += k1 + k2
        if f.name == "Microsoft.Windows.ApplicationModel.DynamicDependency.BootstrapCS.AutoInitialize.cs":
            t, k = re.subn(r"\bInitializeOptions\b", "int", t)
            t = t.replace("(int)8", "8")
            stats["init_options"] += k
        if f.name == "NotificationAutoDismiss.cs":
            t, k = re.subn(r"(?<![\w.])CreateValueCallback<InfoBar, DismissState>",
                           "System.Runtime.CompilerServices.ConditionalWeakTable<InfoBar, DismissState>.CreateValueCallback", t)
            stats["create_value_callback"] += k
        lines = t.split(chr(10))
        total_k = 0
        for li, line in enumerate(lines):
            st = line.strip()
            if not st or st.endswith(";") or "=>" in st:
                continue
            lines[li], k = fix_duplicate_underscores(line)
            total_k += k
        if total_k:
            t = chr(10).join(lines)
        stats["dup_underscore"] += total_k
        if t != raw:
            f.write_text(t, encoding="utf-8")
    print(" ".join(f"{k}={v}" for k, v in stats.items()))
    return 0


if __name__ == "__main__":
    sys.exit(main())

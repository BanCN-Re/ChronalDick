#!/usr/bin/env python3
"""Emit explicitly-marked stubs for Reactor proxies whose target was never recovered.

The helper's cctor depends on the module cctor that throws BadImageFormatException in the original
assembly, so its delegate target is unavailable. These 5% of proxies get a typed no-op stub with an
UNRESOLVED marker instead of a guessed target. Signatures come from tm2 (metadata), not from names.
usage: stub_unresolved.py <src-dir> <helper-targets.tsv> <tm2.tsv>
"""
import pathlib
import re
import sys

from rewrite_helpers import cs_type, split_top


def csparam(t: str) -> str:
    t = t.strip()
    if t.endswith("&"):
        return "ref " + cs_type(t[:-1])
    return cs_type(t)


def main() -> int:
    src = pathlib.Path(sys.argv[1])
proxy_name = sys.argv[4] if len(sys.argv) > 4 else "RPqLKGHxrab"
    rows = [l.split("\t") for l in pathlib.Path(sys.argv[2]).read_text(encoding="utf-8").splitlines()[1:] if l.strip()]
    unresolved = [r[0] for r in rows if len(r) >= 6 and not r[5].startswith("ok")]

    sig, fields = {}, {}
    for line in pathlib.Path(sys.argv[3]).read_text(encoding="utf-8").splitlines()[1:]:
        p = line.split("\t")
        if len(p) < 6:
            continue
        if p[0] == "METHOD" and p[3] == proxy_name:
            sig[p[2]] = p[5]
        elif p[0] == "FIELD" and p[2] in unresolved:
            fields.setdefault(p[2], []).append(p[3])

    texts = [f.read_text(encoding="utf-8", errors="replace") for f in src.glob("*.cs")]
    made = 0
    for h in unresolved:
        for t in texts:
            for fld in re.findall(re.escape(h) + r"\.([A-Za-z_][A-Za-z0-9_]*)", t):
                if fld != "RPqLKGHxrab":
                    fields.setdefault(h, []).append(fld)
        s = sig.get(h)
        if not s:
            continue
        m = re.match(r"^(.+)\((.*)\)$", s)
        if not m:
            continue
        ret = cs_type(m.group(1))
        params = split_top(m.group(2))
        args = params[:-1] if params and params[-1] == h else params
        plist = ", ".join(f"{csparam(t)} P_{i}" for i, t in enumerate(args))
        if plist:
            plist += ", object P_sentinel"
        else:
            plist = "object P_sentinel"
        csharp_ret = "void" if ret == "System.Void" else ret
        body = "{\n\t\treturn default;\n\t}" if ret != "System.Void" else "{ }"
        lines = [
            "// UNRESOLVED Reactor proxy: the module cctor throws BadImageFormatException in the original",
            "// assembly, so this delegate target was never decrypted. Signature from metadata (tm2).",
            f"internal static class {h}",
            "{",
        ]
        for f in sorted(set(fields.get(h, []))):
            lines.append(f"\tinternal static object {f};")
        lines.append(f"\tinternal static {csharp_ret} RPqLKGHxrab({plist})")
        lines.append("\t" + body)
        lines.append("}")
        (src / f"{h}.cs").write_text("\n".join(lines) + "\n", encoding="utf-8")
        made += 1
    print(f"unresolved_stubs={made}")
    return 0


if __name__ == "__main__":
    sys.exit(main())

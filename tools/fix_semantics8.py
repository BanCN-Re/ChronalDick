#!/usr/bin/env python3
"""Eighth pass: restore mis-typed locals, flatten remaining events, disambiguate types,
replace isinst placeholders and bare throws."""
import re
import sys
from pathlib import Path

from csbraces import deltas

SRC = Path(sys.argv[1])


def rewrite_all(fn, rules):
    p = SRC / fn
    if not p.exists():
        return 0
    t = p.read_text(encoding="utf-8", errors="replace")
    raw = t
    n = 0
    for rx, rep in rules:
        t, k = rx.subn(rep, t)
        n += k
    if t != raw:
        p.write_text(t, encoding="utf-8")
    return n


# 1) AppShell: the CS1503 pass turned an object local into bool by mistake
rewrite_all("AppShell.cs", [
    (re.compile(r"bool obj = default;"), "object obj = __O_12._0___OnAuthenticationExpired;"),
])

# 2) flatten remaining events (type may contain global:: and ?)
EV = re.compile(r"^(?P<indent>[ \t]*)(?P<mods>(?:(?:public|private|internal|protected|static|new|unsafe|sealed|override|readonly)[ \t]+)*)"
                r"event[ \t]+(?P<type>[A-Za-z_][A-Za-z0-9_.:<>,?\[\] \t]*?)[ \t]+(?P<name>[A-Za-z_][A-Za-z0-9_]*)"
                r"(?P<rest>[ \t]*\{?[ \t]*)$")
flat = 0
for f in SRC.glob("*.cs"):
    lines = f.read_text(encoding="utf-8", errors="replace").split("\n")
    bd = deltas("\n".join(lines))
    out, i, changed = [], 0, False
    while i < len(lines):
        m = EV.match(lines[i])
        if not m:
            out.append(lines[i]); i += 1; continue
        decl = f"{m.group('indent')}{m.group('mods')}{m.group('type')} {m.group('name')};"
        j = i + 1
        while j < len(lines) and not lines[j].strip():
            j += 1
        if j < len(lines) and lines[j].strip() == "{":
            depth, k = 0, j
            while k < len(lines):
                depth += bd[k]
                if depth == 0:
                    break
                k += 1
            out.append(decl); i = k + 1; flat += 1; changed = True; continue
        out.append(decl); i += 1; flat += 1; changed = True
    if changed:
        f.write_text("\n".join(out), encoding="utf-8")

# 3) AnnouncementMarkdownRenderer: Markdig vs XAML Inline
n_inline = rewrite_all("AnnouncementMarkdownRenderer.cs", [
    (re.compile(r"for \(Inline "), "for (Markdig.Syntax.Inlines.Inline "),
    (re.compile(r"(?m)^([ \t]*)Inline val2 = val;"), r"\1Markdig.Syntax.Inlines.Inline val2 = val;"),
    (re.compile(r"\(Inline\)(?=\(object\)val9|new Run|new LineBreak|\(object\)val)"),
     "(Microsoft.UI.Xaml.Documents.Inline)"),
])

# 4) HookLoginPage: Path is ambiguous with Microsoft.UI.Xaml.Shapes.Path
n_path = rewrite_all("HookLoginPage.cs", [
    (re.compile(r"(?<![\w.])Path\.(?=(?:Get|Combine))"), "System.IO.Path."),
])

# 5) PaymentCenterPage: DependencyObject ambiguity
n_dep = rewrite_all("PaymentCenterPage.cs", [
    (re.compile(r"\(\(DependencyObject\)this\)"), "((Microsoft.UI.Xaml.DependencyObject)this)"),
])

# 6) isinst placeholders -> default(T)
n_inst = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"\(([A-Za-z_][A-Za-z0-9_.<>]*)\)[ \t]*/\*isinst with value type is only supported in some contexts\*/",
                    r"default(\1)", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        n_inst += n

# 7) bare throw outside catch
n_throw = 0
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^([ \t]*)throw;[ \t]*\r?\n", r"\1throw new global::System.Exception();\n", t)
    if n:
        f.write_text(t2, encoding="utf-8")
        n_throw += n

print(f"events_flat={flat} inline={n_inline} path={n_path} dep={n_dep} isinst={n_inst} bare_throw={n_throw}")

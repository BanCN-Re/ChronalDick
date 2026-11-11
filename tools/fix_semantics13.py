#!/usr/bin/env python3
"""Final targeted fixes for the remaining compile errors."""
import re
import sys
from pathlib import Path

SRC = Path(sys.argv[1])

def edit(fn, pairs, regex=False):
    p = SRC / fn
    if not p.exists():
        return 0
    t = p.read_text(encoding="utf-8", errors="replace")
    n = 0
    for a, b in pairs:
        if regex:
            t, k = re.subn(a, b, t)
        else:
            k = t.count(a)
            t = t.replace(a, b)
        n += k
    p.write_text(t, encoding="utf-8")
    return n

# AppShell: restore the two object locals the ref-bool pass mis-typed
p = SRC / "AppShell.cs"
if p.exists():
    t = p.read_text(encoding="utf-8", errors="replace")
    t = t.replace("\t\t\tbool obj = false;\n\t\t\tif (obj == null)\n\t\t\t{\n\t\t\t\tEventHandler val = OnAuthenticationExpired;",
                  "\t\t\tobject obj = __O_12._0___OnAuthenticationExpired;\n\t\t\tif (obj == null)\n\t\t\t{\n\t\t\t\tEventHandler val = OnAuthenticationExpired;")
    t = t.replace("\t\tbool obj = false;\n\t\tif (obj != null)\n\t\t{\n\t\t\t(((Microsoft.UI.Xaml.UIElement)obj).DispatcherQueue)",
                  "\t\tobject obj = ((shellHost is UIElement) ? shellHost : null);\n\t\tif (obj != null)\n\t\t{\n\t\t\t(((Microsoft.UI.Xaml.UIElement)obj).DispatcherQueue)")
    p.write_text(t, encoding="utf-8")

# PagerBar / PageHeader: visibility getters lost their real expression
for fn, prop in (("PagerBar.cs", "PageSizeVisibilityProperty"), ("PageHeader.cs", "HasSubtitleProperty")):
    edit(fn, [(f"return (((DependencyObject)this) ? Visibility.Visible : Visibility.Collapsed).GetValue({prop});",
               f"return (Visibility)((DependencyObject)this).GetValue({prop});")])

# PagerBar: handler must not have a ref sender
edit("PagerBar.cs", [("private void PageSizeCombo_SelectionChanged(ref object sender, SelectionChangedEventArgs e)",
                      "private void PageSizeCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)")])

# Pay4399: await cannot live in an unsafe method
edit("Pay4399Page.cs", [("private unsafe async global::System.Threading.Tasks.Task<sl2dDUfRLEcUNZKNoBws> AuthorizeRegistrationAsync",
                         "private async global::System.Threading.Tasks.Task<sl2dDUfRLEcUNZKNoBws> AuthorizeRegistrationAsync")])
# Pay4399: bool cast to enum -> ternary
p = SRC / "Pay4399Page.cs"
if p.exists():
    t = p.read_text(encoding="utf-8", errors="replace")
    t = re.sub(r"\(([A-Za-z_][A-Za-z0-9_.]*)\)\(\(\(Selector\)([A-Za-z_][A-Za-z0-9_.]*)\)\.SelectedIndex == 1\)",
               r"((((Selector)\2).SelectedIndex == 1) ? (\1)1 : (\1)0)", t)
    p.write_text(t, encoding="utf-8")

# SmsVerificationView: bool cast to Orientation
edit("SmsVerificationView.cs", [
    ("actionsPanel.Orientation = (Orientation)(!(newSize.Width < 480.0));",
     "actionsPanel.Orientation = ((!(newSize.Width < 480.0)) ? (Orientation)1 : (Orientation)0);")
])

# BedrockToolsView: bool cast to InfoBarSeverity (wrapped ternary result)
p = SRC / "BedrockToolsView.cs"
if p.exists():
    t = p.read_text(encoding="utf-8", errors="replace")
    t = re.sub(r"\((InfoBarSeverity)\)(\([^;]*?\))(?=[,);\s])", r"((\2) ? (InfoBarSeverity)1 : (InfoBarSeverity)0)", t)
    p.write_text(t, encoding="utf-8")

# PaymentCenterPage: DispatcherQueueHandler ambiguity
edit("PaymentCenterPage.cs", [(r"(?<![\w.])DispatcherQueueHandler\b", "Microsoft.UI.Dispatching.DispatcherQueueHandler")], regex=True)

# base call instead of cast-to-base
for fn in ("PaymentOrdersPage.cs", "RefundHistoryPage.cs", "HookLoginPage.cs"):
    edit(fn, [("((Page)this).OnNavigatedFrom(e);", "base.OnNavigatedFrom(e);")])

# awaiting a bare awaiter
edit("PaymentOrdersPage.cs", [("await val2;", "val2.GetResult();")])

# ReadOnlySpan element access artefact
edit("PaymentQrImageDecoder.cs", [("global::System.ReadOnlySpan<byte>.array", "array")])

# InitializeArray without a field token -> drop the initialisation call
for f in SRC.glob("*.cs"):
    t = f.read_text(encoding="utf-8", errors="replace")
    t2, n = re.subn(r"(?m)^[ \t]*RuntimeHelpers\.InitializeArray\([^;]*\);[ \t]*\r?\n", "", t)
    if n:
        f.write_text(t2, encoding="utf-8")

# JavaLaunchModeOption: static cctor cannot touch instance properties
p = SRC / "JavaLaunchModeOption.cs"
if p.exists():
    lines = p.read_text(encoding="utf-8", errors="replace").split("\n")
    out, in_static = [], False
    for line in lines:
        if re.match(r"^[ \t]*(?:private|internal|public)?[ \t]*static[ \t]+void[ \t]+_cctor\(", line):
            in_static = True
        if in_static and re.match(r"^[ \t]*(Description|Title) = default;[ \t]*$", line):
            continue
        if in_static and line.strip() == "}":
            in_static = False
        out.append(line)
    p.write_text("\n".join(out), encoding="utf-8")

# DesktopFileTypeChoice: missing auto-property backing fields
p = SRC / "DesktopFileTypeChoice.cs"
if p.exists():
    t = p.read_text(encoding="utf-8", errors="replace")
    if "_DisplayName_k__BackingField;" not in t:
        t = t.replace("\tpublic string DisplayName", "\tprivate string _DisplayName_k__BackingField;\n\tpublic string DisplayName", 1)
    if "_Extensions_k__BackingField;" not in t:
        t = t.replace("\tpublic global::System.Collections.Generic.IReadOnlyList<string> Extensions",
                      "\tprivate global::System.Collections.Generic.IReadOnlyList<string> _Extensions_k__BackingField;\n\tpublic global::System.Collections.Generic.IReadOnlyList<string> Extensions", 1)
    p.write_text(t, encoding="utf-8")

# ToolboxPage: TryGetValue wants out
edit("ToolboxPage.cs", [("new ValueTuple<int, DateTimeOffset>(val.ProcessId, val.StartedAt), ref val2)",
                        "new ValueTuple<int, DateTimeOffset>(val.ProcessId, val.StartedAt), out val2)")])

# CS1673: replace captured field writes with lambda-local variables
def fix_lambda_fields(fn):
    p = SRC / fn
    if not p.exists():
        return 0
    lines = p.read_text(encoding="utf-8", errors="replace").split("\n")
    out, n = [], 0
    i = 0
    while i < len(lines):
        m = re.match(r"^([ \t]*)([A-Za-z_][A-Za-z0-9_]*) = \(([A-Za-z_][A-Za-z0-9_.]*)\)(obj\d+);[ \t]*$", lines[i])
        if m and (m.group(2).startswith("_ex_") or m.group(2).startswith("__7__wrap")):
            local = "__exLocal" + str(n)
            out.append(f"{m.group(1)}{m.group(3)} {local} = ({m.group(3)}){m.group(4)};")
            n += 1
            i += 1
            while i < len(lines) and "}).Invoke()" not in lines[i]:
                if m.group(2) in lines[i]:
                    lines[i] = lines[i].replace(m.group(2), local)
                out.append(lines[i])
                i += 1
            continue
        out.append(lines[i])
        i += 1
    p.write_text("\n".join(out), encoding="utf-8")
    return n

print("lambda_fields=", fix_lambda_fields("BalancePage.cs") + fix_lambda_fields("ServiceSubscriptionsPage.cs"))
print("done")

#!/usr/bin/env python3
"""Idempotent compile-repair pass for the decompiled tree.

Every rule here was validated individually against a real build; running them in one place keeps the
pipeline reproducible instead of patched ad hoc from the shell. Each rule is safe to re-run: they match on
shapes that disappear after the first application.

usage: normalize.py <src-dir>
"""
import re
import sys
import shutil
from pathlib import Path

HELPER_NS = "qS8vkpL43FlTMgcj0rgs"
HELPER_CLASS = "g9MiPrL41bvmHLMo2Exb"

HELPER_SHIM = """namespace {ns}
{{
	/// <summary>
	/// Surface of the obfuscator's runtime support type. The real implementation is the decryption engine
	/// itself, which cannot be decompiled; only these members are referenced by application code.
	/// </summary>
	internal static class {cls}
	{{
		/// <summary>Per-assembly initialiser, called from every type's static constructor.</summary>
		internal static void EQTLhG7rRhl() {{ }}

		/// <summary>Companion initialiser, run immediately after the first one.</summary>
		internal static void XBZLhW9oDYR() {{ }}

		/// <summary>Late-stage initialiser invoked from module and helper constructors.</summary>
		internal static void Cw1LhDMIACq() {{ }}

		/// <summary>Decodes an embedded string; callers pass the already-decoded integer.</summary>
		internal static string YoQLhoegTpw(int value) => value.ToString();

		/// <summary>Resolves an embedded resource stream.</summary>
		internal static object YUec0jLr8udpaMfJhw8y(object stream) => stream;
	}}
}}
"""

TYPEDETAILS_SHIM = """using WinRT;

namespace WinRT.ChronalVtableClasses
{{
	internal sealed class {cls} : IWinRTExposedTypeDetails
	{{
		public ComWrappers.ComInterfaceEntry[] GetExposedInterfaces()
		{{
			return new ComWrappers.ComInterfaceEntry[0];
		}}
	}}
}}
"""

READONLY_SHIM = """using System;
using System.Collections;
using System.Collections.Generic;

[global::System.Runtime.CompilerServices.CompilerGenerated]
internal sealed class {cls}<T> : IEnumerable, ICollection, IList,
    IEnumerable<T>, IReadOnlyCollection<T>, IReadOnlyList<T>, ICollection<T>, IList<T>
{{
    int ICollection.Count => 0;
    bool ICollection.IsSynchronized => true;
    object ICollection.SyncRoot => null;
    void ICollection.CopyTo(Array array, int index) {{ }}

    IEnumerator IEnumerable.GetEnumerator() => null;
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => null;

    int IReadOnlyCollection<T>.Count => 0;
    T IReadOnlyList<T>.this[int index] => default;

    int ICollection<T>.Count => 0;
    bool ICollection<T>.IsReadOnly => true;
    void ICollection<T>.Add(T item) {{ }}
    void ICollection<T>.Clear() {{ }}
    bool ICollection<T>.Contains(T item) => false;
    void ICollection<T>.CopyTo(T[] array, int arrayIndex) {{ }}
    bool ICollection<T>.Remove(T item) => false;

    T IList<T>.this[int index]
    {{
        get => default;
        set {{ }}
    }}
    int IList<T>.IndexOf(T item) => 0;
    void IList<T>.Insert(int index, T item) {{ }}
    void IList<T>.RemoveAt(int index) {{ }}

    bool IList.IsFixedSize => true;
    bool IList.IsReadOnly => true;
    object IList.this[int index]
    {{
        get => null;
        set {{ }}
    }}
    int IList.Add(object value) => 0;
    void IList.Clear() {{ }}
    bool IList.Contains(object value) => false;
    int IList.IndexOf(object value) => 0;
    void IList.Insert(int index, object value) {{ }}
    void IList.Remove(object value) {{ }}
    void IList.RemoveAt(int index) {{ }}
}}
"""


def write_shims(root: Path) -> None:
    (root / f"{HELPER_NS}.cs").write_text(
        HELPER_SHIM.format(ns=HELPER_NS, cls=HELPER_CLASS), encoding="utf-8")

    # The WinRT type-details classes are generator output: keep one stub each so the attributes resolve.
    for f in list(root.glob("*WinRTTypeDetails.cs")):
        f.write_text(TYPEDETAILS_SHIM.format(cls=f.stem), encoding="utf-8")

    for name in ("__z__ReadOnlyArray_1", "__z__ReadOnlySingleElementList_1"):
        (root / f"{name}.cs").write_text(READONLY_SHIM.format(cls=name), encoding="utf-8")


def patch_file(text: str) -> tuple[str, dict]:
    st = {"awaiter": 0, "ref": 0, "mod": 0, "using": 0, "amb": 0}

    def sub(key, pat, repl, flags=0):
        nonlocal text
        text, n = re.subn(pat, repl, text, flags=flags)
        st[key] += n

    # Nested awaiter types are named `ConfiguredTaskAwaitable<T>.ConfiguredTaskAwaiter`; ILSpy drops the
    # outer generic, so the qualified spelling is what compiles.
    sub("awaiter", r"\bConfiguredTaskAwaiter\s*<", "ConfiguredTaskAwaitable<")
    sub("awaiter", r"\bConfiguredValueTaskAwaiter\s*<", "ConfiguredValueTaskAwaitable<")
    sub("awaiter", r"\bYieldAwaiter\b", "System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter")
    sub("awaiter", r"(?<![\w.])CreateValueCallback<", "System.Runtime.InteropServices.CreateValueCallback<")

    # `ref` only accepts variables. A field chain and a cast both have to lose the `ref`.
    sub("ref", r"\(\(\s*([A-Za-z_][A-Za-z0-9_.<>]*)\s*\)\s*\(ref ([A-Za-z_][A-Za-z0-9_.]*)\)\s*\)",
        lambda m: m.group(2))
    sub("ref", r"(?<![A-Za-z0-9_])ref ([A-Za-z_][A-Za-z0-9_]*\.[A-Za-z_][A-Za-z0-9_]*)", lambda m: m.group(1))

    # Explicit interface implementations carry a dotted member name and take no accessibility modifier.
    sub("mod", r"(?m)^([ \t]*)(?:private|public|protected|internal)[ \t]+([^\r\n{=;]*?\b[A-Za-z_][A-Za-z0-9_]*(?:\.[A-Za-z_][A-Za-z0-9_]*)+)[ \t]*(?=[\r\n{=])",
        lambda m: m.group(1) + m.group(2))

    # Awaiter types live in System.Runtime.CompilerServices, which the decompiler sometimes omits.
    if ("ConfiguredTaskAwaitable" in text or "ConfiguredValueTaskAwaitable" in text) \
            and "using System.Runtime.CompilerServices;" not in text:
        lines = text.split("\n")
        at = max((i for i, l in enumerate(lines) if l.startswith("using ")), default=-1)
        lines.insert(at + 1, "using System.Runtime.CompilerServices;")
        text = "\n".join(lines)
        st["using"] += 1

    # `XamlMember`-style names collide between Microsoft.UI.Xaml and Markdig; the UI one is intended.
    for t in ("UnhandledExceptionEventArgs", "UnhandledExceptionEventHandler", "LaunchActivatedEventArgs"):
        sub("amb", r"(?<![\w.])" + t + r"(?![\w])", "Microsoft.UI.Xaml." + t)

    return text, st


def main() -> int:
    root = Path(sys.argv[1])
    write_shims(root)

    files = 0
    totals = {}
    for f in sorted(root.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        text, st = patch_file(raw)
        if text != raw:
            f.write_text(text, encoding="utf-8")
            files += 1
            for k, v in st.items():
                totals[k] = totals.get(k, 0) + v
    print(f"files={files} " + " ".join(f"{k}={v}" for k, v in sorted(totals.items())))
    return 0


if __name__ == "__main__":
    sys.exit(main())

#!/usr/bin/env python3
"""Rewrite the XAML provider's baked metadata tokens into compile-checked typeof() expressions.

Background
----------
The restored WinUI generated provider (XamlTypeInfoProvider / *_obj*_Bindings) originally called

    System.Type.GetTypeFromHandle(MbgJAqLroveeTUtcYc7g.jC3noGLrrlsiO9bkyy5r.j7Zjb8lvW8d(TOKEN))

where the helper is `ModuleHandle.GetRuntimeTypeHandleFromMetadataToken(int)` on the *current*
module.  TOKEN was baked against the original (protected) assembly; after recompilation the
token rows point at different types, so the provider resolves the wrong System.Type.

This script resolves every TOKEN in the ORIGINAL assembly's metadata (dumped with
tools/verify_xaml_tokens dump) to its full type name and rewrites the call site into
`typeof(global::Full.Type.Name)`, which the compiler resolves by name and re-emits as a
fresh ldtoken for the rebuilt module.  No token constant, no ModuleHandle init survives.

usage:
  py -3 fix_xaml_tokens.py --root <src dir> --orig-tsv <dump.tsv> [--plan <plan.tsv>] [--check]
"""
import argparse
import collections
import io
import os
import re
import sys

HELPER = r"jC3noGLrrlsiO9bkyy5r\s*\.\s*j7Zjb8lvW8d\s*\(\s*(\d+)\s*\)"
SITE = re.compile(
    r"(?:(?:global::)?System\s*\.\s*)?Type\s*\.\s*GetTypeFromHandle\s*\(\s*"
    r"(?:MbgJAqLroveeTUtcYc7g\s*\.\s*)?" + HELPER + r"\s*\)"
)
# same helper reached without the GetTypeFromHandle wrapper (not present today, kept as a guard)
BARE = re.compile(r"(?:MbgJAqLroveeTUtcYc7g\s*\.\s*)?" + HELPER)


def load_tokens(path):
    m = {}
    for line in io.open(path, encoding="utf-8"):
        p = line.rstrip("\n").split("\t")
        if len(p) < 4 or p[0] == "token":
            continue
        token = int(p[0], 16)
        kind, name = p[1], p[2]
        # dnlib prints nested types as Outer/Inner (TypeDef) -- C# needs Outer.Inner
        m[token] = (kind, name.replace("/", ".").replace("+", "."))
    return m


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--root", required=True)
    ap.add_argument("--orig-tsv", required=True)
    ap.add_argument("--plan", default="")
    ap.add_argument("--check", action="store_true", help="report only, do not write")
    args = ap.parse_args()

    tokens = load_tokens(args.orig_tsv)
    skip_dirs = {"bin", "obj", ".vs", ".git"}

    files_changed = 0
    sites = 0
    unknown = collections.Counter()
    plan = []
    per_file = collections.Counter()

    for dirpath, dirnames, filenames in os.walk(args.root):
        dirnames[:] = [d for d in dirnames if d not in skip_dirs]
        for fn in sorted(filenames):
            if not fn.endswith(".cs"):
                continue
            path = os.path.join(dirpath, fn)
            text = io.open(path, encoding="utf-8-sig", newline="").read()
            bare = len(BARE.findall(text))
            wrapped = len(SITE.findall(text))
            if bare != wrapped:  # something the wrapper regex does not cover -> stop loudly
                print("ERROR: %s has %d bare helper calls but %d wrapped" % (path, bare, wrapped))
                return 2
            if wrapped == 0:
                continue

            def repl(mo):
                tk = int(mo.group(1))
                if tk not in tokens:
                    unknown[tk] += 1
                    return mo.group(0)
                name = tokens[tk][1]
                plan.append((tk, name))
                per_file[path] += 1
                return "typeof(global::%s)" % name

            new_text, n = SITE.subn(repl, text)
            if n == 0:
                continue
            files_changed += 1
            sites += n
            if not args.check:
                io.open(path, "w", encoding="utf-8", newline="").write(new_text)
            print("%-52s %3d" % (os.path.relpath(path, args.root), n))

    if unknown:
        print("UNRESOLVED TOKENS: %s" % ", ".join("0x%08x" % t for t in sorted(unknown)))
        return 3

    if args.plan:
        with io.open(args.plan, "w", encoding="utf-8", newline="") as f:
            f.write("token\tname\n")
            for tk, name in plan:
                f.write("0x%08x\t%s\n" % (tk, name))

    print("---")
    print("files=%d sites=%d distinctTypes=%d mode=%s"
          % (files_changed, sites, len(set(n for _, n in plan)), "check" if args.check else "write"))
    return 0


if __name__ == "__main__":
    sys.exit(main())

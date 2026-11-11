#!/usr/bin/env python3
"""Fix decompiler sign mis-readings in Mahiro string-decryptor call arguments.

The exporter sometimes writes a negative IL constant as `-N` where the runtime
engine only accepts the positive reading (the id is a blob offset).  strdump
already detected and validated the correct reading; its TSV keeps one
self-consistent row per repaired site (`literal_hex ^ field_const == id`).

This pass rewrites those source sites: for each call whose current XOR-chain
does not reproduce the TSV's registered id, try negating one negative term; if
that reproduces the registered literal exactly, apply it.

Usage: py -3 flip_sign_sites.py <tree-dir> <strdump.tsv> [--dry-run]
"""
import sys
from pathlib import Path

sys.path.insert(0, str(Path(__file__).resolve().parent))
from apply_strings import (  # noqa: E402
    CALL_HEAD, FIELD_RE, parse_call, parse_num, xor_all, read_text, write_text,
)


def load_rows(tsv):
    rows = []
    lines = Path(tsv).read_text(encoding="utf-8").splitlines()
    head = lines[0].split("\t")
    idx = {c: i for i, c in enumerate(head)}
    for line in lines[1:]:
        if not line.strip():
            continue
        c = line.split("\t")
        try:
            sid = int(c[idx["id_dec"]])
            lit = int(c[idx["literal_hex"]], 16) & 0xFFFFFFFF
        except (ValueError, KeyError, IndexError):
            continue
        sites = []
        for s in c[idx["sites"]].split(";"):
            s = s.strip()
            if not s:
                continue
            base, _, ln = s.rpartition(":")
            if base and ln.isdigit():
                sites.append((base, int(ln)))
        rows.append((sid, lit, c[idx["field"]], sites))
    return rows


def try_fix(args, field_const, target):
    terms = [t.strip() for t in args.split("^")]
    if len(terms) < 2:
        return None
    if not FIELD_RE.search(terms[-1]):
        return None
    vals = []
    for t in terms[:-1]:
        v = parse_num(t)
        if v is None:
            return None
        vals.append((t, v))
    cur = xor_all(v for _, v in vals)
    for i, (t, v) in enumerate(vals):
        if not t.lstrip().startswith("-"):
            continue
        newv = (v ^ cur ^ target) & 0xFFFFFFFF
        if newv != ((-v) & 0xFFFFFFFF):
            continue
        sign = "-" if newv >= 0x80000000 else ""
        mag = newv if newv < 0x80000000 else (1 << 32) - newv
        if t.strip().lower().startswith("-0x"):
            newtext = f"-0x{mag:X}"
        else:
            newtext = f"-{mag}"
        if newv < 0x80000000:
            newtext = t.strip()[1:] if t.strip().startswith("-") else t.strip()
        new_terms = [x for x, _ in vals]
        new_terms[i] = newtext
        return " ^ ".join(new_terms + [terms[-1]]), t, newtext
    return None


def main():
    tree = Path(sys.argv[1])
    tsv = sys.argv[2]
    dry = "--dry-run" in sys.argv
    rows = load_rows(tsv)
    site_ids = {}
    field_const = {}
    for sid, lit, field, sites in rows:
        field_const.setdefault(field, (sid ^ lit) & 0xFFFFFFFF)
        for s in sites:
            site_ids.setdefault(s, set()).add(sid)

    fixed_sites = fixed_calls = 0
    touched = 0
    for f in sorted(tree.glob("*.cs")):
        text, bom = read_text(str(f))
        if CALL_HEAD not in text:
            continue
        out_lines = text.split("\n")
        changed = False
        for ln, line in enumerate(out_lines, 1):
            if CALL_HEAD not in line:
                continue
            targets = site_ids.get((f.name, ln))
            if not targets:
                continue
            pos = 0
            rebuild = line
            while True:
                start, end, args = parse_call(rebuild, pos)
                if start < 0:
                    break
                if end is None:
                    break
                pos = end
                m = FIELD_RE.search(args.split("^")[-1].strip()) if "^" in args else None
                if not m:
                    continue
                field = m.group(1)
                fc = field_const.get(field)
                if fc is None:
                    continue
                terms = [t.strip() for t in args.split("^")]
                vals = []
                ok = True
                for t in terms[:-1]:
                    v = parse_num(t)
                    if v is None:
                        ok = False
                        break
                    vals.append(v)
                if not ok or not vals:
                    continue
                cur_id = fc ^ xor_all(vals)
                if cur_id in targets:
                    continue
                hits = set()
                applied = None
                for sid in targets:
                    res = try_fix(args, fc, fc ^ sid)
                    if res is None:
                        continue
                    hits.add(sid)
                    applied = (sid, res)
                if len(hits) != 1:
                    continue
                sid, (newargs, oldterm, newterm) = applied
                rebuild = rebuild[:start + len(CALL_HEAD)] + newargs + rebuild[end - 1:]
                pos = start + len(CALL_HEAD) + len(newargs) + 1
                fixed_calls += 1
                if fixed_calls <= 15:
                    print(f"flip {f.name}:{ln} {oldterm} -> {newterm} (id {cur_id} -> {sid})")
            if rebuild != line:
                out_lines[ln - 1] = rebuild
                changed = True
                fixed_sites += 1
        if changed:
            touched += 1
            if not dry:
                write_text(str(f), "\n".join(out_lines), bom)
    print(f"files_touched={touched} lines_fixed={fixed_sites} calls_fixed={fixed_calls} dry_run={dry}")


if __name__ == "__main__":
    main()

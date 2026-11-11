#!/usr/bin/env python3
r"""Replace Mahiro string-decryption calls with recovered plaintext literals.

Call shape (produced by ILSpy from the protected assembly):

    LFHd1ojfYcRKGDVUDAUb.yjMjfFekXfb(<lit> ^ [<lit> ^ ...] ^ _Module__x_.m_OUTER.m_FIELD)

The XOR of the literals combined with the field's runtime constant yields the
string id; ``strings.tsv`` maps (id) -> plaintext and also records every
``basename:line`` site that belongs to that id.

Two resolution strategies:

  strategy1_line        the (basename, line) pair is listed in the TSV ``sites``
                        column and the call on that line resolves to an id in
                        that line's id set (or the line holds exactly one id).
  strategy2_field       fallback when line numbers drifted (different export):
                        id = field_const ^ xor(literals), looked up in the TSV;
                        if the literals cannot be parsed, a field that maps to a
                        single id is accepted.

Anything else is reported as ``ambiguous`` (field known, several candidate ids,
no exact hit) or ``unmatched`` (unknown field / literals / id) and left as-is.

Escaping: the TSV ``plaintext`` column was written by strdump's Esc(), which
doubles backslashes and turns TAB/LF/CR into ``\t``/``\n``/``\r`` (quotes stay
raw). It is un-escaped on load (``--raw-plaintext`` disables that) and the
replacement literal is produced with ``json.dumps`` -- C# and JSON share the
same escaping for ``\\``, ``\"``, ``\t``, ``\n``, ``\r``, ``\b``, ``\f`` and
``\uXXXX``.

Usage:
  py -3 apply_strings.py <tree-dir> <strings.tsv> [--dry-run]
                         [--file-map OLD=NEW ...] [--report out.json]
                         [--report-tsv out.tsv] [--samples N]

Write mode edits files in place; always run it on a copy (Copy-first).
"""

import argparse
import json
import os
import re
import sys
from collections import defaultdict

RECEIVER = "LFHd1ojfYcRKGDVUDAUb.yjMjfFekXfb"
CALL_HEAD = RECEIVER + "("

# Last component of `_Module__....m_OUTER.m_FIELD`
FIELD_RE = re.compile(r"_Module__[A-Za-z0-9_]+\.(?:m_[0-9a-fA-F]+\.)?(m_[0-9a-fA-F]+)\s*$")
NUM_RE = re.compile(r"^([+-]*)(0[xX][0-9A-Fa-f]+|[0-9]+)$")

S1_LINE = "strategy1_line"
S2_FL = "strategy2_field_literal"
S2_FU = "strategy2_field_unique"
AMB = "ambiguous"
UNM = "unmatched"
UNP = "unparsed"


def unescape_tsv(text):
    """Invert strdump's Esc(): the TSV stores `\\\\`->`\\`, `\\t`, `\\n`, `\\r`.

    Quotes are NOT escaped in the TSV, so `\\X` for any other X cannot occur;
    such sequences are kept verbatim for safety.
    """
    if "\\" not in text:
        return text
    out = []
    i = 0
    n = len(text)
    while i < n:
        ch = text[i]
        if ch == "\\" and i + 1 < n:
            nxt = text[i + 1]
            mapped = {"\\": "\\", "t": "\t", "n": "\n", "r": "\r"}.get(nxt)
            if mapped is not None:
                out.append(mapped)
                i += 2
                continue
        out.append(ch)
        i += 1
    return "".join(out)


def parse_num(token):
    """Parse a C# int literal term, including `-N`, `--N` and hex forms."""
    m = NUM_RE.match(token.strip())
    if not m:
        return None
    signs, num = m.group(1), m.group(2)
    try:
        value = int(num, 16) if num[:2].lower() == "0x" else int(num, 10)
    except ValueError:
        return None
    if signs.count("-") % 2 == 1:
        value = -value
    return value & 0xFFFFFFFF  # C# int arithmetic wraps modulo 2**32


class Table:
    def __init__(self, tsv_path, unescape=True):
        self.id_text = {}          # id -> plaintext
        self.id_conflict = 0
        self.field_const = {}      # field -> runtime constant (id ^ literal)
        self.field_const_conflict = 0
        self.field_lit = {}        # (field, literal) -> set(ids)
        self.field_ids = defaultdict(set)  # field -> set(ids)
        self.sites = defaultdict(set)      # (basename, line) -> set(ids)
        self.rows = 0
        self.unescaped_rows = 0
        self.unescape = unescape
        self._load(tsv_path)

    def _load(self, path):
        with open(path, encoding="utf-8", newline="") as fh:
            header = fh.readline().rstrip("\r\n").split("\t")
            idx = {name: i for i, name in enumerate(header)}
            for need in ("id_dec", "id_hex", "plaintext", "field", "literal_hex", "sites"):
                if need not in idx:
                    raise SystemExit("TSV missing column: %s" % need)
            for raw in fh:
                cols = raw.rstrip("\r\n").split("\t")
                if len(cols) < len(header):
                    continue
                sid = int(cols[idx["id_hex"]], 16)
                text = cols[idx["plaintext"]]
                if self.unescape:
                    un = unescape_tsv(text)
                    if un != text:
                        self.unescaped_rows += 1
                    text = un
                field = cols[idx["field"]]
                lit = cols[idx["literal_hex"]]
                self.rows += 1
                prev = self.id_text.get(sid)
                if prev is not None and prev != text:
                    self.id_conflict += 1
                else:
                    self.id_text[sid] = text
                try:
                    const = sid ^ (int(lit, 16) & 0xFFFFFFFF)
                except ValueError:
                    const = None
                if const is not None:
                    prevc = self.field_const.get(field)
                    if prevc is not None and prevc != const:
                        self.field_const_conflict += 1
                    else:
                        self.field_const[field] = const
                    self.field_lit.setdefault((field, const), set()).add(sid)
                self.field_ids[field].add(sid)
                for site in cols[idx["sites"]].split(";"):
                    site = site.strip()
                    if not site:
                        continue
                    base, _, line = site.rpartition(":")
                    if not base or not line.isdigit():
                        continue
                    self.sites[(base, int(line))].add(sid)


def parse_call(line, pos):
    """Locate the next complete call at/after pos on this physical line.

    Returns (start, end, args) or (start, None, None) when the parens do not
    balance on the line (multi-line expression -> left untouched).
    """
    start = line.find(CALL_HEAD, pos)
    if start < 0:
        return -1, None, None
    i = start + len(CALL_HEAD)
    depth = 1
    n = len(line)
    while i < n:
        ch = line[i]
        if ch == "(":
            depth += 1
        elif ch == ")":
            depth -= 1
            if depth == 0:
                return start, i + 1, line[start + len(CALL_HEAD):i]
        i += 1
    return start, None, None


def parse_args(args):
    """Split call args into (literals, field). Returns (None, None) on failure."""
    terms = [t.strip() for t in args.split("^")]
    if len(terms) < 2:
        return None, None
    m = FIELD_RE.search(terms[-1])
    if not m:
        return None, None
    field = m.group(1)
    lits = []
    for term in terms[:-1]:
        val = parse_num(term)
        if val is None:
            return None, field  # field known, literals unparsable
        lits.append(val)
    return lits, field


def xor_all(values):
    acc = 0
    for v in values:
        acc ^= v
    return acc & 0xFFFFFFFF


def resolve(line_ids, lits, field, table):
    """Decide the plaintext for one call. Returns (status, text, id)."""
    computed = None
    if lits is not None and field in table.field_const:
        computed = table.field_const[field] ^ xor_all(lits)

    if line_ids:
        if computed is not None and computed in line_ids:
            return S1_LINE, table.id_text.get(computed), computed
        if computed is None and len(line_ids) == 1:
            sid = next(iter(line_ids))
            return S1_LINE, table.id_text.get(sid), sid

    if computed is not None:
        text = table.id_text.get(computed)
        if text is not None:
            return S2_FL, text, computed
        if field in table.field_lit and (field, xor_all(lits)) in table.field_lit:
            pass  # unreachable in practice; kept for clarity
        return UNM, None, computed

    ids = table.field_ids.get(field, set())
    if len(ids) == 1:
        sid = next(iter(ids))
        return S2_FU, table.id_text.get(sid), sid
    if len(ids) > 1:
        return AMB, None, None
    return UNM, None, None


def read_text(path):
    with open(path, "rb") as fh:
        data = fh.read()
    bom = data.startswith(b"\xef\xbb\xbf")
    text = data.decode("utf-8-sig", errors="replace")
    return text, bom


def write_text(path, text, bom):
    data = text.encode("utf-8")
    if bom:
        data = b"\xef\xbb\xbf" + data
    with open(path, "wb") as fh:
        fh.write(data)


def main(argv=None):
    ap = argparse.ArgumentParser(description=__doc__.splitlines()[0])
    ap.add_argument("tree", help="source tree to scan (directory)")
    ap.add_argument("tsv", help="mahiro-strings.tsv")
    ap.add_argument("--dry-run", action="store_true", help="report only, never write")
    ap.add_argument("--file-map", action="append", default=[], metavar="OLD=NEW",
                    help="rename map for strategy 1 (repeatable, ';' separated)")
    ap.add_argument("--report", metavar="PATH", help="write JSON report here")
    ap.add_argument("--report-tsv", metavar="PATH", help="write per-file TSV report here")
    ap.add_argument("--samples", type=int, default=40, help="changes kept in the JSON report")
    ap.add_argument("--raw-plaintext", action="store_true",
                    help="keep the TSV plaintext verbatim (default: undo strdump's "
                         "backslash/tab/newline/CR escaping)")
    args = ap.parse_args(argv)

    tree = os.path.abspath(args.tree)
    if not os.path.isdir(tree):
        raise SystemExit("not a directory: %s" % tree)

    fmap = {}
    for item in args.file_map:
        for pair in item.split(";"):
            pair = pair.strip()
            if not pair:
                continue
            if "=" not in pair:
                raise SystemExit("bad --file-map entry: %s" % pair)
            old, new = pair.split("=", 1)
            fmap[old.strip().replace("\\", "/")] = new.strip().replace("\\", "/")

    table = Table(args.tsv, unescape=not args.raw_plaintext)

    stats = defaultdict(int)
    per_file = []
    samples = []
    amb_samples = []
    unm_samples = []
    files = []
    for root, _dirs, names in os.walk(tree):
        for name in sorted(names):
            if name.endswith(".cs"):
                files.append(os.path.join(root, name))

    for path in sorted(files):
        rel = os.path.relpath(path, tree).replace("\\", "/")
        base = os.path.basename(path)
        keys = []
        for cand in (rel, base):
            if cand in fmap:
                mapped = fmap[cand]
                keys.append(mapped.replace("\\", "/").split("/")[-1])
        if not keys:
            keys = [base]
        key = keys[0]

        original, bom = read_text(path)
        lines = original.splitlines(True)
        out = []
        fst = defaultdict(int)
        changed = False
        for lineno, line in enumerate(lines, 1):
            if CALL_HEAD not in line:
                out.append(line)
                continue
            line_ids = table.sites.get((key, lineno), set())
            pieces = []
            cursor = 0
            pos = 0
            while True:
                start, end, argstr = parse_call(line, pos)
                if start < 0:
                    break
                stats["calls"] += 1
                fst["calls"] += 1
                if end is None:
                    stats[UNP] += 1
                    fst[UNP] += 1
                    pos = start + len(CALL_HEAD)
                    continue
                lits, field = parse_args(argstr)
                if field is None:
                    stats[UNP] += 1
                    fst[UNP] += 1
                    if len(unm_samples) < 30:
                        unm_samples.append({"file": rel, "line": lineno,
                                            "reason": "unparsable args", "text": argstr[:160]})
                    pos = end
                    continue
                status, text, sid = resolve(line_ids, lits, field, table)
                if text is None:
                    stats[status] += 1
                    fst[status] += 1
                    if status == AMB and len(amb_samples) < 30:
                        amb_samples.append({"file": rel, "line": lineno, "field": field,
                                            "candidates": len(table.field_ids.get(field, ()))})
                    if status == UNM and len(unm_samples) < 30:
                        unm_samples.append({"file": rel, "line": lineno, "field": field,
                                            "reason": "no id match",
                                            "expr": argstr[:160]})
                    pos = end
                    continue
                literal = json.dumps(text, ensure_ascii=False)
                pieces.append(line[cursor:start])
                pieces.append(literal)
                cursor = end
                pos = end
                stats[status] += 1
                fst[status] += 1
                changed = True
                if len(samples) < args.samples:
                    samples.append({"file": rel, "line": lineno, "strategy": status,
                                    "id": sid, "old": line[start:end][:200],
                                    "new": literal[:200]})
            pieces.append(line[cursor:])
            out.append("".join(pieces))
        if changed and not args.dry_run:
            write_text(path, "".join(out), bom)
        entry = {"file": rel, "calls": fst["calls"], S1_LINE: fst[S1_LINE],
                 S2_FL: fst[S2_FL], S2_FU: fst[S2_FU], AMB: fst[AMB],
                 UNM: fst[UNM], UNP: fst[UNP], "changed": changed}
        per_file.append(entry)

    replaced = stats[S1_LINE] + stats[S2_FL] + stats[S2_FU]
    report = {
        "tree": tree,
        "strings": os.path.abspath(args.tsv),
        "dry_run": bool(args.dry_run),
        "tree_files": len(files),
        "tsv_rows": table.rows,
        "tsv_ids": len(table.id_text),
        "tsv_rows_unescaped": table.unescaped_rows,
        "tsv_id_conflicts": table.id_conflict,
        "tsv_field_const_conflicts": table.field_const_conflict,
        "calls": stats["calls"],
        "replaced": replaced,
        "coverage": round(replaced / stats["calls"], 4) if stats["calls"] else 0.0,
        "by_strategy": {
            S1_LINE: stats[S1_LINE],
            S2_FL: stats[S2_FL],
            S2_FU: stats[S2_FU],
        },
        "ambiguous": stats[AMB],
        "unmatched": stats[UNM],
        "unparsed": stats[UNP],
        "files_with_calls": sum(1 for e in per_file if e["calls"]),
        "samples": samples,
        "ambiguous_samples": amb_samples,
        "unmatched_samples": unm_samples,
        "per_file": per_file,
    }
    if args.report:
        with open(args.report, "w", encoding="utf-8", newline="\n") as fh:
            json.dump(report, fh, ensure_ascii=False, indent=1)
    if args.report_tsv:
        with open(args.report_tsv, "w", encoding="utf-8", newline="\n") as fh:
            fh.write("file\tcalls\tstrategy1_line\tstrategy2_field_literal\t"
                     "strategy2_field_unique\tambiguous\tunmatched\tunparsed\n")
            for e in per_file:
                if not e["calls"]:
                    continue
                fh.write("%s\t%d\t%d\t%d\t%d\t%d\t%d\t%d\n" % (
                    e["file"], e["calls"], e[S1_LINE], e[S2_FL], e[S2_FU],
                    e[AMB], e[UNM], e[UNP]))

    summary = {k: report[k] for k in ("tree", "tree_files", "calls", "replaced", "coverage",
                                      "by_strategy", "ambiguous", "unmatched", "unparsed",
                                      "files_with_calls", "dry_run")}
    print(json.dumps(summary, ensure_ascii=False, indent=1))
    return 0


if __name__ == "__main__":
    sys.exit(main())

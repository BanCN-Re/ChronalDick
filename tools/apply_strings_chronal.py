#!/usr/bin/env python3
r"""Replace Chronal string-decryption calls with recovered plaintext literals (src-work7 port).

Call shape produced by ILSpy from the protected assembly:

    g9MiPrL41bvmHLMo2Exb.YoQLhoegTpw(<lit> ^ [<lit> ^ ...] ^ _Module__x_.m_OUTER.m_FIELD)

Resolution: field_const = id_dec ^ literal_hex (TSV row), id = xor(all literals) ^ field_const,
plaintext = TSV[id_dec]. Rows whose status is not "ok" are skipped (id left unmatched).
Terms written as `-(-N)` or plain numbers (no field term) are not string ids -> unmatched.

Usage:
  py -3 apply_strings_chronal.py <tree-dir> <strings.tsv> [--dry-run] [--report-tsv out.tsv]
"""
import argparse
import json
import os
import re
import sys

RECEIVER = "g9MiPrL41bvmHLMo2Exb.YoQLhoegTpw("
FIELD_RE = re.compile(r"_Module__[A-Za-z0-9_]+\.(?:m_[0-9a-fA-F]+\.)?(m_[0-9a-fA-F]+)\s*$")
NUM_RE = re.compile(r"^([+-]*)(0[xX][0-9A-Fa-f]+|[0-9]+)$")


def unescape_tsv(text):
    out = []
    i = 0
    n = len(text)
    while i < n:
        ch = text[i]
        if ch == "\\" and i + 1 < n:
            mapped = {"\\": "\\", "t": "\t", "n": "\n", "r": "\r"}.get(text[i + 1])
            if mapped is not None:
                out.append(mapped)
                i += 2
                continue
        out.append(ch)
        i += 1
    return "".join(out)


def parse_num(tok):
    t = tok.strip()
    # ILSpy emits plain / signed / parenthesised forms: 0x1F, -5, -(-5), (0x1F), -(-662046383)
    for _ in range(8):
        if len(t) >= 2 and t[0] == "(" and t[-1] == ")":
            depth = 0
            closed = -1
            for i, ch in enumerate(t):
                depth += 1 if ch == "(" else (-1 if ch == ")" else 0)
                if depth == 0:
                    closed = i
                    break
            if closed != len(t) - 1:
                break
            t = t[1:-1].strip()
            continue
        break
    neg = 0
    while t[:1] in ("-", "+") and t:
        if t[0] == "-":
            neg ^= 1
        t = t[1:].strip()
        while len(t) >= 2 and t[0] == "(" and t[-1] == ")":
            t = t[1:-1].strip()
    m = NUM_RE.match(t)
    if not m:
        return None
    signs, num = m.group(1), m.group(2)
    try:
        v = int(num, 16) if num[:2].lower() == "0x" else int(num, 10)
    except ValueError:
        return None
    if neg:
        v = -v
    return v & 0xFFFFFFFF


def load(path):
    ids = {}          # id -> plaintext
    field_const = {}  # field -> constant
    order = []
    with open(path, encoding="utf-8", newline="") as fh:
        header = fh.readline().rstrip("\r\n").split("\t")
        idx = {n: i for i, n in enumerate(header)}
        for raw in fh:
            c = raw.rstrip("\r\n").split("\t")
            if len(c) < len(header):
                continue
            sid = int(c[idx["id_hex"]], 16)
            status = c[idx["status"]].strip()
            field = c[idx["field"]].strip()
            lit = c[idx["literal_hex"]].strip()
            if status != "ok":
                continue
            ids[sid] = unescape_tsv(c[idx["plaintext"]])
            field_const[field] = sid ^ (int(lit, 16) & 0xFFFFFFFF)
            order.append(sid)
    return ids, field_const, order


def find_calls(text):
    """Yield (start, end, args) for every balanced YoQLhoegTpw(...) call in text."""
    pos = 0
    while True:
        s = text.find(RECEIVER, pos)
        if s < 0:
            return
        i = s + len(RECEIVER)
        depth = 1
        while i < len(text):
            ch = text[i]
            if ch == '"':
                i += 1
                while i < len(text) and text[i] != '"':
                    i += 2 if text[i] == "\\" else 1
            elif ch == "(":
                depth += 1
            elif ch == ")":
                depth -= 1
                if depth == 0:
                    break
            i += 1
        if i >= len(text):
            return
        yield s, i + 1, text[s + len(RECEIVER):i]
        pos = i + 1


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("root")
    ap.add_argument("tsv")
    ap.add_argument("--dry-run", action="store_true")
    ap.add_argument("--report-tsv", default="")
    args = ap.parse_args()

    ids, field_const, _ = load(args.tsv)
    rows = []
    stats = {"replaced": 0, "unmatched": 0, "files": 0, "nofield": 0}

    for dirpath, dirnames, filenames in os.walk(args.root):
        dirnames[:] = [d for d in dirnames if d not in {"bin", "obj", ".vs", ".git"}]
        for fn in sorted(filenames):
            if not fn.endswith(".cs"):
                continue
            path = os.path.join(dirpath, fn)
            with open(path, "rb") as fh:
                data = fh.read()
            bom = data.startswith(b"\xef\xbb\xbf")
            text = data.decode("utf-8-sig", errors="replace")
            if RECEIVER not in text:
                continue
            edits = []
            for s, e, inner in find_calls(text):
                terms = [t.strip() for t in inner.split("^")]
                fm = FIELD_RE.search(terms[-1]) if terms else None
                if fm is None:
                    stats["nofield"] += 1
                    stats["unmatched"] += 1
                    line = text.count("\n", 0, s) + 1
                    rows.append((fn, line, "no-field", inner.replace("\n", " ")[:70], ""))
                    continue
                field = fm.group(1)
                lits = []
                bad = False
                for t in terms[:-1]:
                    v = parse_num(t)
                    if v is None:
                        bad = True
                        break
                    lits.append(v)
                line = text.count("\n", 0, s) + 1
                if bad or field not in field_const:
                    stats["unmatched"] += 1
                    rows.append((fn, line, "unknown-field-or-lit", inner.replace("\n", " ")[:70], ""))
                    continue
                acc = 0
                for v in lits:
                    acc ^= v
                sid = (acc & 0xFFFFFFFF) ^ field_const[field]
                if sid not in ids:
                    stats["unmatched"] += 1
                    rows.append((fn, line, "id-0x%X-not-in-tsv" % sid, inner.replace("\n", " ")[:70], ""))
                    continue
                edits.append((s, e, json.dumps(ids[sid], ensure_ascii=False)))
                stats["replaced"] += 1
                rows.append((fn, line, "ok", "0x%X" % sid, ids[sid]))
            if not edits:
                continue
            stats["files"] += 1
            for s, e, rep in reversed(edits):
                text = text[:s] + rep + text[e:]
            if not args.dry_run:
                out = text.encode("utf-8")
                if bom:
                    out = b"\xef\xbb\xbf" + out
                with open(path, "wb") as fh:
                    fh.write(out)

    if args.report_tsv:
        with open(args.report_tsv, "w", encoding="utf-8") as fh:
            fh.write("file\tline\tstatus\tid_or_expr\tplaintext\n")
            for r in rows:
                fh.write("\t".join(str(x).replace("\t", " ") for x in r) + "\n")
    print("replaced=%d unmatched=%d files=%d nofield=%d mode=%s"
          % (stats["replaced"], stats["unmatched"], stats["files"], stats["nofield"],
             "dry-run" if args.dry_run else "write"))
    return 0


if __name__ == "__main__":
    sys.exit(main())

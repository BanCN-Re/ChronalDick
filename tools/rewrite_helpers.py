#!/usr/bin/env python3
"""Rewrite Reactor delegate-proxy call sites to the real BCL/WinRT call they wrap.

Input is the runtime mapping produced by helpertargets:
    helper, targetType, targetMethod, targetSig, field, status, isStatic, isCtor, genArgs

Each source call has the shape `Helper.RPqLKGHxrab(arg0, ..., Helper.field)`; the trailing delegate
field is dropped and the remaining arguments are re-emitted according to the target method:
  static method      -> Type.Method(args)
  instance method    -> (arg0).Method(args[1:])
  getter / setter    -> (arg0).Prop / (arg0).Prop = value
  event add/remove   -> (arg0).Event += handler / -= handler
  operator           -> (a == b) etc.
  constructor        -> new Type(args)

usage: rewrite_helpers.py <src-dir> <helper-targets.tsv> [--dry-run]
"""
import re
import sys
from pathlib import Path

PROXY_NAME = next((a.split("=",1)[1] for a in sys.argv if a.startswith("--proxy=")), "RPqLKGHxrab")
PROXY = "." + PROXY_NAME + "("

OPS = {
    "op_Equality": "==", "op_Inequality": "!=", "op_GreaterThan": ">", "op_LessThan": "<",
    "op_GreaterThanOrEqual": ">=", "op_LessThanOrEqual": "<=", "op_Addition": "+",
    "op_Subtraction": "-", "op_Multiply": "*", "op_Division": "/", "op_Modulus": "%",
    "op_BitwiseAnd": "&", "op_BitwiseOr": "|", "op_ExclusiveOr": "^", "op_LeftShift": "<<",
    "op_RightShift": ">>",
}
UNARY = {"op_UnaryNegation": "-", "op_UnaryPlus": "+", "op_LogicalNot": "!", "op_OnesComplement": "~"}


def split_top(s: str, sep: str = ",") -> list[str]:
    out, cur, depth = [], [], 0
    for ch in s:
        if ch in "<([{":
            depth += 1
        elif ch in ">)]}":
            depth -= 1
        if ch == sep and depth == 0:
            out.append("".join(cur).strip())
            cur = []
        else:
            cur.append(ch)
    if "".join(cur).strip():
        out.append("".join(cur).strip())
    return out


def cs_type(t: str) -> str:
    """CLR full name -> C# source name (generics, nested types)."""
    t = t.strip()
    if not t:
        return t
    if "|" in t:  # generic parameter marker from reflection
        return t.split("|")[0]
    bt = t.find("`")
    if bt < 0:
        return t.replace("+", ".")
    arity = 0
    i = bt + 1
    while i < len(t) and t[i].isdigit():
        arity = arity * 10 + int(t[i])
        i += 1
    base = t[:bt].replace("+", ".")
    if i < len(t) and t[i] == "<":
        inner = t[i + 1:]
        if inner.endswith(">"):
            inner = inner[:-1]
        return base + "<" + ", ".join(cs_type(x) for x in split_top(inner)) + ">"
    if i >= len(t) or t[i] != "[":
        return base
    # [[T1, asm],[T2, asm]] or [T1,asm]
    depth = 0
    parts, cur = [], []
    j = i
    while j < len(t):
        c = t[j]
        if c == "[":
            depth += 1
            if depth == 1:
                j += 1
                continue
        elif c == "]":
            depth -= 1
            if depth == 0:
                parts.append("".join(cur))
                break
        if depth == 1 and c == ",":
            parts.append("".join(cur))
            cur = []
            j += 1
            continue
        if depth >= 1:
            cur.append(c)
        j += 1
    args = []
    for p in parts:
        p = p.strip()
        # drop assembly qualification at the top level
        d, k = 0, 0
        while k < len(p):
            if p[k] == "[":
                d += 1
            elif p[k] == "]":
                d -= 1
            elif p[k] == "," and d == 0:
                break
            k += 1
        args.append(cs_type(p[:k].strip()))
    return f"{base}<{', '.join(args)}>"


def ret_type(sig: str) -> str:
    return sig.split("(", 1)[0]


class Scanner:
    """Char scanner that knows C# strings, chars and comments."""

    def __init__(self, text: str):
        self.s = text

    def skip(self, i: int) -> int:
        """If a string/char/comment starts at i, return index after it, else i."""
        s, n = self.s, len(self.s)
        if s.startswith('@"', i):
            j = i + 2
            while j < n:
                if s[j] == '"':
                    if j + 1 < n and s[j + 1] == '"':
                        j += 2
                        continue
                    return j + 1
                j += 1
            return n
        if s.startswith('$@"', i) or s.startswith('@$"', i):
            j = i + 3
            while j < n:
                if s[j] == '"':
                    if j + 1 < n and s[j + 1] == '"':
                        j += 2
                        continue
                    return j + 1
                j += 1
            return n
        if s[i] == '"' or (s[i] == '$' and i + 1 < n and s[i + 1] == '"'):
            j = i + (2 if s[i] == '$' else 1)
            while j < n:
                if s[j] == '\\':
                    j += 2
                    continue
                if s[j] == '"':
                    return j + 1
                j += 1
            return n
        if s[i] == "'":
            j = i + 1
            while j < n:
                if s[j] == '\\':
                    j += 2
                    continue
                if s[j] == "'":
                    return j + 1
                j += 1
            return n
        if s.startswith("//", i):
            j = s.find("\n", i)
            return n if j < 0 else j
        if s.startswith("/*", i):
            j = s.find("*/", i + 2)
            return n if j < 0 else j + 2
        return i


def match_paren(text: str, open_idx: int) -> int:
    sc = Scanner(text)
    depth = 0
    i = open_idx
    while i < len(text):
        j = sc.skip(i)
        if j != i:
            i = j
            continue
        c = text[i]
        if c == "(":
            depth += 1
        elif c == ")":
            depth -= 1
            if depth == 0:
                return i
        i += 1
    raise ValueError("unbalanced parentheses")


def split_args(text: str) -> list[str]:
    sc = Scanner(text)
    args, cur, depth = [], [], 0
    i = 0
    while i < len(text):
        j = sc.skip(i)
        if j != i:
            cur.append(text[i:j])
            i = j
            continue
        c = text[i]
        if c in "([{":
            depth += 1
        elif c in ")]}":
            depth -= 1
        elif c == "<" and i > 0 and (text[i-1].isalnum() or text[i-1] in "_]"):
            depth += 1
        elif c == ">" and depth > 0 and (i == 0 or text[i-1] != "=") and (i+1 >= len(text) or text[i+1] != "="):
            depth -= 1
        if c == "," and depth == 0:
            args.append("".join(cur).strip())
            cur = []
        else:
            cur.append(c)
        i += 1
    if "".join(cur).strip():
        args.append("".join(cur).strip())
    return args


def strip_ref(a: str) -> str:
    a = a.strip()
    if "ref " in a:
        a = a[a.rfind("ref ") + 4:].strip()
        while a.endswith(")") and a.count(")") > a.count("("):
            a = a[:-1].rstrip()
        while a.startswith("(") and a.count("(") > a.count(")"):
            a = a[1:].lstrip()
    return re.sub(r"^(ref|out|in)\s+", "", a.strip())


def emit(m: dict, args: list[str]) -> str:
    name = m["method"]
    ttype = cs_type(m["targetType"])
    ret = cs_type(ret_type(m["targetSig"]))
    static = m["isStatic"] == "1"
    ctor = m["isCtor"] == "1"
    gen = ""
    if m["genArgs"]:
        gen = "<" + ", ".join(cs_type(x) for x in m["genArgs"].split(",")) + ">"

    if ctor:
        return f"new {ttype}({', '.join(args)})"

    if name in OPS and len(args) == 2:
        a, b = args
        return f"({a} {OPS[name]} {b})"
    if name in UNARY and len(args) == 1:
        return f"({UNARY[name]}{args[0]})"
    if name in ("op_Implicit", "op_Explicit") and len(args) == 1:
        return f"(({ret}){args[0]})"

    if name.startswith("get_") and len(args) >= 1:
        prop = name[4:]
        if static:
            return f"{ttype}.{prop}"
        return f"({strip_ref(args[0])}).{prop}"
    if name.startswith("set_") and len(args) >= 2:
        prop = name[4:]
        if static:
            return f"{ttype}.{prop} = {args[1]}"
        return f"({strip_ref(args[0])}).{prop} = {args[1]}"
    if name.startswith("add_") and len(args) >= 2:
        return f"({strip_ref(args[0])}).{name[4:]} += {args[1]}"
    if name.startswith("remove_") and len(args) >= 2:
        return f"({strip_ref(args[0])}).{name[7:]} -= {args[1]}"

    if static:
        return f"{ttype}.{name}{gen}({', '.join(args)})"

    if not args:
        return f"{ttype}.{name}{gen}()"
    recv = strip_ref(args[0])
    return f"({recv}).{name}{gen}({', '.join(args[1:])})"


def load_map(path: str) -> dict[str, dict]:
    out = {}
    for line in Path(path).read_text(encoding="utf-8").splitlines()[1:]:
        if not line.strip():
            continue
        p = line.split("\t")
        if len(p) < 9:
            continue
        helper, tt, tm, ts, field, status, st, ctor, gen = p[:9]
        if not status.startswith("ok"):
            continue
        out[helper] = dict(targetType=tt, method=tm, targetSig=ts, field=field,
                           isStatic=st, isCtor=ctor, genArgs=gen)
    return out


def find_call(text: str, start: int, mapping: dict[str, dict]):
    sc = Scanner(text)
    i = start
    n = len(text)
    while i < n:
        j = sc.skip(i)
        if j != i:
            i = j
            continue
        if text[i].isalpha() or text[i] == "_":
            k = i + 1
            while k < n and (text[k].isalnum() or text[k] == "_"):
                k += 1
            ident = text[i:k]
            if ident in mapping and text.startswith(PROXY, k):
                return i, ident, k + len(PROXY) - 1
            i = k
            continue
        i += 1
    return None


def rewrite(text: str, mapping: dict[str, dict], stats: dict) -> str:
    out, i = [], 0
    while True:
        hit = find_call(text, i, mapping)
        if hit is None:
            out.append(text[i:])
            break
        start, helper, open_idx = hit
        try:
            close = match_paren(text, open_idx)
        except ValueError:
            stats["unbalanced"] += 1
            out.append(text[i:])
            break
        inner = rewrite(text[open_idx + 1:close], mapping, stats)
        args = split_args(inner)
        m = mapping[helper]
        if args and args[-1].startswith(helper + "."):
            args = args[:-1]
        else:
            stats["field_arg_mismatch"] += 1
        try:
            repl = emit(m, args)
        except Exception as e:
            stats["emit_fail"] += 1
            stats.setdefault("emit_errors", []).append(f"{helper} {m['method']}: {e}")
            repl = text[start:close + 1]
        out.append(text[i:start])
        out.append(repl)
        i = close + 1
        stats["rewritten"] += 1
    return "".join(out)


def main() -> int:
    src = Path(sys.argv[1])
    mapping = load_map(sys.argv[2])
    dry = "--dry-run" in sys.argv
    stats = dict(files=0, rewritten=0, unbalanced=0, field_arg_mismatch=0, emit_fail=0)
    for f in sorted(src.glob("*.cs")):
        raw = f.read_text(encoding="utf-8", errors="replace")
        if PROXY not in raw:
            continue
        out = rewrite(raw, mapping, stats)
        if out != raw:
            stats["files"] += 1
            if not dry:
                f.write_text(out, encoding="utf-8")
    print(" ".join(f"{k}={v}" for k, v in stats.items() if not isinstance(v, list)))
    for e in stats.get("emit_errors", [])[:10]:
        print("  emit-error:", e)
    return 0


if __name__ == "__main__":
    sys.exit(main())

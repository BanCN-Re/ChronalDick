import re, io, collections, sys

path = sys.argv[1] if len(sys.argv) > 1 else r"y2.log"
pat = re.compile(r"^(?P<file>[^()]+)\((?P<line>\d+),(?P<col>\d+)\): error (?P<code>CS\d+): (?P<msg>.*?)(?: \[[^\]]*\])?$")
want = sys.argv[2].split(",") if len(sys.argv) > 2 else None
seen = collections.Counter()
n = int(sys.argv[3]) if len(sys.argv) > 3 else 6
with io.open(path, encoding="utf-8", errors="replace") as f:
    for ln in f:
        m = pat.match(ln.rstrip("\n"))
        if not m:
            continue
        code = m.group("code")
        if want and code not in want:
            continue
        if seen[code] >= n:
            continue
        seen[code] += 1
        rel = m.group("file").split("Mahiro.Security\\")[-1]
        print("%s %s(%s) :: %s" % (code, rel, m.group("line"), m.group("msg")[:260]))

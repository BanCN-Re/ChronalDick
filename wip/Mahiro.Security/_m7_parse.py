import re, io, collections, sys

path = sys.argv[1] if len(sys.argv) > 1 else r"y2.log"
pat = re.compile(r"^(?P<file>[^()]+)\((?P<line>\d+),(?P<col>\d+)\): error (?P<code>CS\d+):")
by_file = collections.Counter()
by_code = collections.Counter()
with io.open(path, encoding="utf-8", errors="replace") as f:
    for ln in f:
        m = pat.match(ln)
        if not m:
            continue
        fn = m.group("file").split("\\")[-1]
        by_file[fn] += 1
        by_code[m.group("code")] += 1

print("TOTAL errors:", sum(by_file.values()), " files:", len(by_file))
print("\n-- by code --")
for c, n in by_code.most_common(25):
    print("%-8s %6d" % (c, n))
print("\n-- by file (top 40) --")
for c, n in by_file.most_common(40):
    print("%-50s %6d" % (c, n))

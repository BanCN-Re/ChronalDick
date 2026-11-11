import re, sys, collections

LOG = sys.argv[1]
OUT = sys.argv[2] if len(sys.argv) > 2 else 'g1b_rows.tsv'
pat = re.compile(r'^.*\\([^\\]+\.cs)\((\d+),(\d+)\): error (CS\d+): (.*?)(?: \[[^\]]*\])?$')
rows = []
for L in open(LOG, encoding='utf-8', errors='replace'):
    L = L.rstrip('\n')
    m = pat.match(L)
    if m:
        rows.append((m.group(1), m.group(2), m.group(3), m.group(4), m.group(5)))
print('total', len(rows))
c = collections.Counter(r[3] for r in rows)
for code, n in c.most_common():
    print(f'  {code} {n}')
files = collections.Counter(r[0] for r in rows if r[3] in ('CS0103', 'CS0117'))
print('files with 0103/0117:', len(files))
print('errs in them:', sum(files.values()))
with open(OUT, 'w', encoding='utf-8') as fh:
    for r in rows:
        fh.write('\t'.join(r) + '\n')
print('wrote', OUT)

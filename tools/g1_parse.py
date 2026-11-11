import re, sys, collections

log = sys.argv[1]
lines = open(log, encoding='utf-8', errors='replace').read().splitlines()
pat = re.compile(r'[\\/]([^\\/:]+\.cs)\((\d+),(\d+)\): error (CS\d+): (.*?) \[[^\]]*\]\s*$')
rows = []
for L in lines:
    m = pat.search(L)
    if m:
        rows.append(m.groups())
print('total parsed', len(rows))
c = collections.Counter(r[3] for r in rows)
for code, n in c.most_common():
    print(f'  {code} {n}')
tf = collections.Counter((r[0], r[3]) for r in rows)
print('--- per file (target classes) ---')
for (f, code), n in sorted(tf.items()):
    if code in ('CS0103', 'CS0117', 'CS1061'):
        print(f'{f}\t{n}\t{code}')
if len(sys.argv) > 2:
    with open(sys.argv[2], 'w', encoding='utf-8') as fh:
        for r in rows:
            fh.write('\t'.join(r) + '\n')
    print('wrote', sys.argv[2])

import sys, collections
p = sys.argv[1]
out = sys.argv[2]
rows = [l.split('\t') for l in open(p, encoding='utf-8').read().splitlines() if l.strip()]
sel = [r for r in rows if r[3] in ('CS0103', 'CS0117', 'CS1061')]
by = collections.defaultdict(list)
for r in sel:
    by[r[0]].append(r)
with open(out, 'w', encoding='utf-8') as fh:
    fh.write(f'target-class errors: {len(sel)}\n')
    for f in sorted(by):
        fh.write(f'\n### {f}  ({len(by[f])})\n')
        for r in by[f]:
            fh.write(f'  L{r[1]}:{r[2]} {r[3]} {r[4]}\n')
print('ok', len(sel))

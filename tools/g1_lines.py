import sys, collections

tsv = sys.argv[1]
base = sys.argv[2]
rows = [l.split('\t') for l in open(tsv, encoding='utf-8').read().splitlines() if l.strip()]
seen = set()
out = []
for r in rows:
    f, ln, code = r[0], int(r[1]), r[3]
    if code != 'CS0117':
        continue
    if (f, ln) in seen:
        continue
    seen.add((f, ln))
    out.append((f, ln))
cache = {}
with open(sys.argv[3], 'w', encoding='utf-8') as fh:
    for f, ln in out:
        if f not in cache:
            cache[f] = open(base + '/' + f, encoding='utf-8', errors='replace').read().splitlines()
        src = cache[f][ln - 1]
        fh.write(f'=== {f}:{ln} len={len(src)}\n{src}\n')
print('lines', len(out))

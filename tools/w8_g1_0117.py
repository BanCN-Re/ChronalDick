import re, sys, collections, os
ROOT = r'D:/Work/deobf/Chronal-crk-release/full/src-work8/Chronal'
rows = [l.rstrip('\n').split('\t') for l in open(os.path.join(ROOT, sys.argv[1]), encoding='utf-8')]
tgt = collections.defaultdict(set)
for r in rows:
    if len(r) > 4 and r[3] == 'CS0117':
        tgt[r[0]].add(int(r[1]))
standalone = re.compile(r'^(?:global::)?[\w.]+\.\w+\(.*\);\s*$')
for fn in sorted(tgt):
    lines = open(os.path.join(ROOT, fn), encoding='utf-8-sig').read().split('\n')
    for ln in sorted(tgt[fn]):
        s = lines[ln - 1].strip()
        kind = 'DEL' if standalone.match(s) else '??'
        print(f'{kind}\t{fn}:{ln}\t{s[:150]}')

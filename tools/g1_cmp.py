import sys, collections

before = [l.split('\t') for l in open(sys.argv[1], encoding='utf-8').read().splitlines() if l.strip()]
after = [l.split('\t') for l in open(sys.argv[2], encoding='utf-8').read().splitlines() if l.strip()]

tb = [r for r in before if r[3] not in ('CS0103', 'CS0117', 'CS1061')]
ta = [r for r in after]
print('baseline non-target errors:', len(tb))
print('after-fix errors:', len(ta))
sigb = collections.Counter((r[0], r[3], r[4]) for r in tb)
siga = collections.Counter((r[0], r[3], r[4]) for r in ta)
new = siga - sigb
gone = sigb - siga
print('NEW errors (regressions):', sum(new.values()))
for k, v in new.items():
    print('  +', k, v)
print('gone:', sum(gone.values()))
for k, v in list(gone.items())[:10]:
    print('  -', k, v)
print('--- remaining per file ---')
pf = collections.Counter(r[0] for r in ta)
for f, n in sorted(pf.items(), key=lambda x: -x[1]):
    print(f'{n:3d}  {f}')

import sys

base = sys.argv[1]
sites = []
for a in sys.argv[2:]:
    f, ln = a.split(':')
    sites.append((f, int(ln)))

cache = {}
for f, ln in sites:
    if f not in cache:
        cache[f] = open(base + '/' + f, encoding='utf-8', errors='replace').read().splitlines()
    L = cache[f]
    print(f'----- {f}:{ln}')
    for i in range(max(0, ln - 4), min(len(L), ln + 3)):
        mark = '>>' if i == ln - 1 else '  '
        print(f'{mark}{i+1:5d} {L[i]}')
    print()

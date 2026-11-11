import sys, collections
p = sys.argv[1]
rows = [l.split('\t') for l in open(p, encoding='utf-8').read().splitlines() if l.strip()]
filef = None
for r in rows:
    f, ln, col, code, msg = r[0], int(r[1]), int(r[2]), r[3], r[4]
    if filef and f != filef:
        print()
    filef = f
    print(f'{f}:{ln}:{col} {code} {msg}')

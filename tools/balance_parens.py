import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'


def balance(line):
    d = 0
    i = 0
    n = len(line)
    instr = False
    quote = ''
    while i < n:
        c = line[i]
        if instr:
            if c == chr(92):
                i += 2
                continue
            if c == quote:
                instr = False
        else:
            if c == '"' or c == "'":
                instr = True
                quote = c
            elif c == '(':
                d += 1
            elif c == ')':
                d -= 1
        i += 1
    return d


fixed = 0
for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    if '((dynamic)' not in s:
        continue
    lines = s.split('\n')
    changed = False
    for i, l in enumerate(lines):
        if '((dynamic)' not in l:
            continue
        d = balance(l)
        if d > 0 and l.rstrip().endswith(';'):
            lines[i] = l.rstrip()[:-1] + ')' * d + ';'
            fixed += 1
            changed = True
    if changed:
        io.open(f, 'w', encoding='utf-8').write('\n'.join(lines))
print('lines balanced:', fixed)

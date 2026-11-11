import io, os, re, sys

root = sys.argv[1]
BS = chr(92)

# 1) class-level stub block -> empty body
p = os.path.join(root, 'v5OiSQSzC8GipXkQ3VG.cs')
s = io.open(p, encoding='utf-8', errors='replace').read()
pat = re.compile(r'\n\t\{\r?\n\t// body stubbed by _fix[^\n]*\r?\n\t//[^\n]*\r?\n\tthrow new global::System\.NotSupportedException\(\);\r?\n\t\}')
s2, n = pat.subn('\n\t{ }', s)
io.open(p, 'w', encoding='utf-8').write(s2)
print('v5Oi type-level stubs emptied:', n)


def delta(line):
    d = 0
    instr = False
    q = ''
    i = 0
    while i < len(line):
        c = line[i]
        if instr:
            if c == BS:
                i += 2
                continue
            if c == q:
                instr = False
        else:
            if c in '"' + "'":
                instr = True
                q = c
            elif c == '{':
                d += 1
            elif c == '}':
                d -= 1
        i += 1
    return d


# 2) brace-balance report for LFHd
p = os.path.join(root, 'LFHd1ojfYcRKGDVUDAUb.cs')
lines = io.open(p, encoding='utf-8', errors='replace').read().split('\n')
bal = 0
open_line = None
issues = []
for i, l in enumerate(lines, 1):
    before = bal
    bal += delta(l)
    if before == 1 and bal == 0:
        open_line = None
print('final balance:', bal, 'lines:', len(lines))
# find lines where balance drops below zero (extra close) or ends positive at EOF
bal = 0
for i, l in enumerate(lines, 1):
    bal += delta(l)
    if bal < 0 and i < len(lines):
        print('negative balance at line', i, ':', l.strip()[:100])
        break

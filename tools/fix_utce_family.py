import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'

# (dynamic)((T)x).F  ==  ((dynamic)((T)x).F)  -> wrap the cast expression properly
pats = [
    # if ((dynamic)((T)x).F).Mem)
    (re.compile(r'if \(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+)\)'),
     r'if (((dynamic)((\1)\2).\3).\4)'),
    # if (((dynamic)((T)x).F).Mem).Mem2)
    (re.compile(r'if \(\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+)\)\.(\w+)\)'),
     r'if ((((dynamic)((\1)\2).\3).\4).\5)'),
    # if (!((dynamic)((T)x).F).Mem).Mem2)
    (re.compile(r'if \(!\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+)\)\.(\w+)\)'),
     r'if (!((((dynamic)((\1)\2).\3).\4).\5))'),
    # P_3 = ...cwTLlmBwajP((dynamic)((T)x).F).Mem);
    (re.compile(r'cwTLlmBwajP\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+)\);'),
     r'cwTLlmBwajP((((dynamic)((\1)\2).\3).\4));'),
]

# if (!((dynamic)((T)x).F).IsStatic && ((dynamic)((T)y).G).H).I)
combo = re.compile(
    r'if \(!\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+) && \(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.(\w+)\)\.(\w+)\)')

n = 0
for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    o = s
    for pat, rep in pats:
        s = pat.sub(rep, s)
    s = combo.sub(lambda m: 'if (!(((dynamic)((%s)%s).%s).%s && (((dynamic)((%s)%s).%s).%s).%s))' % (
        m.group(1), m.group(2), m.group(3), m.group(4),
        m.group(5), m.group(6), m.group(7), m.group(8), m.group(9)), s)
    if s != o:
        io.open(f, 'w', encoding='utf-8').write(s)
        n += 1
print('files rewritten:', n)

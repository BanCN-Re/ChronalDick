import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
n = 0
# ((T)obj).((dynamic)F).  ->  ((dynamic)((T)obj).F).
# When the match is preceded by an extra '(' (Reactor nests the cast), keep one more '(' so the
# closing paren that used to pair with it stays balanced.
pat = re.compile(r'(\(?)\(\((\w+)\)(\w+)\)\.\(\(dynamic\)(\w+)\)\.')


def repl(m):
    extra = '(' if m.group(1) == '(' else ''
    return extra + '((dynamic)((%s)%s).%s).' % (m.group(2), m.group(3), m.group(4))


for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    o = s
    s = pat.sub(repl, s)
    # collapse triple-open artefact produced by earlier passes
    s = re.sub(r'\(\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)',
               lambda m: '((dynamic)((%s)%s).%s)' % (m.group(1), m.group(2), m.group(3)), s)
    s = re.sub(r'return \(\(dynamic\)(\w+)\)\.__t__builder\)\.Task;', r'return (\1.__t__builder).Task;', s)
    s = re.sub(r'\(ref (\w+) \? ', r'(\1 ? ', s)
    s = re.sub(r'\(\(object\)\(\(dynamic\)(\w+)\)\.', r'((dynamic)\1).', s)
    if s != o:
        io.open(f, 'w', encoding='utf-8').write(s)
        n += 1
print('files rewritten:', n)

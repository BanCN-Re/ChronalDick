import re, io, sys

p = sys.argv[1] if len(sys.argv) > 1 else 'UTceUuLofwXEp4GdC3ht.cs'
s = io.open(p, encoding='utf-8', errors='replace').read()
s = s.replace(' /*Error: fixme*/', '')

# 1) MethodInfo condition: rewrite the broken cast chain
s = re.sub(r'\(\(\(object\)\(MethodInfo\)\(\((\w+)\)(\w+)\)\.\(\(dynamic\)(\w+)\)\.ReturnType',
           r'(((MethodInfo)((\1)\2).\3).ReturnType', s)

# 2) generic: ((T)obj).((dynamic)F).X -> ((dynamic)((T)obj).F).X
s = re.sub(r'\(\((\w+)\)(\w+)\)\.\(\(dynamic\)(\w+)\)\.',
           lambda m: '((dynamic)((%s)%s).%s).' % (m.group(1), m.group(2), m.group(3)), s)

# 3) collapse the triple-open artefact (((dynamic)((T)obj).F). -> ((dynamic)((T)obj).F).
s = re.sub(r'\(\(\(dynamic\)\(\((\w+)\)(\w+)\)\.(\w+)\)\.',
           lambda m: '((dynamic)((%s)%s).%s).' % (m.group(1), m.group(2), m.group(3)), s)

io.open(p, 'w', encoding='utf-8').write(s)
print('rewritten')

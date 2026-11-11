import glob, io, os, re, sys
from collections import defaultdict

root = sys.argv[1] if len(sys.argv) > 1 else '.'
log = sys.argv[2]
errs = io.open(log, encoding='utf-8', errors='replace').read().split('\n')

cs0246 = set()
cs0101 = []
cs0053 = []
cs1106 = []
cs0563 = []
for l in errs:
    m = re.search(r'([\w.]+\.cs)\((\d+),\d+\): error CS0246: .*?[\u201c"]([^\u201d"]+)[\u201d"]', l)
    if m:
        cs0246.add(m.group(3)); continue
    m = re.search(r'([\w.]+\.cs)\((\d+),\d+\): error CS0101: .*?[\u201c"]([^\u201d"]+)[\u201d"]', l)
    if m: cs0101.append(m.group(3)); continue
    m = re.search(r'([\w.]+\.cs)\((\d+),\d+\): error CS0053: .*?[\u201c"]([^\u201d"]+)[\u201d"]', l)
    if m: cs0053.append((m.group(1), int(m.group(2)), m.group(3))); continue
    m = re.search(r'([\w.]+\.cs)\((\d+),\d+\): error CS1106', l)
    if m: cs1106.append((m.group(1), int(m.group(2)))); continue
    m = re.search(r'([\w.]+\.cs)\((\d+),\d+\): error CS0563', l)
    if m: cs0563.append((m.group(1), int(m.group(2))))

# 1) operators must return bool
for f, ln in cs0563:
    p = os.path.join(root, f)
    lines = io.open(p, encoding='utf-8', errors='replace').read().split('\n')
    if ln - 1 < len(lines):
        lines[ln - 1] = re.sub(r'(static\s+)[\w<>\[\],\.]+\s+(operator\s*(?:==|!=))', r'\1bool \2', lines[ln - 1])
    io.open(p, 'w', encoding='utf-8').write('\n'.join(lines))

# 2) drop duplicate stubs from __failed_type_stubs.cs
stub = os.path.join(root, '__failed_type_stubs.cs')
if os.path.exists(stub):
    s = io.open(stub, encoding='utf-8', errors='replace').read()
    for name in set(cs0101):
        s = re.sub(r'\n\s*(?:internal|public|private|protected)?\s*(?:sealed\s+|static\s+)?(?:class|struct|interface|record)\s+' + re.escape(name) + r'\b[^{]*\{[^{}]*\}', '\n', s)
    io.open(stub, 'w', encoding='utf-8').write(s)

# 3) stub missing types in a dedicated file
if cs0246:
    out = ['namespace __v5_missing_types;']
    for n in sorted(cs0246):
        out.append('internal class ' + n + ' { }')
    io.open(os.path.join(root, '__v5_missing_types.cs'), 'w', encoding='utf-8').write('\n'.join(out) + '\n')

# 4) extension-method classes must be static: add 'static' to the enclosing class
for f, ln in cs1106:
    p = os.path.join(root, f)
    lines = io.open(p, encoding='utf-8', errors='replace').read().split('\n')
    for j in range(min(ln - 1, len(lines) - 1), -1, -1):
        m = re.search(r'^(\s*)((?:public|internal|private|protected)?\s*(?:sealed\s+|partial\s+|abstract\s+)*)class\s+(\w+)', lines[j])
        if m:
            if 'static' not in lines[j]:
                lines[j] = lines[j].replace('class ' + m.group(3), 'static class ' + m.group(3))
            break
    io.open(p, 'w', encoding='utf-8').write('\n'.join(lines))

# 5) CS0053: make the property type public (nested type declaration)
for f, ln, tname in cs0053:
    p = os.path.join(root, f)
    s = io.open(p, encoding='utf-8', errors='replace').read()
    s = re.sub(r'(?m)^(\s*)(?:private|internal)\s+(sealed\s+|abstract\s+|static\s+)*(class|struct|enum|interface)\s+' + re.escape(tname.split('.')[-1]) + r'\b', r'\1public \2\3 ' + tname.split('.')[-1], s)
    io.open(p, 'w', encoding='utf-8').write(s)

print('cs0563=%d cs0101=%d cs0246=%d cs1106=%d cs0053=%d' % (len(cs0563), len(set(cs0101)), len(cs0246), len(cs1106), len(cs0053)))

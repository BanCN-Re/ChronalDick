import io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
log = sys.argv[2]
text = io.open(log, encoding='utf-8', errors='replace').read()
sites = [(m.group(1), int(m.group(2))) for m in re.finditer(r'([\w.]+\.cs)\((\d+),\d+\): error CS0563', text)]
n = 0
for f, ln in sites:
    p = os.path.join(root, f)
    lines = io.open(p, encoding='utf-8', errors='replace').read().split('\n')
    # enclosing type name
    cls = None
    for j in range(min(ln - 1, len(lines) - 1), -1, -1):
        m = re.search(r'\b(?:class|struct|record)\s+(\w+)', lines[j])
        if m:
            cls = m.group(1)
            break
    if not cls or ln - 1 >= len(lines):
        continue
    line = lines[ln - 1]
    line2 = re.sub(r'\(\s*object\??\s+\w+\s*,\s*object\??\s+\w+\s*\)', '(%s left, %s right)' % (cls, cls), line)
    if line2 != line:
        lines[ln - 1] = line2
        io.open(p, 'w', encoding='utf-8').write('\n'.join(lines))
        n += 1
print('operators retyped:', n)

import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
fixed = 0
for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    if 'body stubbed by _fix/fix_e1_stub_methods' not in s:
        continue
    lines = s.split('\n')
    out = []
    i = 0
    changed = False
    while i < len(lines):
        l = lines[i]
        out.append(l)
        # a class/struct header whose body is only the stub marker + throw
        if re.search(r'\b(class|struct|interface|record)\s+\w+', l) and l.rstrip().endswith('{'):
            j = i + 1
            body = []
            while j < len(lines) and lines[j].strip() != '}':
                if lines[j].strip():
                    body.append(lines[j].strip())
                j += 1
            if body and all(('stubbed by _fix' in b or b.startswith('//') or b.startswith('throw new global::System.NotSupportedException')) for b in body):
                out.append('}')  # close immediately, drop the stub
                i = j + 1
                changed = True
                continue
        i += 1
    if changed:
        io.open(f, 'w', encoding='utf-8').write('\n'.join(out))
        fixed += 1
print('emptied class-level stubs:', fixed)

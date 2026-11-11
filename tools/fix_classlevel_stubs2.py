import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
fixed = 0
block = ('body stubbed by _fix', '// the semantics', 'throw new global::System.NotSupportedException();')
for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    if block[0].split('body stubbed by _fix')[0] + 'body stubbed by _fix' not in s:
        continue
    lines = s.split('\n')
    out = []
    i = 0
    changed = False
    while i < len(lines):
        l = lines[i]
        m = re.match(r'^(\s*)((?:public|internal|private|protected)\s+)?(?:sealed\s+|abstract\s+|static\s+|ref\s+|partial\s+|readonly\s+)*(class|struct|interface|record)\s+\w+', l)
        if m and '(' not in l:
            # find the opening brace on this or a following line
            j = i + 1
            while j < len(lines) and not lines[j].strip():
                j += 1
            if j < len(lines) and lines[j].strip() == '{':
                # body lines until matching close
                k = j + 1
                body = []
                while k < len(lines) and lines[k].strip() != '}':
                    if lines[k].strip():
                        body.append(lines[k].strip())
                    k += 1
                if body and all(('stubbed by _fix' in b or b.startswith('//') or
                                 b.startswith('throw new global::System.NotSupportedException')) for b in body):
                    out.append(l)
                    out.append(m.group(1) + '{ }')
                    i = k + 1
                    changed = True
                    continue
        out.append(l)
        i += 1
    if changed:
        io.open(f, 'w', encoding='utf-8').write('\n'.join(out))
        fixed += 1
print('emptied type-level stubs:', fixed)

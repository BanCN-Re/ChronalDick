import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
pat = re.compile(
    r'\{\s*\n\s*// body stubbed by _fix/fix_e1_stub_methods\.py[^\n]*\n\s*//[^\n]*\n\s*'
    r'throw new global::System\.NotSupportedException\(\);\s*\n\s*\}')
n = 0
for f in glob.glob(os.path.join(root, '*.cs')):
    s = io.open(f, encoding='utf-8', errors='replace').read()
    if 'body stubbed by _fix/fix_e1_stub_methods' not in s:
        continue
    s2, k = pat.subn('{ get; set; }', s)
    if k:
        io.open(f, 'w', encoding='utf-8').write(s2)
        n += k
print('properties converted to auto-properties:', n)

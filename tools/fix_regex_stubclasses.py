import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
files = glob.glob(os.path.join(root, '*.cs'))
texts = {f: io.open(f, encoding='utf-8', errors='replace').read() for f in files}

fixed = 0
for f, s in texts.items():
    m = re.search(r'internal sealed class (\w+) : Regex', s)
    if not m:
        continue
    name = m.group(1)
    if 'body stubbed by _fix/fix_e1_stub_methods' not in s:
        continue
    fields = set()
    for g, t in texts.items():
        if g == f:
            continue
        for mm in re.finditer(r'\b' + re.escape(name) + r'\.(\w+)', t):
            fields.add(mm.group(1))
    ns = re.search(r'namespace\s+([\w.]+)\s*;', s)
    nsline = 'namespace ' + ns.group(1) + ';\n' if ns else ''
    body = ['using System.Text.RegularExpressions;', '', nsline,
            'internal sealed class ' + name + ' : Regex', '{']
    for fld in sorted(fields):
        body.append('\tinternal static readonly Regex ' + fld + ' = new Regex("");')
    body.append('\tprivate ' + name + '() : base("") { }')
    body.append('}')
    io.open(f, 'w', encoding='utf-8').write('\n'.join(body))
    fixed += 1
print('rebuilt regex stub classes:', fixed)

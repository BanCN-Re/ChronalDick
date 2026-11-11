import re, sys, os, collections

ROOT = r'D:/Work/deobf/Chronal-crk-release/full/src-work8/Chronal'
W5 = r'D:/Work/deobf/Chronal-crk-release/full/src-work5/Chronal'
ROWS = os.path.join(ROOT, 'g1b_rows.tsv')
APPLY = '--apply' in sys.argv

need = collections.defaultdict(set)
for L in open(ROWS, encoding='utf-8'):
    f = L.rstrip('\n').split('\t')
    if len(f) < 5 or f[3] != 'CS0103':
        continue
    m = re.search(r'(_(\w+?)_k__BackingField)', f[4])
    if m:
        need[f[0]].add(m.group(1))

MODS = {'public', 'internal', 'protected', 'private', 'static', 'readonly', 'sealed',
        'override', 'virtual', 'new', 'partial', 'unsafe', 'required', 'volatile'}
prop_re = re.compile(r'^(\s*)(\S[^()=;]*?)\s+([A-Za-z_]\w*)\s*$')
report = []
ins_total = 0
for fn in sorted(need):
    path = os.path.join(ROOT, fn)
    raw = open(path, 'rb').read()
    crlf = b'\r\n' in raw
    lines = raw.decode('utf-8-sig').split('\r\n' if crlf else '\n')
    text0 = '\n'.join(lines)
    have_field = set(re.findall(r'\b(?:private|public|internal|protected)\s+[^;=\n]*?\b(_\w+_k__BackingField)\s*;', text0))
    todo = [n for n in need[fn] if n not in have_field]
    inserts = []
    for fld in todo:
        prop = fld[1:-len('_k__BackingField')]
        cand = None
        for i, ln in enumerate(lines):
            m = prop_re.match(ln)
            if not m or m.group(3) != prop:
                continue
            parts = m.group(2).split()
            mods = []
            while parts and parts[0] in MODS:
                mods.append(parts.pop(0))
            typ = ' '.join(parts)
            if not typ or typ[0] in '.+-*/':
                continue
            cand = (i, m.group(1), typ, 'static' in mods)
            break
        if cand is None:
            report.append(('MISS', fn, fld, '', ''))
            continue
        i, ind, typ, is_static = cand
        # prefer inserting right after the [field: CompilerGenerated] attribute line above the property
        pos = i
        if i >= 1 and '[field: CompilerGenerated]' in lines[i - 1]:
            pos = i
        newline = f'{ind}private {"static " if is_static else ""}{typ} {fld};'
        # cross-check with work5
        w5p = os.path.join(W5, fn)
        w5type = ''
        if os.path.exists(w5p):
            t = open(w5p, encoding='utf-8-sig', errors='replace').read()
            m2 = re.search(r'private\s+(.+?)\s+' + re.escape(fld) + r'\s*;', t)
            if m2:
                w5type = m2.group(1)
        flag = '' if (not w5type or w5type == typ) else 'TYPE-MISMATCH'
        inserts.append((pos, newline))
        report.append(('OK' if not flag else flag, fn, fld, typ, w5type))
    if not inserts:
        continue
    for pos, txt in sorted(inserts, reverse=True):
        lines.insert(pos, txt)
    if APPLY:
        out = ('\r\n' if crlf else '\n').join(lines)
        open(path, 'wb').write(out.encode('utf-8-sig') if raw.startswith(b'\xef\xbb\xbf') else out.encode('utf-8'))
    ins_total += len(inserts)

c = collections.Counter(r[0] for r in report)
print('insertions', ins_total, dict(c))
for r in report:
    if r[0] != 'OK':
        print('\t'.join(r))
print('--- per file applied')
for fn, n in sorted(collections.Counter(r[1] for r in report if r[0] == 'OK').items()):
    print(f'{fn}\t{n}')

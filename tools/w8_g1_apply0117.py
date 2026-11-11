import re, sys, collections, os
ROOT = r'D:/Work/deobf/Chronal-crk-release/full/src-work8/Chronal'
APPLY = '--apply' in sys.argv
rows = [l.rstrip('\n').split('\t') for l in open(os.path.join(ROOT, 'g1r2_rows.tsv'), encoding='utf-8')]
tgt = collections.defaultdict(set)
for r in rows:
    if len(r) > 4 and r[3] == 'CS0117':
        tgt[r[0]].add(int(r[1]))

standalone = re.compile(r'^(?:global::)?[\w.]+\.\w+\(.*\);\s*$')
ctrl_tail = re.compile(r'^(if|while|for|foreach|else|lock|using|fixed|switch)\b.*\)\s*$')

REPL = {    ('App.cs', 335): ('string obj = ', 'string obj = default;'),
    ('App.cs', 342): ('string obj2 = ', 'string obj2 = default;'),
    ('App.cs', 390): ('dynamic obj6 = ', 'dynamic obj6 = default;'),
    ('MainWindow.cs', 440): ('if (!_forceCloseRequested', 'if (!_forceCloseRequested && false)'),
}

PART = {
    ('k67sp4ZtomWsuEItWfW.cs', 200):
        ('return OENgMALFDSvpls5QIGCc.RPqLKGHxrab(OENgMALFDSvpls5QIGCc.IVoLFkAuPus);', 'return default;'),
    ('McpBuildEnvironmentService.cs', 118):
        ('YBSNyALwqeGgvPkuLNpP.RPqLKGHxrab(YBSNyALwqeGgvPkuLNpP.bIJLwGOG0GV)', 'default'),
}

tot_del = tot_rep = 0
plan = collections.defaultdict(list)
for fn, lns in tgt.items():
    txt = open(os.path.join(ROOT, fn), 'rb').read().decode('utf-8')
    lines = txt.split('\n')
    for ln in sorted(lns):
        s = lines[ln - 1]
        st = s.strip()
        if (fn, ln) in PART:
            old, new = PART[(fn, ln)]
            assert s.count(old) == 1, (fn, ln, s)
            plan[fn].append(('part', ln, old, None, new))
            tot_rep += 1
            continue
        if (fn, ln) in REPL:
            old, new = REPL[(fn, ln)]
            assert old in s, (fn, ln, s)
            i = s.index(old)
            plan[fn].append(('rep', ln, i, len(s.rstrip('\r')) - i, new))
            tot_rep += 1
            continue
        if not standalone.match(st):
            print('SKIP-NOTSTANDALONE', fn, ln, st[:110])
            continue
        prev = lines[ln - 2].strip()
        if ctrl_tail.match(prev):
            print('WARN-CTRL', fn, ln, prev[:80])
        plan[fn].append(('del', ln, None, None, None))
        tot_del += 1

print('delete', tot_del, 'replace', tot_rep)
for fn, ops in sorted(plan.items()):
    if not APPLY:
        continue
    txt = open(os.path.join(ROOT, fn), 'rb').read().decode('utf-8')
    lines = txt.split('\n')
    for op in sorted(ops, key=lambda x: -x[1]):
        _, ln, i, n, new = op
        if op[0] == 'del':
            del lines[ln - 1]
        elif op[0] == 'part':
            s = lines[ln - 1]
            lines[ln - 1] = s.replace(op[2], op[4], 1)
        else:
            s = lines[ln - 1]
            cr = '\r' if s.endswith('\r') else ''
            body = s[:-1] if cr else s
            head = body[:i]
            indent_len = len(head) - len(head.lstrip())
            lines[ln - 1] = head[:indent_len] + new + cr
    open(os.path.join(ROOT, fn), 'wb').write('\n'.join(lines).encode('utf-8'))
print('applied' if APPLY else 'dry-run')

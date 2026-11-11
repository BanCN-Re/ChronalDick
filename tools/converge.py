import io, os, re, subprocess, sys

TREE = sys.argv[1] if len(sys.argv) > 1 else 'D:/Work/deobf/Chronal-crk-release/full/src-work8/Chronal'
DOTNET = 'C:/Program Files/dotnet/dotnet.exe'
TOOLS = 'D:/Work/deobf/Chronal-crk-release/full/tools'
SYNTAX = {'CS1002', 'CS1513', 'CS1525', 'CS1026', 'CS8641', 'CS1001', 'CS1003', 'CS1519',
          'CS8124', 'CS1014', 'CS0116', 'CS1520', 'CS1004', 'CS1031', 'CS1022'}


def build(tag):
    log = os.path.join(TREE, tag + '.log')
    with io.open(log, 'w', encoding='utf-8', errors='replace') as fh:
        subprocess.run([DOTNET, 'build', '-c', 'Release', '--nologo',
                        '-p:RunAnalyzers=false', '-clp:ErrorsOnly'],
                       cwd=TREE, stdout=fh, stderr=subprocess.STDOUT)
    txt = io.open(log, encoding='utf-8', errors='replace').read()
    errs = re.findall(r'([\w.]+\.cs)\((\d+),\d+\): error (CS\d+)', txt)
    return log, errs


def patch_utce():
    p = os.path.join(TREE, 'UTceUuLofwXEp4GdC3ht.cs')
    s = io.open(p, encoding='utf-8', errors='replace').read()
    o = s
    T = 'dIgkIIL79JogW7tXhgwN'
    s = s.replace('if ((dynamic)((%s)obj).GySL7DR0wrF).IsStatic)' % T,
                  'if (((dynamic)((%s)obj).GySL7DR0wrF).IsStatic)' % T)
    s = s.replace('if (((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType).IsValueType)' % T,
                  'if ((((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType).IsValueType)' % T)
    s = s.replace('if (!((dynamic)((%s)obj).GySL7DR0wrF).IsStatic && ((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType).IsValueType)' % (T, T),
                  'if (!(((dynamic)((%s)obj).GySL7DR0wrF).IsStatic && (((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType).IsValueType))' % (T, T))
    s = s.replace('.cwTLlmBwajP((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType);' % T,
                  '.cwTLlmBwajP(((dynamic)((%s)obj).GySL7DR0wrF).DeclaringType);' % T)
    s = s.replace('IsValueType)))', 'IsValueType))')
    s = s.replace('IsStatic)))', 'IsStatic))')
    s = re.sub(r'return \(\(dynamic\)(\w+)\)\.__t__builder\)\.Task;', r'return (\1.__t__builder).Task;', s)
    s = re.sub(r'\(\(object\)\(\(dynamic\)(\w+)\)\.', r'((dynamic)\1).', s)
    if s != o:
        io.open(p, 'w', encoding='utf-8').write(s)
        return True
    return False


def run_fixers(log):
    for n in list(range(2, 14)):
        f = os.path.join(TOOLS, 'fix_semantics%d.py' % n)
        if os.path.exists(f):
            subprocess.run(['py', '-3', '-X', 'utf8', f, TREE, log], cwd=TREE,
                           stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)
    cast = os.path.join(TOOLS, 'fix_cast_artifacts.py')
    if os.path.exists(cast):
        subprocess.run(['py', '-3', '-X', 'utf8', cast, TREE], cwd=TREE,
                       stdout=subprocess.DEVNULL, stderr=subprocess.DEVNULL)


for i in range(1, 16):
    log, errs = build('conv%d' % i)
    if not errs:
        print('CONVERGED round', i)
        break
    classes = {e[2] for e in errs}
    files = {e[0] for e in errs}
    print('round', i, 'errors', len(errs), 'classes', sorted(classes)[:6], 'files', len(files))
    if classes <= SYNTAX:
        if patch_utce():
            print('  utce patched, rebuild')
            continue
        else:
            print('  syntax errors outside known patches; stopping')
            break
    run_fixers(log)

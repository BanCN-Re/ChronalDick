"""Cross-check inserted backing-field types against the compiling src-work5 tree."""
import os
import re

ROOT = os.path.dirname(os.path.dirname(os.path.abspath(__file__)))
W7 = os.path.join(ROOT, 'src-work7', 'Chronal')
W5 = os.path.join(ROOT, 'src-work5', 'Chronal')

FILES = ['AnnouncementMarkdownRenderer.cs', 'App.cs', 'AppShell.cs', 'BedrockAccessGuard.cs',
         'BedrockAccountPage.cs', 'BpOjxVLPwPUO93lZkbW.cs', 'JavaAccountPage.cs',
         'JavaCompatibilityNavigationRequest.cs', 'JavaConnectionModePresentation.cs',
         'JavaLaunchModeOption.cs', 'MainWindow.cs', 'McpBuildEnvironmentService.cs', 'Motion.cs',
         'NavigationEntry.cs', 'PaymentOrderNavigationRequest.cs', 'k67sp4ZtomWsuEItWfW.cs']

DECL = re.compile(r'^\s*private\s+(.+?)\s+(_\w+_k__BackingField)\s*;\s*$')

bad = 0
total = 0
for f in FILES:
    def decls(p):
        d = {}
        with open(p, encoding='utf-8', errors='replace') as fh:
            for L in fh:
                m = DECL.match(L.rstrip('\r\n'))
                if m:
                    d[m.group(2)] = m.group(1).strip()
        return d
    d7 = decls(os.path.join(W7, f))
    path5 = os.path.join(W5, f)
    if not os.path.exists(path5):
        continue
    d5 = decls(path5)
    for name, t7 in d7.items():
        total += 1
        t5 = d5.get(name)
        if t5 is None:
            print(f'{f}: {name} type={t7}  [not in work5]')
        elif t5 != t7:
            bad += 1
            print(f'MISMATCH {f}: {name}  work7={t7}  work5={t5}')
print(f'checked {total} field decls in work7; mismatches={bad}')

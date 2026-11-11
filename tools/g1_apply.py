"""Re-apply V7-GROUP1 fixes (backing fields + telemetry deletions + expression fixes).

Operates on full/src-work7/Chronal only. Idempotent per-file: refuses if the
expected original text is not present.
"""
import os
import re
import sys

BASE = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), 'src-work7', 'Chronal')

# file -> list of property names that need an explicit `_<Name>_k__BackingField` field
BACKING = {
    'AnnouncementMarkdownRenderer.cs': ['TextBrush', 'MutedBrush', 'CodeBackgroundBrush',
                                        'CodeBorderBrush', 'CodeTextBrush', 'AccentBrush'],
    'BedrockAccessGuard.cs': ['Access', 'UserId'],
    'BedrockAccountPage.cs': ['Access', 'CachedAt', 'Generation', 'UserId'],
    'JavaAccountPage.cs': ['HostStatus', 'BridgeStatus'],
    'JavaCompatibilityNavigationRequest.cs': ['Destination'],
    'JavaConnectionModePresentation.cs': ['EntryTitle', 'ActionTitle', 'ActionAutomationName',
                                          'StartingMessage', 'ShowsUserPort'],
    'JavaLaunchModeOption.cs': ['Mode', 'Title', 'Description'],
    'Motion.cs': ['Prefix', 'Format', 'Clock'],
    'NavigationEntry.cs': ['Key', 'Title', 'Glyph'],
    'PaymentOrderNavigationRequest.cs': ['OrderNo', 'OpenPaymentPage', 'ServicePurchaseOrderNo'],
}

# file -> {line_no: (must_contain, replacement_code)}
REPLACE = {
    'App.cs': {
        326: ('ht67KuL5y2wMk87Qy0yy.RPqLKGHxrab', 'string obj = default;'),
        333: ('Kd4ZX3L5J4ICkvNmc7lt.RPqLKGHxrab', 'string obj2 = default;'),
        381: ('E13uSRL5K8bE1H8SqDKg.RPqLKGHxrab', 'dynamic obj6 = default;'),
    },
    'MainWindow.cs': {
        434: ('v8CwiRLw0QjVaw7aHvc0.RPqLKGHxrab', 'if (!_forceCloseRequested && false)'),
    },
    'McpBuildEnvironmentService.cs': {
        127: ('YBSNyALwqeGgvPkuLNpP.RPqLKGHxrab',
              'return System.IO.Path.Combine(default, "Mcp", "BuildEnvironment");'),
    },
    'k67sp4ZtomWsuEItWfW.cs': {
        209: ('OENgMALFDSvpls5QIGCc.RPqLKGHxrab', 'return default;'),
    },
}

# file -> list of 1-based line numbers holding a standalone Reactor telemetry statement
DELETE = {
    'App.cs': [82, 88, 241, 242, 255, 256, 270, 271, 300],
    'AppShell.cs': [81, 90, 633, 640, 647, 654, 662, 744, 745, 746, 747],
    'BpOjxVLPwPUO93lZkbW.cs': [520],
    'MainWindow.cs': [201, 375, 398, 403, 493, 528],
}

PROP_RE = re.compile(r'^(\s*)(?:public|internal|private|protected)\s+(.+?)\s+([A-Za-z_]\w*)\s*$')


def process(fname):
    path = os.path.join(BASE, fname)
    with open(path, encoding='utf-8') as fh:
        raw = fh.read()
    nl = '\r\n' if '\r\n' in raw else '\n'
    lines = raw.split(nl)
    orig = list(lines)

    changes = []

    # --- 1. expression-position replacements
    for ln, (needle, newcode) in REPLACE.get(fname, {}).items():
        cur = lines[ln - 1]
        assert needle in cur, f'{fname}:{ln} expected {needle!r} in {cur!r}'
        indent = cur[:len(cur) - len(cur.lstrip('\t '))]
        lines[ln - 1] = indent + newcode
        changes.append(f'R{ln}')

    # --- 2. delete telemetry statements
    dels = set(DELETE.get(fname, []))

    # --- 3. insert backing fields after the [field: CompilerGenerated] attribute line
    wants = set(BACKING.get(fname, []))
    inserts = {}  # index -> list of new lines
    if wants:
        existing = set()
        for L in lines:
            m = re.search(r'\b(_\w+_k__BackingField)\b', L)
            if m:
                existing.add(m.group(1))
        i = 0
        while i < len(lines):
            if lines[i].strip() == '[field: CompilerGenerated]':
                j = i + 1
                while j < len(lines) and not lines[j].strip():
                    j += 1
                if j < len(lines):
                    m = PROP_RE.match(lines[j])
                    if m:
                        indent, ptype, pname = m.groups()
                        fld = f'_{pname}_k__BackingField'
                        if pname in wants and fld not in existing:
                            inserts[i] = [f'{indent}private {ptype} {fld};']
                            existing.add(fld)
                            changes.append(f'F{pname}')
            i += 1

    out = []
    for idx, L in enumerate(lines):
        if (idx + 1) not in dels:
            out.append(L)
        if idx in inserts:
            out.extend(inserts[idx])

    del_count = sum(1 for n in dels if n <= len(lines))
    if out != orig:
        with open(path, 'w', encoding='utf-8', newline=nl) as fh:
            fh.write(nl.join(out))
    print(f'{fname}: fields={len([c for c in changes if c.startswith("F")])} '
          f'del={del_count} repl={len([c for c in changes if c.startswith("R")])} '
          f'lines {len(orig)}->{len(out)}  [{", ".join(sorted(changes))}]')


if __name__ == '__main__':
    files = sorted(set(list(BACKING) + list(REPLACE) + list(DELETE)))
    for f in files:
        process(f)

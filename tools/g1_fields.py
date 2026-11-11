"""Insert the missing record backing fields for V7-GROUP1 (declaration-aware).

Skips a field when an actual *declaration* (`private T _X_k__BackingField;`) already
exists; usage sites such as `_X_k__BackingField = ...` do not count.
"""
import os
import re

BASE = os.path.join(os.path.dirname(os.path.dirname(os.path.abspath(__file__))), 'src-work7', 'Chronal')

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

MODIFIERS = r'(?:public|internal|private|protected|protected internal|private protected)'


def process(fname, props):
    path = os.path.join(BASE, fname)
    with open(path, encoding='utf-8') as fh:
        raw = fh.read()
    nl = '\r\n' if '\r\n' in raw else '\n'
    lines = raw.split(nl)
    orig = list(lines)
    added = []

    for prop in props:
        decl_re = re.compile(r'^\s*' + MODIFIERS + r'\s+(.+?)\s+(' + re.escape(prop) + r')\s*$')
        fld = f'_{prop}_k__BackingField'
        fld_decl_re = re.compile(r'^\s*' + MODIFIERS + r'\s+(.+?)\s+' + re.escape(fld) + r'\s*;\s*$')
        if any(fld_decl_re.match(L) for L in lines):
            continue
        for i, L in enumerate(lines):
            m = decl_re.match(L)
            if not m:
                continue
            ptype = m.group(1).strip()
            indent = L[:len(L) - len(L.lstrip('\t '))]
            newline = f'{indent}private {ptype} {fld};'
            if i > 0 and lines[i - 1].strip() == '[field: CompilerGenerated]':
                lines.insert(i, newline)
                after = i - 1
            else:
                lines.insert(i, newline)
                after = None
            added.append(f'{prop}<{ptype}>')
            break

    if lines != orig:
        with open(path, 'w', encoding='utf-8', newline=nl) as fh:
            fh.write(nl.join(lines))
    print(f'{fname}: +{len(added)} {added}  lines {len(orig)}->{len(lines)}')


if __name__ == '__main__':
    for f in sorted(BACKING):
        process(f, BACKING[f])

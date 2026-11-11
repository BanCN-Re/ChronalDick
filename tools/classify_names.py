import os, re, io, glob, collections, csv, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
files = glob.glob(os.path.join(root, '*.cs'))
texts = {f: io.open(f, encoding='utf-8', errors='replace').read() for f in files}

literals = []
for s in texts.values():
    literals.extend(re.findall(r'"([^"\n]*)"', s))
lit_blob = '\n'.join(literals)

decl = re.compile(r'^\s*(?:internal|public|private|protected|sealed|static|abstract|partial|\s)*(?:class|struct|interface|enum|record)\s+(\w+)\s*(?::\s*([\w\.<>,\s]+))?', re.M)
ident = collections.Counter()
for s in texts.values():
    ident.update(re.findall(r'[A-Za-z_][A-Za-z0-9_]*', s))


def obf(n):
    return bool(re.fullmatch(r'[A-Za-z0-9_]{10,}', n)) and sum(c.isdigit() for c in n) >= 3


rows = []
seen = set()
for f, s in texts.items():
    for m in decl.finditer(s):
        n = m.group(1)
        if (n, f) in seen:
            continue
        seen.add((n, f))
        base = (m.group(2) or '').strip()
        if not obf(n):
            continue
        in_str = n in lit_blob
        typeof_refs = sum(len(re.findall(r'typeof\s*\(\s*' + re.escape(n) + r'\s*\)', t)) for t in texts.values())
        rows.append([n, os.path.basename(f), ident[n], 'yes' if in_str else 'no', typeof_refs, base[:60]])

rows.sort(key=lambda r: (-r[2], r[0]))
out = os.path.join(root, 'type-roles.tsv')
with io.open(out, 'w', encoding='utf-8', newline='') as fh:
    w = csv.writer(fh, delimiter='\t')
    w.writerow(['type', 'file', 'code_refs', 'in_string_literal', 'typeof_refs', 'base_type'])
    w.writerows(rows)

print('total declarations:', len(seen))
print('obfuscated types:', len(rows))
print('string-referenced:', sum(1 for r in rows if r[3] == 'yes'))
print('typeof-referenced:', sum(1 for r in rows if r[4] > 0))
print('code-only (safe to rename candidates):', sum(1 for r in rows if r[3] == 'no' and r[4] == 0 and r[2] > 1))
print('out:', out)
for r in rows[:15]:
    print(r)

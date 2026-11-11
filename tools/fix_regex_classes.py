import glob, io, os, re, sys

root = sys.argv[1] if len(sys.argv) > 1 else '.'
files = glob.glob(os.path.join(root, '*.cs'))
texts = {f: io.open(f, encoding='utf-8', errors='replace').read() for f in files}

# 1) generated regex subclasses that nobody references outside their own file
removed = 0
for f, s in list(texts.items()):
    m = re.search(r'class (\w+) : Regex', s)
    if not m:
        continue
    name = m.group(1)
    users = [g for g, t in texts.items() if re.search(r'\b' + re.escape(name) + r'\b', t)]
    if users == [f]:
        os.remove(f)
        removed += 1
print('removed orphan regex classes:', removed)

# 2) rewrite [GeneratedRegex("...")] extern methods into new Regex("...")
pat = re.compile(
    r'\[GeneratedRegex\("((?:[^"\\]|\\.)*)"\)\]\r?\n'
    r'[ \t]*\[GeneratedCode\([^\]]*\)\]\r?\n'
    r'([ \t]*)(?:private|public|internal)\s+static\s+(?:extern\s+)?Regex\s+\w+\s*\(\s*\)\s*'
    r'(\{[^}]*\}|;)', re.S)
fixed = 0
for f, s in texts.items():
    def repl(m):
        global_fixed = None
        return m.group(2) + 'private static Regex __generated_regex()\n' + m.group(2) + '{\n' + m.group(2) + '\treturn new Regex("' + m.group(1) + '");\n' + m.group(2) + '}'
    s2, n = pat.subn(repl, s)
    if n:
        io.open(f, 'w', encoding='utf-8').write(s2)
        fixed += n
print('rewritten GeneratedRegex attrs:', fixed)

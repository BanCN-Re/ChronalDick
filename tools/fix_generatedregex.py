import io, os, re, sys

root = sys.argv[1]
p = os.path.join(root, 'p7aMTy5CiDjPcd5Qwt6.cs')
s = io.open(p, encoding='utf-8', errors='replace').read()
pat = re.compile(
    r'\[GeneratedRegex\("((?:[^"\\]|\\.)*)"\)\]\s*\n'
    r'([ \t]*)\[GeneratedCode\([^\]]*\)\]\s*\n'
    r'([ \t]*)private static Regex H155rm2NKw\(\)\s*\{\s*'
    r'return \(Regex\)\(object\)\w+\.\w+;\s*\}')
m = pat.search(s)
if not m:
    print('not matched')
    sys.exit(1)
indent = m.group(2)
rep = indent + 'private static Regex H155rm2NKw()\n' + indent + '{\n' + indent + '\treturn new Regex("' + m.group(1) + '");\n' + indent + '}'
s = s[:m.start()] + rep + s[m.end():]
io.open(p, 'w', encoding='utf-8').write(s)
print('patched')

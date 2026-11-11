import sys, io

def scan(path):
    s = io.open(path, encoding='utf-8-sig', errors='replace').read()
    depth = 0
    i = 0
    n = len(s)
    line = 1
    state = None  # None, 'line', 'block', 'str', 'verb', 'char'
    out = []
    while i < n:
        c = s[i]
        nxt = s[i+1] if i+1 < n else ''
        if c == '\n':
            line += 1
            if state == 'line':
                state = None
            i += 1
            continue
        if state is None:
            if c == '/' and nxt == '/':
                state = 'line'; i += 2; continue
            if c == '/' and nxt == '*':
                state = 'block'; i += 2; continue
            if c == '"':
                state = 'str'; i += 1; continue
            if c == '@' and nxt == '"':
                state = 'verb'; i += 2; continue
            if c == "'":
                state = 'char'; i += 1; continue
            if c == '{':
                depth += 1; out.append((line, depth))
            elif c == '}':
                depth -= 1; out.append((line, depth))
            i += 1
            continue
        if state == 'block':
            if c == '*' and nxt == '/':
                state = None; i += 2; continue
            i += 1; continue
        if state == 'str':
            if c == '\\':
                i += 2; continue
            if c == '"':
                state = None
            i += 1; continue
        if state == 'verb':
            if c == '"' and nxt == '"':
                i += 2; continue
            if c == '"':
                state = None
            i += 1; continue
        if state == 'char':
            if c == '\\':
                i += 2; continue
            if c == "'":
                state = None
            i += 1; continue
    return depth, out

if __name__ == '__main__':
    for p in sys.argv[1:]:
        d, out = scan(p)
        print(p, 'final_depth=', d, 'last_events=', out[-4:])

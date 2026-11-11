"""Per-line C# brace deltas ignoring strings, chars and comments."""


def deltas(text: str):
    lines = text.split("\n")
    out = [0] * len(lines)
    i, n, line = 0, len(text), 0
    state = None  # None | 'str' | 'verbatim' | 'char' | 'block' | 'line'
    while i < n:
        c = text[i]
        if c == "\n":
            if state == "line":
                state = None
            line += 1
            i += 1
            continue
        if state is None:
            if c == "/" and i + 1 < n and text[i + 1] == "/":
                state = "line"
                i += 2
                continue
            if c == "/" and i + 1 < n and text[i + 1] == "*":
                state = "block"
                i += 2
                continue
            if c == '"':
                state = "str"
                i += 1
                continue
            if c == "@" and i + 1 < n and text[i + 1] == '"':
                state = "verbatim"
                i += 2
                continue
            if c == "$" and i + 1 < n and text[i + 1] == '"':
                state = "str"
                i += 2
                continue
            if c == "'":
                state = "char"
                i += 1
                continue
            if c in "{}":
                out[line] += 1 if c == "{" else -1
            i += 1
            continue
        if state == "line":
            i += 1
            continue
        if state == "block":
            if c == "*" and i + 1 < n and text[i + 1] == "/":
                state = None
                i += 2
            else:
                i += 1
            continue
        if state == "str":
            if c == "\\":
                i += 2
            elif c == '"':
                state = None
                i += 1
            else:
                i += 1
            continue
        if state == "verbatim":
            if c == '"' and i + 1 < n and text[i + 1] == '"':
                i += 2
            elif c == '"':
                state = None
                i += 1
            else:
                i += 1
            continue
        if state == "char":
            if c == "\\":
                i += 2
            elif c == "'":
                state = None
                i += 1
            else:
                i += 1
            continue
    return out

"""Remove stray async-await debris left inside a stubbed method body.

In full/src-mahiro7/Mahiro.Security/v5OiSQSzC8GipXkQ3VG.cs the method
`vvCcVZnnHg` was replaced by a throw-stub, but the tail of the original
decompiled body survived as two lines: a mangled

    })->AwaitUnsafeOnCompleted<...>(ref *(A*)1, ref *(SM*)default(TaskAwaiter));

plus `return (Task<...>)(object)result;` referencing an undefined local.
v5 (src-mahiro5) has the same method as a clean stub, so the debris is dropped.
"""
import io

PATH = r"D:\Work\deobf\Chronal-crk-release\full\src-mahiro7\Mahiro.Security\v5OiSQSzC8GipXkQ3VG.cs"

with io.open(PATH, "r", encoding="utf-8-sig", newline="") as f:
    lines = f.readlines()

# 1-based 10609 / 10610 -> 0-based 10608 / 10609
a = lines[10608]
b = lines[10609]
assert a.lstrip().startswith("})->AwaitUnsafeOnCompleted<"), repr(a[:80])
assert "AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<qSLZnhtNYkiZ3RlIcPi>" in a, repr(a[:120])
assert b.strip() == "return (global::System.Threading.Tasks.Task<N1yckPfKpJ6amX0c2v79>)(object)result;", repr(b.strip())
# the stub throw must sit directly above the debris
assert lines[10607].strip() == "throw new global::System.NotSupportedException();", repr(lines[10607])
assert lines[10610].strip() == "}", repr(lines[10610])

del lines[10608:10610]

with io.open(PATH, "w", encoding="utf-8-sig", newline="") as f:
    f.writelines(lines)

print("removed 2 debris lines; file now %d lines" % len(lines))

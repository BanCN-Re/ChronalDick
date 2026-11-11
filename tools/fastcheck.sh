#!/usr/bin/env bash
# Fast error loop for the Mahiro tree: copy -> stub the 140 pathological methods -> build -> count.
# The stub set only exists to keep Roslyn's flow analysis from running for hours; errors reported
# in files OUTSIDE the stub set are real for the current tree.
set -uo pipefail
cd "$(dirname "$0")/.."          # full/
DOTNET="C:/Program Files/dotnet/dotnet.exe"
rm -rf tmp-fast
cp -r src-mahiro7/Mahiro.Security tmp-fast
rm -rf tmp-fast/bin tmp-fast/obj
py -3 tools/tmp_stub_big.py src-mahiro7/Mahiro.Security tmp-fast D:/tmp/big-methods.tsv
cd tmp-fast
"$DOTNET" restore Mahiro.Security.csproj -v q >/dev/null 2>&1
"$DOTNET" build Mahiro.Security.csproj -c Release --no-restore -v q -p:UseSharedCompilation=false > build-fast.log 2>&1
echo "exit=$?"
py -3 - <<'PYEOF'
import io,re,collections
stub=set(l.split('\t')[0] for l in io.open('D:/tmp/big-methods.tsv',encoding='utf-8'))
pat=re.compile(r"tmp-fast.([A-Za-z0-9_.]+)\.cs\((\d+),(\d+)\): error (CS\d+): (.*?) \[")
errs=[]
for l in io.open('build-fast.log',encoding='utf-8',errors='replace'):
    m=pat.search(l)
    if m: errs.append(m.groups())
non=[e for e in errs if e[0] not in stub]
by=collections.Counter(e[3] for e in non)
print('all_errors',len(errs),'non_stub_errors',len(non),'files',len({e[0] for e in non}))
print(by.most_common(12))
PYEOF

# M7-FINAL — Mahiro.Security reconstruction

Date: 2026-11-11.  Two source trees exist for Mahiro; this report states exactly what each one is.

## Delivered buildable tree — `full/src-mahiro4/Mahiro.Security`

| item | value |
|---|---|
| files | 3,009 `.cs` |
| build | `dotnet build -c Release --no-restore` -> 48 warnings, **0 errors** (24.8 s) |
| DLL | `bin/Release/net8.0-windows10.0.19041.0/Mahiro.Security.dll`, 3,889,152 B, sha256 `0e4ca0049b90d79b74a6c9470ac84f7cfea5c2548b86fd7edfa416e1d1178b1e` |
| strings | 0 decryptor calls left (already inlined in this export) |
| protection calls | 263 Reactor anti-tamper hook statements removed in this pass (134 files) |
| UNDECRYPTED stubs | 3,336 explicit marked throws (3,328 bodies Reactor never decrypted + 8 ILSpy-error bodies) |

This is the only Mahiro tree that compiles end-to-end. Its body coverage is lower than the newer
export (3,336 vs 1,906 stubs), but every gap is explicit and the assembly builds and ships.

## Higher-coverage WIP — `full/src-mahiro7/Mahiro.Security`

| item | value |
|---|---|
| files | 1,484 `.cs` (1,525 unreferenced helper-proxy files moved to `full/_deleted_helpers_mahiro7/`) |
| strings | 7,988/7,988 decryptor calls inlined (5,039 ids; 108 sign mis-readings repaired by engine-validated flips) |
| protection calls | 8,676 hook statements removed (1,339 files) |
| UNDECRYPTED stubs | 1,906 |
| build | **does not compile.** Real build exceeds 100 min of CPU in Roslyn's flow analysis on 140 flattened methods (100–300 `case` labels each); with those bodies stubbed a full binding pass takes ~30 s and reports **10,552 real errors in 763 files** |
| error profile (current) | CS1061 2,332 / CS0030 2,150 / CS0177 1,292 / CS0246 804 / CS0029 630 / CS0019 584 / CS0120 464 / CS0122 378 / CS0155 352 / CS1929 312 / CS0165 290 |
| repairs already applied | `throw "x"` -> `throw new Exception("x")` (693), bare literal statements -> `_ = "x";` (478), unbound `ICollection<>` -> `object` (630), readonly modifiers stripped on fields assigned outside ctors (567), TryParse `ref`->`out` (237), out-param initialisation (189 declaration sites + 278 return sites, 1,519 assignments), `x = ref y` -> `x = y` (1,355), `__ldftn` delegate construction (284, partial: trades CS0103 for CS0120) |
| remaining error nature | per-site decompiler artifacts: member calls on `object` receivers, invalid conversions (`(string)enumerator`), missing nested state-machine types (`_WaitAsync_d__10`), throws of non-exception values, `ref`-struct/`Span` misuse. Mechanical classes are exhausted; the rest needs per-site semantic repair like the earlier 85-fixer campaign. |

## Why the stubs exist (evidence)

For `vEVdSWX8wOeywlDEk3Kk.A5AtGfX8RTdtwYMZRkYq::ToString`: runtime `MethodBase.GetMethodBody()`
-> 395 bytes; harvest file -> 395 bytes; written body -> 395 bytes, **byte-identical**. The body
still contains Reactor decoy instructions (`newobj` with a field token, unbound generics) that no
C# decompiler can translate; ILSpy reports error islands for 906 `Invalid field token`, 360
field-as-method operands, 28 stack underflows. Per the project rule, such methods keep an explicit
`// UNDECRYPTED` throw instead of a fabricated body. Reflection cannot reach the executable body:
the engine returns this same decoy IL to `GetMethodBody`.

## Verification commands

```bash
# delivered tree (must print 0 errors)
cd full/src-mahiro4/Mahiro.Security && dotnet build -c Release --no-restore
# fast error probe for the WIP tree (stubs the 140 pathological methods; ~30 s)
bash full/tools/fastcheck.sh
# string / hook residue (must print 0)
grep -roh "LFHd1ojfYcRKGDVUDAUb.yjMjfFekXfb(" <tree>/*.cs | wc -l
grep -roh "LFHd1ojfYcRKGDVUDAUb\.\(SsXjfAZ8mMV\|WRJjLW46qrx\|t2vjfOtIwFT\)(" <tree>/*.cs | wc -l
```

## Honest status

Mahiro is **not** fully restored to a compiling, gap-free source tree. The compiling tree carries
3,336 marked stubs; the richer tree carries 1,906 stubs and 11,756 diagnostics. Chronal is complete.

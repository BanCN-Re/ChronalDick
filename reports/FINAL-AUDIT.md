# FINAL AUDIT — Chronal / Mahiro.Security reconstruction

Date: 2026-11-11 (evening).  Scope: both protected assemblies rebuilt as editable C# source trees
with the protection layer removed (not reimplemented), business logic carried over from the
runtime-harvested IL.

## Chronal — COMPLETE

| item | value |
|---|---|
| source tree | `full/src-work9b/Chronal` |
| source files | 211 `.cs` |
| build | `dotnet build -c Release` -> 662 warnings, **0 errors** (5.9 s; clean `-t:Rebuild` also 0 errors) |
| output DLL | `bin/Release/net8.0-windows10.0.19041.0/Chronal.dll`, 2,420,224 B |
| DLL sha256 | per-build (csproj `Deterministic=false`): `cfdaff42…517d4`, clean rebuild `7a060f39…8c6cfb` |
| string decryptor calls left | 0 (engine shim kept as an inert value shim) |
| strings inlined | 461 sites / 346 ids, including `CreateRemoteThread 失败` and the ClassicDownloadsPage XAML URI recovered in this pass (sign mis-read fix + strdump v10) |
| UNDECRYPTED stubs | **1** — `UTceUuLofwXEp4GdC3ht.cs::uREL7KfgxJ3`, a ~31 KB flattened machine whose body Reactor never decrypted |
| XAML token verifier | `verify_xaml_tokens verify` on the built DLL: satisfiedSites=544/544, missingTypes=0, helperCalls=0, leftoverTokenConstants=0 -> **PASS** |

## Mahiro.Security — two trees (compiling baseline / higher-coverage WIP)

The later export (`src-mahiro7`, from `mahiro.v5g.cf.dll`) recovers more bodies but is **not
compile-clean**; this audit measured that directly instead of relying on an earlier incremental
no-op. The earlier export (`src-mahiro4`) **does compile with 0 errors** and is delivered as the
buildable Mahiro source.

### src-mahiro4 — buildable (delivered)

| item | value |
|---|---|
| source files | 3,009 `.cs` |
| build | `dotnet build -c Release --no-restore` -> 48 warnings, **0 errors** (24.8 s) |
| output DLL | `bin/Release/net8.0-windows10.0.19041.0/Mahiro.Security.dll`, 3,889,152 B, sha256 `0e4ca0049b90d79b74a6c9470ac84f7cfea5c2548b86fd7edfa416e1d1178b1e` |
| strings | 0 decryptor calls left (already inlined in this tree) |
| protection calls | 263 Reactor anti-tamper hook statements removed in this pass (134 files) |
| UNDECRYPTED stubs | **3,336** (3,328 never-decrypted bodies + 8 ILSpy-error bodies), explicit throws with markers |

### src-mahiro7 — higher coverage, not compilable (WIP)

| item | value |
|---|---|
| source files | 1,484 `.cs` (1,525 unreferenced helper-proxy files removed) |
| strings | 7,988/7,988 inlined (5,039 ids, strdump v7; 108 sign mis-readings repaired) |
| protection calls | 8,676 hook statements removed (1,339 files) |
| UNDECRYPTED stubs | **1,906** |
| build status | does **not** compile. A binding-only probe (140 pathological methods stubbed out, ~30 s) reports **10,552 errors in 763 untouched files** after this pass's mechanical repairs (started at 19,090): CS1061 2,332 / CS0030 2,150 / CS0246 804 / CS0029 630 / CS0019 584 / CS0120 464 / CS0122 378 / CS0155 352 / CS1929 312 / CS0165 290 / CS0426 188 / CS1605 184 |
| repairs applied to mahiro7 | string artifacts (693 throws, 478 literal statements), unbound `ICollection<>`→`object` (630), readonly modifiers (567), TryParse ref→out (237), out-param initialisation (189 declaration sites + 278 return sites, 1,519 assignments), `x = ref y` (1,355), `__ldftn` delegate construction (284; note: this last pass traded some CS0103 for CS0120 and is under review) |
| compile-time pathology | full Release compile exceeds 100 min of CPU without finishing; the cost sits in 140 flattened methods (100–300 `case` labels each). Removing their bodies drops binding to 25.8 s, which isolates the cost to those methods' flow analysis/emission. |
| error root causes (sampled) | string-literal statements/throws introduced by inlining (`"text";`, `throw "text";`), `readonly` field assignments outside ctors, `ref`/`out` mismatches from proxy rewrites, references to nested state-machine types that do not exist in the assembly (`_WaitAsync_d__10`), unbound generic casts (`ICollection<>`), ref-struct misuse |

## Protection layer status (both delivered trees)

- Reactor string-decryptor entry points have no call sites left; Chronal keeps an inert
  `YoQLhoegTpw(int) => value.ToString()` shim, Mahiro's engine type is only a type container.
- All Reactor-injected anti-tamper hook calls removed (Chronal by `strip_reactor.py`; Mahiro by
  `strip_mahiro_hooks.py`: 8,676 in mahiro7, 263 in mahiro4; all standalone statements).
- `<Module>` cctor anti-tamper/hash checks are absent; module types remain only as holders of
  static fields that business code reads.
- Helper proxy delegate types removed where unreferenced (594 Chronal, 1,525 mahiro7).
- Original samples under `D:/Work/deobf/chronal/Chronal/` untouched.

## Honest completion statement

- Chronal: complete within the evidence (0 errors, 1/10,206 bodies unrecoverable and marked).
- Mahiro: an editable, compiling 1:1 source tree exists (`src-mahiro4`, 0 errors, 3,336 marked
  stubs). A higher-coverage tree exists (`src-mahiro7`, 1,906 stubs) but needs an error-repair
  campaign (19k diagnostics) and a faster compiler loop before it can replace mahiro4.
  Neither tree fabricates a body: every gap is an explicit marked throw.

## Detailed reports

- Mahiro: `full/reports/M7-FINAL.md`
- Chronal: `full/reports/W9B-FINAL.md`, `full/reports/W9B-XAML-STRINGS.md`

## Reproduce

```bash
cd full/src-work9b/Chronal && dotnet build -c Release
cd full/src-mahiro4/Mahiro.Security && dotnet build -c Release --no-restore
```

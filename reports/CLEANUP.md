# CLEANUP — 2026-11-11 22:1x–22:3x

Kept the latest line only; deleted superseded trees, harvest dumps and build caches.

## Kept (deliverables and their inputs)

| path | role |
|---|---|
| `full/src-work9b/Chronal` | final Chronal source (0 errors; DLL 2,420,224 B) |
| `full/src-mahiro4/Mahiro.Security` | compiling Mahiro source (0 errors; DLL 3,889,152 B) |
| `full/src-mahiro7/Mahiro.Security` | higher-coverage Mahiro WIP (1,906 stubs, not compiling) |
| `full/tools/**` (sources + csproj) | toolchain; bin/obj removed (rebuild on demand) |
| `full/reports/**` | FINAL-AUDIT, M7-FINAL, W9B-*, RECOVERY-CT, this file |
| `full/HANDOFF*.md`, `full/patch`, `full/scripts` | bootstrap patch + helper scripts |
| `full/_backup_m7_prehooks` | safety snapshot of mahiro7 before the bulk repairs |
| `full/_deleted_helpers_mahiro7` | removed proxy-helper provenance (2.3 MB) |
| `work/Chronal` | runtime assemblies referenced by the csproj HintPaths |
| `work/baseline.sha256` | upstream baseline |
| `work/memdump/mahiro.v5g.*` | latest Mahiro writeback lineage |
| `work/memdump/extracted_*.dll` | original memory extracts |
| `work/out/fullydec_Chronal.v3e.{decoy,fixed}.dll` + decisions | final Chronal writeback |
| `work/out/chronal-strings-v9/v10.tsv`, `mahiro-strings-v6/v7.tsv` | final string tables |
| `work/out/chronal-typemap.tsv`, `mahiro-tm.tsv`, `*-bodylist.tsv`, `mahiro-helper-targets-ret.tsv` | pipeline metadata |
| `work/out/manifests/` | the four harvest manifests (JSON) |
| `work/out/{chronal,Mahiro}.ret.dll` | cctor-patched builds used by strdump |

## Deleted

- **Probe trees**: `tmp-decoyexp`, `tmp-fast`, `tmp-onefile`, `tmp-onemethod`, `tmp-sdk8`, `tmp-timesplit`, `tmpwork`, `vmhelp`.
- **Superseded source trees** (≈50): `src-mahiro{0,2,3,5,6,6s}`, `src-rewrite{,2}`, `src-work{,3..9}`, `src-work9_{1..3}`, `src-work9b_{1..5}`, `src-work9c_{1..8}`, `src-work9d_{1..8}`.
- **Backups/archives** superseded: `_backup_chronal_prefinal`, `_backup_chronal_pretokens`, `_backup_mahiro4_prestr{,ings}`, `_backup_v7g1`, `_backup_w8g1`, `_backup_w9b_strfix`, `_backup_work8_pre_p5`, `_backup_m7_prestrings`, `_archive_mahiro7`, `_deleted_helpers_work{7,8,9b}`.
- **Memdump intermediates**: `chronal.dmp` (810 MB process dump), `fused_*`, `fullydec_Mahiro*.dll` (v1–v5), `mahiro.v3*`, `mahiro.v4*`, `mahiro.v5f*`, `mahiro.v5s`, `mahiro.dedecoy.*`, `decomp_v*`, `logs3`, `ilwriter2`, and the four `ilharvest*` directories (manifests preserved under `work/out/manifests/`).
- **work/out intermediates**: all older `fullydec_Chronal.*` DLLs/decisions (v3e kept), `chronal.modfix/m8fix`, duplicate typemaps, older string tables (v5 and below), apply reports, duplicate helper-target tables, `cap*.cs`.
- **Old runtime-deps copies**: `strdeps`, `strdeps-mahiro{,2}`, `deps-chronal2`, `strdeps-mahiro7`, `vmrun-deps-*`, `probe-deps*` (re-create from `work/Chronal` + ret DLLs if strdump is needed again).
- **Build logs**: `work/build*.log`, `mahiro-build*.log`, `s_err*.txt`, `c_err*.txt`, plus misc intermediate `work/` dirs (`chronal-pipeline`, `mahiro-eh-pipeline`, `dump`, `dyntrace`, `jitraw`, `snap-clean`, `src`, `tmp-strings-test`, `unshelled`, `vmres`).
- **Tool build outputs**: every `full/tools/*/bin` and `*/obj` (rebuild with `dotnet build <tool>.csproj`).

## Post-cleanup verification

```
full/src-work9b/Chronal            -t:Rebuild -> 0 errors, DLL 2,420,224 B
full/src-mahiro4/Mahiro.Security   -t:Rebuild -> 0 errors, DLL 3,889,152 B
```

Directory sizes after cleanup: `full` ≈ 190 MB, `work` ≈ 235 MB (was >1.5 GB in intermediates alone).
Originals under `D:/Work/deobf/chronal/Chronal/` untouched (Nov 7 timestamps).

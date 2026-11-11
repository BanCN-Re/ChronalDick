# RECOVERY ANCHOR — Chronal/Mahiro reconstruction

Updated: 2026-11-11 22:25 local.

## Deliverables so far
- **Chronal: COMPLETE.** `full/src-work9b/Chronal` — 211 files, 0 errors (5.9 s), DLL 2,420,224 B,
  XAML 544/544 PASS, 461 strings inlined, 1 marked stub (`UTceUuLofwXEp4GdC3ht.cs::uREL7KfgxJ3`).
- **Mahiro buildable tree: `full/src-mahiro4/Mahiro.Security`** — 3,009 files, 0 errors (24.8 s),
  DLL 3,889,152 B sha256 `0e4ca0049b90d79b74a6c9470ac84f7cfea5c2548b86fd7edfa416e1d1178b1e`,
  strings inlined (0 decryptor calls), 263 hook calls stripped, **3,336 marked stubs**.
- **Mahiro high-coverage WIP: `full/src-mahiro7/Mahiro.Security`** — 1,484 files, 7,988 strings
  inlined, 8,676 hook calls stripped, **1,906 marked stubs**, does NOT compile yet.

## Mahiro7 error-repair state (in progress)
- `/tmp` fast loop: `full/tools/fastcheck.sh` copies the tree, stubs the 140 pathological methods
  (100–300 `case` labels; without them Roslyn runs 100+ min), restores, builds (~30 s), prints the
  error profile. Only errors in files OUTSIDE the stub set are real.
- Progress: 19,090 non-stub errors -> **10,552** (763 files) after:
  - `full/tools/fix_string_artifacts.py` (693 `throw "x"` -> `throw new Exception("x")`, 478 bare literal statements -> `_ = "x";`)
  - unbound `ICollection<>` -> `object` (630 occurrences)
  - `full/tools/fix_readonly_ref.py` (567 readonly modifiers stripped, 237 TryParse ref->out)
  - `full/tools/fix_outparams.py` (189 declaration + 278 return sites, 1,519 `= default;` insertions)
  - `full/tools/fix_ref_and_ldftn.py` (1,355 `x = ref y` -> `x = y`, 284 `__ldftn` sites; the ldftn part is partial and trades CS0103 for CS0120 — review before relying on it)
  - regenerate the current log with `tools/fastcheck.sh` (it writes `tmp-fast/build-fast.log`)
- Remaining top classes as of 10,552: CS1061 2,332 / CS0030 2,150 / CS0246 804 / CS0029 630 /
  CS0019 584 / CS0120 464 / CS0122 378 / CS0155 352 / CS1929 312 / CS0165 290 / CS0426 188 / CS1605 184.
  These are per-site decompiler artifacts; the mechanical classes are mostly exhausted.

## Backups
- `full/_backup_m7_prehooks` — mahiro7 state right before hook stripping (strings already inlined).
- `full/_backup_m7_prestrings` — before string inlining.
- `full/_deleted_helpers_mahiro7` (1,525 files), `full/_archive_mahiro7`.

## Next actions
1. Continue mahiro7: sample CS1061/CS0030 sites, fix by pattern (`(obj).GetX()` casts, `_u__ = ref v`
   assignment, `__ldftn` delegate construction), rerun `tools/fastcheck.sh` each round.
2. When non-stub errors reach 0: run the real full build on `src-mahiro7` (hours; use
   `-p:UseSharedCompilation=false -flp:LogFile=...`), record DLL size/hash, then re-check stub count.
3. Do NOT claim Mahiro complete while mahiro7 has errors/stubs; mahiro4 is the compiling artifact.

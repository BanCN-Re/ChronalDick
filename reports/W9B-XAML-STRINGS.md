# src-work9b XAML / token / 字符串三步移植

**结论**：`full/src-work9b/Chronal` 已补齐 work8 的三步——XAML provider 栈并入编译、544 个元数据 token 点位改 `typeof(...)`、459 处字符串调用落明文。`-t:Rebuild` 0 错误 / 661 警告，DLL 2,420,224 B；三张 token 期望表（544 / 480 / 531）全部 PASS。

## 1. XAML provider 恢复
- 备份 `Chronal.csproj.bak-xaml`；删 6 条 `<Compile Remove>`（5 个 Xaml* 与 `_removed_generated/**`），与 `src-work8/Chronal/Chronal.csproj` diff = 0 行。
- 自 work8 整份覆盖 5 文件：`XamlMember.cs` / `XamlMetaDataProvider.cs` / `XamlSystemBaseType.cs` / `XamlUserType.cs` / `XamlTypeInfoProvider.cs`（work9b 原件存 `.bak-v9xaml`；原件里构造器被反编译成 `public void Xxx()` + 死方法 `_cctor`）。
- `XamlMetaDataProvider.Stub.cs` → `.disabled`；`_removed_generated/GlobalVtableLookup.cs` → `.dup-sourcegen.bak`（否则与源生成器 `WinRTGlobalVtableLookup.g.cs` 撞 CS0101）。
- work9b 自带的 3 个 `*WinRTTypeDetails.cs` 保留原样（有真实 `GetExposedInterfaces` 体，优于 work8 的 UNDECRYPTED 桩），仅未参与本次覆盖。

## 2. token 修复与校验
| 项 | 值 |
|---|---|
| 随 provider 带入的改写 | 427 个 `typeof(global::…)` 站点（`XamlTypeInfoProvider.cs`） |
| `fix_xaml_tokens.py --root src-work9b/Chronal` | **47 文件 / 116 处**，distinctTypes=56，未解析 token 0（计划表 `w9b_token_plan.tsv`） |
| 合计点位 | **544 处 / 247 类型**；树内 helper 仅剩声明 1 处 |

```
verify <新 DLL> src-work9b/Chronal/w9b_expect.tsv → expectedSites=544 satisfiedSites=544 missingTypes=0 helperCalls=0 leftoverTokenConstants=0 RESULT: PASS
verify <新 DLL> tools/v7_expect.tsv             → 480/480  RESULT: PASS
verify <新 DLL> src-work8/Chronal/w8_expect.tsv → 531/531  RESULT: PASS
InitTypeTables[0]=Microsoft.UI.Xaml.Controls.XamlControlsResources（三表一致）
```
期望表由 `tools/strdump-v9/helpers/make_xaml_expect.py` 扫描生成（把 `IList<object>` 之类 C# 简写归一成元数据名 `IList`1<System.Object>`，并补全未限定泛型实参）。

## 3. 字符串（345 id / 461 站点）
- `tools/strdump-v9` = `strdump-v7` 副本（AssemblyName 改 v9，站点扫描参数指向 `full/src-work9b/Chronal`），同一 anti-tamper 路线：`chronal.ret.dll` 载入后 `STRDUMP_RESTORE_MOVE=1` 回填 `work/chronal-pipeline/orig/Chronal.dll` 原始字节。
- 运行：`files=211 sites=461 distinct-field-call-sites=461` → `distinct-evaluable=345 ok=343 null=0 failed=2`；与历史表按 id 并集 **49 + 297 = 346 行** → `work/out/chronal-strings-v9.tsv`。
- `apply_strings_chronal.py`：**459/461 替换，2 未匹配，36 文件**。头部：`McpBuilderService`(50)、`iv7VBsjI8muRaeK8cVn`(34)、`McpInjectionService`(32)、`App`(28)、`AppShell`(27)、`McpBuildEnvironmentService`(26)。

## 4. 构建与产物校验
```
"C:/Program Files/dotnet/dotnet.exe" build -c Release --nologo -p:RunAnalyzers=false -clp:ErrorsOnly -t:Rebuild
→ 0 错误 / 661 警告（移植前基线 2,094,592 B / sha256 6d362a77…）
bin/Release/net8.0-windows10.0.19041.0/Chronal.dll  2,420,224 B
sha256 515b80fe26d53ca083f48cc6005e015c790b6a7bbddc5f0189d6e36cba7a891f   （Deterministic=false，每次 rebuild 的 MVID 不同，字节数恒为 2,420,224）
```
- `ilspycmd -l c` → 938 类，其中含 xaml 者 **45 个**：8 个 `Mahiro_Account.Chronal_XamlTypeInfo.*`、3 个 WinRT vtable details、34 个 `*XamlBindingSetters`。
- UTF-16LE 字节检索抽样 **10/10 命中**：`{{ type = {0}, requestId = {1} }}`、`IDAT`、` GiB`、`Login4399GeneratedCredentials`、`, Output = `、`Submission` 等。

## 5. 剩余缺口
- 业务方法体 UNDECRYPTED 仍 **1 处**（`UTceUuLofwXEp4GdC3ht.cs:22401` 的 `uREL7KfgxJ3`）；`YoQLhoegTpw` 调用残留 2 处。
- 2 个未匹配 id：`0xFFFFEAA2`（`iv7VBsjI8muRaeK8cVn.cs:3061`）、`0xFFFFF3A4`（`McpInjectionService.cs:2500`），均来自 `-662046383 ^ …` 负数站点，引擎抛 `ArgumentOutOfRangeException(startIndex)`，表内无此 id，保留原调用。
- `XamlMetaDataProvider.Stub.cs.disabled` 保留未删，供后续对照。
**证据文件**（均在 `full/src-work9b/Chronal/`）：`w9b_expect.tsv`、`w9b_token_plan.tsv`、`w9bstr-run.log`、`w9bstr-diag.txt`、`w9bstr-applied.tsv`、`w9b-types-final.txt`；工具 `full/tools/strdump-v9/`（含 `helpers/make_xaml_expect.py`、`helpers/check_strings_utf16.py`）。

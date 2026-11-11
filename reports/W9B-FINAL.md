# W9B FINAL — src-work9b Chronal 构建收敛报告

## 结果
- 起始 39 错误 / 8 文件 → **0 错误**（Release；`-t:Rebuild` 全量重建确认 0 错误、661 警告）
- DLL：`full/src-work9b/Chronal/bin/Release/net8.0-windows10.0.19041.0/Chronal.dll`
  - 大小 2,203,648 字节
  - SHA256 `463b58cb9836f9e3eeacda0ae2c0788fe50ebb6532ff5f2638628c82e3aad580`
- UNDECRYPTED stub：**1**（`UTceUuLofwXEp4GdC3ht.cs:22401` `uREL7KfgxJ3`，方法体为 ILSpy 占位符，仍抛 NotSupportedException）

## 逐类修复
| 文件 | 错误 | 修复 |
|---|---|---|
| fCh7uDxLklaY8sQGcF.cs | 12 | `code/size/obj19/obj7/obj9` 局部改型（uint/int/VW922EHC2yTH7A8aDT）；`counters` 定 `SETtwX9jwcZBEDDUmR6`；装箱枚举器 `Enumerator<int,T>` ×3 改为 `Unsafe.As<object, Dictionary<int,T>.ValueCollection.Enumerator>(ref obj16)`（对应原 IL 的 unbox 指针语义） |
| qiPowfLrI8h0QeonOQ0X.cs | 10 | `byte*`→`object` 经 `(IntPtr)`；for 计数器 object→int；补齐 `g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y` 嵌套替身（流包装，实现 KR5785vTkC/IHnLrySmBWA） |
| McpPythonCompiler.cs | 6 | 动态 AppendFormatted 实参显式转 `(int)`/`(string)`；`--常量` → `-(-常量)` ×2；`__u__1/obj14/obj15` 定型为 `ConfiguredTaskAwaitable(.ConfiguredTaskAwaiter)`，`AwaitUnsafeOnCompleted` 泛型实参同步 |
| iv7VBsjI8muRaeK8cVn.cs | 3 | dynamic `Percent` 先转 `(double)`；代理残留 `uvAb3KLOt7j86XDJ0NNL.hYoLOOUm2VC` 移除（值已是预格式化尺寸串，无格式参数） |
| UiHelpers.cs | 3 | 插值内 `global::System.DateTime` 加括号，消除 `:` 格式歧义；`_cctor` 还原为 static 构造（`__c_24`、`UiHelpers`） |
| BpOjxVLPwPUO93lZkbW.cs | 2 | 代理残留 `gASDEMLPaSjOaUPC8fQE.RPqLKGHxrab/fbJLP1WFJ3q` → `string.Empty`（缓存凭据读取不可恢复，就地注释） |
| Mahiro_..._BindingsWinRTTypeDetails.cs | 1 | IID 直接赋 `IComponentConnectorMethods.IID`（Guid），去掉 `Unsafe.Read<Guid>((void*)…)` |
| Pay4399Page.cs | 2 | `catch (object obj) when` → `catch (OperationCanceledException) when`；`((Page)this).OnNavigatedTo` → `base.OnNavigatedTo` |

## 剩余缺口
- 唯一 stub：`uREL7KfgxJ3` 仍抛 NotSupportedException（需重新 harvest 该 body）。
- 字符串解密仍是占位：`g9MiPrL41bvmHLMo2Exb.YoQLhoegTpw` 返回数字 id 文本，全部文案表现为 id 串。
- 3 处 Reactor 代理残留按默认值退化（缓存密码读取、格式参数、事件目标）。
- `UiHelpers.LineSeparators` 初值仅为长度 7 的全 NUL 数组（原 `<PrivateImplementationDetails>` 二进制未回填），`SplitLines` 实际不会拆分。
- 661 条警告未逐条处理（构建以 ErrorsOnly 输出，仅统计总数）。

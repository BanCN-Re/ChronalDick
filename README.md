# ChronalDick — Chronal / Mahiro.Security 反编译重建（未完成）

> **这不是原始源码，也还不是"可读的源码"。** 这是对 .NET Reactor 保护的 Chronal 与
> Mahiro.Security 两个程序集做运行时抽取 + 反编译 + 修补得到的重建产物。标识符仍是
> 混淆名（Reactor 单向改名，原始名字不存在于任何元数据中，无法恢复）；控制流仍是被
> Reactor 扁平化后的 `while/switch/goto` 状态机；大量位置带着反编译伪影。部分方法
> Reactor 从未解密，只能保留显式的 `UNDECRYPTED` 抛出桩。请按"研究中间产物"而不是
> "可交付源码"来看待本仓库。

## 结论先行（如实）

| 对象 | 状态 | 事实 |
|---|---|---|
| **Chronal** | 可编译 | 211 个 `.cs`，Release 编译 **0 错误**；DLL 2,420,224 B。XAML token 校验 544/544 通过；461 条字符串已内联（解密调用 0 残留）。**仍有 1 个方法体从未被 Reactor 解密**（`UTceUuLofwXEp4GdC3ht.cs::uREL7KfgxJ3`，31 KB 状态机），以显式 throw 桩保留。 |
| **Mahiro（可编译线）** | 可编译 | 3,009 个 `.cs`，Release 编译 **0 错误**；DLL 3,889,152 B。字符串已内联、防篡改钩子已清除。**3,336 个方法体是显式标记的 `UNDECRYPTED` 桩**（占 33,762 个方法的 9.9%）。 |
| **Mahiro（高覆盖 WIP）** | **不可编译** | 1,484 个 `.cs`，桩数降到 **1,906**（5.6%），字符串 7,988/7,988 内联、8,676 个钩子调用已删。但**实测有 10,552 条编译错误（763 个文件）**；另有 140 个含 100–300 个 `case` 的扁平方法会让 Roslyn 流分析跑 100 分钟以上不出结果。 |
| 运行时等价性 | **未验证** | 没有对重建产物做端到端运行对比；已去除保护层的代码不保证与原程序行为一致。 |

**差距还很大**：两个程序集都不是"完整、可读、可维护、等价"的源码。Chronal 接近可用但仍缺 1 个体；
Mahiro 只能做到"有一个能编译但缺口很大的版本"和"一个缺口更小但编不过的版本"二选一。

## 为什么说"不是可读源码"

1. **名字**：`v5OiSQSzC8GipXkQ3VG`、`A5AtGfX8RTdtwYMZRkYq` 这类标识符来自原始元数据，
   是 Reactor 的改名结果；反混淆名不可逆，任何"还原原名"的尝试都是编造，且会破坏
   XAML/反射/序列化的对应关系。
2. **控制流**：原方法被拆成状态机（`int num = 5; while(true){ switch(num){ ... } }`），
   反编译只能重建这个形态，不能还原为原始 if/for。
3. **反编译伪影**：`ICollection<>` 这类未绑定泛型、object 上调成员、非法转换、缺失的
   嵌套状态机类型等，都是 ILSpy 对诱饵/畸形 IL 的妥协产物。
4. **缺口**：Reactor 对反射 `GetMethodBody()` 返回的是诱饵 IL（与写入体内的字节逐字节相同），
   因此这些方法的真实执行体现在通过反射拿不到；保留显式桩是唯一诚实的选择。

## 仓库结构

```
src/Chronal/            Chronal 最终源码（可编译，1 个标记桩）
src/Mahiro.Security/    Mahiro 可编译源码（3,336 个标记桩）
wip/Mahiro.Security/    Mahiro 高覆盖 WIP（1,906 个标记桩，10,552 条错误，不可编译）
reports/                审计、修复进度、恢复锚点、清理记录
tools/                  修复脚本与快速错误回路（fastcheck.sh）
```

不含任何原始二进制、进程转储或上游应用文件；版权归原作者，本仓库仅用于保护机制与
反编译方法研究。

## 复现

```bash
# Chronal
cd src/Chronal && dotnet build -c Release

# Mahiro（可编译线）
cd src/Mahiro.Security && dotnet build -c Release

# Mahiro WIP 的快速错误面（约 30 秒：桩掉 140 个病态方法后只做绑定）
# 需要先按 reports/RECOVERY-CT.md 准备好 big-methods 列表与临时目录
bash tools/fastcheck.sh
```

## 已知缺口（Roadmap）

- [ ] Mahiro WIP：10,552 条错误逐点修复（CS1061/CS0030/CS0246… 多为反编译伪影，需要按位点判断）。
- [ ] Mahiro WIP：解决 140 个病态方法的编译时间问题，才能跑完整构建。
- [ ] Mahiro：把可编译线的 3,336 个桩尽量替换为真实体（受限于诱饵 IL 与反编译器能力）。
- [ ] Chronal：`uREL7KfgxJ3` 的 31 KB 状态机从未被解密，暂无法恢复。
- [ ] 任何运行期等价性验证（启动、登录、注入等链路）都尚未进行。
- [ ] 名称、控制流、伪影三座山未解决——"1:1 可读源码"的目标尚未达成。

## 证据与审计

- `reports/FINAL-AUDIT.md` — 两棵树逐项数据、编译与校验证据
- `reports/M7-FINAL.md` — Mahiro 两棵树、桩根因（诱饵 IL 逐字节比对）、修复清单
- `reports/RECOVERY-CT.md` — 当前断点与继续修复的操作步骤
- `reports/CLEANUP.md` — 产物清理记录

using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using BG9sBqf6kx9MZ3vTYp4d;
using By1SFsLobKQOZCdh5qRg;
using Ho1Bbrf69UmDWyTf7WZ4;
using JvgQTDcbARdEdTAk7GE;
using Mahiro_Account.Features.McpStudio.Builder;
using Mahiro_Account.Features.McpStudio.Models;
using Mahiro_Account.Features.McpStudio.Services;
using Mahiro_Account.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using VW5x9Sf6Yl3Avl436WrG;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.DataTransfer;
using Windows.Storage;
using Windows.System;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;
using r5LWFs73eOlXSX66CSK;

namespace Mahiro_Account.Features.McpStudio.Views;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class McpStudioPage : Page, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__46_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008f;
				}
				if (!mcpStudioPage._fileOperation && !mcpStudioPage._injecting && mcpStudioPage._cloudSyncCancellation == null)
				{
					_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__46_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_008f;
				}
				goto end_IL_0011;
				IL_008f:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private static class __O_2
	{
		public static Func<Dictionary<int, global::System.DateTime?>> _0___ReadGameSessions;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_11
	{
		public static readonly __c_11 __9;

		public static Func<KeyValuePair<int, global::System.DateTime?>, int> __9__51_0;

		public static Func<KeyValuePair<int, global::System.DateTime?>, string> __9__51_1;

		public static Func<KeyValuePair<string, McpInjectionService.Submission>, string> __9__51_3;

		public static Func<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>> __9__51_4;

		public static Func<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>> __9__51_5;

		public static Func<KeyValuePair<string, McpInjectionService.Submission>, string> __9__55_2;

		[MethodImpl((MethodImplOptions)8)]
		static __c_11()
		{
			__9 = (__c_11)new __c_11();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_11()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int _RefreshAsync_b__51_0(KeyValuePair<int, global::System.DateTime?> pair)
		{
			return pair.Key;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _RefreshAsync_b__51_1(KeyValuePair<int, global::System.DateTime?> pair)
		{
			return $"{pair.Key}:{pair.Value?.Ticks}";
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _RefreshAsync_b__51_3(KeyValuePair<string, McpInjectionService.Submission> pair)
		{
			return pair.Key;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal ValueTuple<string, long, global::System.DateTime, bool, string> _RefreshAsync_b__51_4(McpLocalFile file)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, long, global::System.DateTime, bool, string>(file.FilePath, file.SizeBytes, file.LastWriteTime, file.IsInjected, file.EntryModule);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal ValueTuple<string, long, global::System.DateTime, bool, string> _RefreshAsync_b__51_5(McpLocalFile file)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			return new ValueTuple<string, long, global::System.DateTime, bool, string>(file.FilePath, file.SizeBytes, file.LastWriteTime, file.IsInjected, file.EntryModule);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _Inject_Click_b__55_2(KeyValuePair<string, McpInjectionService.Submission> pair)
		{
			return pair.Key;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_0_2
	{
		public CancellationTokenSource cancellation;

		public McpStudioPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _BuildMcp_Click_b__0(string message)
		{
			if (!cancellation.IsCancellationRequested && __4__this._buildCancellation == cancellation)
			{
				__4__this.BuildMessage(message);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_1
	{
		public McpBuildOptions options;

		public Progress<string> progress;

		public __c__DisplayClass14_0_2 CS___8__locals1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<McpBuildResult>? _BuildMcp_Click_b__1()
		{
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			return CS___8__locals1.__4__this._builder.BuildAsync(options, (IProgress<string>?)(object)progress, CS___8__locals1.cancellation.Token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0_4
	{
		public McpStudioPage __4__this;

		public CancellationTokenSource cancellation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _CloudSync_Click_b__0(string message)
		{
			if (__4__this._cloudSyncCancellation == cancellation && !cancellation.IsCancellationRequested)
			{
				__4__this.CloudStatusText.Text = "云端库状态：" + message;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_1
	{
		public McpCloudSyncService service;

		public pKPWErf6DBoy2hpuUB59 response;

		public Progress<string> progress;

		public __c__DisplayClass18_0_4 CS___8__locals1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<McpCloudSyncService.SyncResult>? _CloudSync_Click_b__1()
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			return service.SyncAsync((global::System.Collections.Generic.IEnumerable<JEDl1cf6VmwwyP6UuZ5V>)response.Items, CS___8__locals1.__4__this._library.PendingPath, (IProgress<string>?)(object)progress, CS___8__locals1.cancellation.Token);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass26_0_2
	{
		public McpLocalFile file;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass26_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _FileDetails_Click_b__0()
		{
			FileStream val = File.OpenRead(file.FilePath);
			try
			{
				return Convert.ToHexString(SHA256.HashData((Stream)(object)val));
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass51_0
	{
		public Dictionary<int, global::System.DateTime?> games;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass51_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshAsync_b__2(KeyValuePair<string, McpInjectionService.Submission> pair)
		{
			global::System.DateTime? dateTime = default(global::System.DateTime?);
			if (games.TryGetValue(pair.Value.ProcessId, out dateTime))
			{
				if (dateTime.HasValue)
				{
					return dateTime.Value != pair.Value.StartedAt;
				}
				return false;
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass52_0
	{
		public string term;

		public Func<McpLocalFile, bool> __9__0;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass52_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ApplyFileFilter_b__0(McpLocalFile file)
		{
			if (term.Length != 0 && !file.FileName.Contains(term, (StringComparison)5))
			{
				return file.EntryModule.Contains(term, (StringComparison)5);
			}
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass55_0
	{
		public McpStudioPage __4__this;

		public McpLocalFile file;

		public string address;

		public string entry;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass55_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<McpInjectionService.Submission>? _Inject_Click_b__0()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			return __4__this._injector.InjectAndActivateAsync(file.FilePath, address, entry);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass55_1
	{
		public McpInjectionService.Submission submission;

		public Func<KeyValuePair<string, McpInjectionService.Submission>, bool> __9__1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass55_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Inject_Click_b__1(KeyValuePair<string, McpInjectionService.Submission> pair)
		{
			if (pair.Value.ProcessId == submission.ProcessId)
			{
				return pair.Value.EntryModule == submission.EntryModule;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BuildMcp_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private __c__DisplayClass14_1 __8__1;

		private __c__DisplayClass14_0_2 __8__2;

		private TaskAwaiter<string> __u__1;

		private TaskAwaiter __u__2;

		private TaskAwaiter<McpBuildResult> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0329: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0346: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0055;
				}
				__8__2 = (__c__DisplayClass14_0_2)new __c__DisplayClass14_0_2();
				__8__2.__4__this = __4__this;
				if (mcpStudioPage._buildCancellation == null)
				{
					__8__2.cancellation = new CancellationTokenSource();
					goto IL_0055;
				}
				goto end_IL_0011;
				IL_0055:
				try
				{
					if ((uint)num > 2u)
					{
						mcpStudioPage._buildCancellation = __8__2.cancellation;
						mcpStudioPage.SetBuildBusy(busy: true);
						mcpStudioPage.BuildLogBox.Text = string.Empty;
					}
					try
					{
						TaskAwaiter<string> _u__3 = default;
						TaskAwaiter _u__2 = default;
						TaskAwaiter<McpBuildResult> _u__ = default;
						string result;
						switch (num)
						{
						default:
							__8__1 = (__c__DisplayClass14_1)new __c__DisplayClass14_1();
							__8__1.CS___8__locals1 = __8__2;
							if (!Directory.Exists(mcpStudioPage.SourceDirectoryBox.Text))
							{
								throw new DirectoryNotFoundException("请选择有效的源码输入目录");
							}
							if (string.IsNullOrWhiteSpace(mcpStudioPage.PackageIdBox.Text))
							{
								throw new InvalidOperationException("请填写包 ID");
							}
							if (string.IsNullOrWhiteSpace(mcpStudioPage.OutputPathBox.Text))
							{
								throw new InvalidOperationException("请选择 MCP 输出路径");
							}
							__8__1.progress = new Progress<string>((Action<string>)__8__1.CS___8__locals1._BuildMcp_Click_b__0);
							if (!mcpStudioPage._buildEnvironment.IsInstalled || string.IsNullOrWhiteSpace(mcpStudioPage.PythonPathBox.Text))
							{
								_u__3 = mcpStudioPage._buildEnvironment.EnsureInstalledAsync((IProgress<string>?)(object)__8__1.progress, __8__1.CS___8__locals1.cancellation.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _BuildMcp_Click_d__14>(ref _u__3, ref this);
									return;
								}
								goto IL_01dd;
							}
							goto IL_0206;
						case 0:
							_u__3 = __u__1;
							__u__1 = default(TaskAwaiter<string>);
							num = (__1__state = -1);
							goto IL_01dd;
						case 1:
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_02f7;
						case 2:
							{
								_u__ = __u__3;
								__u__3 = default(TaskAwaiter<McpBuildResult>);
								num = (__1__state = -1);
								break;
							}
							IL_02f7:
							_u__2.GetResult();
							_u__ = global::System.Threading.Tasks.Task.Run<McpBuildResult>((Func<global::System.Threading.Tasks.Task<McpBuildResult>>)__8__1._BuildMcp_Click_b__1, __8__1.CS___8__locals1.cancellation.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpBuildResult>, _BuildMcp_Click_d__14>(ref _u__, ref this);
								return;
							}
							break;
							IL_01dd:
							result = _u__3.GetResult();
							if (string.IsNullOrWhiteSpace(mcpStudioPage.PythonPathBox.Text))
							{
								mcpStudioPage.PythonPathBox.Text = result;
							}
							goto IL_0206;
							IL_0206:
							mcpStudioPage.UpdateEnvironmentStatus();
							__8__1.options = (McpBuildOptions)new McpBuildOptions
							{
								PythonPath = mcpStudioPage.PythonPathBox.Text,
								GoPath = mcpStudioPage._buildEnvironment.GoPath,
								PackageToolPath = mcpStudioPage._buildEnvironment.PackageToolPath,
								SourceDirectory = mcpStudioPage.SourceDirectoryBox.Text,
								PackageId = mcpStudioPage.PackageIdBox.Text.Trim(),
								EntryModule = mcpStudioPage.BuildEntryModuleBox.Text.Trim(),
								OutputPath = mcpStudioPage.OutputPathBox.Text
							};
							_u__2 = mcpStudioPage.SaveBuildSettingsAsync().GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BuildMcp_Click_d__14>(ref _u__2, ref this);
								return;
							}
							goto IL_02f7;
						}
						McpBuildResult mcpBuildResult = (mcpStudioPage._lastBuild = _u__.GetResult());
						mcpStudioPage.BuildMessage($"构建成功：{mcpBuildResult.EntryCount} 个条目，{mcpBuildResult.SizeBytes:N0} 字节。");
						mcpStudioPage.BuildResultText.Text = $"{mcpBuildResult.OutputPath}\n入口：{mcpBuildResult.EntryModule}\nSHA-256：{mcpBuildResult.Sha256}";
						((UIElement)mcpStudioPage.BuildResultPanel).Visibility = (Visibility)0;
						mcpStudioPage.Notice("MCP 已构建，可将产物添加到文件库。", (InfoBarSeverity)1);
						__8__1 = null;
					}
					catch (OperationCanceledException)
					{
						mcpStudioPage.BuildMessage("构建已取消。");
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "BuildMcp_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 158);
						mcpStudioPage.BuildMessage("构建失败：" + ex2.Message);
						mcpStudioPage.Notice(mcpStudioPage.BuildStatusText.Text, (InfoBarSeverity)3);
					}
					finally
					{
						if (num < 0)
						{
							mcpStudioPage._buildCancellation = null;
							mcpStudioPage.SetBuildBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && __8__2.cancellation != null)
					{
						((global::System.IDisposable)__8__2.cancellation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CloudSync_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private __c__DisplayClass18_1 __8__1;

		private __c__DisplayClass18_0_4 __8__2;

		private object __7__wrap1;

		private int __7__wrap2;

		private v5OiSQSzC8GipXkQ3VG _api_5__4;

		private McpCloudSyncService.SyncResult _result_5__5;

		private TaskAwaiter<pKPWErf6DBoy2hpuUB59> __u__1;

		private TaskAwaiter<McpCloudSyncService.SyncResult> __u__2;

		private TaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0406: Expected O, but got Unknown
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_051c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			//IL_0539: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Expected O, but got Unknown
			//IL_049b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 4u)
				{
					goto IL_0060;
				}
				__8__2 = (__c__DisplayClass18_0_4)new __c__DisplayClass18_0_4();
				__8__2.__4__this = __4__this;
				if (mcpStudioPage._cloudSyncCancellation == null && mcpStudioPage.CanChangeFiles())
				{
					__8__2.cancellation = new CancellationTokenSource();
					goto IL_0060;
				}
				goto end_IL_0011;
				IL_0060:
				try
				{
					if ((uint)num > 4u)
					{
						mcpStudioPage._cloudSyncCancellation = __8__2.cancellation;
						((Control)mcpStudioPage.CloudSyncButton).IsEnabled = false;
						((UIElement)mcpStudioPage.CancelSyncButton).Visibility = (Visibility)0;
						((UIElement)mcpStudioPage.CloudProgress).Visibility = (Visibility)0;
						((UIElement)mcpStudioPage.CloudErrorsPanel).Visibility = (Visibility)1;
						mcpStudioPage.CloudErrorsText.Text = string.Empty;
						mcpStudioPage.CloudStatusText.Text = "云端库状态：正在读取个人文件与有效订阅…";
					}
					try
					{
						TaskAwaiter _u__ = default;
						switch (num)
						{
						default:
							__7__wrap2 = 0;
							goto case 0;
						case 0:
						case 1:
						case 2:
						{
							try
							{
								TaskAwaiter<pKPWErf6DBoy2hpuUB59> _u__3 = default;
								TaskAwaiter<McpCloudSyncService.SyncResult> _u__2 = default;
								McpCloudSyncService.SyncResult result;
								pKPWErf6DBoy2hpuUB59 result2;
								switch (num)
								{
								default:
									__8__1 = (__c__DisplayClass18_1)new __c__DisplayClass18_1();
									__8__1.CS___8__locals1 = __8__2;
									_api_5__4 = AppShell.Api;
									_u__3 = _api_5__4.hMv8wl3dF8(__8__1.CS___8__locals1.cancellation.Token).GetAwaiter();
									if (!_u__3.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__3;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<pKPWErf6DBoy2hpuUB59>, _CloudSync_Click_d__18>(ref _u__3, ref this);
										return;
									}
									goto IL_0195;
								case 0:
									_u__3 = __u__1;
									__u__1 = default(TaskAwaiter<pKPWErf6DBoy2hpuUB59>);
									num = (__1__state = -1);
									goto IL_0195;
								case 1:
									_u__2 = __u__2;
									__u__2 = default(TaskAwaiter<McpCloudSyncService.SyncResult>);
									num = (__1__state = -1);
									goto IL_026f;
								case 2:
									{
										_u__ = __u__3;
										__u__3 = default(TaskAwaiter);
										num = (__1__state = -1);
										break;
									}
									IL_026f:
									result = _u__2.GetResult();
									_result_5__5 = result;
									mcpStudioPage.FileSearchBox.Text = string.Empty;
									_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 2);
										__u__3 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CloudSync_Click_d__18>(ref _u__, ref this);
										return;
									}
									break;
									IL_0195:
									result2 = _u__3.GetResult();
									__8__1.response = result2;
									__8__1.service = (McpCloudSyncService)new McpCloudSyncService((Func<long, long, int, CancellationToken, global::System.Threading.Tasks.Task<blITQ5f6ZD0ur9oMSjQ5>>)_api_5__4.c8H8eBAI0O);
									__8__1.progress = new Progress<string>((Action<string>)__8__1.CS___8__locals1._CloudSync_Click_b__0);
									_u__2 = global::System.Threading.Tasks.Task.Run<McpCloudSyncService.SyncResult>((Func<global::System.Threading.Tasks.Task<McpCloudSyncService.SyncResult>>)__8__1._CloudSync_Click_b__1, __8__1.CS___8__locals1.cancellation.Token).GetAwaiter();
									if (!_u__2.IsCompleted)
									{
										num = (__1__state = 1);
										__u__2 = _u__2;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpCloudSyncService.SyncResult>, _CloudSync_Click_d__18>(ref _u__2, ref this);
										return;
									}
									goto IL_026f;
								}
								_u__.GetResult();
								mcpStudioPage.CloudStatusText.Text = ((__8__1.response.Items.Count == 0) ? "云端库为空：请在网页市场上传文件或订阅商品，然后再次同步。" : $"云端库状态：已下载 {_result_5__5.Downloaded} 个，已有 {_result_5__5.Existing} 个，失败 {_result_5__5.Errors.Count} 个；下载的文件已加入未注入列表。");
								if (_result_5__5.Errors.Count > 0)
								{
									((UIElement)mcpStudioPage.CloudErrorsPanel).Visibility = (Visibility)0;
									mcpStudioPage.CloudErrorsText.Text = string.Join(Environment.NewLine, (global::System.Collections.Generic.IEnumerable<string>)_result_5__5.Errors);
									mcpStudioPage.Notice("部分 MCP 文件同步失败，可展开详情查看原因后重试。", (InfoBarSeverity)2);
								}
								__8__1 = null;
								_api_5__4 = null;
								_result_5__5 = null;
							}
							catch (OperationCanceledException ex)
							{
								OperationCanceledException _7__wrap = ex;
								__7__wrap1 = _7__wrap;
								__7__wrap2 = 1;
							}
							catch (global::System.Exception _7__wrap2)
							{
								__7__wrap1 = _7__wrap2;
								__7__wrap2 = 2;
							}
							int num2 = __7__wrap2;
							if (num2 != 1)
							{
								if (num2 != 2)
								{
									break;
								}
								global::System.Exception ex2 = (global::System.Exception)__7__wrap1;
								cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "CloudSync_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.CloudSync.cs", 56);
								mcpStudioPage.CloudStatusText.Text = "云端库同步失败：" + ex2.Message;
								mcpStudioPage.Notice(mcpStudioPage.CloudStatusText.Text, (InfoBarSeverity)3);
								_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 4);
									__u__3 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CloudSync_Click_d__18>(ref _u__, ref this);
									return;
								}
								goto IL_0570;
							}
							mcpStudioPage.CloudStatusText.Text = "云端库同步已取消；已完成的文件保留在本地。";
							_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 3);
								__u__3 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CloudSync_Click_d__18>(ref _u__, ref this);
								return;
							}
							goto IL_04b7;
						}
						case 3:
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_04b7;
						case 4:
							{
								_u__ = __u__3;
								__u__3 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_0570;
							}
							IL_0570:
							_u__.GetResult();
							break;
							IL_04b7:
							_u__.GetResult();
							break;
						}
						__7__wrap1 = null;
					}
					finally
					{
						if (num < 0)
						{
							mcpStudioPage._cloudSyncCancellation = null;
							((Control)mcpStudioPage.CloudSyncButton).IsEnabled = true;
							((UIElement)mcpStudioPage.CancelSyncButton).Visibility = (Visibility)1;
							((UIElement)mcpStudioPage.CloudProgress).Visibility = (Visibility)1;
						}
					}
				}
				finally
				{
					if (num < 0 && __8__2.cancellation != null)
					{
						((global::System.IDisposable)__8__2.cancellation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _FileDetails_Click_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public McpStudioPage __4__this;

		private __c__DisplayClass26_0_2 __8__1;

		private TaskAwaiter<string> __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0227: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Expected O, but got Unknown
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_007a;
				}
				__8__1 = (__c__DisplayClass26_0_2)new __c__DisplayClass26_0_2();
				object obj = sender;
				object obj2 = ((obj is FrameworkElement) ? obj : null);
				object obj3 = ((obj2 != null) ? ((FrameworkElement)obj2).Tag : null);
				__8__1.file = obj3 as McpLocalFile;
				if (__8__1.file != null && mcpStudioPage.CanChangeFiles())
				{
					mcpStudioPage._fileOperation = true;
					goto IL_007a;
				}
				goto end_IL_0011;
				IL_007a:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					TaskAwaiter<string> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<ContentDialogResult>);
							num = (__1__state = -1);
							goto IL_02a2;
						}
						_u__2 = global::System.Threading.Tasks.Task.Run<string>((Func<string>)__8__1._FileDetails_Click_b__0).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _FileDetails_Click_d__26>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
					}
					string result = _u__2.GetResult();
					string text = $"{__8__1.file.FileName}\n\n大小：{__8__1.file.SizeText}\n修改时间：{__8__1.file.LastWriteTime:yyyy-MM-dd HH:mm:ss}\n入口：{__8__1.file.EntryText}\n状态：{__8__1.file.StatusText}\n\n路径：{__8__1.file.FilePath}\n\nSHA-256：{result}";
					_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
					{
						XamlRoot = ((UIElement)mcpStudioPage).XamlRoot,
						Title = "MCP 文件详情",
						CloseButtonText = "关闭",
						Content = (object)new TextBox
						{
							Text = text,
							IsReadOnly = true,
							TextWrapping = (TextWrapping)2,
							AcceptsReturn = true,
							MaxHeight = 420.0
						}
					}.ShowAsync());
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _FileDetails_Click_d__26>(ref _u__, ref this);
						return;
					}
					goto IL_02a2;
					IL_02a2:
					_u__.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "FileDetails_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Files.cs", 86);
					mcpStudioPage.Notice("读取详情失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._fileOperation = false;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ImportBuildResult_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter<McpLocalFile?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0123: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0047;
				}
				if (mcpStudioPage._lastBuild != null && mcpStudioPage.CanChangeFiles())
				{
					mcpStudioPage._fileOperation = true;
					((Control)mcpStudioPage.ImportBuildButton).IsEnabled = false;
					goto IL_0047;
				}
				goto end_IL_0011;
				IL_0047:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<McpLocalFile> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_0139;
						}
						_u__2 = mcpStudioPage._library.ImportAsync(mcpStudioPage._lastBuild.OutputPath).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpLocalFile>, _ImportBuildResult_Click_d__15>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<McpLocalFile>);
						num = (__1__state = -1);
					}
					if (_u__2.GetResult() == null)
					{
						throw new FileNotFoundException("构建产物已不存在");
					}
					mcpStudioPage.FileSearchBox.Text = string.Empty;
					_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ImportBuildResult_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_0139;
					IL_0139:
					_u__.GetResult();
					mcpStudioPage.WorkspaceTabs.SelectedIndex = 0;
					mcpStudioPage.Notice("构建产物已加入文件库。", (InfoBarSeverity)1);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "ImportBuildResult_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 175);
					mcpStudioPage.Notice("导入构建产物失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._fileOperation = false;
						((Control)mcpStudioPage.ImportBuildButton).IsEnabled = true;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Import_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private McpLocalFile _file_5__2;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter<McpLocalFile?> __u__2;

		private TaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_003c;
				}
				if (mcpStudioPage.CanChangeFiles())
				{
					mcpStudioPage._fileOperation = true;
					((Control)mcpStudioPage.ImportButton).IsEnabled = false;
					goto IL_003c;
				}
				goto end_IL_0011;
				IL_003c:
				try
				{
					TaskAwaiter<string> _u__3 = default;
					TaskAwaiter<McpLocalFile> _u__2 = default;
					TaskAwaiter _u__ = default;
					McpLocalFile result;
					string result2;
					switch (num)
					{
					default:
						_u__3 = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)0, new string[1] { ".mcp" }, "选择 MCP 文件").GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _Import_Click_d__21>(ref _u__3, ref this);
							return;
						}
						goto IL_00bd;
					case 0:
						_u__3 = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
						goto IL_00bd;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<McpLocalFile>);
						num = (__1__state = -1);
						goto IL_0130;
					case 2:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0130:
						result = _u__2.GetResult();
						_file_5__2 = result ?? throw new FileNotFoundException("选择的文件已不存在");
						mcpStudioPage.FileSearchBox.Text = string.Empty;
						_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Import_Click_d__21>(ref _u__, ref this);
							return;
						}
						break;
						IL_00bd:
						result2 = _u__3.GetResult();
						if (result2 != null)
						{
							_u__2 = mcpStudioPage._library.ImportAsync(result2).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpLocalFile>, _Import_Click_d__21>(ref _u__2, ref this);
								return;
							}
							goto IL_0130;
						}
						goto end_IL_003c;
					}
					_u__.GetResult();
					mcpStudioPage.Notice(_file_5__2.FileName + " 已加入文件库。", (InfoBarSeverity)1);
					_file_5__2 = null;
					end_IL_003c:;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Import_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Files.cs", 39);
					mcpStudioPage.Notice("添加 MCP 文件失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._fileOperation = false;
						((Control)mcpStudioPage.ImportButton).IsEnabled = true;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Inject_Click_d__55 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		public object sender;

		private __c__DisplayClass55_0 __8__1;

		private __c__DisplayClass55_1 __8__2;

		private TaskAwaiter<Dictionary<int, global::System.DateTime?>> __u__1;

		private TaskAwaiter<McpInjectionService.Submission> __u__2;

		private TaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_025b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0171;
				}
				__8__1 = (__c__DisplayClass55_0)new __c__DisplayClass55_0();
				__8__1.__4__this = __4__this;
				object obj = sender;
				object obj2 = ((obj is FrameworkElement) ? obj : null);
				object obj3 = ((obj2 != null) ? ((FrameworkElement)obj2).Tag : null);
				__8__1.file = obj3 as McpLocalFile;
				if (__8__1.file != null)
				{
					if (mcpStudioPage._injecting || mcpStudioPage._fileOperation || mcpStudioPage._cloudSyncCancellation != null)
					{
						mcpStudioPage.Notice("文件操作正在进行，请稍后再试。", (InfoBarSeverity)0);
					}
					else
					{
						__8__1.entry = (string.IsNullOrWhiteSpace(__8__1.file.EntryModule) ? mcpStudioPage.EntryModuleBox.Text.Trim() : __8__1.file.EntryModule);
						if (!string.IsNullOrWhiteSpace(mcpStudioPage.ManagerAddressBox.Text) && !string.IsNullOrWhiteSpace(__8__1.entry))
						{
							__8__1.address = mcpStudioPage.ManagerAddressBox.Text;
							mcpStudioPage._injecting = true;
							((Control)mcpStudioPage.PendingList).IsEnabled = false;
							((Control)mcpStudioPage.InjectedList).IsEnabled = false;
							goto IL_0171;
						}
						mcpStudioPage.InjectionSettings.IsExpanded = true;
						mcpStudioPage.Notice("请先填写管理器地址；未识别入口的文件还需要填写备用入口。", (InfoBarSeverity)2);
					}
				}
				goto end_IL_0011;
				IL_0171:
				try
				{
					TaskAwaiter<Dictionary<int, global::System.DateTime?>> _u__3;
					TaskAwaiter<McpInjectionService.Submission> _u__2 = default;
					TaskAwaiter _u__ = default;
					McpInjectionService.Submission result;
					string[] array;
					switch (num)
					{
					default:
						__8__2 = (__c__DisplayClass55_1)new __c__DisplayClass55_1();
						_u__3 = global::System.Threading.Tasks.Task.Run<Dictionary<int, global::System.DateTime?>>((Func<Dictionary<int, global::System.DateTime?>>)ReadGameSessions).GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<int, global::System.DateTime?>>, _Inject_Click_d__55>(ref _u__3, ref this);
							return;
						}
						goto IL_0202;
					case 0:
						_u__3 = __u__1;
						__u__1 = default(TaskAwaiter<Dictionary<int, global::System.DateTime?>>);
						num = (__1__state = -1);
						goto IL_0202;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<McpInjectionService.Submission>);
						num = (__1__state = -1);
						goto IL_02af;
					case 2:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0202:
						if (_u__3.GetResult().Count != 1)
						{
							throw new InvalidOperationException("请先启动并仅保留一个目标游戏进程");
						}
						mcpStudioPage.Notice("正在提交 " + __8__1.file.FileName + "…", (InfoBarSeverity)0);
						_u__2 = global::System.Threading.Tasks.Task.Run<McpInjectionService.Submission>((Func<global::System.Threading.Tasks.Task<McpInjectionService.Submission>>)__8__1._Inject_Click_b__0).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpInjectionService.Submission>, _Inject_Click_d__55>(ref _u__2, ref this);
							return;
						}
						goto IL_02af;
						IL_02af:
						result = _u__2.GetResult();
						__8__2.submission = result;
						array = Enumerable.ToArray<string>(Enumerable.Select<KeyValuePair<string, McpInjectionService.Submission>, string>(Enumerable.Where<KeyValuePair<string, McpInjectionService.Submission>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, McpInjectionService.Submission>>)mcpStudioPage._submissions, (Func<KeyValuePair<string, McpInjectionService.Submission>, bool>)__8__2._Inject_Click_b__1), (Func<KeyValuePair<string, McpInjectionService.Submission>, string>)__c_11.__9._Inject_Click_b__55_2));
						foreach (string text in array)
						{
							mcpStudioPage._submissions.Remove(text);
							mcpStudioPage._injected.Remove(text);
						}
						mcpStudioPage._submissions[__8__1.file.FilePath] = __8__2.submission;
						mcpStudioPage._injected.Add(__8__1.file.FilePath);
						_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Inject_Click_d__55>(ref _u__, ref this);
							return;
						}
						break;
					}
					_u__.GetResult();
					mcpStudioPage.Notice($"已向进程 {__8__2.submission.ProcessId} 发送 {__8__2.submission.EntryModule}，请在游戏中确认加载结果。", (InfoBarSeverity)1);
					__8__2 = null;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Inject_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.xaml.cs", 178);
					mcpStudioPage.Notice("MCP 提交失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._injecting = false;
						((Control)mcpStudioPage.PendingList).IsEnabled = true;
						((Control)mcpStudioPage.InjectedList).IsEnabled = true;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _InstallBuildEnvironment_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private CancellationTokenSource _cancellation_5__2;

		private TextBox __7__wrap2;

		private TaskAwaiter<string> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0034;
				}
				if (mcpStudioPage._buildCancellation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_0034;
				}
				goto end_IL_0011;
				IL_0034:
				try
				{
					if ((uint)num > 1u)
					{
						mcpStudioPage._buildCancellation = _cancellation_5__2;
						mcpStudioPage.SetBuildBusy(busy: true);
					}
					try
					{
						TaskAwaiter _u__ = default;
						TaskAwaiter<string> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_0166;
							}
							__7__wrap2 = mcpStudioPage.PythonPathBox;
							_u__2 = mcpStudioPage._buildEnvironment.EnsureInstalledAsync((IProgress<string>?)(object)new Progress<string>((Action<string>)mcpStudioPage.BuildMessage), _cancellation_5__2.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _InstallBuildEnvironment_Click_d__10>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<string>);
							num = (__1__state = -1);
						}
						string result = _u__2.GetResult();
						__7__wrap2.Text = result;
						__7__wrap2 = null;
						mcpStudioPage.UpdateEnvironmentStatus();
						mcpStudioPage.BuildMessage("内置构建环境已就绪。");
						_u__ = mcpStudioPage.SaveBuildSettingsAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InstallBuildEnvironment_Click_d__10>(ref _u__, ref this);
							return;
						}
						goto IL_0166;
						IL_0166:
						_u__.GetResult();
					}
					catch (OperationCanceledException)
					{
						mcpStudioPage.BuildMessage("环境部署已取消。");
					}
					catch (global::System.Exception ex2)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "InstallBuildEnvironment_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 89);
						mcpStudioPage.BuildMessage("环境部署失败：" + ex2.Message);
						mcpStudioPage.Notice(mcpStudioPage.BuildStatusText.Text, (InfoBarSeverity)3);
					}
					finally
					{
						if (num < 0)
						{
							mcpStudioPage._buildCancellation = null;
							mcpStudioPage.SetBuildBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__2 != null)
					{
						((global::System.IDisposable)_cancellation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_cancellation_5__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadBuildSettingsAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter<McpWorkspaceSettings> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_002f;
				}
				if (!mcpStudioPage._settingsLoaded)
				{
					mcpStudioPage._settingsLoaded = true;
					goto IL_002f;
				}
				goto end_IL_0011;
				IL_002f:
				try
				{
					TaskAwaiter<McpWorkspaceSettings> _u__ = default;
					if (num != 0)
					{
						_u__ = McpWorkspaceSettings.LoadAsync(mcpStudioPage._library.RootPath).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<McpWorkspaceSettings>, _LoadBuildSettingsAsync_d__4>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<McpWorkspaceSettings>);
						num = (__1__state = -1);
					}
					McpWorkspaceSettings result = _u__.GetResult();
					mcpStudioPage.SourceDirectoryBox.Text = result.SourceDirectory ?? string.Empty;
					mcpStudioPage.OutputPathBox.Text = result.OutputPath ?? string.Empty;
					mcpStudioPage.PackageIdBox.Text = result.PackageId ?? string.Empty;
					if (File.Exists(result.PythonPath))
					{
						mcpStudioPage.PythonPathBox.Text = result.PythonPath;
					}
					mcpStudioPage.UpdateEnvironmentStatus();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "LoadBuildSettingsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 38);
					mcpStudioPage.Notice("无法恢复上次构建设置：" + ex.Message, (InfoBarSeverity)2);
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenBuildFolder_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0089;
				}
				if (mcpStudioPage._lastBuild != null)
				{
					_u__ = mcpStudioPage.OpenFolderAsync(Path.GetDirectoryName(mcpStudioPage._lastBuild.OutputPath)).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenBuildFolder_Click_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_0089;
				}
				goto end_IL_0011;
				IL_0089:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenDocs_Click_d__58 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = mcpStudioPage.OpenUrlAsync("https://www.chronal.my/docs/readme").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenDocs_Click_d__58>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenFileLocation_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a2;
				}
				object obj = sender;
				object obj2 = ((obj is FrameworkElement) ? obj : null);
				if (((obj2 != null) ? ((FrameworkElement)obj2).Tag : null) is McpLocalFile mcpLocalFile)
				{
					_u__ = mcpStudioPage.OpenFolderAsync(Path.GetDirectoryName(mcpLocalFile.FilePath)).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenFileLocation_Click_d__24>(ref _u__, ref this);
						return;
					}
					goto IL_00a2;
				}
				goto end_IL_0011;
				IL_00a2:
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenFolderAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string path;

		public McpStudioPage __4__this;

		private TaskAwaiter<StorageFolder> __u__1;

		private TaskAwaiter<bool> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<bool> _u__ = default;
					TaskAwaiter<StorageFolder> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							goto IL_00e8;
						}
						Directory.CreateDirectory(path);
						_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<StorageFolder>(StorageFolder.GetFolderFromPathAsync(path));
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<StorageFolder>, _OpenFolderAsync_d__22>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<StorageFolder>);
						num = (__1__state = -1);
					}
					_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchFolderAsync((IStorageFolder)(object)_u__2.GetResult()));
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenFolderAsync_d__22>(ref _u__, ref this);
						return;
					}
					goto IL_00e8;
					IL_00e8:
					if (!_u__.GetResult())
					{
						throw new IOException("资源管理器未能打开文件夹");
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "OpenFolderAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Files.cs", 51);
					mcpStudioPage.Notice("打开文件夹失败：" + ex.Message, (InfoBarSeverity)3);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenLibraryFolder_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = mcpStudioPage.OpenFolderAsync(mcpStudioPage._library.PendingPath).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenLibraryFolder_Click_d__23>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenMarket_Click_d__57 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = mcpStudioPage.OpenUrlAsync("https://dash.chronal.my/mcp-market").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenMarket_Click_d__57>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenUrlAsync_d__56 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string value;

		public McpStudioPage __4__this;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				try
				{
					bool flag;
					TaskAwaiter<bool> _u__ = default;
					if (num != 0)
					{
						Uri val = default(Uri);
						flag = !Uri.TryCreate(value, (UriKind)1, out val);
						if (flag)
						{
							goto IL_0097;
						}
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(val));
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenUrlAsync_d__56>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					flag = !_u__.GetResult();
					goto IL_0097;
					IL_0097:
					if (flag)
					{
						throw new InvalidOperationException("没有可用的浏览器");
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "OpenUrlAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.xaml.cs", 194);
					mcpStudioPage.Notice("打开网页失败：" + ex.Message, (InfoBarSeverity)3);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Page_Loaded_d__47 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00d3;
					}
					_u__ = mcpStudioPage.LoadBuildSettingsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Page_Loaded_d__47>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
				_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Page_Loaded_d__47>(ref _u__, ref this);
					return;
				}
				goto IL_00d3;
				IL_00d3:
				_u__.GetResult();
				mcpStudioPage._gameTimer.Start();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _Page_Unloaded_d__48 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					mcpStudioPage._gameTimer.Stop();
					mcpStudioPage._noticeTimer.Stop();
					mcpStudioPage.OperationNotice.IsOpen = false;
					CancellationTokenSource? cloudSyncCancellation = mcpStudioPage._cloudSyncCancellation;
					if (cloudSyncCancellation != null)
					{
						cloudSyncCancellation.Cancel();
					}
					CancellationTokenSource? buildCancellation = mcpStudioPage._buildCancellation;
					if (buildCancellation != null)
					{
						buildCancellation.Cancel();
					}
					_u__ = mcpStudioPage.SaveBuildSettingsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Page_Unloaded_d__48>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshAsync_d__51 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private __c__DisplayClass51_0 __8__1;

		private TaskAwaiter<Dictionary<int, global::System.DateTime?>> __u__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0314: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0030;
				}
				if (!mcpStudioPage._refreshing)
				{
					mcpStudioPage._refreshing = true;
					goto IL_0030;
				}
				goto end_IL_0011;
				IL_0030:
				try
				{
					TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>> _u__;
					TaskAwaiter<Dictionary<int, global::System.DateTime?>> _u__2;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>);
							num = (__1__state = -1);
							goto IL_034b;
						}
						__8__1 = (__c__DisplayClass51_0)new __c__DisplayClass51_0();
						_u__2 = global::System.Threading.Tasks.Task.Run<Dictionary<int, global::System.DateTime?>>((Func<Dictionary<int, global::System.DateTime?>>)ReadGameSessions).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Dictionary<int, global::System.DateTime?>>, _RefreshAsync_d__51>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<Dictionary<int, global::System.DateTime?>>);
						num = (__1__state = -1);
					}
					Dictionary<int, global::System.DateTime?> result = _u__2.GetResult();
					__8__1.games = result;
					string text = string.Join(";", Enumerable.Select<KeyValuePair<int, global::System.DateTime?>, string>((global::System.Collections.Generic.IEnumerable<KeyValuePair<int, global::System.DateTime?>>)Enumerable.OrderBy<KeyValuePair<int, global::System.DateTime?>, int>((global::System.Collections.Generic.IEnumerable<KeyValuePair<int, global::System.DateTime?>>)__8__1.games, (Func<KeyValuePair<int, global::System.DateTime?>, int>)__c_11.__9._RefreshAsync_b__51_0), (Func<KeyValuePair<int, global::System.DateTime?>, string>)__c_11.__9._RefreshAsync_b__51_1));
					if (mcpStudioPage._gameSignature != null && mcpStudioPage._gameSignature != text)
					{
						mcpStudioPage.ManagerAddressBox.Text = string.Empty;
					}
					mcpStudioPage._gameSignature = text;
					string[] array = Enumerable.ToArray<string>(Enumerable.Select<KeyValuePair<string, McpInjectionService.Submission>, string>(Enumerable.Where<KeyValuePair<string, McpInjectionService.Submission>>((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, McpInjectionService.Submission>>)mcpStudioPage._submissions, (Func<KeyValuePair<string, McpInjectionService.Submission>, bool>)__8__1._RefreshAsync_b__2), (Func<KeyValuePair<string, McpInjectionService.Submission>, string>)__c_11.__9._RefreshAsync_b__51_3));
					string[] array2 = array;
					foreach (string text2 in array2)
					{
						mcpStudioPage._submissions.Remove(text2);
						mcpStudioPage._injected.Remove(text2);
					}
					if (array.Length != 0)
					{
						mcpStudioPage.ManagerAddressBox.Text = string.Empty;
					}
					TextBlock gameStatusText = mcpStudioPage.GameStatusText;
					gameStatusText.Text = __8__1.games.Count switch
					{
						0 => "游戏未启动 · 请先进入启用 MCP 的服务器", 
						1 => $"已发现游戏进程 {Enumerable.First<int>((global::System.Collections.Generic.IEnumerable<int>)__8__1.games.Keys)} · 脚本系统需在游戏中确认", 
						_ => $"发现 {__8__1.games.Count} 个游戏进程 · 请仅保留一个目标游戏", 
					};
					_u__ = mcpStudioPage._library.ListAsync((ISet<string>)(object)new HashSet<string>((global::System.Collections.Generic.IEnumerable<string>)mcpStudioPage._injected, (IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase)).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<McpLocalFile>>, _RefreshAsync_d__51>(ref _u__, ref this);
						return;
					}
					goto IL_034b;
					IL_034b:
					global::System.Collections.Generic.IReadOnlyList<McpLocalFile> result2 = _u__.GetResult();
					bool num2 = !Enumerable.SequenceEqual<ValueTuple<string, long, global::System.DateTime, bool, string>>(Enumerable.Select<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>>((global::System.Collections.Generic.IEnumerable<McpLocalFile>)mcpStudioPage._files, (Func<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>>)__c_11.__9._RefreshAsync_b__51_4), Enumerable.Select<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>>((global::System.Collections.Generic.IEnumerable<McpLocalFile>)result2, (Func<McpLocalFile, ValueTuple<string, long, global::System.DateTime, bool, string>>)__c_11.__9._RefreshAsync_b__51_5));
					mcpStudioPage._files = result2;
					if (num2)
					{
						mcpStudioPage.ApplyFileFilter();
					}
					__8__1 = null;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RefreshAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.xaml.cs", 121);
					mcpStudioPage.Notice("读取 MCP 文件失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._refreshing = false;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshLibrary_Click_d__54 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshLibrary_Click_d__54>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
				}
				_u__.GetResult();
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RemoveFile_Click_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public McpStudioPage __4__this;

		private McpLocalFile _file_5__2;

		private TaskAwaiter<ContentDialogResult> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Invalid comparison between Unknown and I4
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0065;
				}
				object obj = sender;
				object obj2 = ((obj is FrameworkElement) ? obj : null);
				object obj3 = ((obj2 != null) ? ((FrameworkElement)obj2).Tag : null);
				_file_5__2 = obj3 as McpLocalFile;
				if (_file_5__2 != null && mcpStudioPage.CanChangeFiles())
				{
					mcpStudioPage._fileOperation = true;
					goto IL_0065;
				}
				goto end_IL_0011;
				IL_0065:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__2 = default;
					TaskAwaiter _u__ = default;
					switch (num)
					{
					default:
						_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
						{
							XamlRoot = ((UIElement)mcpStudioPage).XamlRoot,
							Title = "移除本地 MCP",
							PrimaryButtonText = "移除",
							CloseButtonText = "取消",
							DefaultButton = (ContentDialogButton)3,
							Content = "将删除本地副本：" + _file_5__2.FileName + "\n\n云端文件与订阅不受影响。已经发送到游戏的模块不会热卸载，将持续到游戏退出。"
						}.ShowAsync());
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _RemoveFile_Click_d__27>(ref _u__2, ref this);
							return;
						}
						goto IL_0126;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
						goto IL_0126;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_019d;
					case 2:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_019d:
						_u__.GetResult();
						_u__ = mcpStudioPage.RefreshAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RemoveFile_Click_d__27>(ref _u__, ref this);
							return;
						}
						break;
						IL_0126:
						if ((int)_u__2.GetResult() == 1)
						{
							_u__ = mcpStudioPage._library.RemoveAsync(_file_5__2).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RemoveFile_Click_d__27>(ref _u__, ref this);
								return;
							}
							goto IL_019d;
						}
						goto end_IL_0065;
					}
					_u__.GetResult();
					mcpStudioPage.Notice("本地文件已移除。", (InfoBarSeverity)1);
					end_IL_0065:;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RemoveFile_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Files.cs", 106);
					mcpStudioPage.Notice("移除失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						mcpStudioPage._fileOperation = false;
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_file_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_file_5__2 = null;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SaveBuildSettingsAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				if (num == 0 || mcpStudioPage._settingsLoaded)
				{
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = ((McpWorkspaceSettings)new McpWorkspaceSettings
							{
								SourceDirectory = mcpStudioPage.SourceDirectoryBox.Text,
								OutputPath = mcpStudioPage.OutputPathBox.Text,
								PackageId = mcpStudioPage.PackageIdBox.Text,
								PythonPath = mcpStudioPage.PythonPathBox.Text
							}).SaveAsync(mcpStudioPage._library.RootPath).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SaveBuildSettingsAsync_d__5>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
						}
						_u__.GetResult();
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SaveBuildSettingsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 48);
						mcpStudioPage.Notice("无法保存构建设置：" + ex.Message, (InfoBarSeverity)2);
					}
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SelectOutput_Click_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						_u__ = DesktopFilePicker.PickSaveFileAsync(AppShell.WindowHandle, (PickerLocationId)0, "新建 MCP 文件", new DesktopFileTypeChoice[1] { (DesktopFileTypeChoice)new DesktopFileTypeChoice("MCP 文件", (global::System.Collections.Generic.IReadOnlyList<string>)new string[1] { ".mcp" }) }, "选择 MCP 输出路径").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _SelectOutput_Click_d__13>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
					}
					string result = _u__.GetResult();
					if (result != null)
					{
						mcpStudioPage.OutputPathBox.Text = result;
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SelectOutput_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 122);
					mcpStudioPage.Notice("选择输出失败：" + ex.Message, (InfoBarSeverity)3);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SelectPython_Click_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						_u__ = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)0, new string[1] { ".exe" }, "选择 Python 2.7 x64").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _SelectPython_Click_d__11>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
					}
					string result = _u__.GetResult();
					if (result != null)
					{
						mcpStudioPage.PythonPathBox.Text = result;
						mcpStudioPage.UpdateEnvironmentStatus();
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SelectPython_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 102);
					mcpStudioPage.Notice("选择解释器失败：" + ex.Message, (InfoBarSeverity)3);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SelectSourceDirectory_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public McpStudioPage __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			McpStudioPage mcpStudioPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						_u__ = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)0, "选择 MCP 源码目录").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _SelectSourceDirectory_Click_d__12>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
					}
					string result = _u__.GetResult();
					if (result != null)
					{
						mcpStudioPage.SourceDirectoryBox.Text = result;
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SelectSourceDirectory_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Build.cs", 112);
					mcpStudioPage.Notice("选择源码失败：" + ex.Message, (InfoBarSeverity)3);
				}
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			__t__builder.SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private CancellationTokenSource? _buildCancellation;

	private McpBuildResult? _lastBuild;

	private bool _settingsLoaded;

	private CancellationTokenSource? _cloudSyncCancellation;

	private const string MarketUrl = "https://dash.chronal.my/mcp-market";

	private const string DocsUrl = "https://www.chronal.my/docs/readme";

	private readonly McpLocalLibraryService _library;

	private readonly McpInjectionService _injector;

	private readonly McpBuilderService _builder;

	private readonly McpBuildEnvironmentService _buildEnvironment;

	private readonly HashSet<string> _injected;

	private readonly Dictionary<string, McpInjectionService.Submission> _submissions;

	private readonly ObservableCollection<McpLocalFile> _pending;

	private readonly ObservableCollection<McpLocalFile> _injectedFiles;

	private readonly DispatcherTimer _gameTimer;

	private readonly DispatcherTimer _noticeTimer;

	private global::System.Collections.Generic.IReadOnlyList<McpLocalFile> _files;

	private bool _ready;

	private bool _refreshing;

	private bool _fileOperation;

	private bool _injecting;

	private string? _gameSignature;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar OperationNotice;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TabView WorkspaceTabs;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private UserControl BuildInputs;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border BuildResultPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox BuildLogBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BuildResultText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ImportBuildButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar BuildProgress;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BuildStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button BuildButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelBuildButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PackageIdBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox BuildEntryModuleBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox OutputPathBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox SourceDirectoryBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EnvironmentStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PythonPathBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox FileSearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Expander InjectionSettings;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock InjectedTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock InjectedEmpty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView InjectedList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PendingTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border PendingEmpty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView PendingList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PendingEmptyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock GameStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ManagerAddressBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox EntryModuleBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar CloudProgress;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CloudStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Expander CloudErrorsPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox CloudErrorsText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppBarButton ImportButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppBarButton CloudSyncButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private AppBarButton CancelSyncButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateEnvironmentStatus()
	{
		EnvironmentStatusText.Text = ((!string.IsNullOrWhiteSpace(PythonPathBox.Text) && File.Exists(PythonPathBox.Text)) ? "已选择 Python · 构建时校验版本与架构" : "尚未部署 · 首次构建时自动部署内置环境");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadBuildSettingsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadBuildSettingsAsync_d__4 loadBuildSettingsAsync_d__ = default(_LoadBuildSettingsAsync_d__4);
		loadBuildSettingsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadBuildSettingsAsync_d__.__4__this = this;
		loadBuildSettingsAsync_d__.__1__state = -1;
		loadBuildSettingsAsync_d__.__t__builder.Start<_LoadBuildSettingsAsync_d__4>(ref loadBuildSettingsAsync_d__);
		return loadBuildSettingsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SaveBuildSettingsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SaveBuildSettingsAsync_d__5 saveBuildSettingsAsync_d__ = default(_SaveBuildSettingsAsync_d__5);
		saveBuildSettingsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		saveBuildSettingsAsync_d__.__4__this = this;
		saveBuildSettingsAsync_d__.__1__state = -1;
		saveBuildSettingsAsync_d__.__t__builder.Start<_SaveBuildSettingsAsync_d__5>(ref saveBuildSettingsAsync_d__);
		return saveBuildSettingsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PackageId_TextChanged(object sender, TextChangedEventArgs e)
	{
		if (BuildEntryModuleBox != null)
		{
			BuildEntryModuleBox.Text = (string.IsNullOrWhiteSpace(PackageIdBox.Text) ? string.Empty : (PackageIdBox.Text.Trim() + ".modMain"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBuildBusy(bool busy)
	{
		((Control)BuildInputs).IsEnabled = !busy;
		((Control)BuildButton).IsEnabled = !busy;
		((Control)ImportBuildButton).IsEnabled = !busy;
		((UIElement)CancelBuildButton).Visibility = ((!busy) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)BuildProgress).Visibility = ((!busy) ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelBuild_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? buildCancellation = _buildCancellation;
		if (buildCancellation != null)
		{
			buildCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BuildMessage(string message)
	{
		BuildStatusText.Text = message;
		BuildLogBox.Text += $"[{(global::System.DateTime.Now):HH:mm:ss}] {message}\n";
		if (BuildLogBox.Text.Length > 30000)
		{
			TextBox buildLogBox = BuildLogBox;
			string text = BuildLogBox.Text;
			buildLogBox.Text = text.Substring(text.Length - 30000);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InstallBuildEnvironment_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InstallBuildEnvironment_Click_d__10 installBuildEnvironment_Click_d__ = default(_InstallBuildEnvironment_Click_d__10);
		installBuildEnvironment_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		installBuildEnvironment_Click_d__.__4__this = this;
		installBuildEnvironment_Click_d__.__1__state = -1;
		installBuildEnvironment_Click_d__.__t__builder.Start<_InstallBuildEnvironment_Click_d__10>(ref installBuildEnvironment_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SelectPython_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SelectPython_Click_d__11 selectPython_Click_d__ = default(_SelectPython_Click_d__11);
		selectPython_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		selectPython_Click_d__.__4__this = this;
		selectPython_Click_d__.__1__state = -1;
		selectPython_Click_d__.__t__builder.Start<_SelectPython_Click_d__11>(ref selectPython_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SelectSourceDirectory_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SelectSourceDirectory_Click_d__12 selectSourceDirectory_Click_d__ = default(_SelectSourceDirectory_Click_d__12);
		selectSourceDirectory_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		selectSourceDirectory_Click_d__.__4__this = this;
		selectSourceDirectory_Click_d__.__1__state = -1;
		selectSourceDirectory_Click_d__.__t__builder.Start<_SelectSourceDirectory_Click_d__12>(ref selectSourceDirectory_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SelectOutput_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SelectOutput_Click_d__13 selectOutput_Click_d__ = default(_SelectOutput_Click_d__13);
		selectOutput_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		selectOutput_Click_d__.__4__this = this;
		selectOutput_Click_d__.__1__state = -1;
		selectOutput_Click_d__.__t__builder.Start<_SelectOutput_Click_d__13>(ref selectOutput_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BuildMcp_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BuildMcp_Click_d__14 buildMcp_Click_d__ = default(_BuildMcp_Click_d__14);
		buildMcp_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		buildMcp_Click_d__.__4__this = this;
		buildMcp_Click_d__.__1__state = -1;
		buildMcp_Click_d__.__t__builder.Start<_BuildMcp_Click_d__14>(ref buildMcp_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ImportBuildResult_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ImportBuildResult_Click_d__15 importBuildResult_Click_d__ = default(_ImportBuildResult_Click_d__15);
		importBuildResult_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		importBuildResult_Click_d__.__4__this = this;
		importBuildResult_Click_d__.__1__state = -1;
		importBuildResult_Click_d__.__t__builder.Start<_ImportBuildResult_Click_d__15>(ref importBuildResult_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenBuildFolder_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenBuildFolder_Click_d__16 openBuildFolder_Click_d__ = default(_OpenBuildFolder_Click_d__16);
		openBuildFolder_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openBuildFolder_Click_d__.__4__this = this;
		openBuildFolder_Click_d__.__1__state = -1;
		openBuildFolder_Click_d__.__t__builder.Start<_OpenBuildFolder_Click_d__16>(ref openBuildFolder_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CloudSync_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CloudSync_Click_d__18 cloudSync_Click_d__ = default(_CloudSync_Click_d__18);
		cloudSync_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		cloudSync_Click_d__.__4__this = this;
		cloudSync_Click_d__.__1__state = -1;
		cloudSync_Click_d__.__t__builder.Start<_CloudSync_Click_d__18>(ref cloudSync_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelCloudSync_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? cloudSyncCancellation = _cloudSyncCancellation;
		if (cloudSyncCancellation != null)
		{
			cloudSyncCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool CanChangeFiles()
	{
		if (!_fileOperation && !_injecting && _cloudSyncCancellation == null)
		{
			return true;
		}
		Notice("文件操作正在进行，请稍后再试。", (InfoBarSeverity)0);
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Import_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Import_Click_d__21 import_Click_d__ = default(_Import_Click_d__21);
		import_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		import_Click_d__.__4__this = this;
		import_Click_d__.__1__state = -1;
		import_Click_d__.__t__builder.Start<_Import_Click_d__21>(ref import_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task OpenFolderAsync(string path)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenFolderAsync_d__22 openFolderAsync_d__ = default(_OpenFolderAsync_d__22);
		openFolderAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		openFolderAsync_d__.__4__this = this;
		openFolderAsync_d__.path = path;
		openFolderAsync_d__.__1__state = -1;
		openFolderAsync_d__.__t__builder.Start<_OpenFolderAsync_d__22>(ref openFolderAsync_d__);
		return openFolderAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenLibraryFolder_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenLibraryFolder_Click_d__23 openLibraryFolder_Click_d__ = default(_OpenLibraryFolder_Click_d__23);
		openLibraryFolder_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openLibraryFolder_Click_d__.__4__this = this;
		openLibraryFolder_Click_d__.__1__state = -1;
		openLibraryFolder_Click_d__.__t__builder.Start<_OpenLibraryFolder_Click_d__23>(ref openLibraryFolder_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenFileLocation_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenFileLocation_Click_d__24 openFileLocation_Click_d__ = default(_OpenFileLocation_Click_d__24);
		openFileLocation_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openFileLocation_Click_d__.__4__this = this;
		openFileLocation_Click_d__.sender = sender;
		openFileLocation_Click_d__.__1__state = -1;
		openFileLocation_Click_d__.__t__builder.Start<_OpenFileLocation_Click_d__24>(ref openFileLocation_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyFilePath_Click(object sender, RoutedEventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		object obj = ((sender is FrameworkElement) ? sender : null);
		if (!(((obj != null) ? ((FrameworkElement)obj).Tag : null) is McpLocalFile mcpLocalFile))
		{
			return;
		}
		try
		{
			DataPackage val = new DataPackage();
			val.SetText(mcpLocalFile.FilePath);
			Clipboard.SetContent(val);
			Notice("文件路径已复制。", (InfoBarSeverity)1);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "CopyFilePath_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Features\\McpStudio\\Views\\McpStudioPage.Files.cs", 72);
			Notice("复制失败：" + ex.Message, (InfoBarSeverity)3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void FileDetails_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_FileDetails_Click_d__26 fileDetails_Click_d__ = default(_FileDetails_Click_d__26);
		fileDetails_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		fileDetails_Click_d__.__4__this = this;
		fileDetails_Click_d__.sender = sender;
		fileDetails_Click_d__.__1__state = -1;
		fileDetails_Click_d__.__t__builder.Start<_FileDetails_Click_d__26>(ref fileDetails_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RemoveFile_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RemoveFile_Click_d__27 removeFile_Click_d__ = default(_RemoveFile_Click_d__27);
		removeFile_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		removeFile_Click_d__.__4__this = this;
		removeFile_Click_d__.sender = sender;
		removeFile_Click_d__.__1__state = -1;
		removeFile_Click_d__.__t__builder.Start<_RemoveFile_Click_d__27>(ref removeFile_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpStudioPage()
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		_library = (McpLocalLibraryService)new McpLocalLibraryService(Path.Combine(JNVYTu71oRZRpWuML35.LocalDataRoot, "Mcp"));
		_injector = (McpInjectionService)new McpInjectionService();
		_builder = (McpBuilderService)new McpBuilderService();
		_buildEnvironment = (McpBuildEnvironmentService)new McpBuildEnvironmentService();
		_injected = new HashSet<string>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		_submissions = new Dictionary<string, McpInjectionService.Submission>((IEqualityComparer<string>)(object)StringComparer.OrdinalIgnoreCase);
		_pending = new ObservableCollection<McpLocalFile>();
		_injectedFiles = new ObservableCollection<McpLocalFile>();
		_gameTimer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(5.0)
		};
		_noticeTimer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(8.0)
		};
		_files = global::System.Array.Empty<McpLocalFile>();
		InitializeComponent();
		((ItemsControl)PendingList).ItemsSource = _pending;
		((ItemsControl)InjectedList).ItemsSource = _injectedFiles;
		_ready = true;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(Page_Loaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(Page_Unloaded);
		_gameTimer.Tick += [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, object _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__46_0_d __ctor_b__46_0_d = default(___ctor_b__46_0_d);
			__ctor_b__46_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__46_0_d.__4__this = this;
			__ctor_b__46_0_d.__1__state = -1;
			__ctor_b__46_0_d.__t__builder.Start<___ctor_b__46_0_d>(ref __ctor_b__46_0_d);
		};
		_noticeTimer.Tick += [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object? _, object _) =>
		{
			_noticeTimer.Stop();
			OperationNotice.IsOpen = false;
		};
		if (_buildEnvironment.IsInstalled)
		{
			PythonPathBox.Text = _buildEnvironment.PythonPath;
		}
		UpdateEnvironmentStatus();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Page_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Page_Loaded_d__47 page_Loaded_d__ = default(_Page_Loaded_d__47);
		page_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		page_Loaded_d__.__4__this = this;
		page_Loaded_d__.__1__state = -1;
		page_Loaded_d__.__t__builder.Start<_Page_Loaded_d__47>(ref page_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Page_Unloaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Page_Unloaded_d__48 page_Unloaded_d__ = default(_Page_Unloaded_d__48);
		page_Unloaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		page_Unloaded_d__.__4__this = this;
		page_Unloaded_d__.__1__state = -1;
		page_Unloaded_d__.__t__builder.Start<_Page_Unloaded_d__48>(ref page_Unloaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Notice(string message, InfoBarSeverity severity = (InfoBarSeverity)0)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		OperationNotice.Message = message;
		OperationNotice.Severity = severity;
		OperationNotice.IsOpen = true;
		_noticeTimer.Stop();
		_noticeTimer.Start();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Dictionary<int, global::System.DateTime?> ReadGameSessions()
	{
		Dictionary<int, global::System.DateTime?> val = new Dictionary<int, global::System.DateTime?>();
		Process[] processesByName = Process.GetProcessesByName("Minecraft.Windows");
		foreach (Process val2 in processesByName)
		{
			Process val3 = val2;
			try
			{
				val[val2.Id] = val2.StartTime.ToUniversalTime();
			}
			catch (Win32Exception)
			{
				val[val2.Id] = null;
			}
			catch (InvalidOperationException)
			{
			}
			finally
			{
				((global::System.IDisposable)val3)?.Dispose();
			}
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAsync_d__51 refreshAsync_d__ = default(_RefreshAsync_d__51);
		refreshAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAsync_d__.__4__this = this;
		refreshAsync_d__.__1__state = -1;
		refreshAsync_d__.__t__builder.Start<_RefreshAsync_d__51>(ref refreshAsync_d__);
		return refreshAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyFileFilter()
	{
		__c__DisplayClass52_0 __8_locals6 = (__c__DisplayClass52_0)new __c__DisplayClass52_0();
		if (!_ready)
		{
			return;
		}
		__8_locals6.term = FileSearchBox.Text.Trim();
		((Collection<McpLocalFile>)(object)_pending).Clear();
		((Collection<McpLocalFile>)(object)_injectedFiles).Clear();
		global::System.Collections.Generic.IEnumerator<McpLocalFile> enumerator = Enumerable.Where<McpLocalFile>((global::System.Collections.Generic.IEnumerable<McpLocalFile>)_files, (Func<McpLocalFile, bool>)([MethodImpl((MethodImplOptions)8)] (McpLocalFile file) => __8_locals6.term.Length == 0 || file.FileName.Contains(__8_locals6.term, (StringComparison)5) || file.EntryModule.Contains(__8_locals6.term, (StringComparison)5))).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				McpLocalFile current = enumerator.Current;
				if (current.IsInjected)
				{
					((Collection<McpLocalFile>)(object)_injectedFiles).Add(current);
				}
				else
				{
					((Collection<McpLocalFile>)(object)_pending).Add(current);
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		PendingTitle.Text = $"未注入 ({((Collection<McpLocalFile>)(object)_pending).Count})";
		InjectedTitle.Text = $"已发送到游戏 ({((Collection<McpLocalFile>)(object)_injectedFiles).Count})";
		((UIElement)PendingEmpty).Visibility = (((((Collection<McpLocalFile>)(object)_pending).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		PendingEmptyText.Text = ((__8_locals6.term.Length > 0) ? "没有匹配的未注入文件" : "还没有未注入的 MCP 文件");
		((UIElement)InjectedEmpty).Visibility = (((((Collection<McpLocalFile>)(object)_injectedFiles).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		InjectedEmpty.Text = ((__8_locals6.term.Length > 0) ? "没有匹配的已发送文件。" : "本次游戏会话还没有提交过 MCP。");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void FileSearch_TextChanged(object sender, TextChangedEventArgs e)
	{
		ApplyFileFilter();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshLibrary_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshLibrary_Click_d__54 refreshLibrary_Click_d__ = default(_RefreshLibrary_Click_d__54);
		refreshLibrary_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshLibrary_Click_d__.__4__this = this;
		refreshLibrary_Click_d__.__1__state = -1;
		refreshLibrary_Click_d__.__t__builder.Start<_RefreshLibrary_Click_d__54>(ref refreshLibrary_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Inject_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Inject_Click_d__55 inject_Click_d__ = default(_Inject_Click_d__55);
		inject_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		inject_Click_d__.__4__this = this;
		inject_Click_d__.sender = sender;
		inject_Click_d__.__1__state = -1;
		inject_Click_d__.__t__builder.Start<_Inject_Click_d__55>(ref inject_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task OpenUrlAsync(string value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenUrlAsync_d__56 openUrlAsync_d__ = default(_OpenUrlAsync_d__56);
		openUrlAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		openUrlAsync_d__.__4__this = this;
		openUrlAsync_d__.value = value;
		openUrlAsync_d__.__1__state = -1;
		openUrlAsync_d__.__t__builder.Start<_OpenUrlAsync_d__56>(ref openUrlAsync_d__);
		return openUrlAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenMarket_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenMarket_Click_d__57 openMarket_Click_d__ = default(_OpenMarket_Click_d__57);
		openMarket_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openMarket_Click_d__.__4__this = this;
		openMarket_Click_d__.__1__state = -1;
		openMarket_Click_d__.__t__builder.Start<_OpenMarket_Click_d__57>(ref openMarket_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenDocs_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenDocs_Click_d__58 openDocs_Click_d__ = default(_OpenDocs_Click_d__58);
		openDocs_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openDocs_Click_d__.__4__this = this;
		openDocs_Click_d__.__1__state = -1;
		openDocs_Click_d__.__t__builder.Start<_OpenDocs_Click_d__58>(ref openDocs_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///Features/McpStudio/Views/McpStudioPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0245: Expected O, but got Unknown
		//IL_0285: Unknown result type (might be due to invalid IL or missing references)
		//IL_028f: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0313: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Expected O, but got Unknown
		//IL_0340: Unknown result type (might be due to invalid IL or missing references)
		//IL_034a: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f3: Expected O, but got Unknown
		//IL_0511: Unknown result type (might be due to invalid IL or missing references)
		//IL_051b: Expected O, but got Unknown
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Expected O, but got Unknown
		//IL_0555: Unknown result type (might be due to invalid IL or missing references)
		//IL_055f: Expected O, but got Unknown
		//IL_0571: Unknown result type (might be due to invalid IL or missing references)
		//IL_057b: Expected O, but got Unknown
		//IL_058d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0597: Expected O, but got Unknown
		switch (connectionId)
		{
		case 3:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(Inject_Click);
			break;
		case 4:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(FileDetails_Click);
			break;
		case 5:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(OpenFileLocation_Click);
			break;
		case 6:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(CopyFilePath_Click);
			break;
		case 7:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(RemoveFile_Click);
			break;
		case 8:
			OperationNotice = CastExtensions.As<InfoBar>(target);
			break;
		case 9:
			WorkspaceTabs = CastExtensions.As<TabView>(target);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(OpenDocs_Click);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenMarket_Click);
			break;
		case 12:
			BuildInputs = CastExtensions.As<UserControl>(target);
			break;
		case 13:
			BuildResultPanel = CastExtensions.As<Border>(target);
			break;
		case 14:
			BuildLogBox = CastExtensions.As<TextBox>(target);
			break;
		case 15:
			BuildResultText = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			ImportBuildButton = CastExtensions.As<Button>(target);
			((ButtonBase)ImportBuildButton).Click += new RoutedEventHandler(ImportBuildResult_Click);
			break;
		case 17:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenBuildFolder_Click);
			break;
		case 18:
			BuildProgress = CastExtensions.As<ProgressBar>(target);
			break;
		case 19:
			BuildStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			BuildButton = CastExtensions.As<Button>(target);
			((ButtonBase)BuildButton).Click += new RoutedEventHandler(BuildMcp_Click);
			break;
		case 21:
			CancelBuildButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelBuildButton).Click += new RoutedEventHandler(CancelBuild_Click);
			break;
		case 22:
			PackageIdBox = CastExtensions.As<TextBox>(target);
			PackageIdBox.TextChanged += new TextChangedEventHandler(PackageId_TextChanged);
			break;
		case 23:
			BuildEntryModuleBox = CastExtensions.As<TextBox>(target);
			break;
		case 24:
			OutputPathBox = CastExtensions.As<TextBox>(target);
			break;
		case 25:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SelectOutput_Click);
			break;
		case 26:
			SourceDirectoryBox = CastExtensions.As<TextBox>(target);
			break;
		case 27:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SelectSourceDirectory_Click);
			break;
		case 28:
			EnvironmentStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			PythonPathBox = CastExtensions.As<TextBox>(target);
			break;
		case 30:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(InstallBuildEnvironment_Click);
			break;
		case 31:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SelectPython_Click);
			break;
		case 32:
			FileSearchBox = CastExtensions.As<TextBox>(target);
			FileSearchBox.TextChanged += new TextChangedEventHandler(FileSearch_TextChanged);
			break;
		case 33:
			InjectionSettings = CastExtensions.As<Expander>(target);
			break;
		case 34:
			InjectedTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 35:
			InjectedEmpty = CastExtensions.As<TextBlock>(target);
			break;
		case 36:
			InjectedList = CastExtensions.As<ListView>(target);
			break;
		case 37:
			PendingTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 38:
			PendingEmpty = CastExtensions.As<Border>(target);
			break;
		case 39:
			PendingList = CastExtensions.As<ListView>(target);
			break;
		case 40:
			PendingEmptyText = CastExtensions.As<TextBlock>(target);
			break;
		case 41:
			GameStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 42:
			ManagerAddressBox = CastExtensions.As<TextBox>(target);
			break;
		case 43:
			EntryModuleBox = CastExtensions.As<TextBox>(target);
			break;
		case 44:
			CloudProgress = CastExtensions.As<ProgressBar>(target);
			break;
		case 45:
			CloudStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 46:
			CloudErrorsPanel = CastExtensions.As<Expander>(target);
			break;
		case 47:
			CloudErrorsText = CastExtensions.As<TextBox>(target);
			break;
		case 48:
			ImportButton = CastExtensions.As<AppBarButton>(target);
			((ButtonBase)ImportButton).Click += new RoutedEventHandler(Import_Click);
			break;
		case 49:
			CloudSyncButton = CastExtensions.As<AppBarButton>(target);
			((ButtonBase)CloudSyncButton).Click += new RoutedEventHandler(CloudSync_Click);
			break;
		case 50:
			CancelSyncButton = CastExtensions.As<AppBarButton>(target);
			((ButtonBase)CancelSyncButton).Click += new RoutedEventHandler(CancelCloudSync_Click);
			break;
		case 51:
			((ButtonBase)CastExtensions.As<AppBarButton>(target)).Click += new RoutedEventHandler(RefreshLibrary_Click);
			break;
		case 52:
			((ButtonBase)CastExtensions.As<AppBarButton>(target)).Click += new RoutedEventHandler(OpenLibraryFolder_Click);
			break;
		case 53:
			((ButtonBase)CastExtensions.As<AppBarButton>(target)).Click += new RoutedEventHandler(OpenMarket_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__46_0(object? _, object _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__46_0_d __ctor_b__46_0_d = default(___ctor_b__46_0_d);
		__ctor_b__46_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__46_0_d.__4__this = this;
		__ctor_b__46_0_d.__1__state = -1;
		__ctor_b__46_0_d.__t__builder.Start<___ctor_b__46_0_d>(ref __ctor_b__46_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__46_1(object? _, object _2)
	{
		_noticeTimer.Stop();
		OperationNotice.IsOpen = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

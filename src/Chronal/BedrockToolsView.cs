using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using NGs23dRsf1NAcIqosyu;
using R5yqr9R1IELhaDBLEJI;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Toolbox;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class BedrockToolsView : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_12
	{
		public static __c_12 __9;

		public static Func<global::System.Collections.Generic.IReadOnlyList<string>> __9__15_0;

		public static Func<string, string> __9__16_0;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			__9 = (__c_12)new __c_12();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_12()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Collections.Generic.IReadOnlyList<string> _DeleteCache_Click_b__15_0()
		{
			return da18CdX55laNMRKtM3p0.Shared.sUFXRKJrHX5();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _RefreshCacheTargets_b__16_0(string path)
		{
			string relativePath = Path.GetRelativePath(Environment.GetFolderPath((System.Environment.SpecialFolder)26), path);
			return "%APPDATA%\\" + relativePath;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass4_0
	{
		public fOcOY1RFFHl1umhJwJs previous;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass4_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshDllTargetsAsync_b__0(fOcOY1RFFHl1umhJwJs target)
		{
			return target == previous;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_3
	{
		public BedrockToolsView __4__this;

		public fOcOY1RFFHl1umhJwJs target;

		public string path;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _InjectDll_Click_b__0()
		{
			return __4__this._dllInjection.UNjRvji1H4(target, path);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockToolsView_Loaded_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockToolsView.RefreshCacheTargets();
					_u__ = bedrockToolsView.RefreshDllTargetsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockToolsView_Loaded_d__13>(ref _u__, ref this);
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
	private struct _DeleteCache_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<string>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004c;
				}
				if (!bedrockToolsView._deletingCache)
				{
					bedrockToolsView._deletingCache = true;
					((Control)bedrockToolsView.DeleteCacheButton).IsEnabled = false;
					ShowStatus(bedrockToolsView.CacheStatusBar, "正在清理游戏缓存…", (InfoBarSeverity)0);
					goto IL_004c;
				}
				goto end_IL_0011;
				IL_004c:
				try
				{
					TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<string>> _u__;
					if (num != 0)
					{
						EnsureLoggedIn();
						_u__ = global::System.Threading.Tasks.Task.Run<global::System.Collections.Generic.IReadOnlyList<string>>((Func<global::System.Collections.Generic.IReadOnlyList<string>>)__c_12.__9._DeleteCache_Click_b__15_0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<string>>, _DeleteCache_Click_d__15>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<string>>);
						num = (__1__state = -1);
					}
					global::System.Collections.Generic.IReadOnlyList<string> result = _u__.GetResult();
					ShowStatus(bedrockToolsView.CacheStatusBar, (((global::System.Collections.Generic.IReadOnlyCollection<string>)result).Count > 0) ? $"已清理 {((global::System.Collections.Generic.IReadOnlyCollection<string>)result).Count} 个游戏缓存目录；再次进入服务器时会重新生成或下载。" : "未找到可清理的游戏缓存目录。", (((((global::System.Collections.Generic.IReadOnlyCollection<string>)result).Count > 0)) ? (InfoBarSeverity)1 : (InfoBarSeverity)0));
					bedrockToolsView.RefreshCacheTargets();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-cache-delete", "DeleteCache_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\BedrockToolsView.xaml.cs", 53);
					ShowStatus(bedrockToolsView.CacheStatusBar, "缓存清理未完成：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						bedrockToolsView._deletingCache = false;
						((Control)bedrockToolsView.DeleteCacheButton).IsEnabled = true;
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
	private struct _InjectDll_Click_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

		private __c__DisplayClass8_0_3 __8__1;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0100;
				}
				__8__1 = (__c__DisplayClass8_0_3)new __c__DisplayClass8_0_3();
				__8__1.__4__this = __4__this;
				if (!bedrockToolsView._injectingDll && !bedrockToolsView._refreshingDllTargets && !bedrockToolsView._selectingDll)
				{
					object selectedItem = ((Selector)bedrockToolsView.DllTargetComboBox).SelectedItem;
					__8__1.target = (fOcOY1RFFHl1umhJwJs)((selectedItem is fOcOY1RFFHl1umhJwJs) ? selectedItem : null);
					if (__8__1.target != null)
					{
						__8__1.path = bedrockToolsView._dllPath;
						if (__8__1.path != null)
						{
							bedrockToolsView._injectingDll = true;
							bedrockToolsView.UpdateDllControls();
							ShowStatus(bedrockToolsView.DllStatusBar, $"正在向 PID {__8__1.target.ProcessId} 注入 DLL…", (InfoBarSeverity)0);
							goto IL_0100;
						}
					}
				}
				goto end_IL_0011;
				IL_0100:
				try
				{
					TaskAwaiter<bool> _u__ = default;
					if (num != 0)
					{
						EnsureLoggedIn();
						_u__ = global::System.Threading.Tasks.Task.Run<bool>((Func<bool>)__8__1._InjectDll_Click_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _InjectDll_Click_d__8>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					bool result = _u__.GetResult();
					ShowStatus(bedrockToolsView.DllStatusBar, result ? $"DLL 已加载到游戏进程 PID {__8__1.target.ProcessId}。" : $"该 DLL 已在游戏进程 PID {__8__1.target.ProcessId} 中加载。", (result ? (InfoBarSeverity)1 : (InfoBarSeverity)0));
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-dll-injection", "InjectDll_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\BedrockToolsView.DllInjection.cs", 101);
					ShowStatus(bedrockToolsView.DllStatusBar, "DLL 注入未完成：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						bedrockToolsView._injectingDll = false;
						bedrockToolsView.UpdateDllControls();
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
	private struct _RefreshDllTargetsAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

		private __c__DisplayClass4_0 __8__1;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004b;
				}
				if (!bedrockToolsView._refreshingDllTargets && !bedrockToolsView._injectingDll && !bedrockToolsView._selectingDll)
				{
					bedrockToolsView._refreshingDllTargets = true;
					bedrockToolsView.UpdateDllControls();
					goto IL_004b;
				}
				goto end_IL_0011;
				IL_004b:
				try
				{
					TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>> _u__;
					if (num != 0)
					{
						__8__1 = (__c__DisplayClass4_0)new __c__DisplayClass4_0();
						EnsureLoggedIn();
						fOcOY1RFFHl1umhJwJs reference = __8__1.previous;
						object selectedItem = ((Selector)bedrockToolsView.DllTargetComboBox).SelectedItem;
						reference = (fOcOY1RFFHl1umhJwJs)((selectedItem is fOcOY1RFFHl1umhJwJs) ? selectedItem : null);
						_u__ = global::System.Threading.Tasks.Task.Run<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>>((Func<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>>)bedrockToolsView._dllInjection.AO8R3Oh34e).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>>, _RefreshDllTargetsAsync_d__4>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs>>);
						num = (__1__state = -1);
					}
					global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs> result = _u__.GetResult();
					((ItemsControl)bedrockToolsView.DllTargetComboBox).ItemsSource = result;
					((Selector)bedrockToolsView.DllTargetComboBox).SelectedItem = Enumerable.FirstOrDefault<fOcOY1RFFHl1umhJwJs>((global::System.Collections.Generic.IEnumerable<fOcOY1RFFHl1umhJwJs>)result, (Func<fOcOY1RFFHl1umhJwJs, bool>)__8__1._RefreshDllTargetsAsync_b__0) ?? ((((global::System.Collections.Generic.IReadOnlyCollection<fOcOY1RFFHl1umhJwJs>)result).Count == 1) ? result[0] : null);
					if (((global::System.Collections.Generic.IReadOnlyCollection<fOcOY1RFFHl1umhJwJs>)result).Count == 0)
					{
						ShowStatus(bedrockToolsView.DllStatusBar, "未找到正在运行的 Minecraft.Windows.exe，请先启动游戏再刷新。", (InfoBarSeverity)0);
					}
					else
					{
						bedrockToolsView.DllStatusBar.IsOpen = false;
					}
					__8__1 = null;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-dll-targets", "RefreshDllTargetsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\BedrockToolsView.DllInjection.cs", 39);
					ShowStatus(bedrockToolsView.DllStatusBar, "读取游戏进程失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						bedrockToolsView._refreshingDllTargets = false;
						bedrockToolsView.UpdateDllControls();
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
	private struct _RefreshDllTargets_Click_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

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
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockToolsView.RefreshDllTargetsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshDllTargets_Click_d__5>(ref _u__, ref this);
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
	private struct _SelectDll_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockToolsView __4__this;

		private TaskAwaiter<string?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockToolsView bedrockToolsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_004b;
				}
				if (!bedrockToolsView._selectingDll && !bedrockToolsView._injectingDll && !bedrockToolsView._refreshingDllTargets)
				{
					bedrockToolsView._selectingDll = true;
					bedrockToolsView.UpdateDllControls();
					goto IL_004b;
				}
				goto end_IL_0011;
				IL_004b:
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						EnsureLoggedIn();
						_u__ = DesktopFilePicker.PickOpenFileAsync(AppShell.WindowHandle, (PickerLocationId)0, new string[1] { ".dll" }, "选择要注入的 DLL").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _SelectDll_Click_d__7>(ref _u__, ref this);
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
						EnsureLoggedIn();
						bedrockToolsView._dllPath = result;
						bedrockToolsView.DllPathText.Text = result;
						bedrockToolsView.DllStatusBar.IsOpen = false;
					}
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-dll-picker", "SelectDll_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\BedrockToolsView.DllInjection.cs", 73);
					ShowStatus(bedrockToolsView.DllStatusBar, "选择 DLL 失败：" + ex.Message, (InfoBarSeverity)3);
				}
				finally
				{
					if (num < 0)
					{
						bedrockToolsView._selectingDll = false;
						bedrockToolsView.UpdateDllControls();
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

	private string? _dllPath;

	private bool _refreshingDllTargets;

	private bool _injectingDll;

	private bool _selectingDll;

	private readonly S2o5G5RaBS3I3hNd033 _dllInjection;

	private bool _deletingCache;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar CacheStatusBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button DeleteCacheButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CacheTargetsText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar DllStatusBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button InjectDllButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DllPathText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button SelectDllButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox DllTargetComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshDllTargetsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshDllTargetsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshDllTargetsAsync_d__4 refreshDllTargetsAsync_d__ = default(_RefreshDllTargetsAsync_d__4);
		refreshDllTargetsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshDllTargetsAsync_d__.__4__this = this;
		refreshDllTargetsAsync_d__.__1__state = -1;
		refreshDllTargetsAsync_d__.__t__builder.Start<_RefreshDllTargetsAsync_d__4>(ref refreshDllTargetsAsync_d__);
		return refreshDllTargetsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshDllTargets_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshDllTargets_Click_d__5 refreshDllTargets_Click_d__ = default(_RefreshDllTargets_Click_d__5);
		refreshDllTargets_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshDllTargets_Click_d__.__4__this = this;
		refreshDllTargets_Click_d__.__1__state = -1;
		refreshDllTargets_Click_d__.__t__builder.Start<_RefreshDllTargets_Click_d__5>(ref refreshDllTargets_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void DllTarget_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdateDllControls();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SelectDll_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SelectDll_Click_d__7 selectDll_Click_d__ = default(_SelectDll_Click_d__7);
		selectDll_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		selectDll_Click_d__.__4__this = this;
		selectDll_Click_d__.__1__state = -1;
		selectDll_Click_d__.__t__builder.Start<_SelectDll_Click_d__7>(ref selectDll_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void InjectDll_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InjectDll_Click_d__8 injectDll_Click_d__ = default(_InjectDll_Click_d__8);
		injectDll_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		injectDll_Click_d__.__4__this = this;
		injectDll_Click_d__.__1__state = -1;
		injectDll_Click_d__.__t__builder.Start<_InjectDll_Click_d__8>(ref injectDll_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateDllControls()
	{
		if (InjectDllButton != null)
		{
			bool flag = !_injectingDll && !_refreshingDllTargets && !_selectingDll;
			((Control)DllTargetComboBox).IsEnabled = flag;
			((Control)RefreshDllTargetsButton).IsEnabled = flag;
			((Control)SelectDllButton).IsEnabled = flag;
			((Control)InjectDllButton).IsEnabled = flag && ((Selector)DllTargetComboBox).SelectedItem is fOcOY1RFFHl1umhJwJs && _dllPath != null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockToolsView()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		_dllInjection = new S2o5G5RaBS3I3hNd033();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockToolsView_Loaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockToolsView_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockToolsView_Loaded_d__13 bedrockToolsView_Loaded_d__ = default(_BedrockToolsView_Loaded_d__13);
		bedrockToolsView_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockToolsView_Loaded_d__.__4__this = this;
		bedrockToolsView_Loaded_d__.__1__state = -1;
		bedrockToolsView_Loaded_d__.__t__builder.Start<_BedrockToolsView_Loaded_d__13>(ref bedrockToolsView_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void EnsureLoggedIn()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		if (AppShell.Api.CurrentUser == null)
		{
			throw new InvalidOperationException("请先登录后使用工具箱。");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DeleteCache_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteCache_Click_d__15 deleteCache_Click_d__ = default(_DeleteCache_Click_d__15);
		deleteCache_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		deleteCache_Click_d__.__4__this = this;
		deleteCache_Click_d__.__1__state = -1;
		deleteCache_Click_d__.__t__builder.Start<_DeleteCache_Click_d__15>(ref deleteCache_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshCacheTargets()
	{
		try
		{
			global::System.Collections.Generic.IReadOnlyList<string> readOnlyList = da18CdX55laNMRKtM3p0.Shared.u33XRd98cmn();
			CacheTargetsText.Text = ((((global::System.Collections.Generic.IReadOnlyCollection<string>)readOnlyList).Count == 0) ? "未发现网易基岩缓存目录" : string.Join(Environment.NewLine, Enumerable.Select<string, string>((global::System.Collections.Generic.IEnumerable<string>)readOnlyList, (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string path) =>
			{
				string relativePath = Path.GetRelativePath(Environment.GetFolderPath((System.Environment.SpecialFolder)26), path);
				return "%APPDATA%\\" + relativePath;
			}))));
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "toolbox-cache-discovery", "RefreshCacheTargets", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Toolbox\\BedrockToolsView.xaml.cs", 78);
			CacheTargetsText.Text = "缓存目录读取失败：" + ex.Message;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ShowStatus(InfoBar bar, string message, InfoBarSeverity severity)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		bar.Message = message;
		bar.Severity = severity;
		bar.IsOpen = true;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Toolbox/BedrockToolsView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			CacheStatusBar = CastExtensions.As<InfoBar>(target);
			break;
		case 3:
			DeleteCacheButton = CastExtensions.As<Button>(target);
			((ButtonBase)DeleteCacheButton).Click += new RoutedEventHandler(DeleteCache_Click);
			break;
		case 4:
			CacheTargetsText = CastExtensions.As<TextBlock>(target);
			break;
		case 5:
			DllStatusBar = CastExtensions.As<InfoBar>(target);
			break;
		case 6:
			InjectDllButton = CastExtensions.As<Button>(target);
			((ButtonBase)InjectDllButton).Click += new RoutedEventHandler(InjectDll_Click);
			break;
		case 7:
			DllPathText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			SelectDllButton = CastExtensions.As<Button>(target);
			((ButtonBase)SelectDllButton).Click += new RoutedEventHandler(SelectDll_Click);
			break;
		case 9:
			DllTargetComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)DllTargetComboBox).SelectionChanged += new SelectionChangedEventHandler(DllTarget_SelectionChanged);
			break;
		case 10:
			RefreshDllTargetsButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshDllTargetsButton).Click += new RoutedEventHandler(RefreshDllTargets_Click);
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
	private static void _cctor()
	{
	}
}

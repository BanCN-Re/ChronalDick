using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using L920rlXJE07t7SweCSKe;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.Storage.Pickers;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Yh4txuXJnTvW8Kqtdvjl;
using bUfedyCg1PBqhqIkB8r;
using piNWoNXQAI9JcY9ZCnhF;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class JavaRuntimeProfilePanel : UserControl, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __Scan_Click_b__6_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					javaRuntimeProfilePanel._selectedRoot = null;
					_u__ = javaRuntimeProfilePanel.ScanAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Scan_Click_b__6_0_d>(ref _u__, ref this);
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
	private struct __Select_Click_b__7_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
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
						goto IL_00f4;
					}
					_u__2 = DesktopFilePicker.PickFolderAsync(AppShell.WindowHandle, (PickerLocationId)1, "指定游戏使用的 Java bin 文件夹").GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __Select_Click_b__7_0_d>(ref _u__2, ref this);
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
				if (result != null)
				{
					javaRuntimeProfilePanel._selectedRoot = result;
					_u__ = javaRuntimeProfilePanel.ScanAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __Select_Click_b__7_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_00f4;
				}
				goto end_IL_0011;
				IL_00f4:
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
	private sealed class __c__DisplayClass11_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __ChangeAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass11_0 __4__this;

			private object __7__wrap1;

			private int __7__wrap2;

			private TaskAwaiter<string> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0250: Unknown result type (might be due to invalid IL or missing references)
				//IL_0255: Unknown result type (might be due to invalid IL or missing references)
				//IL_025d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0218: Unknown result type (might be due to invalid IL or missing references)
				//IL_021d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0235: Unknown result type (might be due to invalid IL or missing references)
				//IL_0237: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0129: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0136: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_010e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0110: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008a: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass11_0 _c__DisplayClass11_ = __4__this;
				try
				{
					if ((uint)num > 1u)
					{
						if (num == 2)
						{
							goto IL_01fb;
						}
						__7__wrap1 = null;
						__7__wrap2 = 0;
					}
					try
					{
						TaskAwaiter<string> _u__ = default;
						string result;
						if (num != 0)
						{
							if (num != 1)
							{
								if (_c__DisplayClass11_.restore)
								{
									_u__ = _c__DisplayClass11_.__4__this._service.RwrXQgHLB6M(_c__DisplayClass11_.entry.Directory, default(CancellationToken)).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __ChangeAsync_b__0_d>(ref _u__, ref this);
										return;
									}
									goto IL_00bf;
								}
								_u__ = _c__DisplayClass11_.__4__this._service.rkRXQBD8TDl(_c__DisplayClass11_.entry.Directory, default(CancellationToken)).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __ChangeAsync_b__0_d>(ref _u__, ref this);
									return;
								}
							}
							else
							{
								_u__ = __u__1;
								__u__1 = default(TaskAwaiter<string>);
								num = (__1__state = -1);
							}
							result = _u__.GetResult();
							goto IL_014d;
						}
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<string>);
						num = (__1__state = -1);
						goto IL_00bf;
						IL_00bf:
						result = _u__.GetResult();
						goto IL_014d;
						IL_014d:
						string text = result;
						_c__DisplayClass11_.__4__this.AppendLog(_c__DisplayClass11_.entry.Directory + Environment.NewLine + text);
						_c__DisplayClass11_.__4__this.ResultBar.Severity = (InfoBarSeverity)1;
						_c__DisplayClass11_.__4__this.ResultBar.Title = (_c__DisplayClass11_.restore ? "已恢复原始配置" : "兼容配置已应用");
						_c__DisplayClass11_.__4__this.ResultBar.Message = (_c__DisplayClass11_.restore ? "下次打开游戏时将使用原始文件，备份继续保留。" : "原始文件已备份。请重新打开游戏，确认设备信息的显示结果。");
						_c__DisplayClass11_.__4__this.ResultBar.IsOpen = true;
					}
					catch (global::System.Exception _7__wrap)
					{
						__7__wrap1 = _7__wrap;
					}
					goto IL_01fb;
					IL_01fb:
					try
					{
						TaskAwaiter _u__2 = default;
						if (num != 2)
						{
							_u__2 = _c__DisplayClass11_.__4__this.ScanAsync(_c__DisplayClass11_.entry.Directory).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ChangeAsync_b__0_d>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
						}
						_u__2.GetResult();
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "ChangeAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Java\\JavaRuntimeProfilePanel.xaml.cs", 68);
						((ItemsControl)_c__DisplayClass11_.__4__this.RuntimePicker).ItemsSource = null;
						_c__DisplayClass11_.__4__this._hasSearched = false;
						_c__DisplayClass11_.__4__this._environmentCount = 0;
						_c__DisplayClass11_.__4__this.AppendLog("操作后读取环境状态失败：" + ex.Message);
						InfoBar resultBar = _c__DisplayClass11_.__4__this.ResultBar;
						resultBar.Message = resultBar.Message + Environment.NewLine + "暂时无法读取环境状态，请重新查找。";
					}
					dynamic obj = __7__wrap1;
					if (obj != null)
					{
						ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj).Throw();
					}
					__7__wrap1 = null;
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

		public bool restore;

		public JavaRuntimeProfilePanel __4__this;

		public c2coImXJvwEghB4hbjMJ entry;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass11_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ChangeAsync_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ChangeAsync_b__0_d _ChangeAsync_b__0_d = default(__ChangeAsync_b__0_d);
			_ChangeAsync_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ChangeAsync_b__0_d.__4__this = this;
			_ChangeAsync_b__0_d.__1__state = -1;
			_ChangeAsync_b__0_d.__t__builder.Start<__ChangeAsync_b__0_d>(ref _ChangeAsync_b__0_d);
			return _ChangeAsync_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass12_0_1
	{
		public string keepSelected;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass12_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ScanAsync_b__0(c2coImXJvwEghB4hbjMJ entry)
		{
			return entry.Directory.Equals(keepSelected, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ChangeAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public bool restore;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00dd;
				}
				__c__DisplayClass11_0 _c__DisplayClass11_ = (__c__DisplayClass11_0)new __c__DisplayClass11_0
				{
					restore = restore,
					__4__this = __4__this
				};
				object selectedItem = ((Selector)javaRuntimeProfilePanel.RuntimePicker).SelectedItem;
				_c__DisplayClass11_.entry = (c2coImXJvwEghB4hbjMJ)((selectedItem is c2coImXJvwEghB4hbjMJ) ? selectedItem : null);
				if (_c__DisplayClass11_.entry != null)
				{
					_u__ = javaRuntimeProfilePanel.RunAsync(_c__DisplayClass11_.restore ? "恢复原始配置" : "应用兼容配置", _c__DisplayClass11_._ChangeAsync_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ChangeAsync_d__11>(ref _u__, ref this);
						return;
					}
					goto IL_00dd;
				}
				goto end_IL_0011;
				IL_00dd:
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
	private struct _Install_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaRuntimeProfilePanel.ChangeAsync(restore: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Install_Click_d__9>(ref _u__, ref this);
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
	private struct _Restore_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaRuntimeProfilePanel.ChangeAsync(restore: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Restore_Click_d__10>(ref _u__, ref this);
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
	private struct _RunAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		public Func<global::System.Threading.Tasks.Task> action;

		public string operation;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0041;
				}
				if (!javaRuntimeProfilePanel._busy)
				{
					javaRuntimeProfilePanel._busy = true;
					javaRuntimeProfilePanel.ResultBar.IsOpen = false;
					javaRuntimeProfilePanel.UpdateControls();
					goto IL_0041;
				}
				goto end_IL_0011;
				IL_0041:
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = action.Invoke().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunAsync_d__13>(ref _u__, ref this);
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
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Java\\JavaRuntimeProfilePanel.xaml.cs", 100);
					javaRuntimeProfilePanel.ResultBar.Severity = (InfoBarSeverity)3;
					javaRuntimeProfilePanel.ResultBar.Title = operation + "失败";
					javaRuntimeProfilePanel.ResultBar.Message = ex.Message;
					javaRuntimeProfilePanel.ResultBar.IsOpen = true;
					javaRuntimeProfilePanel.AppendLog(operation + "：" + (object)ex);
				}
				finally
				{
					if (num < 0)
					{
						javaRuntimeProfilePanel._busy = false;
						javaRuntimeProfilePanel.UpdateControls();
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
	private struct _ScanAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string keepSelected;

		public JavaRuntimeProfilePanel __4__this;

		private __c__DisplayClass12_0_1 __8__1;

		private TaskAwaiter<lfXX0hXJiENbR2koEBGi> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel javaRuntimeProfilePanel = __4__this;
			try
			{
				TaskAwaiter<lfXX0hXJiENbR2koEBGi> _u__ = default;
				if (num != 0)
				{
					__8__1 = (__c__DisplayClass12_0_1)new __c__DisplayClass12_0_1();
					__8__1.keepSelected = keepSelected;
					_u__ = javaRuntimeProfilePanel._service.UMPXQI7B7RZ(javaRuntimeProfilePanel._selectedRoot, default(CancellationToken)).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<lfXX0hXJiENbR2koEBGi>, _ScanAsync_d__12>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<lfXX0hXJiENbR2koEBGi>);
					num = (__1__state = -1);
				}
				lfXX0hXJiENbR2koEBGi result = _u__.GetResult();
				javaRuntimeProfilePanel._hasSearched = true;
				javaRuntimeProfilePanel._environmentCount = ((global::System.Collections.Generic.IReadOnlyCollection<c2coImXJvwEghB4hbjMJ>)result.Entries).Count;
				((ItemsControl)javaRuntimeProfilePanel.RuntimePicker).ItemsSource = result.Entries;
				((Selector)javaRuntimeProfilePanel.RuntimePicker).SelectedItem = Enumerable.FirstOrDefault<c2coImXJvwEghB4hbjMJ>((global::System.Collections.Generic.IEnumerable<c2coImXJvwEghB4hbjMJ>)result.Entries, (Func<c2coImXJvwEghB4hbjMJ, bool>)__8__1._ScanAsync_b__0) ?? Enumerable.FirstOrDefault<c2coImXJvwEghB4hbjMJ>((global::System.Collections.Generic.IEnumerable<c2coImXJvwEghB4hbjMJ>)result.Entries);
				javaRuntimeProfilePanel.AppendLog($"扫描完成，找到 {((global::System.Collections.Generic.IReadOnlyCollection<c2coImXJvwEghB4hbjMJ>)result.Entries).Count} 个运行时。");
				global::System.Collections.Generic.IEnumerator<string> enumerator = ((global::System.Collections.Generic.IEnumerable<string>)result.Diagnostics).GetEnumerator();
				try
				{
					while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
					{
						string current = enumerator.Current;
						javaRuntimeProfilePanel.AppendLog(current);
					}
				}
				finally
				{
					if (num < 0)
					{
						((global::System.IDisposable)enumerator)?.Dispose();
					}
				}
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
	private struct _Scan_Click_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel __8_locals2 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = __8_locals2.RunAsync("查找游戏环境", [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__Scan_Click_b__6_0_d _Scan_Click_b__6_0_d = default(__Scan_Click_b__6_0_d);
						_Scan_Click_b__6_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_Scan_Click_b__6_0_d.__4__this = __8_locals2;
						_Scan_Click_b__6_0_d.__1__state = -1;
						_Scan_Click_b__6_0_d.__t__builder.Start<__Scan_Click_b__6_0_d>(ref _Scan_Click_b__6_0_d);
						return _Scan_Click_b__6_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Scan_Click_d__6>(ref _u__, ref this);
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
	private struct _Select_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaRuntimeProfilePanel __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaRuntimeProfilePanel __8_locals2 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = __8_locals2.RunAsync("指定 Java 环境", [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__Select_Click_b__7_0_d _Select_Click_b__7_0_d = default(__Select_Click_b__7_0_d);
						_Select_Click_b__7_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_Select_Click_b__7_0_d.__4__this = __8_locals2;
						_Select_Click_b__7_0_d.__1__state = -1;
						_Select_Click_b__7_0_d.__t__builder.Start<__Select_Click_b__7_0_d>(ref _Select_Click_b__7_0_d);
						return _Select_Click_b__7_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Select_Click_d__7>(ref _u__, ref this);
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

	private readonly Ww77pMXQ7floyLL96QVT _service;

	private bool _busy;

	private string? _selectedRoot;

	private bool _hasSearched;

	private int _environmentCount;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar ResultBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button InstallButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private HyperlinkButton RestoreButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RuntimeStatus;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RuntimeProcess;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EnvironmentSummary;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox RuntimePicker;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ScanButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing BusyRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private HyperlinkButton SelectButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public JavaRuntimeProfilePanel()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		_service = new Ww77pMXQ7floyLL96QVT();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Scan_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Scan_Click_d__6 scan_Click_d__ = default(_Scan_Click_d__6);
		scan_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		scan_Click_d__.__4__this = this;
		scan_Click_d__.__1__state = -1;
		scan_Click_d__.__t__builder.Start<_Scan_Click_d__6>(ref scan_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Select_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Select_Click_d__7 select_Click_d__ = default(_Select_Click_d__7);
		select_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		select_Click_d__.__4__this = this;
		select_Click_d__.__1__state = -1;
		select_Click_d__.__t__builder.Start<_Select_Click_d__7>(ref select_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Runtime_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdateControls();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Install_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Install_Click_d__9 install_Click_d__ = default(_Install_Click_d__9);
		install_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		install_Click_d__.__4__this = this;
		install_Click_d__.__1__state = -1;
		install_Click_d__.__t__builder.Start<_Install_Click_d__9>(ref install_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Restore_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Restore_Click_d__10 restore_Click_d__ = default(_Restore_Click_d__10);
		restore_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		restore_Click_d__.__4__this = this;
		restore_Click_d__.__1__state = -1;
		restore_Click_d__.__t__builder.Start<_Restore_Click_d__10>(ref restore_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ChangeAsync(bool restore)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ChangeAsync_d__11 changeAsync_d__ = default(_ChangeAsync_d__11);
		changeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		changeAsync_d__.__4__this = this;
		changeAsync_d__.restore = restore;
		changeAsync_d__.__1__state = -1;
		changeAsync_d__.__t__builder.Start<_ChangeAsync_d__11>(ref changeAsync_d__);
		return changeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ScanAsync(string? keepSelected = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ScanAsync_d__12 scanAsync_d__ = default(_ScanAsync_d__12);
		scanAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		scanAsync_d__.__4__this = this;
		scanAsync_d__.keepSelected = keepSelected;
		scanAsync_d__.__1__state = -1;
		scanAsync_d__.__t__builder.Start<_ScanAsync_d__12>(ref scanAsync_d__);
		return scanAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunAsync(string operation, Func<global::System.Threading.Tasks.Task> action)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunAsync_d__13 runAsync_d__ = default(_RunAsync_d__13);
		runAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runAsync_d__.__4__this = this;
		runAsync_d__.operation = operation;
		runAsync_d__.action = action;
		runAsync_d__.__1__state = -1;
		runAsync_d__.__t__builder.Start<_RunAsync_d__13>(ref runAsync_d__);
		return runAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateControls()
	{
		if (InstallButton != null)
		{
			object selectedItem = ((Selector)RuntimePicker).SelectedItem;
			c2coImXJvwEghB4hbjMJ val = (c2coImXJvwEghB4hbjMJ)((selectedItem is c2coImXJvwEghB4hbjMJ) ? selectedItem : null);
			BusyRing.IsActive = _busy;
			Button scanButton = ScanButton;
			HyperlinkButton selectButton = SelectButton;
			bool flag = (((Control)RuntimePicker).IsEnabled = !_busy);
			bool isEnabled = (((Control)selectButton).IsEnabled = flag);
			((Control)scanButton).IsEnabled = isEnabled;
			((Control)InstallButton).IsEnabled = !_busy && val != null && val.CanInstall;
			((Control)RestoreButton).IsEnabled = !_busy && val != null && val.CanRestore;
			EnvironmentSummary.Text = (_busy ? "正在处理，请稍候" : (_hasSearched ? $"找到 {_environmentCount} 个 Java 环境" : "尚未查找本机环境"));
			RuntimeStatus.Text = ((val != null) ? val.Status : null) ?? (_hasSearched ? "没有找到可用环境，可手动指定游戏的 Java 目录。" : "选择环境后查看配置状态");
			RuntimeProcess.Text = ((val != null) ? val.ProcessSummary : null) ?? string.Empty;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AppendLog(string message)
	{
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("java-runtime-profile", message);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void InitializeComponent()
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			Uri val = new Uri("ms-appx:///UI/Controls/Java/JavaRuntimeProfilePanel.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011b: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResultBar = CastExtensions.As<InfoBar>(target);
			break;
		case 3:
			InstallButton = CastExtensions.As<Button>(target);
			((ButtonBase)InstallButton).Click += new RoutedEventHandler(Install_Click);
			break;
		case 4:
			RestoreButton = CastExtensions.As<HyperlinkButton>(target);
			((ButtonBase)RestoreButton).Click += new RoutedEventHandler(Restore_Click);
			break;
		case 5:
			RuntimeStatus = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			RuntimeProcess = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			EnvironmentSummary = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			RuntimePicker = CastExtensions.As<ComboBox>(target);
			((Selector)RuntimePicker).SelectionChanged += new SelectionChangedEventHandler(Runtime_SelectionChanged);
			break;
		case 10:
			ScanButton = CastExtensions.As<Button>(target);
			((ButtonBase)ScanButton).Click += new RoutedEventHandler(Scan_Click);
			break;
		case 11:
			BusyRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 12:
			SelectButton = CastExtensions.As<HyperlinkButton>(target);
			((ButtonBase)SelectButton).Click += new RoutedEventHandler(Select_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _Scan_Click_b__6_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__Scan_Click_b__6_0_d _Scan_Click_b__6_0_d = default(__Scan_Click_b__6_0_d);
		_Scan_Click_b__6_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_Scan_Click_b__6_0_d.__4__this = this;
		_Scan_Click_b__6_0_d.__1__state = -1;
		_Scan_Click_b__6_0_d.__t__builder.Start<__Scan_Click_b__6_0_d>(ref _Scan_Click_b__6_0_d);
		return _Scan_Click_b__6_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _Select_Click_b__7_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__Select_Click_b__7_0_d _Select_Click_b__7_0_d = default(__Select_Click_b__7_0_d);
		_Select_Click_b__7_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_Select_Click_b__7_0_d.__4__this = this;
		_Select_Click_b__7_0_d.__1__state = -1;
		_Select_Click_b__7_0_d.__t__builder.Start<__Select_Click_b__7_0_d>(ref _Select_Click_b__7_0_d);
		return _Select_Click_b__7_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

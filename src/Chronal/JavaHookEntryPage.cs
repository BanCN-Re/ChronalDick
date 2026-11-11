using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.DataTransfer;
using Y9IOPZ2Or6f8KVLXj8N;
using bUfedyCg1PBqhqIkB8r;
using dFmVWJXWeFYUCrpyHTCd;
using qS8vkpL43FlTMgcj0rgs;
using vGvsaMXWxOcIv9vwTPwq;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class JavaHookEntryPage : Page, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__12_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

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
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaHookEntryPage.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__12_0_d>(ref _u__, ref this);
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
	private struct _AutoInject_Changed_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private long _revision_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_00d3;
				}
				javaHookEntryPage._autoInjectionRevision++;
				if (javaHookEntryPage._loaded && javaHookEntryPage._accessAllowed)
				{
					javaHookEntryPage._refreshTimer.Interval = ((((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true) ? TimeSpan.FromMilliseconds(200.0) : TimeSpan.FromSeconds(2.0));
					javaHookEntryPage.Render(javaHookEntryPage._service.Snapshot);
					if (((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true && !javaHookEntryPage._requestingElevation)
					{
						javaHookEntryPage._requestingElevation = true;
						_revision_5__2 = javaHookEntryPage._autoInjectionRevision;
						goto IL_00d3;
					}
				}
				goto end_IL_0011;
				IL_00d3:
				try
				{
					TaskAwaiter<bool> _u__2 = default;
					TaskAwaiter _u__ = default;
					bool result;
					switch (num)
					{
					default:
						_u__2 = JavaAccessGuard.EnsureAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _AutoInject_Changed_d__3>(ref _u__2, ref this);
							return;
						}
						goto IL_013e;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_013e;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0201;
					case 2:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0201:
						_u__.GetResult();
						if (javaHookEntryPage._loaded && ((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true && _revision_5__2 == javaHookEntryPage._autoInjectionRevision)
						{
							_u__ = javaHookEntryPage.RefreshAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _AutoInject_Changed_d__3>(ref _u__, ref this);
								return;
							}
							break;
						}
						goto end_IL_00d3;
						IL_013e:
						result = _u__2.GetResult();
						if (javaHookEntryPage._loaded && ((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true && _revision_5__2 == javaHookEntryPage._autoInjectionRevision)
						{
							javaHookEntryPage._accessAllowed = result;
							if (result)
							{
								_u__ = javaHookEntryPage._service.F0I2uvtTX1().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _AutoInject_Changed_d__3>(ref _u__, ref this);
									return;
								}
								goto IL_0201;
							}
							((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
						}
						goto end_IL_00d3;
					}
					_u__.GetResult();
					end_IL_00d3:;
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "AutoInject_Changed", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaHookEntryPage.AutoInjection.cs", 36);
					((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
					javaHookEntryPage.ShowError((ex is OperationCanceledException) ? "已取消管理员授权" : "请求管理员权限失败", ex);
				}
				finally
				{
					if (num < 0)
					{
						javaHookEntryPage._requestingElevation = false;
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
	private struct _CheckComponents_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

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
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaHookEntryPage.InspectComponentsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CheckComponents_Click_d__19>(ref _u__, ref this);
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
	private struct _InspectComponentsAsync_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private TextBlock __7__wrap1;

		private TaskAwaiter<string> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0039;
				}
				if (((Control)javaHookEntryPage.CheckComponentsButton).IsEnabled)
				{
					((Control)javaHookEntryPage.CheckComponentsButton).IsEnabled = false;
					goto IL_0039;
				}
				goto end_IL_0011;
				IL_0039:
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						__7__wrap1 = javaHookEntryPage.ComponentStatus;
						_u__ = javaHookEntryPage._service.bDS25i5yas(default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _InspectComponentsAsync_d__20>(ref _u__, ref this);
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
					__7__wrap1.Text = result;
					__7__wrap1 = null;
					gX17swyO7x0JWQxdaD1.IdOy6I4Chb("java-native", javaHookEntryPage.ComponentStatus.Text);
				}
				catch (global::System.Exception ex)
				{
					javaHookEntryPage.ComponentStatus.Text = ex.Message;
					gX17swyO7x0JWQxdaD1.TyQywPUFFh("java-native", "检查组件失败", ex);
				}
				finally
				{
					if (num < 0)
					{
						((Control)javaHookEntryPage.CheckComponentsButton).IsEnabled = true;
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
	private struct _LoadedAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__2 = default;
				TaskAwaiter _u__ = default;
				bool result;
				switch (num)
				{
				default:
					if (!javaHookEntryPage._loaded)
					{
						javaHookEntryPage._loaded = true;
						((Control)javaHookEntryPage.StartButton).IsEnabled = false;
						_u__2 = JavaAccessGuard.EnsureAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _LoadedAsync_d__13>(ref _u__2, ref this);
							return;
						}
						goto IL_009c;
					}
					goto end_IL_0011;
				case 0:
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_009c;
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0181;
				case 2:
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_009c:
					result = _u__2.GetResult();
					if (javaHookEntryPage._loaded)
					{
						javaHookEntryPage._accessAllowed = result;
						if (result)
						{
							javaHookEntryPage._service.Changed += javaHookEntryPage.Service_Changed;
							javaHookEntryPage.Render(javaHookEntryPage._service.Snapshot);
							javaHookEntryPage._refreshTimer.Start();
							_u__ = javaHookEntryPage.RefreshAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadedAsync_d__13>(ref _u__, ref this);
								return;
							}
							goto IL_0181;
						}
						Frame frame = ((Page)javaHookEntryPage).Frame;
						if (((frame != null) ? ((ContentControl)frame).Content : null) == javaHookEntryPage)
						{
							AppShell.Navigate(NavigationRegistry.MainPageType("home"));
						}
					}
					goto end_IL_0011;
					IL_0181:
					_u__.GetResult();
					_u__ = javaHookEntryPage.InspectComponentsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadedAsync_d__13>(ref _u__, ref this);
						return;
					}
					break;
				}
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
	private struct _RefreshAsync_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0051;
				}
				if (javaHookEntryPage._loaded && javaHookEntryPage._accessAllowed && !javaHookEntryPage._refreshing && !javaHookEntryPage._starting)
				{
					javaHookEntryPage._refreshing = true;
					goto IL_0051;
				}
				goto end_IL_0011;
				IL_0051:
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
							goto IL_0121;
						}
						_u__ = javaHookEntryPage._service.RefreshAsync(default(CancellationToken)).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshAsync_d__15>(ref _u__, ref this);
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
					_u__ = javaHookEntryPage.TryAutoInjectAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshAsync_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_0121;
					IL_0121:
					_u__.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RefreshAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaHookEntryPage.xaml.cs", 74);
					javaHookEntryPage.ShowError("刷新状态失败", ex);
				}
				finally
				{
					if (num < 0)
					{
						javaHookEntryPage._refreshing = false;
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
	private struct _Refresh_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

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
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaHookEntryPage.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Refresh_Click_d__24>(ref _u__, ref this);
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
	private struct _StartInjectionAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		public xoV7UKXWP562ggfcmFvm automaticTarget;

		private long _revision_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_03c5: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Invalid comparison between Unknown and I4
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Invalid comparison between Unknown and I4
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				if ((uint)num <= 4u)
				{
					goto IL_005e;
				}
				if (!javaHookEntryPage._starting && !javaHookEntryPage._requestingElevation && javaHookEntryPage._accessAllowed)
				{
					_revision_5__2 = javaHookEntryPage._autoInjectionRevision;
					javaHookEntryPage._starting = true;
					((Control)javaHookEntryPage.StartButton).IsEnabled = false;
					goto IL_005e;
				}
				goto end_IL_0011;
				IL_005e:
				try
				{
					TaskAwaiter<bool> _u__2 = default;
					TaskAwaiter _u__ = default;
					R5Ae8x2tv12uNTj2C3h service;
					xoV7UKXWP562ggfcmFvm val;
					bool result;
					switch (num)
					{
					default:
						_u__2 = JavaAccessGuard.EnsureAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StartInjectionAsync_d__22>(ref _u__2, ref this);
							return;
						}
						goto IL_00ce;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_00ce;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_01a2;
					case 2:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_024c;
					case 3:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_02dd;
					case 4:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_02ff:
						if ((int)javaHookEntryPage._service.Snapshot.State == 6)
						{
							_u__ = global::System.Threading.Tasks.Task.Delay(200).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartInjectionAsync_d__22>(ref _u__, ref this);
								return;
							}
							goto IL_024c;
						}
						javaHookEntryPage.RememberInjectionAttempt(automaticTarget ?? javaHookEntryPage._service.Snapshot);
						service = javaHookEntryPage._service;
						val = automaticTarget;
						_u__ = service.BIn2Ny3eeU(default(CancellationToken), val).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 4);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartInjectionAsync_d__22>(ref _u__, ref this);
							return;
						}
						break;
						IL_00ce:
						result = _u__2.GetResult();
						if (javaHookEntryPage._loaded)
						{
							javaHookEntryPage._accessAllowed = result;
							if (!result)
							{
								((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
							}
							else if (automaticTarget == null || (_revision_5__2 == javaHookEntryPage._autoInjectionRevision && ((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true))
							{
								_u__ = javaHookEntryPage._service.F0I2uvtTX1().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartInjectionAsync_d__22>(ref _u__, ref this);
									return;
								}
								goto IL_01a2;
							}
						}
						goto end_IL_005e;
						IL_024c:
						_u__.GetResult();
						if (javaHookEntryPage._loaded && _revision_5__2 == javaHookEntryPage._autoInjectionRevision)
						{
							_u__ = javaHookEntryPage._service.RefreshAsync(default(CancellationToken)).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 3);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartInjectionAsync_d__22>(ref _u__, ref this);
								return;
							}
							goto IL_02dd;
						}
						goto end_IL_005e;
						IL_01a2:
						_u__.GetResult();
						if (javaHookEntryPage._loaded && _revision_5__2 == javaHookEntryPage._autoInjectionRevision && (automaticTarget == null || ((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true))
						{
							goto IL_02ff;
						}
						goto end_IL_005e;
						IL_02dd:
						_u__.GetResult();
						if ((int)javaHookEntryPage._service.Snapshot.State != 4)
						{
							goto IL_02ff;
						}
						goto end_IL_005e;
					}
					_u__.GetResult();
					javaHookEntryPage.RememberInjectionAttempt(javaHookEntryPage._service.Snapshot);
					end_IL_005e:;
				}
				catch (OperationCanceledException ex)
				{
					OperationCanceledException exception = ex;
					((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
					javaHookEntryPage.ShowError("已取消管理员授权", (global::System.Exception)(object)exception);
				}
				catch (global::System.Exception ex2)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "StartInjectionAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaHookEntryPage.xaml.cs", 158);
					((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
					javaHookEntryPage.ShowError("启动注入失败", ex2);
				}
				finally
				{
					if (num < 0)
					{
						javaHookEntryPage._starting = false;
						javaHookEntryPage.Render(javaHookEntryPage._service.Snapshot);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _Start_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

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
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = javaHookEntryPage.StartInjectionAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Start_Click_d__21>(ref _u__, ref this);
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
	private struct _Stop_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				if (num != 0)
				{
					javaHookEntryPage._autoInjectionRevision++;
					((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked = false;
				}
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = javaHookEntryPage._service.lIh2a6k0VQ().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Stop_Click_d__23>(ref _u__, ref this);
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
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Stop_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaHookEntryPage.xaml.cs", 173);
					javaHookEntryPage.ShowError("停止等待失败", ex);
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
	private struct _TryAutoInjectAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaHookEntryPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Invalid comparison between Unknown and I4
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaHookEntryPage javaHookEntryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_016c;
				}
				if (javaHookEntryPage._loaded && javaHookEntryPage._accessAllowed && !javaHookEntryPage._starting && !javaHookEntryPage._requestingElevation && ((ToggleButton)javaHookEntryPage.AutoInjectCheckBox).IsChecked == true)
				{
					xoV7UKXWP562ggfcmFvm snapshot = javaHookEntryPage._service.Snapshot;
					bool flag = snapshot.IsBusy;
					if (!flag)
					{
						xmx1tWXWwxE0l9r9sG2Q state = snapshot.State;
						bool flag2 = (int)state - 1 <= 2;
						flag = flag2;
					}
					if (flag)
					{
						javaHookEntryPage.RememberInjectionAttempt(snapshot);
					}
					else if ((int)snapshot.State == 0)
					{
						int? processId = snapshot.ProcessId;
						if (processId.HasValue)
						{
							int valueOrDefault = processId.GetValueOrDefault();
							global::System.DateTime? processStartTimeUtc = snapshot.ProcessStartTimeUtc;
							if (processStartTimeUtc.HasValue)
							{
								global::System.DateTime valueOrDefault2 = processStartTimeUtc.GetValueOrDefault();
								if (!javaHookEntryPage._injectionAttempts.Contains(new ValueTuple<int, global::System.DateTime>(valueOrDefault, valueOrDefault2)))
								{
									_u__ = javaHookEntryPage.StartInjectionAsync(snapshot).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _TryAutoInjectAsync_d__4>(ref _u__, ref this);
										return;
									}
									goto IL_016c;
								}
							}
						}
					}
				}
				goto end_IL_0011;
				IL_016c:
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

	private readonly HashSet<ValueTuple<int, global::System.DateTime>> _injectionAttempts;

	private long _autoInjectionRevision;

	private bool _requestingElevation;

	private readonly R5Ae8x2tv12uNTj2C3h _service;

	private readonly DispatcherQueueTimer _refreshTimer;

	private bool _loaded;

	private bool _refreshing;

	private bool _starting;

	private bool _accessAllowed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar ErrorBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ComponentStatus;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CheckComponentsButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox AutoInjectCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StartButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StopButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProxyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private HyperlinkButton CopyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProcessText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void AutoInject_Changed(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_AutoInject_Changed_d__3 autoInject_Changed_d__ = default(_AutoInject_Changed_d__3);
		autoInject_Changed_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		autoInject_Changed_d__.__4__this = this;
		autoInject_Changed_d__.__1__state = -1;
		autoInject_Changed_d__.__t__builder.Start<_AutoInject_Changed_d__3>(ref autoInject_Changed_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task TryAutoInjectAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_TryAutoInjectAsync_d__4 tryAutoInjectAsync_d__ = default(_TryAutoInjectAsync_d__4);
		tryAutoInjectAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		tryAutoInjectAsync_d__.__4__this = this;
		tryAutoInjectAsync_d__.__1__state = -1;
		tryAutoInjectAsync_d__.__t__builder.Start<_TryAutoInjectAsync_d__4>(ref tryAutoInjectAsync_d__);
		return tryAutoInjectAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RememberInjectionAttempt(xoV7UKXWP562ggfcmFvm snapshot)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		int? processId = snapshot.ProcessId;
		if (processId.HasValue)
		{
			int valueOrDefault = processId.GetValueOrDefault();
			global::System.DateTime? processStartTimeUtc = snapshot.ProcessStartTimeUtc;
			if (processStartTimeUtc.HasValue)
			{
				global::System.DateTime valueOrDefault2 = processStartTimeUtc.GetValueOrDefault();
				_injectionAttempts.Add(new ValueTuple<int, global::System.DateTime>(valueOrDefault, valueOrDefault2));
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public JavaHookEntryPage()
	{
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		_injectionAttempts = new HashSet<ValueTuple<int, global::System.DateTime>>();
		_service = AppShell.JavaNativeHook;
		InitializeComponent();
		_refreshTimer = ((DependencyObject)this).DispatcherQueue.CreateTimer();
		_refreshTimer.Interval = TimeSpan.FromSeconds(2.0);
		_refreshTimer.Tick += [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (DispatcherQueueTimer _, object _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__12_0_d __ctor_b__12_0_d = default(___ctor_b__12_0_d);
			__ctor_b__12_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__12_0_d.__4__this = this;
			__ctor_b__12_0_d.__1__state = -1;
			__ctor_b__12_0_d.__t__builder.Start<___ctor_b__12_0_d>(ref __ctor_b__12_0_d);
		};
		((FrameworkElement)this).Loaded += new RoutedEventHandler(LoadedAsync);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadedAsync(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadedAsync_d__13 loadedAsync_d__ = default(_LoadedAsync_d__13);
		loadedAsync_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadedAsync_d__.__4__this = this;
		loadedAsync_d__.__1__state = -1;
		loadedAsync_d__.__t__builder.Start<_LoadedAsync_d__13>(ref loadedAsync_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		_loaded = false;
		_autoInjectionRevision++;
		_accessAllowed = false;
		_refreshTimer.Stop();
		_service.Changed -= Service_Changed;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAsync_d__15 refreshAsync_d__ = default(_RefreshAsync_d__15);
		refreshAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAsync_d__.__4__this = this;
		refreshAsync_d__.__1__state = -1;
		refreshAsync_d__.__t__builder.Start<_RefreshAsync_d__15>(ref refreshAsync_d__);
		return refreshAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Service_Changed(object? sender, xoV7UKXWP562ggfcmFvm snapshot)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () =>
		{
			if (_loaded)
			{
				Render(_service.Snapshot);
			}
		}));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Render(xoV7UKXWP562ggfcmFvm snapshot)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Invalid comparison between Unknown and I4
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Invalid comparison between Unknown and I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Invalid comparison between Unknown and I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Invalid comparison between Unknown and I4
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Invalid comparison between Unknown and I4
		StatusText.Text = snapshot.Message;
		TextBlock processText = ProcessText;
		int? processId = snapshot.ProcessId;
		object text;
		if (processId.HasValue)
		{
			int valueOrDefault = processId.GetValueOrDefault();
			text = $"PID {valueOrDefault}";
		}
		else
		{
			text = "未找到";
		}
		processText.Text = (string)text;
		ProxyText.Text = (((int)snapshot.State == 3) ? "已就绪（已核对目标 PID）" : "未确认监听");
		Button startButton = StartButton;
		bool flag = _accessAllowed && !_starting && !_requestingElevation && !snapshot.IsBusy;
		if (flag)
		{
			xmx1tWXWwxE0l9r9sG2Q state = snapshot.State;
			bool flag2 = (((int)state == 3 || (int)state == 6) ? true : false);
			flag = !flag2;
		}
		((Control)startButton).IsEnabled = flag;
		((Control)StopButton).IsEnabled = _starting || snapshot.IsBusy || ((ToggleButton)AutoInjectCheckBox).IsChecked == true;
		((Control)AutoInjectCheckBox).IsEnabled = _accessAllowed;
		((Control)CopyButton).IsEnabled = (int)snapshot.State == 3;
		ErrorBar.IsOpen = (int)snapshot.State == 4;
		ErrorBar.Title = snapshot.Message;
		ErrorBar.Message = snapshot.ErrorDetails;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HookLogin_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("hook"));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CheckComponents_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CheckComponents_Click_d__19 checkComponents_Click_d__ = default(_CheckComponents_Click_d__19);
		checkComponents_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		checkComponents_Click_d__.__4__this = this;
		checkComponents_Click_d__.__1__state = -1;
		checkComponents_Click_d__.__t__builder.Start<_CheckComponents_Click_d__19>(ref checkComponents_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task InspectComponentsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InspectComponentsAsync_d__20 inspectComponentsAsync_d__ = default(_InspectComponentsAsync_d__20);
		inspectComponentsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		inspectComponentsAsync_d__.__4__this = this;
		inspectComponentsAsync_d__.__1__state = -1;
		inspectComponentsAsync_d__.__t__builder.Start<_InspectComponentsAsync_d__20>(ref inspectComponentsAsync_d__);
		return inspectComponentsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Start_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Start_Click_d__21 start_Click_d__ = default(_Start_Click_d__21);
		start_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		start_Click_d__.__4__this = this;
		start_Click_d__.__1__state = -1;
		start_Click_d__.__t__builder.Start<_Start_Click_d__21>(ref start_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task StartInjectionAsync(xoV7UKXWP562ggfcmFvm? automaticTarget = null)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StartInjectionAsync_d__22 startInjectionAsync_d__ = default(_StartInjectionAsync_d__22);
		startInjectionAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		startInjectionAsync_d__.__4__this = this;
		startInjectionAsync_d__.automaticTarget = automaticTarget;
		startInjectionAsync_d__.__1__state = -1;
		startInjectionAsync_d__.__t__builder.Start<_StartInjectionAsync_d__22>(ref startInjectionAsync_d__);
		return startInjectionAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Stop_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Stop_Click_d__23 stop_Click_d__ = default(_Stop_Click_d__23);
		stop_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stop_Click_d__.__4__this = this;
		stop_Click_d__.__1__state = -1;
		stop_Click_d__.__t__builder.Start<_Stop_Click_d__23>(ref stop_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Refresh_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Refresh_Click_d__24 refresh_Click_d__ = default(_Refresh_Click_d__24);
		refresh_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refresh_Click_d__.__4__this = this;
		refresh_Click_d__.__1__state = -1;
		refresh_Click_d__.__t__builder.Start<_Refresh_Click_d__24>(ref refresh_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Copy_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			DataPackage val = new DataPackage();
			val.SetText("127.0.0.1:25565");
			Clipboard.SetContent(val);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Copy_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaHookEntryPage.xaml.cs", 184);
			ShowError("复制地址失败", ex);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowError(string title, global::System.Exception exception)
	{
		ErrorBar.Title = title;
		ErrorBar.Message = exception.Message;
		ErrorBar.IsOpen = true;
		gX17swyO7x0JWQxdaD1.TyQywPUFFh("java-native", title, exception);
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaHookEntryPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ErrorBar = CastExtensions.As<InfoBar>(target);
			break;
		case 3:
			ComponentStatus = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			CheckComponentsButton = CastExtensions.As<Button>(target);
			((ButtonBase)CheckComponentsButton).Click += new RoutedEventHandler(CheckComponents_Click);
			break;
		case 5:
			AutoInjectCheckBox = CastExtensions.As<CheckBox>(target);
			((ToggleButton)AutoInjectCheckBox).Checked += new RoutedEventHandler(AutoInject_Changed);
			((ToggleButton)AutoInjectCheckBox).Unchecked += new RoutedEventHandler(AutoInject_Changed);
			break;
		case 6:
			StartButton = CastExtensions.As<Button>(target);
			((ButtonBase)StartButton).Click += new RoutedEventHandler(Start_Click);
			break;
		case 7:
			StopButton = CastExtensions.As<Button>(target);
			((ButtonBase)StopButton).Click += new RoutedEventHandler(Stop_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(Refresh_Click);
			break;
		case 9:
			ProxyText = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			CopyButton = CastExtensions.As<HyperlinkButton>(target);
			((ButtonBase)CopyButton).Click += new RoutedEventHandler(Copy_Click);
			break;
		case 11:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			ProcessText = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(HookLogin_Click);
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
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void __ctor_b__12_0(DispatcherQueueTimer _, object _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__12_0_d __ctor_b__12_0_d = default(___ctor_b__12_0_d);
		__ctor_b__12_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__12_0_d.__4__this = this;
		__ctor_b__12_0_d.__1__state = -1;
		__ctor_b__12_0_d.__t__builder.Start<___ctor_b__12_0_d>(ref __ctor_b__12_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void _Service_Changed_b__16_0()
	{
		if (_loaded)
		{
			Render(_service.Snapshot);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

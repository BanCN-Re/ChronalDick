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
using System.Threading;
using System.Threading.Tasks;
using AuLwjd4Baw36iWRDt8t;
using By1SFsLobKQOZCdh5qRg;
using JoqwdR4HRLb3utGBTng;
using LEXZsB4Yr6H3t3TdcX4;
using LYCBRkf5Q9nZvTAYjPMZ;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Shapes;
using O4wwqTmFRZpFGt3kwme;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.UI;
using bUfedyCg1PBqhqIkB8r;
using cTpd1lf54YS57isqnyoi;
using gHbGAbCs5WyChRmQ8j8;
using lohC93f5UaygTd8U978I;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class HookLoginPage : Page, IComponentConnector
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass29_0
	{
		public int existingPid;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass29_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefreshHookProcessesAsync_b__0(NYI398f5COw5dgT3xbBV item)
		{
			return item.ProcessId == existingPid;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass40_0
	{
		public NYI398f5COw5dgT3xbBV target;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass40_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SelectHookProcess_b__0(NYI398f5COw5dgT3xbBV item)
		{
			return item.ProcessId == target.ProcessId;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DetectSpecifiedLauncherAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter<string> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				if (num != 0)
				{
					hookLoginPage._nextLauncherDetectionUtc = global::System.DateTime.UtcNow.AddSeconds(5.0);
				}
				try
				{
					TaskAwaiter<string> _u__ = default;
					if (num != 0)
					{
						_u__ = global::System.Threading.Tasks.Task.Run<string>((Func<string>)hookLoginPage._hookBridgeInstaller.QR4CTEJ58k).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _DetectSpecifiedLauncherAsync_d__2>(ref _u__, ref this);
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
					hookLoginPage._hookLauncherExecutablePath = result;
					hookLoginPage.UpdateLauncherSetupStatus();
					hookLoginPage.UpdateHookLoginButtonState();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "DetectSpecifiedLauncherAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.LauncherSetup.cs", 27);
					hookLoginPage.LauncherSetupStatusText.Text = "自动检测失败：" + ex.Message + "。请使用本页指定下载入口安装后重试。";
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
	private struct _HookInstallButton_Click_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private string _launcherPath_5__2;

		private bool _started_5__3;

		private TaskAwaiter __u__1;

		private TaskAwaiter<Ayjhv8f5JJRpAIerOZpd> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0380: Unknown result type (might be due to invalid IL or missing references)
			//IL_0381: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00fa;
				}
				if ((uint)(num - 2) <= 1u)
				{
					goto IL_0341;
				}
				if (!hookLoginPage._hookInstallInProgress && !hookLoginPage._hookLoginInProgress && !hookLoginPage._launcherUpdateInProgress)
				{
					object selectedItem = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
					object obj = ((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
					_launcherPath_5__2 = ((obj != null) ? ((NYI398f5COw5dgT3xbBV)obj).ExecutablePath : null) ?? hookLoginPage._hookLauncherExecutablePath ?? hookLoginPage._hookBridgeInstaller.QR4CTEJ58k();
					if (p7LWrnmxAeJORbM9fVd.uqZmssXTy3(_launcherPath_5__2))
					{
						hookLoginPage._hookLauncherExecutablePath = _launcherPath_5__2;
						hookLoginPage._hookInstallInProgress = true;
						hookLoginPage._hookReadyProcessId = null;
						hookLoginPage.HookChannelStatusText.Text = "正在关闭指定网易启动器…";
						hookLoginPage.UpdateHookLoginButtonState();
						_started_5__3 = false;
						goto IL_00fa;
					}
					hookLoginPage.HookChannelStatusText.Text = "必须先安装本页提供的指定网易启动器，再检测安装并安装 Hook";
					AppShell.Error("必须先安装本页提供的指定网易启动器，再检测安装并安装 Hook");
				}
				goto end_IL_0011;
				IL_0341:
				TaskAwaiter _u__ = default;
				try
				{
					if (num != 2)
					{
						if (num == 3)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_041e;
						}
						_u__ = global::System.Threading.Tasks.Task.Delay(3500, hookLoginPage._hookPageCts.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookInstallButton_Click_d__33>(ref _u__, ref this);
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
					_u__ = hookLoginPage.RefreshHookProcessesAsync(hookLoginPage._hookPageCts.Token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 3);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookInstallButton_Click_d__33>(ref _u__, ref this);
						return;
					}
					goto IL_041e;
					IL_041e:
					_u__.GetResult();
				}
				catch (OperationCanceledException)
				{
				}
				goto end_IL_0011;
				IL_00fa:
				try
				{
					TaskAwaiter<Ayjhv8f5JJRpAIerOZpd> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter<Ayjhv8f5JJRpAIerOZpd>);
							num = (__1__state = -1);
							goto IL_0217;
						}
						string launcherPath = _launcherPath_5__2;
						CancellationTokenSource? hookPageCts = hookLoginPage._hookPageCts;
						_u__ = TryStopLauncherAsync(launcherPath, (hookPageCts != null) ? hookPageCts.Token : CancellationToken.None).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookInstallButton_Click_d__33>(ref _u__, ref this);
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
					hookLoginPage.HookChannelStatusText.Text = "正在安装 HookBridge…";
					EXYCaACFeHnhL7iYDy3 hookBridgeInstaller = hookLoginPage._hookBridgeInstaller;
					string text = _launcherPath_5__2;
					CancellationTokenSource? hookPageCts2 = hookLoginPage._hookPageCts;
					_u__2 = hookBridgeInstaller.InxCMfjUOI(text, (hookPageCts2 != null) ? hookPageCts2.Token : CancellationToken.None).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Ayjhv8f5JJRpAIerOZpd>, _HookInstallButton_Click_d__33>(ref _u__2, ref this);
						return;
					}
					goto IL_0217;
					IL_0217:
					Ayjhv8f5JJRpAIerOZpd result = _u__2.GetResult();
					if (result.Success)
					{
						_started_5__3 = TryStartLauncher(_launcherPath_5__2);
						hookLoginPage.HookChannelStatusText.Text = (_started_5__3 ? "HookBridge 已安装，正在启动指定网易启动器…" : result.Message);
						if (_started_5__3)
						{
							AppShell.Success("HookBridge 已安装，正在启动指定网易启动器");
						}
						else
						{
							AppShell.Info(result.Message);
						}
					}
					else
					{
						hookLoginPage.HookChannelStatusText.Text = result.Message;
						AppShell.Error(result.Message);
					}
				}
				catch (OperationCanceledException)
				{
					hookLoginPage.HookChannelStatusText.Text = "HookBridge 安装等待已取消";
				}
				catch (global::System.Exception ex3)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex3, "ui-exception", "HookInstallButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.xaml.cs", 339);
					hookLoginPage.HookChannelStatusText.Text = "Hook 安装失败：" + ex3.Message;
					AppShell.Error(hookLoginPage.HookChannelStatusText.Text);
				}
				finally
				{
					if (num < 0)
					{
						hookLoginPage._hookInstallInProgress = false;
						hookLoginPage.UpdateHookLoginButtonState();
					}
				}
				if (_started_5__3 && hookLoginPage._hookPageCts != null)
				{
					goto IL_0341;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_launcherPath_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_launcherPath_5__2 = null;
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
	private struct _HookLoginButton_Click_d__38 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter<QZp6nEf5hixc2uAIZhmg> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_016d;
				}
				NYI398f5COw5dgT3xbBV val = default(NYI398f5COw5dgT3xbBV);
				string text = default(string);
				if (!hookLoginPage._hookLoginInProgress && !hookLoginPage._hookInstallInProgress && !hookLoginPage._launcherUpdateInProgress)
				{
					object selectedItem = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
					val = (NYI398f5COw5dgT3xbBV)((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
					if (val != null && p7LWrnmxAeJORbM9fVd.uqZmssXTy3(val.ExecutablePath) && hookLoginPage._hookReadyProcessId == val.ProcessId)
					{
						string text2 = default(string);
						if (kxbvDW4KnLh4arMZvqe.ec74tl9MBX(hookLoginPage.HookSauthBox.Password, out text, out text2))
						{
							hookLoginPage._hookLoginInProgress = true;
							CancellationTokenSource? hookLoginCts = hookLoginPage._hookLoginCts;
							if (hookLoginCts != null)
							{
								hookLoginCts.Cancel();
							}
							CancellationTokenSource? hookLoginCts2 = hookLoginPage._hookLoginCts;
							if (hookLoginCts2 != null)
							{
								hookLoginCts2.Dispose();
							}
							hookLoginPage._hookLoginCts = (CancellationTokenSource?)((hookLoginPage._hookPageCts != null) ? ((object)CancellationTokenSource.CreateLinkedTokenSource(hookLoginPage._hookPageCts.Token)) : ((object)new CancellationTokenSource()));
							hookLoginPage.UpdateHookLoginButtonState();
							hookLoginPage.HookLoginStatusText.Text = $"正在向 PID {val.ProcessId} 发送登录请求";
							hookLoginPage.ResetHookLoginResult();
							goto IL_016d;
						}
						hookLoginPage.HookLoginStatusText.Text = text2;
						AppShell.Error(text2);
					}
				}
				goto end_IL_0011;
				IL_016d:
					text = default;
					val = default;
				try
				{
					TaskAwaiter<QZp6nEf5hixc2uAIZhmg> _u__ = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<QZp6nEf5hixc2uAIZhmg>);
							num = (__1__state = -1);
							goto IL_02b6;
						}
						_u__ = hookLoginPage._hookPipeClient.LoginAsync(val.ProcessId, text, hookLoginPage._hookLoginCts.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QZp6nEf5hixc2uAIZhmg>, _HookLoginButton_Click_d__38>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<QZp6nEf5hixc2uAIZhmg>);
						num = (__1__state = -1);
					}
					QZp6nEf5hixc2uAIZhmg result = _u__.GetResult();
					if (result != null && !result.Success && string.Equals(result.Code, "restarting", (StringComparison)4))
					{
						hookLoginPage.HookSauthBox.Password = string.Empty;
						hookLoginPage._hookReadyProcessId = null;
						hookLoginPage.HookLoginStatusText.Text = "启动器重启中，登录将在启动时自动注入…";
						_u__ = hookLoginPage.WaitForRestartedLoginAsync(result.TransactionId, hookLoginPage._hookLoginCts.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QZp6nEf5hixc2uAIZhmg>, _HookLoginButton_Click_d__38>(ref _u__, ref this);
							return;
						}
						goto IL_02b6;
					}
					goto IL_02bf;
					IL_02bf:
					if (result != null && result.Success)
					{
						hookLoginPage.HookSauthBox.Password = string.Empty;
						hookLoginPage.HookLoginStatusText.Text = result.Message;
						hookLoginPage.ShowHookLoginResult(result);
						AppShell.Success(result.Message);
					}
					else
					{
						hookLoginPage.HookLoginStatusText.Text = ((result == null || string.IsNullOrWhiteSpace(result.Message)) ? "Hook 登录失败或超时" : result.Message);
						AppShell.Error(hookLoginPage.HookLoginStatusText.Text);
					}
					goto end_IL_016d;
					IL_02b6:
					result = _u__.GetResult();
					goto IL_02bf;
					end_IL_016d:;
				}
				catch (OperationCanceledException)
				{
					hookLoginPage.HookLoginStatusText.Text = "Hook 登录已取消";
				}
				catch (global::System.Exception ex2)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "HookLoginButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.xaml.cs", 506);
					hookLoginPage.HookLoginStatusText.Text = "Hook 登录通信异常";
					AppShell.Error("Hook 登录通信异常：" + ex2.Message);
				}
				finally
				{
					if (num < 0)
					{
						text = string.Empty;
						hookLoginPage._hookLoginInProgress = false;
						CancellationTokenSource? hookLoginCts3 = hookLoginPage._hookLoginCts;
						if (hookLoginCts3 != null)
						{
							hookLoginCts3.Dispose();
						}
						hookLoginPage._hookLoginCts = null;
						hookLoginPage.UpdateHookLoginButtonState();
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
	private struct _HookProcessComboBox_SelectionChanged_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00b7;
				}
				if (!hookLoginPage._hookUpdatingSelection && hookLoginPage._hookPageCts != null)
				{
					object selectedItem = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
					NYI398f5COw5dgT3xbBV val = (NYI398f5COw5dgT3xbBV)((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
					if (val != null)
					{
						hookLoginPage._hookLauncherExecutablePath = val.ExecutablePath;
					}
					_u__ = hookLoginPage.ProbeSelectedHookAsync(hookLoginPage._hookPageCts.Token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookProcessComboBox_SelectionChanged_d__28>(ref _u__, ref this);
						return;
					}
					goto IL_00b7;
				}
				goto end_IL_0011;
				IL_00b7:
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
	private struct _HookProcessTimer_Tick_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0084;
				}
				if (hookLoginPage._hookPageCts != null)
				{
					_u__ = hookLoginPage.RefreshHookProcessesAsync(hookLoginPage._hookPageCts.Token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookProcessTimer_Tick_d__26>(ref _u__, ref this);
						return;
					}
					goto IL_0084;
				}
				goto end_IL_0011;
				IL_0084:
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
	private struct _HookRefreshButton_Click_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					_u__ = hookLoginPage.DetectSpecifiedLauncherAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookRefreshButton_Click_d__27>(ref _u__, ref this);
						return;
					}
					goto IL_007a;
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007a;
				case 1:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00e3;
				case 2:
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_00e3:
					_u__.GetResult();
					goto end_IL_0011;
					IL_007a:
					_u__.GetResult();
					if (hookLoginPage._hookPageCts == null)
					{
						_u__ = hookLoginPage.StartMonitoringAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookRefreshButton_Click_d__27>(ref _u__, ref this);
							return;
						}
						goto IL_00e3;
					}
					_u__ = hookLoginPage.RefreshHookProcessesAsync(hookLoginPage._hookPageCts.Token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _HookRefreshButton_Click_d__27>(ref _u__, ref this);
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
	private struct _OnNavigatedTo_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		public NavigationEventArgs e;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					hookLoginPage.__n__0(e);
					_u__ = hookLoginPage.StartMonitoringAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__21>(ref _u__, ref this);
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
	private struct _OpenLauncherDirectory_Click_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Expected O, but got Unknown
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = hookLoginPage.DetectSpecifiedLauncherAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OpenLauncherDirectory_Click_d__6>(ref _u__, ref this);
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
					if (!p7LWrnmxAeJORbM9fVd.uqZmssXTy3(hookLoginPage._hookLauncherExecutablePath))
					{
						throw new InvalidOperationException("未找到指定启动器，请先使用本页下载入口安装。");
					}
					Process.Start(new ProcessStartInfo(System.IO.Path.GetDirectoryName(hookLoginPage._hookLauncherExecutablePath))
					{
						UseShellExecute = true
					});
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "OpenLauncherDirectory_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.LauncherSetup.cs", 105);
					AppShell.Error("无法打开指定启动器安装目录：" + ex.Message);
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
	private struct _ProbeSelectedHookAsync_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		public CancellationToken cancellationToken;

		private NYI398f5COw5dgT3xbBV _selected_5__2;

		private int _processId_5__3;

		private TaskAwaiter<QZp6nEf5hixc2uAIZhmg> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter<QZp6nEf5hixc2uAIZhmg> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<QZp6nEf5hixc2uAIZhmg>);
					num = (__1__state = -1);
					goto IL_0115;
				}
				object selectedItem = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
				_selected_5__2 = (NYI398f5COw5dgT3xbBV)((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
				if (_selected_5__2 != null)
				{
					_processId_5__3 = _selected_5__2.ProcessId;
					hookLoginPage.HookChannelStatusText.Text = $"正在检查 PID {_processId_5__3} 的 Hook 通道";
					_u__ = hookLoginPage._hookPipeClient.PingAsync(_processId_5__3, cancellationToken).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<QZp6nEf5hixc2uAIZhmg>, _ProbeSelectedHookAsync_d__30>(ref _u__, ref this);
						return;
					}
					goto IL_0115;
				}
				hookLoginPage._hookReadyProcessId = null;
				hookLoginPage.SetHookStatusDot(ready: false);
				hookLoginPage.UpdateHookLoginButtonState();
				goto end_IL_0011;
				IL_0115:
				QZp6nEf5hixc2uAIZhmg result = _u__.GetResult();
				object selectedItem2 = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
				object obj = ((selectedItem2 is NYI398f5COw5dgT3xbBV) ? selectedItem2 : null);
				if (obj != null && ((NYI398f5COw5dgT3xbBV)obj).ProcessId == _processId_5__3)
				{
					if (result.Success)
					{
						hookLoginPage._hookReadyProcessId = _processId_5__3;
						hookLoginPage.HookChannelStatusText.Text = (string.IsNullOrWhiteSpace(result.BridgeVersion) ? $"PID {_processId_5__3} | Hook 通道已就绪" : $"PID {_processId_5__3} | HookBridge {result.BridgeVersion}");
						hookLoginPage.SetHookStatusDot(ready: true);
					}
					else
					{
						hookLoginPage._hookReadyProcessId = null;
						string text = (hookLoginPage._hookBridgeInstaller.SmeCNw8dYI(_selected_5__2.ExecutablePath) ? result.Message : "Hook 信任信息已过期，请点击“安装/更新 Hook”");
						hookLoginPage.HookChannelStatusText.Text = $"PID {_processId_5__3} | {text}";
						hookLoginPage.SetHookStatusDot(ready: false);
					}
					hookLoginPage.UpdateHookLoginButtonState();
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_selected_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_selected_5__2 = null;
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
	private struct _RefreshHookProcessesAsync_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		public CancellationToken cancellationToken;

		private int? _selectedPid_5__2;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<NYI398f5COw5dgT3xbBV>> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_035e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0051;
				}
				if (!hookLoginPage._hookRefreshInProgress && !hookLoginPage._hookLoginInProgress && !hookLoginPage._hookInstallInProgress && !hookLoginPage._launcherUpdateInProgress)
				{
					hookLoginPage._hookRefreshInProgress = true;
					goto IL_0051;
				}
				goto end_IL_0011;
				IL_0051:
				try
				{
					TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<NYI398f5COw5dgT3xbBV>> _u__2;
					TaskAwaiter _u__ = default;
					global::System.Collections.Generic.IReadOnlyList<NYI398f5COw5dgT3xbBV> result;
					object selectedItem3;
					NYI398f5COw5dgT3xbBV val = default;
					switch (num)
					{
					default:
					{
						object selectedItem = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
						object obj = ((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
						_selectedPid_5__2 = ((obj != null) ? new int?(((NYI398f5COw5dgT3xbBV)obj).ProcessId) : ((int?)null));
						_u__2 = hookLoginPage._hookProcessDiscovery.C374grMnWX(cancellationToken).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<NYI398f5COw5dgT3xbBV>>, _RefreshHookProcessesAsync_d__29>(ref _u__2, ref this);
							return;
						}
						goto IL_00fe;
					}
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<NYI398f5COw5dgT3xbBV>>);
						num = (__1__state = -1);
						goto IL_00fe;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_02d5;
					case 2:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_00fe:
						result = _u__2.GetResult();
						cancellationToken.ThrowIfCancellationRequested();
						hookLoginPage._hookUpdatingSelection = true;
						try
						{
							__c__DisplayClass29_0 _c__DisplayClass29_ = (__c__DisplayClass29_0)new __c__DisplayClass29_0();
							((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses).Clear();
							global::System.Collections.Generic.IEnumerator<NYI398f5COw5dgT3xbBV> enumerator = ((global::System.Collections.Generic.IEnumerable<NYI398f5COw5dgT3xbBV>)result).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
								{
									NYI398f5COw5dgT3xbBV current = enumerator.Current;
									((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses).Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator)?.Dispose();
								}
							}
							ComboBox hookProcessComboBox = hookLoginPage.HookProcessComboBox;
							object selectedItem2;
							if (!_selectedPid_5__2.HasValue)
							{
								selectedItem2 = ((((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses).Count == 1) ? ((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses)[0] : null);
							}
							else
							{
								_c__DisplayClass29_.existingPid = _selectedPid_5__2.GetValueOrDefault();
								selectedItem2 = Enumerable.FirstOrDefault<NYI398f5COw5dgT3xbBV>((global::System.Collections.Generic.IEnumerable<NYI398f5COw5dgT3xbBV>)hookLoginPage._hookProcesses, (Func<NYI398f5COw5dgT3xbBV, bool>)_c__DisplayClass29_._RefreshHookProcessesAsync_b__0);
							}
							((Selector)hookProcessComboBox).SelectedItem = selectedItem2;
						}
						finally
						{
							if (num < 0)
							{
								hookLoginPage._hookUpdatingSelection = false;
							}
						}
						selectedItem3 = ((Selector)hookLoginPage.HookProcessComboBox).SelectedItem;
						val = (NYI398f5COw5dgT3xbBV)((selectedItem3 is NYI398f5COw5dgT3xbBV) ? selectedItem3 : null);
						if (val != null)
						{
							hookLoginPage._hookLauncherExecutablePath = val.ExecutablePath;
						}
						else if (((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses).Count > 0)
						{
							hookLoginPage._hookLauncherExecutablePath = ((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses)[0].ExecutablePath;
						}
						if (((Collection<NYI398f5COw5dgT3xbBV>)(object)hookLoginPage._hookProcesses).Count == 0)
						{
							hookLoginPage._hookReadyProcessId = null;
							if (global::System.DateTime.UtcNow >= hookLoginPage._nextLauncherDetectionUtc)
							{
								_u__ = hookLoginPage.DetectSpecifiedLauncherAsync().GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshHookProcessesAsync_d__29>(ref _u__, ref this);
									return;
								}
								goto IL_02d5;
							}
							goto IL_02dc;
						}
						if (((Selector)hookLoginPage.HookProcessComboBox).SelectedItem != null)
						{
							hookLoginPage.UpdateLauncherSetupStatus();
							_u__ = hookLoginPage.ProbeSelectedHookAsync(cancellationToken).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshHookProcessesAsync_d__29>(ref _u__, ref this);
								return;
							}
							break;
						}
						hookLoginPage._hookReadyProcessId = null;
						hookLoginPage.HookChannelStatusText.Text = "检测到多个 x86 实例，请选择目标";
						hookLoginPage.SetHookStatusDot(ready: false);
						hookLoginPage.UpdateHookLoginButtonState();
						goto end_IL_0051;
						IL_02d5:
						_u__.GetResult();
						goto IL_02dc;
						IL_02dc:
						hookLoginPage.HookChannelStatusText.Text = (p7LWrnmxAeJORbM9fVd.uqZmssXTy3(hookLoginPage._hookLauncherExecutablePath) ? "已检测到指定启动器，安装 Hook 后将自动启动" : "请先下载并安装本页提供的指定启动器");
						hookLoginPage.SetHookStatusDot(ready: false);
						hookLoginPage.UpdateHookLoginButtonState();
						goto end_IL_0051;
					}
					_u__.GetResult();
					end_IL_0051:;
				}
				catch (OperationCanceledException)
				{
				}
				finally
				{
					if (num < 0)
					{
						hookLoginPage._hookRefreshInProgress = false;
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
	private struct _StartMonitoringAsync_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Expected O, but got Unknown
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					hookLoginPage.StopMonitoring(clearProcesses: false);
					hookLoginPage._hookPageCts = new CancellationTokenSource();
					hookLoginPage._hookProcessTimer.Start();
					_u__ = hookLoginPage.RefreshHookProcessesAsync(hookLoginPage._hookPageCts.Token).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartMonitoringAsync_d__24>(ref _u__, ref this);
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
	private struct _TryStopLauncherAsync_d__35 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string launcherPath;

		public CancellationToken cancellationToken;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				if (num == 0)
				{
					goto IL_0146;
				}
				string fileNameWithoutExtension = System.IO.Path.GetFileNameWithoutExtension(launcherPath);
				if (!string.IsNullOrWhiteSpace(fileNameWithoutExtension))
				{
					string fullPath = System.IO.Path.GetFullPath(launcherPath);
					bool flag = false;
					try
					{
						Process[] processesByName = Process.GetProcessesByName(fileNameWithoutExtension);
						foreach (Process val in processesByName)
						{
							Process val2 = val;
							try
							{
								ProcessModule mainModule = val.MainModule;
								string text = ((mainModule != null) ? mainModule.FileName : null);
								if (!string.IsNullOrWhiteSpace(text) && string.Equals(System.IO.Path.GetFullPath(text), fullPath, (StringComparison)5))
								{
									val.Kill();
									flag = true;
								}
							}
							catch (global::System.Exception ex) when (((ex is Win32Exception || ex is InvalidOperationException || ex is NotSupportedException) ? 1 : 0) != 0)
							{
								cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "TryStopLauncherAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.xaml.cs", 413);
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)val2)?.Dispose();
								}
							}
						}
					}
					catch (InvalidOperationException)
					{
					}
					if (flag)
					{
						goto IL_0146;
					}
				}
				goto end_IL_000a;
				IL_0146:
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = global::System.Threading.Tasks.Task.Delay(1200, cancellationToken).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _TryStopLauncherAsync_d__35>(ref _u__, ref this);
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
				catch (OperationCanceledException)
				{
				}
				end_IL_000a:;
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
	private struct _UpdateLauncher_Click_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public HookLoginPage __4__this;

		private string _directory_5__2;

		private Process _updater_5__3;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			HookLoginPage hookLoginPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_004c;
				}
				if (!hookLoginPage._launcherUpdateInProgress && !hookLoginPage._hookInstallInProgress && !hookLoginPage._hookLoginInProgress)
				{
					hookLoginPage._launcherUpdateInProgress = true;
					hookLoginPage.UpdateHookLoginButtonState();
					goto IL_004c;
				}
				goto end_IL_0011;
				IL_004c:
				try
				{
					TaskAwaiter _u__ = default;
					string? hookLauncherExecutablePath;
					CancellationTokenSource? hookPageCts;
					switch (num)
					{
					default:
						_u__ = hookLoginPage.DetectSpecifiedLauncherAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _UpdateLauncher_Click_d__5>(ref _u__, ref this);
							return;
						}
						goto IL_00b5;
					case 0:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00b5;
					case 1:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0160;
					case 2:
						break;
						IL_0160:
						_u__.GetResult();
						_updater_5__3 = Process.Start(new ProcessStartInfo(System.IO.Path.Combine(_directory_5__2, "Updater\\MCLauncherUpdater.exe"))
						{
							WorkingDirectory = System.IO.Path.Combine(_directory_5__2, "Updater"),
							UseShellExecute = true
						}) ?? throw new InvalidOperationException("无法启动指定启动器的更新程序。");
						break;
						IL_00b5:
						_u__.GetResult();
						if (!p7LWrnmxAeJORbM9fVd.uqZmssXTy3(hookLoginPage._hookLauncherExecutablePath))
						{
							throw new InvalidOperationException("请先通过本页指定下载入口安装网易启动器。");
						}
						_directory_5__2 = System.IO.Path.GetDirectoryName(hookLoginPage._hookLauncherExecutablePath);
						hookLauncherExecutablePath = hookLoginPage._hookLauncherExecutablePath;
						hookPageCts = hookLoginPage._hookPageCts;
						_u__ = TryStopLauncherAsync(hookLauncherExecutablePath, (hookPageCts != null) ? hookPageCts.Token : CancellationToken.None).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _UpdateLauncher_Click_d__5>(ref _u__, ref this);
							return;
						}
						goto IL_0160;
					}
					try
					{
						if (num != 2)
						{
							hookLoginPage.LauncherSetupStatusText.Text = "请在更新器中完成检查或更新。更新完成并关闭启动器后，点击“安装/更新 Hook”。";
							_u__ = _updater_5__3.WaitForExitAsync(default(CancellationToken)).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _UpdateLauncher_Click_d__5>(ref _u__, ref this);
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
						hookLoginPage._hookReadyProcessId = null;
						hookLoginPage.SetHookStatusDot(ready: false);
						hookLoginPage.HookChannelStatusText.Text = "更新器已退出；请确认更新完成，再安装/更新 Hook";
					}
					finally
					{
						if (num < 0 && _updater_5__3 != null)
						{
							((global::System.IDisposable)_updater_5__3).Dispose();
						}
					}
					_directory_5__2 = null;
					_updater_5__3 = null;
				}
				catch (OperationCanceledException)
				{
					AppShell.Info("已取消启动更新器");
				}
				catch (global::System.Exception ex2)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "UpdateLauncher_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.LauncherSetup.cs", 83);
					AppShell.Error("启动器更新失败：" + ex2.Message);
				}
				finally
				{
					if (num < 0)
					{
						hookLoginPage._launcherUpdateInProgress = false;
						hookLoginPage.UpdateHookLoginButtonState();
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

	private global::System.DateTime _nextLauncherDetectionUtc;

	private bool _launcherUpdateInProgress;

	private readonly IYgTOL4IxURSpAJKOJ6 _hookProcessDiscovery;

	private readonly M0UKkE4VRxo2p0mlpaw _hookPipeClient;

	private readonly EXYCaACFeHnhL7iYDy3 _hookBridgeInstaller;

	private readonly ObservableCollection<NYI398f5COw5dgT3xbBV> _hookProcesses;

	private readonly DispatcherTimer _hookProcessTimer;

	private CancellationTokenSource? _hookPageCts;

	private CancellationTokenSource? _hookLoginCts;

	private bool _hookRefreshInProgress;

	private bool _hookLoginInProgress;

	private bool _hookInstallInProgress;

	private bool _hookUpdatingSelection;

	private int? _hookReadyProcessId;

	private string? _hookLauncherExecutablePath;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ScrollViewer HookResultEmpty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel HookResultPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border HookResultBadge;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookResTime;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookResBridge;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookResPid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookResAid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon HookResultIcon;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookResultTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LauncherSetupStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LauncherUpdateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox HookSauthBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookLoginStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button HookInstallButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button HookLoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Ellipse HookStatusDot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock HookChannelStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox HookProcessComboBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button HookRefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task DetectSpecifiedLauncherAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DetectSpecifiedLauncherAsync_d__2 detectSpecifiedLauncherAsync_d__ = default(_DetectSpecifiedLauncherAsync_d__2);
		detectSpecifiedLauncherAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		detectSpecifiedLauncherAsync_d__.__4__this = this;
		detectSpecifiedLauncherAsync_d__.__1__state = -1;
		detectSpecifiedLauncherAsync_d__.__t__builder.Start<_DetectSpecifiedLauncherAsync_d__2>(ref detectSpecifiedLauncherAsync_d__);
		return detectSpecifiedLauncherAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateLauncherSetupStatus()
	{
		LauncherSetupStatusText.Text = (p7LWrnmxAeJORbM9fVd.uqZmssXTy3(_hookLauncherExecutablePath) ? ("已检测到指定启动器：" + _hookLauncherExecutablePath) : "尚未检测到指定启动器。请点击下方下载按钮完成安装；安装后会自动检测，无需搜索文件。");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void DownloadLauncher_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		try
		{
			Process.Start(new ProcessStartInfo("https://adl.netease.com/d/g/mc/c/pe?type=windows")
			{
				UseShellExecute = true
			});
			LauncherSetupStatusText.Text = "已打开指定网易 x86 启动器下载入口。请运行下载的安装包完成安装，完成后返回此页。";
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "DownloadLauncher_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.LauncherSetup.cs", 48);
			AppShell.Error("无法打开指定启动器下载入口：" + ex.Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void UpdateLauncher_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_UpdateLauncher_Click_d__5 updateLauncher_Click_d__ = default(_UpdateLauncher_Click_d__5);
		updateLauncher_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		updateLauncher_Click_d__.__4__this = this;
		updateLauncher_Click_d__.__1__state = -1;
		updateLauncher_Click_d__.__t__builder.Start<_UpdateLauncher_Click_d__5>(ref updateLauncher_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenLauncherDirectory_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenLauncherDirectory_Click_d__6 openLauncherDirectory_Click_d__ = default(_OpenLauncherDirectory_Click_d__6);
		openLauncherDirectory_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openLauncherDirectory_Click_d__.__4__this = this;
		openLauncherDirectory_Click_d__.__1__state = -1;
		openLauncherDirectory_Click_d__.__t__builder.Start<_OpenLauncherDirectory_Click_d__6>(ref openLauncherDirectory_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public HookLoginPage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		_hookProcessDiscovery = new IYgTOL4IxURSpAJKOJ6(true);
		_hookPipeClient = new M0UKkE4VRxo2p0mlpaw();
		_hookBridgeInstaller = new EXYCaACFeHnhL7iYDy3();
		_hookProcesses = new ObservableCollection<NYI398f5COw5dgT3xbBV>();
		_hookProcessTimer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(1.0)
		};
		InitializeComponent();
		((ItemsControl)HookProcessComboBox).ItemsSource = _hookProcesses;
		_hookProcessTimer.Tick += HookProcessTimer_Tick;
		_hookLauncherExecutablePath = _hookBridgeInstaller.QR4CTEJ58k();
		UpdateLauncherSetupStatus();
		UpdateHookLoginButtonState();
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__21 onNavigatedTo_d__ = default(_OnNavigatedTo_d__21);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__21>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	protected override void OnNavigatedFrom(NavigationEventArgs e)
	{
		base.OnNavigatedFrom(e);
		StopMonitoring(clearProcesses: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		StopMonitoring(clearProcesses: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task StartMonitoringAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StartMonitoringAsync_d__24 startMonitoringAsync_d__ = default(_StartMonitoringAsync_d__24);
		startMonitoringAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		startMonitoringAsync_d__.__4__this = this;
		startMonitoringAsync_d__.__1__state = -1;
		startMonitoringAsync_d__.__t__builder.Start<_StartMonitoringAsync_d__24>(ref startMonitoringAsync_d__);
		return startMonitoringAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StopMonitoring(bool clearProcesses)
	{
		_hookProcessTimer.Stop();
		CancellationTokenSource? hookLoginCts = _hookLoginCts;
		if (hookLoginCts != null)
		{
			hookLoginCts.Cancel();
		}
		CancellationTokenSource? hookLoginCts2 = _hookLoginCts;
		if (hookLoginCts2 != null)
		{
			hookLoginCts2.Dispose();
		}
		_hookLoginCts = null;
		CancellationTokenSource? hookPageCts = _hookPageCts;
		if (hookPageCts != null)
		{
			hookPageCts.Cancel();
		}
		CancellationTokenSource? hookPageCts2 = _hookPageCts;
		if (hookPageCts2 != null)
		{
			hookPageCts2.Dispose();
		}
		_hookPageCts = null;
		_hookReadyProcessId = null;
		_hookLoginInProgress = false;
		HookSauthBox.Password = string.Empty;
		if (clearProcesses)
		{
			((Collection<NYI398f5COw5dgT3xbBV>)(object)_hookProcesses).Clear();
			((Selector)HookProcessComboBox).SelectedItem = null;
		}
		UpdateHookLoginButtonState();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HookProcessTimer_Tick(object? sender, object e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HookProcessTimer_Tick_d__26 hookProcessTimer_Tick_d__ = default(_HookProcessTimer_Tick_d__26);
		hookProcessTimer_Tick_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		hookProcessTimer_Tick_d__.__4__this = this;
		hookProcessTimer_Tick_d__.__1__state = -1;
		hookProcessTimer_Tick_d__.__t__builder.Start<_HookProcessTimer_Tick_d__26>(ref hookProcessTimer_Tick_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HookRefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HookRefreshButton_Click_d__27 hookRefreshButton_Click_d__ = default(_HookRefreshButton_Click_d__27);
		hookRefreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		hookRefreshButton_Click_d__.__4__this = this;
		hookRefreshButton_Click_d__.__1__state = -1;
		hookRefreshButton_Click_d__.__t__builder.Start<_HookRefreshButton_Click_d__27>(ref hookRefreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HookProcessComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HookProcessComboBox_SelectionChanged_d__28 hookProcessComboBox_SelectionChanged_d__ = default(_HookProcessComboBox_SelectionChanged_d__28);
		hookProcessComboBox_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		hookProcessComboBox_SelectionChanged_d__.__4__this = this;
		hookProcessComboBox_SelectionChanged_d__.__1__state = -1;
		hookProcessComboBox_SelectionChanged_d__.__t__builder.Start<_HookProcessComboBox_SelectionChanged_d__28>(ref hookProcessComboBox_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshHookProcessesAsync(CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshHookProcessesAsync_d__29 refreshHookProcessesAsync_d__ = default(_RefreshHookProcessesAsync_d__29);
		refreshHookProcessesAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshHookProcessesAsync_d__.__4__this = this;
		refreshHookProcessesAsync_d__.cancellationToken = cancellationToken;
		refreshHookProcessesAsync_d__.__1__state = -1;
		refreshHookProcessesAsync_d__.__t__builder.Start<_RefreshHookProcessesAsync_d__29>(ref refreshHookProcessesAsync_d__);
		return refreshHookProcessesAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ProbeSelectedHookAsync(CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_ProbeSelectedHookAsync_d__30 probeSelectedHookAsync_d__ = default(_ProbeSelectedHookAsync_d__30);
		probeSelectedHookAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		probeSelectedHookAsync_d__.__4__this = this;
		probeSelectedHookAsync_d__.cancellationToken = cancellationToken;
		probeSelectedHookAsync_d__.__1__state = -1;
		probeSelectedHookAsync_d__.__t__builder.Start<_ProbeSelectedHookAsync_d__30>(ref probeSelectedHookAsync_d__);
		return probeSelectedHookAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetHookStatusDot(bool ready)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (HookStatusDot != null)
		{
			((Shape)HookStatusDot).Fill = (Brush)((!ready) ? ((object)null) : ((object)new SolidColorBrush(Color.FromArgb((byte)255, (byte)62, (byte)180, (byte)137))));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateHookLoginButtonState()
	{
		if (HookLoginButton == null || HookSauthBox == null || HookProcessComboBox == null)
		{
			return;
		}
		Button hookLoginButton = HookLoginButton;
		int isEnabled;
		if (!_hookLoginInProgress && !_hookInstallInProgress && !_launcherUpdateInProgress)
		{
			object selectedItem = ((Selector)HookProcessComboBox).SelectedItem;
			NYI398f5COw5dgT3xbBV val = (NYI398f5COw5dgT3xbBV)((selectedItem is NYI398f5COw5dgT3xbBV) ? selectedItem : null);
			if (val != null && _hookReadyProcessId == val.ProcessId)
			{
				isEnabled = ((!string.IsNullOrWhiteSpace(HookSauthBox.Password)) ? 1 : 0);
				goto IL_00a1;
			}
		}
		isEnabled = 0;
		goto IL_00a1;
		IL_00a1:
		((Control)hookLoginButton).IsEnabled = (byte)isEnabled != 0;
		((Control)HookInstallButton).IsEnabled = !_hookLoginInProgress && !_hookInstallInProgress && !_launcherUpdateInProgress && p7LWrnmxAeJORbM9fVd.uqZmssXTy3(_hookLauncherExecutablePath);
		((Control)LauncherUpdateButton).IsEnabled = ((Control)HookInstallButton).IsEnabled && !_launcherUpdateInProgress;
		((Control)HookRefreshButton).IsEnabled = !_hookLoginInProgress && !_hookInstallInProgress && !_launcherUpdateInProgress;
		((Control)HookProcessComboBox).IsEnabled = !_hookLoginInProgress && !_hookInstallInProgress && !_launcherUpdateInProgress;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HookInstallButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HookInstallButton_Click_d__33 hookInstallButton_Click_d__ = default(_HookInstallButton_Click_d__33);
		hookInstallButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		hookInstallButton_Click_d__.__4__this = this;
		hookInstallButton_Click_d__.__1__state = -1;
		hookInstallButton_Click_d__.__t__builder.Start<_HookInstallButton_Click_d__33>(ref hookInstallButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryStartLauncher(string launcherPath)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = launcherPath,
				WorkingDirectory = (System.IO.Path.GetDirectoryName(launcherPath) ?? string.Empty),
				UseShellExecute = true
			});
			return true;
		}
		catch (global::System.Exception ex) when (((ex is Win32Exception || ex is FileNotFoundException || ex is InvalidOperationException) ? 1 : 0) != 0)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "TryStartLauncher", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\HookLoginPage.xaml.cs", 377);
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task TryStopLauncherAsync(string launcherPath, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_TryStopLauncherAsync_d__35 tryStopLauncherAsync_d__ = default(_TryStopLauncherAsync_d__35);
		tryStopLauncherAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		tryStopLauncherAsync_d__.launcherPath = launcherPath;
		tryStopLauncherAsync_d__.cancellationToken = cancellationToken;
		tryStopLauncherAsync_d__.__1__state = -1;
		tryStopLauncherAsync_d__.__t__builder.Start<_TryStopLauncherAsync_d__35>(ref tryStopLauncherAsync_d__);
		return tryStopLauncherAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HookSauthBox_PasswordChanged(object sender, RoutedEventArgs e)
	{
		UpdateHookLoginButtonState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HookClearButton_Click(object sender, RoutedEventArgs e)
	{
		HookSauthBox.Password = string.Empty;
		ResetHookLoginResult();
		TextBlock hookLoginStatusText = HookLoginStatusText;
		int? hookReadyProcessId = _hookReadyProcessId;
		hookLoginStatusText.Text = ((!hookReadyProcessId.HasValue) ? "Hook 通道未就绪" : "Hook 通道已就绪");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void HookLoginButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_HookLoginButton_Click_d__38 hookLoginButton_Click_d__ = default(_HookLoginButton_Click_d__38);
		hookLoginButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		hookLoginButton_Click_d__.__4__this = this;
		hookLoginButton_Click_d__.__1__state = -1;
		hookLoginButton_Click_d__.__t__builder.Start<_HookLoginButton_Click_d__38>(ref hookLoginButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<QZp6nEf5hixc2uAIZhmg?> WaitForRestartedLoginAsync(string transactionId, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		for (int i = 0; i < 90; i++)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await global::System.Threading.Tasks.Task.Delay(500, cancellationToken);
			NYI398f5COw5dgT3xbBV val = Enumerable.FirstOrDefault<NYI398f5COw5dgT3xbBV>((global::System.Collections.Generic.IEnumerable<NYI398f5COw5dgT3xbBV>)(await _hookProcessDiscovery.C374grMnWX(cancellationToken)));
			if (val == null)
			{
				HookLoginStatusText.Text = "等待启动器重启…";
				continue;
			}
			if (!(await _hookPipeClient.PingAsync(val.ProcessId, cancellationToken)).Success)
			{
				HookLoginStatusText.Text = $"启动器已重启(PID {val.ProcessId})，等待 Hook 通道…";
				continue;
			}
			SelectHookProcess(val);
			QZp6nEf5hixc2uAIZhmg val2 = await _hookPipeClient.ResultAsync(val.ProcessId, transactionId, cancellationToken);
			if (string.Equals(val2.Code, "pending", (StringComparison)4) || string.Equals(val2.Code, "transaction_mismatch", (StringComparison)4))
			{
				HookLoginStatusText.Text = $"PID {val.ProcessId} | 登录注入中…";
				continue;
			}
			return val2;
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SelectHookProcess(NYI398f5COw5dgT3xbBV target)
	{
		__c__DisplayClass40_0 __8_locals6 = (__c__DisplayClass40_0)new __c__DisplayClass40_0();
		__8_locals6.target = target;
		_hookUpdatingSelection = true;
		try
		{
			NYI398f5COw5dgT3xbBV val = Enumerable.FirstOrDefault<NYI398f5COw5dgT3xbBV>((global::System.Collections.Generic.IEnumerable<NYI398f5COw5dgT3xbBV>)_hookProcesses, (Func<NYI398f5COw5dgT3xbBV, bool>)([MethodImpl((MethodImplOptions)8)] (NYI398f5COw5dgT3xbBV item) => item.ProcessId == __8_locals6.target.ProcessId));
			if (val == null)
			{
				((Collection<NYI398f5COw5dgT3xbBV>)(object)_hookProcesses).Clear();
				((Collection<NYI398f5COw5dgT3xbBV>)(object)_hookProcesses).Add(__8_locals6.target);
				val = __8_locals6.target;
			}
			((Selector)HookProcessComboBox).SelectedItem = val;
			_hookReadyProcessId = __8_locals6.target.ProcessId;
			_hookLauncherExecutablePath = __8_locals6.target.ExecutablePath;
		}
		finally
		{
			_hookUpdatingSelection = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowHookLoginResult(QZp6nEf5hixc2uAIZhmg result)
	{
		HookResAid.Text = (string.IsNullOrWhiteSpace(result.UserId) ? "--" : result.UserId);
		HookResPid.Text = $"PID {result.ProcessId}";
		HookResBridge.Text = (string.IsNullOrWhiteSpace(result.BridgeVersion) ? "--" : result.BridgeVersion);
		HookResTime.Text = global::System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
		HookResultTitle.Text = (string.IsNullOrWhiteSpace(result.Message) ? "Hook 登录成功" : result.Message);
		((UIElement)HookResultEmpty).Visibility = (Visibility)1;
		((UIElement)HookResultPanel).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetHookLoginResult()
	{
		((UIElement)HookResultPanel).Visibility = (Visibility)1;
		((UIElement)HookResultEmpty).Visibility = (Visibility)0;
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
			Uri val = new Uri("ms-appx:///Views/Pages/HookLoginPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0228: Unknown result type (might be due to invalid IL or missing references)
		//IL_0232: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			HookResultEmpty = CastExtensions.As<ScrollViewer>(target);
			break;
		case 3:
			HookResultPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			HookResultBadge = CastExtensions.As<Border>(target);
			break;
		case 5:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DownloadLauncher_Click);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenLauncherDirectory_Click);
			break;
		case 7:
			HookResTime = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			HookResBridge = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			HookResPid = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			HookResAid = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			HookResultIcon = CastExtensions.As<FontIcon>(target);
			break;
		case 12:
			HookResultTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DownloadLauncher_Click);
			break;
		case 14:
			LauncherSetupStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			LauncherUpdateButton = CastExtensions.As<Button>(target);
			((ButtonBase)LauncherUpdateButton).Click += new RoutedEventHandler(UpdateLauncher_Click);
			break;
		case 16:
			HookSauthBox = CastExtensions.As<PasswordBox>(target);
			HookSauthBox.PasswordChanged += new RoutedEventHandler(HookSauthBox_PasswordChanged);
			break;
		case 17:
			HookLoginStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 18:
			HookInstallButton = CastExtensions.As<Button>(target);
			((ButtonBase)HookInstallButton).Click += new RoutedEventHandler(HookInstallButton_Click);
			break;
		case 19:
			HookLoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)HookLoginButton).Click += new RoutedEventHandler(HookLoginButton_Click);
			break;
		case 20:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(HookClearButton_Click);
			break;
		case 21:
			HookStatusDot = CastExtensions.As<Ellipse>(target);
			break;
		case 22:
			HookChannelStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			HookProcessComboBox = CastExtensions.As<ComboBox>(target);
			((Selector)HookProcessComboBox).SelectionChanged += new SelectionChangedEventHandler(HookProcessComboBox_SelectionChanged);
			break;
		case 24:
			HookRefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)HookRefreshButton).Click += new RoutedEventHandler(HookRefreshButton_Click);
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
	[DebuggerHidden]
	[CompilerGenerated]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

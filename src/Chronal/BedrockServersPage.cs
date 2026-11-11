using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using AHCHY0f012HXIPgw0yYN;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using PW0ZZVfus06wwb9hw2Vi;
using ROZe5Gf1WgRr9IZ64gbr;
using SGLutIO07VZ7bawO9WX;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using fZGimHf0suVRPkaXFQcr;
using knGiRcfu9DhbMgArQGtn;
using qS8vkpL43FlTMgcj0rgs;
using r7Ie1ifM7owYurGstPtD;
using upxeYBfDKCIugOs5dAeA;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class BedrockServersPage : Page, global::System.IDisposable, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockServersPage_Loaded_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockServersPage __4__this;

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
			BedrockServersPage bedrockServersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockServersPage.RefreshAndroidTouchStatus();
					bedrockServersPage.RefreshSelectedClientStatus();
					_u__ = bedrockServersPage.ServerBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockServersPage_Loaded_d__5>(ref _u__, ref this);
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
	private struct _ServerBrowser_LaunchRequested_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockServersPage __4__this;

		public wjHCLDf1ydVEraHow39U server;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter<XHEDPNfuFO31QfaHLUGP> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0186: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockServersPage bedrockServersPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_005e;
				}
				if (bedrockServersPage._clientService.CurrentSession != null && bedrockServersPage._launchCancellation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_005e;
				}
				if (bedrockServersPage._clientService.CurrentSession == null)
				{
					AppShell.Error("启动失败：未配置游戏身份认证，请先前往账号配置页面完成身份验证");
				}
				goto end_IL_0011;
				IL_005e:
				try
				{
					if ((uint)num > 1u)
					{
						bedrockServersPage._launchCancellation = _cancellation_5__2;
						bedrockServersPage.SetLaunchState(isRunning: true, "正在校验基岩版服务权益", 0.0);
					}
					try
					{
						TaskAwaiter<XHEDPNfuFO31QfaHLUGP> _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<XHEDPNfuFO31QfaHLUGP>);
								num = (__1__state = -1);
								goto IL_01a2;
							}
							_u__2 = BedrockAccessGuard.EnsureAsync(_cancellation_5__2.Token, forceRefresh: true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ServerBrowser_LaunchRequested_d__11>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (_u__2.GetResult())
						{
							Progress<TNGLHufuZJeliMhnBLZ9> val = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)bedrockServersPage.UpdateLaunchProgress);
							_u__ = bedrockServersPage._clientService.XSsXRbeZqIw(server, (IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XHEDPNfuFO31QfaHLUGP>, _ServerBrowser_LaunchRequested_d__11>(ref _u__, ref this);
								return;
							}
							goto IL_01a2;
						}
						bedrockServersPage.SetLaunchState(isRunning: false, "启动已停止：未能通过服务权益校验", 0.0);
						goto end_IL_0087;
						IL_01a2:
						XHEDPNfuFO31QfaHLUGP result = _u__.GetResult();
						bedrockServersPage.SetLaunchState(isRunning: false, $"已启动 PID {result.ProcessId}  ·  RPC {result.LauncherPort}", 100.0);
						if (!result.AndroidTouchEnabled)
						{
							AppShell.Info("本服务器未启用 Android/Touch。游戏内分类与匹配以服务器结果为准");
						}
						else if (result.McpPatchRuntimeCompleted)
						{
							AppShell.Info("内置MCP 入口已执行，Android/Touch 本地 API 已核验；通知可见性和服务器 PE 分类以游戏内结果为准");
						}
						else if (result.McpPatchFilesDeployed)
						{
							AppShell.Warning("内置MCP 未确认生效，游戏保持运行；" + result.McpPatchStatus);
						}
						else if (result.AndroidTouchActivated)
						{
							AppShell.Success("Android/Touch 本地运行时已加载", $"模拟设备：{result.AndroidDeviceName}（{result.AndroidDeviceModel}） · Android {result.AndroidVersion}");
						}
						else
						{
							AppShell.Warning("Android/Touch 本次未确认生效，请查看启动诊断日志");
						}
						if (result.HudAddonSigninRequested)
						{
							AppShell.Success("HudAddon 签到已完成", "已检测到 HudAddon，并发送今日签到请求");
						}
						else
						{
							AppShell.Warning("HudAddon 本次未探测到，未发送每日签到请求");
						}
						AppShell.Success("已启动并进入 " + server.Name);
						end_IL_0087:;
					}
					catch (OperationCanceledException)
					{
						bedrockServersPage.SetLaunchState(isRunning: false, "启动已取消", ((RangeBase)bedrockServersPage.LaunchProgressBar).Value);
						AppShell.Warning("启动已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "ServerBrowser_LaunchRequested", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockServersPage.xaml.cs", 154);
						bedrockServersPage.SetLaunchState(isRunning: false, exceptionDisplayMessage, ((RangeBase)bedrockServersPage.LaunchProgressBar).Value);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockServersPage._launchCancellation == _cancellation_5__2)
							{
								bedrockServersPage._launchCancellation = null;
							}
							bedrockServersPage.ServerBrowser.SetOperationRunning(running: false);
							((Control)bedrockServersPage.CancelLaunchButton).IsEnabled = false;
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
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
	private struct _ServerBrowser_RelayLaunchRequested_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockServersPage __4__this;

		public wjHCLDf1ydVEraHow39U server;

		private CancellationTokenSource _cancellation_5__2;

		private mpVm6bf0F2Qxo2jn2O2u _relayBindScope_5__3;

		private int _relayFrontendProtocol_5__4;

		private TaskAwaiter<bool> __u__1;

		private ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Expected O, but got Unknown
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockServersPage bedrockServersPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_005e;
				}
				if (bedrockServersPage._clientService.CurrentSession != null && bedrockServersPage._relayCancellation == null)
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_005e;
				}
				if (bedrockServersPage._clientService.CurrentSession == null)
				{
					AppShell.Error("代理启动失败：未配置游戏身份认证，请先完成身份验证");
				}
				goto end_IL_0011;
				IL_005e:
				try
				{
					if ((uint)num > 1u)
					{
						bedrockServersPage._relayCancellation = _cancellation_5__2;
						_relayBindScope_5__3 = bedrockServersPage.ServerBrowser.RelayBindScope;
						_relayFrontendProtocol_5__4 = bedrockServersPage.ServerBrowser.RelayFrontendProtocol;
						bedrockServersPage.ServerBrowser.SetRelayRunning(running: true);
					}
					try
					{
						ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
								goto IL_01be;
							}
							_u__2 = BedrockAccessGuard.EnsureAsync(_cancellation_5__2.Token, forceRefresh: true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ServerBrowser_RelayLaunchRequested_d__14>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (_u__2.GetResult())
						{
							_u__ = bedrockServersPage._clientService.Relay.oFmf0gyFDoj(server, _relayBindScope_5__3, _relayFrontendProtocol_5__4, _cancellation_5__2.Token).ConfigureAwait(true).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter, _ServerBrowser_RelayLaunchRequested_d__14>(ref _u__, ref this);
								return;
							}
							goto IL_01be;
						}
						bedrockServersPage.ServerBrowser.SetRelayStatus("代理启动已停止：未能通过服务权益校验");
						goto end_IL_00a0;
						IL_01be:
						xB2S7Ef0a4y25KVIgI8F result = _u__.GetResult();
						string text = (string.IsNullOrWhiteSpace(result.LanAddressText) ? result.LocalAddressText : (result.LocalAddressText + "；局域网 " + result.LanAddressText));
						bedrockServersPage.ServerBrowser.SetRelayStatus($"代理已启动：{text} → {result.RemoteAddressText}（v{result.FrontendProtocol} → v{result.BackendProtocol}）。请使用 BedrockBoot 启动对应国际版客户端");
						AppShell.Success("代理服务已启动", "请使用 BedrockBoot 启动对应国际版客户端，连接地址 " + text);
						end_IL_00a0:;
					}
					catch (OperationCanceledException)
					{
						bedrockServersPage.ServerBrowser.SetRelayStatus("代理启动已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "ServerBrowser_RelayLaunchRequested", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockServersPage.xaml.cs", 238);
						bedrockServersPage.ServerBrowser.SetRelayStatus("代理启动失败：" + exceptionDisplayMessage);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockServersPage._relayCancellation == _cancellation_5__2)
							{
								bedrockServersPage._relayCancellation = null;
							}
							bedrockServersPage.ServerBrowser.SetRelayRunning(running: false);
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
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

	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private CancellationTokenSource? _launchCancellation;

	private CancellationTokenSource? _relayCancellation;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LaunchOperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockServerBrowser ServerBrowser;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchTransferText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar LaunchProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AndroidTouchStatusTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock AndroidTouchStatusDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockServersPage()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		ServerBrowser.Attach(_clientService);
		ServerBrowser.LaunchRequested += ServerBrowser_LaunchRequested;
		ServerBrowser.RelayLaunchRequested += ServerBrowser_RelayLaunchRequested;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockServersPage_Loaded);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockServersPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockServersPage_Loaded_d__5 bedrockServersPage_Loaded_d__ = default(_BedrockServersPage_Loaded_d__5);
		bedrockServersPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockServersPage_Loaded_d__.__4__this = this;
		bedrockServersPage_Loaded_d__.__1__state = -1;
		bedrockServersPage_Loaded_d__.__t__builder.Start<_BedrockServersPage_Loaded_d__5>(ref bedrockServersPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AndroidTouchSettingsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.ToolboxPage));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VersionManagementButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_versions"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshSelectedClientStatus()
	{
		if (_clientService.UsesCustomClient)
		{
			SelectedClientTitle.Text = "当前使用本机已有客户端";
			SelectedClientDescription.Text = (string.IsNullOrWhiteSpace(_clientService.CustomClientPath) ? "当前目录不可用，请前往版本管理重新选择。" : (_clientService.CustomClientPath + "。网络游戏不会自动下载或切换版本。"));
			return;
		}
		uY2l6VfMmfM34jZlW4GQ obj = _clientService.yQdX6RCQjO2();
		string text = ((obj != null) ? obj.Version : null) ?? _clientService.fL9X6w1Dv6X();
		SelectedClientTitle.Text = (string.IsNullOrWhiteSpace(text) ? "尚未选择客户端版本" : ("当前客户端版本：" + text));
		SelectedClientDescription.Text = "网络游戏只启动版本管理中指定的本地客户端，不会自动下载或切换版本。";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshAndroidTouchStatus()
	{
		AndroidTouchStatusTitle.Text = XmZPH6fDdBx0Jhg6ql8p.i3dfD6hQKQA();
		AndroidTouchStatusDescription.Text = XmZPH6fDdBx0Jhg6ql8p.ServerAndroidTouchDescription;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		CancellationTokenSource? launchCancellation = _launchCancellation;
		if (launchCancellation != null)
		{
			launchCancellation.Cancel();
		}
		CancellationTokenSource? relayCancellation = _relayCancellation;
		if (relayCancellation != null)
		{
			relayCancellation.Cancel();
		}
		_clientService.Relay.A4Rf0KmpHJd(default(CancellationToken));
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			ServerBrowser.Clear();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(ServerBrowser.Clear));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServerBrowser_LaunchRequested(object? sender, wjHCLDf1ydVEraHow39U server)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServerBrowser_LaunchRequested_d__11 serverBrowser_LaunchRequested_d__ = default(_ServerBrowser_LaunchRequested_d__11);
		serverBrowser_LaunchRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serverBrowser_LaunchRequested_d__.__4__this = this;
		serverBrowser_LaunchRequested_d__.server = server;
		serverBrowser_LaunchRequested_d__.__1__state = -1;
		serverBrowser_LaunchRequested_d__.__t__builder.Start<_ServerBrowser_LaunchRequested_d__11>(ref serverBrowser_LaunchRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? launchCancellation = _launchCancellation;
		if (launchCancellation != null)
		{
			launchCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateLaunchProgress(TNGLHufuZJeliMhnBLZ9 progress)
	{
		double percent = Math.Clamp(progress.Percent, 0.0, 100.0);
		long? totalBytes = progress.TotalBytes;
		if (totalBytes.HasValue && totalBytes.GetValueOrDefault() > 0)
		{
			string text = (progress.BytesPerSecond.HasValue ? ("  ·  " + W0wBpiOcLVX0Ukx7VdU.MFpOy4Ua8e(progress.BytesPerSecond)) : string.Empty);
			LaunchTransferText.Text = W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.BytesProcessed) + " / " + W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(progress.TotalBytes.Value) + text;
			((UIElement)LaunchTransferText).Visibility = (Visibility)0;
		}
		else
		{
			LaunchTransferText.Text = string.Empty;
			((UIElement)LaunchTransferText).Visibility = (Visibility)1;
		}
		SetLaunchState(isRunning: true, progress.Message, percent);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServerBrowser_RelayLaunchRequested(object? sender, wjHCLDf1ydVEraHow39U server)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServerBrowser_RelayLaunchRequested_d__14 serverBrowser_RelayLaunchRequested_d__ = default(_ServerBrowser_RelayLaunchRequested_d__14);
		serverBrowser_RelayLaunchRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serverBrowser_RelayLaunchRequested_d__.__4__this = this;
		serverBrowser_RelayLaunchRequested_d__.server = server;
		serverBrowser_RelayLaunchRequested_d__.__1__state = -1;
		serverBrowser_RelayLaunchRequested_d__.__t__builder.Start<_ServerBrowser_RelayLaunchRequested_d__14>(ref serverBrowser_RelayLaunchRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLaunchState(bool isRunning, string status, double percent)
	{
		((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
		LaunchStageText.Text = GetLaunchStageText(isRunning, percent);
		LaunchStatusText.Text = status;
		((RangeBase)LaunchProgressBar).Value = percent;
		LaunchPercentText.Text = $"{percent:0.#}%";
		((Control)CancelLaunchButton).IsEnabled = isRunning;
		ServerBrowser.SetOperationRunning(isRunning);
		if (!isRunning)
		{
			LaunchTransferText.Text = string.Empty;
			((UIElement)LaunchTransferText).Visibility = (Visibility)1;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetLaunchStageText(bool isRunning, double percent)
	{
		if (!isRunning)
		{
			if (!(percent >= 100.0))
			{
				return "启动已停止";
			}
			return "启动完成";
		}
		if (!(percent < 2.0))
		{
			if (!(percent < 30.0))
			{
				if (!(percent < 36.0))
				{
					if (!(percent < 44.0))
					{
						if (!(percent < 50.0))
						{
							if (!(percent < 69.0))
							{
								if (!(percent < 75.0))
								{
									if (!(percent < 85.0))
									{
										if (!(percent < 88.0))
										{
											if (!(percent < 91.0))
											{
												if (!(percent < 96.0))
												{
													if (percent < 100.0)
													{
														return "等待游戏内连接";
													}
													return "启动完成";
												}
												return "初始化游戏运行时";
											}
											return "创建游戏进程";
										}
										return "生成启动配置";
									}
									return "建立游戏会话";
								}
								return "部署资源与材质";
							}
							return "准备服务器资源";
						}
						return "解析服务器入口";
					}
					return "同步玩家皮肤";
				}
				return "读取服务器信息";
			}
			return "准备游戏客户端";
		}
		return "校验服务权限";
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockServersPage_Loaded);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			ServerBrowser.LaunchRequested -= ServerBrowser_LaunchRequested;
			ServerBrowser.RelayLaunchRequested -= ServerBrowser_RelayLaunchRequested;
			CancellationTokenSource? launchCancellation = _launchCancellation;
			if (launchCancellation != null)
			{
				launchCancellation.Cancel();
			}
			CancellationTokenSource? launchCancellation2 = _launchCancellation;
			if (launchCancellation2 != null)
			{
				launchCancellation2.Dispose();
			}
			CancellationTokenSource? relayCancellation = _relayCancellation;
			if (relayCancellation != null)
			{
				relayCancellation.Cancel();
			}
			CancellationTokenSource? relayCancellation2 = _relayCancellation;
			if (relayCancellation2 != null)
			{
				relayCancellation2.Dispose();
			}
			ServerBrowser.Dispose();
		}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockServersPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LaunchOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			ServerBrowser = CastExtensions.As<BedrockServerBrowser>(target);
			break;
		case 4:
			LaunchStageText = CastExtensions.As<TextBlock>(target);
			break;
		case 5:
			LaunchPercentText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			CancelLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelLaunchButton).Click += new RoutedEventHandler(CancelLaunchButton_Click);
			break;
		case 7:
			LaunchStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			LaunchTransferText = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			LaunchProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(VersionManagementButton_Click);
			break;
		case 11:
			SelectedClientTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			SelectedClientDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(AndroidTouchSettingsButton_Click);
			break;
		case 14:
			AndroidTouchStatusTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			AndroidTouchStatusDescription = CastExtensions.As<TextBlock>(target);
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
	private static void _cctor()
	{
	}
}

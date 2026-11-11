using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AHCHY0f012HXIPgw0yYN;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using PW0ZZVfus06wwb9hw2Vi;
using SGLutIO07VZ7bawO9WX;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using fZGimHf0suVRPkaXFQcr;
using knGiRcfu9DhbMgArQGtn;
using qS8vkpL43FlTMgcj0rgs;
using r7Ie1ifM7owYurGstPtD;
using yun8CRfanLkaBpPLfVrd;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class BedrockRentalRoomsPage : Page, global::System.IDisposable, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockRentalRoomsPage_Loaded_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockRentalRoomsPage __4__this;

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
			BedrockRentalRoomsPage bedrockRentalRoomsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockRentalRoomsPage.RefreshSelectedClientStatus();
					_u__ = bedrockRentalRoomsPage.RentalRoomBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockRentalRoomsPage_Loaded_d__12>(ref _u__, ref this);
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
	private struct _RentalRoomBrowser_LaunchRequested_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockRentalRoomsPage __4__this;

		public DAoPoufaie63jNVdbNug room;

		private string _password_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter<bool> __u__2;

		private TaskAwaiter<XHEDPNfuFO31QfaHLUGP> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockRentalRoomsPage bedrockRentalRoomsPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_00cc;
				}
				if ((uint)(num - 1) <= 1u)
				{
					goto IL_00f2;
				}
				if (bedrockRentalRoomsPage._clientService.CurrentSession != null && bedrockRentalRoomsPage._launchCancellation == null)
				{
					_password_5__2 = string.Empty;
					if (room.HasPassword)
					{
						_u__ = bedrockRentalRoomsPage.PromptForPasswordAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _RentalRoomBrowser_LaunchRequested_d__0>(ref _u__, ref this);
							return;
						}
						goto IL_00cc;
					}
					goto IL_00e6;
				}
				if (bedrockRentalRoomsPage._clientService.CurrentSession == null)
				{
					AppShell.Error("启动失败：未配置游戏身份认证，请先前往账号配置页面完成身份验证");
				}
				goto end_IL_0011;
				IL_00e6:
				_cancellation_5__3 = new CancellationTokenSource();
				goto IL_00f2;
				IL_00cc:
				string result = _u__.GetResult();
				if (result != null)
				{
					_password_5__2 = result;
					goto IL_00e6;
				}
				goto end_IL_0011;
				IL_00f2:
				try
				{
					if ((uint)(num - 1) > 1u)
					{
						bedrockRentalRoomsPage._launchCancellation = _cancellation_5__3;
						bedrockRentalRoomsPage.SetLaunchState(isRunning: true, "正在校验基岩版服务权益", 0.0);
					}
					try
					{
						TaskAwaiter<XHEDPNfuFO31QfaHLUGP> _u__2 = default;
						TaskAwaiter<bool> _u__3 = default;
						if (num != 1)
						{
							if (num == 2)
							{
								_u__2 = __u__3;
								__u__3 = default(TaskAwaiter<XHEDPNfuFO31QfaHLUGP>);
								num = (__1__state = -1);
								goto IL_0241;
							}
							_u__3 = BedrockAccessGuard.EnsureAsync(_cancellation_5__3.Token, forceRefresh: true).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _RentalRoomBrowser_LaunchRequested_d__0>(ref _u__3, ref this);
								return;
							}
						}
						else
						{
							_u__3 = __u__2;
							__u__2 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (_u__3.GetResult())
						{
							Progress<TNGLHufuZJeliMhnBLZ9> val = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)bedrockRentalRoomsPage.UpdateLaunchProgress);
							_u__2 = bedrockRentalRoomsPage._clientService.FKeXRXAHrR0(room, _password_5__2, (IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val, _cancellation_5__3.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XHEDPNfuFO31QfaHLUGP>, _RentalRoomBrowser_LaunchRequested_d__0>(ref _u__2, ref this);
								return;
							}
							goto IL_0241;
						}
						bedrockRentalRoomsPage.SetLaunchState(isRunning: false, "启动已停止：未能通过服务权益校验", 0.0);
						goto end_IL_011d;
						IL_0241:
						XHEDPNfuFO31QfaHLUGP result2 = _u__2.GetResult();
						bedrockRentalRoomsPage.SetLaunchState(isRunning: false, $"已启动 PID {result2.ProcessId}  ·  RPC {result2.LauncherPort}", 100.0);
						ShowRuntimeResult(result2);
						AppShell.Success("已启动并进入 " + room.ServerName);
						end_IL_011d:;
					}
					catch (OperationCanceledException)
					{
						bedrockRentalRoomsPage.SetLaunchState(isRunning: false, "启动已取消", ((RangeBase)bedrockRentalRoomsPage.LaunchProgressBar).Value);
						AppShell.Warning("启动已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "RentalRoomBrowser_LaunchRequested", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockRentalRoomsPage.Launch.cs", 64);
						if (bedrockRentalRoomsPage._clientService.CurrentSession == null)
						{
							bedrockRentalRoomsPage.RentalRoomBrowser.Clear();
						}
						bedrockRentalRoomsPage.SetLaunchState(isRunning: false, exceptionDisplayMessage, ((RangeBase)bedrockRentalRoomsPage.LaunchProgressBar).Value);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							_password_5__2 = string.Empty;
							if (bedrockRentalRoomsPage._launchCancellation == _cancellation_5__3)
							{
								bedrockRentalRoomsPage._launchCancellation = null;
							}
							bedrockRentalRoomsPage.RentalRoomBrowser.SetOperationRunning(running: false);
							((Control)bedrockRentalRoomsPage.CancelLaunchButton).IsEnabled = false;
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__3 != null)
					{
						((global::System.IDisposable)_cancellation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_password_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_password_5__2 = null;
			_cancellation_5__3 = null;
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
	private struct _RentalRoomBrowser_RelayLaunchRequested_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockRentalRoomsPage __4__this;

		public DAoPoufaie63jNVdbNug room;

		private string _password_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private mpVm6bf0F2Qxo2jn2O2u _relayBindScope_5__4;

		private int _relayFrontendProtocol_5__5;

		private TaskAwaiter<string?> __u__1;

		private TaskAwaiter<bool> __u__2;

		private ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Expected O, but got Unknown
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockRentalRoomsPage bedrockRentalRoomsPage = __4__this;
			try
			{
				TaskAwaiter<string> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<string>);
					num = (__1__state = -1);
					goto IL_00cc;
				}
				if ((uint)(num - 1) <= 1u)
				{
					goto IL_00f2;
				}
				if (bedrockRentalRoomsPage._clientService.CurrentSession != null && bedrockRentalRoomsPage._relayCancellation == null)
				{
					_password_5__2 = string.Empty;
					if (room.HasPassword)
					{
						_u__ = bedrockRentalRoomsPage.PromptForPasswordAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, _RentalRoomBrowser_RelayLaunchRequested_d__1>(ref _u__, ref this);
							return;
						}
						goto IL_00cc;
					}
					goto IL_00e6;
				}
				if (bedrockRentalRoomsPage._clientService.CurrentSession == null)
				{
					AppShell.Error("代理启动失败：未配置游戏身份认证，请先完成身份验证");
				}
				goto end_IL_0011;
				IL_00e6:
				_cancellation_5__3 = new CancellationTokenSource();
				goto IL_00f2;
				IL_00cc:
				string result = _u__.GetResult();
				if (result != null)
				{
					_password_5__2 = result;
					goto IL_00e6;
				}
				goto end_IL_0011;
				IL_00f2:
				try
				{
					if ((uint)(num - 1) > 1u)
					{
						bedrockRentalRoomsPage._relayCancellation = _cancellation_5__3;
						_relayBindScope_5__4 = bedrockRentalRoomsPage.RentalRoomBrowser.RelayBindScope;
						_relayFrontendProtocol_5__5 = bedrockRentalRoomsPage.RentalRoomBrowser.RelayFrontendProtocol;
						bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayRunning(running: true);
					}
					try
					{
						ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter _u__2 = default;
						TaskAwaiter<bool> _u__3 = default;
						if (num != 1)
						{
							if (num == 2)
							{
								_u__2 = __u__3;
								__u__3 = default(ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
								goto IL_025b;
							}
							_u__3 = BedrockAccessGuard.EnsureAsync(_cancellation_5__3.Token, forceRefresh: true).GetAwaiter();
							if (!_u__3.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _RentalRoomBrowser_RelayLaunchRequested_d__1>(ref _u__3, ref this);
								return;
							}
						}
						else
						{
							_u__3 = __u__2;
							__u__2 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (_u__3.GetResult())
						{
							_u__2 = bedrockRentalRoomsPage._clientService.Relay.gYnf0lwe5Kg(room, _password_5__2, _relayBindScope_5__4, _relayFrontendProtocol_5__5, _cancellation_5__3.Token).ConfigureAwait(true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 2);
								__u__3 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<xB2S7Ef0a4y25KVIgI8F>.ConfiguredTaskAwaiter, _RentalRoomBrowser_RelayLaunchRequested_d__1>(ref _u__2, ref this);
								return;
							}
							goto IL_025b;
						}
						bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayStatus("代理启动已停止：未能通过服务权益校验");
						goto end_IL_0136;
						IL_025b:
						xB2S7Ef0a4y25KVIgI8F result2 = _u__2.GetResult();
						string text = (string.IsNullOrWhiteSpace(result2.LanAddressText) ? result2.LocalAddressText : (result2.LocalAddressText + "；局域网 " + result2.LanAddressText));
						bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayStatus($"代理已启动：{text} → {result2.RemoteAddressText}（v{result2.FrontendProtocol} → v{result2.BackendProtocol}）。请使用 BedrockBoot 启动对应国际版客户端");
						AppShell.Success("代理服务已启动", "请使用 BedrockBoot 启动对应国际版客户端，连接地址 " + text);
						end_IL_0136:;
					}
					catch (OperationCanceledException)
					{
						bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayStatus("代理启动已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "RentalRoomBrowser_RelayLaunchRequested", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockRentalRoomsPage.Launch.cs", 141);
						bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayStatus("代理启动失败：" + exceptionDisplayMessage);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							_password_5__2 = string.Empty;
							if (bedrockRentalRoomsPage._relayCancellation == _cancellation_5__3)
							{
								bedrockRentalRoomsPage._relayCancellation = null;
							}
							bedrockRentalRoomsPage.RentalRoomBrowser.SetRelayRunning(running: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__3 != null)
					{
						((global::System.IDisposable)_cancellation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_password_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_password_5__2 = null;
			_cancellation_5__3 = null;
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
	private BedrockRentalRoomBrowser RentalRoomBrowser;

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
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RentalRoomBrowser_LaunchRequested(object? sender, DAoPoufaie63jNVdbNug room)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RentalRoomBrowser_LaunchRequested_d__0 rentalRoomBrowser_LaunchRequested_d__ = default(_RentalRoomBrowser_LaunchRequested_d__0);
		rentalRoomBrowser_LaunchRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		rentalRoomBrowser_LaunchRequested_d__.__4__this = this;
		rentalRoomBrowser_LaunchRequested_d__.room = room;
		rentalRoomBrowser_LaunchRequested_d__.__1__state = -1;
		rentalRoomBrowser_LaunchRequested_d__.__t__builder.Start<_RentalRoomBrowser_LaunchRequested_d__0>(ref rentalRoomBrowser_LaunchRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RentalRoomBrowser_RelayLaunchRequested(object? sender, DAoPoufaie63jNVdbNug room)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RentalRoomBrowser_RelayLaunchRequested_d__1 rentalRoomBrowser_RelayLaunchRequested_d__ = default(_RentalRoomBrowser_RelayLaunchRequested_d__1);
		rentalRoomBrowser_RelayLaunchRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		rentalRoomBrowser_RelayLaunchRequested_d__.__4__this = this;
		rentalRoomBrowser_RelayLaunchRequested_d__.room = room;
		rentalRoomBrowser_RelayLaunchRequested_d__.__1__state = -1;
		rentalRoomBrowser_RelayLaunchRequested_d__.__t__builder.Start<_RentalRoomBrowser_RelayLaunchRequested_d__1>(ref rentalRoomBrowser_RelayLaunchRequested_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<string?> PromptForPasswordAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		PasswordBox val = new PasswordBox
		{
			Header = "房间密码",
			PlaceholderText = "请输入租赁房密码",
			PasswordRevealMode = (PasswordRevealMode)0
		};
		object obj = default(object);
		if (Application.Current.Resources.TryGetValue((object)"FormPasswordBoxStyle", out obj))
		{
			Style val2 = (Style)((obj is Style) ? obj : null);
			if (val2 != null)
			{
				((FrameworkElement)val).Style = val2;
			}
		}
		TaskAwaiter<ContentDialogResult> val3 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
		{
			XamlRoot = ((UIElement)this).XamlRoot,
			Title = "进入密码租赁房",
			Content = val,
			PrimaryButtonText = "进入",
			CloseButtonText = "取消",
			DefaultButton = (ContentDialogButton)1
		}.ShowAsync());
		if (!val3.IsCompleted)
		{
			val3.GetResult();
			TaskAwaiter<ContentDialogResult> val4 = default(TaskAwaiter<ContentDialogResult>);
			val3 = val4;
		}
		ContentDialogResult result = val3.GetResult();
		string password = val.Password;
		val.Password = string.Empty;
		return ((int)result == 1 && !string.IsNullOrWhiteSpace(password)) ? password : null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ShowRuntimeResult(XHEDPNfuFO31QfaHLUGP result)
	{
		if (result.AndroidTouchActivated)
		{
			AppShell.Success("手机端指纹已启用", $"模拟设备：{result.AndroidDeviceName}（{result.AndroidDeviceModel}） · Android {result.AndroidVersion}");
		}
		else
		{
			AppShell.Warning("手机端指纹本次未确认生效，请查看启动诊断日志");
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
	private void SetLaunchState(bool isRunning, string status, double percent)
	{
		((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
		LaunchStageText.Text = GetLaunchStageText(isRunning, percent);
		LaunchStatusText.Text = status;
		((RangeBase)LaunchProgressBar).Value = percent;
		LaunchPercentText.Text = $"{percent:0.#}%";
		((Control)CancelLaunchButton).IsEnabled = isRunning;
		RentalRoomBrowser.SetOperationRunning(isRunning);
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
								return "建立本地服务";
							}
							return "准备材质与游戏会话";
						}
						return "解析租赁房入口";
					}
					return "同步玩家皮肤";
				}
				return "读取租赁房信息";
			}
			return "准备游戏客户端";
		}
		return "校验服务权限";
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockRentalRoomsPage()
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		RentalRoomBrowser.Attach(_clientService);
		RentalRoomBrowser.LaunchRequested += RentalRoomBrowser_LaunchRequested;
		RentalRoomBrowser.RelayLaunchRequested += RentalRoomBrowser_RelayLaunchRequested;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockRentalRoomsPage_Loaded);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockRentalRoomsPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockRentalRoomsPage_Loaded_d__12 bedrockRentalRoomsPage_Loaded_d__ = default(_BedrockRentalRoomsPage_Loaded_d__12);
		bedrockRentalRoomsPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockRentalRoomsPage_Loaded_d__.__4__this = this;
		bedrockRentalRoomsPage_Loaded_d__.__1__state = -1;
		bedrockRentalRoomsPage_Loaded_d__.__t__builder.Start<_BedrockRentalRoomsPage_Loaded_d__12>(ref bedrockRentalRoomsPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshSelectedClientStatus()
	{
		if (_clientService.UsesCustomClient)
		{
			SelectedClientTitle.Text = "当前使用本机已有客户端";
			SelectedClientDescription.Text = (string.IsNullOrWhiteSpace(_clientService.CustomClientPath) ? "当前目录不可用，请前往版本管理重新选择。" : (_clientService.CustomClientPath + "。租赁房不会自动下载或切换版本。"));
			return;
		}
		uY2l6VfMmfM34jZlW4GQ obj = _clientService.yQdX6RCQjO2();
		string text = ((obj != null) ? obj.Version : null) ?? _clientService.fL9X6w1Dv6X();
		SelectedClientTitle.Text = (string.IsNullOrWhiteSpace(text) ? "尚未选择客户端版本" : ("当前客户端版本：" + text));
		SelectedClientDescription.Text = "租赁房只启动版本管理中指定的本地客户端，不会自动下载或切换版本。";
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
			RentalRoomBrowser.Clear();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(RentalRoomBrowser.Clear));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VersionManagementButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_versions"));
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
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockRentalRoomsPage_Loaded);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			RentalRoomBrowser.LaunchRequested -= RentalRoomBrowser_LaunchRequested;
			RentalRoomBrowser.RelayLaunchRequested -= RentalRoomBrowser_RelayLaunchRequested;
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
			RentalRoomBrowser.Dispose();
		}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockRentalRoomsPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LaunchOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			RentalRoomBrowser = CastExtensions.As<BedrockRentalRoomBrowser>(target);
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

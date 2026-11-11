using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Controls.Bedrock;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using bP1knHfaZRN10coBj77w;
using knGiRcfu9DhbMgArQGtn;
using qS8vkpL43FlTMgcj0rgs;
using r7Ie1ifM7owYurGstPtD;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockLocalMultiplayerPage : Page, global::System.IDisposable, IComponentConnector
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_2
	{
		public BedrockLocalMultiplayerPage __4__this;

		public CancellationTokenSource cancellation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _LobbyBrowser_StartLobbyRequested_b__0(TNGLHufuZJeliMhnBLZ9 value)
		{
			if (__4__this._disposed || __4__this._launchCancellation != cancellation || cancellation.IsCancellationRequested)
			{
				gX17swyO7x0JWQxdaD1.rShyeXSwgD("bedrock-local-lobby", $"stage=progress-ignored percent={value.Percent}");
			}
			else
			{
				__4__this.UpdateLaunchProgress(value);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockLocalMultiplayerPage_Loaded_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalMultiplayerPage __4__this;

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
			BedrockLocalMultiplayerPage bedrockLocalMultiplayerPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					bedrockLocalMultiplayerPage.RefreshSelectedClientStatus();
					_u__ = bedrockLocalMultiplayerPage.LobbyBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockLocalMultiplayerPage_Loaded_d__4>(ref _u__, ref this);
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
	private struct _LobbyBrowser_StartLobbyRequested_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockLocalMultiplayerPage __4__this;

		public YBV0pDfajTopiWOW3iSn request;

		private __c__DisplayClass8_0_2 __8__1;

		private YBV0pDfajTopiWOW3iSn _launchRequest_5__2;

		private Stopwatch _timer_5__3;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter<int> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Expected O, but got Unknown
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockLocalMultiplayerPage bedrockLocalMultiplayerPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0084;
				}
				__8__1 = (__c__DisplayClass8_0_2)new __c__DisplayClass8_0_2();
				__8__1.__4__this = __4__this;
				if (!bedrockLocalMultiplayerPage._disposed)
				{
					if (bedrockLocalMultiplayerPage._clientService.CurrentSession == null)
					{
						AppShell.Error("启动失败：未配置游戏身份认证，请先完成身份验证");
					}
					else if (bedrockLocalMultiplayerPage._launchCancellation == null)
					{
						__8__1.cancellation = new CancellationTokenSource();
						goto IL_0084;
					}
				}
				goto end_IL_0011;
				IL_0084:
				try
				{
					if ((uint)num > 1u)
					{
						YBV0pDfajTopiWOW3iSn obj = request.Uy0faDV8fqj();
						obj.GetType().GetProperty("MobileModeEnabled").SetValue(obj, false);
						_launchRequest_5__2 = obj;
						bedrockLocalMultiplayerPage._launchCancellation = __8__1.cancellation;
						_timer_5__3 = Stopwatch.StartNew();
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-local-lobby", "stage=launch-start clientMode=" + (_launchRequest_5__2.MobileModeEnabled ? "mobile" : "pc"));
						bedrockLocalMultiplayerPage.SetLaunchState(running: true, "正在校验基岩版服务权益", 0.0);
					}
					try
					{
						TaskAwaiter<int> _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<int>);
								num = (__1__state = -1);
								goto IL_0232;
							}
							_u__2 = BedrockAccessGuard.EnsureAsync(__8__1.cancellation.Token, forceRefresh: true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _LobbyBrowser_StartLobbyRequested_d__8>(ref _u__2, ref this);
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
							Progress<TNGLHufuZJeliMhnBLZ9> val = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)__8__1._LobbyBrowser_StartLobbyRequested_b__0);
							_u__ = bedrockLocalMultiplayerPage._clientService.SNgX6BnhAhs(_launchRequest_5__2, (IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val, __8__1.cancellation.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _LobbyBrowser_StartLobbyRequested_d__8>(ref _u__, ref this);
								return;
							}
							goto IL_0232;
						}
						bedrockLocalMultiplayerPage.SetLaunchState(running: false, "启动已停止：未能通过服务权益校验", 0.0);
						goto end_IL_0108;
						IL_0232:
						int result = _u__.GetResult();
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-local-lobby", $"stage=launch-completed pid={result} elapsedMs={_timer_5__3.ElapsedMilliseconds}");
						bedrockLocalMultiplayerPage.SetLaunchState(running: false, $"已启动并进入 {request.Room.Name}（PID {result}）", 100.0);
						AppShell.Success("已进入公共房间", "目标房间：" + request.Room.Name);
						end_IL_0108:;
					}
					catch (OperationCanceledException)
					{
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-local-lobby", $"stage=launch-cancelled elapsedMs={_timer_5__3.ElapsedMilliseconds}");
						bedrockLocalMultiplayerPage.SetLaunchState(running: false, "启动已取消", ((RangeBase)bedrockLocalMultiplayerPage.LaunchProgressBar).Value);
						AppShell.Warning("启动已取消");
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-local-lobby", $"stage=launch-failed error={((MemberInfo)ex2.GetType()).Name} elapsedMs={_timer_5__3.ElapsedMilliseconds}", ex2);
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(ex2, "LobbyBrowser_StartLobbyRequested", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockLocalMultiplayerPage.xaml.cs", 135);
						bedrockLocalMultiplayerPage.SetLaunchState(running: false, exceptionDisplayMessage, ((RangeBase)bedrockLocalMultiplayerPage.LaunchProgressBar).Value);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockLocalMultiplayerPage._launchCancellation == __8__1.cancellation)
							{
								bedrockLocalMultiplayerPage._launchCancellation = null;
							}
							if (!bedrockLocalMultiplayerPage._disposed)
							{
								bedrockLocalMultiplayerPage.LobbyBrowser.SetOperationRunning(running: false);
								((Control)bedrockLocalMultiplayerPage.CancelLaunchButton).IsEnabled = false;
							}
						}
					}
				}
				finally
				{
					if (num < 0 && __8__1.cancellation != null)
					{
						((global::System.IDisposable)__8__1.cancellation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				_launchRequest_5__2 = null;
				_timer_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_launchRequest_5__2 = null;
			_timer_5__3 = null;
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

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LaunchOperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockLocalLobbyBrowser LobbyBrowser;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar LaunchProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockLocalMultiplayerPage()
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		LobbyBrowser.Attach(_clientService);
		LobbyBrowser.StartLobbyRequested += LobbyBrowser_StartLobbyRequested;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockLocalMultiplayerPage_Loaded);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockLocalMultiplayerPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockLocalMultiplayerPage_Loaded_d__4 bedrockLocalMultiplayerPage_Loaded_d__ = default(_BedrockLocalMultiplayerPage_Loaded_d__4);
		bedrockLocalMultiplayerPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockLocalMultiplayerPage_Loaded_d__.__4__this = this;
		bedrockLocalMultiplayerPage_Loaded_d__.__1__state = -1;
		bedrockLocalMultiplayerPage_Loaded_d__.__t__builder.Start<_BedrockLocalMultiplayerPage_Loaded_d__4>(ref bedrockLocalMultiplayerPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshSelectedClientStatus()
	{
		if (_clientService.UsesCustomClient)
		{
			SelectedClientTitle.Text = "当前使用本机已有客户端";
			SelectedClientDescription.Text = (string.IsNullOrWhiteSpace(_clientService.CustomClientPath) ? "当前目录不可用，请前往版本管理重新选择。" : (_clientService.CustomClientPath + "。本地联机不会自动下载或切换版本。"));
			return;
		}
		uY2l6VfMmfM34jZlW4GQ obj = _clientService.yQdX6RCQjO2();
		string text = ((obj != null) ? obj.Version : null) ?? _clientService.fL9X6w1Dv6X();
		SelectedClientTitle.Text = (string.IsNullOrWhiteSpace(text) ? "尚未选择客户端版本" : ("当前客户端版本：" + text));
		SelectedClientDescription.Text = "本地联机只启动指定的本地客户端，不启用原生、MODSDK 或 MCP 设备伪装。";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void VersionManagementButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_versions"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		CancellationTokenSource? launchCancellation = _launchCancellation;
		if (launchCancellation != null)
		{
			launchCancellation.Cancel();
		}
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			LobbyBrowser.Clear();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(LobbyBrowser.Clear));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LobbyBrowser_StartLobbyRequested(object? sender, YBV0pDfajTopiWOW3iSn request)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LobbyBrowser_StartLobbyRequested_d__8 lobbyBrowser_StartLobbyRequested_d__ = default(_LobbyBrowser_StartLobbyRequested_d__8);
		lobbyBrowser_StartLobbyRequested_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		lobbyBrowser_StartLobbyRequested_d__.__4__this = this;
		lobbyBrowser_StartLobbyRequested_d__.request = request;
		lobbyBrowser_StartLobbyRequested_d__.__1__state = -1;
		lobbyBrowser_StartLobbyRequested_d__.__t__builder.Start<_LobbyBrowser_StartLobbyRequested_d__8>(ref lobbyBrowser_StartLobbyRequested_d__);
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
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		double num = Math.Clamp(progress.Percent, 0.0, 100.0);
		gX17swyO7x0JWQxdaD1.rShyeXSwgD("bedrock-local-lobby", $"stage=launch-progress percent={num} phase={progress.Stage}");
		SetLaunchState(running: true, progress.Message, num);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLaunchState(bool running, string status, double percent)
	{
		if (!_disposed)
		{
			((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
			LaunchStageText.Text = (running ? "准备本地联机大厅" : ((percent >= 100.0) ? "启动完成" : "启动已停止"));
			LaunchStatusText.Text = status;
			((RangeBase)LaunchProgressBar).Value = percent;
			LaunchPercentText.Text = $"{percent:0.#}%";
			((Control)CancelLaunchButton).IsEnabled = running;
			LobbyBrowser.SetOperationRunning(running);
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
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockLocalMultiplayerPage_Loaded);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			LobbyBrowser.StartLobbyRequested -= LobbyBrowser_StartLobbyRequested;
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
			LobbyBrowser.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockLocalMultiplayerPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LaunchOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			LobbyBrowser = CastExtensions.As<BedrockLocalLobbyBrowser>(target);
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
			LaunchProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(VersionManagementButton_Click);
			break;
		case 10:
			SelectedClientTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			SelectedClientDescription = CastExtensions.As<TextBlock>(target);
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

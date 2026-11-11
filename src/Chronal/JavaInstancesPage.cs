using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using GxkGd8NIqf0OYNxx8A9;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using O7oSQyfxiUTrhAE02s2Q;
using WP2chpfxfiuBSYyeOFWV;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.DataTransfer;
using YXMjNoXcouOKeTTRMKFH;
using bUfedyCg1PBqhqIkB8r;
using c4PNM5fxD3whDVKOiLnG;
using fAXRvmNZu6fmaZ5kmc8;
using qS8vkpL43FlTMgcj0rgs;
using xysbBnfxVcX9hX2IYacd;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class JavaInstancesPage : Page, global::System.IDisposable, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunOperationAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public JavaInstancesPage __4__this;

		public Func<global::System.Threading.Tasks.Task> operation;

		public string successMessage;

		public string nextStep;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaInstancesPage javaInstancesPage = __4__this;
			try
			{
				if (num != 0)
				{
					javaInstancesPage._operationInProgress = true;
					javaInstancesPage.Refresh();
				}
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = operation.Invoke().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunOperationAsync_d__13>(ref _u__, ref this);
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
					javaInstancesPage.Refresh();
					AppShell.Success(successMessage);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RunOperationAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaInstancesPage.xaml.cs", 183);
					AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, nextStep));
				}
				finally
				{
					if (num < 0)
					{
						javaInstancesPage._operationInProgress = false;
						javaInstancesPage.Refresh();
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
	private struct _StopConnectionButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public JavaInstancesPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0116: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			JavaInstancesPage __8_locals4 = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00ca;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_014b;
				}
				qC3ZV7fxXAJqu2TjY3Nc current = __8_locals4._coordinator.Current;
				if (current != null && current.CanStop && !__8_locals4._operationInProgress)
				{
					string message = (((int)current.Mode == 0) ? "将关闭认证侧车与回环代理，并断开玩家客户端；不会结束玩家自己的客户端进程。" : "将关闭内部回环代理，并停止由本项目创建且身份仍匹配的官方游戏事务。");
					_u__ = AppShell.ConfirmAsync("停止当前 Java 连接？", message, "停止连接").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StopConnectionButton_Click_d__9>(ref _u__, ref this);
						return;
					}
					goto IL_00ca;
				}
				goto end_IL_0011;
				IL_00ca:
				if (_u__.GetResult())
				{
					_u__2 = __8_locals4.RunOperationAsync([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] () => __8_locals4._coordinator.GGwNtycGrm(default(CancellationToken)), "Java 连接已停止", "刷新连接实例后重新停止当前连接").GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StopConnectionButton_Click_d__9>(ref _u__2, ref this);
						return;
					}
					goto IL_014b;
				}
				goto end_IL_0011;
				IL_014b:
				_u__2.GetResult();
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

	private readonly Jj84PVNAj19tCbr5gHp _coordinator;

	private bool _operationInProgress;

	private bool _disposed;

	private string _copyAddress;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ConnectionPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DownloadTrafficText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock UploadTrafficText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock UpstreamStateText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LocalClientStateText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock OfficialProcessStateText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProxyStateText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RelayStateText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LocalEndpointPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border ExternalProcessHintBorder;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StopConnectionButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RetryConnectionButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LocalAddressText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StartedAtText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock TransactionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock VersionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RoleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ServerText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StateCodeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ModeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ConnectionStateTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ConnectionMessageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public JavaInstancesPage()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		_coordinator = Yx0jy4NjAWxONbCjY3P.Shared;
		_copyAddress = string.Empty;
		InitializeComponent();
		AppShell.RegisterDisposable(this);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(JavaInstancesPage_Loaded);
		_coordinator.Changed += new EventHandler(Coordinator_Changed);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void JavaInstancesPage_Loaded(object sender, RoutedEventArgs e)
	{
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Coordinator_Changed(object? sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(Refresh));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Refresh()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Invalid comparison between Unknown and I4
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_033e: Invalid comparison between Unknown and I4
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Invalid comparison between Unknown and I4
		if (!_disposed)
		{
			qC3ZV7fxXAJqu2TjY3Nc current = _coordinator.Current;
			bool flag = current != null;
			((UIElement)EmptyPanel).Visibility = ((flag) ? Visibility.Visible : Visibility.Collapsed);
			((UIElement)ConnectionPanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
			if (current == null)
			{
				_copyAddress = string.Empty;
				return;
			}
			ConnectionStateTitleText.Text = JavaConnectionStatePresentation.TitleOf(current.State);
			ConnectionMessageText.Text = (string.IsNullOrWhiteSpace(current.Message) ? "当前连接没有附加状态说明" : current.Message);
			ModeText.Text = (((int)current.Mode == 0) ? "外部客户端" : "官方客户端");
			StateCodeText.Text = (current.IsActive ? "活动事务" : "最近事务");
			ServerText.Text = SafeDisplay(current.ServerName, "未命名服务器");
			RoleText.Text = SafeDisplay(current.RoleName, "未选择角色");
			VersionText.Text = SafeDisplay(current.VersionName, "未知版本");
			TextBlock startedAtText = StartedAtText;
			DateTimeOffset val = current.StartedAt;
			val = val.ToLocalTime();
			startedAtText.Text = "建立时间：" + val.ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider)(object)CultureInfo.CurrentCulture);
			TransactionText.Text = "事务：" + ShortTransactionId(current.Id);
			bool flag2 = (int)current.Mode == 0 && current.HasLocalEndpoint;
			_copyAddress = (flag2 ? current.LocalAddressText : string.Empty);
			LocalAddressText.Text = _copyAddress;
			((UIElement)LocalEndpointPanel).Visibility = ((!flag2) ? Visibility.Visible : Visibility.Collapsed);
			((UIElement)ExternalProcessHintBorder).Visibility = ((((int)current.Mode != 0)) ? Visibility.Visible : Visibility.Collapsed);
			RelayStateText.Text = DescribeRelay(current);
			ProxyStateText.Text = DescribeProxy(current);
			OfficialProcessStateText.Text = DescribeOfficialProcess(current);
			FpqMUEfxkfKkyh2Gakrc val2 = current.Telemetry ?? FpqMUEfxkfKkyh2Gakrc.Empty;
			bool flag3 = current.IsActive && (int)current.State != 9;
			LocalClientStateText.Text = (flag3 ? DescribeLocalClient(current.Mode, val2) : "已断开");
			UpstreamStateText.Text = ((flag3 && val2.UpstreamConnected) ? "已连接并由代理观察" : (flag3 ? "尚未建立或正在等待" : "已断开"));
			UploadTrafficText.Text = FormatBytes(val2.ClientToServerBytes);
			DownloadTrafficText.Text = FormatBytes(val2.ServerToClientBytes);
			((Control)StopConnectionButton).IsEnabled = current.CanStop && !_operationInProgress;
			Button retryConnectionButton = RetryConnectionButton;
			T9LWLtfx944ku4NynZ2L state = current.State;
			bool flag4 = (((int)state == 8 || (int)state == 10) ? true : false);
			((UIElement)retryConnectionButton).Visibility = ((!flag4) ? Visibility.Visible : Visibility.Collapsed);
			((Control)RetryConnectionButton).IsEnabled = !_operationInProgress;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StopConnectionButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StopConnectionButton_Click_d__9 stopConnectionButton_Click_d__ = default(_StopConnectionButton_Click_d__9);
		stopConnectionButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stopConnectionButton_Click_d__.__4__this = this;
		stopConnectionButton_Click_d__.__1__state = -1;
		stopConnectionButton_Click_d__.__t__builder.Start<_StopConnectionButton_Click_d__9>(ref stopConnectionButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RetryConnectionButton_Click(object sender, RoutedEventArgs e)
	{
		if (!_operationInProgress)
		{
			qC3ZV7fxXAJqu2TjY3Nc current = _coordinator.Current;
			if (current == null || !current.IsActive)
			{
				AppShell.Navigate(NavigationRegistry.MainPageType("java_servers"));
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenServersButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("java_servers"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyAddressButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (string.IsNullOrWhiteSpace(_copyAddress))
		{
			return;
		}
		try
		{
			DataPackage val = new DataPackage();
			val.SetText(_copyAddress);
			Clipboard.SetContent(val);
			AppShell.Success("已复制本机地址：" + _copyAddress);
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "CopyAddressButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Java\\JavaInstancesPage.xaml.cs", 161);
			AppShell.Error(pTtxNQXcrrZ784qrl4Q2.yAfXcm7NrMl(ex, "手动复制连接实例页显示的本机地址"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunOperationAsync(Func<global::System.Threading.Tasks.Task> operation, string successMessage, string nextStep)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RunOperationAsync_d__13 runOperationAsync_d__ = default(_RunOperationAsync_d__13);
		runOperationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		runOperationAsync_d__.__4__this = this;
		runOperationAsync_d__.operation = operation;
		runOperationAsync_d__.successMessage = successMessage;
		runOperationAsync_d__.nextStep = nextStep;
		runOperationAsync_d__.__1__state = -1;
		runOperationAsync_d__.__t__builder.Start<_RunOperationAsync_d__13>(ref runOperationAsync_d__);
		return runOperationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DescribeRelay(qC3ZV7fxXAJqu2TjY3Nc snapshot)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected I4, but got Unknown
		if ((int)snapshot.Mode == 1)
		{
			return "官方客户端模式由受信官方游戏事务完成认证，不向桌面端公开凭据。";
		}
		T9LWLtfx944ku4NynZ2L state = snapshot.State;
		switch ((int)state)
		{
		case 0:
		case 1:
		case 2:
			return "等待官方宿主准备一次性认证上下文";
		case 3:
			return "正在启动并绑定本次事务";
		case 4:
		case 5:
		case 6:
		case 7:
			return "已绑定当前账号、服务器、角色与版本";
		case 9:
			return "正在销毁一次性认证上下文";
		case 10:
			return "认证侧车不可用或已释放";
		default:
			return "一次性认证上下文已释放";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DescribeProxy(qC3ZV7fxXAJqu2TjY3Nc snapshot)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		T9LWLtfx944ku4NynZ2L state = snapshot.State;
		switch ((int)state)
		{
		case 0:
		case 1:
		case 2:
			return "尚未建立回环监听";
		case 3:
			return "正在绑定仅本机可访问的入口";
		case 4:
		case 5:
			return ((int)snapshot.Mode == 0 && snapshot.HasLocalEndpoint) ? ("正在监听 " + snapshot.LocalAddressText) : "内部回环代理已就绪；端口不会对玩家客户端公开";
		case 6:
			return "正在转发登录与认证流量";
		case 7:
			return "正在转发游戏流量";
		case 9:
			return "正在停止接入并释放监听";
		case 10:
			return "回环代理失败或已经释放";
		default:
			return "回环代理已停止";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DescribeOfficialProcess(qC3ZV7fxXAJqu2TjY3Nc snapshot)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected I4, but got Unknown
		if ((int)snapshot.Mode == 0)
		{
			return "此模式不启动官方游戏；玩家自己的客户端由用户自行管理。";
		}
		T9LWLtfx944ku4NynZ2L state = snapshot.State;
		switch ((int)state)
		{
		case 0:
		case 1:
		case 2:
		case 3:
		case 4:
			return "等待官方宿主创建游戏进程";
		case 5:
		case 6:
		case 7:
			return "官方游戏已启动，进程身份与退出状态正在受控观察";
		case 9:
			return "正在停止已验证归属的官方游戏事务";
		case 10:
			return "官方游戏或进程观察链失败";
		default:
			return "官方游戏事务已结束";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DescribeLocalClient(r9S4FZfxG0478bdNv59r mode, FpqMUEfxkfKkyh2Gakrc telemetry)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (telemetry.LocalClientConnected)
		{
			if ((int)mode != 0)
			{
				return "官方游戏已连接内部代理";
			}
			return "玩家客户端已连接";
		}
		if ((int)mode != 0)
		{
			return "等待官方游戏连接";
		}
		return "等待玩家客户端连接";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatBytes(long bytes)
	{
		if (bytes < 1048576)
		{
			if (bytes < 1024)
			{
				return bytes.ToString((IFormatProvider)(object)CultureInfo.CurrentCulture) + " B";
			}
			return ((double)bytes / 1024.0).ToString("0.0", (IFormatProvider)(object)CultureInfo.CurrentCulture) + " KB";
		}
		if (bytes < 1073741824)
		{
			return ((double)bytes / 1048576.0).ToString("0.0", (IFormatProvider)(object)CultureInfo.CurrentCulture) + " MB";
		}
		return ((double)bytes / 1073741824.0).ToString("0.0", (IFormatProvider)(object)CultureInfo.CurrentCulture) + " GB";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string SafeDisplay(string value, string fallback)
	{
		if (!string.IsNullOrWhiteSpace(value))
		{
			return value.Trim();
		}
		return fallback;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ShortTransactionId(string value)
	{
		string text = (value ?? string.Empty).Trim();
		if (text.Length <= 8)
		{
			return SafeDisplay(text, "未知");
		}
		return text.Substring(0, 8);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(JavaInstancesPage_Loaded);
			_coordinator.Changed -= new EventHandler(Coordinator_Changed);
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaInstancesPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		//IL_019a: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			EmptyPanel = CastExtensions.As<Border>(target);
			break;
		case 3:
			ConnectionPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			DownloadTrafficText = CastExtensions.As<TextBlock>(target);
			break;
		case 5:
			UploadTrafficText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			UpstreamStateText = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			LocalClientStateText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			OfficialProcessStateText = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
			ProxyStateText = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			RelayStateText = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			LocalEndpointPanel = CastExtensions.As<Border>(target);
			break;
		case 12:
			ExternalProcessHintBorder = CastExtensions.As<Border>(target);
			break;
		case 13:
			StopConnectionButton = CastExtensions.As<Button>(target);
			((ButtonBase)StopConnectionButton).Click += new RoutedEventHandler(StopConnectionButton_Click);
			break;
		case 14:
			RetryConnectionButton = CastExtensions.As<Button>(target);
			((ButtonBase)RetryConnectionButton).Click += new RoutedEventHandler(RetryConnectionButton_Click);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyAddressButton_Click);
			break;
		case 16:
			LocalAddressText = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			StartedAtText = CastExtensions.As<TextBlock>(target);
			break;
		case 18:
			TransactionText = CastExtensions.As<TextBlock>(target);
			break;
		case 19:
			VersionText = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			RoleText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			ServerText = CastExtensions.As<TextBlock>(target);
			break;
		case 22:
			StateCodeText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			ModeText = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			ConnectionStateTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 25:
			ConnectionMessageText = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenServersButton_Click);
			break;
		case 27:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
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
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _StopConnectionButton_Click_b__9_0()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return _coordinator.GGwNtycGrm(default(CancellationToken));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

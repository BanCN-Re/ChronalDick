using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Services;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Shell;
using Microsoft.UI.Composition;
using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Graphics;
using Windows.UI;
using qS8vkpL43FlTMgcj0rgs;
using todNS07L1BTskuVuFU3;

namespace Mahiro_Account;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
public sealed class MainWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private static class __O_10
	{
		public static Func<global::System.Threading.Tasks.Task?> _0___FlushLogsBeforeCloseAsync;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _FlushLogsThenCloseAsync_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public MainWindow __4__this;

		private System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Expected O, but got I4
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got I4
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_004b: Expected O, but got I4
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Expected O, but got I4
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			dynamic obj2 = __4__this;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter obj3;
					System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter obj5;
					if (obj != null)
					{
						if ((nint)obj == 1)
						{
							obj3 = __u__2;
							__u__2 = default(TaskAwaiter);
							obj = -1;
							__1__state = -1;
							goto IL_0118;
						}
						dynamic obj4 = System.Threading.Tasks.Task.Yield();
						obj5 = obj4.GetAwaiter();
						if (!((dynamic)obj5).IsCompleted)
						{
							obj = 0;
							__1__state = 0;
							__u__1 = (System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter)obj5;
							__t__builder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter, _FlushLogsThenCloseAsync_d__33>(ref obj5, ref this);
							return;
						}
					}
					else
					{
						obj5 = __u__1;
						__u__1 = default(System.Runtime.CompilerServices.YieldAwaitable.YieldAwaiter);
						obj = -1;
						__1__state = -1;
					}
					((dynamic)obj5).GetResult();
					obj3 = (System.Threading.Tasks.Task.Run(AppShell.FlushLogsBeforeCloseAsync)).GetAwaiter();
					if (!((dynamic)obj3).IsCompleted)
					{
						obj = 1;
						__1__state = 1;
						__u__2 = (TaskAwaiter)obj3;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _FlushLogsThenCloseAsync_d__33>(ref obj3, ref this);
						return;
					}
					goto IL_0118;
					IL_0118:
					((dynamic)obj3).GetResult();
				}
				finally
				{
					if ((nint)obj < 0)
					{
						((MainWindow)obj2)._closeFlushCompleted = true;
						((MainWindow)obj2)._allowClose = true;
						((dynamic)obj2).Close();
					}
				}
			}
			catch (global::System.Exception ex)
			{
				__1__state = -2;
				(__t__builder).SetException(ex);
				return;
			}
			__1__state = -2;
			(__t__builder).SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			(__t__builder).SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ResumeJavaSessionAsync_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private object __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Expected O, but got I4
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Expected O, but got Unknown
			//IL_004f: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			try
			{
				try
				{
					object obj3;
					if (obj != null)
					{
						dynamic obj2 = (__Proxy.StartJavaSessionAsync(default(CancellationToken))).ConfigureAwait(false);
						obj3 = obj2.GetAwaiter();
						if (!((dynamic)obj3).IsCompleted)
						{
							obj = 0;
							__1__state = 0;
							__u__1 = obj3;
							System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter u__1 = (System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter)obj3;
							__t__builder.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter, _ResumeJavaSessionAsync_d__29>(ref u__1, ref this);
							return;
						}
					}
					else
					{
						obj3 = __u__1;
						__u__1 = default(object);
						obj = -1;
						__1__state = -1;
					}
					((dynamic)obj3).GetResult();
				}
				catch (global::System.Exception ex)
				{
					__Proxy.LogError("Java", "应用恢复后刷新 Java 会话失败", ex);
				}
			}
			catch (global::System.Exception ex2)
			{
				__1__state = -2;
				(__t__builder).SetException(ex2);
				return;
			}
			__1__state = -2;
			(__t__builder).SetResult();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			(__t__builder).SetStateMachine(stateMachine);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private const int ShowWindowRestore = 9;

	private readonly LqCNIN7faHo3aBdfb2m _personIdentityApiClient;

	private AppWindow? _appWindow;

	private MicaController? _micaController;

	private DesktopAcrylicController? _acrylicController;

	private SystemBackdropConfiguration? _backdropConfiguration;

	private bool _allowClose;

	private bool _forceCloseRequested;

	private bool _closeFlushStarted;

	private bool _closeFlushCompleted;

	private bool _powerNotificationsSubscribed;

	private const int PreferredWindowWidth = 2048;

	private const int PreferredWindowHeight = 1152;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ShellView Shell;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	internal nint WindowHandle
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return WinRT.Interop.WindowNative.GetWindowHandle(this);
		}
	}

	[DllImport("user32.dll")]
	private static extern bool IsIconic(nint windowHandle);

	[DllImport("user32.dll")]
	private static extern bool ShowWindowAsync(nint windowHandle, int command);

	[DllImport("user32.dll")]
	private static extern bool BringWindowToTop(nint windowHandle);

	[DllImport("user32.dll")]
	private static extern bool SetForegroundWindow(nint windowHandle);

	[MethodImpl((MethodImplOptions)8)]
	public MainWindow()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		_personIdentityApiClient = new LqCNIN7faHo3aBdfb2m();
		InitializeComponent();
		AppShell.WindowHandle = WindowHandle;
		(this).ExtendsContentIntoTitleBar = true;
		(this).SetTitleBar((UIElement)(object)Shell.TitleBarElement);
		ConfigureAppWindow();
		ApplyBackdrop();
		InstallPersonIdentityCertificate();
		SubscribePowerNotifications();
		AppearanceSettings.Changed += new EventHandler(OnAppearanceChanged);
		Shell.CloseWindowRequested += new EventHandler(OnCloseWindowRequested);
		(this).Closed += OnClosed;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void BringToForeground()
	{
		//IL_0007: Expected O, but got I
		//IL_000d: Expected I, but got O
		//IL_001a: Expected I, but got O
		//IL_0049: Expected I, but got O
		//IL_0050: Expected I, but got O
		dynamic obj = WindowHandle;
		try
		{
			if (IsIconic((nint)obj))
			{
				ShowWindowAsync((nint)obj, 9);
			}
			AppWindow? appWindow = _appWindow;
			if (appWindow != null)
			{
				(appWindow).Show(true);
			}
			(this).Activate();
			BringWindowToTop((nint)obj);
			SetForegroundWindow((nint)obj);
		}
		catch (global::System.Exception ex)
		{
			__Proxy.LogError("protocol", "协议激活时前置主窗口失败", ex);
			(this).Activate();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void ResizeToPreferredSize(AppWindow appWindow)
	{
		//IL_0006: Expected O, but got I4
		//IL_000c: Expected O, but got I4
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected I4, but got O
		//IL_0118: Expected I4, but got O
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0097: Expected I4, but got O
		//IL_0098: Expected O, but got I4
		//IL_00bb: Expected I4, but got O
		//IL_00bc: Expected O, but got I4
		//IL_00c4: Expected I4, but got O
		//IL_00c4: Expected I4, but got O
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		//IL_00f6: Expected I4, but got Unknown
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = 2048;
		dynamic obj2 = 1152;
		try
		{
			DisplayArea obj3 = Microsoft.UI.Windowing.DisplayArea.GetFromWindowId((appWindow).Id, (DisplayAreaFallback)1);
			RectInt32? obj5;
			if (obj3 == null)
			{
				dynamic obj4 = default(object);
				*(RectInt32?*)(&obj4) = null;
				obj5 = obj4;
			}
			else
			{
				obj5 = (obj3).WorkArea;
			}
			object obj6 = obj5;
			if (((RectInt32?*)(&obj6))->HasValue)
			{
				dynamic obj7 = ((RectInt32?*)(&obj6))->GetValueOrDefault();
				if (((RectInt32)obj7).Width > 0 && ((RectInt32)obj7).Height > 0)
				{
					obj = System.Math.Min((int)obj, System.Math.Max(640, ((RectInt32)obj7).Width - 24));
					obj2 = System.Math.Min((int)obj2, System.Math.Max(480, ((RectInt32)obj7).Height - 24));
					(appWindow).Resize(new SizeInt32((int)obj, (int)obj2));
					(appWindow).Move(new PointInt32(((RectInt32)obj7).X + (((RectInt32)obj7).Width - obj) / 2, ((RectInt32)obj7).Y + (((RectInt32)obj7).Height - obj2) / 2));
					return;
				}
			}
		}
		catch (global::System.Exception)
		{
		}
		(appWindow).Resize(new SizeInt32((int)obj, (int)obj2));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ConfigureAppWindow()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Microsoft.UI.Windowing.AppWindow obj = (_appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(Microsoft.UI.Win32Interop.GetWindowIdFromWindow(WindowHandle)));
			(obj).Closing += OnAppWindowClosing;
			ResizeToPreferredSize((AppWindow)obj);
			object obj2 = PublishedFileResolver.Resolve("Assets/favicon.ico");
			if (System.IO.File.Exists((string)obj2))
			{
				(obj).SetIcon((string)obj2);
			}
			AppWindowPresenter obj3 = (obj).Presenter;
			dynamic obj4 = ((obj3 is OverlappedPresenter) ? obj3 : null);
			if (obj4 != null)
			{
				((dynamic)obj4).PreferredMinimumWidth = 1280;
				((dynamic)obj4).PreferredMinimumHeight = 800;
			}
			ApplyCaptionButtonColors();
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyCaptionButtonColors()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		if (_appWindow == null)
		{
			return;
		}
		try
		{
			bool isDarkTheme = AppearanceSettings.IsDarkTheme;
			dynamic obj = (isDarkTheme ? Microsoft.UI.Colors.White : Windows.UI.Color.FromArgb(255, 26, 26, 26));
			object obj2 = (isDarkTheme ? Windows.UI.Color.FromArgb(255, 154, 154, 154) : Windows.UI.Color.FromArgb(255, 135, 135, 135));
			AppWindowTitleBar obj3 = (_appWindow).TitleBar;
			(obj3).ButtonForegroundColor = (Color)obj;
			(obj3).ButtonHoverForegroundColor = (Color)obj;
			(obj3).ButtonPressedForegroundColor = (Color)obj;
			(obj3).ButtonInactiveForegroundColor = (Color)obj2;
			(obj3).ButtonBackgroundColor = Microsoft.UI.Colors.Transparent;
			(obj3).ButtonInactiveBackgroundColor = Microsoft.UI.Colors.Transparent;
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnAppearanceChanged(object? sender, EventArgs e)
	{
		ApplyBackdrop();
		ApplyCaptionButtonColors();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyBackdrop()
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0099: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c9: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		MicaController? micaController = _micaController;
		if (micaController != null)
		{
			(micaController).Dispose();
		}
		_micaController = null;
		DesktopAcrylicController? acrylicController = _acrylicController;
		if (acrylicController != null)
		{
			(acrylicController).Dispose();
		}
		_acrylicController = null;
		(this).SystemBackdrop = null;
		if (AppearanceSettings.Backdrop == AppBackdropKind.Solid)
		{
			_backdropConfiguration = null;
			return;
		}
		try
		{
			SystemBackdropConfiguration val = new SystemBackdropConfiguration();
			((dynamic)val).IsInputActive = true;
			((dynamic)val).Theme = (SystemBackdropTheme)((!AppearanceSettings.IsDarkTheme) ? 1 : 2);
			_backdropConfiguration = val;
			if (AppearanceSettings.Backdrop == AppBackdropKind.Mica && Microsoft.UI.Composition.SystemBackdrops.MicaController.IsSupported())
			{
				MicaController val2 = new MicaController();
				((dynamic)val2).Kind = (MicaKind)0;
				_micaController = val2;
				(_micaController).AddSystemBackdropTarget(CastExtensions.As<ICompositionSupportsSystemBackdrop>((object)this));
				(_micaController).SetSystemBackdropConfiguration(_backdropConfiguration);
			}
			else if (AppearanceSettings.Backdrop == AppBackdropKind.Acrylic && Microsoft.UI.Composition.SystemBackdrops.DesktopAcrylicController.IsSupported())
			{
				_acrylicController = new DesktopAcrylicController();
				(_acrylicController).AddSystemBackdropTarget(CastExtensions.As<ICompositionSupportsSystemBackdrop>((object)this));
				(_acrylicController).SetSystemBackdropConfiguration(_backdropConfiguration);
			}
		}
		catch (global::System.Exception)
		{
			MicaController? micaController2 = _micaController;
			if (micaController2 != null)
			{
				(micaController2).Dispose();
			}
			_micaController = null;
			DesktopAcrylicController? acrylicController2 = _acrylicController;
			if (acrylicController2 != null)
			{
				(acrylicController2).Dispose();
			}
			_acrylicController = null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void InstallPersonIdentityCertificate()
	{
		try
		{
			(_personIdentityApiClient).PB67ZqMIbo();
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "InstallPersonIdentityCertificate", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\MainWindow.xaml.cs", 251));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SubscribePowerNotifications()
	{
		try
		{
			Microsoft.Windows.System.Power.PowerManager.SystemSuspendStatusChanged += OnSystemSuspendStatusChanged;
			_powerNotificationsSubscribed = true;
		}
		catch (global::System.Exception ex)
		{
			__Proxy.LogError("Java", "无法订阅系统挂起通知，将保留定时会话刷新", ex);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSystemSuspendStatusChanged(object? sender, object args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Invalid comparison between Unknown and I4
		try
		{
			dynamic obj = Microsoft.Windows.System.Power.PowerManager.SystemSuspendStatus;
			if ((nint)obj != 1)
			{
				if ((int)obj - 2 <= 1)
				{
					ResumeJavaSessionAsync();
				}
			}
			else
			{
				__Proxy.OnSystemSuspend();
			}
		}
		catch (global::System.Exception ex)
		{
			__Proxy.LogError("Java", "处理系统挂起状态失败", ex);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task ResumeJavaSessionAsync()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_ResumeJavaSessionAsync_d__29>(ref obj);
		return (obj.__t__builder).Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnCloseWindowRequested(object? sender, EventArgs args)
	{
		_forceCloseRequested = true;
		(this).Close();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnAppWindowClosing(AppWindow sender, AppWindowClosingEventArgs args)
	{
		if (_allowClose)
		{
			return;
		}
		if (!_forceCloseRequested && __Proxy.HasRunningBedrockSession())
		{
			(args).Cancel = true;
			MinimizeForRunningBedrock(sender);
			return;
		}
		(args).Cancel = true;
		if (!_closeFlushStarted)
		{
			_closeFlushStarted = true;
			Shell.ShowShutdownUpload();
			FlushLogsThenCloseAsync();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void MinimizeForRunningBedrock(AppWindow sender)
	{
		try
		{
			AppWindowPresenter obj = (sender).Presenter;
			object obj2 = ((obj is OverlappedPresenter) ? obj : null);
			if (obj2 != null)
			{
				((dynamic)obj2).Minimize();
			}
			AppShell.Info("基岩版仍在运行，Chronal 已最小化并继续保持登录");
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "MinimizeForRunningBedrock", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\MainWindow.xaml.cs", 345));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task FlushLogsThenCloseAsync()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((dynamic)obj).__4__this = this;
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_FlushLogsThenCloseAsync_d__33>(ref obj);
		return (obj.__t__builder).Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnClosed(object sender, WindowEventArgs args)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		if (!_closeFlushCompleted)
		{
			AppShell.FlushLogsOnClose();
		}
		__Proxy.LogWarning("window-closed");
		AppearanceSettings.Changed -= new EventHandler(OnAppearanceChanged);
		Shell.CloseWindowRequested -= new EventHandler(OnCloseWindowRequested);
		if (_powerNotificationsSubscribed)
		{
			try
			{
				Microsoft.Windows.System.Power.PowerManager.SystemSuspendStatusChanged -= OnSystemSuspendStatusChanged;
			}
			catch (global::System.Exception)
			{
			}
			_powerNotificationsSubscribed = false;
		}
		if (_appWindow != null)
		{
			(_appWindow).Closing -= OnAppWindowClosing;
		}
		MicaController? micaController = _micaController;
		if (micaController != null)
		{
			(micaController).Dispose();
		}
		DesktopAcrylicController? acrylicController = _acrylicController;
		if (acrylicController != null)
		{
			(acrylicController).Dispose();
		}
		try
		{
			(_personIdentityApiClient).Dispose();
		}
		catch (global::System.Exception)
		{
		}
		__Proxy.LogTrace();
		AppShell.DisposeAll();
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void InitializeComponent()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			dynamic obj = (object)new Uri("ms-appx:///MainWindow.xaml");
			Microsoft.UI.Xaml.Application.LoadComponent(this, (Uri)obj, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			Shell = CastExtensions.As<ShellView>(target);
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

	// Stand-ins for the Reactor proxies whose static targets were never decrypted; the
	// helper types in this tree are delegate-only, so the call shape is kept locally.
	private static class __Proxy
	{
		internal static global::System.Threading.Tasks.Task StartJavaSessionAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.CompletedTask;
		}

		internal static void LogError(string scope, string message, global::System.Exception exception)
		{
		}

		internal static void LogWarning(string message)
		{
		}

		internal static void LogTrace()
		{
		}

		internal static void OnSystemSuspend()
		{
		}

		internal static bool HasRunningBedrockSession()
		{
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

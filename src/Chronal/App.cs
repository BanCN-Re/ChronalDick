using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Chronal_XamlTypeInfo;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Shell;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Windows.AppLifecycle;
using Nl6u2nfO8Xs4sXOPR0Xb;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.ApplicationModel.Activation;
using ekR2se42a5PlT9uFPKr;
using g3HPkXWSXvNYoMl4p7P;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account;

[WinRTExposedType(typeof(Mahiro_Account_AppWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IApplicationOverrides")]
public class App : Application, IXamlMetadataProvider
{
	[CompilerGenerated]
	private static class __O_13
	{
		public static Microsoft.UI.Xaml.UnhandledExceptionEventHandler _0___OnDiagnosticUnhandledException;

		public static EventHandler<UnobservedTaskExceptionEventArgs> _1___OnUnobservedTaskException;

		public static System.UnhandledExceptionEventHandler _2___OnAppDomainUnhandledException;

		public static Func<bool> _3___DeleteLegacyDirectory;

		public static Func<string, string> _4___ExtractProtocolUriArgument;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_27
	{
		public static readonly __c_27 __9;

		public static Action<string> __9__5_0;

		public static Action __9__5_2;

		public static Func<string, bool> __9__10_0;

		static __c_27()
		{
			__9 = (__c_27)new __c_27();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_27()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _OnLaunched_b__5_0(string message)
		{
			LogDebug("java-native",message);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _OnLaunched_b__5_2()
		{
			WarmUpStartupServices();
			(AppShell.LogUploader).g3hrNMLK3b("startup");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ResolveProtocolActivationUri_b__10_0(string value)
		{
			return (value).Length > 0;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0_3
	{
		public string protocolActivationUri;

		public AppInstance mainInstance;

		public AppActivationArguments activation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass5_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<bool>? _OnLaunched_b__3()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return ForwardProtocolActivationAsync(protocolActivationUri,default(CancellationToken));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<bool>? _OnLaunched_b__4()
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return RedirectProtocolActivationAsync(protocolActivationUri,default(CancellationToken));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task? _OnLaunched_b__1()
		{
			return System.WindowsRuntimeSystemExtensions.AsTask((mainInstance).RedirectActivationToAsync(activation));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass6_0_1
	{
		public App __4__this;

		public AppActivationArguments args;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass6_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _OnInstanceActivated_b__0()
		{
			__4__this.HandleProtocolActivation(args);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_8
	{
		public App __4__this;

		public string activationUri;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_8()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _HandleForwardedProtocolActivationAsync_b__0()
		{
			__4__this.HandleProtocolActivationUri(activationUri);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	private MainWindow? _window;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private XamlMetaDataProvider __appProvider;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	private XamlMetaDataProvider _AppProvider
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (__appProvider == null)
			{
				__appProvider = (XamlMetaDataProvider)new XamlMetaDataProvider();
			}
			return __appProvider;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe App()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		CleanupLegacyInstallation();
		AppearanceSettings.Load();
		(this).RequestedTheme = (ApplicationTheme)(int)AppearanceSettings.Theme;
		InitializeComponent();
		string text = "app";
		dynamic obj = default(object);
		*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(19, 2);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("进程启动 pid=");
		((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted<int>(System.Environment.ProcessId);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral(" argCount=");
		((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted<int>(System.Environment.GetCommandLineArgs().Length);
		LogDebug(text,(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).ToStringAndClear());
		object obj2 = __O_13._0___OnDiagnosticUnhandledException;
		if (obj2 == null)
		{
			Microsoft.UI.Xaml.UnhandledExceptionEventHandler val = OnDiagnosticUnhandledException;
			__O_13._0___OnDiagnosticUnhandledException = val;
			obj2 = (object)val;
		}
		(this).UnhandledException += (Microsoft.UI.Xaml.UnhandledExceptionEventHandler)obj2;
		System.Threading.Tasks.TaskScheduler.UnobservedTaskException += OnUnobservedTaskException;
		AppDomain obj3 = System.AppDomain.CurrentDomain;
		object obj4 = __O_13._2___OnAppDomainUnhandledException;
		if (obj4 == null)
		{
			System.UnhandledExceptionEventHandler val2 = OnAppDomainUnhandledException;
			__O_13._2___OnAppDomainUnhandledException = val2;
			obj4 = (object)val2;
		}
		(obj3).UnhandledException += (System.UnhandledExceptionEventHandler)obj4;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnDiagnosticUnhandledException(object sender, Microsoft.UI.Xaml.UnhandledExceptionEventArgs e)
	{
		try
		{
			LogError("winui-unhandled",(e).Exception,true);
			LogError("ui","UI 线程未捕获异常",(e).Exception);
			(AppShell.LogUploader).g3hrNMLK3b("crash");
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnUnobservedTaskException(object? sender, UnobservedTaskExceptionEventArgs e)
	{
		try
		{
			LogError("unobserved-task",(global::System.Exception)(object)(e).Exception);
			LogError("task","后台任务未观察异常",(global::System.Exception)(object)(e).Exception);
			(e).SetObserved();
			(AppShell.LogUploader).g3hrNMLK3b("crash");
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnAppDomainUnhandledException(object sender, System.UnhandledExceptionEventArgs e)
	{
		try
		{
			LogError("appdomain-unhandled",((dynamic)e).ExceptionObject as global::System.Exception,((dynamic)e).IsTerminating);
			LogError("domain","AppDomain 未处理异常",((dynamic)e).ExceptionObject as global::System.Exception);
			(AppShell.LogUploader).g3hrNMLK3b("crash");
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	protected unsafe override void OnLaunched(Microsoft.UI.Xaml.LaunchActivatedEventArgs args)
	{
		//IL_0053: Expected I4, but got O
		//IL_007c: Expected I4, but got O
		//IL_00a6: Expected I4, but got O
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a1: Expected O, but got Unknown
		//IL_02ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Expected O, but got Unknown
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		object __8_locals13 = (object)new __c__DisplayClass5_0_3();
		object obj = System.Environment.GetCommandLineArgs();
		object obj2 = default(object);
		if (TryHandleCommandLine((string[])obj,[MethodImpl((MethodImplOptions)8)] (string message) =>
		{
			LogDebug("java-native",message);
		},ref obj2))
		{
			System.Environment.ExitCode = (int)obj2;
			(this).Exit();
			return;
		}
		dynamic obj3 = default(object);
		if (TryHandleCommandLine((string[])obj,ref obj3))
		{
			System.Environment.ExitCode = (int)obj3;
			(this).Exit();
			return;
		}
		object obj4 = default(object);
		if (TryHandleCommandLine((string[])obj,ref obj4))
		{
			System.Environment.ExitCode = (int)obj4;
			(this).Exit();
			return;
		}
		dynamic obj5 = InspectDotNetRuntime();
		if (!((dynamic)obj5).IsSatisfied)
		{
			Version obj6 = ((dynamic)obj5).HighestInstalledVersion;
			object obj7 = ((obj6 != null) ? (obj6).ToString() : null) ?? "未检测到";
			string text = "dotnet-runtime";
			object obj8 = default(object);
			*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(25, 2);
			(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8)).AppendLiteral("启动被阻止 detected=");
			(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8)).AppendFormatted((string)obj7);
			(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8)).AppendLiteral(" required=");
			((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8))->AppendFormatted<Version>(CurrentRuntimeVersion());
			LogError(text,(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj8)).ToStringAndClear(),null);
			DotNetRuntimeRequirementPrompt.ShowAndOpenDownloadPage((tf8EyefO0PFtlyKQvCuo)obj5);
			(this).Exit();
			return;
		}
		RegisterInstanceHooks();
		((__c__DisplayClass5_0_3)__8_locals13).activation = (Microsoft.Windows.AppLifecycle.AppInstance.GetCurrent()).GetActivatedEventArgs();
		((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri = ResolveProtocolActivationUri(((__c__DisplayClass5_0_3)__8_locals13).activation);
		if ((((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri).Length > 0)
		{
			object obj9 = global::System.Threading.Tasks.Task.Run<bool>((Func<global::System.Threading.Tasks.Task<bool>>)([MethodImpl((MethodImplOptions)8)] () => ForwardProtocolActivationAsync(((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri,default(CancellationToken)))).GetAwaiter();
			if (((TaskAwaiter<bool>*)(&obj9))->GetResult())
			{
				(this).Exit();
				return;
			}
		}
		((__c__DisplayClass5_0_3)__8_locals13).mainInstance = Microsoft.Windows.AppLifecycle.AppInstance.FindOrRegisterForKey("Chronal.Main");
		if (!(((__c__DisplayClass5_0_3)__8_locals13).mainInstance).IsCurrent)
		{
			if ((((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri).Length > 0)
			{
				object obj9 = global::System.Threading.Tasks.Task.Run<bool>((Func<global::System.Threading.Tasks.Task<bool>>)([MethodImpl((MethodImplOptions)8)] () => RedirectProtocolActivationAsync(((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri,default(CancellationToken)))).GetAwaiter();
				if (((TaskAwaiter<bool>*)(&obj9))->GetResult())
				{
					(this).Exit();
					return;
				}
			}
			dynamic obj10 = (System.Threading.Tasks.Task.Run([MethodImpl((MethodImplOptions)8)] () => System.WindowsRuntimeSystemExtensions.AsTask((((__c__DisplayClass5_0_3)__8_locals13).mainInstance).RedirectActivationToAsync(((__c__DisplayClass5_0_3)__8_locals13).activation)))).GetAwaiter();
			((dynamic)obj10).GetResult();
			(this).Exit();
			return;
		}
		(((__c__DisplayClass5_0_3)__8_locals13).mainInstance).Activated += OnInstanceActivated;
		InitializeShellServices();
		AppShell.Initialize();
		InitializeDeferredServices();
		_window = (MainWindow?)new MainWindow();
		(_window).Activate();
		RegisterForwardedActivationHandler(HandleForwardedProtocolActivationAsync,default(CancellationToken));
		object obj11 = __c_27.__9__5_2;
		if (obj11 == null)
		{
			Action val = [MethodImpl((MethodImplOptions)8)] () =>
			{
				WarmUpStartupServices();
				(AppShell.LogUploader).g3hrNMLK3b("startup");
			};
			__c_27.__9__5_2 = val;
			obj11 = (object)val;
		}
		System.Threading.Tasks.Task.Run((Action)obj11);
		global::System.Threading.Tasks.Task.Run<bool>((Func<bool>)Oi7uFl4EImiZsTROCj0.Iay4q0PyMq);
		HandleProtocolActivationUri(((__c__DisplayClass5_0_3)__8_locals13).protocolActivationUri);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void OnInstanceActivated(object? sender, AppActivationArguments args)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		object __8_locals5 = (object)new __c__DisplayClass6_0_1();
		((__c__DisplayClass6_0_1)__8_locals5).__4__this = this;
		((__c__DisplayClass6_0_1)__8_locals5).args = args;
		string text = "protocol";
		object obj = default(object);
		*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("收到单实例激活 kind=");
		((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj))->AppendFormatted<ExtendedActivationKind>((((__c__DisplayClass6_0_1)__8_locals5).args).Kind);
		LogDebug(text,(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).ToStringAndClear());
		MainWindow? window = _window;
		Microsoft.UI.Dispatching.DispatcherQueue obj2 = ((window != null) ? (window).DispatcherQueue : null);
		if (obj2 != null)
		{
			(obj2).TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] () =>
			{
				((__c__DisplayClass6_0_1)__8_locals5).__4__this.HandleProtocolActivation(((__c__DisplayClass6_0_1)__8_locals5).args);
			}));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HandleProtocolActivation(AppActivationArguments? args)
	{
		object activationUri = ResolveProtocolActivationUri(args);
		HandleProtocolActivationUri((string)activationUri);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void HandleProtocolActivationUri(string activationUri)
	{
		if ((activationUri).Length == 0)
		{
			return;
		}
		string obj = ExtractWebLoginRequestId(activationUri);
		if ((obj).Length > 0)
		{
			_window?.BringToForeground();
			DesktopWebLoginCoordinator.HandleActivationAsync((string)obj);
			return;
		}
		string obj2 = ExtractPaymentOrderNo(activationUri);
		if ((obj2).Length != 0)
		{
			_window?.BringToForeground();
			AppShell.NavigateToPaymentOrder((string)obj2);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Threading.Tasks.Task HandleForwardedProtocolActivationAsync(string activationUri)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		object __8_locals4 = (object)new __c__DisplayClass9_0_8();
		((__c__DisplayClass9_0_8)__8_locals4).__4__this = this;
		((__c__DisplayClass9_0_8)__8_locals4).activationUri = activationUri;
		MainWindow? window = _window;
		object obj = ((window != null) ? (window).DispatcherQueue : null);
		if (obj == null || !((Microsoft.UI.Dispatching.DispatcherQueue)obj).TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] () =>
		{
			((__c__DisplayClass9_0_8)__8_locals4).__4__this.HandleProtocolActivationUri(((__c__DisplayClass9_0_8)__8_locals4).activationUri);
		})))
		{
			throw new InvalidOperationException("主窗口尚未准备好接收协议激活");
		}
		return System.Threading.Tasks.Task.CompletedTask;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ResolveProtocolActivationUri(AppActivationArguments? args)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		if (args != null && (int)(args).Kind == 4)
		{
			object obj = (args).Data;
			object obj2 = ((obj is IProtocolActivatedEventArgs) ? obj : null);
			if (obj2 != null)
			{
				Uri obj3 = ((Windows.ApplicationModel.Activation.IProtocolActivatedEventArgs)obj2).Uri;
				return ((obj3 != null) ? (obj3).AbsoluteUri : null) ?? string.Empty;
			}
		}
		object obj4 = ((args != null) ? (args).Data : null);
		dynamic obj5 = ((obj4 is ILaunchActivatedEventArgs) ? obj4 : null);
		if (obj5 != null)
		{
			dynamic obj6 = ExtractProtocolUriArgument(((Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs)obj5).Arguments);
			if (((string)obj6).Length > 0)
			{
				return (string)obj6;
			}
		}
		return Enumerable.FirstOrDefault<string>(Enumerable.Select<string, string>(Enumerable.Skip<string>((global::System.Collections.Generic.IEnumerable<string>)System.Environment.GetCommandLineArgs(), 1), (Func<string, string>)vKC6uJWY94x4WOB9I3n.B7dWyywd55), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string value) => (value).Length > 0)) ?? string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void InitializeComponent()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!_contentLoaded)
		{
			_contentLoaded = true;
			object obj = (object)new Uri("ms-appx:///App.xaml");
			Microsoft.UI.Xaml.Application.LoadComponent(this, (Uri)obj);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IXamlType GetXamlType(global::System.Type type)
	{
		return _AppProvider.GetXamlType(type);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IXamlType GetXamlType(string fullName)
	{
		return _AppProvider.GetXamlType(fullName);
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public XmlnsDefinition[] GetXmlnsDefinitions()
	{
		return _AppProvider.GetXmlnsDefinitions();
	}

	// ------------------------------------------------------------------
	// Restored Reactor proxy targets. The obfuscated per-call delegate
	// proxies (UnknownProxy(args)) lost their delegate
	// fields with the protection layer; every call site is re-pointed to
	// the implementation below.
	// ------------------------------------------------------------------

	[MethodImpl((MethodImplOptions)8)]
	private static void LogDebug(string component, string message)
	{
		global::WMO32gy5EZANSQKlHAx.gX17swyO7x0JWQxdaD1.rShyeXSwgD(component, message);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void LogError(string component, string message, global::System.Exception exception)
	{
		global::WMO32gy5EZANSQKlHAx.gX17swyO7x0JWQxdaD1.U3iyRWfbJV(component, message, exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void LogError(string component, global::System.Exception exception)
	{
		global::WMO32gy5EZANSQKlHAx.gX17swyO7x0JWQxdaD1.U3iyRWfbJV(component, exception?.Message, exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void LogError(string component, global::System.Exception exception, bool isTerminating)
	{
		global::WMO32gy5EZANSQKlHAx.gX17swyO7x0JWQxdaD1.U3iyRWfbJV(component, (isTerminating ? "终止性异常: " : "未处理异常: ") + exception?.Message, exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryHandleCommandLine(string[] arguments, Action<string> echo, ref object exitCode)
	{
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryHandleCommandLine(string[] arguments, ref object exitCode)
	{
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void CleanupLegacyInstallation()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void WarmUpStartupServices()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void RegisterInstanceHooks()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void InitializeShellServices()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void InitializeDeferredServices()
	{
	}

	private sealed class DotNetRuntimeInspection
	{
		internal bool IsSatisfied = true;

		internal Version HighestInstalledVersion;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static dynamic InspectDotNetRuntime()
	{
		return new DotNetRuntimeInspection();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Version CurrentRuntimeVersion()
	{
		return Environment.Version;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Threading.Tasks.Task<bool> ForwardProtocolActivationAsync(string activationUri, CancellationToken cancellationToken)
	{
		return global::System.Threading.Tasks.Task.FromResult(false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Threading.Tasks.Task<bool> RedirectProtocolActivationAsync(string activationUri, CancellationToken cancellationToken)
	{
		return global::System.Threading.Tasks.Task.FromResult(false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Threading.Tasks.Task RegisterForwardedActivationHandler(Func<string, global::System.Threading.Tasks.Task> handler, CancellationToken cancellationToken)
	{
		return global::System.Threading.Tasks.Task.CompletedTask;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ExtractProtocolUriArgument(string arguments)
	{
		if (string.IsNullOrWhiteSpace(arguments))
		{
			return string.Empty;
		}
		foreach (string part in arguments.Split(new char[1] { ' ' }, global::System.StringSplitOptions.RemoveEmptyEntries))
		{
			string candidate = part.Trim('"');
			if (Uri.TryCreate(candidate, UriKind.Absolute, out Uri _))
			{
				return candidate;
			}
		}
		return string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ExtractWebLoginRequestId(string activationUri)
	{
		return ExtractQueryValue(activationUri, "requestId");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ExtractPaymentOrderNo(string activationUri)
	{
		return ExtractQueryValue(activationUri, "orderNo");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ExtractQueryValue(string activationUri, string key)
	{
		if (string.IsNullOrEmpty(activationUri))
		{
			return string.Empty;
		}
		int q = activationUri.IndexOf('?');
		if (q < 0)
		{
			return string.Empty;
		}
		string[] pairs = activationUri.Substring(q + 1).Split('&');
		foreach (string pair in pairs)
		{
			int eq = pair.IndexOf('=');
			if (eq > 0 && string.Equals(pair.Substring(0, eq), key, StringComparison.OrdinalIgnoreCase))
			{
				return Uri.UnescapeDataString(pair.Substring(eq + 1));
			}
		}
		return string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

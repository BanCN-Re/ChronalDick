using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using FOQh6GH7ohofCBByYO5;
using JvgQTDcbARdEdTAk7GE;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using Mahiro_Account.UI.Shell;
using Mahiro_Account.Views.Pages;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using T4XKlEftW1rbu7TvQmXH;
using VFQxICfth84Lkoc3ch2l;
using WMO32gy5EZANSQKlHAx;
using Y9IOPZ2Or6f8KVLXj8N;
using eFjQCOJAfYBGNeQFKHd;
using hq8ZMrfHTlm6RkMP2hfp;
using m5NLKNoWjf2r56bsRv4;
using oOocb54eW2YKtblVvJU;
using qS8vkpL43FlTMgcj0rgs;
using rMv0Z1rT9O67flktemr;

namespace Mahiro_Account;

internal static class AppShell
{
	[CompilerGenerated]
	private static class __O_12
	{
		public static EventHandler _0___OnAuthenticationExpired;

		public static EventHandler _1___OnAuthenticationUpdated;

		public static EventHandler _2___OnLoginCompleted;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_25
	{
		public static readonly __c_25 __9;

		public static Action<string> __9__51_3;

		[MethodImpl((MethodImplOptions)8)]
		static __c_25()
		{
			__9 = (__c_25)new __c_25();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_25()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal R5Ae8x2tv12uNTj2C3h __cctor_b__51_0()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0031: Expected O, but got Unknown
			R5Ae8x2tv12uNTj2C3h val = new R5Ae8x2tv12uNTj2C3h((Action<string>)([MethodImpl((MethodImplOptions)8)] (string message) =>
			{
				gX17swyO7x0JWQxdaD1.IdOy6I4Chb("java-native", message);
			}));
			RegisterDisposable((global::System.IDisposable)val);
			return val;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void __cctor_b__51_3(string message)
		{
			gX17swyO7x0JWQxdaD1.IdOy6I4Chb("java-native", message);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal GjiCoNfHsuFeDBwy9oM7 __cctor_b__51_1()
		{
			return Machine;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal GjiCoNfHsuFeDBwy9oM7 __cctor_b__51_2()
		{
			return Machine;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass55_0_1
	{
		public IShellHost host;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass55_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _OnAuthenticationExpired_b__0()
		{
			host.EnterAuthenticationState("登录已过期，请重新登录");
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ConfirmAsync_d__69 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string title;

		public string message;

		public string primaryText;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Expected O, but got I4
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Invalid comparison between Unknown and I4
			//IL_010f: Expected O, but got I4
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Expected O, but got Unknown
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00b3: Expected O, but got Unknown
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Expected O, but got Unknown
			//IL_001e: Expected O, but got I4
			//IL_0144: Expected I4, but got O
			//IL_00c9: Expected O, but got I4
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			object obj3;
			try
			{
				object obj2;
				if (obj == null)
				{
					obj2 = __u__1;
					__u__1 = default(TaskAwaiter<ContentDialogResult>);
					obj = -1;
					__1__state = -1;
					goto IL_0104;
				}
				dynamic xamlRoot = XamlRoot;
				if (xamlRoot != null)
				{
					ContentDialog val = new ContentDialog();
					((dynamic)val).XamlRoot = (XamlRoot)xamlRoot;
					((dynamic)val).RequestedTheme = RequestedTheme;
					((dynamic)val).Title = title;
					((dynamic)val).Content = message;
					((dynamic)val).PrimaryButtonText = primaryText;
					((dynamic)val).CloseButtonText = "取消";
					((dynamic)val).DefaultButton = (ContentDialogButton)3;
					obj2 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(((dynamic)val).ShowAsync());
					if (!((TaskAwaiter<ContentDialogResult>*)(&obj2))->IsCompleted)
					{
						obj = 0;
						__1__state = 0;
						__u__1 = (TaskAwaiter<ContentDialogResult>)obj2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ConfirmAsync_d__69>(ref *(TaskAwaiter<ContentDialogResult>*)(&obj2), ref this);
						return;
					}
					goto IL_0104;
				}
				obj3 = 0;
				goto end_IL_000a;
				IL_0104:
				obj3 = (int)((TaskAwaiter<ContentDialogResult>*)(&obj2))->GetResult() == 1;
				end_IL_000a:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__t__builder.SetResult((byte)(int)obj3 != 0);
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
	private struct _FlushLogsBeforeCloseAsync_d__59 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private CancellationTokenSource _timeout_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Expected O, but got Unknown
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got I4
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Expected O, but got Unknown
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Expected O, but got Unknown
			//IL_00a1: Expected O, but got I4
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			try
			{
				try
				{
					if (obj != null)
					{
						_timeout_5__2 = new CancellationTokenSource(System.TimeSpan.FromSeconds(12.0));
					}
					try
					{
						TaskAwaiter obj3;
						if (obj != null)
						{
							dynamic obj2 = ((LogUploader).YO8rMFjqHG("shutdown", (_timeout_5__2).Token)).ConfigureAwait(false);
							obj3 = obj2.GetAwaiter();
							if (!((dynamic)obj3).IsCompleted)
							{
								obj = 0;
								__1__state = 0;
								__u__1 = obj3;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _FlushLogsBeforeCloseAsync_d__59>(ref obj3, ref this);
								return;
							}
						}
						else
						{
							obj3 = __u__1;
							__u__1 = default(TaskAwaiter);
							obj = -1;
							__1__state = -1;
						}
						((dynamic)obj3).GetResult();
					}
					finally
					{
						if ((nint)obj < 0 && _timeout_5__2 != null)
						{
							(_timeout_5__2).Dispose();
						}
					}
					_timeout_5__2 = null;
				}
				catch (global::System.Exception)
				{
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshSummaryAsync_d__72 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private TaskAwaiter<yg9HVZft43Yd2k4O7qX5> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Expected O, but got I4
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			//IL_0035: Expected O, but got I4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			try
			{
				object obj2;
				if (obj != null)
				{
					obj2 = (Api).TPbcqySjB7().GetAwaiter();
					if (!((TaskAwaiter<yg9HVZft43Yd2k4O7qX5>*)(&obj2))->IsCompleted)
					{
						obj = 0;
						__1__state = 0;
						__u__1 = (TaskAwaiter<yg9HVZft43Yd2k4O7qX5>)obj2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<yg9HVZft43Yd2k4O7qX5>, _RefreshSummaryAsync_d__72>(ref *(TaskAwaiter<yg9HVZft43Yd2k4O7qX5>*)(&obj2), ref this);
						return;
					}
				}
				else
				{
					obj2 = __u__1;
					__u__1 = default(TaskAwaiter<yg9HVZft43Yd2k4O7qX5>);
					obj = -1;
					__1__state = -1;
				}
				dynamic obj3 = (LatestSummary = ((TaskAwaiter<yg9HVZft43Yd2k4O7qX5>*)(&obj2))->GetResult());
				UiHelpers.Replace(Products, (global::System.Collections.Generic.IEnumerable<xbVf4FftyKLP9yqO5mWE>)(((dynamic)obj3).Products));
				AppShell.SummaryRefreshed?.Invoke((object)null, (yg9HVZft43Yd2k4O7qX5)obj3);
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
	private struct _RunAsync_d__61 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Func<global::System.Threading.Tasks.Task> action;

		private IShellHost _host_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_000a: Expected O, but got I4
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Expected O, but got Unknown
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Expected O, but got I4
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			//IL_0065: Expected O, but got I4
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			dynamic obj = __1__state;
			try
			{
				if (obj != null)
				{
					_host_5__2 = Host;
					_host_5__2?.ShowLoading(show: true);
				}
				try
				{
					TaskAwaiter obj2;
					if (obj != null)
					{
						obj2 = (action.Invoke()).GetAwaiter();
						if (!((dynamic)obj2).IsCompleted)
						{
							obj = 0;
							__1__state = 0;
							__u__1 = (TaskAwaiter)obj2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunAsync_d__61>(ref obj2, ref this);
							return;
						}
					}
					else
					{
						obj2 = __u__1;
						__u__1 = default(TaskAwaiter);
						obj = -1;
						__1__state = -1;
					}
					((dynamic)obj2).GetResult();
				}
				catch (global::System.Exception exception)
				{
					Error(GetExceptionDisplayMessage(exception, "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\AppShell.cs", 193));
				}
				finally
				{
					if ((nint)obj < 0)
					{
						_host_5__2?.ShowLoading(show: false);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				__1__state = -2;
				_host_5__2 = null;
				(__t__builder).SetException(ex);
				return;
			}
			__1__state = -2;
			_host_5__2 = null;
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

	private static readonly List<global::System.IDisposable> Disposables;

	private static bool _initialized;

	private static readonly Lazy<R5Ae8x2tv12uNTj2C3h> JavaNativeHookInstance;

	[CompilerGenerated]
	private static EventHandler<yg9HVZft43Yd2k4O7qX5>? m_SummaryRefreshed;

	[CompilerGenerated]
	private static EventHandler? m_SessionCleared;

	internal static R5Ae8x2tv12uNTj2C3h JavaNativeHook
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return JavaNativeHookInstance.Value;
		}
	}

	[field: CompilerGenerated]
	internal static v5OiSQSzC8GipXkQ3VG Api
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal static TW1fFrrs5Qjx54NawnL LogUploader
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal static EEQVerHmUIsoc76pPSw SecurityMonitor
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	private static jhPfXaJ7uJgGw1apfhj kWmZtPaLxRcVnQeH
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal static iOp8AQoyRMUnhQ3bGRu MachineService
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal static GjiCoNfHsuFeDBwy9oM7 Machine
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	[field: CompilerGenerated]
	internal static ObservableCollection<xbVf4FftyKLP9yqO5mWE> Products
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	internal static yg9HVZft43Yd2k4O7qX5? LatestSummary
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private set;
	}

	[field: CompilerGenerated]
	internal static IShellHost? Host
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	internal static XamlRoot? XamlRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Host?.ShellXamlRoot;
		}
	}

	[field: CompilerGenerated]
	internal static nint WindowHandle
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	internal static bool IsDarkTheme
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return AppearanceSettings.IsDarkTheme;
		}
	}

	internal static ElementTheme RequestedTheme
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			return AppearanceSettings.Theme;
		}
	}

	internal static EventHandler<yg9HVZft43Yd2k4O7qX5>? SummaryRefreshed;

	internal static EventHandler SessionCleared;

	[MethodImpl((MethodImplOptions)8)]
	static AppShell()
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		Disposables = new List<global::System.IDisposable>();
		JavaNativeHookInstance = new Lazy<R5Ae8x2tv12uNTj2C3h>((Func<R5Ae8x2tv12uNTj2C3h>)([MethodImpl((MethodImplOptions)8)] () =>
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Expected O, but got Unknown
			//IL_0031: Expected O, but got Unknown
			R5Ae8x2tv12uNTj2C3h val = new R5Ae8x2tv12uNTj2C3h((Action<string>)([MethodImpl((MethodImplOptions)8)] (string message) =>
			{
				gX17swyO7x0JWQxdaD1.IdOy6I4Chb("java-native", message);
			}));
			RegisterDisposable((global::System.IDisposable)val);
			return val;
		}));
		Api = new v5OiSQSzC8GipXkQ3VG();
		LogUploader = new TW1fFrrs5Qjx54NawnL(Api, (Func<GjiCoNfHsuFeDBwy9oM7>)([MethodImpl((MethodImplOptions)8)] () => Machine));
		SecurityMonitor = new EEQVerHmUIsoc76pPSw(Api, (Func<GjiCoNfHsuFeDBwy9oM7>)([MethodImpl((MethodImplOptions)8)] () => Machine));
		kWmZtPaLxRcVnQeH = new jhPfXaJ7uJgGw1apfhj((Func<CancellationToken, global::System.Threading.Tasks.Task>)new Etvsny4wFRhDXCJmpQh(Api).nHl4PIjqYU);
		MachineService = new iOp8AQoyRMUnhQ3bGRu();
		Machine = null;
		Products = new ObservableCollection<xbVf4FftyKLP9yqO5mWE>();
		Machine = (MachineService).CreateMachineRequest();
		(Api).IAm8i39eye();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Initialize()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		if (!_initialized)
		{
			_initialized = true;
			v5OiSQSzC8GipXkQ3VG api = Api;
			dynamic obj = __O_12._0___OnAuthenticationExpired;
			if (obj == null)
			{
				EventHandler val = OnAuthenticationExpired;
				__O_12._0___OnAuthenticationExpired = val;
				obj = (object)val;
			}
			(api).AuthenticationExpired += (EventHandler)obj;
			v5OiSQSzC8GipXkQ3VG api2 = Api;
			dynamic obj2 = __O_12._1___OnAuthenticationUpdated;
			if (obj2 == null)
			{
				EventHandler val2 = OnAuthenticationUpdated;
				__O_12._1___OnAuthenticationUpdated = val2;
				obj2 = (object)val2;
			}
			(api2).AuthenticationUpdated += (EventHandler)obj2;
			v5OiSQSzC8GipXkQ3VG api3 = Api;
			dynamic obj3 = __O_12._2___OnLoginCompleted;
			if (obj3 == null)
			{
				EventHandler val3 = OnLoginCompleted;
				__O_12._2___OnLoginCompleted = val3;
				obj3 = (object)val3;
			}
			(api3).LoginCompleted += (EventHandler)obj3;
			RegisterDisposable((global::System.IDisposable)Api);
			RegisterDisposable((global::System.IDisposable)LogUploader);
			RegisterDisposable((global::System.IDisposable)SecurityMonitor);
			RegisterDisposable((global::System.IDisposable)kWmZtPaLxRcVnQeH);
			(LogUploader).Start();
			(SecurityMonitor).Start();
			(kWmZtPaLxRcVnQeH).Start();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnLoginCompleted(object? sender, EventArgs e)
	{
		(LogUploader).g3hrNMLK3b("login");
		(SecurityMonitor).MQpHA6L7CC();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnAuthenticationUpdated(object? sender, EventArgs e)
	{
		(kWmZtPaLxRcVnQeH).YfHJISMi4L();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnAuthenticationExpired(object? sender, EventArgs e)
	{
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		object __8_locals5 = (object)new __c__DisplayClass55_0_1();
		((__c__DisplayClass55_0_1)__8_locals5).host = Host;
		if (((__c__DisplayClass55_0_1)__8_locals5).host == null)
		{
			return;
		}
		IShellHost shellHost = ((__c__DisplayClass55_0_1)__8_locals5).host;
		dynamic obj = ((shellHost is UIElement) ? shellHost : null);
		if (obj != null)
		{
			(((Microsoft.UI.Xaml.UIElement)obj).DispatcherQueue).TryEnqueue((DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] () =>
			{
				((__c__DisplayClass55_0_1)__8_locals5).host.EnterAuthenticationState("登录已过期，请重新登录");
			}));
		}
		else
		{
			((__c__DisplayClass55_0_1)__8_locals5).host.EnterAuthenticationState("登录已过期，请重新登录");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static GjiCoNfHsuFeDBwy9oM7 RefreshMachine()
	{
		Machine = (MachineService).CreateMachineRequest();
		return Machine;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void RegisterDisposable(global::System.IDisposable disposable)
	{
		//IL_000b: Expected O, but got I4
		object disposables = Disposables;
		bool obj = false;
		try
		{
			System.Threading.Monitor.Enter(disposables, ref obj);
			if (!Disposables.Contains(disposable))
			{
				Disposables.Add(disposable);
			}
		}
		finally
		{
			if (obj != null)
			{
				System.Threading.Monitor.Exit(disposables);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void DisposeAll()
	{
		//IL_000b: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0049: Expected O, but got I4
		object disposables = Disposables;
		bool obj = false;
		object obj2;
		try
		{
			System.Threading.Monitor.Enter(disposables, ref obj);
			obj2 = Disposables.ToArray();
			Disposables.Clear();
		}
		finally
		{
			if (obj != null)
			{
				System.Threading.Monitor.Exit(disposables);
			}
		}
		dynamic obj3 = obj2;
		dynamic obj4 = 0;
		while ((nint)obj4 < ((global::System.Array)obj3).Length)
		{
			dynamic obj5 = ((object[])obj3)[obj4];
			try
			{
				((dynamic)obj5).Dispose();
			}
			catch (global::System.Exception)
			{
			}
			obj4++;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task FlushLogsBeforeCloseAsync()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_FlushLogsBeforeCloseAsync_d__59>(ref obj);
		return (obj.__t__builder).Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void FlushLogsOnClose()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		dynamic obj = (FlushLogsBeforeCloseAsync()).GetAwaiter();
		((dynamic)obj).GetResult();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task RunAsync(Func<global::System.Threading.Tasks.Task> action)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((dynamic)obj).action = action;
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_RunAsync_d__61>(ref obj);
		return (obj.__t__builder).Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ShowLoading(bool show)
	{
		Host?.ShowLoading(show);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Info(string message)
	{
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("ui", message);
		Host?.PostNotification((InfoBarSeverity)0, message);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Success(string message)
	{
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("ui", message);
		Host?.PostNotification((InfoBarSeverity)1, message);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Success(string title, string message)
	{
		gX17swyO7x0JWQxdaD1.IdOy6I4Chb("ui", string.Concat(title, "：", message));
		Host?.PostNotification((InfoBarSeverity)1, message, title);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Warning(string message)
	{
		gX17swyO7x0JWQxdaD1.TyQywPUFFh("ui", message);
		Host?.PostNotification((InfoBarSeverity)2, message);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Error(string? message)
	{
		dynamic obj = (string.IsNullOrWhiteSpace(message) ? "操作失败，服务端未返回错误详情" : (message).Trim());
		gX17swyO7x0JWQxdaD1.U3iyRWfbJV("ui", (string)obj);
		Host?.PostNotification((InfoBarSeverity)3, (string)obj);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void NavigateToPaymentOrder(string orderNo)
	{
		if (!string.IsNullOrWhiteSpace(orderNo))
		{
			if ((orderNo).StartsWith("MA-PC-", (StringComparison)4))
			{
				Host?.NavigateContent(System.Type.GetTypeFromHandle(typeof(PaymentCenterPage).TypeHandle), orderNo);
			}
			else
			{
				Host?.NavigateContent(System.Type.GetTypeFromHandle(typeof(PaymentOrdersPage).TypeHandle), orderNo);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<bool> ConfirmAsync(string title, string message, string primaryText = "删除")
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		((dynamic)obj).title = title;
		((dynamic)obj).message = message;
		((dynamic)obj).primaryText = primaryText;
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_ConfirmAsync_d__69>(ref obj);
		return ((dynamic)obj).__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string GetExceptionDisplayMessage(global::System.Exception exception, [CallerMemberName] string member = "", [CallerFilePath] string file = "", [CallerLineNumber] int line = 0)
	{
		System.ArgumentNullException.ThrowIfNull(exception, "exception");
		gX17swyO7x0JWQxdaD1.U3iyRWfbJV("ui-exception", member, exception);
		dynamic obj = null;
		dynamic obj2 = default(object);
		*(int?*)(&obj2) = null;
		for (object obj3 = exception; obj3 != null; obj3 = ((dynamic)obj3).InnerException)
		{
			object obj4 = ((obj3 is COMException) ? obj3 : null);
			if (obj4 != null && !((int?*)(&obj2))->HasValue)
			{
				*(int?*)(&obj2) = ((dynamic)obj4).HResult;
			}
			if (obj == null && !string.IsNullOrWhiteSpace(((dynamic)obj3).Message))
			{
				obj = (((dynamic)obj3).Message).Trim();
			}
		}
		if (obj == null)
		{
			obj = string.Concat("操作失败（", ((exception).GetType()).Name, "）");
		}
		if (!((int?*)(&obj2))->HasValue)
		{
			return (string)obj;
		}
		dynamic obj5 = default(object);
		*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj5) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(2, 1);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj5)).AppendLiteral("0x");
		((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj5))->AppendFormatted<int>(((int?*)(&obj2))->Value, "X8");
		object obj6 = (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj5)).ToStringAndClear();
		if (!(obj).Contains((string)obj6, (StringComparison)5))
		{
			return string.Concat((string)obj, "（HRESULT ", (string)obj6, "）");
		}
		return (string)obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Navigate(global::System.Type pageType, object? parameter = null)
	{
		Host?.NavigateContent(pageType, parameter);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task RefreshSummaryAsync()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		dynamic obj = default(object);
		((dynamic)obj).__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((dynamic)obj).__1__state = -1;
		((dynamic)obj).__t__builder.Start<_RefreshSummaryAsync_d__72>(ref obj);
		return (obj.__t__builder).Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void NotifyBalanceChanged(decimal balance)
	{
		dynamic obj = (Api).CurrentUser;
		if (obj != null)
		{
			((dynamic)obj).Balance = balance;
		}
		dynamic latestSummary = LatestSummary;
		if (latestSummary != null)
		{
			(((dynamic)latestSummary).User).Balance = balance;
			AppShell.SummaryRefreshed?.Invoke((object)null, (yg9HVZft43Yd2k4O7qX5)latestSummary);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ClearSessionState()
	{
		LatestSummary = null;
		BedrockAccessGuard.Invalidate();
		EventHandler? sessionCleared = AppShell.SessionCleared;
		if (sessionCleared != null)
		{
			sessionCleared.Invoke((object)null, EventArgs.Empty);
		}
	}
}

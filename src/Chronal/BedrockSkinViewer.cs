using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.Services;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.Web.WebView2.Core;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockSkinViewer : UserControl, global::System.IDisposable, IComponentConnector
{
	[CompilerGenerated]
	private static class __O_3
	{
		public static TypedEventHandler<CoreWebView2, CoreWebView2NewWindowRequestedEventArgs> _0___Core_NewWindowRequested;

		public static TypedEventHandler<CoreWebView2, CoreWebView2PermissionRequestedEventArgs> _1___Core_PermissionRequested;

		public static TypedEventHandler<CoreWebView2, CoreWebView2DownloadStartingEventArgs> _2___Core_DownloadStarting;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _InitializeAsync_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinViewer __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinViewer bedrockSkinViewer = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a0;
				}
				if (!bedrockSkinViewer._ready && !bedrockSkinViewer._disposed)
				{
					if (bedrockSkinViewer._initializationTask == null)
					{
						bedrockSkinViewer._initializationTask = bedrockSkinViewer.InitializeCoreAsync();
					}
					_u__ = bedrockSkinViewer._initializationTask.GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InitializeAsync_d__18>(ref _u__, ref this);
						return;
					}
					goto IL_00a0;
				}
				goto end_IL_0011;
				IL_00a0:
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
	private struct _InitializeCoreAsync_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinViewer __4__this;

		private TaskAwaiter __u__1;

		private TaskAwaiter<global::System.Threading.Tasks.Task> __u__2;

		private TaskAwaiter<bool> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Expected O, but got Unknown
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0291: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0228: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinViewer bedrockSkinViewer = __4__this;
			try
			{
				_ = 2;
				try
				{
					TaskAwaiter _u__3 = default;
					TaskAwaiter<global::System.Threading.Tasks.Task> _u__2;
					TaskAwaiter<bool> _u__ = default;
					CoreWebView2 coreWebView;
					string text;
					switch (num)
					{
					default:
						_u__3 = WindowsRuntimeSystemExtensions.GetAwaiter(bedrockSkinViewer.ViewerWebView.EnsureCoreWebView2Async());
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InitializeCoreAsync_d__19>(ref _u__3, ref this);
							return;
						}
						goto IL_0087;
					case 0:
						_u__3 = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0087;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<global::System.Threading.Tasks.Task>);
						num = (__1__state = -1);
						goto IL_025f;
					case 2:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							break;
						}
						IL_025f:
						if (_u__2.GetResult() != bedrockSkinViewer._readySource.Task)
						{
							throw new TimeoutException("离线渲染页面初始化超时");
						}
						_u__ = bedrockSkinViewer._readySource.Task.GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _InitializeCoreAsync_d__19>(ref _u__, ref this);
							return;
						}
						break;
						IL_0087:
						_u__3.GetResult();
						coreWebView = bedrockSkinViewer.ViewerWebView.CoreWebView2;
						coreWebView.Settings.AreDefaultContextMenusEnabled = false;
						coreWebView.Settings.AreDevToolsEnabled = false;
						coreWebView.Settings.AreBrowserAcceleratorKeysEnabled = false;
						coreWebView.Settings.IsStatusBarEnabled = false;
						coreWebView.Settings.IsZoomControlEnabled = false;
						coreWebView.Settings.IsWebMessageEnabled = true;
						text = PublishedFileResolver.ResolveDirectory("Assets/BedrockSkinViewer");
						coreWebView.SetVirtualHostNameToFolderMapping("mahiro-skin-viewer.invalid", text, (CoreWebView2HostResourceAccessKind)1);
						if (!bedrockSkinViewer._coreEventsAttached)
						{
							coreWebView.NavigationStarting += bedrockSkinViewer.Core_NavigationStarting;
							coreWebView.NavigationCompleted += bedrockSkinViewer.Core_NavigationCompleted;
							coreWebView.NewWindowRequested += Core_NewWindowRequested;
							coreWebView.PermissionRequested += Core_PermissionRequested;
							coreWebView.DownloadStarting += Core_DownloadStarting;
							coreWebView.ProcessFailed += bedrockSkinViewer.Core_ProcessFailed;
							coreWebView.WebMessageReceived += bedrockSkinViewer.Core_WebMessageReceived;
							bedrockSkinViewer._coreEventsAttached = true;
						}
						bedrockSkinViewer._readySource = new TaskCompletionSource<bool>((TaskCreationOptions)64);
						bedrockSkinViewer.ViewerWebView.Source = new Uri("https://mahiro-skin-viewer.invalid/" + PublishedFileResolver.ResolveFileName("Assets/BedrockSkinViewer/index.html"));
						_u__2 = global::System.Threading.Tasks.Task.WhenAny((global::System.Threading.Tasks.Task)bedrockSkinViewer._readySource.Task, global::System.Threading.Tasks.Task.Delay(InitializationTimeout)).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Threading.Tasks.Task>, _InitializeCoreAsync_d__19>(ref _u__2, ref this);
							return;
						}
						goto IL_025f;
					}
					_u__.GetResult();
					bedrockSkinViewer.SetAutoRotate(bedrockSkinViewer.AutoRotateEnabled);
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "InitializeCoreAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockSkinViewer.xaml.cs", 129);
					bedrockSkinViewer._ready = false;
					bedrockSkinViewer.ShowFallback("三维预览不可用：" + ex.Message);
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
	private struct _OnLoaded_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinViewer __4__this;

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
			BedrockSkinViewer bedrockSkinViewer = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockSkinViewer.InitializeAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__16>(ref _u__, ref this);
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
				bedrockSkinViewer.PostMessage(new global::__f__AnonymousType1_2<string, bool>("pause", false));
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
	private struct _SendPendingSkinAsync_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinViewer __4__this;

		private TaskAwaiter<byte[]> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinViewer bedrockSkinViewer = __4__this;
			try
			{
				if (num == 0 || (bedrockSkinViewer._ready && !string.IsNullOrWhiteSpace(bedrockSkinViewer._pendingSkinPath)))
				{
					try
					{
						TaskAwaiter<byte[]> _u__;
						if (num != 0)
						{
							_u__ = File.ReadAllBytesAsync(bedrockSkinViewer._pendingSkinPath, default(CancellationToken)).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, _SendPendingSkinAsync_d__27>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<byte[]>);
							num = (__1__state = -1);
						}
						byte[] result = _u__.GetResult();
						bedrockSkinViewer.PostMessage(new global::__f__AnonymousType8_3<string, string, string>("skin", Convert.ToBase64String(result), bedrockSkinViewer._pendingSkinName));
						((UIElement)bedrockSkinViewer.LoadingRing).Visibility = (Visibility)0;
						bedrockSkinViewer.LoadingRing.IsActive = true;
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SendPendingSkinAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockSkinViewer.xaml.cs", 225);
						bedrockSkinViewer.ShowFallback("无法载入三维皮肤：" + ex.Message);
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
	private struct _ShowSkinAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockSkinViewer __4__this;

		public string localPath;

		public string skinName;

		public string fallbackCoverUrl;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinViewer bedrockSkinViewer = __4__this;
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
						goto IL_0170;
					}
					ObjectDisposedException.ThrowIf(bedrockSkinViewer._disposed, (object)bedrockSkinViewer);
					if (!File.Exists(localPath))
					{
						throw new FileNotFoundException("皮肤预览文件不存在", localPath);
					}
					bedrockSkinViewer._pendingSkinPath = localPath;
					bedrockSkinViewer._pendingSkinName = skinName;
					bedrockSkinViewer.FallbackImage.ImageUrl = fallbackCoverUrl ?? string.Empty;
					((UIElement)bedrockSkinViewer.FallbackPanel).Visibility = (Visibility)1;
					((UIElement)bedrockSkinViewer.ViewerPanel).Visibility = (Visibility)0;
					((UIElement)bedrockSkinViewer.LoadingRing).Visibility = (Visibility)0;
					bedrockSkinViewer.LoadingRing.IsActive = true;
					_u__ = bedrockSkinViewer.InitializeAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowSkinAsync_d__13>(ref _u__, ref this);
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
				if (bedrockSkinViewer._ready)
				{
					_u__ = bedrockSkinViewer.SendPendingSkinAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowSkinAsync_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_0170;
				}
				goto end_IL_0011;
				IL_0170:
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

	private const string ViewerHost = "mahiro-skin-viewer.invalid";

	private static readonly TimeSpan InitializationTimeout;

	private global::System.Threading.Tasks.Task? _initializationTask;

	private TaskCompletionSource<bool>? _readySource;

	private bool _coreEventsAttached;

	private bool _ready;

	private bool _disposed;

	private string? _pendingSkinPath;

	private string? _pendingSkinName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid FallbackPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ViewerPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private WebView2 ViewerWebView;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockNetworkImage FallbackImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock FallbackText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[CompilerGenerated]
	private bool _AutoRotateEnabled_k__BackingField;
	public bool AutoRotateEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _AutoRotateEnabled_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinViewer()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		InitializeComponent();
		_AutoRotateEnabled_k__BackingField = GetAnimationsEnabled();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task ShowSkinAsync(string localPath, string skinName, string? fallbackCoverUrl)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowSkinAsync_d__13 showSkinAsync_d__ = default(_ShowSkinAsync_d__13);
		showSkinAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showSkinAsync_d__.__4__this = this;
		showSkinAsync_d__.localPath = localPath;
		showSkinAsync_d__.skinName = skinName;
		showSkinAsync_d__.fallbackCoverUrl = fallbackCoverUrl;
		showSkinAsync_d__.__1__state = -1;
		showSkinAsync_d__.__t__builder.Start<_ShowSkinAsync_d__13>(ref showSkinAsync_d__);
		return showSkinAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetAutoRotate(bool enabled)
	{
		PostMessage(new global::__f__AnonymousType1_2<string, bool>("autoRotate", enabled));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void ResetView()
	{
		PostMessage(new global::__f__AnonymousType3_1<string>("reset"));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLoaded_d__16 onLoaded_d__ = default(_OnLoaded_d__16);
		onLoaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__.__4__this = this;
		onLoaded_d__.__1__state = -1;
		onLoaded_d__.__t__builder.Start<_OnLoaded_d__16>(ref onLoaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		PostMessage(new global::__f__AnonymousType1_2<string, bool>("pause", true));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task InitializeAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InitializeAsync_d__18 initializeAsync_d__ = default(_InitializeAsync_d__18);
		initializeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		initializeAsync_d__.__4__this = this;
		initializeAsync_d__.__1__state = -1;
		initializeAsync_d__.__t__builder.Start<_InitializeAsync_d__18>(ref initializeAsync_d__);
		return initializeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task InitializeCoreAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InitializeCoreAsync_d__19 initializeCoreAsync_d__ = default(_InitializeCoreAsync_d__19);
		initializeCoreAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		initializeCoreAsync_d__.__4__this = this;
		initializeCoreAsync_d__.__1__state = -1;
		initializeCoreAsync_d__.__t__builder.Start<_InitializeCoreAsync_d__19>(ref initializeCoreAsync_d__);
		return initializeCoreAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_NavigationStarting(CoreWebView2 sender, CoreWebView2NavigationStartingEventArgs args)
	{
		if (!args.Uri.StartsWith("https://mahiro-skin-viewer.invalid/", (StringComparison)5))
		{
			args.Cancel = true;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_NavigationCompleted(CoreWebView2 sender, CoreWebView2NavigationCompletedEventArgs args)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		if (!args.IsSuccess)
		{
			_readySource?.TrySetException((global::System.Exception)new InvalidOperationException("离线渲染页面加载失败：" + ((object)args.WebErrorStatus/*cast due to .constrained prefix*/).ToString()));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Core_NewWindowRequested(CoreWebView2 sender, CoreWebView2NewWindowRequestedEventArgs args)
	{
		args.Handled = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Core_PermissionRequested(CoreWebView2 sender, CoreWebView2PermissionRequestedEventArgs args)
	{
		args.State = (CoreWebView2PermissionState)2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Core_DownloadStarting(CoreWebView2 sender, CoreWebView2DownloadStartingEventArgs args)
	{
		args.Cancel = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_ProcessFailed(CoreWebView2 sender, CoreWebView2ProcessFailedEventArgs args)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		InvalidOperationException ex = new InvalidOperationException("三维渲染进程异常：" + ((object)args.ProcessFailedKind/*cast due to .constrained prefix*/).ToString());
		_readySource?.TrySetException((global::System.Exception)(object)ex);
		if (_ready)
		{
			_ready = false;
			ShowFallback(((global::System.Exception)(object)ex).Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_WebMessageReceived(CoreWebView2 sender, CoreWebView2WebMessageReceivedEventArgs args)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			JsonDocument val = JsonDocument.Parse(args.WebMessageAsJson, default(JsonDocumentOptions));
			try
			{
				JsonElement rootElement = val.RootElement;
				JsonElement val2 = default(JsonElement);
				string text = (rootElement.TryGetProperty("type", out val2) ? val2.GetString() : null);
				if (text == "ready")
				{
					_ready = true;
					_readySource?.TrySetResult(true);
				}
				else if (text == "skinLoaded")
				{
					LoadingRing.IsActive = false;
					((UIElement)LoadingRing).Visibility = (Visibility)1;
					((UIElement)FallbackPanel).Visibility = (Visibility)1;
					((UIElement)ViewerPanel).Visibility = (Visibility)0;
				}
				else if (text == "error")
				{
					JsonElement val3 = default(JsonElement);
					string text2 = (rootElement.TryGetProperty("message", out val3) ? val3.GetString() : null);
					ShowFallback("无法渲染三维皮肤：" + (text2 ?? "未知错误"));
				}
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Core_WebMessageReceived", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockSkinViewer.xaml.cs", 199);
			ShowFallback("无法读取三维预览状态：" + ex.Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SendPendingSkinAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SendPendingSkinAsync_d__27 sendPendingSkinAsync_d__ = default(_SendPendingSkinAsync_d__27);
		sendPendingSkinAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		sendPendingSkinAsync_d__.__4__this = this;
		sendPendingSkinAsync_d__.__1__state = -1;
		sendPendingSkinAsync_d__.__t__builder.Start<_SendPendingSkinAsync_d__27>(ref sendPendingSkinAsync_d__);
		return sendPendingSkinAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PostMessage(object message)
	{
		if (!_ready || _disposed || ViewerWebView.CoreWebView2 == null)
		{
			return;
		}
		try
		{
			ViewerWebView.CoreWebView2.PostWebMessageAsJson(JsonSerializer.Serialize<object>(message, (JsonSerializerOptions)null));
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PostMessage", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockSkinViewer.xaml.cs", 243);
			ShowFallback("无法控制三维预览：" + ex.Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowFallback(string message)
	{
		LoadingRing.IsActive = false;
		((UIElement)LoadingRing).Visibility = (Visibility)1;
		FallbackText.Text = message;
		((UIElement)FallbackPanel).Visibility = (Visibility)0;
		((UIElement)ViewerPanel).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool GetAnimationsEnabled()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return new UISettings().AnimationsEnabled;
		}
		catch (global::System.Exception)
		{
			return true;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		if (_disposed)
		{
			return;
		}
		((FrameworkElement)this).Loaded -= new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded -= new RoutedEventHandler(OnUnloaded);
		try
		{
			PostMessage(new global::__f__AnonymousType1_2<string, bool>("pause", true));
			_disposed = true;
			if (ViewerWebView.CoreWebView2 != null)
			{
				CoreWebView2 coreWebView = ViewerWebView.CoreWebView2;
				if (_coreEventsAttached)
				{
					coreWebView.NavigationStarting -= Core_NavigationStarting;
					coreWebView.NavigationCompleted -= Core_NavigationCompleted;
					coreWebView.NewWindowRequested -= Core_NewWindowRequested;
					coreWebView.PermissionRequested -= Core_PermissionRequested;
					coreWebView.DownloadStarting -= Core_DownloadStarting;
					coreWebView.ProcessFailed -= Core_ProcessFailed;
					coreWebView.WebMessageReceived -= Core_WebMessageReceived;
					_coreEventsAttached = false;
				}
			}
			ViewerWebView.Close();
		}
		catch (global::System.Exception)
		{
			_disposed = true;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockSkinViewer.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		switch (connectionId)
		{
		case 2:
			FallbackPanel = CastExtensions.As<Grid>(target);
			break;
		case 3:
			ViewerPanel = CastExtensions.As<Grid>(target);
			break;
		case 4:
			ViewerWebView = CastExtensions.As<WebView2>(target);
			break;
		case 5:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 6:
			FallbackImage = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 7:
			FallbackText = CastExtensions.As<TextBlock>(target);
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
	static BedrockSkinViewer()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		InitializationTimeout = TimeSpan.FromSeconds(8.0);
	}
}

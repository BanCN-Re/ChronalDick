using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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
using NfdorxfpWBqmvmt4ZpvI;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using bUfedyCg1PBqhqIkB8r;
using dFXbSSfp7AGypITCPxjt;
using hMm1lMfph7PJcuUgXHNe;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockFourDimensionalViewer : UserControl, global::System.IDisposable, IComponentConnector
{
	[CompilerGenerated]
	private static class __O
	{
		public static TypedEventHandler<CoreWebView2, CoreWebView2NewWindowRequestedEventArgs> _0___Core_NewWindowRequested;

		public static TypedEventHandler<CoreWebView2, CoreWebView2PermissionRequestedEventArgs> _1___Core_PermissionRequested;

		public static TypedEventHandler<CoreWebView2, CoreWebView2DownloadStartingEventArgs> _2___Core_DownloadStarting;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_3
	{
		public static readonly __c_3 __9;

		public static Func<JsonElement, bool> __9__38_0;

		public static Func<JsonElement, string> __9__38_1;

		public static Func<string, bool> __9__38_2;

		public static Func<string, string> __9__38_3;

		public static Func<JsonElement, bool> __9__38_4;

		public static Func<JsonElement, string> __9__38_5;

		public static Func<string, bool> __9__38_6;

		public static Func<string, string> __9__38_7;

		public static Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>> __9__39_0;

		public static Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>> __9__39_1;

		public static Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>> __9__39_2;

		public static Func<b9eIS3fp4yf1hN7CxE1B, global::__f__AnonymousType7_3<string, string, string>> __9__39_3;

		[MethodImpl((MethodImplOptions)8)]
		static __c_3()
		{
			__9 = (__c_3)new __c_3();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Core_WebMessageReceived_b__38_0(JsonElement value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			return (int)value.ValueKind == 3;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _Core_WebMessageReceived_b__38_1(JsonElement value)
		{
			return value.GetString();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Core_WebMessageReceived_b__38_2(string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _Core_WebMessageReceived_b__38_3(string value)
		{
			return value;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Core_WebMessageReceived_b__38_4(JsonElement value)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			return (int)value.ValueKind == 3;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _Core_WebMessageReceived_b__38_5(JsonElement value)
		{
			return value.GetString();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Core_WebMessageReceived_b__38_6(string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _Core_WebMessageReceived_b__38_7(string value)
		{
			return value;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::__f__AnonymousType6_2<string, string> _SendPendingAppearance_b__39_0(yFupgpfpy3KmMqUSH5b5 file)
		{
			return new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::__f__AnonymousType6_2<string, string> _SendPendingAppearance_b__39_1(yFupgpfpy3KmMqUSH5b5 file)
		{
			return new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::__f__AnonymousType6_2<string, string> _SendPendingAppearance_b__39_2(yFupgpfpy3KmMqUSH5b5 file)
		{
			return new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::__f__AnonymousType7_3<string, string, string> _SendPendingAppearance_b__39_3(b9eIS3fp4yf1hN7CxE1B file)
		{
			return new global::__f__AnonymousType7_3<string, string, string>(file.RelativePath, file.MimeType, file.Base64Data);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _InitializeAsync_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockFourDimensionalViewer __4__this;

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
			BedrockFourDimensionalViewer bedrockFourDimensionalViewer = __4__this;
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
				if (!bedrockFourDimensionalViewer._ready && !bedrockFourDimensionalViewer._disposed)
				{
					if (bedrockFourDimensionalViewer._initializationTask == null)
					{
						bedrockFourDimensionalViewer._initializationTask = bedrockFourDimensionalViewer.InitializeCoreAsync();
					}
					_u__ = bedrockFourDimensionalViewer._initializationTask.GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InitializeAsync_d__30>(ref _u__, ref this);
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
	private struct _InitializeCoreAsync_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockFourDimensionalViewer __4__this;

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
			BedrockFourDimensionalViewer bedrockFourDimensionalViewer = __4__this;
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
						_u__3 = WindowsRuntimeSystemExtensions.GetAwaiter(bedrockFourDimensionalViewer.ViewerWebView.EnsureCoreWebView2Async());
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _InitializeCoreAsync_d__31>(ref _u__3, ref this);
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
						if (_u__2.GetResult() != bedrockFourDimensionalViewer._readySource.Task)
						{
							throw new TimeoutException("4D 离线渲染页面初始化超时");
						}
						_u__ = bedrockFourDimensionalViewer._readySource.Task.GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _InitializeCoreAsync_d__31>(ref _u__, ref this);
							return;
						}
						break;
						IL_0087:
						_u__3.GetResult();
						coreWebView = bedrockFourDimensionalViewer.ViewerWebView.CoreWebView2;
						coreWebView.Settings.AreDefaultContextMenusEnabled = false;
						coreWebView.Settings.AreDevToolsEnabled = false;
						coreWebView.Settings.AreBrowserAcceleratorKeysEnabled = false;
						coreWebView.Settings.IsStatusBarEnabled = false;
						coreWebView.Settings.IsZoomControlEnabled = false;
						coreWebView.Settings.IsWebMessageEnabled = true;
						text = PublishedFileResolver.ResolveDirectory("Assets/Bedrock4DViewer");
						coreWebView.SetVirtualHostNameToFolderMapping("mahiro-4d-viewer.invalid", text, (CoreWebView2HostResourceAccessKind)1);
						if (!bedrockFourDimensionalViewer._eventsAttached)
						{
							coreWebView.NavigationStarting += bedrockFourDimensionalViewer.Core_NavigationStarting;
							coreWebView.NavigationCompleted += bedrockFourDimensionalViewer.Core_NavigationCompleted;
							coreWebView.NewWindowRequested += Core_NewWindowRequested;
							coreWebView.PermissionRequested += Core_PermissionRequested;
							coreWebView.DownloadStarting += Core_DownloadStarting;
							coreWebView.ProcessFailed += bedrockFourDimensionalViewer.Core_ProcessFailed;
							coreWebView.WebMessageReceived += bedrockFourDimensionalViewer.Core_WebMessageReceived;
							bedrockFourDimensionalViewer._eventsAttached = true;
						}
						bedrockFourDimensionalViewer._readySource = new TaskCompletionSource<bool>((TaskCreationOptions)64);
						bedrockFourDimensionalViewer.ViewerWebView.Source = new Uri("https://mahiro-4d-viewer.invalid/" + PublishedFileResolver.ResolveFileName("Assets/Bedrock4DViewer/index.html"));
						_u__2 = global::System.Threading.Tasks.Task.WhenAny((global::System.Threading.Tasks.Task)bedrockFourDimensionalViewer._readySource.Task, global::System.Threading.Tasks.Task.Delay(InitializationTimeout)).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Threading.Tasks.Task>, _InitializeCoreAsync_d__31>(ref _u__2, ref this);
							return;
						}
						goto IL_025f;
					}
					_u__.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "InitializeCoreAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockFourDimensionalViewer.xaml.cs", 176);
					bedrockFourDimensionalViewer._ready = false;
					bedrockFourDimensionalViewer.ShowFallback("4D 预览不可用：" + ex.Message);
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
	private struct _OnLoaded_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockFourDimensionalViewer __4__this;

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
			BedrockFourDimensionalViewer bedrockFourDimensionalViewer = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockFourDimensionalViewer.InitializeAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__28>(ref _u__, ref this);
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
				bedrockFourDimensionalViewer.PostMessage(new global::__f__AnonymousType1_2<string, bool>("pause", false));
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
	private struct _ShowAppearanceAsync_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockFourDimensionalViewer __4__this;

		public wj4U04fpmtYOnJb5AT2Q payload;

		public string fallbackCoverUrl;

		public CancellationToken cancellationToken;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockFourDimensionalViewer bedrockFourDimensionalViewer = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					ObjectDisposedException.ThrowIf(bedrockFourDimensionalViewer._disposed, (object)bedrockFourDimensionalViewer);
					ArgumentNullException.ThrowIfNull((object)payload, "payload");
					bedrockFourDimensionalViewer._pendingPayload = payload;
					Guid val = Guid.NewGuid();
					bedrockFourDimensionalViewer._pendingRequestId = val.ToString("N");
					bedrockFourDimensionalViewer.AnimationNamesChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
					bedrockFourDimensionalViewer.PreviewWarningsChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
					bedrockFourDimensionalViewer.FallbackImage.ImageUrl = fallbackCoverUrl ?? string.Empty;
					((UIElement)bedrockFourDimensionalViewer.FallbackPanel).Visibility = (Visibility)1;
					((UIElement)bedrockFourDimensionalViewer.ViewerPanel).Visibility = (Visibility)0;
					((UIElement)bedrockFourDimensionalViewer.LoadingRing).Visibility = (Visibility)0;
					bedrockFourDimensionalViewer.LoadingRing.IsActive = true;
					_u__ = bedrockFourDimensionalViewer.InitializeAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowAppearanceAsync_d__20>(ref _u__, ref this);
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
				cancellationToken.ThrowIfCancellationRequested();
				if (bedrockFourDimensionalViewer._ready)
				{
					bedrockFourDimensionalViewer.SendPendingAppearance();
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

	private const string ViewerHost = "mahiro-4d-viewer.invalid";

	private static readonly TimeSpan InitializationTimeout;

	private global::System.Threading.Tasks.Task? _initializationTask;

	private TaskCompletionSource<bool>? _readySource;

	private wj4U04fpmtYOnJb5AT2Q? _pendingPayload;

	private string _pendingRequestId;

	private string _sentRequestId;

	private bool _eventsAttached;

	private bool _ready;

	private bool _disposed;

	private bool _autoRotate;

	private bool _animationsEnabled;

	private bool _particlesEnabled;

	[CompilerGenerated]
	private Action<global::System.Collections.Generic.IReadOnlyList<string>>? m_AnimationNamesChanged;

	[CompilerGenerated]
	private Action<global::System.Collections.Generic.IReadOnlyList<string>>? m_PreviewWarningsChanged;

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

	public Action<global::System.Collections.Generic.IReadOnlyList<string>>? AnimationNamesChanged;

	public Action<global::System.Collections.Generic.IReadOnlyList<string>>? PreviewWarningsChanged;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockFourDimensionalViewer()
	{
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		_pendingRequestId = string.Empty;
		_sentRequestId = string.Empty;
		_autoRotate = true;
		_animationsEnabled = true;
		_particlesEnabled = true;
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task ShowAppearanceAsync(wj4U04fpmtYOnJb5AT2Q payload, string? fallbackCoverUrl, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_ShowAppearanceAsync_d__20 showAppearanceAsync_d__ = default(_ShowAppearanceAsync_d__20);
		showAppearanceAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showAppearanceAsync_d__.__4__this = this;
		showAppearanceAsync_d__.payload = payload;
		showAppearanceAsync_d__.fallbackCoverUrl = fallbackCoverUrl;
		showAppearanceAsync_d__.cancellationToken = cancellationToken;
		showAppearanceAsync_d__.__1__state = -1;
		showAppearanceAsync_d__.__t__builder.Start<_ShowAppearanceAsync_d__20>(ref showAppearanceAsync_d__);
		return showAppearanceAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void ClearAppearance()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		_pendingPayload = null;
		Guid val = Guid.NewGuid();
		_pendingRequestId = val.ToString("N");
		this.AnimationNamesChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
		this.PreviewWarningsChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
		PostMessage(new global::__f__AnonymousType0_2<string, string>("clear", _pendingRequestId));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void ShowFallbackAppearance(string? coverUrl, string message)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		ObjectDisposedException.ThrowIf(_disposed, (object)this);
		_pendingPayload = null;
		Guid val = Guid.NewGuid();
		_pendingRequestId = val.ToString("N");
		this.AnimationNamesChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
		this.PreviewWarningsChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)global::System.Array.Empty<string>());
		FallbackImage.ImageUrl = coverUrl ?? string.Empty;
		LoadingRing.IsActive = false;
		((UIElement)LoadingRing).Visibility = (Visibility)1;
		FallbackText.Text = message;
		((UIElement)FallbackPanel).Visibility = (Visibility)0;
		((UIElement)ViewerPanel).Visibility = (Visibility)1;
		PostMessage(new global::__f__AnonymousType0_2<string, string>("clear", _pendingRequestId));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetAutoRotate(bool enabled)
	{
		_autoRotate = enabled;
		PostMessage(new global::__f__AnonymousType1_2<string, bool>("autoRotate", enabled));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetAnimationsEnabled(bool enabled)
	{
		_animationsEnabled = enabled;
		PostMessage(new global::__f__AnonymousType1_2<string, bool>("animations", enabled));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetAnimation(string name)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name, "name");
		PostMessage(new global::__f__AnonymousType2_2<string, string>("animation", name.Trim()));
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetParticlesEnabled(bool enabled)
	{
		_particlesEnabled = enabled;
		PostMessage(new global::__f__AnonymousType1_2<string, bool>("particles", enabled));
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
		_OnLoaded_d__28 onLoaded_d__ = default(_OnLoaded_d__28);
		onLoaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__.__4__this = this;
		onLoaded_d__.__1__state = -1;
		onLoaded_d__.__t__builder.Start<_OnLoaded_d__28>(ref onLoaded_d__);
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
		_InitializeAsync_d__30 initializeAsync_d__ = default(_InitializeAsync_d__30);
		initializeAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		initializeAsync_d__.__4__this = this;
		initializeAsync_d__.__1__state = -1;
		initializeAsync_d__.__t__builder.Start<_InitializeAsync_d__30>(ref initializeAsync_d__);
		return initializeAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task InitializeCoreAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_InitializeCoreAsync_d__31 initializeCoreAsync_d__ = default(_InitializeCoreAsync_d__31);
		initializeCoreAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		initializeCoreAsync_d__.__4__this = this;
		initializeCoreAsync_d__.__1__state = -1;
		initializeCoreAsync_d__.__t__builder.Start<_InitializeCoreAsync_d__31>(ref initializeCoreAsync_d__);
		return initializeCoreAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_NavigationStarting(CoreWebView2 sender, CoreWebView2NavigationStartingEventArgs args)
	{
		if (!args.Uri.StartsWith("https://mahiro-4d-viewer.invalid/", (StringComparison)5))
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
			_readySource?.TrySetException((global::System.Exception)new InvalidOperationException("4D 离线渲染页面加载失败：" + ((object)args.WebErrorStatus/*cast due to .constrained prefix*/).ToString()));
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
		InvalidOperationException ex = new InvalidOperationException("4D 渲染进程异常：" + ((object)args.ProcessFailedKind/*cast due to .constrained prefix*/).ToString());
		_readySource?.TrySetException((global::System.Exception)(object)ex);
		ShowFallback(((global::System.Exception)(object)ex).Message);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Core_WebMessageReceived(CoreWebView2 sender, CoreWebView2WebMessageReceivedEventArgs args)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Invalid comparison between Unknown and I4
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e1: Invalid comparison between Unknown and I4
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
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
					SetAutoRotate(_autoRotate);
					SetAnimationsEnabled(_animationsEnabled);
					SetParticlesEnabled(_particlesEnabled);
					SendPendingAppearance();
				}
				else if (text == "appearanceLoaded")
				{
					JsonElement val3 = default(JsonElement);
					if (string.Equals(rootElement.TryGetProperty("requestId", out val3) ? val3.GetString() : null, _pendingRequestId, (StringComparison)4))
					{
						JsonElement val4 = default(JsonElement);
						string[] array = ((rootElement.TryGetProperty("animationNames", out val4) && (int)val4.ValueKind == 2) ? Enumerable.ToArray<string>(Enumerable.Distinct<string>(Enumerable.Select<string, string>(Enumerable.Where<string>(Enumerable.Select<JsonElement, string>(Enumerable.Where<JsonElement>((global::System.Collections.Generic.IEnumerable<JsonElement>)(object)val4.EnumerateArray(), (Func<JsonElement, bool>)([MethodImpl((MethodImplOptions)8)] (JsonElement value) => (int)value.ValueKind == 3)), (Func<JsonElement, string>)([MethodImpl((MethodImplOptions)8)] (JsonElement value) => value.GetString())), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string value) => !string.IsNullOrWhiteSpace(value))), (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string value) => value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal)) : global::System.Array.Empty<string>());
						JsonElement val5 = default(JsonElement);
						string[] array2 = ((rootElement.TryGetProperty("warnings", out val5) && (int)val5.ValueKind == 2) ? Enumerable.ToArray<string>(Enumerable.Distinct<string>(Enumerable.Select<string, string>(Enumerable.Where<string>(Enumerable.Select<JsonElement, string>(Enumerable.Where<JsonElement>((global::System.Collections.Generic.IEnumerable<JsonElement>)(object)val5.EnumerateArray(), (Func<JsonElement, bool>)([MethodImpl((MethodImplOptions)8)] (JsonElement value) => (int)value.ValueKind == 3)), (Func<JsonElement, string>)([MethodImpl((MethodImplOptions)8)] (JsonElement value) => value.GetString())), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string value) => !string.IsNullOrWhiteSpace(value))), (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string value) => value)), (IEqualityComparer<string>)(object)StringComparer.Ordinal)) : global::System.Array.Empty<string>());
						this.AnimationNamesChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)array);
						this.PreviewWarningsChanged?.Invoke((global::System.Collections.Generic.IReadOnlyList<string>)array2);
						LoadingRing.IsActive = false;
						((UIElement)LoadingRing).Visibility = (Visibility)1;
						((UIElement)FallbackPanel).Visibility = (Visibility)1;
						((UIElement)ViewerPanel).Visibility = (Visibility)0;
					}
				}
				else if (text == "error")
				{
					JsonElement val6 = default(JsonElement);
					string text2 = (rootElement.TryGetProperty("requestId", out val6) ? val6.GetString() : null);
					if (string.IsNullOrEmpty(text2) || string.Equals(text2, _pendingRequestId, (StringComparison)4))
					{
						JsonElement val7 = default(JsonElement);
						string text3 = (rootElement.TryGetProperty("message", out val7) ? val7.GetString() : null);
						ShowFallback("无法渲染 4D 装扮：" + (text3 ?? "未知错误"));
					}
				}
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "Core_WebMessageReceived", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockFourDimensionalViewer.xaml.cs", 291);
			ShowFallback("无法读取 4D 预览状态：" + ex.Message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SendPendingAppearance()
	{
		if (_ready && _pendingPayload != null && !string.Equals(_sentRequestId, _pendingRequestId, (StringComparison)4))
		{
			wj4U04fpmtYOnJb5AT2Q pendingPayload = _pendingPayload;
			_sentRequestId = _pendingRequestId;
			PostMessage(new global::__f__AnonymousType4_3<string, string, global::__f__AnonymousType5_6<string, string, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType7_3<string, string, string>>>>("appearance", _pendingRequestId, new global::__f__AnonymousType5_6<string, string, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType6_2<string, string>>, global::System.Collections.Generic.IEnumerable<global::__f__AnonymousType7_3<string, string, string>>>(pendingPayload.ItemId, pendingPayload.Name, Enumerable.Select<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>((global::System.Collections.Generic.IEnumerable<yFupgpfpy3KmMqUSH5b5>)pendingPayload.GeometryFiles, (Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>)([MethodImpl((MethodImplOptions)8)] (yFupgpfpy3KmMqUSH5b5 file) => new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content))), Enumerable.Select<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>((global::System.Collections.Generic.IEnumerable<yFupgpfpy3KmMqUSH5b5>)pendingPayload.AnimationFiles, (Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>)([MethodImpl((MethodImplOptions)8)] (yFupgpfpy3KmMqUSH5b5 file) => new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content))), Enumerable.Select<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>((global::System.Collections.Generic.IEnumerable<yFupgpfpy3KmMqUSH5b5>)pendingPayload.ParticleFiles, (Func<yFupgpfpy3KmMqUSH5b5, global::__f__AnonymousType6_2<string, string>>)([MethodImpl((MethodImplOptions)8)] (yFupgpfpy3KmMqUSH5b5 file) => new global::__f__AnonymousType6_2<string, string>(file.RelativePath, file.Content))), Enumerable.Select<b9eIS3fp4yf1hN7CxE1B, global::__f__AnonymousType7_3<string, string, string>>((global::System.Collections.Generic.IEnumerable<b9eIS3fp4yf1hN7CxE1B>)pendingPayload.Textures, (Func<b9eIS3fp4yf1hN7CxE1B, global::__f__AnonymousType7_3<string, string, string>>)([MethodImpl((MethodImplOptions)8)] (b9eIS3fp4yf1hN7CxE1B file) => new global::__f__AnonymousType7_3<string, string, string>(file.RelativePath, file.MimeType, file.Base64Data))))));
		}
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
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "PostMessage", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockFourDimensionalViewer.xaml.cs", 353);
			ShowFallback("无法控制 4D 预览：" + ex.Message);
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
		this.AnimationNamesChanged = null;
		this.PreviewWarningsChanged = null;
		try
		{
			PostMessage(new global::__f__AnonymousType1_2<string, bool>("pause", true));
			_disposed = true;
			if (ViewerWebView.CoreWebView2 != null && _eventsAttached)
			{
				CoreWebView2 coreWebView = ViewerWebView.CoreWebView2;
				coreWebView.NavigationStarting -= Core_NavigationStarting;
				coreWebView.NavigationCompleted -= Core_NavigationCompleted;
				coreWebView.NewWindowRequested -= Core_NewWindowRequested;
				coreWebView.PermissionRequested -= Core_PermissionRequested;
				coreWebView.DownloadStarting -= Core_DownloadStarting;
				coreWebView.ProcessFailed -= Core_ProcessFailed;
				coreWebView.WebMessageReceived -= Core_WebMessageReceived;
				_eventsAttached = false;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockFourDimensionalViewer.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
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
	static BedrockFourDimensionalViewer()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		InitializationTimeout = TimeSpan.FromSeconds(8.0);
	}
}

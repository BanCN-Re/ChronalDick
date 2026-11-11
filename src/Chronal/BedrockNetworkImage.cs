using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using Windows.Storage.Streams;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockNetworkImage : UserControl, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadImage_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockNetworkImage __4__this;

		public string imageUrl;

		private CancellationTokenSource _cancellation_5__2;

		private HttpResponseMessage _response_5__3;

		private InMemoryRandomAccessStream _imageStream_5__4;

		private TaskAwaiter<HttpResponseMessage> __u__1;

		private TaskAwaiter<byte[]> __u__2;

		private DataWriter _writer_5__5;

		private TaskAwaiter<uint> __u__3;

		private TaskAwaiter<bool> __u__4;

		private TaskAwaiter __u__5;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0146: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_021a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0483: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Expected O, but got Unknown
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0336: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_036e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03da: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Expected O, but got Unknown
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_045b: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockNetworkImage bedrockNetworkImage = __4__this;
			try
			{
				if ((uint)num <= 4u)
				{
					goto IL_00c7;
				}
				CancellationTokenSource? loadCancellation = bedrockNetworkImage._loadCancellation;
				if (loadCancellation != null)
				{
					loadCancellation.Cancel();
				}
				CancellationTokenSource? loadCancellation2 = bedrockNetworkImage._loadCancellation;
				if (loadCancellation2 != null)
				{
					loadCancellation2.Dispose();
				}
				bedrockNetworkImage._loadCancellation = null;
				bedrockNetworkImage.CoverImage.Source = null;
				((UIElement)bedrockNetworkImage.CoverImage).Opacity = 0.0;
				((UIElement)bedrockNetworkImage.PlaceholderPanel).Visibility = (Visibility)0;
				Uri val = default(Uri);
				if (Uri.TryCreate(imageUrl, (UriKind)1, out val) && (!(val.Scheme != Uri.UriSchemeHttps) || !(val.Scheme != Uri.UriSchemeHttp)))
				{
					_cancellation_5__2 = new CancellationTokenSource();
					goto IL_00c7;
				}
				goto end_IL_0011;
				IL_00c7:
					val = default;
				try
				{
					if ((uint)num > 4u)
					{
						bedrockNetworkImage._loadCancellation = _cancellation_5__2;
					}
					try
					{
						TaskAwaiter<HttpResponseMessage> _u__ = default;
						if (num != 0)
						{
							if ((uint)(num - 1) <= 3u)
							{
								goto IL_0167;
							}
							_u__ = ImageClient.GetAsync(val, (HttpCompletionOption)1, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, _LoadImage_d__14>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<HttpResponseMessage>);
							num = (__1__state = -1);
						}
						HttpResponseMessage result = _u__.GetResult();
						_response_5__3 = result;
						goto IL_0167;
						IL_0167:
						try
						{
							TaskAwaiter<byte[]> _u__2;
							if (num != 1)
							{
								if ((uint)(num - 2) <= 2u)
								{
									goto IL_0267;
								}
								_response_5__3.EnsureSuccessStatusCode();
								long? contentLength = _response_5__3.Content.Headers.ContentLength;
								if (contentLength.HasValue && contentLength.GetValueOrDefault() > 8388608)
								{
									throw new InvalidDataException("封面图片过大");
								}
								_u__2 = _response_5__3.Content.ReadAsByteArrayAsync(_cancellation_5__2.Token).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<byte[]>, _LoadImage_d__14>(ref _u__2, ref this);
									return;
								}
							}
							else
							{
								_u__2 = __u__2;
								__u__2 = default(TaskAwaiter<byte[]>);
								num = (__1__state = -1);
							}
							byte[] result2 = _u__2.GetResult();
							if (result2.Length == 0 || result2.Length > 8388608)
							{
								throw new InvalidDataException("封面图片数据无效");
							}
							_imageStream_5__4 = new InMemoryRandomAccessStream();
							goto IL_0267;
							IL_0267:
								result2 = default;
							try
							{
								TaskAwaiter _u__3 = default;
								if ((uint)(num - 2) > 1u)
								{
									if (num == 4)
									{
										_u__3 = __u__5;
										__u__5 = default(TaskAwaiter);
										num = (__1__state = -1);
										goto IL_0492;
									}
									_writer_5__5 = new DataWriter((IOutputStream)(object)_imageStream_5__4);
								}
								try
								{
									TaskAwaiter<bool> _u__4 = default;
									TaskAwaiter<uint> _u__5 = default;
									if (num != 2)
									{
										if (num == 3)
										{
											_u__4 = __u__4;
											__u__4 = default(TaskAwaiter<bool>);
											num = (__1__state = -1);
											goto IL_038a;
										}
										_writer_5__5.WriteBytes(result2);
										_u__5 = WindowsRuntimeSystemExtensions.AsTask<uint>((IAsyncOperation<uint>)(object)_writer_5__5.StoreAsync(), _cancellation_5__2.Token).GetAwaiter();
										if (!_u__5.IsCompleted)
										{
											num = (__1__state = 2);
											__u__3 = _u__5;
											__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<uint>, _LoadImage_d__14>(ref _u__5, ref this);
											return;
										}
									}
									else
									{
										_u__5 = __u__3;
										__u__3 = default(TaskAwaiter<uint>);
										num = (__1__state = -1);
									}
									_u__5.GetResult();
									_u__4 = WindowsRuntimeSystemExtensions.AsTask<bool>(_writer_5__5.FlushAsync(), _cancellation_5__2.Token).GetAwaiter();
									if (!_u__4.IsCompleted)
									{
										num = (__1__state = 3);
										__u__4 = _u__4;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _LoadImage_d__14>(ref _u__4, ref this);
										return;
									}
									goto IL_038a;
									IL_038a:
									_u__4.GetResult();
									_writer_5__5.DetachStream();
								}
								finally
								{
									if (num < 0 && _writer_5__5 != null)
									{
										((global::System.IDisposable)_writer_5__5).Dispose();
									}
								}
								_writer_5__5 = null;
								_imageStream_5__4.Seek(0uL);
								BitmapImage val2 = new BitmapImage
								{
									DecodePixelWidth = 720,
									DecodePixelType = (DecodePixelType)1
								};
								if (bedrockNetworkImage._loadCancellation == _cancellation_5__2 && !_cancellation_5__2.IsCancellationRequested)
								{
									bedrockNetworkImage.CoverImage.Source = (ImageSource)(object)val2;
									_u__3 = WindowsRuntimeSystemExtensions.AsTask(((BitmapSource)val2).SetSourceAsync((IRandomAccessStream)(object)_imageStream_5__4), _cancellation_5__2.Token).GetAwaiter();
									if (!_u__3.IsCompleted)
									{
										num = (__1__state = 4);
										__u__5 = _u__3;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadImage_d__14>(ref _u__3, ref this);
										return;
									}
									goto IL_0492;
								}
								goto end_IL_0267;
								IL_0492:
								_u__3.GetResult();
								if (bedrockNetworkImage._loadCancellation == _cancellation_5__2 && !_cancellation_5__2.IsCancellationRequested)
								{
									((UIElement)bedrockNetworkImage.PlaceholderPanel).Visibility = (Visibility)1;
									((UIElement)bedrockNetworkImage.CoverImage).Opacity = 1.0;
								}
								goto IL_0520;
								end_IL_0267:;
							}
							finally
							{
								if (num < 0 && _imageStream_5__4 != null)
								{
									((global::System.IDisposable)_imageStream_5__4).Dispose();
								}
							}
						}
						finally
						{
							if (num < 0 && _response_5__3 != null)
							{
								((global::System.IDisposable)_response_5__3).Dispose();
							}
						}
						goto end_IL_00db;
						IL_0520:
						_response_5__3 = null;
						_imageStream_5__4 = null;
						end_IL_00db:;
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception)
					{
						if (bedrockNetworkImage._loadCancellation == _cancellation_5__2)
						{
							bedrockNetworkImage.CoverImage.Source = null;
							((UIElement)bedrockNetworkImage.CoverImage).Opacity = 0.0;
							((UIElement)bedrockNetworkImage.PlaceholderPanel).Visibility = (Visibility)0;
						}
					}
					finally
					{
						if (num < 0 && bedrockNetworkImage._loadCancellation == _cancellation_5__2)
						{
							bedrockNetworkImage._loadCancellation = null;
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
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception);
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

	private const int MaximumImageBytes = 8388608;

	private static readonly HttpClient ImageClient;

	private CancellationTokenSource? _loadCancellation;

	public static readonly DependencyProperty ImageUrlProperty;

	public static readonly DependencyProperty ImageStretchProperty;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid PlaceholderPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image CoverImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	public string ImageUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (string)((DependencyObject)this).GetValue(ImageUrlProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			((DependencyObject)this).SetValue(ImageUrlProperty, (object)value);
		}
	}

	public Stretch ImageStretch
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (Stretch)((DependencyObject)this).GetValue(ImageStretchProperty);
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			((DependencyObject)this).SetValue(ImageStretchProperty, (object)value);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockNetworkImage()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockNetworkImage_Loaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(BedrockNetworkImage_Unloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnImageUrlChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
	{
		if (sender is BedrockNetworkImage bedrockNetworkImage)
		{
			bedrockNetworkImage.LoadImage(args.NewValue as string);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OnImageStretchChanged(DependencyObject sender, DependencyPropertyChangedEventArgs args)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		if (sender is BedrockNetworkImage bedrockNetworkImage && args.NewValue is Stretch stretch)
		{
			bedrockNetworkImage.CoverImage.Stretch = stretch;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadImage(string? imageUrl)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadImage_d__14 loadImage_d__ = default(_LoadImage_d__14);
		loadImage_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadImage_d__.__4__this = this;
		loadImage_d__.imageUrl = imageUrl;
		loadImage_d__.__1__state = -1;
		loadImage_d__.__t__builder.Start<_LoadImage_d__14>(ref loadImage_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BedrockNetworkImage_Loaded(object sender, RoutedEventArgs e)
	{
		if (CoverImage.Source == null && _loadCancellation == null)
		{
			LoadImage(ImageUrl);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BedrockNetworkImage_Unloaded(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? loadCancellation = _loadCancellation;
		if (loadCancellation != null)
		{
			loadCancellation.Cancel();
		}
		CancellationTokenSource? loadCancellation2 = _loadCancellation;
		if (loadCancellation2 != null)
		{
			loadCancellation2.Dispose();
		}
		_loadCancellation = null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient CreateImageClient()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		HttpClient val = new HttpClient((HttpMessageHandler)new HttpClientHandler
		{
			AutomaticDecompression = (DecompressionMethods)3
		})
		{
			Timeout = TimeSpan.FromSeconds(15.0)
		};
		((HttpHeaders)val.DefaultRequestHeaders).TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/131.0.0.0 Safari/537.36");
		((HttpHeaders)val.DefaultRequestHeaders).TryAddWithoutValidation("Accept", "image/avif,image/webp,image/png,image/jpeg,*/*;q=0.8");
		return val = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CoverImage_ImageOpened(object sender, RoutedEventArgs e)
	{
		((UIElement)PlaceholderPanel).Visibility = (Visibility)1;
		((UIElement)CoverImage).Opacity = 1.0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CoverImage_ImageFailed(object sender, ExceptionRoutedEventArgs e)
	{
		CoverImage.Source = null;
		((UIElement)CoverImage).Opacity = 0.0;
		((UIElement)PlaceholderPanel).Visibility = (Visibility)0;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockNetworkImage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PlaceholderPanel = CastExtensions.As<Grid>(target);
			break;
		case 3:
			CoverImage = CastExtensions.As<Image>(target);
			CoverImage.ImageFailed += new ExceptionRoutedEventHandler(CoverImage_ImageFailed);
			CoverImage.ImageOpened += new RoutedEventHandler(CoverImage_ImageOpened);
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
	static BedrockNetworkImage()
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		ImageClient = CreateImageClient();
		ImageUrlProperty = DependencyProperty.Register("ImageUrl", typeof(global::System.String), typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage), new PropertyMetadata((object)string.Empty, new PropertyChangedCallback(OnImageUrlChanged)));
		ImageStretchProperty = DependencyProperty.Register("ImageStretch", typeof(global::Microsoft.UI.Xaml.Media.Stretch), typeof(global::Mahiro_Account.UI.Controls.Bedrock.BedrockNetworkImage), new PropertyMetadata((object)(Stretch)3, new PropertyChangedCallback(OnImageStretchChanged)));
	}
}

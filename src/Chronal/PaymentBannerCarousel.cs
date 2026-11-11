using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using OQZwpbfRHr9DWudhZEpR;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.System;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PaymentBannerCarousel : UserControl, IComponentConnector
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_13
	{
		public static readonly __c_13 __9;

		public static Func<eBH6YIfRKKYmAtWXaPLA, bool> __9__5_0;

		public static Func<eBH6YIfRKKYmAtWXaPLA, eBH6YIfRKKYmAtWXaPLA> __9__5_1;

		static __c_13()
		{
			__9 = (__c_13)new __c_13();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_13()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _SetBanners_b__5_0(eBH6YIfRKKYmAtWXaPLA item)
		{
			if (item.Enabled)
			{
				return !string.IsNullOrWhiteSpace(item.Title);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal eBH6YIfRKKYmAtWXaPLA _SetBanners_b__5_1(eBH6YIfRKKYmAtWXaPLA item)
		{
			return item.slefRtgPed6();
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BannerActionButton_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				try
				{
					TaskAwaiter<bool> _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_009e;
					}
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null && ((FrameworkElement)val).Tag is string value && TryCreateHttpUri(value, out Uri uri))
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(uri));
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _BannerActionButton_Click_d__12>(ref _u__, ref this);
							return;
						}
						goto IL_009e;
					}
					goto end_IL_000d;
					IL_009e:
					if (!_u__.GetResult())
					{
						AppShell.Warning("无法打开横幅链接");
					}
					end_IL_000d:;
				}
				catch (global::System.Exception exception)
				{
					AppShell.Warning("打开横幅链接失败：" + AppShell.GetExceptionDisplayMessage(exception, "BannerActionButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\PaymentBannerCarousel.xaml.cs", 150));
				}
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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

	private readonly List<eBH6YIfRKKYmAtWXaPLA> _banners;

	private readonly ObservableCollection<PaymentBannerIndicator> _indicators;

	private readonly DispatcherTimer _timer;

	private int _activeIndex;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border BannerSurface;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition BannerImageColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition BannerIndicatorColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border BannerImagePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ScrollViewer BannerIndicatorScroller;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ItemsControl BannerIndicators;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon BannerImageFallback;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image BannerImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BannerTitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BannerDescriptionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button BannerActionButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BannerActionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public PaymentBannerCarousel()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		_banners = new List<eBH6YIfRKKYmAtWXaPLA>();
		_indicators = new ObservableCollection<PaymentBannerIndicator>();
		_timer = new DispatcherTimer
		{
			Interval = TimeSpan.FromSeconds(6.0)
		};
		InitializeComponent();
		BannerIndicators.ItemsSource = _indicators;
		_timer.Tick += [MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object? _, object _) =>
		{
			MoveNext();
		};
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
		((UIElement)this).PointerEntered += (PointerEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, PointerRoutedEventArgs _) =>
		{
			_timer.Stop();
		});
		((UIElement)this).PointerExited += (PointerEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, PointerRoutedEventArgs _) =>
		{
			StartTimer();
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetBanners(global::System.Collections.Generic.IEnumerable<eBH6YIfRKKYmAtWXaPLA>? banners)
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			_banners.Clear();
			_banners.AddRange(Enumerable.Select<eBH6YIfRKKYmAtWXaPLA, eBH6YIfRKKYmAtWXaPLA>(Enumerable.Take<eBH6YIfRKKYmAtWXaPLA>(Enumerable.Where<eBH6YIfRKKYmAtWXaPLA>(banners ?? global::System.Array.Empty<eBH6YIfRKKYmAtWXaPLA>(), (Func<eBH6YIfRKKYmAtWXaPLA, bool>)([MethodImpl((MethodImplOptions)8)] (eBH6YIfRKKYmAtWXaPLA item) => item.Enabled && !string.IsNullOrWhiteSpace(item.Title))), 8), (Func<eBH6YIfRKKYmAtWXaPLA, eBH6YIfRKKYmAtWXaPLA>)([MethodImpl((MethodImplOptions)8)] (eBH6YIfRKKYmAtWXaPLA item) => item.slefRtgPed6())));
			((Collection<PaymentBannerIndicator>)(object)_indicators).Clear();
			for (int num = 0; num < _banners.Count; num++)
			{
				((Collection<PaymentBannerIndicator>)(object)_indicators).Add((PaymentBannerIndicator)new PaymentBannerIndicator(num));
			}
			_activeIndex = 0;
			((UIElement)BannerSurface).Visibility = ((_banners.Count <= 0) ? Visibility.Visible : Visibility.Collapsed);
			BannerIndicatorColumn.Width = ((_banners.Count > 1) ? new GridLength(40.0) : new GridLength(0.0));
			((UIElement)BannerIndicatorScroller).Visibility = ((_banners.Count <= 1) ? Visibility.Visible : Visibility.Collapsed);
			((UIElement)this).Visibility = ((UIElement)BannerSurface).Visibility;
			if (_banners.Count > 0)
			{
				ShowBanner(0);
			}
			StartTimer();
		}
		catch (global::System.Exception exception)
		{
			_timer.Stop();
			((UIElement)this).Visibility = (Visibility)1;
			AppShell.Warning("充值横幅加载失败：" + AppShell.GetExceptionDisplayMessage(exception, "SetBanners", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\PaymentBannerCarousel.xaml.cs", 64));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		StartTimer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		_timer.Stop();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StartTimer()
	{
		_timer.Stop();
		if (((FrameworkElement)this).IsLoaded && _banners.Count > 1)
		{
			_timer.Start();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void MoveNext()
	{
		if (_banners.Count > 1)
		{
			ShowBanner((_activeIndex + 1) % _banners.Count);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowBanner(int index)
	{
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		if (index < 0 || index >= _banners.Count)
		{
			return;
		}
		_activeIndex = index;
		eBH6YIfRKKYmAtWXaPLA val = _banners[index];
		BannerTitleText.Text = val.Title;
		BannerDescriptionText.Text = val.Description;
		((UIElement)BannerDescriptionText).Visibility = (string.IsNullOrWhiteSpace(val.Description) ? Visibility.Visible : Visibility.Collapsed);
		BannerActionText.Text = (string.IsNullOrWhiteSpace(val.ActionText) ? "查看详情" : val.ActionText);
		((FrameworkElement)BannerActionButton).Tag = val.LinkUrl;
		((UIElement)BannerActionButton).Visibility = ((!IsHttpUrl(val.LinkUrl)) ? Visibility.Visible : Visibility.Collapsed);
		BannerImage.Source = null;
		((UIElement)BannerImage).Visibility = (Visibility)1;
		((UIElement)BannerImageFallback).Visibility = (Visibility)0;
		BannerImageColumn.Width = new GridLength(0.0);
		((UIElement)BannerImagePanel).Visibility = (Visibility)1;
		if (TryCreateHttpUri(val.ImageUrl, out Uri uri))
		{
			BannerImageColumn.Width = new GridLength(200.0);
			((UIElement)BannerImagePanel).Visibility = (Visibility)0;
			BannerImage.Source = (ImageSource)new BitmapImage(uri);
			((UIElement)BannerImage).Visibility = (Visibility)0;
		}
		global::System.Collections.Generic.IEnumerator<PaymentBannerIndicator> enumerator = ((Collection<PaymentBannerIndicator>)(object)_indicators).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				PaymentBannerIndicator current = enumerator.Current;
				current.IsActive = current.Index == index;
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		StartTimer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BannerIndicatorButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null && ((FrameworkElement)val).Tag is int index)
		{
			ShowBanner(index);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BannerActionButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BannerActionButton_Click_d__12 bannerActionButton_Click_d__ = default(_BannerActionButton_Click_d__12);
		bannerActionButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bannerActionButton_Click_d__.sender = sender;
		bannerActionButton_Click_d__.__1__state = -1;
		bannerActionButton_Click_d__.__t__builder.Start<_BannerActionButton_Click_d__12>(ref bannerActionButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BannerImage_ImageFailed(object sender, ExceptionRoutedEventArgs e)
	{
		BannerImage.Source = null;
		((UIElement)BannerImage).Visibility = (Visibility)1;
		((UIElement)BannerImageFallback).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsHttpUrl(string? value)
	{
		Uri uri;
		return TryCreateHttpUri(value, out uri);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryCreateHttpUri(string? value, out Uri uri)
	{
		//IL_0043: Expected I8, but got O
		//IL_003e: Expected I8, but got O
		Uri val = default(Uri);
		if (Uri.TryCreate(value, (UriKind)1, out val) && (val.Scheme == Uri.UriSchemeHttp || val.Scheme == Uri.UriSchemeHttps))
		{
			uri = (Uri)val;
			return true;
		}
		uri = (Uri)null;
		return false;
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
			Uri val = new Uri("ms-appx:///UI/Controls/PaymentBannerCarousel.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			BannerSurface = CastExtensions.As<Border>(target);
			break;
		case 3:
			BannerImageColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 4:
			BannerIndicatorColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 5:
			BannerImagePanel = CastExtensions.As<Border>(target);
			break;
		case 6:
			BannerIndicatorScroller = CastExtensions.As<ScrollViewer>(target);
			break;
		case 7:
			BannerIndicators = CastExtensions.As<ItemsControl>(target);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(BannerIndicatorButton_Click);
			break;
		case 10:
			BannerImageFallback = CastExtensions.As<FontIcon>(target);
			break;
		case 11:
			BannerImage = CastExtensions.As<Image>(target);
			BannerImage.ImageFailed += new ExceptionRoutedEventHandler(BannerImage_ImageFailed);
			break;
		case 12:
			BannerTitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			BannerDescriptionText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			BannerActionButton = CastExtensions.As<Button>(target);
			((ButtonBase)BannerActionButton).Click += new RoutedEventHandler(BannerActionButton_Click);
			break;
		case 15:
			BannerActionText = CastExtensions.As<TextBlock>(target);
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
	private void __ctor_b__4_0(object? _, object _2)
	{
		MoveNext();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__4_1(object _, PointerRoutedEventArgs _2)
	{
		_timer.Stop();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__4_2(object _, PointerRoutedEventArgs _2)
	{
		StartTimer();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

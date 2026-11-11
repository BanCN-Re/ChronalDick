using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using VFQxICfth84Lkoc3ch2l;
using WinRT;
using WinRT.ChronalVtableClasses;
using mxcLK5ftbOSeIbYOjPNf;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Shell;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class NavigationUserFooter : UserControl, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ApplyWindowsAccountPictureAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public NavigationUserFooter __4__this;

		private TaskAwaiter<BitmapImage?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			NavigationUserFooter navigationUserFooter = __4__this;
			try
			{
				try
				{
					TaskAwaiter<BitmapImage> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsAccountPicture.GetAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, _ApplyWindowsAccountPictureAsync_d__10>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<BitmapImage>);
						num = (__1__state = -1);
					}
					BitmapImage result = _u__.GetResult();
					if (result != null)
					{
						navigationUserFooter.UserAvatar.ProfilePicture = (ImageSource)(object)result;
					}
				}
				catch (global::System.Exception)
				{
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

	[CompilerGenerated]
	private EventHandler? m_RefreshRequested;

	[CompilerGenerated]
	private EventHandler? m_LogoutRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button UserButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid FooterGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PersonPicture UserAvatar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel DetailPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private FontIcon ChevronIcon;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock UsernameText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border RoleBadgeBorder;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock MetaText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RoleBadgeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	internal EventHandler RefreshRequested;

	internal EventHandler LogoutRequested;

	[MethodImpl((MethodImplOptions)8)]
	public NavigationUserFooter()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		InitializeComponent();
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			AppShell.SummaryRefreshed -= OnSummaryRefreshed;
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void SetCompact(bool compact)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		Visibility visibility = ((compact ? true : false) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)DetailPanel).Visibility = visibility;
		((UIElement)ChevronIcon).Visibility = visibility;
		FooterGrid.ColumnSpacing = ((!compact) ? 10 : 0);
		FooterGrid.ColumnDefinitions[0].Width = (GridLength)(compact ? new GridLength(1.0, (GridUnitType)2) : GridLength.Auto);
		((FrameworkElement)UserAvatar).HorizontalAlignment = (HorizontalAlignment)(compact ? 1 : 0);
		((Control)UserButton).HorizontalContentAlignment = (HorizontalAlignment)3;
		((Control)UserButton).Padding = (compact ? new Thickness(0.0, 8.0, 0.0, 8.0) : new Thickness(10.0, 8.0, 10.0, 8.0));
		((Control)UserButton).CornerRadius = new CornerRadius((double)(compact ? 22 : 4));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Update(dN4xMCftS2WHJlRJeqrU? user)
	{
		if (user == null)
		{
			UserAvatar.Initials = string.Empty;
			UserAvatar.ProfilePicture = null;
			UsernameText.Text = "未登录";
			MetaText.Text = "-";
			ApplyRoleBadge(null);
			ToolTipService.SetToolTip((DependencyObject)(object)UserButton, (object)"未登录");
			return;
		}
		UserAvatar.Initials = (string.IsNullOrWhiteSpace(user.Username) ? string.Empty : user.Username.Substring(0, 1).ToUpperInvariant());
		UsernameText.Text = user.Username;
		MetaText.Text = "¥ " + user.BalanceText;
		ApplyRoleBadge(user.PrimaryRole);
		string text = (string.IsNullOrWhiteSpace(user.PrimaryRoleText) ? MetaText.Text : (user.PrimaryRoleText + " · " + MetaText.Text));
		ToolTipService.SetToolTip((DependencyObject)(object)UserButton, (object)$"{user.Username}\n{text}\n{user.EmailDisplayText}");
		ApplyWindowsAccountPictureAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyRoleBadge(nQWwHEfHzpacwJ7BMYfS? role)
	{
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		if (role == null || string.IsNullOrWhiteSpace(role.DisplayText))
		{
			((UIElement)RoleBadgeBorder).Visibility = (Visibility)1;
			RoleBadgeText.Text = string.Empty;
			return;
		}
		((UIElement)RoleBadgeBorder).Visibility = (Visibility)0;
		RoleBadgeText.Text = role.DisplayText;
		SolidColorBrush val = UiHelpers.TryCreateBrush(role.BadgeColor);
		RoleBadgeText.Foreground = (Brush)(((object)val) ?? ((object)(Brush)Application.Current.Resources[(object)"TextFillColorSecondaryBrush"]));
		SolidColorBrush val2 = UiHelpers.TryCreateBrush(role.BadgeBg);
		RoleBadgeBorder.Background = (Brush)(((object)val2) ?? ((object)(Brush)Application.Current.Resources[(object)"ControlAltFillColorSecondaryBrush"]));
		RoleBadgeBorder.BorderBrush = (Brush)((val2 != null) ? ((object)val2) : ((object)(Brush)Application.Current.Resources[(object)"ControlStrokeColorDefaultBrush"]));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ApplyWindowsAccountPictureAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ApplyWindowsAccountPictureAsync_d__10 applyWindowsAccountPictureAsync_d__ = default(_ApplyWindowsAccountPictureAsync_d__10);
		applyWindowsAccountPictureAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		applyWindowsAccountPictureAsync_d__.__4__this = this;
		applyWindowsAccountPictureAsync_d__.__1__state = -1;
		applyWindowsAccountPictureAsync_d__.__t__builder.Start<_ApplyWindowsAccountPictureAsync_d__10>(ref applyWindowsAccountPictureAsync_d__);
		return applyWindowsAccountPictureAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		Update(summary.User);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		Update(null);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshMenuItem_Click(object sender, RoutedEventArgs e)
	{
		EventHandler? obj = this.RefreshRequested;
		if (obj != null)
		{
			obj.Invoke((object)this, EventArgs.Empty);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AccountMenuItem_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("account"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AboutMenuItem_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("about"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LogoutMenuItem_Click(object sender, RoutedEventArgs e)
	{
		EventHandler? obj = this.LogoutRequested;
		if (obj != null)
		{
			obj.Invoke((object)this, EventArgs.Empty);
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
			Uri val = new Uri("ms-appx:///UI/Shell/NavigationUserFooter.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			UserButton = CastExtensions.As<Button>(target);
			break;
		case 3:
			FooterGrid = CastExtensions.As<Grid>(target);
			break;
		case 4:
			UserAvatar = CastExtensions.As<PersonPicture>(target);
			break;
		case 5:
			DetailPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			ChevronIcon = CastExtensions.As<FontIcon>(target);
			break;
		case 7:
			UsernameText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			RoleBadgeBorder = CastExtensions.As<Border>(target);
			break;
		case 9:
			MetaText = CastExtensions.As<TextBlock>(target);
			break;
		case 10:
			RoleBadgeText = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(RefreshMenuItem_Click);
			break;
		case 12:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(AccountMenuItem_Click);
			break;
		case 13:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(AboutMenuItem_Click);
			break;
		case 14:
			CastExtensions.As<MenuFlyoutItem>(target).Click += new RoutedEventHandler(LogoutMenuItem_Click);
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
	private void __ctor_b__0_0(object _, RoutedEventArgs _2)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		AppShell.SummaryRefreshed -= OnSummaryRefreshed;
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

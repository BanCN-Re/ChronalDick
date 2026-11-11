using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using VFQxICfth84Lkoc3ch2l;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;
using rt6nJFOgpDacgmTF8Ih;

namespace Mahiro_Account.UI.Shell;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class AppWatermark : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock UsernameText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock VersionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public AppWatermark()
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		InitializeComponent();
		VersionText.Text = ResolveVersionText();
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
		Update(AppShell.Api.CurrentUser);
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
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		AppShell.SummaryRefreshed -= OnSummaryRefreshed;
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded -= new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Update(dN4xMCftS2WHJlRJeqrU? user)
	{
		if (user == null || string.IsNullOrWhiteSpace(user.Username))
		{
			UsernameText.Text = string.Empty;
			((UIElement)this).Visibility = (Visibility)1;
		}
		else
		{
			UsernameText.Text = user.Username.Trim();
			((UIElement)this).Visibility = (Visibility)0;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ResolveVersionText()
	{
		try
		{
			string text = PrFs4fOBwUvdAORC617.CfCOdBTIDC();
			return text.StartsWith("v", (StringComparison)5) ? text : ("v" + text);
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("ui", "读取应用版本号失败", ex);
			return "v未知";
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
			Uri val = new Uri("ms-appx:///UI/Shell/AppWatermark.xaml");
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
			UsernameText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			VersionText = CastExtensions.As<TextBlock>(target);
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

using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using Windows.UI.ViewManagement;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ShutdownUploadOverlay : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid OverlayRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border ExitCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar UploadProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public ShutdownUploadOverlay()
	{
		InitializeComponent();
		ApplySystemAnimationPreference();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Begin()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((UIElement)this).Visibility = (Visibility)0;
			((UIElement)UploadProgressBar).Visibility = (Visibility)0;
			((UIElement)OverlayRoot).Opacity = 1.0;
			((UIElement)ExitCard).Scale = Vector3.One;
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.TyQywPUFFh("ui", "显示退出日志上传动画失败", ex);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ExitCard_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		Border exitCard = ExitCard;
		Size newSize = e.NewSize;
		float num = (float)(newSize.Width / 2.0);
		newSize = e.NewSize;
		((UIElement)exitCard).CenterPoint = new Vector3(num, (float)(newSize.Height / 2.0), 0f);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplySystemAnimationPreference()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (!new UISettings().AnimationsEnabled)
			{
				((UIElement)OverlayRoot).OpacityTransition = null;
				((UIElement)ExitCard).ScaleTransition = null;
			}
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.TyQywPUFFh("ui", "读取系统动画设置失败", ex);
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
			Uri val = new Uri("ms-appx:///UI/Controls/ShutdownUploadOverlay.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			OverlayRoot = CastExtensions.As<Grid>(target);
			break;
		case 3:
			ExitCard = CastExtensions.As<Border>(target);
			((FrameworkElement)ExitCard).SizeChanged += new SizeChangedEventHandler(ExitCard_SizeChanged);
			break;
		case 4:
			UploadProgressBar = CastExtensions.As<ProgressBar>(target);
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

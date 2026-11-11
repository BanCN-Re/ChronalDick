using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Controls.Bedrock;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class BedrockInstancesPage : Page, global::System.IDisposable, IComponentConnector
{
	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockInstanceList InstanceBrowser;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockInstancesPage()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		InstanceBrowser.Attach(_clientService);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockInstancesPage_Loaded);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BedrockInstancesPage_Loaded(object sender, RoutedEventArgs e)
	{
		InstanceBrowser.Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockInstancesPage_Loaded);
			InstanceBrowser.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockInstancesPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		if (connectionId == 2)
		{
			InstanceBrowser = CastExtensions.As<BedrockInstanceList>(target);
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
	private static void _cctor()
	{
	}
}

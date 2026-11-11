using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class JavaCompatibilityToolsPage : Page, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenIndependentProxyButton_Click_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.ConfirmAsync("进入独立认证代理？", "该旧流程使用独立认证链，仅用于兼容性排查。默认连接请返回“网络服务器”并建立本机入口。", "继续进入").GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenIndependentProxyButton_Click_d__3>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				if (_u__.GetResult())
				{
					OpenServerCompatibilityEntry(JavaCompatibilityDestination.IndependentProxy);
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

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactIndependentProxyTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideIndependentProxyTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel IndependentProxyActions;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenIndependentProxyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenCompatibilityInstancesButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactManagedClientTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideManagedClientTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenManagedClientButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState CompactResourceTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private VisualState WideResourceTools;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenVersionManagementButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public JavaCompatibilityToolsPage()
	{
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenVersionManagementButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("java_versions"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenManagedClientButton_Click(object sender, RoutedEventArgs e)
	{
		OpenServerCompatibilityEntry(JavaCompatibilityDestination.ManagedClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenIndependentProxyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenIndependentProxyButton_Click_d__3 openIndependentProxyButton_Click_d__ = default(_OpenIndependentProxyButton_Click_d__3);
		openIndependentProxyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openIndependentProxyButton_Click_d__.__1__state = -1;
		openIndependentProxyButton_Click_d__.__t__builder.Start<_OpenIndependentProxyButton_Click_d__3>(ref openIndependentProxyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenCompatibilityInstancesButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("java_compatibility_instances"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void OpenServerCompatibilityEntry(JavaCompatibilityDestination destination)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("java_servers"), (object?)new JavaCompatibilityNavigationRequest(destination));
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
			Uri val = new Uri("ms-appx:///Views/Pages/Java/JavaCompatibilityToolsPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			CompactIndependentProxyTools = CastExtensions.As<VisualState>(target);
			break;
		case 3:
			WideIndependentProxyTools = CastExtensions.As<VisualState>(target);
			break;
		case 4:
			IndependentProxyActions = CastExtensions.As<StackPanel>(target);
			break;
		case 5:
			OpenIndependentProxyButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenIndependentProxyButton).Click += new RoutedEventHandler(OpenIndependentProxyButton_Click);
			break;
		case 6:
			OpenCompatibilityInstancesButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenCompatibilityInstancesButton).Click += new RoutedEventHandler(OpenCompatibilityInstancesButton_Click);
			break;
		case 7:
			CompactManagedClientTools = CastExtensions.As<VisualState>(target);
			break;
		case 8:
			WideManagedClientTools = CastExtensions.As<VisualState>(target);
			break;
		case 9:
			OpenManagedClientButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenManagedClientButton).Click += new RoutedEventHandler(OpenManagedClientButton_Click);
			break;
		case 10:
			CompactResourceTools = CastExtensions.As<VisualState>(target);
			break;
		case 11:
			WideResourceTools = CastExtensions.As<VisualState>(target);
			break;
		case 12:
			OpenVersionManagementButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenVersionManagementButton).Click += new RoutedEventHandler(OpenVersionManagementButton_Click);
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
	private static void _cctor()
	{
	}
}

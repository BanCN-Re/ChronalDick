using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Controls.Bedrock;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using fYjvfFf1p8udxK21D6pd;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockSkinsPage : Page, global::System.IDisposable, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockSkinsPage_Loaded_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockSkinsPage __4__this;

		private string _sessionUserId_5__2;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockSkinsPage bedrockSkinsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d9;
				}
				c7lEmkf1MoB1jUf1XEF1 currentSession = bedrockSkinsPage._clientService.CurrentSession;
				_sessionUserId_5__2 = ((currentSession != null) ? currentSession.UserId : null);
				if (string.IsNullOrWhiteSpace(_sessionUserId_5__2))
				{
					bedrockSkinsPage._loadedSessionUserId = null;
					bedrockSkinsPage.SkinBrowser.Clear();
				}
				else if (!string.Equals(bedrockSkinsPage._loadedSessionUserId, _sessionUserId_5__2, (StringComparison)4))
				{
					_u__ = bedrockSkinsPage.SkinBrowser.LoadInitialAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BedrockSkinsPage_Loaded_d__4>(ref _u__, ref this);
						return;
					}
					goto IL_00d9;
				}
				goto end_IL_0011;
				IL_00d9:
				_u__.GetResult();
				c7lEmkf1MoB1jUf1XEF1 currentSession2 = bedrockSkinsPage._clientService.CurrentSession;
				if (string.Equals((currentSession2 != null) ? currentSession2.UserId : null, _sessionUserId_5__2, (StringComparison)4))
				{
					bedrockSkinsPage._loadedSessionUserId = _sessionUserId_5__2;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_sessionUserId_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_sessionUserId_5__2 = null;
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

	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private string? _loadedSessionUserId;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockSkinBrowser SkinBrowser;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinsPage()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		SkinBrowser.Attach(_clientService);
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockSkinsPage_Loaded);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockSkinsPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockSkinsPage_Loaded_d__4 bedrockSkinsPage_Loaded_d__ = default(_BedrockSkinsPage_Loaded_d__4);
		bedrockSkinsPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockSkinsPage_Loaded_d__.__4__this = this;
		bedrockSkinsPage_Loaded_d__.__1__state = -1;
		bedrockSkinsPage_Loaded_d__.__t__builder.Start<_BedrockSkinsPage_Loaded_d__4>(ref bedrockSkinsPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		_loadedSessionUserId = null;
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			SkinBrowser.Clear();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(SkinBrowser.Clear));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockSkinsPage_Loaded);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			SkinBrowser.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockSkinsPage.xaml");
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
			SkinBrowser = CastExtensions.As<BedrockSkinBrowser>(target);
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

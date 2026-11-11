using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using ROZe5Gf1WgRr9IZ64gbr;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Foundation;
using fZGimHf0suVRPkaXFQcr;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
public sealed class BedrockServerBrowser : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockServerBrowser_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockServerBrowser_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	private static class XamlBindingSetters
	{
		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource(ItemsControl obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.ItemsSource = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(TextBlock obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(BedrockNetworkImage obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.ImageUrl = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class BedrockServerBrowser_obj21_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockServerBrowser_Bindings
	{
		private BedrockServerCardViewModel dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj21;

		private TextBlock obj22;

		private TextBlock obj23;

		private TextBlock obj24;

		private BedrockNetworkImage obj25;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockServerBrowser_obj21_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			switch (connectionId)
			{
			case 21:
				obj21 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			case 23:
				obj23 = CastExtensions.As<TextBlock>(target);
				break;
			case 24:
				obj24 = CastExtensions.As<TextBlock>(target);
				break;
			case 25:
				obj25 = CastExtensions.As<BedrockNetworkImage>(target);
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DataContextChangedHandler(FrameworkElement sender, DataContextChangedEventArgs args)
		{
			if (SetDataRoot(args.NewValue))
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool ProcessBinding(uint phase)
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotImplementedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public int ProcessBindings(ContainerContentChangingEventArgs args)
		{
			int nextPhase = -1;
			ProcessBindings(args.Item, args.ItemIndex, (int)args.Phase, out nextPhase);
			return nextPhase;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ResetTemplate()
		{
			Recycle();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void ProcessBindings(object item, int itemIndex, int phase, out int nextPhase)
		{
			nextPhase = -1;
			removedDataContextHandler = true;
			object target = obj21.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BedrockServerCardViewModel>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<BedrockServerCardViewModel>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockServerCardViewModel obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Name(obj.Name, phase);
				Update_Summary(obj.Summary, phase);
				Update_OnlineText(obj.OnlineText, phase);
				Update_CoverUrl(obj.CoverUrl, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Summary(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_OnlineText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj24, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CoverUrl(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Mahiro_Account_UI_Controls_Bedrock_BedrockNetworkImage_ImageUrl(obj25, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	private class BedrockServerBrowser_obj1_Bindings : IComponentConnector, IBedrockServerBrowser_Bindings
	{
		private BedrockServerBrowser dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj17;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockServerBrowser_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 17)
			{
				obj17 = CastExtensions.As<GridView>(target);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		public IComponentConnector GetBindingConnector(int connectionId, object target)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Initialize()
		{
			if (!initialized)
			{
				Update();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Update()
		{
			Update_(dataRoot, -2147483648);
			initialized = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void StopTracking()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void DisconnectUnloadedObject(int connectionId)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			throw new ArgumentException("No unloadable elements to disconnect.");
		}

		[MethodImpl((MethodImplOptions)8)]
		public bool SetDataRoot(object newDataRoot)
		{
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<BedrockServerBrowser>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Activated(object obj, WindowActivatedEventArgs data)
		{
			Initialize();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Loading(FrameworkElement src, object data)
		{
			Initialize();
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BedrockServerBrowser obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Servers(obj.Servers, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Servers(ObservableCollection<BedrockServerCardViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockServerBrowser __4__this;

		private CancellationTokenSource _cancellation_5__2;

		private TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wjHCLDf1ydVEraHow39U>> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			int num = __1__state;
			BedrockServerBrowser bedrockServerBrowser = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0089;
				}
				if (!bedrockServerBrowser._disposed)
				{
					da18CdX55laNMRKtM3p0? service = bedrockServerBrowser._service;
					if (((service != null) ? service.CurrentSession : null) != null)
					{
						CancellationTokenSource? loadCancellation = bedrockServerBrowser._loadCancellation;
						if (loadCancellation != null)
						{
							loadCancellation.Cancel();
						}
						CancellationTokenSource? loadCancellation2 = bedrockServerBrowser._loadCancellation;
						if (loadCancellation2 != null)
						{
							loadCancellation2.Dispose();
						}
						_cancellation_5__2 = new CancellationTokenSource();
						goto IL_0089;
					}
					bedrockServerBrowser.Clear();
				}
				goto end_IL_0011;
				IL_0089:
				try
				{
					if (num != 0)
					{
						bedrockServerBrowser._loadCancellation = _cancellation_5__2;
						((Control)bedrockServerBrowser.RefreshButton).IsEnabled = false;
						bedrockServerBrowser.StatusText.Text = "正在同步服务器目录";
					}
					try
					{
						TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wjHCLDf1ydVEraHow39U>> _u__;
						if (num != 0)
						{
							_u__ = bedrockServerBrowser._service.YN8X6AqW1jH(0, 50, _cancellation_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wjHCLDf1ydVEraHow39U>>, _LoadAsync_d__23>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<global::System.Collections.Generic.IReadOnlyList<wjHCLDf1ydVEraHow39U>>);
							num = (__1__state = -1);
						}
						global::System.Collections.Generic.IReadOnlyList<wjHCLDf1ydVEraHow39U> result = _u__.GetResult();
						if (!_cancellation_5__2.IsCancellationRequested)
						{
							((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Clear();
							global::System.Collections.Generic.IEnumerator<wjHCLDf1ydVEraHow39U> enumerator = ((global::System.Collections.Generic.IEnumerable<wjHCLDf1ydVEraHow39U>)result).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
								{
									wjHCLDf1ydVEraHow39U current = enumerator.Current;
									((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Add((BedrockServerCardViewModel)new BedrockServerCardViewModel(current));
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator)?.Dispose();
								}
							}
							((UIElement)bedrockServerBrowser.EmptyPanel).Visibility = (((((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
							bedrockServerBrowser.EmptyTitle.Text = ((((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count == 0) ? "暂无可用服务器" : string.Empty);
							bedrockServerBrowser.StatusText.Text = ((((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count == 0) ? "目录暂时为空" : $"已同步 {((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count} 个服务器");
							((Selector)bedrockServerBrowser.ServerGrid).SelectedIndex = ((((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count <= 0) ? (-1) : 0);
							bedrockServerBrowser.ShowSelection(((Selector)bedrockServerBrowser.ServerGrid).SelectedItem as BedrockServerCardViewModel);
						}
					}
					catch (OperationCanceledException)
					{
					}
					catch (global::System.Exception exception)
					{
						bedrockServerBrowser.StatusText.Text = AppShell.GetExceptionDisplayMessage(exception, "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockServerBrowser.xaml.cs", 110);
						((UIElement)bedrockServerBrowser.EmptyPanel).Visibility = (((((Collection<BedrockServerCardViewModel>)(object)bedrockServerBrowser.Servers).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
						bedrockServerBrowser.EmptyTitle.Text = "服务器目录加载失败";
						AppShell.Error(bedrockServerBrowser.StatusText.Text);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockServerBrowser._loadCancellation == _cancellation_5__2)
							{
								bedrockServerBrowser._loadCancellation = null;
							}
							bedrockServerBrowser.UpdateButtons();
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_cancellation_5__2 = null;
				__t__builder.SetException(exception2);
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshButton_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockServerBrowser __4__this;

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
			BedrockServerBrowser bedrockServerBrowser = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockServerBrowser.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__24>(ref _u__, ref this);
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

	private const double WideLayoutThreshold = 1000.0;

	private da18CdX55laNMRKtM3p0? _service;

	private CancellationTokenSource? _loadCancellation;

	private bool _operationRunning;

	private bool _relayRunning;

	private bool _disposed;

	[CompilerGenerated]
	private EventHandler<wjHCLDf1ydVEraHow39U>? m_LaunchRequested;

	[CompilerGenerated]
	private EventHandler<wjHCLDf1ydVEraHow39U>? m_RelayLaunchRequested;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ResponsiveRoot;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition CatalogColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ColumnDefinition DetailColumn;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RowDefinition CompactDetailRow;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border DetailPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailSummary;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RelayLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RelayStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox RelayProtocolCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch RelayLanToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailName;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailOnline;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailPlatform;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private BedrockNetworkImage DetailCover;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView ServerGrid;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockServerBrowser_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<BedrockServerCardViewModel> _Servers_k__BackingField;
	public ObservableCollection<BedrockServerCardViewModel> Servers
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public mpVm6bf0F2Qxo2jn2O2u RelayBindScope
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (RelayLanToggle.IsOn)
			{
				return (mpVm6bf0F2Qxo2jn2O2u)1;
			}
			return (mpVm6bf0F2Qxo2jn2O2u)0;
		}
	}

	public int RelayFrontendProtocol
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			object selectedItem = ((Selector)RelayProtocolCombo).SelectedItem;
			object obj = ((selectedItem is ComboBoxItem) ? selectedItem : null);
			int result = default(int);
			if (!(((obj != null) ? ((FrameworkElement)obj).Tag : null) is string text) || !int.TryParse(text, out result))
			{
				return 844;
			}
			return result;
		}
	}

	public EventHandler<wjHCLDf1ydVEraHow39U>? LaunchRequested;

	public EventHandler<wjHCLDf1ydVEraHow39U>? RelayLaunchRequested;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockServerBrowser()
	{
		_Servers_k__BackingField = new ObservableCollection<BedrockServerCardViewModel>();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Attach(da18CdX55laNMRKtM3p0 service)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		ObjectDisposedException.ThrowIf(_disposed, (object)this);
		_service = service ?? throw new ArgumentNullException("service");
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetOperationRunning(bool running)
	{
		_operationRunning = running;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		CancellationTokenSource? loadCancellation = _loadCancellation;
		if (loadCancellation != null)
		{
			loadCancellation.Cancel();
		}
		((Collection<BedrockServerCardViewModel>)(object)Servers).Clear();
		((Selector)ServerGrid).SelectedItem = null;
		StatusText.Text = "登录后获取服务器目录";
		((UIElement)EmptyPanel).Visibility = (Visibility)0;
		EmptyTitle.Text = "等待服务器目录";
		ShowSelection(null);
		RelayStatusText.Text = "代理未启动";
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task LoadAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__23 loadAsync_d__ = default(_LoadAsync_d__23);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__23>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__24 refreshButton_Click_d__ = default(_RefreshButton_Click_d__24);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__24>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ServerGrid_ItemClick(object sender, ItemClickEventArgs e)
	{
		if (e.ClickedItem is BedrockServerCardViewModel selectedItem)
		{
			((Selector)ServerGrid).SelectedItem = selectedItem;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ServerGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ShowSelection(((Selector)ServerGrid).SelectedItem as BedrockServerCardViewModel);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowSelection(BedrockServerCardViewModel? item)
	{
		DetailCover.ImageUrl = item?.CoverUrl ?? string.Empty;
		DetailName.Text = item?.Name ?? "选择一个服务器";
		DetailSummary.Text = item?.Summary ?? "从左侧目录选择服务器，查看信息并直接启动。";
		DetailPlatform.Text = item?.PlatformText ?? "基岩移动端";
		DetailOnline.Text = item?.OnlineText ?? string.Empty;
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LaunchButton_Click(object sender, RoutedEventArgs e)
	{
		if (((Selector)ServerGrid).SelectedItem is BedrockServerCardViewModel bedrockServerCardViewModel)
		{
			this.LaunchRequested?.Invoke((object)this, bedrockServerCardViewModel.Server);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RelayLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		if (((Selector)ServerGrid).SelectedItem is BedrockServerCardViewModel bedrockServerCardViewModel)
		{
			this.RelayLaunchRequested?.Invoke((object)this, bedrockServerCardViewModel.Server);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetRelayRunning(bool running)
	{
		_relayRunning = running;
		if (running)
		{
			RelayStatusText.Text = "正在启动代理";
		}
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void SetRelayStatus(string status)
	{
		RelayStatusText.Text = (string.IsNullOrWhiteSpace(status) ? "代理未启动" : status);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResponsiveRoot_SizeChanged(object sender, SizeChangedEventArgs e)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		Size newSize = e.NewSize;
		bool flag = newSize.Width >= 1000.0;
		DetailColumn.Width = (flag ? new GridLength(360.0) : new GridLength(0.0));
		CompactDetailRow.Height = (GridLength)(flag ? new GridLength(0.0) : GridLength.Auto);
		Grid.SetRow((FrameworkElement)(object)DetailPanel, (!flag) ? 2 : 0);
		Grid.SetRowSpan((FrameworkElement)(object)DetailPanel, (!flag) ? 1 : 2);
		Grid.SetColumn((FrameworkElement)(object)DetailPanel, flag ? 1 : 0);
		((FrameworkElement)DetailPanel).Margin = (flag ? new Thickness(0.0) : new Thickness(0.0, 16.0, 0.0, 0.0));
		((FrameworkElement)DetailPanel).MinHeight = ((!flag) ? 360 : 0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		da18CdX55laNMRKtM3p0? service = _service;
		bool flag = ((service != null) ? service.CurrentSession : null) != null;
		((Control)RefreshButton).IsEnabled = flag && !_operationRunning && _loadCancellation == null;
		((Control)LaunchButton).IsEnabled = flag && !_operationRunning && ((Selector)ServerGrid).SelectedItem is BedrockServerCardViewModel bedrockServerCardViewModel && bedrockServerCardViewModel.Server.SupportsBedrock;
		((Control)RelayLaunchButton).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
		((Control)RelayProtocolCombo).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
		((Control)RelayLanToggle).IsEnabled = ((Control)LaunchButton).IsEnabled && !_relayRunning;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		if (!_disposed)
		{
			_disposed = true;
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
			_service = null;
			this.LaunchRequested = null;
			this.RelayLaunchRequested = null;
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockServerBrowser.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResponsiveRoot = CastExtensions.As<Grid>(target);
			((FrameworkElement)ResponsiveRoot).SizeChanged += new SizeChangedEventHandler(ResponsiveRoot_SizeChanged);
			break;
		case 3:
			CatalogColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 4:
			DetailColumn = CastExtensions.As<ColumnDefinition>(target);
			break;
		case 5:
			CompactDetailRow = CastExtensions.As<RowDefinition>(target);
			break;
		case 6:
			DetailPanel = CastExtensions.As<Border>(target);
			break;
		case 7:
			DetailSummary = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			LaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)LaunchButton).Click += new RoutedEventHandler(LaunchButton_Click);
			break;
		case 9:
			RelayLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)RelayLaunchButton).Click += new RoutedEventHandler(RelayLaunchButton_Click);
			break;
		case 10:
			RelayStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			RelayProtocolCombo = CastExtensions.As<ComboBox>(target);
			break;
		case 12:
			RelayLanToggle = CastExtensions.As<ToggleSwitch>(target);
			break;
		case 13:
			DetailName = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			DetailOnline = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			DetailPlatform = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			DetailCover = CastExtensions.As<BedrockNetworkImage>(target);
			break;
		case 17:
			ServerGrid = CastExtensions.As<GridView>(target);
			((ListViewBase)ServerGrid).ItemClick += new ItemClickEventHandler(ServerGrid_ItemClick);
			((Selector)ServerGrid).SelectionChanged += new SelectionChangedEventHandler(ServerGrid_SelectionChanged);
			break;
		case 18:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 19:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 27:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 1:
		{
			UserControl val2 = (UserControl)target;
			BedrockServerBrowser_obj1_Bindings bedrockServerBrowser_obj1_Bindings = (BedrockServerBrowser_obj1_Bindings)new BedrockServerBrowser_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockServerBrowser_obj1_Bindings;
			bedrockServerBrowser_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockServerBrowser_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockServerBrowser_obj1_Bindings.Loading;
			break;
		}
		case 21:
		{
			Grid val = (Grid)target;
			BedrockServerBrowser_obj21_Bindings bedrockServerBrowser_obj21_Bindings = (BedrockServerBrowser_obj21_Bindings)new BedrockServerBrowser_obj21_Bindings();
			result = (IComponentConnector)(object)bedrockServerBrowser_obj21_Bindings;
			bedrockServerBrowser_obj21_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockServerBrowser_obj21_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockServerBrowser_obj21_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockServerBrowser_obj21_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

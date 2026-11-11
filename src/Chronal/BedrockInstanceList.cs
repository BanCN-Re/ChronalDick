using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using ROZe5Gf1WgRr9IZ64gbr;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using i6TlJMfuChv2AjPXr7O8;
using nyJeB7f0q9CPYw2lLbou;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockSkinBrowserWinRTTypeDetails))]
public sealed class BedrockInstanceList : UserControl, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockInstanceList_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockInstanceList_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	private class BedrockInstanceList_obj1_Bindings : IComponentConnector, IBedrockInstanceList_Bindings
	{
		private BedrockInstanceList dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private GridView obj2;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockInstanceList_obj1_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			if (connectionId == 2)
			{
				obj2 = CastExtensions.As<GridView>(target);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
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
				dataRoot = CastExtensions.As<BedrockInstanceList>(newDataRoot);
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
		private void Update_(BedrockInstanceList obj, int phase)
		{
			if ((UserControl)(object)obj != (UserControl)null && (phase & -2147483647) != 0)
			{
				Update_Instances(obj.Instances, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Instances(ObservableCollection<BedrockInstanceCardViewModel> obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj2, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CloseButton_Click_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockInstanceList __4__this;

		public object sender;

		private MFIPycf02g29tSkCEJDk _relay_5__2;

		private zG6ueUfuQUk6CEmxLYji _instance_5__3;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Unknown result type (might be due to invalid IL or missing references)
			//IL_033f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0344: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_027a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockInstanceList bedrockInstanceList = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				TaskAwaiter _u__2 = default;
				switch (num)
				{
				default:
					if (bedrockInstanceList._service != null)
					{
						object obj = sender;
						Button val = (Button)((obj is Button) ? obj : null);
						if (val != null && ((ButtonBase)val).CommandParameter is BedrockInstanceCardViewModel bedrockInstanceCardViewModel)
						{
							_relay_5__2 = bedrockInstanceCardViewModel.Relay;
							if (_relay_5__2 != null)
							{
								_u__ = AppShell.ConfirmAsync("停止代理服务", $"确定停止监听 {_relay_5__2.ListenAddress}:{_relay_5__2.LocalPort} 的代理服务？", "停止代理").GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CloseButton_Click_d__11>(ref _u__, ref this);
									return;
								}
								goto IL_012e;
							}
							_instance_5__3 = bedrockInstanceCardViewModel.Instance;
							if (_instance_5__3 != null)
							{
								_u__ = AppShell.ConfirmAsync("关闭基岩实例", $"确定关闭 {GetInstanceName(_instance_5__3)}（PID {_instance_5__3.ProcessId}）？未保存的游戏内容可能丢失。", "关闭实例").GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 2);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CloseButton_Click_d__11>(ref _u__, ref this);
									return;
								}
								goto IL_02ce;
							}
						}
					}
					goto end_IL_0011;
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_012e;
				case 1:
					try
					{
						if (num != 1)
						{
							_u__2 = bedrockInstanceList._service.Relay.vhEf0dJlG2d(_relay_5__2.Id, default(CancellationToken)).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CloseButton_Click_d__11>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
						}
						_u__2.GetResult();
						AppShell.Success("代理服务已停止");
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "CloseButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockInstanceList.xaml.cs", 118));
					}
					goto end_IL_0011;
				case 2:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_02ce;
				case 3:
					break;
					IL_02ce:
					if (_u__.GetResult())
					{
						break;
					}
					goto end_IL_0011;
					IL_012e:
					if (_u__.GetResult())
					{
						goto case 1;
					}
					goto end_IL_0011;
				}
				try
				{
					if (num != 3)
					{
						_u__2 = bedrockInstanceList._service.kugX67mqkMv(_instance_5__3.ProcessId, default(CancellationToken)).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 3);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CloseButton_Click_d__11>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
					}
					_u__2.GetResult();
					AppShell.Success("基岩实例已关闭");
				}
				catch (global::System.Exception exception2)
				{
					AppShell.Error(AppShell.GetExceptionDisplayMessage(exception2, "CloseButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockInstanceList.xaml.cs", 141));
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception3)
			{
				__1__state = -2;
				_relay_5__2 = null;
				_instance_5__3 = null;
				__t__builder.SetException(exception3);
				return;
			}
			__1__state = -2;
			_relay_5__2 = null;
			_instance_5__3 = null;
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

	private da18CdX55laNMRKtM3p0? _service;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private GridView InstanceGridView;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RunningCountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockInstanceList_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<BedrockInstanceCardViewModel> _Instances_k__BackingField;

	public ObservableCollection<BedrockInstanceCardViewModel> Instances
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockInstanceList()
	{
		_Instances_k__BackingField = new ObservableCollection<BedrockInstanceCardViewModel>();
		InitializeComponent();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Attach(da18CdX55laNMRKtM3p0 service)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		if (_service != null)
		{
			_service.InstancesChanged -= new EventHandler(Service_InstancesChanged);
			_service.Relay.InstancesChanged -= new EventHandler(Service_InstancesChanged);
		}
		_service = service ?? throw new ArgumentNullException("service");
		_service.InstancesChanged += new EventHandler(Service_InstancesChanged);
		_service.Relay.InstancesChanged += new EventHandler(Service_InstancesChanged);
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Refresh()
	{
		if (_service == null || _disposed)
		{
			return;
		}
		((Collection<BedrockInstanceCardViewModel>)(object)Instances).Clear();
		global::System.Collections.Generic.IEnumerator<zG6ueUfuQUk6CEmxLYji> enumerator = ((global::System.Collections.Generic.IEnumerable<zG6ueUfuQUk6CEmxLYji>)_service.fqaX64xovpi()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				zG6ueUfuQUk6CEmxLYji current = enumerator.Current;
				((Collection<BedrockInstanceCardViewModel>)(object)Instances).Add((BedrockInstanceCardViewModel)new BedrockInstanceCardViewModel(current));
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		global::System.Collections.Generic.IEnumerator<MFIPycf02g29tSkCEJDk> enumerator2 = ((global::System.Collections.Generic.IEnumerable<MFIPycf02g29tSkCEJDk>)_service.Relay.YXcf0BgP5Jv()).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				MFIPycf02g29tSkCEJDk current2 = enumerator2.Current;
				((Collection<BedrockInstanceCardViewModel>)(object)Instances).Add((BedrockInstanceCardViewModel)new BedrockInstanceCardViewModel(current2));
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator2)?.Dispose();
		}
		((UIElement)EmptyPanel).Visibility = (((((Collection<BedrockInstanceCardViewModel>)(object)Instances).Count != 0)) ? Visibility.Visible : Visibility.Collapsed);
		StatusText.Text = ((((Collection<BedrockInstanceCardViewModel>)(object)Instances).Count == 0) ? "自动跟踪客户端进程与国际版代理服务" : $"{((Collection<BedrockInstanceCardViewModel>)(object)Instances).Count} 个客户端或代理正在运行，状态由系统实时同步");
		RunningCountText.Text = $"{((Collection<BedrockInstanceCardViewModel>)(object)Instances).Count} 个在线";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Service_InstancesChanged(object? sender, EventArgs e)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		if (((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			Refresh();
		}
		else
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue((DispatcherQueuePriority)0, new DispatcherQueueHandler(Refresh));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		Refresh();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenFolderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null || !(((ButtonBase)val).CommandParameter is BedrockInstanceCardViewModel bedrockInstanceCardViewModel) || string.IsNullOrWhiteSpace(bedrockInstanceCardViewModel.OpenPath))
		{
			return;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = bedrockInstanceCardViewModel.OpenPath,
				UseShellExecute = true
			});
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "OpenFolderButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockInstanceList.xaml.cs", 90));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CloseButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CloseButton_Click_d__11 closeButton_Click_d__ = default(_CloseButton_Click_d__11);
		closeButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		closeButton_Click_d__.__4__this = this;
		closeButton_Click_d__.sender = sender;
		closeButton_Click_d__.__1__state = -1;
		closeButton_Click_d__.__t__builder.Start<_CloseButton_Click_d__11>(ref closeButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetInstanceName(zG6ueUfuQUk6CEmxLYji instance)
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Invalid comparison between Unknown and I4
		wjHCLDf1ydVEraHow39U server = instance.Server;
		object obj = ((server != null) ? server.Name : null);
		if (obj == null)
		{
			if ((int)instance.Kind != 3)
			{
				return "本地客户端";
			}
			obj = "外部 Minecraft 客户端";
		}
		return (string)obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			if (_service != null)
			{
				_service.InstancesChanged -= new EventHandler(Service_InstancesChanged);
				_service.Relay.InstancesChanged -= new EventHandler(Service_InstancesChanged);
			}
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
			Uri val = new Uri("ms-appx:///UI/Controls/Bedrock/BedrockInstanceList.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			InstanceGridView = CastExtensions.As<GridView>(target);
			break;
		case 3:
			EmptyPanel = CastExtensions.As<Border>(target);
			break;
		case 5:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenFolderButton_Click);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CloseButton_Click);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 8:
			RunningCountText = CastExtensions.As<TextBlock>(target);
			break;
		case 9:
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
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		IComponentConnector result = null;
		if (connectionId == 1)
		{
			UserControl val = (UserControl)target;
			BedrockInstanceList_obj1_Bindings bedrockInstanceList_obj1_Bindings = (BedrockInstanceList_obj1_Bindings)new BedrockInstanceList_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockInstanceList_obj1_Bindings;
			bedrockInstanceList_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockInstanceList_obj1_Bindings;
			((FrameworkElement)val).Loading += bedrockInstanceList_obj1_Bindings.Loading;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

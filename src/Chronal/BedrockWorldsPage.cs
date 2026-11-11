using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using E3rtuYf3hKgKIPSbYth8;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Vl4jDMX56cFYkU2Jw1oo;
using WinRT;
using WinRT.ChronalVtableClasses;
using knGiRcfu9DhbMgArQGtn;
using qS8vkpL43FlTMgcj0rgs;
using r7Ie1ifM7owYurGstPtD;
using rSrNDuf3mE35XoBDTuIX;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BedrockWorldsPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockWorldsPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockWorldsPage_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool ContainsElement(int connectionId);

		void RegisterForElementConnection(int connectionId, IComponentConnector connector);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private static class XamlBindingSetters
	{
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
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class BedrockWorldsPage_obj3_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockWorldsPage_Bindings
	{
		private wjj6nVf3ogsWdVdSQAAy dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj3;

		private TextBlock obj7;

		private TextBlock obj8;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockWorldsPage_obj3_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 3:
				obj3 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 7:
				obj7 = CastExtensions.As<TextBlock>(target);
				break;
			case 8:
				obj8 = CastExtensions.As<TextBlock>(target);
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
			nextPhase = default;
			removedDataContextHandler = true;
			object target = obj3.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<wjj6nVf3ogsWdVdSQAAy>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<wjj6nVf3ogsWdVdSQAAy>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(wjj6nVf3ogsWdVdSQAAy obj, int phase)
		{
			if (obj != (wjj6nVf3ogsWdVdSQAAy)null && (phase & -2147483647) != 0)
			{
				Update_Name(obj.Name, phase);
				Update_Subtitle(obj.Subtitle, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Subtitle(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BedrockWorldsPage_Loaded_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockWorldsPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			BedrockWorldsPage bedrockWorldsPage = __4__this;
			try
			{
				bedrockWorldsPage.RefreshSelectedClientStatus();
				bedrockWorldsPage.LoadWorlds();
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DeleteWorldButton_Click_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockWorldsPage __4__this;

		private wjj6nVf3ogsWdVdSQAAy _world_5__2;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockWorldsPage bedrockWorldsPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00c9;
				}
				object obj = sender;
				FrameworkElement val = (FrameworkElement)((obj is FrameworkElement) ? obj : null);
				if (val != null)
				{
					object dataContext = val.DataContext;
					_world_5__2 = (wjj6nVf3ogsWdVdSQAAy)((dataContext is wjj6nVf3ogsWdVdSQAAy) ? dataContext : null);
					if (_world_5__2 != null)
					{
						_u__ = AppShell.ConfirmAsync("删除存档", "确定删除世界“" + _world_5__2.Name + "”？存档数据将被永久删除，无法恢复。").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _DeleteWorldButton_Click_d__13>(ref _u__, ref this);
							return;
						}
						goto IL_00c9;
					}
				}
				goto end_IL_0011;
				IL_00c9:
				if (_u__.GetResult())
				{
					try
					{
						bedrockWorldsPage._clientService.ApUXR9oLaGl(_world_5__2.Id);
						AppShell.Success("已删除世界：" + _world_5__2.Name);
						bedrockWorldsPage.LoadWorlds();
					}
					catch (global::System.Exception exception)
					{
						AppShell.Error("删除世界失败：" + AppShell.GetExceptionDisplayMessage(exception, "DeleteWorldButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockWorldsPage.xaml.cs", 219));
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_world_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_world_5__2 = null;
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
	private struct _LaunchWorldButton_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public BedrockWorldsPage __4__this;

		private wjj6nVf3ogsWdVdSQAAy _world_5__2;

		private CancellationTokenSource _cancellation_5__3;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter<int> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Expected O, but got Unknown
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_019e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockWorldsPage bedrockWorldsPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0088;
				}
				object obj = sender;
				FrameworkElement val = (FrameworkElement)((obj is FrameworkElement) ? obj : null);
				if (val != null)
				{
					object dataContext = val.DataContext;
					_world_5__2 = (wjj6nVf3ogsWdVdSQAAy)((dataContext is wjj6nVf3ogsWdVdSQAAy) ? dataContext : null);
					if (_world_5__2 != null)
					{
						if (bedrockWorldsPage._clientService.CurrentSession == null)
						{
							AppShell.Error("启动失败：未配置游戏身份认证，请先前往账号配置页面完成身份验证");
						}
						else if (bedrockWorldsPage._launchCancellation == null)
						{
							_cancellation_5__3 = new CancellationTokenSource();
							goto IL_0088;
						}
					}
				}
				goto end_IL_0011;
				IL_0088:
				try
				{
					if ((uint)num > 1u)
					{
						bedrockWorldsPage._launchCancellation = _cancellation_5__3;
						bedrockWorldsPage.SetLaunchState(isRunning: true, "正在校验基岩版服务权益", 0.0);
					}
					try
					{
						TaskAwaiter<int> _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<int>);
								num = (__1__state = -1);
								goto IL_01d3;
							}
							_u__2 = BedrockAccessGuard.EnsureAsync(_cancellation_5__3.Token, forceRefresh: true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _LaunchWorldButton_Click_d__12>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (_u__2.GetResult())
						{
							Progress<TNGLHufuZJeliMhnBLZ9> val2 = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)bedrockWorldsPage.UpdateLaunchProgress);
							_u__ = bedrockWorldsPage._clientService.F5KXRkg7ff2(_world_5__2.Id, (IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val2, _cancellation_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _LaunchWorldButton_Click_d__12>(ref _u__, ref this);
								return;
							}
							goto IL_01d3;
						}
						bedrockWorldsPage.SetLaunchState(isRunning: false, "启动已停止：未能通过服务权益校验", 0.0);
						goto end_IL_00b1;
						IL_01d3:
						int result = _u__.GetResult();
						bedrockWorldsPage.SetLaunchState(isRunning: false, $"单人世界已启动（PID {result}）", 100.0);
						AppShell.Success("已启动单人世界：" + _world_5__2.Name);
						end_IL_00b1:;
					}
					catch (OperationCanceledException)
					{
						bedrockWorldsPage.SetLaunchState(isRunning: false, "启动已取消", ((RangeBase)bedrockWorldsPage.LaunchProgressBar).Value);
						AppShell.Warning("启动已取消");
					}
					catch (global::System.Exception exception)
					{
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(exception, "LaunchWorldButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockWorldsPage.xaml.cs", 184);
						bedrockWorldsPage.SetLaunchState(isRunning: false, exceptionDisplayMessage, ((RangeBase)bedrockWorldsPage.LaunchProgressBar).Value);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockWorldsPage._launchCancellation == _cancellation_5__3)
							{
								bedrockWorldsPage._launchCancellation = null;
							}
							((Control)bedrockWorldsPage.CancelLaunchButton).IsEnabled = false;
						}
					}
				}
				finally
				{
					if (num < 0 && _cancellation_5__3 != null)
					{
						((global::System.IDisposable)_cancellation_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_world_5__2 = null;
				_cancellation_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_world_5__2 = null;
			_cancellation_5__3 = null;
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

	private CancellationTokenSource? _launchCancellation;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CreateWorldPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border LaunchOperationPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView WorldListView;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel WorldEmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchPercentText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelLaunchButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock LaunchStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar LaunchProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox CheatCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox RandomTickSpeedBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox PvpCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox ShowCoordsCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox KeepInventoryCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox AlwaysDayCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox DaylightCycleCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox WeatherCycleCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox MobSpawnCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox MobLootCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox MobGriefingCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox NaturalRegenerationCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox FireSpreadsCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox TntExplodesCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox TileDropsCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox EntitiesDropLootCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox CommandBlocksCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox WorldNameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox WorldSeedBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox GameModeBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox DifficultyBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox WorldTypeBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PermissionLevelBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox BonusItemsCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox StartMapCheckBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button ToggleCreateWorldButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SelectedClientDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockWorldsPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockWorldsPage()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(BedrockWorldsPage_Loaded);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BedrockWorldsPage_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BedrockWorldsPage_Loaded_d__4 bedrockWorldsPage_Loaded_d__ = default(_BedrockWorldsPage_Loaded_d__4);
		bedrockWorldsPage_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bedrockWorldsPage_Loaded_d__.__4__this = this;
		bedrockWorldsPage_Loaded_d__.__1__state = -1;
		bedrockWorldsPage_Loaded_d__.__t__builder.Start<_BedrockWorldsPage_Loaded_d__4>(ref bedrockWorldsPage_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshSelectedClientStatus()
	{
		if (_clientService.UsesCustomClient)
		{
			SelectedClientTitle.Text = "当前使用本机已有客户端";
			SelectedClientDescription.Text = (string.IsNullOrWhiteSpace(_clientService.CustomClientPath) ? "当前目录不可用，请前往版本管理重新选择。" : (_clientService.CustomClientPath + "。单人世界不会自动下载或切换版本。"));
			return;
		}
		uY2l6VfMmfM34jZlW4GQ obj = _clientService.yQdX6RCQjO2();
		string text = ((obj != null) ? obj.Version : null) ?? _clientService.fL9X6w1Dv6X();
		SelectedClientTitle.Text = (string.IsNullOrWhiteSpace(text) ? "尚未选择客户端版本" : ("当前客户端版本：" + text));
		SelectedClientDescription.Text = "单人世界只启动版本管理中指定的本地客户端，存档写入当前版本的数据根目录。";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoadWorlds()
	{
		try
		{
			global::System.Collections.Generic.IReadOnlyList<wjj6nVf3ogsWdVdSQAAy> readOnlyList = _clientService.rvXXRjuUbWw();
			((ItemsControl)WorldListView).ItemsSource = readOnlyList;
			((UIElement)WorldEmptyPanel).Visibility = (((((global::System.Collections.Generic.IReadOnlyCollection<wjj6nVf3ogsWdVdSQAAy>)readOnlyList).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error("存档列表读取失败：" + AppShell.GetExceptionDisplayMessage(exception, "LoadWorlds", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockWorldsPage.xaml.cs", 63));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ToggleCreateWorldButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Invalid comparison between Unknown and I4
		bool flag = (int)((UIElement)CreateWorldPanel).Visibility == 0;
		((UIElement)CreateWorldPanel).Visibility = ((flag ? true : false) ? Visibility.Visible : Visibility.Collapsed);
		((ContentControl)ToggleCreateWorldButton).Content = (flag ? "创建新世界" : "收起表单");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelCreateButton_Click(object sender, RoutedEventArgs e)
	{
		((UIElement)CreateWorldPanel).Visibility = (Visibility)1;
		((ContentControl)ToggleCreateWorldButton).Content = "创建新世界";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ConfirmCreateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Unknown result type (might be due to invalid IL or missing references)
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		try
		{
			Y7XDAnf34PXxEUue3XLL val = new Y7XDAnf34PXxEUue3XLL();
			val.GetType().GetProperty("Name").SetValue(val, WorldNameBox.Text);
			val.GetType().GetProperty("GameType").SetValue(val, ReadSelectedTag(GameModeBox));
			val.GetType().GetProperty("Difficulty").SetValue(val, ReadSelectedTag(DifficultyBox));
			val.GetType().GetProperty("WorldType").SetValue(val, ReadSelectedTag(WorldTypeBox));
			val.GetType().GetProperty("PermissionLevel").SetValue(val, ReadSelectedTag(PermissionLevelBox));
			val.GetType().GetProperty("Seed").SetValue(val, WorldSeedBox.Text?.Trim() ?? string.Empty);
			val.GetType().GetProperty("Cheat").SetValue(val, ((ToggleButton)CheatCheckBox).IsChecked == true);
			val.GetType().GetProperty("KeepInventory").SetValue(val, ((ToggleButton)KeepInventoryCheckBox).IsChecked == true);
			val.GetType().GetProperty("ShowCoordinates").SetValue(val, ((ToggleButton)ShowCoordsCheckBox).IsChecked == true);
			val.GetType().GetProperty("Pvp").SetValue(val, ((ToggleButton)PvpCheckBox).IsChecked == true);
			val.GetType().GetProperty("AlwaysDay").SetValue(val, ((ToggleButton)AlwaysDayCheckBox).IsChecked == true);
			val.GetType().GetProperty("DaylightCycle").SetValue(val, ((ToggleButton)DaylightCycleCheckBox).IsChecked == true);
			val.GetType().GetProperty("WeatherCycle").SetValue(val, ((ToggleButton)WeatherCycleCheckBox).IsChecked == true);
			val.GetType().GetProperty("FireSpreads").SetValue(val, ((ToggleButton)FireSpreadsCheckBox).IsChecked == true);
			val.GetType().GetProperty("TntExplodes").SetValue(val, ((ToggleButton)TntExplodesCheckBox).IsChecked == true);
			val.GetType().GetProperty("MobSpawn").SetValue(val, ((ToggleButton)MobSpawnCheckBox).IsChecked == true);
			val.GetType().GetProperty("NaturalRegeneration").SetValue(val, ((ToggleButton)NaturalRegenerationCheckBox).IsChecked == true);
			val.GetType().GetProperty("MobLoot").SetValue(val, ((ToggleButton)MobLootCheckBox).IsChecked == true);
			val.GetType().GetProperty("MobGriefing").SetValue(val, ((ToggleButton)MobGriefingCheckBox).IsChecked == true);
			val.GetType().GetProperty("TileDrops").SetValue(val, ((ToggleButton)TileDropsCheckBox).IsChecked == true);
			val.GetType().GetProperty("EntitiesDropLoot").SetValue(val, ((ToggleButton)EntitiesDropLootCheckBox).IsChecked == true);
			val.GetType().GetProperty("CommandBlocksEnabled").SetValue(val, ((ToggleButton)CommandBlocksCheckBox).IsChecked == true);
			val.GetType().GetProperty("RandomTickSpeed").SetValue(val, UiHelpers.RequireInteger(RandomTickSpeedBox, "随机刻速度"));
			val.GetType().GetProperty("BonusItems").SetValue(val, ((ToggleButton)BonusItemsCheckBox).IsChecked == true);
			val.GetType().GetProperty("StartWithMap").SetValue(val, ((ToggleButton)StartMapCheckBox).IsChecked == true);
			Y7XDAnf34PXxEUue3XLL val2 = val;
			wjj6nVf3ogsWdVdSQAAy val3 = _clientService.LUCXRZWhjZW(val2);
			AppShell.Success("已创建世界：" + val3.Name);
			((UIElement)CreateWorldPanel).Visibility = (Visibility)1;
			((ContentControl)ToggleCreateWorldButton).Content = "创建新世界";
			WorldNameBox.Text = string.Empty;
			WorldSeedBox.Text = string.Empty;
			LoadWorlds();
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error("创建世界失败：" + AppShell.GetExceptionDisplayMessage(exception, "ConfirmCreateButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockWorldsPage.xaml.cs", 122));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int ReadSelectedTag(ComboBox comboBox)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		object selectedItem = ((Selector)comboBox).SelectedItem;
		ComboBoxItem val = (ComboBoxItem)((selectedItem is ComboBoxItem) ? selectedItem : null);
		int result = default(int);
		if (val != null && int.TryParse(((FrameworkElement)val).Tag as string, out result))
		{
			return result;
		}
		throw new InvalidOperationException("表单选项不完整");
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RefreshWorldsButton_Click(object sender, RoutedEventArgs e)
	{
		RefreshSelectedClientStatus();
		LoadWorlds();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LaunchWorldButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LaunchWorldButton_Click_d__12 launchWorldButton_Click_d__ = default(_LaunchWorldButton_Click_d__12);
		launchWorldButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		launchWorldButton_Click_d__.__4__this = this;
		launchWorldButton_Click_d__.sender = sender;
		launchWorldButton_Click_d__.__1__state = -1;
		launchWorldButton_Click_d__.__t__builder.Start<_LaunchWorldButton_Click_d__12>(ref launchWorldButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DeleteWorldButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DeleteWorldButton_Click_d__13 deleteWorldButton_Click_d__ = default(_DeleteWorldButton_Click_d__13);
		deleteWorldButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		deleteWorldButton_Click_d__.__4__this = this;
		deleteWorldButton_Click_d__.sender = sender;
		deleteWorldButton_Click_d__.__1__state = -1;
		deleteWorldButton_Click_d__.__t__builder.Start<_DeleteWorldButton_Click_d__13>(ref deleteWorldButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenWorldFolderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		FrameworkElement val = (FrameworkElement)((sender is FrameworkElement) ? sender : null);
		if (val == null)
		{
			return;
		}
		object dataContext = val.DataContext;
		wjj6nVf3ogsWdVdSQAAy val2 = (wjj6nVf3ogsWdVdSQAAy)((dataContext is wjj6nVf3ogsWdVdSQAAy) ? dataContext : null);
		if (val2 == null || string.IsNullOrWhiteSpace(val2.DirectoryPath))
		{
			return;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = val2.DirectoryPath,
				UseShellExecute = true
			});
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "OpenWorldFolderButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockWorldsPage.xaml.cs", 240));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLaunchButton_Click(object sender, RoutedEventArgs e)
	{
		CancellationTokenSource? launchCancellation = _launchCancellation;
		if (launchCancellation != null)
		{
			launchCancellation.Cancel();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateLaunchProgress(TNGLHufuZJeliMhnBLZ9 progress)
	{
		double percent = Math.Clamp(progress.Percent, 0.0, 100.0);
		SetLaunchState(isRunning: true, progress.Message, percent);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLaunchState(bool isRunning, string status, double percent)
	{
		((UIElement)LaunchOperationPanel).Visibility = (Visibility)0;
		LaunchStageText.Text = GetLaunchStageText(isRunning, percent);
		LaunchStatusText.Text = status;
		((RangeBase)LaunchProgressBar).Value = percent;
		LaunchPercentText.Text = $"{percent:0.#}%";
		((Control)CancelLaunchButton).IsEnabled = isRunning;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetLaunchStageText(bool isRunning, double percent)
	{
		if (!isRunning)
		{
			if (!(percent >= 100.0))
			{
				return "启动已停止";
			}
			return "启动完成";
		}
		if (!(percent < 2.0))
		{
			if (!(percent < 36.0))
			{
				if (!(percent < 50.0))
				{
					if (!(percent < 75.0))
					{
						if (!(percent < 85.0))
						{
							if (!(percent < 88.0))
							{
								if (percent < 100.0)
								{
									return "确认运行状态";
								}
								return "启动完成";
							}
							return "创建游戏进程";
						}
						return "生成启动配置";
					}
					return "准备材质与游戏会话";
				}
				return "同步玩家皮肤";
			}
			return "准备游戏客户端";
		}
		return "校验服务权限";
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		if (!_disposed)
		{
			_disposed = true;
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(BedrockWorldsPage_Loaded);
			CancellationTokenSource? launchCancellation = _launchCancellation;
			if (launchCancellation != null)
			{
				launchCancellation.Cancel();
			}
			CancellationTokenSource? launchCancellation2 = _launchCancellation;
			if (launchCancellation2 != null)
			{
				launchCancellation2.Dispose();
			}
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockWorldsPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03de: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e8: Expected O, but got Unknown
		switch (connectionId)
		{
		case 4:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(LaunchWorldButton_Click);
			break;
		case 5:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenWorldFolderButton_Click);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DeleteWorldButton_Click);
			break;
		case 9:
			CreateWorldPanel = CastExtensions.As<Border>(target);
			break;
		case 10:
			LaunchOperationPanel = CastExtensions.As<Border>(target);
			break;
		case 11:
			WorldListView = CastExtensions.As<ListView>(target);
			break;
		case 12:
			WorldEmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 13:
			LaunchStageText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			LaunchPercentText = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			CancelLaunchButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelLaunchButton).Click += new RoutedEventHandler(CancelLaunchButton_Click);
			break;
		case 16:
			LaunchStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			LaunchProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 18:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ConfirmCreateButton_Click);
			break;
		case 19:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CancelCreateButton_Click);
			break;
		case 20:
			CheatCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 21:
			RandomTickSpeedBox = CastExtensions.As<NumberBox>(target);
			break;
		case 22:
			PvpCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 23:
			ShowCoordsCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 24:
			KeepInventoryCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 25:
			AlwaysDayCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 26:
			DaylightCycleCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 27:
			WeatherCycleCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 28:
			MobSpawnCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 29:
			MobLootCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 30:
			MobGriefingCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 31:
			NaturalRegenerationCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 32:
			FireSpreadsCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 33:
			TntExplodesCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 34:
			TileDropsCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 35:
			EntitiesDropLootCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 36:
			CommandBlocksCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 37:
			WorldNameBox = CastExtensions.As<TextBox>(target);
			break;
		case 38:
			WorldSeedBox = CastExtensions.As<TextBox>(target);
			break;
		case 39:
			GameModeBox = CastExtensions.As<ComboBox>(target);
			break;
		case 40:
			DifficultyBox = CastExtensions.As<ComboBox>(target);
			break;
		case 41:
			WorldTypeBox = CastExtensions.As<ComboBox>(target);
			break;
		case 42:
			PermissionLevelBox = CastExtensions.As<ComboBox>(target);
			break;
		case 43:
			BonusItemsCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 44:
			StartMapCheckBox = CastExtensions.As<CheckBox>(target);
			break;
		case 45:
			ToggleCreateWorldButton = CastExtensions.As<Button>(target);
			((ButtonBase)ToggleCreateWorldButton).Click += new RoutedEventHandler(ToggleCreateWorldButton_Click);
			break;
		case 46:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshWorldsButton_Click);
			break;
		case 47:
			SelectedClientTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 48:
			SelectedClientDescription = CastExtensions.As<TextBlock>(target);
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
		//IL_0013: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 3)
		{
			Border val = (Border)target;
			BedrockWorldsPage_obj3_Bindings bedrockWorldsPage_obj3_Bindings = (BedrockWorldsPage_obj3_Bindings)new BedrockWorldsPage_obj3_Bindings();
			result = (IComponentConnector)(object)bedrockWorldsPage_obj3_Bindings;
			bedrockWorldsPage_obj3_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockWorldsPage_obj3_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockWorldsPage_obj3_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockWorldsPage_obj3_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

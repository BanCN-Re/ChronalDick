using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using PW0ZZVfus06wwb9hw2Vi;
using Vl4jDMX56cFYkU2Jw1oo;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using hLvcBKfad2ZdsJsU8psZ;
using knGiRcfu9DhbMgArQGtn;
using pZg6QPfag7jmC8rKUG4i;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Bedrock;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_Bedrock_BedrockVersionManagementPageWinRTTypeDetails))]
public sealed class BedrockOnlineLobbyPage : Page, global::System.IDisposable, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBedrockOnlineLobbyPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBedrockOnlineLobbyPage_BindingsScopeConnector
	{
		WeakReference Parent { get; set; }

		bool fBdL4SsXPpl(int connectionId);

		void QhhL4cYq04W(int connectionId, IComponentConnector connector);
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
		public static void Set_Microsoft_UI_Xaml_FrameworkElement_Tag(FrameworkElement obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Tag = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip(DependencyObject obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			ToolTipService.SetToolTip(obj, value);
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_Documents_Run_Text(Run obj, string value, string targetNullValue)
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
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BedrockOnlineLobbyPage_obj10_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBedrockOnlineLobbyPage_Bindings
	{
		private en9Zr5faBGr6cyEG7MZ5 dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj10;

		private Button obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private Run obj14;

		private TextBlock obj15;

		private TextBlock obj16;

		private TextBlock obj17;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockOnlineLobbyPage_obj10_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Expected O, but got Unknown
			switch (connectionId)
			{
			case 10:
				obj10 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 11:
				obj11 = CastExtensions.As<Button>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<Run>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<TextBlock>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
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
			object target = obj10.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<en9Zr5faBGr6cyEG7MZ5>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<en9Zr5faBGr6cyEG7MZ5>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(en9Zr5faBGr6cyEG7MZ5 obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_VersionText(obj.VersionText, phase);
				Update_ResourceId(obj.ResourceId, phase);
				Update_PlayerText(obj.PlayerText, phase);
				Update_Name(obj.Name, phase);
				Update_Description(obj.Description, phase);
			}
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_VersionText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ResourceId(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj13, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Documents_Run_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PlayerText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj16, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj16, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockMaterialPackBrowser_BedrockMaterialPackBrowser_obj1_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.Markup.IComponentConnector")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BedrockOnlineLobbyPage_obj1_Bindings : IComponentConnector, IBedrockOnlineLobbyPage_Bindings
	{
		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class BedrockOnlineLobbyPage_obj1_BindingsTracking
		{
			private WeakReference<BedrockOnlineLobbyPage_obj1_Bindings> weakRefToBindingObj;

			private ObservableCollection<en9Zr5faBGr6cyEG7MZ5> cache_Rooms;

			[MethodImpl((MethodImplOptions)8)]
			public BedrockOnlineLobbyPage_obj1_BindingsTracking(BedrockOnlineLobbyPage_obj1_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<BedrockOnlineLobbyPage_obj1_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public BedrockOnlineLobbyPage_obj1_Bindings TryGetBindingObject()
			{
				BedrockOnlineLobbyPage_obj1_Bindings bedrockOnlineLobbyPage_obj1_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out bedrockOnlineLobbyPage_obj1_Bindings);
					if (bedrockOnlineLobbyPage_obj1_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return bedrockOnlineLobbyPage_obj1_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_Rooms(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void PropertyChanged_Rooms(object sender, PropertyChangedEventArgs e)
			{
				BedrockOnlineLobbyPage_obj1_Bindings bedrockOnlineLobbyPage_obj1_Bindings = TryGetBindingObject();
				if (bedrockOnlineLobbyPage_obj1_Bindings == null)
				{
					return;
				}
				string propertyName = e.PropertyName;
				ObservableCollection<en9Zr5faBGr6cyEG7MZ5> val = sender as ObservableCollection<en9Zr5faBGr6cyEG7MZ5>;
				if (string.IsNullOrEmpty(propertyName))
				{
					if (val != null)
					{
						bedrockOnlineLobbyPage_obj1_Bindings.Update_Rooms_Count(((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)val).Count, 1073741824);
					}
				}
				else if (propertyName == "Count" && val != null)
				{
					bedrockOnlineLobbyPage_obj1_Bindings.Update_Rooms_Count(((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)val).Count, 1073741824);
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void CollectionChanged_Rooms(object sender, NotifyCollectionChangedEventArgs e)
			{
				BedrockOnlineLobbyPage_obj1_Bindings bedrockOnlineLobbyPage_obj1_Bindings = TryGetBindingObject();
				if (bedrockOnlineLobbyPage_obj1_Bindings != null && sender is ObservableCollection<en9Zr5faBGr6cyEG7MZ5> val)
				{
					bedrockOnlineLobbyPage_obj1_Bindings.Update_Rooms_Count(((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)val).Count, 1073741824);
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_Rooms(ObservableCollection<en9Zr5faBGr6cyEG7MZ5> obj)
			{
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Expected O, but got Unknown
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Expected O, but got Unknown
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Expected O, but got Unknown
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Expected O, but got Unknown
				if (obj != cache_Rooms)
				{
					if (cache_Rooms != null)
					{
						((INotifyPropertyChanged)cache_Rooms).PropertyChanged -= new PropertyChangedEventHandler(PropertyChanged_Rooms);
						((INotifyCollectionChanged)cache_Rooms).CollectionChanged -= new NotifyCollectionChangedEventHandler(CollectionChanged_Rooms);
						cache_Rooms = null;
					}
					if (obj != null)
					{
						cache_Rooms = obj;
						((INotifyPropertyChanged)obj).PropertyChanged += new PropertyChangedEventHandler(PropertyChanged_Rooms);
						((INotifyCollectionChanged)obj).CollectionChanged += new NotifyCollectionChangedEventHandler(CollectionChanged_Rooms);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private BedrockOnlineLobbyPage dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private ListView obj5;

		private TextBlock obj18;

		private BedrockOnlineLobbyPage_obj1_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public BedrockOnlineLobbyPage_obj1_Bindings()
		{
			bindingsTracking = (BedrockOnlineLobbyPage_obj1_BindingsTracking)new BedrockOnlineLobbyPage_obj1_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 5:
				obj5 = CastExtensions.As<ListView>(target);
				break;
			case 18:
				obj18 = CastExtensions.As<TextBlock>(target);
				break;
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
			bindingsTracking.ReleaseAllListeners();
			initialized = false;
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
			bindingsTracking.ReleaseAllListeners();
			if (newDataRoot != null)
			{
				dataRoot = CastExtensions.As<BedrockOnlineLobbyPage>(newDataRoot);
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
		private void Update_(BedrockOnlineLobbyPage obj, int phase)
		{
			if ((Page)(object)obj != (Page)null && (phase & -1073741823) != 0)
			{
				Update_Rooms(obj.Rooms, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Rooms(ObservableCollection<en9Zr5faBGr6cyEG7MZ5> obj, int phase)
		{
			bindingsTracking.UpdateChildListeners_Rooms(obj);
			if (obj != null && (phase & -1073741823) != 0)
			{
				Update_Rooms_Count(((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)obj).Count, phase);
			}
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ItemsControl_ItemsSource((ItemsControl)(object)obj5, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Rooms_Count(int obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj18, obj.ToString(), null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_1
	{
		public BedrockOnlineLobbyPage __4__this;

		public CancellationTokenSource operation;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _EnterRoomButton_Click_b__0(TNGLHufuZJeliMhnBLZ9 value)
		{
			if (!__4__this._disposed && __4__this._operationCancellation == operation && !operation.IsCancellationRequested)
			{
				__4__this.SetLaunchProgress(active: true, value.Message, value.Percent);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _EnterRoomButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		public object sender;

		private __c__DisplayClass15_0_1 __8__1;

		private en9Zr5faBGr6cyEG7MZ5 _room_5__2;

		private Stopwatch _timer_5__3;

		private TaskAwaiter<bool> __u__1;

		private ConfiguredTaskAwaitable<XHEDPNfuFO31QfaHLUGP>.ConfiguredTaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_019d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_020c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0210: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_017d: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Expected O, but got Unknown
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_00ce;
				}
				__8__1 = (__c__DisplayClass15_0_1)new __c__DisplayClass15_0_1();
				__8__1.__4__this = __4__this;
				if (!bedrockOnlineLobbyPage._disposed && bedrockOnlineLobbyPage._operationCancellation == null)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						_room_5__2 = (en9Zr5faBGr6cyEG7MZ5)((tag is en9Zr5faBGr6cyEG7MZ5) ? tag : null);
						if (_room_5__2 != null)
						{
							if (_room_5__2.HasPassword)
							{
								AppShell.Warning("该房间需要密码；当前进服流程不支持代填密码。");
							}
							else
							{
								if (bedrockOnlineLobbyPage._clientService.CurrentSession != null)
								{
									__8__1.operation = new CancellationTokenSource();
									goto IL_00ce;
								}
								AppShell.Error("请先建立基岩游戏会话。");
							}
						}
					}
				}
				goto end_IL_0011;
				IL_00ce:
				try
				{
					if ((uint)num > 1u)
					{
						bedrockOnlineLobbyPage._operationCancellation = __8__1.operation;
						_timer_5__3 = Stopwatch.StartNew();
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-online-lobby", "stage=join-start room_id=" + _room_5__2.RoomId + " resource_id=" + _room_5__2.ResourceId);
						bedrockOnlineLobbyPage.SetLoadingState(loading: true);
						bedrockOnlineLobbyPage.SetLaunchProgress(active: true, "正在校验进服权限", 0.0);
					}
					try
					{
						ConfiguredTaskAwaitable<XHEDPNfuFO31QfaHLUGP>.ConfiguredTaskAwaiter _u__ = default;
						TaskAwaiter<bool> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(ConfiguredTaskAwaitable<XHEDPNfuFO31QfaHLUGP>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
								goto IL_0264;
							}
							_u__2 = BedrockAccessGuard.EnsureAsync(__8__1.operation.Token, forceRefresh: true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _EnterRoomButton_Click_d__15>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
						}
						if (!_u__2.GetResult())
						{
							throw new InvalidOperationException("服务权限校验未通过，尚未提交房间资源请求。");
						}
						Progress<TNGLHufuZJeliMhnBLZ9> val2 = new Progress<TNGLHufuZJeliMhnBLZ9>((Action<TNGLHufuZJeliMhnBLZ9>)__8__1._EnterRoomButton_Click_b__0);
						_u__ = bedrockOnlineLobbyPage._clientService.XE7XRlvdJWY(_room_5__2, (IProgress<TNGLHufuZJeliMhnBLZ9>)(object)val2, __8__1.operation.Token).ConfigureAwait(true).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<XHEDPNfuFO31QfaHLUGP>.ConfiguredTaskAwaiter, _EnterRoomButton_Click_d__15>(ref _u__, ref this);
							return;
						}
						goto IL_0264;
						IL_0264:
						XHEDPNfuFO31QfaHLUGP result = _u__.GetResult();
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-online-lobby", $"stage=join-completed room_id={_room_5__2.RoomId} pid={result.ProcessId} elapsedMs={_timer_5__3.ElapsedMilliseconds}");
						bedrockOnlineLobbyPage.SetLaunchProgress(active: false, "已启动房间「" + _room_5__2.Name + "」", 100.0);
						AppShell.Success("联机大厅已启动", $"房间：{_room_5__2.Name}（PID {result.ProcessId}）");
					}
					catch (OperationCanceledException)
					{
						gX17swyO7x0JWQxdaD1.IdOy6I4Chb("bedrock-online-lobby", $"stage=join-cancelled elapsedMs={_timer_5__3.ElapsedMilliseconds}");
						bedrockOnlineLobbyPage.SetLaunchProgress(active: false, "进服已取消", ((RangeBase)bedrockOnlineLobbyPage.OperationProgressBar).Value);
						AppShell.Warning("进服已取消");
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-online-lobby", $"stage=join-failed room_id={_room_5__2.RoomId} error={((MemberInfo)ex2.GetType()).Name} elapsedMs={_timer_5__3.ElapsedMilliseconds}", ex2);
						string exceptionDisplayMessage = AppShell.GetExceptionDisplayMessage(ex2, "EnterRoomButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockOnlineLobbyPage.xaml.cs", 212);
						bedrockOnlineLobbyPage.SetLaunchProgress(active: false, exceptionDisplayMessage, ((RangeBase)bedrockOnlineLobbyPage.OperationProgressBar).Value);
						AppShell.Error(exceptionDisplayMessage);
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockOnlineLobbyPage._operationCancellation == __8__1.operation)
							{
								bedrockOnlineLobbyPage._operationCancellation = null;
							}
							if (!bedrockOnlineLobbyPage._disposed)
							{
								bedrockOnlineLobbyPage.SetLoadingState(loading: false);
							}
						}
					}
				}
				finally
				{
					if (num < 0 && __8__1.operation != null)
					{
						((global::System.IDisposable)__8__1.operation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				_room_5__2 = null;
				_timer_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_room_5__2 = null;
			_timer_5__3 = null;
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
	private struct _LoadMoreButton_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockOnlineLobbyPage.LoadRoomsAsync(reset: false).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadMoreButton_Click_d__12>(ref _u__, ref this);
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadRoomsAsync_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		public bool reset;

		private CancellationTokenSource _operation_5__2;

		private int _requestedOffset_5__3;

		private ConfiguredTaskAwaitable<U6F9bpfalxRTQHVPjMJF>.ConfiguredTaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_0176: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0099;
				}
				if (!bedrockOnlineLobbyPage._disposed && bedrockOnlineLobbyPage._operationCancellation == null)
				{
					if (bedrockOnlineLobbyPage._clientService.CurrentSession != null)
					{
						_operation_5__2 = new CancellationTokenSource();
						goto IL_0099;
					}
					((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Clear();
					bedrockOnlineLobbyPage._offset = 0;
					bedrockOnlineLobbyPage._hasMore = false;
					bedrockOnlineLobbyPage.SetEmptyState("请先建立游戏会话", "登录 PE 账号后加载联机大厅房间。", show: true);
					bedrockOnlineLobbyPage.StatusText.Text = "请先建立游戏会话";
					((UIElement)bedrockOnlineLobbyPage.LoadMoreButton).Visibility = (Visibility)1;
				}
				goto end_IL_0011;
				IL_0099:
				try
				{
					string text = default(string);
					if (num != 0)
					{
						bedrockOnlineLobbyPage._operationCancellation = _operation_5__2;
						text = bedrockOnlineLobbyPage.SearchBox.Text?.Trim() ?? string.Empty;
						_requestedOffset_5__3 = ((!reset) ? bedrockOnlineLobbyPage._offset : 0);
						bedrockOnlineLobbyPage.SetLoadingState(loading: true);
						if (reset)
						{
							bedrockOnlineLobbyPage.StatusText.Text = "正在读取 PE 联机大厅";
						}
						else
						{
							bedrockOnlineLobbyPage.StatusText.Text = "正在加载更多房间";
						}
					}
					try
					{
						ConfiguredTaskAwaitable<U6F9bpfalxRTQHVPjMJF>.ConfiguredTaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = bedrockOnlineLobbyPage._clientService.iA3XRgBMWZp(text, _requestedOffset_5__3, _operation_5__2.Token).ConfigureAwait(true).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<U6F9bpfalxRTQHVPjMJF>.ConfiguredTaskAwaiter, _LoadRoomsAsync_d__14>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(ConfiguredTaskAwaitable<U6F9bpfalxRTQHVPjMJF>.ConfiguredTaskAwaiter);
							num = (__1__state = -1);
						}
						U6F9bpfalxRTQHVPjMJF result = _u__.GetResult();
						if (!bedrockOnlineLobbyPage._disposed && !_operation_5__2.IsCancellationRequested && bedrockOnlineLobbyPage._operationCancellation == _operation_5__2)
						{
							if (reset)
							{
								((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Clear();
							}
							global::System.Collections.Generic.IEnumerator<en9Zr5faBGr6cyEG7MZ5> enumerator = ((global::System.Collections.Generic.IEnumerable<en9Zr5faBGr6cyEG7MZ5>)result.Rooms).GetEnumerator();
							try
							{
								while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
								{
									en9Zr5faBGr6cyEG7MZ5 current = enumerator.Current;
									((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Add(current);
								}
							}
							finally
							{
								if (num < 0)
								{
									((global::System.IDisposable)enumerator)?.Dispose();
								}
							}
							bedrockOnlineLobbyPage._offset = result.NextOffset;
							bedrockOnlineLobbyPage._hasMore = result.HasMore;
							bedrockOnlineLobbyPage.StatusText.Text = ((((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Count == 0) ? "没有找到符合条件的 PE 大厅房间" : $"显示 {((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Count} 个房间，共 {result.Total} 个");
							bedrockOnlineLobbyPage.SetEmptyState("没有找到房间", "换一个名称或刷新大厅列表。", ((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Count == 0);
							((UIElement)bedrockOnlineLobbyPage.LoadMoreButton).Visibility = ((!bedrockOnlineLobbyPage._hasMore) ? Visibility.Visible : Visibility.Collapsed);
						}
					}
					catch (OperationCanceledException)
					{
						if (!bedrockOnlineLobbyPage._disposed)
						{
							bedrockOnlineLobbyPage.StatusText.Text = "读取已取消";
						}
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("bedrock-online-lobby", $"stage=room-search offset={_requestedOffset_5__3} error={((MemberInfo)ex2.GetType()).Name}", ex2);
						if (!bedrockOnlineLobbyPage._disposed)
						{
							bedrockOnlineLobbyPage.StatusText.Text = AppShell.GetExceptionDisplayMessage(ex2, "LoadRoomsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\Bedrock\\BedrockOnlineLobbyPage.xaml.cs", 134);
							bedrockOnlineLobbyPage.SetEmptyState("大厅读取失败", bedrockOnlineLobbyPage.StatusText.Text, ((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Count == 0);
						}
					}
					finally
					{
						if (num < 0)
						{
							if (bedrockOnlineLobbyPage._operationCancellation == _operation_5__2)
							{
								bedrockOnlineLobbyPage._operationCancellation = null;
							}
							if (!bedrockOnlineLobbyPage._disposed)
							{
								bedrockOnlineLobbyPage.SetLoadingState(loading: false);
							}
						}
					}
				}
				finally
				{
					if (num < 0 && _operation_5__2 != null)
					{
						((global::System.IDisposable)_operation_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_operation_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_operation_5__2 = null;
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
	private struct _Page_Loaded_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007f;
				}
				if (((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)bedrockOnlineLobbyPage.Rooms).Count == 0)
				{
					_u__ = bedrockOnlineLobbyPage.LoadRoomsAsync(reset: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _Page_Loaded_d__9>(ref _u__, ref this);
						return;
					}
					goto IL_007f;
				}
				goto end_IL_0011;
				IL_007f:
				_u__.GetResult();
				end_IL_0011:;
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
	private struct _RefreshButton_Click_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockOnlineLobbyPage.LoadRoomsAsync(reset: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__11>(ref _u__, ref this);
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SearchBox_KeyDown_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public KeyRoutedEventArgs e;

		public BedrockOnlineLobbyPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008d;
				}
				if ((int)e.Key == 13)
				{
					e.Handled = true;
					_u__ = bedrockOnlineLobbyPage.LoadRoomsAsync(reset: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchBox_KeyDown_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_008d;
				}
				goto end_IL_0011;
				IL_008d:
				_u__.GetResult();
				end_IL_0011:;
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
	private struct _SearchButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BedrockOnlineLobbyPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BedrockOnlineLobbyPage bedrockOnlineLobbyPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = bedrockOnlineLobbyPage.LoadRoomsAsync(reset: true).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SearchButton_Click_d__10>(ref _u__, ref this);
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

	private readonly da18CdX55laNMRKtM3p0 _clientService;

	private CancellationTokenSource? _operationCancellation;

	private int _offset;

	private bool _hasMore;

	private bool _disposed;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LoadMoreButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressBar OperationProgressBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView RoomList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBedrockOnlineLobbyPage_Bindings Bindings;

	[field: CompilerGenerated]
	private ObservableCollection<en9Zr5faBGr6cyEG7MZ5> _Rooms_k__BackingField;
	public ObservableCollection<en9Zr5faBGr6cyEG7MZ5> Rooms
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockOnlineLobbyPage()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		_clientService = da18CdX55laNMRKtM3p0.Shared;
		_Rooms_k__BackingField = new ObservableCollection<en9Zr5faBGr6cyEG7MZ5>();
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(Page_Loaded);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		AppShell.RegisterDisposable(this);
		AppShell.RegisterDisposable((global::System.IDisposable)_clientService);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void Page_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_Page_Loaded_d__9 page_Loaded_d__ = default(_Page_Loaded_d__9);
		page_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		page_Loaded_d__.__4__this = this;
		page_Loaded_d__.__1__state = -1;
		page_Loaded_d__.__t__builder.Start<_Page_Loaded_d__9>(ref page_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchButton_Click_d__10 searchButton_Click_d__ = default(_SearchButton_Click_d__10);
		searchButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchButton_Click_d__.__4__this = this;
		searchButton_Click_d__.__1__state = -1;
		searchButton_Click_d__.__t__builder.Start<_SearchButton_Click_d__10>(ref searchButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__11 refreshButton_Click_d__ = default(_RefreshButton_Click_d__11);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__11>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoadMoreButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadMoreButton_Click_d__12 loadMoreButton_Click_d__ = default(_LoadMoreButton_Click_d__12);
		loadMoreButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loadMoreButton_Click_d__.__4__this = this;
		loadMoreButton_Click_d__.__1__state = -1;
		loadMoreButton_Click_d__.__t__builder.Start<_LoadMoreButton_Click_d__12>(ref loadMoreButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SearchBox_KeyDown(object sender, KeyRoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SearchBox_KeyDown_d__13 searchBox_KeyDown_d__ = default(_SearchBox_KeyDown_d__13);
		searchBox_KeyDown_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		searchBox_KeyDown_d__.__4__this = this;
		searchBox_KeyDown_d__.e = e;
		searchBox_KeyDown_d__.__1__state = -1;
		searchBox_KeyDown_d__.__t__builder.Start<_SearchBox_KeyDown_d__13>(ref searchBox_KeyDown_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadRoomsAsync(bool reset)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadRoomsAsync_d__14 loadRoomsAsync_d__ = default(_LoadRoomsAsync_d__14);
		loadRoomsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadRoomsAsync_d__.__4__this = this;
		loadRoomsAsync_d__.reset = reset;
		loadRoomsAsync_d__.__1__state = -1;
		loadRoomsAsync_d__.__t__builder.Start<_LoadRoomsAsync_d__14>(ref loadRoomsAsync_d__);
		return loadRoomsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void EnterRoomButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_EnterRoomButton_Click_d__15 enterRoomButton_Click_d__ = default(_EnterRoomButton_Click_d__15);
		enterRoomButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		enterRoomButton_Click_d__.__4__this = this;
		enterRoomButton_Click_d__.sender = sender;
		enterRoomButton_Click_d__.__1__state = -1;
		enterRoomButton_Click_d__.__t__builder.Start<_EnterRoomButton_Click_d__15>(ref enterRoomButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		CancellationTokenSource? operationCancellation = _operationCancellation;
		if (operationCancellation != null)
		{
			operationCancellation.Cancel();
		}
		if (!((DependencyObject)this).DispatcherQueue.HasThreadAccess)
		{
			((DependencyObject)this).DispatcherQueue.TryEnqueue(new DispatcherQueueHandler(ClearRooms));
		}
		else
		{
			ClearRooms();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearRooms()
	{
		((Collection<en9Zr5faBGr6cyEG7MZ5>)(object)Rooms).Clear();
		_offset = 0;
		_hasMore = false;
		StatusText.Text = "请先建立游戏会话";
		SetEmptyState("请先建立游戏会话", "登录 PE 账号后加载联机大厅房间。", show: true);
		((UIElement)LoadMoreButton).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLoadingState(bool loading)
	{
		((Control)SearchBox).IsEnabled = !loading;
		((Control)RoomList).IsEnabled = !loading;
		((Control)LoadMoreButton).IsEnabled = !loading && _hasMore;
		((UIElement)OperationProgressBar).Visibility = ((!loading) ? Visibility.Visible : Visibility.Collapsed);
		if (loading)
		{
			OperationProgressBar.IsIndeterminate = true;
		}
		else
		{
			OperationProgressBar.IsIndeterminate = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetLaunchProgress(bool active, string message, double percent)
	{
		StatusText.Text = message;
		((UIElement)OperationProgressBar).Visibility = ((!active) ? Visibility.Visible : Visibility.Collapsed);
		OperationProgressBar.IsIndeterminate = false;
		((RangeBase)OperationProgressBar).Value = Math.Clamp(percent, 0.0, 100.0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetEmptyState(string title, string description, bool show)
	{
		EmptyTitle.Text = title;
		EmptyDescription.Text = description;
		((UIElement)EmptyPanel).Visibility = ((!show) ? Visibility.Visible : Visibility.Collapsed);
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
			((FrameworkElement)this).Loaded -= new RoutedEventHandler(Page_Loaded);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			CancellationTokenSource? operationCancellation = _operationCancellation;
			if (operationCancellation != null)
			{
				operationCancellation.Cancel();
			}
			CancellationTokenSource? operationCancellation2 = _operationCancellation;
			if (operationCancellation2 != null)
			{
				operationCancellation2.Dispose();
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
			Uri val = new Uri("ms-appx:///Views/Pages/Bedrock/BedrockOnlineLobbyPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LoadMoreButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoadMoreButton).Click += new RoutedEventHandler(LoadMoreButton_Click);
			break;
		case 3:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			OperationProgressBar = CastExtensions.As<ProgressBar>(target);
			break;
		case 5:
			RoomList = CastExtensions.As<ListView>(target);
			break;
		case 6:
			EmptyPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 7:
			EmptyTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			EmptyDescription = CastExtensions.As<TextBlock>(target);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(EnterRoomButton_Click);
			break;
		case 19:
			SearchBox = CastExtensions.As<TextBox>(target);
			((UIElement)SearchBox).KeyDown += new KeyEventHandler(SearchBox_KeyDown);
			break;
		case 20:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(SearchButton_Click);
			break;
		case 21:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
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
			Page val2 = (Page)target;
			BedrockOnlineLobbyPage_obj1_Bindings bedrockOnlineLobbyPage_obj1_Bindings = (BedrockOnlineLobbyPage_obj1_Bindings)new BedrockOnlineLobbyPage_obj1_Bindings();
			result = (IComponentConnector)(object)bedrockOnlineLobbyPage_obj1_Bindings;
			bedrockOnlineLobbyPage_obj1_Bindings.SetDataRoot(this);
			Bindings = bedrockOnlineLobbyPage_obj1_Bindings;
			((FrameworkElement)val2).Loading += bedrockOnlineLobbyPage_obj1_Bindings.Loading;
			break;
		}
		case 10:
		{
			Border val = (Border)target;
			BedrockOnlineLobbyPage_obj10_Bindings bedrockOnlineLobbyPage_obj10_Bindings = (BedrockOnlineLobbyPage_obj10_Bindings)new BedrockOnlineLobbyPage_obj10_Bindings();
			result = (IComponentConnector)(object)bedrockOnlineLobbyPage_obj10_Bindings;
			bedrockOnlineLobbyPage_obj10_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += bedrockOnlineLobbyPage_obj10_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)bedrockOnlineLobbyPage_obj10_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)bedrockOnlineLobbyPage_obj10_Bindings);
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

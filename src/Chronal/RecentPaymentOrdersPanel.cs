using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Shapes;
using WinRT;
using WinRT.ChronalVtableClasses;
using nowIRbfRRJ79HCUCsbjS;
using qG4hi9fRxSuBHQR0lMWK;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
public sealed class RecentPaymentOrdersPanel : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IRecentPaymentOrdersPanel_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IRecentPaymentOrdersPanel_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(TextBlock obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static void Set_Microsoft_UI_Xaml_UIElement_Visibility(UIElement obj, Visibility value)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			obj.Visibility = value;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class RecentPaymentOrdersPanel_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IRecentPaymentOrdersPanel_Bindings
	{
		private delegate void InvokeFunctionDelegate(int phase);

		[DebuggerNonUserCode]
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		private class RecentPaymentOrdersPanel_obj5_BindingsTracking
		{
			private WeakReference<RecentPaymentOrdersPanel_obj5_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public RecentPaymentOrdersPanel_obj5_BindingsTracking(RecentPaymentOrdersPanel_obj5_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<RecentPaymentOrdersPanel_obj5_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public RecentPaymentOrdersPanel_obj5_Bindings TryGetBindingObject()
			{
				RecentPaymentOrdersPanel_obj5_Bindings recentPaymentOrdersPanel_obj5_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out recentPaymentOrdersPanel_obj5_Bindings);
					if (recentPaymentOrdersPanel_obj5_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return recentPaymentOrdersPanel_obj5_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private aS44CUfR6tdgNLbdQbUH dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBlock obj6;

		private TextBlock obj7;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private Ellipse obj11;

		private Ellipse obj12;

		private Ellipse obj13;

		private Ellipse obj14;

		private RecentPaymentOrdersPanel_obj5_BindingsTracking bindingsTracking;

		private Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings;

		[MethodImpl((MethodImplOptions)8)]
		public RecentPaymentOrdersPanel_obj5_Bindings()
		{
			PendingFunctionBindings = new Dictionary<string, InvokeFunctionDelegate>();
			bindingsTracking = (RecentPaymentOrdersPanel_obj5_BindingsTracking)new RecentPaymentOrdersPanel_obj5_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 6:
				obj6 = CastExtensions.As<TextBlock>(target);
				break;
			case 7:
				obj7 = CastExtensions.As<TextBlock>(target);
				break;
			case 8:
				obj8 = CastExtensions.As<TextBlock>(target);
				break;
			case 9:
				obj9 = CastExtensions.As<TextBlock>(target);
				break;
			case 10:
				obj10 = CastExtensions.As<TextBlock>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<Ellipse>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<Ellipse>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<Ellipse>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<Ellipse>(target);
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
			object target = obj5.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<aS44CUfR6tdgNLbdQbUH>(item), 1 << phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Recycle()
		{
			bindingsTracking.ReleaseAllListeners();
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
				dataRoot = CastExtensions.As<aS44CUfR6tdgNLbdQbUH>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool TryGet_Status(out string val)
		{
			//IL_0023: Expected I8, but got O
			//IL_001e: Expected I8, but got O
			if (TryGet_(out var val2) && val2 != null)
			{
				val = default;
				return true;
			}
			val = default;
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool TryGet_(out aS44CUfR6tdgNLbdQbUH val)
		{
			//IL_000b: Expected I8, but got O
			val = (aS44CUfR6tdgNLbdQbUH)dataRoot;
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = PaidDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj11, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = PendingDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj12, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = FailedDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj13, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = OtherDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj14, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void CompleteUpdate(int phase)
		{
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			Dictionary<string, InvokeFunctionDelegate> pendingFunctionBindings = PendingFunctionBindings;
			PendingFunctionBindings = new Dictionary<string, InvokeFunctionDelegate>();
			var enumerator = pendingFunctionBindings.Values.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					enumerator.Current(phase);
				}
			}
			finally
			{
				((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(aS44CUfR6tdgNLbdQbUH obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_ChannelName(obj.ChannelName, phase);
				Update_PayAmountText(obj.PayAmountText, phase);
				Update_PurposeText(obj.PurposeText, phase);
				Update_TimeText(obj.TimeText, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_Status(obj.Status, phase);
			}
			Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104(phase);
			Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104(phase);
			Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104(phase);
			Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104(phase);
			CompleteUpdate(phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ChannelName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PayAmountText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PurposeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TimeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Status(string obj, int phase)
		{
			if (obj != null)
			{
				Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104(phase);
				Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104(phase);
				Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104(phase);
				Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104(phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104"] = Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PaidDotVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104"] = Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_PendingDotVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104"] = Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_FailedDotVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104"] = Invoke_Mahiro_Account_UI_Controls_RecentPaymentOrdersPanel_M_OtherDotVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RefreshAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public RecentPaymentOrdersPanel __4__this;

		private TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RecentPaymentOrdersPanel recentPaymentOrdersPanel = __4__this;
			try
			{
				TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.aLB0v5viGX(1, 5).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY>, _RefreshAsync_d__6>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY>);
					num = (__1__state = -1);
				}
				q2BJ1ifRPDNVJ0t9KrGY result = _u__.GetResult();
				UiHelpers.Replace(recentPaymentOrdersPanel._orders, (global::System.Collections.Generic.IEnumerable<aS44CUfR6tdgNLbdQbUH>)result.Orders);
				((UIElement)recentPaymentOrdersPanel.EmptyStatePanel).Visibility = (((((Collection<aS44CUfR6tdgNLbdQbUH>)(object)recentPaymentOrdersPanel._orders).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
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

	private readonly ObservableCollection<aS44CUfR6tdgNLbdQbUH> _orders;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView RecentOrderList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyStatePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IRecentPaymentOrdersPanel_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public RecentPaymentOrdersPanel()
	{
		_orders = new ObservableCollection<aS44CUfR6tdgNLbdQbUH>();
		InitializeComponent();
		((ItemsControl)RecentOrderList).ItemsSource = _orders;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility PaidDotVisibility(string status)
	{
		if (status == "paid")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility PendingDotVisibility(string status)
	{
		if (status == "pending")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility FailedDotVisibility(string status)
	{
		if (status == "failed")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility OtherDotVisibility(string status)
	{
		if ((status == "paid" || status == "pending" || status == "failed") ? true : false)
		{
			return (Visibility)1;
		}
		return (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task RefreshAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAsync_d__6 refreshAsync_d__ = default(_RefreshAsync_d__6);
		refreshAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAsync_d__.__4__this = this;
		refreshAsync_d__.__1__state = -1;
		refreshAsync_d__.__t__builder.Start<_RefreshAsync_d__6>(ref refreshAsync_d__);
		return refreshAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		((Collection<aS44CUfR6tdgNLbdQbUH>)(object)_orders).Clear();
		((Selector)RecentOrderList).SelectedItem = null;
		((UIElement)EmptyStatePanel).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RecentOrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		object selectedItem = ((Selector)RecentOrderList).SelectedItem;
		aS44CUfR6tdgNLbdQbUH val = (aS44CUfR6tdgNLbdQbUH)((selectedItem is aS44CUfR6tdgNLbdQbUH) ? selectedItem : null);
		if (val != null)
		{
			((Selector)RecentOrderList).SelectedItem = null;
			AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage), val.OrderNo);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AllOrdersButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("paymentOrders"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BalanceHistoryButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("balanceHistory"));
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
			Uri val = new Uri("ms-appx:///UI/Controls/RecentPaymentOrdersPanel.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			RecentOrderList = CastExtensions.As<ListView>(target);
			((Selector)RecentOrderList).SelectionChanged += new SelectionChangedEventHandler(RecentOrderList_SelectionChanged);
			break;
		case 3:
			EmptyStatePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(BalanceHistoryButton_Click);
			break;
		case 16:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(AllOrdersButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 5)
		{
			Grid val = (Grid)target;
			RecentPaymentOrdersPanel_obj5_Bindings recentPaymentOrdersPanel_obj5_Bindings = (RecentPaymentOrdersPanel_obj5_Bindings)new RecentPaymentOrdersPanel_obj5_Bindings();
			result = (IComponentConnector)(object)recentPaymentOrdersPanel_obj5_Bindings;
			recentPaymentOrdersPanel_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += recentPaymentOrdersPanel_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)recentPaymentOrdersPanel_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)recentPaymentOrdersPanel_obj5_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

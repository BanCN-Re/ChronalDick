using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BNyHcUfRdE6bqImEQbYu;
using By1SFsLobKQOZCdh5qRg;
using KIXiTCfRkrHP7oZK89E4;
using Mahiro_Account.UI.Navigation;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using MnCNHgfwhm1BlAufHdT1;
using MxR6V4fw1JmwZAnDGw3X;
using QnRg8tfRY6CfQ4Wt7Sc5;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using c3BNZqfwv5FUbHQcBZP8;
using fP0gtffR8x6iKYFl06Cb;
using gwt7kqfebXTfvoaCUCUp;
using haIKS5fw2YRHybtyfaXG;
using qS8vkpL43FlTMgcj0rgs;
using yF160kfwGseu0SQV9uio;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ServiceSubscriptionsPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IServiceSubscriptionsPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IServiceSubscriptionsPage_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class ServiceSubscriptionsPage_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IServiceSubscriptionsPage_Bindings
	{
		private QViUVJfwErbDiYmY0eTe dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBlock obj6;

		private TextBlock obj7;

		private TextBlock obj8;

		private TextBlock obj9;

		[MethodImpl((MethodImplOptions)8)]
		public ServiceSubscriptionsPage_obj5_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
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
			nextPhase = 0;
			removedDataContextHandler = true;
			object target = obj5.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<QViUVJfwErbDiYmY0eTe>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<QViUVJfwErbDiYmY0eTe>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(QViUVJfwErbDiYmY0eTe obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_DurationChangeText(obj.DurationChangeText, phase);
				Update_NewExpiryText(obj.NewExpiryText, phase);
				Update_EventText(obj.EventText, phase);
				Update_CreatedAtText(obj.CreatedAtText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DurationChangeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_NewExpiryText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_EventText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CreatedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class ServiceSubscriptionsPage_obj13_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IServiceSubscriptionsPage_Bindings
	{
		private jpLHDefwa5H2Sf8UX9BT dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj13;

		private TextBlock obj14;

		private Button obj15;

		private TextBlock obj16;

		private TextBlock obj17;

		private TextBlock obj18;

		[MethodImpl((MethodImplOptions)8)]
		public ServiceSubscriptionsPage_obj13_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			switch (connectionId)
			{
			case 13:
				obj13 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 14:
				obj14 = CastExtensions.As<TextBlock>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<Button>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<TextBlock>(target);
				break;
			case 17:
				obj17 = CastExtensions.As<TextBlock>(target);
				break;
			case 18:
				obj18 = CastExtensions.As<TextBlock>(target);
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
			nextPhase = 0;
			removedDataContextHandler = true;
			object target = obj13.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<jpLHDefwa5H2Sf8UX9BT>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<jpLHDefwa5H2Sf8UX9BT>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(jpLHDefwa5H2Sf8UX9BT obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Description(obj.Description, phase);
				Update_PriceText(obj.PriceText, phase);
				Update_Name(obj.Name, phase);
				Update_DurationText(obj.DurationText, phase);
			}
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PriceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj16, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Name(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj17, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DurationText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj18, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__4_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ServiceSubscriptionsPage __4__this;

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
			ServiceSubscriptionsPage serviceSubscriptionsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = serviceSubscriptionsPage.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__4_0_d>(ref _u__, ref this);
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
	private struct __LoadAsync_b__5_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ServiceSubscriptionsPage __4__this;

		private __c__DisplayClass5_0 __8__1;

		private XQvZhgfwqBVVjaySr6Ok _response_5__2;

		private A9uRAufRVheoa8CBA6OA _paymentCenterMethods_5__3;

		private TaskAwaiter<XQvZhgfwqBVVjaySr6Ok> __u__1;

		private TaskAwaiter<A9uRAufRVheoa8CBA6OA> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ServiceSubscriptionsPage __8_locals29 = __4__this;
			try
			{
				TaskAwaiter<XQvZhgfwqBVVjaySr6Ok> _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						goto IL_00a8;
					}
					__8__1 = (__c__DisplayClass5_0)new __c__DisplayClass5_0();
					_u__ = AppShell.Api.t9bcGhGxjD(1, 20).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XQvZhgfwqBVVjaySr6Ok>, __LoadAsync_b__5_0_d>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<XQvZhgfwqBVVjaySr6Ok>);
					num = (__1__state = -1);
				}
				XQvZhgfwqBVVjaySr6Ok result = _u__.GetResult();
				_response_5__2 = result;
				_paymentCenterMethods_5__3 = null;
				__8_locals29._paymentConfigLoadFailed = false;
				goto IL_00a8;
				IL_00a8:
				try
				{
					TaskAwaiter<A9uRAufRVheoa8CBA6OA> _u__2 = default;
					if (num != 1)
					{
						_u__2 = AppShell.Api.RBq0ins422().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<A9uRAufRVheoa8CBA6OA>, __LoadAsync_b__5_0_d>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<A9uRAufRVheoa8CBA6OA>);
						num = (__1__state = -1);
					}
					A9uRAufRVheoa8CBA6OA result2 = _u__2.GetResult();
					_paymentCenterMethods_5__3 = result2;
				}
				catch (global::System.Exception ex)
				{
					__8_locals29._paymentConfigLoadFailed = true;
					gX17swyO7x0JWQxdaD1.U3iyRWfbJV("services", "加载支付中心方式失败", ex);
				}
				__8_locals29.UpdatePurchaseMethods(_paymentCenterMethods_5__3);
				__8_locals29.BalanceText.Text = $"¥ {_response_5__2.Balance:0.00}";
				((ItemsControl)__8_locals29.ServiceCombo).DisplayMemberPath = "Name";
				((Selector)__8_locals29.ServiceCombo).SelectedValuePath = "Code";
				((ItemsControl)__8_locals29.ServiceCombo).ItemsSource = _response_5__2.Services;
				__c__DisplayClass5_0 _c__DisplayClass5_ = __8__1;
				object selectedCode;
				if (!Enumerable.Any<ixkKI2fw3cF6iNilYo5r>((global::System.Collections.Generic.IEnumerable<ixkKI2fw3cF6iNilYo5r>)_response_5__2.Services, (Func<ixkKI2fw3cF6iNilYo5r, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (ixkKI2fw3cF6iNilYo5r item) => item.Code == __8_locals29._selectedServiceCode)))
				{
					ixkKI2fw3cF6iNilYo5r obj = Enumerable.FirstOrDefault<ixkKI2fw3cF6iNilYo5r>((global::System.Collections.Generic.IEnumerable<ixkKI2fw3cF6iNilYo5r>)_response_5__2.Services);
					selectedCode = ((obj != null) ? obj.Code : null) ?? string.Empty;
				}
				else
				{
					selectedCode = __8_locals29._selectedServiceCode;
				}
				_c__DisplayClass5_.selectedCode = (string)selectedCode;
				__8_locals29._selectedServiceCode = __8__1.selectedCode;
				((Selector)__8_locals29.ServiceCombo).SelectedValue = __8__1.selectedCode;
				ixkKI2fw3cF6iNilYo5r val = Enumerable.FirstOrDefault<ixkKI2fw3cF6iNilYo5r>((global::System.Collections.Generic.IEnumerable<ixkKI2fw3cF6iNilYo5r>)_response_5__2.Services, (Func<ixkKI2fw3cF6iNilYo5r, bool>)__8__1._LoadAsync_b__2);
				if (val == null)
				{
					__8_locals29.ServiceNameText.Text = "服务不可用";
					__8_locals29.ServiceDescriptionText.Text = string.Empty;
					__8_locals29.StatusText.Text = "服务不可用";
					__8_locals29.ExpiryText.Text = "-";
					__8_locals29.RemainingLabelText.Text = "订阅说明";
					__8_locals29.RemainingText.Text = "管理员尚未启用该服务";
					__8_locals29.PlansList.ItemsSource = null;
					((UIElement)__8_locals29.PlansEmptyState).Visibility = (Visibility)0;
				}
				else
				{
					__8_locals29.ServiceNameText.Text = val.Name;
					__8_locals29.ServiceDescriptionText.Text = val.Description;
					__8_locals29.StatusText.Text = val.Access.StatusText;
					__8_locals29.ExpiryText.Text = val.Access.ExpiryText;
					__8_locals29.RemainingLabelText.Text = ((val.Access.IsLifetime && val.Access.Status == "active") ? "订阅类型" : ((val.Access.Status == "active") ? "剩余时长" : "订阅说明"));
					__8_locals29.RemainingText.Text = ((val.Access.Status == "active") ? val.Access.RemainingText : val.Access.SummaryText);
					__8_locals29.PlansList.ItemsSource = val.Plans;
					((UIElement)__8_locals29.PlansEmptyState).Visibility = (((val.Plans.Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
				}
				((ItemsControl)__8_locals29.EventsList).ItemsSource = _response_5__2.Events;
				((UIElement)__8_locals29.EventsEmptyState).Visibility = (((_response_5__2.Events.Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				_response_5__2 = null;
				_paymentCenterMethods_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_response_5__2 = null;
			_paymentCenterMethods_5__3 = null;
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

	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0
	{
		public string selectedCode;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass5_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _LoadAsync_b__2(ixkKI2fw3cF6iNilYo5r item)
		{
			return item.Code == selectedCode;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0_3
	{
		public string selectedCode;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _UpdatePurchaseMethods_b__0(t38PEtfRlRJjDwb2rSSY method)
		{
			return method.Code == selectedCode;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ServiceSubscriptionsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ServiceSubscriptionsPage __8_locals4 = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_002f;
				}
				if (!__8_locals4._loading)
				{
					__8_locals4._loading = true;
					goto IL_002f;
				}
				goto end_IL_0011;
				IL_002f:
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
						{
							//IL_0005: Unknown result type (might be due to invalid IL or missing references)
							//IL_000a: Unknown result type (might be due to invalid IL or missing references)
							__LoadAsync_b__5_0_d _LoadAsync_b__5_0_d = default(__LoadAsync_b__5_0_d);
							_LoadAsync_b__5_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
							_LoadAsync_b__5_0_d.__4__this = __8_locals4;
							_LoadAsync_b__5_0_d.__1__state = -1;
							_LoadAsync_b__5_0_d.__t__builder.Start<__LoadAsync_b__5_0_d>(ref _LoadAsync_b__5_0_d);
							return _LoadAsync_b__5_0_d.__t__builder.Task;
						}).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAsync_d__5>(ref _u__, ref this);
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
				finally
				{
					if (num < 0)
					{
						__8_locals4._loading = false;
					}
				}
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
	private struct _PurchaseButton_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public ServiceSubscriptionsPage __4__this;

		private Button _button_5__2;

		private jpLHDefwa5H2Sf8UX9BT _plan_5__3;

		private t38PEtfRlRJjDwb2rSSY _method_5__4;

		private TaskAwaiter<bool> __u__1;

		private int __7__wrap4;

		private UfjqWXfw4LbmaQBvftfE _ex_5__6;

		private UfjqWXfw4LbmaQBvftfE __7__wrap6;

		private dMTVZZfwzx9x02bGIKos _result_5__8;

		private TaskAwaiter<dMTVZZfwzx9x02bGIKos> __u__2;

		private TaskAwaiter __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_055b: Expected O, but got Unknown
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Expected O, but got Unknown
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0657: Unknown result type (might be due to invalid IL or missing references)
			//IL_0659: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0705: Unknown result type (might be due to invalid IL or missing references)
			//IL_0707: Unknown result type (might be due to invalid IL or missing references)
			//IL_074d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0672: Unknown result type (might be due to invalid IL or missing references)
			//IL_0677: Unknown result type (might be due to invalid IL or missing references)
			//IL_067f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0720: Unknown result type (might be due to invalid IL or missing references)
			//IL_0725: Unknown result type (might be due to invalid IL or missing references)
			//IL_072d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_032e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_035c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_0313: Unknown result type (might be due to invalid IL or missing references)
			//IL_0315: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0376: Unknown result type (might be due to invalid IL or missing references)
			//IL_0532: Unknown result type (might be due to invalid IL or missing references)
			//IL_0454: Unknown result type (might be due to invalid IL or missing references)
			//IL_045e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0463: Unknown result type (might be due to invalid IL or missing references)
			//IL_046e: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0474: Unknown result type (might be due to invalid IL or missing references)
			//IL_0488: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Expected O, but got Unknown
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0184: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ServiceSubscriptionsPage serviceSubscriptionsPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_01d8;
				}
				if ((uint)(num - 1) <= 4u)
				{
					goto IL_01f6;
				}
				ref Button reference = ref _button_5__2;
				object obj = sender;
				reference = (Button)((obj is Button) ? obj : null);
				if (_button_5__2 != null)
				{
					object tag = ((FrameworkElement)_button_5__2).Tag;
					_plan_5__3 = (jpLHDefwa5H2Sf8UX9BT)((tag is jpLHDefwa5H2Sf8UX9BT) ? tag : null);
					if (_plan_5__3 != null)
					{
						tag = ((Selector)serviceSubscriptionsPage.PurchaseMethodCombo).SelectedItem;
						_method_5__4 = (t38PEtfRlRJjDwb2rSSY)((tag is t38PEtfRlRJjDwb2rSSY) ? tag : null);
						if (_method_5__4 != null)
						{
							string text = ((_method_5__4.Code == "balance") ? "账户余额" : _method_5__4.DisplayText);
							_u__ = AppShell.ConfirmAsync("确认购买服务套餐", $"将使用{text}支付 {_plan_5__3.PriceText}，购买「{_plan_5__3.Name}」，到账 {_plan_5__3.DurationText}。", (_method_5__4.Code == "balance") ? "确认购买" : "创建支付订单").GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _PurchaseButton_Click_d__12>(ref _u__, ref this);
								return;
							}
							goto IL_01d8;
						}
						AppShell.Warning("请先选择支付方式");
					}
				}
				goto end_IL_0011;
				IL_01f6:
				try
				{
					int num2;
					switch (num)
					{
					default:
						__7__wrap4 = 0;
						goto case 1;
					case 1:
					case 2:
					case 3:
						try
						{
							TaskAwaiter<dMTVZZfwzx9x02bGIKos> _u__3 = default;
							TaskAwaiter _u__2 = default;
							dMTVZZfwzx9x02bGIKos result;
							switch (num)
							{
							default:
								if (_method_5__4.Code == "balance")
								{
									_u__3 = AppShell.Api.dJOcnI0Ywp(_plan_5__3.Id, ((object)Guid.NewGuid()/*cast due to .constrained prefix*/).ToString(), _plan_5__3.ServiceCode).GetAwaiter();
									if (!_u__3.IsCompleted)
									{
										num = (__1__state = 1);
										__u__2 = _u__3;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<dMTVZZfwzx9x02bGIKos>, _PurchaseButton_Click_d__12>(ref _u__3, ref this);
										return;
									}
									goto IL_02d0;
								}
								if (_method_5__4.IsPaymentCenter)
								{
									AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.PaymentCenterPage), (object?)new T9NmGVfR07AvCBhE2MjK
									{
										Purpose = "service_subscription",
										RequestNo = ((object)Guid.NewGuid()/*cast due to .constrained prefix*/).ToString(),
										ServiceCode = _plan_5__3.ServiceCode,
										PlanId = _plan_5__3.Id,
										Subject = "购买服务套餐 " + _plan_5__3.Name,
										AmountCents = (int)Math.Round(_plan_5__3.Price * 100m, (MidpointRounding)1),
										ChannelId = _method_5__4.PaymentCenterChannelId,
										Method = _method_5__4.PaymentCenterMethod
									});
									AppShell.Success("已进入支付中心套餐支付");
									break;
								}
								throw new InvalidOperationException("该支付方式已停用，请重新选择支付方式");
							case 1:
								_u__3 = __u__2;
								__u__2 = default(TaskAwaiter<dMTVZZfwzx9x02bGIKos>);
								num = (__1__state = -1);
								goto IL_02d0;
							case 2:
								_u__2 = __u__3;
								__u__3 = default(TaskAwaiter);
								num = (__1__state = -1);
								goto IL_034a;
							case 3:
								{
									_u__2 = __u__3;
									__u__3 = default(TaskAwaiter);
									num = (__1__state = -1);
									goto IL_03ab;
								}
								IL_03ab:
								_u__2.GetResult();
								AppShell.Success(_result_5__8.IsLifetime ? "购买成功，永久订阅已生效" : (_result_5__8.ExpiresAt.HasValue ? $"购买成功，到期时间 {_result_5__8.ExpiresAt.Value.ToLocalTime():yyyy-MM-dd HH:mm:ss}" : "购买成功，订阅已生效"));
								break;
								IL_034a:
								_u__2.GetResult();
								_u__2 = serviceSubscriptionsPage.LoadAsync().GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 3);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PurchaseButton_Click_d__12>(ref _u__2, ref this);
									return;
								}
								goto IL_03ab;
								IL_02d0:
								result = _u__3.GetResult();
								_result_5__8 = result;
								AppShell.NotifyBalanceChanged(_result_5__8.Balance);
								_u__2 = AppShell.RefreshSummaryAsync().GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 2);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PurchaseButton_Click_d__12>(ref _u__2, ref this);
									return;
								}
								goto IL_034a;
							}
						}
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							object obj3 = ((obj2 is UfjqWXfw4LbmaQBvftfE) ? obj2 : null);
							global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
							if (obj3 == null)
							{
								result2 = 0;
							}
							else
							{
								UfjqWXfw4LbmaQBvftfE __exLocal0 = (UfjqWXfw4LbmaQBvftfE)obj3;
								result2 = ((__exLocal0.Code == "INSUFFICIENT_BALANCE") ? 1 : 0);
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							__7__wrap4 = 1;
							goto IL_05ea;
						}
						catch (global::System.Exception obj4) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							object obj5 = ((obj4 is UfjqWXfw4LbmaQBvftfE) ? obj4 : null);
							global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result3);
							if (obj5 == null)
							{
								result3 = 0;
							}
							else
							{
								UfjqWXfw4LbmaQBvftfE __exLocal1 = (UfjqWXfw4LbmaQBvftfE)obj5;
								result3 = ((__exLocal1.Code == "PAYMENT_ORDER_PENDING_EXISTS") ? 1 : 0);
							}
							return (byte)result3 != 0;
						}).Invoke())
						{
							__7__wrap4 = 2;
							goto IL_05ea;
						}
						catch (global::System.Exception exception)
						{
							AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "PurchaseButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ServiceSubscriptionsPage.xaml.cs", 225));
							goto IL_05ea;
						}
						goto end_IL_01f6;
					case 4:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_068e;
					case 5:
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							goto IL_073c;
						}
						IL_05ea:
						num2 = __7__wrap4;
						if (num2 != 1)
						{
							if (num2 != 2)
							{
								break;
							}
							cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)__7__wrap6, "ui-exception", "PurchaseButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ServiceSubscriptionsPage.xaml.cs", 216);
							_u__ = AppShell.ConfirmAsync("已有待支付订单", ((global::System.Exception)(object)__7__wrap6).Message, "查看支付订单").GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 5);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _PurchaseButton_Click_d__12>(ref _u__, ref this);
								return;
							}
							goto IL_073c;
						}
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)_ex_5__6, "ui-exception", "PurchaseButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ServiceSubscriptionsPage.xaml.cs", 210);
						_u__ = AppShell.ConfirmAsync("账户余额不足", "当前余额无法完成购买，请先充值余额。", "前往充值").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 4);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _PurchaseButton_Click_d__12>(ref _u__, ref this);
							return;
						}
						goto IL_068e;
						IL_073c:
						if (_u__.GetResult())
						{
							AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage));
						}
						break;
						IL_068e:
						if (_u__.GetResult())
						{
							AppShell.Navigate(NavigationRegistry.MainPageType("balance"));
						}
						break;
					}
					_ex_5__6 = null;
					__7__wrap6 = null;
					end_IL_01f6:;
				}
				finally
				{
					if (num < 0)
					{
						((Control)_button_5__2).IsEnabled = true;
					}
				}
				goto end_IL_0011;
				IL_01d8:
				if (_u__.GetResult())
				{
					((Control)_button_5__2).IsEnabled = false;
					goto IL_01f6;
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__t__builder.SetException(exception2);
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
	private struct _RefreshButton_Click_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ServiceSubscriptionsPage __4__this;

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
			ServiceSubscriptionsPage serviceSubscriptionsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = serviceSubscriptionsPage.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__7>(ref _u__, ref this);
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
	private struct _ServiceCombo_SelectionChanged_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ServiceSubscriptionsPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ServiceSubscriptionsPage serviceSubscriptionsPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00b8;
				}
				if (!serviceSubscriptionsPage._loading && ((Selector)serviceSubscriptionsPage.ServiceCombo).SelectedValue is string text && !string.IsNullOrWhiteSpace(text) && !(text == serviceSubscriptionsPage._selectedServiceCode))
				{
					serviceSubscriptionsPage._selectedServiceCode = text;
					_u__ = serviceSubscriptionsPage.LoadAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ServiceCombo_SelectionChanged_d__6>(ref _u__, ref this);
						return;
					}
					goto IL_00b8;
				}
				goto end_IL_0011;
				IL_00b8:
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

	private readonly ObservableCollection<t38PEtfRlRJjDwb2rSSY> _purchaseMethods;

	private bool _loading;

	private bool _paymentConfigLoadFailed;

	private string _selectedServiceCode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView EventsList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EventsEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ItemsRepeater PlansList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border PlansEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PurchaseMethodCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PurchaseMethodHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BalanceText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RemainingLabelText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RemainingText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ExpiryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ServiceNameText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ServiceDescriptionText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ServiceCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IServiceSubscriptionsPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public ServiceSubscriptionsPage()
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		_purchaseMethods = new ObservableCollection<t38PEtfRlRJjDwb2rSSY>();
		_selectedServiceCode = string.Empty;
		InitializeComponent();
		((ItemsControl)PurchaseMethodCombo).ItemsSource = _purchaseMethods;
		((FrameworkElement)this).Loaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__4_0_d __ctor_b__4_0_d = default(___ctor_b__4_0_d);
			__ctor_b__4_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__4_0_d.__4__this = this;
			__ctor_b__4_0_d.__1__state = -1;
			__ctor_b__4_0_d.__t__builder.Start<___ctor_b__4_0_d>(ref __ctor_b__4_0_d);
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__5 loadAsync_d__ = default(_LoadAsync_d__5);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__5>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ServiceCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ServiceCombo_SelectionChanged_d__6 serviceCombo_SelectionChanged_d__ = default(_ServiceCombo_SelectionChanged_d__6);
		serviceCombo_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		serviceCombo_SelectionChanged_d__.__4__this = this;
		serviceCombo_SelectionChanged_d__.__1__state = -1;
		serviceCombo_SelectionChanged_d__.__t__builder.Start<_ServiceCombo_SelectionChanged_d__6>(ref serviceCombo_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__7 refreshButton_Click_d__ = default(_RefreshButton_Click_d__7);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__7>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RechargeButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("balance"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdatePurchaseMethods(A9uRAufRVheoa8CBA6OA? paymentCenterMethods)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		__c__DisplayClass9_0_3 __8_locals3 = (__c__DisplayClass9_0_3)new __c__DisplayClass9_0_3();
		__8_locals3.selectedCode = (((Selector)PurchaseMethodCombo).SelectedValue as string) ?? "balance";
		((Collection<t38PEtfRlRJjDwb2rSSY>)(object)_purchaseMethods).Clear();
		((Collection<t38PEtfRlRJjDwb2rSSY>)(object)_purchaseMethods).Add(new t38PEtfRlRJjDwb2rSSY
		{
			Code = "balance",
			ChannelCode = "balance",
			PayType = "balance",
			DisplayName = "账户余额支付",
			BalancePerYuan = 1m
		});
		global::System.Collections.Generic.IEnumerator<aIFZ93fRD8ZaK9DQ5OOq> enumerator = ((global::System.Collections.Generic.IEnumerable<aIFZ93fRD8ZaK9DQ5OOq>)(((paymentCenterMethods != null) ? paymentCenterMethods.Available : null) ?? global::System.Array.Empty<aIFZ93fRD8ZaK9DQ5OOq>())).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				aIFZ93fRD8ZaK9DQ5OOq current = enumerator.Current;
				((Collection<t38PEtfRlRJjDwb2rSSY>)(object)_purchaseMethods).Add(new t38PEtfRlRJjDwb2rSSY
				{
					Code = "payment_center:" + current.ChannelId + ":" + current.Method,
					ChannelCode = "payment_center",
					PayType = current.Method,
					DisplayName = "支付中心 · " + current.DisplayText,
					PaymentCenterChannelId = current.ChannelId,
					PaymentCenterMethod = current.Method,
					BalancePerYuan = 1m
				});
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		((Selector)PurchaseMethodCombo).SelectedValue = (Enumerable.Any<t38PEtfRlRJjDwb2rSSY>((global::System.Collections.Generic.IEnumerable<t38PEtfRlRJjDwb2rSSY>)_purchaseMethods, (Func<t38PEtfRlRJjDwb2rSSY, bool>)([MethodImpl((MethodImplOptions)8)] (t38PEtfRlRJjDwb2rSSY method) => method.Code == __8_locals3.selectedCode)) ? __8_locals3.selectedCode : "balance");
		UpdatePurchaseMethodHint();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PurchaseMethodCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdatePurchaseMethodHint();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdatePurchaseMethodHint()
	{
		object selectedItem = ((Selector)PurchaseMethodCombo).SelectedItem;
		t38PEtfRlRJjDwb2rSSY val = (t38PEtfRlRJjDwb2rSSY)((selectedItem is t38PEtfRlRJjDwb2rSSY) ? selectedItem : null);
		if (val == null)
		{
			PurchaseMethodHintText.Text = "请选择支付方式";
		}
		else
		{
			PurchaseMethodHintText.Text = ((!(val.Code == "balance")) ? ("通过" + val.DisplayText + "创建支付订单") : (_paymentConfigLoadFailed ? "在线支付方式加载失败，仍可使用账户余额" : "从当前余额直接扣除"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PurchaseButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PurchaseButton_Click_d__12 purchaseButton_Click_d__ = default(_PurchaseButton_Click_d__12);
		purchaseButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		purchaseButton_Click_d__.__4__this = this;
		purchaseButton_Click_d__.sender = sender;
		purchaseButton_Click_d__.__1__state = -1;
		purchaseButton_Click_d__.__t__builder.Start<_PurchaseButton_Click_d__12>(ref purchaseButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/ServiceSubscriptionsPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			EventsList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EventsEmptyState = CastExtensions.As<StackPanel>(target);
			break;
		case 10:
			PlansList = CastExtensions.As<ItemsRepeater>(target);
			break;
		case 11:
			PlansEmptyState = CastExtensions.As<Border>(target);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(PurchaseButton_Click);
			break;
		case 19:
			PurchaseMethodCombo = CastExtensions.As<ComboBox>(target);
			((Selector)PurchaseMethodCombo).SelectionChanged += new SelectionChangedEventHandler(PurchaseMethodCombo_SelectionChanged);
			break;
		case 20:
			PurchaseMethodHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			BalanceText = CastExtensions.As<TextBlock>(target);
			break;
		case 22:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RechargeButton_Click);
			break;
		case 23:
			RemainingLabelText = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			RemainingText = CastExtensions.As<TextBlock>(target);
			break;
		case 25:
			ExpiryText = CastExtensions.As<TextBlock>(target);
			break;
		case 26:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 27:
			ServiceNameText = CastExtensions.As<TextBlock>(target);
			break;
		case 28:
			ServiceDescriptionText = CastExtensions.As<TextBlock>(target);
			break;
		case 29:
			ServiceCombo = CastExtensions.As<ComboBox>(target);
			((Selector)ServiceCombo).SelectionChanged += new SelectionChangedEventHandler(ServiceCombo_SelectionChanged);
			break;
		case 30:
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
		//IL_0020: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		IComponentConnector result = null;
		switch (connectionId)
		{
		case 5:
		{
			Grid val2 = (Grid)target;
			ServiceSubscriptionsPage_obj5_Bindings serviceSubscriptionsPage_obj5_Bindings = (ServiceSubscriptionsPage_obj5_Bindings)new ServiceSubscriptionsPage_obj5_Bindings();
			result = (IComponentConnector)(object)serviceSubscriptionsPage_obj5_Bindings;
			serviceSubscriptionsPage_obj5_Bindings.SetDataRoot(((FrameworkElement)val2).DataContext);
			((FrameworkElement)val2).DataContextChanged += serviceSubscriptionsPage_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val2, (IDataTemplateExtension)(object)serviceSubscriptionsPage_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val2, (IDataTemplateComponent)(object)serviceSubscriptionsPage_obj5_Bindings);
			break;
		}
		case 13:
		{
			Border val = (Border)target;
			ServiceSubscriptionsPage_obj13_Bindings serviceSubscriptionsPage_obj13_Bindings = (ServiceSubscriptionsPage_obj13_Bindings)new ServiceSubscriptionsPage_obj13_Bindings();
			result = (IComponentConnector)(object)serviceSubscriptionsPage_obj13_Bindings;
			serviceSubscriptionsPage_obj13_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += serviceSubscriptionsPage_obj13_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)serviceSubscriptionsPage_obj13_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)serviceSubscriptionsPage_obj13_Bindings);
			break;
		}
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void __ctor_b__4_0(object _, RoutedEventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__4_0_d __ctor_b__4_0_d = default(___ctor_b__4_0_d);
		__ctor_b__4_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__4_0_d.__4__this = this;
		__ctor_b__4_0_d.__1__state = -1;
		__ctor_b__4_0_d.__t__builder.Start<___ctor_b__4_0_d>(ref __ctor_b__4_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _LoadAsync_b__5_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__LoadAsync_b__5_0_d _LoadAsync_b__5_0_d = default(__LoadAsync_b__5_0_d);
		_LoadAsync_b__5_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_LoadAsync_b__5_0_d.__4__this = this;
		_LoadAsync_b__5_0_d.__1__state = -1;
		_LoadAsync_b__5_0_d.__t__builder.Start<__LoadAsync_b__5_0_d>(ref _LoadAsync_b__5_0_d);
		return _LoadAsync_b__5_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _LoadAsync_b__5_1(ixkKI2fw3cF6iNilYo5r item)
	{
		return item.Code == _selectedServiceCode;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

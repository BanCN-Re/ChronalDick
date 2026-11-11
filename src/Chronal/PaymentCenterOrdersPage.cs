using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Shell;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using Td5iBpfRoJqh3680WjA5;
using WinRT;
using WinRT.ChronalVtableClasses;
using e38ZmBf51OoNmYc9Uj20;
using ib6glgfRIbvKiV2rgUHE;
using jyCuL7fR7H8kkWsM6e4q;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PaymentCenterOrdersPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPaymentCenterOrdersPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPaymentCenterOrdersPage_BindingsScopeConnector
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class PaymentCenterOrdersPage_obj7_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IPaymentCenterOrdersPage_Bindings
	{
		private BARafCfRr4T7Xe7KDtJF dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj7;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private Button obj14;

		private Button obj15;

		[MethodImpl((MethodImplOptions)8)]
		public PaymentCenterOrdersPage_obj7_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			switch (connectionId)
			{
			case 7:
				obj7 = new WeakReference((object)CastExtensions.As<Grid>(target));
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
				obj11 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<Button>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<Button>(target);
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
			object target = obj7.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<BARafCfRr4T7Xe7KDtJF>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<BARafCfRr4T7Xe7KDtJF>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(BARafCfRr4T7Xe7KDtJF obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Purpose(obj.Purpose, phase);
				Update_MerchantOrderNo(obj.MerchantOrderNo, phase);
				Update_AmountText(obj.AmountText, phase);
				Update_Method(obj.Method, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_ExpiresAt(obj.ExpiresAt, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Purpose(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MerchantOrderNo(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj14, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AmountText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Method(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ExpiresAt(DateTimeOffset? obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, ((object)obj/*cast due to .constrained prefix*/).ToString(), null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__3_0_d_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

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
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = paymentCenterOrdersPage.MovePageAsync(-1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__3_0_d_1>(ref _u__, ref this);
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
	private struct ___ctor_b__3_1_d_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

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
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = paymentCenterOrdersPage.MovePageAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__3_1_d_1>(ref _u__, ref this);
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

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __QueryButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass10_0_1 __4__this;

			private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_0027: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass10_0_1 _c__DisplayClass10_0_ = __4__this;
				try
				{
					TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.iaZ8foVl5m(_c__DisplayClass10_0_.orderNo).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, __QueryButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
						num = (__1__state = -1);
					}
					BARafCfRr4T7Xe7KDtJF result = _u__.GetResult();
					_c__DisplayClass10_0_.__4__this.ReplaceOrder(result);
					_c__DisplayClass10_0_.__4__this.ShowDetail(result);
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

		public string orderNo;

		public PaymentCenterOrdersPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _QueryButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__QueryButton_Click_b__0_d _QueryButton_Click_b__0_d = default(__QueryButton_Click_b__0_d);
			_QueryButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_QueryButton_Click_b__0_d.__4__this = this;
			_QueryButton_Click_b__0_d.__1__state = -1;
			_QueryButton_Click_b__0_d.__t__builder.Start<__QueryButton_Click_b__0_d>(ref _QueryButton_Click_b__0_d);
			return _QueryButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass11_0_2
	{
		[StructLayout((LayoutKind)3)]
		private struct __RefundButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass11_0_2 __4__this;

			private TaskAwaiter<JUZ1WufRA6BDOrUUSfwK> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_008f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0059: Unknown result type (might be due to invalid IL or missing references)
				//IL_005e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				//IL_0076: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass11_0_2 _c__DisplayClass11_0_ = __4__this;
				try
				{
					TaskAwaiter<JUZ1WufRA6BDOrUUSfwK> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.p4f89ubrdl(_c__DisplayClass11_0_.order.MerchantOrderNo, (int)Math.Round(_c__DisplayClass11_0_.amount * 100m, (MidpointRounding)1), _c__DisplayClass11_0_.reasonBox.Text.Trim()).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<JUZ1WufRA6BDOrUUSfwK>, __RefundButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<JUZ1WufRA6BDOrUUSfwK>);
						num = (__1__state = -1);
					}
					JUZ1WufRA6BDOrUUSfwK result = _u__.GetResult();
					_c__DisplayClass11_0_.__4__this.DetailText.Text = $"退款申请已创建：{result.MerchantRefundNo} · {RefundStatusText(result.Status)}。支付中心审核后才会提交资金退款。";
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

		public BARafCfRr4T7Xe7KDtJF order;

		public decimal amount;

		public TextBox reasonBox;

		public PaymentCenterOrdersPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass11_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _RefundButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__RefundButton_Click_b__0_d _RefundButton_Click_b__0_d = default(__RefundButton_Click_b__0_d);
			_RefundButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_RefundButton_Click_b__0_d.__4__this = this;
			_RefundButton_Click_b__0_d.__1__state = -1;
			_RefundButton_Click_b__0_d.__t__builder.Start<__RefundButton_Click_b__0_d>(ref _RefundButton_Click_b__0_d);
			return _RefundButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _MovePageAsync_d__8_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		public int delta;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00a6;
				}
				int num2 = paymentCenterOrdersPage._page + delta;
				if (num2 >= 1 && num2 <= paymentCenterOrdersPage._totalPages)
				{
					paymentCenterOrdersPage._page = num2;
					_u__ = AppShell.RunAsync(paymentCenterOrdersPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MovePageAsync_d__8_1>(ref _u__, ref this);
						return;
					}
					goto IL_00a6;
				}
				goto end_IL_0011;
				IL_00a6:
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
	private struct _OnNavigatedTo_d__4_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		public NavigationEventArgs e;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					paymentCenterOrdersPage.__n__0(e);
					_u__ = AppShell.RunAsync(paymentCenterOrdersPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__4_1>(ref _u__, ref this);
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
	private struct _QueryButton_Click_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		public object sender;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00ce;
				}
				__c__DisplayClass10_0_1 _c__DisplayClass10_0_ = (__c__DisplayClass10_0_1)new __c__DisplayClass10_0_1
				{
					__4__this = __4__this
				};
				object obj = sender;
				object obj2 = ((obj is Button) ? obj : null);
				object obj3 = ((obj2 != null) ? ((FrameworkElement)obj2).Tag : null);
				_c__DisplayClass10_0_.orderNo = obj3 as string;
				if (_c__DisplayClass10_0_.orderNo != null && !string.IsNullOrWhiteSpace(_c__DisplayClass10_0_.orderNo))
				{
					_u__ = AppShell.RunAsync(_c__DisplayClass10_0_._QueryButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _QueryButton_Click_d__10>(ref _u__, ref this);
						return;
					}
					goto IL_00ce;
				}
				goto end_IL_000a;
				IL_00ce:
				_u__.GetResult();
				end_IL_000a:;
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
	private struct _RefreshAsync_d__7_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		private TaskAwaiter<GPqFWcfRmA29id0OGRVc> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter<GPqFWcfRmA29id0OGRVc> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.M0u8jGlPjg(paymentCenterOrdersPage._page, 20).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GPqFWcfRmA29id0OGRVc>, _RefreshAsync_d__7_1>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<GPqFWcfRmA29id0OGRVc>);
					num = (__1__state = -1);
				}
				GPqFWcfRmA29id0OGRVc result = _u__.GetResult();
				UiHelpers.Replace(paymentCenterOrdersPage._orders, (global::System.Collections.Generic.IEnumerable<BARafCfRr4T7Xe7KDtJF>)result.Orders);
				paymentCenterOrdersPage._page = ((p9WVlJf5a812Tn4S3TgP)result).Page;
				paymentCenterOrdersPage._totalPages = Math.Max(1, ((p9WVlJf5a812Tn4S3TgP)result).TotalPages);
				paymentCenterOrdersPage.OrderPager.SetState(paymentCenterOrdersPage._page, paymentCenterOrdersPage._totalPages, ((p9WVlJf5a812Tn4S3TgP)result).Total);
				((UIElement)paymentCenterOrdersPage.EmptyStatePanel).Visibility = (((((Collection<BARafCfRr4T7Xe7KDtJF>)(object)paymentCenterOrdersPage._orders).Count != 0)) ? Visibility.Visible : Visibility.Collapsed);
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
	private struct _RefreshButton_Click_d__6_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync(paymentCenterOrdersPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__6_1>(ref _u__, ref this);
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
	private struct _RefundButton_Click_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterOrdersPage __4__this;

		public object sender;

		private __c__DisplayClass11_0_2 __8__1;

		private TextBox _amountBox_5__2;

		private TaskAwaiter<ContentDialogResult> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0280: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Invalid comparison between Unknown and I4
			//IL_0364: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Expected O, but got Unknown
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0172: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Expected O, but got Unknown
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterOrdersPage paymentCenterOrdersPage = __4__this;
			try
			{
				TaskAwaiter<ContentDialogResult> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<ContentDialogResult>);
					num = (__1__state = -1);
					goto IL_027e;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0380;
				}
				__8__1 = (__c__DisplayClass11_0_2)new __c__DisplayClass11_0_2();
				__8__1.__4__this = __4__this;
				object obj = sender;
				object obj2 = ((obj is Button) ? obj : null);
				if (((obj2 != null) ? ((FrameworkElement)obj2).Tag : null) is string text && !string.IsNullOrWhiteSpace(text))
				{
					__8__1.order = paymentCenterOrdersPage.FindOrder(text);
					if (__8__1.order != null && !(__8__1.order.EffectiveStatus != "SUCCEEDED"))
					{
						_amountBox_5__2 = new TextBox
						{
							Header = "退款金额（元）",
							Text = (__8__1.order.AmountCents / 100m).ToString("0.00", (IFormatProvider)(object)CultureInfo.InvariantCulture)
						};
						__8__1.reasonBox = new TextBox
						{
							Header = "退款原因",
							Text = "用户申请退款",
							AcceptsReturn = true,
							TextWrapping = (TextWrapping)2,
							MaxLength = 256
						};
						StackPanel val = new StackPanel
						{
							Spacing = 12.0
						};
						((Panel)val).Children.Add((UIElement)new TextBlock
						{
							Text = "订单：" + __8__1.order.MerchantOrderNo + "\n原支付金额：" + __8__1.order.AmountText,
							TextWrapping = (TextWrapping)2
						});
						((Panel)val).Children.Add((UIElement)(object)_amountBox_5__2);
						((Panel)val).Children.Add((UIElement)(object)__8__1.reasonBox);
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(new ContentDialog
						{
							XamlRoot = ((UIElement)paymentCenterOrdersPage).XamlRoot,
							RequestedTheme = AppShell.RequestedTheme,
							Title = "申请支付中心退款",
							Content = val,
							PrimaryButtonText = "提交申请",
							CloseButtonText = "取消",
							DefaultButton = (ContentDialogButton)3
						}.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _RefundButton_Click_d__11>(ref _u__, ref this);
							return;
						}
						goto IL_027e;
					}
					AppShell.Warning("只有支付成功的订单可以申请退款");
				}
				goto end_IL_0011;
				IL_027e:
				if ((int)_u__.GetResult() == 1)
				{
					if (decimal.TryParse(_amountBox_5__2.Text, (NumberStyles)111, (IFormatProvider)(object)CultureInfo.InvariantCulture, out __8__1.amount) && !(__8__1.amount <= 0m) && !(__8__1.amount * 100m > __8__1.order.AmountCents))
					{
						_u__2 = AppShell.RunAsync(__8__1._RefundButton_Click_b__0).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefundButton_Click_d__11>(ref _u__2, ref this);
							return;
						}
						goto IL_0380;
					}
					AppShell.Warning("退款金额无效或超过原支付金额");
				}
				goto end_IL_0011;
				IL_0380:
				_u__2.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				_amountBox_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
			_amountBox_5__2 = null;
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

	private readonly ObservableCollection<BARafCfRr4T7Xe7KDtJF> _orders;

	private int _page;

	private int _totalPages;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView OrderList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyStatePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PagerBar OrderPager;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock DetailText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPaymentCenterOrdersPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public PaymentCenterOrdersPage()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		_orders = new ObservableCollection<BARafCfRr4T7Xe7KDtJF>();
		_page = 1;
		_totalPages = 1;
		InitializeComponent();
		((ItemsControl)OrderList).ItemsSource = _orders;
		OrderPager.PreviousRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__3_0_d_1 __ctor_b__3_0_d_ = default(___ctor_b__3_0_d_1);
			__ctor_b__3_0_d_.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__3_0_d_.__4__this = this;
			__ctor_b__3_0_d_.__1__state = -1;
			__ctor_b__3_0_d_.__t__builder.Start<___ctor_b__3_0_d_1>(ref __ctor_b__3_0_d_);
		});
		OrderPager.NextRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__3_1_d_1 __ctor_b__3_1_d_ = default(___ctor_b__3_1_d_1);
			__ctor_b__3_1_d_.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__3_1_d_.__4__this = this;
			__ctor_b__3_1_d_.__1__state = -1;
			__ctor_b__3_1_d_.__t__builder.Start<___ctor_b__3_1_d_1>(ref __ctor_b__3_1_d_);
		});
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__4_1 onNavigatedTo_d__4_ = default(_OnNavigatedTo_d__4_1);
		onNavigatedTo_d__4_.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__4_.__4__this = this;
		onNavigatedTo_d__4_.e = e;
		onNavigatedTo_d__4_.__1__state = -1;
		onNavigatedTo_d__4_.__t__builder.Start<_OnNavigatedTo_d__4_1>(ref onNavigatedTo_d__4_);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		((Collection<BARafCfRr4T7Xe7KDtJF>)(object)_orders).Clear();
		DetailText.Text = string.Empty;
		((UIElement)EmptyStatePanel).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__6_1 refreshButton_Click_d__6_ = default(_RefreshButton_Click_d__6_1);
		refreshButton_Click_d__6_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__6_.__4__this = this;
		refreshButton_Click_d__6_.__1__state = -1;
		refreshButton_Click_d__6_.__t__builder.Start<_RefreshButton_Click_d__6_1>(ref refreshButton_Click_d__6_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAsync_d__7_1 refreshAsync_d__7_ = default(_RefreshAsync_d__7_1);
		refreshAsync_d__7_.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAsync_d__7_.__4__this = this;
		refreshAsync_d__7_.__1__state = -1;
		refreshAsync_d__7_.__t__builder.Start<_RefreshAsync_d__7_1>(ref refreshAsync_d__7_);
		return refreshAsync_d__7_.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MovePageAsync(int delta)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MovePageAsync_d__8_1 movePageAsync_d__8_ = default(_MovePageAsync_d__8_1);
		movePageAsync_d__8_.__t__builder = AsyncTaskMethodBuilder.Create();
		movePageAsync_d__8_.__4__this = this;
		movePageAsync_d__8_.delta = delta;
		movePageAsync_d__8_.__1__state = -1;
		movePageAsync_d__8_.__t__builder.Start<_MovePageAsync_d__8_1>(ref movePageAsync_d__8_);
		return movePageAsync_d__8_.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		object selectedItem = ((Selector)OrderList).SelectedItem;
		BARafCfRr4T7Xe7KDtJF val = (BARafCfRr4T7Xe7KDtJF)((selectedItem is BARafCfRr4T7Xe7KDtJF) ? selectedItem : null);
		if (val != null)
		{
			ShowDetail(val);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void QueryButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_QueryButton_Click_d__10 queryButton_Click_d__ = default(_QueryButton_Click_d__10);
		queryButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		queryButton_Click_d__.__4__this = this;
		queryButton_Click_d__.sender = sender;
		queryButton_Click_d__.__1__state = -1;
		queryButton_Click_d__.__t__builder.Start<_QueryButton_Click_d__10>(ref queryButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefundButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefundButton_Click_d__11 refundButton_Click_d__ = default(_RefundButton_Click_d__11);
		refundButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refundButton_Click_d__.__4__this = this;
		refundButton_Click_d__.sender = sender;
		refundButton_Click_d__.__1__state = -1;
		refundButton_Click_d__.__t__builder.Start<_RefundButton_Click_d__11>(ref refundButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private BARafCfRr4T7Xe7KDtJF? FindOrder(string orderNo)
	{
		global::System.Collections.Generic.IEnumerator<BARafCfRr4T7Xe7KDtJF> enumerator = ((Collection<BARafCfRr4T7Xe7KDtJF>)(object)_orders).GetEnumerator();
		try
		{
			while (((global::System.Collections.IEnumerator)enumerator).MoveNext())
			{
				BARafCfRr4T7Xe7KDtJF current = enumerator.Current;
				if (string.Equals(current.MerchantOrderNo, orderNo, (StringComparison)4))
				{
					return current;
				}
			}
		}
		finally
		{
			((global::System.IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ReplaceOrder(BARafCfRr4T7Xe7KDtJF updated)
	{
		BARafCfRr4T7Xe7KDtJF val = FindOrder(updated.MerchantOrderNo);
		if (val != null)
		{
			int num = ((Collection<BARafCfRr4T7Xe7KDtJF>)(object)_orders).IndexOf(val);
			if (num >= 0)
			{
				((Collection<BARafCfRr4T7Xe7KDtJF>)(object)_orders)[num] = updated;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowDetail(BARafCfRr4T7Xe7KDtJF order)
	{
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		TextBlock detailText = DetailText;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(36, 6);
		defaultInterpolatedStringHandler.AppendLiteral("订单号：");
		defaultInterpolatedStringHandler.AppendFormatted(order.MerchantOrderNo);
		defaultInterpolatedStringHandler.AppendLiteral(" · 中心订单：");
		defaultInterpolatedStringHandler.AppendFormatted(order.CenterOrderId);
		defaultInterpolatedStringHandler.AppendLiteral("\n状态：");
		defaultInterpolatedStringHandler.AppendFormatted(order.StatusText);
		defaultInterpolatedStringHandler.AppendLiteral(" · 履约：");
		defaultInterpolatedStringHandler.AppendFormatted(order.FulfillmentStatus);
		defaultInterpolatedStringHandler.AppendLiteral("\n支付时间：");
		DateTimeOffset? paidAt = order.PaidAt;
		object obj;
		DateTimeOffset val;
		if (!paidAt.HasValue)
		{
			obj = null;
		}
		else
		{
			val = paidAt.GetValueOrDefault();
			val = val.ToLocalTime();
			obj = val.ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
		if (obj == null)
		{
			obj = "未支付";
		}
		defaultInterpolatedStringHandler.AppendFormatted((string)obj);
		defaultInterpolatedStringHandler.AppendLiteral(" · 查询时间：");
		paidAt = order.QueryAfter;
		object obj2;
		if (!paidAt.HasValue)
		{
			obj2 = null;
		}
		else
		{
			val = paidAt.GetValueOrDefault();
			val = val.ToLocalTime();
			obj2 = val.ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
		if (obj2 == null)
		{
			obj2 = "可立即查询";
		}
		defaultInterpolatedStringHandler.AppendFormatted((string)obj2);
		detailText.Text = defaultInterpolatedStringHandler.ToStringAndClear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string RefundStatusText(string status)
	{
		if (!(status == "SUCCEEDED"))
		{
			if (!(status == "FAILED"))
			{
				if (!(status == "UNKNOWN"))
				{
					if (status == "REVIEW")
					{
						return "待审核";
					}
					return "退款处理中";
				}
				return "退款待核验";
			}
			return "退款失败";
		}
		return "退款成功";
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
			Uri val = new Uri("ms-appx:///Views/Pages/PaymentCenterOrdersPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			OrderList = CastExtensions.As<ListView>(target);
			((Selector)OrderList).SelectionChanged += new SelectionChangedEventHandler(OrderList_SelectionChanged);
			break;
		case 3:
			EmptyStatePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			OrderPager = CastExtensions.As<PagerBar>(target);
			break;
		case 5:
			DetailText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(QueryButton_Click);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefundButton_Click);
			break;
		case 16:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshButton_Click);
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
		if (connectionId == 7)
		{
			Grid val = (Grid)target;
			PaymentCenterOrdersPage_obj7_Bindings paymentCenterOrdersPage_obj7_Bindings = (PaymentCenterOrdersPage_obj7_Bindings)new PaymentCenterOrdersPage_obj7_Bindings();
			result = (IComponentConnector)(object)paymentCenterOrdersPage_obj7_Bindings;
			paymentCenterOrdersPage_obj7_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += paymentCenterOrdersPage_obj7_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)paymentCenterOrdersPage_obj7_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)paymentCenterOrdersPage_obj7_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__3_0(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__3_0_d_1 __ctor_b__3_0_d_ = default(___ctor_b__3_0_d_1);
		__ctor_b__3_0_d_.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__3_0_d_.__4__this = this;
		__ctor_b__3_0_d_.__1__state = -1;
		__ctor_b__3_0_d_.__t__builder.Start<___ctor_b__3_0_d_1>(ref __ctor_b__3_0_d_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__3_1(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__3_1_d_1 __ctor_b__3_1_d_ = default(___ctor_b__3_1_d_1);
		__ctor_b__3_1_d_.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__3_1_d_.__4__this = this;
		__ctor_b__3_1_d_.__1__state = -1;
		__ctor_b__3_1_d_.__t__builder.Start<___ctor_b__3_1_d_1>(ref __ctor_b__3_1_d_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__3_2(object _, RoutedEventArgs _2)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerHidden]
	[CompilerGenerated]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

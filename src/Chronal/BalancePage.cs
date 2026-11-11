using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using BNyHcUfRdE6bqImEQbYu;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using MnCNHgfwhm1BlAufHdT1;
using OQZwpbfRHr9DWudhZEpR;
using VFQxICfth84Lkoc3ch2l;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using nowIRbfRRJ79HCUCsbjS;
using qS8vkpL43FlTMgcj0rgs;
using vAJCQ5fR5HjOMuQ8HHCp;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class BalancePage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBalancePage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBalancePage_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BalancePage_obj20_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBalancePage_Bindings
	{
		private t38PEtfRlRJjDwb2rSSY dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj20;

		private TextBlock obj21;

		private TextBlock obj22;

		private TextBlock obj23;

		[MethodImpl((MethodImplOptions)8)]
		public BalancePage_obj20_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			switch (connectionId)
			{
			case 20:
				obj20 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 21:
				obj21 = CastExtensions.As<TextBlock>(target);
				break;
			case 22:
				obj22 = CastExtensions.As<TextBlock>(target);
				break;
			case 23:
				obj23 = CastExtensions.As<TextBlock>(target);
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
			object target = obj20.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<t38PEtfRlRJjDwb2rSSY>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<t38PEtfRlRJjDwb2rSSY>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(t38PEtfRlRJjDwb2rSSY obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_DisplayName(obj.DisplayName, phase);
				Update_FeeText(obj.FeeText, phase);
				Update_RateText(obj.RateText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DisplayName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj21, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_FeeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj22, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RateText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj23, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __OnNavigatedTo_b__3_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalancePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BalancePage balancePage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					_u__ = balancePage.RefreshBalanceAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__3_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_007a;
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007a;
				case 1:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d8;
				case 2:
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_00d8:
					_u__.GetResult();
					_u__ = balancePage.RecentOrdersPanel.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__3_0_d>(ref _u__, ref this);
						return;
					}
					break;
					IL_007a:
					_u__.GetResult();
					_u__ = balancePage.RefreshPaymentPageAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__3_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_00d8;
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
	private sealed class __c__DisplayClass14_0_4
	{
		[StructLayout((LayoutKind)3)]
		private struct __CreatePaymentOrderButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass14_0_4 __4__this;

			private int __7__wrap1;

			private UfjqWXfw4LbmaQBvftfE _ex_5__3;

			private TaskAwaiter<aS44CUfR6tdgNLbdQbUH> __u__1;

			private TaskAwaiter<bool> __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_010f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0119: Expected O, but got Unknown
				//IL_0189: Unknown result type (might be due to invalid IL or missing references)
				//IL_018e: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_009c: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0064: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass14_0_4 _c__DisplayClass14_0_ = __4__this;
				try
				{
					TaskAwaiter<bool> _u__ = default;
					int num2 = default(int);
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							goto IL_01dd;
						}
						num2 = checked((int)Math.Round(_c__DisplayClass14_0_.__4__this.RechargeAmountBox.Value * 100.0, (MidpointRounding)1));
						__7__wrap1 = 0;
					}
					try
					{
						TaskAwaiter<aS44CUfR6tdgNLbdQbUH> _u__2 = default;
						if (num != 0)
						{
							_u__2 = AppShell.Api.ncb0ukvFAR(num2, _c__DisplayClass14_0_.method.Code).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aS44CUfR6tdgNLbdQbUH>, __CreatePaymentOrderButton_Click_b__0_d>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<aS44CUfR6tdgNLbdQbUH>);
							num = (__1__state = -1);
						}
						aS44CUfR6tdgNLbdQbUH result = _u__2.GetResult();
						AppShell.Navigate(typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage), (object?)new PaymentOrderNavigationRequest(result.OrderNo, OpenPaymentPage: false, ""));
						AppShell.Success("支付订单已创建");
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is UfjqWXfw4LbmaQBvftfE) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
						if (obj2 == null)
						{
							result2 = 0;
						}
						else
						{
							UfjqWXfw4LbmaQBvftfE __exLocal0 = (UfjqWXfw4LbmaQBvftfE)obj2;
							result2 = ((__exLocal0.Code == "REFUND_HOLD_ACTIVE") ? 1 : 0);
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						__7__wrap1 = 1;
					}
					int num3 = __7__wrap1;
					if (num3 == 1)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)_ex_5__3, "ui-exception", "CreatePaymentOrderButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\BalancePage.xaml.cs", 143);
						_u__ = AppShell.ConfirmAsync("暂时无法充值", ((global::System.Exception)(object)_ex_5__3).Message, "我知道了").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __CreatePaymentOrderButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						goto IL_01dd;
					}
					goto IL_01e5;
					IL_01dd:
					_u__.GetResult();
					goto IL_01e5;
					IL_01e5:
					_ex_5__3 = null;
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

		public BalancePage __4__this;

		public t38PEtfRlRJjDwb2rSSY method;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _CreatePaymentOrderButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__CreatePaymentOrderButton_Click_b__0_d _CreatePaymentOrderButton_Click_b__0_d = default(__CreatePaymentOrderButton_Click_b__0_d);
			_CreatePaymentOrderButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_CreatePaymentOrderButton_Click_b__0_d.__4__this = this;
			_CreatePaymentOrderButton_Click_b__0_d.__1__state = -1;
			_CreatePaymentOrderButton_Click_b__0_d.__t__builder.Start<__CreatePaymentOrderButton_Click_b__0_d>(ref _CreatePaymentOrderButton_Click_b__0_d);
			return _CreatePaymentOrderButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreatePaymentOrderButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalancePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BalancePage balancePage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d5;
				}
				__c__DisplayClass14_0_4 _c__DisplayClass14_0_ = (__c__DisplayClass14_0_4)new __c__DisplayClass14_0_4
				{
					__4__this = __4__this
				};
				object selectedItem = ((Selector)balancePage.PaymentMethodList).SelectedItem;
				_c__DisplayClass14_0_.method = (t38PEtfRlRJjDwb2rSSY)((selectedItem is t38PEtfRlRJjDwb2rSSY) ? selectedItem : null);
				if (_c__DisplayClass14_0_.method != null && !double.IsNaN(balancePage.RechargeAmountBox.Value))
				{
					_u__ = AppShell.RunAsync(_c__DisplayClass14_0_._CreatePaymentOrderButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CreatePaymentOrderButton_Click_d__14>(ref _u__, ref this);
						return;
					}
					goto IL_00d5;
				}
				AppShell.Warning("请选择支付方式并输入充值金额");
				goto end_IL_0011;
				IL_00d5:
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
	private struct _OnNavigatedTo_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalancePage __4__this;

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
			BalancePage __8_locals2 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					__8_locals2.__n__0(e);
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__OnNavigatedTo_b__3_0_d _OnNavigatedTo_b__3_0_d = default(__OnNavigatedTo_b__3_0_d);
						_OnNavigatedTo_b__3_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_OnNavigatedTo_b__3_0_d.__4__this = __8_locals2;
						_OnNavigatedTo_b__3_0_d.__1__state = -1;
						_OnNavigatedTo_b__3_0_d.__t__builder.Start<__OnNavigatedTo_b__3_0_d>(ref _OnNavigatedTo_b__3_0_d);
						return _OnNavigatedTo_b__3_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__3>(ref _u__, ref this);
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
	private struct _RefreshBalanceAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalancePage __4__this;

		private TaskAwaiter<yg9HVZft43Yd2k4O7qX5> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BalancePage balancePage = __4__this;
			try
			{
				TaskAwaiter<yg9HVZft43Yd2k4O7qX5> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.TPbcqySjB7().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<yg9HVZft43Yd2k4O7qX5>, _RefreshBalanceAsync_d__8>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<yg9HVZft43Yd2k4O7qX5>);
					num = (__1__state = -1);
				}
				yg9HVZft43Yd2k4O7qX5 result = _u__.GetResult();
				Motion.CountTo(balancePage.BalancePageAmountText, result.User.Balance);
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
	private struct _RefreshForShellAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalancePage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			BalancePage balancePage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					_u__ = balancePage.RefreshBalanceAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshForShellAsync_d__7>(ref _u__, ref this);
						return;
					}
					goto IL_007a;
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007a;
				case 1:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d8;
				case 2:
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_00d8:
					_u__.GetResult();
					_u__ = balancePage.RecentOrdersPanel.RefreshAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshForShellAsync_d__7>(ref _u__, ref this);
						return;
					}
					break;
					IL_007a:
					_u__.GetResult();
					_u__ = balancePage.RefreshPaymentPageAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshForShellAsync_d__7>(ref _u__, ref this);
						return;
					}
					goto IL_00d8;
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
	private struct _RefreshPaymentPageAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalancePage __4__this;

		private TaskAwaiter<KNGB7hfROy3UOcBXs30t> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			int num = __1__state;
			BalancePage balancePage = __4__this;
			try
			{
				TaskAwaiter<KNGB7hfROy3UOcBXs30t> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.Th20pQr1j5().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<KNGB7hfROy3UOcBXs30t>, _RefreshPaymentPageAsync_d__9>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<KNGB7hfROy3UOcBXs30t>);
					num = (__1__state = -1);
				}
				KNGB7hfROy3UOcBXs30t result = _u__.GetResult();
				balancePage._paymentConfig = result;
				balancePage.PaymentBannerCarousel.SetBanners((global::System.Collections.Generic.IEnumerable<eBH6YIfRKKYmAtWXaPLA>?)balancePage._paymentConfig.Banners);
				UiHelpers.Replace(balancePage._paymentMethods, (global::System.Collections.Generic.IEnumerable<t38PEtfRlRJjDwb2rSSY>)balancePage._paymentConfig.Methods);
				((Selector)balancePage.PaymentMethodList).SelectedIndex = ((((Collection<t38PEtfRlRJjDwb2rSSY>)(object)balancePage._paymentMethods).Count <= 0) ? (-1) : 0);
				((ItemsControl)balancePage.RechargePresetCombo).Items.Clear();
				var enumerator = balancePage._paymentConfig.PresetAmountsCents.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						int current = enumerator.Current;
						((ItemsControl)balancePage.RechargePresetCombo).Items.Add((object)new ComboBoxItem
						{
							Content = $"¥ {current / 100m:0.00}",
							Tag = current
						});
					}
				}
				finally
				{
					if (num < 0)
					{
						((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
					}
				}
				if (((ItemsControl)balancePage.RechargePresetCombo).Items.Count > 0)
				{
					((Selector)balancePage.RechargePresetCombo).SelectedIndex = 0;
				}
				balancePage.RechargeAmountBox.Minimum = (double)balancePage._paymentConfig.MinAmountCents / 100.0;
				balancePage.RechargeAmountBox.Maximum = (double)balancePage._paymentConfig.MaxAmountCents / 100.0;
				((Control)balancePage.RechargeAmountBox).IsEnabled = balancePage._paymentConfig.AllowCustomAmount;
				((Control)balancePage.CreatePaymentOrderButton).IsEnabled = balancePage._paymentConfig.Enabled && ((Collection<t38PEtfRlRJjDwb2rSSY>)(object)balancePage._paymentMethods).Count > 0;
				balancePage.UpdateRechargeExpectedText();
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

	private readonly ObservableCollection<t38PEtfRlRJjDwb2rSSY> _paymentMethods;

	private KNGB7hfROy3UOcBXs30t? _paymentConfig;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PaymentBannerCarousel PaymentBannerCarousel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private RecentPaymentOrdersPanel RecentOrdersPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox RechargePresetCombo;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private NumberBox RechargeAmountBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CreatePaymentOrderButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RechargeExpectedText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView PaymentMethodList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock BalancePageAmountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBalancePage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public BalancePage()
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		_paymentMethods = new ObservableCollection<t38PEtfRlRJjDwb2rSSY>();
		InitializeComponent();
		((ItemsControl)PaymentMethodList).ItemsSource = _paymentMethods;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__3 onNavigatedTo_d__ = default(_OnNavigatedTo_d__3);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__3>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		((Collection<t38PEtfRlRJjDwb2rSSY>)(object)_paymentMethods).Clear();
		_paymentConfig = null;
		PaymentBannerCarousel.SetBanners(global::System.Array.Empty<eBH6YIfRKKYmAtWXaPLA>());
		RecentOrdersPanel.Clear();
		Motion.CountTo(BalancePageAmountText, 0m, "¥ ", "0.00", animate: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task RefreshForShellAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshForShellAsync_d__7 refreshForShellAsync_d__ = default(_RefreshForShellAsync_d__7);
		refreshForShellAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshForShellAsync_d__.__4__this = this;
		refreshForShellAsync_d__.__1__state = -1;
		refreshForShellAsync_d__.__t__builder.Start<_RefreshForShellAsync_d__7>(ref refreshForShellAsync_d__);
		return refreshForShellAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshBalanceAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshBalanceAsync_d__8 refreshBalanceAsync_d__ = default(_RefreshBalanceAsync_d__8);
		refreshBalanceAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshBalanceAsync_d__.__4__this = this;
		refreshBalanceAsync_d__.__1__state = -1;
		refreshBalanceAsync_d__.__t__builder.Start<_RefreshBalanceAsync_d__8>(ref refreshBalanceAsync_d__);
		return refreshBalanceAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshPaymentPageAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshPaymentPageAsync_d__9 refreshPaymentPageAsync_d__ = default(_RefreshPaymentPageAsync_d__9);
		refreshPaymentPageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshPaymentPageAsync_d__.__4__this = this;
		refreshPaymentPageAsync_d__.__1__state = -1;
		refreshPaymentPageAsync_d__.__t__builder.Start<_RefreshPaymentPageAsync_d__9>(ref refreshPaymentPageAsync_d__);
		return refreshPaymentPageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RechargePresetCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		object selectedItem = ((Selector)RechargePresetCombo).SelectedItem;
		ComboBoxItem val = (ComboBoxItem)((selectedItem is ComboBoxItem) ? selectedItem : null);
		if (val != null && ((FrameworkElement)val).Tag is int num)
		{
			RechargeAmountBox.Value = (double)num / 100.0;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PaymentMethodList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdateRechargeExpectedText();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void RechargeAmountBox_ValueChanged(NumberBox sender, NumberBoxValueChangedEventArgs args)
	{
		UpdateRechargeExpectedText();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateRechargeExpectedText()
	{
		object selectedItem = ((Selector)PaymentMethodList).SelectedItem;
		t38PEtfRlRJjDwb2rSSY val = (t38PEtfRlRJjDwb2rSSY)((selectedItem is t38PEtfRlRJjDwb2rSSY) ? selectedItem : null);
		if (val == null || double.IsNaN(RechargeAmountBox.Value))
		{
			TextBlock rechargeExpectedText = RechargeExpectedText;
			KNGB7hfROy3UOcBXs30t? paymentConfig = _paymentConfig;
			rechargeExpectedText.Text = ((paymentConfig != null && paymentConfig.Enabled) ? "请选择支付方式和金额" : "余额充值暂未开放");
			return;
		}
		decimal num = (decimal)RechargeAmountBox.Value;
		RechargeExpectedText.Text = $"1 元 = {val.BalancePerYuan:0.####} 余额，预计到账 {num * val.BalancePerYuan:0.00}";
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CreatePaymentOrderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CreatePaymentOrderButton_Click_d__14 createPaymentOrderButton_Click_d__ = default(_CreatePaymentOrderButton_Click_d__14);
		createPaymentOrderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		createPaymentOrderButton_Click_d__.__4__this = this;
		createPaymentOrderButton_Click_d__.__1__state = -1;
		createPaymentOrderButton_Click_d__.__t__builder.Start<_CreatePaymentOrderButton_Click_d__14>(ref createPaymentOrderButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/BalancePage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PaymentBannerCarousel = CastExtensions.As<PaymentBannerCarousel>(target);
			break;
		case 3:
			RecentOrdersPanel = CastExtensions.As<RecentPaymentOrdersPanel>(target);
			break;
		case 4:
			RechargePresetCombo = CastExtensions.As<ComboBox>(target);
			((Selector)RechargePresetCombo).SelectionChanged += new SelectionChangedEventHandler(RechargePresetCombo_SelectionChanged);
			break;
		case 5:
			RechargeAmountBox = CastExtensions.As<NumberBox>(target);
			RechargeAmountBox.ValueChanged += RechargeAmountBox_ValueChanged;
			break;
		case 6:
			CreatePaymentOrderButton = CastExtensions.As<Button>(target);
			((ButtonBase)CreatePaymentOrderButton).Click += new RoutedEventHandler(CreatePaymentOrderButton_Click);
			break;
		case 7:
			RechargeExpectedText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			PaymentMethodList = CastExtensions.As<ListView>(target);
			((Selector)PaymentMethodList).SelectionChanged += new SelectionChangedEventHandler(PaymentMethodList_SelectionChanged);
			break;
		case 24:
			BalancePageAmountText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 20)
		{
			Grid val = (Grid)target;
			BalancePage_obj20_Bindings balancePage_obj20_Bindings = (BalancePage_obj20_Bindings)new BalancePage_obj20_Bindings();
			result = (IComponentConnector)(object)balancePage_obj20_Bindings;
			balancePage_obj20_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += balancePage_obj20_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)balancePage_obj20_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)balancePage_obj20_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _OnNavigatedTo_b__3_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__OnNavigatedTo_b__3_0_d _OnNavigatedTo_b__3_0_d = default(__OnNavigatedTo_b__3_0_d);
		_OnNavigatedTo_b__3_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_OnNavigatedTo_b__3_0_d.__4__this = this;
		_OnNavigatedTo_b__3_0_d.__1__state = -1;
		_OnNavigatedTo_b__3_0_d.__t__builder.Start<__OnNavigatedTo_b__3_0_d>(ref _OnNavigatedTo_b__3_0_d);
		return _OnNavigatedTo_b__3_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[DebuggerHidden]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

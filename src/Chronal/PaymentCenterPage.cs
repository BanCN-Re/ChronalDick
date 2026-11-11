using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using I7Fo99fRQIQoofdH2H95;
using KIXiTCfRkrHP7oZK89E4;
using Mahiro_Account.UI;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using QRCoder;
using QnRg8tfRY6CfQ4Wt7Sc5;
using R3a9eAfRUag4BR6XfBN8;
using Td5iBpfRoJqh3680WjA5;
using VFQxICfth84Lkoc3ch2l;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Storage.Streams;
using Windows.System;
using bUfedyCg1PBqhqIkB8r;
using fP0gtffR8x6iKYFl06Cb;
using g7HcdHfRcYgKbftg2Cgq;
using lBcS2hfR4CYQ9NgTHf5h;
using qS8vkpL43FlTMgcj0rgs;
using r376pGfRWbjdLq9HFyP9;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PaymentCenterPage : Page, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __CancelPaymentCenterButton_Click_b__20_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00f9;
					}
					paymentCenterPage.StopPolling();
					_u__2 = AppShell.Api.dp08LSn5Fu(paymentCenterPage._order.MerchantOrderNo).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, __CancelPaymentCenterButton_Click_b__20_0_d>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
					num = (__1__state = -1);
				}
				BARafCfRr4T7Xe7KDtJF result = _u__2.GetResult();
				paymentCenterPage._order = result;
				_u__ = paymentCenterPage.RenderOrderAsync(paymentCenterPage._order).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __CancelPaymentCenterButton_Click_b__20_0_d>(ref _u__, ref this);
					return;
				}
				goto IL_00f9;
				IL_00f9:
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
	private struct __RefreshPaymentCenterButton_Click_b__19_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00f3;
					}
					_u__2 = AppShell.Api.iaZ8foVl5m(paymentCenterPage._order.MerchantOrderNo).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, __RefreshPaymentCenterButton_Click_b__19_0_d>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
					num = (__1__state = -1);
				}
				BARafCfRr4T7Xe7KDtJF result = _u__2.GetResult();
				paymentCenterPage._order = result;
				_u__ = paymentCenterPage.RenderOrderAsync(paymentCenterPage._order).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __RefreshPaymentCenterButton_Click_b__19_0_d>(ref _u__, ref this);
					return;
				}
				goto IL_00f3;
				IL_00f3:
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
	private sealed class __c__DisplayClass18_0_5
	{
		[StructLayout((LayoutKind)3)]
		private struct __CreatePaymentCenterOrderButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass18_0_5 __4__this;

			private TaskAwaiter __u__1;

			private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__2;

			private TaskAwaiter<bool> __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_04b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_0527: Unknown result type (might be due to invalid IL or missing references)
				//IL_052c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0534: Unknown result type (might be due to invalid IL or missing references)
				//IL_0695: Unknown result type (might be due to invalid IL or missing references)
				//IL_069a: Unknown result type (might be due to invalid IL or missing references)
				//IL_06a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
				//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_050c: Unknown result type (might be due to invalid IL or missing references)
				//IL_050e: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0141: Unknown result type (might be due to invalid IL or missing references)
				//IL_0198: Unknown result type (might be due to invalid IL or missing references)
				//IL_017d: Unknown result type (might be due to invalid IL or missing references)
				//IL_065d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0662: Unknown result type (might be due to invalid IL or missing references)
				//IL_067a: Unknown result type (might be due to invalid IL or missing references)
				//IL_067c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0222: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_0271: Unknown result type (might be due to invalid IL or missing references)
				//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_02be: Unknown result type (might be due to invalid IL or missing references)
				//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
				//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
				//IL_0305: Unknown result type (might be due to invalid IL or missing references)
				//IL_0311: Unknown result type (might be due to invalid IL or missing references)
				//IL_031a: Expected O, but got Unknown
				//IL_046f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0474: Unknown result type (might be due to invalid IL or missing references)
				//IL_048c: Unknown result type (might be due to invalid IL or missing references)
				//IL_048e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0433: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass18_0_5 _c__DisplayClass18_0_ = __4__this;
				try
				{
					TaskAwaiter _u__2 = default;
					TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__3 = default;
					TaskAwaiter<bool> _u__ = default;
					aIFZ93fRD8ZaK9DQ5OOq val2;
					int amountCents;
					tNdblpfRSjVa21oAY2qH val3;
					T9NmGVfR07AvCBhE2MjK? draft = default;
					T9NmGVfR07AvCBhE2MjK? draft2;
					T9NmGVfR07AvCBhE2MjK? draft3;
					T9NmGVfR07AvCBhE2MjK? draft4;
					T9NmGVfR07AvCBhE2MjK? draft5;
					T9NmGVfR07AvCBhE2MjK? draft6;
					T9NmGVfR07AvCBhE2MjK? draft7;
					T9NmGVfR07AvCBhE2MjK? draft8;
					T9NmGVfR07AvCBhE2MjK? draft9;
					tNdblpfRSjVa21oAY2qH val4;
					T9NmGVfR07AvCBhE2MjK? draft10;
					string effectiveStatus;
					BARafCfRr4T7Xe7KDtJF result;
					switch (num)
					{
					default:
						_u__2 = _c__DisplayClass18_0_.__4__this.LoadMethodsAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __CreatePaymentCenterOrderButton_Click_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0086;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0086;
					case 1:
						_u__3 = __u__2;
						__u__2 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
						num = (__1__state = -1);
						goto IL_04c3;
					case 2:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0543;
					case 3:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							break;
						}
						IL_0543:
						_u__2.GetResult();
						effectiveStatus = _c__DisplayClass18_0_.__4__this._order.EffectiveStatus;
						if ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false)
						{
							_c__DisplayClass18_0_.__4__this.StartPolling(_c__DisplayClass18_0_.__4__this._order.MerchantOrderNo);
						}
						if (_c__DisplayClass18_0_.__4__this._checkoutMode == "external")
						{
							Uri val = default(Uri);
							bool flag = Uri.TryCreate((!string.IsNullOrWhiteSpace(_c__DisplayClass18_0_.__4__this._order.CheckoutUrl)) ? _c__DisplayClass18_0_.__4__this._order.CheckoutUrl : _c__DisplayClass18_0_.__4__this._order.RedirectUrl, (UriKind)1, out val);
							if (flag)
							{
								effectiveStatus = val.Scheme;
								bool flag2 = ((effectiveStatus == "http" || effectiveStatus == "https") ? true : false);
								flag = flag2;
							}
							if (flag)
							{
								_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(val));
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 3);
									__u__3 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __CreatePaymentCenterOrderButton_Click_b__0_d>(ref _u__, ref this);
									return;
								}
								break;
							}
						}
						goto end_IL_0011;
						IL_0086:
						_u__2.GetResult();
						val2 = Enumerable.FirstOrDefault<aIFZ93fRD8ZaK9DQ5OOq>((global::System.Collections.Generic.IEnumerable<aIFZ93fRD8ZaK9DQ5OOq>)_c__DisplayClass18_0_.__4__this._methods, (Func<aIFZ93fRD8ZaK9DQ5OOq, bool>)_c__DisplayClass18_0_._CreatePaymentCenterOrderButton_Click_b__1);
						if (val2 == null)
						{
							throw new InvalidOperationException("该支付方式已停用或在线支付已关闭，请重新选择支付方式");
						}
						((Selector)_c__DisplayClass18_0_.__4__this.PaymentCenterMethodBox).SelectedItem = val2;
						_c__DisplayClass18_0_.__4__this.StopPolling();
						amountCents = (int)Math.Round(_c__DisplayClass18_0_.amount * 100m, (MidpointRounding)1);
						val3 = new tNdblpfRSjVa21oAY2qH();
						draft = _c__DisplayClass18_0_.__4__this._draft;
						val3.Purpose = ((draft != null) ? draft.Purpose : null) ?? "balance_recharge";
						draft2 = _c__DisplayClass18_0_.__4__this._draft;
						val3.BusinessOrderId = ((draft2 != null) ? draft2.BusinessOrderId : null) ?? $"winui-{Guid.NewGuid():N}";
						draft3 = _c__DisplayClass18_0_.__4__this._draft;
						val3.RequestNo = ((draft3 != null) ? draft3.RequestNo : null) ?? string.Empty;
						draft4 = _c__DisplayClass18_0_.__4__this._draft;
						val3.ServiceCode = ((draft4 != null) ? draft4.ServiceCode : null) ?? string.Empty;
						draft5 = _c__DisplayClass18_0_.__4__this._draft;
						val3.PlanId = ((draft5 != null) ? draft5.PlanId : ((long?)null));
						draft6 = _c__DisplayClass18_0_.__4__this._draft;
						val3.KookUserId = ((draft6 != null) ? draft6.KookUserId : null);
						draft7 = _c__DisplayClass18_0_.__4__this._draft;
						val3.ProductId = ((draft7 != null) ? draft7.ProductId : ((long?)null));
						draft8 = _c__DisplayClass18_0_.__4__this._draft;
						val3.Quantity = ((draft8 != null) ? new int?(draft8.Quantity) : ((int?)null));
						val3.MerchantOrderNo = string.Empty;
						val3.ChannelId = _c__DisplayClass18_0_.method.ChannelId;
						val3.Method = _c__DisplayClass18_0_.method.Method;
						draft9 = _c__DisplayClass18_0_.__4__this._draft;
						val3.Subject = ((draft9 != null) ? draft9.Subject : null) ?? "Chronal 余额充值";
						val3.AmountCents = amountCents;
						val3.Currency = val2.Currency;
						val3.ExpiryMinutes = 5;
						val4 = val3;
						draft10 = _c__DisplayClass18_0_.__4__this._draft;
						effectiveStatus = ((draft10 != null) ? draft10.Purpose : null);
						if ((effectiveStatus == "kook_purchase" || effectiveStatus == "kook_recharge") ? true : false)
						{
							val4.KookUserId = _c__DisplayClass18_0_.__4__this.PaymentCenterKookUserBox.Text;
							object selectedItem = ((Selector)_c__DisplayClass18_0_.__4__this.PaymentCenterKookProductBox).SelectedItem;
							object obj = ((selectedItem is WxAKn9fRycUOUMdMZHj4) ? selectedItem : null);
							val4.ProductId = ((obj != null) ? new long?(((WxAKn9fRycUOUMdMZHj4)obj).Id) : ((long?)null));
							int num2 = default(int);
							val4.Quantity = ((!int.TryParse(_c__DisplayClass18_0_.__4__this.PaymentCenterKookQuantityBox.Text, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num2)) ? 1 : Math.Clamp(num2, 1, 20));
							val4.BusinessOrderId = ((_c__DisplayClass18_0_.__4__this._draft.BusinessOrderId.Length > 0) ? _c__DisplayClass18_0_.__4__this._draft.BusinessOrderId : $"winui-kook-{Guid.NewGuid():N}");
						}
						_u__3 = AppShell.Api.JTH8byx6Iv(val4).GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, __CreatePaymentCenterOrderButton_Click_b__0_d>(ref _u__3, ref this);
							return;
						}
						goto IL_04c3;
						IL_04c3:
						result = _u__3.GetResult();
						_c__DisplayClass18_0_.__4__this._order = result;
						_u__2 = _c__DisplayClass18_0_.__4__this.RenderOrderAsync(_c__DisplayClass18_0_.__4__this._order).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 2);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __CreatePaymentCenterOrderButton_Click_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0543;
					}
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

		public PaymentCenterPage __4__this;

		public aIFZ93fRD8ZaK9DQ5OOq method;

		public decimal amount;

		public Func<aIFZ93fRD8ZaK9DQ5OOq, bool> __9__1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_5()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _CreatePaymentCenterOrderButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__CreatePaymentCenterOrderButton_Click_b__0_d _CreatePaymentCenterOrderButton_Click_b__0_d = default(__CreatePaymentCenterOrderButton_Click_b__0_d);
			_CreatePaymentCenterOrderButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_CreatePaymentCenterOrderButton_Click_b__0_d.__4__this = this;
			_CreatePaymentCenterOrderButton_Click_b__0_d.__1__state = -1;
			_CreatePaymentCenterOrderButton_Click_b__0_d.__t__builder.Start<__CreatePaymentCenterOrderButton_Click_b__0_d>(ref _CreatePaymentCenterOrderButton_Click_b__0_d);
			return _CreatePaymentCenterOrderButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _CreatePaymentCenterOrderButton_Click_b__1(aIFZ93fRD8ZaK9DQ5OOq item)
		{
			if (string.Equals(item.ChannelId, method.ChannelId, (StringComparison)4))
			{
				return string.Equals(item.Method, method.Method, (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass27_0_1
	{
		public BARafCfRr4T7Xe7KDtJF order;

		public PaymentCenterPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass27_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _PollAsync_b__0()
		{
			return __4__this.RenderOrderAsync(order);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass28_0
	{
		[StructLayout((LayoutKind)3)]
		public struct __RunOnUiAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public __c__DisplayClass28_0 __4__this;

			private TaskAwaiter __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0041: Unknown result type (might be due to invalid IL or missing references)
				//IL_0042: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass28_0 _c__DisplayClass28_ = __4__this;
				try
				{
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							_u__ = _c__DisplayClass28_.action.Invoke().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __RunOnUiAsync_b__0_d>(ref _u__, ref this);
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
						_c__DisplayClass28_.completion.TrySetResult((object)null);
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RunOnUiAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\PaymentCenterPage.xaml.cs", 342);
						_c__DisplayClass28_.completion.TrySetException(ex);
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

		public Func<global::System.Threading.Tasks.Task> action;

		public TaskCompletionSource<object?> completion;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass28_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _RunOnUiAsync_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__RunOnUiAsync_b__0_d _RunOnUiAsync_b__0_d = default(__RunOnUiAsync_b__0_d);
			_RunOnUiAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_RunOnUiAsync_b__0_d.__4__this = this;
			_RunOnUiAsync_b__0_d.__1__state = -1;
			_RunOnUiAsync_b__0_d.__t__builder.Start<__RunOnUiAsync_b__0_d>(ref _RunOnUiAsync_b__0_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass7_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __OnNavigatedTo_b__0_d_1 : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass7_0_1 __4__this;

			private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_003e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass7_0_1 _c__DisplayClass7_0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__2 = default;
					if (num != 0)
					{
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_0108;
						}
						_c__DisplayClass7_0_.__4__this.StopPolling();
						_u__2 = AppShell.Api.iaZ8foVl5m(_c__DisplayClass7_0_.merchantOrderNo).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, __OnNavigatedTo_b__0_d_1>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
						num = (__1__state = -1);
					}
					BARafCfRr4T7Xe7KDtJF result = _u__2.GetResult();
					_c__DisplayClass7_0_.__4__this._order = result;
					_u__ = _c__DisplayClass7_0_.__4__this.RenderOrderAsync(_c__DisplayClass7_0_.__4__this._order).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__0_d_1>(ref _u__, ref this);
						return;
					}
					goto IL_0108;
					IL_0108:
					_u__.GetResult();
					string effectiveStatus = _c__DisplayClass7_0_.__4__this._order.EffectiveStatus;
					if ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING" || effectiveStatus == "UNKNOWN") ? true : false)
					{
						_c__DisplayClass7_0_.__4__this.StartPolling(_c__DisplayClass7_0_.__4__this._order.MerchantOrderNo);
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

		public PaymentCenterPage __4__this;

		public string merchantOrderNo;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass7_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _OnNavigatedTo_b__1(aIFZ93fRD8ZaK9DQ5OOq item)
		{
			if (string.Equals(item.ChannelId, __4__this._draft.ChannelId, (StringComparison)4))
			{
				return string.Equals(item.Method, __4__this._draft.Method, (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _OnNavigatedTo_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__OnNavigatedTo_b__0_d_1 _OnNavigatedTo_b__0_d_ = default(__OnNavigatedTo_b__0_d_1);
			_OnNavigatedTo_b__0_d_.__t__builder = AsyncTaskMethodBuilder.Create();
			_OnNavigatedTo_b__0_d_.__4__this = this;
			_OnNavigatedTo_b__0_d_.__1__state = -1;
			_OnNavigatedTo_b__0_d_.__t__builder.Start<__OnNavigatedTo_b__0_d_1>(ref _OnNavigatedTo_b__0_d_);
			return _OnNavigatedTo_b__0_d_.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CancelPaymentCenterButton_Click_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage __8_locals3 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00d4;
				}
				bool flag = __8_locals3._order == null;
				if (!flag)
				{
					string effectiveStatus = __8_locals3._order.EffectiveStatus;
					bool flag2 = ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false);
					flag = !flag2;
				}
				if (!flag)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__CancelPaymentCenterButton_Click_b__20_0_d _CancelPaymentCenterButton_Click_b__20_0_d = default(__CancelPaymentCenterButton_Click_b__20_0_d);
						_CancelPaymentCenterButton_Click_b__20_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_CancelPaymentCenterButton_Click_b__20_0_d.__4__this = __8_locals3;
						_CancelPaymentCenterButton_Click_b__20_0_d.__1__state = -1;
						_CancelPaymentCenterButton_Click_b__20_0_d.__t__builder.Start<__CancelPaymentCenterButton_Click_b__20_0_d>(ref _CancelPaymentCenterButton_Click_b__20_0_d);
						return _CancelPaymentCenterButton_Click_b__20_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CancelPaymentCenterButton_Click_d__20>(ref _u__, ref this);
						return;
					}
					goto IL_00d4;
				}
				goto end_IL_0011;
				IL_00d4:
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
	private struct _CreatePaymentCenterOrderButton_Click_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0111;
				}
				__c__DisplayClass18_0_5 _c__DisplayClass18_0_ = (__c__DisplayClass18_0_5)new __c__DisplayClass18_0_5
				{
					__4__this = __4__this
				};
				object selectedItem = ((Selector)paymentCenterPage.PaymentCenterMethodBox).SelectedItem;
				_c__DisplayClass18_0_.method = (aIFZ93fRD8ZaK9DQ5OOq)((selectedItem is aIFZ93fRD8ZaK9DQ5OOq) ? selectedItem : null);
				if (_c__DisplayClass18_0_.method != null && decimal.TryParse(paymentCenterPage.PaymentCenterAmountBox.Text, (NumberStyles)111, (IFormatProvider)(object)CultureInfo.InvariantCulture, out _c__DisplayClass18_0_.amount) && !(_c__DisplayClass18_0_.amount <= 0m) && !(_c__DisplayClass18_0_.amount > 1000000m))
				{
					_u__ = AppShell.RunAsync(_c__DisplayClass18_0_._CreatePaymentCenterOrderButton_Click_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CreatePaymentCenterOrderButton_Click_d__18>(ref _u__, ref this);
						return;
					}
					goto IL_0111;
				}
				AppShell.Warning("请选择支付方式并输入有效金额");
				goto end_IL_0011;
				IL_0111:
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
	private struct _LoadKookContextAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<a0WrX4fRCnMwcK7lEuMx> __u__1;

		private TaskAwaiter<jeqOC5fRJRoOimNqGGEm> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage __8_locals9 = __4__this;
			try
			{
				TaskAwaiter<jeqOC5fRJRoOimNqGGEm> _u__ = default;
				TaskAwaiter<a0WrX4fRCnMwcK7lEuMx> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter<jeqOC5fRJRoOimNqGGEm>);
						num = (__1__state = -1);
						goto IL_0140;
					}
					_u__2 = AppShell.Api.UsB0zv2pvY().GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<a0WrX4fRCnMwcK7lEuMx>, _LoadKookContextAsync_d__13>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<a0WrX4fRCnMwcK7lEuMx>);
					num = (__1__state = -1);
				}
				a0WrX4fRCnMwcK7lEuMx result = _u__2.GetResult();
				TextBox paymentCenterKookUserBox = __8_locals9.PaymentCenterKookUserBox;
				ChuprbfRhs9SmiLwn7BE binding = result.Binding;
				paymentCenterKookUserBox.Text = ((binding != null) ? binding.KookUserId : null) ?? "未绑定 KOOK 账号";
				((Collection<WxAKn9fRycUOUMdMZHj4>)(object)__8_locals9._kookProducts).Clear();
				T9NmGVfR07AvCBhE2MjK? draft = __8_locals9._draft;
				if (((draft != null) ? draft.Purpose : null) == "kook_purchase")
				{
					_u__ = AppShell.Api.uV50nwjVs0().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<jeqOC5fRJRoOimNqGGEm>, _LoadKookContextAsync_d__13>(ref _u__, ref this);
						return;
					}
					goto IL_0140;
				}
				goto end_IL_0011;
				IL_0140:
				jeqOC5fRJRoOimNqGGEm result2 = _u__.GetResult();
				UiHelpers.Replace(__8_locals9._kookProducts, (global::System.Collections.Generic.IEnumerable<WxAKn9fRycUOUMdMZHj4>)result2.Products);
				((Selector)__8_locals9.PaymentCenterKookProductBox).SelectedItem = Enumerable.FirstOrDefault<WxAKn9fRycUOUMdMZHj4>((global::System.Collections.Generic.IEnumerable<WxAKn9fRycUOUMdMZHj4>)__8_locals9._kookProducts, (Func<WxAKn9fRycUOUMdMZHj4, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (WxAKn9fRycUOUMdMZHj4 item) => item.Id == __8_locals9._draft.ProductId)) ?? Enumerable.FirstOrDefault<WxAKn9fRycUOUMdMZHj4>((global::System.Collections.Generic.IEnumerable<WxAKn9fRycUOUMdMZHj4>)__8_locals9._kookProducts);
				__8_locals9.UpdateKookAmount();
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
	private struct _LoadMethodsAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<yg9HVZft43Yd2k4O7qX5> __u__1;

		private TaskAwaiter<A9uRAufRVheoa8CBA6OA> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter<A9uRAufRVheoa8CBA6OA> _u__ = default;
				TaskAwaiter<yg9HVZft43Yd2k4O7qX5> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter<A9uRAufRVheoa8CBA6OA>);
						num = (__1__state = -1);
						goto IL_0143;
					}
					((Control)paymentCenterPage.CreatePaymentCenterOrderButton).IsEnabled = false;
					((Collection<aIFZ93fRD8ZaK9DQ5OOq>)(object)paymentCenterPage._methods).Clear();
					((Selector)paymentCenterPage.PaymentCenterMethodBox).SelectedIndex = -1;
					_u__2 = AppShell.Api.TPbcqySjB7().GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<yg9HVZft43Yd2k4O7qX5>, _LoadMethodsAsync_d__11>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<yg9HVZft43Yd2k4O7qX5>);
					num = (__1__state = -1);
				}
				yg9HVZft43Yd2k4O7qX5 result = _u__2.GetResult();
				paymentCenterPage.PaymentCenterBalanceText.Text = $"¥ {result.User.Balance:0.00}";
				_u__ = AppShell.Api.RBq0ins422().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<A9uRAufRVheoa8CBA6OA>, _LoadMethodsAsync_d__11>(ref _u__, ref this);
					return;
				}
				goto IL_0143;
				IL_0143:
				A9uRAufRVheoa8CBA6OA result2 = _u__.GetResult();
				paymentCenterPage._checkoutMode = (string.Equals(result2.CheckoutMode, "external", (StringComparison)5) ? "external" : "embedded");
				UiHelpers.Replace(paymentCenterPage._methods, (global::System.Collections.Generic.IEnumerable<aIFZ93fRD8ZaK9DQ5OOq>)result2.Available);
				((Selector)paymentCenterPage.PaymentCenterMethodBox).SelectedIndex = ((((Collection<aIFZ93fRD8ZaK9DQ5OOq>)(object)paymentCenterPage._methods).Count <= 0) ? (-1) : 0);
				((Control)paymentCenterPage.CreatePaymentCenterOrderButton).IsEnabled = ((Collection<aIFZ93fRD8ZaK9DQ5OOq>)(object)paymentCenterPage._methods).Count > 0;
				if (((Collection<aIFZ93fRD8ZaK9DQ5OOq>)(object)paymentCenterPage._methods).Count == 0)
				{
					paymentCenterPage.PaymentCenterStatusText.Text = "支付中心暂未开放可用支付方式";
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OnNavigatedTo_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		public NavigationEventArgs e;

		private __c__DisplayClass7_0_1 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				object parameter;
				T9NmGVfR07AvCBhE2MjK? draft = default;
				object parameter2;
				T9NmGVfR07AvCBhE2MjK? draft2;
				string text;
				switch (num)
				{
				default:
					__8__1 = (__c__DisplayClass7_0_1)new __c__DisplayClass7_0_1();
					__8__1.__4__this = __4__this;
					paymentCenterPage.__n__0(e);
					_u__ = AppShell.RunAsync(paymentCenterPage.LoadMethodsAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__7>(ref _u__, ref this);
						return;
					}
					goto IL_00ad;
				case 0:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00ad;
				case 1:
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_017d;
				case 2:
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_0184:
					if (paymentCenterPage._draft != null)
					{
						int? amountCents = paymentCenterPage._draft.AmountCents;
						if (amountCents.HasValue && amountCents.GetValueOrDefault() > 0)
						{
							paymentCenterPage.PaymentCenterAmountBox.Text = (paymentCenterPage._draft.AmountCents.Value / 100m).ToString("0.00", (IFormatProvider)(object)CultureInfo.InvariantCulture);
						}
						aIFZ93fRD8ZaK9DQ5OOq val = Enumerable.FirstOrDefault<aIFZ93fRD8ZaK9DQ5OOq>((global::System.Collections.Generic.IEnumerable<aIFZ93fRD8ZaK9DQ5OOq>)paymentCenterPage._methods, (Func<aIFZ93fRD8ZaK9DQ5OOq, bool>)__8__1._OnNavigatedTo_b__1);
						if (val != null)
						{
							((Selector)paymentCenterPage.PaymentCenterMethodBox).SelectedItem = val;
						}
					}
					parameter = e.Parameter;
					__8__1.merchantOrderNo = parameter as string;
					if (__8__1.merchantOrderNo != null && !string.IsNullOrWhiteSpace(__8__1.merchantOrderNo))
					{
						_u__ = AppShell.RunAsync(__8__1._OnNavigatedTo_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__7>(ref _u__, ref this);
							return;
						}
						break;
					}
					goto end_IL_0011;
					IL_00ad:
						draft = default;
					_u__.GetResult();
					draft = paymentCenterPage._draft;
					parameter2 = e.Parameter;
					draft = (T9NmGVfR07AvCBhE2MjK?)((parameter2 is T9NmGVfR07AvCBhE2MjK) ? parameter2 : null);
					paymentCenterPage.UpdatePurposeFields();
					draft2 = paymentCenterPage._draft;
					text = ((draft2 != null) ? draft2.Purpose : null);
					if ((text == "kook_purchase" || text == "kook_recharge") ? true : false)
					{
						_u__ = AppShell.RunAsync(paymentCenterPage.LoadKookContextAsync).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__7>(ref _u__, ref this);
							return;
						}
						goto IL_017d;
					}
					goto IL_0184;
					IL_017d:
					_u__.GetResult();
					goto IL_0184;
				}
				_u__.GetResult();
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = null;
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
	private struct _OpenPaymentCenterAppButton_Click_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00b5;
				}
				Uri val = default(Uri);
				if (paymentCenterPage._order != null && Regex.IsMatch(paymentCenterPage._order.AppScheme, "^[A-Za-z][A-Za-z0-9+.-]{1,31}://", (RegexOptions)512) && Uri.TryCreate(paymentCenterPage._order.AppScheme, (UriKind)1, out val))
				{
					_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(val));
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenPaymentCenterAppButton_Click_d__22>(ref _u__, ref this);
						return;
					}
					goto IL_00b5;
				}
				goto end_IL_0011;
				IL_00b5:
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
	private struct _OpenPaymentCenterButton_Click_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_0113;
				}
				if (paymentCenterPage._order != null)
				{
					Uri val = default(Uri);
					bool flag = !Uri.TryCreate((!string.IsNullOrWhiteSpace(paymentCenterPage._order.CheckoutUrl)) ? paymentCenterPage._order.CheckoutUrl : paymentCenterPage._order.RedirectUrl, (UriKind)1, out val);
					if (!flag)
					{
						string scheme = val.Scheme;
						bool flag2 = ((scheme == "http" || scheme == "https") ? true : false);
						flag = !flag2;
					}
					if (!flag)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(val));
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenPaymentCenterButton_Click_d__21>(ref _u__, ref this);
							return;
						}
						goto IL_0113;
					}
					AppShell.Warning("支付站链接无效");
				}
				goto end_IL_0011;
				IL_0113:
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
	private struct _PollAsync_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		public CancellationToken cancellationToken;

		public string orderNo;

		private __c__DisplayClass27_0_1 __8__1;

		private TimeSpan _delay_5__2;

		private TaskAwaiter __u__1;

		private TaskAwaiter<BARafCfRr4T7Xe7KDtJF> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_0032;
				}
				_delay_5__2 = TimeSpan.FromSeconds(5.0);
				goto IL_02c4;
				IL_0032:
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<BARafCfRr4T7Xe7KDtJF> _u__2 = default;
					BARafCfRr4T7Xe7KDtJF result;
					BARafCfRr4T7Xe7KDtJF? order;
					switch (num)
					{
					default:
						__8__1 = (__c__DisplayClass27_0_1)new __c__DisplayClass27_0_1();
						__8__1.__4__this = paymentCenterPage;
						_u__ = global::System.Threading.Tasks.Task.Delay(_delay_5__2, cancellationToken).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollAsync_d__27>(ref _u__, ref this);
							return;
						}
						goto IL_00bd;
					case 0:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00bd;
					case 1:
						_u__2 = __u__2;
						__u__2 = default(TaskAwaiter<BARafCfRr4T7Xe7KDtJF>);
						num = (__1__state = -1);
						goto IL_0128;
					case 2:
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0128:
						result = _u__2.GetResult();
						__8__1.order = result;
						order = paymentCenterPage._order;
						if (string.Equals((order != null) ? order.MerchantOrderNo : null, __8__1.order.MerchantOrderNo, (StringComparison)4))
						{
							paymentCenterPage._order = __8__1.order;
							_u__ = paymentCenterPage.RunOnUiAsync(__8__1._PollAsync_b__0).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 2);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollAsync_d__27>(ref _u__, ref this);
								return;
							}
							break;
						}
						goto end_IL_0032;
						IL_00bd:
						_u__.GetResult();
						_u__2 = AppShell.Api.iaZ8foVl5m(orderNo).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BARafCfRr4T7Xe7KDtJF>, _PollAsync_d__27>(ref _u__2, ref this);
							return;
						}
						goto IL_0128;
					}
					_u__.GetResult();
					string effectiveStatus = __8__1.order.EffectiveStatus;
					if ((!(effectiveStatus == "SUCCEEDED") && !(effectiveStatus == "FAILED") && !(effectiveStatus == "CANCELLED")) || 1 == 0)
					{
						_delay_5__2 = TimeSpan.FromSeconds(Math.Min(30.0, _delay_5__2.TotalSeconds + 5.0));
						__8__1 = null;
						goto IL_02c4;
					}
					end_IL_0032:;
				}
				catch (OperationCanceledException)
				{
				}
				catch
				{
					_delay_5__2 = TimeSpan.FromSeconds(Math.Min(30.0, _delay_5__2.TotalSeconds + 5.0));
					goto IL_02c4;
				}
				goto end_IL_0011;
				IL_02c4:
				if (!cancellationToken.IsCancellationRequested)
				{
					goto IL_0032;
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
	private struct _RefreshPaymentCenterButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage __8_locals2 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0089;
				}
				if (__8_locals2._order != null)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__RefreshPaymentCenterButton_Click_b__19_0_d _RefreshPaymentCenterButton_Click_b__19_0_d = default(__RefreshPaymentCenterButton_Click_b__19_0_d);
						_RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_RefreshPaymentCenterButton_Click_b__19_0_d.__4__this = __8_locals2;
						_RefreshPaymentCenterButton_Click_b__19_0_d.__1__state = -1;
						_RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder.Start<__RefreshPaymentCenterButton_Click_b__19_0_d>(ref _RefreshPaymentCenterButton_Click_b__19_0_d);
						return _RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshPaymentCenterButton_Click_d__19>(ref _u__, ref this);
						return;
					}
					goto IL_0089;
				}
				goto end_IL_0011;
				IL_0089:
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
	private struct _RenderOrderAsync_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentCenterPage __4__this;

		public BARafCfRr4T7Xe7KDtJF order;

		private Image __7__wrap1;

		private TaskAwaiter<BitmapImage> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_034f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0357: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_032f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentCenterPage paymentCenterPage = __4__this;
			try
			{
				TaskAwaiter<BitmapImage> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<BitmapImage>);
					num = (__1__state = -1);
					goto IL_0366;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<BitmapImage>);
					num = (__1__state = -1);
					goto IL_040d;
				}
				paymentCenterPage.PaymentCenterStatusText.Text = $"{order.StatusText} · {order.AmountText}\n订单号：{order.MerchantOrderNo}";
				TextBlock paymentCenterOrderHintText = paymentCenterPage.PaymentCenterOrderHintText;
				object text;
				if (!(order.FulfillmentStatus == "FAILED"))
				{
					DateTimeOffset? expiresAt = order.ExpiresAt;
					if (expiresAt.HasValue)
					{
						DateTimeOffset valueOrDefault = expiresAt.GetValueOrDefault();
						text = $"有效期至 {valueOrDefault.ToLocalTime():yyyy-MM-dd HH:mm:ss}";
					}
					else
					{
						text = "";
					}
				}
				else
				{
					text = "支付已确认，但业务入账失败：" + order.FulfillmentError + "，请保留订单号联系管理员。";
				}
				paymentCenterOrderHintText.Text = (string)text;
				Button openPaymentCenterButton = paymentCenterPage.OpenPaymentCenterButton;
				string effectiveStatus = order.EffectiveStatus;
				bool flag = ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false);
				((UIElement)openPaymentCenterButton).Visibility = (((!flag || (string.IsNullOrWhiteSpace(order.RedirectUrl) && string.IsNullOrWhiteSpace(order.CheckoutUrl))) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
				openPaymentCenterButton = paymentCenterPage.OpenPaymentCenterAppButton;
				effectiveStatus = order.EffectiveStatus;
				flag = ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false);
				((UIElement)openPaymentCenterButton).Visibility = (((!flag || !Regex.IsMatch(order.AppScheme, "^[A-Za-z][A-Za-z0-9+.-]{1,31}://", (RegexOptions)512)) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
				openPaymentCenterButton = paymentCenterPage.CancelPaymentCenterButton;
				effectiveStatus = order.EffectiveStatus;
				flag = ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false);
				((Control)openPaymentCenterButton).IsEnabled = flag;
				paymentCenterPage.PaymentCenterQrImage.Source = null;
				((UIElement)paymentCenterPage.PaymentCenterQrImage).Visibility = (Visibility)1;
				flag = paymentCenterPage._checkoutMode != "external";
				if (flag)
				{
					effectiveStatus = order.EffectiveStatus;
					bool flag2 = ((effectiveStatus == "PENDING" || effectiveStatus == "PROCESSING") ? true : false);
					flag = flag2;
				}
				if (flag)
				{
					if (!string.IsNullOrWhiteSpace(order.QrImage))
					{
						__7__wrap1 = paymentCenterPage.PaymentCenterQrImage;
						_u__ = PaymentQrImageDecoder.DecodeAsync(order.QrImage).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, _RenderOrderAsync_d__23>(ref _u__, ref this);
							return;
						}
						goto IL_0366;
					}
					if (!string.IsNullOrWhiteSpace(order.QrPayload))
					{
						__7__wrap1 = paymentCenterPage.PaymentCenterQrImage;
						_u__ = RenderQrAsync(order.QrPayload).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<BitmapImage>, _RenderOrderAsync_d__23>(ref _u__, ref this);
							return;
						}
						goto IL_040d;
					}
					goto IL_042a;
				}
				goto end_IL_0011;
				IL_042a:
				((UIElement)paymentCenterPage.PaymentCenterQrImage).Visibility = ((paymentCenterPage.PaymentCenterQrImage.Source == null) ? Visibility.Visible : Visibility.Collapsed);
				goto end_IL_0011;
				IL_0366:
				BitmapImage result = _u__.GetResult();
				__7__wrap1.Source = (ImageSource)(object)result;
				__7__wrap1 = null;
				goto IL_042a;
				IL_040d:
				result = _u__.GetResult();
				__7__wrap1.Source = (ImageSource)(object)result;
				__7__wrap1 = null;
				goto IL_042a;
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

	private readonly ObservableCollection<aIFZ93fRD8ZaK9DQ5OOq> _methods;

	private readonly ObservableCollection<WxAKn9fRycUOUMdMZHj4> _kookProducts;

	private BARafCfRr4T7Xe7KDtJF? _order;

	private T9NmGVfR07AvCBhE2MjK? _draft;

	private CancellationTokenSource? _polling;

	private string _checkoutMode;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PaymentCenterOrderHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PaymentCenterPurposeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PaymentCenterMethodBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel PaymentCenterKookPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PaymentCenterAmountBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PaymentCenterStatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image PaymentCenterQrImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenPaymentCenterButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenPaymentCenterAppButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CreatePaymentCenterOrderButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshPaymentCenterButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelPaymentCenterButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PaymentCenterKookUserBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox PaymentCenterKookProductBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox PaymentCenterKookQuantityBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PaymentCenterBalanceText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	public PaymentCenterPage()
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		_methods = new ObservableCollection<aIFZ93fRD8ZaK9DQ5OOq>();
		_kookProducts = new ObservableCollection<WxAKn9fRycUOUMdMZHj4>();
		_checkoutMode = "embedded";
		InitializeComponent();
		((ItemsControl)PaymentCenterMethodBox).ItemsSource = _methods;
		((ItemsControl)PaymentCenterKookProductBox).ItemsSource = _kookProducts;
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__7 onNavigatedTo_d__ = default(_OnNavigatedTo_d__7);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__7>(ref onNavigatedTo_d__);
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
		StopPolling();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		StopPolling();
		_order = null;
		((Collection<aIFZ93fRD8ZaK9DQ5OOq>)(object)_methods).Clear();
		PaymentCenterQrImage.Source = null;
		((UIElement)PaymentCenterQrImage).Visibility = (Visibility)1;
		((UIElement)OpenPaymentCenterButton).Visibility = (Visibility)1;
		((UIElement)OpenPaymentCenterAppButton).Visibility = (Visibility)1;
		PaymentCenterStatusText.Text = "";
		((Control)PaymentCenterAmountBox).IsEnabled = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadMethodsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadMethodsAsync_d__11 loadMethodsAsync_d__ = default(_LoadMethodsAsync_d__11);
		loadMethodsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadMethodsAsync_d__.__4__this = this;
		loadMethodsAsync_d__.__1__state = -1;
		loadMethodsAsync_d__.__t__builder.Start<_LoadMethodsAsync_d__11>(ref loadMethodsAsync_d__);
		return loadMethodsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdatePurposeFields()
	{
		T9NmGVfR07AvCBhE2MjK? draft = _draft;
		string text = ((draft != null) ? draft.Purpose : null) ?? "balance_recharge";
		TextBlock paymentCenterPurposeText = PaymentCenterPurposeText;
		string text2 = ((text == "service_subscription") ? "服务套餐支付" : ((text == "kook_purchase") ? "KOOK 商城支付" : ((!(text == "kook_recharge")) ? "余额充值" : "KOOK 账户充值")));
		paymentCenterPurposeText.Text = text2;
		StackPanel paymentCenterKookPanel = PaymentCenterKookPanel;
		bool flag = ((text == "kook_purchase" || text == "kook_recharge") ? true : false);
		((UIElement)paymentCenterKookPanel).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((UIElement)PaymentCenterKookQuantityBox).Visibility = ((!(text == "kook_purchase")) ? Visibility.Visible : Visibility.Collapsed);
		PaymentCenterAmountBox.Header = ((text == "service_subscription") ? "套餐金额（元）" : ((text == "kook_purchase") ? "商品金额（元）" : "充值金额（元）"));
		TextBox paymentCenterAmountBox = PaymentCenterAmountBox;
		flag = ((text == "service_subscription" || text == "kook_purchase") ? true : false);
		((Control)paymentCenterAmountBox).IsEnabled = !flag;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadKookContextAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadKookContextAsync_d__13 loadKookContextAsync_d__ = default(_LoadKookContextAsync_d__13);
		loadKookContextAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadKookContextAsync_d__.__4__this = this;
		loadKookContextAsync_d__.__1__state = -1;
		loadKookContextAsync_d__.__t__builder.Start<_LoadKookContextAsync_d__13>(ref loadKookContextAsync_d__);
		return loadKookContextAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateKookAmount()
	{
		T9NmGVfR07AvCBhE2MjK? draft = _draft;
		if (((draft != null) ? draft.Purpose : null) != "kook_purchase")
		{
			return;
		}
		object selectedItem = ((Selector)PaymentCenterKookProductBox).SelectedItem;
		WxAKn9fRycUOUMdMZHj4 val = (WxAKn9fRycUOUMdMZHj4)((selectedItem is WxAKn9fRycUOUMdMZHj4) ? selectedItem : null);
		if (val != null)
		{
			int num = default(int);
			if (!int.TryParse(PaymentCenterKookQuantityBox.Text, (NumberStyles)7, (IFormatProvider)(object)CultureInfo.InvariantCulture, out num))
			{
				num = 1;
			}
			num = Math.Clamp(num, 1, 20);
			PaymentCenterKookQuantityBox.Text = num.ToString((IFormatProvider)(object)CultureInfo.InvariantCulture);
			PaymentCenterAmountBox.Text = (val.Price * num).ToString("0.00", (IFormatProvider)(object)CultureInfo.InvariantCulture);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PaymentCenterKookProductBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		UpdateKookAmount();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PaymentCenterKookQuantityBox_TextChanged(object sender, TextChangedEventArgs e)
	{
		UpdateKookAmount();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void PaymentCenterAmountBox_TextChanged(object sender, TextChangedEventArgs e)
	{
		T9NmGVfR07AvCBhE2MjK? draft = _draft;
		if (((draft != null) ? draft.Purpose : null) == "kook_purchase")
		{
			UpdateKookAmount();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CreatePaymentCenterOrderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CreatePaymentCenterOrderButton_Click_d__18 createPaymentCenterOrderButton_Click_d__ = default(_CreatePaymentCenterOrderButton_Click_d__18);
		createPaymentCenterOrderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		createPaymentCenterOrderButton_Click_d__.__4__this = this;
		createPaymentCenterOrderButton_Click_d__.__1__state = -1;
		createPaymentCenterOrderButton_Click_d__.__t__builder.Start<_CreatePaymentCenterOrderButton_Click_d__18>(ref createPaymentCenterOrderButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshPaymentCenterButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshPaymentCenterButton_Click_d__19 refreshPaymentCenterButton_Click_d__ = default(_RefreshPaymentCenterButton_Click_d__19);
		refreshPaymentCenterButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshPaymentCenterButton_Click_d__.__4__this = this;
		refreshPaymentCenterButton_Click_d__.__1__state = -1;
		refreshPaymentCenterButton_Click_d__.__t__builder.Start<_RefreshPaymentCenterButton_Click_d__19>(ref refreshPaymentCenterButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CancelPaymentCenterButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CancelPaymentCenterButton_Click_d__20 cancelPaymentCenterButton_Click_d__ = default(_CancelPaymentCenterButton_Click_d__20);
		cancelPaymentCenterButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		cancelPaymentCenterButton_Click_d__.__4__this = this;
		cancelPaymentCenterButton_Click_d__.__1__state = -1;
		cancelPaymentCenterButton_Click_d__.__t__builder.Start<_CancelPaymentCenterButton_Click_d__20>(ref cancelPaymentCenterButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenPaymentCenterButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenPaymentCenterButton_Click_d__21 openPaymentCenterButton_Click_d__ = default(_OpenPaymentCenterButton_Click_d__21);
		openPaymentCenterButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openPaymentCenterButton_Click_d__.__4__this = this;
		openPaymentCenterButton_Click_d__.__1__state = -1;
		openPaymentCenterButton_Click_d__.__t__builder.Start<_OpenPaymentCenterButton_Click_d__21>(ref openPaymentCenterButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenPaymentCenterAppButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenPaymentCenterAppButton_Click_d__22 openPaymentCenterAppButton_Click_d__ = default(_OpenPaymentCenterAppButton_Click_d__22);
		openPaymentCenterAppButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openPaymentCenterAppButton_Click_d__.__4__this = this;
		openPaymentCenterAppButton_Click_d__.__1__state = -1;
		openPaymentCenterAppButton_Click_d__.__t__builder.Start<_OpenPaymentCenterAppButton_Click_d__22>(ref openPaymentCenterAppButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RenderOrderAsync(BARafCfRr4T7Xe7KDtJF order)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RenderOrderAsync_d__23 renderOrderAsync_d__ = default(_RenderOrderAsync_d__23);
		renderOrderAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		renderOrderAsync_d__.__4__this = this;
		renderOrderAsync_d__.order = order;
		renderOrderAsync_d__.__1__state = -1;
		renderOrderAsync_d__.__t__builder.Start<_RenderOrderAsync_d__23>(ref renderOrderAsync_d__);
		return renderOrderAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<BitmapImage> RenderQrAsync(string payload)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		QRCodeGenerator val = new QRCodeGenerator();
		try
		{
			QRCoder.QRCodeData val2 = val.CreateQrCode(payload, (QRCodeGenerator.ECCLevel)2, false, false, (QRCodeGenerator.EciMode)0, -1);
			try
			{
				byte[] graphic = new PngByteQRCode(val2).GetGraphic(8, true);
				InMemoryRandomAccessStream val3 = new InMemoryRandomAccessStream();
				try
				{
					TaskAwaiter<uint> val4 = WindowsRuntimeSystemExtensions.GetAwaiter<uint, uint>(val3.WriteAsync(WindowsRuntimeBufferExtensions.AsBuffer(graphic)));
					if (!val4.IsCompleted)
					{
						val4.GetResult();
						TaskAwaiter<uint> val5 = default(TaskAwaiter<uint>);
						val4 = val5;
					}
					val4.GetResult();
					val3.Seek(0uL);
					BitmapImage val6 = new BitmapImage();
					TaskAwaiter val7 = WindowsRuntimeSystemExtensions.GetAwaiter(((BitmapSource)val6).SetSourceAsync((IRandomAccessStream)(object)val3));
					if (!val7.IsCompleted)
					{
						val7.GetResult();
						TaskAwaiter val8 = default(TaskAwaiter);
						val7 = val8;
					}
					val7.GetResult();
					return val6;
				}
				finally
				{
					((global::System.IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((global::System.IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StartPolling(string orderNo)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		StopPolling();
		_polling = new CancellationTokenSource();
		PollAsync(orderNo, _polling.Token);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StopPolling()
	{
		CancellationTokenSource? polling = _polling;
		if (polling != null)
		{
			polling.Cancel();
		}
		CancellationTokenSource? polling2 = _polling;
		if (polling2 != null)
		{
			polling2.Dispose();
		}
		_polling = null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task PollAsync(string orderNo, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_PollAsync_d__27 pollAsync_d__ = default(_PollAsync_d__27);
		pollAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		pollAsync_d__.__4__this = this;
		pollAsync_d__.orderNo = orderNo;
		pollAsync_d__.cancellationToken = cancellationToken;
		pollAsync_d__.__1__state = -1;
		pollAsync_d__.__t__builder.Start<_PollAsync_d__27>(ref pollAsync_d__);
		return pollAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Threading.Tasks.Task RunOnUiAsync(Func<global::System.Threading.Tasks.Task> action)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		__c__DisplayClass28_0 __8_locals5 = (__c__DisplayClass28_0)new __c__DisplayClass28_0();
		__8_locals5.action = action;
		__8_locals5.completion = new TaskCompletionSource<object>((TaskCreationOptions)64);
		if (!((Microsoft.UI.Xaml.DependencyObject)this).DispatcherQueue.TryEnqueue((Microsoft.UI.Dispatching.DispatcherQueueHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] () =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass28_0.__RunOnUiAsync_b__0_d _RunOnUiAsync_b__0_d = default(__c__DisplayClass28_0.__RunOnUiAsync_b__0_d);
			_RunOnUiAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_RunOnUiAsync_b__0_d.__4__this = __8_locals5;
			_RunOnUiAsync_b__0_d.__1__state = -1;
			_RunOnUiAsync_b__0_d.__t__builder.Start<__c__DisplayClass28_0.__RunOnUiAsync_b__0_d>(ref _RunOnUiAsync_b__0_d);
		})))
		{
			__8_locals5.completion.TrySetException((global::System.Exception)new InvalidOperationException("支付页面已关闭"));
		}
		return __8_locals5.completion.Task;
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
			Uri val = new Uri("ms-appx:///Views/Pages/PaymentCenterPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PaymentCenterOrderHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			PaymentCenterPurposeText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			PaymentCenterMethodBox = CastExtensions.As<ComboBox>(target);
			break;
		case 5:
			PaymentCenterKookPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			PaymentCenterAmountBox = CastExtensions.As<TextBox>(target);
			PaymentCenterAmountBox.TextChanged += new TextChangedEventHandler(PaymentCenterAmountBox_TextChanged);
			break;
		case 7:
			PaymentCenterStatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 8:
			PaymentCenterQrImage = CastExtensions.As<Image>(target);
			break;
		case 9:
			OpenPaymentCenterButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenPaymentCenterButton).Click += new RoutedEventHandler(OpenPaymentCenterButton_Click);
			break;
		case 10:
			OpenPaymentCenterAppButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenPaymentCenterAppButton).Click += new RoutedEventHandler(OpenPaymentCenterAppButton_Click);
			break;
		case 11:
			CreatePaymentCenterOrderButton = CastExtensions.As<Button>(target);
			((ButtonBase)CreatePaymentCenterOrderButton).Click += new RoutedEventHandler(CreatePaymentCenterOrderButton_Click);
			break;
		case 12:
			RefreshPaymentCenterButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshPaymentCenterButton).Click += new RoutedEventHandler(RefreshPaymentCenterButton_Click);
			break;
		case 13:
			CancelPaymentCenterButton = CastExtensions.As<Button>(target);
			((ButtonBase)CancelPaymentCenterButton).Click += new RoutedEventHandler(CancelPaymentCenterButton_Click);
			break;
		case 14:
			PaymentCenterKookUserBox = CastExtensions.As<TextBox>(target);
			break;
		case 15:
			PaymentCenterKookProductBox = CastExtensions.As<ComboBox>(target);
			((Selector)PaymentCenterKookProductBox).SelectionChanged += new SelectionChangedEventHandler(PaymentCenterKookProductBox_SelectionChanged);
			break;
		case 16:
			PaymentCenterKookQuantityBox = CastExtensions.As<TextBox>(target);
			PaymentCenterKookQuantityBox.TextChanged += new TextChangedEventHandler(PaymentCenterKookQuantityBox_TextChanged);
			break;
		case 17:
			PaymentCenterBalanceText = CastExtensions.As<TextBlock>(target);
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
	[DebuggerHidden]
	[CompilerGenerated]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _LoadKookContextAsync_b__13_0(WxAKn9fRycUOUMdMZHj4 item)
	{
		return item.Id == _draft.ProductId;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _RefreshPaymentCenterButton_Click_b__19_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__RefreshPaymentCenterButton_Click_b__19_0_d _RefreshPaymentCenterButton_Click_b__19_0_d = default(__RefreshPaymentCenterButton_Click_b__19_0_d);
		_RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_RefreshPaymentCenterButton_Click_b__19_0_d.__4__this = this;
		_RefreshPaymentCenterButton_Click_b__19_0_d.__1__state = -1;
		_RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder.Start<__RefreshPaymentCenterButton_Click_b__19_0_d>(ref _RefreshPaymentCenterButton_Click_b__19_0_d);
		return _RefreshPaymentCenterButton_Click_b__19_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private global::System.Threading.Tasks.Task _CancelPaymentCenterButton_Click_b__20_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__CancelPaymentCenterButton_Click_b__20_0_d _CancelPaymentCenterButton_Click_b__20_0_d = default(__CancelPaymentCenterButton_Click_b__20_0_d);
		_CancelPaymentCenterButton_Click_b__20_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_CancelPaymentCenterButton_Click_b__20_0_d.__4__this = this;
		_CancelPaymentCenterButton_Click_b__20_0_d.__1__state = -1;
		_CancelPaymentCenterButton_Click_b__20_0_d.__t__builder.Start<__CancelPaymentCenterButton_Click_b__20_0_d>(ref _CancelPaymentCenterButton_Click_b__20_0_d);
		return _CancelPaymentCenterButton_Click_b__20_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Controls;
using Mahiro_Account.UI.Shell;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using QRCoder;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Storage.Streams;
using Windows.System;
using bUfedyCg1PBqhqIkB8r;
using e38ZmBf51OoNmYc9Uj20;
using gutM8kfejYCdXhJYN8g9;
using k3mslofReUvYgRPIiJbq;
using nowIRbfRRJ79HCUCsbjS;
using qG4hi9fRxSuBHQR0lMWK;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class PaymentOrdersPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IPaymentOrdersPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IPaymentOrdersPage_BindingsScopeConnector
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

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class PaymentOrdersPage_obj29_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IPaymentOrdersPage_Bindings
	{
		private delegate void InvokeFunctionDelegate(int phase);

		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class PaymentOrdersPage_obj29_BindingsTracking
		{
			private WeakReference<PaymentOrdersPage_obj29_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public PaymentOrdersPage_obj29_BindingsTracking(PaymentOrdersPage_obj29_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<PaymentOrdersPage_obj29_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public PaymentOrdersPage_obj29_Bindings TryGetBindingObject()
			{
				PaymentOrdersPage_obj29_Bindings paymentOrdersPage_obj29_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out paymentOrdersPage_obj29_Bindings);
					if (paymentOrdersPage_obj29_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return paymentOrdersPage_obj29_Bindings;
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

		private WeakReference obj29;

		private TextBlock obj30;

		private TextBlock obj31;

		private TextBlock obj32;

		private TextBlock obj33;

		private TextBlock obj34;

		private Button obj35;

		private Border obj36;

		private Border obj37;

		private Border obj38;

		private Border obj39;

		private TextBlock obj40;

		private TextBlock obj41;

		private PaymentOrdersPage_obj29_BindingsTracking bindingsTracking;

		private Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings;

		[MethodImpl((MethodImplOptions)8)]
		public PaymentOrdersPage_obj29_Bindings()
		{
			PendingFunctionBindings = new Dictionary<string, InvokeFunctionDelegate>();
			bindingsTracking = (PaymentOrdersPage_obj29_BindingsTracking)new PaymentOrdersPage_obj29_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			switch (connectionId)
			{
			case 29:
				obj29 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 30:
				obj30 = CastExtensions.As<TextBlock>(target);
				break;
			case 31:
				obj31 = CastExtensions.As<TextBlock>(target);
				break;
			case 32:
				obj32 = CastExtensions.As<TextBlock>(target);
				break;
			case 33:
				obj33 = CastExtensions.As<TextBlock>(target);
				break;
			case 34:
				obj34 = CastExtensions.As<TextBlock>(target);
				break;
			case 35:
				obj35 = CastExtensions.As<Button>(target);
				break;
			case 36:
				obj36 = CastExtensions.As<Border>(target);
				break;
			case 37:
				obj37 = CastExtensions.As<Border>(target);
				break;
			case 38:
				obj38 = CastExtensions.As<Border>(target);
				break;
			case 39:
				obj39 = CastExtensions.As<Border>(target);
				break;
			case 40:
				obj40 = CastExtensions.As<TextBlock>(target);
				break;
			case 41:
				obj41 = CastExtensions.As<TextBlock>(target);
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
			nextPhase = 0;
			removedDataContextHandler = true;
			object target = obj29.Target;
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
		private void Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = PaidPillVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj35, value);
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj36, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = PendingPillVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj37, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = FailedPillVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj38, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Status(out var val))
			{
				Visibility value = OtherPillVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj39, value);
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
				Update_OrderNo(obj.OrderNo, phase);
				Update_PayAmountText(obj.PayAmountText, phase);
				Update_PurposeText(obj.PurposeText, phase);
				Update_TimeText(obj.TimeText, phase);
				Update_Id(obj.Id, phase);
				Update_Status(obj.Status, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_PaidStatusText(obj.PaidStatusText, phase);
			}
			Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104(phase);
			Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104(phase);
			Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104(phase);
			Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104(phase);
			CompleteUpdate(phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ChannelName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj30, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_OrderNo(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj31, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PayAmountText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj32, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PurposeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj33, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TimeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj34, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(long obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj35, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Status(string obj, int phase)
		{
			if (obj != null)
			{
				Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104(phase);
				Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104(phase);
				Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104(phase);
				Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104(phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104"] = Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104;
				PendingFunctionBindings["Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104"] = Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PaidPillVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104"] = Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_PendingPillVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104"] = Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_FailedPillVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104"] = Invoke_Mahiro_Account_Views_Pages_PaymentOrdersPage_M_OtherPillVisibility_1959773104;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj40, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PaidStatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj41, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__17_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

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
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = paymentOrdersPage.MovePageAsync(-1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__17_0_d>(ref _u__, ref this);
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
	private struct ___ctor_b__17_1_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

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
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = paymentOrdersPage.MovePageAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__17_1_d>(ref _u__, ref this);
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
	private sealed class __c__DisplayClass18_0_6
	{
		[StructLayout((LayoutKind)3)]
		private struct __OnNavigatedTo_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass18_0_6 __4__this;

			private aS44CUfR6tdgNLbdQbUH _order_5__2;

			private TaskAwaiter __u__1;

			private TaskAwaiter<aS44CUfR6tdgNLbdQbUH> __u__2;

			private TaskAwaiter<bool> __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0105: Unknown result type (might be due to invalid IL or missing references)
				//IL_010a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01af: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0245: Unknown result type (might be due to invalid IL or missing references)
				//IL_024a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0252: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0174: Unknown result type (might be due to invalid IL or missing references)
				//IL_0179: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_0190: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Unknown result type (might be due to invalid IL or missing references)
				//IL_020d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0212: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
				//IL_022a: Unknown result type (might be due to invalid IL or missing references)
				//IL_022c: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass18_0_6 _c__DisplayClass18_0_ = __4__this;
				try
				{
					TaskAwaiter _u__2 = default;
					TaskAwaiter<aS44CUfR6tdgNLbdQbUH> _u__3 = default;
					TaskAwaiter<bool> _u__ = default;
					bool flag;
					aS44CUfR6tdgNLbdQbUH result;
					switch (num)
					{
					default:
						_u__2 = _c__DisplayClass18_0_.__4__this.RefreshOrdersAsync().GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0083;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0083;
					case 1:
						_u__3 = __u__2;
						__u__2 = default(TaskAwaiter<aS44CUfR6tdgNLbdQbUH>);
						num = (__1__state = -1);
						goto IL_0121;
					case 2:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_01c5;
					case 3:
						{
							_u__ = __u__3;
							__u__3 = default(TaskAwaiter<bool>);
							num = (__1__state = -1);
							goto IL_0261;
						}
						IL_0261:
						flag = _u__.GetResult();
						break;
						IL_0083:
						_u__2.GetResult();
						if ((object)_c__DisplayClass18_0_.request != null)
						{
							string orderNo = _c__DisplayClass18_0_.request.OrderNo;
							if (orderNo != null && orderNo.Length > 0)
							{
								_u__3 = AppShell.Api.PqJ0aaJCUJ(_c__DisplayClass18_0_.request.OrderNo).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aS44CUfR6tdgNLbdQbUH>, __OnNavigatedTo_b__0_d>(ref _u__3, ref this);
									return;
								}
								goto IL_0121;
							}
						}
						goto end_IL_0011;
						IL_01c5:
						_u__2.GetResult();
						_c__DisplayClass18_0_.requestedOrder = _order_5__2;
						flag = _c__DisplayClass18_0_.request.OpenPaymentPage && IsExternalPayment(_order_5__2);
						if (!flag)
						{
							break;
						}
						_u__ = LaunchPaymentPageAsync(_order_5__2).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 3);
							__u__3 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, __OnNavigatedTo_b__0_d>(ref _u__, ref this);
							return;
						}
						goto IL_0261;
						IL_0121:
						result = _u__3.GetResult();
						_order_5__2 = result;
						_u__2 = _c__DisplayClass18_0_.__4__this.ShowOrderAsync(_order_5__2, _order_5__2.Status == "pending" || _c__DisplayClass18_0_.__4__this.IsTrackedServicePayment(_order_5__2)).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 2);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __OnNavigatedTo_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_01c5;
					}
					if (flag)
					{
						AppShell.Info("已在浏览器打开支付页面，付款完成后订单状态会自动更新");
					}
					end_IL_0011:;
				}
				catch (global::System.Exception exception)
				{
					__1__state = -2;
					_order_5__2 = null;
					__t__builder.SetException(exception);
					return;
				}
				__1__state = -2;
				_order_5__2 = null;
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

		public PaymentOrdersPage __4__this;

		public PaymentOrderNavigationRequest request;

		public aS44CUfR6tdgNLbdQbUH requestedOrder;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_6()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _OnNavigatedTo_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__OnNavigatedTo_b__0_d _OnNavigatedTo_b__0_d = default(__OnNavigatedTo_b__0_d);
			_OnNavigatedTo_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_OnNavigatedTo_b__0_d.__4__this = this;
			_OnNavigatedTo_b__0_d.__1__state = -1;
			_OnNavigatedTo_b__0_d.__t__builder.Start<__OnNavigatedTo_b__0_d>(ref _OnNavigatedTo_b__0_d);
			return _OnNavigatedTo_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass1_0
	{
		public long orderId;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass1_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _RefundOrderButton_Click_b__0(aS44CUfR6tdgNLbdQbUH order)
		{
			if (order.Id == orderId)
			{
				return order.Status == "paid";
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass27_0_2
	{
		public PaymentOrdersPage __4__this;

		public aS44CUfR6tdgNLbdQbUH order;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass27_0_2()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task _PaymentOrderList_SelectionChanged_b__0()
		{
			return __4__this.ShowOrderAsync(order, order.Status == "pending");
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass48_0
	{
		[StructLayout((LayoutKind)3)]
		private struct __ConfirmCancelPaymentOrderButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass48_0 __4__this;

			private aS44CUfR6tdgNLbdQbUH _cancelledOrder_5__2;

			private TaskAwaiter<aS44CUfR6tdgNLbdQbUH> __u__1;

			private TaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0153: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Unknown result type (might be due to invalid IL or missing references)
				//IL_003d: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_011b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0120: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
				//IL_0138: Unknown result type (might be due to invalid IL or missing references)
				//IL_013a: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass48_0 _c__DisplayClass48_ = __4__this;
				try
				{
					TaskAwaiter<aS44CUfR6tdgNLbdQbUH> _u__2 = default;
					TaskAwaiter _u__ = default;
					aS44CUfR6tdgNLbdQbUH result;
					switch (num)
					{
					default:
						_u__2 = AppShell.Api.F2r03O3TcO(_c__DisplayClass48_.order.OrderNo).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aS44CUfR6tdgNLbdQbUH>, __ConfirmCancelPaymentOrderButton_Click_b__0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0089;
					case 0:
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<aS44CUfR6tdgNLbdQbUH>);
						num = (__1__state = -1);
						goto IL_0089;
					case 1:
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0102;
					case 2:
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter);
							num = (__1__state = -1);
							break;
						}
						IL_0102:
						_u__.GetResult();
						_u__ = _c__DisplayClass48_.__4__this.ShowOrderAsync(_cancelledOrder_5__2, startPolling: false).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ConfirmCancelPaymentOrderButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						break;
						IL_0089:
						result = _u__2.GetResult();
						_cancelledOrder_5__2 = result;
						_c__DisplayClass48_.__4__this.StopPolling();
						_u__ = _c__DisplayClass48_.__4__this.RefreshOrdersAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ConfirmCancelPaymentOrderButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
						goto IL_0102;
					}
					_u__.GetResult();
					AppShell.Success("订单已取消，待支付限制已释放");
				}
				catch (global::System.Exception exception)
				{
					__1__state = -2;
					_cancelledOrder_5__2 = null;
					__t__builder.SetException(exception);
					return;
				}
				__1__state = -2;
				_cancelledOrder_5__2 = null;
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

		public aS44CUfR6tdgNLbdQbUH order;

		public PaymentOrdersPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass48_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ConfirmCancelPaymentOrderButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ConfirmCancelPaymentOrderButton_Click_b__0_d _ConfirmCancelPaymentOrderButton_Click_b__0_d = default(__ConfirmCancelPaymentOrderButton_Click_b__0_d);
			_ConfirmCancelPaymentOrderButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ConfirmCancelPaymentOrderButton_Click_b__0_d.__4__this = this;
			_ConfirmCancelPaymentOrderButton_Click_b__0_d.__1__state = -1;
			_ConfirmCancelPaymentOrderButton_Click_b__0_d.__t__builder.Start<__ConfirmCancelPaymentOrderButton_Click_b__0_d>(ref _ConfirmCancelPaymentOrderButton_Click_b__0_d);
			return _ConfirmCancelPaymentOrderButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ConfirmCancelPaymentOrderButton_Click_d__48 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0082;
				}
				__c__DisplayClass48_0 _c__DisplayClass48_ = (__c__DisplayClass48_0)new __c__DisplayClass48_0
				{
					__4__this = __4__this,
					order = paymentOrdersPage._currentOrder
				};
				if (_c__DisplayClass48_.order != null && _c__DisplayClass48_.order.Status == "pending")
				{
					((FlyoutBase)paymentOrdersPage.CancelOrderFlyout).Hide();
					((Control)paymentOrdersPage.CancelPaymentOrderButton).IsEnabled = false;
					goto IL_0082;
				}
				((FlyoutBase)paymentOrdersPage.CancelOrderFlyout).Hide();
				goto end_IL_0011;
				IL_0082:
					_c__DisplayClass48_ = default;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.RunAsync(_c__DisplayClass48_._ConfirmCancelPaymentOrderButton_Click_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ConfirmCancelPaymentOrderButton_Click_d__48>(ref _u__, ref this);
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
						Button cancelPaymentOrderButton = paymentOrdersPage.CancelPaymentOrderButton;
						aS44CUfR6tdgNLbdQbUH? currentOrder = paymentOrdersPage._currentOrder;
						((Control)cancelPaymentOrderButton).IsEnabled = ((currentOrder != null) ? currentOrder.Status : null) == "pending";
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
	private struct _MovePageAsync_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

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
			PaymentOrdersPage paymentOrdersPage = __4__this;
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
				int num2 = paymentOrdersPage._page + delta;
				if (num2 >= 1 && num2 <= paymentOrdersPage._totalPages)
				{
					paymentOrdersPage._page = num2;
					_u__ = AppShell.RunAsync(paymentOrdersPage.RefreshOrdersAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MovePageAsync_d__25>(ref _u__, ref this);
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
	private struct _OnNavigatedTo_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		public NavigationEventArgs e;

		private __c__DisplayClass18_0_6 __8__1;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_01e4;
					}
					__8__1 = (__c__DisplayClass18_0_6)new __c__DisplayClass18_0_6();
					__8__1.__4__this = __4__this;
					paymentOrdersPage.__n__0(e);
					object parameter = e.Parameter;
					PaymentOrderNavigationRequest request = (PaymentOrderNavigationRequest)((parameter is PaymentOrderNavigationRequest paymentOrderNavigationRequest) ? ((object)paymentOrderNavigationRequest) : ((object)((!(parameter is string orderNo)) ? null : new PaymentOrderNavigationRequest(orderNo, OpenPaymentPage: false, ""))));
					__8__1.request = request;
					paymentOrdersPage._servicePaymentOrderNo = __8__1.request?.OrderNo ?? string.Empty;
					paymentOrdersPage._servicePurchaseOrderNo = __8__1.request?.ServicePurchaseOrderNo ?? string.Empty;
					__8__1.requestedOrder = null;
					_u__ = AppShell.RunAsync(__8__1._OnNavigatedTo_b__0).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__18>(ref _u__, ref this);
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
				if (__8__1.requestedOrder != null)
				{
					_u__ = paymentOrdersPage.ShowPaymentDetailsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__18>(ref _u__, ref this);
						return;
					}
					goto IL_01e4;
				}
				goto end_IL_0011;
				IL_01e4:
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
	private struct _OpenPaymentLinkButton_Click_d__44 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00af;
				}
				aS44CUfR6tdgNLbdQbUH currentOrder = paymentOrdersPage._currentOrder;
				if (currentOrder != null && !string.IsNullOrWhiteSpace(currentOrder.PayUrl))
				{
					if (currentOrder.PayKind == "urlscheme")
					{
						AppShell.Info("该支付方式需要在手机微信中打开，请复制链接后在手机上使用");
					}
					_u__ = LaunchPaymentPageAsync(currentOrder).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenPaymentLinkButton_Click_d__44>(ref _u__, ref this);
						return;
					}
					goto IL_00af;
				}
				goto end_IL_0011;
				IL_00af:
				if (!_u__.GetResult())
				{
					AppShell.Warning("无法打开支付链接");
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
	private struct _PaymentOrderList_SelectionChanged_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0100;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0161;
				}
				__c__DisplayClass27_0_2 _c__DisplayClass27_0_ = (__c__DisplayClass27_0_2)new __c__DisplayClass27_0_2
				{
					__4__this = __4__this
				};
				if (paymentOrdersPage._refundDialog == null)
				{
					object selectedItem = ((Selector)paymentOrdersPage.PaymentOrderList).SelectedItem;
					_c__DisplayClass27_0_.order = (aS44CUfR6tdgNLbdQbUH)((selectedItem is aS44CUfR6tdgNLbdQbUH) ? selectedItem : null);
					if (_c__DisplayClass27_0_.order != null)
					{
						paymentOrdersPage.StopPolling();
						if (!string.Equals(_c__DisplayClass27_0_.order.OrderNo, paymentOrdersPage._servicePaymentOrderNo, (StringComparison)4))
						{
							paymentOrdersPage._servicePaymentOrderNo = string.Empty;
							paymentOrdersPage._servicePurchaseOrderNo = string.Empty;
						}
						_u__ = AppShell.RunAsync(_c__DisplayClass27_0_._PaymentOrderList_SelectionChanged_b__0).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PaymentOrderList_SelectionChanged_d__27>(ref _u__, ref this);
							return;
						}
						goto IL_0100;
					}
				}
				goto end_IL_0011;
				IL_0161:
				_u__.GetResult();
				goto end_IL_0011;
				IL_0100:
				_u__.GetResult();
				_u__ = paymentOrdersPage.ShowPaymentDetailsAsync().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PaymentOrderList_SelectionChanged_d__27>(ref _u__, ref this);
					return;
				}
				goto IL_0161;
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
	private struct _PollOrderAsync_d__35 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public CancellationToken cancellationToken;

		public string orderNo;

		public PaymentOrdersPage __4__this;

		private aS44CUfR6tdgNLbdQbUH _order_5__2;

		private TaskAwaiter __u__1;

		private TaskAwaiter<aS44CUfR6tdgNLbdQbUH> __u__2;

		private hmrJXYfeLZEjdr5ehXqm _serviceOrder_5__3;

		private TaskAwaiter<hmrJXYfeLZEjdr5ehXqm> __u__3;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_019c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0397: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			//IL_0408: Unknown result type (might be due to invalid IL or missing references)
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0355: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0371: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0213: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0484: Unknown result type (might be due to invalid IL or missing references)
			//IL_0485: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				_ = 7;
				try
				{
					TaskAwaiter _u__ = default;
					TaskAwaiter<aS44CUfR6tdgNLbdQbUH> _u__3 = default;
					TaskAwaiter<hmrJXYfeLZEjdr5ehXqm> _u__2 = default;
					aS44CUfR6tdgNLbdQbUH result;
					hmrJXYfeLZEjdr5ehXqm result2;
					string status;
					switch (num)
					{
					case 0:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00ab;
					case 1:
						_u__3 = __u__2;
						__u__2 = default(TaskAwaiter<aS44CUfR6tdgNLbdQbUH>);
						num = (__1__state = -1);
						goto IL_0116;
					case 2:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_01b7;
					case 3:
						_u__2 = __u__3;
						__u__3 = default(TaskAwaiter<hmrJXYfeLZEjdr5ehXqm>);
						num = (__1__state = -1);
						goto IL_0267;
					case 4:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0325;
					case 5:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_03a6;
					case 6:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_041e;
					case 7:
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_04b9;
					default:
						{
							if (!cancellationToken.IsCancellationRequested)
							{
								_u__ = global::System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(2.0), cancellationToken).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
									return;
								}
								goto IL_00ab;
							}
							goto end_IL_0016;
						}
						IL_00ab:
						_u__.GetResult();
						_u__3 = AppShell.Api.PqJ0aaJCUJ(orderNo).GetAwaiter();
						if (!_u__3.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__3;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<aS44CUfR6tdgNLbdQbUH>, _PollOrderAsync_d__35>(ref _u__3, ref this);
							return;
						}
						goto IL_0116;
						IL_04b9:
						_u__.GetResult();
						break;
						IL_0116:
						result = _u__3.GetResult();
						_order_5__2 = result;
						if (paymentOrdersPage._detailDialogOpen)
						{
							aS44CUfR6tdgNLbdQbUH? currentOrder = paymentOrdersPage._currentOrder;
							if (string.Equals((currentOrder != null) ? currentOrder.OrderNo : null, orderNo, (StringComparison)4))
							{
								_u__ = paymentOrdersPage.ShowOrderAsync(_order_5__2, startPolling: false).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 2);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
									return;
								}
								goto IL_01b7;
							}
						}
						goto IL_01be;
						IL_03bc:
						paymentOrdersPage.StopPolling();
						goto end_IL_0016;
						IL_0325:
						_u__.GetResult();
						if (_serviceOrder_5__3.Status == "completed")
						{
							AppShell.Success("支付成功，服务套餐已开通");
							_u__ = AppShell.RefreshSummaryAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 5);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
								return;
							}
							goto IL_03a6;
						}
						AppShell.Error("支付已确认，但服务套餐开通异常，请联系管理员处理");
						goto IL_03bc;
						IL_0267:
						result2 = _u__2.GetResult();
						_serviceOrder_5__3 = result2;
						status = _serviceOrder_5__3.Status;
						if ((status == "pending_payment" || status == "paid_pending_fulfillment") ? true : false)
						{
							paymentOrdersPage.PaymentQrHintText.Text = "付款已确认，正在开通服务套餐。";
							goto default;
						}
						_u__ = paymentOrdersPage.RefreshOrdersAsync().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 4);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
							return;
						}
						goto IL_0325;
						IL_041e:
						_u__.GetResult();
						if (_order_5__2.Status == "paid")
						{
							AppShell.Success(_order_5__2.IsServiceSubscription ? "支付成功，服务套餐正在开通" : "充值已到账");
							_u__ = AppShell.RefreshSummaryAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 7);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
								return;
							}
							goto IL_04b9;
						}
						AppShell.Info("支付订单" + _order_5__2.StatusText);
						break;
						IL_03a6:
						_u__.GetResult();
						goto IL_03bc;
						IL_01b7:
						_u__.GetResult();
						goto IL_01be;
						IL_01be:
						if (!(_order_5__2.Status == "pending"))
						{
							if (_order_5__2.Status == "paid" && paymentOrdersPage.IsTrackedServicePayment(_order_5__2))
							{
								_u__2 = AppShell.Api.mei0b3AQTt(paymentOrdersPage._servicePurchaseOrderNo).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 3);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<hmrJXYfeLZEjdr5ehXqm>, _PollOrderAsync_d__35>(ref _u__2, ref this);
									return;
								}
								goto IL_0267;
							}
							_u__ = paymentOrdersPage.RefreshOrdersAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 6);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PollOrderAsync_d__35>(ref _u__, ref this);
								return;
							}
							goto IL_041e;
						}
						goto default;
					}
					paymentOrdersPage.StopPolling();
					end_IL_0016:;
				}
				catch (OperationCanceledException)
				{
				}
				catch (global::System.Exception ex2)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "ui-exception", "PollOrderAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\PaymentOrdersPage.xaml.cs", 402);
					AppShell.Error(ex2.Message);
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
	private struct _RefreshOrdersAsync_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		private TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY> __u__1;

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
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.aLB0v5viGX(paymentOrdersPage._page, 20).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<q2BJ1ifRPDNVJ0t9KrGY>, _RefreshOrdersAsync_d__24>(ref _u__, ref this);
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
				UiHelpers.Replace(paymentOrdersPage._orders, (global::System.Collections.Generic.IEnumerable<aS44CUfR6tdgNLbdQbUH>)result.Orders);
				paymentOrdersPage._page = ((p9WVlJf5a812Tn4S3TgP)result).Page;
				paymentOrdersPage._totalPages = ((p9WVlJf5a812Tn4S3TgP)result).TotalPages;
				paymentOrdersPage.OrderPager.SetState(((p9WVlJf5a812Tn4S3TgP)result).Page, ((p9WVlJf5a812Tn4S3TgP)result).TotalPages, ((p9WVlJf5a812Tn4S3TgP)result).Total);
				((UIElement)paymentOrdersPage.EmptyOrderPanel).Visibility = (((((Collection<aS44CUfR6tdgNLbdQbUH>)(object)paymentOrdersPage._orders).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
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
	private struct _RefreshOrdersButton_Click_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

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
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync(paymentOrdersPage.RefreshOrdersAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshOrdersButton_Click_d__26>(ref _u__, ref this);
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
	private struct _RefundOrderButton_Click_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		public object sender;

		private long? _ownerId_5__2;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00c2;
				}
				__c__DisplayClass1_0 _c__DisplayClass1_ = (__c__DisplayClass1_0)new __c__DisplayClass1_0();
				if (paymentOrdersPage._refundDialog == null && !paymentOrdersPage._detailDialogOpen)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						if (tag is long)
						{
							_c__DisplayClass1_.orderId = (long)tag;
							if (Enumerable.Any<aS44CUfR6tdgNLbdQbUH>((global::System.Collections.Generic.IEnumerable<aS44CUfR6tdgNLbdQbUH>)paymentOrdersPage._orders, (Func<aS44CUfR6tdgNLbdQbUH, bool>)_c__DisplayClass1_._RefundOrderButton_Click_b__0))
							{
								dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
								_ownerId_5__2 = ((currentUser != null) ? new long?(currentUser.Id) : ((long?)null));
								goto IL_00c2;
							}
						}
					}
				}
				goto end_IL_0011;
				IL_00c2:
					_c__DisplayClass1_ = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						paymentOrdersPage.StopPolling();
						object userRefundRequestDialog = (object)new UserRefundRequestDialog(_c__DisplayClass1_.orderId);
						((UIElement)userRefundRequestDialog).XamlRoot = ((UIElement)paymentOrdersPage).XamlRoot;
						((FrameworkElement)userRefundRequestDialog).RequestedTheme = ((FrameworkElement)paymentOrdersPage).ActualTheme;
						paymentOrdersPage._refundDialog = (UserRefundRequestDialog?)userRefundRequestDialog;
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(((ContentDialog)paymentOrdersPage._refundDialog).ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _RefundOrderButton_Click_d__1>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
				}
				catch (global::System.Exception exception)
				{
					if (_ownerId_5__2.HasValue)
					{
						dN4xMCftS2WHJlRJeqrU currentUser2 = AppShell.Api.CurrentUser;
						if ((currentUser2 != null) ? (currentUser2.Id == _ownerId_5__2) : (!_ownerId_5__2.HasValue))
						{
							AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "RefundOrderButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\PaymentOrdersPage.Refunds.cs", 25));
						}
					}
				}
				finally
				{
					if (num < 0)
					{
						paymentOrdersPage._refundDialog = null;
						((Selector)paymentOrdersPage.PaymentOrderList).SelectedItem = null;
					}
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
	private struct _RenderPaymentQrAsync_d__31 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		public string value;

		private QRCodeGenerator _generator_5__2;

		private QRCoder.QRCodeData _data_5__3;

		private InMemoryRandomAccessStream _stream_5__4;

		private BitmapImage _bitmap_5__5;

		private TaskAwaiter<uint> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Expected O, but got Unknown
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Expected O, but got Unknown
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0174: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0045;
				}
				paymentOrdersPage.PaymentQrImage.Source = null;
				if (!string.IsNullOrWhiteSpace(value))
				{
					_generator_5__2 = new QRCodeGenerator();
					goto IL_0045;
				}
				goto end_IL_0011;
				IL_0045:
				try
				{
					if ((uint)num > 1u)
					{
						_data_5__3 = _generator_5__2.CreateQrCode(value, (QRCodeGenerator.ECCLevel)2, false, false, (QRCodeGenerator.EciMode)0, -1);
					}
					try
					{
						byte[] graphic = default(byte[]);
						if ((uint)num > 1u)
						{
							graphic = new PngByteQRCode(_data_5__3).GetGraphic(8, true);
							_stream_5__4 = new InMemoryRandomAccessStream();
						}
						try
						{
							TaskAwaiter _u__ = default;
							TaskAwaiter<uint> _u__2 = default;
							if (num != 0)
							{
								if (num == 1)
								{
									_u__ = __u__2;
									__u__2 = default(TaskAwaiter);
									num = (__1__state = -1);
									goto IL_0183;
								}
								_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<uint, uint>(_stream_5__4.WriteAsync(WindowsRuntimeBufferExtensions.AsBuffer(graphic)));
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<uint>, _RenderPaymentQrAsync_d__31>(ref _u__2, ref this);
									return;
								}
							}
							else
							{
								_u__2 = __u__1;
								__u__1 = default(TaskAwaiter<uint>);
								num = (__1__state = -1);
							}
							_u__2.GetResult();
							_stream_5__4.Seek(0uL);
							_bitmap_5__5 = new BitmapImage();
							_u__ = WindowsRuntimeSystemExtensions.GetAwaiter(((BitmapSource)_bitmap_5__5).SetSourceAsync((IRandomAccessStream)(object)_stream_5__4));
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RenderPaymentQrAsync_d__31>(ref _u__, ref this);
								return;
							}
							goto IL_0183;
							IL_0183:
							_u__.GetResult();
							paymentOrdersPage.PaymentQrImage.Source = (ImageSource)(object)_bitmap_5__5;
						}
						finally
						{
							if (num < 0 && _stream_5__4 != null)
							{
								((global::System.IDisposable)_stream_5__4).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && _data_5__3 != null)
						{
							((global::System.IDisposable)_data_5__3).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _generator_5__2 != null)
					{
						((global::System.IDisposable)_generator_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_generator_5__2 = null;
				_data_5__3 = null;
				_stream_5__4 = null;
				_bitmap_5__5 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_generator_5__2 = null;
			_data_5__3 = null;
			_stream_5__4 = null;
			_bitmap_5__5 = null;
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
	private struct _ShowOrderAsync_d__29 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		public aS44CUfR6tdgNLbdQbUH order;

		public bool startPolling;

		private bool _providerQrLoaded_5__2;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num != 0)
				{
					TaskAwaiter _u__2 = default;
					if (num != 1)
					{
						paymentOrdersPage._currentOrder = order;
						paymentOrdersPage.CurrentPaymentChannelText.Text = order.ChannelName;
						paymentOrdersPage.CurrentPaymentAmountText.Text = PaymentAmountSummary(order);
						paymentOrdersPage.CurrentPaymentFeeText.Text = order.DisplayFeeText;
						((UIElement)paymentOrdersPage.CurrentPaymentFeeText).Visibility = ((string.IsNullOrEmpty(order.DisplayFeeText) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
						paymentOrdersPage.CurrentPaymentOrderNoText.Text = order.OrderNo;
						paymentOrdersPage.CurrentPaymentExpiryText.Text = $"有效期至 {order.ExpiresAt.ToLocalTime():yyyy-MM-dd HH:mm:ss}";
						paymentOrdersPage.ApplyStatusPill(order);
						_providerQrLoaded_5__2 = false;
						if (UsesProviderQr(order))
						{
							_u__ = paymentOrdersPage.TryRenderProviderQrAsync(order).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _ShowOrderAsync_d__29>(ref _u__, ref this);
								return;
							}
							goto IL_0173;
						}
						paymentOrdersPage.ResetProviderQrState();
						bool flag = order.Status == "pending" && order.PayKind != "payurl" && order.PayKind != "urlscheme";
						_u__2 = paymentOrdersPage.RenderPaymentQrAsync(flag ? PaymentQrSource(order) : string.Empty).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 1);
							__u__2 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ShowOrderAsync_d__29>(ref _u__2, ref this);
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
					goto IL_025d;
				}
				_u__ = __u__1;
				__u__1 = default(TaskAwaiter<bool>);
				num = (__1__state = -1);
				goto IL_0173;
				IL_025d:
				((UIElement)paymentOrdersPage.PaymentQrPanel).Visibility = ((paymentOrdersPage.PaymentQrImage.Source == null) ? Visibility.Visible : Visibility.Collapsed);
				paymentOrdersPage.ApplyPaymentHint(order, _providerQrLoaded_5__2);
				bool flag2 = order.Status == "pending";
				bool flag3 = flag2 && !string.IsNullOrWhiteSpace(order.PayUrl);
				bool flag4 = flag2 && (flag3 || !string.IsNullOrWhiteSpace(order.QrUrl));
				((UIElement)paymentOrdersPage.OpenPaymentLinkButton).Visibility = ((!flag3) ? Visibility.Visible : Visibility.Collapsed);
				((UIElement)paymentOrdersPage.CopyPaymentLinkButton).Visibility = ((!flag4) ? Visibility.Visible : Visibility.Collapsed);
				((UIElement)paymentOrdersPage.CancelPaymentOrderButton).Visibility = ((!flag2) ? Visibility.Visible : Visibility.Collapsed);
				((Control)paymentOrdersPage.CancelPaymentOrderButton).IsEnabled = flag2;
				((UIElement)paymentOrdersPage.CancelPaymentHintText).Visibility = ((!flag2) ? Visibility.Visible : Visibility.Collapsed);
				if (startPolling && (order.Status == "pending" || paymentOrdersPage.IsTrackedServicePayment(order)))
				{
					paymentOrdersPage.StartPolling(order.OrderNo);
				}
				goto end_IL_0011;
				IL_0173:
				bool result = _u__.GetResult();
				_providerQrLoaded_5__2 = result;
				goto IL_025d;
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
	private struct _ShowPaymentDetailsAsync_d__28 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public PaymentOrdersPage __4__this;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			PaymentOrdersPage paymentOrdersPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_007c;
				}
				if (!paymentOrdersPage._detailDialogOpen && paymentOrdersPage._currentOrder != null)
				{
					XamlRoot xamlRoot = AppShell.XamlRoot;
					if (xamlRoot != null)
					{
						((UIElement)paymentOrdersPage.PaymentDetailDialog).XamlRoot = xamlRoot;
						paymentOrdersPage.PaymentDetailDialog.Title = (paymentOrdersPage._currentOrder.IsServiceSubscription ? "服务套餐付款" : "充值付款");
						paymentOrdersPage._detailDialogOpen = true;
						goto IL_007c;
					}
				}
				goto end_IL_0011;
				IL_007c:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(paymentOrdersPage.PaymentDetailDialog.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowPaymentDetailsAsync_d__28>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
				}
				finally
				{
					if (num < 0)
					{
						paymentOrdersPage._detailDialogOpen = false;
						paymentOrdersPage.StopPolling();
						((Selector)paymentOrdersPage.PaymentOrderList).SelectedItem = null;
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

	private UserRefundRequestDialog? _refundDialog;

	private readonly ObservableCollection<aS44CUfR6tdgNLbdQbUH> _orders;

	private aS44CUfR6tdgNLbdQbUH? _currentOrder;

	private CancellationTokenSource? _pollingCts;

	private string _providerQrOrderNo;

	private string _providerQrSource;

	private string _servicePaymentOrderNo;

	private string _servicePurchaseOrderNo;

	private bool _detailDialogOpen;

	private DateTimeOffset _providerQrRetryAt;

	private int _page;

	private int _totalPages;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ContentDialog PaymentDetailDialog;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaymentFeeText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CancelPaymentHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CancelPaymentOrderButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Flyout CancelOrderFlyout;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button OpenPaymentLinkButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CopyPaymentLinkButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaymentChannelText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaymentAmountText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaymentExpiryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaymentOrderNoText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CurrentPaidPill;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CurrentPendingPill;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CurrentFailedPill;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border CurrentOtherPill;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentOtherPillText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock CurrentPaidPillText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Border PaymentQrPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PaymentQrHintText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image PaymentQrImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PagerBar OrderPager;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView PaymentOrderList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyOrderPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IPaymentOrdersPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefundOrderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefundOrderButton_Click_d__1 refundOrderButton_Click_d__ = default(_RefundOrderButton_Click_d__1);
		refundOrderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refundOrderButton_Click_d__.__4__this = this;
		refundOrderButton_Click_d__.sender = sender;
		refundOrderButton_Click_d__.__1__state = -1;
		refundOrderButton_Click_d__.__t__builder.Start<_RefundOrderButton_Click_d__1>(ref refundOrderButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility PaidPillVisibility(string status)
	{
		if (status == "paid")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility PendingPillVisibility(string status)
	{
		if (status == "pending")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility FailedPillVisibility(string status)
	{
		if (status == "failed")
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility OtherPillVisibility(string status)
	{
		if ((status == "paid" || status == "pending" || status == "failed") ? true : false)
		{
			return (Visibility)1;
		}
		return (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	public PaymentOrdersPage()
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		_orders = new ObservableCollection<aS44CUfR6tdgNLbdQbUH>();
		_providerQrOrderNo = string.Empty;
		_providerQrSource = string.Empty;
		_servicePaymentOrderNo = string.Empty;
		_servicePurchaseOrderNo = string.Empty;
		_providerQrRetryAt = DateTimeOffset.MinValue;
		_page = 1;
		_totalPages = 1;
		InitializeComponent();
		((ItemsControl)PaymentOrderList).ItemsSource = _orders;
		OrderPager.PreviousRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__17_0_d __ctor_b__17_0_d = default(___ctor_b__17_0_d);
			__ctor_b__17_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__17_0_d.__4__this = this;
			__ctor_b__17_0_d.__1__state = -1;
			__ctor_b__17_0_d.__t__builder.Start<___ctor_b__17_0_d>(ref __ctor_b__17_0_d);
		});
		OrderPager.NextRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__17_1_d __ctor_b__17_1_d = default(___ctor_b__17_1_d);
			__ctor_b__17_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__17_1_d.__4__this = this;
			__ctor_b__17_1_d.__1__state = -1;
			__ctor_b__17_1_d.__t__builder.Start<___ctor_b__17_1_d>(ref __ctor_b__17_1_d);
		});
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__18 onNavigatedTo_d__ = default(_OnNavigatedTo_d__18);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__18>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task RefreshForShellAsync()
	{
		return RefreshOrdersAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	protected override void OnNavigatedFrom(NavigationEventArgs e)
	{
		_refundDialog?.Clear();
		base.OnNavigatedFrom(e);
		StopPolling();
		if (_detailDialogOpen)
		{
			PaymentDetailDialog.Hide();
		}
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
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		_refundDialog?.Clear();
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		StopPolling();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		_refundDialog?.Clear();
		StopPolling();
		((Collection<aS44CUfR6tdgNLbdQbUH>)(object)_orders).Clear();
		_currentOrder = null;
		_servicePaymentOrderNo = string.Empty;
		_servicePurchaseOrderNo = string.Empty;
		ResetProviderQrState();
		_page = 1;
		_totalPages = 1;
		if (_detailDialogOpen)
		{
			PaymentDetailDialog.Hide();
		}
		((UIElement)EmptyOrderPanel).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshOrdersAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshOrdersAsync_d__24 refreshOrdersAsync_d__ = default(_RefreshOrdersAsync_d__24);
		refreshOrdersAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshOrdersAsync_d__.__4__this = this;
		refreshOrdersAsync_d__.__1__state = -1;
		refreshOrdersAsync_d__.__t__builder.Start<_RefreshOrdersAsync_d__24>(ref refreshOrdersAsync_d__);
		return refreshOrdersAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MovePageAsync(int delta)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MovePageAsync_d__25 movePageAsync_d__ = default(_MovePageAsync_d__25);
		movePageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		movePageAsync_d__.__4__this = this;
		movePageAsync_d__.delta = delta;
		movePageAsync_d__.__1__state = -1;
		movePageAsync_d__.__t__builder.Start<_MovePageAsync_d__25>(ref movePageAsync_d__);
		return movePageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshOrdersButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshOrdersButton_Click_d__26 refreshOrdersButton_Click_d__ = default(_RefreshOrdersButton_Click_d__26);
		refreshOrdersButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshOrdersButton_Click_d__.__4__this = this;
		refreshOrdersButton_Click_d__.__1__state = -1;
		refreshOrdersButton_Click_d__.__t__builder.Start<_RefreshOrdersButton_Click_d__26>(ref refreshOrdersButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PaymentOrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PaymentOrderList_SelectionChanged_d__27 paymentOrderList_SelectionChanged_d__ = default(_PaymentOrderList_SelectionChanged_d__27);
		paymentOrderList_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		paymentOrderList_SelectionChanged_d__.__4__this = this;
		paymentOrderList_SelectionChanged_d__.__1__state = -1;
		paymentOrderList_SelectionChanged_d__.__t__builder.Start<_PaymentOrderList_SelectionChanged_d__27>(ref paymentOrderList_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowPaymentDetailsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowPaymentDetailsAsync_d__28 showPaymentDetailsAsync_d__ = default(_ShowPaymentDetailsAsync_d__28);
		showPaymentDetailsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showPaymentDetailsAsync_d__.__4__this = this;
		showPaymentDetailsAsync_d__.__1__state = -1;
		showPaymentDetailsAsync_d__.__t__builder.Start<_ShowPaymentDetailsAsync_d__28>(ref showPaymentDetailsAsync_d__);
		return showPaymentDetailsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowOrderAsync(aS44CUfR6tdgNLbdQbUH order, bool startPolling)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowOrderAsync_d__29 showOrderAsync_d__ = default(_ShowOrderAsync_d__29);
		showOrderAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showOrderAsync_d__.__4__this = this;
		showOrderAsync_d__.order = order;
		showOrderAsync_d__.startPolling = startPolling;
		showOrderAsync_d__.__1__state = -1;
		showOrderAsync_d__.__t__builder.Start<_ShowOrderAsync_d__29>(ref showOrderAsync_d__);
		return showOrderAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyStatusPill(aS44CUfR6tdgNLbdQbUH order)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		((UIElement)CurrentPaidPill).Visibility = PaidPillVisibility(order.Status);
		((UIElement)CurrentPendingPill).Visibility = PendingPillVisibility(order.Status);
		((UIElement)CurrentFailedPill).Visibility = FailedPillVisibility(order.Status);
		((UIElement)CurrentOtherPill).Visibility = OtherPillVisibility(order.Status);
		CurrentPaidPillText.Text = order.PaidStatusText;
		CurrentOtherPillText.Text = order.StatusText;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RenderPaymentQrAsync(string value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RenderPaymentQrAsync_d__31 renderPaymentQrAsync_d__ = default(_RenderPaymentQrAsync_d__31);
		renderPaymentQrAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		renderPaymentQrAsync_d__.__4__this = this;
		renderPaymentQrAsync_d__.value = value;
		renderPaymentQrAsync_d__.__1__state = -1;
		renderPaymentQrAsync_d__.__t__builder.Start<_RenderPaymentQrAsync_d__31>(ref renderPaymentQrAsync_d__);
		return renderPaymentQrAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private async global::System.Threading.Tasks.Task<bool> TryRenderProviderQrAsync(aS44CUfR6tdgNLbdQbUH order)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!string.Equals(_providerQrOrderNo, order.OrderNo, (StringComparison)4))
		{
			PaymentQrImage.Source = null;
			_providerQrOrderNo = order.OrderNo;
			_providerQrSource = string.Empty;
			_providerQrRetryAt = DateTimeOffset.MinValue;
		}
		if (PaymentQrImage.Source != null)
		{
			return true;
		}
		DateTimeOffset utcNow = DateTimeOffset.UtcNow;
		if (utcNow < _providerQrRetryAt)
		{
			return false;
		}
		try
		{
			XddOLEfRwuQfFXUTbiv1 val = await AppShell.Api.jxk01Na0mG(order.OrderNo);
			BitmapImage source = await PaymentQrImageDecoder.DecodeAsync(val.DataUrl);
			aS44CUfR6tdgNLbdQbUH? currentOrder = _currentOrder;
			if (!string.Equals((currentOrder != null) ? currentOrder.OrderNo : null, order.OrderNo, (StringComparison)4) || !string.Equals(_providerQrOrderNo, order.OrderNo, (StringComparison)4))
			{
				return false;
			}
			PaymentQrImage.Source = (ImageSource)(object)source;
			_providerQrSource = val.Source;
			_providerQrRetryAt = DateTimeOffset.MaxValue;
			int? payAmountCents = val.PayAmountCents;
			if (payAmountCents.HasValue)
			{
				int valueOrDefault = payAmountCents.GetValueOrDefault();
				order.PayAmountCents = valueOrDefault;
				CurrentPaymentAmountText.Text = PaymentAmountSummary(order);
			}
			return true;
		}
		catch (global::System.Exception)
		{
			if (string.Equals(_providerQrOrderNo, order.OrderNo, (StringComparison)4))
			{
				_providerQrRetryAt = utcNow.AddSeconds(5.0);
			}
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ResetProviderQrState()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		PaymentQrImage.Source = null;
		_providerQrOrderNo = string.Empty;
		_providerQrSource = string.Empty;
		_providerQrRetryAt = DateTimeOffset.MinValue;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StartPolling(string orderNo)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		StopPolling();
		_pollingCts = new CancellationTokenSource();
		PollOrderAsync(orderNo, _pollingCts.Token);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task PollOrderAsync(string orderNo, CancellationToken cancellationToken)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_PollOrderAsync_d__35 pollOrderAsync_d__ = default(_PollOrderAsync_d__35);
		pollOrderAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		pollOrderAsync_d__.__4__this = this;
		pollOrderAsync_d__.orderNo = orderNo;
		pollOrderAsync_d__.cancellationToken = cancellationToken;
		pollOrderAsync_d__.__1__state = -1;
		pollOrderAsync_d__.__t__builder.Start<_PollOrderAsync_d__35>(ref pollOrderAsync_d__);
		return pollOrderAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void StopPolling()
	{
		CancellationTokenSource? pollingCts = _pollingCts;
		if (pollingCts != null)
		{
			pollingCts.Cancel();
		}
		CancellationTokenSource? pollingCts2 = _pollingCts;
		if (pollingCts2 != null)
		{
			pollingCts2.Dispose();
		}
		_pollingCts = null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PaymentQrSource(aS44CUfR6tdgNLbdQbUH order)
	{
		if (!string.IsNullOrWhiteSpace(order.QrUrl))
		{
			return order.QrUrl;
		}
		return order.PayUrl;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool IsTrackedServicePayment(aS44CUfR6tdgNLbdQbUH order)
	{
		if (order.IsServiceSubscription && !string.IsNullOrWhiteSpace(_servicePurchaseOrderNo))
		{
			return string.Equals(order.OrderNo, _servicePaymentOrderNo, (StringComparison)4);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PaymentAmountSummary(aS44CUfR6tdgNLbdQbUH order)
	{
		if (order.ChannelCode == "paypal" && !string.IsNullOrEmpty(order.ProviderAmount))
		{
			if (!order.IsServiceSubscription)
			{
				return $"{order.PayAmountText} → {order.CreditAmount:0.00} 余额";
			}
			return order.PayAmountText;
		}
		if (!order.HasAmountDrift)
		{
			return order.AmountText;
		}
		string text = $"实付 ¥ {order.EffectivePayAmountCents / 100m:0.00}（下单 {order.AmountCents / 100m:0.00}）";
		if (!order.IsServiceSubscription)
		{
			return $"{text} → {order.CreditAmount:0.00} 余额";
		}
		return text;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool UsesProviderQr(aS44CUfR6tdgNLbdQbUH order)
	{
		if (order.Status == "pending" && (order.ChannelCode == "epay" || order.ChannelCode == "xunhupay" || order.ChannelCode == "paypal"))
		{
			return order.PayKind == "payurl";
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyPaymentHint(aS44CUfR6tdgNLbdQbUH order, bool providerQrLoaded)
	{
		if (order.Status != "pending")
		{
			TextBlock paymentQrHintText = PaymentQrHintText;
			string status = order.Status;
			string text = ((!(status == "paid")) ? ((status == "cancelled") ? "订单已取消。" : ((!(status == "expired")) ? "订单处理失败，请稍后重试或联系管理员。" : "订单已过期。")) : ((!order.IsServiceSubscription) ? "订单已支付并到账。" : "付款已确认，服务套餐正在开通或已经开通。"));
			paymentQrHintText.Text = text;
		}
		else
		{
			bool flag = order.PayKind == "payurl";
			TextBlock paymentQrHintText = PaymentQrHintText;
			string text = order.PayKind;
			string status = ((!(text == "payurl")) ? ((!(text == "urlscheme")) ? "使用对应支付 App 扫码完成支付。" : "该支付方式需要在手机微信中打开支付链接。") : ((order.ChannelCode == "paypal") ? "点击支付链接前往 PayPal，或使用手机相机扫描二维码打开 PayPal 收银台；服务端确认收款后到账。" : ((order.ChannelCode == "xunhupay" && providerQrLoaded) ? "请使用对应支付 App 扫码付款，虎皮椒二维码有效期为 5 分钟。" : ((order.ChannelCode == "xunhupay" && string.IsNullOrWhiteSpace(order.PayUrl)) ? "虎皮椒二维码暂未就绪，正在重试加载。" : ((providerQrLoaded && _providerQrSource == "provider") ? "二维码来自支付站，请使用对应支付 App 扫码付款；最终实付金额以支付站页面为准。" : ((!providerQrLoaded) ? "支付二维码暂未就绪，可前往支付站完成付款。" : "请使用对应支付 App 扫码打开收银台；最终实付金额以支付站页面为准。"))))));
			paymentQrHintText.Text = status;
			((ContentControl)OpenPaymentLinkButton).Content = ((order.ChannelCode == "paypal") ? "前往 PayPal 支付" : (flag ? "前往支付" : "打开支付链接"));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsExternalPayment(aS44CUfR6tdgNLbdQbUH order)
	{
		if (order.PayKind == "payurl")
		{
			return !string.IsNullOrWhiteSpace(order.PayUrl);
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<bool> LaunchPaymentPageAsync(aS44CUfR6tdgNLbdQbUH order)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Uri val = default(Uri);
		if (!Uri.TryCreate(order.PayUrl, (UriKind)1, out val))
		{
			return false;
		}
		TaskAwaiter<bool> val2 = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(val));
		if (!val2.IsCompleted)
		{
			val2.GetResult();
			TaskAwaiter<bool> val3 = default(TaskAwaiter<bool>);
			val2 = val3;
		}
		return val2.GetResult();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OpenPaymentLinkButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenPaymentLinkButton_Click_d__44 openPaymentLinkButton_Click_d__ = default(_OpenPaymentLinkButton_Click_d__44);
		openPaymentLinkButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		openPaymentLinkButton_Click_d__.__4__this = this;
		openPaymentLinkButton_Click_d__.__1__state = -1;
		openPaymentLinkButton_Click_d__.__t__builder.Start<_OpenPaymentLinkButton_Click_d__44>(ref openPaymentLinkButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyOrderNoButton_Click(object sender, RoutedEventArgs e)
	{
		aS44CUfR6tdgNLbdQbUH? currentOrder = _currentOrder;
		string text = ((currentOrder != null) ? currentOrder.OrderNo : null) ?? string.Empty;
		if (!string.IsNullOrWhiteSpace(text))
		{
			UiHelpers.CopyToClipboard(text);
			AppShell.Info("订单号已复制");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyPaymentLinkButton_Click(object sender, RoutedEventArgs e)
	{
		aS44CUfR6tdgNLbdQbUH? currentOrder = _currentOrder;
		object obj;
		if (!string.IsNullOrWhiteSpace((currentOrder != null) ? currentOrder.PayUrl : null))
		{
			obj = _currentOrder.PayUrl;
		}
		else
		{
			aS44CUfR6tdgNLbdQbUH? currentOrder2 = _currentOrder;
			obj = ((currentOrder2 != null) ? currentOrder2.QrUrl : null) ?? string.Empty;
		}
		string text = (string)obj;
		if (!string.IsNullOrWhiteSpace(text))
		{
			UiHelpers.CopyToClipboard(text);
			AppShell.Info("支付链接已复制");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void DismissCancelPaymentOrderButton_Click(object sender, RoutedEventArgs e)
	{
		((FlyoutBase)CancelOrderFlyout).Hide();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ConfirmCancelPaymentOrderButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ConfirmCancelPaymentOrderButton_Click_d__48 confirmCancelPaymentOrderButton_Click_d__ = default(_ConfirmCancelPaymentOrderButton_Click_d__48);
		confirmCancelPaymentOrderButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		confirmCancelPaymentOrderButton_Click_d__.__4__this = this;
		confirmCancelPaymentOrderButton_Click_d__.__1__state = -1;
		confirmCancelPaymentOrderButton_Click_d__.__t__builder.Start<_ConfirmCancelPaymentOrderButton_Click_d__48>(ref confirmCancelPaymentOrderButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/PaymentOrdersPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02be: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PaymentDetailDialog = CastExtensions.As<ContentDialog>(target);
			break;
		case 3:
			CurrentPaymentFeeText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			CancelPaymentHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 5:
			CancelPaymentOrderButton = CastExtensions.As<Button>(target);
			break;
		case 6:
			CancelOrderFlyout = CastExtensions.As<Flyout>(target);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DismissCancelPaymentOrderButton_Click);
			break;
		case 8:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ConfirmCancelPaymentOrderButton_Click);
			break;
		case 9:
			OpenPaymentLinkButton = CastExtensions.As<Button>(target);
			((ButtonBase)OpenPaymentLinkButton).Click += new RoutedEventHandler(OpenPaymentLinkButton_Click);
			break;
		case 10:
			CopyPaymentLinkButton = CastExtensions.As<Button>(target);
			((ButtonBase)CopyPaymentLinkButton).Click += new RoutedEventHandler(CopyPaymentLinkButton_Click);
			break;
		case 11:
			CurrentPaymentChannelText = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			CurrentPaymentAmountText = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			CurrentPaymentExpiryText = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			CurrentPaymentOrderNoText = CastExtensions.As<TextBlock>(target);
			break;
		case 15:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyOrderNoButton_Click);
			break;
		case 16:
			CurrentPaidPill = CastExtensions.As<Border>(target);
			break;
		case 17:
			CurrentPendingPill = CastExtensions.As<Border>(target);
			break;
		case 18:
			CurrentFailedPill = CastExtensions.As<Border>(target);
			break;
		case 19:
			CurrentOtherPill = CastExtensions.As<Border>(target);
			break;
		case 20:
			CurrentOtherPillText = CastExtensions.As<TextBlock>(target);
			break;
		case 21:
			CurrentPaidPillText = CastExtensions.As<TextBlock>(target);
			break;
		case 22:
			PaymentQrPanel = CastExtensions.As<Border>(target);
			break;
		case 23:
			PaymentQrHintText = CastExtensions.As<TextBlock>(target);
			break;
		case 24:
			PaymentQrImage = CastExtensions.As<Image>(target);
			break;
		case 25:
			OrderPager = CastExtensions.As<PagerBar>(target);
			break;
		case 26:
			PaymentOrderList = CastExtensions.As<ListView>(target);
			((Selector)PaymentOrderList).SelectionChanged += new SelectionChangedEventHandler(PaymentOrderList_SelectionChanged);
			break;
		case 27:
			EmptyOrderPanel = CastExtensions.As<StackPanel>(target);
			break;
		case 35:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefundOrderButton_Click);
			break;
		case 42:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefreshOrdersButton_Click);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		IComponentConnector result = null;
		if (connectionId == 29)
		{
			Grid val = (Grid)target;
			PaymentOrdersPage_obj29_Bindings paymentOrdersPage_obj29_Bindings = (PaymentOrdersPage_obj29_Bindings)new PaymentOrdersPage_obj29_Bindings();
			result = (IComponentConnector)(object)paymentOrdersPage_obj29_Bindings;
			paymentOrdersPage_obj29_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += paymentOrdersPage_obj29_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)paymentOrdersPage_obj29_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)paymentOrdersPage_obj29_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__17_0(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__17_0_d __ctor_b__17_0_d = default(___ctor_b__17_0_d);
		__ctor_b__17_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__17_0_d.__4__this = this;
		__ctor_b__17_0_d.__1__state = -1;
		__ctor_b__17_0_d.__t__builder.Start<___ctor_b__17_0_d>(ref __ctor_b__17_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__17_1(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__17_1_d __ctor_b__17_1_d = default(___ctor_b__17_1_d);
		__ctor_b__17_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__17_1_d.__4__this = this;
		__ctor_b__17_1_d.__1__state = -1;
		__ctor_b__17_1_d.__t__builder.Start<___ctor_b__17_1_d>(ref __ctor_b__17_1_d);
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

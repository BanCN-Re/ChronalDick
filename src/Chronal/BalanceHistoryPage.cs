using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using Microsoft.UI.Xaml.Shapes;
using WinRT;
using WinRT.ChronalVtableClasses;
using e38ZmBf51OoNmYc9Uj20;
using k9Y5SHf5vZRCDBjsD8Rb;
using pbEuRhf52wNAGEpBF2sM;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class BalanceHistoryPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IBalanceHistoryPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IBalanceHistoryPage_BindingsScopeConnector
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class BalanceHistoryPage_obj6_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IBalanceHistoryPage_Bindings
	{
		private delegate void InvokeFunctionDelegate(int phase);

		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class BalanceHistoryPage_obj6_BindingsTracking
		{
			private WeakReference<BalanceHistoryPage_obj6_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public BalanceHistoryPage_obj6_BindingsTracking(BalanceHistoryPage_obj6_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<BalanceHistoryPage_obj6_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public BalanceHistoryPage_obj6_Bindings TryGetBindingObject()
			{
				BalanceHistoryPage_obj6_Bindings balanceHistoryPage_obj6_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out balanceHistoryPage_obj6_Bindings);
					if (balanceHistoryPage_obj6_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return balanceHistoryPage_obj6_Bindings;
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

		private P4we1Nf53qYVoxPlZyvG dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj6;

		private TextBlock obj7;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private Ellipse obj14;

		private Ellipse obj15;

		private Ellipse obj16;

		private BalanceHistoryPage_obj6_BindingsTracking bindingsTracking;

		private Dictionary<string, InvokeFunctionDelegate> PendingFunctionBindings;

		[MethodImpl((MethodImplOptions)8)]
		public BalanceHistoryPage_obj6_Bindings()
		{
			PendingFunctionBindings = new Dictionary<string, InvokeFunctionDelegate>();
			bindingsTracking = (BalanceHistoryPage_obj6_BindingsTracking)new BalanceHistoryPage_obj6_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Expected O, but got Unknown
			switch (connectionId)
			{
			case 6:
				obj6 = new WeakReference((object)CastExtensions.As<Grid>(target));
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
				obj11 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<Ellipse>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<Ellipse>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<Ellipse>(target);
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
			object target = obj6.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<P4we1Nf53qYVoxPlZyvG>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<P4we1Nf53qYVoxPlZyvG>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool TryGet_Amount(out decimal val)
		{
			if (TryGet_(out var val2) && val2 != null)
			{
				val = val2.Amount;
				return true;
			}
			val = default(decimal);
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool TryGet_(out P4we1Nf53qYVoxPlZyvG val)
		{
			//IL_000b: Expected I8, but got O
			val = (P4we1Nf53qYVoxPlZyvG)dataRoot;
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool TryGet_Type(out string val)
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
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Amount(out var val))
			{
				Visibility value = PositiveAmountVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj10, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Amount(out var val))
			{
				Visibility value = NegativeAmountVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj11, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Amount(out var val))
			{
				Visibility value = ZeroAmountVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj12, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Type(out var val))
			{
				Visibility value = IncomeDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj14, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Type(out var val))
			{
				Visibility value = ExpenseDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj15, value);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990(int phase)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			if (TryGet_Type(out var val))
			{
				Visibility value = NeutralDotVisibility(val);
				if ((phase & -2147483647) != 0)
				{
					XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj16, value);
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
		private void Update_(P4we1Nf53qYVoxPlZyvG obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_BalanceText(obj.BalanceText, phase);
				Update_ReasonText(obj.ReasonText, phase);
				Update_TimeText(obj.TimeText, phase);
				Update_AmountText(obj.AmountText, phase);
				Update_Amount(obj.Amount, phase);
				Update_TypeText(obj.TypeText, phase);
				Update_Type(obj.Type, phase);
			}
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990(phase);
			CompleteUpdate(phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_BalanceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj7, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ReasonText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj8, obj, null);
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
		private void Update_AmountText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Amount(decimal obj, int phase)
		{
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850(phase);
			Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850(phase);
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_PositiveAmountVisibility_236364850;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NegativeAmountVisibility_236364850;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ZeroAmountVisibility_236364850;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TypeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Type(string obj, int phase)
		{
			if (obj != null)
			{
				Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990(phase);
				Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990(phase);
				Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990(phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_IncomeDotVisibility_1421152990;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_ExpenseDotVisibility_1421152990;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990(int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				PendingFunctionBindings["Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990"] = Invoke_Mahiro_Account_Views_Pages_BalanceHistoryPage_M_NeutralDotVisibility_1421152990;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__9_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = balanceHistoryPage.MovePageAsync(-1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__9_0_d>(ref _u__, ref this);
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
	private struct ___ctor_b__9_1_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = balanceHistoryPage.MovePageAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__9_1_d>(ref _u__, ref this);
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
	private struct _MovePageAsync_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
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
				int num2 = balanceHistoryPage._page + delta;
				if (num2 >= 1 && num2 <= balanceHistoryPage._totalPages)
				{
					balanceHistoryPage._page = num2;
					_u__ = AppShell.RunAsync(balanceHistoryPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MovePageAsync_d__14>(ref _u__, ref this);
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
	private struct _OnNavigatedTo_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					balanceHistoryPage.__n__0(e);
					_u__ = AppShell.RunAsync(balanceHistoryPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__10>(ref _u__, ref this);
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
	private struct _RefreshAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

		private TaskAwaiter<Ppt203f5EkL1uByHb1JT> __u__1;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
			try
			{
				TaskAwaiter<Ppt203f5EkL1uByHb1JT> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.Dxx0MhwNda(balanceHistoryPage._page, 50).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Ppt203f5EkL1uByHb1JT>, _RefreshAsync_d__13>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<Ppt203f5EkL1uByHb1JT>);
					num = (__1__state = -1);
				}
				Ppt203f5EkL1uByHb1JT result = _u__.GetResult();
				UiHelpers.Replace(balanceHistoryPage._transactions, (global::System.Collections.Generic.IEnumerable<P4we1Nf53qYVoxPlZyvG>)result.Transactions);
				balanceHistoryPage._page = ((p9WVlJf5a812Tn4S3TgP)result).Page;
				balanceHistoryPage._totalPages = ((p9WVlJf5a812Tn4S3TgP)result).TotalPages;
				balanceHistoryPage.BalancePager.SetState(((p9WVlJf5a812Tn4S3TgP)result).Page, ((p9WVlJf5a812Tn4S3TgP)result).TotalPages, ((p9WVlJf5a812Tn4S3TgP)result).Total);
				((UIElement)balanceHistoryPage.EmptyStatePanel).Visibility = (((((Collection<P4we1Nf53qYVoxPlZyvG>)(object)balanceHistoryPage._transactions).Count != 0) ? true : false) ? Visibility.Visible : Visibility.Collapsed);
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
	private struct _RefreshButton_Click_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public BalanceHistoryPage __4__this;

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
			BalanceHistoryPage balanceHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync(balanceHistoryPage.RefreshAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__12>(ref _u__, ref this);
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

	private readonly ObservableCollection<P4we1Nf53qYVoxPlZyvG> _transactions;

	private int _page;

	private int _totalPages;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView BalanceTransactionList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyStatePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PagerBar BalancePager;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IBalanceHistoryPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility IncomeDotVisibility(string type)
	{
		if ((type == "payment_recharge" || type == "card_redeem" || type == "opening_balance" || type == "service_refund") ? true : false)
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility ExpenseDotVisibility(string type)
	{
		if ((type == "account_claim" || type == "service_purchase") ? true : false)
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility NeutralDotVisibility(string type)
	{
		if ((type == "payment_recharge" || type == "card_redeem" || type == "opening_balance" || type == "service_refund" || type == "account_claim" || type == "service_purchase") ? true : false)
		{
			return (Visibility)1;
		}
		return (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility PositiveAmountVisibility(decimal amount)
	{
		if (amount > 0m)
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility NegativeAmountVisibility(decimal amount)
	{
		if (amount < 0m)
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static Visibility ZeroAmountVisibility(decimal amount)
	{
		if (amount == 0m)
		{
			return (Visibility)0;
		}
		return (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	public BalanceHistoryPage()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		_transactions = new ObservableCollection<P4we1Nf53qYVoxPlZyvG>();
		_page = 1;
		_totalPages = 1;
		InitializeComponent();
		((ItemsControl)BalanceTransactionList).ItemsSource = _transactions;
		BalancePager.PreviousRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__9_0_d __ctor_b__9_0_d = default(___ctor_b__9_0_d);
			__ctor_b__9_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__9_0_d.__4__this = this;
			__ctor_b__9_0_d.__1__state = -1;
			__ctor_b__9_0_d.__t__builder.Start<___ctor_b__9_0_d>(ref __ctor_b__9_0_d);
		});
		BalancePager.NextRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__9_1_d __ctor_b__9_1_d = default(___ctor_b__9_1_d);
			__ctor_b__9_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__9_1_d.__4__this = this;
			__ctor_b__9_1_d.__1__state = -1;
			__ctor_b__9_1_d.__t__builder.Start<___ctor_b__9_1_d>(ref __ctor_b__9_1_d);
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
		_OnNavigatedTo_d__10 onNavigatedTo_d__ = default(_OnNavigatedTo_d__10);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__10>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		((Collection<P4we1Nf53qYVoxPlZyvG>)(object)_transactions).Clear();
		_page = 1;
		_totalPages = 1;
		((UIElement)EmptyStatePanel).Visibility = (Visibility)1;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__12 refreshButton_Click_d__ = default(_RefreshButton_Click_d__12);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__12>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshAsync_d__13 refreshAsync_d__ = default(_RefreshAsync_d__13);
		refreshAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshAsync_d__.__4__this = this;
		refreshAsync_d__.__1__state = -1;
		refreshAsync_d__.__t__builder.Start<_RefreshAsync_d__13>(ref refreshAsync_d__);
		return refreshAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MovePageAsync(int delta)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MovePageAsync_d__14 movePageAsync_d__ = default(_MovePageAsync_d__14);
		movePageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		movePageAsync_d__.__4__this = this;
		movePageAsync_d__.delta = delta;
		movePageAsync_d__.__1__state = -1;
		movePageAsync_d__.__t__builder.Start<_MovePageAsync_d__14>(ref movePageAsync_d__);
		return movePageAsync_d__.__t__builder.Task;
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
			Uri val = new Uri("ms-appx:///Views/Pages/BalanceHistoryPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			BalanceTransactionList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EmptyStatePanel = CastExtensions.As<StackPanel>(target);
			break;
		case 4:
			BalancePager = CastExtensions.As<PagerBar>(target);
			break;
		case 17:
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
		if (connectionId == 6)
		{
			Grid val = (Grid)target;
			BalanceHistoryPage_obj6_Bindings balanceHistoryPage_obj6_Bindings = (BalanceHistoryPage_obj6_Bindings)new BalanceHistoryPage_obj6_Bindings();
			result = (IComponentConnector)(object)balanceHistoryPage_obj6_Bindings;
			balanceHistoryPage_obj6_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += balanceHistoryPage_obj6_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)balanceHistoryPage_obj6_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)balanceHistoryPage_obj6_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void __ctor_b__9_0(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__9_0_d __ctor_b__9_0_d = default(___ctor_b__9_0_d);
		__ctor_b__9_0_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__9_0_d.__4__this = this;
		__ctor_b__9_0_d.__1__state = -1;
		__ctor_b__9_0_d.__t__builder.Start<___ctor_b__9_0_d>(ref __ctor_b__9_0_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__9_1(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__9_1_d __ctor_b__9_1_d = default(___ctor_b__9_1_d);
		__ctor_b__9_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__9_1_d.__4__this = this;
		__ctor_b__9_1_d.__1__state = -1;
		__ctor_b__9_1_d.__t__builder.Start<___ctor_b__9_1_d>(ref __ctor_b__9_1_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__9_2(object _, RoutedEventArgs _2)
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

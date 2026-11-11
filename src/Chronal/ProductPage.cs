using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Mahiro_Account.UI.Navigation;
using Mahiro_Account.UI.Shell;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using T4XKlEftW1rbu7TvQmXH;
using VFQxICfth84Lkoc3ch2l;
using WinRT;
using WinRT.ChronalVtableClasses;
using aT519UfO3d6PYepiHMHC;
using bUfedyCg1PBqhqIkB8r;
using fJI2ftf5SouLKttbv85L;
using qS8vkpL43FlTMgcj0rgs;
using zDw8FCfOEDpLHSbKqHHt;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ProductPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IProductPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IProductPage_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Controls_ContentControl_Content(ContentControl obj, object value, string targetNullValue)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			if (value == null && targetNullValue != null)
			{
				value = XamlBindingHelper.ConvertValue(typeof(global::System.Object), (object)targetNullValue);
			}
			obj.Content = value;
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

	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class ProductPage_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IProductPage_Bindings
	{
		[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
		[DebuggerNonUserCode]
		private class ProductPage_obj5_BindingsTracking
		{
			private WeakReference<ProductPage_obj5_Bindings> weakRefToBindingObj;

			[MethodImpl((MethodImplOptions)8)]
			public ProductPage_obj5_BindingsTracking(ProductPage_obj5_Bindings obj)
			{
				weakRefToBindingObj = new WeakReference<ProductPage_obj5_Bindings>(obj);
			}

			[MethodImpl((MethodImplOptions)8)]
			public ProductPage_obj5_Bindings TryGetBindingObject()
			{
				ProductPage_obj5_Bindings productPage_obj5_Bindings = null;
				if (weakRefToBindingObj != null)
				{
					weakRefToBindingObj.TryGetTarget(out productPage_obj5_Bindings);
					if (productPage_obj5_Bindings == null)
					{
						weakRefToBindingObj = null;
						ReleaseAllListeners();
					}
				}
				return productPage_obj5_Bindings;
			}

			[MethodImpl((MethodImplOptions)8)]
			public void ReleaseAllListeners()
			{
				UpdateChildListeners_(null);
			}

			[MethodImpl((MethodImplOptions)8)]
			public void PropertyChanged_(object sender, PropertyChangedEventArgs e)
			{
				ProductPage_obj5_Bindings productPage_obj5_Bindings = TryGetBindingObject();
				if (productPage_obj5_Bindings == null)
				{
					return;
				}
				string propertyName = e.PropertyName;
				xbVf4FftyKLP9yqO5mWE val = (xbVf4FftyKLP9yqO5mWE)((sender is xbVf4FftyKLP9yqO5mWE) ? sender : null);
				if (string.IsNullOrEmpty(propertyName))
				{
					if (val != null)
					{
						productPage_obj5_Bindings.Update_StockAlertButtonText(val.StockAlertButtonText, 1073741824);
						productPage_obj5_Bindings.Update_StockAlertTooltip(val.StockAlertTooltip, 1073741824);
					}
				}
				else if (!(propertyName == "StockAlertButtonText"))
				{
					if (propertyName == "StockAlertTooltip" && val != null)
					{
						productPage_obj5_Bindings.Update_StockAlertTooltip(val.StockAlertTooltip, 1073741824);
					}
				}
				else if (val != null)
				{
					productPage_obj5_Bindings.Update_StockAlertButtonText(val.StockAlertButtonText, 1073741824);
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			public void UpdateChildListeners_(xbVf4FftyKLP9yqO5mWE obj)
			{
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_0047: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Expected O, but got Unknown
				ProductPage_obj5_Bindings productPage_obj5_Bindings = TryGetBindingObject();
				if (productPage_obj5_Bindings != null)
				{
					if (productPage_obj5_Bindings.dataRoot != null)
					{
						((INotifyPropertyChanged)productPage_obj5_Bindings.dataRoot).PropertyChanged -= new PropertyChangedEventHandler(PropertyChanged_);
					}
					if (obj != null)
					{
						productPage_obj5_Bindings.dataRoot = obj;
						((INotifyPropertyChanged)obj).PropertyChanged += new PropertyChangedEventHandler(PropertyChanged_);
					}
				}
			}

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
			}
		}

		private xbVf4FftyKLP9yqO5mWE dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private Button obj6;

		private TextBlock obj8;

		private TextBlock obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		private TextBlock obj12;

		private ProductPage_obj5_BindingsTracking bindingsTracking;

		[MethodImpl((MethodImplOptions)8)]
		public ProductPage_obj5_Bindings()
		{
			bindingsTracking = (ProductPage_obj5_BindingsTracking)new ProductPage_obj5_BindingsTracking(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			switch (connectionId)
			{
			case 5:
				obj5 = new WeakReference((object)CastExtensions.As<Border>(target));
				break;
			case 6:
				obj6 = CastExtensions.As<Button>(target);
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
			case 7:
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
			object target = obj5.Target;
			Border val = (Border)((target is Border) ? target : null);
			if (val != (Border)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<xbVf4FftyKLP9yqO5mWE>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<xbVf4FftyKLP9yqO5mWE>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(xbVf4FftyKLP9yqO5mWE obj, int phase)
		{
			bindingsTracking.UpdateChildListeners_(obj);
			if (obj != null)
			{
				if ((phase & -1073741823) != 0)
				{
					Update_StockAlertButtonText(obj.StockAlertButtonText, phase);
					Update_StockAlertTooltip(obj.StockAlertTooltip, phase);
				}
				if ((phase & -2147483647) != 0)
				{
					Update_IsOutOfStock(obj.IsOutOfStock, phase);
					Update_PriceText(obj.PriceText, phase);
					Update_StockText(obj.StockText, phase);
					Update_DisplayName(obj.DisplayName, phase);
					Update_Category(obj.Category, phase);
					Update_Description(obj.Description, phase);
					Update_HasDescription(obj.HasDescription, phase);
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StockAlertButtonText(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ContentControl_Content((ContentControl)(object)obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StockAlertTooltip(string obj, int phase)
		{
			if ((phase & -1073741823) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IsOutOfStock(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				Update_IsOutOfStock_Cast_IsOutOfStock_To_Visibility(((!obj) ? Visibility.Visible : Visibility.Collapsed), phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_IsOutOfStock_Cast_IsOutOfStock_To_Visibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj6, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_PriceText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StockText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_DisplayName(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Category(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Description(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_HasDescription(bool obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				Update_HasDescription_Cast_HasDescription_To_Visibility(((!obj) ? Visibility.Visible : Visibility.Collapsed), phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_HasDescription_Cast_HasDescription_To_Visibility(Visibility obj, int phase)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_UIElement_Visibility((UIElement)(object)obj12, obj);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private static class __O_5
	{
		public static Func<global::System.Threading.Tasks.Task> _0___RefreshSummaryAsync;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OnNavigatedTo_d__6_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductPage __4__this;

		public NavigationEventArgs e;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductPage productPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					productPage.__n__0(e);
					productPage.TryStartBackAnimation();
					_u__ = productPage.ReloadSubscriptionStatesAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__6_1>(ref _u__, ref this);
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
	private struct _RefreshButton_Click_d__12_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductPage productPage = __4__this;
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
						goto IL_00f0;
					}
					_u__ = AppShell.RunAsync(AppShell.RefreshSummaryAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__12_1>(ref _u__, ref this);
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
				_u__ = productPage.ReloadSubscriptionStatesAsync().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__12_1>(ref _u__, ref this);
					return;
				}
				goto IL_00f0;
				IL_00f0:
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
	private struct _ReloadSubscriptionStatesAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ProductPage __4__this;

		private TaskAwaiter<sxb90VfOvfxZ3y2XxwdE?> __u__1;

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
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductPage productPage = __4__this;
			try
			{
				TaskAwaiter<sxb90VfOvfxZ3y2XxwdE> _u__ = default;
				if (num != 0)
				{
					_u__ = ShellView.TryLoadStockSubscriptionsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sxb90VfOvfxZ3y2XxwdE>, _ReloadSubscriptionStatesAsync_d__13>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<sxb90VfOvfxZ3y2XxwdE>);
					num = (__1__state = -1);
				}
				sxb90VfOvfxZ3y2XxwdE result = _u__.GetResult();
				if (result != null)
				{
					productPage._subscribedProductIds.Clear();
					var enumerator = result.Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							PqFZUVfO1JCpVlryjUX8 current = enumerator.Current;
							productPage._subscribedProductIds.Add(current.ProductId);
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					ShellView.ApplyStockSubscriptionStates((global::System.Collections.Generic.IEnumerable<long>?)productPage._subscribedProductIds);
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
	private struct _StockAlertButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public object sender;

		public ProductPage __4__this;

		private xbVf4FftyKLP9yqO5mWE _product_5__2;

		private TaskAwaiter<bool?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0091: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductPage productPage = __4__this;
			try
			{
				TaskAwaiter<bool?> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool?>);
					num = (__1__state = -1);
					goto IL_00ad;
				}
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object dataContext = ((FrameworkElement)val).DataContext;
					_product_5__2 = (xbVf4FftyKLP9yqO5mWE)((dataContext is xbVf4FftyKLP9yqO5mWE) ? dataContext : null);
					if (_product_5__2 != null)
					{
						_u__ = ToggleStockSubscriptionAsync(_product_5__2).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool?>, _StockAlertButton_Click_d__14>(ref _u__, ref this);
							return;
						}
						goto IL_00ad;
					}
				}
				goto end_IL_0011;
				IL_00ad:
				bool? result = _u__.GetResult();
				if (result.HasValue)
				{
					if (result.Value)
					{
						productPage._subscribedProductIds.Add(_product_5__2.Id);
					}
					else
					{
						productPage._subscribedProductIds.Remove(_product_5__2.Id);
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_product_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_product_5__2 = null;
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
	private struct _TryStartBackAnimation_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductPage __4__this;

		private TaskAwaiter<bool> __u__1;

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
			ProductPage __8_locals3 = __4__this;
			try
			{
				try
				{
					TaskAwaiter<bool> _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
						goto IL_00d4;
					}
					ConnectedAnimation animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("ProductTitleBack");
					if (animation != null)
					{
						xbVf4FftyKLP9yqO5mWE val = ((__8_locals3._lastOpenedProduct == null) ? null : Enumerable.FirstOrDefault<xbVf4FftyKLP9yqO5mWE>((global::System.Collections.Generic.IEnumerable<xbVf4FftyKLP9yqO5mWE>)AppShell.Products, (Func<xbVf4FftyKLP9yqO5mWE, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (xbVf4FftyKLP9yqO5mWE item) => item.Id == __8_locals3._lastOpenedProduct.Id)));
						if (val != null)
						{
							_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(((ListViewBase)__8_locals3.ProductCatalogList).TryStartConnectedAnimationAsync(animation, (object)val, "ProductCardTitle"));
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _TryStartBackAnimation_d__7>(ref _u__, ref this);
								return;
							}
							goto IL_00d4;
						}
						animation.Cancel();
					}
					goto end_IL_0014;
					IL_00d4:
					_u__.GetResult();
					end_IL_0014:;
				}
				catch (global::System.Exception)
				{
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

	internal const string ForwardAnimationKey = "ProductTitleForward";

	internal const string BackAnimationKey = "ProductTitleBack";

	private const string CardTitleElementName = "ProductCardTitle";

	private readonly HashSet<long> _subscribedProductIds;

	private xbVf4FftyKLP9yqO5mWE? _lastOpenedProduct;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView ProductCatalogList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel EmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IProductPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public ProductPage()
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		_subscribedProductIds = new HashSet<long>();
		InitializeComponent();
		((ItemsControl)ProductCatalogList).ItemsSource = AppShell.Products;
		AppShell.Products.CollectionChanged += new NotifyCollectionChangedEventHandler(OnProductsChanged);
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			AppShell.Products.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnProductsChanged);
			AppShell.SummaryRefreshed -= OnSummaryRefreshed;
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
		UpdateEmptyState();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__6_1 onNavigatedTo_d__6_ = default(_OnNavigatedTo_d__6_1);
		onNavigatedTo_d__6_.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__6_.__4__this = this;
		onNavigatedTo_d__6_.e = e;
		onNavigatedTo_d__6_.__1__state = -1;
		onNavigatedTo_d__6_.__t__builder.Start<_OnNavigatedTo_d__6_1>(ref onNavigatedTo_d__6_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void TryStartBackAnimation()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_TryStartBackAnimation_d__7 tryStartBackAnimation_d__ = default(_TryStartBackAnimation_d__7);
		tryStartBackAnimation_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		tryStartBackAnimation_d__.__4__this = this;
		tryStartBackAnimation_d__.__1__state = -1;
		tryStartBackAnimation_d__.__t__builder.Start<_TryStartBackAnimation_d__7>(ref tryStartBackAnimation_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnProductsChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		UpdateEmptyState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		ShellView.ApplyStockSubscriptionStates((global::System.Collections.Generic.IEnumerable<long>?)_subscribedProductIds);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		_subscribedProductIds.Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateEmptyState()
	{
		((UIElement)EmptyState).Visibility = (((((Collection<xbVf4FftyKLP9yqO5mWE>)(object)AppShell.Products).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__12_1 refreshButton_Click_d__12_ = default(_RefreshButton_Click_d__12_1);
		refreshButton_Click_d__12_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__12_.__4__this = this;
		refreshButton_Click_d__12_.__1__state = -1;
		refreshButton_Click_d__12_.__t__builder.Start<_RefreshButton_Click_d__12_1>(ref refreshButton_Click_d__12_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ReloadSubscriptionStatesAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ReloadSubscriptionStatesAsync_d__13 reloadSubscriptionStatesAsync_d__ = default(_ReloadSubscriptionStatesAsync_d__13);
		reloadSubscriptionStatesAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		reloadSubscriptionStatesAsync_d__.__4__this = this;
		reloadSubscriptionStatesAsync_d__.__1__state = -1;
		reloadSubscriptionStatesAsync_d__.__t__builder.Start<_ReloadSubscriptionStatesAsync_d__13>(ref reloadSubscriptionStatesAsync_d__);
		return reloadSubscriptionStatesAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StockAlertButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StockAlertButton_Click_d__14 stockAlertButton_Click_d__ = default(_StockAlertButton_Click_d__14);
		stockAlertButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stockAlertButton_Click_d__.__4__this = this;
		stockAlertButton_Click_d__.sender = sender;
		stockAlertButton_Click_d__.__1__state = -1;
		stockAlertButton_Click_d__.__t__builder.Start<_StockAlertButton_Click_d__14>(ref stockAlertButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<bool?> ToggleStockSubscriptionAsync(xbVf4FftyKLP9yqO5mWE product)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (product == null)
		{
			return null;
		}
		bool flag = !product.IsSubscribed;
		if (flag)
		{
			flag = !(await ShellView.EnsureEmailBoundAsync());
		}
		if (flag)
		{
			return null;
		}
		bool flag2 = !product.IsSubscribed;
		Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
		try
		{
			if (flag2)
			{
				await AppShell.Api.Cv5cFo99l5(product.Id);
				AppShell.Success("已订阅「" + product.DisplayName + "」的到货提醒");
			}
			else
			{
				await AppShell.Api.nUMcsCyNtl(product.Id);
				AppShell.Info("已取消「" + product.DisplayName + "」的到货提醒");
			}
		}
		catch (global::System.Exception obj) when (((Func<bool>)delegate
		{
			// Could not convert BlockContainer to single expression
			object obj2 = ((obj is Fx92Odf5YJhjb4F5o23y) ? obj : null);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			if (obj2 == null)
			{
				result = 0;
			}
			else
			{
				val = (Fx92Odf5YJhjb4F5o23y)obj2;
				result = (val.IsRateLimited ? 1 : 0);
			}
			return (byte)result != 0;
		}).Invoke())
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ToggleStockSubscriptionAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ProductPage.xaml.cs", 176);
			int num = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
			AppShell.Warning($"操作过于频繁，请 {num} 秒后再试");
			return null;
		}
		catch (Fx92Odf5YJhjb4F5o23y val2)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)val2, "ui-exception", "ToggleStockSubscriptionAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ProductPage.xaml.cs", 183);
			AppShell.Error(((global::System.Exception)val2).Message);
			return null;
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "ToggleStockSubscriptionAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\ProductPage.xaml.cs", 189));
			return null;
		}
		ShellView.SetStockSubscriptionState(product.Id, flag2);
		product.IsSubscribed = flag2;
		return flag2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OpenProductDetailButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		Button val = (Button)((sender is Button) ? sender : null);
		if (val == null)
		{
			return;
		}
		object dataContext = ((FrameworkElement)val).DataContext;
		xbVf4FftyKLP9yqO5mWE val2 = (xbVf4FftyKLP9yqO5mWE)((dataContext is xbVf4FftyKLP9yqO5mWE) ? dataContext : null);
		if (val2 != null)
		{
			_lastOpenedProduct = val2;
			global::System.Type type = NavigationRegistry.MainPageType("productDetail");
			if (TryPrepareForwardAnimation(val2))
			{
				((Page)this).Frame.Navigate(type, (object)val2, (NavigationTransitionInfo)new SuppressNavigationTransitionInfo());
			}
			else
			{
				AppShell.Navigate(type, val2);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryPrepareForwardAnimation(xbVf4FftyKLP9yqO5mWE product)
	{
		try
		{
			DependencyObject obj = ((ItemsControl)ProductCatalogList).ContainerFromItem((object)product);
			ListViewItem val = (ListViewItem)(object)((obj is ListViewItem) ? obj : null);
			if (val != null)
			{
				UIElement contentTemplateRoot = ((ContentControl)val).ContentTemplateRoot;
				FrameworkElement val2 = (FrameworkElement)(object)((contentTemplateRoot is FrameworkElement) ? contentTemplateRoot : null);
				if (val2 != null)
				{
					object obj2 = val2.FindName("ProductCardTitle");
					UIElement val3 = (UIElement)((obj2 is UIElement) ? obj2 : null);
					if (val3 != null)
					{
						ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("ProductTitleForward", val3);
						return true;
					}
				}
			}
			return false;
		}
		catch (global::System.Exception)
		{
			return false;
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
			Uri val = new Uri("ms-appx:///Views/Pages/ProductPage.xaml");
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
			ProductCatalogList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			EmptyState = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(StockAlertButton_Click);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(OpenProductDetailButton_Click);
			break;
		case 13:
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
		if (connectionId == 5)
		{
			Border val = (Border)target;
			ProductPage_obj5_Bindings productPage_obj5_Bindings = (ProductPage_obj5_Bindings)new ProductPage_obj5_Bindings();
			result = (IComponentConnector)(object)productPage_obj5_Bindings;
			productPage_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += productPage_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)productPage_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)productPage_obj5_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__5_0(object _, RoutedEventArgs _2)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		AppShell.Products.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnProductsChanged);
		AppShell.SummaryRefreshed -= OnSummaryRefreshed;
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[DebuggerHidden]
	private void __n__0(NavigationEventArgs e)
	{
		base.OnNavigatedTo(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _TryStartBackAnimation_b__7_0(xbVf4FftyKLP9yqO5mWE item)
	{
		return item.Id == _lastOpenedProduct.Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

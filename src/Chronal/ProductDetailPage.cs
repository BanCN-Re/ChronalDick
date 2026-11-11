using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using MGB8R2ftKpwJh8G93obv;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using Mahiro_Account.UI.Shell;
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
using Xisa5gftBnMyHwIOMZc6;
using a5L5Rjftl7vqo57IsFL8;
using aT519UfO3d6PYepiHMHC;
using qS8vkpL43FlTMgcj0rgs;
using zDw8FCfOEDpLHSbKqHHt;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class ProductDetailPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IProductDetailPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IProductDetailPage_BindingsScopeConnector
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

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	private class ProductDetailPage_obj5_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IProductDetailPage_Bindings
	{
		private RXFpPPftg4tbCOfOyXMK dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj5;

		private TextBlock obj6;

		private TextBlock obj8;

		private TextBlock obj9;

		[MethodImpl((MethodImplOptions)8)]
		public ProductDetailPage_obj5_Bindings()
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
			case 8:
				obj8 = CastExtensions.As<TextBlock>(target);
				break;
			case 9:
				obj9 = CastExtensions.As<TextBlock>(target);
				break;
			case 7:
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
			object target = obj5.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<RXFpPPftg4tbCOfOyXMK>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<RXFpPPftg4tbCOfOyXMK>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(RXFpPPftg4tbCOfOyXMK obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_ClaimedAtText(obj.ClaimedAtText, phase);
				Update_Account(obj.Account, phase);
				Update_ProductName(obj.ProductName, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ClaimedAtText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj6, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Account(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj8, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ProductName(string obj, int phase)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __ClaimButton_Click_b__17_0_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

		private TaskAwaiter<lFFfw5ftIots8RHFKHwP> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_017a: Unknown result type (might be due to invalid IL or missing references)
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductDetailPage productDetailPage = __4__this;
			try
			{
				TaskAwaiter<lFFfw5ftIots8RHFKHwP> _u__2 = default;
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					if (productDetailPage._selectedProduct != null)
					{
						if (productDetailPage._pendingClaimProductId != productDetailPage._selectedProduct.Id)
						{
							productDetailPage._pendingClaimRequestNo = null;
							productDetailPage._pendingClaimProductId = productDetailPage._selectedProduct.Id;
						}
						if (productDetailPage._pendingClaimRequestNo == null)
						{
							productDetailPage._pendingClaimRequestNo = ((object)Guid.NewGuid()/*cast due to .constrained prefix*/).ToString();
						}
						_u__2 = AppShell.Api.Fsy0ggWSDw(productDetailPage._selectedProduct.Id, AppShell.Machine.Hash, productDetailPage._pendingClaimRequestNo).GetAwaiter();
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<lFFfw5ftIots8RHFKHwP>, __ClaimButton_Click_b__17_0_d>(ref _u__2, ref this);
							return;
						}
						goto IL_0105;
					}
					AppShell.Warning("请先选择商品");
					goto end_IL_0011;
				case 0:
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<lFFfw5ftIots8RHFKHwP>);
					num = (__1__state = -1);
					goto IL_0105;
				case 1:
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_016d;
				case 2:
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						break;
					}
					IL_016d:
					_u__.GetResult();
					_u__ = productDetailPage.RefreshClaimHistoryAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ClaimButton_Click_b__17_0_d>(ref _u__, ref this);
						return;
					}
					break;
					IL_0105:
					_u__2.GetResult();
					productDetailPage._pendingClaimRequestNo = null;
					_u__ = AppShell.RefreshSummaryAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ClaimButton_Click_b__17_0_d>(ref _u__, ref this);
						return;
					}
					goto IL_016d;
				}
				_u__.GetResult();
				AppShell.Success("账号已获取，库存已扣减");
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
	private struct _ClaimButton_Click_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

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
			ProductDetailPage __8_locals1 = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] () =>
					{
						//IL_0005: Unknown result type (might be due to invalid IL or missing references)
						//IL_000a: Unknown result type (might be due to invalid IL or missing references)
						__ClaimButton_Click_b__17_0_d _ClaimButton_Click_b__17_0_d = default(__ClaimButton_Click_b__17_0_d);
						_ClaimButton_Click_b__17_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
						_ClaimButton_Click_b__17_0_d.__4__this = __8_locals1;
						_ClaimButton_Click_b__17_0_d.__1__state = -1;
						_ClaimButton_Click_b__17_0_d.__t__builder.Start<__ClaimButton_Click_b__17_0_d>(ref _ClaimButton_Click_b__17_0_d);
						return _ClaimButton_Click_b__17_0_d.__t__builder.Task;
					}).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ClaimButton_Click_d__17>(ref _u__, ref this);
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
	private struct _OnNavigatedTo_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

		public NavigationEventArgs e;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_011f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductDetailPage productDetailPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00dc;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_013a;
				}
				productDetailPage.__n__0(e);
				object parameter = e.Parameter;
				xbVf4FftyKLP9yqO5mWE val = (xbVf4FftyKLP9yqO5mWE)((parameter is xbVf4FftyKLP9yqO5mWE) ? parameter : null);
				if (val != null)
				{
					productDetailPage._selectedProduct = val;
				}
				if (productDetailPage._selectedProduct != null)
				{
					productDetailPage.UpdateProductDetail(productDetailPage._selectedProduct);
					productDetailPage.TryStartForwardAnimation();
					_u__ = AppShell.RunAsync(productDetailPage.RefreshClaimHistoryAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__6>(ref _u__, ref this);
						return;
					}
					goto IL_00dc;
				}
				AppShell.Navigate(NavigationRegistry.MainPageType("product"));
				goto end_IL_0011;
				IL_00dc:
				_u__.GetResult();
				_u__ = productDetailPage.ReloadSubscriptionStatesAsync().GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__6>(ref _u__, ref this);
					return;
				}
				goto IL_013a;
				IL_013a:
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
	private struct _RefreshClaimHistoryAsync_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

		private TaskAwaiter<XdxjAiftdCEnHSHIPGcU> __u__1;

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
			ProductDetailPage __8_locals3 = __4__this;
			try
			{
				TaskAwaiter<XdxjAiftdCEnHSHIPGcU> _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.Api.wyJ0Y4SvY7().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<XdxjAiftdCEnHSHIPGcU>, _RefreshClaimHistoryAsync_d__18>(ref _u__, ref this);
						return;
					}
				}
				else
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<XdxjAiftdCEnHSHIPGcU>);
					num = (__1__state = -1);
				}
				XdxjAiftdCEnHSHIPGcU result = _u__.GetResult();
				UiHelpers.Replace(__8_locals3._claimHistory, Enumerable.Where<RXFpPPftg4tbCOfOyXMK>((global::System.Collections.Generic.IEnumerable<RXFpPPftg4tbCOfOyXMK>)result.Claims, (Func<RXFpPPftg4tbCOfOyXMK, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (RXFpPPftg4tbCOfOyXMK claim) => __8_locals3._selectedProduct == null || claim.ProductName == __8_locals3._selectedProduct.Name)));
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
	private struct _ReloadSubscriptionStatesAsync_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

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
			ProductDetailPage productDetailPage = __4__this;
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
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sxb90VfOvfxZ3y2XxwdE>, _ReloadSubscriptionStatesAsync_d__14>(ref _u__, ref this);
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
					productDetailPage._subscribedProductIds.Clear();
					var enumerator = result.Items.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							PqFZUVfO1JCpVlryjUX8 current = enumerator.Current;
							productDetailPage._subscribedProductIds.Add(current.ProductId);
						}
					}
					finally
					{
						if (num < 0)
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
						}
					}
					ShellView.ApplyStockSubscriptionStates((global::System.Collections.Generic.IEnumerable<long>?)productDetailPage._subscribedProductIds);
					if (productDetailPage._selectedProduct != null)
					{
						productDetailPage._selectedProduct.IsSubscribed = productDetailPage._subscribedProductIds.Contains(productDetailPage._selectedProduct.Id);
						productDetailPage.UpdateStockAlertButton(productDetailPage._selectedProduct);
					}
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
	private struct _StockAlertButton_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ProductDetailPage __4__this;

		private xbVf4FftyKLP9yqO5mWE _product_5__2;

		private TaskAwaiter<bool?> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			ProductDetailPage productDetailPage = __4__this;
			try
			{
				TaskAwaiter<bool?> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool?>);
					num = (__1__state = -1);
					goto IL_0099;
				}
				_product_5__2 = productDetailPage._selectedProduct;
				if (_product_5__2 != null)
				{
					_u__ = ProductPage.ToggleStockSubscriptionAsync(_product_5__2).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool?>, _StockAlertButton_Click_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_0099;
				}
				AppShell.Warning("请先选择商品");
				goto end_IL_0011;
				IL_0099:
				bool? result = _u__.GetResult();
				if (result.HasValue)
				{
					if (result.Value)
					{
						productDetailPage._subscribedProductIds.Add(_product_5__2.Id);
					}
					else
					{
						productDetailPage._subscribedProductIds.Remove(_product_5__2.Id);
					}
					productDetailPage.UpdateStockAlertButton(_product_5__2);
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

	private readonly ObservableCollection<RXFpPPftg4tbCOfOyXMK> _claimHistory;

	private readonly HashSet<long> _subscribedProductIds;

	private xbVf4FftyKLP9yqO5mWE? _selectedProduct;

	private string? _pendingClaimRequestNo;

	private long _pendingClaimProductId;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView ClaimHistoryList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel ClaimEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button StockAlertButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProductDetailStock;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProductDetailPrice;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProductDetailTitle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProductDetailMeta;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ProductDetailDescription;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IProductDetailPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public ProductDetailPage()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		_claimHistory = new ObservableCollection<RXFpPPftg4tbCOfOyXMK>();
		_subscribedProductIds = new HashSet<long>();
		InitializeComponent();
		((ItemsControl)ClaimHistoryList).ItemsSource = _claimHistory;
		_claimHistory.CollectionChanged += new NotifyCollectionChangedEventHandler(OnClaimHistoryChanged);
		AppShell.SummaryRefreshed += OnSummaryRefreshed;
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Expected O, but got Unknown
			_claimHistory.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnClaimHistoryChanged);
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
		_OnNavigatedTo_d__6 onNavigatedTo_d__ = default(_OnNavigatedTo_d__6);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__6>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void TryStartForwardAnimation()
	{
		try
		{
			ConnectedAnimation animation = ConnectedAnimationService.GetForCurrentView().GetAnimation("ProductTitleForward");
			if (animation != null)
			{
				animation.TryStart((UIElement)(object)ProductDetailTitle);
			}
		}
		catch (global::System.Exception)
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnClaimHistoryChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		UpdateEmptyState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateEmptyState()
	{
		((UIElement)ClaimEmptyState).Visibility = ((((Collection<RXFpPPftg4tbCOfOyXMK>)(object)_claimHistory).Count != 0)) ? Visibility.Visible : Visibility.Collapsed;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		_pendingClaimRequestNo = null;
		_pendingClaimProductId = 0L;
		_selectedProduct = null;
		_subscribedProductIds.Clear();
		((Collection<RXFpPPftg4tbCOfOyXMK>)(object)_claimHistory).Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSummaryRefreshed(object? sender, yg9HVZft43Yd2k4O7qX5 summary)
	{
		if (_selectedProduct != null)
		{
			_selectedProduct = Enumerable.FirstOrDefault<xbVf4FftyKLP9yqO5mWE>((global::System.Collections.Generic.IEnumerable<xbVf4FftyKLP9yqO5mWE>)AppShell.Products, (Func<xbVf4FftyKLP9yqO5mWE, bool>)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (xbVf4FftyKLP9yqO5mWE item) => item.Id == _selectedProduct.Id)) ?? _selectedProduct;
			_selectedProduct.IsSubscribed = _subscribedProductIds.Contains(_selectedProduct.Id);
			UpdateProductDetail(_selectedProduct);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateProductDetail(xbVf4FftyKLP9yqO5mWE product)
	{
		ProductDetailTitle.Text = product.DisplayName;
		ProductDetailMeta.Text = "分类：" + product.Category;
		ProductDetailDescription.Text = product.Description;
		((UIElement)ProductDetailDescription).Visibility = ((!product.HasDescription) ? Visibility.Visible : Visibility.Collapsed);
		ProductDetailPrice.Text = product.PriceText;
		ProductDetailStock.Text = product.StockText;
		UpdateStockAlertButton(product);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateStockAlertButton(xbVf4FftyKLP9yqO5mWE product)
	{
		((UIElement)StockAlertButton).Visibility = ((!product.IsOutOfStock) ? Visibility.Visible : Visibility.Collapsed);
		((ContentControl)StockAlertButton).Content = product.StockAlertButtonText;
		ToolTipService.SetToolTip((DependencyObject)(object)StockAlertButton, (object)product.StockAlertTooltip);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ReloadSubscriptionStatesAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ReloadSubscriptionStatesAsync_d__14 reloadSubscriptionStatesAsync_d__ = default(_ReloadSubscriptionStatesAsync_d__14);
		reloadSubscriptionStatesAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		reloadSubscriptionStatesAsync_d__.__4__this = this;
		reloadSubscriptionStatesAsync_d__.__1__state = -1;
		reloadSubscriptionStatesAsync_d__.__t__builder.Start<_ReloadSubscriptionStatesAsync_d__14>(ref reloadSubscriptionStatesAsync_d__);
		return reloadSubscriptionStatesAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void BackToProductsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		global::System.Type type = NavigationRegistry.MainPageType("product");
		try
		{
			ConnectedAnimationService.GetForCurrentView().PrepareToAnimate("ProductTitleBack", (UIElement)(object)ProductDetailTitle);
			((Page)this).Frame.Navigate(type, (object)null, (NavigationTransitionInfo)new SuppressNavigationTransitionInfo());
		}
		catch (global::System.Exception)
		{
			AppShell.Navigate(type);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void StockAlertButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StockAlertButton_Click_d__16 stockAlertButton_Click_d__ = default(_StockAlertButton_Click_d__16);
		stockAlertButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		stockAlertButton_Click_d__.__4__this = this;
		stockAlertButton_Click_d__.__1__state = -1;
		stockAlertButton_Click_d__.__t__builder.Start<_StockAlertButton_Click_d__16>(ref stockAlertButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ClaimButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ClaimButton_Click_d__17 claimButton_Click_d__ = default(_ClaimButton_Click_d__17);
		claimButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		claimButton_Click_d__.__4__this = this;
		claimButton_Click_d__.__1__state = -1;
		claimButton_Click_d__.__t__builder.Start<_ClaimButton_Click_d__17>(ref claimButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RefreshClaimHistoryAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshClaimHistoryAsync_d__18 refreshClaimHistoryAsync_d__ = default(_RefreshClaimHistoryAsync_d__18);
		refreshClaimHistoryAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		refreshClaimHistoryAsync_d__.__4__this = this;
		refreshClaimHistoryAsync_d__.__1__state = -1;
		refreshClaimHistoryAsync_d__.__t__builder.Start<_RefreshClaimHistoryAsync_d__18>(ref refreshClaimHistoryAsync_d__);
		return refreshClaimHistoryAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyClaimAccountButton_Click(object sender, RoutedEventArgs e)
	{
		Button val = (Button)((sender is Button) ? sender : null);
		if (val != null)
		{
			object dataContext = ((FrameworkElement)val).DataContext;
			RXFpPPftg4tbCOfOyXMK val2 = (RXFpPPftg4tbCOfOyXMK)((dataContext is RXFpPPftg4tbCOfOyXMK) ? dataContext : null);
			if (val2 != null)
			{
				UiHelpers.CopyToClipboard(val2.Account);
				AppShell.Info("账号已复制");
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
			Uri val = new Uri("ms-appx:///Views/Pages/ProductDetailPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ClaimHistoryList = CastExtensions.As<ListView>(target);
			break;
		case 3:
			ClaimEmptyState = CastExtensions.As<StackPanel>(target);
			break;
		case 7:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CopyClaimAccountButton_Click);
			break;
		case 10:
			StockAlertButton = CastExtensions.As<Button>(target);
			((ButtonBase)StockAlertButton).Click += new RoutedEventHandler(StockAlertButton_Click);
			break;
		case 11:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ClaimButton_Click);
			break;
		case 12:
			ProductDetailStock = CastExtensions.As<TextBlock>(target);
			break;
		case 13:
			ProductDetailPrice = CastExtensions.As<TextBlock>(target);
			break;
		case 14:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(BackToProductsButton_Click);
			break;
		case 15:
			ProductDetailTitle = CastExtensions.As<TextBlock>(target);
			break;
		case 16:
			ProductDetailMeta = CastExtensions.As<TextBlock>(target);
			break;
		case 17:
			ProductDetailDescription = CastExtensions.As<TextBlock>(target);
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
			ProductDetailPage_obj5_Bindings productDetailPage_obj5_Bindings = (ProductDetailPage_obj5_Bindings)new ProductDetailPage_obj5_Bindings();
			result = (IComponentConnector)(object)productDetailPage_obj5_Bindings;
			productDetailPage_obj5_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += productDetailPage_obj5_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)productDetailPage_obj5_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)productDetailPage_obj5_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__5_0(object _, RoutedEventArgs _2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		_claimHistory.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnClaimHistoryChanged);
		AppShell.SummaryRefreshed -= OnSummaryRefreshed;
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
	[CompilerGenerated]
	private bool _OnSummaryRefreshed_b__11_0(xbVf4FftyKLP9yqO5mWE item)
	{
		return item.Id == _selectedProduct.Id;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task _ClaimButton_Click_b__17_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__ClaimButton_Click_b__17_0_d _ClaimButton_Click_b__17_0_d = default(__ClaimButton_Click_b__17_0_d);
		_ClaimButton_Click_b__17_0_d.__t__builder = AsyncTaskMethodBuilder.Create();
		_ClaimButton_Click_b__17_0_d.__4__this = this;
		_ClaimButton_Click_b__17_0_d.__1__state = -1;
		_ClaimButton_Click_b__17_0_d.__t__builder.Start<__ClaimButton_Click_b__17_0_d>(ref _ClaimButton_Click_b__17_0_d);
		return _ClaimButton_Click_b__17_0_d.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool _RefreshClaimHistoryAsync_b__18_0(RXFpPPftg4tbCOfOyXMK claim)
	{
		if (_selectedProduct != null)
		{
			return claim.ProductName == _selectedProduct.Name;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

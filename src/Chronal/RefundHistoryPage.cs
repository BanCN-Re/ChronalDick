using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
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
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using VMOwuQfetZ78yHUOBvpj;
using WinRT;
using WinRT.ChronalVtableClasses;
using bUfedyCg1PBqhqIkB8r;
using nwUITEfelhB69Hne010y;
using qS8vkpL43FlTMgcj0rgs;
using yjXUBbfeKNTIxhLVVKy5;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class RefundHistoryPage : Page, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IRefundHistoryPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IRefundHistoryPage_BindingsScopeConnector
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
		public static void Set_Microsoft_UI_Xaml_Documents_Run_Text(Run obj, string value, string targetNullValue)
		{
			if (value == null && targetNullValue != null)
			{
				value = targetNullValue;
			}
			obj.Text = value ?? string.Empty;
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

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class RefundHistoryPage_obj8_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IRefundHistoryPage_Bindings
	{
		private DX66fufedNmOe7OHG7BS dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj8;

		private Button obj9;

		private Run obj10;

		private Run obj11;

		private TextBlock obj12;

		private TextBlock obj13;

		private TextBlock obj14;

		private TextBlock obj15;

		private TextBlock obj16;

		[MethodImpl((MethodImplOptions)8)]
		public RefundHistoryPage_obj8_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Expected O, but got Unknown
			switch (connectionId)
			{
			case 8:
				obj8 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 9:
				obj9 = CastExtensions.As<Button>(target);
				break;
			case 10:
				obj10 = CastExtensions.As<Run>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<Run>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 13:
				obj13 = CastExtensions.As<TextBlock>(target);
				break;
			case 14:
				obj14 = CastExtensions.As<TextBlock>(target);
				break;
			case 15:
				obj15 = CastExtensions.As<TextBlock>(target);
				break;
			case 16:
				obj16 = CastExtensions.As<TextBlock>(target);
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
			object target = obj8.Target;
			Grid val = (Grid)((target is Grid) ? target : null);
			if (val != (Grid)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<DX66fufedNmOe7OHG7BS>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<DX66fufedNmOe7OHG7BS>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(DX66fufedNmOe7OHG7BS obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_Id(obj.Id, phase);
				Update_RecoveryText(obj.RecoveryText, phase);
				Update_StatusText(obj.StatusText, phase);
				Update_AmountText(obj.AmountText, phase);
				Update_ModeText(obj.ModeText, phase);
				Update_OrderText(obj.OrderText, phase);
				Update_RequestNo(obj.RequestNo, phase);
				Update_TimeText(obj.TimeText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_Id(long obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_FrameworkElement_Tag((FrameworkElement)(object)obj9, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RecoveryText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Documents_Run_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_StatusText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Documents_Run_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AmountText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ModeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj13, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_OrderText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj14, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RequestNo(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj15, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_TimeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj16, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct ___ctor_b__12_0_d_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

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
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = refundHistoryPage.MovePageAsync(-1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__12_0_d_1>(ref _u__, ref this);
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
	private struct ___ctor_b__12_1_d : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

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
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = refundHistoryPage.MovePageAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, ___ctor_b__12_1_d>(ref _u__, ref this);
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
	private struct _DetailButton_Click_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		public object sender;

		private long _refundId_5__2;

		private int _revision_5__3;

		private CancellationTokenSource _request_5__4;

		private TaskAwaiter<TlFRg4feHhirUMZ30AVt> __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0230: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_024e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Expected O, but got Unknown
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Expected O, but got Unknown
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0215: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				if ((uint)num <= 1u)
				{
					goto IL_0099;
				}
				if (refundHistoryPage._active && !refundHistoryPage._busy && refundHistoryPage._dialog == null)
				{
					object obj = sender;
					Button val = (Button)((obj is Button) ? obj : null);
					if (val != null)
					{
						object tag = ((FrameworkElement)val).Tag;
						if (tag is long)
						{
							_refundId_5__2 = (long)tag;
							_revision_5__3 = ++refundHistoryPage._revision;
							_request_5__4 = new CancellationTokenSource();
							goto IL_0099;
						}
					}
				}
				goto end_IL_0011;
				IL_0099:
				try
				{
					if ((uint)num > 1u)
					{
						refundHistoryPage._request = _request_5__4;
						refundHistoryPage.SetBusy(busy: true);
						((UIElement)refundHistoryPage.ErrorText).Visibility = (Visibility)1;
					}
					try
					{
						TaskAwaiter<ContentDialogResult> _u__ = default;
						TaskAwaiter<TlFRg4feHhirUMZ30AVt> _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(TaskAwaiter<ContentDialogResult>);
								num = (__1__state = -1);
								goto IL_024c;
							}
							_u__2 = AppShell.Api.qmVyDV4VsV(_refundId_5__2, _request_5__4.Token).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TlFRg4feHhirUMZ30AVt>, _DetailButton_Click_d__26>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(TaskAwaiter<TlFRg4feHhirUMZ30AVt>);
							num = (__1__state = -1);
						}
						TlFRg4feHhirUMZ30AVt result = _u__2.GetResult();
						if (refundHistoryPage.IsCurrent(_revision_5__3))
						{
							if (result.Record.Id != _refundId_5__2)
							{
								throw new InvalidOperationException("退款详情与所选记录不一致");
							}
							refundHistoryPage._detailView = (UserRefundDetailView?)new UserRefundDetailView();
							refundHistoryPage._detailView.SetDetail(result);
							refundHistoryPage._dialog = new ContentDialog
							{
								Title = "退款详情",
								Content = refundHistoryPage._detailView,
								CloseButtonText = "关闭",
								XamlRoot = ((UIElement)refundHistoryPage).XamlRoot,
								RequestedTheme = ((FrameworkElement)refundHistoryPage).ActualTheme,
								DefaultButton = (ContentDialogButton)3
							};
							refundHistoryPage.LoadingRing.IsActive = false;
							_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(refundHistoryPage._dialog.ShowAsync());
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _DetailButton_Click_d__26>(ref _u__, ref this);
								return;
							}
							goto IL_024c;
						}
						goto end_IL_00c0;
						IL_024c:
						_u__.GetResult();
						end_IL_00c0:;
					}
					catch (global::System.Exception obj2) when (obj2 is OperationCanceledException && _request_5__4.IsCancellationRequested)
					{
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "DetailButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\RefundHistoryPage.xaml.cs", 166);
						if (refundHistoryPage.IsCurrent(_revision_5__3))
						{
							refundHistoryPage.ShowError(ex);
						}
					}
					finally
					{
						if (num < 0)
						{
							refundHistoryPage._detailView?.Clear();
							refundHistoryPage._detailView = null;
							refundHistoryPage._dialog = null;
							if (refundHistoryPage._request == _request_5__4)
							{
								refundHistoryPage._request = null;
							}
							if (refundHistoryPage.IsCurrent(_revision_5__3))
							{
								refundHistoryPage.SetBusy(busy: false);
							}
						}
					}
				}
				finally
				{
					if (num < 0 && _request_5__4 != null)
					{
						((global::System.IDisposable)_request_5__4).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_request_5__4 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_request_5__4 = null;
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
	private struct _FilterButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

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
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = refundHistoryPage.LoadAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _FilterButton_Click_d__23>(ref _u__, ref this);
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
	private struct _LoadAsync_d__21 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		public int page;

		private int _revision_5__2;

		private CancellationTokenSource _request_5__3;

		private TaskAwaiter<deZEBkfeg9HtXZWaBllo> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Expected O, but got Unknown
			//IL_0154: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0055;
				}
				if (refundHistoryPage._active && !refundHistoryPage._busy)
				{
					_revision_5__2 = ++refundHistoryPage._revision;
					_request_5__3 = new CancellationTokenSource();
					goto IL_0055;
				}
				goto end_IL_0011;
				IL_0055:
				try
				{
					if (num != 0)
					{
						refundHistoryPage._request = _request_5__3;
						refundHistoryPage.SetBusy(busy: true);
						TextBlock errorText = refundHistoryPage.ErrorText;
						TextBlock emptyText = refundHistoryPage.EmptyText;
						Visibility visibility = (Visibility)1;
						((UIElement)emptyText).Visibility = (Visibility)1;
						((UIElement)errorText).Visibility = visibility;
						((Collection<DX66fufedNmOe7OHG7BS>)(object)refundHistoryPage._items).Clear();
					}
					try
					{
						TaskAwaiter<deZEBkfeg9HtXZWaBllo> _u__ = default;
						if (num != 0)
						{
							object selectedItem = ((Selector)refundHistoryPage.StatusBox).SelectedItem;
							object obj = ((selectedItem is ComboBoxItem) ? selectedItem : null);
							string text = ((obj == null) ? null : ((FrameworkElement)obj).Tag?.ToString()) ?? string.Empty;
							_u__ = AppShell.Api.rsmy9m29yS(page, 20, text, refundHistoryPage.SearchBox.Text, refundHistoryPage.FromDate.Date, refundHistoryPage.ToDate.Date, _request_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<deZEBkfeg9HtXZWaBllo>, _LoadAsync_d__21>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<deZEBkfeg9HtXZWaBllo>);
							num = (__1__state = -1);
						}
						deZEBkfeg9HtXZWaBllo result = _u__.GetResult();
						if (refundHistoryPage.IsCurrent(_revision_5__2))
						{
							UiHelpers.Replace(refundHistoryPage._items, (global::System.Collections.Generic.IEnumerable<DX66fufedNmOe7OHG7BS>)result.Items);
							refundHistoryPage._page = result.Pagination.Page;
							refundHistoryPage._totalPages = result.Pagination.TotalPages;
							refundHistoryPage.RefundPager.SetState(refundHistoryPage._page, refundHistoryPage._totalPages, result.Pagination.Total);
							refundHistoryPage.EmptyText.Text = "没有符合条件的退款记录";
							((UIElement)refundHistoryPage.EmptyText).Visibility = (((((Collection<DX66fufedNmOe7OHG7BS>)(object)refundHistoryPage._items).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
						}
					}
					catch (global::System.Exception obj2) when (obj2 is OperationCanceledException && _request_5__3.IsCancellationRequested)
					{
					}
					catch (global::System.Exception ex)
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\RefundHistoryPage.xaml.cs", 117);
						if (refundHistoryPage.IsCurrent(_revision_5__2))
						{
							refundHistoryPage.ShowError(ex);
						}
					}
					finally
					{
						if (num < 0)
						{
							if (refundHistoryPage._request == _request_5__3)
							{
								refundHistoryPage._request = null;
							}
							if (refundHistoryPage.IsCurrent(_revision_5__2))
							{
								refundHistoryPage.SetBusy(busy: false);
							}
						}
					}
				}
				finally
				{
					if (num < 0 && _request_5__3 != null)
					{
						((global::System.IDisposable)_request_5__3).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_request_5__3 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_request_5__3 = null;
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
	private struct _MovePageAsync_d__25_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		public int delta;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0090;
				}
				int num2 = refundHistoryPage._page + delta;
				if (num2 >= 1 && num2 <= refundHistoryPage._totalPages)
				{
					_u__ = refundHistoryPage.LoadAsync(num2).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _MovePageAsync_d__25_1>(ref _u__, ref this);
						return;
					}
					goto IL_0090;
				}
				goto end_IL_0011;
				IL_0090:
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
	private struct _OnLoaded_d__13_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_00cf;
				}
				AppShell.SessionCleared -= new EventHandler(refundHistoryPage.OnSessionCleared);
				AppShell.SessionCleared += new EventHandler(refundHistoryPage.OnSessionCleared);
				dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
				refundHistoryPage._ownerId = ((currentUser != null) ? currentUser.Id : 0);
				refundHistoryPage._active = refundHistoryPage._ownerId > 0;
				if (refundHistoryPage._active)
				{
					_u__ = refundHistoryPage.LoadAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__13_1>(ref _u__, ref this);
						return;
					}
					goto IL_00cf;
				}
				goto end_IL_0011;
				IL_00cf:
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
	private struct _RefreshButton_Click_d__22_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		private TaskAwaiter __u__1;

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
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = refundHistoryPage.LoadAsync(refundHistoryPage._page).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__22_1>(ref _u__, ref this);
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
	private struct _RefundRequestsButton_Click_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		private int _revision_5__2;

		private TaskAwaiter<ContentDialogResult> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_005c;
				}
				TaskAwaiter _u__ = default;
				if (num == 1)
				{
					_u__ = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_01f6;
				}
				if (refundHistoryPage._active && !refundHistoryPage._busy && refundHistoryPage._dialog == null)
				{
					_revision_5__2 = ++refundHistoryPage._revision;
					goto IL_005c;
				}
				goto end_IL_0011;
				IL_01f6:
				_u__.GetResult();
				goto end_IL_0011;
				IL_005c:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__2 = default;
					if (num != 0)
					{
						refundHistoryPage._requestView = (UserRefundRequestsView?)new UserRefundRequestsView();
						refundHistoryPage._dialog = new ContentDialog
						{
							Title = "我的退款申请",
							Content = refundHistoryPage._requestView,
							CloseButtonText = "关闭",
							XamlRoot = ((UIElement)refundHistoryPage).XamlRoot,
							RequestedTheme = ((FrameworkElement)refundHistoryPage).ActualTheme
						};
						_u__2 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(refundHistoryPage._dialog.ShowAsync());
						if (!_u__2.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__2;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _RefundRequestsButton_Click_d__0>(ref _u__2, ref this);
							return;
						}
					}
					else
					{
						_u__2 = __u__1;
						__u__1 = default(TaskAwaiter<ContentDialogResult>);
						num = (__1__state = -1);
					}
					_u__2.GetResult();
				}
				catch (global::System.Exception ex)
				{
					cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "RefundRequestsButton_Click", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\RefundHistoryPage.Requests.cs", 21);
					if (refundHistoryPage.IsCurrent(_revision_5__2))
					{
						refundHistoryPage.ShowError(ex);
					}
				}
				finally
				{
					if (num < 0)
					{
						refundHistoryPage._requestView?.Clear();
						refundHistoryPage._requestView = null;
						refundHistoryPage._dialog = null;
					}
				}
				if (refundHistoryPage.IsCurrent(_revision_5__2))
				{
					_u__ = refundHistoryPage.LoadAsync(refundHistoryPage._page).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefundRequestsButton_Click_d__0>(ref _u__, ref this);
						return;
					}
					goto IL_01f6;
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
	private struct _ResetButton_Click_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public RefundHistoryPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0077: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			RefundHistoryPage refundHistoryPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					refundHistoryPage.SearchBox.Text = string.Empty;
					((Selector)refundHistoryPage.StatusBox).SelectedIndex = 0;
					CalendarDatePicker fromDate = refundHistoryPage.FromDate;
					DateTimeOffset? date = (refundHistoryPage.ToDate.Date = null);
					fromDate.Date = date;
					_u__ = refundHistoryPage.LoadAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ResetButton_Click_d__24>(ref _u__, ref this);
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

	private readonly ObservableCollection<DX66fufedNmOe7OHG7BS> _items;

	private CancellationTokenSource? _request;

	private ContentDialog? _dialog;

	private UserRefundDetailView? _detailView;

	private UserRefundRequestsView? _requestView;

	private long _ownerId;

	private int _revision;

	private int _page;

	private int _totalPages;

	private bool _active;

	private bool _busy;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ScrollViewer FilterPanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ErrorText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView RefundList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmptyText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PagerBar RefundPager;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox SearchBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox StatusBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CalendarDatePicker FromDate;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CalendarDatePicker ToDate;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IRefundHistoryPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefundRequestsButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefundRequestsButton_Click_d__0 refundRequestsButton_Click_d__ = default(_RefundRequestsButton_Click_d__0);
		refundRequestsButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refundRequestsButton_Click_d__.__4__this = this;
		refundRequestsButton_Click_d__.__1__state = -1;
		refundRequestsButton_Click_d__.__t__builder.Start<_RefundRequestsButton_Click_d__0>(ref refundRequestsButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public RefundHistoryPage()
	{
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		_items = new ObservableCollection<DX66fufedNmOe7OHG7BS>();
		_page = 1;
		_totalPages = 1;
		InitializeComponent();
		((ItemsControl)RefundList).ItemsSource = _items;
		RefundPager.PreviousRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] [AsyncStateMachine(typeof(object))] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__12_0_d_1 __ctor_b__12_0_d_ = default(___ctor_b__12_0_d_1);
			__ctor_b__12_0_d_.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__12_0_d_.__4__this = this;
			__ctor_b__12_0_d_.__1__state = -1;
			__ctor_b__12_0_d_.__t__builder.Start<___ctor_b__12_0_d_1>(ref __ctor_b__12_0_d_);
		});
		RefundPager.NextRequested += (EventHandler)([MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] [CompilerGenerated] (object? _, EventArgs _) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			___ctor_b__12_1_d __ctor_b__12_1_d = default(___ctor_b__12_1_d);
			__ctor_b__12_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
			__ctor_b__12_1_d.__4__this = this;
			__ctor_b__12_1_d.__1__state = -1;
			__ctor_b__12_1_d.__t__builder.Start<___ctor_b__12_1_d>(ref __ctor_b__12_1_d);
		});
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLoaded_d__13_1 onLoaded_d__13_ = default(_OnLoaded_d__13_1);
		onLoaded_d__13_.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__13_.__4__this = this;
		onLoaded_d__13_.__1__state = -1;
		onLoaded_d__13_.__t__builder.Start<_OnLoaded_d__13_1>(ref onLoaded_d__13_);
	}

	[MethodImpl((MethodImplOptions)8)]
	protected override void OnNavigatedFrom(NavigationEventArgs e)
	{
		ClearSessionView();
		base.OnNavigatedFrom(e);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		ClearSessionView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		ClearSessionView();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearSessionView()
	{
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		_active = false;
		_ownerId = 0L;
		_revision++;
		CancellationTokenSource? request = _request;
		if (request != null)
		{
			request.Cancel();
		}
		_detailView?.Clear();
		_requestView?.Clear();
		ContentDialog? dialog = _dialog;
		if (dialog != null)
		{
			dialog.Hide();
		}
		((Collection<DX66fufedNmOe7OHG7BS>)(object)_items).Clear();
		_page = (_totalPages = 1);
		RefundPager.SetState(1, 1, 0);
		ErrorText.Text = string.Empty;
		TextBlock errorText = ErrorText;
		TextBlock emptyText = EmptyText;
		Visibility visibility = (Visibility)1;
		((UIElement)emptyText).Visibility = (Visibility)1;
		((UIElement)errorText).Visibility = visibility;
		SetBusy(busy: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool IsCurrent(int revision)
	{
		if (_active && revision == _revision && _ownerId > 0)
		{
			dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
			return ((currentUser != null) ? new long?(currentUser.Id) : ((long?)null)) == _ownerId;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBusy(bool busy)
	{
		_busy = busy;
		LoadingRing.IsActive = busy;
		Button refreshButton = RefreshButton;
		ScrollViewer filterPanel = FilterPanel;
		PagerBar refundPager = RefundPager;
		bool flag = (((Control)RefundList).IsEnabled = !busy);
		bool flag3 = (((Control)refundPager).IsEnabled = flag);
		bool isEnabled = (((Control)filterPanel).IsEnabled = flag3);
		((Control)refreshButton).IsEnabled = isEnabled;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ShowError(global::System.Exception error)
	{
		ErrorText.Text = "退款记录加载失败：" + AppShell.GetExceptionDisplayMessage(error, "ShowError", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\RefundHistoryPage.xaml.cs", 90);
		((UIElement)ErrorText).Visibility = (Visibility)0;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAsync(int page)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__21 loadAsync_d__ = default(_LoadAsync_d__21);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.page = page;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__21>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__22_1 refreshButton_Click_d__22_ = default(_RefreshButton_Click_d__22_1);
		refreshButton_Click_d__22_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__22_.__4__this = this;
		refreshButton_Click_d__22_.__1__state = -1;
		refreshButton_Click_d__22_.__t__builder.Start<_RefreshButton_Click_d__22_1>(ref refreshButton_Click_d__22_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void FilterButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_FilterButton_Click_d__23 filterButton_Click_d__ = default(_FilterButton_Click_d__23);
		filterButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		filterButton_Click_d__.__4__this = this;
		filterButton_Click_d__.__1__state = -1;
		filterButton_Click_d__.__t__builder.Start<_FilterButton_Click_d__23>(ref filterButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ResetButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ResetButton_Click_d__24 resetButton_Click_d__ = default(_ResetButton_Click_d__24);
		resetButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		resetButton_Click_d__.__4__this = this;
		resetButton_Click_d__.__1__state = -1;
		resetButton_Click_d__.__t__builder.Start<_ResetButton_Click_d__24>(ref resetButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MovePageAsync(int delta)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_MovePageAsync_d__25_1 movePageAsync_d__25_ = default(_MovePageAsync_d__25_1);
		movePageAsync_d__25_.__t__builder = AsyncTaskMethodBuilder.Create();
		movePageAsync_d__25_.__4__this = this;
		movePageAsync_d__25_.delta = delta;
		movePageAsync_d__25_.__1__state = -1;
		movePageAsync_d__25_.__t__builder.Start<_MovePageAsync_d__25_1>(ref movePageAsync_d__25_);
		return movePageAsync_d__25_.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void DetailButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_DetailButton_Click_d__26 detailButton_Click_d__ = default(_DetailButton_Click_d__26);
		detailButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		detailButton_Click_d__.__4__this = this;
		detailButton_Click_d__.sender = sender;
		detailButton_Click_d__.__1__state = -1;
		detailButton_Click_d__.__t__builder.Start<_DetailButton_Click_d__26>(ref detailButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/RefundHistoryPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			FilterPanel = CastExtensions.As<ScrollViewer>(target);
			break;
		case 3:
			ErrorText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			RefundList = CastExtensions.As<ListView>(target);
			break;
		case 5:
			EmptyText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			RefundPager = CastExtensions.As<PagerBar>(target);
			break;
		case 9:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(DetailButton_Click);
			break;
		case 17:
			SearchBox = CastExtensions.As<TextBox>(target);
			break;
		case 18:
			StatusBox = CastExtensions.As<ComboBox>(target);
			break;
		case 19:
			FromDate = CastExtensions.As<CalendarDatePicker>(target);
			break;
		case 20:
			ToDate = CastExtensions.As<CalendarDatePicker>(target);
			break;
		case 21:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(FilterButton_Click);
			break;
		case 22:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(ResetButton_Click);
			break;
		case 23:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 24:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 25:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(RefundRequestsButton_Click);
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
		if (connectionId == 8)
		{
			Grid val = (Grid)target;
			RefundHistoryPage_obj8_Bindings refundHistoryPage_obj8_Bindings = (RefundHistoryPage_obj8_Bindings)new RefundHistoryPage_obj8_Bindings();
			result = (IComponentConnector)(object)refundHistoryPage_obj8_Bindings;
			refundHistoryPage_obj8_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += refundHistoryPage_obj8_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)refundHistoryPage_obj8_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)refundHistoryPage_obj8_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	[AsyncStateMachine(typeof(object))]
	private void __ctor_b__12_0(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__12_0_d_1 __ctor_b__12_0_d_ = default(___ctor_b__12_0_d_1);
		__ctor_b__12_0_d_.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__12_0_d_.__4__this = this;
		__ctor_b__12_0_d_.__1__state = -1;
		__ctor_b__12_0_d_.__t__builder.Start<___ctor_b__12_0_d_1>(ref __ctor_b__12_0_d_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	[CompilerGenerated]
	private void __ctor_b__12_1(object? _, EventArgs _2)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		___ctor_b__12_1_d __ctor_b__12_1_d = default(___ctor_b__12_1_d);
		__ctor_b__12_1_d.__t__builder = AsyncVoidMethodBuilder.Create();
		__ctor_b__12_1_d.__4__this = this;
		__ctor_b__12_1_d.__1__state = -1;
		__ctor_b__12_1_d.__t__builder.Start<___ctor_b__12_1_d>(ref __ctor_b__12_1_d);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

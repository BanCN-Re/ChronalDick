using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using LlvQkpftcKTPAsaRP0ff;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using PXVa7OfezgywaA0jcqj9;
using WinRT;
using WinRT.ChronalVtableClasses;
using e2LYxrfeicPNMvjDOJV9;
using ftkhp5fPXc3cmmZq9YAG;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class UserRefundRequestsView : UserControl, IComponentConnector
{
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IUserRefundRequestsView_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IUserRefundRequestsView_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	private class UserRefundRequestsView_obj9_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IUserRefundRequestsView_Bindings
	{
		private qgTWE1fPbituBSVMJXEH dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj9;

		private TextBlock obj10;

		private TextBlock obj11;

		[MethodImpl((MethodImplOptions)8)]
		public UserRefundRequestsView_obj9_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			switch (connectionId)
			{
			case 9:
				obj9 = new WeakReference((object)CastExtensions.As<StackPanel>(target));
				break;
			case 10:
				obj10 = CastExtensions.As<TextBlock>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<TextBlock>(target);
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
			object target = obj9.Target;
			StackPanel val = (StackPanel)((target is StackPanel) ? target : null);
			if (val != (StackPanel)null)
			{
				((FrameworkElement)val).DataContextChanged -= DataContextChangedHandler;
			}
			initialized = true;
			Update_(CastExtensions.As<qgTWE1fPbituBSVMJXEH>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<qgTWE1fPbituBSVMJXEH>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(qgTWE1fPbituBSVMJXEH obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_ListText(obj.ListText, phase);
				Update_RequestNo(obj.RequestNo, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_ListText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj10, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_RequestNo(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadAsync_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

		public int page;

		private CancellationTokenSource _request_5__2;

		private TaskAwaiter<dgEMlbfeGxdGsrMPuUsu> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003e;
				}
				if (userRefundRequestsView.IsCurrent && !userRefundRequestsView._busy)
				{
					_request_5__2 = new CancellationTokenSource();
					goto IL_003e;
				}
				goto end_IL_0011;
				IL_003e:
				try
				{
					if (num != 0)
					{
						userRefundRequestsView._request = _request_5__2;
						userRefundRequestsView.SetBusy(busy: true);
						((ItemsControl)userRefundRequestsView.RequestList).ItemsSource = null;
						TextBlock summaryText = userRefundRequestsView.SummaryText;
						TextBlock planText = userRefundRequestsView.PlanText;
						string text = (userRefundRequestsView.ErrorText.Text = string.Empty);
						string text2 = (planText.Text = text);
						summaryText.Text = text2;
					}
					try
					{
						TaskAwaiter<dgEMlbfeGxdGsrMPuUsu> _u__ = default;
						if (num != 0)
						{
							_u__ = AppShell.Api.UyEyLnXBRa(page, _request_5__2.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<dgEMlbfeGxdGsrMPuUsu>, _LoadAsync_d__13>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<dgEMlbfeGxdGsrMPuUsu>);
							num = (__1__state = -1);
						}
						dgEMlbfeGxdGsrMPuUsu result = _u__.GetResult();
						if (userRefundRequestsView.IsCurrent && !_request_5__2.IsCancellationRequested)
						{
							userRefundRequestsView._page = result.Pagination.Page;
							userRefundRequestsView._pages = result.Pagination.TotalPages;
							((ItemsControl)userRefundRequestsView.RequestList).ItemsSource = result.Items;
							userRefundRequestsView.PageText.Text = $"共 {result.Pagination.Total} 条 · 第 {userRefundRequestsView._page} / {userRefundRequestsView._pages} 页";
							if (result.Items.Count == 0)
							{
								userRefundRequestsView.ErrorText.Text = "暂无退款申请";
							}
						}
					}
					catch (global::System.Exception obj) when (obj is OperationCanceledException && _request_5__2.IsCancellationRequested)
					{
					}
					catch (global::System.Exception exception)
					{
						if (userRefundRequestsView.IsCurrent)
						{
							userRefundRequestsView.ErrorText.Text = AppShell.GetExceptionDisplayMessage(exception, "LoadAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\UserRefundRequestsView.xaml.cs", 70);
						}
					}
					finally
					{
						if (num < 0)
						{
							if (userRefundRequestsView._request == _request_5__2)
							{
								userRefundRequestsView._request = null;
							}
							userRefundRequestsView.SetBusy(busy: false);
						}
					}
				}
				finally
				{
					if (num < 0 && _request_5__2 != null)
					{
						((global::System.IDisposable)_request_5__2).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_request_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_request_5__2 = null;
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
	private struct _NextButton_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0087;
				}
				if (userRefundRequestsView._page < userRefundRequestsView._pages)
				{
					_u__ = userRefundRequestsView.LoadAsync(userRefundRequestsView._page + 1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _NextButton_Click_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_0087;
				}
				goto end_IL_0011;
				IL_0087:
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
	private struct _OnLoaded_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					AppShell.SessionCleared -= new EventHandler(userRefundRequestsView.OnSessionCleared);
					AppShell.SessionCleared += new EventHandler(userRefundRequestsView.OnSessionCleared);
					dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
					userRefundRequestsView._ownerId = ((currentUser != null) ? currentUser.Id : 0);
					userRefundRequestsView._active = userRefundRequestsView._ownerId > 0;
					_u__ = userRefundRequestsView.LoadAsync(1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__7>(ref _u__, ref this);
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
	private struct _PreviousButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0082;
				}
				if (userRefundRequestsView._page > 1)
				{
					_u__ = userRefundRequestsView.LoadAsync(userRefundRequestsView._page - 1).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PreviousButton_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_0082;
				}
				goto end_IL_0011;
				IL_0082:
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
	private struct _RefreshButton_Click_d__14_2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

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
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = userRefundRequestsView.LoadAsync(userRefundRequestsView._page).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__14_2>(ref _u__, ref this);
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
	private struct _RequestList_SelectionChanged_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestsView __4__this;

		private qgTWE1fPbituBSVMJXEH _item_5__2;

		private CancellationTokenSource _request_5__3;

		private TaskAwaiter<u0kZmvfenFahk4yQUbNZ> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestsView userRefundRequestsView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0061;
				}
				if (userRefundRequestsView.IsCurrent && !userRefundRequestsView._busy)
				{
					object selectedItem = ((Selector)userRefundRequestsView.RequestList).SelectedItem;
					_item_5__2 = (qgTWE1fPbituBSVMJXEH)((selectedItem is qgTWE1fPbituBSVMJXEH) ? selectedItem : null);
					if (_item_5__2 != null)
					{
						_request_5__3 = new CancellationTokenSource();
						goto IL_0061;
					}
				}
				goto end_IL_0011;
				IL_0061:
				try
				{
					if (num != 0)
					{
						userRefundRequestsView._request = _request_5__3;
						userRefundRequestsView.SetBusy(busy: true);
						TextBlock summaryText = userRefundRequestsView.SummaryText;
						TextBlock planText = userRefundRequestsView.PlanText;
						string text = (userRefundRequestsView.ErrorText.Text = string.Empty);
						string text2 = (planText.Text = text);
						summaryText.Text = text2;
					}
					try
					{
						TaskAwaiter<u0kZmvfenFahk4yQUbNZ> _u__ = default;
						if (num != 0)
						{
							_u__ = AppShell.Api.xEgyjjXsno(_item_5__2.Id, _request_5__3.Token).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<u0kZmvfenFahk4yQUbNZ>, _RequestList_SelectionChanged_d__17>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<u0kZmvfenFahk4yQUbNZ>);
							num = (__1__state = -1);
						}
						u0kZmvfenFahk4yQUbNZ result = _u__.GetResult();
						if (userRefundRequestsView.IsCurrent && !_request_5__3.IsCancellationRequested)
						{
							if (result.Record.Id != _item_5__2.Id)
							{
								throw new InvalidOperationException("退款申请详情不匹配");
							}
							userRefundRequestsView.SummaryText.Text = result.Record.SummaryText;
							userRefundRequestsView.PlanText.Text = "申请时确认的完整清单：" + Environment.NewLine + result.Consent.DisplayText;
						}
					}
					catch (global::System.Exception obj) when (obj is OperationCanceledException && _request_5__3.IsCancellationRequested)
					{
					}
					catch (global::System.Exception exception)
					{
						if (userRefundRequestsView.IsCurrent)
						{
							userRefundRequestsView.ErrorText.Text = AppShell.GetExceptionDisplayMessage(exception, "RequestList_SelectionChanged", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\UserRefundRequestsView.xaml.cs", 92);
						}
					}
					finally
					{
						if (num < 0)
						{
							if (userRefundRequestsView._request == _request_5__3)
							{
								userRefundRequestsView._request = null;
							}
							userRefundRequestsView.SetBusy(busy: false);
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
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_item_5__2 = null;
				_request_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_item_5__2 = null;
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

	private long _ownerId;

	private bool _active;

	private bool _busy;

	private int _page;

	private int _pages;

	private CancellationTokenSource? _request;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PageText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView RequestList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ErrorText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SummaryText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PlanText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button PreviousButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button NextButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IUserRefundRequestsView_Bindings Bindings;

	private bool IsCurrent
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (_active && _ownerId > 0)
			{
				dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
				return ((currentUser != null) ? new long?(currentUser.Id) : ((long?)null)) == _ownerId;
			}
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public UserRefundRequestsView()
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		_page = 1;
		_pages = 1;
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
			Clear();
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLoaded_d__7 onLoaded_d__ = default(_OnLoaded_d__7);
		onLoaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__.__4__this = this;
		onLoaded_d__.__1__state = -1;
		onLoaded_d__.__t__builder.Start<_OnLoaded_d__7>(ref onLoaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		_active = false;
		_ownerId = 0L;
		CancellationTokenSource? request = _request;
		if (request != null)
		{
			request.Cancel();
		}
		((ItemsControl)RequestList).ItemsSource = null;
		TextBlock summaryText = SummaryText;
		TextBlock planText = PlanText;
		TextBlock errorText = ErrorText;
		string text = (PageText.Text = string.Empty);
		string text2 = (errorText.Text = text);
		string text4 = (planText.Text = text2);
		summaryText.Text = text4;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SetBusy(bool busy)
	{
		_busy = busy;
		LoadingRing.IsActive = busy;
		Button refreshButton = RefreshButton;
		bool isEnabled = (((Control)RequestList).IsEnabled = !busy);
		((Control)refreshButton).IsEnabled = isEnabled;
		((Control)PreviousButton).IsEnabled = !busy && _page > 1;
		((Control)NextButton).IsEnabled = !busy && _page < _pages;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAsync(int page)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAsync_d__13 loadAsync_d__ = default(_LoadAsync_d__13);
		loadAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAsync_d__.__4__this = this;
		loadAsync_d__.page = page;
		loadAsync_d__.__1__state = -1;
		loadAsync_d__.__t__builder.Start<_LoadAsync_d__13>(ref loadAsync_d__);
		return loadAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__14_2 refreshButton_Click_d__14_ = default(_RefreshButton_Click_d__14_2);
		refreshButton_Click_d__14_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__14_.__4__this = this;
		refreshButton_Click_d__14_.__1__state = -1;
		refreshButton_Click_d__14_.__t__builder.Start<_RefreshButton_Click_d__14_2>(ref refreshButton_Click_d__14_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PreviousButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PreviousButton_Click_d__15 previousButton_Click_d__ = default(_PreviousButton_Click_d__15);
		previousButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		previousButton_Click_d__.__4__this = this;
		previousButton_Click_d__.__1__state = -1;
		previousButton_Click_d__.__t__builder.Start<_PreviousButton_Click_d__15>(ref previousButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void NextButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_NextButton_Click_d__16 nextButton_Click_d__ = default(_NextButton_Click_d__16);
		nextButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		nextButton_Click_d__.__4__this = this;
		nextButton_Click_d__.__1__state = -1;
		nextButton_Click_d__.__t__builder.Start<_NextButton_Click_d__16>(ref nextButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RequestList_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RequestList_SelectionChanged_d__17 requestList_SelectionChanged_d__ = default(_RequestList_SelectionChanged_d__17);
		requestList_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		requestList_SelectionChanged_d__.__4__this = this;
		requestList_SelectionChanged_d__.__1__state = -1;
		requestList_SelectionChanged_d__.__t__builder.Start<_RequestList_SelectionChanged_d__17>(ref requestList_SelectionChanged_d__);
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
			Uri val = new Uri("ms-appx:///UI/Controls/UserRefundRequestsView.xaml");
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
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Expected O, but got Unknown
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			PageText = CastExtensions.As<TextBlock>(target);
			break;
		case 3:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 4:
			RequestList = CastExtensions.As<ListView>(target);
			((Selector)RequestList).SelectionChanged += new SelectionChangedEventHandler(RequestList_SelectionChanged);
			break;
		case 5:
			ErrorText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			SummaryText = CastExtensions.As<TextBlock>(target);
			break;
		case 7:
			PlanText = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 13:
			PreviousButton = CastExtensions.As<Button>(target);
			((ButtonBase)PreviousButton).Click += new RoutedEventHandler(PreviousButton_Click);
			break;
		case 14:
			NextButton = CastExtensions.As<Button>(target);
			((ButtonBase)NextButton).Click += new RoutedEventHandler(NextButton_Click);
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
		if (connectionId == 9)
		{
			StackPanel val = (StackPanel)target;
			UserRefundRequestsView_obj9_Bindings userRefundRequestsView_obj9_Bindings = (UserRefundRequestsView_obj9_Bindings)new UserRefundRequestsView_obj9_Bindings();
			result = (IComponentConnector)(object)userRefundRequestsView_obj9_Bindings;
			userRefundRequestsView_obj9_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += userRefundRequestsView_obj9_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)userRefundRequestsView_obj9_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)userRefundRequestsView_obj9_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__6_0(object _, RoutedEventArgs _2)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

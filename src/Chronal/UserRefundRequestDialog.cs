using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using Em73oofeuZ8cicBolFHh;
using LlvQkpftcKTPAsaRP0ff;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using PXVa7OfezgywaA0jcqj9;
using WinRT;
using WinRT.ChronalVtableClasses;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_UserRefundRequestDialogWinRTTypeDetails))]
public sealed class UserRefundRequestDialog : ContentDialog, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OnLoaded_d__13 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestDialog __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestDialog userRefundRequestDialog = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					AppShell.SessionCleared += new EventHandler(userRefundRequestDialog.OnSessionCleared);
					_u__ = userRefundRequestDialog.PreviewAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__13>(ref _u__, ref this);
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
	private struct _OnPrimaryButtonClick_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public ContentDialogButtonClickEventArgs args;

		public UserRefundRequestDialog __4__this;

		private ContentDialogButtonClickDeferral _deferral_5__2;

		private bool _lookupOnly_5__3;

		private u0kZmvfenFahk4yQUbNZ _result_5__4;

		private int __7__wrap4;

		private TaskAwaiter<u0kZmvfenFahk4yQUbNZ> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestDialog userRefundRequestDialog = __4__this;
			try
			{
				if ((uint)num <= 2u)
				{
					goto IL_00cb;
				}
				args.Cancel = true;
				if (userRefundRequestDialog.IsCurrent && !userRefundRequestDialog._busy && !userRefundRequestDialog._finished && userRefundRequestDialog._plan != null && (userRefundRequestDialog._submitted || ((ToggleButton)userRefundRequestDialog.ConfirmBox).IsChecked == true))
				{
					_deferral_5__2 = args.GetDeferral();
					userRefundRequestDialog._busy = true;
					_lookupOnly_5__3 = userRefundRequestDialog._submitted;
					if (!userRefundRequestDialog._submitted)
					{
						userRefundRequestDialog._submittedReason = userRefundRequestDialog.ReasonBox.Text.Trim();
					}
					userRefundRequestDialog._submitted = true;
					userRefundRequestDialog.UpdateButtons();
					goto IL_00cb;
				}
				goto end_IL_0011;
				IL_00cb:
				try
				{
					TaskAwaiter<u0kZmvfenFahk4yQUbNZ> _u__ = default;
					if ((uint)num > 1u)
					{
						if (num == 2)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<u0kZmvfenFahk4yQUbNZ>);
							num = (__1__state = -1);
							goto IL_02e9;
						}
						__7__wrap4 = 0;
					}
					u0kZmvfenFahk4yQUbNZ result;
					try
					{
						if (num != 0)
						{
							if (num != 1)
							{
								if (_lookupOnly_5__3)
								{
									_u__ = AppShell.Api.uOYyZa5IXZ(userRefundRequestDialog._requestNo, userRefundRequestDialog._lifetime.Token).GetAwaiter();
									if (!_u__.IsCompleted)
									{
										num = (__1__state = 0);
										__u__1 = _u__;
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<u0kZmvfenFahk4yQUbNZ>, _OnPrimaryButtonClick_d__20>(ref _u__, ref this);
										return;
									}
									goto IL_0168;
								}
								_u__ = AppShell.Api.uqqyf83shx(userRefundRequestDialog._orderId, userRefundRequestDialog._requestNo, userRefundRequestDialog._submittedReason, userRefundRequestDialog._plan, userRefundRequestDialog._lifetime.Token).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 1);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<u0kZmvfenFahk4yQUbNZ>, _OnPrimaryButtonClick_d__20>(ref _u__, ref this);
									return;
								}
							}
							else
							{
								_u__ = __u__1;
								__u__1 = default(TaskAwaiter<u0kZmvfenFahk4yQUbNZ>);
								num = (__1__state = -1);
							}
							result = _u__.GetResult();
							goto IL_01fe;
						}
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<u0kZmvfenFahk4yQUbNZ>);
						num = (__1__state = -1);
						goto IL_0168;
						IL_0168:
						result = _u__.GetResult();
						goto IL_01fe;
						IL_01fe:
						_result_5__4 = result;
					}
					catch (global::System.Exception) when (userRefundRequestDialog.IsCurrent && !userRefundRequestDialog._lifetime.IsCancellationRequested && !_lookupOnly_5__3)
					{
						__7__wrap4 = 1;
					}
					int num2 = __7__wrap4;
					if (num2 == 1)
					{
						userRefundRequestDialog.ResultText.Text = "提交响应未收到，正在只读核对原申请；这不代表退款失败。";
						_u__ = AppShell.Api.uOYyZa5IXZ(userRefundRequestDialog._requestNo, userRefundRequestDialog._lifetime.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 2);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<u0kZmvfenFahk4yQUbNZ>, _OnPrimaryButtonClick_d__20>(ref _u__, ref this);
							return;
						}
						goto IL_02e9;
					}
					goto IL_02f8;
					IL_02e9:
					result = _u__.GetResult();
					_result_5__4 = result;
					goto IL_02f8;
					IL_02f8:
					if (userRefundRequestDialog.IsCurrent)
					{
						if (_result_5__4.Record.RequestNo != userRefundRequestDialog._requestNo || _result_5__4.Record.OrderId != userRefundRequestDialog._orderId)
						{
							throw new InvalidOperationException("退款申请不匹配");
						}
						string status = _result_5__4.Record.Status;
						bool finished = ((status == "succeeded" || status == "failed" || status == "rejected") ? true : false);
						userRefundRequestDialog._finished = finished;
						((ContentDialog)userRefundRequestDialog).PrimaryButtonText = "只读刷新退款结果";
						userRefundRequestDialog.ResultText.Text = _result_5__4.Record.SummaryText + Environment.NewLine + "可在退款历史的“我的退款申请”中查看进度。";
						if (_result_5__4.Record.Status == "unknown")
						{
							TextBlock resultText = userRefundRequestDialog.ResultText;
							resultText.Text = resultText.Text + Environment.NewLine + "申请已受理，支付站未返回可确认的结果，资金可能已退回；请勿再次退款，需管理员核对支付站，资产状态单独记录。";
						}
						_result_5__4 = null;
					}
				}
				catch (global::System.Exception obj) when (obj is OperationCanceledException && userRefundRequestDialog._lifetime.IsCancellationRequested)
				{
				}
				catch (global::System.Exception)
				{
					if (userRefundRequestDialog.IsCurrent)
					{
						userRefundRequestDialog.ResultText.Text = "暂未取得退款结果，这不代表退款失败。请只读刷新原申请或到退款历史核对，不要新建退款。";
						((ContentDialog)userRefundRequestDialog).PrimaryButtonText = "只读刷新退款结果";
					}
				}
				finally
				{
					if (num < 0)
					{
						userRefundRequestDialog._busy = false;
						if (userRefundRequestDialog.IsCurrent)
						{
							userRefundRequestDialog.UpdateButtons();
						}
						_deferral_5__2.Complete();
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
	private struct _PreviewAsync_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public UserRefundRequestDialog __4__this;

		private TaskAwaiter<bt5vf8fepM1aCnrtDLQ1> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			UserRefundRequestDialog userRefundRequestDialog = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0081;
				}
				if (userRefundRequestDialog.IsCurrent && !userRefundRequestDialog._busy && !userRefundRequestDialog._submitted)
				{
					userRefundRequestDialog._busy = true;
					userRefundRequestDialog._plan = null;
					((ToggleButton)userRefundRequestDialog.ConfirmBox).IsChecked = false;
					TextBlock planText = userRefundRequestDialog.PlanText;
					string text = (userRefundRequestDialog.ResultText.Text = string.Empty);
					planText.Text = text;
					userRefundRequestDialog.UpdateButtons();
					goto IL_0081;
				}
				goto end_IL_0011;
				IL_0081:
				try
				{
					TaskAwaiter<bt5vf8fepM1aCnrtDLQ1> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.dngyXtYIVi(userRefundRequestDialog._orderId, userRefundRequestDialog._lifetime.Token).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bt5vf8fepM1aCnrtDLQ1>, _PreviewAsync_d__18>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bt5vf8fepM1aCnrtDLQ1>);
						num = (__1__state = -1);
					}
					bt5vf8fepM1aCnrtDLQ1 result = _u__.GetResult();
					if (userRefundRequestDialog.IsCurrent)
					{
						userRefundRequestDialog._plan = result;
						userRefundRequestDialog.PlanText.Text = result.DisplayText;
						((ContentDialog)userRefundRequestDialog).PrimaryButtonText = (result.RequiresReview ? "提交管理员审核" : "确认退款并追回资产");
					}
				}
				catch (global::System.Exception obj) when (obj is OperationCanceledException && userRefundRequestDialog._lifetime.IsCancellationRequested)
				{
				}
				catch (global::System.Exception exception)
				{
					if (userRefundRequestDialog.IsCurrent)
					{
						userRefundRequestDialog.ResultText.Text = AppShell.GetExceptionDisplayMessage(exception, "PreviewAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\UserRefundRequestDialog.xaml.cs", 83);
					}
				}
				finally
				{
					if (num < 0)
					{
						userRefundRequestDialog._busy = false;
						if (userRefundRequestDialog.IsCurrent)
						{
							userRefundRequestDialog.UpdateButtons();
						}
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
	private struct _RecalculateButton_Click_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public UserRefundRequestDialog __4__this;

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
			UserRefundRequestDialog userRefundRequestDialog = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = userRefundRequestDialog.PreviewAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RecalculateButton_Click_d__19>(ref _u__, ref this);
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

	private readonly long _orderId;

	private readonly long _ownerId;

	private readonly string _requestNo;

	private readonly CancellationTokenSource _lifetime;

	private bt5vf8fepM1aCnrtDLQ1? _plan;

	private string _submittedReason;

	private bool _active;

	private bool _busy;

	private bool _submitted;

	private bool _finished;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock PlanText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ReasonBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private CheckBox ConfirmBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RecalculateButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock ResultText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

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
	public UserRefundRequestDialog(long orderId)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		_requestNo = ((object)Guid.NewGuid()/*cast due to .constrained prefix*/).ToString();
		_lifetime = new CancellationTokenSource();
		_submittedReason = string.Empty;
		_active = true;
		_orderId = orderId;
		dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
		_ownerId = ((currentUser != null) ? currentUser.Id : 0);
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
		((ContentDialog)this).PrimaryButtonClick += OnPrimaryButtonClick;
		((ToggleButton)ConfirmBox).Checked += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			UpdateButtons();
		});
		((ToggleButton)ConfirmBox).Unchecked += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			UpdateButtons();
		});
		ReasonBox.TextChanged += (TextChangedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, TextChangedEventArgs _) =>
		{
			UpdateButtons();
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLoaded_d__13 onLoaded_d__ = default(_OnLoaded_d__13);
		onLoaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__.__4__this = this;
		onLoaded_d__.__1__state = -1;
		onLoaded_d__.__t__builder.Start<_OnLoaded_d__13>(ref onLoaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		Clear();
		_lifetime.Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		Clear();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Clear()
	{
		if (_active)
		{
			_active = false;
			_lifetime.Cancel();
			_plan = null;
			TextBlock planText = PlanText;
			TextBlock resultText = ResultText;
			string text = (ReasonBox.Text = (_submittedReason = string.Empty));
			string text3 = (resultText.Text = text);
			planText.Text = text3;
			((ContentDialog)this).IsPrimaryButtonEnabled = false;
			((ContentDialog)this).Hide();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateButtons()
	{
		LoadingRing.IsActive = _busy;
		TextBox reasonBox = ReasonBox;
		bool isEnabled = (((Control)ConfirmBox).IsEnabled = !_busy && !_submitted);
		((Control)reasonBox).IsEnabled = isEnabled;
		((Control)RecalculateButton).IsEnabled = IsCurrent && !_busy && !_submitted;
		((ContentDialog)this).IsPrimaryButtonEnabled = IsCurrent && !_busy && !_finished && _plan != null && (_submitted || (((ToggleButton)ConfirmBox).IsChecked == true && !string.IsNullOrWhiteSpace(ReasonBox.Text)));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task PreviewAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PreviewAsync_d__18 previewAsync_d__ = default(_PreviewAsync_d__18);
		previewAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		previewAsync_d__.__4__this = this;
		previewAsync_d__.__1__state = -1;
		previewAsync_d__.__t__builder.Start<_PreviewAsync_d__18>(ref previewAsync_d__);
		return previewAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RecalculateButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RecalculateButton_Click_d__19 recalculateButton_Click_d__ = default(_RecalculateButton_Click_d__19);
		recalculateButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		recalculateButton_Click_d__.__4__this = this;
		recalculateButton_Click_d__.__1__state = -1;
		recalculateButton_Click_d__.__t__builder.Start<_RecalculateButton_Click_d__19>(ref recalculateButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnPrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnPrimaryButtonClick_d__20 onPrimaryButtonClick_d__ = default(_OnPrimaryButtonClick_d__20);
		onPrimaryButtonClick_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onPrimaryButtonClick_d__.__4__this = this;
		onPrimaryButtonClick_d__.args = args;
		onPrimaryButtonClick_d__.__1__state = -1;
		onPrimaryButtonClick_d__.__t__builder.Start<_OnPrimaryButtonClick_d__20>(ref onPrimaryButtonClick_d__);
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
			Uri val = new Uri("ms-appx:///UI/Controls/UserRefundRequestDialog.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
			break;
		case 3:
			PlanText = CastExtensions.As<TextBlock>(target);
			break;
		case 4:
			ReasonBox = CastExtensions.As<TextBox>(target);
			break;
		case 5:
			ConfirmBox = CastExtensions.As<CheckBox>(target);
			break;
		case 6:
			RecalculateButton = CastExtensions.As<Button>(target);
			((ButtonBase)RecalculateButton).Click += new RoutedEventHandler(RecalculateButton_Click);
			break;
		case 7:
			ResultText = CastExtensions.As<TextBlock>(target);
			break;
		}
		_contentLoaded = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public IComponentConnector GetBindingConnector(int connectionId, object target)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__10_0(object _, RoutedEventArgs _2)
	{
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__10_1(object _, RoutedEventArgs _2)
	{
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__10_2(object _, TextChangedEventArgs _2)
	{
		UpdateButtons();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

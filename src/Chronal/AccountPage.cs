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
using CommunityToolkit.WinUI.Controls;
using FXwhkifOd0mJIMiQqRWJ;
using MQoh6BfOCL7YieMsY4S3;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Shell;
using Mb9AMcfOTACDN3sMXWGZ;
using MbgJAqLroveeTUtcYc7g;
using Microsoft.UI.Dispatching;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Navigation;
using WinRT;
using WinRT.ChronalVtableClasses;
using aT519UfO3d6PYepiHMHC;
using bUfedyCg1PBqhqIkB8r;
using bYA5I0fO6k3f6mkMsqrr;
using cYolIrfOpCRwrB3GW6Hh;
using fJI2ftf5SouLKttbv85L;
using jgG5Q9fOOsLROSquOFjg;
using qS8vkpL43FlTMgcj0rgs;
using r7Ay0KfOPrf3aPybRli9;
using yk0qylfOoLyWUHolY5pj;
using zDw8FCfOEDpLHSbKqHHt;

namespace Mahiro_Account.Views.Pages;

[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class AccountPage : Page, IComponentConnector
{
	private enum RebindStage
	{
		Request,
		OldConfirm,
		NewVerify,
		LinkPending
	}

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private interface IAccountPage_Bindings
	{
		void Initialize();

		void Update();

		void StopTracking();

		void DisconnectUnloadedObject(int connectionId);
	}

	private interface IAccountPage_BindingsScopeConnector
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
		private static void _cctor()
		{
		}
	}

	[WinRTExposedType(typeof(Mahiro_Account_Views_Pages_HomePage_HomePage_obj4_BindingsWinRTTypeDetails))]
	[WinRTRuntimeClassName("Microsoft.UI.Xaml.IDataTemplateExtension")]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private class AccountPage_obj8_Bindings : IDataTemplateExtension, IDataTemplateComponent, IComponentConnector, IAccountPage_Bindings
	{
		private PqFZUVfO1JCpVlryjUX8 dataRoot;

		private bool initialized;

		private const int NOT_PHASED = -2147483648;

		private const int DATA_CHANGED = 1073741824;

		private bool removedDataContextHandler;

		private WeakReference obj8;

		private TextBlock obj9;

		private TextBlock obj11;

		private TextBlock obj12;

		[MethodImpl((MethodImplOptions)8)]
		public AccountPage_obj8_Bindings()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		public void Connect(int connectionId, object target)
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Expected O, but got Unknown
			switch (connectionId)
			{
			case 8:
				obj8 = new WeakReference((object)CastExtensions.As<Grid>(target));
				break;
			case 9:
				obj9 = CastExtensions.As<TextBlock>(target);
				break;
			case 11:
				obj11 = CastExtensions.As<TextBlock>(target);
				break;
			case 12:
				obj12 = CastExtensions.As<TextBlock>(target);
				break;
			case 10:
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
			Update_(CastExtensions.As<PqFZUVfO1JCpVlryjUX8>(item), 1 << phase);
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
				dataRoot = CastExtensions.As<PqFZUVfO1JCpVlryjUX8>(newDataRoot);
				return true;
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_(PqFZUVfO1JCpVlryjUX8 obj, int phase)
		{
			if (obj != null && (phase & -2147483647) != 0)
			{
				Update_CreatedAtText(obj.CreatedAtText, phase);
				Update_DisplayName(obj.DisplayName, phase);
				Update_MetaText(obj.MetaText, phase);
				Update_AutoUnsubscribeText(obj.AutoUnsubscribeText, phase);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_CreatedAtText(string obj, int phase)
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
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj11, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_MetaText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_TextBlock_Text(obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private void Update_AutoUnsubscribeText(string obj, int phase)
		{
			if ((phase & -2147483647) != 0)
			{
				XamlBindingSetters.Set_Microsoft_UI_Xaml_Controls_ToolTipService_ToolTip((DependencyObject)(object)obj12, obj, null);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_19
	{
		public static readonly __c_19 __9;

		public static Func<PqFZUVfO1JCpVlryjUX8, long> __9__24_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c_19()
		{
			__9 = (__c_19)new __c_19();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_19()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal long _LoadSubscriptionsAsync_b__24_0(PqFZUVfO1JCpVlryjUX8 item)
		{
			return item.ProductId;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass17_0_3
	{
		[StructLayout((LayoutKind)3)]
		private struct __ShowRebindDialogAsync_b__6_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public __c__DisplayClass17_0_3 __4__this;

			private TaskAwaiter __u__1;

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
				__c__DisplayClass17_0_3 _c__DisplayClass17_0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						((Control)_c__DisplayClass17_0_.resendButton).IsEnabled = false;
						_u__ = _c__DisplayClass17_0_._ShowRebindDialogAsync_g__RequestRebindAsync_5().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ShowRebindDialogAsync_b__6_d>(ref _u__, ref this);
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
		private struct __ShowRebindDialogAsync_b__7_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass17_0_3 __4__this;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private TaskAwaiter __u__1;

			private TaskAwaiter<AdhqjEfO5ttEUU2Ut1eS> __u__2;

			private TaskAwaiter<EyIZsdfOl4aMc0KMHmOg> __u__3;

			private TaskAwaiter<tR6PgnfOrMtDaK70FTsD> __u__4;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0415: Expected O, but got Unknown
				//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
				//IL_00af: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
				//IL_0145: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0269: Unknown result type (might be due to invalid IL or missing references)
				//IL_026e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0276: Unknown result type (might be due to invalid IL or missing references)
				//IL_0301: Unknown result type (might be due to invalid IL or missing references)
				//IL_0306: Unknown result type (might be due to invalid IL or missing references)
				//IL_030e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_0090: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_010d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0112: Unknown result type (might be due to invalid IL or missing references)
				//IL_0231: Unknown result type (might be due to invalid IL or missing references)
				//IL_0236: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
				//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
				//IL_012a: Unknown result type (might be due to invalid IL or missing references)
				//IL_012c: Unknown result type (might be due to invalid IL or missing references)
				//IL_024e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0250: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass17_0_3 _c__DisplayClass17_0_ = __4__this;
				try
				{
					if ((uint)num > 3u)
					{
						_deferral_5__2 = args.GetDeferral();
						args.Cancel = true;
					}
					Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
					try
					{
						TaskAwaiter _u__4 = default;
						TaskAwaiter<AdhqjEfO5ttEUU2Ut1eS> _u__3 = default;
						TaskAwaiter<EyIZsdfOl4aMc0KMHmOg> _u__2 = default;
						TaskAwaiter<tR6PgnfOrMtDaK70FTsD> _u__ = default;
						string text = default;
						string text2;
						AdhqjEfO5ttEUU2Ut1eS result;
						switch (num)
						{
						default:
							switch (_c__DisplayClass17_0_.stage)
							{
							case RebindStage.Request:
								goto IL_006e;
							case RebindStage.OldConfirm:
								goto IL_00d1;
							case RebindStage.NewVerify:
								goto IL_01f5;
							case RebindStage.LinkPending:
								goto IL_02bf;
							}
							goto end_IL_0036;
						case 0:
							_u__4 = __u__1;
							__u__1 = default(TaskAwaiter);
							num = (__1__state = -1);
							goto IL_00c5;
						case 1:
							_u__3 = __u__2;
							__u__2 = default(TaskAwaiter<AdhqjEfO5ttEUU2Ut1eS>);
							num = (__1__state = -1);
							goto IL_0161;
						case 2:
							_u__2 = __u__3;
							__u__3 = default(TaskAwaiter<EyIZsdfOl4aMc0KMHmOg>);
							num = (__1__state = -1);
							goto IL_0285;
						case 3:
							{
								_u__ = __u__4;
								__u__4 = default(TaskAwaiter<tR6PgnfOrMtDaK70FTsD>);
								num = (__1__state = -1);
								break;
							}
							IL_02bf:
							_u__ = AppShell.Api.Vh0cHLpAgq().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 3);
								__u__4 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tR6PgnfOrMtDaK70FTsD>, __ShowRebindDialogAsync_b__7_d>(ref _u__, ref this);
								return;
							}
							break;
							IL_00c5:
							_u__4.GetResult();
							goto end_IL_0036;
							IL_01f5:
							text = _c__DisplayClass17_0_.codeBox.Text.Trim();
							if (text.Length != 0)
							{
								_u__2 = AppShell.Api.NgicOYuf4n(text, (string)null).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 2);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<EyIZsdfOl4aMc0KMHmOg>, __ShowRebindDialogAsync_b__7_d>(ref _u__2, ref this);
									return;
								}
								goto IL_0285;
							}
							_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入新邮箱收到的验证码");
							goto end_IL_0036;
							IL_006e:
							_u__4 = _c__DisplayClass17_0_._ShowRebindDialogAsync_g__RequestRebindAsync_5().GetAwaiter();
							if (!_u__4.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__4;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ShowRebindDialogAsync_b__7_d>(ref _u__4, ref this);
								return;
							}
							goto IL_00c5;
							IL_00d1:
							text2 = _c__DisplayClass17_0_.codeBox.Text.Trim();
							if (text2.Length != 0)
							{
								_u__3 = AppShell.Api.Oelc634Mc2(text2, (string)null).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<AdhqjEfO5ttEUU2Ut1eS>, __ShowRebindDialogAsync_b__7_d>(ref _u__3, ref this);
									return;
								}
								goto IL_0161;
							}
							_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入旧邮箱收到的确认码");
							goto end_IL_0036;
							IL_0161:
							result = _u__3.GetResult();
							if (!result.Ok)
							{
								_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "确认码不正确，请重新输入");
							}
							else
							{
								_c__DisplayClass17_0_.stage = RebindStage.NewVerify;
								_c__DisplayClass17_0_.codeBox.Text = string.Empty;
								_c__DisplayClass17_0_.codeBox.Header = "新邮箱收到的验证码";
								_c__DisplayClass17_0_.dialog.PrimaryButtonText = "完成换绑";
								_c__DisplayClass17_0_.instructionText.Text = "旧邮箱已确认，请输入新邮箱收到的验证码完成换绑。";
								_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, "验证码已发送到新邮箱" + ShellView.FormatTtl(result.TtlMinutes) + "。");
							}
							goto end_IL_0036;
							IL_0285:
							if (_u__2.GetResult().Ok)
							{
								_c__DisplayClass17_0_.completed = true;
								args.Cancel = false;
							}
							else
							{
								_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "验证码不正确，请重新输入");
							}
							goto end_IL_0036;
						}
						tR6PgnfOrMtDaK70FTsD result2 = _u__.GetResult();
						if (result2.EmailVerified && !string.Equals(result2.DisplayEmail, _c__DisplayClass17_0_.previousEmail, (StringComparison)5))
						{
							_c__DisplayClass17_0_.completed = true;
							args.Cancel = false;
						}
						else
						{
							_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, "还没有检测到换绑完成，请先在浏览器里打开邮件中的链接");
						}
						end_IL_0036:;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is Fx92Odf5YJhjb4F5o23y) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result3);
						if (obj2 == null)
						{
							result3 = 0;
						}
						else
						{
							val = (Fx92Odf5YJhjb4F5o23y)obj2;
							result3 = (val.IsRateLimited ? 1 : 0);
						}
						return (byte)result3 != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 482);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, $"操作过于频繁，请 {num2} 秒后再试");
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 488);
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, ((global::System.Exception)(object)val3).Message);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, AppShell.GetExceptionDisplayMessage(exception, "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 493));
					}
					finally
					{
						if (num < 0)
						{
							_deferral_5__2.Complete();
						}
					}
				}
				catch (global::System.Exception exception2)
				{
					__1__state = -2;
					_deferral_5__2 = null;
					__t__builder.SetException(exception2);
					return;
				}
				__1__state = -2;
				_deferral_5__2 = null;
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
		private struct __ShowRebindDialogAsync_g__RequestRebindAsync_5_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass17_0_3 __4__this;

			private TaskAwaiter<Kvpi89fOtJCpq5YOJS6L> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_015f: Expected O, but got Unknown
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0093: Unknown result type (might be due to invalid IL or missing references)
				//IL_009b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Unknown result type (might be due to invalid IL or missing references)
				//IL_005b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0075: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass17_0_3 _c__DisplayClass17_0_ = __4__this;
				try
				{
					if (num == 0)
					{
						goto IL_0045;
					}
					string text = _c__DisplayClass17_0_.newEmailBox.Text.Trim();
					if (ShellView.IsValidEmail(text))
					{
						goto IL_0045;
					}
					_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入有效的新邮箱地址");
					goto end_IL_0011;
					IL_0045:
						text = default;
					Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
					try
					{
						TaskAwaiter<Kvpi89fOtJCpq5YOJS6L> _u__ = default;
						if (num != 0)
						{
							_u__ = AppShell.Api.WqJc5xKJZr(text).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Kvpi89fOtJCpq5YOJS6L>, __ShowRebindDialogAsync_g__RequestRebindAsync_5_d>(ref _u__, ref this);
								return;
							}
						}
						else
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<Kvpi89fOtJCpq5YOJS6L>);
							num = (__1__state = -1);
						}
						Kvpi89fOtJCpq5YOJS6L result = _u__.GetResult();
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ApplyRequestResult_4(result);
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						object obj2 = ((obj is Fx92Odf5YJhjb4F5o23y) ? obj : null);
						global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
						if (obj2 == null)
						{
							result2 = 0;
						}
						else
						{
							val = (Fx92Odf5YJhjb4F5o23y)obj2;
							result2 = (val.IsRateLimited ? 1 : 0);
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 377);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__StartCooldown_2(num2);
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, $"操作过于频繁，请 {num2} 秒后再试");
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 384);
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, ((global::System.Exception)(object)val3).Message);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass17_0_._ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, AppShell.GetExceptionDisplayMessage(exception, "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 389));
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

		public InfoBar messageBar;

		public int remainingSeconds;

		public DispatcherQueueTimer resendTimer;

		public Button resendButton;

		public TextBox newEmailBox;

		public bool isLink;

		public RebindStage stage;

		public TextBox codeBox;

		public ContentDialog dialog;

		public TextBlock instructionText;

		public bool completed;

		public string previousEmail;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass17_0_3()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_g__ShowMessage_0(InfoBarSeverity severity, string message)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			messageBar.Severity = severity;
			messageBar.Message = message;
			NotificationAutoDismiss.Show(messageBar);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_g__StopCooldown_1()
		{
			remainingSeconds = 0;
			DispatcherQueueTimer obj = resendTimer;
			if (obj != null)
			{
				obj.Stop();
			}
			((ContentControl)resendButton).Content = "重新发送";
			((Control)resendButton).IsEnabled = true;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_g__StartCooldown_2(int seconds)
		{
			if (resendTimer == null)
			{
				((Control)resendButton).IsEnabled = true;
				return;
			}
			remainingSeconds = Math.Clamp(seconds, 1, 3600);
			((Control)resendButton).IsEnabled = false;
			((ContentControl)resendButton).Content = $"{remainingSeconds} 秒后可重发";
			resendTimer.Start();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_b__3(DispatcherQueueTimer _, object _2)
		{
			remainingSeconds--;
			if (remainingSeconds <= 0)
			{
				_ShowRebindDialogAsync_g__StopCooldown_1();
				return;
			}
			((ContentControl)resendButton).Content = $"{remainingSeconds} 秒后可重发";
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_g__ApplyRequestResult_4(Kvpi89fOtJCpq5YOJS6L response)
		{
			newEmailBox.IsReadOnly = true;
			((UIElement)resendButton).Visibility = (Visibility)0;
			_ShowRebindDialogAsync_g__StartCooldown_2((response.ResendAfterSeconds > 0) ? response.ResendAfterSeconds : 60);
			bool num = nkelP9fOQIfs4dM8xou1.i2tfO4KYbqq(response.Method) | isLink;
			string text = ShellView.FormatTtl(response.TtlMinutes);
			if (num)
			{
				stage = RebindStage.LinkPending;
				((UIElement)codeBox).Visibility = (Visibility)1;
				dialog.PrimaryButtonText = "我已完成换绑";
				instructionText.Text = "换绑邮件已发送，请在浏览器中按邮件里的链接依次完成确认，然后回到这里点「我已完成换绑」。";
				_ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, "换绑邮件已发送" + text + "。");
				return;
			}
			((UIElement)codeBox).Visibility = (Visibility)0;
			codeBox.Text = string.Empty;
			if (response.RequiresOldConfirm)
			{
				stage = RebindStage.OldConfirm;
				codeBox.Header = "旧邮箱收到的确认码";
				dialog.PrimaryButtonText = "确认旧邮箱";
				instructionText.Text = "为确认是本人操作，我们向旧邮箱发送了确认码，请先输入它。";
				_ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, "确认码已发送到旧邮箱" + text + "。");
			}
			else
			{
				stage = RebindStage.NewVerify;
				codeBox.Header = "新邮箱收到的验证码";
				dialog.PrimaryButtonText = "完成换绑";
				instructionText.Text = "请输入新邮箱收到的验证码以完成换绑。";
				_ShowRebindDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, "验证码已发送到新邮箱" + text + "。");
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _ShowRebindDialogAsync_g__RequestRebindAsync_5()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowRebindDialogAsync_g__RequestRebindAsync_5_d _ShowRebindDialogAsync_g__RequestRebindAsync_5_d = default(__ShowRebindDialogAsync_g__RequestRebindAsync_5_d);
			_ShowRebindDialogAsync_g__RequestRebindAsync_5_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_ShowRebindDialogAsync_g__RequestRebindAsync_5_d.__4__this = this;
			_ShowRebindDialogAsync_g__RequestRebindAsync_5_d.__1__state = -1;
			_ShowRebindDialogAsync_g__RequestRebindAsync_5_d.__t__builder.Start<__ShowRebindDialogAsync_g__RequestRebindAsync_5_d>(ref _ShowRebindDialogAsync_g__RequestRebindAsync_5_d);
			return _ShowRebindDialogAsync_g__RequestRebindAsync_5_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowRebindDialogAsync_b__6(object _, RoutedEventArgs _2)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowRebindDialogAsync_b__6_d _ShowRebindDialogAsync_b__6_d = default(__ShowRebindDialogAsync_b__6_d);
			_ShowRebindDialogAsync_b__6_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowRebindDialogAsync_b__6_d.__4__this = this;
			_ShowRebindDialogAsync_b__6_d.__1__state = -1;
			_ShowRebindDialogAsync_b__6_d.__t__builder.Start<__ShowRebindDialogAsync_b__6_d>(ref _ShowRebindDialogAsync_b__6_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowRebindDialogAsync_b__7(ContentDialog _, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowRebindDialogAsync_b__7_d _ShowRebindDialogAsync_b__7_d = default(__ShowRebindDialogAsync_b__7_d);
			_ShowRebindDialogAsync_b__7_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowRebindDialogAsync_b__7_d.__4__this = this;
			_ShowRebindDialogAsync_b__7_d.args = args;
			_ShowRebindDialogAsync_b__7_d.__1__state = -1;
			_ShowRebindDialogAsync_b__7_d.__t__builder.Start<__ShowRebindDialogAsync_b__7_d>(ref _ShowRebindDialogAsync_b__7_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowRebindDialogAsync_b__8(ContentDialog _, ContentDialogClosingEventArgs _2)
		{
			DispatcherQueueTimer obj = resendTimer;
			if (obj != null)
			{
				obj.Stop();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass18_0_7
	{
		[StructLayout((LayoutKind)3)]
		private struct __ShowUnbindDialogAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass18_0_7 __4__this;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private TaskAwaiter<UPx3DCfOe3MHBypQJFDr> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_01e6: Expected O, but got Unknown
				//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass18_0_7 _c__DisplayClass18_0_ = __4__this;
				try
				{
					if (num != 0)
					{
						_deferral_5__2 = args.GetDeferral();
						args.Cancel = true;
					}
					Fx92Odf5YJhjb4F5o23y val = default(Fx92Odf5YJhjb4F5o23y);
					try
					{
						TaskAwaiter<UPx3DCfOe3MHBypQJFDr> _u__ = default;
						if (num == 0)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<UPx3DCfOe3MHBypQJFDr>);
							num = (__1__state = -1);
							goto IL_00e2;
						}
						if (_c__DisplayClass18_0_.passwordBox.Password.Length != 0)
						{
							_u__ = AppShell.Api.wewcRBH7rH(_c__DisplayClass18_0_.passwordBox.Password).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UPx3DCfOe3MHBypQJFDr>, __ShowUnbindDialogAsync_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_00e2;
						}
						_c__DisplayClass18_0_.messageBar.Severity = (InfoBarSeverity)3;
						_c__DisplayClass18_0_.messageBar.Message = "请输入账号密码";
						NotificationAutoDismiss.Show(_c__DisplayClass18_0_.messageBar);
						goto end_IL_0035;
						IL_00e2:
						if (_u__.GetResult().Ok)
						{
							_c__DisplayClass18_0_.unbound = true;
							args.Cancel = false;
						}
						else
						{
							_c__DisplayClass18_0_.messageBar.Severity = (InfoBarSeverity)3;
							_c__DisplayClass18_0_.messageBar.Message = "解绑失败，请稍后重试";
							NotificationAutoDismiss.Show(_c__DisplayClass18_0_.messageBar);
						}
						end_IL_0035:;
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
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowUnbindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 600);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass18_0_.messageBar.Severity = (InfoBarSeverity)2;
						_c__DisplayClass18_0_.messageBar.Message = $"操作过于频繁，请 {num2} 秒后再试";
						NotificationAutoDismiss.Show(_c__DisplayClass18_0_.messageBar);
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowUnbindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 608);
						_c__DisplayClass18_0_.messageBar.Severity = (InfoBarSeverity)3;
						_c__DisplayClass18_0_.messageBar.Message = ((global::System.Exception)(object)val3).Message;
						NotificationAutoDismiss.Show(_c__DisplayClass18_0_.messageBar);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass18_0_.messageBar.Severity = (InfoBarSeverity)3;
						_c__DisplayClass18_0_.messageBar.Message = AppShell.GetExceptionDisplayMessage(exception, "ShowUnbindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 616);
						NotificationAutoDismiss.Show(_c__DisplayClass18_0_.messageBar);
					}
					finally
					{
						if (num < 0)
						{
							_deferral_5__2.Complete();
						}
					}
				}
				catch (global::System.Exception exception2)
				{
					__1__state = -2;
					_deferral_5__2 = null;
					__t__builder.SetException(exception2);
					return;
				}
				__1__state = -2;
				_deferral_5__2 = null;
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

		public PasswordBox passwordBox;

		public InfoBar messageBar;

		public bool unbound;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass18_0_7()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowUnbindDialogAsync_b__0(ContentDialog _, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowUnbindDialogAsync_b__0_d _ShowUnbindDialogAsync_b__0_d = default(__ShowUnbindDialogAsync_b__0_d);
			_ShowUnbindDialogAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowUnbindDialogAsync_b__0_d.__4__this = this;
			_ShowUnbindDialogAsync_b__0_d.args = args;
			_ShowUnbindDialogAsync_b__0_d.__1__state = -1;
			_ShowUnbindDialogAsync_b__0_d.__t__builder.Start<__ShowUnbindDialogAsync_b__0_d>(ref _ShowUnbindDialogAsync_b__0_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass25_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __CancelSubscriptionButton_Click_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncTaskMethodBuilder __t__builder;

			public __c__DisplayClass25_0_1 __4__this;

			private TaskAwaiter<UPx3DCfOe3MHBypQJFDr> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006e: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0031: Unknown result type (might be due to invalid IL or missing references)
				//IL_0048: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass25_0_1 _c__DisplayClass25_0_ = __4__this;
				try
				{
					TaskAwaiter<UPx3DCfOe3MHBypQJFDr> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.nUMcsCyNtl(_c__DisplayClass25_0_.item.ProductId).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<UPx3DCfOe3MHBypQJFDr>, __CancelSubscriptionButton_Click_b__0_d>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<UPx3DCfOe3MHBypQJFDr>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
					((Collection<PqFZUVfO1JCpVlryjUX8>)(object)_c__DisplayClass25_0_.__4__this._subscriptions).Remove(_c__DisplayClass25_0_.item);
					ShellView.SetStockSubscriptionState(_c__DisplayClass25_0_.item.ProductId, subscribed: false);
					AppShell.Info("已取消该商品的到货提醒");
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

		public PqFZUVfO1JCpVlryjUX8 item;

		public AccountPage __4__this;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass25_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal global::System.Threading.Tasks.Task _CancelSubscriptionButton_Click_b__0()
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__CancelSubscriptionButton_Click_b__0_d _CancelSubscriptionButton_Click_b__0_d = default(__CancelSubscriptionButton_Click_b__0_d);
			_CancelSubscriptionButton_Click_b__0_d.__t__builder = AsyncTaskMethodBuilder.Create();
			_CancelSubscriptionButton_Click_b__0_d.__4__this = this;
			_CancelSubscriptionButton_Click_b__0_d.__1__state = -1;
			_CancelSubscriptionButton_Click_b__0_d.__t__builder.Start<__CancelSubscriptionButton_Click_b__0_d>(ref _CancelSubscriptionButton_Click_b__0_d);
			return _CancelSubscriptionButton_Click_b__0_d.__t__builder.Task;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _BindEmailButton_Click_d__14 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				TaskAwaiter<bool> _u__2 = default;
				if (num != 0)
				{
					if (num == 1)
					{
						_u__ = __u__2;
						__u__2 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00de;
					}
					_u__2 = ShellView.ShowEmailBindingFlowAsync().GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _BindEmailButton_Click_d__14>(ref _u__2, ref this);
						return;
					}
				}
				else
				{
					_u__2 = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
				}
				_u__2.GetResult();
				_u__ = AppShell.RunAsync(accountPage.LoadEmailStateAsync).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__2 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _BindEmailButton_Click_d__14>(ref _u__, ref this);
					return;
				}
				goto IL_00de;
				IL_00de:
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
	private struct _CancelSubscriptionButton_Click_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

		public object sender;

		private __c__DisplayClass25_0_1 __8__1;

		private TaskAwaiter<bool> __u__1;

		private TaskAwaiter __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				TaskAwaiter<bool> _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter<bool>);
					num = (__1__state = -1);
					goto IL_00f1;
				}
				TaskAwaiter _u__2 = default;
				if (num == 1)
				{
					_u__2 = __u__2;
					__u__2 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_016c;
				}
				__8__1 = (__c__DisplayClass25_0_1)new __c__DisplayClass25_0_1();
				__8__1.__4__this = __4__this;
				object obj = sender;
				Button val = (Button)((obj is Button) ? obj : null);
				if (val != null)
				{
					object dataContext = ((FrameworkElement)val).DataContext;
					__8__1.item = (PqFZUVfO1JCpVlryjUX8)((dataContext is PqFZUVfO1JCpVlryjUX8) ? dataContext : null);
					if (__8__1.item != null)
					{
						_u__ = AppShell.ConfirmAsync("取消到货提醒", "确定不再接收「" + __8__1.item.DisplayName + "」的到货邮件提醒？", "取消订阅").GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _CancelSubscriptionButton_Click_d__25>(ref _u__, ref this);
							return;
						}
						goto IL_00f1;
					}
				}
				goto end_IL_000a;
				IL_00f1:
				if (_u__.GetResult())
				{
					_u__2 = AppShell.RunAsync(__8__1._CancelSubscriptionButton_Click_b__0).GetAwaiter();
					if (!_u__2.IsCompleted)
					{
						num = (__1__state = 1);
						__u__2 = _u__2;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _CancelSubscriptionButton_Click_d__25>(ref _u__2, ref this);
						return;
					}
					goto IL_016c;
				}
				goto end_IL_000a;
				IL_016c:
				_u__2.GetResult();
				end_IL_000a:;
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
	private struct _LoadAllAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

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
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				switch (num)
				{
				default:
					_u__ = accountPage.LoadEmailStateAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAllAsync_d__11>(ref _u__, ref this);
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
					_u__ = accountPage.LoadSubscriptionsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 2);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAllAsync_d__11>(ref _u__, ref this);
						return;
					}
					break;
					IL_007a:
					_u__.GetResult();
					_u__ = accountPage.LoadNotifyPrefsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 1);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoadAllAsync_d__11>(ref _u__, ref this);
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
	private struct _LoadEmailStateAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter<tR6PgnfOrMtDaK70FTsD> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_008b: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<tR6PgnfOrMtDaK70FTsD> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.Vh0cHLpAgq().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<tR6PgnfOrMtDaK70FTsD>, _LoadEmailStateAsync_d__12>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<tR6PgnfOrMtDaK70FTsD>);
						num = (__1__state = -1);
					}
					tR6PgnfOrMtDaK70FTsD result = _u__.GetResult();
					accountPage._emailState = result;
				}
				catch (Fx92Odf5YJhjb4F5o23y val)
				{
					Fx92Odf5YJhjb4F5o23y val2 = val;
					cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "LoadEmailStateAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 89);
					accountPage._emailState = null;
					AppShell.Error("邮箱状态加载失败：" + ((global::System.Exception)(object)val2).Message);
				}
				catch (global::System.Exception exception)
				{
					accountPage._emailState = null;
					AppShell.Error("邮箱状态加载失败：" + AppShell.GetExceptionDisplayMessage(exception, "LoadEmailStateAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 96));
				}
				accountPage.ApplyEmailState();
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
	private struct _LoadNotifyPrefsAsync_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter<yrfLThfOMGsy4PnH7t7H> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009c: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<yrfLThfOMGsy4PnH7t7H> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.ToFceStBHL().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<yrfLThfOMGsy4PnH7t7H>, _LoadNotifyPrefsAsync_d__19>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<yrfLThfOMGsy4PnH7t7H>);
						num = (__1__state = -1);
					}
					yrfLThfOMGsy4PnH7t7H result = _u__.GetResult();
					accountPage._prefs = (dX1haifOsUV0umcwoCha)(((object)result.Prefs) ?? ((object)new dX1haifOsUV0umcwoCha()));
				}
				catch (Fx92Odf5YJhjb4F5o23y val)
				{
					Fx92Odf5YJhjb4F5o23y val2 = val;
					cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "LoadNotifyPrefsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 652);
					AppShell.Error("通知偏好加载失败：" + ((global::System.Exception)(object)val2).Message);
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error("通知偏好加载失败：" + AppShell.GetExceptionDisplayMessage(exception, "LoadNotifyPrefsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 657));
				}
				accountPage.ApplyPrefsToToggles();
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
	private struct _LoadSubscriptionsAsync_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter<sxb90VfOvfxZ3y2XxwdE> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c7: Expected O, but got Unknown
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_005f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				try
				{
					TaskAwaiter<sxb90VfOvfxZ3y2XxwdE> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.D3Ecx4XJpH().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<sxb90VfOvfxZ3y2XxwdE>, _LoadSubscriptionsAsync_d__24>(ref _u__, ref this);
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
					UiHelpers.Replace(accountPage._subscriptions, (global::System.Collections.Generic.IEnumerable<PqFZUVfO1JCpVlryjUX8>)result.Items);
					ShellView.ApplyStockSubscriptionStates(Enumerable.Select<PqFZUVfO1JCpVlryjUX8, long>((global::System.Collections.Generic.IEnumerable<PqFZUVfO1JCpVlryjUX8>)result.Items, (Func<PqFZUVfO1JCpVlryjUX8, long>)__c_19.__9._LoadSubscriptionsAsync_b__24_0));
				}
				catch (Fx92Odf5YJhjb4F5o23y val)
				{
					Fx92Odf5YJhjb4F5o23y val2 = val;
					cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "LoadSubscriptionsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 736);
					AppShell.Error("到货订阅加载失败：" + ((global::System.Exception)(object)val2).Message);
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error("到货订阅加载失败：" + AppShell.GetExceptionDisplayMessage(exception, "LoadSubscriptionsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 741));
				}
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
	private struct _NotifyPrefToggle_Toggled_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_007e;
				}
				if (!accountPage._applyingPrefs)
				{
					_u__ = accountPage.SaveNotifyPrefsAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _NotifyPrefToggle_Toggled_d__22>(ref _u__, ref this);
						return;
					}
					goto IL_007e;
				}
				goto end_IL_0011;
				IL_007e:
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
	private struct _OnNavigatedTo_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

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
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					accountPage.__n__0(e);
					_u__ = AppShell.RunAsync(accountPage.LoadAllAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnNavigatedTo_d__5>(ref _u__, ref this);
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
	private struct _RebindEmailButton_Click_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_009c;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0105;
				}
				tR6PgnfOrMtDaK70FTsD emailState = accountPage._emailState;
				if (emailState != null && emailState.AllowRebind)
				{
					_u__ = accountPage.ShowRebindDialogAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RebindEmailButton_Click_d__15>(ref _u__, ref this);
						return;
					}
					goto IL_009c;
				}
				AppShell.Warning("管理员已关闭邮箱换绑");
				goto end_IL_0011;
				IL_0105:
				_u__.GetResult();
				goto end_IL_0011;
				IL_009c:
				_u__.GetResult();
				_u__ = AppShell.RunAsync(accountPage.LoadEmailStateAsync).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RebindEmailButton_Click_d__15>(ref _u__, ref this);
					return;
				}
				goto IL_0105;
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
	private struct _RefreshButton_Click_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

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
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = AppShell.RunAsync(accountPage.LoadAllAsync).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__9>(ref _u__, ref this);
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
	private struct _SaveNotifyPrefsAsync_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private dX1haifOsUV0umcwoCha _desired_5__2;

		private TaskAwaiter<yrfLThfOMGsy4PnH7t7H> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00c3: Expected O, but got Unknown
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				if (num != 0)
				{
					_desired_5__2 = accountPage.ReadPrefsFromToggles();
				}
				try
				{
					TaskAwaiter<yrfLThfOMGsy4PnH7t7H> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.IgqcPbpMwi(_desired_5__2).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<yrfLThfOMGsy4PnH7t7H>, _SaveNotifyPrefsAsync_d__23>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<yrfLThfOMGsy4PnH7t7H>);
						num = (__1__state = -1);
					}
					yrfLThfOMGsy4PnH7t7H result = _u__.GetResult();
					accountPage._prefs = result.Prefs ?? _desired_5__2;
					accountPage.ApplyPrefsToToggles();
					AppShell.Success("通知偏好已保存");
				}
				catch (Fx92Odf5YJhjb4F5o23y val)
				{
					Fx92Odf5YJhjb4F5o23y val2 = val;
					cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "SaveNotifyPrefsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 713);
					AppShell.Error("通知偏好保存失败：" + ((global::System.Exception)(object)val2).Message);
					accountPage.ApplyPrefsToToggles();
				}
				catch (global::System.Exception exception)
				{
					AppShell.Error("通知偏好保存失败：" + AppShell.GetExceptionDisplayMessage(exception, "SaveNotifyPrefsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 719));
					accountPage.ApplyPrefsToToggles();
				}
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_desired_5__2 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_desired_5__2 = null;
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
	private struct _ShowRebindDialogAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private __c__DisplayClass17_0_3 __8__1;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_040f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Expected O, but got Unknown
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Expected O, but got Unknown
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Expected O, but got Unknown
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f4: Expected O, but got Unknown
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0216: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Expected O, but got Unknown
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Expected O, but got Unknown
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d0: Expected O, but got Unknown
			//IL_0311: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_037e: Expected O, but got Unknown
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_03c1;
				}
				__8__1 = (__c__DisplayClass17_0_3)new __c__DisplayClass17_0_3();
				XamlRoot xamlRoot = ((UIElement)accountPage).XamlRoot;
				if (xamlRoot != null)
				{
					__c__DisplayClass17_0_3 _c__DisplayClass17_0_ = __8__1;
					tR6PgnfOrMtDaK70FTsD? emailState = accountPage._emailState;
					_c__DisplayClass17_0_.isLink = nkelP9fOQIfs4dM8xou1.i2tfO4KYbqq((emailState != null) ? emailState.VerifyMethod : null);
					__c__DisplayClass17_0_3 _c__DisplayClass17_0_2 = __8__1;
					tR6PgnfOrMtDaK70FTsD? emailState2 = accountPage._emailState;
					_c__DisplayClass17_0_2.previousEmail = ((emailState2 != null) ? emailState2.DisplayEmail : null) ?? string.Empty;
					DispatcherQueue forCurrentThread = DispatcherQueue.GetForCurrentThread();
					__8__1.stage = RebindStage.Request;
					__8__1.remainingSeconds = 0;
					__8__1.completed = false;
					StackPanel val = new StackPanel
					{
						Spacing = 14.0,
						MaxWidth = 460.0
					};
					__8__1.instructionText = new TextBlock
					{
						Text = "当前邮箱：" + __8__1.previousEmail + "。输入新邮箱后点「下一步」开始换绑。",
						TextWrapping = (TextWrapping)2,
						Style = null
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.instructionText);
					__8__1.messageBar = new InfoBar
					{
						IsOpen = false,
						IsClosable = false,
						Severity = (InfoBarSeverity)0
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.messageBar);
					__8__1.newEmailBox = new TextBox
					{
						Header = "新邮箱地址",
						PlaceholderText = "you@example.com",
						MaxLength = 190
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.newEmailBox);
					__8__1.resendButton = new Button
					{
						Content = "重新发送",
						HorizontalAlignment = (HorizontalAlignment)3,
						Visibility = (Visibility)1
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.resendButton);
					__8__1.codeBox = new TextBox
					{
						Header = "验证码",
						PlaceholderText = "邮件里的 6 位验证码",
						MaxLength = 8,
						Visibility = (Visibility)1
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.codeBox);
					__8__1.dialog = new ContentDialog
					{
						XamlRoot = xamlRoot,
						RequestedTheme = AppearanceSettings.Theme,
						Title = "更换邮箱",
						Content = (object)new ScrollViewer
						{
							Content = val,
							MaxHeight = 520.0,
							VerticalScrollBarVisibility = (ScrollBarVisibility)1,
							HorizontalScrollBarVisibility = (ScrollBarVisibility)0
						},
						PrimaryButtonText = "下一步",
						CloseButtonText = "取消",
						DefaultButton = (ContentDialogButton)1
					};
					__8__1.resendTimer = ((forCurrentThread != null) ? forCurrentThread.CreateTimer() : null);
					if (__8__1.resendTimer != null)
					{
						__8__1.resendTimer.Interval = TimeSpan.FromSeconds(1.0);
						__8__1.resendTimer.IsRepeating = true;
					}
					if (__8__1.resendTimer != null)
					{
						__8__1.resendTimer.Tick += __8__1._ShowRebindDialogAsync_b__3;
					}
					((ButtonBase)__8__1.resendButton).Click += new RoutedEventHandler(__8__1._ShowRebindDialogAsync_b__6);
					__8__1.dialog.PrimaryButtonClick += __8__1._ShowRebindDialogAsync_b__7;
					__8__1.dialog.Closing += __8__1._ShowRebindDialogAsync_b__8;
					goto IL_03c1;
				}
				goto end_IL_0011;
				IL_03c1:
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(__8__1.dialog.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowRebindDialogAsync_d__17>(ref _u__, ref this);
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
					AppShell.Error("换绑弹窗打开失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowRebindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 509));
				}
				finally
				{
					if (num < 0)
					{
						DispatcherQueueTimer obj = __8__1.resendTimer;
						if (obj != null)
						{
							obj.Stop();
						}
					}
				}
				if (__8__1.completed)
				{
					AppShell.Success("邮箱已更换并验证");
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception2);
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
	private struct _ShowUnbindDialogAsync_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AccountPage __4__this;

		private __c__DisplayClass18_0_7 __8__1;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Expected O, but got Unknown
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected O, but got Unknown
			//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected O, but got Unknown
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Expected O, but got Unknown
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_017d;
				}
				__8__1 = (__c__DisplayClass18_0_7)new __c__DisplayClass18_0_7();
				XamlRoot xamlRoot = ((UIElement)accountPage).XamlRoot;
				ContentDialog val2 = default(ContentDialog);
				if (xamlRoot != null)
				{
					__8__1.unbound = false;
					StackPanel val = new StackPanel
					{
						Spacing = 12.0,
						MaxWidth = 420.0
					};
					((Panel)val).Children.Add((UIElement)new TextBlock
					{
						Text = "解绑后将无法通过邮箱找回密码，也不会再收到账单与到货提醒。请输入账号密码确认。",
						TextWrapping = (TextWrapping)2,
						Style = null
					});
					__8__1.messageBar = new InfoBar
					{
						IsOpen = false,
						IsClosable = false,
						Severity = (InfoBarSeverity)0
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.messageBar);
					__8__1.passwordBox = new PasswordBox
					{
						Header = "账号密码",
						MaxLength = 128
					};
					((Panel)val).Children.Add((UIElement)(object)__8__1.passwordBox);
					val2 = new ContentDialog
					{
						XamlRoot = xamlRoot,
						RequestedTheme = AppearanceSettings.Theme,
						Title = "解绑邮箱",
						Content = val,
						PrimaryButtonText = "确认解绑",
						CloseButtonText = "取消",
						DefaultButton = (ContentDialogButton)3
					};
					val2.PrimaryButtonClick += __8__1._ShowUnbindDialogAsync_b__0;
					goto IL_017d;
				}
				goto end_IL_0011;
				IL_017d:
					val2 = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(val2.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowUnbindDialogAsync_d__18>(ref _u__, ref this);
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
					AppShell.Error("解绑弹窗打开失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowUnbindDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\AccountPage.xaml.cs", 631));
					goto end_IL_0011;
				}
				if (__8__1.unbound)
				{
					AppShell.Success("邮箱已解绑");
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				__8__1 = null;
				__t__builder.SetException(exception2);
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
	private struct _UnbindEmailButton_Click_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AccountPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AccountPage accountPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_009c;
				}
				if (num == 1)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0105;
				}
				tR6PgnfOrMtDaK70FTsD emailState = accountPage._emailState;
				if (emailState != null && emailState.AllowUnbind)
				{
					_u__ = accountPage.ShowUnbindDialogAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _UnbindEmailButton_Click_d__16>(ref _u__, ref this);
						return;
					}
					goto IL_009c;
				}
				AppShell.Warning("管理员已关闭邮箱解绑");
				goto end_IL_0011;
				IL_0105:
				_u__.GetResult();
				goto end_IL_0011;
				IL_009c:
				_u__.GetResult();
				_u__ = AppShell.RunAsync(accountPage.LoadEmailStateAsync).GetAwaiter();
				if (!_u__.IsCompleted)
				{
					num = (__1__state = 1);
					__u__1 = _u__;
					__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _UnbindEmailButton_Click_d__16>(ref _u__, ref this);
					return;
				}
				goto IL_0105;
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

	private readonly ObservableCollection<PqFZUVfO1JCpVlryjUX8> _subscriptions;

	private tR6PgnfOrMtDaK70FTsD? _emailState;

	private dX1haifOsUV0umcwoCha _prefs;

	private bool _applyingPrefs;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar EmailNoticeBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SettingsCard EmailStatusCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private SettingsCard EmailBoundAtCard;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ListView SubscriptionList;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel SubscriptionEmptyState;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefStockAvailableToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefStatementWeeklyToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefStatementMonthlyToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefBillConsumeToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefBillCardRedeemToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ToggleSwitch PrefBillRechargeToggle;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock EmailBoundAtText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button BindEmailButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RebindEmailButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button UnbindEmailButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private IAccountPage_Bindings Bindings;

	[MethodImpl((MethodImplOptions)8)]
	public AccountPage()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		_subscriptions = new ObservableCollection<PqFZUVfO1JCpVlryjUX8>();
		_prefs = new dX1haifOsUV0umcwoCha();
		InitializeComponent();
		((ItemsControl)SubscriptionList).ItemsSource = _subscriptions;
		_subscriptions.CollectionChanged += new NotifyCollectionChangedEventHandler(OnSubscriptionsChanged);
		AppShell.SessionCleared += new EventHandler(OnSessionCleared);
		((FrameworkElement)this).Unloaded += (RoutedEventHandler)([MethodImpl((MethodImplOptions)8)] [CompilerGenerated] (object _, RoutedEventArgs _) =>
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got Unknown
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			_subscriptions.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnSubscriptionsChanged);
			AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		});
		ApplyEmailState();
		UpdateSubscriptionEmptyState();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	protected override void OnNavigatedTo(NavigationEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnNavigatedTo_d__5 onNavigatedTo_d__ = default(_OnNavigatedTo_d__5);
		onNavigatedTo_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		onNavigatedTo_d__.__4__this = this;
		onNavigatedTo_d__.e = e;
		onNavigatedTo_d__.__1__state = -1;
		onNavigatedTo_d__.__t__builder.Start<_OnNavigatedTo_d__5>(ref onNavigatedTo_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		_emailState = null;
		_prefs = new dX1haifOsUV0umcwoCha();
		((Collection<PqFZUVfO1JCpVlryjUX8>)(object)_subscriptions).Clear();
		ApplyEmailState();
		ApplyPrefsToToggles();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSubscriptionsChanged(object? sender, NotifyCollectionChangedEventArgs e)
	{
		UpdateSubscriptionEmptyState();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UpdateSubscriptionEmptyState()
	{
		((UIElement)SubscriptionEmptyState).Visibility = (((((Collection<PqFZUVfO1JCpVlryjUX8>)(object)_subscriptions).Count != 0) ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__9 refreshButton_Click_d__ = default(_RefreshButton_Click_d__9);
		refreshButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__.__4__this = this;
		refreshButton_Click_d__.__1__state = -1;
		refreshButton_Click_d__.__t__builder.Start<_RefreshButton_Click_d__9>(ref refreshButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Threading.Tasks.Task RefreshForShellAsync()
	{
		return LoadAllAsync();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadAllAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadAllAsync_d__11 loadAllAsync_d__ = default(_LoadAllAsync_d__11);
		loadAllAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadAllAsync_d__.__4__this = this;
		loadAllAsync_d__.__1__state = -1;
		loadAllAsync_d__.__t__builder.Start<_LoadAllAsync_d__11>(ref loadAllAsync_d__);
		return loadAllAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadEmailStateAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadEmailStateAsync_d__12 loadEmailStateAsync_d__ = default(_LoadEmailStateAsync_d__12);
		loadEmailStateAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadEmailStateAsync_d__.__4__this = this;
		loadEmailStateAsync_d__.__1__state = -1;
		loadEmailStateAsync_d__.__t__builder.Start<_LoadEmailStateAsync_d__12>(ref loadEmailStateAsync_d__);
		return loadEmailStateAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyEmailState()
	{
		tR6PgnfOrMtDaK70FTsD emailState = _emailState;
		if (emailState == null)
		{
			EmailStatusCard.Description = "邮箱状态未知，请点右上角「刷新」重试";
			EmailBoundAtText.Text = "-";
			((ContentControl)BindEmailButton).Content = "绑定邮箱";
			((UIElement)BindEmailButton).Visibility = (Visibility)0;
			((UIElement)RebindEmailButton).Visibility = (Visibility)1;
			((UIElement)UnbindEmailButton).Visibility = (Visibility)1;
			NotificationAutoDismiss.Hide(EmailNoticeBar);
			return;
		}
		EmailStatusCard.Description = emailState.DisplayEmail + " · " + emailState.StatusText;
		EmailBoundAtText.Text = emailState.BoundAtText;
		bool flag = emailState.HasEmail && emailState.EmailVerified;
		((UIElement)BindEmailButton).Visibility = ((flag ? 1 : 0) != 0 ? Visibility.Visible : Visibility.Collapsed);
		((ContentControl)BindEmailButton).Content = (emailState.HasEmail ? "继续验证" : "绑定邮箱");
		((UIElement)RebindEmailButton).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((Control)RebindEmailButton).IsEnabled = emailState.AllowRebind;
		ToolTipService.SetToolTip((DependencyObject)(object)RebindEmailButton, (object)((!emailState.AllowRebind) ? "管理员已关闭邮箱换绑" : ((emailState.RebindCooldownDays > 0) ? $"换绑后 {emailState.RebindCooldownDays} 天内不能再次更换" : "更换绑定的邮箱")));
		((UIElement)UnbindEmailButton).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		((Control)UnbindEmailButton).IsEnabled = emailState.AllowUnbind;
		ToolTipService.SetToolTip((DependencyObject)(object)UnbindEmailButton, (object)(emailState.AllowUnbind ? "解绑需要验证账号密码" : "管理员已关闭邮箱解绑"));
		if (!emailState.HasEmail)
		{
			EmailNoticeBar.Severity = (InfoBarSeverity)2;
			EmailNoticeBar.Message = "还没有绑定邮箱，绑定后才能找回密码、接收账单与到货提醒。";
			NotificationAutoDismiss.Show(EmailNoticeBar);
		}
		else if (!emailState.EmailVerified)
		{
			EmailNoticeBar.Severity = (InfoBarSeverity)2;
			EmailNoticeBar.Message = "邮箱尚未完成验证，请点「继续验证」重新获取验证码。";
			NotificationAutoDismiss.Show(EmailNoticeBar);
		}
		else
		{
			NotificationAutoDismiss.Hide(EmailNoticeBar);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void BindEmailButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_BindEmailButton_Click_d__14 bindEmailButton_Click_d__ = default(_BindEmailButton_Click_d__14);
		bindEmailButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		bindEmailButton_Click_d__.__4__this = this;
		bindEmailButton_Click_d__.__1__state = -1;
		bindEmailButton_Click_d__.__t__builder.Start<_BindEmailButton_Click_d__14>(ref bindEmailButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RebindEmailButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RebindEmailButton_Click_d__15 rebindEmailButton_Click_d__ = default(_RebindEmailButton_Click_d__15);
		rebindEmailButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		rebindEmailButton_Click_d__.__4__this = this;
		rebindEmailButton_Click_d__.__1__state = -1;
		rebindEmailButton_Click_d__.__t__builder.Start<_RebindEmailButton_Click_d__15>(ref rebindEmailButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void UnbindEmailButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_UnbindEmailButton_Click_d__16 unbindEmailButton_Click_d__ = default(_UnbindEmailButton_Click_d__16);
		unbindEmailButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		unbindEmailButton_Click_d__.__4__this = this;
		unbindEmailButton_Click_d__.__1__state = -1;
		unbindEmailButton_Click_d__.__t__builder.Start<_UnbindEmailButton_Click_d__16>(ref unbindEmailButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowRebindDialogAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowRebindDialogAsync_d__17 showRebindDialogAsync_d__ = default(_ShowRebindDialogAsync_d__17);
		showRebindDialogAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showRebindDialogAsync_d__.__4__this = this;
		showRebindDialogAsync_d__.__1__state = -1;
		showRebindDialogAsync_d__.__t__builder.Start<_ShowRebindDialogAsync_d__17>(ref showRebindDialogAsync_d__);
		return showRebindDialogAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowUnbindDialogAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowUnbindDialogAsync_d__18 showUnbindDialogAsync_d__ = default(_ShowUnbindDialogAsync_d__18);
		showUnbindDialogAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showUnbindDialogAsync_d__.__4__this = this;
		showUnbindDialogAsync_d__.__1__state = -1;
		showUnbindDialogAsync_d__.__t__builder.Start<_ShowUnbindDialogAsync_d__18>(ref showUnbindDialogAsync_d__);
		return showUnbindDialogAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadNotifyPrefsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadNotifyPrefsAsync_d__19 loadNotifyPrefsAsync_d__ = default(_LoadNotifyPrefsAsync_d__19);
		loadNotifyPrefsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadNotifyPrefsAsync_d__.__4__this = this;
		loadNotifyPrefsAsync_d__.__1__state = -1;
		loadNotifyPrefsAsync_d__.__t__builder.Start<_LoadNotifyPrefsAsync_d__19>(ref loadNotifyPrefsAsync_d__);
		return loadNotifyPrefsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyPrefsToToggles()
	{
		_applyingPrefs = true;
		try
		{
			PrefBillRechargeToggle.IsOn = _prefs.BillRecharge;
			PrefBillCardRedeemToggle.IsOn = _prefs.BillCardRedeem;
			PrefBillConsumeToggle.IsOn = _prefs.BillConsume;
			PrefStatementMonthlyToggle.IsOn = _prefs.StatementMonthly;
			PrefStatementWeeklyToggle.IsOn = _prefs.StatementWeekly;
			PrefStockAvailableToggle.IsOn = _prefs.StockAvailable;
		}
		finally
		{
			_applyingPrefs = false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private dX1haifOsUV0umcwoCha ReadPrefsFromToggles()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		return new dX1haifOsUV0umcwoCha
		{
			BillRecharge = PrefBillRechargeToggle.IsOn,
			BillCardRedeem = PrefBillCardRedeemToggle.IsOn,
			BillConsume = PrefBillConsumeToggle.IsOn,
			StatementMonthly = PrefStatementMonthlyToggle.IsOn,
			StatementWeekly = PrefStatementWeeklyToggle.IsOn,
			StockAvailable = PrefStockAvailableToggle.IsOn
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void NotifyPrefToggle_Toggled(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_NotifyPrefToggle_Toggled_d__22 notifyPrefToggle_Toggled_d__ = default(_NotifyPrefToggle_Toggled_d__22);
		notifyPrefToggle_Toggled_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		notifyPrefToggle_Toggled_d__.__4__this = this;
		notifyPrefToggle_Toggled_d__.__1__state = -1;
		notifyPrefToggle_Toggled_d__.__t__builder.Start<_NotifyPrefToggle_Toggled_d__22>(ref notifyPrefToggle_Toggled_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SaveNotifyPrefsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SaveNotifyPrefsAsync_d__23 saveNotifyPrefsAsync_d__ = default(_SaveNotifyPrefsAsync_d__23);
		saveNotifyPrefsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		saveNotifyPrefsAsync_d__.__4__this = this;
		saveNotifyPrefsAsync_d__.__1__state = -1;
		saveNotifyPrefsAsync_d__.__t__builder.Start<_SaveNotifyPrefsAsync_d__23>(ref saveNotifyPrefsAsync_d__);
		return saveNotifyPrefsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadSubscriptionsAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadSubscriptionsAsync_d__24 loadSubscriptionsAsync_d__ = default(_LoadSubscriptionsAsync_d__24);
		loadSubscriptionsAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadSubscriptionsAsync_d__.__4__this = this;
		loadSubscriptionsAsync_d__.__1__state = -1;
		loadSubscriptionsAsync_d__.__t__builder.Start<_LoadSubscriptionsAsync_d__24>(ref loadSubscriptionsAsync_d__);
		return loadSubscriptionsAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void CancelSubscriptionButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_CancelSubscriptionButton_Click_d__25 cancelSubscriptionButton_Click_d__ = default(_CancelSubscriptionButton_Click_d__25);
		cancelSubscriptionButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		cancelSubscriptionButton_Click_d__.__4__this = this;
		cancelSubscriptionButton_Click_d__.sender = sender;
		cancelSubscriptionButton_Click_d__.__1__state = -1;
		cancelSubscriptionButton_Click_d__.__t__builder.Start<_CancelSubscriptionButton_Click_d__25>(ref cancelSubscriptionButton_Click_d__);
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
			Uri val = new Uri("ms-appx:///Views/Pages/AccountPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	[DebuggerNonUserCode]
	public void Connect(int connectionId, object target)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_024d: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			EmailNoticeBar = CastExtensions.As<InfoBar>(target);
			break;
		case 3:
			EmailStatusCard = CastExtensions.As<SettingsCard>(target);
			break;
		case 4:
			EmailBoundAtCard = CastExtensions.As<SettingsCard>(target);
			break;
		case 5:
			SubscriptionList = CastExtensions.As<ListView>(target);
			break;
		case 6:
			SubscriptionEmptyState = CastExtensions.As<StackPanel>(target);
			break;
		case 10:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(CancelSubscriptionButton_Click);
			break;
		case 13:
			PrefStockAvailableToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefStockAvailableToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 14:
			PrefStatementWeeklyToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefStatementWeeklyToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 15:
			PrefStatementMonthlyToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefStatementMonthlyToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 16:
			PrefBillConsumeToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefBillConsumeToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 17:
			PrefBillCardRedeemToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefBillCardRedeemToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 18:
			PrefBillRechargeToggle = CastExtensions.As<ToggleSwitch>(target);
			PrefBillRechargeToggle.Toggled += new RoutedEventHandler(NotifyPrefToggle_Toggled);
			break;
		case 19:
			EmailBoundAtText = CastExtensions.As<TextBlock>(target);
			break;
		case 20:
			BindEmailButton = CastExtensions.As<Button>(target);
			((ButtonBase)BindEmailButton).Click += new RoutedEventHandler(BindEmailButton_Click);
			break;
		case 21:
			RebindEmailButton = CastExtensions.As<Button>(target);
			((ButtonBase)RebindEmailButton).Click += new RoutedEventHandler(RebindEmailButton_Click);
			break;
		case 22:
			UnbindEmailButton = CastExtensions.As<Button>(target);
			((ButtonBase)UnbindEmailButton).Click += new RoutedEventHandler(UnbindEmailButton_Click);
			break;
		case 23:
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
		if (connectionId == 8)
		{
			Grid val = (Grid)target;
			AccountPage_obj8_Bindings accountPage_obj8_Bindings = (AccountPage_obj8_Bindings)new AccountPage_obj8_Bindings();
			result = (IComponentConnector)(object)accountPage_obj8_Bindings;
			accountPage_obj8_Bindings.SetDataRoot(((FrameworkElement)val).DataContext);
			((FrameworkElement)val).DataContextChanged += accountPage_obj8_Bindings.DataContextChangedHandler;
			DataTemplate.SetExtensionInstance((FrameworkElement)(object)val, (IDataTemplateExtension)(object)accountPage_obj8_Bindings);
			XamlBindingHelper.SetDataTemplateComponent((DependencyObject)(object)val, (IDataTemplateComponent)(object)accountPage_obj8_Bindings);
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void __ctor_b__4_0(object _, RoutedEventArgs _2)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		_subscriptions.CollectionChanged -= new NotifyCollectionChangedEventHandler(OnSubscriptionsChanged);
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
	private static void _cctor()
	{
	}
}

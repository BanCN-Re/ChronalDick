using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using HHPaYafHu83VxCggKTsx;
using JvgQTDcbARdEdTAk7GE;
using KBEilrA0WroT9wKME3f;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Animation;
using WinRT;
using WinRT.ChronalVtableClasses;
using YVeMU8SufMQCyNFfnY2;
using bUfedyCg1PBqhqIkB8r;
using fJI2ftf5SouLKttbv85L;
using fNKXZaCVx11wUEBS5ms;
using o5bDswf5LGXabEVwneya;
using qS8vkpL43FlTMgcj0rgs;
using sBBxrOfOz52kggictN4I;
using w5IkpKfHMXXm0FOu8Q1G;

namespace Mahiro_Account.UI.Shell;

[WinRTExposedType(typeof(Mahiro_Account_UI_Controls_Bedrock_BedrockAccountHistoryViewWinRTTypeDetails))]
[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
public sealed class AuthView : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private static class __O_8
	{
		public static Func<char, bool> _0___IsLetter;

		public static Func<char, bool> _1___IsDigit;

		public static Func<char, bool> _2___IsWhiteSpace;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass33_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __ShowPasswordResetDialogAsync_b__2_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass33_0_1 __4__this;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private TaskAwaiter<Be4ToIf5fbU5iWdyJB42> __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_01b6: Expected O, but got Unknown
				//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass33_0_1 _c__DisplayClass33_0_ = __4__this;
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
						TaskAwaiter<Be4ToIf5fbU5iWdyJB42> _u__ = default;
						if (num == 0)
						{
							_u__ = __u__1;
							__u__1 = default(TaskAwaiter<Be4ToIf5fbU5iWdyJB42>);
							num = (__1__state = -1);
							goto IL_00d8;
						}
						string text = _c__DisplayClass33_0_.emailBox.Text.Trim();
						if (!ShellView.IsValidEmail(text))
						{
							_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, "请输入有效的邮箱地址");
						}
						else if (!_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__WarnAboutTypo_1(text))
						{
							_u__ = AppShell.Api.MwAcN7ue2x(text).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Be4ToIf5fbU5iWdyJB42>, __ShowPasswordResetDialogAsync_b__2_d>(ref _u__, ref this);
								return;
							}
							goto IL_00d8;
						}
						goto end_IL_0035;
						IL_00d8:
						Be4ToIf5fbU5iWdyJB42 result = _u__.GetResult();
						_c__DisplayClass33_0_.dialog.IsPrimaryButtonEnabled = false;
						_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__ShowMessage_0((InfoBarSeverity)1, string.IsNullOrWhiteSpace(result.Message) ? "若该邮箱已绑定账号，重置邮件已发送，请在浏览器中打开邮件里的链接完成重置。" : result.Message.Trim());
						end_IL_0035:;
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
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val, "ui-exception", "ShowPasswordResetDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 565);
						int num2 = ((val.RetryAfterSeconds > 0) ? val.RetryAfterSeconds : 60);
						_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__ShowMessage_0((InfoBarSeverity)2, $"请求过于频繁，请 {num2} 秒后再试");
					}
					catch (Fx92Odf5YJhjb4F5o23y val2)
					{
						Fx92Odf5YJhjb4F5o23y val3 = val2;
						cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val3, "ui-exception", "ShowPasswordResetDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 571);
						_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, ((global::System.Exception)(object)val3).Message);
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass33_0_._ShowPasswordResetDialogAsync_g__ShowMessage_0((InfoBarSeverity)3, AppShell.GetExceptionDisplayMessage(exception, "ShowPasswordResetDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 576));
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

		public InfoBar messageBar;

		public string typoConfirmedFor;

		public TextBox emailBox;

		public ContentDialog dialog;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass33_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowPasswordResetDialogAsync_g__ShowMessage_0(InfoBarSeverity severity, string message)
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			messageBar.ActionButton = null;
			messageBar.Severity = severity;
			messageBar.Message = message;
			NotificationAutoDismiss.Show(messageBar);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ShowPasswordResetDialogAsync_g__WarnAboutTypo_1(string email)
		{
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Expected O, but got Unknown
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Expected O, but got Unknown
			__c__DisplayClass33_1_1 _c__DisplayClass33_1_ = (__c__DisplayClass33_1_1)new __c__DisplayClass33_1_1
			{
				CS___8__locals1 = this,
				suggestion = F0NMLsCkIKFUF5TJCVr.AYWCYaQrtD(email)
			};
			if (_c__DisplayClass33_1_.suggestion == null || string.Equals(typoConfirmedFor, email, (StringComparison)5))
			{
				return false;
			}
			typoConfirmedFor = email;
			Button val = new Button
			{
				Content = "改为 " + _c__DisplayClass33_1_.suggestion
			};
			((ButtonBase)val).Click += new RoutedEventHandler(_c__DisplayClass33_1_._ShowPasswordResetDialogAsync_b__3);
			messageBar.Severity = (InfoBarSeverity)2;
			messageBar.Message = "是不是想输 " + _c__DisplayClass33_1_.suggestion + "？确认没错的话再点一次「发送重置邮件」。";
			messageBar.ActionButton = (ButtonBase)(object)val;
			NotificationAutoDismiss.Show(messageBar);
			return true;
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowPasswordResetDialogAsync_b__2(ContentDialog _, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowPasswordResetDialogAsync_b__2_d _ShowPasswordResetDialogAsync_b__2_d = default(__ShowPasswordResetDialogAsync_b__2_d);
			_ShowPasswordResetDialogAsync_b__2_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowPasswordResetDialogAsync_b__2_d.__4__this = this;
			_ShowPasswordResetDialogAsync_b__2_d.args = args;
			_ShowPasswordResetDialogAsync_b__2_d.__1__state = -1;
			_ShowPasswordResetDialogAsync_b__2_d.__t__builder.Start<__ShowPasswordResetDialogAsync_b__2_d>(ref _ShowPasswordResetDialogAsync_b__2_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass33_1_1
	{
		public string suggestion;

		public __c__DisplayClass33_0_1 CS___8__locals1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass33_1_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowPasswordResetDialogAsync_b__3(object _, RoutedEventArgs _2)
		{
			CS___8__locals1.emailBox.Text = suggestion;
			CS___8__locals1.emailBox.SelectionStart = suggestion.Length;
			CS___8__locals1.typoConfirmedFor = string.Empty;
			NotificationAutoDismiss.Hide(CS___8__locals1.messageBar);
			CS___8__locals1.messageBar.ActionButton = null;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ApiRouteSelector_SelectionChanged_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				if (num == 0 || (authView._routeSelectorReady && !authView._authenticationInProgress))
				{
					try
					{
						TaskAwaiter _u__ = default;
						if (num != 0)
						{
							bool flag = ((Selector)authView.ApiRouteSelector).SelectedItem == authView.BackupRouteItem;
							AppShell.Api.nhNcryPF8h(flag);
							NotificationAutoDismiss.Hide(authView.AuthErrorBar);
							_u__ = WarmUpAuthenticationAsync().GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ApiRouteSelector_SelectionChanged_d__15>(ref _u__, ref this);
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
						authView.SyncRouteSelector();
						authView.ShowError(AppShell.GetExceptionDisplayMessage(exception, "ApiRouteSelector_SelectionChanged", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 123));
					}
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
	private struct _AuthView_Loaded_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					try
					{
						authView.AmbientAnimation.Begin();
					}
					catch
					{
					}
					global::System.Threading.Tasks.Task task = authView.LoadRegisterPolicyAsync();
					global::System.Threading.Tasks.Task task2 = WarmUpAuthenticationAsync();
					_u__ = global::System.Threading.Tasks.Task.WhenAll(new global::System.Threading.Tasks.Task[2] { task, task2 }).GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _AuthView_Loaded_d__16>(ref _u__, ref this);
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
	private struct _ForgotPassword_Click_d__32 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

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
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = authView.ShowPasswordResetDialogAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _ForgotPassword_Click_d__32>(ref _u__, ref this);
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
	private struct _LoadRegisterPolicyAsync_d__18 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter<O9LpdbfOncQx4LguZQ0v> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_003b;
				}
				if (!authView._registerPolicyLoading)
				{
					authView._registerPolicyLoading = true;
					((Control)authView.RegisterButton).IsEnabled = false;
					goto IL_003b;
				}
				goto end_IL_0011;
				IL_003b:
				try
				{
					TaskAwaiter<O9LpdbfOncQx4LguZQ0v> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.wQ5cTCIcqU().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<O9LpdbfOncQx4LguZQ0v>, _LoadRegisterPolicyAsync_d__18>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<O9LpdbfOncQx4LguZQ0v>);
						num = (__1__state = -1);
					}
					O9LpdbfOncQx4LguZQ0v result = _u__.GetResult();
					authView._registerPolicy = result;
				}
				catch (global::System.Exception exception)
				{
					authView._registerPolicy = null;
					authView.ShowError(AppShell.GetExceptionDisplayMessage(exception, "LoadRegisterPolicyAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 173));
				}
				finally
				{
					if (num < 0)
					{
						authView._registerPolicyLoading = false;
					}
				}
				authView.ApplyRegisterPolicy();
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
	private struct _LoginButton_Click_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

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
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = authView.SignInAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _LoginButton_Click_d__22>(ref _u__, ref this);
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
	private struct _PasswordBox_KeyDown_d__24 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public KeyRoutedEventArgs e;

		public AuthView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008c;
				}
				if ((int)e.Key == 13)
				{
					e.Handled = true;
					_u__ = authView.SignInAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _PasswordBox_KeyDown_d__24>(ref _u__, ref this);
						return;
					}
					goto IL_008c;
				}
				goto end_IL_0011;
				IL_008c:
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
	private struct _RegPasswordBox_KeyDown_d__25 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public KeyRoutedEventArgs e;

		public AuthView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Invalid comparison between Unknown and I4
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_008c;
				}
				if ((int)e.Key == 13)
				{
					e.Handled = true;
					_u__ = authView.SignUpAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RegPasswordBox_KeyDown_d__25>(ref _u__, ref this);
						return;
					}
					goto IL_008c;
				}
				goto end_IL_0011;
				IL_008c:
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
	private struct _RegisterButton_Click_d__23 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

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
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = authView.SignUpAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RegisterButton_Click_d__23>(ref _u__, ref this);
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
	private struct _ShowPasswordResetDialogAsync_d__33 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter<ContentDialogResult> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Expected O, but got Unknown
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Expected O, but got Unknown
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b2: Expected O, but got Unknown
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01db: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0174;
				}
				__c__DisplayClass33_0_1 _c__DisplayClass33_0_ = (__c__DisplayClass33_0_1)new __c__DisplayClass33_0_1();
				if (((UIElement)authView).XamlRoot != null)
				{
					StackPanel val = new StackPanel
					{
						Spacing = 12.0,
						MaxWidth = 420.0
					};
					((Panel)val).Children.Add((UIElement)new TextBlock
					{
						Text = "输入账号绑定的邮箱，我们会发送一封包含重置链接的邮件。",
						TextWrapping = (TextWrapping)2,
						Style = null
					});
					_c__DisplayClass33_0_.messageBar = new InfoBar
					{
						IsOpen = false,
						IsClosable = false,
						Severity = (InfoBarSeverity)0
					};
					((Panel)val).Children.Add((UIElement)(object)_c__DisplayClass33_0_.messageBar);
					_c__DisplayClass33_0_.emailBox = new TextBox
					{
						Header = "邮箱地址",
						PlaceholderText = "you@example.com",
						MaxLength = 190
					};
					((Panel)val).Children.Add((UIElement)(object)_c__DisplayClass33_0_.emailBox);
					_c__DisplayClass33_0_.dialog = new ContentDialog
					{
						XamlRoot = ((UIElement)authView).XamlRoot,
						RequestedTheme = AppearanceSettings.Theme,
						Title = "找回密码",
						Content = val,
						PrimaryButtonText = "发送重置邮件",
						CloseButtonText = "关闭",
						DefaultButton = (ContentDialogButton)1
					};
					_c__DisplayClass33_0_.typoConfirmedFor = string.Empty;
					_c__DisplayClass33_0_.dialog.PrimaryButtonClick += _c__DisplayClass33_0_._ShowPasswordResetDialogAsync_b__2;
					goto IL_0174;
				}
				goto end_IL_0011;
				IL_0174:
					_c__DisplayClass33_0_ = default;
				try
				{
					TaskAwaiter<ContentDialogResult> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(_c__DisplayClass33_0_.dialog.ShowAsync());
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowPasswordResetDialogAsync_d__33>(ref _u__, ref this);
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
					authView.ShowError(AppShell.GetExceptionDisplayMessage(exception, "ShowPasswordResetDialogAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 590));
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
	private struct _SignInAsync_d__26 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AuthView __4__this;

		private string _username_5__2;

		private string _password_5__3;

		private TaskAwaiter<oSIpOJfHpmrg6bJOVFNH> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00ba;
				}
				NotificationAutoDismiss.Hide(authView.AuthErrorBar);
				_username_5__2 = authView.UsernameBox.Text.Trim();
				_password_5__3 = authView.PasswordBox.Password;
				int length = _username_5__2.Length;
				if ((length < 3 || length > 64) ? true : false)
				{
					authView.ShowError("用户名长度必须为 3 到 64 个字符");
				}
				else if (_password_5__3.Length == 0)
				{
					authView.ShowError("请输入密码");
				}
				else if (authView.TryBeginAuthentication())
				{
					AppShell.ShowLoading(show: true);
					goto IL_00ba;
				}
				goto end_IL_0011;
				IL_00ba:
				try
				{
					TaskAwaiter<oSIpOJfHpmrg6bJOVFNH> _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.LoginAsync(new I8JmDNfHNvD23TNHgrer
						{
							Username = _username_5__2,
							Password = _password_5__3,
							Machine = AppShell.RefreshMachine()
						}).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<oSIpOJfHpmrg6bJOVFNH>, _SignInAsync_d__26>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<oSIpOJfHpmrg6bJOVFNH>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
					authView.SaveLogin(_username_5__2, _password_5__3);
					EventHandler? obj = authView.AuthenticationSucceeded;
					if (obj != null)
					{
						obj.Invoke((object)authView, EventArgs.Empty);
					}
				}
				catch (global::System.Exception exception)
				{
					authView.ShowError(AppShell.GetExceptionDisplayMessage(exception, "SignInAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 333));
				}
				finally
				{
					if (num < 0)
					{
						AppShell.ShowLoading(show: false);
						authView.EndAuthentication();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception2)
			{
				__1__state = -2;
				_username_5__2 = null;
				_password_5__3 = null;
				__t__builder.SetException(exception2);
				return;
			}
			__1__state = -2;
			_username_5__2 = null;
			_password_5__3 = null;
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
	private struct _SignUpAsync_d__27 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter<oSIpOJfHpmrg6bJOVFNH> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Expected O, but got Unknown
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_00c7;
				}
				NotificationAutoDismiss.Hide(authView.AuthErrorBar);
				string username = authView.RegUsernameBox.Text.Trim();
				string password = authView.RegPasswordBox.Password;
				string text = authView.RegEmailBox.Text.Trim();
				string text2 = authView.RegInvitationBox.Text.Trim();
				string text3 = authView.ValidateRegisterInput(username, password, text, text2);
				if (text3 != null)
				{
					authView.ShowError(text3);
				}
				else
				{
					O9LpdbfOncQx4LguZQ0v registerPolicy = authView._registerPolicy;
					if (registerPolicy != null && !registerPolicy.AllowRegistration)
					{
						authView.ShowError("当前未开放注册");
					}
					else if (authView.TryBeginAuthentication())
					{
						AppShell.ShowLoading(show: true);
						goto IL_00c7;
					}
				}
				goto end_IL_0011;
				IL_00c7:
					text2 = default;
					text = default;
					password = default;
					username = default;
				try
				{
					TaskAwaiter<oSIpOJfHpmrg6bJOVFNH> _u__ = default;
					if (num != 0)
					{
						v5OiSQSzC8GipXkQ3VG api = AppShell.Api;
						I8JmDNfHNvD23TNHgrer val = new I8JmDNfHNvD23TNHgrer
						{
							Username = username,
							Password = password
						};
						O9LpdbfOncQx4LguZQ0v? registerPolicy2 = authView._registerPolicy;
						val.Email = (((registerPolicy2 != null && registerPolicy2.RequireEmail) || text.Length > 0) ? text : null);
						val.InvitationCode = ((text2.Length > 0) ? text2 : null);
						val.Machine = AppShell.RefreshMachine();
						_u__ = api.H8CcoHgumc(val).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<oSIpOJfHpmrg6bJOVFNH>, _SignUpAsync_d__27>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<oSIpOJfHpmrg6bJOVFNH>);
						num = (__1__state = -1);
					}
					_u__.GetResult();
					authView.SaveLogin(authView.RegUsernameBox.Text, authView.RegPasswordBox.Password);
					EventHandler? obj = authView.AuthenticationSucceeded;
					if (obj != null)
					{
						obj.Invoke((object)authView, EventArgs.Empty);
					}
				}
				catch (global::System.Exception exception)
				{
					authView.ShowError(AppShell.GetExceptionDisplayMessage(exception, "SignUpAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Shell\\AuthView.xaml.cs", 384));
				}
				finally
				{
					if (num < 0)
					{
						AppShell.ShowLoading(show: false);
						authView.EndAuthentication();
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
	private struct _SwitchToRegister_Click_d__30 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public AuthView __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0092: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			AuthView authView = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					NotificationAutoDismiss.Hide(authView.AuthErrorBar);
					((UIElement)authView.LoginForm).Visibility = (Visibility)1;
					((UIElement)authView.RegisterForm).Visibility = (Visibility)0;
					authView.SubtitleText.Text = "创建新账号";
					authView.RegUsernameBox.Text = authView.UsernameBox.Text;
					authView.RegPasswordBox.Password = string.Empty;
					_u__ = authView.LoadRegisterPolicyAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SwitchToRegister_Click_d__30>(ref _u__, ref this);
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
				O9LpdbfOncQx4LguZQ0v registerPolicy = authView._registerPolicy;
				if (registerPolicy != null && !registerPolicy.AllowRegistration)
				{
					authView.ShowError("当前未开放注册");
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
	private struct _WarmUpAuthenticationAsync_d__20 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

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
			try
			{
				try
				{
					TaskAwaiter _u__ = default;
					if (num != 0)
					{
						_u__ = AppShell.Api.QVPcm8NKQc().GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _WarmUpAuthenticationAsync_d__20>(ref _u__, ref this);
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
				catch
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

	private readonly cTiSRgAcCRnTC07e9Qw _credentialStore;

	private O9LpdbfOncQx4LguZQ0v? _registerPolicy;

	private bool _registerPolicyLoading;

	private bool _authenticationInProgress;

	private bool _routeSelectorReady;

	[CompilerGenerated]
	private EventHandler? m_AuthenticationSucceeded;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Storyboard AmbientAnimation;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private InfoBar AuthErrorBar;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Grid ApiRoutePanel;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel LoginForm;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private StackPanel RegisterForm;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox RegUsernameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox RegEmailBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox RegInvitationBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox RegPasswordBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock RegPolicyHint;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RegisterButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox UsernameBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private PasswordBox PasswordBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button LoginButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBox ApiRouteSelector;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBoxItem PrimaryRouteItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ComboBoxItem BackupRouteItem;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock SubtitleText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TranslateTransform Orb4Transform;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TranslateTransform Orb3Transform;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TranslateTransform Orb2Transform;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TranslateTransform Orb1Transform;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	internal EventHandler AuthenticationSucceeded;

	[MethodImpl((MethodImplOptions)8)]
	public AuthView()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		_credentialStore = new cTiSRgAcCRnTC07e9Qw();
		InitializeComponent();
		InitializeRouteSelector();
		LoadSavedLogin();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void ShowError(string? message)
	{
		AuthErrorBar.Message = (string.IsNullOrWhiteSpace(message) ? "操作失败" : message.Trim());
		AuthErrorBar.Severity = (InfoBarSeverity)3;
		NotificationAutoDismiss.Show(AuthErrorBar);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Reset(string? message)
	{
		NotificationAutoDismiss.Hide(AuthErrorBar);
		((UIElement)RegisterForm).Visibility = (Visibility)1;
		((UIElement)LoginForm).Visibility = (Visibility)0;
		RegPasswordBox.Password = string.Empty;
		SyncRouteSelector();
		LoadSavedLogin();
		if (!string.IsNullOrWhiteSpace(message))
		{
			ShowError(message);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void LoadSavedLogin()
	{
		Q8SJNySpuiTTojUZ5FF val = _credentialStore.rNYA8ot3SV();
		if (val != null)
		{
			UsernameBox.Text = val.Username;
			PasswordBox.Password = val.Password;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SaveLogin(string username, string password)
	{
		try
		{
			_credentialStore.rLTAy5MFv4(username, password);
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void InitializeRouteSelector()
	{
		Uri backupEndpointBaseUri = AppShell.Api.BackupEndpointBaseUri;
		((Control)BackupRouteItem).IsEnabled = backupEndpointBaseUri != null;
		((UIElement)ApiRoutePanel).Visibility = ((backupEndpointBaseUri == null) ? Visibility.Visible : Visibility.Collapsed);
		((Control)ApiRouteSelector).IsEnabled = backupEndpointBaseUri != null;
		SyncRouteSelector();
		_routeSelectorReady = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SyncRouteSelector()
	{
		bool routeSelectorReady = _routeSelectorReady;
		_routeSelectorReady = false;
		try
		{
			((Selector)ApiRouteSelector).SelectedItem = (AppShell.Api.IsBackupEndpointPinnedForProcess ? BackupRouteItem : PrimaryRouteItem);
		}
		finally
		{
			_routeSelectorReady = routeSelectorReady;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ApiRouteSelector_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ApiRouteSelector_SelectionChanged_d__15 apiRouteSelector_SelectionChanged_d__ = default(_ApiRouteSelector_SelectionChanged_d__15);
		apiRouteSelector_SelectionChanged_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		apiRouteSelector_SelectionChanged_d__.__4__this = this;
		apiRouteSelector_SelectionChanged_d__.__1__state = -1;
		apiRouteSelector_SelectionChanged_d__.__t__builder.Start<_ApiRouteSelector_SelectionChanged_d__15>(ref apiRouteSelector_SelectionChanged_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void AuthView_Loaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_AuthView_Loaded_d__16 authView_Loaded_d__ = default(_AuthView_Loaded_d__16);
		authView_Loaded_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		authView_Loaded_d__.__4__this = this;
		authView_Loaded_d__.__1__state = -1;
		authView_Loaded_d__.__t__builder.Start<_AuthView_Loaded_d__16>(ref authView_Loaded_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void AuthView_Unloaded(object sender, RoutedEventArgs e)
	{
		try
		{
			AmbientAnimation.Stop();
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task LoadRegisterPolicyAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoadRegisterPolicyAsync_d__18 loadRegisterPolicyAsync_d__ = default(_LoadRegisterPolicyAsync_d__18);
		loadRegisterPolicyAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		loadRegisterPolicyAsync_d__.__4__this = this;
		loadRegisterPolicyAsync_d__.__1__state = -1;
		loadRegisterPolicyAsync_d__.__t__builder.Start<_LoadRegisterPolicyAsync_d__18>(ref loadRegisterPolicyAsync_d__);
		return loadRegisterPolicyAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ApplyRegisterPolicy()
	{
		O9LpdbfOncQx4LguZQ0v registerPolicy = _registerPolicy;
		bool flag = registerPolicy != null && registerPolicy.RequireEmail;
		bool flag2 = registerPolicy != null && registerPolicy.RequireInviteCode;
		((UIElement)RegEmailBox).Visibility = ((!flag) ? Visibility.Visible : Visibility.Collapsed);
		bool flag3 = registerPolicy != null && registerPolicy.InvitationEnabled && registerPolicy.AllowRegistration;
		((UIElement)RegInvitationBox).Visibility = ((!flag3) ? Visibility.Visible : Visibility.Collapsed);
		RegInvitationBox.Header = (flag2 ? "邀请码（必填）" : "邀请码（可选）");
		if (!flag3)
		{
			RegInvitationBox.Text = string.Empty;
		}
		if (!flag)
		{
			RegEmailBox.Text = string.Empty;
		}
		List<string> val = new List<string>();
		if (registerPolicy != null)
		{
			val.Add($"密码至少 {Math.Max(registerPolicy.PasswordMinLength, 1)} 位");
			if (registerPolicy.PasswordRequireLetter)
			{
				val.Add("需包含字母");
			}
			if (registerPolicy.PasswordRequireNumber)
			{
				val.Add("需包含数字");
			}
			if (flag)
			{
				val.Add("邮箱为必填项，用于找回密码");
			}
			if (flag3)
			{
				val.Add(flag2 ? "邀请码为必填项" : "邀请码可选");
			}
			if (!registerPolicy.AllowRegistration)
			{
				val.Add("当前已关闭新用户注册");
			}
		}
		RegPolicyHint.Text = string.Join("，", (global::System.Collections.Generic.IEnumerable<string>)val);
		((UIElement)RegPolicyHint).Visibility = ((val.Count == 0) ? Visibility.Visible : Visibility.Collapsed);
		((Control)RegisterButton).IsEnabled = !_authenticationInProgress && registerPolicy != null && registerPolicy.AllowRegistration;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task WarmUpAuthenticationAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_WarmUpAuthenticationAsync_d__20 warmUpAuthenticationAsync_d__ = default(_WarmUpAuthenticationAsync_d__20);
		warmUpAuthenticationAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		warmUpAuthenticationAsync_d__.__1__state = -1;
		warmUpAuthenticationAsync_d__.__t__builder.Start<_WarmUpAuthenticationAsync_d__20>(ref warmUpAuthenticationAsync_d__);
		return warmUpAuthenticationAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string? ValidateRegisterInput(string username, string password, string email, string invitationCode)
	{
		if (username.Length == 0)
		{
			return "请输入用户名";
		}
		O9LpdbfOncQx4LguZQ0v registerPolicy = _registerPolicy;
		if (registerPolicy == null)
		{
			return "注册策略加载失败，请重新打开注册表单重试";
		}
		if (registerPolicy != null && !registerPolicy.AllowRegistration)
		{
			return "当前已关闭新用户注册";
		}
		int num = Math.Max((registerPolicy != null) ? registerPolicy.PasswordMinLength : 8, 1);
		if (password.Length < num)
		{
			return $"密码至少 {num} 位";
		}
		if (registerPolicy != null && registerPolicy.PasswordRequireLetter && !Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)password, (Func<char, bool>)char.IsLetter))
		{
			return "密码需要包含字母";
		}
		if (registerPolicy != null && registerPolicy.PasswordRequireNumber && !Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)password, (Func<char, bool>)char.IsDigit))
		{
			return "密码需要包含数字";
		}
		if (registerPolicy != null && registerPolicy.RequireEmail && !ShellView.IsValidEmail(email))
		{
			return "请输入有效的邮箱地址";
		}
		if (registerPolicy != null && registerPolicy.RequireInviteCode && string.IsNullOrWhiteSpace(invitationCode))
		{
			return "请输入邀请码";
		}
		if (invitationCode.Length > 96 || Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)invitationCode, (Func<char, bool>)char.IsWhiteSpace))
		{
			return "邀请码格式不正确";
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void LoginButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_LoginButton_Click_d__22 loginButton_Click_d__ = default(_LoginButton_Click_d__22);
		loginButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		loginButton_Click_d__.__4__this = this;
		loginButton_Click_d__.__1__state = -1;
		loginButton_Click_d__.__t__builder.Start<_LoginButton_Click_d__22>(ref loginButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RegisterButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RegisterButton_Click_d__23 registerButton_Click_d__ = default(_RegisterButton_Click_d__23);
		registerButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		registerButton_Click_d__.__4__this = this;
		registerButton_Click_d__.__1__state = -1;
		registerButton_Click_d__.__t__builder.Start<_RegisterButton_Click_d__23>(ref registerButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void PasswordBox_KeyDown(object sender, KeyRoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_PasswordBox_KeyDown_d__24 passwordBox_KeyDown_d__ = default(_PasswordBox_KeyDown_d__24);
		passwordBox_KeyDown_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		passwordBox_KeyDown_d__.__4__this = this;
		passwordBox_KeyDown_d__.e = e;
		passwordBox_KeyDown_d__.__1__state = -1;
		passwordBox_KeyDown_d__.__t__builder.Start<_PasswordBox_KeyDown_d__24>(ref passwordBox_KeyDown_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RegPasswordBox_KeyDown(object sender, KeyRoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RegPasswordBox_KeyDown_d__25 regPasswordBox_KeyDown_d__ = default(_RegPasswordBox_KeyDown_d__25);
		regPasswordBox_KeyDown_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		regPasswordBox_KeyDown_d__.__4__this = this;
		regPasswordBox_KeyDown_d__.e = e;
		regPasswordBox_KeyDown_d__.__1__state = -1;
		regPasswordBox_KeyDown_d__.__t__builder.Start<_RegPasswordBox_KeyDown_d__25>(ref regPasswordBox_KeyDown_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SignInAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SignInAsync_d__26 signInAsync_d__ = default(_SignInAsync_d__26);
		signInAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		signInAsync_d__.__4__this = this;
		signInAsync_d__.__1__state = -1;
		signInAsync_d__.__t__builder.Start<_SignInAsync_d__26>(ref signInAsync_d__);
		return signInAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task SignUpAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SignUpAsync_d__27 signUpAsync_d__ = default(_SignUpAsync_d__27);
		signUpAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		signUpAsync_d__.__4__this = this;
		signUpAsync_d__.__1__state = -1;
		signUpAsync_d__.__t__builder.Start<_SignUpAsync_d__27>(ref signUpAsync_d__);
		return signUpAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private bool TryBeginAuthentication()
	{
		if (_authenticationInProgress)
		{
			return false;
		}
		_authenticationInProgress = true;
		((Control)LoginButton).IsEnabled = false;
		((Control)RegisterButton).IsEnabled = false;
		((Control)ApiRouteSelector).IsEnabled = false;
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void EndAuthentication()
	{
		_authenticationInProgress = false;
		((Control)LoginButton).IsEnabled = true;
		Button registerButton = RegisterButton;
		O9LpdbfOncQx4LguZQ0v? registerPolicy = _registerPolicy;
		((Control)registerButton).IsEnabled = registerPolicy != null && registerPolicy.AllowRegistration;
		((Control)ApiRouteSelector).IsEnabled = AppShell.Api.BackupEndpointBaseUri != null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void SwitchToRegister_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_SwitchToRegister_Click_d__30 switchToRegister_Click_d__ = default(_SwitchToRegister_Click_d__30);
		switchToRegister_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		switchToRegister_Click_d__.__4__this = this;
		switchToRegister_Click_d__.__1__state = -1;
		switchToRegister_Click_d__.__t__builder.Start<_SwitchToRegister_Click_d__30>(ref switchToRegister_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void SwitchToLogin_Click(object sender, RoutedEventArgs e)
	{
		NotificationAutoDismiss.Hide(AuthErrorBar);
		((UIElement)RegisterForm).Visibility = (Visibility)1;
		((UIElement)LoginForm).Visibility = (Visibility)0;
		SubtitleText.Text = "登录以继续";
		UsernameBox.Text = RegUsernameBox.Text;
		PasswordBox.Password = string.Empty;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void ForgotPassword_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ForgotPassword_Click_d__32 forgotPassword_Click_d__ = default(_ForgotPassword_Click_d__32);
		forgotPassword_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		forgotPassword_Click_d__.__4__this = this;
		forgotPassword_Click_d__.__1__state = -1;
		forgotPassword_Click_d__.__t__builder.Start<_ForgotPassword_Click_d__32>(ref forgotPassword_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task ShowPasswordResetDialogAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowPasswordResetDialogAsync_d__33 showPasswordResetDialogAsync_d__ = default(_ShowPasswordResetDialogAsync_d__33);
		showPasswordResetDialogAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showPasswordResetDialogAsync_d__.__4__this = this;
		showPasswordResetDialogAsync_d__.__1__state = -1;
		showPasswordResetDialogAsync_d__.__t__builder.Start<_ShowPasswordResetDialogAsync_d__33>(ref showPasswordResetDialogAsync_d__);
		return showPasswordResetDialogAsync_d__.__t__builder.Task;
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
			Uri val = new Uri("ms-appx:///UI/Shell/AuthView.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Expected O, but got Unknown
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fb: Expected O, but got Unknown
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_0235: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Expected O, but got Unknown
		switch (connectionId)
		{
		case 1:
		{
			UserControl obj = CastExtensions.As<UserControl>(target);
			((FrameworkElement)obj).Loaded += new RoutedEventHandler(AuthView_Loaded);
			((FrameworkElement)obj).Unloaded += new RoutedEventHandler(AuthView_Unloaded);
			break;
		}
		case 2:
			AmbientAnimation = CastExtensions.As<Storyboard>(target);
			break;
		case 3:
			AuthErrorBar = CastExtensions.As<InfoBar>(target);
			break;
		case 4:
			ApiRoutePanel = CastExtensions.As<Grid>(target);
			break;
		case 5:
			LoginForm = CastExtensions.As<StackPanel>(target);
			break;
		case 6:
			RegisterForm = CastExtensions.As<StackPanel>(target);
			break;
		case 7:
			RegUsernameBox = CastExtensions.As<TextBox>(target);
			break;
		case 8:
			RegEmailBox = CastExtensions.As<TextBox>(target);
			break;
		case 9:
			RegInvitationBox = CastExtensions.As<TextBox>(target);
			break;
		case 10:
			RegPasswordBox = CastExtensions.As<PasswordBox>(target);
			((UIElement)RegPasswordBox).KeyDown += new KeyEventHandler(RegPasswordBox_KeyDown);
			break;
		case 11:
			RegPolicyHint = CastExtensions.As<TextBlock>(target);
			break;
		case 12:
			RegisterButton = CastExtensions.As<Button>(target);
			((ButtonBase)RegisterButton).Click += new RoutedEventHandler(RegisterButton_Click);
			break;
		case 13:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(SwitchToLogin_Click);
			break;
		case 14:
			UsernameBox = CastExtensions.As<TextBox>(target);
			break;
		case 15:
			PasswordBox = CastExtensions.As<PasswordBox>(target);
			((UIElement)PasswordBox).KeyDown += new KeyEventHandler(PasswordBox_KeyDown);
			break;
		case 16:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(ForgotPassword_Click);
			break;
		case 17:
			LoginButton = CastExtensions.As<Button>(target);
			((ButtonBase)LoginButton).Click += new RoutedEventHandler(LoginButton_Click);
			break;
		case 18:
			((ButtonBase)CastExtensions.As<HyperlinkButton>(target)).Click += new RoutedEventHandler(SwitchToRegister_Click);
			break;
		case 19:
			ApiRouteSelector = CastExtensions.As<ComboBox>(target);
			((Selector)ApiRouteSelector).SelectionChanged += new SelectionChangedEventHandler(ApiRouteSelector_SelectionChanged);
			break;
		case 20:
			PrimaryRouteItem = CastExtensions.As<ComboBoxItem>(target);
			break;
		case 21:
			BackupRouteItem = CastExtensions.As<ComboBoxItem>(target);
			break;
		case 22:
			SubtitleText = CastExtensions.As<TextBlock>(target);
			break;
		case 23:
			Orb4Transform = CastExtensions.As<TranslateTransform>(target);
			break;
		case 24:
			Orb3Transform = CastExtensions.As<TranslateTransform>(target);
			break;
		case 25:
			Orb2Transform = CastExtensions.As<TranslateTransform>(target);
			break;
		case 26:
			Orb1Transform = CastExtensions.As<TranslateTransform>(target);
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
	private static void _cctor()
	{
	}
}

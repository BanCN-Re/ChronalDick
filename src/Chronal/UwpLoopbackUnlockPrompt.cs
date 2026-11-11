using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using DEpkllOxX0SYLtEysJR;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using OI0DRbOnc6U9XmTja3l;
using WMO32gy5EZANSQKlHAx;
using knJtsJOEZ9ordiPYxu7;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class UwpLoopbackUnlockPrompt
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass1_0_1
	{
		[StructLayout((LayoutKind)3)]
		private struct __ShowIfNeededAsync_b__0_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass1_0_1 __4__this;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private bool _unlocked_5__3;

			private ConfiguredTaskAwaitable<wlcAHCOi3KSBuSQua4p>.ConfiguredTaskAwaiter __u__1;

			private ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter __u__2;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0080: Unknown result type (might be due to invalid IL or missing references)
				//IL_0088: Unknown result type (might be due to invalid IL or missing references)
				//IL_008d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0091: Unknown result type (might be due to invalid IL or missing references)
				//IL_0096: Unknown result type (might be due to invalid IL or missing references)
				//IL_0152: Unknown result type (might be due to invalid IL or missing references)
				//IL_0158: Unknown result type (might be due to invalid IL or missing references)
				//IL_0160: Unknown result type (might be due to invalid IL or missing references)
				//IL_0165: Unknown result type (might be due to invalid IL or missing references)
				//IL_0169: Unknown result type (might be due to invalid IL or missing references)
				//IL_016e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
				//IL_0186: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass1_0_1 _c__DisplayClass1_0_ = __4__this;
				try
				{
					if ((uint)num > 1u)
					{
						args.Cancel = true;
						_deferral_5__2 = args.GetDeferral();
						_unlocked_5__3 = false;
						_c__DisplayClass1_0_.dialog.IsPrimaryButtonEnabled = false;
						_c__DisplayClass1_0_.dialog.IsSecondaryButtonEnabled = false;
						_c__DisplayClass1_0_.details.Text = "正在请求管理员权限并为全部 UWP 应用开启本机回环访问，请稍候…";
					}
					try
					{
						ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter _u__ = default;
						ConfiguredTaskAwaitable<wlcAHCOi3KSBuSQua4p>.ConfiguredTaskAwaiter _u__2 = default;
						if (num != 0)
						{
							if (num == 1)
							{
								_u__ = __u__2;
								__u__2 = default(ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
								goto IL_01bd;
							}
							_u__2 = _c__DisplayClass1_0_.service.NevOsB5VDw(default(CancellationToken)).ConfigureAwait(true).GetAwaiter();
							if (!_u__2.IsCompleted)
							{
								num = (__1__state = 0);
								__u__1 = _u__2;
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<wlcAHCOi3KSBuSQua4p>.ConfiguredTaskAwaiter, __ShowIfNeededAsync_b__0_d>(ref _u__2, ref this);
								return;
							}
						}
						else
						{
							_u__2 = __u__1;
							__u__1 = default(ConfiguredTaskAwaitable<wlcAHCOi3KSBuSQua4p>.ConfiguredTaskAwaiter);
							num = (__1__state = -1);
						}
						wlcAHCOi3KSBuSQua4p result = _u__2.GetResult();
						if (result.Succeeded)
						{
							_u__ = _c__DisplayClass1_0_.service.PyUOFv5y7e(default(CancellationToken)).ConfigureAwait(true).GetAwaiter();
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter, __ShowIfNeededAsync_b__0_d>(ref _u__, ref this);
								return;
							}
							goto IL_01bd;
						}
						_c__DisplayClass1_0_.details.Text = (string.IsNullOrWhiteSpace(result.Error) ? "UWP 解锁失败，请稍后重试。" : ("UWP 解锁失败：" + result.Error));
						_c__DisplayClass1_0_.dialog.IsPrimaryButtonEnabled = true;
						_c__DisplayClass1_0_.dialog.IsSecondaryButtonEnabled = true;
						goto end_IL_0011;
						IL_01bd:
						aS1f1nOvDvWmiknaRRQ result2 = _u__.GetResult();
						if (result2.IsComplete)
						{
							_unlocked_5__3 = true;
						}
						else
						{
							_c__DisplayClass1_0_.details.Text = $"已完成部分设置，仍有 {((global::System.Collections.Generic.IReadOnlyCollection<string>)result2.MissingPackages).Count} 个 UWP 应用未能开启。" + "请确认管理员授权未被拦截后重试。";
							_c__DisplayClass1_0_.dialog.IsPrimaryButtonEnabled = true;
							_c__DisplayClass1_0_.dialog.IsSecondaryButtonEnabled = true;
						}
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass1_0_.details.Text = "UWP 解锁失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowIfNeededAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\UwpLoopbackUnlockPrompt.cs", 102);
						_c__DisplayClass1_0_.dialog.IsPrimaryButtonEnabled = true;
						_c__DisplayClass1_0_.dialog.IsSecondaryButtonEnabled = true;
					}
					finally
					{
						if (num < 0)
						{
							_deferral_5__2.Complete();
						}
					}
					if (_unlocked_5__3)
					{
						_c__DisplayClass1_0_.dialog.Hide();
						AppShell.Success("UWP 回环访问已开启");
					}
					end_IL_0011:;
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

		public ContentDialog dialog;

		public TextBlock details;

		public pMK19YOP7RWRqnrmhaw service;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass1_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowIfNeededAsync_b__0(ContentDialog _, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowIfNeededAsync_b__0_d _ShowIfNeededAsync_b__0_d = default(__ShowIfNeededAsync_b__0_d);
			_ShowIfNeededAsync_b__0_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowIfNeededAsync_b__0_d.__4__this = this;
			_ShowIfNeededAsync_b__0_d.args = args;
			_ShowIfNeededAsync_b__0_d.__1__state = -1;
			_ShowIfNeededAsync_b__0_d.__t__builder.Start<__ShowIfNeededAsync_b__0_d>(ref _ShowIfNeededAsync_b__0_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ShowIfNeededAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private __c__DisplayClass1_0_1 __8__1;

		private XamlRoot _xamlRoot_5__2;

		private ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter __u__1;

		private TaskAwaiter<ContentDialogResult> __u__2;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_028e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Expected O, but got Unknown
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_018c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0193: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Expected O, but got Unknown
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0257: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				if ((uint)num <= 1u || Interlocked.Exchange(ref _showing, 1) == 0)
				{
					try
					{
						if (num == 0)
						{
							goto IL_006b;
						}
						TaskAwaiter<ContentDialogResult> _u__ = default;
						if (num == 1)
						{
							_u__ = __u__2;
							__u__2 = default(TaskAwaiter<ContentDialogResult>);
							num = (__1__state = -1);
							goto IL_028c;
						}
						__8__1 = (__c__DisplayClass1_0_1)new __c__DisplayClass1_0_1();
						_xamlRoot_5__2 = AppShell.XamlRoot;
						if (_xamlRoot_5__2 != null)
						{
							__8__1.service = new pMK19YOP7RWRqnrmhaw();
							goto IL_006b;
						}
						goto end_IL_0027;
						IL_028c:
						_u__.GetResult();
						__8__1 = null;
						_xamlRoot_5__2 = null;
						goto end_IL_0027;
						IL_006b:
						aS1f1nOvDvWmiknaRRQ result;
						try
						{
							ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter _u__2 = default;
							if (num != 0)
							{
								_u__2 = __8__1.service.PyUOFv5y7e(default(CancellationToken)).ConfigureAwait(true).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter, _ShowIfNeededAsync_d__1>(ref _u__2, ref this);
									return;
								}
							}
							else
							{
								_u__2 = __u__1;
								__u__1 = default(ConfiguredTaskAwaitable<aS1f1nOvDvWmiknaRRQ>.ConfiguredTaskAwaiter);
								num = (__1__state = -1);
							}
							result = _u__2.GetResult();
						}
						catch (global::System.Exception ex)
						{
							gX17swyO7x0JWQxdaD1.U3iyRWfbJV("uwp-loopback", "检测 UWP 回环豁免失败: " + ex.Message, ex);
							goto end_IL_0027;
						}
						if (result.Error == null && ((global::System.Collections.Generic.IReadOnlyCollection<string>)result.MissingPackages).Count != 0)
						{
							__8__1.details = new TextBlock
							{
								Text = $"检测到 {((global::System.Collections.Generic.IReadOnlyCollection<string>)result.MissingPackages).Count} 个 UWP 应用尚未开启本机回环访问。\n\n" + "开启后，UWP 应用才能访问本机服务，部分代理、登录和联机功能会依赖此设置。这不会修改应用文件，也不会改变商店授权。\n\n是否现在为全部 UWP 应用开启？此操作需要管理员权限。",
								TextWrapping = (TextWrapping)2,
								MaxWidth = 520.0
							};
							__8__1.dialog = new ContentDialog
							{
								XamlRoot = _xamlRoot_5__2,
								RequestedTheme = AppearanceSettings.Theme,
								Title = "检测到 UWP 未解锁",
								Content = __8__1.details,
								PrimaryButtonText = "是",
								SecondaryButtonText = "否",
								DefaultButton = (ContentDialogButton)1
							};
							__8__1.dialog.PrimaryButtonClick += __8__1._ShowIfNeededAsync_b__0;
							_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(__8__1.dialog.ShowAsync());
							if (!_u__.IsCompleted)
							{
								num = (__1__state = 1);
								__u__2 = _u__;
								__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ContentDialogResult>, _ShowIfNeededAsync_d__1>(ref _u__, ref this);
								return;
							}
							goto IL_028c;
						}
						end_IL_0027:;
					}
					catch (global::System.Exception ex2)
					{
						gX17swyO7x0JWQxdaD1.U3iyRWfbJV("uwp-loopback", "UWP 解锁提示显示失败: " + ex2.Message, ex2);
					}
					finally
					{
						if (num < 0)
						{
							Volatile.Write(ref _showing, 0);
						}
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

	private static int _showing;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task ShowIfNeededAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_ShowIfNeededAsync_d__1 showIfNeededAsync_d__ = default(_ShowIfNeededAsync_d__1);
		showIfNeededAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		showIfNeededAsync_d__.__1__state = -1;
		showIfNeededAsync_d__.__t__builder.Start<_ShowIfNeededAsync_d__1>(ref showIfNeededAsync_d__);
		return showIfNeededAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using By1SFsLobKQOZCdh5qRg;
using EiAPRwJSDFvNotiSTTX;
using LtCF3VfeBD0w3fV2hfaC;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using SGLutIO07VZ7bawO9WX;
using Windows.System;
using jayVXsfeU04hSNk3ePPo;
using lfQ1Oof50HTLLTV2kOfH;
using qS8vkpL43FlTMgcj0rgs;
using tba4F6W6dnIXWgnyGcc;

namespace Mahiro_Account.UI;

internal static class AppUpdateFlow
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass0_0
	{
		[StructLayout((LayoutKind)3)]
		public struct __ShowAsync_b__1_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass0_0 __4__this;

			public ContentDialog sender;

			private __c__DisplayClass0_1 __8__1;

			private ContentDialogButtonClickDeferral _deferral_5__2;

			private TaskAwaiter __u__1;

			private CancellationTokenSource _cancellation_5__3;

			private TaskAwaiter<w0y6HIfeI5bDPsB7ikaO> __u__2;

			private TaskAwaiter<string> __u__3;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_0089: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_0188: Unknown result type (might be due to invalid IL or missing references)
				//IL_018d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0197: Expected O, but got Unknown
				//IL_0053: Unknown result type (might be due to invalid IL or missing references)
				//IL_0058: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0070: Unknown result type (might be due to invalid IL or missing references)
				//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
				//IL_0207: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
				//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02df: Unknown result type (might be due to invalid IL or missing references)
				//IL_0389: Unknown result type (might be due to invalid IL or missing references)
				//IL_038e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0396: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
				//IL_0347: Unknown result type (might be due to invalid IL or missing references)
				//IL_0351: Unknown result type (might be due to invalid IL or missing references)
				//IL_0356: Unknown result type (might be due to invalid IL or missing references)
				//IL_01df: Unknown result type (might be due to invalid IL or missing references)
				//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0290: Unknown result type (might be due to invalid IL or missing references)
				//IL_029a: Unknown result type (might be due to invalid IL or missing references)
				//IL_029f: Unknown result type (might be due to invalid IL or missing references)
				//IL_036e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0370: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b7: Unknown result type (might be due to invalid IL or missing references)
				//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass0_0 _c__DisplayClass0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_00a4;
					}
					if ((uint)(num - 1) <= 2u)
					{
						goto IL_015e;
					}
					args.Cancel = true;
					if (_c__DisplayClass0_.selfUpdateSupported)
					{
						_deferral_5__2 = args.GetDeferral();
						_c__DisplayClass0_.updating = true;
						sender.IsPrimaryButtonEnabled = false;
						sender.IsSecondaryButtonEnabled = false;
						((UIElement)_c__DisplayClass0_.progressBar).Visibility = (Visibility)0;
						((UIElement)_c__DisplayClass0_.progressText).Visibility = (Visibility)0;
						_c__DisplayClass0_.progressText.Text = "正在获取安装包直链…";
						goto IL_015e;
					}
					if (_c__DisplayClass0_.hasDownloadPage)
					{
						_u__ = OpenDownloadPageAsync(_c__DisplayClass0_.result, _c__DisplayClass0_.progressText).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ShowAsync_b__1_d>(ref _u__, ref this);
							return;
						}
						goto IL_00a4;
					}
					if (_c__DisplayClass0_.mandatory)
					{
						_c__DisplayClass0_.updateStarted = true;
						sender.Hide();
						_c__DisplayClass0_.requestExit.Invoke();
					}
					goto end_IL_0011;
					IL_00a4:
					_u__.GetResult();
					if (_c__DisplayClass0_.mandatory)
					{
						_c__DisplayClass0_.updateStarted = true;
						sender.Hide();
						_c__DisplayClass0_.requestExit.Invoke();
					}
					goto end_IL_0011;
					IL_015e:
					try
					{
						if ((uint)(num - 1) > 2u)
						{
							__8__1 = (__c__DisplayClass0_1)new __c__DisplayClass0_1();
							__8__1.CS___8__locals1 = _c__DisplayClass0_;
							_cancellation_5__3 = new CancellationTokenSource(TimeSpan.FromMinutes(15.0));
						}
						try
						{
							TaskAwaiter<w0y6HIfeI5bDPsB7ikaO> _u__3 = default;
							TaskAwaiter<string> _u__2 = default;
							string result;
							w0y6HIfeI5bDPsB7ikaO result2;
							Progress<tW0BDPf5cuc4Pv1qq5Rq> val;
							switch (num)
							{
							default:
								_u__3 = _c__DisplayClass0_.autoUpdateService.SSCWwjDLNC(_cancellation_5__3.Token).GetAwaiter();
								if (!_u__3.IsCompleted)
								{
									num = (__1__state = 1);
									__u__2 = _u__3;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<w0y6HIfeI5bDPsB7ikaO>, __ShowAsync_b__1_d>(ref _u__3, ref this);
									return;
								}
								goto IL_0216;
							case 1:
								_u__3 = __u__2;
								__u__2 = default(TaskAwaiter<w0y6HIfeI5bDPsB7ikaO>);
								num = (__1__state = -1);
								goto IL_0216;
							case 2:
								_u__2 = __u__3;
								__u__3 = default(TaskAwaiter<string>);
								num = (__1__state = -1);
								goto IL_02ee;
							case 3:
								{
									_u__2 = __u__3;
									__u__3 = default(TaskAwaiter<string>);
									num = (__1__state = -1);
									break;
								}
								IL_02ee:
								result = _u__2.GetResult();
								__8__1.zipPath = result;
								_c__DisplayClass0_.progressBar.IsIndeterminate = true;
								_c__DisplayClass0_.progressText.Text = "正在解压安装包…";
								_c__DisplayClass0_.transferText.Text = "安装包下载完成";
								_u__2 = global::System.Threading.Tasks.Task.Run<string>((Func<string>)__8__1._ShowAsync_b__4, _cancellation_5__3.Token).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 3);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __ShowAsync_b__1_d>(ref _u__2, ref this);
									return;
								}
								break;
								IL_0216:
								result2 = _u__3.GetResult();
								_c__DisplayClass0_.progressBar.IsIndeterminate = false;
								_c__DisplayClass0_.progressText.Text = "正在下载安装包… 0%";
								((UIElement)_c__DisplayClass0_.transferText).Visibility = (Visibility)0;
								_c__DisplayClass0_.transferText.Text = "正在计算下载速度…";
								val = new Progress<tW0BDPf5cuc4Pv1qq5Rq>((Action<tW0BDPf5cuc4Pv1qq5Rq>)_c__DisplayClass0_._ShowAsync_b__3);
								_u__2 = _c__DisplayClass0_.autoUpdateService.BTXWPCMnQ3(result2, (IProgress<tW0BDPf5cuc4Pv1qq5Rq>)(object)val, _cancellation_5__3.Token).GetAwaiter();
								if (!_u__2.IsCompleted)
								{
									num = (__1__state = 2);
									__u__3 = _u__2;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<string>, __ShowAsync_b__1_d>(ref _u__2, ref this);
									return;
								}
								goto IL_02ee;
							}
							string result3 = _u__2.GetResult();
							_c__DisplayClass0_.progressText.Text = "准备安装新版本并重启…";
							qJZUC0JY3okUVxPyXoP.gkTJydRdHq(_c__DisplayClass0_.result.LocalVersion);
							_c__DisplayClass0_.autoUpdateService.XIrWNuxQHw(result3, __8__1.zipPath);
							_c__DisplayClass0_.updating = false;
							_c__DisplayClass0_.updateStarted = true;
						}
						finally
						{
							if (num < 0 && _cancellation_5__3 != null)
							{
								((global::System.IDisposable)_cancellation_5__3).Dispose();
							}
						}
						__8__1 = null;
						_cancellation_5__3 = null;
					}
					catch (global::System.Exception exception)
					{
						_c__DisplayClass0_.updating = false;
						_c__DisplayClass0_.progressBar.IsIndeterminate = false;
						((RangeBase)_c__DisplayClass0_.progressBar).Value = 0.0;
						((UIElement)_c__DisplayClass0_.progressBar).Visibility = (Visibility)1;
						((UIElement)_c__DisplayClass0_.transferText).Visibility = (Visibility)1;
						_c__DisplayClass0_.progressText.Text = "自动更新失败：" + AppShell.GetExceptionDisplayMessage(exception, "ShowAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\AppUpdateFlow.cs", 206);
						sender.IsPrimaryButtonEnabled = true;
						sender.IsSecondaryButtonEnabled = true;
					}
					finally
					{
						if (num < 0)
						{
							_deferral_5__2.Complete();
						}
					}
					if (_c__DisplayClass0_.updateStarted)
					{
						sender.Hide();
						_c__DisplayClass0_.requestExit.Invoke();
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

		[StructLayout((LayoutKind)3)]
		public struct __ShowAsync_b__2_d : IAsyncStateMachine
		{
			public int __1__state;

			public AsyncVoidMethodBuilder __t__builder;

			public ContentDialogButtonClickEventArgs args;

			public __c__DisplayClass0_0 __4__this;

			public ContentDialog sender;

			private TaskAwaiter __u__1;

			[MethodImpl((MethodImplOptions)8)]
			public void MoveNext()
			{
				//IL_007a: Unknown result type (might be due to invalid IL or missing references)
				//IL_007f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_0044: Unknown result type (might be due to invalid IL or missing references)
				//IL_0049: Unknown result type (might be due to invalid IL or missing references)
				//IL_0060: Unknown result type (might be due to invalid IL or missing references)
				//IL_0061: Unknown result type (might be due to invalid IL or missing references)
				int num = __1__state;
				__c__DisplayClass0_0 _c__DisplayClass0_ = __4__this;
				try
				{
					TaskAwaiter _u__ = default;
					if (num == 0)
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter);
						num = (__1__state = -1);
						goto IL_0095;
					}
					args.Cancel = true;
					if (_c__DisplayClass0_.hasDownloadPage)
					{
						_u__ = OpenDownloadPageAsync(_c__DisplayClass0_.result, _c__DisplayClass0_.progressText).GetAwaiter();
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, __ShowAsync_b__2_d>(ref _u__, ref this);
							return;
						}
						goto IL_0095;
					}
					goto end_IL_0011;
					IL_0095:
					_u__.GetResult();
					if (_c__DisplayClass0_.mandatory)
					{
						_c__DisplayClass0_.updateStarted = true;
						sender.Hide();
						_c__DisplayClass0_.requestExit.Invoke();
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

		public bool updating;

		public bool mandatory;

		public bool updateStarted;

		public bool selfUpdateSupported;

		public bool hasDownloadPage;

		public sJFvIGfehRs7r8TsV0mL result;

		public TextBlock progressText;

		public Action requestExit;

		public ProgressBar progressBar;

		public bgH5nMW5qDiNZhSNyrs autoUpdateService;

		public TextBlock transferText;

		public Action<tW0BDPf5cuc4Pv1qq5Rq> __9__3;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass0_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowAsync_b__0(ContentDialog _, ContentDialogClosingEventArgs args)
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (updating)
			{
				args.Cancel = true;
			}
			else if (mandatory && !updateStarted && (int)args.Result == 0)
			{
				args.Cancel = true;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowAsync_b__1(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowAsync_b__1_d _ShowAsync_b__1_d = default(__ShowAsync_b__1_d);
			_ShowAsync_b__1_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowAsync_b__1_d.__4__this = this;
			_ShowAsync_b__1_d.sender = sender;
			_ShowAsync_b__1_d.args = args;
			_ShowAsync_b__1_d.__1__state = -1;
			_ShowAsync_b__1_d.__t__builder.Start<__ShowAsync_b__1_d>(ref _ShowAsync_b__1_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _ShowAsync_b__3(tW0BDPf5cuc4Pv1qq5Rq value)
		{
			((RangeBase)progressBar).Value = value.Fraction;
			progressText.Text = $"正在下载安装包… {value.Fraction * 100.0:0}%";
			long? totalBytes = value.TotalBytes;
			string text = ((totalBytes.HasValue && totalBytes.GetValueOrDefault() > 0) ? (" / " + W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(value.TotalBytes.Value)) : string.Empty);
			transferText.Text = W0wBpiOcLVX0Ukx7VdU.yWJO8A6iPJ(value.BytesTransferred) + text + "  ·  " + W0wBpiOcLVX0Ukx7VdU.MFpOy4Ua8e((double?)value.BytesPerSecond);
		}

		[MethodImpl((MethodImplOptions)8)]
		[AsyncStateMachine(typeof(object))]
		internal void _ShowAsync_b__2(ContentDialog sender, ContentDialogButtonClickEventArgs args)
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__ShowAsync_b__2_d _ShowAsync_b__2_d = default(__ShowAsync_b__2_d);
			_ShowAsync_b__2_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowAsync_b__2_d.__4__this = this;
			_ShowAsync_b__2_d.sender = sender;
			_ShowAsync_b__2_d.args = args;
			_ShowAsync_b__2_d.__1__state = -1;
			_ShowAsync_b__2_d.__t__builder.Start<__ShowAsync_b__2_d>(ref _ShowAsync_b__2_d);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass0_1
	{
		public string zipPath;

		public __c__DisplayClass0_0 CS___8__locals1;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _ShowAsync_b__4()
		{
			return CS___8__locals1.autoUpdateService.vKwWswkduc(zipPath);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OpenDownloadPageAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public sJFvIGfehRs7r8TsV0mL result;

		public TextBlock feedback;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			try
			{
				try
				{
					bool flag;
					TaskAwaiter<bool> _u__ = default;
					if (num != 0)
					{
						flag = result.DownloadUri != null;
						if (!flag)
						{
							goto IL_0094;
						}
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(result.DownloadUri));
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _OpenDownloadPageAsync_d__1>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					flag = _u__.GetResult();
					goto IL_0094;
					IL_0094:
					if (!flag)
					{
						goto end_IL_000d;
					}
					goto end_IL_000a;
					end_IL_000d:;
				}
				catch (global::System.Exception)
				{
				}
				((UIElement)feedback).Visibility = (Visibility)0;
				feedback.Text = "无法打开下载链接，请检查系统默认浏览器后重试。";
				end_IL_000a:;
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

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<bool> ShowAsync(XamlRoot? xamlRoot, sJFvIGfehRs7r8TsV0mL result, bool mandatory, Action requestExit)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		__c__DisplayClass0_0 __8_locals33 = (__c__DisplayClass0_0)new __c__DisplayClass0_0();
		__8_locals33.mandatory = mandatory;
		__8_locals33.result = result;
		__8_locals33.requestExit = requestExit;
		if (xamlRoot == null)
		{
			return false;
		}
		__8_locals33.autoUpdateService = new bgH5nMW5qDiNZhSNyrs();
		__8_locals33.selfUpdateSupported = bgH5nMW5qDiNZhSNyrs.OxAWRJqmsM();
		__8_locals33.hasDownloadPage = __8_locals33.result.DownloadUri != null && !string.IsNullOrWhiteSpace(__8_locals33.result.DownloadLink);
		TextBlock val = new TextBlock
		{
			Text = (__8_locals33.mandatory ? $"当前版本 {__8_locals33.result.LocalVersion}，最新版本 {__8_locals33.result.LatestVersion}。必须更新后才能继续使用。" : $"当前版本 {__8_locals33.result.LocalVersion}，最新版本 {__8_locals33.result.LatestVersion}。"),
			TextWrapping = (TextWrapping)2
		};
		TextBlock val2 = new TextBlock
		{
			Text = (__8_locals33.selfUpdateSupported ? "点击「立即更新」将自动下载安装包，覆盖当前版本并重新启动。" : "当前安装目录不可写，请使用下载页手动更新（或以管理员身份重新运行）。"),
			TextWrapping = (TextWrapping)2,
			Style = null
		};
		__8_locals33.progressBar = new ProgressBar
		{
			Minimum = 0.0,
			Maximum = 1.0,
			Value = 0.0,
			IsIndeterminate = true,
			Visibility = (Visibility)1
		};
		__8_locals33.progressText = new TextBlock
		{
			TextWrapping = (TextWrapping)2,
			Visibility = (Visibility)1,
			Style = null
		};
		__8_locals33.transferText = new TextBlock
		{
			TextWrapping = (TextWrapping)2,
			Visibility = (Visibility)1,
			Style = null
		};
		StackPanel val3 = new StackPanel
		{
			Spacing = 10.0,
			MaxWidth = 520.0
		};
		((Panel)val3).Children.Add((UIElement)(object)val);
		((Panel)val3).Children.Add((UIElement)(object)val2);
		((Panel)val3).Children.Add((UIElement)(object)__8_locals33.progressBar);
		((Panel)val3).Children.Add((UIElement)(object)__8_locals33.progressText);
		((Panel)val3).Children.Add((UIElement)(object)__8_locals33.transferText);
		ContentDialog val4 = new ContentDialog
		{
			XamlRoot = xamlRoot,
			RequestedTheme = AppearanceSettings.Theme,
			Title = (__8_locals33.mandatory ? "必须更新" : "发现新版本"),
			Content = val3,
			DefaultButton = (ContentDialogButton)1
		};
		if (__8_locals33.selfUpdateSupported)
		{
			val4.PrimaryButtonText = "立即更新";
			val4.SecondaryButtonText = (__8_locals33.hasDownloadPage ? "打开下载页" : null);
		}
		else
		{
			val4.PrimaryButtonText = (__8_locals33.hasDownloadPage ? "打开下载页" : "知道了");
		}
		if (!__8_locals33.mandatory)
		{
			val4.CloseButtonText = "稍后";
		}
		__8_locals33.updating = false;
		__8_locals33.updateStarted = false;
		val4.Closing += [MethodImpl((MethodImplOptions)8)] (ContentDialog _, ContentDialogClosingEventArgs args) =>
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (__8_locals33.updating)
			{
				args.Cancel = true;
			}
			else if (__8_locals33.mandatory && !__8_locals33.updateStarted && (int)args.Result == 0)
			{
				args.Cancel = true;
			}
		};
		val4.PrimaryButtonClick += [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] (ContentDialog sender, ContentDialogButtonClickEventArgs args) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass0_0.__ShowAsync_b__1_d _ShowAsync_b__1_d = default(__c__DisplayClass0_0.__ShowAsync_b__1_d);
			_ShowAsync_b__1_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowAsync_b__1_d.__4__this = __8_locals33;
			_ShowAsync_b__1_d.sender = sender;
			_ShowAsync_b__1_d.args = args;
			_ShowAsync_b__1_d.__1__state = -1;
			_ShowAsync_b__1_d.__t__builder.Start<__c__DisplayClass0_0.__ShowAsync_b__1_d>(ref _ShowAsync_b__1_d);
		};
		val4.SecondaryButtonClick += [MethodImpl((MethodImplOptions)8)] [AsyncStateMachine(typeof(object))] (ContentDialog sender, ContentDialogButtonClickEventArgs args) =>
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			__c__DisplayClass0_0.__ShowAsync_b__2_d _ShowAsync_b__2_d = default(__c__DisplayClass0_0.__ShowAsync_b__2_d);
			_ShowAsync_b__2_d.__t__builder = AsyncVoidMethodBuilder.Create();
			_ShowAsync_b__2_d.__4__this = __8_locals33;
			_ShowAsync_b__2_d.sender = sender;
			_ShowAsync_b__2_d.args = args;
			_ShowAsync_b__2_d.__1__state = -1;
			_ShowAsync_b__2_d.__t__builder.Start<__c__DisplayClass0_0.__ShowAsync_b__2_d>(ref _ShowAsync_b__2_d);
		};
		TaskAwaiter<ContentDialogResult> val5 = WindowsRuntimeSystemExtensions.GetAwaiter<ContentDialogResult>(val4.ShowAsync());
		if (!val5.IsCompleted)
		{
			val5.GetResult();
			TaskAwaiter<ContentDialogResult> val6 = default(TaskAwaiter<ContentDialogResult>);
			val5 = val6;
		}
		val5.GetResult();
		return __8_locals33.updateStarted;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task OpenDownloadPageAsync(sJFvIGfehRs7r8TsV0mL result, TextBlock feedback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OpenDownloadPageAsync_d__1 openDownloadPageAsync_d__ = default(_OpenDownloadPageAsync_d__1);
		openDownloadPageAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		openDownloadPageAsync_d__.result = result;
		openDownloadPageAsync_d__.feedback = feedback;
		openDownloadPageAsync_d__.__1__state = -1;
		openDownloadPageAsync_d__.__t__builder.Start<_OpenDownloadPageAsync_d__1>(ref openDownloadPageAsync_d__);
		return openDownloadPageAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

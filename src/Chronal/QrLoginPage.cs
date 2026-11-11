using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AT3I7sfwZothDnPCovM6;
using By1SFsLobKQOZCdh5qRg;
using HyH29AfPDgIWpjh1J2P1;
using Mahiro_Account.UI;
using Mahiro_Account.UI.Navigation;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Markup;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using QRCoder;
using SrTRlrfwcUIDlpgSI2lW;
using WMO32gy5EZANSQKlHAx;
using WinRT;
using WinRT.ChronalVtableClasses;
using Windows.Storage.Streams;
using Windows.System;
using bUfedyCg1PBqhqIkB8r;
using f7RjHTINjctjOLPOHGn;
using ghJqOefwYjKrGahxnvYK;
using qS8vkpL43FlTMgcj0rgs;
using qhpqa0B0cyZ72OPoi8t;

namespace Mahiro_Account.Views.Pages;

[WinRTRuntimeClassName("Microsoft.UI.Xaml.IUIElementOverrides")]
[WinRTExposedType(typeof(Mahiro_Account_Features_McpStudio_Views_McpStudioPageWinRTTypeDetails))]
public sealed class QrLoginPage : Page, IComponentConnector
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass12_0_3
	{
		public QrLoginPage __4__this;

		public CancellationTokenSource operation;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _OnLoaded_d__6_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public QrLoginPage __4__this;

		private TaskAwaiter __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Expected O, but got Unknown
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			QrLoginPage qrLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num == 0)
				{
					_u__ = __u__1;
					__u__1 = default(TaskAwaiter);
					num = (__1__state = -1);
					goto IL_0096;
				}
				if (!qrLoginPage._active)
				{
					qrLoginPage._active = true;
					AppShell.SessionCleared += new EventHandler(qrLoginPage.OnSessionCleared);
					_u__ = qrLoginPage.StartLoginAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _OnLoaded_d__6_1>(ref _u__, ref this);
						return;
					}
					goto IL_0096;
				}
				goto end_IL_0011;
				IL_0096:
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
	private struct _RefreshButton_Click_d__11_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public QrLoginPage __4__this;

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
			QrLoginPage qrLoginPage = __4__this;
			try
			{
				TaskAwaiter _u__ = default;
				if (num != 0)
				{
					_u__ = qrLoginPage.StartLoginAsync().GetAwaiter();
					if (!_u__.IsCompleted)
					{
						num = (__1__state = 0);
						__u__1 = _u__;
						__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RefreshButton_Click_d__11_1>(ref _u__, ref this);
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
	private struct _StartLoginAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public QrLoginPage __4__this;

		private __c__DisplayClass12_0_3 __8__1;

		private zmDKtAITNJAAOKv0pRj _service_5__2;

		private CancellationToken _token_5__3;

		private khnBI1fwjAwYr3QEry7m _session_5__4;

		private QRCodeGenerator _generator_5__5;

		private QRCoder.QRCodeData _data_5__6;

		private PngByteQRCode _qr_5__7;

		private InMemoryRandomAccessStream _stream_5__8;

		private BitmapImage _bitmap_5__9;

		private int _failures_5__10;

		private TaskAwaiter<khnBI1fwjAwYr3QEry7m> __u__1;

		private TaskAwaiter<uint> __u__2;

		private TaskAwaiter __u__3;

		private TaskAwaiter<IRXBK4fwS2F7hX7yc0OL> __u__4;

		private TaskAwaiter<bool> __u__5;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_074e: Expected O, but got Unknown
			//IL_07cc: Expected O, but got Unknown
			//IL_0806: Expected O, but got Unknown
			//IL_097d: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Expected O, but got Unknown
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got Unknown
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0414: Unknown result type (might be due to invalid IL or missing references)
			//IL_0416: Unknown result type (might be due to invalid IL or missing references)
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Unknown result type (might be due to invalid IL or missing references)
			//IL_053d: Invalid comparison between Unknown and I4
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Expected O, but got Unknown
			//IL_0103: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0112: Unknown result type (might be due to invalid IL or missing references)
			//IL_065a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0660: Invalid comparison between Unknown and I4
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0690: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Unknown result type (might be due to invalid IL or missing references)
			//IL_0697: Unknown result type (might be due to invalid IL or missing references)
			//IL_069a: Invalid comparison between Unknown and I4
			//IL_059f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_069f: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a2: Invalid comparison between Unknown and I4
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Expected O, but got Unknown
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d3: Expected O, but got Unknown
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_028c: Expected O, but got Unknown
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			QrLoginPage qrLoginPage = __4__this;
			try
			{
				if ((uint)num <= 5u)
				{
					goto IL_0064;
				}
				__8__1.__4__this = __4__this;
				if (qrLoginPage._active)
				{
					qrLoginPage.CancelLogin();
					qrLoginPage.ClearResult();
					__8__1.operation = new CancellationTokenSource(TimeSpan.FromMinutes(3.0));
					goto IL_0064;
				}
				goto end_IL_0011;
				IL_0064:
				try
				{
					if ((uint)num > 5u)
					{
						_service_5__2 = new zmDKtAITNJAAOKv0pRj();
					}
					try
					{
						if ((uint)num > 5u)
						{
							qrLoginPage._operation = __8__1.operation;
							_token_5__3 = __8__1.operation.Token;
							qrLoginPage.LoadingRing.IsActive = true;
							((Control)qrLoginPage.RefreshButton).IsEnabled = false;
							qrLoginPage.StatusText.Text = "正在生成二维码…";
						}
						try
						{
							TaskAwaiter<khnBI1fwjAwYr3QEry7m> _u__ = default;
							if (num != 0)
							{
								if ((uint)(num - 1) <= 4u)
								{
									goto IL_0179;
								}
								gX17swyO7x0JWQxdaD1.IdOy6I4Chb("QrLogin", "扫码诊断文件：" + _service_5__2.DiagnosticLogPath);
								_u__ = _service_5__2.QQrIMyDOOp(_token_5__3).GetAwaiter();
								if (!_u__.IsCompleted)
								{
									num = (__1__state = 0);
									__u__1 = _u__;
									__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<khnBI1fwjAwYr3QEry7m>, _StartLoginAsync_d__12>(ref _u__, ref this);
									return;
								}
							}
							else
							{
								_u__ = __u__1;
								__u__1 = default(TaskAwaiter<khnBI1fwjAwYr3QEry7m>);
								num = (__1__state = -1);
							}
							khnBI1fwjAwYr3QEry7m result = _u__.GetResult();
							_session_5__4 = result;
							_generator_5__5 = new QRCodeGenerator();
							goto IL_0179;
							IL_0179:
							try
							{
								if ((uint)(num - 1) > 4u)
								{
									_data_5__6 = _generator_5__5.CreateQrCode(_session_5__4.ScanUrl, (QRCodeGenerator.ECCLevel)1, false, false, (QRCodeGenerator.EciMode)0, -1);
								}
								try
								{
									if ((uint)(num - 1) > 4u)
									{
										_qr_5__7 = new PngByteQRCode(_data_5__6);
									}
									try
									{
										if ((uint)(num - 1) > 4u)
										{
											_stream_5__8 = new InMemoryRandomAccessStream();
										}
										try
										{
											TaskAwaiter<uint> _u__4 = default;
											TaskAwaiter _u__3 = default;
											TaskAwaiter<bool> _u__2 = default;
											bool result2;
											switch (num)
											{
											default:
												_u__4 = WindowsRuntimeSystemExtensions.AsTask<uint, uint>(_stream_5__8.WriteAsync(WindowsRuntimeBufferExtensions.AsBuffer(_qr_5__7.GetGraphic(8, true))), _token_5__3).GetAwaiter();
												if (!_u__4.IsCompleted)
												{
													num = (__1__state = 1);
													__u__2 = _u__4;
													__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<uint>, _StartLoginAsync_d__12>(ref _u__4, ref this);
													return;
												}
												goto IL_026c;
											case 1:
												_u__4 = __u__2;
												__u__2 = default(TaskAwaiter<uint>);
												num = (__1__state = -1);
												goto IL_026c;
											case 2:
												_u__3 = __u__3;
												__u__3 = default(TaskAwaiter);
												num = (__1__state = -1);
												goto IL_02fc;
											case 3:
												_u__3 = __u__3;
												__u__3 = default(TaskAwaiter);
												num = (__1__state = -1);
												goto IL_03d1;
											case 4:
											{
												IRXBK4fwS2F7hX7yc0OL result3;
												try
												{
													TaskAwaiter<IRXBK4fwS2F7hX7yc0OL> _u__5 = default;
													if (num != 4)
													{
														_u__5 = _service_5__2.Jy7Ip1rovT(_session_5__4, _token_5__3).GetAwaiter();
														if (!_u__5.IsCompleted)
														{
															num = (__1__state = 4);
															__u__4 = _u__5;
															__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IRXBK4fwS2F7hX7yc0OL>, _StartLoginAsync_d__12>(ref _u__5, ref this);
															return;
														}
													}
													else
													{
														_u__5 = __u__4;
														__u__4 = default(TaskAwaiter<IRXBK4fwS2F7hX7yc0OL>);
														num = (__1__state = -1);
													}
													result3 = _u__5.GetResult();
													_failures_5__10 = 0;
												}
												catch (global::System.Exception ex) when ((ex is HttpRequestException || ex is OperationCanceledException) && !_token_5__3.IsCancellationRequested && ++_failures_5__10 < 3)
												{
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "StartLoginAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\QrLoginPage.xaml.cs", 118);
													_service_5__2.R0mIvYEdQO("ui_poll_retry", ex);
													if (!qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
													{
														break;
													}
													qrLoginPage.StatusText.Text = "网络暂时不可用，正在重试…";
													goto IL_0364;
												}
												_token_5__3.ThrowIfCancellationRequested();
												if (!qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
												{
													break;
												}
												if ((int)result3.Status == 2 && !string.IsNullOrWhiteSpace(result3.SauthJson))
												{
													qrLoginPage.ResultBox.Text = result3.SauthJson;
													((Control)qrLoginPage.CopyButton).IsEnabled = true;
													qrLoginPage.StatusText.Text = "扫码登录成功，正在保存账号记录…";
													qrLoginPage.QrImage.Source = null;
													_u__2 = SaveGeneratedAccountAsync(result3.SauthJson, _service_5__2).GetAwaiter();
													if (!_u__2.IsCompleted)
													{
														num = (__1__state = 5);
														__u__5 = _u__2;
														__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _StartLoginAsync_d__12>(ref _u__2, ref this);
														return;
													}
													goto IL_05f3;
												}
												if ((int)result3.Status == 3)
												{
													qrLoginPage.StatusText.Text = "二维码已过期，请刷新";
													qrLoginPage.QrImage.Source = null;
													break;
												}
												TextBlock statusText = qrLoginPage.StatusText;
												y3IdabfwVlgiI5udlxtM status = result3.Status;
												string text = (((int)status == 1) ? "已扫码，请在手机上确认登录…" : (((int)status != 4) ? "等待扫码，请在手机上确认登录" : "已确认，正在获取 SAuth；换票未完成，正在重试…"));
												statusText.Text = text;
												goto IL_0364;
											}
											case 5:
												{
													_u__2 = __u__5;
													__u__5 = default(TaskAwaiter<bool>);
													num = (__1__state = -1);
													goto IL_05f3;
												}
												IL_05f3:
												result2 = _u__2.GetResult();
												if (qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
												{
													qrLoginPage.StatusText.Text = (result2 ? "扫码登录成功，已保存到网易转 SAuth 账号记录" : "SAuth 已生成，但账号记录保存失败，可先复制 SAuth");
													if (result2)
													{
														AppShell.Success("扫码账号和 SAuth 已保存");
													}
													else
													{
														AppShell.Error("账号记录保存失败，请先复制 SAuth");
													}
												}
												break;
												IL_026c:
												_u__4.GetResult();
												_stream_5__8.Seek(0uL);
												_bitmap_5__9 = new BitmapImage();
												_u__3 = WindowsRuntimeSystemExtensions.AsTask(((BitmapSource)_bitmap_5__9).SetSourceAsync((IRandomAccessStream)(object)_stream_5__8), _token_5__3).GetAwaiter();
												if (!_u__3.IsCompleted)
												{
													num = (__1__state = 2);
													__u__3 = _u__3;
													__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartLoginAsync_d__12>(ref _u__3, ref this);
													return;
												}
												goto IL_02fc;
												IL_03d1:
												_u__3.GetResult();
												goto case 4;
												IL_02fc:
												_u__3.GetResult();
												_token_5__3.ThrowIfCancellationRequested();
												if (!qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
												{
													break;
												}
												qrLoginPage.QrImage.Source = (ImageSource)(object)_bitmap_5__9;
												qrLoginPage.LoadingRing.IsActive = false;
												((Control)qrLoginPage.RefreshButton).IsEnabled = true;
												qrLoginPage.StatusText.Text = "等待扫码，请在手机上确认登录";
												_failures_5__10 = 0;
												goto IL_0364;
												IL_0364:
												_u__3 = global::System.Threading.Tasks.Task.Delay(TimeSpan.FromSeconds(2.0), _token_5__3).GetAwaiter();
												if (!_u__3.IsCompleted)
												{
													num = (__1__state = 3);
													__u__3 = _u__3;
													__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _StartLoginAsync_d__12>(ref _u__3, ref this);
													return;
												}
												goto IL_03d1;
											}
										}
										finally
										{
											if (num < 0 && _stream_5__8 != null)
											{
												((global::System.IDisposable)_stream_5__8).Dispose();
											}
										}
									}
									finally
									{
										if (num < 0 && _qr_5__7 != null)
										{
											((global::System.IDisposable)_qr_5__7).Dispose();
										}
									}
								}
								finally
								{
									if (num < 0 && _data_5__6 != null)
									{
										((global::System.IDisposable)_data_5__6).Dispose();
									}
								}
							}
							finally
							{
								if (num < 0 && _generator_5__5 != null)
								{
									((global::System.IDisposable)_generator_5__5).Dispose();
								}
							}
						}
						catch (jGf7FgBces5wPRuUuWo val)
						{
							jGf7FgBces5wPRuUuWo val2 = val;
							_service_5__2.R0mIvYEdQO("ui_verification_required", (global::System.Exception)(object)val2);
							if (qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
							{
								qrLoginPage._verificationUri = val2.VerificationUri;
								((UIElement)qrLoginPage.VerifyButton).Visibility = ((qrLoginPage._verificationUri == null) ? Visibility.Visible : Visibility.Collapsed);
								qrLoginPage.StatusText.Text = ((qrLoginPage._verificationUri == null) ? "网易要求安全验证（1351），但未提供可用验证地址" : "网易要求设备安全验证，请打开验证页面，完成后刷新二维码");
							}
						}
						catch (OperationCanceledException ex2)
						{
							OperationCanceledException ex3 = ex2;
							_service_5__2.R0mIvYEdQO("ui_cancelled_or_timeout", (global::System.Exception)(object)ex3);
							if (qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
							{
								qrLoginPage.StatusText.Text = "扫码等待已超时，请刷新二维码";
							}
						}
						catch (HttpRequestException ex4)
						{
							HttpRequestException ex5 = ex4;
							cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)ex5, "ui-exception", "StartLoginAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\QrLoginPage.xaml.cs", 172);
							_service_5__2.R0mIvYEdQO("ui_network_error", (global::System.Exception)(object)ex5);
							if (qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
							{
								qrLoginPage.StatusText.Text = "网络请求失败，请刷新二维码重试";
							}
						}
						catch (global::System.Exception ex6)
						{
							cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex6, "ui-exception", "StartLoginAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\QrLoginPage.xaml.cs", 178);
							_service_5__2.R0mIvYEdQO("ui_error", ex6);
							if (qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
							{
								qrLoginPage.StatusText.Text = ((ex6 is InvalidOperationException) ? ex6.Message : "扫码登录失败，请刷新二维码重试");
							}
						}
						finally
						{
							if (num < 0 && qrLoginPage._StartLoginAsync_g__IsCurrent_12_0(ref __8__1))
							{
								qrLoginPage._operation = null;
								qrLoginPage.LoadingRing.IsActive = false;
								((Control)qrLoginPage.RefreshButton).IsEnabled = true;
								qrLoginPage.QrImage.Source = null;
							}
						}
					}
					finally
					{
						if (num < 0 && _service_5__2 != null)
						{
							((global::System.IDisposable)_service_5__2).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && __8__1.operation != null)
					{
						((global::System.IDisposable)__8__1.operation).Dispose();
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				__8__1 = default(__c__DisplayClass12_0_3);
				_service_5__2 = null;
				_token_5__3 = default(CancellationToken);
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			__8__1 = default(__c__DisplayClass12_0_3);
			_service_5__2 = null;
			_token_5__3 = default(CancellationToken);
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
	private struct _VerifyButton_Click_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncVoidMethodBuilder __t__builder;

		public QrLoginPage __4__this;

		private Uri _uri_5__2;

		private TaskAwaiter<bool> __u__1;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			int num = __1__state;
			QrLoginPage qrLoginPage = __4__this;
			try
			{
				if (num == 0)
				{
					goto IL_0034;
				}
				_uri_5__2 = qrLoginPage._verificationUri;
				if (_uri_5__2 != null)
				{
					goto IL_0034;
				}
				goto end_IL_0011;
				IL_0034:
				try
				{
					TaskAwaiter<bool> _u__ = default;
					if (num != 0)
					{
						_u__ = WindowsRuntimeSystemExtensions.GetAwaiter<bool>(Launcher.LaunchUriAsync(_uri_5__2));
						if (!_u__.IsCompleted)
						{
							num = (__1__state = 0);
							__u__1 = _u__;
							__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _VerifyButton_Click_d__1>(ref _u__, ref this);
							return;
						}
					}
					else
					{
						_u__ = __u__1;
						__u__1 = default(TaskAwaiter<bool>);
						num = (__1__state = -1);
					}
					bool result = _u__.GetResult();
					if (qrLoginPage._active && !(qrLoginPage._verificationUri != _uri_5__2))
					{
						qrLoginPage.StatusText.Text = (result ? "请在网易页面完成安全验证，然后返回刷新二维码" : "无法打开安全验证页面，请检查默认浏览器后重试");
					}
				}
				catch (global::System.Exception)
				{
					if (qrLoginPage._active && qrLoginPage._verificationUri == _uri_5__2)
					{
						qrLoginPage.StatusText.Text = "安全验证页面打开失败，请重试";
					}
				}
				end_IL_0011:;
			}
			catch (global::System.Exception exception)
			{
				__1__state = -2;
				_uri_5__2 = null;
				__t__builder.SetException(exception);
				return;
			}
			__1__state = -2;
			_uri_5__2 = null;
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

	private CancellationTokenSource? _operation;

	private bool _active;

	private Uri? _verificationUri;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBox ResultBox;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button CopyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private TextBlock StatusText;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button VerifyButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Button RefreshButton;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private Image QrImage;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private ProgressRing LoadingRing;

	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	private bool _contentLoaded;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static async global::System.Threading.Tasks.Task<bool> SaveGeneratedAccountAsync(string sauthJson, zmDKtAITNJAAOKv0pRj service)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			JsonDocument val = JsonDocument.Parse(sauthJson, default(JsonDocumentOptions));
			try
			{
				JsonElement val2 = val.RootElement;
				val2 = val2.GetProperty("sauth_json");
				JsonDocument val3 = JsonDocument.Parse(val2.GetString() ?? throw new InvalidOperationException("扫码凭证内容为空"), default(JsonDocumentOptions));
				try
				{
					val2 = val3.RootElement;
					val2 = val2.GetProperty("sdkuid");
					string text = val2.GetString();
					if (string.IsNullOrWhiteSpace(text))
					{
						throw new InvalidOperationException("扫码凭证缺少账号 ID");
					}
					ONqw1ofP95psXgbRXRlF val4 = new ONqw1ofP95psXgbRXRlF
					{
						Account = text,
						Password = string.Empty,
						SauthJson = sauthJson,
						LoginMode = "qr"
					};
					service.R0mIvYEdQO("account_save_started", (global::System.Exception)null);
					await AppShell.Api.qZ20UTMODo(val4);
					service.R0mIvYEdQO("account_save_completed", (global::System.Exception)null);
					return true;
				}
				finally
				{
					((global::System.IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((global::System.IDisposable)val)?.Dispose();
			}
		}
		catch (global::System.Exception ex)
		{
			cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "ui-exception", "SaveGeneratedAccountAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Views\\Pages\\QrLoginPage.AccountHistory.cs", 37);
			service.R0mIvYEdQO("account_save_failed", ex);
			return false;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void VerifyButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_VerifyButton_Click_d__1 verifyButton_Click_d__ = default(_VerifyButton_Click_d__1);
		verifyButton_Click_d__.__t__builder = AsyncVoidMethodBuilder.Create();
		verifyButton_Click_d__.__4__this = this;
		verifyButton_Click_d__.__1__state = -1;
		verifyButton_Click_d__.__t__builder.Start<_VerifyButton_Click_d__1>(ref verifyButton_Click_d__);
	}

	[MethodImpl((MethodImplOptions)8)]
	public QrLoginPage()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		InitializeComponent();
		((FrameworkElement)this).Loaded += new RoutedEventHandler(OnLoaded);
		((FrameworkElement)this).Unloaded += new RoutedEventHandler(OnUnloaded);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void OnLoaded(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_OnLoaded_d__6_1 onLoaded_d__6_ = default(_OnLoaded_d__6_1);
		onLoaded_d__6_.__t__builder = AsyncVoidMethodBuilder.Create();
		onLoaded_d__6_.__4__this = this;
		onLoaded_d__6_.__1__state = -1;
		onLoaded_d__6_.__t__builder.Start<_OnLoaded_d__6_1>(ref onLoaded_d__6_);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnUnloaded(object sender, RoutedEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		_active = false;
		AppShell.SessionCleared -= new EventHandler(OnSessionCleared);
		CancelLogin();
		ClearResult();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void OnSessionCleared(object? sender, EventArgs e)
	{
		CancelLogin();
		ClearResult();
		StatusText.Text = "登录会话已清除";
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CancelLogin()
	{
		CancellationTokenSource? operation = _operation;
		_operation = null;
		if (operation != null)
		{
			operation.Cancel();
		}
		LoadingRing.IsActive = false;
		((Control)RefreshButton).IsEnabled = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void ClearResult()
	{
		_verificationUri = null;
		((UIElement)VerifyButton).Visibility = (Visibility)1;
		QrImage.Source = null;
		ResultBox.Text = string.Empty;
		((Control)CopyButton).IsEnabled = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private void RefreshButton_Click(object sender, RoutedEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_RefreshButton_Click_d__11_1 refreshButton_Click_d__11_ = default(_RefreshButton_Click_d__11_1);
		refreshButton_Click_d__11_.__t__builder = AsyncVoidMethodBuilder.Create();
		refreshButton_Click_d__11_.__4__this = this;
		refreshButton_Click_d__11_.__1__state = -1;
		refreshButton_Click_d__11_.__t__builder.Start<_RefreshButton_Click_d__11_1>(ref refreshButton_Click_d__11_);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task StartLoginAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		_StartLoginAsync_d__12 startLoginAsync_d__ = default(_StartLoginAsync_d__12);
		startLoginAsync_d__.__t__builder = AsyncTaskMethodBuilder.Create();
		startLoginAsync_d__.__4__this = this;
		startLoginAsync_d__.__1__state = -1;
		startLoginAsync_d__.__t__builder.Start<_StartLoginAsync_d__12>(ref startLoginAsync_d__);
		return startLoginAsync_d__.__t__builder.Task;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CopyButton_Click(object sender, RoutedEventArgs e)
	{
		if (string.IsNullOrWhiteSpace(ResultBox.Text))
		{
			return;
		}
		try
		{
			UiHelpers.CopyToClipboard(ResultBox.Text);
			AppShell.Success("SAuth 已复制");
		}
		catch (global::System.Exception)
		{
			AppShell.Error("复制失败，请重试");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void GoToAccountButton_Click(object sender, RoutedEventArgs e)
	{
		AppShell.Navigate(NavigationRegistry.MainPageType("bedrock_account"));
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
			Uri val = new Uri("ms-appx:///Views/Pages/QrLoginPage.xaml");
			Application.LoadComponent((object)this, val, (ComponentResourceLocation)0);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[DebuggerNonUserCode]
	[GeneratedCode("Microsoft.UI.Xaml.Markup.Compiler", " 3.0.0.2606")]
	public void Connect(int connectionId, object target)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		switch (connectionId)
		{
		case 2:
			ResultBox = CastExtensions.As<TextBox>(target);
			break;
		case 3:
			CopyButton = CastExtensions.As<Button>(target);
			((ButtonBase)CopyButton).Click += new RoutedEventHandler(CopyButton_Click);
			break;
		case 4:
			((ButtonBase)CastExtensions.As<Button>(target)).Click += new RoutedEventHandler(GoToAccountButton_Click);
			break;
		case 5:
			StatusText = CastExtensions.As<TextBlock>(target);
			break;
		case 6:
			VerifyButton = CastExtensions.As<Button>(target);
			((ButtonBase)VerifyButton).Click += new RoutedEventHandler(VerifyButton_Click);
			break;
		case 7:
			RefreshButton = CastExtensions.As<Button>(target);
			((ButtonBase)RefreshButton).Click += new RoutedEventHandler(RefreshButton_Click);
			break;
		case 8:
			QrImage = CastExtensions.As<Image>(target);
			break;
		case 9:
			LoadingRing = CastExtensions.As<ProgressRing>(target);
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
	private bool _StartLoginAsync_g__IsCurrent_12_0(ref __c__DisplayClass12_0_3 P_0)
	{
		if (_active)
		{
			return _operation == P_0.operation;
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

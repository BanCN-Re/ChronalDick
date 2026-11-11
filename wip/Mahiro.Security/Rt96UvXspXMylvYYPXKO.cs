using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using R7Y8jtXsqnv0hePFTc0q;
using fDAldojjppXrctUVYOJn;

namespace obIWGCXsuWbuISNsekUL;

internal class Rt96UvXspXMylvYYPXKO
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<int> __t__builder;

		public CancellationToken cancellationToken;

		public Stream input;

		public global::System.Memory<byte> buffer;

		private CancellationTokenSource _timeout_5__2;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1;

		internal static object tGWojjDXOmNrY2X3tAbL;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_055d: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0406: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0688->IL0657: Incompatible stack heights: 0 vs 2
			//IL_065b->IL065b: Incompatible stack heights: 3 vs 1
			//IL_00a0->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00ab->IL0010: Incompatible stack heights: 3 vs 1
			//IL_036f->IL026a: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			int num18 = default;
			int num15 = default;
			global::System.Threading.Tasks.ValueTask<int> valueTask = default;
			int num9 = default;
			ConfiguredValueTaskAwaitable<int> _u__ = default;
			ConfiguredValueTaskAwaitable<int> val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
			OperationCanceledException ex = default;
			int num12 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num14 = default;
			int num17 = default;
			int num21 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 3:
							goto end_IL_000c;
						case 2:
							_ = __t__builder;
							_ = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								_ = 4;
							}
							continue;
						case 1:
							num4 = __1__state;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 2;
									goto IL_00f6;
								}
								goto IL_011e;
								IL_011e:
								_timeout_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
								{
									num5 = 3;
								}
								goto IL_00f6;
								IL_00f6:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num18 == 991)
										{
											num5 = num18;
											continue;
										}
										goto case 0;
									case 1:
										break;
									case 0:
									case 2:
										num5 = 3;
										continue;
									case 3:
										try
										{
											int num6;
											if (num4 == 0)
											{
												num6 = 2;
												goto IL_01a6;
											}
											goto IL_01ce;
											IL_01ce:
											(_timeout_5__2).CancelAfter(W15XsE3AvW4);
											num6 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
											{
												num6 = 5;
											}
											goto IL_01a6;
											IL_01a6:
											while (true)
											{
												switch (num6)
												{
												default:
													if (num15 == 991)
													{
														num6 = num15;
														continue;
													}
													break;
												case 3:
													break;
												case 1:
												case 2:
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
													{
														num6 = 6;
													}
													continue;
												case 0:
													try
													{
														int num7;
														if (num4 == 0)
														{
															num7 = 13;
															goto IL_026a;
														}
														goto IL_0319;
														IL_0319:
														valueTask = (input).ReadAsync(buffer, (_timeout_5__2).Token);
														num7 = 11;
														goto IL_026a;
														IL_026a:
														while (true)
														{
															int num10;
															switch (num7)
															{
															default:
																if (num9 == 21)
																{
																	return;
																}
																if (num9 == 1001)
																{
																	goto IL_0266;
																}
																goto case 10;
															case 1:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter, _ReadAsync_d__4>(ref _u__, ref this);
																num10 = 13;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
																{
																	num10 = 21;
																}
																goto IL_0262;
															case 7:
																break;
															case 9:
																num4 = (__1__state = -1);
																num7 = 12;
																continue;
															case 11:
																_ = valueTask;
																val = (ConfiguredValueTaskAwaitable<int>)0;
																_ = 8;
																continue;
															case 6:
																num4 = (__1__state = 0);
																num10 = 5;
																goto IL_0262;
															case 2:
																if (&_u__ != null)
																{
																	num7 = 20;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																	{
																		num7 = 0;
																	}
																	continue;
																}
																goto case 6;
															case 5:
																__u__1 = _u__;
																num7 = 12;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
																{
																	num7 = 1;
																}
																continue;
															case 8:
																_u__ = val;
																num7 = 2;
																continue;
															case 10:
																__u__1 = default;
																num10 = 9;
																goto IL_0262;
															case 4:
															case 13:
																_u__ = __u__1;
																num7 = 10;
																continue;
															case 0:
															case 12:
															{
																int num8 = (int)(&_u__);
																num7 = 3;
																continue;
															}
															case 3:
																goto end_IL_026a;
																IL_0266:
																num7 = num9;
																continue;
																IL_0262:
																num9 = num10;
																goto IL_0266;
															}
															goto IL_0319;
															continue;
															end_IL_026a:
															break;
														}
													}
													catch (object obj) when (((Func<bool>)delegate
													{
														// Could not convert BlockContainer to single expression
														obj2 = ((obj is OperationCanceledException) ? obj : null);
														if (obj2 == null)
														{
															num11 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
															{
																num11 = 6;
															}
														}
														else
														{
															ex = (OperationCanceledException)obj2;
															num11 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
															{
																num11 = 0;
															}
														}
														while (true)
														{
															switch (num11)
															{
															default:
																if (num12 == 989)
																{
																	goto IL_0488;
																}
																goto case 0;
															case 1:
																result = 0;
																break;
															case 0:
																result = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
																break;
															}
															break;
															IL_0488:
															num11 = num12;
														}
														return (byte)result != 0;
													}).Invoke())
													{
														int num13 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
														{
															num13 = 3;
														}
														while (true)
														{
															switch (num13)
															{
															default:
																if (num14 == 988)
																{
																	goto IL_0519;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_0519:
															num13 = num14;
														}
														_ = "下载连接超过 45 秒没有收到数据";
														throw ex;
													}
													catch (IOException ex2)
													{
														throw new bgVUiEXs2b9LGUBkyXlk(ex2);
													}
													goto end_IL_01a6;
												}
												goto IL_01ce;
												continue;
												end_IL_01a6:
												break;
											}
										}
										finally
										{
											if (num4 < 0)
											{
												int num16 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
												{
													num16 = 2;
												}
												while (true)
												{
													switch (num16)
													{
													default:
														if (num17 == 991)
														{
															num16 = num17;
															continue;
														}
														goto case 2;
													case 2:
														if (_timeout_5__2 == null)
														{
															num16 = 7;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
															{
																num16 = 0;
															}
															continue;
														}
														break;
													case 3:
														break;
													case 0:
														goto end_IL_0597;
													case 1:
														goto end_IL_0597;
													}
													(_timeout_5__2).Dispose();
													num16 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
													{
														num16 = 8;
													}
													continue;
													end_IL_0597:
													break;
												}
											}
										}
										goto end_IL_00f6;
									}
									goto IL_011e;
									continue;
									end_IL_00f6:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num19 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
								{
									num19 = 0;
								}
								while (true)
								{
									switch (num19)
									{
									default:
										switch (num21)
										{
										case 10:
											return;
										case 990:
											goto end_IL_065b;
										}
										goto case 0;
									case 0:
										__1__state = -2;
										num19 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num19 = 1;
										}
										break;
									case 1:
										_timeout_5__2 = null;
										num19 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
										{
											num19 = 2;
										}
										break;
									case 2:
										{
											_ = __t__builder;
											int num20 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
											{
												num20 = 1;
											}
											num21 = num20;
											break;
										}
										end_IL_065b:
										break;
									}
								}
							}
							goto end_IL_000c;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							_timeout_5__2 = null;
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				__1__state = -2;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						case 2:
							return;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TUoYZ0DX5NvBRL07lKCu()
		{
			return tGWojjDXOmNrY2X3tAbL == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Hj5u92DX6MA8nufktCKK()
		{
			return tGWojjDXOmNrY2X3tAbL;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder;

		public CancellationToken cancellationToken;

		public HttpClient http;

		public HttpRequestMessage request;

		private CancellationTokenSource _timeout_5__2;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		internal static object mkEoOaDXRqhR2GWNNhhk;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_036f: Expected O, but got Ref
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676->IL060b: Incompatible stack heights: 3 vs 1
			//IL_008e->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0099->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0343->IL026e: Incompatible stack heights: 2 vs 1
			int num = 3;
			int num4 = default;
			int num17 = default;
			int num14 = default;
			int num9 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
			OperationCanceledException ex = default;
			int num11 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num13 = default;
			int num16 = default;
			int num20 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 4;
							}
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 3;
									goto IL_00d0;
								}
								goto IL_013c;
								IL_013c:
								_timeout_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
								{
									num5 = 2;
								}
								goto IL_00d0;
								IL_00d0:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num17 == 991)
										{
											num5 = num17;
											continue;
										}
										goto case 2;
									case 2:
									case 3:
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
										{
											num5 = 1;
										}
										continue;
									case 0:
										break;
									case 1:
										try
										{
											int num6;
											if (num4 == 0)
											{
												num6 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
												{
													num6 = 0;
												}
												goto IL_01aa;
											}
											goto IL_0201;
											IL_01aa:
											while (true)
											{
												switch (num6)
												{
												default:
													if (num14 == 991)
													{
														num6 = num14;
														continue;
													}
													goto case 0;
												case 0:
												case 2:
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
													{
														num6 = 6;
													}
													continue;
												case 3:
													break;
												case 1:
													try
													{
														int num7;
														if (num4 != 0)
														{
															num7 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
															{
																num7 = 4;
															}
															goto IL_026e;
														}
														goto IL_0379;
														IL_026e:
														while (true)
														{
															int num8;
															switch (num7)
															{
															default:
																if (num9 == 18)
																{
																	return;
																}
																if (num9 != 998)
																{
																	break;
																}
																goto IL_026a;
															case 8:
																_u__ = val;
																num8 = 2;
																goto IL_0266;
															case 3:
																num4 = (__1__state = -1);
																num7 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
																{
																	num7 = 14;
																}
																continue;
															case 5:
																__u__1 = default;
																num7 = 3;
																continue;
															case 4:
																(http).SendAsync(request, (HttpCompletionOption)1, (_timeout_5__2).Token);
																val = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																_ = 8;
																continue;
															case 2:
																if (&_u__ == null)
																{
																	num7 = 10;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
																	{
																		num7 = 1;
																	}
																	continue;
																}
																goto case 0;
															case 0:
															{
																HttpResponseMessage val2 = (HttpResponseMessage)(object)(&_u__);
																num7 = 6;
																continue;
															}
															case 7:
																break;
															case 1:
																num4 = (__1__state = 0);
																num7 = 10;
																continue;
															case 10:
																__u__1 = _u__;
																num7 = 8;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																{
																	num7 = 9;
																}
																continue;
															case 9:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _SendAsync_d__3>(ref _u__, ref this);
																num8 = 18;
																goto IL_0266;
															case 6:
																goto end_IL_026e;
																IL_0266:
																num9 = num8;
																goto IL_026a;
																IL_026a:
																num7 = num9;
																continue;
															}
															goto IL_0379;
															continue;
															end_IL_026e:
															break;
														}
														goto end_IL_0236;
														IL_0379:
														_u__ = __u__1;
														num7 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
														{
															num7 = 5;
														}
														goto IL_026e;
														end_IL_0236:;
													}
													catch (object obj) when (((Func<bool>)delegate
													{
														// Could not convert BlockContainer to single expression
														obj2 = ((obj is OperationCanceledException) ? obj : null);
														if (obj2 == null)
														{
															num10 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
															{
																num10 = 0;
															}
														}
														else
														{
															ex = (OperationCanceledException)obj2;
															num10 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
															{
																num10 = 3;
															}
														}
														while (true)
														{
															switch (num10)
															{
															default:
																if (num11 == 989)
																{
																	goto IL_0440;
																}
																goto case 1;
															case 0:
																result = 0;
																break;
															case 1:
																result = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
																break;
															}
															break;
															IL_0440:
															num10 = num11;
														}
														return (byte)result != 0;
													}).Invoke())
													{
														int num12 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
														{
															num12 = 0;
														}
														while (true)
														{
															switch (num12)
															{
															default:
																if (num13 == 988)
																{
																	goto IL_04d1;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_04d1:
															num12 = num13;
														}
														_ = "下载连接超过 45 秒没有返回响应";
														throw ex;
													}
													goto end_IL_01aa;
												}
												goto IL_0201;
												continue;
												end_IL_01aa:
												break;
											}
											goto end_IL_0172;
											IL_0201:
											(_timeout_5__2).CancelAfter(W15XsE3AvW4);
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
											{
												num6 = 2;
											}
											goto IL_01aa;
											end_IL_0172:;
										}
										finally
										{
											int num15;
											if (num4 >= 0)
											{
												num15 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
												{
													num15 = 7;
												}
												goto IL_0549;
											}
											goto IL_0584;
											IL_05ae:
											(_timeout_5__2).Dispose();
											num15 = 3;
											goto IL_0549;
											IL_0584:
											if (_timeout_5__2 == null)
											{
												num15 = 8;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
												{
													num15 = 1;
												}
												goto IL_0549;
											}
											goto IL_05ae;
											IL_0549:
											while (true)
											{
												switch (num15)
												{
												default:
													if (num16 == 992)
													{
														num15 = num16;
														continue;
													}
													goto IL_0584;
												case 0:
													break;
												case 4:
													goto IL_0584;
												case 2:
													goto IL_05ae;
												case 1:
													break;
												case 3:
													break;
												}
												break;
											}
										}
										goto end_IL_00d0;
									}
									goto IL_013c;
									continue;
									end_IL_00d0:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num18 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
								{
									num18 = 1;
								}
								while (true)
								{
									switch (num18)
									{
									case 2:
										return;
									default:
										if (num20 != 10)
										{
											if (num20 != 990)
											{
												break;
											}
											goto IL_0607;
										}
										_timeout_5__2 = null;
										num18 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
										{
											num18 = 0;
										}
										continue;
									case 0:
										break;
									case 1:
										{
											__1__state = -2;
											int num19 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
											{
												num19 = 10;
											}
											num20 = num19;
											goto IL_0607;
										}
										IL_0607:
										num18 = num20;
										continue;
									}
									_ = __t__builder;
									_ = 2;
								}
							}
							goto case 0;
						case 0:
							__1__state = -2;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							_ = __t__builder;
							_ = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							break;
						case 2:
							return;
						case 1:
							_timeout_5__2 = null;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num4 = __1__state;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			do
			{
				while (true)
				{
					switch (num)
					{
					case 1:
						_ = __t__builder;
						_ = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							_ = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 2;
							}
							return;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							break;
						case 1:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
				{
					num = 2;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool hrcHT7DXwPIOKDnfA8jo()
		{
			return mkEoOaDXRqhR2GWNNhhk == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object nYR7dBDXeKNRGnDUaxlT()
		{
			return mkEoOaDXRqhR2GWNNhhk;
		}
	}

	private static TimeSpan W15XsE3AvW4;

	internal static object iRfotbZRzLIWp4lnBBcJ;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IXYXsay4dIV(object error)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TimeSpan AKXXs1SVe8e(int attempt)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return System.TimeSpan.FromSeconds(1 << System.Math.Clamp(attempt - 1, 0, 3));
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<HttpResponseMessage> QiDXs3oxy7W(object http, object request, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<int> JHCXsvb4GO3(object input, global::System.Memory<byte> buffer, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						switch (num2)
						{
						case 992:
							break;
						case 11:
							goto IL_004c;
						default:
							goto end_IL_000e;
						}
						break;
					case 2:
						W15XsE3AvW4 = System.TimeSpan.FromSeconds(45.0);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num3 = 11;
						}
						continue;
					case 3:
						return;
					case 0:
						goto end_IL_000e;
						IL_004c:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 4;
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SD6a83ZwbZjCYWVQqlGF()
	{
		return iRfotbZRzLIWp4lnBBcJ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Rt96UvXspXMylvYYPXKO fXGYQgZwXEv9Eo6K8sw0()
	{
		return (Rt96UvXspXMylvYYPXKO)iRfotbZRzLIWp4lnBBcJ;
	}
}

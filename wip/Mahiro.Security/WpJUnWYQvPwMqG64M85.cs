using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using AWAwFNkh6yEOmYofsXA;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PU90ECViU55JrPWL7iB;
using TMq6qlVkgbYPkRTR0JI;
using fDAldojjppXrctUVYOJn;
using jPoJV4kyjtZrwHRgWE6;

namespace VOmN2IYCjZ9IabYMj9A;

sealed class WpJUnWYQvPwMqG64M85 : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AuthenticateAsync_d__11_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<hb785wVGMcElWyHPFnE> __t__builder;

		public WpJUnWYQvPwMqG64M85 __4__this;

		public CancellationToken cancellationToken;

		public string serverHash;

		private CancellationTokenSource _linked_5__2;

		private object __u__1;

		internal static object q5jTP190pepJiZifyB8h;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0600: Unknown result type (might be due to invalid IL or missing references)
			//IL_0522: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0482: Unknown result type (might be due to invalid IL or missing references)
			//IL_056a: Unknown result type (might be due to invalid IL or missing references)
			//IL_056f: Unknown result type (might be due to invalid IL or missing references)
			//IL_054f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0999->IL0968: Incompatible stack heights: 0 vs 2
			//IL_096c->IL096c: Incompatible stack heights: 3 vs 1
			//IL_006b->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0076->IL0008: Incompatible stack heights: 3 vs 1
			WpJUnWYQvPwMqG64M85 wpJUnWYQvPwMqG64M = default;
			int num3 = default;
			int num5 = default;
			int num17 = default;
			object _u__ = default;
			ConfiguredTaskAwaitable val = default;
			CancellationToken val2 = default;
			int num10 = default;
			int num12 = default;
			int num14 = default;
			int num16 = default;
			int num19 = default;
			int num21 = default;
			while (true)
			{
				int num = 5;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 12)
							{
								if (num == 993)
								{
									goto end_IL_0010;
								}
								goto case 4;
							}
							return;
						case 0:
							break;
						case 4:
							wpJUnWYQvPwMqG64M = __4__this;
							num2 = 2;
							continue;
						case 1:
							__1__state = -2;
							num2 = 3;
							continue;
						case 3:
							_linked_5__2 = null;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num2 = 1;
							}
							continue;
						case 2:
							try
							{
								int num4;
								if (num3 != 0)
								{
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
									{
										num4 = 9;
									}
									goto IL_00f9;
								}
								goto IL_0234;
								IL_00f9:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 != 16)
										{
											if (num5 == 996)
											{
												goto IL_00f5;
											}
											goto case 0;
										}
										goto end_IL_00f9;
									case 7:
									{
										hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_not_found", "认证中继会话不存在或已经释放");
										num4 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
										{
											num4 = 1;
										}
										continue;
									}
									case 1:
										goto end_IL_00f9;
									case 3:
										_linked_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, (wpJUnWYQvPwMqG64M.SL7Yhhk4lK).Token);
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
										{
											num4 = 14;
										}
										continue;
									case 4:
									case 8:
										if (System.Threading.Interlocked.CompareExchange(wpJUnWYQvPwMqG64M.mc3YULSkPD, 1, 0) != 0)
										{
											num4 = 2;
											continue;
										}
										goto case 3;
									case 5:
										break;
									case 2:
									{
										hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_replayed", "认证中继句柄已经消费，请重新准备");
										int num6 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
										{
											num6 = 3;
										}
										num5 = num6;
										goto IL_00f5;
									}
									case 6:
										if (System.Threading.Volatile.Read(wpJUnWYQvPwMqG64M.YbpYrP0B8o) == 0)
										{
											num4 = 8;
											continue;
										}
										goto case 7;
									case 0:
										{
											try
											{
												int num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
												{
													num7 = 4;
												}
												while (true)
												{
													switch (num7)
													{
													default:
														if (num17 == 989)
														{
															num7 = num17;
															continue;
														}
														goto case 0;
													case 0:
														num7 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
														{
															num7 = 1;
														}
														continue;
													case 1:
														try
														{
															int num8;
															if (num3 != 0)
															{
																num8 = 17;
																goto IL_0375;
															}
															goto IL_05eb;
															IL_05eb:
															_u__ = __u__1;
															int num9 = 25;
															goto IL_036d;
															IL_0375:
															hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE;
															while (true)
															{
																switch (num8)
																{
																case 7:
																	return;
																case 8:
																	hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.KkCVzGoPsc("auth_relay_authenticated", "认证中继请求已完成", "", 0L);
																	num8 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
																	{
																		num8 = 10;
																	}
																	continue;
																case 6:
																case 9:
																	val = (((TkpMidk8h3eg3a0fcjs)wpJUnWYQvPwMqG64M.b29Y4oHULZ).AuthenticateAsync(serverHash, (_linked_5__2).Token)).ConfigureAwait(false);
																	num8 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
																	{
																		num8 = 1;
																	}
																	continue;
																case 2:
																	goto end_IL_0375;
																case 5:
																	goto IL_04eb;
																case 13:
																	if (System.Threading.Volatile.Read(wpJUnWYQvPwMqG64M.YbpYrP0B8o) == 0)
																	{
																		num8 = 6;
																		continue;
																	}
																	goto end_IL_0375;
																case 4:
																	__u__1 = _u__;
																	num8 = 14;
																	continue;
																case 12:
																	goto IL_0533;
																case 17:
																	val2 = (_linked_5__2).Token;
																	num8 = 5;
																	continue;
																case 15:
																	num3 = (__1__state = -1);
																	num8 = 12;
																	continue;
																case 0:
																	num3 = (__1__state = 0);
																	num8 = 14;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
																	{
																		num8 = 4;
																	}
																	continue;
																case 11:
																	goto end_IL_0352;
																case 3:
																	goto IL_05eb;
																case 1:
																	_u__ = val;
																	num8 = 16;
																	continue;
																case 16:
																	goto IL_060c;
																case 14:
																	__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__11_1>(ref _u__, ref this);
																	num8 = 23;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
																	{
																		num8 = 7;
																	}
																	continue;
																case 10:
																	goto end_IL_0352;
																}
																if (num10 != 25)
																{
																	if (num10 == 1005)
																	{
																		goto IL_0371;
																	}
																	goto IL_060c;
																}
																__u__1 = default;
																num8 = 15;
																continue;
																IL_060c:
																if (!(_u__).IsCompleted)
																{
																	num8 = 10;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
																	{
																		num8 = 0;
																	}
																	continue;
																}
																goto IL_0533;
																IL_0533:
																(_u__).GetResult();
																num8 = 8;
																continue;
																end_IL_0375:
																break;
															}
															hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_not_found", "认证中继会话不存在或已经释放");
															num9 = 11;
															goto IL_036d;
															IL_036d:
															num10 = num9;
															goto IL_0371;
															IL_0371:
															num8 = num10;
															goto IL_0375;
															IL_04eb:
															(val2).ThrowIfCancellationRequested();
															num9 = 13;
															goto IL_036d;
															end_IL_0352:;
														}
														catch (OperationCanceledException)
														{
															int num11 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
															{
																num11 = 2;
															}
															while (true)
															{
																switch (num11)
																{
																default:
																	if (num12 == 989)
																	{
																		num11 = num12;
																		continue;
																	}
																	break;
																case 1:
																{
																	hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_canceled", "认证中继请求已取消");
																	num11 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
																	{
																		num11 = 5;
																	}
																	continue;
																}
																case 0:
																	break;
																}
																break;
															}
														}
														catch (AJ6x61VDYw2THcvPjVa)
														{
															int num13 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
															{
																num13 = 7;
															}
															while (true)
															{
																switch (num13)
																{
																default:
																	if (num14 == 989)
																	{
																		num13 = num14;
																		continue;
																	}
																	break;
																case 1:
																	break;
																case 0:
																	goto end_IL_0753;
																}
																hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_control_rejected", "认证组件拒绝了本次请求");
																num13 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
																{
																	num13 = 0;
																}
																continue;
																end_IL_0753:
																break;
															}
														}
														catch (global::System.Exception)
														{
															int num15 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
															{
																num15 = 3;
															}
															while (true)
															{
																switch (num15)
																{
																default:
																	if (num16 == 989)
																	{
																		num15 = num16;
																		continue;
																	}
																	break;
																case 1:
																	break;
																case 0:
																	goto end_IL_0812;
																}
																hb785wVGMcElWyHPFnE hb785wVGMcElWyHPFnE = hb785wVGMcElWyHPFnE.vpVVnXNnIC("auth_relay_adapter_failed", "认证中继适配器认证失败");
																num15 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
																{
																	num15 = 0;
																}
																continue;
																end_IL_0812:
																break;
															}
														}
														break;
													}
													break;
												}
											}
											finally
											{
												int num18;
												if (num3 >= 0)
												{
													num18 = 9;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
													{
														num18 = 1;
													}
													goto IL_08d2;
												}
												goto IL_0923;
												IL_08d2:
												while (true)
												{
													switch (num18)
													{
													default:
														if (num19 == 991)
														{
															goto IL_08ce;
														}
														goto end_IL_08d2;
													case 0:
														(_linked_5__2).Dispose();
														num19 = 3;
														goto IL_08ce;
													case 1:
														goto end_IL_08d2;
													case 2:
														break;
													case 3:
														goto end_IL_08d2;
													}
													goto IL_0923;
													IL_08ce:
													num18 = num19;
													continue;
													end_IL_08d2:
													break;
												}
												goto end_IL_0899;
												IL_0923:
												if (_linked_5__2 != null)
												{
													num18 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
													{
														num18 = 1;
													}
													goto IL_08d2;
												}
												end_IL_0899:;
											}
											goto end_IL_00f9;
										}
										IL_00f5:
										num4 = num5;
										continue;
									}
									goto IL_0234;
									continue;
									end_IL_00f9:
									break;
								}
								goto end_IL_00c1;
								IL_0234:
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
								{
									num4 = 0;
								}
								goto IL_00f9;
								end_IL_00c1:;
							}
							catch (global::System.Exception)
							{
								int num20 = 2;
								while (true)
								{
									switch (num20)
									{
									default:
										switch (num21)
										{
										case 990:
											continue;
										case 10:
											return;
										}
										break;
									case 2:
										__1__state = -2;
										num20 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
										{
											num20 = 1;
										}
										continue;
									case 0:
										_ = __t__builder;
										num21 = 10;
										continue;
									case 1:
										break;
									}
									_linked_5__2 = null;
									num20 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
									{
										num20 = 0;
									}
								}
							}
							goto case 1;
						case 5:
							num3 = __1__state;
							num2 = 4;
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
				_ = __t__builder;
				_ = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
				{
					_ = 12;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_ = __t__builder;
					_ = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
					{
						_ = 0;
					}
				}
			}
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
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							break;
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
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool bMbYFo90uk2FA32lUmk0()
		{
			return q5jTP190pepJiZifyB8h == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object LKPtaN90aHeP1bGZgksQ()
		{
			return q5jTP190pepJiZifyB8h;
		}
	}

	private readonly object b29Y4oHULZ;

	private readonly object SL7Yhhk4lK;

	private int mc3YULSkPD;

	private int YbpYrP0B8o;

	[CompilerGenerated]
	private readonly Rw2xvdk4yUIbmFhBjx8 hJxYo0vvqn;

	[CompilerGenerated]
	private readonly global::System.DateTime FVOYmWl4VZ;

	internal static object s3IWngZYf3mfUjyAJfFq;

	internal Rw2xvdk4yUIbmFhBjx8 Binding
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return hJxYo0vvqn;
		}
	}

	internal global::System.DateTime ExpiresAtUtc
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return FVOYmWl4VZ;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal WpJUnWYQvPwMqG64M85(Rw2xvdk4yUIbmFhBjx8 binding, TkpMidk8h3eg3a0fcjs session, global::System.DateTime expiresAtUtc)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<hb785wVGMcElWyHPFnE> AuthenticateAsync(string serverHash, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.serverHash = serverHash;
		_ = 4;
		obj.__4__this = this;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1;
		_ = 4;
		_ = obj;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0155: Expected I4, but got O
		//IL_008e: Expected I4, but got O
		//IL_013a->IL014c: Incompatible stack types: I4 vs O
		//IL_0197->IL0010: Incompatible stack types: I4 vs O
		//IL_0145->IL014c: Incompatible stack types: I4 vs O
		//IL_010a->IL0010: Incompatible stack types: I4 vs O
		//IL_01a2->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0085: Incompatible stack types: I4 vs O
		//IL_0115->IL0010: Incompatible stack types: I4 vs O
		//IL_007e->IL0085: Incompatible stack types: I4 vs O
		int num = 3;
		object obj6 = default;
		object obj4 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
					{
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						(SL7Yhhk4lK).Cancel();
						object obj5 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							obj5 = 0;
						}
						while (true)
						{
							switch ((int)obj5)
							{
							default:
								if ((nint)obj6 == 988)
								{
									goto IL_0081;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0081:
							obj5 = obj6;
						}
						goto case 5;
					}
					case 1:
						return;
					case 2:
						break;
					case 3:
						if (System.Threading.Interlocked.Exchange(ref YbpYrP0B8o, 1) != 0)
						{
							return;
						}
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
						{
							obj2 = 6;
						}
						continue;
					case 0:
					{
						(b29Y4oHULZ).Dispose();
						object obj3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
						{
							obj3 = 1;
						}
						while (true)
						{
							switch ((int)obj3)
							{
							case 0:
								return;
							}
							if ((nint)obj4 == 988)
							{
								obj3 = obj4;
								continue;
							}
							return;
						}
					}
					case 4:
						return;
					case 5:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							obj2 = 12;
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
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0091->IL0012: Incompatible stack types: I4 vs O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		//IL_0053->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							obj2 = 2;
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				if ((nint)obj != 990)
				{
					return;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool eUIKn0ZYLo1sp9n3VmLq()
	{
		return s3IWngZYf3mfUjyAJfFq == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static WpJUnWYQvPwMqG64M85 JVCfjkZYjXqYYmcwVW63()
	{
		return (WpJUnWYQvPwMqG64M85)s3IWngZYf3mfUjyAJfFq;
	}
}

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using GWTRrnfpaWE7CGUVCeZU;
using MkadWUXSSw3YLfjcsdnF;
using N7C2oTfTSOw34Jog3k20;
using OjRDRnXktG0jdQCvW1ed;
using QTDL5wXBTqLlG2y5F5Yn;
using fDAldojjppXrctUVYOJn;
using fJfNTB3p5nRiIJsrptO;

namespace c0tL76XYveVO4HtQTHx2;

sealed class oWfn25XY3YCC7mkGihcI : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RestoreRemoteStateAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<global::System.Exception> __t__builder;

		public GE50SffsnGnn7g3lMZHE replacementSession;

		public GE50SffsnGnn7g3lMZHE previousSession;

		public oWfn25XY3YCC7mkGihcI __4__this;

		public bool previousStopAttempted;

		private object __u__1;

		private CancellationTokenSource _timeout_5__2;

		private static object n4i3Vc9xC3fM9PckBxdp;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0252: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Expected O, but got Unknown
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745->IL070e: Incompatible stack heights: 3 vs 1
			//IL_07ad->IL0008: Incompatible stack heights: 3 vs 1
			//IL_07b8->IL0008: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num4 = default;
			object _u__ = default;
			ConfiguredTaskAwaitable val = default;
			oWfn25XY3YCC7mkGihcI oWfn25XY3YCC7mkGihcI2 = default;
			int num7 = default;
			int num10 = default;
			int num13 = default;
			int num15 = default;
			int num16 = default;
			int num18 = default;
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
								goto case 2;
							}
							return;
						case 0:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 3;
									goto IL_006e;
								}
								goto IL_01d6;
								IL_0198:
								int num6 = 5;
								goto IL_0066;
								IL_006e:
								while (true)
								{
									switch (num5)
									{
									case 13:
										_u__ = val;
										num5 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											num5 = 0;
										}
										continue;
									case 3:
									case 4:
										goto end_IL_006e;
									case 18:
										if ((object)replacementSession != null)
										{
											num5 = 11;
											continue;
										}
										goto case 15;
									case 0:
										if ((_u__).IsCompleted)
										{
											goto IL_0179;
										}
										goto case 8;
									case 15:
										if (!previousStopAttempted)
										{
											num5 = 7;
											continue;
										}
										goto IL_0198;
									case 9:
										goto IL_0198;
									case 17:
										val = (oWfn25XY3YCC7mkGihcI2.M4hXYqTqvk4(replacementSession)).ConfigureAwait(false);
										num5 = 13;
										continue;
									case 6:
										return;
									case 2:
										goto IL_01d6;
									case 14:
									case 19:
										(_u__).GetResult();
										num5 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
										{
											num5 = 20;
										}
										continue;
									case 11:
										if (!OUJXYGflqqc(previousSession, replacementSession))
										{
											num5 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
											{
												num5 = 11;
											}
											continue;
										}
										goto case 15;
									case 16:
										__t__builder.AwaitUnsafeOnCompleted<object, _RestoreRemoteStateAsync_d__12>(ref _u__, ref this);
										num5 = 6;
										continue;
									case 1:
										goto IL_02af;
									case 10:
										goto end_IL_004b;
									case 8:
										num4 = (__1__state = 0);
										num5 = 12;
										continue;
									case 7:
									{
										global::System.Exception ex = null;
										num5 = 10;
										continue;
									}
									case 12:
										__u__1 = _u__;
										num5 = 16;
										continue;
									case 5:
										try
										{
											if (num4 != 1)
											{
												num7 = 2;
												goto IL_033b;
											}
											goto IL_0363;
											IL_0363:
											int num8 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
											{
												num8 = 4;
											}
											goto IL_033f;
											IL_033b:
											num8 = num7;
											goto IL_033f;
											IL_033f:
											while (true)
											{
												switch (num8)
												{
												case 0:
													goto IL_0363;
												case 2:
													_timeout_5__2 = (CancellationTokenSource)sa6XSbPy1xP;
													num8 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
													{
														num8 = 0;
													}
													continue;
												case 1:
													try
													{
														int num9;
														if (num4 != 1)
														{
															num9 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
															{
																num9 = 10;
															}
															goto IL_03e8;
														}
														goto IL_0591;
														IL_03e8:
														while (true)
														{
															int num11;
															switch (num9)
															{
															default:
																if (num10 != 19)
																{
																	if (num10 == 999)
																	{
																		goto IL_03e4;
																	}
																	goto case 7;
																}
																num4 = (__1__state = -1);
																num9 = 4;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
																{
																	num9 = 11;
																}
																continue;
															case 3:
																_u__ = val;
																num9 = 4;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																{
																	num9 = 0;
																}
																continue;
															case 0:
																if (!(_u__).IsCompleted)
																{
																	num9 = 6;
																	continue;
																}
																goto case 11;
															case 1:
																return;
															case 7:
																__t__builder.AwaitUnsafeOnCompleted<object, _RestoreRemoteStateAsync_d__12>(ref _u__, ref this);
																num9 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																{
																	num9 = 13;
																}
																continue;
															case 10:
																val = (((HHvjbWXSYZt2S7V2ZJQE)oWfn25XY3YCC7mkGihcI2.Lx4XSXsLeEj).vpbL4Ih9foF(previousSession, (_timeout_5__2).Token)).ConfigureAwait(false);
																num11 = 3;
																goto IL_03e0;
															case 2:
																__u__1 = default;
																num11 = 19;
																goto IL_03e0;
															case 6:
																num4 = (__1__state = 1);
																num9 = 16;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
																{
																	num9 = 9;
																}
																continue;
															case 5:
															{
																global::System.Exception ex = null;
																num9 = 8;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
																{
																	num9 = 1;
																}
																continue;
															}
															case 4:
																break;
															case 11:
																(_u__).GetResult();
																num9 = 5;
																continue;
															case 9:
																__u__1 = _u__;
																num9 = 19;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
																{
																	num9 = 7;
																}
																continue;
															case 8:
																goto end_IL_03e8;
																IL_03e0:
																num10 = num11;
																goto IL_03e4;
																IL_03e4:
																num9 = num10;
																continue;
															}
															goto IL_0591;
															continue;
															end_IL_03e8:
															break;
														}
														goto end_IL_03af;
														IL_0591:
														_u__ = __u__1;
														num9 = 2;
														goto IL_03e8;
														end_IL_03af:;
													}
													finally
													{
														if (num4 < 0)
														{
															int num12 = 8;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
															{
																num12 = 0;
															}
															while (true)
															{
																switch (num12)
																{
																default:
																	if (num13 == 990)
																	{
																		num12 = num13;
																		continue;
																	}
																	goto case 2;
																case 2:
																	(_timeout_5__2).Dispose();
																	num12 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
																	{
																		num12 = 3;
																	}
																	continue;
																case 0:
																	if (_timeout_5__2 != null)
																	{
																		num12 = 2;
																		continue;
																	}
																	break;
																case 1:
																	break;
																}
																break;
															}
														}
													}
													goto end_IL_031b;
												}
												break;
											}
											if (num7 == 990)
											{
												goto IL_033b;
											}
											goto IL_0363;
											end_IL_031b:;
										}
										catch (global::System.Exception)
										{
											int num14 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
											{
												num14 = 2;
											}
											while (true)
											{
												switch (num14)
												{
												default:
													if (num15 == 988)
													{
														num14 = num15;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										goto end_IL_004b;
									}
									if (num16 == 27)
									{
										__u__1 = default;
										num5 = 1;
										continue;
									}
									goto IL_00d1;
									continue;
									end_IL_006e:
									break;
								}
								_u__ = __u__1;
								num6 = 27;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
								{
									num6 = 17;
								}
								goto IL_0066;
								IL_00d1:
								if (num16 == 1007)
								{
									goto IL_006a;
								}
								goto IL_0198;
								IL_0179:
								num6 = 19;
								goto IL_0066;
								IL_02af:
								num4 = (__1__state = -1);
								num6 = 14;
								goto IL_0066;
								IL_01d6:
								if (num4 != 1)
								{
									num5 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
									{
										num5 = 18;
									}
									goto IL_006e;
								}
								goto IL_0198;
								IL_0066:
								num16 = num6;
								goto IL_006a;
								IL_006a:
								num5 = num16;
								goto IL_006e;
								end_IL_004b:;
							}
							catch (global::System.Exception)
							{
								int num17 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num17 = 0;
								}
								while (true)
								{
									switch (num17)
									{
									default:
										if (num18 == 990)
										{
											num17 = num18;
											break;
										}
										return;
									case 1:
										_ = __t__builder;
										_ = 2;
										break;
									case 0:
										__1__state = -2;
										num17 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num17 = 1;
										}
										break;
									case 2:
										return;
									}
								}
							}
							goto case 1;
						case 4:
							_ = __t__builder;
							_ = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
							{
								_ = 7;
							}
							break;
						case 2:
							oWfn25XY3YCC7mkGihcI2 = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							__1__state = -2;
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num3 = 9;
							}
							continue;
						case 3:
							num4 = __1__state;
							num = 2;
							break;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004d->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0058->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			do
			{
				while (true)
				{
					switch (num)
					{
					case 0:
						return;
					case 1:
						_ = __t__builder;
						_ = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
						{
							_ = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
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
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool kH47qx9x49JrwrchpVhN()
		{
			return n4i3Vc9xC3fM9PckBxdp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object BxBMxm9xhLm687Ld6Yv0()
		{
			return n4i3Vc9xC3fM9PckBxdp;
		}
	}

	private static TimeSpan sa6XSbPy1xP;

	private readonly object Lx4XSXsLeEj;

	private readonly object hcRXSfXY9YR;

	private readonly Func<bool> TawXSLowtbx;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, bool> iG8XSjgF5fY;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, ApIkaAfTYb5LNELVYIFB, bool> f8GXSZrfF67;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, ApIkaAfTYb5LNELVYIFB, bool> sEQXS9p8bJc;

	private readonly Func<GE50SffsnGnn7g3lMZHE, long, ApIkaAfTYb5LNELVYIFB, global::System.Exception, bool> N2gXSDLCPHN;

	private readonly object CPPXSk40g5I;

	private int LY1XSVw3HqO;

	internal static object QnfeJ6ZByy8nTxs8d4iL;

	[MethodImpl((MethodImplOptions)8)]
	internal oWfn25XY3YCC7mkGihcI(HHvjbWXSYZt2S7V2ZJQE transport, oIjXLk3MLAhkiO8QELV interLogin, Func<bool> hasActiveGameWork, Func<GE50SffsnGnn7g3lMZHE, long, bool> isCurrentReplacement, Func<GE50SffsnGnn7g3lMZHE, long, ApIkaAfTYb5LNELVYIFB, bool> tryBeginReplacement, Func<GE50SffsnGnn7g3lMZHE, long, GE50SffsnGnn7g3lMZHE, ApIkaAfTYb5LNELVYIFB, bool> tryCompleteReplacement, Func<GE50SffsnGnn7g3lMZHE, long, ApIkaAfTYb5LNELVYIFB, global::System.Exception, bool> tryRestorePrevious, Action lifecycleChanged)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<GE50SffsnGnn7g3lMZHE> GvHXYE2YkyU(string sauthWrapper, GE50SffsnGnn7g3lMZHE previousSession, long expectedGeneration, ApIkaAfTYb5LNELVYIFB previousState, CancellationToken cancellationToken, Bdya9IXkHFhKS63J1R6j? existingCoordination = null)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<global::System.Exception?> jRDXY2j5oTW(GE50SffsnGnn7g3lMZHE previousSession, GE50SffsnGnn7g3lMZHE? replacementSession, bool previousStopAttempted)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task M4hXYqTqvk4(GE50SffsnGnn7g3lMZHE session)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_TryLogoutAsync_d__13 tryLogoutAsync_d__ = default;
		tryLogoutAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool OUJXYGflqqc(object first, object second)
	{
		return string.Equals(((GE50SffsnGnn7g3lMZHE)first).UserId, ((GE50SffsnGnn7g3lMZHE)second).UserId, (StringComparison)4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void U7SXYi2B3NJ(GE50SffsnGnn7g3lMZHE previousSession, long expectedGeneration)
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string AxyXYntrPdO(object exception)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (!string.IsNullOrWhiteSpace((exception).Message))
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return ((exception).GetType()).Name;
				case 0:
					return ((exception).Message).Trim();
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void rXbXYzDvtMp()
	{
		int num = 1;
		int num3 = default;
		int num5 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					_ = CPPXSk40g5I;
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						}
						if (num3 != 988)
						{
							return;
						}
						num2 = num3;
					}
				}
				catch
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
					{
						num4 = 4;
					}
					while (true)
					{
						switch (num4)
						{
						case 0:
							return;
						}
						if (num5 != 988)
						{
							return;
						}
						num4 = num5;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					System.Threading.Interlocked.Exchange(ref LY1XSVw3HqO, 1);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while (num == 989);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
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
						if (num2 == 11)
						{
							num3 = 4;
							continue;
						}
						goto IL_0039;
					case 1:
						sa6XSbPy1xP = System.TimeSpan.FromSeconds(10.0);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						goto end_IL_000e;
					case 4:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 2:
						break;
					case 0:
						return;
					}
					goto IL_00b0;
					IL_0039:
					if (num2 == 992)
					{
						break;
					}
					goto IL_00b0;
					IL_00b0:
					HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
					num3 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						num3 = 11;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Gxsfo8ZBWhhjI60XaDSD()
	{
		return QnfeJ6ZByy8nTxs8d4iL == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oWfn25XY3YCC7mkGihcI dpL1DvZBJXMdL9F1hGyu()
	{
		return (oWfn25XY3YCC7mkGihcI)QnfeJ6ZByy8nTxs8d4iL;
	}
}

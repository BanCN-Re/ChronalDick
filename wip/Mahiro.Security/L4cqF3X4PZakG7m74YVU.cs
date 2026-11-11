using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BCXoLCXUvJyBkqc6IRk2;
using BdZQbJfN4H4AgIYemOL6;
using BjcLBlXh09xdCwZktJfV;
using C0RPrLXrEwgooXWbyseV;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using EGjGpPfNQ5sRCSMK7KqW;
using IAx1o0f1iQkCqF80SQqk;
using IShopXXhfUZdpEuiERsW;
using KCUB02Xobpko7G6QhyjY;
using O7HFpeX4wvH5fXZaaJn1;
using OJoUjNXoas1ZnYNAbZSE;
using PYSO5xX46dDsF66cx1dn;
using RjxJbhXrbm2w7GFft9Yx;
using RmtpW0Xow5SCxCO0uqYD;
using SWbctifNl0nv75nVoM1n;
using UchfG8fTzhAHMiok6Yk0;
using UlCl4CXozSPNb6fy2MI4;
using UoNuqQXhkirYxBfQcfpw;
using Vl4jDMX56cFYkU2Jw1oo;
using XwPpiLXQsPK7EEBp2PNq;
using YphbcNXr3MAYpcL0ofID;
using b7C8sgfNUlsIIZiFPiE3;
using bUfedyCg1PBqhqIkB8r;
using bwGbOeXrn2An6WX4qGu4;
using fDAldojjppXrctUVYOJn;
using j0UF4QfN832bb9GMrcTe;
using kDnqtyfNVLomBXTPNmyi;
using npAfK7XhjSyZ4tkZjVE6;
using ufKW2gfNWtEx5Kth7h2G;
using wJB2dvXh9UPV8tOqTfys;
using xsbjKUfp9um80Gf8YymA;
using yoclAxeG6hQhgmsUKZZ;

namespace GDnLN3X4xspHVjOJ1JdM;

internal sealed class L4cqF3X4PZakG7m74YVU
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ForwardPacketsAsync_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<Y9pGY9XhDLu5C5MtS4qi> __t__builder;

		public L4cqF3X4PZakG7m74YVU __4__this;

		public CancellationToken cancellationToken;

		public v2wCmOXrzswbLaNh7J2E protocol;

		public FccDXYXUz2hreOnMHmMq sourceCodec;

		public Stream source;

		public UQksENfNyB5duJtOvWxq direction;

		public FccDXYXUz2hreOnMHmMq destinationCodec;

		public Stream destination;

		private CancellationTokenSource _readTimeout_5__2;

		private kkvRUaXrvh8R9Ql3Qx9T _observation_5__3;

		private ConfiguredTaskAwaitable<qAftL0XU3M5I1RIneNTc?>.ConfiguredTaskAwaiter __u__1;

		private zBw3u2XhcwFyHwCwbYDI _handshake_5__4;

		private object __u__2;

		private ConfiguredTaskAwaitable<tevrq6fTnmxdv0004lXm>.ConfiguredTaskAwaiter __u__3;

		private static object vPlqxf9NfTpVI9hUSfqD;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_1bff: Expected O, but got Unknown
			//IL_1b0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
			//IL_080d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0812: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e22: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a54: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_087e: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0492: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
			//IL_08db: Unknown result type (might be due to invalid IL or missing references)
			//IL_08dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1038: Unknown result type (might be due to invalid IL or missing references)
			//IL_1040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_19a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9a: Expected O, but got I4
			//IL_0676: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Unknown result type (might be due to invalid IL or missing references)
			//IL_12cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1451: Unknown result type (might be due to invalid IL or missing references)
			//IL_1456: Unknown result type (might be due to invalid IL or missing references)
			//IL_131a: Unknown result type (might be due to invalid IL or missing references)
			//IL_132a: Unknown result type (might be due to invalid IL or missing references)
			//IL_132f: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0586: Expected O, but got Ref
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_055a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0616: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_063c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0641: Unknown result type (might be due to invalid IL or missing references)
			//IL_17af: Unknown result type (might be due to invalid IL or missing references)
			//IL_17b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1581: Unknown result type (might be due to invalid IL or missing references)
			//IL_1586: Unknown result type (might be due to invalid IL or missing references)
			//IL_162d: Unknown result type (might be due to invalid IL or missing references)
			//IL_153f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1541: Unknown result type (might be due to invalid IL or missing references)
			//IL_15de: Unknown result type (might be due to invalid IL or missing references)
			//IL_15ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_151a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd7->IL1f84: Incompatible stack heights: 3 vs 1
			//IL_1fe2->IL1f84: Incompatible stack heights: 3 vs 1
			//IL_0068->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0010: Incompatible stack heights: 3 vs 1
			//IL_1073->IL0268: Incompatible stack heights: 3 vs 1
			//IL_087b->IL0268: Incompatible stack heights: 3 vs 1
			//IL_18e3->IL0268: Incompatible stack heights: 3 vs 1
			//IL_104c->IL0268: Incompatible stack heights: 4 vs 1
			//IL_0fb5->IL0268: Incompatible stack heights: 2 vs 1
			//IL_107e->IL0268: Incompatible stack heights: 3 vs 1
			//IL_1922->IL0268: Incompatible stack heights: 3 vs 1
			//IL_0cfd->IL0268: Incompatible stack heights: 3 vs 1
			//IL_18ee->IL0268: Incompatible stack heights: 3 vs 1
			//IL_19d8->IL0268: Incompatible stack heights: 2 vs 1
			//IL_0fc0->IL0268: Incompatible stack heights: 2 vs 1
			//IL_0d08->IL0268: Incompatible stack heights: 3 vs 1
			//IL_0522->IL065f: Incompatible stack heights: 1 vs 0
			//IL_0569->IL04e5: Incompatible stack heights: 2 vs 1
			//IL_04ed->IL04ed: Incompatible stack heights: 1 vs 2
			//IL_053e->IL04e9: Incompatible stack heights: 1 vs 0
			int num = 4;
			L4cqF3X4PZakG7m74YVU l4cqF3X4PZakG7m74YVU = default;
			int num45 = default;
			int num5 = default;
			int num8 = default;
			object _u__ = default;
			int num27 = default;
			D7IHSrXr1huMOH1PUcFA postForwardAction = default;
			ConfiguredTaskAwaitable val = default;
			ConfiguredTaskAwaitable<qAftL0XU3M5I1RIneNTc> val3 = default;
			int num29 = default;
			ConfiguredTaskAwaitable<qAftL0XU3M5I1RIneNTc>.ConfiguredTaskAwaiter _u__3 = default;
			qAftL0XU3M5I1RIneNTc qAftL0XU3M5I1RIneNTc = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num30);
			int num31 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
			int num33 = default;
			ConfiguredTaskAwaitable<tevrq6fTnmxdv0004lXm>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<tevrq6fTnmxdv0004lXm> val2 = default;
			tevrq6fTnmxdv0004lXm transferEndpoint = default;
			byte[] sharedSecret = default;
			int num25 = default;
			int num22 = default;
			int num20 = default;
			int num12 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
			int num15 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num17 = default;
			int num19 = default;
			int num24 = default;
			int num35 = default;
			int num37 = default;
			int num39 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj5);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num40);
			global::System.Exception ex5 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num41);
			int num42 = default;
			bool flag = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result3);
			int num44 = default;
			int num47 = default;
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
								_ = __t__builder;
								_ = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
								{
									_ = 6;
								}
								continue;
							}
							goto IL_0037;
						case 0:
							return;
						case 3:
							l4cqF3X4PZakG7m74YVU = __4__this;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							goto end_IL_000c;
						case 4:
							break;
						case 2:
							try
							{
								_ = 5;
								int num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num45 == 989)
										{
											num4 = num45;
											continue;
										}
										goto case 0;
									case 0:
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num4 = 4;
										}
										continue;
									case 1:
										try
										{
											int num6;
											if ((uint)num5 > 5u)
											{
												num6 = 8;
												goto IL_015a;
											}
											goto IL_1b3b;
											IL_1b3b:
											num6 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
											{
												num6 = 14;
											}
											goto IL_015a;
											IL_015a:
											while (true)
											{
												int num7;
												switch (num6)
												{
												default:
													if (num8 != 18)
													{
														if (num8 == 998)
														{
															goto IL_0156;
														}
														goto case 10;
													}
													goto end_IL_015a;
												case 7:
												case 8:
													goto IL_01ac;
												case 5:
												{
													Y9pGY9XhDLu5C5MtS4qi canceled = Y9pGY9XhDLu5C5MtS4qi.SwitchToRaw;
													num6 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
													{
														num6 = 7;
													}
													continue;
												}
												case 9:
													_readTimeout_5__2 = null;
													num6 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
													{
														num6 = 0;
													}
													continue;
												case 10:
													try
													{
														int num9;
														switch (num5)
														{
														default:
															num9 = 29;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
															{
																num9 = 91;
															}
															goto IL_0268;
														case 4:
															goto IL_080c;
														case 0:
															goto IL_0afc;
														case 3:
															goto IL_0b1c;
														case 1:
														case 2:
															goto IL_0baa;
														case 5:
															goto IL_0e21;
															IL_0b1c:
															_u__ = __u__2;
															num9 = 18;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
															{
																num9 = 2;
															}
															goto IL_0268;
															IL_0268:
															while (true)
															{
																Y9pGY9XhDLu5C5MtS4qi y9pGY9XhDLu5C5MtS4qi;
																int num26;
																object obj;
																Y9pGY9XhDLu5C5MtS4qi canceled;
																switch (num9)
																{
																case 41:
																	return;
																case 76:
																	return;
																case 94:
																	return;
																default:
																	if (num27 != 103)
																	{
																		if (num27 == 1083)
																		{
																			goto IL_0264;
																		}
																		goto case 4;
																	}
																	Interlocked.CompareExchange<TaskCompletionSource<bool>>(l4cqF3X4PZakG7m74YVU.znvX4nTBa4j, (TaskCompletionSource<bool>)(object)64, (TaskCompletionSource<bool>)null);
																	num9 = 86;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
																	{
																		num9 = 12;
																	}
																	continue;
																case 92:
																	switch (postForwardAction)
																	{
																	case D7IHSrXr1huMOH1PUcFA.EnableEncryption:
																		goto IL_0933;
																	case D7IHSrXr1huMOH1PUcFA.EnableCompression:
																		goto IL_0b43;
																	case D7IHSrXr1huMOH1PUcFA.PauseForEncryption:
																		goto IL_194b;
																	}
																	num9 = 67;
																	continue;
																case 55:
																	break;
																case 48:
																	num5 = (__1__state = 5);
																	num9 = 34;
																	continue;
																case 60:
																	val = (destinationCodec.BKPXrjdbSu4(destination, _observation_5__3.Packet, cancellationToken)).ConfigureAwait(false);
																	num9 = 16;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
																	{
																		num9 = 18;
																	}
																	continue;
																case 7:
																case 58:
																	(_u__).GetResult();
																	num9 = 70;
																	continue;
																case 17:
																	try
																	{
																		if (num5 == 0)
																		{
																			goto IL_04e5;
																		}
																		goto IL_065f;
																		IL_065f:
																		sourceCodec.LvxXrL355ew(source, (_readTimeout_5__2).Token);
																		val3 = (ConfiguredTaskAwaitable<qAftL0XU3M5I1RIneNTc>)0;
																		int num28 = 16;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																		{
																			num28 = 9;
																		}
																		goto IL_04ed;
																		IL_04e5:
																		num29 = 4;
																		goto IL_04ed;
																		IL_04ed:
																		while (true)
																		{
																			switch (num28)
																			{
																			case 6:
																				return;
																			default:
																				switch (num29)
																				{
																				case 999:
																					break;
																				default:
																					goto end_IL_04ca;
																				case 19:
																					__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<qAftL0XU3M5I1RIneNTc>.ConfiguredTaskAwaiter, _ForwardPacketsAsync_d__19>(ref _u__3, ref this);
																					num28 = 6;
																					break;
																				}
																				continue;
																			case 8:
																				num5 = (__1__state = 0);
																				num28 = 2;
																				continue;
																			case 2:
																				break;
																			case 1:
																				qAftL0XU3M5I1RIneNTc = (qAftL0XU3M5I1RIneNTc)(&_u__3);
																				num28 = 5;
																				continue;
																			case 3:
																				num5 = (__1__state = -1);
																				num28 = 8;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																				{
																					num28 = 1;
																				}
																				continue;
																			case 9:
																				_u__3 = val3;
																				num28 = 14;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
																				{
																					num28 = 11;
																				}
																				continue;
																			case 7:
																				__u__1 = default;
																				num28 = 11;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
																				{
																					num28 = 3;
																				}
																				continue;
																			case 4:
																			case 10:
																				_u__3 = __u__1;
																				num28 = 7;
																				continue;
																			case 11:
																				if (&_u__3 == null)
																				{
																					num28 = 8;
																					continue;
																				}
																				goto case 1;
																			case 0:
																				goto IL_065f;
																			case 5:
																				goto end_IL_04ca;
																			}
																			break;
																		}
																		__u__1 = _u__3;
																		_ = 19;
																		goto IL_04e5;
																		end_IL_04ca:;
																	}
																	catch (object obj3) when (((Func<bool>)delegate
																	{
																		// Could not convert BlockContainer to single expression
																		if (!(obj3 is OperationCanceledException))
																		{
																			num30 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																			{
																				num30 = 7;
																			}
																		}
																		else
																		{
																			num30 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																			{
																				num30 = 0;
																			}
																		}
																		while (true)
																		{
																			switch (num30)
																			{
																			default:
																				if (num31 == 989)
																				{
																					goto IL_06e6;
																				}
																				goto case 1;
																			case 1:
																				result2 = 0;
																				break;
																			case 0:
																				result2 = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
																				break;
																			}
																			break;
																			IL_06e6:
																			num30 = num31;
																		}
																		return (byte)result2 != 0;
																	}).Invoke())
																	{
																		int num32 = 3;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
																		{
																			num32 = 1;
																		}
																		while (true)
																		{
																			switch (num32)
																			{
																			default:
																				if (num33 == 989)
																				{
																					num32 = num33;
																					continue;
																				}
																				break;
																			case 1:
																				canceled = (Y9pGY9XhDLu5C5MtS4qi)new Y9pGY9XhDLu5C5MtS4qi(yUXTQbXhZdCWPbu9vYcI.Failed, f3JeIyfNCcv94eShPUIb.TimedOut, vfdX4Nogf7p(protocol.State));
																				num32 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																				{
																					num32 = 0;
																				}
																				continue;
																			case 0:
																				break;
																			}
																			break;
																		}
																		goto end_IL_015a;
																	}
																	goto case 73;
																case 16:
																	if (direction != UQksENfNyB5duJtOvWxq.ClientToServer)
																	{
																		num9 = 12;
																		continue;
																	}
																	y9pGY9XhDLu5C5MtS4qi = Y9pGY9XhDLu5C5MtS4qi.LocalClosed;
																	goto IL_193f;
																case 31:
																	goto IL_080c;
																case 46:
																case 50:
																	System.Threading.Interlocked.Exchange(l4cqF3X4PZakG7m74YVU.QUlXhbOthij, 1);
																	num9 = 52;
																	continue;
																case 61:
																case 68:
																	postForwardAction = _observation_5__3.PostForwardAction;
																	num26 = 92;
																	goto IL_0260;
																case 29:
																	_ = l4cqF3X4PZakG7m74YVU.rvQX4EO8a6E;
																	_ = 9;
																	_ = 88;
																	continue;
																case 35:
																	_u__2 = val2;
																	num26 = 82;
																	goto IL_0260;
																case 82:
																	if (&_u__2 == null)
																	{
																		num9 = 52;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
																		{
																			num9 = 56;
																		}
																		continue;
																	}
																	goto case 77;
																case 57:
																	if ((_u__).IsCompleted)
																	{
																		num26 = 58;
																		goto IL_0260;
																	}
																	goto case 48;
																case 77:
																	_ = _u__2;
																	num9 = 61;
																	continue;
																case 81:
																	__u__3 = _u__2;
																	num9 = 24;
																	continue;
																case 74:
																case 85:
																	_observation_5__3 = protocol.DRGXoX7TZbp(direction, qAftL0XU3M5I1RIneNTc);
																	num9 = 11;
																	continue;
																case 44:
																	break;
																case 8:
																	goto IL_0933;
																case 15:
																	_handshake_5__4 = zBw3u2XhcwFyHwCwbYDI.DVcXh84mYdw(_observation_5__3.Packet, protocol.ProtocolVersion);
																	num9 = 84;
																	continue;
																case 20:
																case 52:
																	goto IL_0976;
																case 49:
																	num5 = (__1__state = -1);
																	num9 = 7;
																	continue;
																case 86:
																	if (_observation_5__3.PostForwardAction == D7IHSrXr1huMOH1PUcFA.AuthenticateUpstream)
																	{
																		num26 = 43;
																		goto IL_0260;
																	}
																	goto case 51;
																case 54:
																	num5 = (__1__state = -1);
																	num9 = 37;
																	continue;
																case 67:
																	break;
																case 91:
																	(_readTimeout_5__2).CancelAfter(System.TimeSpan.FromSeconds(WIeX4TdPqdK(protocol.State, l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU)));
																	num26 = 90;
																	goto IL_0260;
																case 72:
																	if ((object)transferEndpoint == null)
																	{
																		num9 = 68;
																		continue;
																	}
																	goto case 29;
																case 33:
																	_u__ = val;
																	num9 = 57;
																	continue;
																case 38:
																	goto IL_0a6f;
																case 63:
																	if (l4cqF3X4PZakG7m74YVU.EPYX4GEU9As != null)
																	{
																		num26 = 36;
																		goto IL_0260;
																	}
																	goto case 59;
																case 23:
																case 47:
																	if (System.Threading.Volatile.Read(l4cqF3X4PZakG7m74YVU.QUlXhbOthij) == 0)
																	{
																		num9 = 55;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
																		{
																			num9 = 30;
																		}
																		continue;
																	}
																	goto case 13;
																case 65:
																	__u__2 = default;
																	num9 = 49;
																	continue;
																case 90:
																	goto IL_0afc;
																case 22:
																	goto IL_0b1c;
																case 9:
																	goto IL_0b43;
																case 30:
																	if (sharedSecret.Length == 16)
																	{
																		num26 = 4;
																		goto IL_0260;
																	}
																	goto case 46;
																case 42:
																case 93:
																	if (_observation_5__3.LoginSucceeded)
																	{
																		num9 = 40;
																		continue;
																	}
																	goto case 69;
																case 87:
																	destinationCodec.CndXrf25Bl7((global::System.ReadOnlySpan<byte>)sharedSecret);
																	num9 = 20;
																	continue;
																case 84:
																	goto IL_0baa;
																case 32:
																	canceled = Y9pGY9XhDLu5C5MtS4qi.SwitchToRaw;
																	num9 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																	{
																		num9 = 0;
																	}
																	continue;
																case 28:
																	__u__3 = default;
																	num9 = 79;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
																	{
																		num9 = 67;
																	}
																	continue;
																case 12:
																	y9pGY9XhDLu5C5MtS4qi = Y9pGY9XhDLu5C5MtS4qi.RemoteClosed;
																	goto IL_193f;
																case 18:
																	_u__ = val;
																	num9 = 78;
																	continue;
																case 56:
																	num5 = (__1__state = 4);
																	num9 = 74;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																	{
																		num9 = 81;
																	}
																	continue;
																case 11:
																	if (_observation_5__3.ConnectionKind == UCfDV7XrihrRu9r5WVQZ.Unknown)
																	{
																		num9 = 19;
																		continue;
																	}
																	goto case 53;
																case 75:
																	if (sharedSecret == null)
																	{
																		num9 = 91;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																		{
																			num9 = 50;
																		}
																		continue;
																	}
																	goto case 30;
																case 34:
																	__u__2 = _u__;
																	num9 = 14;
																	continue;
																case 3:
																	throw new global::System.Exception("代理上游认证桥接未就绪");
																case 45:
																	if (_observation_5__3.PostForwardAction == D7IHSrXr1huMOH1PUcFA.PauseForEncryption)
																	{
																		num26 = 103;
																		goto IL_0260;
																	}
																	goto case 86;
																case 83:
																	goto end_IL_015a;
																case 37:
																	(_u__).GetResult();
																	num9 = 64;
																	continue;
																case 24:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<tevrq6fTnmxdv0004lXm>.ConfiguredTaskAwaiter, _ForwardPacketsAsync_d__19>(ref _u__2, ref this);
																	num9 = 94;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
																	{
																		num9 = 99;
																	}
																	continue;
																case 2:
																	__u__2 = default;
																	num9 = 54;
																	continue;
																case 14:
																	__t__builder.AwaitUnsafeOnCompleted<object, _ForwardPacketsAsync_d__19>(ref _u__, ref this);
																	num9 = 76;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
																	{
																		num9 = 63;
																	}
																	continue;
																case 26:
																	goto IL_0e21;
																case 13:
																	canceled = Y9pGY9XhDLu5C5MtS4qi.SwitchToRaw;
																	num9 = 83;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
																	{
																		num9 = 96;
																	}
																	continue;
																case 6:
																	destinationCodec.HBvXrXXRovf(_observation_5__3.CompressionThreshold);
																	num9 = 10;
																	continue;
																case 43:
																	if (direction == UQksENfNyB5duJtOvWxq.ServerToClient)
																	{
																		num26 = 38;
																		goto IL_0260;
																	}
																	goto case 3;
																case 0:
																	goto end_IL_015a;
																case 66:
																	__u__2 = _u__;
																	num9 = 89;
																	continue;
																case 71:
																	goto end_IL_015a;
																case 70:
																	if (System.Threading.Volatile.Read(l4cqF3X4PZakG7m74YVU.QUlXhbOthij) == 0)
																	{
																		num9 = 44;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																		{
																			num9 = 78;
																		}
																		continue;
																	}
																	goto case 32;
																case 95:
																	_ = l4cqF3X4PZakG7m74YVU.ujaX4qNUTwq;
																	_ = 79;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
																	{
																		_ = 5;
																	}
																	continue;
																case 79:
																	num5 = (__1__state = -1);
																	num9 = 77;
																	continue;
																case 53:
																	if (System.Threading.Interlocked.Exchange(l4cqF3X4PZakG7m74YVU.Ll3X4zo92hh, 1) == 0)
																	{
																		num9 = 7;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
																		{
																			num9 = 95;
																		}
																		continue;
																	}
																	goto case 5;
																case 88:
																	_ = l4cqF3X4PZakG7m74YVU.mYSX4vXF9Hw;
																	_ = cancellationToken;
																	val2 = (ConfiguredTaskAwaitable<tevrq6fTnmxdv0004lXm>)0;
																	_ = 35;
																	continue;
																case 21:
																	_ = l4cqF3X4PZakG7m74YVU.jB2X425V8AT;
																	_ = protocol.ProtocolVersion;
																	_ = 63;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
																	{
																		_ = 47;
																	}
																	continue;
																case 73:
																	if ((object)qAftL0XU3M5I1RIneNTc != null)
																	{
																		num9 = 74;
																		continue;
																	}
																	goto case 16;
																case 51:
																	if (_observation_5__3.SuppressForward)
																	{
																		num9 = 42;
																		continue;
																	}
																	goto case 60;
																case 78:
																	if (!(_u__).IsCompleted)
																	{
																		num9 = 27;
																		continue;
																	}
																	goto case 37;
																case 64:
																	num25 = _observation_5__3.Packet.EncodedLength + YFkFTdXouTMZ2mVrHfvp.k9VXo1N73WZ(_observation_5__3.Packet.EncodedLength);
																	num9 = 39;
																	continue;
																case 27:
																	num5 = (__1__state = 3);
																	num9 = 66;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
																	{
																		num9 = 98;
																	}
																	continue;
																case 5:
																case 19:
																	if (_observation_5__3.ConnectionKind == UCfDV7XrihrRu9r5WVQZ.Game)
																	{
																		num9 = 21;
																		continue;
																	}
																	goto case 45;
																case 69:
																	transferEndpoint = _observation_5__3.TransferEndpoint;
																	num9 = 72;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																	{
																		num9 = 30;
																	}
																	continue;
																case 39:
																	((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).r0BXoeLdxW2(direction, (long)num25, packet: true);
																	num9 = 93;
																	continue;
																case 1:
																	try
																	{
																		int num10;
																		if (num5 != 1)
																		{
																			num10 = 16;
																			goto IL_11de;
																		}
																		goto IL_133b;
																		IL_133b:
																		num10 = 15;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
																		{
																			num10 = 2;
																		}
																		goto IL_11de;
																		IL_11de:
																		while (true)
																		{
																			int num21;
																			switch (num10)
																			{
																			case 3:
																				return;
																			default:
																				if (num22 != 26)
																				{
																					if (num22 == 1006)
																					{
																						goto IL_11da;
																					}
																					goto case 5;
																				}
																				__u__2 = _u__;
																				num10 = 9;
																				continue;
																			case 16:
																				if (num5 != 2)
																				{
																					num10 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
																					{
																						num10 = 4;
																					}
																					continue;
																				}
																				goto case 12;
																			case 7:
																				((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).r0BXoeLdxW2(UQksENfNyB5duJtOvWxq.ClientToServer, (long)num20, packet: true);
																				num10 = 21;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
																				{
																					num10 = 4;
																				}
																				continue;
																			case 10:
																				num5 = (__1__state = -1);
																				num10 = 14;
																				continue;
																			case 5:
																				_u__ = val;
																				num10 = 16;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																				{
																					num10 = 1;
																				}
																				continue;
																			case 13:
																				num5 = (__1__state = 2);
																				num21 = 26;
																				goto IL_11d6;
																			case 15:
																				val = (sourceCodec.BKPXrjdbSu4(source, _handshake_5__4.Response, cancellationToken)).ConfigureAwait(false);
																				num21 = 5;
																				goto IL_11d6;
																			case 6:
																				break;
																			case 1:
																				if ((_u__).IsCompleted)
																				{
																					num10 = 11;
																					continue;
																				}
																				goto case 13;
																			case 9:
																				__t__builder.AwaitUnsafeOnCompleted<object, _ForwardPacketsAsync_d__19>(ref _u__, ref this);
																				num10 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
																				{
																					num10 = 0;
																				}
																				continue;
																			case 0:
																				if (_handshake_5__4.ShouldAuthenticate)
																				{
																					num21 = 6;
																					goto IL_11d6;
																				}
																				goto case 15;
																			case 4:
																				sourceCodec.CndXrf25Bl7(_handshake_5__4.Secret);
																				num21 = 18;
																				goto IL_11d6;
																			case 17:
																				__u__2 = default;
																				num10 = 10;
																				continue;
																			case 11:
																			case 14:
																				(_u__).GetResult();
																				num10 = 24;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
																				{
																					num10 = 8;
																				}
																				continue;
																			case 8:
																				num20 = _handshake_5__4.Response.EncodedLength + YFkFTdXouTMZ2mVrHfvp.k9VXo1N73WZ(_handshake_5__4.Response.EncodedLength);
																				num21 = 7;
																				goto IL_11d6;
																			case 12:
																				_u__ = __u__2;
																				num10 = 17;
																				continue;
																			case 2:
																				try
																				{
																					int num11;
																					if (num5 != 1)
																					{
																						num11 = 4;
																						goto IL_1496;
																					}
																					goto IL_1580;
																					IL_1580:
																					_u__ = __u__2;
																					num11 = 5;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
																					{
																						num11 = 0;
																					}
																					goto IL_1496;
																					IL_1496:
																					while (true)
																					{
																						int num13;
																						switch (num11)
																						{
																						case 9:
																							return;
																						default:
																							switch (num12)
																							{
																							case 998:
																								break;
																							default:
																								goto end_IL_1496;
																							case 18:
																								num5 = (__1__state = -1);
																								num11 = 6;
																								continue;
																							}
																							goto IL_1492;
																						case 10:
																							__t__builder.AwaitUnsafeOnCompleted<object, _ForwardPacketsAsync_d__19>(ref _u__, ref this);
																							num13 = 9;
																							goto IL_148e;
																						case 0:
																							num5 = (__1__state = 1);
																							num11 = 2;
																							continue;
																						case 5:
																							__u__2 = default;
																							num13 = 18;
																							goto IL_148e;
																						case 2:
																							__u__2 = _u__;
																							num11 = 10;
																							continue;
																						case 8:
																							if (!(_u__).IsCompleted)
																							{
																								num11 = 0;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																								{
																									num11 = 15;
																								}
																								continue;
																							}
																							goto case 6;
																						case 7:
																							break;
																						case 4:
																							val = (l4cqF3X4PZakG7m74YVU.VuFX43fHIKS.AuthenticateAsync(_handshake_5__4.ServerHash, cancellationToken)).ConfigureAwait(false);
																							num11 = 1;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
																							{
																								num11 = 7;
																							}
																							continue;
																						case 6:
																							(_u__).GetResult();
																							num11 = 3;
																							continue;
																						case 1:
																							_u__ = val;
																							num11 = 8;
																							continue;
																						case 3:
																							goto end_IL_1496;
																							IL_148e:
																							num12 = num13;
																							goto IL_1492;
																							IL_1492:
																							num11 = num12;
																							continue;
																						}
																						goto IL_1580;
																						continue;
																						end_IL_1496:
																						break;
																					}
																				}
																				catch (object obj2) when (((Func<bool>)delegate
																				{
																					// Could not convert BlockContainer to single expression
																					if (!(obj2 is OperationCanceledException))
																					{
																						num14 = 4;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																						{
																							num14 = 0;
																						}
																					}
																					else
																					{
																						num14 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																						{
																							num14 = 7;
																						}
																					}
																					while (true)
																					{
																						switch (num14)
																						{
																						default:
																							if (num15 == 989)
																							{
																								goto IL_167c;
																							}
																							goto case 0;
																						case 0:
																							result = 0;
																							break;
																						case 1:
																							result = ((cancellationToken).IsCancellationRequested ? 1 : 0);
																							break;
																						}
																						break;
																						IL_167c:
																						num14 = num15;
																					}
																					return (byte)result != 0;
																				}).Invoke())
																				{
																					int num16 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
																					{
																						num16 = 1;
																					}
																					while (true)
																					{
																						switch (num16)
																						{
																						default:
																							if (num17 == 988)
																							{
																								goto IL_1709;
																							}
																							break;
																						case 0:
																							break;
																						}
																						break;
																						IL_1709:
																						num16 = num17;
																					}
																					throw new global::System.Exception();
																				}
																				catch (global::System.Exception ex)
																				{
																					int num18 = 5;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
																					{
																						num18 = 0;
																					}
																					while (true)
																					{
																						switch (num18)
																						{
																						default:
																							if (num19 == 988)
																							{
																								goto IL_175a;
																							}
																							break;
																						case 0:
																							break;
																						}
																						break;
																						IL_175a:
																						num18 = num19;
																					}
																					throw new fYjCFyXhXArspWHG9Bh4(qOyLvbeqBlffJuaDnpH.qaZeilAb63("代理认证", ex), ex);
																				}
																				goto case 15;
																			case 18:
																				goto end_IL_11de;
																				IL_11da:
																				num10 = num22;
																				continue;
																				IL_11d6:
																				num22 = num21;
																				goto IL_11da;
																			}
																			goto IL_133b;
																			continue;
																			end_IL_11de:
																			break;
																		}
																	}
																	finally
																	{
																		if (num5 < 0)
																		{
																			int num23 = 3;
																			while (true)
																			{
																				switch (num23)
																				{
																				default:
																					if (num24 == 991)
																					{
																						num23 = num24;
																						continue;
																					}
																					break;
																				case 3:
																					if (_handshake_5__4 == null)
																					{
																						num23 = 5;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
																						{
																							num23 = 2;
																						}
																						continue;
																					}
																					break;
																				case 0:
																					break;
																				case 2:
																					goto end_IL_17e9;
																				case 1:
																					goto end_IL_17e9;
																				}
																				(_handshake_5__4).Dispose();
																				num23 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																				{
																					num23 = 1;
																				}
																				continue;
																				end_IL_17e9:
																				break;
																			}
																		}
																	}
																	goto IL_01ac;
																case 89:
																	__t__builder.AwaitUnsafeOnCompleted<object, _ForwardPacketsAsync_d__19>(ref _u__, ref this);
																	num9 = 41;
																	continue;
																case 40:
																	_ = l4cqF3X4PZakG7m74YVU.rvQX4EO8a6E;
																	_ = 8;
																	_ = 69;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
																	{
																		_ = 25;
																	}
																	continue;
																case 59:
																	throw new u3y1RIXhLOAUUdS1tnHM("已有游戏客户端连接，本次登录已拒绝");
																case 36:
																	_ = l4cqF3X4PZakG7m74YVU.rvQX4EO8a6E;
																	_ = 5;
																	_ = 45;
																	continue;
																case 4:
																	sourceCodec.CndXrf25Bl7((global::System.ReadOnlySpan<byte>)sharedSecret);
																	num9 = 87;
																	continue;
																case 62:
																	goto IL_194b;
																case 80:
																	obj = null;
																	goto IL_196f;
																case 25:
																	obj = System.Threading.Tasks.Task.CompletedTask;
																	goto IL_199f;
																case 10:
																	break;
																	IL_196f:
																	if (obj == null)
																	{
																		num9 = 25;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
																		{
																			num9 = 22;
																		}
																		continue;
																	}
																	goto IL_199f;
																	IL_0264:
																	num9 = num27;
																	continue;
																	IL_199f:
																	val = ((obj).WaitAsync(cancellationToken)).ConfigureAwait(false);
																	num9 = 33;
																	continue;
																	IL_0260:
																	num27 = num26;
																	goto IL_0264;
																	IL_0b43:
																	sourceCodec.HBvXrXXRovf(_observation_5__3.CompressionThreshold);
																	num9 = 6;
																	continue;
																	IL_193f:
																	canceled = y9pGY9XhDLu5C5MtS4qi;
																	num9 = 71;
																	continue;
																	IL_0933:
																	sharedSecret = ((KKxWUefNkXpsd6v6SISa)l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU).SharedSecret;
																	num9 = 75;
																	continue;
																	IL_194b:
																	obj = l4cqF3X4PZakG7m74YVU.znvX4nTBa4j;
																	if (obj != null)
																	{
																		goto IL_196f;
																	}
																	num26 = 80;
																	goto IL_0260;
																}
																break;
																IL_0a6f:
																if (l4cqF3X4PZakG7m74YVU.VuFX43fHIKS == null)
																{
																	num9 = 88;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
																	{
																		num9 = 3;
																	}
																	continue;
																}
																_ = l4cqF3X4PZakG7m74YVU.rvQX4EO8a6E;
																_ = 6;
																_ = 15;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																{
																	_ = 64;
																}
																continue;
																IL_0976:
																if (l4cqF3X4PZakG7m74YVU.znvX4nTBa4j == null)
																{
																	num9 = 31;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
																	{
																		num9 = 47;
																	}
																}
																else
																{
																	_ = 1;
																	_ = 23;
																}
															}
															break;
															IL_0e21:
															_u__ = __u__2;
															num9 = 65;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
															{
																num9 = 24;
															}
															goto IL_0268;
															IL_080c:
															_u__2 = __u__3;
															num9 = 28;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
															{
																num9 = 28;
															}
															goto IL_0268;
															IL_0baa:
															num9 = 26;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
															{
																num9 = 1;
															}
															goto IL_0268;
															IL_0afc:
															num9 = 28;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
															{
																num9 = 17;
															}
															goto IL_0268;
														}
													}
													finally
													{
														if (num5 < 0)
														{
															int num34 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
															{
																num34 = 0;
															}
															while (true)
															{
																switch (num34)
																{
																default:
																	if (num35 == 991)
																	{
																		num34 = num35;
																		continue;
																	}
																	break;
																case 3:
																	if (_readTimeout_5__2 == null)
																	{
																		num34 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
																		{
																			num34 = 4;
																		}
																		continue;
																	}
																	break;
																case 2:
																	break;
																case 1:
																	goto end_IL_1a16;
																case 0:
																	goto end_IL_1a16;
																}
																(_readTimeout_5__2).Dispose();
																num34 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																{
																	num34 = 8;
																}
																continue;
																end_IL_1a16:
																break;
															}
														}
													}
													goto case 9;
												case 0:
													_observation_5__3 = null;
													num6 = 7;
													continue;
												case 2:
													goto end_IL_015a;
												case 6:
													_readTimeout_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
													num6 = 3;
													continue;
												case 4:
												{
													Y9pGY9XhDLu5C5MtS4qi canceled = Y9pGY9XhDLu5C5MtS4qi.Canceled;
													num7 = 18;
													goto IL_0152;
												}
												case 3:
													break;
												case 1:
													{
														if (System.Threading.Volatile.Read(l4cqF3X4PZakG7m74YVU.QUlXhbOthij) != 0)
														{
															num7 = 5;
															goto IL_0152;
														}
														goto case 6;
													}
													IL_0156:
													num6 = num8;
													continue;
													IL_0152:
													num8 = num7;
													goto IL_0156;
													IL_01ac:
													if ((cancellationToken).IsCancellationRequested)
													{
														num6 = 4;
														continue;
													}
													goto case 1;
												}
												goto IL_1b3b;
												continue;
												end_IL_015a:
												break;
											}
										}
										catch (OperationCanceledException)
										{
											int num36 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
											{
												num36 = 5;
											}
											while (true)
											{
												switch (num36)
												{
												default:
													if (num37 == 989)
													{
														num36 = num37;
														continue;
													}
													break;
												case 0:
												{
													Y9pGY9XhDLu5C5MtS4qi canceled = Y9pGY9XhDLu5C5MtS4qi.Canceled;
													num36 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
													{
														num36 = 1;
													}
													continue;
												}
												case 1:
													break;
												}
												break;
											}
										}
										catch (InvalidDataException ex3)
										{
											InvalidDataException ex4 = ex3;
											int num38 = 2;
											while (true)
											{
												switch (num38)
												{
												default:
													if (num39 == 990)
													{
														num38 = num39;
														continue;
													}
													goto case 2;
												case 2:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)ex4, "caught-exception", "ForwardPacketsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 374);
													num38 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
													{
														num38 = 6;
													}
													continue;
												case 1:
												{
													Y9pGY9XhDLu5C5MtS4qi canceled = (Y9pGY9XhDLu5C5MtS4qi)new Y9pGY9XhDLu5C5MtS4qi(yUXTQbXhZdCWPbu9vYcI.Failed, f3JeIyfNCcv94eShPUIb.ProtocolError, (ex4).Message);
													num38 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
													{
														num38 = 0;
													}
													continue;
												}
												case 0:
													break;
												}
												break;
											}
										}
										catch (object obj4) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj5 = obj4 as global::System.Exception;
											if (obj5 == null)
											{
												num40 = 2;
												goto IL_1d25;
											}
											ex5 = obj5;
											num41 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
											{
												num41 = 12;
											}
											goto IL_1d2d;
											IL_1d29:
											num41 = num42;
											goto IL_1d2d;
											IL_1d2d:
											while (true)
											{
												switch (num41)
												{
												default:
													if (num42 != 14)
													{
														if (num42 == 994)
														{
															goto IL_1d29;
														}
														goto case 4;
													}
													goto case 6;
												case 3:
													if (!(ex5 is SocketException))
													{
														num41 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
														{
															num41 = 1;
														}
														continue;
													}
													goto case 4;
												case 1:
													if (!(ex5 is IOException))
													{
														num41 = 3;
														continue;
													}
													goto case 4;
												case 4:
													flag = true;
													num41 = 6;
													continue;
												case 0:
												case 5:
													break;
												case 2:
													result3 = 0;
													goto IL_1e3e;
												case 6:
													{
														result3 = (flag ? 1 : 0);
														goto IL_1e3e;
													}
													IL_1e3e:
													return (byte)result3 != 0;
												}
												break;
											}
											flag = false;
											num40 = 14;
											goto IL_1d25;
											IL_1d25:
											num42 = num40;
											goto IL_1d29;
										}).Invoke())
										{
											int num43 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
											{
												num43 = 1;
											}
											while (true)
											{
												switch (num43)
												{
												default:
													if (num44 == 990)
													{
														num43 = num44;
														continue;
													}
													goto case 0;
												case 0:
												{
													Y9pGY9XhDLu5C5MtS4qi canceled = (Y9pGY9XhDLu5C5MtS4qi)new Y9pGY9XhDLu5C5MtS4qi(yUXTQbXhZdCWPbu9vYcI.Failed, f3JeIyfNCcv94eShPUIb.NetworkError, (ex5).Message);
													num43 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
													{
														num43 = 0;
													}
													continue;
												}
												case 1:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex5, "caught-exception", "ForwardPacketsAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 382);
													num43 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
													{
														num43 = 0;
													}
													continue;
												case 2:
													break;
												}
												break;
											}
										}
										break;
									}
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num46 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
								{
									num46 = 4;
								}
								while (true)
								{
									switch (num46)
									{
									case 0:
										return;
									default:
										if (num47 != 990)
										{
											return;
										}
										num46 = num47;
										break;
									case 1:
										__1__state = -2;
										num46 = 2;
										break;
									case 2:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											_ = 5;
										}
										break;
									}
								}
							}
							goto end_IL_000c;
						}
						goto IL_00ac;
						IL_0037:
						if (num2 == 992)
						{
							break;
						}
						goto IL_00ac;
						IL_00ac:
						num5 = __1__state;
						num3 = 3;
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
								goto case 0;
							}
							return;
						case 2:
							break;
						case 0:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num3 = 5;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool kAPyPO9NL8Kbxke31TWA()
		{
			return vPlqxf9NfTpVI9hUSfqD == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object DoULsJ9NjTB1r1jH6uxo()
		{
			return vPlqxf9NfTpVI9hUSfqD;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<cErHyCfNgLv2dVTCrMaB> __t__builder;

		public L4cqF3X4PZakG7m74YVU __4__this;

		public CancellationToken cancellationToken;

		private TcpClient __7__wrap1;

		private TcpClient _remote_5__3;

		private FccDXYXUz2hreOnMHmMq _clientCodec_5__4;

		private FccDXYXUz2hreOnMHmMq _remoteCodec_5__5;

		private v2wCmOXrzswbLaNh7J2E _protocol_5__6;

		private NetworkStream _clientStream_5__7;

		private NetworkStream _remoteStream_5__8;

		private object __u__1;

		private ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi>.ConfiguredTaskAwaiter __u__3;

		private ConfiguredTaskAwaitable<cErHyCfNgLv2dVTCrMaB>.ConfiguredTaskAwaiter __u__4;

		internal static object j01Rxe9NZ5A77IcCg3Jb;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_118e: Expected O, but got Unknown
			//IL_0325: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0415: Expected O, but got Ref
			//IL_04af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0476: Unknown result type (might be due to invalid IL or missing references)
			//IL_0337: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Unknown result type (might be due to invalid IL or missing references)
			//IL_0545: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0883: Unknown result type (might be due to invalid IL or missing references)
			//IL_0888: Unknown result type (might be due to invalid IL or missing references)
			//IL_0927: Unknown result type (might be due to invalid IL or missing references)
			//IL_0929: Unknown result type (might be due to invalid IL or missing references)
			//IL_0846: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0966: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_081b: Expected O, but got Ref
			//IL_09f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_099f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0986: Expected O, but got Ref
			//IL_0975: Unknown result type (might be due to invalid IL or missing references)
			//IL_0953: Unknown result type (might be due to invalid IL or missing references)
			//IL_1910->IL18a8: Incompatible stack heights: 3 vs 1
			//IL_191b->IL18a8: Incompatible stack heights: 3 vs 1
			//IL_196f->IL0010: Incompatible stack heights: 3 vs 1
			//IL_197a->IL0010: Incompatible stack heights: 3 vs 1
			//IL_03df->IL01eb: Incompatible stack heights: 2 vs 1
			//IL_03ea->IL01eb: Incompatible stack heights: 2 vs 1
			//IL_085e->IL0770: Incompatible stack heights: 2 vs 1
			//IL_09c1->IL0770: Incompatible stack heights: 2 vs 1
			//IL_0bd7->IL0770: Incompatible stack heights: 3 vs 1
			//IL_09cc->IL0770: Incompatible stack heights: 2 vs 1
			//IL_0be2->IL0770: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num47 = default;
			int num5 = default;
			int num25 = default;
			object _u__4 = default;
			int num22 = default;
			ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter _u__3 = default;
			ConfiguredTaskAwaitable<TcpClient> val4 = default;
			L4cqF3X4PZakG7m74YVU l4cqF3X4PZakG7m74YVU = default;
			ConfiguredTaskAwaitable val3 = default;
			TcpClient remote_5__ = default;
			int num18 = default;
			int num15 = default;
			int num12 = default;
			ConfiguredTaskAwaitable<cErHyCfNgLv2dVTCrMaB>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi> val = default;
			ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi>.ConfiguredTaskAwaiter _u__ = default;
			Y9pGY9XhDLu5C5MtS4qi y9pGY9XhDLu5C5MtS4qi = default;
			ConfiguredTaskAwaitable<cErHyCfNgLv2dVTCrMaB> val2 = default;
			int num14 = default;
			int num17 = default;
			int num20 = default;
			int num24 = default;
			int num27 = default;
			int num29 = default;
			int num31 = default;
			int num33 = default;
			int num35 = default;
			int num37 = default;
			int num39 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num40);
			global::System.Exception ex5 = default;
			int num42 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num41);
			bool flag = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num44 = default;
			int num46 = default;
			int num49 = default;
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
							default:
								goto end_IL_000c;
							case 11:
								goto IL_192b;
							}
							break;
						case 3:
							goto end_IL_000c;
						case 2:
							__1__state = -2;
							num3 = 4;
							continue;
						case 1:
							try
							{
								_ = 3;
								int num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num47 == 989)
										{
											num4 = num47;
											continue;
										}
										goto case 0;
									case 0:
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
										{
											num4 = 7;
										}
										continue;
									case 1:
										try
										{
											int num6;
											if ((uint)num5 <= 3u)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
												{
													num6 = 7;
												}
												goto IL_011f;
											}
											goto IL_0152;
											IL_011f:
											while (true)
											{
												switch (num6)
												{
												default:
													if (num25 == 991)
													{
														num6 = num25;
														continue;
													}
													goto case 0;
												case 0:
												case 1:
													num6 = 2;
													continue;
												case 3:
													break;
												case 2:
													try
													{
														int num7;
														switch (num5)
														{
														default:
															num7 = 11;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
															{
																num7 = 19;
															}
															goto IL_01eb;
														case 0:
															_u__4 = __u__1;
															num7 = 20;
															goto IL_01eb;
														case 2:
														case 3:
															goto IL_04bf;
														case 1:
															goto IL_04ee;
															IL_04bf:
															num7 = 22;
															goto IL_01eb;
															IL_01eb:
															while (true)
															{
																switch (num7)
																{
																default:
																	if (num22 != 31)
																	{
																		if (num22 == 1011)
																		{
																			goto IL_01e7;
																		}
																		goto case 21;
																	}
																	if (&_u__3 == null)
																	{
																		num7 = 23;
																		continue;
																	}
																	goto IL_0410;
																case 10:
																	num5 = (__1__state = -1);
																	num7 = 6;
																	continue;
																case 20:
																	__u__1 = default;
																	num7 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
																	{
																		num7 = 10;
																	}
																	continue;
																case 14:
																{
																	_u__3 = val4;
																	int num21 = 31;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
																	{
																		num21 = 30;
																	}
																	num22 = num21;
																	goto IL_01e7;
																}
																case 17:
																	num5 = (__1__state = -1);
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
																	{
																		num7 = 2;
																	}
																	continue;
																case 13:
																	__u__2 = _u__3;
																	num7 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
																	{
																		num7 = 7;
																	}
																	continue;
																case 16:
																	break;
																case 12:
																	__u__1 = _u__4;
																	num7 = 5;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
																	{
																		num7 = 25;
																	}
																	continue;
																case 11:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<TcpClient>.ConfiguredTaskAwaiter, _RunAsync_d__17>(ref _u__3, ref this);
																	num7 = 8;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
																	{
																		num7 = 12;
																	}
																	continue;
																case 6:
																	(_u__4).GetResult();
																	num7 = 8;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
																	{
																		num7 = 21;
																	}
																	continue;
																case 21:
																	NuN0BDX4RxXEOKrCwn3o.ucNX4euLmss(l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU, cancellationToken);
																	val4 = (ConfiguredTaskAwaitable<TcpClient>)0;
																	_ = 14;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																	{
																		_ = 17;
																	}
																	continue;
																case 23:
																	num5 = (__1__state = 1);
																	num7 = 13;
																	continue;
																case 0:
																	goto IL_0410;
																case 7:
																	if (!(_u__4).IsCompleted)
																	{
																		num7 = 6;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
																		{
																			num7 = 1;
																		}
																		continue;
																	}
																	goto case 6;
																case 15:
																	return;
																case 9:
																	_u__4 = val3;
																	num7 = 7;
																	continue;
																case 4:
																	_remote_5__3 = remote_5__;
																	num7 = 19;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																	{
																		num7 = 18;
																	}
																	continue;
																case 2:
																	__u__2 = default;
																	num7 = 17;
																	continue;
																case 18:
																	goto IL_04bf;
																case 8:
																	return;
																case 3:
																	goto IL_04ee;
																case 5:
																	__t__builder.AwaitUnsafeOnCompleted<object, _RunAsync_d__17>(ref _u__4, ref this);
																	num7 = 15;
																	continue;
																case 19:
																	val3 = (l4cqF3X4PZakG7m74YVU.IuFX4FXQaox(cancellationToken)).ConfigureAwait(false);
																	num7 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
																	{
																		num7 = 9;
																	}
																	continue;
																case 1:
																	num5 = (__1__state = 0);
																	num7 = 12;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
																	{
																		num7 = 7;
																	}
																	continue;
																case 22:
																	{
																		try
																		{
																			int num8;
																			if ((uint)(num5 - 2) <= 1u)
																			{
																				num8 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
																				{
																					num8 = 8;
																				}
																				goto IL_05cb;
																			}
																			goto IL_05f3;
																			IL_05cb:
																			while (true)
																			{
																				switch (num8)
																				{
																				default:
																					if (num18 == 991)
																					{
																						num8 = num18;
																						continue;
																					}
																					goto case 2;
																				case 3:
																					break;
																				case 0:
																				case 1:
																					num8 = 2;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
																					{
																						num8 = 6;
																					}
																					continue;
																				case 2:
																					try
																					{
																						int num9;
																						if ((uint)(num5 - 2) <= 1u)
																						{
																							num9 = 1;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																							{
																								num9 = 8;
																							}
																							goto IL_0694;
																						}
																						goto IL_06dc;
																						IL_0694:
																						while (true)
																						{
																							switch (num9)
																							{
																							default:
																								if (num15 == 991)
																								{
																									num9 = num15;
																									continue;
																								}
																								goto case 0;
																							case 0:
																							case 1:
																								num9 = 5;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																								{
																									num9 = 2;
																								}
																								continue;
																							case 3:
																								break;
																							case 2:
																								try
																								{
																									int num10;
																									if (num5 != 2)
																									{
																										num10 = 10;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
																										{
																											num10 = 33;
																										}
																										goto IL_0770;
																									}
																									goto IL_0882;
																									IL_0b4f:
																									_remoteStream_5__8 = (_remote_5__3).GetStream();
																									int num11 = 2;
																									goto IL_0768;
																									IL_0768:
																									num12 = num11;
																									goto IL_076c;
																									IL_0770:
																									while (true)
																									{
																										switch (num10)
																										{
																										case 13:
																										case 18:
																										{
																											cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)(&_u__2);
																											num10 = 11;
																											continue;
																										}
																										case 2:
																											l4cqF3X4PZakG7m74YVU.bnrX4siiJox((Stream)(object)_clientStream_5__7, (Stream)(object)_remoteStream_5__8, _clientCodec_5__4, _remoteCodec_5__5, _protocol_5__6, cancellationToken);
																											val = (ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi>)0;
																											_ = 6;
																											continue;
																										case 4:
																											goto end_IL_0770;
																										case 23:
																											num5 = (__1__state = 3);
																											num10 = 0;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																											{
																												num10 = 26;
																											}
																											continue;
																										case 8:
																											if (&_u__ == null)
																											{
																												num10 = 3;
																												continue;
																											}
																											goto case 26;
																										case 28:
																											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<cErHyCfNgLv2dVTCrMaB>.ConfiguredTaskAwaiter, _RunAsync_d__17>(ref _u__2, ref this);
																											num10 = 4;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																											{
																												num10 = 21;
																											}
																											continue;
																										case 15:
																											_protocol_5__6.rtCXofutEiq();
																											num10 = 22;
																											continue;
																										case 0:
																											__u__4 = _u__2;
																											num10 = 28;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
																											{
																												num10 = 22;
																											}
																											continue;
																										case 6:
																											_u__ = val;
																											num10 = 8;
																											continue;
																										case 27:
																											goto IL_0972;
																										case 26:
																											y9pGY9XhDLu5C5MtS4qi = (Y9pGY9XhDLu5C5MtS4qi)(&_u__);
																											num10 = 9;
																											continue;
																										case 16:
																											l4cqF3X4PZakG7m74YVU.O6GX4MkSfFI((Stream)(object)_clientStream_5__7, (Stream)(object)_remoteStream_5__8, cancellationToken);
																											val2 = (ConfiguredTaskAwaitable<cErHyCfNgLv2dVTCrMaB>)0;
																											_ = 31;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																											{
																												_ = 27;
																											}
																											continue;
																										case 25:
																											if (&_u__2 != null)
																											{
																												num10 = 18;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																												{
																													num10 = 36;
																												}
																												continue;
																											}
																											goto case 23;
																										case 14:
																											_u__2 = __u__4;
																											num10 = 32;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
																											{
																												num10 = 7;
																											}
																											continue;
																										case 19:
																											__u__3 = _u__;
																											num10 = 31;
																											continue;
																										case 30:
																											num5 = (__1__state = -1);
																											num10 = 26;
																											continue;
																										case 22:
																										{
																											cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(y9pGY9XhDLu5C5MtS4qi.Reason, y9pGY9XhDLu5C5MtS4qi.Detail, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
																											num10 = 12;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
																											{
																												num10 = 12;
																											}
																											continue;
																										}
																										case 11:
																											goto end_IL_0737;
																										case 5:
																											num5 = (__1__state = -1);
																											num10 = 13;
																											continue;
																										case 24:
																											_clientStream_5__7 = (l4cqF3X4PZakG7m74YVU.vRnX4uT2qZT).GetStream();
																											num10 = 1;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																											{
																												num10 = 28;
																											}
																											continue;
																										case 17:
																											_protocol_5__6 = (v2wCmOXrzswbLaNh7J2E)new v2wCmOXrzswbLaNh7J2E((KKxWUefNkXpsd6v6SISa)l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU, (tevrq6fTnmxdv0004lXm)l4cqF3X4PZakG7m74YVU.SsGX41S5VYC);
																											num10 = 24;
																											continue;
																										case 31:
																											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi>.ConfiguredTaskAwaiter, _RunAsync_d__17>(ref _u__, ref this);
																											num10 = 29;
																											continue;
																										case 3:
																											num5 = (__1__state = 2);
																											num10 = 13;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
																											{
																												num10 = 19;
																											}
																											continue;
																										case 10:
																											if (num5 != 3)
																											{
																												num10 = 17;
																												continue;
																											}
																											goto case 14;
																										case 1:
																											goto IL_0b4f;
																										case 9:
																											if (y9pGY9XhDLu5C5MtS4qi.End == yUXTQbXhZdCWPbu9vYcI.SwitchToRaw)
																											{
																												num10 = 20;
																												continue;
																											}
																											goto case 15;
																										case 7:
																											__u__4 = default;
																											num10 = 5;
																											continue;
																										case 29:
																											return;
																										case 21:
																											return;
																										case 20:
																											_ = l4cqF3X4PZakG7m74YVU.rvQX4EO8a6E;
																											_ = 7;
																											_ = 10;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																											{
																												_ = 16;
																											}
																											continue;
																										case 12:
																											goto end_IL_0737;
																										}
																										if (num12 != 39)
																										{
																											if (num12 == 1019)
																											{
																												goto IL_076c;
																											}
																											goto IL_0972;
																										}
																										__u__3 = default;
																										num10 = 30;
																										continue;
																										IL_0972:
																										_u__2 = val2;
																										num10 = 25;
																										continue;
																										end_IL_0770:
																										break;
																									}
																									goto IL_0882;
																									IL_0882:
																									_u__ = __u__3;
																									num11 = 2;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
																									{
																										num11 = 39;
																									}
																									goto IL_0768;
																									IL_076c:
																									num10 = num12;
																									goto IL_0770;
																									end_IL_0737:;
																								}
																								finally
																								{
																									int num13;
																									if (num5 >= 0)
																									{
																										num13 = 7;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
																										{
																											num13 = 0;
																										}
																										goto IL_0c20;
																									}
																									goto IL_0c86;
																									IL_0c20:
																									while (true)
																									{
																										switch (num13)
																										{
																										default:
																											if (num14 == 991)
																											{
																												num13 = num14;
																												continue;
																											}
																											break;
																										case 0:
																											goto end_IL_0c20;
																										case 3:
																											(_remoteCodec_5__5).Dispose();
																											num13 = 2;
																											continue;
																										case 1:
																											break;
																										case 2:
																											goto end_IL_0c20;
																										}
																										goto IL_0c86;
																										continue;
																										end_IL_0c20:
																										break;
																									}
																									goto end_IL_0be7;
																									IL_0c86:
																									if (_remoteCodec_5__5 != null)
																									{
																										num13 = 3;
																										goto IL_0c20;
																									}
																									end_IL_0be7:;
																								}
																								goto end_IL_0694;
																							}
																							goto IL_06dc;
																							continue;
																							end_IL_0694:
																							break;
																						}
																						goto end_IL_0659;
																						IL_06dc:
																						_remoteCodec_5__5 = (FccDXYXUz2hreOnMHmMq)new FccDXYXUz2hreOnMHmMq(((KKxWUefNkXpsd6v6SISa)l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU).MaximumPacketBytes);
																						num9 = 5;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
																						{
																							num9 = 0;
																						}
																						goto IL_0694;
																						end_IL_0659:;
																					}
																					finally
																					{
																						if (num5 < 0)
																						{
																							int num16 = 0;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
																							{
																								num16 = 2;
																							}
																							while (true)
																							{
																								switch (num16)
																								{
																								default:
																									if (num17 == 990)
																									{
																										num16 = num17;
																										continue;
																									}
																									break;
																								case 2:
																									if (_clientCodec_5__4 != null)
																									{
																										num16 = 6;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
																										{
																											num16 = 1;
																										}
																										continue;
																									}
																									break;
																								case 1:
																									(_clientCodec_5__4).Dispose();
																									num16 = 1;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
																									{
																										num16 = 0;
																									}
																									continue;
																								case 0:
																									break;
																								}
																								break;
																							}
																						}
																					}
																					goto end_IL_05cb;
																				}
																				goto IL_05f3;
																				continue;
																				end_IL_05cb:
																				break;
																			}
																			goto end_IL_0590;
																			IL_05f3:
																			_clientCodec_5__4 = (FccDXYXUz2hreOnMHmMq)new FccDXYXUz2hreOnMHmMq(((KKxWUefNkXpsd6v6SISa)l4cqF3X4PZakG7m74YVU.JKEX4aWuYTU).MaximumPacketBytes);
																			num8 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
																			{
																				num8 = 4;
																			}
																			goto IL_05cb;
																			end_IL_0590:;
																		}
																		finally
																		{
																			if (num5 < 0)
																			{
																				int num19 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
																				{
																					num19 = 1;
																				}
																				while (true)
																				{
																					switch (num19)
																					{
																					default:
																						if (num20 == 990)
																						{
																							num19 = num20;
																							continue;
																						}
																						goto case 1;
																					case 1:
																						if (_remote_5__3 != null)
																						{
																							num19 = 1;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																							{
																								num19 = 2;
																							}
																							continue;
																						}
																						break;
																					case 2:
																						(_remote_5__3).Dispose();
																						num19 = 0;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																						{
																							num19 = 6;
																						}
																						continue;
																					case 0:
																						break;
																					}
																					break;
																				}
																			}
																		}
																		goto end_IL_01a5;
																	}
																	IL_01e7:
																	num7 = num22;
																	continue;
																}
																break;
																IL_0410:
																remote_5__ = (TcpClient)(object)(&_u__3);
																num7 = 4;
															}
															goto case 0;
															IL_04ee:
															_u__3 = __u__2;
															num7 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
															{
																num7 = 5;
															}
															goto IL_01eb;
															end_IL_01a5:
															break;
														}
													}
													finally
													{
														int num23;
														if (num5 >= 0)
														{
															num23 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
															{
																num23 = 5;
															}
															goto IL_0e43;
														}
														goto IL_0ebe;
														IL_0e43:
														while (true)
														{
															switch (num23)
															{
															default:
																if (num24 == 991)
																{
																	num23 = num24;
																	continue;
																}
																goto end_IL_0e43;
															case 1:
																goto end_IL_0e43;
															case 3:
																(__7__wrap1).Dispose();
																num23 = 2;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
																{
																	num23 = 2;
																}
																continue;
															case 0:
																break;
															case 2:
																goto end_IL_0e43;
															}
															goto IL_0ebe;
															continue;
															end_IL_0e43:
															break;
														}
														goto end_IL_0e0a;
														IL_0ebe:
														if (__7__wrap1 != null)
														{
															num23 = 3;
															goto IL_0e43;
														}
														end_IL_0e0a:;
													}
													goto end_IL_011f;
												}
												goto IL_0152;
												continue;
												end_IL_011f:
												break;
											}
											goto end_IL_00e6;
											IL_0152:
											__7__wrap1 = (TcpClient)l4cqF3X4PZakG7m74YVU.vRnX4uT2qZT;
											num6 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
											{
												num6 = 0;
											}
											goto IL_011f;
											end_IL_00e6:;
										}
										catch (OperationCanceledException)
										{
											int num26 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
											{
												num26 = 5;
											}
											while (true)
											{
												switch (num26)
												{
												default:
													if (num27 == 989)
													{
														num26 = num27;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_0f06;
												}
												cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.Canceled, "代理连接已取消", ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
												num26 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
												{
													num26 = 4;
												}
												continue;
												end_IL_0f06:
												break;
											}
										}
										catch (QlcFgbX45bXEIqsSjOj7 qlcFgbX45bXEIqsSjOj)
										{
											int num28 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
											{
												num28 = 1;
											}
											while (true)
											{
												switch (num28)
												{
												default:
													if (num29 == 990)
													{
														num28 = num29;
														continue;
													}
													goto case 0;
												case 0:
												{
													cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.ConnectionAuthorizationFailed, (qlcFgbX45bXEIqsSjOj).Message, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
													num28 = 2;
													continue;
												}
												case 1:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(qlcFgbX45bXEIqsSjOj, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 96);
													num28 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
													{
														num28 = 0;
													}
													continue;
												case 2:
													break;
												}
												break;
											}
										}
										catch (w5XYUfXonpij6hCLxJAA w5XYUfXonpij6hCLxJAA)
										{
											int num30 = 2;
											while (true)
											{
												switch (num30)
												{
												default:
													if (num31 == 990)
													{
														num30 = num31;
														continue;
													}
													goto case 2;
												case 2:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)w5XYUfXonpij6hCLxJAA, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 104);
													num30 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
													{
														num30 = 0;
													}
													continue;
												case 0:
												{
													cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.SocksAuthenticationFailed, (w5XYUfXonpij6hCLxJAA).Message, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
													num30 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
													{
														num30 = 1;
													}
													continue;
												}
												case 1:
													break;
												}
												break;
											}
										}
										catch (InvalidDataException ex2)
										{
											InvalidDataException ex3 = ex2;
											int num32 = 2;
											while (true)
											{
												switch (num32)
												{
												default:
													if (num33 == 990)
													{
														num32 = num33;
														continue;
													}
													break;
												case 2:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)ex3, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 112);
													num32 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
													{
														num32 = 0;
													}
													continue;
												case 1:
													break;
												case 0:
													goto end_IL_11aa;
												}
												cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.ProtocolError, (ex3).Message, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
												num32 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
												{
													num32 = 0;
												}
												continue;
												end_IL_11aa:
												break;
											}
										}
										catch (fYjCFyXhXArspWHG9Bh4 fYjCFyXhXArspWHG9Bh)
										{
											int num34 = 2;
											while (true)
											{
												switch (num34)
												{
												default:
													if (num35 == 990)
													{
														num34 = num35;
														continue;
													}
													goto case 0;
												case 0:
												{
													cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.AuthenticationFailed, (fYjCFyXhXArspWHG9Bh).Message, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
													num34 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
													{
														num34 = 1;
													}
													continue;
												}
												case 2:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(fYjCFyXhXArspWHG9Bh, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 120);
													num34 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
													{
														num34 = 7;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
										catch (u3y1RIXhLOAUUdS1tnHM u3y1RIXhLOAUUdS1tnHM)
										{
											int num36 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
											{
												num36 = 1;
											}
											while (true)
											{
												switch (num36)
												{
												default:
													if (num37 == 990)
													{
														num36 = num37;
														continue;
													}
													break;
												case 0:
												{
													cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.ConnectionLimitReached, (u3y1RIXhLOAUUdS1tnHM).Message, ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
													num36 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
													{
														num36 = 1;
													}
													continue;
												}
												case 2:
													break;
												case 1:
													goto end_IL_13cf;
												}
												cywTmHCBonHBVDeOMyD.TdvClQfWA9(u3y1RIXhLOAUUdS1tnHM, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 128);
												num36 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
												{
													num36 = 3;
												}
												continue;
												end_IL_13cf:
												break;
											}
										}
										catch (TimeoutException)
										{
											int num38 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
											{
												num38 = 3;
											}
											while (true)
											{
												switch (num38)
												{
												default:
													if (num39 == 989)
													{
														num38 = num39;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_14ec;
												}
												cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.TimedOut, "连接目标网络服超时", ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
												num38 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
												{
													num38 = 0;
												}
												continue;
												end_IL_14ec:
												break;
											}
										}
										catch (object obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num40 = 6;
											}
											else
											{
												ex5 = obj2;
												num40 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
												{
													num40 = 1;
												}
											}
											while (true)
											{
												switch (num40)
												{
												default:
													if (num42 != 14)
													{
														if (num42 == 994)
														{
															goto IL_1584;
														}
														goto case 5;
													}
													goto case 2;
												case 0:
													if (!(ex5 is SocketException))
													{
														num41 = 3;
														goto IL_1580;
													}
													goto case 5;
												case 5:
													flag = true;
													num41 = 14;
													goto IL_1580;
												case 3:
												case 4:
													flag = false;
													num40 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
													{
														num40 = 10;
													}
													continue;
												case 1:
													if (!(ex5 is IOException))
													{
														num40 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
														{
															num40 = 10;
														}
														continue;
													}
													goto case 5;
												case 6:
													result = 0;
													break;
												case 2:
													{
														result = (flag ? 1 : 0);
														break;
													}
													IL_1580:
													num42 = num41;
													goto IL_1584;
													IL_1584:
													num40 = num42;
													continue;
												}
												break;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num43 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
											{
												num43 = 6;
											}
											while (true)
											{
												switch (num43)
												{
												default:
													if (num44 == 989)
													{
														num43 = num44;
														continue;
													}
													break;
												case 0:
												{
													cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.NetworkError, "无法连接或维持目标网络服连接", ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
													num43 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
													{
														num43 = 5;
													}
													continue;
												}
												case 1:
													break;
												}
												break;
											}
										}
										catch (global::System.Exception ex6)
										{
											int num45 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
											{
												num45 = 2;
											}
											while (true)
											{
												switch (num45)
												{
												default:
													if (num46 != 990)
													{
														break;
													}
													goto IL_176f;
												case 1:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex6, "caught-exception", "RunAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\Proxy\\JavaProxyConnectionSession.cs", 150);
													num46 = 2;
													goto IL_176f;
												case 2:
													break;
												case 0:
													goto end_IL_1773;
													IL_176f:
													num45 = num46;
													continue;
												}
												cErHyCfNgLv2dVTCrMaB cErHyCfNgLv2dVTCrMaB = (cErHyCfNgLv2dVTCrMaB)new cErHyCfNgLv2dVTCrMaB(f3JeIyfNCcv94eShPUIb.InternalError, string.Concat("代理内部错误：", ((ex6).GetType()).Name), ((G3SmJxXoRkHCNrxY0lca)l4cqF3X4PZakG7m74YVU.DTjX4i11VXs).Snapshot());
												num45 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
												{
													num45 = 0;
												}
												continue;
												end_IL_1773:
												break;
											}
										}
										break;
									}
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num48 = 2;
								while (true)
								{
									switch (num48)
									{
									default:
										if (num49 == 990)
										{
											num48 = num49;
											break;
										}
										goto case 2;
									case 2:
										__1__state = -2;
										num48 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
										{
											num48 = 6;
										}
										break;
									case 0:
										_ = __t__builder;
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
										{
											_ = 4;
										}
										break;
									case 1:
										return;
									}
								}
							}
							goto case 2;
						case 0:
							return;
						case 4:
							{
								_ = __t__builder;
								_ = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
								{
									_ = 0;
								}
								continue;
							}
							IL_192b:
							l4cqF3X4PZakG7m74YVU = __4__this;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								num3 = 6;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num5 = __1__state;
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
						case 0:
							return;
						case 2:
							num3 = 1;
							continue;
						case 1:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aRATmk9N9IHm7edOiB39()
		{
			return j01Rxe9NZ5A77IcCg3Jb == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object tO8YT49NDDKU826OCmhd()
		{
			return j01Rxe9NZ5A77IcCg3Jb;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunRawAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<cErHyCfNgLv2dVTCrMaB> __t__builder;

		public CancellationToken cancellationToken;

		public L4cqF3X4PZakG7m74YVU __4__this;

		public Stream clientStream;

		public Stream remoteStream;

		private CancellationTokenSource _linked_5__2;

		private global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> _clientToServer_5__3;

		private global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> _serverToClient_5__4;

		private global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> _firstTask_5__5;

		private Y9pGY9XhDLu5C5MtS4qi _first_5__6;

		private ConfiguredTaskAwaitable<global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi>>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<Y9pGY9XhDLu5C5MtS4qi>.ConfiguredTaskAwaiter __u__2;

		private object __u__3;

		private static object daLFD59NSkDIfWEmviaZ;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
						case 1:
							goto end_IL_000e;
						case 2:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num3 = 1;
							}
							continue;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fujoKU9Nc3vdcK6bGGZq()
		{
			return daLFD59NSkDIfWEmviaZ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object aUs7uO9N0WpsnNUsyCna()
		{
			return daLFD59NSkDIfWEmviaZ;
		}
	}

	private readonly object vRnX4uT2qZT;

	private readonly object JKEX4aWuYTU;

	private readonly object SsGX41S5VYC;

	private readonly qjUekmXQFPB3X2exa8El? VuFX43fHIKS;

	private readonly Func<tevrq6fTnmxdv0004lXm, CancellationToken, global::System.Threading.Tasks.Task<tevrq6fTnmxdv0004lXm>> mYSX4vXF9Hw;

	private readonly Action<n1qKx2fNJL9msKD7ZGJu> rvQX4EO8a6E;

	private readonly Action<int> jB2X425V8AT;

	private readonly object ujaX4qNUTwq;

	private readonly Func<bool> EPYX4GEU9As;

	private readonly object DTjX4i11VXs;

	private TaskCompletionSource<bool>? znvX4nTBa4j;

	private int Ll3X4zo92hh;

	private int QUlXhbOthij;

	private static object sWqVjqZKwOj2MSOdtu8a;

	internal I8UL5cfNhu2cgReqF3g8 Traffic
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((G3SmJxXoRkHCNrxY0lca)DTjX4i11VXs).Snapshot();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task IuFX4FXQaox(CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal L4cqF3X4PZakG7m74YVU(TcpClient client, KKxWUefNkXpsd6v6SISa options, tevrq6fTnmxdv0004lXm localEndpoint, qjUekmXQFPB3X2exa8El? loginBridge, Func<tevrq6fTnmxdv0004lXm, CancellationToken, global::System.Threading.Tasks.Task<tevrq6fTnmxdv0004lXm>> transferRequested, Action<n1qKx2fNJL9msKD7ZGJu> stateChanged, Action<int> protocolNegotiated, Action handshakeIdentified, Func<bool> tryAcquireGameRoute)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		DTjX4i11VXs = (object)new G3SmJxXoRkHCNrxY0lca();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<cErHyCfNgLv2dVTCrMaB> RunAsync(CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_RunAsync_d__17 runAsync_d__ = default;
		runAsync_d__.cancellationToken = cancellationToken;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RunAsync_d__17*)2)->__t__builder, ref runAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> bnrX4siiJox(Stream clientStream, Stream remoteStream, FccDXYXUz2hreOnMHmMq clientCodec, FccDXYXUz2hreOnMHmMq remoteCodec, v2wCmOXrzswbLaNh7J2E protocol, CancellationToken cancellationToken)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> ForwardPacketsAsync(Stream source, Stream destination, FccDXYXUz2hreOnMHmMq sourceCodec, FccDXYXUz2hreOnMHmMq destinationCodec, v2wCmOXrzswbLaNh7J2E protocol, UQksENfNyB5duJtOvWxq direction, CancellationToken cancellationToken)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		_ForwardPacketsAsync_d__19 forwardPacketsAsync_d__ = default;
		forwardPacketsAsync_d__.destination = destination;
		_ = 17;
		forwardPacketsAsync_d__.source = source;
		_ = 14;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e;
		_ = 0;
		forwardPacketsAsync_d__.__1__state = -1;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_ForwardPacketsAsync_d__19*)7)->__t__builder, ref forwardPacketsAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int WIeX4TdPqdK(zNm36IfN0r4HRnMd2R6W state, object options)
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
					goto IL_0021;
				case 2:
					return ((KKxWUefNkXpsd6v6SISa)options).ConnectionTimeoutSeconds;
				case 0:
					if (state == zNm36IfN0r4HRnMd2R6W.Play)
					{
						return ((KKxWUefNkXpsd6v6SISa)options).IdleTimeoutSeconds;
					}
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					break;
				}
				goto IL_0068;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0068;
				IL_0068:
				System.ArgumentNullException.ThrowIfNull(options, "options");
				num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string vfdX4Nogf7p(zNm36IfN0r4HRnMd2R6W state)
	{
		int num = 6;
		string result = default;
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
						if (num2 != 15 && num2 == 996)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 0:
					case 4:
					case 7:
						return result;
					case 2:
						result = "目标网络服未进入认证阶段，玩家客户端握手扩展或所选版本可能不兼容";
						num3 = 7;
						continue;
					case 6:
						switch (state)
						{
						case zNm36IfN0r4HRnMd2R6W.Login:
							break;
						default:
							goto IL_00b2;
						case zNm36IfN0r4HRnMd2R6W.Handshake:
						case zNm36IfN0r4HRnMd2R6W.Status:
							goto end_IL_0010_2;
						case zNm36IfN0r4HRnMd2R6W.Configuration:
							goto IL_0139;
						}
						goto case 2;
					case 1:
					case 5:
						result = "代理连接等待数据超时";
						num3 = 4;
						continue;
					case 8:
						break;
					case 3:
						goto IL_0139;
						IL_0139:
						result = "目标网络服配置阶段超时，玩家客户端加载器或模组可能不兼容";
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							num3 = 0;
						}
						continue;
						IL_00b2:
						num3 = 5;
						continue;
						end_IL_0010_2:
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
			result = "目标网络服握手响应超时";
			num = 15;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
			{
				num = 15;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<cErHyCfNgLv2dVTCrMaB> O6GX4MkSfFI(Stream clientStream, Stream remoteStream, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_RunRawAsync_d__22 runRawAsync_d__ = default;
		runRawAsync_d__.cancellationToken = cancellationToken;
		_ = 5;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RunRawAsync_d__22*)2)->__t__builder, ref runRawAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> CopyRawAsync(Stream source, Stream destination, UQksENfNyB5duJtOvWxq direction, CancellationToken cancellationToken)
	{
		_CopyRawAsync_d__23 copyRawAsync_d__ = default;
		copyRawAsync_d__.source = source;
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35;
		((AsyncTaskMethodBuilder<sqxgGaf1G3NFtC5JDIRJ>*)4)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>>.ConfiguredTaskAwaiter, da18CdX55laNMRKtM3p0._RemoveFourDimensionalPartAsync_d__92>(ref *(ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<m4wFTFfpZW4pcAqQZC1k>>.ConfiguredTaskAwaiter*)(&copyRawAsync_d__.__t__builder), ref *(da18CdX55laNMRKtM3p0._RemoveFourDimensionalPartAsync_d__92*)(&copyRawAsync_d__));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task PELX4pWYJou(global::System.Threading.Tasks.Task<Y9pGY9XhDLu5C5MtS4qi> task)
	{
		return null;
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
						if (num2 == 9)
						{
							return;
						}
						goto IL_0031;
					case 2:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 1:
						break;
					}
					goto IL_0078;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					num3 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
					{
						num3 = 0;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VCdGBhZKeDIm0TMNrTZq()
	{
		return sWqVjqZKwOj2MSOdtu8a == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static L4cqF3X4PZakG7m74YVU D9yIOTZKPejKIb6p4177()
	{
		return (L4cqF3X4PZakG7m74YVU)sWqVjqZKwOj2MSOdtu8a;
	}
}

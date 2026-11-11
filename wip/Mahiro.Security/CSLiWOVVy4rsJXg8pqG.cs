using System;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CELgvWV9lYsRgTXgugK;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using TMq6qlVkgbYPkRTR0JI;
using fDAldojjppXrctUVYOJn;
using hvdlBFkJRUOXRPxBGLo;
using toftxFkKDnPm2ElaKgA;

namespace oPTLxRVYkoIM9o8i68e;

internal sealed class CSLiWOVVy4rsJXg8pqG : XV8PggkWW4TAVTrqDUo
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AuthenticateAsync_d__5_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public int controlPort;

		public string gameId;

		public string userId;

		public string serverHash;

		public CancellationToken cancellationToken;

		public CSLiWOVVy4rsJXg8pqG __4__this;

		private CancellationTokenSource _timeout_5__2;

		private TcpClient _client_5__3;

		private CancellationTokenRegistration _cancellation_5__4;

		private NetworkStream _stream_5__5;

		private byte[] _response_5__6;

		private object __u__1;

		private static object mhuiv990Iix23sBvcfKt;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_1440: Ignored invalid 'constrained' prefix
			//IL_13a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1679: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got I4
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0347: Unknown result type (might be due to invalid IL or missing references)
			//IL_034c: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_117b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1180: Unknown result type (might be due to invalid IL or missing references)
			//IL_11a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_114a: Unknown result type (might be due to invalid IL or missing references)
			//IL_110a: Unknown result type (might be due to invalid IL or missing references)
			//IL_110c: Unknown result type (might be due to invalid IL or missing references)
			//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_11eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0773: Unknown result type (might be due to invalid IL or missing references)
			//IL_0778: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0610: Unknown result type (might be due to invalid IL or missing references)
			//IL_0615: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f81: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_085c: Unknown result type (might be due to invalid IL or missing references)
			//IL_086c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0871: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d75: Unknown result type (might be due to invalid IL or missing references)
			//IL_074c: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0edb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c55: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0624: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0df9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e09: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0965: Unknown result type (might be due to invalid IL or missing references)
			//IL_0967: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3f: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f9->IL1416: Incompatible stack heights: 1 vs 2
			//IL_1427->IL143a: Incompatible stack heights: 1 vs 0
			//IL_1404->IL1416: Incompatible stack heights: 1 vs 2
			//IL_143a->IL143a: Incompatible stack heights: 1 vs 0
			int num = 2;
			CSLiWOVVy4rsJXg8pqG cSLiWOVVy4rsJXg8pqG = default;
			int num4 = default;
			int num37 = default;
			int num7 = default;
			int num9 = default;
			int num28 = default;
			int num12 = default;
			object _u__ = default;
			int num14 = default;
			ConfiguredTaskAwaitable val2 = default;
			int num17 = default;
			int num20 = default;
			int num22 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num24);
			int num25 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num27 = default;
			int num30 = default;
			int num33 = default;
			int num35 = default;
			int num39 = default;
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
							if (num2 != 14)
							{
								if (num2 == 995)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							_client_5__3 = null;
							num = 5;
							break;
						case 1:
							cSLiWOVVy4rsJXg8pqG = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num3 = 8;
							}
							continue;
						case 3:
							(__t__builder).SetResult();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 14;
							}
							continue;
						case 5:
							_cancellation_5__4 = default;
							num3 = 3;
							continue;
						case 2:
							num4 = __1__state;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
							{
								num3 = 8;
							}
							continue;
						case 4:
							__1__state = -2;
							num3 = 7;
							continue;
						case 6:
							return;
						case 0:
							try
							{
								int num5;
								if ((uint)num4 > 5u)
								{
									num5 = 2;
									goto IL_0132;
								}
								goto IL_0164;
								IL_0164:
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
								{
									num5 = 10;
								}
								goto IL_0132;
								IL_0132:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num37 == 10)
										{
											break;
										}
										if (num37 == 990)
										{
											goto IL_012e;
										}
										goto case 2;
									case 2:
										njuVSHrMCP(controlPort, gameId, userId, serverHash);
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num5 = 8;
										}
										continue;
									case 0:
									{
										_timeout_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
										int num36 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
										{
											num36 = 0;
										}
										num37 = num36;
										goto IL_012e;
									}
									case 1:
										{
											try
											{
												int num6;
												if ((uint)num4 > 5u)
												{
													num6 = 2;
													goto IL_021a;
												}
												goto IL_024c;
												IL_024c:
												num7 = 10;
												goto IL_0216;
												IL_021a:
												while (true)
												{
													switch (num6)
													{
													case 1:
														goto end_IL_021a;
													case 2:
														goto IL_0257;
													case 0:
														_client_5__3 = (TcpClient)(object)2;
														num6 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
														{
															num6 = 1;
														}
														continue;
													}
													if (num7 != 10)
													{
														if (num7 == 990)
														{
															goto IL_0216;
														}
														goto IL_0257;
													}
													try
													{
														int num8;
														if ((uint)num4 > 5u)
														{
															num8 = 2;
															goto IL_02d9;
														}
														goto IL_0386;
														IL_02d5:
														num8 = num9;
														goto IL_02d9;
														IL_02d9:
														while (true)
														{
															switch (num8)
															{
															case 2:
																goto IL_030b;
															case 1:
															{
																CancellationToken val = (_timeout_5__2).Token;
																_cancellation_5__4 = (val).Register((Action)(object)_client_5__3);
																num8 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
																{
																	num8 = 1;
																}
																continue;
															}
															case 0:
																goto end_IL_02d9;
															}
															if (num9 != 10)
															{
																if (num9 == 990)
																{
																	goto IL_02d5;
																}
																goto IL_030b;
															}
															try
															{
																_ = 5;
																int num10 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
																{
																	num10 = 6;
																}
																while (true)
																{
																	switch (num10)
																	{
																	default:
																		if (num28 == 990)
																		{
																			num10 = num28;
																			continue;
																		}
																		break;
																	case 2:
																		try
																		{
																			int num11;
																			if (num4 == 0)
																			{
																				num11 = 2;
																				goto IL_0425;
																			}
																			goto IL_109b;
																			IL_0421:
																			num11 = num12;
																			goto IL_0425;
																			IL_0425:
																			while (true)
																			{
																				switch (num11)
																				{
																				case 7:
																					return;
																				default:
																					if (num12 != 27)
																					{
																						if (num12 == 1007)
																						{
																							goto IL_0421;
																						}
																						goto case 3;
																					}
																					goto case 10;
																				case 16:
																					try
																					{
																						int num13;
																						switch (num4)
																						{
																						default:
																							num13 = 21;
																							goto IL_04d5;
																						case 3:
																							_u__ = __u__1;
																							num13 = 15;
																							goto IL_04d5;
																						case 4:
																							goto IL_060f;
																						case 1:
																							goto IL_0772;
																						case 5:
																							goto IL_083a;
																						case 2:
																							goto IL_0cd0;
																							IL_04d5:
																							while (true)
																							{
																								int num15;
																								switch (num13)
																								{
																								case 18:
																									return;
																								case 24:
																									return;
																								case 31:
																									return;
																								case 41:
																									return;
																								default:
																									if (num14 != 57)
																									{
																										if (num14 == 1037)
																										{
																											goto IL_04d1;
																										}
																										goto case 13;
																									}
																									val2 = (os8VcoHP2o(_stream_5__5, serverHash, (_timeout_5__2).Token)).ConfigureAwait(false);
																									num13 = 45;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
																									{
																										num13 = 29;
																									}
																									continue;
																								case 15:
																									__u__1 = default;
																									num13 = 30;
																									continue;
																								case 9:
																									break;
																								case 2:
																									_u__ = val2;
																									num13 = 54;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																									{
																										num13 = 8;
																									}
																									continue;
																								case 10:
																									goto IL_060f;
																								case 33:
																									_u__ = val2;
																									num15 = 34;
																									goto IL_04cd;
																								case 14:
																									num4 = (__1__state = -1);
																									num13 = 32;
																									continue;
																								case 36:
																									if ((_u__).IsCompleted)
																									{
																										num13 = 31;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
																										{
																											num13 = 13;
																										}
																										continue;
																									}
																									goto case 27;
																								case 38:
																									__u__1 = default;
																									num13 = 25;
																									continue;
																								case 30:
																									num4 = (__1__state = -1);
																									num13 = 47;
																									continue;
																								case 28:
																									__u__1 = default;
																									num13 = 6;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																									{
																										num13 = 14;
																									}
																									continue;
																								case 1:
																									num4 = (__1__state = -1);
																									num13 = 40;
																									continue;
																								case 3:
																									__u__1 = _u__;
																									num13 = 50;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
																									{
																										num13 = 0;
																									}
																									continue;
																								case 39:
																									num4 = (__1__state = 1);
																									num13 = 45;
																									continue;
																								case 22:
																									__u__1 = _u__;
																									num13 = 20;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																									{
																										num13 = 44;
																									}
																									continue;
																								case 44:
																									goto IL_0772;
																								case 32:
																								case 37:
																									(_u__).GetResult();
																									num13 = 42;
																									continue;
																								case 48:
																									__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																									num13 = 31;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
																									{
																										num13 = 57;
																									}
																									continue;
																								case 6:
																									__u__1 = default;
																									num13 = 52;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
																									{
																										num13 = 1;
																									}
																									continue;
																								case 4:
																									goto IL_083a;
																								case 19:
																									val2 = (os8VcoHP2o(_stream_5__5, userId, (_timeout_5__2).Token)).ConfigureAwait(false);
																									num13 = 11;
																									continue;
																								case 42:
																									_response_5__6 = new byte[4];
																									num13 = 4;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
																									{
																										num13 = 42;
																									}
																									continue;
																								case 25:
																									num4 = (__1__state = -1);
																									num13 = 49;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																									{
																										num13 = 54;
																									}
																									continue;
																								case 16:
																									try
																									{
																										int num16;
																										if (num4 != 5)
																										{
																											num16 = 17;
																											goto IL_08ee;
																										}
																										goto IL_0a40;
																										IL_0b78:
																										_u__ = val2;
																										num16 = 19;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																										{
																											num16 = 25;
																										}
																										goto IL_08ee;
																										IL_08ee:
																										num17 = num16;
																										goto IL_08f2;
																										IL_08f2:
																										int num18 = num17;
																										goto IL_08f6;
																										IL_08f6:
																										while (true)
																										{
																											switch (num18)
																											{
																											case 12:
																												return;
																											case 5:
																												__u__1 = _u__;
																												num18 = 4;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
																												{
																													num18 = 9;
																												}
																												continue;
																											case 11:
																												if (_response_5__6[3] == 0)
																												{
																													num18 = 6;
																													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																													{
																														num18 = 2;
																													}
																													continue;
																												}
																												goto IL_0bab;
																											case 6:
																												num4 = (__1__state = 5);
																												num18 = 5;
																												continue;
																											case 8:
																												goto IL_0a13;
																											case 4:
																												if (_response_5__6[2] != 0)
																												{
																													num18 = 7;
																													continue;
																												}
																												goto case 11;
																											case 10:
																												goto end_IL_08f6;
																											case 3:
																												num4 = (__1__state = -1);
																												num18 = 8;
																												continue;
																											case 16:
																												if (_response_5__6[0] != 0)
																												{
																													num18 = 13;
																													continue;
																												}
																												goto IL_0aa1;
																											case 15:
																												goto IL_0aa1;
																											case 0:
																												__u__1 = default;
																												num18 = 3;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
																												{
																													num18 = 20;
																												}
																												continue;
																											case 17:
																												val2 = (IIbV0xbIja(_stream_5__5, _response_5__6, (_timeout_5__2).Token)).ConfigureAwait(false);
																												num18 = 1;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
																												{
																													num18 = 14;
																												}
																												continue;
																											case 9:
																												__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																												num18 = 12;
																												continue;
																											case 1:
																												goto IL_0b78;
																											case 2:
																												goto end_IL_08d2;
																											case 7:
																											case 13:
																											case 14:
																												goto IL_0bab;
																											}
																											if (num17 != 25)
																											{
																												if (num17 == 1005)
																												{
																													goto IL_08f2;
																												}
																												goto IL_0aa1;
																											}
																											if ((_u__).IsCompleted)
																											{
																												goto IL_0a13;
																											}
																											goto IL_0b09;
																											IL_0bab:
																											throw new AJ6x61VDYw2THcvPjVa();
																											IL_0a13:
																											(_u__).GetResult();
																											num18 = 16;
																											continue;
																											IL_0aa1:
																											if (_response_5__6[1] == 0)
																											{
																												num18 = 4;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																												{
																													num18 = 11;
																												}
																												continue;
																											}
																											goto IL_0bab;
																											continue;
																											end_IL_08f6:
																											break;
																										}
																										goto IL_0a40;
																										IL_0b09:
																										num16 = 6;
																										goto IL_08ee;
																										IL_0a40:
																										_u__ = __u__1;
																										num18 = 0;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
																										{
																											num18 = 18;
																										}
																										goto IL_08f6;
																										end_IL_08d2:;
																									}
																									finally
																									{
																										if (num4 < 0)
																										{
																											int num19 = 1;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
																											{
																												num19 = 5;
																											}
																											while (true)
																											{
																												switch (num19)
																												{
																												default:
																													if (num20 == 989)
																													{
																														num19 = num20;
																														continue;
																													}
																													break;
																												case 1:
																													break;
																												case 0:
																													goto end_IL_0bef;
																												}
																												System.Array.Clear(_response_5__6, 0, _response_5__6.Length);
																												num19 = 0;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
																												{
																													num19 = 7;
																												}
																												continue;
																												end_IL_0bef:
																												break;
																											}
																										}
																									}
																									goto end_IL_04a0;
																								case 26:
																									__u__1 = _u__;
																									num13 = 17;
																									continue;
																								case 7:
																									num4 = (__1__state = 4);
																									num13 = 26;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
																									{
																										num13 = 27;
																									}
																									continue;
																								case 20:
																									__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																									num13 = 18;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																									{
																										num13 = 1;
																									}
																									continue;
																								case 13:
																								case 49:
																									(_u__).GetResult();
																									num15 = 57;
																									goto IL_04cd;
																								case 35:
																									goto IL_0cd0;
																								case 29:
																									_u__ = val2;
																									num13 = 12;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
																									{
																										num13 = 55;
																									}
																									continue;
																								case 17:
																									__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																									num13 = 24;
																									continue;
																								case 5:
																								case 47:
																									(_u__).GetResult();
																									num13 = 23;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																									{
																										num13 = 57;
																									}
																									continue;
																								case 21:
																									val2 = (os8VcoHP2o(_stream_5__5, gameId, (_timeout_5__2).Token)).ConfigureAwait(false);
																									num13 = 2;
																									continue;
																								case 45:
																									__u__1 = _u__;
																									num15 = 48;
																									goto IL_04cd;
																								case 40:
																									(_u__).GetResult();
																									num13 = 26;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																									{
																										num13 = 19;
																									}
																									continue;
																								case 8:
																									if (!(_u__).IsCompleted)
																									{
																										num13 = 39;
																										continue;
																									}
																									goto case 40;
																								case 34:
																									if ((_u__).IsCompleted)
																									{
																										num13 = 20;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
																										{
																											num13 = 37;
																										}
																										continue;
																									}
																									goto case 7;
																								case 0:
																									__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																									num13 = 41;
																									continue;
																								case 27:
																									num4 = (__1__state = 2);
																									num13 = 3;
																									continue;
																								case 23:
																									val2 = ((_stream_5__5).FlushAsync((_timeout_5__2).Token)).ConfigureAwait(false);
																									num13 = 40;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
																									{
																										num13 = 33;
																									}
																									continue;
																								case 12:
																									if ((_u__).IsCompleted)
																									{
																										num13 = 5;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
																										{
																											num13 = 3;
																										}
																										continue;
																									}
																									goto case 46;
																								case 46:
																									num4 = (__1__state = 3);
																									num13 = 36;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
																									{
																										num13 = 22;
																									}
																									continue;
																								case 11:
																									_u__ = val2;
																									num13 = 36;
																									continue;
																								case 43:
																									goto end_IL_04a0;
																									IL_04cd:
																									num14 = num15;
																									goto IL_04d1;
																									IL_04d1:
																									num13 = num14;
																									continue;
																								}
																								break;
																							}
																							goto case 3;
																							IL_0cd0:
																							_u__ = __u__1;
																							num13 = 38;
																							goto IL_04d5;
																							IL_083a:
																							num13 = 16;
																							goto IL_04d5;
																							IL_0772:
																							_u__ = __u__1;
																							num13 = 6;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
																							{
																								num13 = 52;
																							}
																							goto IL_04d5;
																							IL_060f:
																							_u__ = __u__1;
																							num13 = 28;
																							goto IL_04d5;
																							end_IL_04a0:
																							break;
																						}
																					}
																					finally
																					{
																						if (num4 < 0)
																						{
																							int num21 = 6;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
																							{
																								num21 = 3;
																							}
																							while (true)
																							{
																								switch (num21)
																								{
																								default:
																									if (num22 == 991)
																									{
																										num21 = num22;
																										continue;
																									}
																									goto case 1;
																								case 0:
																									break;
																								case 1:
																									(_stream_5__5).Dispose();
																									num21 = 2;
																									continue;
																								case 3:
																									if (_stream_5__5 == null)
																									{
																										num21 = 2;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
																										{
																											num21 = 0;
																										}
																										continue;
																									}
																									goto case 1;
																								case 2:
																									break;
																								}
																								break;
																							}
																						}
																					}
																					goto case 8;
																				case 0:
																					_stream_5__5 = (_client_5__3).GetStream();
																					num11 = 7;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
																					{
																						num11 = 1;
																					}
																					continue;
																				case 17:
																					break;
																				case 10:
																					(_u__).GetResult();
																					num11 = 10;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																					{
																						num11 = 0;
																					}
																					continue;
																				case 1:
																				case 18:
																					num11 = 16;
																					continue;
																				case 12:
																					__u__1 = _u__;
																					num11 = 13;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
																					{
																						num11 = 6;
																					}
																					continue;
																				case 5:
																					num4 = (__1__state = 0);
																					num11 = 12;
																					continue;
																				case 4:
																					__u__1 = default;
																					num11 = 14;
																					continue;
																				case 11:
																					goto IL_115a;
																				case 15:
																					_response_5__6 = null;
																					num11 = 13;
																					continue;
																				case 3:
																					_u__ = val2;
																					num11 = 11;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
																					{
																						num11 = 9;
																					}
																					continue;
																				case 2:
																				case 19:
																					_u__ = __u__1;
																					num11 = 4;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
																					{
																						num11 = 26;
																					}
																					continue;
																				case 14:
																					num4 = (__1__state = -1);
																					num11 = 10;
																					continue;
																				case 9:
																					if (!(_u__).IsCompleted)
																					{
																						goto case 5;
																					}
																					goto IL_1231;
																				case 8:
																					_stream_5__5 = null;
																					num11 = 27;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
																					{
																						num11 = 15;
																					}
																					continue;
																				case 6:
																					__t__builder.AwaitUnsafeOnCompleted<object, _AuthenticateAsync_d__5_1>(ref _u__, ref this);
																					num11 = 7;
																					continue;
																				case 13:
																					goto end_IL_0402;
																				}
																				break;
																			}
																			goto IL_109b;
																			IL_1231:
																			int num23 = 27;
																			goto IL_041d;
																			IL_115a:
																			val2 = ((_client_5__3).ConnectAsync(IPAddress.Loopback, controlPort)).ConfigureAwait(false);
																			num11 = 3;
																			goto IL_0425;
																			IL_109b:
																			if ((uint)(num4 - 1) <= 4u)
																			{
																				num23 = 18;
																				goto IL_041d;
																			}
																			goto IL_115a;
																			IL_041d:
																			num12 = num23;
																			goto IL_0421;
																			end_IL_0402:;
																		}
																		catch (object obj) when (((Func<bool>)delegate
																		{
																			// Could not convert BlockContainer to single expression
																			if (!(obj is global::System.Exception))
																			{
																				num24 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
																				{
																					num24 = 6;
																				}
																			}
																			else
																			{
																				num24 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
																				{
																					num24 = 0;
																				}
																			}
																			while (true)
																			{
																				switch (num24)
																				{
																				default:
																					if (num25 == 989)
																					{
																						goto IL_12ef;
																					}
																					goto case 1;
																				case 1:
																					result = 0;
																					break;
																				case 0:
																					result = ((_timeout_5__2).IsCancellationRequested ? 1 : 0);
																					break;
																				}
																				break;
																				IL_12ef:
																				num24 = num25;
																			}
																			return (byte)result != 0;
																		}).Invoke())
																		{
																			int num26 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
																			{
																				num26 = 0;
																			}
																			while (true)
																			{
																				switch (num26)
																				{
																				default:
																					if (num27 == 988)
																					{
																						goto IL_137c;
																					}
																					break;
																				case 0:
																					break;
																				}
																				break;
																				IL_137c:
																				num26 = num27;
																			}
																			throw (_timeout_5__2).Token;
																		}
																		break;
																	case 1:
																		num10 = 2;
																		continue;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															finally
															{
																if (num4 >= 0)
																{
																	_ = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
																	{
																		_ = 8;
																	}
																	goto IL_1416;
																}
																goto IL_143a;
																IL_1416:
																int num29;
																while (true)
																{
																	switch (num29)
																	{
																	default:
																		if (num30 == 990)
																		{
																			goto IL_1412;
																		}
																		break;
																	case 2:
																		break;
																	case 1:
																		goto end_IL_1416;
																	case 0:
																		goto end_IL_1416;
																	}
																	goto IL_143a;
																	IL_1412:
																	num29 = num30;
																	continue;
																	end_IL_1416:
																	break;
																}
																goto end_IL_13dd;
																IL_143a:
																_ = _cancellation_5__4;
																num29 = 2;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
																{
																	num29 = 0;
																}
																goto IL_1416;
																end_IL_13dd:;
															}
															goto end_IL_02b5;
															IL_030b:
															(_client_5__3).NoDelay = true;
															num8 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
															{
																num8 = 1;
															}
															continue;
															end_IL_02d9:
															break;
														}
														goto IL_0386;
														IL_0386:
														int num31 = 10;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
														{
															num31 = 8;
														}
														num9 = num31;
														goto IL_02d5;
														end_IL_02b5:;
													}
													finally
													{
														int num32;
														if (num4 >= 0)
														{
															num32 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
															{
																num32 = 8;
															}
															goto IL_14af;
														}
														goto IL_14d7;
														IL_14af:
														while (true)
														{
															switch (num32)
															{
															default:
																if (num33 == 991)
																{
																	num32 = num33;
																	continue;
																}
																goto end_IL_14af;
															case 0:
																break;
															case 2:
																goto end_IL_14af;
															case 1:
																(_client_5__3).Dispose();
																num32 = 3;
																continue;
															case 3:
																goto end_IL_14af;
															}
															goto IL_14d7;
															continue;
															end_IL_14af:
															break;
														}
														goto end_IL_1476;
														IL_14d7:
														if (_client_5__3 != null)
														{
															num32 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
															{
																num32 = 1;
															}
															goto IL_14af;
														}
														end_IL_1476:;
													}
													goto end_IL_01f6;
													IL_0257:
													(_timeout_5__2).CancelAfter(cSLiWOVVy4rsJXg8pqG.NgUVJMSTJm);
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
													{
														num6 = 0;
													}
													continue;
													end_IL_021a:
													break;
												}
												goto IL_024c;
												IL_0216:
												num6 = num7;
												goto IL_021a;
												end_IL_01f6:;
											}
											finally
											{
												int num34;
												if (num4 >= 0)
												{
													num34 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
													{
														num34 = 0;
													}
													goto IL_1579;
												}
												goto IL_15a1;
												IL_1579:
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
														goto end_IL_1579;
													case 3:
														break;
													case 0:
														goto end_IL_1579;
													case 2:
														(_timeout_5__2).Dispose();
														num34 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
														{
															num34 = 7;
														}
														continue;
													case 1:
														goto end_IL_1579;
													}
													goto IL_15a1;
													continue;
													end_IL_1579:
													break;
												}
												goto end_IL_1540;
												IL_15a1:
												if (_timeout_5__2 != null)
												{
													num34 = 2;
													goto IL_1579;
												}
												end_IL_1540:;
											}
											goto end_IL_0132;
										}
										IL_012e:
										num5 = num37;
										continue;
									}
									goto IL_0164;
									continue;
									end_IL_0132:
									break;
								}
							}
							catch (global::System.Exception ex)
							{
								int num38 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num38 = 3;
								}
								while (true)
								{
									int num40;
									switch (num38)
									{
									case 2:
										return;
									default:
										switch (num39)
										{
										default:
											return;
										case 992:
											break;
										case 12:
											(__t__builder).SetException(ex);
											num38 = 2;
											goto end_IL_1628;
										}
										goto IL_1624;
									case 1:
										_client_5__3 = null;
										num40 = 4;
										goto IL_1620;
									case 4:
										_cancellation_5__4 = default;
										num40 = 12;
										goto IL_1620;
									case 3:
										__1__state = -2;
										num38 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
										{
											num38 = 1;
										}
										break;
									case 0:
										{
											_timeout_5__2 = null;
											num38 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
											{
												num38 = 1;
											}
											break;
										}
										IL_1624:
										num38 = num39;
										break;
										IL_1620:
										num39 = num40;
										goto IL_1624;
										end_IL_1628:
										break;
									}
								}
							}
							goto case 4;
						case 7:
							_timeout_5__2 = null;
							num = 14;
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
						(__t__builder).SetStateMachine(stateMachine);
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 2:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
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
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool dt4kpf90B8j5xnnNL7hE()
		{
			return mhuiv990Iix23sBvcfKt == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object m5gH1k90gkxAEkPZZaC0()
		{
			return mhuiv990Iix23sBvcfKt;
		}
	}

	private static readonly TimeSpan soCVyyrSas;

	private static readonly object uEKVWbvHgr;

	private readonly TimeSpan NgUVJMSTJm;

	internal static object ua5T0PZVxZuY7JP02JNT;

	[MethodImpl((MethodImplOptions)8)]
	internal CSLiWOVVy4rsJXg8pqG()
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected I4, but got O
		//IL_0036->IL0048: Incompatible stack types: I4 vs O
		//IL_0041->IL0048: Incompatible stack types: I4 vs O
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		CSLiWOVVy4rsJXg8pqG(soCVyyrSas);
		object obj = 0;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
		{
			obj = 1;
		}
		object obj2 = default;
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal CSLiWOVVy4rsJXg8pqG(TimeSpan timeout)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task AuthenticateAsync(int controlPort, string gameId, string userId, string serverHash, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void njuVSHrMCP(int controlPort, object gameId, object userId, object serverHash)
	{
		//IL_000c: Expected O, but got I4
		//IL_004d: Expected I4, but got O
		//IL_0138: Expected O, but got I4
		//IL_00e7: Expected O, but got I4
		//IL_014c->IL0010: Incompatible stack types: I4 vs O
		//IL_011a->IL0010: Incompatible stack types: I4 vs O
		//IL_00e4->IL0010: Incompatible stack types: I4 vs O
		//IL_0135->IL0010: Incompatible stack types: I4 vs O
		//IL_0157->IL0010: Incompatible stack types: I4 vs O
		//IL_0102->IL0010: Incompatible stack types: I4 vs O
		int num = 4;
		object obj3 = default;
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
						if ((nint)obj != 20)
						{
							if ((nint)obj == 1001)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						return;
					case 10:
						if (CDpQapkdEaKhuI1fey5.UOpkOQFtnl(serverHash))
						{
							num = 20;
							break;
						}
						goto case 0;
					case 4:
						if (controlPort >= 1)
						{
							num = 3;
							break;
						}
						goto case 13;
					case 0:
					case 2:
					case 6:
					case 12:
						throw new CgxTSxVZkBNLYy7vkSL("认证组件请求无效");
					case 3:
						if (controlPort <= 65535)
						{
							obj2 = 9;
							continue;
						}
						goto case 13;
					case 13:
						obj3 = 1;
						num = 7;
						break;
					case 7:
					case 11:
						if (obj3 != null)
						{
							obj2 = 6;
							continue;
						}
						goto case 5;
					case 1:
						if (!CDpQapkdEaKhuI1fey5.uuEk5lHPgL(userId, 32, digitsOnly: true))
						{
							obj2 = 2;
							continue;
						}
						goto case 10;
					case 5:
						if (!CDpQapkdEaKhuI1fey5.uuEk5lHPgL(gameId, 256, digitsOnly: false))
						{
							obj2 = 12;
							continue;
						}
						goto case 1;
					case 8:
					case 9:
						obj3 = 0;
						obj2 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task os8VcoHP2o(object stream, object value, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task IIbV0xbIja(object stream, object buffer, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void xGbV81s5Rq(object buffer, int value)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0089->IL0010: Incompatible stack types: I4 vs O
		//IL_0062->IL0010: Incompatible stack types: I4 vs O
		//IL_0094->IL0010: Incompatible stack types: I4 vs O
		//IL_006d->IL0010: Incompatible stack types: I4 vs O
		//IL_00af->IL0010: Incompatible stack types: I4 vs O
		//IL_00ba->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
						if ((nint)obj == 10)
						{
							((sbyte[])buffer)[1] = (sbyte)(byte)(value >> 8);
							obj2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto end_IL_0010;
					case 1:
						((sbyte[])buffer)[2] = (sbyte)(byte)(value >> 16);
						obj2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						((sbyte[])buffer)[3] = (sbyte)(byte)(value >> 24);
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							obj2 = 3;
						}
						continue;
					case 2:
						break;
					case 3:
						return;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if ((nint)obj != 991)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			((sbyte[])buffer)[0] = (sbyte)(byte)value;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		soCVyyrSas = System.TimeSpan.FromSeconds(10.0);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool aDsuq9ZVFlYYqpC5svvQ()
	{
		return ua5T0PZVxZuY7JP02JNT == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static CSLiWOVVy4rsJXg8pqG fZQUIIZVsCQopAT8sSQi()
	{
		return (CSLiWOVVy4rsJXg8pqG)ua5T0PZVxZuY7JP02JNT;
	}
}

using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using QJ21CkfSL8itNSePE2uS;
using fDAldojjppXrctUVYOJn;

namespace ScULqvXq3TjcWivXagrC;

sealed class u1lLwgXq1FLYtLiTx61U : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AuthenticateAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<ValueTuple<string, string>> __t__builder;

		public u1lLwgXq1FLYtLiTx61U __4__this;

		public string sauthJson;

		public CancellationToken cancellationToken;

		private StringContent _content_5__2;

		private HttpResponseMessage _response_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object fyGxlVDVkXqUBaDuDKv1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0d21: Expected O, but got Unknown
			//IL_0d8f: Expected O, but got Unknown
			//IL_0ecc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Expected native int or pointer, but got O
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0419: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0478: Expected O, but got Ref
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_065e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_075f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0765: Unknown result type (might be due to invalid IL or missing references)
			//IL_0771: Expected O, but got Ref
			//IL_06e9: Expected O, but got I4
			//IL_071e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0728: Expected I4, but got Unknown
			//IL_0785: Unknown result type (might be due to invalid IL or missing references)
			//IL_078a: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0910: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_09bd: Expected O, but got I4
			//IL_0a04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e96->IL0e2e: Incompatible stack heights: 3 vs 1
			//IL_0ea1->IL0e2e: Incompatible stack heights: 3 vs 1
			//IL_0ed9->IL0008: Incompatible stack heights: 3 vs 1
			//IL_01af->IL01cc: Incompatible stack heights: 1 vs 3
			//IL_01e1->IL0223: Incompatible stack heights: 2 vs 0
			//IL_01ba->IL01cc: Incompatible stack heights: 1 vs 3
			//IL_04ee->IL029e: Incompatible stack heights: 4 vs 3
			//IL_066a->IL053a: Incompatible stack heights: 4 vs 3
			//IL_09c7->IL07a0: Incompatible stack types: I4 vs O
			//IL_07a4->IL07a4: Incompatible stack heights: 3 vs 2
			int num3 = default;
			int num28 = default;
			u1lLwgXq1FLYtLiTx61U u1lLwgXq1FLYtLiTx61U2 = default;
			int num22 = default;
			int num19 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val4 = default;
			HttpResponseMessage response_5__ = default;
			int num15 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<string> val3 = default;
			JsonDocument val = default;
			int num11 = default;
			int num9 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			string text = default;
			v8S9tafSfKHe7BkHpBrA challenge = default;
			int num13 = default;
			int num17 = default;
			int num21 = default;
			int num24 = default;
			int num26 = default;
			int num30 = default;
			while (true)
			{
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 11)
							{
								if (num == 992)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							return;
						case 1:
							__1__state = -2;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							try
							{
								int num4;
								if ((uint)num3 > 1u)
								{
									num4 = 2;
									goto IL_0096;
								}
								goto IL_013e;
								IL_013e:
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
								{
									num4 = 0;
								}
								goto IL_0096;
								IL_0096:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num28 != 10)
										{
											if (num28 == 990)
											{
												goto IL_0092;
											}
											goto case 1;
										}
										if (string.IsNullOrWhiteSpace(sauthJson))
										{
											num4 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
											{
												num4 = 1;
											}
											continue;
										}
										break;
									case 2:
									{
										System.ObjectDisposedException.ThrowIf(u1lLwgXq1FLYtLiTx61U2.Gi8XqiRnX1R, u1lLwgXq1FLYtLiTx61U2);
										int num27 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
										{
											num27 = 10;
										}
										num28 = num27;
										goto IL_0092;
									}
									case 1:
										_ = "基岩 SAuth 不能为空";
										throw new global::System.Exception("sauthJson");
									case 0:
										{
											try
											{
												if ((uint)num3 <= 1u)
												{
													_ = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
													{
														_ = 1;
													}
													goto IL_01cc;
												}
												goto IL_0223;
												IL_01cc:
												int num5;
												while (true)
												{
													switch (num5)
													{
													default:
														if (num22 == 991)
														{
															num5 = num22;
															continue;
														}
														goto case 1;
													case 1:
													case 3:
														num5 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
														{
															num5 = 5;
														}
														continue;
													case 2:
														break;
													case 0:
														try
														{
															int num6;
															if (num3 == 0)
															{
																num6 = 3;
																goto IL_029e;
															}
															goto IL_043a;
															IL_043a:
															if (num3 != 1)
															{
																num6 = 4;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
																{
																	num6 = 13;
																}
																goto IL_029e;
															}
															goto IL_0497;
															IL_029e:
															while (true)
															{
																switch (num6)
																{
																default:
																	if (num19 != 22)
																	{
																		if (num19 == 1002)
																		{
																			goto IL_029a;
																		}
																		goto case 1;
																	}
																	goto IL_0473;
																case 2:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _AuthenticateAsync_d__5>(ref _u__2, ref this);
																	num6 = 13;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																	{
																		num6 = 10;
																	}
																	continue;
																case 1:
																	if (&_u__2 == null)
																	{
																		num6 = 11;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
																		{
																			num6 = 20;
																		}
																		continue;
																	}
																	goto IL_0473;
																case 13:
																	return;
																case 11:
																	num3 = (__1__state = 0);
																	num6 = 8;
																	continue;
																case 14:
																	__u__1 = default;
																	num6 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
																	{
																		num6 = 19;
																	}
																	continue;
																case 8:
																	__u__1 = _u__2;
																	num6 = 14;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
																	{
																		num6 = 2;
																	}
																	continue;
																case 7:
																{
																	num3 = (__1__state = -1);
																	int num18 = 22;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
																	{
																		num18 = 18;
																	}
																	num19 = num18;
																	goto IL_029a;
																}
																case 9:
																	_u__2 = val4;
																	num6 = 21;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
																	{
																		num6 = 1;
																	}
																	continue;
																case 10:
																	break;
																case 12:
																	_response_5__3 = response_5__;
																	num6 = 6;
																	continue;
																case 6:
																	goto IL_0497;
																case 4:
																	(u1lLwgXq1FLYtLiTx61U2.G1xXqGeokcZ).PostAsync("https://mgbsdk.matrix.netease.com/x19/sdk/uni_sauth", (HttpContent)(object)_content_5__2, cancellationToken);
																	val4 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																	_ = 9;
																	continue;
																case 0:
																case 3:
																	_u__2 = __u__1;
																	num6 = 14;
																	continue;
																case 5:
																	{
																		try
																		{
																			int num7;
																			if (num3 != 1)
																			{
																				num7 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																				{
																					num7 = 11;
																				}
																				goto IL_053a;
																			}
																			goto IL_066a;
																			IL_053a:
																			while (true)
																			{
																				switch (num7)
																				{
																				default:
																					if (num15 != 19)
																					{
																						if (num15 == 999)
																						{
																							goto IL_0536;
																						}
																						goto case 6;
																					}
																					return;
																				case 5:
																					_u__ = val3;
																					num7 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
																					{
																						num7 = 10;
																					}
																					continue;
																				case 11:
																					__u__2 = default;
																					num7 = 4;
																					continue;
																				case 10:
																					__u__2 = _u__;
																					num7 = 8;
																					continue;
																				case 8:
																				{
																					__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _AuthenticateAsync_d__5>(ref _u__, ref this);
																					int num14 = 18;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
																					{
																						num14 = 19;
																					}
																					num15 = num14;
																					goto IL_0536;
																				}
																				case 3:
																					((_response_5__3).Content).ReadAsStringAsync(cancellationToken);
																					val3 = (ConfiguredTaskAwaitable<string>)0;
																					_ = 5;
																					continue;
																				case 2:
																					break;
																				case 6:
																					num3 = (__1__state = 1);
																					num7 = 10;
																					continue;
																				case 4:
																					num3 = (__1__state = -1);
																					num7 = 7;
																					continue;
																				case 0:
																					if (&_u__ != null)
																					{
																						num7 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																						{
																							num7 = 15;
																						}
																						continue;
																					}
																					goto case 6;
																				case 1:
																				case 7:
																					if (!(_response_5__3).IsSuccessStatusCode)
																					{
																						_ = 21;
																						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																						(defaultInterpolatedStringHandler2).AppendLiteral("基岩 MgbSdk 认证失败（HTTP ");
																						defaultInterpolatedStringHandler2.AppendFormatted<int>((int)(_response_5__3).StatusCode);
																						(defaultInterpolatedStringHandler2).AppendLiteral("）");
																						throw (defaultInterpolatedStringHandler2).ToStringAndClear();
																					}
																					val = System.Text.Json.JsonDocument.Parse((string)(&_u__), default(JsonDocumentOptions));
																					num7 = 9;
																					continue;
																				case 9:
																					{
																						try
																						{
																							JsonElement root = (val).RootElement;
																							int num8 = 3;
																							while (true)
																							{
																								object obj;
																								int num10;
																								switch (num8)
																								{
																								default:
																									if (num11 != 18)
																									{
																										if (num11 == 998)
																										{
																											goto IL_07a4;
																										}
																										goto case 10;
																									}
																									goto end_IL_07a8;
																								case 6:
																								{
																									if (num9 != 200)
																									{
																										num8 = 17;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
																										{
																											num8 = 0;
																										}
																										continue;
																									}
																									obj = FHBXqE034ad(root, "aid", string.Empty);
																									string text2 = FHBXqE034ad(root, "sdkuid", string.Empty);
																									if (string.IsNullOrWhiteSpace((string)obj) || string.IsNullOrWhiteSpace(text2))
																									{
																										break;
																									}
																									ValueTuple<string, string> val2 = (ValueTuple<string, string>)text2;
																									num10 = 18;
																									goto IL_07a0;
																								}
																								case 2:
																									(defaultInterpolatedStringHandler).AppendLiteral("（code=");
																									num8 = 3;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
																									{
																										num8 = 1;
																									}
																									continue;
																								case 7:
																									if (!v8S9tafSfKHe7BkHpBrA.DhCfSjXshTa(num9, text, out challenge))
																									{
																										num8 = 5;
																										continue;
																									}
																									goto case 9;
																								case 1:
																									defaultInterpolatedStringHandler.AppendFormatted<int>(num9);
																									num8 = 8;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																									{
																										num8 = 14;
																									}
																									continue;
																								case 8:
																									(defaultInterpolatedStringHandler).AppendLiteral("）");
																									num8 = 10;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
																									{
																										num8 = 2;
																									}
																									continue;
																								case 0:
																									text = FHBXqE034ad(root, "msg", FHBXqE034ad(root, "message", "基岩 MgbSdk 认证失败"));
																									num8 = 7;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
																									{
																										num8 = 8;
																									}
																									continue;
																								case 4:
																									(defaultInterpolatedStringHandler).AppendFormatted(text);
																									num8 = 1;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
																									{
																										num8 = 2;
																									}
																									continue;
																								case 9:
																									throw challenge;
																								case 5:
																									defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
																									num10 = 4;
																									obj = 7;
																									goto IL_07a0;
																								case 3:
																									num9 = xhGXqvWbm4X(root, "code");
																									num8 = 6;
																									continue;
																								case 10:
																									{
																										throw (defaultInterpolatedStringHandler).ToStringAndClear();
																									}
																									IL_07a4:
																									num8 = num11;
																									continue;
																									IL_07a0:
																									num11 = num10;
																									goto IL_07a4;
																								}
																								throw new global::System.Exception("基岩 MgbSdk 认证响应缺少账号标识");
																								continue;
																								end_IL_07a8:
																								break;
																							}
																						}
																						finally
																						{
																							int num12;
																							if (num3 >= 0)
																							{
																								num12 = 1;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																								{
																									num12 = 2;
																								}
																								goto IL_0aeb;
																							}
																							goto IL_0b62;
																							IL_0aeb:
																							while (true)
																							{
																								switch (num12)
																								{
																								default:
																									if (num13 == 991)
																									{
																										num12 = num13;
																										continue;
																									}
																									goto end_IL_0aeb;
																								case 3:
																									(val).Dispose();
																									num12 = 1;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
																									{
																										num12 = 0;
																									}
																									continue;
																								case 1:
																									goto end_IL_0aeb;
																								case 2:
																									break;
																								case 0:
																									goto end_IL_0aeb;
																								}
																								goto IL_0b62;
																								continue;
																								end_IL_0aeb:
																								break;
																							}
																							goto end_IL_0ab2;
																							IL_0b62:
																							if (val != null)
																							{
																								num12 = 3;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
																								{
																									num12 = 6;
																								}
																								goto IL_0aeb;
																							}
																							end_IL_0ab2:;
																						}
																						goto end_IL_053a;
																					}
																					IL_0536:
																					num7 = num15;
																					continue;
																				}
																				goto IL_066a;
																				continue;
																				end_IL_053a:
																				break;
																			}
																			goto end_IL_0501;
																			IL_066a:
																			_u__ = __u__2;
																			num7 = 11;
																			goto IL_053a;
																			end_IL_0501:;
																		}
																		finally
																		{
																			if (num3 < 0)
																			{
																				int num16 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
																				{
																					num16 = 1;
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
																						(_response_5__3).Dispose();
																						num16 = 7;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
																						{
																							num16 = 0;
																						}
																						continue;
																					case 1:
																						break;
																					case 0:
																						goto end_IL_0bc2;
																					}
																					if (_response_5__3 != null)
																					{
																						num16 = 2;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
																						{
																							num16 = 0;
																						}
																						continue;
																					}
																					break;
																					continue;
																					end_IL_0bc2:
																					break;
																				}
																			}
																		}
																		goto end_IL_027b;
																	}
																	IL_029a:
																	num6 = num19;
																	continue;
																}
																break;
																IL_0473:
																response_5__ = (HttpResponseMessage)(object)(&_u__2);
																num6 = 14;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																{
																	num6 = 12;
																}
															}
															goto IL_043a;
															IL_0497:
															num6 = 5;
															goto IL_029e;
															end_IL_027b:;
														}
														finally
														{
															if (num3 < 0)
															{
																int num20 = 6;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
																{
																	num20 = 2;
																}
																while (true)
																{
																	switch (num20)
																	{
																	default:
																		if (num21 == 991)
																		{
																			num20 = num21;
																			continue;
																		}
																		break;
																	case 3:
																		(_content_5__2).Dispose();
																		num20 = 4;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																		{
																			num20 = 0;
																		}
																		continue;
																	case 2:
																		if (_content_5__2 == null)
																		{
																			num20 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																			{
																				num20 = 4;
																			}
																			continue;
																		}
																		goto case 3;
																	case 1:
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
														}
														goto end_IL_01cc;
													}
													goto IL_0223;
													continue;
													end_IL_01cc:
													break;
												}
												goto end_IL_0193;
												IL_0223:
												_ = sauthJson;
												global::System.Runtime.CompilerServices.Unsafe.Write(&((_AuthenticateAsync_d__5*)(nint)System.Text.Encoding.UTF8)->_content_5__2, "application/json");
												num5 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
												{
													num5 = 7;
												}
												goto IL_01cc;
												end_IL_0193:;
											}
											catch (JsonException ex)
											{
												JsonException ex2 = ex;
												int num23 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
												{
													num23 = 0;
												}
												while (true)
												{
													switch (num23)
													{
													default:
														if (num24 == 988)
														{
															goto IL_0d4e;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_0d4e:
													num23 = num24;
												}
												_ = "基岩 MgbSdk 认证响应格式无效";
												throw ex2;
											}
											catch (HttpRequestException ex3)
											{
												HttpRequestException ex4 = ex3;
												int num25 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
												{
													num25 = 0;
												}
												while (true)
												{
													switch (num25)
													{
													default:
														if (num26 == 988)
														{
															goto IL_0dbc;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_0dbc:
													num25 = num26;
												}
												_ = "基岩 MgbSdk 认证请求失败";
												throw ex4;
											}
											goto end_IL_0096;
										}
										IL_0092:
										num4 = num28;
										continue;
									}
									goto IL_013e;
									continue;
									end_IL_0096:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num29 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num29 = 4;
								}
								while (true)
								{
									switch (num29)
									{
									default:
										if (num30 == 990)
										{
											num29 = num30;
											break;
										}
										return;
									case 1:
										__1__state = -2;
										num29 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num29 = 0;
										}
										break;
									case 2:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											_ = 7;
										}
										break;
									case 0:
										return;
									}
								}
							}
							goto case 1;
						case 0:
							break;
						case 3:
							u1lLwgXq1FLYtLiTx61U2 = __4__this;
							num2 = 2;
							continue;
						case 4:
							num3 = __1__state;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num2 = 3;
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
				_ = __t__builder;
				_ = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = __t__builder;
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
						case 1:
							goto end_IL_000e;
						case 2:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
							{
								num3 = 1;
							}
							continue;
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 6;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
				{
					num = 5;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool jRWMK4DVVRQFMlFls7Ss()
		{
			return fyGxlVDVkXqUBaDuDKv1 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object pfFnXlDVYA725EbGQEME()
		{
			return fyGxlVDVkXqUBaDuDKv1;
		}
	}

	private readonly object G1xXqGeokcZ;

	private bool Gi8XqiRnX1R;

	internal static object DIWbY7ZxubgZfkDRsM8j;

	[MethodImpl((MethodImplOptions)8)]
	internal u1lLwgXq1FLYtLiTx61U()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<ValueTuple<string, string>> AuthenticateAsync(string sauthJson, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int xhGXqvWbm4X(JsonElement root, object propertyName)
	{
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Invalid comparison between Unknown and I4
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Invalid comparison between Unknown and I4
		int num = 10;
		JsonValueKind val = default;
		int result = default;
		int num5 = default;
		int num4 = default;
		JsonElement val2 = default;
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						if ((int)val != 3)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 12;
					case 3:
						result = num5;
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 8;
						}
						continue;
					case 6:
						result = num4;
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 2;
						}
						continue;
					case 10:
						if ((root).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 9;
							continue;
						}
						goto case 11;
					case 0:
					case 1:
						result = -2147483648;
						num3 = 5;
						continue;
					case 2:
					case 5:
					case 8:
						return result;
					case 4:
						if (!(val2).TryGetInt32(out num5))
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 3;
					case 11:
						return -2147483648;
					case 9:
						val = (val2).ValueKind;
						num = 19;
						break;
					case 7:
						if ((int)val == 4)
						{
							num = 4;
							break;
						}
						goto case 0;
					case 12:
						if (int.TryParse((val2).GetString(), out num4))
						{
							num3 = 6;
							continue;
						}
						goto case 0;
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
	private static string FHBXqE034ad(JsonElement root, object propertyName, object fallback)
	{
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Invalid comparison between Unknown and I4
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Invalid comparison between Unknown and I4
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		JsonValueKind val = default;
		JsonElement val2 = default;
		string result = default;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 18)
						{
							goto end_IL_0010;
						}
						goto case 7;
					case 6:
						if ((int)val != 3)
						{
							num3 = 10;
							continue;
						}
						goto case 11;
					case 2:
						return (string)fallback;
					case 0:
						val = (val2).ValueKind;
						num3 = 6;
						continue;
					case 3:
					case 8:
						break;
					case 4:
						result = (val2).GetRawText();
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
					case 9:
						return result;
					case 11:
						obj = (val2).GetString();
						if (obj == null)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto IL_0192;
					case 1:
						if ((root).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 2;
					case 10:
						if ((int)val != 4)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 4;
					case 5:
						{
							obj = fallback;
							goto IL_0192;
						}
						IL_0192:
						result = (string)obj;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
						{
							num3 = 11;
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
			while (num2 == 999);
			result = (string)fallback;
			num = 15;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
			{
				num = 18;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_000c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						return;
					case 0:
						return;
					case 1:
						goto IL_0099;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						(G1xXqGeokcZ).Dispose();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 2;
						}
						continue;
					}
					goto IL_000c;
					IL_0099:
					if (!Gi8XqiRnX1R)
					{
						break;
					}
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num3 = 6;
					}
				}
				break;
			}
			Gi8XqiRnX1R = true;
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
			{
				num = 9;
			}
		}
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
					case 2:
						goto end_IL_000e;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
						{
							num3 = 4;
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
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 7;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool whl5q7Zxanwip0pTmCd0()
	{
		return DIWbY7ZxubgZfkDRsM8j == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static u1lLwgXq1FLYtLiTx61U hqVQJeZx1p9ev72dlDdj()
	{
		return (u1lLwgXq1FLYtLiTx61U)DIWbY7ZxubgZfkDRsM8j;
	}
}

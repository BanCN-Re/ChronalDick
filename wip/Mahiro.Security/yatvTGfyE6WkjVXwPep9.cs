using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using A0e1b7fyvTGRhAShHWec;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using D92aI6fc1JJ4bAaEjL8U;
using SxsGGAfLOxcpiFNutOL1;
using Vl4jDMX56cFYkU2Jw1oo;
using WMO32gy5EZANSQKlHAx;
using fDAldojjppXrctUVYOJn;
using fYjvfFf1p8udxK21D6pd;
using iM65eRXiKVWZgs63pZCd;

namespace WREoxkfy2BpdTWOuUftE;

internal class yatvTGfyE6WkjVXwPep9
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_94
	{
		public static __c_94 __9;

		public static Func<ValueTuple<string, string>, bool> __9__12_0;

		private static __c_94 wfHclqDQShYuhrkW46IH;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 4;
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
									goto end_IL_0012;
								}
								goto case 0;
							}
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
							__9 = (__c_94)new __c_94();
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							break;
						case 1:
							return;
						case 4:
							num3 = 3;
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
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_94()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool h4yLclMbYW9(ValueTuple<string, string> candidate)
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool nbTdE0DQcIcrsBinxs3Q()
		{
			return wfHclqDQShYuhrkW46IH == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_94 Edh8A7DQ0NLtwtuve202()
		{
			return wfHclqDQShYuhrkW46IH;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateEnvelopeAsync_d__12 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public string accountId;

		public string serverItemId;

		public string displayName;

		public string proxyPublicKeyB64;

		public long uid;

		public bool isRental;

		public CancellationToken cancellationToken;

		private string _normalizedAccountId_5__2;

		private string _normalizedServerId_5__3;

		private string _normalizedDisplayName_5__4;

		private string _normalizedPublicKey_5__5;

		private ValueTuple<string, string>[] _versionCandidates_5__6;

		private int _versionIndex_5__7;

		private ValueTuple<string, string> _version_5__8;

		private byte[] _encrypted_5__9;

		private StringContent _content_5__10;

		private HttpRequestMessage _request_5__11;

		private HttpResponseMessage _response_5__12;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object RlxUc3DQ8oVsHoTHfEMW;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_1209: Expected O, but got I4
			//IL_12eb: Expected O, but got I4
			//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1102: Invalid comparison between Unknown and I4
			//IL_13fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_14c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_150d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_153f: Expected native int or pointer, but got O
			//IL_1530: Expected O, but got I
			//IL_1634: Expected O, but got I8
			//IL_058e: Expected native int or pointer, but got O
			//IL_0693: Expected native int or pointer, but got O
			//IL_0936: Unknown result type (might be due to invalid IL or missing references)
			//IL_093b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa4: Expected O, but got Ref
			//IL_08cc: Expected O, but got I4
			//IL_08e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a41: Unknown result type (might be due to invalid IL or missing references)
			//IL_09ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e63: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c2b: Expected O, but got I4
			//IL_0c5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c69: Expected I4, but got Unknown
			//IL_0d7d: Expected O, but got I4
			//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0baa: Expected O, but got Ref
			//IL_12ff->IL11a1: Incompatible stack heights: 2 vs 1
			//IL_1706->IL1676: Incompatible stack heights: 3 vs 1
			//IL_130a->IL11a1: Incompatible stack heights: 2 vs 1
			//IL_1797->IL0010: Incompatible stack heights: 3 vs 1
			//IL_154e->IL0100: Incompatible stack heights: 4 vs 1
			//IL_1530->IL1530: Incompatible stack heights: 7 vs 6
			//IL_164a->IL00f8: Incompatible stack heights: 8 vs 1
			//IL_1655->IL00f8: Incompatible stack heights: 8 vs 1
			//IL_059d->IL04f4: Incompatible stack heights: 2 vs 1
			//IL_06ac->IL0621: Incompatible stack heights: 2 vs 1
			//IL_06b7->IL0621: Incompatible stack heights: 2 vs 1
			//IL_090a->IL0836: Incompatible stack heights: 2 vs 1
			//IL_0915->IL0836: Incompatible stack heights: 2 vs 1
			//IL_0d91->IL0b08: Incompatible stack heights: 2 vs 1
			//IL_0e30->IL0b08: Incompatible stack heights: 2 vs 1
			//IL_0d9c->IL0b08: Incompatible stack heights: 2 vs 1
			int num = 6;
			int num4 = default;
			int num8 = default;
			string text = default;
			NHWZ6yfy3eQFMLHkUCGq nHWZ6yfy3eQFMLHkUCGq2 = default;
			int num6 = default;
			int num24 = default;
			string text7 = default;
			string text5 = default;
			int num20 = default;
			int num13 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__2 = default;
			int num15 = default;
			string text2 = default;
			ConfiguredTaskAwaitable<string> val = default;
			int num17 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			HttpResponseMessage response_5__ = default;
			int num19 = default;
			int num23 = default;
			int num31 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out NHWZ6yfy3eQFMLHkUCGq obj3);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num25);
			NHWZ6yfy3eQFMLHkUCGq nHWZ6yfy3eQFMLHkUCGq3 = default;
			int num27 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num26);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num29 = default;
			int num33 = default;
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
							if (num2 != 15)
							{
								if (num2 == 996)
								{
									goto end_IL_0010;
								}
								goto case 8;
							}
							_normalizedDisplayName_5__4 = null;
							num3 = 4;
							continue;
						case 7:
							return;
						case 0:
							_versionCandidates_5__6 = null;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							_normalizedPublicKey_5__5 = null;
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
							{
								num3 = 0;
							}
							continue;
						case 6:
							num4 = __1__state;
							num3 = 5;
							continue;
						case 2:
							_normalizedServerId_5__3 = null;
							num = 15;
							break;
						case 5:
							try
							{
								int num5;
								if ((uint)num4 <= 1u)
								{
									num5 = 15;
									goto IL_0100;
								}
								goto IL_032e;
								IL_032e:
								System.ArgumentNullException.ThrowIfNull(session, "session");
								num5 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
								{
									num5 = 1;
								}
								goto IL_0100;
								IL_0100:
								while (true)
								{
									int num7;
									NHWZ6yfy3eQFMLHkUCGq nHWZ6yfy3eQFMLHkUCGq;
									switch (num5)
									{
									default:
										if (num8 != 31)
										{
											if (num8 == 1011)
											{
												goto IL_00fc;
											}
											goto case 21;
										}
										_encrypted_5__9 = QTafWbmi3EL((global::System.ReadOnlySpan<byte>)(System.Text.Encoding.UTF8).GetBytes(text));
										num5 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
										{
											num5 = 17;
										}
										continue;
									case 8:
										_normalizedPublicKey_5__5 = EgyfW9vS7rA(proxyPublicKeyB64, "proxyPublicKeyB64");
										num5 = 6;
										continue;
									case 14:
										_versionIndex_5__7 = 0;
										num7 = 22;
										goto IL_00f8;
									case 9:
										nHWZ6yfy3eQFMLHkUCGq = nHWZ6yfy3eQFMLHkUCGq2;
										if (nHWZ6yfy3eQFMLHkUCGq == null)
										{
											num5 = 10;
											continue;
										}
										goto IL_165f;
									case 6:
										if (uid <= 0)
										{
											num5 = 5;
											continue;
										}
										if (!string.Equals(session.UserId, _normalizedAccountId_5__2, (StringComparison)4))
										{
											num5 = 3;
											continue;
										}
										nHWZ6yfy3eQFMLHkUCGq2 = null;
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
										{
											num5 = 11;
										}
										continue;
									case 4:
										_versionIndex_5__7 = num6 + 1;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
										{
											num5 = 31;
										}
										continue;
									case 5:
										_ = "uid";
										throw new global::System.Exception("网易基岩 UID 无效");
									case 17:
									case 18:
										_version_5__8 = _versionCandidates_5__6[_versionIndex_5__7];
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
										{
											num5 = 26;
										}
										continue;
									case 15:
									case 16:
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
										{
											num5 = 26;
										}
										continue;
									case 2:
										break;
									case 0:
										num6 = _versionIndex_5__7;
										num5 = 4;
										continue;
									case 23:
										_normalizedServerId_5__3 = EgyfW9vS7rA(serverItemId, "serverItemId");
										num5 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
										{
											num5 = 22;
										}
										continue;
									case 1:
										_normalizedAccountId_5__2 = EgyfW9vS7rA(accountId, "accountId");
										num7 = 23;
										goto IL_00f8;
									case 3:
										throw new global::System.Exception("中继认证账号与当前基岩会话不一致");
									case 7:
									case 22:
										if (_versionIndex_5__7 < _versionCandidates_5__6.Length)
										{
											num5 = 17;
											continue;
										}
										goto case 9;
									case 13:
										_encrypted_5__9 = null;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
										{
											num5 = 12;
										}
										continue;
									case 12:
										try
										{
											int num9;
											if ((uint)num4 <= 1u)
											{
												num9 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
												{
													num9 = 10;
												}
												goto IL_04fc;
											}
											goto IL_05ac;
											IL_04fc:
											while (true)
											{
												switch (num9)
												{
												default:
													if (num24 != 12)
													{
														if (num24 == 992)
														{
															goto IL_04f8;
														}
														goto case 1;
													}
													global::System.Runtime.CompilerServices.Unsafe.Write(&((_CreateEnvelopeAsync_d__12*)(nint)text7)->_content_5__10, System.Text.Encoding.UTF8);
													_ = 3;
													goto IL_04f4;
												case 0:
													text5 = ptMHWhfcakRytZlVXYBT.md8fc3IVOBj("/authentication-v2", text, session.Token);
													goto IL_04f4;
												case 1:
												case 3:
													num9 = 4;
													continue;
												case 2:
													break;
												case 4:
													{
														try
														{
															int num10;
															if ((uint)num4 > 1u)
															{
																num10 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
																{
																	num10 = 11;
																}
																goto IL_0621;
															}
															goto IL_073c;
															IL_0621:
															while (true)
															{
																switch (num10)
																{
																default:
																	if (num20 != 12)
																	{
																		if (num20 == 992)
																		{
																			goto IL_061d;
																		}
																		goto case 1;
																	}
																	((_content_5__10).Headers).TryAddWithoutValidation("user-id", _normalizedAccountId_5__2);
																	num10 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																	{
																		num10 = 0;
																	}
																	continue;
																case 3:
																{
																	HttpMethod obj = System.Net.Http.HttpMethod.Post;
																	string text6 = "https://g79authobt.minecraft.cn/authentication-v2";
																	(text6).Content = (HttpContent)(object)_content_5__10;
																	global::System.Runtime.CompilerServices.Unsafe.Write(&((_CreateEnvelopeAsync_d__12*)(nint)obj)->_request_5__11, text6);
																	_ = 4;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																	{
																		_ = 11;
																	}
																	continue;
																}
																case 0:
																	((_content_5__10).Headers).TryAddWithoutValidation("user-token", (System.Convert.ToHexString((System.Text.Encoding.ASCII).GetBytes(text5))).ToUpperInvariant());
																	num10 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																	{
																		num10 = 3;
																	}
																	continue;
																case 4:
																	break;
																case 1:
																{
																	((_content_5__10).Headers).ContentType = (MediaTypeHeaderValue)(object)"application/json";
																	int num21 = 4;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																	{
																		num21 = 12;
																	}
																	num20 = num21;
																	goto IL_061d;
																}
																case 2:
																	{
																		try
																		{
																			int num11;
																			if (num4 != 0)
																			{
																				num11 = 22;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																				{
																					num11 = 1;
																				}
																				goto IL_0836;
																			}
																			goto IL_0935;
																			IL_0836:
																			while (true)
																			{
																				int num12;
																				switch (num11)
																				{
																				case 14:
																					return;
																				default:
																					switch (num13)
																					{
																					default:
																						return;
																					case 1003:
																						break;
																					case 23:
																						try
																						{
																							int num14;
																							if (num4 != 1)
																							{
																								num14 = 3;
																								goto IL_0b08;
																							}
																							goto IL_0e5d;
																							IL_0e5d:
																							_u__2 = __u__2;
																							num14 = 8;
																							goto IL_0b08;
																							IL_0b08:
																							while (true)
																							{
																								switch (num14)
																								{
																								case 0:
																									return;
																								default:
																									if (num15 == 22)
																									{
																										goto IL_0ba5;
																									}
																									if (num15 == 1002)
																									{
																										goto IL_0b04;
																									}
																									goto case 11;
																								case 5:
																									if (&_u__2 == null)
																									{
																										num14 = 14;
																										continue;
																									}
																									goto IL_0ba5;
																								case 14:
																									num4 = (__1__state = 1);
																									num14 = 12;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
																									{
																										num14 = 13;
																									}
																									continue;
																								case 9:
																									throw new NHWZ6yfy3eQFMLHkUCGq((_response_5__12).StatusCode);
																								case 4:
																								{
																									string text3 = iu4fynsYORI(text2);
																									secfyz2YHqg(text3);
																									string text4 = text3;
																									num14 = 6;
																									continue;
																								}
																								case 12:
																									__u__2 = _u__2;
																									num14 = 12;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																									{
																										num14 = 10;
																									}
																									continue;
																								case 1:
																								{
																									_ = "bedrock-relay";
																									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
																									(defaultInterpolatedStringHandler).AppendLiteral("AuthV2 HTTP ");
																									defaultInterpolatedStringHandler.AppendFormatted<int>((int)(_response_5__12).StatusCode);
																									(defaultInterpolatedStringHandler).AppendLiteral(" engine=");
																									(defaultInterpolatedStringHandler).AppendFormatted(_version_5__8.Item1);
																									(defaultInterpolatedStringHandler).AppendLiteral(" ");
																									(defaultInterpolatedStringHandler).AppendLiteral("patch=");
																									(defaultInterpolatedStringHandler).AppendFormatted(_version_5__8.Item2);
																									(defaultInterpolatedStringHandler).AppendLiteral(" response=");
																									gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)37, string.Concat((defaultInterpolatedStringHandler).ToStringAndClear(), vCdkuBfLtLlHd38qlo2M.a2VfLRPfDcZ((global::System.ReadOnlySpan<byte>)(System.Text.Encoding.UTF8).GetBytes(text2))));
																									_ = 21;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																									{
																										_ = 9;
																									}
																									continue;
																								}
																								case 11:
																									if ((_response_5__12).IsSuccessStatusCode)
																									{
																										num14 = 4;
																										continue;
																									}
																									goto case 1;
																								case 2:
																									num4 = (__1__state = -1);
																									num15 = 22;
																									goto IL_0b04;
																								case 3:
																									((_response_5__12).Content).ReadAsStringAsync(cancellationToken);
																									val = (ConfiguredTaskAwaitable<string>)0;
																									_ = 13;
																									continue;
																								case 10:
																									__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _CreateEnvelopeAsync_d__12>(ref _u__2, ref this);
																									num14 = 2;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
																									{
																										num14 = 0;
																									}
																									continue;
																								case 7:
																									break;
																								case 13:
																									_u__2 = val;
																									num14 = 5;
																									continue;
																								case 8:
																									__u__2 = default;
																									num14 = 2;
																									continue;
																								case 6:
																									goto end_IL_0b08;
																									IL_0ba5:
																									text2 = (string)(&_u__2);
																									num14 = 11;
																									continue;
																									IL_0b04:
																									num14 = num15;
																									continue;
																								}
																								goto IL_0e5d;
																								continue;
																								end_IL_0b08:
																								break;
																							}
																						}
																						finally
																						{
																							if (num4 < 0)
																							{
																								int num16 = 7;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
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
																									case 1:
																										if (_response_5__12 != null)
																										{
																											num16 = 2;
																											continue;
																										}
																										break;
																									case 2:
																										(_response_5__12).Dispose();
																										num16 = 8;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
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
																						goto end_IL_0836;
																					}
																					goto IL_0832;
																				case 12:
																					num4 = (__1__state = -1);
																					num11 = 4;
																					continue;
																				case 6:
																					((_request_5__11).Headers).ExpectContinue = (bool?)(object)0;
																					num11 = 9;
																					continue;
																				case 9:
																					(L4LfWJg0Pgt).SendAsync(_request_5__11, (HttpCompletionOption)1, cancellationToken);
																					val2 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																					_ = 4;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																					{
																						_ = 11;
																					}
																					continue;
																				case 2:
																					num12 = 13;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																					{
																						num12 = 23;
																					}
																					goto IL_082e;
																				case 5:
																					break;
																				case 8:
																					if (&_u__ == null)
																					{
																						num11 = 3;
																						continue;
																					}
																					goto case 4;
																				case 13:
																					((_request_5__11).Headers).TryAddWithoutValidation("User-Agent", "libhttpclient/1.0.0.0");
																					num11 = 6;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
																					{
																						num11 = 21;
																					}
																					continue;
																				case 11:
																					_u__ = val2;
																					num11 = 8;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
																					{
																						num11 = 4;
																					}
																					continue;
																				case 0:
																					__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _CreateEnvelopeAsync_d__12>(ref _u__, ref this);
																					num11 = 10;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
																					{
																						num11 = 14;
																					}
																					continue;
																				case 10:
																					__u__1 = default;
																					num11 = 12;
																					continue;
																				case 1:
																					if (num4 != 1)
																					{
																						num11 = 3;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
																						{
																							num11 = 13;
																						}
																						continue;
																					}
																					goto case 2;
																				case 15:
																					__u__1 = _u__;
																					num11 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
																					{
																						num11 = 16;
																					}
																					continue;
																				case 4:
																					response_5__ = (HttpResponseMessage)(object)(&_u__);
																					num11 = 7;
																					continue;
																				case 7:
																					_response_5__12 = response_5__;
																					num12 = 2;
																					goto IL_082e;
																				case 3:
																					{
																						num4 = (__1__state = 0);
																						num12 = 15;
																						goto IL_082e;
																					}
																					IL_082e:
																					num13 = num12;
																					goto IL_0832;
																					IL_0832:
																					num11 = num13;
																					continue;
																				}
																				goto IL_0935;
																				continue;
																				end_IL_0836:
																				break;
																			}
																			goto end_IL_07fe;
																			IL_0935:
																			_u__ = __u__1;
																			num11 = 17;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
																			{
																				num11 = 10;
																			}
																			goto IL_0836;
																			end_IL_07fe:;
																		}
																		finally
																		{
																			int num18;
																			if (num4 >= 0)
																			{
																				num18 = 2;
																				goto IL_0f5f;
																			}
																			goto IL_0fab;
																			IL_0fab:
																			if (_request_5__11 != null)
																			{
																				num18 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
																				{
																					num18 = 0;
																				}
																				goto IL_0f5f;
																			}
																			goto end_IL_0f3b;
																			IL_0f5f:
																			while (true)
																			{
																				switch (num18)
																				{
																				default:
																					if (num19 == 991)
																					{
																						num18 = num19;
																						continue;
																					}
																					goto end_IL_0f5f;
																				case 2:
																					goto end_IL_0f5f;
																				case 1:
																					break;
																				case 0:
																					(_request_5__11).Dispose();
																					num18 = 3;
																					continue;
																				case 3:
																					goto end_IL_0f5f;
																				}
																				goto IL_0fab;
																				continue;
																				end_IL_0f5f:
																				break;
																			}
																			end_IL_0f3b:;
																		}
																		goto end_IL_0621;
																	}
																	IL_061d:
																	num10 = num20;
																	continue;
																}
																goto IL_073c;
																continue;
																end_IL_0621:
																break;
															}
															goto end_IL_05e8;
															IL_073c:
															num10 = 2;
															goto IL_0621;
															end_IL_05e8:;
														}
														finally
														{
															if (num4 < 0)
															{
																int num22 = 2;
																while (true)
																{
																	switch (num22)
																	{
																	default:
																		if (num23 == 991)
																		{
																			num22 = num23;
																			continue;
																		}
																		break;
																	case 1:
																		break;
																	case 3:
																		(_content_5__10).Dispose();
																		num22 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																		{
																			num22 = 4;
																		}
																		continue;
																	case 2:
																		if (_content_5__10 == null)
																		{
																			num22 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
																			{
																				num22 = 2;
																			}
																			continue;
																		}
																		goto case 3;
																	case 0:
																		break;
																	}
																	break;
																}
															}
														}
														goto end_IL_04fc;
													}
													IL_04f4:
													num24 = 12;
													goto IL_04f8;
													IL_04f8:
													num9 = num24;
													continue;
												}
												goto IL_05ac;
												continue;
												end_IL_04fc:
												break;
											}
											goto end_IL_04c3;
											IL_05ac:
											text7 = (System.Convert.ToHexString(_encrypted_5__9)).ToLowerInvariant();
											num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
											{
												num9 = 4;
											}
											goto IL_04fc;
											end_IL_04c3:;
										}
										catch (object obj2) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj3 = obj2 as NHWZ6yfy3eQFMLHkUCGq;
											if (obj3 == null)
											{
												num25 = 2;
											}
											else
											{
												nHWZ6yfy3eQFMLHkUCGq3 = obj3;
												num25 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
												{
													num25 = 7;
												}
											}
											while (true)
											{
												switch (num25)
												{
												default:
													if (num27 == 990)
													{
														num25 = num27;
														continue;
													}
													goto case 1;
												case 1:
													if ((int)nHWZ6yfy3eQFMLHkUCGq3.StatusCode == 401)
													{
														num25 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
														{
															num25 = 0;
														}
														continue;
													}
													num26 = 0;
													goto IL_116a;
												case 0:
													num26 = ((_versionIndex_5__7 < _versionCandidates_5__6.Length - 1) ? 1 : 0);
													goto IL_116a;
												case 2:
													{
														result = 0;
														break;
													}
													IL_116a:
													result = ((num26 != 0) ? 1 : 0);
													break;
												}
												break;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num28 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
											{
												num28 = 0;
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
													goto case 1;
												case 1:
													nHWZ6yfy3eQFMLHkUCGq2 = nHWZ6yfy3eQFMLHkUCGq3;
													num28 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
													{
														num28 = 3;
													}
													continue;
												case 0:
												{
													_ = "bedrock-relay";
													global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
													(defaultInterpolatedStringHandler2).AppendLiteral("AuthV2 401，尝试下一个兼容中继版本 engine=");
													(defaultInterpolatedStringHandler2).AppendFormatted(_versionCandidates_5__6[_versionIndex_5__7 + 1].Item1);
													(defaultInterpolatedStringHandler2).AppendLiteral(" ");
													(defaultInterpolatedStringHandler2).AppendLiteral("patch=");
													(defaultInterpolatedStringHandler2).AppendFormatted(_versionCandidates_5__6[_versionIndex_5__7 + 1].Item2);
													gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)37, (defaultInterpolatedStringHandler2).ToStringAndClear(), (global::System.Exception?)(object)nHWZ6yfy3eQFMLHkUCGq3);
													_ = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
													{
														_ = 1;
													}
													continue;
												}
												case 2:
													break;
												}
												break;
											}
											goto case 21;
										}
										finally
										{
											if (num4 < 0)
											{
												int num30 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
												{
													num30 = 0;
												}
												while (true)
												{
													switch (num30)
													{
													default:
														if (num31 == 989)
														{
															num30 = num31;
															continue;
														}
														break;
													case 0:
														System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)_encrypted_5__9);
														num30 = 4;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
														{
															num30 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_0100;
									case 21:
										_version_5__8 = default;
										num5 = 13;
										continue;
									case 19:
										_normalizedDisplayName_5__4 = EgyfW9vS7rA(displayName, "displayName");
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
										{
											num5 = 23;
										}
										continue;
									case 11:
									{
										ValueTuple<string, string>[] array = new ValueTuple<string, string>[3];
										((ValueTuple<string, string>[])0)[(object)"3.4.5.272725"] = (ValueTuple<string, string>)"3.4.118.273808";
										((ValueTuple<string, string>[])1)[(object)session.EngineVersion] = (ValueTuple<string, string>)session.PatchVersion;
										((ValueTuple<string, string>[])2)[(object)"3.8.15.292838"] = (ValueTuple<string, string>)"3.8.16.292818";
										Func<ValueTuple<string, string>, bool> _9__12_ = __c_94.__9__12_0;
										if (_9__12_ == null)
										{
											_ = __c_94.__9;
											__c_94.__9__12_0 = new Func<ValueTuple<string, string>, bool>(__c_94.h4yLclMbYW9);
										}
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_CreateEnvelopeAsync_d__12*)(nint)array)->_versionCandidates_5__6, Enumerable.ToArray<ValueTuple<string, string>>(Enumerable.Distinct<ValueTuple<string, string>>(Enumerable.Where<ValueTuple<string, string>>((global::System.Collections.Generic.IEnumerable<ValueTuple<string, string>>)array, _9__12_))));
										_ = 14;
										continue;
									}
									case 20:
										_ = "64";
										_ = _normalizedPublicKey_5__5;
										_ = _normalizedDisplayName_5__4;
										_ = _version_5__8.Item1;
										string.Concat(_normalizedServerId_5__3, ":", isRental ? "RentalGame" : "NetworkGame");
										_ = "android";
										_ = _version_5__8.Item2;
										text = JsonSerializer.Serialize<global::__f__AnonymousType98_8<string, string, string, string, string, string, string, long>>((global::__f__AnonymousType98_8<string, string, string, string, string, string, string, long>)uid, (JsonSerializerOptions)iskfWy5fuVP);
										_ = 25;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
										{
											_ = 31;
										}
										goto IL_00f8;
									case 10:
										{
											nHWZ6yfy3eQFMLHkUCGq = (NHWZ6yfy3eQFMLHkUCGq)new NHWZ6yfy3eQFMLHkUCGq((HttpStatusCode)401);
											goto IL_165f;
										}
										IL_165f:
										throw nHWZ6yfy3eQFMLHkUCGq;
										IL_00f8:
										num8 = num7;
										goto IL_00fc;
										IL_00fc:
										num5 = num8;
										continue;
									}
									goto IL_032e;
									continue;
									end_IL_0100:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num32 = 3;
								while (true)
								{
									switch (num32)
									{
									case 5:
										return;
									default:
										if (num33 != 14)
										{
											if (num33 == 994)
											{
												goto IL_167a;
											}
											goto case 6;
										}
										_versionCandidates_5__6 = null;
										num32 = 4;
										break;
									case 1:
										_normalizedPublicKey_5__5 = null;
										goto IL_1676;
									case 0:
										_normalizedServerId_5__3 = null;
										num32 = 6;
										break;
									case 4:
										_ = __t__builder;
										_ = 5;
										goto IL_1676;
									case 6:
										_normalizedDisplayName_5__4 = null;
										num32 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
										{
											num32 = 1;
										}
										break;
									case 3:
										__1__state = -2;
										num32 = 2;
										break;
									case 2:
										{
											_normalizedAccountId_5__2 = null;
											num32 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
											{
												num32 = 4;
											}
											break;
										}
										IL_1676:
										num33 = 14;
										goto IL_167a;
										IL_167a:
										num32 = num33;
										break;
									}
								}
							}
							goto case 8;
						case 3:
							_normalizedAccountId_5__2 = null;
							num3 = 2;
							continue;
						case 1:
							_ = __t__builder;
							_ = 7;
							continue;
						case 8:
							__1__state = -2;
							num = 3;
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
							switch (num2)
							{
							case 990:
								break;
							default:
								goto end_IL_000e;
							case 9:
								goto IL_0077;
							}
							break;
						case 0:
							goto end_IL_000e;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							return;
							IL_0077:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 2;
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
		internal static bool zEG65wDQyLqo6U0O5UPV()
		{
			return RlxUc3DQ8oVsHoTHfEMW == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object K4qt9QDQW9qdE7EAlI1G()
		{
			return RlxUc3DQ8oVsHoTHfEMW;
		}
	}

	private static readonly object iskfWy5fuVP;

	private static readonly object j75fWW6X5oW;

	private static readonly object L4LfWJg0Pgt;

	internal static object ppocFpZubrJ3vwaLc3hg;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Threading.Tasks.Task<string> TjyfyqONql4(object accountId, object serverItemId, bool isRental, long uid, object displayName, object proxyPublicKeyB64, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
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
				{
					c7lEmkf1MoB1jUf1XEF1? currentSession = da18CdX55laNMRKtM3p0.Shared.CurrentSession;
					if ((object)currentSession == null)
					{
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return By8fyGn0Ihn(currentSession, accountId, serverItemId, isRental, uid, displayName, proxyPublicKeyB64, cancellationToken);
				}
				case 0:
					throw new global::System.Exception("请先建立网易基岩会话");
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<string> By8fyGn0Ihn(object session, object accountId, object serverItemId, bool isRental, long uid, object displayName, object proxyPublicKeyB64, CancellationToken cancellationToken = default(CancellationToken))
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient FQJfyibJ3i8()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string iu4fynsYORI(object responseText)
	{
		//IL_0123: Expected O, but got Unknown
		int num = 6;
		string text = default;
		byte[] array = default;
		int num9 = default;
		int num11 = default;
		string result = default;
		int num5 = default;
		int num7 = default;
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
						return text;
					case 4:
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 0;
						}
						break;
					case 7:
						throw new global::System.Exception("网易 AuthV2 返回为空");
					case 2:
						if ((text).Chars != '{')
						{
							num3 = 3;
							break;
						}
						goto end_IL_000c;
					case 3:
						try
						{
							array = System.Convert.FromHexString(text);
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 988)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (FormatException ex)
						{
							FormatException ex2 = ex;
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
							{
								num10 = 6;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										goto IL_0150;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0150:
								num10 = num11;
							}
							_ = "网易 AuthV2 返回不是有效密文";
							throw ex2;
						}
						goto case 4;
					case 6:
						text = (responseText).Trim();
						num3 = 5;
						break;
					case 0:
						try
						{
							result = lB9fWLhVu5j((global::System.ReadOnlySpan<byte>)array);
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
							int num6 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					case 1:
						return result;
					case 5:
						if ((text).Length != 0)
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 2;
							}
							break;
						}
						goto case 7;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void secfyz2YHqg(object envelope)
	{
		//IL_03ad: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Invalid comparison between Unknown and I4
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Invalid comparison between Unknown and I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029b: Invalid comparison between Unknown and I4
		int num = 1;
		int num3 = default;
		int num5 = default;
		JsonElement val3 = default;
		bool flag = default;
		JsonElement val4 = default;
		int num8 = default;
		int num10 = default;
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
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)envelope, default(JsonDocumentOptions));
					int num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								goto IL_0076;
							}
							break;
						case 1:
							break;
						}
						break;
						IL_0076:
						num2 = num3;
					}
					try
					{
						JsonElement val2 = (val).RootElement;
						int num4 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							int num6;
							switch (num4)
							{
							case 0:
								return;
							case 6:
								return;
							default:
								if (num5 != 15)
								{
									if (num5 == 995)
									{
										goto IL_00d6;
									}
									goto case 4;
								}
								num6 = ((!string.IsNullOrWhiteSpace((val3).GetString())) ? 1 : 0);
								goto IL_025a;
							case 7:
								throw new global::System.Exception("网易 AuthV2 返回不是 JSON 对象");
							case 4:
								if ((int)(val3).ValueKind == 3)
								{
									num5 = 15;
									goto IL_00d6;
								}
								goto case 5;
							case 1:
								if ((int)(val2).ValueKind == 1)
								{
									if (!(val2).TryGetProperty("Certificate", ref val3))
									{
										num4 = 5;
										continue;
									}
									goto case 4;
								}
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num4 = 7;
								}
								continue;
							case 3:
								if (flag)
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num4 = 6;
									}
									continue;
								}
								break;
							case 5:
								num6 = 0;
								goto IL_025a;
							case 2:
								break;
								IL_00d6:
								num4 = num5;
								continue;
								IL_025a:
								flag = (val2).TryGetProperty("chain", ref val4) && (int)(val4).ValueKind == 2 && (val4).GetArrayLength() > 0;
								if (num6 != 0)
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 3;
							}
							break;
						}
						throw new global::System.Exception("网易 AuthV2 返回缺少证书链");
					}
					finally
					{
						if (val != null)
						{
							int num7 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_033b;
								}
								(val).Dispose();
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
								{
									num7 = 1;
								}
								continue;
								end_IL_033b:
								break;
							}
						}
					}
				}
				catch (JsonException ex)
				{
					JsonException ex2 = ex;
					int num9 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						default:
							if (num10 == 988)
							{
								goto IL_03da;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_03da:
						num9 = num10;
					}
					_ = "网易 AuthV2 返回 JSON 无效";
					throw ex2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static byte[] QTafWbmi3EL(global::System.ReadOnlySpan<byte> plaintext, int tailLength = 16)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] yQLfWXlg6Co(global::System.ReadOnlySpan<byte> plaintext, int tailLength = 16)
	{
		return QTafWbmi3EL(plaintext, tailLength);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string CTYfWfBYchB(global::System.ReadOnlySpan<byte> ciphertext)
	{
		return lB9fWLhVu5j(ciphertext);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string lB9fWLhVu5j(global::System.ReadOnlySpan<byte> body)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] iYKfWjyd5AG(object key, object iv, object input, bool encrypt)
	{
		int num = 1;
		byte[] result = default;
		Aes val = default;
		int num5 = default;
		ICryptoTransform val2 = default;
		int num7 = default;
		int num9 = default;
		int num11 = default;
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
					return result;
				case 0:
					try
					{
						(val).Key = (byte[])key;
						int num3 = 2;
						while (true)
						{
							ICryptoTransform obj;
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 12)
								{
									if (num5 == 992)
									{
										goto IL_005d;
									}
									goto case 4;
								}
								try
								{
									result = (val2).TransformFinalBlock((byte[])input, 0, ((global::System.Array)input).Length);
									int num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 988)
											{
												num6 = num7;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									int num8;
									if (val2 == null)
									{
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
										{
											num8 = 6;
										}
										goto IL_01fb;
									}
									goto IL_021f;
									IL_01fb:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_01f7;
											}
											goto end_IL_01fb;
										case 2:
											break;
										case 1:
											goto end_IL_01fb;
										case 0:
											goto end_IL_01fb;
										}
										goto IL_021f;
										IL_01f7:
										num8 = num9;
										continue;
										end_IL_01fb:
										break;
									}
									goto end_IL_01c3;
									IL_021f:
									(val2).Dispose();
									num8 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num8 = 0;
									}
									goto IL_01fb;
									end_IL_01c3:;
								}
								goto end_IL_0061;
							case 2:
								(val).IV = (byte[])iv;
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
								{
									num3 = 10;
								}
								break;
							case 0:
								if (!encrypt)
								{
									num3 = 3;
									break;
								}
								obj = (val).CreateEncryptor();
								goto IL_013c;
							case 4:
								(val).Padding = (PaddingMode)1;
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
								{
									num3 = 0;
								}
								break;
							case 3:
								obj = (val).CreateDecryptor();
								goto IL_013c;
							case 1:
								{
									(val).Mode = (CipherMode)1;
									num4 = 4;
									goto IL_0059;
								}
								IL_013c:
								val2 = obj;
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
								{
									num4 = 12;
								}
								goto IL_0059;
								IL_005d:
								num3 = num5;
								break;
								IL_0059:
								num5 = num4;
								goto IL_005d;
							}
							continue;
							end_IL_0061:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										num10 = num11;
										continue;
									}
									break;
								case 0:
									(val).Dispose();
									num10 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 1:
					break;
				}
				goto IL_02fd;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_02fd;
				IL_02fd:
				val = System.Security.Cryptography.Aes.Create();
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void F1WfWZwygP9(global::System.Span<byte> destination)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string EgyfW9vS7rA(string? value, object parameterName)
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 2:
					return (value).Trim();
				case 0:
					_ = "参数不能为空";
					throw parameterName;
				case 1:
					if (string.IsNullOrWhiteSpace(value))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_02e0: Expected O, but got I4
		//IL_02e5: Expected O, but got I4
		j75fWW6X5oW = new IEquatable<bjsovlXid1IZ1bYL6Xwl>[16]
		{
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("60F1E0D1FD635362430747215CF1C2FF"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("EA5B62D27D0338374852C4B9469D7AC6"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("17238D55501C5F020B155FB3303591E6"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("8C5CEAE0F443E006A050266F73ADD5B0"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("1C02CE22FB22F0E72060217418F351F3"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("9A01773FEBB0CFE0EBDBF37F4D23C27F"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("43F32300BF252CC320E2572ACE766367"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("07F161011B3101F1ED0301735631E734"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("0454E7707A5F37565601E100406060AF"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("647554BAD3100C43C16660F002CC10F3"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("E157213170F842382032564265B0B043"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("914FC59311B04151393EF6896A847636"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("0710C0205D224237025323265C145FA1"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("054E6F01165267025C3111F562A921E9"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("722D1789E792E2CA0D5322211FD0F5AE"),
			(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("91F7C751FCF671F34943430772341799")
		};
		_ = 4;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe;
		(0).Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
		iskfWy5fuVP = 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Ghr7Z1ZuX9sMAADTFvhd()
	{
		return ppocFpZubrJ3vwaLc3hg == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static yatvTGfyE6WkjVXwPep9 SRiuIDZufhj3CrJAi98r()
	{
		return (yatvTGfyE6WkjVXwPep9)ppocFpZubrJ3vwaLc3hg;
	}
}

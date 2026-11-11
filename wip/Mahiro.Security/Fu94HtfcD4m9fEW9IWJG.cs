using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using D92aI6fc1JJ4bAaEjL8U;
using MSc01sf3DGpdk89SaOBd;
using T3KSF1f3LrL7n0SFo0BO;
using fDAldojjppXrctUVYOJn;
using fYjvfFf1p8udxK21D6pd;
using zabwm4f3ZfjEaKUH3iZp;

namespace KkpGy6fckS1PJBVEQ69a;

sealed class Fu94HtfcD4m9fEW9IWJG : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _GetAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<y6sHXkf3fhIBq5aFx6SX> __t__builder;

		public Fu94HtfcD4m9fEW9IWJG __4__this;

		public c7lEmkf1MoB1jUf1XEF1 session;

		public CancellationToken cancellationToken;

		private HttpRequestMessage _request_5__2;

		private HttpResponseMessage _response_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object kOGkUcDWPehHxoyUy39N;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_10e7: Expected O, but got Unknown
			//IL_01a3: Expected native int or pointer, but got O
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e2: Expected O, but got Ref
			//IL_04ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0370: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Expected O, but got Ref
			//IL_0683: Expected O, but got I4
			//IL_0660: Unknown result type (might be due to invalid IL or missing references)
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0811: Unknown result type (might be due to invalid IL or missing references)
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_0728: Unknown result type (might be due to invalid IL or missing references)
			//IL_0732: Expected I4, but got Unknown
			//IL_087a: Unknown result type (might be due to invalid IL or missing references)
			//IL_087f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b13: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b8c: Invalid comparison between Unknown and I4
			//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a72: Invalid comparison between Unknown and I4
			//IL_0a9b: Expected O, but got I4
			//IL_0926: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ccd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ddd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e67: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e74: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Unknown result type (might be due to invalid IL or missing references)
			//IL_101b: Unknown result type (might be due to invalid IL or missing references)
			//IL_137c->IL130d: Incompatible stack heights: 3 vs 1
			//IL_1436->IL0008: Incompatible stack heights: 3 vs 1
			//IL_01b2->IL00b2: Incompatible stack heights: 4 vs 1
			//IL_04b9->IL0258: Incompatible stack heights: 2 vs 1
			//IL_068d->IL056e: Incompatible stack heights: 2 vs 1
			//IL_067d->IL056e: Incompatible stack heights: 2 vs 1
			//IL_0aaf->IL08b2: Incompatible stack heights: 2 vs 1
			//IL_0aba->IL08b2: Incompatible stack heights: 2 vs 1
			int num3 = default;
			int num24 = default;
			string text3 = default;
			Fu94HtfcD4m9fEW9IWJG fu94HtfcD4m9fEW9IWJG = default;
			int num6 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__2 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val7 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			int num17 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default;
			string text = default;
			ConfiguredTaskAwaitable<string> val6 = default;
			int num9 = default;
			int num12 = default;
			string text2 = default;
			JsonElement val4 = default;
			JsonElement element2 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			JsonElement val5 = default;
			int num11 = default;
			JsonElement val3 = default;
			int num14 = default;
			int num16 = default;
			int num19 = default;
			int num22 = default;
			int num26 = default;
			while (true)
			{
				int num = 5;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num == 13)
							{
								return;
							}
							goto end_IL_0010;
						case 0:
							_request_5__2 = null;
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
							{
								num2 = 3;
							}
							continue;
						case 6:
							try
							{
								int num4;
								if ((uint)num3 > 1u)
								{
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num4 = 9;
									}
									goto IL_00b2;
								}
								goto IL_00ec;
								IL_00b2:
								while (true)
								{
									switch (num4)
									{
									default:
									{
										if (num24 != 12)
										{
											if (num24 == 992)
											{
												goto IL_00ae;
											}
											goto case 2;
										}
										System.Net.Http.HttpMethod.Post;
										string text4 = "https://g79apigatewayobt.minecraft.cn/user-detail/query/other";
										string request_5__ = text3;
										(System.Text.Encoding.UTF8).Content = (HttpContent)(object)"application/json";
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_GetAsync_d__7*)(nint)text4)->_request_5__2, request_5__);
										_ = 4;
										continue;
									}
									case 4:
										break;
									case 0:
									{
										text3 = JsonSerializer.Serialize<global::__f__AnonymousType39_1<string>>((global::__f__AnonymousType39_1<string>)(object)session.UserId, (JsonSerializerOptions)yF4fcUN0w0s);
										int num23 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
										{
											num23 = 4;
										}
										num24 = num23;
										goto IL_00ae;
									}
									case 2:
										System.ArgumentNullException.ThrowIfNull(session, "session");
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
										{
											num4 = 0;
										}
										continue;
									case 3:
										System.ObjectDisposedException.ThrowIf(fu94HtfcD4m9fEW9IWJG.V2efco52Ii7, fu94HtfcD4m9fEW9IWJG);
										num4 = 2;
										continue;
									case 1:
										{
											try
											{
												int num5;
												if (num3 == 0)
												{
													num5 = 17;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
													{
														num5 = 0;
													}
													goto IL_0258;
												}
												goto IL_03c1;
												IL_0254:
												num5 = num6;
												goto IL_0258;
												IL_03c1:
												if (num3 != 1)
												{
													num5 = 16;
													goto IL_0258;
												}
												goto IL_02c6;
												IL_0258:
												while (true)
												{
													switch (num5)
													{
													default:
														if (num6 != 25)
														{
															if (num6 == 1005)
															{
																goto IL_0254;
															}
															goto case 2;
														}
														goto IL_04dd;
													case 11:
														break;
													case 2:
														((_request_5__2).Headers).TryAddWithoutValidation("user-token", ptMHWhfcakRytZlVXYBT.md8fc3IVOBj("/user-detail/query/other", text3, session.Token));
														num5 = 14;
														continue;
													case 17:
														if (&_u__2 != null)
														{
															goto IL_034d;
														}
														goto case 7;
													case 9:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _GetAsync_d__7>(ref _u__2, ref this);
														num5 = 3;
														continue;
													case 0:
													case 15:
														_u__2 = __u__1;
														num5 = 13;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
														{
															num5 = 15;
														}
														continue;
													case 13:
														__u__1 = default;
														num5 = 6;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
														{
															num5 = 1;
														}
														continue;
													case 8:
														goto IL_03c1;
													case 3:
														return;
													case 1:
														num3 = (__1__state = -1);
														num5 = 10;
														continue;
													case 7:
														num3 = (__1__state = 0);
														num5 = 21;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
														{
															num5 = 12;
														}
														continue;
													case 4:
														_response_5__3 = response_5__;
														num5 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
														{
															num5 = 11;
														}
														continue;
													case 14:
														(fu94HtfcD4m9fEW9IWJG.Y8UfcrdNEEm).SendAsync(_request_5__2, cancellationToken);
														val7 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
														_ = 5;
														continue;
													case 5:
														_u__2 = val7;
														num5 = 9;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
														{
															num5 = 17;
														}
														continue;
													case 10:
														goto IL_04dd;
													case 12:
														goto IL_04ec;
													case 16:
														((_request_5__2).Headers).TryAddWithoutValidation("user-id", session.UserId);
														num5 = 2;
														continue;
													case 6:
														try
														{
															int num7;
															if (num3 != 1)
															{
																num7 = 9;
																goto IL_056e;
															}
															goto IL_06be;
															IL_06be:
															_u__ = __u__2;
															num7 = 10;
															goto IL_056e;
															IL_056e:
															while (true)
															{
																switch (num7)
																{
																default:
																	if (num17 != 25)
																	{
																		if (num17 == 1005)
																		{
																			goto IL_056a;
																		}
																		goto case 15;
																	}
																	defaultInterpolatedStringHandler2.AppendFormatted<int>((int)(_response_5__3).StatusCode);
																	num7 = 16;
																	continue;
																case 12:
																	if (&_u__ != null)
																	{
																		num7 = 2;
																		continue;
																	}
																	goto case 1;
																case 2:
																case 6:
																	text = (string)(&_u__);
																	num7 = 3;
																	continue;
																case 15:
																	throw (defaultInterpolatedStringHandler2).ToStringAndClear();
																case 9:
																	((_response_5__3).Content).ReadAsStringAsync(cancellationToken);
																	val6 = (ConfiguredTaskAwaitable<string>)0;
																	_ = 5;
																	continue;
																case 7:
																	_ = 19;
																	defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																	_ = 11;
																	continue;
																case 16:
																	(defaultInterpolatedStringHandler2).AppendLiteral("）");
																	num7 = 15;
																	continue;
																case 8:
																	break;
																case 5:
																	_u__ = val6;
																	num7 = 16;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																	{
																		num7 = 12;
																	}
																	continue;
																case 13:
																	__u__2 = _u__;
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																	{
																		num7 = 16;
																	}
																	continue;
																case 4:
																	return;
																case 11:
																	(defaultInterpolatedStringHandler2).AppendLiteral("网易角色资料接口请求失败（HTTP ");
																	num17 = 25;
																	goto IL_056a;
																case 17:
																	num3 = (__1__state = -1);
																	num7 = 17;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
																	{
																		num7 = 6;
																	}
																	continue;
																case 10:
																	__u__2 = default;
																	num7 = 17;
																	continue;
																case 3:
																	if ((_response_5__3).IsSuccessStatusCode)
																	{
																		num7 = 14;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
																		{
																			num7 = 23;
																		}
																	}
																	else
																	{
																		num7 = 7;
																	}
																	continue;
																case 0:
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _GetAsync_d__7>(ref _u__, ref this);
																	num7 = 4;
																	continue;
																case 1:
																	num3 = (__1__state = 1);
																	num7 = 13;
																	continue;
																case 14:
																	{
																		try
																		{
																			JsonDocument val = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
																			int num8 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
																			{
																				num8 = 4;
																			}
																			while (true)
																			{
																				switch (num8)
																				{
																				default:
																					if (num9 == 988)
																					{
																						goto IL_0852;
																					}
																					break;
																				case 0:
																					break;
																				}
																				break;
																				IL_0852:
																				num8 = num9;
																			}
																			try
																			{
																				JsonElement element = (val).RootElement;
																				int num10 = 8;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																				{
																					num10 = 17;
																				}
																				while (true)
																				{
																					JsonElement val2;
																					switch (num10)
																					{
																					default:
																					{
																						if (num12 != 26)
																						{
																							if (num12 == 1006)
																							{
																								goto IL_08ae;
																							}
																							goto case 1;
																						}
																						y6sHXkf3fhIBq5aFx6SX y6sHXkf3fhIBq5aFx6SX = (y6sHXkf3fhIBq5aFx6SX)new y6sHXkf3fhIBq5aFx6SX
																						{
																							UserId = (((text2).Length == 0) ? session.UserId : text2),
																							Nickname = (Ru2fcCJSeJM(val4, "nickname")).Trim(),
																							Signature = (Ru2fcCJSeJM(val4, "signature")).Trim(),
																							AvatarUrl = (Ru2fcCJSeJM(val4, "headImage")).Trim(),
																							FrameUrl = (Ru2fcCJSeJM(val4, "frame_id")).Trim(),
																							Level = yVkfcS5eMvy(element2, "lv"),
																							Experience = yVkfcS5eMvy(element2, "exp"),
																							ExperienceNeeded = yVkfcS5eMvy(element2, "need_exp"),
																							VipLevel = yVkfcS5eMvy(val4, "recharge_vip_level"),
																							Tags = lF7fccyZwtf(val4),
																							IsDeveloperVerified = iiSfc0GDWvN(val4),
																							HomepageBackground = (Ru2fcCJSeJM(val4, "homepage_bg")).Trim(),
																							VisitCardBackground = (Ru2fcCJSeJM(val4, "visit_card_bg")).Trim(),
																							Province = fbdfcW8FPo0(val4, "lbs_info", "province"),
																							City = fbdfcW8FPo0(val4, "lbs_info", "city"),
																							Area = fbdfcW8FPo0(val4, "lbs_info", "area"),
																							IsFriend = ENRfcySg5Cv(val4, "is_friend"),
																							IsHomepagePublic = ENRfcySg5Cv(val4, "public_flag"),
																							Statistics = VFYfcJc1pmf(val4)
																						};
																						num10 = 2;
																						continue;
																					}
																					case 18:
																						(defaultInterpolatedStringHandler).AppendFormatted(Ru2fcCJSeJM(element, "message", "网易角色资料接口返回失败"));
																						num10 = 3;
																						continue;
																					case 6:
																						(defaultInterpolatedStringHandler).AppendLiteral("）");
																						num10 = 9;
																						continue;
																					case 14:
																						if (!string.Equals(text2, session.UserId, (StringComparison)4))
																						{
																							num10 = 13;
																							continue;
																						}
																						goto case 4;
																					case 1:
																					case 17:
																						throw new global::System.Exception("网易角色资料接口未返回角色实体");
																					case 10:
																						if ((text2).Length <= 0)
																						{
																							num10 = 4;
																							continue;
																						}
																						goto case 14;
																					case 12:
																						if ((int)(val5).ValueKind != 1)
																						{
																							num10 = 0;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
																							{
																								num10 = 0;
																							}
																							continue;
																						}
																						val2 = val5;
																						goto IL_0c92;
																					case 16:
																						_ = 7;
																						defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
																						_ = 14;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
																						{
																							_ = 18;
																						}
																						continue;
																					case 8:
																						num11 = QG7fcQnZHpU(element, "code", -2147483648);
																						num10 = 5;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
																						{
																							num10 = 23;
																						}
																						continue;
																					case 0:
																						val3 = default;
																						num10 = 11;
																						continue;
																					case 9:
																						throw (defaultInterpolatedStringHandler).ToStringAndClear();
																					case 7:
																						if ((int)(val4).ValueKind == 1)
																						{
																							text2 = Ru2fcCJSeJM(val4, "id");
																							num10 = 10;
																							continue;
																						}
																						num10 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
																						{
																							num10 = 26;
																						}
																						continue;
																					case 3:
																						(defaultInterpolatedStringHandler).AppendLiteral("（code=");
																						num10 = 15;
																						continue;
																					case 15:
																						defaultInterpolatedStringHandler.AppendFormatted<int>(num11);
																						num10 = 2;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
																						{
																							num10 = 6;
																						}
																						continue;
																					case 13:
																						throw new global::System.Exception("网易角色资料接口返回了不匹配的角色 ID");
																					case 4:
																						if ((val4).TryGetProperty("pe_growth", out val5))
																						{
																							num10 = 12;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
																							{
																								num10 = 21;
																							}
																							continue;
																						}
																						goto case 0;
																					case 5:
																						if (num11 == 0)
																						{
																							if (!(element).TryGetProperty("entity", out val4))
																							{
																								num10 = 24;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																								{
																									num10 = 17;
																								}
																								continue;
																							}
																							goto case 7;
																						}
																						num10 = 16;
																						continue;
																					case 11:
																						val2 = val3;
																						goto IL_0c92;
																					case 2:
																						break;
																						IL_0c92:
																						element2 = val2;
																						num12 = 26;
																						goto IL_08ae;
																						IL_08ae:
																						num10 = num12;
																						continue;
																					}
																					break;
																				}
																			}
																			finally
																			{
																				int num13;
																				if (num3 >= 0)
																				{
																					num13 = 3;
																					goto IL_105c;
																				}
																				goto IL_1084;
																				IL_1084:
																				if (val != null)
																				{
																					num13 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
																					{
																						num13 = 7;
																					}
																					goto IL_105c;
																				}
																				goto end_IL_1038;
																				IL_105c:
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
																					case 2:
																						break;
																					case 1:
																						(val).Dispose();
																						num13 = 7;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
																						{
																							num13 = 0;
																						}
																						continue;
																					case 3:
																						goto end_IL_105c;
																					case 0:
																						goto end_IL_105c;
																					}
																					goto IL_1084;
																					continue;
																					end_IL_105c:
																					break;
																				}
																				end_IL_1038:;
																			}
																		}
																		catch (JsonException ex)
																		{
																			JsonException ex2 = ex;
																			int num15 = 4;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
																			{
																				num15 = 0;
																			}
																			while (true)
																			{
																				switch (num15)
																				{
																				default:
																					if (num16 == 988)
																					{
																						goto IL_1114;
																					}
																					break;
																				case 0:
																					break;
																				}
																				break;
																				IL_1114:
																				num15 = num16;
																			}
																			_ = "网易角色资料接口响应格式无效";
																			throw ex2;
																		}
																		goto end_IL_056e;
																	}
																	IL_056a:
																	num7 = num17;
																	continue;
																}
																goto IL_06be;
																continue;
																end_IL_056e:
																break;
															}
														}
														finally
														{
															if (num3 < 0)
															{
																int num18 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
																{
																	num18 = 1;
																}
																while (true)
																{
																	switch (num18)
																	{
																	default:
																		if (num19 == 990)
																		{
																			num18 = num19;
																			continue;
																		}
																		goto case 0;
																	case 0:
																		(_response_5__3).Dispose();
																		num18 = 2;
																		continue;
																	case 1:
																		if (_response_5__3 != null)
																		{
																			num18 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
																			{
																				num18 = 0;
																			}
																			continue;
																		}
																		break;
																	case 2:
																		break;
																	}
																	break;
																}
															}
														}
														goto end_IL_0220;
													}
													break;
												}
												goto IL_02c6;
												IL_04dd:
												response_5__ = (HttpResponseMessage)(object)(&_u__2);
												int num20 = 4;
												goto IL_0250;
												IL_04ec:
												__u__1 = _u__2;
												num20 = 9;
												goto IL_0250;
												IL_034d:
												num20 = 25;
												goto IL_0250;
												IL_02c6:
												num20 = 6;
												goto IL_0250;
												IL_0250:
												num6 = num20;
												goto IL_0254;
												end_IL_0220:;
											}
											finally
											{
												if (num3 < 0)
												{
													int num21 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
													{
														num21 = 2;
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
															break;
														case 0:
															(_request_5__2).Dispose();
															num21 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
															{
																num21 = 3;
															}
															continue;
														case 2:
															if (_request_5__2 == null)
															{
																num21 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																{
																	num21 = 6;
																}
																continue;
															}
															goto case 0;
														case 1:
															break;
														case 3:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_00b2;
										}
										IL_00ae:
										num4 = num24;
										continue;
									}
									goto IL_00ec;
									continue;
									end_IL_00b2:
									break;
								}
								goto end_IL_0079;
								IL_00ec:
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
								{
									num4 = 5;
								}
								goto IL_00b2;
								end_IL_0079:;
							}
							catch (global::System.Exception)
							{
								int num25 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
								{
									num25 = 0;
								}
								while (true)
								{
									switch (num25)
									{
									default:
										if (num26 != 11)
										{
											if (num26 != 991)
											{
												break;
											}
											goto IL_1309;
										}
										_response_5__3 = null;
										num25 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
										{
											num25 = 2;
										}
										continue;
									case 0:
										_ = __t__builder;
										_ = 3;
										continue;
									case 2:
										_request_5__2 = null;
										num26 = 11;
										goto IL_1309;
									case 1:
										break;
									case 3:
										return;
										IL_1309:
										num25 = num26;
										continue;
									}
									__1__state = -2;
									num25 = 2;
								}
							}
							goto case 1;
						case 4:
							fu94HtfcD4m9fEW9IWJG = __4__this;
							num2 = 6;
							continue;
						case 1:
							__1__state = -2;
							num2 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num2 = 0;
							}
							continue;
						case 3:
							_response_5__3 = null;
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
							{
								num2 = 13;
							}
							continue;
						case 2:
							break;
						case 5:
							num3 = __1__state;
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
							{
								num2 = 4;
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
				while (num == 994);
				_ = __t__builder;
				_ = 13;
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
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							return;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								num3 = 8;
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
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool SV81xgDWxWIMIihijhHC()
		{
			return kOGkUcDWPehHxoyUy39N == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object T4gsibDWFCT1LGi4RtdT()
		{
			return kOGkUcDWPehHxoyUy39N;
		}
	}

	private static readonly object yF4fcUN0w0s;

	private readonly object Y8UfcrdNEEm;

	private bool V2efco52Ii7;

	private static object RHMV36ZpfMFwPDUy8x3T;

	[MethodImpl((MethodImplOptions)8)]
	internal Fu94HtfcD4m9fEW9IWJG()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		Fu94HtfcD4m9fEW9IWJG(nk0fcYU9W46());
		int num = 3;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
		{
			num = 0;
		}
		int num2 = default;
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			}
			if (num2 == 988)
			{
				num = num2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal Fu94HtfcD4m9fEW9IWJG(HttpMessageHandler handler)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<y6sHXkf3fhIBq5aFx6SX> L82fcVjRl8b(c7lEmkf1MoB1jUf1XEF1 session, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpMessageHandler nk0fcYU9W46()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpMessageHandler);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int yVkfcS5eMvy(JsonElement element, object propertyName)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return System.Math.Max(0, QG7fcQnZHpU(element, propertyName, 0));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<OWKoZxf3jBxC2YrDwBgN> lF7fccyZwtf(JsonElement entity)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool iiSfc0GDWvN(JsonElement entity)
	{
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected I4, but got Unknown
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		int num = 14;
		bool result = default;
		JsonElement value = default;
		JsonValueKind val = default;
		int num5 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 0;
					case 13:
						return false;
					case 6:
					case 7:
					case 11:
					case 16:
					case 17:
					case 18:
						return result;
					case 0:
					case 5:
						result = false;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num3 = 18;
						}
						continue;
					case 2:
						result = (value).GetArrayLength() > 0;
						num = 7;
						break;
					case 4:
						goto IL_0117;
					case 14:
						if ((entity).TryGetProperty("is_developer", out value))
						{
							val = (value).ValueKind;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
							{
								num3 = 22;
							}
							continue;
						}
						num = 13;
						break;
					case 10:
						goto IL_016a;
					case 9:
						num4 = ((!string.Equals((value).GetString(), "0", (StringComparison)4)) ? 1 : 0);
						goto IL_0252;
					case 3:
						result = num5 != 0;
						num3 = 17;
						continue;
					case 8:
						goto IL_01d0;
					case 12:
						goto IL_0201;
					case 1:
						switch (val - 1)
						{
						case 1:
							break;
						case 0:
							goto IL_0117;
						case 4:
							goto IL_016a;
						case 2:
							goto IL_01d0;
						case 3:
							goto IL_0201;
						default:
							goto IL_023b;
						}
						goto case 2;
					case 15:
						{
							num4 = 0;
							goto IL_0252;
						}
						IL_023b:
						num3 = 5;
						continue;
						IL_0201:
						if (!(value).TryGetInt32(out num5))
						{
							num = 25;
							break;
						}
						goto case 3;
						IL_01d0:
						if (string.IsNullOrWhiteSpace((value).GetString()))
						{
							num = 15;
							break;
						}
						goto case 9;
						IL_0252:
						result = (byte)num4 != 0;
						num3 = 11;
						continue;
						IL_016a:
						result = true;
						num3 = 6;
						continue;
						IL_0117:
						result = MFRfc8UtOJn(value);
						num3 = 16;
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
	private static bool MFRfc8UtOJn(JsonElement value)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ENRfcySg5Cv(JsonElement element, object propertyName)
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011d: Invalid comparison between Unknown and I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0204: Expected I4, but got Unknown
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		JsonValueKind val = default;
		JsonElement val2 = default;
		bool result = default;
		int num5 = default;
		int num4 = default;
		bool flag = default;
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
						if (num2 != 24 && num2 == 1005)
						{
							goto end_IL_0010;
						}
						goto case 3;
					case 16:
						return false;
					case 14:
						val = (val2).ValueKind;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							num3 = 15;
						}
						continue;
					case 3:
					case 7:
					case 8:
					case 12:
						return result;
					case 9:
						if (int.TryParse((val2).GetString(), out num5))
						{
							num3 = 10;
							continue;
						}
						goto case 1;
					case 10:
						result = num5 != 0;
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 12;
						}
						continue;
					case 5:
						if ((int)(element).ValueKind == 1)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto case 16;
					case 4:
						if ((element).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 16;
					case 17:
						result = true;
						num3 = 8;
						continue;
					case 13:
						result = num4 != 0;
						num = 7;
						break;
					case 0:
						result = flag;
						num = 24;
						break;
					case 11:
						goto IL_01b3;
					case 15:
						switch (val - 3)
						{
						case 2:
							break;
						case 0:
							goto IL_01b3;
						default:
							goto IL_0204;
						case 1:
							goto IL_0230;
						}
						goto case 17;
					case 1:
					case 6:
						result = false;
						num3 = 3;
						continue;
					case 2:
						goto IL_0230;
						IL_0230:
						if ((val2).TryGetInt32(out num4))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num3 = 13;
							}
							continue;
						}
						goto case 1;
						IL_0204:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
						{
							num3 = 9;
						}
						continue;
						IL_01b3:
						if (bool.TryParse((val2).GetString(), out flag))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 9;
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
	private static string fbdfcW8FPo0(JsonElement element, object objectName, object propertyName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static List<w6dBwqf3936qgl9ghrK7> VFYfcJc1pmf(JsonElement entity)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int QG7fcQnZHpU(JsonElement element, object propertyName, int fallback)
	{
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Invalid comparison between Unknown and I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		int num = 10;
		int result = default;
		int num5 = default;
		JsonElement val2 = default;
		JsonValueKind val = default;
		int num4 = default;
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
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto case 7;
					case 0:
						result = num5;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 12;
						}
						continue;
					case 9:
						if (!(element).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							val = (val2).ValueKind;
							num3 = 6;
						}
						continue;
					case 11:
						if ((int)val == 4)
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto case 7;
					case 7:
					case 13:
						result = fallback;
						num3 = 2;
						continue;
					case 4:
						if (!(val2).TryGetInt32(out num5))
						{
							num = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
							{
								num = 20;
							}
							break;
						}
						goto case 0;
					case 6:
						if ((int)val != 3)
						{
							num = 11;
							break;
						}
						goto case 5;
					case 2:
					case 3:
					case 12:
						return result;
					case 10:
						if ((int)(element).ValueKind == 1)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 1;
					case 1:
						return fallback;
					case 5:
						if (!int.TryParse((val2).GetString(), out num4))
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 8;
					case 8:
						result = num4;
						num3 = 3;
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
	private static string Ru2fcCJSeJM(JsonElement element, object propertyName, string fallback = "")
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Invalid comparison between Unknown and I4
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Invalid comparison between Unknown and I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Invalid comparison between Unknown and I4
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		string result = default;
		JsonValueKind val = default;
		JsonElement val2 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text;
					switch (num3)
					{
					default:
						if (num2 != 19 && num2 == 1000)
						{
							goto end_IL_0010;
						}
						goto case 11;
					case 4:
						if ((int)(element).ValueKind == 1)
						{
							num3 = 3;
							continue;
						}
						goto case 7;
					case 6:
					case 8:
					case 9:
						return result;
					case 0:
						if ((int)val != 3)
						{
							num3 = 2;
							continue;
						}
						goto case 12;
					case 1:
						result = (val2).GetRawText();
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						return fallback;
					case 10:
						val = (val2).ValueKind;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 0;
						}
						continue;
					case 11:
						result = fallback;
						num3 = 9;
						continue;
					case 3:
						if ((element).TryGetProperty((string)propertyName, out val2))
						{
							num = 10;
							break;
						}
						goto case 7;
					case 12:
						text = (val2).GetString();
						if (text == null)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto IL_019d;
					case 2:
						if ((int)val != 4)
						{
							num = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num = 19;
							}
							break;
						}
						goto case 1;
					case 5:
						{
							text = fallback;
							goto IL_019d;
						}
						IL_019d:
						result = text;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 8;
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
	public void Dispose()
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
						goto end_IL_0010;
					case 1:
						return;
					case 2:
						if (!V2efco52Ii7)
						{
							V2efco52Ii7 = true;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							num3 = 1;
						}
						continue;
					case 0:
						break;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			(Y8UfcrdNEEm).Dispose();
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PefEOhZpLUtYkDBtlJk3()
	{
		return RHMV36ZpfMFwPDUy8x3T == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Fu94HtfcD4m9fEW9IWJG kC2ZTGZpjyVfBtJIHBSo()
	{
		return (Fu94HtfcD4m9fEW9IWJG)RHMV36ZpfMFwPDUy8x3T;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;

namespace VZfsNuXA7S11f1qe8xel;

internal class DR7lSHXAmxCoFcuPoiOR
{
	internal static readonly object tpAXABRAxml;

	internal static object KGi7dyZOjZRYxB2mOF1Q;

	[MethodImpl((MethodImplOptions)8)]
	internal static Dictionary<string, string> fmsXAATRQ9S(object sauthWrapper, object expectedSdkUid)
	{
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Invalid comparison between Unknown and I4
		//IL_0336: Unknown result type (might be due to invalid IL or missing references)
		//IL_033c: Invalid comparison between Unknown and I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_036d: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aab: Unknown result type (might be due to invalid IL or missing references)
		//IL_056a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b07: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f2: Invalid comparison between Unknown and I4
		//IL_0c32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0485: Unknown result type (might be due to invalid IL or missing references)
		//IL_091d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_0973: Unknown result type (might be due to invalid IL or missing references)
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b58: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0->IL038b: Incompatible stack heights: 58 vs 1
		//IL_0aab->IL038b: Incompatible stack heights: 58 vs 1
		int num = 2;
		int num5 = default(int);
		int num11 = default(int);
		JsonElement val6 = default(JsonElement);
		JsonDocument val4 = default(JsonDocument);
		int num8 = default(int);
		string text2 = default(string);
		string text4 = default(string);
		Dictionary<string, string> result = default(Dictionary<string, string>);
		string text = default(string);
		string text3 = default(string);
		int num10 = default(int);
		int num14 = default(int);
		int num16 = default(int);
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
						}
						else
						{
							try
							{
								JsonDocumentOptions val = default(JsonDocumentOptions);
								(val).MaxDepth = 16;
								JsonDocument val2 = System.Text.Json.JsonDocument.Parse((string)sauthWrapper, val);
								int num4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
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
											goto IL_01b8;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_01b8:
									num4 = num5;
								}
								try
								{
									JsonElement val3 = (val2).RootElement;
									int num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
									{
										num6 = 8;
									}
									while (true)
									{
										int num12;
										switch (num6)
										{
										default:
											if (num11 != 11)
											{
												if (num11 == 991)
												{
													goto IL_0214;
												}
											}
											else if ((val3).TryGetProperty("sauth_json", out val6))
											{
												num12 = 3;
												goto IL_0210;
											}
											goto case 0;
										case 0:
											throw new global::System.Exception("原生票据需要已建立游戏会话的 SAuth 包装");
										case 1:
											if ((int)(val3).ValueKind == 1)
											{
												num12 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
												{
													num12 = 4;
												}
												goto IL_0210;
											}
											goto case 0;
										case 3:
											if ((int)(val6).ValueKind == 3)
											{
												string text5 = (val6).GetString();
												val = default(JsonDocumentOptions);
												(val).MaxDepth = 16;
												val4 = System.Text.Json.JsonDocument.Parse(text5, val);
												num6 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
												{
													num6 = 4;
												}
											}
											else
											{
												num6 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
												{
													num6 = 0;
												}
											}
											continue;
										case 2:
											{
												try
												{
													JsonElement source = (val4).RootElement;
													int num7 = 7;
													while (true)
													{
														switch (num7)
														{
														default:
															if (num8 == 20)
															{
																goto IL_0bb4;
															}
															if (num8 == 1000)
															{
																goto IL_0387;
															}
															goto case 0;
														case 7:
															if ((int)(source).ValueKind != 1)
															{
																num7 = 3;
																continue;
															}
															if ((g6UXAI4mHMr(source, "login_channel") != "netease"))
															{
																num7 = 12;
																continue;
															}
															goto case 2;
														case 10:
															throw new global::System.Exception("SAuth 的 SDK 用户与当前经典版游戏会话不一致");
														case 9:
															if (!(g6UXAI4mHMr(source, "platform") != "ad"))
															{
																num7 = 11;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																{
																	num7 = 1;
																}
																continue;
															}
															goto IL_0bb4;
														case 5:
														case 12:
															throw new global::System.Exception("第三方渠道需要独立发烧平台登录及账号关联后签发原生票据；不能用 4399 sessionid 代替网易 token 或平台 Bearer");
														case 2:
															if (!(g6UXAI4mHMr(source, "app_channel") != "netease"))
															{
																if (!(g6UXAI4mHMr(source, "gameid") != "x19"))
																{
																	num7 = 9;
																	continue;
																}
																goto IL_0bb4;
															}
															num7 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
															{
																num7 = 14;
															}
															continue;
														case 11:
														{
															System.StringComparer.Ordinal;
															_ = "app_channel";
															_ = "netease";
															_ = "app_mode";
															_ = "2";
															_ = "app_type";
															_ = "games";
															_ = "cv";
															_ = "a5.16.0";
															_ = "game_id";
															_ = "aecfrxodyqaaaajp-g-x19";
															_ = "gv";
															_ = "840287970";
															_ = "gvn";
															_ = "3.7.15.287970";
															_ = "jf_game_id";
															_ = "x19";
															_ = "pkg_channel";
															_ = "netease";
															_ = "sv";
															_ = "33";
															_ = "sc";
															_ = "1";
															_ = "_cloud_extra_base64";
															_ = "e30=";
															_ = "mcount_app_key";
															_ = "EEkEEXLymcNjM42yLY3Bn6AO15aGy4yq";
															_ = "mcount_transaction_id";
															Guid val5 = System.Guid.NewGuid();
															(val5).ToString("N");
															_ = "transid";
															val5 = System.Guid.NewGuid();
															(val5).ToString("N");
															_ = "ext_ci";
															(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes(string.Concat(text2, text4, "aecfrxodyqaaaajp-g-x19"))))).ToLowerInvariant();
															_ = "user_id";
															_ = "device_id";
															_ = "token";
															result = (Dictionary<string, string>)(object)text;
															_ = 13;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
															{
																_ = 4;
															}
															continue;
														}
														case 1:
															if ((g6UXAI4mHMr(source, "sdk_version") != "5.16.0"))
															{
																num8 = 20;
																goto IL_0387;
															}
															text3 = g6UXAI4mHMr(source, "sdkuid");
															num7 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
															{
																num7 = 3;
															}
															continue;
														case 6:
															text2 = g6UXAI4mHMr(source, "udid");
															num7 = 8;
															continue;
														case 3:
															throw new global::System.Exception("SAuth 正文不是对象");
														case 0:
															if (string.Equals(text3, (string)expectedSdkUid, (StringComparison)4))
															{
																text4 = g6UXAI4mHMr(source, "deviceid");
																num7 = 20;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																{
																	num7 = 6;
																}
															}
															else
															{
																num7 = 10;
															}
															continue;
														case 8:
															text = g6UXAI4mHMr(source, "sessionid");
															num7 = 11;
															continue;
														case 4:
															break;
															IL_0387:
															num7 = num8;
															continue;
															IL_0bb4:
															throw new global::System.Exception("当前只核对了 x19 Android 5.16.0 网易凭据来源，不能套用其他 SDK 的签发参数");
														}
														break;
													}
												}
												finally
												{
													int num9;
													if (val4 == null)
													{
														num9 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
														{
															num9 = 7;
														}
														goto IL_0c9d;
													}
													goto IL_0cc1;
													IL_0c9d:
													while (true)
													{
														switch (num9)
														{
														default:
															if (num10 == 990)
															{
																goto IL_0c99;
															}
															goto end_IL_0c9d;
														case 0:
															break;
														case 1:
															goto end_IL_0c9d;
														case 2:
															goto end_IL_0c9d;
														}
														goto IL_0cc1;
														IL_0c99:
														num9 = num10;
														continue;
														end_IL_0c9d:
														break;
													}
													goto end_IL_0c65;
													IL_0cc1:
													(val4).Dispose();
													num9 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
													{
														num9 = 4;
													}
													goto IL_0c9d;
													end_IL_0c65:;
												}
												break;
											}
											IL_0214:
											num6 = num11;
											continue;
											IL_0210:
											num11 = num12;
											goto IL_0214;
										}
										break;
									}
								}
								finally
								{
									if (val2 != null)
									{
										int num13 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
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
												(val2).Dispose();
												num13 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
												{
													num13 = 2;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
							}
							catch (JsonException)
							{
								int num15 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
								{
									num15 = 5;
								}
								while (true)
								{
									switch (num15)
									{
									default:
										if (num16 == 988)
										{
											goto IL_0dc3;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_0dc3:
									num15 = num16;
								}
								_ = "原生票据所需 SAuth 格式无效";
								throw new global::System.Exception("sauthWrapper");
							}
						}
						goto case 3;
					case 4:
						_ = "SAuth 大小超出原生票据请求限制";
						throw new global::System.Exception("sauthWrapper");
					case 1:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)expectedSdkUid, "expectedSdkUid");
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						return result;
					case 0:
						break;
					case 2:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)sauthWrapper, "sauthWrapper");
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					if ((System.Text.Encoding.UTF8).GetByteCount((string)sauthWrapper) <= 131072)
					{
						goto end_IL_000c;
					}
					num3 = 4;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string g6UXAI4mHMr(JsonElement source, object name)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Invalid comparison between Unknown and I4
		int num = 11;
		JsonElement val = default(JsonElement);
		int num4 = default(int);
		string text2 = default(string);
		string text = default(string);
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
							goto case 1;
						}
						goto case 2;
					case 11:
						if ((source).TryGetProperty((string)name, out val))
						{
							num3 = 10;
							continue;
						}
						goto case 9;
					case 5:
					case 8:
						if (num4 >= (text2).Length)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 12;
					case 10:
						if ((int)(val).ValueKind != 3)
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						text = (val).GetString();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 11;
						}
						continue;
					case 2:
						throw string.Concat("SAuth 的原生票据字段无效：", (string)name);
					case 4:
						if ((text).Length <= 4096)
						{
							text2 = text;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
							{
								num3 = 2;
							}
						}
						continue;
					case 3:
						if (string.IsNullOrWhiteSpace(text))
						{
							num = 19;
							break;
						}
						goto case 4;
					case 6:
						throw string.Concat("SAuth 的原生票据字段含控制字符：", (string)name);
					case 7:
						num4++;
						num = 8;
						break;
					case 9:
						throw string.Concat("SAuth 缺少原生票据所需字段：", (string)name);
					case 12:
						if (!char.IsControl((text2).Chars))
						{
							num = 7;
							break;
						}
						goto case 6;
					case 0:
						num4 = 0;
						num3 = 5;
						continue;
					case 1:
						return text;
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cv4KeAZOZ6f7taQpiOaJ()
	{
		return KGi7dyZOjZRYxB2mOF1Q == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static DR7lSHXAmxCoFcuPoiOR EL5leRZO9kkbDdo53x9G()
	{
		return (DR7lSHXAmxCoFcuPoiOR)KGi7dyZOjZRYxB2mOF1Q;
	}
}

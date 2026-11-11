using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using dDZeghfkcJHyjpQYG0bq;
using dHUo7PXIxudqosA07XUa;
using fDAldojjppXrctUVYOJn;
using zE0qbMXGcR37qePea3rj;

namespace rVq0LWfkfK0eTGp8Iklw;

internal class pnKqlafkXUAQlucSo3qa
{
	private static readonly object bqGfkYafQQP;

	private static object gy1sE8ZNaJvHldbyQL6j;

	[MethodImpl((MethodImplOptions)8)]
	internal static StDSbnfkSH7fjEfMgMeT C41fkL5dC6D(object input)
	{
		//IL_04d3: Expected O, but got Unknown
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Invalid comparison between Unknown and I4
		//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num4 = default(int);
		int num6 = default(int);
		JsonDocument val2 = default(JsonDocument);
		int num8 = default(int);
		string text2 = default(string);
		StDSbnfkSH7fjEfMgMeT result = default(StDSbnfkSH7fjEfMgMeT);
		string text = default(string);
		int num10 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 992)
					{
						goto end_IL_0010;
					}
					goto case 3;
				case 4:
					try
					{
						JsonDocument val = System.Text.Json.JsonDocument.Parse(((dynamic)(input)).Trim(), default(JsonDocumentOptions));
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_008b;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_008b:
							num3 = num4;
						}
						try
						{
							JsonElement root = (val).RootElement;
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
							{
								num5 = 6;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 10)
									{
										if (num6 == 990)
										{
											goto IL_00e7;
										}
										goto case 0;
									}
									try
									{
										JsonElement source = (val2).RootElement;
										int num7 = 6;
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 != 17)
												{
													if (num8 == 997)
													{
														goto IL_01d1;
													}
													goto case 2;
												}
												break;
											case 6:
												if ((int)(source).ValueKind != 1)
												{
													num7 = 4;
													continue;
												}
												text2 = mFkfkZIc2FP(source);
												num7 = 5;
												continue;
											case 9:
												result = EtkGAIXIPlNNpX0TxLg2.OCMXITfJH0R(text);
												num8 = 17;
												goto IL_01d1;
											case 0:
											case 8:
												if (!string.Equals(text2, "netease", (StringComparison)4))
												{
													num7 = 3;
													continue;
												}
												goto case 2;
											case 5:
												if (!string.Equals(text2, "4399com", (StringComparison)4))
												{
													num7 = 8;
													continue;
												}
												goto case 9;
											case 1:
												break;
											case 2:
												result = qZIfk9WxiIq(source);
												num7 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
												{
													num7 = 9;
												}
												continue;
											case 4:
												throw new InvalidOperationException("sauth_json 必须是 JSON 对象");
											case 3:
											case 7:
												{
													throw new InvalidOperationException(string.Concat("基岩移动端不支持渠道 ", text2));
												}
												IL_01d1:
												num7 = num8;
												continue;
											}
											break;
										}
									}
									finally
									{
										int num9;
										if (val2 == null)
										{
											num9 = 2;
											goto IL_03d9;
										}
										goto IL_0421;
										IL_0421:
										(val2).Dispose();
										num9 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											num9 = 0;
										}
										goto IL_03d9;
										IL_03d9:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_03d5;
												}
												goto end_IL_03d9;
											case 2:
												goto end_IL_03d9;
											case 1:
												break;
											case 0:
												goto end_IL_03d9;
											}
											goto IL_0421;
											IL_03d5:
											num9 = num10;
											continue;
											end_IL_03d9:
											break;
										}
									}
									goto end_IL_00eb;
								case 0:
									if ((int)(root).ValueKind != 1)
									{
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
										{
											num5 = 7;
										}
									}
									else
									{
										text = CPqfkjyTltr(root);
										num5 = 2;
									}
									break;
								case 1:
									throw new InvalidOperationException("SAuth 必须是 JSON 对象");
								case 2:
									{
										val2 = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
										num6 = 10;
										goto IL_00e7;
									}
									IL_00e7:
									num5 = num6;
									break;
								}
								continue;
								end_IL_00eb:
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num11 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
								{
									num11 = 5;
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
										(val).Dispose();
										num11 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
										{
											num11 = 0;
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
					catch (JsonException ex)
					{
						JsonException ex2 = ex;
						int num13 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num13 = 1;
						}
						while (true)
						{
							switch (num13)
							{
							default:
								if (num14 == 988)
								{
									goto IL_0500;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0500:
							num13 = num14;
						}
						throw new InvalidOperationException("SAuth 格式无效", (global::System.Exception)(object)ex2);
					}
					break;
				case 3:
					throw new ArgumentException("请先生成或粘贴 SAuth", "input");
				case 0:
					num2 = 4;
					continue;
				case 1:
					if (!string.IsNullOrWhiteSpace((string)input))
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 2:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string CPqfkjyTltr(JsonElement root)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = (val2).ValueKind;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string mFkfkZIc2FP(JsonElement source)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = (ctFfkkxslxT(source, "app_channel", string.Empty)).Trim();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static StDSbnfkSH7fjEfMgMeT qZIfk9WxiIq(JsonElement source)
	{
		//IL_0711: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		JsonDocument val2 = default(JsonDocument);
		string text = default(string);
		string text2 = default(string);
		string text5 = default(string);
		string text3 = default(string);
		string text6 = default(string);
		string text7 = default(string);
		int num5 = default(int);
		StDSbnfkSH7fjEfMgMeT result = default(StDSbnfkSH7fjEfMgMeT);
		int num7 = default(int);
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
							goto case 4;
						}
						val2 = System.Text.Json.JsonDocument.Parse(JsonSerializer.Serialize<Dictionary<string, object>>(new Dictionary<string, object>
						{
							["app_channel"] = "netease",
							["client_login_sn"] = text,
							["gameid"] = ctFfkkxslxT(source, "gameid", "x19"),
							["get_access_token"] = ctFfkkxslxT(source, "get_access_token", "1"),
							["ip"] = ctFfkkxslxT(source, "ip", "127.0.0.1"),
							["login_channel"] = "netease",
							["platform"] = ctFfkkxslxT(source, "platform", "ad"),
							["sdk_version"] = text2,
							["sdkuid"] = text5,
							["sessionid"] = text3,
							["udid"] = text6,
							["deviceid"] = text7
						}, (JsonSerializerOptions)bqGfkYafQQP), default(JsonDocumentOptions));
						num3 = 4;
						continue;
					case 3:
						text5 = PJafkDBPsmo(source, "sdkuid", "SAuth 缺少 sdkuid");
						num3 = 2;
						continue;
					case 4:
						try
						{
							string text4 = (source).GetRawText();
							int num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_00ea;
								}
								string wrapperJson = JsonSerializer.Serialize<Dictionary<string, string>>(new Dictionary<string, string> { ["sauth_json"] = text4 }, (JsonSerializerOptions)bqGfkYafQQP);
								JsonElement val = (val2).RootElement;
								result = (StDSbnfkSH7fjEfMgMeT)new StDSbnfkSH7fjEfMgMeT(wrapperJson, text4, (val).Clone(), "netease", text5, text6, text2, b01LeFXGSG18tqTkKDCm.xNrXG0DnBQA("netease"));
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
								{
									num4 = 1;
								}
								continue;
								end_IL_00ea:
								break;
							}
						}
						finally
						{
							int num6;
							if (val2 == null)
							{
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
								{
									num6 = 0;
								}
								goto IL_0203;
							}
							goto IL_024b;
							IL_0203:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_01ff;
									}
									goto end_IL_0203;
								case 0:
									goto end_IL_0203;
								case 1:
									break;
								case 2:
									goto end_IL_0203;
								}
								goto IL_024b;
								IL_01ff:
								num6 = num7;
								continue;
								end_IL_0203:
								break;
							}
							goto end_IL_01cb;
							IL_024b:
							(val2).Dispose();
							num6 = 2;
							goto IL_0203;
							end_IL_01cb:;
						}
						goto case 7;
					case 6:
						text6 = PJafkDBPsmo(source, "udid", "网易 SAuth 缺少 udid");
						num3 = 5;
						continue;
					case 1:
						break;
					case 2:
						text3 = PJafkDBPsmo(source, "sessionid", "SAuth 缺少 sessionid");
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						text2 = ctFfkkxslxT(source, "sdk_version", "5.16.0");
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 1;
						}
						continue;
					case 7:
						return result;
					case 0:
						text = PJafkDBPsmo(source, "client_login_sn", "网易 SAuth 缺少 client_login_sn");
						num3 = 6;
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
			text7 = ctFfkkxslxT(source, "deviceid", string.Empty);
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
			{
				num = 14;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PJafkDBPsmo(JsonElement source, object propertyName, object message)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = ctFfkkxslxT(source, propertyName, string.Empty);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ctFfkkxslxT(JsonElement source, object propertyName, object fallback)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = (val2).ValueKind;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xs3PJDZN1BiLtDdtUHxM()
	{
		return gy1sE8ZNaJvHldbyQL6j == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static pnKqlafkXUAQlucSo3qa UbR3NTZN3nCeNcPifcjW()
	{
		return (pnKqlafkXUAQlucSo3qa)gy1sE8ZNaJvHldbyQL6j;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using dDZeghfkcJHyjpQYG0bq;
using dHUo7PXIxudqosA07XUa;
using zE0qbMXGcR37qePea3rj;

namespace rVq0LWfkfK0eTGp8Iklw;

internal class pnKqlafkXUAQlucSo3qa
{
	private static object bqGfkYafQQP;

	private static object gy1sE8ZNaJvHldbyQL6j;

	[MethodImpl((MethodImplOptions)8)]
	internal static StDSbnfkSH7fjEfMgMeT C41fkL5dC6D(object input)
	{
		//IL_04c7: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Invalid comparison between Unknown and I4
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Invalid comparison between Unknown and I4
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
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
						JsonDocument val = System.Text.Json.JsonDocument.Parse((input).Trim(), default(JsonDocumentOptions));
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
														goto IL_01cd;
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
												goto IL_01cd;
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
												throw new global::System.Exception("sauth_json 必须是 JSON 对象");
											case 3:
											case 7:
												{
													throw string.Concat("基岩移动端不支持渠道 ", text2);
												}
												IL_01cd:
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
											goto IL_03cd;
										}
										goto IL_0415;
										IL_0415:
										(val2).Dispose();
										num9 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											num9 = 0;
										}
										goto IL_03cd;
										IL_03cd:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_03c9;
												}
												goto end_IL_03cd;
											case 2:
												goto end_IL_03cd;
											case 1:
												break;
											case 0:
												goto end_IL_03cd;
											}
											goto IL_0415;
											IL_03c9:
											num9 = num10;
											continue;
											end_IL_03cd:
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
									throw new global::System.Exception("SAuth 必须是 JSON 对象");
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
									goto IL_04f4;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_04f4:
							num13 = num14;
						}
						_ = "SAuth 格式无效";
						throw ex2;
					}
					break;
				case 3:
					_ = "请先生成或粘贴 SAuth";
					throw new global::System.Exception("input");
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
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Invalid comparison between Unknown and I4
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Invalid comparison between Unknown and I4
		int num = 7;
		JsonValueKind val = default(JsonValueKind);
		JsonElement val2 = default(JsonElement);
		string result = default(string);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
						}
						else if ((int)val == 3)
						{
							num3 = 8;
							continue;
						}
						goto case 5;
					case 9:
						return (root).GetRawText();
					case 6:
						val = (val2).ValueKind;
						num3 = 4;
						continue;
					case 7:
						if ((root).TryGetProperty("sauth_json", out val2))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 9;
					case 1:
						result = (val2).GetRawText();
						num3 = 2;
						continue;
					case 8:
						if (string.IsNullOrWhiteSpace((val2).GetString()))
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 13;
							}
							continue;
						}
						goto case 0;
					case 5:
					case 10:
						throw new global::System.Exception("SAuth 包装中的 sauth_json 无效");
					case 2:
					case 3:
						return result;
					case 0:
						result = (val2).GetString();
						num = 3;
						break;
					case 4:
						if ((int)val != 1)
						{
							num = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num = 17;
							}
							break;
						}
						goto case 1;
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
	private static string mFkfkZIc2FP(JsonElement source)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static StDSbnfkSH7fjEfMgMeT qZIfk9WxiIq(JsonElement source)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PJafkDBPsmo(JsonElement source, object propertyName, object message)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ctFfkkxslxT(JsonElement source, object propertyName, object fallback)
	{
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected I4, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		string result = default(string);
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = default(JsonValueKind);
		while (true)
		{
			int num2 = num;
			while (true)
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
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 9;
						}
						obj = fallback;
						goto IL_01d5;
					case 9:
						result = (string)fallback;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							num3 = 17;
						}
						continue;
					case 5:
					case 11:
						goto IL_0088;
					case 0:
					case 4:
					case 8:
						return result;
					case 10:
						goto IL_00d4;
					case 2:
						if ((source).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 15;
							}
							continue;
						}
						goto case 6;
					case 6:
						return (string)fallback;
					case 1:
						val = (val2).ValueKind;
						num3 = 3;
						continue;
					case 3:
						switch (val - 3)
						{
						case 4:
							break;
						case 2:
						case 3:
							goto IL_0088;
						case 0:
							goto IL_00d4;
						default:
							goto IL_0177;
						case 1:
							goto IL_01bc;
						}
						goto case 9;
					case 7:
						goto IL_01bc;
						IL_01bc:
						result = (val2).GetRawText();
						num = 8;
						break;
						IL_0177:
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
						{
							num3 = 15;
						}
						continue;
						IL_0088:
						throw string.Concat("SAuth 的 ", (string)propertyName, " 类型无效");
						IL_00d4:
						obj = (val2).GetString();
						if (obj == null)
						{
							num = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num = 1;
							}
							break;
						}
						goto IL_01d5;
						IL_01d5:
						result = (string)obj;
						num3 = 4;
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
	private static void _cctor()
	{
		//IL_0032: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		_ = 5;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a;
		(2).Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
		bqGfkYafQQP = 2;
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

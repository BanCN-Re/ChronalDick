using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using bUfedyCg1PBqhqIkB8r;

namespace SxsGGAfLOxcpiFNutOL1;

internal class vCdkuBfLtLlHd38qlo2M
{
	private static readonly object W9ifLsTTHVX;

	internal static object mKSRVFZTrGBKfuEmiOvA;

	[MethodImpl((MethodImplOptions)8)]
	internal static string mF5fL54OaVw(global::System.ReadOnlySpan<byte> bytes)
	{
		return (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(bytes))).ToLowerInvariant();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string n0CfL6pyLYP(object value)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string a2VfLRPfDcZ(global::System.ReadOnlySpan<byte> responseBytes)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0453: Invalid comparison between Unknown and I4
		//IL_02fb: Expected O, but got I4
		//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ef: Invalid comparison between Unknown and I4
		//IL_07c8->IL06da: Incompatible stack heights: 4 vs 1
		//IL_07d3->IL06da: Incompatible stack heights: 4 vs 1
		//IL_0249->IL00ff: Incompatible stack heights: 2 vs 1
		//IL_0305->IL00ff: Incompatible stack heights: 2 vs 1
		int num = 2;
		string text = default(string);
		int num9 = default(int);
		int num11 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		JsonElement val2 = default(JsonElement);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string result = default(string);
		JsonElement val3 = default(JsonElement);
		string value = default(string);
		string text4 = default(string);
		int num14 = default(int);
		int num16 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num5 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num3 = 2;
						}
						continue;
					case 3:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
						try
						{
							JsonDocument val = System.Text.Json.JsonDocument.Parse(text, default(JsonDocumentOptions));
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
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
										goto IL_00b4;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00b4:
								num8 = num9;
							}
							try
							{
								JsonElement root = (val).RootElement;
								int num10 = 26;
								while (true)
								{
									string text2;
									int num12;
									string text3;
									switch (num10)
									{
									default:
										if (num11 != 34)
										{
											if (num11 == 1014)
											{
												goto IL_00fb;
											}
											goto case 10;
										}
										(defaultInterpolatedStringHandler).AppendLiteral("message=");
										num10 = 18;
										continue;
									case 19:
										if ((root).TryGetProperty("code", out val2))
										{
											num10 = 4;
											continue;
										}
										goto case 10;
									case 7:
										(defaultInterpolatedStringHandler2).AppendLiteral(" utf8_valid=true sha256=");
										num10 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
										{
											num10 = 11;
										}
										continue;
									case 0:
										_ = 56;
										defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)4;
										_ = 21;
										continue;
									case 20:
										(defaultInterpolatedStringHandler).AppendLiteral(" utf8_valid=true sha256=");
										num10 = 22;
										continue;
									case 17:
										defaultInterpolatedStringHandler2.AppendFormatted<JsonValueKind>((root).ValueKind);
										num10 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
										{
											num10 = 10;
										}
										continue;
									case 13:
										result = (defaultInterpolatedStringHandler2).ToStringAndClear();
										num10 = 5;
										continue;
									case 2:
										(defaultInterpolatedStringHandler2).AppendFormatted(mF5fL54OaVw(responseBytes));
										num10 = 13;
										continue;
									case 9:
									case 23:
										text2 = string.Empty;
										break;
									case 25:
										_ = 34;
										defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
										_ = 8;
										continue;
									case 14:
										if (!(root).TryGetProperty("message", out val3))
										{
											num12 = 23;
											goto IL_00f7;
										}
										goto case 24;
									case 21:
										(defaultInterpolatedStringHandler).AppendLiteral("json_kind=object code=");
										num10 = 6;
										continue;
									case 11:
										result = (defaultInterpolatedStringHandler).ToStringAndClear();
										num10 = 16;
										continue;
									case 15:
										(defaultInterpolatedStringHandler).AppendLiteral(" ");
										num12 = 34;
										goto IL_00f7;
									case 5:
										goto end_IL_00ff;
									case 10:
										text3 = "none";
										goto IL_05d8;
									case 24:
										if ((int)(val3).ValueKind == 3)
										{
											text2 = (val3).GetString();
											if (text2 == null)
											{
												num10 = 12;
												continue;
											}
											break;
										}
										num10 = 9;
										continue;
									case 18:
										(defaultInterpolatedStringHandler).AppendFormatted(C6qfLFqdb7u(value));
										num10 = 20;
										continue;
									case 1:
										(defaultInterpolatedStringHandler).AppendFormatted(wdFfLxuRPU5(root));
										num10 = 15;
										continue;
									case 8:
										(defaultInterpolatedStringHandler2).AppendLiteral("json_kind=");
										num10 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
										{
											num10 = 17;
										}
										continue;
									case 26:
										if ((int)(root).ValueKind != 1)
										{
											num10 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
											{
												num10 = 25;
											}
											continue;
										}
										goto case 19;
									case 6:
										(defaultInterpolatedStringHandler).AppendFormatted(text4);
										num10 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
										{
											num10 = 2;
										}
										continue;
									case 3:
										(defaultInterpolatedStringHandler).AppendLiteral(" ");
										num10 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
										{
											num10 = 27;
										}
										continue;
									case 22:
										(defaultInterpolatedStringHandler).AppendFormatted(mF5fL54OaVw(responseBytes));
										num10 = 11;
										continue;
									case 4:
										text3 = (val2).GetRawText();
										goto IL_05d8;
									case 12:
										text2 = string.Empty;
										break;
									case 16:
										goto end_IL_00ff;
										IL_00fb:
										num10 = num11;
										continue;
										IL_00f7:
										num11 = num12;
										goto IL_00fb;
										IL_05d8:
										text4 = text3;
										num10 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num10 = 27;
										}
										continue;
									}
									value = text2;
									num10 = 24;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num10 = 0;
									}
									continue;
									end_IL_00ff:
									break;
								}
							}
							finally
							{
								if (val != null)
								{
									int num13 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
									{
										num13 = 0;
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
										case 0:
											break;
										case 1:
											goto end_IL_065c;
										}
										(val).Dispose();
										num13 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
										{
											num13 = 1;
										}
										continue;
										end_IL_065c:
										break;
									}
								}
							}
						}
						catch (JsonException)
						{
							int num15 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
							{
								num15 = 0;
							}
							while (true)
							{
								int num17;
								switch (num15)
								{
								default:
									switch (num16)
									{
									case 994:
										break;
									default:
										goto end_IL_06da;
									case 14:
										defaultInterpolatedStringHandler3.AppendFormatted<int>((System.Text.Encoding.UTF8).GetByteCount(text));
										num15 = 5;
										continue;
									}
									goto IL_06d6;
								case 2:
									(defaultInterpolatedStringHandler3).AppendLiteral("text_bytes=");
									num17 = 14;
									goto IL_06d2;
								case 1:
									(defaultInterpolatedStringHandler3).AppendFormatted(mF5fL54OaVw(responseBytes));
									num15 = 3;
									continue;
								case 5:
									result = (defaultInterpolatedStringHandler3).ToStringAndClear();
									num15 = 4;
									continue;
								case 0:
									_ = defaultInterpolatedStringHandler3;
									_ = 44;
									_ = 2;
									_ = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
									{
										_ = 6;
									}
									continue;
								case 3:
									(defaultInterpolatedStringHandler3).AppendLiteral(" ");
									num17 = 2;
									goto IL_06d2;
								case 6:
									(defaultInterpolatedStringHandler3).AppendLiteral("non_json utf8_valid=true sha256=");
									num15 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num15 = 10;
									}
									continue;
								case 4:
									break;
									IL_06d6:
									num15 = num16;
									continue;
									IL_06d2:
									num16 = num17;
									goto IL_06d6;
									end_IL_06da:
									break;
								}
								break;
							}
						}
						goto case 5;
					case 5:
						return result;
					case 4:
						try
						{
							text = ((W9ifLsTTHVX).GetString(responseBytes)).Trim();
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
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
						catch (DecoderFallbackException)
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								case 0:
									break;
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 1:
									result = string.Concat("non_utf8 utf8_valid=false sha256=", mF5fL54OaVw(responseBytes));
									num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								break;
							}
							goto case 5;
						}
						goto case 3;
					case 2:
						if (&responseBytes != null)
						{
							break;
						}
						goto case 1;
					case 1:
						return string.Concat("empty utf8_valid=true sha256=", mF5fL54OaVw(responseBytes));
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
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
			{
				num = 12;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long mpofLwxFF61(object path)
	{
		int num = 1;
		int num4 = default(int);
		long result = default(long);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num2 = 2;
						}
						goto IL_0075;
					}
					long num3 = (path).Length;
					goto IL_00ad;
					IL_0075:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num4 == 989)
							{
								goto IL_0071;
							}
							goto end_IL_0075;
						case 0:
							num3 = 0L;
							break;
						case 1:
							goto end_IL_0075;
						}
						goto IL_00ad;
						IL_0071:
						num2 = num4;
						continue;
						end_IL_0075:
						break;
					}
					goto end_IL_0034;
					IL_00ad:
					result = num3;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 1;
					}
					goto IL_0075;
					end_IL_0034:;
				}
				catch (global::System.Exception)
				{
					int num5 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
					{
						num5 = 2;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 989)
							{
								num5 = num6;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							goto end_IL_0105;
						}
						result = -1L;
						num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							num5 = 7;
						}
						continue;
						end_IL_0105:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string oNffLe2WTrV(object process)
	{
		int num = 1;
		int num3 = default(int);
		string result = default(string);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					global::System.DateTime dateTime = (process).StartTime;
					int num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								num2 = num3;
								continue;
							}
							goto case 1;
						case 1:
							dateTime = (dateTime).ToUniversalTime();
							num2 = 2;
							continue;
						case 2:
							result = (dateTime).ToString("O");
							num2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num2 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
					{
						num4 = 7;
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
							goto end_IL_012e;
						}
						result = "unknown";
						num4 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
						{
							num4 = 1;
						}
						continue;
						end_IL_012e:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long ntyfLPXRB9S(object process)
	{
		int num = 1;
		long result = default(long);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					result = (process).WorkingSet64;
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num4 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
					{
						num4 = 1;
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
						case 1:
							break;
						case 0:
							goto end_IL_00c5;
						}
						result = -1L;
						num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num4 = 5;
						}
						continue;
						end_IL_00c5:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string DescribeProcessState(object process)
	{
		//IL_00b1: Expected O, but got I4
		//IL_0058->IL0075: Incompatible stack heights: 1 vs 2
		//IL_0063->IL0075: Incompatible stack heights: 1 vs 2
		int num = 1;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num3 = default(int);
		string result = default(string);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					int num2;
					if (!(process).HasExited)
					{
						_ = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
						{
							_ = 0;
						}
					}
					else
					{
						_ = 26;
						defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
						num2 = 3;
					}
					while (true)
					{
						string text;
						switch (num2)
						{
						default:
							if (num3 != 11)
							{
								if (num3 == 991)
								{
									goto IL_0071;
								}
								goto case 2;
							}
							text = (defaultInterpolatedStringHandler).ToStringAndClear();
							break;
						case 3:
							(defaultInterpolatedStringHandler).AppendLiteral("has_exited=true exit_code=");
							num2 = 2;
							continue;
						case 2:
						{
							defaultInterpolatedStringHandler.AppendFormatted<int>((process).ExitCode);
							int num4 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num4 = 8;
							}
							num3 = num4;
							goto IL_0071;
						}
						case 0:
							text = "has_exited=false exit_code=none";
							break;
						case 1:
							goto end_IL_0075;
							IL_0071:
							num2 = num3;
							continue;
						}
						result = text;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
						{
							num2 = 8;
						}
						continue;
						end_IL_0075:
						break;
					}
				}
				catch (global::System.Exception ex)
				{
					int num5 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
					{
						num5 = 4;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 990)
							{
								num5 = num6;
								continue;
							}
							goto case 2;
						case 2:
							result = string.Concat("has_exited=unknown exit_code=unknown state_error=", ((ex).GetType()).Name);
							num5 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								num5 = 1;
							}
							continue;
						case 0:
							cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "DescribeProcessState", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\BedrockProtocolDiagnostics.cs", 110);
							num5 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
							{
								num5 = 2;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string wdFfLxuRPU5(JsonElement root)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string C6qfLFqdb7u(object value)
	{
		int num = 2;
		string text = default(string);
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
				case 0:
					return string.Concat((text).Substring(0, 160), "...");
				case 1:
					if ((text).Length <= 160)
					{
						return text;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					text = (((value).Replace('\r', ' ')).Replace('\n', ' ')).Trim();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
					{
						num2 = 4;
					}
					break;
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
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jRuWSuZToACcIESSSl7x()
	{
		return mKSRVFZTrGBKfuEmiOvA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static vCdkuBfLtLlHd38qlo2M uqwOqtZTmiTW3TS5c5r9()
	{
		return (vCdkuBfLtLlHd38qlo2M)mKSRVFZTrGBKfuEmiOvA;
	}
}

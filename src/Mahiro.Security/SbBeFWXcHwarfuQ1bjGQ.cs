using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Text.RegularExpressions;
using CZUx5njfSrbl1tnMcUCO;
using XqoLwmfxKZ22pXoXD9rh;
using fDAldojjppXrctUVYOJn;
using rlILWsvtm9ixMhTgFNA;

namespace awQBbMXctWBW6q02gRKG;

internal class SbBeFWXcHwarfuQ1bjGQ
{
	internal static object Nu7TxvZBvaaSn5joT3rO;

	[MethodImpl((MethodImplOptions)8)]
	internal static fj8YrGvHp5swHSNT9Nh CPIXcORpCgQ(JsonElement root, object settings)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = V5IXcNrsBF5(root, "jvm_arguments");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static List<string> FdBXc5xkvEL(JsonElement root, object settings)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = V5IXcNrsBF5(root, "minecraftArguments");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string K20Xc6Nhcuk(JsonElement root)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = V5IXcNrsBF5(root, "mainClass");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IRsXcRq7ahw(JsonElement library)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static List<string> rMmXcwXXv1Z(JsonElement root, object group, object settings)
	{
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05da: Invalid comparison between Unknown and I4
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0582: Invalid comparison between Unknown and I4
		//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Invalid comparison between Unknown and I4
		//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0364: Invalid comparison between Unknown and I4
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Invalid comparison between Unknown and I4
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_039e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Invalid comparison between Unknown and I4
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		JsonElement val3 = default(JsonElement);
		ArrayEnumerator enumerator = default(ArrayEnumerator);
		ArrayEnumerator val2 = default(ArrayEnumerator);
		List<string> result = default(List<string>);
		JsonElement val = default(JsonElement);
		JsonElement value = default(JsonElement);
		int num9 = default(int);
		JsonElement value3 = default(JsonElement);
		JsonElement rules = default(JsonElement);
		ArrayEnumerator val4 = default(ArrayEnumerator);
		int num6 = default(int);
		JsonElement value2 = default(JsonElement);
		int num8 = default(int);
		int num11 = default(int);
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
							goto case 3;
						}
						goto case 6;
					case 0:
						if (!(root).TryGetProperty("arguments", out val3))
						{
							num = 6;
							break;
						}
						goto case 8;
					case 3:
						enumerator = val2.GetEnumerator();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
						{
							num3 = 1;
						}
						continue;
					case 5:
						return result;
					case 7:
						if ((val3).TryGetProperty((string)group, out val))
						{
							num3 = 4;
							continue;
						}
						goto case 6;
					case 2:
						try
						{
							while (true)
							{
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
									{
										num4 = 20;
									}
									goto IL_0112;
								}
								goto IL_02c7;
								IL_02c7:
								value = (enumerator).Current;
								num4 = 15;
								goto IL_0112;
								IL_0112:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num9 != 24)
										{
											if (num9 == 1004)
											{
												goto IL_010e;
											}
											goto case 3;
										}
										if ((value).TryGetProperty("value", out value3))
										{
											num4 = 6;
											continue;
										}
										break;
									case 2:
									case 7:
									case 14:
										break;
									case 0:
										if ((int)(value).ValueKind != 1)
										{
											break;
										}
										num9 = 24;
										goto IL_010e;
									case 6:
										if (!(value).TryGetProperty("rules", out rules))
										{
											num4 = 11;
											continue;
										}
										goto case 10;
									case 3:
										val2 = val4.GetEnumerator();
										num4 = 8;
										continue;
									case 11:
									case 12:
										if ((int)(value3).ValueKind == 3)
										{
											num4 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
											{
												num4 = 6;
											}
											continue;
										}
										goto case 9;
									case 1:
										gkRXce5JP3G(result, value3);
										num4 = 14;
										continue;
									case 13:
										val4 = value3.EnumerateArray();
										num4 = 3;
										continue;
									case 4:
										goto IL_02c7;
									case 10:
										if (lhAXcPOScRy(rules, settings))
										{
											num4 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
											{
												num4 = 21;
											}
											continue;
										}
										break;
									case 16:
										gkRXce5JP3G(result, value);
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num4 = 7;
										}
										continue;
									case 9:
										if ((int)(value3).ValueKind == 2)
										{
											num4 = 13;
											continue;
										}
										break;
									case 15:
										if ((int)(value).ValueKind == 3)
										{
											num4 = 16;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
											{
												num4 = 22;
											}
											continue;
										}
										goto case 0;
									case 8:
										try
										{
											while (true)
											{
												IL_0434:
												int num5;
												if (!(val2).MoveNext())
												{
													num5 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
													{
														num5 = 1;
													}
													goto IL_03ea;
												}
												goto IL_041c;
												IL_03e6:
												num5 = num6;
												goto IL_03ea;
												IL_03ea:
												while (true)
												{
													switch (num5)
													{
													case 2:
														goto end_IL_03ea;
													case 0:
														goto IL_0434;
													case 1:
														goto end_IL_0434;
													}
													switch (num6)
													{
													case 990:
														break;
													default:
														goto end_IL_0434;
													case 10:
														gkRXce5JP3G(result, value2);
														num5 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
														{
															num5 = 0;
														}
														continue;
													}
													goto IL_03e6;
													continue;
													end_IL_03ea:
													break;
												}
												goto IL_041c;
												IL_041c:
												value2 = (val2).Current;
												num6 = 10;
												goto IL_03e6;
												continue;
												end_IL_0434:
												break;
											}
										}
										finally
										{
											((global::System.IDisposable)(val2)/*cast due to .constrained prefix*/).Dispose();
											int num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
											{
												num7 = 0;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 == 988)
													{
														num7 = num8;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										break;
									case 5:
										goto end_IL_017c;
										IL_010e:
										num4 = num9;
										continue;
									}
									break;
								}
								continue;
								end_IL_017c:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										num10 = num11;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 5;
					case 8:
						if ((int)(val3).ValueKind == 1)
						{
							num = 7;
							break;
						}
						goto case 6;
					case 1:
						result = new List<string>();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
						{
							num3 = 3;
						}
						continue;
					case 6:
						return result;
					case 4:
						if ((int)(val).ValueKind == 2)
						{
							val2 = val.EnumerateArray();
							num3 = 3;
							continue;
						}
						num = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
						{
							num = 13;
						}
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
	private static void gkRXce5JP3G(List<string> result, JsonElement value)
	{
		string text = (value).GetString();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool lhAXcPOScRy(JsonElement rules, object? settings)
	{
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Invalid comparison between Unknown and I4
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		ArrayEnumerator val = default(ArrayEnumerator);
		bool result = default(bool);
		ArrayEnumerator enumerator = default(ArrayEnumerator);
		JsonElement val2 = default(JsonElement);
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
						if (num2 == 11)
						{
							val = rules.EnumerateArray();
							num3 = 3;
							continue;
						}
						goto IL_0037;
					case 4:
						return result;
					case 0:
						return false;
					case 2:
						try
						{
							while (true)
							{
								IL_01b4:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
									{
										num4 = 8;
									}
									goto IL_00a8;
								}
								goto IL_0187;
								IL_0187:
								val2 = (enumerator).Current;
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
								{
									num4 = 7;
								}
								goto IL_00a8;
								IL_00a8:
								while (true)
								{
									switch (num4)
									{
									default:
										switch (num5)
										{
										case 992:
											break;
										case 12:
											goto IL_012a;
										default:
											goto IL_01b4;
										}
										goto IL_00a4;
									case 1:
										if ((int)(val2).ValueKind == 1)
										{
											num4 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
											{
												num4 = 3;
											}
											continue;
										}
										goto IL_01b4;
									case 3:
										if (!KiUXcxPO5UH(val2, settings))
										{
											goto IL_01b4;
										}
										num5 = 12;
										goto IL_00a4;
									case 4:
										break;
									case 2:
										goto IL_01b4;
									case 0:
										goto end_IL_01b4;
										IL_012a:
										result = !string.Equals(V5IXcNrsBF5(val2, "action"), "disallow", (StringComparison)5);
										num4 = 2;
										continue;
										IL_00a4:
										num4 = num5;
										continue;
									}
									break;
								}
								goto IL_0187;
								continue;
								end_IL_01b4:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
							int num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
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
						goto case 4;
					case 1:
						break;
					case 3:
						enumerator = val.GetEnumerator();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num3 = 7;
						}
						continue;
					}
					goto IL_024e;
					IL_0037:
					if (num2 == 992)
					{
						break;
					}
					goto IL_024e;
					IL_024e:
					if ((int)(rules).ValueKind == 2)
					{
						goto end_IL_000c;
					}
					num3 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
					{
						num3 = 0;
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			result = false;
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool KiUXcxPO5UH(JsonElement rule, object? settings)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool yoTXcF25p1S(JsonElement os)
	{
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		string text = default(string);
		bool result = default(bool);
		string text3 = default(string);
		int num5 = default(int);
		int num7 = default(int);
		string text2 = default(string);
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
						if (num2 == 17)
						{
							return false;
						}
						goto IL_004f;
					case 0:
						return true;
					case 1:
						return false;
					case 4:
						text = V5IXcNrsBF5(os, "arch");
						num3 = 2;
						continue;
					case 3:
						if (!DSKXcsBPMEP(text))
						{
							goto end_IL_000c;
						}
						goto IL_02d9;
					case 7:
						try
						{
							result = System.Text.RegularExpressions.Regex.IsMatch((System.Environment.OSVersion).VersionString, text3, (RegexOptions)513, System.TimeSpan.FromSeconds(1.0));
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
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
						catch (ArgumentException)
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0197;
								}
								result = false;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
								{
									num6 = 4;
								}
								continue;
								end_IL_0197:
								break;
							}
						}
						break;
					case 6:
						text2 = V5IXcNrsBF5(os, "name");
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 5;
						}
						continue;
					case 8:
						if (string.Equals(text2, "windows", (StringComparison)5))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 1;
					case 5:
						if ((text2).Length > 0)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 4;
					case 9:
						if ((text3).Length != 0)
						{
							num3 = 7;
							continue;
						}
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						if ((text).Length > 0)
						{
							num3 = 3;
							continue;
						}
						goto IL_02d9;
					case 10:
						break;
						IL_02d9:
						text3 = V5IXcNrsBF5(os, "version");
						num3 = 9;
						continue;
					}
					goto IL_0328;
					IL_004f:
					if (num2 == 998)
					{
						break;
					}
					goto IL_0328;
					IL_0328:
					return result;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool DSKXcsBPMEP(object expected)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		Architecture val = System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool zXTXcT2O0Oi(JsonElement features, object? settings)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Invalid comparison between Unknown and I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		ObjectEnumerator val4 = default(ObjectEnumerator);
		ObjectEnumerator enumerator = default(ObjectEnumerator);
		JsonProperty val = default(JsonProperty);
		int num6 = default(int);
		JsonElement val2 = default(JsonElement);
		bool flag2 = default(bool);
		JsonValueKind val3 = default(JsonValueKind);
		bool flag = default(bool);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 3;
				case 3:
					val4 = features.EnumerateObject();
					num2 = 2;
					break;
				case 2:
					enumerator = val4.GetEnumerator();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
					{
						num2 = 7;
					}
					break;
				case 1:
					try
					{
						while (true)
						{
							IL_0301:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 20;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
								{
									num3 = 13;
								}
								goto IL_00aa;
							}
							goto IL_024f;
							IL_024f:
							val = (enumerator).Current;
							num3 = 12;
							goto IL_00aa;
							IL_00aa:
							while (true)
							{
								int num4;
								int num5;
								switch (num3)
								{
								default:
									if (num6 != 26)
									{
										if (num6 == 1006)
										{
											goto IL_00a6;
										}
										goto case 17;
									}
									if (string.Equals((val).Name, "has_custom_resolution", (StringComparison)5))
									{
										num4 = 3;
										goto IL_00a2;
									}
									num5 = 0;
									goto IL_034a;
								case 11:
									num5 = 0;
									goto IL_034a;
								case 18:
									val2 = (val).Value;
									num3 = 8;
									continue;
								case 17:
									num5 = (((tkF3LRfxdkiPD0dqhesT)settings).AutoSetWindowSize ? 1 : 0);
									goto IL_034a;
								case 6:
									flag2 = true;
									num3 = 20;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
									{
										num3 = 1;
									}
									continue;
								case 0:
									if ((int)val3 - 5 <= 1)
									{
										num3 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
										{
											num3 = 13;
										}
										continue;
									}
									goto case 7;
								case 3:
									if (settings != null)
									{
										num3 = 17;
										continue;
									}
									goto case 11;
								case 10:
									val3 = (val2).ValueKind;
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
									{
										num3 = 24;
									}
									continue;
								case 9:
									flag2 = false;
									num3 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
									{
										num3 = 2;
									}
									continue;
								case 14:
									break;
								case 12:
									val2 = (val).Value;
									num3 = 10;
									continue;
								case 2:
									goto end_IL_0301;
								case 15:
									flag2 = false;
									num4 = 16;
									goto IL_00a2;
								case 1:
								case 5:
									if (!flag2)
									{
										num3 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
										{
											num3 = 15;
										}
										continue;
									}
									goto case 18;
								case 7:
									flag2 = false;
									num3 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
									{
										num3 = 5;
									}
									continue;
								case 16:
									goto end_IL_0301;
								case 4:
									goto IL_0301;
								case 8:
									flag = (val2).GetBoolean();
									num4 = 26;
									goto IL_00a2;
								case 13:
									goto IL_03ef;
									IL_034a:
									if (num5 != (flag ? 1 : 0))
									{
										num3 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
										{
											num3 = 9;
										}
										continue;
									}
									goto IL_0301;
									IL_00a2:
									num6 = num4;
									goto IL_00a6;
									IL_00a6:
									num3 = num6;
									continue;
								}
								break;
							}
							goto IL_024f;
							continue;
							end_IL_0301:
							break;
						}
					}
					finally
					{
						((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
						int num7 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								if (num8 == 988)
								{
									num7 = num8;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					return flag2;
				case 0:
					goto IL_03ef;
					IL_03ef:
					return true;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string V5IXcNrsBF5(JsonElement element, object name)
	{
		int num = 3;
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
	internal static bool styE3sZBE638jHrRylTQ()
	{
		return Nu7TxvZBvaaSn5joT3rO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SbBeFWXcHwarfuQ1bjGQ O5ni9vZB2JCUkC2NNlJ5()
	{
		return (SbBeFWXcHwarfuQ1bjGQ)Nu7TxvZBvaaSn5joT3rO;
	}
}

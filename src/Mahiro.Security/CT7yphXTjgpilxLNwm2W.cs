using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json;
using A4N75AfjcfnnFqO7s8ad;
using CZUx5njfSrbl1tnMcUCO;
using URYDCfoED4sjjHBaoJH;
using fDAldojjppXrctUVYOJn;

namespace SjVltUXTZSd31mYkgsbs;

internal class CT7yphXTjgpilxLNwm2W
{
	private static object JqSvaXZw8HUr056E9M9N;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lZkXT90aBQN(object error)
	{
		FBhZZEfjSCpnoTvxnkUd fBhZZEfjSCpnoTvxnkUd = error as FBhZZEfjSCpnoTvxnkUd;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string HrPXTDmk3TW(object error)
	{
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Unknown result type (might be due to invalid IL or missing references)
		//IL_050f: Invalid comparison between Unknown and I4
		//IL_04cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d5: Invalid comparison between Unknown and I4
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_041a: Invalid comparison between Unknown and I4
		//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b9: Invalid comparison between Unknown and I4
		int num = 1;
		FBhZZEfjSCpnoTvxnkUd fBhZZEfjSCpnoTvxnkUd = default(FBhZZEfjSCpnoTvxnkUd);
		Win32Exception ex2 = default(Win32Exception);
		HeOiCXovnuVhGHyE2EO heOiCXovnuVhGHyE2EO = default(HeOiCXovnuVhGHyE2EO);
		int num11 = default(int);
		int num8 = default(int);
		JsonElement val3 = default(JsonElement);
		string text2 = default(string);
		JsonElement val6 = default(JsonElement);
		string text3 = default(string);
		bool flag = default(bool);
		JsonElement val4 = default(JsonElement);
		string[] array = default(string[]);
		string result = default(string);
		JsonValueKind val5 = default(JsonValueKind);
		bool flag2 = default(bool);
		int num10 = default(int);
		int num13 = default(int);
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
						if (num2 != 24)
						{
							if (num2 == 1005)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto case 9;
					case 15:
						if (fBhZZEfjSCpnoTvxnkUd != null)
						{
							num3 = 4;
							continue;
						}
						goto case 11;
					case 2:
						if (ex2 == null)
						{
							num3 = 9;
							continue;
						}
						goto end_IL_000c;
					case 7:
						try
						{
							JsonDocument val = System.Text.Json.JsonDocument.Parse(heOiCXovnuVhGHyE2EO.Detail, default(JsonDocumentOptions));
							int num4 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num11 == 989)
									{
										goto IL_00fa;
									}
									break;
								case 0:
									try
									{
										JsonElement val2 = (val).RootElement;
										int num5 = 26;
										while (true)
										{
											IL_0141:
											int num6 = num5;
											while (true)
											{
												IL_0145:
												int num7 = num6;
												while (true)
												{
													switch (num7)
													{
													default:
														if (num6 != 36)
														{
															if (num6 == 1016)
															{
																goto IL_0145;
															}
															goto case 22;
														}
														goto case 0;
													case 14:
														num8 = 0;
														num5 = 13;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
														{
															num5 = 36;
														}
														break;
													case 2:
													case 7:
														if ((val2).TryGetProperty("pythonErrorType", out val3))
														{
															num7 = 25;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
															{
																num7 = 11;
															}
															continue;
														}
														goto case 16;
													case 3:
														text2 = string.Concat(text2, " native_stage=", (val6).GetString());
														num7 = 7;
														continue;
													case 15:
														if (!AysXTkg0w3E((val6).GetString()))
														{
															num7 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
															{
																num7 = 35;
															}
															continue;
														}
														goto case 3;
													case 22:
													{
														string[] obj2 = new string[5]
														{
															text2,
															" ",
															text3,
															"=",
															null
														};
														flag = (val4).GetBoolean();
														obj2[4] = ((flag).ToString()).ToLowerInvariant();
														text2 = string.Concat(obj2);
														num7 = 6;
														continue;
													}
													case 16:
														array = new string[2]
														{
															"threadStarted",
															"threadCompleted"
														};
														num7 = 14;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
														{
															num7 = 2;
														}
														continue;
													case 9:
														result = text2;
														num7 = 27;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
														{
															num7 = 26;
														}
														continue;
													case 28:
														if (flag)
														{
															num7 = 22;
															continue;
														}
														goto case 6;
													case 25:
														if ((int)(val3).ValueKind == 3)
														{
															num7 = 10;
															continue;
														}
														goto case 16;
													case 0:
														if (num8 >= array.Length)
														{
															num7 = 7;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
															{
																num7 = 23;
															}
															continue;
														}
														goto case 18;
													case 10:
														if (iTaXTV3fZJF((val3).GetString()))
														{
															num7 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
															{
																num7 = 1;
															}
															continue;
														}
														goto case 16;
													case 26:
														if ((int)(val2).ValueKind != 1)
														{
															num7 = 9;
															continue;
														}
														goto case 21;
													case 17:
														if ((int)(val6).ValueKind == 3)
														{
															num7 = 15;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
															{
																num7 = 31;
															}
															continue;
														}
														goto case 2;
													case 18:
														text3 = array[num8];
														num7 = 12;
														continue;
													case 8:
														if ((int)val5 - 5 > 1)
														{
															num7 = 24;
															continue;
														}
														goto case 20;
													case 6:
														num8++;
														num7 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
														{
															num7 = 21;
														}
														continue;
													case 13:
													case 24:
														flag2 = false;
														num7 = 11;
														continue;
													case 21:
														if ((val2).TryGetProperty("runtimeStage", out val6))
														{
															num7 = 17;
															continue;
														}
														goto case 2;
													case 20:
														flag2 = true;
														num7 = 19;
														continue;
													case 4:
														val5 = (val4).ValueKind;
														num7 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
														{
															num7 = 32;
														}
														continue;
													case 11:
													case 19:
														flag = flag2;
														num7 = 28;
														continue;
													case 12:
														flag = (val2).TryGetProperty(text3, out val4);
														num7 = 5;
														continue;
													case 1:
														text2 = string.Concat(text2, " python_error_type=", (val3).GetString());
														num7 = 16;
														continue;
													case 5:
														if (flag)
														{
															num7 = 4;
															continue;
														}
														goto case 28;
													case 23:
														goto end_IL_0149;
													case 27:
														return result;
													}
													goto IL_0141;
													continue;
													end_IL_0149:
													break;
												}
												break;
											}
											break;
										}
									}
									finally
									{
										if (val != null)
										{
											int num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
											{
												num9 = 2;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													if (num10 == 989)
													{
														num9 = num10;
														continue;
													}
													break;
												case 0:
													break;
												case 1:
													goto end_IL_06bc;
												}
												(val).Dispose();
												num9 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
												{
													num9 = 1;
												}
												continue;
												end_IL_06bc:
												break;
											}
										}
									}
									break;
								case 1:
									break;
								}
								break;
								IL_00fa:
								num4 = num11;
							}
						}
						catch (JsonException)
						{
							int num12 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 988)
									{
										num12 = num13;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 3;
					case 3:
						return text2;
					case 8:
						return text2;
					case 17:
					{
						string text = text2;
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(51, 3);
						(defaultInterpolatedStringHandler).AppendLiteral(" native_status=0x");
						defaultInterpolatedStringHandler.AppendFormatted<uint>(heOiCXovnuVhGHyE2EO.Status, "X8");
						(defaultInterpolatedStringHandler).AppendLiteral(" windows_error=0x");
						defaultInterpolatedStringHandler.AppendFormatted<uint>(heOiCXovnuVhGHyE2EO.WindowsError, "X8");
						(defaultInterpolatedStringHandler).AppendLiteral(" cleanup_error=0x");
						defaultInterpolatedStringHandler.AppendFormatted<uint>(heOiCXovnuVhGHyE2EO.CleanupWindowsError, "X8");
						text2 = string.Concat(text, (defaultInterpolatedStringHandler).ToStringAndClear());
						num3 = 5;
						continue;
					}
					case 10:
						if (heOiCXovnuVhGHyE2EO != null)
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 8;
					case 0:
						text2 = string.Concat("error=", ((error).GetType()).Name);
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 4;
						}
						continue;
					case 14:
						goto end_IL_000c;
					case 12:
						if ((heOiCXovnuVhGHyE2EO.Detail).Length > 4096)
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num3 = 13;
							}
						}
						else
						{
							num3 = 7;
						}
						continue;
					case 16:
						return text2;
					case 11:
						ex2 = (Win32Exception)((error is Win32Exception) ? error : null);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
					{
						string text4 = text2;
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
						(defaultInterpolatedStringHandler2).AppendLiteral(" thread_exit=0x");
						defaultInterpolatedStringHandler2.AppendFormatted<uint>(fBhZZEfjSCpnoTvxnkUd.ExitCode, "X8");
						text2 = string.Concat(text4, (defaultInterpolatedStringHandler2).ToStringAndClear());
						num3 = 11;
						continue;
					}
					case 5:
						if (!string.IsNullOrEmpty(heOiCXovnuVhGHyE2EO.Detail))
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto case 16;
					case 1:
						System.ArgumentNullException.ThrowIfNull(error, "error");
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 0;
						}
						continue;
					case 9:
						obj = error as HeOiCXovnuVhGHyE2EO;
						if (obj == null)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
							{
								num3 = 5;
							}
							continue;
						}
						break;
					case 13:
						fBhZZEfjSCpnoTvxnkUd = error as FBhZZEfjSCpnoTvxnkUd;
						num3 = 15;
						continue;
					case 6:
						obj = ((dynamic)(error)).InnerException as HeOiCXovnuVhGHyE2EO;
						break;
					}
					heOiCXovnuVhGHyE2EO = (HeOiCXovnuVhGHyE2EO)obj;
					num3 = 10;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			string text5 = text2;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(17, 1);
			(defaultInterpolatedStringHandler3).AppendLiteral(" windows_error=0x");
			defaultInterpolatedStringHandler3.AppendFormatted<uint>((uint)(ex2).NativeErrorCode, "X8");
			text2 = string.Concat(text5, (defaultInterpolatedStringHandler3).ToStringAndClear());
			num = 24;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool AysXTkg0w3E(object? value)
	{
		int num = ((dynamic)(value)).Length;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool iTaXTV3fZJF(object? value)
	{
		int num = ((dynamic)(value)).Length;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Aa2chGZwy4CaDB308XcG()
	{
		return JqSvaXZw8HUr056E9M9N == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static CT7yphXTjgpilxLNwm2W FpMXblZwWwqKVFxLi7Im()
	{
		return (CT7yphXTjgpilxLNwm2W)JqSvaXZw8HUr056E9M9N;
	}
}

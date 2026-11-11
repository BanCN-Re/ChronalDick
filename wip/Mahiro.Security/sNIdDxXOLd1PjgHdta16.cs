using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using HN5yyEfpz8TLMVS2CfPf;
using PmD8yTfLjwM0m5QodEpn;
using UPDUUoX5BPGXslf8pqn8;
using dyVsfqXwqLxdTbSEAqwt;
using fDAldojjppXrctUVYOJn;

namespace KyrneTXOjI67ChfCkaOP;

internal class sNIdDxXOLd1PjgHdta16
{
	internal static object PHsiU5Z5i2c0NS3FQdHL;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool chrXOZLhJSF(object installation, out string failure)
	{
		return QPlXO9tJZfJ(installation, iKfXODpkKVY(((xssD3cfpnxdefR05FuDD)installation).InstallationPath), out failure);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool QPlXO9tJZfJ(object installation, bool requirePatchManifest, out string failure)
	{
		//IL_0b0a: Ignored invalid 'constrained' prefix
		//IL_00f5: Expected O, but got Ref
		//IL_04ac: Expected O, but got I4
		//IL_072f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0735: Unknown result type (might be due to invalid IL or missing references)
		//IL_0798: Unknown result type (might be due to invalid IL or missing references)
		//IL_079d: Unknown result type (might be due to invalid IL or missing references)
		//IL_083d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Invalid comparison between Unknown and I4
		//IL_0897: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0915: Unknown result type (might be due to invalid IL or missing references)
		//IL_091b: Invalid comparison between Unknown and I4
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0->IL0113: Incompatible stack heights: 4 vs 1
		//IL_04cb->IL0113: Incompatible stack heights: 4 vs 1
		int num = 2;
		bool result = default(bool);
		int num19 = default(int);
		string text3 = default(string);
		string text4 = default(string);
		string text2 = default(string);
		long num18 = default(long);
		string failure2 = default(string);
		bool flag = default(bool);
		string missingModule = default(string);
		FileStream val2 = default(FileStream);
		int num5 = default(int);
		int num7 = default(int);
		ObjectEnumerator val6 = default(ObjectEnumerator);
		int num10 = default(int);
		JsonProperty val7 = default(JsonProperty);
		int num9 = default(int);
		int num12 = default(int);
		ObjectEnumerator val4 = default(ObjectEnumerator);
		JsonElement val5 = default(JsonElement);
		int num14 = default(int);
		int num16 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num20);
		global::System.Exception ex = default(global::System.Exception);
		int num22 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num21);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num24 = default(int);
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
				case 1:
					failure = string.Empty;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
					{
						num2 = 8;
					}
					break;
				case 3:
					return result;
				case 2:
					System.ArgumentNullException.ThrowIfNull(installation, "installation");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
					{
						num2 = 5;
					}
					break;
				case 0:
					try
					{
						global::System.ReadOnlySpan<char> readOnlySpan = ((System.ReadOnlySpan<char>)(System.IO.Path.GetFullPath(((xssD3cfpnxdefR05FuDD)installation).InstallationPath)).TrimEnd(new char[2]
						{
							Path.DirectorySeparatorChar,
							Path.AltDirectorySeparatorChar
						}));
						char directorySeparatorChar = Path.DirectorySeparatorChar;
						string text = string.Concat(readOnlySpan, (global::System.ReadOnlySpan<char>)(&directorySeparatorChar));
						int num3 = 41;
						while (true)
						{
							int num17;
							switch (num3)
							{
							default:
								if (num19 != 53)
								{
									if (num19 == 1033)
									{
										goto IL_010f;
									}
									goto case 9;
								}
								goto case 43;
							case 38:
								break;
							case 4:
								break;
							case 2:
								if (RrKXOVwTrly(text3))
								{
									num17 = 14;
									goto IL_010b;
								}
								goto case 9;
							case 10:
								failure = "客户端补丁校验清单大小无效";
								num3 = 31;
								continue;
							case 31:
								result = false;
								num3 = 35;
								continue;
							case 16:
							case 44:
								result = true;
								num17 = 19;
								goto IL_010b;
							case 3:
							case 6:
								text4 = System.IO.Path.Combine(text2, "patch.json");
								num17 = 27;
								goto IL_010b;
							case 28:
							case 42:
								num18 = (text4).Length;
								num3 = 7;
								continue;
							case 34:
								if (num18 > 67108864)
								{
									num17 = 37;
									goto IL_010b;
								}
								goto case 36;
							case 39:
								failure = "客户端补丁校验清单缺失";
								num3 = 25;
								continue;
							case 14:
							case 29:
								text2 = System.IO.Path.GetDirectoryName(text3);
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
								{
									num3 = 23;
								}
								continue;
							case 35:
								break;
							case 25:
								result = false;
								num3 = 5;
								continue;
							case 27:
								if (System.IO.File.Exists(text4))
								{
									num3 = 28;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num3 = 28;
									}
									continue;
								}
								goto case 18;
							case 7:
								if (num18 <= 0)
								{
									num3 = 22;
									continue;
								}
								goto case 34;
							case 12:
								if (!VJKuWuX5I6KF2Sjds1dw.jW5X5ddVP6O(installation, out failure2))
								{
									num3 = 6;
									continue;
								}
								goto case 11;
							case 5:
								break;
							case 19:
								break;
							case 8:
							case 26:
								if (flag)
								{
									num3 = 10;
									continue;
								}
								goto case 20;
							case 0:
								failure = string.Concat("运行组件 ", missingModule, " 缺失");
								num17 = 17;
								goto IL_010b;
							case 40:
								result = false;
								num3 = 23;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
								{
									num3 = 1;
								}
								continue;
							case 20:
								_ = 3;
								_ = 1;
								val2 = (FileStream)(object)7;
								_ = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
								{
									_ = 21;
								}
								continue;
							case 1:
								break;
							case 24:
								failure = "无法确定客户端运行目录";
								num3 = 30;
								continue;
							case 45:
								result = false;
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
								{
									num3 = 33;
								}
								continue;
							case 32:
								if ((text3).StartsWith(text, (StringComparison)5))
								{
									num3 = 2;
									continue;
								}
								goto case 9;
							case 41:
								text3 = System.IO.Path.GetFullPath(((xssD3cfpnxdefR05FuDD)installation).ExecutablePath);
								num3 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
								{
									num3 = 11;
								}
								continue;
							case 11:
								failure = failure2;
								num3 = 40;
								continue;
							case 33:
								break;
							case 18:
								if (!requirePatchManifest)
								{
									num3 = 16;
									continue;
								}
								goto case 39;
							case 36:
								flag = false;
								num3 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
								{
									num3 = 8;
								}
								continue;
							case 17:
								result = false;
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
								{
									num3 = 38;
								}
								continue;
							case 43:
								if (Jvu7JOfLL0r7v1NOWoPw.dnQfLZs7QsK(installation, out missingModule))
								{
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num3 = 28;
									}
									continue;
								}
								goto case 12;
							case 15:
								if (!System.IO.Directory.Exists(((xssD3cfpnxdefR05FuDD)installation).InstallationPath))
								{
									num3 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto case 32;
							case 23:
								if (!string.IsNullOrWhiteSpace(text2))
								{
									num17 = 53;
									goto IL_010b;
								}
								goto case 24;
							case 9:
							case 13:
								failure = "Minecraft.Windows.exe 缺失或为空";
								num3 = 47;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
								{
									num3 = 45;
								}
								continue;
							case 30:
								result = false;
								num3 = 4;
								continue;
							case 22:
							case 37:
								flag = true;
								num17 = 26;
								goto IL_010b;
							case 21:
								{
									try
									{
										JsonDocument val = System.Text.Json.JsonDocument.Parse((Stream)(object)val2, default(JsonDocumentOptions));
										int num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
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
													goto IL_0770;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_0770:
											num4 = num5;
										}
										try
										{
											JsonElement val3 = (val).RootElement;
											int num6 = 5;
											while (true)
											{
												switch (num6)
												{
												default:
													if (num7 != 25)
													{
														if (num7 != 1005)
														{
															break;
														}
														goto IL_07b7;
													}
													try
													{
														while (true)
														{
															IL_0ad8:
															int num8;
															if (!(val6).MoveNext())
															{
																num8 = 6;
																goto IL_0970;
															}
															goto IL_0ab3;
															IL_0970:
															while (true)
															{
																switch (num8)
																{
																case 6:
																	break;
																default:
																	if (num10 != 15)
																	{
																		if (num10 == 995)
																		{
																			goto IL_096c;
																		}
																		goto case 1;
																	}
																	if (!RrKXOVwTrly(SYUagtXw2B6wGlhI1DG3.C4tXwndefmY(text2, (val7).Name)))
																	{
																		num8 = 7;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																		{
																			num8 = 1;
																		}
																		continue;
																	}
																	goto IL_0ad8;
																case 1:
																	failure = string.Concat("运行组件 ", System.IO.Path.GetFileName((val7).Name), " 缺失或为空");
																	num8 = 12;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
																	{
																		num8 = 0;
																	}
																	continue;
																case 4:
																	if (c2sXOkkp2cd((val7).Name))
																	{
																		num8 = 5;
																		continue;
																	}
																	goto IL_0ad8;
																case 7:
																	goto end_IL_093a;
																case 2:
																	goto IL_0ab3;
																case 0:
																	result = false;
																	num8 = 7;
																	continue;
																case 3:
																	goto IL_0ad8;
																case 5:
																	{
																		num9++;
																		num10 = 15;
																		goto IL_096c;
																	}
																	IL_096c:
																	num8 = num10;
																	continue;
																}
																break;
															}
															break;
															IL_0ab3:
															val7 = (val6).Current;
															num8 = 4;
															goto IL_0970;
														}
														goto case 12;
														end_IL_093a:;
													}
													finally
													{
														_ = val6;
														int num11 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
														{
															num11 = 4;
														}
														while (true)
														{
															switch (num11)
															{
															default:
																if (num12 == 988)
																{
																	num11 = num12;
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
												case 12:
													if (num9 != 0)
													{
														num6 = 9;
														continue;
													}
													goto case 0;
												case 2:
													val4 = val5;
													num6 = 8;
													continue;
												case 13:
													result = false;
													num6 = 4;
													continue;
												case 6:
													if (!(val3).TryGetProperty("md5", ref val5))
													{
														num6 = 10;
														continue;
													}
													goto case 16;
												case 8:
													val6 = val4;
													num7 = 25;
													goto IL_07b7;
												case 17:
													result = false;
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
													{
														num6 = 12;
													}
													continue;
												case 3:
												case 9:
													result = true;
													num6 = 7;
													continue;
												case 0:
													failure = "客户端补丁校验清单未包含运行组件";
													num6 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
													{
														num6 = 13;
													}
													continue;
												case 16:
													if ((int)(val5).ValueKind != 1)
													{
														num6 = 15;
														continue;
													}
													goto case 14;
												case 4:
													break;
												case 10:
												case 15:
													failure = "客户端补丁校验清单格式无效";
													num6 = 17;
													continue;
												case 5:
													if ((int)(val3).ValueKind == 1)
													{
														num6 = 11;
														continue;
													}
													goto case 10;
												case 1:
													break;
												case 14:
													num9 = 0;
													num6 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
													{
														num6 = 6;
													}
													continue;
												case 11:
													val3 = (val).RootElement;
													num6 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
													{
														num6 = 0;
													}
													continue;
												case 7:
													break;
													IL_07b7:
													num6 = num7;
													continue;
												}
												break;
											}
										}
										finally
										{
											if (val != null)
											{
												int num13 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
												{
													num13 = 1;
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
														break;
													case 0:
														goto end_IL_0c95;
													}
													(val).Dispose();
													num13 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
													{
														num13 = 1;
													}
													continue;
													end_IL_0c95:
													break;
												}
											}
										}
									}
									finally
									{
										int num15;
										if (val2 == null)
										{
											num15 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
											{
												num15 = 2;
											}
											goto IL_0d19;
										}
										goto IL_0d61;
										IL_0d19:
										while (true)
										{
											switch (num15)
											{
											default:
												if (num16 == 990)
												{
													goto IL_0d15;
												}
												break;
											case 2:
												goto end_IL_0d19;
											case 0:
												break;
											case 1:
												goto end_IL_0d19;
											}
											goto IL_0d61;
											IL_0d15:
											num15 = num16;
											continue;
											end_IL_0d19:
											break;
										}
										goto end_IL_0ce1;
										IL_0d61:
										(val2).Dispose();
										num15 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
										{
											num15 = 6;
										}
										goto IL_0d19;
										end_IL_0ce1:;
									}
									break;
								}
								IL_010f:
								num3 = num19;
								continue;
								IL_010b:
								num19 = num17;
								goto IL_010f;
							}
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num20 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								num20 = 5;
							}
						}
						else
						{
							ex = obj2;
							num20 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								num20 = 3;
							}
						}
						while (true)
						{
							switch (num20)
							{
							default:
								if (num22 != 22)
								{
									if (num22 == 1002)
									{
										goto IL_0dcb;
									}
									goto case 4;
								}
								goto case 0;
							case 1:
								if (ex is JsonException)
								{
									num21 = 22;
									goto IL_0dc7;
								}
								goto case 10;
							case 3:
								if (ex is IOException)
								{
									num20 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num20 = 6;
									}
									continue;
								}
								goto case 12;
							case 12:
								if (!(ex is UnauthorizedAccessException))
								{
									num20 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
									{
										num20 = 8;
									}
									continue;
								}
								goto case 0;
							case 11:
								if (!(ex is NotSupportedException))
								{
									num20 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
									{
										num20 = 5;
									}
									continue;
								}
								goto case 0;
							case 10:
								if (ex is ArgumentException)
								{
									num20 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
									{
										num20 = 6;
									}
									continue;
								}
								goto case 11;
							case 8:
								if (ex is InvalidDataException)
								{
									num20 = 14;
									continue;
								}
								goto case 1;
							case 0:
							case 2:
							case 6:
							case 14:
								flag = true;
								num20 = 4;
								continue;
							case 7:
							case 13:
								flag = false;
								num21 = 9;
								goto IL_0dc7;
							case 5:
								result2 = 0;
								break;
							case 4:
							case 9:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0dcb:
								num20 = num22;
								continue;
								IL_0dc7:
								num22 = num21;
								goto IL_0dcb;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num23 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num23 = 0;
						}
						while (true)
						{
							switch (num23)
							{
							default:
								if (num24 == 990)
								{
									num23 = num24;
									continue;
								}
								break;
							case 2:
								result = false;
								num23 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
								{
									num23 = 1;
								}
								continue;
							case 0:
								failure = "客户端完整性校验失败";
								num23 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
								{
									num23 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 3;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool iKfXODpkKVY(object installationPath)
	{
		//IL_03c0: Ignored invalid 'constrained' prefix
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ae: Invalid comparison between Unknown and I4
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Invalid comparison between Unknown and I4
		int num = 1;
		int num13 = default(int);
		JsonDocument val2 = default(JsonDocument);
		int num5 = default(int);
		ObjectEnumerator val4 = default(ObjectEnumerator);
		ObjectEnumerator val3 = default(ObjectEnumerator);
		int num8 = default(int);
		JsonProperty val5 = default(JsonProperty);
		string text2 = default(string);
		bool result = default(bool);
		int num10 = default(int);
		int num12 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
		global::System.Exception ex = default(global::System.Exception);
		int num15 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num17 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			default:
				return false;
			case 1:
				{
					try
					{
						string text = System.IO.Path.Combine(System.IO.Path.GetFullPath((string)installationPath), ".mahiro-install.json");
						int num2 = 5;
						while (true)
						{
							switch (num2)
							{
							default:
								if (num13 != 13)
								{
									if (num13 != 993)
									{
										break;
									}
									goto IL_0086;
								}
								goto end_IL_0010;
							case 5:
								if (System.IO.File.Exists(text))
								{
									num2 = 2;
									continue;
								}
								goto case 0;
							case 1:
								try
								{
									JsonElement val = (val2).RootElement;
									int num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
									{
										num3 = 4;
									}
									while (true)
									{
										switch (num3)
										{
										default:
											switch (num5)
											{
											case 994:
												break;
											default:
												goto end_IL_0147;
											case 14:
												val4 = val3;
												num3 = 2;
												continue;
											}
											goto IL_0143;
										case 1:
										{
											val3 = val;
											int num4 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
											{
												num4 = 14;
											}
											num5 = num4;
											goto IL_0143;
										}
										case 2:
											try
											{
												while (true)
												{
													IL_0338:
													int num6;
													if (!(val4).MoveNext())
													{
														num6 = 17;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
														{
															num6 = 18;
														}
														goto IL_01c7;
													}
													goto IL_030b;
													IL_02ef:
													if ((int)(val).ValueKind != 3)
													{
														continue;
													}
													num6 = 6;
													goto IL_01c7;
													IL_01cb:
													int num7 = num8;
													goto IL_01cf;
													IL_030b:
													val5 = (val4).Current;
													num7 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
													{
														num7 = 9;
													}
													goto IL_01cf;
													IL_01c7:
													num8 = num6;
													goto IL_01cb;
													IL_01cf:
													while (true)
													{
														switch (num7)
														{
														default:
															if (num8 != 18)
															{
																if (num8 == 998)
																{
																	goto IL_01cb;
																}
																goto case 6;
															}
															goto end_IL_008a;
														case 4:
															if ((text2).Contains("patch.json", (StringComparison)5))
															{
																num7 = 2;
																continue;
															}
															goto IL_0338;
														case 1:
															val = (val5).Value;
															num7 = 7;
															continue;
														case 5:
															break;
														case 3:
															if (string.IsNullOrWhiteSpace(text2))
															{
																num7 = 9;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
																{
																	num7 = 0;
																}
																continue;
															}
															goto case 4;
														case 2:
															result = true;
															num7 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
															{
																num7 = 9;
															}
															continue;
														case 7:
															goto IL_02ef;
														case 8:
															goto IL_030b;
														case 0:
														case 10:
															goto IL_0338;
														case 6:
															val = (val5).Value;
															num7 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
															{
																num7 = 5;
															}
															continue;
														case 9:
															goto end_IL_0338;
														}
														break;
													}
													text2 = (val).GetString();
													num6 = 3;
													goto IL_01c7;
													continue;
													end_IL_0338:
													break;
												}
											}
											finally
											{
												_ = val4;
												int num9 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
												{
													num9 = 3;
												}
												while (true)
												{
													switch (num9)
													{
													default:
														if (num10 == 988)
														{
															num9 = num10;
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
										case 6:
											break;
										case 5:
											val = (val2).RootElement;
											num3 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
											{
												num3 = 1;
											}
											continue;
										case 3:
											result = false;
											num3 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
											{
												num3 = 10;
											}
											continue;
										case 4:
											if ((int)(val).ValueKind != 1)
											{
												num3 = 3;
												continue;
											}
											goto case 5;
										case 0:
											goto end_IL_008a;
											IL_0143:
											num3 = num5;
											continue;
											end_IL_0147:
											break;
										}
										break;
									}
								}
								finally
								{
									if (val2 != null)
									{
										int num11 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											num11 = 0;
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
											case 0:
												break;
											case 1:
												goto end_IL_04fa;
											}
											(val2).Dispose();
											num11 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
											{
												num11 = 1;
											}
											continue;
											end_IL_04fa:
											break;
										}
									}
								}
								goto end_IL_0010;
							case 2:
							case 3:
								break;
							case 0:
								result = false;
								num13 = 13;
								goto IL_0086;
							case 4:
								goto end_IL_008a;
								IL_0086:
								num2 = num13;
								continue;
							}
							val2 = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)System.IO.File.ReadAllBytes(text), default(JsonDocumentOptions));
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								num2 = 12;
							}
							continue;
							end_IL_008a:
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num14 = 4;
						}
						else
						{
							ex = obj2;
							num14 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
							{
								num14 = 3;
							}
						}
						while (true)
						{
							switch (num14)
							{
							default:
								if (num15 != 20)
								{
									if (num15 == 1000)
									{
										goto IL_0606;
									}
									goto case 7;
								}
								goto case 2;
							case 8:
								if (ex is JsonException)
								{
									num15 = 20;
									goto IL_0606;
								}
								goto case 0;
							case 2:
							case 11:
							case 12:
								flag = true;
								num14 = 7;
								continue;
							case 1:
								if (!(ex is NotSupportedException))
								{
									num14 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
									{
										num14 = 10;
									}
									continue;
								}
								goto case 2;
							case 5:
							case 10:
								flag = false;
								num14 = 9;
								continue;
							case 0:
								if (ex is ArgumentException)
								{
									num14 = 11;
									continue;
								}
								goto case 1;
							case 3:
								if (!(ex is IOException))
								{
									num14 = 6;
									continue;
								}
								goto case 2;
							case 6:
								if (ex is UnauthorizedAccessException)
								{
									num14 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
									{
										num14 = 9;
									}
									continue;
								}
								goto case 8;
							case 4:
								result2 = 0;
								break;
							case 7:
							case 9:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0606:
								num14 = num15;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num16 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num16 = 6;
						}
						while (true)
						{
							switch (num16)
							{
							default:
								if (num17 == 988)
								{
									num16 = num17;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					goto default;
				}
				end_IL_0010:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool c2sXOkkp2cd(object relativePath)
	{
		int num = 3;
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						goto case 4;
					case 3:
						text = System.IO.Path.GetExtension((string)relativePath);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						if ((text).Equals(".dll", (StringComparison)5))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 0;
					case 1:
						return (text).Equals(".pyd", (StringComparison)5);
					case 4:
						return true;
					case 0:
						if ((text).Equals(".exe", (StringComparison)5))
						{
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool RrKXOVwTrly(object path)
	{
		int num = 1;
		bool result = default(bool);
		int num4 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			default:
				try
				{
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
						{
							num2 = 0;
						}
						goto IL_0072;
					}
					goto IL_00ba;
					IL_00d4:
					int num3 = 0;
					goto IL_00d5;
					IL_00d5:
					result = (byte)num3 != 0;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
					{
						num2 = 1;
					}
					goto IL_0072;
					IL_0072:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num4 == 990)
							{
								num2 = num4;
								continue;
							}
							goto IL_00d4;
						case 1:
							break;
						case 0:
							goto IL_00d4;
						case 2:
							goto end_IL_0031;
						}
						break;
					}
					goto IL_00ba;
					IL_00ba:
					num3 = (((path).Length > 0) ? 1 : 0);
					goto IL_00d5;
					end_IL_0031:;
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							num5 = 1;
						}
					}
					else
					{
						ex = obj2;
						num5 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
						{
							num5 = 2;
						}
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 13)
							{
								if (num6 == 993)
								{
									goto IL_0134;
								}
								goto case 2;
							}
							goto case 3;
						case 2:
							if (!(ex is IOException))
							{
								num5 = 4;
								continue;
							}
							goto case 5;
						case 5:
							flag = true;
							num5 = 3;
							continue;
						case 0:
							flag = false;
							num6 = 13;
							goto IL_0134;
						case 4:
							if (ex is UnauthorizedAccessException)
							{
								num5 = 5;
								continue;
							}
							goto case 0;
						case 1:
							result2 = 0;
							break;
						case 3:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0134:
							num5 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
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
						case 1:
							break;
						case 0:
							goto end_IL_0240;
						}
						result = false;
						num7 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
						{
							num7 = 0;
						}
						continue;
						end_IL_0240:
						break;
					}
				}
				break;
			case 0:
				break;
			}
			break;
		}
		return result;
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
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
						{
							num3 = 6;
						}
						continue;
					case 1:
						break;
					case 2:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						return;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
			{
				num = 7;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool vfvKiZZ5neJrPNuGOyKO()
	{
		return PHsiU5Z5i2c0NS3FQdHL == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sNIdDxXOLd1PjgHdta16 MYri7vZ5zZwCtum6AwRc()
	{
		return (sNIdDxXOLd1PjgHdta16)PHsiU5Z5i2c0NS3FQdHL;
	}
}

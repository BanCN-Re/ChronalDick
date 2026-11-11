using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace tlx5YSfgdKLfFIZYSgdo;

internal class r1Ua3Dfgl70B0c3gZkrx
{
	private static object U8w5TDZ16j0UgKH1DT50;

	[MethodImpl((MethodImplOptions)8)]
	internal static string XQEfgKNLDry(string? rootPath = null)
	{
		//IL_09ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d09: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Invalid comparison between Unknown and I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_0255: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Unknown result type (might be due to invalid IL or missing references)
		//IL_0557: Expected O, but got Unknown
		int num = 3;
		Stream val = default(Stream);
		int num32 = default(int);
		bool flag = default(bool);
		MemoryStream val2 = default(MemoryStream);
		int num7 = default(int);
		string text2 = default(string);
		int num10 = default(int);
		string text3 = default(string);
		string text5 = default(string);
		FileStream val3 = default(FileStream);
		string text4 = default(string);
		byte[] array = default(byte[]);
		int num13 = default(int);
		int num15 = default(int);
		string result = default(string);
		int num22 = default(int);
		int num24 = default(int);
		int num26 = default(int);
		int num28 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num16);
		global::System.Exception ex = default(global::System.Exception);
		int num18 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num17);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num20 = default(int);
		int num30 = default(int);
		int num34 = default(int);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						throw new PlatformNotSupportedException("游戏内面板要求 x64 Chronal");
					case 3:
					{
						if ((int)System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture != 1)
						{
							break;
						}
						Stream obj = ((System.Type.GetTypeFromHandle(typeof(r1Ua3Dfgl70B0c3gZkrx).TypeHandle)).Assembly).GetManifestResourceStream("Mahiro_Account.Resources.Bedrock.GameOverlay.x64.dll");
						if (obj == null)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						val = obj;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 1;
						}
						continue;
					}
					case 1:
						try
						{
							long num4 = (val).Length;
							int num5 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num5 = 8;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num32 != 16)
									{
										if (num32 == 996)
										{
											goto IL_0127;
										}
										goto case 5;
									}
									throw new InvalidDataException("游戏内面板组件大小无效");
								case 0:
								case 1:
									flag = true;
									num5 = 7;
									continue;
								case 5:
								case 7:
									if (flag)
									{
										int num31 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
										{
											num31 = 16;
										}
										num32 = num31;
										goto IL_0127;
									}
									val2 = new MemoryStream();
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
									{
										num5 = 3;
									}
									continue;
								case 8:
									if (num4 <= 0)
									{
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num5 = 14;
										}
										continue;
									}
									goto case 2;
								case 4:
								case 6:
									flag = false;
									num5 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
									{
										num5 = 14;
									}
									continue;
								case 2:
									if (num4 <= 33554432)
									{
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
										{
											num5 = 4;
										}
										continue;
									}
									goto case 0;
								case 3:
									{
										try
										{
											(val).CopyTo((Stream)(object)val2);
											int num6 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
											{
												num6 = 2;
											}
											while (true)
											{
												int num8;
												string text;
												switch (num6)
												{
												default:
													if (num7 != 13)
													{
														if (num7 == 993)
														{
															goto IL_02e9;
														}
														goto case 0;
													}
													try
													{
														System.IO.Directory.CreateDirectory(text2);
														int num9 = 10;
														while (true)
														{
															switch (num9)
															{
															default:
																if (num10 != 18)
																{
																	if (num10 == 998)
																	{
																		goto IL_04f5;
																	}
																}
																else if (!uc0fgH8VVTp(text3, text5))
																{
																	num9 = 3;
																	continue;
																}
																goto case 6;
															case 3:
															case 4:
																val3 = new FileStream(text4, (FileMode)1, (FileAccess)2, (FileShare)0);
																num9 = 7;
																continue;
															case 8:
																if (uc0fgH8VVTp(text4, text5))
																{
																	num9 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
																	{
																		num9 = 5;
																	}
																	continue;
																}
																goto case 2;
															case 7:
																try
																{
																	(val3).Write(default(global::System.ReadOnlySpan<byte>));
																	int num12 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																	{
																		num12 = 0;
																	}
																	while (true)
																	{
																		switch (num12)
																		{
																		default:
																			if (num13 == 989)
																			{
																				num12 = num13;
																				continue;
																			}
																			break;
																		case 0:
																			(val3).Flush(true);
																			num12 = 6;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
																			{
																				num12 = 1;
																			}
																			continue;
																		case 1:
																			break;
																		}
																		break;
																	}
																}
																finally
																{
																	if (val3 != null)
																	{
																		int num14 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																		{
																			num14 = 0;
																		}
																		while (true)
																		{
																			switch (num14)
																			{
																			default:
																				if (num15 == 989)
																				{
																					num14 = num15;
																					continue;
																				}
																				break;
																			case 0:
																				break;
																			case 1:
																				goto end_IL_0674;
																			}
																			(val3).Dispose();
																			num14 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
																			{
																				num14 = 7;
																			}
																			continue;
																			end_IL_0674:
																			break;
																		}
																	}
																}
																goto case 8;
															case 6:
																result = text3;
																num9 = 11;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																{
																	num9 = 9;
																}
																continue;
															case 10:
																if (System.IO.File.Exists(text3))
																{
																	int num11 = 18;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
																	{
																		num11 = 8;
																	}
																	num10 = num11;
																	goto IL_04f5;
																}
																goto case 3;
															case 2:
																throw new InvalidDataException("游戏内面板组件校验失败");
															case 5:
																System.IO.File.Move(text4, text3, true);
																num9 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																{
																	num9 = 11;
																}
																continue;
															case 9:
																break;
															case 1:
																result = text3;
																num9 = 18;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
																{
																	num9 = 0;
																}
																continue;
															case 0:
																break;
																IL_04f5:
																num9 = num10;
																continue;
															}
															break;
														}
													}
													catch (global::System.Exception obj2) when (((Func<bool>)delegate
													{
														// Could not convert BlockContainer to single expression
														obj3 = obj2 as global::System.Exception;
														if (obj3 == null)
														{
															num16 = 10;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
															{
																num16 = 4;
															}
														}
														else
														{
															ex = obj3;
															num16 = 5;
														}
														while (true)
														{
															switch (num16)
															{
															default:
																if (num18 != 14)
																{
																	if (num18 == 994)
																	{
																		goto IL_083e;
																	}
																	goto case 4;
																}
																goto case 1;
															case 5:
																if (ex is IOException)
																{
																	num16 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
																	{
																		num16 = 2;
																	}
																	continue;
																}
																goto case 0;
															case 3:
																flag = false;
																num16 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																{
																	num16 = 11;
																}
																continue;
															case 0:
																if (ex is UnauthorizedAccessException)
																{
																	num16 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																	{
																		num16 = 11;
																	}
																	continue;
																}
																goto case 3;
															case 2:
															case 6:
																flag = true;
																num17 = 12;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
																{
																	num17 = 14;
																}
																num18 = num17;
																goto IL_083e;
															case 4:
																result2 = 0;
																break;
															case 1:
																{
																	result2 = (flag ? 1 : 0);
																	break;
																}
																IL_083e:
																num16 = num18;
																continue;
															}
															break;
														}
														return (byte)result2 != 0;
													}).Invoke())
													{
														int num19 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
														{
															num19 = 5;
														}
														while (true)
														{
															switch (num19)
															{
															default:
																if (num20 == 988)
																{
																	goto IL_09ad;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_09ad:
															num19 = num20;
														}
														throw new InvalidOperationException("释放游戏内面板组件失败", ex);
													}
													finally
													{
														System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
														int num21 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
														{
															num21 = 0;
														}
														while (true)
														{
															switch (num21)
															{
															default:
																if (num22 == 989)
																{
																	goto IL_0a2e;
																}
																break;
															case 0:
																break;
															case 1:
																goto end_IL_0a32;
															}
															try
															{
																int num23;
																if (!System.IO.File.Exists(text4))
																{
																	num23 = 5;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																	{
																		num23 = 2;
																	}
																	goto IL_0a95;
																}
																goto IL_0add;
																IL_0a95:
																while (true)
																{
																	switch (num23)
																	{
																	default:
																		if (num24 == 990)
																		{
																			goto IL_0a91;
																		}
																		goto end_IL_0a95;
																	case 2:
																		goto end_IL_0a95;
																	case 0:
																		break;
																	case 1:
																		goto end_IL_0a95;
																	}
																	goto IL_0add;
																	IL_0a91:
																	num23 = num24;
																	continue;
																	end_IL_0a95:
																	break;
																}
																goto end_IL_0a53;
																IL_0add:
																System.IO.File.Delete(text4);
																num23 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
																{
																	num23 = 0;
																}
																goto IL_0a95;
																end_IL_0a53:;
															}
															catch (IOException)
															{
																int num25 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																{
																	num25 = 3;
																}
																while (true)
																{
																	switch (num25)
																	{
																	default:
																		if (num26 == 988)
																		{
																			num25 = num26;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															catch (UnauthorizedAccessException)
															{
																int num27 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																{
																	num27 = 0;
																}
																while (true)
																{
																	switch (num27)
																	{
																	default:
																		if (num28 == 988)
																		{
																			num27 = num28;
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
															IL_0a2e:
															num21 = num22;
															continue;
															end_IL_0a32:
															break;
														}
													}
													goto end_IL_02ed;
												case 4:
													text5 = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array));
													num6 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
													{
														num6 = 0;
													}
													break;
												case 1:
													text3 = System.IO.Path.Combine(text2, "Chronal.Bedrock.GameOverlay.dll");
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
													{
														num6 = 9;
													}
													break;
												case 0:
												{
													string text6 = text3;
													string text7 = ".";
													Guid val4 = System.Guid.NewGuid();
													text4 = string.Concat(text6, text7, (val4).ToString("N"), ".tmp");
													num8 = 13;
													goto IL_02e5;
												}
												case 5:
													text = rootPath;
													if (text == null)
													{
														num8 = 3;
														goto IL_02e5;
													}
													goto IL_0476;
												case 2:
													array = (val2).ToArray();
													num6 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
													{
														num6 = 5;
													}
													break;
												case 3:
													{
														text = JNVYTu71oRZRpWuML35.BedrockDataRoot;
														goto IL_0476;
													}
													IL_02e5:
													num7 = num8;
													goto IL_02e9;
													IL_0476:
													text2 = System.IO.Path.Combine(text, "game-overlay", (text5).ToLowerInvariant());
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
													{
														num6 = 13;
													}
													break;
													IL_02e9:
													num6 = num7;
													break;
												}
												continue;
												end_IL_02ed:
												break;
											}
										}
										finally
										{
											if (val2 != null)
											{
												int num29 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
												{
													num29 = 3;
												}
												while (true)
												{
													switch (num29)
													{
													default:
														if (num30 == 989)
														{
															num29 = num30;
															continue;
														}
														break;
													case 1:
														(val2).Dispose();
														num29 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
														{
															num29 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										break;
									}
									IL_0127:
									num5 = num32;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num33 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
								{
									num33 = 1;
								}
								while (true)
								{
									switch (num33)
									{
									default:
										if (num34 == 989)
										{
											num33 = num34;
											continue;
										}
										break;
									case 0:
										(val).Dispose();
										num33 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
										{
											num33 = 0;
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
					case 2:
						return result;
					case 0:
						throw new InvalidOperationException("程序缺少游戏内面板 DLL，请重新构建客户端");
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
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool uc0fgH8VVTp(object path, object hash)
	{
		int num = 1;
		bool result = default(bool);
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
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
						result = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)) == (string)hash);
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
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
									num3 = num4;
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
						if (val != null)
						{
							int num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
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
								case 1:
									break;
								case 0:
									goto end_IL_00e5;
								}
								(val).Dispose();
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
								{
									num5 = 5;
								}
								continue;
								end_IL_00e5:
								break;
							}
						}
					}
					goto case 2;
				case 1:
					break;
				}
				goto IL_0150;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0150;
				IL_0150:
				val = System.IO.File.OpenRead((string)path);
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string JJ1fgtDeGRl()
	{
		string[] array = new string[3]
		{
			"msyh.ttc",
			"msyh.ttf",
			"simsun.ttc"
		};
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
	internal static bool kw0PsNZ1R0FABs3KnBDQ()
	{
		return U8w5TDZ16j0UgKH1DT50 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static r1Ua3Dfgl70B0c3gZkrx quZBbVZ1w0PgQaLAT1i0()
	{
		return (r1Ua3Dfgl70B0c3gZkrx)U8w5TDZ16j0UgKH1DT50;
	}
}

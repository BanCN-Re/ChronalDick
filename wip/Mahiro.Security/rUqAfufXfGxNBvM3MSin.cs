using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace TRwsmCfXLcRIOdC8smGS;

internal class rUqAfufXfGxNBvM3MSin
{
	private static object kxYwJJZsHQdI8DyiZURp;

	[MethodImpl((MethodImplOptions)8)]
	internal static string P3tfXja6c6u(string? rootPath = null)
	{
		//IL_0710: Unknown result type (might be due to invalid IL or missing references)
		//IL_0716: Invalid comparison between Unknown and I4
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got I4
		//IL_0303->IL040a: Incompatible stack heights: 0 vs 5
		int num = 6;
		string text3 = default(string);
		string text4 = default(string);
		string result = default(string);
		int num6 = default(int);
		string text5 = default(string);
		int num12 = default(int);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num11 = default(int);
		string text2 = default(string);
		int num14 = default(int);
		int num20 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		global::System.Exception ex = default(global::System.Exception);
		int num16 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num18 = default(int);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 8;
						}
						text3 = System.IO.Path.Combine(text4, "Chronal.Bedrock.OptionsRedirect.dll");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 11;
						}
						continue;
					case 8:
						return result;
					case 0:
						try
						{
							int num4;
							if (!System.IO.File.Exists(text3))
							{
								num4 = 7;
								goto IL_0084;
							}
							goto IL_0166;
							IL_0134:
							result = text3;
							int num5 = 4;
							goto IL_008c;
							IL_0084:
							num6 = num4;
							goto IL_0088;
							IL_0088:
							num5 = num6;
							goto IL_008c;
							IL_008c:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 16)
									{
										if (num6 == 996)
										{
											goto IL_0088;
										}
										goto case 2;
									}
									goto end_IL_005f;
								case 2:
								case 5:
								case 7:
									System.IO.Directory.CreateDirectory(text4);
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
									{
										num5 = 1;
									}
									continue;
								case 6:
									result = text3;
									num4 = 16;
									goto IL_0084;
								case 0:
									break;
								case 3:
									goto IL_0166;
								case 1:
								{
									string text6 = text3;
									string text7 = ".staging-";
									Guid val2 = System.Guid.NewGuid();
									text5 = string.Concat(text6, text7, (val2).ToString("N"));
									num5 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
									{
										num5 = 3;
									}
									continue;
								}
								case 8:
									try
									{
										_ = 1;
										_ = 2;
										_ = 0;
										_ = 65536;
										FileStream val = (FileStream)(object)(-2147483648);
										int num7 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
										{
											num7 = 4;
										}
										while (true)
										{
											switch (num7)
											{
											default:
												if (num12 != 991)
												{
													break;
												}
												goto IL_0245;
											case 1:
												try
												{
													(val).Write((global::System.ReadOnlySpan<byte>)array);
													int num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
													{
														num8 = 0;
													}
													while (true)
													{
														switch (num8)
														{
														default:
															if (num9 == 989)
															{
																num8 = num9;
																continue;
															}
															break;
														case 0:
															break;
														case 1:
															goto end_IL_02b2;
														}
														(val).Flush(true);
														num8 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
														{
															num8 = 6;
														}
														continue;
														end_IL_02b2:
														break;
													}
												}
												finally
												{
													int num10;
													if (val == null)
													{
														num10 = 4;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
														{
															num10 = 1;
														}
														goto IL_033b;
													}
													goto IL_0383;
													IL_033b:
													while (true)
													{
														switch (num10)
														{
														default:
															if (num11 == 990)
															{
																goto IL_0337;
															}
															goto end_IL_033b;
														case 1:
															goto end_IL_033b;
														case 0:
															break;
														case 2:
															goto end_IL_033b;
														}
														goto IL_0383;
														IL_0337:
														num10 = num11;
														continue;
														end_IL_033b:
														break;
													}
													goto end_IL_0303;
													IL_0383:
													(val).Dispose();
													num10 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
													{
														num10 = 2;
													}
													goto IL_033b;
													end_IL_0303:;
												}
												goto case 0;
											case 3:
												throw new global::System.Exception("基岩渲染配置重定向组件写入后校验失败");
											case 0:
												if (!BynfX9MSp2u(text5, text2))
												{
													num12 = 3;
													goto IL_0245;
												}
												System.IO.File.Move(text5, text3, true);
												num7 = 2;
												continue;
											case 2:
												break;
												IL_0245:
												num7 = num12;
												continue;
											}
											break;
										}
									}
									finally
									{
										rGQfXDUx8Od(text5);
										int num13 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
										{
											num13 = 0;
										}
										while (true)
										{
											switch (num13)
											{
											default:
												if (num14 == 988)
												{
													num13 = num14;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									goto case 6;
								case 4:
									goto end_IL_005f;
								}
								break;
							}
							goto IL_0134;
							IL_0166:
							if (!BynfX9MSp2u(text3, text2))
							{
								num4 = 5;
								goto IL_0084;
							}
							goto IL_0134;
							end_IL_005f:;
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num15 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num15 = 5;
								}
							}
							else
							{
								ex = obj2;
								num15 = 4;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 != 15)
									{
										if (num16 == 995)
										{
											goto IL_04d8;
										}
										goto case 2;
									}
									goto case 0;
								case 3:
									if (!(ex is UnauthorizedAccessException))
									{
										num15 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num15 = 15;
										}
										continue;
									}
									goto case 2;
								case 2:
								case 7:
									flag = true;
									num15 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
									{
										num15 = 0;
									}
									continue;
								case 6:
									flag = false;
									num16 = 15;
									goto IL_04d8;
								case 4:
									if (ex is IOException)
									{
										num15 = 2;
										continue;
									}
									goto case 3;
								case 1:
									if (ex is InvalidDataException)
									{
										num15 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
										{
											num15 = 7;
										}
										continue;
									}
									goto case 6;
								case 5:
									result2 = 0;
									break;
								case 0:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_04d8:
									num15 = num16;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num17 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								num17 = 0;
							}
							while (true)
							{
								switch (num17)
								{
								default:
									if (num18 == 988)
									{
										goto IL_064c;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_064c:
								num17 = num18;
							}
							_ = "部署基岩渲染配置重定向组件失败";
							throw ex;
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
							int num19 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num19 = 0;
							}
							while (true)
							{
								switch (num19)
								{
								default:
									if (num20 == 988)
									{
										num19 = num20;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 8;
					case 4:
						if (string.IsNullOrWhiteSpace(rootPath))
						{
							num3 = 7;
							continue;
						}
						goto case 2;
					case 5:
						if ((int)System.Runtime.InteropServices.RuntimeInformation.ProcessArchitecture != 1)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
							{
								num3 = 2;
							}
						}
						else
						{
							array = NqrfXZb88IQ();
							num3 = 3;
						}
						continue;
					case 2:
						text = rootPath;
						goto IL_0825;
					case 1:
						throw new global::System.Exception("按版本隔离基岩渲染配置仅支持 x64 Chronal");
					case 6:
						if (System.Environment.Is64BitProcess)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 1;
					case 3:
						text2 = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array));
						num = 4;
						break;
					case 7:
						{
							text = JNVYTu71oRZRpWuML35.BedrockDataRoot;
							goto IL_0825;
						}
						IL_0825:
						text4 = System.IO.Path.Combine(System.IO.Path.GetFullPath(text), "options-redirect", "runtime", (text2).ToLowerInvariant());
						num = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							num = 15;
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
	private static byte[] NqrfXZb88IQ()
	{
		//IL_01a0: Expected O, but got I4
		int num = 3;
		Stream val = default(Stream);
		byte[] result = default(byte[]);
		int num9 = default(int);
		bool flag = default(bool);
		MemoryStream val2 = default(MemoryStream);
		int num6 = default(int);
		int num8 = default(int);
		int num11 = default(int);
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
					goto case 2;
				case 3:
				{
					Stream obj = ((System.Type.GetTypeFromHandle(typeof(rUqAfufXfGxNBvM3MSin).TypeHandle)).Assembly).GetManifestResourceStream("Mahiro_Account.Resources.Bedrock.OptionsRedirect.x64.dll");
					if (obj == null)
					{
						num2 = 2;
						break;
					}
					val = obj;
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 0:
					return result;
				case 1:
					try
					{
						long num3 = (val).Length;
						int num4 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
						{
							num4 = 7;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num9 != 15)
								{
									if (num9 == 995)
									{
										goto IL_00c6;
									}
									goto case 2;
								}
								if (num3 <= 2097152)
								{
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
									{
										num4 = 12;
									}
									continue;
								}
								goto case 0;
							case 7:
								if (num3 > 0)
								{
									num9 = 15;
									goto IL_00c6;
								}
								goto case 0;
							case 1:
								throw new global::System.Exception("内置基岩渲染配置重定向组件大小无效");
							case 3:
							case 6:
								flag = false;
								num4 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
								{
									num4 = 14;
								}
								continue;
							case 0:
								flag = true;
								num4 = 2;
								continue;
							case 2:
							case 5:
								if (!flag)
								{
									val2 = (MemoryStream)(object)checked((int)(val).Length);
									num4 = 4;
									continue;
								}
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
								{
									num4 = 10;
								}
								continue;
							case 4:
								{
									try
									{
										(val).CopyTo((Stream)(object)val2);
										int num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
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
												goto end_IL_024e;
											}
											result = (val2).ToArray();
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
											{
												num5 = 1;
											}
											continue;
											end_IL_024e:
											break;
										}
									}
									finally
									{
										int num7;
										if (val2 == null)
										{
											num7 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
											{
												num7 = 5;
											}
											goto IL_02d8;
										}
										goto IL_02fc;
										IL_02d8:
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 == 990)
												{
													goto IL_02d4;
												}
												goto end_IL_02d8;
											case 0:
												break;
											case 1:
												goto end_IL_02d8;
											case 2:
												goto end_IL_02d8;
											}
											goto IL_02fc;
											IL_02d4:
											num7 = num8;
											continue;
											end_IL_02d8:
											break;
										}
										goto end_IL_02a0;
										IL_02fc:
										(val2).Dispose();
										num7 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
										{
											num7 = 2;
										}
										goto IL_02d8;
										end_IL_02a0:;
									}
									break;
								}
								IL_00c6:
								num4 = num9;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num10;
						if (val == null)
						{
							num10 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num10 = 0;
							}
							goto IL_0384;
						}
						goto IL_03a8;
						IL_0384:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_0380;
								}
								goto end_IL_0384;
							case 2:
								break;
							case 0:
								goto end_IL_0384;
							case 1:
								goto end_IL_0384;
							}
							goto IL_03a8;
							IL_0380:
							num10 = num11;
							continue;
							end_IL_0384:
							break;
						}
						goto end_IL_034c;
						IL_03a8:
						(val).Dispose();
						num10 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num10 = 1;
						}
						goto IL_0384;
						end_IL_034c:;
					}
					goto case 0;
				case 2:
					throw new global::System.Exception("程序缺少 x64 基岩渲染配置重定向组件");
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool BynfX9MSp2u(object path, object expectedHash)
	{
		//IL_015f: Expected O, but got I4
		//IL_0173->IL0010: Incompatible stack heights: 6 vs 1
		//IL_017e->IL0010: Incompatible stack heights: 6 vs 1
		int num = 2;
		bool result = default(bool);
		FileStream val = default(FileStream);
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0021;
				case 1:
					try
					{
						result = string.Equals(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)), (string)expectedHash, (StringComparison)5);
						int num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
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
					finally
					{
						if (val != null)
						{
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
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
									goto end_IL_00e3;
								}
								(val).Dispose();
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
								{
									num4 = 5;
								}
								continue;
								end_IL_00e3:
								break;
							}
						}
					}
					break;
				case 2:
					_ = 3;
					_ = 1;
					_ = 1;
					_ = 65536;
					val = (FileStream)(object)134217728;
					_ = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
					{
						_ = 1;
					}
					continue;
				case 0:
					break;
				}
				goto IL_017e;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_017e;
				IL_017e:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void rGQfXDUx8Od(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num7 = default(int);
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
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num2 = 0;
						}
						goto IL_0073;
					}
					goto IL_0097;
					IL_0073:
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						case 2:
							return;
						default:
							if (num3 == 990)
							{
								goto IL_006f;
							}
							return;
						case 1:
							break;
						}
						break;
						IL_006f:
						num2 = num3;
					}
					goto IL_0097;
					IL_0097:
					System.IO.File.Delete((string)path);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num2 = 3;
					}
					goto IL_0073;
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 3;
						goto IL_0112;
					}
					ex = obj2;
					num5 = 14;
					goto IL_010e;
					IL_010e:
					num4 = num5;
					goto IL_0112;
					IL_0112:
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 14)
							{
								if (num5 == 994)
								{
									break;
								}
								goto case 1;
							}
							if (ex is IOException)
							{
								num4 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
								{
									num4 = 9;
								}
								continue;
							}
							goto case 4;
						case 4:
							if (ex is UnauthorizedAccessException)
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
								{
									num4 = 4;
								}
								continue;
							}
							goto case 6;
						case 0:
						case 5:
							flag = true;
							num4 = 2;
							continue;
						case 6:
							flag = false;
							num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
							{
								num4 = 1;
							}
							continue;
						case 3:
							result = 0;
							goto IL_0223;
						case 1:
						case 2:
							{
								result = (flag ? 1 : 0);
								goto IL_0223;
							}
							IL_0223:
							return (byte)result != 0;
						}
						break;
					}
					goto IL_010e;
				}).Invoke())
				{
					int num6 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num6 = 5;
					}
					while (true)
					{
						switch (num6)
						{
						case 0:
							return;
						}
						if (num7 != 988)
						{
							return;
						}
						num6 = num7;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 9)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num3 = 0;
						}
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
			while (num2 == 990);
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool A9U3TmZstWRXdn8Y84yx()
	{
		return kxYwJJZsHQdI8DyiZURp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rUqAfufXfGxNBvM3MSin HM7tTgZsOOnLxmGfR03u()
	{
		return (rUqAfufXfGxNBvM3MSin)kxYwJJZsHQdI8DyiZURp;
	}
}

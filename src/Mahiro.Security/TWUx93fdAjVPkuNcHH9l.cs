using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using MQLtWrflbjL7rOmZhG0a;
using QZs97cfg7H5cG2l6dckf;
using eKYaxffghFvoT0eZRTxb;
using fDAldojjppXrctUVYOJn;
using i6TlJMfuChv2AjPXr7O8;
using lQs7SmfZ8MofeLgDpWlN;
using r5LWFs73eOlXSX66CSK;

namespace UXils3fdIjmg3YyIOYqq;

internal class TWUx93fdAjVPkuNcHH9l
{
	internal static object MuIdGWZ3yIdn0gMaBU6E;

	[MethodImpl((MethodImplOptions)8)]
	internal static void fHQfdB8UHbA(object process, object instance, object addresses)
	{
		//IL_07da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_070b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_0477: Expected O, but got Unknown
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num16 = default(int);
		byte[] array = default(byte[]);
		uint num15 = default(uint);
		rF2scFfgzeIgxosZZ5PH rF2scFfgzeIgxosZZ5PH = default(rF2scFfgzeIgxosZZ5PH);
		nint num9 = default(nint);
		string text = default(string);
		global::System.Collections.IEnumerator enumerator = default(global::System.Collections.IEnumerator);
		int num11 = default(int);
		ProcessModule val2 = default(ProcessModule);
		int num14 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num18 = default(int);
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
					case 4:
						goto IL_004a;
					case 1:
						throw new PlatformNotSupportedException("此客户端版本尚未适配同进程换号");
					case 0:
						goto IL_07e0;
					case 3:
						if (!(((zG6ueUfuQUk6CEmxLYji)instance).ClientVersion != "1.21.120.0"))
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 1;
					case 2:
						return;
					}
					break;
				}
				switch (num2)
				{
				case 992:
					break;
				default:
					return;
				case 11:
					try
					{
						FileStream val = System.IO.File.OpenRead((((dynamic)(process)).MainModule).FileName);
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num4 = 13;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num16 != 23)
								{
									if (num16 == 1003)
									{
										goto IL_00d9;
									}
									goto case 5;
								}
								System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(default(global::System.Span<byte>), 24u);
								num4 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num4 = 6;
								}
								break;
							case 6:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(MemoryExtensions.AsSpan<byte>(array, 4), num15);
								num4 = 7;
								break;
							case 14:
							{
								num15 = KIAFMLfgmmKb9KvNAddq.yXafggvOo76(rF2scFfgzeIgxosZZ5PH.Window, out var _);
								num4 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
								{
									num4 = 23;
								}
								break;
							}
							case 1:
								num9 = rF2scFfgzeIgxosZZ5PH.oAbflXIgyFU("Chronal.Bedrock.AccountSwitch.dll");
								num4 = 2;
								break;
							case 3:
								throw new InvalidOperationException("换号组件加载失败");
							case 5:
								rF2scFfgzeIgxosZZ5PH.grCflLEkhBi(text);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
								{
									num4 = 2;
								}
								break;
							case 9:
								array = new byte[24];
								num16 = 23;
								goto IL_00d9;
							case 10:
								num9 = rF2scFfgzeIgxosZZ5PH.oAbflXIgyFU("Chronal.Bedrock.AccountSwitch.dll");
								num4 = 4;
								break;
							case 15:
								text = v5efdgeS8yt();
								num4 = 10;
								break;
							case 13:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(MemoryExtensions.AsSpan<byte>(array, 16), ((V1NV4TfZ0HRmQ56BROEp)addresses).GilRelease);
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
								{
									num4 = 6;
								}
								break;
							case 4:
								if (num9 == 0)
								{
									num4 = 5;
									break;
								}
								goto case 2;
							case 12:
								try
								{
									while (true)
									{
										int num10;
										if (!(enumerator).MoveNext())
										{
											num10 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
											{
												num10 = 2;
											}
											goto IL_0332;
										}
										goto IL_0464;
										IL_0332:
										while (true)
										{
											switch (num10)
											{
											case 1:
												goto IL_036c;
											case 3:
												goto IL_03e1;
											case 0:
												goto end_IL_0332;
											case 2:
												goto IL_0464;
											case 4:
												goto end_IL_0402;
											}
											if (num11 != 12)
											{
												if (num11 == 992)
												{
													goto IL_032e;
												}
												goto IL_036c;
											}
											if ((val2).BaseAddress != num9)
											{
												break;
											}
											num10 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
											{
												num10 = 9;
											}
											continue;
											IL_036c:
											if (string.Equals(System.IO.Path.GetFullPath((val2).FileName), System.IO.Path.GetFullPath(text), (StringComparison)5))
											{
												num10 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
												{
													num10 = 0;
												}
												continue;
											}
											goto IL_03e1;
											IL_03e1:
											throw new PlatformNotSupportedException("此实例已加载其他构建的换号组件");
											continue;
											end_IL_0332:
											break;
										}
										continue;
										IL_032e:
										num10 = num11;
										goto IL_0332;
										IL_0464:
										val2 = (ProcessModule)(enumerator).Current;
										int num12 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num12 = 12;
										}
										num11 = num12;
										goto IL_032e;
										continue;
										end_IL_0402:
										break;
									}
								}
								finally
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									int num13 = 2;
									while (true)
									{
										switch (num13)
										{
										default:
											if (num14 == 990)
											{
												num13 = num14;
												continue;
											}
											goto case 2;
										case 2:
											if (disposable != null)
											{
												num13 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
												{
													num13 = 0;
												}
												continue;
											}
											break;
										case 0:
											(disposable).Dispose();
											num13 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
											{
												num13 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto case 14;
							case 8:
								if (rF2scFfgzeIgxosZZ5PH.MkIfljPfSJe(S7TvvYfg4lFMFZrHEXNd.RegisterAccount, array) != 0)
								{
									num4 = 11;
									break;
								}
								return;
							case 0:
								try
								{
									if ((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)) != "EC4673BF6D0B128FECD3616012B8D26A2F40BCB26F1CD031C79DDFA12BA7F0F3"))
									{
										int num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											default:
												if (num6 == 988)
												{
													goto IL_05c8;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_05c8:
											num5 = num6;
										}
										throw new PlatformNotSupportedException("客户端文件指纹未适配同进程换号");
									}
								}
								finally
								{
									if (val != null)
									{
										int num7 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
										{
											num7 = 7;
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
												(val).Dispose();
												num7 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
												{
													num7 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 15;
							case 7:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(MemoryExtensions.AsSpan<byte>(array, 8), ((V1NV4TfZ0HRmQ56BROEp)addresses).GilEnsure);
								num4 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num4 = 21;
								}
								break;
							case 2:
								if (num9 != 0)
								{
									enumerator = (((dynamic)(process)).Modules).GetEnumerator();
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
									{
										num4 = 17;
									}
								}
								else
								{
									num4 = 3;
								}
								break;
							case 11:
								{
									throw new PlatformNotSupportedException("客户端原生换号特征校验未通过");
								}
								IL_00d9:
								num4 = num16;
								break;
							}
						}
					}
					finally
					{
						if (rF2scFfgzeIgxosZZ5PH != null)
						{
							int num17 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num17 = 1;
							}
							while (true)
							{
								switch (num17)
								{
								default:
									if (num18 == 989)
									{
										num17 = num18;
										continue;
									}
									break;
								case 1:
									(rF2scFfgzeIgxosZZ5PH).Dispose();
									num17 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num17 = 6;
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
				continue;
				IL_07e0:
				rF2scFfgzeIgxosZZ5PH = (rF2scFfgzeIgxosZZ5PH)new rF2scFfgzeIgxosZZ5PH((Process)process, (zG6ueUfuQUk6CEmxLYji)instance);
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
				{
					num = 10;
				}
				break;
				IL_004a:
				if ((((zG6ueUfuQUk6CEmxLYji)instance).ClientVersion != "3.9.20.299893"))
				{
					num = 3;
					break;
				}
				goto IL_07e0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string v5efdgeS8yt()
	{
		//IL_08c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num4 = default(int);
		Stream val2 = default(Stream);
		int num6 = default(int);
		string text2 = default(string);
		int num8 = default(int);
		FileStream val3 = default(FileStream);
		string text = default(string);
		int num11 = default(int);
		string result = default(string);
		string text3 = default(string);
		int num13 = default(int);
		string text4 = default(string);
		byte[] array = default(byte[]);
		int num15 = default(int);
		int num17 = default(int);
		int num19 = default(int);
		int num21 = default(int);
		int num24 = default(int);
		int num26 = default(int);
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
						break;
					}
					goto case 1;
				case 2:
					try
					{
						MemoryStream val = new MemoryStream();
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_006d;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_006d:
							num3 = num4;
						}
						try
						{
							(val2).CopyTo((Stream)(object)val);
							int num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 12)
									{
										if (num6 == 992)
										{
											goto IL_00c9;
										}
										goto case 3;
									}
									try
									{
										System.IO.Directory.CreateDirectory(text2);
										int num7 = 5;
										while (true)
										{
											int num9;
											switch (num7)
											{
											default:
												if (num8 != 14)
												{
													if (num8 == 994)
													{
														goto IL_02ba;
													}
													goto case 1;
												}
												try
												{
													int num10;
													if (!(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val3)) == text))
													{
														num10 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
														{
															num10 = 0;
														}
														goto IL_0359;
													}
													goto IL_0381;
													IL_0359:
													while (true)
													{
														switch (num10)
														{
														default:
															if (num11 == 991)
															{
																goto IL_0355;
															}
															goto IL_04ab;
														case 1:
															break;
														case 3:
															goto end_IL_0359;
														case 0:
														case 2:
															goto IL_04ab;
														}
														goto IL_0381;
														IL_0355:
														num10 = num11;
														continue;
														end_IL_0359:
														break;
													}
													goto end_IL_0301;
													IL_0381:
													result = text3;
													num10 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
													{
														num10 = 3;
													}
													goto IL_0359;
													end_IL_0301:;
												}
												finally
												{
													int num12;
													if (val3 == null)
													{
														num12 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
														{
															num12 = 8;
														}
														goto IL_0414;
													}
													goto IL_0438;
													IL_0414:
													while (true)
													{
														switch (num12)
														{
														default:
															if (num13 == 990)
															{
																goto IL_0410;
															}
															goto end_IL_0414;
														case 2:
															break;
														case 1:
															goto end_IL_0414;
														case 0:
															goto end_IL_0414;
														}
														goto IL_0438;
														IL_0410:
														num12 = num13;
														continue;
														end_IL_0414:
														break;
													}
													goto end_IL_03dc;
													IL_0438:
													(val3).Dispose();
													num12 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
													{
														num12 = 0;
													}
													goto IL_0414;
													end_IL_03dc:;
												}
												break;
											case 0:
												System.IO.File.Move(text4, text3, true);
												num9 = 4;
												goto IL_02b6;
											case 3:
											case 6:
												goto IL_04ab;
											case 1:
												val3 = System.IO.File.OpenRead(text3);
												num9 = 14;
												goto IL_02b6;
											case 4:
												result = text3;
												num7 = 2;
												continue;
											case 5:
												if (!System.IO.File.Exists(text3))
												{
													num7 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
													{
														num7 = 3;
													}
													continue;
												}
												goto case 1;
											case 2:
												break;
												IL_02b6:
												num8 = num9;
												goto IL_02ba;
												IL_02ba:
												num7 = num8;
												continue;
												IL_04ab:
												System.IO.File.WriteAllBytes(text4, array);
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
												{
													num7 = 0;
												}
												continue;
											}
											break;
										}
									}
									finally
									{
										System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
										int num14 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
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
													goto IL_0595;
												}
												break;
											case 0:
												break;
											case 1:
												goto end_IL_0599;
											}
											try
											{
												if (!System.IO.File.Exists(text4))
												{
													break;
												}
												int num16 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
												{
													num16 = 6;
												}
												while (true)
												{
													switch (num16)
													{
													default:
														if (num17 == 989)
														{
															num16 = num17;
															continue;
														}
														break;
													case 1:
														System.IO.File.Delete(text4);
														num16 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
														{
															num16 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											catch (IOException)
											{
												int num18 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
												{
													num18 = 0;
												}
												while (true)
												{
													switch (num18)
													{
													default:
														if (num19 == 988)
														{
															num18 = num19;
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
												int num20 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
												{
													num20 = 0;
												}
												while (true)
												{
													switch (num20)
													{
													default:
														if (num21 == 988)
														{
															num20 = num21;
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
											IL_0595:
											num14 = num15;
											continue;
											end_IL_0599:
											break;
										}
									}
									goto end_IL_00cd;
								case 2:
								{
									string text5 = text3;
									string text6 = ".";
									Guid val4 = System.Guid.NewGuid();
									text4 = string.Concat(text5, text6, (val4).ToString("N"), ".tmp");
									int num22 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
									{
										num22 = 0;
									}
									num6 = num22;
									goto IL_00c9;
								}
								case 1:
									array = (val).ToArray();
									num5 = 4;
									break;
								case 0:
									text3 = System.IO.Path.Combine(text2, "Chronal.Bedrock.AccountSwitch.dll");
									num5 = 2;
									break;
								case 3:
									text2 = System.IO.Path.Combine(JNVYTu71oRZRpWuML35.BedrockDataRoot, "game-overlay", "account-switch", text);
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num5 = 3;
									}
									break;
								case 4:
									{
										text = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array));
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
										{
											num5 = 3;
										}
										break;
									}
									IL_00c9:
									num5 = num6;
									break;
								}
								continue;
								end_IL_00cd:
								break;
							}
						}
						finally
						{
							int num23;
							if (val == null)
							{
								num23 = 2;
								goto IL_0735;
							}
							goto IL_0759;
							IL_0759:
							(val).Dispose();
							num23 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num23 = 8;
							}
							goto IL_0735;
							IL_0735:
							while (true)
							{
								switch (num23)
								{
								default:
									if (num24 == 990)
									{
										goto IL_0731;
									}
									goto end_IL_0735;
								case 1:
									break;
								case 2:
									goto end_IL_0735;
								case 0:
									goto end_IL_0735;
								}
								goto IL_0759;
								IL_0731:
								num23 = num24;
								continue;
								end_IL_0735:
								break;
							}
						}
					}
					finally
					{
						if (val2 != null)
						{
							int num25 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num25 = 6;
							}
							while (true)
							{
								switch (num25)
								{
								default:
									if (num26 == 989)
									{
										num25 = num26;
										continue;
									}
									break;
								case 0:
									(val2).Dispose();
									num25 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
									{
										num25 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 3;
				case 3:
					return result;
				case 1:
				{
					Stream obj = ((System.Type.GetTypeFromHandle(typeof(TWUx93fdAjVPkuNcHH9l).TypeHandle)).Assembly).GetManifestResourceStream("Mahiro_Account.Resources.Bedrock.AccountSwitch.x64.dll");
					if (obj == null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					val2 = obj;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 0:
					throw new PlatformNotSupportedException("构建中缺少同进程换号组件");
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool fJ3m8WZ3WKKlYiAafngl()
	{
		return MuIdGWZ3yIdn0gMaBU6E == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TWUx93fdAjVPkuNcHH9l to6T6AZ3J84wVdQ6XMyn()
	{
		return (TWUx93fdAjVPkuNcHH9l)MuIdGWZ3yIdn0gMaBU6E;
	}
}

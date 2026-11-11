using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using DBqBFMiKYnFLgQXBHPj;
using Q6oE5PSK8olODa5Bn5m;
using fDAldojjppXrctUVYOJn;
using hGYycdXXDoG2mOL5yubN;
using kjKrMVStekrkCnZqNlG;
using tnscKLYnOam7ppcXQoP;
using xZvVUmilxLNAHtw64Wn;

namespace PstPjqitqCsshhx6ABp;

internal class JkWbcviHn9LLlXcTuGr
{
	internal static object R9pLl1Zo1c8QHcu4Tuog;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool aJeiOBbJwY(int processId, out eX1t8ZigOupKVbWW012? identity, out string code)
	{
		identity = default(eX1t8ZigOupKVbWW012?);
		code = default(string);
		int num = 2;
		int num5 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		bool result = default(bool);
		string text = default(string);
		int num12 = default(int);
		int num14 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
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
					switch (num3)
					{
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						return false;
					case 3:
						try
						{
							Process val = System.Diagnostics.Process.GetProcessById(processId);
							int num4 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
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
										goto IL_0085;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0085:
								num4 = num5;
							}
							try
							{
								Process val2 = System.Diagnostics.Process.GetCurrentProcess();
								int num6 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
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
											goto IL_00df;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_00df:
									num6 = num7;
								}
								try
								{
									ProcessModule obj = (val).MainModule;
									int num8;
									if (obj == null)
									{
										num8 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num8 = 4;
										}
										goto IL_0144;
									}
									object obj2 = (obj).FileName;
									goto IL_0366;
									IL_0144:
									while (true)
									{
										int num9;
										switch (num8)
										{
										default:
											switch (num10)
											{
											case 999:
												break;
											default:
												goto end_IL_0144;
											case 19:
												result = true;
												num8 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
												{
													num8 = 9;
												}
												continue;
											}
											goto IL_0140;
										case 7:
										{
											int processId2 = (val).Id;
											global::System.DateTime dateTime = (val).StartTime;
											dateTime = (dateTime).ToUniversalTime();
											identity = (eX1t8ZigOupKVbWW012?)new eX1t8ZigOupKVbWW012(processId2, (dateTime).Ticks, (val).SessionId, System.IO.Path.GetFullPath(text));
											num8 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
											{
												num8 = 2;
											}
											continue;
										}
										case 3:
											if ((val).HasExited)
											{
												num8 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
												{
													num8 = 19;
												}
												continue;
											}
											goto case 10;
										case 10:
											if (string.IsNullOrWhiteSpace(text))
											{
												num9 = 4;
												goto IL_013c;
											}
											goto case 8;
										case 6:
											if (!Q8xMnNXX9IjGqqCAeb4q.yWMXXVOZltL(text))
											{
												num8 = 5;
												continue;
											}
											goto case 7;
										case 2:
											code = "ready";
											num9 = 19;
											goto IL_013c;
										case 0:
										case 4:
										case 5:
											result = false;
											num8 = 9;
											continue;
										case 8:
											if ((val).SessionId == (val2).SessionId)
											{
												num8 = 15;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
												{
													num8 = 6;
												}
												continue;
											}
											goto case 0;
										case 9:
											goto end_IL_0144;
										case 11:
											obj2 = null;
											break;
										case 1:
											goto end_IL_0144;
											IL_0140:
											num8 = num10;
											continue;
											IL_013c:
											num10 = num9;
											goto IL_0140;
										}
										goto IL_0366;
										continue;
										end_IL_0144:
										break;
									}
									goto end_IL_0100;
									IL_0366:
									text = (string)obj2;
									num8 = 3;
									goto IL_0144;
									end_IL_0100:;
								}
								finally
								{
									int num11;
									if (val2 == null)
									{
										num11 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
										{
											num11 = 4;
										}
										goto IL_03af;
									}
									goto IL_03f7;
									IL_03af:
									while (true)
									{
										switch (num11)
										{
										default:
											if (num12 == 990)
											{
												goto IL_03ab;
											}
											goto end_IL_03af;
										case 2:
											goto end_IL_03af;
										case 0:
											break;
										case 1:
											goto end_IL_03af;
										}
										goto IL_03f7;
										IL_03ab:
										num11 = num12;
										continue;
										end_IL_03af:
										break;
									}
									goto end_IL_0377;
									IL_03f7:
									(val2).Dispose();
									num11 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
									{
										num11 = 7;
									}
									goto IL_03af;
									end_IL_0377:;
								}
							}
							finally
							{
								int num13;
								if (val == null)
								{
									num13 = 2;
									goto IL_0446;
								}
								goto IL_046a;
								IL_046a:
								(val).Dispose();
								num13 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									num13 = 1;
								}
								goto IL_0446;
								IL_0446:
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 990)
										{
											goto IL_0442;
										}
										break;
									case 1:
										break;
									case 2:
										goto end_IL_0446;
									case 0:
										goto end_IL_0446;
									}
									goto IL_046a;
									IL_0442:
									num13 = num14;
									continue;
									end_IL_0446:
									break;
								}
							}
						}
						catch (global::System.Exception obj3) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj4 = obj3 as global::System.Exception;
							if (obj4 == null)
							{
								num15 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
								{
									num15 = 14;
								}
							}
							else
							{
								ex = obj4;
								num15 = 10;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 != 19)
									{
										if (num16 == 999)
										{
											goto IL_04f3;
										}
										goto case 1;
									}
									if (!(ex is NotSupportedException))
									{
										num15 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
										{
											num15 = 10;
										}
										continue;
									}
									goto case 0;
								case 2:
									if (!(ex is InvalidOperationException))
									{
										num15 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
										{
											num15 = 1;
										}
										continue;
									}
									goto case 0;
								case 10:
									if (ex is ArgumentException)
									{
										num15 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num15 = 17;
										}
										continue;
									}
									goto case 2;
								case 3:
								case 9:
									flag = false;
									num15 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
									{
										num15 = 9;
									}
									continue;
								case 8:
									if (!(ex is UnauthorizedAccessException))
									{
										num16 = 19;
										goto IL_04f3;
									}
									goto case 0;
								case 1:
									if (!(ex is Win32Exception))
									{
										num15 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num15 = 13;
										}
										continue;
									}
									goto case 0;
								case 5:
									if (!(ex is IOException))
									{
										num15 = 8;
										continue;
									}
									goto case 0;
								case 0:
								case 7:
									flag = true;
									num15 = 11;
									continue;
								case 4:
									result2 = 0;
									break;
								case 6:
								case 11:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_04f3:
									num15 = num16;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num17 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num17 = 0;
							}
							while (true)
							{
								switch (num17)
								{
								default:
									if (num18 == 990)
									{
										num17 = num18;
										continue;
									}
									break;
								case 1:
									identity = null;
									num17 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
									{
										num17 = 8;
									}
									continue;
								case 0:
									break;
								case 2:
									goto end_IL_06cc;
								}
								result = false;
								num17 = 2;
								continue;
								end_IL_06cc:
								break;
							}
						}
						break;
					case 1:
						code = "java_host_identity_mismatch";
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
						{
							num3 = 10;
						}
						continue;
					case 4:
						if (processId > 0)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto end_IL_000c;
					case 2:
						identity = null;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						break;
					}
					return result;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool OELi5sJAsq(out YVZFyCidIljvrGfaweG? identity, out string code)
	{
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		int num = 3;
		int num4 = default(int);
		string text = default(string);
		int num6 = default(int);
		string text2 = default(string);
		int num8 = default(int);
		int num10 = default(int);
		byte[] array = default(byte[]);
		int num12 = default(int);
		bool result = default(bool);
		int num14 = default(int);
		int num16 = default(int);
		int num18 = default(int);
		int num20 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num21);
		global::System.Exception ex = default(global::System.Exception);
		int num22 = default(int);
		bool flag = default(bool);
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
					goto case 1;
				case 1:
					try
					{
						Process val = System.Diagnostics.Process.GetCurrentProcess();
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0072;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0072:
							num3 = num4;
						}
						try
						{
							ProcessModule obj = (val).MainModule;
							int num5;
							if (obj == null)
							{
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
								{
									num5 = 9;
								}
								goto IL_00dc;
							}
							object obj2 = (obj).FileName;
							goto IL_01e2;
							IL_01e2:
							text = (string)obj2;
							num5 = 7;
							goto IL_00dc;
							IL_00dc:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 15)
									{
										if (num6 == 995)
										{
											goto IL_00d8;
										}
										goto case 7;
									}
									try
									{
										FileStream val2 = new FileStream(text2, (FileMode)3, (FileAccess)1, (FileShare)5, 81920, (FileOptions)134217728);
										int num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
										{
											num7 = 5;
										}
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 == 988)
												{
													goto IL_0232;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_0232:
											num7 = num8;
										}
										try
										{
											SHA256 val3 = System.Security.Cryptography.SHA256.Create();
											int num9 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													if (num10 == 988)
													{
														goto IL_028c;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_028c:
												num9 = num10;
											}
											try
											{
												array = (val3).ComputeHash((Stream)(object)val2);
												int num11 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
												{
													num11 = 3;
												}
												while (true)
												{
													switch (num11)
													{
													default:
														if (num12 != 10)
														{
															if (num12 != 990)
															{
																break;
															}
															goto IL_02ea;
														}
														code = "ready";
														num11 = 2;
														continue;
													case 0:
													{
														int processId = (val).Id;
														global::System.DateTime dateTime = (val).StartTime;
														dateTime = (dateTime).ToUniversalTime();
														identity = (YVZFyCidIljvrGfaweG?)new YVZFyCidIljvrGfaweG(processId, (dateTime).Ticks, (val).SessionId, text2, System.Convert.ToBase64String(array));
														num12 = 10;
														goto IL_02ea;
													}
													case 2:
														break;
													case 1:
														goto end_IL_02ee;
														IL_02ea:
														num11 = num12;
														continue;
													}
													result = true;
													num11 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
													{
														num11 = 1;
													}
													continue;
													end_IL_02ee:
													break;
												}
											}
											finally
											{
												if (val3 != null)
												{
													int num13 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
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
														case 1:
															(val3).Dispose();
															num13 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
															{
																num13 = 0;
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
										finally
										{
											int num15;
											if (val2 == null)
											{
												num15 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
												{
													num15 = 3;
												}
												goto IL_048f;
											}
											goto IL_04b3;
											IL_048f:
											while (true)
											{
												switch (num15)
												{
												default:
													if (num16 == 990)
													{
														goto IL_048b;
													}
													goto end_IL_048f;
												case 2:
													break;
												case 1:
													goto end_IL_048f;
												case 0:
													goto end_IL_048f;
												}
												goto IL_04b3;
												IL_048b:
												num15 = num16;
												continue;
												end_IL_048f:
												break;
											}
											goto end_IL_0457;
											IL_04b3:
											(val2).Dispose();
											num15 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
											{
												num15 = 5;
											}
											goto IL_048f;
											end_IL_0457:;
										}
									}
									finally
									{
										if (array != null)
										{
											int num17 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
											{
												num17 = 2;
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
													System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
													num17 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
													{
														num17 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_00dc;
								case 0:
									text2 = System.IO.Path.GetFullPath(text);
									num5 = 3;
									continue;
								case 4:
									goto end_IL_00dc;
								case 2:
								case 5:
									result = false;
									num5 = 4;
									continue;
								case 7:
									if (string.IsNullOrWhiteSpace(text))
									{
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 6;
								case 3:
									array = null;
									num6 = 15;
									goto IL_00d8;
								case 6:
									if (!System.IO.File.Exists(text))
									{
										num5 = 2;
										continue;
									}
									goto case 0;
								case 1:
									{
										obj2 = null;
										break;
									}
									IL_00d8:
									num5 = num6;
									continue;
								}
								goto IL_01e2;
								continue;
								end_IL_00dc:
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num19 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
								{
									num19 = 2;
								}
								while (true)
								{
									switch (num19)
									{
									default:
										if (num20 == 989)
										{
											num19 = num20;
											continue;
										}
										break;
									case 0:
										(val).Dispose();
										num19 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num19 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
					catch (global::System.Exception obj3) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj4 = obj3 as global::System.Exception;
						if (obj4 == null)
						{
							num21 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
							{
								num21 = 19;
							}
						}
						else
						{
							ex = obj4;
							num21 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
							{
								num21 = 2;
							}
						}
						while (true)
						{
							switch (num21)
							{
							default:
								if (num22 != 20)
								{
									if (num22 == 1000)
									{
										goto IL_064e;
									}
									goto case 1;
								}
								goto case 5;
							case 4:
								flag = false;
								num21 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
								{
									num21 = 9;
								}
								continue;
							case 10:
								if (!(ex is NotSupportedException))
								{
									num21 = 6;
									continue;
								}
								goto case 5;
							case 5:
							case 8:
								flag = true;
								num21 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
								{
									num21 = 20;
								}
								continue;
							case 3:
								if (!(ex is IOException))
								{
									num21 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
									{
										num21 = 7;
									}
									continue;
								}
								goto case 5;
							case 11:
								if (ex is Win32Exception)
								{
									num21 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
									{
										num21 = 5;
									}
									continue;
								}
								goto case 3;
							case 7:
								if (!(ex is UnauthorizedAccessException))
								{
									num21 = 10;
									continue;
								}
								goto case 5;
							case 2:
								if (ex is InvalidOperationException)
								{
									num22 = 20;
									goto IL_064e;
								}
								goto case 11;
							case 0:
								if (ex is ArgumentException)
								{
									num21 = 8;
									continue;
								}
								goto case 4;
							case 6:
								if (!(ex is CryptographicException))
								{
									num21 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
									{
										num21 = 0;
									}
									continue;
								}
								goto case 5;
							case 1:
								result2 = 0;
								break;
							case 9:
							case 12:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_064e:
								num21 = num22;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num23 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num23 = 6;
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
								goto case 0;
							case 0:
								result = false;
								num23 = 2;
								continue;
							case 1:
								identity = null;
								num23 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num23 = 0;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					goto case 0;
				case 0:
					code = default;
					identity = default;
					return result;
				case 2:
					code = "java_host_client_identity_unavailable";
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
					{
						num2 = 8;
					}
					break;
				case 3:
					identity = null;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
					{
						num2 = 2;
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
	internal static bool mT8i6So1c0(irLi0FSdwZq9Aly8Tsu? challenge, object expected, long nowUnixTimeMilliseconds)
	{
		System.ArgumentNullException.ThrowIfNull(expected, "expected");
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mAJiRQ03bM(object expected, object actual)
	{
		System.ArgumentNullException.ThrowIfNull(actual, "actual");
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void McriwFR0gM(object request, object challenge, object client)
	{
		((kpLhhaSH4f4durtm5lL)request).ChallengeNonce = Upe6oqYiScDasDAhdiT.BkWYzrxEAP(32);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TY9ieucxy5(object value, bool result)
	{
		System.Security.Cryptography.CryptographicOperations.ZeroMemory(((global::System.Span<byte>)(byte[])value));
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
	internal static bool p3mlsrZo36qaIRI4XrOK()
	{
		return R9pLl1Zo1c8QHcu4Tuog == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JkWbcviHn9LLlXcTuGr a7qr9xZovRMR8yKWi38B()
	{
		return (JkWbcviHn9LLlXcTuGr)R9pLl1Zo1c8QHcu4Tuog;
	}
}

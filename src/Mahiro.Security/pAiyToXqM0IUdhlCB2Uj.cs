using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using mRtVTpXuWApMcYm2WxSN;

namespace AsNEGcXqpKQLwv7QjmrO;

internal class pAiyToXqM0IUdhlCB2Uj
{
	internal static object gyej0qZxNXPM02FPpKgV;

	[MethodImpl((MethodImplOptions)8)]
	internal static string t3HXqucWAp0(int processId)
	{
		string text = lKtKCyXuyB6tLjdcZ2QJ.b7LXuhUwtRI();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(16, 1);
		(defaultInterpolatedStringHandler).AppendLiteral("mcp-patch-");
		defaultInterpolatedStringHandler.AppendFormatted<int>(processId);
		(defaultInterpolatedStringHandler).AppendLiteral(".stage");
		return System.IO.Path.Combine(text, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string G8AXqaoPMOf(int processId)
	{
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Expected O, but got Unknown
		int num = 1;
		int num11 = default(int);
		FileStream val = default(FileStream);
		int num7 = default(int);
		bool flag = default(bool);
		char c = default(char);
		string text4 = default(string);
		int num5 = default(int);
		string result = default(string);
		string text3 = default(string);
		byte[] array = default(byte[]);
		int num8 = default(int);
		bool flag2 = default(bool);
		int num10 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		global::System.Exception ex = default(global::System.Exception);
		int num14 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num16 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					string text = t3HXqucWAp0(processId);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
					{
						num2 = 10;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num11 != 12)
							{
								if (num11 == 992)
								{
									goto IL_0069;
								}
								goto case 0;
							}
							goto IL_0132;
						case 4:
							val = new FileStream(text, (FileMode)3, (FileAccess)1, (FileShare)3);
							num2 = 2;
							continue;
						case 0:
							if (System.IO.File.Exists(text))
							{
								num2 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
								{
									num2 = 1;
								}
								continue;
							}
							goto IL_0132;
						case 3:
							break;
						case 1:
							if ((System.IO.File.GetAttributes(text) & (FileAttributes)(0x400)) != 0)
							{
								num11 = 12;
								goto IL_0069;
							}
							goto case 4;
						case 2:
							{
								try
								{
									long num3 = (val).Length;
									int num4 = 26;
									while (true)
									{
										int num6;
										string text2;
										switch (num4)
										{
										default:
											if (num7 != 54)
											{
												if (num7 == 1034)
												{
													goto IL_0195;
												}
												goto case 23;
											}
											goto case 2;
										case 4:
											flag = false;
											num4 = 16;
											continue;
										case 16:
										case 43:
											if (flag)
											{
												num4 = 21;
												continue;
											}
											goto case 38;
										case 2:
											c = ((dynamic)(text4)).Chars;
											num4 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
											{
												num4 = 23;
											}
											continue;
										case 35:
											result = "stage=invalid";
											num4 = 31;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
											{
												num4 = 3;
											}
											continue;
										case 23:
											flag = char.IsAsciiLetterOrDigit(c);
											num4 = 46;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
											{
												num4 = 51;
											}
											continue;
										case 38:
											text3 = ((System.Text.Encoding.ASCII).GetString(array, 0, num8)).Trim();
											num6 = 11;
											goto IL_0191;
										case 10:
											flag = true;
											num6 = 43;
											goto IL_0191;
										case 41:
											goto end_IL_0199;
										case 19:
											text2 = "stage=invalid";
											break;
										case 1:
										case 15:
											num5++;
											num4 = 13;
											continue;
										case 17:
											if (num8 > 256)
											{
												num6 = 10;
												goto IL_0191;
											}
											goto case 4;
										case 8:
											array = new byte[257];
											num4 = 33;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
											{
												num4 = 6;
											}
											continue;
										case 25:
											if ((uint)c > 45u)
											{
												num4 = 45;
												continue;
											}
											goto case 14;
										case 20:
											flag = true;
											num4 = 37;
											continue;
										case 33:
											num8 = (val).Read(array, 0, array.Length);
											num4 = 27;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
											{
												num4 = 42;
											}
											continue;
										case 34:
											if (c == '_')
											{
												num4 = 30;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
												{
													num4 = 42;
												}
												continue;
											}
											goto case 3;
										case 46:
											if (!flag)
											{
												num4 = 25;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
												{
													num4 = 48;
												}
												continue;
											}
											goto case 28;
										case 39:
											if (c != '-')
											{
												num4 = 27;
												continue;
											}
											goto case 30;
										case 28:
											if (flag)
											{
												num4 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
												{
													num4 = 35;
												}
												continue;
											}
											goto case 35;
										case 26:
											if (num3 > 0)
											{
												num4 = 22;
												continue;
											}
											goto case 20;
										case 14:
											if (c != ' ')
											{
												num6 = 39;
												goto IL_0191;
											}
											goto case 30;
										case 22:
											if (num3 <= 256)
											{
												num4 = 6;
												continue;
											}
											goto case 20;
										case 42:
											if (num8 > 0)
											{
												num4 = 17;
												continue;
											}
											goto case 10;
										case 0:
											goto end_IL_0199;
										case 30:
											flag2 = true;
											num4 = 5;
											continue;
										case 3:
										case 27:
											flag2 = false;
											num4 = 12;
											continue;
										case 6:
										case 29:
											flag = false;
											num4 = 32;
											continue;
										case 5:
										case 12:
											flag = flag2;
											num4 = 28;
											continue;
										case 11:
											text4 = text3;
											num4 = 40;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
											{
												num4 = 7;
											}
											continue;
										case 40:
											num5 = 0;
											num4 = 18;
											continue;
										case 24:
											result = "stage=invalid";
											num6 = 41;
											goto IL_0191;
										case 36:
										case 45:
											if (c != '=')
											{
												num4 = 34;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
												{
													num4 = 33;
												}
												continue;
											}
											goto case 30;
										case 32:
										case 37:
											if (flag)
											{
												num4 = 24;
												continue;
											}
											goto case 8;
										case 21:
											result = "stage=invalid";
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
											{
												num4 = 53;
											}
											continue;
										case 13:
										case 18:
											if (num5 < (text4).Length)
											{
												num6 = 54;
												goto IL_0191;
											}
											goto case 9;
										case 31:
											goto end_IL_0199;
										case 9:
											if ((text3).StartsWith("stage=", (StringComparison)4))
											{
												num4 = 44;
												continue;
											}
											goto case 19;
										case 44:
											text2 = text3;
											break;
										case 7:
											goto end_IL_0199;
											IL_0191:
											num7 = num6;
											goto IL_0195;
											IL_0195:
											num4 = num7;
											continue;
										}
										result = text2;
										num4 = 7;
										continue;
										end_IL_0199:
										break;
									}
								}
								finally
								{
									if (val != null)
									{
										int num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
										{
											num9 = 1;
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
											case 1:
												break;
											case 0:
												goto end_IL_07b6;
											}
											(val).Dispose();
											num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
											{
												num9 = 3;
											}
											continue;
											end_IL_07b6:
											break;
										}
									}
								}
								break;
							}
							IL_0069:
							num2 = num11;
							continue;
							IL_0132:
							result = "stage=unavailable";
							num2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
							{
								num2 = 3;
							}
							continue;
						}
						break;
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num12 = 4;
					}
					else
					{
						ex = obj2;
						num12 = 2;
					}
					while (true)
					{
						switch (num12)
						{
						default:
							if (num14 != 13)
							{
								if (num14 == 993)
								{
									goto IL_0826;
								}
								goto case 2;
							}
							goto case 3;
						case 1:
							flag = true;
							num12 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num12 = 11;
							}
							continue;
						case 5:
							flag = false;
							num13 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num13 = 13;
							}
							num14 = num13;
							goto IL_0826;
						case 0:
							if (ex is UnauthorizedAccessException)
							{
								num12 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
								{
									num12 = 1;
								}
								continue;
							}
							goto case 5;
						case 2:
							if (!(ex is IOException))
							{
								num12 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
								{
									num12 = 10;
								}
								continue;
							}
							goto case 1;
						case 4:
							result2 = 0;
							break;
						case 3:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0826:
							num12 = num14;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num15 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
					{
						num15 = 2;
					}
					while (true)
					{
						switch (num15)
						{
						default:
							if (num16 == 989)
							{
								num15 = num16;
								continue;
							}
							break;
						case 1:
							result = "stage=unreadable";
							num15 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
							{
								num15 = 0;
							}
							continue;
						case 0:
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
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool qvU3NSZxMJPhffog97tQ()
	{
		return gyej0qZxNXPM02FPpKgV == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static pAiyToXqM0IUdhlCB2Uj OgthyFZxpZJpk8vwPI7Z()
	{
		return (pAiyToXqM0IUdhlCB2Uj)gyej0qZxNXPM02FPpKgV;
	}
}

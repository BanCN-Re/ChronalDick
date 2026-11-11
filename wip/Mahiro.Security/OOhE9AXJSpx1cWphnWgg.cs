using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace ulWEeSXJc4vaaHfwS6DF;

internal class OOhE9AXJSpx1cWphnWgg
{
	private struct dNSbDoLb75dWGFPPWoo8
	{
		public ushort uToLbA89MEA;

		public ushort cFFLbIw8F2r;

		public nint vvHLbB43TQY;
	}

	internal static object FrBrPGZdbcwnQE1haFi4;

	[MethodImpl((MethodImplOptions)8)]
	internal static int? ReadParentProcessId(int pid)
	{
		//IL_033a->IL033a: Incompatible stack types: I4 vs O
		int num = 2;
		SafeProcessHandle val = default(SafeProcessHandle);
		int num4 = default(int);
		int num15 = default(int);
		int? num11 = default(int?);
		nint num5 = default(nint);
		int num9 = default(int);
		int? num12 = default(int?);
		long num8 = default(long);
		nint num7 = default(nint);
		int num14 = default(int);
		int num17 = default(int);
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
						goto end_IL_000d;
					}
					goto case 2;
				case 2:
					val = OpenProcess(4096u, inherit: false, pid);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						int num3;
						if ((val).IsInvalid)
						{
							num3 = 4;
							goto IL_008c;
						}
						goto IL_00ed;
						IL_00ed:
						num4 = nint.Size * 6;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num3 = 1;
						}
						goto IL_008c;
						IL_008c:
						while (true)
						{
							switch (num3)
							{
							default:
								if (num15 != 12)
								{
									if (num15 == 992)
									{
										goto IL_0088;
									}
									goto case 1;
								}
								goto end_IL_008c;
							case 4:
								num11 = null;
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								break;
							case 2:
								num11 = num11;
								num15 = 12;
								goto IL_0088;
							case 1:
								num5 = System.Runtime.InteropServices.Marshal.AllocHGlobal(num4);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num3 = 7;
								}
								continue;
							case 0:
								{
									try
									{
										int num6;
										if (NtQueryInformationProcess(val, 0, num5, num4, out var _) >= 0)
										{
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
											{
												num6 = 16;
											}
											goto IL_01aa;
										}
										goto IL_023f;
										IL_01aa:
										while (true)
										{
											int? obj;
											int num10;
											switch (num6)
											{
											default:
												if (num9 != 18)
												{
													if (num9 == 998)
													{
														goto IL_01a6;
													}
													goto case 6;
												}
												goto end_IL_01aa;
											case 9:
												goto end_IL_01aa;
											case 1:
												obj = num12;
												goto IL_033a;
											case 3:
												if (num8 > 0)
												{
													num6 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
													{
														num6 = 12;
													}
													continue;
												}
												goto case 8;
											case 2:
												break;
											case 5:
												num11 = num12;
												num6 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
												{
													num6 = 9;
												}
												continue;
											case 4:
												num8 = (num7).ToInt64();
												num10 = 3;
												goto IL_01a2;
											case 7:
												if (num8 <= 2147483647)
												{
													num6 = 6;
													continue;
												}
												goto case 8;
											case 0:
											case 10:
												num7 = System.Runtime.InteropServices.Marshal.ReadIntPtr(num5, nint.Size * 5);
												num6 = 4;
												continue;
											case 8:
												num12 = null;
												num6 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
												{
													num6 = 1;
												}
												continue;
											case 6:
												{
													obj = (int?)(object)num8;
													goto IL_033a;
												}
												IL_01a6:
												num6 = num9;
												continue;
												IL_033a:
												num11 = obj;
												num10 = 18;
												goto IL_01a2;
												IL_01a2:
												num9 = num10;
												goto IL_01a6;
											}
											goto IL_023f;
											continue;
											end_IL_01aa:
											break;
										}
										goto end_IL_0165;
										IL_023f:
										num12 = null;
										num6 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
										{
											num6 = 10;
										}
										goto IL_01aa;
										end_IL_0165:;
									}
									finally
									{
										System.Runtime.InteropServices.Marshal.FreeHGlobal(num5);
										int num13 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
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
									goto end_IL_008c;
								}
								IL_0088:
								num3 = num15;
								continue;
							}
							goto IL_00ed;
							continue;
							end_IL_008c:
							break;
						}
					}
					finally
					{
						int num16;
						if (val == null)
						{
							num16 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
							{
								num16 = 4;
							}
							goto IL_03dd;
						}
						goto IL_0425;
						IL_03dd:
						while (true)
						{
							switch (num16)
							{
							default:
								if (num17 == 990)
								{
									goto IL_03d9;
								}
								break;
							case 2:
								goto end_IL_03dd;
							case 1:
								break;
							case 0:
								goto end_IL_03dd;
							}
							goto IL_0425;
							IL_03d9:
							num16 = num17;
							continue;
							end_IL_03dd:
							break;
						}
						goto end_IL_03a5;
						IL_0425:
						(val).Dispose();
						num16 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num16 = 8;
						}
						goto IL_03dd;
						end_IL_03a5:;
					}
					break;
				case 0:
					break;
				}
				return num11;
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string? Read(int pid)
	{
		//IL_01fd: Expected O, but got I4
		int num = 1;
		SafeProcessHandle val = default(SafeProcessHandle);
		int returnLength = default(int);
		int num12 = default(int);
		string result = default(string);
		int num11 = default(int);
		nint num4 = default(nint);
		int num6 = default(int);
		dNSbDoLb75dWGFPPWoo8 dNSbDoLb75dWGFPPWoo = default(dNSbDoLb75dWGFPPWoo8);
		long num7 = default(long);
		int num10 = default(int);
		int num15 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001e;
				case 0:
					try
					{
						int num3;
						if ((val).IsInvalid)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num3 = 3;
							}
						}
						else
						{
							NtQueryInformationProcess(val, 60, global::nint.Zero, 0, out returnLength);
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num3 = 0;
							}
						}
						while (true)
						{
							int num13;
							switch (num3)
							{
							default:
								if (num12 != 19)
								{
									if (num12 == 999)
									{
										goto IL_0070;
									}
									goto case 4;
								}
								break;
							case 9:
								break;
							case 5:
							case 8:
								result = null;
								num13 = 9;
								goto IL_006c;
							case 6:
								if (num11 == 87)
								{
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
									{
										num3 = 14;
									}
									continue;
								}
								goto case 2;
							case 4:
								if (returnLength <= 131072)
								{
									num3 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 5;
							case 0:
								result = null;
								num13 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
								{
									num13 = 10;
								}
								goto IL_006c;
							case 7:
							case 10:
								num4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(returnLength);
								num3 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
								{
									num3 = 1;
								}
								continue;
							case 11:
								if (returnLength < Marshal.SizeOf<dNSbDoLb75dWGFPPWoo8>())
								{
									num3 = 8;
									continue;
								}
								goto case 4;
							case 2:
							{
								_ = 24;
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
								(defaultInterpolatedStringHandler).AppendLiteral("无法读取 Java 进程 PID ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(pid);
								(defaultInterpolatedStringHandler).AppendLiteral(" 的启动信息。");
								throw (defaultInterpolatedStringHandler).ToStringAndClear();
							}
							case 3:
								num11 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
								{
									num3 = 4;
								}
								continue;
							case 1:
								{
									try
									{
										int num5;
										if (NtQueryInformationProcess(val, 60, num4, returnLength, out var _) >= 0)
										{
											num5 = 5;
											goto IL_02ef;
										}
										goto IL_04c2;
										IL_04c2:
										result = null;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
										{
											num5 = 7;
										}
										goto IL_02ef;
										IL_02ef:
										while (true)
										{
											int num8;
											switch (num5)
											{
											default:
												if (num6 != 21)
												{
													if (num6 == 1001)
													{
														goto IL_02eb;
													}
													goto case 2;
												}
												goto end_IL_02ef;
											case 2:
											case 9:
												result = null;
												num5 = 10;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
												{
													num5 = 8;
												}
												continue;
											case 4:
												if (dNSbDoLb75dWGFPPWoo.uToLbA89MEA % 2 != 0)
												{
													num8 = 2;
													goto IL_02e7;
												}
												goto case 11;
											case 1:
											case 13:
												result = System.Runtime.InteropServices.Marshal.PtrToStringUni(dNSbDoLb75dWGFPPWoo.vvHLbB43TQY, dNSbDoLb75dWGFPPWoo.uToLbA89MEA / 2);
												num8 = 21;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
												{
													num8 = 2;
												}
												goto IL_02e7;
											case 8:
												goto end_IL_02ef;
											case 0:
												num7 = (dNSbDoLb75dWGFPPWoo.vvHLbB43TQY).ToInt64() - (num4).ToInt64();
												num5 = 10;
												continue;
											case 5:
											case 12:
												dNSbDoLb75dWGFPPWoo = Marshal.PtrToStructure<dNSbDoLb75dWGFPPWoo8>((global::nint)num4);
												num5 = 18;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
												{
													num5 = 0;
												}
												continue;
											case 11:
												if (num7 >= Marshal.SizeOf<dNSbDoLb75dWGFPPWoo8>())
												{
													num5 = 6;
													continue;
												}
												goto case 2;
											case 7:
												goto end_IL_02ef;
											case 6:
												if (num7 <= returnLength - dNSbDoLb75dWGFPPWoo.uToLbA89MEA)
												{
													num5 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
													{
														num5 = 1;
													}
													continue;
												}
												goto case 2;
											case 3:
												break;
											case 10:
												{
													if (dNSbDoLb75dWGFPPWoo.uToLbA89MEA != 0)
													{
														num5 = 4;
														continue;
													}
													goto case 2;
												}
												IL_02eb:
												num5 = num6;
												continue;
												IL_02e7:
												num6 = num8;
												goto IL_02eb;
											}
											goto IL_04c2;
											continue;
											end_IL_02ef:
											break;
										}
									}
									finally
									{
										System.Runtime.InteropServices.Marshal.FreeHGlobal(num4);
										int num9 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
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
								}
								IL_006c:
								num12 = num13;
								goto IL_0070;
								IL_0070:
								num3 = num12;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num14 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
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
									(val).Dispose();
									num14 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
									{
										num14 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					break;
				case 1:
					val = OpenProcess(4096u, inherit: false, pid);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				}
				goto IL_064d;
				IL_001e:
				if (num == 990)
				{
					break;
				}
				goto IL_064d;
				IL_064d:
				return result;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeProcessHandle OpenProcess(uint access, [MarshalAs((UnmanagedType)2)] bool inherit, int pid);

	[DllImport("ntdll.dll")]
	private static extern int NtQueryInformationProcess(SafeProcessHandle process, int informationClass, nint information, int length, out int returnLength);

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
							goto case 0;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool uCyeB2ZdX5mgSweEN8Pd()
	{
		return FrBrPGZdbcwnQE1haFi4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OOhE9AXJSpx1cWphnWgg rkkuiXZdfQSoF5X46kvq()
	{
		return (OOhE9AXJSpx1cWphnWgg)FrBrPGZdbcwnQE1haFi4;
	}
}

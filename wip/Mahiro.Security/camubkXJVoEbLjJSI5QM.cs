using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using fVk0T8XW33OEoFMbe0uo;

namespace DgSNUQXJYcoAGI4tZHfd;

internal class camubkXJVoEbLjJSI5QM
{
	private static object Na8H63ZliHBALB9gs1l1;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Collections.Generic.IReadOnlyList<k3xHGkXW1iST0JWp5lwf> ReadListeners(int port = 25565)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ReadTable(int family, bool ipv6, int expectedPort, List<k3xHGkXW1iST0JWp5lwf> result)
	{
		//IL_046d->IL00fc: Incompatible stack heights: 3 vs 1
		int num = 5;
		nint num6 = default(nint);
		int num4 = default(int);
		uint extendedTcpTable = default(uint);
		int size = default(int);
		int num15 = default(int);
		int num16 = default(int);
		int num9 = default(int);
		nint num17 = default(nint);
		int num10 = default(int);
		int num12 = default(int);
		int processId = default(int);
		int num8 = default(int);
		int num20 = default(int);
		int num5 = default(int);
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
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_000d;
							}
							goto case 6;
						}
						throw new global::System.Exception("无法查询本地 TCP 监听及所属进程。");
					case 2:
						num6 = System.Runtime.InteropServices.Marshal.AllocHGlobal(num4);
						num3 = 13;
						continue;
					case 13:
						try
						{
							extendedTcpTable = GetExtendedTcpTable(num6, ref size, order: false, family, 3, 0u);
							int num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num7 = 26;
							}
							while (true)
							{
								int num13;
								int num11;
								int num14;
								int num18;
								switch (num7)
								{
								default:
									if (num15 != 28)
									{
										if (num15 == 1008)
										{
											goto IL_0100;
										}
										goto case 4;
									}
									num13 = 8;
									goto IL_03e9;
								case 1:
									if (extendedTcpTable != 0)
									{
										num7 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
										{
											num7 = 8;
										}
										continue;
									}
									if (ipv6)
									{
										num7 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
										{
											num7 = 18;
										}
										continue;
									}
									goto case 16;
								case 16:
									num11 = 24;
									goto IL_03db;
								case 15:
									throw new global::System.Exception("系统返回了无效的 TCP 监听表。");
								case 18:
								case 19:
									if (num16 >= num9)
									{
										num7 = 14;
										continue;
									}
									goto case 2;
								case 11:
									if (!ipv6)
									{
										num14 = 28;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
										{
											num14 = 5;
										}
										goto IL_00fc;
									}
									num13 = 20;
									goto IL_03e9;
								case 0:
									if (num9 >= 0)
									{
										num7 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
										{
											num7 = 7;
										}
										continue;
									}
									goto case 15;
								case 2:
									num17 = nint.Add(num6, 4 + num16 * num10);
									num7 = 11;
									continue;
								case 20:
									num9 = System.Runtime.InteropServices.Marshal.ReadInt32(num6);
									num7 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										num7 = 0;
									}
									continue;
								case 5:
									if (!ipv6)
									{
										num7 = 10;
										continue;
									}
									num18 = -1;
									break;
								case 12:
									if (((System.Runtime.InteropServices.Marshal.ReadByte(num17, num12) << 8) | System.Runtime.InteropServices.Marshal.ReadByte(num17, num12 + 1)) == expectedPort)
									{
										num7 = 4;
										continue;
									}
									goto case 9;
								case 10:
									num18 = System.Runtime.InteropServices.Marshal.ReadInt32(num17, 4);
									break;
								case 6:
									if (num9 <= (num4 - 4) / num10)
									{
										num16 = 0;
										num14 = 19;
										goto IL_00fc;
									}
									num7 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
									{
										num7 = 10;
									}
									continue;
								case 8:
									throw new global::System.Exception("无法查询本地 TCP 监听及所属进程。");
								case 7:
									goto end_IL_0104;
								case 3:
									if (extendedTcpTable == 122)
									{
										num7 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num7 = 14;
										}
										continue;
									}
									goto case 1;
								case 9:
									num16++;
									num7 = 18;
									continue;
								case 17:
									num11 = 56;
									goto IL_03db;
								case 4:
									processId = System.Runtime.InteropServices.Marshal.ReadInt32(num17, ipv6 ? 52 : 20);
									num7 = 5;
									continue;
								case 13:
									new k3xHGkXW1iST0JWp5lwf(processId, !ipv6 && (num8 == 0 || num8 == 16777343));
									_ = 9;
									goto IL_00fc;
								case 14:
									return;
									IL_03db:
									num10 = num11;
									num7 = 20;
									continue;
									IL_03e9:
									num12 = num13;
									num7 = 12;
									continue;
									IL_0100:
									num7 = num15;
									continue;
									IL_00fc:
									num15 = num14;
									goto IL_0100;
								}
								num8 = num18;
								num7 = 13;
								continue;
								end_IL_0104:
								break;
							}
						}
						finally
						{
							System.Runtime.InteropServices.Marshal.FreeHGlobal(num6);
							int num19 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
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
						goto case 7;
					case 5:
						size = 0;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
						{
							num3 = 19;
						}
						continue;
					case 4:
						extendedTcpTable = GetExtendedTcpTable(global::nint.Zero, ref size, order: false, family, 3, 0u);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
						{
							num3 = 14;
						}
						continue;
					case 9:
						return;
					case 11:
					case 12:
						if (extendedTcpTable != 122)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_00b6;
					case 8:
						throw new global::System.Exception("TCP 监听表持续变化，请刷新状态后重试。");
					case 7:
						num5++;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 0;
						}
						continue;
					case 14:
						if (extendedTcpTable != 0)
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
							{
								num3 = 15;
							}
							continue;
						}
						goto case 10;
					case 10:
						if (size == 0)
						{
							return;
						}
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 12;
						}
						continue;
					case 6:
						num4 = size;
						num = 2;
						break;
					case 0:
					case 3:
						if (num5 >= 3)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 6;
					case 1:
						{
							if (extendedTcpTable != 0)
							{
								num = 21;
								break;
							}
							goto IL_00b6;
						}
						IL_00b6:
						num5 = 0;
						num = 3;
						break;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[DllImport("iphlpapi.dll")]
	private static extern uint GetExtendedTcpTable(nint table, ref int size, [MarshalAs((UnmanagedType)2)] bool order, int family, int tableClass, uint reserved);

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
							goto case 1;
						}
						return;
					case 0:
						break;
					case 2:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kbTuJJZlnOBkyRgUwMnp()
	{
		return Na8H63ZliHBALB9gs1l1 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static camubkXJVoEbLjJSI5QM rnmimmZlzE0TWCsocdaE()
	{
		return (camubkXJVoEbLjJSI5QM)Na8H63ZliHBALB9gs1l1;
	}
}

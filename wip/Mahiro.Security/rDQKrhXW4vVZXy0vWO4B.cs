using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;
using qpWY8ZXJWVEkufD4WDTK;
using xAceLqXWMytQDox0p5bJ;

namespace Ve8Or4XWh9nK1FHHtemB;

internal class rDQKrhXW4vVZXy0vWO4B
{
	internal static object LssqKCZl7jTP5LRCJrMa;

	[MethodImpl((MethodImplOptions)8)]
	internal static void VerifyClient(object pipe, int expectedPid)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void VerifyServer(object pipe, int expectedPid, long creationTime)
	{
		int num = 1;
		Process val = default(Process);
		int num5 = default(int);
		int num7 = default(int);
		int processId = default(int);
		global::System.DateTime startTimeUtc = default(global::System.DateTime);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_000d;
							}
							goto case 4;
						}
						try
						{
							ProcessModule obj = (val).MainModule;
							int num4;
							if (obj == null)
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
								{
									num4 = 5;
								}
								goto IL_0155;
							}
							object obj2 = (obj).FileName;
							goto IL_01ad;
							IL_01e6:
							throw new global::System.Exception("Java 请求方不是当前 Chronal 主程序。");
							IL_0155:
							while (true)
							{
								switch (num4)
								{
								case 0:
									return;
								default:
									if (num5 == 990)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
									break;
								case 2:
									goto IL_01e6;
								}
								break;
							}
							obj2 = null;
							goto IL_01ad;
							IL_01ad:
							if (string.Equals((string)obj2, System.Environment.ProcessPath, (StringComparison)5))
							{
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
								{
									num4 = 3;
								}
								goto IL_0155;
							}
							goto IL_01e6;
						}
						finally
						{
							int num6;
							if (val == null)
							{
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
								{
									num6 = 3;
								}
								goto IL_0246;
							}
							goto IL_026a;
							IL_0246:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_0242;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0246;
								case 2:
									goto end_IL_0246;
								}
								goto IL_026a;
								IL_0242:
								num6 = num7;
								continue;
								end_IL_0246:
								break;
							}
							goto end_IL_020e;
							IL_026a:
							(val).Dispose();
							num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num6 = 5;
							}
							goto IL_0246;
							end_IL_020e:;
						}
					case 2:
						return;
					case 1:
						if (GetNamedPipeServerProcessId((pipe).SafePipeHandle, out processId))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 5;
					case 3:
					{
						HTA2r6XWNKDt09pf0WBJ? hTA2r6XWNKDt09pf0WBJ = QPVtaYXJyNOQIs30qeoH.Read(expectedPid);
						if ((object)hTA2r6XWNKDt09pf0WBJ == null)
						{
							num3 = 6;
							continue;
						}
						startTimeUtc = hTA2r6XWNKDt09pf0WBJ.StartTimeUtc;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num3 = 4;
						}
						continue;
					}
					case 5:
					case 6:
						throw new global::System.Exception("Java 请求方进程身份不匹配。");
					case 7:
						break;
					case 0:
						if (processId == expectedPid)
						{
							num3 = 3;
							continue;
						}
						goto case 5;
					case 4:
						if ((startTimeUtc).ToFileTimeUtc() == creationTime)
						{
							num3 = 7;
							continue;
						}
						goto case 5;
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
			val = System.Diagnostics.Process.GetProcessById(expectedPid);
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
			{
				num = 14;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetNamedPipeClientProcessId(SafePipeHandle pipe, out int processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetNamedPipeServerProcessId(SafePipeHandle pipe, out int processId);

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
						return;
					case 0:
						break;
					case 2:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
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
	internal static bool GxxKLHZlAviHEyOvRD9u()
	{
		return LssqKCZl7jTP5LRCJrMa == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rDQKrhXW4vVZXy0vWO4B vTEI5hZlI5gAVIwCnA24()
	{
		return (rDQKrhXW4vVZXy0vWO4B)LssqKCZl7jTP5LRCJrMa;
	}
}

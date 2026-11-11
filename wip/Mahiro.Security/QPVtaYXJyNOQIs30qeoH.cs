using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;
using xAceLqXWMytQDox0p5bJ;

namespace qpWY8ZXJWVEkufD4WDTK;

internal class QPVtaYXJyNOQIs30qeoH
{
	private static object ildZCvZd9nUcaRKAsOEn;

	[MethodImpl((MethodImplOptions)8)]
	internal static HTA2r6XWNKDt09pf0WBJ? Read(int pid)
	{
		//IL_00bd: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_01b1: Expected O, but got I4
		int num = 1;
		SafeProcessHandle val = default(SafeProcessHandle);
		HTA2r6XWNKDt09pf0WBJ result = default(HTA2r6XWNKDt09pf0WBJ);
		int num5 = default(int);
		int num6 = default(int);
		int num8 = default(int);
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
					goto case 0;
				case 0:
					try
					{
						int num3;
						int num4;
						if ((val).IsInvalid)
						{
							num3 = 6;
						}
						else
						{
							if (!GetExitCodeProcess(val, out var exitCode))
							{
								num4 = 3;
								goto IL_0057;
							}
							if (exitCode == 259)
							{
								goto IL_0354;
							}
							num3 = 2;
						}
						goto IL_005f;
						IL_005f:
						while (true)
						{
							switch (num3)
							{
							case 3:
							{
								System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								_ = 21;
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
								(defaultInterpolatedStringHandler2).AppendLiteral("无法查询 Java 进程状态（PID ");
								defaultInterpolatedStringHandler2.AppendFormatted<int>(pid);
								(defaultInterpolatedStringHandler2).AppendLiteral("）。");
								throw (defaultInterpolatedStringHandler2).ToStringAndClear();
							}
							case 0:
								goto end_IL_0032;
							case 8:
								goto end_IL_0032;
							case 2:
								result = null;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
								{
									num3 = 13;
								}
								continue;
							case 1:
								if (num5 == 87)
								{
									num3 = 5;
									continue;
								}
								goto case 7;
							case 6:
								num5 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num3 = 4;
								}
								continue;
							case 7:
							{
								_ = 27;
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
								(defaultInterpolatedStringHandler).AppendLiteral("无法查询 Java 进程身份（PID ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(pid);
								(defaultInterpolatedStringHandler).AppendLiteral("，系统错误 ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
								(defaultInterpolatedStringHandler).AppendLiteral("）。");
								throw (defaultInterpolatedStringHandler).ToStringAndClear();
							}
							case 5:
								result = null;
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
								{
									num3 = 8;
								}
								continue;
							case 9:
								goto IL_0354;
							case 4:
								goto end_IL_0032;
							}
							break;
						}
						if (num6 != 17)
						{
							if (num6 == 997)
							{
								goto IL_005b;
							}
							goto IL_0354;
						}
						System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						_ = 23;
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
						(defaultInterpolatedStringHandler3).AppendLiteral("无法查询 Java 进程启动时间（PID ");
						defaultInterpolatedStringHandler3.AppendFormatted<int>(pid);
						(defaultInterpolatedStringHandler3).AppendLiteral("）。");
						throw (defaultInterpolatedStringHandler3).ToStringAndClear();
						IL_0057:
						num6 = num4;
						goto IL_005b;
						IL_005b:
						num3 = num6;
						goto IL_005f;
						IL_0354:
						if (GetProcessTimes(val, out var created, out var _, out var _, out var _))
						{
							result = (HTA2r6XWNKDt09pf0WBJ)new HTA2r6XWNKDt09pf0WBJ(pid, System.DateTime.FromFileTimeUtc(created));
							num3 = 4;
							goto IL_005f;
						}
						num4 = 17;
						goto IL_0057;
						end_IL_0032:;
					}
					finally
					{
						if (val != null)
						{
							int num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
							{
								num7 = 4;
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
									goto end_IL_03af;
								}
								(val).Dispose();
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num7 = 5;
								}
								continue;
								end_IL_03af:
								break;
							}
						}
					}
					break;
				case 1:
					val = OpenProcess(4096u, inherit: false, pid);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				}
				return result;
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeProcessHandle OpenProcess(uint access, [MarshalAs((UnmanagedType)2)] bool inherit, int pid);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetExitCodeProcess(SafeProcessHandle process, out uint exitCode);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetProcessTimes(SafeProcessHandle process, out long created, out long exited, out long kernel, out long user);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
						switch (num2)
						{
						case 990:
							break;
						default:
							goto end_IL_000e;
						case 9:
							goto IL_0078;
						}
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 2:
						return;
						IL_0078:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 2;
						}
						continue;
					}
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
	internal static bool wTZsklZdDPVRU2dSAJVg()
	{
		return ildZCvZd9nUcaRKAsOEn == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QPVtaYXJyNOQIs30qeoH BfIw1KZdkeb6tmPdJv7L()
	{
		return (QPVtaYXJyNOQIs30qeoH)ildZCvZd9nUcaRKAsOEn;
	}
}

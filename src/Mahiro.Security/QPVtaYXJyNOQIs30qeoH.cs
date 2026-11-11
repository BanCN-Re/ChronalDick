using System.ComponentModel;
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
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		SafeProcessHandle val = default(SafeProcessHandle);
		HTA2r6XWNKDt09pf0WBJ result = default(HTA2r6XWNKDt09pf0WBJ);
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
								goto IL_036c;
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
								int num7 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(21, 1);
								(defaultInterpolatedStringHandler2).AppendLiteral("无法查询 Java 进程状态（PID ");
								defaultInterpolatedStringHandler2.AppendFormatted<int>(pid);
								(defaultInterpolatedStringHandler2).AppendLiteral("）。");
								throw new Win32Exception(num7, (defaultInterpolatedStringHandler2).ToStringAndClear());
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
								if (num6 == 87)
								{
									num3 = 5;
									continue;
								}
								goto case 7;
							case 6:
								num6 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num3 = 4;
								}
								continue;
							case 7:
							{
								int num5 = num6;
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(27, 2);
								(defaultInterpolatedStringHandler).AppendLiteral("无法查询 Java 进程身份（PID ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(pid);
								(defaultInterpolatedStringHandler).AppendLiteral("，系统错误 ");
								defaultInterpolatedStringHandler.AppendFormatted<int>(num6);
								(defaultInterpolatedStringHandler).AppendLiteral("）。");
								throw new Win32Exception(num5, (defaultInterpolatedStringHandler).ToStringAndClear());
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
								goto IL_036c;
							case 4:
								goto end_IL_0032;
							}
							break;
						}
						if (num8 != 17)
						{
							if (num8 == 997)
							{
								goto IL_005b;
							}
							goto IL_036c;
						}
						int num9 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(23, 1);
						(defaultInterpolatedStringHandler3).AppendLiteral("无法查询 Java 进程启动时间（PID ");
						defaultInterpolatedStringHandler3.AppendFormatted<int>(pid);
						(defaultInterpolatedStringHandler3).AppendLiteral("）。");
						throw new Win32Exception(num9, (defaultInterpolatedStringHandler3).ToStringAndClear());
						IL_0057:
						num8 = num4;
						goto IL_005b;
						IL_005b:
						num3 = num8;
						goto IL_005f;
						IL_036c:
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
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
							{
								num10 = 4;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										num10 = num11;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_03c7;
								}
								(val).Dispose();
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num10 = 5;
								}
								continue;
								end_IL_03c7:
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

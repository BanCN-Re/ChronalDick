using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace LioRGnXnTmo7MsqH4aeD;

internal class HJc6fUXnsRJpQ1ZM1yft
{
	internal struct r9hsZrLVGHisQUt0ZQ2N
	{
		internal nint M17LVi1Rk5b;

		internal nint IJrLVnQHuO9;

		internal uint zs1LVzonwg5;

		internal ushort C2RLYbo6qfs;

		internal nuint zqeLYXtHPca;

		internal uint WscLYfYgn4h;

		internal uint C4MLYLAvk8F;

		internal uint VI0LYjNVUZV;
	}

	private static object kp4AuOZFq7Cn9iIWTEEp;

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern SafeProcessHandle OpenProcess(uint desiredAccess, [MarshalAs((UnmanagedType)2)] bool inheritHandle, uint processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool GetProcessTimes(SafeProcessHandle process, out ulong created, out ulong exited, out ulong kernel, out ulong user);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool IsWow64Process2(SafeProcessHandle process, out ushort processMachine, out ushort nativeMachine);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern nuint VirtualQueryEx(SafeProcessHandle process, nint address, out r9hsZrLVGHisQUt0ZQ2N information, nuint informationLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool ReadProcessMemory(SafeProcessHandle process, nint address, [Out] byte[] buffer, nuint size, out nuint bytesRead);

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
					case 0:
						return;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num3 = 8;
						}
						continue;
					case 1:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
						{
							num3 = 9;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GL1yUjZFGR1u6u2SwuaP()
	{
		return kp4AuOZFq7Cn9iIWTEEp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static HJc6fUXnsRJpQ1ZM1yft AvvyhCZFic3E3r8DhEcW()
	{
		return (HJc6fUXnsRJpQ1ZM1yft)kp4AuOZFq7Cn9iIWTEEp;
	}
}

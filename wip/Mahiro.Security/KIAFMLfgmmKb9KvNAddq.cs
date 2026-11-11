using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace QZs97cfg7H5cG2l6dckf;

internal class KIAFMLfgmmKb9KvNAddq
{
	private static object MsB9noZ1tF5vn1gAY4tH;

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	internal static extern SafeProcessHandle PlBfgAUiDOZ(uint access, bool inherit, int processId);

	[DllImport("kernel32.dll", EntryPoint = "IsWow64Process2", SetLastError = true)]
	internal static extern bool JIrfgIt4is4(SafeProcessHandle process, out ushort processMachine, out ushort nativeMachine);

	[DllImport("kernel32.dll", EntryPoint = "GetProcessTimes", SetLastError = true)]
	internal static extern bool fsAfgBagJeb(SafeProcessHandle process, out long created, out long exited, out long kernel, out long user);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	internal static extern uint yXafggvOo76(nint window, out uint processId);

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
							return;
						}
						goto end_IL_0012;
					case 2:
						break;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num3 = 8;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oJ83lLZ1O8J4vTlPQdGn()
	{
		return MsB9noZ1tF5vn1gAY4tH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static KIAFMLfgmmKb9KvNAddq L0QWyLZ15WFsNJ3NB1G0()
	{
		return (KIAFMLfgmmKb9KvNAddq)MsB9noZ1tF5vn1gAY4tH;
	}
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using JvgQTDcbARdEdTAk7GE;
using PJFIn6fwNw3W82OxkWAg;
using VlB983B3k9e3NYmI81T;
using fDAldojjppXrctUVYOJn;

namespace JTiMisBqeBn9pXfmAlu;

internal class ItTFVeB2mJDZrAbx4Mf
{
	private static object C3glZrZy1Q6ifv8nRRMb;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool TryQuery(ulong address, out pnfWcAB1dtd0grBx0DF region, out string error)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool TryRead(ulong address, int count, out byte[] bytes, out string error)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong ReadPointer(nint buffer, int offset)
	{
		//IL_0009: Expected O, but got I4
		//IL_001a: Expected I4, but got O
		//IL_0051->IL000d: Incompatible stack types: I4 vs O
		//IL_005c->IL000d: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (nint.Size != 8)
					{
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					return (ulong)System.Runtime.InteropServices.Marshal.ReadInt64(buffer, offset);
				case 0:
					return (uint)System.Runtime.InteropServices.Marshal.ReadInt32(buffer, offset);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static nint Pointer(ulong address)
	{
		//IL_0009: Expected O, but got I4
		//IL_001a: Expected I4, but got O
		//IL_0063: Expected I, but got I8
		//IL_0051->IL000d: Incompatible stack types: I4 vs O
		//IL_005c->IL000d: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 989)
					{
						goto end_IL_000d;
					}
					goto case 0;
				case 1:
					if (nint.Size == 8)
					{
						return (nint)address;
					}
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
					{
						obj2 = 6;
					}
					break;
				case 0:
					return (int)address;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nuint VirtualQuery(nint address, nint information, nuint length);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool ReadProcessMemory(nint process, nint address, byte[] buffer, nuint size, out nuint read);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0091->IL0012: Incompatible stack types: I4 vs O
		//IL_006d->IL0012: Incompatible stack types: I4 vs O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		//IL_0078->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							return;
						}
						goto IL_0031;
					case 2:
						goto end_IL_000e;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							obj2 = 5;
						}
						continue;
					case 0:
						break;
					}
					goto IL_0078;
					IL_0031:
					if ((nint)obj == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					obj2 = 9;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
					{
						obj2 = 2;
					}
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
	internal static bool hIbJZZZy37YXmfjdtQjB()
	{
		return C3glZrZy1Q6ifv8nRRMb == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern ItTFVeB2mJDZrAbx4Mf qnk2xmZyvADtF4375bFk();
}

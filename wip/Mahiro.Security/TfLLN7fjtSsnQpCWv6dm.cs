using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using VxIxGxfjNbpjLcu03XfC;
using fDAldojjppXrctUVYOJn;
using lQs7SmfZ8MofeLgDpWlN;
using wjhhZEXtACFOAtiTJSXC;

namespace mhx22gfjOC0vjxs7b34p;

internal class TfLLN7fjtSsnQpCWv6dm
{
	private static object vsFfjFLT1en;

	private static object GNufjsgMcuF;

	internal static object vXx8hfZTFxioup7hSeZX;

	[MethodImpl((MethodImplOptions)8)]
	internal static hWgTrufjTEdVmY6adQMn TZMfj5GPEFB(Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, object addresses)
	{
		byte[] array = WvVfjwCPYPb(read, moduleAddress, moduleSize, ((V1NV4TfZ0HRmQ56BROEp)addresses).GilEnsure, ((CbXEJXXt7ab6InjNuGoW)vsFfjFLT1en).Length);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hWgTrufjTEdVmY6adQMn FjWfj6oquJW(Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, object addresses)
	{
		hWgTrufjTEdVmY6adQMn hWgTrufjTEdVmY6adQMn = TZMfj5GPEFB(read, moduleAddress, moduleSize, addresses);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void hUbfjRi7dfy(Func<ulong, int, byte[]> read, object addresses, ulong moduleAddress, ulong moduleSize)
	{
		int num = 3;
		checked
		{
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							System.ArgumentNullException.ThrowIfNull(addresses, "addresses");
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
							{
								num3 = 5;
							}
							continue;
						case 1:
							if (moduleSize != 0L)
							{
								num = 4;
								break;
							}
							goto case 2;
						case 3:
							System.ArgumentNullException.ThrowIfNull(read, "read");
							num = 12;
							break;
						case 0:
							return;
						case 2:
							throw QvdfjxtxB0E("module_range");
						case 4:
							_ = moduleAddress + moduleSize;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num3 = 0;
							}
							continue;
						case 5:
							if (moduleAddress != 0L)
							{
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 2;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] WvVfjwCPYPb(Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, ulong address, int length)
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
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto IL_00a7;
					case 0:
						if ((ulong)length > moduleSize - (address - moduleAddress))
						{
							num = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num = 4;
							}
							break;
						}
						return q2dfjP8nxtF(read, address, length);
					case 1:
						if (address - moduleAddress <= moduleSize)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto IL_00a7;
					case 2:
						{
							if (address >= moduleAddress)
							{
								num = 1;
								break;
							}
							goto IL_00a7;
						}
						IL_00a7:
						throw QvdfjxtxB0E("reference_outside_module");
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong EbxfjekOnrj(ulong function, object code, int displacement, int end)
	{
		return default(ulong);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] q2dfjP8nxtF(Func<ulong, int, byte[]> read, ulong address, int length)
	{
		//IL_0006: Expected O, but got I4
		byte[] array = (byte[])length;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static InvalidDataException QvdfjxtxB0E(object reason)
	{
		return (InvalidDataException)(object)string.Concat("Python runtime initialization is not confirmed: ", (string)reason);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_000e:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						goto end_IL_0012;
					case 3:
						GNufjsgMcuF = CbXEJXXt7ab6InjNuGoW.UenXtIqea4k("initialized_gil_release", "48 89 5C 24 ? 57 48 83 EC 20 8B F9 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B D8 48 85 C0 75 ?");
						num3 = 4;
						continue;
					case 0:
						goto IL_00e8;
					case 1:
						vsFfjFLT1en = CbXEJXXt7ab6InjNuGoW.UenXtIqea4k("initialized_gil_ensure", "48 89 5C 24 ? 57 48 83 EC 20 8B 0D ? ? ? ? E8 ? ? ? ? 48 8B D8 48 85 C0 75 ? 48 8B 0D ? ? ? ? BF 01 00 00 00 8B D7 E8 ? ? ? ? 48 8B D8 48 85 C0 75 ?");
						num3 = 3;
						continue;
					case 4:
						return;
					case 5:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 1;
						}
						continue;
					}
					switch (num2)
					{
					case 993:
						break;
					default:
						return;
					case 12:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 9;
						}
						continue;
					}
					goto IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				num = 12;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
				{
					num = 0;
				}
				break;
				IL_00e8:
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 5;
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool hNfXAIZTsyanwe8AL4aX()
	{
		return vXx8hfZTFxioup7hSeZX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TfLLN7fjtSsnQpCWv6dm uqvGl9ZTTu4tG0TRxhuc()
	{
		return (TfLLN7fjtSsnQpCWv6dm)vXx8hfZTFxioup7hSeZX;
	}
}

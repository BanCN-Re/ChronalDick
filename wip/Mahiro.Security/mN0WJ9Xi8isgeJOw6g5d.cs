using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Sef9I6XiD0OPtFxxu5LU;
using fDAldojjppXrctUVYOJn;
using oiaeLRfZVoDvSB01scrZ;
using wjhhZEXtACFOAtiTJSXC;

namespace j8AoSCXiyIh7VppA4q1a;

internal class mN0WJ9Xi8isgeJOw6g5d
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	internal struct __c__DisplayClass5_0_8
	{
		public ulong moduleAddress;

		public ulong moduleSize;

		public Func<ulong, int, byte[]> read;
	}

	private static object u0mXi4PF3ms;

	private static object IWWXihRpOb2;

	private static object elgXiUgobp9;

	private static object Ho3Xirop1q9;

	private static object J5FXiogegkH;

	internal static object FKFeuCZFQbYYYBo7Yl5h;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static CejIKKXi9rWtr7x2uMe5 dTlXiWYhIPr(global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq> chunks, Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, CancellationToken cancellationToken = default(CancellationToken))
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong fehXiJR1spI(ulong address, global::System.ReadOnlySpan<byte> code, int displacement, int length)
	{
		//IL_0017: Expected O, but got I4
		checked
		{
			_ = unchecked((long)address) + unchecked((long)length);
			_ = code;
			return (ulong)(unchecked((long)displacement) + unchecked((long)System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian((global::System.ReadOnlySpan<byte>)4)));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 4;
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						return;
					case 2:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 8;
						continue;
					case 3:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
						{
							num3 = 4;
						}
						continue;
					case 7:
						break;
					case 6:
						IWWXihRpOb2 = CbXEJXXt7ab6InjNuGoW.UenXtIqea4k("engine-version-registration", "4C 8D 05 ? ? ? ? 48 8B CB 48 8D 15 ? ? ? ? E8 ? ? ? ?");
						num3 = 5;
						continue;
					case 5:
						elgXiUgobp9 = CbXEJXXt7ab6InjNuGoW.UenXtIqea4k("engine-version-getter", "40 53 48 83 EC 60 48 8B 05 ? ? ? ? 48 33 C4 48 89 44 24 50 48 8B CA 48 8D 15 ? ? ? ? E8 ? ? ? ? 85 C0 75 07 33 DB E9 ? ? ? ? E8 ? ? ? ? 48 8D 54 24 30 48 8B C8 E8 ? ? ? ?");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 14;
						}
						continue;
					case 0:
						Ho3Xirop1q9 = CbXEJXXt7ab6InjNuGoW.UenXtIqea4k("engine-version-string-call", "48 83 7C 24 48 0F 48 8D 4C 24 30 48 8B 54 24 40 48 0F 47 4C 24 30 E8 ? ? ? ? 48 8B 54 24 48 48 8B D8");
						num3 = 7;
						continue;
					case 4:
						num3 = 3;
						continue;
					case 8:
						u0mXi4PF3ms = (System.Text.Encoding.ASCII).GetBytes("get_engine_version\u0000");
						num3 = 6;
						continue;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
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
			J5FXiogegkH = System.Convert.FromHexString("4889742420574883EC20488BFA488BF14885D27920");
			num = 15;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	internal static bool nEmXiQY5vD9(ulong address, int length, ref __c__DisplayClass5_0_8 P_2)
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return address - P_2.moduleAddress <= (ulong)((long)P_2.moduleSize - (long)length);
					case 3:
						if ((ulong)length <= P_2.moduleSize)
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 1:
						if (length < 0)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
							{
								num3 = 8;
							}
							break;
						}
						goto case 3;
					case 0:
						return false;
					case 2:
						if (address >= P_2.moduleAddress)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
							{
								num3 = 9;
							}
							break;
						}
						goto case 0;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	internal static byte[] dtwXiCjqGk2(ulong address, int length, ref __c__DisplayClass5_0_8 P_2)
	{
		//IL_000b: Expected O, but got I4
		_ = P_2.read;
		byte[] array = (byte[])length;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Vwsw39ZFC4OfMBfo9Rfn()
	{
		return FKFeuCZFQbYYYBo7Yl5h == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static mN0WJ9Xi8isgeJOw6g5d SsvcTwZF4J5XqWu42OoM()
	{
		return (mN0WJ9Xi8isgeJOw6g5d)FKFeuCZFQbYYYBo7Yl5h;
	}
}

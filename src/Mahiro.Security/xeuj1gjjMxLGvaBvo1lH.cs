using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using YXeZWljjF5dxgDfRUq1w;

namespace fDAldojjppXrctUVYOJn;

internal class xeuj1gjjMxLGvaBvo1lH
{
	private enum lgRoGVjjGW5IoKYwH0n8
	{

	}

	internal class PU3WdIjjix0of5G2Cuqp
	{
		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint go8jjnCqotA(void* P_0, uint P_1)
		{
			//IL_0012: Expected I4, but got F8
			uint result = 0u;
			if (BitConverter.IsLittleEndian)
			{
				result = (uint)(int)(*(double*)P_0);
			}
			else
			{
				switch (P_1)
				{
				case 4u:
					result = (uint)(*(short*)P_0 | (*(short*)((byte*)P_0 + 1) << 8) | (((short*)P_0)[1] << 16) | (*(short*)((byte*)P_0 + 3) << 24));
					break;
				case 3u:
					result = (uint)(*(short*)P_0 | (*(short*)((byte*)P_0 + 1) << 8) | (((short*)P_0)[1] << 16));
					break;
				case 2u:
					result = (uint)(*(short*)P_0 | (*(short*)((byte*)P_0 + 1) << 8));
					break;
				case 1u:
					result = (uint)(*(short*)P_0);
					break;
				}
			}
			return result;
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void INGjjzcDFTv(uint P_0, void* P_1, uint P_2)
		{
			//IL_0087: Expected F4, but got I4
			//IL_007a: Expected F4, but got I4
			//IL_0082: Expected F4, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_006c: Expected F4, but got I4
			//IL_0075: Expected F4, but got I4
			//IL_0045: Expected F4, but got I4
			//IL_004d: Expected F4, but got I4
			//IL_0056: Expected F4, but got I4
			//IL_005f: Expected F4, but got I4
			//IL_0025: Expected F4, but got I4
			if (BitConverter.IsLittleEndian)
			{
				switch (P_2)
				{
				case 1u:
					*(float*)P_1 = (int)(byte)P_0;
					break;
				}
				return;
			}
			switch (P_2)
			{
			case 4u:
				*(float*)P_1 = (int)(byte)P_0;
				*(float*)((byte*)P_1 + 1) = (int)(byte)(P_0 >> 8);
				*(float*)((byte*)P_1 + 2) = (int)(byte)(P_0 >> 16);
				*(float*)((byte*)P_1 + 3) = (int)(byte)(P_0 >> 24);
				break;
			case 3u:
				*(float*)P_1 = (int)(byte)P_0;
				*(float*)((byte*)P_1 + 1) = (int)(byte)(P_0 >> 8);
				*(float*)((byte*)P_1 + 2) = (int)(byte)(P_0 >> 16);
				break;
			case 2u:
				*(float*)P_1 = (int)(byte)P_0;
				*(float*)((byte*)P_1 + 1) = (int)(byte)(P_0 >> 8);
				break;
			case 1u:
				*(float*)P_1 = (int)(byte)P_0;
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static bool HUNjZbcBaxN(void* P_0, void* P_1, uint P_2)
		{
			bool flag = true;
			uint num = 0u;
			while (flag && num < P_2)
			{
				flag = *(short*)((byte*)P_0 + num) == *(short*)((byte*)P_1 + num);
				num++;
			}
			return flag;
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static bool Ik1jZXTPoDD(void* P_0, object P_1)
		{
			byte[] bytes = Encoding.ASCII.GetBytes((string)P_1);
			fixed (byte* ptr = bytes)
			{
				return HUNjZbcBaxN(P_0, ptr, (uint)bytes.Length);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void AJfjZfFh84m(void* P_0, byte P_1, uint P_2)
		{
			//IL_0010: Expected F4, but got I4
			for (uint num = 0u; num < P_2; num++)
			{
				*(float*)((byte*)P_0 + num) = (int)P_1;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void TYZjZLwDb7y(void* P_0, void* P_1, uint P_2)
		{
			//IL_0014: Expected F4, but got I4
			for (uint num = 0u; num < P_2; num++)
			{
				*(float*)((byte*)P_0 + num) = *(short*)((byte*)P_1 + num);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void Lv1jZjaLI8R(void* P_0, object P_1)
		{
			byte[] bytes = Encoding.ASCII.GetBytes((string)P_1);
			fixed (byte* ptr = bytes)
			{
				TYZjZLwDb7y(P_0, ptr, (uint)bytes.Length);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void sWWjZZYLZlP(byte* P_0, byte* P_1, uint P_2)
		{
			//IL_000e: Expected F4, but got I4
			byte* ptr = P_0 + P_2;
			while (P_0 < ptr)
			{
				*(float*)P_0 = *(short*)P_1;
				P_0++;
				P_1++;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint WqnjZ9g6miA(object P_0, uint P_1, lgRoGVjjGW5IoKYwH0n8 P_2)
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static uint pvAjZD4av0p(object P_0)
		{
			return WqnjZ9g6miA(P_0, 0u, (lgRoGVjjGW5IoKYwH0n8)2);
		}

		[MethodImpl((MethodImplOptions)8)]
		public static uint xMRjZkZWm1a(object P_0, uint P_1)
		{
			return WqnjZ9g6miA(P_0, P_1, (lgRoGVjjGW5IoKYwH0n8)3);
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint bsjjZVRhyGl(object P_0, uint P_1, object P_2, uint P_3)
		{
			//IL_01a5: Expected F4, but got I4
			//IL_01fa: Expected F4, but got I4
			//IL_005a: Expected F4, but got I4
			//IL_00b4: Expected F4, but got I4
			uint num2 = default(uint);
			byte* ptr = default(byte*);
			byte* ptr3 = default(byte*);
			if (false)
			{
				byte* ptr2;
				uint num = (uint)(ptr - ptr2);
				if ((!BitConverter.IsLittleEndian) ? (*(short*)(ptr2 + 3) != *(short*)(ptr + 3)) : (*(double*)ptr2 != *(double*)ptr))
				{
					if (num <= 63)
					{
						*(float*)ptr3 = (int)(byte)(num << 2);
						ptr3++;
						num2 = (num2 >> 1) | 0x80000000u;
						ptr += 3;
					}
					else if (num <= 16383)
					{
						INGjjzcDFTv((num << 2) | 1, ptr3, 2u);
						ptr3 += 2;
						num2 = (num2 >> 1) | 0x80000000u;
						ptr += 3;
					}
					else
					{
						*(float*)ptr3 = *(short*)ptr;
						ptr3++;
						ptr++;
						num2 >>= 1;
					}
				}
				else
				{
					num2 = (num2 >> 1) | 0x80000000u;
					uint num3;
					for (num3 = 3u; *(short*)(ptr2 + num3) == *(short*)(ptr + num3) && num3 < 2050; num3++)
					{
					}
					ptr += num3;
					if (num3 <= 18 && num <= 1023)
					{
						INGjjzcDFTv((num3 - 3 << 2) | (num << 6) | 2, ptr3, 2u);
						ptr3 += 2;
					}
					else if (num3 <= 34 && num <= 65535)
					{
						INGjjzcDFTv((num3 - 3 << 3) | (num << 8) | 3, ptr3, 3u);
						ptr3 += 3;
					}
					else if (num3 >= 3)
					{
						INGjjzcDFTv((num3 - 3 << 4) | (num << 15) | 7, ptr3, 4u);
						ptr3 += 4;
					}
				}
			}
			else
			{
				*(float*)ptr3 = *(short*)ptr;
				ptr3++;
				ptr++;
				num2 >>= 1;
			}
			byte* ptr4 = default(byte*);
			_ = ptr4 - 2050;
			byte* ptr5 = default(byte*);
			byte* ptr6 = default(byte*);
			while (ptr <= ptr5)
			{
				if ((num2 & 1) == 1)
				{
					INGjjzcDFTv((num2 >> 1) | 0x80000000u, ptr6, 4u);
					ptr6 = ptr3;
					ptr3 += 4;
					num2 = 2147483648u;
				}
				*(float*)ptr3 = *(short*)ptr;
				ptr3++;
				ptr++;
				num2 >>= 1;
			}
			while ((num2 & 1) != 1)
			{
				num2 >>= 1;
			}
			INGjjzcDFTv((num2 >> 1) | 0x80000000u, ptr6, 4u);
			ptr3 += 4;
			uint* ptr7 = default(uint*);
			INGjjzcDFTv(1u, ptr7 + 4, 4u);
			byte* ptr8 = default(byte*);
			INGjjzcDFTv((uint)(ptr3 - ptr8 - 1 + 4), ptr7 + 2, 4u);
			Lv1jZjaLI8R(ptr8 + go8jjnCqotA(ptr7 + 2, 4u) - 4, "QCLZ");
			return default(uint);
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint wn7jZYWxk4d(object P_0, uint P_1, object P_2)
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string[] AZNjj1BQ9MK(object P_0)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Assembly Hg1jj3K6fJw(object P_0, object P_1)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Initxeuj1gjjMxLGvaBvo1lH()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void tZtDll322LP()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type UmT46CjydAk3ndwVpcSw(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object p5ORwCjyKGLeOnCjFmAa(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object ROAE0JjyHLSLn5qfhuE5(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void XlgfGejytKIcZuqOC5Hg(object P_0, long P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long ygHKakjyOlVFZbU3u17l(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object gcdIJBjy5iBLDQ6GoiOg(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object N9TS38jy6W6aCLWwab3t(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ulJyUbjyRkrbaW1gp47t(object P_0, object P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void wUWI5gjyw7jFOD8vF4aX(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object N0g1W7jyeJ4YD3Qc8h9V(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void f4JLpBjyPpDFmrsyxJA3(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object o3igTAjyxnAw68m9jQuY(object P_0, uint P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object htF2RGjyFy7fTtANBc8t(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool pJo5J1jygji0ollXqTHl()
	{
		return (object)null == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object n6HE8qjyljmIkE4PYQoJ()
	{
		return null;
	}
}

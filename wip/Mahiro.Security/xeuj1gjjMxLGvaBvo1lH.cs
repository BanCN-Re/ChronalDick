using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
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
			fixed (byte* ptr = P_1)
			{
				return HUNjZbcBaxN(P_0, ptr, (uint)((global::System.Array)P_1).Length);
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
			fixed (byte* ptr = P_1)
			{
				TYZjZLwDb7y(P_0, ptr, (uint)((global::System.Array)P_1).Length);
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
			//IL_0060: Expected I4, but got F8
			uint result = 0u;
			fixed (byte* ptr = P_0)
			{
				if (Ik1jZXTPoDD(ptr + P_1, "QCLZ"))
				{
					result = (uint)(int)(*(double*)(ptr + P_1 + (nint)P_2 * (nint)4));
				}
			}
			return result;
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
		private static uint bsjjZVRhyGl(object P_0, uint P_1, object P_2, uint P_3)
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint wn7jZYWxk4d(object P_0, uint P_1, object P_2)
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static byte[] XtajZSepP1C(object P_0)
		{
			//IL_000b: Expected O, but got I4
			byte[] array = null;
			_ = 3;
			_ = 1;
			FileStream val = (FileStream)(object)1;
			try
			{
				array = new byte[checked((nint)(object)val)];
				_ = 0;
				_ = array.Length;
				return array;
			}
			finally
			{
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] YXNjZcEQLKi(object P_0)
		{
			return n5DjZ8IUUCD(XtajZSepP1C(P_0));
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] xoHjZ0fK7lL(object P_0)
		{
			return aScjZyMH6RZ(XtajZSepP1C(P_0));
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] n5DjZ8IUUCD(object P_0)
		{
			return BntjZJ3wspx(P_0, 0u, (uint)((global::System.Array)P_0).Length);
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] aScjZyMH6RZ(object P_0)
		{
			return CgdjZQtnHC3(P_0, 0u);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object xt1jZWNOSHq(object P_0)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(16777332);
			_ = "Load ";
			(new global::System.Type[1])[0] = (global::System.Type)typeof(byte[]).TypeHandle;
			_ = null;
			return new object[1] { P_0 };
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] BntjZJ3wspx(object P_0, uint P_1, uint P_2)
		{
			byte[] array = (byte[])(object)new DateTimeOffset[P_2 + 36000];
			uint num = bsjjZVRhyGl(P_0, P_1, array, P_2);
			byte[] array2 = (byte[])(object)new DateTimeOffset[num];
			for (uint num2 = 0u; num2 < num; num2++)
			{
				array2[num2] = (byte)((short[])(object)array)[num2];
			}
			return array2;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] CgdjZQtnHC3(object P_0, uint P_1)
		{
			uint num = xMRjZkZWm1a(P_0, P_1);
			byte[] array = null;
			if (num != 0)
			{
				array = (byte[])(object)new DateTimeOffset[num];
				wn7jZYWxk4d(P_0, P_1, array);
			}
			return array;
		}

		[MethodImpl((MethodImplOptions)8)]
		public PU3WdIjjix0of5G2Cuqp()
		{
		}

		private static void _cctor()
		{
		}
	}

	private static object qvUjjv8GgkI;

	private static object RAUjjEjahdU;

	private static bool Ufhjj2nQ1Q9;

	private static bool FH6jjqFKTGe;

	[MethodImpl((MethodImplOptions)8)]
	private static void g7Ijja2GNLP()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string[] AZNjj1BQ9MK(object P_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		if ((int)RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557495) != 0)
		{
			if (!Ufhjj2nQ1Q9)
			{
				g7Ijja2GNLP();
			}
			return (string[])(Assembly)RAUjjEjahdU;
		}
		return (string[])P_0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Assembly Hg1jj3K6fJw(object P_0, object P_1)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0039->IL0039: Incompatible stack heights: 1 vs 0
		if (!Ufhjj2nQ1Q9)
		{
			g7Ijja2GNLP();
		}
		for (int i = 0; i < ((global::System.Array)qvUjjv8GgkI).Length; i++)
		{
			_ = ((object[])qvUjjv8GgkI)[i];
			if (P_1 != null)
			{
				return (Assembly)RAUjjEjahdU;
			}
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe xeuj1gjjMxLGvaBvo1lH()
	{
		_ = null;
		_ = (delegate*<object, object, Assembly>)(&Hg1jj3K6fJw);
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void tZtDll322LP()
	{
		if (!FH6jjqFKTGe)
		{
			FH6jjqFKTGe = true;
			new xeuj1gjjMxLGvaBvo1lH();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		qvUjjv8GgkI = new object[0];
		RAUjjEjahdU = null;
		Ufhjj2nQ1Q9 = false;
		FH6jjqFKTGe = false;
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
		return ((LFHd1ojfYcRKGDVUDAUb.isi3yyjjHLD2e2CxV4Py)P_0).KR5785vTkC();
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
		return ((LFHd1ojfYcRKGDVUDAUb.isi3yyjjHLD2e2CxV4Py)P_0).DZijjtEJTbX(P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object N9TS38jy6W6aCLWwab3t(object P_0)
	{
		return PU3WdIjjix0of5G2Cuqp.xt1jZWNOSHq(P_0);
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
		return PU3WdIjjix0of5G2Cuqp.CgdjZQtnHC3(P_0, P_1);
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

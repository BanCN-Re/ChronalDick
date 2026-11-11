using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace qZYpv7LrBd6PaxEhteoA;

internal class qiPowfLrI8h0QeonOQ0X
{
	private enum j1auD1Lr67Bo6mn6beBT
	{

	}

	internal class S0iiUqLrRepXhP0XVcfv
	{
		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint p2jLrwxtKlW(void* P_0, uint P_1)
		{
			//IL_0005: Expected O, but got I4
			//IL_0019: Expected O, but got I
			//IL_0012: Expected O, but got F8
			//IL_007c: Expected native int or pointer, but got O
			//IL_007e: Expected O, but got I4
			//IL_006d: Expected native int or pointer, but got O
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Expected O, but got I4
			//IL_0056: Expected native int or pointer, but got O
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Expected O, but got I4
			//IL_0037: Expected native int or pointer, but got O
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got I4
			//IL_0080: Expected I4, but got O
			dynamic obj = 0;
			if (BitConverter.IsLittleEndian)
			{
				obj = *(double*)P_0;
			}
			else
			{
				dynamic obj2 = (object)(global::System.IntPtr)P_0;
				switch (P_1)
				{
				case 4u:
					obj = *(short*)(nint)obj2 | (*(short*)(nint)((int)obj2 + 1) << 8) | (*(short*)(nint)((int)obj2 + 2) << 16) | (*(short*)(nint)((int)obj2 + 3) << 24);
					break;
				case 3u:
					obj = *(short*)(nint)obj2 | (*(short*)(nint)((int)obj2 + 1) << 8) | (*(short*)(nint)((int)obj2 + 2) << 16);
					break;
				case 2u:
					obj = *(short*)(nint)obj2 | (*(short*)(nint)((int)obj2 + 1) << 8);
					break;
				case 1u:
					obj = *(short*)(nint)obj2;
					break;
				}
			}
			return (uint)(int)obj;
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void j92Lre75JpT(uint P_0, void* P_1, uint P_2)
		{
			//IL_0028: Expected O, but got I
			//IL_0087: Expected F4, but got I4
			//IL_0086: Expected native int or pointer, but got O
			//IL_007a: Expected F4, but got I4
			//IL_0079: Expected native int or pointer, but got O
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0082: Expected F4, but got I4
			//IL_0064: Expected F4, but got I4
			//IL_0063: Expected native int or pointer, but got O
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected F4, but got I4
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Expected F4, but got I4
			//IL_0045: Expected F4, but got I4
			//IL_0044: Expected native int or pointer, but got O
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Expected F4, but got I4
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Expected F4, but got I4
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
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
			dynamic obj = (object)(global::System.IntPtr)P_1;
			switch (P_2)
			{
			case 4u:
				*(float*)(nint)obj = (int)(byte)P_0;
				*(float*)(nint)((int)obj + 1) = (int)(byte)(P_0 >> 8);
				*(float*)(nint)((int)obj + 2) = (int)(byte)(P_0 >> 16);
				*(float*)(nint)((int)obj + 3) = (int)(byte)(P_0 >> 24);
				break;
			case 3u:
				*(float*)(nint)obj = (int)(byte)P_0;
				*(float*)(nint)((int)obj + 1) = (int)(byte)(P_0 >> 8);
				*(float*)(nint)((int)obj + 2) = (int)(byte)(P_0 >> 16);
				break;
			case 2u:
				*(float*)(nint)obj = (int)(byte)P_0;
				*(float*)(nint)((int)obj + 1) = (int)(byte)(P_0 >> 8);
				break;
			case 1u:
				*(float*)(nint)obj = (int)(byte)P_0;
				break;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static bool SZALrP23Tlw(void* P_0, void* P_1, uint P_2)
		{
			//IL_0005: Expected O, but got I4
			//IL_0007: Expected O, but got I4
			//IL_002c: Expected I4, but got O
			//IL_0019: Expected O, but got I4
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			dynamic obj = 1;
			dynamic obj2 = 0;
			while (obj != null && (nuint)(nint)obj2 < (nuint)(int)P_2)
			{
				obj = *(short*)((byte*)P_0 + (nuint)obj2) == *(short*)((byte*)P_1 + (nuint)obj2);
				obj2++;
			}
			return (byte)(int)obj != 0;
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static bool sThLrxb8GGI(void* P_0, object P_1)
		{
			//IL_0022: Expected O, but got I
			//IL_003a: Expected I, but got O
			//IL_0030: Expected O, but got I
			object bytes = Encoding.ASCII.GetBytes((string)P_1);
			object obj2;
			dynamic obj = (((obj2 = bytes) != null && ((global::System.Array)obj2).Length != 0) ? ((object)(global::System.IntPtr)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref ((byte[])obj2)[0])) : ((object)0u));
			return SZALrP23Tlw(P_0, (void*)(nint)obj, (uint)((global::System.Array)bytes).Length);
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void f0TLrFoFaFi(void* P_0, byte P_1, uint P_2)
		{
			//IL_0005: Expected O, but got I4
			//IL_0010: Expected F4, but got I4
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			dynamic obj = 0;
			while ((nuint)(nint)obj < (nuint)(int)P_2)
			{
				*(float*)((byte*)P_0 + (nuint)obj) = (int)P_1;
				obj++;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void F2kLrs4xx86(void* P_0, void* P_1, uint P_2)
		{
			//IL_0005: Expected O, but got I4
			//IL_0014: Expected F4, but got I4
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Expected O, but got Unknown
			dynamic obj = 0;
			while ((nuint)(nint)obj < (nuint)(int)P_2)
			{
				*(float*)((byte*)P_0 + (nuint)obj) = *(short*)((byte*)P_1 + (nuint)obj);
				obj++;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void LLmLrTgYkBe(void* P_0, object P_1)
		{
			//IL_0022: Expected O, but got I
			//IL_003a: Expected I, but got O
			//IL_0030: Expected O, but got I
			object bytes = Encoding.ASCII.GetBytes((string)P_1);
			object obj2;
			dynamic obj = (((obj2 = bytes) != null && ((global::System.Array)obj2).Length != 0) ? ((object)(global::System.IntPtr)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref ((byte[])obj2)[0])) : ((object)0u));
			F2kLrs4xx86(P_0, (void*)(nint)obj, (uint)((global::System.Array)bytes).Length);
			obj2 = null;
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static void jXeLrNWwAaQ(byte* P_0, byte* P_1, uint P_2)
		{
			//IL_0005: Expected O, but got I
			//IL_000e: Expected F4, but got I4
			dynamic obj = (object)(global::System.IntPtr)(P_0 + P_2);
			while ((nuint)P_0 < (nuint)(nint)obj)
			{
				*(float*)P_0 = *(short*)P_1;
				P_0++;
				P_1++;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint wtJLrMtcXR9(object P_0, uint P_1, j1auD1Lr67Bo6mn6beBT P_2)
		{
			//IL_0005: Expected O, but got I4
			//IL_0018: Expected O, but got I
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected I, but got Unknown
			//IL_0026: Expected O, but got I
			//IL_0064: Expected I4, but got O
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got F8
			dynamic obj = 0;
			object obj3;
			dynamic obj2 = (((obj3 = P_0) != null && ((global::System.Array)obj3).Length != 0) ? ((object)(global::System.IntPtr)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref ((byte[])obj3)[0])) : ((object)0u));
			if (sThLrxb8GGI((void*)(nint)(obj2 + P_1), "QCLZ"))
			{
				obj = *(double*)(nint)(obj2 + P_1 + (nint)P_2 * (nint)4);
			}
			obj3 = null;
			return (uint)(int)obj;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static uint UOoLrpZvXrc(object P_0)
		{
			return wtJLrMtcXR9(P_0, 0u, (j1auD1Lr67Bo6mn6beBT)2);
		}

		[MethodImpl((MethodImplOptions)8)]
		public static uint v9ALruBlDfS(object P_0, uint P_1)
		{
			return wtJLrMtcXR9(P_0, P_1, (j1auD1Lr67Bo6mn6beBT)3);
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint V6eLraYncI8(object P_0, uint P_1, object P_2, uint P_3)
		{
			//IL_0003: Expected O, but got I4
			//IL_01a3: Expected native int or pointer, but got O
			//IL_01a5: Expected F4, but got I4
			//IL_01a4: Expected native int or pointer, but got O
			//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ab: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b1: Expected O, but got Unknown
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got I4
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Expected O, but got I4
			//IL_0021: Expected native int or pointer, but got O
			//IL_0024: Expected native int or pointer, but got O
			//IL_002c: Expected O, but got I4
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Invalid comparison between Unknown and I4
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Expected O, but got Unknown
			//IL_00da: Expected O, but got I4
			//IL_01f8: Expected native int or pointer, but got O
			//IL_01fa: Expected F4, but got I4
			//IL_01f9: Expected native int or pointer, but got O
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Expected O, but got Unknown
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Expected O, but got Unknown
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected I, but got O
			//IL_01e3: Expected I4, but got Unknown
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ed: Expected O, but got Unknown
			//IL_01f4: Expected O, but got I4
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Invalid comparison between Unknown and I4
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected F4, but got I4
			//IL_0059: Expected native int or pointer, but got O
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Expected O, but got Unknown
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected I, but got O
			//IL_023c: Expected I4, but got Unknown
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0242: Expected O, but got Unknown
			//IL_0249: Unknown result type (might be due to invalid IL or missing references)
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Expected I, but got Unknown
			//IL_0109: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Expected O, but got Unknown
			//IL_00b2: Expected native int or pointer, but got O
			//IL_00b4: Expected F4, but got I4
			//IL_00b3: Expected native int or pointer, but got O
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Expected O, but got Unknown
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0091: Expected I, but got O
			//IL_0091: Expected I4, but got Unknown
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Expected O, but got Unknown
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Expected O, but got Unknown
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_012d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected I, but got O
			//IL_0136: Expected I4, but got Unknown
			//IL_0139: Unknown result type (might be due to invalid IL or missing references)
			//IL_013c: Expected O, but got Unknown
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Expected I, but got O
			//IL_0194: Expected I4, but got Unknown
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected I, but got O
			//IL_016b: Expected I4, but got Unknown
			//IL_016e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0171: Expected O, but got Unknown
			dynamic obj = 0;
			dynamic obj6 = default(object);
			dynamic obj3 = default(object);
			dynamic obj5 = default(object);
			if (obj != null)
			{
				dynamic obj4 = default(object);
				dynamic obj2 = (long)((obj3 - obj4) / 1);
				obj = ((!BitConverter.IsLittleEndian) ? ((object)(*(short*)(nint)((int)obj4 + 3) != *(short*)(nint)((int)obj3 + 3))) : ((object)(*(double*)(nint)obj4 != *(double*)(nint)obj3)));
				if (obj != null)
				{
					if ((nuint)(nint)obj2 <= (nuint)63u)
					{
						*(float*)(nint)obj5 = (int)(byte)(obj2 << 2);
						obj5++;
						obj6 = (obj6 >> 1) | -2147483648;
						obj3 += 3;
					}
					else if ((nuint)(nint)obj2 <= (nuint)16383u)
					{
						j92Lre75JpT((uint)((obj2 << 2) | 1), (void*)(nint)obj5, 2u);
						obj5 += 2;
						obj6 = (obj6 >> 1) | -2147483648;
						obj3 += 3;
					}
					else
					{
						*(float*)(nint)obj5 = *(short*)(nint)obj3;
						obj5++;
						obj3++;
						obj6 >>= 1;
					}
				}
				else
				{
					obj6 = (obj6 >> 1) | -2147483648;
					dynamic obj7 = 3;
					while (*(short*)(nint)(obj4 + (nuint)obj7) == *(short*)(nint)(obj3 + (nuint)obj7) && (nuint)(nint)obj7 < (nuint)2050u)
					{
						obj7++;
					}
					obj3 += (nuint)obj7;
					if ((nuint)(nint)obj7 <= (nuint)18u && (nuint)(nint)obj2 <= (nuint)1023u)
					{
						j92Lre75JpT((uint)(((int)obj7 - 3 << 2) | (obj2 << 6) | 2), (void*)(nint)obj5, 2u);
						obj5 += 2;
					}
					else if ((nuint)(nint)obj7 <= (nuint)34u && (nuint)(nint)obj2 <= (nuint)65535u)
					{
						j92Lre75JpT((uint)(((int)obj7 - 3 << 3) | (obj2 << 8) | 3), (void*)(nint)obj5, 3u);
						obj5 += 3;
					}
					else if ((nuint)(nint)obj7 >= (nuint)3u)
					{
						j92Lre75JpT((uint)(((int)obj7 - 3 << 4) | (obj2 << 15) | 7), (void*)(nint)obj5, 4u);
						obj5 += 4;
					}
				}
			}
			else
			{
				*(float*)(nint)obj5 = *(short*)(nint)obj3;
				obj5++;
				obj3++;
				obj6 >>= 1;
			}
			dynamic obj8 = default(object);
			_ = (int)obj8 - 2050;
			dynamic obj9 = default(object);
			dynamic obj10 = default(object);
			while (obj3 <= obj9)
			{
				if (((int)obj6 & 1) == 1)
				{
					j92Lre75JpT((uint)((obj6 >> 1) | -2147483648), (void*)(nint)obj10, 4u);
					obj10 = obj5;
					obj5 += 4;
					obj6 = -2147483648;
				}
				*(float*)(nint)obj5 = *(short*)(nint)obj3;
				obj5++;
				obj3++;
				obj6 >>= 1;
			}
			while (((int)obj6 & 1) != 1)
			{
				obj6 >>= 1;
			}
			j92Lre75JpT((uint)((obj6 >> 1) | -2147483648), (void*)(nint)obj10, 4u);
			obj5 += 4;
			dynamic obj11 = default(object);
			j92Lre75JpT(1u, (void*)(nuint)(obj11 + (nint)4 * (nint)4), 4u);
			dynamic obj12 = default(object);
			j92Lre75JpT((uint)((long)((obj5 - obj12) / 1) - 1 + 4), (void*)(nuint)(obj11 + (nint)2 * (nint)4), 4u);
			LLmLrTgYkBe((void*)(nint)(obj12 + p2jLrwxtKlW((void*)(nuint)(obj11 + (nint)2 * (nint)4), 4u) - 4), "QCLZ");
			dynamic obj13 = null;
			dynamic obj14 = null;
			return default(uint);
		}

		[MethodImpl((MethodImplOptions)8)]
		private unsafe static uint GGOLr1ljMxj(object P_0, uint P_1, object P_2)
		{
			//IL_0016: Expected O, but got I
			//IL_0024: Expected O, but got I
			//IL_0037: Expected O, but got I
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Expected O, but got Unknown
			//IL_004f: Expected O, but got I4
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_0074: Expected O, but got I4
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008e: Expected O, but got Unknown
			//IL_0045: Expected O, but got I
			//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Expected I, but got Unknown
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Expected I, but got Unknown
			//IL_013b: Expected I, but got O
			//IL_0141: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Expected O, but got Unknown
			//IL_01a2: Expected I, but got O
			//IL_01a4: Expected O, but got I4
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a9: Invalid comparison between Unknown and I4
			//IL_0192: Expected I, but got O
			//IL_0194: Expected O, but got I4
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Expected O, but got Unknown
			//IL_031c: Expected I, but got O
			//IL_031c: Expected I, but got O
			//IL_0324: Unknown result type (might be due to invalid IL or missing references)
			//IL_0327: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Expected O, but got Unknown
			//IL_0332: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Expected O, but got Unknown
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Expected native int or pointer, but got O
			//IL_0164: Expected F4, but got I4
			//IL_0163: Expected native int or pointer, but got O
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Expected O, but got Unknown
			//IL_016d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Expected O, but got Unknown
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Expected O, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Expected I, but got Unknown
			//IL_01d7: Expected I, but got O
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Expected O, but got Unknown
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Expected O, but got Unknown
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_020b: Expected I, but got Unknown
			//IL_020b: Expected I, but got O
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Expected O, but got Unknown
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Expected O, but got Unknown
			//IL_0392: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_022c: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0231: Expected O, but got Unknown
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0239: Unknown result type (might be due to invalid IL or missing references)
			//IL_023c: Expected O, but got Unknown
			//IL_0243: Unknown result type (might be due to invalid IL or missing references)
			//IL_024b: Expected I4, but got O
			//IL_024b: Expected I, but got Unknown
			//IL_024b: Expected I, but got O
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Expected O, but got Unknown
			//IL_0256: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Expected O, but got Unknown
			//IL_0370: Expected native int or pointer, but got O
			//IL_0372: Expected F4, but got I4
			//IL_0371: Expected native int or pointer, but got O
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Expected O, but got Unknown
			//IL_037b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037e: Expected O, but got Unknown
			//IL_0362: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Expected O, but got Unknown
			//IL_036c: Expected O, but got I4
			//IL_02a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0279: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_027e: Expected O, but got Unknown
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Expected I4, but got O
			//IL_028d: Expected I, but got Unknown
			//IL_028d: Expected I, but got O
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0295: Expected O, but got Unknown
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Expected O, but got Unknown
			//IL_02e8: Expected O, but got I4
			//IL_02f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Expected O, but got Unknown
			//IL_02ff: Expected I4, but got O
			//IL_02ff: Expected I4, but got O
			//IL_02ff: Expected I, but got O
			//IL_0304: Unknown result type (might be due to invalid IL or missing references)
			//IL_0307: Expected O, but got Unknown
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_030d: Expected O, but got Unknown
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected O, but got Unknown
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Expected I4, but got O
			//IL_02cd: Expected I, but got Unknown
			//IL_02cd: Expected I, but got O
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d5: Expected O, but got Unknown
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Expected O, but got Unknown
			object obj2;
			dynamic obj = (((obj2 = P_0) != null && ((global::System.Array)obj2).Length != 0) ? ((object)(global::System.IntPtr)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref ((byte[])obj2)[0])) : ((object)0u));
			object obj4;
			dynamic obj3 = (((obj4 = P_2) != null && ((global::System.Array)obj4).Length != 0) ? ((object)(global::System.IntPtr)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref ((byte[])obj4)[0])) : ((object)0u));
			dynamic obj5 = obj + P_1;
			dynamic obj6 = 32;
			dynamic obj7 = obj5 + (nuint)obj6;
			dynamic obj8 = obj3;
			dynamic obj9 = obj5;
			dynamic obj10 = obj3 + p2jLrwxtKlW((void*)(nuint)(obj9 + (nint)3 * (nint)4), 4u);
			dynamic obj11 = 1;
			uint[] array = new uint[16];
			dynamic obj12 = array;
			dynamic obj13 = (int)obj10 - 4;
			if (!sThLrxb8GGI((void*)(nuint)obj9, "QCLZ"))
			{
				return 0u;
			}
			if (p2jLrwxtKlW((void*)(nuint)((int)obj9 + 4), 4u) != 3)
			{
				return 0u;
			}
			if (!sThLrxb8GGI((void*)(nint)(obj5 + p2jLrwxtKlW((void*)(nuint)(obj9 + (nint)2 * (nint)4), 4u) - 4), "QCLZ"))
			{
				return 0u;
			}
			if (p2jLrwxtKlW((void*)(nuint)(obj9 + (nint)4 * (nint)4), 4u) != 1)
			{
				F2kLrs4xx86((void*)(nint)obj3, (void*)(nint)(obj5 + (nuint)obj6), p2jLrwxtKlW((void*)(nuint)(obj9 + (nint)3 * (nint)4), 4u));
				return p2jLrwxtKlW((void*)(nuint)(obj9 + (nint)3 * (nint)4), 4u);
			}
			if (obj8 >= obj13)
			{
				obj7 += 4;
				while (obj8 < obj10)
				{
					*(float*)(nint)obj8 = *(short*)(nint)obj7;
					obj8++;
					obj7++;
				}
				return (uint)((obj8 - obj3) / 1);
			}
			while (true)
			{
				if ((nint)obj11 == 1)
				{
					obj11 = p2jLrwxtKlW((void*)(nint)obj7, 4u);
					obj7 += 4;
				}
				dynamic obj14 = p2jLrwxtKlW((void*)(nint)obj7, 4u);
				if (((int)obj11 & 1) == 1)
				{
					obj11 >>= 1;
					if (((int)obj14 & 3) == 0)
					{
						dynamic obj15 = ((int)obj14 & 0xFF) >> 2;
						jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)(obj8 - (nuint)obj15), 3u);
						obj8 += 3;
						obj7++;
					}
					else if (((int)obj14 & 2) == 0)
					{
						dynamic obj15 = ((int)obj14 & 0xFFFF) >> 2;
						jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)(obj8 - (nuint)obj15), 3u);
						obj8 += 3;
						obj7 += 2;
					}
					else if (((int)obj14 & 1) == 0)
					{
						dynamic obj15 = ((int)obj14 & 0xFFFF) >> 6;
						dynamic obj16 = ((obj14 >> 2) & 0xF) + 3;
						jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)(obj8 - (nuint)obj15), (uint)(int)obj16);
						obj8 += (nuint)obj16;
						obj7 += 2;
					}
					else if (((int)obj14 & 4) == 0)
					{
						dynamic obj15 = ((int)obj14 & 0xFFFFFF) >> 8;
						dynamic obj16 = ((obj14 >> 3) & 0x1F) + 3;
						jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)(obj8 - (nuint)obj15), (uint)(int)obj16);
						obj8 += (nuint)obj16;
						obj7 += 3;
					}
					else if (((int)obj14 & 8) == 0)
					{
						dynamic obj15 = obj14 >> 15;
						dynamic obj16 = ((obj14 >> 4) & 0x7FF) + 3;
						jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)(obj8 - (nuint)obj15), (uint)(int)obj16);
						obj8 += (nuint)obj16;
						obj7 += 4;
					}
					else
					{
						dynamic obj17 = (byte)(obj14 >> 16);
						dynamic obj16 = (obj14 >> 4) & 0xFFF;
						f0TLrFoFaFi((void*)(nint)obj8, (byte)(int)obj17, (uint)(int)obj16);
						obj8 += (nuint)obj16;
						obj7 += 3;
					}
				}
				else
				{
					jXeLrNWwAaQ((byte*)(nint)obj8, (byte*)(nint)obj7, 4u);
					obj8 += ((ushort[])obj12)[(int)obj11 & 0xF];
					obj7 += ((ushort[])obj12)[(int)obj11 & 0xF];
					obj11 >>= (byte)((ushort[])obj12)[(int)obj11 & 0xF] & 0x1F;
					if (obj8 >= obj13)
					{
						break;
					}
				}
			}
			while (obj8 < obj10)
			{
				if ((nint)obj11 == 1)
				{
					obj7 += 4;
					obj11 = -2147483648;
				}
				*(float*)(nint)obj8 = *(short*)(nint)obj7;
				obj8++;
				obj7++;
				obj11 >>= 1;
			}
			return (uint)((obj8 - obj3) / 1);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static byte[] YDCLr3qmDxE(object P_0)
		{
			dynamic obj = null;
			dynamic obj2 = File.Open((string)P_0, (FileMode)3, (FileAccess)1, (FileShare)1);
			try
			{
				obj = new byte[((Stream)obj2).Length];
				((Stream)obj2).Read((byte[])obj, 0, ((global::System.Array)obj).Length);
				return (byte[])obj;
			}
			finally
			{
				((Stream)obj2).Close();
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] g8jLrvH1e7d(object P_0)
		{
			return OOZLr2R8h7v(YDCLr3qmDxE(P_0));
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] VvALrESu5jj(object P_0)
		{
			return PEhLrqJalkY(YDCLr3qmDxE(P_0));
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] OOZLr2R8h7v(object P_0)
		{
			return UcKLriJdDdg(P_0, 0u, Convert.ToUInt32(((global::System.Array)P_0).Length));
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] PEhLrqJalkY(object P_0)
		{
			return wrbLrniS6AZ(P_0, 0u);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object JIsLrG92x90(object P_0)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return ((MethodBase)typeof(global::System.Reflection.Assembly).GetMethod("Load ".Trim(), new global::System.Type[1] { typeof(byte[]) })).Invoke((object)null, new object[1] { P_0 });
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] UcKLriJdDdg(object P_0, uint P_1, uint P_2)
		{
			//IL_001a: Expected O, but got I4
			//IL_0023: Expected O, but got I4
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Expected O, but got Unknown
			dynamic obj = new byte[P_2 + 36000];
			dynamic obj2 = V6eLraYncI8(P_0, P_1, obj, P_2);
			dynamic obj3 = new byte[obj2];
			for (int obj4 = 0; obj4 < (int)obj2; obj4++)
			{
				((sbyte[])obj3)[obj4] = (sbyte)((short[])obj)[obj4];
			}
			return (byte[])obj3;
		}

		[MethodImpl((MethodImplOptions)8)]
		public static byte[] wrbLrniS6AZ(object P_0, uint P_1)
		{
			//IL_000b: Expected O, but got I4
			dynamic obj = v9ALruBlDfS(P_0, P_1);
			dynamic obj2 = null;
			if (obj != null)
			{
				obj2 = new byte[obj];
				GGOLr1ljMxj(P_0, P_1, obj2);
			}
			return (byte[])obj2;
		}

		[MethodImpl((MethodImplOptions)8)]
		public S0iiUqLrRepXhP0XVcfv()
		{
		}

		private static void _cctor()
		{
		}
	}

	private static object f3DLrHKj1l9;

	private static object yaBLrt8NNaS;

	private static bool GtnLrOclKs3;

	private static bool fFYLr5jHwjE;

	[MethodImpl((MethodImplOptions)8)]
	private static void eWaLrlH4IJy()
	{
		//IL_2950: Unknown result type (might be due to invalid IL or missing references)
		//IL_2957: Expected O, but got Unknown
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bd: Expected O, but got Unknown
		//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13bf: Expected O, but got Unknown
		//IL_0c81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8b: Expected O, but got Unknown
		int num = 334;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num24 = default(int);
		byte[] array4 = default(byte[]);
		int num15 = default(int);
		int num23 = default(int);
		uint num34 = default(uint);
		uint num35 = default(uint);
		int num36 = default(int);
		int num14 = default(int);
		int num26 = default(int);
		int num13 = default(int);
		int num17 = default(int);
		uint num16 = default(uint);
		byte[] array3 = default(byte[]);
		uint num20 = default(uint);
		uint num22 = default(uint);
		g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y yUec0jLr8udpaMfJhw8y = default(g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y);
		int num18 = default(int);
		int num25 = default(int);
		BrotliStream val2 = default(BrotliStream);
		byte[] array7 = default(byte[]);
		byte[] array5 = default(byte[]);
		MemoryStream val = default(MemoryStream);
		int num31 = default(int);
		int num33 = default(int);
		uint num21 = default(uint);
		byte[] array6 = default(byte[]);
		byte[] array8 = default(byte[]);
		int num32 = default(int);
		int num19 = default(int);
		int num28 = default(int);
		int num30 = default(int);
		uint num5 = default(uint);
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
						if (num2 != 405)
						{
							if (num2 == 1386)
							{
								goto end_IL_0010;
							}
							goto case 320;
						}
						array2[4] = 132;
						num3 = 97;
						continue;
					case 157:
						array[9] = 98;
						num3 = 370;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 136;
						}
						continue;
					case 178:
						num24 = 216 - 72;
						num3 = 75;
						continue;
					case 47:
						array4[num15 + num23] = (byte)((num34 & num35) >> num36);
						num3 = 344;
						continue;
					case 355:
						array2[1] = (byte)num14;
						num3 = 245;
						continue;
					case 161:
						array2[6] = 58;
						num3 = 398;
						continue;
					case 186:
						array[15] = 133;
						num3 = 70;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 383;
						}
						continue;
					case 86:
						num14 = 119 + 119;
						num3 = 32;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 351;
						}
						continue;
					case 245:
						array2[1] = 177;
						num3 = 85;
						continue;
					case 272:
					case 292:
						if (num23 >= num26)
						{
							num3 = 350;
							continue;
						}
						goto case 287;
					case 269:
						array2[7] = 67;
						num3 = 212;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 175;
						}
						continue;
					case 18:
						num13 = 217 - 72;
						num3 = 381;
						continue;
					case 103:
						array[10] = (byte)num13;
						num3 = 123;
						continue;
					case 273:
						num17 = 30 + 110;
						num3 = 273;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 177;
						}
						continue;
					case 160:
						array4[num15 + 1] = (byte)((num16 & 0xFF00) >> 8);
						num3 = 141;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 364;
						}
						continue;
					case 277:
						array2[0] = 176;
						num3 = 391;
						continue;
					case 265:
						array2[23] = 122;
						num3 = 230;
						continue;
					case 386:
						array[5] = 25;
						num3 = 91;
						continue;
					case 238:
						if (num26 > 0)
						{
							num = 41;
							break;
						}
						goto case 357;
					case 134:
						num24 = 43 + 111;
						num3 = 53;
						continue;
					case 165:
						array3 = new byte[0];
						num3 = 312;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 113;
						}
						continue;
					case 4:
						num14 = 121 + 11;
						num3 = 138;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 11;
						}
						continue;
					case 288:
						array2[10] = 34;
						num3 = 294;
						continue;
					case 121:
						array2[17] = 59;
						num3 = 350;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 297;
						}
						continue;
					case 247:
						array2[11] = 129;
						num3 = 253;
						continue;
					case 314:
						array2[15] = 128;
						num3 = 226;
						continue;
					case 172:
						array[15] = (byte)num13;
						num3 = 364;
						continue;
					case 100:
						array2[27] = 62;
						num3 = 263;
						continue;
					case 187:
						num17 = 139 + 14;
						num3 = 95;
						continue;
					case 71:
						num17 = 198 - 66;
						num3 = 74;
						continue;
					case 52:
						num14 = 154 + 41;
						num3 = 345;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 81;
						}
						continue;
					case 261:
						array[13] = (byte)num24;
						num3 = 67;
						continue;
					case 105:
						array2[6] = (byte)num14;
						num3 = 161;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 376;
						}
						continue;
					case 137:
						array2[15] = (byte)num14;
						num3 = 390;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 314;
						}
						continue;
					case 60:
						num13 = 149 - 33;
						num3 = 362;
						continue;
					case 5:
						array[11] = 15;
						num3 = 219;
						continue;
					case 111:
						array[0] = (byte)num24;
						num3 = 60;
						continue;
					case 199:
						array2[28] = 118;
						num3 = 21;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 162;
						}
						continue;
					case 246:
						array[14] = 135;
						num = 16;
						break;
					case 357:
						num16 = num5 ^ num20;
						num3 = 147;
						continue;
					case 215:
						num22 = (uint)num15;
						num3 = 251;
						continue;
					case 26:
						return;
					case 321:
						array2[26] = 155;
						num3 = 277;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 14;
						}
						continue;
					case 144:
						num17 = 60 + 95;
						num3 = 309;
						continue;
					case 375:
						num14 = 144 + 38;
						num3 = 6;
						continue;
					case 109:
						array[6] = 138;
						num3 = 322;
						continue;
					case 337:
						num14 = 133 - 44;
						num3 = 368;
						continue;
					case 164:
						num17 = 32 + 60;
						num3 = 378;
						continue;
					case 367:
						array2[8] = 154;
						num3 = 343;
						continue;
					case 363:
						array2[27] = (byte)num17;
						num3 = 150;
						continue;
					case 35:
					case 114:
					case 182:
						f3DLrHKj1l9 = eraq2hLK9IooyDfd0HAO((object)(Assembly)yaBLrt8NNaS);
						num3 = 59;
						continue;
					case 59:
						GtnLrOclKs3 = true;
						num3 = 26;
						continue;
					case 228:
						array2[4] = 165;
						num3 = 187;
						continue;
					case 92:
						array2[25] = (byte)num17;
						num3 = 222;
						continue;
					case 65:
						num17 = 157 - 52;
						num3 = 92;
						continue;
					case 377:
						num24 = 123 + 29;
						num3 = 261;
						continue;
					case 87:
						num13 = 181 - 60;
						num3 = 363;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 382;
						}
						continue;
					case 359:
						array2[14] = 55;
						num3 = 201;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 320;
						}
						continue;
					case 224:
						num14 = 29 + 14;
						num3 = 397;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 1;
						}
						continue;
					case 271:
						num17 = 125 - 41;
						num3 = 380;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 231;
						}
						continue;
					case 397:
						GOkx37LdiYQVkZETuOrc(d8PmLqLdGcFtpnlqwTvX(yUec0jLr8udpaMfJhw8y), 0L);
						num3 = 17;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 165;
						}
						continue;
					case 230:
						array2[23] = 206;
						num3 = 227;
						continue;
					case 17:
						array[4] = (byte)num24;
						num3 = 90;
						continue;
					case 88:
						array2[22] = 57;
						num3 = 4;
						continue;
					case 94:
						num14 = 110 + 92;
						num3 = 347;
						continue;
					case 95:
						array2[4] = (byte)num17;
						num3 = 220;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 182;
						}
						continue;
					case 179:
						array2[10] = (byte)num17;
						num3 = 362;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 288;
						}
						continue;
					case 346:
						num17 = 141 - 47;
						num3 = 79;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 140;
						}
						continue;
					case 38:
						num13 = 53 + 71;
						num3 = 33;
						continue;
					case 206:
						num14 = 4 + 63;
						num3 = 213;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 22;
						}
						continue;
					case 53:
						array[5] = (byte)num24;
						num3 = 365;
						continue;
					case 9:
						array[1] = 127;
						num3 = 22;
						continue;
					case 364:
						array[15] = 165;
						num3 = 278;
						continue;
					case 276:
						num14 = 234 - 78;
						num3 = 49;
						continue;
					case 260:
						array2[23] = 56;
						num3 = 282;
						continue;
					case 211:
						array3 = array4;
						num3 = 313;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 233;
						}
						continue;
					case 89:
						num17 = 246 - 82;
						num = 140;
						break;
					case 345:
						array2[2] = (byte)num14;
						num3 = 63;
						continue;
					case 29:
						array2[24] = 116;
						num3 = 404;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 116;
						}
						continue;
					case 334:
						if (GtnLrOclKs3)
						{
							return;
						}
						num3 = 333;
						continue;
					case 307:
						num14 = 142 - 47;
						num3 = 371;
						continue;
					case 188:
						array[9] = 112;
						num3 = 236;
						continue;
					case 380:
						array[2] = 124;
						num3 = 87;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 85;
						}
						continue;
					case 43:
						array2[22] = 38;
						num3 = 146;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 254;
						}
						continue;
					case 167:
						array2[0] = (byte)num17;
						num3 = 310;
						continue;
					case 351:
						array[11] = (byte)num24;
						num3 = 38;
						continue;
					case 231:
						array2[7] = (byte)num17;
						num3 = 340;
						continue;
					case 132:
						num14 = 39 + 13;
						num3 = 48;
						continue;
					case 387:
						array2[29] = 206;
						num3 = 389;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 96;
						}
						continue;
					case 209:
						array2[21] = (byte)num17;
						num3 = 163;
						continue;
					case 329:
						array2[16] = 94;
						num3 = 145;
						continue;
					case 93:
						array2[18] = (byte)num14;
						num3 = 113;
						continue;
					case 388:
						array2[20] = 146;
						num3 = 346;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 366;
						}
						continue;
					case 378:
						array2[16] = (byte)num17;
						num = 329;
						break;
					case 295:
						num20 <<= 8;
						num3 = 254;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 45;
						}
						continue;
					case 3:
						array[6] = (byte)num13;
						num3 = 37;
						continue;
					case 290:
						array2[16] = (byte)num14;
						num3 = 164;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 391;
						}
						continue;
					case 62:
						num18++;
						num3 = 335;
						continue;
					case 23:
						array[12] = 141;
						num3 = 298;
						continue;
					case 362:
						array[0] = (byte)num13;
						num3 = 27;
						continue;
					case 0:
						array2[14] = (byte)num14;
						num3 = 129;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 311;
						}
						continue;
					case 328:
						array[11] = 72;
						num3 = 18;
						continue;
					case 394:
						num13 = 161 - 53;
						num3 = 2;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 172;
						}
						continue;
					case 34:
						array2[31] = (byte)num17;
						num3 = 277;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 169;
						}
						continue;
					case 41:
						num34 = num5 ^ num20;
						num3 = 2;
						continue;
					case 148:
						num25++;
						num3 = 376;
						continue;
					case 282:
						num17 = 232 - 77;
						num3 = 373;
						continue;
					case 73:
						val2 = new BrotliStream((Stream)new MemoryStream(array3), (CompressionMode)0);
						num = 15;
						break;
					case 168:
						array2[27] = (byte)num14;
						num3 = 194;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 100;
						}
						continue;
					case 136:
						num24 = 162 - 54;
						num3 = 183;
						continue;
					case 244:
						array = new byte[16];
						num3 = 279;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 104;
						}
						continue;
					case 373:
						array2[23] = (byte)num17;
						num3 = 265;
						continue;
					case 279:
						num13 = 55 + 124;
						num3 = 392;
						continue;
					case 147:
						array4[num15] = (byte)(num16 & 0xFF);
						num3 = 160;
						continue;
					case 204:
						num36 += 8;
						num3 = 47;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 63;
						}
						continue;
					case 49:
						array2[13] = (byte)num14;
						num = 171;
						break;
					case 138:
						array2[22] = (byte)num14;
						num3 = 54;
						continue;
					case 31:
						array2[18] = 108;
						num3 = 77;
						continue;
					case 8:
						array[11] = (byte)num24;
						num3 = 328;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 70;
						}
						continue;
					case 319:
						num17 = 160 - 53;
						num3 = 385;
						continue;
					case 222:
						array2[25] = 213;
						num = 129;
						break;
					case 46:
						array2[26] = 151;
						num = 132;
						break;
					case 106:
						num14 = 58 + 66;
						num3 = 317;
						continue;
					case 264:
						num35 = 255u;
						num3 = 115;
						continue;
					case 30:
						num17 = 90 + 1;
						num3 = 209;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 179;
						}
						continue;
					case 63:
						array2[3] = 115;
						num3 = 206;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 5;
						}
						continue;
					case 300:
						array2[29] = 107;
						num3 = 196;
						continue;
					case 293:
						num14 = 73 + 110;
						num3 = 82;
						continue;
					case 183:
						array[9] = (byte)num24;
						num3 = 124;
						continue;
					case 286:
						num35 <<= 8;
						num3 = 204;
						continue;
					case 312:
						array7 = (byte[])o0SFWjLdziqbUmRgD8Xe(yUec0jLr8udpaMfJhw8y, (int)E5JnRcLdncLOEEb5hLPP(d8PmLqLdGcFtpnlqwTvX(yUec0jLr8udpaMfJhw8y)));
						num3 = 28;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 242;
						}
						continue;
					case 193:
						num14 = 166 - 55;
						num = 181;
						break;
					case 371:
						array2[0] = (byte)num14;
						num3 = 277;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 109;
						}
						continue;
					case 171:
						array2[13] = 107;
						num3 = 316;
						continue;
					case 150:
						num17 = 60 + 31;
						num = 194;
						break;
					case 84:
						num24 = 236 - 78;
						num = 158;
						break;
					case 77:
						num17 = 15 + 73;
						num3 = 216;
						continue;
					case 115:
						num36 = 0;
						num3 = 332;
						continue;
					case 42:
						array[3] = (byte)num24;
						num3 = 303;
						continue;
					case 166:
						num25 = 0;
						num3 = 198;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 44;
						}
						continue;
					case 385:
						array2[7] = (byte)num17;
						num3 = 269;
						continue;
					case 318:
						array2[11] = (byte)num14;
						num3 = 120;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 66;
						}
						continue;
					case 243:
						array2[13] = 87;
						num3 = 152;
						continue;
					case 229:
						array5 = array2;
						num3 = 334;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 244;
						}
						continue;
					case 14:
						num14 = 81 + 106;
						num3 = 168;
						continue;
					case 124:
						array[9] = 95;
						num3 = 25;
						continue;
					case 301:
						num24 = 141 + 53;
						num = 128;
						break;
					case 90:
						array[4] = 141;
						num3 = 389;
						continue;
					case 173:
						array2[20] = 108;
						num3 = 388;
						continue;
					case 232:
						array[11] = (byte)num24;
						num3 = 302;
						continue;
					case 180:
						array2[8] = 121;
						num3 = 367;
						continue;
					case 249:
						num13 = 26 + 95;
						num3 = 59;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 390;
						}
						continue;
					case 191:
						array[2] = 180;
						num3 = 126;
						continue;
					case 255:
						array2[17] = 121;
						num3 = 121;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 128;
						}
						continue;
					case 306:
					case 335:
						if (num18 >= num26)
						{
							num3 = 202;
							continue;
						}
						goto case 192;
					case 343:
						array2[9] = 110;
						num3 = 217;
						continue;
					case 333:
						yUec0jLr8udpaMfJhw8y = (g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y)new g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y((Stream)OwgbFWLdqoWyXqGexqw9(Fvg8GsLd2vv0NPvbtHN1(typeof(g9MiPrL41bvmHLMo2Exb).TypeHandle).Assembly, "d9p3GGL4PrEmO74tkLnk.jfhtRuL4xLB3LUHM1DIr"));
						num3 = 397;
						continue;
					case 241:
						yaBLrt8NNaS = E70yM3LKbIHoGmnaDphv(VGJHOALKLXiciYM0Itv9(val));
						num3 = 102;
						continue;
					case 153:
					{
						int num37 = num31 % num33;
						num15 = num31 * 4;
						num22 = (uint)(num37 * 4);
						num3 = 296;
						continue;
					}
					case 251:
						num5 += num21;
						num = 361;
						break;
					case 127:
						array2[19] = (byte)num17;
						num3 = 379;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 392;
						}
						continue;
					case 207:
						num24 = 90 + 23;
						num3 = 111;
						continue;
					case 327:
						array2[11] = 216;
						num = 61;
						break;
					case 256:
						array4 = new byte[array6.Length];
						num3 = 289;
						continue;
					case 370:
						num24 = 31 + 8;
						num3 = 137;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 42;
						}
						continue;
					case 135:
						num14 = 225 - 75;
						num3 = 137;
						continue;
					case 33:
						array[11] = (byte)num13;
						num3 = 5;
						continue;
					case 27:
						array[1] = 97;
						num3 = 358;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 150;
						}
						continue;
					case 315:
						num14 = 22 + 116;
						num3 = 51;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 180;
						}
						continue;
					case 169:
						array2[31] = 181;
						num3 = 55;
						continue;
					case 242:
						array2 = new byte[32];
						num3 = 349;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 97;
						}
						continue;
					case 342:
						array2[0] = (byte)num14;
						num3 = 308;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 140;
						}
						continue;
					case 66:
						array5[num25] ^= array8[num25];
						num = 148;
						break;
					case 83:
						array2[3] = 144;
						num3 = 76;
						continue;
					case 368:
						array2[12] = (byte)num14;
						num3 = 237;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 21;
						}
						continue;
					case 308:
						array2[1] = 117;
						num3 = 283;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 366;
						}
						continue;
					case 323:
						array[15] = 80;
						num3 = 251;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 186;
						}
						continue;
					case 223:
						num32 = array6.Length / 4;
						num3 = 256;
						continue;
					case 208:
						array2[30] = (byte)num17;
						num3 = 10;
						continue;
					case 10:
						array2[30] = 118;
						num = 89;
						break;
					case 40:
						array[4] = 58;
						num3 = 324;
						continue;
					case 354:
						array2[4] = (byte)num14;
						num3 = 228;
						continue;
					case 184:
						if (num26 > 0)
						{
							num3 = 21;
							continue;
						}
						goto case 143;
					case 141:
						array4[num15 + 2] = (byte)((num16 & 0xFF0000) >> 16);
						num3 = 189;
						continue;
					case 332:
						if (num31 == num32 - 1)
						{
							num3 = 233;
							continue;
						}
						goto case 215;
					case 237:
						array2[12] = 97;
						num3 = 71;
						continue;
					case 36:
						num17 = 208 - 69;
						num3 = 34;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 117;
						}
						continue;
					case 1:
						array2[12] = (byte)num14;
						num = 81;
						break;
					case 72:
						array2[24] = (byte)num17;
						num3 = 144;
						continue;
					case 118:
						num17 = 57 + 73;
						num3 = 98;
						continue;
					case 268:
						num14 = 206 + 6;
						num = 93;
						break;
					case 259:
						array2[31] = (byte)num17;
						num3 = 106;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 350;
						}
						continue;
					case 195:
						array[2] = 144;
						num3 = 380;
						continue;
					case 316:
						array2[14] = 121;
						num3 = 240;
						continue;
					case 22:
						array[2] = 131;
						num3 = 195;
						continue;
					case 214:
						array[8] = 185;
						num3 = 188;
						continue;
					case 129:
						array2[26] = 166;
						num3 = 236;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 46;
						}
						continue;
					case 262:
						array2[19] = (byte)num17;
						num3 = 28;
						continue;
					case 311:
						array2[15] = 149;
						num3 = 94;
						continue;
					case 382:
						array[2] = (byte)num13;
						num3 = 191;
						continue;
					case 56:
						num14 = 112 + 68;
						num3 = 290;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 249;
						}
						continue;
					case 107:
						array[3] = 243;
						num3 = 58;
						continue;
					case 258:
						num17 = 13 + 54;
						num3 = 393;
						continue;
					case 280:
						array2[5] = 88;
						num3 = 193;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 281;
						}
						continue;
					case 379:
						array2[19] = 78;
						num3 = 173;
						continue;
					case 16:
						array[14] = 171;
						num3 = 323;
						continue;
					case 139:
						array2[8] = (byte)num17;
						num3 = 180;
						continue;
					case 21:
						num32++;
						num3 = 143;
						continue;
					case 28:
						array2[19] = 125;
						num3 = 156;
						continue;
					case 7:
						num13 = 41 - 24;
						num3 = 151;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 340;
						}
						continue;
					case 198:
						num13 = 190 - 83;
						num3 = 80;
						continue;
					case 75:
						array[14] = (byte)num24;
						num3 = 219;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 353;
						}
						continue;
					case 294:
						array2[10] = 16;
						num3 = 396;
						continue;
					case 113:
						array2[19] = 134;
						num3 = 331;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 360;
						}
						continue;
					case 45:
						num20 |= array6[array6.Length - (1 + num18)];
						num3 = 62;
						continue;
					case 303:
						num13 = 199 - 66;
						num3 = 291;
						continue;
					case 284:
						num14 = 219 - 73;
						num3 = 142;
						continue;
					case 122:
						array[5] = (byte)num13;
						num3 = 73;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 134;
						}
						continue;
					case 51:
						array2[30] = (byte)num14;
						num3 = 36;
						continue;
					case 322:
						num13 = 218 - 72;
						num3 = 170;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 3;
						}
						continue;
					case 24:
						array[12] = (byte)num13;
						num3 = 279;
						continue;
					case 263:
						num17 = 137 - 124;
						num = 363;
						break;
					case 69:
						array[8] = (byte)num13;
						num3 = 57;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 391;
						}
						continue;
					case 391:
						num17 = 49 + 85;
						num3 = 167;
						continue;
					case 149:
						num24 = 177 - 59;
						num3 = 299;
						continue;
					case 257:
						num17 = 53 + 81;
						num3 = 338;
						continue;
					case 19:
						array2[17] = (byte)num17;
						num3 = 52;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 31;
						}
						continue;
					case 348:
						array[3] = (byte)num13;
						num3 = 382;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 370;
						}
						continue;
					case 194:
						array2[28] = (byte)num17;
						num3 = 199;
						continue;
					case 338:
						array2[9] = (byte)num17;
						num3 = 30;
						continue;
					case 175:
						num17 = 218 - 72;
						num3 = 139;
						continue;
					case 289:
						num33 = array5.Length / 4;
						num3 = 285;
						continue;
					case 254:
						array2[23] = 86;
						num = 260;
						break;
					case 125:
						num24 = 223 - 74;
						num3 = 270;
						continue;
					case 91:
						array[5] = 132;
						num = 7;
						break;
					case 250:
						array[6] = (byte)num24;
						num3 = 339;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 59;
						}
						continue;
					case 70:
						array[15] = 142;
						num3 = 394;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 302;
						}
						continue;
					case 68:
						array[9] = (byte)num13;
						num3 = 157;
						continue;
					case 104:
						array[0] = 217;
						num3 = 203;
						continue;
					case 389:
						num13 = 228 - 76;
						num3 = 122;
						continue;
					case 98:
						array2[18] = (byte)num17;
						num3 = 267;
						continue;
					case 79:
						array2[20] = (byte)num17;
						num3 = 395;
						continue;
					case 299:
						array[12] = (byte)num24;
						num3 = 58;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 23;
						}
						continue;
					case 80:
						array[13] = (byte)num13;
						num3 = 146;
						continue;
					case 55:
						num17 = 140 - 46;
						num3 = 259;
						continue;
					case 25:
						array[10] = 218;
						num3 = 155;
						continue;
					case 361:
						num20 = (uint)((array6[num22 + 3] << 24) | (array6[num22 + 2] << 16) | (array6[num22 + 1] << 8) | array6[num22]);
						num3 = 235;
						continue;
					case 365:
						array[5] = 154;
						num3 = 386;
						continue;
					case 57:
						array[8] = 87;
						num3 = 214;
						continue;
					case 50:
						array[10] = (byte)num13;
						num3 = 185;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 145;
						}
						continue;
					case 58:
						num24 = 82 + 120;
						num3 = 239;
						continue;
					case 131:
						num14 = 43 + 105;
						num3 = 105;
						continue;
					case 369:
						array2[20] = (byte)num17;
						num3 = 86;
						continue;
					case 96:
						num17 = 213 - 71;
						num3 = 208;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 29;
						}
						continue;
					case 392:
						array[12] = (byte)num13;
						num3 = 341;
						continue;
					case 158:
						array[1] = (byte)num24;
						num3 = 9;
						continue;
					case 374:
						num31 = 0;
						num = 275;
						break;
					case 344:
						num23++;
						num3 = 292;
						continue;
					case 309:
						array2[25] = (byte)num17;
						num3 = 65;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 25;
						}
						continue;
					case 117:
						array2[6] = 56;
						num3 = 131;
						continue;
					case 126:
						num13 = 111 + 116;
						num3 = 278;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 348;
						}
						continue;
					case 101:
						array[7] = (byte)num24;
						num3 = 125;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 125;
						}
						continue;
					case 190:
						array2[2] = (byte)num17;
						num3 = 369;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 326;
						}
						continue;
					case 108:
						array2[2] = (byte)num14;
						num3 = 52;
						continue;
					case 313:
						if (num19 == 0)
						{
							num3 = 212;
							if (LQG1BYLdENGEbki4xS1K() != null)
							{
								num3 = 325;
							}
							continue;
						}
						goto case 110;
					case 143:
						num22 = 0u;
						num3 = 374;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 292;
						}
						continue;
					case 120:
						array2[11] = 163;
						num3 = 327;
						continue;
					case 213:
						array2[3] = (byte)num14;
						num3 = 83;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 150;
						}
						continue;
					case 339:
						array[7] = 95;
						num3 = 387;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 248;
						}
						continue;
					case 253:
						num14 = 50 + 80;
						num3 = 318;
						continue;
					case 239:
						array[4] = (byte)num24;
						num3 = 40;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 17;
						}
						continue;
					case 356:
						num5 += num21;
						num3 = 330;
						continue;
					case 372:
						num24 = 124 + 9;
						num = 101;
						break;
					case 12:
						num17 = 165 - 55;
						num3 = 205;
						continue;
					case 37:
						num24 = 176 - 103;
						num3 = 124;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 250;
						}
						continue;
					case 349:
						array2[0] = 239;
						num3 = 307;
						continue;
					case 54:
						array2[22] = 107;
						num = 43;
						break;
					case 142:
						array2[29] = (byte)num14;
						num3 = 387;
						continue;
					case 196:
						array2[29] = 156;
						num3 = 197;
						continue;
					case 181:
						array2[5] = (byte)num14;
						num3 = 359;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 273;
						}
						continue;
					case 152:
						num17 = 169 - 56;
						num3 = 210;
						continue;
					case 278:
						array8 = array;
						num = 234;
						break;
					case 133:
						if (num31 == num32 - 1)
						{
							num = 238;
							break;
						}
						goto case 357;
					case 270:
						array[7] = (byte)num24;
						num3 = 301;
						continue;
					case 283:
						num14 = 115 + 79;
						num3 = 355;
						continue;
					case 20:
						val = new MemoryStream();
						num = 73;
						break;
					case 252:
					case 350:
						num31++;
						num3 = 154;
						continue;
					case 381:
						array[12] = (byte)num13;
						num3 = 149;
						continue;
					case 330:
						num18 = 0;
						num3 = 306;
						continue;
					case 266:
						array2[29] = (byte)num14;
						num3 = 284;
						continue;
					case 140:
						array2[30] = (byte)num17;
						num3 = 315;
						continue;
					case 336:
						array2[14] = 90;
						num3 = 106;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 304;
						}
						continue;
					case 305:
						array[1] = 100;
						num3 = 84;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 51;
						}
						continue;
					case 340:
						array2[7] = 132;
						num3 = 264;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 258;
						}
						continue;
					case 281:
						array[13] = (byte)num24;
						num = 377;
						break;
					case 6:
						array2[21] = (byte)num14;
						num3 = 309;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 88;
						}
						continue;
					case 177:
						array2[5] = (byte)num17;
						num3 = 288;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 117;
						}
						continue;
					case 210:
						array2[13] = (byte)num17;
						num3 = 293;
						continue;
					case 162:
						num14 = 223 - 123;
						num3 = 218;
						continue;
					case 74:
						array2[13] = (byte)num17;
						num3 = 353;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 243;
						}
						continue;
					case 341:
						num24 = 37 + 61;
						num3 = 281;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 94;
						}
						continue;
					case 205:
						array2[18] = (byte)num17;
						num = 268;
						break;
					case 130:
						array2[21] = (byte)num14;
						num3 = 375;
						continue;
					case 298:
						num13 = 185 - 61;
						num3 = 77;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 24;
						}
						continue;
					case 163:
						num14 = 148 - 49;
						num3 = 130;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 304;
						}
						continue;
					case 216:
						array2[18] = (byte)num17;
						num3 = 118;
						continue;
					case 85:
						num17 = 96 + 28;
						num3 = 190;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 255;
						}
						continue;
					case 358:
						array[1] = 98;
						num3 = 206;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 305;
						}
						continue;
					case 347:
						array2[15] = (byte)num14;
						num3 = 135;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 249;
						}
						continue;
					case 48:
						array2[26] = (byte)num14;
						num3 = 321;
						continue;
					case 32:
						array2[21] = (byte)num14;
						num3 = 119;
						continue;
					case 81:
						num14 = 143 - 47;
						num3 = 361;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 384;
						}
						continue;
					case 128:
						array[7] = (byte)num24;
						num3 = 159;
						continue;
					case 398:
						array2[6] = 130;
						num3 = 13;
						continue;
					case 287:
						if (num23 > 0)
						{
							num3 = 286;
							continue;
						}
						goto case 47;
					case 219:
						num24 = 151 - 50;
						num3 = 8;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 399;
						}
						continue;
					case 227:
						array2[24] = 143;
						num3 = 29;
						continue;
					case 233:
						if (num26 > 0)
						{
							num3 = 274;
							continue;
						}
						goto case 215;
					case 154:
					case 275:
						if (num31 >= num32)
						{
							num3 = 211;
							if (!tXRmqxLdvFcKMf2eSh38())
							{
								num3 = 109;
							}
							continue;
						}
						goto case 153;
					case 218:
						array2[28] = (byte)num14;
						num3 = 300;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 17;
						}
						continue;
					case 159:
						num13 = 199 - 66;
						num3 = 69;
						continue;
					case 99:
						array[14] = 165;
						num = 246;
						break;
					case 324:
						num24 = 107 + 12;
						num3 = 17;
						continue;
					case 119:
						num17 = 250 - 83;
						num3 = 209;
						continue;
					case 383:
						array[15] = 156;
						num3 = 235;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 70;
						}
						continue;
					case 320:
						num14 = 181 + 56;
						num3 = 0;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 143;
						}
						continue;
					case 15:
						try
						{
							Psy3SDLKXddtmXLeeVqF(val2, val);
							int num27 = 0;
							if (LQG1BYLdENGEbki4xS1K() != null)
							{
								num27 = 6;
							}
							while (true)
							{
								switch (num27)
								{
								default:
									if (num28 == 988)
									{
										num27 = num28;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							int num29;
							if (val2 == null)
							{
								num29 = 5;
								if (LQG1BYLdENGEbki4xS1K() == null)
								{
									num29 = 0;
								}
								goto IL_2eea;
							}
							goto IL_2f0e;
							IL_2eea:
							while (true)
							{
								switch (num29)
								{
								default:
									if (num30 == 990)
									{
										goto IL_2ee6;
									}
									break;
								case 2:
									break;
								case 0:
									goto end_IL_2eea;
								case 1:
									goto end_IL_2eea;
								}
								goto IL_2f0e;
								IL_2ee6:
								num29 = num30;
								continue;
								end_IL_2eea:
								break;
							}
							goto end_IL_2eb7;
							IL_2f0e:
							vfX7duLKfQ2bRkp5HKxR(val2);
							num29 = 6;
							if (LQG1BYLdENGEbki4xS1K() == null)
							{
								num29 = 1;
							}
							goto IL_2eea;
							end_IL_2eb7:;
						}
						goto case 241;
					case 393:
						array2[7] = (byte)num17;
						num3 = 319;
						continue;
					case 203:
						array[0] = 108;
						num3 = 207;
						continue;
					case 302:
						num24 = 228 - 76;
						num3 = 351;
						continue;
					case 217:
						array2[9] = 122;
						num3 = 356;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 257;
						}
						continue;
					case 326:
						num14 = 220 - 73;
						num3 = 64;
						continue;
					case 97:
						num14 = 118 + 87;
						num3 = 354;
						continue;
					case 240:
						num17 = 27 + 24;
						num3 = 196;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 201;
						}
						continue;
					case 76:
						array2[4] = 114;
						num = 405;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num = 74;
						}
						break;
					case 170:
						num26 = array6.Length % 4;
						num3 = 223;
						continue;
					case 317:
						array2[31] = (byte)num14;
						num = 11;
						break;
					case 352:
						array2[18] = (byte)num17;
						num3 = 246;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 12;
						}
						continue;
					case 44:
					case 376:
						if (num25 >= array8.Length)
						{
							num3 = 325;
							continue;
						}
						goto case 66;
					case 285:
						num5 = 0u;
						num3 = 340;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 174;
						}
						continue;
					case 61:
						array2[11] = 233;
						num3 = 176;
						continue;
					case 146:
						array[14] = 92;
						num3 = 178;
						continue;
					case 197:
						num14 = 248 - 82;
						num3 = 178;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 266;
						}
						continue;
					case 116:
						num17 = 59 - 43;
						num3 = 72;
						continue;
					case 360:
						num17 = 19 + 3;
						num3 = 262;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 28;
						}
						continue;
					case 145:
						array2[16] = 237;
						num3 = 366;
						continue;
					case 185:
						num24 = 140 - 46;
						num3 = 232;
						continue;
					case 200:
						array2[7] = 189;
						num3 = 271;
						continue;
					case 2:
						num23 = 0;
						num3 = 272;
						continue;
					case 366:
						array2[16] = 108;
						num3 = 255;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 96;
						}
						continue;
					case 274:
						num20 = 0u;
						num3 = 356;
						continue;
					case 192:
						if (num18 > 0)
						{
							num3 = 295;
							continue;
						}
						goto case 45;
					case 325:
						array6 = array7;
						num3 = 170;
						continue;
					case 297:
						num17 = 113 + 39;
						num3 = 19;
						continue;
					case 226:
						array2[15] = 184;
						num3 = 56;
						if (LQG1BYLdENGEbki4xS1K() != null)
						{
							num3 = 376;
						}
						continue;
					case 236:
						num13 = 18 + 27;
						num3 = 352;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 68;
						}
						continue;
					case 174:
						num21 = 0u;
						num3 = 133;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 221;
						}
						continue;
					case 156:
						num17 = 245 - 81;
						num3 = 127;
						continue;
					case 155:
						num13 = 102 + 26;
						num3 = 103;
						continue;
					case 110:
						if (num19 != 1)
						{
							num3 = 78;
							continue;
						}
						goto case 20;
					case 112:
					case 212:
						yaBLrt8NNaS = E70yM3LKbIHoGmnaDphv(array3);
						num3 = 114;
						continue;
					case 201:
						array2[14] = (byte)num17;
						num3 = 336;
						continue;
					case 176:
						array2[12] = 139;
						num3 = 212;
						if (LQG1BYLdENGEbki4xS1K() == null)
						{
							num3 = 225;
						}
						continue;
					case 11:
						array2[31] = 86;
						num3 = 229;
						continue;
					case 384:
						array2[12] = (byte)num14;
						num3 = 337;
						continue;
					case 390:
						array[3] = (byte)num13;
						num3 = 107;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 353;
						}
						continue;
					case 64:
						array2[2] = (byte)num14;
						num3 = 331;
						continue;
					case 67:
						array[13] = 99;
						num = 198;
						break;
					case 296:
						num21 = (uint)((array5[num22 + 3] << 24) | (array5[num22 + 2] << 16) | (array5[num22 + 1] << 8) | array5[num22]);
						num3 = 264;
						continue;
					case 13:
						array2[6] = 63;
						num3 = 200;
						continue;
					case 248:
						array[7] = 38;
						num3 = 372;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 31;
						}
						continue;
					case 304:
						array2[14] = 122;
						num3 = 359;
						continue;
					case 82:
						array2[13] = (byte)num14;
						num3 = 276;
						continue;
					case 225:
						array2[12] = 147;
						num3 = 224;
						continue;
					case 221:
						num20 = 0u;
						num3 = 184;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 121;
						}
						continue;
					case 395:
						num17 = 112 + 49;
						num3 = 369;
						continue;
					case 396:
						array2[11] = 134;
						num3 = 247;
						continue;
					case 291:
						array[3] = (byte)num13;
						num3 = 249;
						continue;
					case 331:
						num14 = 81 + 106;
						num3 = 108;
						continue;
					case 353:
						array[14] = 164;
						num3 = 99;
						continue;
					case 234:
						num19 = 1;
						num3 = 166;
						continue;
					case 151:
						array[5] = (byte)num13;
						num3 = 109;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 38;
						}
						continue;
					case 310:
						num14 = 47 - 39;
						num3 = 157;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 342;
						}
						continue;
					case 267:
						num17 = 108 + 7;
						num3 = 352;
						if (!tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 180;
						}
						continue;
					case 220:
						array2[5] = 125;
						num3 = 280;
						continue;
					case 123:
						num13 = 119 + 33;
						num3 = 264;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 50;
						}
						continue;
					case 189:
						array4[num15 + 3] = (byte)((num16 & 0xFF000000u) >> 24);
						num3 = 252;
						continue;
					case 102:
						e56U6jLKjTQEIVXjT9Oi(val);
						num3 = 335;
						if (tXRmqxLdvFcKMf2eSh38())
						{
							num3 = 35;
						}
						continue;
					case 39:
					case 78:
						yaBLrt8NNaS = E70yM3LKbIHoGmnaDphv(jfFRTKLKZDgMEfqWvjD9(array3, 0u));
						num3 = 182;
						continue;
					case 202:
					case 235:
					{
						uint num4 = num5;
						num5 = 255u;
						uint num6 = 1682946401u;
						uint num7 = 321642649u;
						uint num8 = 491628748u;
						uint num9 = num4;
						uint num10 = 1079991374u;
						ulong num11 = 508223979uL;
						num11 |= 1;
						num9 = (uint)(num9 * num9 % num11);
						if (num8 == 0)
						{
							num8--;
						}
						uint num12 = num7 / num8 + num8;
						num8 = (num6 + num7) * num12 + num6;
						num6 = num9 ^ 0x12E69872 ^ num9;
						if (num7 == 0)
						{
							num7--;
						}
						num12 = num9 / num7 + num7;
						num7 = num9 - num9 - num12 + num9;
						if (num10 == 0)
						{
							num10--;
						}
						num12 = num9 / num10 + num10;
						num10 = num9 - num9 + num12 + num9;
						num9 ^= num9 >> 3;
						num9 += num6;
						num9 ^= num9 >> 24;
						num9 += num7;
						num9 ^= num9 << 25;
						num9 += num10;
						num9 = (((num9 << 12) - num9) ^ num7) + num9;
						num5 = num4 + (uint)(double)num9;
						num = 133;
						break;
					}
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
	internal static string[] u9PLrd1A5cu(object P_0)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		if ((Assembly)P_0 == typeof(global::qZYpv7LrBd6PaxEhteoA.qiPowfLrI8h0QeonOQ0X).Assembly)
		{
			if (!GtnLrOclKs3)
			{
				eWaLrlH4IJy();
			}
			List<string> obj = new List<string>();
			obj.AddRange((global::System.Collections.Generic.IEnumerable<string>)((Assembly)P_0).GetManifestResourceNames());
			obj.AddRange((global::System.Collections.Generic.IEnumerable<string>)((Assembly)yaBLrt8NNaS).GetManifestResourceNames());
			return obj.ToArray();
		}
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Assembly YY9LrKDsDKG(object P_0, object P_1)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		if (!GtnLrOclKs3)
		{
			eWaLrlH4IJy();
		}
		string name = ((ResolveEventArgs)P_1).Name;
		for (int i = 0; i < ((global::System.Array)f3DLrHKj1l9).Length; i++)
		{
			if ((string)((object[])f3DLrHKj1l9)[i] == name)
			{
				return (Assembly)yaBLrt8NNaS;
			}
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public qiPowfLrI8h0QeonOQ0X()
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		AppDomain.CurrentDomain.ResourceResolve += new ResolveEventHandler(YY9LrKDsDKG);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void gbWjXv8DZtD()
	{
		if (!fFYLr5jHwjE)
		{
			fFYLr5jHwjE = true;
			new qiPowfLrI8h0QeonOQ0X();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		f3DLrHKj1l9 = new string[0];
		yaBLrt8NNaS = null;
		GtnLrOclKs3 = false;
		fFYLr5jHwjE = false;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type Fvg8GsLd2vv0NPvbtHN1(RuntimeTypeHandle P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return global::System.Type.GetTypeFromHandle(P_0);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object OwgbFWLdqoWyXqGexqw9(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetManifestResourceStream((string)P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object d8PmLqLdGcFtpnlqwTvX(object P_0)
	{
		return ((g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y)P_0).KR5785vTkC();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void GOkx37LdiYQVkZETuOrc(object P_0, long P_1)
	{
		((Stream)P_0).Position = P_1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long E5JnRcLdncLOEEb5hLPP(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object o0SFWjLdziqbUmRgD8Xe(object P_0, int P_1)
	{
		return ((g9MiPrL41bvmHLMo2Exb.YUec0jLr8udpaMfJhw8y)P_0).IHnLrySmBWA(P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object E70yM3LKbIHoGmnaDphv(object P_0)
	{
		return S0iiUqLrRepXhP0XVcfv.JIsLrG92x90(P_0);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Psy3SDLKXddtmXLeeVqF(object P_0, object P_1)
	{
		((Stream)P_0).CopyTo((Stream)P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void vfX7duLKfQ2bRkp5HKxR(object P_0)
	{
		((global::System.IDisposable)P_0).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object VGJHOALKLXiciYM0Itv9(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void e56U6jLKjTQEIVXjT9Oi(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object jfFRTKLKZDgMEfqWvjD9(object P_0, uint P_1)
	{
		return S0iiUqLrRepXhP0XVcfv.wrbLrniS6AZ(P_0, P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object eraq2hLK9IooyDfd0HAO(object P_0)
	{
		return ((Assembly)P_0).GetManifestResourceNames();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool tXRmqxLdvFcKMf2eSh38()
	{
		return (object)null == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object LQG1BYLdENGEbki4xS1K()
	{
		return null;
	}
}

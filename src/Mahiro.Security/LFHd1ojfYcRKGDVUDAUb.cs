using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using CbOMUrjZ4UEBbXFQjxfm;
using YXeZWljjF5dxgDfRUq1w;

namespace CZUx5njfSrbl1tnMcUCO;

internal class LFHd1ojfYcRKGDVUDAUb
{
	private class W8Z7v1jjjoZ4OClo3WTS
	{
	}

	internal class isi3yyjjHLD2e2CxV4Py
	{
		private object BqajjRZS9bM;

		[MethodImpl((MethodImplOptions)8)]
		public isi3yyjjHLD2e2CxV4Py(Stream P_0)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[SpecialName]
		internal Stream KR5785vTkC()
		{
			return ((BinaryReader)BqajjRZS9bM).BaseStream;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal byte[] DZijjtEJTbX(int P_0)
		{
			return ((BinaryReader)BqajjRZS9bM).ReadBytes(P_0);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int X1MjjO1aojZ(byte[] P_0, int P_1, int P_2)
		{
			return ((BinaryReader)BqajjRZS9bM).Read(P_0, P_1, P_2);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int Vi4jj5AsZSj()
		{
			return ((BinaryReader)BqajjRZS9bM).ReadInt32();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void fjpjj6pbRLQ()
		{
			((BinaryReader)BqajjRZS9bM).Close();
		}
	}

	private delegate void qGIjfvjjwQqnFL6Zn1pG(object o);

	internal class SHRr3HjjeiEdwtRQTwSn
	{
		[MethodImpl((MethodImplOptions)8)]
		internal static string nYgjjPiOTuL(object P_0, object P_1)
		{
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Expected O, but got Unknown
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			byte[] bytes = Encoding.Unicode.GetBytes((string)P_0);
			byte[] array = new byte[32];
			RuntimeHelpers.InitializeArray((global::System.Array)array, default(RuntimeFieldHandle));
			byte[] key = array;
			byte[] iV = NLCjfQ78KRU(Encoding.Unicode.GetBytes((string)P_1));
			MemoryStream val = new MemoryStream();
			SymmetricAlgorithm val2 = QIVjfgL0IKK();
			val2.Key = key;
			val2.IV = iV;
			CryptoStream val3 = new CryptoStream((Stream)val, val2.CreateEncryptor(), (CryptoStreamMode)1);
			((Stream)val3).Write(bytes, 0, bytes.Length);
			((Stream)val3).Close();
			return Convert.ToBase64String(val.ToArray());
		}

		[MethodImpl((MethodImplOptions)8)]
		public SHRr3HjjeiEdwtRQTwSn()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}
	}

	internal struct KXoHjejjZS3qU6BkQE9W
	{
		internal int i4Djj9QbjlU;

		internal nint VDtjjDMldud;

		internal nint xnKjjktox4j;
	}

	private struct iqcKO2jjVEf134wvf7hy
	{
		public nuint yEujjYN70mU;

		public nuint qlYjjSx43UH;

		public uint ID8jjcACxi4;

		public nint mfvjj0GWeIV;

		public uint gUMjj8SQQby;

		public uint P8wjjyWtvMa;

		public uint gtxjjWCc4MT;
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	internal struct fSkbr6jjJ1jFgHS1jU4c
	{
		public nint dUVjjQrk4GB;

		public nint RgVjjCis6xC;

		public nint X3kjj4ZaRfV;

		public int WtAjjhaih8K;
	}

	internal delegate uint yZe1IqjjUxwkUFd9SOSm(nint classthis, nint comp, ref fSkbr6jjJ1jFgHS1jU4c info, uint flags, nint nativeEntry, ref uint nativeSizeOfCode);

	internal delegate uint xwfKGFjjrcpgqnFqchBy(nint classthis, nint comp, ref fSkbr6jjJ1jFgHS1jU4c info, uint flags, nint nativeEntry, ref uint nativeSizeOfCode);

	private delegate nint lSYZjtjjoUFRk35yWa07();

	private delegate int im4DEajjmDbH4RAHrpX4(nint lpAddress, int dwSize, int flNewProtect, ref int lpflOldProtect);

	private delegate nint diIEQEjj7ZNCGMkXgHpw(nint lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

	private delegate nuint naQXi8jjAYM6tRCHr2Bm(nuint lpAddress, out iqcKO2jjVEf134wvf7hy mbi, nuint dwLength);

	private delegate nint jIKkyKjjIEGW8vTQ5nLE(uint dwDesiredAccess, int bInheritHandle, uint dwProcessId);

	private delegate int zDv1B3jjB40vivxGoYMP(nint hProcess, nint lpBaseAddress, [In][Out] byte[] buffer, uint size, out nint lpNumberOfBytesWritten);

	private delegate int VkWG4pjjguHbJSX6JLfa(nint ptr);

	private delegate nint dg4gEOjjlyJ7VfcQ9OUG(nint addr, nint length, int prot, int flags, int fd, nint offset);

	private delegate int m4CiA5jjdX1Afc2DDLBb(nint start, nint len, int mprot);

	[Flags]
	private enum SoBLAgjjKmI8jLePkCLk
	{

	}

	private static List<int> NG5jLHWNKsU;

	private static int Vd3jLtWDkOY;

	private static xwfKGFjjrcpgqnFqchBy boAjLzmDAXv;

	private static VkWG4pjjguHbJSX6JLfa lcojL17gVif;

	internal static xwfKGFjjrcpgqnFqchBy CISjLwsWe53;

	private static bool fOdjLxBVilU;

	private object bJpjL5voogE;

	private static bool KqrjLq5uWyl;

	private static bool nR4jLo5kEuS;

	private static int eT7jjXwNa6x;

	private static nint xVQjLiRPtRH;

	private static naQXi8jjAYM6tRCHr2Bm Ve9jLp3fHkt;

	private static bool KI7jLGTtjft;

	private static object w9JjLBZnyUm;

	private static object FRKjLIqJQbD;

	internal static object KDajLeoeOoe;

	private static object T4ajLlKIvxj;

	private static bool rDCjL2RZvJX;

	private static nint qX2jLTtAVNe;

	private static bool gVyjjLlvmX7;

	private static object pndjLd6ORW9;

	private static bool yOKjjbe9yP8;

	private static im4DEajjmDbH4RAHrpX4 omKjLNWIIdo;

	internal static yZe1IqjjUxwkUFd9SOSm akIjLRt2hNy;

	private static diIEQEjj7ZNCGMkXgHpw CosjLMlwmLt;

	private static bool bCqjLFiFedh;

	private static zDv1B3jjB40vivxGoYMP faQjLajAmEX;

	internal static object WMNjLPZUAN7;

	private static int UQujjfDHQuK;

	private object tuljLOiQw6S;

	private static int tpljLE76fvS;

	private static nint muMjL6VLTWC;

	private static object crcjLgMY3xc;

	private static object G3AjL3wh4Vg;

	private static jIKkyKjjIEGW8vTQ5nLE zYgjLuKXwKt;

	private static yZe1IqjjUxwkUFd9SOSm oXnjLnB85yK;

	internal static object ibyjLsFh5AX;

	private static Dictionary<int, int> KoOjL7JuHVE;

	private static bool xgsjLm7GfYI;

	private static object PV3jLAC4r2d;

	private static object L3CjLvtgo70;

	private static object pxGjLrpDqqd;

	private static List<string> xQQjLKODyyb;

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal LFHd1ojfYcRKGDVUDAUb()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void WSJDB1c92qM()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] HBgjfckoaPs(object P_0)
	{
		uint num2 = default(uint);
		uint num = num2 << 6;
		uint[] array = default(uint[]);
		byte[] array2 = default(byte[]);
		for (uint num3 = 0u; num3 < 61; num3 += 4)
		{
			array[num3 >> 2] = (uint)((((short[])(object)array2)[num + (num3 + 3)] << 24) | (((short[])(object)array2)[num + (num3 + 2)] << 16) | (((short[])(object)array2)[num + (num3 + 1)] << 8) | ((short[])(object)array2)[num + num3]);
		}
		uint num5 = default(uint);
		uint num4 = num5;
		uint num7 = default(uint);
		uint num6 = num7;
		uint num9 = default(uint);
		uint num8 = num9;
		uint num11 = default(uint);
		uint num10 = num11;
		Jqmjf0JNEv2(ref num5, num7, num9, num11, 0u, 7, 1u, array);
		Jqmjf0JNEv2(ref num11, num5, num7, num9, 1u, 12, 2u, array);
		Jqmjf0JNEv2(ref num9, num11, num5, num7, 2u, 17, 3u, array);
		Jqmjf0JNEv2(ref num7, num9, num11, num5, 3u, 22, 4u, array);
		Jqmjf0JNEv2(ref num5, num7, num9, num11, 4u, 7, 5u, array);
		Jqmjf0JNEv2(ref num11, num5, num7, num9, 5u, 12, 6u, array);
		Jqmjf0JNEv2(ref num9, num11, num5, num7, 6u, 17, 7u, array);
		Jqmjf0JNEv2(ref num7, num9, num11, num5, 7u, 22, 8u, array);
		Jqmjf0JNEv2(ref num5, num7, num9, num11, 8u, 7, 9u, array);
		Jqmjf0JNEv2(ref num11, num5, num7, num9, 9u, 12, 10u, array);
		Jqmjf0JNEv2(ref num9, num11, num5, num7, 10u, 17, 11u, array);
		Jqmjf0JNEv2(ref num7, num9, num11, num5, 11u, 22, 12u, array);
		Jqmjf0JNEv2(ref num5, num7, num9, num11, 12u, 7, 13u, array);
		Jqmjf0JNEv2(ref num11, num5, num7, num9, 13u, 12, 14u, array);
		Jqmjf0JNEv2(ref num9, num11, num5, num7, 14u, 17, 15u, array);
		Jqmjf0JNEv2(ref num7, num9, num11, num5, 15u, 22, 16u, array);
		zZ6jf84cCVt(ref num5, num7, num9, num11, 1u, 5, 17u, array);
		zZ6jf84cCVt(ref num11, num5, num7, num9, 6u, 9, 18u, array);
		zZ6jf84cCVt(ref num9, num11, num5, num7, 11u, 14, 19u, array);
		zZ6jf84cCVt(ref num7, num9, num11, num5, 0u, 20, 20u, array);
		zZ6jf84cCVt(ref num5, num7, num9, num11, 5u, 5, 21u, array);
		zZ6jf84cCVt(ref num11, num5, num7, num9, 10u, 9, 22u, array);
		zZ6jf84cCVt(ref num9, num11, num5, num7, 15u, 14, 23u, array);
		zZ6jf84cCVt(ref num7, num9, num11, num5, 4u, 20, 24u, array);
		zZ6jf84cCVt(ref num5, num7, num9, num11, 9u, 5, 25u, array);
		zZ6jf84cCVt(ref num11, num5, num7, num9, 14u, 9, 26u, array);
		zZ6jf84cCVt(ref num9, num11, num5, num7, 3u, 14, 27u, array);
		zZ6jf84cCVt(ref num7, num9, num11, num5, 8u, 20, 28u, array);
		zZ6jf84cCVt(ref num5, num7, num9, num11, 13u, 5, 29u, array);
		zZ6jf84cCVt(ref num11, num5, num7, num9, 2u, 9, 30u, array);
		zZ6jf84cCVt(ref num9, num11, num5, num7, 7u, 14, 31u, array);
		zZ6jf84cCVt(ref num7, num9, num11, num5, 12u, 20, 32u, array);
		NosjfynrS8v(ref num5, num7, num9, num11, 5u, 4, 33u, array);
		NosjfynrS8v(ref num11, num5, num7, num9, 8u, 11, 34u, array);
		NosjfynrS8v(ref num9, num11, num5, num7, 11u, 16, 35u, array);
		NosjfynrS8v(ref num7, num9, num11, num5, 14u, 23, 36u, array);
		NosjfynrS8v(ref num5, num7, num9, num11, 1u, 4, 37u, array);
		NosjfynrS8v(ref num11, num5, num7, num9, 4u, 11, 38u, array);
		NosjfynrS8v(ref num9, num11, num5, num7, 7u, 16, 39u, array);
		NosjfynrS8v(ref num7, num9, num11, num5, 10u, 23, 40u, array);
		NosjfynrS8v(ref num5, num7, num9, num11, 13u, 4, 41u, array);
		NosjfynrS8v(ref num11, num5, num7, num9, 0u, 11, 42u, array);
		NosjfynrS8v(ref num9, num11, num5, num7, 3u, 16, 43u, array);
		NosjfynrS8v(ref num7, num9, num11, num5, 6u, 23, 44u, array);
		NosjfynrS8v(ref num5, num7, num9, num11, 9u, 4, 45u, array);
		NosjfynrS8v(ref num11, num5, num7, num9, 12u, 11, 46u, array);
		NosjfynrS8v(ref num9, num11, num5, num7, 15u, 16, 47u, array);
		NosjfynrS8v(ref num7, num9, num11, num5, 2u, 23, 48u, array);
		iMNjfWVkOlO(ref num5, num7, num9, num11, 0u, 6, 49u, array);
		iMNjfWVkOlO(ref num11, num5, num7, num9, 7u, 10, 50u, array);
		iMNjfWVkOlO(ref num9, num11, num5, num7, 14u, 15, 51u, array);
		iMNjfWVkOlO(ref num7, num9, num11, num5, 5u, 21, 52u, array);
		iMNjfWVkOlO(ref num5, num7, num9, num11, 12u, 6, 53u, array);
		iMNjfWVkOlO(ref num11, num5, num7, num9, 3u, 10, 54u, array);
		iMNjfWVkOlO(ref num9, num11, num5, num7, 10u, 15, 55u, array);
		iMNjfWVkOlO(ref num7, num9, num11, num5, 1u, 21, 56u, array);
		iMNjfWVkOlO(ref num5, num7, num9, num11, 8u, 6, 57u, array);
		iMNjfWVkOlO(ref num11, num5, num7, num9, 15u, 10, 58u, array);
		iMNjfWVkOlO(ref num9, num11, num5, num7, 6u, 15, 59u, array);
		iMNjfWVkOlO(ref num7, num9, num11, num5, 13u, 21, 60u, array);
		iMNjfWVkOlO(ref num5, num7, num9, num11, 4u, 6, 61u, array);
		iMNjfWVkOlO(ref num11, num5, num7, num9, 11u, 10, 62u, array);
		iMNjfWVkOlO(ref num9, num11, num5, num7, 2u, 15, 63u, array);
		iMNjfWVkOlO(ref num7, num9, num11, num5, 9u, 21, 64u, array);
		num5 += num4;
		num7 += num6;
		num9 += num8;
		num11 += num10;
		num2++;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void Jqmjf0JNEv2(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		_ = P_1 + IUCjfJCr9Iv((uint)(int)(global::System.Runtime.CompilerServices.Unsafe.As<uint, double>(ref P_0) + ((P_1 & P_2) | (~P_1 & P_3)) + ((ushort[])P_7)[P_4] + ((ushort[])pxGjLrpDqqd)[P_6 - 1]), P_5);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void zZ6jf84cCVt(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected I4, but got Unknown
		_ = P_1 + IUCjfJCr9Iv((uint)(int)(global::System.Runtime.CompilerServices.Unsafe.As<uint, double>(ref P_0) + ((P_1 & P_3) | (P_2 & ~P_3)) + ((ushort[])P_7)[P_4] + ((ushort[])pxGjLrpDqqd)[P_6 - 1]), P_5);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NosjfynrS8v(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected I4, but got Unknown
		_ = P_1 + IUCjfJCr9Iv((uint)(int)(global::System.Runtime.CompilerServices.Unsafe.As<uint, double>(ref P_0) + (P_1 ^ P_2 ^ P_3) + ((ushort[])P_7)[P_4] + ((ushort[])pxGjLrpDqqd)[P_6 - 1]), P_5);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void iMNjfWVkOlO(ref uint P_0, uint P_1, uint P_2, uint P_3, uint P_4, ushort P_5, uint P_6, object P_7)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected I4, but got Unknown
		_ = P_1 + IUCjfJCr9Iv((uint)(int)(global::System.Runtime.CompilerServices.Unsafe.As<uint, double>(ref P_0) + (P_2 ^ (P_1 | ~P_3)) + ((ushort[])P_7)[P_4] + ((ushort[])pxGjLrpDqqd)[P_6 - 1]), P_5);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint IUCjfJCr9Iv(uint P_0, ushort P_1)
	{
		return (P_0 >> 32 - P_1) | (P_0 << (int)P_1);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] NLCjfQ78KRU(object P_0)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		if (!XuLjf4j60Yl())
		{
			return ((HashAlgorithm)new MD5CryptoServiceProvider()).ComputeHash((byte[])P_0);
		}
		return HBgjfckoaPs(P_0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void c4jjfCx0LZp()
	{
		try
		{
			RSACryptoServiceProvider.UseMachineKeyStore = true;
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool XuLjf4j60Yl()
	{
		if (!nR4jLo5kEuS)
		{
			CLQjfB1CNbi();
			nR4jLo5kEuS = true;
		}
		return xgsjLm7GfYI;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] vLZjfhgpRWg()
	{
		_ = "5KFgkt0rMs0hgggmO1t".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] nlTjfU0W4qn()
	{
		_ = "Pt818yNDqGJJIINd14Lq8S".Length;
		_ = 0;
		return new byte[2] { 1, 2 };
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] mp9jfrVcEn8()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] z12jfoOoFnt()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void vHpjfmZLY1E(RuntimeTypeHandle P_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_046a: Unknown result type (might be due to invalid IL or missing references)
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0493: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_0547: Unknown result type (might be due to invalid IL or missing references)
		//IL_054e: Expected O, but got Unknown
		//IL_05de: Unknown result type (might be due to invalid IL or missing references)
		//IL_057d: Unknown result type (might be due to invalid IL or missing references)
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0609: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			global::System.Type typeFromHandle = global::System.Type.GetTypeFromHandle(P_0);
			if (KoOjL7JuHVE == null)
			{
				lock (PV3jLAC4r2d)
				{
					Dictionary<int, int> val = new Dictionary<int, int>();
					BinaryReader val2 = new BinaryReader(global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557474)).Assembly.GetManifestResourceStream("M7UDP4jfLcNksAohDXXd.vlIuYQjfjfqrF4IHWf99"));
					val2.BaseStream.Position = 0L;
					byte[] array = val2.ReadBytes((int)val2.BaseStream.Length);
					val2.Close();
					if (array.Length != 0)
					{
						int num = array.Length % 4;
						int num2 = array.Length / 4;
						byte[] array2 = new byte[array.Length];
						uint num3 = 0u;
						uint num4 = 0u;
						if (num > 0)
						{
							num2++;
						}
						uint num5 = 0u;
						for (int i = 0; i < num2; i++)
						{
							int num6 = i * 4;
							uint num7 = 255u;
							int num8 = 0;
							if (i == num2 - 1 && num > 0)
							{
								num4 = 0u;
								for (int j = 0; j < num; j++)
								{
									if (j > 0)
									{
										num4 <<= 8;
									}
									num4 |= array[array.Length - (1 + j)];
								}
							}
							else
							{
								num5 = (uint)num6;
								num4 = (uint)((array[num5 + 3] << 24) | (array[num5 + 2] << 16) | (array[num5 + 1] << 8) | array[num5]);
							}
							num3 = num3;
							uint num9 = num3;
							uint num10 = num3;
							uint num11 = 1682946401u;
							uint num12 = 321642649u;
							uint num13 = 491628748u;
							uint num14 = num10;
							uint num15 = 1079991374u;
							ulong num16 = 508223979uL;
							num16 |= 1;
							num14 = (uint)(num14 * num14 % num16);
							if (num13 == 0)
							{
								num13--;
							}
							uint num17 = num12 / num13 + num13;
							num13 = (num11 + num12) * num17 + num11;
							num11 = num14 ^ 0x12E69872 ^ num14;
							if (num12 == 0)
							{
								num12--;
							}
							num17 = num14 / num12 + num12;
							num12 = num14 - num14 - num17 + num14;
							if (num15 == 0)
							{
								num15--;
							}
							num17 = num14 / num15 + num15;
							num15 = num14 - num14 + num17 + num14;
							num14 ^= num14 >> 3;
							num14 += num11;
							num14 ^= num14 >> 24;
							num14 += num12;
							num14 ^= num14 << 25;
							num14 += num15;
							num14 = (((num14 << 12) - num14) ^ num12) + num14;
							num3 = num9 + (uint)(double)num14;
							if (i == num2 - 1 && num > 0)
							{
								uint num18 = num3 ^ num4;
								for (int k = 0; k < num; k++)
								{
									if (k > 0)
									{
										num7 <<= 8;
										num8 += 8;
									}
									array2[num6 + k] = (byte)((num18 & num7) >> num8);
								}
							}
							else
							{
								uint num19 = num3 ^ num4;
								array2[num6] = (byte)(num19 & 0xFF);
								array2[num6 + 1] = (byte)((num19 & 0xFF00) >> 8);
								array2[num6 + 2] = (byte)((num19 & 0xFF0000) >> 16);
								array2[num6 + 3] = (byte)((num19 & 0xFF000000u) >> 24);
							}
						}
						array = array2;
						array2 = null;
						int num20 = array.Length / 8;
						isi3yyjjHLD2e2CxV4Py isi3yyjjHLD2e2CxV4Py = (isi3yyjjHLD2e2CxV4Py)new isi3yyjjHLD2e2CxV4Py((Stream)new MemoryStream(array));
						for (int l = 0; l < num20; l++)
						{
							int num21 = isi3yyjjHLD2e2CxV4Py.Vi4jj5AsZSj();
							int num22 = isi3yyjjHLD2e2CxV4Py.Vi4jj5AsZSj();
							val.Add(num21, num22);
						}
						isi3yyjjHLD2e2CxV4Py.fjpjj6pbRLQ();
					}
					KoOjL7JuHVE = val;
				}
			}
			FieldInfo[] fields = typeFromHandle.GetFields((BindingFlags)1064);
			foreach (FieldInfo val3 in fields)
			{
				int metadataToken = ((MemberInfo)val3).MetadataToken;
				int num23 = KoOjL7JuHVE[metadataToken];
				bool flag = (num23 & 0x40000000) > 0;
				num23 &= 0x3FFFFFFF;
				MethodInfo val4 = (MethodInfo)global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557474)).Module.ResolveMethod(num23, typeFromHandle.GetGenericArguments(), new global::System.Type[0]);
				if (((MethodBase)val4).IsStatic)
				{
					val3.SetValue((object)null, (object)global::System.Delegate.CreateDelegate(val3.FieldType, val4));
					continue;
				}
				ParameterInfo[] parameters = ((MethodBase)val4).GetParameters();
				int num24 = parameters.Length + 1;
				global::System.Type[] array3 = new global::System.Type[num24];
				if (((MemberInfo)val4).DeclaringType.IsValueType)
				{
					array3[0] = ((MemberInfo)val4).DeclaringType.MakeByRefType();
				}
				else
				{
					array3[0] = global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(16777238));
				}
				for (int n = 0; n < parameters.Length; n++)
				{
					array3[n + 1] = parameters[n].ParameterType;
				}
				DynamicMethod val5 = new DynamicMethod(string.Empty, val4.ReturnType, array3, typeFromHandle, true);
				ILGenerator iLGenerator = val5.GetILGenerator();
				for (int num25 = 0; num25 < num24; num25++)
				{
					switch (num25)
					{
					case 0:
						iLGenerator.Emit(OpCodes.Ldarg_0);
						break;
					case 1:
						iLGenerator.Emit(OpCodes.Ldarg_1);
						break;
					case 2:
						iLGenerator.Emit(OpCodes.Ldarg_2);
						break;
					case 3:
						iLGenerator.Emit(OpCodes.Ldarg_3);
						break;
					default:
						iLGenerator.Emit(OpCodes.Ldarg_S, num25);
						break;
					}
				}
				iLGenerator.Emit(OpCodes.Tailcall);
				iLGenerator.Emit(flag ? OpCodes.Callvirt : OpCodes.Call, val4);
				iLGenerator.Emit(OpCodes.Ret);
				val3.SetValue((object)null, (object)((MethodInfo)val5).CreateDelegate(typeFromHandle));
			}
		}
		catch (global::System.Exception ex)
		{
			throw ex;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void SsXjfAZ8mMV()
	{
		if (Debugger.IsAttached)
		{
			throw new global::System.Exception("Debugger Detected");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int zE7jfIRS2Rq()
	{
		return 5;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void CLQjfB1CNbi()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new MD5CryptoServiceProvider();
		}
		catch
		{
			xgsjLm7GfYI = true;
			return;
		}
		try
		{
			xgsjLm7GfYI = CryptoConfig.AllowOnlyFipsAlgorithms;
		}
		catch
		{
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SymmetricAlgorithm QIVjfgL0IKK()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		SymmetricAlgorithm val = null;
		if (XuLjf4j60Yl())
		{
			return (SymmetricAlgorithm)new AesCryptoServiceProvider();
		}
		try
		{
			return (SymmetricAlgorithm)new RijndaelManaged();
		}
		catch
		{
			return (SymmetricAlgorithm)new AesCryptoServiceProvider();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] TDqjfl7IN4D()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] yHdjfdwq38I()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void rNJjfKiBlUX(object P_0, object P_1, uint P_2, object P_3)
	{
		while (P_2 != 0)
		{
			int num = ((P_2 > (uint)((global::System.Array)P_3).Length) ? ((global::System.Array)P_3).Length : ((int)P_2));
			((Stream)P_1).Read((byte[])P_3, 0, num);
			AUEjfHW7WoZ(P_0, P_3, 0, num);
			P_2 -= (uint)num;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void AUEjfHW7WoZ(object P_0, object P_1, int P_2, int P_3)
	{
		((HashAlgorithm)P_0).TransformBlock((byte[])P_1, P_2, P_3, (byte[])P_1, P_2);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint DK7jft7XvQ9(uint P_0, int P_1, long P_2, object P_3)
	{
		for (int i = 0; i < P_1; i++)
		{
			((BinaryReader)P_3).BaseStream.Position = P_2 + (i * 40 + 8);
			uint num = ((BinaryReader)P_3).ReadUInt32();
			uint num2 = ((BinaryReader)P_3).ReadUInt32();
			((BinaryReader)P_3).ReadUInt32();
			uint num3 = ((BinaryReader)P_3).ReadUInt32();
			if (num2 <= P_0 && P_0 < num2 + num)
			{
				return num3 + P_0 - num2;
			}
		}
		return 0u;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void t2vjfOtIwFT()
	{
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_182b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1830: Unknown result type (might be due to invalid IL or missing references)
		//IL_183d: Expected O, but got Unknown
		//IL_183d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Expected O, but got Unknown
		//IL_186a: Expected O, but got Unknown
		//IL_199a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19a1: Expected O, but got Unknown
		//IL_1cba: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc1: Expected O, but got Unknown
		int num = 17;
		HashAlgorithm val = default(HashAlgorithm);
		int num5 = default(int);
		string text2 = default(string);
		string text = default(string);
		int num7 = default(int);
		BinaryReader val3 = default(BinaryReader);
		int num34 = default(int);
		int num36 = default(int);
		bool flag = default(bool);
		int num41 = default(int);
		int num43 = default(int);
		int num25 = default(int);
		byte[] array = default(byte[]);
		int num16 = default(int);
		uint num23 = default(uint);
		long num14 = default(long);
		uint num30 = default(uint);
		long num11 = default(long);
		byte[] array2 = default(byte[]);
		uint num20 = default(uint);
		long num15 = default(long);
		uint num17 = default(uint);
		int num12 = default(int);
		uint num22 = default(uint);
		long num21 = default(long);
		int num27 = default(int);
		int num29 = default(int);
		long num13 = default(long);
		uint num24 = default(uint);
		int num32 = default(int);
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
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_000d;
							}
							goto case 17;
						}
						try
						{
							val = (HashAlgorithm)A0BgEUjyn3r8qJJgbOKR();
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 991)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
									if (!VuoOMYjWbyBEl6Y613dM(text2))
									{
										num4 = 7;
										if (EqDaRojyEIE7xmUCqV13() == null)
										{
											num4 = 0;
										}
										continue;
									}
									goto end_IL_00a3;
								case 0:
									return;
								case 2:
									break;
								case 3:
									goto end_IL_00a3;
								}
								text = (string)MmwxK9jyzFyfhqFd8Qpi("SHA1");
								num4 = 9;
								if (EqDaRojyEIE7xmUCqV13() == null)
								{
									num4 = 1;
								}
								continue;
								end_IL_00a3:
								break;
							}
						}
						catch
						{
							int num6 = 0;
							if (EqDaRojyEIE7xmUCqV13() != null)
							{
								num6 = 4;
							}
							while (true)
							{
								switch (num6)
								{
								case 0:
									return;
								}
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								return;
							}
						}
						goto case 15;
					case 14:
						try
						{
							if (val3 != null)
							{
								int num33 = 0;
								if (EqDaRojyEIE7xmUCqV13() != null)
								{
									num33 = 0;
								}
								while (true)
								{
									switch (num33)
									{
									default:
										if (num34 == 989)
										{
											num33 = num34;
											continue;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_01b7;
									}
									mLMm3XjWgRMnB2aTQdNn(val3);
									num33 = 3;
									if (t4aFPujyvfij3VXeQ57e())
									{
										num33 = 1;
									}
									continue;
									end_IL_01b7:
									break;
								}
							}
						}
						catch
						{
							int num35 = 0;
							if (EqDaRojyEIE7xmUCqV13() != null)
							{
								num35 = 5;
							}
							while (true)
							{
								switch (num35)
								{
								default:
									if (num36 == 988)
									{
										num35 = num36;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 10;
					case 15:
						flag = false;
						num3 = 25;
						if (EqDaRojyEIE7xmUCqV13() == null)
						{
							num3 = 4;
						}
						continue;
					case 10:
						if (!flag)
						{
							num = 2;
							break;
						}
						goto case 13;
					case 9:
						crcjLgMY3xc = (object)new RSACryptoServiceProvider();
						num3 = 18;
						continue;
					case 16:
						LCaiWdjy2VPvbD2bSu5W(true);
						num3 = 7;
						if (EqDaRojyEIE7xmUCqV13() == null)
						{
							num3 = 9;
						}
						continue;
					case 6:
						if (!flag)
						{
							num3 = 10;
							if (EqDaRojyEIE7xmUCqV13() == null)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 10;
					case 13:
						throw new global::System.Exception((string)EACPPDjWK3wdQTP62dvR(xGbEOSjWdjeUi8ELymmW(D9RLypjWlsCtS7Oubn9m(ES2l1Bjyq1JCgyGS6gCk(typeof(LFHd1ojfYcRKGDVUDAUb).TypeHandle).Assembly)), " is tampered."));
					case 2:
						flag = false;
						num3 = 0;
						if (!t4aFPujyvfij3VXeQ57e())
						{
							num3 = 18;
						}
						continue;
					case 11:
						if (text2 != null)
						{
							num3 = 8;
							continue;
						}
						return;
					case 4:
						try
						{
							object isi3yyjjHLD2e2CxV4Py = (object)new isi3yyjjHLD2e2CxV4Py((Stream)D0sRkVjWXC72BU9JQd1d(FRKjLIqJQbD, "d044aBjXiIL6FhOuvcuG.GfUNk5jXnggaUV4Fn8rf"));
							JJxq5ojWLbSt9nUQCq9y(WCGVbFjWfe0CrU6bQCqw(isi3yyjjHLD2e2CxV4Py), 0L);
							byte[] array3 = (byte[])RjMamhjWZ4H2p75LvQUP(isi3yyjjHLD2e2CxV4Py, (int)L9Kg0hjWjqIddM1q5G1U(WCGVbFjWfe0CrU6bQCqw(isi3yyjjHLD2e2CxV4Py)));
							byte[] array4 = new byte[32];
							array4[0] = 121;
							int num37 = 11 + 78;
							array4[0] = (byte)num37;
							num37 = 170 - 86;
							array4[0] = (byte)num37;
							int num38 = 187 - 62;
							array4[1] = (byte)num38;
							array4[1] = 135;
							array4[1] = 152;
							num38 = 141 - 47;
							array4[2] = (byte)num38;
							array4[2] = 98;
							array4[2] = 116;
							num37 = 104 - 8;
							array4[2] = (byte)num37;
							num38 = 19 + 13;
							array4[3] = (byte)num38;
							array4[3] = 126;
							array4[3] = 107;
							array4[3] = 108;
							array4[3] = 45;
							num37 = 195 - 65;
							array4[4] = (byte)num37;
							num37 = 202 - 67;
							array4[4] = (byte)num37;
							num38 = 173 - 83;
							array4[4] = (byte)num38;
							num37 = 227 - 75;
							array4[5] = (byte)num37;
							array4[5] = 183;
							array4[5] = 242;
							array4[6] = 216;
							num37 = 58 + 37;
							array4[6] = (byte)num37;
							array4[6] = 162;
							array4[6] = 104;
							num37 = 102 - 3;
							array4[6] = (byte)num37;
							array4[7] = 107;
							num38 = 91 + 48;
							array4[7] = (byte)num38;
							num38 = 2 + 79;
							array4[7] = (byte)num38;
							array4[7] = 10;
							num38 = 125 - 41;
							array4[8] = (byte)num38;
							array4[8] = 127;
							num38 = 119 + 90;
							array4[8] = (byte)num38;
							array4[8] = 127;
							array4[8] = 165;
							array4[8] = 69;
							num38 = 150 - 50;
							array4[9] = (byte)num38;
							array4[9] = 95;
							num38 = 47 + 68;
							array4[9] = (byte)num38;
							num37 = 161 - 53;
							array4[9] = (byte)num37;
							num38 = 209 - 69;
							array4[9] = (byte)num38;
							num38 = 154 - 101;
							array4[9] = (byte)num38;
							array4[10] = 101;
							num37 = 55 + 81;
							array4[10] = (byte)num37;
							num38 = 229 - 76;
							array4[10] = (byte)num38;
							num38 = 22 + 103;
							array4[10] = (byte)num38;
							array4[10] = 64;
							num38 = 132 + 79;
							array4[10] = (byte)num38;
							num38 = 2 + 104;
							array4[11] = (byte)num38;
							array4[11] = 54;
							array4[11] = 139;
							array4[11] = 107;
							array4[11] = 102;
							array4[11] = 230;
							num37 = 220 - 73;
							array4[12] = (byte)num37;
							num37 = 15 + 118;
							array4[12] = (byte)num37;
							array4[12] = 123;
							array4[12] = 109;
							num37 = 180 - 60;
							array4[12] = (byte)num37;
							num37 = 120 + 81;
							array4[12] = (byte)num37;
							num37 = 174 - 58;
							array4[13] = (byte)num37;
							array4[13] = 26;
							array4[13] = 110;
							array4[13] = 158;
							num38 = 254 - 84;
							array4[13] = (byte)num38;
							array4[13] = 110;
							array4[14] = 77;
							num38 = 204 - 68;
							array4[14] = (byte)num38;
							array4[14] = 124;
							array4[14] = 155;
							array4[14] = 194;
							num37 = 164 - 54;
							array4[15] = (byte)num37;
							array4[15] = 90;
							array4[15] = 67;
							num37 = 110 + 17;
							array4[15] = (byte)num37;
							array4[16] = 159;
							array4[16] = 66;
							array4[16] = 136;
							array4[16] = 46;
							array4[17] = 102;
							array4[17] = 33;
							num37 = 112 + 124;
							array4[17] = (byte)num37;
							array4[17] = 237;
							array4[18] = 128;
							num38 = 77 + 78;
							array4[18] = (byte)num38;
							array4[18] = 121;
							num37 = 100 - 22;
							array4[18] = (byte)num37;
							array4[19] = 134;
							array4[19] = 181;
							num38 = 177 - 59;
							array4[19] = (byte)num38;
							num37 = 155 - 65;
							array4[19] = (byte)num37;
							array4[20] = 222;
							num38 = 147 - 49;
							array4[20] = (byte)num38;
							array4[20] = 148;
							num38 = 126 - 42;
							array4[20] = (byte)num38;
							num37 = 139 - 111;
							array4[20] = (byte)num37;
							num38 = 138 - 46;
							array4[21] = (byte)num38;
							num37 = 220 - 73;
							array4[21] = (byte)num37;
							num37 = 46 + 61;
							array4[21] = (byte)num37;
							array4[21] = 226;
							array4[22] = 112;
							num38 = 219 - 73;
							array4[22] = (byte)num38;
							num37 = 169 + 41;
							array4[22] = (byte)num37;
							num37 = 51 + 64;
							array4[23] = (byte)num37;
							array4[23] = 192;
							num38 = 222 - 74;
							array4[23] = (byte)num38;
							num38 = 75 + 113;
							array4[23] = (byte)num38;
							array4[24] = 123;
							array4[24] = 136;
							array4[24] = 150;
							array4[24] = 123;
							array4[25] = 40;
							num38 = 149 - 49;
							array4[25] = (byte)num38;
							num37 = 104 + 7;
							array4[25] = (byte)num37;
							num38 = 40 + 87;
							array4[25] = (byte)num38;
							num38 = 46 + 34;
							array4[26] = (byte)num38;
							array4[26] = 118;
							num37 = 19 + 116;
							array4[26] = (byte)num37;
							array4[26] = 164;
							num37 = 191 - 117;
							array4[26] = (byte)num37;
							array4[27] = 114;
							num38 = 208 - 69;
							array4[27] = (byte)num38;
							array4[27] = 135;
							array4[27] = 165;
							num38 = 147 + 99;
							array4[27] = (byte)num38;
							num37 = 179 - 59;
							array4[28] = (byte)num37;
							array4[28] = 134;
							array4[28] = 132;
							array4[28] = 99;
							array4[28] = 18;
							array4[29] = 95;
							num37 = 180 - 60;
							array4[29] = (byte)num37;
							array4[29] = 54;
							array4[30] = 92;
							num37 = 95 + 108;
							array4[30] = (byte)num37;
							array4[30] = 173;
							num37 = 196 - 65;
							array4[30] = (byte)num37;
							num37 = 131 + 77;
							array4[30] = (byte)num37;
							array4[31] = 72;
							array4[31] = 147;
							array4[31] = 124;
							num38 = 75 - 17;
							array4[31] = (byte)num38;
							byte[] array5 = array4;
							byte[] array6 = new byte[16];
							int num39 = 153 - 51;
							array6[0] = (byte)num39;
							num39 = 0 + 109;
							array6[0] = (byte)num39;
							array6[0] = 140;
							array6[0] = 121;
							array6[0] = 132;
							array6[0] = 93;
							num39 = 12 + 100;
							array6[1] = (byte)num39;
							num39 = 32 + 29;
							array6[1] = (byte)num39;
							num39 = 140 - 46;
							array6[1] = (byte)num39;
							array6[1] = 181;
							num39 = 129 - 43;
							array6[2] = (byte)num39;
							array6[2] = 88;
							num39 = 80 + 29;
							array6[2] = (byte)num39;
							num39 = 94 + 117;
							array6[2] = (byte)num39;
							num39 = 119 + 121;
							array6[2] = (byte)num39;
							array6[3] = 60;
							num39 = 229 - 76;
							array6[3] = (byte)num39;
							array6[3] = 154;
							array6[4] = 126;
							array6[4] = 80;
							array6[4] = 150;
							array6[4] = 156;
							array6[4] = 57;
							num39 = 48 + 27;
							array6[5] = (byte)num39;
							array6[5] = 124;
							array6[5] = 91;
							num39 = 245 - 81;
							array6[5] = (byte)num39;
							num39 = 107 - 74;
							array6[5] = (byte)num39;
							num39 = 242 - 80;
							array6[6] = (byte)num39;
							array6[6] = 109;
							array6[6] = 41;
							num39 = 30 + 41;
							array6[7] = (byte)num39;
							array6[7] = 218;
							num39 = 15 + 13;
							array6[7] = (byte)num39;
							num39 = 46 + 117;
							array6[7] = (byte)num39;
							array6[7] = 148;
							array6[7] = 108;
							array6[8] = 94;
							array6[8] = 94;
							num39 = 127 - 48;
							array6[8] = (byte)num39;
							array6[9] = 112;
							num39 = 163 - 54;
							array6[9] = (byte)num39;
							array6[9] = 251;
							num39 = 128 - 42;
							array6[10] = (byte)num39;
							array6[10] = 126;
							num39 = 106 - 63;
							array6[10] = (byte)num39;
							array6[11] = 139;
							num39 = 35 + 75;
							array6[11] = (byte)num39;
							array6[11] = 141;
							num39 = 170 - 84;
							array6[11] = (byte)num39;
							array6[12] = 173;
							num39 = 172 - 57;
							array6[12] = (byte)num39;
							array6[12] = 110;
							num39 = 95 + 89;
							array6[12] = (byte)num39;
							num39 = 38 + 120;
							array6[12] = (byte)num39;
							array6[12] = 5;
							array6[13] = 163;
							num39 = 39 + 14;
							array6[13] = (byte)num39;
							array6[13] = 194;
							num39 = 182 + 19;
							array6[13] = (byte)num39;
							num39 = 208 - 69;
							array6[14] = (byte)num39;
							array6[14] = 104;
							array6[14] = 160;
							array6[14] = 152;
							array6[14] = 136;
							num39 = 138 - 63;
							array6[14] = (byte)num39;
							num39 = 65 + 3;
							array6[15] = (byte)num39;
							array6[15] = 220;
							num39 = 147 - 49;
							array6[15] = (byte)num39;
							array6[15] = 241;
							byte[] array7 = array6;
							object obj5 = JiNGQrjW9ZMFkOxxwPqE();
							EiSRarjWD7bL6UeVrPDS(obj5, (CipherMode)1);
							ICryptoTransform val4 = (ICryptoTransform)NnQv0XjWkfe4j8gWUd72(obj5, array5, array7);
							Stream val5 = (Stream)JwEdqRjWVZMx6hC2XV38();
							CryptoStream val6 = new CryptoStream(val5, val4, (CryptoStreamMode)1);
							phr3hfjWYSNYfRF2boLU((object)val6, array3, 0, array3.Length);
							onitcCjWSDJ3sf9FXn9e((object)val6);
							VgKycTjWyG85rPyrw2TL(crcjLgMY3xc, VXem0ljW8cNHrBXwAaJk(f1gVqcjWcvLwGQZn2D1k(), nWxeTljW0R5SJZsIno4e(val5)));
							gcY4rSjWWa6AlvfvqBFf(val5);
							gcY4rSjWWa6AlvfvqBFf((object)val6);
							N5xtRLjWJMKwNej9r7gU(isi3yyjjHLD2e2CxV4Py);
							int num40 = 0;
							if (!t4aFPujyvfij3VXeQ57e())
							{
								num40 = 6;
							}
							while (true)
							{
								switch (num40)
								{
								default:
									if (num41 == 988)
									{
										num40 = num41;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch
						{
							int num42 = 1;
							if (t4aFPujyvfij3VXeQ57e())
							{
								num42 = 1;
							}
							while (true)
							{
								switch (num42)
								{
								default:
									if (num43 == 989)
									{
										num42 = num43;
										continue;
									}
									break;
								case 1:
									flag = true;
									num42 = 6;
									if (EqDaRojyEIE7xmUCqV13() == null)
									{
										num42 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 6;
					case 18:
						text2 = (string)bXDyWRjyGyJkknU4BN9T(ES2l1Bjyq1JCgyGS6gCk(typeof(LFHd1ojfYcRKGDVUDAUb).TypeHandle).Assembly);
						num3 = 7;
						if (EqDaRojyEIE7xmUCqV13() == null)
						{
							num3 = 11;
						}
						continue;
					case 5:
						val3 = null;
						num3 = 7;
						continue;
					case 3:
						num3 = 14;
						continue;
					case 0:
						return;
					case 8:
						if (CgCHpLjyicvsxvD9ZU1F(text2) == 0)
						{
							num3 = 12;
							continue;
						}
						val = null;
						num3 = 22;
						if (EqDaRojyEIE7xmUCqV13() == null)
						{
							num3 = 1;
						}
						continue;
					case 7:
						try
						{
							FileStream val2 = new FileStream(text2, (FileMode)3, (FileAccess)1, (FileShare)1);
							int num8 = 12;
							while (true)
							{
								int num18;
								switch (num8)
								{
								default:
									if (num25 != 50)
									{
										if (num25 == 1030)
										{
											goto IL_19b9;
										}
										goto case 39;
									}
									goto case 28;
								case 26:
									array = new byte[65536];
									num8 = 8;
									continue;
								case 17:
									num16 = 0;
									num8 = 6;
									continue;
								case 37:
									GXyYTOjWQPA2bVNNsQXI(val, val2, num23, array);
									num8 = 33;
									continue;
								case 3:
									num14 = Ax5llJjWU7KZ8EKH0uqZ(val2);
									num8 = 23;
									continue;
								case 2:
									if (num30 >= num23)
									{
										num18 = 50;
										if (EqDaRojyEIE7xmUCqV13() != null)
										{
											num18 = 5;
										}
										goto IL_19b5;
									}
									goto case 40;
								case 25:
									JJxq5ojWLbSt9nUQCq9y(val2, num11 + num16 * 40 + 16);
									num8 = 50;
									if (EqDaRojyEIE7xmUCqV13() == null)
									{
										num8 = 10;
									}
									continue;
								case 32:
									array2 = (byte[])oXX4I1jWAmMDfEYNcmVM(val3, (int)num20);
									num8 = 30;
									continue;
								case 9:
									if (num14 < num15)
									{
										num8 = 39;
										continue;
									}
									goto case 15;
								case 24:
									JJxq5ojWLbSt9nUQCq9y(val2, num17 + 32);
									num18 = 42;
									goto IL_19b5;
								case 34:
								case 41:
									num17 = DmIc0jjWooN8bfcqJkaf(Sg75GijWrtZkF8UsXaJD(val3), num12, num11, val3);
									num8 = 24;
									continue;
								case 20:
									JJxq5ojWLbSt9nUQCq9y(val2, Ax5llJjWU7KZ8EKH0uqZ(val2) + num30);
									num8 = 34;
									if (EqDaRojyEIE7xmUCqV13() == null)
									{
										num8 = 14;
									}
									continue;
								case 18:
									JJxq5ojWLbSt9nUQCq9y(val2, 360L);
									num8 = 34;
									continue;
								case 30:
									global::System.Array.Reverse<byte>(array2);
									num8 = 38;
									if (EqDaRojyEIE7xmUCqV13() != null)
									{
										num8 = 4;
									}
									continue;
								case 6:
								case 19:
									if (num16 >= num12)
									{
										num8 = 4;
										if (!t4aFPujyvfij3VXeQ57e())
										{
											num8 = 49;
										}
										continue;
									}
									goto case 25;
								case 0:
								case 7:
								case 14:
									if (num23 == 0)
									{
										num8 = 28;
										if (!t4aFPujyvfij3VXeQ57e())
										{
											num8 = 47;
										}
										continue;
									}
									goto case 3;
								case 11:
									num22 = (uint)bYD0W0jWmiyDlj54g1tm(num21 - num14, num23);
									num8 = 29;
									if (EqDaRojyEIE7xmUCqV13() != null)
									{
										num8 = 46;
									}
									continue;
								case 12:
									val3 = new BinaryReader((Stream)(object)val2);
									num8 = 26;
									continue;
								case 27:
									JJxq5ojWLbSt9nUQCq9y(val2, 376L);
									num8 = 41;
									continue;
								case 1:
									JJxq5ojWLbSt9nUQCq9y(val2, num21);
									num8 = 32;
									continue;
								case 28:
								case 33:
									num16++;
									num8 = 44;
									if (t4aFPujyvfij3VXeQ57e())
									{
										num8 = 19;
									}
									continue;
								case 39:
									num30 = (uint)(num15 - num14);
									num8 = 2;
									continue;
								case 4:
									KlfiXAjW7xsDbKaAuAb9(val, new byte[0], 0, 0);
									num8 = 33;
									if (t4aFPujyvfij3VXeQ57e())
									{
										num8 = 1;
									}
									continue;
								case 38:
									try
									{
										flag = !gWIoTrjWBJ9JttiQuwvs(crcjLgMY3xc, qXUAXxjWIej2iCjnj4O7(val), text, array2);
										int num26 = 0;
										if (!t4aFPujyvfij3VXeQ57e())
										{
											num26 = 6;
										}
										while (true)
										{
											switch (num26)
											{
											default:
												if (num27 == 988)
												{
													num26 = num27;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									catch
									{
										int num28 = 2;
										if (EqDaRojyEIE7xmUCqV13() == null)
										{
											num28 = 0;
										}
										while (true)
										{
											switch (num28)
											{
											default:
												if (num29 == 988)
												{
													num28 = num29;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									break;
								case 40:
									num23 -= num30;
									num8 = 20;
									continue;
								case 29:
									GXyYTOjWQPA2bVNNsQXI(val, val2, num22, array);
									num8 = 16;
									continue;
								case 8:
									GXyYTOjWQPA2bVNNsQXI(val, val2, 152u, array);
									num8 = 36;
									if (EqDaRojyEIE7xmUCqV13() == null)
									{
										num8 = 5;
									}
									continue;
								case 16:
									num23 -= num22;
									num18 = 7;
									goto IL_19b5;
								case 23:
									if (num21 > num14)
									{
										num8 = 31;
										if (!t4aFPujyvfij3VXeQ57e())
										{
											num8 = 29;
										}
										continue;
									}
									goto case 9;
								case 36:
									JJxq5ojWLbSt9nUQCq9y(val2, num13);
									num8 = 17;
									continue;
								case 10:
									num23 = Sg75GijWrtZkF8UsXaJD(val3);
									num8 = 35;
									continue;
								case 15:
								case 31:
									if (num14 >= num15)
									{
										num18 = 37;
										goto IL_19b5;
									}
									goto case 11;
								case 21:
									JJxq5ojWLbSt9nUQCq9y(val2, num24);
									num8 = 0;
									if (EqDaRojyEIE7xmUCqV13() != null)
									{
										num8 = 5;
									}
									continue;
								case 35:
									num24 = Sg75GijWrtZkF8UsXaJD(val3);
									num18 = 21;
									goto IL_19b5;
								case 13:
									num15 = num21 + num20;
									num8 = 24;
									if (EqDaRojyEIE7xmUCqV13() == null)
									{
										num8 = 36;
									}
									continue;
								case 42:
								{
									uint num19 = Sg75GijWrtZkF8UsXaJD(val3);
									num20 = Sg75GijWrtZkF8UsXaJD(val3);
									num21 = DmIc0jjWooN8bfcqJkaf(num19, num12, num11, val3);
									num8 = 13;
									continue;
								}
								case 5:
								{
									bool num9 = GAWjRijWC2qcSbI1oBoh(val3) != 523;
									int num10 = (num9 ? 96 : 112);
									JJxq5ojWLbSt9nUQCq9y(val2, 152L);
									QGvB3DjW4E1LBZFLecGC(val2, array, 0, num10);
									array[64] = 0;
									array[65] = 0;
									array[66] = 0;
									array[67] = 0;
									LQ6wO2jWh5OonQWp3QD3(val, array, 0, num10);
									QGvB3DjW4E1LBZFLecGC(val2, array, 0, 128);
									array[32] = 0;
									array[33] = 0;
									array[34] = 0;
									array[35] = 0;
									array[36] = 0;
									array[37] = 0;
									array[38] = 0;
									array[39] = 0;
									LQ6wO2jWh5OonQWp3QD3(val, array, 0, 128);
									num11 = Ax5llJjWU7KZ8EKH0uqZ(val2);
									JJxq5ojWLbSt9nUQCq9y(val2, 134L);
									num12 = GAWjRijWC2qcSbI1oBoh(val3);
									JJxq5ojWLbSt9nUQCq9y(val2, num11);
									GXyYTOjWQPA2bVNNsQXI(val, val2, (uint)(num12 * 40), array);
									num13 = Ax5llJjWU7KZ8EKH0uqZ(val2);
									if (num9)
									{
										num8 = 18;
										if (!t4aFPujyvfij3VXeQ57e())
										{
											num8 = 34;
										}
										continue;
									}
									goto case 27;
								}
								case 22:
									break;
									IL_19b9:
									num8 = num25;
									continue;
									IL_19b5:
									num25 = num18;
									goto IL_19b9;
								}
								break;
							}
						}
						catch
						{
							int num31 = 1;
							if (!t4aFPujyvfij3VXeQ57e())
							{
								num31 = 4;
							}
							while (true)
							{
								switch (num31)
								{
								default:
									if (num32 == 989)
									{
										num31 = num32;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_20ef;
								}
								flag = true;
								num31 = 1;
								if (t4aFPujyvfij3VXeQ57e())
								{
									num31 = 0;
								}
								continue;
								end_IL_20ef:
								break;
							}
						}
						goto case 3;
					case 12:
						return;
					case 17:
						if (crcjLgMY3xc != null)
						{
							return;
						}
						num3 = 6;
						if (EqDaRojyEIE7xmUCqV13() == null)
						{
							num3 = 16;
						}
						continue;
					case 1:
						text = null;
						num = 25;
						if (EqDaRojyEIE7xmUCqV13() != null)
						{
							num = 2;
						}
						break;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Stream zs4jf5FalFp()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return (Stream)new MemoryStream();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] qhfjf6Uc8k1(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		FileStream val = new FileStream((string)P_0, (FileMode)3, (FileAccess)1, (FileShare)1);
		try
		{
			int num = 0;
			int num2 = (int)((Stream)val).Length;
			byte[] array = new byte[num2];
			while (num2 > 0)
			{
				int num3 = ((Stream)val).Read(array, num, num2);
				num += num3;
				num2 -= num3;
			}
			return array;
		}
		finally
		{
			((global::System.IDisposable)val)?.Dispose();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object YvjjfR7qDhq(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (File.Exists(((Assembly)P_0).Location))
			{
				return ((Assembly)P_0).Location;
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(((object)((Assembly)P_0).GetName().CodeBase).ToString().Replace("file:///", "")))
			{
				return ((object)((Assembly)P_0).GetName().CodeBase).ToString().Replace("file:///", "");
			}
		}
		catch
		{
		}
		try
		{
			if (File.Exists(P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
				.ToString()))
			{
				return P_0.GetType().GetProperty("Location").GetValue(P_0, new object[0])
					.ToString();
			}
		}
		catch
		{
		}
		return "";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] pIBjfwJwxSQ(object P_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return ((MemoryStream)P_0).ToArray();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] RXIjfeL46qe()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] JBxjfPceSnU()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void fSDjfx2CBiK(object P_0)
	{
		object[] array = new object[1];
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string yjMjfFekXfb(int P_0)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (((global::System.Array)T4ajLlKIvxj).Length == 0)
		{
			xQQjLKODyyb = new List<string>();
			NG5jLHWNKsU = new List<int>();
			fSDjfx2CBiK(((global::System.Type)(object)IntrospectionExtensions.GetTypeInfo(global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557474)))).Assembly.GetManifestResourceStream("PkSpDrjXErrSdHxCbYmD.CtAQnPjX2axFRoPHwiZY"));
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}
		lock (pndjLd6ORW9)
		{
			int num = BitConverter.ToInt32((byte[])T4ajLlKIvxj, P_0);
			if (num < NG5jLHWNKsU.Count && NG5jLHWNKsU[num] == P_0)
			{
				return xQQjLKODyyb[num];
			}
			try
			{
				byte[] array = new byte[num];
				global::System.Array.Copy((global::System.Array)T4ajLlKIvxj, P_0 + 4, (global::System.Array)array, 0, num);
				string text = Encoding.Unicode.GetString(array, 0, array.Length);
				xQQjLKODyyb.Add(text);
				NG5jLHWNKsU.Add(P_0);
				global::System.Array.Copy((global::System.Array)BitConverter.GetBytes(xQQjLKODyyb.Count - 1), 0, (global::System.Array)T4ajLlKIvxj, P_0, 4);
				return text;
			}
			catch
			{
			}
		}
		return "";
	}

	[MethodImpl((MethodImplOptions)8)]
	private LFHd1ojfYcRKGDVUDAUb(byte[] P_0, byte[] P_1)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] nnMjfsr2AZu(byte[] P_0)
	{
		if (P_0.Length == 0)
		{
			return new byte[0];
		}
		int num = P_0.Length % 4;
		int num2 = P_0.Length / 4;
		byte[] array = new byte[P_0.Length];
		int num3 = ((global::System.Array)tuljLOiQw6S).Length / 4;
		uint num4 = 0u;
		uint num5 = 0u;
		uint num6 = 0u;
		if (num > 0)
		{
			num2++;
		}
		uint num7 = 0u;
		for (int i = 0; i < num2; i++)
		{
			int num8 = i % num3;
			int num9 = i * 4;
			num7 = (uint)(num8 * 4);
			num5 = (uint)((((short[])tuljLOiQw6S)[num7 + 3] << 24) | (((short[])tuljLOiQw6S)[num7 + 2] << 16) | (((short[])tuljLOiQw6S)[num7 + 1] << 8) | ((short[])tuljLOiQw6S)[num7]);
			if (i == num2 - 1 && num > 0)
			{
				num6 = 0u;
				uint num10 = 255u;
				int num11 = 0;
				for (int j = 0; j < num; j++)
				{
					if (j > 0)
					{
						num6 <<= 8;
					}
					num6 |= (uint)((short[])(object)P_0)[P_0.Length - (1 + j)];
				}
				num4 += num5;
				num4 += qDYjfTWlBeG(num4);
				uint num12 = num4 ^ num6;
				for (int k = 0; k < num; k++)
				{
					if (k > 0)
					{
						num10 <<= 8;
						num11 += 8;
					}
					array[num9 + k] = (byte)((num12 & num10) >> num11);
				}
			}
			else
			{
				num7 = (uint)num9;
				num6 = (uint)((((short[])(object)P_0)[num7 + 3] << 24) | (((short[])(object)P_0)[num7 + 2] << 16) | (((short[])(object)P_0)[num7 + 1] << 8) | ((short[])(object)P_0)[num7]);
				num4 += num5;
				num4 += qDYjfTWlBeG(num4);
				uint num13 = num4 ^ num6;
				array[num9] = (byte)(num13 & 0xFF);
				array[num9 + 1] = (byte)((num13 & 0xFF00) >> 8);
				array[num9 + 2] = (byte)((num13 & 0xFF0000) >> 16);
				array[num9 + 3] = (byte)((num13 & 0xFF000000u) >> 24);
			}
		}
		return array;
	}

	[MethodImpl((MethodImplOptions)8)]
	private uint qDYjfTWlBeG(uint P_0)
	{
		uint num = P_0;
		uint num2 = 973202305u;
		_ = 668931134;
		uint num3 = 1582787682u;
		uint num4 = 1577548636u;
		uint num5 = 332884210u;
		ulong num6 = num4 * 1313243236;
		num6 |= 1;
		long num7 = num3 * num3;
		num3 = (uint)num6;
		ulong num8 = 1907532890 * num4;
		if (num8 == 0L)
		{
			num8--;
		}
		_ = num7 * num7;
		num2 = (uint)(-502326134 - num3);
		ulong num9 = num3 * 183835789;
		num9 |= 1;
		_ = num4 * num4;
		num4 = (uint)num9;
		uint num10 = ((num5 >> 6) | (num5 << 26)) ^ num3;
		uint num11 = num10 & 0xF0F0F0F;
		num5 = ((num10 & 0xF0F0F0F0u) >> 4) | (num11 << 4);
		num ^= num << 3;
		num += num2;
		num ^= num << 11;
		num += num4;
		num ^= num >> 27;
		num += num5;
		return (((num2 << 11) - num3) ^ num4) - num;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string kOHjfNfDJrH(object P_0)
	{
		"FeH2YiVdPPfPIDb2m".Trim();
		byte[] array = Convert.FromBase64String((string)P_0);
		return Encoding.Unicode.GetString(array, 0, array.Length);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] VXAjfMrEKQZ(object P_0)
	{
		byte[] array = new byte[32];
		RuntimeHelpers.InitializeArray((global::System.Array)array, default(RuntimeFieldHandle));
		byte[] array2 = new byte[16];
		RuntimeHelpers.InitializeArray((global::System.Array)array2, default(RuntimeFieldHandle));
		return ((LFHd1ojfYcRKGDVUDAUb)new LFHd1ojfYcRKGDVUDAUb(array, array2)).nnMjfsr2AZu((byte[])P_0);
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] xK4jfpX45vJ()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] Pa0jfuH2l0f()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[SpecialName]
	private static nint GttY3rEXPn()
	{
		if (muMjL6VLTWC == (nint)global::System.IntPtr.Zero)
		{
			muMjL6VLTWC = ot8jfG5ueSa("kernel ".Trim() + "32.dll");
		}
		return muMjL6VLTWC;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int KC5jfau2T3u(nint P_0, int P_1, int P_2, ref int P_3)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (omKjLNWIIdo == null)
		{
			omKjLNWIIdo = (im4DEajjmDbH4RAHrpX4)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Virtual ".Trim() + "Protect"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557485)));
		}
		return omKjLNWIIdo(P_0, P_1, P_2, ref P_3);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static nint uGMjf17imFx(nint P_0, uint P_1, uint P_2, uint P_3)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (CosjLMlwmLt == null)
		{
			CosjLMlwmLt = (diIEQEjj7ZNCGMkXgHpw)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Virtual ".Trim() + "Alloc"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557486)));
		}
		return CosjLMlwmLt(P_0, P_1, P_2, P_3);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static nuint ldDjf3M86wX(nuint P_0, out iqcKO2jjVEf134wvf7hy P_1, nuint P_2)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (Ve9jLp3fHkt == null)
		{
			Ve9jLp3fHkt = (naQXi8jjAYM6tRCHr2Bm)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Virtual ".Trim() + "Query"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557487)));
		}
		return Ve9jLp3fHkt(P_0, out P_1, P_2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static nint bZQjfvV8rqu(uint P_0, int P_1, uint P_2)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (zYgjLuKXwKt == null)
		{
			zYgjLuKXwKt = (jIKkyKjjIEGW8vTQ5nLE)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Open ".Trim() + "Process"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557488)));
		}
		return zYgjLuKXwKt(P_0, P_1, P_2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int tMPjfESXUrp(nint P_0, nint P_1, [In][Out] byte[] P_2, uint P_3, out nint P_4)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		if (faQjLajAmEX == null)
		{
			faQjLajAmEX = (zDv1B3jjB40vivxGoYMP)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Write ".Trim() + "Process ".Trim() + "Memory"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557489)));
		}
		return faQjLajAmEX(P_0, P_1, P_2, P_3, out P_4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int Jb5jf2hnfq6(nint P_0)
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		if (lcojL17gVif == null)
		{
			lcojL17gVif = (VkWG4pjjguHbJSX6JLfa)Marshal.GetDelegateForFunctionPointer((global::System.IntPtr)RefjfqkvCvy(GttY3rEXPn(), "Close ".Trim() + "Handle"), global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557490)));
		}
		return lcojL17gVif(P_0);
	}

	[DllImport("kernel32", CharSet = (CharSet)2, EntryPoint = "GetProcAddress")]
	public static extern nint RefjfqkvCvy(nint P_0, string P_1);

	[DllImport("kernel32", EntryPoint = "LoadLibrary")]
	public static extern nint ot8jfG5ueSa(string P_0);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "getJit", SetLastError = true)]
	public static extern nint CKvjfitVtZX();

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mmap", SetLastError = true)]
	public static extern nint lt2jfn9MF5R(nint P_0, nint P_1, int P_2, int P_3, int P_4, nint P_5);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mmap", SetLastError = true)]
	public static extern nint jYbjfzZlBwG(nint P_0, nint P_1, int P_2, int P_3, int P_4, nint P_5);

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mmap", SetLastError = true)]
	public static extern nint yiGjLb9bWQg(nint P_0, nint P_1, int P_2, int P_3, int P_4, nint P_5);

	[MethodImpl((MethodImplOptions)8)]
	private static nint HCTjLX1QjwR(nint P_0, nint P_1, int P_2, int P_3, int P_4, nint P_5)
	{
		try
		{
			if (KI7jLGTtjft)
			{
				return jYbjfzZlBwG(P_0, P_1, P_2, P_3, P_4, P_5);
			}
			return yiGjLb9bWQg(P_0, P_1, P_2, P_3, P_4, P_5);
		}
		catch
		{
			return lt2jfn9MF5R(P_0, P_1, P_2, P_3, P_4, P_5);
		}
	}

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mprotect", SetLastError = true)]
	private static extern int KtjjLflj3f5(nint P_0, nint P_1, int P_2);

	[DllImport("libSystem", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mprotect", SetLastError = true)]
	private static extern int JBYjLLyxIFw(nint P_0, nint P_1, int P_2);

	[DllImport("libc", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "mprotect", SetLastError = true)]
	private static extern int QmJjLjRlVLH(nint P_0, nint P_1, int P_2);

	[MethodImpl((MethodImplOptions)8)]
	private static int U8CjLZNCHqP(nint P_0, nint P_1, int P_2)
	{
		try
		{
			if (KI7jLGTtjft)
			{
				return JBYjLLyxIFw(P_0, P_1, P_2);
			}
			return QmJjLjRlVLH(P_0, P_1, P_2);
		}
		catch
		{
			return KtjjLflj3f5(P_0, P_1, P_2);
		}
	}

	[DllImport("libclrjit", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "getpagesize", SetLastError = true)]
	private static extern int QEkjL90Auhb();

	[DllImport("libSystem", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "getpagesize", SetLastError = true)]
	private static extern int LwrjLDZBoj9();

	[DllImport("libc", BestFitMapping = true, CallingConvention = (CallingConvention)3, EntryPoint = "getpagesize", SetLastError = true)]
	private static extern int jMnjLkYUmXL();

	[DllImport("libSystem", EntryPoint = "mincore")]
	private static extern int mAGjLVVR2W1(nint P_0, nuint P_1, byte[] P_2);

	[DllImport("libc", EntryPoint = "mincore")]
	private static extern int lAhjLYGx0fm(nint P_0, nuint P_1, byte[] P_2);

	[MethodImpl((MethodImplOptions)8)]
	private static List<nint> SqyjLSyl1yl()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		List<nint> val = new List<nint>();
		string[] array = File.ReadAllLines("/proc/self/maps");
		foreach (string obj in array)
		{
			Guid moduleVersionId = global::System.Type.GetTypeFromHandle(RWlGNCjjxJDLCfPvdVYI.gSZDB3T85ym(33557475)).Assembly.ManifestModule.ModuleVersionId;
			long num = BitConverter.ToInt64(moduleVersionId.ToByteArray(), 0);
			long num2 = BitConverter.ToInt64(Enumerable.ToArray<byte>(Enumerable.Reverse<byte>((global::System.Collections.Generic.IEnumerable<byte>)BitConverter.GetBytes(num))), 0);
			string[] array2 = obj.Split(' ', (StringSplitOptions)0);
			string text = array2[0];
			if (array2[1][0] != 'r')
			{
				continue;
			}
			long num3 = Convert.ToInt64(text.Split('-', (StringSplitOptions)0)[0], 16);
			if (Convert.ToInt64(text.Split('-', (StringSplitOptions)0)[1], 16) - num3 < 72)
			{
				continue;
			}
			nint num4 = new global::System.IntPtr(num3);
			nint num5 = new global::System.IntPtr(num3 + 64);
			if (!aiTjL0KrTrW(num5, 8))
			{
				continue;
			}
			try
			{
				long num6 = Marshal.ReadInt64((global::System.IntPtr)num5);
				if (num6 == num || num6 == num2)
				{
					val.Add(num4);
				}
			}
			catch
			{
			}
		}
		return val;
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static nint[] jTjjLcpiI3P(object P_0, int P_1, int P_2, int P_3)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool aiTjL0KrTrW(nint P_0, int P_1)
	{
		bool flag = false;
		iqcKO2jjVEf134wvf7hy iqcKO2jjVEf134wvf7hy = default(iqcKO2jjVEf134wvf7hy);
		nuint num = new nuint(((nuint)iqcKO2jjVEf134wvf7hy.yEujjYN70mU).ToUInt64() + (ulong)((global::System.IntPtr)iqcKO2jjVEf134wvf7hy.mfvjj0GWeIV).ToInt64());
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint DixjL848ROV(nint P_0, nint P_1, ref fSkbr6jjJ1jFgHS1jU4c P_2, uint P_3, nint P_4, ref uint P_5)
	{
		xVQjLiRPtRH = P_2.X3kjj4ZaRfV;
		if (P_1 != (nint)global::System.IntPtr.Zero)
		{
			return boAjLzmDAXv(P_0, P_1, ref P_2, P_3, P_4, ref P_5);
		}
		return 0u;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint McKjLyPEbGn(nint P_0, nint P_1, ref fSkbr6jjJ1jFgHS1jU4c P_2, uint P_3, nint P_4, ref uint P_5)
	{
		xVQjLiRPtRH = P_2.X3kjj4ZaRfV;
		if (P_1 != (nint)global::System.IntPtr.Zero)
		{
			return oXnjLnB85yK(P_0, P_1, ref P_2, P_3, P_4, ref P_5);
		}
		return 0u;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void WRJjLW46qrx()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object DfFidbjyNj3TaGCCNFnw(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void FD60KijyMdFdwguNDAas(object P_0, long P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long V7013wjypwyewrDfrGE5(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object YlTJtTjyuMbDs8hTWsI7(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object Bi1UmQjyaM3diIvBIBaB(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool isnYY0jy1f9UFlvICGeu(object P_0, object P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void udmLOIjy3IaY6VwGlCpp(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool LQeQrSjyscLlTfxa3KS4()
	{
		return (object)null == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object AqoG4gjyTtvAuoEa3edy()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void LCaiWdjy2VPvbD2bSu5W(bool P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type ES2l1Bjyq1JCgyGS6gCk(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object bXDyWRjyGyJkknU4BN9T(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int CgCHpLjyicvsxvD9ZU1F(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object A0BgEUjyn3r8qJJgbOKR()
	{
		return SHA1.Create();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object MmwxK9jyzFyfhqFd8Qpi(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VuoOMYjWbyBEl6Y613dM(object P_0)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object D0sRkVjWXC72BU9JQd1d(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object WCGVbFjWfe0CrU6bQCqw(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void JJxq5ojWLbSt9nUQCq9y(object P_0, long P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long L9Kg0hjWjqIddM1q5G1U(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object RjMamhjWZ4H2p75LvQUP(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object JiNGQrjW9ZMFkOxxwPqE()
	{
		return QIVjfgL0IKK();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void EiSRarjWD7bL6UeVrPDS(object P_0, CipherMode P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object NnQv0XjWkfe4j8gWUd72(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object JwEdqRjWVZMx6hC2XV38()
	{
		return zs4jf5FalFp();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void phr3hfjWYSNYfRF2boLU(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void onitcCjWSDJ3sf9FXn9e(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object f1gVqcjWcvLwGQZn2D1k()
	{
		return Encoding.UTF8;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object nWxeTljW0R5SJZsIno4e(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object VXem0ljW8cNHrBXwAaJk(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void VgKycTjWyG85rPyrw2TL(object P_0, object P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void gcY4rSjWWa6AlvfvqBFf(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void N5xtRLjWJMKwNej9r7gU(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void GXyYTOjWQPA2bVNNsQXI(object P_0, object P_1, uint P_2, object P_3)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ushort GAWjRijWC2qcSbI1oBoh(object P_0)
	{
		return default(ushort);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int QGvB3DjW4E1LBZFLecGC(object P_0, object P_1, int P_2, int P_3)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void LQ6wO2jWh5OonQWp3QD3(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long Ax5llJjWU7KZ8EKH0uqZ(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint Sg75GijWrtZkF8UsXaJD(object P_0)
	{
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint DmIc0jjWooN8bfcqJkaf(uint P_0, int P_1, long P_2, object P_3)
	{
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long bYD0W0jWmiyDlj54g1tm(long P_0, long P_1)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object KlfiXAjW7xsDbKaAuAb9(object P_0, object P_1, int P_2, int P_3)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object oXX4I1jWAmMDfEYNcmVM(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object qXUAXxjWIej2iCjnj4O7(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool gWIoTrjWBJ9JttiQuwvs(object P_0, object P_1, object P_2, object P_3)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void mLMm3XjWgRMnB2aTQdNn(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object D9RLypjWlsCtS7Oubn9m(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object xGbEOSjWdjeUi8ELymmW(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object EACPPDjWK3wdQTP62dvR(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool t4aFPujyvfij3VXeQ57e()
	{
		return (object)null == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object EqDaRojyEIE7xmUCqV13()
	{
		return null;
	}

	static int vNofd1DB2AIXZYwGhcrR()
	{
		return 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void pUEGCvDBik5UUfNUY3xK()
	{
		c4jjfCx0LZp();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OSPlatform cJaXQcDBnB7fgT5SXBde()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return OSPlatform.Windows;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JbjTeSDBzKOuZKiFGtRk(OSPlatform P_0)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OSPlatform J6umc3DgbrMPeQBc72gn()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return OSPlatform.Linux;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OSPlatform vPpO5eDgXVH08VulcpI1(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return default(OSPlatform);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OSPlatform ESBQyNDgfvUShhfmFQDq()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return OSPlatform.OSX;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int lVLSFUDgLSYQgGAxquP5()
	{
		return global::System.IntPtr.Size;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type yrFbSrDgj4bbQFvWdNfB(object P_0, bool P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool rQxAfRDgZBDTkWltNtXE(global::System.Type P_0, global::System.Type P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object GCaFxYDg9LyS8TbsPv9h()
	{
		return Process.GetCurrentProcess();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object vve20UDgDuQHjFi31kd5(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object VlYWTxDgkH5boo8n77XX(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object TUoMdyDgVmKpx6FV9j8P(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object QYEOLcDgY3d5L0p8HjwI(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object YgEXVLDgSNyx6Zg3P5Xw(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BSKIpCDgcqt4TC5npcdf(object P_0, object P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object dQsdArDg0xnrig8UviOZ(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int dHH47hDg8mktqEhcZ5qt(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int PPyJUeDgyknav4S6ipgA(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int HeeCDkDgWOQmxnIGdWu8(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int zspyn0DgJOt1FiHJ8QuL(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool srIBHXDgQIjFFi5G60I5(object P_0, object P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool XnvdFkDgCCJ0AgDX6SMr(object P_0, object P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool R85PjwDg4EJIJi21cKKS(object P_0)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void uYXQkYDghuvbL58sJp2U(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type MVn4ueDgUfrQyGuRJccG(RuntimeTypeHandle P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object JjF1KMDgrpI9yfYgJgV7(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object WZljPkDgoCU7XQoAwQLd(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int qbmc4XDgmLYZvpKG1Ftd(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object YSlFFDDg79rOlM9hn8Qh(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object mNMraEDgAE92pfWyJVBR(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void PmbRxpDgI0CU02ptI7Uh(object P_0, long P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long HglwinDgBDxUIsVDelBe(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object vQTyBhDggK2b0ODnxPI8(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object Dphfo1DglEEQPZPkaXFI(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Wf9lvmDgdjUtAKrgIxRl(object P_0, int P_1, int P_2)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int a6Oiv2DgKyAv2e7wxl5w(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object FlpconDgH025FpSXtj32()
	{
		return QIVjfgL0IKK();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void X8c3gADgtylPb79S4IHA(object P_0, CipherMode P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object IeZg44DgODkodnCkICsA(object P_0, object P_1, object P_2)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void fE8bvPDg5TNJD9H6wKHb(object P_0, object P_1, int P_2, int P_3)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void UX36qqDg63LTNkVLlkgn(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object IVPnEnDgRIxPXQcteVkX(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void q7ryGdDgwKB8O3W0B7XO(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ecRgmYDgeugCy734wyQE(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object DrPNNYDgPbTl5Kg86FRM(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object nDbPaaDgx5lSImDEDMj2(object P_0, int P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object bxaFfSDgFRMYm7Qoco6Y(object P_0, int P_1, int P_2, int P_3)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long FRMkh1DgsIQ0uSmIkZtM(object P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int iZV8t7DgTYDSsEQjvsLE(nint P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static short c30HKCDgNflVjvdJvY0p(nint P_0)
	{
		return default(short);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int QAE2YLDgMIMXrKIKkbpo(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint YoYNT5DgpYQvmFgfSJVa(uint P_0, int P_1, uint P_2)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object v33ylLDgulAq0ewOhCJo(object P_0, FileMode P_1, FileAccess P_2)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object AI8d8uDgaXA4E6YiZCj3(int P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint y4iX6gDg165dFGO0xnv5(nint P_0)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int b4f907Dg3taKjOFdOh9L()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int yfZ8ZGDgvinKikqEX6Ja(nint P_0, nint P_1, int P_2)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long mvi789DgEQUSnCQqksEU(object P_0, long P_1, SeekOrigin P_2)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void KLcWAyDg2QCN6rWLJITe(nint P_0, int P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int Hi2L0gDgqdbovoy9Y74I(nint P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void bSxkxoDgGV9WxTKN2Ucq()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void gk8IvMDginVCPAuKiDZV(object P_0, byte P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void OcLxR4Dgnyn8famFWfoV(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint CpByIbDgz2v2wyYRllKl(nint P_0, uint P_1, uint P_2, uint P_3)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void RB77a5DlbwgEanoWxwfV(object P_0, int P_1, nint P_2, int P_3)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint GFhPCMDlX9n12V81iLfD(nint P_0, nint P_1, int P_2, int P_3, int P_4, nint P_5)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void JxuXnfDlfZyMXR0e8VyA(object P_0, object P_1, object P_2)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object UBLmtoDlLj0gPmtYFGPd()
	{
		return Encoding.UTF8;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object sqg6IODljNq90OcTqvba(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object L6OJp1DlZGAIHNsLkyD9(nint P_0, global::System.Type P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint YbsAGqDl9aZCfkKU0gnB(object P_0)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static long ruqAeCDlDw0mmPUNyvG3(nint P_0)
	{
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nint HASDkcDlkep4j2daVjq4(nint P_0, int P_1)
	{
		return default(nint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object DkPqVlDlVVUJ21pusoj1(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object GExQLKDlYKFYHIMlrjYS(global::System.Type P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object WIvOIsDlSDPxcSyscau1(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool iYtCE0DlcymVTPyQL4X4(object P_0, object P_1)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object tgmdVYDl0FoZfWFan6Xd(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object royylZDl86hwhf26q6hj(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int q6C5ttDlyHZtlkkI2IfC(object P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ModuleHandle DMeTT4DlWEpdYJj9p5nM(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return default(ModuleHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type oN9WXuDlJWtNWYoOHEkj(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object V5NBbTDlQGAuoWuGtnIR(object P_0, object P_1)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object M7iwsqDlCrxVPbFJUHpK(long P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void jSyN7KDl4cDH3IZVO89q(object P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RuntimeMethodHandle XWLFwQDlhR1M3POSPKGQ(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return default(RuntimeMethodHandle);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void lXej5GDlUInvdQ57JLaH(RuntimeMethodHandle P_0)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Architecture h1N2uNDlrbBygwiB3op0()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return RuntimeInformation.ProcessArchitecture;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void ndRwi0DloifIkG7lEhm2(object P_0, RuntimeFieldHandle P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object fmMUx1DlmL76xjZWwvgT(object P_0)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int gOabbGDl7wXwxFcHgvOf(int P_0, int P_1)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int QJC1ryDlAV9GFrjDEDPQ(long P_0)
	{
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void sANGBPDlIp5KCCwJQ0qC(object P_0, int P_1, object P_2, int P_3, int P_4)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void nUiv1JDlBfpy21G2SYdN(nint P_0, nint P_1)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void Gw86TODlgJe3KYNnOew7(nint P_0, nint P_1)
	{
	}

	internal static bool oKnYhxDBqu9wegKhK5sm()
	{
		return (object)null == null;
	}

	internal static object Qd1bn5DBGOaGpnCEHidL()
	{
		return null;
	}
}

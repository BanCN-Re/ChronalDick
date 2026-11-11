using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace OCafisfciLUeKiM14YoD;

internal class yxP1KsfcGa5w7LC3JmL7
{
	private static object t6Ml00ZpJmtAFsrUp774;

	[MethodImpl((MethodImplOptions)8)]
	internal static string EdbfcnkO5vZ(object plaintext)
	{
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		long[] array = qPsf0LxTrLG((System.Text.Encoding.UTF8).GetBytes(((dynamic)(plaintext)).PadRight(32, '\0')));
		long[] key = qPsf0LxTrLG((System.Text.Encoding.UTF8).GetBytes("942894570397f6d1c9cca2535ad18a2b"));
		eOjf0XBEf4j(array, key);
		StringBuilder val = new StringBuilder(array.Length * 16);
		long[] array2 = array;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string? YUHfczXrfYc(object signed)
	{
		long[] data = default(long[]);
		rOUf0bv5XdN(data, qPsf0LxTrLG((System.Text.Encoding.UTF8).GetBytes("942894570397f6d1c9cca2535ad18a2b")));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void rOUf0bv5XdN(object data, object key)
	{
		int num = 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void eOjf0XBEf4j(object data, object key)
	{
		long num2 = default(long);
		long num = num2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long bKJf0f8ebCS(long sum, long first, long last, long index, long selector, object key)
	{
		return (((last >> 5) ^ (first << 2)) + ((first >> 3) ^ (last << 4))) ^ ((sum ^ first) + ((int)((uint[])key)[(index & 3) ^ selector] ^ last));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long[] qPsf0LxTrLG(object bytes)
	{
		int num = default(int);
		global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>((byte[])bytes, num, System.Math.Min(8, ((global::System.Array)bytes).Length - num));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dWeyTfZpQQbEBcAm4ukt()
	{
		return t6Ml00ZpJmtAFsrUp774 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static yxP1KsfcGa5w7LC3JmL7 Ok8vHPZpCM48BtBc8Y1p()
	{
		return (yxP1KsfcGa5w7LC3JmL7)t6Ml00ZpJmtAFsrUp774;
	}
}

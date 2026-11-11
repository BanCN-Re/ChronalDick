using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using SRJB8PfUDKmfEgvmwxvn;
using ePgxqefhipUwkK39mRLP;
using fDAldojjppXrctUVYOJn;
using mdXrpVf4xrJgmIWAd0EM;

namespace xMk5tkfUVNH7XY6TZJsA;

internal class SmeeQEfUk1LOYNogcnC0
{
	private static readonly object PCwfUoOlTxU;

	private static readonly object D0WfUm7ObSv;

	private static readonly object wUNfU7ABK7c;

	internal static object q2JJ3LZaDESHL3P8N4op;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool muFfUYNQ60J(byte reliability)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool p0UfUS3TBNb(byte reliability)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AWFfUcjiRFi(byte reliability)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static bool b6UfU08Ojcm(byte firstByte)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static bool BZxfU8Mkyww(object datagram, out List<ValueTuple<byte[], Jgaq6ef4PuO0JxER8Odt?>> frames)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static bool JE8fUyiVxvs(object datagram, [NotNullWhen(true)] out VRTBhBfhGNLMoKgoRIvW? packet)
	{
		packet = default(VRTBhBfhGNLMoKgoRIvW?);
		int num = default(int);
		Jgaq6ef4PuO0JxER8Odt? jgaq6ef4PuO0JxER8Odt = (Jgaq6ef4PuO0JxER8Odt)new Jgaq6ef4PuO0JxER8Odt(System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num))), System.Buffers.Binary.BinaryPrimitives.ReadUInt16BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num + 4))), System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num + 6))));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] J2IfUWHDgXh(object packet)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] nXqfUJNAIIn(uint sequenceNumber)
	{
		byte[] array = new byte[7];
		System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
		array[4] = (byte)sequenceNumber;
		array[5] = (byte)(sequenceNumber >> 8);
		array[6] = (byte)(sequenceNumber >> 16);
		return array;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] LIFfUQSyZsA(global::System.Collections.Generic.IReadOnlyList<ValueTuple<uint, uint>> records)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static bool bZsfUCoGGtM(object datagram, byte packetId, out List<ValueTuple<uint, uint>> records)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got I4
		records = default;
		int num = 3;
		int num2 = default(int);
		num2 = num2 + 1;
		*(int*)25 = (int)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref records);
		uint num3 = default(uint);
		uint num4 = default(uint);
		default(List<ValueTuple<uint, uint>>)!?.Add(new ValueTuple<uint, uint>(num3, num4));
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint KRyfU4MjPfl(object data, int offset)
	{
		return (uint)(((short[])data)[offset] | (((short[])data)[offset + 1] << 8) | (((short[])data)[offset + 2] << 16));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void BWwfUhE7wNC(object stream, uint value)
	{
		((dynamic)(stream)).WriteByte((byte)value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xNxQUvZakmuWWu9DulRe()
	{
		return q2JJ3LZaDESHL3P8N4op == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SmeeQEfUk1LOYNogcnC0 vlSJVTZaV7kvtQkuFnex()
	{
		return (SmeeQEfUk1LOYNogcnC0)q2JJ3LZaDESHL3P8N4op;
	}
}

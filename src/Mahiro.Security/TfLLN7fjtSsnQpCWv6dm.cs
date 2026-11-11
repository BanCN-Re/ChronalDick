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
	private static readonly object vsFfjFLT1en;

	private static readonly object GNufjsgMcuF;

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
		hWgTrufjTEdVmY6adQMn hWgTrufjTEdVmY6adQMn = default(hWgTrufjTEdVmY6adQMn);
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(((global::System.ReadOnlySpan<byte>)WvVfjwCPYPb(read, moduleAddress, moduleSize, hWgTrufjTEdVmY6adQMn.ThreadLocalKeyAddress, 4)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void hUbfjRi7dfy(Func<ulong, int, byte[]> read, object addresses, ulong moduleAddress, ulong moduleSize)
	{
		System.ArgumentNullException.ThrowIfNull(addresses, "addresses");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] WvVfjwCPYPb(Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, ulong address, int length)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong EbxfjekOnrj(ulong function, object code, int displacement, int end)
	{
		checked
		{
			return (ulong)(unchecked((long)function) + unchecked((long)end) + System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])code, displacement, 4))));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] q2dfjP8nxtF(Func<ulong, int, byte[]> read, ulong address, int length)
	{
		byte[] array = read.Invoke(address, length);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static InvalidDataException QvdfjxtxB0E(object reason)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		return new InvalidDataException(string.Concat("Python runtime initialization is not confirmed: ", (string)reason));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

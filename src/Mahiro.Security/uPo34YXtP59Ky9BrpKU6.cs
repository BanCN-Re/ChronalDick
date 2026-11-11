using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace mTXgbUXtxVyBxISd8ZTw;

sealed class uPo34YXtP59Ky9BrpKU6 : global::System.IDisposable
{
	private readonly uint[] B1qXtpJKaEc;

	private readonly byte[] NPyXtu5Hgm2;

	private int D3OXtaJXfCg;

	private bool tiuXt1RyLUy;

	internal static object ROML3NZ531qVtJIjGq0B;

	private static global::System.ReadOnlySpan<byte> Nonce
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "163 NetEase\n"u8;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal uPo34YXtP59Ky9BrpKU6(global::System.ReadOnlySpan<byte> key)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void aZfXtFRoGDv(global::System.Span<byte> data)
	{
		//IL_0029: Expected F4, but got I4
		int num = default(int);
		ref byte reference = ref data[num];
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref reference) = (int)(byte)(global::System.Runtime.CompilerServices.Unsafe.As<byte, short>(ref reference) ^ ((short[])(object)NPyXtu5Hgm2)[D3OXtaJXfCg++]);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void zdjXtsUOMLO()
	{
		//IL_0023: Expected I4, but got F8
		int num = default(int);
		global::System.Span<uint> span = default(global::System.Span<uint>);
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(MemoryExtensions.AsSpan<byte>(NPyXtu5Hgm2, num * 4), (uint)(int)global::System.Runtime.CompilerServices.Unsafe.As<uint, double>(ref span[num]));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void WfxXtTeARwj(global::System.Span<uint> state, int a, int b, int c, int d)
	{
		int num = 7;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint cXlXtNvTJWt(uint value, int count)
	{
		return (value << count) | (value >> 32 - count);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		System.Security.Cryptography.CryptographicOperations.ZeroMemory(MemoryMarshal.AsBytes<uint>(MemoryExtensions.AsSpan<uint>(B1qXtpJKaEc)));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool iY8OGgZ5vaeYVoCvZro7()
	{
		return ROML3NZ531qVtJIjGq0B == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uPo34YXtP59Ky9BrpKU6 oVuqydZ5EVqPglYEqXAy()
	{
		return (uPo34YXtP59Ky9BrpKU6)ROML3NZ531qVtJIjGq0B;
	}
}

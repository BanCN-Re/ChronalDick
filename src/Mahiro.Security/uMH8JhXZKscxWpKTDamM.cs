using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using WMO32gy5EZANSQKlHAx;
using fDAldojjppXrctUVYOJn;

namespace nrGXPUXZHtsh2lrZ9YQf;

internal sealed class uMH8JhXZKscxWpKTDamM
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_10
	{
		public static readonly __c_10 __9;

		public static Action<string> __9__1_0;

		internal static __c_10 kH6F3N9eSoVUf91AOoOL;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_10()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void cpifzlGrBC6(string message)
		{
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("java-rpc", message);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool coC2VJ9ec8NLoQqyVGsf()
		{
			return kH6F3N9eSoVUf91AOoOL == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_10 FeaYjS9e0cLZ6SsSypjH()
		{
			return kH6F3N9eSoVUf91AOoOL;
		}
	}

	private readonly Action<string> bSLXZRo6rh6;

	private static object Vu0ygOZAm1f3XGQp5dG0;

	[MethodImpl((MethodImplOptions)8)]
	internal uMH8JhXZKscxWpKTDamM(Action<string>? write = null)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void aQJXZtF0PPf(ushort eventId, global::System.ReadOnlySpan<byte> payload)
	{
		Action<string> obj = bSLXZRo6rh6;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 3);
		(defaultInterpolatedStringHandler).AppendLiteral("Java RPC 未知事件：sid=");
		defaultInterpolatedStringHandler.AppendFormatted<ushort>(eventId);
		(defaultInterpolatedStringHandler).AppendLiteral(" bytes=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(payload.Length);
		(defaultInterpolatedStringHandler).AppendLiteral(" sha256=");
		(defaultInterpolatedStringHandler).AppendFormatted(mchXZ6tAnaY(payload));
		obj.Invoke((defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void bDXXZOZhgiG(ushort eventId, int payloadLength, global::System.Exception exception)
	{
		Action<string> obj = bSLXZRo6rh6;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 3);
		(defaultInterpolatedStringHandler).AppendLiteral("Java RPC 事件格式无效：sid=");
		defaultInterpolatedStringHandler.AppendFormatted<ushort>(eventId);
		(defaultInterpolatedStringHandler).AppendLiteral(" bytes=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(payloadLength);
		(defaultInterpolatedStringHandler).AppendLiteral(" ");
		(defaultInterpolatedStringHandler).AppendLiteral("type=");
		(defaultInterpolatedStringHandler).AppendFormatted(((exception).GetType()).Name);
		obj.Invoke((defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void JWCXZ5HVeXc(int connectionId, global::System.Exception exception)
	{
		Action<string> obj = bSLXZRo6rh6;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(23, 2);
		(defaultInterpolatedStringHandler).AppendLiteral("Java RPC 连接结束：id=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(connectionId);
		(defaultInterpolatedStringHandler).AppendLiteral(" type=");
		(defaultInterpolatedStringHandler).AppendFormatted(((exception).GetType()).Name);
		obj.Invoke((defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string mchXZ6tAnaY(global::System.ReadOnlySpan<byte> payload)
	{
		return (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(payload))).ToLowerInvariant();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool o1gvN7ZA7MIUGrd6XCQ3()
	{
		return Vu0ygOZAm1f3XGQp5dG0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uMH8JhXZKscxWpKTDamM gRB899ZAAnknFP04fnoB()
	{
		return (uMH8JhXZKscxWpKTDamM)Vu0ygOZAm1f3XGQp5dG0;
	}
}

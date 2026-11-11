using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace JiZxakxSS0nXGmEGsIx;

internal sealed class sFdmXUxYyoXWv3ZJ7b6
{
	[CompilerGenerated]
	private class __O_46
	{
		public static Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> _0___Delay;

		private static __O_46 tuudar9AnrGotxjmyoLU;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool GcsIjI9AzfmdMNx7rdaZ()
		{
			return tuudar9AnrGotxjmyoLU == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_46 whLix89Ib15FtAsFq1H5()
		{
			return tuudar9AnrGotxjmyoLU;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_164
	{
		public static readonly __c_164 __9;

		public static Func<DateTimeOffset> __9__11_0;

		internal static __c_164 hJKmuI9IXyMTrSSOuRGT;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_164()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset SmdfGabcOjW()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return System.DateTimeOffset.UtcNow;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Qqirs39IfNgKmohZRVy9()
		{
			return hJKmuI9IXyMTrSSOuRGT == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_164 bhIjdO9ILO15pAGarEOc()
		{
			return hJKmuI9IXyMTrSSOuRGT;
		}
	}

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> in8xJntmhi;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> RLcxQY2Bym;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> axcxCkwuwy;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> yt2x4jXKg3;

	private static readonly TimeSpan wgbxhl8GA9;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> bNuxUXvQXc;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> l7lxr0GFXO;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> lLhxoRfGEV;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> q9xxmeweBc;

	private readonly Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> CVxx7dDmvr;

	private readonly Func<DateTimeOffset> oh0xAkR524;

	internal static object UNlIJ6Z4LEfF16u8Cr9G;

	[MethodImpl((MethodImplOptions)8)]
	internal extern sFdmXUxYyoXWv3ZJ7b6(global::System.Collections.Generic.IReadOnlyList<TimeSpan>? timeoutDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? networkDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? rateLimitDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? serverErrorDelays = null, Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task>? delay = null, Func<DateTimeOffset>? clock = null);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal extern global::System.Threading.Tasks.Task<HttpResponseMessage> KZ4xclyooM(string operationName, Func<CancellationToken, global::System.Threading.Tasks.Task<HttpResponseMessage>> send, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private extern global::System.Collections.Generic.IReadOnlyList<TimeSpan>? lUVx0TRQIn(HttpStatusCode? statusCode);

	[MethodImpl((MethodImplOptions)8)]
	private extern TimeSpan IRRx8WR0wL(HttpResponseMessage response, TimeSpan fallback);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool je6xyXFWy1(global::System.Collections.Generic.IReadOnlyList<TimeSpan> delays, int retryCount, out TimeSpan delay);

	[MethodImpl((MethodImplOptions)8)]
	private static extern global::System.Collections.Generic.IReadOnlyList<TimeSpan> XpVxWANTYR(global::System.Collections.Generic.IReadOnlyList<TimeSpan> delays, object parameterName);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool nvRPnMZ4jGOhMj84dBkT();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern sFdmXUxYyoXWv3ZJ7b6 ihZ4aBZ4ZZf8o7od00aD();
}

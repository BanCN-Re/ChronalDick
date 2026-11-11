using System;
using System.Collections.Concurrent;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Oq4bQvXcYX4iV1AeqLRj;
using fDAldojjppXrctUVYOJn;

namespace gETLGie5B8Kl6s8L6Wi;

sealed class Hxx6UOeOpmtQlZjCDUQ : global::System.IDisposable
{
	[CompilerGenerated]
	private class __O_43
	{
		public static Action<string> _0___Write;

		internal static __O_43 XA0hXA97N9tORIa8mDs6;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aoIv6M97MwuyGkErIhe9()
		{
			return XA0hXA97N9tORIa8mDs6 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_43 AjVXbP97pg8a6KE93x48()
		{
			return XA0hXA97N9tORIa8mDs6;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_159
	{
		public static readonly __c_159 __9;

		public static Action<global::System.Threading.Tasks.Task, object?> __9__13_0;

		private static __c_159 WwpeY097uFiIAxKhx58B;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_159()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void qeFfGdBTAff(global::System.Threading.Tasks.Task completedTask, object? state)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			ValueTuple<Hxx6UOeOpmtQlZjCDUQ, long> val = (ValueTuple<Hxx6UOeOpmtQlZjCDUQ, long>)state;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Fy6SpW97aXY1gZQvCFHd()
		{
			return WwpeY097uFiIAxKhx58B == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_159 wsg1Dj971ZMxASrFkmWb()
		{
			return WwpeY097uFiIAxKhx58B;
		}
	}

	private static readonly TimeSpan V55eRheEoL;

	private readonly object ydWew90SCP;

	private readonly object VGVee5uhPB;

	private readonly object YDbePWZGkH;

	private readonly ConcurrentDictionary<long, global::System.Threading.Tasks.Task> MgRex4hijx;

	private global::System.Threading.Tasks.Task? L7teF50W6l;

	private long AQFesLQtqf;

	private bool ehteTrwN10;

	private bool tm8eNJ5WSr;

	private static object iRb2W0ZCBbhantUYHjts;

	[MethodImpl((MethodImplOptions)8)]
	internal extern Hxx6UOeOpmtQlZjCDUQ(WYDdOqXcVFDYKpU0V6Ir portLease, Func<string, string, string, CancellationToken, global::System.Threading.Tasks.Task> authenticate);

	[MethodImpl((MethodImplOptions)8)]
	internal extern Hxx6UOeOpmtQlZjCDUQ(WYDdOqXcVFDYKpU0V6Ir portLease, Func<string, string, string, CancellationToken, global::System.Threading.Tasks.Task> authenticate, TimeSpan operationTimeout, Action<string> diagnosticSink);

	[MethodImpl((MethodImplOptions)8)]
	internal extern void Start();

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private extern global::System.Threading.Tasks.Task AcceptLoopAsync(CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	private extern void ebRe6oQKmC(TcpClient client, CancellationToken cancellationToken);

	[MethodImpl((MethodImplOptions)8)]
	public extern void Dispose();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool mEOnRKZCgxJLHNHPhSCs();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern Hxx6UOeOpmtQlZjCDUQ fOXgTUZClg97r1FL2geA();
}

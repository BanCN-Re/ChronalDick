using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using hrft8OfLNLZ7Z4DpQRng;
using vlySPQfDXr41U3apmG8t;

namespace gocgmhXaNEVTY3TuK58h;

sealed class lEoeMvXaTeLdjmLnoPyo : global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass15_0_1
	{
		public int clientId;

		public lEoeMvXaTeLdjmLnoPyo __4__this;

		internal static __c__DisplayClass15_0_1 cn13EDDjKIja35LR9R3x;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass15_0_1()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void QrdLDOy94fE(global::System.Threading.Tasks.Task completedTask)
		{
			int num = 1;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool CxZIXXDjHHXF3JMvw3yt()
		{
			return cn13EDDjKIja35LR9R3x == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass15_0_1 F403xyDjttG7amQRSVLE()
		{
			return cn13EDDjKIja35LR9R3x;
		}
	}

	private readonly object O3QXapZsEYC;

	private readonly ConcurrentDictionary<int, global::System.Threading.Tasks.Task> YgGXauDdtnp;

	private readonly object a66XaaaTtep;

	private readonly object aBVXa1EDXEr;

	private readonly object iqbXa3AaKkB;

	private global::System.Threading.Tasks.Task? frjXavVk05y;

	private int cAMXaEA7vx7;

	private int CP4Xa2r1eW5;

	private bool x47XaqNsA3n;

	private bool aP1XaG2fVqS;

	internal static object xwOJ9KZeMEmUqxbSFur8;

	internal bool HasConnectedClient
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Volatile.Read(ref CP4Xa2r1eW5) > 0;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void L35XaMOdNcZ(string name)
	{
		((BaoEPdfDb9UBNHGTLB79)aBVXa1EDXEr).Q8ofDfEZixl(name);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal lEoeMvXaTeLdjmLnoPyo(string serverHost, int serverPort, string playerName, VOLhfofLTIqAo1An6PXH protocolLog)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal int Start()
	{
		object obj = iqbXa3AaKkB;
		string component = "rpc";
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(22, 1);
		(defaultInterpolatedStringHandler).AppendLiteral("listener started port=");
		int num = default(int);
		defaultInterpolatedStringHandler.AppendFormatted<int>(num);
		((VOLhfofLTIqAo1An6PXH)obj).rIOfLu6OO2F(component, (defaultInterpolatedStringHandler).ToStringAndClear());
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task AcceptLoopAsync(CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AcceptLoopAsync_d__15 acceptLoopAsync_d__ = default(_AcceptLoopAsync_d__15);
		acceptLoopAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task HandleClientAsync(int clientId, object client, object messageHandler, object protocolLog, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_HandleClientAsync_d__16 handleClientAsync_d__ = default(_HandleClientAsync_d__16);
		handleClientAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		object obj = iqbXa3AaKkB;
		string component = "rpc";
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(33, 1);
		(defaultInterpolatedStringHandler).AppendLiteral("listener stopping active_clients=");
		defaultInterpolatedStringHandler.AppendFormatted<int>(YgGXauDdtnp.Count);
		((VOLhfofLTIqAo1An6PXH)obj).rIOfLu6OO2F(component, (defaultInterpolatedStringHandler).ToStringAndClear());
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool WKscOiZeppdmND0JDhI6()
	{
		return xwOJ9KZeMEmUqxbSFur8 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lEoeMvXaTeLdjmLnoPyo l4SkvhZeufol8htrJjH5()
	{
		return (lEoeMvXaTeLdjmLnoPyo)xwOJ9KZeMEmUqxbSFur8;
	}
}

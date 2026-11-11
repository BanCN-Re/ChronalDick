using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace JH2PRgfBX3Cp7KoXPjDd;

sealed class JVg10IfBbK4Oyl9dcIc6 : global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass7_0_9
	{
		public IPEndPoint local;

		internal static __c__DisplayClass7_0_9 LGlNNrD45P4BY9l1scoR;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass7_0_9()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool acrL8s3VcD6(IPAddress ip)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			return (ip).AddressFamily == (local).AddressFamily;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool w7Q04hD46YediLEMMxSa()
		{
			return LGlNNrD45P4BY9l1scoR == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass7_0_9 ChUHRiD4R4nvBAuigOS1()
		{
			return LGlNNrD45P4BY9l1scoR;
		}
	}

	private readonly object rfLfBLhHNiZ;

	[CompilerGenerated]
	private readonly UdpClient luEfBjpYAYv;

	internal static object eVyd3IZaGyBXLAeyp9tf;

	internal UdpClient Datagram
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return luEfBjpYAYv;
		}
	}

	internal NetworkStream Control
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((dynamic)(rfLfBLhHNiZ)).GetStream();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private JVg10IfBbK4Oyl9dcIc6(TcpClient control, UdpClient datagram)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<JVg10IfBbK4Oyl9dcIc6> kgOfBfbQhlP(object options, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_OpenAsync_d__7 openAsync_d__ = default(_OpenAsync_d__7);
		openAsync_d__.__t__builder = AsyncTaskMethodBuilder<JVg10IfBbK4Oyl9dcIc6>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task AuthenticateAsync(object stream, object options, CancellationToken token)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateAsync_d__8 authenticateAsync_d__ = default(_AuthenticateAsync_d__8);
		authenticateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		(Datagram).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool MbTEdGZai68fbZ8TMvKm()
	{
		return eVyd3IZaGyBXLAeyp9tf == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JVg10IfBbK4Oyl9dcIc6 yqDhsQZanNCSRJsC9VPj()
	{
		return (JVg10IfBbK4Oyl9dcIc6)eVyd3IZaGyBXLAeyp9tf;
	}
}

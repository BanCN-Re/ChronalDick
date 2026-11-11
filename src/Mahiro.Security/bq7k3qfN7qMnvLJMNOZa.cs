using System;
using System.Runtime.CompilerServices;
using BdZQbJfN4H4AgIYemOL6;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using EGjGpPfNQ5sRCSMK7KqW;
using UchfG8fTzhAHMiok6Yk0;
using b7C8sgfNUlsIIZiFPiE3;
using fDAldojjppXrctUVYOJn;

namespace rEWmcPfNAhtZSJjsJvk3;

public sealed class bq7k3qfN7qMnvLJMNOZa
{
	internal static object eJt8pL9DT31qnBtFo5PP;

	[field: CompilerGenerated]
	public string Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public n1qKx2fNJL9msKD7ZGJu State
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public tevrq6fTnmxdv0004lXm LocalEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public tevrq6fTnmxdv0004lXm RemoteEndpoint
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int ProtocolVersion
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int ActiveConnections
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public I8UL5cfNhu2cgReqF3g8 Traffic
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public f3JeIyfNCcv94eShPUIb LastDisconnectReason
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string LastDisconnectDetail
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DateTimeOffset StartedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string AccountId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string ServerId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string ServerName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string RoleId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string RoleName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string VersionName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public string AccountDisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	public string LocalAddressText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			(defaultInterpolatedStringHandler).AppendFormatted(WVqfNIRqgYZ(LocalEndpoint.Host));
			return null;
		}
	}

	public string StateText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			n1qKx2fNJL9msKD7ZGJu state = State;
			return null;
		}
	}

	public string ServerRoleText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public string StartedAtText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset startedAt = StartedAt;
			return null;
		}
	}

	public string TrafficText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat("↑ ", VhGfNBnJFko(Traffic.ClientToServerBytes), " · ↓ ", VhGfNBnJFko(Traffic.ServerToClientBytes));
		}
	}

	public string DisconnectText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			f3JeIyfNCcv94eShPUIb lastDisconnectReason = LastDisconnectReason;
			return null;
		}
	}

	public bool CanStop
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			n1qKx2fNJL9msKD7ZGJu state = State;
			return default(bool);
		}
	}

	public bool CanRetry
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			n1qKx2fNJL9msKD7ZGJu state = State;
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public bq7k3qfN7qMnvLJMNOZa(string id, n1qKx2fNJL9msKD7ZGJu state, tevrq6fTnmxdv0004lXm localEndpoint, tevrq6fTnmxdv0004lXm remoteEndpoint, int protocolVersion, int activeConnections, I8UL5cfNhu2cgReqF3g8 traffic, f3JeIyfNCcv94eShPUIb lastDisconnectReason, string lastDisconnectDetail, DateTimeOffset startedAt)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string WVqfNIRqgYZ(object host)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string VhGfNBnJFko(long bytes)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(" GB");
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
	internal static bool KGaAY19DNpNcQeF5Daud()
	{
		return eJt8pL9DT31qnBtFo5PP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bq7k3qfN7qMnvLJMNOZa tmYxpN9DMYseiw4VxYnG()
	{
		return (bq7k3qfN7qMnvLJMNOZa)eJt8pL9DT31qnBtFo5PP;
	}
}

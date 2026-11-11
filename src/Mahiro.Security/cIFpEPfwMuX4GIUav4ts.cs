using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace dEVUOofwpSJjAgLAYiLV;

public sealed class cIFpEPfwMuX4GIUav4ts
{
	private static object RCLcy39XGULs8M5kp4Ml;

	[JsonPropertyName("serviceCode")]
	[field: CompilerGenerated]
	public string ServiceCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("serviceName")]
	[field: CompilerGenerated]
	public string ServiceName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("allowed")]
	[field: CompilerGenerated]
	public bool Allowed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("status")]
	[field: CompilerGenerated]
	public string Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("expiresAt")]
	[field: CompilerGenerated]
	public global::System.DateTime? ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("remainingSeconds")]
	[field: CompilerGenerated]
	public long RemainingSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("isLifetime")]
	[field: CompilerGenerated]
	public bool IsLifetime
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("enforcementEnabled")]
	[field: CompilerGenerated]
	public bool EnforcementEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("adminBypassEnabled")]
	[field: CompilerGenerated]
	public bool AdminBypassEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("bypassed")]
	[field: CompilerGenerated]
	public bool Bypassed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("serverNow")]
	[field: CompilerGenerated]
	public global::System.DateTime ServerNow
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return null;
		}
	}

	[JsonIgnore]
	public string ExpiryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.DateTime? dateTime = default(global::System.DateTime?);
			global::System.DateTime value = dateTime.Value;
			return null;
		}
	}

	[JsonIgnore]
	public string RemainingText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = string.Concat("原到期时间 ", ExpiryText);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string DHWfwusxVjM(long seconds)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		long num = default(long);
		defaultInterpolatedStringHandler.AppendFormatted<long>(System.Math.Max(1L, (long)System.Math.Ceiling((double)num / 60.0)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public cIFpEPfwMuX4GIUav4ts()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool P1or3N9XiAN8FUxbTfgR()
	{
		return RCLcy39XGULs8M5kp4Ml == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static cIFpEPfwMuX4GIUav4ts j73lNV9XnWqQQO8jxKDT()
	{
		return (cIFpEPfwMuX4GIUav4ts)RCLcy39XGULs8M5kp4Ml;
	}
}

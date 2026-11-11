using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace BNyHcUfRdE6bqImEQbYu;

public sealed class t38PEtfRlRJjDwb2rSSY
{
	internal static object rTjmUP9bhCH7RmmLEiFa;

	[JsonPropertyName("code")]
	[field: CompilerGenerated]
	public string Code
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("channelCode")]
	[field: CompilerGenerated]
	public string ChannelCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("payType")]
	[field: CompilerGenerated]
	public string PayType
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("displayName")]
	[field: CompilerGenerated]
	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("balancePerYuan")]
	[field: CompilerGenerated]
	public decimal BalancePerYuan
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("displayFeePercent")]
	[field: CompilerGenerated]
	public decimal? DisplayFeePercent
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	[field: CompilerGenerated]
	public string PaymentCenterChannelId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	[field: CompilerGenerated]
	public string PaymentCenterMethod
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public bool IsPaymentCenter
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !string.IsNullOrWhiteSpace(PaymentCenterChannelId);
		}
	}

	public string FeeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			decimal? displayFeePercent = DisplayFeePercent;
			return null;
		}
	}

	public string DisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public string RateText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>(BalancePerYuan, "0.####");
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public string ToString()
	{
		return DisplayText;
	}

	[MethodImpl((MethodImplOptions)8)]
	public t38PEtfRlRJjDwb2rSSY()
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
	internal static bool GuM2G99bUHsdGhX7SKdQ()
	{
		return rTjmUP9bhCH7RmmLEiFa == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static t38PEtfRlRJjDwb2rSSY MsM4c99brsdqjiiqTotE()
	{
		return (t38PEtfRlRJjDwb2rSSY)rTjmUP9bhCH7RmmLEiFa;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace nowIRbfRRJ79HCUCsbjS;

public sealed class aS44CUfR6tdgNLbdQbUH
{
	private static object tN4ANb9bgs0jwJXb0om9;

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

	public string DisplayFeeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			decimal num = decimal.Round(((((decimal)AmountCents) * DisplayFeePercent.Value) / 100m), 0, (MidpointRounding)1);
			return null;
		}
	}

	[JsonPropertyName("id")]
	[field: CompilerGenerated]
	public long Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("orderNo")]
	[field: CompilerGenerated]
	public string OrderNo
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

	[JsonPropertyName("channelName")]
	[field: CompilerGenerated]
	public string ChannelName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("paymentMethod")]
	[field: CompilerGenerated]
	public string PaymentMethod
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("orderPurpose")]
	[field: CompilerGenerated]
	public string OrderPurpose
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("amountCents")]
	[field: CompilerGenerated]
	public int AmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("payAmountCents")]
	[field: CompilerGenerated]
	public int? PayAmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("paymentCurrency")]
	[field: CompilerGenerated]
	public string PaymentCurrency
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("providerAmount")]
	[field: CompilerGenerated]
	public string? ProviderAmount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("exchangeRateSnapshot")]
	[field: CompilerGenerated]
	public decimal? ExchangeRateSnapshot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("ratioSnapshot")]
	[field: CompilerGenerated]
	public decimal RatioSnapshot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("creditAmount")]
	[field: CompilerGenerated]
	public decimal CreditAmount
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

	[JsonPropertyName("payKind")]
	[field: CompilerGenerated]
	public string PayKind
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("qrUrl")]
	[field: CompilerGenerated]
	public string QrUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("payUrl")]
	[field: CompilerGenerated]
	public string PayUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("providerTradeNo")]
	[field: CompilerGenerated]
	public string ProviderTradeNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("username")]
	[field: CompilerGenerated]
	public string Username
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
	public global::System.DateTime ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("paidAt")]
	[field: CompilerGenerated]
	public global::System.DateTime? PaidAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("cancelledAt")]
	[field: CompilerGenerated]
	public global::System.DateTime? CancelledAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("createdAt")]
	[field: CompilerGenerated]
	public global::System.DateTime CreatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public int EffectivePayAmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int? payAmountCents = PayAmountCents;
			return default(int);
		}
	}

	public bool HasAmountDrift
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int? payAmountCents = PayAmountCents;
			return default(bool);
		}
	}

	public bool IsServiceSubscription
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (OrderPurpose == "service_subscription");
		}
	}

	public string AmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>((((decimal)AmountCents) / 100m), "0.00");
			return null;
		}
	}

	public string PayAmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>((((decimal)EffectivePayAmountCents) / 100m), "0.00");
			return null;
		}
	}

	public string CreditText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>(CreditAmount, "0.00");
			return null;
		}
	}

	public string PurposeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string orderPurpose = OrderPurpose;
			return null;
		}
	}

	public string PaidStatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string paidStatusText = PaidStatusText;
			return null;
		}
	}

	public string TimeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.DateTime createdAt = CreatedAt;
			return null;
		}
	}

	public string ExpiryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = "有效期至 ";
			global::System.DateTime expiresAt = ExpiresAt;
			expiresAt = (expiresAt).ToLocalTime();
			return string.Concat(text, (expiresAt).ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public aS44CUfR6tdgNLbdQbUH()
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
	internal static bool ovRwqo9blhyT9H7EDmao()
	{
		return tN4ANb9bgs0jwJXb0om9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static aS44CUfR6tdgNLbdQbUH PxBNG79bd2EMkIEyiyg9()
	{
		return (aS44CUfR6tdgNLbdQbUH)tN4ANb9bgs0jwJXb0om9;
	}
}

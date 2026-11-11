using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace peU42mfKoucoxUH2qZpv;

public sealed class XHM664fKrSLjJASlMccl
{
	private static object l54mLqZ3RBajDCULprui;

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

	[JsonPropertyName("batchId")]
	[field: CompilerGenerated]
	public long BatchId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

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

	[JsonPropertyName("amount")]
	[field: CompilerGenerated]
	public decimal Amount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("cardType")]
	[field: CompilerGenerated]
	public string CardType
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("serviceCode")]
	[field: CompilerGenerated]
	public string? ServiceCode
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
	public string? ServiceName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("serviceDurationDays")]
	[field: CompilerGenerated]
	public int? ServiceDurationDays
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

	[JsonPropertyName("note")]
	[field: CompilerGenerated]
	public string Note
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("redeemedBy")]
	[field: CompilerGenerated]
	public string? RedeemedBy
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("redeemedAt")]
	[field: CompilerGenerated]
	public global::System.DateTime? RedeemedAt
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

	[JsonIgnore]
	public string AmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = "¥ ";
			decimal amount = Amount;
			return string.Concat(text, (amount).ToString("0.##", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
		}
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
	public string RedeemedByText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	[JsonIgnore]
	public string CardTypeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			(defaultInterpolatedStringHandler).AppendFormatted(ServiceName ?? ServiceCode ?? "未知服务");
			return null;
		}
	}

	[JsonIgnore]
	public string CreatedAtText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.DateTime createdAt = CreatedAt;
			return null;
		}
	}

	[JsonIgnore]
	public bool IsDisabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (Status == "disabled");
		}
	}

	[JsonIgnore]
	public bool CanManage
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (Status != "redeemed");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public XHM664fKrSLjJASlMccl()
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
	internal static bool xxoVvtZ3wMhd0Z8afT8l()
	{
		return l54mLqZ3RBajDCULprui == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XHM664fKrSLjJASlMccl A0KtQVZ3eKLm2hHSIO2A()
	{
		return (XHM664fKrSLjJASlMccl)l54mLqZ3RBajDCULprui;
	}
}

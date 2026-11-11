using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace aT519UfO3d6PYepiHMHC;

public sealed class PqFZUVfO1JCpVlryjUX8
{
	private static object uGg865ZGdgLGCTRPLEdh;

	[JsonPropertyName("productId")]
	[field: CompilerGenerated]
	public long ProductId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("productName")]
	[field: CompilerGenerated]
	public string ProductName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("category")]
	[field: CompilerGenerated]
	public string Category
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("price")]
	[field: CompilerGenerated]
	public decimal Price
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("availableCount")]
	[field: CompilerGenerated]
	public int AvailableCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("autoUnsubscribe")]
	[field: CompilerGenerated]
	public bool AutoUnsubscribe
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("lastNotifiedAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? LastNotifiedAt
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
	public DateTimeOffset CreatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonIgnore]
	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string PriceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>(Price, "0.##");
			return null;
		}
	}

	[JsonIgnore]
	public string StockText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<int>(AvailableCount);
			return null;
		}
	}

	[JsonIgnore]
	public string CreatedAtText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset createdAt = CreatedAt;
			return null;
		}
	}

	[JsonIgnore]
	public string LastNotifiedAtText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			DateTimeOffset? lastNotifiedAt = LastNotifiedAt;
			return null;
		}
	}

	[JsonIgnore]
	public string AutoUnsubscribeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string MetaText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			(defaultInterpolatedStringHandler).AppendFormatted(LastNotifiedAtText);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public PqFZUVfO1JCpVlryjUX8()
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
	internal static bool aJ10PlZGKXSSxZ9tba5i()
	{
		return uGg865ZGdgLGCTRPLEdh == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PqFZUVfO1JCpVlryjUX8 F4Jl54ZGHJiEAMJW8CGu()
	{
		return (PqFZUVfO1JCpVlryjUX8)uGg865ZGdgLGCTRPLEdh;
	}
}

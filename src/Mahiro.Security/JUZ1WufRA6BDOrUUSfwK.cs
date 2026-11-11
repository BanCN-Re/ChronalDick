using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace ib6glgfRIbvKiV2rgUHE;

public sealed class JUZ1WufRA6BDOrUUSfwK
{
	private static object NWdwme9by8naRO1GvZgK;

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

	[JsonPropertyName("centerRefundId")]
	[field: CompilerGenerated]
	public string CenterRefundId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("centerOrderId")]
	[field: CompilerGenerated]
	public string CenterOrderId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("merchantRefundNo")]
	[field: CompilerGenerated]
	public string MerchantRefundNo
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

	[JsonPropertyName("currency")]
	[field: CompilerGenerated]
	public string Currency
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

	[JsonPropertyName("updatedAt")]
	[field: CompilerGenerated]
	public DateTimeOffset UpdatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public string AmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string currency = Currency;
			string text = " ";
			decimal num = (((decimal)AmountCents) / 100m);
			return string.Concat(currency, text, (num).ToString("0.00", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public JUZ1WufRA6BDOrUUSfwK()
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
	internal static bool MXKSVa9bWTeafre6EtN7()
	{
		return NWdwme9by8naRO1GvZgK == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JUZ1WufRA6BDOrUUSfwK MHQW8V9bJ7k8hRnfVYpu()
	{
		return (JUZ1WufRA6BDOrUUSfwK)NWdwme9by8naRO1GvZgK;
	}
}

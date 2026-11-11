using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace V19yyAfHkmuqXwqQyw37;

public sealed class F0KZw6fHD6PS0BAOceLx
{
	private static object lWV0gcZvTuGdK2bDCNoB;

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

	[JsonPropertyName("name")]
	[field: CompilerGenerated]
	public string Name
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

	[JsonPropertyName("isActive")]
	[field: CompilerGenerated]
	public bool IsActive
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

	[JsonPropertyName("issuedCount")]
	[field: CompilerGenerated]
	public int IssuedCount
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
			return string.Concat(Category, " / ", Name);
		}
	}

	[JsonIgnore]
	public string PriceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = "¥ ";
			decimal price = Price;
			return string.Concat(text, (price).ToString("0.##", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
		}
	}

	[JsonIgnore]
	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public F0KZw6fHD6PS0BAOceLx()
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
	internal static bool GYiZc0ZvN9USFhllhHic()
	{
		return lWV0gcZvTuGdK2bDCNoB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static F0KZw6fHD6PS0BAOceLx PrSwjbZvMC3Ij4Qeo4EX()
	{
		return (F0KZw6fHD6PS0BAOceLx)lWV0gcZvTuGdK2bDCNoB;
	}
}

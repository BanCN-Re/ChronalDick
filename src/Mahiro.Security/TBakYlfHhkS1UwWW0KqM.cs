using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace ILBXFofHUBeT5wBueTDZ;

public sealed class TBakYlfHhkS1UwWW0KqM
{
	private static object ux3KJLZEZrlw6mGsPsqR;

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

	[JsonPropertyName("account")]
	[field: CompilerGenerated]
	public string Account
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

	[JsonPropertyName("importedBy")]
	[field: CompilerGenerated]
	public string ImportedBy
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("issuedTo")]
	[field: CompilerGenerated]
	public string? IssuedTo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("issuedAt")]
	[field: CompilerGenerated]
	public global::System.DateTime? IssuedAt
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
	public string ProductDisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat(Category, " / ", ProductName);
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

	[JsonIgnore]
	public string IssuedToText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
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
	public bool CanDelete
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (Status == "available");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public TBakYlfHhkS1UwWW0KqM()
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
	internal static bool JgdhIaZE9EV3KFnd72pP()
	{
		return ux3KJLZEZrlw6mGsPsqR == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TBakYlfHhkS1UwWW0KqM oNWdl7ZEDMehv3A1QINU()
	{
		return (TBakYlfHhkS1UwWW0KqM)ux3KJLZEZrlw6mGsPsqR;
	}
}

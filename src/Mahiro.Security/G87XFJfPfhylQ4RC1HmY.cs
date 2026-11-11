using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace CGTgWZfPLqikrZ4Zv8WL;

public sealed class G87XFJfPfhylQ4RC1HmY
{
	private static object NZid379LOV4ndmWW2o5g;

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

	[JsonPropertyName("password")]
	[field: CompilerGenerated]
	public string Password
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("sauthJson")]
	[field: CompilerGenerated]
	public string SauthJson
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("loginMode")]
	[field: CompilerGenerated]
	public string LoginMode
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

	[JsonIgnore]
	public bool HasSauth
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !string.IsNullOrWhiteSpace(SauthJson);
		}
	}

	[JsonIgnore]
	public string AccountDisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat("账号：", Account);
		}
	}

	[JsonIgnore]
	public string CopyText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string SauthStateText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string LoginModeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string loginMode = LoginMode;
			return null;
		}
	}

	[JsonIgnore]
	public string SavedAtText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset updatedAt = UpdatedAt;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public G87XFJfPfhylQ4RC1HmY()
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
	internal static bool qrSjnC9L5BqBm7yYq4a6()
	{
		return NZid379LOV4ndmWW2o5g == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static G87XFJfPfhylQ4RC1HmY qOyMoG9L6cRSEuCrQsHG()
	{
		return (G87XFJfPfhylQ4RC1HmY)NZid379LOV4ndmWW2o5g;
	}
}

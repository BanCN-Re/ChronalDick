using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace N9UVEvf6UHvBucn1bopm;

public sealed class aMuqLcf6hnKdBTwYqLWe
{
	private static object pdKQtpZn5LNTaaWkg9BI;

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

	[JsonPropertyName("source")]
	[field: CompilerGenerated]
	public string Source
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
	public string UsernameText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat("用户名：", Username);
		}
	}

	[JsonIgnore]
	public string PasswordText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat("密码：", Password);
		}
	}

	[JsonIgnore]
	public string AccountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat(Username, "------", Password);
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
	public string SourceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = "自动注册";
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
	public aMuqLcf6hnKdBTwYqLWe()
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
	internal static bool KhOPmkZn6NY5FicxXPBL()
	{
		return pdKQtpZn5LNTaaWkg9BI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static aMuqLcf6hnKdBTwYqLWe XklnxmZnRZYMFQc6xaiu()
	{
		return (aMuqLcf6hnKdBTwYqLWe)pdKQtpZn5LNTaaWkg9BI;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using uAMBGBfHIb0BxGpRnPAq;

namespace XW91tWfH68aLp4MR3yI7;

public sealed class QQOq9QfH5ZXiYBD0rR21 : wmdNEbfHAbSdfRGI5xOQ
{
	internal static object zPQwcfZEBPA5tu8r1m7k;

	[JsonPropertyName("isEnabled")]
	[field: CompilerGenerated]
	public bool IsEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("isArchived")]
	[field: CompilerGenerated]
	public bool IsArchived
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

	[JsonPropertyName("createdBy")]
	[field: CompilerGenerated]
	public string? CreatedBy
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("updatedBy")]
	[field: CompilerGenerated]
	public string? UpdatedBy
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
	public string DeliveryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat(base.DisplayModeText, " · ", base.TargetRoleText);
		}
	}

	[JsonIgnore]
	public string TimeRangeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset? endsAt = base.EndsAt;
			object obj;
			if (!endsAt.HasValue)
			{
				obj = null;
			}
			else
			{
				DateTimeOffset valueOrDefault = endsAt.GetValueOrDefault();
				valueOrDefault = (valueOrDefault).ToLocalTime();
				obj = (valueOrDefault).ToString("yyyy-MM-dd HH:mm", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
			}
			if (obj == null)
			{
				obj = "长期";
			}
			string text = (string)obj;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public QQOq9QfH5ZXiYBD0rR21()
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
	internal static bool MEb0o8ZEgTPeTeXK5JSp()
	{
		return zPQwcfZEBPA5tu8r1m7k == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QQOq9QfH5ZXiYBD0rR21 LWTQm9ZEl2dhC2Ff7HOs()
	{
		return (QQOq9QfH5ZXiYBD0rR21)zPQwcfZEBPA5tu8r1m7k;
	}
}

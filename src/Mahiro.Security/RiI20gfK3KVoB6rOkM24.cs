using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace YSkLmZfKvV06AfbeZjaD;

public sealed class RiI20gfK3KVoB6rOkM24
{
	private static object iBbDI9ZvUrPCf5cNtfy0;

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

	[JsonPropertyName("templateCode")]
	[field: CompilerGenerated]
	public string TemplateCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("toEmail")]
	[field: CompilerGenerated]
	public string ToEmail
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("userId")]
	[field: CompilerGenerated]
	public long? UserId
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
	public string? Username
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("subjectSnapshot")]
	[field: CompilerGenerated]
	public string SubjectSnapshot
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

	[JsonPropertyName("attempts")]
	[field: CompilerGenerated]
	public int Attempts
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("nextAttemptAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? NextAttemptAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("lastError")]
	[field: CompilerGenerated]
	public string? LastError
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("sentAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? SentAt
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
	public string UsernameText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	[JsonIgnore]
	public string SubjectText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string AttemptsText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int attempts = Attempts;
			return null;
		}
	}

	[JsonIgnore]
	public string LastErrorText
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
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset createdAt = CreatedAt;
			return null;
		}
	}

	[JsonIgnore]
	public string ScheduleText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			DateTimeOffset? sentAt = SentAt;
			return null;
		}
	}

	[JsonIgnore]
	public bool CanRetry
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return default(bool);
		}
	}

	[JsonIgnore]
	public bool CanDrop
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public RiI20gfK3KVoB6rOkM24()
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
	internal static bool EaRfCkZvrw9NnppXqNeh()
	{
		return iBbDI9ZvUrPCf5cNtfy0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RiI20gfK3KVoB6rOkM24 apySROZvoqloKVsAh13J()
	{
		return (RiI20gfK3KVoB6rOkM24)iBbDI9ZvUrPCf5cNtfy0;
	}
}

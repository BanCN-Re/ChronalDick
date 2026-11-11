using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using ERJ416fPgD8mIlLPsat4;
using fDAldojjppXrctUVYOJn;
using l6fA40fP0TXAIKJYPUiR;

namespace RyDfSXfPyKj0ty7cSIxY;

public sealed class t30hHHfP8gMStFdbd6rB
{
	[CompilerGenerated]
	private y6pelrfPcMaoKw9oseWu _Status_k__BackingField;

	[CompilerGenerated]
	private string _Message_k__BackingField;

	[CompilerGenerated]
	private string? _SauthJson_k__BackingField;

	[CompilerGenerated]
	private string? _Ticket_k__BackingField;

	[CompilerGenerated]
	private string? _VerifyUrl_k__BackingField;

	[CompilerGenerated]
	private bool _CanSms_k__BackingField;

	[CompilerGenerated]
	private string? _UpsmsContent_k__BackingField;

	[CompilerGenerated]
	private string? _UpsmsNumber_k__BackingField;

	[CompilerGenerated]
	private string? _UpsmsBackupNumber_k__BackingField;

	[CompilerGenerated]
	private string? _PendingSauthJson_k__BackingField;

	private static object? exLfQt9LvG1gRjwLJpMN;

	public y6pelrfPcMaoKw9oseWu Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Status_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Status_k__BackingField = value;
		}
	}

	public string Message
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Message_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Message_k__BackingField = value;
		}
	}

	[field: CompilerGenerated]
	public bool AccountCreated
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public string? SauthJson
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _SauthJson_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_SauthJson_k__BackingField = value;
		}
	}

	public string? Ticket
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Ticket_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_Ticket_k__BackingField = value;
		}
	}

	public string? VerifyUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _VerifyUrl_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_VerifyUrl_k__BackingField = value;
		}
	}

	public bool CanSms
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _CanSms_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_CanSms_k__BackingField = value;
		}
	}

	public string? UpsmsContent
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UpsmsContent_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_UpsmsContent_k__BackingField = value;
		}
	}

	public string? UpsmsNumber
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UpsmsNumber_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_UpsmsNumber_k__BackingField = value;
		}
	}

	public string? UpsmsBackupNumber
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _UpsmsBackupNumber_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_UpsmsBackupNumber_k__BackingField = value;
		}
	}

	public string? PendingSauthJson
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PendingSauthJson_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			_PendingSauthJson_k__BackingField = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static t30hHHfP8gMStFdbd6rB EfOfPWKFbjf(string sauthJson, string message = "登录成功")
	{
		HpFsqcfPB2RknTNMlueF.LetfPdB1Tul(sauthJson);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static t30hHHfP8gMStFdbd6rB Fail(string? message)
	{
		return (t30hHHfP8gMStFdbd6rB)new t30hHHfP8gMStFdbd6rB
		{
			Status = y6pelrfPcMaoKw9oseWu.Failed,
			Message = (string.IsNullOrWhiteSpace(message) ? "操作失败，服务端未返回错误详情" : (message).Trim())
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	public static t30hHHfP8gMStFdbd6rB oJ7fPJ2INmZ(object ticket, string? verifyUrl, object message)
	{
		return (t30hHHfP8gMStFdbd6rB)new t30hHHfP8gMStFdbd6rB
		{
			Status = y6pelrfPcMaoKw9oseWu.NeedVerify,
			Ticket = (string?)ticket,
			VerifyUrl = verifyUrl,
			CanSms = true,
			Message = (string)message
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	public static t30hHHfP8gMStFdbd6rB DjBfPQdn12i(string ticket, string? verifyUrl, string content, string number, string? backupNumber, string message, string? pendingSauthJson = null)
	{
		return (t30hHHfP8gMStFdbd6rB)new t30hHHfP8gMStFdbd6rB
		{
			Status = y6pelrfPcMaoKw9oseWu.NeedVerify,
			Ticket = ticket,
			VerifyUrl = verifyUrl,
			CanSms = false,
			UpsmsContent = content,
			UpsmsNumber = number,
			UpsmsBackupNumber = backupNumber,
			PendingSauthJson = pendingSauthJson,
			Message = message
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	public t30hHHfP8gMStFdbd6rB()
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
	internal static bool FSrFoM9LEVXbp9r2tP4r()
	{
		return exLfQt9LvG1gRjwLJpMN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static t30hHHfP8gMStFdbd6rB? vgaCAJ9L2jljBwNRAOqg()
	{
		return (t30hHHfP8gMStFdbd6rB?)exLfQt9LvG1gRjwLJpMN;
	}
}

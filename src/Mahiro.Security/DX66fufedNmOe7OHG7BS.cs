using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Tw9bY8feF6dPFc3Fd2aj;
using fDAldojjppXrctUVYOJn;

namespace yjXUBbfeKNTIxhLVVKy5;

public sealed class DX66fufedNmOe7OHG7BS
{
	private static object e7rCAu9fibdn5qgWIeqn;

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

	[JsonPropertyName("requestNo")]
	[field: CompilerGenerated]
	public string RequestNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("orderNo")]
	[field: CompilerGenerated]
	public string? OrderNo
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
	public long? AmountCents
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

	[JsonPropertyName("mode")]
	[field: CompilerGenerated]
	public string Mode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("recoveryStatus")]
	[field: CompilerGenerated]
	public string RecoveryStatus
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("channelName")]
	[field: CompilerGenerated]
	public string? ChannelName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("paymentMethod")]
	[field: CompilerGenerated]
	public string? PaymentMethod
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("providerRefundNo")]
	[field: CompilerGenerated]
	public string? ProviderRefundNo
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
	public DateTimeOffset? CreatedAt
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
	public DateTimeOffset? UpdatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("completedAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? CompletedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("fundsCompletedAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? FundsCompletedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("affectedOnly")]
	[field: CompilerGenerated]
	public bool AffectedOnly
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	public string OrderText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	public string AmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return null;
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return inelCefex8fdCPrlACDh.Status(Status);
		}
	}

	public string RecoveryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return inelCefex8fdCPrlACDh.Status(RecoveryStatus);
		}
	}

	public string TimeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return inelCefex8fdCPrlACDh.XYafeNONrXt(CreatedAt);
		}
	}

	public string ModeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string recoveryStatus = RecoveryStatus;
			return null;
		}
	}

	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			List<string> obj = new List<string>();
			obj.Add(string.Concat("退款请求号：", RequestNo));
			obj.Add(string.Concat("类型：", ModeText));
			obj.Add(string.Concat("资金状态：", StatusText));
			obj.Add(string.Concat("资产状态：", RecoveryText));
			obj.Add(string.Concat("发起时间：", TimeText));
			obj.Add(string.Concat("更新时间：", inelCefex8fdCPrlACDh.XYafeNONrXt(UpdatedAt)));
			obj.Add(string.Concat("完成时间：", inelCefex8fdCPrlACDh.XYafeNONrXt(CompletedAt)));
			List<string> val = obj;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public DX66fufedNmOe7OHG7BS()
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
	internal static bool rQU7P89fn8kLZgNXAT3T()
	{
		return e7rCAu9fibdn5qgWIeqn == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static DX66fufedNmOe7OHG7BS NANANG9fztsiqBKWdJc4()
	{
		return (DX66fufedNmOe7OHG7BS)e7rCAu9fibdn5qgWIeqn;
	}
}

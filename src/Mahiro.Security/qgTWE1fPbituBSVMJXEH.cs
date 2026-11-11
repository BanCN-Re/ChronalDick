using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Tw9bY8feF6dPFc3Fd2aj;
using fDAldojjppXrctUVYOJn;

namespace ftkhp5fPXc3cmmZq9YAG;

public sealed class qgTWE1fPbituBSVMJXEH
{
	private static object U8Zlqw9LKG6Hsc2Z3Utj;

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

	[JsonPropertyName("orderId")]
	[field: CompilerGenerated]
	public long OrderId
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
	public string OrderNo
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
	public long AmountCents
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

	[JsonPropertyName("reason")]
	[field: CompilerGenerated]
	public string Reason
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("reviewReason")]
	[field: CompilerGenerated]
	public string ReviewReason
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

	[JsonPropertyName("reviewedAt")]
	[field: CompilerGenerated]
	public DateTimeOffset? ReviewedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("refundId")]
	[field: CompilerGenerated]
	public long? RefundId
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

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return null;
		}
	}

	public string ListText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			(defaultInterpolatedStringHandler).AppendFormatted(inelCefex8fdCPrlACDh.gujfeTO17YJ(AmountCents));
			return null;
		}
	}

	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = System.Environment.NewLine;
			string[] obj = new string[10]
			{
				string.Concat("申请号：", RequestNo),
				string.Concat("订单：", OrderNo),
				string.Concat("退款本金：", inelCefex8fdCPrlACDh.gujfeTO17YJ(AmountCents)),
				string.Concat("申请状态：", StatusText),
				string.Concat("资产状态：", (RecoveryStatus == "not_started") ? "尚未执行" : inelCefex8fdCPrlACDh.Status(RecoveryStatus)),
				string.Concat("申请原因：", Reason),
				string.Concat("审核 / 转人工原因：", inelCefex8fdCPrlACDh.z99fesTdvAi(ReviewReason)),
				string.Concat("申请时间：", inelCefex8fdCPrlACDh.XYafeNONrXt(CreatedAt)),
				string.Concat("审核时间：", inelCefex8fdCPrlACDh.XYafeNONrXt(ReviewedAt)),
				null
			};
			string text2;
			if (!RefundId.HasValue)
			{
				text2 = "尚未发起支付站退款。";
			}
			else
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(23, 1);
				(defaultInterpolatedStringHandler).AppendLiteral("实际退款记录：#");
				defaultInterpolatedStringHandler.AppendFormatted<long?>(RefundId);
				(defaultInterpolatedStringHandler).AppendLiteral("，逐项执行结果请查看退款历史。");
				text2 = (defaultInterpolatedStringHandler).ToStringAndClear();
			}
			obj[9] = text2;
			return string.Join(text, obj);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public qgTWE1fPbituBSVMJXEH()
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
	internal static bool jRwWDO9LHPEAvMf5H5hU()
	{
		return U8Zlqw9LKG6Hsc2Z3Utj == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qgTWE1fPbituBSVMJXEH YIMuqc9LtQTAUprWCRoh()
	{
		return (qgTWE1fPbituBSVMJXEH)U8Zlqw9LKG6Hsc2Z3Utj;
	}
}

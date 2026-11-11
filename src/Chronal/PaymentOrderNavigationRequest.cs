using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages;

public sealed class PaymentOrderNavigationRequest : IEquatable<PaymentOrderNavigationRequest>
{
	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return typeof(global::Mahiro_Account.Views.Pages.PaymentOrderNavigationRequest);
		}
	}

	[field: CompilerGenerated]
	private string _OrderNo_k__BackingField;
	public string OrderNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private bool _OpenPaymentPage_k__BackingField;
	public bool OpenPaymentPage
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[field: CompilerGenerated]
	private string _ServicePurchaseOrderNo_k__BackingField;
	public string ServicePurchaseOrderNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init;
	}

	[MethodImpl((MethodImplOptions)8)]
	public PaymentOrderNavigationRequest(string OrderNo, bool OpenPaymentPage, string ServicePurchaseOrderNo = "")
	{
		_OrderNo_k__BackingField = OrderNo;
		_OpenPaymentPage_k__BackingField = OpenPaymentPage;
		_ServicePurchaseOrderNo_k__BackingField = ServicePurchaseOrderNo;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		val.Append("PaymentOrderNavigationRequest");
		val.Append(" { ");
		if (PrintMembers(val))
		{
			val.Append(' ');
		}
		val.Append('}');
		return ((object)val).ToString();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool PrintMembers(StringBuilder builder)
	{
		RuntimeHelpers.EnsureSufficientExecutionStack();
		builder.Append("OrderNo = ");
		builder.Append((object)OrderNo);
		builder.Append(", OpenPaymentPage = ");
		builder.Append(((object)OpenPaymentPage/*cast due to .constrained prefix*/).ToString());
		builder.Append(", ServicePurchaseOrderNo = ");
		builder.Append((object)ServicePurchaseOrderNo);
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(PaymentOrderNavigationRequest? left, PaymentOrderNavigationRequest? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(PaymentOrderNavigationRequest? left, PaymentOrderNavigationRequest? right)
	{
		if ((object)left != right)
		{
			return left?.Equals(right) ?? false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return ((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_OrderNo_k__BackingField)) * -1521134295 + EqualityComparer<bool>.Default.GetHashCode(_OpenPaymentPage_k__BackingField)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_ServicePurchaseOrderNo_k__BackingField);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as PaymentOrderNavigationRequest);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(PaymentOrderNavigationRequest? other)
	{
		if ((object)this != other)
		{
			if ((object)other != null && EqualityContract == other.EqualityContract && EqualityComparer<string>.Default.Equals(_OrderNo_k__BackingField, ((dynamic)other)._OrderNo_k__BackingField) && EqualityComparer<bool>.Default.Equals(_OpenPaymentPage_k__BackingField, ((dynamic)other)._OpenPaymentPage_k__BackingField))
			{
				return EqualityComparer<string>.Default.Equals(_ServicePurchaseOrderNo_k__BackingField, (((dynamic)other)._ServicePurchaseOrderNo_k__BackingField));
			}
			return false;
		}
		return true;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public PaymentOrderNavigationRequest _Clone__()
	{
		return (PaymentOrderNavigationRequest)new PaymentOrderNavigationRequest(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private PaymentOrderNavigationRequest(PaymentOrderNavigationRequest original)
	{
		_OrderNo_k__BackingField = ((dynamic)original)._OrderNo_k__BackingField;
		_OpenPaymentPage_k__BackingField = ((dynamic)original)._OpenPaymentPage_k__BackingField;
		_ServicePurchaseOrderNo_k__BackingField = ((dynamic)original)._ServicePurchaseOrderNo_k__BackingField;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void Deconstruct(out string OrderNo, out bool OpenPaymentPage, out string ServicePurchaseOrderNo)
	{
		//IL_000b: Expected I8, but got O
		//IL_0013: Expected F4, but got I4
		//IL_001b: Expected I8, but got O
		OrderNo = default;
		OpenPaymentPage = default;
		ServicePurchaseOrderNo = default;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

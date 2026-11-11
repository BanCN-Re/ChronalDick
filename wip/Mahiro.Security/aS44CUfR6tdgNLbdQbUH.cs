using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace nowIRbfRRJ79HCUCsbjS;

public sealed class aS44CUfR6tdgNLbdQbUH
{
	[CompilerGenerated]
	private decimal? _DisplayFeePercent_k__BackingField;

	[CompilerGenerated]
	private long _Id_k__BackingField;

	[CompilerGenerated]
	private string _OrderNo_k__BackingField;

	[CompilerGenerated]
	private string _ChannelCode_k__BackingField;

	[CompilerGenerated]
	private string _ChannelName_k__BackingField;

	[CompilerGenerated]
	private string _PaymentMethod_k__BackingField;

	[CompilerGenerated]
	private string _OrderPurpose_k__BackingField;

	[CompilerGenerated]
	private int _AmountCents_k__BackingField;

	[CompilerGenerated]
	private int? _PayAmountCents_k__BackingField;

	[CompilerGenerated]
	private string _PaymentCurrency_k__BackingField;

	[CompilerGenerated]
	private string? _ProviderAmount_k__BackingField;

	[CompilerGenerated]
	private decimal? _ExchangeRateSnapshot_k__BackingField;

	[CompilerGenerated]
	private decimal _RatioSnapshot_k__BackingField;

	[CompilerGenerated]
	private decimal _CreditAmount_k__BackingField;

	[CompilerGenerated]
	private string _Status_k__BackingField;

	[CompilerGenerated]
	private string _PayKind_k__BackingField;

	[CompilerGenerated]
	private string _QrUrl_k__BackingField;

	[CompilerGenerated]
	private string _PayUrl_k__BackingField;

	[CompilerGenerated]
	private string _ProviderTradeNo_k__BackingField;

	[CompilerGenerated]
	private string _Username_k__BackingField;

	[CompilerGenerated]
	private global::System.DateTime _ExpiresAt_k__BackingField;

	[CompilerGenerated]
	private global::System.DateTime? _PaidAt_k__BackingField;

	[CompilerGenerated]
	private global::System.DateTime? _CancelledAt_k__BackingField;

	[CompilerGenerated]
	private global::System.DateTime _CreatedAt_k__BackingField;

	private static object tN4ANb9bgs0jwJXb0om9;

	[JsonPropertyName("displayFeePercent")]
	public decimal? DisplayFeePercent
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _DisplayFeePercent_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_DisplayFeePercent_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	public unsafe string DisplayFeeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0025: Expected O, but got Ref
			//IL_0032: Expected O, but got I4
			decimal num = ((decimal)AmountCents);
			decimal? displayFeePercent = DisplayFeePercent;
			decimal num2 = decimal.Round(((num * (decimal)(&displayFeePercent)) / 100m), 0, (MidpointRounding)1);
			return null;
		}
	}

	[JsonPropertyName("id")]
	public long Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Id_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_Id_k__BackingField = value;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("orderNo")]
	public string OrderNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _OrderNo_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_OrderNo_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num2 = 2;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("channelCode")]
	public string ChannelCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ChannelCode_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_ChannelCode_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("channelName")]
	public string ChannelName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ChannelName_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_ChannelName_k__BackingField = value;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("paymentMethod")]
	public string PaymentMethod
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PaymentMethod_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_PaymentMethod_k__BackingField = value;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("orderPurpose")]
	public string OrderPurpose
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _OrderPurpose_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_OrderPurpose_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
					{
						num2 = 3;
					}
				}
			}
		}
	}

	[JsonPropertyName("amountCents")]
	public int AmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _AmountCents_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_AmountCents_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
					{
						num2 = 3;
					}
				}
			}
		}
	}

	[JsonPropertyName("payAmountCents")]
	public int? PayAmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PayAmountCents_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_PayAmountCents_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("paymentCurrency")]
	public string PaymentCurrency
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PaymentCurrency_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_PaymentCurrency_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
					{
						num2 = 5;
					}
				}
			}
		}
	}

	[JsonPropertyName("providerAmount")]
	public string? ProviderAmount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ProviderAmount_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_ProviderAmount_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("exchangeRateSnapshot")]
	public decimal? ExchangeRateSnapshot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ExchangeRateSnapshot_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_ExchangeRateSnapshot_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
					{
						num2 = 4;
					}
				}
			}
		}
	}

	[JsonPropertyName("ratioSnapshot")]
	public decimal RatioSnapshot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _RatioSnapshot_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_RatioSnapshot_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("creditAmount")]
	public decimal CreditAmount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _CreditAmount_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_CreditAmount_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
					{
						num2 = 4;
					}
				}
			}
		}
	}

	[JsonPropertyName("status")]
	public string Status
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
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_Status_k__BackingField = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("payKind")]
	public string PayKind
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PayKind_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_PayKind_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
					{
						num2 = 4;
					}
				}
			}
		}
	}

	[JsonPropertyName("qrUrl")]
	public string QrUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _QrUrl_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_QrUrl_k__BackingField = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("payUrl")]
	public string PayUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PayUrl_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_PayUrl_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	[JsonPropertyName("providerTradeNo")]
	public string ProviderTradeNo
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ProviderTradeNo_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_ProviderTradeNo_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	[JsonPropertyName("username")]
	public string Username
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Username_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_Username_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("expiresAt")]
	public global::System.DateTime ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _ExpiresAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_ExpiresAt_k__BackingField = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	[JsonPropertyName("paidAt")]
	public global::System.DateTime? PaidAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _PaidAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						_PaidAt_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num2 = 5;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("cancelledAt")]
	public global::System.DateTime? CancelledAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _CancelledAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						_CancelledAt_k__BackingField = value;
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("createdAt")]
	public global::System.DateTime CreatedAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _CreatedAt_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_CreatedAt_k__BackingField = value;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public int EffectivePayAmountCents
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int? payAmountCents = PayAmountCents;
			return default(int);
		}
	}

	public bool HasAmountDrift
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return default(bool);
		}
	}

	public bool IsServiceSubscription
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (OrderPurpose == "service_subscription");
		}
	}

	public string AmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_001f: Expected O, but got I4
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>((((decimal)AmountCents) / 100m), "0.00");
			return null;
		}
	}

	public string PayAmountText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_001f: Expected O, but got I4
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>((((decimal)EffectivePayAmountCents) / 100m), "0.00");
			return null;
		}
	}

	public string CreditText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>(CreditAmount, "0.00");
			return null;
		}
	}

	public string PurposeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 10;
			string orderPurpose = default(string);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 20)
							{
								if (num2 == 1001)
								{
									goto end_IL_0010;
								}
								goto case 12;
							}
							goto case 5;
						case 10:
							orderPurpose = OrderPurpose;
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num3 = 2;
							}
							continue;
						case 5:
							result = "服务套餐";
							num3 = 2;
							continue;
						case 12:
							if (!(orderPurpose == "kook_recharge"))
							{
								num3 = 7;
								continue;
							}
							goto case 6;
						case 9:
							if ((orderPurpose == "service_subscription"))
							{
								break;
							}
							goto case 8;
						case 0:
						case 2:
						case 3:
						case 13:
							return result;
						case 1:
						case 11:
							result = "KOOK 商品";
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
							{
								num3 = 0;
							}
							continue;
						case 8:
							if ((orderPurpose == "kook_card_purchase"))
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
								{
									num3 = 16;
								}
								continue;
							}
							goto case 12;
						case 4:
						case 7:
							result = "余额充值";
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num3 = 13;
							}
							continue;
						case 6:
							result = "KOOK 充值";
							num3 = 3;
							continue;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
				{
					num = 20;
				}
			}
		}
	}

	public string PaidStatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return "已到账";
					case 1:
						break;
					}
					goto IL_006e;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_006e;
					IL_006e:
					if (IsServiceSubscription)
					{
						return "已支付";
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
					{
						num2 = 4;
					}
				}
			}
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 11;
			string result = default(string);
			string status = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 26)
							{
								if (num2 == 1007)
								{
									goto end_IL_0010;
								}
								goto case 16;
							}
							goto case 2;
						case 16:
							result = "已取消";
							num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num3 = 6;
							}
							continue;
						case 8:
							result = "已过期";
							num3 = 4;
							continue;
						case 1:
						case 3:
							result = PaidStatusText;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
						case 4:
						case 6:
						case 7:
						case 17:
						case 18:
							return result;
						case 13:
							if ((status == "paid"))
							{
								num3 = 3;
								continue;
							}
							goto case 5;
						case 9:
							if ((status == "failed"))
							{
								num = 19;
								break;
							}
							goto case 15;
						case 11:
							status = Status;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num3 = 10;
							}
							continue;
						case 14:
							result = "待支付";
							num3 = 18;
							continue;
						case 2:
							result = Status;
							num3 = 17;
							continue;
						case 10:
							if (!(status == "pending"))
							{
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num3 = 13;
								}
								continue;
							}
							goto case 14;
						case 12:
						case 19:
							result = "失败";
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num3 = 23;
							}
							continue;
						case 15:
							if (!(status == "cancelled"))
							{
								num = 26;
								break;
							}
							goto case 16;
						case 5:
							if (!(status == "expired"))
							{
								num3 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
								{
									num3 = 9;
								}
								continue;
							}
							goto case 8;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
			}
		}
	}

	public string TimeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			global::System.DateTime dateTime = default(global::System.DateTime);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (num == 990)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 1:
						dateTime = (dateTime).ToLocalTime();
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return (dateTime).ToString("yyyy-MM-dd HH:mm", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
					case 2:
						dateTime = CreatedAt;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num2 = 1;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	public string ExpiryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = "有效期至 ";
			global::System.DateTime expiresAt = ExpiresAt;
			expiresAt = (expiresAt).ToLocalTime();
			return string.Concat(text, (expiresAt).ToString("yyyy-MM-dd HH:mm:ss", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public aS44CUfR6tdgNLbdQbUH()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 0:
						return;
					case 2:
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool ovRwqo9blhyT9H7EDmao()
	{
		return tN4ANb9bgs0jwJXb0om9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static aS44CUfR6tdgNLbdQbUH PxBNG79bd2EMkIEyiyg9()
	{
		return (aS44CUfR6tdgNLbdQbUH)tN4ANb9bgs0jwJXb0om9;
	}
}

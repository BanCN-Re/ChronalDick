using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace T4XKlEftW1rbu7TvQmXH;

public sealed class xbVf4FftyKLP9yqO5mWE : INotifyPropertyChanged
{
	private bool _isSubscribed;

	[CompilerGenerated]
	private long _Id_k__BackingField;

	[CompilerGenerated]
	private string _Category_k__BackingField;

	[CompilerGenerated]
	private string _Name_k__BackingField;

	[CompilerGenerated]
	private string _Description_k__BackingField;

	[CompilerGenerated]
	private decimal _Price_k__BackingField;

	[CompilerGenerated]
	private int _AvailableCount_k__BackingField;

	[CompilerGenerated]
	private int _IssuedCount_k__BackingField;

	[CompilerGenerated]
	private bool _IsActive_k__BackingField;

	[CompilerGenerated]
	private int _LowStockThreshold_k__BackingField;

	[CompilerGenerated]
	private bool _IsLowStock_k__BackingField;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	internal static object t8dKCXZ2Q6fT7BXpgYXw;

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
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("category")]
	public string Category
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Category_k__BackingField;
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
						_Category_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[JsonPropertyName("name")]
	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Name_k__BackingField;
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
						_Name_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
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

	[JsonPropertyName("description")]
	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Description_k__BackingField;
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
						_Description_k__BackingField = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
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

	[JsonPropertyName("price")]
	public decimal Price
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Price_k__BackingField;
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
						_Price_k__BackingField = value;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
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

	[JsonPropertyName("availableCount")]
	public int AvailableCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _AvailableCount_k__BackingField;
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
						_AvailableCount_k__BackingField = value;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
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

	[JsonPropertyName("issuedCount")]
	public int IssuedCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _IssuedCount_k__BackingField;
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
					_IssuedCount_k__BackingField = value;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonPropertyName("isActive")]
	public bool IsActive
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _IsActive_k__BackingField;
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
						_IsActive_k__BackingField = value;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
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

	[JsonPropertyName("lowStockThreshold")]
	public int LowStockThreshold
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LowStockThreshold_k__BackingField;
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
						_LowStockThreshold_k__BackingField = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
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

	[JsonPropertyName("isLowStock")]
	public bool IsLowStock
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _IsLowStock_k__BackingField;
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
					_IsLowStock_k__BackingField = value;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[JsonIgnore]
	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return string.Concat(Category, " / ", Name);
		}
	}

	[JsonIgnore]
	public string StockText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return null;
		}
	}

	[JsonIgnore]
	public string IssuedText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return null;
		}
	}

	[JsonIgnore]
	public string PriceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<decimal>(Price, "0.##");
			return null;
		}
	}

	[JsonIgnore]
	public string StatusText
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
						if (num == 989)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 1:
						if (!IsActive)
						{
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num2 = 0;
							}
							break;
						}
						return "上架";
					case 0:
						return "下架";
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public string WarningText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
		}
	}

	[JsonIgnore]
	public bool HasDescription
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return !string.IsNullOrWhiteSpace(Description);
		}
	}

	[JsonIgnore]
	public bool IsOutOfStock
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return AvailableCount <= 0;
		}
	}

	[JsonIgnore]
	public bool IsSubscribed
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _isSubscribed;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			int num = 3;
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 4;
							}
							WDJftJtPV1n("StockAlertButtonText");
							num3 = 4;
							continue;
						case 4:
							WDJftJtPV1n("StockAlertTooltip");
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							return;
						case 2:
							return;
						case 3:
							if (_isSubscribed != value)
							{
								_isSubscribed = value;
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 2;
							}
							continue;
						case 0:
							break;
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
				WDJftJtPV1n("IsSubscribed");
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
				{
					num = 11;
				}
			}
		}
	}

	[JsonIgnore]
	public string StockAlertButtonText
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
						if (num == 990)
						{
							goto end_IL_0010;
						}
						goto case 2;
					case 1:
						if (IsSubscribed)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 2;
					case 2:
						return "到货提醒";
					case 0:
						return "取消提醒";
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[JsonIgnore]
	public string StockAlertTooltip
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
						if (num == 989)
						{
							break;
						}
						goto case 1;
					case 1:
						if (!IsSubscribed)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						return "取消该商品的到货邮件提醒";
					case 0:
						return "补货后通过邮件通知你";
					}
					break;
				}
			}
		}
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	private void WDJftJtPV1n(string propertyName)
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	public xbVf4FftyKLP9yqO5mWE()
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
					default:
						switch (num2)
						{
						case 990:
							break;
						default:
							goto end_IL_000e;
						case 9:
							goto IL_0078;
						}
						break;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 7;
						}
						continue;
					case 2:
						goto end_IL_000e;
					case 0:
						return;
						IL_0078:
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
						{
							num3 = 1;
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
	internal static bool uLsMGnZ2CNhbfSf2pVKV()
	{
		return t8dKCXZ2Q6fT7BXpgYXw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xbVf4FftyKLP9yqO5mWE Tvwi9KZ24r1tAM6jJaI7()
	{
		return (xbVf4FftyKLP9yqO5mWE)t8dKCXZ2Q6fT7BXpgYXw;
	}
}

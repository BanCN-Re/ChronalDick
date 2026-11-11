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
	private PropertyChangedEventHandler? m_PropertyChanged;

	internal static object t8dKCXZ2Q6fT7BXpgYXw;

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

	[JsonPropertyName("category")]
	[field: CompilerGenerated]
	public string Category
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("name")]
	[field: CompilerGenerated]
	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("description")]
	[field: CompilerGenerated]
	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("price")]
	[field: CompilerGenerated]
	public decimal Price
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("availableCount")]
	[field: CompilerGenerated]
	public int AvailableCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("issuedCount")]
	[field: CompilerGenerated]
	public int IssuedCount
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("isActive")]
	[field: CompilerGenerated]
	public bool IsActive
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("lowStockThreshold")]
	[field: CompilerGenerated]
	public int LowStockThreshold
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
	}

	[JsonPropertyName("isLowStock")]
	[field: CompilerGenerated]
	public bool IsLowStock
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set;
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
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<int>(AvailableCount);
			return null;
		}
	}

	[JsonIgnore]
	public string IssuedText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<int>(IssuedCount);
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
			return null;
		}
	}

	[JsonIgnore]
	public string WarningText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
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
			WDJftJtPV1n("StockAlertTooltip");
		}
	}

	[JsonIgnore]
	public string StockAlertButtonText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[JsonIgnore]
	public string StockAlertTooltip
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		add
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			PropertyChangedEventHandler val2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler val = (PropertyChangedEventHandler)System.Delegate.Combine((global::System.Delegate)(object)val2, (global::System.Delegate)(object)value);
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		remove
		{
			PropertyChangedEventHandler val2 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler val3 = default(PropertyChangedEventHandler);
			PropertyChangedEventHandler val = Interlocked.CompareExchange<PropertyChangedEventHandler>(ref this.m_PropertyChanged, val2, val3);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void WDJftJtPV1n(string propertyName)
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	public xbVf4FftyKLP9yqO5mWE()
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

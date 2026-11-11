using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using By1SFsLobKQOZCdh5qRg;
using EBJLMifNn8QeuhMRSx7U;
using Microsoft.UI.Xaml;
using VE4SD3fpOtryqPu1jwJE;
using ajau5tfpTXRk8mjlQPRa;
using qS8vkpL43FlTMgcj0rgs;
using v1AhFSfMblmp1q5wGqxg;
using xsbjKUfp9um80Gf8YymA;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockSkinCardViewModel : INotifyPropertyChanged
{
	private bool _isApplied;

	private string _resourceStatusText;

	[CompilerGenerated]
	private PropertyChangedEventHandler? m_PropertyChanged;

	private p1aif0fNieMbuxR5AlNF _Kind_k__BackingField;
	[field: CompilerGenerated]
	public p1aif0fNieMbuxR5AlNF Kind
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private ejKX8wfpsw8ins4MWI7J? _TwoDimensionalSkin_k__BackingField;
	[field: CompilerGenerated]
	public ejKX8wfpsw8ins4MWI7J? TwoDimensionalSkin
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private dZU6g2fptC4VZ350fMxJ? _FourDimensionalSkin_k__BackingField;
	[field: CompilerGenerated]
	public dZU6g2fptC4VZ350fMxJ? FourDimensionalSkin
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private m4wFTFfpZW4pcAqQZC1k? _FourDimensionalPart_k__BackingField;
	[field: CompilerGenerated]
	public m4wFTFfpZW4pcAqQZC1k? FourDimensionalPart
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string Id
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			ejKX8wfpsw8ins4MWI7J? twoDimensionalSkin = TwoDimensionalSkin;
			object obj = ((twoDimensionalSkin != null) ? twoDimensionalSkin.Id : null);
			if (obj == null)
			{
				dZU6g2fptC4VZ350fMxJ? fourDimensionalSkin = FourDimensionalSkin;
				obj = ((fourDimensionalSkin != null) ? fourDimensionalSkin.Id : null);
				if (obj == null)
				{
					m4wFTFfpZW4pcAqQZC1k? fourDimensionalPart = FourDimensionalPart;
					obj = ((fourDimensionalPart != null) ? fourDimensionalPart.Id : null) ?? string.Empty;
				}
			}
			return (string)obj;
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			ejKX8wfpsw8ins4MWI7J? twoDimensionalSkin = TwoDimensionalSkin;
			object obj = ((twoDimensionalSkin != null) ? twoDimensionalSkin.Name : null);
			if (obj == null)
			{
				dZU6g2fptC4VZ350fMxJ? fourDimensionalSkin = FourDimensionalSkin;
				obj = ((fourDimensionalSkin != null) ? fourDimensionalSkin.Name : null);
				if (obj == null)
				{
					m4wFTFfpZW4pcAqQZC1k? fourDimensionalPart = FourDimensionalPart;
					obj = ((fourDimensionalPart != null) ? fourDimensionalPart.Name : null) ?? "未知装扮";
				}
			}
			return (string)obj;
		}
	}

	public string Developer
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Invalid comparison between Unknown and I4
			ejKX8wfpsw8ins4MWI7J? twoDimensionalSkin = TwoDimensionalSkin;
			object obj = ((twoDimensionalSkin != null) ? twoDimensionalSkin.DeveloperName : null);
			if (obj == null)
			{
				dZU6g2fptC4VZ350fMxJ? fourDimensionalSkin = FourDimensionalSkin;
				obj = ((fourDimensionalSkin != null) ? fourDimensionalSkin.DeveloperName : null) ?? string.Empty;
			}
			string text = (string)obj;
			if (string.IsNullOrWhiteSpace(text))
			{
				if ((int)Kind != 3)
				{
					return "网易创作者";
				}
				return "网易 4D 组件";
			}
			return text;
		}
	}

	public string Summary
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			ejKX8wfpsw8ins4MWI7J? twoDimensionalSkin = TwoDimensionalSkin;
			object obj = ((twoDimensionalSkin != null) ? twoDimensionalSkin.Summary : null);
			if (obj == null)
			{
				dZU6g2fptC4VZ350fMxJ? fourDimensionalSkin = FourDimensionalSkin;
				obj = ((fourDimensionalSkin != null) ? fourDimensionalSkin.Summary : null);
				if (obj == null)
				{
					m4wFTFfpZW4pcAqQZC1k? fourDimensionalPart = FourDimensionalPart;
					obj = GetSlotName((fourDimensionalPart != null) ? new mWGKInfNzSRMjl3TLmeA?(fourDimensionalPart.Slot) : ((mWGKInfNzSRMjl3TLmeA?)null));
				}
			}
			return (string)obj;
		}
	}

	public string CoverUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			ejKX8wfpsw8ins4MWI7J? twoDimensionalSkin = TwoDimensionalSkin;
			object obj = ((twoDimensionalSkin != null) ? twoDimensionalSkin.TitleImageUrl : null);
			if (obj == null)
			{
				dZU6g2fptC4VZ350fMxJ? fourDimensionalSkin = FourDimensionalSkin;
				obj = ((fourDimensionalSkin != null) ? fourDimensionalSkin.TitleImageUrl : null);
				if (obj == null)
				{
					m4wFTFfpZW4pcAqQZC1k? fourDimensionalPart = FourDimensionalPart;
					obj = ((fourDimensionalPart != null) ? fourDimensionalPart.TitleImageUrl : null) ?? string.Empty;
				}
			}
			return (string)obj;
		}
	}

	public string MetricsText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Expected I4, but got Unknown
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			p1aif0fNieMbuxR5AlNF kind = Kind;
			switch ((int)kind)
			{
			case 0:
				return $"{TwoDimensionalSkin.DownloadCount:N0} 下载  ·  {TwoDimensionalSkin.LikeCount:N0} 喜欢";
			case 1:
				return "账户已有 · 2D";
			case 2:
				if (((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<mWGKInfNzSRMjl3TLmeA, string>>)FourDimensionalSkin.PartItemIds).Count > 0)
				{
					return $"账户已有 · 4D 整皮 · {((global::System.Collections.Generic.IReadOnlyCollection<KeyValuePair<mWGKInfNzSRMjl3TLmeA, string>>)FourDimensionalSkin.PartItemIds).Count} 件";
				}
				return "账户已有 · 4D 整皮";
			case 3:
			{
				global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral("账户已有 · ");
				m4wFTFfpZW4pcAqQZC1k? fourDimensionalPart = FourDimensionalPart;
				defaultInterpolatedStringHandler.AppendFormatted(GetSlotName((fourDimensionalPart != null) ? new mWGKInfNzSRMjl3TLmeA?(fourDimensionalPart.Slot) : ((mWGKInfNzSRMjl3TLmeA?)null)));
				defaultInterpolatedStringHandler.AppendLiteral(" · 品质 ");
				defaultInterpolatedStringHandler.AppendFormatted<int>(FourDimensionalPart.Rarity);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			default:
				return "账户已有";
			}
		}
	}

	public string ResourceStatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _resourceStatusText;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Expected O, but got Unknown
			string text = value?.Trim() ?? string.Empty;
			if (!string.Equals(_resourceStatusText, text, (StringComparison)4))
			{
				_resourceStatusText = text;
				PropertyChangedEventHandler? obj = this.PropertyChanged;
				if (obj != null)
				{
					obj.Invoke((object)this, new PropertyChangedEventArgs("ResourceStatusText"));
				}
			}
		}
	}

	public bool IsApplied
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return _isApplied;
		}
		[MethodImpl((MethodImplOptions)8)]
		set
		{
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Expected O, but got Unknown
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			if (_isApplied != value)
			{
				_isApplied = value;
				PropertyChangedEventHandler? obj = this.PropertyChanged;
				if (obj != null)
				{
					obj.Invoke((object)this, new PropertyChangedEventArgs("IsApplied"));
				}
				PropertyChangedEventHandler? obj2 = this.PropertyChanged;
				if (obj2 != null)
				{
					obj2.Invoke((object)this, new PropertyChangedEventArgs("AppliedVisibility"));
				}
			}
		}
	}

	public Visibility AppliedVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (IsApplied)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged;

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinCardViewModel(ejKX8wfpsw8ins4MWI7J skin, bool isApplied)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		_TwoDimensionalSkin_k__BackingField = skin ?? throw new ArgumentNullException("skin");
		_Kind_k__BackingField = (p1aif0fNieMbuxR5AlNF)(skin.IsFree ? 0 : 1);
		_isApplied = isApplied;
		_resourceStatusText = "资源：待校验";
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinCardViewModel(dZU6g2fptC4VZ350fMxJ skin, bool isApplied)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_FourDimensionalSkin_k__BackingField = skin ?? throw new ArgumentNullException("skin");
		_Kind_k__BackingField = (p1aif0fNieMbuxR5AlNF)2;
		_isApplied = isApplied;
		_resourceStatusText = "资源：待解析";
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockSkinCardViewModel(m4wFTFfpZW4pcAqQZC1k part, bool isApplied)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_FourDimensionalPart_k__BackingField = part ?? throw new ArgumentNullException("part");
		_Kind_k__BackingField = (p1aif0fNieMbuxR5AlNF)3;
		_isApplied = isApplied;
		_resourceStatusText = "资源：待解析";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetSlotName(mWGKInfNzSRMjl3TLmeA? slot)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected I4, but got Unknown
		return slot switch
		{
			(mWGKInfNzSRMjl3TLmeA)0L => "头饰", 
			(mWGKInfNzSRMjl3TLmeA)1L => "头部", 
			(mWGKInfNzSRMjl3TLmeA)2L => "上装", 
			(mWGKInfNzSRMjl3TLmeA)3L => "下装", 
			(mWGKInfNzSRMjl3TLmeA)4L => "背部", 
			(mWGKInfNzSRMjl3TLmeA)5L => "环绕", 
			(mWGKInfNzSRMjl3TLmeA)6L => "悬浮", 
			_ => "4D 组件", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

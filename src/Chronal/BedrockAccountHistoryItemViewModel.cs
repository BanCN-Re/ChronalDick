using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Imaging;
using T3KSF1f3LrL7n0SFo0BO;
using krYsZbfNFb7hi3LZTnl3;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockAccountHistoryItemViewModel
{
	[CompilerGenerated]
	private GYf3CQfNxVcknhl8gDAn _Model_k__BackingField;
	internal GYf3CQfNxVcknhl8gDAn Model
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Model_k__BackingField;
		}
	}

	public long Id
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.Id;
		}
	}

	public string GameUserId
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.GameUserId;
		}
	}

	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.DisplayName;
		}
	}

	public string AccountDisplayText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.AccountDisplayText;
		}
	}

	public string SavedAtValueText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.SavedAtValueText;
		}
	}

	public bool IsDetailsEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Model.Profile != null;
		}
	}

	[CompilerGenerated]
	private BitmapImage? _AvatarSource_k__BackingField;
	public BitmapImage? AvatarSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _AvatarSource_k__BackingField;
		}
	}

	[CompilerGenerated]
	private BitmapImage? _FrameSource_k__BackingField;
	public BitmapImage? FrameSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _FrameSource_k__BackingField;
		}
	}

	public Visibility FrameVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (FrameSource == null)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility GrowthVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Model.Profile == null)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility MissingGrowthVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Model.Profile == null)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public Visibility VipVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			if (profile != null && profile.VipLevel > 0)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	public string SecondaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			string text = ((profile == null) ? null : profile.Signature?.Trim());
			if (!string.IsNullOrWhiteSpace(text))
			{
				return text + "  ·  SAuth 已保存";
			}
			return "SAuth 已保存";
		}
	}

	public string LevelText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(3, 1);
			defaultInterpolatedStringHandler.AppendLiteral("Lv.");
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			defaultInterpolatedStringHandler.AppendFormatted<int>((profile != null) ? profile.Level : 0);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	public string VipText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
			defaultInterpolatedStringHandler.AppendLiteral("VIP ");
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			defaultInterpolatedStringHandler.AppendFormatted<int>((profile != null) ? profile.VipLevel : 0);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}
	}

	public string ExperienceText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			int num = ((profile != null) ? profile.Experience : 0);
			y6sHXkf3fhIBq5aFx6SX profile2 = Model.Profile;
			int num2 = ((profile2 != null) ? profile2.ExperienceNeeded : 0);
			if (num2 > 0)
			{
				return $"经验 {num} / {num2}";
			}
			return $"经验 {num}";
		}
	}

	public double ExperienceMaximum
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			return Math.Max(1, (profile != null) ? profile.ExperienceNeeded : 0);
		}
	}

	public double ExperienceValue
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			y6sHXkf3fhIBq5aFx6SX profile = Model.Profile;
			return Math.Min((double)((profile != null) ? profile.Experience : 0), ExperienceMaximum);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal BedrockAccountHistoryItemViewModel(GYf3CQfNxVcknhl8gDAn model)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		_Model_k__BackingField = model ?? throw new ArgumentNullException("model");
		y6sHXkf3fhIBq5aFx6SX profile = model.Profile;
		_AvatarSource_k__BackingField = CreateImageSource((profile != null) ? profile.AvatarUrl : null);
		y6sHXkf3fhIBq5aFx6SX profile2 = model.Profile;
		_FrameSource_k__BackingField = CreateImageSource((profile2 != null) ? profile2.FrameUrl : null);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BitmapImage? CreateImageSource(string? value)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		Uri val = default(Uri);
		if (Uri.TryCreate(value, (UriKind)1, out val) && (!(val.Scheme != Uri.UriSchemeHttp) || !(val.Scheme != Uri.UriSchemeHttps)))
		{
			return new BitmapImage(val)
			{
				DecodePixelWidth = 96,
				DecodePixelType = (DecodePixelType)1
			};
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MSc01sf3DGpdk89SaOBd;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Media.Imaging;
using T3KSF1f3LrL7n0SFo0BO;
using krYsZbfNFb7hi3LZTnl3;
using qS8vkpL43FlTMgcj0rgs;
using zabwm4f3ZfjEaKUH3iZp;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockAccountProfileDetailViewModel
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c
	{
		public static readonly __c __9;

		public static Func<w6dBwqf3936qgl9ghrK7, BedrockProfileStatisticViewModel> __9__0_0;

		public static Func<OWKoZxf3jBxC2YrDwBgN, string> __9__17_0;

		public static Func<string, bool> __9__25_0;

		[MethodImpl((MethodImplOptions)8)]
		static __c()
		{
			__9 = (__c)new __c();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal BedrockProfileStatisticViewModel __ctor_b__0_0(w6dBwqf3936qgl9ghrK7 statistic)
		{
			return (BedrockProfileStatisticViewModel)new BedrockProfileStatisticViewModel(statistic);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _get_TagsText_b__17_0(OWKoZxf3jBxC2YrDwBgN tag)
		{
			return tag.Name;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _get_FullLocationText_b__25_0(string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}
	}

	private y6sHXkf3fhIBq5aFx6SX _Profile_k__BackingField;
	[field: CompilerGenerated]
	internal y6sHXkf3fhIBq5aFx6SX Profile
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string TitleText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return DisplayName + " · 角色详情";
		}
	}

	public string DisplayName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Profile.Nickname))
			{
				return Profile.Nickname;
			}
			return "UID " + Profile.UserId;
		}
	}

	public string UserIdText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "UID " + Profile.UserId;
		}
	}

	public string GrowthText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Profile.ExperienceNeeded > 0)
			{
				return $"Lv.{Profile.Level} · 经验 {Profile.Experience:N0} / {Profile.ExperienceNeeded:N0}";
			}
			return $"Lv.{Profile.Level} · 经验 {Profile.Experience:N0}";
		}
	}

	public string VipText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Profile.VipLevel <= 0)
			{
				return "非会员";
			}
			return $"VIP {Profile.VipLevel}";
		}
	}

	public string SignatureText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Profile.Signature))
			{
				return Profile.Signature;
			}
			return "未设置";
		}
	}

	public string TagsText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Profile.Tags.Count != 0)
			{
				return string.Join("  ·  ", Enumerable.Select<OWKoZxf3jBxC2YrDwBgN, string>((global::System.Collections.Generic.IEnumerable<OWKoZxf3jBxC2YrDwBgN>)Profile.Tags, (Func<OWKoZxf3jBxC2YrDwBgN, string>)([MethodImpl((MethodImplOptions)8)] (OWKoZxf3jBxC2YrDwBgN tag) => tag.Name)));
			}
			return "未设置";
		}
	}

	public string DeveloperVerificationText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Profile.IsDeveloperVerified)
			{
				return "未认证";
			}
			return "已认证";
		}
	}

	public string FriendStatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Profile.IsFriend)
			{
				return "非好友";
			}
			return "已是好友";
		}
	}

	public string HomepageVisibilityText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Profile.IsHomepagePublic)
			{
				return "未公开";
			}
			return "公开";
		}
	}

	public string FullLocationText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Collections.Generic.IEnumerable<string> enumerable = Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)new string[3] { Profile.Province, Profile.City, Profile.Area }, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string value) => !string.IsNullOrWhiteSpace(value)));
			string text = string.Join(" · ", enumerable);
			if (text.Length != 0)
			{
				return text;
			}
			return "未提供";
		}
	}

	public string MaskedLocationText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!(FullLocationText == "未提供"))
			{
				return "省/市信息已隐藏";
			}
			return FullLocationText;
		}
	}

	public bool CanRevealLocation
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return FullLocationText != "未提供";
		}
	}

	public string HomepageBackgroundText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return FormatBackground(Profile.HomepageBackground);
		}
	}

	public string VisitCardBackgroundText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return FormatBackground(Profile.VisitCardBackground);
		}
	}

	private BitmapImage? _AvatarSource_k__BackingField;
	[field: CompilerGenerated]
	public BitmapImage? AvatarSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private BitmapImage? _FrameSource_k__BackingField;
	[field: CompilerGenerated]
	public BitmapImage? FrameSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private BitmapImage? _HomepageBackgroundSource_k__BackingField;
	[field: CompilerGenerated]
	public BitmapImage? HomepageBackgroundSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	private BitmapImage? _VisitCardBackgroundSource_k__BackingField;
	[field: CompilerGenerated]
	public BitmapImage? VisitCardBackgroundSource
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
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

	public Visibility HomepageBackgroundImageVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (HomepageBackgroundSource == null)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility VisitCardBackgroundImageVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (VisitCardBackgroundSource == null)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility StatisticsVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (((global::System.Collections.Generic.IReadOnlyCollection<BedrockProfileStatisticViewModel>)Statistics).Count == 0)
			{
				return (Visibility)1;
			}
			return (Visibility)0;
		}
	}

	public Visibility MissingStatisticsVisibility
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (((global::System.Collections.Generic.IReadOnlyCollection<BedrockProfileStatisticViewModel>)Statistics).Count == 0)
			{
				return (Visibility)0;
			}
			return (Visibility)1;
		}
	}

	private global::System.Collections.Generic.IReadOnlyList<BedrockProfileStatisticViewModel> _Statistics_k__BackingField;
	[field: CompilerGenerated]
	public global::System.Collections.Generic.IReadOnlyList<BedrockProfileStatisticViewModel> Statistics
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal BedrockAccountProfileDetailViewModel(GYf3CQfNxVcknhl8gDAn account)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		ArgumentNullException.ThrowIfNull((object)account, "account");
		_Profile_k__BackingField = account.Profile ?? throw new ArgumentException("历史账号缺少角色资料", "account");
		_AvatarSource_k__BackingField = BedrockAccountHistoryItemViewModel.CreateImageSource(Profile.AvatarUrl);
		_FrameSource_k__BackingField = BedrockAccountHistoryItemViewModel.CreateImageSource(Profile.FrameUrl);
		_HomepageBackgroundSource_k__BackingField = BedrockAccountHistoryItemViewModel.CreateImageSource(Profile.HomepageBackground);
		_VisitCardBackgroundSource_k__BackingField = BedrockAccountHistoryItemViewModel.CreateImageSource(Profile.VisitCardBackground);
		_Statistics_k__BackingField = (global::System.Collections.Generic.IReadOnlyList<BedrockProfileStatisticViewModel>)Enumerable.ToList<BedrockProfileStatisticViewModel>(Enumerable.Select<w6dBwqf3936qgl9ghrK7, BedrockProfileStatisticViewModel>((global::System.Collections.Generic.IEnumerable<w6dBwqf3936qgl9ghrK7>)Profile.Statistics, (Func<w6dBwqf3936qgl9ghrK7, BedrockProfileStatisticViewModel>)([MethodImpl((MethodImplOptions)8)] (w6dBwqf3936qgl9ghrK7 statistic) => (BedrockProfileStatisticViewModel)new BedrockProfileStatisticViewModel(statistic))));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatBackground(string value)
	{
		if (string.IsNullOrWhiteSpace(value) || value == "0")
		{
			return "默认背景";
		}
		Uri val = default(Uri);
		if (!Uri.TryCreate(value, (UriKind)1, out val))
		{
			return "资源 ID " + value;
		}
		return "已加载网络背景";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

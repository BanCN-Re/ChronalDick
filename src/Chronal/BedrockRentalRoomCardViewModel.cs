using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;
using yun8CRfanLkaBpPLfVrd;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockRentalRoomCardViewModel
{
	[CompilerGenerated]
	private readonly DAoPoufaie63jNVdbNug _Room_k__BackingField;

	public DAoPoufaie63jNVdbNug Room
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _Room_k__BackingField;
		}
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Room.ServerName))
			{
				return Room.ServerName;
			}
			return "未命名租赁房";
		}
	}

	public string RoomNumberText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "房间号 " + Room.RoomId;
		}
	}

	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return RoomNumberText + " · " + VersionText;
		}
	}

	public string PlayerText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return $"{Room.PlayerCount}/{Room.Capacity}";
		}
	}

	public string PopularityText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Room.Popularity <= 0)
			{
				return "暂无热度";
			}
			return $"热度 {Room.Popularity}";
		}
	}

	public string LevelText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Room.MinimumLevel <= 0)
			{
				return "无等级门槛";
			}
			return $"等级要求 Lv.{Room.MinimumLevel}";
		}
	}

	public string PasswordText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Room.HasPassword)
			{
				return "无需密码";
			}
			return "需要密码";
		}
	}

	public string PasswordShortText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Room.HasPassword)
			{
				return "公开";
			}
			return "密码";
		}
	}

	public string LevelShortText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Room.MinimumLevel <= 0)
			{
				return "无门槛";
			}
			return $"Lv.{Room.MinimumLevel}";
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (Room.Status != 1)
			{
				return "状态异常";
			}
			return "状态正常";
		}
	}

	public string VersionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Room.MinecraftVersion))
			{
				return Room.MinecraftVersion;
			}
			return "版本未知";
		}
	}

	public string CoverUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Room.ImageUrl;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockRentalRoomCardViewModel(DAoPoufaie63jNVdbNug room)
	{
		_Room_k__BackingField = room;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

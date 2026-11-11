using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;
using zCVMnbfabiR2jSY2xUjH;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockLocalLobbyRoomCardViewModel
{
	[field: CompilerGenerated]
	private cwSYjVfuzDOvn8hKeZih _Room_k__BackingField;
	public cwSYjVfuzDOvn8hKeZih Room
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string Name
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Room.Name))
			{
				return Room.Name;
			}
			return "未命名公共房间";
		}
	}

	public string Description
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Room.Description))
			{
				return Room.Description;
			}
			return "暂无房间简介";
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

	public string PlayerText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Room.PlayerText;
		}
	}

	public string CategoryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Room.CategoryText;
		}
	}

	public string VersionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Room.VersionText;
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Room.StatusText;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockLocalLobbyRoomCardViewModel(cwSYjVfuzDOvn8hKeZih room)
	{
		_Room_k__BackingField = room;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

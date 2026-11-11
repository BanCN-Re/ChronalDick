using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using ROZe5Gf1WgRr9IZ64gbr;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

public sealed class BedrockServerCardViewModel
{
	[field: CompilerGenerated]
	private wjHCLDf1ydVEraHow39U _Server_k__BackingField;

	public wjHCLDf1ydVEraHow39U Server
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
			return Server.Name;
		}
	}

	public string Summary
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Server.BriefSummary;
		}
	}

	public string OnlineText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!string.IsNullOrWhiteSpace(Server.OnlineCount))
			{
				return Server.OnlineCount + " 人在线";
			}
			return "在线人数未知";
		}
	}

	public string CoverUrl
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Server.TitleImageUrl;
		}
	}

	public string PlatformText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			if (!Server.SupportsBedrock)
			{
				return "暂不兼容";
			}
			return "基岩移动端";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BedrockServerCardViewModel(wjHCLDf1ydVEraHow39U server)
	{
		_Server_k__BackingField = server;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

using System.Runtime.CompilerServices;
using c4PNM5fxD3whDVKOiLnG;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Views.Pages.Java;

internal static class JavaConnectionStatePresentation
{
	[MethodImpl((MethodImplOptions)8)]
	internal static string TitleOf(T9LWLtfx944ku4NynZ2L state)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected I4, but got Unknown
		return (int)state switch
		{
			0 => "正在准备后台宿主", 
			1 => "正在认证后台宿主", 
			2 => "正在准备连接资源", 
			3 => "正在启动本机入口", 
			4 => "本机入口已就绪", 
			5 => "正在等待客户端连接", 
			6 => "正在认证服务器连接", 
			7 => "连接转发中", 
			8 => "连接已断开", 
			9 => "正在停止连接", 
			10 => "连接失败", 
			_ => "连接状态未知", 
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

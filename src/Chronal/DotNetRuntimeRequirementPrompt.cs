using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using EqBvtpQE23GN9ilOJdU;
using Nl6u2nfO8Xs4sXOPR0Xb;
using WMO32gy5EZANSQKlHAx;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI;

internal static class DotNetRuntimeRequirementPrompt
{
	private const uint MbOkCancel = 1u;

	private const uint MbIconWarning = 48u;

	private const uint MbIconError = 16u;

	private const uint MbSetForeground = 65536u;

	private const uint MbTopMost = 262144u;

	private const int IdOk = 1;

	[MethodImpl((MethodImplOptions)8)]
	internal static void ShowAndOpenDownloadPage(tf8EyefO0PFtlyKQvCuo inspection)
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		ArgumentNullException.ThrowIfNull((object)inspection, "inspection");
		string text = ((object)inspection.HighestInstalledVersion)?.ToString() ?? "未检测到";
		string text2 = $"Chronal 需要 .NET 8 Runtime {FlpEVsQvGkcfr6CtRfn.MinimumVersion} 或更高版本。\n\n当前检测到：{text}\n" + "请前往 Chronal 官网下载并安装 .NET SDK 8.0.423 或更高版本。\n安装完成后，请重新启动 Chronal。\n\n下载地址：" + FlpEVsQvGkcfr6CtRfn.DownloadPageUri.AbsoluteUri + "\n\n点击“确定”前往下载页面；点击“取消”退出。";
		if (MessageBoxW(global::System.IntPtr.Zero, text2, "必须更新 .NET", 327729u) != 1)
		{
			return;
		}
		try
		{
			Process.Start(new ProcessStartInfo
			{
				FileName = FlpEVsQvGkcfr6CtRfn.DownloadPageUri.AbsoluteUri,
				UseShellExecute = true
			});
		}
		catch (global::System.Exception ex)
		{
			gX17swyO7x0JWQxdaD1.U3iyRWfbJV("dotnet-runtime", "无法自动打开 .NET 下载页面", ex);
			MessageBoxW(global::System.IntPtr.Zero, "无法自动打开浏览器，请手动访问：\n\n" + FlpEVsQvGkcfr6CtRfn.DownloadPageUri.AbsoluteUri, "无法打开下载页面", 327696u);
		}
	}

	[DllImport("user32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern int MessageBoxW(nint windowHandle, string text, string caption, uint type);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

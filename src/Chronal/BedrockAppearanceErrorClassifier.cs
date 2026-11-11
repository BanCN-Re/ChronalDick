using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using VyPltSXK5jOSOBpKDtdh;
using n8NbadXKtJ9NV5M8SPMn;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Controls.Bedrock;

internal static class BedrockAppearanceErrorClassifier
{
	[MethodImpl((MethodImplOptions)8)]
	internal static string Catalog(global::System.Exception exception)
	{
		return "目录失败：" + Message(exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string Resource(global::System.Exception exception)
	{
		if (!(exception is InvalidDataException))
		{
			if (!(exception is IOException))
			{
				if (exception is HttpRequestException)
				{
					return "资源下载失败：" + Message(exception);
				}
				return "资源准备失败：" + Message(exception);
			}
			return "资源读写失败：" + Message(exception);
		}
		return "资源无效：" + Message(exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string Apply(global::System.Exception exception)
	{
		if (!(exception is CbmXdIXKOkQnOR6mWB7i))
		{
			if (!(exception is Nc8kMNXKHi0AVOx2LbJ2))
			{
				if (exception is HttpRequestException)
				{
					return "装扮提交失败：" + Message(exception);
				}
				return "装扮应用失败：" + Message(exception);
			}
			return "回读待确认：" + Message(exception);
		}
		return "回读冲突：" + Message(exception);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Message(global::System.Exception exception)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		return AppShell.GetExceptionDisplayMessage(exception ?? throw new ArgumentNullException("exception"), "Message", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Controls\\Bedrock\\BedrockAppearanceErrorClassifier.cs", 30);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

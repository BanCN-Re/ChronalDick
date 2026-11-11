using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using LlvQkpftcKTPAsaRP0ff;
using MnCNHgfwhm1BlAufHdT1;
using bUfedyCg1PBqhqIkB8r;
using qS8vkpL43FlTMgcj0rgs;
using wO3EWmfw6peyoPKxQt8p;

namespace Mahiro_Account.UI.Navigation;

internal static class JavaAccessGuard
{
	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static async global::System.Threading.Tasks.Task<bool> EnsureAsync()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		dN4xMCftS2WHJlRJeqrU currentUser = AppShell.Api.CurrentUser;
		long? num = ((currentUser != null) ? new long?(currentUser.Id) : ((long?)null));
		if (!num.HasValue)
		{
			return false;
		}
		try
		{
			bool flag;
			UfjqWXfw4LbmaQBvftfE val2 = default(UfjqWXfw4LbmaQBvftfE);
			try
			{
				jvLOtufw5u5UGypgaMFF val = await AppShell.Api.ucf8G5snLP("java_launch", default(CancellationToken));
				dN4xMCftS2WHJlRJeqrU currentUser2 = AppShell.Api.CurrentUser;
				if ((currentUser2 != null) ? (currentUser2.Id != num) : num.HasValue)
				{
					return false;
				}
				if (val.Allowed)
				{
					return true;
				}
				flag = val.Status == "frozen";
			}
			catch (global::System.Exception obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				object obj2 = ((obj is UfjqWXfw4LbmaQBvftfE) ? obj : null);
				global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
				if (obj2 == null)
				{
					result = 0;
				}
				else
				{
					val2 = (UfjqWXfw4LbmaQBvftfE)obj2;
					string code = val2.Code;
					result = ((((code == "SERVICE_SUBSCRIPTION_REQUIRED" || code == "SERVICE_SUBSCRIPTION_FROZEN") ? 1 : 0) != 0) ? 1 : 0);
				}
				return (byte)result != 0;
			}).Invoke())
			{
				cywTmHCBonHBVDeOMyD.TdvClQfWA9((global::System.Exception)(object)val2, "ui-exception", "EnsureAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Navigation\\JavaAccessGuard.cs", 36);
				flag = val2.Code == "SERVICE_SUBSCRIPTION_FROZEN";
			}
			dN4xMCftS2WHJlRJeqrU currentUser3 = AppShell.Api.CurrentUser;
			if ((currentUser3 != null) ? (currentUser3.Id != num) : num.HasValue)
			{
				return false;
			}
			if (await AppShell.ConfirmAsync(flag ? "Java版启动订阅已冻结" : "需要订阅Java版启动服务", flag ? "请前往服务订阅解冻后再使用服务" : "你的时长已到期或未订阅，请前往服务订阅购买服务", "前往服务订阅"))
			{
				dN4xMCftS2WHJlRJeqrU currentUser4 = AppShell.Api.CurrentUser;
				if ((currentUser4 != null) ? (currentUser4.Id == num) : (!num.HasValue))
				{
					AppShell.Navigate(NavigationRegistry.MainPageType("services"));
				}
			}
		}
		catch (global::System.Exception exception)
		{
			AppShell.Error(AppShell.GetExceptionDisplayMessage(exception, "EnsureAsync", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\UI\\Navigation\\JavaAccessGuard.cs", 55));
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}
}

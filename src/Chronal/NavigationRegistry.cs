using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using MbgJAqLroveeTUtcYc7g;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.UI.Navigation;

internal static class NavigationRegistry
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0_1
	{
		public global::System.Type pageType;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass5_0_1()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _MainKeyOf_b__0(NavigationEntry entry)
		{
			return entry.PageType == pageType;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass6_0
	{
		public global::System.Type pageType;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass6_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _IsBedrockPage_b__0(NavigationEntry entry)
		{
			if (entry.PageType == pageType)
			{
				return entry.Key.StartsWith("bedrock_", (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass7_0
	{
		public global::System.Type pageType;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass7_0()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _IsJavaPage_b__0(NavigationEntry entry)
		{
			if (entry.PageType == pageType)
			{
				return entry.Key.StartsWith("java_", (StringComparison)4);
			}
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_4
	{
		public string key;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_4()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _Resolve_b__0(NavigationEntry entry)
		{
			return string.Equals(entry.Key, key, (StringComparison)4);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}
	}

	[CompilerGenerated]
	private static readonly global::System.Collections.Generic.IReadOnlyList<NavigationEntry> _MainPages_k__BackingField;

	[field: CompilerGenerated]
	internal static global::System.Collections.Generic.IReadOnlyList<NavigationEntry> MainPages
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _MainPages_k__BackingField;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type MainPageType(string key)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		bool flag;
		if (key != null)
		{
			switch (key.Length)
			{
			case 12:
			{
				char c = key[5];
				if (c != 'a')
				{
					if (c != 's' || !(key == "java_servers"))
					{
						break;
					}
				}
				else if (!(key == "java_account"))
				{
					break;
				}
				goto IL_00f5;
			}
			case 13:
				if (!(key == "java_versions"))
				{
					break;
				}
				goto IL_00f5;
			case 10:
				if (!(key == "java_skins"))
				{
					break;
				}
				goto IL_00f5;
			case 14:
				if (!(key == "java_instances"))
				{
					break;
				}
				goto IL_00f5;
			case 18:
				if (!(key == "java_compatibility"))
				{
					break;
				}
				goto IL_00f5;
			case 28:
				{
					if (!(key == "java_compatibility_instances"))
					{
						break;
					}
					goto IL_00f5;
				}
				IL_00f5:
				flag = true;
				goto IL_00fe;
			}
		}
		flag = false;
		goto IL_00fe;
		IL_00fe:
		if (flag)
		{
			key = "java_entry";
		}
		return Resolve(MainPages, key) ?? throw new ArgumentOutOfRangeException("key", (object)key, "未登记的页面键");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Type? ResolveMain(object? tag)
	{
		if (tag is string text && text.StartsWith("java_", (StringComparison)4) && text != "java_entry")
		{
			return Resolve(MainPages, "java_entry");
		}
		return Resolve(MainPages, tag);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string? MainKeyOf(global::System.Type? pageType)
	{
		__c__DisplayClass5_0_1 __8_locals3 = (__c__DisplayClass5_0_1)new __c__DisplayClass5_0_1();
		__8_locals3.pageType = pageType;
		if (__8_locals3.pageType != null)
		{
			return Enumerable.FirstOrDefault<NavigationEntry>((global::System.Collections.Generic.IEnumerable<NavigationEntry>)MainPages, (Func<NavigationEntry, bool>)([MethodImpl((MethodImplOptions)8)] (NavigationEntry entry) => entry.PageType == __8_locals3.pageType))?.Key;
		}
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsBedrockPage(global::System.Type? pageType)
	{
		__c__DisplayClass6_0 __8_locals3 = (__c__DisplayClass6_0)new __c__DisplayClass6_0();
		__8_locals3.pageType = pageType;
		if (__8_locals3.pageType != null)
		{
			return Enumerable.Any<NavigationEntry>((global::System.Collections.Generic.IEnumerable<NavigationEntry>)MainPages, (Func<NavigationEntry, bool>)([MethodImpl((MethodImplOptions)8)] (NavigationEntry entry) => entry.PageType == __8_locals3.pageType && entry.Key.StartsWith("bedrock_", (StringComparison)4)));
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsJavaPage(global::System.Type? pageType)
	{
		__c__DisplayClass7_0 __8_locals3 = (__c__DisplayClass7_0)new __c__DisplayClass7_0();
		__8_locals3.pageType = pageType;
		if (__8_locals3.pageType != null)
		{
			return Enumerable.Any<NavigationEntry>((global::System.Collections.Generic.IEnumerable<NavigationEntry>)MainPages, (Func<NavigationEntry, bool>)([MethodImpl((MethodImplOptions)8)] (NavigationEntry entry) => entry.PageType == __8_locals3.pageType && entry.Key.StartsWith("java_", (StringComparison)4)));
		}
		return false;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Type? Resolve(global::System.Collections.Generic.IReadOnlyList<NavigationEntry> entries, object? tag)
	{
		__c__DisplayClass8_0_4 __8_locals4 = (__c__DisplayClass8_0_4)new __c__DisplayClass8_0_4();
		__8_locals4.key = tag as string;
		if (__8_locals4.key == null || string.IsNullOrWhiteSpace(__8_locals4.key))
		{
			return null;
		}
		return Enumerable.FirstOrDefault<NavigationEntry>((global::System.Collections.Generic.IEnumerable<NavigationEntry>)entries, (Func<NavigationEntry, bool>)([MethodImpl((MethodImplOptions)8)] (NavigationEntry entry) => string.Equals(entry.Key, __8_locals4.key, (StringComparison)4)))?.PageType;
	}

	[MethodImpl((MethodImplOptions)8)]
	static NavigationRegistry()
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0509: Unknown result type (might be due to invalid IL or missing references)
		_MainPages_k__BackingField = new NavigationEntry[33]
		{
			(NavigationEntry)new NavigationEntry("home", "首页", "\ue80f", typeof(global::Mahiro_Account.Views.Pages.HomePage)),
			(NavigationEntry)new NavigationEntry("product", "商品", "\ue719", typeof(global::Mahiro_Account.Views.Pages.ProductPage)),
			(NavigationEntry)new NavigationEntry("productDetail", "商品详情", "\ue71b", typeof(global::Mahiro_Account.Views.Pages.ProductDetailPage)),
			(NavigationEntry)new NavigationEntry("balance", "余额与充值", "\ue8c7", typeof(global::Mahiro_Account.Views.Pages.PaymentCenterPage)),
			(NavigationEntry)new NavigationEntry("paymentOrders", "支付订单", "\ue8c7", typeof(global::Mahiro_Account.Views.Pages.PaymentOrdersPage)),
			(NavigationEntry)new NavigationEntry("balanceHistory", "余额流水", "\ue9d2", typeof(global::Mahiro_Account.Views.Pages.BalanceHistoryPage)),
			(NavigationEntry)new NavigationEntry("refundHistory", "退款历史", "\ue81c", typeof(global::Mahiro_Account.Views.Pages.RefundHistoryPage)),
			(NavigationEntry)new NavigationEntry("account", "账号与通知", "\ue713", typeof(global::Mahiro_Account.Views.Pages.AccountPage)),
			(NavigationEntry)new NavigationEntry("invitations", "我的邀请码", "\ue715", typeof(global::Mahiro_Account.Views.Pages.InvitationPage)),
			(NavigationEntry)new NavigationEntry("x19", "网易转 SAuth", "\ue715", typeof(global::Mahiro_Account.Views.Pages.X19LoginPage)),
			(NavigationEntry)new NavigationEntry("qrLogin", "扫码登录", "\ued14", typeof(global::Mahiro_Account.Views.Pages.QrLoginPage)),
			(NavigationEntry)new NavigationEntry("pay4399", "4399 转 SAuth", "\ue77b", typeof(global::Mahiro_Account.Views.Pages.Pay4399Page)),
			(NavigationEntry)new NavigationEntry("hook", "Hook 登录", "\ue71b", typeof(global::Mahiro_Account.Views.Pages.HookLoginPage)),
			(NavigationEntry)new NavigationEntry("services", "服务订阅", "\ue719", typeof(global::Mahiro_Account.Views.Pages.ServiceSubscriptionsPage)),
			(NavigationEntry)new NavigationEntry("toolbox", "工具箱", "\ue90f", typeof(global::Mahiro_Account.Views.Pages.ToolboxPage)),
			(NavigationEntry)new NavigationEntry("classic_launch", "经典版启动", "\ue7fc", typeof(global::D5dq98Zj0UIlWLL7BDu.BFW7DwZLAOwBnfcMB57)),
			(NavigationEntry)new NavigationEntry("classic_account", "账号配置", "\ue77b", typeof(global::P4nQc8LxjCxnxuINJP5.BpOjxVLPwPUO93lZkbW)),
			(NavigationEntry)new NavigationEntry("classic_downloads", "下载管理", "\ue896", typeof(global::uj1PrqjB4rcHFMlFGdp.iv7VBsjI8muRaeK8cVn)),
			(NavigationEntry)new NavigationEntry("bedrock_account", "账号配置", "\ue77b", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockAccountPage)),
			(NavigationEntry)new NavigationEntry("bedrock_versions", "版本管理", "\ue72e", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockVersionManagementPage)),
			(NavigationEntry)new NavigationEntry("bedrock_local_multiplayer", "联机大厅", "\ue968", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockOnlineLobbyPage)),
			(NavigationEntry)new NavigationEntry("bedrock_worlds", "单人世界", "\ue7f8", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockWorldsPage)),
			(NavigationEntry)new NavigationEntry("bedrock_servers", "服务器", "\ue968", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockServersPage)),
			(NavigationEntry)new NavigationEntry("bedrock_rentals", "租赁房", "\ue968", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockRentalRoomsPage)),
			(NavigationEntry)new NavigationEntry("bedrock_skins", "皮肤", "\ue8b9", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockSkinsPage)),
			(NavigationEntry)new NavigationEntry("bedrock_material_packs", "材质包", "\ue81e", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPacksPage)),
			(NavigationEntry)new NavigationEntry("bedrock_material_converter", "材质包转换", "\ue8a7", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockMaterialPackConverterPage)),
			(NavigationEntry)new NavigationEntry("bedrock_instances", "实例", "\ue7f4", typeof(global::Mahiro_Account.Views.Pages.Bedrock.BedrockInstancesPage)),
			(NavigationEntry)new NavigationEntry("java_entry", "Java 进服", "\ue968", typeof(global::Mahiro_Account.Views.Pages.Java.JavaHookEntryPage)),
			(NavigationEntry)new NavigationEntry("dealer", "经销商", "\ue716", typeof(global::Mahiro_Account.Views.Pages.DealerPage)),
			(NavigationEntry)new NavigationEntry("media", "Media", "\ue77b", typeof(global::Mahiro_Account.Views.Pages.MediaPage)),
			(NavigationEntry)new NavigationEntry("mcp", "MCP 工作台", "\ue896", typeof(global::Mahiro_Account.Features.McpStudio.Views.McpStudioPage)),
			(NavigationEntry)new NavigationEntry("about", "关于", "\ue946", typeof(global::Mahiro_Account.Views.Pages.AboutPage))
		};
	}
}

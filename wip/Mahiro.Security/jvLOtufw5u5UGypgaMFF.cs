using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace wO3EWmfw6peyoPKxQt8p;

public sealed class jvLOtufw5u5UGypgaMFF
{
	internal static object NPAMcT9Xp6U1Dvua77F0;

	[field: CompilerGenerated]
	public string ServiceCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string ServiceName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool Allowed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool IsLifetime
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool EnforcementEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool AdminBypassEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool Bypassed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public long RemainingSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.DateTime ServerNow
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.DateTime? ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 18;
			string status = default(string);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						string text;
						switch (num3)
						{
						default:
							if (num2 != 29)
							{
								if (num2 == 1010)
								{
									goto end_IL_0010;
								}
								goto case 10;
							}
							if (!(status == "disabled"))
							{
								num3 = 22;
								continue;
							}
							goto case 13;
						case 22:
							if (!(status == "unavailable"))
							{
								num3 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
								{
									num3 = 20;
								}
								continue;
							}
							goto case 2;
						case 7:
							text = "已订阅";
							goto IL_03cd;
						case 15:
							if (!(status == "admin_bypass"))
							{
								num = 29;
								break;
							}
							goto case 16;
						case 1:
						case 5:
						case 6:
						case 9:
						case 14:
						case 19:
						case 21:
							return result;
						case 8:
							result = "已到期";
							num3 = 23;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
							{
								num3 = 14;
							}
							continue;
						case 3:
						case 20:
							result = "未订阅";
							num3 = 6;
							continue;
						case 10:
							if ((status == "frozen"))
							{
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 15;
						case 16:
							result = "管理员免订阅";
							num3 = 19;
							continue;
						case 13:
							result = "当前免订阅";
							num3 = 9;
							continue;
						case 18:
							status = Status;
							num3 = 17;
							continue;
						case 17:
							if (!(status == "active"))
							{
								num3 = 11;
								continue;
							}
							goto case 12;
						case 0:
						case 4:
							result = "已冻结";
							num = 21;
							break;
						case 2:
							result = "服务不可用";
							num3 = 5;
							continue;
						case 12:
							if (!IsLifetime)
							{
								num3 = 7;
								continue;
							}
							text = "永久订阅";
							goto IL_03cd;
						case 11:
							{
								if (!(status == "expired"))
								{
									num3 = 10;
									continue;
								}
								goto case 8;
							}
							IL_03cd:
							result = text;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto end_IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
			}
		}
	}

	public string ExpiryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.DateTime? expiresAt = ExpiresAt;
			_ = 1;
			_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77;
			_ = 10;
			_ = expiresAt;
			return null;
		}
	}

	public string RemainingText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (num == 989)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 1:
						if (!IsLifetime)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num2 = 2;
							}
							break;
						}
						return "永久有效";
					case 0:
						return po0fwwufgVX(RemainingSeconds);
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 17;
			string status = default(string);
			string result = default(string);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						string text;
						switch (num3)
						{
						default:
							if (num2 != 29)
							{
								if (num2 == 1010)
								{
									goto end_IL_0010;
								}
								goto case 8;
							}
							if (!(status == "disabled"))
							{
								goto case 0;
							}
							num3 = 19;
							continue;
						case 8:
						case 9:
						case 10:
						case 11:
						case 12:
						case 21:
							return result;
						case 5:
						case 19:
							result = "服务当前未强制校验订阅时长";
							num3 = 11;
							continue;
						case 6:
							result = "管理员绕过已生效，不设置虚拟到期时间";
							num3 = 21;
							continue;
						case 22:
							result = "订阅已冻结，请先解冻";
							num3 = 10;
							continue;
						case 17:
							status = Status;
							num3 = 29;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num3 = 16;
							}
							continue;
						case 3:
						case 7:
							if (IsLifetime)
							{
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
								{
									num3 = 24;
								}
								continue;
							}
							goto case 2;
						case 13:
							if ((status == "expired"))
							{
								num3 = 29;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 14;
						case 14:
							if (!(status == "frozen"))
							{
								num3 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
								{
									num3 = 20;
								}
								continue;
							}
							goto case 22;
						case 2:
							text = string.Concat("到期 ", ExpiryText, "，剩余 ", RemainingText);
							break;
						case 1:
						case 18:
							result = string.Concat("原到期时间 ", ExpiryText);
							num3 = 9;
							continue;
						case 0:
						case 15:
							result = "购买套餐后可使用启动服务";
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 22;
							}
							continue;
						case 16:
							if ((status == "active"))
							{
								num3 = 21;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto case 13;
						case 20:
							if (!(status == "admin_bypass"))
							{
								goto end_IL_000c;
							}
							goto case 6;
						case 4:
							text = "永久订阅，永久有效";
							break;
						}
						result = text;
						num3 = 12;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num = 29;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private jvLOtufw5u5UGypgaMFF(JsonElement value, string expectedCode)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jvLOtufw5u5UGypgaMFF YZxfwRIsyYJ(JsonElement value, object expectedCode)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		jvLOtufw5u5UGypgaMFF result = default(jvLOtufw5u5UGypgaMFF);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					result = (jvLOtufw5u5UGypgaMFF)new jvLOtufw5u5UGypgaMFF(value, (string)expectedCode);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num4 = 3;
						}
					}
					else
					{
						ex = obj2;
						num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num4 = 6;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 16)
							{
								if (num5 == 996)
								{
									goto IL_00c5;
								}
								goto case 1;
							}
							if (ex is OverflowException)
							{
								num4 = 2;
								continue;
							}
							goto case 5;
						case 8:
							if (!(ex is FormatException))
							{
								num5 = 16;
								goto IL_00c5;
							}
							goto case 1;
						case 4:
							flag = false;
							num4 = 6;
							continue;
						case 1:
						case 2:
							flag = true;
							num4 = 7;
							continue;
						case 5:
							if (ex is KeyNotFoundException)
							{
								num4 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							goto case 4;
						case 0:
							if (!(ex is InvalidOperationException))
							{
								num4 = 8;
								continue;
							}
							goto case 1;
						case 3:
							result2 = 0;
							break;
						case 6:
						case 7:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_00c5:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num6 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (num7 == 988)
							{
								goto IL_0229;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0229:
						num6 = num7;
					}
					_ = "服务端返回的访问状态无效，请重试。";
					throw ex;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string po0fwwufgVX(long seconds)
	{
		//IL_002b: Expected I4, but got I8
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		long num = default(long);
		defaultInterpolatedStringHandler.AppendFormatted<int>((int)System.Math.Max(1L, (long)System.Math.Ceiling((double)num / 60.0)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						return;
					case 1:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool nucZhc9XuZVDgZHenOIN()
	{
		return NPAMcT9Xp6U1Dvua77F0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jvLOtufw5u5UGypgaMFF NKQpZH9XaIxYDYxeuJmC()
	{
		return (jvLOtufw5u5UGypgaMFF)NPAMcT9Xp6U1Dvua77F0;
	}
}

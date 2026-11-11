using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using AoQT4XX8E915Zt2ELpoi;
using CZUx5njfSrbl1tnMcUCO;
using bjMUVyQHhKZ3abxaWAg;
using fDAldojjppXrctUVYOJn;

namespace YXMjNoXcouOKeTTRMKFH;

public class pTtxNQXcrrZ784qrl4Q2
{
	internal static object tVPCsJZBMuaDIAGI5e5y;

	[MethodImpl((MethodImplOptions)8)]
	public static string yAfXcm7NrMl(global::System.Exception exception, string fallbackNextStep)
	{
		int num = 2;
		string text = default(string);
		string text2 = default(string);
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
					default:
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						if (string.IsNullOrWhiteSpace(text))
						{
							return text2;
						}
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
						{
							num3 = 3;
						}
						continue;
					case 2:
						System.ArgumentNullException.ThrowIfNull(exception, "exception");
						num = 1;
						break;
					case 3:
					{
						string text3 = text;
						HttpMethod[] array = new HttpMethod[3];
						System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
						return string.Concat((text3).TrimEnd((char[])(object)array), "。下一步：", text2);
					}
					case 1:
						text = YUHXcBrM35B(exception);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
						text2 = aQAXc7WkDoo(exception, fallbackNextStep);
						num = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num = 8;
						}
						break;
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

	[MethodImpl((MethodImplOptions)8)]
	private static string aQAXc7WkDoo(object exception, object fallback)
	{
		IYqRmPX8vyafh8rWBeY0 yqRmPX8vyafh8rWBeY = default(IYqRmPX8vyafh8rWBeY0);
		string publicCode = yqRmPX8vyafh8rWBeY.PublicCode;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool j54XcAFrGFl(object message)
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
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 3;
				case 2:
					if (!(message).Contains("认证宿主", (StringComparison)4))
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num2 = 2;
						}
						break;
					}
					return true;
				case 1:
					if (string.IsNullOrWhiteSpace((string)message))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 3:
					return (message).Contains("官方启动器", (StringComparison)4);
				case 0:
					return false;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool qYRXcIxInbN(object message)
	{
		int num = 3;
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
					default:
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						goto IL_0130;
					case 2:
						if (!(message).Contains("确认进入服务器", (StringComparison)4))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto IL_0130;
					case 3:
						if (!string.IsNullOrWhiteSpace((string)message))
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						return false;
					case 0:
						if ((message).Contains("本机代理", (StringComparison)4))
						{
							break;
						}
						goto case 1;
					case 1:
						{
							return (message).Contains("进服确认", (StringComparison)4);
						}
						IL_0130:
						return true;
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
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string YUHXcBrM35B(object exception)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						return;
					case 0:
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool hvvfetZBpW6BShxoXFw2()
	{
		return tVPCsJZBMuaDIAGI5e5y == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static pTtxNQXcrrZ784qrl4Q2 cKfSKPZBuqu1DDTGuCG2()
	{
		return (pTtxNQXcrrZ784qrl4Q2)tVPCsJZBMuaDIAGI5e5y;
	}
}

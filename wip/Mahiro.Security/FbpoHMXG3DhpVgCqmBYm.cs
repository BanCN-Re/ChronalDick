using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace ap3MgVXGvTib4bByfaqS;

internal class FbpoHMXG3DhpVgCqmBYm
{
	private static object dRRB11ZF9VK7CK6l6cO1;

	[MethodImpl((MethodImplOptions)8)]
	internal static uint l1kXGEb5AaZ(object userId)
	{
		int num = 1;
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 992)
					{
						break;
					}
					goto case 1;
				case 3:
					if (num3 != 0)
					{
						num2 = 4;
						continue;
					}
					goto case 0;
				case 1:
					if (!uint.TryParse((string)userId, (NumberStyles)0, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num3))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 3;
				case 0:
				case 2:
					throw new global::System.Exception("4399 基岩会话缺少可用的玩家 ID");
				case 4:
					return num3 | 0x80000000u;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string KMkXG2h3TCM(object userId)
	{
		int num = 1;
		uint num3 = default(uint);
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
						break;
					}
					goto case 1;
				case 1:
					num3 = l1kXGEb5AaZ(userId);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					return (num3).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool OCVXGqU0NhY(uint authenticationUserId, object sessionUserId)
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
						break;
					}
					goto case 1;
				case 1:
					if (authenticationUserId != 0)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return false;
				case 0:
					return (authenticationUserId | 0x80000000u) == l1kXGEb5AaZ(sessionUserId);
				}
				break;
			}
		}
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
							goto case 2;
						}
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool yd2eK7ZFDOKKSWBm2E3k()
	{
		return dRRB11ZF9VK7CK6l6cO1 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FbpoHMXG3DhpVgCqmBYm GpX82VZFk4JGr6FXD7gm()
	{
		return (FbpoHMXG3DhpVgCqmBYm)dRRB11ZF9VK7CK6l6cO1;
	}
}

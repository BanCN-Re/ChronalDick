using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using vn7xlPf1FYwDtjMIxHKN;

namespace vXfSi7f1TW3HoKO6A2WK;

public class oKZslXf1sWTcACbhIeXU
{
	private static object b1RdmC9SNxYgBoD4BT9i;


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
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num3 = 5;
						}
						continue;
					case 1:
						break;
					case 2:
						num3 = 1;
						continue;
					case 0:
						return;
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
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool WflvnM9SMuMxuPfOI8sx()
	{
		return b1RdmC9SNxYgBoD4BT9i == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oKZslXf1sWTcACbhIeXU TKFefU9Spe0CA7Ul0bRU()
	{
		return (oKZslXf1sWTcACbhIeXU)b1RdmC9SNxYgBoD4BT9i;
	}
}


internal static class __FixExt_oKZslXf1sWTcACbhIeXU
{
	[MethodImpl((MethodImplOptions)8)]
	public static string mn4f1NZaJmc(this Nafsw6f1xYhqCvXaY8qH kind, object serverId)
	{
		int num = 8;
		string text2 = default(string);
		string text = default(string);
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 5;
					case 4:
						text2 = "TanLobbyClient";
						num3 = 11;
						continue;
					case 2:
						break;
					case 10:
						_ = "基岩服务器 ID 不能为空";
						throw new global::System.Exception("serverId");
					case 7:
						switch (kind)
						{
						case Nafsw6f1xYhqCvXaY8qH.LocalLobby:
							break;
						case Nafsw6f1xYhqCvXaY8qH.NetworkGame:
							goto end_IL_0010_2;
						default:
							goto IL_0134;
						case Nafsw6f1xYhqCvXaY8qH.LobbyGame:
							goto IL_0187;
						case Nafsw6f1xYhqCvXaY8qH.RentalGame:
							goto IL_01b4;
						}
						goto case 4;
					case 8:
						if (!string.IsNullOrWhiteSpace((string)serverId))
						{
							num3 = 7;
							continue;
						}
						goto case 10;
					case 3:
						goto IL_0187;
					case 1:
						goto IL_01b4;
					case 0:
					case 12:
						_ = "kind";
						_ = (object)kind;
						throw new global::System.Exception("未知的基岩服务器会话类型");
					case 5:
					case 6:
					case 11:
						text = text2;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
						{
							num3 = 13;
						}
						continue;
					case 9:
						{
							return string.Concat((serverId).Trim(), ":", text);
						}
						IL_01b4:
						text2 = "RentalGame";
						num3 = 5;
						continue;
						IL_0187:
						text2 = "LobbyGame";
						num3 = 6;
						continue;
						IL_0134:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num3 = 17;
						}
						continue;
						end_IL_0010_2:
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
			text2 = "NetworkGame";
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
			{
				num = 19;
			}
		}
	}

}
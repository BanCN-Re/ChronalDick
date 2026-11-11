using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using ap3MgVXGvTib4bByfaqS;
using bgANk1XHxHNDrDTbYTNT;
using fDAldojjppXrctUVYOJn;
using fYjvfFf1p8udxK21D6pd;
using vXfSi7f1TW3HoKO6A2WK;
using vn7xlPf1FYwDtjMIxHKN;

namespace a4kXmJXHwPkIY3oLGSDv;

internal class eKqI2YXHRQijUbFDAROq
{
	internal static object wW2td4Z54pFKZYVFBAo4;

	[MethodImpl((MethodImplOptions)8)]
	internal static g1GdtbXHP9obZ7KZMjiU nwUXHeAagOn(object authentication, object session, object gameId, Nafsw6f1xYhqCvXaY8qH sessionKind)
	{
		int num = 5;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text2;
					switch (num3)
					{
					default:
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 9;
						}
						throw new global::System.Exception("基岩认证请求的服务器 SID 不匹配");
					case 6:
						if (sessionKind == Nafsw6f1xYhqCvXaY8qH.RentalGame)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num3 = 16;
							}
							break;
						}
						goto case 3;
					case 9:
						_ = "基岩服务器 ID 不能为空";
						throw new global::System.Exception("gameId");
					case 12:
						if (sessionKind != Nafsw6f1xYhqCvXaY8qH.LocalLobby)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 5;
							}
							break;
						}
						text2 = (((g1GdtbXHP9obZ7KZMjiU)authentication).NeteaseSid).Trim();
						goto IL_02a5;
					case 4:
						System.ArgumentNullException.ThrowIfNull(session, "session");
						num3 = 10;
						break;
					case 11:
						throw new global::System.Exception("基岩认证请求缺少客户端公钥");
					case 1:
						text2 = sessionKind.mn4f1NZaJmc(gameId);
						goto IL_02a5;
					case 3:
						if (sessionKind != Nafsw6f1xYhqCvXaY8qH.LocalLobby)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num3 = 14;
							}
							break;
						}
						goto case 0;
					case 8:
						if (!string.Equals(((g1GdtbXHP9obZ7KZMjiU)authentication).NeteaseSid, text, (StringComparison)4))
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 10:
						if (!string.IsNullOrWhiteSpace((string)gameId))
						{
							num3 = 12;
							break;
						}
						goto case 9;
					case 2:
						if (string.IsNullOrWhiteSpace(((g1GdtbXHP9obZ7KZMjiU)authentication).NeteaseSid))
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 3;
					case 5:
						System.ArgumentNullException.ThrowIfNull(authentication, "authentication");
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 4;
						}
						break;
					case 0:
						if (!string.IsNullOrWhiteSpace(((g1GdtbXHP9obZ7KZMjiU)authentication).ClientKey))
						{
							if (!string.IsNullOrWhiteSpace(((c7lEmkf1MoB1jUf1XEF1)session).Nickname))
							{
								num3 = 13;
								break;
							}
							goto case 7;
						}
						num3 = 11;
						break;
					case 7:
						throw new global::System.Exception("基岩会话缺少账号昵称");
					case 13:
						{
							g1GdtbXHP9obZ7KZMjiU g1GdtbXHP9obZ7KZMjiU = ((g1GdtbXHP9obZ7KZMjiU)authentication).q8rXHskiN6w();
							g1GdtbXHP9obZ7KZMjiU.Bit = "64";
							g1GdtbXHP9obZ7KZMjiU.DisplayName = ((c7lEmkf1MoB1jUf1XEF1)session).Nickname;
							g1GdtbXHP9obZ7KZMjiU.EngineVersion = ((c7lEmkf1MoB1jUf1XEF1)session).EngineVersion;
							g1GdtbXHP9obZ7KZMjiU.NeteaseSid = ((sessionKind == Nafsw6f1xYhqCvXaY8qH.LocalLobby) ? ((g1GdtbXHP9obZ7KZMjiU)authentication).NeteaseSid : text);
							g1GdtbXHP9obZ7KZMjiU.OsName = "android";
							g1GdtbXHP9obZ7KZMjiU.PatchVersion = ((c7lEmkf1MoB1jUf1XEF1)session).PatchVersion;
							g1GdtbXHP9obZ7KZMjiU.Uid = FbpoHMXG3DhpVgCqmBYm.l1kXGEb5AaZ(((c7lEmkf1MoB1jUf1XEF1)session).UserId);
							return g1GdtbXHP9obZ7KZMjiU;
						}
						IL_02a5:
						text = text2;
						num3 = 6;
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 20;
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
					case 2:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
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
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
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
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JvlQa2Z5hncgj3fb4Dyu()
	{
		return wW2td4Z54pFKZYVFBAo4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static eKqI2YXHRQijUbFDAROq Lei64OZ5UebdNmPkGX85()
	{
		return (eKqI2YXHRQijUbFDAROq)wW2td4Z54pFKZYVFBAo4;
	}
}

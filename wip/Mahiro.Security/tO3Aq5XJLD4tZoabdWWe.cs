using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace ydijFbXJjsm9K5ZGLW2Q;

internal class tO3Aq5XJLD4tZoabdWWe
{
	private static object VXVD4mZl36U0NvMllExo;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool slbXJZjLf8F(object commandLine)
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		int num = 30;
		string text = default(string);
		MatchCollection val = default(MatchCollection);
		bool flag = default(bool);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		int num4 = default(int);
		bool flag2 = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num5;
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 38)
						{
							if (num2 == 1019)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return false;
					case 13:
						if ((text).Equals("1.20.1", (StringComparison)5))
						{
							num3 = 15;
							continue;
						}
						goto case 23;
					case 12:
						return false;
					case 29:
						val = System.Text.RegularExpressions.Regex.Matches((string)commandLine, "\"[^\"]*\"|[^\\s\"]+", (RegexOptions)512, System.TimeSpan.FromMilliseconds(100.0));
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
						{
							num3 = 19;
						}
						continue;
					case 25:
						if (flag)
						{
							num3 = 18;
							continue;
						}
						goto case 26;
					case 11:
						if ((text2).Equals("--version", (StringComparison)5))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
							{
								num3 = 20;
							}
							continue;
						}
						goto case 16;
					case 22:
						text3 = null;
						num3 = 5;
						continue;
					case 2:
						text3 = text4;
						num3 = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
						{
							num3 = 1;
						}
						continue;
					case 20:
					case 28:
						if (num4 >= (val).Count)
						{
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 8;
					case 8:
						text2 = (((val).Item).Value).Trim('"');
						num3 = 9;
						continue;
					case 23:
						num5 = ((text).StartsWith("1.20.1-", (StringComparison)5) ? 1 : 0);
						goto IL_05b0;
					case 0:
						return string.Equals(text3, "client", (StringComparison)5);
					case 18:
						return true;
					case 10:
						text = text4;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 16;
						}
						continue;
					case 3:
						num4 = 0;
						num3 = 28;
						continue;
					case 26:
						if (!flag2)
						{
							num = 35;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num = 38;
							}
							break;
						}
						goto case 0;
					case 27:
						num4++;
						num3 = 20;
						continue;
					case 17:
						flag2 |= (text2).Equals("net.minecraft.client.main.Main", (StringComparison)5);
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
						{
							num3 = 16;
						}
						continue;
					case 6:
						text = text4;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
						{
							num3 = 11;
						}
						continue;
					case 5:
						flag3 = false;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							num3 = 11;
						}
						continue;
					case 30:
						if (!string.IsNullOrWhiteSpace((string)commandLine))
						{
							num3 = 29;
							continue;
						}
						goto case 12;
					case 16:
					case 31:
						if ((text2).Equals("--launchTarget", (StringComparison)5))
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 1;
					case 9:
						if (num4 + 1 >= (val).Count)
						{
							num3 = 35;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num3 = 24;
							}
							continue;
						}
						obj = (((val).Item).Value).Trim('"');
						goto IL_054c;
					case 14:
						if (text != null)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						num5 = 0;
						goto IL_05b0;
					case 7:
						flag2 = false;
						num = 3;
						break;
					case 21:
						if ((text2).Equals("--fml.mcVersion", (StringComparison)5))
						{
							num3 = 6;
							continue;
						}
						goto case 11;
					case 15:
						num5 = 1;
						goto IL_05b0;
					case 19:
						text = null;
						num3 = 38;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 22;
						}
						continue;
					case 4:
						if (text != null)
						{
							num3 = 31;
							continue;
						}
						goto case 10;
					case 24:
						obj = null;
						goto IL_054c;
					case 1:
						{
							flag3 |= (text2).Equals("--gameDir", (StringComparison)5) && !string.IsNullOrEmpty(text4);
							num3 = 17;
							continue;
						}
						IL_054c:
						text4 = (string)obj;
						num3 = 21;
						continue;
						IL_05b0:
						flag = string.Equals(text3, "forgeclient", (StringComparison)5) || string.Equals(text3, "fmlclient", (StringComparison)5);
						if (((uint)num5 & (flag3 ? 1u : 0u)) == 0)
						{
							return false;
						}
						num3 = 25;
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
						return;
					case 0:
						break;
					case 2:
						num3 = 1;
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
						{
							num3 = 5;
						}
						continue;
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
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kyvxrVZlvOPyRXSb38y1()
	{
		return VXVD4mZl36U0NvMllExo == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static tO3Aq5XJLD4tZoabdWWe H6VcmWZlEoYXmfdlkG20()
	{
		return (tO3Aq5XJLD4tZoabdWWe)VXVD4mZl36U0NvMllExo;
	}
}

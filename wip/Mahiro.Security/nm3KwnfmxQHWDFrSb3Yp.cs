using System;
using System.Runtime.CompilerServices;
using JPgXICfmPv2gt7AINPmw;

namespace gy3qU2fmFDFUY3VUJjh7;

internal class nm3KwnfmxQHWDFrSb3Yp
{
	private static readonly ValueTuple<string, YP04SOfmeWnija95j7YH, string>[] ToZfmNQnu5A;

	internal static object XVDiD7ZalmeoHm2503Sa;

	[MethodImpl((MethodImplOptions)8)]
	internal static YP04SOfmeWnija95j7YH aUjfms4HHN8(string? description, out string token, out string category)
	{
		//IL_0007: Expected I8, but got O
		token = default;
		category = default;
		return default(YP04SOfmeWnija95j7YH);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ot2fmT2WgsR(object description, object token)
	{
		int num = 11;
		int num6 = default(int);
		int num7 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						if (num2 != 18)
						{
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						goto case 8;
					case 5:
						num4 = ((!char.IsLetterOrDigit((description).Chars)) ? 1 : 0);
						break;
					case 1:
						return false;
					case 7:
						num7 = num6 + (token).Length;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
					case 10:
						if (num5 < (description).Length)
						{
							goto end_IL_000c;
						}
						goto case 6;
					case 3:
						if (num6 == 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto case 5;
					case 6:
						return false;
					case 4:
						return true;
					case 8:
						num6 = (description).IndexOf((string)token, num5, (StringComparison)5);
						num3 = 9;
						continue;
					case 9:
						if (num6 >= 0)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 1;
					case 11:
						num5 = 0;
						num3 = 10;
						continue;
					case 2:
						num4 = 1;
						break;
					}
					bool flag = num7 == (description).Length || !char.IsLetterOrDigit((description).Chars);
					if (((uint)num4 & (flag ? 1u : 0u)) == 0)
					{
						num5 = num7;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 0;
						}
					}
					else
					{
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num3 = 4;
						}
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 18;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool LT1BsdZad8NvLXl9TdtM()
	{
		return XVDiD7ZalmeoHm2503Sa == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static nm3KwnfmxQHWDFrSb3Yp suWnBAZaKCkqaCSOAFpr()
	{
		return (nm3KwnfmxQHWDFrSb3Yp)XVDiD7ZalmeoHm2503Sa;
	}
}

using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using IBO8khfs2hYQCxbFhKl7;
using fDAldojjppXrctUVYOJn;
using sIIqaHfsvUMJoArTBa4b;

namespace m1FBfcXL5qZEk0XEhB5j;

internal class w8YL4SXLOiKWeVS6KrTL
{
	internal static object BvoBW6Z7vkPxl4OElTQg;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool YAoXL62P8pA(object server, out Kng51rfsEb2iUOsBkQPY address)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool WrOXLRTKtqK(object value, out string host, out int port)
	{
		//IL_001a: Expected I8, but got O
		int num = default(int);
		host = default;
		port = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string yELXLwTm34n(object host)
	{
		int num = 4;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IL_000c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto IL_000c;
							}
							goto case 1;
						}
						return (text).Substring(1, (text).Length - 1 - 1);
					case 4:
						if ((host).Length <= 2)
						{
							num3 = 3;
							break;
						}
						goto case 2;
					case 2:
						if ((host).Chars == '[')
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
							{
								num3 = 10;
							}
							break;
						}
						goto case 1;
					case 1:
					case 3:
						return (string)host;
					case 0:
						if ((host).Chars == ']')
						{
							text = (string)host;
							num = 11;
							goto end_IL_0010;
						}
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num3 = 7;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool dhxXLe8frlo(object host)
	{
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Invalid comparison between Unknown and I4
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num4 = default(int);
		bool flag = default(bool);
		IPAddress val2 = default(IPAddress);
		char c = default(char);
		string text = default(string);
		UriHostNameType val = default(UriHostNameType);
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
						if (num2 != 31)
						{
							if (num2 == 1012)
							{
								goto end_IL_0010;
							}
							goto case 13;
						}
						goto case 5;
					case 9:
						num4 = 0;
						num3 = 6;
						continue;
					case 1:
						flag = false;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
						{
							num3 = 23;
						}
						continue;
					case 17:
						if (!System.Net.IPAddress.TryParse((string)host, out val2))
						{
							num = 2;
							break;
						}
						goto case 19;
					case 14:
						if (!char.IsWhiteSpace(c))
						{
							num3 = 22;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 22;
							}
							continue;
						}
						goto case 21;
					case 3:
						if (num4 >= 1)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 16;
					case 22:
						if (!char.IsControl(c))
						{
							num3 = 20;
							continue;
						}
						goto case 21;
					case 7:
						flag = false;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num3 = 8;
						}
						continue;
					case 24:
						flag = true;
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num3 = 13;
						}
						continue;
					case 4:
						num4 = (host).Length;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 20;
						}
						continue;
					case 13:
					case 23:
						return flag;
					case 8:
					case 15:
						if (flag)
						{
							num3 = 5;
							continue;
						}
						goto case 10;
					case 10:
					{
						HttpMethod[] array = new HttpMethod[5];
						System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
						if ((host).IndexOfAny((char[])(object)array) >= 0)
						{
							num = 31;
							break;
						}
						text = (string)host;
						num3 = 20;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
						{
							num3 = 9;
						}
						continue;
					}
					case 12:
						if (val - 1 <= 1)
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
							{
								num3 = 24;
							}
							continue;
						}
						goto case 1;
					case 16:
						flag = true;
						num3 = 15;
						continue;
					case 6:
					case 11:
						if (num4 >= (text).Length)
						{
							num3 = 17;
							continue;
						}
						goto case 18;
					case 18:
						c = (text).Chars;
						num3 = 14;
						continue;
					case 21:
						return false;
					case 20:
						num4++;
						num3 = 11;
						continue;
					case 19:
						return true;
					case 2:
						val = System.Uri.CheckHostName((string)host);
						num3 = 12;
						continue;
					case 0:
						if (num4 > 253)
						{
							num = 16;
							break;
						}
						goto case 7;
					case 5:
						return false;
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
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 9)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 2:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
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
			while (num2 == 990);
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lDATY3Z7EbBfdx82J5ta()
	{
		return BvoBW6Z7vkPxl4OElTQg == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static w8YL4SXLOiKWeVS6KrTL ADY2icZ72WTxSiQc6t5t()
	{
		return (w8YL4SXLOiKWeVS6KrTL)BvoBW6Z7vkPxl4OElTQg;
	}
}

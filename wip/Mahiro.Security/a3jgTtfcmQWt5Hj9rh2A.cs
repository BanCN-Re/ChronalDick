using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace uL5pbLfc77hLV1kBnvBc;

internal sealed class a3jgTtfcmQWt5Hj9rh2A : IComparer<string>
{
	[CompilerGenerated]
	private static a3jgTtfcmQWt5Hj9rh2A hNWfcIboksJ;

	internal static object UgVnbJZpZLyXXL4rLlYt;

	internal static a3jgTtfcmQWt5Hj9rh2A Instance
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return hNWfcIboksJ;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public int Compare(string? x, string? y)
	{
		int num = 8;
		string[] array = default(string[]);
		int num8 = default(int);
		int num5 = default(int);
		int num10 = default(int);
		int num11 = default(int);
		string[] array2 = default(string[]);
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num7 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num6;
					int num4;
					switch (num3)
					{
					default:
						if (num2 != 30)
						{
							if (num2 == 1011)
							{
								goto end_IL_0010;
							}
							goto case 19;
						}
						if (int.TryParse(array[num8], out num5))
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 29;
							}
							continue;
						}
						goto case 20;
					case 23:
						if (num10 != num11)
						{
							num3 = 11;
							continue;
						}
						num8++;
						num3 = 18;
						continue;
					case 11:
						return (num11).CompareTo(num10);
					case 12:
					case 21:
						if (num8 >= array2.Length)
						{
							num3 = 10;
							continue;
						}
						goto case 2;
					case 7:
						flag2 = ybJfcAPxYRA(y);
						num3 = 17;
						continue;
					case 13:
						if (!flag)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						return -1;
					case 19:
						return (System.StringComparer.Ordinal).Compare(x, y);
					case 14:
						array2 = (x).Split('.', (StringSplitOptions)0);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
						{
							num3 = 27;
						}
						continue;
					case 3:
						array = (y).Split('.', (StringSplitOptions)0);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 24;
						}
						continue;
					case 6:
					case 10:
						num6 = 0;
						goto IL_0306;
					case 0:
						return 1;
					case 2:
						if (int.TryParse(array2[num8], out num7))
						{
							num3 = 22;
							continue;
						}
						goto case 6;
					case 17:
						if (flag == flag2)
						{
							if (flag)
							{
								num3 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
								{
									num3 = 14;
								}
								continue;
							}
							goto case 19;
						}
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num3 = 14;
						}
						continue;
					case 5:
						return (System.StringComparer.Ordinal).Compare(x, y);
					case 9:
						num9 = System.Math.Max(array2.Length, array.Length);
						num3 = 15;
						continue;
					case 15:
						num8 = 0;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
						{
							num3 = 14;
						}
						continue;
					case 20:
						num4 = 0;
						break;
					case 4:
					case 18:
						if (num8 < num9)
						{
							num3 = 21;
							continue;
						}
						goto case 5;
					case 8:
						flag = ybJfcAPxYRA(x);
						num3 = 7;
						continue;
					case 1:
						if (num8 < array.Length)
						{
							goto end_IL_000c;
						}
						goto case 20;
					case 22:
						num6 = num7;
						goto IL_0306;
					case 16:
						{
							num4 = num5;
							break;
						}
						IL_0306:
						num10 = num6;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
						{
							num3 = 1;
						}
						continue;
					}
					num11 = num4;
					num3 = 23;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 30;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ybJfcAPxYRA(object? value)
	{
		int num = 5;
		string[] array = default(string[]);
		int num4 = default(int);
		int num5 = default(int);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						array = (value).Split('.', (StringSplitOptions)0);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num3 = 12;
						}
						continue;
					case 1:
					case 8:
						if (num4 >= array.Length)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 15;
							}
							continue;
						}
						goto case 3;
					case 4:
						num4 = 0;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 8;
						}
						continue;
					case 2:
						return false;
					case 7:
						num4++;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
						{
							num3 = 1;
						}
						continue;
					case 6:
						return false;
					case 3:
						if (int.TryParse(array[num4], out num5))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 2;
					case 0:
						return true;
					case 5:
						if (!string.IsNullOrWhiteSpace((string)value))
						{
							break;
						}
						goto case 6;
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
			num = 15;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public a3jgTtfcmQWt5Hj9rh2A()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 4;
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
						return;
					case 0:
						hNWfcIboksJ = (a3jgTtfcmQWt5Hj9rh2A)new a3jgTtfcmQWt5Hj9rh2A();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num = 11;
						break;
					case 3:
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						num = 3;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool s0TtVMZp9R4FF9rKDLns()
	{
		return UgVnbJZpZLyXXL4rLlYt == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static a3jgTtfcmQWt5Hj9rh2A Qh6tO2ZpDwUoOE72Zdck()
	{
		return (a3jgTtfcmQWt5Hj9rh2A)UgVnbJZpZLyXXL4rLlYt;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace tlx5YSfgdKLfFIZYSgdo;

internal class r1Ua3Dfgl70B0c3gZkrx
{
	private static object U8w5TDZ16j0UgKH1DT50;

	[MethodImpl((MethodImplOptions)8)]
	internal static string XQEfgKNLDry(string? rootPath = null)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool uc0fgH8VVTp(object path, object hash)
	{
		int num = 1;
		bool result = default(bool);
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
					return result;
				case 0:
					try
					{
						result = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)) == (string)hash);
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									num3 = num4;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_00e5;
								}
								(val).Dispose();
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
								{
									num5 = 5;
								}
								continue;
								end_IL_00e5:
								break;
							}
						}
					}
					goto case 2;
				case 1:
					break;
				}
				goto IL_0150;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0150;
				IL_0150:
				val = System.IO.File.OpenRead((string)path);
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string JJ1fgtDeGRl()
	{
		//IL_01ab: Expected O, but got I4
		int num = 7;
		int num4 = default(int);
		string[] array = default(string[]);
		string text2 = default(string);
		string text = default(string);
		string text3 = default(string);
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
						if (num2 != 16 && num2 == 997)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 0:
						if (num4 >= array.Length)
						{
							num = 9;
							break;
						}
						goto case 3;
					case 4:
						return text2;
					case 5:
						num4++;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							num3 = 14;
						}
						continue;
					case 8:
						text2 = System.IO.Path.Combine(text, text3);
						num3 = 2;
						continue;
					case 9:
						throw new global::System.Exception("未找到可用的中文字体，请安装微软雅黑或宋体");
					case 2:
						if (!System.IO.File.Exists(text2))
						{
							num3 = 5;
							continue;
						}
						goto case 4;
					case 1:
						num4 = 0;
						num = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num = 8;
						}
						break;
					case 3:
						text3 = array[num4];
						num3 = 8;
						continue;
					case 6:
						array = (string[])new object[3]
						{
							(object)"msyh.ttc",
							(object)"msyh.ttf",
							(object)"simsun.ttc"
						};
						num = 1;
						break;
					case 7:
						text = (string)20;
						num3 = 6;
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
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						break;
					case 0:
						return;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 0;
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kw0PsNZ1R0FABs3KnBDQ()
	{
		return U8w5TDZ16j0UgKH1DT50 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static r1Ua3Dfgl70B0c3gZkrx quZBbVZ1w0PgQaLAT1i0()
	{
		return (r1Ua3Dfgl70B0c3gZkrx)U8w5TDZ16j0UgKH1DT50;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace bm713PXSW9wl0Pu4IkPO;

internal class JYAXK1XSywgmWQ5Pnpka
{
	private static object jB00NgZBo1DE7uO2adTe;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string VyNXSJ0tSil(object path, global::System.ReadOnlySpan<byte> content)
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Expected O, but got Ref
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
					{
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						string text = System.IO.Path.GetDirectoryName((string)path);
						if (text == null)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						System.IO.Directory.CreateDirectory(text);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
						{
							num3 = 1;
						}
						continue;
					}
					case 2:
						break;
					case 1:
					{
						object[] obj = new object[6]
						{
							(object)path,
							(object)".corrupt-",
							null,
							null,
							null,
							null
						};
						DateTimeOffset val = System.DateTimeOffset.UtcNow;
						obj[2] = (object)(val).ToString("yyyyMMddHHmmssfff");
						obj[3] = (object)"-";
						Guid val2 = System.Guid.NewGuid();
						obj[4] = (object)(val2).ToString("N");
						obj[5] = (object)".bak";
						string text2 = string.Concat((string[])obj);
						System.IO.File.WriteAllBytes(text2, (byte[])(&content));
						return text2;
					}
					case 0:
						throw new global::System.Exception("Java 设置文件缺少父目录");
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
			System.ArgumentException.ThrowIfNullOrWhiteSpace((string)path, "path");
			num = 9;
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
							goto case 0;
						}
						return;
					case 1:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
						{
							num3 = 3;
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
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool tFPqRWZBmriveQGhw7YX()
	{
		return jB00NgZBo1DE7uO2adTe == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JYAXK1XSywgmWQ5Pnpka GU8En5ZB7ZFwcDs1qBOG()
	{
		return (JYAXK1XSywgmWQ5Pnpka)jB00NgZBo1DE7uO2adTe;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32;
using fDAldojjppXrctUVYOJn;
using vg0Xl17pmaCpCfNLKNQ;

namespace O4wwqTmFRZpFGt3kwme;

public class p7LWrnmxAeJORbM9fVd
{
	private static object QAJEccZ8ArsyodRyfXwF;

	[MethodImpl((MethodImplOptions)8)]
	public static bool uqZmssXTy3(string? executablePath)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0033: Expected I4, but got O
		//IL_0054: Expected O, but got I4
		//IL_00f5: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0091: Expected I4, but got O
		//IL_004e->IL0058: Incompatible stack types: I4 vs O
		//IL_01f6->IL0058: Incompatible stack types: I4 vs O
		//IL_017a->IL0058: Incompatible stack types: I4 vs O
		//IL_00ff->IL0058: Incompatible stack types: I4 vs O
		//IL_0201->IL0058: Incompatible stack types: I4 vs O
		//IL_0185->IL0058: Incompatible stack types: I4 vs O
		//IL_02a4->IL0058: Incompatible stack types: I4 vs O
		//IL_02af->IL0058: Incompatible stack types: I4 vs O
		//IL_0146->IL0058: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default(object);
		object obj5 = default(object);
		object obj3 = default(object);
		while (true)
		{
			object obj2;
			int num2;
			switch ((int)obj)
			{
			default:
				if ((nint)obj == 989)
				{
					continue;
				}
				goto case 1;
			case 0:
				break;
			case 1:
				{
					if (string.IsNullOrWhiteSpace(executablePath))
					{
						obj2 = 2;
						goto IL_0058;
					}
					goto IL_0247;
				}
				IL_0058:
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					case 6:
					case 9:
						break;
					default:
						if ((nint)obj4 != 20)
						{
							if ((nint)obj4 == 1000)
							{
								goto IL_0054;
							}
							goto case 1;
						}
						if (!FNVysd7MbY6qbJiCXpd.Oqy7u2u50w(System.IO.Path.Combine((string)obj5, "Updater\\MCLauncherUpdater.exe")))
						{
							obj2 = 8;
							continue;
						}
						goto case 7;
					case 7:
						if (System.IO.File.Exists(System.IO.Path.Combine((string)obj5, "4399pc.data")))
						{
							goto IL_00e8;
						}
						goto case 10;
					case 2:
					case 3:
					case 11:
						obj3 = 0;
						obj2 = 9;
						continue;
					case 4:
						goto end_IL_0058;
					case 10:
						num = ((!System.IO.File.Exists(System.IO.Path.Combine((string)obj5, "native_a50_cn.data"))) ? 1 : 0);
						goto IL_028e;
					case 12:
						goto IL_01cb;
					case 1:
						if (System.IO.File.Exists(System.IO.Path.Combine((string)obj5, "Mcl.Core.dll")))
						{
							goto IL_023d;
						}
						goto case 5;
					case 0:
						goto IL_0247;
					case 5:
					case 8:
						{
							num = 0;
							goto IL_028e;
						}
						IL_028e:
						obj3 = num;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							obj2 = 17;
						}
						continue;
					}
					goto end_IL_0010;
					continue;
					end_IL_0058:
					break;
				}
				goto IL_015b;
				IL_0247:
				if (!string.Equals(System.IO.Path.GetFileName(executablePath), "WPFLauncher.exe", (StringComparison)5))
				{
					num2 = 3;
					goto IL_0050;
				}
				goto IL_015b;
				IL_023d:
				num2 = 20;
				goto IL_0050;
				IL_015b:
				if (!FNVysd7MbY6qbJiCXpd.Oqy7u2u50w(executablePath))
				{
					obj2 = 11;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
					{
						obj2 = 13;
					}
					goto IL_0058;
				}
				goto IL_01cb;
				IL_00e8:
				num2 = 5;
				goto IL_0050;
				IL_0050:
				obj4 = num2;
				goto IL_0054;
				IL_01cb:
				obj5 = System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath(executablePath));
				obj2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
				{
					obj2 = 5;
				}
				goto IL_0058;
				IL_0054:
				obj2 = obj4;
				goto IL_0058;
				end_IL_0010:
				break;
			}
			break;
		}
		return (byte)(int)obj3 != 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string? BprmT7MRpR()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void aaYmNlGQBI(RegistryHive hive, RegistryView view, List<string> candidates)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0091->IL0012: Incompatible stack types: I4 vs O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								obj2 = 9;
							}
							continue;
						}
						goto IL_0031;
					case 1:
						goto end_IL_000e;
					case 0:
						return;
					case 2:
						break;
					}
					goto IL_0078;
					IL_0031:
					if ((nint)obj == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					obj2 = 8;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
					{
						obj2 = 1;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BjWtpBZ8Ir9YypX0k5Le()
	{
		return QAJEccZ8ArsyodRyfXwF == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static p7LWrnmxAeJORbM9fVd OhUxw9Z8BZCcsIJRYUhy()
	{
		return (p7LWrnmxAeJORbM9fVd)QAJEccZ8ArsyodRyfXwF;
	}
}

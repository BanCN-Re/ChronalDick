using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace ekR2se42a5PlT9uFPKr;

public class Oi7uFl4EImiZsTROCj0
{
	private static object Ipo5RFZc17rZ63sHWBbW;

	[MethodImpl((MethodImplOptions)8)]
	public static bool Iay4q0PyMq()
	{
		return HYO4GAtoHZ(JNVYTu71oRZRpWuML35.LegacyLocalDataRoot, GWj4iso6a3());
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HYO4GAtoHZ(object legacyDirectory, object localApplicationDataRoot)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_031e: Expected I4, but got O
		//IL_027b: Expected O, but got I4
		//IL_0241: Expected O, but got I4
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_01d0: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		//IL_01e4: Expected O, but got I4
		//IL_024e: Expected O, but got I4
		//IL_0066: Expected O, but got I4
		//IL_00c7: Expected I4, but got O
		//IL_0285->IL006a: Incompatible stack types: I4 vs O
		//IL_0055->IL006a: Incompatible stack types: I4 vs O
		//IL_0060->IL006a: Incompatible stack types: I4 vs O
		//IL_02cd->IL006a: Incompatible stack types: I4 vs O
		//IL_024b->IL006a: Incompatible stack types: I4 vs O
		//IL_0102->IL006a: Incompatible stack types: I4 vs O
		//IL_0161->IL006a: Incompatible stack types: I4 vs O
		//IL_01da->IL006a: Incompatible stack types: I4 vs O
		//IL_0258->IL006a: Incompatible stack types: I4 vs O
		//IL_0278->IL006a: Incompatible stack types: I4 vs O
		//IL_022b->IL006a: Incompatible stack types: I4 vs O
		//IL_010d->IL006a: Incompatible stack types: I4 vs O
		//IL_016c->IL006a: Incompatible stack types: I4 vs O
		//IL_02a9->IL006a: Incompatible stack types: I4 vs O
		//IL_0194->IL006a: Incompatible stack types: I4 vs O
		//IL_02e9->IL006a: Incompatible stack types: I4 vs O
		//IL_02b4->IL006a: Incompatible stack types: I4 vs O
		//IL_019f->IL006a: Incompatible stack types: I4 vs O
		//IL_02f4->IL006a: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj3 = default(object);
		object obj5 = default(object);
		object obj4 = default(object);
		object obj6 = default(object);
		object obj7 = default(object);
		do
		{
			object obj2;
			switch ((int)obj)
			{
			default:
				continue;
			case 1:
				if (!string.IsNullOrWhiteSpace((string)legacyDirectory))
				{
					obj2 = 24;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
					{
						obj2 = 10;
					}
					goto IL_006a;
				}
				goto IL_0278;
			case 0:
				break;
				IL_0278:
				obj3 = 0;
				obj2 = 6;
				goto IL_006a;
				IL_006a:
				while (true)
				{
					int num;
					switch ((int)obj2)
					{
					default:
						if ((nint)obj5 != 29)
						{
							if ((nint)obj5 == 1009)
							{
								goto IL_0066;
							}
							goto case 4;
						}
						goto end_IL_0010;
					case 4:
						obj4++;
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							obj2 = 18;
						}
						continue;
					case 8:
					{
						string text = jca4nWby0I(localApplicationDataRoot);
						obj6 = jca4nWby0I(legacyDirectory);
						obj7 = jca4nWby0I(System.IO.Path.Combine(text, "Mahiro-Account"));
						obj2 = 28;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							obj2 = 15;
						}
						continue;
					}
					case 15:
						if (string.Equals((string)obj6, (string)obj7, (StringComparison)5))
						{
							obj2 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								obj2 = 26;
							}
							continue;
						}
						goto case 13;
					case 13:
						obj3 = 0;
						num = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num = 29;
						}
						goto IL_0062;
					case 9:
					case 12:
						obj4 = 0;
						obj2 = 17;
						continue;
					case 14:
						obj3 = 0;
						num = 7;
						goto IL_0062;
					case 11:
					case 19:
						if (System.IO.Directory.Exists((string)obj6))
						{
							num = 12;
							goto IL_0062;
						}
						goto case 16;
					case 3:
						if (!System.IO.Directory.Exists((string)obj6))
						{
							obj2 = 2;
							continue;
						}
						goto case 0;
					case 2:
						obj3 = 1;
						obj2 = 20;
						continue;
					case 16:
						obj3 = 1;
						obj2 = 5;
						continue;
					case 21:
						JsW4zNSRK0(obj6);
						obj2 = 3;
						continue;
					case 1:
						break;
					case 10:
						if (string.IsNullOrWhiteSpace((string)localApplicationDataRoot))
						{
							obj2 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 8;
					case 0:
						System.Threading.Thread.Sleep(750);
						obj2 = 4;
						continue;
					case 17:
					case 18:
						if ((nint)obj4 >= 3)
						{
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
							{
								obj2 = 14;
							}
							continue;
						}
						goto case 21;
					case 5:
					case 6:
					case 7:
					case 20:
						goto end_IL_0010;
						IL_0066:
						obj2 = obj5;
						continue;
						IL_0062:
						obj5 = num;
						goto IL_0066;
					}
					break;
				}
				goto IL_0278;
				end_IL_0010:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		return (byte)(int)obj3 != 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GWj4iso6a3()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0087: Expected O, but got I4
		//IL_009b->IL0010: Incompatible stack types: I4 vs O
		//IL_0077->IL0010: Incompatible stack types: I4 vs O
		//IL_00a6->IL0010: Incompatible stack types: I4 vs O
		//IL_0082->IL0010: Incompatible stack types: I4 vs O
		object obj = 3;
		object obj3 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					return (string)obj3;
				case 1:
					return System.IO.Path.GetTempPath();
				case 2:
					if (string.IsNullOrWhiteSpace((string)obj3))
					{
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							obj2 = 4;
						}
						break;
					}
					goto case 0;
				case 3:
					obj3 = 28;
					obj2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
					{
						obj2 = 1;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string jca4nWby0I(object path)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool JsW4zNSRK0(object directory)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_00a6->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
		//IL_00b1->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 2:
						break;
					case 0:
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						obj2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							obj2 = 0;
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
			while ((nint)obj == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool i8xUaRZc3AdaFRh6jQi8()
	{
		return Ipo5RFZc17rZ63sHWBbW == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Oi7uFl4EImiZsTROCj0 Xspp1XZcv3Oe6k6LALyT()
	{
		return (Oi7uFl4EImiZsTROCj0)Ipo5RFZc17rZ63sHWBbW;
	}
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using gixOAdWhrxDGwqRU2Ad;
using r5LWFs73eOlXSX66CSK;

namespace n5qsBmWAIuoooY62Aod;

internal class SjeRtgW7D9l0uhTX0Bd
{
	private static readonly object gQRWdT6O6A;

	internal static object ViF2Z2ZS9h4GwJbrt0Gk;

	internal static string RootDirectory
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return JNVYTu71oRZRpWuML35.LocalDataRoot;
		}
	}

	private static string StateFile
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootDirectory, "state.json");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string BX5WIp7Qck(object key, string fallback = "")
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void OppWBrbmI0(object key, object value)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool iYDWgFYkkD(out Dictionary<string, string> state, out bool legacyPlaintext)
	{
		//IL_000d: Expected I8, but got O
		state = (Dictionary<string, string>)(long)System.StringComparer.Ordinal;
		legacyPlaintext = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool uqtWlVVWJ8(Dictionary<string, string> state)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0037: Expected I4, but got O
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_00c1: Expected O, but got I4
		//IL_0073: Expected O, but got I4
		//IL_00e3: Expected O, but got I4
		//IL_0090: Expected I4, but got O
		//IL_006d->IL0077: Incompatible stack types: I4 vs O
		//IL_004e->IL0010: Incompatible stack types: I4 vs O
		//IL_0059->IL0010: Incompatible stack types: I4 vs O
		//IL_01b7->IL0077: Incompatible stack types: I4 vs O
		//IL_00d5->IL0077: Incompatible stack types: I4 vs O
		//IL_012d->IL0077: Incompatible stack types: I4 vs O
		//IL_01c2->IL0077: Incompatible stack types: I4 vs O
		//IL_00e0->IL0077: Incompatible stack types: I4 vs O
		//IL_0138->IL0077: Incompatible stack types: I4 vs O
		//IL_00ed->IL0077: Incompatible stack types: I4 vs O
		object obj = 2;
		object obj8 = default(object);
		object obj5 = default(object);
		object obj6 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_0021;
				case 0:
					return (byte)(int)obj8 != 0;
				case 2:
					break;
				case 1:
				{
					object obj3 = VXaAp1W4E4bk5sRcew8.agNWrFriOv(state);
					object obj4 = 2;
					while (true)
					{
						switch ((int)obj4)
						{
						case 3:
							break;
						default:
							if ((nint)obj5 != 12)
							{
								if ((nint)obj5 == 992)
								{
									goto IL_0073;
								}
								goto case 0;
							}
							obj8 = 1;
							obj4 = 3;
							continue;
						case 1:
							System.IO.File.WriteAllText((string)obj6, (string)obj3, (Encoding)(object)0);
							obj4 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								obj4 = 4;
							}
							continue;
						case 4:
							System.IO.File.Move((string)obj6, StateFile, true);
							obj5 = 12;
							goto IL_0073;
						case 2:
							System.IO.Directory.CreateDirectory(RootDirectory);
							obj4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
							{
								obj4 = 4;
							}
							continue;
						case 0:
							{
								string stateFile = StateFile;
								string text = ".tmp-";
								object obj7 = System.Guid.NewGuid();
								obj6 = string.Concat(stateFile, text, (obj7).ToString("N"));
								obj4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									obj4 = 12;
								}
								continue;
							}
							IL_0073:
							obj4 = obj5;
							continue;
						}
						break;
					}
					goto case 0;
				}
				}
				goto IL_0037;
				IL_0021:
				if ((nint)obj == 990)
				{
					break;
				}
				goto IL_0037;
				IL_0037:
				obj6 = null;
				obj2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
				{
					obj2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool O0OowgZSD6PDkC8phKuu()
	{
		return ViF2Z2ZS9h4GwJbrt0Gk == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SjeRtgW7D9l0uhTX0Bd DakRP5ZSkBKIYwJjJlID()
	{
		return (SjeRtgW7D9l0uhTX0Bd)ViF2Z2ZS9h4GwJbrt0Gk;
	}
}

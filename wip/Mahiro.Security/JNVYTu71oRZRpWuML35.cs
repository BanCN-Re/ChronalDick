using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace r5LWFs73eOlXSX66CSK;

public class JNVYTu71oRZRpWuML35
{
	private static object AHTRtoZ8v9mrRwFnWNtk;

	public static string LocalDataRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return E6a7voe7Gv();
		}
	}

	public static string LegacyLocalDataRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return X7X7En4b06();
		}
	}

	public static string BedrockDataRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(LocalDataRoot, "Bedrock");
		}
	}

	public static string UpdateDataRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(LocalDataRoot, "update");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string E6a7voe7Gv(string? localApplicationDataRoot = null)
	{
		return System.IO.Path.Combine(qVa72albEY(localApplicationDataRoot), "Chronal");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string X7X7En4b06(string? localApplicationDataRoot = null)
	{
		return System.IO.Path.Combine(qVa72albEY(localApplicationDataRoot), "Mahiro-Account");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string qVa72albEY(string? localApplicationDataRoot)
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected I4, but got O
		//IL_00de->IL00de: Incompatible stack types: I4 vs O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		//IL_0079->IL0010: Incompatible stack types: I4 vs O
		//IL_00c2->IL0010: Incompatible stack types: I4 vs O
		//IL_00cd->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		object obj4 = default(object);
		while (true)
		{
			object obj = num;
			object obj3;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0010;
							}
						}
						else if (string.IsNullOrWhiteSpace((string)obj4))
						{
							obj2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								obj2 = 10;
							}
							continue;
						}
						goto case 4;
					case 1:
						if (string.IsNullOrWhiteSpace(localApplicationDataRoot))
						{
							obj2 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 3;
					case 4:
						return System.IO.Path.GetFullPath((string)obj4);
					case 2:
						return System.IO.Path.GetTempPath();
					case 3:
						obj3 = localApplicationDataRoot;
						break;
					case 0:
						obj3 = 28;
						break;
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
			obj4 = obj3;
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0090->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_009b->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
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
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						obj2 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						break;
					case 0:
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							obj2 = 2;
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
	internal static bool vvvSNjZ8ELTVF7icXFW9()
	{
		return AHTRtoZ8v9mrRwFnWNtk == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JNVYTu71oRZRpWuML35 voXW1eZ82kV0iiZFwyX3()
	{
		return (JNVYTu71oRZRpWuML35)AHTRtoZ8v9mrRwFnWNtk;
	}
}

using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using ibqOI7fwdAZ7fB5vumc9;

namespace mLmvCnJ22GFjtB7esCn;

internal class dYflYpJE9fRSxesdZZG
{
	private static object XiCJzTVBEl;

	private static object Fxh50ZZSOJtwXl7FKaKB;

	[MethodImpl((MethodImplOptions)8)]
	internal static string xpwJqwTSSx(object plainText)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_007d->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_001d;
				case 0:
					return We1JGrMgM4(plainText, System.Security.Cryptography.RandomNumberGenerator.GetBytes(8));
				case 1:
					break;
				}
				goto IL_0042;
				IL_001d:
				if ((nint)obj == 989)
				{
					break;
				}
				goto IL_0042;
				IL_0042:
				System.ArgumentNullException.ThrowIfNull(plainText, "plainText");
				obj2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
				{
					obj2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string We1JGrMgM4(object plainText, object salt)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] L14Ji3nHwW(object passwordBytes, object salt)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected I4, but got Unknown
		//IL_003f: Expected O, but got I4
		//IL_0047: Expected O, but got I4
		object obj2 = default(object);
		object obj = obj + obj2;
		_ = 4;
		object obj3 = default(object);
		byte[] array = System.Security.Cryptography.MD5.HashData((byte[])obj3);
		object obj4 = default(object);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)obj4);
		obj4 = array;
		object obj5 = default(object);
		obj2 = System.Math.Min(array.Length, ((global::System.Array)obj5).Length - obj);
		object obj6 = JsonContent.Create<YHY2llfwl8ExTrwU63sb>((YHY2llfwl8ExTrwU63sb)(object)array, (MediaTypeHeaderValue)(object)0, (JsonSerializerOptions)obj2);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_002b: Expected I4, but got O
		//IL_00ec->IL0012: Incompatible stack types: I4 vs O
		//IL_0106->IL0012: Incompatible stack types: I4 vs O
		//IL_007f->IL0012: Incompatible stack types: I4 vs O
		//IL_00f7->IL0012: Incompatible stack types: I4 vs O
		//IL_0099->IL0012: Incompatible stack types: I4 vs O
		//IL_00a4->IL0012: Incompatible stack types: I4 vs O
		int num = 4;
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
						{
							obj2 = 8;
						}
						continue;
					case 2:
						break;
					case 4:
						obj2 = 3;
						continue;
					case 0:
						return;
					case 1:
						XiCJzTVBEl = (System.Text.Encoding.ASCII).GetBytes("Salted__");
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							obj2 = 6;
						}
						continue;
					case 3:
						obj2 = 2;
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
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BVZpReZS5O6ohknk155E()
	{
		return Fxh50ZZSOJtwXl7FKaKB == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static dYflYpJE9fRSxesdZZG eQMgFKZS61vZwGtVL1c3()
	{
		return (dYflYpJE9fRSxesdZZG)Fxh50ZZSOJtwXl7FKaKB;
	}
}

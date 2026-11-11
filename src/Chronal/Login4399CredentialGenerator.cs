using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Services;

internal class Login4399CredentialGenerator
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass3_0_1
	{
		public string allowedCharacters;

		internal static __c__DisplayClass3_0_1 UWiZrhLGoBStD3iMXOih;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass3_0_1()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 0;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ee050290791c4dfbba3a13b8d87cc1bd != 0)
			{
				obj = 5;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _ValidatePrefix_b__0(char character)
		{
			return !(allowedCharacters).Contains(character);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool kt03XkLGmqciWTuuZ7xo()
		{
			return UWiZrhLGoBStD3iMXOih == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass3_0_1 x8O9KdLG74DSEI64Lqdf()
		{
			return UWiZrhLGoBStD3iMXOih;
		}
	}

	private const string UsernameAlphabet = "abcdefghijklmnopqrstuvwxyz0123456789";

	private const string PasswordAlphabet = "ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789";

	internal static Login4399CredentialGenerator u58E4GLEo7XKjRc33FQL;

	[MethodImpl((MethodImplOptions)8)]
	public static Login4399GeneratedCredentials Generate(string usernamePrefix, string passwordPrefix)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_008c->IL0010: Incompatible stack types: I4 vs O
		//IL_00e9->IL0010: Incompatible stack types: I4 vs O
		//IL_0097->IL0010: Incompatible stack types: I4 vs O
		//IL_00f4->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
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
					passwordPrefix = ValidatePrefix(passwordPrefix, "密码", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789._@-");
					obj2 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3a9f60458a5840868f1b224a8d25b071 == 0)
					{
						obj2 = 1;
					}
					continue;
				case 1:
					usernamePrefix = ValidatePrefix(usernamePrefix, "账号", "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
					obj2 = 7;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_401ab1a410ca4fdcae9d2ecf627c5703 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					break;
				}
				goto IL_00f4;
				IL_0021:
				if ((nint)obj == 990)
				{
					break;
				}
				goto IL_00f4;
				IL_00f4:
				string username = string.Concat(usernamePrefix, GenerateRandomText("abcdefghijklmnopqrstuvwxyz0123456789", System.Math.Max(8, 12 - (usernamePrefix).Length)));
				object password = string.Concat(passwordPrefix, GenerateRandomText("abcdefghijkmnopqrstuvwxyz", 1), GenerateRandomText("23456789", 1), GenerateRandomText("ABCDEFGHJKLMNPQRSTUVWXYZabcdefghijkmnopqrstuvwxyz23456789", System.Math.Max(8, 12 - (passwordPrefix).Length - 2)));
				return (Login4399GeneratedCredentials)new Login4399GeneratedCredentials(username, (string)password);
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ValidatePrefix(string? prefix, string fieldName, string allowedCharacters)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		//IL_0123->IL0010: Incompatible stack types: I4 vs O
		//IL_00a4->IL0010: Incompatible stack types: I4 vs O
		//IL_00f5->IL0010: Incompatible stack types: I4 vs O
		//IL_0093->IL0010: Incompatible stack types: I4 vs O
		//IL_006d->IL0010: Incompatible stack types: I4 vs O
		//IL_012e->IL0010: Incompatible stack types: I4 vs O
		//IL_0100->IL0010: Incompatible stack types: I4 vs O
		int num = 6;
		dynamic obj3 = default(object);
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
						if ((nint)obj != 13)
						{
							if ((nint)obj == 994)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto IL_012e;
					case 1:
					case 4:
						if ((prefix).Length <= 8)
						{
							obj2 = 2;
							continue;
						}
						goto IL_012e;
					case 3:
						prefix = string.Empty;
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_80d00e736d0b4f7dbce583e459774a86 != 0)
						{
							obj2 = 9;
						}
						continue;
					case 6:
						obj3 = (object)new __c__DisplayClass3_0_1();
						obj2 = 5;
						continue;
					case 2:
						break;
					case 0:
						if (prefix != null)
						{
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8a5abf847bb54a3aa56e2df86c0b5690 != 0)
							{
								obj2 = 8;
							}
							continue;
						}
						goto case 3;
					case 5:
						{
							((__c__DisplayClass3_0_1)obj3).allowedCharacters = allowedCharacters;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0c88e6c08eaf4e998e8fdd2c544cee2e == 0)
							{
								obj2 = 12;
							}
							continue;
						}
						IL_012e:
						throw new ArgumentException(string.Concat(fieldName, "前缀格式无效"), "prefix");
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
			if (!Enumerable.Any<char>((global::System.Collections.Generic.IEnumerable<char>)prefix, (Func<char, bool>)((__c__DisplayClass3_0_1)obj3)._ValidatePrefix_b__0))
			{
				break;
			}
			num = 13;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1e22fe50e3d646ca9b01633c735c9082 == 0)
			{
				num = 13;
			}
		}
		return prefix;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GenerateRandomText(string alphabet, int length)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_0051: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Expected O, but got Unknown
		//IL_0065->IL0010: Incompatible stack types: I4 vs O
		//IL_0082->IL0010: Incompatible stack types: I4 vs O
		//IL_00a1->IL0010: Incompatible stack types: I4 vs O
		//IL_0070->IL0010: Incompatible stack types: I4 vs O
		//IL_00bc->IL0010: Incompatible stack types: I4 vs O
		//IL_00ac->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		dynamic obj4 = default(object);
		object obj3 = default(object);
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						obj4++;
						obj2 = 3;
						continue;
					case 4:
						obj4 = 0;
						obj2 = 9;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e22115a4e7ab476da94f74d7e328d269 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 5:
						obj3 = new char[length];
						obj2 = 4;
						continue;
					case 1:
					case 3:
						if ((nint)obj4 >= ((global::System.Array)obj3).Length)
						{
							obj2 = 12;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1282ca3a3b4d42dea9c5c692937e35bc != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						break;
					case 2:
						break;
					case 0:
						return new string((char[])obj3);
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
			((short[])obj3)[obj4] = (short)((dynamic)alphabet).Chars;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BO9c5ILEmslbUl6RR3JG()
	{
		return u58E4GLEo7XKjRc33FQL == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Login4399CredentialGenerator P5J7DpLE7Gx7Oa9W3exa()
	{
		return u58E4GLEo7XKjRc33FQL;
	}
}

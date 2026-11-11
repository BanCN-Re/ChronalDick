using System;
using System.Runtime.CompilerServices;
using System.Text;
using ADsTHFfwIuATuUxi3Ft1;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using FJvjlndpUOkxUhuFgIS;
using fDAldojjppXrctUVYOJn;

namespace RwSnMBgzOLk6HpinFo8;

internal class odHi4XgnTUuhfF0lv5V
{
	private static object e3yl8XsgmI;

	private static object SydhGPZWZ3dxIlUChixi;

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static byte[] LYjlbKPnST(object request, object response)
	{
		//IL_0014: Expected O, but got I8
		Encoding obj = System.Text.Encoding.UTF8;
		object obj2 = ((mieS14fwAQU1Te76soXD)request).ClientTimestamp;
		object stream = default(object);
		kYflkfNaU1(stream, (obj).GetBytes((obj2).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture)));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] bDClXV9cwp(object channelId, object direction, object requestId, ulong sequence)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] ch1lfQbTIg(object prefix, ulong sequence)
	{
		object obj = default(object);
		(prefix).CopyTo((global::System.Array)obj, 0);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] XnFlLM1I0J(object sharedSecret, object clientNonce, object serverNonce)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_00de: Expected I4, but got O
		//IL_0194->IL0010: Incompatible stack types: I4 vs O
		//IL_0131->IL0010: Incompatible stack types: I4 vs O
		//IL_00c3->IL00d5: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		//IL_015a->IL0010: Incompatible stack types: I4 vs O
		//IL_013c->IL0010: Incompatible stack types: I4 vs O
		//IL_00ce->IL00d5: Incompatible stack types: I4 vs O
		//IL_009d->IL0010: Incompatible stack types: I4 vs O
		//IL_0165->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		object result = default(object);
		object obj3 = default(object);
		object obj5 = default(object);
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
						if ((nint)obj == 12)
						{
							goto IL_004e;
						}
						if ((nint)obj == 993)
						{
							goto end_IL_0010;
						}
						goto case 5;
					case 4:
					{
						result = o2ilD3PLfT(sharedSecret, obj3, e3yl8XsgmI, 72);
						object obj4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							obj4 = 0;
						}
						while (true)
						{
							switch ((int)obj4)
							{
							default:
								if ((nint)obj5 == 988)
								{
									goto IL_00d1;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_00d1:
							obj4 = obj5;
						}
						goto case 5;
					}
					case 3:
						(serverNonce).CopyTo((global::System.Array)obj3, ((global::System.Array)clientNonce).Length);
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							obj2 = 3;
						}
						break;
					case 1:
						if (((global::System.Array)clientNonce).Length == 32)
						{
							obj2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								obj2 = 0;
							}
							break;
						}
						goto IL_004e;
					case 5:
						return (byte[])result;
					case 0:
						if (((global::System.Array)serverNonce).Length == 32)
						{
							obj3 = new DateTimeOffset[64];
							obj2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
							{
								obj2 = 2;
							}
							break;
						}
						goto end_IL_000c;
					case 2:
						{
							(clientNonce).CopyTo((global::System.Array)obj3, 0);
							obj2 = 3;
							break;
						}
						IL_004e:
						throw new Xx8dQadM7RHxK5GyS7F("握手随机数长度无效。");
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string SAtljkyhtL(global::System.ReadOnlySpan<byte> value)
	{
		return (((System.Convert.ToBase64String(value, (Base64FormattingOptions)0)).TrimEnd('=')).Replace('+', '-')).Replace('/', '_');
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] WoTlZJQbOd(object value, object fieldName)
	{
		object obj = ((value).Replace('-', '+')).Replace('_', '/');
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] E33l98jufJ(object value, object fieldName)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] o2ilD3PLfT(object inputKeyMaterial, object salt, object info, int outputLength)
	{
		//IL_000a: Expected I4, but got O
		object obj = default(object);
		object obj2 = default(object);
		((sbyte[])obj)[((global::System.Array)obj).Length - 1] = (sbyte)(int)obj2;
		_ = 6;
		object obj3 = default(object);
		(obj3).ComputeHash((byte[])obj);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)obj);
		object obj4 = default(object);
		if (((global::System.Array)obj4).Length == 0)
		{
		}
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)obj4);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void kYflkfNaU1(object stream, object value)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void PPMlVURvNW(object stream, object value, object fieldName)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0094: Expected I4, but got O
		//IL_0079->IL008b: Incompatible stack types: I4 vs O
		//IL_0051->IL0010: Incompatible stack types: I4 vs O
		//IL_0084->IL008b: Incompatible stack types: I4 vs O
		//IL_005c->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		object value2 = default(object);
		object obj4 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						break;
					}
					goto case 2;
				case 2:
					value2 = E33l98jufJ(value, fieldName);
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
					{
						obj2 = 4;
					}
					continue;
				case 1:
				{
					kYflkfNaU1(stream, value2);
					object obj3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
					{
						obj3 = 4;
					}
					while (true)
					{
						switch ((int)obj3)
						{
						case 0:
							return;
						}
						if ((nint)obj4 == 988)
						{
							obj3 = obj4;
							continue;
						}
						return;
					}
				}
				case 0:
					return;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_002b: Expected I4, but got O
		//IL_00b2->IL0012: Incompatible stack types: I4 vs O
		//IL_0074->IL0012: Incompatible stack types: I4 vs O
		//IL_0098->IL0012: Incompatible stack types: I4 vs O
		//IL_007f->IL0012: Incompatible stack types: I4 vs O
		//IL_00a3->IL0012: Incompatible stack types: I4 vs O
		//IL_00f6->IL0012: Incompatible stack types: I4 vs O
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
						if ((nint)obj != 11)
						{
							if ((nint)obj == 992)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						e3yl8XsgmI = (System.Text.Encoding.UTF8).GetBytes("Mahiro-Account/v2/channel");
						obj2 = 4;
						continue;
					case 0:
						break;
					case 2:
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							obj2 = 1;
						}
						continue;
					case 3:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 1:
						obj2 = 3;
						continue;
					case 4:
						return;
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
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool f52RMXZW9oaPDVSkI6eR()
	{
		return SydhGPZWZ3dxIlUChixi == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static odHi4XgnTUuhfF0lv5V hfvT5PZWD5heRheV4cpL()
	{
		return (odHi4XgnTUuhfF0lv5V)SydhGPZWZ3dxIlUChixi;
	}
}

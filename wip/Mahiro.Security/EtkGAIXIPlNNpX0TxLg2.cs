using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using dDZeghfkcJHyjpQYG0bq;
using fDAldojjppXrctUVYOJn;
using rVq0LWfkfK0eTGp8Iklw;
using zE0qbMXGcR37qePea3rj;

namespace dHUo7PXIxudqosA07XUa;

internal class EtkGAIXIPlNNpX0TxLg2
{
	private static object csaXIvR5y6F;

	internal static object JOfdwTZOmgj9K1qdMbCN;

	[MethodImpl((MethodImplOptions)8)]
	internal static string lvmXIFsnqB3(object sdkUid, object sessionId)
	{
		int num = 3;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static StDSbnfkSH7fjEfMgMeT BsMXIspTUnX(object input)
	{
		return pnKqlafkXUAQlucSo3qa.C41fkL5dC6D(input);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static StDSbnfkSH7fjEfMgMeT OCMXITfJH0R(object innerJson)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string zoFXINEnq93(JsonElement source, object propertyName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string WqUXIM0Vxrg(int length)
	{
		//IL_005d: Expected O, but got I4
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 992)
					{
						break;
					}
					goto case 1;
				case 0:
				case 3:
					_ = "length";
					_ = (object)length;
					throw new global::System.Exception("随机十六进制标识长度必须为正偶数");
				case 4:
					return (System.Convert.ToHexString(System.Security.Cryptography.RandomNumberGenerator.GetBytes(length / 2))).ToLowerInvariant();
				case 1:
					if (length <= 0)
					{
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 2:
					if (length % 2 == 0)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 0;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void zoJXIpDl23j(JsonElement source, object propertyName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string WVFXIuXko5P(JsonElement source, object propertyName, object message)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string m7rXIa1psXk(JsonElement source, object propertyName, object fallback)
	{
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected I4, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		int num = 9;
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = default(JsonValueKind);
		string result = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto IL_017d;
						}
						goto IL_0123;
					case 9:
						if (!(source).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 8;
							continue;
						}
						val = (val2).ValueKind;
						num3 = 5;
						continue;
					case 8:
						return (string)fallback;
					case 2:
						result = (string)fallback;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							num3 = 10;
						}
						continue;
					case 5:
						switch (val - 3)
						{
						case 4:
							break;
						default:
							goto end_IL_000c;
						case 1:
							goto IL_00f6;
						case 2:
						case 3:
							goto IL_0123;
						case 0:
							goto IL_017d;
						}
						goto case 2;
					case 6:
						goto IL_00f6;
					case 7:
						goto IL_0123;
					case 0:
					case 1:
					case 10:
						return result;
					case 3:
						goto IL_017d;
					case 4:
						{
							obj = fallback;
							break;
						}
						IL_00f6:
						result = (val2).GetRawText();
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
						{
							num3 = 1;
						}
						continue;
						IL_017d:
						obj = (val2).GetString();
						if (obj != null)
						{
							break;
						}
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 4;
						}
						continue;
						IL_0123:
						throw string.Concat("SAuth 的 ", (string)propertyName, " 类型无效");
					}
					result = (string)obj;
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
					{
						num3 = 11;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0032: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
		_ = 9;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea;
		(0).Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
		csaXIvR5y6F = 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool eTGfoMZO7KgWDc71R73O()
	{
		return JOfdwTZOmgj9K1qdMbCN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static EtkGAIXIPlNNpX0TxLg2 HXoKQUZOAgkmGwjOrH5B()
	{
		return (EtkGAIXIPlNNpX0TxLg2)JOfdwTZOmgj9K1qdMbCN;
	}
}

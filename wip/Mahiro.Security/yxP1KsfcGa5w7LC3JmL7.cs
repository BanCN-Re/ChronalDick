using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace OCafisfciLUeKiM14YoD;

internal class yxP1KsfcGa5w7LC3JmL7
{
	private static object t6Ml00ZpJmtAFsrUp774;

	[MethodImpl((MethodImplOptions)8)]
	internal static string EdbfcnkO5vZ(object plaintext)
	{
		System.ArgumentNullException.ThrowIfNull(plaintext, "plaintext");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string? YUHfczXrfYc(object signed)
	{
		//IL_024a: Expected I8, but got I4
		int num = 1;
		string text = default(string);
		int num4 = default(int);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		long[] array = default(long[]);
		string text2 = default(string);
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
						if (num2 != 29)
						{
							if (num2 == 1010)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						return null;
					case 17:
						return null;
					case 0:
						if (!(signed).StartsWith("!x19sign!", (StringComparison)4))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							text = (signed).Substring(("!x19sign!").Length);
							num3 = 20;
						}
						continue;
					case 4:
						num4 = 0;
						num3 = 3;
						continue;
					case 10:
						num5 = 0;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num3 = 12;
						}
						continue;
					case 2:
						return null;
					case 19:
						array2 = (byte[])(object)new DateTimeOffset[array.Length * 8];
						num3 = 10;
						continue;
					case 6:
					case 15:
						array[num4] = System.Convert.ToInt64((text).Substring(num4 * 16, 16), 16);
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
						{
							num3 = 18;
						}
						continue;
					case 1:
						System.ArgumentNullException.ThrowIfNull(signed, "signed");
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num3 = 0;
						}
						continue;
					case 7:
						if ((text2).Length == 0)
						{
							num = 29;
							break;
						}
						goto case 11;
					case 9:
					case 21:
						(System.BitConverter.GetBytes((int)((uint[])(object)array)[num5])).CopyTo(array2, num5 * 8);
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
						{
							num3 = 8;
						}
						continue;
					case 18:
						num4++;
						num3 = 14;
						continue;
					case 20:
						if ((text).Length != 0)
						{
							num3 = 22;
							continue;
						}
						goto case 17;
					case 11:
						return text2;
					case 12:
					case 16:
						if (num5 < array.Length)
						{
							num3 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								num3 = 26;
							}
							continue;
						}
						goto case 5;
					case 5:
						text2 = ((System.Text.Encoding.UTF8).GetString(array2)).TrimEnd('\0');
						num3 = 7;
						continue;
					case 8:
						num5++;
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
						{
							num3 = 16;
						}
						continue;
					case 3:
					case 14:
						if (num4 < array.Length)
						{
							num3 = 6;
							continue;
						}
						goto case 13;
					case 13:
						rOUf0bv5XdN(array, qPsf0LxTrLG((System.Text.Encoding.UTF8).GetBytes("942894570397f6d1c9cca2535ad18a2b")));
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 19;
						}
						continue;
					case 22:
						if ((text).Length % 16 == 0)
						{
							array = (long[])(object)new StringContent[(text).Length / 16];
							num = 4;
							break;
						}
						num3 = 17;
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
	private static void rOUf0bv5XdN(object data, object key)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void eOjf0XBEf4j(object data, object key)
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long bKJf0f8ebCS(long sum, long first, long last, long index, long selector, object key)
	{
		return (((last >> 5) ^ (first << 2)) + ((first >> 3) ^ (last << 4))) ^ ((sum ^ first) + ((int)((uint[])key)[(index & 3) ^ selector] ^ last));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long[] qPsf0LxTrLG(object bytes)
	{
		int num = default(int);
		global::System.Span<byte> span = MemoryExtensions.AsSpan<byte>((byte[])bytes, num, System.Math.Min(8, ((global::System.Array)bytes).Length - num));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 2:
						break;
					case 0:
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 2;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num3 = 1;
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dWeyTfZpQQbEBcAm4ukt()
	{
		return t6Ml00ZpJmtAFsrUp774 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static yxP1KsfcGa5w7LC3JmL7 Ok8vHPZpCM48BtBc8Y1p()
	{
		return (yxP1KsfcGa5w7LC3JmL7)t6Ml00ZpJmtAFsrUp774;
	}
}

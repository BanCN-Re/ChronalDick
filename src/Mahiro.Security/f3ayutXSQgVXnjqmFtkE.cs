using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using FesHmbXyXjalPPopQtqa;
using fDAldojjppXrctUVYOJn;

namespace xPXpZIXSC8RgkW5Mb7bc;

internal class f3ayutXSQgVXnjqmFtkE
{
	private static object Od2D5NZBATWsSgBswoxf;

	[MethodImpl((MethodImplOptions)8)]
	internal static ValueTuple<string, string, string> mvoXS47y0hC(VbqBsOXybDRsY8YeCsTb settings, global::System.ReadOnlySpan<byte> body, DateTimeOffset now, global::System.ReadOnlySpan<byte> nonceBytes)
	{
		//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		string text3 = default(string);
		byte[] array = default(byte[]);
		int num6 = default(int);
		ValueTuple<string, string, string> result = default(ValueTuple<string, string, string>);
		string text2 = default(string);
		int num8 = default(int);
		string text5 = default(string);
		string text4 = default(string);
		long num4 = default(long);
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						text3 = (((System.Convert.ToBase64String(nonceBytes, (Base64FormattingOptions)0)).TrimEnd('=')).Replace('+', '-')).Replace('/', '_');
						num3 = 6;
						continue;
					case 4:
						try
						{
							string text = (System.Convert.ToHexString(System.Security.Cryptography.HMACSHA256.HashData(settings.ApiKey, array))).ToLowerInvariant();
							int num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num5 = 3;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 1:
									result = new ValueTuple<string, string, string>(text2, text3, text);
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num7 = 3;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 5;
					case 5:
						return result;
					case 6:
						text5 = (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(body))).ToLowerInvariant();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num3 = 3;
						}
						continue;
					case 7:
						break;
					case 3:
						text4 = string.Join('\n', new string[5]
						{
							"POST",
							(settings.Endpoint).AbsolutePath,
							text2,
							text3,
							text5
						});
						num3 = 8;
						continue;
					case 0:
						throw new ArgumentException("签名请求 Nonce 长度不足", "nonceBytes");
					case 2:
						System.ArgumentNullException.ThrowIfNull(settings, "settings");
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
						{
							num3 = 1;
						}
						continue;
					case 8:
						array = (System.Text.Encoding.UTF8).GetBytes(text4);
						num3 = 4;
						continue;
					case 1:
						if (nonceBytes.Length >= 16)
						{
							num4 = (now).ToUnixTimeSeconds();
							num3 = 7;
							continue;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
						{
							num3 = 12;
						}
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
			text2 = (num4).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
			num = 15;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PQhSyEZBIT24c30aCit8()
	{
		return Od2D5NZBATWsSgBswoxf == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static f3ayutXSQgVXnjqmFtkE l7wJHRZBBETDsufn3lol()
	{
		return (f3ayutXSQgVXnjqmFtkE)Od2D5NZBATWsSgBswoxf;
	}
}

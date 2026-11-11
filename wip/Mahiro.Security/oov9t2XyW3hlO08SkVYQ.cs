using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace rMkIZlXyJT7Lr8FeHxg2;

internal class oov9t2XyW3hlO08SkVYQ
{
	internal static object rr2WCcZlSc8cQJtIAQI0;

	[MethodImpl((MethodImplOptions)8)]
	internal static long LAyXyQWp8QR(object value)
	{
		int num = 1;
		long num4 = default(long);
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
						if (num2 != 9)
						{
							goto end_IL_0010;
						}
						goto IL_00a6;
					case 2:
						break;
					case 0:
						if (long.TryParse((string)value, (NumberStyles)0, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto IL_00a6;
					case 1:
						{
							edqXy7sn8XA(value, 1, 19, "游戏 ID");
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
							{
								num3 = 9;
							}
							continue;
						}
						IL_00a6:
						throw new global::System.Exception("Java 认证游戏 ID 无效");
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
			while (num2 == 990);
			if (num4 > 0)
			{
				break;
			}
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
			{
				num = 6;
			}
		}
		return num4;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int neMXyCQm7X6(object value)
	{
		int num = 2;
		int num4 = default(int);
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
						if (num2 != 10)
						{
							goto end_IL_0010;
						}
						if (!int.TryParse((string)value, (NumberStyles)0, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 1;
					case 2:
						break;
					case 0:
					case 3:
						throw new global::System.Exception("Java 认证 ID 无效");
					case 1:
						if (num4 > 0)
						{
							return num4;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
						{
							num3 = 7;
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
			while (num2 == 991);
			edqXy7sn8XA(value, 1, 10, "认证 ID");
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void B08Xy4xROug(object value)
	{
		int num = 13;
		int num4 = default(int);
		int num5 = default(int);
		char c = default(char);
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
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						goto IL_023f;
					case 1:
						throw new global::System.Exception("Java 认证 ServerId 长度无效");
					case 15:
						num4 = num5;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num3 = 13;
						}
						continue;
					case 5:
						if (c >= 'A')
						{
							num3 = 4;
							continue;
						}
						goto case 6;
					case 13:
						edqXy7sn8XA(value, 1, 41, "ServerId");
						num3 = 12;
						continue;
					case 14:
						if (num5 != (value).Length)
						{
							num3 = 18;
							continue;
						}
						goto case 1;
					case 18:
						if ((value).Length - num5 <= 40)
						{
							num3 = 15;
							continue;
						}
						goto case 1;
					case 2:
						if (c > 'f')
						{
							num3 = 5;
							continue;
						}
						goto IL_023f;
					case 12:
						num5 = (((value).Chars == '-') ? 1 : 0);
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						if (c > '9')
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
							{
								num3 = 25;
							}
							continue;
						}
						goto IL_023f;
					case 0:
					case 8:
						if (num4 < (value).Length)
						{
							num3 = 9;
							continue;
						}
						return;
					case 4:
						if (c <= 'F')
						{
							break;
						}
						goto case 6;
					case 6:
						throw new global::System.Exception("Java 认证 ServerId 格式无效");
					case 17:
						return;
					case 16:
						if (c < '0')
						{
							num3 = 11;
							continue;
						}
						goto case 3;
					case 10:
					case 11:
						if (c >= 'a')
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 5;
					case 7:
					case 9:
						{
							c = (value).Chars;
							num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 16;
							}
							continue;
						}
						IL_023f:
						num4++;
						num3 = 8;
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
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
			{
				num = 25;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void zrEXyhtvWL1(global::System.ReadOnlySpan<byte> seed)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] JFqXyUciw4U(object value)
	{
		int num = 14;
		byte[] array = default(byte[]);
		int num4 = default(int);
		char c = default(char);
		bool flag = default(bool);
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
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto end_IL_0010;
							}
							goto case 11;
						}
						array[num4] = (byte)c;
						num3 = 5;
						break;
					case 8:
						flag = true;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							num3 = 11;
						}
						break;
					case 11:
					case 15:
						if (!flag)
						{
							goto end_IL_000c;
						}
						goto case 2;
					case 12:
						flag = false;
						num3 = 15;
						break;
					case 2:
						throw new global::System.Exception("Java 认证 Token 格式无效");
					case 5:
						num4++;
						num3 = 7;
						break;
					case 9:
						num4 = 0;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
						{
							num3 = 4;
						}
						break;
					case 6:
						return array;
					case 10:
						if (c > '~')
						{
							num3 = 8;
							break;
						}
						goto case 12;
					case 0:
					case 3:
						c = (value).Chars;
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num3 = 1;
						}
						break;
					case 4:
					case 7:
						if (num4 < (value).Length)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num3 = 21;
							}
							break;
						}
						goto case 6;
					case 1:
						if (c >= '!')
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
							{
								num3 = 10;
							}
							break;
						}
						goto case 8;
					case 14:
						edqXy7sn8XA(value, 16, 16, "Token");
						num3 = 13;
						break;
					case 13:
						array = (byte[])(object)new DateTimeOffset[16];
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 9;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 22;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void MPoXyrjrOL4(global::System.ReadOnlySpan<byte> hash)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string MANXyoL2BHj(object value)
	{
		//IL_02d0: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Invalid comparison between Unknown and I4
		int num = 1;
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						try
						{
							JsonDocument val = System.Text.Json.JsonDocument.Parse((string)value, default(JsonDocumentOptions));
							int num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										goto IL_013b;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_013f;
								}
								try
								{
									JsonElement val2 = (val).RootElement;
									int num6 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 989)
											{
												num6 = num7;
												continue;
											}
											goto case 1;
										case 1:
											if ((int)(val2).ValueKind != 1)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
												{
													num6 = 7;
												}
												continue;
											}
											break;
										case 0:
											throw new global::System.Exception("Java 认证模组清单格式无效");
										}
										break;
									}
								}
								finally
								{
									int num8;
									if (val == null)
									{
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num8 = 0;
										}
										goto IL_024b;
									}
									goto IL_0293;
									IL_024b:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_0247;
											}
											goto end_IL_024b;
										case 0:
											goto end_IL_024b;
										case 1:
											break;
										case 2:
											goto end_IL_024b;
										}
										goto IL_0293;
										IL_0247:
										num8 = num9;
										continue;
										end_IL_024b:
										break;
									}
									goto end_IL_0213;
									IL_0293:
									(val).Dispose();
									num8 = 2;
									goto IL_024b;
									end_IL_0213:;
								}
								break;
								IL_013b:
								num4 = num5;
								continue;
								end_IL_013f:
								break;
							}
						}
						catch (JsonException ex)
						{
							JsonException ex2 = ex;
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num10 = 3;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										goto IL_02fd;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_02fd:
								num10 = num11;
							}
							_ = "Java 认证模组清单格式无效";
							throw ex2;
						}
						goto case 3;
					case 4:
						throw new global::System.Exception("Java 认证模组清单过长");
					case 1:
						if (!string.IsNullOrWhiteSpace((string)value))
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 2;
					case 2:
						return string.Empty;
					case 0:
						break;
					case 3:
						return (string)value;
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
			if ((System.Text.Encoding.UTF8).GetByteCount((string)value) <= 65535)
			{
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
				{
					num = 10;
				}
			}
			else
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void C5OXymquDHS(object value, object fieldName)
	{
		int num = 6;
		int num4 = default(int);
		string text = default(string);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						if (!string.IsNullOrWhiteSpace((string)value))
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 4;
					case 0:
						return;
					case 1:
					case 3:
						if (num4 >= (text).Length)
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 8;
					case 4:
						throw string.Concat("Java 认证", (string)fieldName, "长度无效");
					case 5:
						text = (string)value;
						num3 = 2;
						continue;
					case 8:
						if (char.IsControl((text).Chars))
						{
							num3 = 7;
							continue;
						}
						num4++;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num3 = 5;
						}
						continue;
					case 6:
						break;
					case 9:
						if ((System.Text.Encoding.UTF8).GetByteCount((string)value) <= 255)
						{
							num3 = 5;
							continue;
						}
						goto case 4;
					case 7:
						throw string.Concat("Java 认证", (string)fieldName, "格式无效");
					case 2:
						num4 = 0;
						num3 = 3;
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
			System.ArgumentException.ThrowIfNullOrWhiteSpace((string)fieldName, "fieldName");
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
			{
				num = 16;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void edqXy7sn8XA(object value, int minimumBytes, int maximumBytes, object fieldName)
	{
		int num = 2;
		int num4 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
						}
						else if (num4 >= minimumBytes)
						{
							num3 = 3;
							continue;
						}
						goto case 0;
					case 5:
						if (num4 != (value).Length)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						return;
					case 0:
					case 4:
						throw string.Concat("Java 认证", (string)fieldName, "长度无效");
					case 1:
						break;
					case 2:
						System.ArgumentNullException.ThrowIfNull(value, "value");
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						if (num4 > maximumBytes)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 5;
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
			num4 = (System.Text.Encoding.UTF8).GetByteCount((string)value);
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						return;
					case 0:
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
					case 1:
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 0;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool UJb0vZZlcjJ0M4HQvYpj()
	{
		return rr2WCcZlSc8cQJtIAQI0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oov9t2XyW3hlO08SkVYQ zVHAp5Zl0AyZcADFJDns()
	{
		return (oov9t2XyW3hlO08SkVYQ)rr2WCcZlSc8cQJtIAQI0;
	}
}

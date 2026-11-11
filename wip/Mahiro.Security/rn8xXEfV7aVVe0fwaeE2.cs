using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using P1n1jPfkwT8Dr0Ng2CNy;
using fDAldojjppXrctUVYOJn;
using iM65eRXiKVWZgs63pZCd;

namespace i8fQiNfVAr7iwvRTwAUy;

internal sealed class rn8xXEfV7aVVe0fwaeE2 : global::System.IDisposable
{
	private bool tyafVl8MmAC;

	[CompilerGenerated]
	private readonly string SCofVdCCeid;

	[CompilerGenerated]
	private readonly byte[] SoLfVKZ3Yk2;

	[CompilerGenerated]
	private readonly long VQCfVHmFHUn;

	internal static object LDUYZ7ZM0VEhqawVOQXh;

	internal string ContentUuid
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return SCofVdCCeid;
		}
	}

	internal byte[] Bytes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return SoLfVKZ3Yk2;
		}
	}

	internal long ExpiredAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return VQCfVHmFHUn;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private rn8xXEfV7aVVe0fwaeE2(string contentUuid, byte[] bytes, long expiredAt)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void D78fVIbog4U()
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		DateTimeOffset val = default(DateTimeOffset);
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
							goto case 0;
						}
						return;
					case 3:
						if (ExpiredAt <= 0)
						{
							break;
						}
						goto case 1;
					case 4:
						System.ObjectDisposedException.ThrowIf(tyafVl8MmAC, this);
						num3 = 3;
						continue;
					case 1:
						val = System.DateTimeOffset.UtcNow;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						if ((val).ToUnixTimeSeconds() >= ExpiredAt)
						{
							num3 = 2;
							continue;
						}
						return;
					case 2:
						throw new global::System.Exception("网易服务器资源解密密钥已过期");
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal rn8xXEfV7aVVe0fwaeE2 JunfVBcX95A()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001d;
				case 0:
					return (rn8xXEfV7aVVe0fwaeE2)new rn8xXEfV7aVVe0fwaeE2(ContentUuid, (byte[])(object)(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(Bytes).Clone(), ExpiredAt);
				case 1:
					break;
				}
				goto IL_0057;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0057;
				IL_0057:
				D78fVIbog4U();
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
				{
					num2 = 5;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rn8xXEfV7aVVe0fwaeE2 MH8fVg3NDLQ(object jwt, object userId, object deviceId)
	{
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		rn8xXEfV7aVVe0fwaeE2 result = default(rn8xXEfV7aVVe0fwaeE2);
		byte[] array4 = default(byte[]);
		string[] array = default(string[]);
		int num12 = default(int);
		JsonDocument val2 = default(JsonDocument);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		JsonElement val3 = default(JsonElement);
		int num8 = default(int);
		bool flag = default(bool);
		bool flag2 = default(bool);
		byte[] array3 = default(byte[]);
		JsonElement val5 = default(JsonElement);
		string text3 = default(string);
		long expiredAt = default(long);
		Guid val4 = default(Guid);
		int num11 = default(int);
		int num19 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
		global::System.Exception ex = default(global::System.Exception);
		int num14 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num17 = default(int);
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 11;
						}
						throw new global::System.Exception("网易服务器资源解密 JWT 格式无效");
					case 1:
					case 3:
					case 9:
					case 12:
						throw new global::System.Exception("网易资源解密会话参数无效");
					case 0:
						if (string.IsNullOrWhiteSpace((string)deviceId))
						{
							num3 = 12;
							continue;
						}
						goto case 2;
					case 5:
						return result;
					case 8:
						array4 = null;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
						{
							num3 = 11;
						}
						continue;
					case 11:
						try
						{
							string text = ((array[1]).Replace('-', '+')).Replace('_', '/');
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num12 == 990)
									{
										num4 = num12;
										continue;
									}
									goto case 1;
								case 0:
									val2 = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)array2, default(JsonDocumentOptions));
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										num4 = 2;
									}
									continue;
								case 1:
									array2 = System.Convert.FromBase64String((text).PadRight((text).Length + (4 - (text).Length % 4) % 4, '='));
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
									{
										num4 = 6;
									}
									continue;
								case 2:
									try
									{
										JsonElement val = (val2).RootElement;
										int num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num5 = 13;
										}
										while (true)
										{
											int num9;
											long num7;
											string text2;
											switch (num5)
											{
											default:
												if (num6 == 28)
												{
													goto IL_04a9;
												}
												if (num6 == 1008)
												{
													goto IL_029d;
												}
												goto case 7;
											case 0:
												val3 = (val).GetProperty("contentKey");
												num5 = 12;
												continue;
											case 10:
												if (num8 != 16)
												{
													num9 = 3;
													goto IL_0299;
												}
												goto IL_04a9;
											case 9:
												throw new global::System.Exception("网易服务器资源解密 JWT 内容无效");
											case 15:
												if (num8 == 32)
												{
													num9 = 28;
													goto IL_0299;
												}
												goto case 17;
											case 1:
											case 2:
												flag = !flag2;
												num5 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
												{
													num5 = 19;
												}
												continue;
											case 5:
												num8 = array3.Length;
												num5 = 13;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
												{
													num5 = 10;
												}
												continue;
											case 14:
												num7 = 0L;
												break;
											case 11:
											case 19:
												if (!flag)
												{
													if (!(val).TryGetProperty("expiredAt", out val5))
													{
														num5 = 14;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
														{
															num5 = 6;
														}
														continue;
													}
													num7 = (val5).GetInt64();
													break;
												}
												num5 = 12;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
												{
													num5 = 9;
												}
												continue;
											case 13:
												val3 = (val).GetProperty("contentUuid");
												num5 = 8;
												continue;
											case 12:
												array3 = (val3).GetBytesFromBase64();
												num5 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
												{
													num5 = 24;
												}
												continue;
											case 7:
											{
												object obj = (object)new rn8xXEfV7aVVe0fwaeE2(text3, array4, expiredAt);
												((rn8xXEfV7aVVe0fwaeE2)obj).D78fVIbog4U();
												array4 = null;
												result = (rn8xXEfV7aVVe0fwaeE2)obj;
												num5 = 20;
												continue;
											}
											case 4:
												flag = !System.Guid.TryParseExact(text3, "D", out val4);
												num9 = 16;
												goto IL_0299;
											case 17:
												flag2 = false;
												num5 = 2;
												continue;
											case 18:
												array4 = DfBwvtfkRjAfoURwFi9T.Y2efkxjf2eu(array3, userId, deviceId);
												num5 = 7;
												continue;
											case 3:
												if (num8 != 24)
												{
													num5 = 15;
													continue;
												}
												goto IL_04a9;
											case 16:
												if (flag)
												{
													num5 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
													{
														num5 = 11;
													}
													continue;
												}
												goto case 5;
											case 8:
												text2 = (val3).GetString();
												if (text2 != null)
												{
													goto IL_05f6;
												}
												num5 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
												{
													num5 = 6;
												}
												continue;
											case 6:
												text2 = string.Empty;
												goto IL_05f6;
											case 20:
												goto end_IL_02a1;
												IL_05f6:
												text3 = text2;
												num5 = 17;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
												{
													num5 = 0;
												}
												continue;
												IL_04a9:
												flag2 = true;
												num5 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
												{
													num5 = 1;
												}
												continue;
												IL_029d:
												num5 = num6;
												continue;
												IL_0299:
												num6 = num9;
												goto IL_029d;
											}
											expiredAt = num7;
											num5 = 18;
											continue;
											end_IL_02a1:
											break;
										}
									}
									finally
									{
										if (val2 != null)
										{
											int num10 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
											{
												num10 = 3;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 989)
													{
														num10 = num11;
														continue;
													}
													break;
												case 1:
													(val2).Dispose();
													num10 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
													{
														num10 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
									}
									break;
								}
								break;
							}
						}
						catch (object obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num13 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
								{
									num13 = 16;
								}
							}
							else
							{
								ex = obj3;
								num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
								{
									num13 = 1;
								}
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num14 != 18)
									{
										if (num14 == 998)
										{
											goto IL_06f6;
										}
										goto case 4;
									}
									goto case 0;
								case 6:
									if (ex is OverflowException)
									{
										num13 = 7;
										continue;
									}
									goto case 5;
								case 5:
									flag = false;
									num13 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
									{
										num13 = 9;
									}
									continue;
								case 2:
									if (ex is InvalidOperationException)
									{
										num13 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
										{
											num13 = 5;
										}
										continue;
									}
									goto case 6;
								case 8:
									if (ex is JsonException)
									{
										num13 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											num13 = 9;
										}
										continue;
									}
									goto case 10;
								case 10:
									if (!(ex is KeyNotFoundException))
									{
										num15 = 2;
										goto IL_06f2;
									}
									goto case 4;
								case 1:
									if (!(ex is FormatException))
									{
										num13 = 8;
										continue;
									}
									goto case 4;
								case 4:
								case 7:
								case 9:
									flag = true;
									num15 = 18;
									goto IL_06f2;
								case 3:
									result2 = 0;
									break;
								case 0:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_06f2:
									num14 = num15;
									goto IL_06f6;
									IL_06f6:
									num13 = num14;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num16 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
							{
								num16 = 3;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 988)
									{
										goto IL_08b1;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_08b1:
								num16 = num17;
							}
							_ = "网易服务器资源解密 JWT 无法解析";
							throw ex;
						}
						finally
						{
							int num18;
							if (array2 != null)
							{
								num18 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
								{
									num18 = 4;
								}
								goto IL_092e;
							}
							goto IL_09d7;
							IL_09d7:
							if (array3 == null)
							{
								num18 = 6;
								goto IL_092e;
							}
							goto IL_0970;
							IL_0970:
							System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array3);
							num18 = 2;
							goto IL_092e;
							IL_092e:
							while (true)
							{
								switch (num18)
								{
								default:
									if (num19 != 14)
									{
										if (num19 == 994)
										{
											goto IL_092a;
										}
										goto IL_09d7;
									}
									goto end_IL_08f6;
								case 1:
									break;
								case 5:
									System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array4);
									num18 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
									{
										num18 = 0;
									}
									continue;
								case 3:
									goto IL_09d7;
								case 2:
								case 6:
									if (array4 == null)
									{
										int num20 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
										{
											num20 = 1;
										}
										num19 = num20;
										goto IL_092a;
									}
									goto case 5;
								case 4:
									System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array2);
									num18 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
									{
										num18 = 7;
									}
									continue;
								case 0:
									goto end_IL_08f6;
									IL_092a:
									num18 = num19;
									continue;
								}
								break;
							}
							goto IL_0970;
							end_IL_08f6:;
						}
						goto case 5;
					case 4:
						if (string.IsNullOrWhiteSpace((string)jwt))
						{
							num3 = 3;
							continue;
						}
						goto case 7;
					case 6:
						array3 = null;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num3 = 8;
						}
						continue;
					case 7:
						if (string.IsNullOrWhiteSpace((string)userId))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 0;
					case 2:
						if ((deviceId).Length == 32)
						{
							array = (jwt).Split('.', (StringSplitOptions)0);
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
							{
								num3 = 10;
							}
							continue;
						}
						num = 9;
						break;
					case 10:
						if (array.Length == 3)
						{
							array2 = null;
							num3 = 6;
							continue;
						}
						num = 19;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		tyafVl8MmAC = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
					case 1:
						goto end_IL_000e;
					case 2:
						num3 = 1;
						continue;
					case 0:
						return;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool pwfJBOZM8yGg5gsiMiEX()
	{
		return LDUYZ7ZM0VEhqawVOQXh == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rn8xXEfV7aVVe0fwaeE2 UvHldqZMyJvbcGY4geAp()
	{
		return (rn8xXEfV7aVVe0fwaeE2)LDUYZ7ZM0VEhqawVOQXh;
	}
}

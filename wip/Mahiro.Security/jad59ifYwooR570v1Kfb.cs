using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace hcoG9TfYeiGJFV8pdp1h;

internal class jad59ifYwooR570v1Kfb
{
	private static object TqbnOfZM5tGpTu3XnIgk;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool gsEfYPBtOrj(object path)
	{
		int num = 2;
		bool result = default(bool);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Exception ex = default(global::System.Exception);
		int num7 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					return result;
				case 1:
					try
					{
						byte[] pixels = Mw8fYxH4xGE(path);
						int num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 == 991)
								{
									num3 = num5;
									continue;
								}
								goto end_IL_0071;
							case 0:
								if (!a0afYFqlsb0(pixels, 54, 20, 2, 12))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 2:
								num4 = (a0afYFqlsb0(pixels, 46, 52, 2, 12) ? 1 : 0);
								break;
							case 3:
								num4 = 0;
								break;
							case 1:
								goto end_IL_0071;
							}
							result = (byte)num4 != 0;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num3 = 1;
							}
							continue;
							end_IL_0071:
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num6 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num6 = 1;
							}
						}
						else
						{
							ex = obj2;
							num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
							{
								num6 = 1;
							}
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 != 16)
								{
									if (num7 == 996)
									{
										goto IL_0157;
									}
									goto case 3;
								}
								if (ex is InvalidDataException)
								{
									num6 = 4;
									continue;
								}
								goto case 7;
							case 0:
								if (!(ex is IOException))
								{
									num8 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
									{
										num8 = 3;
									}
									num7 = num8;
									goto IL_0157;
								}
								goto case 3;
							case 7:
								if (!(ex is UnauthorizedAccessException))
								{
									num6 = 5;
									continue;
								}
								goto case 3;
							case 3:
							case 4:
								flag = true;
								num6 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
								{
									num6 = 2;
								}
								continue;
							case 5:
							case 8:
								flag = false;
								num6 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
								{
									num6 = 9;
								}
								continue;
							case 1:
								result2 = 0;
								break;
							case 2:
							case 6:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0157:
								num6 = num7;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num9 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 == 989)
								{
									num9 = num10;
									continue;
								}
								break;
							case 1:
								result = false;
								num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
								{
									num9 = 5;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 0;
				case 2:
					System.ArgumentException.ThrowIfNullOrWhiteSpace((string)path, "path");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
					{
						num2 = 6;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static byte[] Mw8fYxH4xGE(object path)
	{
		//IL_003d: Expected O, but got I4
		//IL_011d: Expected O, but got I
		//IL_00ca: Expected O, but got I4
		//IL_00ca: Expected O, but got Ref
		//IL_03ab: Expected O, but got I4
		//IL_0127->IL006e: Incompatible stack heights: 1 vs 2
		//IL_00cf->IL00fd: Incompatible stack heights: 2 vs 1
		//IL_00d9->IL006e: Incompatible stack heights: 3 vs 2
		//IL_03b5->IL0147: Incompatible stack heights: 3 vs 2
		int num = 1;
		int num4 = default(int);
		FileStream val = default(FileStream);
		MemoryStream val2 = default(MemoryStream);
		int num23 = default(int);
		ZLibStream val3 = default(ZLibStream);
		byte[] array5 = default(byte[]);
		uint num20 = default(uint);
		int num21 = default(int);
		byte[] array4 = default(byte[]);
		int num14 = default(int);
		byte b4 = default(byte);
		byte b5 = default(byte);
		byte b3 = default(byte);
		int num11 = default(int);
		byte[] array3 = default(byte[]);
		int num17 = default(int);
		int num10 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num15 = default(int);
		int num9 = default(int);
		byte b = default(byte);
		byte b2 = default(byte);
		byte upperLeft = default(byte);
		int num19 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 0:
					try
					{
						byte* intPtr = stackalloc byte[8];
						global::System.Span<byte> span = (global::System.Span<byte>)8;
						int num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 11)
								{
									if (num4 != 991)
									{
										break;
									}
									goto IL_006a;
								}
								if (MemoryExtensions.SequenceEqual<byte>((global::System.Span<byte>)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref _PrivateImplementationDetails_._4C4B6A3BE1314AB86138BEF4314DDE022E600960D8689A2C8F8631802D20DAB6), (global::System.ReadOnlySpan<byte>)8))
								{
									_ = 2;
									continue;
								}
								goto case 0;
							case 1:
								(val).ReadExactly(span);
								num4 = 11;
								goto IL_006a;
							case 0:
								throw new global::System.Exception("皮肤不是 PNG 文件");
							case 2:
								val2 = (MemoryStream)(object)intPtr;
								_ = 3;
								continue;
							case 3:
								break;
								IL_006a:
								num3 = num4;
								continue;
							}
							break;
						}
						try
						{
							bool flag = false;
							int num5 = 2;
							while (true)
							{
								int num22;
								switch (num5)
								{
								default:
									if (num23 != 35)
									{
										if (num23 == 1015)
										{
											goto IL_0143;
										}
										goto case 13;
									}
									val3 = (ZLibStream)(object)0;
									_ = 16;
									continue;
								case 18:
									if (array5[9] == 6)
									{
										num5 = 26;
										continue;
									}
									goto case 17;
								case 23:
									if (num20 != 1229278788)
									{
										num5 = 19;
										continue;
									}
									goto case 5;
								case 22:
									if ((val2).Length == 0L)
									{
										num5 = 20;
										continue;
									}
									(val2).Position = 0L;
									num22 = 35;
									goto IL_013f;
								case 17:
									throw new global::System.Exception("皮肤 PNG 格式不受支持");
								case 1:
									flag = true;
									num22 = 27;
									goto IL_013f;
								case 26:
									if (array5[12] == 0)
									{
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 17;
								case 5:
									if (flag)
									{
										num5 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
										{
											num5 = 34;
										}
										continue;
									}
									goto case 20;
								case 11:
									if (num20 == 1229209940)
									{
										num22 = 14;
										goto IL_013f;
									}
									goto case 23;
								case 25:
									if (array5[8] == 8)
									{
										num5 = 18;
										continue;
									}
									goto case 17;
								case 0:
								case 15:
								case 19:
								case 27:
									if ((val).Position < (val).Length)
									{
										num22 = 4;
										goto IL_013f;
									}
									goto case 5;
								case 9:
									(val).ReadExactly((global::System.Span<byte>)array5);
									num22 = 3;
									goto IL_013f;
								case 24:
									if (System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array5, 4)) == 64)
									{
										num22 = 25;
										goto IL_013f;
									}
									goto case 17;
								case 8:
									if (num21 == 13)
									{
										num5 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
										{
											num5 = 13;
										}
										continue;
									}
									goto case 17;
								case 6:
									num21 = checked((int)System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)array4));
									num5 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
									{
										num5 = 6;
									}
									continue;
								case 14:
									(val2).Write((global::System.ReadOnlySpan<byte>)array5);
									num5 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
									{
										num5 = 34;
									}
									continue;
								case 2:
									array4 = new byte[8];
									num5 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
									{
										num5 = 0;
									}
									continue;
								case 20:
									throw new global::System.Exception("皮肤 PNG 数据不完整");
								case 3:
									(val).Position = checked((val).Position + 4);
									num5 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
									{
										num5 = 7;
									}
									continue;
								case 7:
									if (num20 == 1229472850)
									{
										num22 = 8;
										goto IL_013f;
									}
									goto case 11;
								case 12:
									array5 = new byte[num21];
									num5 = 22;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
									{
										num5 = 9;
									}
									continue;
								case 13:
									if (System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)array5) == 64)
									{
										num5 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
										{
											num5 = 24;
										}
										continue;
									}
									goto case 17;
								case 21:
									num20 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array4, 4));
									num5 = 12;
									continue;
								case 4:
								case 10:
									(val).ReadExactly((global::System.Span<byte>)array4);
									num5 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
									{
										num5 = 6;
									}
									continue;
								case 16:
									{
										try
										{
											int num6 = 256;
											int num7 = 39;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
											{
												num7 = 32;
											}
											while (true)
											{
												int num12;
												int num13;
												int num16;
												int num8;
												switch (num7)
												{
												default:
													if (num14 != 47 && num14 == 1027)
													{
														goto IL_05c3;
													}
													goto case 7;
												case 1:
													b4 = (byte)(b5 + b3);
													num7 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
													{
														num7 = 37;
													}
													continue;
												case 13:
													num11++;
													num7 = 32;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
													{
														num7 = 32;
													}
													continue;
												case 19:
												case 24:
													b5 = array3[num17 + num10];
													num7 = 36;
													continue;
												case 16:
												case 32:
													if (num11 >= 64)
													{
														num12 = 33;
														goto IL_05bf;
													}
													goto case 35;
												case 33:
													array = array2;
													num7 = 20;
													continue;
												case 29:
													num13 = 0;
													goto IL_0ade;
												case 27:
													if (num10 >= 4)
													{
														num12 = 4;
														goto IL_05bf;
													}
													goto case 9;
												case 22:
													array2 = new byte[num6 * 64];
													num7 = 23;
													continue;
												case 3:
													num10 = 0;
													num7 = 26;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
													{
														num7 = 25;
													}
													continue;
												case 17:
													goto IL_0772;
												case 26:
												case 31:
													if (num10 < num6)
													{
														num7 = 24;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
														{
															num7 = 14;
														}
														continue;
													}
													goto case 13;
												case 23:
													num11 = 0;
													num7 = 16;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
													{
														num7 = 47;
													}
													continue;
												case 6:
												case 25:
													throw new global::System.Exception("皮肤 PNG 过滤器无效");
												case 7:
												case 10:
												case 15:
												case 37:
													array[num15] = b4;
													num7 = 5;
													continue;
												case 30:
													goto IL_0886;
												case 2:
													goto IL_08a9;
												case 18:
													(val3).ReadExactly((global::System.Span<byte>)array3);
													num7 = 22;
													continue;
												case 34:
													array = array2;
													num7 = 23;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
													{
														num7 = 11;
													}
													continue;
												case 21:
													goto IL_0944;
												case 38:
													num16 = 0;
													goto IL_0ab2;
												case 28:
													num17 = num11 * (num6 + 1) + 1;
													num7 = 12;
													continue;
												case 36:
													if (num10 < 4)
													{
														num7 = 38;
														continue;
													}
													num16 = array2[num9 + num10 - 4];
													goto IL_0ab2;
												case 0:
													switch (b)
													{
													case 1:
														break;
													case 4:
														goto IL_0772;
													case 0:
														goto IL_0886;
													case 3:
														goto IL_08a9;
													case 2:
														goto IL_0944;
													default:
														goto IL_09c7;
													}
													goto case 1;
												case 39:
													array3 = new byte[(num6 + 1) * 64];
													num7 = 18;
													continue;
												case 5:
													num10++;
													num7 = 31;
													continue;
												case 11:
													num15 = num9 + num10;
													num7 = 40;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
													{
														num7 = 0;
													}
													continue;
												case 8:
													if (num11 > 0)
													{
														num7 = 27;
														continue;
													}
													goto case 9;
												case 14:
													if (num11 <= 0)
													{
														num7 = 29;
														continue;
													}
													num13 = array2[num9 + num10 - num6];
													goto IL_0ade;
												case 35:
													b = array3[num11 * (num6 + 1)];
													num7 = 28;
													continue;
												case 12:
													num9 = num11 * num6;
													num12 = 3;
													goto IL_05bf;
												case 9:
													num8 = 0;
													break;
												case 4:
													num8 = array2[num9 + num10 - num6 - 4];
													break;
												case 20:
													goto end_IL_05c7;
													IL_05c3:
													num7 = num14;
													continue;
													IL_09c7:
													num7 = 6;
													continue;
													IL_0ade:
													b2 = (byte)num13;
													num7 = 8;
													continue;
													IL_0ab2:
													b3 = (byte)num16;
													num7 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
													{
														num7 = 14;
													}
													continue;
													IL_0944:
													b4 = (byte)(b5 + b2);
													num12 = 7;
													goto IL_05bf;
													IL_08a9:
													b4 = (byte)(b5 + (b3 + b2) / 2);
													num12 = 36;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
													{
														num12 = 47;
													}
													goto IL_05bf;
													IL_05bf:
													num14 = num12;
													goto IL_05c3;
													IL_0886:
													b4 = b5;
													num7 = 19;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
													{
														num7 = 10;
													}
													continue;
													IL_0772:
													b4 = (byte)(b5 + mUufYsg7Rfc(b3, b2, upperLeft));
													num7 = 15;
													continue;
												}
												upperLeft = (byte)num8;
												num7 = 34;
												continue;
												end_IL_05c7:
												break;
											}
										}
										finally
										{
											if (val3 != null)
											{
												int num18 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
												{
													num18 = 1;
												}
												while (true)
												{
													switch (num18)
													{
													default:
														if (num19 == 989)
														{
															num18 = num19;
															continue;
														}
														break;
													case 1:
														break;
													case 0:
														goto end_IL_0b40;
													}
													(val3).Dispose();
													num18 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
													{
														num18 = 6;
													}
													continue;
													end_IL_0b40:
													break;
												}
											}
										}
										break;
									}
									IL_0143:
									num5 = num23;
									continue;
									IL_013f:
									num23 = num22;
									goto IL_0143;
								}
								break;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num24 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
								{
									num24 = 1;
								}
								while (true)
								{
									switch (num24)
									{
									default:
										if (num25 == 989)
										{
											num24 = num25;
											continue;
										}
										break;
									case 1:
										(val2).Dispose();
										num24 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
										{
											num24 = 3;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						int num26;
						if (val == null)
						{
							num26 = 2;
							goto IL_0c33;
						}
						goto IL_0c7b;
						IL_0c7b:
						(val).Dispose();
						num26 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
						{
							num26 = 2;
						}
						goto IL_0c33;
						IL_0c33:
						while (true)
						{
							switch (num26)
							{
							default:
								if (num27 == 990)
								{
									goto IL_0c2f;
								}
								goto end_IL_0c33;
							case 2:
								goto end_IL_0c33;
							case 0:
								break;
							case 1:
								goto end_IL_0c33;
							}
							goto IL_0c7b;
							IL_0c2f:
							num26 = num27;
							continue;
							end_IL_0c33:
							break;
						}
					}
					goto case 2;
				case 2:
					return array;
				case 1:
					val = System.IO.File.OpenRead((string)path);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool a0afYFqlsb0(object pixels, int left, int top, int width, int height)
	{
		int num = 6;
		int num5 = default(int);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto case 2;
					case 9:
						num5++;
						num3 = 2;
						continue;
					case 0:
					case 4:
						if (num4 >= left + width)
						{
							num3 = 9;
							continue;
						}
						goto case 5;
					case 8:
						return true;
					case 2:
						if (num5 < top + height)
						{
							num3 = 10;
							continue;
						}
						goto case 8;
					case 5:
						if (((short[])pixels)[(num5 * 64 + num4) * 4 + 3] == 0)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 7;
					case 6:
						break;
					case 1:
					case 10:
						num4 = left;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 4;
						}
						continue;
					case 7:
						return false;
					case 3:
						num4++;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 0;
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
			num5 = top;
			num = 16;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
			{
				num = 17;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte mUufYsg7Rfc(byte left, byte up, byte upperLeft)
	{
		int num = 3;
		int num5 = default(int);
		int num6 = default(int);
		int num7 = default(int);
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
						if (num2 == 11)
						{
							return upperLeft;
						}
						goto end_IL_0010;
					case 2:
						if (num5 > num6)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 4;
					case 3:
					{
						int num4 = left + up - upperLeft;
						num5 = System.Math.Abs(num4 - left);
						num6 = System.Math.Abs(num4 - up);
						num7 = System.Math.Abs(num4 - upperLeft);
						num3 = 2;
						continue;
					}
					case 0:
					case 1:
						break;
					case 4:
						if (num5 <= num7)
						{
							return left;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
						{
							num3 = 9;
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
			while (num2 == 992);
			if (num6 <= num7)
			{
				break;
			}
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
			{
				num = 11;
			}
		}
		return up;
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
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
						{
							num3 = 9;
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jbrEdTZM6Sp2ZSH03kR7()
	{
		return TqbnOfZM5tGpTu3XnIgk == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jad59ifYwooR570v1Kfb WT9NABZMRjBv7YJxghHQ()
	{
		return (jad59ifYwooR570v1Kfb)TqbnOfZM5tGpTu3XnIgk;
	}
}

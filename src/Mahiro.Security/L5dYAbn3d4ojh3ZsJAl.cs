using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Rs63uZnxHUburFBVigD;
using fDAldojjppXrctUVYOJn;

namespace vXlmtInvSQQRTh0Q4OK;

internal sealed class L5dYAbn3d4ojh3ZsJAl
{
	private static readonly object VoTnzrifCf;

	private readonly object wZQzb74T4S;

	internal static object NZUAcrZm4DJHRy84ljvI;

	[MethodImpl((MethodImplOptions)8)]
	internal L5dYAbn3d4ojh3ZsJAl(string? filePath = null)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool Save(EvVW7qnPXZ2qMbTBjim receipt)
	{
		//IL_06fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		int num = 5;
		bool result = default(bool);
		byte[] array2 = default(byte[]);
		int num9 = default(int);
		string text3 = default(string);
		FileStream val2 = default(FileStream);
		string text2 = default(string);
		byte[] array = default(byte[]);
		int num6 = default(int);
		int num8 = default(int);
		int num17 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
		global::System.Exception ex = default(global::System.Exception);
		int num12 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num15 = default(int);
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
						switch (num2)
						{
						case 994:
							break;
						case 13:
							goto IL_06a1;
						default:
							goto end_IL_000c;
						}
						break;
					case 6:
						return result;
					case 3:
						try
						{
							array2 = JsonSerializer.SerializeToUtf8Bytes<EvVW7qnPXZ2qMbTBjim>(receipt, (JsonSerializerOptions)null);
							int num4 = 10;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num9 != 22)
									{
										if (num9 == 1002)
										{
											goto IL_009c;
										}
										goto case 10;
									}
									result = true;
									num4 = 12;
									continue;
								case 2:
								case 8:
									System.IO.Directory.CreateDirectory(text3);
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 20;
									}
									continue;
								case 11:
									if (!string.IsNullOrWhiteSpace(text3))
									{
										num4 = 8;
										continue;
									}
									goto case 1;
								case 9:
									break;
								case 1:
									result = false;
									num4 = 9;
									continue;
								case 13:
									break;
								case 5:
									result = false;
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
									{
										num4 = 13;
									}
									continue;
								case 3:
									text3 = System.IO.Path.GetDirectoryName((string)wZQzb74T4S);
									num4 = 11;
									continue;
								case 0:
									val2 = new FileStream(text2, (FileMode)1, (FileAccess)2, (FileShare)0, 4096, (FileOptions)(-2147483648));
									num4 = 4;
									continue;
								case 14:
								{
									System.IO.File.Move(text2, (string)wZQzb74T4S, true);
									int num10 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num10 = 22;
									}
									num9 = num10;
									goto IL_009c;
								}
								case 7:
									if (array.Length != 0)
									{
										num4 = 6;
										continue;
									}
									goto case 5;
								case 10:
									array = System.Security.Cryptography.ProtectedData.Protect(array2, (byte[])VoTnzrifCf, (DataProtectionScope)0);
									num4 = 7;
									continue;
								case 6:
									if (array.Length > 16384)
									{
										num4 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
										{
											num4 = 5;
										}
										continue;
									}
									goto case 3;
								case 4:
									try
									{
										(val2).Write(default(global::System.ReadOnlySpan<byte>));
										int num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
										{
											num5 = 1;
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
												break;
											case 0:
												goto end_IL_02ec;
											}
											(val2).Flush(true);
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
											{
												num5 = 5;
											}
											continue;
											end_IL_02ec:
											break;
										}
									}
									finally
									{
										if (val2 != null)
										{
											int num7 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
											{
												num7 = 2;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 == 989)
													{
														num7 = num8;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_0375;
												}
												(val2).Dispose();
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
												{
													num7 = 2;
												}
												continue;
												end_IL_0375:
												break;
											}
										}
									}
									goto case 14;
								case 12:
									break;
									IL_009c:
									num4 = num9;
									continue;
								}
								break;
							}
						}
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num11 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
								{
									num11 = 12;
								}
							}
							else
							{
								ex = obj3;
								num11 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
								{
									num11 = 5;
								}
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 != 16)
									{
										if (num12 == 996)
										{
											goto IL_040e;
										}
									}
									else if (!(ex is ArgumentException))
									{
										num11 = 6;
										continue;
									}
									goto case 2;
								case 3:
									if (!(ex is UnauthorizedAccessException))
									{
										num11 = 8;
										continue;
									}
									goto case 2;
								case 8:
									if (!(ex is CryptographicException))
									{
										num13 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
										{
											num13 = 16;
										}
										goto IL_040a;
									}
									goto case 2;
								case 2:
									flag = true;
									num11 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
									{
										num11 = 15;
									}
									continue;
								case 6:
									if (ex is NotSupportedException)
									{
										num13 = 2;
										goto IL_040a;
									}
									goto case 7;
								case 5:
									if (!(ex is IOException))
									{
										num11 = 3;
										continue;
									}
									goto case 2;
								case 7:
									flag = false;
									num11 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num11 = 0;
									}
									continue;
								case 4:
									result2 = 0;
									break;
								case 0:
								case 1:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_040a:
									num12 = num13;
									goto IL_040e;
									IL_040e:
									num11 = num12;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num14 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num14 = 3;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 989)
									{
										num14 = num15;
										continue;
									}
									break;
								case 0:
									result = false;
									num14 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
									{
										num14 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						finally
						{
							GWBnG5UVJw(array2);
							int num16 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
							{
								num16 = 1;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 990)
									{
										num16 = num17;
										continue;
									}
									break;
								case 0:
									XCEniuofTr(text2);
									num16 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
									{
										num16 = 2;
									}
									continue;
								case 1:
									GWBnG5UVJw(array);
									num16 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num16 = 0;
									}
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						goto case 6;
					case 4:
						if (receipt.IsValid)
						{
							num3 = 2;
							continue;
						}
						goto case 1;
					case 0:
					{
						object obj = wZQzb74T4S;
						string text = ".";
						Guid val = System.Guid.NewGuid();
						text2 = string.Concat((string)obj, text, (val).ToString("N"), ".tmp");
						num3 = 3;
						continue;
					}
					case 1:
						return false;
					case 2:
						goto end_IL_000c;
					case 5:
						{
							System.ArgumentNullException.ThrowIfNull(receipt, "receipt");
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num3 = 4;
							}
							continue;
						}
						IL_06a1:
						array = null;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			array2 = null;
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool NMbnE2Dcga(out EvVW7qnPXZ2qMbTBjim receipt)
	{
		receipt = default(EvVW7qnPXZ2qMbTBjim);
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_0225: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		bool flag = default(bool);
		int num5 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num17 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
		global::System.Exception ex = default(global::System.Exception);
		int num13 = default(int);
		bool flag2 = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num15 = default(int);
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
							goto case 1;
						}
						array = null;
						num3 = 5;
						continue;
					case 1:
						return false;
					case 5:
						array2 = null;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
						try
						{
							FileStream val = new FileStream((string)wZQzb74T4S, (FileMode)3, (FileAccess)1, (FileShare)1, 4096, (FileOptions)134217728);
							int num4 = 6;
							while (true)
							{
								switch (num4)
								{
								case 3:
									return flag;
								default:
									if (num5 != 14)
									{
										if (num5 == 994)
										{
											goto IL_00a9;
										}
										goto case 6;
									}
									receipt = JsonSerializer.Deserialize<EvVW7qnPXZ2qMbTBjim>(default(global::System.ReadOnlySpan<byte>), (JsonSerializerOptions)null);
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
									{
										num4 = 9;
									}
									continue;
								case 4:
									flag = true;
									num4 = 3;
									continue;
								case 5:
									array2 = System.Security.Cryptography.ProtectedData.Unprotect(array, (byte[])VoTnzrifCf, (DataProtectionScope)0);
									num5 = 14;
									goto IL_00a9;
								case 0:
								{
									EvVW7qnPXZ2qMbTBjim obj = receipt;
									if (obj == null)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
										{
											num4 = 6;
										}
										continue;
									}
									if (obj.IsValid)
									{
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
										{
											num4 = 5;
										}
										continue;
									}
									break;
								}
								case 6:
									try
									{
										long num6 = (val).Length;
										int num7 = 6;
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 != 16)
												{
													if (num8 == 996)
													{
														goto IL_01bb;
													}
													goto case 0;
												}
												goto case 8;
											case 0:
												throw new InvalidDataException("宿主所有权凭据大小无效");
											case 4:
												flag = true;
												num7 = 8;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
												{
													num7 = 8;
												}
												continue;
											case 5:
												(val).ReadExactly(default(global::System.Span<byte>));
												num7 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
												{
													num7 = 11;
												}
												continue;
											case 6:
												if (num6 > 0)
												{
													num7 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
													{
														num7 = 7;
													}
													continue;
												}
												goto case 4;
											case 2:
											case 3:
												flag = false;
												num8 = 16;
												goto IL_01bb;
											case 8:
												if (!flag)
												{
													array = new byte[checked((int)(val).Length)];
													num7 = 5;
													continue;
												}
												num7 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
												{
													num7 = 0;
												}
												continue;
											case 7:
												if (num6 <= 16384)
												{
													num7 = 2;
													continue;
												}
												goto case 4;
											case 1:
												break;
												IL_01bb:
												num7 = num8;
												continue;
											}
											break;
										}
									}
									finally
									{
										int num9;
										if (val == null)
										{
											num9 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
											{
												num9 = 1;
											}
											goto IL_0394;
										}
										goto IL_03dc;
										IL_0394:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_0390;
												}
												break;
											case 1:
												goto end_IL_0394;
											case 2:
												break;
											case 0:
												goto end_IL_0394;
											}
											goto IL_03dc;
											IL_0390:
											num9 = num10;
											continue;
											end_IL_0394:
											break;
										}
										goto end_IL_035c;
										IL_03dc:
										(val).Dispose();
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
										{
											num9 = 6;
										}
										goto IL_0394;
										end_IL_035c:;
									}
									goto case 5;
								case 1:
									break;
								case 2:
									break;
									IL_00a9:
									num4 = num5;
									continue;
								}
								break;
							}
						}
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num11 = 8;
							}
							else
							{
								ex = obj3;
								num11 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
								{
									num11 = 0;
								}
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num13 == 18)
									{
										goto case 10;
									}
									if (num13 == 998)
									{
										goto IL_046f;
									}
									goto case 6;
								case 2:
									if (ex is UnauthorizedAccessException)
									{
										num11 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num11 = 15;
										}
										continue;
									}
									goto case 9;
								case 3:
									if (!(ex is JsonException))
									{
										num11 = 6;
										continue;
									}
									goto case 10;
								case 9:
									if (!(ex is CryptographicException))
									{
										num11 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
										{
											num11 = 3;
										}
										continue;
									}
									goto case 10;
								case 10:
									flag2 = true;
									num11 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
									{
										num11 = 12;
									}
									continue;
								case 6:
									if (!(ex is ArgumentException))
									{
										num11 = 4;
										continue;
									}
									goto case 10;
								case 0:
									if (!(ex is IOException))
									{
										num11 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
										{
											num11 = 2;
										}
										continue;
									}
									goto case 10;
								case 1:
									flag2 = false;
									num11 = 7;
									continue;
								case 4:
									if (ex is NotSupportedException)
									{
										num12 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num12 = 18;
										}
										num13 = num12;
										goto IL_046f;
									}
									goto case 1;
								case 8:
									result = 0;
									break;
								case 5:
								case 7:
									{
										result = (flag2 ? 1 : 0);
										break;
									}
									IL_046f:
									num11 = num13;
									continue;
								}
								break;
							}
							return (byte)result != 0;
						}).Invoke())
						{
							int num14 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
							{
								num14 = 0;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 988)
									{
										num14 = num15;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							GWBnG5UVJw(array2);
							int num16 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								num16 = 0;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 989)
									{
										num16 = num17;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_06cd;
								}
								GWBnG5UVJw(array);
								num16 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
								{
									num16 = 5;
								}
								continue;
								end_IL_06cd:
								break;
							}
						}
						break;
					case 2:
						iwpn2g2q5g();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							num3 = 8;
						}
						continue;
					case 3:
						goto end_IL_000c;
					case 0:
						break;
					}
					receipt = null;
					num3 = 2;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			receipt = null;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void iwpn2g2q5g()
	{
		XCEniuofTr(wZQzb74T4S);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string SGSnqIH4rA()
	{
		return System.IO.Path.Combine(Environment.GetFolderPath((global::System.Environment.SpecialFolder)28), "Chronal", "java-official-host.owner");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void GWBnG5UVJw(object? buffer)
	{
		System.Security.Cryptography.CryptographicOperations.ZeroMemory(((global::System.Span<byte>)(byte[])buffer));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void XCEniuofTr(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
						{
							num2 = 0;
						}
						goto IL_0072;
					}
					goto IL_0096;
					IL_0072:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								goto IL_006e;
							}
							return;
						case 2:
							break;
						case 0:
							return;
						case 1:
							return;
						}
						break;
						IL_006e:
						num2 = num3;
					}
					goto IL_0096;
					IL_0096:
					System.IO.File.Delete((string)path);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
					{
						num2 = 8;
					}
					goto IL_0072;
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 6;
					}
					else
					{
						ex = obj2;
						num4 = 10;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num6 != 18)
							{
								if (num6 == 998)
								{
									goto IL_00f8;
								}
								goto case 5;
							}
							goto case 0;
						case 10:
							if (!(ex is IOException))
							{
								num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
								{
									num4 = 5;
								}
								continue;
							}
							goto case 0;
						case 5:
							if (ex is UnauthorizedAccessException)
							{
								num5 = 18;
								goto IL_00f4;
							}
							goto case 2;
						case 7:
						case 8:
							flag = false;
							num5 = 3;
							goto IL_00f4;
						case 9:
							if (!(ex is NotSupportedException))
							{
								num4 = 8;
								continue;
							}
							goto case 0;
						case 2:
							if (ex is ArgumentException)
							{
								num4 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
								{
									num4 = 18;
								}
								continue;
							}
							goto case 9;
						case 0:
						case 4:
							flag = true;
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num4 = 13;
							}
							continue;
						case 6:
							result = 0;
							break;
						case 1:
						case 3:
							{
								result = (flag ? 1 : 0);
								break;
							}
							IL_00f8:
							num4 = num6;
							continue;
							IL_00f4:
							num6 = num5;
							goto IL_00f8;
						}
						break;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num7 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 0:
							return;
						}
						if (num8 == 988)
						{
							num7 = num8;
							continue;
						}
						return;
					}
				}
			default:
				return;
			}
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
	internal static bool WZAaILZmh6mY0UtoMKQx()
	{
		return NZUAcrZm4DJHRy84ljvI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static L5dYAbn3d4ojh3ZsJAl pgQSRLZmU7Wwmqqyms2r()
	{
		return (L5dYAbn3d4ojh3ZsJAl)NZUAcrZm4DJHRy84ljvI;
	}
}

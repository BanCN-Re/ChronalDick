using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using NTFE7yf9B5U1ZOAqSfhj;
using SRwlNQf9OPT4S1ITMMiQ;
using fDAldojjppXrctUVYOJn;

namespace uxBOtcf9PfdZixaGBHrF;

internal class n2d6Asf9enMlUcwDeXtV
{
	internal static object PMLpG6ZNofdiTn4qcxXI;

	[MethodImpl((MethodImplOptions)8)]
	internal static void aZvf9xdEVVJ(string path, ReadOnlyMemory<byte> bytes)
	{
		//IL_07fa: Expected O, but got Unknown
		//IL_0864: Unknown result type (might be due to invalid IL or missing references)
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		int num = 1;
		int num7 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num6 = default(int);
		string text2 = default(string);
		global::System.ReadOnlySpan<byte> span = default(global::System.ReadOnlySpan<byte>);
		MemoryStream val2 = default(MemoryStream);
		int num13 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num15 = default(int);
		JsonDocument val = default(JsonDocument);
		int num5 = default(int);
		int num17 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					string text = System.IO.Path.GetExtension(path);
					int num2 = 24;
					while (true)
					{
						int num3;
						switch (num2)
						{
						case 7:
							return;
						default:
							if (num7 != 35)
							{
								if (num7 == 1015)
								{
									goto IL_0057;
								}
								goto case 5;
							}
							goto case 26;
						case 10:
							(defaultInterpolatedStringHandler).AppendLiteral("资源解密结果不是可识别的完整图片（支持 PNG/JPEG/GIF/BMP/WebP/TGA/TIFF/QOI/PBM；文件=");
							num2 = 3;
							break;
						case 15:
							(defaultInterpolatedStringHandler).AppendLiteral("长度=");
							num2 = 14;
							break;
						case 23:
							num6 = System.Math.Min(8, bytes.Length);
							num2 = 4;
							break;
						case 5:
							(defaultInterpolatedStringHandler).AppendLiteral("）");
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num2 = 16;
							}
							break;
						case 9:
							if (!(text).Equals(".mergedmcs", (StringComparison)5))
							{
								return;
							}
							num2 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num2 = 0;
							}
							break;
						case 21:
							text2 = System.Convert.ToHexString(span.Slice(0, num6));
							num2 = 18;
							break;
						case 13:
							try
							{
								ZipArchive val3 = new ZipArchive((Stream)(object)val2, (ZipArchiveMode)0);
								int num8 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										return;
									default:
										if (num13 != 989)
										{
											return;
										}
										break;
									case 0:
										try
										{
											_ = (val3).Entries.Count;
											int num9 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												case 0:
													return;
												}
												if (num10 != 988)
												{
													return;
												}
												num9 = num10;
											}
										}
										finally
										{
											int num11;
											if (val3 == null)
											{
												num11 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
												{
													num11 = 5;
												}
												goto IL_0323;
											}
											goto IL_036b;
											IL_0323:
											while (true)
											{
												switch (num11)
												{
												default:
													if (num12 == 990)
													{
														goto IL_031f;
													}
													goto end_IL_0323;
												case 1:
													goto end_IL_0323;
												case 2:
													break;
												case 0:
													goto end_IL_0323;
												}
												goto IL_036b;
												IL_031f:
												num11 = num12;
												continue;
												end_IL_0323:
												break;
											}
											goto end_IL_02eb;
											IL_036b:
											(val3).Dispose();
											num11 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
											{
												num11 = 2;
											}
											goto IL_0323;
											end_IL_02eb:;
										}
									}
									num8 = num13;
								}
							}
							finally
							{
								int num14;
								if (val2 == null)
								{
									num14 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num14 = 8;
									}
									goto IL_03f3;
								}
								goto IL_0417;
								IL_03f3:
								while (true)
								{
									switch (num14)
									{
									default:
										if (num15 == 990)
										{
											goto IL_03ef;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_03f3;
									case 2:
										goto end_IL_03f3;
									}
									goto IL_0417;
									IL_03ef:
									num14 = num15;
									continue;
									end_IL_03f3:
									break;
								}
								goto end_IL_03bb;
								IL_0417:
								(val2).Dispose();
								num14 = 2;
								goto IL_03f3;
								end_IL_03bb:;
							}
						case 18:
							defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(73, 3);
							num2 = 10;
							break;
						case 19:
							if (GxI494f9IymiuqWAmEOR.JGFf9ligvta(bytes))
							{
								num2 = 11;
								break;
							}
							goto case 23;
						case 0:
						case 27:
							val2 = new MemoryStream(bytes.ToArray(), false);
							num2 = 31;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num2 = 13;
							}
							break;
						case 12:
							if (!GxI494f9IymiuqWAmEOR.y4tf9ggdufd(path))
							{
								num3 = 6;
								goto IL_0053;
							}
							goto case 19;
						case 3:
							(defaultInterpolatedStringHandler).AppendFormatted(System.IO.Path.GetFileName(path));
							num2 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
							{
								num2 = 1;
							}
							break;
						case 2:
							throw new InvalidDataException((defaultInterpolatedStringHandler).ToStringAndClear());
						case 6:
						case 11:
							if (!(text).Equals(".ogg", (StringComparison)5))
							{
								num2 = 26;
								break;
							}
							goto case 17;
						case 24:
							if ((text).Equals(".json", (StringComparison)5))
							{
								num2 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num2 = 25;
								}
								break;
							}
							goto case 12;
						case 17:
							if (MemoryExtensions.StartsWith<byte>(bytes.Span, "OggS"u8))
							{
								num3 = 35;
								goto IL_0053;
							}
							goto case 8;
						case 16:
							(defaultInterpolatedStringHandler).AppendFormatted(text2);
							num2 = 5;
							break;
						case 22:
							try
							{
								return;
							}
							finally
							{
								if (val != null)
								{
									int num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
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
												num4 = num5;
												continue;
											}
											break;
										case 1:
											(val).Dispose();
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
											{
												num4 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						case 14:
							defaultInterpolatedStringHandler.AppendFormatted<int>(bytes.Length);
							num2 = 20;
							break;
						case 1:
							(defaultInterpolatedStringHandler).AppendLiteral("，");
							num2 = 15;
							break;
						case 20:
							(defaultInterpolatedStringHandler).AppendLiteral("，前8字节=");
							num3 = 16;
							goto IL_0053;
						case 4:
							span = bytes.Span;
							num2 = 21;
							break;
						case 8:
							throw new InvalidDataException("资源解密结果的 OGG 文件头无效");
						case 26:
							if ((text).Equals(".mczip", (StringComparison)5))
							{
								num2 = 27;
								break;
							}
							goto case 9;
						case 25:
							{
								val = System.Text.Json.JsonDocument.Parse(uhJLCZf9tccNtoSWw6mU.QdMf95RGUGc(bytes), uhJLCZf9tccNtoSWw6mU.Options);
								num2 = 22;
								break;
							}
							IL_0053:
							num7 = num3;
							goto IL_0057;
							IL_0057:
							num2 = num7;
							break;
						}
					}
				}
				catch (JsonException ex)
				{
					JsonException ex2 = ex;
					int num16 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
					{
						num16 = 0;
					}
					while (true)
					{
						switch (num16)
						{
						default:
							if (num17 == 988)
							{
								goto IL_0827;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0827:
						num16 = num17;
					}
					throw new InvalidDataException("资源解密结果不是有效 JSON，密钥或资源版本不匹配", (global::System.Exception)(object)ex2);
				}
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
	internal static bool ABtvOWZNmC5cHnciysQP()
	{
		return PMLpG6ZNofdiTn4qcxXI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static n2d6Asf9enMlUcwDeXtV z5RKyjZN76ZPJJSia2JZ()
	{
		return (n2d6Asf9enMlUcwDeXtV)PMLpG6ZNofdiTn4qcxXI;
	}
}

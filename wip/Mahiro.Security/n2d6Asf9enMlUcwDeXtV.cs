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
	internal unsafe static void aZvf9xdEVVJ(string path, ReadOnlyMemory<byte> bytes)
	{
		//IL_07c6: Expected O, but got Unknown
		//IL_0478: Expected O, but got I4
		//IL_073a: Expected O, but got Ref
		//IL_05bb: Expected O, but got I4
		//IL_05bb: Expected O, but got Ref
		//IL_0452: Expected O, but got I4
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got I4
		//IL_079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_079f: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got I4
		//IL_048c->IL005b: Incompatible stack heights: 2 vs 1
		//IL_05c0->IL0744: Incompatible stack heights: 1 vs 0
		//IL_045c->IL005b: Incompatible stack heights: 2 vs 1
		//IL_0222->IL005b: Incompatible stack heights: 3 vs 1
		//IL_0497->IL005b: Incompatible stack heights: 2 vs 1
		//IL_05ca->IL0053: Incompatible stack heights: 2 vs 1
		//IL_02db->IL03a6: Incompatible stack heights: 0 vs 1
		int num = 1;
		int num7 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num6 = default(int);
		global::System.ReadOnlySpan<byte> readOnlySpan = default(global::System.ReadOnlySpan<byte>);
		string text2 = default(string);
		int num13 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		MemoryStream val2 = default(MemoryStream);
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
							num6 = System.Math.Min(8, (int)(&bytes));
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
							_ = readOnlySpan;
							_ = 0;
							text2 = System.Convert.ToHexString((global::System.ReadOnlySpan<byte>)num6);
							_ = 18;
							break;
						case 13:
							try
							{
								ZipArchive val3 = (ZipArchive)(object)0;
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
											(val3).Entries;
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
												goto IL_0313;
											}
											goto IL_035b;
											IL_0313:
											while (true)
											{
												switch (num11)
												{
												default:
													if (num12 == 990)
													{
														goto IL_030f;
													}
													goto end_IL_0313;
												case 1:
													goto end_IL_0313;
												case 2:
													break;
												case 0:
													goto end_IL_0313;
												}
												goto IL_035b;
												IL_030f:
												num11 = num12;
												continue;
												end_IL_0313:
												break;
											}
											goto end_IL_02db;
											IL_035b:
											(val3).Dispose();
											num11 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
											{
												num11 = 2;
											}
											goto IL_0313;
											end_IL_02db:;
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
									goto IL_03e3;
								}
								goto IL_0407;
								IL_03e3:
								while (true)
								{
									switch (num14)
									{
									default:
										if (num15 == 990)
										{
											goto IL_03df;
										}
										break;
									case 0:
										break;
									case 1:
										goto end_IL_03e3;
									case 2:
										goto end_IL_03e3;
									}
									goto IL_0407;
									IL_03df:
									num14 = num15;
									continue;
									end_IL_03e3:
									break;
								}
								goto end_IL_03ab;
								IL_0407:
								(val2).Dispose();
								num14 = 2;
								goto IL_03e3;
								end_IL_03ab:;
							}
						case 18:
							_ = 73;
							defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
							_ = 10;
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
							_ = bytes;
							val2 = (MemoryStream)(object)0;
							_ = 31;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								_ = 13;
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
							throw (defaultInterpolatedStringHandler).ToStringAndClear();
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
							_ = bytes;
							if (MemoryExtensions.StartsWith<byte>((global::System.ReadOnlySpan<byte>)global::System.Runtime.CompilerServices.Unsafe.AsPointer(_PrivateImplementationDetails_.B18BAAED604AF83AB599242F44B854C295F9FD31A594FDAA3A6BABCD6109A1F5), (global::System.ReadOnlySpan<byte>)4))
							{
								_ = 35;
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
							defaultInterpolatedStringHandler.AppendFormatted<int>((int)(&bytes));
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
							readOnlySpan = (global::System.ReadOnlySpan<byte>)(&bytes);
							num2 = 21;
							break;
						case 8:
							throw new global::System.Exception("资源解密结果的 OGG 文件头无效");
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
								goto IL_07f3;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_07f3:
						num16 = num17;
					}
					_ = "资源解密结果不是有效 JSON，密钥或资源版本不匹配";
					throw ex2;
				}
			}
		}
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
					default:
						if (num2 == 9)
						{
							return;
						}
						goto IL_0031;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							num3 = 5;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 2:
						break;
					}
					goto IL_0078;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					num3 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
					{
						num3 = 1;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
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

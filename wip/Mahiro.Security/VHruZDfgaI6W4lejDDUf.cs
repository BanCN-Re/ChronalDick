using System;
using System.Runtime.CompilerServices;
using System.Text;
using AnsLplfgeAbnb7rTly7j;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace UZChX2fg1CIiD6jehP0J;

internal class VHruZDfgaI6W4lejDDUf
{
	private static Encoding v4jfgnZBdYy;

	internal static object TbJ6wuZ1N8FEsubCNKFw;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] Nsjfg30uhGD(object instance, long creationTime, nint window, object fontPath)
	{
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian((global::System.Span<byte>)new DateTimeOffset[2848], 2848u);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] gs1fgve9kBa()
	{
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian((global::System.Span<byte>)new DateTimeOffset[40], 40u);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static X0ftL0fgwFX3wiXHgA4J SXsfgEtBMWK(global::System.ReadOnlySpan<byte> bytes)
	{
		//IL_000f: Expected O, but got I4
		_ = bytes;
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)12);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void EFtfg2Gdlqt(global::System.Span<byte> target, string? value, bool requireComplete = false)
	{
		//IL_0204: Expected O, but got Unknown
		int num = 3;
		int num6 = default(int);
		int num5 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_0010;
							}
							goto case 10;
						}
						goto case 11;
					case 13:
						throw new global::System.Exception("游戏内面板资源路径过长");
					case 7:
						value = (value).Substring(0, num6);
						num3 = 12;
						continue;
					case 10:
						num5 = (int)((nint)(&target) / (nint)2 - 1);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 16;
						}
						continue;
					case 11:
						if ((value).Contains('\0'))
						{
							num3 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 4;
						}
						continue;
					case 5:
						num4 = num5;
						goto IL_030e;
					case 3:
						if (value != null)
						{
							num = 21;
							break;
						}
						goto case 14;
					case 14:
						value = string.Empty;
						num3 = 11;
						continue;
					case 4:
						try
						{
							(v4jfgnZBdYy).GetByteCount(value);
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num7 = 6;
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
						catch (EncoderFallbackException ex)
						{
							EncoderFallbackException ex2 = ex;
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 988)
									{
										goto IL_0231;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0231:
								num9 = num10;
							}
							_ = "面板展示数据包含无效 UTF-16 字符";
							throw ex2;
						}
						goto case 10;
					case 1:
						if ((value).Length <= num5)
						{
							num3 = 2;
							continue;
						}
						goto case 8;
					case 2:
					case 12:
						(v4jfgnZBdYy).GetBytes(System.MemoryExtensions.AsSpan(value), target);
						num = 9;
						break;
					case 9:
						return;
					case 0:
						throw new global::System.Exception("面板展示数据包含无效字符");
					case 8:
						if (!requireComplete)
						{
							if (char.IsHighSurrogate((value).Chars))
							{
								num3 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 5;
						}
						num3 = 13;
						continue;
					case 6:
						{
							num4 = num5 - 1;
							goto IL_030e;
						}
						IL_030e:
						num6 = num4;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_00ad: Expected O, but got I4
		//IL_00c1->IL0012: Incompatible stack heights: 3 vs 1
		//IL_00cc->IL0012: Incompatible stack heights: 3 vs 1
		int num = 4;
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
								goto end_IL_0012;
							}
							goto case 3;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						num = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
						{
							num = 11;
						}
						break;
					case 0:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num = 1;
						break;
					case 2:
						return;
					case 1:
						_ = 0;
						_ = 0;
						v4jfgnZBdYy = (Encoding)(object)1;
						_ = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
						{
							_ = 2;
						}
						continue;
					case 4:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
						{
							num3 = 3;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BPEgimZ1MQJtdcy4bQaD()
	{
		return TbJ6wuZ1N8FEsubCNKFw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static VHruZDfgaI6W4lejDDUf RD0nP7Z1pvCKvlSBFTtJ()
	{
		return (VHruZDfgaI6W4lejDDUf)TbJ6wuZ1N8FEsubCNKFw;
	}
}

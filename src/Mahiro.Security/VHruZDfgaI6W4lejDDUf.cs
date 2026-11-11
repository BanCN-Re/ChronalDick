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
	private static readonly Encoding v4jfgnZBdYy;

	internal static object TbJ6wuZ1N8FEsubCNKFw;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] Nsjfg30uhGD(object instance, long creationTime, nint window, object fontPath)
	{
		System.ArgumentException.ThrowIfNullOrWhiteSpace((string)fontPath, "fontPath");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] gs1fgve9kBa()
	{
		byte[] array = new byte[40];
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(default(global::System.Span<byte>), 40u);
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(MemoryExtensions.AsSpan<byte>(array, 4), 1u);
		return array;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static X0ftL0fgwFX3wiXHgA4J SXsfgEtBMWK(global::System.ReadOnlySpan<byte> bytes)
	{
		uint num = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(bytes.Slice(12));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void EFtfg2Gdlqt(global::System.Span<byte> target, string? value, bool requireComplete = false)
	{
		//IL_020c: Expected O, but got Unknown
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
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
						throw new InvalidOperationException("游戏内面板资源路径过长");
					case 7:
						value = (value).Substring(0, num6);
						num3 = 12;
						continue;
					case 10:
						num5 = target.Length / 2 - 1;
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
						goto IL_031e;
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
										goto IL_0239;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0239:
								num9 = num10;
							}
							throw new InvalidOperationException("面板展示数据包含无效 UTF-16 字符", (global::System.Exception)(object)ex2);
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
						throw new InvalidOperationException("面板展示数据包含无效字符");
					case 8:
						if (!requireComplete)
						{
							if (char.IsHighSurrogate(((dynamic)(value)).Chars))
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
							goto IL_031e;
						}
						IL_031e:
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

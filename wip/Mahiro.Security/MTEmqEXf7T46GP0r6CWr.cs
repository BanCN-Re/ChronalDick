using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CeG2JsXfH5vopSSiWCuk;
using tub52EXDkKsi0h1HL5Yl;

namespace EPfNIFXfAARiySDtVK9q;

internal class MTEmqEXf7T46GP0r6CWr
{
	private static readonly object FKoXfle0QRB;

	internal static object zksiHAZ7QxDV1xYdQsyi;

	[MethodImpl((MethodImplOptions)8)]
	internal static Us57owXfKTSvfd7NUuiq DxGXfIVdrlM(global::System.ReadOnlySpan<byte> payload)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] TDgXfBZK3XM(object playerName, object skinPath, object capePath, int skinMode)
	{
		//IL_002a: Expected O, but got I4
		return CfMulxXDDpJgC5q81PnH.NFeXDVZunBO((object[])(object)new CancellationToken[5]
		{
			(CancellationToken)(object)(FileMode)520,
			(CancellationToken)playerName,
			(CancellationToken)skinPath,
			(CancellationToken)capePath,
			(CancellationToken)(object)skinMode
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string sjjXfgWIUVc(global::System.ReadOnlySpan<byte> payload, ref int offset, object fieldName)
	{
		//IL_00c6: Expected O, but got Unknown
		//IL_0069: Expected O, but got I4
		//IL_0069: Expected O, but got I4
		//IL_027f: Expected O, but got I4
		//IL_0295->IL0010: Incompatible stack heights: 2 vs 1
		//IL_02a0->IL0010: Incompatible stack heights: 2 vs 1
		int num = 2;
		ushort num4 = default(ushort);
		string result = default(string);
		int num6 = default(int);
		int num8 = default(int);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						if ((nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref payload, offset)) < (nint)(int)num4)
						{
							num3 = 3;
							continue;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
						try
						{
							_ = FKoXfle0QRB;
							_ = payload;
							string text = (offset).GetString((global::System.ReadOnlySpan<byte>)num4);
							offset += num4;
							result = text;
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										num5 = num6;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (DecoderFallbackException ex)
						{
							DecoderFallbackException ex2 = ex;
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
							{
								num7 = 2;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										goto IL_00f3;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00f3:
								num7 = num8;
							}
							string.Concat("Java 玩家皮肤请求的", (string)fieldName, "编码无效");
							throw ex2;
						}
						goto case 6;
					case 5:
						break;
					case 3:
						throw string.Concat("Java 玩家皮肤请求的", (string)fieldName, "长度无效");
					case 2:
						if ((nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref payload, offset)) >= (nint)2)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 4;
					case 6:
						return result;
					case 4:
						throw string.Concat("Java 玩家皮肤请求缺少", (string)fieldName, "长度");
					case 1:
						_ = payload;
						num4 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian((global::System.ReadOnlySpan<byte>)offset);
						_ = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							_ = 7;
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
			offset += 2;
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool zmaehDZ7CxXb1xF2h4c0()
	{
		return zksiHAZ7QxDV1xYdQsyi == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MTEmqEXf7T46GP0r6CWr O9lLoGZ74aD7QcdyyS3W()
	{
		return (MTEmqEXf7T46GP0r6CWr)zksiHAZ7QxDV1xYdQsyi;
	}
}

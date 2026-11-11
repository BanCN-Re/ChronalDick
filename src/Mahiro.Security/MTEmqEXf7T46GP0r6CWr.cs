using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CeG2JsXfH5vopSSiWCuk;
using fDAldojjppXrctUVYOJn;
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
		return CfMulxXDDpJgC5q81PnH.NFeXDVZunBO((ushort)520, playerName, skinPath, capePath, skinMode);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string sjjXfgWIUVc(global::System.ReadOnlySpan<byte> payload, ref int offset, object fieldName)
	{
		//IL_00ca: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0282: Unknown result type (might be due to invalid IL or missing references)
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
						if (payload.Length - offset < num4)
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
							string text = ((global::System.Text.Encoding)(FKoXfle0QRB)).GetString(payload.Slice(offset, (int)num4));
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
										goto IL_00f7;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00f7:
								num7 = num8;
							}
							throw new InvalidDataException(string.Concat("Java 玩家皮肤请求的", (string)fieldName, "编码无效"), (global::System.Exception)(object)ex2);
						}
						goto case 6;
					case 5:
						break;
					case 3:
						throw new InvalidDataException(string.Concat("Java 玩家皮肤请求的", (string)fieldName, "长度无效"));
					case 2:
						if (payload.Length - offset >= 2)
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
						throw new InvalidDataException(string.Concat("Java 玩家皮肤请求缺少", (string)fieldName, "长度"));
					case 1:
						num4 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(payload.Slice(offset));
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
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
			offset += 2;
			num = 13;
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

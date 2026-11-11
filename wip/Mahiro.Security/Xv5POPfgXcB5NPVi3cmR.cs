using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PYNO1PfBNwOsy4tWMLJa;
using QSQwU0fB2BeU5SLTafBE;
using fDAldojjppXrctUVYOJn;
using fYOwZVfBsr8s5cvJunHZ;

namespace tXFst2fgfHvC2AF9ZwW6;

internal class Xv5POPfgXcB5NPVi3cmR
{
	private static Encoding RicfgVhY4cm;

	private static Encoding W7NfgYOrEDR;

	private static object UHaaUvZ14rkqqCPCBGr9;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] h2efgLTZscG(uint pid, long created, global::System.ReadOnlySpan<byte> key, ulong operation = 0uL, amKtQtfBTuCaidBK9Kxa? progress = null)
	{
		byte[] array = default(byte[]);
		dSHfg95CDKJ(MemoryExtensions.AsSpan<byte>(array, 1096, 128), progress.Uid);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static C5w4mSfBEmjDtxpXTVcp eNSfgjc9PeX(global::System.ReadOnlySpan<byte> bytes)
	{
		//IL_03f5: Expected O, but got I4
		//IL_0136: Expected O, but got I4
		//IL_00a4: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_01de: Expected O, but got I4
		//IL_0151: Expected O, but got I4
		//IL_0401->IL0008: Incompatible stack heights: 2 vs 1
		//IL_0142->IL0008: Incompatible stack heights: 2 vs 1
		//IL_0103->IL0010: Incompatible stack heights: 3 vs 1
		//IL_01ea->IL0008: Incompatible stack heights: 3 vs 1
		//IL_00b4->IL0010: Incompatible stack heights: 2 vs 1
		//IL_022b->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0448->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0167->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0236->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0172->IL0010: Incompatible stack heights: 2 vs 1
		int num = 15;
		ulong num5 = default(ulong);
		uint num4 = default(uint);
		global::System.ReadOnlySpan<byte> readOnlySpan = default(global::System.ReadOnlySpan<byte>);
		uint num6 = default(uint);
		tyHJr9fBFVSn3V0GL8YR tyHJr9fBFVSn3V0GL8YR = default(tyHJr9fBFVSn3V0GL8YR);
		string sauth = default(string);
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
					switch (num3)
					{
					default:
						if (num2 != 30)
						{
							if (num2 == 1011)
							{
								goto end_IL_0010;
							}
							goto case 15;
						}
						_ = bytes;
						num5 = System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian((global::System.ReadOnlySpan<byte>)56);
						_ = 26;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							_ = 0;
						}
						continue;
					case 16:
						_ = bytes;
						if (System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)4) != 1)
						{
							_ = 10;
							continue;
						}
						_ = bytes;
						num4 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)12);
						_ = 30;
						break;
					case 2:
						if (num4 <= 3)
						{
							num = 9;
							break;
						}
						goto case 6;
					case 5:
						if (num5 != 0L)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 6;
					case 19:
						_ = bytes;
						_ = 1480;
						readOnlySpan = (global::System.ReadOnlySpan<byte>)checked((int)num6);
						_ = 4;
						continue;
					case 23:
						if ((num4 & 1) != 0)
						{
							num3 = 20;
							continue;
						}
						goto case 13;
					case 13:
						if (num6 == 0)
						{
							num3 = 22;
							continue;
						}
						goto case 6;
					case 7:
						_ = bytes;
						tyHJr9fBFVSn3V0GL8YR = (tyHJr9fBFVSn3V0GL8YR)System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)64);
						_ = 2;
						break;
					case 20:
					case 22:
						if ((num4 & 1) != 0)
						{
							num3 = 5;
							continue;
						}
						goto case 11;
					case 18:
						if (num6 < 32768)
						{
							num3 = 23;
							continue;
						}
						goto case 6;
					case 17:
						return (C5w4mSfBEmjDtxpXTVcp)new C5w4mSfBEmjDtxpXTVcp(num5, sauth, (num4 & 2) != 0);
					case 10:
						throw new global::System.Exception("面板账号桥接协议不匹配");
					case 12:
						throw new global::System.Exception("SAuth 请求字符串无效");
					case 1:
						try
						{
							sauth = (RicfgVhY4cm).GetString(readOnlySpan);
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
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
						catch (DecoderFallbackException)
						{
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
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
										goto IL_02d9;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_02d9:
								num9 = num10;
							}
							throw new global::System.Exception("SAuth 必须是有效 UTF-8");
						}
						goto case 17;
					case 3:
						if (num6 != 0)
						{
							num3 = 11;
							continue;
						}
						goto case 6;
					case 9:
						if (global::System.Enum.IsDefined<tyHJr9fBFVSn3V0GL8YR>(tyHJr9fBFVSn3V0GL8YR))
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 18;
							}
							continue;
						}
						goto case 6;
					case 15:
						if (&bytes == (global::System.ReadOnlySpan<byte>*)34248)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 10;
					case 6:
						throw new global::System.Exception("面板账号请求无效");
					case 11:
						sauth = null;
						num3 = 8;
						continue;
					case 14:
						if (System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian(bytes) == 34248)
						{
							num3 = 16;
							continue;
						}
						goto case 10;
					case 0:
						_ = bytes;
						num6 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)68);
						_ = 7;
						break;
					case 4:
						if (!MemoryExtensions.Contains<byte>(readOnlySpan, (byte)0))
						{
							num3 = 29;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 12;
					case 21:
						_ = bytes;
						if (*(byte*)(int)(1480 + num6) == 0)
						{
							_ = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								_ = 1;
							}
						}
						else
						{
							_ = 12;
						}
						continue;
					case 8:
						if ((num4 & 1) != 0)
						{
							num3 = 28;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 17;
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
	private static void t8kfgZe5on2(object bytes, int offset, uint value)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void dSHfg95CDKJ(global::System.Span<byte> target, string value)
	{
		int num = 1;
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						num4 = (int)((nint)(&target) / (nint)2 - 1);
						num = 4;
						break;
					case 6:
						throw new global::System.Exception("展示文本包含 NUL");
					case 5:
						return;
					case 4:
						if ((value).Length <= num4)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 3;
					case 1:
						if (!(value).Contains('\0'))
						{
							num = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num = 13;
							}
							break;
						}
						goto case 6;
					case 0:
					case 2:
						(W7NfgYOrEDR).GetBytes(System.MemoryExtensions.AsSpan(value), target);
						num3 = 5;
						continue;
					case 3:
						value = (value).Substring(0, char.IsHighSurrogate((value).Chars) ? (num4 - 1) : num4);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num3 = 2;
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
		//IL_00d7: Expected O, but got I4
		//IL_0058: Expected O, but got I4
		//IL_00e1->IL000a: Incompatible stack heights: 3 vs 1
		//IL_006c->IL0012: Incompatible stack heights: 2 vs 1
		//IL_0077->IL0012: Incompatible stack heights: 2 vs 1
		int num = 3;
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
								goto end_IL_0012;
							}
							goto case 5;
						}
						return;
					case 5:
						_ = 0;
						RicfgVhY4cm = (Encoding)(object)1;
						_ = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							_ = 10;
						}
						continue;
					case 4:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num = 5;
						break;
					case 2:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						_ = 0;
						_ = 0;
						W7NfgYOrEDR = (Encoding)(object)1;
						_ = 12;
						break;
					case 3:
						num3 = 2;
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
	internal static bool xFnEKMZ1hcc7tTJLqbx8()
	{
		return UHaaUvZ14rkqqCPCBGr9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Xv5POPfgXcB5NPVi3cmR J5qZSdZ1UPVvWUv251fy()
	{
		return (Xv5POPfgXcB5NPVi3cmR)UHaaUvZ14rkqqCPCBGr9;
	}
}

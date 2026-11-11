using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using iM65eRXiKVWZgs63pZCd;

namespace GU7R5LfDhWGiNWYLlfGS;

internal class ccXGwWfD4Anv9wIKtEQi
{
	private static object idnvXEZNOCHGfkrsWr4B;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] OdafDUZT0vx(ushort sid, params object[] values)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool nSyfDr1tfr5(global::System.ReadOnlySpan<byte> data, ref int offset, out string value)
	{
		//IL_001c: Expected O, but got I4
		//IL_001c: Expected O, but got F4
		//IL_001d: Expected I8, but got O
		System.Text.Encoding.UTF8;
		ushort num = default(ushort);
		data = (long)(offset).GetString((global::System.ReadOnlySpan<byte>)num);
		value = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void PNifDo8NYfO(object stream, object value)
	{
		//IL_043c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected I4, but got Unknown
		//IL_02d6: Expected I4, but got O
		//IL_0339: Unknown result type (might be due to invalid IL or missing references)
		//IL_0340: Expected I4, but got Unknown
		//IL_047c: Expected I4, but got O
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected I8, but got Unknown
		//IL_0327: Unknown result type (might be due to invalid IL or missing references)
		//IL_032e: Expected I4, but got Unknown
		//IL_0417: Unknown result type (might be due to invalid IL or missing references)
		//IL_041e: Expected I4, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected I8, but got Unknown
		int num = 31;
		ulong value7 = default(ulong);
		byte[] array = default(byte[]);
		string text = default(string);
		short value6 = default(short);
		bool flag = default(bool);
		ushort value3 = default(ushort);
		long value5 = default(long);
		uint value2 = default(uint);
		byte b = default(byte);
		int value4 = default(int);
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
						if (num2 == 51)
						{
							return;
						}
						goto end_IL_0010;
					case 20:
					case 39:
						if (!(value is CipherMode))
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 3;
					case 1:
						return;
					case 6:
						throw string.Concat("不支持的基岩 RPC 参数类型：", ((value).GetType()).FullName);
					case 38:
						value7 = (ulong)(FileAccess)value;
						num3 = 34;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num3 = 14;
						}
						continue;
					case 13:
						array = (byte[])(object)(value as IEquatable<bjsovlXid1IZ1bYL6Xwl>);
						num3 = 42;
						continue;
					case 27:
						return;
					case 34:
						XSifDlMVR2T(stream, value7);
						num = 42;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num = 51;
						}
						break;
					case 35:
						if (!(value is FileAccess))
						{
							num3 = 44;
							continue;
						}
						goto case 38;
					case 4:
					case 10:
						if (value is FileMode)
						{
							num = 41;
							break;
						}
						goto case 32;
					case 18:
						if (text == null)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 13;
							}
							continue;
						}
						x3YfDmoQGnH(stream, text);
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num3 = 22;
						}
						continue;
					case 30:
					case 33:
						if (!(value is DateTimeOffset))
						{
							num3 = 33;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 20;
							}
							continue;
						}
						goto case 17;
					case 28:
						return;
					case 15:
						vsvfD7nOyo0(stream, value6);
						num = 9;
						break;
					case 11:
					case 24:
						(stream).WriteByte(flag ? ((byte)1) : ((byte)0));
						num3 = 36;
						continue;
					case 42:
						if (array != null)
						{
							num3 = 23;
							continue;
						}
						goto case 6;
					case 32:
						if (!(value is global::System.Collections.ICollection))
						{
							num3 = 29;
							continue;
						}
						goto case 26;
					case 9:
						return;
					case 12:
						qDNfDAy5OXg(stream, value3);
						num3 = 21;
						continue;
					case 5:
						flag = (byte)(int)(global::System.Collections.IList)value != 0;
						num = 24;
						break;
					case 43:
						value5 = (long)(StringContent)value;
						num3 = 37;
						continue;
					case 14:
						if (value is StringContent)
						{
							num3 = 43;
							continue;
						}
						goto case 35;
					case 40:
						value2 = (uint)(int)(AddressFamily)value;
						num3 = 16;
						continue;
					case 17:
						b = (byte)(int)(DateTimeOffset)value;
						num3 = 8;
						continue;
					case 36:
						return;
					case 8:
						(stream).WriteByte(b);
						num3 = 28;
						continue;
					case 25:
						return;
					case 37:
						I4cfDgQKgrR(stream, value5);
						num = 27;
						break;
					case 22:
						return;
					case 23:
						(stream).Write(array, 0, array.Length);
						num3 = 1;
						continue;
					case 19:
					case 29:
						if (value is AddressFamily)
						{
							num3 = 40;
							continue;
						}
						goto case 14;
					case 21:
						return;
					case 7:
						NYPfDIIRGhF(stream, value4);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num3 = 20;
						}
						continue;
					case 41:
						value3 = (ushort)(int)(FileMode)value;
						num = 12;
						break;
					case 3:
						value6 = (short)(int)(CipherMode)value;
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							num3 = 36;
						}
						continue;
					case 2:
					case 44:
						text = (string)(value as object);
						num3 = 18;
						continue;
					case 26:
						value4 = (int)(global::System.Collections.ICollection)value;
						num3 = 7;
						continue;
					case 31:
						if (!(value is global::System.Collections.IList))
						{
							num3 = 30;
							continue;
						}
						goto case 5;
					case 0:
						return;
					case 16:
						AGyfDBRv67Y(stream, value2);
						num3 = 25;
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 1032)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void x3YfDmoQGnH(object stream, object value)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void vsvfD7nOyo0(object stream, short value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteInt16LittleEndian(span, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void qDNfDAy5OXg(object stream, ushort value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(span, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NYPfDIIRGhF(object stream, int value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(span, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void AGyfDBRv67Y(object stream, uint value)
	{
		//IL_001b: Expected O, but got I4
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(span, value);
		_ = 2;
		_ = stackalloc byte[4];
		span = (global::System.Span<byte>)4;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972;
		_ = 0;
		(stream).Write((global::System.ReadOnlySpan<byte>)span);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void I4cfDgQKgrR(object stream, long value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteInt64LittleEndian(span, value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void XSifDlMVR2T(object stream, ulong value)
	{
		global::System.Span<byte> span = default(global::System.Span<byte>);
		System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(span, value);
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
					case 1:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
						{
							num3 = 1;
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
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lcg1mCZN53RB9nvJMyCM()
	{
		return idnvXEZNOCHGfkrsWr4B == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ccXGwWfD4Anv9wIKtEQi OwxPy9ZN6PWPacrsmMtE()
	{
		return (ccXGwWfD4Anv9wIKtEQi)idnvXEZNOCHGfkrsWr4B;
	}
}

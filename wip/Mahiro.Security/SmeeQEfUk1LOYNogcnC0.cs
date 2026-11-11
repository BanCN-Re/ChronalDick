using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using SRJB8PfUDKmfEgvmwxvn;
using ePgxqefhipUwkK39mRLP;
using fDAldojjppXrctUVYOJn;
using mdXrpVf4xrJgmIWAd0EM;

namespace xMk5tkfUVNH7XY6TZJsA;

internal class SmeeQEfUk1LOYNogcnC0
{
	private static object PCwfUoOlTxU;

	private static object D0WfUm7ObSv;

	private static object wUNfU7ABK7c;

	internal static object q2JJ3LZaDESHL3P8N4op;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool muFfUYNQ60J(byte reliability)
	{
		int num = 1;
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
						break;
					}
					goto case 1;
				case 1:
					if (reliability >= ((global::System.Array)PCwfUoOlTxU).Length)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 2;
				case 2:
					return (byte)((short[])PCwfUoOlTxU)[reliability] != 0;
				case 0:
					return false;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool p0UfUS3TBNb(byte reliability)
	{
		int num = 2;
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
				case 2:
					if (reliability >= ((global::System.Array)D0WfUm7ObSv).Length)
					{
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 0;
				case 0:
					return (byte)((short[])D0WfUm7ObSv)[reliability] != 0;
				case 1:
					return false;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AWFfUcjiRFi(byte reliability)
	{
		int num = 2;
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
				case 2:
					if (reliability >= ((global::System.Array)wUNfU7ABK7c).Length)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 0;
				case 0:
					return (byte)((short[])wUNfU7ABK7c)[reliability] != 0;
				case 1:
					return false;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static bool b6UfU08Ojcm(byte firstByte)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (firstByte >= 128)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					return false;
				case 0:
					return firstByte <= 143;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static bool BZxfU8Mkyww(object datagram, out List<ValueTuple<byte[], Jgaq6ef4PuO0JxER8Odt?>> frames)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static bool JE8fUyiVxvs(object datagram, [NotNullWhen(true)] out VRTBhBfhGNLMoKgoRIvW? packet)
	{
		Jgaq6ef4PuO0JxER8Odt? jgaq6ef4PuO0JxER8Odt = default(Jgaq6ef4PuO0JxER8Odt?);
		_ = jgaq6ef4PuO0JxER8Odt;
		int num = default(int);
		new Jgaq6ef4PuO0JxER8Odt(System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num)), System.Buffers.Binary.BinaryPrimitives.ReadUInt16BigEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num + 4)), System.Buffers.Binary.BinaryPrimitives.ReadUInt32BigEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>((byte[])datagram, num + 6)));
		packet = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static byte[] J2IfUWHDgXh(object packet)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] nXqfUJNAIIn(uint sequenceNumber)
	{
		DateTimeOffset[] array = new DateTimeOffset[7];
		System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
		array[4] = (DateTimeOffset)(byte)sequenceNumber;
		array[5] = (DateTimeOffset)(byte)(sequenceNumber >> 8);
		array[6] = (DateTimeOffset)(byte)(sequenceNumber >> 16);
		return (byte[])(object)array;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static byte[] LIFfUQSyZsA(global::System.Collections.Generic.IReadOnlyList<ValueTuple<uint, uint>> records)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static bool bZsfUCoGGtM(object datagram, byte packetId, out List<ValueTuple<uint, uint>> records)
	{
		int num = 3;
		_ = 4;
		int num2 = num2 + 1;
		*(int*)25 = (int)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref records);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint KRyfU4MjPfl(object data, int offset)
	{
		return (uint)(((short[])data)[offset] | (((short[])data)[offset + 1] << 8) | (((short[])data)[offset + 2] << 16));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void BWwfUhE7wNC(object stream, uint value)
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
								goto end_IL_0010;
							}
							goto case 1;
						}
						return;
					case 2:
						(stream).WriteByte((byte)value);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						break;
					case 1:
						(stream).WriteByte((byte)(value >> 8), DugbFHjPXTZwuNCef9LW.zHMjPfovJ4u);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
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
			(stream).WriteByte((byte)(value >> 16), DugbFHjPXTZwuNCef9LW.zHMjPfovJ4u);
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 6;
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
					case 1:
						goto end_IL_000e;
					case 6:
						num3 = 5;
						continue;
					case 0:
						wUNfU7ABK7c = new global::System.Collections.IList[8]
						{
							null,
							null,
							null,
							(global::System.Collections.IList)1,
							null,
							null,
							null,
							(global::System.Collections.IList)1
						};
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 4;
						}
						continue;
					case 5:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 2:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						return;
					}
					switch (num2)
					{
					case 994:
						break;
					default:
						return;
					case 13:
						D0WfUm7ObSv = new global::System.Collections.IList[8]
						{
							null,
							(global::System.Collections.IList)1,
							null,
							null,
							(global::System.Collections.IList)1,
							null,
							null,
							null
						};
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 10;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			global::System.Collections.IList[] array = new global::System.Collections.IList[8];
			System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
			PCwfUoOlTxU = array;
			num = 13;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xNxQUvZakmuWWu9DulRe()
	{
		return q2JJ3LZaDESHL3P8N4op == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SmeeQEfUk1LOYNogcnC0 vlSJVTZaV7kvtQkuFnex()
	{
		return (SmeeQEfUk1LOYNogcnC0)q2JJ3LZaDESHL3P8N4op;
	}
}

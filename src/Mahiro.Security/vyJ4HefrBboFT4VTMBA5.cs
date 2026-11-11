using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace vKtQ3GfrgqHeIsXRiJDa;

internal class vyJ4HefrBboFT4VTMBA5
{
	private static readonly object DDGfr6Qx1oS;

	private static readonly object yD6frRDUe7c;

	private static object CYwFfjZa0JrBHhYxW4DO;

	[MethodImpl((MethodImplOptions)8)]
	internal static int trrfrlmgDI8(int runtimeId)
	{
		int num = 2;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int ianfrdWSImh(int runtimeId)
	{
		int num = 3;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ushort[] MaDfrK6DtkY(object encoded, int count)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		ushort[] result = default(ushort[]);
		MemoryStream val2 = default(MemoryStream);
		int num4 = default(int);
		byte[] array = default(byte[]);
		int num7 = default(int);
		int num6 = default(int);
		ushort[] array2 = default(ushort[]);
		int num9 = default(int);
		int num11 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 0:
					return result;
				case 2:
					break;
				case 1:
					try
					{
						ZLibStream val = new ZLibStream((Stream)(object)val2, (CompressionMode)0);
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_00ab;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_00ab:
							num3 = num4;
						}
						try
						{
							(val).ReadExactly(default(global::System.Span<byte>));
							int num5 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num7 != 16)
									{
										if (num7 == 996)
										{
											goto IL_010c;
										}
										goto case 6;
									}
									num6 = 0;
									num5 = 5;
									continue;
								case 0:
								case 1:
									array2[num6] = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array, num6 * 2, 2)));
									num5 = 4;
									continue;
								case 4:
									num6++;
									num5 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num5 = 7;
									}
									continue;
								case 6:
									throw new InvalidDataException("Runtime-ID map contains trailing data");
								case 2:
									if ((val).ReadByte() == -1)
									{
										array2 = new ushort[count];
										num7 = 16;
										goto IL_010c;
									}
									num5 = 6;
									continue;
								case 5:
								case 7:
									if (num6 < array2.Length)
									{
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
										{
											num5 = 9;
										}
										continue;
									}
									break;
								case 8:
									break;
								case 3:
									goto end_IL_0110;
									IL_010c:
									num5 = num7;
									continue;
								}
								result = array2;
								num5 = 3;
								continue;
								end_IL_0110:
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
								{
									num8 = 6;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 989)
										{
											num8 = num9;
											continue;
										}
										break;
									case 0:
										(val).Dispose();
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
										{
											num8 = 2;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						int num10;
						if (val2 == null)
						{
							num10 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
							{
								num10 = 0;
							}
							goto IL_0331;
						}
						goto IL_0355;
						IL_0331:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_032d;
								}
								goto end_IL_0331;
							case 2:
								break;
							case 0:
								goto end_IL_0331;
							case 1:
								goto end_IL_0331;
							}
							goto IL_0355;
							IL_032d:
							num10 = num11;
							continue;
							end_IL_0331:
							break;
						}
						goto end_IL_02f9;
						IL_0355:
						(val2).Dispose();
						num10 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num10 = 1;
						}
						goto IL_0331;
						end_IL_02f9:;
					}
					goto case 0;
				}
				goto IL_0037;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0037;
				IL_0037:
				byte[] array3 = System.Convert.FromBase64String((string)encoded);
				array = new byte[checked(count * 2)];
				val2 = new MemoryStream(array3, false);
				num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
				{
					num2 = 1;
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
	internal static bool c1nVLiZa8KJrCKtdcJHV()
	{
		return CYwFfjZa0JrBHhYxW4DO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static vyJ4HefrBboFT4VTMBA5 aiPnDbZay2ds2tiLtggE()
	{
		return (vyJ4HefrBboFT4VTMBA5)CYwFfjZa0JrBHhYxW4DO;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using V4sdXyf4Krfx4OiV2unk;
using fDAldojjppXrctUVYOJn;

namespace xHfZwVfWegoMRYhf0neX;

internal class Xk4pP4fWwOTHm3UjNabK
{
	internal static object jsnfLLZuVIC9GFsa7AeZ;

	[MethodImpl((MethodImplOptions)8)]
	public static List<ValueTuple<uint, byte[]>> ElBfWPeZQQF(object payload, bool compressionEnabled, S3TYvPf4dw0Js0IbGOQN sessionAlgo)
	{
		int num = 16;
		S3TYvPf4dw0Js0IbGOQN s3TYvPf4dw0Js0IbGOQN = default(S3TYvPf4dw0Js0IbGOQN);
		int num5 = default(int);
		List<ValueTuple<uint, byte[]>> val = default(List<ValueTuple<uint, byte[]>>);
		byte b = default(byte);
		byte[] data = default(byte[]);
		int num6 = default(int);
		byte[] array = default(byte[]);
		int num8 = default(int);
		List<ValueTuple<uint, byte[]>> result = default(List<ValueTuple<uint, byte[]>>);
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
							goto case 2;
						}
						s3TYvPf4dw0Js0IbGOQN = sessionAlgo;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 28;
						}
						continue;
					case 15:
						if (((global::System.Array)payload).Length == 0)
						{
							num3 = 19;
							continue;
						}
						if (!compressionEnabled)
						{
							num3 = 6;
							continue;
						}
						goto case 1;
					case 2:
						num5 = 1;
						num3 = 10;
						continue;
					case 19:
						return val;
					case 8:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.Snappy;
						num = 22;
						break;
					case 14:
						if (((global::System.Array)payload).Length != 0)
						{
							num3 = 20;
							continue;
						}
						goto case 4;
					case 3:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.Zlib;
						num3 = 18;
						continue;
					case 21:
						if (b != 255)
						{
							num3 = 23;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 12;
					case 12:
						s3TYvPf4dw0Js0IbGOQN = S3TYvPf4dw0Js0IbGOQN.None;
						num3 = 2;
						continue;
					case 1:
						num5 = 0;
						num = 30;
						break;
					case 18:
						num5 = 1;
						num3 = 4;
						continue;
					case 9:
						if (b != 0)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 3;
					case 20:
						b = ((byte[])payload)[0];
						num3 = 9;
						continue;
					case 11:
					case 13:
						VCMfWxtTbPU(data, val);
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
						{
							num3 = 16;
						}
						continue;
					case 0:
						if (b != 1)
						{
							num3 = 21;
							continue;
						}
						goto case 8;
					case 22:
						num5 = 1;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 24;
						}
						continue;
					case 6:
						data = (byte[])payload;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num3 = 18;
						}
						continue;
					case 17:
						return val;
					case 16:
						val = new List<ValueTuple<uint, byte[]>>();
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 15;
						}
						continue;
					case 4:
					case 5:
					case 10:
					case 23:
						num3 = 26;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						{
							try
							{
								int num4;
								if (s3TYvPf4dw0Js0IbGOQN != S3TYvPf4dw0Js0IbGOQN.Zlib)
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
									{
										num4 = 4;
									}
									goto IL_0305;
								}
								goto IL_0393;
								IL_0305:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num6 != 15)
										{
											if (num6 != 995)
											{
												goto end_IL_0305;
											}
											goto IL_0301;
										}
										goto case 1;
									case 7:
										break;
									case 4:
										if (s3TYvPf4dw0Js0IbGOQN != S3TYvPf4dw0Js0IbGOQN.Snappy)
										{
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 2;
									case 0:
									case 6:
										array = ((byte[])payload)[System.Range.StartAt(((System.Index)num5))];
										num4 = 5;
										continue;
									case 1:
									case 5:
										data = array;
										num4 = 3;
										continue;
									case 2:
										array = Rt9fWNhAdb8(payload, num5);
										num6 = 15;
										goto IL_0301;
									case 3:
										goto end_IL_0305;
										IL_0301:
										num4 = num6;
										continue;
									}
									goto IL_0393;
									continue;
									end_IL_0305:
									break;
								}
								goto end_IL_02cc;
								IL_0393:
								array = dGUfWT8xeA5(payload, num5);
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num4 = 1;
								}
								goto IL_0305;
								end_IL_02cc:;
							}
							catch
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										break;
									default:
										if (num8 == 989)
										{
											num7 = num8;
											continue;
										}
										break;
									case 0:
										result = val;
										num7 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
										{
											num7 = 1;
										}
										continue;
									}
									break;
								}
								goto IL_023a;
							}
							goto case 11;
						}
						IL_023a:
						return result;
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
	private static void VCMfWxtTbPU(object data, List<ValueTuple<uint, byte[]>> result)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public static uint q4xfWFFivJy(object data, ref int pos)
	{
		int num = 0;
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static uint wYvfWsL4Kag(global::System.ReadOnlySpan<byte> data, ref int pos)
	{
		uint num = 0u;
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] dGUfWT8xeA5(object data, int start)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] Rt9fWNhAdb8(object data, int start)
	{
		return Snappier.Snappy.DecompressToArray(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>((byte[])data, start)));
	}

	[MethodImpl((MethodImplOptions)8)]
	public static uint H8lfWMJJwUX(global::System.ReadOnlySpan<byte> data, ref int pos)
	{
		int num = 1;
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static ushort IurfWpXOSKP(global::System.ReadOnlySpan<byte> data, ref int pos)
	{
		int num = 1;
		return default(ushort);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static int ngmfWuvY3PV(global::System.ReadOnlySpan<byte> data, ref int pos)
	{
		int num = 1;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HYlfFOZuYYHKKHHR8y9g()
	{
		return jsnfLLZuVIC9GFsa7AeZ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Xk4pP4fWwOTHm3UjNabK sTXnN4ZuSXuofaq6vMva()
	{
		return (Xk4pP4fWwOTHm3UjNabK)jsnfLLZuVIC9GFsa7AeZ;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using mTXgbUXtxVyBxISd8ZTw;

namespace ywKTLrf9s1JS7osGVg81;

sealed class iuQZKpf9FCllYdsW5HbW : global::System.IDisposable
{
	private static readonly UTF8Encoding s7Cf9a6mB07;

	private uPo34YXtP59Ky9BrpKU6? y4Hf91iYlEJ;

	private uPo34YXtP59Ky9BrpKU6? Dwtf93cpwJi;

	private bool Hd3f9vNimYU;

	private bool rvWf9EbbBUJ;

	internal static object VItw9RZNAc3nnbAe0oC3;

	internal bool Enabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return default(bool);
		}
	}

	internal bool Plaintext
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 2;
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void WhEf9Taysws(global::System.Span<byte> frame)
	{
		System.ObjectDisposedException.ThrowIf(rvWf9EbbBUJ, this);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void j6if9NIvEcD(global::System.Span<byte> frame)
	{
		System.ObjectDisposedException.ThrowIf(rvWf9EbbBUJ, this);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool vfbf9MH7L7I(global::System.ReadOnlySpan<byte> frame)
	{
		//IL_0556: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		int num = 16;
		int num4 = default(int);
		global::System.ReadOnlySpan<byte> readOnlySpan = default(global::System.ReadOnlySpan<byte>);
		ushort num14 = default(ushort);
		byte[] array = default(byte[]);
		bool result = default(bool);
		int num11 = default(int);
		uPo34YXtP59Ky9BrpKU6 dwtf93cpwJi2 = default(uPo34YXtP59Ky9BrpKU6);
		int num13 = default(int);
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
						if (num2 != 23)
						{
							if (num2 == 1004)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						return false;
					case 13:
						num4 = 4;
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
						{
							num3 = 0;
						}
						continue;
					case 15:
						if (!Hd3f9vNimYU)
						{
							if (frame.Length < 2)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num3 = 15;
								}
								continue;
							}
							goto case 2;
						}
						num = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num = 23;
						}
						break;
					case 11:
						num3 = ((readOnlySpan.Length == num4 + num14) ? 6 : 4);
						continue;
					case 5:
						num3 = ((array.Length == 32) ? 12 : 7);
						continue;
					case 9:
						return result;
					case 8:
						throw new InvalidDataException("基岩 RPC ChaCha8 握手密钥编码无效");
					case 2:
						if (System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(frame) != 0)
						{
							num3 = 10;
							continue;
						}
						readOnlySpan = frame.Slice(2);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
						{
							num3 = 4;
						}
						continue;
					case 16:
						System.ObjectDisposedException.ThrowIf(rvWf9EbbBUJ, this);
						num = 15;
						break;
					case 7:
						System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num3 = 8;
						}
						continue;
					case 3:
						if (readOnlySpan.Length < 4)
						{
							num3 = 14;
							continue;
						}
						num14 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(readOnlySpan.Slice(2));
						num3 = 13;
						continue;
					case 14:
						throw new InvalidDataException("基岩 RPC ChaCha8 握手数据不完整");
					case 0:
						if (num14 == 32)
						{
							num3 = 11;
							continue;
						}
						goto case 4;
					case 1:
					case 10:
						return false;
					case 4:
						throw new InvalidDataException("基岩 RPC ChaCha8 握手密钥长度无效");
					case 12:
						try
						{
							uPo34YXtP59Ky9BrpKU6 uPo34YXtP59Ky9BrpKU = (uPo34YXtP59Ky9BrpKU6)new uPo34YXtP59Ky9BrpKU6(default(global::System.ReadOnlySpan<byte>));
							int num9 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num9 = 6;
							}
							while (true)
							{
								int num10;
								switch (num9)
								{
								default:
									if (num11 != 16)
									{
										if (num11 == 996)
										{
											goto IL_02e4;
										}
										goto case 8;
									}
									goto end_IL_02e8;
								case 0:
									Hd3f9vNimYU = true;
									num9 = 8;
									break;
								case 5:
								case 7:
									y4Hf91iYlEJ = uPo34YXtP59Ky9BrpKU;
									num9 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
									{
										num9 = 14;
									}
									break;
								case 6:
									dwtf93cpwJi2 = (uPo34YXtP59Ky9BrpKU6)new uPo34YXtP59Ky9BrpKU6(default(global::System.ReadOnlySpan<byte>));
									num9 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
									{
										num9 = 14;
									}
									break;
								case 8:
									result = true;
									num10 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
									{
										num10 = 1;
									}
									goto IL_02e0;
								case 4:
									Dwtf93cpwJi = dwtf93cpwJi2;
									num9 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
									{
										num9 = 0;
									}
									break;
								case 3:
								{
									uPo34YXtP59Ky9BrpKU6? uPo34YXtP59Ky9BrpKU2 = y4Hf91iYlEJ;
									if (uPo34YXtP59Ky9BrpKU2 == null)
									{
										num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
										{
											num9 = 6;
										}
										break;
									}
									uPo34YXtP59Ky9BrpKU2.Dispose();
									num10 = 2;
									goto IL_02e0;
								}
								case 1:
								case 2:
									{
										uPo34YXtP59Ky9BrpKU6? dwtf93cpwJi = Dwtf93cpwJi;
										if (dwtf93cpwJi == null)
										{
											num9 = 5;
											break;
										}
										dwtf93cpwJi.Dispose();
										num9 = 7;
										break;
									}
									IL_02e4:
									num9 = num11;
									break;
									IL_02e0:
									num11 = num10;
									goto IL_02e4;
								}
								continue;
								end_IL_02e8:
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num12 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 988)
									{
										num12 = num13;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 9;
					case 6:
						try
						{
							array = (s7Cf9a6mB07).GetBytes((s7Cf9a6mB07).GetString(readOnlySpan.Slice(num4)));
							int num5 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
							{
								num5 = 0;
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
							int num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										goto IL_0583;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0583:
								num7 = num8;
							}
							throw new InvalidDataException("基岩 RPC ChaCha8 握手密钥编码无效", (global::System.Exception)(object)ex2);
						}
						goto case 5;
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
	internal bool SAwf9pipDci(global::System.ReadOnlySpan<byte> frame)
	{
		Hd3f9vNimYU = true;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_002a: Expected O, but got I4
		//IL_0019->IL0019: Incompatible stack types: I4 vs O
		((uPo34YXtP59Ky9BrpKU6)(y4Hf91iYlEJ ?? ((object)4))).Dispose();
		default(uPo34YXtP59Ky9BrpKU6)?.Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	public iuQZKpf9FCllYdsW5HbW()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mKcnktZNIXpL6j9BwQkH()
	{
		return VItw9RZNAc3nnbAe0oC3 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static iuQZKpf9FCllYdsW5HbW VgBWl1ZNBhKFtUX9qr7B()
	{
		return (iuQZKpf9FCllYdsW5HbW)VItw9RZNAc3nnbAe0oC3;
	}
}

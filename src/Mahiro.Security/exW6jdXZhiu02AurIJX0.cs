using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using DA13y7xHUtQiwdGNt7U;
using FNZYemX9hTsCS2mHgSne;
using fDAldojjppXrctUVYOJn;
using tub52EXDkKsi0h1HL5Yl;

namespace yhPKfjXZUiZRkPBdj3U0;

sealed class exW6jdXZhiu02AurIJX0 : global::System.IDisposable
{
	private static readonly UTF8Encoding wFRXZIKPn6W;

	private Wtxhn7xKZiMM9ABDupm? UdmXZBEsCEl;

	private Wtxhn7xKZiMM9ABDupm? QtZXZgUIhOf;

	private bool h67XZl239PJ;

	private bool wCKXZdGaX2r;

	internal static object zfw2T5ZAUlxWIbP8pCcV;

	private static global::System.ReadOnlySpan<byte> Nonce
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "163 NetEase\n"u8;
		}
	}

	internal bool Enabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return default(bool);
		}
	}

	internal bool Plaintext
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void ntxXZrRp3Ts(global::System.Span<byte> payload)
	{
		System.ObjectDisposedException.ThrowIf(wCKXZdGaX2r, this);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void bOfXZoeWDy0(global::System.Span<byte> payload)
	{
		System.ObjectDisposedException.ThrowIf(wCKXZdGaX2r, this);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool J95XZmu7qMy(global::System.ReadOnlySpan<byte> frame)
	{
		//IL_0443: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		qK5P5RX94J63yK8jJsNo qK5P5RX94J63yK8jJsNo = default(qK5P5RX94J63yK8jJsNo);
		byte[] array = default(byte[]);
		global::System.ReadOnlySpan<byte> payload = default(global::System.ReadOnlySpan<byte>);
		string text = default(string);
		int num9 = default(int);
		bool result = default(bool);
		int num11 = default(int);
		int num5 = default(int);
		int num7 = default(int);
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
						if (num2 != 24)
						{
							if (num2 == 1005)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						qK5P5RX94J63yK8jJsNo.xqTX9IJgno1();
						num3 = 10;
						continue;
					case 2:
						if (!h67XZl239PJ)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 15;
					case 6:
						System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
						{
							num3 = 1;
						}
						continue;
					case 7:
					case 12:
						return false;
					case 11:
						payload = frame.Slice(2);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
						{
							num3 = 16;
						}
						continue;
					case 1:
						throw new InvalidDataException("Java RPC ChaCha8 握手密钥长度无效");
					case 3:
						System.ObjectDisposedException.ThrowIf(wCKXZdGaX2r, this);
						num3 = 2;
						continue;
					case 15:
						return false;
					case 0:
						if (frame.Length < 2)
						{
							num = 7;
							break;
						}
						goto case 8;
					case 5:
						text = qK5P5RX94J63yK8jJsNo.PrvX97LRNgd("握手密钥");
						num = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num = 8;
						}
						break;
					case 16:
						if (!uLfXZAles2U(payload))
						{
							num3 = 17;
							continue;
						}
						qK5P5RX94J63yK8jJsNo = CfMulxXDDpJgC5q81PnH.AAnXDYAWoMW(payload);
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num3 = 17;
						}
						continue;
					case 14:
						try
						{
							UdmXZBEsCEl = (Wtxhn7xKZiMM9ABDupm?)new Wtxhn7xKZiMM9ABDupm(default(global::System.ReadOnlySpan<byte>), Nonce);
							int num8 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									switch (num9)
									{
									case 990:
										break;
									default:
										goto end_IL_0273;
									case 10:
										h67XZl239PJ = true;
										num8 = 2;
										continue;
									}
									goto IL_026f;
								case 2:
									result = true;
									num8 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
									{
										num8 = 0;
									}
									continue;
								case 1:
									QtZXZgUIhOf = (Wtxhn7xKZiMM9ABDupm?)new Wtxhn7xKZiMM9ABDupm(default(global::System.ReadOnlySpan<byte>), Nonce);
									num9 = 10;
									goto IL_026f;
								case 0:
									break;
									IL_026f:
									num8 = num9;
									continue;
									end_IL_0273:
									break;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num10 = 4;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										num10 = num11;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 13;
					case 8:
						if (System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian(frame) == 0)
						{
							num3 = 11;
							continue;
						}
						goto case 7;
					case 13:
						return result;
					case 4:
						qK5P5RX94J63yK8jJsNo.AnCX9Up5NK8("握手版本");
						num3 = 5;
						continue;
					case 9:
						if (array.Length == 32)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num3 = 10;
							}
						}
						else
						{
							num3 = 6;
						}
						continue;
					case 10:
						try
						{
							array = (wFRXZIKPn6W).GetBytes(text);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
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
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num6 = 2;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										goto IL_0470;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0470:
								num6 = num7;
							}
							throw new InvalidDataException("Java RPC ChaCha8 握手密钥编码无效", (global::System.Exception)(object)ex2);
						}
						goto case 9;
					case 17:
						return false;
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
	internal bool I5cXZ7Egv6U(global::System.ReadOnlySpan<byte> frame)
	{
		h67XZl239PJ = true;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool uLfXZAles2U(global::System.ReadOnlySpan<byte> payload)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0029: Expected O, but got I4
		default(Wtxhn7xKZiMM9ABDupm)?.Dispose();
		_ = 12;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776;
		default(Wtxhn7xKZiMM9ABDupm)?.Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	public exW6jdXZhiu02AurIJX0()
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
	internal static bool K2YhkEZArK8lKM8kPB8i()
	{
		return zfw2T5ZAUlxWIbP8pCcV == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static exW6jdXZhiu02AurIJX0 qlVL3AZAoSirfkrscPXI()
	{
		return (exW6jdXZhiu02AurIJX0)zfw2T5ZAUlxWIbP8pCcV;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QYGhLHXItkif7OOHRlA7;
using fDAldojjppXrctUVYOJn;

namespace fBoiiMXA2IYv4Oy0MsjP;

internal class XiZQAGXAERAuE93TspKZ
{
	private static readonly UTF8Encoding RfcXILI0Mns;

	internal static object Cglcg5ZO0sRXIf7sdmeN;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cUUXAq0Apn0(global::System.ReadOnlySpan<byte> packet, global::System.ReadOnlySpan<byte> mask, out qp1wBpXIHSoMwJ0wWPPV? request)
	{
		request = default(qp1wBpXIHSoMwJ0wWPPV?);
		int num = 4;
		bool flag = default(bool);
		global::System.Span<byte> span2 = default(global::System.Span<byte>);
		int num8 = default(int);
		int num6 = default(int);
		bool flag2 = default(bool);
		int num5 = default(int);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		byte b = default(byte);
		int num9 = default(int);
		int num11 = default(int);
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
							goto case 5;
						}
						if (packet.Length == 272)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num3 = 3;
							}
							break;
						}
						goto case 1;
					case 1:
						return false;
					case 0:
						return flag;
					case 5:
						if (System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(packet.Slice(4)) == 13)
						{
							span2 = new byte[260];
							num3 = 6;
							break;
						}
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num3 = 1;
						}
						break;
					case 4:
						request = null;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
						{
							num3 = 3;
						}
						break;
					case 6:
						try
						{
							global::System.ReadOnlySpan<byte> readOnlySpan = packet.Slice(12);
							int num4 = 32;
							while (true)
							{
								int num7;
								switch (num4)
								{
								default:
									if (num8 != 55 && num8 == 1035)
									{
										goto IL_0123;
									}
									goto case 26;
								case 13:
									break;
								case 35:
									break;
								case 32:
									readOnlySpan.CopyTo(span2);
									num4 = 28;
									continue;
								case 16:
									num6 = System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(span2);
									num4 = 42;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
									{
										num4 = 9;
									}
									continue;
								case 43:
									flag = false;
									num7 = 35;
									goto IL_011f;
								case 7:
								case 11:
								case 14:
								case 37:
									flag2 = true;
									num4 = 20;
									continue;
								case 33:
									num5 = MemoryExtensions.IndexOf<byte>(span, (byte)0);
									num4 = 39;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
									{
										num4 = 21;
									}
									continue;
								case 34:
									if (b >= 97)
									{
										num7 = 4;
										goto IL_011f;
									}
									goto case 6;
								case 9:
									if (num6 < 101)
									{
										num4 = 40;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
										{
											num4 = 29;
										}
										continue;
									}
									goto case 8;
								case 18:
								case 29:
									flag = true;
									num4 = 10;
									continue;
								case 8:
									if (num6 > 201)
									{
										num4 = 18;
										continue;
									}
									goto case 1;
								case 15:
									flag = false;
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
									{
										num4 = 13;
									}
									continue;
								case 12:
									if (b <= 57)
									{
										num4 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
										{
											num4 = 7;
										}
										continue;
									}
									goto case 0;
								case 3:
								case 44:
									num9 = 0;
									num4 = 24;
									continue;
								case 24:
								case 46:
									if (num9 >= num5)
									{
										num4 = 25;
										continue;
									}
									goto case 47;
								case 4:
									if (b <= 122)
									{
										num7 = 37;
										goto IL_011f;
									}
									goto case 0;
								case 1:
									flag = false;
									num4 = 42;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num4 = 16;
									}
									continue;
								case 2:
									span = span2.Slice(4);
									num4 = 33;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
									{
										num4 = 14;
									}
									continue;
								case 10:
								case 42:
									if (flag)
									{
										num7 = 43;
										goto IL_011f;
									}
									goto case 2;
								case 30:
									if (b != 95)
									{
										num4 = 41;
										continue;
									}
									goto case 7;
								case 21:
									if (num5 > 0)
									{
										num4 = 3;
										continue;
									}
									goto case 15;
								case 27:
									if (b < 65)
									{
										num4 = 19;
										continue;
									}
									goto case 34;
								case 38:
									num9++;
									num4 = 46;
									continue;
								case 28:
									qGPXAiQwxcZ(span2, mask);
									num4 = 35;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num4 = 16;
									}
									continue;
								case 17:
								case 19:
									if (b < 48)
									{
										num7 = 55;
										goto IL_011f;
									}
									goto case 12;
								case 20:
								case 39:
									if (!flag2)
									{
										num4 = 23;
										continue;
									}
									goto case 38;
								case 23:
									flag = false;
									num4 = 45;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
									{
										num4 = 49;
									}
									continue;
								case 6:
									if (b <= 90)
									{
										num4 = 11;
										continue;
									}
									goto case 30;
								case 22:
									flag = true;
									num4 = 36;
									continue;
								case 45:
									break;
								case 0:
								case 5:
								case 31:
								case 40:
								case 41:
									flag2 = false;
									num4 = 39;
									continue;
								case 26:
									if ((uint)(b - 45) > 1u)
									{
										num4 = 40;
										continue;
									}
									goto case 7;
								case 47:
									b = span[num9];
									num4 = 25;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
									{
										num4 = 27;
									}
									continue;
								case 25:
									request = (qp1wBpXIHSoMwJ0wWPPV?)new qp1wBpXIHSoMwJ0wWPPV((System.Text.Encoding.ASCII).GetString(((global::System.Span<byte>)span.Slice(0, num5))), num6 - 101);
									num4 = 22;
									continue;
								case 36:
									break;
									IL_011f:
									num8 = num7;
									goto IL_0123;
									IL_0123:
									num4 = num8;
									continue;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(span2);
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
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
						goto case 0;
					case 3:
						if (mask.Length == 496)
						{
							goto end_IL_000c;
						}
						goto case 1;
					case 2:
						if (System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(packet) == 260)
						{
							num3 = 5;
							break;
						}
						goto case 1;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] YL1XAGnKUyc(global::System.ReadOnlySpan<byte> nativeTicket, global::System.ReadOnlySpan<byte> mask)
	{
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		byte[] array = default(byte[]);
		int num6 = default(int);
		byte[] result = default(byte[]);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						try
						{
							System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(default(global::System.Span<byte>), 512);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 != 11)
									{
										if (num6 == 991)
										{
											goto IL_0197;
										}
										goto case 3;
									}
									goto end_IL_019b;
								case 3:
									nativeTicket.CopyTo(MemoryExtensions.AsSpan<byte>(array, 12));
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num4 = 3;
									}
									break;
								case 0:
									qGPXAiQwxcZ(MemoryExtensions.AsSpan<byte>(array, 12), mask);
									num4 = 2;
									break;
								case 2:
								{
									result = array;
									int num5 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
									{
										num5 = 10;
									}
									num6 = num5;
									goto IL_0197;
								}
								case 1:
									{
										System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian(MemoryExtensions.AsSpan<byte>(array, 4), 14);
										num4 = 3;
										break;
									}
									IL_0197:
									num4 = num6;
									break;
								}
								continue;
								end_IL_019b:
								break;
							}
						}
						catch
						{
							int num7 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										break;
									}
									goto case 0;
								case 0:
									System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
									num7 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
									{
										num7 = 1;
									}
									break;
								case 1:
									throw;
								}
							}
						}
						goto case 4;
					case 1:
						throw new ArgumentException("NCG 封包掩码长度无效", "mask");
					case 2:
						if (mask.Length == 496)
						{
							if (nativeTicket.IsEmpty)
							{
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num3 = 8;
								}
								continue;
							}
							goto case 0;
						}
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						if (nativeTicket.Length >= 512)
						{
							num3 = 8;
							continue;
						}
						goto case 6;
					case 4:
						return result;
					case 6:
						if (!MemoryExtensions.Contains<byte>(nativeTicket, (byte)0))
						{
							num = 3;
							break;
						}
						goto case 7;
					case 7:
					case 8:
					case 9:
						throw new ArgumentException("原生用户票据必须为 1 到 511 字节，不能含 NUL；不会截断票据", "nativeTicket");
					case 3:
						(RfcXILI0Mns).GetCharCount(nativeTicket);
						num3 = 5;
						continue;
					case 5:
						array = new byte[524];
						num = 16;
						break;
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
	private unsafe static void qGPXAiQwxcZ(global::System.Span<byte> bytes, global::System.ReadOnlySpan<byte> mask)
	{
		//IL_0020: Expected F4, but got I4
		int num = default(int);
		ref byte reference = ref bytes[num];
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref reference) = (int)(byte)(global::System.Runtime.CompilerServices.Unsafe.As<byte, short>(ref reference) ^ *(short*)mask[num % mask.Length]);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool X1BvUeZO8uCHxPDcvUho()
	{
		return Cglcg5ZO0sRXIf7sdmeN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XiZQAGXAERAuE93TspKZ wPslsSZOyXMGcLcBsOKr()
	{
		return (XiZQAGXAERAuE93TspKZ)Cglcg5ZO0sRXIf7sdmeN;
	}
}

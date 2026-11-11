using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace l7sYxOXw1UqblxoyRMtK;

internal class Q6ETVKXwaTp4Tr9J7a2h
{
	private static object pFi3fXZ6hOCE5MdYp9xO;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static byte[] UNvXw3qPtuK(global::System.ReadOnlySpan<byte> encrypted, object keyHex)
	{
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		Aes val = default(Aes);
		int num6 = default(int);
		int num12 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		byte[] array4 = default(byte[]);
		global::System.Span<byte> counter = default(global::System.Span<byte>);
		int num11 = default(int);
		byte[] array3 = default(byte[]);
		ICryptoTransform val2 = default(ICryptoTransform);
		byte[] result = default(byte[]);
		int num14 = default(int);
		byte[] array = default(byte[]);
		int num17 = default(int);
		bool flag = default(bool);
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
						if (num2 != 18)
						{
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						try
						{
							(val).Mode = (CipherMode)2;
							int num5 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 10)
									{
										if (num6 == 990)
										{
											goto IL_01b4;
										}
										goto case 0;
									}
									try
									{
										byte[] array2 = new byte[encrypted.Length];
										int num7 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num7 = 10;
										}
										while (true)
										{
											int num9;
											switch (num7)
											{
											default:
												if (num12 != 26)
												{
													if (num12 == 1006)
													{
														goto IL_0297;
													}
													goto case 0;
												}
												goto case 16;
											case 14:
												num8 = 0;
												num7 = 15;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
												{
													num7 = 3;
												}
												continue;
											case 11:
												num10 += 16;
												num7 = 3;
												continue;
											case 9:
												array4 = new byte[16];
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
												{
													num7 = 20;
												}
												continue;
											case 17:
												NuuXwEheDpn(counter);
												num7 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
												{
													num7 = 10;
												}
												continue;
											case 4:
												num11 = System.Math.Min(16, encrypted.Length - num10);
												num7 = 14;
												continue;
											case 6:
												array3 = new byte[16];
												num7 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
												{
													num7 = 9;
												}
												continue;
											case 7:
											case 15:
												if (num8 < num11)
												{
													num9 = 10;
													goto IL_0293;
												}
												goto case 17;
											case 16:
												counter.CopyTo(default(global::System.Span<byte>));
												num9 = 5;
												goto IL_0293;
											case 5:
												(val2).TransformBlock(array3, 0, array3.Length, array4, 0);
												num7 = 4;
												continue;
											case 0:
												num10 = 0;
												num7 = 10;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
												{
													num7 = 1;
												}
												continue;
											case 10:
											case 13:
												array2[num10 + num8] = (byte)(*(byte*)encrypted[num10 + num8] ^ array4[num8]);
												num7 = 8;
												continue;
											case 12:
												result = array2;
												num7 = 18;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
												{
													num7 = 12;
												}
												continue;
											case 1:
											case 3:
												if (num10 < encrypted.Length)
												{
													num9 = 26;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
													{
														num9 = 3;
													}
													goto IL_0293;
												}
												goto case 12;
											case 2:
												counter = stackalloc byte[16];
												num9 = 6;
												goto IL_0293;
											case 8:
												num8++;
												num7 = 7;
												continue;
											case 18:
												break;
												IL_0293:
												num12 = num9;
												goto IL_0297;
												IL_0297:
												num7 = num12;
												continue;
											}
											break;
										}
									}
									finally
									{
										if (val2 != null)
										{
											int num13 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
											{
												num13 = 0;
											}
											while (true)
											{
												switch (num13)
												{
												default:
													if (num14 == 989)
													{
														num13 = num14;
														continue;
													}
													break;
												case 0:
													(val2).Dispose();
													num13 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
													{
														num13 = 2;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									goto end_IL_01b8;
								case 1:
								{
									val2 = (val).CreateEncryptor();
									int num15 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
									{
										num15 = 9;
									}
									num6 = num15;
									goto IL_01b4;
								}
								case 2:
									(val).Padding = (PaddingMode)1;
									num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
									{
										num5 = 0;
									}
									break;
								case 0:
									{
										(val).Key = array;
										num5 = 1;
										break;
									}
									IL_01b4:
									num5 = num6;
									break;
								}
								continue;
								end_IL_01b8:
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num16 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
								{
									num16 = 2;
								}
								while (true)
								{
									switch (num16)
									{
									default:
										if (num17 == 989)
										{
											num16 = num17;
											continue;
										}
										break;
									case 1:
										(val).Dispose();
										num16 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
										{
											num16 = 7;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 3;
					case 8:
						flag = false;
						num3 = 11;
						continue;
					case 2:
						flag = true;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num3 = 10;
						}
						continue;
					case 5:
						num4 = array.Length;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num3 = 12;
						}
						continue;
					case 9:
						throw new InvalidDataException("内容分发 AES 密钥长度无效");
					case 1:
						break;
					case 10:
					case 11:
						if (flag)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
							{
								num3 = 18;
							}
							continue;
						}
						goto case 9;
					case 4:
						if (num4 != 24)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 2;
					case 0:
						if (num4 != 16)
						{
							num3 = 4;
							continue;
						}
						goto case 2;
					case 3:
						return result;
					case 6:
						array = System.Convert.FromHexString((string)keyHex);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
						{
							num3 = 5;
						}
						continue;
					case 7:
						if (num4 == 32)
						{
							num3 = 2;
							continue;
						}
						goto case 8;
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
			val = System.Security.Cryptography.Aes.Create();
			num = 18;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task jaeXwv2tNAQ(object encrypted, object decrypted, object keyHex, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_DecryptAesCtrAsync_d__1 decryptAesCtrAsync_d__ = default(_DecryptAesCtrAsync_d__1);
		decryptAesCtrAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NuuXwEheDpn(global::System.Span<byte> counter)
	{
		//IL_000f: Expected F4, but got I4
		int num = default(int);
		ref byte reference = ref counter[num];
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref reference) = (int)(byte)(global::System.Runtime.CompilerServices.Unsafe.As<byte, short>(ref reference) + 1);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool CNS5qAZ6UcfyyGiPrdNU()
	{
		return pFi3fXZ6hOCE5MdYp9xO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Q6ETVKXwaTp4Tr9J7a2h BwHdDMZ6rhGU0K5KodZR()
	{
		return (Q6ETVKXwaTp4Tr9J7a2h)pFi3fXZ6hOCE5MdYp9xO;
	}
}

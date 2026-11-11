using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace anmNuRasIpBHSpIrwSJ;

internal class RASndraFFlYP4RJ9RVA
{
	private static object eYNa3wtted;

	private static object IhLavXKUFL;

	private static object kHUaEEJ4QH;

	private static object JKHa2ag4ET;

	internal static object WUCfYTZUBqqorSXcq4WN;

	[MethodImpl((MethodImplOptions)8)]
	internal static int i8taT65Zcx(int value)
	{
		int num = 5;
		int num6 = default(int);
		int[] array = default(int[]);
		int num5 = default(int);
		int num4 = default(int);
		int round = default(int);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						num6 = (((byte[])(object)array)[0] << 8) + ((byte[])(object)array)[1];
						num3 = 8;
						continue;
					case 2:
						return (num5 >> 8 << 24) | ((num5 & 0xFF) << 16) | (num6 >> 8 << 8) | (num6 & 0xFF);
					case 6:
						num4 = 0;
						num3 = 9;
						continue;
					case 4:
						num4++;
						num3 = 10;
						continue;
					case 8:
						num5 = (((byte[])(object)array)[2] << 8) + ((byte[])(object)array)[3];
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						num6 ^= VTaaa5wxPG(round, num5) ^ round++;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							num3 = 14;
						}
						continue;
					case 3:
					case 7:
						num5 ^= VTaaa5wxPG(round, num6) ^ round++;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num3 = 4;
						}
						continue;
					case 9:
					case 10:
						if (num4 < 12)
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 2;
					case 5:
						break;
					case 1:
						round = 0;
						num3 = 6;
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
			array = (int[])(object)new global::System.Collections.ICollection[4]
			{
				(global::System.Collections.ICollection)((value >> 24) & 0xFF),
				(global::System.Collections.ICollection)((value >> 16) & 0xFF),
				(global::System.Collections.ICollection)((value >> 8) & 0xFF),
				(global::System.Collections.ICollection)(value & 0xFF)
			};
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
			{
				num = 17;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string sahaNkQLXJ(object roleName, uint userId)
	{
		int num = 2;
		byte[] array = default(byte[]);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return (System.Convert.ToHexString(array)).ToLowerInvariant();
					case 3:
						array[6] = (byte)((((short[])(object)array)[6] & 0xF) | 0x30);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						array = System.Security.Cryptography.MD5.HashData((System.Text.Encoding.UTF8).GetBytes((string)roleName));
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 5;
						}
						continue;
					case 0:
						array[8] = (byte)((((short[])(object)array)[8] & 0x3F) | 0x80);
						num = 10;
						break;
					case 1:
						(System.BitConverter.GetBytes(i8taT65Zcx((int)userId))).CopyTo(array, 12);
						num = 3;
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
	internal static uint VMHaMnD21Y(object uuid)
	{
		//IL_00e3: Expected O, but got Unknown
		int num = 2;
		byte[] array = default(byte[]);
		string text = default(string);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						throw new global::System.Exception("Java 角色 UUID 必须包含 32 个十六进制字符");
					case 0:
						break;
					case 5:
						try
						{
							array = System.Convert.FromHexString(text);
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
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
						catch (FormatException ex)
						{
							FormatException ex2 = ex;
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										goto IL_0110;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0110:
								num6 = num7;
							}
							_ = "Java 角色 UUID 包含无效字符";
							throw ex2;
						}
						goto case 4;
					case 3:
						_ = "Java 角色 UUID 不能为空";
						throw new global::System.Exception("uuid");
					case 1:
						text = ((uuid).Replace("-", string.Empty, (StringComparison)4)).Trim();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						if (!string.IsNullOrWhiteSpace((string)uuid))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 3;
					case 4:
						return (uint)JABa16JyLd(System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array, 12, 4)));
					}
					if ((text).Length != 32)
					{
						goto end_IL_000c;
					}
					num3 = 10;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
					{
						num3 = 5;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
			{
				num = 12;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string TWRap1VHx7(object token)
	{
		int num = 2;
		string result = default(string);
		Aes val = default(Aes);
		int num5 = default(int);
		byte[] array = default(byte[]);
		string text = default(string);
		string text2 = default(string);
		int num7 = default(int);
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
					goto case 1;
				case 0:
					return result;
				case 2:
					val = System.Security.Cryptography.Aes.Create();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					try
					{
						(val).Mode = (CipherMode)1;
						int num3 = 6;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 != 14)
								{
									if (num5 == 994)
									{
										goto IL_0088;
									}
									goto case 1;
								}
								result = System.Convert.ToHexString(((val).CreateEncryptor()).TransformFinalBlock(array, 0, array.Length));
								num3 = 3;
								continue;
							case 0:
								(val).Key = (byte[])IhLavXKUFL;
								num3 = 2;
								continue;
							case 1:
								text = E6naubZcfE(8);
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
								{
									num3 = 14;
								}
								continue;
							case 2:
								(val).IV = (byte[])kHUaEEJ4QH;
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
								{
									num3 = 1;
								}
								continue;
							case 6:
								(val).Padding = (PaddingMode)3;
								num3 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
								{
									num3 = 0;
								}
								continue;
							case 4:
								text2 = E6naubZcfE(8);
								num3 = 5;
								continue;
							case 5:
							{
								array = (System.Text.Encoding.ASCII).GetBytes(string.Concat(text, (string)token, text2));
								int num4 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
								{
									num4 = 14;
								}
								num5 = num4;
								goto IL_0088;
							}
							case 3:
								break;
								IL_0088:
								num3 = num5;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (val == null)
						{
							num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
							{
								num6 = 8;
							}
							goto IL_0232;
						}
						goto IL_0256;
						IL_0232:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_022e;
								}
								break;
							case 0:
								break;
							case 2:
								goto end_IL_0232;
							case 1:
								goto end_IL_0232;
							}
							goto IL_0256;
							IL_022e:
							num6 = num7;
							continue;
							end_IL_0232:
							break;
						}
						goto end_IL_01fa;
						IL_0256:
						(val).Dispose();
						num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num6 = 5;
						}
						goto IL_0232;
						end_IL_01fa:;
					}
					goto case 0;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string E6naubZcfE(int length)
	{
		int num = 3;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int VTaaa5wxPG(int round, int word)
	{
		int num = 1;
		int num6 = default(int);
		int num9 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num8 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						return (num6 << 8) + num9;
					case 1:
						num5 = word >> 8;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num3 = 12;
						}
						continue;
					case 5:
						break;
					case 2:
						num7 = ((short[])JKHa2ag4ET)[num8 ^ ((short[])eYNa3wtted)[(4 * round + 1) % 10]] ^ num4;
						num3 = 4;
						continue;
					case 3:
						num8 = ((short[])JKHa2ag4ET)[num4 ^ ((short[])eYNa3wtted)[4 * round % 10]] ^ num5;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						num6 = ((short[])JKHa2ag4ET)[num7 ^ ((short[])eYNa3wtted)[(4 * round + 2) % 10]] ^ num8;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						num4 = word & 0xFF;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num3 = 3;
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
			num9 = ((short[])JKHa2ag4ET)[num6 ^ ((short[])eYNa3wtted)[(4 * round + 3) % 10]] ^ num7;
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int JABa16JyLd(int value)
	{
		int num = 8;
		int num4 = default(int);
		int num5 = default(int);
		int num6 = default(int);
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
						if (num2 != 15 && num2 == 996)
						{
							goto end_IL_0010;
						}
						goto case 3;
					case 8:
						num4 = (value >> 16) & 0xFFFF;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
						{
							num3 = 10;
						}
						continue;
					case 0:
					case 4:
						if (num5 >= 1)
						{
							num = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num = 9;
							}
							break;
						}
						goto case 6;
					case 7:
						num6 = value & 0xFFFF;
						num3 = 5;
						continue;
					case 6:
						return (num6 << 16) | num4;
					case 3:
						num6 ^= VTaaa5wxPG(num5, num4) ^ num5;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						num5 -= 2;
						num = 4;
						break;
					case 5:
						num5 = 23;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							num3 = 7;
						}
						continue;
					case 1:
						num4 ^= VTaaa5wxPG(num5 - 1, num6) ^ (num5 - 1);
						num3 = 2;
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
		int num = 4;
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
					{
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0012;
							}
							goto case 0;
						}
						DateTimeOffset[] array = new DateTimeOffset[256];
						System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
						JKHa2ag4ET = array;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 1;
						}
						continue;
					}
					case 1:
						return;
					case 2:
						break;
					case 5:
						IhLavXKUFL = (System.Text.Encoding.ASCII).GetBytes("debbde3548928fab");
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
						{
							num3 = 2;
						}
						continue;
					case 7:
						eYNa3wtted = (System.Text.Encoding.ASCII).GetBytes("SaintSteve");
						num3 = 5;
						continue;
					case 3:
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 6;
						}
						continue;
					case 0:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 7;
						continue;
					case 4:
						num3 = 3;
						continue;
					case 6:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
						{
							num3 = 0;
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
			kHUaEEJ4QH = (System.Text.Encoding.ASCII).GetBytes("afd4c5c5a7c456a1");
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool ARDgNhZUgwCQHVBPWpLq()
	{
		return WUCfYTZUBqqorSXcq4WN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RASndraFFlYP4RJ9RVA RegcpeZUl2982cb4lCIn()
	{
		return (RASndraFFlYP4RJ9RVA)WUCfYTZUBqqorSXcq4WN;
	}
}

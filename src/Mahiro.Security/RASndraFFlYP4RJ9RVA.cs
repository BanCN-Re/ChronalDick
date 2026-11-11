using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace anmNuRasIpBHSpIrwSJ;

internal class RASndraFFlYP4RJ9RVA
{
	private static readonly object eYNa3wtted;

	private static readonly object IhLavXKUFL;

	private static readonly object kHUaEEJ4QH;

	private static readonly object JKHa2ag4ET;

	internal static object WUCfYTZUBqqorSXcq4WN;

	[MethodImpl((MethodImplOptions)8)]
	internal static int i8taT65Zcx(int value)
	{
		int round = default(int);
		int word = default(int);
		int num = default(int);
		num = num ^ (VTaaa5wxPG(round, word) ^ round++);
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string sahaNkQLXJ(object roleName, uint userId)
	{
		byte[] array = System.Security.Cryptography.MD5.HashData((System.Text.Encoding.UTF8).GetBytes((string)roleName));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uint VMHaMnD21Y(object uuid)
	{
		//IL_00e3: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
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
						throw new FormatException("Java 角色 UUID 必须包含 32 个十六进制字符");
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
							throw new FormatException("Java 角色 UUID 包含无效字符", (global::System.Exception)(object)ex2);
						}
						goto case 4;
					case 3:
						throw new ArgumentException("Java 角色 UUID 不能为空", "uuid");
					case 1:
						text = (((dynamic)(uuid)).Replace("-", string.Empty, (StringComparison)4)).Trim();
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
						return (uint)JABa16JyLd(System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array, 12, 4))));
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
		int num = 0;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int VTaaa5wxPG(int round, int word)
	{
		int num = 1;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int JABa16JyLd(int value)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
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

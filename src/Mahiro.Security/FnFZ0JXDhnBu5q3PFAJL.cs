using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace R26CvrXDU9IrxrsNNmvK;

internal class FnFZ0JXDhnBu5q3PFAJL
{
	private static object sln6V0ZAEwRAmGwICELF;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] pA7XDrFTOMl(global::System.ReadOnlySpan<byte> encrypted)
	{
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		RSA val = default(RSA);
		int num3 = default(int);
		int num5 = default(int);
		RSAParameters val2 = default(RSAParameters);
		byte[] result = default(byte[]);
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
					goto case 0;
				case 0:
					try
					{
						(val).ImportSubjectPublicKeyInfo(((global::System.ReadOnlySpan<byte>)System.Convert.FromBase64String("MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEA4HJFrYdVTeoSvH6qsnJElfXuf7FnxxFQdz3gRCs66LDrZfaoGoWt2e/aGIOv8uGHliBWnZP42Ike9Qf5aiYVtQ4mlj2bXZjifHG35LlS1Bq6yCA6k1WevWcrGWOuLzny3jo8Wbdi0lIFMTT2hN98sF2k4YcvyE9zhqxfRNFGVI5kLyxm9CeTKAXGBU5mw3yQWJ8cPRR4866jpGGOhBWlJdilWt2NES9bid8SbhTT55wqumnVO5J5/DaMyTgKIQngH7NyZQljAhdK5I23dzpGop322n2eQ+mTNLuquwU453o1cbyQobgC6vh5/F1QT2INBR2qYCnRzzJ6hrhE5kIMZwIDAQAB")), out num3);
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num5 == 990)
								{
									num4 = num5;
									continue;
								}
								break;
							case 0:
								val2 = (val).ExportParameters(false);
								num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							case 2:
								goto end_IL_009f;
							}
							result = e7DXDoECLqy(encrypted, val2.Exponent, val2.Modulus);
							num4 = 2;
							continue;
							end_IL_009f:
							break;
						}
					}
					finally
					{
						int num6;
						if (val == null)
						{
							num6 = 2;
							goto IL_0139;
						}
						goto IL_0181;
						IL_0181:
						(val).Dispose();
						num6 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							num6 = 1;
						}
						goto IL_0139;
						IL_0139:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0135;
								}
								goto end_IL_0139;
							case 2:
								goto end_IL_0139;
							case 0:
								break;
							case 1:
								goto end_IL_0139;
							}
							goto IL_0181;
							IL_0135:
							num6 = num7;
							continue;
							end_IL_0139:
							break;
						}
					}
					break;
				case 1:
					val = System.Security.Cryptography.RSA.Create();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] e7DXDoECLqy(global::System.ReadOnlySpan<byte> input, object exponentBytes, object modulusBytes)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] Pl4XDma3csr(global::System.ReadOnlySpan<byte> block)
	{
		int num = MemoryExtensions.IndexOf<byte>(block.Slice(2), (byte)0);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] fErXD7sn4c6(BigInteger value, int length)
	{
		byte[] array = (value).ToByteArray(true, true);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool L2o0b0ZA2LmivE99n1vN()
	{
		return sln6V0ZAEwRAmGwICELF == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FnFZ0JXDhnBu5q3PFAJL qvlui9ZAqpWLIEw9kf3B()
	{
		return (FnFZ0JXDhnBu5q3PFAJL)sln6V0ZAEwRAmGwICELF;
	}
}

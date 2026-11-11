using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using fDAldojjppXrctUVYOJn;

namespace r8IBAqfWmsX5Q657ItyO;

internal sealed class sh6KmlfWoQNMIWAdC2mj
{
	private readonly object KxZfWtSDm6G;

	private readonly object V7pfWOy0yfC;

	private readonly object YKLfW5Io0Kh;

	private int BpIfW6ZVtvs;

	[CompilerGenerated]
	private readonly byte[] FCrfWRaMsPa;

	internal static object ItoKTLZu9cUvcoL147qS;

	public byte[] SessionKey
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return FCrfWRaMsPa;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private sh6KmlfWoQNMIWAdC2mj(byte[] key32)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public byte mWZfW7BvDyS(byte value)
	{
		UhyfWgKsMmj();
		return default(byte);
	}

	[MethodImpl((MethodImplOptions)8)]
	public byte[] LmMfWAahyIv(global::System.ReadOnlySpan<byte> input)
	{
		byte[] array = default(byte[]);
		DvTfWItaF1Q(input, default(global::System.Span<byte>));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe void DvTfWItaF1Q(global::System.ReadOnlySpan<byte> input, global::System.Span<byte> output)
	{
		//IL_001a: Expected F4, but got I4
		int num = default(int);
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref output[num]) = (int)mWZfW7BvDyS((byte)(*(short*)input[num]));
	}

	[MethodImpl((MethodImplOptions)8)]
	public static ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj> NKnfWBJAuLZ(object key32)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		return new ValueTuple<sh6KmlfWoQNMIWAdC2mj, sh6KmlfWoQNMIWAdC2mj>((sh6KmlfWoQNMIWAdC2mj)new sh6KmlfWoQNMIWAdC2mj((byte[])key32), (sh6KmlfWoQNMIWAdC2mj)new sh6KmlfWoQNMIWAdC2mj((byte[])key32));
	}

	[MethodImpl((MethodImplOptions)8)]
	private void UhyfWgKsMmj()
	{
		BpIfW6ZVtvs = 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void CjufWlEraNd()
	{
		//IL_0017: Expected F4, but got I4
		int num = default(int);
		ref byte reference = ref ((byte[])V7pfWOy0yfC)[num];
		byte b = (byte)(global::System.Runtime.CompilerServices.Unsafe.As<byte, short>(ref reference) + 1);
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref reference) = (int)b;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] I7dfWdVAwuj(object localKey, object remoteSpkiDer, object saltBytes)
	{
		return F7MfWKTnB7I(localKey, remoteSpkiDer, saltBytes, reverseSecret: false, secretFirst: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static byte[] F7MfWKTnB7I(object localKey, object remoteSpkiDer, object saltBytes, bool reverseSecret, bool secretFirst)
	{
		int num = 1;
		byte[] result = default(byte[]);
		ECDiffieHellman val = default(ECDiffieHellman);
		int num3 = default(int);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num8 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
					return result;
				case 1:
					break;
				case 0:
					try
					{
						(val).ImportSubjectPublicKeyInfo(((global::System.ReadOnlySpan<byte>)(byte[])remoteSpkiDer), out num3);
						int num4 = 11;
						while (true)
						{
							IL_008b:
							int num5 = num4;
							while (true)
							{
								IL_008f:
								int num6 = num5;
								while (true)
								{
									switch (num6)
									{
									default:
										if (num5 != 19)
										{
											if (num5 == 999)
											{
												break;
											}
											goto end_IL_008f;
										}
										if (reverseSecret)
										{
											num6 = 9;
											continue;
										}
										goto case 4;
									case 3:
										System.Buffer.BlockCopy((global::System.Array)saltBytes, 0, array, array2.Length, ((global::System.Array)saltBytes).Length);
										num6 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num6 = 0;
										}
										continue;
									case 5:
									case 8:
										System.Buffer.BlockCopy((global::System.Array)saltBytes, 0, array, 0, ((global::System.Array)saltBytes).Length);
										num6 = 6;
										continue;
									case 6:
										System.Buffer.BlockCopy(array2, 0, array, ((global::System.Array)saltBytes).Length, array2.Length);
										num6 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
										{
											num6 = 9;
										}
										continue;
									case 1:
										if (!secretFirst)
										{
											num6 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
											{
												num6 = 8;
											}
											continue;
										}
										goto case 7;
									case 4:
										array = new byte[((global::System.Array)saltBytes).Length + array2.Length];
										num6 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num6 = 1;
										}
										continue;
									case 7:
										System.Buffer.BlockCopy(array2, 0, array, 0, array2.Length);
										num6 = 3;
										continue;
									case 9:
										global::System.Array.Reverse<byte>(array2);
										num6 = 4;
										continue;
									case 11:
										goto end_IL_0093;
									case 0:
									case 10:
										result = System.Security.Cryptography.SHA256.HashData(array);
										num6 = 2;
										continue;
									case 2:
										goto end_IL_008f;
									}
									goto IL_008f;
									continue;
									end_IL_0093:
									break;
								}
								array2 = ((dynamic)(localKey)).DeriveRawSecretAgreement((val).PublicKey);
								num4 = 19;
								goto IL_008b;
								continue;
								end_IL_008f:
								break;
							}
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								num7 = 6;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0297;
								}
								(val).Dispose();
								num7 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
								{
									num7 = 0;
								}
								continue;
								end_IL_0297:
								break;
							}
						}
					}
					goto case 2;
				}
				goto IL_0037;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0037;
				IL_0037:
				val = System.Security.Cryptography.ECDiffieHellman.Create();
				num2 = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
				{
					num2 = 0;
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
	internal static bool lKUGrMZuDJHXI228IysZ()
	{
		return ItoKTLZu9cUvcoL147qS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sh6KmlfWoQNMIWAdC2mj HheMYWZukewE8jlarcD3()
	{
		return (sh6KmlfWoQNMIWAdC2mj)ItoKTLZu9cUvcoL147qS;
	}
}

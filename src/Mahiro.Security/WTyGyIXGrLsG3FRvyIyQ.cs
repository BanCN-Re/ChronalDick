using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace FIvg7fXGol9r92PwaO9r;

internal class WTyGyIXGrLsG3FRvyIyQ
{
	private static readonly byte[][] qUTXGdsTpeR;

	private static object bI9w9FZxiH7EQjqONllK;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] kerXGmCFm6F(global::System.ReadOnlySpan<byte> plaintext)
	{
		byte[] array = default(byte[]);
		plaintext.CopyTo(default(global::System.Span<byte>));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] id4XG7RiJH6(global::System.ReadOnlySpan<byte> body)
	{
		byte[] array = default(byte[]);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] UJBXGAZqsb1(global::System.ReadOnlySpan<byte> body)
	{
		byte[] array = RBKXGBxoXuH(body);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] XVYXGIrEswH(global::System.ReadOnlySpan<byte> body)
	{
		return RBKXGBxoXuH(body);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] RBKXGBxoXuH(global::System.ReadOnlySpan<byte> body)
	{
		global::System.ReadOnlySpan<byte> reference = default;
		global::System.ReadOnlySpan<byte> readOnlySpan = reference.Slice(16, reference.Length - 1 - 16);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] HhpXGgn3eto(object key, object initializationVector, object input, bool encrypt)
	{
		int num = 2;
		Aes val = default(Aes);
		int num8 = default(int);
		byte[] result = default(byte[]);
		ICryptoTransform val2 = default(ICryptoTransform);
		int num5 = default(int);
		int num7 = default(int);
		int num10 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					try
					{
						(val).Key = (byte[])key;
						int num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							ICryptoTransform obj;
							switch (num3)
							{
							default:
								if (num8 != 12)
								{
									if (num8 == 992)
									{
										goto IL_006f;
									}
									goto case 3;
								}
								if (!encrypt)
								{
									num3 = 3;
									continue;
								}
								obj = (val).CreateEncryptor();
								goto IL_0139;
							case 3:
								obj = (val).CreateDecryptor();
								goto IL_0139;
							case 4:
								(val).Mode = (CipherMode)1;
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
								{
									num3 = 3;
								}
								continue;
							case 1:
								(val).IV = (byte[])initializationVector;
								num3 = 4;
								continue;
							case 2:
								(val).Padding = (PaddingMode)1;
								num8 = 12;
								goto IL_006f;
							case 0:
								{
									try
									{
										result = (val2).TransformFinalBlock((byte[])input, 0, ((global::System.Array)input).Length);
										int num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num4 = 1;
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
									finally
									{
										if (val2 != null)
										{
											int num6 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													if (num7 == 989)
													{
														num6 = num7;
														continue;
													}
													break;
												case 0:
													(val2).Dispose();
													num6 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
													{
														num6 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									break;
								}
								IL_006f:
								num3 = num8;
								continue;
								IL_0139:
								val2 = obj;
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
					}
					finally
					{
						int num9;
						if (val == null)
						{
							num9 = 2;
							goto IL_0267;
						}
						goto IL_028b;
						IL_028b:
						(val).Dispose();
						num9 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
						{
							num9 = 0;
						}
						goto IL_0267;
						IL_0267:
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 == 990)
								{
									goto IL_0263;
								}
								goto end_IL_0267;
							case 1:
								break;
							case 2:
								goto end_IL_0267;
							case 0:
								goto end_IL_0267;
							}
							goto IL_028b;
							IL_0263:
							num9 = num10;
							continue;
							end_IL_0267:
							break;
						}
					}
					goto case 0;
				case 0:
					return result;
				case 2:
					break;
				}
				goto IL_02fd;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_02fd;
				IL_02fd:
				val = System.Security.Cryptography.Aes.Create();
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
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
	internal static bool hp3JwyZxnDHJpE2dOVsP()
	{
		return bI9w9FZxiH7EQjqONllK == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static WTyGyIXGrLsG3FRvyIyQ BhGSTdZxzL6HD8voCo7c()
	{
		return (WTyGyIXGrLsG3FRvyIyQ)bI9w9FZxiH7EQjqONllK;
	}
}

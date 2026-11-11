using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace eS51BbfcxSK58TdIFX0F;

internal class sy3VFbfcPwrx2pkHA5rj
{
	private static readonly object O5lfcp1OMHG;

	private static readonly object hEKfcuIyILj;

	private static object R1BAO6ZpSq7xjSM1kb1u;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] aqwfcFt3lmM(global::System.ReadOnlySpan<byte> plaintext)
	{
		byte[] array = new byte[checked((int)System.Math.Ceiling((double)(plaintext.Length + 16) / 16.0) * 16)];
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] jIffcsHn8DF(global::System.ReadOnlySpan<byte> body)
	{
		global::System.ReadOnlySpan<byte> reference = default;
		global::System.ReadOnlySpan<byte> readOnlySpan = reference.Slice(16, reference.Length - 1 - 16);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] wiefcT3u5Xk(object key, object initializationVector, object input, bool encrypt)
	{
		int num = 1;
		Aes val = default(Aes);
		int num4 = default(int);
		byte[] result = default(byte[]);
		ICryptoTransform val2 = default(ICryptoTransform);
		int num6 = default(int);
		int num8 = default(int);
		int num10 = default(int);
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
						(val).Key = (byte[])key;
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							ICryptoTransform obj;
							switch (num3)
							{
							default:
								if (num4 != 13)
								{
									if (num4 == 993)
									{
										goto IL_006f;
									}
									goto case 2;
								}
								try
								{
									result = (val2).TransformFinalBlock((byte[])input, 0, ((global::System.Array)input).Length);
									int num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
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
								finally
								{
									if (val2 != null)
									{
										int num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num7 = 1;
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
												(val2).Dispose();
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
												{
													num7 = 7;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto end_IL_0073;
							case 3:
								obj = (val).CreateDecryptor();
								goto IL_0176;
							case 5:
								(val).Mode = (CipherMode)1;
								num3 = 4;
								break;
							case 4:
								(val).Padding = (PaddingMode)1;
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
								{
									num3 = 1;
								}
								break;
							case 2:
								(val).IV = (byte[])initializationVector;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
								{
									num3 = 5;
								}
								break;
							case 1:
								if (encrypt)
								{
									num3 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num3 = 0;
									}
									break;
								}
								goto case 3;
							case 0:
								{
									obj = (val).CreateEncryptor();
									goto IL_0176;
								}
								IL_006f:
								num3 = num4;
								break;
								IL_0176:
								val2 = obj;
								num4 = 13;
								goto IL_006f;
							}
							continue;
							end_IL_0073:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num9 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 989)
									{
										num9 = num10;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_02a4;
								}
								(val).Dispose();
								num9 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
								{
									num9 = 0;
								}
								continue;
								end_IL_02a4:
								break;
							}
						}
					}
					goto case 2;
				case 2:
					return result;
				case 1:
					val = System.Security.Cryptography.Aes.Create();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
					{
						num2 = 7;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] J09fcNP5QJS(int length)
	{
		int num = 0;
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
	internal static bool E5yRMIZpcIaFIBQCIK3o()
	{
		return R1BAO6ZpSq7xjSM1kb1u == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sy3VFbfcPwrx2pkHA5rj rh6W0fZp0RkqMqwok4MM()
	{
		return (sy3VFbfcPwrx2pkHA5rj)R1BAO6ZpSq7xjSM1kb1u;
	}
}

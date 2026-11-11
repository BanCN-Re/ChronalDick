using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using iM65eRXiKVWZgs63pZCd;
using ibqOI7fwdAZ7fB5vumc9;

namespace FIvg7fXGol9r92PwaO9r;

internal class WTyGyIXGrLsG3FRvyIyQ
{
	private static byte[][] qUTXGdsTpeR;

	private static object bI9w9FZxiH7EQjqONllK;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] kerXGmCFm6F(global::System.ReadOnlySpan<byte> plaintext)
	{
		int num = System.Security.Cryptography.RandomNumberGenerator.GetInt32(15);
		_ = 22;
		byte[] array = default(byte[]);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] id4XG7RiJH6(global::System.ReadOnlySpan<byte> body)
	{
		//IL_000f: Expected O, but got I4
		//IL_000f: Expected O, but got I4
		byte[] array = default(byte[]);
		global::System.Span<byte> span = (global::System.Span<byte>)JsonContent.Create<YHY2llfwl8ExTrwU63sb>((YHY2llfwl8ExTrwU63sb)(object)array, (MediaTypeHeaderValue)(object)0, (JsonSerializerOptions)(object)(array.Length - 112));
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726;
		_ = 9;
		array = RBKXGBxoXuH(body);
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3;
		_ = 1;
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
		_ = 4;
		_ = span;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] UJBXGAZqsb1(global::System.ReadOnlySpan<byte> body)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] XVYXGIrEswH(global::System.ReadOnlySpan<byte> body)
	{
		return RBKXGBxoXuH(body);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static byte[] RBKXGBxoXuH(global::System.ReadOnlySpan<byte> body)
	{
		//IL_004b: Expected O, but got Ref
		_ = 10;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3;
		_ = 7;
		_ = 16;
		_ = 17;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209;
		_ = 29;
		_ = 4;
		byte[] array = default(byte[]);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		return (byte[])(&span);
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
		int num = 2;
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						qUTXGdsTpeR = (byte[][])(object)new IEquatable<bjsovlXid1IZ1bYL6Xwl>[16]
						{
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("60F1E0D1FD635362430747215CF1C2FF"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("EA5B62D27D0338374852C4B9469D7AC6"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("17238D55501C5F020B155FB3303591E6"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("8C5CEAE0F443E006A050266F73ADD5B0"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("1C02CE22FB22F0E72060217418F351F3"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("9A01773FEBB0CFE0EBDBF37F4D23C27F"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("43F32300BF252CC320E2572ACE766367"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("07F161011B3101F1ED0301735631E734"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("0454E7707A5F37565601E100406060AF"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("647554BAD3100C43C16660F002CC10F3"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("E157213170F842382032564265B0B043"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("914FC59311B04151393EF6896A847636"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("0710C0205D224237025323265C145FA1"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("054E6F01165267025C3111F562A921E9"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("722D1789E792E2CA0D5322211FD0F5AE"),
							(IEquatable<bjsovlXid1IZ1bYL6Xwl>)(object)System.Convert.FromHexString("91F7C751FCF671F34943430772341799")
						};
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						break;
					case 4:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
						{
							num3 = 4;
						}
						continue;
					case 2:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						return;
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
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
			{
				num = 11;
			}
		}
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

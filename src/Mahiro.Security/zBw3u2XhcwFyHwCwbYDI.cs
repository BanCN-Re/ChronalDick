using System;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using BCXoLCXUvJyBkqc6IRk2;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using K48WkOXrQUD3xl2yuwa3;
using fDAldojjppXrctUVYOJn;

namespace BjcLBlXh09xdCwZktJfV;

sealed class zBw3u2XhcwFyHwCwbYDI : global::System.IDisposable
{
	private byte[]? RayXhJF3o2l;

	[CompilerGenerated]
	private readonly string itjXhQGLrFU;

	[CompilerGenerated]
	private readonly bool uC7XhCe0H6i;

	[CompilerGenerated]
	private readonly qAftL0XU3M5I1RIneNTc qmYXh4mUXvX;

	internal static object Yy1bj0ZKEu8yCKIqcpmT;

	internal string ServerHash
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return itjXhQGLrFU;
		}
	}

	internal bool ShouldAuthenticate
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return uC7XhCe0H6i;
		}
	}

	internal qAftL0XU3M5I1RIneNTc Response
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return qmYXh4mUXvX;
		}
	}

	internal global::System.ReadOnlySpan<byte> Secret
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return default(global::System.ReadOnlySpan<byte>);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private zBw3u2XhcwFyHwCwbYDI(string serverHash, bool shouldAuthenticate, qAftL0XU3M5I1RIneNTc response, byte[] secret)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static zBw3u2XhcwFyHwCwbYDI DVcXh84mYdw(object request, int protocolVersion)
	{
		//IL_07d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0795: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Unknown result type (might be due to invalid IL or missing references)
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		int num = 16;
		bool shouldAuthenticate = default(bool);
		int offset = default(int);
		byte[] array2 = default(byte[]);
		byte[] array5 = default(byte[]);
		bool unsignedShortLength = default(bool);
		zBw3u2XhcwFyHwCwbYDI result = default(zBw3u2XhcwFyHwCwbYDI);
		string serverId = default(string);
		int num5 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		MemoryStream val2 = default(MemoryStream);
		byte[] array3 = default(byte[]);
		int num10 = default(int);
		byte[] array4 = default(byte[]);
		byte[] array = default(byte[]);
		int num12 = default(int);
		int num14 = default(int);
		int num18 = default(int);
		int num16 = default(int);
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
						if (num2 != 26)
						{
							if (num2 == 1007)
							{
								goto end_IL_0010;
							}
							goto case 12;
						}
						if (protocolVersion >= 766)
						{
							num3 = 18;
							continue;
						}
						goto case 4;
					case 19:
						shouldAuthenticate = true;
						num = 26;
						break;
					case 18:
						if (offset >= ((qAftL0XU3M5I1RIneNTc)request).Payload.Length)
						{
							num = 14;
							break;
						}
						goto case 2;
					case 6:
						if (array2.Length < 64)
						{
							num3 = 8;
							continue;
						}
						goto case 0;
					case 5:
						array5 = LDmKkaXrJsoQ9MJDZJvB.ifLXrUXXxL7(((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)request).Payload), ref offset, unsignedShortLength, 1024);
						num = 19;
						break;
					case 16:
						System.ArgumentNullException.ThrowIfNull(request, "request");
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num3 = 4;
						}
						continue;
					case 9:
						return result;
					case 12:
						throw new InvalidDataException("Minecraft 加密请求编号无效");
					case 2:
						if (((qAftL0XU3M5I1RIneNTc)request).Payload[offset] > 1)
						{
							num3 = 11;
							continue;
						}
						shouldAuthenticate = ((qAftL0XU3M5I1RIneNTc)request).Payload[offset++] != 0;
						num3 = 4;
						continue;
					case 4:
						if (offset == ((qAftL0XU3M5I1RIneNTc)request).Payload.Length)
						{
							num3 = 6;
							continue;
						}
						goto case 7;
					case 17:
						serverId = LDmKkaXrJsoQ9MJDZJvB.nTbXr4FpagV(((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)request).Payload), ref offset);
						num3 = 10;
						continue;
					case 15:
						if (((qAftL0XU3M5I1RIneNTc)request).Id == 1)
						{
							offset = 0;
							num3 = 17;
						}
						else
						{
							num3 = 12;
						}
						continue;
					case 3:
						array2 = LDmKkaXrJsoQ9MJDZJvB.ifLXrUXXxL7(((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)request).Payload), ref offset, unsignedShortLength);
						num3 = 5;
						continue;
					case 0:
						if (array5.Length != 0)
						{
							num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 7;
					case 13:
						try
						{
							RSA val = System.Security.Cryptography.RSA.Create();
							int num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
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
										goto IL_02d6;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_02d6:
								num4 = num5;
							}
							try
							{
								(val).ImportSubjectPublicKeyInfo(default(global::System.ReadOnlySpan<byte>), out num6);
								int num7 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										if (num8 != 11)
										{
											if (num8 == 991)
											{
												goto IL_0339;
											}
											goto case 0;
										}
										try
										{
											LDmKkaXrJsoQ9MJDZJvB.F8lXr7sRNtg((Stream)(object)val2, default(global::System.ReadOnlySpan<byte>), unsignedShortLength);
											int num9 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
											{
												num9 = 1;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													if (num10 == 990)
													{
														num9 = num10;
														continue;
													}
													break;
												case 2:
													LDmKkaXrJsoQ9MJDZJvB.F8lXr7sRNtg((Stream)(object)val2, default(global::System.ReadOnlySpan<byte>), unsignedShortLength);
													num9 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
													{
														num9 = 5;
													}
													continue;
												case 0:
													break;
												case 1:
													goto end_IL_0484;
												}
												result = (zBw3u2XhcwFyHwCwbYDI)new zBw3u2XhcwFyHwCwbYDI(cANXhycUGAS(serverId, default(global::System.ReadOnlySpan<byte>), default(global::System.ReadOnlySpan<byte>)), shouldAuthenticate, (qAftL0XU3M5I1RIneNTc)new qAftL0XU3M5I1RIneNTc(1, (val2).ToArray()), array);
												num9 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
												{
													num9 = 5;
												}
												continue;
												end_IL_0484:
												break;
											}
										}
										finally
										{
											if (val2 != null)
											{
												int num11 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
												{
													num11 = 2;
												}
												while (true)
												{
													switch (num11)
													{
													default:
														if (num12 == 989)
														{
															num11 = num12;
															continue;
														}
														break;
													case 0:
														(val2).Dispose();
														num11 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
														{
															num11 = 6;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_033d;
									case 2:
										val2 = new MemoryStream();
										num8 = 11;
										goto IL_0339;
									case 3:
										array4 = (val).Encrypt(array5, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
										num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
										{
											num7 = 2;
										}
										break;
									case 1:
										if (num6 != array2.Length)
										{
											num7 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
											{
												num7 = 10;
											}
											break;
										}
										array3 = (val).Encrypt(array, System.Security.Cryptography.RSAEncryptionPadding.Pkcs1);
										num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
										{
											num7 = 3;
										}
										break;
									case 0:
										{
											throw new CryptographicException("Minecraft 服务器公钥包含多余数据");
										}
										IL_0339:
										num7 = num8;
										break;
									}
									continue;
									end_IL_033d:
									break;
								}
							}
							finally
							{
								int num13;
								if (val == null)
								{
									num13 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
									{
										num13 = 0;
									}
									goto IL_05e9;
								}
								goto IL_0631;
								IL_05e9:
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 990)
										{
											goto IL_05e5;
										}
										break;
									case 0:
										goto end_IL_05e9;
									case 1:
										break;
									case 2:
										goto end_IL_05e9;
									}
									goto IL_0631;
									IL_05e5:
									num13 = num14;
									continue;
									end_IL_05e9:
									break;
								}
								goto end_IL_05b1;
								IL_0631:
								(val).Dispose();
								num13 = 2;
								goto IL_05e9;
								end_IL_05b1:;
							}
						}
						catch
						{
							int num15 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
							{
								num15 = 1;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 == 989)
									{
										num15 = num16;
										break;
									}
									goto case 0;
								case 0:
									System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
									num15 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
									{
										num15 = 0;
									}
									break;
								case 1:
									throw;
								}
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num17 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
							{
								num17 = 0;
							}
							while (true)
							{
								switch (num17)
								{
								default:
									if (num18 == 989)
									{
										num17 = num18;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_070e;
								}
								System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
								num17 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
								{
									num17 = 5;
								}
								continue;
								end_IL_070e:
								break;
							}
						}
						goto case 9;
					case 10:
						unsignedShortLength = protocolVersion == 5;
						num3 = 3;
						continue;
					case 11:
					case 14:
						throw new InvalidDataException("Minecraft 加密请求认证标志无效");
					case 7:
					case 8:
						throw new InvalidDataException("Minecraft 加密请求内容无效");
					case 1:
						array = System.Security.Cryptography.RandomNumberGenerator.GetBytes(16);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 13;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string cANXhycUGAS(string serverId, global::System.ReadOnlySpan<byte> secret, global::System.ReadOnlySpan<byte> publicKey)
	{
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		BigInteger val2 = default(BigInteger);
		string text4 = default(string);
		string result = default(string);
		string text3 = default(string);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						secret.CopyTo(MemoryExtensions.AsSpan<byte>(array, array2.Length));
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
						array2 = (System.Text.Encoding.Latin1).GetBytes(serverId);
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
						{
							num3 = 3;
						}
						continue;
					case 6:
						try
						{
							byte[] array3 = System.Security.Cryptography.SHA1.HashData(array);
							int num4 = 5;
							while (true)
							{
								string text2;
								int num5;
								switch (num4)
								{
								default:
									if (num6 != 17)
									{
										if (num6 == 997)
										{
											goto IL_00e0;
										}
										goto case 5;
									}
									if ((val2).Sign < 0)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
										{
											num4 = 8;
										}
										continue;
									}
									goto case 0;
								case 6:
									text4 = "0";
									num4 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
									{
										num4 = 17;
									}
									continue;
								case 7:
								case 9:
									result = text4;
									num4 = 4;
									continue;
								case 1:
									if ((text3 == ""))
									{
										num4 = 6;
										continue;
									}
									goto case 3;
								case 5:
									global::System.Array.Reverse<byte>(array3);
									num4 = 2;
									continue;
								case 0:
									text2 = (val2).ToString("x");
									break;
								case 2:
									val2 = new BigInteger(array3);
									num5 = 17;
									goto IL_00dc;
								case 3:
									text4 = text3;
									num5 = 7;
									goto IL_00dc;
								case 8:
								{
									string text = "-";
									BigInteger val = System.Numerics.BigInteger.Abs(val2);
									text2 = string.Concat(text, (val).ToString("x"));
									break;
								}
								case 4:
									goto end_IL_00e4;
									IL_00dc:
									num6 = num5;
									goto IL_00e0;
									IL_00e0:
									num4 = num6;
									continue;
								}
								text3 = (text2).TrimStart('0');
								num4 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
								{
									num4 = 1;
								}
								continue;
								end_IL_00e4:
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num7 = 5;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 4;
					case 5:
						publicKey.CopyTo(MemoryExtensions.AsSpan<byte>(array, array2.Length + secret.Length));
						num3 = 6;
						continue;
					case 1:
						System.ArgumentNullException.ThrowIfNull(serverId, "serverId");
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						array = new byte[checked(array2.Length + secret.Length + publicKey.Length)];
						num3 = 2;
						continue;
					case 2:
						break;
					case 4:
						return result;
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
			(array2).CopyTo(array, 0);
			num = 13;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		byte[] array = default(byte[]);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BYWc1uZK2RvrvSrTCM1I()
	{
		return Yy1bj0ZKEu8yCKIqcpmT == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static zBw3u2XhcwFyHwCwbYDI JN7VyrZKqA9GCAhTxynP()
	{
		return (zBw3u2XhcwFyHwCwbYDI)Yy1bj0ZKEu8yCKIqcpmT;
	}
}

using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace suLfX1XvfmmhveItvMW2;

internal class fdPhTKXvXpBq5gSgOVDb
{
	internal static object nvNFwAZPHdVZJmjHir28;

	[MethodImpl((MethodImplOptions)8)]
	internal static string nhNXvLKvCCu(object sessionToken)
	{
		//IL_037b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		byte[] array = default(byte[]);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		string result = default(string);
		int num9 = default(int);
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
				case 1:
					array = null;
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 0:
					try
					{
						string text = xPpXvZW1EA5((string?)sessionToken);
						int num3 = 9;
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 22)
								{
									if (num5 != 1002)
									{
										break;
									}
									goto IL_007b;
								}
								if ((text == "hex32"))
								{
									num4 = 4;
									goto IL_0077;
								}
								goto case 5;
							case 6:
							case 11:
								array2 = System.Convert.FromBase64String((string)sessionToken);
								num3 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
							case 4:
								array2 = System.Convert.FromHexString((string)sessionToken);
								num3 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
								{
									num3 = 17;
								}
								continue;
							case 3:
							case 12:
								throw new FormatException();
							case 1:
							case 13:
							case 14:
								array = array2;
								num3 = 7;
								continue;
							case 9:
								if (!(text == "ascii16"))
								{
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
									{
										num4 = 22;
									}
									goto IL_0077;
								}
								goto case 10;
							case 5:
								if ((text == "base64"))
								{
									num3 = 6;
									continue;
								}
								goto case 3;
							case 2:
								throw new FormatException();
							case 10:
								array2 = (System.Text.Encoding.ASCII).GetBytes((string)sessionToken);
								num3 = 14;
								continue;
							case 7:
								break;
							case 8:
								goto end_IL_007f;
								IL_007b:
								num3 = num5;
								continue;
								IL_0077:
								num5 = num4;
								goto IL_007b;
							}
							if (array.Length == 16)
							{
								result = System.Convert.ToBase64String(array);
								num3 = 8;
								continue;
							}
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num3 = 11;
							}
							continue;
							end_IL_007f:
							break;
						}
					}
					catch (FormatException)
					{
						int num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
						{
							num6 = 3;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									goto IL_0340;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0340:
							num6 = num7;
						}
						throw new InvalidOperationException("基岩公共房间启动凭据编码不受支持，请查看诊断日志");
					}
					finally
					{
						int num8;
						if (array == null)
						{
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
							{
								num8 = 0;
							}
							goto IL_03b9;
						}
						goto IL_03dd;
						IL_03b9:
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 == 990)
								{
									goto IL_03b5;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_03b9;
							case 2:
								goto end_IL_03b9;
							}
							goto IL_03dd;
							IL_03b5:
							num8 = num9;
							continue;
							end_IL_03b9:
							break;
						}
						goto end_IL_0381;
						IL_03dd:
						System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
						num8 = 2;
						goto IL_03b9;
						end_IL_0381:;
					}
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
	internal static string jmIXvj7SYii(string? sessionToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string xPpXvZW1EA5(string? value)
	{
		int num = 19;
		char c = default(char);
		string text = default(string);
		int num4 = default(int);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		bool flag = default(bool);
		int num5 = default(int);
		int num8 = default(int);
		int num10 = default(int);
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
						if (num2 != 35)
						{
							if (num2 == 1016)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						return "ascii16";
					case 3:
					case 14:
						c = ((dynamic)(text)).Chars;
						num3 = 2;
						break;
					case 4:
						return "unsupported";
					case 11:
						if ((value).Length == 16)
						{
							goto end_IL_000c;
						}
						if ((value).Length == 32)
						{
							num3 = 23;
							break;
						}
						if ((value).Length == 24)
						{
							num3 = 9;
							break;
						}
						goto case 4;
					case 1:
						num4 = 0;
						num3 = 8;
						break;
					case 17:
						span = new byte[16];
						num3 = 20;
						break;
					case 12:
					case 28:
						if (num4 < (text).Length)
						{
							num3 = 3;
							break;
						}
						goto case 11;
					case 0:
					case 16:
						if (flag)
						{
							num3 = 21;
							break;
						}
						num4++;
						num3 = 28;
						break;
					case 15:
						return "empty";
					case 18:
						text = value;
						num3 = 25;
						break;
					case 24:
						return "unsupported";
					case 7:
						num4++;
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num3 = 27;
						}
						break;
					case 8:
					case 27:
						if (num4 >= (text).Length)
						{
							num3 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
							{
								num3 = 5;
							}
							break;
						}
						goto case 22;
					case 10:
					case 26:
						flag = false;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 23;
						}
						break;
					case 20:
						try
						{
							if (System.Convert.TryFromBase64String(value, span, out num5))
							{
								int num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num6 = 5;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num8 == 11)
										{
											return text;
										}
										if (num8 == 991)
										{
											goto IL_02c4;
										}
										goto case 3;
									case 1:
										if (num5 == 16)
										{
											num6 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num6 = 0;
											}
											continue;
										}
										break;
									case 0:
										if ((System.Convert.ToBase64String(span, (Base64FormattingOptions)0) == value))
										{
											num6 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
											{
												num6 = 9;
											}
											continue;
										}
										break;
									case 3:
									{
										text = "base64";
										int num7 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num7 = 10;
										}
										num8 = num7;
										goto IL_02c4;
									}
									case 2:
										break;
										IL_02c4:
										num6 = num8;
										continue;
									}
									break;
								}
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(span);
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
							{
								num9 = 3;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 988)
									{
										num9 = num10;
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
					case 25:
						num4 = 0;
						num3 = 12;
						break;
					case 9:
						if ((value).EndsWith("==", (StringComparison)4))
						{
							num3 = 17;
							break;
						}
						goto case 4;
					case 19:
						if (!string.IsNullOrEmpty(value))
						{
							num3 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num3 = 18;
							}
							break;
						}
						goto case 15;
					case 5:
						return "hex32";
					case 23:
						text = value;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 26;
						}
						break;
					case 6:
						if (c <= '~')
						{
							num3 = 26;
							break;
						}
						goto case 13;
					case 13:
						flag = true;
						num3 = 16;
						break;
					case 22:
						if (System.Uri.IsHexDigit(((dynamic)(text)).Chars))
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 17;
							}
							break;
						}
						goto case 24;
					case 21:
						return "unsupported";
					case 2:
						if (c >= '!')
						{
							num3 = 6;
							break;
						}
						goto case 13;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 35;
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
	internal static bool cQCOflZPtBMBv3AvkArU()
	{
		return nvNFwAZPHdVZJmjHir28 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static fdPhTKXvXpBq5gSgOVDb RJWANuZPOvvNRsLlIq8f()
	{
		return (fdPhTKXvXpBq5gSgOVDb)nvNFwAZPHdVZJmjHir28;
	}
}

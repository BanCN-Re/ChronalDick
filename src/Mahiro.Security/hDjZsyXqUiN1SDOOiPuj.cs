using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using BqKL3wffhEPrvBS3U8BK;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using KiaSgnXtR0buq3Xh1g8j;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using kv4rFCXt5vWpEP7klgZ0;
using pP8gJUXq52Ip5dHhgodd;

namespace sjGx70Xqrvb4N3a6V79Z;

internal class hDjZsyXqUiN1SDOOiPuj
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_67
	{
		public static readonly __c_67 __9;

		public static Func<string, bool> __9__4_0;

		private static __c_67 Tcvor6DkzqQjIfGQXqQ0;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_67()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool wtALkqooT3r(string _)
		{
			return false;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool eeYDJODVbraMZj1bu4Zp()
		{
			return Tcvor6DkzqQjIfGQXqQ0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_67 YDj8qIDVXAjNnNLLeaQW()
		{
			return Tcvor6DkzqQjIfGQXqQ0;
		}
	}

	private static readonly object M5eXqI60RTq;

	private static object Pfb9RVZx6jC3xpcT5CJj;

	[MethodImpl((MethodImplOptions)8)]
	internal static string BnkXqo24Y7Y(object directory, object payload)
	{
		return System.IO.Path.Combine((string)directory, string.Concat(".chronal-owned-", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName, ".sha256"));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Release(object directory, object payload, Action<string>? log)
	{
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		string text = default(string);
		string text2 = default(string);
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		YtPZc0ff4HhtXJ66KDeo ytPZc0ff4HhtXJ66KDeo = default(YtPZc0ff4HhtXJ66KDeo);
		bool result = default(bool);
		int num11 = default(int);
		int num13 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
		global::System.Exception ex = default(global::System.Exception);
		int num15 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num16);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num18 = default(int);
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
							goto case 5;
						}
						if (!System.IO.File.Exists(text))
						{
							num3 = 10;
							continue;
						}
						goto case 7;
					case 11:
						if (!System.IO.File.Exists(text2))
						{
							break;
						}
						goto case 6;
					case 1:
						try
						{
							FileStream val = new FileStream(text, (FileMode)1, (FileAccess)2, (FileShare)0, 4096, (FileOptions)(-2147483648));
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num4 = 6;
							}
							while (true)
							{
								switch (num4)
								{
								default:
								{
									if (num5 != 13)
									{
										if (num5 == 993)
										{
											goto IL_00e9;
										}
										goto case 4;
									}
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(94, 3);
									(defaultInterpolatedStringHandler).AppendLiteral("file released file=");
									(defaultInterpolatedStringHandler).AppendFormatted(((KYxDNCXqOpQF3JF9F6k2)payload).FileName);
									(defaultInterpolatedStringHandler).AppendLiteral(" sha256=");
									(defaultInterpolatedStringHandler).AppendFormatted(((KYxDNCXqOpQF3JF9F6k2)payload).Sha256);
									(defaultInterpolatedStringHandler).AppendLiteral(" ");
									(defaultInterpolatedStringHandler).AppendLiteral("directory=");
									(defaultInterpolatedStringHandler).AppendFormatted(System.IO.Path.GetFileName((string)directory));
									(defaultInterpolatedStringHandler).AppendLiteral(" execution=unconfirmed server_classification=unconfirmed");
									log.Invoke((defaultInterpolatedStringHandler).ToStringAndClear());
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
									{
										num4 = 3;
									}
									continue;
								}
								case 0:
									throw new IOException(string.Concat("释放 MCP 时缓存文件发生变化：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
								case 1:
									try
									{
										(val).Write(((global::System.ReadOnlySpan<byte>)((dynamic)(M5eXqI60RTq)).GetBytes(((KYxDNCXqOpQF3JF9F6k2)payload).Sha256)));
										int num6 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
										{
											num6 = 1;
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
											case 1:
												(val).Flush(true);
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
												{
													num6 = 2;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									finally
									{
										int num8;
										if (val == null)
										{
											num8 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
											{
												num8 = 3;
											}
											goto IL_024d;
										}
										goto IL_0295;
										IL_024d:
										while (true)
										{
											switch (num8)
											{
											default:
												if (num9 == 990)
												{
													goto IL_0249;
												}
												goto end_IL_024d;
											case 1:
												goto end_IL_024d;
											case 0:
												break;
											case 2:
												goto end_IL_024d;
											}
											goto IL_0295;
											IL_0249:
											num8 = num9;
											continue;
											end_IL_024d:
											break;
										}
										goto end_IL_0215;
										IL_0295:
										(val).Dispose();
										num8 = 2;
										goto IL_024d;
										end_IL_0215:;
									}
									goto case 2;
								case 3:
									if (ytPZc0ff4HhtXJ66KDeo.sqaffUmppI4(text2))
									{
										if (log != null)
										{
											num5 = 13;
											goto IL_00e9;
										}
										goto case 4;
									}
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
									{
										num4 = 0;
									}
									continue;
								case 4:
									result = true;
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num4 = 5;
									}
									continue;
								case 2:
									if (ytPZc0ff4HhtXJ66KDeo.KX9ffmQZvxE(text2, ((KYxDNCXqOpQF3JF9F6k2)payload).Bytes))
									{
										num4 = 3;
										continue;
									}
									goto case 0;
								case 5:
									break;
									IL_00e9:
									num4 = num5;
									continue;
								}
								break;
							}
						}
						catch
						{
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
							{
								num10 = 5;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										goto IL_049b;
									}
									goto case 1;
								case 1:
									try
									{
										T8vXqmSQE51(directory, payload, log);
										int num12 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
										{
											num12 = 0;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												if (num13 == 988)
												{
													num12 = num13;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									catch (global::System.Exception obj2) when (((Func<bool>)delegate
									{
										// Could not convert BlockContainer to single expression
										obj3 = obj2 as global::System.Exception;
										if (obj3 == null)
										{
											num14 = 2;
										}
										else
										{
											ex = obj3;
											num14 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
											{
												num14 = 13;
											}
										}
										num15 = num14;
										while (true)
										{
											num16 = num15;
											while (true)
											{
												switch (num16)
												{
												default:
													if (num15 != 13)
													{
														if (num15 == 993)
														{
															goto end_IL_0542;
														}
														goto case 2;
													}
													if (!(ex is IOException))
													{
														num16 = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
														{
															num16 = 1;
														}
														continue;
													}
													goto case 0;
												case 0:
													flag = true;
													num16 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
													{
														num16 = 8;
													}
													continue;
												case 1:
													if (ex is UnauthorizedAccessException)
													{
														num16 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
														{
															num16 = 0;
														}
														continue;
													}
													goto case 3;
												case 3:
													flag = false;
													num16 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
													{
														num16 = 12;
													}
													continue;
												case 2:
													result2 = 0;
													break;
												case 4:
												case 5:
													result2 = (flag ? 1 : 0);
													break;
												}
												return (byte)result2 != 0;
												continue;
												end_IL_0542:
												break;
											}
										}
									}).Invoke())
									{
										int num17 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
										{
											num17 = 2;
										}
										while (true)
										{
											switch (num17)
											{
											default:
												if (num18 != 11)
												{
													if (num18 == 991)
													{
														goto IL_069a;
													}
													goto case 2;
												}
												break;
											case 2:
												cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "Release", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\BedrockMcpPatchFile.cs", 61);
												num17 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
												{
													num17 = 2;
												}
												continue;
											case 0:
												log.Invoke(string.Concat("rollback deferred file=", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName, " error=", ((ex).GetType()).Name));
												num18 = 11;
												goto IL_069a;
											case 1:
												if (log == null)
												{
													num17 = 3;
													continue;
												}
												goto case 0;
											case 3:
												break;
												IL_069a:
												num17 = num18;
												continue;
											}
											break;
										}
									}
									break;
								case 0:
									break;
								}
								break;
								IL_049b:
								num10 = num11;
							}
							throw;
						}
						goto case 3;
					case 0:
						ir3XqAXPOBE(text2);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num3 = 2;
						}
						continue;
					case 8:
						throw new T7fHlCXt61wmEaJPLhon(ONNOITXtOJ2NNuZvPNm7.McpNameConflict, string.Concat("同名内置MCP 内容不同：", text2));
					case 9:
						ir3XqAXPOBE(text);
						num3 = 11;
						continue;
					case 2:
						ytPZc0ff4HhtXJ66KDeo = Q7EXq7Rg6CB(((KYxDNCXqOpQF3JF9F6k2)payload).Sha256, log);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							num3 = 7;
						}
						continue;
					case 5:
						text2 = System.IO.Path.Combine((string)directory, ((KYxDNCXqOpQF3JF9F6k2)payload).FileName);
						num3 = 4;
						continue;
					case 3:
						return result;
					case 6:
						if (ytPZc0ff4HhtXJ66KDeo.sqaffUmppI4(text2))
						{
							return false;
						}
						num3 = 8;
						continue;
					case 7:
						throw new InvalidDataException(string.Concat("MCP 所有权记录尚未撤回：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
					case 10:
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						text = BnkXqo24Y7Y(directory, payload);
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
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
			{
				num = 18;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void T8vXqmSQE51(object directory, object payload, Action<string>? log)
	{
		//IL_056f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ef: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		string text = default(string);
		FileStream val = default(FileStream);
		StreamReader val2 = default(StreamReader);
		int num9 = default(int);
		string text2 = default(string);
		int num6 = default(int);
		int num8 = default(int);
		int num11 = default(int);
		string text3 = default(string);
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
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						ir3XqAXPOBE(text);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							num3 = 2;
						}
						continue;
					case 7:
						try
						{
							int num4;
							if ((val).Length != 64)
							{
								num4 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
								{
									num4 = 1;
								}
							}
							else
							{
								val2 = new StreamReader((Stream)(object)val, (Encoding)M5eXqI60RTq, false);
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
								{
									num4 = 0;
								}
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num9 == 989)
									{
										goto IL_00d4;
									}
									goto case 1;
								case 1:
									throw new InvalidDataException(string.Concat("MCP 所有权记录已变化，停止撤回：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
								case 0:
									try
									{
										text2 = (val2).ReadToEnd();
										int num5 = 3;
										while (true)
										{
											switch (num5)
											{
											default:
												if (num6 == 991)
												{
													num5 = num6;
													continue;
												}
												goto case 3;
											case 2:
												if (string.Equals(text2, ((KYxDNCXqOpQF3JF9F6k2)payload).PreviousSha256, (StringComparison)4))
												{
													num5 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
													{
														num5 = 1;
													}
													continue;
												}
												break;
											case 3:
												if (!string.Equals(text2, ((KYxDNCXqOpQF3JF9F6k2)payload).Sha256, (StringComparison)4))
												{
													num5 = 2;
													continue;
												}
												goto end_IL_0183;
											case 1:
												goto end_IL_0183;
											case 0:
												break;
											}
											throw new InvalidDataException(string.Concat("MCP 所有权记录不匹配，停止撤回：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
											continue;
											end_IL_0183:
											break;
										}
									}
									finally
									{
										if (val2 != null)
										{
											int num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
											{
												num7 = 0;
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
												case 0:
													(val2).Dispose();
													num7 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
													{
														num7 = 1;
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
								break;
								IL_00d4:
								num4 = num9;
							}
						}
						finally
						{
							int num10;
							if (val == null)
							{
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
								{
									num10 = 1;
								}
								goto IL_0320;
							}
							goto IL_0368;
							IL_0320:
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 990)
									{
										goto IL_031c;
									}
									goto end_IL_0320;
								case 1:
									goto end_IL_0320;
								case 2:
									break;
								case 0:
									goto end_IL_0320;
								}
								goto IL_0368;
								IL_031c:
								num10 = num11;
								continue;
								end_IL_0320:
								break;
							}
							goto end_IL_02e8;
							IL_0368:
							(val).Dispose();
							num10 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
							{
								num10 = 0;
							}
							goto IL_0320;
							end_IL_02e8:;
						}
						goto case 10;
					case 13:
						return;
					case 9:
						log.Invoke(string.Concat("owned file withdrawn file=", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName, " directory=", System.IO.Path.GetFileName((string)directory)));
						num3 = 8;
						continue;
					case 3:
						if (!System.IO.File.Exists(text3))
						{
							num3 = 12;
							continue;
						}
						goto case 11;
					case 11:
						if (!Q7EXq7Rg6CB(text2, log).SDUff7jrRta(text3))
						{
							num3 = 4;
							continue;
						}
						goto case 12;
					case 2:
						text3 = System.IO.Path.Combine((string)directory, ((KYxDNCXqOpQF3JF9F6k2)payload).FileName);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							num3 = 15;
						}
						continue;
					case 10:
						ir3XqAXPOBE(text3);
						num3 = 3;
						continue;
					case 6:
						throw new IOException(string.Concat("MCP 所有权记录撤回失败：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
					case 0:
						if (!System.IO.File.Exists(text))
						{
							return;
						}
						num = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num = 20;
						}
						break;
					case 8:
						return;
					case 4:
						throw new InvalidDataException(string.Concat("已释放 MCP 被外部修改，保留该文件：", ((KYxDNCXqOpQF3JF9F6k2)payload).FileName));
					case 12:
						if (Q7EXq7Rg6CB(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(((dynamic)(M5eXqI60RTq)).GetBytes(text2))), log).SDUff7jrRta(text))
						{
							if (log != null)
							{
								num3 = 9;
								continue;
							}
							return;
						}
						num = 6;
						break;
					case 1:
						text = BnkXqo24Y7Y(directory, payload);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 13;
						}
						continue;
					case 5:
						val = new FileStream(text, (FileMode)3, (FileAccess)1, (FileShare)1, 4096);
						num3 = 7;
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
	private static YtPZc0ff4HhtXJ66KDeo Q7EXq7Rg6CB(object hash, Action<string>? log)
	{
		return (YtPZc0ff4HhtXJ66KDeo)new YtPZc0ff4HhtXJ66KDeo((string)hash, (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string _) => false), log);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ir3XqAXPOBE(object path)
	{
		int num = 3;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool P5KplHZxRsciuSoRsPH0()
	{
		return Pfb9RVZx6jC3xpcT5CJj == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hDjZsyXqUiN1SDOOiPuj tuIDlqZxwChGvbQpkCj7()
	{
		return (hDjZsyXqUiN1SDOOiPuj)Pfb9RVZx6jC3xpcT5CJj;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using VDFw09XQ2VQyx5mkm1V2;
using an3gUVq2E3PsvwmPejP;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using rEWmcPfNAhtZSJjsJvk3;

namespace zSDXc3fA2sZmUh5kbpKe;

internal class QjR8kDfAEKuXesjdUuCU
{
	internal static object uiQOiDZaTKtxaYfA0iZp;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oMwfAqhOB9N(object body, out int itemCount, out string detail)
	{
		detail = default;
		itemCount = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool thkfAGOK7Kf(object body, out global::System.Collections.Generic.IReadOnlyList<string> identifiers)
	{
		int num = 3;
		identifiers = default;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool MBGfAixEDiD(object body, bool useNetworkNbt, out global::System.Collections.Generic.IReadOnlyList<string> identifiers)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool TryValidateItemRegistryCore(object body, bool useNetworkNbt, out int itemCount, out string detail)
	{
		//IL_0191: Expected O, but got I4
		//IL_01ec->IL0092: Incompatible stack heights: 2 vs 1
		//IL_01f7->IL0092: Incompatible stack heights: 2 vs 1
		int num = 1;
		bool result = default(bool);
		int num5 = default(int);
		uint num4 = default(uint);
		uint num6 = default(uint);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		int num9 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num11 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					itemCount = 0;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
					{
						num2 = 8;
					}
					break;
				case 3:
					detail = default;
					itemCount = default;
					return result;
				case 2:
					try
					{
						int pos = 0;
						int num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 == 36)
								{
									goto case 23;
								}
								if (num5 == 1016)
								{
									goto IL_008e;
								}
								goto case 5;
							case 22:
								if (LgrfIDJ1mEa(body, ref pos) <= 1)
								{
									num3 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
									{
										num3 = 25;
									}
									continue;
								}
								goto case 16;
							case 25:
							case 26:
								X2HfIYB7M4a(body, ref pos);
								num3 = 17;
								continue;
							case 11:
							{
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
								(defaultInterpolatedStringHandler).AppendLiteral("trailing bytes=");
								defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Array)body).Length - pos);
								global::System.Runtime.CompilerServices.Unsafe.Write((void*)15, (defaultInterpolatedStringHandler).ToStringAndClear());
								_ = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
								{
									_ = 9;
								}
								continue;
							}
							case 8:
								detail = "item count exceeds safety limit";
								num3 = 24;
								continue;
							case 9:
								num4 = 0u;
								num3 = 23;
								continue;
							case 12:
								break;
							case 24:
								result = false;
								num3 = 28;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
								{
									num3 = 27;
								}
								continue;
							case 1:
								result = false;
								num3 = 12;
								continue;
							case 27:
								detail = "itemstates fully parsed";
								num3 = 18;
								continue;
							case 14:
							case 19:
								raofIbyGaLl(body, ref pos);
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
								{
									num3 = 4;
								}
								continue;
							case 18:
								result = true;
								num3 = 21;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
								{
									num3 = 6;
								}
								continue;
							case 23:
								if (num4 >= num6)
								{
									num3 = 20;
									continue;
								}
								goto case 13;
							case 5:
								if (num6 > 100000)
								{
									num3 = 8;
									continue;
								}
								goto case 9;
							case 21:
								result = false;
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
								{
									num3 = 7;
								}
								continue;
							case 0:
								itemCount = checked((int)num6);
								num3 = 27;
								continue;
							case 3:
								num6 = GhMfIkZGWol(body, ref pos);
								num3 = 5;
								continue;
							case 13:
								XXxfI9AvMgR(body, ref pos, 4096);
								num3 = 2;
								continue;
							case 16:
								detail = "component_based is not boolean";
								num3 = 21;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
								{
									num3 = 2;
								}
								continue;
							case 20:
								if (pos != ((global::System.Array)body).Length)
								{
									num3 = 11;
									continue;
								}
								goto case 0;
							case 4:
							case 10:
								num4++;
								num5 = 36;
								goto IL_008e;
							case 2:
								QZifIS3OTJ8(body, ref pos, 2);
								num3 = 22;
								continue;
							case 28:
								break;
							case 15:
								pZSfAzukn3n(body, ref pos);
								num3 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									num3 = 33;
								}
								continue;
							case 17:
								if (!useNetworkNbt)
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num3 = 19;
									}
									continue;
								}
								goto case 15;
							case 7:
								break;
							case 6:
								break;
								IL_008e:
								num3 = num5;
								continue;
							}
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num7 = 2;
							goto IL_04ce;
						}
						ex = obj2;
						num8 = 3;
						goto IL_04c6;
						IL_04c6:
						num9 = num8;
						goto IL_04ca;
						IL_04ca:
						num7 = num9;
						goto IL_04ce;
						IL_04ce:
						while (true)
						{
							switch (num7)
							{
							case 5:
								goto IL_0534;
							case 6:
								if (ex is OverflowException)
								{
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
									{
										num7 = 5;
									}
									continue;
								}
								goto case 0;
							case 0:
								flag = false;
								num7 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
								{
									num7 = 1;
								}
								continue;
							case 3:
								goto IL_058e;
							case 2:
								result2 = 0;
								goto IL_05d1;
							case 1:
							case 4:
								{
									result2 = (flag ? 1 : 0);
									goto IL_05d1;
								}
								IL_05d1:
								return (byte)result2 != 0;
							}
							if (num9 != 14)
							{
								if (num9 == 994)
								{
									goto IL_04ca;
								}
							}
							else if (!(ex is InvalidDataException))
							{
								num7 = 6;
								continue;
							}
							goto IL_0534;
							IL_058e:
							if (!(ex is EndOfStreamException))
							{
								break;
							}
							goto IL_0534;
							IL_0534:
							flag = true;
							num7 = 4;
						}
						num8 = 14;
						goto IL_04c6;
					}).Invoke())
					{
						int num10 = 1;
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 != 10)
								{
									if (num11 == 990)
									{
										goto IL_05ec;
									}
									goto case 2;
								}
								result = false;
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
								{
									num10 = 9;
								}
								continue;
							case 2:
							{
								detail = string.Concat("parse failed: ", (ex).Message);
								int num12 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
								{
									num12 = 10;
								}
								num11 = num12;
								goto IL_05ec;
							}
							case 1:
								cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryValidateItemRegistryCore", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Translation\\BedrockRegistryCompatibilityTracker.cs", 354);
								num10 = 2;
								continue;
							case 0:
								break;
								IL_05ec:
								num10 = num11;
								continue;
							}
							break;
						}
					}
					goto case 3;
				case 0:
					detail = "";
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
					{
						num2 = 6;
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
	internal unsafe static bool TryValidateBiomeDefinitionList(object body, out int biomeCount, out bool opaque, out string detail)
	{
		//IL_0329: Expected O, but got I4
		//IL_0380->IL0073: Incompatible stack heights: 2 vs 1
		//IL_038b->IL0073: Incompatible stack heights: 2 vs 1
		int num = 2;
		int num8 = default(int);
		int num5 = default(int);
		bool result = default(bool);
		uint num6 = default(uint);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num13 = default(int);
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
						opaque = false;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						break;
					case 3:
						try
						{
							int pos = 0;
							int num4 = 7;
							while (true)
							{
								int num7;
								switch (num4)
								{
								default:
									if (num8 != 28)
									{
										if (num8 == 1008)
										{
											goto IL_006f;
										}
										goto case 12;
									}
									goto case 4;
								case 19:
									if (((global::System.Array)body).Length < num5)
									{
										num4 = 18;
										continue;
									}
									goto case 5;
								case 17:
									result = false;
									num4 = 10;
									continue;
								case 16:
									break;
								case 3:
									detail = "definitions and string list fully parsed";
									num4 = 2;
									continue;
								case 8:
									break;
								case 1:
									detail = "biome count exceeds safety limit";
									num4 = 17;
									continue;
								case 12:
									detail = "definition extension is opaque; payload was not rewritten";
									num4 = 9;
									continue;
								case 10:
									break;
								case 15:
									if (!GoefAny7SX9(body, ref pos, num6, hasNeteaseExtras: false))
									{
										num4 = 11;
										continue;
									}
									goto case 3;
								case 13:
								case 14:
									num5 = checked(1 + biomeCount * 29);
									num4 = 28;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
									{
										num4 = 19;
									}
									continue;
								case 4:
									biomeCount = checked((int)num6);
									num7 = 15;
									goto IL_006b;
								case 2:
									result = true;
									num4 = 8;
									continue;
								case 9:
									result = false;
									num4 = 20;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
									{
										num4 = 0;
									}
									continue;
								case 7:
									num6 = GhMfIkZGWol(body, ref pos);
									num7 = 20;
									goto IL_006b;
								case 5:
									opaque = true;
									num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
									{
										num4 = 12;
									}
									continue;
								case 6:
									result = false;
									num4 = 16;
									continue;
								case 11:
									if (!GoefAny7SX9(body, ref pos, num6, hasNeteaseExtras: true))
									{
										num4 = 14;
										continue;
									}
									goto case 3;
								case 20:
									if (num6 <= 4096)
									{
										num7 = 28;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
										{
											num7 = 27;
										}
										goto IL_006b;
									}
									goto case 1;
								case 18:
								{
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
									(defaultInterpolatedStringHandler).AppendLiteral("body shorter than biome header minimum=");
									defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
									global::System.Runtime.CompilerServices.Unsafe.Write((void*)39, (defaultInterpolatedStringHandler).ToStringAndClear());
									_ = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										_ = 1;
									}
									continue;
								}
								case 0:
									break;
									IL_006b:
									num8 = num7;
									goto IL_006f;
									IL_006f:
									num4 = num8;
									continue;
								}
								break;
							}
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num9 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
								{
									num9 = 8;
								}
							}
							else
							{
								ex = obj2;
								num9 = 3;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num11 != 16)
									{
										if (num11 == 996)
										{
											goto IL_03c9;
										}
										goto case 1;
									}
									if (ex is InvalidDataException)
									{
										num9 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num9 = 5;
										}
										continue;
									}
									goto case 4;
								case 3:
									if (!(ex is EndOfStreamException))
									{
										num10 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
										{
											num10 = 16;
										}
										num11 = num10;
										goto IL_03c9;
									}
									goto case 0;
								case 2:
								case 5:
									flag = false;
									num9 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
									{
										num9 = 8;
									}
									continue;
								case 4:
									if (!(ex is OverflowException))
									{
										num9 = 5;
										continue;
									}
									goto case 0;
								case 0:
								case 7:
									flag = true;
									num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
									{
										num9 = 3;
									}
									continue;
								case 8:
									result2 = 0;
									break;
								case 1:
								case 6:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_03c9:
									num9 = num11;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num12 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
							{
								num12 = 1;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 != 10)
									{
										if (num13 == 990)
										{
											goto IL_0565;
										}
										goto case 2;
									}
									goto end_IL_0569;
								case 2:
									result = false;
									num13 = 10;
									goto IL_0565;
								case 0:
									detail = string.Concat("parse failed: ", (ex).Message);
									num12 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
									{
										num12 = 6;
									}
									break;
								case 1:
									{
										cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryValidateBiomeDefinitionList", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Translation\\BedrockRegistryCompatibilityTracker.cs", 397);
										num12 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
										{
											num12 = 9;
										}
										break;
									}
									IL_0565:
									num12 = num13;
									break;
								}
								continue;
								end_IL_0569:
								break;
							}
						}
						goto case 0;
					case 1:
						detail = "";
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
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
			biomeCount = 0;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool GoefAny7SX9(object body, ref int originalPos, uint count, bool hasNeteaseExtras)
	{
		int pos = default(int);
		uint num = GhMfIkZGWol(body, ref pos);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool TryValidateLevelChunk(object body, out int payloadLength, out int subChunkCount, out string detail)
	{
		//IL_01ec: Expected O, but got I4
		//IL_0238->IL00bb: Incompatible stack heights: 2 vs 1
		int num = 3;
		int num8 = default(int);
		bool result = default(bool);
		uint num7 = default(uint);
		uint num5 = default(uint);
		byte b = default(byte);
		uint num9 = default(uint);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num14 = default(int);
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
							goto case 3;
						}
						try
						{
							int pos = 0;
							int num4 = 33;
							while (true)
							{
								int num6;
								switch (num4)
								{
								default:
									if (num8 != 49)
									{
										if (num8 == 1029)
										{
											goto IL_00b7;
										}
										goto case 5;
									}
									goto case 15;
								case 10:
									QZifIS3OTJ8(body, ref pos, 2);
									num4 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
									{
										num4 = 3;
									}
									continue;
								case 12:
									detail = "cache_enabled is not boolean";
									num4 = 26;
									continue;
								case 27:
									result = false;
									num6 = 31;
									goto IL_00b3;
								case 1:
								{
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
									(defaultInterpolatedStringHandler).AppendLiteral("trailing bytes=");
									defaultInterpolatedStringHandler.AppendFormatted<int>(((global::System.Array)body).Length - pos);
									global::System.Runtime.CompilerServices.Unsafe.Write((void*)15, (defaultInterpolatedStringHandler).ToStringAndClear());
									_ = 30;
									continue;
								}
								case 33:
									X2HfIYB7M4a(body, ref pos);
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									X2HfIYB7M4a(body, ref pos);
									num4 = 9;
									continue;
								case 2:
									if (num7 == 4294967294u)
									{
										num6 = 10;
										goto IL_00b3;
									}
									goto case 11;
								case 13:
									break;
								case 30:
									result = false;
									num6 = 28;
									goto IL_00b3;
								case 14:
									subChunkCount = checked((int)num7);
									num4 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
									{
										num4 = 15;
									}
									continue;
								case 38:
									if (num5 <= 4096)
									{
										num4 = 29;
										continue;
									}
									goto case 37;
								case 4:
									result = false;
									num4 = 13;
									continue;
								case 22:
									detail = "header, cache hashes and payload length fully parsed";
									num4 = 41;
									continue;
								case 15:
									b = LgrfIDJ1mEa(body, ref pos);
									num4 = 32;
									continue;
								case 37:
									detail = "chunk hash count exceeds safety limit";
									num4 = 39;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
									{
										num4 = 17;
									}
									continue;
								case 28:
									break;
								case 36:
									num5 = GhMfIkZGWol(body, ref pos);
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num4 = 38;
									}
									continue;
								case 3:
									if (num9 <= (uint)(((global::System.Array)body).Length - pos))
									{
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
										{
											num4 = 2;
										}
										continue;
									}
									goto case 35;
								case 8:
									num9 = GhMfIkZGWol(body, ref pos);
									num4 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
									{
										num4 = 5;
									}
									continue;
								case 41:
									result = true;
									num4 = 49;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
									{
										num4 = 20;
									}
									continue;
								case 6:
								case 17:
									payloadLength = checked((int)num9);
									num4 = 40;
									continue;
								case 16:
									if (pos != ((global::System.Array)body).Length)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num4 = 24;
										}
										continue;
									}
									goto case 22;
								case 31:
									break;
								case 9:
									X2HfIYB7M4a(body, ref pos);
									num6 = 25;
									goto IL_00b3;
								case 26:
									result = false;
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
									{
										num4 = 7;
									}
									continue;
								case 40:
									pos += payloadLength;
									num4 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num4 = 16;
									}
									continue;
								case 25:
									num7 = GhMfIkZGWol(body, ref pos);
									num4 = 2;
									continue;
								case 19:
									break;
								case 18:
								case 34:
									if (b != 0)
									{
										num4 = 36;
										continue;
									}
									goto case 8;
								case 21:
									subChunkCount = -2;
									num6 = 49;
									goto IL_00b3;
								case 7:
									break;
								case 35:
									detail = "payload length exceeds body";
									num4 = 4;
									continue;
								case 5:
									if (num9 <= 2147483647)
									{
										num4 = 3;
										continue;
									}
									goto case 35;
								case 32:
									if (b <= 1)
									{
										num4 = 34;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
										{
											num4 = 35;
										}
										continue;
									}
									goto case 12;
								case 23:
									detail = "sub chunk count exceeds safety limit";
									num4 = 27;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
									{
										num4 = 39;
									}
									continue;
								case 11:
									if (num7 > 64)
									{
										num4 = 23;
										continue;
									}
									goto case 14;
								case 39:
									result = false;
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
									{
										num4 = 4;
									}
									continue;
								case 24:
								case 29:
									QZifIS3OTJ8(body, ref pos, checked((int)num5 * 8));
									num4 = 8;
									continue;
								case 20:
									break;
									IL_00b7:
									num4 = num8;
									continue;
									IL_00b3:
									num8 = num6;
									goto IL_00b7;
								}
								break;
							}
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num10 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
								{
									num10 = 6;
								}
							}
							else
							{
								ex = obj2;
								num10 = 5;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 != 15)
									{
										if (num11 == 995)
										{
											goto IL_06ce;
										}
										goto case 5;
									}
									goto case 3;
								case 1:
									flag = false;
									num12 = 15;
									goto IL_06ca;
								case 7:
									if (!(ex is InvalidDataException))
									{
										num12 = 4;
										goto IL_06ca;
									}
									goto case 0;
								case 4:
									if (ex is OverflowException)
									{
										num10 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
										{
											num10 = 0;
										}
										continue;
									}
									goto case 1;
								case 0:
								case 2:
									flag = true;
									num10 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
									{
										num10 = 3;
									}
									continue;
								case 5:
									if (ex is EndOfStreamException)
									{
										num10 = 2;
										continue;
									}
									goto case 7;
								case 6:
									result2 = 0;
									break;
								case 3:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_06ce:
									num10 = num11;
									continue;
									IL_06ca:
									num11 = num12;
									goto IL_06ce;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num13 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num13 = 6;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num14 != 10)
									{
										if (num14 == 990)
										{
											goto IL_0818;
										}
										goto case 2;
									}
									goto end_IL_081c;
								case 0:
									detail = string.Concat("parse failed: ", (ex).Message);
									num13 = 2;
									break;
								case 1:
									cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryValidateLevelChunk", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Translation\\BedrockRegistryCompatibilityTracker.cs", 517);
									num13 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
									{
										num13 = 6;
									}
									break;
								case 2:
									{
										result = false;
										num14 = 10;
										goto IL_0818;
									}
									IL_0818:
									num13 = num14;
									break;
								}
								continue;
								end_IL_081c:
								break;
							}
						}
						goto case 0;
					case 3:
						payloadLength = 0;
						num3 = 2;
						continue;
					case 2:
						subChunkCount = 0;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
						{
							num3 = 9;
						}
						continue;
					case 1:
						break;
					case 0:
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
			detail = "";
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void pZSfAzukn3n(object data, ref int pos)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001d;
				case 0:
					return;
				case 1:
					break;
				}
				goto IL_0031;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0031;
				IL_0031:
				byte type = LgrfIDJ1mEa(data, ref pos);
				XXxfI9AvMgR(data, ref pos, 4096);
				j1afIjKe6xt(type, data, ref pos, 0);
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void raofIbyGaLl(object data, ref int pos)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001d;
				case 1:
					break;
				case 0:
					return;
				}
				goto IL_0030;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0030;
				IL_0030:
				byte type = LgrfIDJ1mEa(data, ref pos);
				O2GfIfGUYfm(data, ref pos);
				GoefIXiKYZF(type, data, ref pos, 0);
				num2 = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void GoefIXiKYZF(byte type, object data, ref int pos, int depth)
	{
		QZifIS3OTJ8(data, ref pos, 2);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		((AsyncTaskMethodBuilder<bq7k3qfN7qMnvLJMNOZa>*)3)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Jx59f3qEugGU1B1mwyt>.ConfiguredTaskAwaiter, AjdJLyXQEsgQnnubppr2._StartProxyAsync_d__32>(ref this, ref this);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void O2GfIfGUYfm(object data, ref int pos)
	{
		ushort length = default(ushort);
		QZifIS3OTJ8(data, ref pos, length);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int cY6fILjgvGE(object data, ref int pos)
	{
		int num = 2;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void j1afIjKe6xt(byte type, object data, ref int pos, int depth)
	{
		QZifIS3OTJ8(data, ref pos, JydfIZcjAYm(data, ref pos));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int JydfIZcjAYm(object data, ref int pos)
	{
		int num = 1;
		int num5 = default(int);
		uint num4 = default(uint);
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
								goto end_IL_0010;
							}
							goto case 3;
						}
						if (num5 < 0)
						{
							num3 = 4;
							continue;
						}
						goto case 2;
					case 0:
						break;
					case 2:
						if (num5 > 1000000)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						return num5;
					case 3:
					case 4:
						throw new global::System.Exception("invalid NBT collection length");
					case 1:
						num4 = GhMfIkZGWol(data, ref pos);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							num3 = 0;
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
			num5 = (int)((num4 >> 1) ^ (0 - (num4 & 1)));
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string XXxfI9AvMgR(object data, ref int pos, int maxLength)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Invalid comparison between I4 and Unknown
		//IL_0102: Expected I4, but got F4
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		int num = 3;
		uint num4 = default(uint);
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
								goto end_IL_0010;
							}
							goto case 0;
						}
						(System.Text.Encoding.UTF8).GetString((byte[])data, (int)global::System.Runtime.CompilerServices.Unsafe.As<int, float>(ref pos), (int)num4);
						return (string)(global::System.Runtime.CompilerServices.Unsafe.As<int, float>(ref pos) + num4);
					case 4:
						if ((int)num4 <= (int)(((global::System.Array)data).Length - global::System.Runtime.CompilerServices.Unsafe.As<int, float>(ref pos)))
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 3:
						num4 = GhMfIkZGWol(data, ref pos);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 2;
						}
						break;
					case 2:
						if (num4 > maxLength)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								num3 = 1;
							}
							break;
						}
						goto case 4;
					case 0:
					case 1:
						throw new global::System.Exception("string length exceeds packet");
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte LgrfIDJ1mEa(object data, ref int pos)
	{
		int num = 2;
		return default(byte);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint GhMfIkZGWol(object data, ref int pos)
	{
		int num = 4;
		uint num4 = default(uint);
		byte b = default(byte);
		int num5 = default(int);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 2;
					case 4:
						num4 = 0u;
						num3 = 3;
						continue;
					case 7:
						num4 |= (uint)((b & 0x7F) << num5);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							num3 = 8;
						}
						continue;
					case 5:
						throw new global::System.Exception("VarInt is too long");
					case 1:
					case 9:
						if (num5 < 35)
						{
							break;
						}
						goto case 5;
					case 3:
						num5 = 0;
						num3 = 9;
						continue;
					case 2:
						b = LgrfIDJ1mEa(data, ref pos);
						num3 = 7;
						continue;
					case 0:
						return num4;
					case 6:
						num5 += 7;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
						{
							num3 = 4;
						}
						continue;
					case 8:
						if ((b & 0x80) != 0)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 0;
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
			num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
			{
				num = 16;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong A5gfIVJD5jx(object data, ref int pos)
	{
		int num = 2;
		byte b = default(byte);
		int num4 = default(int);
		ulong num5 = default(ulong);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						if ((b & 0x80) == 0)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						num4 += 7;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							num3 = 11;
						}
						continue;
					case 6:
						b = LgrfIDJ1mEa(data, ref pos);
						num3 = 4;
						continue;
					case 3:
					case 7:
						if (num4 >= 70)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 6;
					case 2:
						num5 = 0uL;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						throw new global::System.Exception("VarLong is too long");
					case 4:
						break;
					case 5:
						return num5;
					case 1:
						num4 = 0;
						num3 = 3;
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
			num5 |= (ulong)((long)(b & 0x7F) << num4);
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int X2HfIYB7M4a(object data, ref int pos)
	{
		int num = 1;
		uint num3 = default(uint);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					num3 = GhMfIkZGWol(data, ref pos);
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return (int)((num3 >> 1) ^ (0 - (num3 & 1)));
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void QZifIS3OTJ8(object data, ref int pos, int length)
	{
		int num = 4;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						num3 = 2;
						continue;
					case 1:
						break;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jSx5MbZaNDJIcSrGZo42()
	{
		return uiQOiDZaTKtxaYfA0iZp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static QjR8kDfAEKuXesjdUuCU TS67QuZaMnNDdL11SIvB()
	{
		return (QjR8kDfAEKuXesjdUuCU)uiQOiDZaTKtxaYfA0iZp;
	}
}

using System;
using System.Collections.Immutable;
using System.IO;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace ofVNYmXIA1tTCQAPJyfj;

internal sealed class r7j98AXI72xOtKXWLtub
{
	private readonly object ArZXIKeRAu3;

	private static object oAo8UcZOC7RogVHryga4;

	internal global::System.ReadOnlySpan<byte> Mask
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((global::System.ReadOnlySpan<byte>)(byte[])ArZXIKeRAu3);
		}
	}

	internal string PlatformWindowName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return "LHMW_FG_Main";
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private r7j98AXI72xOtKXWLtub(byte[] mask)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static r7j98AXI72xOtKXWLtub cH2XII8X1Cp(object installationPath)
	{
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c7: Expected O, but got Unknown
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f1: Invalid comparison between Unknown and I4
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Invalid comparison between Unknown and I4
		int num = 2;
		r7j98AXI72xOtKXWLtub result = default(r7j98AXI72xOtKXWLtub);
		FileStream val = default(FileStream);
		int num10 = default(int);
		PEReader val2 = default(PEReader);
		bool flag = default(bool);
		int num7 = default(int);
		byte[] array = default(byte[]);
		PEMemoryBlock val4 = default(PEMemoryBlock);
		ImmutableArray<byte> val3 = default(ImmutableArray<byte>);
		int num9 = default(int);
		int num13 = default(int);
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
					goto case 3;
				case 0:
					return result;
				case 2:
					System.ArgumentException.ThrowIfNullOrWhiteSpace((string)installationPath, "installationPath");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
					{
						num2 = 6;
					}
					break;
				case 3:
					try
					{
						long num3 = (val).Length;
						int num4 = 2;
						while (true)
						{
							switch (num4)
							{
							default:
								if (num10 != 18)
								{
									if (num10 == 998)
									{
										goto IL_00a8;
									}
									goto case 3;
								}
								goto case 7;
							case 8:
								val2 = new PEReader((Stream)(object)val, (PEStreamOptions)1);
								num4 = 6;
								continue;
							case 9:
								if (num3 > 16777216)
								{
									num4 = 4;
									continue;
								}
								goto case 10;
							case 4:
								flag = true;
								num4 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
								{
									num4 = 7;
								}
								continue;
							case 3:
								throw new NotSupportedException("经典版 NCG SDK 版本尚未核对，不能套用其他版本的票据交付协议");
							case 0:
								(val).Position = 0L;
								num4 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
								{
									num4 = 8;
								}
								continue;
							case 5:
								throw new InvalidDataException("经典版 NCG SDK 文件大小不受支持");
							case 1:
								if (string.Equals((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val))).ToLowerInvariant(), "5cd129572e8b54691bb04267914b552bce3b1ceec8fa9054aa445928dc52f29c", (StringComparison)4))
								{
									num4 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								goto case 3;
							case 7:
								if (!flag)
								{
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 5;
							case 2:
								if (num3 >= 4096)
								{
									num4 = 9;
									continue;
								}
								goto case 4;
							case 10:
							{
								flag = false;
								int num11 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
								{
									num11 = 9;
								}
								num10 = num11;
								goto IL_00a8;
							}
							case 6:
								{
									try
									{
										if ((int)(((val2).PEHeaders).CoffHeader).Machine != 34404)
										{
											goto IL_035c;
										}
										int num5 = 7;
										while (true)
										{
											switch (num5)
											{
											default:
												if (num7 != 16)
												{
													if (num7 == 996)
													{
														goto IL_030e;
													}
													goto case 5;
												}
												goto end_IL_0312;
											case 4:
											case 6:
												break;
											case 1:
												array = new byte[496];
												num5 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
												{
													num5 = 7;
												}
												continue;
											case 2:
											{
												if (!string.Equals((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array))).ToLowerInvariant(), "81842e1aa7b1e7edc8027addb390340e3f840b7154d221f1aa9629a020cd93c2", (StringComparison)4))
												{
													num5 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
													{
														num5 = 5;
													}
													continue;
												}
												result = (r7j98AXI72xOtKXWLtub)new r7j98AXI72xOtKXWLtub(array);
												int num6 = 16;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
												{
													num6 = 9;
												}
												num7 = num6;
												goto IL_030e;
											}
											case 0:
												val4 = (val2).GetSectionData(2315872);
												num5 = 3;
												continue;
											case 3:
												val3 = (val4).GetContent(0, 496);
												num5 = 8;
												continue;
											case 7:
											{
												PEHeader obj = ((val2).PEHeaders).PEHeader;
												if (obj == null)
												{
													num5 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
													{
														num5 = 14;
													}
													continue;
												}
												if ((int)(obj).Magic == 523)
												{
													num5 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
													{
														num5 = 1;
													}
													continue;
												}
												break;
											}
											case 5:
												throw new InvalidDataException("经典版 NCG 封包格式校验失败");
											case 8:
												{
													val3.CopyTo(array);
													num5 = 2;
													continue;
												}
												IL_030e:
												num5 = num7;
												continue;
											}
											goto IL_035c;
											continue;
											end_IL_0312:
											break;
										}
										goto end_IL_02cc;
										IL_035c:
										throw new InvalidDataException("经典版 NCG SDK 不是受支持的 x64 PE 映像");
										end_IL_02cc:;
									}
									finally
									{
										if (val2 != null)
										{
											int num8 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
											{
												num8 = 1;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 == 989)
													{
														num8 = num9;
														continue;
													}
													break;
												case 0:
													(val2).Dispose();
													num8 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
													{
														num8 = 6;
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
								IL_00a8:
								num4 = num10;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num12;
						if (val == null)
						{
							num12 = 2;
							goto IL_05f4;
						}
						goto IL_063c;
						IL_063c:
						(val).Dispose();
						num12 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
						{
							num12 = 2;
						}
						goto IL_05f4;
						IL_05f4:
						while (true)
						{
							switch (num12)
							{
							default:
								if (num13 == 990)
								{
									goto IL_05f0;
								}
								goto end_IL_05f4;
							case 2:
								goto end_IL_05f4;
							case 1:
								break;
							case 0:
								goto end_IL_05f4;
							}
							goto IL_063c;
							IL_05f0:
							num12 = num13;
							continue;
							end_IL_05f4:
							break;
						}
					}
					goto case 0;
				case 1:
					val = new FileStream(System.IO.Path.Combine(System.IO.Path.GetFullPath((string)installationPath), "Netease.Ncg.Pay.dll"), (FileMode)3, (FileAccess)1, (FileShare)1);
					num2 = 3;
					break;
				}
				continue;
				end_IL_0010:
				break;
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
	internal static bool Aq3RX9ZO40RIlM7g0oFM()
	{
		return oAo8UcZOC7RogVHryga4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static r7j98AXI72xOtKXWLtub JTE7BOZOh6JaNRBE4Wcy()
	{
		return (r7j98AXI72xOtKXWLtub)oAo8UcZOC7RogVHryga4;
	}
}

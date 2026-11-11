using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using HN5yyEfpz8TLMVS2CfPf;
using XpsS9BXeBrTXsofVa1hH;
using fDAldojjppXrctUVYOJn;

namespace H4TKCGX75d1FgG18yJXL;

internal class bQnMlNX7O5PZhjLe8HkE
{
	private static object sIVudqZtP1s8ZSCVkaOx;

	[MethodImpl((MethodImplOptions)8)]
	internal static xssD3cfpnxdefR05FuDD f5CX76oJaLK(object path)
	{
		//IL_0086: Expected O, but got I4
		//IL_0090->IL0010: Incompatible stack heights: 4 vs 1
		int num = 13;
		string text3 = default(string);
		FileStream val2 = default(FileStream);
		string text5 = default(string);
		string[] array = default(string[]);
		int num4 = default(int);
		string text4 = default(string);
		int num6 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text;
					switch (num3)
					{
					default:
						if (num2 != 24)
						{
							if (num2 == 1005)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						text3 = System.IO.Path.GetFullPath((string)path);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
						{
							num3 = 13;
						}
						continue;
					case 7:
						_ = 3;
						_ = 1;
						val2 = (FileStream)(object)1;
						_ = 2;
						continue;
					case 8:
						text5 = array[num4];
						num3 = 4;
						continue;
					case 1:
						if (!System.IO.File.Exists(text4))
						{
							num3 = 5;
							continue;
						}
						goto case 11;
					case 11:
						if ((text4).Length == 0L)
						{
							num = 10;
							break;
						}
						num4++;
						num = 9;
						break;
					case 2:
						try
						{
							BinaryReader val = (BinaryReader)(object)val2;
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
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
										goto IL_010b;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_010b:
								num5 = num6;
							}
							try
							{
								int num7;
								if ((val).ReadUInt16() != 23117)
								{
									num7 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
									{
										num7 = 3;
									}
									goto IL_0173;
								}
								(val2).Position = 60L;
								int num8 = 16;
								goto IL_016b;
								IL_0312:
								num9 = (val).ReadInt32();
								num8 = 7;
								goto IL_016b;
								IL_016b:
								num10 = num8;
								goto IL_016f;
								IL_016f:
								num7 = num10;
								goto IL_0173;
								IL_0173:
								while (true)
								{
									switch (num7)
									{
									case 5:
									case 8:
										throw new global::System.Exception("客户端 PE 头无效");
									case 6:
										(val2).Position = num9;
										num7 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
										{
											num7 = 1;
										}
										continue;
									case 4:
										if (num9 <= (val2).Length - 6)
										{
											num7 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
											{
												num7 = 6;
											}
											continue;
										}
										goto case 5;
									case 3:
										throw new global::System.Exception("客户端不是有效的 Windows 程序");
									case 2:
										if ((val).ReadUInt16() != 34404)
										{
											num7 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
											{
												num7 = 0;
											}
											continue;
										}
										goto end_IL_0173;
									case 1:
										goto IL_02dd;
									case 7:
										if (num9 < 0)
										{
											num7 = 8;
											continue;
										}
										goto case 4;
									case 0:
										goto IL_033c;
									}
									if (num10 != 16)
									{
										if (num10 == 996)
										{
											goto IL_016f;
										}
										goto IL_02dd;
									}
									goto IL_0312;
									IL_02dd:
									if ((val).ReadUInt32() == 17744)
									{
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
										{
											num7 = 2;
										}
										continue;
									}
									goto IL_033c;
									IL_033c:
									throw new global::System.Exception("经典版启动需要 x64 客户端");
									continue;
									end_IL_0173:
									break;
								}
							}
							finally
							{
								if (val != null)
								{
									int num11 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
									{
										num11 = 0;
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
											break;
										case 1:
											goto end_IL_0396;
										}
										(val).Dispose();
										num11 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
										{
											num11 = 6;
										}
										continue;
										end_IL_0396:
										break;
									}
								}
							}
						}
						finally
						{
							int num13;
							if (val2 == null)
							{
								num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
								{
									num13 = 0;
								}
								goto IL_041a;
							}
							goto IL_0462;
							IL_0462:
							(val2).Dispose();
							num14 = 2;
							goto IL_0416;
							IL_0416:
							num13 = num14;
							goto IL_041a;
							IL_041a:
							switch (num13)
							{
							case 0:
								goto end_IL_03e2;
							case 1:
								goto IL_0462;
							case 2:
								goto end_IL_03e2;
							}
							if (num14 == 990)
							{
								goto IL_0416;
							}
							end_IL_03e2:;
						}
						goto case 6;
					case 17:
						throw new global::System.Exception("请先选择或下载经典版客户端");
					case 0:
						throw new global::System.Exception("所选目录不是完整的经典版客户端，需要 Minecraft.Windows.exe、data/client_cfg.json 和 data/vanilla.mcp");
					case 5:
					case 10:
						throw string.Concat("经典版客户端缺少组件：", text5);
					case 4:
						text4 = System.IO.Path.Combine(text3, text5);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
						{
							num3 = 24;
						}
						continue;
					case 16:
						if (kF34VmXeI3PB5b9LQm9f.UTkXegSBwg6(text3))
						{
							array = new string[4]
							{
								"NtUniSdkBase.dll",
								"NtUniSdkMpay.dll",
								"mpay.dll",
								"netease.data"
							};
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
							{
								num3 = 20;
							}
						}
						else
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num3 = 0;
							}
						}
						continue;
					case 3:
					case 9:
						if (num4 >= array.Length)
						{
							num3 = 12;
							continue;
						}
						goto case 8;
					case 12:
						text2 = System.IO.Path.Combine(text3, "Minecraft.Windows.exe");
						num3 = 7;
						continue;
					case 13:
						if (!string.IsNullOrWhiteSpace((string)path))
						{
							num = 24;
							break;
						}
						goto case 17;
					case 6:
						text = (System.Diagnostics.FileVersionInfo.GetVersionInfo(text2)).FileVersion;
						if (text == null)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_0761;
					case 15:
						num4 = 0;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
						{
							num3 = 0;
						}
						continue;
					case 14:
						{
							text = "未知版本";
							goto IL_0761;
						}
						IL_0761:
						return (xssD3cfpnxdefR05FuDD)new xssD3cfpnxdefR05FuDD(text, text3, text2);
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
						if (num2 == 9)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_0031;
					case 0:
						return;
					case 1:
						break;
					case 2:
						goto end_IL_000e;
					}
					goto IL_0069;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0069;
					IL_0069:
					xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
					num3 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
					{
						num3 = 0;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool ja5AwlZtxjE10EG6qWBP()
	{
		return sIVudqZtP1s8ZSCVkaOx == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bQnMlNX7O5PZhjLe8HkE fcm66OZtFKNiD0m0JSCw()
	{
		return (bQnMlNX7O5PZhjLe8HkE)sIVudqZtP1s8ZSCVkaOx;
	}
}

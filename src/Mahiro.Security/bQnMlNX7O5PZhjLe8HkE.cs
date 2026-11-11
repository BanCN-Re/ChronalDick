using System;
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
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		int num = 13;
		string text3 = default(string);
		FileStream val2 = default(FileStream);
		string text2 = default(string);
		string text5 = default(string);
		string[] array = default(string[]);
		int num4 = default(int);
		string text4 = default(string);
		int num6 = default(int);
		int num9 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		int num14 = default(int);
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
						val2 = new FileStream(text2, (FileMode)3, (FileAccess)1, (FileShare)1);
						num3 = 2;
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
						if ((new FileInfo(text4)).Length == 0L)
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
							BinaryReader val = new BinaryReader((Stream)(object)val2);
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
										goto IL_0117;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0117:
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
									goto IL_017f;
								}
								(val2).Position = 60L;
								int num8 = 16;
								goto IL_0177;
								IL_0326:
								num9 = (val).ReadInt32();
								num8 = 7;
								goto IL_0177;
								IL_0177:
								num10 = num8;
								goto IL_017b;
								IL_017b:
								num7 = num10;
								goto IL_017f;
								IL_017f:
								while (true)
								{
									switch (num7)
									{
									case 5:
									case 8:
										throw new InvalidDataException("客户端 PE 头无效");
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
										throw new InvalidDataException("客户端不是有效的 Windows 程序");
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
										goto end_IL_017f;
									case 1:
										goto IL_02f1;
									case 7:
										if (num9 < 0)
										{
											num7 = 8;
											continue;
										}
										goto case 4;
									case 0:
										goto IL_0350;
									}
									if (num10 != 16)
									{
										if (num10 == 996)
										{
											goto IL_017b;
										}
										goto IL_02f1;
									}
									goto IL_0326;
									IL_02f1:
									if ((val).ReadUInt32() == 17744)
									{
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
										{
											num7 = 2;
										}
										continue;
									}
									goto IL_0350;
									IL_0350:
									throw new InvalidDataException("经典版启动需要 x64 客户端");
									continue;
									end_IL_017f:
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
											goto end_IL_03ae;
										}
										(val).Dispose();
										num11 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
										{
											num11 = 6;
										}
										continue;
										end_IL_03ae:
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
								goto IL_0432;
							}
							goto IL_047a;
							IL_047a:
							(val2).Dispose();
							num14 = 2;
							goto IL_042e;
							IL_042e:
							num13 = num14;
							goto IL_0432;
							IL_0432:
							switch (num13)
							{
							case 0:
								goto end_IL_03fa;
							case 1:
								goto IL_047a;
							case 2:
								goto end_IL_03fa;
							}
							if (num14 == 990)
							{
								goto IL_042e;
							}
							end_IL_03fa:;
						}
						goto case 6;
					case 17:
						throw new InvalidOperationException("请先选择或下载经典版客户端");
					case 0:
						throw new InvalidDataException("所选目录不是完整的经典版客户端，需要 Minecraft.Windows.exe、data/client_cfg.json 和 data/vanilla.mcp");
					case 5:
					case 10:
						throw new InvalidDataException(string.Concat("经典版客户端缺少组件：", text5));
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
						goto IL_0785;
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
							goto IL_0785;
						}
						IL_0785:
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

using System;
using System.Collections.Immutable;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace iXYYFOfgcAKbPQvtICI8;

internal class SwUyMlfgS9I6YwTCcJnZ
{
	internal static object Da8eHfZ1rC05Q85lmJGn;

	[MethodImpl((MethodImplOptions)8)]
	internal static int nG6fg0aitq7(object path, object exportName)
	{
		//IL_032d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int result = default(int);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Exception ex = default(global::System.Exception);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 0;
						}
						break;
					case 4:
						if (((dynamic)(exportName)).Length > 255)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
							{
								num3 = 11;
							}
							break;
						}
						goto case 3;
					case 5:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)exportName, "exportName");
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num3 = 4;
						}
						break;
					case 0:
						try
						{
							result = xsufg8hKxhU(path, exportName);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
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
						catch (global::System.Exception obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num6 = 8;
							}
							else
							{
								ex = obj2;
								num6 = 2;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num8 != 16)
									{
										if (num8 == 996)
										{
											goto IL_017e;
										}
										goto case 1;
									}
									goto case 5;
								case 1:
									if (!(ex is OverflowException))
									{
										num7 = 16;
										goto IL_017a;
									}
									goto case 3;
								case 2:
									if (ex is BadImageFormatException)
									{
										num7 = 6;
										goto IL_017a;
									}
									goto case 7;
								case 5:
									flag = false;
									num6 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
									{
										num6 = 0;
									}
									continue;
								case 3:
								case 6:
									flag = true;
									num6 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										num6 = 4;
									}
									continue;
								case 7:
									if (!(ex is ArgumentOutOfRangeException))
									{
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
										{
											num6 = 9;
										}
										continue;
									}
									goto case 3;
								case 8:
									result2 = 0;
									break;
								case 0:
								case 4:
									{
										result2 = (flag ? 1 : 0);
										break;
									}
									IL_017e:
									num6 = num8;
									continue;
									IL_017a:
									num8 = num7;
									goto IL_017e;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num9 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 988)
									{
										goto IL_02f0;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_02f0:
								num9 = num10;
							}
							throw new InvalidDataException("游戏内面板 DLL 的 PE 导出表已损坏", ex);
						}
						goto case 6;
					case 6:
						return result;
					case 3:
						if (!((dynamic)(exportName)).Contains('\0'))
						{
							goto end_IL_000c;
						}
						goto case 1;
					case 1:
					case 2:
						throw new ArgumentException("导出名称无效", "exportName");
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int xsufg8hKxhU(object path, object exportName)
	{
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0850: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_0567: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Unknown result type (might be due to invalid IL or missing references)
		//IL_037d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Unknown result type (might be due to invalid IL or missing references)
		//IL_0801: Unknown result type (might be due to invalid IL or missing references)
		//IL_080b: Invalid comparison between Unknown and I4
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_0907: Unknown result type (might be due to invalid IL or missing references)
		//IL_090c: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		FileStream val = default(FileStream);
		int num4 = default(int);
		int num8 = default(int);
		int rva4 = default(int);
		BlobReader val5 = default(BlobReader);
		ushort num13 = default(ushort);
		BlobReader val4 = default(BlobReader);
		uint num7 = default(uint);
		BlobReader val8 = default(BlobReader);
		int num10 = default(int);
		DirectoryEntry val6 = default(DirectoryEntry);
		int rva3 = default(int);
		int num12 = default(int);
		int rva2 = default(int);
		BlobReader val7 = default(BlobReader);
		int result = default(int);
		int num11 = default(int);
		byte[] array = default(byte[]);
		uint num6 = default(uint);
		int num14 = default(int);
		BlobReader val9 = default(BlobReader);
		int rva = default(int);
		int num16 = default(int);
		int num18 = default(int);
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
					goto case 1;
				case 2:
					val = System.IO.File.OpenRead((string)path);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					try
					{
						PEReader val2 = new PEReader((Stream)(object)val);
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
						{
							num3 = 3;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0097;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0097:
							num3 = num4;
						}
						try
						{
							PEHeaders val3 = (val2).PEHeaders;
							int num5 = 41;
							while (true)
							{
								int num9;
								switch (num5)
								{
								default:
									if (num8 != 57)
									{
										if (num8 == 1037)
										{
											goto IL_00de;
										}
										goto case 6;
									}
									rva4 = (val5).ReadInt32();
									num5 = 26;
									continue;
								case 4:
									num13 = (val4).ReadUInt16();
									num5 = 56;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
									{
										num5 = 5;
									}
									continue;
								case 18:
									if (num13 >= num7)
									{
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
										{
											num5 = 26;
										}
									}
									else
									{
										(val8).Offset = num13 * 4;
										num5 = 30;
									}
									continue;
								case 7:
									if (num7 == 0)
									{
										num5 = 13;
										continue;
									}
									goto case 3;
								case 34:
									if (num10 >= val6.RelativeVirtualAddress)
									{
										num5 = 36;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
										{
											num5 = 20;
										}
										continue;
									}
									goto case 20;
								case 43:
									throw new InvalidDataException("游戏内面板 DLL 缺少导出表");
								case 48:
									rva3 = (val5).ReadInt32();
									num5 = 11;
									continue;
								case 14:
									num12 = 0;
									num5 = 33;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
									{
										num5 = 44;
									}
									continue;
								case 12:
								case 37:
									rva2 = (val7).ReadInt32();
									num5 = 4;
									continue;
								case 10:
								case 29:
								case 47:
									throw new InvalidDataException("游戏内面板导出地址无效");
								case 8:
									result = num10;
									num5 = 39;
									continue;
								case 39:
									goto end_IL_00e2;
								case 42:
									if (num11 >= 0)
									{
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num5 = 17;
										}
										continue;
									}
									goto case 31;
								case 0:
									throw new InvalidDataException("游戏内面板组件不是 x64 DLL");
								case 24:
								{
									PEHeader obj = (val3).PEHeader;
									if (obj == null)
									{
										num5 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
										{
											num5 = 31;
										}
										continue;
									}
									val6 = (obj).ExportTableDirectory;
									num9 = 6;
									goto IL_00da;
								}
								case 40:
									num11 = global::System.Array.IndexOf<byte>(array, (byte)0);
									num5 = 42;
									continue;
								case 20:
									if (wSYfgWF0OQG(val3, num10))
									{
										num5 = 8;
										continue;
									}
									goto case 10;
								case 31:
									throw new InvalidDataException("游戏内面板导出名称未终止");
								case 17:
									if (!((System.Text.Encoding.ASCII).GetString(array, 0, num11) != (string)exportName))
									{
										num5 = 18;
										continue;
									}
									goto case 15;
								case 49:
									val8 = GYefgyVFJEN(val2, rva4, checked((int)num7 * 4));
									num5 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
									{
										num5 = 14;
									}
									continue;
								case 23:
									val4 = GYefgyVFJEN(val2, rva3, checked((int)num6 * 2));
									num5 = 49;
									continue;
								case 38:
									num14 = System.Math.Min(256, (val9).RemainingBytes);
									num5 = 9;
									continue;
								case 13:
								case 45:
									throw new InvalidDataException("游戏内面板导出表大小无效");
								case 1:
									val7 = GYefgyVFJEN(val2, rva, checked((int)num6 * 4));
									num9 = 23;
									goto IL_00da;
								case 30:
									num10 = (val8).ReadInt32();
									num5 = 25;
									continue;
								case 5:
									val9 = GYefgyVFJEN(val2, rva2, 1);
									num5 = 38;
									continue;
								case 3:
									if (num7 <= 4096)
									{
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
										{
											num5 = 29;
										}
										continue;
									}
									goto case 13;
								case 32:
									num6 = (val5).ReadUInt32();
									num9 = 57;
									goto IL_00da;
								case 9:
									array = (val9).ReadBytes(num14);
									num9 = 40;
									goto IL_00da;
								case 35:
									if (num10 >= ((val3).PEHeader).SizeOfImage)
									{
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
										{
											num5 = 39;
										}
										continue;
									}
									goto case 34;
								case 46:
									if (num6 <= 1024)
									{
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
										{
											num5 = 7;
										}
										continue;
									}
									goto case 13;
								case 28:
									num7 = (val5).ReadUInt32();
									num5 = 32;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
									{
										num5 = 57;
									}
									continue;
								case 2:
									(val5).Offset = 20;
									num5 = 28;
									continue;
								case 36:
									if (num10 >= (long)val6.RelativeVirtualAddress + (long)val6.Size)
									{
										num5 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
										{
											num5 = 20;
										}
										continue;
									}
									goto case 10;
								case 44:
									if (val6.Size >= 40)
									{
										val5 = GYefgyVFJEN(val2, val6.RelativeVirtualAddress, 40);
										num5 = 2;
										continue;
									}
									num5 = 43;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
									{
										num5 = 43;
									}
									continue;
								case 26:
									rva = (val5).ReadInt32();
									num5 = 48;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
									{
										num5 = 14;
									}
									continue;
								case 16:
								case 33:
									if (num12 < num6)
									{
										num5 = 12;
										continue;
									}
									break;
								case 19:
									if ((((val3).CoffHeader).Characteristics & (Characteristics)(0x2000)) != 0)
									{
										num5 = 24;
										continue;
									}
									goto case 0;
								case 25:
									if (num10 <= 0)
									{
										num5 = 47;
										continue;
									}
									goto case 35;
								case 41:
									if ((int)((val3).CoffHeader).Machine == 34404)
									{
										num5 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
										{
											num5 = 33;
										}
										continue;
									}
									goto case 0;
								case 21:
									throw new InvalidDataException("游戏内面板导出序号无效");
								case 6:
									if (val6.RelativeVirtualAddress > 0)
									{
										num5 = 44;
										continue;
									}
									goto case 43;
								case 11:
									if (num6 != 0)
									{
										num5 = 46;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
										{
											num5 = 50;
										}
										continue;
									}
									goto case 13;
								case 15:
									num12++;
									num5 = 16;
									continue;
								case 22:
									throw new InvalidDataException("游戏内面板 DLL 缺少 PE 头");
								case 27:
									break;
									IL_00da:
									num8 = num9;
									goto IL_00de;
									IL_00de:
									num5 = num8;
									continue;
								}
								throw new InvalidDataException(string.Concat("游戏内面板 DLL 缺少 ", (string)exportName));
								continue;
								end_IL_00e2:
								break;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num15 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
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
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0982;
									}
									(val2).Dispose();
									num15 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
									{
										num15 = 5;
									}
									continue;
									end_IL_0982:
									break;
								}
							}
						}
					}
					finally
					{
						int num17;
						if (val == null)
						{
							num17 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num17 = 1;
							}
							goto IL_0a06;
						}
						goto IL_0a2a;
						IL_0a06:
						while (true)
						{
							switch (num17)
							{
							default:
								if (num18 == 990)
								{
									goto IL_0a02;
								}
								goto end_IL_0a06;
							case 0:
								break;
							case 1:
								goto end_IL_0a06;
							case 2:
								goto end_IL_0a06;
							}
							goto IL_0a2a;
							IL_0a02:
							num17 = num18;
							continue;
							end_IL_0a06:
							break;
						}
						goto end_IL_09ce;
						IL_0a2a:
						(val).Dispose();
						num17 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							num17 = 2;
						}
						goto IL_0a06;
						end_IL_09ce:;
					}
					break;
				case 0:
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
	private static BlobReader GYefgyVFJEN(object pe, int rva, int minimumLength)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		PEMemoryBlock val = ((dynamic)(pe)).GetSectionData(rva);
		return default(BlobReader);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool wSYfgWF0OQG(object headers, int rva)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool F8wCuVZ1ok6xjqRYiglc()
	{
		return Da8eHfZ1rC05Q85lmJGn == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SwUyMlfgS9I6YwTCcJnZ qEX32cZ1mJbdOlLmjMoQ()
	{
		return (SwUyMlfgS9I6YwTCcJnZ)Da8eHfZ1rC05Q85lmJGn;
	}
}

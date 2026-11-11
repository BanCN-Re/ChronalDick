using System;
using System.IO;
using System.IO.Compression;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace OtrSMlXQ0hqVyriWYgnh;

internal class z1sVglXQcrEox7hxA54W
{
	internal static object rMuGy3ZdO0TqmUkASWdL;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] nITXQ8aKEoE()
	{
		//IL_0103: Expected O, but got I4
		int num = 2;
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		byte[] result = default(byte[]);
		int num12 = default(int);
		int num14 = default(int);
		int num16 = default(int);
		Stream val = default(Stream);
		int num18 = default(int);
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
				case 3:
					try
					{
						StreamReader val2 = (StreamReader)(object)System.Text.Encoding.UTF8;
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0075;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0075:
							num3 = num4;
						}
						try
						{
							MemoryStream val3 = (MemoryStream)(object)System.Convert.FromBase64String((val2).ReadToEnd());
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
							{
								num5 = 6;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										goto IL_00dc;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00dc:
								num5 = num6;
							}
							try
							{
								GZipStream val4 = (GZipStream)(object)0;
								int num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
								{
									num7 = 3;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										if (num8 == 988)
										{
											goto IL_0130;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_0130:
									num7 = num8;
								}
								try
								{
									byte[] array = new byte[439808];
									int num9 = 2;
									while (true)
									{
										switch (num9)
										{
										default:
											if (num10 != 12)
											{
												if (num10 == 992)
												{
													goto IL_0175;
												}
												goto case 1;
											}
											goto end_IL_0179;
										case 2:
											(val4).ReadExactly((global::System.Span<byte>)array);
											num9 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
											{
												num9 = 3;
											}
											break;
										case 3:
											if ((val4).ReadByte() == -1)
											{
												num9 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
												{
													num9 = 1;
												}
												break;
											}
											goto case 0;
										case 0:
											throw new global::System.Exception("硬件信息兼容组件完整性校验失败，未执行替换。");
										case 4:
											result = array;
											num10 = 12;
											goto IL_0175;
										case 1:
											{
												if ((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array))).Equals("4FAA9261A73FE78803AA39B6B5692A516CF39BA95FC14F2D255491A5F4721806", (StringComparison)4))
												{
													num9 = 4;
													break;
												}
												goto case 0;
											}
											IL_0175:
											num9 = num10;
											break;
										}
										continue;
										end_IL_0179:
										break;
									}
								}
								finally
								{
									int num11;
									if (val4 == null)
									{
										num11 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num11 = 6;
										}
										goto IL_02f0;
									}
									goto IL_0338;
									IL_02f0:
									while (true)
									{
										switch (num11)
										{
										default:
											if (num12 == 990)
											{
												goto IL_02ec;
											}
											goto end_IL_02f0;
										case 0:
											goto end_IL_02f0;
										case 1:
											break;
										case 2:
											goto end_IL_02f0;
										}
										goto IL_0338;
										IL_02ec:
										num11 = num12;
										continue;
										end_IL_02f0:
										break;
									}
									goto end_IL_02b8;
									IL_0338:
									(val4).Dispose();
									num11 = 2;
									goto IL_02f0;
									end_IL_02b8:;
								}
							}
							finally
							{
								int num13;
								if (val3 == null)
								{
									num13 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
									{
										num13 = 0;
									}
									goto IL_0387;
								}
								goto IL_03ab;
								IL_0387:
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 990)
										{
											goto IL_0383;
										}
										goto end_IL_0387;
									case 2:
										break;
									case 0:
										goto end_IL_0387;
									case 1:
										goto end_IL_0387;
									}
									goto IL_03ab;
									IL_0383:
									num13 = num14;
									continue;
									end_IL_0387:
									break;
								}
								goto end_IL_034f;
								IL_03ab:
								(val3).Dispose();
								num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num13 = 3;
								}
								goto IL_0387;
								end_IL_034f:;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num15 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
								{
									num15 = 6;
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
									case 0:
										break;
									case 1:
										goto end_IL_041e;
									}
									(val2).Dispose();
									num15 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
									{
										num15 = 1;
									}
									continue;
									end_IL_041e:
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
							num17 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num17 = 1;
							}
							goto IL_04a2;
						}
						goto IL_04c6;
						IL_04a2:
						while (true)
						{
							switch (num17)
							{
							default:
								if (num18 == 990)
								{
									goto IL_049e;
								}
								goto end_IL_04a2;
							case 2:
								break;
							case 1:
								goto end_IL_04a2;
							case 0:
								goto end_IL_04a2;
							}
							goto IL_04c6;
							IL_049e:
							num17 = num18;
							continue;
							end_IL_04a2:
							break;
						}
						goto end_IL_046a;
						IL_04c6:
						(val).Dispose();
						num17 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num17 = 0;
						}
						goto IL_04a2;
						end_IL_046a:;
					}
					goto case 0;
				case 2:
				{
					Stream obj = ((System.Type.GetTypeFromHandle(typeof(z1sVglXQcrEox7hxA54W).TypeHandle)).Assembly).GetManifestResourceStream("Mahiro_Account.Resources.JavaRuntimeProfile.x64.gz.b64");
					if (obj == null)
					{
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							num2 = 1;
						}
						break;
					}
					val = obj;
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
					{
						num2 = 3;
					}
					break;
				}
				case 0:
					return result;
				case 1:
					throw new global::System.Exception("应用缺少 x64 硬件信息兼容组件，请使用完整应用包。");
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string bp7XQyn99Zp(object path)
	{
		int num = 1;
		FileStream val = default(FileStream);
		string result = default(string);
		int num4 = default(int);
		int num6 = default(int);
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
					val = System.IO.File.Open((string)path, (FileMode)3, (FileAccess)1, (FileShare)1);
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				case 0:
					try
					{
						result = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val));
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									num3 = num4;
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
						if (val != null)
						{
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num5 = 6;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 989)
									{
										num5 = num6;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0109;
								}
								(val).Dispose();
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
								{
									num5 = 1;
								}
								continue;
								end_IL_0109:
								break;
							}
						}
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
	internal static void c0AXQWr2Ve4(object path, bool library)
	{
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		//IL_014d: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		FileStream val2 = default(FileStream);
		int num4 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					val2 = System.IO.File.Open((string)path, (FileMode)3, (FileAccess)1, (FileShare)1);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
					{
						num2 = 4;
					}
					continue;
				case 0:
					try
					{
						PEReader val = (PEReader)(object)val2;
						int num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 0;
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
							PEHeaders val3 = (val).PEHeaders;
							int num5 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num7 == 11)
									{
										break;
									}
									if (num7 == 991)
									{
										goto IL_00f3;
									}
									goto case 2;
								case 3:
								{
									if ((((val3).CoffHeader).Characteristics).HasFlag((global::System.Enum)(object)(Characteristics)8192) == library)
									{
										return;
									}
									int num6 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
									{
										num6 = 11;
									}
									num7 = num6;
									goto IL_00f3;
								}
								case 2:
									if ((val3).PEHeader == null)
									{
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto case 3;
								case 0:
									if ((int)((val3).CoffHeader).Machine == 34404)
									{
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
										{
											num5 = 2;
										}
										continue;
									}
									break;
								case 1:
									break;
									IL_00f3:
									num5 = num7;
									continue;
								}
								break;
							}
							throw string.Concat("当前组件仅支持 x64 Java 运行时，文件类型或架构不匹配：", (string)path);
						}
						finally
						{
							int num8;
							if (val == null)
							{
								num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
								{
									num8 = 3;
								}
								goto IL_0264;
							}
							goto IL_02ac;
							IL_0264:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 990)
									{
										goto IL_0260;
									}
									break;
								case 2:
									goto end_IL_0264;
								case 0:
									break;
								case 1:
									goto end_IL_0264;
								}
								goto IL_02ac;
								IL_0260:
								num8 = num9;
								continue;
								end_IL_0264:
								break;
							}
							goto end_IL_022c;
							IL_02ac:
							(val).Dispose();
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num8 = 8;
							}
							goto IL_0264;
							end_IL_022c:;
						}
					}
					finally
					{
						int num10;
						if (val2 == null)
						{
							num10 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
							{
								num10 = 2;
							}
							goto IL_0310;
						}
						goto IL_0334;
						IL_0310:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_030c;
								}
								goto end_IL_0310;
							case 1:
								break;
							case 2:
								goto end_IL_0310;
							case 0:
								goto end_IL_0310;
							}
							goto IL_0334;
							IL_030c:
							num10 = num11;
							continue;
							end_IL_0310:
							break;
						}
						goto end_IL_02d8;
						IL_0334:
						(val2).Dispose();
						num10 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
						{
							num10 = 0;
						}
						goto IL_0310;
						end_IL_02d8:;
					}
				}
				break;
			}
		}
		while (num == 990);
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
						if (num2 == 9)
						{
							num = 2;
							break;
						}
						goto end_IL_0012;
					case 1:
						num = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num = 9;
						}
						break;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 4;
						}
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				if (num2 != 990)
				{
					return;
				}
				continue;
				end_IL_000e:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool ECHD1NZd5s77LpS8lnmU()
	{
		return rMuGy3ZdO0TqmUkASWdL == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static z1sVglXQcrEox7hxA54W EE88x5Zd62BA8335AmAD()
	{
		return (z1sVglXQcrEox7hxA54W)rMuGy3ZdO0TqmUkASWdL;
	}
}

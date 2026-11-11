using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using MQLtWrflbjL7rOmZhG0a;
using QZs97cfg7H5cG2l6dckf;
using eKYaxffghFvoT0eZRTxb;
using fDAldojjppXrctUVYOJn;
using i6TlJMfuChv2AjPXr7O8;
using lQs7SmfZ8MofeLgDpWlN;
using r5LWFs73eOlXSX66CSK;

namespace UXils3fdIjmg3YyIOYqq;

internal class TWUx93fdAjVPkuNcHH9l
{
	internal static object MuIdGWZ3yIdn0gMaBU6E;

	[MethodImpl((MethodImplOptions)8)]
	internal static void fHQfdB8UHbA(object process, object instance, object addresses)
	{
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		int num = 4;
		int num16 = default(int);
		byte[] array = default(byte[]);
		uint num15 = default(uint);
		rF2scFfgzeIgxosZZ5PH rF2scFfgzeIgxosZZ5PH = default(rF2scFfgzeIgxosZZ5PH);
		nint num9 = default(nint);
		string text = default(string);
		global::System.Collections.IEnumerator enumerator = default(global::System.Collections.IEnumerator);
		int num11 = default(int);
		ProcessModule val2 = default(ProcessModule);
		int num14 = default(int);
		int num6 = default(int);
		int num8 = default(int);
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
					case 4:
						goto IL_004a;
					case 1:
						throw new global::System.Exception("此客户端版本尚未适配同进程换号");
					case 0:
						goto IL_07c8;
					case 3:
						if (!(((zG6ueUfuQUk6CEmxLYji)instance).ClientVersion != "1.21.120.0"))
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 1;
					case 2:
						return;
					}
					break;
				}
				switch (num2)
				{
				case 992:
					break;
				default:
					return;
				case 11:
					try
					{
						FileStream val = System.IO.File.OpenRead(((process).MainModule).FileName);
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num4 = 13;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num16 != 23)
								{
									if (num16 == 1003)
									{
										goto IL_00d9;
									}
									goto case 5;
								}
								System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian((global::System.Span<byte>)array, 24u);
								num4 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num4 = 6;
								}
								break;
							case 6:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(MemoryExtensions.AsSpan<byte>(array, 4), num15);
								num4 = 7;
								break;
							case 14:
							{
								num15 = KIAFMLfgmmKb9KvNAddq.yXafggvOo76(rF2scFfgzeIgxosZZ5PH.Window, out var _);
								num4 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
								{
									num4 = 23;
								}
								break;
							}
							case 1:
								num9 = rF2scFfgzeIgxosZZ5PH.oAbflXIgyFU("Chronal.Bedrock.AccountSwitch.dll");
								num4 = 2;
								break;
							case 3:
								throw new global::System.Exception("换号组件加载失败");
							case 5:
								rF2scFfgzeIgxosZZ5PH.grCflLEkhBi(text);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
								{
									num4 = 2;
								}
								break;
							case 9:
								array = new byte[24];
								num16 = 23;
								goto IL_00d9;
							case 10:
								num9 = rF2scFfgzeIgxosZZ5PH.oAbflXIgyFU("Chronal.Bedrock.AccountSwitch.dll");
								num4 = 4;
								break;
							case 15:
								text = v5efdgeS8yt();
								num4 = 10;
								break;
							case 13:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(MemoryExtensions.AsSpan<byte>(array, 16), ((V1NV4TfZ0HRmQ56BROEp)addresses).GilRelease);
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
								{
									num4 = 6;
								}
								break;
							case 4:
								if (num9 == 0)
								{
									num4 = 5;
									break;
								}
								goto case 2;
							case 12:
								try
								{
									while (true)
									{
										int num10;
										if (!(enumerator).MoveNext())
										{
											num10 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
											{
												num10 = 2;
											}
											goto IL_032a;
										}
										goto IL_0458;
										IL_032a:
										while (true)
										{
											switch (num10)
											{
											case 1:
												goto IL_0364;
											case 3:
												goto IL_03d9;
											case 0:
												goto end_IL_032a;
											case 2:
												goto IL_0458;
											case 4:
												goto end_IL_03f6;
											}
											if (num11 != 12)
											{
												if (num11 == 992)
												{
													goto IL_0326;
												}
												goto IL_0364;
											}
											if ((val2).BaseAddress != num9)
											{
												break;
											}
											num10 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
											{
												num10 = 9;
											}
											continue;
											IL_0364:
											if (string.Equals(System.IO.Path.GetFullPath((val2).FileName), System.IO.Path.GetFullPath(text), (StringComparison)5))
											{
												num10 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
												{
													num10 = 0;
												}
												continue;
											}
											goto IL_03d9;
											IL_03d9:
											throw new global::System.Exception("此实例已加载其他构建的换号组件");
											continue;
											end_IL_032a:
											break;
										}
										continue;
										IL_0326:
										num10 = num11;
										goto IL_032a;
										IL_0458:
										val2 = (ProcessModule)(enumerator).Current;
										int num12 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num12 = 12;
										}
										num11 = num12;
										goto IL_0326;
										continue;
										end_IL_03f6:
										break;
									}
								}
								finally
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									int num13 = 2;
									while (true)
									{
										switch (num13)
										{
										default:
											if (num14 == 990)
											{
												num13 = num14;
												continue;
											}
											goto case 2;
										case 2:
											if (disposable != null)
											{
												num13 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
												{
													num13 = 0;
												}
												continue;
											}
											break;
										case 0:
											(disposable).Dispose();
											num13 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
											{
												num13 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto case 14;
							case 8:
								if (rF2scFfgzeIgxosZZ5PH.MkIfljPfSJe(S7TvvYfg4lFMFZrHEXNd.RegisterAccount, array) != 0)
								{
									num4 = 11;
									break;
								}
								return;
							case 0:
								try
								{
									if ((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((Stream)(object)val)) != "EC4673BF6D0B128FECD3616012B8D26A2F40BCB26F1CD031C79DDFA12BA7F0F3"))
									{
										int num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
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
													goto IL_05bc;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_05bc:
											num5 = num6;
										}
										throw new global::System.Exception("客户端文件指纹未适配同进程换号");
									}
								}
								finally
								{
									if (val != null)
									{
										int num7 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
										{
											num7 = 7;
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
											case 1:
												(val).Dispose();
												num7 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
												{
													num7 = 0;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
								}
								goto case 15;
							case 7:
								System.Buffers.Binary.BinaryPrimitives.WriteUInt64LittleEndian(MemoryExtensions.AsSpan<byte>(array, 8), ((V1NV4TfZ0HRmQ56BROEp)addresses).GilEnsure);
								num4 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num4 = 21;
								}
								break;
							case 2:
								if (num9 != 0)
								{
									enumerator = ((process).Modules).GetEnumerator();
									num4 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
									{
										num4 = 17;
									}
								}
								else
								{
									num4 = 3;
								}
								break;
							case 11:
								{
									throw new global::System.Exception("客户端原生换号特征校验未通过");
								}
								IL_00d9:
								num4 = num16;
								break;
							}
						}
					}
					finally
					{
						if (rF2scFfgzeIgxosZZ5PH != null)
						{
							int num17 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num17 = 1;
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
									(rF2scFfgzeIgxosZZ5PH).Dispose();
									num17 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num17 = 6;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
				continue;
				IL_07c8:
				rF2scFfgzeIgxosZZ5PH = (rF2scFfgzeIgxosZZ5PH)new rF2scFfgzeIgxosZZ5PH((Process)process, (zG6ueUfuQUk6CEmxLYji)instance);
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
				{
					num = 10;
				}
				break;
				IL_004a:
				if ((((zG6ueUfuQUk6CEmxLYji)instance).ClientVersion != "3.9.20.299893"))
				{
					num = 3;
					break;
				}
				goto IL_07c8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string v5efdgeS8yt()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
							goto case 0;
						}
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						break;
					case 2:
						return;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
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
			num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool fJ3m8WZ3WKKlYiAafngl()
	{
		return MuIdGWZ3yIdn0gMaBU6E == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TWUx93fdAjVPkuNcHH9l to6T6AZ3J84wVdQ6XMyn()
	{
		return (TWUx93fdAjVPkuNcHH9l)MuIdGWZ3yIdn0gMaBU6E;
	}
}

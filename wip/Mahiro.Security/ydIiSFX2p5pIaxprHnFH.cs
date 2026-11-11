using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using nW2Sekfay3BSEMMb8toe;

namespace NyMcBcX2un6fyUtppdKq;

internal class ydIiSFX2p5pIaxprHnFH
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_65
	{
		public static __c_65 __9;

		public static Func<JsonElement, bool> __9__2_0;

		public static Func<JsonElement, bool> __9__3_0;

		public static Func<JsonElement, int> __9__3_1;

		public static Func<string, string> __9__4_0;

		public static Func<string, bool> __9__4_1;

		internal static __c_65 ypu53NDkwX0jE7QP8cC2;

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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 3:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 4;
							continue;
						case 1:
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							__9 = (__c_65)new __c_65();
							num = 11;
							break;
						case 0:
							num = 3;
							break;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_65()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool ekkLkFi0YH7(JsonElement module)
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Invalid comparison between Unknown and I4
			int num = 1;
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
							goto end_IL_0010;
						}
						goto case 0;
					case 1:
						if ((int)(module).ValueKind == 1)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num2 = 2;
							}
							break;
						}
						return false;
					case 0:
						return string.Equals(PZrX22C0bMO(module, "type"), "resources", (StringComparison)5);
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool q0TLks1PQgf(JsonElement item)
		{
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Invalid comparison between Unknown and I4
			int num = 1;
			int num3 = default(int);
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
						return (item).TryGetInt32(out num3);
					case 1:
						break;
					}
					goto IL_0041;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0041;
					IL_0041:
					if ((int)(item).ValueKind != 4)
					{
						return false;
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
					{
						num2 = 6;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int zZ2LkT4Fi8i(JsonElement item)
		{
			return (item).GetInt32();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string XR9LkNoYW5U(string value)
		{
			return ((value).Trim()).Trim((char[])(object)new HttpMethod[2]
			{
				(HttpMethod)47,
				(HttpMethod)92
			});
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool BFZLkM4K3pn(string value)
		{
			int num = 3;
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
					case 1:
						return !(value).Contains('\\');
					case 0:
						return false;
					case 3:
						if ((value).Length > 0)
						{
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
							{
								num2 = 2;
							}
							break;
						}
						goto case 0;
					case 2:
						if ((value).Contains('/'))
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num2 = 4;
							}
							break;
						}
						goto case 1;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fVbL6WDke8kuICffUDmX()
		{
			return ypu53NDkwX0jE7QP8cC2 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_65 Ul2XQPDkPcxLdGGZ65Fh()
		{
			return ypu53NDkwX0jE7QP8cC2;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass1_0_4
	{
		public string extractedPath;

		internal static __c__DisplayClass1_0_4 CeaFZHDkxoEL2H3cs7Bt;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass1_0_4()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool aUqLkpk0YBU(string path)
		{
			return pDLX2G1c7CO(extractedPath, path);
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
							return;
						case 0:
							num = 2;
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num = 9;
							}
							break;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool UacRmtDkF8sbZqHpyOAC()
		{
			return CeaFZHDkxoEL2H3cs7Bt == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass1_0_4 w8bBluDksn8MotLnrCCF()
		{
			return CeaFZHDkxoEL2H3cs7Bt;
		}
	}

	internal static object JiwdwsZxBmRHPqLeP1yX;

	[MethodImpl((MethodImplOptions)8)]
	internal static WQh695fa8bRtqyh4inIH EiyX2ag11Kg(object directoryPath, bool isEnabled, int priority, bool isPreset, global::System.Collections.Generic.IReadOnlyList<string>? excludedFolders = null)
	{
		//IL_0586: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0352: Invalid comparison between Unknown and I4
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0393: Unknown result type (might be due to invalid IL or missing references)
		//IL_04be: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		string text = default(string);
		string text3 = default(string);
		WQh695fa8bRtqyh4inIH result = default(WQh695fa8bRtqyh4inIH);
		int num5 = default(int);
		int num7 = default(int);
		string text2 = default(string);
		JsonElement val3 = default(JsonElement);
		string text4 = default(string);
		string text5 = default(string);
		Guid val2 = default(Guid);
		int num10 = default(int);
		int num12 = default(int);
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
							goto case 1;
						}
						throw new global::System.Exception("材质包根目录缺少 manifest.json");
					case 3:
						if (System.IO.File.Exists(text))
						{
							num3 = 4;
							continue;
						}
						num = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
						{
							num = 5;
						}
						break;
					case 2:
						text3 = System.IO.Path.GetFullPath((string)directoryPath);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						return result;
					case 4:
						try
						{
							JsonDocument val = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(text), default(JsonDocumentOptions));
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
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
										goto IL_0127;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0127:
								num4 = num5;
							}
							try
							{
								JsonElement root = (val).RootElement;
								int num6 = 3;
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 != 16)
										{
											if (num7 == 996)
											{
												goto IL_016e;
											}
											goto case 5;
										}
										text2 = ox9X2qCHuV0(PZrX22C0bMO(val3, "name", System.IO.Path.GetFileName(text3)));
										num6 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
										{
											num6 = 5;
										}
										continue;
									case 7:
										text4 = ox9X2qCHuV0(PZrX22C0bMO(val3, "description", "基岩版资源包"));
										num6 = 2;
										continue;
									case 0:
										throw new global::System.Exception("材质包 header.uuid 无效");
									case 5:
										throw new global::System.Exception("材质包 manifest.json 缺少 header");
									case 2:
										text5 = System.IO.Path.Combine(text3, "pack_icon.png");
										num6 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num6 = 1;
										}
										continue;
									case 4:
										if ((int)(val3).ValueKind == 1)
										{
											if (System.Guid.TryParse(PZrX22C0bMO(val3, "uuid"), out val2))
											{
												if (BujX23HRt43(root))
												{
													int num8 = 16;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
													{
														num8 = 4;
													}
													num7 = num8;
													goto IL_016e;
												}
												goto case 8;
											}
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
											{
												num6 = 9;
											}
											continue;
										}
										num6 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
										{
											num6 = 5;
										}
										continue;
									case 8:
										throw new global::System.Exception("材质包必须包含 type 为 resources 的模块");
									case 3:
										if ((root).TryGetProperty("header", out val3))
										{
											num6 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
											{
												num6 = 4;
											}
											continue;
										}
										goto case 5;
									case 1:
										result = (WQh695fa8bRtqyh4inIH)new WQh695fa8bRtqyh4inIH((val2).ToString("D"), string.IsNullOrWhiteSpace(text2) ? System.IO.Path.GetFileName(text3) : text2, string.IsNullOrWhiteSpace(text4) ? "基岩版资源包" : text4, lqlX2vofC6H(val3), text3, System.IO.File.Exists(text5) ? text5 : null, isEnabled, priority, isPreset, kyuX2EQ3wA9(excludedFolders));
										num6 = 6;
										continue;
									case 6:
										break;
										IL_016e:
										num6 = num7;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (val != null)
								{
									int num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
									{
										num9 = 2;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											if (num10 == 989)
											{
												num9 = num10;
												continue;
											}
											break;
										case 1:
											(val).Dispose();
											num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
											{
												num9 = 0;
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
						catch (JsonException ex)
						{
							JsonException ex2 = ex;
							int num11 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
							{
								num11 = 0;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 988)
									{
										goto IL_05b3;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_05b3:
								num11 = num12;
							}
							_ = "材质包 manifest.json 不是有效 JSON";
							throw ex2;
						}
						goto case 0;
					case 1:
						text = System.IO.Path.Combine(text3, "manifest.json");
						num = 3;
						break;
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
	internal unsafe static string ue9X21FkI2D(object extractedPath)
	{
		//IL_0180: Expected O, but got I
		//IL_028e->IL0255: Incompatible stack heights: 3 vs 1
		//IL_0299->IL0255: Incompatible stack heights: 3 vs 1
		int num = 3;
		int num4 = default(int);
		string result = default(string);
		string[] array = default(string[]);
		string text = default(string);
		__c__DisplayClass1_0_4 _c__DisplayClass1_0_ = default(__c__DisplayClass1_0_4);
		List<string> val = default(List<string>);
		int num6 = default(int);
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
						if (num2 != 26)
						{
							if (num2 == 1007)
							{
								goto end_IL_0010;
							}
							goto case 19;
						}
						num4 = 0;
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
						{
							num3 = 19;
						}
						continue;
					case 12:
						if (num4 == 0)
						{
							num3 = 9;
							continue;
						}
						goto case 11;
					case 14:
						result = array[0];
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 16;
						}
						continue;
					case 5:
					case 9:
						throw new global::System.Exception("未找到有效的基岩版材质包 manifest.json");
					case 15:
						throw new global::System.Exception("导入内容包含多个材质包，请分别导入");
					case 16:
						return result;
					case 11:
						if (num4 == 1)
						{
							num3 = 14;
							continue;
						}
						goto case 15;
					case 0:
						if (text != null)
						{
							num3 = 4;
							continue;
						}
						goto case 1;
					case 13:
					{
						global::System.Collections.Generic.IEnumerable<string> enumerable = System.IO.Directory.EnumerateFiles(_c__DisplayClass1_0_.extractedPath, "manifest.json", (SearchOption)1);
						val = (List<string>)(object)Enumerable.ToArray<string>(Enumerable.Where<string>((global::System.Collections.Generic.IEnumerable<string>)(object)_c__DisplayClass1_0_, new Func<string, bool>(__c__DisplayClass1_0_4.aUqLkpk0YBU)));
						array = (string[])enumerable;
						num = 26;
						break;
					}
					case 4:
						num3 = 6;
						continue;
					case 17:
						if (array == null)
						{
							num3 = 15;
							continue;
						}
						goto case 10;
					case 1:
						num4++;
						num = 7;
						break;
					case 6:
						try
						{
							EiyX2ag11Kg(text, isEnabled: false, 0, isPreset: false);
							int num5 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num5 = 1;
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
								case 1:
									_ = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
									{
										_ = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						catch (InvalidDataException)
						{
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
							{
								num7 = 0;
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
						goto case 1;
					case 10:
						num4 = array.Length;
						num3 = 12;
						continue;
					case 3:
						_c__DisplayClass1_0_ = (__c__DisplayClass1_0_4)new __c__DisplayClass1_0_4();
						num3 = 20;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						_c__DisplayClass1_0_.extractedPath = (string)extractedPath;
						num3 = 13;
						continue;
					case 8:
						text = System.IO.Path.GetDirectoryName(array[num4]);
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num3 = 0;
						}
						continue;
					case 7:
					case 18:
						if (num4 >= array.Length)
						{
							num = 19;
							break;
						}
						goto case 8;
					case 19:
						array = Enumerable.ToArray<string>(Enumerable.Distinct<string>((global::System.Collections.Generic.IEnumerable<string>)val, (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase));
						num3 = 17;
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
	private static bool BujX23HRt43(JsonElement root)
	{
		int num = 3;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static global::System.Collections.Generic.IReadOnlyList<int> lqlX2vofC6H(JsonElement header)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Collections.Generic.IReadOnlyList<string> kyuX2EQ3wA9(global::System.Collections.Generic.IReadOnlyList<string>? folders)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string PZrX22C0bMO(JsonElement element, object propertyName, string fallback = "")
	{
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		int num = 1;
		JsonElement val = default(JsonElement);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						text = fallback;
						goto IL_00e6;
					case 1:
						if (!(element).TryGetProperty((string)propertyName, out val))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 3;
					case 0:
					case 2:
						return fallback;
					case 3:
						{
							if ((int)(val).ValueKind == 3)
							{
								text = (val).GetString();
								if (text == null)
								{
									break;
								}
								goto IL_00e6;
							}
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
							{
								num3 = 9;
							}
							continue;
						}
						IL_00e6:
						return text;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ox9X2qCHuV0(object value)
	{
		int num = default(int);
		char c = (value).Chars;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool pDLX2G1c7CO(object rootPath, object filePath)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						return;
					case 0:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							num3 = 1;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
			{
				num = 7;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool hPfAV1ZxggWaKDrFG6qU()
	{
		return JiwdwsZxBmRHPqLeP1yX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ydIiSFX2p5pIaxprHnFH U5xBvyZxlHKq5sMiFH2Y()
	{
		return (ydIiSFX2p5pIaxprHnFH)JiwdwsZxBmRHPqLeP1yX;
	}
}

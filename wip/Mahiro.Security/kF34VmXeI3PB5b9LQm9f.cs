using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using dyVsfqXwqLxdTbSEAqwt;
using fDAldojjppXrctUVYOJn;

namespace XpsS9BXeBrTXsofVa1hH;

internal class kF34VmXeI3PB5b9LQm9f
{
	private static object gk0hV0Z6PeyGipwKHnDi;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool UTkXegSBwg6(object installationPath)
	{
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Invalid comparison between Unknown and I4
		int num = 1;
		int num4 = default(int);
		JsonDocument val = default(JsonDocument);
		int num8 = default(int);
		int num6 = default(int);
		JsonElement val3 = default(JsonElement);
		bool result = default(bool);
		int num11 = default(int);
		string text3 = default(string);
		string text2 = default(string);
		int num13 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					string text = kRFXeloI11N(installationPath, "Minecraft.Windows.exe");
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
					{
						num2 = 6;
					}
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							if (num4 != 24)
							{
								if (num4 == 1004)
								{
									goto IL_0082;
								}
								goto case 15;
							}
							try
							{
								JsonElement val2 = (val).RootElement;
								int num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
								{
									num5 = 4;
								}
								while (true)
								{
									int num9;
									int num7;
									switch (num5)
									{
									default:
										if (num8 != 12)
										{
											if (num8 == 992)
											{
												goto IL_031c;
											}
											goto case 1;
										}
										goto IL_03fe;
									case 3:
										num9 = ((num6 == 1) ? 1 : 0);
										break;
									case 4:
										if ((val2).TryGetProperty("no_launch_mcp", out val3))
										{
											num7 = 1;
											goto IL_0318;
										}
										goto IL_03fe;
									case 1:
										if ((int)(val3).ValueKind == 4)
										{
											num5 = 2;
											continue;
										}
										goto IL_03fe;
									case 2:
										if (!(val3).TryGetInt32(out num6))
										{
											num7 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
											{
												num7 = 7;
											}
											goto IL_0318;
										}
										goto case 3;
									case 0:
										goto end_IL_0320;
										IL_031c:
										num5 = num8;
										continue;
										IL_03fe:
										num9 = 0;
										break;
										IL_0318:
										num8 = num7;
										goto IL_031c;
									}
									result = (byte)num9 != 0;
									num5 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
									{
										num5 = 0;
									}
									continue;
									end_IL_0320:
									break;
								}
							}
							finally
							{
								if (val != null)
								{
									int num10 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
									{
										num10 = 0;
									}
									while (true)
									{
										switch (num10)
										{
										default:
											if (num11 == 989)
											{
												num10 = num11;
												continue;
											}
											break;
										case 0:
											break;
										case 1:
											goto end_IL_045d;
										}
										(val).Dispose();
										num10 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num10 = 1;
										}
										continue;
										end_IL_045d:
										break;
									}
								}
							}
							break;
						case 3:
							if (!System.IO.File.Exists(text))
							{
								num2 = 4;
								continue;
							}
							goto case 16;
						case 9:
							result = false;
							num2 = 2;
							continue;
						case 1:
							text3 = kRFXeloI11N(installationPath, "data/vanilla.mcp");
							num3 = 3;
							goto IL_007e;
						case 11:
							if ((text3).Length != 0L)
							{
								num2 = 10;
								continue;
							}
							goto case 6;
						case 5:
							val = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(text2), default(JsonDocumentOptions));
							num3 = 24;
							goto IL_007e;
						case 12:
							if (!System.IO.File.Exists(text2))
							{
								num2 = 9;
								continue;
							}
							goto case 5;
						case 0:
							break;
						case 6:
						case 14:
							result = false;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								num2 = 7;
							}
							continue;
						case 4:
						case 13:
							result = false;
							num2 = 7;
							continue;
						case 2:
							break;
						case 8:
						case 10:
							text2 = kRFXeloI11N(installationPath, "data/client_cfg.json");
							num2 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num2 = 12;
							}
							continue;
						case 16:
							if ((text).Length < 10485760)
							{
								num2 = 13;
								continue;
							}
							goto case 15;
						case 15:
							if (!System.IO.File.Exists(text3))
							{
								num3 = 6;
								goto IL_007e;
							}
							goto case 11;
						case 7:
							break;
							IL_007e:
							num4 = num3;
							goto IL_0082;
							IL_0082:
							num2 = num4;
							continue;
						}
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num12 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
					{
						num12 = 6;
					}
					while (true)
					{
						switch (num12)
						{
						default:
							if (num13 == 989)
							{
								num12 = num13;
								continue;
							}
							break;
						case 1:
							result = false;
							num12 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								num12 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string kRFXeloI11N(object installationPath, object relativePath)
	{
		return SYUagtXw2B6wGlhI1DG3.C4tXwndefmY(installationPath, relativePath);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
						{
							num3 = 8;
						}
						continue;
					case 0:
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool l5bgkWZ6xhqm77BKdraa()
	{
		return gk0hV0Z6PeyGipwKHnDi == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static kF34VmXeI3PB5b9LQm9f StPNybZ6FvvtuTvuZrts()
	{
		return (kF34VmXeI3PB5b9LQm9f)gk0hV0Z6PeyGipwKHnDi;
	}
}

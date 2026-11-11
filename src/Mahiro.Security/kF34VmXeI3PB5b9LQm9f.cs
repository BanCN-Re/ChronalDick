using System;
using System.IO;
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
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Invalid comparison between Unknown and I4
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
												goto IL_0324;
											}
											goto case 1;
										}
										goto IL_0406;
									case 3:
										num9 = ((num6 == 1) ? 1 : 0);
										break;
									case 4:
										if ((val2).TryGetProperty("no_launch_mcp", out val3))
										{
											num7 = 1;
											goto IL_0320;
										}
										goto IL_0406;
									case 1:
										if ((int)(val3).ValueKind == 4)
										{
											num5 = 2;
											continue;
										}
										goto IL_0406;
									case 2:
										if (!(val3).TryGetInt32(out num6))
										{
											num7 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
											{
												num7 = 7;
											}
											goto IL_0320;
										}
										goto case 3;
									case 0:
										goto end_IL_0328;
										IL_0324:
										num5 = num8;
										continue;
										IL_0406:
										num9 = 0;
										break;
										IL_0320:
										num8 = num7;
										goto IL_0324;
									}
									result = (byte)num9 != 0;
									num5 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
									{
										num5 = 0;
									}
									continue;
									end_IL_0328:
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
											goto end_IL_0465;
										}
										(val).Dispose();
										num10 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
										{
											num10 = 1;
										}
										continue;
										end_IL_0465:
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
							if ((new FileInfo(text3)).Length != 0L)
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
							if ((new FileInfo(text)).Length < 10485760)
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

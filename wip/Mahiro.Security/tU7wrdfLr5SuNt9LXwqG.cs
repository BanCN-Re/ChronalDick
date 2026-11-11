using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Cv9y45Xq94mXv2Y5ae7L;
using EgXnfafZ2mjsaPfJxiCB;
using HN5yyEfpz8TLMVS2CfPf;
using KBx9lafY6LvYfHSvsVm4;
using KqsWiGXnXE3yfOjhGTJe;
using KyrneTXOjI67ChfCkaOP;
using LZKvU9ox950cc34tDpH;
using MWciMsXqgRcoiTZlBKAW;
using VS10M0X1DU7odDvB9xDR;
using fDAldojjppXrctUVYOJn;
using fhwgR7X1fg8wtATQ636A;
using htRZSkfbXu6AOwyRjCEw;

namespace vIVVIkfLoeccvMakd3lS;

public sealed class tU7wrdfLr5SuNt9LXwqG
{
	internal static object R1DpqvZTJ5yqmfaOooZd;

	[MethodImpl((MethodImplOptions)8)]
	public int Start(xssD3cfpnxdefR05FuDD installation, string? configPath = null)
	{
		int num = 2;
		Process val = default(Process);
		int result = default(int);
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
					goto IL_0021;
				case 2:
					val = tkAfLm2ClEu(installation, configPath);
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					try
					{
						result = (val).Id;
						int num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
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
						int num5;
						if (val == null)
						{
							num5 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num5 = 0;
							}
							goto IL_00fa;
						}
						goto IL_011e;
						IL_00fa:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_00f6;
								}
								goto end_IL_00fa;
							case 2:
								break;
							case 0:
								goto end_IL_00fa;
							case 1:
								goto end_IL_00fa;
							}
							goto IL_011e;
							IL_00f6:
							num5 = num6;
							continue;
							end_IL_00fa:
							break;
						}
						goto end_IL_00c2;
						IL_011e:
						(val).Dispose();
						num5 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num5 = 1;
						}
						goto IL_00fa;
						end_IL_00c2:;
					}
					break;
				case 0:
					break;
				}
				goto IL_0178;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0178;
				IL_0178:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe Process tkAfLm2ClEu(xssD3cfpnxdefR05FuDD installation, string? configPath = null, string? errorLogPath = null, aH8OktfZE5UfKgZLYDFf? optionsRedirect = null, LyhYIeXqZljYNCRRk2o9? mcpPatchDeployment = null, vVvXkmoPrInbUIFEyf5? authorization = null)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string EGcfL7tBXHZ(object name, object path)
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 2:
					throw new global::System.Exception("基岩版启动参数路径包含无效字符");
				case 0:
					return string.Concat((string)name, "=\"", RjJcojfY55sN0GqYZJag.ToAsciiPath(path), "\"");
				case 1:
					if (!(path).Contains('"', (StringComparison)4))
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string IrmfLA6AK6w(object workingDirectory, string? inheritedPath)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public tU7wrdfLr5SuNt9LXwqG()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
						switch (num2)
						{
						case 990:
							break;
						case 9:
							goto IL_0068;
						default:
							goto end_IL_000e;
						}
						break;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 2:
						goto end_IL_000e;
						IL_0068:
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool pXkomyZTQ3wvBlbmfRx7()
	{
		return R1DpqvZTJ5yqmfaOooZd == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static tU7wrdfLr5SuNt9LXwqG HMIIjbZTCx2JvM2ChkDv()
	{
		return (tU7wrdfLr5SuNt9LXwqG)R1DpqvZTJ5yqmfaOooZd;
	}
}

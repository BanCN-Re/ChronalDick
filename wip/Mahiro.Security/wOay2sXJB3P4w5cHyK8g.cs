using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace sUXP8NXJgRXbRBc7QCg0;

internal class wOay2sXJB3P4w5cHyK8g
{
	internal static object wW0dG8Zdy256tY41MpE8;

	[MethodImpl((MethodImplOptions)8)]
	internal static string? xwKXJlfLbqg(object line, int targetPid)
	{
		int num = 36;
		string result = default(string);
		int num4 = default(int);
		string text = default(string);
		Match val = default(Match);
		char c = default(char);
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
						if (num2 != 79)
						{
							if (num2 == 1060)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto IL_02af;
					case 56:
						result = "代理所需的方法或字段解析失败，本地连接未开放。";
						num3 = 55;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
						{
							num3 = 64;
						}
						continue;
					case 58:
						switch (num4)
						{
						case 16:
							goto IL_0296;
						case 10:
						case 12:
						case 13:
						case 17:
							goto IL_02af;
						case 9:
							goto IL_0580;
						case 18:
							goto IL_063c;
						case 14:
							goto IL_0693;
						case 8:
							goto IL_06c9;
						case 11:
							goto IL_08da;
						case 15:
							goto IL_09a0;
						}
						num3 = 64;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 31;
						}
						continue;
					case 4:
					case 9:
					case 12:
					case 14:
					case 15:
					case 23:
					case 30:
					case 33:
					case 46:
					case 49:
					case 55:
					case 57:
						return result;
					case 44:
						result = "本地代理监听启动失败，请检查端口占用及组件日志。";
						num3 = 12;
						continue;
					case 31:
						if (!(text == "minecraft"))
						{
							num3 = 19;
							continue;
						}
						goto case 70;
					case 1:
						if (text != null)
						{
							num3 = 16;
							continue;
						}
						goto IL_02af;
					case 65:
						goto IL_0296;
					case 3:
					case 5:
					case 6:
					case 7:
					case 11:
					case 19:
					case 40:
					case 48:
					case 53:
					case 59:
					case 61:
					case 62:
					case 63:
					case 64:
					case 69:
						goto IL_02af;
					case 26:
						if (((((val).Groups).Item).Value != (targetPid).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture)))
						{
							num3 = 38;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num3 = 71;
							}
							continue;
						}
						text = (((val).Groups).Item).Value;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num3 = 23;
						}
						continue;
					case 27:
						if ((text == "main-gate"))
						{
							num3 = 45;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto IL_02af;
					case 51:
						if (c != 'h')
						{
							num3 = 22;
							continue;
						}
						goto case 21;
					case 22:
						if (c != 'l')
						{
							num = 6;
							break;
						}
						goto case 50;
					case 36:
						val = System.Text.RegularExpressions.Regex.Match((string)line, "^\\[组件日志 PID (\\d+)\\] \\[\\d+\\] START-FAILED: stage=([a-z-]+)$", (RegexOptions)512);
						num3 = 35;
						continue;
					case 39:
						if (c != 'e')
						{
							num3 = 72;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 29;
							}
							continue;
						}
						goto case 31;
					case 71:
						if ((text == "cancelled"))
						{
							num3 = 66;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
							{
								num3 = 23;
							}
							continue;
						}
						goto IL_02af;
					case 24:
					case 45:
						result = "无法建立兼容客户端连接前的游戏等待任务。";
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
						{
							num3 = 28;
						}
						continue;
					case 20:
					case 66:
						result = "游戏窗口中的取消操作已中止本次初始化。";
						num3 = 46;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
						{
							num3 = 5;
						}
						continue;
					case 10:
					case 13:
						result = "游戏连接桥初始化失败。";
						num3 = 49;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 26;
						}
						continue;
					case 18:
						goto IL_0580;
					case 38:
					case 42:
						return null;
					case 43:
						if (!(text == "network-bindings"))
						{
							goto IL_02af;
						}
						num3 = 28;
						continue;
					case 2:
						goto IL_063c;
					case 25:
						goto IL_0693;
					case 41:
						goto IL_06c9;
					case 54:
						if (c != 'c')
						{
							num3 = 39;
							continue;
						}
						goto case 71;
					case 32:
						if (c != 'r')
						{
							num3 = 40;
							continue;
						}
						goto case 8;
					case 35:
						if (!(val).Success)
						{
							num3 = 42;
							continue;
						}
						goto case 26;
					case 16:
						num4 = (text).Length;
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
						{
							num3 = 58;
						}
						continue;
					case 70:
						result = "等待游戏初始化失败或超时，尚未开放本地连接。";
						num3 = 15;
						continue;
					case 50:
						if ((text == "local-frame"))
						{
							num3 = 17;
							continue;
						}
						goto IL_02af;
					case 28:
					case 37:
						result = "网络连接类的方法或字段未准备完成，重试后仍无法初始化代理。";
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 40;
						}
						continue;
					case 8:
						if (!(text == "readiness-signal"))
						{
							num3 = 48;
							continue;
						}
						goto case 67;
					case 72:
						if (c != 'n')
						{
							num = 3;
							break;
						}
						goto case 27;
					case 21:
						if (!(text == "hook-bridge"))
						{
							goto IL_02af;
						}
						num3 = 10;
						continue;
					case 68:
						goto IL_08da;
					case 52:
						if (c != 'n')
						{
							num3 = 32;
							continue;
						}
						goto case 43;
					case 17:
					case 47:
						result = "JVM 无法分配初始化所需的本地引用空间。";
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							num3 = 14;
						}
						continue;
					case 0:
					case 60:
						result = "无法获取目标游戏的网络连接。";
						num3 = 36;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
						{
							num3 = 57;
						}
						continue;
					case 29:
						goto IL_09a0;
					case 67:
						result = "组件无法发布初始化完成状态。";
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
						{
							num3 = 44;
						}
						continue;
					case 34:
						{
							result = "游戏连接 Hook 安装失败，请查看日志中的 JVM 错误码。";
							num3 = 30;
							continue;
						}
						IL_08da:
						c = (text).Chars;
						num3 = 51;
						continue;
						IL_06c9:
						if (!(text == "listener"))
						{
							num = 79;
							break;
						}
						goto case 44;
						IL_0296:
						c = (text).Chars;
						num = 52;
						break;
						IL_0693:
						if (!(text == "proxy-bindings"))
						{
							num3 = 53;
							continue;
						}
						goto case 56;
						IL_063c:
						if (!(text == "capture-connection"))
						{
							goto IL_02af;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num3 = 10;
						}
						continue;
						IL_0580:
						c = (text).Chars;
						num3 = 76;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 54;
						}
						continue;
						IL_09a0:
						if (!(text == "connection-hook"))
						{
							num = 5;
							break;
						}
						goto case 34;
						IL_02af:
						result = "Native 初始化失败，详细原因已记录到日志文件。";
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 33;
						}
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
					case 2:
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num3 = 2;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool X3GbMaZdW2CSOfwSqsSh()
	{
		return wW0dG8Zdy256tY41MpE8 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static wOay2sXJB3P4w5cHyK8g GWK04tZdJppuGlb767fD()
	{
		return (wOay2sXJB3P4w5cHyK8g)wW0dG8Zdy256tY41MpE8;
	}
}

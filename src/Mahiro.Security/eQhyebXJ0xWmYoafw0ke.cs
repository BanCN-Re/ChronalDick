using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ATleGtXJDvEfFHraXwiw;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using qpWY8ZXJWVEkufD4WDTK;
using ulWEeSXJc4vaaHfwS6DF;
using xAceLqXWMytQDox0p5bJ;
using ydijFbXJjsm9K5ZGLW2Q;

namespace vWBE4sXJ8HCZBMol0gVm;

internal class eQhyebXJ0xWmYoafw0ke
{
	private delegate bool qfNuvsLbgYCwp9OpLBtf(nint window, nint parameter);

	[CompilerGenerated]
	private sealed class __c__DisplayClass0_0_2
	{
		public Dictionary<int, HTA2r6XWNKDt09pf0WBJ> candidates;

		public global::System.Exception inspectionError;

		private static __c__DisplayClass0_0_2 Gd72KX9sPPKachiPi2oL;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass0_0_2()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _FindTarget_b__0(nint window, nint _)
		{
			//IL_0333: Expected O, but got Unknown
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_043f: Expected O, but got Unknown
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Expected O, but got Unknown
			int num = 4;
			StringBuilder val = default(StringBuilder);
			int processId = default(int);
			int num5 = default(int);
			int num7 = default(int);
			HTA2r6XWNKDt09pf0WBJ hTA2r6XWNKDt09pf0WBJ = default(HTA2r6XWNKDt09pf0WBJ);
			int num9 = default(int);
			int num11 = default(int);
			int num13 = default(int);
			int num15 = default(int);
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
								goto case 4;
							}
							val = new StringBuilder(512);
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num3 = 6;
							}
							continue;
						case 6:
							if (GetWindowText(window, val, (val).Capacity) != 0)
							{
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 3;
						case 0:
							try
							{
								Process val2 = System.Diagnostics.Process.GetProcessById(processId);
								int num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 == 989)
										{
											goto IL_00c6;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_00ca;
									}
									try
									{
										int num6;
										if (!IsJavaName((val2).ProcessName))
										{
											num6 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
											{
												num6 = 0;
											}
											goto IL_0132;
										}
										goto IL_01cb;
										IL_0132:
										while (true)
										{
											switch (num6)
											{
											default:
												if (num7 != 11)
												{
													if (num7 == 991)
													{
														goto IL_012e;
													}
													goto case 2;
												}
												candidates[processId] = hTA2r6XWNKDt09pf0WBJ;
												num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
												{
													num6 = 6;
												}
												continue;
											case 0:
												goto end_IL_0132;
											case 2:
												if ((object)hTA2r6XWNKDt09pf0WBJ != null)
												{
													num7 = 11;
													goto IL_012e;
												}
												goto end_IL_0132;
											case 3:
												break;
											case 1:
												goto end_IL_0132;
												IL_012e:
												num6 = num7;
												continue;
											}
											goto IL_01cb;
											continue;
											end_IL_0132:
											break;
										}
										goto end_IL_00eb;
										IL_01cb:
										hTA2r6XWNKDt09pf0WBJ = QPVtaYXJyNOQIs30qeoH.Read(processId);
										num6 = 2;
										goto IL_0132;
										end_IL_00eb:;
									}
									finally
									{
										if (val2 != null)
										{
											int num8 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
											{
												num8 = 0;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 == 989)
													{
														num8 = num9;
														continue;
													}
													break;
												case 0:
													(val2).Dispose();
													num8 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
													{
														num8 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
									}
									break;
									IL_00c6:
									num4 = num5;
									continue;
									end_IL_00ca:
									break;
								}
							}
							catch (ArgumentException)
							{
								int num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
								{
									num10 = 0;
								}
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 988)
										{
											num10 = num11;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							catch (InvalidOperationException)
							{
								int num12 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
								{
									num12 = 0;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										if (num13 == 988)
										{
											num12 = num13;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							catch (Win32Exception ex3)
							{
								Win32Exception ex4 = ex3;
								int num14 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
								{
									num14 = 7;
								}
								while (true)
								{
									switch (num14)
									{
									default:
										if (num15 == 989)
										{
											num14 = num15;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0364;
									}
									global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(54, 2);
									(defaultInterpolatedStringHandler).AppendLiteral("无法检查匹配游戏窗口的进程（PID ");
									defaultInterpolatedStringHandler.AppendFormatted<int>(processId);
									(defaultInterpolatedStringHandler).AppendLiteral("，系统错误 ");
									defaultInterpolatedStringHandler.AppendFormatted<int>((ex4).NativeErrorCode);
									(defaultInterpolatedStringHandler).AppendLiteral("）。请确认 Chronal 与指定启动器使用相同的运行权限。");
									inspectionError = (global::System.Exception)new InvalidOperationException((defaultInterpolatedStringHandler).ToStringAndClear(), (global::System.Exception)(object)ex4);
									num14 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
									{
										num14 = 5;
									}
									continue;
									end_IL_0364:
									break;
								}
							}
							goto case 5;
						case 3:
							return true;
						case 5:
							return true;
						case 4:
							if (IsWindowVisible(window))
							{
								break;
							}
							goto case 1;
						case 2:
							if (((val).ToString()).Contains("布吉岛", (StringComparison)4))
							{
								GetWindowThreadProcessId(window, out processId);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
								{
									num3 = 3;
								}
							}
							else
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
								{
									num3 = 3;
								}
							}
							continue;
						case 1:
							return true;
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
				num = 13;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
				{
					num = 1;
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
		internal static bool cBmXMU9sxid7AIna2Obk()
		{
			return Gd72KX9sPPKachiPi2oL == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass0_0_2 ajyR9t9sFHpWmaEbuUDL()
		{
			return Gd72KX9sPPKachiPi2oL;
		}
	}

	internal static object RQ5ND3ZdLu4YoBp0uLdX;

	[MethodImpl((MethodImplOptions)8)]
	internal static HTA2r6XWNKDt09pf0WBJ? FindTarget(Action<string>? reportDiagnostic = null)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsAlive(object target)
	{
		//IL_0187: Expected O, but got Unknown
		//IL_030f: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		bool result = default(bool);
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			default:
				try
				{
					result = QPVtaYXJyNOQIs30qeoH.Read(((HTA2r6XWNKDt09pf0WBJ)target).ProcessId) == target;
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (ArgumentException)
				{
					int num4 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
					{
						num4 = 6;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 989)
							{
								num4 = num5;
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							goto end_IL_00c5;
						}
						result = false;
						num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num4 = 0;
						}
						continue;
						end_IL_00c5:
						break;
					}
				}
				catch (InvalidOperationException)
				{
					int num6 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num6 = 6;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (num7 == 989)
							{
								num6 = num7;
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							goto end_IL_013e;
						}
						result = false;
						num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num6 = 7;
						}
						continue;
						end_IL_013e:
						break;
					}
				}
				catch (Win32Exception ex3)
				{
					Win32Exception ex4 = ex3;
					int num8 = 9;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
					{
						num8 = 0;
					}
					while (true)
					{
						int num10;
						switch (num8)
						{
						default:
							if (num9 != 13)
							{
								if (num9 != 993)
								{
									break;
								}
								goto IL_01b4;
							}
							defaultInterpolatedStringHandler.AppendFormatted<int>((ex4).NativeErrorCode);
							num8 = 2;
							continue;
						case 0:
							defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(51, 2);
							num10 = 4;
							goto IL_01b0;
						case 2:
							(defaultInterpolatedStringHandler).AppendLiteral("）。请确认 Chronal 与指定启动器使用相同的运行权限。");
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
							{
								num8 = 4;
							}
							continue;
						case 4:
							(defaultInterpolatedStringHandler).AppendLiteral("无法核对目标游戏进程（PID ");
							num8 = 3;
							continue;
						case 5:
							(defaultInterpolatedStringHandler).AppendLiteral("，系统错误 ");
							num10 = 13;
							goto IL_01b0;
						case 3:
							defaultInterpolatedStringHandler.AppendFormatted<int>(((HTA2r6XWNKDt09pf0WBJ)target).ProcessId);
							num8 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num8 = 5;
							}
							continue;
						case 1:
							break;
							IL_01b4:
							num8 = num9;
							continue;
							IL_01b0:
							num9 = num10;
							goto IL_01b4;
						}
						break;
					}
					throw new InvalidOperationException((defaultInterpolatedStringHandler).ToStringAndClear(), (global::System.Exception)(object)ex4);
				}
				break;
			case 0:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsJavaName(object name)
	{
		int num = 2;
		return default(bool);
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool EnumWindows(qfNuvsLbgYCwp9OpLBtf callback, nint parameter);

	[DllImport("user32.dll")]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool IsWindowVisible(nint window);

	[DllImport("user32.dll", CharSet = (CharSet)3, EntryPoint = "GetWindowTextW")]
	private static extern int GetWindowText(nint window, StringBuilder title, int count);

	[DllImport("user32.dll")]
	private static extern uint GetWindowThreadProcessId(nint window, out int processId);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jNDdcEZdjIQyAtW9J4iS()
	{
		return RQ5ND3ZdLu4YoBp0uLdX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static eQhyebXJ0xWmYoafw0ke osrUZMZdZ3RiM14VXAJX()
	{
		return (eQhyebXJ0xWmYoafw0ke)RQ5ND3ZdLu4YoBp0uLdX;
	}
}

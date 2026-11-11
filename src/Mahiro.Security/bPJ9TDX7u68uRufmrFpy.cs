using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace ewdqsiX7aGTq6iu2bF43;

internal class bPJ9TDX7u68uRufmrFpy
{
	internal static object poLXTyZtaTOb5upXLdWY;

	[MethodImpl((MethodImplOptions)8)]
	internal static void E7ZX71YulOv()
	{
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		int num8 = default(int);
		Process[] array = default(Process[]);
		Process val2 = default(Process);
		Process val = default(Process);
		string[] array2 = default(string[]);
		int num9 = default(int);
		int num5 = default(int);
		int num7 = default(int);
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
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						goto case 10;
					case 9:
					case 11:
						if (num8 >= array.Length)
						{
							num3 = 8;
							continue;
						}
						goto case 5;
					case 13:
						val2 = val;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						array2 = new string[3]
						{
							"FeverGamesInstaller",
							"FeverGamesLauncher",
							"FeverGamesWeb"
						};
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 3;
						}
						continue;
					case 0:
					case 7:
						if (num9 < array2.Length)
						{
							num = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num = 1;
							}
							break;
						}
						return;
					case 2:
						num8 = 0;
						num = 9;
						break;
					case 8:
						num9++;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						val = array[num8];
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 16;
						}
						continue;
					case 6:
						try
						{
							if (!(val).HasExited)
							{
								int num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
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
											goto IL_0212;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_0212:
									num4 = num5;
								}
								throw new InvalidOperationException("请先退出发烧游戏平台，再启动经典版；不会代为关闭其他程序");
							}
						}
						finally
						{
							int num6;
							if (val2 == null)
							{
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
								{
									num6 = 7;
								}
								goto IL_0290;
							}
							goto IL_02b4;
							IL_0290:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_028c;
									}
									goto end_IL_0290;
								case 2:
									break;
								case 0:
									goto end_IL_0290;
								case 1:
									goto end_IL_0290;
								}
								goto IL_02b4;
								IL_028c:
								num6 = num7;
								continue;
								end_IL_0290:
								break;
							}
							goto end_IL_0258;
							IL_02b4:
							(val2).Dispose();
							num6 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								num6 = 1;
							}
							goto IL_0290;
							end_IL_0258:;
						}
						goto case 12;
					case 12:
						num8++;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						num9 = 0;
						num3 = 7;
						continue;
					case 1:
						return;
					case 10:
						array = System.Diagnostics.Process.GetProcessesByName(array2[num9]);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							num3 = 2;
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
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<Process> uRdX73XNKyy(object installationPath, object api, long user, CancellationToken token)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_StartAsync_d__1 startAsync_d__ = default(_StartAsync_d__1);
		startAsync_d__.__t__builder = AsyncTaskMethodBuilder<Process>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool QDYQNdZt1NJc4viSMJ1l()
	{
		return poLXTyZtaTOb5upXLdWY == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bPJ9TDX7u68uRufmrFpy TEDecZZt3xtLn9ov8Bos()
	{
		return (bPJ9TDX7u68uRufmrFpy)poLXTyZtaTOb5upXLdWY;
	}
}

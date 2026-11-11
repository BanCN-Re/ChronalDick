using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using IDSiJKXQpP3Po0oBGWYA;
using fDAldojjppXrctUVYOJn;

namespace EntQbgXmVpZYxE1aMrVr;

internal sealed class lb0ds9XmkTqdx7OLHbev : UiXScuXQMQ7WOIWCBA6v
{
	internal static object HLPlRcZtLKyPwn9YkQNW;

	[MethodImpl((MethodImplOptions)8)]
	public DateTimeOffset? k3ML45pjEfI(int processId)
	{
		int num = 3;
		DateTimeOffset? val = default(DateTimeOffset?);
		int num5 = default(int);
		global::System.DateTime dateTime = default(global::System.DateTime);
		int num8 = default(int);
		int num10 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		bool flag = default(bool);
		int num13 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num15 = default(int);
		DateTimeOffset? val3 = default(DateTimeOffset?);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return val;
					case 0:
						return val;
					case 2:
						break;
					case 1:
						try
						{
							Process val2 = System.Diagnostics.Process.GetProcessById(processId);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
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
										goto IL_0096;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0096:
								num4 = num5;
							}
							try
							{
								int num6;
								if ((val2).HasExited)
								{
									num6 = 3;
									goto IL_00e4;
								}
								goto IL_0141;
								IL_0141:
								dateTime = (val2).StartTime;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num6 = 10;
								}
								goto IL_00e4;
								IL_00e4:
								while (true)
								{
									switch (num6)
									{
									default:
										if (num8 != 12)
										{
											if (num8 != 992)
											{
												break;
											}
											goto IL_00e0;
										}
										val = val;
										num6 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
										{
											num6 = 0;
										}
										continue;
									case 2:
										break;
									case 0:
										goto end_IL_00e4;
									case 1:
										val = (DateTimeOffset?)(dateTime).ToUniversalTime();
										num6 = 4;
										continue;
									case 3:
									{
										val = null;
										int num7 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num7 = 5;
										}
										num8 = num7;
										goto IL_00e0;
									}
									case 4:
										goto end_IL_00e4;
										IL_00e0:
										num6 = num8;
										continue;
									}
									goto IL_0141;
									continue;
									end_IL_00e4:
									break;
								}
							}
							finally
							{
								int num9;
								if (val2 == null)
								{
									num9 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
									{
										num9 = 6;
									}
									goto IL_0210;
								}
								goto IL_0258;
								IL_0210:
								while (true)
								{
									switch (num9)
									{
									default:
										if (num10 == 990)
										{
											goto IL_020c;
										}
										break;
									case 2:
										goto end_IL_0210;
									case 0:
										break;
									case 1:
										goto end_IL_0210;
									}
									goto IL_0258;
									IL_020c:
									num9 = num10;
									continue;
									end_IL_0210:
									break;
								}
								goto end_IL_01d8;
								IL_0258:
								(val2).Dispose();
								num9 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
								{
									num9 = 8;
								}
								goto IL_0210;
								end_IL_01d8:;
							}
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num11 = 8;
								goto IL_02a4;
							}
							ex = obj2;
							num12 = 3;
							goto IL_02ac;
							IL_0321:
							flag = true;
							num11 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num11 = 13;
							}
							goto IL_02a4;
							IL_0392:
							if (!(ex is Win32Exception))
							{
								num11 = 5;
								goto IL_02a4;
							}
							goto IL_0321;
							IL_02a4:
							num13 = num11;
							goto IL_02a8;
							IL_02a8:
							num12 = num13;
							goto IL_02ac;
							IL_02ac:
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 != 16)
									{
										if (num13 == 996)
										{
											goto IL_02a8;
										}
										goto case 5;
									}
									goto case 6;
								case 5:
									if (ex is NotSupportedException)
									{
										num12 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
										{
											num12 = 4;
										}
										continue;
									}
									goto case 0;
								case 1:
								case 7:
									break;
								case 3:
									if (ex is ArgumentException)
									{
										num12 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
										{
											num12 = 6;
										}
										continue;
									}
									goto case 4;
								case 2:
									goto IL_0392;
								case 4:
									if (!(ex is InvalidOperationException))
									{
										num12 = 2;
										continue;
									}
									break;
								case 0:
									flag = false;
									num12 = 6;
									continue;
								case 8:
									result = 0;
									goto IL_03f1;
								case 6:
									{
										result = (flag ? 1 : 0);
										goto IL_03f1;
									}
									IL_03f1:
									return (byte)result != 0;
								}
								break;
							}
							goto IL_0321;
						}).Invoke())
						{
							int num14 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num14 = 2;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 990)
									{
										num14 = num15;
										continue;
									}
									goto case 1;
								case 1:
									val = val3;
									num14 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
									{
										num14 = 3;
									}
									continue;
								case 2:
									val3 = null;
									num14 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
									{
										num14 = 1;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 0;
					case 3:
						if (processId <= 0)
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 5;
							}
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
			val = null;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public lb0ds9XmkTqdx7OLHbev()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
					case 2:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
						{
							num3 = 2;
						}
						continue;
					case 0:
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GMSh7ZZtjI7kymCiqD6T()
	{
		return HLPlRcZtLKyPwn9YkQNW == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lb0ds9XmkTqdx7OLHbev MUXRvxZtZo3dSit54VRy()
	{
		return (lb0ds9XmkTqdx7OLHbev)HLPlRcZtLKyPwn9YkQNW;
	}
}

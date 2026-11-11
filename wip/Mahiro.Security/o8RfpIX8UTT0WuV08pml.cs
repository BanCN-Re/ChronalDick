using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using MFxNUqX8hOl3sAOFgc40;
using YNmAdkXtWdqCX5luaOfN;
using fDAldojjppXrctUVYOJn;

namespace f36QYiX8rlOmVQX2FKg6;

internal sealed class o8RfpIX8UTT0WuV08pml : InvalidOperationException
{
	[CompilerGenerated]
	private readonly lwQLqMX84V4jjpZyRJiH IihX87gS7tm;

	[CompilerGenerated]
	private readonly byte fI7X8A7PvWI;

	private static object dwgULPZgxJgxbIRZgxbI;

	internal lwQLqMX84V4jjpZyRJiH Stage
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return IihX87gS7tm;
		}
	}

	internal byte Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return fI7X8A7PvWI;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe o8RfpIX8UTT0WuV08pml(lwQLqMX84V4jjpZyRJiH stage, byte status)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		_ = defaultInterpolatedStringHandler;
		_ = 16;
		_ = 2;
		(defaultInterpolatedStringHandler).AppendLiteral("Java 认证");
		(defaultInterpolatedStringHandler).AppendFormatted(tCCX8mIQU0f(stage));
		(defaultInterpolatedStringHandler).AppendLiteral("被拒绝，状态 0x");
		((AsyncTaskMethodBuilder<byte[]>*)(&defaultInterpolatedStringHandler))->AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter, N2cbLyXtyOtffAtN5OLH._ReadResponseAsync_d__7>(ref this, ref this);
		(defaultInterpolatedStringHandler).ToStringAndClear();
		int num = 2;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
		{
			num = 3;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 == 990)
				{
					num = num2;
					continue;
				}
				break;
			case 2:
				IihX87gS7tm = stage;
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
				{
					num = 3;
				}
				continue;
			case 1:
				break;
			case 0:
				return;
			}
			fI7X8A7PvWI = status;
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string M0GX8osmGb7()
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendFormatted(tCCX8mIQU0f(Stage));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string tCCX8mIQU0f(lwQLqMX84V4jjpZyRJiH stage)
	{
		int num = 5;
		string result = default(string);
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
							goto case 5;
						}
						goto case 0;
					case 2:
					case 6:
						_ = "stage";
						_ = (object)stage;
						throw null;
					case 0:
						return result;
					case 5:
						if (stage != lwQLqMX84V4jjpZyRJiH.Initialize)
						{
							num3 = 4;
							continue;
						}
						goto case 1;
					case 4:
						if (stage != lwQLqMX84V4jjpZyRJiH.Join)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
							{
								num3 = 6;
							}
							continue;
						}
						break;
					case 3:
						break;
					case 1:
						result = "初始化";
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
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
			result = "Join";
			num = 13;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
			{
				num = 0;
			}
		}
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						num3 = 1;
						continue;
					case 1:
						break;
					case 0:
						return;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool R4gqyKZgFsp8ommobCD7()
	{
		return dwgULPZgxJgxbIRZgxbI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static o8RfpIX8UTT0WuV08pml TCE1idZgsK5fUWR9BfqD()
	{
		return (o8RfpIX8UTT0WuV08pml)dwgULPZgxJgxbIRZgxbI;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using JvgQTDcbARdEdTAk7GE;
using PJFIn6fwNw3W82OxkWAg;
using fDAldojjppXrctUVYOJn;

namespace E3mmdoXKraivGfAKbeGF;

internal sealed class Wd6cYLXKUFPSlmk3COk8 : InvalidOperationException
{
	[CompilerGenerated]
	private readonly int mPuXKmQfxJj;

	[CompilerGenerated]
	private readonly string EglXK7Qv0so;

	private static object t9USpWZOTCAtiCy1YL84;

	internal int Code
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return mPuXKmQfxJj;
		}
	}

	internal string ApiMessage
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return EglXK7Qv0so;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe Wd6cYLXKUFPSlmk3COk8(int code, string apiMessage)
	{
		//IL_005e: Expected O, but got I4
		//IL_005e: Expected O, but got I4
		//IL_005e: Expected O, but got Ref
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendFormatted(SXvXKoEGuGr(apiMessage));
		(defaultInterpolatedStringHandler).AppendLiteral("（code=");
		((v5OiSQSzC8GipXkQ3VG)(&defaultInterpolatedStringHandler)).wDn87ymIHB<S9HINnfwTP9GO76XPCkJ>((string)7, (object)2, (byte)(&defaultInterpolatedStringHandler) != 0, (CancellationToken)code);
		(defaultInterpolatedStringHandler).AppendLiteral("）");
		(defaultInterpolatedStringHandler).ToStringAndClear();
		int num = 1;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
		{
			num = 8;
		}
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 990)
				{
					break;
				}
				goto IL_00b7;
			case 1:
				mPuXKmQfxJj = code;
				num2 = 2;
				goto IL_00b7;
			case 2:
				break;
			case 0:
				return;
				IL_00b7:
				num = num2;
				continue;
			}
			EglXK7Qv0so = SXvXKoEGuGr(apiMessage);
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string SXvXKoEGuGr(object message)
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
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (!string.IsNullOrWhiteSpace((string)message))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return "网易接口返回失败";
				case 0:
					return (message).Trim();
				}
				break;
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
						default:
							goto end_IL_000e;
						case 9:
							goto IL_0053;
						}
						break;
					case 2:
						goto end_IL_000e;
					case 1:
						return;
					case 0:
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						IL_0053:
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							num3 = 0;
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
	internal static bool BnSRmEZONjVrSw0r8ZBq()
	{
		return t9USpWZOTCAtiCy1YL84 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Wd6cYLXKUFPSlmk3COk8 YkmLtlZOMVVybJ8VWdSR()
	{
		return (Wd6cYLXKUFPSlmk3COk8)t9USpWZOTCAtiCy1YL84;
	}
}

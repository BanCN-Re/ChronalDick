using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace kjmEg9XjZAnq4NNUOiwu;

internal class RE1PFHXjjsSQUve0yeCF
{
	internal static object VVnJvqZAXW0wVasvyEL9;


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
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return;
					case 1:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Kcpr6uZAfvT1iq2fnWpd()
	{
		return VVnJvqZAXW0wVasvyEL9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RE1PFHXjjsSQUve0yeCF zRjPCEZALtKvDfDeNDJk()
	{
		return (RE1PFHXjjsSQUve0yeCF)VVnJvqZAXW0wVasvyEL9;
	}
}


internal static class __FixExt_RE1PFHXjjsSQUve0yeCF
{
	[MethodImpl((MethodImplOptions)8)]
	internal static long rVAXj9qKx8U<T>(this global::System.Collections.Generic.IEnumerable<T> values, Func<T, long> selector)
	{
		//IL_0015: Expected I8, but got O
		//IL_0038->IL0038: Incompatible stack heights: 1 vs 0
		long num = 0L;
		try
		{
			while ((values).MoveNext())
			{
				T val = (T)values;
				long num2 = (long)val;
				num = ((num > 9223372036854775807L - num2) ? 9223372036854775807L : (num + num2));
			}
			return num;
		}
		finally
		{
			if (values != null)
			{
				(values).Dispose();
			}
		}
	}

}
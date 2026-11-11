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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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
		long num = 0L;
		global::System.Collections.Generic.IEnumerator<T> enumerator = values.GetEnumerator();
		try
		{
			while ((enumerator).MoveNext())
			{
				T current = enumerator.Current;
				long num2 = selector.Invoke(current);
				num = ((num > 9223372036854775807L - num2) ? 9223372036854775807L : (num + num2));
			}
			return num;
		}
		finally
		{
			if (enumerator != null)
			{
				(enumerator).Dispose();
			}
		}
	}

}
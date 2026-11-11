using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace HAx88KXPnl7mg9edqCms;

internal class YyxkipXPix5sf3TwZkPC
{
	private static object wZWpp1ZR0xhgRh90gOOr;

	[MethodImpl((MethodImplOptions)8)]
	internal static int JNvXPzRjTHR()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		int num = System.Math.Clamp(System.Environment.ProcessorCount / 2, 2, 6);
		GCMemoryInfo val = System.GC.GetGCMemoryInfo();
		long num2 = (val).TotalAvailableMemoryBytes;
		int num3 = ((num2 < 8589934592L) ? ((num2 <= 0) ? 4 : ((num2 >= 4294967296L) ? 3 : 2)) : ((num2 >= 17179869184L) ? 6 : 4));
		int num4 = num3;
		return System.Math.Min(num, num4);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int bsgXxb588LN()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		int num = System.Math.Clamp(System.Environment.ProcessorCount / 2, 2, 6);
		GCMemoryInfo val = System.GC.GetGCMemoryInfo();
		long num2 = (val).TotalAvailableMemoryBytes;
		int num3 = ((num2 >= 8589934592L) ? ((num2 >= 17179869184L) ? 6 : 4) : ((num2 <= 0) ? 4 : ((num2 >= 4294967296L) ? 3 : 2)));
		int num4 = num3;
		return System.Math.Min(num, num4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PHNeLEZR8LPngq9K5RGD()
	{
		return wZWpp1ZR0xhgRh90gOOr == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static YyxkipXPix5sf3TwZkPC ihHj5ZZRyO71rYQICb8o()
	{
		return (YyxkipXPix5sf3TwZkPC)wZWpp1ZR0xhgRh90gOOr;
	}
}

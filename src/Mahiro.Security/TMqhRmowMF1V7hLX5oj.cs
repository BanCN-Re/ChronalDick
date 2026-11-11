using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PJoWpXB7rwAmXGt51DD;

namespace VA6gxxoeXYkppxunNaZ;

internal class TMqhRmowMF1V7hLX5oj
{
	internal static object JDbvmWZ89nKwgw519IaQ;

	[MethodImpl((MethodImplOptions)8)]
	internal static extern global::System.Collections.Generic.IReadOnlyList<A228j3Bm0ei4PAS7MF3> Capture();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern A228j3Bm0ei4PAS7MF3 Interpret(object id, int informationClass, int size, int status, uint returned, ulong value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern A228j3Bm0ei4PAS7MF3 Query(string id, int informationClass, int size);

	[DllImport("ntdll.dll", ExactSpelling = true)]
	private static extern int NtQueryInformationProcess(nint process, int informationClass, nint information, uint length, out uint returnLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool CloseHandle(nint handle);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool rQo9I4Z8DcyHJmp9AQTd();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern TMqhRmowMF1V7hLX5oj RHv3yfZ8kCNnyoS9kRlX();
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32.SafeHandles;
using NGs23dRsf1NAcIqosyu;
using fDAldojjppXrctUVYOJn;

namespace R5yqr9R1IELhaDBLEJI;

public sealed class S2o5G5RaBS3I3hNd033
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_157
	{
		public static readonly __c_157 __9;

		public static Func<fOcOY1RFFHl1umhJwJs, int> __9__0_0;

		internal static __c_157 IndxRk97eQiV7gIexTNn;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_157()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int TBUfGQWwTal(fOcOY1RFFHl1umhJwJs target)
		{
			return target.ProcessId;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool jCPFa597PRCwS46X5qre()
		{
			return IndxRk97eQiV7gIexTNn == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_157 YKfBng97xae9gALYohbj()
		{
			return IndxRk97eQiV7gIexTNn;
		}
	}

	private static object XIq6pqZQz4pgnoBQJxM7;

	[MethodImpl((MethodImplOptions)8)]
	public extern global::System.Collections.Generic.IReadOnlyList<fOcOY1RFFHl1umhJwJs> AO8R3Oh34e();

	[MethodImpl((MethodImplOptions)8)]
	public extern bool UNjRvji1H4(fOcOY1RFFHl1umhJwJs target, string dllPath);

	[MethodImpl((MethodImplOptions)8)]
	private static extern nint yboREX4gLH(object target);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool GIlR204ba8(object target, object path);

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	private static extern SafeProcessHandle j17Rq6v5m4(uint access, [MarshalAs((UnmanagedType)2)] bool inherit, int processId);

	[DllImport("kernel32.dll", EntryPoint = "GetProcessTimes", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool xCTRGIjMx6(SafeProcessHandle process, out long created, out long exited, out long kernel, out long user);

	[DllImport("kernel32.dll", EntryPoint = "IsWow64Process2", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool b4rRiUt6wy(SafeProcessHandle process, out ushort processMachine, out ushort nativeMachine);

	[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx", SetLastError = true)]
	private static extern nint I6JRnMUfge(SafeProcessHandle process, nint address, nuint size, uint type, uint protection);

	[DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool FD7Rzcfi1e(SafeProcessHandle process, nint address, nuint size, uint type);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool afDwbsja6d(SafeProcessHandle process, nint address, byte[] bytes, nuint size, out nuint written);

	[DllImport("kernel32.dll", EntryPoint = "CreateRemoteThread", SetLastError = true)]
	private static extern SafeWaitHandle yiZwXD7Ooh(SafeProcessHandle process, nint attributes, nuint stackSize, nint start, nint parameter, uint flags, out uint threadId);

	[DllImport("kernel32.dll", EntryPoint = "WaitForSingleObject", SetLastError = true)]
	private static extern uint r2wwfsAfai(SafeWaitHandle handle, uint milliseconds);

	[DllImport("kernel32.dll", EntryPoint = "GetExitCodeThread", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool Td9wLHacUr(SafeWaitHandle thread, out uint exitCode);

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "GetModuleHandleW", ExactSpelling = true, SetLastError = true)]
	private static extern nint aW3wjPj6Yf(string moduleName);

	[DllImport("kernel32.dll", CharSet = (CharSet)2, EntryPoint = "GetProcAddress", ExactSpelling = true, SetLastError = true)]
	private static extern nint xpEwZ396Ye(nint module, string name);

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "GetModuleHandleExW", ExactSpelling = true, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool echw9odiaZ(uint flags, nint address, out nint module);

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "GetModuleFileNameW", ExactSpelling = true, SetLastError = true)]
	private static extern uint iwLwDra1GX(nint module, StringBuilder path, int size);

	[MethodImpl((MethodImplOptions)8)]
	public extern S2o5G5RaBS3I3hNd033();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool jD094sZCbg41ttVlRDAG();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern S2o5G5RaBS3I3hNd033 UXsUecZCXab2I3pGUv6n();
}

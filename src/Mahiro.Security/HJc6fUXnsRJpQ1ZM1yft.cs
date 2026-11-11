using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace LioRGnXnTmo7MsqH4aeD;

internal class HJc6fUXnsRJpQ1ZM1yft
{
	internal struct r9hsZrLVGHisQUt0ZQ2N
	{
		internal nint M17LVi1Rk5b;

		internal nint IJrLVnQHuO9;

		internal uint zs1LVzonwg5;

		internal ushort C2RLYbo6qfs;

		internal nuint zqeLYXtHPca;

		internal uint WscLYfYgn4h;

		internal uint C4MLYLAvk8F;

		internal uint VI0LYjNVUZV;
	}

	private static object kp4AuOZFq7Cn9iIWTEEp;

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern SafeProcessHandle OpenProcess(uint desiredAccess, [MarshalAs((UnmanagedType)2)] bool inheritHandle, uint processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool GetProcessTimes(SafeProcessHandle process, out ulong created, out ulong exited, out ulong kernel, out ulong user);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool IsWow64Process2(SafeProcessHandle process, out ushort processMachine, out ushort nativeMachine);

	[DllImport("kernel32.dll", SetLastError = true)]
	internal static extern nuint VirtualQueryEx(SafeProcessHandle process, nint address, out r9hsZrLVGHisQUt0ZQ2N information, nuint informationLength);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	internal static extern bool ReadProcessMemory(SafeProcessHandle process, nint address, [Out] byte[] buffer, nuint size, out nuint bytesRead);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GL1yUjZFGR1u6u2SwuaP()
	{
		return kp4AuOZFq7Cn9iIWTEEp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static HJc6fUXnsRJpQ1ZM1yft AvvyhCZFic3E3r8DhEcW()
	{
		return (HJc6fUXnsRJpQ1ZM1yft)kp4AuOZFq7Cn9iIWTEEp;
	}
}

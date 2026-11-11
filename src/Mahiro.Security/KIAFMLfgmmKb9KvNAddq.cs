using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace QZs97cfg7H5cG2l6dckf;

internal class KIAFMLfgmmKb9KvNAddq
{
	private static object MsB9noZ1tF5vn1gAY4tH;

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess", SetLastError = true)]
	internal static extern SafeProcessHandle PlBfgAUiDOZ(uint access, bool inherit, int processId);

	[DllImport("kernel32.dll", EntryPoint = "IsWow64Process2", SetLastError = true)]
	internal static extern bool JIrfgIt4is4(SafeProcessHandle process, out ushort processMachine, out ushort nativeMachine);

	[DllImport("kernel32.dll", EntryPoint = "GetProcessTimes", SetLastError = true)]
	internal static extern bool fsAfgBagJeb(SafeProcessHandle process, out long created, out long exited, out long kernel, out long user);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	internal static extern uint yXafggvOo76(nint window, out uint processId);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oJ83lLZ1O8J4vTlPQdGn()
	{
		return MsB9noZ1tF5vn1gAY4tH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static KIAFMLfgmmKb9KvNAddq L0QWyLZ15WFsNJ3NB1G0()
	{
		return (KIAFMLfgmmKb9KvNAddq)MsB9noZ1tF5vn1gAY4tH;
	}
}

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using VlB983B3k9e3NYmI81T;

namespace JTiMisBqeBn9pXfmAlu;

internal class ItTFVeB2mJDZrAbx4Mf
{
	private static object C3glZrZy1Q6ifv8nRRMb;

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool TryQuery(ulong address, out pnfWcAB1dtd0grBx0DF region, out string error);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool TryRead(ulong address, int count, out byte[] bytes, out string error);

	[MethodImpl((MethodImplOptions)8)]
	private static extern ulong ReadPointer(nint buffer, int offset);

	[MethodImpl((MethodImplOptions)8)]
	private static extern nint Pointer(ulong address);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nuint VirtualQuery(nint address, nint information, nuint length);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool ReadProcessMemory(nint process, nint address, byte[] buffer, nuint size, out nuint read);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool hIbJZZZy37YXmfjdtQjB();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern ItTFVeB2mJDZrAbx4Mf qnk2xmZyvADtF4375bFk();
}

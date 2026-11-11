using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using o77FSD4oMGHGbl44MPR;

namespace eSnvSk4QPk5P8PMlYpC;

internal class sopKL04JEumctKDXjEH
{
	private static object mCVulsZclinuqdBB6een;

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool TryCapture(int processId, out bKgpy04rH66Wqmd3C4r? identity);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool IsSame(object expected);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool IsCurrentUserProcess(nint processHandle);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool TryQueryProcessImagePath(nint processHandle, out string path);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern nint OpenProcess(uint desiredAccess, [MarshalAs((UnmanagedType)2)] bool inheritHandle, uint processId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool CloseHandle(nint handle);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool ProcessIdToSessionId(uint processId, out uint sessionId);

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool QueryFullProcessImageName(nint processHandle, uint flags, StringBuilder executableName, ref int size);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool OpenProcessToken(nint processHandle, uint desiredAccess, out nint tokenHandle);

	[DllImport("advapi32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetTokenInformation(nint tokenHandle, int tokenInformationClass, nint tokenInformation, int tokenInformationLength, out int returnLength);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool SCxM8TZcdfiIhSpsmCE5();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern sopKL04JEumctKDXjEH nV6ADQZcKo3OCnkbhKoP();
}

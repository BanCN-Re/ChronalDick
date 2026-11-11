using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace I8kVvQmUGdEncAIoxaC;

internal class rDf13emhypQ5FFQEmmM
{
	[StructLayout((LayoutKind)0, CharSet = (CharSet)3)]
	internal struct qbbCDuf2M2VA8gjdtCP1
	{
		public uint vlGf2p5n3Cb;

		public uint jwAf2u8v5n6;

		public uint L4kf2axUPk2;

		public uint Pmqf21e4DmG;

		public uint njVf23xFNeG;

		public uint Viwf2vpEuUh;

		public ulong D7Lf2Eu383t;

		public ulong qN0f22wAsEC;

		[MarshalAs((UnmanagedType)23, SizeConst = 97)]
		public string GIAf2qGShJa;
	}

	private delegate uint znZxKuf2Gx7dhTPpZW0L(ref qbbCDuf2M2VA8gjdtCP1 result);

	private static readonly object GbKmlXAEpF;

	private static nint ntkmdpS7sf;

	private static FileStream? fBVmKq6Crr;

	private static object v2QmH7Z8honHJJDfg8hB;

	internal static extern string InstallationRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "LoadLibraryExW", SetLastError = true)]
	private static extern nint unumryWKjc(string path, nint file, uint flags);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	private static extern nint bcamomFs1C();

	[DllImport("kernel32.dll", EntryPoint = "TerminateProcess")]
	private static extern bool iiimmE1FOE(nint process, uint exitCode);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern qbbCDuf2M2VA8gjdtCP1 mWnm7vuQZN();

	[MethodImpl((MethodImplOptions)8)]
	private static extern qbbCDuf2M2VA8gjdtCP1 lvDmADrKv5();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern nint pI3mIjtv0a(object name);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern void lxWmBMIqyT();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern void NxkmgBHGr9();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool a1ssZyZ8UDfQaSa2bKo9();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern rDf13emhypQ5FFQEmmM XXYadqZ8rUxY3qg21gb7();
}

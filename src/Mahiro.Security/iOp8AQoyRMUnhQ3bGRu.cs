using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using hq8ZMrfHTlm6RkMP2hfp;

namespace m5NLKNoWjf2r56bsRv4;

public sealed class iOp8AQoyRMUnhQ3bGRu
{
	private struct tifZBmfEEYUpFbU8vUqw
	{
		public uint iYWfE2MPic9;

		public uint IdyfEqey9Sr;

		[MarshalAs((UnmanagedType)30, SizeConst = 1)]
		public byte[] EF5fEG5pZBF;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_132
	{
		public static readonly __c_132 __9;

		public static Func<KeyValuePair<string, string>, string> __9__0_0;

		private static __c_132 BvKvSL9CxPViqFqoZr2A;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_132()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _CreateMachineRequest_b__0_0(KeyValuePair<string, string> pair)
		{
			return string.Concat(pair.Key, ":", pair.Value);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ajhFG29CFuFooNl8xNmc()
		{
			return BvKvSL9CxPViqFqoZr2A == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_132 Ewrcjh9CswbFlBwH4cQj()
		{
			return BvKvSL9CxPViqFqoZr2A;
		}
	}

	private static object z7Fh9nZ0iy3vXbmAeWv5;

	[MethodImpl((MethodImplOptions)8)]
	public extern GjiCoNfHsuFeDBwy9oM7 CreateMachineRequest();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetSystemFirmwareTable(uint firmwareTableProviderSignature, uint firmwareTableID, nint pFirmwareTableBuffer, uint bufferSize);

	[MethodImpl((MethodImplOptions)8)]
	private static extern ValueTuple<string, string, string> ReadSmbiosInfo();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetSmbiosString(object data, int stringAreaStart, byte stringIndex, int maxOffset);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool IsInvalidGuid(object bytes);

	[DllImport("kernel32.dll", CharSet = (CharSet)4, SetLastError = true)]
	private static extern nint CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, nint lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, nint hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool DeviceIoControl(nint hDevice, uint dwIoControlCode, ref tifZBmfEEYUpFbU8vUqw lpInBuffer, uint nInBufferSize, nint lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, nint lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(nint hObject);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string ReadDiskSerialNumber();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string CleanSerialNumber(object serial);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetCpuArchitectureSignature();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string Sha256(object value);

	[MethodImpl((MethodImplOptions)8)]
	public extern iOp8AQoyRMUnhQ3bGRu();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool FW2gx3Z0nhmsDHeyenZ1();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern iOp8AQoyRMUnhQ3bGRu wkWCiJZ0zvKc0gvuXapH();
}

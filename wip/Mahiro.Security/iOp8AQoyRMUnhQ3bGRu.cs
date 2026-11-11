using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using AR0yDHKcbVJbe6i6hLY;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using hq8ZMrfHTlm6RkMP2hfp;
using uwRhO8CRVFnAu0aW8Xr;

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
		public static __c_132 __9;

		public static Func<KeyValuePair<string, string>, string> __9__0_0;

		private static __c_132 BvKvSL9CxPViqFqoZr2A;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
							{
								num3 = 8;
							}
							continue;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num3 = 3;
							}
							continue;
						case 4:
							break;
						case 3:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
							{
								num3 = 4;
							}
							continue;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto end_IL_000e;
						continue;
						end_IL_0012:
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				__9 = (__c_132)new __c_132();
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_132()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string _CreateMachineRequest_b__0_0(KeyValuePair<string, string> pair)
		{
			return null;
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
	public unsafe GjiCoNfHsuFeDBwy9oM7 CreateMachineRequest()
	{
		_ = 11;
		_ = "cpu";
		_ = "board";
		_ = "memory";
		object obj = default(object);
		_ = ((LwmISJC6yaOQNTugLhy.UFRTibfEWKTWmAtv66DI*)(&obj))->Memory;
		_ = "gpu";
		_ = ((LwmISJC6yaOQNTugLhy.UFRTibfEWKTWmAtv66DI*)(&obj))->Gpu;
		_ = "disk";
		_ = "bios";
		_ = "boardUuid";
		_ = "boardSerial";
		_ = "machineName";
		System.Environment.MachineName;
		_ = "os";
		object obj3 = default(object);
		object obj2 = obj3;
		return null;
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint GetSystemFirmwareTable(uint firmwareTableProviderSignature, uint firmwareTableID, nint pFirmwareTableBuffer, uint bufferSize);

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static ValueTuple<string, string, string> ReadSmbiosInfo()
	{
		//IL_0008: Ignored invalid 'constrained' prefix
		//IL_0019: Expected O, but got Ref
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		_ = 14;
		object obj2 = default(object);
		object obj = ((object)(&obj2)).ToLowerInvariant();
		return default(ValueTuple<string, string, string>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GetSmbiosString(object data, int stringAreaStart, byte stringIndex, int maxOffset)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsInvalidGuid(object bytes)
	{
		//IL_0009: Expected O, but got I4
		//IL_0042: Expected I4, but got O
		//IL_00cb: Expected O, but got I4
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_007a: Expected O, but got I4
		//IL_006d: Expected O, but got I4
		//IL_012a: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_009f: Expected I4, but got O
		//IL_00df->IL000d: Incompatible stack types: I4 vs O
		//IL_011c->IL000d: Incompatible stack types: I4 vs O
		//IL_008e->IL000d: Incompatible stack types: I4 vs O
		//IL_0077->IL000d: Incompatible stack types: I4 vs O
		//IL_0134->IL000d: Incompatible stack types: I4 vs O
		//IL_014b->IL000d: Incompatible stack types: I4 vs O
		//IL_00ea->IL000d: Incompatible stack types: I4 vs O
		//IL_0127->IL000d: Incompatible stack types: I4 vs O
		//IL_0099->IL000d: Incompatible stack types: I4 vs O
		//IL_0156->IL000d: Incompatible stack types: I4 vs O
		//IL_0102->IL000d: Incompatible stack types: I4 vs O
		//IL_00bd->IL000d: Incompatible stack types: I4 vs O
		//IL_00c8->IL000d: Incompatible stack types: I4 vs O
		int num = 5;
		object obj5 = default(object);
		object obj4 = default(object);
		object obj3 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 18)
						{
							if ((nint)obj == 999)
							{
								goto end_IL_000d;
							}
							goto case 1;
						}
						goto case 8;
					case 5:
						obj5 = 1;
						obj2 = 4;
						continue;
					case 4:
						obj4 = 1;
						obj2 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
						{
							obj2 = 7;
						}
						continue;
					case 9:
						return (byte)(obj5 | obj4) != 0;
					case 10:
					case 11:
						if ((nint)obj3 < ((global::System.Array)bytes).Length)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
							{
								obj2 = 10;
							}
							continue;
						}
						goto case 9;
					case 1:
						obj5 = 0;
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 8:
						if (((short[])bytes)[obj3] != 255)
						{
							obj2 = 6;
							continue;
						}
						goto case 3;
					case 3:
						obj3++;
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							obj2 = 10;
						}
						continue;
					case 6:
						obj4 = 0;
						obj2 = 3;
						continue;
					case 7:
						obj3 = 0;
						obj2 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
					case 2:
						if (((short[])bytes)[obj3] == 0)
						{
							break;
						}
						goto case 1;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 18;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
			{
				num = 8;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)4, SetLastError = true)]
	private static extern nint CreateFile(string lpFileName, uint dwDesiredAccess, uint dwShareMode, nint lpSecurityAttributes, uint dwCreationDisposition, uint dwFlagsAndAttributes, nint hTemplateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool DeviceIoControl(nint hDevice, uint dwIoControlCode, ref tifZBmfEEYUpFbU8vUqw lpInBuffer, uint nInBufferSize, nint lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, nint lpOverlapped);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CloseHandle(nint hObject);

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string ReadDiskSerialNumber()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string CleanSerialNumber(object serial)
	{
		//IL_000e: Expected I4, but got O
		//IL_0010: Expected O, but got I4
		object obj2 = default(object);
		object obj3 = default(object);
		object obj = (obj2).Chars;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string GetCpuArchitectureSignature()
	{
		object obj = default(object);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("-");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Sha256(object value)
	{
		return (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes((string)value)))).ToLowerInvariant();
	}

	[MethodImpl((MethodImplOptions)8)]
	public iOp8AQoyRMUnhQ3bGRu()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_005e->IL0012: Incompatible stack types: I4 vs O
		//IL_0091->IL0012: Incompatible stack types: I4 vs O
		//IL_0069->IL0012: Incompatible stack types: I4 vs O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							return;
						}
						goto IL_0031;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							obj2 = 2;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 2:
						break;
					}
					goto IL_0078;
					IL_0031:
					if ((nint)obj == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					obj2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
					{
						obj2 = 1;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool FW2gx3Z0nhmsDHeyenZ1()
	{
		return z7Fh9nZ0iy3vXbmAeWv5 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern iOp8AQoyRMUnhQ3bGRu wkWCiJZ0zvKc0gvuXapH();
}

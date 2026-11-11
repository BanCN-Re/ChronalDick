using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using HYsR4B4jbWNvKiLWpcX;
using fDAldojjppXrctUVYOJn;
using o77FSD4oMGHGbl44MPR;

namespace eSnvSk4QPk5P8PMlYpC;

internal class sopKL04JEumctKDXjEH
{
	private static object mCVulsZclinuqdBB6een;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool TryCapture(int processId, out bKgpy04rH66Wqmd3C4r? identity)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool IsSame(object expected)
	{
		//IL_0009: Expected O, but got I4
		//IL_002a: Expected I4, but got O
		//IL_010e->IL000d: Incompatible stack types: I4 vs O
		//IL_00e7->IL000d: Incompatible stack types: I4 vs O
		//IL_00b6->IL000d: Incompatible stack types: I4 vs O
		//IL_00f2->IL000d: Incompatible stack types: I4 vs O
		//IL_0089->IL000d: Incompatible stack types: I4 vs O
		//IL_00c1->IL000d: Incompatible stack types: I4 vs O
		//IL_0094->IL000d: Incompatible stack types: I4 vs O
		int num = 3;
		object identity = default(object);
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_000d;
							}
							goto case 3;
						}
						goto case 0;
					case 3:
						if (expected == (object?)null)
						{
							goto end_IL_0009;
						}
						goto case 2;
					case 0:
						return false;
					case 5:
						if (identity != null)
						{
							if (((bKgpy04rH66Wqmd3C4r)identity).SessionId == ((bKgpy04rH66Wqmd3C4r)expected).SessionId)
							{
								obj2 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
								{
									obj2 = 4;
								}
								continue;
							}
							break;
						}
						obj2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						if (((bKgpy04rH66Wqmd3C4r)identity).StartTimeUtcTicks == ((bKgpy04rH66Wqmd3C4r)expected).StartTimeUtcTicks)
						{
							obj2 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
							{
								obj2 = 1;
							}
							continue;
						}
						break;
					case 2:
						if (TryCapture(((bKgpy04rH66Wqmd3C4r)expected).ProcessId, out *(bKgpy04rH66Wqmd3C4r?*)(&identity)))
						{
							obj2 = 5;
							continue;
						}
						goto case 0;
					case 1:
						return string.Equals(((bKgpy04rH66Wqmd3C4r)identity).ExecutablePath, ((bKgpy04rH66Wqmd3C4r)expected).ExecutablePath, (StringComparison)5);
					}
					return false;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool IsCurrentUserProcess(nint processHandle)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool TryQueryProcessImagePath(nint processHandle, out string path)
	{
		//IL_0010: Expected I4, but got O
		//IL_001b: Expected I8, but got O
		object obj = default(object);
		object obj2 = default(object);
		path = default;
		return default(bool);
	}

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
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_005e->IL0012: Incompatible stack types: I4 vs O
		//IL_0069->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
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
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num = 2;
						break;
					case 2:
						return;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							obj2 = 9;
						}
						continue;
					case 0:
						num = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
						{
							num = 9;
						}
						break;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SCxM8TZcdfiIhSpsmCE5()
	{
		return mCVulsZclinuqdBB6een == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern sopKL04JEumctKDXjEH nV6ADQZcKo3OCnkbhKoP();
}

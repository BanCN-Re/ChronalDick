using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace IYlPrUCyr91RiubtipO;

internal class pbDtgtC8qE0jgObfkY7
{
	private struct Ed5UdnfEVBSMMO7lMClg
	{
		public int RnGfEYJxs6B;

		public nint caefES4YuWJ;
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_124
	{
		public static __c_124 __9;

		public static Func<string, object> __9__4_0;

		public static Func<string, object> __9__7_0;

		internal static __c_124 CUccdZ9WlYOnJ5QeIpoV;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 1;
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
							switch (num2)
							{
							case 992:
								goto end_IL_0012;
							case 11:
								return;
							}
							goto end_IL_000e;
						case 0:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							goto end_IL_000e;
						case 2:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num3 = 3;
							}
							continue;
						case 4:
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
								{
									num3 = 2;
								}
								continue;
							}
							end_IL_0012:
							break;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				__9 = (__c_124)new __c_124();
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_124()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal object _Append_b__4_0(string _)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal object _ReadCore_b__7_0(string _)
		{
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool mAItfh9Wd9MMp8o5KAeh()
		{
			return CUccdZ9WlYOnJ5QeIpoV == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_124 UUb6vA9WK23cEnqDrcuk()
		{
			return CUccdZ9WlYOnJ5QeIpoV;
		}
	}

	private static readonly object zoaCWldx2c;

	private static readonly object WRCCJVmLfF;

	private static readonly ConcurrentDictionary<string, object> TCACQYxEeH;

	internal static object M3uJI2ZcXagAtIih2hjr;

	[MethodImpl((MethodImplOptions)8)]
	internal static void Append(object path, string? content)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string ReadAndMigrate(object path, int maxPlainBytes)
	{
		return ReadCore(path, maxPlainBytes, migrate: true, keepTail: false);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string ReadSnapshot(object path, int maxPlainBytes)
	{
		return ReadCore(path, maxPlainBytes, migrate: false, keepTail: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ReadCore(object path, int maxPlainBytes, bool migrate, bool keepTail)
	{
		object obj2 = default(object);
		object obj = new DateTimeOffset[System.Math.Min(maxPlainBytes, checked((int)System.Math.Max(0L, (obj2).Length - (obj2).Position)))];
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string ReadEncrypted(object stream, int maxPlainBytes, bool keepTail)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string DecodeUtf8Tail(global::System.ReadOnlySpan<byte> bytes)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void TryMigrate(object path, object content)
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		string text = ".chronal-migrate-";
		object obj = System.Guid.NewGuid();
		object obj2 = string.Concat((string)path, text, (obj).ToString("N"));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool HasHeader(object stream)
	{
		//IL_0009: Expected O, but got I4
		object obj = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ReadExactly(object stream, object buffer)
	{
		//IL_0009: Expected O, but got I4
		//IL_002a: Expected I4, but got O
		//IL_0098: Expected O, but got I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected I4, but got Unknown
		//IL_0061: Expected I4, but got O
		//IL_0063: Expected O, but got I4
		//IL_00ac->IL000d: Incompatible stack types: I4 vs O
		//IL_00b7->IL000d: Incompatible stack types: I4 vs O
		//IL_00f3->IL000d: Incompatible stack types: I4 vs O
		//IL_00fe->IL000d: Incompatible stack types: I4 vs O
		//IL_008a->IL000d: Incompatible stack types: I4 vs O
		//IL_00c9->IL000d: Incompatible stack types: I4 vs O
		//IL_0095->IL000d: Incompatible stack types: I4 vs O
		int num = 1;
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
						if ((nint)obj != 12)
						{
							if ((nint)obj == 993)
							{
								goto end_IL_000d;
							}
							goto case 5;
						}
						if ((nint)obj4 <= 0)
						{
							obj2 = 5;
							continue;
						}
						obj3 += obj4;
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							obj2 = 0;
						}
						continue;
					case 4:
						return true;
					case 3:
						break;
					case 5:
						return false;
					case 1:
						obj3 = 0;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
					case 2:
						if ((nint)obj3 >= ((global::System.Array)buffer).Length)
						{
							obj2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								obj2 = 4;
							}
							continue;
						}
						break;
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
			obj4 = (stream).Read((byte[])buffer, (int)obj3, ((global::System.Array)buffer).Length - obj3);
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] Protect(byte[] plain);

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] Unprotect(object protectedBytes);

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static byte[] Transform(object input, bool protect)
	{
		object obj = default(object);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("Windows DPAPI 操作失败，错误码 ");
		return null;
	}

	[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern bool CryptProtectData(ref Ed5UdnfEVBSMMO7lMClg dataIn, string? description, nint entropy, nint reserved, nint prompt, int flags, ref Ed5UdnfEVBSMMO7lMClg dataOut);

	[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Ed5UdnfEVBSMMO7lMClg dataIn, nint description, nint entropy, nint reserved, nint prompt, int flags, ref Ed5UdnfEVBSMMO7lMClg dataOut);

	[DllImport("kernel32.dll")]
	private static extern nint LocalFree(nint handle);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Dj2cyBZcfZZvbqpJaodH()
	{
		return M3uJI2ZcXagAtIih2hjr == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static extern pbDtgtC8qE0jgObfkY7 nUh7R0ZcLUMgGBSABNAV();
}

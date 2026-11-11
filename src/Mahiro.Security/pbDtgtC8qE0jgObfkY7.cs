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
		public static readonly __c_124 __9;

		public static Func<string, object> __9__4_0;

		public static Func<string, object> __9__7_0;

		internal static __c_124 CUccdZ9WlYOnJ5QeIpoV;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_124()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
			{
				num = 3;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal object _Append_b__4_0(string _)
		{
			return new object();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal object _ReadCore_b__7_0(string _)
		{
			return new object();
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
	internal static extern void Append(object path, string? content);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern string ReadAndMigrate(object path, int maxPlainBytes);

	[MethodImpl((MethodImplOptions)8)]
	internal static extern string ReadSnapshot(object path, int maxPlainBytes);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string ReadCore(object path, int maxPlainBytes, bool migrate, bool keepTail);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string ReadEncrypted(object stream, int maxPlainBytes, bool keepTail);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string DecodeUtf8Tail(global::System.ReadOnlySpan<byte> bytes);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void TryMigrate(object path, object content);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool HasHeader(object stream);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool ReadExactly(object stream, object buffer);

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] Protect(byte[] plain);

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] Unprotect(object protectedBytes);

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] Transform(object input, bool protect);

	[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern bool CryptProtectData(ref Ed5UdnfEVBSMMO7lMClg dataIn, string? description, nint entropy, nint reserved, nint prompt, int flags, ref Ed5UdnfEVBSMMO7lMClg dataOut);

	[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern bool CryptUnprotectData(ref Ed5UdnfEVBSMMO7lMClg dataIn, nint description, nint entropy, nint reserved, nint prompt, int flags, ref Ed5UdnfEVBSMMO7lMClg dataOut);

	[DllImport("kernel32.dll")]
	private static extern nint LocalFree(nint handle);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool Dj2cyBZcfZZvbqpJaodH();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern pbDtgtC8qE0jgObfkY7 nUh7R0ZcLUMgGBSABNAV();
}

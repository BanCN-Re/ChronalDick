using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace WMO32gy5EZANSQKlHAx;

public class gX17swyO7x0JWQxdaD1
{
	private class c2FJb3fvOSATYfF0bF8t
	{
		private struct FrvYRkLWzOjYdbf2nTgQ
		{
			public int mH0LJbMufBi;

			public nint dTALJXRvARN;
		}

		private static object m95uMT9ycKk1fN2iB0YX;

		[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
		private static extern bool CryptProtectData(ref FrvYRkLWzOjYdbf2nTgQ dataIn, string? description, nint entropy, nint reserved, nint prompt, int flags, ref FrvYRkLWzOjYdbf2nTgQ dataOut);

		[DllImport("crypt32.dll", CharSet = (CharSet)3, SetLastError = true)]
		private static extern bool CryptUnprotectData(ref FrvYRkLWzOjYdbf2nTgQ dataIn, nint description, nint entropy, nint reserved, nint prompt, int flags, ref FrvYRkLWzOjYdbf2nTgQ dataOut);

		[DllImport("kernel32.dll")]
		private static extern nint LocalFree(nint handle);

		[MethodImpl((MethodImplOptions)8)]
		internal static byte[] Protect(byte[] plain)
		{
			return Transform(plain, protect: true);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static byte[] Unprotect(object protectedBytes)
		{
			return Transform(protectedBytes, protect: false);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static byte[] Transform(object input, bool protect)
		{
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			nint num3 = default(nint);
			int num5 = default(int);
			FrvYRkLWzOjYdbf2nTgQ dataIn = default(FrvYRkLWzOjYdbf2nTgQ);
			FrvYRkLWzOjYdbf2nTgQ frvYRkLWzOjYdbf2nTgQ = default(FrvYRkLWzOjYdbf2nTgQ);
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			FrvYRkLWzOjYdbf2nTgQ dataOut = default(FrvYRkLWzOjYdbf2nTgQ);
			byte[] array = default(byte[]);
			byte[] result = default(byte[]);
			int num9 = default(int);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001e;
					case 1:
						num3 = System.Runtime.InteropServices.Marshal.AllocHGlobal(((global::System.Array)input).Length);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						try
						{
							System.Runtime.InteropServices.Marshal.Copy((byte[])input, 0, num3, ((global::System.Array)input).Length);
							int num4 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num4 = 7;
							}
							while (true)
							{
								bool num6;
								switch (num4)
								{
								default:
									if (num5 != 24)
									{
										if (num5 == 1004)
										{
											goto IL_009e;
										}
										goto case 10;
									}
									dataIn = frvYRkLWzOjYdbf2nTgQ;
									num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
									{
										num4 = 7;
									}
									continue;
								case 10:
								case 14:
									defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(23, 1);
									num4 = 5;
									continue;
								case 6:
								{
									frvYRkLWzOjYdbf2nTgQ.dTALJXRvARN = num3;
									int num7 = 24;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
									{
										num7 = 8;
									}
									num5 = num7;
									goto IL_009e;
								}
								case 7:
									frvYRkLWzOjYdbf2nTgQ = default(FrvYRkLWzOjYdbf2nTgQ);
									num4 = 22;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
									{
										num4 = 0;
									}
									continue;
								case 12:
									if (dataOut.mH0LJbMufBi <= 0)
									{
										num4 = 10;
										continue;
									}
									array = new byte[dataOut.mH0LJbMufBi];
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
									{
										num4 = 14;
									}
									continue;
								case 16:
									if (!protect)
									{
										num4 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
										{
											num4 = 4;
										}
										continue;
									}
									num6 = CryptProtectData(ref dataIn, "Chronal encrypted logs", global::System.IntPtr.Zero, global::System.IntPtr.Zero, global::System.IntPtr.Zero, 0, ref dataOut);
									goto IL_03b5;
								case 5:
									(defaultInterpolatedStringHandler).AppendLiteral("Windows DPAPI 操作失败，错误码 ");
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
									{
										num4 = 6;
									}
									continue;
								case 9:
									throw new CryptographicException((defaultInterpolatedStringHandler).ToStringAndClear());
								case 2:
									System.Runtime.InteropServices.Marshal.Copy(dataOut.dTALJXRvARN, array, 0, array.Length);
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
									{
										num4 = 15;
									}
									continue;
								case 1:
									defaultInterpolatedStringHandler.AppendFormatted<int>(System.Runtime.InteropServices.Marshal.GetLastWin32Error());
									num4 = 9;
									continue;
								case 15:
									if (dataOut.dTALJXRvARN != (nint)global::System.IntPtr.Zero)
									{
										num4 = 12;
										continue;
									}
									goto case 10;
								case 13:
									dataOut = default(FrvYRkLWzOjYdbf2nTgQ);
									num4 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										num4 = 16;
									}
									continue;
								case 4:
									num6 = CryptUnprotectData(ref dataIn, global::System.IntPtr.Zero, global::System.IntPtr.Zero, global::System.IntPtr.Zero, global::System.IntPtr.Zero, 0, ref dataOut);
									goto IL_03b5;
								case 11:
									LocalFree(dataOut.dTALJXRvARN);
									num4 = 3;
									continue;
								case 3:
									result = array;
									num4 = 8;
									continue;
								case 0:
									frvYRkLWzOjYdbf2nTgQ.mH0LJbMufBi = ((global::System.Array)input).Length;
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
									{
										num4 = 8;
									}
									continue;
								case 8:
									break;
									IL_009e:
									num4 = num5;
									continue;
									IL_03b5:
									if (!num6)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
										{
											num4 = 14;
										}
										continue;
									}
									goto case 15;
								}
								break;
							}
						}
						finally
						{
							System.Runtime.InteropServices.Marshal.FreeHGlobal(num3);
							int num8 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 988)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						break;
					case 2:
						break;
					}
					goto IL_0457;
					IL_001e:
					if (num == 990)
					{
						break;
					}
					goto IL_0457;
					IL_0457:
					return result;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool AslEvG9y0kMAsvwBNs77()
		{
			return m95uMT9ycKk1fN2iB0YX == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static c2FJb3fvOSATYfF0bF8t FjonLw9y8ebXGXtksDGe()
		{
			return (c2FJb3fvOSATYfF0bF8t)m95uMT9ycKk1fN2iB0YX;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_117
	{
		public static readonly __c_117 __9;

		public static Func<string, FileInfo> __9__35_0;

		public static Func<FileInfo, global::System.DateTime> __9__35_1;

		internal static __c_117 O21lhk9yyrHUCqSUEyNv;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_117()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
			{
				num = 0;
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
		internal FileInfo YjJfv5kYNNE(string path)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			return new FileInfo(path);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.DateTime Glffv6jVDkj(FileInfo info)
		{
			return (info).LastWriteTimeUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool V2AcrP9yWVMcWCMYFXnw()
		{
			return O21lhk9yyrHUCqSUEyNv == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_117 hTeA2Y9yJBMPkDYYNv2F()
		{
			return O21lhk9yyrHUCqSUEyNv;
		}
	}

	private static readonly TimeSpan sIUyiukC4h;

	private static readonly object jcCWZBouoQ;

	private static readonly object yF3W9h3ZRf;

	private static string? yi3WD4YrgJ;

	private static byte[]? RUdWkTFkKF;

	private static bool P6wWVbCWsD;

	internal static object Km7CR1ZYitSqfQly4Ib4;

	public static extern string LogDirectory
	{
		[MethodImpl((MethodImplOptions)8)]
		get;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static extern void IdOy6I4Chb(string component, string message);

	[MethodImpl((MethodImplOptions)8)]
	public static extern void U3iyRWfbJV(string component, string message, global::System.Exception? exception = null);

	[MethodImpl((MethodImplOptions)8)]
	public static extern void TyQywPUFFh(string component, string message, global::System.Exception? exception = null);

	[MethodImpl((MethodImplOptions)8)]
	public static extern void rShyeXSwgD(string component, string message);

	[MethodImpl((MethodImplOptions)8)]
	public static extern string shOyPmYErh();

	[MethodImpl((MethodImplOptions)8)]
	public static extern string fMoyx8H7Qn();

	[MethodImpl((MethodImplOptions)8)]
	public static extern string? aDCyFji7Ab();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void jHmys25o53(object level, object component, object message, global::System.Exception? exception);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string vf6yTiRfyD(object level, object component, object message, global::System.Exception? exception);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string z73yNEosw0(object value);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void NcyyMDTmr4();

	[MethodImpl((MethodImplOptions)8)]
	private static extern byte[] TMAypgSgwU(object directory);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string vV9yumqI1o();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void YndyarWu6k(object path, object text);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string srFy1ccJBv(object path);

	[MethodImpl((MethodImplOptions)8)]
	private static extern bool OrOy3veIhX(object stream, object buffer);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void B5yyvO38uU(object directory);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void ymJyEXMMLO(object path, object content);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void eony2lDcEH();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool LDhcTqZYnEivJ0KLH1Ai();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern gX17swyO7x0JWQxdaD1 StUUSjZYzv90QjeUj7J0();
}

using System;
using System.IO;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using MJcvqdChtnRHU3OjlAg;
using bjMUVyQHhKZ3abxaWAg;
using fDAldojjppXrctUVYOJn;
using ibqOI7fwdAZ7fB5vumc9;
using r5LWFs73eOlXSX66CSK;

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
			//IL_0112: Expected O, but got I4
			//IL_011c->IL00a2: Incompatible stack heights: 2 vs 1
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
									_ = 23;
									defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
									_ = 5;
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
									num6 = CryptProtectData(ref dataIn, "Chronal encrypted logs", global::nint.Zero, global::nint.Zero, global::nint.Zero, 0, ref dataOut);
									goto IL_03ad;
								case 5:
									(defaultInterpolatedStringHandler).AppendLiteral("Windows DPAPI 操作失败，错误码 ");
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
									{
										num4 = 6;
									}
									continue;
								case 9:
									throw (defaultInterpolatedStringHandler).ToStringAndClear();
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
									if (dataOut.dTALJXRvARN != (nint)global::nint.Zero)
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
									num6 = CryptUnprotectData(ref dataIn, global::nint.Zero, global::nint.Zero, global::nint.Zero, global::nint.Zero, 0, ref dataOut);
									goto IL_03ad;
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
									IL_03ad:
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
					goto IL_044f;
					IL_001e:
					if (num == 990)
					{
						break;
					}
					goto IL_044f;
					IL_044f:
					return result;
				}
			}
		}

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
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							goto end_IL_000e;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
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
		public static __c_117 __9;

		public static Func<string, FileInfo> __9__35_0;

		public static Func<FileInfo, global::System.DateTime> __9__35_1;

		internal static __c_117 O21lhk9yyrHUCqSUEyNv;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
			while (true)
			{
				int num2 = num;
				do
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (num2 == 11)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto end_IL_0012;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
							continue;
						case 0:
							return;
						case 4:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 3;
							continue;
						case 3:
							__9 = (__c_117)new __c_117();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 10;
							}
							continue;
						case 2:
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
				while (num2 == 992);
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_117()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal FileInfo YjJfv5kYNNE(string path)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return default(FileInfo);
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

	public unsafe static string LogDirectory
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0025: Expected I4, but got O
			//IL_00f8: Expected O, but got I4
			//IL_007e: Expected I4, but got O
			//IL_005b->IL006d: Incompatible stack types: I4 vs O
			//IL_010c->IL0010: Incompatible stack types: I4 vs O
			//IL_0132->IL0010: Incompatible stack types: I4 vs O
			//IL_0066->IL006d: Incompatible stack types: I4 vs O
			//IL_0117->IL0010: Incompatible stack types: I4 vs O
			//IL_013d->IL0010: Incompatible stack types: I4 vs O
			//IL_00c6->IL006d: Incompatible stack types: I4 vs O
			//IL_00aa->IL006d: Incompatible stack types: I4 vs O
			//IL_00b5->IL006d: Incompatible stack types: I4 vs O
			object obj = 2;
			object obj3 = default(object);
			object obj4 = default(object);
			object obj6 = default(object);
			object result = default(object);
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 991)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 0:
					{
						System.Threading.Monitor.Enter(obj3, ref obj4);
						object obj5 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							obj5 = 1;
						}
						while (true)
						{
							switch ((int)obj5)
							{
							default:
								if ((nint)obj6 == 990)
								{
									obj5 = obj6;
									continue;
								}
								goto case 0;
							case 1:
								NcyyMDTmr4();
								obj5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
								{
									obj5 = 0;
								}
								continue;
							case 0:
								result = yi3WD4YrgJ;
								obj5 = 2;
								continue;
							case 2:
								break;
							}
							break;
						}
						goto case 3;
					}
					case 3:
						return (string)result;
					case 1:
						obj4 = 0;
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							obj2 = 0;
						}
						break;
					case 2:
						obj3 = yF3W9h3ZRf;
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							obj2 = 1;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void IdOy6I4Chb(string component, string message)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0068->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_001d;
				case 0:
					return;
				case 1:
					break;
				}
				goto IL_0031;
				IL_001d:
				if ((nint)obj == 989)
				{
					break;
				}
				goto IL_0031;
				IL_0031:
				jHmys25o53("INFO", component, message, null);
				obj2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
				{
					obj2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void U3iyRWfbJV(string component, string message, global::System.Exception? exception = null)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0069->IL0010: Incompatible stack types: I4 vs O
		//IL_0074->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 0:
					return;
				case 1:
					jHmys25o53("WARN", component, message, exception);
					obj2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
					{
						obj2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while ((nint)obj == 989);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void TyQywPUFFh(string component, string message, global::System.Exception? exception = null)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0067->IL0010: Incompatible stack types: I4 vs O
		//IL_0072->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_001d;
				case 1:
					break;
				case 0:
					return;
				}
				goto IL_0030;
				IL_001d:
				if ((nint)obj == 989)
				{
					break;
				}
				goto IL_0030;
				IL_0030:
				jHmys25o53("ERROR", component, message, exception);
				obj2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
				{
					obj2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void rShyeXSwgD(string component, string message)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0068->IL0010: Incompatible stack types: I4 vs O
		//IL_0073->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_001d;
				case 0:
					return;
				case 1:
					break;
				}
				goto IL_0031;
				IL_001d:
				if ((nint)obj == 989)
				{
					break;
				}
				goto IL_0031;
				IL_0031:
				jHmys25o53("DEBUG", component, message, null);
				obj2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
				{
					obj2 = 6;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static string shOyPmYErh()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static string fMoyx8H7Qn()
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0084: Expected O, but got I4
		//IL_006e: Expected I4, but got O
		//IL_00d4: Expected I4, but got O
		//IL_004f->IL0061: Incompatible stack types: I4 vs O
		//IL_005a->IL0061: Incompatible stack types: I4 vs O
		//IL_0098->IL0061: Incompatible stack types: I4 vs O
		//IL_00bc->IL00c3: Incompatible stack types: I4 vs O
		//IL_00a3->IL0061: Incompatible stack types: I4 vs O
		//IL_010c->IL00c3: Incompatible stack types: I4 vs O
		//IL_0130->IL00c3: Incompatible stack types: I4 vs O
		//IL_0117->IL00c3: Incompatible stack types: I4 vs O
		//IL_013b->IL00c3: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj5 = default(object);
		object obj4 = default(object);
		object obj7 = default(object);
		object result = default(object);
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				break;
			case 1:
			{
				object obj2 = yF3W9h3ZRf;
				object obj3 = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
				{
					obj3 = 0;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						if ((nint)obj5 == 989)
						{
							obj3 = obj5;
							continue;
						}
						break;
					case 0:
						obj4 = 0;
						obj3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
						{
							obj3 = 3;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				System.Threading.Monitor.Enter(obj2, ref obj4);
				object obj6 = 2;
				while (true)
				{
					switch ((int)obj6)
					{
					case 0:
						break;
					default:
						if ((nint)obj7 == 990)
						{
							obj6 = obj7;
							continue;
						}
						goto case 2;
					case 1:
						result = System.IO.Path.GetFileName(vV9yumqI1o());
						obj6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							obj6 = 0;
						}
						continue;
					case 2:
						NcyyMDTmr4();
						obj6 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							obj6 = 1;
						}
						continue;
					}
					break;
				}
				break;
			}
			}
			break;
		}
		while ((nint)obj == 989);
		return (string)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static string? aDCyFji7Ab()
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0081: Expected O, but got I4
		//IL_006b: Expected I4, but got O
		//IL_00bf: Expected O, but got I4
		//IL_00d8: Expected I4, but got O
		//IL_004c->IL005e: Incompatible stack types: I4 vs O
		//IL_0057->IL005e: Incompatible stack types: I4 vs O
		//IL_0095->IL005e: Incompatible stack types: I4 vs O
		//IL_00b9->IL00c3: Incompatible stack types: I4 vs O
		//IL_00a0->IL005e: Incompatible stack types: I4 vs O
		//IL_0138->IL00c3: Incompatible stack types: I4 vs O
		//IL_0143->IL00c3: Incompatible stack types: I4 vs O
		//IL_017d->IL00c3: Incompatible stack types: I4 vs O
		//IL_0188->IL00c3: Incompatible stack types: I4 vs O
		//IL_0165->IL00c3: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj5 = default(object);
		object obj4 = default(object);
		object obj8 = default(object);
		object obj9 = default(object);
		object result = default(object);
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 1:
			{
				object obj2 = yF3W9h3ZRf;
				object obj3 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
				{
					obj3 = 5;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						if ((nint)obj5 == 989)
						{
							obj3 = obj5;
							continue;
						}
						break;
					case 0:
						obj4 = 0;
						obj3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							obj3 = 1;
						}
						continue;
					case 1:
						break;
					}
					break;
				}
				System.Threading.Monitor.Enter(obj2, ref obj4);
				object obj6 = 1;
				while (true)
				{
					object obj7;
					switch ((int)obj6)
					{
					default:
						if ((nint)obj8 != 11)
						{
							if ((nint)obj8 == 991)
							{
								goto IL_00bf;
							}
							goto case 0;
						}
						if (!System.IO.File.Exists((string)obj9))
						{
							obj6 = 3;
							continue;
						}
						obj7 = obj9;
						goto IL_0167;
					case 0:
					{
						obj9 = vV9yumqI1o();
						int num = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num = 10;
						}
						obj8 = num;
						goto IL_00bf;
					}
					case 1:
						NcyyMDTmr4();
						obj6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							obj6 = 10;
						}
						continue;
					case 3:
						obj7 = null;
						goto IL_0167;
					case 2:
						break;
						IL_0167:
						result = obj7;
						obj6 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							obj6 = 2;
						}
						continue;
						IL_00bf:
						obj6 = obj8;
						continue;
					}
					break;
				}
				break;
			}
			case 0:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		return (string?)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void jHmys25o53(object level, object component, object message, global::System.Exception? exception)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_017e: Expected O, but got I4
		//IL_0063: Expected I4, but got O
		//IL_0095: Expected O, but got I4
		//IL_00aa: Expected I4, but got O
		//IL_0047->IL004e: Incompatible stack types: I4 vs O
		//IL_008f->IL0099: Incompatible stack types: I4 vs O
		//IL_0192->IL004e: Incompatible stack types: I4 vs O
		//IL_0170->IL004e: Incompatible stack types: I4 vs O
		//IL_019d->IL004e: Incompatible stack types: I4 vs O
		//IL_017b->IL004e: Incompatible stack types: I4 vs O
		//IL_00fa->IL0099: Incompatible stack types: I4 vs O
		//IL_011e->IL0099: Incompatible stack types: I4 vs O
		//IL_0105->IL0099: Incompatible stack types: I4 vs O
		//IL_0129->IL0099: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		object text = vf6yTiRfyD(level, component, message, exception);
		object obj2 = 3;
		object obj4 = default(object);
		object obj3 = default(object);
		object obj5 = default(object);
		object obj7 = default(object);
		while (true)
		{
			switch ((int)obj2)
			{
			case 2:
				return;
			default:
				if ((nint)obj4 == 991)
				{
					obj2 = obj4;
					continue;
				}
				break;
			case 0:
			{
				System.Threading.Monitor.Enter(obj3, ref obj5);
				object obj6 = 2;
				while (true)
				{
					switch ((int)obj6)
					{
					default:
						if ((nint)obj7 == 10)
						{
							return;
						}
						if ((nint)obj7 != 990)
						{
							break;
						}
						goto IL_0095;
					case 1:
						eony2lDcEH();
						obj7 = 10;
						goto IL_0095;
					case 0:
						YndyarWu6k(vV9yumqI1o(), text);
						obj6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							obj6 = 4;
						}
						continue;
					case 2:
						break;
						IL_0095:
						obj6 = obj7;
						continue;
					}
					NcyyMDTmr4();
					obj6 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
					{
						obj6 = 0;
					}
				}
			}
			case 3:
				obj3 = yF3W9h3ZRf;
				obj2 = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
				{
					obj2 = 1;
				}
				continue;
			case 1:
				break;
			}
			obj5 = 0;
			obj2 = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string vf6yTiRfyD(object level, object component, object message, global::System.Exception? exception)
	{
		object obj = string.Concat((string)obj, System.Environment.NewLine, Ujvc33C40toMjHRXEol.qw5CUQbJIS(exception));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string z73yNEosw0(object value)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NcyyMDTmr4()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0109: Expected O, but got I4
		//IL_013a: Expected I4, but got O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		//IL_005b->IL0010: Incompatible stack types: I4 vs O
		//IL_00f8->IL010d: Incompatible stack types: I4 vs O
		//IL_00d6->IL0010: Incompatible stack types: I4 vs O
		//IL_0103->IL010d: Incompatible stack types: I4 vs O
		//IL_026c->IL010d: Incompatible stack types: I4 vs O
		//IL_02c3->IL010d: Incompatible stack types: I4 vs O
		//IL_029d->IL010d: Incompatible stack types: I4 vs O
		//IL_020f->IL010d: Incompatible stack types: I4 vs O
		//IL_0277->IL010d: Incompatible stack types: I4 vs O
		//IL_02ce->IL010d: Incompatible stack types: I4 vs O
		//IL_02a8->IL010d: Incompatible stack types: I4 vs O
		//IL_01e9->IL010d: Incompatible stack types: I4 vs O
		//IL_021a->IL010d: Incompatible stack types: I4 vs O
		//IL_01c0->IL010d: Incompatible stack types: I4 vs O
		//IL_01f4->IL010d: Incompatible stack types: I4 vs O
		//IL_01cb->IL010d: Incompatible stack types: I4 vs O
		//IL_024c->IL010d: Incompatible stack types: I4 vs O
		int num = 3;
		object obj3 = default(object);
		object obj6 = default(object);
		object obj5 = default(object);
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
					{
						if ((nint)obj != 10)
						{
							if ((nint)obj == 991)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						System.IO.Directory.CreateDirectory((string)obj3);
						object obj4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
						{
							obj4 = 17;
						}
						while (true)
						{
							int num2;
							switch ((int)obj4)
							{
							case 2:
								return;
							default:
								if ((nint)obj6 != 17)
								{
									if ((nint)obj6 == 997)
									{
										goto IL_0109;
									}
									goto case 0;
								}
								if (string.Equals(System.IO.Path.GetFullPath((string)obj5), System.IO.Path.GetFullPath((string)obj3), (StringComparison)5))
								{
									return;
								}
								obj4 = 7;
								break;
							case 8:
								obj5 = System.IO.Path.Combine(JNVYTu71oRZRpWuML35.LegacyLocalDataRoot, "logs");
								num2 = 17;
								goto IL_0105;
							case 0:
								yi3WD4YrgJ = (string?)obj3;
								num2 = 5;
								goto IL_0105;
							case 6:
							case 9:
								if (P6wWVbCWsD)
								{
									return;
								}
								obj4 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
								{
									obj4 = 17;
								}
								break;
							case 5:
								if (RUdWkTFkKF != null)
								{
									obj4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										obj4 = 6;
									}
									break;
								}
								goto case 1;
							case 7:
								B5yyvO38uU(obj5);
								obj4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
								{
									obj4 = 4;
								}
								break;
							case 1:
								RUdWkTFkKF = TMAypgSgwU(obj3);
								obj4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
								{
									obj4 = 9;
								}
								break;
							case 4:
								P6wWVbCWsD = true;
								obj4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
								{
									obj4 = 3;
								}
								break;
							case 3:
								{
									B5yyvO38uU(obj3);
									obj4 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
									{
										obj4 = 15;
									}
									break;
								}
								IL_0105:
								obj6 = num2;
								goto IL_0109;
								IL_0109:
								obj4 = obj6;
								break;
							}
						}
					}
					case 1:
						return;
					case 3:
						if (yi3WD4YrgJ != null)
						{
							obj2 = 2;
							continue;
						}
						break;
					case 0:
						return;
					case 2:
						if (RUdWkTFkKF != null)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						break;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			obj3 = System.IO.Path.Combine(JNVYTu71oRZRpWuML35.LocalDataRoot, "logs");
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
			{
				num = 1;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static byte[] TMAypgSgwU(object directory)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_00a6->IL0010: Incompatible stack types: I4 vs O
		//IL_0059->IL0010: Incompatible stack types: I4 vs O
		//IL_00b1->IL0010: Incompatible stack types: I4 vs O
		//IL_0064->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj3 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 0:
					if (!System.IO.File.Exists((string)obj3))
					{
						byte[] array2 = System.Security.Cryptography.RandomNumberGenerator.GetBytes(32);
						object obj4 = c2FJb3fvOSATYfF0bF8t.Protect(array2);
						object obj5 = obj3;
						string text = ".tmp-";
						object obj6 = System.Guid.NewGuid();
						string text2 = string.Concat((string)obj5, text, (obj6).ToString("N"));
						System.IO.File.WriteAllBytes(text2, (byte[])obj4);
						System.IO.File.Move(text2, (string)obj3, true);
						return array2;
					}
					obj2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						obj2 = 2;
					}
					break;
				case 1:
					obj3 = System.IO.Path.Combine((string)directory, "key.dpapi");
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						obj2 = 3;
					}
					break;
				case 2:
				{
					byte[] array = c2FJb3fvOSATYfF0bF8t.Unprotect(System.IO.File.ReadAllBytes((string)obj3));
					if (array.Length != 32)
					{
						throw new global::System.Exception("本地日志密钥长度无效");
					}
					return array;
				}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string vV9yumqI1o()
	{
		object obj = System.DateTime.Now;
		object obj2 = default(object);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj2)).AppendFormatted((*(global::System.DateTime*)(&obj)).ToString("yyyyMMdd"));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void YndyarWu6k(object path, object text)
	{
		//IL_0039: Expected O, but got I4
		object obj = (jcCWZBouoQ).GetBytes((string)text);
		object obj2 = System.Security.Cryptography.RandomNumberGenerator.GetBytes(12);
		object obj3 = new DateTimeOffset[((global::System.Array)obj).Length];
		object obj4 = new DateTimeOffset[16];
		object obj5 = 16;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string srFy1ccJBv(object path)
	{
		//IL_0021: Expected O, but got I4
		//IL_0021: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		//IL_0034: Expected O, but got I4
		//IL_005c: Expected O, but got I4
		_ = 8;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e;
		_ = 4;
		object obj2 = default(object);
		object obj = JsonContent.Create<YHY2llfwl8ExTrwU63sb>((YHY2llfwl8ExTrwU63sb)obj2, (MediaTypeHeaderValue)(object)0, (JsonSerializerOptions)(object)12);
		_ = 9;
		obj = JsonContent.Create<YHY2llfwl8ExTrwU63sb>((YHY2llfwl8ExTrwU63sb)obj2, (MediaTypeHeaderValue)(object)12, (JsonSerializerOptions)(object)16);
		_ = 8;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76;
		_ = 6;
		object obj4 = default(object);
		object obj3 = System.BitConverter.ToInt32((global::System.ReadOnlySpan<byte>)obj4);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool OrOy3veIhX(object stream, object buffer)
	{
		//IL_000c: Expected O, but got I4
		//IL_002d: Expected I4, but got O
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected I4, but got Unknown
		//IL_0095: Expected I4, but got O
		//IL_0097: Expected O, but got I4
		//IL_00cd: Expected O, but got I4
		//IL_00ab->IL0010: Incompatible stack types: I4 vs O
		//IL_00e1->IL0010: Incompatible stack types: I4 vs O
		//IL_00b6->IL0010: Incompatible stack types: I4 vs O
		//IL_00ec->IL0010: Incompatible stack types: I4 vs O
		//IL_00ca->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
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
								goto end_IL_0010;
							}
							goto case 3;
						}
						return false;
					case 4:
						break;
					case 3:
						return true;
					case 0:
						obj4 = (stream).Read((byte[])buffer, (int)obj3, ((global::System.Array)buffer).Length - obj3);
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							obj2 = 11;
						}
						continue;
					case 1:
					case 5:
						if ((nint)obj3 >= ((global::System.Array)buffer).Length)
						{
							obj2 = 3;
							continue;
						}
						goto case 0;
					case 2:
						obj3 = 0;
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							obj2 = 1;
						}
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			if ((nint)obj4 <= 0)
			{
				num = 12;
				continue;
			}
			obj3 += obj4;
			num = 5;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void B5yyvO38uU(object directory)
	{
		object obj = default(object);
		ymJyEXMMLO(obj, System.IO.File.ReadAllText((string)obj, System.Text.Encoding.UTF8));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ymJyEXMMLO(object path, object content)
	{
		//IL_000c: Expected O, but got I4
		//IL_004d: Expected I4, but got O
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_00c0: Expected O, but got I4
		//IL_0252: Expected I4, but got O
		//IL_00db->IL0010: Incompatible stack types: I4 vs O
		//IL_01bc->IL0010: Incompatible stack types: I4 vs O
		//IL_02ac->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		//IL_00ca->IL0010: Incompatible stack types: I4 vs O
		//IL_0102->IL0010: Incompatible stack types: I4 vs O
		//IL_00b2->IL0010: Incompatible stack types: I4 vs O
		//IL_01ec->IL0010: Incompatible stack types: I4 vs O
		//IL_0127->IL0010: Incompatible stack types: I4 vs O
		//IL_01c7->IL0010: Incompatible stack types: I4 vs O
		//IL_0093->IL0010: Incompatible stack types: I4 vs O
		//IL_0237->IL0249: Incompatible stack types: I4 vs O
		//IL_00bd->IL0010: Incompatible stack types: I4 vs O
		//IL_01f7->IL0010: Incompatible stack types: I4 vs O
		//IL_0132->IL0010: Incompatible stack types: I4 vs O
		//IL_0242->IL0249: Incompatible stack types: I4 vs O
		int num = 6;
		object obj8 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		object obj3 = default(object);
		object obj6 = default(object);
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
					{
						if ((nint)obj != 20)
						{
							if ((nint)obj == 1001)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						System.IO.File.Delete((string)path);
						object obj7 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							obj7 = 6;
						}
						while (true)
						{
							switch ((int)obj7)
							{
							case 0:
								return;
							}
							if ((nint)obj8 != 988)
							{
								return;
							}
							obj7 = obj8;
						}
					}
					case 8:
						obj4++;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
					case 12:
						if ((nint)obj4 < ((global::System.Array)obj5).Length)
						{
							obj2 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								obj2 = 7;
							}
							continue;
						}
						break;
					case 9:
						obj4 = 0;
						obj2 = 12;
						continue;
					case 2:
					case 10:
						obj3 = ((object[])obj5)[obj4];
						obj2 = 4;
						continue;
					case 11:
						return;
					case 13:
						obj5 = (c7OGv5QKxt7AwetRqiP.acYQthGMrG((string?)content)).Split('\n', (StringSplitOptions)0);
						obj2 = 9;
						continue;
					case 5:
						if (System.IO.File.Exists((string)obj6))
						{
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 13;
					case 6:
						obj6 = System.IO.Path.Combine(yi3WD4YrgJ, string.Concat("legacy-", (System.IO.Path.GetFileName((string)path)).Replace('.', '-'), ".clog"));
						obj2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							obj2 = 5;
						}
						continue;
					case 4:
						if (!string.IsNullOrWhiteSpace((string)obj3))
						{
							obj2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 8;
					case 1:
					case 3:
						break;
					case 7:
						YndyarWu6k(obj6, string.Concat((string)obj3, System.Environment.NewLine));
						obj2 = 8;
						continue;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 17;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
			{
				num = 20;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void eony2lDcEH()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool LDhcTqZYnEivJ0KLH1Ai()
	{
		return Km7CR1ZYitSqfQly4Ib4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static gX17swyO7x0JWQxdaD1 StUUSjZYzv90QjeUj7J0()
	{
		return (gX17swyO7x0JWQxdaD1)Km7CR1ZYitSqfQly4Ib4;
	}
}

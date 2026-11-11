using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace X8Xn04fS269eXTr3GGu1;

internal class jSaVIGfSEMcLFoc1CMPV
{
	[CompilerGenerated]
	private class __O_30
	{
		public static Func<string, long> _0___GetAvailableBytes;

		private static __O_30 KoVK3VDWR72pOM6BWbvd;

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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 2;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 4;
							}
							continue;
						case 0:
							break;
						case 2:
							num3 = 1;
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KTwL3SDWwtfEjlFl3Pej()
		{
			return KoVK3VDWR72pOM6BWbvd == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_30 t9vDVbDWeDl6i0ATwhEv()
		{
			return KoVK3VDWR72pOM6BWbvd;
		}
	}

	private static object C4mAl3ZMGgWMgpT2d1OT;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void EnsureAvailable(object storagePath, long requiredBytes, Func<string, long>? availableBytesProvider = null)
	{
		//IL_0289: Expected I8, but got O
		//IL_0284: Expected O, but got I
		//IL_0476->IL000d: Incompatible stack heights: 4 vs 1
		//IL_0227->IL0227: Incompatible stack heights: 1 vs 2
		//IL_0284->IL0284: Incompatible stack heights: 3 vs 1
		//IL_0256->IL0284: Incompatible stack heights: 2 vs 1
		//IL_0246->IL0223: Incompatible stack heights: 1 vs 0
		int num = 14;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		long num4 = default(long);
		string text = default(string);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Exception ex = default(global::System.Exception);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num10 = default(int);
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
						if (num2 != 23)
						{
							if (num2 == 1004)
							{
								goto end_IL_000d;
							}
							goto case 4;
						}
						(defaultInterpolatedStringHandler).AppendFormatted(FormatBytes(num4));
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
						{
							num3 = 5;
						}
						continue;
					case 0:
						(defaultInterpolatedStringHandler).AppendFormatted(text);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 2;
						}
						continue;
					case 15:
						break;
					case 7:
						throw string.Concat((defaultInterpolatedStringHandler).ToStringAndClear(), "请清理磁盘空间，或在版本管理中更改客户端存储位置。");
					case 13:
						_ = "客户端存储位置不能为空";
						throw new global::System.Exception("storagePath");
					case 1:
						_ = "requiredBytes";
						throw new global::System.Exception("所需空间必须大于零");
					case 16:
						text = System.IO.Path.GetFullPath((string)storagePath);
						num3 = 2;
						continue;
					case 2:
						try
						{
							if (availableBytesProvider != null)
							{
								goto IL_0284;
							}
							num5 = 2;
							goto IL_0227;
							IL_0227:
							int num6;
							while (true)
							{
								switch (num6)
								{
								default:
									if (num5 == 990)
									{
										continue;
									}
									goto case 1;
								case 2:
									if (__O_30._0___GetAvailableBytes == null)
									{
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num6 = 7;
										}
										continue;
									}
									break;
								case 1:
									_ = null;
									__O_30._0___GetAvailableBytes = (Func<string, long>)(object)(delegate*<object, long>)(&GetAvailableBytes);
									break;
								case 0:
									goto end_IL_0227;
								}
								goto IL_0284;
								continue;
								end_IL_0227:
								break;
							}
							goto end_IL_01fe;
							IL_0284:
							num4 = (long)text;
							num6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num6 = 0;
							}
							goto IL_0227;
							end_IL_01fe:;
						}
						catch (object obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num7 = 2;
								}
							}
							else
							{
								ex = obj2;
								num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
								{
									num7 = 1;
								}
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										goto IL_02eb;
									}
									goto case 0;
								case 0:
									result = 0;
									break;
								case 1:
									result = ((!(ex is OperationCanceledException)) ? 1 : 0);
									break;
								}
								break;
								IL_02eb:
								num7 = num8;
							}
							return (byte)result != 0;
						}).Invoke())
						{
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num9 = 6;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 988)
									{
										goto IL_0376;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0376:
								num9 = num10;
							}
							string.Concat("无法检查客户端存储位置的剩余空间：", text);
							throw ex;
						}
						goto case 6;
					case 11:
						(defaultInterpolatedStringHandler).AppendLiteral("，至少需要 ");
						num3 = 4;
						continue;
					case 4:
						(defaultInterpolatedStringHandler).AppendFormatted(FormatBytes(requiredBytes));
						num3 = 5;
						continue;
					case 10:
						(defaultInterpolatedStringHandler).AppendLiteral("；");
						num3 = 15;
						continue;
					case 9:
						return;
					case 8:
						throw new global::System.Exception("客户端存储位置返回了无效的剩余空间");
					case 3:
						if (num4 < requiredBytes)
						{
							_ = defaultInterpolatedStringHandler;
							_ = 26;
							_ = 3;
							_ = 12;
						}
						else
						{
							num3 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
							{
								num3 = 9;
							}
						}
						continue;
					case 12:
						(defaultInterpolatedStringHandler).AppendLiteral("客户端存储位置空间不足。位置：");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num3 = 18;
						}
						continue;
					case 5:
						(defaultInterpolatedStringHandler).AppendLiteral("。");
						num3 = 7;
						continue;
					case 14:
						if (!string.IsNullOrWhiteSpace((string)storagePath))
						{
							if (requiredBytes > 0)
							{
								num3 = 16;
								continue;
							}
							goto case 1;
						}
						num3 = 13;
						continue;
					case 6:
						if (num4 >= 0)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 8;
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
			(defaultInterpolatedStringHandler).AppendLiteral("可用 ");
			num = 23;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long GetAvailableBytes(object storagePath)
	{
		int num = 2;
		ulong freeBytesAvailableToCaller = default(ulong);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001e;
				case 0:
					return (long)freeBytesAvailableToCaller;
				case 1:
					throw System.Runtime.InteropServices.Marshal.GetLastWin32Error();
				case 2:
					break;
				}
				goto IL_0079;
				IL_001e:
				if (num == 990)
				{
					break;
				}
				goto IL_0079;
				IL_0079:
				if (GetDiskFreeSpaceEx((string)storagePath, out freeBytesAvailableToCaller, out var _, out var _))
				{
					if (freeBytesAvailableToCaller > 9223372036854775807L)
					{
						return 9223372036854775807L;
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatBytes(long bytes)
	{
		int num = 1;
		double num4 = default(double);
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_000d;
							}
							goto case 2;
						}
						return string.Concat((num4).ToString("0.##", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture), " GB");
					case 1:
						if (bytes >= 1073741824)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						num4 = (double)bytes / 1048576.0;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return string.Concat((num4).ToString("0.##", (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture), " MB");
					case 0:
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
			num4 = (double)bytes / 1073741824.0;
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
			{
				num = 0;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetDiskFreeSpaceEx(string directoryName, out ulong freeBytesAvailableToCaller, out ulong totalNumberOfBytes, out ulong totalNumberOfFreeBytes);

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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					case 2:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 1;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xWnri0ZMiVyuxES5C95B()
	{
		return C4mAl3ZMGgWMgpT2d1OT == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jSaVIGfSEMcLFoc1CMPV jvrjCpZMnHJb6teBFMYF()
	{
		return (jSaVIGfSEMcLFoc1CMPV)C4mAl3ZMGgWMgpT2d1OT;
	}
}

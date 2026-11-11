using System;
using System.IO;
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
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
	internal static void EnsureAvailable(object storagePath, long requiredBytes, Func<string, long>? availableBytesProvider = null)
	{
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		int num = 14;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		long num4 = default(long);
		string text = default(string);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
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
						throw new IOException(string.Concat((defaultInterpolatedStringHandler).ToStringAndClear(), "请清理磁盘空间，或在版本管理中更改客户端存储位置。"));
					case 13:
						throw new ArgumentException("客户端存储位置不能为空", "storagePath");
					case 1:
						throw new ArgumentOutOfRangeException("requiredBytes", "所需空间必须大于零");
					case 16:
						text = System.IO.Path.GetFullPath((string)storagePath);
						num3 = 2;
						continue;
					case 2:
						try
						{
							Func<string, long> obj = availableBytesProvider;
							if (obj != null)
							{
								goto IL_0294;
							}
							num5 = 2;
							goto IL_022f;
							IL_0233:
							int num6;
							while (true)
							{
								switch (num6)
								{
								case 2:
									goto IL_0257;
								case 1:
									goto IL_0282;
								case 0:
									goto end_IL_0233;
								}
								if (num5 == 990)
								{
									goto IL_022f;
								}
								goto IL_0282;
								IL_0257:
								obj = __O_30._0___GetAvailableBytes;
								if (obj == null)
								{
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num6 = 7;
									}
									continue;
								}
								goto IL_0294;
								IL_0282:
								obj = (__O_30._0___GetAvailableBytes = GetAvailableBytes);
								goto IL_0294;
								continue;
								end_IL_0233:
								break;
							}
							goto end_IL_020a;
							IL_0294:
							num4 = obj.Invoke(text);
							num6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num6 = 0;
							}
							goto IL_0233;
							IL_022f:
							num6 = num5;
							goto IL_0233;
							end_IL_020a:;
						}
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num7 = 2;
								}
							}
							else
							{
								ex = obj3;
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
										goto IL_02ff;
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
								IL_02ff:
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
										goto IL_038a;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_038a:
								num9 = num10;
							}
							throw new InvalidOperationException(string.Concat("无法检查客户端存储位置的剩余空间：", text), ex);
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
						throw new InvalidOperationException("客户端存储位置返回了无效的剩余空间");
					case 3:
						if (num4 < requiredBytes)
						{
							defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(26, 3);
							num3 = 12;
							continue;
						}
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
						{
							num3 = 9;
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
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FormatBytes(long bytes)
	{
		int num = 1;
		return null;
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetDiskFreeSpaceEx(string directoryName, out ulong freeBytesAvailableToCaller, out ulong totalNumberOfBytes, out ulong totalNumberOfFreeBytes);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

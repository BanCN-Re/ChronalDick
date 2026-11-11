using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;
using xAceLqXWMytQDox0p5bJ;

namespace GhiZg2XJQSmZ7QXjDJQI;

internal class PbDAprXJJW94oIcT3mir
{
	private static object JpFm2nZdVJHnVsqbKtum;

	[MethodImpl((MethodImplOptions)8)]
	internal static string EventName(object target)
	{
		string text = "Local\\Chronal.JavaProxy.Ready.v1.";
		int processId = ((HTA2r6XWNKDt09pf0WBJ)target).ProcessId;
		string text2 = (processId).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
		string text3 = ".";
		global::System.DateTime startTimeUtc = ((HTA2r6XWNKDt09pf0WBJ)target).StartTimeUtc;
		long num = (startTimeUtc).ToFileTimeUtc();
		return string.Concat(text, text2, text3, (num).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsInitialized(object target)
	{
		int num = 2;
		SafeWaitHandle val = default(SafeWaitHandle);
		uint num4 = default(uint);
		int num6 = default(int);
		bool result = default(bool);
		bool flag = default(bool);
		int num5 = default(int);
		int num9 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_000d;
					}
					goto case 2;
				case 2:
					val = OpenEvent(1048576u, inheritHandle: false, EventName(target));
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					break;
				case 1:
					try
					{
						int num3;
						if ((val).IsInvalid)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num4 = WaitForSingleObject(val, 0u);
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num6 != 21)
								{
									if (num6 == 1001)
									{
										goto IL_00a5;
									}
									goto case 6;
								}
								break;
							case 11:
							case 13:
								System.Runtime.InteropServices.Marshal.GetLastWin32Error();
								throw new global::System.Exception("核对组件初始化状态失败。");
							case 1:
							case 3:
							{
								result = flag;
								int num7 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
								{
									num7 = 21;
								}
								num6 = num7;
								goto IL_00a5;
							}
							case 6:
								result = false;
								num3 = 9;
								continue;
							case 10:
								if (num4 != 258)
								{
									num3 = 11;
									continue;
								}
								goto case 8;
							case 2:
								if (num4 == 0)
								{
									num3 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 10;
							case 12:
								throw new global::System.Exception("无法读取目标游戏的组件初始化状态。");
							case 9:
								break;
							case 0:
							case 7:
								flag = true;
								num3 = 3;
								continue;
							case 5:
								if (num5 == 2)
								{
									num3 = 6;
									continue;
								}
								goto case 12;
							case 8:
								flag = false;
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								{
									num5 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
									num3 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								IL_00a5:
								num3 = num6;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num8 = 5;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 989)
									{
										num8 = num9;
										continue;
									}
									break;
								case 1:
									(val).Dispose();
									num8 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num8 = 6;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					break;
				}
				return result;
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "OpenEventW", SetLastError = true)]
	private static extern SafeWaitHandle OpenEvent(uint desiredAccess, [MarshalAs((UnmanagedType)2)] bool inheritHandle, string name);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern uint WaitForSingleObject(SafeWaitHandle handle, uint milliseconds);

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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 1:
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					case 2:
						return;
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
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool aDNdqkZdYMB5YXLA4O3o()
	{
		return JpFm2nZdVJHnVsqbKtum == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PbDAprXJJW94oIcT3mir mrVoZjZdS7Ph7AqYgVSr()
	{
		return (PbDAprXJJW94oIcT3mir)JpFm2nZdVJHnVsqbKtum;
	}
}

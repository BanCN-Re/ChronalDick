using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using cTpd1lf54YS57isqnyoi;
using fDAldojjppXrctUVYOJn;
using hGYycdXXDoG2mOL5yubN;

namespace ukP35Jzt5b38OvfDOL9;

internal class enUnXWzH2140NUR5ig9
{
	private static readonly TimeSpan HoozR62A3E;

	private static readonly TimeSpan E4Ozw9EObD;

	internal static object fsxgSXZmB9OibNghCj78;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task uE9zOYj6fv(object process, object expected, bool hostAcceptedShutdown, bool allowForcedTermination, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_StopForComponentUpdateAsync_d__2 stopForComponentUpdateAsync_d__ = default(_StopForComponentUpdateAsync_d__2);
		stopForComponentUpdateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JsTz5GvHef(object process, object expected)
	{
		int num = 2;
		int num7 = default(int);
		string text = default(string);
		global::System.DateTime dateTime = default(global::System.DateTime);
		long num5 = default(long);
		bool result = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num10 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num12 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					System.ArgumentNullException.ThrowIfNull(expected, "expected");
					num2 = 3;
					continue;
				case 2:
					System.ArgumentNullException.ThrowIfNull(process, "process");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					try
					{
						global::System.DateTime? startTime = ((NYI398f5COw5dgT3xbBV)expected).StartTime;
						int num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							object obj;
							int num8;
							int num6;
							long num4;
							switch (num3)
							{
							default:
							{
								if (num7 != 28)
								{
									if (num7 == 1008)
									{
										goto IL_00e3;
									}
									goto case 2;
								}
								ProcessModule obj2 = ((dynamic)(process)).MainModule;
								if (obj2 == null)
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								obj = (obj2).FileName;
								goto IL_0446;
							}
							case 4:
								num8 = (Q8xMnNXX9IjGqqCAeb4q.yWMXXVOZltL(text) ? 1 : 0);
								break;
							case 8:
								dateTime = ((dynamic)(process)).StartTime;
								num3 = 5;
								continue;
							case 7:
								dateTime = (dateTime).ToUniversalTime();
								num3 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								if (((NYI398f5COw5dgT3xbBV)expected).SessionId < 0)
								{
									num3 = 2;
									continue;
								}
								goto case 16;
							case 14:
								if (((dynamic)(process)).HasExited)
								{
									num3 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto case 13;
							case 17:
								if ((dateTime).Ticks == num5)
								{
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 2;
							case 13:
								if (((dynamic)(process)).Id == ((NYI398f5COw5dgT3xbBV)expected).ProcessId)
								{
									num3 = 15;
									continue;
								}
								goto case 2;
							case 5:
								dateTime = (dateTime).ToUniversalTime();
								num3 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num3 = 28;
								}
								continue;
							case 16:
								if (((dynamic)(process)).SessionId == ((NYI398f5COw5dgT3xbBV)expected).SessionId)
								{
									num3 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 2;
							case 15:
								if (num5 > 0)
								{
									num3 = 8;
									continue;
								}
								goto case 2;
							case 9:
								if (!startTime.HasValue)
								{
									num3 = 27;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
									{
										num3 = 20;
									}
								}
								else
								{
									dateTime = startTime.GetValueOrDefault();
									num3 = 7;
								}
								continue;
							case 6:
								if (string.IsNullOrWhiteSpace(text))
								{
									num6 = 11;
									goto IL_00df;
								}
								goto case 10;
							case 10:
								if (!string.Equals(System.IO.Path.GetFullPath(text), System.IO.Path.GetFullPath(((NYI398f5COw5dgT3xbBV)expected).ExecutablePath), (StringComparison)5))
								{
									num3 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 4;
							case 20:
								num4 = 0L;
								goto IL_03df;
							case 18:
								num4 = (dateTime).Ticks;
								goto IL_03df;
							case 1:
								obj = null;
								goto IL_0446;
							case 2:
							case 3:
							case 11:
							case 19:
								num8 = 0;
								break;
							case 12:
								goto end_IL_00e7;
								IL_03df:
								num5 = num4;
								num6 = 28;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
								{
									num6 = 28;
								}
								goto IL_00df;
								IL_00e3:
								num3 = num7;
								continue;
								IL_00df:
								num7 = num6;
								goto IL_00e3;
								IL_0446:
								text = (string)obj;
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							result = (byte)num8 != 0;
							num3 = 12;
							continue;
							end_IL_00e7:
							break;
						}
					}
					catch (global::System.Exception obj3) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj4 = obj3 as global::System.Exception;
						if (obj4 == null)
						{
							num9 = 5;
						}
						else
						{
							ex = obj4;
							num9 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num9 = 7;
							}
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 != 19 && num10 == 999)
								{
									goto IL_04a2;
								}
								goto case 6;
							case 6:
							case 7:
								flag = true;
								num9 = 2;
								continue;
							case 1:
								if (!(ex is InvalidOperationException))
								{
									num9 = 8;
									continue;
								}
								goto case 6;
							case 3:
								if (!(ex is IOException))
								{
									num9 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num9 = 0;
									}
									continue;
								}
								goto case 6;
							case 10:
								if (ex is ArgumentException)
								{
									num9 = 6;
									continue;
								}
								goto case 4;
							case 8:
								if (ex is NotSupportedException)
								{
									num10 = 19;
									goto IL_04a2;
								}
								goto case 3;
							case 0:
								if (!(ex is UnauthorizedAccessException))
								{
									num9 = 10;
									continue;
								}
								goto case 6;
							case 4:
								flag = false;
								num9 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num9 = 8;
								}
								continue;
							case 11:
								if (ex is Win32Exception)
								{
									num9 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
									{
										num9 = 7;
									}
									continue;
								}
								goto case 1;
							case 5:
								result2 = 0;
								break;
							case 2:
							case 9:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_04a2:
								num9 = num10;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num11 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 989)
								{
									num11 = num12;
									continue;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_06a5;
							}
							result = false;
							num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
							{
								num11 = 2;
							}
							continue;
							end_IL_06a5:
							break;
						}
					}
					break;
				case 0:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<bool> wkoz62VIiF(object process, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_WaitForExitAsync_d__4 waitForExitAsync_d__ = default(_WaitForExitAsync_d__4);
		waitForExitAsync_d__.__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HWPJdLZmgMAnEb7jrneQ()
	{
		return fsxgSXZmB9OibNghCj78 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static enUnXWzH2140NUR5ig9 hWT22eZmlQhHajBBWy37()
	{
		return (enUnXWzH2140NUR5ig9)fsxgSXZmB9OibNghCj78;
	}
}

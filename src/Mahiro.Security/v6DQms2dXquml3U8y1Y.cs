using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using Vmo4hVXyvmIwyQZjF3Zr;
using fDAldojjppXrctUVYOJn;
using iFG88Vmb1p0qPpvwBpT;
using xAceLqXWMytQDox0p5bJ;

namespace sWGS082KfMuwDLQWwpA;

internal class v6DQms2dXquml3U8y1Y
{
	internal static object lu5npDZrqoBCd7hWwZF0;

	[MethodImpl((MethodImplOptions)8)]
	internal static void OsI2H4URJN(object authorization, object target, CancellationToken cancellationToken)
	{
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>> awaiter = default(TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>>);
		Process val = default(Process);
		int num5 = default(int);
		int num7 = default(int);
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
						if (num2 == 991)
						{
							goto end_IL_0010;
						}
						goto case 2;
					case 0:
						return;
					case 1:
						break;
					case 2:
					{
						int processId = ((HTA2r6XWNKDt09pf0WBJ)target).ProcessId;
						global::System.DateTime startTimeUtc = ((HTA2r6XWNKDt09pf0WBJ)target).StartTimeUtc;
						startTimeUtc = (startTimeUtc).ToUniversalTime();
						awaiter = hM3QRXozIobMSJf4Wde.ExecuteAsync(3u, new global::__f__AnonymousType65_4<string, int, long, string>((string)authorization, processId, (startTimeUtc).ToFileTimeUtc(), lZn07CXy3xSIHfSN5qv4.WB4XyEajPgQ().LibraryPath), cancellationToken).GetAwaiter();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
						{
							num3 = 2;
						}
						continue;
					}
					case 3:
						try
						{
							if ((val).Id == ((HTA2r6XWNKDt09pf0WBJ)target).ProcessId)
							{
								return;
							}
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										goto IL_0100;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0100:
								num4 = num5;
							}
							throw new InvalidOperationException("原生注入目标回执不一致。");
						}
						finally
						{
							if (val != null)
							{
								int num6 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 989)
										{
											num6 = num7;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0184;
									}
									(val).Dispose();
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
									{
										num6 = 1;
									}
									continue;
									end_IL_0184:
									break;
								}
							}
						}
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
			val = hM3QRXozIobMSJf4Wde.pPwm9ooQjF(awaiter.GetResult().Item1);
			num = 3;
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
	internal static bool dkPWVOZrG8Cnb0YJ3JVL()
	{
		return lu5npDZrqoBCd7hWwZF0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static v6DQms2dXquml3U8y1Y lOhQokZricBGNUl1cTwx()
	{
		return (v6DQms2dXquml3U8y1Y)lu5npDZrqoBCd7hWwZF0;
	}
}

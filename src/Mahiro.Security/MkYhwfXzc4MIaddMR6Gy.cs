using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CvfGGifjZQCxUvIjLvX8;
using StWYIEXu147v3eyuP7W2;
using URYDCfoED4sjjHBaoJH;
using bHoPOpfjDtsI8jVTlPxD;
using fDAldojjppXrctUVYOJn;
using iFG88Vmb1p0qPpvwBpT;
using lQs7SmfZ8MofeLgDpWlN;

namespace qY7y49Xz00h3kme1hs7Z;

internal class MkYhwfXzc4MIaddMR6Gy
{
	private static object aI9NbMZsXnUGIPwW8ABJ;

	[MethodImpl((MethodImplOptions)8)]
	internal static SVJdZVfj9nUvL0x7eSmL RGcXz8Hixuo(object process, object addresses, object payload, EU66Dufjjol83ZECAW1T mode, CancellationToken cancellationToken)
	{
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num8 = default(int);
		JsonDocument val2 = default(JsonDocument);
		int num5 = default(int);
		SVJdZVfj9nUvL0x7eSmL result = default(SVJdZVfj9nUvL0x7eSmL);
		int num7 = default(int);
		int num10 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					int num2 = ((dynamic)(process)).Id;
					global::System.DateTime dateTime = ((dynamic)(process)).StartTime;
					dateTime = (dateTime).ToUniversalTime();
					TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>> awaiter = hM3QRXozIobMSJf4Wde.ExecuteAsync(4u, new global::__f__AnonymousType51_7<int, long, string, string, uint, ulong[], ulong>(num2, (dateTime).ToFileTimeUtc(), ((s2pqjHXuaJFOKmapoTQZ)payload).FilePrefix, System.Convert.ToBase64String(((s2pqjHXuaJFOKmapoTQZ)payload).Utf8Bytes), (uint)mode, new ulong[8]
					{
						((V1NV4TfZ0HRmQ56BROEp)addresses).SafeRuntimeGet,
						((V1NV4TfZ0HRmQ56BROEp)addresses).SafeRuntimeSet,
						((V1NV4TfZ0HRmQ56BROEp)addresses).GilEnsure,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyImportAddModule,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyModuleGetDict,
						((V1NV4TfZ0HRmQ56BROEp)addresses).RunSimpleString,
						((V1NV4TfZ0HRmQ56BROEp)addresses).GilRelease,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyErrFetch
					}, ((V1NV4TfZ0HRmQ56BROEp)addresses).MainModuleName), cancellationToken).GetAwaiter();
					int num3 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
					{
						num3 = 4;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							if (num8 == 989)
							{
								num3 = num8;
								continue;
							}
							goto case 1;
						case 1:
							val2 = System.Text.Json.JsonDocument.Parse(((ReadOnlyMemory<byte>)awaiter.GetResult().Item2), default(JsonDocumentOptions));
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 2;
							}
							continue;
						case 0:
							try
							{
								JsonElement val = (val2).RootElement;
								int num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
								{
									num4 = 6;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 != 990)
										{
											break;
										}
										goto IL_01b5;
									case 1:
										break;
									case 0:
									{
										uint threadExitCode = (val).GetUInt32();
										val = (val2).RootElement;
										val = (val).GetProperty("gilState");
										int gilState = (val).GetInt32();
										val = (val2).RootElement;
										val = (val).GetProperty("runResult");
										result = (SVJdZVfj9nUvL0x7eSmL)new SVJdZVfj9nUvL0x7eSmL(threadExitCode, gilState, (val).GetInt32());
										num5 = 2;
										goto IL_01b5;
									}
									case 2:
										goto end_IL_01b9;
										IL_01b5:
										num4 = num5;
										continue;
									}
									val = (val).GetProperty("threadExitCode");
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
									{
										num4 = 0;
									}
									continue;
									end_IL_01b9:
									break;
								}
							}
							finally
							{
								int num6;
								if (val2 == null)
								{
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
									{
										num6 = 0;
									}
									goto IL_0317;
								}
								goto IL_035f;
								IL_0317:
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 990)
										{
											goto IL_0313;
										}
										break;
									case 0:
										goto end_IL_0317;
									case 1:
										break;
									case 2:
										goto end_IL_0317;
									}
									goto IL_035f;
									IL_0313:
									num6 = num7;
									continue;
									end_IL_0317:
									break;
								}
								goto end_IL_02df;
								IL_035f:
								(val2).Dispose();
								num6 = 2;
								goto IL_0317;
								end_IL_02df:;
							}
							break;
						}
						break;
					}
				}
				catch (HeOiCXovnuVhGHyE2EO heOiCXovnuVhGHyE2EO)
				{
					int num9 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						default:
							if (num10 == 988)
							{
								goto IL_03a5;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_03a5:
						num9 = num10;
					}
					global::System.Exception ex = x38XzyEQ7T6(heOiCXovnuVhGHyE2EO);
					if ((object)ex == heOiCXovnuVhGHyE2EO)
					{
						throw;
					}
					throw ex;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Exception x38XzyEQ7T6(object error)
	{
		System.ArgumentNullException.ThrowIfNull(error, "error");
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
	internal static bool NZ5nBoZsfaRoUTd1OryW()
	{
		return aI9NbMZsXnUGIPwW8ABJ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MkYhwfXzc4MIaddMR6Gy a5iGAwZsLUmifk7hfbMA()
	{
		return (MkYhwfXzc4MIaddMR6Gy)aI9NbMZsXnUGIPwW8ABJ;
	}
}

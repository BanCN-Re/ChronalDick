using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using A4N75AfjcfnnFqO7s8ad;
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
	internal unsafe static SVJdZVfj9nUvL0x7eSmL RGcXz8Hixuo(object process, object addresses, object payload, EU66Dufjjol83ZECAW1T mode, CancellationToken cancellationToken)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got I8
		//IL_00d7: Expected I4, but got O
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num7 = default(int);
		JsonDocument val3 = default(JsonDocument);
		int num4 = default(int);
		SVJdZVfj9nUvL0x7eSmL result = default(SVJdZVfj9nUvL0x7eSmL);
		int num6 = default(int);
		int num9 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					_ = 4;
					(process).Id;
					global::System.DateTime dateTime = (process).StartTime;
					dateTime = (dateTime).ToUniversalTime();
					(dateTime).ToFileTimeUtc();
					_ = ((s2pqjHXuaJFOKmapoTQZ)payload).FilePrefix;
					System.Convert.ToBase64String(((s2pqjHXuaJFOKmapoTQZ)payload).Utf8Bytes);
					TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>> val = (TaskAwaiter<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>>)hM3QRXozIobMSJf4Wde.ExecuteAsync((uint)(int)new ulong[8]
					{
						((V1NV4TfZ0HRmQ56BROEp)addresses).SafeRuntimeGet,
						((V1NV4TfZ0HRmQ56BROEp)addresses).SafeRuntimeSet,
						((V1NV4TfZ0HRmQ56BROEp)addresses).GilEnsure,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyImportAddModule,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyModuleGetDict,
						((V1NV4TfZ0HRmQ56BROEp)addresses).RunSimpleString,
						((V1NV4TfZ0HRmQ56BROEp)addresses).GilRelease,
						((V1NV4TfZ0HRmQ56BROEp)addresses).PyErrFetch
					}, ((V1NV4TfZ0HRmQ56BROEp)addresses).MainModuleName, cancellationToken);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
					{
						num2 = 4;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num7 == 989)
							{
								num2 = num7;
								continue;
							}
							goto case 1;
						case 1:
							val3 = System.Text.Json.JsonDocument.Parse((ReadOnlyMemory<byte>)((ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>*)(&val))->Item2, default(JsonDocumentOptions));
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num2 = 2;
							}
							continue;
						case 0:
							try
							{
								JsonElement val2 = (val3).RootElement;
								int num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
								{
									num3 = 6;
								}
								while (true)
								{
									switch (num3)
									{
									default:
										if (num4 != 990)
										{
											break;
										}
										goto IL_01a5;
									case 1:
										break;
									case 0:
									{
										uint threadExitCode = (val2).GetUInt32();
										val2 = (val3).RootElement;
										val2 = (val2).GetProperty("gilState");
										int gilState = (val2).GetInt32();
										val2 = (val3).RootElement;
										val2 = (val2).GetProperty("runResult");
										result = (SVJdZVfj9nUvL0x7eSmL)new SVJdZVfj9nUvL0x7eSmL(threadExitCode, gilState, (val2).GetInt32());
										num4 = 2;
										goto IL_01a5;
									}
									case 2:
										goto end_IL_01a9;
										IL_01a5:
										num3 = num4;
										continue;
									}
									val2 = (val2).GetProperty("threadExitCode");
									num3 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
									{
										num3 = 0;
									}
									continue;
									end_IL_01a9:
									break;
								}
							}
							finally
							{
								int num5;
								if (val3 == null)
								{
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
									{
										num5 = 0;
									}
									goto IL_0307;
								}
								goto IL_034f;
								IL_0307:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 == 990)
										{
											goto IL_0303;
										}
										break;
									case 0:
										goto end_IL_0307;
									case 1:
										break;
									case 2:
										goto end_IL_0307;
									}
									goto IL_034f;
									IL_0303:
									num5 = num6;
									continue;
									end_IL_0307:
									break;
								}
								goto end_IL_02cf;
								IL_034f:
								(val3).Dispose();
								num5 = 2;
								goto IL_0307;
								end_IL_02cf:;
							}
							break;
						}
						break;
					}
				}
				catch (HeOiCXovnuVhGHyE2EO heOiCXovnuVhGHyE2EO)
				{
					int num8 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
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
								goto IL_0395;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0395:
						num8 = num9;
					}
					global::System.Exception ex = x38XzyEQ7T6(heOiCXovnuVhGHyE2EO);
					if ((object)ex == heOiCXovnuVhGHyE2EO)
					{
						throw new global::System.Exception();
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto case 0;
					case 0:
						return (global::System.Exception)error;
					case 3:
						if (((HeOiCXovnuVhGHyE2EO)error).CleanupWindowsError != 0)
						{
							num = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num = 11;
							}
							break;
						}
						goto case 4;
					case 2:
						System.ArgumentNullException.ThrowIfNull(error, "error");
						num = 1;
						break;
					case 4:
						if (((HeOiCXovnuVhGHyE2EO)error).WindowsError == 3134193665u)
						{
							return (global::System.Exception)new FBhZZEfjSCpnoTvxnkUd(((HeOiCXovnuVhGHyE2EO)error).WindowsError, (global::System.Exception?)error);
						}
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						if (((HeOiCXovnuVhGHyE2EO)error).Status == 8198)
						{
							num = 3;
							break;
						}
						goto case 0;
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
					default:
						switch (num2)
						{
						case 990:
							break;
						default:
							goto end_IL_000e;
						case 9:
							goto IL_0053;
						}
						break;
					case 1:
						goto end_IL_000e;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						return;
						IL_0053:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
						{
							num3 = 0;
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

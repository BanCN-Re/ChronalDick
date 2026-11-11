using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using E8lvgpXkaerTjm5gLXSY;
using GJFHuMfF9Tsu20PjaEve;
using KAQdBKX0RD135sYYdI7g;
using RkEBBcxE6uQHIJCVGy1;
using XQwLpPX8X2gLJv9RM0na;
using fDAldojjppXrctUVYOJn;
using gbTxoOX08yKDEWBLvu1I;
using l3hVEMX8SYNAaT7v97jF;
using svLo8OX0c9XIg4YrhKfV;

namespace qGTCRGXc2JrciPMM84f8;

sealed class EABRHeXcEaM6cFVK7Wd6 : global::System.IDisposable
{
	private readonly object x7IXcn4OWrT;

	private readonly object aCtXczj5xBS;

	private readonly object iAbX0bj0eMK;

	private readonly object Qs0X0XupDwc;

	private object NvTX0frANN5;

	private bool Vd6X0LZ1e9B;

	internal static object pjIWuuZgXIDOFxZBHZ6P;

	internal unsafe GE50SffsnGnn7g3lMZHE Session
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000e: Expected O, but got Ref
			return (GE50SffsnGnn7g3lMZHE)MemoryExtensions.AsSpan<byte>((byte[])global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref NvTX0frANN5));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal EABRHeXcEaM6cFVK7Wd6(bnHA9vxvBiUJqO7FLm4 paths, GE50SffsnGnn7g3lMZHE session, HDDHYcfFZMJBwyk4WxDY request, string modListJson)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		EABRHeXcEaM6cFVK7Wd6(paths, session, request, (s0B8yoX06tNYxvbfpJiH)new s0B8yoX06tNYxvbfpJiH(), (GFBm1PX0SCU6CVKqacD8)new vFO4UtX00cvEykURMW55(), (FXXNSRX8Y3Ad9Ho2yoLb)new FXXNSRX8Y3Ad9Ho2yoLb((Eyhp5FX8b3BcPN3DvvXR)new Eyhp5FX8b3BcPN3DvvXR(paths, request, modListJson)));
		int num = 0;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
		{
			num = 5;
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
	internal EABRHeXcEaM6cFVK7Wd6(bnHA9vxvBiUJqO7FLm4 paths, GE50SffsnGnn7g3lMZHE session, HDDHYcfFZMJBwyk4WxDY request, s0B8yoX06tNYxvbfpJiH endpointProvider, GFBm1PX0SCU6CVKqacD8 connection, FXXNSRX8Y3Ad9Ho2yoLb protocol)
	{
		Qs0X0XupDwc = stG8Q2XkufUoIw0QT4qA.jpSXkvJtjrI(request.Server, request.Role);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void MAMXcqvkVNh(GE50SffsnGnn7g3lMZHE refreshedSession)
	{
		System.ArgumentNullException.ThrowIfNull(refreshedSession, "refreshedSession");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task AuthenticateAsync(string gameId, string userId, string serverId, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateAsync_d__11 authenticateAsync_d__ = default(_AuthenticateAsync_d__11);
		authenticateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool VjfXcGogcwt(object exception)
	{
		int num = 8;
		bool result = default(bool);
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
						if (num2 != 18)
						{
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						goto case 9;
					case 1:
						if (!(exception is X509Certificate))
						{
							num3 = 4;
							continue;
						}
						goto case 2;
					case 0:
					case 3:
						return result;
					case 6:
						if (!(exception is JsonSerializerOptions))
						{
							num = 1;
							break;
						}
						goto case 2;
					case 4:
						if (!(exception is CancellationTokenSource))
						{
							num = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
							{
								num = 14;
							}
							break;
						}
						goto case 2;
					case 10:
						if (exception is NetworkStream)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
							{
								num3 = 18;
							}
							continue;
						}
						goto case 6;
					case 8:
						if (!(exception is CookieContainer))
						{
							num3 = 7;
							continue;
						}
						goto case 2;
					case 7:
						if (exception is ConcurrentBag<>)
						{
							num3 = 2;
							continue;
						}
						goto case 10;
					case 9:
						result = false;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							num3 = 11;
						}
						continue;
					case 2:
					case 5:
					case 11:
						result = true;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num3 = 3;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string CqUXciaMZPx(object exception)
	{
		int num = 15;
		string result = default(string);
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
						if (num2 != 27)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 0:
					case 3:
					case 4:
					case 6:
					case 10:
					case 17:
						return result;
					case 11:
						if (!(exception is X509Certificate))
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto case 13;
					case 13:
						result = "加密校验错误";
						num3 = 6;
						continue;
					case 12:
						if (!(exception is NetworkStream))
						{
							num3 = 7;
							continue;
						}
						goto case 5;
					case 7:
						if (exception is JsonSerializerOptions)
						{
							num3 = 16;
							continue;
						}
						goto case 11;
					case 1:
						result = "网络错误";
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
						{
							num3 = 10;
						}
						continue;
					case 14:
						if (!(exception is ConcurrentBag<>))
						{
							num3 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 1;
					case 5:
						result = "传输错误";
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 17;
						}
						continue;
					case 2:
						result = "超时";
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num3 = 0;
						}
						continue;
					case 16:
					case 20:
						result = "协议错误";
						num3 = 4;
						continue;
					case 9:
					case 18:
						result = "认证拒绝";
						num3 = 24;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num3 = 3;
						}
						continue;
					case 15:
						if (!(exception is CookieContainer))
						{
							num3 = 22;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 2;
					case 19:
						if (!(exception is ConditionalWeakTable<, >))
						{
							num3 = 12;
							continue;
						}
						break;
					case 8:
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
			while (num2 == 1008);
			result = "远端关闭";
			num = 27;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 3;
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
						((FXXNSRX8Y3Ad9Ho2yoLb)iAbX0bj0eMK).Dispose();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
						return;
					case 2:
						Vd6X0LZ1e9B = true;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					case 1:
						return;
					case 3:
						if (Vd6X0LZ1e9B)
						{
							return;
						}
						num3 = 2;
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
			((s0B8yoX06tNYxvbfpJiH)x7IXcn4OWrT).Dispose();
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
						if (num2 == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 1:
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 2;
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lKIKKSZgf3sQiFJRyCil()
	{
		return pjIWuuZgXIDOFxZBHZ6P == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static EABRHeXcEaM6cFVK7Wd6 yoEdNrZgLV14ksCJ98Kd()
	{
		return (EABRHeXcEaM6cFVK7Wd6)pjIWuuZgXIDOFxZBHZ6P;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using BkLpKCXYTvTKAdlSPPJo;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using E8lvgpXkaerTjm5gLXSY;
using GJFHuMfF9Tsu20PjaEve;
using IBO8khfs2hYQCxbFhKl7;
using K5FCrdFj16NFnFBU3KQ;
using Vl4jDMX56cFYkU2Jw1oo;
using fDAldojjppXrctUVYOJn;
using ifVIgIajVVrkxsy3ckb;
using qGTCRGXc2JrciPMM84f8;

namespace UmpC1Xu1VvibPgPGJsn;

sealed class yVgVh0ua6aAM6gZHOY8 : global::System.IDisposable
{
	private readonly object k66uEKIftJ;

	private readonly object u9hu22toXB;

	private readonly object DYHuq0IAkN;

	private readonly object CMouGYdZHa;

	private object MCSuinw3HQ;

	private long h4Hun7Inxc;

	private int quNuzW33D1;

	[CompilerGenerated]
	private readonly HDDHYcfFZMJBwyk4WxDY JOyabAfdWc;

	[CompilerGenerated]
	private readonly Kng51rfsEb2iUOsBkQPY X4AaXPWXxQ;

	[CompilerGenerated]
	private readonly string Pn6aftIIHU;

	internal static object GqTC1JZUSJYVTBBvwLGV;

	internal HDDHYcfFZMJBwyk4WxDY Request
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return JOyabAfdWc;
		}
	}

	internal Kng51rfsEb2iUOsBkQPY Address
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return X4AaXPWXxQ;
		}
	}

	internal string WorkingDirectory
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return Pn6aftIIHU;
		}
	}

	internal unsafe GE50SffsnGnn7g3lMZHE Session
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000e: Expected O, but got Ref
			return (GE50SffsnGnn7g3lMZHE)MemoryExtensions.AsSpan<byte>((byte[])global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref MCSuinw3HQ));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal yVgVh0ua6aAM6gZHOY8(KxOGVaFL8AQcstEY1GC owner, HDDHYcfFZMJBwyk4WxDY request, Kng51rfsEb2iUOsBkQPY address, string workingDirectory, GE50SffsnGnn7g3lMZHE session, long sessionGeneration, qKdAufXYs6ddcG66aURX sessionReference, EABRHeXcEaM6cFVK7Wd6 authenticator)
	{
		//IL_0020: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		((yVgVh0ua6aAM6gZHOY8)1).CMouGYdZHa = 1;
		int num = 3;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				switch (num2)
				{
				case 995:
					break;
				default:
					return;
				case 15:
					DYHuq0IAkN = sessionReference ?? throw "sessionReference";
					num = 7;
					goto end_IL_003b;
				}
				goto IL_0037;
			case 6:
				return;
			case 1:
				h4Hun7Inxc = sessionGeneration;
				num2 = 15;
				goto IL_0037;
			case 3:
				k66uEKIftJ = owner ?? throw "owner";
				num = 2;
				break;
			case 2:
				JOyabAfdWc = request ?? throw "request";
				num = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
				{
					num = 11;
				}
				break;
			case 5:
				X4AaXPWXxQ = address ?? throw "address";
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
				{
					num = 5;
				}
				break;
			case 0:
				if (string.IsNullOrWhiteSpace(workingDirectory))
				{
					_ = "外部 Java 运行目录不能为空";
					throw new global::System.Exception("workingDirectory");
				}
				Pn6aftIIHU = workingDirectory;
				num = 12;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
				{
					num = 4;
				}
				break;
			case 4:
				MCSuinw3HQ = session ?? throw "session";
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
				{
					num = 1;
				}
				break;
			case 7:
				{
					u9hu22toXB = authenticator ?? throw "authenticator";
					num = 6;
					break;
				}
				IL_0037:
				num = num2;
				break;
				end_IL_003b:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task AuthenticateAsync(string serverHash, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateAsync_d__19 authenticateAsync_d__ = default(_AuthenticateAsync_d__19);
		authenticateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Threading.Tasks.Task NN0u3CU1iD(string serverHash, CancellationToken cancellationToken)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		return ((EABRHeXcEaM6cFVK7Wd6)u9hu22toXB).AuthenticateAsync(stG8Q2XkufUoIw0QT4qA.jpSXkvJtjrI(Request.Server, Request.Role), Session.UserId, serverHash, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void AiKuvbWYxB()
	{
		MyHCvGaLXaXXnqiTBH8 myHCvGaLXaXXnqiTBH = default(MyHCvGaLXaXXnqiTBH8);
		_ = myHCvGaLXaXXnqiTBH.Generation;
		System.Threading.Volatile.Read(ref h4Hun7Inxc);
		((AsyncTaskMethodBuilder<int>*)6)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, da18CdX55laNMRKtM3p0._LaunchLocalLobbyAsync_d__189>(ref global::System.Runtime.CompilerServices.Unsafe.As<object, ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter>(ref MCSuinw3HQ), ref *(da18CdX55laNMRKtM3p0._LaunchLocalLobbyAsync_d__189*)myHCvGaLXaXXnqiTBH.Session);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						return;
					case 3:
						return;
					case 0:
						((EABRHeXcEaM6cFVK7Wd6)u9hu22toXB).Dispose();
						num3 = 4;
						continue;
					case 1:
						if (System.Threading.Interlocked.Exchange(ref quNuzW33D1, 1) != 0)
						{
							return;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						(CMouGYdZHa).Dispose();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
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
			((KxOGVaFL8AQcstEY1GC)k66uEKIftJ).GDUsX1kX7q((qKdAufXYs6ddcG66aURX)DYHuq0IAkN, Session, System.Threading.Volatile.Read(ref h4Hun7Inxc));
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
			{
				num = 11;
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
					case 2:
						num3 = 1;
						continue;
					case 1:
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
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 3;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool sn5hdpZUc737XnIDgphR()
	{
		return GqTC1JZUSJYVTBBvwLGV == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static yVgVh0ua6aAM6gZHOY8 PhpOLNZU0rdQeIviaB9t()
	{
		return (yVgVh0ua6aAM6gZHOY8)GqTC1JZUSJYVTBBvwLGV;
	}
}

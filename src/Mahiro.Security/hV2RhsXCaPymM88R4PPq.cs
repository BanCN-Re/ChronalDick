using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using XwPpiLXQsPK7EEBp2PNq;
using an3gUVq2E3PsvwmPejP;
using fDAldojjppXrctUVYOJn;
using uIQTm1XQ5eNvJGnZP8cQ;

namespace kWZKZaXC1EjUpJ5SeRim;

sealed class hV2RhsXCaPymM88R4PPq : qjUekmXQFPB3X2exa8El, global::System.IDisposable, global::System.IAsyncDisposable
{
	private readonly object GGAXC2m0Z61;

	private readonly object roJXCqKK56W;

	private readonly object TDNXCGiXyMs;

	private readonly object M5YXCiOO88E;

	private Jx59f3qEugGU1B1mwyt? vluXCns0f9c;

	private global::System.Threading.Tasks.Task? xhmXCz651Wh;

	private int Mb7X4bURRop;

	private int xJkX4Xg5kPg;

	[CompilerGenerated]
	private readonly string JhBX4fdYQH8;

	internal static object iqlbBhZKCJKfSV8ygM0r;

	public string RoleName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return JhBX4fdYQH8;
		}
	}

	internal int AuthenticationAttempts
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Volatile.Read(ref Mb7X4bURRop);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal hV2RhsXCaPymM88R4PPq(A9351BXQOqSsKQwNYRBC leaseProvider, Jx59f3qEugGU1B1mwyt initialLease)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task AuthenticateAsync(string serverHash, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateAsync_d__14 authenticateAsync_d__ = default(_AuthenticateAsync_d__14);
		authenticateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task vQaXC3Cndoy(object lease, object serverHash, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateLeaseAsync_d__15 authenticateLeaseAsync_d__ = default(_AuthenticateLeaseAsync_d__15);
		authenticateLeaseAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Exception aYCXCvaCvC0(global::System.Exception? current, object next)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		global::System.Threading.Tasks.ValueTask valueTask = default(global::System.Threading.Tasks.ValueTask);
		TaskAwaiter val = ((valueTask).AsTask()).GetAwaiter();
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.ValueTask DisposeAsync()
	{
		int num = 2;
		object m5YXCiOO88E = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		global::System.Threading.Tasks.ValueTask result = default(global::System.Threading.Tasks.ValueTask);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 2:
					m5YXCiOO88E = M5YXCiOO88E;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
					{
						num2 = 6;
					}
					continue;
				case 1:
					flag = false;
					num2 = 3;
					continue;
				case 0:
					break;
				case 3:
					try
					{
						System.Threading.Monitor.Enter(m5YXCiOO88E, ref flag);
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 10)
								{
									if (num4 != 990)
									{
										break;
									}
									goto IL_0096;
								}
								goto IL_00cc;
							case 1:
							{
								xhmXCz651Wh = KSEXCE8exUH();
								int num5 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
								{
									num5 = 2;
								}
								num4 = num5;
								goto IL_0096;
							}
							case 2:
								if (xhmXCz651Wh == null)
								{
									num3 = 1;
									continue;
								}
								goto IL_00cc;
							case 0:
								break;
								IL_0096:
								num3 = num4;
								continue;
								IL_00cc:
								result = new global::System.Threading.Tasks.ValueTask(xhmXCz651Wh);
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num6 = 1;
							}
							goto IL_0175;
						}
						goto IL_01bd;
						IL_0175:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0171;
								}
								goto end_IL_0175;
							case 1:
								goto end_IL_0175;
							case 0:
								break;
							case 2:
								goto end_IL_0175;
							}
							goto IL_01bd;
							IL_0171:
							num6 = num7;
							continue;
							end_IL_0175:
							break;
						}
						goto end_IL_013d;
						IL_01bd:
						System.Threading.Monitor.Exit(m5YXCiOO88E);
						num6 = 2;
						goto IL_0175;
						end_IL_013d:;
					}
					break;
				}
				goto IL_006c;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_006c;
				IL_006c:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task KSEXCE8exUH()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_DisposeCoreAsync_d__19 disposeCoreAsync_d__ = default(_DisposeCoreAsync_d__19);
		disposeCoreAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
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
	internal static bool UetXaAZK4Tfp4WIsWkKX()
	{
		return iqlbBhZKCJKfSV8ygM0r == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hV2RhsXCaPymM88R4PPq gVgkFLZKhDQvIjORHTKs()
	{
		return (hV2RhsXCaPymM88R4PPq)iqlbBhZKCJKfSV8ygM0r;
	}
}

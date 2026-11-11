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
using vn7xlPf1FYwDtjMIxHKN;

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
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
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
	private unsafe static global::System.Threading.Tasks.Task vQaXC3Cndoy(object lease, object serverHash, CancellationToken cancellationToken)
	{
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		_AuthenticateLeaseAsync_d__15 authenticateLeaseAsync_d__ = default(_AuthenticateLeaseAsync_d__15);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&authenticateLeaseAsync_d__.__t__builder))->AppendFormatted<Nafsw6f1xYhqCvXaY8qH>((Nafsw6f1xYhqCvXaY8qH)(int)(&authenticateLeaseAsync_d__));
						num3 = 3;
						continue;
					case 5:
						authenticateLeaseAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
						num3 = 4;
						continue;
					case 4:
						authenticateLeaseAsync_d__.lease = (Jx59f3qEugGU1B1mwyt)lease;
						num = 2;
						break;
					case 1:
						authenticateLeaseAsync_d__.cancellationToken = cancellationToken;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
						{
							num3 = 8;
						}
						continue;
					case 3:
						return (authenticateLeaseAsync_d__.__t__builder).Task;
					case 0:
						authenticateLeaseAsync_d__.__1__state = -1;
						num = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
						{
							num = 12;
						}
						break;
					case 2:
						authenticateLeaseAsync_d__.serverHash = (string)serverHash;
						num3 = 1;
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
	private static global::System.Exception aYCXCvaCvC0(global::System.Exception? current, object next)
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (current != null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					return (global::System.Exception)next;
				case 0:
					_ = "认证事务和清理操作均失败";
					return (global::System.Exception)(object)new global::System.ValueType[2]
					{
						(global::System.ValueType)(object)current,
						(global::System.ValueType)next
					};
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		TaskAwaiter val = default(TaskAwaiter);
		global::System.Threading.Tasks.ValueTask valueTask = default(global::System.Threading.Tasks.ValueTask);
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
								goto end_IL_0010;
							}
							goto case 1;
						}
						return;
					case 0:
						val = ((valueTask).AsTask()).GetAwaiter();
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
					case 1:
						valueTask = DisposeAsync();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 0;
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
			(val).GetResult();
			num = 9;
		}
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
								result = (global::System.Threading.Tasks.ValueTask)xhmXCz651Wh;
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
							goto IL_0171;
						}
						goto IL_01b9;
						IL_0171:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_016d;
								}
								goto end_IL_0171;
							case 1:
								goto end_IL_0171;
							case 0:
								break;
							case 2:
								goto end_IL_0171;
							}
							goto IL_01b9;
							IL_016d:
							num6 = num7;
							continue;
							end_IL_0171:
							break;
						}
						goto end_IL_0139;
						IL_01b9:
						System.Threading.Monitor.Exit(m5YXCiOO88E);
						num6 = 2;
						goto IL_0171;
						end_IL_0139:;
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
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 0:
						return;
					case 2:
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
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
			while (num2 == 990);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
			{
				num = 1;
			}
		}
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

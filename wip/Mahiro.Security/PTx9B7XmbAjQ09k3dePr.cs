using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using UchfG8fTzhAHMiok6Yk0;
using b53iPpXMJRnlXyrk1GwO;
using fDAldojjppXrctUVYOJn;
using y6aXjmfNjqEa4QZsAxq8;

namespace w6HELYXmXw1JesIj9gWf;

internal class PTx9B7XmbAjQ09k3dePr
{
	private static object FYr3aAZtbXwIlOckANZJ;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<TcpClient> z8OXmfCby37(object proxy, object target, CancellationToken cancellationToken)
	{
		_ConnectAsync_d__0_1 connectAsync_d__0_ = default(_ConnectAsync_d__0_1);
		connectAsync_d__0_.proxy = (UMHcoIfNLE9EKKScQadx)proxy;
		_ = 10;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76;
		((AsyncTaskMethodBuilder<no9jkQXMWVmKXSFPv1CU>*)null)->AwaitUnsafeOnCompleted<object, no9jkQXMWVmKXSFPv1CU._AcquireAsync_d__4>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task vwKXmLZ1B3o(object stream, object proxy, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_NegotiateAsync_d__1 negotiateAsync_d__ = default(_NegotiateAsync_d__1);
		negotiateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task AuthenticateAsync(object stream, object proxy, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_AuthenticateAsync_d__2 authenticateAsync_d__ = default(_AuthenticateAsync_d__2);
		authenticateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task euVXmjlV5N1(object stream, object target, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_RequestConnectionAsync_d__3 requestConnectionAsync_d__ = default(_RequestConnectionAsync_d__3);
		requestConnectionAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<int> FLYXmZXVFyk(object stream, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task AyyXm9ShZF1(object stream, global::System.Memory<byte> destination, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ReadExactlyAsync_d__5 readExactlyAsync_d__ = default(_ReadExactlyAsync_d__5);
		readExactlyAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void AU3XmDDW04s(object endpoint, object parameterName)
	{
		int num = 1;
		bool flag2 = default(bool);
		bool flag = default(bool);
		int port = default(int);
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
						if (num2 != 16)
						{
							goto end_IL_0010;
						}
						goto IL_00f0;
					case 2:
						flag2 = true;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
					case 6:
						break;
					case 5:
						_ = "SOCKS5 地址无效";
						throw parameterName;
					case 1:
						flag = string.IsNullOrWhiteSpace(((tevrq6fTnmxdv0004lXm)endpoint).Host);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						if (!flag)
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto IL_00f0;
					case 8:
						flag2 = false;
						num3 = 6;
						continue;
					case 7:
						port = ((tevrq6fTnmxdv0004lXm)endpoint).Port;
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
						{
							num3 = 3;
						}
						continue;
					case 9:
						if (port > 65535)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 8;
					case 3:
						{
							if (port >= 1)
							{
								num3 = 9;
								continue;
							}
							goto case 2;
						}
						IL_00f0:
						if (!flag)
						{
							return;
						}
						num3 = 5;
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
			while (num2 == 997);
			flag = flag2;
			num = 16;
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
						if (num2 == 9)
						{
							return;
						}
						goto IL_0031;
					case 2:
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 1:
						break;
					}
					goto IL_0078;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0078;
					IL_0078:
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
					{
						num3 = 1;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool qJjkTZZtX545UMddLV7h()
	{
		return FYr3aAZtbXwIlOckANZJ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PTx9B7XmbAjQ09k3dePr ta7VWaZtf78tATnoRWY6()
	{
		return (PTx9B7XmbAjQ09k3dePr)FYr3aAZtbXwIlOckANZJ;
	}
}

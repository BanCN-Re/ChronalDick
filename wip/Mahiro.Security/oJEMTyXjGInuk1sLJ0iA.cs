using System;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using e3PxvgX9e6QeuS9EwNnp;
using fDAldojjppXrctUVYOJn;
using mXpxUMXZeWDb8PCEN1uO;
using yhPKfjXZUiZRkPBdj3U0;

namespace COMudHXjiEilDb7HnuOS;

sealed class oJEMTyXjGInuk1sLJ0iA : global::System.IDisposable
{
	private readonly object p5CXZbCgP7q;

	private readonly object DcmXZXPaap9;

	private readonly object WqwXZf3j3Vv;

	private readonly object ODjXZLtNegv;

	private readonly TimeSpan ENOXZjr995f;

	private NetworkStream? O0SXZZUSNJJ;

	private int ws9XZ9wYYxP;

	[CompilerGenerated]
	private readonly int akuXZDqUlcR;

	[CompilerGenerated]
	private readonly dC5YMxX9w6vHLYyLdKX4 n9hXZkwQYv3;

	private static object FIs8DSZAWuW4CRJ6Uwx9;

	internal int Id
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return akuXZDqUlcR;
		}
	}

	internal dC5YMxX9w6vHLYyLdKX4 RequestState
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return n9hXZkwQYv3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal oJEMTyXjGInuk1sLJ0iA(int id, TcpClient client, OyvcDTXZwtrMNdFb6sh5 dispatcher, TimeSpan ioTimeout)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task RunAsync(CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task xIFXjn1ZYcq(byte[] message, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_SendAsync_d__15 sendAsync_d__ = default(_SendAsync_d__15);
		sendAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		vwnXjzpfIFC();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void vwnXjzpfIFC()
	{
		int num = 4;
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num3 = 1;
						}
						continue;
					case 6:
						try
						{
							(p5CXZbCgP7q).Dispose();
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (global::System.Exception)
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
							{
								num6 = 5;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 0;
					case 1:
						try
						{
							NetworkStream? o0SXZZUSNJJ = O0SXZZUSNJJ;
							int num8;
							if (o0SXZZUSNJJ == null)
							{
								num8 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
								{
									num8 = 1;
								}
							}
							else
							{
								(o0SXZZUSNJJ).Dispose();
								num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
								{
									num8 = 4;
								}
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
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (global::System.Exception)
						{
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num10 = 0;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										num10 = num11;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 2;
					case 4:
						break;
					case 3:
						return;
					case 0:
						((exW6jdXZhiu02AurIJX0)WqwXZf3j3Vv).Dispose();
						num3 = 5;
						continue;
					case 2:
						num3 = 6;
						continue;
					case 5:
						return;
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
			if (System.Threading.Interlocked.Exchange(ref ws9XZ9wYYxP, 1) == 0)
			{
				num = 13;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
				{
					num = 8;
				}
				continue;
			}
			break;
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
					case 0:
						return;
					case 1:
						goto end_IL_000e;
					case 2:
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num3 = 1;
						}
						continue;
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
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							num3 = 8;
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
	internal static bool SQXcMoZAJqnPwjrdtVx0()
	{
		return FIs8DSZAWuW4CRJ6Uwx9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oJEMTyXjGInuk1sLJ0iA bs76TIZAQAuDaELfHJp1()
	{
		return (oJEMTyXjGInuk1sLJ0iA)FIs8DSZAWuW4CRJ6Uwx9;
	}
}

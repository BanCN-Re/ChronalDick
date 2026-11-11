using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PW0ZZVfus06wwb9hw2Vi;
using Vl4jDMX56cFYkU2Jw1oo;
using YuUbZ8OJNmt9DXfNMjB;
using fDAldojjppXrctUVYOJn;
using knGiRcfu9DhbMgArQGtn;

namespace qIIsIiXslFgG3TiMmGui;

internal sealed class NwvcA9XsgKvXJf3u1rZP
{
	private readonly IProgress<TNGLHufuZJeliMhnBLZ9>? IpfXsegNvaq;

	private readonly object iMEXsP7nLqt;

	private long rtjXsxZftjZ;

	private long MQJXsFwhy27;

	private int m9FXssjoDGN;

	private long nO9XsT3XXSI;

	private object loZXsNnqogC;

	private static readonly long oLnXsM88Pun;

	private static object U5Ni1IZRGt38oMFE4hha;

	internal long BytesProcessed
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Interlocked.Read(ref rtjXsxZftjZ);
		}
	}

	internal long TotalBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Interlocked.Read(ref MQJXsFwhy27);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal NwvcA9XsgKvXJf3u1rZP(IProgress<TNGLHufuZJeliMhnBLZ9>? progress)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		iMEXsP7nLqt = (object)new oWe9REOWP5UmvoCVEl1();
		loZXsNnqogC = "正在准备下载客户端";
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void vjLXsdFJOEk(long totalBytes)
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					m4DXs6M77N3();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return;
				case 1:
					System.Threading.Interlocked.Exchange(ref MQJXsFwhy27, System.Math.Max(0L, totalBytes));
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void kToXsKBgNls(int concurrency)
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
					goto IL_0021;
				case 1:
					System.Threading.Interlocked.Exchange(ref m9FXssjoDGN, System.Math.Max(0, concurrency));
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					return;
				case 0:
					break;
				}
				goto IL_0071;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0071;
				IL_0071:
				m4DXs6M77N3();
				num2 = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Dx3XsH00O5X(string message)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void UAeXst2KvBq(long bytes)
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
						if (num2 == 10)
						{
							return;
						}
						goto end_IL_0010;
					case 0:
						System.Threading.Interlocked.Add(ref rtjXsxZftjZ, bytes);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						I2uXsRLdOs3();
						num3 = 2;
						continue;
					case 3:
						if (bytes <= 0)
						{
							break;
						}
						goto case 0;
					case 2:
						return;
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 991)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void jYMXsO03BFy(long bytes)
	{
		int num = 1;
		long num4 = default(long);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						m4DXs6M77N3();
						num3 = 3;
						continue;
					case 0:
						System.Threading.Interlocked.Exchange(ref rtjXsxZftjZ, num4);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
					case 3:
						return;
					case 1:
						num4 = System.Math.Max(0L, bytes);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
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
			((oWe9REOWP5UmvoCVEl1)iMEXsP7nLqt).EcHOQWtTIn(num4);
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task cx2Xs5AFget(CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_HeartbeatAsync_d__18 heartbeatAsync_d__ = default(_HeartbeatAsync_d__18);
		heartbeatAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void m4DXs6M77N3()
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
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					System.Threading.Interlocked.Exchange(ref nO9XsT3XXSI, System.Diagnostics.Stopwatch.GetTimestamp());
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					return;
				case 0:
					hSyXswTYTcZ();
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void I2uXsRLdOs3()
	{
		int num = 1;
		long num5 = default(long);
		long num4 = default(long);
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
							goto case 0;
						}
						return;
					case 6:
						if (num5 == 0L)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 5;
					case 4:
						return;
					case 0:
						num5 = System.Threading.Interlocked.Read(ref nO9XsT3XXSI);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num3 = 6;
						}
						continue;
					case 5:
						if (num4 - num5 < oLnXsM88Pun)
						{
							break;
						}
						goto case 3;
					case 3:
						if (System.Threading.Interlocked.CompareExchange(ref nO9XsT3XXSI, num4, num5) == num5)
						{
							hSyXswTYTcZ();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num3 = 2;
							}
						}
						else
						{
							num3 = 4;
						}
						continue;
					case 2:
						return;
					case 1:
						num4 = System.Diagnostics.Stopwatch.GetTimestamp();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
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
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
			{
				num = 13;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void hSyXswTYTcZ()
	{
		long totalBytes = TotalBytes;
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral("）");
		((AsyncTaskMethodBuilder<XHEDPNfuFO31QfaHLUGP>*)8)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, da18CdX55laNMRKtM3p0._LaunchServerCoreAsync_d__159>(ref *(ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter*)5, ref global::System.Runtime.CompilerServices.Unsafe.As<object, da18CdX55laNMRKtM3p0._LaunchServerCoreAsync_d__159>(ref loZXsNnqogC));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PMRAu5ZRiy1oRXRDuAxT()
	{
		return U5Ni1IZRGt38oMFE4hha == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static NwvcA9XsgKvXJf3u1rZP eQt4xKZRnnTC4NLLZtRP()
	{
		return (NwvcA9XsgKvXJf3u1rZP)U5Ni1IZRGt38oMFE4hha;
	}
}

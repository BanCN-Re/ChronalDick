using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using Bq8RQiXJKPoYAokn45Ln;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using VZZZd9XWrlA27h8tWWsv;
using fDAldojjppXrctUVYOJn;
using vGvsaMXWxOcIv9vwTPwq;

namespace Iky0gbXWZtrGc1p4kNpx;

sealed class XO3bQrXWjkdOIF8SaTDc : global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass11_0_1
	{
		public ProcessStartInfo info;

		private static __c__DisplayClass11_0_1 esTPx39scJ9R850FU9UW;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass11_0_1()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal Process corLbhx59pg()
		{
			return System.Diagnostics.Process.Start(info);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KabiP19s0drJZCVIZZGb()
		{
			return esTPx39scJ9R850FU9UW == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass11_0_1 A7EylM9s8ETM3OSTqRJT()
		{
			return esTPx39scJ9R850FU9UW;
		}
	}

	private readonly object d8wXWcgORV9;

	private readonly object wnoXW0jkLlW;

	private readonly object DbaXW80GVIL;

	private StreamReader? s2HXWyl9Zas;

	private StreamWriter? biqXWWvGbcJ;

	private Process? vLTXWJ2YTUa;

	private static object hA0hDCZl4s2wh7bQwfgp;

	[MethodImpl((MethodImplOptions)8)]
	internal XO3bQrXWjkdOIF8SaTDc(string name)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task savXW9lB7ap(int expectedPid, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ConnectAsync_d__9 connectAsync_d__ = default(_ConnectAsync_d__9);
		connectAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool zLHXWDBIEH8()
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		int num = 2;
		bool result = default(bool);
		WindowsIdentity val = default(WindowsIdentity);
		int num4 = default(int);
		int num6 = default(int);
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
					goto case 2;
				case 1:
					try
					{
						result = (new WindowsPrincipal(val)).IsInRole((WindowsBuiltInRole)544);
						int num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									num3 = num4;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num5;
						if (val == null)
						{
							num5 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
							{
								num5 = 0;
							}
							goto IL_00d7;
						}
						goto IL_011f;
						IL_00d7:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_00d3;
								}
								break;
							case 0:
								goto end_IL_00d7;
							case 1:
								break;
							case 2:
								goto end_IL_00d7;
							}
							goto IL_011f;
							IL_00d3:
							num5 = num6;
							continue;
							end_IL_00d7:
							break;
						}
						goto end_IL_009f;
						IL_011f:
						(val).Dispose();
						num5 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
						{
							num5 = 2;
						}
						goto IL_00d7;
						end_IL_009f:;
					}
					break;
				case 2:
					val = System.Security.Principal.WindowsIdentity.GetCurrent();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<XO3bQrXWjkdOIF8SaTDc> AxYXWkSRDfv()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_LaunchAsync_d__11 launchAsync_d__ = default(_LaunchAsync_d__11);
		launchAsync_d__.__t__builder = AsyncTaskMethodBuilder<XO3bQrXWjkdOIF8SaTDc>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<xoV7UKXWP562ggfcmFvm> ORuXWVUXTpa(nQJbXUXWUkPwQ8JfHTBv command, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_SendAsync_d__12 sendAsync_d__ = default(_SendAsync_d__12);
		sendAsync_d__.__t__builder = AsyncTaskMethodBuilder<xoV7UKXWP562ggfcmFvm>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		ELfn2xXJd7Ivm97I82xx.iU6XJR9FBC5(wnoXW0jkLlW);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cJ118pZlhO5bAV0Qp6XJ()
	{
		return hA0hDCZl4s2wh7bQwfgp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static XO3bQrXWjkdOIF8SaTDc n9fR4pZlUHYLTcOHWf9f()
	{
		return (XO3bQrXWjkdOIF8SaTDc)hA0hDCZl4s2wh7bQwfgp;
	}
}

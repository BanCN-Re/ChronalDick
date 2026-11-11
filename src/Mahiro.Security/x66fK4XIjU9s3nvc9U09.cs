using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QYGhLHXItkif7OOHRlA7;
using caV83GXAx0MgWXxPfFqu;
using fBoiiMXA2IYv4Oy0MsjP;
using fDAldojjppXrctUVYOJn;
using ofVNYmXIA1tTCQAPJyfj;
using vPsLRWXAKouaS91XjEO3;

namespace DusBAfXIZTnmARaIW8Kr;

internal sealed class x66fK4XIjU9s3nvc9U09
{
	internal sealed class FFV4QyLfW0WYUoO4pQhT
	{
		private int j3ALfQmEvYb;

		[CompilerGenerated]
		private readonly x66fK4XIjU9s3nvc9U09 SeeLfCPwmrF;

		[CompilerGenerated]
		private readonly nint hqnLf4X133f;

		[CompilerGenerated]
		private readonly long LBTLfhFi6N4;

		[CompilerGenerated]
		private readonly qp1wBpXIHSoMwJ0wWPPV NDvLfUdxMe9;

		private static object FPcqHC9aydDUNRhVlyej;

		internal x66fK4XIjU9s3nvc9U09 Owner
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return SeeLfCPwmrF;
			}
		}

		internal nint ClientWindow
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return hqnLf4X133f;
			}
		}

		internal long ReceivedAt
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return LBTLfhFi6N4;
			}
		}

		internal qp1wBpXIHSoMwJ0wWPPV Request
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return NDvLfUdxMe9;
			}
		}

		internal bool IsExpired
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				//IL_000e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				return (System.Diagnostics.Stopwatch.GetElapsedTime(ReceivedAt) > RIbXImn0pJ8);
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal FFV4QyLfW0WYUoO4pQhT(x66fK4XIjU9s3nvc9U09 owner, nint clientWindow, qp1wBpXIHSoMwJ0wWPPV request)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool ecbLfJ5RvYn()
		{
			return System.Threading.Interlocked.Exchange(ref j3ALfQmEvYb, 1) == 0;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool dp5yNr9aW7KAVp1x90Vf()
		{
			return FPcqHC9aydDUNRhVlyej == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static FFV4QyLfW0WYUoO4pQhT oSQUVE9aJXRmO5UpHuje()
		{
			return (FFV4QyLfW0WYUoO4pQhT)FPcqHC9aydDUNRhVlyej;
		}
	}

	private struct GxsgZpLfrjg9hlhgdBLJ
	{
		internal nuint Ly7Lfo1EoQJ;

		internal int rliLfm6BqS3;

		internal nint C58Lf72Bekm;
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass14_0
	{
		public CancellationToken cancellationToken;

		public x66fK4XIjU9s3nvc9U09 __4__this;

		public FFV4QyLfW0WYUoO4pQhT pending;

		public byte[] deliveryPacket;

		internal static __c__DisplayClass14_0 wXhlWa9ahIq60QxhBlN6;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass14_0()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void CTdLfAxeHig()
		{
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_0125: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0403: Unknown result type (might be due to invalid IL or missing references)
			int num = 3;
			bool flag = default(bool);
			GCHandle val = default(GCHandle);
			int num9 = default(int);
			GxsgZpLfrjg9hlhgdBLJ data = default(GxsgZpLfrjg9hlhgdBLJ);
			int num11 = default(int);
			object u1qXIUqk2Jv = default(object);
			int num5 = default(int);
			int num7 = default(int);
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
							if (num2 == 14)
							{
								flag = false;
								num3 = 6;
								continue;
							}
							goto IL_0043;
						case 1:
							break;
						case 3:
							(cancellationToken).ThrowIfCancellationRequested();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num3 = 2;
							}
							continue;
						case 4:
							throw new InvalidOperationException("NCG 票据请求已过期");
						case 5:
							val = System.Runtime.InteropServices.GCHandle.Alloc(deliveryPacket, (GCHandleType)3);
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							try
							{
								GxsgZpLfrjg9hlhgdBLJ gxsgZpLfrjg9hlhgdBLJ = default(GxsgZpLfrjg9hlhgdBLJ);
								int num8 = 2;
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 != 11)
										{
											if (num9 == 991)
											{
												goto IL_0167;
											}
											goto case 3;
										}
										data = gxsgZpLfrjg9hlhgdBLJ;
										num8 = 3;
										break;
									case 1:
										gxsgZpLfrjg9hlhgdBLJ.C58Lf72Bekm = (val).AddrOfPinnedObject();
										num9 = 11;
										goto IL_0167;
									case 3:
									{
										if (T2MXIS9EitC(pending.ClientWindow, 74u, __4__this.eFVXIQOBUTp, ref data, 35u, 5000u, out var _) == 0)
										{
											num8 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
											{
												num8 = 0;
											}
											break;
										}
										return;
									}
									case 2:
										gxsgZpLfrjg9hlhgdBLJ.rliLfm6BqS3 = deliveryPacket.Length;
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
										{
											num8 = 9;
										}
										break;
									case 0:
										{
											throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "NCG 票据交付未确认，不会自动重放");
										}
										IL_0167:
										num8 = num9;
										break;
									}
								}
							}
							finally
							{
								(val).Free();
								int num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
								{
									num10 = 1;
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
						case 7:
							return;
						case 2:
							__4__this.sOHXIV84qX8(pending.ClientWindow, pending.Request.ClientWindowName);
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
							try
							{
								System.Threading.Monitor.Enter(u1qXIUqk2Jv, ref flag);
								int num4 = 2;
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 == 990)
										{
											num4 = num5;
											continue;
										}
										break;
									case 2:
										if (!__4__this.kChXIosWYD0)
										{
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
											{
												num4 = 2;
											}
											continue;
										}
										break;
									case 0:
										if (__4__this.eveXIrmURoC != pending)
										{
											num4 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto end_IL_0360;
									case 1:
										break;
									}
									throw new OperationCanceledException("NCG 票据请求已撤销");
									continue;
									end_IL_0360:
									break;
								}
							}
							finally
							{
								int num6;
								if (!flag)
								{
									num6 = 2;
									goto IL_0431;
								}
								goto IL_0479;
								IL_0479:
								System.Threading.Monitor.Exit(u1qXIUqk2Jv);
								num6 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num6 = 0;
								}
								goto IL_0431;
								IL_0431:
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 == 990)
										{
											goto IL_042d;
										}
										goto end_IL_0431;
									case 2:
										goto end_IL_0431;
									case 1:
										break;
									case 0:
										goto end_IL_0431;
									}
									goto IL_0479;
									IL_042d:
									num6 = num7;
									continue;
									end_IL_0431:
									break;
								}
							}
							goto case 5;
						}
						goto IL_0056;
						IL_0043:
						if (num2 == 995)
						{
							break;
						}
						goto IL_0056;
						IL_0056:
						if (!pending.IsExpired)
						{
							goto end_IL_000c;
						}
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							num3 = 8;
						}
					}
					continue;
					end_IL_000c:
					break;
				}
				u1qXIUqk2Jv = __4__this.U1qXIUqk2Jv;
				num = 13;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
				{
					num = 14;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool SF5qiL9aUnxUeo8P6is2()
		{
			return wXhlWa9ahIq60QxhBlN6 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass14_0 Q6jPyv9arBUYBUH8RaYM()
		{
			return wXhlWa9ahIq60QxhBlN6;
		}
	}

	private readonly object ONYXIybWT0O;

	private readonly object am0XIWxkpam;

	private readonly long rF6XIJ09wRG;

	private readonly nint eFVXIQOBUTp;

	private readonly object IbqXIC4p2kX;

	private readonly object imbXI4PN39A;

	private readonly object Q54XIhYMe3t;

	private readonly object U1qXIUqk2Jv;

	private FFV4QyLfW0WYUoO4pQhT? eveXIrmURoC;

	private bool kChXIosWYD0;

	private static readonly TimeSpan RIbXImn0pJ8;

	internal static object mAu3SHZOWY102anrBYVC;

	[MethodImpl((MethodImplOptions)8)]
	internal x66fK4XIjU9s3nvc9U09(r7j98AXI72xOtKXWLtub profile, Process ownedGame, nint platformWindow, string productId, W8UV04XAdpTXOmgNYBMi ticketContext, Action ensureAccountCurrent)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool nixXI9EjLOA(nint senderWindow, nint copyDataPointer, out FFV4QyLfW0WYUoO4pQhT? pending)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task tmjXIDGpPIB(FFV4QyLfW0WYUoO4pQhT pending, CMd6QIXAPC7C8Vv5kluF nativeTicket, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_DeliverTicketAsync_d__14 deliverTicketAsync_d__ = default(_DeliverTicketAsync_d__14);
		deliverTicketAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void dEjXIkEigQo()
	{
		int num = 2;
		object u1qXIUqk2Jv = default(object);
		bool flag = default(bool);
		int num7 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return;
				case 3:
					try
					{
						System.Threading.Monitor.Enter(u1qXIUqk2Jv, ref flag);
						int num3 = 3;
						while (true)
						{
							int num4 = num3;
							FFV4QyLfW0WYUoO4pQhT? fFV4QyLfW0WYUoO4pQhT;
							while (true)
							{
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									case 1:
										return;
									default:
										if (num4 != 11 && num4 == 991)
										{
											goto end_IL_0061;
										}
										goto case 0;
									case 2:
										kChXIosWYD0 = true;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
										{
											num5 = 1;
										}
										continue;
									case 3:
										break;
									case 0:
										eveXIrmURoC = null;
										num5 = 2;
										continue;
									}
									fFV4QyLfW0WYUoO4pQhT = eveXIrmURoC;
									if (fFV4QyLfW0WYUoO4pQhT != null)
									{
										goto end_IL_005d;
									}
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
									{
										num5 = 11;
									}
									continue;
									end_IL_0061:
									break;
								}
								continue;
								end_IL_005d:
								break;
							}
							fFV4QyLfW0WYUoO4pQhT.ecbLfJ5RvYn();
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
							{
								num3 = 11;
							}
						}
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num6 = 0;
							}
							goto IL_0161;
						}
						goto IL_0185;
						IL_0161:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_015d;
								}
								goto end_IL_0161;
							case 1:
								break;
							case 0:
								goto end_IL_0161;
							case 2:
								goto end_IL_0161;
							}
							goto IL_0185;
							IL_015d:
							num6 = num7;
							continue;
							end_IL_0161:
							break;
						}
						goto end_IL_0129;
						IL_0185:
						System.Threading.Monitor.Exit(u1qXIUqk2Jv);
						num6 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
						{
							num6 = 2;
						}
						goto IL_0161;
						end_IL_0129:;
					}
				case 1:
					flag = false;
					num2 = 3;
					continue;
				case 2:
					u1qXIUqk2Jv = U1qXIUqk2Jv;
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
		while (num == 991);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void sOHXIV84qX8(nint clientWindow, string? clientName)
	{
		qcbXIYQbwTy(eFVXIQOBUTp, System.Environment.ProcessId, ((r7j98AXI72xOtKXWLtub)ONYXIybWT0O).PlatformWindowName);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void qcbXIYQbwTy(nint window, int processId, object? expectedName)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		StringBuilder val = new StringBuilder(512);
	}

	[DllImport("user32.dll", EntryPoint = "SendMessageTimeoutW", ExactSpelling = true, SetLastError = true)]
	private static extern nint T2MXIS9EitC(nint window, uint message, nint sender, ref GxsgZpLfrjg9hlhgdBLJ data, uint flags, uint timeout, out nuint result);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", ExactSpelling = true)]
	private static extern uint qxUXIcYAG05(nint window, out uint processId);

	[DllImport("user32.dll", CharSet = (CharSet)3, EntryPoint = "GetWindowTextW", ExactSpelling = true)]
	private static extern int PwcXI0yEJUS(nint window, StringBuilder text, int maximum);

	[DllImport("user32.dll", CharSet = (CharSet)3, EntryPoint = "GetClassNameW", ExactSpelling = true)]
	private static extern int BtMXI8fbqFK(nint window, StringBuilder text, int maximum);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool er4UCGZOJO0WYygL25YT()
	{
		return mAu3SHZOWY102anrBYVC == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static x66fK4XIjU9s3nvc9U09 E6e2lyZOQWA6nvDxhR4y()
	{
		return (x66fK4XIjU9s3nvc9U09)mAu3SHZOWY102anrBYVC;
	}
}

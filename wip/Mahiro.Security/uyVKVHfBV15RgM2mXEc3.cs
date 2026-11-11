using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CvQ8qLfIaPhOpHAJXxwb;
using JH2PRgfBX3Cp7KoXPjDd;
using fDAldojjppXrctUVYOJn;
using yIYtF0fIn7KHlAY0LkTJ;

namespace FxhHnnfBYmb2RqREI3gn;

sealed class uyVKVHfBV15RgM2mXEc3 : global::System.IDisposable
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_101
	{
		public static __c_101 __9;

		public static Action<global::System.Threading.Tasks.Task> __9__15_0;

		public static Predicate<IPAddress> __9__17_0;

		public static Predicate<IPAddress> __9__17_1;

		internal static __c_101 D41x4BD4TGLZKJgpcBfm;

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
							if (num2 == 11)
							{
								num3 = 4;
								continue;
							}
							goto end_IL_0012;
						case 3:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num3 = 4;
							}
							continue;
						case 4:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 3;
							continue;
						case 1:
							break;
						case 0:
							__9 = (__c_101)new __c_101();
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							return;
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
				while (num2 == 992);
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_101()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void LaWL8TOgbIF(global::System.Threading.Tasks.Task task)
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						(task).Exception;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
						{
							num2 = 0;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool fsaL8NW84Fk(IPAddress ip)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_000f: Invalid comparison between Unknown and I4
			return (int)(ip).AddressFamily == 2;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool RE1L8MaArCl(IPAddress ip)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Invalid comparison between Unknown and I4
			return (int)(ip).AddressFamily == 23;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool L85VDdD4N3XmrdQoMAGT()
		{
			return D41x4BD4TGLZKJgpcBfm == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_101 b8rm6tD4MgjNnUglQnKY()
		{
			return D41x4BD4TGLZKJgpcBfm;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateAsync_d__16 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<uyVKVHfBV15RgM2mXEc3> __t__builder;

		public string host;

		public int port;

		public CancellationToken token;

		private ConfiguredTaskAwaitable<uyVKVHfBV15RgM2mXEc3>.ConfiguredTaskAwaiter __u__1;

		internal static object V6LsJJD4pKbg8vQH9loo;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_015c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0161: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0261: Expected O, but got Ref
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b->IL02a3: Incompatible stack heights: 3 vs 1
			//IL_0316->IL02a3: Incompatible stack heights: 3 vs 1
			//IL_0358->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0363->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00cb->IL0066: Incompatible stack heights: 0 vs 1
			//IL_006a->IL006a: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			ConfiguredTaskAwaitable<uyVKVHfBV15RgM2mXEc3>.ConfiguredTaskAwaiter _u__ = default;
			int num6 = default;
			ConfiguredTaskAwaitable<uyVKVHfBV15RgM2mXEc3> val = default;
			jX93P4fIu15bhq10GXXT jX93P4fIu15bhq10GXXT = default;
			int num9 = default;
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
							case 991:
								break;
							case 10:
								goto IL_033b;
							default:
								goto end_IL_000c;
							}
							break;
						case 0:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 13;
									goto IL_006a;
								}
								goto IL_015b;
								IL_015b:
								_u__ = __u__1;
								num5 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
								{
									num5 = 0;
								}
								goto IL_006a;
								IL_006a:
								while (true)
								{
									switch (num5)
									{
									default:
										switch (num6)
										{
										case 1003:
											continue;
										case 23:
											_u__ = val;
											num5 = 11;
											continue;
										}
										goto case 3;
									case 13:
										jX93P4fIu15bhq10GXXT = BMBwE6fIiRdqmheZPl4M.Load();
										num5 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
										{
											num5 = 9;
										}
										continue;
									case 4:
										num4 = (__1__state = -1);
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
										{
											num5 = 3;
										}
										continue;
									case 6:
									{
										RcffBcdByv5(jX93P4fIu15bhq10GXXT, host, port, token);
										val = (ConfiguredTaskAwaitable<uyVKVHfBV15RgM2mXEc3>)0;
										int num7 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
										{
											num7 = 11;
										}
										num6 = num7;
										continue;
									}
									case 10:
										break;
									case 8:
										return;
									case 15:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<uyVKVHfBV15RgM2mXEc3>.ConfiguredTaskAwaiter, _CreateAsync_d__16>(ref _u__, ref this);
										num5 = 8;
										continue;
									case 11:
										if (&_u__ != null)
										{
											num5 = 3;
											continue;
										}
										goto case 7;
									case 9:
										if (!jX93P4fIu15bhq10GXXT.Enabled)
										{
											num5 = 2;
											continue;
										}
										goto case 6;
									case 5:
										__u__1 = _u__;
										num5 = 15;
										continue;
									case 7:
										num4 = (__1__state = 0);
										num5 = 5;
										continue;
									case 14:
										goto end_IL_006a;
									case 0:
										__u__1 = default;
										num5 = 4;
										continue;
									case 2:
									{
										uyVKVHfBV15RgM2mXEc3 uyVKVHfBV15RgM2mXEc4 = null;
										num5 = 14;
										continue;
									}
									case 3:
									case 12:
									{
										uyVKVHfBV15RgM2mXEc3 uyVKVHfBV15RgM2mXEc4 = (uyVKVHfBV15RgM2mXEc3)(&_u__);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
										{
											num5 = 2;
										}
										continue;
									}
									case 1:
										goto end_IL_006a;
									}
									goto IL_015b;
									continue;
									end_IL_006a:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num8 = 2;
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											num8 = num9;
											break;
										}
										return;
									case 2:
										__1__state = -2;
										num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
										{
											num8 = 0;
										}
										break;
									case 0:
										_ = __t__builder;
										_ = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
										{
											_ = 1;
										}
										break;
									case 1:
										return;
									}
								}
							}
							goto end_IL_000c;
						case 2:
							return;
						case 3:
							goto end_IL_000c;
						case 1:
							{
								num4 = __1__state;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							IL_033b:
							_ = __t__builder;
							_ = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								_ = 2;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				__1__state = -2;
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = __t__builder;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
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
						case 2:
							return;
						case 0:
							goto end_IL_000e;
						case 1:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
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
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool L6UGx9D4uQaALixu3WEr()
		{
			return V6LsJJD4pKbg8vQH9loo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object fChEZfD4a8o7P8DqMj5s()
		{
			return V6LsJJD4pKbg8vQH9loo;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateAsync_d__17 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<uyVKVHfBV15RgM2mXEc3> __t__builder;

		public int port;

		public CancellationToken token;

		public string host;

		public jX93P4fIu15bhq10GXXT options;

		private CancellationTokenSource _timeout_5__2;

		private IPAddress _target_5__3;

		private ConfiguredTaskAwaitable<IPAddress[]>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<JVg10IfBbK4Oyl9dcIc6>.ConfiguredTaskAwaiter __u__2;

		private static object kXYjpWD41TlOPXRNA1Mk;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_ = __t__builder;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
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
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 2:
							break;
						case 0:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
							{
								num3 = 0;
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool yNL4SpD43bJZVKSZmy4C()
		{
			return kXYjpWD41TlOPXRNA1Mk == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Wc3uUYD4vZTB5vrblrrO()
		{
			return kXYjpWD41TlOPXRNA1Mk;
		}
	}

	private readonly object Yg9fBCUSPJq;

	private readonly object dgVfB4L4A6g;

	private readonly object sSbfBh7BEnS;

	private readonly object HShfBU4aqnx;

	private IPEndPoint? EWFfBrgmM0P;

	private long NYmfBo7cD72;

	private long Lq2fBmnVFHa;

	private long AWgfB79nq9a;

	private int URqfBAVIFLT;

	[CompilerGenerated]
	private readonly int clHfBIXk7Z5;

	[CompilerGenerated]
	private readonly global::System.Threading.Tasks.Task CQRfBBccOX6;

	private static object gF5BA4Z1fmkp45ZoNvWY;

	internal int LocalPort
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return clHfBIXk7Z5;
		}
	}

	internal global::System.Threading.Tasks.Task Completion
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return CQRfBBccOX6;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private uyVKVHfBV15RgM2mXEc3(JVg10IfBbK4Oyl9dcIc6 association, IPEndPoint target)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<uyVKVHfBV15RgM2mXEc3?> SbnfBS1Fh81(object host, int port, CancellationToken token)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<uyVKVHfBV15RgM2mXEc3> RcffBcdByv5(object options, object host, int port, CancellationToken token)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void Y3IfB0h6kV4()
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		TaskAwaiter val = default;
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
							goto case 0;
						}
						val = (Completion).GetAwaiter();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						return;
					case 1:
						break;
					case 0:
						(val).GetResult();
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
			if (!(Completion).IsCompleted)
			{
				break;
			}
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task RunAsync()
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task vcefB8vwibI(CancellationToken token)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_SendLoopAsync_d__20 sendLoopAsync_d__ = default;
		sendLoopAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task c7OfByYYVtQ(CancellationToken token)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ReceiveLoopAsync_d__21 receiveLoopAsync_d__ = default;
		receiveLoopAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task Iv4fBWb5Va9(CancellationToken token)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WatchControlAsync_d__22 watchControlAsync_d__ = default;
		watchControlAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task acjfBJnXilJ(CancellationToken token)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WatchActivityAsync_d__23 watchActivityAsync_d__ = default;
		watchActivityAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		((JVg10IfBbK4Oyl9dcIc6)Yg9fBCUSPJq).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private void SUqfBQlHMry(global::System.Threading.Tasks.Task _)
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
					return;
				case 1:
					(HShfBU4aqnx).Dispose();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			}
		}
		while (num == 989);
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						break;
					case 2:
						num3 = 1;
						continue;
					case 0:
						return;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool CaB70HZ1LwZdLsAQailB()
	{
		return gF5BA4Z1fmkp45ZoNvWY == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static uyVKVHfBV15RgM2mXEc3 l2piFCZ1jOAbYZSyX2ax()
	{
		return (uyVKVHfBV15RgM2mXEc3)gF5BA4Z1fmkp45ZoNvWY;
	}
}

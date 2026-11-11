using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Vl4jDMX56cFYkU2Jw1oo;
using bP1knHfaZRN10coBj77w;
using fDAldojjppXrctUVYOJn;
using knGiRcfu9DhbMgArQGtn;

namespace MX5HwHX3nc4qLanQ6mn2;

internal sealed class JVkIaKX3ikipomuYPq5Q
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LaunchAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<int> __t__builder;

		public YBV0pDfajTopiWOW3iSn request;

		public JVkIaKX3ikipomuYPq5Q __4__this;

		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public CancellationToken cancellationToken;

		private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter __u__1;

		private static object nCtkCLDZxbbtEiZUhYdo;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b7->IL0564: Incompatible stack heights: 3 vs 1
			//IL_05c2->IL0564: Incompatible stack heights: 3 vs 1
			//IL_0067->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0072->IL0010: Incompatible stack heights: 3 vs 1
			//IL_04a0->IL00f6: Incompatible stack heights: 2 vs 1
			//IL_04ab->IL00f6: Incompatible stack heights: 2 vs 1
			int num = 2;
			JVkIaKX3ikipomuYPq5Q jVkIaKX3ikipomuYPq5Q = default;
			int num4 = default;
			int num6 = default;
			ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<int> val = default;
			int num10 = default;
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
							jVkIaKX3ikipomuYPq5Q = __4__this;
							num3 = 3;
							continue;
						case 4:
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
							{
								_ = 1;
							}
							continue;
						case 0:
							__1__state = -2;
							num = 4;
							break;
						case 2:
							num4 = __1__state;
							num = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num = 11;
							}
							break;
						case 3:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 21;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
									{
										num5 = 16;
									}
									goto IL_00f6;
								}
								goto IL_02f0;
								IL_00ee:
								int num7;
								num6 = num7;
								goto IL_00f2;
								IL_02f0:
								System.ArgumentNullException.ThrowIfNull(request, "request");
								num7 = 3;
								goto IL_00ee;
								IL_00f6:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 != 29)
										{
											if (num6 == 1009)
											{
												goto IL_00f2;
											}
											goto case 3;
										}
										return;
									case 13:
										_u__ = val;
										num5 = 11;
										continue;
									case 5:
										throw new global::System.Exception("请先建立游戏会话");
									case 19:
										if (request.Room.HasJoinMetadata)
										{
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
											{
												num5 = 15;
											}
											continue;
										}
										goto case 14;
									case 6:
										num4 = (__1__state = 0);
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
										{
											num5 = 20;
										}
										continue;
									case 10:
										if (!string.IsNullOrEmpty(request.Password))
										{
											num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
											{
												num5 = 12;
											}
											continue;
										}
										goto case 12;
									case 8:
									case 16:
									{
										int num8 = (int)(&_u__);
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											num5 = 7;
										}
										continue;
									}
									case 4:
										if ((object)((da18CdX55laNMRKtM3p0)jVkIaKX3ikipomuYPq5Q.NjwXvbqyW29).CurrentSession != null)
										{
											num5 = 19;
											continue;
										}
										goto case 5;
									case 15:
									case 21:
										_u__ = __u__1;
										num5 = 18;
										continue;
									case 20:
										__u__1 = _u__;
										num5 = 17;
										continue;
									case 1:
										break;
									case 14:
										throw new global::System.Exception("公共房间缺少自动加入所需的连接信息，请刷新大厅后重试");
									case 0:
										if (request.Room.RequiresPassword)
										{
											num5 = 13;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
											{
												num5 = 10;
											}
											continue;
										}
										goto case 2;
									case 11:
										if (&_u__ != null)
										{
											num5 = 16;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
											{
												num5 = 6;
											}
											continue;
										}
										goto case 6;
									case 3:
										System.ArgumentNullException.ThrowIfNull(request.Room, "request.Room");
										num5 = 4;
										continue;
									case 12:
										_ = "请输入公共房间密码";
										throw new global::System.Exception("request");
									case 2:
										((da18CdX55laNMRKtM3p0)jVkIaKX3ikipomuYPq5Q.NjwXvbqyW29).GUTXRBBdVnl(request, progress, cancellationToken);
										val = (ConfiguredTaskAwaitable<int>)0;
										_ = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
										{
											_ = 18;
										}
										continue;
									case 9:
										num4 = (__1__state = -1);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
										{
											num5 = 8;
										}
										continue;
									case 18:
										__u__1 = default;
										num5 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
										{
											num5 = 9;
										}
										continue;
									case 17:
										goto IL_04ff;
									case 7:
										goto end_IL_00be;
									}
									break;
								}
								goto IL_02f0;
								IL_00f2:
								num5 = num6;
								goto IL_00f6;
								IL_04ff:
								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter, _LaunchAsync_d__2>(ref _u__, ref this);
								num7 = 29;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
								{
									num7 = 24;
								}
								goto IL_00ee;
								end_IL_00be:;
							}
							catch (global::System.Exception)
							{
								int num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
								{
									num9 = 8;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										if (num10 == 990)
										{
											num9 = num10;
											continue;
										}
										break;
									case 0:
										__1__state = -2;
										num9 = 2;
										continue;
									case 2:
										break;
									case 1:
										return;
									}
									_ = __t__builder;
									_ = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
									{
										_ = 5;
									}
								}
							}
							goto case 0;
						case 1:
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
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
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						case 1:
							break;
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
				while (num2 == 990);
				num = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool QsSb4tDZFGUa2dIGjfXN()
		{
			return nCtkCLDZxbbtEiZUhYdo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object dL8Z6JDZss9180xgnwxL()
		{
			return nCtkCLDZxbbtEiZUhYdo;
		}
	}

	private readonly object NjwXvbqyW29;

	internal static object lp9JVCZPl1SYE3jbADlq;

	[MethodImpl((MethodImplOptions)8)]
	internal JVkIaKX3ikipomuYPq5Q(da18CdX55laNMRKtM3p0 client)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<int> QXhX3zRL9dW(YBV0pDfajTopiWOW3iSn request, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 1:
						break;
					case 2:
						num3 = 1;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
			{
				num = 1;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool N2AP5RZPdWgltfx9prup()
	{
		return lp9JVCZPl1SYE3jbADlq == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JVkIaKX3ikipomuYPq5Q sc85lqZPKAGvZwKw7wJp()
	{
		return (JVkIaKX3ikipomuYPq5Q)lp9JVCZPl1SYE3jbADlq;
	}
}

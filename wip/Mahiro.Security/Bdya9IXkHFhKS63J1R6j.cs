using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using fL58ItfV1kVf9frJWuxF;

namespace OjRDRnXktG0jdQCvW1ed;

sealed class Bdya9IXkHFhKS63J1R6j : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AcquireAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<Bdya9IXkHFhKS63J1R6j> __t__builder;

		public SemaphoreSlim gate;

		public CancellationToken cancellationToken;

		private object __u__1;

		private static object F3JQOR9PhYGX1oQDRphI;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0195: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331->IL02fa: Incompatible stack heights: 3 vs 1
			//IL_006c->IL0010: Incompatible stack heights: 3 vs 1
			int num = 2;
			int num4 = default;
			int num7 = default;
			object _u__ = default;
			ConfiguredTaskAwaitable val = default;
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
							if (num2 == 10)
							{
								try
								{
									int num5;
									if (num4 != 0)
									{
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num5 = 7;
										}
										goto IL_00cc;
									}
									goto IL_028c;
									IL_00cc:
									while (true)
									{
										int num6;
										switch (num5)
										{
										case 4:
											return;
										default:
											if (num7 != 20)
											{
												if (num7 == 1000)
												{
													goto IL_00c8;
												}
												goto case 8;
											}
											num4 = (__1__state = 0);
											num5 = 7;
											continue;
										case 9:
											__t__builder.AwaitUnsafeOnCompleted<object, _AcquireAsync_d__2>(ref _u__, ref this);
											num5 = 4;
											continue;
										case 6:
											System.ArgumentNullException.ThrowIfNull(gate, "gate");
											num5 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
											{
												num5 = 20;
											}
											continue;
										case 1:
											val = ((gate).WaitAsync(cancellationToken)).ConfigureAwait(false);
											num5 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											_u__ = val;
											num6 = 12;
											goto IL_00c4;
										case 11:
										{
											Bdya9IXkHFhKS63J1R6j bdya9IXkHFhKS63J1R6j = (Bdya9IXkHFhKS63J1R6j)new Bdya9IXkHFhKS63J1R6j(gate);
											num6 = 10;
											goto IL_00c4;
										}
										case 12:
											if (!(_u__).IsCompleted)
											{
												num6 = 20;
												goto IL_00c4;
											}
											goto case 8;
										case 3:
											num4 = (__1__state = -1);
											num5 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
											{
												num5 = 8;
											}
											continue;
										case 7:
											__u__1 = _u__;
											num5 = 9;
											continue;
										case 2:
											__u__1 = default;
											num5 = 3;
											continue;
										case 8:
											(_u__).GetResult();
											num5 = 11;
											continue;
										case 5:
											break;
										case 10:
											goto end_IL_00cc;
											IL_00c4:
											num7 = num6;
											goto IL_00c8;
											IL_00c8:
											num5 = num7;
											continue;
										}
										goto IL_028c;
										continue;
										end_IL_00cc:
										break;
									}
									goto end_IL_0094;
									IL_028c:
									_u__ = __u__1;
									num5 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
									{
										num5 = 2;
									}
									goto IL_00cc;
									end_IL_0094:;
								}
								catch (global::System.Exception)
								{
									int num8 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
									{
										num8 = 0;
									}
									while (true)
									{
										switch (num8)
										{
										case 2:
											return;
										default:
											if (num9 != 990)
											{
												return;
											}
											num8 = num9;
											break;
										case 1:
											_ = __t__builder;
											_ = 2;
											break;
										case 0:
											__1__state = -2;
											num8 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
											{
												num8 = 1;
											}
											break;
										}
									}
								}
								break;
							}
							goto IL_0033;
						case 3:
							return;
						case 2:
							goto end_IL_000c;
						case 1:
							_ = __t__builder;
							_ = 3;
							continue;
						case 0:
							break;
						}
						goto IL_006c;
						IL_0033:
						if (num2 == 991)
						{
							break;
						}
						goto IL_006c;
						IL_006c:
						__1__state = -2;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num3 = 1;
						}
					}
					continue;
					end_IL_000c:
					break;
				}
				num4 = __1__state;
				num = 10;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
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
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto IL_0031;
						case 1:
							break;
						case 2:
							goto end_IL_000e;
						case 0:
							return;
						}
						goto IL_0068;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0068;
						IL_0068:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool sh5MBn9PULphtv8GnN7J()
		{
			return F3JQOR9PhYGX1oQDRphI == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object u64n3p9Prv7c7fudCboA()
		{
			return F3JQOR9PhYGX1oQDRphI;
		}
	}

	private SemaphoreSlim? sjFXk5xoTq0;

	private static object NYTKuvZIr4UClFJ44QEw;

	[MethodImpl((MethodImplOptions)8)]
	private Bdya9IXkHFhKS63J1R6j(SemaphoreSlim gate)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<Bdya9IXkHFhKS63J1R6j> nYLXkOKLDtx(object gate, CancellationToken cancellationToken)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		_AcquireAsync_d__2 acquireAsync_d__ = default;
		acquireAsync_d__.__1__state = -1;
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe;
		((AsyncTaskMethodBuilder<byte[]>*)1)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter, IuFb5gfVakTHm3qModnF._TryReadAsync_d__10>(ref this, ref this);
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_AcquireAsync_d__2*)4)->__t__builder, ref acquireAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
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
						switch (num2)
						{
						case 990:
							goto end_IL_0012;
						case 9:
							return;
						}
						goto end_IL_000e;
					case 2:
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						goto end_IL_000e;
					case 1:
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						end_IL_0012:
						break;
					}
					break;
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
	internal static bool lKfcYYZIod49bsn821Lp()
	{
		return NYTKuvZIr4UClFJ44QEw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Bdya9IXkHFhKS63J1R6j bNPm5AZImKAPam6GTiwY()
	{
		return (Bdya9IXkHFhKS63J1R6j)NYTKuvZIr4UClFJ44QEw;
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using cTpd1lf54YS57isqnyoi;
using fDAldojjppXrctUVYOJn;
using hGYycdXXDoG2mOL5yubN;

namespace ukP35Jzt5b38OvfDOL9;

internal class enUnXWzH2140NUR5ig9
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WaitForExitAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public Process process;

		public CancellationToken cancellationToken;

		public TimeSpan timeout;

		private object __u__1;

		internal static object BNYesy9OO4TIcwbFilvx;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0353: Unknown result type (might be due to invalid IL or missing references)
			//IL_0358: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_02af: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_02da: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0560->IL051f: Incompatible stack heights: 3 vs 1
			//IL_056b->IL051f: Incompatible stack heights: 3 vs 1
			//IL_0063->IL0008: Incompatible stack heights: 3 vs 1
			//IL_006e->IL0008: Incompatible stack heights: 3 vs 1
			int num3 = default;
			int num5 = default;
			ConfiguredTaskAwaitable val = default;
			int num8 = default;
			object _u__ = default;
			int num11 = default;
			int num13 = default;
			int num15 = default;
			while (true)
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
							if (num != 10)
							{
								if (num == 991)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							return;
						case 2:
							break;
						case 1:
							num3 = __1__state;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
							{
								num2 = 5;
							}
							continue;
						case 3:
							__1__state = -2;
							num2 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num2 = 2;
							}
							continue;
						case 0:
							try
							{
								int num4;
								if (num3 == 0)
								{
									num4 = 5;
									goto IL_00d9;
								}
								goto IL_011f;
								IL_0184:
								num4 = 4;
								goto IL_00d9;
								IL_00d9:
								num5 = num4;
								goto IL_00dd;
								IL_00dd:
								int num6 = num5;
								goto IL_00e1;
								IL_00e1:
								bool flag;
								switch (num6)
								{
								case 3:
									goto IL_011f;
								case 2:
									goto IL_0162;
								case 0:
								case 5:
									goto IL_0184;
								case 1:
									goto end_IL_00be;
								case 4:
									try
									{
										int num7;
										if (num3 != 0)
										{
											num7 = 8;
											goto IL_01f3;
										}
										goto IL_0352;
										IL_02a8:
										val = (((process).WaitForExitAsync(cancellationToken)).WaitAsync(timeout, cancellationToken)).ConfigureAwait(false);
										num7 = 20;
										goto IL_01f3;
										IL_01f3:
										num8 = num7;
										goto IL_01f7;
										IL_01f7:
										int num9 = num8;
										goto IL_01fb;
										IL_01fb:
										while (true)
										{
											switch (num9)
											{
											case 9:
												return;
											case 0:
												flag = true;
												num9 = 10;
												continue;
											case 6:
												__u__1 = default;
												num9 = 3;
												continue;
											case 7:
												if ((_u__).IsCompleted)
												{
													num9 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
													{
														num9 = 0;
													}
													continue;
												}
												goto case 1;
											case 8:
												goto end_IL_01fb;
											case 4:
											case 5:
												(_u__).GetResult();
												num9 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
												{
													num9 = 17;
												}
												continue;
											case 2:
												__t__builder.AwaitUnsafeOnCompleted<object, _WaitForExitAsync_d__4>(ref _u__, ref this);
												num9 = 9;
												continue;
											case 12:
												goto IL_0352;
											case 11:
												__u__1 = _u__;
												num9 = 2;
												continue;
											case 3:
												num3 = (__1__state = -1);
												num9 = 8;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
												{
													num9 = 5;
												}
												continue;
											case 1:
												num3 = (__1__state = 0);
												num9 = 11;
												continue;
											case 10:
												goto end_IL_01d8;
											}
											if (num8 == 20)
											{
												_u__ = val;
												num9 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
												{
													num9 = 10;
												}
												continue;
											}
											goto IL_0242;
											continue;
											end_IL_01fb:
											break;
										}
										goto IL_02a8;
										IL_0242:
										if (num8 == 1000)
										{
											goto IL_01f7;
										}
										goto IL_02a8;
										IL_0352:
										_u__ = __u__1;
										num9 = 6;
										goto IL_01fb;
										end_IL_01d8:;
									}
									catch (TimeoutException)
									{
										int num10 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
										{
											num10 = 1;
										}
										while (true)
										{
											switch (num10)
											{
											default:
												if (num11 == 989)
												{
													num10 = num11;
													continue;
												}
												break;
											case 1:
												break;
											case 0:
												goto end_IL_041d;
											}
											flag = (process).HasExited;
											num10 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
											{
												num10 = 6;
											}
											continue;
											end_IL_041d:
											break;
										}
									}
									catch (InvalidOperationException)
									{
										int num12 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
										{
											num12 = 2;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												if (num13 == 989)
												{
													num12 = num13;
													continue;
												}
												break;
											case 0:
												break;
											case 1:
												goto end_IL_04a5;
											}
											flag = true;
											num12 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
											{
												num12 = 1;
											}
											continue;
											end_IL_04a5:
											break;
										}
									}
									goto end_IL_00be;
								}
								if (num5 != 13 && num5 == 993)
								{
									goto IL_00dd;
								}
								goto IL_0184;
								IL_011f:
								if (!(process).HasExited)
								{
									num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
									{
										num4 = 3;
									}
									goto IL_00d9;
								}
								goto IL_0162;
								IL_0162:
								flag = true;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
								{
									num6 = 13;
								}
								goto IL_00e1;
								end_IL_00be:;
							}
							catch (global::System.Exception)
							{
								int num14 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
								{
									num14 = 8;
								}
								while (true)
								{
									switch (num14)
									{
									case 1:
										return;
									default:
										if (num15 != 990)
										{
											break;
										}
										goto IL_051b;
									case 2:
										break;
									case 0:
										{
											__1__state = -2;
											num15 = 2;
											goto IL_051b;
										}
										IL_051b:
										num14 = num15;
										continue;
									}
									_ = __t__builder;
									_ = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
									{
										_ = 3;
									}
								}
							}
							goto case 3;
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
				_ = __t__builder;
				_ = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
				{
					_ = 3;
				}
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
						case 1:
							goto end_IL_000e;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
							{
								num3 = 2;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool IVtfD89O5I4ZAFEpALh8()
		{
			return BNYesy9OO4TIcwbFilvx == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object KuE2tx9O6MZgcnN5jjZo()
		{
			return BNYesy9OO4TIcwbFilvx;
		}
	}

	private static TimeSpan HoozR62A3E;

	private static TimeSpan E4Ozw9EObD;

	internal static object fsxgSXZmB9OibNghCj78;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task uE9zOYj6fv(object process, object expected, bool hostAcceptedShutdown, bool allowForcedTermination, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_StopForComponentUpdateAsync_d__2 stopForComponentUpdateAsync_d__ = default;
		stopForComponentUpdateAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool JsTz5GvHef(object process, object expected)
	{
		//IL_03c1: Expected O, but got Ref
		int num = 2;
		int num7 = default;
		string text = default;
		global::System.DateTime dateTime = default;
		long num5 = default;
		bool result = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default;
		int num10 = default;
		bool flag = default;
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num12 = default;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					System.ArgumentNullException.ThrowIfNull(expected, "expected");
					num2 = 3;
					continue;
				case 2:
					System.ArgumentNullException.ThrowIfNull(process, "process");
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					try
					{
						global::System.DateTime? startTime = ((NYI398f5COw5dgT3xbBV)expected).StartTime;
						int num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							object obj;
							int num8;
							int num6;
							long num4;
							switch (num3)
							{
							default:
							{
								if (num7 != 28)
								{
									if (num7 == 1008)
									{
										goto IL_00e3;
									}
									goto case 2;
								}
								ProcessModule obj2 = (process).MainModule;
								if (obj2 == null)
								{
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
									{
										num3 = 11;
									}
									continue;
								}
								obj = (obj2).FileName;
								goto IL_043e;
							}
							case 4:
								num8 = (Q8xMnNXX9IjGqqCAeb4q.yWMXXVOZltL(text) ? 1 : 0);
								break;
							case 8:
								dateTime = (process).StartTime;
								num3 = 5;
								continue;
							case 7:
								dateTime = (dateTime).ToUniversalTime();
								num3 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								if (((NYI398f5COw5dgT3xbBV)expected).SessionId < 0)
								{
									num3 = 2;
									continue;
								}
								goto case 16;
							case 14:
								if ((process).HasExited)
								{
									num3 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
									{
										num3 = 3;
									}
									continue;
								}
								goto case 13;
							case 17:
								if ((dateTime).Ticks == num5)
								{
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
									{
										num3 = 6;
									}
									continue;
								}
								goto case 2;
							case 13:
								if ((process).Id == ((NYI398f5COw5dgT3xbBV)expected).ProcessId)
								{
									num3 = 15;
									continue;
								}
								goto case 2;
							case 5:
								dateTime = (dateTime).ToUniversalTime();
								num3 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num3 = 28;
								}
								continue;
							case 16:
								if ((process).SessionId == ((NYI398f5COw5dgT3xbBV)expected).SessionId)
								{
									num3 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 2;
							case 15:
								if (num5 > 0)
								{
									num3 = 8;
									continue;
								}
								goto case 2;
							case 9:
								if (&startTime == null)
								{
									num3 = 27;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
									{
										num3 = 20;
									}
								}
								else
								{
									dateTime = (global::System.DateTime)(&startTime);
									num3 = 7;
								}
								continue;
							case 6:
								if (string.IsNullOrWhiteSpace(text))
								{
									num6 = 11;
									goto IL_00df;
								}
								goto case 10;
							case 10:
								if (!string.Equals(System.IO.Path.GetFullPath(text), System.IO.Path.GetFullPath(((NYI398f5COw5dgT3xbBV)expected).ExecutablePath), (StringComparison)5))
								{
									num3 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 4;
							case 20:
								num4 = 0L;
								goto IL_03d7;
							case 18:
								num4 = (dateTime).Ticks;
								goto IL_03d7;
							case 1:
								obj = null;
								goto IL_043e;
							case 2:
							case 3:
							case 11:
							case 19:
								num8 = 0;
								break;
							case 12:
								goto end_IL_00e7;
								IL_03d7:
								num5 = num4;
								num6 = 28;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
								{
									num6 = 28;
								}
								goto IL_00df;
								IL_00e3:
								num3 = num7;
								continue;
								IL_00df:
								num7 = num6;
								goto IL_00e3;
								IL_043e:
								text = (string)obj;
								num3 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							result = (byte)num8 != 0;
							num3 = 12;
							continue;
							end_IL_00e7:
							break;
						}
					}
					catch (object obj3) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj4 = obj3 as global::System.Exception;
						if (obj4 == null)
						{
							num9 = 5;
						}
						else
						{
							ex = obj4;
							num9 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num9 = 7;
							}
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 != 19 && num10 == 999)
								{
									goto IL_049a;
								}
								goto case 6;
							case 6:
							case 7:
								flag = true;
								num9 = 2;
								continue;
							case 1:
								if (!(ex is InvalidOperationException))
								{
									num9 = 8;
									continue;
								}
								goto case 6;
							case 3:
								if (!(ex is IOException))
								{
									num9 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num9 = 0;
									}
									continue;
								}
								goto case 6;
							case 10:
								if (ex is ArgumentException)
								{
									num9 = 6;
									continue;
								}
								goto case 4;
							case 8:
								if (ex is NotSupportedException)
								{
									num10 = 19;
									goto IL_049a;
								}
								goto case 3;
							case 0:
								if (!(ex is UnauthorizedAccessException))
								{
									num9 = 10;
									continue;
								}
								goto case 6;
							case 4:
								flag = false;
								num9 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num9 = 8;
								}
								continue;
							case 11:
								if (ex is Win32Exception)
								{
									num9 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
									{
										num9 = 7;
									}
									continue;
								}
								goto case 1;
							case 5:
								result2 = 0;
								break;
							case 2:
							case 9:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_049a:
								num9 = num10;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num11 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
						{
							num11 = 1;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 989)
								{
									num11 = num12;
									continue;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_069d;
							}
							result = false;
							num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
							{
								num11 = 2;
							}
							continue;
							end_IL_069d:
							break;
						}
					}
					break;
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
	private unsafe static global::System.Threading.Tasks.Task<bool> wkoz62VIiF(object process, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_000e: Expected O, but got Ref
		//IL_000e: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		_WaitForExitAsync_d__4 waitForExitAsync_d__ = default;
		Enumerable.Any<JsonNode>((global::System.Collections.Generic.IEnumerable<JsonNode>)(&waitForExitAsync_d__.__t__builder), (Func<JsonNode, bool>)(object)(&waitForExitAsync_d__));
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_WaitForExitAsync_d__4*)5)->__t__builder, ref waitForExitAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
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
						if (num2 == 12)
						{
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto end_IL_0012;
					case 3:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
						{
							num3 = 3;
						}
						continue;
					case 0:
						break;
					case 5:
						E4Ozw9EObD = System.TimeSpan.FromSeconds(10.0);
						num3 = 2;
						continue;
					case 2:
						return;
					case 1:
						HoozR62A3E = System.TimeSpan.FromSeconds(8.0);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							num3 = 8;
						}
						continue;
					case 4:
						num3 = 3;
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
			while (num2 == 993);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HWPJdLZmgMAnEb7jrneQ()
	{
		return fsxgSXZmB9OibNghCj78 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static enUnXWzH2140NUR5ig9 hWT22eZmlQhHajBBWy37()
	{
		return (enUnXWzH2140NUR5ig9)fsxgSXZmB9OibNghCj78;
	}
}

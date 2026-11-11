using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace mYKZEuXzD5tMJ7L99pWq;

internal class TwsjUrXz9sQTXc0kkorA
{
	[CompilerGenerated]
	private class __O_22
	{
		public static Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> _0___Delay;

		private static __O_22 wZLUh6DYvgshxZxdOuhM;

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
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto IL_0031;
						case 0:
							return;
						case 2:
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
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
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
		internal static bool lsqIyPDYEPoiywPAlImP()
		{
			return wZLUh6DYvgshxZxdOuhM == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_22 PbFouWDY2Tb7ntJUc33K()
		{
			return wZLUh6DYvgshxZxdOuhM;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WaitAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> delay;

		public CancellationToken token;

		public Func<bool> hasExited;

		public Action<string> report;

		public Action validate;

		private string _lastReason_5__2;

		private int _reports_5__3;

		private int _attempt_5__4;

		private object __u__1;

		internal static object nJk5mFDYqinP3ZumgHb4;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_0525: Expected O, but got I4
			//IL_0745: Unknown result type (might be due to invalid IL or missing references)
			//IL_074b: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Expected O, but got Unknown
			//IL_0757: Unknown result type (might be due to invalid IL or missing references)
			//IL_075c: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e4: Expected O, but got I4
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0726: Unknown result type (might be due to invalid IL or missing references)
			//IL_0783: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected O, but got I4
			//IL_05b1->IL046a: Incompatible stack heights: 4 vs 1
			//IL_0a97->IL0a37: Incompatible stack heights: 3 vs 1
			//IL_0954->IL00e1: Incompatible stack heights: 1 vs 3
			//IL_0aa2->IL0a37: Incompatible stack heights: 3 vs 1
			//IL_0162->IL073f: Incompatible stack heights: 2 vs 0
			//IL_0162->IL0933: Incompatible stack heights: 2 vs 0
			//IL_095f->IL00e1: Incompatible stack heights: 1 vs 3
			//IL_00c5->IL09c3: Incompatible stack heights: 0 vs 2
			//IL_0067->IL0010: Incompatible stack heights: 3 vs 1
			//IL_086a->IL00e1: Incompatible stack heights: 6 vs 3
			//IL_01f7->IL00e1: Incompatible stack heights: 5 vs 3
			//IL_00cf->IL00e1: Incompatible stack heights: 1 vs 3
			//IL_0072->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0202->IL00e1: Incompatible stack heights: 5 vs 3
			//IL_02c6->IL023b: Incompatible stack heights: 7 vs 4
			//IL_02d1->IL023b: Incompatible stack heights: 7 vs 4
			int num = 3;
			int num4 = default;
			object _u__ = default;
			int num8 = default;
			int num10 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
			global::System.Exception ex = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
			int num13 = default;
			bool flag2 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num15 = default;
			string text = default;
			int num6 = default;
			ConfiguredTaskAwaitable val = default;
			int num17 = default;
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
							_ = __t__builder;
							_ = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
							{
								_ = 0;
							}
							continue;
						case 3:
							num4 = __1__state;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
						case 0:
							return;
						case 4:
							goto end_IL_000c;
						case 2:
							try
							{
								if (num4 != 0)
								{
									_ = 29;
									goto IL_00e1;
								}
								goto IL_09c3;
								IL_09c3:
								_u__ = __u__1;
								int num5 = 27;
								goto IL_00e1;
								IL_00e1:
								while (true)
								{
									int num7;
									switch (num5)
									{
									default:
										if (num8 == 38)
										{
											return;
										}
										if (num8 == 1018)
										{
											goto IL_00dd;
										}
										goto case 10;
									case 18:
										_attempt_5__4 = 1;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
										{
											num5 = 8;
										}
										continue;
									case 10:
										__u__1 = _u__;
										num5 = 20;
										continue;
									case 4:
										_ = report;
										_ = "stopped reason=process_exited";
										_ = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
										{
											_ = 12;
										}
										continue;
									case 25:
										try
										{
											_ = validate;
											int num9 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
											{
												num9 = 1;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													if (num10 != 990)
													{
														break;
													}
													goto IL_0237;
												case 1:
													break;
												case 0:
												{
													bool flag = true;
													num10 = 2;
													goto IL_0237;
												}
												case 2:
													goto end_IL_023b;
													IL_0237:
													num9 = num10;
													continue;
												}
												_ = report;
												_ = 19;
												global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
												(defaultInterpolatedStringHandler).AppendLiteral("validated attempts=");
												defaultInterpolatedStringHandler.AppendFormatted<int>(_attempt_5__4);
												(defaultInterpolatedStringHandler).ToStringAndClear();
												_ = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
												{
													_ = 0;
												}
												continue;
												end_IL_023b:
												break;
											}
										}
										catch (object obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num11 = 4;
												goto IL_0310;
											}
											ex = obj2;
											num12 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
											{
												num12 = 4;
											}
											num13 = num12;
											goto IL_030c;
											IL_030c:
											num11 = num13;
											goto IL_0310;
											IL_0310:
											while (true)
											{
												switch (num11)
												{
												default:
													if (num13 != 14)
													{
														if (num13 == 994)
														{
															break;
														}
														goto case 4;
													}
													if (!(ex is InvalidDataException))
													{
														num11 = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
														{
															num11 = 1;
														}
														continue;
													}
													goto case 3;
												case 0:
												case 2:
													flag2 = false;
													num11 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
													{
														num11 = 9;
													}
													continue;
												case 1:
													if (!(ex is Win32Exception))
													{
														num11 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
														{
															num11 = 1;
														}
														continue;
													}
													goto case 3;
												case 3:
													flag2 = true;
													num11 = 5;
													continue;
												case 4:
													result = 0;
													goto IL_0436;
												case 5:
												case 6:
													{
														result = (flag2 ? 1 : 0);
														goto IL_0436;
													}
													IL_0436:
													return (byte)result != 0;
												}
												break;
											}
											goto IL_030c;
										}).Invoke())
										{
											int num14 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
											{
												num14 = 1;
											}
											while (true)
											{
												switch (num14)
												{
												default:
													if (num15 != 17)
													{
														if (num15 == 997)
														{
															goto IL_0466;
														}
														goto case 1;
													}
													if (!(text != _lastReason_5__2))
													{
														num14 = 6;
														continue;
													}
													goto case 5;
												case 5:
													num6 = _reports_5__3;
													num14 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
													{
														num14 = 0;
													}
													continue;
												case 1:
													text = O6KXzkJXgtm(ex);
													num14 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
													{
														num14 = 13;
													}
													continue;
												case 3:
												case 6:
												case 7:
													_lastReason_5__2 = text;
													num14 = 4;
													continue;
												case 9:
												{
													_ = report;
													_ = 23;
													global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
													(defaultInterpolatedStringHandler2).AppendLiteral("waiting attempt=");
													defaultInterpolatedStringHandler2.AppendFormatted<int>(_attempt_5__4);
													(defaultInterpolatedStringHandler2).AppendLiteral(" guard=");
													(defaultInterpolatedStringHandler2).AppendFormatted(text);
													(defaultInterpolatedStringHandler2).ToStringAndClear();
													_ = 7;
													continue;
												}
												case 8:
													if (_attempt_5__4 != 1)
													{
														num15 = 17;
														goto IL_0466;
													}
													goto case 5;
												case 0:
													_reports_5__3 = num6 + 1;
													num14 = 9;
													continue;
												case 2:
													if (_reports_5__3 >= 8)
													{
														num14 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
														{
															num14 = 2;
														}
														continue;
													}
													goto case 8;
												case 4:
													break;
													IL_0466:
													num14 = num15;
													continue;
												}
												break;
											}
											goto case 26;
										}
										goto end_IL_00e1;
									case 1:
										num4 = (__1__state = -1);
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
										{
											num5 = 3;
										}
										continue;
									case 24:
										_reports_5__3 = 0;
										num7 = 18;
										goto IL_00d9;
									case 12:
									{
										bool flag = false;
										num5 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
										{
											num5 = 19;
										}
										continue;
									}
									case 23:
										_attempt_5__4 = num6 + 1;
										num5 = 30;
										continue;
									case 3:
										(_u__).GetResult();
										num5 = 16;
										continue;
									case 17:
										if (hasExited != null)
										{
											num5 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
											{
												num5 = 11;
											}
											continue;
										}
										goto case 15;
									case 19:
										goto end_IL_00e1;
									case 13:
										_u__ = val;
										num5 = 9;
										continue;
									case 8:
									{
										bool flag = false;
										num5 = 6;
										continue;
									}
									case 11:
										_ = delay;
										_ = yVkXzStFXdX;
										val = (token).ConfigureAwait(false);
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
										{
											num5 = 13;
										}
										continue;
									case 27:
										__u__1 = default;
										num5 = 36;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
										{
											num5 = 1;
										}
										continue;
									case 16:
									case 21:
										num6 = _attempt_5__4;
										num7 = 23;
										goto IL_00d9;
									case 2:
									{
										_ = report;
										_ = 53;
										global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
										(defaultInterpolatedStringHandler3).AppendLiteral("unavailable reason=readiness_timeout guard=");
										(defaultInterpolatedStringHandler3).AppendFormatted(_lastReason_5__2);
										(defaultInterpolatedStringHandler3).AppendLiteral(" attempts=");
										defaultInterpolatedStringHandler3.AppendFormatted<int>(40);
										(defaultInterpolatedStringHandler3).ToStringAndClear();
										_ = 8;
										continue;
									}
									case 0:
									case 30:
										if (_attempt_5__4 > 40)
										{
											num5 = 2;
											continue;
										}
										goto case 14;
									case 7:
										num4 = (__1__state = 0);
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
										{
											num5 = 36;
										}
										continue;
									case 29:
										if (delay == null)
										{
											num5 = 22;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
											{
												num5 = 28;
											}
											continue;
										}
										goto case 5;
									case 14:
										(token).ThrowIfCancellationRequested();
										num5 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num5 = 20;
										}
										continue;
									case 9:
										if (!(_u__).IsCompleted)
										{
											num5 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
											{
												num5 = 3;
											}
											continue;
										}
										goto case 3;
									case 26:
										if (_attempt_5__4 >= 40)
										{
											_ = 38;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
											{
												_ = 21;
											}
											continue;
										}
										goto case 11;
									case 15:
										num5 = 25;
										continue;
									case 5:
										_lastReason_5__2 = "not_checked";
										num5 = 24;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num5 = 6;
										}
										continue;
									case 20:
										__t__builder.AwaitUnsafeOnCompleted<object, _WaitAsync_d__3>(ref _u__, ref this);
										num7 = 38;
										goto IL_00d9;
									case 28:
										break;
									case 22:
										delay = __O_22._0___Delay ?? (__O_22._0___Delay = null);
										num5 = 5;
										continue;
									case 6:
										goto end_IL_00e1;
										IL_00d9:
										num8 = num7;
										goto IL_00dd;
										IL_00dd:
										num5 = num8;
										continue;
									}
									goto IL_09c3;
									continue;
									end_IL_00e1:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num16 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
								{
									num16 = 4;
								}
								while (true)
								{
									switch (num16)
									{
									case 2:
										return;
									default:
										if (num17 != 10)
										{
											if (num17 == 990)
											{
												goto IL_0a33;
											}
											goto case 0;
										}
										_ = __t__builder;
										_ = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											_ = 2;
										}
										break;
									case 0:
										_lastReason_5__2 = null;
										num17 = 10;
										goto IL_0a33;
									case 1:
										{
											__1__state = -2;
											num16 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
											{
												num16 = 8;
											}
											break;
										}
										IL_0a33:
										num16 = num17;
										break;
									}
								}
							}
							break;
						}
						__1__state = -2;
						num3 = 4;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				_lastReason_5__2 = null;
				num = 11;
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
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							goto end_IL_000e;
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
		internal static bool WYThBNDYGfO33r1uH7Px()
		{
			return nJk5mFDYqinP3ZumgHb4 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object luVwXkDYiwYl2AZ6Hqym()
		{
			return nJk5mFDYqinP3ZumgHb4;
		}
	}

	internal static TimeSpan yVkXzStFXdX;

	private static object zZq1R1ZFnROZt1wm3sOS;

	[MethodImpl((MethodImplOptions)8)]
	internal static string O6KXzkJXgtm(object exception)
	{
		int num = 18;
		string text2 = default;
		string result = default;
		string text = default;
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
						if (num2 != 34)
						{
							if (num2 == 1015)
							{
								goto end_IL_0010;
							}
							goto case 5;
						}
						goto case 1;
					case 23:
						text2 = "input_id_vtable";
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
					case 3:
					case 7:
					case 15:
					case 26:
					case 27:
						result = text2;
						num3 = 25;
						continue;
					case 20:
						if ((text == "input_field_load"))
						{
							num3 = 13;
							continue;
						}
						goto case 4;
					case 8:
						if (!(text == "input_id_vtable"))
						{
							num3 = 2;
							continue;
						}
						goto case 23;
					case 14:
						text2 = "input_write_readback";
						num3 = 27;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num3 = 2;
						}
						continue;
					case 13:
					case 24:
						text2 = "input_field_load";
						num = 15;
						break;
					case 0:
						if (!(text == "input_write_readback"))
						{
							num3 = 10;
							continue;
						}
						goto case 14;
					case 16:
					case 19:
						text2 = "input_serializer_vtable";
						num3 = 7;
						continue;
					case 21:
						if ((text == "input_packet_id"))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num3 = 29;
							}
							continue;
						}
						goto case 8;
					case 17:
						result = "memory_unavailable";
						num3 = 12;
						continue;
					case 4:
						if (!(text == "input_field_reference"))
						{
							num3 = 21;
							continue;
						}
						goto case 9;
					case 18:
						if (exception is BlobReader)
						{
							num3 = 30;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
							{
								num3 = 17;
							}
							continue;
						}
						goto case 11;
					case 12:
					case 25:
						return result;
					case 9:
						text2 = "input_field_reference";
						num = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
						{
							num = 34;
						}
						break;
					case 5:
					case 6:
						text2 = "input_packet_id";
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
						{
							num3 = 9;
						}
						continue;
					case 10:
					case 22:
						text2 = "validation_failed";
						num = 26;
						break;
					case 2:
						if ((text == "input_serializer_vtable"))
						{
							num3 = 21;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto case 0;
					case 11:
						text = (exception).Message;
						num3 = 20;
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
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<bool> xP2XzVUaR6e(object validate, Func<bool> hasExited, Action<string> report, CancellationToken token, Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task>? delay = null)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0012;
							}
							goto case 4;
						}
						num3 = 4;
						continue;
					case 0:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 3;
						continue;
					case 3:
						yVkXzStFXdX = System.TimeSpan.FromMilliseconds(500.0);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 6;
						}
						continue;
					case 1:
						return;
					case 4:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						break;
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
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool U7TFhRZFzDVEFVfx395w()
	{
		return zZq1R1ZFnROZt1wm3sOS == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static TwsjUrXz9sQTXc0kkorA UKUqEMZsbGmV2X5KTbWQ()
	{
		return (TwsjUrXz9sQTXc0kkorA)zZq1R1ZFnROZt1wm3sOS;
	}
}

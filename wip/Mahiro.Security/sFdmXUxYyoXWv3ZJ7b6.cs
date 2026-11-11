using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace JiZxakxSS0nXGmEGsIx;

internal sealed class sFdmXUxYyoXWv3ZJ7b6
{
	[CompilerGenerated]
	private class __O_46
	{
		public static Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> _0___Delay;

		private static __O_46 tuudar9AnrGotxjmyoLU;

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
								goto case 1;
							}
							return;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool GcsIjI9AzfmdMNx7rdaZ()
		{
			return tuudar9AnrGotxjmyoLU == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_46 whLix89Ib15FtAsFq1H5()
		{
			return tuudar9AnrGotxjmyoLU;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_164
	{
		public static __c_164 __9;

		public static Func<DateTimeOffset> __9__11_0;

		internal static __c_164 hJKmuI9IXyMTrSSOuRGT;

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
						case 4:
							return;
						case 2:
							__9 = (__c_164)new __c_164();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 3:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 7;
							}
							continue;
						case 0:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 2;
							continue;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							num3 = 3;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
				{
					num = 0;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_164()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset SmdfGabcOjW()
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return System.DateTimeOffset.UtcNow;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Qqirs39IfNgKmohZRVy9()
		{
			return hJKmuI9IXyMTrSSOuRGT == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_164 bhIjdO9ILO15pAGarEOc()
		{
			return hJKmuI9IXyMTrSSOuRGT;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__12_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<HttpResponseMessage> __t__builder;

		public string operationName;

		public Func<CancellationToken, global::System.Threading.Tasks.Task<HttpResponseMessage>> send;

		public CancellationToken cancellationToken;

		public sFdmXUxYyoXWv3ZJ7b6 __4__this;

		private int _retryCount_5__2;

		private HttpResponseMessage _response_5__3;

		private object __7__wrap3;

		private int __7__wrap4;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		internal static object aDJG6Q9IjrBfGNgqFqZG;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_07d9: Expected O, but got Unknown
			//IL_0882: Expected O, but got Unknown
			//IL_0e33: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e3a: Expected O, but got Unknown
			//IL_02de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0924: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc2: Expected O, but got Unknown
			//IL_0dbd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dc2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eff: Invalid comparison between Unknown and I4
			//IL_0e9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cee: Expected O, but got Unknown
			//IL_0bc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c05: Unknown result type (might be due to invalid IL or missing references)
			//IL_034b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c61: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf8: Expected O, but got Unknown
			//IL_0f5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f5f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Expected O, but got Unknown
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ad8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3e: Expected O, but got Unknown
			//IL_0f39: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Expected O, but got Ref
			//IL_0649: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0675: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_069d: Unknown result type (might be due to invalid IL or missing references)
			//IL_10cf->IL1071: Incompatible stack heights: 3 vs 1
			//IL_0dd8->IL011c: Incompatible stack heights: 3 vs 1
			//IL_0481->IL011c: Incompatible stack heights: 3 vs 1
			//IL_0f4a->IL011c: Incompatible stack heights: 3 vs 1
			//IL_008f->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0de3->IL011c: Incompatible stack heights: 3 vs 1
			//IL_048c->IL011c: Incompatible stack heights: 3 vs 1
			//IL_009a->IL0010: Incompatible stack heights: 3 vs 1
			//IL_05d6->IL04ee: Incompatible stack heights: 3 vs 1
			//IL_05e1->IL04ee: Incompatible stack heights: 3 vs 1
			int num = 4;
			sFdmXUxYyoXWv3ZJ7b6 sFdmXUxYyoXWv3ZJ7b7 = default;
			int num4 = default;
			int num6 = default;
			object _u__ = default;
			ConfiguredTaskAwaitable val = default;
			int num8 = default;
			global::System.Collections.Generic.IReadOnlyList<TimeSpan> readOnlyList2 = default;
			TimeSpan delay = default;
			int num10 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val4 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
			int num13 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num15 = default;
			int num17 = default;
			int num19 = default;
			HttpRequestException ex = default;
			OperationCanceledException ex2 = default;
			HttpStatusCode? val2 = default;
			int num21 = default;
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
								goto case 3;
							}
							_ = __t__builder;
							_ = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								_ = 6;
							}
							continue;
						case 1:
							break;
						case 2:
							return;
						case 3:
							sFdmXUxYyoXWv3ZJ7b7 = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							num4 = __1__state;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num3 = 10;
							}
							continue;
						case 0:
							try
							{
								int num5;
								switch (num4)
								{
								default:
									num5 = 54;
									goto IL_011c;
								case 0:
									num5 = 31;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
									{
										num5 = 0;
									}
									goto IL_011c;
								case 2:
									goto IL_0bc4;
								case 3:
									goto IL_0cc4;
								case 1:
									goto IL_0f59;
									IL_011c:
									while (true)
									{
										int num7;
										global::System.Collections.Generic.IReadOnlyList<TimeSpan> readOnlyList;
										TimeSpan delay2;
										switch (num5)
										{
										case 9:
											return;
										case 45:
											return;
										case 62:
											return;
										default:
											if (num6 != 80)
											{
												if (num6 == 1060)
												{
													goto IL_0118;
												}
												goto case 1;
											}
											__t__builder.AwaitUnsafeOnCompleted<object, _SendAsync_d__12_1>(ref _u__, ref this);
											num7 = 62;
											goto IL_0114;
										case 27:
											(_response_5__3).Dispose();
											num5 = 65;
											continue;
										case 72:
											_u__ = val;
											num5 = 17;
											continue;
										case 21:
											if (num8 != 1)
											{
												num5 = 20;
												continue;
											}
											goto case 52;
										case 32:
											if (readOnlyList2 == null)
											{
												num5 = 35;
												continue;
											}
											goto case 3;
										case 10:
											delay = sFdmXUxYyoXWv3ZJ7b7.IRRx8WR0wL(_response_5__3, delay);
											num5 = 27;
											continue;
										case 12:
											if ((_u__).IsCompleted)
											{
												num5 = 56;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
												{
													num5 = 15;
												}
												continue;
											}
											goto case 58;
										case 20:
											if (num8 != 2)
											{
												num5 = 77;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
												{
													num5 = 23;
												}
												continue;
											}
											goto case 8;
										case 46:
											_u__ = val;
											num5 = 30;
											continue;
										case 4:
										case 48:
										case 57:
										case 59:
											__7__wrap4 = 0;
											num5 = 45;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
											{
												num5 = 34;
											}
											continue;
										case 5:
											_retryCount_5__2 = 0;
											num5 = 59;
											continue;
										case 30:
											if (!(_u__).IsCompleted)
											{
												num5 = 36;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
												{
													num5 = 11;
												}
												continue;
											}
											goto case 60;
										case 17:
											if (!(_u__).IsCompleted)
											{
												num5 = 14;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
												{
													num5 = 47;
												}
												continue;
											}
											goto case 1;
										case 34:
											break;
										case 56:
											_ = sFdmXUxYyoXWv3ZJ7b7.CVxx7dDmvr;
											val = (cancellationToken).ConfigureAwait(false);
											_ = 43;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
											{
												_ = 72;
											}
											continue;
										case 18:
											num4 = (__1__state = -1);
											num5 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
											{
												num5 = 67;
											}
											continue;
										case 0:
											try
											{
												int num9;
												if (num4 != 0)
												{
													num9 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
													{
														num9 = 9;
													}
													goto IL_04ee;
												}
												goto IL_056c;
												IL_04ea:
												num9 = num10;
												goto IL_04ee;
												IL_04e6:
												int num11;
												num10 = num11;
												goto IL_04ea;
												IL_04ee:
												while (true)
												{
													switch (num9)
													{
													case 9:
														return;
													case 7:
														goto end_IL_04ee;
													case 2:
													case 10:
														response_5__ = (HttpResponseMessage)(object)(&_u__2);
														num9 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
														{
															num9 = 8;
														}
														continue;
													case 6:
														_ = send;
														_ = cancellationToken;
														val4 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
														_ = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
														{
															_ = 8;
														}
														continue;
													case 11:
														num4 = (__1__state = 0);
														num9 = 3;
														continue;
													case 1:
														num4 = (__1__state = -1);
														num9 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
														{
															num9 = 2;
														}
														continue;
													case 0:
														_response_5__3 = response_5__;
														num9 = 12;
														continue;
													case 3:
														goto IL_0648;
													case 5:
														__u__1 = default;
														num9 = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
														{
															num9 = 1;
														}
														continue;
													case 8:
														_u__2 = val4;
														num9 = 4;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
														{
															num9 = 16;
														}
														continue;
													case 4:
														if (&_u__2 != null)
														{
															num9 = 10;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
															{
																num9 = 10;
															}
															continue;
														}
														goto case 11;
													case 12:
														goto end_IL_04b6;
													}
													if (num10 == 20)
													{
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _SendAsync_d__12_1>(ref _u__2, ref this);
														num9 = 9;
														continue;
													}
													goto IL_0535;
													continue;
													end_IL_04ee:
													break;
												}
												goto IL_056c;
												IL_0535:
												if (num10 == 1000)
												{
													goto IL_04ea;
												}
												goto IL_0648;
												IL_0648:
												__u__1 = _u__2;
												num11 = 20;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
												{
													num11 = 20;
												}
												goto IL_04e6;
												IL_056c:
												_u__2 = __u__1;
												num11 = 5;
												goto IL_04e6;
												end_IL_04b6:;
											}
											catch (object obj) when (((Func<bool>)delegate
											{
												// Could not convert BlockContainer to single expression
												if (!(obj is OperationCanceledException))
												{
													num12 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
													{
														num12 = 1;
													}
												}
												else
												{
													num12 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
													{
														num12 = 0;
													}
												}
												while (true)
												{
													switch (num12)
													{
													default:
														if (num13 == 989)
														{
															goto IL_0728;
														}
														goto case 1;
													case 1:
														result = 0;
														break;
													case 0:
														result = ((cancellationToken).IsCancellationRequested ? 1 : 0);
														break;
													}
													break;
													IL_0728:
													num12 = num13;
												}
												return (byte)result != 0;
											}).Invoke())
											{
												int num14 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
												{
													num14 = 4;
												}
												while (true)
												{
													switch (num14)
													{
													default:
														if (num15 == 988)
														{
															goto IL_07b5;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_07b5:
													num14 = num15;
												}
												throw new global::System.Exception();
											}
											catch (OperationCanceledException ex3)
											{
												OperationCanceledException _7__wrap = ex3;
												int num16 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
												{
													num16 = 7;
												}
												while (true)
												{
													switch (num16)
													{
													default:
														if (num17 == 990)
														{
															num16 = num17;
															continue;
														}
														break;
													case 1:
														__7__wrap3 = _7__wrap;
														num16 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
														{
															num16 = 7;
														}
														continue;
													case 2:
														__7__wrap4 = 1;
														num16 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
														{
															num16 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											catch (HttpRequestException ex4)
											{
												HttpRequestException _7__wrap2 = ex4;
												int num18 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
												{
													num18 = 1;
												}
												while (true)
												{
													switch (num18)
													{
													default:
														if (num19 == 990)
														{
															num18 = num19;
															continue;
														}
														goto case 1;
													case 1:
														__7__wrap3 = _7__wrap2;
														num18 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
														{
															num18 = 1;
														}
														continue;
													case 0:
														__7__wrap4 = 2;
														num18 = 2;
														continue;
													case 2:
														break;
													}
													break;
												}
											}
											goto case 44;
										case 13:
											__u__2 = default;
											num5 = 42;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
											{
												num5 = 40;
											}
											continue;
										case 7:
											string.Concat(operationName, "网络失败，重试后仍未恢复");
											throw (ex).StatusCode;
										case 39:
											num8 = _retryCount_5__2;
											num5 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
											{
												num5 = 0;
											}
											continue;
										case 54:
											System.ArgumentException.ThrowIfNullOrWhiteSpace(operationName, "operationName");
											num5 = 53;
											continue;
										case 60:
											(_u__).GetResult();
											num5 = 48;
											continue;
										case 36:
											num4 = (__1__state = 2);
											num5 = 69;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
											{
												num5 = 68;
											}
											continue;
										case 1:
											(_u__).GetResult();
											num5 = 37;
											continue;
										case 11:
											goto end_IL_00eb;
										case 65:
											num8 = _retryCount_5__2;
											num5 = 22;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
											{
												num5 = 57;
											}
											continue;
										case 58:
											num4 = (__1__state = 1);
											num5 = 43;
											continue;
										case 26:
											__t__builder.AwaitUnsafeOnCompleted<object, _SendAsync_d__12_1>(ref _u__, ref this);
											num5 = 9;
											continue;
										case 70:
											__u__2 = _u__;
											num5 = 50;
											continue;
										case 40:
											num4 = (__1__state = -1);
											num5 = 51;
											continue;
										case 50:
											__t__builder.AwaitUnsafeOnCompleted<object, _SendAsync_d__12_1>(ref _u__, ref this);
											num5 = 45;
											continue;
										case 3:
											if (je6xyXFWy1(readOnlyList2, _retryCount_5__2, out delay))
											{
												num5 = 2;
												continue;
											}
											goto case 24;
										case 67:
										{
											if (je6xyXFWy1(sFdmXUxYyoXWv3ZJ7b7.bNuxUXvQXc, _retryCount_5__2, out var _))
											{
												num5 = 6;
												continue;
											}
											goto case 61;
										}
										case 33:
											num4 = (__1__state = -1);
											num5 = 60;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
											{
												num5 = 66;
											}
											continue;
										case 42:
											goto IL_0bc4;
										case 52:
											ex2 = (OperationCanceledException)__7__wrap3;
											num7 = 67;
											goto IL_0114;
										case 43:
											__u__2 = _u__;
											num7 = 80;
											goto IL_0114;
										case 23:
										case 38:
											__7__wrap3 = null;
											num5 = 19;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
											{
												num5 = 29;
											}
											continue;
										case 49:
											_u__ = val;
											num5 = 12;
											continue;
										case 14:
											_retryCount_5__2 = num8 + 1;
											num5 = 71;
											continue;
										case 64:
											readOnlyList = sFdmXUxYyoXWv3ZJ7b7.lUVx0TRQIn((ex).StatusCode);
											goto IL_0fe6;
										case 37:
											_response_5__3 = null;
											num5 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
											{
												num5 = 10;
											}
											continue;
										case 63:
											goto IL_0cc4;
										case 29:
											readOnlyList2 = sFdmXUxYyoXWv3ZJ7b7.lUVx0TRQIn((_response_5__3).StatusCode);
											num7 = 32;
											goto IL_0114;
										case 61:
											string.Concat(operationName, "超时，重试后仍未恢复");
											throw ex2;
										case 6:
											num8 = _retryCount_5__2;
											num5 = 41;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
											{
												num5 = 13;
											}
											continue;
										case 69:
											val2 = (ex).StatusCode;
											num5 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
											{
												num5 = 31;
											}
											continue;
										case 16:
											_ = sFdmXUxYyoXWv3ZJ7b7.CVxx7dDmvr;
											val = (cancellationToken).ConfigureAwait(false);
											_ = 49;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
											{
												_ = 45;
											}
											continue;
										case 68:
											__u__2 = _u__;
											num5 = 26;
											continue;
										case 22:
											_retryCount_5__2 = num8 + 1;
											num7 = 56;
											goto IL_0114;
										case 8:
											ex = (HttpRequestException)__7__wrap3;
											num5 = 69;
											continue;
										case 31:
											if (&val2 == null)
											{
												num5 = 48;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
												{
													num5 = 28;
												}
												continue;
											}
											goto case 64;
										case 47:
											num4 = (__1__state = 3);
											num5 = 70;
											continue;
										case 15:
										case 51:
											(_u__).GetResult();
											num5 = 57;
											continue;
										case 25:
											__u__2 = default;
											num5 = 18;
											continue;
										case 66:
											__u__2 = default;
											num7 = 33;
											goto IL_0114;
										case 41:
											_retryCount_5__2 = num8 + 1;
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
											{
												num5 = 16;
											}
											continue;
										case 2:
										case 19:
											if ((int)(_response_5__3).StatusCode == 429)
											{
												num5 = 10;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
												{
													num5 = 44;
												}
												continue;
											}
											goto case 27;
										case 71:
											_ = sFdmXUxYyoXWv3ZJ7b7.CVxx7dDmvr;
											val = (cancellationToken).ConfigureAwait(false);
											_ = 46;
											continue;
										case 55:
											goto IL_0f59;
										case 44:
											num8 = __7__wrap4;
											num5 = 12;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
											{
												num5 = 21;
											}
											continue;
										case 24:
										case 35:
										{
											HttpResponseMessage val3 = _response_5__3;
											num7 = 11;
											goto IL_0114;
										}
										case 53:
											System.ArgumentNullException.ThrowIfNull(send, "send");
											num5 = 5;
											continue;
										case 28:
											{
												readOnlyList = sFdmXUxYyoXWv3ZJ7b7.l7lxr0GFXO;
												goto IL_0fe6;
											}
											IL_0114:
											num6 = num7;
											goto IL_0118;
											IL_0fe6:
											if (readOnlyList == null)
											{
												(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((__7__wrap3 as global::System.Exception) ?? throw __7__wrap3)).Throw();
											}
											if (je6xyXFWy1(readOnlyList, _retryCount_5__2, out delay2))
											{
												num5 = 39;
												continue;
											}
											goto case 7;
											IL_0118:
											num5 = num6;
											continue;
										}
										break;
									}
									goto case 0;
									IL_0f59:
									_u__ = __u__2;
									num5 = 13;
									goto IL_011c;
									IL_0cc4:
									_u__ = __u__2;
									num5 = 25;
									goto IL_011c;
									IL_0bc4:
									_u__ = __u__2;
									num5 = 68;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num5 = 66;
									}
									goto IL_011c;
									end_IL_00eb:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num20 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									num20 = 5;
								}
								while (true)
								{
									switch (num20)
									{
									case 2:
										return;
									default:
										if (num21 == 990)
										{
											num20 = num21;
											break;
										}
										goto case 0;
									case 0:
										__1__state = -2;
										num20 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
										{
											num20 = 1;
										}
										break;
									case 1:
										_ = __t__builder;
										_ = 2;
										break;
									}
								}
							}
							break;
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
				__1__state = -2;
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			while (true)
			{
				while (true)
				{
					switch (num)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_ = __t__builder;
					_ = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
					{
						_ = 1;
					}
				}
			}
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
						case 0:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							break;
						case 1:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool CDfMPD9IZcvk18ohQKvW()
		{
			return aDJG6Q9IjrBfGNgqFqZG == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object rwQGxu9I9ychK0ZrHWeO()
		{
			return aDJG6Q9IjrBfGNgqFqZG;
		}
	}

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> in8xJntmhi;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> RLcxQY2Bym;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> axcxCkwuwy;

	private static readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> yt2x4jXKg3;

	private static readonly TimeSpan wgbxhl8GA9;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> bNuxUXvQXc;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> l7lxr0GFXO;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> lLhxoRfGEV;

	private readonly global::System.Collections.Generic.IReadOnlyList<TimeSpan> q9xxmeweBc;

	private readonly Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task> CVxx7dDmvr;

	private readonly Func<DateTimeOffset> oh0xAkR524;

	internal static object UNlIJ6Z4LEfF16u8Cr9G;

	[MethodImpl((MethodImplOptions)8)]
	internal sFdmXUxYyoXWv3ZJ7b6(global::System.Collections.Generic.IReadOnlyList<TimeSpan>? timeoutDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? networkDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? rateLimitDelays = null, global::System.Collections.Generic.IReadOnlyList<TimeSpan>? serverErrorDelays = null, Func<TimeSpan, CancellationToken, global::System.Threading.Tasks.Task>? delay = null, Func<DateTimeOffset>? clock = null)
	{
		bNuxUXvQXc = XpVxWANTYR(timeoutDelays ?? in8xJntmhi, "timeoutDelays");
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<HttpResponseMessage> KZ4xclyooM(string operationName, Func<CancellationToken, global::System.Threading.Tasks.Task<HttpResponseMessage>> send, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.send = send;
		_ = 13;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6;
		_ = 5;
		obj.__4__this = this;
		_ = 4;
		_ = obj;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private global::System.Collections.Generic.IReadOnlyList<TimeSpan>? lUVx0TRQIn(HttpStatusCode? statusCode)
	{
		//IL_0009: Expected O, but got I4
		object obj = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private TimeSpan IRRx8WR0wL(HttpResponseMessage response, TimeSpan fallback)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		object obj = ((response).Headers).RetryAfter;
		return default(TimeSpan);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool je6xyXFWy1(global::System.Collections.Generic.IReadOnlyList<TimeSpan> delays, int retryCount, out TimeSpan delay)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Collections.Generic.IReadOnlyList<TimeSpan> XpVxWANTYR(global::System.Collections.Generic.IReadOnlyList<TimeSpan> delays, object parameterName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		wgbxhl8GA9 = System.TimeSpan.FromSeconds(30.0);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool nvRPnMZ4jGOhMj84dBkT()
	{
		return UNlIJ6Z4LEfF16u8Cr9G == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static sFdmXUxYyoXWv3ZJ7b6 ihZ4aBZ4ZZf8o7od00aD()
	{
		return (sFdmXUxYyoXWv3ZJ7b6)UNlIJ6Z4LEfF16u8Cr9G;
	}
}

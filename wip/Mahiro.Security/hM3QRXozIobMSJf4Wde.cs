using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using URYDCfoED4sjjHBaoJH;
using fDAldojjppXrctUVYOJn;

namespace iFG88Vmb1p0qPpvwBpT;

internal class hM3QRXozIobMSJf4Wde
{
	private struct RiGLXof2jefOtdlyMSlx
	{
		public uint lIYf2Zgm8RI;

		public uint xOef29X6laC;

		public uint JUcf2DiJ2Kf;

		public uint Ursf2k1ZOwf;

		public ulong GkRf2V7V75Q;

		public uint hcof2Y31pwJ;

		public uint hGOf2SRakKP;
	}

	internal struct ltxoruf2ci5IIim8Kb7L
	{
		public uint pTTf20i1mBf;

		public uint zwTf28d6Y8A;

		public uint vuMf2ykXgfa;

		public uint Twef2WV8VLy;

		public ulong C2Jf2JYFNE4;

		public uint Vgmf2QCLK8A;

		public uint vgSf2CPJ9G7;

		public ulong nbff243SFxv;

		public uint TCLf2hXG36T;

		public uint wQ1f2Uh4fTM;
	}

	private delegate uint AYe7nEf2r367qxVm5oOI(ref RiGLXof2jefOtdlyMSlx request, ref ltxoruf2ci5IIim8Kb7L result);

	private delegate uint q1jviEf2oWA9c9d78Lkk(ulong id, ref ltxoruf2ci5IIim8Kb7L result, [Out] byte[]? bytes, uint capacity);

	private delegate uint z14U0sf2mJ1hqx8bw5Cj(ulong id);

	private delegate uint G6IULff27XOX7ZIMV0U1([Out] byte[] nonce, uint count);

	private delegate uint KxTwMAf2APwb8KIhmrr3([In] byte[] bytes, uint count);

	[CompilerGenerated]
	private sealed class __c__DisplayClass22_0_4
	{
		public z14U0sf2mJ1hqx8bw5Cj cancel;

		public ulong id;

		internal static __c__DisplayClass22_0_4 tiPLt294SqjLlaD1UY52;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass22_0_4()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void gKIf2IFc73S()
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
					cancel(id);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
					{
						num2 = 0;
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
							switch (num2)
							{
							case 990:
								goto end_IL_0012;
							case 9:
								return;
							}
							goto end_IL_000e;
						case 0:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							goto end_IL_000e;
						case 1:
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
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
		internal static bool ULBXYi94ceUuEhkoqOVT()
		{
			return tiPLt294SqjLlaD1UY52 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass22_0_4 jFC9ew940q2T7GO2IW3L()
		{
			return tiPLt294SqjLlaD1UY52;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ExecuteAsync_d__22 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<ValueTuple<ltxoruf2ci5IIim8Kb7L, byte[]>> __t__builder;

		public CancellationToken cancellationToken;

		public object input;

		public uint kind;

		private __c__DisplayClass22_0_4 __8__1;

		private q1jviEf2oWA9c9d78Lkk _query_5__2;

		private z14U0sf2mJ1hqx8bw5Cj _release_5__3;

		private CancellationTokenRegistration _cancellation_5__4;

		private Stopwatch _timeout_5__5;

		private object __u__1;

		private static object yC4qQg948qdxSIC5RODp;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0e9f: Ignored invalid 'constrained' prefix
			//IL_0f4d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Expected O, but got I
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_0860: Unknown result type (might be due to invalid IL or missing references)
			//IL_0865: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a73: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a44: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eba->IL0e79: Incompatible stack heights: 2 vs 1
			//IL_0ec5->IL0e79: Incompatible stack heights: 2 vs 1
			//IL_0f47->IL0ee4: Incompatible stack heights: 3 vs 1
			//IL_009e->IL0008: Incompatible stack heights: 3 vs 1
			//IL_00a9->IL0008: Incompatible stack heights: 3 vs 1
			//IL_023f->IL011b: Incompatible stack heights: 2 vs 1
			//IL_024a->IL011b: Incompatible stack heights: 2 vs 1
			//IL_0a50->IL07b5: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			int num22 = default;
			ltxoruf2ci5IIim8Kb7L result = default;
			GCHandle val3 = default;
			byte[] array2 = default;
			bool flag = default;
			int num20 = default;
			int num26 = default;
			RiGLXof2jefOtdlyMSlx request = default;
			AYe7nEf2r367qxVm5oOI aYe7nEf2r367qxVm5oOI = default;
			int num28 = default;
			int num7 = default;
			object _u__ = default;
			int num15 = default;
			uint num10 = default;
			byte[] array = default;
			ConfiguredTaskAwaitable val = default;
			string detail = default;
			int num12 = default;
			int num14 = default;
			int num17 = default;
			int num19 = default;
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
							if (num2 != 14)
							{
								if (num2 == 995)
								{
									goto end_IL_0010;
								}
								goto case 6;
							}
							return;
						case 3:
							_cancellation_5__4 = default;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
							{
								num3 = 11;
							}
							continue;
						case 2:
							_ = __t__builder;
							_ = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								_ = 14;
							}
							break;
						case 4:
							__1__state = -2;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num3 = 7;
							}
							continue;
						case 5:
							__8__1 = null;
							num3 = 7;
							continue;
						case 0:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num5 = 8;
									}
									goto IL_011b;
								}
								goto IL_024a;
								IL_011b:
								while (true)
								{
									int num21;
									switch (num5)
									{
									default:
										if (num22 == 31)
										{
											goto IL_0615;
										}
										if (num22 == 1011)
										{
											goto IL_0117;
										}
										goto case 17;
									case 0:
										__8__1 = (__c__DisplayClass22_0_4)new __c__DisplayClass22_0_4();
										num5 = 22;
										continue;
									case 4:
										if (__8__1.id != 0L)
										{
											num5 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
											{
												num5 = 29;
											}
											continue;
										}
										goto case 18;
									case 18:
										throw new global::System.Exception("原生游戏操作 ABI 不兼容。");
									case 1:
										break;
									case 21:
										__8__1.id = result.C2Jf2JYFNE4;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
										{
											num5 = 4;
										}
										continue;
									case 14:
										__8__1.cancel = GiUmXMdHhw<z14U0sf2mJ1hqx8bw5Cj>("chronal_cancel_game_operation");
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
										{
											num5 = 31;
										}
										continue;
									case 13:
										val3 = System.Runtime.InteropServices.GCHandle.Alloc(array2, (GCHandleType)3);
										num5 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
										{
											num5 = 23;
										}
										continue;
									case 20:
										_query_5__2 = GiUmXMdHhw<q1jviEf2oWA9c9d78Lkk>("chronal_query_game_operation");
										num5 = 14;
										continue;
									case 2:
									case 9:
										if (!flag)
										{
											num5 = 3;
											continue;
										}
										goto case 6;
									case 8:
										_release_5__3 = GiUmXMdHhw<z14U0sf2mJ1hqx8bw5Cj>("chronal_release_game_operation");
										num5 = 13;
										continue;
									case 23:
										result = nXVmfbluvM();
										num21 = 11;
										goto IL_0113;
									case 12:
										if (num20 == 0)
										{
											num21 = 31;
											goto IL_0113;
										}
										goto case 17;
									case 19:
										if (num20 <= 16777216)
										{
											num21 = 12;
											goto IL_0113;
										}
										goto IL_0615;
									case 11:
										try
										{
											RiGLXof2jefOtdlyMSlx riGLXof2jefOtdlyMSlx = default;
											int num23 = 6;
											while (true)
											{
												switch (num23)
												{
												default:
													switch (num26)
													{
													case 994:
														break;
													default:
														goto end_IL_03f7;
													case 14:
														request = riGLXof2jefOtdlyMSlx;
														num23 = 3;
														continue;
													}
													goto IL_03f3;
												case 4:
													riGLXof2jefOtdlyMSlx.JUcf2DiJ2Kf = kind;
													num23 = 5;
													continue;
												case 1:
												{
													riGLXof2jefOtdlyMSlx.hcof2Y31pwJ = checked((uint)array2.Length);
													int num25 = 14;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
													{
														num25 = 6;
													}
													num26 = num25;
													goto IL_03f3;
												}
												case 2:
													riGLXof2jefOtdlyMSlx.xOef29X6laC = 3u;
													num23 = 11;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
													{
														num23 = 4;
													}
													continue;
												case 6:
													riGLXof2jefOtdlyMSlx.lIYf2Zgm8RI = (uint)Marshal.SizeOf<RiGLXof2jefOtdlyMSlx>();
													num23 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
													{
														num23 = 2;
													}
													continue;
												case 3:
													hT5mLskXai(aYe7nEf2r367qxVm5oOI(ref request, ref result), result.vgSf2CPJ9G7);
													num23 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
													{
														num23 = 1;
													}
													continue;
												case 5:
												{
													nint num24 = (val3).AddrOfPinnedObject();
													riGLXof2jefOtdlyMSlx.GkRf2V7V75Q = (ulong)(num24).ToInt64();
													num23 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
													{
														num23 = 1;
													}
													continue;
												}
												case 0:
													break;
													IL_03f3:
													num23 = num26;
													continue;
													end_IL_03f7:
													break;
												}
												break;
											}
										}
										finally
										{
											if (num4 < 0)
											{
												int num27 = 2;
												while (true)
												{
													switch (num27)
													{
													default:
														if (num28 == 990)
														{
															num27 = num28;
															continue;
														}
														break;
													case 0:
														System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array2);
														num27 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
														{
															num27 = 1;
														}
														continue;
													case 2:
														(val3).Free();
														num27 = 4;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
														{
															num27 = 0;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 21;
									case 22:
										(cancellationToken).ThrowIfCancellationRequested();
										num5 = 10;
										continue;
									case 6:
										throw new global::System.Exception("原生游戏请求长度无效。");
									case 3:
										aYe7nEf2r367qxVm5oOI = GiUmXMdHhw<AYe7nEf2r367qxVm5oOI>("chronal_begin_game_operation");
										num5 = 20;
										continue;
									case 10:
										array2 = JsonSerializer.SerializeToUtf8Bytes<object>(input, jsNmWAkao7);
										num5 = 16;
										continue;
									case 15:
										if (result.zwTf28d6Y8A == 3)
										{
											num5 = 7;
											continue;
										}
										goto case 18;
									case 17:
										flag = false;
										num5 = 2;
										continue;
									case 7:
										if (result.pTTf20i1mBf == Marshal.SizeOf<ltxoruf2ci5IIim8Kb7L>())
										{
											global::System.Runtime.CompilerServices.Unsafe.As<CancellationToken, _ExecuteAsync_d__22>(ref cancellationToken)._cancellation_5__4 = (*(CancellationToken*)__8__1).Register((Action)(object)__ldftn(__c__DisplayClass22_0_4.gKIf2IFc73S));
											_ = 26;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
											{
												_ = 1;
											}
										}
										else
										{
											num5 = 18;
										}
										continue;
									case 16:
										num20 = array2.Length;
										num21 = 19;
										goto IL_0113;
									case 5:
										{
											try
											{
												int num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
												{
													num6 = 4;
												}
												while (true)
												{
													switch (num6)
													{
													default:
														if (num7 == 989)
														{
															num6 = num7;
															continue;
														}
														break;
													case 1:
														num6 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
														{
															num6 = 2;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
												try
												{
													int num8;
													if (num4 != 0)
													{
														num8 = 18;
														goto IL_07b5;
													}
													goto IL_085f;
													IL_085f:
													_u__ = __u__1;
													int num9 = 8;
													goto IL_07ad;
													IL_07b5:
													while (true)
													{
														switch (num8)
														{
														case 30:
															return;
														default:
															if (num15 != 40)
															{
																if (num15 == 1020)
																{
																	goto IL_07b1;
																}
																goto case 10;
															}
															num10 = _query_5__2(__8__1.id, ref result, null, 0u);
															num8 = 32;
															continue;
														case 25:
															break;
														case 2:
															goto IL_0871;
														case 21:
															hT5mLskXai(num10);
															num8 = 36;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
															{
																num8 = 0;
															}
															continue;
														case 3:
															array = new byte[checked((int)result.wQ1f2Uh4fTM)];
															num8 = 9;
															continue;
														case 13:
														case 29:
															goto IL_08cc;
														case 17:
															_u__ = val;
															num8 = 12;
															continue;
														case 23:
															throw new global::System.Exception("原生游戏响应超长。");
														case 12:
															if ((_u__).IsCompleted)
															{
																num8 = 6;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																{
																	num8 = 22;
																}
																continue;
															}
															goto case 4;
														case 24:
															(cancellationToken).ThrowIfCancellationRequested();
															num8 = 27;
															continue;
														case 9:
															hT5mLskXai(_query_5__2(__8__1.id, ref result, array, (uint)array.Length));
															num8 = 6;
															continue;
														case 7:
															goto end_IL_0792;
														case 22:
														case 31:
															(_u__).GetResult();
															num8 = 29;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
															{
																num8 = 13;
															}
															continue;
														case 15:
															throw new global::System.Exception("原生游戏操作超时；不会自动重放。");
														case 10:
															throw new HeOiCXovnuVhGHyE2EO(result.vuMf2ykXgfa, result.vgSf2CPJ9G7, 0u, detail);
														case 26:
															__t__builder.AwaitUnsafeOnCompleted<object, _ExecuteAsync_d__22>(ref _u__, ref this);
															num8 = 30;
															continue;
														case 28:
															goto IL_0a68;
														case 20:
															__u__1 = _u__;
															num8 = 17;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
															{
																num8 = 26;
															}
															continue;
														case 1:
															if (num10 != 8201)
															{
																num8 = 21;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
																{
																	num8 = 18;
																}
																continue;
															}
															goto case 0;
														case 27:
															array = global::System.Array.Empty<byte>();
															num8 = 37;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
															{
																num8 = 2;
															}
															continue;
														case 19:
															if (array.Length != 0)
															{
																num8 = 7;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
																{
																	num8 = 14;
																}
																continue;
															}
															goto case 10;
														case 18:
															goto IL_0ba2;
														case 11:
															__8__1.cancel(__8__1.id);
															num8 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
															{
																num8 = 15;
															}
															continue;
														case 0:
															if (result.Twef2WV8VLy == 2)
															{
																num8 = 24;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
																{
																	num8 = 37;
																}
																continue;
															}
															goto IL_0a68;
														case 14:
															try
															{
																detail = (System.Text.Encoding.UTF8).GetString(array);
																int num11 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
																{
																	num11 = 5;
																}
																while (true)
																{
																	switch (num11)
																	{
																	default:
																		if (num12 == 988)
																		{
																			num11 = num12;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															catch (DecoderFallbackException)
															{
																int num13 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																{
																	num13 = 0;
																}
																while (true)
																{
																	switch (num13)
																	{
																	default:
																		if (num14 == 988)
																		{
																			num13 = num14;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															goto case 10;
														case 5:
															num4 = (__1__state = -1);
															num8 = 32;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
															{
																num8 = 31;
															}
															continue;
														case 6:
															goto IL_0d38;
														case 32:
															if (num10 != 0)
															{
																num8 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
																{
																	num8 = 23;
																}
																continue;
															}
															goto case 0;
														case 8:
															__u__1 = default;
															num8 = 5;
															continue;
														case 16:
															detail = null;
															num8 = 19;
															continue;
														case 4:
															num4 = (__1__state = 0);
															num8 = 20;
															continue;
														}
														break;
														IL_0a68:
														if (!((_timeout_5__5).Elapsed > System.TimeSpan.FromMinutes(5.0)))
														{
															val = (System.Threading.Tasks.Task.Delay(25)).ConfigureAwait(false);
															num8 = 39;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
															{
																num8 = 17;
															}
														}
														else
														{
															num8 = 16;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
															{
																num8 = 11;
															}
														}
														continue;
														IL_0d38:
														if (result.vuMf2ykXgfa == 0)
														{
															ValueTuple<ltxoruf2ci5IIim8Kb7L, byte[]> val2 = (ValueTuple<ltxoruf2ci5IIim8Kb7L, byte[]>)array;
															_ = 7;
														}
														else
														{
															num8 = 16;
														}
														continue;
														IL_0871:
														if (result.wQ1f2Uh4fTM > 4194304)
														{
															num8 = 23;
															continue;
														}
														if (result.wQ1f2Uh4fTM != 0)
														{
															num8 = 3;
															continue;
														}
														goto IL_0d38;
													}
													goto IL_085f;
													IL_07b1:
													num8 = num15;
													goto IL_07b5;
													IL_07ad:
													num15 = num9;
													goto IL_07b1;
													IL_0ba2:
													_timeout_5__5 = System.Diagnostics.Stopwatch.StartNew();
													num9 = 29;
													goto IL_07ad;
													IL_08cc:
													result = nXVmfbluvM();
													num9 = 40;
													goto IL_07ad;
													end_IL_0792:;
												}
												finally
												{
													if (num4 < 0)
													{
														int num16 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
														{
															num16 = 7;
														}
														while (true)
														{
															switch (num16)
															{
															default:
																if (num17 == 989)
																{
																	num16 = num17;
																	continue;
																}
																break;
															case 1:
																_release_5__3(__8__1.id);
																num16 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
																{
																	num16 = 6;
																}
																continue;
															case 0:
																break;
															}
															break;
														}
													}
												}
											}
											finally
											{
												if (num4 < 0)
												{
													int num18 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
													{
														num18 = 7;
													}
													while (true)
													{
														switch (num18)
														{
														default:
															if (num19 == 989)
															{
																num18 = num19;
																continue;
															}
															break;
														case 1:
															break;
														case 0:
															goto end_IL_0e79;
														}
														_ = _cancellation_5__4;
														_ = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
														{
															_ = 5;
														}
														continue;
														end_IL_0e79:
														break;
													}
												}
											}
											goto end_IL_011b;
										}
										IL_0615:
										flag = true;
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
										{
											num5 = 9;
										}
										continue;
										IL_0117:
										num5 = num22;
										continue;
										IL_0113:
										num22 = num21;
										goto IL_0117;
									}
									goto IL_024a;
									continue;
									end_IL_011b:
									break;
								}
								goto end_IL_00e3;
								IL_024a:
								num5 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
								{
									num5 = 5;
								}
								goto IL_011b;
								end_IL_00e3:;
							}
							catch (global::System.Exception)
							{
								int num29 = 3;
								while (true)
								{
									int num30 = num29;
									while (true)
									{
										int num31 = num30;
										while (true)
										{
											switch (num31)
											{
											case 5:
												return;
											default:
												if (num30 != 13)
												{
													if (num30 == 993)
													{
														goto end_IL_0ee4;
													}
													goto case 4;
												}
												_release_5__3 = null;
												num31 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
												{
													num31 = 7;
												}
												continue;
											case 3:
												__1__state = -2;
												num31 = 4;
												continue;
											case 1:
												_ = __t__builder;
												_ = 5;
												continue;
											case 0:
												_cancellation_5__4 = default;
												num31 = 1;
												continue;
											case 4:
												__8__1 = null;
												num31 = 2;
												continue;
											case 2:
												break;
											}
											goto end_IL_0ee0;
											continue;
											end_IL_0ee4:
											break;
										}
										continue;
										end_IL_0ee0:
										break;
									}
									_query_5__2 = null;
									num29 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
									{
										num29 = 13;
									}
								}
							}
							goto case 4;
						case 6:
							_release_5__3 = null;
							num3 = 3;
							continue;
						case 1:
							num4 = __1__state;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
							{
								num3 = 3;
							}
							continue;
						case 7:
							_query_5__2 = null;
							num = 6;
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
						case 2:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						case 1:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								num3 = 0;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aqUAfm94yntH3isGSKeS()
		{
			return yC4qQg948qdxSIC5RODp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object wWM2ne94W47VixVMtpSN()
		{
			return yC4qQg948qdxSIC5RODp;
		}
	}

	private static readonly JsonSerializerOptions jsNmWAkao7;

	internal static object HRccAmZ8ypaoGmhv4HSu;

	[MethodImpl((MethodImplOptions)8)]
	private static extern T GiUmXMdHhw<T>(object name) where T : global::System.Delegate;

	[MethodImpl((MethodImplOptions)8)]
	private static ltxoruf2ci5IIim8Kb7L nXVmfbluvM()
	{
		return default(ltxoruf2ci5IIim8Kb7L);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void hT5mLskXai(uint status, uint windowsError = 0u)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0055->IL0010: Incompatible stack types: I4 vs O
		//IL_0060->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 989)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					throw new HeOiCXovnuVhGHyE2EO(status, windowsError, 0u, (string?)null);
				case 1:
					if (status == 0)
					{
						return;
					}
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
					{
						obj2 = 0;
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
	internal static byte[] Wq5mj4MTxT()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void q7xmZ1tmwC(object transcript, object signature)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<ValueTuple<ltxoruf2ci5IIim8Kb7L, byte[]>> ExecuteAsync(uint kind, object input, CancellationToken cancellationToken)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static Process pPwm9ooQjF(ltxoruf2ci5IIim8Kb7L result)
	{
		//IL_000c: Expected O, but got I4
		//IL_0045: Expected I4, but got O
		//IL_006e: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_02a2: Expected O, but got I4
		//IL_018e: Expected O, but got I4
		//IL_01a7: Expected I4, but got O
		//IL_0082->IL0010: Incompatible stack types: I4 vs O
		//IL_017d->IL0192: Incompatible stack types: I4 vs O
		//IL_029f->IL0010: Incompatible stack types: I4 vs O
		//IL_02b6->IL0010: Incompatible stack types: I4 vs O
		//IL_0119->IL0010: Incompatible stack types: I4 vs O
		//IL_008d->IL0010: Incompatible stack types: I4 vs O
		//IL_0188->IL0192: Incompatible stack types: I4 vs O
		//IL_02c1->IL0010: Incompatible stack types: I4 vs O
		//IL_00b9->IL0010: Incompatible stack types: I4 vs O
		//IL_00c4->IL0010: Incompatible stack types: I4 vs O
		//IL_0103->IL0010: Incompatible stack types: I4 vs O
		//IL_0264->IL0192: Incompatible stack types: I4 vs O
		//IL_01e9->IL0192: Incompatible stack types: I4 vs O
		//IL_020b->IL0192: Incompatible stack types: I4 vs O
		//IL_026f->IL0192: Incompatible stack types: I4 vs O
		//IL_0216->IL0192: Incompatible stack types: I4 vs O
		int num = 1;
		object obj5 = default;
		object obj4 = default;
		object obj3 = default;
		object obj8 = default;
		object obj7 = default;
		object result2 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 18)
						{
							if ((nint)obj == 999)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						obj5 = System.Diagnostics.Process.GetProcessById((int)result.Vgmf2QCLK8A);
						obj2 = 2;
						continue;
					case 1:
						obj4 = result.Vgmf2QCLK8A;
						obj2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 3:
					case 11:
						if (obj3 == null)
						{
							num = 5;
							break;
						}
						goto case 8;
					case 9:
						if (obj4 == null)
						{
							obj2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
							{
								obj2 = 4;
							}
							continue;
						}
						goto case 4;
					case 8:
						throw new global::System.Exception("原生进程回执无效。");
					case 0:
						if ((nuint)(nint)obj4 > (nuint)2147483647u)
						{
							obj2 = 7;
							continue;
						}
						goto case 9;
					case 5:
						if (result.nbff243SFxv != 0L)
						{
							num = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num = 2;
							}
							break;
						}
						goto case 8;
					case 2:
					{
						(obj5).SafeHandle;
						object obj6 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
						{
							obj6 = 4;
						}
						while (true)
						{
							switch ((int)obj6)
							{
							default:
								if ((nint)obj8 != 11)
								{
									if ((nint)obj8 == 991)
									{
										goto IL_018e;
									}
									goto case 3;
								}
								obj7 = (*(global::System.DateTime*)(&obj7)).ToUniversalTime();
								obj6 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
								{
									obj6 = 1;
								}
								continue;
							case 1:
								if ((*(global::System.DateTime*)(&obj7)).ToFileTimeUtc() != (long)result.nbff243SFxv)
								{
									obj6 = 2;
									continue;
								}
								result2 = obj5;
								obj6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
								{
									obj6 = 0;
								}
								continue;
							case 3:
								obj7 = (obj5).StartTime;
								obj8 = 11;
								goto IL_018e;
							case 2:
								throw new global::System.Exception("游戏进程实例已发生变化。");
							case 0:
								break;
								IL_018e:
								obj6 = obj8;
								continue;
							}
							break;
						}
						goto case 10;
					}
					case 4:
						obj3 = 0;
						obj2 = 11;
						continue;
					case 6:
					case 7:
						obj3 = 1;
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							obj2 = 14;
						}
						continue;
					case 10:
						return (Process)result2;
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
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool DA4FECZ8WVRIoAPOHQ7H()
	{
		return HRccAmZ8ypaoGmhv4HSu == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hM3QRXozIobMSJf4Wde orknyvZ8JKIfhYgunTRN()
	{
		return (hM3QRXozIobMSJf4Wde)HRccAmZ8ypaoGmhv4HSu;
	}
}

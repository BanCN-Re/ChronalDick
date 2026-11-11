using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using AR0yDHKcbVJbe6i6hLY;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using D7xJjNfwCFnMZjlFZPVf;
using JvgQTDcbARdEdTAk7GE;
using dcvjfggjMhe2HpqDyUf;
using f6bfbCKDsBX36YTVKpd;
using fDAldojjppXrctUVYOJn;
using fIsVVndaX2MwgYmEEob;
using m133jJK4aGTkYCX9JA5;
using m5NLKNoWjf2r56bsRv4;

namespace EalDClKBE7R7DfsUjMd;

internal class eDTUdFKIG1IFKQgZTDp
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_147
	{
		public static __c_147 __9;

		public static TimerCallback __9__13_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset> __9__14_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, bool> __9__15_2;

		public static Func<vNIX0hKSxIjAmGCLN6M, bool> __9__15_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset> __9__15_1;

		private static __c_147 AZhpdd9rFtn9k1yNTPdQ;

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
							if (num2 == 11)
							{
								return;
							}
							goto IL_0039;
						case 0:
							goto end_IL_000e;
						case 1:
							num3 = 3;
							continue;
						case 2:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							break;
						}
						goto IL_00b8;
						IL_0039:
						if (num2 == 992)
						{
							break;
						}
						goto IL_00b8;
						IL_00b8:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 4;
					}
					continue;
					end_IL_000e:
					break;
				}
				__9 = (__c_147)new __c_147();
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_147()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void kbtfqOqR3be(object? _)
		{
			_ = U2mKd85i2c();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset bkkfq5BiqLC(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			return x.Event.LastSeenUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool YgNfq6FXINt(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset lastSeenUtc = x.Event.LastSeenUtc;
			DateTimeOffset val = System.DateTimeOffset.UtcNow;
			return (lastSeenUtc < (val).AddDays(-7.0));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool ru2fqRTJPbv(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (x.DueUtc <= System.DateTimeOffset.UtcNow);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset HEifqwh9CJi(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return x.DueUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string gaPfqeqHunC()
		{
			return (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes((((iOp8AQoyRMUnhQ3bGRu)new iOp8AQoyRMUnhQ3bGRu()).CreateMachineRequest().Hash).Trim())))).ToLowerInvariant();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OnVkGe9rsN2QhytRM2PB()
		{
			return AZhpdd9rFtn9k1yNTPdQ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_147 KIMYYe9rTErM0Gw1Fcek()
		{
			return AZhpdd9rFtn9k1yNTPdQ;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _FlushAsync_d__15 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		private vNIX0hKSxIjAmGCLN6M[] __7__wrap1;

		private int __7__wrap2;

		private vNIX0hKSxIjAmGCLN6M _entry_5__4;

		private int _retryAfterSeconds_5__5;

		private CancellationTokenSource _timeout_5__6;

		private ConfiguredTaskAwaitable<D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>>.ConfiguredTaskAwaiter __u__2;

		internal static object F7ls9Q9rNOwaKoOX3cEN;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_16a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_16b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b70: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b75: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Expected O, but got I
			//IL_058b: Expected O, but got I
			//IL_0453: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_10d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e1: Expected O, but got Unknown
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Expected O, but got I
			//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0607: Expected O, but got I
			//IL_0ad5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Expected O, but got I
			//IL_138f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1394: Unknown result type (might be due to invalid IL or missing references)
			//IL_1359: Unknown result type (might be due to invalid IL or missing references)
			//IL_135e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b2e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b3a: Unknown result type (might be due to invalid IL or missing references)
			//IL_092c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0932: Invalid comparison between Unknown and I4
			//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_08df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6d: Expected O, but got Ref
			//IL_0bd5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dd6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_174a->IL1520: Incompatible stack heights: 4 vs 1
			//IL_16f0->IL1755: Incompatible stack heights: 2 vs 0
			//IL_1755->IL1520: Incompatible stack heights: 4 vs 1
			//IL_1704->IL1520: Incompatible stack heights: 3 vs 1
			//IL_170f->IL1520: Incompatible stack heights: 3 vs 1
			//IL_0556->IL03fd: Incompatible stack heights: 2 vs 1
			//IL_05cc->IL05df: Incompatible stack heights: 2 vs 3
			//IL_058b->IL058b: Incompatible stack heights: 3 vs 2
			//IL_0268->IL00d3: Incompatible stack heights: 2 vs 1
			//IL_05f4->IL0607: Incompatible stack heights: 3 vs 4
			//IL_062d->IL03fd: Incompatible stack heights: 3 vs 1
			//IL_1219->IL1223: Incompatible stack heights: 1 vs 0
			//IL_0638->IL03fd: Incompatible stack heights: 3 vs 1
			//IL_1185->IL1185: Incompatible stack heights: 1 vs 0
			//IL_0b50->IL07ad: Incompatible stack heights: 2 vs 1
			//IL_0b5b->IL07ad: Incompatible stack heights: 2 vs 1
			//IL_0ce0->IL0c6d: Incompatible stack heights: 2 vs 1
			//IL_0d02->IL0c6d: Incompatible stack heights: 4 vs 1
			//IL_0d2c->IL0c6d: Incompatible stack heights: 4 vs 1
			//IL_0da5->IL0e62: Incompatible stack heights: 2 vs 0
			//IL_0c69->IL0c69: Incompatible stack heights: 2 vs 0
			int num = 1;
			int num4 = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _u__ = default;
			int num7 = default;
			ConfiguredTaskAwaitable<bool> val5 = default;
			int num10 = default;
			vNIX0hKSxIjAmGCLN6M[] _7__wrap = default;
			bool flag = default;
			object f91KKQC3Fo = default;
			int num48 = default;
			vNIX0hKSxIjAmGCLN6M vNIX0hKSxIjAmGCLN6M5 = default;
			int num40 = default;
			vNIX0hKSxIjAmGCLN6M[] array = default;
			int num51 = default;
			int num31 = default;
			ConfiguredTaskAwaitable<D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>>.ConfiguredTaskAwaiter _u__2 = default;
			int num28 = default;
			OtUqeAK9rXJ3eFJguIm otUqeAK9rXJ3eFJguIm = default;
			ConfiguredTaskAwaitable<D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>> val4 = default;
			JsonElement val3 = default;
			D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm> tZ40E3fwQFywClnXCq1A_ = default;
			JsonElement val2 = default;
			string accessToken = default;
			int num25 = default;
			vNIX0hKSxIjAmGCLN6M vNIX0hKSxIjAmGCLN6M = default;
			vNIX0hKSxIjAmGCLN6M pending = default;
			DateTimeOffset val = default;
			int num27 = default;
			int num30 = default;
			int num17 = default;
			v5OiSQSzC8GipXkQ3VG v5OiSQSzC8GipXkQ3VG = default;
			int num19 = default;
			int num13 = default;
			int num15 = default;
			int num46 = default;
			int num42 = default;
			int num43 = default;
			int num35 = default;
			vNIX0hKSxIjAmGCLN6M vNIX0hKSxIjAmGCLN6M3 = default;
			vNIX0hKSxIjAmGCLN6M pending2 = default;
			int num37 = default;
			int num39 = default;
			int num55 = default;
			int num53 = default;
			int num57 = default;
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
							}
							else
							{
								try
								{
									int num5;
									if (num4 != 0)
									{
										num5 = 7;
										goto IL_00cb;
									}
									goto IL_1b6f;
									IL_1b6f:
									_u__ = __u__1;
									int num6 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
									{
										num6 = 1;
									}
									goto IL_00d3;
									IL_00cb:
									num7 = num5;
									goto IL_00cf;
									IL_00cf:
									num6 = num7;
									goto IL_00d3;
									IL_00d3:
									while (true)
									{
										switch (num6)
										{
										case 2:
											return;
										case 12:
											__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _FlushAsync_d__15>(ref _u__, ref this);
											num6 = 2;
											continue;
										case 3:
											goto IL_014d;
										case 7:
											if (num4 != 1)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
												{
													num6 = 6;
												}
												continue;
											}
											goto IL_022a;
										case 8:
											num4 = (__1__state = -1);
											num6 = 3;
											continue;
										case 4:
											goto end_IL_00d3;
										case 14:
											goto IL_01a9;
										case 1:
											__u__1 = default;
											num6 = 8;
											continue;
										case 11:
											goto IL_0209;
										case 10:
											_u__ = val5;
											num6 = 11;
											continue;
										case 9:
											goto IL_022a;
										case 0:
										{
											(V71K6DgZim).WaitAsync(0);
											val5 = (ConfiguredTaskAwaitable<bool>)0;
											int num58 = 10;
											continue;
										}
										case 13:
											try
											{
												int num8;
												if (num4 != 1)
												{
													num8 = 9;
													goto IL_028e;
												}
												goto IL_033c;
												IL_033c:
												num8 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
												{
													num8 = 10;
												}
												goto IL_028e;
												IL_028e:
												while (true)
												{
													switch (num8)
													{
													default:
														switch (num10)
														{
														case 1000:
															break;
														default:
															goto end_IL_028e;
														case 20:
															__7__wrap2 = 0;
															num8 = 11;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
															{
																num8 = 15;
															}
															continue;
														}
														goto IL_028a;
													case 3:
														goto IL_02e8;
													case 4:
													{
														__7__wrap1 = _7__wrap;
														int num9 = 17;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
														{
															num9 = 20;
														}
														num10 = num9;
														goto IL_028a;
													}
													case 12:
														break;
													case 7:
														_entry_5__4 = __7__wrap1[__7__wrap2];
														num8 = 5;
														continue;
													case 8:
														flag = false;
														num8 = 6;
														continue;
													case 1:
														__7__wrap1 = null;
														num8 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
														{
															num8 = 7;
														}
														continue;
													case 6:
														try
														{
															System.Threading.Monitor.Enter(f91KKQC3Fo, ref flag);
															int num47 = 5;
															while (true)
															{
																switch (num47)
																{
																case 3:
																	goto end_IL_03fd;
																default:
																	if (num48 != 19)
																	{
																		if (num48 != 999)
																		{
																			break;
																		}
																		goto IL_03f9;
																	}
																	if (!(OXrKw0XDSu > System.DateTimeOffset.UtcNow))
																	{
																		num47 = 7;
																		continue;
																	}
																	goto end_IL_03d3;
																case 1:
																	goto end_IL_03d3;
																case 8:
																	((bjOfPlKCMWgTdY9HF6p)WWEKRouoI1).Xo2KrNK8TD(vNIX0hKSxIjAmGCLN6M5.Event.EventId);
																	num47 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
																	{
																		num47 = 9;
																	}
																	continue;
																case 2:
																	num40 = 0;
																	num47 = 10;
																	continue;
																case 6:
																case 10:
																	if (num40 >= array.Length)
																	{
																		int num49 = 12;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
																		{
																			num49 = 19;
																		}
																		num48 = num49;
																		goto IL_03f9;
																	}
																	goto case 9;
																case 0:
																	num40++;
																	num47 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																	{
																		num47 = 5;
																	}
																	continue;
																case 11:
																{
																	Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl2 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																	string eventId = vNIX0hKSxIjAmGCLN6M5.Event.EventId;
																	int num59 = 8;
																	continue;
																}
																case 9:
																	vNIX0hKSxIjAmGCLN6M5 = array[num40];
																	num47 = 11;
																	continue;
																case 5:
																{
																	Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																	Func<vNIX0hKSxIjAmGCLN6M, bool> _9__15_ = __c_147.__9__15_2;
																	if (_9__15_ == null)
																	{
																		__c_147 _3 = __c_147.__9;
																		__c_147.__9__15_2 = new Func<vNIX0hKSxIjAmGCLN6M, bool>(__c_147.YgNfq6FXINt);
																	}
																	array = Enumerable.ToArray<vNIX0hKSxIjAmGCLN6M>(Enumerable.Where<vNIX0hKSxIjAmGCLN6M>((global::System.Collections.Generic.IEnumerable<vNIX0hKSxIjAmGCLN6M>)eV9KtFVfZl, _9__15_));
																	num47 = 18;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
																	{
																		num47 = 2;
																	}
																	continue;
																}
																case 4:
																case 7:
																	break;
																	IL_03f9:
																	num47 = num48;
																	continue;
																}
																Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl3 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																__c_147 _;
																if (__c_147.__9__15_0 == null)
																{
																	_ = __c_147.__9;
																	__c_147.__9__15_0 = new Func<vNIX0hKSxIjAmGCLN6M, bool>(__c_147.ru2fqRTJPbv);
																}
																Enumerable.Where<vNIX0hKSxIjAmGCLN6M>((global::System.Collections.Generic.IEnumerable<vNIX0hKSxIjAmGCLN6M>)(object)_, new Func<vNIX0hKSxIjAmGCLN6M, bool>(__c_147.ru2fqRTJPbv));
																__c_147 _2;
																if (__c_147.__9__15_1 == null)
																{
																	_2 = __c_147.__9;
																	__c_147.__9__15_1 = new Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset>(__c_147.HEifqwh9CJi);
																}
																_7__wrap = Enumerable.ToArray<vNIX0hKSxIjAmGCLN6M>(Enumerable.Take<vNIX0hKSxIjAmGCLN6M>((global::System.Collections.Generic.IEnumerable<vNIX0hKSxIjAmGCLN6M>)Enumerable.OrderBy<vNIX0hKSxIjAmGCLN6M, DateTimeOffset>((global::System.Collections.Generic.IEnumerable<vNIX0hKSxIjAmGCLN6M>)(object)_2, new Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset>(__c_147.HEifqwh9CJi)), 6));
																int num60 = 13;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																{
																	int num61 = 3;
																}
																continue;
																end_IL_03fd:
																break;
															}
															goto case 4;
															end_IL_03d3:;
														}
														finally
														{
															if (num4 < 0)
															{
																int num50 = 3;
																while (true)
																{
																	switch (num50)
																	{
																	default:
																		if (num51 != 991)
																		{
																			break;
																		}
																		goto IL_065d;
																	case 1:
																		break;
																	case 3:
																		if (flag)
																		{
																			break;
																		}
																		num51 = 2;
																		goto IL_065d;
																	case 2:
																		goto end_IL_0661;
																	case 0:
																		goto end_IL_0661;
																		IL_065d:
																		num50 = num51;
																		continue;
																	}
																	System.Threading.Monitor.Exit(f91KKQC3Fo);
																	num50 = 5;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																	{
																		num50 = 0;
																	}
																	continue;
																	end_IL_0661:
																	break;
																}
															}
														}
														goto end_IL_028e;
													case 10:
														try
														{
															int num11;
															if (num4 != 1)
															{
																num11 = 8;
																goto IL_072e;
															}
															goto IL_1100;
															IL_1100:
															num11 = 9;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
															{
																num11 = 2;
															}
															goto IL_072e;
															IL_072e:
															while (true)
															{
																switch (num11)
																{
																default:
																	if (num31 != 20)
																	{
																		if (num31 == 1000)
																		{
																			goto IL_072a;
																		}
																		goto case 1;
																	}
																	f91KKQC3Fo = eDTUdFKIG1IFKQgZTDp.f91KKQC3Fo;
																	num11 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
																	{
																		num11 = 0;
																	}
																	continue;
																case 9:
																	try
																	{
																		int num20;
																		if (num4 != 1)
																		{
																			num20 = 2;
																			goto IL_07a5;
																		}
																		goto IL_0ad4;
																		IL_0ad4:
																		_u__2 = __u__2;
																		num20 = 38;
																		goto IL_07a5;
																		IL_07a5:
																		while (true)
																		{
																			int num21 = num20;
																			while (true)
																			{
																				IL_07a9:
																				int num22 = num21;
																				while (true)
																				{
																					switch (num22)
																					{
																					case 0:
																						return;
																					case 27:
																						_retryAfterSeconds_5__5 = System.Math.Clamp(num28, 1, 300);
																						num22 = 9;
																						continue;
																					case 22:
																						if (otUqeAK9rXJ3eFJguIm == null)
																						{
																							goto IL_0887;
																						}
																						if (otUqeAK9rXJ3eFJguIm.Accepted)
																						{
																							goto case 28;
																						}
																						goto case 21;
																					case 23:
																						__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>>.ConfiguredTaskAwaiter, _FlushAsync_d__15>(ref _u__2, ref this);
																						num22 = 18;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
																						{
																							num22 = 0;
																						}
																						continue;
																					case 26:
																						goto end_IL_07ad;
																					case 15:
																						_u__2 = val4;
																						num22 = 24;
																						continue;
																					case 10:
																						if ((int)(val3).ValueKind == 1)
																						{
																							num22 = 13;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																							{
																								num22 = 18;
																							}
																							continue;
																						}
																						goto IL_0a5e;
																					case 8:
																						goto IL_0956;
																					case 28:
																						if ((otUqeAK9rXJ3eFJguIm.EventId != _entry_5__4.Event.EventId))
																						{
																							num22 = 17;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
																							{
																								num22 = 34;
																							}
																							continue;
																						}
																						goto IL_0aae;
																					case 13:
																						val3 = (JsonElement)tZ40E3fwQFywClnXCq1A_;
																						num22 = 9;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
																						{
																							num22 = 4;
																						}
																						continue;
																					case 4:
																						if ((val3).TryGetProperty("retryAfterSeconds", ref val2))
																						{
																							num22 = 19;
																							continue;
																						}
																						goto IL_0a5e;
																					case 1:
																						val3 = (JsonElement)tZ40E3fwQFywClnXCq1A_;
																						num22 = 10;
																						continue;
																					case 24:
																						if (&_u__2 != null)
																						{
																							num22 = 6;
																							continue;
																						}
																						goto case 30;
																					case 30:
																						num4 = (__1__state = 1);
																						num22 = 29;
																						continue;
																					case 3:
																					case 9:
																						goto IL_0a5e;
																					case 14:
																						goto IL_0aae;
																					case 16:
																						goto end_IL_07a5;
																					case 2:
																					{
																						RGxKFMoQKP.zZtgY0EvL5<OtUqeAK9rXJ3eFJguIm>(System.Net.Http.HttpMethod.Post, "/api/o/6e48df20935a4ac2b16f0fdf9eb78143", _entry_5__4.Event, accessToken, (_timeout_5__6).Token);
																						val4 = (ConfiguredTaskAwaitable<D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>>)0;
																						int num62 = 38;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
																						{
																							int num63 = 15;
																						}
																						continue;
																					}
																					case 20:
																						goto IL_0b5b;
																					case 6:
																					case 18:
																						tZ40E3fwQFywClnXCq1A_ = (D7xJjNfwCFnMZjlFZPVf.tZ40E3fwQFywClnXCq1A_1<OtUqeAK9rXJ3eFJguIm>)(&_u__2);
																						num22 = 5;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
																						{
																							num22 = 26;
																						}
																						continue;
																					case 7:
																					case 17:
																					case 25:
																						goto IL_0b8c;
																					case 5:
																						num4 = (__1__state = -1);
																						num22 = 18;
																						continue;
																					case 29:
																						__u__2 = _u__2;
																						num22 = 23;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
																						{
																							num22 = 31;
																						}
																						continue;
																					case 19:
																						if (!(val2).TryGetInt32(ref num28))
																						{
																							num22 = 3;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																							{
																								num22 = 12;
																							}
																							continue;
																						}
																						goto case 27;
																					case 11:
																						try
																						{
																							System.Threading.Monitor.Enter(f91KKQC3Fo, ref flag);
																							int num23 = 9;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
																							{
																								num23 = 1;
																							}
																							while (true)
																							{
																								switch (num23)
																								{
																								case 2:
																									break;
																								default:
																									if (num25 != 18)
																									{
																										if (num25 == 998)
																										{
																											goto IL_0c69;
																										}
																										goto case 6;
																									}
																									goto case 0;
																								case 1:
																								{
																									Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl4 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																									string eventId2 = _entry_5__4.Event.EventId;
																									int num64 = 8;
																									continue;
																								}
																								case 5:
																								{
																									Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl5 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																									string eventId3 = _entry_5__4.Event.EventId;
																									int num65 = 6;
																									continue;
																								}
																								case 9:
																								{
																									Dictionary<string, DateTimeOffset> oB3K5D4spL = oB3K5D4spL;
																									string eventId4 = _entry_5__4.Event.EventId;
																									System.DateTimeOffset.UtcNow;
																									int num66 = 10;
																									continue;
																								}
																								case 3:
																									goto end_IL_0c2e;
																								case 0:
																									if (vNIX0hKSxIjAmGCLN6M.Event.Count <= otUqeAK9rXJ3eFJguIm.AcceptedCount)
																									{
																										num23 = 10;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																										{
																											num23 = 1;
																										}
																										continue;
																									}
																									goto case 4;
																								case 6:
																									((bjOfPlKCMWgTdY9HF6p)WWEKRouoI1).Save(pending);
																									num23 = 7;
																									continue;
																								case 10:
																								{
																									Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl6 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																									string eventId5 = _entry_5__4.Event.EventId;
																									if (&vNIX0hKSxIjAmGCLN6M != null)
																									{
																										int num24 = 18;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
																										{
																											num24 = 12;
																										}
																										num25 = num24;
																										goto IL_0c69;
																									}
																									break;
																								}
																								case 4:
																								{
																									vNIX0hKSxIjAmGCLN6M vNIX0hKSxIjAmGCLN6M2 = vNIX0hKSxIjAmGCLN6M.tMJK8acXId();
																									val = System.DateTimeOffset.UtcNow;
																									vNIX0hKSxIjAmGCLN6M2.DueUtc = (val).AddSeconds(60.0);
																									vNIX0hKSxIjAmGCLN6M2.Failures = 0;
																									pending = vNIX0hKSxIjAmGCLN6M2;
																									num23 = 3;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
																									{
																										num23 = 5;
																									}
																									continue;
																								}
																								case 8:
																									((bjOfPlKCMWgTdY9HF6p)WWEKRouoI1).Xo2KrNK8TD(_entry_5__4.Event.EventId);
																									num23 = 3;
																									continue;
																								case 7:
																									goto end_IL_0c2e;
																									IL_0c69:
																									num23 = num25;
																									continue;
																								}
																								break;
																							}
																							goto IL_02e8;
																							end_IL_0c2e:;
																						}
																						finally
																						{
																							if (num4 < 0)
																							{
																								int num26 = 5;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
																								{
																									num26 = 0;
																								}
																								while (true)
																								{
																									switch (num26)
																									{
																									default:
																										if (num27 == 990)
																										{
																											num26 = num27;
																											continue;
																										}
																										goto case 2;
																									case 2:
																										System.Threading.Monitor.Exit(f91KKQC3Fo);
																										num26 = 1;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
																										{
																											num26 = 5;
																										}
																										continue;
																									case 0:
																										if (flag)
																										{
																											num26 = 2;
																											continue;
																										}
																										break;
																									case 1:
																										break;
																									}
																									break;
																								}
																							}
																						}
																						goto end_IL_0789;
																					case 21:
																						num22 = 9;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																						{
																							num22 = 7;
																						}
																						continue;
																					case 12:
																						goto end_IL_0789;
																					}
																					if (num21 != 38)
																					{
																						if (num21 == 1018)
																						{
																							goto IL_07a9;
																						}
																						goto IL_0956;
																					}
																					__u__2 = default;
																					num22 = 5;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
																					{
																						num22 = 8;
																					}
																					continue;
																					IL_0aae:
																					if (otUqeAK9rXJ3eFJguIm.AcceptedCount < _entry_5__4.Event.Count)
																					{
																						num22 = 25;
																						continue;
																					}
																					f91KKQC3Fo = eDTUdFKIG1IFKQgZTDp.f91KKQC3Fo;
																					num22 = 20;
																					continue;
																					IL_0a5e:
																					if (tZ40E3fwQFywClnXCq1A_ != null)
																					{
																						num22 = 22;
																						continue;
																					}
																					goto IL_0b8c;
																					IL_0b8c:
																					throw new global::System.Exception("decoy_event_unconfirmed");
																					IL_0956:
																					if ((nint)tZ40E3fwQFywClnXCq1A_ == 429)
																					{
																						num22 = 19;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
																						{
																							num22 = 1;
																						}
																						continue;
																					}
																					goto IL_0a5e;
																					continue;
																					end_IL_07ad:
																					break;
																				}
																				break;
																			}
																			otUqeAK9rXJ3eFJguIm = (OtUqeAK9rXJ3eFJguIm)(object)tZ40E3fwQFywClnXCq1A_;
																			num20 = 8;
																			continue;
																			IL_0887:
																			num20 = 21;
																			continue;
																			IL_0b5b:
																			flag = false;
																			num20 = 11;
																			continue;
																			end_IL_07a5:
																			break;
																		}
																		goto IL_0ad4;
																		end_IL_0789:;
																	}
																	finally
																	{
																		if (num4 < 0)
																		{
																			int num29 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
																			{
																				num29 = 6;
																			}
																			while (true)
																			{
																				switch (num29)
																				{
																				default:
																					if (num30 == 990)
																					{
																						num29 = num30;
																						continue;
																					}
																					goto case 0;
																				case 0:
																					(_timeout_5__6).Dispose();
																					num29 = 2;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
																					{
																						num29 = 5;
																					}
																					continue;
																				case 1:
																					if (_timeout_5__6 != null)
																					{
																						num29 = 5;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
																						{
																							num29 = 0;
																						}
																						continue;
																					}
																					break;
																				case 2:
																					break;
																				}
																				break;
																			}
																		}
																	}
																	goto case 11;
																case 8:
																	f91KKQC3Fo = eDTUdFKIG1IFKQgZTDp.f91KKQC3Fo;
																	num11 = 10;
																	continue;
																case 4:
																	if (RGxKFMoQKP == null)
																	{
																		num11 = 2;
																		continue;
																	}
																	goto case 3;
																case 3:
																{
																	accessToken = null;
																	int num32 = 20;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
																	{
																		num32 = 6;
																	}
																	num31 = num32;
																	goto IL_072a;
																}
																case 0:
																	flag = false;
																	num11 = 12;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
																	{
																		num11 = 17;
																	}
																	continue;
																case 1:
																	_timeout_5__6 = (CancellationTokenSource)System.TimeSpan.FromSeconds(45.0);
																	num11 = 16;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
																	{
																		num11 = 6;
																	}
																	continue;
																case 6:
																	break;
																case 2:
																	RGxKFMoQKP = k78QiLgLvQc95QQmDIY.mF3gZOoNHK();
																	num11 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																	{
																		num11 = 3;
																	}
																	continue;
																case 12:
																	try
																	{
																		System.Threading.Monitor.Enter(f91KKQC3Fo, ref flag);
																		int num16 = 4;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
																		{
																			num16 = 1;
																		}
																		while (true)
																		{
																			switch (num16)
																			{
																			default:
																				if (num17 != 10)
																				{
																					if (num17 != 990)
																					{
																						break;
																					}
																					goto IL_1185;
																				}
																				accessToken = v5OiSQSzC8GipXkQ3VG.AccessToken;
																				num16 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																				{
																					num16 = 0;
																				}
																				continue;
																			case 1:
																				break;
																			case 2:
																			{
																				WeakReference<v5OiSQSzC8GipXkQ3VG>? dxRKPMl6jC = dxRKPMl6jC;
																				if (&v5OiSQSzC8GipXkQ3VG != null)
																				{
																					num17 = 10;
																					goto IL_1185;
																				}
																				goto end_IL_1189;
																			}
																			case 0:
																				goto end_IL_1189;
																				IL_1185:
																				num16 = num17;
																				continue;
																			}
																			if (dxRKPMl6jC != null)
																			{
																				num16 = 4;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
																				{
																					num16 = 2;
																				}
																				continue;
																			}
																			break;
																			continue;
																			end_IL_1189:
																			break;
																		}
																	}
																	finally
																	{
																		if (num4 < 0)
																		{
																			int num18 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																			{
																				num18 = 9;
																			}
																			while (true)
																			{
																				switch (num18)
																				{
																				default:
																					if (num19 == 991)
																					{
																						num18 = num19;
																						continue;
																					}
																					goto case 0;
																				case 0:
																					if (!flag)
																					{
																						num18 = 8;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
																						{
																							num18 = 1;
																						}
																						continue;
																					}
																					break;
																				case 1:
																					goto end_IL_1261;
																				case 2:
																					break;
																				case 3:
																					goto end_IL_1261;
																				}
																				System.Threading.Monitor.Exit(f91KKQC3Fo);
																				num18 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
																				{
																					num18 = 0;
																				}
																				continue;
																				end_IL_1261:
																				break;
																			}
																		}
																	}
																	goto case 1;
																case 11:
																	_timeout_5__6 = null;
																	num11 = 5;
																	continue;
																case 7:
																	try
																	{
																		System.Threading.Monitor.Enter(f91KKQC3Fo, ref flag);
																		int num12 = 2;
																		while (true)
																		{
																			switch (num12)
																			{
																			default:
																				if (num13 == 990)
																				{
																					num12 = num13;
																					continue;
																				}
																				break;
																			case 2:
																				val = System.DateTimeOffset.UtcNow;
																				num12 = 2;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																				{
																					num12 = 1;
																				}
																				continue;
																			case 1:
																				break;
																			case 0:
																				goto end_IL_1330;
																			}
																			OXrKw0XDSu = (val).AddSeconds(10.0);
																			num12 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
																			{
																				num12 = 2;
																			}
																			continue;
																			end_IL_1330:
																			break;
																		}
																	}
																	finally
																	{
																		if (num4 < 0)
																		{
																			int num14 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																			{
																				num14 = 0;
																			}
																			while (true)
																			{
																				switch (num14)
																				{
																				default:
																					if (num15 == 991)
																					{
																						num14 = num15;
																						continue;
																					}
																					goto case 0;
																				case 0:
																					if (!flag)
																					{
																						num14 = 2;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
																						{
																							num14 = 1;
																						}
																						continue;
																					}
																					break;
																				case 1:
																					goto end_IL_13f6;
																				case 2:
																					break;
																				case 3:
																					goto end_IL_13f6;
																				}
																				System.Threading.Monitor.Exit(f91KKQC3Fo);
																				num14 = 3;
																				continue;
																				end_IL_13f6:
																				break;
																			}
																		}
																	}
																	goto case 4;
																case 10:
																	flag = false;
																	num11 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
																	{
																		num11 = 2;
																	}
																	continue;
																case 5:
																	goto end_IL_072e;
																	IL_072a:
																	num11 = num31;
																	continue;
																}
																goto IL_1100;
																continue;
																end_IL_072e:
																break;
															}
														}
														catch (global::System.Exception)
														{
															int num33 = 2;
															while (true)
															{
																switch (num33)
																{
																default:
																	if (num46 == 991)
																	{
																		num33 = num46;
																		continue;
																	}
																	break;
																case 3:
																	try
																	{
																		System.Threading.Monitor.Enter(f91KKQC3Fo, ref flag);
																		int num34 = 12;
																		while (true)
																		{
																			int num41;
																			switch (num34)
																			{
																			default:
																				if (num42 != 24 && num42 == 1004)
																				{
																					goto IL_151c;
																				}
																				goto case 2;
																			case 6:
																			case 10:
																				num40 = 300;
																				num34 = 15;
																				continue;
																			case 8:
																				num40 = 10;
																				num41 = 3;
																				goto IL_1518;
																			case 11:
																				goto IL_15b8;
																			case 13:
																				goto IL_15ea;
																			case 9:
																				break;
																			case 1:
																				switch (num43)
																				{
																				case 1:
																					break;
																				case 2:
																					goto IL_15b8;
																				case 3:
																					goto IL_15ea;
																				default:
																					goto IL_1655;
																				}
																				goto case 8;
																			case 2:
																			case 3:
																			case 15:
																				num35 = num40;
																				num34 = 15;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																				{
																					num34 = 16;
																				}
																				continue;
																			case 7:
																			{
																				vNIX0hKSxIjAmGCLN6M vNIX0hKSxIjAmGCLN6M4 = vNIX0hKSxIjAmGCLN6M3.tMJK8acXId();
																				val = System.DateTimeOffset.UtcNow;
																				vNIX0hKSxIjAmGCLN6M4.DueUtc = (val).AddSeconds(num35);
																				vNIX0hKSxIjAmGCLN6M4.Failures = num43;
																				pending2 = vNIX0hKSxIjAmGCLN6M4;
																				num34 = 5;
																				continue;
																			}
																			case 12:
																			{
																				Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl7 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																				string eventId6 = _entry_5__4.Event.EventId;
																				if (&vNIX0hKSxIjAmGCLN6M3 == null)
																				{
																					int num67 = 21;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
																					{
																						int num68 = 9;
																					}
																					continue;
																				}
																				goto case 0;
																			}
																			case 5:
																			{
																				Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl8 = eDTUdFKIG1IFKQgZTDp.eV9KtFVfZl;
																				string eventId7 = _entry_5__4.Event.EventId;
																				int num69 = 4;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
																				{
																					int num70 = 4;
																				}
																				continue;
																			}
																			case 0:
																				num43 = System.Math.Min(vNIX0hKSxIjAmGCLN6M3.Failures + 1, 1000);
																				num34 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
																				{
																					num34 = 8;
																				}
																				continue;
																			case 4:
																				try
																				{
																					((bjOfPlKCMWgTdY9HF6p)WWEKRouoI1).Save(pending2);
																					int num36 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
																					{
																						num36 = 2;
																					}
																					while (true)
																					{
																						switch (num36)
																						{
																						default:
																							if (num37 == 988)
																							{
																								num36 = num37;
																								continue;
																							}
																							break;
																						case 0:
																							break;
																						}
																						break;
																					}
																				}
																				catch (global::System.Exception)
																				{
																					int num38 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
																					{
																						num38 = 2;
																					}
																					while (true)
																					{
																						switch (num38)
																						{
																						case 0:
																							goto end_IL_17ed;
																						}
																						if (num39 == 988)
																						{
																							num38 = num39;
																							continue;
																						}
																						goto end_IL_17ed;
																					}
																					end_IL_17ed:;
																				}
																				goto end_IL_14cd;
																			case 16:
																				num35 = System.Math.Max(num35, _retryAfterSeconds_5__5);
																				num34 = 7;
																				continue;
																			case 14:
																				goto end_IL_14cd;
																				IL_1518:
																				num42 = num41;
																				goto IL_151c;
																				IL_1655:
																				num34 = 6;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
																				{
																					num34 = 21;
																				}
																				continue;
																				IL_15ea:
																				num40 = 60;
																				num34 = 2;
																				continue;
																				IL_15b8:
																				num40 = 30;
																				num41 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
																				{
																					num41 = 24;
																				}
																				goto IL_1518;
																				IL_151c:
																				num34 = num42;
																				continue;
																			}
																			break;
																		}
																	}
																	finally
																	{
																		if (num4 < 0)
																		{
																			int num44 = 2;
																			while (true)
																			{
																				IL_188d:
																				int num45 = num44;
																				while (true)
																				{
																					switch (num45)
																					{
																					default:
																						if (num44 == 991)
																						{
																							break;
																						}
																						goto end_IL_1891;
																					case 3:
																						goto end_IL_1891;
																					case 1:
																						System.Threading.Monitor.Exit(f91KKQC3Fo);
																						num45 = 9;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
																						{
																							num45 = 0;
																						}
																						continue;
																					case 2:
																						if (!flag)
																						{
																							num45 = 3;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																							{
																								num45 = 8;
																							}
																							continue;
																						}
																						goto case 1;
																					case 0:
																						goto end_IL_1891;
																					}
																					goto IL_188d;
																					continue;
																					end_IL_1891:
																					break;
																				}
																				break;
																			}
																		}
																	}
																	goto IL_02e8;
																case 2:
																	f91KKQC3Fo = eDTUdFKIG1IFKQgZTDp.f91KKQC3Fo;
																	num33 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
																	{
																		num33 = 0;
																	}
																	continue;
																case 0:
																	flag = false;
																	num33 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
																	{
																		num33 = 3;
																	}
																	continue;
																case 1:
																	break;
																	end_IL_14cd:
																	break;
																}
																break;
															}
														}
														goto case 1;
													case 5:
														_retryAfterSeconds_5__5 = 0;
														num8 = 12;
														continue;
													case 0:
													case 11:
														if (__7__wrap2 >= __7__wrap1.Length)
														{
															num8 = 8;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
															{
																num8 = 1;
															}
															continue;
														}
														goto case 7;
													case 9:
														f91KKQC3Fo = eDTUdFKIG1IFKQgZTDp.f91KKQC3Fo;
														num8 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
														{
															num8 = 4;
														}
														continue;
													case 2:
														goto end_IL_028e;
														IL_028a:
														num8 = num10;
														continue;
														IL_02e8:
														__7__wrap2++;
														num8 = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
														{
															num8 = 0;
														}
														continue;
													}
													goto IL_033c;
													continue;
													end_IL_028e:
													break;
												}
											}
											catch (global::System.Exception)
											{
												int num52 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
												{
													num52 = 0;
												}
												while (true)
												{
													switch (num52)
													{
													default:
														if (num53 == 988)
														{
															num52 = num53;
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
												if (num4 < 0)
												{
													int num54 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
													{
														num54 = 1;
													}
													while (true)
													{
														switch (num54)
														{
														default:
															if (num55 == 989)
															{
																num54 = num55;
																continue;
															}
															break;
														case 1:
															(V71K6DgZim).Release();
															num54 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
															{
																num54 = 1;
															}
															continue;
														case 0:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_00d3;
										case 5:
											goto IL_1b6f;
										case 6:
											goto end_IL_00d3;
										}
										if (num7 != 22)
										{
											if (num7 == 1002)
											{
												goto IL_00cf;
											}
											goto IL_0209;
										}
										__u__1 = _u__;
										num6 = 12;
										continue;
										IL_022a:
										num6 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num6 = 13;
										}
										continue;
										IL_014d:
										if (&_u__ == null)
										{
											num6 = 4;
											continue;
										}
										goto IL_022a;
										IL_0209:
										if (&_u__ == null)
										{
											num6 = 14;
											continue;
										}
										goto IL_014d;
										continue;
										end_IL_00d3:
										break;
									}
									goto end_IL_00b0;
									IL_01a9:
									num4 = (__1__state = 0);
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
									{
										num5 = 22;
									}
									goto IL_00cb;
									end_IL_00b0:;
								}
								catch (global::System.Exception ex4)
								{
									int num56 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
									{
										num56 = 8;
									}
									while (true)
									{
										switch (num56)
										{
										case 1:
											return;
										default:
											if (num57 != 990)
											{
												return;
											}
											num56 = num57;
											break;
										case 2:
											(__t__builder).SetException(ex4);
											num56 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
											{
												num56 = 1;
											}
											break;
										case 0:
											__1__state = -2;
											num56 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
											{
												num56 = 2;
											}
											break;
										}
									}
								}
							}
							goto case 3;
						case 1:
							break;
						case 3:
							__1__state = -2;
							num3 = 2;
							continue;
						case 0:
							return;
						case 2:
							(__t__builder).SetResult();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
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
				num4 = __1__state;
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
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
					(__t__builder).SetStateMachine(stateMachine);
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 0;
					}
				}
			}
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
								return;
							}
							goto IL_0031;
						case 2:
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
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
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 0;
						}
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
		internal static bool yiwnUA9rM6cehMrLaVan()
		{
			return F7ls9Q9rNOwaKoOX3cEN == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Rw12ak9rp5YiBpbJYeQj()
		{
			return F7ls9Q9rNOwaKoOX3cEN;
		}
	}

	private static readonly object f91KKQC3Fo;

	private static readonly object egnKH0KGuw;

	private static readonly Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl;

	private static readonly Dictionary<string, GidN49duOY8iHR2nUNC> EdIKOHXKTU;

	private static readonly Dictionary<string, DateTimeOffset> oB3K5D4spL;

	private static readonly object V71K6DgZim;

	private static readonly object WWEKRouoI1;

	private static DateTimeOffset OXrKw0XDSu;

	private static readonly Lazy<string> FqyKeJS4Ql;

	private static WeakReference<v5OiSQSzC8GipXkQ3VG>? dxRKPMl6jC;

	private static Timer? pPaKx3YAOk;

	private static k78QiLgLvQc95QQmDIY? RGxKFMoQKP;

	internal static object siyRQUZWNGuPBT1CSu3o;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static void Bh9KgPM1Vc(object client)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_00f2: Expected O, but got I4
		//IL_007e: Expected I4, but got O
		//IL_00fc->IL0010: Incompatible stack types: I4 vs O
		//IL_0118->IL0010: Incompatible stack types: I4 vs O
		//IL_005b->IL006d: Incompatible stack types: I4 vs O
		//IL_0123->IL0010: Incompatible stack types: I4 vs O
		//IL_0066->IL006d: Incompatible stack types: I4 vs O
		//IL_00c6->IL006d: Incompatible stack types: I4 vs O
		//IL_00aa->IL006d: Incompatible stack types: I4 vs O
		//IL_00b5->IL006d: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj3 = default;
		object obj4 = default;
		object obj6 = default;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 3:
				{
					System.Threading.Monitor.Enter(obj3, ref obj4);
					object obj5 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
					{
						obj5 = 4;
					}
					while (true)
					{
						switch ((int)obj5)
						{
						default:
							if ((nint)obj6 == 990)
							{
								obj5 = obj6;
								continue;
							}
							break;
						case 2:
							Start();
							obj5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								obj5 = 4;
							}
							continue;
						case 0:
							break;
						case 1:
							return;
						}
						dxRKPMl6jC = (WeakReference<v5OiSQSzC8GipXkQ3VG>?)client;
						obj5 = 2;
					}
				}
				case 0:
					obj4 = 0;
					obj2 = 3;
					break;
				case 2:
					return;
				case 1:
					obj3 = f91KKQC3Fo;
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
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
	private static void Start()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void LipKlx6PVV(object buildId, object layoutId, object decoyId, object symbol)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task U2mKd85i2c()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		object obj = System.Guid.NewGuid();
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7;
		_ = 11;
		eV9KtFVfZl = (Dictionary<string, vNIX0hKSxIjAmGCLN6M>)(object)System.StringComparer.Ordinal;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BWNa9PZWMYlZdn4NNVGm()
	{
		return siyRQUZWNGuPBT1CSu3o == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static eDTUdFKIG1IFKQgZTDp VG25N7ZWpYDL3l1ZjS8J()
	{
		return (eDTUdFKIG1IFKQgZTDp)siyRQUZWNGuPBT1CSu3o;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QplM0bfLb4PwWIsZYhRM;
using SharpCompress.Archives;
using SharpCompress.Readers;
using fDAldojjppXrctUVYOJn;
using hAoqh2oglC8sMtYZroA;
using juC9IPf0yHbXVIJyU2NU;
using knGiRcfu9DhbMgArQGtn;
using yko5ekf0Vt0uU4qpssM2;
using zmRgyMXHgEnjab02Fn1M;

namespace ilOrlDXHcN1uPq9DGB2O;

internal class Xli2LmXHSycQMfOwFiRM
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_36
	{
		public static __c_36 __9;

		public static Func<IArchiveEntry, bool> __9__13_0;

		public static Func<string, bool> __9__15_0;

		internal static __c_36 rjkSR992rsBkHsYXWPey;

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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							__9 = (__c_36)new __c_36();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num3 = 3;
							}
							continue;
						case 4:
							break;
						case 0:
							num3 = 3;
							continue;
						case 2:
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
							{
								num3 = 2;
							}
							continue;
						case 3:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
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
				HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_36()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool gwVLLvFIkNR(IArchiveEntry entry)
		{
			return !(entry).IsDirectory;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool dwoLLEoGIJg(string segment)
		{
			return (segment).Contains(':');
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool uf4pdi92oXXwrxalHidt()
		{
			return rjkSR992rsBkHsYXWPey == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_36 AKehNS92myLhW25ilI5q()
		{
			return rjkSR992rsBkHsYXWPey;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_0_1
	{
		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public int lastNativePercent;

		public xdAHnXXHBeS3dgIAsIYi summary;

		private static __c__DisplayClass10_0_1 kR6iwm927t0tMGew3FQy;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_0_1()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void GWULL2xxZ50(int percent)
		{
			int num = 1;
			long extractedBytes = default;
			int entryNumber = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						long num5;
						int num4;
						switch (num3)
						{
						default:
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							if (summary.TotalBytes <= 0)
							{
								num3 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
								{
									num3 = 2;
								}
								continue;
							}
							num5 = summary.TotalBytes * percent / 100;
							goto IL_0160;
						case 4:
							cI6XHCx6Hr6(progress, extractedBytes, summary.TotalBytes, entryNumber, summary.FileCount);
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num3 = 3;
							}
							continue;
						case 2:
							num5 = 0L;
							goto IL_0160;
						case 5:
							if (summary.FileCount <= 0)
							{
								num3 = 6;
								continue;
							}
							num4 = System.Math.Min(summary.FileCount, (int)System.Math.Ceiling((double)(summary.FileCount * percent) / 100.0));
							goto IL_01a4;
						case 6:
							num4 = 0;
							goto IL_01a4;
						case 1:
							break;
						case 3:
							return;
						case 0:
							return;
							IL_01a4:
							entryNumber = num4;
							num3 = 4;
							continue;
							IL_0160:
							extractedBytes = num5;
							num3 = 5;
							continue;
						}
						if (percent > lastNativePercent)
						{
							goto end_IL_000c;
						}
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 0;
						}
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				lastNativePercent = percent;
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
				{
					num = 13;
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
							switch (num2)
							{
							case 990:
								break;
							default:
								goto end_IL_000e;
							case 9:
								goto IL_0078;
							}
							break;
						case 0:
							return;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							goto end_IL_000e;
							IL_0078:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num3 = 1;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool l9WSlK92AHLewMq1DBvx()
		{
			return kR6iwm927t0tMGew3FQy == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass10_0_1 cA3ufL92IHqKcid9qpSn()
		{
			return kR6iwm927t0tMGew3FQy;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass10_1
	{
		public loUP6Nf08wOPnG4Lm7Oe.D03AJVLckTZErjaSvxTe plan;

		public double extractionEndPercent;

		public bool verifiesDuringExtraction;

		public __c__DisplayClass10_0_1 CS___8__locals1;

		internal static __c__DisplayClass10_1 IQE2PG92BfTju1qshd1w;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass10_1()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void VyvLLqKVC61(long extractedBytes, int extractedFiles)
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
						cI6XHCx6Hr6(CS___8__locals1.progress, extractedBytes, plan.TotalBytes, extractedFiles, plan.FileCount, extractionEndPercent, verifiesDuringExtraction);
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
						{
							num2 = 0;
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
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num3 = 0;
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
		internal static bool Bnfylf92gGv93vyIUFnu()
		{
			return IQE2PG92BfTju1qshd1w == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass10_1 JcUqQ292lJnV9x3HPqSR()
		{
			return IQE2PG92BfTju1qshd1w;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_1
	{
		public string archivePath;

		public string destinationPath;

		public CancellationToken cancellationToken;

		internal static __c__DisplayClass8_0_1 dfADGo92dEXjen47jNOL;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_1()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal xdAHnXXHBeS3dgIAsIYi br0LLGTPZKt()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			return z01XHWk9LAN(archivePath, destinationPath, cancellationToken);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 2;
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
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							break;
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool YVsSS692KSFJPg7c0sKd()
		{
			return dfADGo92dEXjen47jNOL == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass8_0_1 wTs8jt92HYii2KlJdyti()
		{
			return dfADGo92dEXjen47jNOL;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass9_0
	{
		public string archivePath;

		public string destinationPath;

		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public CancellationToken cancellationToken;

		public KkXJvSffzM6Jqh09qOWl patchManifest;

		private static __c__DisplayClass9_0 XpDsN892tyxN4gTBwCV8;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass9_0()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool MHALLiTMFJl()
		{
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			return PPRXHyjcb1M(archivePath, destinationPath, progress, cancellationToken, patchManifest);
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
								goto case 0;
							}
							return;
						case 0:
							num3 = 2;
							continue;
						case 2:
							break;
						case 1:
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool PRfwTQ92OGNpbKXQl1m1()
		{
			return XpDsN892tyxN4gTBwCV8 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass9_0 DC5q0d925tWVoDwxVgep()
		{
			return XpDsN892tyxN4gTBwCV8;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ExtractAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string archivePath;

		public string destinationPath;

		public IProgress<TNGLHufuZJeliMhnBLZ9> progress;

		public CancellationToken cancellationToken;

		public KkXJvSffzM6Jqh09qOWl patchManifest;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		internal static object bNxAlu926HDev86Mo0iT;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0283: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Expected O, but got I
			//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ec->IL048e: Incompatible stack heights: 3 vs 1
			//IL_0063->IL0010: Incompatible stack heights: 3 vs 1
			//IL_006e->IL0010: Incompatible stack heights: 3 vs 1
			//IL_02d3->IL01ff: Incompatible stack heights: 3 vs 1
			//IL_02de->IL01ff: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num4 = default;
			int num14 = default;
			__c__DisplayClass9_0 _c__DisplayClass9_ = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _u__ = default;
			int num8 = default;
			ConfiguredTaskAwaitable<bool> val = default;
			int num10 = default;
			int num12 = default;
			int num16 = default;
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
								goto case 2;
							}
							_ = __t__builder;
							_ = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
							{
								_ = 8;
							}
							continue;
						case 3:
							num4 = __1__state;
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 5;
									goto IL_00b6;
								}
								goto IL_014c;
								IL_014c:
								num5 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
								{
									num5 = 4;
								}
								goto IL_00b6;
								IL_00b6:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num14 == 14)
										{
											break;
										}
										if (num14 == 994)
										{
											goto IL_00b2;
										}
										goto case 6;
									case 5:
										_c__DisplayClass9_ = (__c__DisplayClass9_0)new __c__DisplayClass9_0();
										num5 = 3;
										continue;
									case 1:
										_c__DisplayClass9_.progress = progress;
										num5 = 6;
										continue;
									case 0:
										_c__DisplayClass9_.destinationPath = destinationPath;
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
										{
											num5 = 8;
										}
										continue;
									case 2:
									{
										_c__DisplayClass9_.patchManifest = patchManifest;
										int num13 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
										{
											num13 = 2;
										}
										num14 = num13;
										goto IL_00b2;
									}
									case 3:
										_c__DisplayClass9_.archivePath = archivePath;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
										{
											num5 = 1;
										}
										continue;
									case 6:
										_c__DisplayClass9_.cancellationToken = cancellationToken;
										num5 = 2;
										continue;
									case 4:
										{
											try
											{
												int num6;
												if (num4 != 0)
												{
													num6 = 7;
													goto IL_01ff;
												}
												goto IL_0282;
												IL_0282:
												_u__ = __u__1;
												num6 = 11;
												goto IL_01ff;
												IL_01ff:
												while (true)
												{
													int num7;
													switch (num6)
													{
													default:
														if (num8 != 19)
														{
															if (num8 == 999)
															{
																goto IL_01fb;
															}
															goto case 7;
														}
														goto case 2;
													case 8:
														__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ExtractAsync_d__9>(ref _u__, ref this);
														num6 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
														{
															num6 = 15;
														}
														continue;
													case 10:
														break;
													case 5:
														return;
													case 7:
														global::System.Threading.Tasks.Task.Run<bool>(new Func<bool>(__c__DisplayClass9_0.MHALLiTMFJl), System.Threading.CancellationToken.None);
														val = (ConfiguredTaskAwaitable<bool>)0;
														_ = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
														{
															_ = 0;
														}
														continue;
													case 0:
														_u__ = val;
														num6 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
														{
															num6 = 6;
														}
														continue;
													case 1:
														__u__1 = _u__;
														num6 = 8;
														continue;
													case 2:
													{
														bool flag = (byte)(&_u__) != 0;
														num7 = 9;
														goto IL_01f7;
													}
													case 4:
														num4 = (__1__state = 0);
														num6 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
														{
															num6 = 1;
														}
														continue;
													case 11:
														__u__1 = default;
														num6 = 3;
														continue;
													case 3:
														num4 = (__1__state = -1);
														num7 = 19;
														goto IL_01f7;
													case 6:
														if (&_u__ != null)
														{
															num7 = 2;
															goto IL_01f7;
														}
														goto case 4;
													case 9:
														goto end_IL_01ff;
														IL_01f7:
														num8 = num7;
														goto IL_01fb;
														IL_01fb:
														num6 = num8;
														continue;
													}
													goto IL_0282;
													continue;
													end_IL_01ff:
													break;
												}
											}
											catch (OperationCanceledException)
											{
												int num9 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
												{
													num9 = 6;
												}
												while (true)
												{
													switch (num9)
													{
													default:
														if (num10 == 988)
														{
															goto IL_03ca;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_03ca:
													num9 = num10;
												}
												throw new global::System.Exception();
											}
											catch (global::System.Exception ex2)
											{
												int num11 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
												{
													num11 = 6;
												}
												while (true)
												{
													switch (num11)
													{
													default:
														if (num12 == 988)
														{
															goto IL_041b;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_041b:
													num11 = num12;
												}
												_ = "客户端压缩包无法解压";
												throw ex2;
											}
											goto end_IL_00b6;
										}
										IL_00b2:
										num5 = num14;
										continue;
									}
									goto IL_014c;
									continue;
									end_IL_00b6:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num15 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
								{
									num15 = 0;
								}
								while (true)
								{
									switch (num15)
									{
									default:
										if (num16 == 990)
										{
											num15 = num16;
											continue;
										}
										break;
									case 0:
										__1__state = -2;
										num15 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num15 = 1;
										}
										continue;
									case 1:
										break;
									case 2:
										return;
									}
									_ = __t__builder;
									_ = 2;
								}
							}
							break;
						case 0:
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
				__1__state = -2;
				num = 10;
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
			int num = 2;
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
								return;
							}
							goto end_IL_0012;
						case 2:
							num3 = 1;
							continue;
						case 0:
							break;
						case 1:
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
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
				while (num2 == 990);
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 4;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool DSrDqc92RCtkYPd8xIGQ()
		{
			return bNxAlu926HDev86Mo0iT == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object K5sBPy92wp88BmKwpMJn()
		{
			return bNxAlu926HDev86Mo0iT;
		}
	}

	internal static object wgoaaxZ5S1cPAEmuWbW3;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<xdAHnXXHBeS3dgIAsIYi> tlaXH0uT2Qy(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<bool> QoEXH8yq92c(object archivePath, object destinationPath, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken, KkXJvSffzM6Jqh09qOWl? patchManifest = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		_ExtractAsync_d__9 extractAsync_d__ = default;
		extractAsync_d__.cancellationToken = cancellationToken;
		_ = 12;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed;
		_ = 14;
		extractAsync_d__.patchManifest = patchManifest;
		_ = 2;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_ExtractAsync_d__9*)10)->__t__builder, ref extractAsync_d__);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool PPRXHyjcb1M(object archivePath, object destinationPath, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken, KkXJvSffzM6Jqh09qOWl? patchManifest)
	{
		//IL_040b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0431: Expected O, but got I
		//IL_0431: Expected O, but got Unknown
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e3->IL03e4: Incompatible stack heights: 3 vs 2
		//IL_042c->IL042c: Incompatible stack heights: 4 vs 5
		//IL_020d->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0440->IL0010: Incompatible stack heights: 2 vs 1
		int num = 13;
		__c__DisplayClass10_0_1 _c__DisplayClass10_0_ = default;
		__c__DisplayClass10_1 _c__DisplayClass10_ = default;
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
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 9;
						}
						_c__DisplayClass10_0_.progress = progress;
						num3 = 15;
						continue;
					case 15:
						if (loUP6Nf08wOPnG4Lm7Oe.sqcf0WA0Zuw(archivePath))
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						_c__DisplayClass10_0_.summary = cBqXHJjlDCU(archivePath, destinationPath, cancellationToken);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 8:
						cI6XHCx6Hr6(_c__DisplayClass10_.CS___8__locals1.progress, _c__DisplayClass10_.plan.TotalBytes, _c__DisplayClass10_.plan.TotalBytes, _c__DisplayClass10_.plan.FileCount, _c__DisplayClass10_.plan.FileCount, _c__DisplayClass10_.extractionEndPercent, _c__DisplayClass10_.verifiesDuringExtraction);
						num3 = 6;
						continue;
					case 9:
						cI6XHCx6Hr6(_c__DisplayClass10_0_.progress, _c__DisplayClass10_0_.summary.TotalBytes, _c__DisplayClass10_0_.summary.TotalBytes, _c__DisplayClass10_0_.summary.FileCount, _c__DisplayClass10_0_.summary.FileCount);
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
						{
							num3 = 14;
						}
						continue;
					case 13:
						break;
					case 4:
						_c__DisplayClass10_.CS___8__locals1 = _c__DisplayClass10_0_;
						num3 = 11;
						continue;
					case 6:
						return _c__DisplayClass10_.verifiesDuringExtraction;
					case 14:
						return false;
					case 1:
						_c__DisplayClass10_.plan = fltqOVf0kLrWqU6qxYRq.iiEf0YQ4SuK(_c__DisplayClass10_.plan, patchManifest);
						num3 = 10;
						continue;
					case 11:
						_c__DisplayClass10_.plan = loUP6Nf08wOPnG4Lm7Oe.aM0f0J28T0s(archivePath, destinationPath, 500000, 17179869184L, 68719476736L, cancellationToken);
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 0;
						}
						continue;
					case 5:
						cI6XHCx6Hr6(_c__DisplayClass10_0_.progress, 0L, _c__DisplayClass10_0_.summary.TotalBytes, 0, _c__DisplayClass10_0_.summary.FileCount);
						num3 = 7;
						continue;
					case 3:
						_c__DisplayClass10_ = (__c__DisplayClass10_1)new __c__DisplayClass10_1();
						num3 = 4;
						continue;
					case 7:
						_c__DisplayClass10_0_.lastNativePercent = -1;
						num3 = 2;
						continue;
					case 0:
						if ((object)patchManifest != null)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 10;
					case 17:
						return false;
					case 12:
						cI6XHCx6Hr6(_c__DisplayClass10_.CS___8__locals1.progress, 0L, _c__DisplayClass10_.plan.TotalBytes, 0, _c__DisplayClass10_.plan.FileCount, _c__DisplayClass10_.extractionEndPercent, _c__DisplayClass10_.verifiesDuringExtraction);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num3 = 2;
						}
						continue;
					case 10:
						_c__DisplayClass10_.verifiesDuringExtraction = (object)patchManifest != null && _c__DisplayClass10_.plan.VerifiedFileCount == (nint)patchManifest.Md5;
						num3 = 18;
						continue;
					case 18:
						_c__DisplayClass10_.extractionEndPercent = (_c__DisplayClass10_.verifiesDuringExtraction ? 98.0 : 82.0);
						num3 = 12;
						continue;
					case 16:
					{
						loUP6Nf08wOPnG4Lm7Oe.D03AJVLckTZErjaSvxTe plan = _c__DisplayClass10_.plan;
						if (_c__DisplayClass10_.CS___8__locals1.progress != null)
						{
							__ldftn(__c__DisplayClass10_1.VyvLLqKVC61);
						}
						else
						{
						}
						loUP6Nf08wOPnG4Lm7Oe.dvlf0Q7drL9(plan, null, cancellationToken);
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 8;
						}
						continue;
					}
					case 2:
					{
						__c__DisplayClass10_0_1 _c__DisplayClass10_0_2;
						if (_c__DisplayClass10_0_.progress != null)
						{
							_c__DisplayClass10_0_2 = _c__DisplayClass10_0_;
						}
						else
						{
							_ = null;
						}
						if (!mYOW63oBtmhmei5nUhA.Oi9olYEgVv(destinationPath, cancellationToken, (CancellationToken)_c__DisplayClass10_0_2, (Action<int>?)(object)__ldftn(__c__DisplayClass10_0_1.GWULL2xxZ50)))
						{
							YKyXHQG80Bc(archivePath, destinationPath, _c__DisplayClass10_0_.summary, _c__DisplayClass10_0_.progress, cancellationToken);
							_ = 17;
						}
						else
						{
							_ = 9;
						}
						continue;
					}
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
			_c__DisplayClass10_0_ = (__c__DisplayClass10_0_1)new __c__DisplayClass10_0_1();
			num = 17;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
			{
				num = 25;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static xdAHnXXHBeS3dgIAsIYi z01XHWk9LAN(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		loUP6Nf08wOPnG4Lm7Oe.D03AJVLckTZErjaSvxTe d03AJVLckTZErjaSvxTe = default;
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
					goto case 2;
				case 1:
					if (!loUP6Nf08wOPnG4Lm7Oe.sqcf0WA0Zuw(archivePath))
					{
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					return (xdAHnXXHBeS3dgIAsIYi)new xdAHnXXHBeS3dgIAsIYi(d03AJVLckTZErjaSvxTe.TotalBytes, d03AJVLckTZErjaSvxTe.FileCount);
				case 0:
					return cBqXHJjlDCU(archivePath, destinationPath, cancellationToken);
				case 3:
					break;
				}
				d03AJVLckTZErjaSvxTe = loUP6Nf08wOPnG4Lm7Oe.aM0f0J28T0s(archivePath, destinationPath, 500000, 17179869184L, 68719476736L, cancellationToken);
				num2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static xdAHnXXHBeS3dgIAsIYi cBqXHJjlDCU(object archivePath, object destinationPath, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void YKyXHQG80Bc(object archivePath, object destinationPath, object summary, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void cI6XHCx6Hr6(IProgress<TNGLHufuZJeliMhnBLZ9>? progress, long extractedBytes, long totalBytes, int entryNumber, int entryCount, double endPercent = 82.0, bool verifiesDuringExtraction = false)
	{
		double num = 72.0 + System.Math.Min(endPercent - 72.0, (double)System.Math.Min(extractedBytes, totalBytes) * (endPercent - 72.0) / (double)totalBytes);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string vsNXH4iGTvr(object destinationPath, string? entryKey)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
							num3 = 2;
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 7;
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
			while (num2 == 990);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lqaIIqZ5cnaBiO2h1iHJ()
	{
		return wgoaaxZ5S1cPAEmuWbW3 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Xli2LmXHSycQMfOwFiRM YwNNd7Z500mQtQ75G55P()
	{
		return (Xli2LmXHSycQMfOwFiRM)wgoaaxZ5S1cPAEmuWbW3;
	}
}

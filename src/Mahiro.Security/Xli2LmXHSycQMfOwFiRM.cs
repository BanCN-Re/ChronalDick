using System;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QplM0bfLb4PwWIsZYhRM;
using SharpCompress.Archives;
using SharpCompress.Readers;
using fDAldojjppXrctUVYOJn;
using juC9IPf0yHbXVIJyU2NU;
using knGiRcfu9DhbMgArQGtn;
using zmRgyMXHgEnjab02Fn1M;

namespace ilOrlDXHcN1uPq9DGB2O;

internal class Xli2LmXHSycQMfOwFiRM
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_36
	{
		public static readonly __c_36 __9;

		public static Func<IArchiveEntry, bool> __9__13_0;

		public static Func<string, bool> __9__15_0;

		internal static __c_36 rjkSR992rsBkHsYXWPey;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_36()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
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
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void GWULL2xxZ50(int percent)
		{
			int num = System.Math.Min(summary.FileCount, (int)System.Math.Ceiling((double)(summary.FileCount * percent) / 100.0));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
			{
				num = 4;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void VyvLLqKVC61(long extractedBytes, int extractedFiles)
		{
			cI6XHCx6Hr6(CS___8__locals1.progress, extractedBytes, plan.TotalBytes, extractedFiles, plan.FileCount, extractionEndPercent, verifiesDuringExtraction);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
			{
				num = 4;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
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
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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
			int num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
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
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
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

	internal static object wgoaaxZ5S1cPAEmuWbW3;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<xdAHnXXHBeS3dgIAsIYi> tlaXH0uT2Qy(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_InspectAsync_d__8 inspectAsync_d__ = default(_InspectAsync_d__8);
		inspectAsync_d__.__t__builder = AsyncTaskMethodBuilder<xdAHnXXHBeS3dgIAsIYi>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<bool> QoEXH8yq92c(object archivePath, object destinationPath, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken, KkXJvSffzM6Jqh09qOWl? patchManifest = null)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ExtractAsync_d__9 extractAsync_d__ = default(_ExtractAsync_d__9);
		extractAsync_d__.__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool PPRXHyjcb1M(object archivePath, object destinationPath, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken, KkXJvSffzM6Jqh09qOWl? patchManifest)
	{
		__c__DisplayClass10_0_1 _c__DisplayClass10_0_ = default(__c__DisplayClass10_0_1);
		cI6XHCx6Hr6(_c__DisplayClass10_0_.progress, _c__DisplayClass10_0_.summary.TotalBytes, _c__DisplayClass10_0_.summary.TotalBytes, _c__DisplayClass10_0_.summary.FileCount, _c__DisplayClass10_0_.summary.FileCount);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static xdAHnXXHBeS3dgIAsIYi z01XHWk9LAN(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		loUP6Nf08wOPnG4Lm7Oe.D03AJVLckTZErjaSvxTe d03AJVLckTZErjaSvxTe = loUP6Nf08wOPnG4Lm7Oe.aM0f0J28T0s(archivePath, destinationPath, 500000, 17179869184L, 68719476736L, cancellationToken);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static xdAHnXXHBeS3dgIAsIYi cBqXHJjlDCU(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_05ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fd: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		IArchive val = default(IArchive);
		int num7 = default(int);
		IArchiveEntry val2 = default(IArchiveEntry);
		int num6 = default(int);
		xdAHnXXHBeS3dgIAsIYi result = default(xdAHnXXHBeS3dgIAsIYi);
		int num9 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 1:
					try
					{
						IArchiveEntry[] array = Enumerable.ToArray<IArchiveEntry>((val).Entries);
						if (array.Length == 0)
						{
							throw new InvalidDataException("客户端压缩包内容为空");
						}
						if (array.Length > 500000)
						{
							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 1);
							(defaultInterpolatedStringHandler).AppendLiteral("客户端压缩包文件数量超过 ");
							defaultInterpolatedStringHandler.AppendFormatted<int>(500000, "N0");
							(defaultInterpolatedStringHandler).AppendLiteral(" 个");
							throw new InvalidDataException((defaultInterpolatedStringHandler).ToStringAndClear());
						}
						long num3 = 0L;
						int num4 = 0;
						IArchiveEntry[] array2 = array;
						int num5 = 2;
						while (true)
						{
							switch (num5)
							{
							default:
								if (num7 != 30)
								{
									if (num7 == 1010)
									{
										goto IL_0134;
									}
									goto case 16;
								}
								if ((val2).IsDirectory)
								{
									num5 = 7;
									continue;
								}
								goto case 6;
							case 2:
								num6 = 0;
								num5 = 14;
								continue;
							case 0:
							case 8:
								val2 = array2[num6];
								num5 = 22;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num5 = 8;
								}
								continue;
							case 7:
							case 10:
								num6++;
								num5 = 21;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
								{
									num5 = 12;
								}
								continue;
							case 3:
								throw new InvalidDataException("客户端压缩包不包含文件");
							case 21:
								if (string.IsNullOrWhiteSpace((val2).LinkTarget))
								{
									num7 = 30;
									goto IL_0134;
								}
								goto case 19;
							case 20:
								if (num4 != 0)
								{
									result = (xdAHnXXHBeS3dgIAsIYi)new xdAHnXXHBeS3dgIAsIYi(num3, num4);
									num5 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
									{
										num5 = 12;
									}
								}
								else
								{
									num5 = 3;
								}
								continue;
							case 15:
								throw new InvalidDataException("客户端压缩包不能包含加密文件");
							case 19:
								throw new InvalidDataException("客户端压缩包不能包含符号链接");
							case 9:
								throw new InvalidDataException("客户端压缩包解压后体积超过限制");
							case 13:
								num4++;
								num5 = 10;
								continue;
							case 16:
								if (num3 <= 68719476736L)
								{
									num5 = 13;
									continue;
								}
								goto case 9;
							case 17:
								vsNXH4iGTvr(destinationPath, (val2).Key);
								num5 = 21;
								continue;
							case 6:
								if (!(val2).IsEncrypted)
								{
									if ((val2).Size < 0)
									{
										num5 = 5;
										continue;
									}
									goto case 18;
								}
								num5 = 15;
								continue;
							case 4:
							case 5:
								throw new InvalidDataException("客户端压缩包包含超大单文件");
							case 1:
								num3 = checked(num3 + (val2).Size);
								num5 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
								{
									num5 = 16;
								}
								continue;
							case 22:
								(cancellationToken).ThrowIfCancellationRequested();
								num5 = 17;
								continue;
							case 12:
							case 14:
								if (num6 < array2.Length)
								{
									num5 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num5 = 30;
									}
									continue;
								}
								goto case 20;
							case 18:
								if ((val2).Size <= 17179869184L)
								{
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
									{
										num5 = 5;
									}
									continue;
								}
								goto case 4;
							case 11:
								break;
								IL_0134:
								num5 = num7;
								continue;
							}
							break;
						}
					}
					finally
					{
						int num8;
						if (val == null)
						{
							num8 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
							{
								num8 = 2;
							}
							goto IL_0557;
						}
						goto IL_059f;
						IL_0557:
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 == 990)
								{
									goto IL_0553;
								}
								goto end_IL_0557;
							case 2:
								goto end_IL_0557;
							case 0:
								break;
							case 1:
								goto end_IL_0557;
							}
							goto IL_059f;
							IL_0553:
							num8 = num9;
							continue;
							end_IL_0557:
							break;
						}
						goto end_IL_051f;
						IL_059f:
						(val).Dispose();
						num8 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num8 = 2;
						}
						goto IL_0557;
						end_IL_051f:;
					}
					goto case 0;
				case 0:
					return result;
				case 2:
					val = SharpCompress.Archives.ArchiveFactory.OpenArchive((string)archivePath, new ReaderOptions());
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
					{
						num2 = 1;
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
	private static void YKyXHQG80Bc(object archivePath, object destinationPath, object summary, IProgress<TNGLHufuZJeliMhnBLZ9>? progress, CancellationToken cancellationToken)
	{
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0739: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		int num = 1;
		IArchive val = default(IArchive);
		string text2 = default(string);
		IArchiveEntry val4 = default(IArchiveEntry);
		long num10 = default(long);
		int num8 = default(int);
		int num15 = default(int);
		long num13 = default(long);
		long num6 = default(long);
		int num16 = default(int);
		long num12 = default(long);
		int num11 = default(int);
		Stream val3 = default(Stream);
		byte[] array2 = default(byte[]);
		int num18 = default(int);
		int num20 = default(int);
		string text = default(string);
		int num22 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 0:
					try
					{
						IArchiveEntry[] array = Enumerable.ToArray<IArchiveEntry>(Enumerable.Where<IArchiveEntry>((val).Entries, (Func<IArchiveEntry, bool>)([MethodImpl((MethodImplOptions)8)] (IArchiveEntry entry) => !(entry).IsDirectory)));
						int num3 = 16;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									default:
										if (num4 != 24)
										{
											if (num4 == 1004)
											{
												goto end_IL_008b;
											}
											goto case 0;
										}
										text2 = vsNXH4iGTvr(destinationPath, (val4).Key);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
										{
											num5 = 23;
										}
										continue;
									case 5:
										(cancellationToken).ThrowIfCancellationRequested();
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num5 = 18;
										}
										continue;
									case 9:
										num10 = 0L;
										num5 = 7;
										continue;
									case 12:
										try
										{
											FileStream val2 = new FileStream(text2, (FileMode)2, (FileAccess)2, (FileShare)0, 131072, (FileOptions)134217728);
											int num7 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
											{
												num7 = 6;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 == 988)
													{
														goto IL_0172;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_0172:
												num7 = num8;
											}
											try
											{
												while (true)
												{
													IL_0193:
													(cancellationToken).ThrowIfCancellationRequested();
													int num9 = 6;
													while (true)
													{
														switch (num9)
														{
														default:
															if (num15 != 18)
															{
																if (num15 == 998)
																{
																	goto IL_01b7;
																}
																goto case 7;
															}
															break;
														case 5:
															if (num13 - num6 >= 250)
															{
																num9 = 10;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
																{
																	num9 = 4;
																}
																continue;
															}
															break;
														case 10:
															cI6XHCx6Hr6(progress, num10, ((xdAHnXXHBeS3dgIAsIYi)summary).TotalBytes, num16 + 1, ((xdAHnXXHBeS3dgIAsIYi)summary).FileCount);
															num9 = 16;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
															{
																num9 = 7;
															}
															continue;
														case 7:
															num12 = num10;
															num9 = 9;
															continue;
														case 6:
															num11 = (val3).Read(array2, 0, array2.Length);
															num9 = 16;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
															{
																num9 = 0;
															}
															continue;
														case 1:
															if (num10 - num12 < 4194304)
															{
																num9 = 5;
																continue;
															}
															goto case 10;
														case 8:
															num13 = System.Environment.TickCount64;
															num9 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
															{
																num9 = 14;
															}
															continue;
														case 9:
														{
															num6 = num13;
															int num14 = 7;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
															{
																num14 = 18;
															}
															num15 = num14;
															goto IL_01b7;
														}
														case 0:
															if (num11 == 0)
															{
																num9 = 3;
																continue;
															}
															goto case 4;
														case 4:
															(val2).Write(array2, 0, num11);
															num9 = 2;
															continue;
														case 3:
															goto end_IL_01bb;
														case 2:
															{
																num10 += num11;
																num9 = 8;
																continue;
															}
															IL_01b7:
															num9 = num15;
															continue;
														}
														goto IL_0193;
														continue;
														end_IL_01bb:
														break;
													}
													break;
												}
											}
											finally
											{
												if (val2 != null)
												{
													int num17 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
													{
														num17 = 7;
													}
													while (true)
													{
														switch (num17)
														{
														default:
															if (num18 == 989)
															{
																num17 = num18;
																continue;
															}
															break;
														case 0:
															break;
														case 1:
															goto end_IL_03c6;
														}
														(val2).Dispose();
														num17 = 7;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
														{
															num17 = 1;
														}
														continue;
														end_IL_03c6:
														break;
													}
												}
											}
										}
										finally
										{
											int num19;
											if (val3 == null)
											{
												num19 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
												{
													num19 = 0;
												}
												goto IL_044a;
											}
											goto IL_046e;
											IL_044a:
											while (true)
											{
												switch (num19)
												{
												default:
													if (num20 == 990)
													{
														goto IL_0446;
													}
													goto end_IL_044a;
												case 1:
													break;
												case 0:
													goto end_IL_044a;
												case 2:
													goto end_IL_044a;
												}
												goto IL_046e;
												IL_0446:
												num19 = num20;
												continue;
												end_IL_044a:
												break;
											}
											goto end_IL_0412;
											IL_046e:
											(val3).Dispose();
											num19 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
											{
												num19 = 2;
											}
											goto IL_044a;
											end_IL_0412:;
										}
										goto case 13;
									case 2:
										num6 = System.Environment.TickCount64;
										num3 = 15;
										break;
									case 0:
										val4 = array[num16];
										num3 = 24;
										break;
									case 13:
										num16++;
										num5 = 3;
										continue;
									case 3:
									case 6:
										if (num16 >= array.Length)
										{
											num5 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
											{
												num5 = 22;
											}
											continue;
										}
										goto case 5;
									case 10:
										System.IO.Directory.CreateDirectory(text);
										num5 = 11;
										continue;
									case 16:
										array2 = new byte[131072];
										num5 = 9;
										continue;
									case 11:
										val3 = (val4).OpenEntryStream();
										num3 = 12;
										break;
									case 4:
										cI6XHCx6Hr6(progress, num10, ((xdAHnXXHBeS3dgIAsIYi)summary).TotalBytes, ((xdAHnXXHBeS3dgIAsIYi)summary).FileCount, ((xdAHnXXHBeS3dgIAsIYi)summary).FileCount);
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
										{
											num5 = 14;
										}
										continue;
									case 15:
										num16 = 0;
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
										{
											num5 = 19;
										}
										continue;
									case 1:
										text = System.IO.Path.GetDirectoryName(text2);
										num5 = 8;
										continue;
									case 7:
										num12 = 0L;
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
										{
											num5 = 6;
										}
										continue;
									case 8:
										if (!string.IsNullOrWhiteSpace(text))
										{
											num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
											{
												num5 = 10;
											}
											continue;
										}
										goto case 11;
									case 14:
										return;
									}
									goto end_IL_0087;
									continue;
									end_IL_008b:
									break;
								}
								continue;
								end_IL_0087:
								break;
							}
						}
					}
					finally
					{
						if (val != null)
						{
							int num21 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
							{
								num21 = 0;
							}
							while (true)
							{
								switch (num21)
								{
								default:
									if (num22 == 989)
									{
										num21 = num22;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_06bd;
								}
								(val).Dispose();
								num21 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
								{
									num21 = 0;
								}
								continue;
								end_IL_06bd:
								break;
							}
						}
					}
				case 2:
					return;
				case 1:
					break;
				}
				goto IL_0729;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0729;
				IL_0729:
				val = SharpCompress.Archives.ArchiveFactory.OpenArchive((string)archivePath, new ReaderOptions());
				num2 = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void cI6XHCx6Hr6(IProgress<TNGLHufuZJeliMhnBLZ9>? progress, long extractedBytes, long totalBytes, int entryNumber, int entryCount, double endPercent = 82.0, bool verifiesDuringExtraction = false)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 2);
		(defaultInterpolatedStringHandler).AppendLiteral("正在并行解压并校验客户端（");
		defaultInterpolatedStringHandler.AppendFormatted<int>(System.Math.Min(entryNumber, entryCount));
		(defaultInterpolatedStringHandler).AppendLiteral("/");
		defaultInterpolatedStringHandler.AppendFormatted<int>(entryCount);
		(defaultInterpolatedStringHandler).AppendLiteral("）");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string vsNXH4iGTvr(object destinationPath, string? entryKey)
	{
		string text = string.Concat(((System.ReadOnlySpan<char>)(System.IO.Path.GetFullPath((string)destinationPath)).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		})), new global::System.ReadOnlySpan<char>(new char[] { Path.DirectorySeparatorChar }));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

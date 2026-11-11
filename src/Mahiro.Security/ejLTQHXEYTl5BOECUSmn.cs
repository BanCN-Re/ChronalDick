using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OZyca1RHlSLf9TUIBo1;
using SharpCompress.Archives;
using SharpCompress.Readers;
using fDAldojjppXrctUVYOJn;
using iUvcWjR7kFMiLwhnTbh;
using nD7M11Ctrybnsbu308r;

namespace sFE4DTXESph7AqQHKoHx;

internal class ejLTQHXEYTl5BOECUSmn
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass1_0_2
	{
		public string archivePath;

		public string destinationPath;

		public CancellationToken cancellationToken;

		private static __c__DisplayClass1_0_2 MMD4AAD9B6apSCIKTBCf;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass1_0_2()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
			{
				num = 5;
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
		internal void dL0LkjEGlQO()
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			WK9XE06SHHF(archivePath, destinationPath, cancellationToken);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Ixq908D9gNWQFRF1w1ge()
		{
			return MMD4AAD9B6apSCIKTBCf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass1_0_2 ShK0qiD9lU8U9yYUHutl()
		{
			return MMD4AAD9B6apSCIKTBCf;
		}
	}

	private static object unQhGUZxks0QNP8Ht8UP;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Threading.Tasks.Task urHXEcOOqGn(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		object _c__DisplayClass1_0_ = (object)new __c__DisplayClass1_0_2();
		((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).archivePath = (string)archivePath;
		((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).destinationPath = (string)destinationPath;
		((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).cancellationToken = cancellationToken;
		return System.Threading.Tasks.Task.Run((Action)([MethodImpl((MethodImplOptions)8)] () =>
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			WK9XE06SHHF(((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).archivePath, ((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).destinationPath, ((__c__DisplayClass1_0_2)_c__DisplayClass1_0_).cancellationToken);
		}), System.Threading.CancellationToken.None);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void WK9XE06SHHF(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		int num = 9;
		FileStream val = default(FileStream);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		global::System.Span<byte> span2 = default(global::System.Span<byte>);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 7;
						}
						val = System.IO.File.OpenRead((string)archivePath);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
						{
							num3 = 11;
						}
						continue;
					case 11:
						if (MemoryExtensions.StartsWith<byte>(span, (global::System.ReadOnlySpan<byte>)new byte[6] { 55, 122, 188, 175, 39, 28 }))
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 5;
					case 5:
						throw new InvalidDataException("材质包文件不是有效的 ZIP、RAR 或 7z 压缩包。请重新下载完整文件；已解压的材质包请使用“导入文件夹”。");
					case 0:
						kK1XE8JdtqT(archivePath, destinationPath, cancellationToken);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
						{
							num3 = 4;
						}
						continue;
					case 8:
						span2 = new byte[8];
						num = 19;
						break;
					case 9:
						(cancellationToken).ThrowIfCancellationRequested();
						num3 = 8;
						continue;
					case 1:
						try
						{
							num4 = (val).ReadAtLeast(span2, span2.Length, false);
							int num5 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										num5 = num6;
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
							int num7;
							if (val == null)
							{
								num7 = 2;
								goto IL_01f2;
							}
							goto IL_023a;
							IL_023a:
							(val).Dispose();
							num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
							{
								num7 = 0;
							}
							goto IL_01f2;
							IL_01f2:
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										goto IL_01ee;
									}
									break;
								case 2:
									goto end_IL_01f2;
								case 1:
									break;
								case 0:
									goto end_IL_01f2;
								}
								goto IL_023a;
								IL_01ee:
								num7 = num8;
								continue;
								end_IL_01f2:
								break;
							}
						}
						goto case 2;
					case 2:
						span = span2.Slice(0, num4);
						num3 = 6;
						continue;
					case 4:
						return;
					case 10:
						return;
					case 7:
						if (!MemoryExtensions.StartsWith<byte>(span, (global::System.ReadOnlySpan<byte>)new byte[4] { 80, 75, 5, 6 }))
						{
							if (!MemoryExtensions.StartsWith<byte>(span, (global::System.ReadOnlySpan<byte>)new byte[6] { 82, 97, 114, 33, 26, 7 }))
							{
								num3 = 11;
								continue;
							}
							goto case 0;
						}
						num3 = 3;
						continue;
					case 6:
						if (MemoryExtensions.StartsWith<byte>(span, (global::System.ReadOnlySpan<byte>)new byte[4] { 80, 75, 3, 4 }))
						{
							num = 12;
							break;
						}
						goto case 7;
					case 3:
					case 12:
						D35396CHyd2tBBEjhq6.vFSCOZb3nH(archivePath, destinationPath, wOBaeZRKpDHEao6bEkd.MaterialPack, cancellationToken);
						num3 = 10;
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
	private static void kK1XE8JdtqT(object archivePath, object destinationPath, CancellationToken cancellationToken)
	{
		//IL_0d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_091a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_065d: Unknown result type (might be due to invalid IL or missing references)
		//IL_069f: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num22 = default(int);
		int num19 = default(int);
		IArchiveEntry[] array3 = default(IArchiveEntry[]);
		long num7 = default(long);
		IArchiveEntry val5 = default(IArchiveEntry);
		int num16 = default(int);
		Stream val4 = default(Stream);
		IArchiveEntry val2 = default(IArchiveEntry);
		string text = default(string);
		byte[] array2 = default(byte[]);
		int num13 = default(int);
		int num9 = default(int);
		int num8 = default(int);
		wOBaeZRKpDHEao6bEkd materialPack = default(wOBaeZRKpDHEao6bEkd);
		int num12 = default(int);
		int num15 = default(int);
		long num18 = default(long);
		HashSet<string> val6 = default(HashSet<string>);
		string text2 = default(string);
		int num21 = default(int);
		int num24 = default(int);
		int num26 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num27);
		global::System.Exception ex3 = default(global::System.Exception);
		int num28 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num30 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					IArchive val = SharpCompress.Archives.ArchiveFactory.OpenArchive((string)archivePath, new ReaderOptions());
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
					{
						num2 = 7;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num22 != 989)
							{
								return;
							}
							break;
						case 1:
							try
							{
								IArchiveEntry[] array = Enumerable.ToArray<IArchiveEntry>((val).Entries);
								int num3 = 22;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
								{
									num3 = 27;
								}
								while (true)
								{
									int num17;
									switch (num3)
									{
									default:
										if (num19 != 46)
										{
											if (num19 == 1026)
											{
												goto IL_00d5;
											}
											goto case 23;
										}
										array3 = array;
										num3 = 9;
										break;
									case 13:
										num7 = 0L;
										num3 = 24;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
										{
											num3 = 4;
										}
										break;
									case 34:
										val5 = array3[num16];
										num3 = 35;
										break;
									case 33:
										val4 = (val2).OpenEntryStream();
										num3 = 19;
										break;
									case 23:
										(cancellationToken).ThrowIfCancellationRequested();
										num3 = 38;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
										{
											num3 = 46;
										}
										break;
									case 14:
										throw new InvalidDataException("材质包压缩包不能包含符号链接");
									case 35:
										(cancellationToken).ThrowIfCancellationRequested();
										num3 = 12;
										break;
									case 27:
										if ((val2).IsDirectory)
										{
											num3 = 28;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
											{
												num3 = 23;
											}
											break;
										}
										goto case 31;
									case 29:
										throw new InvalidDataException("材质包压缩包不能包含加密文件");
									case 25:
										if ((val5).Size >= 0)
										{
											num3 = 31;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
											{
												num3 = 0;
											}
											break;
										}
										goto case 10;
									case 26:
										array3 = array;
										num3 = 7;
										break;
									case 31:
										System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(text));
										num3 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
										{
											num3 = 33;
										}
										break;
									case 6:
										val2 = array3[num16];
										num3 = 23;
										break;
									case 9:
										num16 = 0;
										num3 = 30;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
										{
											num3 = 1;
										}
										break;
									case 24:
										array2 = new byte[131072];
										num3 = 26;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
										{
											num3 = 32;
										}
										break;
									case 8:
										throw new InvalidDataException("材质包压缩包包含重复路径");
									case 19:
										checked
										{
											try
											{
												FileStream val3 = new FileStream(text, (FileMode)1, (FileAccess)2, (FileShare)0, 131072, (FileOptions)134217728);
												int num4 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
												{
													num4 = 0;
												}
												while (true)
												{
													switch (num4)
													{
													default:
														if (num13 == 989)
														{
															goto IL_0446;
														}
														break;
													case 0:
														try
														{
															long num5 = 0L;
															int num6 = 7;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
															{
																num6 = 3;
															}
															while (true)
															{
																int num10;
																switch (num6)
																{
																default:
																	if (num9 != 18 && num9 == 998)
																	{
																		goto IL_049c;
																	}
																	goto case 7;
																case 3:
																case 6:
																	if ((num8 = (val4).Read(array2, 0, array2.Length)) != 0)
																	{
																		num10 = 18;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
																		{
																			num10 = 15;
																		}
																		goto IL_0498;
																	}
																	goto case 2;
																case 2:
																	if (num5 != (val2).Size)
																	{
																		num6 = 10;
																		break;
																	}
																	goto end_IL_04a0;
																case 7:
																	(cancellationToken).ThrowIfCancellationRequested();
																	num10 = 5;
																	goto IL_0498;
																case 8:
																	if (num5 <= materialPack.MaximumEntryBytes)
																	{
																		num10 = 4;
																		goto IL_0498;
																	}
																	goto case 1;
																case 9:
																	num7 += num8;
																	num6 = 10;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																	{
																		num6 = 0;
																	}
																	break;
																case 5:
																	num5 += num8;
																	num6 = 9;
																	break;
																case 0:
																	if (num5 <= (val2).Size)
																	{
																		num6 = 17;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
																		{
																			num6 = 8;
																		}
																		break;
																	}
																	goto case 1;
																case 4:
																	if (num7 > materialPack.MaximumExpandedBytes)
																	{
																		num6 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
																		{
																			num6 = 10;
																		}
																	}
																	else
																	{
																		(val3).Write(array2, 0, num8);
																		num6 = 6;
																	}
																	break;
																case 1:
																	throw new InvalidDataException("材质包压缩包实际解压大小超过限制或与文件记录不符");
																case 10:
																	{
																		throw new InvalidDataException("材质包压缩包文件不完整，请重新下载后导入");
																	}
																	IL_049c:
																	num6 = num9;
																	break;
																	IL_0498:
																	num9 = num10;
																	goto IL_049c;
																}
																continue;
																end_IL_04a0:
																break;
															}
														}
														finally
														{
															if (val3 != null)
															{
																int num11 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
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
																		goto end_IL_06e2;
																	}
																	(val3).Dispose();
																	num11 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
																	{
																		num11 = 3;
																	}
																	continue;
																	end_IL_06e2:
																	break;
																}
															}
														}
														break;
													case 1:
														break;
													}
													break;
													IL_0446:
													num4 = num13;
												}
											}
											finally
											{
												if (val4 != null)
												{
													int num14 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
													{
														num14 = 7;
													}
													while (true)
													{
														switch (num14)
														{
														default:
															if (num15 == 989)
															{
																num14 = num15;
																continue;
															}
															break;
														case 1:
															break;
														case 0:
															goto end_IL_078a;
														}
														(val4).Dispose();
														num14 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
														{
															num14 = 0;
														}
														continue;
														end_IL_078a:
														break;
													}
												}
											}
											goto case 2;
										}
									case 4:
									case 32:
										if (num16 >= array3.Length)
										{
											num3 = 27;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num3 = 37;
											}
											break;
										}
										goto case 6;
									case 22:
										materialPack = wOBaeZRKpDHEao6bEkd.MaterialPack;
										num3 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
										{
											num3 = 29;
										}
										break;
									case 20:
										num18 = 0L;
										num17 = 46;
										goto IL_00d1;
									case 21:
										if (array.Length > materialPack.MaximumEntryCount)
										{
											num3 = 17;
											break;
										}
										val6 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
										num3 = 20;
										break;
									case 2:
									case 30:
										num16++;
										num3 = 4;
										break;
									case 0:
										if ((val5).Size <= materialPack.MaximumEntryBytes)
										{
											num3 = 16;
											break;
										}
										goto case 10;
									case 17:
										throw new InvalidDataException("材质包压缩包内容为空或文件数量超过限制");
									case 5:
										throw new InvalidDataException("材质包压缩包解压后体积超过限制");
									case 18:
										num16++;
										num3 = 36;
										break;
									case 28:
										System.IO.Directory.CreateDirectory(text);
										num3 = 2;
										break;
									case 3:
										if (num18 <= materialPack.MaximumExpandedBytes)
										{
											num3 = 18;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
											{
												num3 = 45;
											}
											break;
										}
										goto case 5;
									case 15:
										if (array.Length != 0)
										{
											num3 = 21;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
											{
												num3 = 23;
											}
											break;
										}
										goto case 17;
									case 10:
										throw new InvalidDataException("材质包压缩包包含超大单文件");
									case 16:
										num18 = checked(num18 + (val5).Size);
										num3 = 3;
										break;
									case 1:
									case 36:
										if (num16 >= array3.Length)
										{
											num3 = 13;
											break;
										}
										goto case 34;
									case 7:
										num16 = 0;
										num17 = 32;
										goto IL_00d1;
									case 11:
										if (val6.Add(text2))
										{
											if (string.IsNullOrWhiteSpace((val5).LinkTarget))
											{
												if (!(val5).IsEncrypted)
												{
													num3 = 25;
													break;
												}
												goto case 29;
											}
											num3 = 14;
											break;
										}
										num3 = 8;
										break;
									case 12:
										text2 = tB4TtRRmIMqW0EPX3jQ.S7gRBZpSMa(destinationPath, (val5).Key ?? string.Empty);
										num3 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num3 = 10;
										}
										break;
									case 38:
										text = tB4TtRRmIMqW0EPX3jQ.S7gRBZpSMa(destinationPath, (val2).Key ?? string.Empty);
										num3 = 27;
										break;
									case 37:
										return;
										IL_00d1:
										num19 = num17;
										goto IL_00d5;
										IL_00d5:
										num3 = num19;
										break;
									}
								}
							}
							finally
							{
								int num20;
								if (val == null)
								{
									num20 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
									{
										num20 = 1;
									}
									goto IL_0ad9;
								}
								goto IL_0afd;
								IL_0ad9:
								while (true)
								{
									switch (num20)
									{
									default:
										if (num21 == 990)
										{
											goto IL_0ad5;
										}
										break;
									case 2:
										break;
									case 1:
										goto end_IL_0ad9;
									case 0:
										goto end_IL_0ad9;
									}
									goto IL_0afd;
									IL_0ad5:
									num20 = num21;
									continue;
									end_IL_0ad9:
									break;
								}
								goto end_IL_0aa1;
								IL_0afd:
								(val).Dispose();
								num20 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
								{
									num20 = 7;
								}
								goto IL_0ad9;
								end_IL_0aa1:;
							}
						case 0:
							return;
						}
						num2 = num22;
					}
				}
				catch (OperationCanceledException)
				{
					int num23 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
					{
						num23 = 3;
					}
					while (true)
					{
						switch (num23)
						{
						default:
							if (num24 == 988)
							{
								goto IL_0b9f;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0b9f:
						num23 = num24;
					}
					throw;
				}
				catch (InvalidDataException)
				{
					int num25 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
					{
						num25 = 0;
					}
					while (true)
					{
						switch (num25)
						{
						default:
							if (num26 == 988)
							{
								goto IL_0bef;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0bef:
						num25 = num26;
					}
					throw;
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num27 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num27 = 1;
						}
					}
					else
					{
						ex3 = obj2;
						num27 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
						{
							num27 = 0;
						}
					}
					while (true)
					{
						switch (num27)
						{
						default:
							if (num28 == 989)
							{
								goto IL_0c4f;
							}
							goto case 0;
						case 1:
							result = 0;
							break;
						case 0:
							result = ((!(ex3 is UnauthorizedAccessException)) ? 1 : 0);
							break;
						}
						break;
						IL_0c4f:
						num27 = num28;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num29 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
					{
						num29 = 0;
					}
					while (true)
					{
						switch (num29)
						{
						default:
							if (num30 == 988)
							{
								goto IL_0cda;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0cda:
						num29 = num30;
					}
					throw new InvalidDataException("材质包压缩包无法读取或解压，请确认文件完整且未加密；也可以完整解压后使用“导入文件夹”。", ex3);
				}
			default:
				return;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Qi8JH9ZxVq72qmGsK9aP()
	{
		return unQhGUZxks0QNP8Ht8UP == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ejLTQHXEYTl5BOECUSmn lHGhwZZxYK0JEYuF2pJs()
	{
		return (ejLTQHXEYTl5BOECUSmn)unQhGUZxks0QNP8Ht8UP;
	}
}

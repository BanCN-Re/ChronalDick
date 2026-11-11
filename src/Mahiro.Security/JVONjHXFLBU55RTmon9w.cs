using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using mqSxymXxirA01jCDGieJ;

namespace HrGmidXFjqZ3VHjOCF1H;

internal class JVONjHXFLBU55RTmon9w
{
	[CompilerGenerated]
	private class __O_11
	{
		public static Func<string, bool> _0___IsNullOrWhiteSpace;

		public static Func<string, bool> _1___IsNestedArchive;

		private static __O_11 ae6AwuDb36UVJ2J1QLjS;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool MWFfRKDbvXoK0c4tBSav()
		{
			return ae6AwuDb36UVJ2J1QLjS == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_11 O1rogbDbEfoXDh3gvKLH()
		{
			return ae6AwuDb36UVJ2J1QLjS;
		}
	}

	internal static object JepxpAZRISxc2AlwMrUr;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<nQIdMjXxGGtHBfhuOHIF> bD9XFZCfD2S(object inputArchivePath, object outputArchivePath, global::System.Collections.Generic.IReadOnlyList<string> itemIds, object reader, IProgress<string>? progress, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_DecryptAsync_d__3 decryptAsync_d__ = default(_DecryptAsync_d__3);
		decryptAsync_d__.__t__builder = AsyncTaskMethodBuilder<nQIdMjXxGGtHBfhuOHIF>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void woKXF9RmhrB(object archivePath, CancellationToken cancellationToken)
	{
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		long num5 = default(long);
		int num10 = default(int);
		global::System.Collections.Generic.IEnumerator<ZipArchiveEntry> enumerator = default(global::System.Collections.Generic.IEnumerator<ZipArchiveEntry>);
		int num7 = default(int);
		ZipArchiveEntry current = default(ZipArchiveEntry);
		int num9 = default(int);
		int num12 = default(int);
		int num14 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		global::System.Exception ex2 = default(global::System.Exception);
		int num16 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num18 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					ZipArchive val = System.IO.Compression.ZipFile.OpenRead((string)archivePath);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
					{
						num2 = 4;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								goto IL_006c;
							}
							break;
						case 1:
							break;
						}
						break;
						IL_006c:
						num2 = num3;
					}
					try
					{
						int num4;
						if ((val).Entries.Count > 100000)
						{
							num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num4 = 0;
							}
						}
						else
						{
							num5 = 0L;
							num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
							{
								num4 = 3;
							}
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
								return;
							default:
								if (num10 == 991)
								{
									num4 = num10;
									continue;
								}
								break;
							case 0:
								throw new InvalidDataException("ZIP 文件条目数量超过安全限制");
							case 1:
								try
								{
									while (true)
									{
										int num6;
										if (!(enumerator).MoveNext())
										{
											num6 = 7;
											goto IL_016b;
										}
										goto IL_02b8;
										IL_016b:
										while (true)
										{
											switch (num6)
											{
											case 7:
												return;
											default:
												if (num7 == 17)
												{
													goto end_IL_016b;
												}
												if (num7 == 997)
												{
													goto IL_0167;
												}
												goto case 5;
											case 5:
												if (num5 <= 2147483648u - (current).Length)
												{
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
													{
														num6 = 2;
													}
													continue;
												}
												goto case 2;
											case 8:
												if ((current).Length > 2147483648u)
												{
													num6 = 2;
													continue;
												}
												goto case 5;
											case 4:
												(cancellationToken).ThrowIfCancellationRequested();
												num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
												{
													num6 = 6;
												}
												continue;
											case 1:
												if ((current).Length < 0)
												{
													num6 = 9;
													continue;
												}
												goto case 8;
											case 6:
												break;
											case 2:
											case 3:
											case 9:
												throw new InvalidDataException("ZIP 解压后总大小超过 2 GiB 限制");
											case 0:
												{
													num5 += (current).Length;
													num7 = 17;
													goto IL_0167;
												}
												IL_0167:
												num6 = num7;
												continue;
											}
											goto IL_02b8;
											continue;
											end_IL_016b:
											break;
										}
										continue;
										IL_02b8:
										current = enumerator.Current;
										num6 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
										{
											num6 = 15;
										}
										goto IL_016b;
									}
								}
								finally
								{
									int num8;
									if (enumerator == null)
									{
										num8 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
										{
											num8 = 2;
										}
										goto IL_035f;
									}
									goto IL_0383;
									IL_035f:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_035b;
											}
											goto end_IL_035f;
										case 0:
											break;
										case 2:
											goto end_IL_035f;
										case 1:
											goto end_IL_035f;
										}
										goto IL_0383;
										IL_035b:
										num8 = num9;
										continue;
										end_IL_035f:
										break;
									}
									goto end_IL_0327;
									IL_0383:
									(enumerator).Dispose();
									num8 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
									{
										num8 = 1;
									}
									goto IL_035f;
									end_IL_0327:;
								}
							case 3:
								break;
							}
							enumerator = (val).Entries.GetEnumerator();
							num4 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num4 = 1;
							}
						}
					}
					finally
					{
						if (val != null)
						{
							int num11 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
							{
								num11 = 0;
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
								case 0:
									(val).Dispose();
									num11 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
									{
										num11 = 3;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
				catch (InvalidDataException)
				{
					int num13 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
					{
						num13 = 6;
					}
					while (true)
					{
						switch (num13)
						{
						default:
							if (num14 == 988)
							{
								goto IL_04ff;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_04ff:
						num13 = num14;
					}
					throw;
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num15 = 4;
					}
					else
					{
						ex2 = obj2;
						num15 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
						{
							num15 = 0;
						}
					}
					while (true)
					{
						switch (num15)
						{
						default:
							if (num16 != 14)
							{
								if (num16 == 994)
								{
									goto IL_054a;
								}
								goto case 1;
							}
							goto case 6;
						case 3:
							flag = true;
							num16 = 14;
							goto IL_054a;
						case 5:
							if (!(ex2 is UnauthorizedAccessException))
							{
								num15 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num15 = 1;
								}
								continue;
							}
							goto case 3;
						case 0:
							if (!(ex2 is IOException))
							{
								num15 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
								{
									num15 = 2;
								}
								continue;
							}
							goto case 3;
						case 1:
						case 2:
							flag = false;
							num15 = 6;
							continue;
						case 4:
							result = 0;
							break;
						case 6:
							{
								result = (flag ? 1 : 0);
								break;
							}
							IL_054a:
							num15 = num16;
							continue;
						}
						break;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num17 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
					{
						num17 = 1;
					}
					while (true)
					{
						switch (num17)
						{
						default:
							if (num18 == 988)
							{
								goto IL_068f;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_068f:
						num17 = num18;
					}
					throw new InvalidDataException("选择的文件不是有效 ZIP 或无法读取", ex2);
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<global::System.Collections.Generic.IReadOnlyList<string>> t41XFDfxd2f(object root, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_FindEncryptedFilesAsync_d__5 findEncryptedFilesAsync_d__ = default(_FindEncryptedFilesAsync_d__5);
		findEncryptedFilesAsync_d__.__t__builder = AsyncTaskMethodBuilder<global::System.Collections.Generic.IReadOnlyList<string>>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<bool> Q03XFkamXgW(object root, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ContainsEncryptedFileAsync_d__6 containsEncryptedFileAsync_d__ = default(_ContainsEncryptedFileAsync_d__6);
		containsEncryptedFileAsync_d__.__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool fDEXFVlx7qY(object path)
	{
		string text = System.IO.Path.GetExtension((string)path);
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task YqAXFYpvByk(object sourceDirectory, object outputPath, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_CreateOutputArchiveAsync_d__8 createOutputArchiveAsync_d__ = default(_CreateOutputArchiveAsync_d__8);
		createOutputArchiveAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void XgAXFSDv4Ae(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				int num2;
				if (!System.IO.File.Exists((string)path))
				{
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
					{
						num2 = 0;
					}
					goto IL_0072;
				}
				goto IL_00a5;
				IL_0072:
				while (true)
				{
					switch (num2)
					{
					default:
						if (num3 == 990)
						{
							goto IL_006e;
						}
						return;
					case 0:
						return;
					case 2:
						break;
					case 1:
						return;
					}
					break;
					IL_006e:
					num2 = num3;
				}
				goto IL_00a5;
				IL_00a5:
				System.IO.File.Delete((string)path);
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
				{
					num2 = 5;
				}
				goto IL_0072;
			}
			catch (global::System.Exception)
			{
				int num4 = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 == 988)
					{
						num4 = num5;
						continue;
					}
					return;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void dV9XFcqF2Q3(object path)
	{
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				int num2;
				if (!System.IO.Directory.Exists((string)path))
				{
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
					{
						num2 = 0;
					}
					goto IL_0073;
				}
				goto IL_00bb;
				IL_0073:
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 2:
						return;
					default:
						if (num3 == 990)
						{
							goto IL_006f;
						}
						return;
					case 1:
						break;
					}
					break;
					IL_006f:
					num2 = num3;
				}
				goto IL_00bb;
				IL_00bb:
				System.IO.Directory.Delete((string)path, true);
				num2 = 2;
				goto IL_0073;
			}
			catch (global::System.Exception)
			{
				int num4 = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 != 988)
					{
						return;
					}
					num4 = num5;
				}
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
	internal static bool CMoArSZRBTRIxPf9xiAf()
	{
		return JepxpAZRISxc2AlwMrUr == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JVONjHXFLBU55RTmon9w YhSt2gZRgjJfL4SPBJPO()
	{
		return (JVONjHXFLBU55RTmon9w)JepxpAZRISxc2AlwMrUr;
	}
}

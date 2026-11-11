using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CO34DtGBRQmXHPNZNcn;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using ZstdSharp;
using ax7rGeXwCeKy0FKpvaUV;
using e5Wu0CXeClRDwU7shqdf;
using fDAldojjppXrctUVYOJn;
using l7sYxOXw1UqblxoyRMtK;

namespace zGRdeXXw6XheIJ8T2W2K;

sealed class unerPMXw5ZYDUl4lYsfx : global::System.IDisposable
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass8_0_2
	{
		public unerPMXw5ZYDUl4lYsfx __4__this;

		public TskRBqXeQChlIH5eQbGM chunk;

		public CancellationToken cancellationToken;

		public Func<global::System.Threading.Tasks.Task<string>> __9__1;

		private static __c__DisplayClass8_0_2 irILl59nqHV4s5xbIOSG;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass8_0_2()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal unsafe Lazy<global::System.Threading.Tasks.Task<string>> oFMLZ0XP6CZ(string _)
		{
			//IL_006c: Expected O, but got I
			//IL_0071: Expected O, but got I
			//IL_0095: Expected O, but got I4
			//IL_0085->IL0010: Incompatible stack heights: 2 vs 1
			//IL_0090->IL0010: Incompatible stack heights: 2 vs 1
			int num = 1;
			Func<global::System.Threading.Tasks.Task<string>> val = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					Func<global::System.Threading.Tasks.Task<string>> obj;
					switch (num2)
					{
					default:
						if (num == 990)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 1:
						obj = __9__1;
						if (obj == null)
						{
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						break;
					case 0:
					{
						val = new Func<global::System.Threading.Tasks.Task<string>>(__c__DisplayClass8_0_2.SDvLZ8f14u3);
						__9__1 = new Func<global::System.Threading.Tasks.Task<string>>(__c__DisplayClass8_0_2.SDvLZ8f14u3);
						int num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
						{
							int num4 = 5;
						}
						continue;
					}
					case 2:
						obj = val;
						break;
					}
					return (Lazy<global::System.Threading.Tasks.Task<string>>)(object)2;
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.Threading.Tasks.Task<string> SDvLZ8f14u3()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			return __4__this.J0oXwevqLdZ(chunk, cancellationToken);
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
						case 1:
							goto end_IL_000e;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool wmXfEr9nGMCIRwYkQpVD()
		{
			return irILl59nqHV4s5xbIOSG == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass8_0_2 em711l9nip2mDFtICxA5()
		{
			return irILl59nqHV4s5xbIOSG;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AwaitDownloadAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public Lazy<global::System.Threading.Tasks.Task<string>> lazy;

		public unerPMXw5ZYDUl4lYsfx __4__this;

		public string key;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private static object p14Wlc9nnajs8Xa4dmJr;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e5: Expected O, but got Ref
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302->IL02b8: Incompatible stack heights: 3 vs 1
			//IL_0383->IL0342: Incompatible stack heights: 3 vs 1
			//IL_030d->IL02b8: Incompatible stack heights: 3 vs 1
			//IL_038e->IL0342: Incompatible stack heights: 3 vs 1
			//IL_0438->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0249->IL00f8: Incompatible stack heights: 2 vs 1
			//IL_0254->IL00f8: Incompatible stack heights: 2 vs 1
			int num9 = default;
			int num3 = default;
			int num6 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<string> val = default;
			int num8 = default;
			unerPMXw5ZYDUl4lYsfx unerPMXw5ZYDUl4lYsfx2 = default;
			int num11 = default;
			while (true)
			{
				int num = 1;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num == 11)
							{
								return;
							}
							goto end_IL_0010;
						case 3:
							try
							{
								int num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num9 == 989)
										{
											num4 = num9;
											continue;
										}
										goto case 0;
									case 0:
										num4 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
										{
											num4 = 1;
										}
										continue;
									case 1:
										try
										{
											int num5;
											if (num3 != 0)
											{
												num5 = 18;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
												{
													num5 = 9;
												}
												goto IL_00f8;
											}
											goto IL_0172;
											IL_00f4:
											num5 = num6;
											goto IL_00f8;
											IL_0172:
											_u__ = __u__1;
											num6 = 18;
											goto IL_00f4;
											IL_00f8:
											while (true)
											{
												switch (num5)
												{
												case 4:
													if (&_u__ == null)
													{
														num5 = 2;
														continue;
													}
													goto IL_01e0;
												case 7:
													goto end_IL_00f8;
												case 6:
													num3 = (__1__state = -1);
													num5 = 17;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
													{
														num5 = 3;
													}
													continue;
												case 5:
													_u__ = val;
													num5 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
													{
														num5 = 15;
													}
													continue;
												case 1:
													return;
												case 3:
													goto IL_01e0;
												case 2:
													num3 = (__1__state = 0);
													num5 = 10;
													continue;
												case 10:
													__u__1 = _u__;
													num5 = 8;
													continue;
												case 9:
													_ = lazy;
													val = (ConfiguredTaskAwaitable<string>)0;
													_ = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
													{
														_ = 6;
													}
													continue;
												case 8:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _AwaitDownloadAsync_d__9>(ref _u__, ref this);
													num5 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
													{
														num5 = 10;
													}
													continue;
												case 0:
													goto end_IL_00c0;
												}
												if (num6 != 18)
												{
													if (num6 == 998)
													{
														goto IL_00f4;
													}
													goto IL_01e0;
												}
												__u__1 = default;
												num5 = 6;
												continue;
												IL_01e0:
												string text = (string)(&_u__);
												num5 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
												{
													num5 = 0;
												}
												continue;
												end_IL_00f8:
												break;
											}
											goto IL_0172;
											end_IL_00c0:;
										}
										catch
										{
											int num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
											{
												num7 = 1;
											}
											while (true)
											{
												switch (num7)
												{
												default:
													if (num8 == 989)
													{
														num7 = num8;
														break;
													}
													goto case 1;
												case 1:
													_ = unerPMXw5ZYDUl4lYsfx2.BKSXwpwRkOb;
													_ = key;
													_ = lazy;
													_ = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
													{
														_ = 3;
													}
													break;
												case 0:
													throw new global::System.Exception();
												}
											}
										}
										break;
									}
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
								{
									num10 = 3;
								}
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 990)
										{
											num10 = num11;
											continue;
										}
										break;
									case 2:
										_ = __t__builder;
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
										{
											_ = 1;
										}
										continue;
									case 0:
										break;
									case 1:
										return;
									}
									__1__state = -2;
									num10 = 2;
								}
							}
							goto case 2;
						case 0:
							unerPMXw5ZYDUl4lYsfx2 = __4__this;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num2 = 8;
							}
							continue;
						case 1:
							num3 = __1__state;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num2 = 0;
							}
							continue;
						case 2:
							__1__state = -2;
							num2 = 4;
							continue;
						case 4:
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
				while (num == 992);
				_ = __t__builder;
				_ = 11;
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
								goto IL_0054;
							}
							break;
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							IL_0054:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
							{
								num3 = 7;
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
		internal static bool R82Ym89nz5OfGMTHCCdF()
		{
			return p14Wlc9nnajs8Xa4dmJr == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object dvceAB9zbUMl2lZdoDH6()
		{
			return p14Wlc9nnajs8Xa4dmJr;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _DownloadAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public TskRBqXeQChlIH5eQbGM chunk;

		public unerPMXw5ZYDUl4lYsfx __4__this;

		public CancellationToken cancellationToken;

		private string _finalPath_5__2;

		private string _encryptedPath_5__3;

		private string _compressedPath_5__4;

		private string _partPath_5__5;

		private int _attempt_5__6;

		private long _encryptedLength_5__7;

		private object __u__1;

		private HttpResponseMessage _response_5__8;

		private Stream _source_5__9;

		private FileStream _encrypted_5__10;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__3;

		private object __7__wrap10;

		private int __7__wrap11;

		private object __7__wrap12;

		private int __7__wrap13;

		private ValueTaskAwaiter __u__4;

		private FileStream _compressed_5__15;

		private DecompressionStream _zstd_5__16;

		private object __7__wrap16;

		private int __7__wrap17;

		private static object LlePvR9zXN1yA6eaEoqA;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_1938: Unknown result type (might be due to invalid IL or missing references)
			//IL_193d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c31: Expected O, but got I4
			//IL_1c51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1883: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_16f3: Expected O, but got Ref
			//IL_161a: Unknown result type (might be due to invalid IL or missing references)
			//IL_161c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1574: Unknown result type (might be due to invalid IL or missing references)
			//IL_1585: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d90: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_14a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_144e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1453: Unknown result type (might be due to invalid IL or missing references)
			//IL_16ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1609: Unknown result type (might be due to invalid IL or missing references)
			//IL_151c: Unknown result type (might be due to invalid IL or missing references)
			//IL_169c: Unknown result type (might be due to invalid IL or missing references)
			//IL_16a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ba9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b00: Expected O, but got I4
			//IL_27a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_27a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_27bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_27c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_257f: Unknown result type (might be due to invalid IL or missing references)
			//IL_2584: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Expected O, but got I4
			//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ea2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ea7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0468: Unknown result type (might be due to invalid IL or missing references)
			//IL_046a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2449: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f52: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1163: Unknown result type (might be due to invalid IL or missing references)
			//IL_1178: Unknown result type (might be due to invalid IL or missing references)
			//IL_117d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ba: Expected O, but got I4
			//IL_231e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2320: Unknown result type (might be due to invalid IL or missing references)
			//IL_23dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_110d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1112: Unknown result type (might be due to invalid IL or missing references)
			//IL_2610: Expected O, but got I4
			//IL_2d10: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f00: Unknown result type (might be due to invalid IL or missing references)
			//IL_2f05: Unknown result type (might be due to invalid IL or missing references)
			//IL_21dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0980: Unknown result type (might be due to invalid IL or missing references)
			//IL_0985: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d53: Expected O, but got I4
			//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0791: Unknown result type (might be due to invalid IL or missing references)
			//IL_0796: Unknown result type (might be due to invalid IL or missing references)
			//IL_0745: Expected O, but got I4
			//IL_0fcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_3254: Unknown result type (might be due to invalid IL or missing references)
			//IL_32e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_32ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_3304: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_31d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_3218: Unknown result type (might be due to invalid IL or missing references)
			//IL_321a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2d5d: Expected O, but got I4
			//IL_354f: Expected O, but got I4
			//IL_3672: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ae8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1aed: Unknown result type (might be due to invalid IL or missing references)
			//IL_2976: Unknown result type (might be due to invalid IL or missing references)
			//IL_297b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f98: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fe7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f37: Unknown result type (might be due to invalid IL or missing references)
			//IL_211b: Unknown result type (might be due to invalid IL or missing references)
			//IL_20b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_20c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a86: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a5a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a6f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a74: Unknown result type (might be due to invalid IL or missing references)
			//IL_20e7: Expected O, but got Ref
			//IL_2900: Unknown result type (might be due to invalid IL or missing references)
			//IL_2902: Unknown result type (might be due to invalid IL or missing references)
			//IL_28de: Unknown result type (might be due to invalid IL or missing references)
			//IL_28ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_28f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a79: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b65: Unknown result type (might be due to invalid IL or missing references)
			//IL_1a99: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_386b->IL382a: Incompatible stack heights: 3 vs 1
			//IL_3876->IL382a: Incompatible stack heights: 3 vs 1
			//IL_0068->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0073->IL0008: Incompatible stack heights: 3 vs 1
			//IL_1c45->IL1737: Incompatible stack heights: 6 vs 1
			//IL_1591->IL1335: Incompatible stack heights: 2 vs 1
			//IL_2b14->IL2669: Incompatible stack heights: 6 vs 1
			//IL_03d8->IL0246: Incompatible stack heights: 2 vs 1
			//IL_04ce->IL0246: Incompatible stack heights: 2 vs 1
			//IL_2624->IL0246: Incompatible stack heights: 6 vs 1
			//IL_0d5d->IL08b9: Incompatible stack heights: 6 vs 1
			//IL_06b9->IL0604: Incompatible stack heights: 1 vs 4
			//IL_1c50->IL1737: Incompatible stack heights: 6 vs 1
			//IL_2b1f->IL2669: Incompatible stack heights: 6 vs 1
			//IL_2d71->IL0246: Incompatible stack heights: 6 vs 1
			//IL_04d9->IL0246: Incompatible stack heights: 2 vs 1
			//IL_262f->IL0246: Incompatible stack heights: 6 vs 1
			//IL_068d->IL0608: Incompatible stack heights: 0 vs 3
			//IL_3559->IL0099: Incompatible stack heights: 2 vs 1
			//IL_2d7c->IL0246: Incompatible stack heights: 6 vs 1
			//IL_3026->IL023e: Incompatible stack heights: 3 vs 1
			//IL_060c->IL060c: Incompatible stack heights: 4 vs 1
			//IL_20d7->IL1291: Incompatible stack heights: 2 vs 1
			//IL_37c5->IL0099: Incompatible stack heights: 3 vs 1
			//IL_20e2->IL1291: Incompatible stack heights: 2 vs 1
			int num = 2;
			int num4 = default;
			int num6 = default;
			int num10 = default;
			object _u__ = default;
			int num8 = default;
			int num36 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = default;
			object obj = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = default;
			long num37 = default;
			ValueTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable val = default;
			int num33 = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			int num30 = default;
			int num26 = default;
			int num29 = default;
			int num32 = default;
			int num35 = default;
			unerPMXw5ZYDUl4lYsfx unerPMXw5ZYDUl4lYsfx2 = default;
			int num39 = default;
			int num43 = default;
			ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _u__4 = default;
			Stream source_5__ = default;
			ConfiguredTaskAwaitable<Stream> val3 = default;
			int num45 = default;
			int num48 = default;
			int num50 = default;
			int num52 = default;
			int num54 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__3 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val2 = default;
			int num56 = default;
			int num15 = default;
			int num17 = default;
			int num20 = default;
			int num22 = default;
			int num59 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj10);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num60);
			global::System.Exception ex2 = default;
			int num61 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num63 = default;
			int num66 = default;
			string text = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			string text2 = default;
			int num68 = default;
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
								goto case 1;
							}
							return;
						case 4:
							_ = __t__builder;
							_ = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								_ = 11;
							}
							break;
						case 0:
							try
							{
								int num5;
								if ((uint)num4 > 13u)
								{
									num5 = 23;
									goto IL_0099;
								}
								goto IL_3458;
								IL_0091:
								int num7;
								num6 = num7;
								goto IL_0095;
								IL_0099:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num6 != 32)
										{
											if (num6 == 1012)
											{
												goto IL_0095;
											}
											goto case 22;
										}
										try
										{
											int num9;
											if ((uint)num4 > 12u)
											{
												num9 = 8;
												goto IL_0152;
											}
											goto IL_32b2;
											IL_320d:
											num9 = 13;
											goto IL_0152;
											IL_0152:
											num10 = num9;
											goto IL_0156;
											IL_0156:
											int num11 = num10;
											goto IL_015a;
											IL_015a:
											while (true)
											{
												switch (num11)
												{
												default:
													if (num10 == 23)
													{
														return;
													}
													if (num10 == 1003)
													{
														goto IL_0156;
													}
													goto case 3;
												case 7:
													_u__ = __u__1;
													num11 = 9;
													continue;
												case 15:
													num8 = 0;
													num11 = 12;
													continue;
												case 4:
													try
													{
														int num12;
														int num57;
														switch (num4)
														{
														default:
															num12 = 36;
															goto IL_0246;
														case 9:
														case 10:
														case 11:
															num57 = 81;
															goto IL_023e;
														case 1:
														case 2:
														case 3:
														case 4:
														case 5:
															goto IL_1150;
														case 6:
														case 7:
															goto IL_22e5;
														case 8:
															goto IL_23db;
														case 12:
															goto IL_257e;
														case 0:
															goto IL_2eff;
															IL_0246:
															while (true)
															{
																switch (num12)
																{
																case 6:
																	return;
																case 61:
																	return;
																case 84:
																	return;
																default:
																	if (num36 != 94)
																	{
																		goto IL_03b5;
																	}
																	goto case 72;
																case 12:
																	_ = 18;
																	defaultInterpolatedStringHandler3 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
																	_ = 71;
																	continue;
																case 42:
																	obj = __7__wrap10;
																	num12 = 31;
																	continue;
																case 78:
																	defaultInterpolatedStringHandler2.AppendFormatted<long>(num37);
																	num12 = 13;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
																	{
																		num12 = 94;
																	}
																	continue;
																case 79:
																	defaultInterpolatedStringHandler2.AppendFormatted<uint>(chunk.DecompressSize);
																	num12 = 40;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
																	{
																		num12 = 66;
																	}
																	continue;
																case 23:
																	__u__4 = _u__2;
																	num12 = 30;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
																	{
																		num12 = 46;
																	}
																	continue;
																case 72:
																	__7__wrap10 = null;
																	num12 = 25;
																	continue;
																case 0:
																	if (_encrypted_5__10 != null)
																	{
																		num12 = 24;
																		continue;
																	}
																	goto case 42;
																case 48:
																	_ = 20;
																	defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
																	_ = 47;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
																	{
																		_ = 15;
																	}
																	continue;
																case 38:
																	num4 = (__1__state = 12);
																	num12 = 23;
																	continue;
																case 51:
																	break;
																case 63:
																case 80:
																	obj = __7__wrap10;
																	num12 = 80;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
																	{
																		num12 = 73;
																	}
																	continue;
																case 34:
																	(defaultInterpolatedStringHandler3).AppendFormatted(chunk.ChunkId);
																	num12 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
																	{
																		num12 = 17;
																	}
																	continue;
																case 15:
																	goto IL_0565;
																case 20:
																	_u__ = val;
																	num12 = 75;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
																	{
																		num12 = 78;
																	}
																	continue;
																case 81:
																	try
																	{
																		int num23;
																		if ((uint)(num4 - 9) > 1u)
																		{
																			num23 = 19;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																			{
																				num23 = 28;
																			}
																			goto IL_060c;
																		}
																		goto IL_0ff1;
																		IL_060c:
																		while (true)
																		{
																			switch (num23)
																			{
																			case 2:
																				return;
																			default:
																				switch (num33)
																				{
																				case 1011:
																					continue;
																				case 31:
																					__7__wrap12 = null;
																					num23 = 3;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
																					{
																						num23 = 6;
																					}
																					continue;
																				}
																				goto case 7;
																			case 6:
																				if (_zstd_5__16 != null)
																				{
																					num23 = 14;
																					continue;
																				}
																				goto case 13;
																			case 17:
																				__u__4 = _u__2;
																				_ = 11;
																				goto IL_0604;
																			case 18:
																				__u__4 = default;
																				num23 = 22;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
																				{
																					num23 = 0;
																				}
																				continue;
																			case 13:
																				obj = __7__wrap12;
																				num23 = 12;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
																				{
																					num23 = 2;
																				}
																				continue;
																			case 9:
																				_ = _encrypted_5__10;
																				_ = 131072;
																				global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)1)->_zstd_5__16, (object)0);
																				goto IL_0604;
																			case 22:
																				num4 = (__1__state = 11);
																				num23 = 17;
																				continue;
																			case 3:
																				__7__wrap13 = 0;
																				num23 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
																				{
																					num23 = 3;
																				}
																				continue;
																			case 5:
																				_u__2 = (valueTask).GetAwaiter();
																				num23 = 29;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
																				{
																					num23 = 16;
																				}
																				continue;
																			case 0:
																				num4 = (__1__state = -1);
																				num23 = 20;
																				continue;
																			case 19:
																				if (num4 != 11)
																				{
																					num23 = 9;
																					continue;
																				}
																				goto case 10;
																			case 14:
																				valueTask = (_zstd_5__16).DisposeAsync();
																				num23 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
																				{
																					num23 = 20;
																				}
																				continue;
																			case 8:
																			case 23:
																				__7__wrap12 = null;
																				num23 = 4;
																				continue;
																			case 12:
																				if (obj == null)
																				{
																					num23 = 8;
																					continue;
																				}
																				goto case 15;
																			case 11:
																				__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																				num23 = 2;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
																				{
																					num23 = 2;
																				}
																				continue;
																			case 4:
																				_zstd_5__16 = null;
																				num23 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
																				{
																					num23 = 21;
																				}
																				continue;
																			case 7:
																				try
																				{
																					int num24;
																					if (num4 != 9)
																					{
																						num24 = 7;
																						goto IL_08b9;
																					}
																					goto IL_0e82;
																					IL_0e82:
																					num24 = 24;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																					{
																						num24 = 31;
																					}
																					goto IL_08b9;
																					IL_08b9:
																					while (true)
																					{
																						switch (num24)
																						{
																						case 19:
																							return;
																						default:
																							if (num30 != 32)
																							{
																								if (num30 == 1012)
																								{
																									goto IL_08b5;
																								}
																								goto case 3;
																							}
																							__7__wrap17 = 0;
																							num24 = 20;
																							continue;
																						case 11:
																							num4 = (__1__state = -1);
																							num24 = 17;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
																							{
																								num24 = 26;
																							}
																							continue;
																						case 7:
																							if (num4 != 10)
																							{
																								num24 = 16;
																								continue;
																							}
																							goto case 0;
																						case 0:
																							_u__2 = __u__4;
																							num24 = 21;
																							continue;
																						case 24:
																							try
																							{
																								int num25;
																								if (num4 != 9)
																								{
																									num25 = 2;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
																									{
																										num25 = 2;
																									}
																									goto IL_09cc;
																								}
																								goto IL_0baf;
																								IL_09c8:
																								num25 = num26;
																								goto IL_09cc;
																								IL_09c4:
																								int num27;
																								num26 = num27;
																								goto IL_09c8;
																								IL_09cc:
																								while (true)
																								{
																									switch (num25)
																									{
																									case 7:
																										return;
																									case 4:
																										num4 = (__1__state = -1);
																										num25 = 10;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
																										{
																											num25 = 1;
																										}
																										continue;
																									case 9:
																										__t__builder.AwaitUnsafeOnCompleted<object, _DownloadAsync_d__10>(ref _u__, ref this);
																										num25 = 6;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
																										{
																											num25 = 7;
																										}
																										continue;
																									case 3:
																										goto IL_0a78;
																									case 2:
																										goto end_IL_09cc;
																									case 5:
																										if ((_u__).IsCompleted)
																										{
																											num25 = 2;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
																											{
																												num25 = 1;
																											}
																											continue;
																										}
																										goto case 6;
																									case 6:
																										num4 = (__1__state = 9);
																										num25 = 3;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																										{
																											num25 = 5;
																										}
																										continue;
																									case 8:
																										__u__1 = default;
																										num25 = 4;
																										continue;
																									case 1:
																									case 10:
																										(_u__).GetResult();
																										num25 = 12;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																										{
																											num25 = 0;
																										}
																										continue;
																									case 11:
																										goto IL_0baf;
																									case 0:
																										goto end_IL_0992;
																									}
																									if (num26 != 19)
																									{
																										if (num26 == 999)
																										{
																											goto IL_09c8;
																										}
																										goto IL_0a78;
																									}
																									_u__ = val;
																									num25 = 5;
																									continue;
																									IL_0a78:
																									__u__1 = _u__;
																									num25 = 9;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
																									{
																										num25 = 4;
																									}
																									continue;
																									end_IL_09cc:
																									break;
																								}
																								val = ((_zstd_5__16).CopyToAsync((Stream)(object)_compressed_5__15, cancellationToken)).ConfigureAwait(false);
																								num27 = 19;
																								goto IL_09c4;
																								IL_0baf:
																								_u__ = __u__1;
																								num27 = 8;
																								goto IL_09c4;
																								end_IL_0992:;
																							}
																							catch (object obj4)
																							{
																								obj = obj4;
																								int num28 = 1;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
																								{
																									num28 = 0;
																								}
																								while (true)
																								{
																									switch (num28)
																									{
																									default:
																										if (num29 == 989)
																										{
																											num28 = num29;
																											continue;
																										}
																										break;
																									case 1:
																										__7__wrap16 = obj;
																										num28 = 0;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
																										{
																											num28 = 0;
																										}
																										continue;
																									case 0:
																										break;
																									}
																									break;
																								}
																							}
																							goto case 22;
																						case 21:
																							__u__4 = default;
																							num24 = 11;
																							continue;
																						case 14:
																						case 17:
																							(_u__2).GetResult();
																							num24 = 27;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
																							{
																								num24 = 12;
																							}
																							continue;
																						case 23:
																							num4 = (__1__state = 10);
																							num24 = 19;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
																							{
																								num24 = 1;
																							}
																							continue;
																						case 4:
																							_compressed_5__15 = null;
																							num24 = 32;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
																							{
																								num24 = 9;
																							}
																							continue;
																						case 16:
																							_ = _partPath_5__5;
																							_ = 2;
																							_ = 2;
																							_ = 0;
																							global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)131072)->_compressed_5__15, (object)1207959552);
																							_ = 13;
																							continue;
																						case 3:
																							valueTask = (_compressed_5__15).DisposeAsync();
																							num24 = 10;
																							continue;
																						case 1:
																							__u__4 = _u__2;
																							num24 = 8;
																							continue;
																						case 2:
																							if ((_u__2).IsCompleted)
																							{
																								num24 = 24;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
																								{
																									num24 = 14;
																								}
																								continue;
																							}
																							goto case 23;
																						case 5:
																						case 12:
																							obj = __7__wrap16;
																							num24 = 18;
																							continue;
																						case 22:
																							if (_compressed_5__15 == null)
																							{
																								num24 = 5;
																								continue;
																							}
																							goto case 3;
																						case 13:
																							__7__wrap16 = null;
																							num30 = 32;
																							goto IL_08b5;
																						case 8:
																							__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																							num24 = 19;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
																							{
																								num24 = 1;
																							}
																							continue;
																						case 10:
																							_u__2 = (valueTask).GetAwaiter();
																							num24 = 2;
																							continue;
																						case 18:
																							if (obj != null)
																							{
																								num24 = 11;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
																								{
																									num24 = 15;
																								}
																								continue;
																							}
																							goto case 6;
																						case 20:
																							break;
																						case 6:
																							__7__wrap16 = null;
																							num24 = 4;
																							continue;
																						case 15:
																							(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																							num24 = 6;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
																							{
																								num24 = 8;
																							}
																							continue;
																						case 9:
																							goto end_IL_08b9;
																							IL_08b5:
																							num24 = num30;
																							continue;
																						}
																						goto IL_0e82;
																						continue;
																						end_IL_08b9:
																						break;
																					}
																				}
																				catch (object obj5)
																				{
																					obj = obj5;
																					int num31 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
																					{
																						num31 = 6;
																					}
																					while (true)
																					{
																						switch (num31)
																						{
																						default:
																							if (num32 == 989)
																							{
																								num31 = num32;
																								continue;
																							}
																							break;
																						case 1:
																							break;
																						case 0:
																							goto end_IL_0f2e;
																						}
																						__7__wrap12 = obj;
																						num31 = 0;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
																						{
																							num31 = 2;
																						}
																						continue;
																						end_IL_0f2e:
																						break;
																					}
																				}
																				goto case 6;
																			case 16:
																				if (!(_u__2).IsCompleted)
																				{
																					num23 = 22;
																					continue;
																				}
																				goto case 20;
																			case 20:
																				(_u__2).GetResult();
																				num23 = 13;
																				continue;
																			case 10:
																				_u__2 = __u__4;
																				num23 = 18;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																				{
																					num23 = 13;
																				}
																				continue;
																			case 1:
																				break;
																			case 15:
																				(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																				num23 = 26;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
																				{
																					num23 = 23;
																				}
																				continue;
																			case 21:
																				goto end_IL_060c;
																				IL_0604:
																				num33 = 31;
																				continue;
																			}
																			goto IL_0ff1;
																			continue;
																			end_IL_060c:
																			break;
																		}
																		goto end_IL_05d0;
																		IL_0ff1:
																		num23 = 7;
																		goto IL_060c;
																		end_IL_05d0:;
																	}
																	catch (object obj6)
																	{
																		obj = obj6;
																		int num34 = 7;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
																		{
																			num34 = 1;
																		}
																		while (true)
																		{
																			switch (num34)
																			{
																			default:
																				if (num35 == 989)
																				{
																					num34 = num35;
																					continue;
																				}
																				break;
																			case 1:
																				break;
																			case 0:
																				goto end_IL_109b;
																			}
																			__7__wrap10 = obj;
																			num34 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
																			{
																				num34 = 5;
																			}
																			continue;
																			end_IL_109b:
																			break;
																		}
																	}
																	goto case 0;
																case 55:
																	_u__2 = (valueTask).GetAwaiter();
																	num12 = 59;
																	continue;
																case 39:
																	(defaultInterpolatedStringHandler2).AppendLiteral("，期望 ");
																	num12 = 79;
																	continue;
																case 74:
																	goto IL_1150;
																case 36:
																	val = ((unerPMXw5ZYDUl4lYsfx2.RdKXwM3Y81i).WaitAsync(cancellationToken)).ConfigureAwait(false);
																	num12 = 20;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																	{
																		num12 = 34;
																	}
																	continue;
																case 47:
																case 83:
																	(_u__).GetResult();
																	num12 = 42;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
																	{
																		num12 = 74;
																	}
																	continue;
																case 5:
																	(defaultInterpolatedStringHandler3).AppendLiteral("，实际 ");
																	num12 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
																	{
																		num12 = 60;
																	}
																	continue;
																case 31:
																	if (obj != null)
																	{
																		num12 = 18;
																		continue;
																	}
																	goto case 26;
																case 9:
																	num4 = (__1__state = -1);
																	num12 = 70;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
																	{
																		num12 = 4;
																	}
																	continue;
																case 3:
																	num37 = (_partPath_5__5).Length;
																	num12 = 58;
																	continue;
																case 19:
																	try
																	{
																		int num38;
																		if (num4 != 1)
																		{
																			num38 = 14;
																			goto IL_1289;
																		}
																		goto IL_1f97;
																		IL_1fc1:
																		num4 = (__1__state = -1);
																		num38 = 25;
																		goto IL_1289;
																		IL_1289:
																		num39 = num38;
																		goto IL_128d;
																		IL_128d:
																		int num40 = num39;
																		goto IL_1291;
																		IL_1291:
																		while (true)
																		{
																			switch (num40)
																			{
																			case 10:
																				return;
																			case 6:
																				try
																				{
																					int num41;
																					switch (num4)
																					{
																					default:
																						num41 = 19;
																						goto IL_1335;
																					case 5:
																						_u__2 = __u__4;
																						num41 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
																						{
																							num41 = 30;
																						}
																						goto IL_1335;
																					case 3:
																					case 4:
																						goto IL_14f9;
																					case 2:
																						goto IL_16cd;
																						IL_1335:
																						while (true)
																						{
																							int num42;
																							switch (num41)
																							{
																							case 11:
																								return;
																							case 18:
																								return;
																							default:
																								if (num43 != 43)
																								{
																									if (num43 == 1023)
																									{
																										goto IL_1331;
																									}
																								}
																								else if (&_u__4 != null)
																								{
																									num41 = 25;
																									continue;
																								}
																								goto IL_1da0;
																							case 13:
																								__7__wrap11 = 0;
																								num41 = 7;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
																								{
																									num41 = 27;
																								}
																								continue;
																							case 19:
																								(_response_5__8).EnsureSuccessStatusCode();
																								num41 = 5;
																								continue;
																							case 16:
																								_source_5__9 = source_5__;
																								num41 = 26;
																								continue;
																							case 24:
																								break;
																							case 10:
																								valueTask = (_source_5__9).DisposeAsync();
																								num41 = 32;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
																								{
																									num41 = 43;
																								}
																								continue;
																							case 20:
																								__u__3 = _u__4;
																								num41 = 1;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																								{
																									num41 = 15;
																								}
																								continue;
																							case 8:
																								__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																								num41 = 11;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
																								{
																									num41 = 28;
																								}
																								continue;
																							case 7:
																								goto IL_14f9;
																							case 31:
																								_u__4 = val3;
																								num42 = 37;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
																								{
																									num42 = 43;
																								}
																								goto IL_132d;
																							case 12:
																								if (obj == null)
																								{
																									num41 = 21;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																									{
																										num41 = 9;
																									}
																									continue;
																								}
																								goto IL_1e28;
																							case 5:
																								((_response_5__8).Content).ReadAsStreamAsync(cancellationToken);
																								val3 = (ConfiguredTaskAwaitable<Stream>)0;
																								_ = 31;
																								continue;
																							case 22:
																							case 27:
																								(_u__2).GetResult();
																								num41 = 34;
																								continue;
																							case 21:
																							case 23:
																								__7__wrap10 = null;
																								num41 = 28;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
																								{
																									num41 = 33;
																								}
																								continue;
																							case 30:
																								__u__4 = default;
																								num42 = 17;
																								goto IL_132d;
																							case 3:
																								__u__4 = _u__2;
																								num42 = 8;
																								goto IL_132d;
																							case 9:
																								num4 = (__1__state = -1);
																								num41 = 0;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
																								{
																									num41 = 21;
																								}
																								continue;
																							case 6:
																								num4 = (__1__state = 5);
																								num41 = 3;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
																								{
																									num41 = 29;
																								}
																								continue;
																							case 1:
																								__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter, _DownloadAsync_d__10>(ref _u__4, ref this);
																								num42 = 18;
																								goto IL_132d;
																							case 32:
																								_u__2 = (valueTask).GetAwaiter();
																								num41 = 4;
																								continue;
																							case 26:
																								__7__wrap10 = null;
																								num41 = 13;
																								continue;
																							case 29:
																								goto IL_16cd;
																							case 0:
																							case 25:
																								source_5__ = (Stream)(object)(&_u__4);
																								num41 = 16;
																								continue;
																							case 2:
																								try
																								{
																									int num44;
																									if (num4 != 3)
																									{
																										num44 = 11;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
																										{
																											num44 = 5;
																										}
																										goto IL_1737;
																									}
																									goto IL_1872;
																									IL_1733:
																									num44 = num45;
																									goto IL_1737;
																									IL_1872:
																									int num46 = 22;
																									goto IL_172f;
																									IL_1737:
																									while (true)
																									{
																										switch (num44)
																										{
																										default:
																											if (num45 == 30)
																											{
																												return;
																											}
																											if (num45 == 1010)
																											{
																												goto IL_1733;
																											}
																											goto case 21;
																										case 13:
																											num4 = (__1__state = -1);
																											num44 = 6;
																											continue;
																										case 14:
																											break;
																										case 17:
																											valueTask = (_encrypted_5__10).DisposeAsync();
																											num44 = 8;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																											{
																												num44 = 7;
																											}
																											continue;
																										case 16:
																										case 19:
																											obj = __7__wrap12;
																											num44 = 0;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																											{
																												num44 = 28;
																											}
																											continue;
																										case 0:
																											if (obj != null)
																											{
																												num44 = 10;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
																												{
																													num44 = 3;
																												}
																												continue;
																											}
																											goto case 2;
																										case 4:
																											goto IL_1872;
																										case 15:
																											__u__4 = default;
																											num44 = 13;
																											continue;
																										case 3:
																											if (!(_u__2).IsCompleted)
																											{
																												num44 = 7;
																												continue;
																											}
																											goto case 6;
																										case 1:
																											__7__wrap13 = 0;
																											num44 = 4;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
																											{
																												num44 = 15;
																											}
																											continue;
																										case 21:
																											__u__4 = _u__2;
																											num44 = 14;
																											continue;
																										case 2:
																											__7__wrap12 = null;
																											num44 = 12;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
																											{
																												num44 = 28;
																											}
																											continue;
																										case 6:
																											(_u__2).GetResult();
																											num44 = 16;
																											continue;
																										case 8:
																											_u__2 = (valueTask).GetAwaiter();
																											num44 = 3;
																											continue;
																										case 20:
																											__7__wrap12 = null;
																											num44 = 0;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
																											{
																												num44 = 1;
																											}
																											continue;
																										case 7:
																											num4 = (__1__state = 4);
																											num44 = 8;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																											{
																												num44 = 21;
																											}
																											continue;
																										case 18:
																											if (_encrypted_5__10 == null)
																											{
																												num44 = 19;
																												continue;
																											}
																											goto case 17;
																										case 22:
																											try
																											{
																												int num47;
																												if (num4 != 3)
																												{
																													num47 = 10;
																													goto IL_19d2;
																												}
																												goto IL_1ae7;
																												IL_1ae7:
																												_u__ = __u__1;
																												num47 = 6;
																												goto IL_19d2;
																												IL_19d2:
																												while (true)
																												{
																													switch (num47)
																													{
																													case 2:
																														return;
																													default:
																														if (num48 != 18)
																														{
																															if (num48 == 998)
																															{
																																goto IL_19ce;
																															}
																															goto case 7;
																														}
																														_u__ = val;
																														num47 = 4;
																														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
																														{
																															num47 = 3;
																														}
																														continue;
																													case 7:
																														num4 = (__1__state = -1);
																														num47 = 14;
																														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
																														{
																															num47 = 0;
																														}
																														continue;
																													case 10:
																														val = ((_source_5__9).CopyToAsync((Stream)(object)_encrypted_5__10, cancellationToken)).ConfigureAwait(false);
																														num48 = 18;
																														goto IL_19ce;
																													case 6:
																														__u__1 = default;
																														num47 = 7;
																														continue;
																													case 9:
																														__t__builder.AwaitUnsafeOnCompleted<object, _DownloadAsync_d__10>(ref _u__, ref this);
																														num47 = 2;
																														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
																														{
																															num47 = 2;
																														}
																														continue;
																													case 5:
																														break;
																													case 1:
																														num4 = (__1__state = 3);
																														num47 = 3;
																														continue;
																													case 4:
																														if (!(_u__).IsCompleted)
																														{
																															num47 = 13;
																															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
																															{
																																num47 = 1;
																															}
																															continue;
																														}
																														goto case 0;
																													case 0:
																														(_u__).GetResult();
																														num47 = 8;
																														continue;
																													case 3:
																														__u__1 = _u__;
																														num47 = 2;
																														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
																														{
																															num47 = 9;
																														}
																														continue;
																													case 8:
																														goto end_IL_19d2;
																														IL_19ce:
																														num47 = num48;
																														continue;
																													}
																													goto IL_1ae7;
																													continue;
																													end_IL_19d2:
																													break;
																												}
																											}
																											catch (object obj7)
																											{
																												obj = obj7;
																												int num49 = 0;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																												{
																													num49 = 0;
																												}
																												while (true)
																												{
																													switch (num49)
																													{
																													default:
																														if (num50 == 989)
																														{
																															num49 = num50;
																															continue;
																														}
																														break;
																													case 0:
																														__7__wrap12 = obj;
																														num49 = 1;
																														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
																														{
																															num49 = 6;
																														}
																														continue;
																													case 1:
																														break;
																													}
																													break;
																												}
																											}
																											goto case 18;
																										case 9:
																											_ = _encryptedPath_5__3;
																											_ = 2;
																											_ = 2;
																											_ = 0;
																											global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)131072)->_encrypted_5__10, (object)1207959552);
																											_ = 4;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																											{
																												_ = 20;
																											}
																											continue;
																										case 11:
																											_u__2 = __u__4;
																											num44 = 15;
																											continue;
																										case 5:
																											if (num4 != 4)
																											{
																												num44 = 9;
																												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
																												{
																													num44 = 11;
																												}
																												continue;
																											}
																											goto case 11;
																										case 10:
																											goto IL_1c89;
																										case 12:
																											goto end_IL_16fe;
																										}
																										break;
																										IL_1c89:
																										(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																										num44 = 2;
																									}
																									__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																									num46 = 30;
																									goto IL_172f;
																									IL_172f:
																									num45 = num46;
																									goto IL_1733;
																									end_IL_16fe:;
																								}
																								catch (object obj8)
																								{
																									obj = obj8;
																									int num51 = 1;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																									{
																										num51 = 5;
																									}
																									while (true)
																									{
																										switch (num51)
																										{
																										default:
																											if (num52 == 989)
																											{
																												num51 = num52;
																												continue;
																											}
																											break;
																										case 1:
																											break;
																										case 0:
																											goto end_IL_1cef;
																										}
																										__7__wrap10 = obj;
																										num51 = 0;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
																										{
																											num51 = 4;
																										}
																										continue;
																										end_IL_1cef:
																										break;
																									}
																								}
																								goto case 14;
																							case 14:
																								if (_source_5__9 != null)
																								{
																									num41 = 10;
																									continue;
																								}
																								goto case 34;
																							case 4:
																								if ((_u__2).IsCompleted)
																								{
																									num41 = 27;
																									continue;
																								}
																								goto case 6;
																							case 15:
																								__u__3 = default;
																								num42 = 9;
																								goto IL_132d;
																							case 33:
																								goto IL_1da0;
																							case 34:
																								obj = __7__wrap10;
																								num41 = 12;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
																								{
																									num41 = 6;
																								}
																								continue;
																							case 17:
																								num4 = (__1__state = -1);
																								num41 = 22;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
																								{
																									num41 = 15;
																								}
																								continue;
																							case 35:
																								goto IL_1e28;
																							case 28:
																								goto end_IL_1304;
																								IL_132d:
																								num43 = num42;
																								goto IL_1331;
																								IL_1331:
																								num41 = num43;
																								continue;
																							}
																							break;
																							IL_1e28:
																							(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																							num41 = 23;
																							continue;
																							IL_1da0:
																							num4 = (__1__state = 2);
																							num41 = 20;
																						}
																						goto case 5;
																						IL_16cd:
																						_u__4 = __u__3;
																						num41 = 15;
																						goto IL_1335;
																						IL_14f9:
																						num41 = 14;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
																						{
																							num41 = 2;
																						}
																						goto IL_1335;
																						end_IL_1304:
																						break;
																					}
																				}
																				finally
																				{
																					if (num4 < 0)
																					{
																						int num53 = 1;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
																						{
																							num53 = 0;
																						}
																						while (true)
																						{
																							switch (num53)
																							{
																							default:
																								if (num54 == 990)
																								{
																									num53 = num54;
																									continue;
																								}
																								break;
																							case 0:
																								if (_response_5__8 != null)
																								{
																									num53 = 0;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
																									{
																										num53 = 2;
																									}
																									continue;
																								}
																								goto end_IL_1e94;
																							case 2:
																								break;
																							case 1:
																								goto end_IL_1e94;
																							}
																							(_response_5__8).Dispose();
																							num53 = 1;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
																							{
																								num53 = 2;
																							}
																							continue;
																							end_IL_1e94:
																							break;
																						}
																					}
																				}
																				goto case 9;
																			case 4:
																				__u__2 = default;
																				num40 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																				{
																					num40 = 1;
																				}
																				continue;
																			case 17:
																				num4 = (__1__state = 1);
																				num40 = 2;
																				continue;
																			case 12:
																				_response_5__8 = response_5__;
																				num40 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
																				{
																					num40 = 6;
																				}
																				continue;
																			case 5:
																				goto end_IL_1291;
																			case 11:
																				__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _DownloadAsync_d__10>(ref _u__3, ref this);
																				num40 = 10;
																				continue;
																			case 1:
																				goto IL_1fc1;
																			case 2:
																				__u__2 = _u__3;
																				num40 = 11;
																				continue;
																			case 9:
																				_response_5__8 = null;
																				num40 = 15;
																				continue;
																			case 14:
																				goto IL_2007;
																			case 0:
																				_encrypted_5__10 = null;
																				num40 = 14;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
																				{
																					num40 = 13;
																				}
																				continue;
																			case 3:
																				goto IL_2056;
																			case 15:
																				_source_5__9 = null;
																				num40 = 18;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
																				{
																					num40 = 0;
																				}
																				continue;
																			case 16:
																				(unerPMXw5ZYDUl4lYsfx2.JRrXwFbREyy).GetAsync(chunk.Url, (HttpCompletionOption)1, cancellationToken);
																				val2 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																				_ = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
																				{
																					_ = 2;
																				}
																				continue;
																			case 8:
																				goto IL_2106;
																			case 7:
																				_u__3 = val2;
																				num40 = 8;
																				continue;
																			case 13:
																				goto end_IL_126d;
																			}
																			if (num39 != 25)
																			{
																				if (num39 == 1005)
																				{
																					goto IL_128d;
																				}
																				goto IL_2007;
																			}
																			goto IL_20e2;
																			IL_2106:
																			if (&_u__3 == null)
																			{
																				num40 = 17;
																				continue;
																			}
																			goto IL_20e2;
																			IL_20e2:
																			response_5__ = (HttpResponseMessage)(object)(&_u__3);
																			num40 = 12;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
																			{
																				num40 = 0;
																			}
																			continue;
																			IL_2007:
																			if ((uint)(num4 - 2) > 3u)
																			{
																				num40 = 25;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
																				{
																					num40 = 16;
																				}
																				continue;
																			}
																			goto IL_2056;
																			IL_2056:
																			num40 = 10;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
																			{
																				num40 = 6;
																			}
																			continue;
																			end_IL_1291:
																			break;
																		}
																		goto IL_1f97;
																		IL_1f97:
																		_u__3 = __u__2;
																		num40 = 4;
																		goto IL_1291;
																		end_IL_126d:;
																	}
																	finally
																	{
																		if (num4 < 0)
																		{
																			int num55 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
																			{
																				num55 = 7;
																			}
																			while (true)
																			{
																				switch (num55)
																				{
																				default:
																					if (num56 == 989)
																					{
																						num55 = num56;
																						continue;
																					}
																					break;
																				case 0:
																					(unerPMXw5ZYDUl4lYsfx2.RdKXwM3Y81i).Release();
																					num55 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
																					{
																						num55 = 1;
																					}
																					continue;
																				case 1:
																					break;
																				}
																				break;
																			}
																		}
																	}
																	goto case 56;
																case 70:
																	__u__4 = default;
																	num12 = 41;
																	continue;
																case 26:
																	__7__wrap10 = null;
																	num12 = 22;
																	continue;
																case 11:
																	goto IL_21fd;
																case 43:
																	goto IL_2245;
																case 14:
																	__7__wrap10 = null;
																	num12 = 69;
																	continue;
																case 35:
																	if (_encrypted_5__10 == null)
																	{
																		num12 = 15;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
																		{
																			num12 = 80;
																		}
																		continue;
																	}
																	goto case 67;
																case 46:
																	__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																	num12 = 92;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
																	{
																		num12 = 84;
																	}
																	continue;
																case 60:
																	goto IL_22ce;
																case 64:
																	goto IL_22e5;
																case 16:
																	__t__builder.AwaitUnsafeOnCompleted<object, _DownloadAsync_d__10>(ref _u__, ref this);
																	num12 = 6;
																	continue;
																case 52:
																	__u__1 = _u__;
																	num12 = 16;
																	continue;
																case 7:
																	goto IL_233e;
																case 59:
																	if (!(_u__2).IsCompleted)
																	{
																		num12 = 65;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
																		{
																			num12 = 38;
																		}
																		continue;
																	}
																	goto case 53;
																case 1:
																	(defaultInterpolatedStringHandler3).AppendLiteral("，期望 ");
																	num12 = 37;
																	continue;
																case 54:
																	goto IL_23db;
																case 77:
																	if (!(_u__2).IsCompleted)
																	{
																		num12 = 51;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
																		{
																			num12 = 49;
																		}
																		continue;
																	}
																	goto case 4;
																case 25:
																	_encrypted_5__10 = null;
																	num12 = 6;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
																	{
																		num12 = 62;
																	}
																	continue;
																case 29:
																	__u__1 = default;
																	num12 = 82;
																	continue;
																case 45:
																	__7__wrap10 = null;
																	num12 = 46;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																	{
																		num12 = 40;
																	}
																	continue;
																case 67:
																	valueTask = (_encrypted_5__10).DisposeAsync();
																	num12 = 52;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
																	{
																		num12 = 21;
																	}
																	continue;
																case 82:
																	num4 = (__1__state = -1);
																	num12 = 47;
																	continue;
																case 4:
																	(_u__2).GetResult();
																	num12 = 63;
																	continue;
																case 49:
																	num4 = (__1__state = 8);
																	num12 = 30;
																	continue;
																case 13:
																	throw (defaultInterpolatedStringHandler2).ToStringAndClear();
																case 40:
																	__7__wrap11 = 0;
																	num12 = 64;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
																	{
																		num12 = 36;
																	}
																	continue;
																case 57:
																case 86:
																{
																	string text3 = _finalPath_5__2;
																	num12 = 10;
																	continue;
																}
																case 24:
																	valueTask = (_encrypted_5__10).DisposeAsync();
																	num12 = 55;
																	continue;
																case 2:
																	goto IL_257e;
																case 58:
																	goto IL_2590;
																case 37:
																	defaultInterpolatedStringHandler3.AppendFormatted<uint>(chunk.ChunkSize);
																	num12 = 5;
																	continue;
																case 32:
																	__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																	num12 = 52;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
																	{
																		num12 = 61;
																	}
																	continue;
																case 62:
																	_ = _compressedPath_5__4;
																	_ = 3;
																	_ = 1;
																	_ = 1;
																	global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)131072)->_encrypted_5__10, (object)1207959552);
																	_ = 26;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
																	{
																		_ = 14;
																	}
																	continue;
																case 17:
																	try
																	{
																		int num13;
																		if (num4 != 6)
																		{
																			num13 = 3;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
																			{
																				num13 = 2;
																			}
																			goto IL_2669;
																		}
																		goto IL_272e;
																		IL_2669:
																		while (true)
																		{
																			switch (num13)
																			{
																			case 5:
																				return;
																			default:
																				if (num15 == 32)
																				{
																					goto IL_275f;
																				}
																				if (num15 == 1012)
																				{
																					goto IL_2665;
																				}
																				goto case 18;
																			case 2:
																			case 20:
																				obj = __7__wrap12;
																				num13 = 11;
																				continue;
																			case 7:
																				num4 = (__1__state = 7);
																				num13 = 27;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
																				{
																					num13 = 10;
																				}
																				continue;
																			case 15:
																				break;
																			case 22:
																				__7__wrap12 = null;
																				num13 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																				{
																					num13 = 21;
																				}
																				continue;
																			case 4:
																				__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _DownloadAsync_d__10>(ref _u__2, ref this);
																				num13 = 13;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
																				{
																					num13 = 5;
																				}
																				continue;
																			case 10:
																				__u__4 = _u__2;
																				num13 = 4;
																				continue;
																			case 23:
																				_u__2 = (valueTask).GetAwaiter();
																				num13 = 12;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
																				{
																					num13 = 25;
																				}
																				continue;
																			case 1:
																			case 14:
																				__7__wrap12 = null;
																				num13 = 24;
																				continue;
																			case 3:
																				if (num4 != 7)
																				{
																					num13 = 9;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
																					{
																						num13 = 21;
																					}
																					continue;
																				}
																				goto case 16;
																			case 24:
																				_compressed_5__15 = null;
																				num13 = 20;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																				{
																					num13 = 6;
																				}
																				continue;
																			case 13:
																				try
																				{
																					int num16;
																					if (num4 != 6)
																					{
																						num16 = 4;
																						goto IL_2864;
																					}
																					goto IL_2975;
																					IL_2975:
																					_u__ = __u__1;
																					num16 = 5;
																					goto IL_2864;
																					IL_2864:
																					while (true)
																					{
																						int num18;
																						switch (num16)
																						{
																						case 9:
																							return;
																						default:
																							if (num17 != 18)
																							{
																								if (num17 == 998)
																								{
																									goto IL_2860;
																								}
																								goto case 6;
																							}
																							num4 = (__1__state = 6);
																							num16 = 1;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
																							{
																								num16 = 0;
																							}
																							continue;
																						case 8:
																							num4 = (__1__state = -1);
																							num18 = 2;
																							goto IL_285c;
																						case 4:
																							val = (Q6ETVKXwaTp4Tr9J7a2h.jaeXwv2tNAQ(_encrypted_5__10, _compressed_5__15, unerPMXw5ZYDUl4lYsfx2.qq1XwT3bhN8, cancellationToken)).ConfigureAwait(false);
																							num16 = 6;
																							continue;
																						case 1:
																							__u__1 = _u__;
																							num16 = 7;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
																							{
																								num16 = 10;
																							}
																							continue;
																						case 2:
																							(_u__).GetResult();
																							num16 = 11;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
																							{
																								num16 = 10;
																							}
																							continue;
																						case 0:
																							break;
																						case 6:
																							_u__ = val;
																							num16 = 16;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
																							{
																								num16 = 3;
																							}
																							continue;
																						case 3:
																							if (!(_u__).IsCompleted)
																							{
																								num18 = 18;
																								goto IL_285c;
																							}
																							goto case 2;
																						case 7:
																							__t__builder.AwaitUnsafeOnCompleted<object, _DownloadAsync_d__10>(ref _u__, ref this);
																							num16 = 9;
																							continue;
																						case 5:
																							__u__1 = default;
																							num16 = 14;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
																							{
																								num16 = 8;
																							}
																							continue;
																						case 10:
																							goto end_IL_2864;
																							IL_285c:
																							num17 = num18;
																							goto IL_2860;
																							IL_2860:
																							num16 = num17;
																							continue;
																						}
																						goto IL_2975;
																						continue;
																						end_IL_2864:
																						break;
																					}
																				}
																				catch (object obj2)
																				{
																					obj = obj2;
																					int num19 = 3;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																					{
																						num19 = 0;
																					}
																					while (true)
																					{
																						switch (num19)
																						{
																						default:
																							if (num20 == 989)
																							{
																								num19 = num20;
																								continue;
																							}
																							break;
																						case 0:
																							break;
																						case 1:
																							goto end_IL_2a6a;
																						}
																						__7__wrap12 = obj;
																						num19 = 7;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
																						{
																							num19 = 1;
																						}
																						continue;
																						end_IL_2a6a:
																						break;
																					}
																				}
																				goto case 17;
																			case 21:
																				__7__wrap13 = 0;
																				num13 = 15;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
																				{
																					num13 = 30;
																				}
																				continue;
																			case 9:
																				_ = _compressedPath_5__4;
																				_ = 2;
																				_ = 2;
																				_ = 0;
																				global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)131072)->_compressed_5__15, (object)1207959552);
																				_ = 22;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
																				{
																					_ = 5;
																				}
																				continue;
																			case 11:
																				if (obj == null)
																				{
																					num13 = 21;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
																					{
																						num13 = 14;
																					}
																					continue;
																				}
																				goto case 19;
																			case 18:
																				valueTask = (_compressed_5__15).DisposeAsync();
																				num13 = 23;
																				continue;
																			case 17:
																				if (_compressed_5__15 == null)
																				{
																					num13 = 2;
																					continue;
																				}
																				goto case 18;
																			case 8:
																				__u__4 = default;
																				num13 = 18;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
																				{
																					num13 = 0;
																				}
																				continue;
																			case 16:
																				_u__2 = __u__4;
																				num13 = 8;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
																				{
																					num13 = 7;
																				}
																				continue;
																			case 0:
																			{
																				num4 = (__1__state = -1);
																				int num14 = 32;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
																				{
																					num14 = 21;
																				}
																				num15 = num14;
																				goto IL_2665;
																			}
																			case 12:
																				if (!(_u__2).IsCompleted)
																				{
																					num13 = 7;
																					continue;
																				}
																				goto IL_275f;
																			case 19:
																				(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																				num13 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
																				{
																					num13 = 9;
																				}
																				continue;
																			case 6:
																				goto end_IL_2669;
																				IL_2665:
																				num13 = num15;
																				continue;
																				IL_275f:
																				(_u__2).GetResult();
																				num13 = 20;
																				continue;
																			}
																			goto IL_272e;
																			continue;
																			end_IL_2669:
																			break;
																		}
																		goto end_IL_2630;
																		IL_272e:
																		num13 = 13;
																		goto IL_2669;
																		end_IL_2630:;
																	}
																	catch (object obj3)
																	{
																		obj = obj3;
																		int num21 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
																		{
																			num21 = 6;
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
																				__7__wrap10 = obj;
																				num21 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																				{
																					num21 = 1;
																				}
																				continue;
																			case 1:
																				break;
																			}
																			break;
																		}
																	}
																	goto case 35;
																case 65:
																	__u__4 = default;
																	num12 = 9;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
																	{
																		num12 = 69;
																	}
																	continue;
																case 76:
																	throw (defaultInterpolatedStringHandler3).ToStringAndClear();
																case 22:
																	_encrypted_5__10 = null;
																	num12 = 3;
																	continue;
																case 8:
																	num4 = (__1__state = 0);
																	num12 = 52;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
																	{
																		num12 = 5;
																	}
																	continue;
																case 56:
																	_encryptedLength_5__7 = (_encryptedPath_5__3).Length;
																	num12 = 43;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
																	{
																		num12 = 64;
																	}
																	continue;
																case 71:
																	(defaultInterpolatedStringHandler3).AppendLiteral("内容分块大小不匹配：");
																	num12 = 34;
																	continue;
																case 27:
																	goto IL_2e1d;
																case 69:
																	__7__wrap11 = 0;
																	num12 = 51;
																	continue;
																case 28:
																case 50:
																	goto IL_2e4f;
																case 53:
																	(_u__2).GetResult();
																	num12 = 42;
																	continue;
																case 21:
																	_u__2 = (valueTask).GetAwaiter();
																	num12 = 40;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
																	{
																		num12 = 77;
																	}
																	continue;
																case 66:
																	(defaultInterpolatedStringHandler2).AppendLiteral("，实际 ");
																	num12 = 78;
																	continue;
																case 68:
																	goto IL_2eff;
																case 75:
																	if ((_u__).IsCompleted)
																	{
																		num12 = 83;
																		continue;
																	}
																	goto case 8;
																case 41:
																	num4 = (__1__state = -1);
																	num12 = 53;
																	continue;
																case 73:
																	goto IL_2f40;
																case 30:
																	__u__4 = _u__2;
																	num12 = 32;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
																	{
																		num12 = 62;
																	}
																	continue;
																case 33:
																	goto IL_2f78;
																case 18:
																	goto IL_2fab;
																case 44:
																case 85:
																	goto IL_2fde;
																case 10:
																	goto end_IL_01f1;
																}
																break;
																IL_2fde:
																if (unerPMXw5ZYDUl4lYsfx2.D8QXwN7Qn93 != null)
																{
																	goto IL_3015;
																}
																num12 = 56;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
																{
																	num12 = 57;
																}
																continue;
																IL_2e4f:
																System.IO.File.Move(_partPath_5__5, _finalPath_5__2, true);
																num12 = 85;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
																{
																	num12 = 53;
																}
																continue;
																IL_233e:
																if ((_finalPath_5__2).Length == chunk.DecompressSize)
																{
																	num12 = 11;
																	continue;
																}
																goto IL_2e4f;
																IL_2590:
																if (num37 == chunk.DecompressSize)
																{
																	if (!System.IO.File.Exists(_finalPath_5__2))
																	{
																		num12 = 28;
																		continue;
																	}
																	goto IL_233e;
																}
																goto IL_25a3;
																IL_2245:
																if (_encryptedLength_5__7 != chunk.ChunkSize)
																{
																	num12 = 12;
																	continue;
																}
																_ = _encryptedPath_5__3;
																_ = 3;
																_ = 1;
																_ = 1;
																global::System.Runtime.CompilerServices.Unsafe.Write(&((_DownloadAsync_d__10*)131072)->_encrypted_5__10, (object)1207959552);
																_ = 45;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
																{
																	_ = 17;
																}
															}
															goto case 9;
															IL_3015:
															_ = _encryptedLength_5__7;
															_ = 86;
															goto IL_023e;
															IL_2fab:
															(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
															num57 = 26;
															goto IL_023e;
															IL_1150:
															num12 = 19;
															goto IL_0246;
															IL_0565:
															(defaultInterpolatedStringHandler2).AppendLiteral("内容分块解压大小不匹配：");
															num57 = 27;
															goto IL_023e;
															IL_2f40:
															if (obj == null)
															{
																num57 = 94;
																goto IL_023e;
															}
															goto IL_2f78;
															IL_2f78:
															(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
															num57 = 72;
															goto IL_023e;
															IL_023e:
															num36 = num57;
															goto IL_0242;
															IL_03b5:
															if (num36 != 1074)
															{
																return;
															}
															goto IL_0242;
															IL_2eff:
															_u__ = __u__1;
															num12 = 29;
															goto IL_0246;
															IL_2e1d:
															(defaultInterpolatedStringHandler2).AppendFormatted(chunk.ChunkId);
															num57 = 39;
															goto IL_023e;
															IL_25a3:
															num57 = 48;
															goto IL_023e;
															IL_257e:
															_u__2 = __u__4;
															num12 = 70;
															goto IL_0246;
															IL_23db:
															_u__2 = __u__4;
															num12 = 65;
															goto IL_0246;
															IL_22e5:
															num12 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
															{
																num12 = 17;
															}
															goto IL_0246;
															IL_0242:
															num12 = num36;
															goto IL_0246;
															IL_22ce:
															defaultInterpolatedStringHandler3.AppendFormatted<long>(_encryptedLength_5__7);
															num57 = 76;
															goto IL_023e;
															IL_21fd:
															zlyXwxKSgpj(_partPath_5__5);
															num57 = 44;
															goto IL_023e;
															end_IL_01f1:
															break;
														}
													}
													catch (OperationCanceledException)
													{
														int num58 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
														{
															num58 = 4;
														}
														while (true)
														{
															switch (num58)
															{
															default:
																if (num59 == 988)
																{
																	goto IL_3059;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_3059:
															num58 = num59;
														}
														throw new global::System.Exception();
													}
													catch (object obj9) when (((Func<bool>)delegate
													{
														// Could not convert BlockContainer to single expression
														obj10 = obj9 as global::System.Exception;
														if (obj10 == null)
														{
															num60 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
															{
																num60 = 3;
															}
														}
														else
														{
															ex2 = obj10;
															num60 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
															{
																num60 = 1;
															}
														}
														while (true)
														{
															switch (num60)
															{
															default:
																if (num61 == 989)
																{
																	goto IL_30b4;
																}
																goto case 0;
															case 0:
																result = 0;
																break;
															case 1:
																result = ((_attempt_5__6 < 3) ? 1 : 0);
																break;
															}
															break;
															IL_30b4:
															num60 = num61;
														}
														return (byte)result != 0;
													}).Invoke())
													{
														int num62 = 6;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
														{
															num62 = 1;
														}
														while (true)
														{
															switch (num62)
															{
															default:
																if (num63 == 989)
																{
																	num62 = num63;
																	continue;
																}
																break;
															case 1:
																break;
															case 0:
																goto end_IL_313f;
															}
															num8 = 1;
															num62 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
															{
																num62 = 0;
															}
															continue;
															end_IL_313f:
															break;
														}
														goto case 2;
													}
													goto end_IL_0074;
												case 0:
													num4 = (__1__state = -1);
													num11 = 14;
													continue;
												case 1:
													break;
												case 9:
													__u__1 = default;
													num11 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
													{
														num11 = 1;
													}
													continue;
												case 11:
													if (!(_u__).IsCompleted)
													{
														goto IL_320d;
													}
													goto case 14;
												case 10:
													__u__1 = _u__;
													num11 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
													{
														num11 = 8;
													}
													continue;
												case 8:
													if (num4 != 13)
													{
														num11 = 15;
														continue;
													}
													goto case 7;
												case 3:
													_u__ = val;
													num11 = 11;
													continue;
												case 2:
													if (num8 == 1)
													{
														num11 = 6;
														continue;
													}
													goto end_IL_0135;
												case 14:
													(_u__).GetResult();
													num11 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
													{
														num11 = 18;
													}
													continue;
												case 13:
													num4 = (__1__state = 13);
													num11 = 10;
													continue;
												case 12:
													goto IL_32b2;
												case 6:
													val = (System.Threading.Tasks.Task.Delay(System.TimeSpan.FromMilliseconds(250 * _attempt_5__6), cancellationToken)).ConfigureAwait(false);
													num11 = 9;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
													{
														num11 = 3;
													}
													continue;
												case 5:
													goto end_IL_0135;
												}
												break;
											}
											__t__builder.AwaitUnsafeOnCompleted<object, _DownloadAsync_d__10>(ref _u__, ref this);
											num9 = 23;
											goto IL_0152;
											IL_32b2:
											num11 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
											{
												num11 = 7;
											}
											goto IL_015a;
											end_IL_0135:;
										}
										finally
										{
											if (num4 < 0)
											{
												int num64 = 2;
												while (true)
												{
													switch (num64)
													{
													default:
														if (num66 != 10)
														{
															if (num66 != 990)
															{
																break;
															}
															goto IL_334a;
														}
														goto end_IL_334e;
													case 2:
														zlyXwxKSgpj(_encryptedPath_5__3);
														num64 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
														{
															num64 = 0;
														}
														continue;
													case 0:
														break;
													case 1:
														{
															zlyXwxKSgpj(_partPath_5__5);
															int num65 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
															{
																num65 = 10;
															}
															num66 = num65;
															goto IL_334a;
														}
														IL_334a:
														num64 = num66;
														continue;
													}
													zlyXwxKSgpj(_compressedPath_5__4);
													num64 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
													{
														num64 = 3;
													}
													continue;
													end_IL_334e:
													break;
												}
											}
										}
										goto case 5;
									case 1:
										_attempt_5__6 = 1;
										num5 = 21;
										continue;
									case 3:
										break;
									case 15:
									case 21:
										goto IL_3433;
									case 2:
										goto end_IL_0074;
									case 9:
										goto IL_3458;
									case 6:
										_compressedPath_5__4 = string.Concat(_finalPath_5__2, text, ".zst");
										num5 = 11;
										continue;
									case 19:
										(defaultInterpolatedStringHandler).AppendLiteral(".");
										num5 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
										{
											num5 = 3;
										}
										continue;
									case 11:
										_partPath_5__5 = string.Concat(_finalPath_5__2, text, ".part");
										num5 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
										{
											num5 = 1;
										}
										continue;
									case 5:
										num8 = _attempt_5__6;
										num5 = 20;
										continue;
									case 0:
										_ = 2;
										defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
										_ = 19;
										continue;
									case 10:
										if (System.IO.File.Exists(_finalPath_5__2))
										{
											num5 = 30;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
											{
												num5 = 18;
											}
											continue;
										}
										goto case 0;
									case 18:
										if ((_finalPath_5__2).Length == chunk.DecompressSize)
										{
											num5 = 7;
											continue;
										}
										goto case 24;
									case 24:
										zlyXwxKSgpj(_finalPath_5__2);
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
										{
											num5 = 7;
										}
										continue;
									case 23:
										text2 = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes((chunk.Url).AbsoluteUri)));
										num5 = 12;
										continue;
									case 22:
										text = (defaultInterpolatedStringHandler).ToStringAndClear();
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
										{
											num5 = 14;
										}
										continue;
									case 4:
									case 8:
									{
										string text3 = _finalPath_5__2;
										num5 = 2;
										continue;
									}
									case 13:
										defaultInterpolatedStringHandler.AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
										num5 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
										{
											num5 = 8;
										}
										continue;
									case 20:
										_attempt_5__6 = num8 + 1;
										num5 = 15;
										continue;
									case 12:
										_finalPath_5__2 = System.IO.Path.Combine((string)unerPMXw5ZYDUl4lYsfx2.VKXXwsNKasT, string.Concat(text2, ".chunk"));
										num5 = 10;
										continue;
									case 14:
										_encryptedPath_5__3 = string.Concat(_finalPath_5__2, text, ".encrypted");
										num5 = 6;
										continue;
									case 16:
										(defaultInterpolatedStringHandler).AppendLiteral(".");
										num5 = 13;
										continue;
									case 7:
										goto IL_378c;
									case 17:
										throw string.Concat("内容分块下载失败：", chunk.ChunkId);
									}
									break;
									IL_378c:
									if (unerPMXw5ZYDUl4lYsfx2.D8QXwN7Qn93 == null)
									{
										num5 = 8;
										continue;
									}
									_ = chunk.ChunkSize;
									_ = 4;
								}
								defaultInterpolatedStringHandler.AppendFormatted<int>(System.Environment.ProcessId);
								num7 = 16;
								goto IL_0091;
								IL_3433:
								if (_attempt_5__6 > 3)
								{
									num7 = 17;
									goto IL_0091;
								}
								goto IL_3458;
								IL_3458:
								num7 = 32;
								goto IL_0091;
								IL_0095:
								num5 = num6;
								goto IL_0099;
								end_IL_0074:;
							}
							catch (global::System.Exception)
							{
								int num67 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
								{
									num67 = 4;
								}
								while (true)
								{
									switch (num67)
									{
									case 0:
										return;
									default:
										if (num68 == 990)
										{
											num67 = num68;
											continue;
										}
										break;
									case 1:
										_ = __t__builder;
										_ = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
										{
											_ = 0;
										}
										continue;
									case 2:
										break;
									}
									__1__state = -2;
									num67 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
									{
										num67 = 2;
									}
								}
							}
							goto case 3;
						case 2:
							num4 = __1__state;
							num3 = 1;
							continue;
						case 1:
							unerPMXw5ZYDUl4lYsfx2 = __4__this;
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							__1__state = -2;
							num = 4;
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
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							return;
						case 2:
							num3 = 1;
							continue;
						case 1:
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
				while (num2 == 990);
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
				{
					num = 6;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool VT50rj9zfuKLnnukTIjw()
		{
			return LlePvR9zXN1yA6eaEoqA == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object XtY3Xe9zLoaNVBPKdFCM()
		{
			return LlePvR9zXN1yA6eaEoqA;
		}
	}

	private readonly object JRrXwFbREyy;

	private readonly object VKXXwsNKasT;

	private readonly object qq1XwT3bhN8;

	private readonly Action<long>? D8QXwN7Qn93;

	private readonly object RdKXwM3Y81i;

	private readonly ConcurrentDictionary<string, Lazy<global::System.Threading.Tasks.Task<string>>> BKSXwpwRkOb;

	private bool IxTXwuFhIX5;

	private static object eiO6LSZ6QsqpZ3ZiuH2n;

	[MethodImpl((MethodImplOptions)8)]
	internal unerPMXw5ZYDUl4lYsfx(string cachePath, string aesKey, Action<long>? downloadCompleted = null, HttpMessageHandler? handler = null)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		BKSXwpwRkOb = (ConcurrentDictionary<string, Lazy<global::System.Threading.Tasks.Task<string>>>)(object)System.StringComparer.Ordinal;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe global::System.Threading.Tasks.Task<string> HcdXwR1KSTh(TskRBqXeQChlIH5eQbGM chunk, CancellationToken cancellationToken)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
		(defaultInterpolatedStringHandler).AppendLiteral("|");
		_ = 11;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053;
		__c__DisplayClass8_0_2 _c__DisplayClass8_0_ = default;
		((AsyncTaskMethodBuilder)1).AwaitUnsafeOnCompleted<object, QpE8CgGIjI48WnWx3D1._SuppressObservationCancellationAsync_d__31>(ref defaultInterpolatedStringHandler, ref *(QpE8CgGIjI48WnWx3D1._SuppressObservationCancellationAsync_d__31*)_c__DisplayClass8_0_.chunk.ChunkSize);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<string> JQ8XwwUcfjH(string key, Lazy<global::System.Threading.Tasks.Task<string>> lazy)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<string> J0oXwevqLdZ(TskRBqXeQChlIH5eQbGM chunk, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void fvXXwPQ4Yq3(object chunk)
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
								goto end_IL_0010;
							}
							goto case 1;
						}
						if (((TskRBqXeQChlIH5eQbGM)chunk).DecompressSize != 0)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 0;
					case 0:
						throw string.Concat("内容分块信息无效：", ((TskRBqXeQChlIH5eQbGM)chunk).ChunkId);
					case 1:
						if (asSKN6XwQWbqwYE9yILe.HSIXw7qMipF(((TskRBqXeQChlIH5eQbGM)chunk).Url))
						{
							return;
						}
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						if (((TskRBqXeQChlIH5eQbGM)chunk).ChunkSize != 0)
						{
							break;
						}
						goto case 0;
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
			num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void zlyXwxKSgpj(object path)
	{
		int num = 1;
		int num3 = default;
		int num5 = default;
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
				if (!System.IO.File.Exists((string)path))
				{
					return;
				}
				int num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					default:
						if (num3 != 989)
						{
							return;
						}
						num2 = num3;
						break;
					case 1:
						System.IO.File.Delete((string)path);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
			catch (global::System.Exception)
			{
				int num4 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
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
	public void Dispose()
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
						if (num2 == 10)
						{
							(JRrXwFbREyy).Dispose();
							num3 = 3;
							continue;
						}
						goto IL_0033;
					case 3:
						return;
					case 0:
						return;
					case 2:
						goto end_IL_000c;
					case 1:
						break;
					}
					goto IL_00a2;
					IL_0033:
					if (num2 == 991)
					{
						break;
					}
					goto IL_00a2;
					IL_00a2:
					if (!IxTXwuFhIX5)
					{
						IxTXwuFhIX5 = true;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num3 = 5;
						}
					}
					else
					{
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
						{
							num3 = 0;
						}
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			(RdKXwM3Y81i).Dispose();
			num = 10;
		}
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
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						return;
					case 1:
						break;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
						{
							num3 = 1;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jb2Hs6Z6CjlXUtlwpKWP()
	{
		return eiO6LSZ6QsqpZ3ZiuH2n == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static unerPMXw5ZYDUl4lYsfx ThsJIfZ645bxvGi3Jqop()
	{
		return (unerPMXw5ZYDUl4lYsfx)eiO6LSZ6QsqpZ3ZiuH2n;
	}
}

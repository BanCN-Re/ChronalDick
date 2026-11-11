using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace b53iPpXMJRnlXyrk1GwO;

sealed class no9jkQXMWVmKXSFPv1CU : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _AcquireAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<no9jkQXMWVmKXSFPv1CU> __t__builder;

		public string rootPath;

		public CancellationToken cancellationToken;

		private string _lockPath_5__2;

		private object __u__1;

		internal static object jcX8wfDf16s5eZBlnUjP;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_061f: Expected O, but got Unknown
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			//IL_059f: Expected O, but got Unknown
			//IL_069b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0269: Expected O, but got I4
			//IL_03b6: Expected O, but got I4
			//IL_041c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Expected O, but got I4
			//IL_086f->IL082e: Incompatible stack heights: 3 vs 1
			//IL_087a->IL082e: Incompatible stack heights: 3 vs 1
			//IL_08cd->IL0010: Incompatible stack heights: 3 vs 1
			//IL_08d8->IL0010: Incompatible stack heights: 3 vs 1
			//IL_032b->IL02f2: Incompatible stack heights: 5 vs 6
			//IL_02f6->IL02f6: Incompatible stack heights: 7 vs 6
			int num = 3;
			int num4 = default;
			string text = default;
			int num7 = default;
			int num8 = default;
			object _u__ = default;
			ConfiguredTaskAwaitable val = default;
			int num10 = default;
			int num13 = default;
			byte[] array = default;
			int num15 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj3);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num16);
			IOException ex = default;
			int num17 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num19 = default;
			int num21 = default;
			int num23 = default;
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
								goto end_IL_0010;
							}
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 13;
									goto IL_006a;
								}
								goto IL_0233;
								IL_0233:
								if (string.IsNullOrWhiteSpace(rootPath))
								{
									num5 = 4;
								}
								else
								{
									text = System.IO.Path.GetFullPath(rootPath);
									num5 = 18;
								}
								goto IL_006a;
								IL_006a:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num7 != 27)
										{
											if (num7 == 1007)
											{
												goto IL_0066;
											}
											goto case 0;
										}
										_lockPath_5__2 = System.IO.Path.Combine(text, ".chronal-install.lock");
										num5 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
										{
											num5 = 18;
										}
										continue;
									case 17:
										num4 = (__1__state = 0);
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
										{
											num5 = 11;
										}
										continue;
									case 0:
										num4 = (__1__state = -1);
										num5 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
										{
											num5 = 16;
										}
										continue;
									case 10:
										if (num8 == 1)
										{
											num5 = 6;
											continue;
										}
										goto case 5;
									case 8:
										if (!(_u__).IsCompleted)
										{
											num5 = 17;
											continue;
										}
										goto case 16;
									case 3:
										return;
									case 15:
										_u__ = val;
										num5 = 8;
										continue;
									case 1:
										__t__builder.AwaitUnsafeOnCompleted<object, _AcquireAsync_d__4>(ref _u__, ref this);
										num5 = 3;
										continue;
									case 12:
										__u__1 = default;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
										{
											num5 = 17;
										}
										continue;
									case 16:
										(_u__).GetResult();
										num5 = 5;
										continue;
									case 13:
									case 14:
										_u__ = __u__1;
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
										{
											num5 = 4;
										}
										continue;
									case 11:
										__u__1 = _u__;
										num5 = 19;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
										{
											num5 = 1;
										}
										continue;
									case 9:
										break;
									case 7:
										try
										{
											_ = _lockPath_5__2;
											_ = 4;
											_ = 3;
											_ = 0;
											_ = 256;
											FileStream val2 = (FileStream)(object)(-2147483648);
											int num9 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
											{
												num9 = 0;
											}
											while (true)
											{
												switch (num9)
												{
												default:
													if (num10 == 988)
													{
														goto IL_0296;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_0296:
												num9 = num10;
											}
											try
											{
												(val2).SetLength(0L);
												int num11 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
												{
													num11 = 0;
												}
												while (true)
												{
													switch (num11)
													{
													default:
														switch (num13)
														{
														case 992:
															continue;
														case 12:
															(val2).Write(array, 0, array.Length);
															num11 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
															{
																num11 = 6;
															}
															continue;
														}
														break;
													case 4:
														(val2).Flush(true);
														num11 = 3;
														continue;
													case 3:
														(val2).Position = 0L;
														num11 = 10;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
														{
															num11 = 1;
														}
														continue;
													case 0:
													{
														System.Text.Encoding.UTF8;
														global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
														(defaultInterpolatedStringHandler).AppendLiteral("pid=");
														defaultInterpolatedStringHandler.AppendFormatted<int>(System.Environment.ProcessId);
														(defaultInterpolatedStringHandler).AppendLiteral(";utc=");
														defaultInterpolatedStringHandler.AppendFormatted<DateTimeOffset>(System.DateTimeOffset.UtcNow, "O");
														array = (9).GetBytes((defaultInterpolatedStringHandler).ToStringAndClear());
														int num12 = 12;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
														{
															num12 = 10;
														}
														num13 = num12;
														continue;
													}
													case 1:
														break;
													case 2:
														goto end_IL_02f6;
													}
													no9jkQXMWVmKXSFPv1CU no9jkQXMWVmKXSFPv1CU2 = (no9jkQXMWVmKXSFPv1CU)new no9jkQXMWVmKXSFPv1CU(val2);
													num11 = 2;
													continue;
													end_IL_02f6:
													break;
												}
											}
											catch
											{
												int num14 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
												{
													num14 = 0;
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
														(val2).Dispose();
														num14 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
														{
															num14 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
												throw new global::System.Exception();
											}
										}
										catch (object obj2) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj3 = ((obj2 is IOException) ? obj2 : null);
											if (obj3 == null)
											{
												num16 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
												{
													num16 = 0;
												}
											}
											else
											{
												ex = (IOException)obj3;
												num16 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
												{
													num16 = 1;
												}
											}
											while (true)
											{
												switch (num16)
												{
												default:
													if (num17 == 989)
													{
														goto IL_0548;
													}
													goto case 0;
												case 0:
													result = 0;
													break;
												case 1:
													result = (d10XMCmSLmS(ex) ? 1 : 0);
													break;
												}
												break;
												IL_0548:
												num16 = num17;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num18 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
											{
												num18 = 1;
											}
											while (true)
											{
												switch (num18)
												{
												case 0:
													break;
												default:
													if (num19 == 989)
													{
														num18 = num19;
														continue;
													}
													break;
												case 1:
													num8 = 1;
													num18 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
													{
														num18 = 0;
													}
													continue;
												}
												break;
											}
											goto case 10;
										}
										catch (IOException ex2)
										{
											IOException ex3 = ex2;
											int num20 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
											{
												num20 = 2;
											}
											while (true)
											{
												switch (num20)
												{
												default:
													if (num21 == 988)
													{
														goto IL_064c;
													}
													break;
												case 0:
													break;
												}
												break;
												IL_064c:
												num20 = num21;
											}
											_ = "无法创建客户端安装锁";
											throw ex3;
										}
										goto end_IL_006a;
									case 6:
										val = (System.Threading.Tasks.Task.Delay(bjRXMhkuorU, cancellationToken)).ConfigureAwait(false);
										num5 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num5 = 15;
										}
										continue;
									case 2:
										num8 = 0;
										num5 = 7;
										continue;
									case 4:
										_ = "客户端根目录不能为空";
										throw new global::System.Exception("rootPath");
									case 18:
									{
										System.IO.Directory.CreateDirectory(text);
										int num6 = 26;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
										{
											num6 = 27;
										}
										num7 = num6;
										goto IL_0066;
									}
									case 5:
									case 19:
										{
											(cancellationToken).ThrowIfCancellationRequested();
											num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
											{
												num5 = 14;
											}
											continue;
										}
										IL_0066:
										num5 = num7;
										continue;
									}
									goto IL_0233;
									continue;
									end_IL_006a:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num22 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
								{
									num22 = 0;
								}
								while (true)
								{
									switch (num22)
									{
									default:
										if (num23 == 990)
										{
											num22 = num23;
											break;
										}
										return;
									case 2:
										_ = __t__builder;
										_ = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
										{
											_ = 1;
										}
										break;
									case 0:
										__1__state = -2;
										num22 = 2;
										break;
									case 1:
										return;
									}
								}
							}
							goto case 2;
						case 0:
							_ = __t__builder;
							_ = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								_ = 7;
							}
							continue;
						case 3:
							break;
						case 1:
							return;
						case 2:
							__1__state = -2;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
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
					if (num2 != 991)
					{
						return;
					}
					continue;
					end_IL_000c:
					break;
				}
				num4 = __1__state;
				num = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
				{
					num = 10;
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
						case 1:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 2;
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
				while (num2 == 990);
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
				{
					num = 5;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool HUylZODf3aybs7wjTiMD()
		{
			return jcX8wfDf16s5eZBlnUjP == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object PpPrg8DfvB0dfaIEj9EX()
		{
			return jcX8wfDf16s5eZBlnUjP;
		}
	}

	private static TimeSpan bjRXMhkuorU;

	private FileStream? jTNXMUJSNnf;

	internal static object h6uG6hZw2BSZoHGiByEa;

	[MethodImpl((MethodImplOptions)8)]
	private no9jkQXMWVmKXSFPv1CU(FileStream stream)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<no9jkQXMWVmKXSFPv1CU> nY8XMQGS6pH(object rootPath, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool d10XMCmSLmS(object exception)
	{
		int num = 4;
		bool result = default;
		int num4 = default;
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
							goto case 0;
						}
						goto case 2;
					case 1:
						break;
					case 0:
						result = false;
						num3 = 2;
						continue;
					case 4:
						num4 = (exception).HResult & 0xFFFF;
						num3 = 3;
						continue;
					case 2:
						return result;
					case 3:
						if ((uint)(num4 - 32) <= 1u)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
							{
								num3 = 1;
							}
							continue;
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
			result = true;
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
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
							goto case 3;
						}
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
						{
							num3 = 9;
						}
						continue;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num = 2;
						break;
					case 2:
						bjRXMhkuorU = System.TimeSpan.FromMilliseconds(200.0);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
					case 4:
						num = 11;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Ik6w2IZwqURxvkaAhRSW()
	{
		return h6uG6hZw2BSZoHGiByEa == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static no9jkQXMWVmKXSFPv1CU WssID8ZwGAHOQNWD3gPS()
	{
		return (no9jkQXMWVmKXSFPv1CU)h6uG6hZw2BSZoHGiByEa;
	}
}

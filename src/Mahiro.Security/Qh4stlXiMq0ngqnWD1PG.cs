using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using LioRGnXnTmo7MsqH4aeD;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;
using gOHobQXi6HMDyrTGUVcV;
using iM65eRXiKVWZgs63pZCd;

namespace CEPYrrXipayLqARwPYlb;

sealed class Qh4stlXiMq0ngqnWD1PG : global::System.IDisposable
{
	private readonly object mnIXiuJgM3Q;

	private readonly object btaXiaLjZYY;

	private bool pE4Xi1NoIVx;

	internal static object ntJTOsZFKhNRVBQGJL20;

	[MethodImpl((MethodImplOptions)8)]
	private Qh4stlXiMq0ngqnWD1PG(Process process, SafeProcessHandle handle)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Qh4stlXiMq0ngqnWD1PG Acquire(object process, ulong moduleAddress, Func<ulong, bool>? additionalUnsafeInstruction = null)
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		Qh4stlXiMq0ngqnWD1PG qh4stlXiMq0ngqnWD1PG = default(Qh4stlXiMq0ngqnWD1PG);
		SafeProcessHandle val = default(SafeProcessHandle);
		Qh4stlXiMq0ngqnWD1PG result = default(Qh4stlXiMq0ngqnWD1PG);
		int num4 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_000d;
							}
							goto case 1;
						}
						qh4stlXiMq0ngqnWD1PG = (Qh4stlXiMq0ngqnWD1PG)new Qh4stlXiMq0ngqnWD1PG((Process)process, val);
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 6;
						}
						break;
					case 5:
						val = HJc6fUXnsRJpQ1ZM1yft.OpenProcess(2048u, inheritHandle: false, checked((uint)((dynamic)(process)).Id));
						num3 = 4;
						break;
					case 8:
						(val).Dispose();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
						{
							num3 = 12;
						}
						break;
					case 1:
						return result;
					case 0:
					{
						int num5 = System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						(val).Dispose();
						throw new Win32Exception(num5, "Unable to open native fingerprint suspension handle");
					}
					case 4:
						if (!(val).IsInvalid)
						{
							num4 = NtSuspendProcess(val);
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num3 = 10;
							}
						}
						else
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num3 = 0;
							}
						}
						break;
					case 6:
						try
						{
							ValidateInstructionPointers(process, moduleAddress, additionalUnsafeInstruction);
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
							{
								num6 = 0;
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
									break;
								case 0:
									goto end_IL_017f;
								}
								result = qh4stlXiMq0ngqnWD1PG;
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_017f:
								break;
							}
						}
						catch
						{
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 989)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									qh4stlXiMq0ngqnWD1PG.Dispose();
									num8 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
									{
										num8 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
							throw;
						}
						goto case 1;
					case 7:
						throw new InvalidOperationException((defaultInterpolatedStringHandler).ToStringAndClear());
					case 2:
						defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(47, 1);
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
						{
							num3 = 9;
						}
						break;
					case 3:
						defaultInterpolatedStringHandler.AppendFormatted<int>(num4, "X8");
						num3 = 7;
						break;
					case 10:
						if (num4 >= 0)
						{
							goto end_IL_0009;
						}
						goto case 8;
					case 9:
						(defaultInterpolatedStringHandler).AppendLiteral("Unable to suspend native fingerprint target: 0x");
						num3 = 3;
						break;
					}
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void ValidateInstructionPointers(object process, ulong moduleAddress, Func<ulong, bool>? additionalUnsafeInstruction)
	{
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0354: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		nint num4 = default(nint);
		global::System.Collections.IEnumerator enumerator = default(global::System.Collections.IEnumerator);
		int num8 = default(int);
		ProcessThread val = default(ProcessThread);
		ProcessThread val3 = default(ProcessThread);
		int num11 = default(int);
		int num21 = default(int);
		ulong num16 = default(ulong);
		global::System.Collections.Generic.IEnumerator<bjsovlXid1IZ1bYL6Xwl> enumerator2 = default(global::System.Collections.Generic.IEnumerator<bjsovlXid1IZ1bYL6Xwl>);
		int num14 = default(int);
		bjsovlXid1IZ1bYL6Xwl current = default(bjsovlXid1IZ1bYL6Xwl);
		ulong num17 = default(ulong);
		int num19 = default(int);
		int num22 = default(int);
		int num25 = default(int);
		int num27 = default(int);
		int num29 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001e;
				case 2:
					return;
				case 0:
					try
					{
						nint num3 = (nint)(((num4).ToInt64() + 15) & -16);
						int num5 = 2;
						while (true)
						{
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									goto IL_0077;
								case 2:
									((dynamic)(process)).Refresh();
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num6 = 6;
									}
									continue;
								case 1:
									enumerator = (((dynamic)(process)).Threads).GetEnumerator();
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
									{
										num6 = 0;
									}
									continue;
								case 0:
									break;
								}
								goto IL_00eb;
								IL_0077:
								if (num5 == 990)
								{
									break;
								}
								goto IL_00eb;
								IL_00eb:
								try
								{
									while (true)
									{
										IL_0182:
										if (!(enumerator).MoveNext())
										{
											int num7 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
											{
												num7 = 11;
											}
											num8 = num7;
											goto IL_0108;
										}
										goto IL_0165;
										IL_0165:
										val = (ProcessThread)(enumerator).Current;
										int num9 = 1;
										goto IL_010c;
										IL_0108:
										num9 = num8;
										goto IL_010c;
										IL_010c:
										while (true)
										{
											switch (num9)
											{
											case 1:
												val3 = val;
												num9 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
												{
													num9 = 0;
												}
												continue;
											case 3:
												goto IL_0165;
											case 2:
												goto IL_0182;
											case 0:
												try
												{
													SafeWaitHandle val2 = OpenThread(8u, inheritHandle: false, checked((uint)(val).Id));
													int num10 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
													{
														num10 = 0;
													}
													while (true)
													{
														switch (num10)
														{
														default:
															if (num11 == 988)
															{
																goto IL_01f6;
															}
															break;
														case 0:
															break;
														}
														break;
														IL_01f6:
														num10 = num11;
													}
													try
													{
														if ((val2).IsInvalid)
														{
															goto IL_032f;
														}
														int num12 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
														{
															num12 = 16;
														}
														while (true)
														{
															int num20;
															switch (num12)
															{
															default:
																if (num21 != 16)
																{
																	if (num21 == 996)
																	{
																		goto IL_0255;
																	}
																	goto case 2;
																}
																if (!GetThreadContext(val2, num3))
																{
																	num12 = 3;
																	continue;
																}
																num16 = (ulong)System.Runtime.InteropServices.Marshal.ReadInt64(num3, 248);
																num12 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
																{
																	num12 = 4;
																}
																continue;
															case 6:
																throw new InvalidOperationException("原生诊断调用指令正在执行");
															case 2:
																enumerator2 = ((global::System.Collections.Generic.IEnumerable<bjsovlXid1IZ1bYL6Xwl>)s5JXjPXi58Pbj27Zb6pF.Sites).GetEnumerator();
																num12 = 4;
																continue;
															case 0:
																if (additionalUnsafeInstruction == null)
																{
																	num12 = 8;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
																	{
																		num12 = 2;
																	}
																	continue;
																}
																goto case 7;
															case 7:
																if (additionalUnsafeInstruction.Invoke(num16))
																{
																	num12 = 6;
																	continue;
																}
																goto case 2;
															case 5:
																break;
															case 1:
																System.Runtime.InteropServices.Marshal.Copy(new byte[1232], 0, num3, 1232);
																num20 = 8;
																goto IL_0251;
															case 8:
																System.Runtime.InteropServices.Marshal.WriteInt32(num3, 48, 1048577);
																num20 = 16;
																goto IL_0251;
															case 3:
																throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "Unable to read suspended thread context");
															case 4:
																{
																	try
																	{
																		while (true)
																		{
																			IL_04f7:
																			int num13;
																			if (!(enumerator2).MoveNext())
																			{
																				num13 = 5;
																				goto IL_0455;
																			}
																			goto IL_0493;
																			IL_0451:
																			num13 = num14;
																			goto IL_0455;
																			IL_0493:
																			current = enumerator2.Current;
																			int num15 = 12;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
																			{
																				num15 = 13;
																			}
																			num14 = num15;
																			goto IL_0451;
																			IL_0455:
																			while (true)
																			{
																				switch (num13)
																				{
																				case 1:
																					goto end_IL_0455;
																				case 0:
																					throw new InvalidOperationException("原生设备指纹指令正在执行，请重新启动游戏");
																				case 3:
																					goto IL_04f7;
																				case 2:
																					if (num16 <= num17)
																					{
																						num13 = 3;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																						{
																							num13 = 5;
																						}
																						continue;
																					}
																					goto case 4;
																				case 4:
																					if (num16 < (ulong)((long)num17 + (long)((current.OriginalHex).Length / 2)))
																					{
																						num13 = 0;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
																						{
																							num13 = 1;
																						}
																						continue;
																					}
																					goto IL_04f7;
																				case 5:
																					goto end_IL_04f7;
																				}
																				switch (num14)
																				{
																				case 993:
																					break;
																				default:
																					goto end_IL_04f7;
																				case 13:
																					num17 = checked(moduleAddress + current.Rva);
																					num13 = 2;
																					continue;
																				}
																				goto IL_0451;
																				continue;
																				end_IL_0455:
																				break;
																			}
																			goto IL_0493;
																			continue;
																			end_IL_04f7:
																			break;
																		}
																	}
																	finally
																	{
																		int num18;
																		if (enumerator2 == null)
																		{
																			num18 = 2;
																			goto IL_05c3;
																		}
																		goto IL_05e7;
																		IL_05e7:
																		(enumerator2).Dispose();
																		num18 = 6;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																		{
																			num18 = 1;
																		}
																		goto IL_05c3;
																		IL_05c3:
																		while (true)
																		{
																			switch (num18)
																			{
																			default:
																				if (num19 == 990)
																				{
																					goto IL_05bf;
																				}
																				goto end_IL_05c3;
																			case 0:
																				break;
																			case 2:
																				goto end_IL_05c3;
																			case 1:
																				goto end_IL_05c3;
																			}
																			goto IL_05e7;
																			IL_05bf:
																			num18 = num19;
																			continue;
																			end_IL_05c3:
																			break;
																		}
																	}
																	goto end_IL_0259;
																}
																IL_0251:
																num21 = num20;
																goto IL_0255;
																IL_0255:
																num12 = num21;
																continue;
															}
															goto IL_032f;
															continue;
															end_IL_0259:
															break;
														}
														goto end_IL_0217;
														IL_032f:
														throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "Unable to inspect suspended thread");
														end_IL_0217:;
													}
													finally
													{
														if (val2 == null)
														{
															num22 = 2;
															goto IL_0656;
														}
														goto IL_067e;
														IL_067e:
														(val2).Dispose();
														int num23 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
														{
															num23 = 4;
														}
														goto IL_065a;
														IL_0656:
														num23 = num22;
														goto IL_065a;
														IL_065a:
														switch (num23)
														{
														case 1:
															goto IL_067e;
														case 2:
															goto end_IL_0637;
														case 0:
															goto end_IL_0637;
														}
														if (num22 == 990)
														{
															goto IL_0656;
														}
														goto IL_067e;
														end_IL_0637:;
													}
												}
												finally
												{
													int num24;
													if (val3 == null)
													{
														num24 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
														{
															num24 = 7;
														}
														goto IL_0706;
													}
													goto IL_074e;
													IL_0706:
													while (true)
													{
														switch (num24)
														{
														default:
															if (num25 == 990)
															{
																goto IL_0702;
															}
															break;
														case 0:
															goto end_IL_0706;
														case 1:
															break;
														case 2:
															goto end_IL_0706;
														}
														goto IL_074e;
														IL_0702:
														num24 = num25;
														continue;
														end_IL_0706:
														break;
													}
													goto end_IL_06ce;
													IL_074e:
													(val3).Dispose();
													num24 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
													{
														num24 = 2;
													}
													goto IL_0706;
													end_IL_06ce:;
												}
												goto IL_0182;
											}
											break;
										}
										switch (num8)
										{
										case 11:
											return;
										case 991:
											break;
										default:
											continue;
										}
										goto IL_0108;
									}
								}
								finally
								{
									global::System.IDisposable disposable = enumerator as global::System.IDisposable;
									int num26 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										num26 = 1;
									}
									while (true)
									{
										switch (num26)
										{
										default:
											if (num27 == 991)
											{
												num26 = num27;
												continue;
											}
											goto case 0;
										case 0:
											(disposable).Dispose();
											num26 = 2;
											continue;
										case 1:
											if (disposable == null)
											{
												num26 = 3;
												continue;
											}
											goto case 0;
										case 3:
											break;
										case 2:
											break;
										}
										break;
									}
								}
							}
						}
					}
					finally
					{
						System.Runtime.InteropServices.Marshal.FreeHGlobal(num4);
						int num28 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
						{
							num28 = 0;
						}
						while (true)
						{
							switch (num28)
							{
							default:
								if (num29 == 988)
								{
									num28 = num29;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				case 1:
					break;
				}
				goto IL_08c5;
				IL_001e:
				if (num == 990)
				{
					break;
				}
				goto IL_08c5;
				IL_08c5:
				num4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(1247);
				num2 = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num5 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 992)
					{
						goto end_IL_000d;
					}
					goto case 2;
				case 4:
					return;
				case 1:
					return;
				case 2:
					pE4Xi1NoIVx = true;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
					{
						num2 = 5;
					}
					break;
				case 3:
					if (pE4Xi1NoIVx)
					{
						return;
					}
					num2 = 2;
					break;
				case 0:
					try
					{
						int num3 = NtResumeProcess((SafeProcessHandle)mnIXiuJgM3Q);
						int num4 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num4 = 2;
						}
						while (true)
						{
							switch (num4)
							{
							case 0:
								return;
							case 4:
								return;
							default:
								switch (num5)
								{
								default:
									return;
								case 995:
									break;
								case 15:
									defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(46, 1);
									num4 = 7;
									goto end_IL_00d9;
								}
								goto IL_00d5;
							case 1:
								((dynamic)(btaXiaLjZYY)).Kill();
								num5 = 15;
								goto IL_00d5;
							case 5:
								defaultInterpolatedStringHandler.AppendFormatted<int>(num3, "X8");
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
								{
									num4 = 6;
								}
								break;
							case 7:
								(defaultInterpolatedStringHandler).AppendLiteral("Unable to resume native fingerprint target: 0x");
								num4 = 5;
								break;
							case 3:
								if (((dynamic)(btaXiaLjZYY)).HasExited)
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 1;
							case 2:
								if (num3 >= 0)
								{
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
									{
										num4 = 1;
									}
									break;
								}
								goto case 3;
							case 6:
								{
									throw new InvalidOperationException((defaultInterpolatedStringHandler).ToStringAndClear());
								}
								IL_00d5:
								num4 = num5;
								break;
								end_IL_00d9:
								break;
							}
						}
					}
					finally
					{
						((dynamic)(mnIXiuJgM3Q)).Dispose();
						int num6 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									num6 = num7;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				}
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[DllImport("ntdll.dll", ExactSpelling = true)]
	private static extern int NtSuspendProcess(SafeProcessHandle process);

	[DllImport("ntdll.dll", ExactSpelling = true)]
	private static extern int NtResumeProcess(SafeProcessHandle process);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern SafeWaitHandle OpenThread(uint access, bool inheritHandle, uint threadId);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetThreadContext(SafeWaitHandle thread, nint context);

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool L1N8mxZFHoupFMODMl42()
	{
		return ntJTOsZFKhNRVBQGJL20 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Qh4stlXiMq0ngqnWD1PG DBcnWxZFtO7xrnsSrj4G()
	{
		return (Qh4stlXiMq0ngqnWD1PG)ntJTOsZFKhNRVBQGJL20;
	}
}

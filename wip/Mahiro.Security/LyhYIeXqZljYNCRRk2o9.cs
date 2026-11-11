using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using MWciMsXqgRcoiTZlBKAW;
using OWRumnXNe7U48tXBXFAY;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using pP8gJUXq52Ip5dHhgodd;
using sjGx70Xqrvb4N3a6V79Z;

namespace Cv9y45Xq94mXv2Y5ae7L;

sealed class LyhYIeXqZljYNCRRk2o9 : global::System.IDisposable
{
	private readonly object SihXqS7jgKN;

	private readonly global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2> mWDXqc4EoYH;

	private readonly Action<string>? iD5Xq0o213V;

	private readonly object RyVXq8aDece;

	private readonly HashSet<string> s6rXqy5nH3a;

	private object QVIXqWXeO7q;

	private Process? sJeXqJovaFT;

	private global::System.Exception? TDxXqQ2QPcs;

	private int u3uXqCDVT4I;

	private int CQhXq4sZkcb;

	[CompilerGenerated]
	private readonly global::System.IDisposable QKhXqhWVQ99;

	internal static object hmoffHZxt4y2wrtn17VI;

	internal global::System.IDisposable LaunchLease
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return QKhXqhWVQ99;
		}
	}

	internal int ReadyDirectories
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Volatile.Read(ref u3uXqCDVT4I);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private LyhYIeXqZljYNCRRk2o9(string root, global::System.IDisposable lease, Action<string>? log)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static LyhYIeXqZljYNCRRk2o9 Start(object dataRoot, Action<string>? log, CancellationToken cancellationToken)
	{
		//IL_0215: Expected O, but got I
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e->IL0134: Incompatible stack heights: 2 vs 1
		//IL_01ce->IL0134: Incompatible stack heights: 3 vs 1
		//IL_0239->IL0134: Incompatible stack heights: 2 vs 1
		int num = 6;
		global::System.IDisposable disposable = default(global::System.IDisposable);
		string text = default(string);
		LyhYIeXqZljYNCRRk2o9 lyhYIeXqZljYNCRRk2o = default(LyhYIeXqZljYNCRRk2o9);
		LyhYIeXqZljYNCRRk2o9 result = default(LyhYIeXqZljYNCRRk2o9);
		int num5 = default(int);
		int num9 = default(int);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						disposable = YewtLmXqB5xkIZdH5noR.TBTXqlf9SwS();
						num = 4;
						break;
					case 0:
						text = System.IO.Path.Combine(System.IO.Path.GetFullPath((string)dataRoot), "packcache");
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 6;
						}
						continue;
					case 6:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)dataRoot, "dataRoot");
						num3 = 5;
						continue;
					case 4:
						lyhYIeXqZljYNCRRk2o = null;
						num3 = 1;
						continue;
					case 2:
						KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(text);
						num = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
						{
							num = 6;
						}
						break;
					case 3:
						return result;
					case 1:
						try
						{
							OjCXqYXgI06((global::System.Collections.Generic.IEnumerable<string>)dataRoot, log);
							int num4 = 5;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 != 15)
									{
										if (num5 == 995)
										{
											goto IL_0130;
										}
										goto case 2;
									}
									goto end_IL_0134;
								case 4:
									System.IO.Directory.CreateDirectory(text);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
									{
										num4 = 13;
									}
									break;
								case 2:
									_ = "monitor started source=third-party author=3691350367 files=Script_PlatformPatcher.mcp,xdpatch.mcp execution=unconfirmed server_classification=unconfirmed";
									_ = 3;
									break;
								case 3:
								case 7:
								{
									result = lyhYIeXqZljYNCRRk2o;
									int num6 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
									{
										num6 = 2;
									}
									num5 = num6;
									goto IL_0130;
								}
								case 0:
									lyhYIeXqZljYNCRRk2o.QVIXqWXeO7q = System.Threading.Tasks.Task.Run(new Func<global::System.Threading.Tasks.Task>(LyhYIeXqZljYNCRRk2o9.MonitorAsync));
									_ = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
									{
										_ = 0;
									}
									break;
								case 6:
									if (log == null)
									{
										num4 = 7;
										break;
									}
									goto case 2;
								case 1:
									lyhYIeXqZljYNCRRk2o.ApplyExisting(cancellationToken);
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
									{
										num4 = 11;
									}
									break;
								case 5:
									{
										lyhYIeXqZljYNCRRk2o = (LyhYIeXqZljYNCRRk2o9)new LyhYIeXqZljYNCRRk2o9(text, disposable, log);
										num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
										{
											num4 = 4;
										}
										break;
									}
									IL_0130:
									num4 = num5;
									break;
								}
								continue;
								end_IL_0134:
								break;
							}
						}
						catch
						{
							int num7 = 3;
							while (true)
							{
								switch (num7)
								{
								default:
									if (num9 != 11)
									{
										if (num9 != 991)
										{
											break;
										}
										goto IL_02b9;
									}
									lyhYIeXqZljYNCRRk2o.Dispose();
									num7 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num7 = 1;
									}
									continue;
								case 3:
									if (lyhYIeXqZljYNCRRk2o != null)
									{
										int num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num8 = 11;
										}
										num9 = num8;
										goto IL_02b9;
									}
									goto case 2;
								case 2:
									(disposable).Dispose();
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
									{
										num7 = 11;
									}
									continue;
								case 0:
								case 1:
									break;
									IL_02b9:
									num7 = num9;
									continue;
								}
								break;
							}
							throw new global::System.Exception();
						}
						goto case 3;
					case 5:
						(cancellationToken).ThrowIfCancellationRequested();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num3 = 13;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void MlTXqDelQZQ(Process process)
	{
		System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref CQhXq4sZkcb) != 0, this);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void ugCXqkXwNRZ()
	{
		global::System.Exception ex = Volatile.Read<global::System.Exception>(ref TDxXqQ2QPcs);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task oYAXqVsCZGW(CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WaitForFilesAsync_d__19 waitForFilesAsync_d__ = default(_WaitForFilesAsync_d__19);
		waitForFilesAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task MonitorAsync()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_MonitorAsync_d__20 monitorAsync_d__ = default(_MonitorAsync_d__20);
		monitorAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe void ApplyExisting(CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void OjCXqYXgI06(global::System.Collections.Generic.IEnumerable<string> dataRoots, Action<string>? log = null)
	{
		//IL_018b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2> readOnlyList = default(global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2>);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num3 = default(int);
		string text = default(string);
		global::System.Collections.Generic.IEnumerator<string> enumerator2 = default(global::System.Collections.Generic.IEnumerator<string>);
		string text2 = default(string);
		int num7 = default(int);
		global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2> enumerator3 = default(global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2>);
		KYxDNCXqOpQF3JF9F6k2 payload = default(KYxDNCXqOpQF3JF9F6k2);
		int num10 = default(int);
		int num11 = default(int);
		int num14 = default(int);
		int num16 = default(int);
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
				case 0:
					return;
				case 2:
					readOnlyList = KYxDNCXqOpQF3JF9F6k2.nBJXq6DU9vk();
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					try
					{
						while (true)
						{
							IL_0480:
							if (!(enumerator).MoveNext())
							{
								num3 = 12;
								goto IL_0092;
							}
							goto IL_04b4;
							IL_0092:
							int num4 = num3;
							goto IL_0096;
							IL_04b4:
							text = System.IO.Path.Combine(System.IO.Path.GetFullPath((string)enumerator), "packcache");
							num4 = 2;
							goto IL_0096;
							IL_0096:
							while (true)
							{
								switch (num4)
								{
								case 2:
									if (System.IO.Directory.Exists(text))
									{
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto IL_0480;
								case 3:
									try
									{
										while (true)
										{
											IL_01a5:
											int num5;
											if (!(enumerator2).MoveNext())
											{
												num5 = 4;
												goto IL_0137;
											}
											goto IL_0175;
											IL_019b:
											int num6 = 2;
											goto IL_012f;
											IL_0175:
											text2 = (string)enumerator2;
											num6 = 13;
											goto IL_012f;
											IL_012f:
											num7 = num6;
											goto IL_0133;
											IL_0133:
											num5 = num7;
											goto IL_0137;
											IL_0137:
											while (true)
											{
												switch (num5)
												{
												case 1:
													goto end_IL_0137;
												case 2:
												case 3:
													goto IL_01a5;
												case 5:
													goto IL_01c1;
												case 0:
													goto IL_03b6;
												case 4:
													goto end_IL_01a5;
												}
												if (num7 != 13)
												{
													if (num7 == 993)
													{
														goto IL_0133;
													}
													goto IL_01c1;
												}
												if ((System.IO.File.GetAttributes(text2) & 0x400) == 0)
												{
													goto IL_03b6;
												}
												goto IL_019b;
												IL_01c1:
												try
												{
													while (true)
													{
														IL_0251:
														int num8;
														if (!(enumerator3).MoveNext())
														{
															num8 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
															{
																num8 = 11;
															}
															goto IL_01e2;
														}
														goto IL_0242;
														IL_0242:
														payload = (KYxDNCXqOpQF3JF9F6k2)(object)enumerator3;
														num8 = 2;
														goto IL_01e2;
														IL_01e2:
														while (true)
														{
															int num9;
															switch (num8)
															{
															default:
																switch (num10)
																{
																case 993:
																	break;
																default:
																	goto end_IL_0251;
																case 13:
																	throw new global::System.Exception("MCP 自有文件尚未撤回，请先关闭基岩客户端再启动");
																}
																goto IL_01de;
															case 2:
																if (System.IO.File.Exists(hDjZsyXqUiN1SDOOiPuj.BnkXqo24Y7Y(text2, payload)))
																{
																	num8 = 3;
																	continue;
																}
																goto IL_0251;
															case 5:
																break;
															case 0:
																goto IL_0251;
															case 3:
																KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(text2);
																num9 = 4;
																goto IL_01da;
															case 4:
																if (!YewtLmXqB5xkIZdH5noR.U1NXqKDR4Zh())
																{
																	hDjZsyXqUiN1SDOOiPuj.T8vXqmSQE51(text2, payload, log);
																	num8 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
																	{
																		num8 = 5;
																	}
																	continue;
																}
																num9 = 13;
																goto IL_01da;
															case 1:
																goto end_IL_0251;
																IL_01de:
																num8 = num10;
																continue;
																IL_01da:
																num10 = num9;
																goto IL_01de;
															}
															break;
														}
														goto IL_0242;
														continue;
														end_IL_0251:
														break;
													}
												}
												finally
												{
													if (enumerator3 == null)
													{
														num11 = 2;
														goto IL_0310;
													}
													goto IL_0338;
													IL_0338:
													(enumerator3).Dispose();
													int num12 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
													{
														num12 = 0;
													}
													goto IL_0314;
													IL_0310:
													num12 = num11;
													goto IL_0314;
													IL_0314:
													switch (num12)
													{
													case 1:
														goto IL_0338;
													case 2:
														goto end_IL_02f1;
													case 0:
														goto end_IL_02f1;
													}
													if (num11 == 990)
													{
														goto IL_0310;
													}
													end_IL_02f1:;
												}
												goto IL_01a5;
												IL_03b6:
												enumerator3 = (global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2>)readOnlyList;
												num5 = 5;
												continue;
												end_IL_0137:
												break;
											}
											goto IL_0175;
											continue;
											end_IL_01a5:
											break;
										}
									}
									finally
									{
										int num13;
										if (enumerator2 == null)
										{
											num13 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
											{
												num13 = 1;
											}
											goto IL_0402;
										}
										goto IL_0435;
										IL_0402:
										while (true)
										{
											switch (num13)
											{
											default:
												if (num14 == 990)
												{
													goto IL_03fe;
												}
												goto end_IL_0402;
											case 1:
												goto end_IL_0402;
											case 2:
												break;
											case 0:
												goto end_IL_0402;
											}
											goto IL_0435;
											IL_03fe:
											num13 = num14;
											continue;
											end_IL_0402:
											break;
										}
										goto end_IL_03ca;
										IL_0435:
										(enumerator2).Dispose();
										num13 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num13 = 0;
										}
										goto IL_0402;
										end_IL_03ca:;
									}
									goto IL_0480;
								case 4:
									goto IL_0480;
								case 0:
									enumerator2 = (global::System.Collections.Generic.IEnumerator<string>)System.IO.Directory.EnumerateDirectories(text);
									num4 = 3;
									continue;
								case 1:
									goto IL_04b4;
								}
								break;
							}
							switch (num3)
							{
							case 12:
								return;
							case 992:
								break;
							default:
								continue;
							}
							goto IL_0092;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num15 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
							{
								num15 = 0;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 == 989)
									{
										num15 = num16;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0530;
								}
								(enumerator).Dispose();
								num15 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num15 = 2;
								}
								continue;
								end_IL_0530:
								break;
							}
						}
					}
				case 1:
					enumerator = (global::System.Collections.Generic.IEnumerator<string>)Enumerable.Distinct<string>(dataRoots, (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
					num2 = 8;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
					{
						num2 = 3;
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
	public void Dispose()
	{
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b2->IL01a0: Incompatible stack heights: 3 vs 1
		//IL_02bd->IL01a0: Incompatible stack heights: 3 vs 1
		int num = 3;
		int num5 = default(int);
		TaskAwaiter val = default(TaskAwaiter);
		int num9 = default(int);
		int num7 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (System.Threading.Interlocked.Exchange(ref CQhXq4sZkcb, 1) == 0)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					return;
				case 4:
					try
					{
						(RyVXq8aDece).Cancel();
						int num3 = 2;
						while (true)
						{
							switch (num3)
							{
							default:
								switch (num5)
								{
								case 990:
									break;
								default:
									return;
								case 10:
									(val).GetResult();
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
									{
										num3 = 6;
									}
									goto end_IL_009f;
								}
								goto IL_009b;
							case 1:
								OjCXqYXgI06((global::System.Collections.Generic.IEnumerable<string>)System.IO.Path.GetDirectoryName((string)SihXqS7jgKN), iD5Xq0o213V);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num3 = 2;
								}
								break;
							case 2:
							{
								val = (QVIXqWXeO7q).GetAwaiter();
								int num4 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num4 = 1;
								}
								num5 = num4;
								goto IL_009b;
							}
							case 0:
								return;
								IL_009b:
								num3 = num5;
								break;
								end_IL_009f:
								break;
							}
						}
					}
					catch (global::System.Exception ex)
					{
						int num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
						{
							num6 = 5;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								switch (num7)
								{
								case 990:
									break;
								default:
									return;
								case 10:
									if (iD5Xq0o213V == null)
									{
										num6 = 2;
										continue;
									}
									string.Concat("withdraw deferred error=", ((ex).GetType()).Name);
									_ = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										_ = 0;
									}
									continue;
								}
								break;
							case 1:
								cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "Dispose", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\BedrockMcpPatchDeployment.cs", 262);
								num7 = 10;
								break;
							case 2:
								return;
							case 0:
								return;
							}
							num6 = num7;
						}
					}
					finally
					{
						(RyVXq8aDece).Dispose();
						int num8 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
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
								(LaunchLease).Dispose();
								num8 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
								{
									num8 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				case 1:
					return;
				case 0:
					return;
				case 2:
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
		while (num == 992);
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
					case 2:
						break;
					case 0:
						num3 = 2;
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							num3 = 5;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool NvnWmQZxOtLJABFAf2d7()
	{
		return hmoffHZxt4y2wrtn17VI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static LyhYIeXqZljYNCRRk2o9 pokrQGZx51oLCmkSHDMI()
	{
		return (LyhYIeXqZljYNCRRk2o9)hmoffHZxt4y2wrtn17VI;
	}
}

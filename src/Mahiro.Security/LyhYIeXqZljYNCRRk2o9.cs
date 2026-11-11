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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static LyhYIeXqZljYNCRRk2o9 Start(object dataRoot, Action<string>? log, CancellationToken cancellationToken)
	{
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
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
							OjCXqYXgI06(new global::__z__ReadOnlySingleElementList_1<string>((string)dataRoot), log);
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
											goto IL_0134;
										}
										goto case 2;
									}
									goto end_IL_0138;
								case 4:
									System.IO.Directory.CreateDirectory(text);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
									{
										num4 = 13;
									}
									break;
								case 2:
									log.Invoke("monitor started source=third-party author=3691350367 files=Script_PlatformPatcher.mcp,xdpatch.mcp execution=unconfirmed server_classification=unconfirmed");
									num4 = 3;
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
									goto IL_0134;
								}
								case 0:
									lyhYIeXqZljYNCRRk2o.QVIXqWXeO7q = System.Threading.Tasks.Task.Run(lyhYIeXqZljYNCRRk2o.MonitorAsync);
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
									{
										num4 = 0;
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
									IL_0134:
									num4 = num5;
									break;
								}
								continue;
								end_IL_0138:
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
										goto IL_02c5;
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
										goto IL_02c5;
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
									IL_02c5:
									num7 = num9;
									continue;
								}
								break;
							}
							throw;
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
	private void ApplyExisting(CancellationToken cancellationToken)
	{
		//IL_0a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num13 = default(int);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		string current = default(string);
		int num5 = default(int);
		int num12 = default(int);
		global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2> enumerator2 = default(global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2>);
		KYxDNCXqOpQF3JF9F6k2 current2 = default(KYxDNCXqOpQF3JF9F6k2);
		int num9 = default(int);
		List<KYxDNCXqOpQF3JF9F6k2> val = default(List<KYxDNCXqOpQF3JF9F6k2>);
		int num11 = default(int);
		string text = default(string);
		global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2> enumerator3 = default(global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2>);
		int num18 = default(int);
		KYxDNCXqOpQF3JF9F6k2 current3 = default(KYxDNCXqOpQF3JF9F6k2);
		int num20 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num21);
		global::System.Exception ex2 = default(global::System.Exception);
		int num22 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num27 = default(int);
		int num29 = default(int);
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
							goto case 4;
						}
						return;
					case 1:
						num13 = 0;
						num3 = 3;
						continue;
					case 0:
						break;
					case 3:
						enumerator = System.IO.Directory.EnumerateDirectories((string)SihXqS7jgKN).GetEnumerator();
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						try
						{
							while (true)
							{
								IL_013f:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
									{
										num4 = 9;
									}
									goto IL_00e1;
								}
								goto IL_012c;
								IL_012c:
								current = enumerator.Current;
								num4 = 2;
								goto IL_00e1;
								IL_00e1:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 != 12)
										{
											if (num5 == 992)
											{
												goto IL_00dd;
											}
											goto case 2;
										}
										try
										{
											if (KxxYYwXNwodeMw0HASFS.Ev9XNPIEbji(current))
											{
												int num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
												{
													num6 = 1;
												}
												while (true)
												{
													switch (num6)
													{
													default:
														if (num12 == 993)
														{
															num6 = num12;
															continue;
														}
														goto end_IL_01d8;
													case 2:
														goto end_IL_01d8;
													case 0:
													case 5:
														enumerator2 = ((global::System.Collections.Generic.IEnumerable<KYxDNCXqOpQF3JF9F6k2>)mWDXqc4EoYH).GetEnumerator();
														num6 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
														{
															num6 = 1;
														}
														continue;
													case 4:
														break;
													case 3:
														try
														{
															while (true)
															{
																int num7;
																if (!(enumerator2).MoveNext())
																{
																	num7 = 4;
																	goto IL_02ae;
																}
																goto IL_039c;
																IL_0353:
																int num8 = 13;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
																{
																	num8 = 0;
																}
																goto IL_02a6;
																IL_039c:
																current2 = enumerator2.Current;
																num8 = 2;
																goto IL_02a6;
																IL_02a6:
																num9 = num8;
																goto IL_02aa;
																IL_02aa:
																num7 = num9;
																goto IL_02ae;
																IL_02ae:
																while (true)
																{
																	switch (num7)
																	{
																	default:
																		if (num9 != 13)
																		{
																			if (num9 == 993)
																			{
																				goto IL_02aa;
																			}
																			goto case 1;
																		}
																		break;
																	case 5:
																		val.Add(current2);
																		num7 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
																		{
																			num7 = 5;
																		}
																		continue;
																	case 2:
																		(cancellationToken).ThrowIfCancellationRequested();
																		num7 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
																		{
																			num7 = 12;
																		}
																		continue;
																	case 1:
																		if (hDjZsyXqUiN1SDOOiPuj.Release(current, current2, iD5Xq0o213V))
																		{
																			goto case 5;
																		}
																		goto IL_0353;
																	case 0:
																		break;
																	case 3:
																		goto IL_039c;
																	case 4:
																		goto end_IL_0372;
																	}
																	break;
																}
																continue;
																end_IL_0372:
																break;
															}
														}
														finally
														{
															int num10;
															if (enumerator2 == null)
															{
																num10 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
																{
																	num10 = 5;
																}
																goto IL_03ec;
															}
															goto IL_0434;
															IL_03ec:
															while (true)
															{
																switch (num10)
																{
																default:
																	if (num11 == 990)
																	{
																		goto IL_03e8;
																	}
																	goto end_IL_03ec;
																case 0:
																	goto end_IL_03ec;
																case 2:
																	break;
																case 1:
																	goto end_IL_03ec;
																}
																goto IL_0434;
																IL_03e8:
																num10 = num11;
																continue;
																end_IL_03ec:
																break;
															}
															goto end_IL_03b4;
															IL_0434:
															(enumerator2).Dispose();
															num10 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
															{
																num10 = 1;
															}
															goto IL_03ec;
															end_IL_03b4:;
														}
														break;
													case 1:
														goto end_IL_01d8;
													}
													num13++;
													num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
													{
														num6 = 1;
													}
													continue;
													end_IL_01d8:
													break;
												}
											}
										}
										catch (global::System.Exception ex)
										{
											int num14 = 5;
											while (true)
											{
												IL_0485:
												int num15 = num14;
												while (true)
												{
													IL_0489:
													int num16 = num15;
													while (true)
													{
														switch (num16)
														{
														default:
															if (num15 != 22)
															{
																if (num15 == 1002)
																{
																	goto IL_0489;
																}
																goto case 5;
															}
															goto end_IL_048d;
														case 8:
															if (s6rXqy5nH3a.Count < 64)
															{
																num14 = 2;
																break;
															}
															goto end_IL_048d;
														case 9:
															goto end_IL_048d;
														case 14:
															goto end_IL_048d;
														case 11:
															if (ex is InvalidDataException)
															{
																num16 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																{
																	num16 = 13;
																}
																continue;
															}
															goto case 6;
														case 6:
														case 13:
															text = string.Concat(System.IO.Path.GetFileName(current), ":", ((ex).GetType()).Name);
															num16 = 8;
															continue;
														case 10:
															if (ex is IOException)
															{
																num16 = 11;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																{
																	num16 = 16;
																}
																continue;
															}
															goto case 1;
														case 0:
															try
															{
																while (true)
																{
																	int num17;
																	if (!enumerator3.MoveNext())
																	{
																		num17 = 8;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
																		{
																			num17 = 0;
																		}
																		goto IL_05f4;
																	}
																	goto IL_0989;
																	IL_05f0:
																	num17 = num18;
																	goto IL_05f4;
																	IL_05f4:
																	switch (num17)
																	{
																	case 3:
																		try
																		{
																			hDjZsyXqUiN1SDOOiPuj.T8vXqmSQE51(current, current3, iD5Xq0o213V);
																			int num19 = 3;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																			{
																				num19 = 0;
																			}
																			while (true)
																			{
																				switch (num19)
																				{
																				default:
																					if (num20 == 988)
																					{
																						num19 = num20;
																						continue;
																					}
																					break;
																				case 0:
																					break;
																				}
																				break;
																			}
																		}
																		catch (global::System.Exception obj2) when (((Func<bool>)delegate
																		{
																			// Could not convert BlockContainer to single expression
																			obj3 = obj2 as global::System.Exception;
																			if (obj3 == null)
																			{
																				num21 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
																				{
																					num21 = 10;
																				}
																				goto IL_06bb;
																			}
																			ex2 = obj3;
																			num22 = 14;
																			goto IL_06b7;
																			IL_06bb:
																			while (true)
																			{
																				switch (num21)
																				{
																				default:
																					if (num22 != 14)
																					{
																						if (num22 == 994)
																						{
																							break;
																						}
																						goto case 3;
																					}
																					if (ex2 is IOException)
																					{
																						num21 = 4;
																						continue;
																					}
																					goto case 1;
																				case 1:
																					if (ex2 is UnauthorizedAccessException)
																					{
																						num21 = 3;
																						continue;
																					}
																					goto case 6;
																				case 6:
																					flag = false;
																					num21 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
																					{
																						num21 = 2;
																					}
																					continue;
																				case 3:
																				case 4:
																					flag = true;
																					num21 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																					{
																						num21 = 13;
																					}
																					continue;
																				case 5:
																					result = 0;
																					goto IL_07cc;
																				case 0:
																				case 2:
																					{
																						result = (flag ? 1 : 0);
																						goto IL_07cc;
																					}
																					IL_07cc:
																					return (byte)result != 0;
																				}
																				break;
																			}
																			goto IL_06b7;
																			IL_06b7:
																			num21 = num22;
																			goto IL_06bb;
																		}).Invoke())
																		{
																			int num23 = 1;
																			while (true)
																			{
																				IL_07e3:
																				int num24 = num23;
																				do
																				{
																					int num25 = num24;
																					Action<string>? obj4;
																					while (true)
																					{
																						switch (num25)
																						{
																						case 1:
																							cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "caught-exception", "ApplyExisting", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\BedrockMcpPatchDeployment.cs", 193);
																							num25 = 2;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
																							{
																								num25 = 10;
																							}
																							continue;
																						case 2:
																							goto IL_08a5;
																						case 0:
																							goto end_IL_07e7;
																						}
																						break;
																						IL_08a5:
																						obj4 = iD5Xq0o213V;
																						if (obj4 != null)
																						{
																							goto IL_08db;
																						}
																						num25 = 9;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																						{
																							num25 = 0;
																						}
																					}
																					continue;
																					IL_08db:
																					obj4.Invoke(string.Concat("pair rollback deferred error=", ((ex2).GetType()).Name));
																					num23 = 2;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
																					{
																						num23 = 10;
																					}
																					goto IL_07e3;
																					continue;
																					end_IL_07e7:
																					break;
																				}
																				while (num24 != 10 && num24 == 990);
																				break;
																			}
																		}
																		continue;
																	case 1:
																		continue;
																	case 2:
																		goto IL_0989;
																	case 0:
																		goto end_IL_095e;
																	}
																	if (num18 != 991)
																	{
																		break;
																	}
																	goto IL_05f0;
																	IL_0989:
																	current3 = enumerator3.Current;
																	num18 = 3;
																	goto IL_05f0;
																	continue;
																	end_IL_095e:
																	break;
																}
															}
															finally
															{
																((global::System.IDisposable)enumerator3/*cast due to .constrained prefix*/).Dispose();
																int num26 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																{
																	num26 = 3;
																}
																while (true)
																{
																	switch (num26)
																	{
																	default:
																		if (num27 == 988)
																		{
																			num26 = num27;
																			continue;
																		}
																		break;
																	case 0:
																		break;
																	}
																	break;
																}
															}
															goto case 4;
														case 1:
															if (!(ex is UnauthorizedAccessException))
															{
																num16 = 7;
																continue;
															}
															goto case 6;
														case 2:
															if (!s6rXqy5nH3a.Add(text))
															{
																num16 = 6;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
																{
																	num16 = 9;
																}
																continue;
															}
															goto case 3;
														case 5:
															enumerator3 = val.GetEnumerator();
															num16 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
															{
																num16 = 0;
															}
															continue;
														case 4:
															if (ex is JsonException)
															{
																num16 = 6;
																continue;
															}
															goto case 10;
														case 3:
														{
															Action<string>? obj = iD5Xq0o213V;
															if (obj == null)
															{
																num14 = 22;
																break;
															}
															global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(37, 2);
															(defaultInterpolatedStringHandler).AppendLiteral("cache scan deferred directory=");
															(defaultInterpolatedStringHandler).AppendFormatted(System.IO.Path.GetFileName(current));
															(defaultInterpolatedStringHandler).AppendLiteral(" ");
															(defaultInterpolatedStringHandler).AppendLiteral("error=");
															(defaultInterpolatedStringHandler).AppendFormatted(((ex).GetType()).Name);
															obj.Invoke((defaultInterpolatedStringHandler).ToStringAndClear());
															num14 = 14;
															break;
														}
														case 7:
														case 12:
															throw;
														}
														goto IL_0485;
														continue;
														end_IL_048d:
														break;
													}
													break;
												}
												break;
											}
										}
										goto IL_013f;
									case 0:
										val = new List<KYxDNCXqOpQF3JF9F6k2>();
										num5 = 12;
										goto IL_00dd;
									case 4:
										break;
									case 3:
										goto IL_013f;
									case 2:
										(cancellationToken).ThrowIfCancellationRequested();
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
										{
											num4 = 8;
										}
										continue;
									case 1:
										goto end_IL_013f;
										IL_00dd:
										num4 = num5;
										continue;
									}
									break;
								}
								goto IL_012c;
								continue;
								end_IL_013f:
								break;
							}
						}
						finally
						{
							int num28;
							if (enumerator == null)
							{
								num28 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									num28 = 1;
								}
								goto IL_0be8;
							}
							goto IL_0c0c;
							IL_0be8:
							while (true)
							{
								switch (num28)
								{
								default:
									if (num29 == 990)
									{
										goto IL_0be4;
									}
									goto end_IL_0be8;
								case 2:
									break;
								case 1:
									goto end_IL_0be8;
								case 0:
									goto end_IL_0be8;
								}
								goto IL_0c0c;
								IL_0be4:
								num28 = num29;
								continue;
								end_IL_0be8:
								break;
							}
							goto end_IL_0bb0;
							IL_0c0c:
							(enumerator).Dispose();
							num28 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
							{
								num28 = 0;
							}
							goto IL_0be8;
							end_IL_0bb0:;
						}
						break;
					case 2:
						KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(SihXqS7jgKN);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
						{
							num3 = 1;
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
			System.Threading.Volatile.Write(ref u3uXqCDVT4I, num13);
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void OjCXqYXgI06(global::System.Collections.Generic.IEnumerable<string> dataRoots, Action<string>? log = null)
	{
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2> readOnlyList = default(global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2>);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num3 = default(int);
		string text = default(string);
		global::System.Collections.Generic.IEnumerator<string> enumerator2 = default(global::System.Collections.Generic.IEnumerator<string>);
		string current = default(string);
		int num7 = default(int);
		global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2> enumerator3 = default(global::System.Collections.Generic.IEnumerator<KYxDNCXqOpQF3JF9F6k2>);
		KYxDNCXqOpQF3JF9F6k2 current2 = default(KYxDNCXqOpQF3JF9F6k2);
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
							IL_0490:
							if (!(enumerator).MoveNext())
							{
								num3 = 12;
								goto IL_0092;
							}
							goto IL_04c8;
							IL_0092:
							int num4 = num3;
							goto IL_0096;
							IL_04c8:
							text = System.IO.Path.Combine(System.IO.Path.GetFullPath(enumerator.Current), "packcache");
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
									goto IL_0490;
								case 3:
									try
									{
										while (true)
										{
											IL_01a9:
											int num5;
											if (!(enumerator2).MoveNext())
											{
												num5 = 4;
												goto IL_0137;
											}
											goto IL_0175;
											IL_019f:
											int num6 = 2;
											goto IL_012f;
											IL_0175:
											current = enumerator2.Current;
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
													goto IL_01a9;
												case 5:
													goto IL_01c5;
												case 0:
													goto IL_03c2;
												case 4:
													goto end_IL_01a9;
												}
												if (num7 != 13)
												{
													if (num7 == 993)
													{
														goto IL_0133;
													}
													goto IL_01c5;
												}
												if ((System.IO.File.GetAttributes(current) & (FileAttributes)(0x400)) == 0)
												{
													goto IL_03c2;
												}
												goto IL_019f;
												IL_01c5:
												try
												{
													while (true)
													{
														IL_0259:
														int num8;
														if (!(enumerator3).MoveNext())
														{
															num8 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
															{
																num8 = 11;
															}
															goto IL_01e6;
														}
														goto IL_0246;
														IL_0246:
														current2 = enumerator3.Current;
														num8 = 2;
														goto IL_01e6;
														IL_01e6:
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
																	goto end_IL_0259;
																case 13:
																	throw new InvalidOperationException("MCP 自有文件尚未撤回，请先关闭基岩客户端再启动");
																}
																goto IL_01e2;
															case 2:
																if (System.IO.File.Exists(hDjZsyXqUiN1SDOOiPuj.BnkXqo24Y7Y(current, current2)))
																{
																	num8 = 3;
																	continue;
																}
																goto IL_0259;
															case 5:
																break;
															case 0:
																goto IL_0259;
															case 3:
																KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(current);
																num9 = 4;
																goto IL_01de;
															case 4:
																if (!YewtLmXqB5xkIZdH5noR.U1NXqKDR4Zh())
																{
																	hDjZsyXqUiN1SDOOiPuj.T8vXqmSQE51(current, current2, log);
																	num8 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
																	{
																		num8 = 5;
																	}
																	continue;
																}
																num9 = 13;
																goto IL_01de;
															case 1:
																goto end_IL_0259;
																IL_01e2:
																num8 = num10;
																continue;
																IL_01de:
																num10 = num9;
																goto IL_01e2;
															}
															break;
														}
														goto IL_0246;
														continue;
														end_IL_0259:
														break;
													}
												}
												finally
												{
													if (enumerator3 == null)
													{
														num11 = 2;
														goto IL_031c;
													}
													goto IL_0344;
													IL_0344:
													(enumerator3).Dispose();
													int num12 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
													{
														num12 = 0;
													}
													goto IL_0320;
													IL_031c:
													num12 = num11;
													goto IL_0320;
													IL_0320:
													switch (num12)
													{
													case 1:
														goto IL_0344;
													case 2:
														goto end_IL_02fd;
													case 0:
														goto end_IL_02fd;
													}
													if (num11 == 990)
													{
														goto IL_031c;
													}
													end_IL_02fd:;
												}
												goto IL_01a9;
												IL_03c2:
												enumerator3 = ((global::System.Collections.Generic.IEnumerable<KYxDNCXqOpQF3JF9F6k2>)readOnlyList).GetEnumerator();
												num5 = 5;
												continue;
												end_IL_0137:
												break;
											}
											goto IL_0175;
											continue;
											end_IL_01a9:
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
											goto IL_0412;
										}
										goto IL_0445;
										IL_0412:
										while (true)
										{
											switch (num13)
											{
											default:
												if (num14 == 990)
												{
													goto IL_040e;
												}
												goto end_IL_0412;
											case 1:
												goto end_IL_0412;
											case 2:
												break;
											case 0:
												goto end_IL_0412;
											}
											goto IL_0445;
											IL_040e:
											num13 = num14;
											continue;
											end_IL_0412:
											break;
										}
										goto end_IL_03da;
										IL_0445:
										(enumerator2).Dispose();
										num13 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num13 = 0;
										}
										goto IL_0412;
										end_IL_03da:;
									}
									goto IL_0490;
								case 4:
									goto IL_0490;
								case 0:
									enumerator2 = System.IO.Directory.EnumerateDirectories(text).GetEnumerator();
									num4 = 3;
									continue;
								case 1:
									goto IL_04c8;
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
									goto end_IL_0548;
								}
								(enumerator).Dispose();
								num15 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num15 = 2;
								}
								continue;
								end_IL_0548:
								break;
							}
						}
					}
				case 1:
					enumerator = Enumerable.Distinct<string>(dataRoots, (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase).GetEnumerator();
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
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
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
						((dynamic)(RyVXq8aDece)).Cancel();
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
								OjCXqYXgI06(new global::__z__ReadOnlySingleElementList_1<string>(System.IO.Path.GetDirectoryName((string)SihXqS7jgKN)), iD5Xq0o213V);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num3 = 2;
								}
								break;
							case 2:
							{
								val = ((dynamic)(QVIXqWXeO7q)).GetAwaiter();
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
								{
									Action<string>? obj = iD5Xq0o213V;
									if (obj == null)
									{
										num6 = 2;
										continue;
									}
									obj.Invoke(string.Concat("withdraw deferred error=", ((ex).GetType()).Name));
									num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
									{
										num6 = 0;
									}
									continue;
								}
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
						((dynamic)(RyVXq8aDece)).Dispose();
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PTmBhWXAkOqcMFXeoAHn;
using fDAldojjppXrctUVYOJn;
using vPsLRWXAKouaS91XjEO3;

namespace TJE19XX7zhZ5YVLR4KCi;

internal class l9f0HPX7nRCFPT4LnE15
{
	internal static readonly object wTdXAjdvZMP;

	private static object aiKLBNZtqKLsA6Kfl8S6;

	[MethodImpl((MethodImplOptions)8)]
	internal static HttpRequestMessage T5rXAb46eZ2(object session, object context)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		int num = 1;
		HttpRequestMessage val = default(HttpRequestMessage);
		Uri val2 = default(Uri);
		int num5 = default(int);
		HttpRequestMessage result = default(HttpRequestMessage);
		int num7 = default(int);
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
							goto case 0;
						}
						System.ArgumentNullException.ThrowIfNull(context, "context");
						num3 = 3;
						continue;
					case 0:
						((M3qr7lXADxIiM3wM1qRy)session).YbcXAYQdgUf((W8UV04XAdpTXOmgNYBMi)context);
						num3 = 6;
						continue;
					case 4:
						val = new HttpRequestMessage(System.Net.Http.HttpMethod.Get, val2);
						num3 = 2;
						continue;
					case 3:
						((W8UV04XAdpTXOmgNYBMi)context).iAVXAHV6MAL();
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 0;
						}
						continue;
					case 6:
						val2 = new Uri(string.Concat(new string[5]
						{
							((dynamic)(wTdXAjdvZMP)).AbsoluteUri,
							"?app_id=81&code=4399_channel&account_id=",
							System.Uri.EscapeDataString(((M3qr7lXADxIiM3wM1qRy)session).AccountId),
							"&device_id=",
							System.Uri.EscapeDataString(((M3qr7lXADxIiM3wM1qRy)session).DeviceId)
						}));
						num3 = 4;
						continue;
					case 2:
						try
						{
							((M3qr7lXADxIiM3wM1qRy)session).zdBXAVC3bPg((val).Headers);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num4 = 5;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_01ba;
								}
								result = val;
								num4 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
								{
									num4 = 0;
								}
								continue;
								end_IL_01ba:
								break;
							}
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
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
								case 0:
									(val).Dispose();
									num6 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
									{
										num6 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
							throw;
						}
						goto case 5;
					case 1:
						break;
					case 5:
						return result;
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
			System.ArgumentNullException.ThrowIfNull(session, "session");
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
			{
				num = 13;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string KFQXAX5Jk5Z(object sauthWrapper, object context)
	{
		//IL_05ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Invalid comparison between Unknown and I4
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0413: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a8: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		string result = default(string);
		int num15 = default(int);
		JsonDocument val3 = default(JsonDocument);
		JsonDocumentOptions val5 = default(JsonDocumentOptions);
		int num6 = default(int);
		JsonDocument val4 = default(JsonDocument);
		int num9 = default(int);
		int num11 = default(int);
		int num13 = default(int);
		int num17 = default(int);
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
							goto case 0;
						}
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)sauthWrapper, "sauthWrapper");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						return result;
					case 5:
						try
						{
							JsonDocumentOptions val = default(JsonDocumentOptions);
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num15 != 10)
									{
										if (num15 == 990)
										{
											goto IL_0076;
										}
										goto case 2;
									}
									val3 = System.Text.Json.JsonDocument.Parse((string)sauthWrapper, val5);
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
									{
										num4 = 1;
									}
									continue;
								case 0:
								{
									val5 = val;
									int num14 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
									{
										num14 = 5;
									}
									num15 = num14;
									goto IL_0076;
								}
								case 2:
									(val).MaxDepth = 16;
									num4 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num4 = 0;
									}
									continue;
								case 1:
									{
										try
										{
											JsonElement val2 = DHRXALWHPTC((val3).RootElement, "sauth_json");
											int num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
											{
												num5 = 10;
											}
											while (true)
											{
												switch (num5)
												{
												default:
													if (num6 != 10)
													{
														if (num6 == 990)
														{
															goto IL_018c;
														}
														goto case 0;
													}
													try
													{
														JsonElement source = (val4).RootElement;
														int num7 = 3;
														while (true)
														{
															switch (num7)
															{
															default:
																if (num9 != 11)
																{
																	if (num9 == 991)
																	{
																		goto IL_028a;
																	}
																	goto case 1;
																}
																goto IL_03f1;
															case 3:
																if (!(XdEXAfumPhI(source, "login_channel") != "4399com"))
																{
																	num7 = 2;
																	continue;
																}
																goto IL_03f1;
															case 2:
																if ((XdEXAfumPhI(source, "gameid") != "x19"))
																{
																	int num8 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
																	{
																		num8 = 11;
																	}
																	num9 = num8;
																	goto IL_028a;
																}
																if (string.Equals(XdEXAfumPhI(source, "sdkuid"), ((W8UV04XAdpTXOmgNYBMi)context).SdkUid, (StringComparison)4))
																{
																	result = XdEXAfumPhI(source, "sessionid");
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																	{
																		num7 = 3;
																	}
																}
																else
																{
																	num7 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																	{
																		num7 = 1;
																	}
																}
																continue;
															case 1:
																throw new InvalidOperationException("4399 SAuth 与当前经典版 SDK 用户不一致");
															case 0:
																break;
																IL_03f1:
																throw new NotSupportedException("第三方原生票据入口只接受 x19 / 4399com 来源");
																IL_028a:
																num7 = num9;
																continue;
															}
															break;
														}
													}
													finally
													{
														if (val4 != null)
														{
															int num10 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
															{
																num10 = 1;
															}
															while (true)
															{
																switch (num10)
																{
																default:
																	if (num11 == 989)
																	{
																		num10 = num11;
																		continue;
																	}
																	break;
																case 1:
																	break;
																case 0:
																	goto end_IL_04ad;
																}
																(val4).Dispose();
																num10 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
																{
																	num10 = 4;
																}
																continue;
																end_IL_04ad:
																break;
															}
														}
													}
													goto end_IL_0190;
												case 0:
													if ((int)(val2).ValueKind == 3)
													{
														num5 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
														{
															num5 = 3;
														}
														break;
													}
													goto case 2;
												case 1:
													if (string.IsNullOrWhiteSpace((val2).GetString()))
													{
														num5 = 2;
														break;
													}
													val4 = System.Text.Json.JsonDocument.Parse((val2).GetString(), val5);
													num6 = 10;
													goto IL_018c;
												case 2:
													{
														throw new ArgumentException("4399 原生票据需要有效的 SAuth 包装");
													}
													IL_018c:
													num5 = num6;
													break;
												}
												continue;
												end_IL_0190:
												break;
											}
										}
										finally
										{
											if (val3 != null)
											{
												int num12 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
												{
													num12 = 5;
												}
												while (true)
												{
													switch (num12)
													{
													default:
														if (num13 == 989)
														{
															num12 = num13;
															continue;
														}
														break;
													case 1:
														(val3).Dispose();
														num12 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
														{
															num12 = 3;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										break;
									}
									IL_0076:
									num4 = num15;
									continue;
								}
								break;
							}
						}
						catch (JsonException)
						{
							int num16 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num16 = 0;
							}
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 988)
									{
										goto IL_05ab;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_05ab:
								num16 = num17;
							}
							throw new ArgumentException("4399 原生票据所需 SAuth 格式无效");
						}
						goto case 4;
					case 1:
						throw new ArgumentException("4399 SAuth 大小超出原生票据请求限制");
					case 6:
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num3 = 5;
						}
						continue;
					case 3:
						System.ArgumentNullException.ThrowIfNull(context, "context");
						num3 = 2;
						continue;
					case 0:
						if ((System.Text.Encoding.UTF8).GetByteCount((string)sauthWrapper) <= 131072)
						{
							num3 = 6;
							continue;
						}
						goto case 1;
					case 2:
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
			((W8UV04XAdpTXOmgNYBMi)context).iAVXAHV6MAL();
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string XdEXAfumPhI(JsonElement source, object name)
	{
		JsonElement val = default(JsonElement);
		string text = (val).GetString();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static JsonElement DHRXALWHPTC(JsonElement source, object name)
	{
		//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Invalid comparison between Unknown and I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		ObjectEnumerator val2 = default(ObjectEnumerator);
		ObjectEnumerator enumerator = default(ObjectEnumerator);
		int num4 = default(int);
		JsonElement result = default(JsonElement);
		JsonProperty val = default(JsonProperty);
		int num6 = default(int);
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
							goto case 4;
						}
						val2 = source.EnumerateObject();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						enumerator = val2.GetEnumerator();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
						{
							num3 = 4;
						}
						continue;
					case 6:
						if (num4 != 1)
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
							{
								num3 = 5;
							}
							continue;
						}
						return result;
					case 0:
						throw new ArgumentException("第三方票据字段所在对象无效");
					case 3:
						result = default(JsonElement);
						num = 13;
						break;
					case 4:
						try
						{
							while (true)
							{
								IL_0219:
								int num5;
								if (!(enumerator).MoveNext())
								{
									num5 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num5 = 11;
									}
									goto IL_0131;
								}
								goto IL_016f;
								IL_0131:
								while (true)
								{
									switch (num5)
									{
									case 3:
										goto IL_016f;
									case 5:
										num4++;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
										{
											num5 = 2;
										}
										continue;
									case 4:
										if ((val).NameEquals((string)name))
										{
											goto case 5;
										}
										goto IL_01e2;
									case 0:
										result = (val).Value;
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
										{
											num5 = 2;
										}
										continue;
									case 2:
										goto IL_0219;
									case 1:
										goto end_IL_0219;
									}
									break;
								}
								if (num6 == 13 || num6 != 993)
								{
									continue;
								}
								goto IL_012d;
								IL_01e2:
								int num7 = 13;
								goto IL_0129;
								IL_016f:
								val = (enumerator).Current;
								num7 = 4;
								goto IL_0129;
								IL_0129:
								num6 = num7;
								goto IL_012d;
								IL_012d:
								num5 = num6;
								goto IL_0131;
								continue;
								end_IL_0219:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 988)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 6;
					case 5:
						throw new ArgumentException(string.Concat("第三方票据字段缺失或重复：", (string)name));
					case 1:
						if ((int)(source).ValueKind == 1)
						{
							num4 = 0;
							num = 3;
							break;
						}
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
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
	internal static bool unqr5ZZtGZWKCvOmX2l2()
	{
		return aiKLBNZtqKLsA6Kfl8S6 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static l9f0HPX7nRCFPT4LnE15 veIJ3XZti1TtNud6gKWe()
	{
		return (l9f0HPX7nRCFPT4LnE15)aiKLBNZtqKLsA6Kfl8S6;
	}
}

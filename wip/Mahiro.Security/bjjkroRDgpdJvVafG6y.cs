using System;
using System.Diagnostics;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using ANAXBh6MYUNLNY3i4BB;
using CZUx5njfSrbl1tnMcUCO;
using QJ21CkfSL8itNSePE2uS;
using WMO32gy5EZANSQKlHAx;
using YcbNgp6neMFOwVbXHuw;
using fDAldojjppXrctUVYOJn;

namespace zZh991RksnlDbIy6JGc;

sealed class bjjkroRDgpdJvVafG6y : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RegisterUniSauthAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<VS3DDV6icfQFnd6RdNC> __t__builder;

		public string sauthJsonValue;

		public bjjkroRDgpdJvVafG6y __4__this;

		public CancellationToken cancellationToken;

		private StringContent _content_5__2;

		private HttpResponseMessage _response_5__3;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__2;

		internal static object TQlrgT977ACcsi7IjQKH;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_017f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Expected native int or pointer, but got O
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a81: Unknown result type (might be due to invalid IL or missing references)
			//IL_0222: Expected O, but got I4
			//IL_0251: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_045d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a31: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0aa5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b64: Expected O, but got Ref
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eac: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0698: Unknown result type (might be due to invalid IL or missing references)
			//IL_0716: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d63: Expected O, but got I4
			//IL_0d97: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da1: Expected I4, but got Unknown
			//IL_0df3: Expected O, but got I4
			//IL_0f49: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f4f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f26: Expected O, but got I4
			//IL_0c47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e29: Expected I4, but got Unknown
			//IL_0d1d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ccc: Expected O, but got Ref
			//IL_0eec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fcf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0815: Expected O, but got I4
			//IL_14e1: Expected O, but got I4
			//IL_1296: Unknown result type (might be due to invalid IL or missing references)
			//IL_129c: Invalid comparison between Unknown and I4
			//IL_1181: Unknown result type (might be due to invalid IL or missing references)
			//IL_10dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1331: Unknown result type (might be due to invalid IL or missing references)
			//IL_1434: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c9: Expected O, but got I4
			//IL_1300: Expected O, but got I4
			//IL_16fa: Expected O, but got I4
			//IL_1456: Unknown result type (might be due to invalid IL or missing references)
			//IL_16bf: Expected O, but got I4
			//IL_1b41->IL1ad2: Incompatible stack heights: 3 vs 1
			//IL_00c5->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0130->IL00fb: Incompatible stack heights: 0 vs 2
			//IL_00ff->IL00ff: Incompatible stack heights: 3 vs 1
			//IL_0a47->IL0960: Incompatible stack heights: 2 vs 1
			//IL_0a52->IL0960: Incompatible stack heights: 2 vs 1
			//IL_0e07->IL0bb7: Incompatible stack heights: 2 vs 1
			//IL_0f3a->IL0bb7: Incompatible stack heights: 2 vs 1
			//IL_0fc7->IL0bb7: Incompatible stack heights: 2 vs 1
			//IL_0e12->IL0bb7: Incompatible stack heights: 2 vs 1
			//IL_0f45->IL0bb7: Incompatible stack heights: 2 vs 1
			//IL_0829->IL01dd: Incompatible stack heights: 2 vs 1
			//IL_0834->IL01dd: Incompatible stack heights: 2 vs 1
			//IL_17c4->IL1805: Incompatible stack heights: 2 vs 3
			//IL_130a->IL0fea: Incompatible stack heights: 2 vs 1
			//IL_16f5->IL1736: Incompatible stack heights: 2 vs 3
			//IL_1819->IL0ff2: Incompatible stack heights: 2 vs 1
			//IL_1754->IL0ff2: Incompatible stack heights: 2 vs 1
			//IL_175f->IL0ff2: Incompatible stack heights: 2 vs 1
			//IL_16c9->IL0fea: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			bjjkroRDgpdJvVafG6y bjjkroRDgpdJvVafG6y2 = default;
			int num27 = default;
			JsonDocument val5 = default;
			int num24 = default;
			int num26 = default;
			int num19 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__2 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val4 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			int num16 = default;
			ConfiguredTaskAwaitable<string> val3 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler5 = default;
			string text5 = default;
			JsonDocument val = default;
			int num10 = default;
			int? num11 = default;
			JsonElement val2 = default;
			int? num9 = default;
			VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC2 = default;
			v8S9tafSfKHe7BkHpBrA challenge = default;
			string message = default;
			HRAgcW6NqPAffX13iZE hRAgcW6NqPAffX13iZE = default;
			string rawMessage = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			string text7 = default;
			string text4 = default;
			int num15 = default;
			int num18 = default;
			int num22 = default;
			int num29 = default;
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
								goto case 6;
							}
							_ = __t__builder;
							_ = 3;
							continue;
						case 1:
							num4 = __1__state;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							return;
						case 0:
							bjjkroRDgpdJvVafG6y2 = __4__this;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num3 = 11;
							}
							continue;
						case 6:
							_content_5__2 = null;
							num3 = 4;
							continue;
						case 2:
							try
							{
								int num5;
								if ((uint)num4 > 1u)
								{
									num5 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num5 = 0;
									}
									goto IL_00ff;
								}
								goto IL_0907;
								IL_00ff:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num27 == 11)
										{
											break;
										}
										if (num27 == 991)
										{
											continue;
										}
										goto case 2;
									case 2:
										_ = sauthJsonValue;
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_RegisterUniSauthAsync_d__8*)(nint)System.Text.Encoding.UTF8)->_content_5__2, "application/json");
										num27 = 11;
										continue;
									case 0:
										val5 = System.Text.Json.JsonDocument.Parse(sauthJsonValue, default(JsonDocumentOptions));
										num5 = 3;
										continue;
									case 3:
										try
										{
											JsonElement root2 = (val5).RootElement;
											int num23 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
											{
												num23 = 1;
											}
											while (true)
											{
												switch (num23)
												{
												default:
													if (num24 == 989)
													{
														num23 = num24;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_01dd;
												}
												_ = "Login4399";
												global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler7 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)10;
												(defaultInterpolatedStringHandler7).AppendLiteral("客户端 uni_sauth 请求字段: app_channel=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qYnR0dwFDI(root2, "app_channel"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("login_channel=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qYnR0dwFDI(root2, "login_channel"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("gameid=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qYnR0dwFDI(root2, "gameid"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("sdk_version=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qYnR0dwFDI(root2, "sdk_version"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("access_token=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qmQRScd3iC(root2, "access_token") ? "present" : "missing");
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("access_token_empty=");
												defaultInterpolatedStringHandler7.AppendFormatted<bool>(GPKRcdCncq(root2, "access_token"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("deviceid=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qmQRScd3iC(root2, "deviceid") ? "present" : "missing");
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("deviceid_empty=");
												defaultInterpolatedStringHandler7.AppendFormatted<bool>(GPKRcdCncq(root2, "deviceid"));
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("udid=");
												(defaultInterpolatedStringHandler7).AppendFormatted(qmQRScd3iC(root2, "udid") ? "present" : "missing");
												(defaultInterpolatedStringHandler7).AppendLiteral(", ");
												(defaultInterpolatedStringHandler7).AppendLiteral("payloadBytes=");
												defaultInterpolatedStringHandler7.AppendFormatted<int>((System.Text.Encoding.UTF8).GetByteCount(sauthJsonValue));
												gX17swyO7x0JWQxdaD1.IdOy6I4Chb((string)157, (defaultInterpolatedStringHandler7).ToStringAndClear());
												_ = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
												{
													_ = 2;
												}
												continue;
												end_IL_01dd:
												break;
											}
										}
										finally
										{
											if (num4 < 0)
											{
												int num25 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
												{
													num25 = 2;
												}
												while (true)
												{
													switch (num25)
													{
													default:
														if (num26 == 990)
														{
															num25 = num26;
															continue;
														}
														break;
													case 2:
														if (val5 != null)
														{
															num25 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
															{
																num25 = 4;
															}
															continue;
														}
														break;
													case 1:
														(val5).Dispose();
														num25 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
														{
															num25 = 4;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto case 2;
									case 1:
										try
										{
											int num6;
											if (num4 != 0)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
												{
													num6 = 10;
												}
												goto IL_0960;
											}
											goto IL_0a7b;
											IL_0960:
											while (true)
											{
												int num20;
												switch (num6)
												{
												case 3:
													return;
												default:
													if (num19 != 22)
													{
														if (num19 == 1002)
														{
															goto IL_095c;
														}
														goto case 13;
													}
													goto case 7;
												case 2:
													if (&_u__2 != null)
													{
														num6 = 7;
														continue;
													}
													goto case 11;
												case 9:
													num4 = (__1__state = -1);
													num20 = 22;
													goto IL_0958;
												case 4:
													(bjjkroRDgpdJvVafG6y2.RoVRr806l8).PostAsync("https://mgbsdk.matrix.netease.com/x19/sdk/uni_sauth", (HttpContent)(object)_content_5__2, cancellationToken);
													val4 = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
													_ = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
													{
														_ = 19;
													}
													continue;
												case 11:
													num4 = (__1__state = 0);
													num6 = 13;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
													{
														num6 = 5;
													}
													continue;
												case 6:
													break;
												case 13:
													__u__1 = _u__2;
													num6 = 10;
													continue;
												case 0:
													if (num4 != 1)
													{
														num6 = 4;
														continue;
													}
													goto case 1;
												case 10:
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _RegisterUniSauthAsync_d__8>(ref _u__2, ref this);
													num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
													{
														num6 = 5;
													}
													continue;
												case 1:
													num20 = 12;
													goto IL_0958;
												case 14:
													_response_5__3 = response_5__;
													num6 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
													{
														num6 = 1;
													}
													continue;
												case 5:
													__u__1 = default;
													num6 = 9;
													continue;
												case 7:
													response_5__ = (HttpResponseMessage)(object)(&_u__2);
													num6 = 14;
													continue;
												case 8:
													_u__2 = val4;
													num6 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
													{
														num6 = 2;
													}
													continue;
												case 12:
													{
														try
														{
															int num7;
															if (num4 != 1)
															{
																num7 = 12;
																goto IL_0bb7;
															}
															goto IL_0eab;
															IL_0eab:
															_u__ = __u__2;
															num7 = 21;
															goto IL_0bb7;
															IL_0bb7:
															while (true)
															{
																switch (num7)
																{
																case 10:
																	return;
																default:
																	if (num16 != 29)
																	{
																		if (num16 == 1009)
																		{
																			goto IL_0bb3;
																		}
																		goto case 7;
																	}
																	__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _RegisterUniSauthAsync_d__8>(ref _u__, ref this);
																	num7 = 10;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
																	{
																		num7 = 13;
																	}
																	continue;
																case 11:
																	_u__ = val3;
																	num7 = 16;
																	continue;
																case 13:
																	(defaultInterpolatedStringHandler5).AppendLiteral("4399 会话认证失败（HTTP ");
																	num7 = 14;
																	continue;
																case 3:
																	if ((_response_5__3).IsSuccessStatusCode)
																	{
																		num7 = 8;
																		continue;
																	}
																	goto case 2;
																case 5:
																case 19:
																	text5 = (string)(&_u__);
																	num7 = 3;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
																	{
																		num7 = 15;
																	}
																	continue;
																case 15:
																	(defaultInterpolatedStringHandler5).AppendLiteral("）");
																	num7 = 6;
																	continue;
																case 18:
																	__u__2 = _u__;
																	num16 = 29;
																	goto IL_0bb3;
																case 1:
																	num4 = (__1__state = -1);
																	num7 = 19;
																	continue;
																case 2:
																{
																	_ = "Login4399";
																	global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler6 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)2;
																	(defaultInterpolatedStringHandler6).AppendLiteral("客户端 uni_sauth HTTP 拒绝: status=");
																	defaultInterpolatedStringHandler6.AppendFormatted<int>((int)(_response_5__3).StatusCode);
																	(defaultInterpolatedStringHandler6).AppendLiteral(", responseBytes=");
																	defaultInterpolatedStringHandler6.AppendFormatted<int>((text5).Length);
																	gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)46, (defaultInterpolatedStringHandler6).ToStringAndClear());
																	_ = 9;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
																	{
																		_ = 21;
																	}
																	continue;
																}
																case 14:
																	defaultInterpolatedStringHandler5.AppendFormatted<int>((int)(_response_5__3).StatusCode);
																	num7 = 15;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
																	{
																		num7 = 6;
																	}
																	continue;
																case 16:
																	if (&_u__ != null)
																	{
																		num7 = 5;
																		continue;
																	}
																	goto case 4;
																case 0:
																	goto end_IL_0bb7;
																case 17:
																	break;
																case 4:
																	num4 = (__1__state = 1);
																	num7 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
																	{
																		num7 = 18;
																	}
																	continue;
																case 21:
																	__u__2 = default;
																	num7 = 1;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																	{
																		num7 = 16;
																	}
																	continue;
																case 9:
																	_ = 18;
																	defaultInterpolatedStringHandler5 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																	_ = 13;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
																	{
																		_ = 16;
																	}
																	continue;
																case 7:
																case 8:
																	val = System.Text.Json.JsonDocument.Parse(text5, default(JsonDocumentOptions));
																	num7 = 20;
																	continue;
																case 6:
																{
																	VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.edBRb5mpvV((defaultInterpolatedStringHandler5).ToStringAndClear());
																	num7 = 9;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																	{
																		num7 = 0;
																	}
																	continue;
																}
																case 12:
																	((_response_5__3).Content).ReadAsStringAsync(cancellationToken);
																	val3 = (ConfiguredTaskAwaitable<string>)0;
																	_ = 11;
																	continue;
																case 20:
																	{
																		try
																		{
																			JsonElement root = (val).RootElement;
																			int num8 = 22;
																			while (true)
																			{
																				int num12;
																				string text;
																				string text6;
																				switch (num8)
																				{
																				default:
																					if (num10 != 42)
																					{
																						if (num10 == 1022)
																						{
																							goto IL_0fee;
																						}
																						goto case 0;
																					}
																					num11 = BoPRWC1bJW(root, "code");
																					num12 = 13;
																					goto IL_0fea;
																				case 28:
																					if (!(root).TryGetProperty("msg", ref val2))
																					{
																						num8 = 6;
																						continue;
																					}
																					goto case 11;
																				case 13:
																					num9 = BoPRWC1bJW(root, "subcode");
																					num8 = 34;
																					continue;
																				case 29:
																					vS3DDV6icfQFnd6RdNC2.SmsChallenge = challenge;
																					num8 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
																					{
																						num8 = 23;
																					}
																					continue;
																				case 0:
																					vS3DDV6icfQFnd6RdNC2 = (VS3DDV6icfQFnd6RdNC)new VS3DDV6icfQFnd6RdNC(Success: false, (challenge).Message);
																					num8 = 29;
																					continue;
																				case 33:
																					text = string.Empty;
																					break;
																				case 25:
																					message = hRAgcW6NqPAffX13iZE.Message;
																					num12 = 42;
																					goto IL_0fea;
																				case 12:
																					hRAgcW6NqPAffX13iZE = HRAgcW6NqPAffX13iZE.LoS6pl05Rg(root, "4399 会话认证失败");
																					num8 = 25;
																					continue;
																				case 7:
																				case 23:
																					if ((message).Contains("aid login limit", (StringComparison)5))
																					{
																						num8 = 31;
																						continue;
																					}
																					goto case 8;
																				case 19:
																					if (!v8S9tafSfKHe7BkHpBrA.DhCfSjXshTa((int)(&num11), rawMessage, out challenge))
																					{
																						num12 = 24;
																						goto IL_0fea;
																					}
																					goto case 0;
																				case 2:
																					(defaultInterpolatedStringHandler).AppendLiteral("）");
																					num8 = 14;
																					continue;
																				case 32:
																					goto end_IL_0ff2;
																				case 31:
																				{
																					VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.O3c6zq7Mse("凭证已生成且账号身份已被识别；当前 AID 登录数量已达限制，请释放旧登录后使用");
																					num8 = 18;
																					continue;
																				}
																				case 11:
																					if ((int)(val2).ValueKind != 3)
																					{
																						num8 = 3;
																						continue;
																					}
																					text6 = (val2).GetString();
																					goto IL_16d5;
																				case 27:
																					goto end_IL_0ff2;
																				case 4:
																				case 20:
																				{
																					VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.O3c6zq7Mse("登录凭证已生成并通过认证校验");
																					num8 = 42;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
																					{
																						num8 = 10;
																					}
																					continue;
																				}
																				case 17:
																					_ = 2;
																					defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
																					_ = 30;
																					goto IL_0fea;
																				case 26:
																					if (&num9 == null)
																					{
																						num8 = 33;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																						{
																							num8 = 25;
																						}
																						continue;
																					}
																					goto case 17;
																				case 22:
																					if (Y9KRyhOwiT(root, 200))
																					{
																						num8 = 20;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
																						{
																							num8 = 4;
																						}
																						continue;
																					}
																					goto case 12;
																				case 18:
																					goto end_IL_0ff2;
																				case 30:
																					(defaultInterpolatedStringHandler).AppendLiteral("（");
																					num8 = 21;
																					continue;
																				case 1:
																				{
																					VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC = vS3DDV6icfQFnd6RdNC2;
																					num8 = 32;
																					continue;
																				}
																				case 24:
																					if (!v8S9tafSfKHe7BkHpBrA.DhCfSjXshTa((int)(&num11), message, out challenge))
																					{
																						num8 = 23;
																						continue;
																					}
																					goto case 0;
																				case 8:
																					if (&num11 != null)
																					{
																						num8 = 17;
																						continue;
																					}
																					goto case 26;
																				case 9:
																				{
																					VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.edBRb5mpvV(string.Concat(message, text7));
																					num8 = 27;
																					continue;
																				}
																				case 34:
																					text4 = lEmRJm1MxD(root);
																					num8 = 5;
																					continue;
																				case 3:
																				case 6:
																					text6 = message;
																					goto IL_16d5;
																				case 5:
																				{
																					_ = "Login4399";
																					global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler4 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)5;
																					(defaultInterpolatedStringHandler4).AppendLiteral("客户端 uni_sauth 业务拒绝: code=");
																					object obj;
																					if (&num11 == null)
																					{
																						obj = null;
																					}
																					else
																					{
																						int num13 = (int)(&num11);
																						obj = (num13).ToString();
																					}
																					if (obj == null)
																					{
																						obj = "-";
																					}
																					(defaultInterpolatedStringHandler4).AppendFormatted((string)obj);
																					(defaultInterpolatedStringHandler4).AppendLiteral(", ");
																					(defaultInterpolatedStringHandler4).AppendLiteral("subcode=");
																					object obj2;
																					if (&num9 == null)
																					{
																						obj2 = null;
																					}
																					else
																					{
																						int num13 = (int)(&num9);
																						obj2 = (num13).ToString();
																					}
																					if (obj2 == null)
																					{
																						obj2 = "-";
																					}
																					(defaultInterpolatedStringHandler4).AppendFormatted((string)obj2);
																					(defaultInterpolatedStringHandler4).AppendLiteral(", status=");
																					(defaultInterpolatedStringHandler4).AppendFormatted(text4);
																					(defaultInterpolatedStringHandler4).AppendLiteral(", ");
																					(defaultInterpolatedStringHandler4).AppendFormatted(hRAgcW6NqPAffX13iZE.Diagnostic);
																					(defaultInterpolatedStringHandler4).AppendLiteral(", responseBytes=");
																					defaultInterpolatedStringHandler4.AppendFormatted<int>((text5).Length);
																					gX17swyO7x0JWQxdaD1.U3iyRWfbJV((string)62, (defaultInterpolatedStringHandler4).ToStringAndClear());
																					_ = 28;
																					goto IL_0fea;
																				}
																				case 21:
																				{
																					_ = defaultInterpolatedStringHandler;
																					string text3;
																					if (&num11 == null)
																					{
																						_ = string.Empty;
																					}
																					else
																					{
																						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler3 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																						(defaultInterpolatedStringHandler3).AppendLiteral("code=");
																						defaultInterpolatedStringHandler3.AppendFormatted<int?>(num11);
																						text3 = (defaultInterpolatedStringHandler3).ToStringAndClear();
																					}
																					(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)5).AppendFormatted(text3);
																					_ = 17;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
																					{
																						_ = 15;
																					}
																					continue;
																				}
																				case 15:
																					(defaultInterpolatedStringHandler).AppendFormatted((&num11 != null && &num9 != null) ? ", " : string.Empty);
																					num8 = 16;
																					continue;
																				case 16:
																				{
																					_ = defaultInterpolatedStringHandler;
																					string text2;
																					if (&num9 == null)
																					{
																						_ = string.Empty;
																					}
																					else
																					{
																						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																						(defaultInterpolatedStringHandler2).AppendLiteral("subcode=");
																						defaultInterpolatedStringHandler2.AppendFormatted<int?>(num9);
																						text2 = (defaultInterpolatedStringHandler2).ToStringAndClear();
																					}
																					(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)8).AppendFormatted(text2);
																					_ = 2;
																					continue;
																				}
																				case 14:
																					text = (defaultInterpolatedStringHandler).ToStringAndClear();
																					break;
																				case 10:
																					goto end_IL_0ff2;
																					IL_0fea:
																					num10 = num12;
																					goto IL_0fee;
																					IL_0fee:
																					num8 = num10;
																					continue;
																					IL_16d5:
																					rawMessage = text6;
																					num8 = 19;
																					continue;
																				}
																				text7 = text;
																				num8 = 9;
																				continue;
																				end_IL_0ff2:
																				break;
																			}
																		}
																		finally
																		{
																			int num14;
																			if (num4 >= 0)
																			{
																				num14 = 3;
																				goto IL_185a;
																			}
																			goto IL_18d1;
																			IL_18d1:
																			if (val != null)
																			{
																				num14 = 2;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
																				{
																					num14 = 9;
																				}
																				goto IL_185a;
																			}
																			goto end_IL_1836;
																			IL_185a:
																			while (true)
																			{
																				switch (num14)
																				{
																				default:
																					if (num15 == 991)
																					{
																						num14 = num15;
																						continue;
																					}
																					goto case 2;
																				case 3:
																					goto end_IL_185a;
																				case 2:
																					(val).Dispose();
																					num14 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
																					{
																						num14 = 8;
																					}
																					continue;
																				case 1:
																					break;
																				case 0:
																					goto end_IL_185a;
																				}
																				goto IL_18d1;
																				continue;
																				end_IL_185a:
																				break;
																			}
																			end_IL_1836:;
																		}
																		goto end_IL_0bb7;
																	}
																	IL_0bb3:
																	num7 = num16;
																	continue;
																}
																goto IL_0eab;
																continue;
																end_IL_0bb7:
																break;
															}
														}
														finally
														{
															int num17;
															if (num4 >= 0)
															{
																num17 = 2;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																{
																	num17 = 0;
																}
																goto IL_1931;
															}
															goto IL_1997;
															IL_1931:
															while (true)
															{
																switch (num17)
																{
																default:
																	if (num18 == 991)
																	{
																		num17 = num18;
																		continue;
																	}
																	break;
																case 0:
																	(_response_5__3).Dispose();
																	num17 = 3;
																	continue;
																case 2:
																	goto end_IL_1931;
																case 1:
																	break;
																case 3:
																	goto end_IL_1931;
																}
																goto IL_1997;
																continue;
																end_IL_1931:
																break;
															}
															goto end_IL_18f8;
															IL_1997:
															if (_response_5__3 != null)
															{
																num17 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
																{
																	num17 = 3;
																}
																goto IL_1931;
															}
															end_IL_18f8:;
														}
														goto end_IL_0960;
													}
													IL_095c:
													num6 = num19;
													continue;
													IL_0958:
													num19 = num20;
													goto IL_095c;
												}
												goto IL_0a7b;
												continue;
												end_IL_0960:
												break;
											}
											goto end_IL_0928;
											IL_0a7b:
											_u__2 = __u__1;
											num6 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
											{
												num6 = 1;
											}
											goto IL_0960;
											end_IL_0928:;
										}
										finally
										{
											int num21;
											if (num4 >= 0)
											{
												num21 = 3;
												goto IL_19e6;
											}
											goto IL_1a74;
											IL_1a36:
											(_content_5__2).Dispose();
											num21 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
											{
												num21 = 3;
											}
											goto IL_19e6;
											IL_19e6:
											while (true)
											{
												switch (num21)
												{
												default:
													if (num22 == 992)
													{
														num21 = num22;
														continue;
													}
													break;
												case 1:
													break;
												case 2:
													goto IL_1a36;
												case 3:
													break;
												case 4:
													goto IL_1a74;
												case 0:
													break;
												}
												break;
											}
											goto end_IL_19c2;
											IL_1a74:
											if (_content_5__2 == null)
											{
												num21 = 10;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
												{
													num21 = 1;
												}
												goto IL_19e6;
											}
											goto IL_1a36;
											end_IL_19c2:;
										}
										goto end_IL_00ff;
									}
									goto IL_0907;
									continue;
									end_IL_00ff:
									break;
								}
								goto end_IL_00c6;
								IL_0907:
								num5 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
								{
									num5 = 1;
								}
								goto IL_00ff;
								end_IL_00c6:;
							}
							catch (global::System.Exception)
							{
								int num28 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
								{
									num28 = 7;
								}
								while (true)
								{
									switch (num28)
									{
									case 3:
										return;
									default:
										if (num29 != 11)
										{
											if (num29 == 991)
											{
												goto IL_1ace;
											}
											goto case 2;
										}
										_content_5__2 = null;
										num28 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
										{
											num28 = 0;
										}
										break;
									case 0:
										_response_5__3 = null;
										num28 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
										{
											num28 = 5;
										}
										break;
									case 2:
										_ = __t__builder;
										_ = 3;
										break;
									case 1:
										{
											__1__state = -2;
											num29 = 11;
											goto IL_1ace;
										}
										IL_1ace:
										num28 = num29;
										break;
									}
								}
							}
							break;
						case 5:
							break;
						case 4:
							goto end_IL_000c;
						}
						__1__state = -2;
						num3 = 6;
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				_response_5__3 = null;
				num = 13;
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
						case 0:
							return;
						case 2:
							num3 = 1;
							continue;
						case 1:
							goto end_IL_000e;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool lVw8CQ97AwuUynD7lLFo()
		{
			return TQlrgT977ACcsi7IjQKH == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Uk38nn97ITXpiFKSH3px()
		{
			return TQlrgT977ACcsi7IjQKH;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ValidateWrapperAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<VS3DDV6icfQFnd6RdNC> __t__builder;

		public bjjkroRDgpdJvVafG6y __4__this;

		public string sauthWrapper;

		public bool registerUniSauth;

		public CancellationToken cancellationToken;

		private JsonDocument _document_5__2;

		private ConfiguredTaskAwaitable<VS3DDV6icfQFnd6RdNC>.ConfiguredTaskAwaiter __u__1;

		internal static object Qm37FQ97ddial7kYTpX1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_031a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0365: Unknown result type (might be due to invalid IL or missing references)
			//IL_033c: Unknown result type (might be due to invalid IL or missing references)
			//IL_033e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0452: Expected O, but got Ref
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0537: Invalid comparison between Unknown and I4
			//IL_0727->IL06e6: Incompatible stack heights: 3 vs 1
			//IL_0732->IL06e6: Incompatible stack heights: 3 vs 1
			//IL_07ac->IL0008: Incompatible stack heights: 3 vs 1
			//IL_07b7->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0330->IL0238: Incompatible stack heights: 2 vs 1
			//IL_033b->IL0238: Incompatible stack heights: 2 vs 1
			int num3 = default;
			int num5 = default;
			int num12 = default;
			ConfiguredTaskAwaitable<VS3DDV6icfQFnd6RdNC>.ConfiguredTaskAwaiter _u__ = default;
			int num9 = default;
			JsonElement val3 = default;
			bjjkroRDgpdJvVafG6y bjjkroRDgpdJvVafG6y2 = default;
			ConfiguredTaskAwaitable<VS3DDV6icfQFnd6RdNC> val = default;
			JsonElement val2 = default;
			int num11 = default;
			int num14 = default;
			int num16 = default;
			while (true)
			{
				int num = 4;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 11)
							{
								if (num == 992)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							return;
						case 0:
							try
							{
								int num4;
								if (num3 == 0)
								{
									num4 = 4;
									goto IL_006e;
								}
								goto IL_00ac;
								IL_006a:
								num4 = num5;
								goto IL_006e;
								IL_006e:
								while (true)
								{
									VS3DDV6icfQFnd6RdNC vS3DDV6icfQFnd6RdNC;
									switch (num4)
									{
									case 1:
										goto end_IL_006e;
									case 3:
										goto end_IL_004b;
									case 0:
									case 4:
										goto IL_00ed;
									case 2:
										goto IL_00f8;
									case 5:
										try
										{
											int num6;
											if (num3 != 0)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
												{
													num6 = 1;
												}
												goto IL_01a6;
											}
											goto IL_01ca;
											IL_01a6:
											while (true)
											{
												switch (num6)
												{
												default:
													if (num12 == 990)
													{
														num6 = num12;
														continue;
													}
													goto case 0;
												case 2:
													break;
												case 0:
													_document_5__2 = System.Text.Json.JsonDocument.Parse(sauthWrapper, default(JsonDocumentOptions));
													num6 = 2;
													continue;
												case 1:
													try
													{
														int num7;
														if (num3 != 0)
														{
															num7 = 3;
															goto IL_0238;
														}
														goto IL_03c0;
														IL_03c0:
														_u__ = __u__1;
														num7 = 2;
														goto IL_0238;
														IL_0238:
														while (true)
														{
															int num8;
															switch (num7)
															{
															default:
																if (num9 != 24)
																{
																	if (num9 == 1004)
																	{
																		goto IL_0234;
																	}
																	goto case 11;
																}
																if ((int)(val3).ValueKind == 3)
																{
																	num7 = 8;
																	continue;
																}
																goto case 4;
															case 4:
																vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.edBRb5mpvV("生成的登录凭证格式无效");
																num7 = 14;
																continue;
															case 8:
																if (string.IsNullOrWhiteSpace((val3).GetString()))
																{
																	num7 = 4;
																	continue;
																}
																goto case 0;
															case 0:
																bjjkroRDgpdJvVafG6y2.ValidateCoreAsync((val3).GetString(), sauthWrapper, registerUniSauth, cancellationToken);
																val = (ConfiguredTaskAwaitable<VS3DDV6icfQFnd6RdNC>)0;
																_ = 7;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
																{
																	_ = 4;
																}
																continue;
															case 9:
																__u__1 = _u__;
																num7 = 11;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
																{
																	num7 = 19;
																}
																continue;
															case 7:
																_u__ = val;
																num7 = 5;
																continue;
															case 10:
																return;
															case 2:
																__u__1 = default;
																num7 = 8;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
																{
																	num7 = 15;
																}
																continue;
															case 1:
																break;
															case 11:
																__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<VS3DDV6icfQFnd6RdNC>.ConfiguredTaskAwaiter, _ValidateWrapperAsync_d__6>(ref _u__, ref this);
																num7 = 10;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
																{
																	num7 = 4;
																}
																continue;
															case 13:
																if ((val2).TryGetProperty("sauth_json", ref val3))
																{
																	num8 = 24;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
																	{
																		num8 = 8;
																	}
																	goto IL_0230;
																}
																goto case 4;
															case 16:
																vS3DDV6icfQFnd6RdNC = (VS3DDV6icfQFnd6RdNC)(&_u__);
																num7 = 6;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
																{
																	num7 = 3;
																}
																continue;
															case 15:
																num3 = (__1__state = -1);
																num7 = 16;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
																{
																	num7 = 8;
																}
																continue;
															case 12:
																num3 = (__1__state = 0);
																num7 = 9;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
																{
																	num7 = 9;
																}
																continue;
															case 3:
																val2 = (_document_5__2).RootElement;
																num8 = 13;
																goto IL_0230;
															case 5:
																if (&_u__ == null)
																{
																	num7 = 23;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
																	{
																		num7 = 12;
																	}
																	continue;
																}
																goto case 16;
															case 14:
																goto end_IL_0238;
															case 6:
																goto end_IL_0238;
																IL_0234:
																num7 = num9;
																continue;
																IL_0230:
																num9 = num8;
																goto IL_0234;
															}
															goto IL_03c0;
															continue;
															end_IL_0238:
															break;
														}
													}
													finally
													{
														if (num3 < 0)
														{
															int num10 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
															{
																num10 = 7;
															}
															while (true)
															{
																switch (num10)
																{
																default:
																	if (num11 == 991)
																	{
																		goto IL_0580;
																	}
																	goto case 0;
																case 0:
																	if (_document_5__2 == null)
																	{
																		num10 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
																		{
																			num10 = 3;
																		}
																		continue;
																	}
																	goto case 1;
																case 1:
																	(_document_5__2).Dispose();
																	num11 = 2;
																	goto IL_0580;
																case 3:
																	break;
																case 2:
																	break;
																	IL_0580:
																	num10 = num11;
																	continue;
																}
																break;
															}
														}
													}
													goto end_IL_01a6;
												}
												goto IL_01ca;
												continue;
												end_IL_01a6:
												break;
											}
											goto end_IL_016e;
											IL_01ca:
											num6 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
											{
												num6 = 0;
											}
											goto IL_01a6;
											end_IL_016e:;
										}
										catch (JsonException)
										{
											int num13 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
											{
												num13 = 6;
											}
											while (true)
											{
												switch (num13)
												{
												default:
													if (num14 == 989)
													{
														num13 = num14;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_0647;
												}
												vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.edBRb5mpvV("生成的登录凭证格式无效");
												num13 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
												{
													num13 = 3;
												}
												continue;
												end_IL_0647:
												break;
											}
										}
										goto end_IL_004b;
									}
									if (num5 != 13)
									{
										if (num5 == 993)
										{
											goto IL_006a;
										}
										goto IL_00f8;
									}
									if (string.IsNullOrWhiteSpace(sauthWrapper))
									{
										num4 = 2;
										continue;
									}
									goto IL_00ed;
									IL_00f8:
									vS3DDV6icfQFnd6RdNC = VS3DDV6icfQFnd6RdNC.edBRb5mpvV("生成的登录凭证为空");
									num4 = 3;
									continue;
									IL_00ed:
									num4 = 5;
									continue;
									end_IL_006e:
									break;
								}
								goto IL_00ac;
								IL_00ac:
								System.ObjectDisposedException.ThrowIf(bjjkroRDgpdJvVafG6y2.zNQRoMIrO9, bjjkroRDgpdJvVafG6y2);
								num5 = 13;
								goto IL_006a;
								end_IL_004b:;
							}
							catch (global::System.Exception)
							{
								int num15 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
								{
									num15 = 5;
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
									case 1:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
										{
											_ = 5;
										}
										continue;
									case 2:
										break;
									case 0:
										return;
									}
									__1__state = -2;
									num15 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
									{
										num15 = 0;
									}
								}
							}
							goto case 1;
						case 4:
							num3 = __1__state;
							num2 = 3;
							continue;
						case 2:
							break;
						case 3:
							bjjkroRDgpdJvVafG6y2 = __4__this;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
							{
								num2 = 0;
							}
							continue;
						case 1:
							__1__state = -2;
							num2 = 2;
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
				_ = __t__builder;
				_ = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
				{
					_ = 11;
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
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
							{
								num3 = 6;
							}
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ldIXwX97Kg1dL9MfjBKG()
		{
			return Qm37FQ97ddial7kYTpX1 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object a8NDIn97HujRCQHAMrX2()
		{
			return Qm37FQ97ddial7kYTpX1;
		}
	}

	private readonly object RoVRr806l8;

	private bool zNQRoMIrO9;

	private static object VJFU7dZQxkrAbShJJsQA;

	[MethodImpl((MethodImplOptions)8)]
	public bjjkroRDgpdJvVafG6y()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task<VS3DDV6icfQFnd6RdNC> ValidateAsync(string sauthJsonValue, string sauthWrapper, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return ValidateCoreAsync(sauthJsonValue, sauthWrapper, registerUniSauth: true, cancellationToken);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe global::System.Threading.Tasks.Task<VS3DDV6icfQFnd6RdNC> GA8RVS1N3K(string sauthWrapper, bool registerUniSauth, CancellationToken cancellationToken)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.registerUniSauth = registerUniSauth;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_ValidateWrapperAsync_d__6*)null)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<VS3DDV6icfQFnd6RdNC> ValidateCoreAsync(string sauthJsonValue, string sauthWrapper, bool registerUniSauth, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<VS3DDV6icfQFnd6RdNC> SOPRYP9TUa(string sauthJsonValue, CancellationToken cancellationToken)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__1__state = -1;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RegisterUniSauthAsync_d__8*)12)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool qmQRScd3iC(JsonElement root, object propertyName)
	{
		object obj = default;
		return (root).TryGetProperty((string)propertyName, ref obj);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool GPKRcdCncq(JsonElement root, object propertyName)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_0091->IL0010: Incompatible stack types: I4 vs O
		//IL_005e->IL0010: Incompatible stack types: I4 vs O
		//IL_009c->IL0010: Incompatible stack types: I4 vs O
		//IL_0069->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		object obj3 = default;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 3:
					if ((int)(obj3).ValueKind == 3)
					{
						obj2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 2:
					if (!(root).TryGetProperty((string)propertyName, ref obj3))
					{
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							obj2 = 3;
						}
						continue;
					}
					goto case 3;
				case 0:
					return string.IsNullOrEmpty((obj3).GetString());
				case 1:
					break;
				}
				return false;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string qYnR0dwFDI(JsonElement root, object propertyName)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static VS3DDV6icfQFnd6RdNC ycsR8R0lFH(object sauthJsonValue)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Invalid comparison between Unknown and I4
		//IL_0077: Expected I4, but got O
		//IL_00a9: Expected O, but got I4
		//IL_00fe: Expected I4, but got O
		//IL_005c->IL006e: Incompatible stack types: I4 vs O
		//IL_0067->IL006e: Incompatible stack types: I4 vs O
		//IL_00a3->IL00ad: Incompatible stack types: I4 vs O
		//IL_03be->IL00ad: Incompatible stack types: I4 vs O
		//IL_02f3->IL00ad: Incompatible stack types: I4 vs O
		//IL_035b->IL00ad: Incompatible stack types: I4 vs O
		//IL_0225->IL00ad: Incompatible stack types: I4 vs O
		//IL_0334->IL00ad: Incompatible stack types: I4 vs O
		//IL_01ee->IL00ad: Incompatible stack types: I4 vs O
		//IL_026b->IL00ad: Incompatible stack types: I4 vs O
		//IL_0392->IL00ad: Incompatible stack types: I4 vs O
		//IL_0230->IL00ad: Incompatible stack types: I4 vs O
		//IL_033f->IL00ad: Incompatible stack types: I4 vs O
		//IL_01f9->IL00ad: Incompatible stack types: I4 vs O
		//IL_0276->IL00ad: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default;
		object obj7 = default;
		object result = default;
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 1:
			{
				object obj2 = System.Text.Json.JsonDocument.Parse((string)sauthJsonValue, (JsonDocumentOptions)default(TaskCompletionSource<>));
				object obj3 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
				{
					obj3 = 0;
				}
				while (true)
				{
					switch ((int)obj3)
					{
					default:
						if ((nint)obj4 == 988)
						{
							goto IL_006a;
						}
						break;
					case 0:
						break;
					}
					break;
					IL_006a:
					obj3 = obj4;
				}
				object obj5 = (obj2).RootElement;
				object obj6 = 3;
				while (true)
				{
					int num;
					switch ((int)obj6)
					{
					default:
						if ((nint)obj7 != 26)
						{
							if ((nint)obj7 != 1006)
							{
								break;
							}
							goto IL_00a9;
						}
						goto case 1;
					case 11:
						if (!SRgRQMmQHc((JsonElement)obj5, "gameid"))
						{
							num = 9;
							goto IL_00a5;
						}
						goto case 12;
					case 0:
						if (!SRgRQMmQHc((JsonElement)obj5, "platform"))
						{
							num = 26;
							goto IL_00a5;
						}
						goto case 4;
					case 12:
						if (!SRgRQMmQHc((JsonElement)obj5, "app_channel"))
						{
							obj6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								obj6 = 5;
							}
							continue;
						}
						goto case 10;
					case 5:
						if (OyaRCAOd23((JsonElement)obj5))
						{
							obj6 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								obj6 = 20;
							}
							continue;
						}
						goto case 1;
					case 16:
						if (!SRgRQMmQHc((JsonElement)obj5, "sessionid"))
						{
							obj6 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								obj6 = 13;
							}
							continue;
						}
						goto case 18;
					case 4:
						if (!SRgRQMmQHc((JsonElement)obj5, "sdkuid"))
						{
							num = 2;
							goto IL_00a5;
						}
						goto case 16;
					case 14:
					case 15:
						result = VS3DDV6icfQFnd6RdNC.O3c6zq7Mse("登录凭证已生成并通过认证校验");
						obj6 = 17;
						continue;
					case 10:
						if (!SRgRQMmQHc((JsonElement)obj5, "login_channel"))
						{
							obj6 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								obj6 = 7;
							}
							continue;
						}
						goto case 0;
					case 3:
						if ((int)(obj5).ValueKind == 1)
						{
							obj6 = 11;
							continue;
						}
						goto case 1;
					case 18:
						if (SRgRQMmQHc((JsonElement)obj5, "udid"))
						{
							obj6 = 5;
							continue;
						}
						goto case 1;
					case 1:
					case 2:
					case 7:
					case 8:
					case 9:
					case 13:
						result = VS3DDV6icfQFnd6RdNC.edBRb5mpvV("生成的登录凭证缺少必要字段");
						obj6 = 6;
						continue;
					case 6:
					case 17:
						break;
						IL_00a9:
						obj6 = obj7;
						continue;
						IL_00a5:
						obj7 = num;
						goto IL_00a9;
					}
					break;
				}
				break;
			}
			case 0:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		return (VS3DDV6icfQFnd6RdNC)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool Y9KRyhOwiT(JsonElement root, int expected)
	{
		//IL_000c: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_0087: Expected I4, but got O
		//IL_0065: Expected O, but got I4
		//IL_01e3: Expected O, but got I4
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_01d6: Expected O, but got I4
		//IL_0079->IL0010: Incompatible stack types: I4 vs O
		//IL_0084->IL0010: Incompatible stack types: I4 vs O
		//IL_01ed->IL0010: Incompatible stack types: I4 vs O
		//IL_00df->IL0010: Incompatible stack types: I4 vs O
		//IL_00a3->IL0010: Incompatible stack types: I4 vs O
		//IL_016f->IL0010: Incompatible stack types: I4 vs O
		//IL_013f->IL0010: Incompatible stack types: I4 vs O
		//IL_01c8->IL0010: Incompatible stack types: I4 vs O
		//IL_00ea->IL0010: Incompatible stack types: I4 vs O
		//IL_00ae->IL0010: Incompatible stack types: I4 vs O
		//IL_014a->IL0010: Incompatible stack types: I4 vs O
		//IL_01d3->IL0010: Incompatible stack types: I4 vs O
		//IL_01e0->IL0010: Incompatible stack types: I4 vs O
		int num = 7;
		object obj7 = default;
		object obj4 = default;
		object obj3 = default;
		object obj6 = default;
		object obj5 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					int num3;
					int num2;
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 17)
						{
							if ((nint)obj == 998)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						num3 = (((nint)obj7 == expected) ? 1 : 0);
						goto IL_01d4;
					case 1:
						obj4 = 0;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							obj2 = 5;
						}
						continue;
					case 0:
					case 4:
					case 10:
						return (byte)(int)obj4 != 0;
					case 5:
						if ((nint)obj3 != 3)
						{
							obj2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
							{
								obj2 = 8;
							}
							continue;
						}
						goto case 3;
					case 3:
						if (int.TryParse((obj6).GetString(), ref obj5))
						{
							obj2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								obj2 = 8;
							}
							continue;
						}
						num2 = 0;
						goto IL_01e1;
					case 7:
						if (!(root).TryGetProperty("code", ref obj6))
						{
							obj2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								obj2 = 6;
							}
						}
						else
						{
							obj3 = (obj6).ValueKind;
							obj2 = 5;
						}
						continue;
					case 6:
						return false;
					case 9:
						if ((obj6).TryGetInt32(ref obj7))
						{
							break;
						}
						num3 = 0;
						goto IL_01d4;
					case 2:
						num2 = (((nint)obj5 == expected) ? 1 : 0);
						goto IL_01e1;
					case 8:
						{
							if ((nint)obj3 == 4)
							{
								obj2 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
								{
									obj2 = 5;
								}
								continue;
							}
							goto case 1;
						}
						IL_01e1:
						obj4 = num2;
						obj2 = 10;
						continue;
						IL_01d4:
						obj4 = num3;
						obj2 = 4;
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
			num = 17;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
			{
				num = 8;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int? BoPRWC1bJW(JsonElement root, object propertyName)
	{
		object obj2 = default;
		object obj = obj2;
		_ = 12;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04;
		_ = 1;
		object obj3 = default;
		obj = obj3;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string lEmRJm1MxD(JsonElement root)
	{
		//IL_000c: Expected O, but got I4
		//IL_0051: Expected I4, but got O
		//IL_0192: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Invalid comparison between Unknown and I4
		//IL_00b4: Expected O, but got I4
		//IL_01a6->IL0010: Incompatible stack types: I4 vs O
		//IL_00be->IL0010: Incompatible stack types: I4 vs O
		//IL_01b1->IL0010: Incompatible stack types: I4 vs O
		//IL_021f->IL0010: Incompatible stack types: I4 vs O
		//IL_00aa->IL0010: Incompatible stack types: I4 vs O
		//IL_02e9->IL0010: Incompatible stack types: I4 vs O
		//IL_01e8->IL0010: Incompatible stack types: I4 vs O
		//IL_0204->IL0010: Incompatible stack types: I4 vs O
		//IL_0184->IL0010: Incompatible stack types: I4 vs O
		//IL_026a->IL0010: Incompatible stack types: I4 vs O
		//IL_022a->IL0010: Incompatible stack types: I4 vs O
		//IL_02f4->IL0010: Incompatible stack types: I4 vs O
		//IL_018f->IL0010: Incompatible stack types: I4 vs O
		//IL_0275->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		object obj6 = default;
		object obj4 = default;
		object obj5 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj3;
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 21)
						{
							if ((nint)obj == 1002)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 1;
					case 5:
						if (!(root).TryGetProperty("status", ref obj6))
						{
							obj2 = 4;
							continue;
						}
						goto case 8;
					case 12:
						obj4 = 0;
						obj2 = 3;
						continue;
					case 2:
						if (((string)obj5 == "aid login limit"))
						{
							num = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
							{
								num = 21;
							}
							break;
						}
						goto case 14;
					case 9:
						return "other_or_missing";
					case 0:
						return (string)obj5;
					case 11:
						if (((string)obj5 == "success"))
						{
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 12;
					case 1:
						obj4 = 1;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							obj2 = 10;
						}
						continue;
					case 7:
						if (!((string)obj5 == "login abnormally"))
						{
							obj2 = 2;
							continue;
						}
						goto case 1;
					case 8:
					{
						if ((int)(obj6).ValueKind != 3)
						{
							obj2 = 13;
							continue;
						}
						string text = (obj6).GetString();
						if (text == null)
						{
							num = 6;
							break;
						}
						obj3 = ((text).Trim()).ToLowerInvariant();
						goto IL_02d3;
					}
					case 3:
					case 10:
						if (obj4 != null)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								obj2 = 2;
							}
							continue;
						}
						goto case 9;
					case 14:
						if (!((string)obj5 == "ok"))
						{
							obj2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								obj2 = 11;
							}
							continue;
						}
						goto case 1;
					case 4:
					case 13:
						return "other_or_missing";
					case 6:
						{
							obj3 = null;
							goto IL_02d3;
						}
						IL_02d3:
						obj5 = obj3;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							obj2 = 7;
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
	private unsafe static bool SRgRQMmQHc(JsonElement root, object propertyName)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Invalid comparison between Unknown and I4
		//IL_005a->IL0010: Incompatible stack types: I4 vs O
		//IL_008d->IL0010: Incompatible stack types: I4 vs O
		//IL_0065->IL0010: Incompatible stack types: I4 vs O
		//IL_0098->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		object obj3 = default;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 1:
					if ((int)(obj3).ValueKind == 3)
					{
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							obj2 = 7;
						}
						continue;
					}
					break;
				case 2:
					if ((root).TryGetProperty((string)propertyName, ref obj3))
					{
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
						{
							obj2 = 7;
						}
						continue;
					}
					break;
				case 0:
					return !string.IsNullOrWhiteSpace((obj3).GetString());
				}
				return false;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool OyaRCAOd23(JsonElement root)
	{
		//IL_000c: Expected O, but got I4
		//IL_0045: Expected I4, but got O
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9->IL0010: Incompatible stack types: I4 vs O
		//IL_015d->IL0010: Incompatible stack types: I4 vs O
		//IL_00ee->IL0010: Incompatible stack types: I4 vs O
		//IL_0244->IL0010: Incompatible stack types: I4 vs O
		//IL_0126->IL0010: Incompatible stack types: I4 vs O
		//IL_029f->IL0010: Incompatible stack types: I4 vs O
		//IL_00d4->IL0010: Incompatible stack types: I4 vs O
		//IL_01fb->IL0010: Incompatible stack types: I4 vs O
		//IL_0168->IL0010: Incompatible stack types: I4 vs O
		//IL_0131->IL0010: Incompatible stack types: I4 vs O
		//IL_02aa->IL0010: Incompatible stack types: I4 vs O
		//IL_0206->IL0010: Incompatible stack types: I4 vs O
		int num = 7;
		object obj4 = default;
		object obj3 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 18)
						{
							goto IL_00d4;
						}
						if ((nint)obj == 999)
						{
							goto end_IL_0010;
						}
						goto case 9;
					case 3:
						if (!xT3R4ctwwX(root, "app_channel", "4399com"))
						{
							obj2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								obj2 = 11;
							}
							continue;
						}
						goto case 11;
					case 8:
						if ((obj4).Length != 0)
						{
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								obj2 = 8;
							}
							continue;
						}
						goto case 3;
					case 5:
						if (!string.IsNullOrWhiteSpace((string)obj4))
						{
							obj2 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								obj2 = 10;
							}
							continue;
						}
						if (obj4 == null)
						{
							obj2 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 8;
					case 6:
						break;
					case 9:
						return xT3R4ctwwX(root, "platform", "ad");
					case 0:
					case 1:
					case 2:
					case 4:
						return false;
					case 10:
						return true;
					case 7:
						if ((root).TryGetProperty("deviceid", ref obj3))
						{
							obj2 = 6;
							continue;
						}
						goto IL_00d4;
					case 11:
						{
							if (!xT3R4ctwwX(root, "login_channel", "4399com"))
							{
								obj2 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
								{
									obj2 = 2;
								}
								continue;
							}
							goto case 9;
						}
						IL_00d4:
						return false;
					}
					if ((int)(obj3).ValueKind != 3)
					{
						goto end_IL_000c;
					}
					obj4 = (obj3).GetString();
					obj2 = 5;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 18;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool xT3R4ctwwX(JsonElement root, object propertyName, object expected)
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Invalid comparison between Unknown and I4
		//IL_00a3->IL0010: Incompatible stack types: I4 vs O
		//IL_00ae->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		object obj3 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 991)
						{
							break;
						}
						goto case 1;
					case 3:
						return string.Equals((obj3).GetString(), (string)expected, (StringComparison)5);
					case 0:
						return false;
					case 2:
						if ((int)(obj3).ValueKind == 3)
						{
							goto end_IL_000c;
						}
						goto case 0;
					case 1:
						if (!(root).TryGetProperty((string)propertyName, ref obj3))
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								obj2 = 4;
							}
							continue;
						}
						goto case 2;
					}
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_00b3->IL0010: Incompatible stack types: I4 vs O
		//IL_00be->IL0010: Incompatible stack types: I4 vs O
		//IL_0063->IL0010: Incompatible stack types: I4 vs O
		//IL_006e->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 1:
						return;
					case 3:
						return;
					case 2:
						if (zNQRoMIrO9)
						{
							return;
						}
						goto end_IL_000c;
					case 0:
						(RoVRr806l8).Dispose();
						obj2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							obj2 = 8;
						}
						continue;
					}
					if ((nint)obj == 10)
					{
						zNQRoMIrO9 = true;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							obj2 = 4;
						}
						continue;
					}
					break;
				}
				if ((nint)obj != 991)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0091->IL0012: Incompatible stack types: I4 vs O
		//IL_006c->IL0012: Incompatible stack types: I4 vs O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		//IL_0077->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 2:
						break;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
						{
							obj2 = 2;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool qIKU1KZQFKuyOPoIyZIv()
	{
		return VJFU7dZQxkrAbShJJsQA == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bjjkroRDgpdJvVafG6y BmIgPRZQsdRCDP8YnrWQ()
	{
		return (bjjkroRDgpdJvVafG6y)VJFU7dZQxkrAbShJJsQA;
	}
}

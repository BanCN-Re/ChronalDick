using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using VZfsNuXA7S11f1qe8xel;
using caV83GXAx0MgWXxPfFqu;
using fDAldojjppXrctUVYOJn;
using vPsLRWXAKouaS91XjEO3;

namespace AB7B1dXA4X76svx1ebc1;

sealed class hWtPOFXACgnCfI2g7TyK : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _IssueAsync_d__5_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<CMd6QIXAPC7C8Vv5kluF> __t__builder;

		public W8UV04XAdpTXOmgNYBMi context;

		public CancellationToken cancellationToken;

		public string sauthWrapper;

		public hWtPOFXACgnCfI2g7TyK __4__this;

		private Dictionary<string, string> _form_5__2;

		private CancellationTokenSource _timeout_5__3;

		private byte[] _buffer_5__4;

		private HttpRequestMessage _request_5__5;

		private HttpResponseMessage _response_5__6;

		private Stream _stream_5__7;

		private int _length_5__8;

		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter __u__1;

		private ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter __u__2;

		private object __7__wrap8;

		private int __7__wrap9;

		private CMd6QIXAPC7C8Vv5kluF __7__wrap10;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__3;

		private ValueTaskAwaiter __u__4;

		internal static object Aff2EW9acAMZvE87D9Zh;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0a70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a75: Unknown result type (might be due to invalid IL or missing references)
			//IL_0711: Unknown result type (might be due to invalid IL or missing references)
			//IL_0713: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Expected O, but got Ref
			//IL_0737: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
			//IL_083e: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_07fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0827: Unknown result type (might be due to invalid IL or missing references)
			//IL_0831: Expected I4, but got Unknown
			//IL_100c: Unknown result type (might be due to invalid IL or missing references)
			//IL_101d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e0: Expected O, but got I4
			//IL_08fa: Expected O, but got I4
			//IL_0e7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e83: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_025e: Expected native int or pointer, but got O
			//IL_0e46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef0: Expected native int or pointer, but got O
			//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f45: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f03: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e58: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_1631: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_051d: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0585: Expected O, but got Ref
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Unknown result type (might be due to invalid IL or missing references)
			//IL_1877->IL1836: Incompatible stack heights: 3 vs 1
			//IL_15ca->IL151f: Incompatible stack heights: 2 vs 1
			//IL_1882->IL1836: Incompatible stack heights: 3 vs 1
			//IL_15d5->IL151f: Incompatible stack heights: 2 vs 1
			//IL_15f2->IL151f: Incompatible stack heights: 3 vs 1
			//IL_18f2->IL0008: Incompatible stack heights: 3 vs 1
			//IL_15fd->IL151f: Incompatible stack heights: 3 vs 1
			//IL_1033->IL05cc: Incompatible stack heights: 2 vs 1
			//IL_103e->IL05cc: Incompatible stack heights: 2 vs 1
			//IL_0904->IL05cc: Incompatible stack heights: 2 vs 1
			//IL_026d->IL01fd: Incompatible stack heights: 2 vs 1
			//IL_0eff->IL0c27: Incompatible stack heights: 2 vs 1
			//IL_0f19->IL0c2f: Incompatible stack heights: 2 vs 1
			//IL_0f24->IL0c2f: Incompatible stack heights: 2 vs 1
			//IL_0511->IL02fd: Incompatible stack heights: 2 vs 1
			//IL_051c->IL02fd: Incompatible stack heights: 2 vs 1
			int num3 = default;
			int num5 = default;
			int num8 = default;
			int num11 = default;
			int num13 = default;
			ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<HttpResponseMessage> val = default;
			hWtPOFXACgnCfI2g7TyK hWtPOFXACgnCfI2g7TyK2 = default;
			HttpResponseMessage response_5__ = default;
			ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter _u__3 = default;
			int num23 = default;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default;
			ValueTaskAwaiter _u__4 = default;
			object obj3 = default;
			Stream stream_5__ = default;
			ConfiguredTaskAwaitable<Stream> val2 = default;
			int num22 = default;
			long? num20 = default;
			global::System.Threading.Tasks.ValueTask valueTask2 = default;
			int num16 = default;
			ConfiguredValueTaskAwaitable<int> _u__2 = default;
			int num17 = default;
			ConfiguredValueTaskAwaitable<int> val3 = default;
			global::System.Threading.Tasks.ValueTask<int> valueTask = default;
			int num19 = default;
			int num25 = default;
			int num27 = default;
			int num36 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num28);
			int num29 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num31 = default;
			int num33 = default;
			int num38 = default;
			int num40 = default;
			while (true)
			{
				int num = 2;
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
								goto case 2;
							}
							return;
						case 0:
							try
							{
								int num4;
								if ((uint)num3 > 3u)
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
									{
										num4 = 1;
									}
									goto IL_0084;
								}
								goto IL_1749;
								IL_1749:
								num5 = 17;
								goto IL_0080;
								IL_0080:
								num4 = num5;
								goto IL_0084;
								IL_0084:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 != 17)
										{
											if (num5 == 997)
											{
												goto IL_0080;
											}
											goto case 0;
										}
										try
										{
											int num6;
											if ((uint)num3 > 3u)
											{
												num6 = 2;
												goto IL_016c;
											}
											goto IL_01a2;
											IL_01a2:
											num6 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
											{
												num6 = 3;
											}
											goto IL_016c;
											IL_016c:
											while (true)
											{
												switch (num6)
												{
												default:
													switch (num8)
													{
													case 991:
														break;
													default:
														goto end_IL_016c;
													case 11:
														_buffer_5__4 = null;
														num6 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
														{
															num6 = 4;
														}
														continue;
													}
													goto IL_0168;
												case 0:
													break;
												case 3:
													try
													{
														int num9;
														if ((uint)num3 > 3u)
														{
															num9 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
															{
																num9 = 2;
															}
															goto IL_01fd;
														}
														goto IL_026d;
														IL_026d:
														int num10 = 13;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
														{
															num10 = 5;
														}
														num11 = num10;
														goto IL_01f9;
														IL_01f9:
														num9 = num11;
														goto IL_01fd;
														IL_01fd:
														while (true)
														{
															switch (num9)
															{
															default:
																if (num11 != 13)
																{
																	if (num11 == 993)
																	{
																		goto IL_01f9;
																	}
																	goto case 2;
																}
																try
																{
																	int num12;
																	if (num3 != 0)
																	{
																		num12 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
																		{
																			num12 = 3;
																		}
																		goto IL_02fd;
																	}
																	goto IL_04bf;
																	IL_02f9:
																	num12 = num13;
																	goto IL_02fd;
																	IL_04bf:
																	_u__ = __u__1;
																	num13 = 25;
																	goto IL_02f9;
																	IL_02fd:
																	while (true)
																	{
																		switch (num12)
																		{
																		case 7:
																			((_request_5__5).Headers).TryAddWithoutValidation("Accept", "application/json");
																			num12 = 10;
																			continue;
																		case 15:
																			if (&_u__ != null)
																			{
																				num12 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
																				{
																					num12 = 17;
																				}
																				continue;
																			}
																			goto IL_043b;
																		case 0:
																			_u__ = val;
																			num12 = 25;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
																			{
																				num12 = 15;
																			}
																			continue;
																		case 9:
																			goto IL_043b;
																		case 13:
																			((_request_5__5).Headers).TryAddWithoutValidation("User-Agent", "com.netease.x19/840287970 NeteaseMobileGame/a5.16.0 (22081212C;33)");
																			num12 = 7;
																			continue;
																		case 12:
																			num3 = (__1__state = -1);
																			num12 = 5;
																			continue;
																		case 8:
																			goto end_IL_02fd;
																		case 10:
																			(hWtPOFXACgnCfI2g7TyK2.kNNXAr1bbvw).SendAsync(_request_5__5, (HttpCompletionOption)1, (_timeout_5__3).Token);
																			val = (ConfiguredTaskAwaitable<HttpResponseMessage>)0;
																			_ = 10;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
																			{
																				_ = 0;
																			}
																			continue;
																		case 4:
																			__u__1 = _u__;
																			num12 = 20;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
																			{
																				num12 = 16;
																			}
																			continue;
																		case 14:
																			_response_5__6 = response_5__;
																			num12 = 6;
																			continue;
																		case 5:
																		case 17:
																			response_5__ = (HttpResponseMessage)(object)(&_u__);
																			num12 = 14;
																			continue;
																		case 6:
																			num12 = 11;
																			continue;
																		case 11:
																			try
																			{
																				int num14;
																				switch (num3)
																				{
																				default:
																					num14 = 14;
																					goto IL_05cc;
																				case 1:
																					_u__3 = __u__2;
																					num14 = 48;
																					goto IL_05cc;
																				case 2:
																					goto IL_0a9d;
																				case 3:
																					goto IL_0b44;
																					IL_05cc:
																					while (true)
																					{
																						object obj;
																						int num21;
																						switch (num14)
																						{
																						default:
																							if (num23 != 58)
																							{
																								if (num23 == 1038)
																								{
																									goto IL_05c8;
																								}
																								goto case 22;
																							}
																							_ = 17;
																							defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
																							_ = 46;
																							continue;
																						case 36:
																						case 47:
																							(_u__4).GetResult();
																							num14 = 49;
																							continue;
																						case 8:
																							if (obj3 == null)
																							{
																								num14 = 28;
																								continue;
																							}
																							goto IL_10d0;
																						case 48:
																							__u__2 = default;
																							num14 = 38;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
																							{
																								num14 = 19;
																							}
																							continue;
																						case 5:
																							__u__4 = _u__4;
																							num14 = 24;
																							continue;
																						case 9:
																							return;
																						case 16:
																							__u__4 = default;
																							num14 = 49;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
																							{
																								num14 = 31;
																							}
																							continue;
																						case 35:
																							if (&_u__3 == null)
																							{
																								num14 = 11;
																								continue;
																							}
																							goto case 7;
																						case 19:
																							num3 = (__1__state = -1);
																							num14 = 11;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
																							{
																								num14 = 7;
																							}
																							continue;
																						case 24:
																							__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _IssueAsync_d__5_1>(ref _u__4, ref this);
																							num14 = 0;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
																							{
																								num14 = 29;
																							}
																							continue;
																						case 14:
																						{
																							HttpRequestMessage obj4 = (_response_5__6).RequestMessage;
																							if (obj4 == null)
																							{
																								num14 = 45;
																								continue;
																							}
																							obj = (obj4).RequestUri;
																							goto IL_10b2;
																						}
																						case 7:
																							stream_5__ = (Stream)(object)(&_u__3);
																							num14 = 17;
																							continue;
																						case 33:
																							break;
																						case 20:
																							num3 = (__1__state = 3);
																							num14 = 5;
																							continue;
																						case 37:
																							defaultInterpolatedStringHandler.AppendFormatted<int>((int)(_response_5__6).StatusCode);
																							num14 = 13;
																							continue;
																						case 32:
																							_u__3 = val2;
																							num14 = 11;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
																							{
																								num14 = 35;
																							}
																							continue;
																						case 12:
																							__7__wrap8 = null;
																							num14 = 41;
																							continue;
																						case 10:
																						{
																							CMd6QIXAPC7C8Vv5kluF cMd6QIXAPC7C8Vv5kluF = __7__wrap10;
																							num21 = 15;
																							goto IL_05c4;
																						}
																						case 29:
																							if (num22 == 1)
																							{
																								num14 = 54;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
																								{
																									num14 = 10;
																								}
																								continue;
																							}
																							goto case 22;
																						case 15:
																							goto end_IL_059f;
																						case 17:
																							_stream_5__7 = stream_5__;
																							num14 = 58;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
																							{
																								num14 = 12;
																							}
																							continue;
																						case 46:
																							(defaultInterpolatedStringHandler).AppendLiteral("原生用户票据签发失败（HTTP ");
																							num14 = 37;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
																							{
																								num14 = 10;
																							}
																							continue;
																						case 1:
																							if (&num20 != null)
																							{
																								num14 = 6;
																								continue;
																							}
																							goto IL_09d3;
																						case 22:
																							__7__wrap8 = null;
																							num21 = 2;
																							goto IL_05c4;
																						case 40:
																							__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<Stream>.ConfiguredTaskAwaiter, _IssueAsync_d__5_1>(ref _u__3, ref this);
																							num14 = 6;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
																							{
																								num14 = 9;
																							}
																							continue;
																						case 23:
																							if ((_u__4).IsCompleted)
																							{
																								num21 = 36;
																								goto IL_05c4;
																							}
																							goto case 20;
																						case 42:
																							throw new global::System.Exception("原生票据响应超过大小限制");
																						case 4:
																							throw new global::System.Exception("原生票据请求地址发生变化，已停止接收凭据");
																						case 38:
																							if (!(_response_5__6).IsSuccessStatusCode)
																							{
																								num21 = 58;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
																								{
																									num21 = 47;
																								}
																								goto IL_05c4;
																							}
																							num20 = (((_response_5__6).Content).Headers).ContentLength;
																							num14 = 45;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
																							{
																								num14 = 1;
																							}
																							continue;
																						case 11:
																							num3 = (__1__state = 1);
																							num14 = 18;
																							continue;
																						case 31:
																							num3 = (__1__state = -1);
																							num14 = 47;
																							continue;
																						case 3:
																							_u__4 = (valueTask2).GetAwaiter();
																							num21 = 23;
																							goto IL_05c4;
																						case 21:
																							valueTask2 = (_stream_5__7).DisposeAsync();
																							num21 = 3;
																							goto IL_05c4;
																						case 27:
																							goto IL_0a9d;
																						case 0:
																							return;
																						case 28:
																						case 30:
																							num22 = __7__wrap9;
																							num14 = 23;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
																							{
																								num14 = 29;
																							}
																							continue;
																						case 6:
																							if ((long)(&num20) > 16384L)
																							{
																								num14 = 42;
																								continue;
																							}
																							goto IL_09d3;
																						case 50:
																							if (_stream_5__7 != null)
																							{
																								num14 = 21;
																								continue;
																							}
																							goto case 49;
																						case 25:
																							goto IL_0b44;
																						case 18:
																							__u__2 = _u__3;
																							num14 = 40;
																							continue;
																						case 2:
																							__7__wrap10 = null;
																							num14 = 34;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
																							{
																								num14 = 34;
																							}
																							continue;
																						case 49:
																							obj3 = __7__wrap8;
																							num14 = 8;
																							continue;
																						case 13:
																							(defaultInterpolatedStringHandler).AppendLiteral("）");
																							num14 = 56;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
																							{
																								num14 = 26;
																							}
																							continue;
																						case 39:
																							try
																							{
																								int num15;
																								if (num3 != 2)
																								{
																									num15 = 7;
																									goto IL_0c2f;
																								}
																								goto IL_0e7d;
																								IL_0c2b:
																								num15 = num16;
																								goto IL_0c2f;
																								IL_0c2f:
																								while (true)
																								{
																									switch (num15)
																									{
																									case 1:
																										num3 = (__1__state = 2);
																										num15 = 5;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																										{
																											num15 = 0;
																										}
																										continue;
																									case 10:
																										if (&_u__2 == null)
																										{
																											num15 = 26;
																											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
																											{
																												num15 = 1;
																											}
																											continue;
																										}
																										goto case 14;
																									case 17:
																										goto IL_0cf1;
																									case 12:
																										__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter, _IssueAsync_d__5_1>(ref _u__2, ref this);
																										num15 = 15;
																										continue;
																									case 8:
																										throw new global::System.Exception("原生票据响应超过大小限制");
																									case 16:
																										goto IL_0d6c;
																									case 7:
																										_length_5__8 = 0;
																										num15 = 16;
																										continue;
																									case 18:
																										num3 = (__1__state = -1);
																										num15 = 14;
																										continue;
																									case 4:
																										__7__wrap9 = 1;
																										num15 = 13;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
																										{
																											num15 = 7;
																										}
																										continue;
																									case 2:
																										_length_5__8 += num17;
																										num15 = 6;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
																										{
																											num15 = 11;
																										}
																										continue;
																									case 0:
																										_u__2 = val3;
																										num15 = 10;
																										continue;
																									case 9:
																										goto end_IL_0c2f;
																									case 11:
																										goto IL_0e8f;
																									case 3:
																										goto IL_0ea9;
																									case 6:
																										_ = valueTask;
																										val3 = (ConfiguredValueTaskAwaitable<int>)0;
																										_ = 0;
																										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
																										{
																											_ = 8;
																										}
																										continue;
																									case 15:
																										return;
																									case 14:
																										num17 = (int)(&_u__2);
																										num15 = 17;
																										continue;
																									case 5:
																										__u__3 = _u__2;
																										num15 = 12;
																										continue;
																									case 13:
																										goto end_IL_0c0b;
																									}
																									if (num16 != 26)
																									{
																										if (num16 == 1006)
																										{
																											goto IL_0c2b;
																										}
																										goto IL_0e8f;
																									}
																									__u__3 = default;
																									num15 = 3;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
																									{
																										num15 = 18;
																									}
																									continue;
																									IL_0cf1:
																									if (num17 != 0)
																									{
																										num15 = 2;
																										continue;
																									}
																									(cancellationToken).ThrowIfCancellationRequested();
																									num15 = 3;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
																									{
																										num15 = 0;
																									}
																									continue;
																									IL_0d6c:
																									valueTask = (_stream_5__7).ReadAsync(MemoryExtensions.AsMemory<byte>(_buffer_5__4, _length_5__8, 16385 - _length_5__8), (_timeout_5__3).Token);
																									num15 = 6;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
																									{
																										num15 = 10;
																									}
																									continue;
																									IL_0e8f:
																									if (_length_5__8 > 16384)
																									{
																										num15 = 8;
																										continue;
																									}
																									goto IL_0d6c;
																									continue;
																									end_IL_0c2f:
																									break;
																								}
																								goto IL_0e7d;
																								IL_0ea9:
																								global::System.Runtime.CompilerServices.Unsafe.Write(&((_IssueAsync_d__5_1*)(nint)MemoryExtensions.AsMemory<byte>(_buffer_5__4, 0, _length_5__8))->__7__wrap10, CMd6QIXAPC7C8Vv5kluF.oi7XAFGpqHk((ReadOnlyMemory<byte>)context, _form_5__2, "token"));
																								_ = 4;
																								goto IL_0c27;
																								IL_0c27:
																								num16 = 26;
																								goto IL_0c2b;
																								IL_0e7d:
																								_u__2 = __u__3;
																								goto IL_0c27;
																								end_IL_0c0b:;
																							}
																							catch (object obj2)
																							{
																								obj3 = obj2;
																								int num18 = 0;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
																								{
																									num18 = 5;
																								}
																								while (true)
																								{
																									switch (num18)
																									{
																									default:
																										if (num19 == 989)
																										{
																											num18 = num19;
																											continue;
																										}
																										break;
																									case 0:
																										break;
																									case 1:
																										goto end_IL_0f8c;
																									}
																									__7__wrap8 = obj3;
																									num18 = 4;
																									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
																									{
																										num18 = 1;
																									}
																									continue;
																									end_IL_0f8c:
																									break;
																								}
																							}
																							goto case 50;
																						case 43:
																							((_response_5__6).Content).ReadAsStreamAsync((_timeout_5__3).Token);
																							val2 = (ConfiguredTaskAwaitable<Stream>)0;
																							_ = 57;
																							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																							{
																								_ = 32;
																							}
																							continue;
																						case 26:
																							throw (defaultInterpolatedStringHandler).ToStringAndClear();
																						case 41:
																							__7__wrap9 = 0;
																							num14 = 27;
																							continue;
																						case 45:
																							obj = null;
																							goto IL_10b2;
																						case 44:
																							goto IL_10d0;
																						case 34:
																							goto end_IL_02c5;
																							IL_10b2:
																							if (!((Uri)obj != (Uri)DR7lSHXAmxCoFcuPoiOR.tpAXABRAxml))
																							{
																								num14 = 38;
																								continue;
																							}
																							goto case 4;
																							IL_05c4:
																							num23 = num21;
																							goto IL_05c8;
																							IL_09d3:
																							_buffer_5__4 = (byte[])16385;
																							num21 = 43;
																							goto IL_05c4;
																							IL_05c8:
																							num14 = num23;
																							continue;
																						}
																						break;
																						IL_10d0:
																						(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj3 as global::System.Exception) ?? throw obj3)).Throw();
																						num14 = 30;
																						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
																						{
																							num14 = 49;
																						}
																					}
																					goto case 1;
																					IL_0b44:
																					_u__4 = __u__4;
																					num14 = 16;
																					goto IL_05cc;
																					IL_0a9d:
																					num14 = 39;
																					goto IL_05cc;
																					end_IL_059f:
																					break;
																				}
																			}
																			finally
																			{
																				if (num3 < 0)
																				{
																					int num24 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
																					{
																						num24 = 0;
																					}
																					while (true)
																					{
																						switch (num24)
																						{
																						default:
																							if (num25 == 990)
																							{
																								num24 = num25;
																								continue;
																							}
																							goto case 0;
																						case 0:
																							if (_response_5__6 != null)
																							{
																								num24 = 6;
																								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
																								{
																									num24 = 1;
																								}
																								continue;
																							}
																							break;
																						case 1:
																							(_response_5__6).Dispose();
																							num24 = 2;
																							continue;
																						case 2:
																							break;
																						}
																						break;
																					}
																				}
																			}
																			goto end_IL_004b;
																		case 16:
																			__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter, _IssueAsync_d__5_1>(ref _u__, ref this);
																			num12 = 2;
																			continue;
																		case 3:
																			if ((uint)(num3 - 1) > 2u)
																			{
																				num12 = 13;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
																				{
																					num12 = 21;
																				}
																				continue;
																			}
																			goto case 6;
																		case 2:
																			return;
																		case 1:
																			goto end_IL_02c5;
																		}
																		if (num13 != 25)
																		{
																			if (num13 == 1005)
																			{
																				goto IL_02f9;
																			}
																			goto IL_043b;
																		}
																		__u__1 = default;
																		num12 = 11;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
																		{
																			num12 = 12;
																		}
																		continue;
																		IL_043b:
																		num3 = (__1__state = 0);
																		num12 = 4;
																		continue;
																		end_IL_02fd:
																		break;
																	}
																	goto IL_04bf;
																	end_IL_02c5:;
																}
																finally
																{
																	if (num3 < 0)
																	{
																		int num26 = 2;
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
																				break;
																			case 2:
																				if (_request_5__5 == null)
																				{
																					num26 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
																					{
																						num26 = 3;
																					}
																					continue;
																				}
																				break;
																			case 1:
																				goto end_IL_1257;
																			case 3:
																				break;
																			case 0:
																				goto end_IL_1257;
																			}
																			(_request_5__5).Dispose();
																			num26 = 1;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
																			{
																				num26 = 0;
																			}
																			continue;
																			end_IL_1257:
																			break;
																		}
																	}
																}
																goto case 0;
															case 2:
															{
																HttpMethod obj5 = System.Net.Http.HttpMethod.Post;
																object tpAXABRAxml = DR7lSHXAmxCoFcuPoiOR.tpAXABRAxml;
																(tpAXABRAxml).Content = (HttpContent)(object)_form_5__2;
																global::System.Runtime.CompilerServices.Unsafe.Write(&((_IssueAsync_d__5_1*)(nint)obj5)->_request_5__5, tpAXABRAxml);
																_ = 5;
																continue;
															}
															case 5:
																break;
															case 4:
																_stream_5__7 = null;
																num9 = 3;
																continue;
															case 0:
																_request_5__5 = null;
																num9 = 13;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
																{
																	num9 = 1;
																}
																continue;
															case 1:
																_response_5__6 = null;
																num9 = 4;
																continue;
															case 3:
																goto end_IL_01c4;
															}
															break;
														}
														goto IL_026d;
														end_IL_01c4:;
													}
													catch (object obj6) when (((Func<bool>)delegate
													{
														// Could not convert BlockContainer to single expression
														if (!(obj6 is OperationCanceledException))
														{
															num28 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
															{
																num28 = 1;
															}
														}
														else
														{
															num28 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
															{
																num28 = 7;
															}
														}
														while (true)
														{
															switch (num28)
															{
															default:
																if (num29 == 989)
																{
																	goto IL_135b;
																}
																goto case 0;
															case 0:
																result = 0;
																break;
															case 1:
																result = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
																break;
															}
															break;
															IL_135b:
															num28 = num29;
														}
														return (byte)result != 0;
													}).Invoke())
													{
														int num30 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
														{
															num30 = 0;
														}
														while (true)
														{
															switch (num30)
															{
															default:
																if (num31 == 988)
																{
																	goto IL_13eb;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_13eb:
															num30 = num31;
														}
														throw new global::System.Exception("原生用户票据签发超时，不会自动重发");
													}
													catch (HttpRequestException)
													{
														int num32 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
														{
															num32 = 0;
														}
														while (true)
														{
															switch (num32)
															{
															default:
																if (num33 == 988)
																{
																	goto IL_1457;
																}
																break;
															case 0:
																break;
															}
															break;
															IL_1457:
															num32 = num33;
														}
														throw new global::System.Exception("原生用户票据签发网络请求失败，不会自动重发");
													}
													finally
													{
														if (num3 < 0)
														{
															int num34 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
															{
																num34 = 3;
															}
															while (true)
															{
																switch (num34)
																{
																default:
																	switch (num36)
																	{
																	case 991:
																		break;
																	default:
																		goto end_IL_151f;
																	case 11:
																		_ = _buffer_5__4;
																		_ = 0;
																		_ = 2;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
																		{
																			_ = 7;
																		}
																		continue;
																	}
																	goto IL_151b;
																case 1:
																{
																	System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)_buffer_5__4);
																	int num35 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
																	{
																		num35 = 8;
																	}
																	num36 = num35;
																	goto IL_151b;
																}
																case 0:
																	if (_buffer_5__4 != null)
																	{
																		num34 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
																		{
																			num34 = 10;
																		}
																		continue;
																	}
																	break;
																case 3:
																	_ = _form_5__2;
																	_ = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
																	{
																		_ = 2;
																	}
																	continue;
																case 2:
																	break;
																	IL_151b:
																	num34 = num36;
																	continue;
																	end_IL_151f:
																	break;
																}
																break;
															}
														}
													}
													goto end_IL_016c;
												case 2:
												{
													(_timeout_5__3).CancelAfter(System.TimeSpan.FromSeconds(15.0));
													int num7 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
													{
														num7 = 11;
													}
													num8 = num7;
													goto IL_0168;
												}
												case 1:
													goto end_IL_016c;
													IL_0168:
													num6 = num8;
													continue;
												}
												goto IL_01a2;
												continue;
												end_IL_016c:
												break;
											}
										}
										finally
										{
											if (num3 < 0)
											{
												int num37 = 3;
												while (true)
												{
													switch (num37)
													{
													default:
														if (num38 == 991)
														{
															num37 = num38;
															continue;
														}
														break;
													case 1:
														break;
													case 2:
														(_timeout_5__3).Dispose();
														num37 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
														{
															num37 = 0;
														}
														continue;
													case 3:
														if (_timeout_5__3 == null)
														{
															num37 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
															{
																num37 = 6;
															}
															continue;
														}
														goto case 2;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto case 3;
									case 6:
										_timeout_5__3 = null;
										num4 = 8;
										continue;
									case 4:
										_timeout_5__3 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
										num4 = 9;
										continue;
									case 5:
										context.iAVXAHV6MAL();
										num4 = 7;
										continue;
									case 7:
										(cancellationToken).ThrowIfCancellationRequested();
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
										{
											num4 = 16;
										}
										continue;
									case 9:
										break;
									case 0:
										_form_5__2 = DR7lSHXAmxCoFcuPoiOR.fmsXAATRQ9S(sauthWrapper, context.SdkUid);
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num4 = 10;
										}
										continue;
									case 3:
										_form_5__2 = null;
										num4 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
										{
											num4 = 6;
										}
										continue;
									case 1:
										System.ArgumentNullException.ThrowIfNull(context, "context");
										num4 = 5;
										continue;
									case 8:
										_buffer_5__4 = null;
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
										{
											num4 = 2;
										}
										continue;
									case 2:
										throw null;
									}
									break;
								}
								goto IL_1749;
								end_IL_004b:;
							}
							catch (global::System.Exception)
							{
								int num39 = 2;
								while (true)
								{
									switch (num39)
									{
									default:
										if (num40 == 990)
										{
											num39 = num40;
											break;
										}
										return;
									case 0:
										_ = __t__builder;
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
										{
											_ = 7;
										}
										break;
									case 2:
										__1__state = -2;
										num39 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num39 = 1;
										}
										break;
									case 1:
										return;
									}
								}
							}
							goto case 4;
						case 1:
							hWtPOFXACgnCfI2g7TyK2 = __4__this;
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
							{
								num2 = 8;
							}
							continue;
						case 3:
							break;
						case 4:
							__1__state = -2;
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
							{
								num2 = 10;
							}
							continue;
						case 2:
							num3 = __1__state;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								num2 = 5;
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
				_ = __t__builder;
				_ = 11;
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
						default:
							if (num2 != 9)
							{
								if (num2 == 990)
								{
									goto end_IL_0012;
								}
								goto case 2;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							break;
						case 2:
							num3 = 1;
							continue;
						case 0:
							return;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
				{
					num = 1;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TFoFwJ9a0gs4mhj8GK24()
		{
			return Aff2EW9acAMZvE87D9Zh == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object GOqS4v9a8as3HXPRAY81()
		{
			return Aff2EW9acAMZvE87D9Zh;
		}
	}

	private readonly object kNNXAr1bbvw;

	private readonly bool IW0XAoNLm63;

	private static object PaWKQlZOXhV3y45YMtOg;

	[MethodImpl((MethodImplOptions)8)]
	internal hWtPOFXACgnCfI2g7TyK()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal hWtPOFXACgnCfI2g7TyK(HttpClient http, bool ownsHttp = false)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<CMd6QIXAPC7C8Vv5kluF> iiNXAhTVxF7(string sauthWrapper, W8UV04XAdpTXOmgNYBMi context, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 2;
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
					goto case 1;
				case 2:
					if (IW0XAoNLm63)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
						{
							num2 = 3;
						}
						break;
					}
					return;
				case 1:
					(kNNXAr1bbvw).Dispose();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
					{
						num2 = 7;
					}
					break;
				case 0:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						break;
					case 0:
						return;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
						{
							num3 = 3;
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
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HhusjkZOfufJBPW2bZ6y()
	{
		return PaWKQlZOXhV3y45YMtOg == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static hWtPOFXACgnCfI2g7TyK sfZsfnZOLcGuoJ2A59CA()
	{
		return (hWtPOFXACgnCfI2g7TyK)PaWKQlZOXhV3y45YMtOg;
	}
}

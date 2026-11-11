using System;
using System.Diagnostics;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using SpQIuLJeVWOnaaf62nJ;
using fDAldojjppXrctUVYOJn;
using jayVXsfeU04hSNk3ePPo;
using rpAOHpBy1Ss2rabyYHw;

namespace rt6nJFOgpDacgmTF8Ih;

public sealed class PrFs4fOBwUvdAORC617
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadRemoteTextAsync_d__10 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<string> __t__builder;

		public Uri uri;

		public CancellationToken cancellationToken;

		private HttpRequestMessage _request_5__2;

		private HttpResponseMessage _response_5__3;

		private Stream _stream_5__4;

		private byte[] _buffer_5__5;

		private int _totalRead_5__6;

		private TaskAwaiter<HttpResponseMessage> __u__1;

		private TaskAwaiter<Stream> __u__2;

		private object __7__wrap6;

		private int __7__wrap7;

		private string __7__wrap8;

		private ValueTaskAwaiter<int> __u__3;

		private ValueTaskAwaiter __u__4;

		internal static object MF5TjP9mX6KBfW3yJmf1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af0: Expected O, but got Ref
			//IL_0ada: Unknown result type (might be due to invalid IL or missing references)
			//IL_0adc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a3e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bf8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0665: Unknown result type (might be due to invalid IL or missing references)
			//IL_066a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ff3: Expected native int or pointer, but got O
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_08cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0748: Expected O, but got I4
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Expected O, but got Ref
			//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0db9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_10c5->IL1072: Incompatible stack heights: 3 vs 1
			//IL_10d0->IL1072: Incompatible stack heights: 3 vs 1
			//IL_10fc->IL0010: Incompatible stack heights: 3 vs 1
			//IL_1107->IL0010: Incompatible stack heights: 3 vs 1
			//IL_100c->IL00a8: Incompatible stack heights: 2 vs 1
			//IL_1017->IL00a8: Incompatible stack heights: 2 vs 1
			//IL_0774->IL0533: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			int num6 = default;
			int num9 = default;
			HttpResponseMessage response_5__ = default;
			TaskAwaiter<HttpResponseMessage> _u__ = default;
			int num14 = default;
			ValueTaskAwaiter _u__2 = default;
			TaskAwaiter<Stream> _u__3 = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			long? num15 = default;
			int num12 = default;
			object obj = default;
			int num19 = default;
			ValueTaskAwaiter<int> _u__4 = default;
			global::System.Threading.Tasks.ValueTask<int> valueTask2 = default;
			int num17 = default;
			string text2 = default;
			int num21 = default;
			Stream stream_5__ = default;
			int num23 = default;
			int num25 = default;
			int num27 = default;
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
							if (num2 == 10)
							{
								_ = __t__builder;
								_ = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
								{
									_ = 5;
								}
								continue;
							}
							goto end_IL_0010;
						case 1:
							num4 = __1__state;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
							{
								num3 = 1;
							}
							continue;
						case 3:
							return;
						case 0:
							try
							{
								int num5;
								if ((uint)num4 > 3u)
								{
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
									{
										num5 = 2;
									}
									goto IL_00a8;
								}
								goto IL_0110;
								IL_00a8:
								while (true)
								{
									int num7;
									switch (num5)
									{
									default:
										if (num6 != 14)
										{
											if (num6 == 994)
											{
												goto IL_00a4;
											}
											goto case 6;
										}
										_response_5__3 = null;
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										_request_5__2 = null;
										num7 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num7 = 9;
										}
										goto IL_00a0;
									case 1:
										break;
									case 3:
										try
										{
											int num8;
											if (num4 != 0)
											{
												num8 = 3;
												goto IL_0154;
											}
											goto IL_01b6;
											IL_014c:
											int num10;
											num9 = num10;
											goto IL_0150;
											IL_0154:
											while (true)
											{
												switch (num8)
												{
												case 13:
													return;
												case 0:
													goto end_IL_0154;
												case 2:
												case 4:
													response_5__ = (HttpResponseMessage)(object)(&_u__);
													num8 = 5;
													continue;
												case 5:
													_response_5__3 = response_5__;
													num8 = 8;
													continue;
												case 9:
													try
													{
														int num11;
														switch (num4)
														{
														default:
															num11 = 39;
															goto IL_021b;
														case 1:
															goto IL_03a8;
														case 2:
															goto IL_044d;
														case 3:
															goto IL_0a4d;
															IL_021b:
															while (true)
															{
																switch (num11)
																{
																case 25:
																	return;
																case 37:
																	return;
																default:
																	if (num14 != 51)
																	{
																		if (num14 == 1031)
																		{
																			goto IL_0217;
																		}
																		goto case 2;
																	}
																	__7__wrap7 = 0;
																	num11 = 13;
																	continue;
																case 4:
																	if ((_u__2).IsCompleted)
																	{
																		num11 = 14;
																		continue;
																	}
																	goto case 36;
																case 12:
																	break;
																case 21:
																	num4 = (__1__state = -1);
																	num11 = 24;
																	continue;
																case 15:
																	__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Stream>, _ReadRemoteTextAsync_d__10>(ref _u__3, ref this);
																	num11 = 37;
																	continue;
																case 10:
																	num4 = (__1__state = -1);
																	num11 = 33;
																	continue;
																case 16:
																	_u__2 = (valueTask).GetAwaiter();
																	num11 = 10;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
																	{
																		num11 = 4;
																	}
																	continue;
																case 6:
																	goto IL_03a8;
																case 30:
																	if (_stream_5__4 == null)
																	{
																		num11 = 7;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
																		{
																			num11 = 51;
																		}
																		continue;
																	}
																	goto case 26;
																case 9:
																	num15 = (((_response_5__3).Content).Headers).ContentLength;
																	num11 = 48;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
																	{
																		num11 = 42;
																	}
																	continue;
																case 13:
																	goto IL_044d;
																case 36:
																	num4 = (__1__state = 3);
																	num11 = 41;
																	continue;
																case 22:
																	num12 = __7__wrap7;
																	num11 = 18;
																	continue;
																case 8:
																	if ((long)(&num15) <= 1024L)
																	{
																		num11 = 34;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																		{
																			num11 = 34;
																		}
																		continue;
																	}
																	goto case 19;
																case 7:
																case 35:
																	obj = __7__wrap6;
																	num11 = 32;
																	continue;
																case 42:
																	if (&num15 != null)
																	{
																		num11 = 36;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
																		{
																			num11 = 8;
																		}
																		continue;
																	}
																	goto case 34;
																case 0:
																	try
																	{
																		int num16;
																		if (num4 != 2)
																		{
																			num16 = 16;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
																			{
																				num16 = 6;
																			}
																			goto IL_0533;
																		}
																		goto IL_0664;
																		IL_0533:
																		while (true)
																		{
																			int num18;
																			switch (num16)
																			{
																			case 12:
																				return;
																			default:
																				if (num19 != 32)
																				{
																					if (num19 == 1012)
																					{
																						goto IL_052f;
																					}
																					goto case 9;
																				}
																				__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<int>, _ReadRemoteTextAsync_d__10>(ref _u__4, ref this);
																				num16 = 12;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
																				{
																					num16 = 3;
																				}
																				continue;
																			case 5:
																				_u__4 = valueTask2;
																				num16 = 8;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
																				{
																					num16 = 28;
																				}
																				continue;
																			case 23:
																				__u__3 = default;
																				num18 = 9;
																				goto IL_052b;
																			case 13:
																				__7__wrap7 = 1;
																				num16 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
																				{
																					num16 = 1;
																				}
																				continue;
																			case 4:
																			case 11:
																				num17 = (int)(&_u__4);
																				num16 = 14;
																				continue;
																			case 16:
																				num4 = (__1__state = 2);
																				num16 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
																				{
																					num16 = 14;
																				}
																				continue;
																			case 15:
																				break;
																			case 3:
																				if (_totalRead_5__6 > 1024)
																				{
																					num16 = 22;
																					continue;
																				}
																				goto case 0;
																			case 17:
																				__7__wrap8 = text2;
																				num16 = 29;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																				{
																					num16 = 13;
																				}
																				continue;
																			case 2:
																				_totalRead_5__6 = 0;
																				num16 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
																				{
																					num16 = 31;
																				}
																				continue;
																			case 18:
																			case 20:
																				_ = 0;
																				text2 = oU4OOvwHk4((1).GetString(_buffer_5__5, 0, _totalRead_5__6), "更新服务器响应");
																				_ = 19;
																				continue;
																			case 21:
																			case 24:
																				valueTask2 = (_stream_5__4).ReadAsync(MemoryExtensions.AsMemory<byte>(_buffer_5__5, _totalRead_5__6, _buffer_5__5.Length - _totalRead_5__6), cancellationToken);
																				num16 = 32;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
																				{
																					num16 = 5;
																				}
																				continue;
																			case 9:
																				num4 = (__1__state = -1);
																				num16 = 11;
																				continue;
																			case 19:
																				agV9GMJwpmu5p5m3IxF.kp3JPC1oWW("update-discovery", text2);
																				num16 = 32;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
																				{
																					num16 = 17;
																				}
																				continue;
																			case 8:
																				if (&_u__4 != null)
																				{
																					num16 = 4;
																					continue;
																				}
																				goto case 16;
																			case 6:
																				_buffer_5__5 = new byte[1025];
																				num16 = 2;
																				continue;
																			case 10:
																				_totalRead_5__6 += num17;
																				num16 = 3;
																				continue;
																			case 22:
																				throw new global::System.Exception("更新服务器返回的数据过大。");
																			case 0:
																				if (_totalRead_5__6 < _buffer_5__5.Length)
																				{
																					num16 = 21;
																					continue;
																				}
																				goto case 18;
																			case 7:
																				__u__3 = _u__4;
																				num18 = 10;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
																				{
																					num18 = 32;
																				}
																				goto IL_052b;
																			case 14:
																				if (num17 == 0)
																				{
																					num16 = 20;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
																					{
																						num16 = 16;
																					}
																					continue;
																				}
																				goto case 10;
																			case 1:
																				goto end_IL_0533;
																				IL_052f:
																				num16 = num19;
																				continue;
																				IL_052b:
																				num19 = num18;
																				goto IL_052f;
																			}
																			goto IL_0664;
																			continue;
																			end_IL_0533:
																			break;
																		}
																		goto end_IL_04fa;
																		IL_0664:
																		_u__4 = __u__3;
																		num16 = 23;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																		{
																			num16 = 1;
																		}
																		goto IL_0533;
																		end_IL_04fa:;
																	}
																	catch (object obj2)
																	{
																		obj = obj2;
																		int num20 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
																		{
																			num20 = 1;
																		}
																		while (true)
																		{
																			switch (num20)
																			{
																			default:
																				if (num21 == 989)
																				{
																					num20 = num21;
																					continue;
																				}
																				break;
																			case 0:
																				__7__wrap6 = obj;
																				num20 = 3;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
																				{
																					num20 = 1;
																				}
																				continue;
																			case 1:
																				break;
																			}
																			break;
																		}
																	}
																	goto case 30;
																case 39:
																	(_response_5__3).EnsureSuccessStatusCode();
																	num11 = 9;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
																	{
																		num11 = 36;
																	}
																	continue;
																case 40:
																	__7__wrap6 = null;
																	num11 = 2;
																	continue;
																case 29:
																	if (&_u__3 != null)
																	{
																		num11 = 20;
																		continue;
																	}
																	goto case 23;
																case 2:
																	__7__wrap8 = null;
																	num11 = 39;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
																	{
																		num11 = 1;
																	}
																	continue;
																case 41:
																	__u__4 = _u__2;
																	num11 = 17;
																	continue;
																case 31:
																	goto IL_0a4d;
																case 3:
																	__u__2 = default;
																	num11 = 21;
																	continue;
																case 5:
																	_stream_5__4 = stream_5__;
																	num11 = 43;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
																	{
																		num11 = 10;
																	}
																	continue;
																case 11:
																	__u__4 = default;
																	num11 = 10;
																	continue;
																case 28:
																{
																	string text = __7__wrap8;
																	num11 = 12;
																	continue;
																}
																case 27:
																	__u__2 = _u__3;
																	num11 = 15;
																	continue;
																case 20:
																case 24:
																	stream_5__ = (Stream)(object)(&_u__3);
																	num11 = 5;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
																	{
																		num11 = 10;
																	}
																	continue;
																case 18:
																	if (num12 == 1)
																	{
																		num11 = 28;
																		continue;
																	}
																	goto case 40;
																case 23:
																	num4 = (__1__state = 1);
																	num11 = 27;
																	continue;
																case 14:
																case 33:
																	(_u__2).GetResult();
																	num11 = 35;
																	continue;
																case 17:
																	__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _ReadRemoteTextAsync_d__10>(ref _u__2, ref this);
																	num11 = 25;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
																	{
																		num11 = 15;
																	}
																	continue;
																case 19:
																	throw new global::System.Exception("更新服务器返回的数据过大。");
																case 34:
																	_u__3 = (TaskAwaiter<Stream>)((_response_5__3).Content).ReadAsStreamAsync(cancellationToken);
																	num11 = 29;
																	continue;
																case 43:
																{
																	__7__wrap6 = null;
																	int num13 = 28;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
																	{
																		num13 = 51;
																	}
																	num14 = num13;
																	goto IL_0217;
																}
																case 26:
																	valueTask = (_stream_5__4).DisposeAsync();
																	num11 = 13;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
																	{
																		num11 = 16;
																	}
																	continue;
																case 32:
																	if (obj != null)
																	{
																		num11 = 40;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
																		{
																			num11 = 38;
																		}
																		continue;
																	}
																	goto case 22;
																case 38:
																	goto IL_0c81;
																case 1:
																	goto end_IL_0131;
																	IL_0217:
																	num11 = num14;
																	continue;
																}
																break;
																IL_0c81:
																(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
																num11 = 22;
															}
															break;
															IL_0a4d:
															_u__2 = __u__4;
															num11 = 11;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
															{
																num11 = 37;
															}
															goto IL_021b;
															IL_03a8:
															_u__3 = __u__2;
															num11 = 3;
															goto IL_021b;
															IL_044d:
															num11 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
															{
																num11 = 44;
															}
															goto IL_021b;
														}
													}
													finally
													{
														int num22;
														if (num4 >= 0)
														{
															num22 = 2;
															goto IL_0cd8;
														}
														goto IL_0d0f;
														IL_0d0f:
														if (_response_5__3 != null)
														{
															num22 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
															{
																num22 = 8;
															}
															goto IL_0cd8;
														}
														goto end_IL_0cb4;
														IL_0cd8:
														while (true)
														{
															switch (num22)
															{
															default:
																if (num23 == 991)
																{
																	num22 = num23;
																	continue;
																}
																goto end_IL_0cd8;
															case 2:
																goto end_IL_0cd8;
															case 3:
																break;
															case 0:
																(_response_5__3).Dispose();
																num22 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																{
																	num22 = 1;
																}
																continue;
															case 1:
																goto end_IL_0cd8;
															}
															goto IL_0d0f;
															continue;
															end_IL_0cd8:
															break;
														}
														end_IL_0cb4:;
													}
													goto end_IL_00a8;
												case 7:
													num4 = (__1__state = -1);
													num8 = 17;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
													{
														num8 = 2;
													}
													continue;
												case 12:
													_u__ = (TaskAwaiter<HttpResponseMessage>)(PZ0OeAfoSK).SendAsync(_request_5__2, (HttpCompletionOption)1, cancellationToken);
													num8 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
													{
														num8 = 12;
													}
													continue;
												case 3:
													goto IL_0de9;
												case 6:
													__u__1 = _u__;
													num8 = 9;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
													{
														num8 = 10;
													}
													continue;
												case 8:
													goto IL_0e4f;
												case 10:
													__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<HttpResponseMessage>, _ReadRemoteTextAsync_d__10>(ref _u__, ref this);
													num8 = 13;
													continue;
												case 11:
													num4 = (__1__state = 0);
													num8 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
													{
														num8 = 16;
													}
													continue;
												case 1:
													if (&_u__ == null)
													{
														goto case 11;
													}
													goto IL_0ec7;
												case 14:
													goto end_IL_0131;
												}
												if (num9 != 22)
												{
													if (num9 == 1002)
													{
														goto IL_0150;
													}
													goto IL_0de9;
												}
												__u__1 = default;
												num8 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
												{
													num8 = 7;
												}
												continue;
												IL_0de9:
												if ((uint)(num4 - 1) > 2u)
												{
													num8 = 12;
													continue;
												}
												goto IL_0e4f;
												IL_0e4f:
												num8 = 9;
												continue;
												end_IL_0154:
												break;
											}
											goto IL_01b6;
											IL_01b6:
											_u__ = __u__1;
											num10 = 22;
											goto IL_014c;
											IL_0150:
											num8 = num9;
											goto IL_0154;
											IL_0ec7:
											num10 = 4;
											goto IL_014c;
											end_IL_0131:;
										}
										finally
										{
											if (num4 < 0)
											{
												int num24 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
												{
													num24 = 4;
												}
												while (true)
												{
													switch (num24)
													{
													default:
														if (num25 == 991)
														{
															num24 = num25;
															continue;
														}
														break;
													case 0:
														(_request_5__2).Dispose();
														num24 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
														{
															num24 = 3;
														}
														continue;
													case 2:
														break;
													case 1:
														if (_request_5__2 == null)
														{
															num24 = 2;
															continue;
														}
														goto case 0;
													case 3:
														break;
													}
													break;
												}
											}
										}
										goto case 2;
									case 0:
										_stream_5__4 = null;
										num7 = 5;
										goto IL_00a0;
									case 5:
										_buffer_5__5 = null;
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
										{
											num5 = 4;
										}
										continue;
									case 6:
										global::System.Runtime.CompilerServices.Unsafe.Write(&((_ReadRemoteTextAsync_d__10*)(nint)System.Net.Http.HttpMethod.Get)->_request_5__2, uri);
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
										{
											_ = 1;
										}
										continue;
									case 4:
										{
											throw null;
										}
										IL_00a4:
										num5 = num6;
										continue;
										IL_00a0:
										num6 = num7;
										goto IL_00a4;
									}
									goto IL_0110;
									continue;
									end_IL_00a8:
									break;
								}
								goto end_IL_006f;
								IL_0110:
								num5 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
								{
									num5 = 4;
								}
								goto IL_00a8;
								end_IL_006f:;
							}
							catch (global::System.Exception)
							{
								int num26 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
								{
									num26 = 0;
								}
								while (true)
								{
									switch (num26)
									{
									case 1:
										return;
									default:
										if (num27 != 990)
										{
											return;
										}
										num26 = num27;
										break;
									case 0:
										__1__state = -2;
										num26 = 2;
										break;
									case 2:
										_ = __t__builder;
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
										{
											_ = 8;
										}
										break;
									}
								}
							}
							break;
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
				while (num2 == 991);
				__1__state = -2;
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
				{
					num = 1;
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
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 2:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
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
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool zOkFaG9mfqLSqt83E338()
		{
			return MF5TjP9mX6KBfW3yJmf1 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Ln4pfH9mLqB1hlVHVn0T()
		{
			return MF5TjP9mX6KBfW3yJmf1;
		}
	}

	internal static readonly object otyOwExuP4;

	private static readonly object PZ0OeAfoSK;

	private static object LB6nmaZQjMnt0iaBmv41;

	private static Uri LatestVersionUri
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return OPkowHB8re070ZB8Cba.Version;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<sJFvIGfehRs7r8TsV0mL> C4SOlc7W07(CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string CfCOdBTIDC()
	{
		return IGrOH9CyVW();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient Py8OKIZe4R()
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string IGrOH9CyVW()
	{
		object obj = ((System.Type.GetTypeFromHandle(typeof(PrFs4fOBwUvdAORC617).TypeHandle)).Assembly).GetManifestResourceStream("Mahiro_Account.Resources.version.txt");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<string> WeFOtsSUtA(object uri, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.uri = (Uri)uri;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string oU4OOvwHk4(object value, object fieldName)
	{
		HttpMethod[] array = new HttpMethod[5];
		System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
		string text = (value).Trim((char[])(object)array);
		if (string.IsNullOrWhiteSpace(text))
		{
			throw string.Concat((string)fieldName, "不能为空。");
		}
		return text;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static Version H8SO5Z4gmT(object value, object fieldName)
	{
		//IL_000c: Expected O, but got I4
		//IL_0035: Expected I4, but got O
		//IL_0187: Expected O, but got I4
		//IL_00c0->IL0010: Incompatible stack types: I4 vs O
		//IL_008f->IL0010: Incompatible stack types: I4 vs O
		//IL_00fa->IL0010: Incompatible stack types: I4 vs O
		//IL_00cb->IL0010: Incompatible stack types: I4 vs O
		//IL_009a->IL0010: Incompatible stack types: I4 vs O
		//IL_01ae->IL0010: Incompatible stack types: I4 vs O
		int num = 5;
		object obj3 = default;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					object obj4;
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 14)
						{
							goto case 2;
						}
						if ((nint)obj == 995)
						{
							goto end_IL_0010;
						}
						goto case 0;
					case 7:
						obj4 = value;
						goto IL_0193;
					case 3:
						if ((obj3).Major >= 0)
						{
							obj2 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 2;
					case 1:
						if ((value).StartsWith('V'))
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
							{
								obj2 = 6;
							}
							continue;
						}
						goto case 7;
					case 5:
						if ((value).StartsWith('v'))
						{
							obj2 = 4;
							continue;
						}
						goto case 1;
					case 6:
						if ((obj3).Minor >= 0)
						{
							(obj3).Major;
							(obj3).Minor;
							System.Math.Max((obj3).Build, 0);
							return (Version)(object)System.Math.Max((obj3).Revision, 0);
						}
						break;
					case 2:
						throw string.Concat((string)fieldName, "格式无效：", (string)value);
					case 0:
					case 4:
						{
							obj4 = (value).Substring(1);
							goto IL_0193;
						}
						IL_0193:
						if (!System.Version.TryParse((string)obj4, ref obj3))
						{
							obj2 = 2;
							continue;
						}
						goto case 3;
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
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public PrFs4fOBwUvdAORC617()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		PZ0OeAfoSK = Py8OKIZe4R();
		_ = 4;
		otyOwExuP4 = "https://www.chronal.my/downloads";
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dmekpxZQZDyPDm8OQNlM()
	{
		return LB6nmaZQjMnt0iaBmv41 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PrFs4fOBwUvdAORC617 eTuQ6jZQ9dawRLRPHsjV()
	{
		return (PrFs4fOBwUvdAORC617)LB6nmaZQjMnt0iaBmv41;
	}
}

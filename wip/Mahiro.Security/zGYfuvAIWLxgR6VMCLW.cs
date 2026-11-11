using System;
using System.Diagnostics;
using System.IO;
using System.IO.Pipes;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using PsXpS654E57g4aJfi0E;
using RyDfSXfPyKj0ty7cSIxY;
using WMO32gy5EZANSQKlHAx;
using fDAldojjppXrctUVYOJn;
using g3HPkXWSXvNYoMl4p7P;

namespace gLLUPnABRuawQrExxRT;

public class zGYfuvAIWLxgR6VMCLW
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _RunServerAsync_d__8 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string pipeName;

		public Func<string, global::System.Threading.Tasks.Task> handler;

		public CancellationToken cancellationToken;

		private object __7__wrap1;

		private int __7__wrap2;

		private NamedPipeServerStream _server_5__4;

		private StreamReader _reader_5__5;

		private TaskAwaiter __u__1;

		private ValueTaskAwaiter<string?> __u__2;

		private static object qjxZx09hhx33qkT1nnUs;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e84: Unknown result type (might be due to invalid IL or missing references)
			//IL_097a: Expected O, but got I4
			//IL_0eaf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e59: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
			//IL_085e: Expected O, but got I4
			//IL_0265: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_07d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0752: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_033b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0340: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0597: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0470: Unknown result type (might be due to invalid IL or missing references)
			//IL_0472: Unknown result type (might be due to invalid IL or missing references)
			//IL_0394: Expected O, but got Ref
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_013a->IL014c: Incompatible stack heights: 1 vs 5
			//IL_0169->IL0965: Incompatible stack heights: 4 vs 0
			//IL_0868->IL01f0: Incompatible stack heights: 9 vs 5
			//IL_086d->IL019b: Incompatible stack heights: 0 vs 4
			//IL_0457->IL02b0: Incompatible stack heights: 6 vs 5
			//IL_062a->IL0868: Incompatible stack heights: 0 vs 4
			int num = 2;
			int num4 = default;
			int num7 = default;
			int num17 = default;
			int num19 = default;
			TaskAwaiter _u__ = default;
			string text = default;
			ValueTaskAwaiter<string> _u__2 = default;
			global::System.Threading.Tasks.ValueTask<string> valueTask = default;
			int num23 = default;
			int num25 = default;
			int num27 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num28);
			int num29 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
			int num31 = default;
			int num33 = default;
			global::System.Exception exception = default;
			int num15 = default;
			int num9 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num11);
			int num12 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num14 = default;
			int num35 = default;
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
								if (num2 == 991)
								{
									goto end_IL_0010;
								}
							}
							else
							{
								try
								{
									int num5;
									if ((uint)num4 > 2u)
									{
										num5 = 14;
										goto IL_0088;
									}
									goto IL_0c5d;
									IL_0c5d:
									int num6 = 5;
									goto IL_0090;
									IL_0088:
									num7 = num5;
									goto IL_008c;
									IL_008c:
									num6 = num7;
									goto IL_0090;
									IL_0090:
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 != 22)
											{
												if (num7 == 1002)
												{
													goto IL_008c;
												}
												goto case 13;
											}
											goto IL_0c68;
										case 6:
											System.ArgumentException.ThrowIfNullOrWhiteSpace(pipeName, "pipeName");
											num6 = 13;
											continue;
										case 5:
											try
											{
												if ((uint)num4 <= 2u)
												{
													_ = 2;
													goto IL_014c;
												}
												goto IL_0965;
												IL_0965:
												_ = pipeName;
												_ = 1;
												_ = 1;
												global::System.Runtime.CompilerServices.Unsafe.Write(&((_RunServerAsync_d__8*)null)->_server_5__4, (object)1610612736);
												int num16 = 9;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
												{
													num16 = 5;
												}
												goto IL_014c;
												IL_014c:
												while (true)
												{
													switch (num16)
													{
													default:
														if (num17 != 13)
														{
															if (num17 == 993)
															{
																goto IL_0148;
															}
														}
														else
														{
															try
															{
																int num18;
																if (num4 == 0)
																{
																	num18 = 11;
																	goto IL_01f0;
																}
																goto IL_0738;
																IL_01e8:
																int num20;
																num19 = num20;
																goto IL_01ec;
																IL_01f0:
																while (true)
																{
																	switch (num18)
																	{
																	case 12:
																		return;
																	case 13:
																		__u__1 = _u__;
																		num18 = 3;
																		continue;
																	case 4:
																	case 11:
																		_u__ = __u__1;
																		num18 = 6;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
																		{
																			num18 = 9;
																		}
																		continue;
																	case 6:
																		num4 = (__1__state = -1);
																		num18 = 8;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
																		{
																			num18 = 1;
																		}
																		continue;
																	case 5:
																		goto IL_0738;
																	case 9:
																		__u__1 = default;
																		num18 = 22;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
																		{
																			num18 = 6;
																		}
																		continue;
																	case 3:
																		goto IL_0786;
																	case 1:
																		(_u__).GetResult();
																		num18 = 21;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
																		{
																			num18 = 0;
																		}
																		continue;
																	case 8:
																		_u__ = ((_server_5__4).WaitForConnectionAsync(cancellationToken)).GetAwaiter();
																		num18 = 7;
																		continue;
																	case 7:
																		if (!(_u__).IsCompleted)
																		{
																			num18 = 14;
																			continue;
																		}
																		goto case 1;
																	case 2:
																		goto IL_0810;
																	case 14:
																		num4 = (__1__state = 0);
																		num18 = 13;
																		continue;
																	case 0:
																		_ = _server_5__4;
																		System.Text.Encoding.UTF8;
																		_ = 0;
																		global::System.Runtime.CompilerServices.Unsafe.Write(&((_RunServerAsync_d__8*)(-1))->_reader_5__5, (object)1);
																		_ = 2;
																		continue;
																	case 10:
																		goto end_IL_01cd;
																	}
																	break;
																}
																if (num19 != 22)
																{
																	if (num19 == 1002)
																	{
																		goto IL_01ec;
																	}
																	goto IL_0810;
																}
																try
																{
																	int num21;
																	if (num4 != 1)
																	{
																		num21 = 6;
																		goto IL_02b0;
																	}
																	goto IL_0426;
																	IL_04e4:
																	int num22;
																	if (num4 != 2)
																	{
																		num22 = 14;
																		goto IL_02a8;
																	}
																	goto IL_033a;
																	IL_02b0:
																	while (true)
																	{
																		switch (num21)
																		{
																		case 3:
																			return;
																		case 21:
																			return;
																		case 2:
																			goto end_IL_02b0;
																		case 23:
																			goto IL_0361;
																		case 0:
																		case 24:
																			text = vKC6uJWY94x4WOB9I3n.B7dWyywd55((string?)(&_u__2));
																			num21 = 8;
																			continue;
																		case 7:
																			_u__2 = valueTask;
																			num21 = 12;
																			continue;
																		case 8:
																			if ((text).Length == 0)
																			{
																				num21 = 11;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
																				{
																					num21 = 12;
																				}
																				continue;
																			}
																			goto case 15;
																		case 20:
																			num4 = (__1__state = -1);
																			num21 = 23;
																			continue;
																		case 5:
																			goto IL_0426;
																		case 15:
																			_ = handler;
																			_u__ = (text).GetAwaiter();
																			_ = 19;
																			continue;
																		case 4:
																			__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunServerAsync_d__8>(ref _u__, ref this);
																			num21 = 3;
																			continue;
																		case 22:
																			__u__1 = _u__;
																			num21 = 4;
																			continue;
																		case 18:
																			__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<string>, _RunServerAsync_d__8>(ref _u__2, ref this);
																			num21 = 21;
																			continue;
																		case 14:
																			valueTask = (_reader_5__5).ReadLineAsync(cancellationToken);
																			num21 = 7;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
																			{
																				num21 = 23;
																			}
																			continue;
																		case 13:
																			num4 = (__1__state = 1);
																			num21 = 9;
																			continue;
																		case 6:
																			goto IL_04e4;
																		case 9:
																			__u__2 = _u__2;
																			num21 = 26;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
																			{
																				num21 = 18;
																			}
																			continue;
																		case 11:
																			goto end_IL_028c;
																		case 1:
																			num4 = (__1__state = 2);
																			num21 = 12;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
																			{
																				num21 = 22;
																			}
																			continue;
																		case 12:
																			if (&_u__2 != null)
																			{
																				num21 = 21;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																				{
																					num21 = 0;
																				}
																				continue;
																			}
																			goto case 13;
																		case 10:
																			__u__2 = default;
																			num21 = 16;
																			continue;
																		case 16:
																			num4 = (__1__state = -1);
																			num21 = 24;
																			continue;
																		case 19:
																			if (!(_u__).IsCompleted)
																			{
																				num21 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
																				{
																					num21 = 25;
																				}
																				continue;
																			}
																			goto IL_0361;
																		case 17:
																			goto end_IL_01cd;
																		}
																		if (num23 != 32)
																		{
																			if (num23 == 1012)
																			{
																				goto IL_02ac;
																			}
																			goto IL_0361;
																		}
																		__u__1 = default;
																		num21 = 19;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
																		{
																			num21 = 20;
																		}
																		continue;
																		IL_0361:
																		(_u__).GetResult();
																		num21 = 17;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
																		{
																			num21 = 15;
																		}
																		continue;
																		end_IL_02b0:
																		break;
																	}
																	goto IL_033a;
																	IL_02a8:
																	num23 = num22;
																	goto IL_02ac;
																	IL_02ac:
																	num21 = num23;
																	goto IL_02b0;
																	IL_033a:
																	_u__ = __u__1;
																	num22 = 32;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
																	{
																		num22 = 10;
																	}
																	goto IL_02a8;
																	IL_0426:
																	_u__2 = __u__2;
																	num22 = 10;
																	goto IL_02a8;
																	end_IL_028c:;
																}
																finally
																{
																	if (num4 < 0)
																	{
																		int num24 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
																		{
																			num24 = 4;
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
																				goto case 2;
																			case 2:
																				(_reader_5__5).Dispose();
																				num24 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
																				{
																					num24 = 0;
																				}
																				continue;
																			case 1:
																				if (_reader_5__5 != null)
																				{
																					num24 = 0;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
																					{
																						num24 = 2;
																					}
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
																goto IL_0c68;
																IL_01ec:
																num18 = num19;
																goto IL_01f0;
																IL_0786:
																__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunServerAsync_d__8>(ref _u__, ref this);
																num20 = 12;
																goto IL_01e8;
																IL_0738:
																if ((uint)(num4 - 1) > 1u)
																{
																	num18 = 8;
																	goto IL_01f0;
																}
																goto IL_0810;
																IL_0810:
																num20 = 22;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
																{
																	num20 = 3;
																}
																goto IL_01e8;
																end_IL_01cd:;
															}
															finally
															{
																if (num4 < 0)
																{
																	int num26 = 9;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
																	{
																		num26 = 2;
																	}
																	while (true)
																	{
																		switch (num26)
																		{
																		default:
																			if (num27 != 991)
																			{
																				goto end_IL_08a6;
																			}
																			goto IL_08a2;
																		case 2:
																			if (_server_5__4 != null)
																			{
																				break;
																			}
																			num27 = 3;
																			goto IL_08a2;
																		case 3:
																			goto end_IL_08a6;
																		case 1:
																			break;
																		case 0:
																			goto end_IL_08a6;
																			IL_08a2:
																			num26 = num27;
																			continue;
																		}
																		(_server_5__4).Dispose();
																		num26 = 8;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
																		{
																			num26 = 0;
																		}
																		continue;
																		end_IL_08a6:
																		break;
																	}
																}
															}
														}
														goto case 1;
													case 0:
														_reader_5__5 = null;
														num16 = 4;
														continue;
													case 1:
														_server_5__4 = null;
														num16 = 8;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
														{
															num16 = 0;
														}
														continue;
													case 2:
													case 5:
														num17 = 13;
														goto IL_0148;
													case 3:
														break;
													case 4:
														goto end_IL_014c;
														IL_0148:
														num16 = num17;
														continue;
													}
													goto IL_0965;
													continue;
													end_IL_014c:
													break;
												}
											}
											catch (object obj2) when (((Func<bool>)delegate
											{
												// Could not convert BlockContainer to single expression
												if (!(obj2 is OperationCanceledException))
												{
													num28 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
													{
														num28 = 2;
													}
												}
												else
												{
													num28 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
													{
														num28 = 0;
													}
												}
												while (true)
												{
													switch (num28)
													{
													default:
														if (num29 == 989)
														{
															goto IL_09dc;
														}
														goto case 1;
													case 1:
														result2 = 0;
														break;
													case 0:
														result2 = ((cancellationToken).IsCancellationRequested ? 1 : 0);
														break;
													}
													break;
													IL_09dc:
													num28 = num29;
												}
												return (byte)result2 != 0;
											}).Invoke())
											{
												int num30 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
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
															num30 = num31;
															continue;
														}
														break;
													case 0:
														break;
													}
													break;
												}
												goto end_IL_006c;
											}
											catch (global::System.Exception _7__wrap)
											{
												int num32 = 2;
												while (true)
												{
													switch (num32)
													{
													default:
														if (num33 == 990)
														{
															num32 = num33;
															continue;
														}
														goto case 1;
													case 1:
														__7__wrap2 = 1;
														num32 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
														{
															num32 = 5;
														}
														continue;
													case 2:
														__7__wrap1 = _7__wrap;
														num32 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
														{
															num32 = 1;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
											goto case 1;
										case 11:
											__7__wrap1 = null;
											num5 = 22;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
											{
												num5 = 18;
											}
											goto IL_0088;
										case 7:
											num6 = 3;
											continue;
										case 2:
											__7__wrap2 = 0;
											num6 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
											{
												num6 = 10;
											}
											continue;
										case 14:
											if (num4 != 3)
											{
												num6 = 6;
												continue;
											}
											goto case 7;
										case 12:
											gX17swyO7x0JWQxdaD1.U3iyRWfbJV("protocol", "协议激活进程间转发失败", exception);
											num6 = 7;
											continue;
										case 1:
											num15 = __7__wrap2;
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
											{
												num6 = 1;
											}
											continue;
										case 13:
											System.ArgumentNullException.ThrowIfNull(handler, "handler");
											num6 = 8;
											continue;
										case 10:
											break;
										case 8:
											goto IL_0c68;
										case 0:
											if (num15 == 1)
											{
												num5 = 9;
												goto IL_0088;
											}
											goto case 11;
										case 9:
											exception = (global::System.Exception)__7__wrap1;
											num6 = 12;
											continue;
										case 3:
											try
											{
												int num8;
												if (num4 != 3)
												{
													num8 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
													{
														num8 = 18;
													}
													goto IL_0cea;
												}
												goto IL_0e7e;
												IL_0cea:
												while (true)
												{
													switch (num8)
													{
													case 10:
														return;
													default:
														if (num9 != 18)
														{
															if (num9 == 998)
															{
																goto IL_0ce6;
															}
															goto case 0;
														}
														goto end_IL_0cea;
													case 0:
													case 1:
													{
														(_u__).GetResult();
														int num10 = 18;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
														{
															num10 = 18;
														}
														num9 = num10;
														goto IL_0ce6;
													}
													case 8:
														_u__ = (System.Threading.Tasks.Task.Delay(120, cancellationToken)).GetAwaiter();
														num8 = 6;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
														{
															num8 = 6;
														}
														continue;
													case 4:
														__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _RunServerAsync_d__8>(ref _u__, ref this);
														num8 = 18;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
														{
															num8 = 10;
														}
														continue;
													case 9:
														num4 = (__1__state = 3);
														num8 = 2;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
														{
															num8 = 17;
														}
														continue;
													case 3:
														num4 = (__1__state = -1);
														num8 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
														{
															num8 = 0;
														}
														continue;
													case 6:
														if ((_u__).IsCompleted)
														{
															num8 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
															{
																num8 = 14;
															}
															continue;
														}
														goto case 9;
													case 5:
														__u__1 = default;
														num8 = 12;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
														{
															num8 = 3;
														}
														continue;
													case 7:
														break;
													case 2:
														{
															__u__1 = _u__;
															num8 = 2;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
															{
																num8 = 4;
															}
															continue;
														}
														IL_0ce6:
														num8 = num9;
														continue;
													}
													goto IL_0e7e;
													continue;
													end_IL_0cea:
													break;
												}
												goto end_IL_0cb1;
												IL_0e7e:
												_u__ = __u__1;
												num8 = 5;
												goto IL_0cea;
												end_IL_0cb1:;
											}
											catch (object obj) when (((Func<bool>)delegate
											{
												// Could not convert BlockContainer to single expression
												if (!(obj is OperationCanceledException))
												{
													num11 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
													{
														num11 = 0;
													}
												}
												else
												{
													num11 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
													{
														num11 = 7;
													}
												}
												while (true)
												{
													switch (num11)
													{
													default:
														if (num12 == 989)
														{
															goto IL_0f13;
														}
														goto case 1;
													case 0:
														result = 0;
														break;
													case 1:
														result = ((cancellationToken).IsCancellationRequested ? 1 : 0);
														break;
													}
													break;
													IL_0f13:
													num11 = num12;
												}
												return (byte)result != 0;
											}).Invoke())
											{
												int num13 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
												{
													num13 = 0;
												}
												while (true)
												{
													switch (num13)
													{
													default:
														if (num14 == 988)
														{
															num13 = num14;
															continue;
														}
														break;
													case 0:
														break;
													}
													break;
												}
												goto end_IL_006c;
											}
											goto case 11;
										case 4:
											goto end_IL_006c;
											IL_0c68:
											if ((cancellationToken).IsCancellationRequested)
											{
												num6 = 4;
												continue;
											}
											goto case 2;
										}
										break;
									}
									goto IL_0c5d;
									end_IL_006c:;
								}
								catch (global::System.Exception ex)
								{
									int num34 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
									{
										num34 = 8;
									}
									while (true)
									{
										switch (num34)
										{
										case 0:
											return;
										default:
											if (num35 == 990)
											{
												num34 = num35;
												continue;
											}
											break;
										case 2:
											(__t__builder).SetException(ex);
											num34 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
											{
												num34 = 1;
											}
											continue;
										case 1:
											break;
										}
										__1__state = -2;
										num34 = 2;
									}
								}
							}
							goto case 1;
						case 2:
							num4 = __1__state;
							num = 10;
							break;
						case 1:
							__1__state = -2;
							num = 3;
							break;
						case 0:
							return;
						case 3:
							(__t__builder).SetResult();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
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
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						(__t__builder).SetStateMachine(stateMachine);
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
						{
							num2 = 4;
						}
						continue;
					case 0:
						return;
					}
					break;
				}
			}
			while (num == 989);
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
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool QD8Ppy9hUu2iY2jwR1EQ()
		{
			return qjxZx09hhx33qkT1nnUs == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object MfDmu39hrmnTcu7UmNtu()
		{
			return qjxZx09hhx33qkT1nnUs;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__3_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string activationUri;

		public CancellationToken cancellationToken;

		private TaskAwaiter<bool> __u__1;

		private static object eYtUoi9hox838kDOieYr;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01be: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_0319->IL02b1: Incompatible stack heights: 3 vs 1
			//IL_0324->IL02b1: Incompatible stack heights: 3 vs 1
			//IL_009c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_00a7->IL0010: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num4 = default;
			int num6 = default;
			TaskAwaiter<bool> _u__ = default;
			int num9 = default;
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
								if (num4 != 0)
								{
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
									{
										num5 = 12;
									}
									goto IL_00e0;
								}
								goto IL_015a;
								IL_00e0:
								while (true)
								{
									int num7;
									switch (num5)
									{
									default:
										if (num6 != 18)
										{
											if (num6 == 998)
											{
												goto IL_00dc;
											}
											goto case 3;
										}
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _SendAsync_d__3_1>(ref _u__, ref this);
										num5 = 10;
										continue;
									case 6:
										__u__1 = default;
										num5 = 9;
										continue;
									case 1:
										if (&_u__ != null)
										{
											num7 = 8;
											goto IL_00d8;
										}
										goto case 5;
									case 7:
										break;
									case 3:
										_u__ = (TaskAwaiter<bool>)dqZAKXUtL1("Chronal.ProtocolActivation", activationUri, 5, cancellationToken);
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
										{
											num5 = 1;
										}
										continue;
									case 2:
										__u__1 = _u__;
										num7 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
										{
											num7 = 18;
										}
										goto IL_00d8;
									case 9:
										num4 = (__1__state = -1);
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
										{
											num5 = 0;
										}
										continue;
									case 4:
									case 8:
									{
										bool flag = (byte)(&_u__) != 0;
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
										{
											num5 = 11;
										}
										continue;
									}
									case 10:
										return;
									case 5:
										num4 = (__1__state = 0);
										num5 = 2;
										continue;
									case 0:
										goto end_IL_00e0;
										IL_00dc:
										num5 = num6;
										continue;
										IL_00d8:
										num6 = num7;
										goto IL_00dc;
									}
									goto IL_015a;
									continue;
									end_IL_00e0:
									break;
								}
								goto end_IL_00a8;
								IL_015a:
								_u__ = __u__1;
								num5 = 6;
								goto IL_00e0;
								end_IL_00a8:;
							}
							catch (global::System.Exception)
							{
								int num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
								{
									num8 = 2;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											num8 = num9;
											break;
										}
										goto case 0;
									case 0:
										__1__state = -2;
										num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
										{
											num8 = 2;
										}
										break;
									case 2:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
										{
											_ = 1;
										}
										break;
									case 1:
										return;
									}
								}
							}
							goto case 2;
						case 2:
							__1__state = -2;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
							{
								num3 = 4;
							}
							continue;
						case 3:
							break;
						case 0:
							_ = __t__builder;
							_ = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								_ = 1;
							}
							continue;
						case 1:
							return;
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
				num = 10;
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
						case 2:
							goto end_IL_000e;
						case 1:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool jDVrkY9hmUQZaOUvhIS9()
		{
			return eYtUoi9hox838kDOieYr == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object wuTAgb9h74ZXkrH11IpR()
		{
			return eYtUoi9hox838kDOieYr;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string pipeName;

		public string activationUri;

		public CancellationToken cancellationToken;

		private TaskAwaiter<bool> __u__1;

		internal static object SZrTgm9hA732L09WbnAP;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_021f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0->IL0278: Incompatible stack heights: 3 vs 1
			//IL_02eb->IL0278: Incompatible stack heights: 3 vs 1
			//IL_032c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0337->IL0010: Incompatible stack heights: 3 vs 1
			int num = 2;
			int num4 = default;
			int num6 = default;
			TaskAwaiter<bool> _u__ = default;
			int num8 = default;
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
							if (num2 != 10)
							{
								goto end_IL_0010;
							}
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
									{
										num5 = 2;
									}
									goto IL_00a7;
								}
								goto IL_0206;
								IL_00a7:
								while (true)
								{
									switch (num5)
									{
									case 7:
										return;
									default:
										if (num6 != 18)
										{
											if (num6 == 998)
											{
												goto IL_00a3;
											}
											goto case 5;
										}
										num4 = (__1__state = 0);
										num5 = 6;
										continue;
									case 1:
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _SendAsync_d__5>(ref _u__, ref this);
										num5 = 7;
										continue;
									case 2:
									case 9:
										_u__ = __u__1;
										num5 = 5;
										continue;
									case 3:
										num4 = (__1__state = -1);
										num5 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
										{
											num5 = 4;
										}
										continue;
									case 5:
										__u__1 = default;
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
										{
											num5 = 17;
										}
										continue;
									case 6:
										__u__1 = _u__;
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
										{
											num5 = 6;
										}
										continue;
									case 4:
									{
										bool flag = (byte)(&_u__) != 0;
										num5 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
										{
											num5 = 0;
										}
										continue;
									}
									case 8:
										if (&_u__ == null)
										{
											num6 = 18;
											goto IL_00a3;
										}
										goto case 4;
									case 10:
										break;
									case 0:
										goto end_IL_00a7;
										IL_00a3:
										num5 = num6;
										continue;
									}
									goto IL_0206;
									continue;
									end_IL_00a7:
									break;
								}
								goto end_IL_006f;
								IL_0206:
								_u__ = (TaskAwaiter<bool>)dqZAKXUtL1(pipeName, activationUri, 5, cancellationToken);
								num5 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num5 = 8;
								}
								goto IL_00a7;
								end_IL_006f:;
							}
							catch (global::System.Exception)
							{
								int num7 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
								{
									num7 = 2;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										return;
									default:
										if (num8 == 990)
										{
											num7 = num8;
											continue;
										}
										break;
									case 2:
										__1__state = -2;
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
										{
											num7 = 7;
										}
										continue;
									case 0:
										break;
									}
									_ = __t__builder;
									_ = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										_ = 1;
									}
								}
							}
							goto case 3;
						case 2:
							break;
						case 1:
							return;
						case 0:
							_ = __t__builder;
							_ = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
							{
								_ = 1;
							}
							continue;
						case 3:
							__1__state = -2;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
							{
								num3 = 9;
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
				while (num2 == 991);
				num4 = __1__state;
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
				{
					num = 10;
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
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								num = 6;
							}
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							num = 1;
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
		internal static bool UYn6Jd9hIUnvU9lbZFbM()
		{
			return SZrTgm9hA732L09WbnAP == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object k1ymNW9hBdbkeQnGyOYL()
		{
			return SZrTgm9hA732L09WbnAP;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string pipeName;

		public string activationUri;

		public CancellationToken cancellationToken;

		public int maximumAttempts;

		private string _normalized_5__2;

		private int _attempt_5__3;

		private NamedPipeClientStream _client_5__4;

		private StreamWriter _writer_5__5;

		private TaskAwaiter __u__1;

		private static object QfAKDP9hgMh91Yg1LQiU;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b94: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cf4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d08: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c69: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b68: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0265: Expected O, but got I4
			//IL_0318: Unknown result type (might be due to invalid IL or missing references)
			//IL_031d: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_032c: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0391: Unknown result type (might be due to invalid IL or missing references)
			//IL_0396: Unknown result type (might be due to invalid IL or missing references)
			//IL_0341: Unknown result type (might be due to invalid IL or missing references)
			//IL_03de: Expected O, but got I4
			//IL_03e3: Expected O, but got I4
			//IL_0603: Unknown result type (might be due to invalid IL or missing references)
			//IL_0608: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0589: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0658: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dca->IL0d89: Incompatible stack heights: 3 vs 1
			//IL_0dd5->IL0d89: Incompatible stack heights: 3 vs 1
			//IL_0e5b->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0279->IL0208: Incompatible stack heights: 4 vs 1
			//IL_0284->IL0208: Incompatible stack heights: 4 vs 1
			//IL_03ed->IL02b5: Incompatible stack heights: 4 vs 1
			int num3 = default;
			TaskAwaiter _u__ = default;
			int num6 = default;
			int num19 = default;
			int num16 = default;
			int num12 = default;
			int num14 = default;
			int num18 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num20);
			global::System.Exception ex = default;
			int num21 = default;
			global::System.Exception ex2 = default;
			bool flag2 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num23 = default;
			int num7 = default;
			int num25 = default;
			while (true)
			{
				int num = 2;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num == 10)
							{
								return;
							}
							goto end_IL_0010;
						case 0:
							__1__state = -2;
							num2 = 3;
							continue;
						case 1:
							try
							{
								int num4;
								if ((uint)num3 <= 1u)
								{
									num4 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
									{
										num4 = 33;
									}
									goto IL_0092;
								}
								goto IL_0bff;
								IL_0b8e:
								_u__ = __u__1;
								num4 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
								{
									num4 = 34;
								}
								goto IL_0092;
								IL_0bff:
								if (num3 != 2)
								{
									num4 = 13;
									goto IL_0092;
								}
								goto IL_0b8e;
								IL_0092:
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										if (num6 != 41)
										{
											if (num6 == 1021)
											{
												goto IL_008e;
											}
											goto case 3;
										}
										goto case 29;
									case 29:
										if (_attempt_5__3 <= maximumAttempts)
										{
											num4 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
											{
												num4 = 25;
											}
											continue;
										}
										goto case 3;
									case 23:
									case 33:
										num4 = 20;
										continue;
									case 13:
										System.ArgumentException.ThrowIfNullOrWhiteSpace(pipeName, "pipeName");
										num5 = 19;
										goto IL_008a;
									case 1:
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SendAsync_d__6>(ref _u__, ref this);
										num5 = 28;
										goto IL_008a;
									case 20:
										try
										{
											int num8;
											if ((uint)num3 > 1u)
											{
												num8 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
												{
													num8 = 0;
												}
												goto IL_0208;
											}
											goto IL_022c;
											IL_0208:
											while (true)
											{
												switch (num8)
												{
												default:
													if (num19 == 990)
													{
														num8 = num19;
														continue;
													}
													goto case 0;
												case 1:
													break;
												case 0:
													_ = ".";
													_ = pipeName;
													global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendAsync_d__6*)2)->_client_5__4, (object)1610612736);
													_ = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
													{
														_ = 7;
													}
													continue;
												case 2:
													try
													{
														int num9;
														if (num3 != 0)
														{
															num9 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
															{
																num9 = 5;
															}
															goto IL_02bd;
														}
														goto IL_0317;
														IL_02bd:
														while (true)
														{
															int num15;
															switch (num9)
															{
															default:
																if (num16 != 20)
																{
																	if (num16 == 1000)
																	{
																		goto IL_02b9;
																	}
																	goto case 7;
																}
																_ = _client_5__4;
																_ = 0;
																(1).AutoFlush = true;
																global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendAsync_d__6*)(-1))->_writer_5__5, (object)1);
																_ = 7;
																goto IL_02b5;
															case 12:
																break;
															case 1:
																__u__1 = _u__;
																num9 = 6;
																continue;
															case 8:
																__u__1 = default;
																num9 = 2;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
																{
																	num9 = 11;
																}
																continue;
															case 7:
																num9 = 4;
																continue;
															case 2:
																_u__ = ((_client_5__4).ConnectAsync(600, cancellationToken)).GetAwaiter();
																num9 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
																{
																	num9 = 0;
																}
																continue;
															case 9:
																return;
															case 3:
																if (num3 != 1)
																{
																	num9 = 2;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
																	{
																		num9 = 10;
																	}
																	continue;
																}
																goto case 7;
															case 0:
																if (!(_u__).IsCompleted)
																{
																	num15 = 5;
																	goto IL_02b5;
																}
																goto case 10;
															case 6:
																__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SendAsync_d__6>(ref _u__, ref this);
																num9 = 9;
																continue;
															case 10:
																(_u__).GetResult();
																num15 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
																{
																	num15 = 20;
																}
																goto IL_02b5;
															case 5:
																num3 = (__1__state = 0);
																num9 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
																{
																	num9 = 16;
																}
																continue;
															case 11:
																num3 = (__1__state = -1);
																num9 = 10;
																continue;
															case 4:
																{
																	try
																	{
																		int num10;
																		if (num3 != 1)
																		{
																			num10 = 2;
																			goto IL_04d4;
																		}
																		goto IL_0602;
																		IL_0602:
																		_u__ = __u__1;
																		int num11 = 5;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
																		{
																			num11 = 19;
																		}
																		goto IL_04cc;
																		IL_04d4:
																		while (true)
																		{
																			switch (num10)
																			{
																			case 1:
																				if ((_u__).IsCompleted)
																				{
																					num10 = 11;
																					continue;
																				}
																				goto case 3;
																			case 3:
																				num3 = (__1__state = 1);
																				num10 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
																				{
																					num10 = 17;
																				}
																				continue;
																			case 2:
																				_u__ = ((_writer_5__5).WriteLineAsync(_normalized_5__2)).GetAwaiter();
																				num10 = 4;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
																				{
																					num10 = 1;
																				}
																				continue;
																			case 9:
																				return;
																			case 4:
																				goto end_IL_04d4;
																			case 5:
																			case 11:
																				goto IL_05da;
																			case 0:
																				__u__1 = _u__;
																				num10 = 8;
																				continue;
																			case 6:
																				goto IL_0602;
																			case 10:
																				num3 = (__1__state = -1);
																				num10 = 5;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
																				{
																					num10 = 17;
																				}
																				continue;
																			case 8:
																				goto IL_0668;
																			case 7:
																				goto end_IL_04b0;
																			}
																			if (num12 != 19)
																			{
																				if (num12 == 999)
																				{
																					goto IL_04d0;
																				}
																				goto IL_0668;
																			}
																			__u__1 = default;
																			num10 = 10;
																			continue;
																			IL_0668:
																			__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _SendAsync_d__6>(ref _u__, ref this);
																			num10 = 19;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
																			{
																				num10 = 9;
																			}
																			continue;
																			end_IL_04d4:
																			break;
																		}
																		bool flag = true;
																		num11 = 7;
																		goto IL_04cc;
																		IL_04d0:
																		num10 = num12;
																		goto IL_04d4;
																		IL_05da:
																		(_u__).GetResult();
																		num11 = 4;
																		goto IL_04cc;
																		IL_04cc:
																		num12 = num11;
																		goto IL_04d0;
																		end_IL_04b0:;
																	}
																	finally
																	{
																		if (num3 < 0)
																		{
																			int num13 = 2;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
																			{
																				num13 = 5;
																			}
																			while (true)
																			{
																				switch (num13)
																				{
																				default:
																					if (num14 == 991)
																					{
																						num13 = num14;
																						continue;
																					}
																					goto end_IL_06d3;
																				case 3:
																					goto end_IL_06d3;
																				case 2:
																					if (_writer_5__5 == null)
																					{
																						num13 = 3;
																						continue;
																					}
																					break;
																				case 1:
																					break;
																				case 0:
																					goto end_IL_06d3;
																				}
																				(_writer_5__5).Dispose();
																				num13 = 0;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
																				{
																					num13 = 0;
																				}
																				continue;
																				end_IL_06d3:
																				break;
																			}
																		}
																	}
																	goto end_IL_02bd;
																}
																IL_02b9:
																num9 = num16;
																continue;
																IL_02b5:
																num16 = num15;
																goto IL_02b9;
															}
															goto IL_0317;
															continue;
															end_IL_02bd:
															break;
														}
														goto end_IL_0285;
														IL_0317:
														_u__ = __u__1;
														num9 = 8;
														goto IL_02bd;
														end_IL_0285:;
													}
													finally
													{
														int num17;
														if (num3 >= 0)
														{
															num17 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
															{
																num17 = 3;
															}
															goto IL_079d;
														}
														goto IL_0807;
														IL_07ed:
														(_client_5__4).Dispose();
														num17 = 4;
														goto IL_079d;
														IL_0807:
														if (_client_5__4 == null)
														{
															num17 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
															{
																num17 = 8;
															}
															goto IL_079d;
														}
														goto IL_07ed;
														IL_079d:
														while (true)
														{
															switch (num17)
															{
															default:
																if (num18 == 992)
																{
																	num17 = num18;
																	continue;
																}
																goto IL_0807;
															case 3:
																break;
															case 0:
																goto IL_07ed;
															case 2:
																goto IL_0807;
															case 1:
																break;
															case 4:
																break;
															}
															break;
														}
													}
													goto end_IL_0208;
												}
												goto IL_022c;
												continue;
												end_IL_0208:
												break;
											}
											goto end_IL_01cf;
											IL_022c:
											num8 = 2;
											goto IL_0208;
											end_IL_01cf:;
										}
										catch (object obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num20 = 6;
											}
											else
											{
												ex = obj2;
												num20 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
												{
													num20 = 13;
												}
											}
											while (true)
											{
												switch (num20)
												{
												default:
													if (num21 != 14)
													{
														if (num21 == 994)
														{
															goto IL_087f;
														}
														goto case 6;
													}
													if (ex2 is IOException)
													{
														num20 = 2;
														continue;
													}
													goto case 3;
												case 3:
													flag2 = false;
													num20 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
													{
														num20 = 1;
													}
													continue;
												case 0:
													if (!(ex2 is TimeoutException))
													{
														num21 = 14;
														goto IL_087f;
													}
													goto case 2;
												case 4:
													ex2 = ex;
													num20 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
													{
														num20 = 0;
													}
													continue;
												case 2:
													flag2 = true;
													num20 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
													{
														num20 = 10;
													}
													continue;
												case 6:
													result = 0;
													break;
												case 1:
												case 5:
													{
														result = (flag2 ? 1 : 0);
														break;
													}
													IL_087f:
													num20 = num21;
													continue;
												}
												break;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num22 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
											{
												num22 = 1;
											}
											while (true)
											{
												switch (num22)
												{
												default:
													if (num23 == 989)
													{
														num22 = num23;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto end_IL_09cc;
												}
												num7 = 1;
												num22 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
												{
													num22 = 0;
												}
												continue;
												end_IL_09cc:
												break;
											}
											goto case 26;
										}
										break;
									case 15:
										(_u__).GetResult();
										num4 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
										{
											num4 = 24;
										}
										continue;
									case 0:
									case 11:
										(cancellationToken).ThrowIfCancellationRequested();
										num4 = 27;
										continue;
									case 7:
										if (_attempt_5__3 < maximumAttempts)
										{
											num4 = 21;
											continue;
										}
										goto case 31;
									case 32:
										_attempt_5__3 = num7 + 1;
										num4 = 29;
										continue;
									case 30:
										if (!(_u__).IsCompleted)
										{
											num4 = 14;
											continue;
										}
										goto case 15;
									case 8:
										if ((_normalized_5__2).Length != 0)
										{
											num4 = 2;
											continue;
										}
										goto case 9;
									case 17:
										break;
									case 28:
										return;
									case 24:
										num7 = _attempt_5__3;
										num4 = 32;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
										{
											num4 = 7;
										}
										continue;
									case 25:
										__u__1 = _u__;
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
										{
											num4 = 30;
										}
										continue;
									case 10:
										goto IL_0b8e;
									case 19:
										_normalized_5__2 = vKC6uJWY94x4WOB9I3n.B7dWyywd55(activationUri);
										num4 = 8;
										continue;
									case 27:
										num7 = 0;
										num4 = 23;
										continue;
									case 31:
									{
										bool flag = false;
										num4 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
										{
											num4 = 17;
										}
										continue;
									}
									case 4:
										goto IL_0bff;
									case 9:
									{
										bool flag = false;
										num4 = 5;
										continue;
									}
									case 5:
										break;
									case 26:
										if (num7 == 1)
										{
											num4 = 7;
											continue;
										}
										goto case 24;
									case 16:
										__u__1 = default;
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
										{
											num4 = 1;
										}
										continue;
									case 3:
									{
										bool flag = false;
										num4 = 18;
										continue;
									}
									case 6:
										num3 = (__1__state = -1);
										num4 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
										{
											num4 = 15;
										}
										continue;
									case 2:
									case 22:
										_attempt_5__3 = 1;
										num5 = 41;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num5 = 40;
										}
										goto IL_008a;
									case 12:
									case 21:
										_u__ = (System.Threading.Tasks.Task.Delay(_attempt_5__3 * 80, cancellationToken)).GetAwaiter();
										num5 = 30;
										goto IL_008a;
									case 14:
										num3 = (__1__state = 2);
										num4 = 25;
										continue;
									case 18:
										break;
										IL_008e:
										num4 = num6;
										continue;
										IL_008a:
										num6 = num5;
										goto IL_008e;
									}
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num24 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
								{
									num24 = 1;
								}
								while (true)
								{
									switch (num24)
									{
									default:
										if (num25 == 990)
										{
											num24 = num25;
											break;
										}
										return;
									case 0:
										_ = __t__builder;
										_ = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
										{
											_ = 2;
										}
										break;
									case 1:
										__1__state = -2;
										num24 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
										{
											num24 = 0;
										}
										break;
									case 2:
										return;
									}
								}
							}
							goto case 0;
						case 2:
							num3 = __1__state;
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								num2 = 1;
							}
							continue;
						case 3:
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
				while (num == 991);
				_ = __t__builder;
				_ = 10;
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
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
								{
									num3 = 3;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							num3 = 1;
							continue;
						case 1:
							break;
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
				while (num2 == 990);
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool wrVL6k9hlwQvDhCcrtCT()
		{
			return QfAKDP9hgMh91Yg1LQiU == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object rDsPtV9hdGu7euC8MknQ()
		{
			return QfAKDP9hgMh91Yg1LQiU;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _TrySendAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string activationUri;

		public CancellationToken cancellationToken;

		private TaskAwaiter<bool> __u__1;

		private static object q6XqGj9hKJUIWWNjc8Xp;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297->IL0256: Incompatible stack heights: 3 vs 1
			//IL_02a2->IL0256: Incompatible stack heights: 3 vs 1
			//IL_0359->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0364->IL0010: Incompatible stack heights: 3 vs 1
			int num = 3;
			int num4 = default;
			TaskAwaiter<bool> _u__ = default;
			int num7 = default;
			int num9 = default;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					IL_000c:
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 2:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 7;
									goto IL_006a;
								}
								goto IL_01a6;
								IL_01a6:
								_u__ = __u__1;
								num5 = 10;
								goto IL_006a;
								IL_006a:
								while (true)
								{
									int num6;
									switch (num5)
									{
									default:
										if (num7 != 18)
										{
											if (num7 == 998)
											{
												goto IL_0066;
											}
											goto case 1;
										}
										__t__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _TrySendAsync_d__4>(ref _u__, ref this);
										num6 = 8;
										goto IL_0062;
									case 8:
										return;
									case 7:
										_u__ = (TaskAwaiter<bool>)dqZAKXUtL1("Chronal.ProtocolActivation", activationUri, 2, cancellationToken);
										num5 = 3;
										continue;
									case 3:
										if (&_u__ != null)
										{
											num5 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
											{
												num5 = 12;
											}
											continue;
										}
										goto case 5;
									case 1:
									case 9:
									{
										bool flag = (byte)(&_u__) != 0;
										num5 = 4;
										continue;
									}
									case 5:
										num4 = (__1__state = 0);
										num5 = 2;
										continue;
									case 6:
										break;
									case 0:
										num4 = (__1__state = -1);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
										{
											num5 = 13;
										}
										continue;
									case 10:
										__u__1 = default;
										num5 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
										{
											num5 = 0;
										}
										continue;
									case 2:
										__u__1 = _u__;
										num6 = 18;
										goto IL_0062;
									case 4:
										goto end_IL_006a;
										IL_0062:
										num7 = num6;
										goto IL_0066;
										IL_0066:
										num5 = num7;
										continue;
									}
									goto IL_01a6;
									continue;
									end_IL_006a:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
								{
									num8 = 2;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											num8 = num9;
											break;
										}
										return;
									case 0:
										_ = __t__builder;
										_ = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
										{
											_ = 1;
										}
										break;
									case 2:
										__1__state = -2;
										num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
										{
											num8 = 8;
										}
										break;
									case 1:
										return;
									}
								}
							}
							goto case 1;
						case 1:
							__1__state = -2;
							num = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
							{
								num = 10;
							}
							goto end_IL_0010;
						case 3:
							num4 = __1__state;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num3 = 1;
							}
							continue;
						case 0:
							return;
						}
						switch (num2)
						{
						case 991:
							break;
						default:
							return;
						case 10:
							_ = __t__builder;
							_ = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
							{
								_ = 0;
							}
							continue;
						}
						goto IL_000c;
						continue;
						end_IL_0010:
						break;
					}
					break;
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
								num3 = 2;
								continue;
							}
							goto end_IL_0012;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							break;
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
				while (num2 == 990);
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool PRJ0AR9hHsuOs7MvEyWt()
		{
			return q6XqGj9hKJUIWWNjc8Xp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object mQcK3N9htxn6fYx9QcwY()
		{
			return q6XqGj9hKJUIWWNjc8Xp;
		}
	}

	private static object iH66Q9ZyjKPgZqHWWn49;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe static global::System.Threading.Tasks.Task<bool> DqSAgJSFVC(string activationUri, CancellationToken cancellationToken = default(CancellationToken))
	{
		object obj = default;
		obj.__1__state = -1;
		((AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB>*)2)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<t30hHHfP8gMStFdbd6rB>.ConfiguredTaskAwaiter, p7aMTy5CiDjPcd5Qwt6._CheckUpsmsVerifyAsync_d__25>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public unsafe static global::System.Threading.Tasks.Task<bool> sVCAlag522(string activationUri, CancellationToken cancellationToken = default(CancellationToken))
	{
		object obj = default;
		obj.activationUri = activationUri;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<bool> SkFAdqL5E2(object pipeName, object activationUri, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.activationUri = (string)activationUri;
		_ = 5;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3;
		_ = 3;
		obj.__1__state = -1;
		_ = 0;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendAsync_d__5*)11)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<bool> dqZAKXUtL1(object pipeName, object activationUri, int maximumAttempts, CancellationToken cancellationToken)
	{
		object obj = default;
		obj.__1__state = -1;
		((AsyncTaskMethodBuilder<t30hHHfP8gMStFdbd6rB>*)1)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<p7aMTy5CiDjPcd5Qwt6.bcATbBfGSAoRYQCqLAfa>.ConfiguredTaskAwaiter, p7aMTy5CiDjPcd5Qwt6._CompleteMobileSmsLoginAsync_d__62>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public static global::System.Threading.Tasks.Task OqxAHKWEdi(Func<string, global::System.Threading.Tasks.Task> handler, CancellationToken cancellationToken = default(CancellationToken))
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task dqeAtyNw0o(object pipeName, Func<string, global::System.Threading.Tasks.Task> handler, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		((AsyncTaskMethodBuilder<bool>*)3)->AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, p7aMTy5CiDjPcd5Qwt6._EnsureDeviceAsync_d__26>(ref this, ref this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_009b->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
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
					case 1:
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
						{
							obj2 = 0;
						}
						continue;
					case 0:
						break;
					case 2:
						obj2 = 1;
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
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool m2f8C2ZyZYsf92jMjewK()
	{
		return iH66Q9ZyjKPgZqHWWn49 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static zGYfuvAIWLxgR6VMCLW MegYyXZy9Jsk4YrUFgXG()
	{
		return (zGYfuvAIWLxgR6VMCLW)iH66Q9ZyjKPgZqHWWn49;
	}
}

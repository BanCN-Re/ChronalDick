using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QYJtooPfnXCe6AdrjZX;
using W7vNcCepi9XSttyQFSd;
using fDAldojjppXrctUVYOJn;
using ixW8SPPDRc7BNnonXQX;
using yoclAxeG6hQhgmsUKZZ;

namespace XgJ6gce1wjf9QCp6VWH;

internal sealed class VwcdmEeaHles4kN24T4
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _HandleAsync_d__4 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public TcpClient client;

		public VwcdmEeaHles4kN24T4 __4__this;

		public CancellationToken cancellationToken;

		private TcpClient __7__wrap1;

		private NetworkStream _stream_5__3;

		private object __7__wrap3;

		private int __7__wrap4;

		private uint _status_5__6;

		private ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		private ValueTaskAwaiter __u__3;

		private static object l8X1Jw9720KLivTi1UAo;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f72: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e90: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f9b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e7f: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0979: Unknown result type (might be due to invalid IL or missing references)
			//IL_097e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_067b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0695: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_062e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_050e: Unknown result type (might be due to invalid IL or missing references)
			//IL_060c: Expected O, but got Ref
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0718: Unknown result type (might be due to invalid IL or missing references)
			//IL_071a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b21: Unknown result type (might be due to invalid IL or missing references)
			//IL_09da: Unknown result type (might be due to invalid IL or missing references)
			//IL_09dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0af8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0afd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0750: Unknown result type (might be due to invalid IL or missing references)
			//IL_08e3->IL087f: Incompatible stack heights: 3 vs 1
			//IL_0cc8->IL0c6a: Incompatible stack heights: 3 vs 1
			//IL_08ee->IL087f: Incompatible stack heights: 3 vs 1
			//IL_0cd3->IL0c6a: Incompatible stack heights: 3 vs 1
			//IL_0524->IL03cb: Incompatible stack heights: 2 vs 1
			//IL_052f->IL03cb: Incompatible stack heights: 2 vs 1
			int num = 4;
			int num4 = default;
			int num7 = default;
			int num9 = default;
			object obj4 = default;
			int num29 = default;
			int num21 = default;
			ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>.ConfiguredTaskAwaiter _u__3 = default;
			ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD> val2 = default;
			object _u__2 = default;
			VwcdmEeaHles4kN24T4 vwcdmEeaHles4kN24T = default;
			oFthKhPXnfwgYxepFLD request = default;
			ConfiguredTaskAwaitable val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num23);
			int num24 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
			int num26 = default;
			int num28 = default;
			int num13 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
			int num15 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num17 = default;
			int num19 = default;
			int num31 = default;
			int num10 = default;
			ValueTaskAwaiter _u__ = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			int num34 = default;
			int num36 = default;
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
							__1__state = -2;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
							{
								num3 = 11;
							}
							continue;
						case 4:
							goto end_IL_000c;
						case 0:
							try
							{
								int num5;
								if ((uint)num4 <= 3u)
								{
									num5 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
									{
										num5 = 1;
									}
									goto IL_00e4;
								}
								goto IL_0122;
								IL_00e4:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num7 != 13)
										{
											if (num7 != 993)
											{
												goto end_IL_00e4;
											}
											goto IL_00e0;
										}
										try
										{
											int num8;
											if ((uint)num4 <= 2u)
											{
												num8 = 17;
												goto IL_01b6;
											}
											goto IL_02ac;
											IL_023d:
											if (num9 != 1016)
											{
												return;
											}
											goto IL_01b2;
											IL_01b6:
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 != 36)
													{
														goto IL_023d;
													}
													goto case 18;
												case 20:
													__7__wrap4 = 0;
													num8 = 23;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
													{
														num8 = 18;
													}
													continue;
												case 14:
													obj4 = __7__wrap3;
													num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
													{
														num8 = 11;
													}
													continue;
												case 10:
													break;
												case 26:
													try
													{
														int num11;
														if ((uint)num4 > 1u)
														{
															num11 = 7;
															goto IL_02f8;
														}
														goto IL_0cf3;
														IL_0cf3:
														num11 = 2;
														goto IL_02f8;
														IL_02f8:
														while (true)
														{
															switch (num11)
															{
															default:
																if (num29 == 15)
																{
																	break;
																}
																if (num29 == 995)
																{
																	goto IL_02f4;
																}
																goto case 1;
															case 7:
																if (num4 != 2)
																{
																	num11 = 2;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																	{
																		num11 = 1;
																	}
																	continue;
																}
																goto case 4;
															case 3:
																goto end_IL_02f8;
															case 1:
																_status_5__6 = 1u;
																num29 = 15;
																goto IL_02f4;
															case 2:
																try
																{
																	int num20;
																	if (num4 != 0)
																	{
																		num20 = 22;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
																		{
																			num20 = 19;
																		}
																		goto IL_03d3;
																	}
																	goto IL_05f5;
																	IL_03d3:
																	while (true)
																	{
																		int num22;
																		switch (num20)
																		{
																		default:
																			if (num21 != 33)
																			{
																				if (num21 == 1013)
																				{
																					goto IL_03cf;
																				}
																				goto case 1;
																			}
																			_u__3 = val2;
																			num20 = 5;
																			continue;
																		case 25:
																			return;
																		case 11:
																			num4 = (__1__state = 0);
																			num20 = 23;
																			continue;
																		case 0:
																			return;
																		case 12:
																		case 16:
																			(_u__2).GetResult();
																			num22 = 4;
																			goto IL_03cb;
																		case 1:
																			_u__2 = __u__2;
																			num20 = 2;
																			continue;
																		case 15:
																			h1yFryP9N7Y4p0MUIAi.FW9PkFADcY(_stream_5__3, vwcdmEeaHles4kN24T.SFWeEZ7Gt4, cancellationToken);
																			val2 = (ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>)0;
																			_ = 33;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
																			{
																				_ = 16;
																			}
																			goto IL_03cb;
																		case 18:
																			__t__builder.AwaitUnsafeOnCompleted<object, _HandleAsync_d__4>(ref _u__2, ref this);
																			num20 = 25;
																			continue;
																		case 17:
																			if ((_u__2).IsCompleted)
																			{
																				num20 = 30;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
																				{
																					num20 = 12;
																				}
																				continue;
																			}
																			goto case 14;
																		case 21:
																			__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<oFthKhPXnfwgYxepFLD>.ConfiguredTaskAwaiter, _HandleAsync_d__4>(ref _u__3, ref this);
																			num20 = 2;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
																			{
																				num20 = 0;
																			}
																			continue;
																		case 8:
																			num4 = (__1__state = -1);
																			num20 = 16;
																			continue;
																		case 7:
																			__u__1 = default;
																			num20 = 2;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																			{
																				num20 = 10;
																			}
																			continue;
																		case 20:
																			__u__2 = _u__2;
																			num20 = 18;
																			continue;
																		case 6:
																			break;
																		case 19:
																		case 24:
																			request = (oFthKhPXnfwgYxepFLD)(&_u__3);
																			num20 = 7;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
																			{
																				num20 = 9;
																			}
																			continue;
																		case 13:
																			_u__2 = val;
																			num20 = 17;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
																			{
																				num20 = 10;
																			}
																			continue;
																		case 4:
																			_status_5__6 = 0u;
																			num20 = 17;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
																			{
																				num20 = 3;
																			}
																			continue;
																		case 2:
																			__u__2 = default;
																			num22 = 8;
																			goto IL_03cb;
																		case 9:
																			val = (((rEhAA9eMY3vbR3ki0HQ)vwcdmEeaHles4kN24T.GK6evDFL1R).AuthenticateAsync(request, cancellationToken)).ConfigureAwait(false);
																			num20 = 13;
																			continue;
																		case 22:
																			if (num4 != 1)
																			{
																				num20 = 4;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
																				{
																					num20 = 15;
																				}
																				continue;
																			}
																			goto case 1;
																		case 5:
																			if (&_u__3 != null)
																			{
																				num20 = 24;
																				continue;
																			}
																			goto case 11;
																		case 10:
																			num4 = (__1__state = -1);
																			num20 = 19;
																			continue;
																		case 14:
																			num4 = (__1__state = 1);
																			num20 = 20;
																			continue;
																		case 23:
																			__u__1 = _u__3;
																			num20 = 21;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
																			{
																				num20 = 5;
																			}
																			continue;
																		case 3:
																			goto end_IL_03d3;
																			IL_03cf:
																			num20 = num21;
																			continue;
																			IL_03cb:
																			num21 = num22;
																			goto IL_03cf;
																		}
																		goto IL_05f5;
																		continue;
																		end_IL_03d3:
																		break;
																	}
																	goto end_IL_039b;
																	IL_05f5:
																	_u__3 = __u__1;
																	num20 = 7;
																	goto IL_03d3;
																	end_IL_039b:;
																}
																catch (object obj2) when (((Func<bool>)delegate
																{
																	// Could not convert BlockContainer to single expression
																	if (!(obj2 is OperationCanceledException))
																	{
																		num23 = 3;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
																		{
																			num23 = 1;
																		}
																	}
																	else
																	{
																		num23 = 5;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
																		{
																			num23 = 0;
																		}
																	}
																	while (true)
																	{
																		switch (num23)
																		{
																		default:
																			if (num24 == 989)
																			{
																				goto IL_079a;
																			}
																			goto case 0;
																		case 1:
																			result2 = 0;
																			break;
																		case 0:
																			result2 = ((cancellationToken).IsCancellationRequested ? 1 : 0);
																			break;
																		}
																		break;
																		IL_079a:
																		num23 = num24;
																	}
																	return (byte)result2 != 0;
																}).Invoke())
																{
																	int num25 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																	{
																		num25 = 3;
																	}
																	while (true)
																	{
																		switch (num25)
																		{
																		default:
																			if (num26 == 988)
																			{
																				num25 = num26;
																				continue;
																			}
																			break;
																		case 0:
																			break;
																		}
																		break;
																	}
																	goto case 0;
																}
																catch (global::System.Exception exception2)
																{
																	int num27 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
																	{
																		num27 = 0;
																	}
																	while (true)
																	{
																		switch (num27)
																		{
																		default:
																			if (num28 == 989)
																			{
																				num27 = num28;
																				continue;
																			}
																			break;
																		case 0:
																			break;
																		case 1:
																			goto end_IL_087f;
																		}
																		_ = vwcdmEeaHles4kN24T.imie29mGhB;
																		qOyLvbeqBlffJuaDnpH.qaZeilAb63("认证", exception2);
																		_ = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
																		{
																			_ = 6;
																		}
																		continue;
																		end_IL_087f:
																		break;
																	}
																}
																goto case 4;
															case 6:
																try
																{
																	int num12;
																	if (num4 != 2)
																	{
																		num12 = 11;
																		goto IL_0922;
																	}
																	goto IL_0978;
																	IL_0978:
																	_u__2 = __u__2;
																	num12 = 11;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
																	{
																		num12 = 10;
																	}
																	goto IL_0922;
																	IL_0922:
																	while (true)
																	{
																		switch (num12)
																		{
																		case 3:
																			goto end_IL_0922;
																		default:
																			if (num13 != 19)
																			{
																				if (num13 == 999)
																				{
																					goto IL_091e;
																				}
																				goto case 6;
																			}
																			goto case 7;
																		case 9:
																			break;
																		case 5:
																			return;
																		case 10:
																			__u__2 = default;
																			num12 = 8;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
																			{
																				num12 = 2;
																			}
																			continue;
																		case 6:
																			__u__2 = _u__2;
																			num12 = 15;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
																			{
																				num12 = 0;
																			}
																			continue;
																		case 2:
																			num4 = (__1__state = -1);
																			num12 = 11;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
																			{
																				num12 = 7;
																			}
																			continue;
																		case 0:
																			__t__builder.AwaitUnsafeOnCompleted<object, _HandleAsync_d__4>(ref _u__2, ref this);
																			num12 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
																			{
																				num12 = 0;
																			}
																			continue;
																		case 8:
																			if ((_u__2).IsCompleted)
																			{
																				num13 = 19;
																				goto IL_091e;
																			}
																			goto case 1;
																		case 1:
																			num4 = (__1__state = 2);
																			num12 = 6;
																			continue;
																		case 7:
																			(_u__2).GetResult();
																			num12 = 5;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
																			{
																				num12 = 3;
																			}
																			continue;
																		case 11:
																			val = (h1yFryP9N7Y4p0MUIAi.fclPYSVpoo(_stream_5__3, _status_5__6, vwcdmEeaHles4kN24T.SFWeEZ7Gt4, cancellationToken)).ConfigureAwait(false);
																			num12 = 4;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
																			{
																				num12 = 4;
																			}
																			continue;
																		case 4:
																			{
																				_u__2 = val;
																				num12 = 13;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
																				{
																					num12 = 8;
																				}
																				continue;
																			}
																			IL_091e:
																			num12 = num13;
																			continue;
																		}
																		goto IL_0978;
																		continue;
																		end_IL_0922:
																		break;
																	}
																}
																catch (object obj) when (((Func<bool>)delegate
																{
																	// Could not convert BlockContainer to single expression
																	if (!(obj is OperationCanceledException))
																	{
																		num14 = 4;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
																		{
																			num14 = 0;
																		}
																	}
																	else
																	{
																		num14 = 1;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
																		{
																			num14 = 3;
																		}
																	}
																	while (true)
																	{
																		switch (num14)
																		{
																		default:
																			if (num15 == 989)
																			{
																				goto IL_0b85;
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
																		IL_0b85:
																		num14 = num15;
																	}
																	return (byte)result != 0;
																}).Invoke())
																{
																	int num16 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
																	{
																		num16 = 1;
																	}
																	while (true)
																	{
																		switch (num16)
																		{
																		case 0:
																			break;
																		default:
																			if (num17 != 988)
																			{
																				break;
																			}
																			num16 = num17;
																			continue;
																		}
																		break;
																	}
																}
																catch (global::System.Exception exception)
																{
																	int num18 = 7;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
																	{
																		num18 = 0;
																	}
																	while (true)
																	{
																		switch (num18)
																		{
																		case 1:
																			goto end_IL_0c6a;
																		default:
																			if (num19 == 989)
																			{
																				num18 = num19;
																				continue;
																			}
																			break;
																		case 0:
																			break;
																		}
																		_ = vwcdmEeaHles4kN24T.imie29mGhB;
																		qOyLvbeqBlffJuaDnpH.qaZeilAb63("响应", exception);
																		_ = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
																		{
																			_ = 1;
																		}
																		continue;
																		end_IL_0c6a:
																		break;
																	}
																}
																goto end_IL_02f8;
															case 0:
																__7__wrap4 = 1;
																num11 = 5;
																continue;
															case 4:
																num11 = 6;
																continue;
															case 5:
																goto end_IL_02f8;
																IL_02f4:
																num11 = num29;
																continue;
															}
															goto IL_0cf3;
															continue;
															end_IL_02f8:
															break;
														}
													}
													catch (object obj3)
													{
														obj4 = obj3;
														int num30 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
														{
															num30 = 2;
														}
														while (true)
														{
															switch (num30)
															{
															default:
																if (num31 == 989)
																{
																	num30 = num31;
																	continue;
																}
																break;
															case 0:
																break;
															case 1:
																goto end_IL_0d41;
															}
															__7__wrap3 = obj4;
															num30 = 6;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
															{
																num30 = 1;
															}
															continue;
															end_IL_0d41:
															break;
														}
													}
													goto case 13;
												case 4:
													__7__wrap3 = null;
													num8 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
													{
														num8 = 2;
													}
													continue;
												case 16:
													num4 = (__1__state = -1);
													num8 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
													{
														num8 = 15;
													}
													continue;
												case 1:
													goto end_IL_0192;
												case 12:
													return;
												case 11:
													if (num10 == 1)
													{
														num8 = 27;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
														{
															num8 = 1;
														}
														continue;
													}
													goto case 4;
												case 25:
													__u__3 = default;
													num8 = 16;
													continue;
												case 8:
													__u__3 = _u__;
													num8 = 5;
													continue;
												case 17:
												case 23:
													num8 = 26;
													continue;
												case 5:
													__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _HandleAsync_d__4>(ref _u__, ref this);
													num8 = 12;
													continue;
												case 28:
													_stream_5__3 = (client).GetStream();
													num8 = 22;
													continue;
												case 18:
													num10 = __7__wrap4;
													num8 = 11;
													continue;
												case 22:
													__7__wrap3 = null;
													num8 = 20;
													continue;
												case 21:
													if ((_u__).IsCompleted)
													{
														num8 = 7;
														continue;
													}
													goto case 9;
												case 13:
													if (_stream_5__3 == null)
													{
														goto case 14;
													}
													goto IL_0f3c;
												case 2:
													_stream_5__3 = null;
													num8 = 19;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
													{
														num8 = 16;
													}
													continue;
												case 3:
													goto IL_0f6c;
												case 7:
												case 15:
													(_u__).GetResult();
													num8 = 14;
													continue;
												case 24:
													_u__ = (valueTask).GetAwaiter();
													num8 = 21;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
													{
														num8 = 31;
													}
													continue;
												case 27:
													valueTask = (_stream_5__3).DisposeAsync();
													num8 = 24;
													continue;
												case 9:
													num4 = (__1__state = 3);
													num8 = 8;
													continue;
												case 0:
													goto IL_0ff1;
												case 6:
													goto IL_1002;
												case 19:
													goto IL_1166;
												}
												break;
											}
											goto IL_02ac;
											IL_0ff1:
											int num32;
											if (obj4 == null)
											{
												num32 = 36;
												goto IL_01ae;
											}
											goto IL_1002;
											IL_0f6c:
											_u__ = __u__3;
											num32 = 25;
											goto IL_01ae;
											IL_0f3c:
											num32 = 27;
											goto IL_01ae;
											IL_01b2:
											num8 = num9;
											goto IL_01b6;
											IL_01ae:
											num9 = num32;
											goto IL_01b2;
											IL_1002:
											(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj4 as global::System.Exception) ?? throw obj4)).Throw();
											num32 = 18;
											goto IL_01ae;
											IL_02ac:
											if (num4 != 3)
											{
												num8 = 28;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
												{
													num8 = 18;
												}
												goto IL_01b6;
											}
											goto IL_0f6c;
											end_IL_0192:;
										}
										finally
										{
											int num33;
											if (num4 >= 0)
											{
												num33 = 2;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
												{
													num33 = 1;
												}
												goto IL_106e;
											}
											goto IL_10fc;
											IL_10fc:
											if (__7__wrap1 == null)
											{
												num33 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
												{
													num33 = 3;
												}
												goto IL_106e;
											}
											goto IL_10a9;
											IL_10a9:
											(__7__wrap1).Dispose();
											num33 = 9;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
											{
												num33 = 2;
											}
											goto IL_106e;
											IL_106e:
											while (true)
											{
												switch (num33)
												{
												default:
													if (num34 == 992)
													{
														num33 = num34;
														continue;
													}
													break;
												case 1:
													break;
												case 0:
													goto IL_10a9;
												case 3:
													break;
												case 4:
													goto IL_10fc;
												case 2:
													break;
												}
												break;
											}
										}
										goto end_IL_00e4;
									case 3:
										break;
									case 4:
										__7__wrap1 = client;
										num5 = 2;
										continue;
									case 1:
									case 2:
									{
										int num6 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
										{
											num6 = 13;
										}
										num7 = num6;
										goto IL_00e0;
									}
									case 5:
										goto IL_1166;
									case 0:
										goto end_IL_00e4;
										IL_00e0:
										num5 = num7;
										continue;
										IL_1166:
										__7__wrap1 = null;
										num5 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto IL_0122;
									continue;
									end_IL_00e4:
									break;
								}
								goto end_IL_00ab;
								IL_0122:
								System.ArgumentNullException.ThrowIfNull(client, "client");
								num5 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
								{
									num5 = 12;
								}
								goto IL_00e4;
								end_IL_00ab:;
							}
							catch (global::System.Exception ex)
							{
								int num35 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
								{
									num35 = 2;
								}
								while (true)
								{
									switch (num35)
									{
									default:
										if (num36 == 990)
										{
											num35 = num36;
											continue;
										}
										break;
									case 0:
										(__t__builder).SetException(ex);
										num35 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
										{
											num35 = 1;
										}
										continue;
									case 2:
										break;
									case 1:
										return;
									}
									__1__state = -2;
									num35 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
									{
										num35 = 4;
									}
								}
							}
							goto case 2;
						case 3:
							(__t__builder).SetResult();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							return;
						}
						switch (num2)
						{
						case 992:
							break;
						default:
							return;
						case 11:
							vwcdmEeaHles4kN24T = __4__this;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num4 = __1__state;
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					(__t__builder).SetStateMachine(stateMachine);
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 0;
					}
				}
			}
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
								goto case 1;
							}
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num3 = 2;
							}
							continue;
						case 1:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							return;
						case 0:
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
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool MdaKnF97qAXfcfn4ohPV()
		{
			return l8X1Jw9720KLivTi1UAo == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object pK2exr97GVN5N0jlu3Us()
		{
			return l8X1Jw9720KLivTi1UAo;
		}
	}

	private readonly object GK6evDFL1R;

	private readonly TimeSpan SFWeEZ7Gt4;

	private readonly Action<string> imie29mGhB;

	private static object A0Jlq3ZCtEuP4SoypaVm;

	[MethodImpl((MethodImplOptions)8)]
	internal VwcdmEeaHles4kN24T4(rEhAA9eMY3vbR3ki0HQ authentication, TimeSpan operationTimeout, Action<string> diagnosticSink)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task FBve3paj1D(TcpClient client, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_009c->IL0012: Incompatible stack types: I4 vs O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
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
						if ((nint)obj == 9)
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								obj2 = 5;
							}
							continue;
						}
						goto end_IL_0012;
					case 1:
						break;
					case 0:
						return;
					case 2:
						obj2 = 1;
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				if ((nint)obj != 990)
				{
					return;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool FROqXVZCOKWkUXyXvBGS()
	{
		return A0Jlq3ZCtEuP4SoypaVm == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static VwcdmEeaHles4kN24T4 WVBpVGZC5JM92t5ZbKhj()
	{
		return (VwcdmEeaHles4kN24T4)A0Jlq3ZCtEuP4SoypaVm;
	}
}

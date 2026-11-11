using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace yO1vXQX9kfLYbR8wYmyM;

internal class xL8iCSX9DGsdfVCWO14G
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<byte[]> __t__builder;

		public Stream stream;

		public TimeSpan timeout;

		public CancellationToken cancellationToken;

		private CancellationTokenSource _timeoutSource_5__2;

		private CancellationTokenSource _linkedSource_5__3;

		private byte[] _header_5__4;

		private byte[] _payload_5__5;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		internal static object W9PCha9eJmSPoCZNj6RY;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Expected O, but got Unknown
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0551: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Unknown result type (might be due to invalid IL or missing references)
			//IL_0615: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0499: Unknown result type (might be due to invalid IL or missing references)
			//IL_067f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0684: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_064b: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9d->IL0a0b: Incompatible stack heights: 3 vs 1
			//IL_0ad0->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0569->IL02df: Incompatible stack heights: 2 vs 1
			//IL_062b->IL02df: Incompatible stack heights: 2 vs 1
			//IL_0636->IL02df: Incompatible stack heights: 2 vs 1
			int num = 1;
			int num4 = default;
			int num23 = default;
			int num20 = default;
			int num17 = default;
			int num10 = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _u__ = default;
			ushort num9 = default;
			ConfiguredTaskAwaitable<bool> val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out object obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
			OperationCanceledException ex = default;
			int num14 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num16 = default;
			int num19 = default;
			int num22 = default;
			int num25 = default;
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							_linkedSource_5__3 = null;
							num3 = 4;
							continue;
						case 2:
							return;
						case 5:
							break;
						case 0:
							try
							{
								int num5;
								if ((uint)num4 > 1u)
								{
									num5 = 3;
									goto IL_009a;
								}
								goto IL_0137;
								IL_0137:
								num5 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
								{
									num5 = 0;
								}
								goto IL_009a;
								IL_009a:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num23 != 11)
										{
											if (num23 == 991)
											{
												goto IL_0096;
											}
											goto case 3;
										}
										_timeoutSource_5__2 = (CancellationTokenSource)timeout;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
										{
											num5 = 1;
										}
										continue;
									case 3:
										System.ArgumentNullException.ThrowIfNull(stream, "stream");
										num5 = 2;
										continue;
									case 1:
										break;
									case 2:
										iulX9c9Nb1G(timeout);
										num23 = 11;
										goto IL_0096;
									case 0:
										{
											try
											{
												int num6;
												if ((uint)num4 > 1u)
												{
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
													{
														num6 = 2;
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
														if (num20 == 990)
														{
															num6 = num20;
															continue;
														}
														goto case 1;
													case 0:
														break;
													case 2:
														_linkedSource_5__3 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, (_timeoutSource_5__2).Token);
														num6 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
														{
															num6 = 0;
														}
														continue;
													case 1:
														try
														{
															_ = 1;
															int num7 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
															{
																num7 = 1;
															}
															while (true)
															{
																switch (num7)
																{
																default:
																	if (num17 == 989)
																	{
																		num7 = num17;
																		continue;
																	}
																	goto case 1;
																case 1:
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
																	{
																		num7 = 1;
																	}
																	continue;
																case 0:
																	try
																	{
																		int num8;
																		if (num4 != 0)
																		{
																			num8 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
																			{
																				num8 = 0;
																			}
																			goto IL_02df;
																		}
																		goto IL_04ba;
																		IL_02df:
																		while (true)
																		{
																			switch (num8)
																			{
																			case 11:
																				return;
																			case 20:
																				return;
																			default:
																				if (num10 != 39)
																				{
																					if (num10 == 1019)
																					{
																						goto IL_02db;
																					}
																					goto case 1;
																				}
																				if (&_u__ == null)
																				{
																					num8 = 28;
																					continue;
																				}
																				goto case 24;
																			case 10:
																				__u__1 = default;
																				num8 = 1;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																				{
																					num8 = 2;
																				}
																				continue;
																			case 12:
																			{
																				byte[] array = null;
																				num8 = 8;
																				continue;
																			}
																			case 23:
																				num4 = (__1__state = 1);
																				num8 = 27;
																				continue;
																			case 16:
																			case 25:
																				num9 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian((global::System.ReadOnlySpan<byte>)_header_5__4);
																				num8 = 21;
																				continue;
																			case 4:
																				num4 = (__1__state = -1);
																				num8 = 24;
																				continue;
																			case 3:
																				_header_5__4 = new byte[2];
																				num8 = 2;
																				continue;
																			case 28:
																				num4 = (__1__state = 0);
																				num8 = 31;
																				continue;
																			case 5:
																				throw new global::System.Exception("Java RPC 帧长度无效");
																			case 17:
																				_payload_5__5 = new byte[num9];
																				num8 = 7;
																				continue;
																			case 14:
																			{
																				_u__ = val;
																				int num11 = 39;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
																				{
																					num11 = 38;
																				}
																				num10 = num11;
																				goto IL_02db;
																			}
																			case 9:
																				break;
																			case 22:
																				__u__1 = default;
																				num8 = 4;
																				continue;
																			case 30:
																				_ = _u__;
																				num8 = 15;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
																				{
																					num8 = 16;
																				}
																				continue;
																			case 2:
																				mFoX9SFwB1g(stream, (global::System.Memory<byte>)_header_5__4, allowCleanEndOfStream: true, (_linkedSource_5__3).Token);
																				val = (ConfiguredTaskAwaitable<bool>)0;
																				_ = 14;
																				continue;
																			case 26:
																				__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ReadAsync_d__1>(ref _u__, ref this);
																				num8 = 7;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
																				{
																					num8 = 11;
																				}
																				continue;
																			case 8:
																				goto end_IL_02df;
																			case 13:
																				if (&_u__ == null)
																				{
																					num8 = 23;
																					continue;
																				}
																				goto case 30;
																			case 27:
																				__u__1 = _u__;
																				num8 = 6;
																				continue;
																			case 31:
																				__u__1 = _u__;
																				num8 = 15;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
																				{
																					num8 = 26;
																				}
																				continue;
																			case 7:
																				mFoX9SFwB1g(stream, (global::System.Memory<byte>)_payload_5__5, allowCleanEndOfStream: false, (_linkedSource_5__3).Token);
																				val = (ConfiguredTaskAwaitable<bool>)0;
																				_ = 29;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
																				{
																					_ = 36;
																				}
																				continue;
																			case 24:
																				if (&_u__ != null)
																				{
																					num8 = 16;
																					continue;
																				}
																				goto case 12;
																			case 29:
																				_u__ = val;
																				num8 = 13;
																				continue;
																			case 0:
																				if (num4 != 1)
																				{
																					num8 = 5;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
																					{
																						num8 = 3;
																					}
																					continue;
																				}
																				goto case 18;
																			case 18:
																				_u__ = __u__1;
																				num8 = 28;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
																				{
																					num8 = 10;
																				}
																				continue;
																			case 6:
																				__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ReadAsync_d__1>(ref _u__, ref this);
																				num8 = 20;
																				continue;
																			case 1:
																				num4 = (__1__state = -1);
																				num8 = 30;
																				continue;
																			case 21:
																				if (num9 >= 2)
																				{
																					num8 = 17;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
																					{
																						num8 = 8;
																					}
																					continue;
																				}
																				goto case 5;
																			case 15:
																			{
																				byte[] array = _payload_5__5;
																				num8 = 19;
																				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
																				{
																					num8 = 38;
																				}
																				continue;
																			}
																			case 19:
																				goto end_IL_02df;
																				IL_02db:
																				num8 = num10;
																				continue;
																			}
																			goto IL_04ba;
																			continue;
																			end_IL_02df:
																			break;
																		}
																		goto end_IL_02a7;
																		IL_04ba:
																		_u__ = __u__1;
																		num8 = 22;
																		goto IL_02df;
																		end_IL_02a7:;
																	}
																	catch (object obj) when (((Func<bool>)delegate
																	{
																		// Could not convert BlockContainer to single expression
																		obj2 = ((obj is OperationCanceledException) ? obj : null);
																		if (obj2 == null)
																		{
																			num12 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
																			{
																				num12 = 0;
																			}
																		}
																		else
																		{
																			ex = (OperationCanceledException)obj2;
																			num12 = 2;
																		}
																		while (true)
																		{
																			switch (num12)
																			{
																			default:
																				if (num14 == 990)
																				{
																					num12 = num14;
																					continue;
																				}
																				goto case 2;
																			case 2:
																				if (!(cancellationToken).IsCancellationRequested)
																				{
																					num12 = 1;
																					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
																					{
																						num12 = 4;
																					}
																					continue;
																				}
																				num13 = 0;
																				goto IL_07fa;
																			case 1:
																				num13 = ((_timeoutSource_5__2).IsCancellationRequested ? 1 : 0);
																				goto IL_07fa;
																			case 0:
																				{
																					result = 0;
																					break;
																				}
																				IL_07fa:
																				result = ((num13 != 0) ? 1 : 0);
																				break;
																			}
																			break;
																		}
																		return (byte)result != 0;
																	}).Invoke())
																	{
																		int num15 = 0;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
																		{
																			num15 = 4;
																		}
																		while (true)
																		{
																			switch (num15)
																			{
																			default:
																				if (num16 == 988)
																				{
																					goto IL_082d;
																				}
																				break;
																			case 0:
																				break;
																			}
																			break;
																			IL_082d:
																			num15 = num16;
																		}
																		_ = "Java RPC 接收帧超时";
																		throw ex;
																	}
																	break;
																}
																break;
															}
														}
														finally
														{
															int num18;
															if (num4 >= 0)
															{
																num18 = 2;
																goto IL_0890;
															}
															goto IL_08f6;
															IL_08f6:
															if (_linkedSource_5__3 != null)
															{
																num18 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
																{
																	num18 = 7;
																}
																goto IL_0890;
															}
															goto end_IL_086c;
															IL_0890:
															while (true)
															{
																switch (num18)
																{
																default:
																	if (num19 == 991)
																	{
																		num18 = num19;
																		continue;
																	}
																	goto end_IL_0890;
																case 2:
																	goto end_IL_0890;
																case 1:
																	(_linkedSource_5__3).Dispose();
																	num18 = 3;
																	continue;
																case 0:
																	break;
																case 3:
																	goto end_IL_0890;
																}
																goto IL_08f6;
																continue;
																end_IL_0890:
																break;
															}
															end_IL_086c:;
														}
														goto end_IL_01a6;
													}
													goto IL_01ca;
													continue;
													end_IL_01a6:
													break;
												}
												goto end_IL_016d;
												IL_01ca:
												num6 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
												{
													num6 = 8;
												}
												goto IL_01a6;
												end_IL_016d:;
											}
											finally
											{
												if (num4 < 0)
												{
													int num21 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
													{
														num21 = 2;
													}
													while (true)
													{
														switch (num21)
														{
														default:
															if (num22 == 990)
															{
																num21 = num22;
																continue;
															}
															break;
														case 0:
															(_timeoutSource_5__2).Dispose();
															num21 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
															{
																num21 = 1;
															}
															continue;
														case 2:
															if (_timeoutSource_5__2 != null)
															{
																num21 = 4;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
																{
																	num21 = 0;
																}
																continue;
															}
															break;
														case 1:
															break;
														}
														break;
													}
												}
											}
											goto end_IL_009a;
										}
										IL_0096:
										num5 = num23;
										continue;
									}
									goto IL_0137;
									continue;
									end_IL_009a:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num24 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
								{
									num24 = 1;
								}
								while (true)
								{
									switch (num24)
									{
									case 2:
										return;
									default:
										if (num25 != 11)
										{
											if (num25 == 991)
											{
												goto IL_0a07;
											}
											goto case 1;
										}
										_ = __t__builder;
										_ = 2;
										break;
									case 0:
										_timeoutSource_5__2 = null;
										num24 = 3;
										break;
									case 3:
										_linkedSource_5__3 = null;
										num25 = 11;
										goto IL_0a07;
									case 1:
										{
											__1__state = -2;
											num24 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
											{
												num24 = 0;
											}
											break;
										}
										IL_0a07:
										num24 = num25;
										break;
									}
								}
							}
							goto case 3;
						case 4:
							_ = __t__builder;
							_ = 2;
							continue;
						case 3:
							__1__state = -2;
							num3 = 5;
							continue;
						case 1:
							num4 = __1__state;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
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
				_timeoutSource_5__2 = null;
				num = 12;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
				{
					num = 9;
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
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
								{
									num3 = 8;
								}
								continue;
							}
							goto end_IL_0012;
						case 2:
							break;
						case 1:
							return;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
							{
								num3 = 1;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool h2Bd5i9eQBFd5YxZwf84()
		{
			return W9PCha9eJmSPoCZNj6RY == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object J1Jcf89eCLITnA2sKF2g()
		{
			return W9PCha9eJmSPoCZNj6RY;
		}
	}

	internal static object CWWrVmZAHlQ76Jb7teM4;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<byte[]?> mI0X9V7L6Qg(object stream, TimeSpan timeout, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task vaeX9YIJISN(object stream, ReadOnlyMemory<byte> payload, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__2 writeAsync_d__ = default;
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<bool> mFoX9SFwB1g(object stream, global::System.Memory<byte> buffer, bool allowCleanEndOfStream, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void iulX9c9Nb1G(TimeSpan timeout)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
						switch (num2)
						{
						case 990:
							break;
						default:
							goto end_IL_000e;
						case 9:
							goto IL_0053;
						}
						break;
					case 2:
						goto end_IL_000e;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
						IL_0053:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
						{
							num3 = 1;
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
	internal static bool KZ3gIgZAtcJIsCSYx76p()
	{
		return CWWrVmZAHlQ76Jb7teM4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xL8iCSX9DGsdfVCWO14G fXQnwCZAODodWcTWs38L()
	{
		return (xL8iCSX9DGsdfVCWO14G)CWWrVmZAHlQ76Jb7teM4;
	}
}

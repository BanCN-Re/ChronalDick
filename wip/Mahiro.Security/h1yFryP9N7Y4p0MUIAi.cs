using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using QYJtooPfnXCe6AdrjZX;
using fDAldojjppXrctUVYOJn;
using w6HELYXmXw1JesIj9gWf;

namespace ixW8SPPDRc7BNnonXQX;

internal class h1yFryP9N7Y4p0MUIAi
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadExactlyAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Stream stream;

		public global::System.Memory<byte> buffer;

		public CancellationToken cancellationToken;

		private int _offset_5__2;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1;

		internal static object PsmCCR9Abcu1p4ISxoH1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_0285: Unknown result type (might be due to invalid IL or missing references)
			//IL_0287: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Expected O, but got I4
			//IL_0175: Expected O, but got Ref
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191->IL00ce: Incompatible stack heights: 2 vs 1
			//IL_0181->IL00ce: Incompatible stack heights: 2 vs 1
			int num = 2;
			int num4 = default;
			int num7 = default;
			ConfiguredValueTaskAwaitable<int> _u__ = default;
			global::System.Threading.Tasks.ValueTask<int> valueTask = default;
			ConfiguredValueTaskAwaitable<int> val = default;
			int num6 = default;
			int num10 = default;
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
								goto case 2;
							}
							return;
						case 3:
							__1__state = -2;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							num4 = __1__state;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
							{
								num3 = 3;
							}
							continue;
						case 1:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
									{
										num5 = 10;
									}
									goto IL_00ce;
								}
								goto IL_0213;
								IL_00ce:
								while (true)
								{
									int num8;
									switch (num5)
									{
									case 4:
										return;
									default:
										if (num7 != 26)
										{
											if (num7 == 1006)
											{
												goto IL_00ca;
											}
											goto case 13;
										}
										throw new global::System.Exception("Java 本地认证连接已由远端关闭");
									case 3:
										if (&_u__ != null)
										{
											num5 = 14;
											continue;
										}
										goto case 16;
									case 15:
										_ = stream;
										valueTask = (buffer).ReadAsync((global::System.Memory<byte>)_offset_5__2, cancellationToken);
										_ = 11;
										continue;
									case 11:
										_ = valueTask;
										val = (ConfiguredValueTaskAwaitable<int>)0;
										_ = 8;
										continue;
									case 2:
										if (num6 == 0)
										{
											num8 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
											{
												num8 = 26;
											}
											goto IL_00c6;
										}
										_offset_5__2 += num6;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
										{
											num5 = 2;
										}
										continue;
									case 1:
										num4 = (__1__state = -1);
										num5 = 6;
										continue;
									case 18:
										break;
									case 12:
										__u__1 = _u__;
										num5 = 13;
										continue;
									case 7:
									case 9:
										if ((nint)_offset_5__2 >= (nint)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref buffer))
										{
											num8 = 5;
											goto IL_00c6;
										}
										goto case 15;
									case 0:
									case 10:
										_u__ = __u__1;
										num5 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
										{
											num5 = 1;
										}
										continue;
									case 17:
										__u__1 = default;
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
										{
											num5 = 1;
										}
										continue;
									case 13:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter, _ReadExactlyAsync_d__6>(ref _u__, ref this);
										num5 = 4;
										continue;
									case 16:
										num4 = (__1__state = 0);
										num5 = 12;
										continue;
									case 8:
										_u__ = val;
										num5 = 3;
										continue;
									case 6:
									case 14:
										num6 = (int)(&_u__);
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
										{
											num5 = 2;
										}
										continue;
									case 5:
										goto end_IL_00ce;
										IL_00ca:
										num5 = num7;
										continue;
										IL_00c6:
										num7 = num8;
										goto IL_00ca;
									}
									goto IL_0213;
									continue;
									end_IL_00ce:
									break;
								}
								goto end_IL_0096;
								IL_0213:
								_offset_5__2 = 0;
								num5 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
								{
									num5 = 4;
								}
								goto IL_00ce;
								end_IL_0096:;
							}
							catch (global::System.Exception ex)
							{
								int num9 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num9 = 2;
								}
								while (true)
								{
									switch (num9)
									{
									case 0:
										return;
									default:
										if (num10 != 990)
										{
											return;
										}
										num9 = num10;
										break;
									case 2:
										__1__state = -2;
										num9 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											num9 = 1;
										}
										break;
									case 1:
										(__t__builder).SetException(ex);
										num9 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
										{
											num9 = 0;
										}
										break;
									}
								}
							}
							goto case 3;
						case 0:
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
				(__t__builder).SetResult();
				num = 10;
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
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
					{
						num2 = 3;
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
							if (num2 == 9)
							{
								return;
							}
							goto IL_0031;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							goto end_IL_000e;
						case 0:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num3 = 4;
						}
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
		internal static bool TSfdON9AXaoyD6SJx1pW()
		{
			return PsmCCR9Abcu1p4ISxoH1 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Ddj6Jd9AfIFuTx2RTrLm()
		{
			return PsmCCR9Abcu1p4ISxoH1;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadRequestAsync_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<oFthKhPXnfwgYxepFLD> __t__builder;

		public Stream stream;

		public TimeSpan timeout;

		public CancellationToken cancellationToken;

		private CancellationTokenSource _operation_5__2;

		private string _gameId_5__3;

		private string _userId_5__4;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		internal static object i9XXIQ9AL9T2dHhNSsCj;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_027c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0400: Unknown result type (might be due to invalid IL or missing references)
			//IL_0405: Unknown result type (might be due to invalid IL or missing references)
			//IL_066c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0671: Unknown result type (might be due to invalid IL or missing references)
			//IL_070b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0710: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0734: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fc: Expected O, but got Ref
			//IL_0782: Expected O, but got Ref
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_055f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_058b: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_06fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e3: Expected O, but got Ref
			//IL_05c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a92->IL0a00: Incompatible stack heights: 3 vs 1
			//IL_008f->IL0008: Incompatible stack heights: 3 vs 1
			//IL_009a->IL0008: Incompatible stack heights: 3 vs 1
			//IL_04a4->IL02da: Incompatible stack heights: 2 vs 1
			//IL_0802->IL02da: Incompatible stack heights: 2 vs 1
			//IL_03ff->IL02da: Incompatible stack heights: 2 vs 1
			int num3 = default;
			int num5 = default;
			int num14 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			int num9 = default;
			ConfiguredTaskAwaitable<string> val = default;
			string text = default;
			string serverId = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
			int num11 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num13 = default;
			int num16 = default;
			int num19 = default;
			while (true)
			{
				int num = 4;
				do
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num == 11)
							{
								return;
							}
							goto end_IL_0010;
						case 2:
							__1__state = -2;
							num2 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
							{
								num2 = 1;
							}
							continue;
						case 0:
							break;
						case 1:
							_operation_5__2 = null;
							num2 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
							{
								num2 = 0;
							}
							continue;
						case 3:
							try
							{
								int num4;
								if ((uint)num3 > 2u)
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
									{
										num4 = 0;
									}
									goto IL_00fa;
								}
								goto IL_01c4;
								IL_00f6:
								num4 = num5;
								goto IL_00fa;
								IL_01c4:
								num5 = 11;
								goto IL_00f6;
								IL_00fa:
								while (true)
								{
									switch (num4)
									{
									case 1:
										System.ArgumentNullException.ThrowIfNull(stream, "stream");
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
										{
											num4 = 0;
										}
										continue;
									case 2:
										_operation_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
										num4 = 3;
										continue;
									case 0:
										TVcP8KRUqM(timeout);
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
										{
											num4 = 2;
										}
										continue;
									case 3:
										goto IL_01c4;
									}
									break;
								}
								if (num5 != 11)
								{
									if (num5 == 991)
									{
										goto IL_00f6;
									}
									goto IL_01c4;
								}
								try
								{
									int num6;
									if ((uint)num3 <= 2u)
									{
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
										{
											num6 = 5;
										}
										goto IL_0209;
									}
									goto IL_0275;
									IL_0209:
									while (true)
									{
										switch (num6)
										{
										default:
											if (num14 == 991)
											{
												num6 = num14;
												continue;
											}
											goto case 1;
										case 1:
										case 3:
											num6 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
											{
												num6 = 3;
											}
											continue;
										case 2:
											break;
										case 0:
											try
											{
												int num7;
												switch (num3)
												{
												default:
													num7 = 35;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
													{
														num7 = 35;
													}
													goto IL_02da;
												case 0:
													_u__ = __u__1;
													num7 = 11;
													goto IL_02da;
												case 1:
													goto IL_066b;
												case 2:
													goto IL_070a;
													IL_066b:
													_u__ = __u__1;
													num7 = 33;
													goto IL_02da;
													IL_02da:
													while (true)
													{
														int num8;
														switch (num7)
														{
														case 7:
															return;
														case 20:
															return;
														case 21:
															return;
														default:
															if (num9 != 43)
															{
																if (num9 == 1023)
																{
																	goto IL_02d6;
																}
																goto case 15;
															}
															dEZPSe5Spa(stream, 41, "ServerId", (_operation_5__2).Token);
															val = (ConfiguredTaskAwaitable<string>)0;
															_ = 8;
															continue;
														case 31:
															num3 = (__1__state = -1);
															num7 = 10;
															continue;
														case 23:
															break;
														case 28:
															num3 = (__1__state = 1);
															num7 = 17;
															continue;
														case 18:
															if (&_u__ == null)
															{
																num7 = 28;
																continue;
															}
															goto case 9;
														case 15:
															_gameId_5__3 = text;
															num7 = 22;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
															{
																num7 = 24;
															}
															continue;
														case 22:
															dEZPSe5Spa(stream, 10, "认证 ID", (_operation_5__2).Token);
															val = (ConfiguredTaskAwaitable<string>)0;
															_ = 4;
															continue;
														case 11:
															__u__1 = default;
															num7 = 25;
															continue;
														case 4:
															_u__ = val;
															num7 = 18;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
															{
																num7 = 12;
															}
															continue;
														case 27:
															text = (string)(&_u__);
															num7 = 15;
															continue;
														case 8:
															_u__ = val;
															num7 = 41;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
															{
																num7 = 16;
															}
															continue;
														case 34:
															num3 = (__1__state = 2);
															num7 = 26;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
															{
																num7 = 14;
															}
															continue;
														case 17:
															__u__1 = _u__;
															num7 = 13;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
															{
																num7 = 23;
															}
															continue;
														case 24:
															__u__1 = default;
															num7 = 31;
															continue;
														case 32:
														{
															oFthKhPXnfwgYxepFLD oFthKhPXnfwgYxepFLD = (oFthKhPXnfwgYxepFLD)new oFthKhPXnfwgYxepFLD(_gameId_5__3, _userId_5__4, serverId);
															num7 = 3;
															continue;
														}
														case 33:
															__u__1 = default;
															num7 = 5;
															continue;
														case 12:
															__u__1 = _u__;
															num7 = 14;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
															{
																num7 = 12;
															}
															continue;
														case 9:
															text = (string)(&_u__);
															num7 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
															{
																num7 = 0;
															}
															continue;
														case 1:
															num3 = (__1__state = 0);
															num7 = 33;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
															{
																num7 = 12;
															}
															continue;
														case 30:
															if (&_u__ == null)
															{
																num7 = 25;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
																{
																	num7 = 1;
																}
																continue;
															}
															goto case 27;
														case 2:
															goto IL_066b;
														case 16:
															if (&_u__ == null)
															{
																num7 = 39;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
																{
																	num7 = 34;
																}
																continue;
															}
															goto case 10;
														case 19:
															__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ReadRequestAsync_d__1>(ref _u__, ref this);
															num7 = 30;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
															{
																num7 = 21;
															}
															continue;
														case 13:
															__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ReadRequestAsync_d__1>(ref _u__, ref this);
															num7 = 20;
															continue;
														case 26:
															__u__1 = _u__;
															num7 = 19;
															continue;
														case 29:
															goto IL_070a;
														case 6:
															_u__ = val;
															num7 = 30;
															continue;
														case 5:
															num3 = (__1__state = -1);
															num7 = 7;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
															{
																num7 = 9;
															}
															continue;
														case 25:
															num3 = (__1__state = -1);
															num7 = 27;
															continue;
														case 10:
															serverId = (string)(&_u__);
															num8 = 32;
															goto IL_02d2;
														case 0:
															_userId_5__4 = text;
															num8 = 43;
															goto IL_02d2;
														case 14:
															__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ReadRequestAsync_d__1>(ref _u__, ref this);
															num7 = 7;
															continue;
														case 35:
															dEZPSe5Spa(stream, 19, "游戏 ID", (_operation_5__2).Token);
															val = (ConfiguredTaskAwaitable<string>)0;
															_ = 6;
															continue;
														case 3:
															goto end_IL_0298;
															IL_02d2:
															num9 = num8;
															goto IL_02d6;
															IL_02d6:
															num7 = num9;
															continue;
														}
														break;
													}
													goto case 0;
													IL_070a:
													_u__ = __u__1;
													num7 = 24;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
													{
														num7 = 15;
													}
													goto IL_02da;
													end_IL_0298:
													break;
												}
											}
											catch (object obj) when (((Func<bool>)delegate
											{
												// Could not convert BlockContainer to single expression
												if (!(obj is OperationCanceledException))
												{
													num10 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
													{
														num10 = 1;
													}
												}
												else
												{
													num10 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
													{
														num10 = 5;
													}
												}
												while (true)
												{
													switch (num10)
													{
													default:
														if (num11 == 989)
														{
															goto IL_0845;
														}
														goto case 0;
													case 1:
														result = 0;
														break;
													case 0:
														result = ((!(cancellationToken).IsCancellationRequested) ? 1 : 0);
														break;
													}
													break;
													IL_0845:
													num10 = num11;
												}
												return (byte)result != 0;
											}).Invoke())
											{
												int num12 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
												{
													num12 = 0;
												}
												while (true)
												{
													switch (num12)
													{
													default:
														if (num13 == 988)
														{
															goto IL_08d5;
														}
														break;
													case 0:
														break;
													}
													break;
													IL_08d5:
													num12 = num13;
												}
												throw new global::System.Exception("Java 本地认证请求读取超时");
											}
											goto end_IL_0209;
										}
										goto IL_0275;
										continue;
										end_IL_0209:
										break;
									}
									goto end_IL_01d0;
									IL_0275:
									(_operation_5__2).CancelAfter(timeout);
									num6 = 3;
									goto IL_0209;
									end_IL_01d0:;
								}
								finally
								{
									if (num3 < 0)
									{
										int num15 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num15 = 1;
										}
										while (true)
										{
											switch (num15)
											{
											default:
												if (num16 == 991)
												{
													num15 = num16;
													continue;
												}
												break;
											case 2:
												break;
											case 3:
												(_operation_5__2).Dispose();
												num15 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
												{
													num15 = 0;
												}
												continue;
											case 1:
												if (_operation_5__2 == null)
												{
													num15 = 2;
													continue;
												}
												goto case 3;
											case 0:
												break;
											}
											break;
										}
									}
								}
							}
							catch (global::System.Exception)
							{
								int num17 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
								{
									num17 = 2;
								}
								while (true)
								{
									switch (num17)
									{
									case 1:
										return;
									default:
										if (num19 != 10)
										{
											if (num19 == 990)
											{
												goto IL_09fc;
											}
											goto case 2;
										}
										_ = __t__builder;
										_ = 1;
										break;
									case 2:
										__1__state = -2;
										num17 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
										{
											num17 = 5;
										}
										break;
									case 0:
										{
											_operation_5__2 = null;
											int num18 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
											{
												num18 = 10;
											}
											num19 = num18;
											goto IL_09fc;
										}
										IL_09fc:
										num17 = num19;
										break;
									}
								}
							}
							goto case 2;
						case 4:
							num3 = __1__state;
							num2 = 3;
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
				while (num == 992);
				_ = __t__builder;
				_ = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
				{
					_ = 11;
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
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							goto end_IL_000e;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num3 = 2;
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool a61UxR9AjxRbs6lJOUAk()
		{
			return i9XXIQ9AL9T2dHhNSsCj == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object yxVG3a9AZK0MykTrwbKO()
		{
			return i9XXIQ9AL9T2dHhNSsCj;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WriteRequestAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Stream stream;

		public oFthKhPXnfwgYxepFLD request;

		public CancellationToken cancellationToken;

		private object __u__1;

		private static object bAb2i49AVGNouWll8WAe;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_02ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_0446: Unknown result type (might be due to invalid IL or missing references)
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0152: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_0500: Unknown result type (might be due to invalid IL or missing references)
			//IL_0502: Unknown result type (might be due to invalid IL or missing references)
			//IL_04da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_041e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0423: Unknown result type (might be due to invalid IL or missing references)
			//IL_020e: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_047e: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num4 = default;
			object _u__ = default;
			int num6 = default;
			ConfiguredTaskAwaitable val = default;
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
								int num7;
								switch (num4)
								{
								default:
									num5 = 27;
									goto IL_006e;
								case 1:
									_u__ = __u__1;
									num7 = 13;
									goto IL_0076;
								case 0:
									goto IL_02c9;
								case 2:
									goto IL_02ff;
									IL_006e:
									num6 = num5;
									goto IL_0072;
									IL_0072:
									num7 = num6;
									goto IL_0076;
									IL_0076:
									while (true)
									{
										switch (num7)
										{
										case 3:
											val = (HbfPcmTm86(stream, request.GameId, cancellationToken)).ConfigureAwait(false);
											num7 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
											{
												num7 = 18;
											}
											continue;
										case 12:
											goto end_IL_0076;
										case 2:
											num4 = (__1__state = 2);
											num7 = 14;
											continue;
										case 1:
											__t__builder.AwaitUnsafeOnCompleted<object, _WriteRequestAsync_d__2>(ref _u__, ref this);
											num7 = 17;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
											{
												num7 = 36;
											}
											continue;
										case 11:
											goto IL_01cb;
										case 24:
											if ((_u__).IsCompleted)
											{
												num7 = 28;
												continue;
											}
											goto case 2;
										case 33:
											goto IL_01fc;
										case 34:
											goto IL_022f;
										case 25:
											if ((_u__).IsCompleted)
											{
												num7 = 29;
												continue;
											}
											goto case 10;
										case 18:
											_u__ = val;
											num7 = 34;
											continue;
										case 23:
										case 29:
											(_u__).GetResult();
											num7 = 33;
											continue;
										case 8:
											num4 = (__1__state = 0);
											num7 = 16;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
											{
												num7 = 0;
											}
											continue;
										case 31:
											__u__1 = default;
											num7 = 7;
											continue;
										case 35:
											goto IL_02c9;
										case 9:
											goto IL_02ff;
										case 7:
											num4 = (__1__state = -1);
											num7 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
											{
												num7 = 9;
											}
											continue;
										case 10:
											num4 = (__1__state = 1);
											num7 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
											{
												num7 = 31;
											}
											continue;
										case 15:
											num4 = (__1__state = -1);
											num7 = 23;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
											{
												num7 = 23;
											}
											continue;
										case 5:
										case 28:
											(_u__).GetResult();
											num7 = 19;
											continue;
										case 14:
											goto IL_03c6;
										case 20:
											return;
										case 32:
											val = (HbfPcmTm86(stream, request.UserId, cancellationToken)).ConfigureAwait(false);
											num7 = 26;
											continue;
										case 13:
											__u__1 = default;
											num7 = 15;
											continue;
										case 0:
											__u__1 = _u__;
											num7 = 16;
											continue;
										case 17:
											return;
										case 26:
											_u__ = val;
											num7 = 25;
											continue;
										case 30:
											goto IL_0499;
										case 6:
											__u__1 = default;
											num7 = 21;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
											{
												num7 = 15;
											}
											continue;
										case 4:
											__u__1 = _u__;
											num7 = 24;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
											{
												num7 = 1;
											}
											continue;
										case 36:
											__t__builder.AwaitUnsafeOnCompleted<object, _WriteRequestAsync_d__2>(ref _u__, ref this);
											num7 = 20;
											continue;
										case 21:
											num4 = (__1__state = -1);
											num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
											{
												num7 = 6;
											}
											continue;
										case 27:
											goto IL_0567;
										case 22:
											return;
										case 16:
											__t__builder.AwaitUnsafeOnCompleted<object, _WriteRequestAsync_d__2>(ref _u__, ref this);
											num7 = 22;
											continue;
										case 19:
											goto end_IL_0049;
										}
										if (num6 != 44)
										{
											if (num6 == 1024)
											{
												goto IL_0072;
											}
											goto IL_022f;
										}
										_u__ = val;
										num7 = 24;
										continue;
										IL_022f:
										if ((_u__).IsCompleted)
										{
											goto IL_01cb;
										}
										goto IL_0240;
										IL_01cb:
										(_u__).GetResult();
										num7 = 32;
										continue;
										end_IL_0076:
										break;
									}
									goto case 1;
									IL_0567:
									System.ArgumentNullException.ThrowIfNull(stream, "stream");
									num5 = 30;
									goto IL_006e;
									IL_0499:
									System.ArgumentNullException.ThrowIfNull(request, "request");
									num5 = 3;
									goto IL_006e;
									IL_03c6:
									__u__1 = _u__;
									num5 = 36;
									goto IL_006e;
									IL_02ff:
									_u__ = __u__1;
									num7 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
									{
										num7 = 6;
									}
									goto IL_0076;
									IL_02c9:
									_u__ = __u__1;
									num7 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num7 = 31;
									}
									goto IL_0076;
									IL_0240:
									num5 = 8;
									goto IL_006e;
									IL_01fc:
									val = (HbfPcmTm86(stream, request.ServerId, cancellationToken)).ConfigureAwait(false);
									num5 = 44;
									goto IL_006e;
									end_IL_0049:
									break;
								}
							}
							catch (global::System.Exception ex)
							{
								int num8 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num8 = 0;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											num8 = num9;
											continue;
										}
										break;
									case 2:
										(__t__builder).SetException(ex);
										num8 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											num8 = 1;
										}
										continue;
									case 0:
										break;
									case 1:
										return;
									}
									__1__state = -2;
									num8 = 2;
								}
							}
							goto case 0;
						case 0:
							__1__state = -2;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num3 = 3;
							}
							continue;
						case 3:
							(__t__builder).SetResult();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							break;
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
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
					{
						num2 = 4;
					}
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
								goto case 1;
							}
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							break;
						case 2:
							num3 = 1;
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
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool uTXxaZ9AYw88Eb98u7KS()
		{
			return bAb2i49AVGNouWll8WAe == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object wGfnmg9AStRCk1WIU9SG()
		{
			return bAb2i49AVGNouWll8WAe;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WriteStatusAsync_d__3 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public Stream stream;

		public TimeSpan timeout;

		public uint status;

		public CancellationToken cancellationToken;

		private CancellationTokenSource _operation_5__2;

		private object __u__1;

		private object __u__2;

		internal static object tKaNVe9AcNCOHQMAlnZ0;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0685: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0584: Unknown result type (might be due to invalid IL or missing references)
			//IL_0599: Unknown result type (might be due to invalid IL or missing references)
			//IL_059e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0496: Unknown result type (might be due to invalid IL or missing references)
			//IL_049b: Unknown result type (might be due to invalid IL or missing references)
			//IL_061b: Unknown result type (might be due to invalid IL or missing references)
			//IL_042b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0562: Unknown result type (might be due to invalid IL or missing references)
			//IL_0564: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_047d: Unknown result type (might be due to invalid IL or missing references)
			//IL_047f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0442: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num4 = default;
			int num17 = default;
			byte[] array = default;
			int num14 = default;
			object _u__ = default;
			int num8 = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			object _u__2 = default;
			ConfiguredValueTaskAwaitable val2 = default;
			ConfiguredTaskAwaitable val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
			int num11 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num13 = default;
			int num16 = default;
			int num20 = default;
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
								goto case 3;
							}
							return;
						case 0:
							break;
						case 3:
							_operation_5__2 = null;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
							{
								num3 = 5;
							}
							continue;
						case 4:
							__1__state = -2;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
							{
								num3 = 10;
							}
							continue;
						case 2:
							num4 = __1__state;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							try
							{
								int num5;
								if ((uint)num4 > 1u)
								{
									num5 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
									{
										num5 = 1;
									}
									goto IL_0113;
								}
								goto IL_01a3;
								IL_0113:
								while (true)
								{
									switch (num5)
									{
									default:
										if (num17 == 13)
										{
											break;
										}
										if (num17 == 993)
										{
											goto IL_010f;
										}
										goto case 3;
									case 5:
										System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian((global::System.Span<byte>)array, status);
										num5 = 3;
										continue;
									case 3:
									{
										_operation_5__2 = System.Threading.CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
										int num18 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
										{
											num18 = 13;
										}
										num17 = num18;
										goto IL_010f;
									}
									case 1:
										System.ArgumentNullException.ThrowIfNull(stream, "stream");
										num5 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num5 = 4;
										}
										continue;
									case 0:
										TVcP8KRUqM(timeout);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
										{
											num5 = 4;
										}
										continue;
									case 4:
										array = new byte[4];
										num5 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
										{
											num5 = 5;
										}
										continue;
									case 2:
										{
											try
											{
												int num6;
												if ((uint)num4 <= 1u)
												{
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
													{
														num6 = 10;
													}
													goto IL_0289;
												}
												goto IL_02b5;
												IL_0289:
												while (true)
												{
													switch (num6)
													{
													default:
														if (num14 == 992)
														{
															num6 = num14;
															continue;
														}
														goto end_IL_0289;
													case 2:
														break;
													case 0:
													case 1:
														num6 = 4;
														continue;
													case 4:
														try
														{
															int num7;
															if (num4 != 0)
															{
																num7 = 2;
																goto IL_0319;
															}
															goto IL_0684;
															IL_0684:
															_u__ = __u__1;
															num7 = 19;
															goto IL_0319;
															IL_0319:
															while (true)
															{
																int num9;
																switch (num7)
																{
																case 6:
																	return;
																case 15:
																	return;
																default:
																	if (num8 != 32)
																	{
																		if (num8 == 1012)
																		{
																			goto IL_0315;
																		}
																		goto case 17;
																	}
																	goto end_IL_0319;
																case 23:
																	valueTask = (stream).WriteAsync((ReadOnlyMemory<byte>)array, (_operation_5__2).Token);
																	num7 = 23;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
																	{
																		num7 = 1;
																	}
																	continue;
																case 9:
																	__t__builder.AwaitUnsafeOnCompleted<object, _WriteStatusAsync_d__3>(ref _u__, ref this);
																	num9 = 15;
																	goto IL_0311;
																case 10:
																case 24:
																	(_u__).GetResult();
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
																	{
																		num7 = 11;
																	}
																	continue;
																case 7:
																	_u__2 = __u__2;
																	num7 = 22;
																	continue;
																case 22:
																	__u__2 = default;
																	num7 = 21;
																	continue;
																case 8:
																	if ((_u__).IsCompleted)
																	{
																		num7 = 24;
																		continue;
																	}
																	goto case 20;
																case 16:
																	__u__2 = _u__2;
																	num9 = 3;
																	goto IL_0311;
																case 1:
																	val2 = (valueTask).ConfigureAwait(false);
																	num7 = 4;
																	continue;
																case 19:
																	__u__1 = default;
																	num7 = 18;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
																	{
																		num7 = 30;
																	}
																	continue;
																case 2:
																	if (num4 != 1)
																	{
																		num7 = 23;
																		continue;
																	}
																	goto case 7;
																case 20:
																	num4 = (__1__state = 0);
																	num7 = 0;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
																	{
																		num7 = 11;
																	}
																	continue;
																case 21:
																	num4 = (__1__state = -1);
																	num7 = 17;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
																	{
																		num7 = 31;
																	}
																	continue;
																case 17:
																	(_u__2).GetResult();
																	num9 = 17;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
																	{
																		num9 = 32;
																	}
																	goto IL_0311;
																case 11:
																	__u__1 = _u__;
																	num7 = 9;
																	continue;
																case 0:
																	val = ((stream).FlushAsync((_operation_5__2).Token)).ConfigureAwait(false);
																	num7 = 20;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea != 0)
																	{
																		num7 = 12;
																	}
																	continue;
																case 5:
																	if (!(_u__2).IsCompleted)
																	{
																		num7 = 8;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
																		{
																			num7 = 13;
																		}
																		continue;
																	}
																	goto case 17;
																case 18:
																	num4 = (__1__state = -1);
																	num7 = 26;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
																	{
																		num7 = 10;
																	}
																	continue;
																case 4:
																	_u__ = val2;
																	num7 = 8;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
																	{
																		num7 = 0;
																	}
																	continue;
																case 14:
																	break;
																case 13:
																	num4 = (__1__state = 1);
																	num7 = 16;
																	continue;
																case 12:
																	_u__2 = val;
																	num7 = 5;
																	continue;
																case 3:
																	{
																		__t__builder.AwaitUnsafeOnCompleted<object, _WriteStatusAsync_d__3>(ref _u__2, ref this);
																		num7 = 28;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
																		{
																			num7 = 6;
																		}
																		continue;
																	}
																	IL_0311:
																	num8 = num9;
																	goto IL_0315;
																	IL_0315:
																	num7 = num8;
																	continue;
																}
																goto IL_0684;
																continue;
																end_IL_0319:
																break;
															}
														}
														catch (object obj) when (((Func<bool>)delegate
														{
															// Could not convert BlockContainer to single expression
															if (!(obj is OperationCanceledException))
															{
																num10 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
																{
																	num10 = 0;
																}
															}
															else
															{
																num10 = 1;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
																{
																	num10 = 3;
																}
															}
															while (true)
															{
																switch (num10)
																{
																default:
																	if (num11 == 989)
																	{
																		goto IL_0724;
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
																IL_0724:
																num10 = num11;
															}
															return (byte)result != 0;
														}).Invoke())
														{
															int num12 = 1;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
															{
																num12 = 0;
															}
															while (true)
															{
																switch (num12)
																{
																default:
																	if (num13 == 988)
																	{
																		goto IL_07b4;
																	}
																	break;
																case 0:
																	break;
																}
																break;
																IL_07b4:
																num12 = num13;
															}
															throw new global::System.Exception("Java 本地认证响应写入超时");
														}
														goto end_IL_0289;
													case 3:
														goto end_IL_0289;
													}
													goto IL_02b5;
													continue;
													end_IL_0289:
													break;
												}
												goto end_IL_0250;
												IL_02b5:
												(_operation_5__2).CancelAfter(timeout);
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
												{
													num6 = 10;
												}
												goto IL_0289;
												end_IL_0250:;
											}
											finally
											{
												int num15;
												if (num4 >= 0)
												{
													num15 = 2;
													goto IL_0848;
												}
												goto IL_08c3;
												IL_08c3:
												if (_operation_5__2 != null)
												{
													num15 = 3;
													goto IL_0848;
												}
												goto end_IL_0824;
												IL_0848:
												while (true)
												{
													switch (num15)
													{
													default:
														if (num16 == 991)
														{
															num15 = num16;
															continue;
														}
														goto end_IL_0848;
													case 3:
														(_operation_5__2).Dispose();
														num15 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
														{
															num15 = 0;
														}
														continue;
													case 2:
														goto end_IL_0848;
													case 1:
														break;
													case 0:
														goto end_IL_0848;
													}
													goto IL_08c3;
													continue;
													end_IL_0848:
													break;
												}
												end_IL_0824:;
											}
											goto end_IL_0113;
										}
										IL_010f:
										num5 = num17;
										continue;
									}
									goto IL_01a3;
									continue;
									end_IL_0113:
									break;
								}
								goto end_IL_00da;
								IL_01a3:
								num5 = 2;
								goto IL_0113;
								end_IL_00da:;
							}
							catch (global::System.Exception ex)
							{
								int num19 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
								{
									num19 = 1;
								}
								while (true)
								{
									switch (num19)
									{
									default:
										if (num20 == 10)
										{
											return;
										}
										if (num20 != 990)
										{
											break;
										}
										goto IL_0908;
									case 2:
										(__t__builder).SetException(ex);
										num20 = 10;
										goto IL_0908;
									case 1:
										__1__state = -2;
										num19 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
										{
											num19 = 0;
										}
										continue;
									case 0:
										break;
										IL_0908:
										num19 = num20;
										continue;
									}
									_operation_5__2 = null;
									num19 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
									{
										num19 = 2;
									}
								}
							}
							goto case 4;
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
				(__t__builder).SetResult();
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
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					(__t__builder).SetStateMachine(stateMachine);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
					{
						num2 = 0;
					}
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
							if (num2 == 9)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto IL_0031;
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool BrC3TK9A08oLJuGCFvSK()
		{
			return tKaNVe9AcNCOHQMAlnZ0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object fkkvMZ9A8q4t4XUZ8f6a()
		{
			return tKaNVe9AcNCOHQMAlnZ0;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _WriteStringAsync_d__5 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public string value;

		public Stream stream;

		public CancellationToken cancellationToken;

		private byte[] _bytes_5__2;

		private object __u__1;

		private static object EP0moT9Ayw5IDMIhehRO;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_03de: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_048d: Unknown result type (might be due to invalid IL or missing references)
			//IL_048f: Unknown result type (might be due to invalid IL or missing references)
			//IL_050d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0437: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0374: Unknown result type (might be due to invalid IL or missing references)
			//IL_0379: Unknown result type (might be due to invalid IL or missing references)
			//IL_038b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0200: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num4 = default;
			object _u__ = default;
			int num7 = default;
			byte[] array = default;
			ConfiguredValueTaskAwaitable val = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0010;
								}
								goto case 1;
							}
							_bytes_5__2 = null;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
							{
								num3 = 3;
							}
							continue;
						case 4:
							return;
						case 1:
							num4 = __1__state;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							(__t__builder).SetResult();
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num3 = 7;
							}
							continue;
						case 2:
							break;
						case 0:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 23;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
									{
										num5 = 31;
									}
									goto IL_0112;
								}
								goto IL_03ef;
								IL_03ef:
								if (num4 != 1)
								{
									num5 = 26;
									goto IL_0112;
								}
								goto IL_03dd;
								IL_03dd:
								_u__ = __u__1;
								num5 = 22;
								goto IL_0112;
								IL_0112:
								while (true)
								{
									int num6;
									switch (num5)
									{
									case 8:
										return;
									default:
										if (num7 == 38)
										{
											return;
										}
										if (num7 != 1018)
										{
											break;
										}
										goto IL_010e;
									case 15:
										num4 = (__1__state = 1);
										num5 = 10;
										continue;
									case 30:
										System.Buffers.Binary.BinaryPrimitives.WriteInt32LittleEndian((global::System.Span<byte>)array, _bytes_5__2.Length);
										num5 = 28;
										continue;
									case 29:
										_u__ = val;
										num5 = 4;
										continue;
									case 28:
										valueTask = (stream).WriteAsync((ReadOnlyMemory<byte>)array, cancellationToken);
										num5 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
										{
											num5 = 16;
										}
										continue;
									case 7:
										num4 = (__1__state = -1);
										num5 = 14;
										continue;
									case 4:
										if (!(_u__).IsCompleted)
										{
											num6 = 17;
											goto IL_010a;
										}
										goto case 25;
									case 20:
										array = new byte[4];
										num5 = 30;
										continue;
									case 9:
										__t__builder.AwaitUnsafeOnCompleted<object, _WriteStringAsync_d__5>(ref _u__, ref this);
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
										{
											num5 = 13;
										}
										continue;
									case 6:
										_u__ = val;
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
										{
											num5 = 1;
										}
										continue;
									case 17:
										num4 = (__1__state = 0);
										num5 = 12;
										continue;
									case 12:
										__u__1 = _u__;
										num5 = 13;
										continue;
									case 24:
										_bytes_5__2 = (U3yPy85Y7Z).GetBytes(value);
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
										{
											num5 = 18;
										}
										continue;
									case 21:
									case 23:
										_u__ = __u__1;
										num5 = 11;
										continue;
									case 22:
										__u__1 = default;
										num5 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
										{
											num5 = 7;
										}
										continue;
									case 13:
										__t__builder.AwaitUnsafeOnCompleted<object, _WriteStringAsync_d__5>(ref _u__, ref this);
										num6 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
										{
											num6 = 38;
										}
										goto IL_010a;
									case 19:
										break;
									case 5:
										goto IL_03ef;
									case 16:
										val = (valueTask).ConfigureAwait(false);
										num5 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
										{
											num5 = 29;
										}
										continue;
									case 18:
										val = (valueTask).ConfigureAwait(false);
										num5 = 6;
										continue;
									case 2:
										num4 = (__1__state = -1);
										num5 = 25;
										continue;
									case 1:
										if ((_u__).IsCompleted)
										{
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
											{
												num5 = 12;
											}
											continue;
										}
										goto case 15;
									case 10:
										__u__1 = _u__;
										num5 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
										{
											num5 = 9;
										}
										continue;
									case 27:
										valueTask = (stream).WriteAsync((ReadOnlyMemory<byte>)_bytes_5__2, cancellationToken);
										num5 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
										{
											num5 = 20;
										}
										continue;
									case 0:
									case 14:
										(_u__).GetResult();
										num5 = 3;
										continue;
									case 11:
										__u__1 = default;
										num5 = 2;
										continue;
									case 26:
										System.ArgumentNullException.ThrowIfNull(value, "value");
										num5 = 24;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
										{
											num5 = 32;
										}
										continue;
									case 25:
										(_u__).GetResult();
										num6 = 27;
										goto IL_010a;
									case 3:
										goto end_IL_00da;
										IL_010a:
										num7 = num6;
										goto IL_010e;
										IL_010e:
										num5 = num7;
										continue;
									}
									break;
								}
								goto IL_03dd;
								end_IL_00da:;
							}
							catch (global::System.Exception ex)
							{
								int num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num8 = 7;
								}
								while (true)
								{
									switch (num8)
									{
									case 1:
										return;
									default:
										if (num9 != 10)
										{
											if (num9 == 990)
											{
												goto IL_05b7;
											}
											goto case 0;
										}
										_bytes_5__2 = null;
										num8 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
										{
											num8 = 0;
										}
										break;
									case 0:
										(__t__builder).SetException(ex);
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
										{
											num8 = 3;
										}
										break;
									case 2:
										{
											__1__state = -2;
											num9 = 10;
											goto IL_05b7;
										}
										IL_05b7:
										num8 = num9;
										break;
									}
								}
							}
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
				__1__state = -2;
				num = 11;
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
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num2 = 0;
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
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num3 = 6;
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 4;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool q5BJX39AWJSWQ2q1soqa()
		{
			return EP0moT9Ayw5IDMIhehRO == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object qq1T6N9AJ3Ym1v4HOyi0()
		{
			return EP0moT9Ayw5IDMIhehRO;
		}
	}

	private static readonly object U3yPy85Y7Z;

	private static object Uup9PtZCFWLoo36RDc4P;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<oFthKhPXnfwgYxepFLD> FW9PkFADcY(object stream, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.timeout = timeout;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_ReadRequestAsync_d__1*)12)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task Mu7PVYxp9X(object stream, object request, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		_ = 4;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f;
		((AsyncTaskMethodBuilder)10).AwaitUnsafeOnCompleted<object, PTx9B7XmbAjQ09k3dePr._RequestConnectionAsync_d__3>(ref *(object*)(&obj.__t__builder), ref *(PTx9B7XmbAjQ09k3dePr._RequestConnectionAsync_d__3*)(&obj));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task fclPYSVpoo(object stream, uint status, TimeSpan timeout, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<string> dEZPSe5Spa(object stream, int maximumBytes, object fieldName, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task HbfPcmTm86(object stream, object value, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task WOOP0XmGe4(object stream, global::System.Memory<byte> buffer, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void TVcP8KRUqM(TimeSpan timeout)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VWlJUgZCsOats4saNJMl()
	{
		return Uup9PtZCFWLoo36RDc4P == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static h1yFryP9N7Y4p0MUIAi k88V5ZZCTcsST6ewS6Gl()
	{
		return (h1yFryP9N7Y4p0MUIAi)Uup9PtZCFWLoo36RDc4P;
	}
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using bOy3QQfPwq6ccKPkNqjf;
using fDAldojjppXrctUVYOJn;
using xCSvFsfPtZQHpr1knb4k;

namespace uVHsNBPG3JHxZKQTLaI;

internal sealed class EojBdgPqGhtC3Ay4HpO
{
	[CompilerGenerated]
	private class __O_45
	{
		public static Func<char, bool> _0___IsHexDigit;

		private static __O_45 XGLgm09APfL7oxQJ9yds;

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
							return;
						case 0:
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool EhDDEp9AxaoM47KyTZmD()
		{
			return XGLgm09APfL7oxQJ9yds == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_45 uo6tWy9AF7OhjNeadmmw()
		{
			return XGLgm09APfL7oxQJ9yds;
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class __c_163
	{
		public static __c_163 __9;

		public static Func<string, global::System.DateTime> __9__12_0;

		internal static __c_163 JhAN4t9As18hQyM43gqw;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 3;
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
									goto end_IL_0012;
								}
								goto case 3;
							}
							return;
						case 3:
							num3 = 2;
							continue;
						case 0:
							break;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
							continue;
						case 4:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 7;
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
				__9 = (__c_163)new __c_163();
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_163()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.DateTime y4ofGusinEV(string path)
		{
			return System.IO.Directory.GetLastWriteTimeUtc(path);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aVmqCh9ATS0CIH3IvLIR()
		{
			return JhAN4t9As18hQyM43gqw == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_163 FOsQmj9ANTMJSDN1oepc()
		{
			return JhAN4t9As18hQyM43gqw;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _CreateFileEntryAsync_d__9 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<PPhC6UfPHoxMRrHIKpta> __t__builder;

		public string root;

		public string path;

		public CancellationToken cancellationToken;

		public string source;

		private string _fullPath_5__2;

		private FileStream _stream_5__3;

		private object __7__wrap3;

		private int __7__wrap4;

		private PPhC6UfPHoxMRrHIKpta __7__wrap5;

		private ConfiguredValueTaskAwaitable<byte[]>.ConfiguredValueTaskAwaiter __u__1;

		private ValueTaskAwaiter __u__2;

		private static object yuZGEf9AMqsJ9fJqNXWQ;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
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
						case 1:
							goto end_IL_000e;
						case 0:
							return;
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num3 = 4;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
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
		internal static bool XjbvON9ApIyTuAxOsQCi()
		{
			return yuZGEf9AMqsJ9fJqNXWQ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object Wxh1bK9AuphR4nqCORAv()
		{
			return yuZGEf9AMqsJ9fJqNXWQ;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _LoadValidAsync_d__6 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<B1TmcCfPRdfmACRd0FyW> __t__builder;

		public EojBdgPqGhtC3Ay4HpO __4__this;

		public string userId;

		public string serverId;

		public string launcherVersion;

		public string gameVersion;

		public CancellationToken cancellationToken;

		private string _directory_5__2;

		private B1TmcCfPRdfmACRd0FyW _manifest_5__3;

		private FileStream _stream_5__4;

		private object __7__wrap4;

		private int __7__wrap5;

		private ConfiguredValueTaskAwaitable<B1TmcCfPRdfmACRd0FyW?>.ConfiguredValueTaskAwaiter __u__1;

		private ValueTaskAwaiter __u__2;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__3;

		internal static object VuW8gC9AaiMbS8kFx3RC;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//IL_004c->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0057->IL0010: Incompatible stack heights: 3 vs 1
			int num = 1;
			do
			{
				while (true)
				{
					switch (num)
					{
					case 1:
						_ = __t__builder;
						_ = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							_ = 0;
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
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto end_IL_0012;
						case 0:
							return;
						case 2:
							break;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num3 = 8;
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
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool uaFfTf9A1lLpaoYa9uZ5()
		{
			return VuW8gC9AaiMbS8kFx3RC == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object QjcUcj9A3CUVKKaslJXP()
		{
			return VuW8gC9AaiMbS8kFx3RC;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SaveAsync_d__7 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder __t__builder;

		public B1TmcCfPRdfmACRd0FyW manifest;

		public EojBdgPqGhtC3Ay4HpO __4__this;

		public CancellationToken cancellationToken;

		private string _finalPath_5__2;

		private string _temporaryPath_5__3;

		private FileStream _stream_5__4;

		private object __7__wrap4;

		private int __7__wrap5;

		private object __u__1;

		private ValueTaskAwaiter __u__2;

		private static object lsigjJ9AvKWcj9mvIUig;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0349: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_030c: Unknown result type (might be due to invalid IL or missing references)
			//IL_030e: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Expected O, but got I4
			//IL_043f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0444: Unknown result type (might be due to invalid IL or missing references)
			//IL_08c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_080e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0813: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b06: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_056b: Unknown result type (might be due to invalid IL or missing references)
			//IL_056d: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Unknown result type (might be due to invalid IL or missing references)
			//IL_066b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0670: Unknown result type (might be due to invalid IL or missing references)
			//IL_0692: Unknown result type (might be due to invalid IL or missing references)
			//IL_0694: Unknown result type (might be due to invalid IL or missing references)
			//IL_0748: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_0609: Unknown result type (might be due to invalid IL or missing references)
			//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0716: Unknown result type (might be due to invalid IL or missing references)
			//IL_071b: Unknown result type (might be due to invalid IL or missing references)
			//IL_07b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_07cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a6->IL027d: Incompatible stack heights: 6 vs 1
			int num = 2;
			EojBdgPqGhtC3Ay4HpO eojBdgPqGhtC3Ay4HpO = default;
			int num4 = default;
			int num17 = default;
			string text = default;
			int num8 = default;
			ValueTaskAwaiter _u__ = default;
			global::System.Threading.Tasks.ValueTask valueTask = default;
			object obj = default;
			int num10 = default;
			object _u__2 = default;
			ConfiguredTaskAwaitable val = default;
			int num13 = default;
			int num16 = default;
			int num19 = default;
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
							eojBdgPqGhtC3Ay4HpO = __4__this;
							num3 = 3;
							continue;
						case 4:
							(__t__builder).SetResult();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
							{
								num3 = 5;
							}
							continue;
						case 3:
							try
							{
								int num5;
								if ((uint)num4 <= 2u)
								{
									num5 = 16;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num5 = 3;
									}
									goto IL_00b3;
								}
								goto IL_0148;
								IL_00b3:
								while (true)
								{
									int num6;
									switch (num5)
									{
									default:
									{
										if (num17 != 18)
										{
											if (num17 == 998)
											{
												goto IL_00af;
											}
											goto case 3;
										}
										string text2 = _finalPath_5__2;
										string text3 = ".tmp-";
										Guid val2 = System.Guid.NewGuid();
										_temporaryPath_5__3 = string.Concat(text2, text3, (val2).ToString("N"));
										num6 = 6;
										goto IL_00ab;
									}
									case 3:
									case 6:
										num5 = 2;
										continue;
									case 0:
										_finalPath_5__2 = System.IO.Path.Combine(text, "manifest.json");
										num6 = 18;
										goto IL_00ab;
									case 4:
										break;
									case 5:
										System.IO.Directory.CreateDirectory(text);
										num5 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
										{
											num5 = 0;
										}
										continue;
									case 7:
										if (string.Equals(manifest.SignatureProvider, "s1gin-java-v1", (StringComparison)4))
										{
											num5 = 8;
											continue;
										}
										goto case 1;
									case 9:
										if (manifest.SchemaVersion == 3)
										{
											num5 = 13;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
											{
												num5 = 7;
											}
											continue;
										}
										goto case 1;
									case 2:
										try
										{
											int num7;
											if ((uint)num4 <= 1u)
											{
												num7 = 21;
												goto IL_027d;
											}
											goto IL_03d9;
											IL_0279:
											num7 = num8;
											goto IL_027d;
											IL_027d:
											while (true)
											{
												switch (num7)
												{
												case 7:
													__u__2 = _u__;
													num7 = 23;
													continue;
												case 15:
													__7__wrap4 = null;
													num7 = 9;
													continue;
												case 22:
													goto IL_032e;
												case 2:
													_u__ = (valueTask).GetAwaiter();
													num7 = 14;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
													{
														num7 = 13;
													}
													continue;
												case 14:
													goto IL_036f;
												case 5:
													valueTask = (_stream_5__4).DisposeAsync();
													num7 = 2;
													continue;
												case 12:
													goto end_IL_027d;
												case 9:
													_stream_5__4 = null;
													num7 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
													{
														num7 = 11;
													}
													continue;
												case 23:
													__t__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter, _SaveAsync_d__7>(ref _u__, ref this);
													num7 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
													{
														num7 = 7;
													}
													continue;
												case 16:
													goto IL_043e;
												case 21:
												case 25:
													num7 = 17;
													continue;
												case 20:
													obj = __7__wrap4;
													num7 = 3;
													continue;
												case 8:
													_ = _temporaryPath_5__3;
													_ = 1;
													_ = 2;
													_ = 0;
													global::System.Runtime.CompilerServices.Unsafe.Write(&((_SaveAsync_d__7*)16384)->_stream_5__4, (object)(-1073741824));
													_ = 10;
													continue;
												case 18:
												case 19:
													(_u__).GetResult();
													num7 = 20;
													continue;
												case 17:
													try
													{
														int num9;
														if (num4 == 0)
														{
															num9 = 7;
															goto IL_04d8;
														}
														goto IL_07d7;
														IL_0557:
														if (num10 == 1012)
														{
															goto IL_04dc;
														}
														goto IL_05a6;
														IL_04d8:
														num10 = num9;
														goto IL_04dc;
														IL_04dc:
														int num11 = num10;
														goto IL_04e0;
														IL_04e0:
														while (true)
														{
															switch (num11)
															{
															case 2:
																__u__1 = _u__2;
																num11 = 6;
																continue;
															case 23:
																num4 = (__1__state = 0);
																num11 = 9;
																continue;
															case 1:
															case 24:
																(_u__2).GetResult();
																num11 = 10;
																continue;
															case 22:
																goto end_IL_04e0;
															case 5:
																num4 = (__1__state = 1);
																num11 = 2;
																continue;
															case 20:
																return;
															case 8:
																return;
															case 18:
																__u__1 = default;
																num11 = 0;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
																{
																	num11 = 21;
																}
																continue;
															case 15:
																if (!(_u__2).IsCompleted)
																{
																	goto case 5;
																}
																goto IL_063f;
															case 3:
																val = (JsonSerializer.SerializeAsync<B1TmcCfPRdfmACRd0FyW>((Stream)(object)_stream_5__4, manifest, (JsonSerializerOptions)wryxkZmfjX, cancellationToken)).ConfigureAwait(false);
																num11 = 19;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
																{
																	num11 = 16;
																}
																continue;
															case 9:
																__u__1 = _u__2;
																num11 = 14;
																continue;
															case 6:
																__t__builder.AwaitUnsafeOnCompleted<object, _SaveAsync_d__7>(ref _u__2, ref this);
																num11 = 20;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
																{
																	num11 = 8;
																}
																continue;
															case 19:
																__u__1 = default;
																num11 = 17;
																continue;
															case 4:
																if (!(_u__2).IsCompleted)
																{
																	num11 = 23;
																	continue;
																}
																goto end_IL_04e0;
															case 17:
																num4 = (__1__state = -1);
																num11 = 24;
																continue;
															case 7:
															case 21:
																_u__2 = __u__1;
																num11 = 18;
																continue;
															case 11:
																_u__2 = val;
																num11 = 15;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
																{
																	num11 = 18;
																}
																continue;
															case 14:
																__t__builder.AwaitUnsafeOnCompleted<object, _SaveAsync_d__7>(ref _u__2, ref this);
																num11 = 5;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
																{
																	num11 = 20;
																}
																continue;
															case 0:
																goto IL_0796;
															case 12:
																goto IL_07d7;
															case 16:
																_u__2 = val;
																num11 = 12;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
																{
																	num11 = 4;
																}
																continue;
															case 13:
																goto IL_080d;
															case 10:
																goto end_IL_04bd;
															}
															if (num10 == 32)
															{
																val = ((_stream_5__4).FlushAsync(cancellationToken)).ConfigureAwait(false);
																num11 = 11;
																continue;
															}
															goto IL_0557;
															continue;
															end_IL_04e0:
															break;
														}
														goto IL_05a6;
														IL_0796:
														num4 = (__1__state = -1);
														num9 = 22;
														goto IL_04d8;
														IL_07d7:
														if (num4 != 1)
														{
															num11 = 3;
															goto IL_04e0;
														}
														goto IL_080d;
														IL_063f:
														num9 = 1;
														goto IL_04d8;
														IL_080d:
														_u__2 = __u__1;
														num9 = 19;
														goto IL_04d8;
														IL_05a6:
														(_u__2).GetResult();
														num9 = 32;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
														{
															num9 = 20;
														}
														goto IL_04d8;
														end_IL_04bd:;
													}
													catch (object obj2)
													{
														obj = obj2;
														int num12 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
														{
															num12 = 1;
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
																__7__wrap4 = obj;
																num12 = 6;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
																{
																	num12 = 0;
																}
																continue;
															case 0:
																break;
															}
															break;
														}
													}
													goto case 13;
												case 0:
													__7__wrap5 = 0;
													num7 = 25;
													continue;
												case 11:
													System.IO.File.Move(_temporaryPath_5__3, _finalPath_5__2, true);
													num7 = 4;
													continue;
												case 1:
													num4 = (__1__state = -1);
													num7 = 18;
													continue;
												case 6:
													return;
												case 13:
													if (_stream_5__4 != null)
													{
														num7 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
														{
															num7 = 11;
														}
														continue;
													}
													goto case 20;
												case 3:
													if (obj != null)
													{
														num7 = 24;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
														{
															num7 = 19;
														}
														continue;
													}
													goto case 15;
												case 10:
													__7__wrap4 = null;
													num7 = 28;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
													{
														num7 = 0;
													}
													continue;
												case 24:
													goto IL_09a3;
												case 4:
													goto end_IL_0259;
												}
												if (num8 != 33)
												{
													if (num8 == 1013)
													{
														goto IL_0279;
													}
													goto IL_036f;
												}
												__u__2 = default;
												num7 = 28;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
												{
													num7 = 1;
												}
												continue;
												IL_09a3:
												(System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture((obj as global::System.Exception) ?? throw obj)).Throw();
												num7 = 15;
												continue;
												IL_032e:
												num4 = (__1__state = 2);
												num7 = 7;
												continue;
												IL_036f:
												if ((_u__).IsCompleted)
												{
													num7 = 19;
													continue;
												}
												goto IL_032e;
												continue;
												end_IL_027d:
												break;
											}
											goto IL_03d9;
											IL_03d9:
											if (num4 != 2)
											{
												num7 = 8;
												goto IL_027d;
											}
											goto IL_043e;
											IL_043e:
											_u__ = __u__2;
											int num14 = 16;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
											{
												num14 = 33;
											}
											num8 = num14;
											goto IL_0279;
											end_IL_0259:;
										}
										finally
										{
											if (num4 < 0)
											{
												int num15 = 3;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
												{
													num15 = 1;
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
													case 1:
														br8xjU7o1F(_temporaryPath_5__3);
														num15 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
														{
															num15 = 0;
														}
														continue;
													case 0:
														break;
													}
													break;
												}
											}
										}
										goto end_IL_00b3;
									case 1:
										throw new global::System.Exception("Java 认证资源清单无效");
									case 8:
										text = ((bnHA9vxvBiUJqO7FLm4)eojBdgPqGhtC3Ay4HpO.DfIxVN2h8w).WRxxqoBZht(manifest.UserId, manifest.ServerId, manifest.LauncherVersion, manifest.GameVersion);
										num6 = 5;
										goto IL_00ab;
									case 10:
										goto end_IL_00b3;
										IL_00ab:
										num17 = num6;
										goto IL_00af;
										IL_00af:
										num5 = num17;
										continue;
									}
									goto IL_0148;
									continue;
									end_IL_00b3:
									break;
								}
								goto end_IL_007a;
								IL_0148:
								System.ArgumentNullException.ThrowIfNull(manifest, "manifest");
								num5 = 9;
								goto IL_00b3;
								end_IL_007a:;
							}
							catch (global::System.Exception ex)
							{
								int num18 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
								{
									num18 = 1;
								}
								while (true)
								{
									switch (num18)
									{
									default:
										if (num19 == 990)
										{
											num18 = num19;
											continue;
										}
										break;
									case 1:
										__1__state = -2;
										num18 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
										{
											num18 = 8;
										}
										continue;
									case 0:
										break;
									case 2:
										return;
									}
									(__t__builder).SetException(ex);
									num18 = 2;
								}
							}
							goto case 1;
						case 0:
							return;
						case 1:
							__1__state = -2;
							num3 = 4;
							continue;
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
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
					{
						num2 = 2;
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
						case 2:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 2;
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
				{
					num = 7;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TwTjNP9AEWRb8Xr7cMK3()
		{
			return lsigjJ9AvKWcj9mvIUig == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object nTy4mg9A2VAb19yMqQgR()
		{
			return lsigjJ9AvKWcj9mvIUig;
		}
	}

	private static readonly object wryxkZmfjX;

	private readonly object DfIxVN2h8w;

	internal static object VRFT7cZ4bjqvgHA0ALrX;

	[MethodImpl((MethodImplOptions)8)]
	internal EojBdgPqGhtC3Ay4HpO(bnHA9vxvBiUJqO7FLm4 paths)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<B1TmcCfPRdfmACRd0FyW?> W1vPiSPKnl(string userId, string serverId, string launcherVersion, string gameVersion, CancellationToken cancellationToken)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__1__state = -1;
		_ = 8;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_LoadValidAsync_d__6*)15)->__t__builder, ref obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task DnMPnKPOUr(B1TmcCfPRdfmACRd0FyW manifest, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void zolPzOug8u(string userId, string serverId, string launcherVersion, string gameVersion)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_005f->IL0010: Incompatible stack types: I4 vs O
		//IL_006a->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				case 1:
				{
					string text = ((bnHA9vxvBiUJqO7FLm4)DfIxVN2h8w).WRxxqoBZht(userId, serverId, launcherVersion, gameVersion);
					kcKxLplVZ2(text);
					aWZxfwuDxu(text);
					obj2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
					{
						obj2 = 6;
					}
					continue;
				}
				case 0:
					return;
				}
				break;
			}
		}
		while ((nint)obj == 989);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<PPhC6UfPHoxMRrHIKpta> f6txbBvL1Z(object root, object path, object source, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		object obj = default;
		obj.cancellationToken = cancellationToken;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<bool> aYNxXrybP5(object root, global::System.Collections.Generic.IReadOnlyList<PPhC6UfPHoxMRrHIKpta>? files, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void aWZxfwuDxu(object path)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0075: Expected I4, but got O
		//IL_0056->IL0068: Incompatible stack types: I4 vs O
		//IL_0061->IL0068: Incompatible stack types: I4 vs O
		//IL_00a8->IL0068: Incompatible stack types: I4 vs O
		//IL_00b3->IL0068: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		if (!System.IO.Directory.Exists((string)path))
		{
			return;
		}
		object obj2 = 2;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
		{
			obj2 = 1;
		}
		object obj3 = default;
		while (true)
		{
			switch ((int)obj2)
			{
			case 0:
				return;
			default:
				if ((nint)obj3 == 989)
				{
					obj2 = obj3;
					continue;
				}
				break;
			case 1:
				break;
			}
			System.IO.Directory.Delete((string)path, true);
			obj2 = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
			{
				obj2 = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void kcKxLplVZ2(object destination)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void br8xjU7o1F(object path)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0075: Expected I4, but got O
		//IL_0056->IL0068: Incompatible stack types: I4 vs O
		//IL_0061->IL0068: Incompatible stack types: I4 vs O
		//IL_00a7->IL0068: Incompatible stack types: I4 vs O
		//IL_00b2->IL0068: Incompatible stack types: I4 vs O
		object obj = 1;
		do
		{
			switch ((int)obj)
			{
			default:
				continue;
			case 0:
				return;
			case 1:
				break;
			}
			break;
		}
		while ((nint)obj == 989);
		if (!System.IO.File.Exists((string)path))
		{
			return;
		}
		object obj2 = 1;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
		{
			obj2 = 5;
		}
		object obj3 = default;
		while (true)
		{
			switch ((int)obj2)
			{
			case 0:
				return;
			default:
				if ((nint)obj3 == 989)
				{
					obj2 = obj3;
					continue;
				}
				break;
			case 1:
				break;
			}
			System.IO.File.Delete((string)path);
			obj2 = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
			{
				obj2 = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JM3ZJlZ4XfrW8a7R0Zsv()
	{
		return VRFT7cZ4bjqvgHA0ALrX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static EojBdgPqGhtC3Ay4HpO XHECOXZ4f39TjJKgTn47()
	{
		return (EojBdgPqGhtC3Ay4HpO)VRFT7cZ4bjqvgHA0ALrX;
	}
}

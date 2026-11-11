using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace f5MCtYX3KQ3bmxTNKeFA;

internal sealed class BMqtYNX3dibE9UCe1e8O : IEquatable<BMqtYNX3dibE9UCe1e8O>
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadAsync_d__11 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<BMqtYNX3dibE9UCe1e8O> __t__builder;

		public string path;

		public CancellationToken token;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private static object joyoTsDZmpctkmkMtjxW;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Expected O, but got Ref
			//IL_023c: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0331: Unknown result type (might be due to invalid IL or missing references)
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_038a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d4->IL0593: Incompatible stack heights: 3 vs 1
			//IL_05df->IL0593: Incompatible stack heights: 3 vs 1
			//IL_063d->IL0008: Incompatible stack heights: 3 vs 1
			//IL_0259->IL00f4: Incompatible stack heights: 2 vs 1
			int num13 = default;
			int num4 = default;
			int num7 = default;
			ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter _u__ = default;
			ConfiguredTaskAwaitable<string> val = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
			global::System.Exception ex = default;
			int num9 = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
			bool flag = default;
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num12 = default;
			int num15 = default;
			while (true)
			{
				int num = 3;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num != 10)
							{
								if (num == 991)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							return;
						case 2:
							try
							{
								int num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num3 = 0;
								}
								while (true)
								{
									switch (num3)
									{
									default:
										if (num13 == 989)
										{
											num3 = num13;
											continue;
										}
										goto case 0;
									case 0:
										num3 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
										{
											num3 = 1;
										}
										continue;
									case 1:
										try
										{
											int num5;
											if (num4 != 0)
											{
												num5 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
												{
													num5 = 21;
												}
												goto IL_00f4;
											}
											goto IL_0259;
											IL_00f4:
											while (true)
											{
												switch (num5)
												{
												default:
													if (num7 != 25)
													{
														if (num7 == 1005)
														{
															goto IL_00f0;
														}
														goto case 3;
													}
													__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter, _ReadAsync_d__11>(ref _u__, ref this);
													num5 = 23;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
													{
														num5 = 12;
													}
													continue;
												case 4:
													num4 = (__1__state = 0);
													num5 = 8;
													continue;
												case 1:
												case 5:
												{
													BMqtYNX3dibE9UCe1e8O bMqtYNX3dibE9UCe1e8O = K61X3t95Vp7((object)(&_u__));
													num5 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
													{
														num5 = 0;
													}
													continue;
												}
												case 3:
													if ((path).Length <= 8192)
													{
														num5 = 11;
														continue;
													}
													goto case 9;
												case 9:
												case 10:
												{
													BMqtYNX3dibE9UCe1e8O bMqtYNX3dibE9UCe1e8O = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=missing");
													num5 = 17;
													continue;
												}
												case 7:
													if (!System.IO.File.Exists(path))
													{
														num5 = 12;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
														{
															num5 = 9;
														}
														continue;
													}
													goto case 3;
												case 2:
												case 11:
													System.IO.File.ReadAllTextAsync(path, token);
													val = (ConfiguredTaskAwaitable<string>)0;
													_ = 15;
													continue;
												case 13:
													break;
												case 16:
													num4 = (__1__state = -1);
													num5 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
													{
														num5 = 1;
													}
													continue;
												case 6:
													if (&_u__ != null)
													{
														num5 = 5;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
														{
															num5 = 12;
														}
														continue;
													}
													goto case 4;
												case 8:
												{
													__u__1 = _u__;
													int num6 = 25;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
													{
														num6 = 6;
													}
													num7 = num6;
													goto IL_00f0;
												}
												case 15:
													_u__ = val;
													num5 = 6;
													continue;
												case 12:
													return;
												case 17:
													goto end_IL_00f4;
												case 14:
													__u__1 = default;
													num5 = 16;
													continue;
												case 0:
													goto end_IL_00f4;
													IL_00f0:
													num5 = num7;
													continue;
												}
												goto IL_0259;
												continue;
												end_IL_00f4:
												break;
											}
											goto end_IL_00bc;
											IL_0259:
											_u__ = __u__1;
											num5 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
											{
												num5 = 15;
											}
											goto IL_00f4;
											end_IL_00bc:;
										}
										catch (object obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num8 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
												{
													num8 = 8;
												}
											}
											else
											{
												ex = obj2;
												num8 = 3;
											}
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 == 13)
													{
														goto IL_047f;
													}
													if (num9 == 993)
													{
														goto IL_03d8;
													}
													goto case 0;
												case 4:
													if (ex is UnauthorizedAccessException)
													{
														num10 = 13;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
														{
															num10 = 3;
														}
														goto IL_03d4;
													}
													goto case 1;
												case 3:
													if (!(ex is IOException))
													{
														num8 = 4;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
														{
															num8 = 0;
														}
														continue;
													}
													goto IL_047f;
												case 1:
													flag = false;
													num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
													{
														num8 = 8;
													}
													continue;
												case 5:
													result = 0;
													break;
												case 0:
												case 2:
													{
														result = (flag ? 1 : 0);
														break;
													}
													IL_03d8:
													num8 = num9;
													continue;
													IL_047f:
													flag = true;
													num10 = 2;
													goto IL_03d4;
													IL_03d4:
													num9 = num10;
													goto IL_03d8;
												}
												break;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num11 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
											{
												num11 = 0;
											}
											while (true)
											{
												switch (num11)
												{
												default:
													if (num12 == 989)
													{
														num11 = num12;
														continue;
													}
													break;
												case 0:
													break;
												case 1:
													goto end_IL_04f9;
												}
												BMqtYNX3dibE9UCe1e8O bMqtYNX3dibE9UCe1e8O = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=unreadable");
												num11 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
												{
													num11 = 2;
												}
												continue;
												end_IL_04f9:
												break;
											}
										}
										break;
									}
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num14 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
								{
									num14 = 1;
								}
								while (true)
								{
									switch (num14)
									{
									default:
										if (num15 == 990)
										{
											num14 = num15;
											continue;
										}
										break;
									case 0:
										_ = __t__builder;
										_ = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
										{
											_ = 2;
										}
										continue;
									case 1:
										break;
									case 2:
										return;
									}
									__1__state = -2;
									num14 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
									{
										num14 = 0;
									}
								}
							}
							goto case 0;
						case 1:
							break;
						case 0:
							__1__state = -2;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num2 = 9;
							}
							continue;
						case 3:
							num4 = __1__state;
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							return;
						case 2:
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
							{
								num3 = 1;
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
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool butuP5DZ7eLii9QLK1sT()
		{
			return joyoTsDZmpctkmkMtjxW == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object hy5iggDZA2V9Dd9bE6In()
		{
			return joyoTsDZmpctkmkMtjxW;
		}
	}

	[CompilerGenerated]
	private string? SliX3e00ZYB;

	[CompilerGenerated]
	private string axrX3PS7Z50;

	internal static object bD0uUdZPCuL5HfTh5qM2;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(BMqtYNX3dibE9UCe1e8O).TypeHandle);
		}
	}

	public string? Phase
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return SliX3e00ZYB;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						SliX3e00ZYB = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	public string Diagnostic
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return axrX3PS7Z50;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			do
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						axrX3PS7Z50 = value;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					break;
				}
			}
			while (num == 989);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public BMqtYNX3dibE9UCe1e8O(string? Phase, string Diagnostic)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		SliX3e00ZYB = Phase;
		axrX3PS7Z50 = Diagnostic;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<BMqtYNX3dibE9UCe1e8O> FoJX3HyKLN3(object path, CancellationToken token)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BMqtYNX3dibE9UCe1e8O K61X3t95Vp7(object json)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0880: Expected O, but got I4
		//IL_0317: Unknown result type (might be due to invalid IL or missing references)
		//IL_031d: Invalid comparison between Unknown and I4
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076b: Invalid comparison between Unknown and I4
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e8: Expected O, but got I4
		//IL_09f4->IL00bb: Incompatible stack heights: 2 vs 1
		int num = 1;
		int num3 = default;
		int num6 = default;
		string text = default;
		JsonElement val2 = default;
		string text2 = default;
		int num8 = default;
		char c = default;
		bool flag2 = default;
		BMqtYNX3dibE9UCe1e8O result = default;
		bool flag = default;
		int num10 = default;
		int num12 = default;
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)json, default(JsonDocumentOptions));
					int num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								goto IL_0078;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0078:
						num2 = num3;
					}
					try
					{
						JsonElement root = (val).RootElement;
						int num4 = 32;
						while (true)
						{
							object obj;
							int num5;
							int num7;
							string text3;
							switch (num4)
							{
							default:
								if (num6 != 56)
								{
									if (num6 == 1036)
									{
										goto IL_00bf;
									}
									goto case 17;
								}
								if ((text == "waiting"))
								{
									num4 = 10;
									continue;
								}
								goto case 2;
							case 40:
								goto end_IL_00c3;
							case 14:
								obj = null;
								goto IL_083c;
							case 29:
								if (!(root).TryGetProperty("corrected", out val2))
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
									{
										num4 = 12;
									}
									continue;
								}
								goto case 16;
							case 19:
								if (!(text2 == "setting_not_ready"))
								{
									num4 = 30;
									continue;
								}
								goto case 1;
							case 28:
								if (text2 == null)
								{
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
									{
										num4 = 42;
									}
									continue;
								}
								goto case 20;
							case 43:
								switch (num8)
								{
								case 17:
									break;
								default:
									goto IL_0306;
								case 13:
								case 16:
									goto IL_0381;
								case 18:
									goto IL_057e;
								case 19:
									goto IL_0625;
								case 12:
									goto IL_0670;
								case 15:
									goto IL_06a6;
								case 14:
									goto IL_0787;
								}
								goto case 19;
							case 16:
								num5 = (((int)(val2).ValueKind == 5) ? 1 : 0);
								break;
							case 2:
								if (!(text == "ready"))
								{
									num4 = 46;
									continue;
								}
								goto case 3;
							case 5:
								if (c != 'l')
								{
									num7 = 4;
									goto IL_00bb;
								}
								goto case 38;
							case 11:
							case 24:
							case 27:
							case 30:
							case 34:
							case 36:
							case 39:
							case 42:
							case 44:
							case 48:
								goto IL_0381;
							case 47:
								text3 = "none";
								goto IL_084a;
							case 46:
								if (!(text == "failed"))
								{
									num4 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
									{
										num4 = 6;
									}
									continue;
								}
								goto case 3;
							case 15:
								if (!(text2 == "rollback_failed"))
								{
									num4 = 23;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
									{
										num4 = 44;
									}
									continue;
								}
								goto case 1;
							case 20:
								num8 = (text2).Length;
								num7 = 43;
								goto IL_00bb;
							case 1:
							case 35:
							case 45:
								flag2 = true;
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
								{
									num4 = 52;
								}
								continue;
							case 17:
							case 18:
								if (flag2)
								{
									num4 = 26;
									continue;
								}
								goto case 14;
							case 23:
								goto IL_057e;
							case 9:
								text = QtdX3OXgIDj(root, "phase");
								num7 = 56;
								goto IL_00bb;
							case 4:
								if (c != 'r')
								{
									num4 = 27;
									continue;
								}
								goto case 15;
							case 12:
								goto IL_0625;
							case 25:
								goto IL_0670;
							case 33:
								goto IL_06a6;
							case 6:
							case 7:
								flag2 = false;
								num4 = 18;
								continue;
							case 21:
								text2 = QtdX3OXgIDj(root, "code");
								num7 = 28;
								goto IL_00bb;
							case 38:
								if (!(text2 == "login_not_ready"))
								{
									goto IL_0381;
								}
								num4 = 45;
								continue;
							case 32:
								if ((int)(root).ValueKind != 1)
								{
									num4 = 41;
									continue;
								}
								goto case 9;
							case 3:
							case 10:
								flag2 = true;
								num4 = 17;
								continue;
							case 37:
								goto IL_0787;
							case 41:
								result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=invalid");
								num4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num4 = 40;
								}
								continue;
							case 8:
							case 31:
								if (!flag2)
								{
									num4 = 47;
									continue;
								}
								text3 = text2;
								goto IL_084a;
							case 26:
								obj = text;
								goto IL_083c;
							case 0:
								num5 = 0;
								break;
							case 13:
							{
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)3;
								(defaultInterpolatedStringHandler).AppendLiteral("stage=credentials phase=");
								(defaultInterpolatedStringHandler).AppendFormatted(text ?? "unknown");
								(defaultInterpolatedStringHandler).AppendLiteral(" code=");
								(defaultInterpolatedStringHandler).AppendFormatted(text2);
								(defaultInterpolatedStringHandler).AppendLiteral(" ");
								(defaultInterpolatedStringHandler).AppendLiteral("corrected=");
								(defaultInterpolatedStringHandler).AppendFormatted(((flag).ToString()).ToLowerInvariant());
								result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)41, string.Concat((defaultInterpolatedStringHandler).ToStringAndClear(), Mw6X35NS0WP(root, "login_bytes"), Mw6X35NS0WP(root, "key_bytes")));
								_ = 22;
								goto IL_00bb;
							}
							case 22:
								goto end_IL_00c3;
								IL_057e:
								if (!(text2 == "credential_changed"))
								{
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 37;
									}
									continue;
								}
								goto case 1;
								IL_0381:
								flag2 = false;
								num4 = 31;
								continue;
								IL_0306:
								num4 = 36;
								continue;
								IL_084a:
								text2 = text3;
								num4 = 29;
								continue;
								IL_0787:
								if (!(text2 == "refresh_failed"))
								{
									goto IL_0381;
								}
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
								{
									num4 = 40;
								}
								continue;
								IL_083c:
								text = (string)obj;
								num7 = 21;
								goto IL_00bb;
								IL_06a6:
								c = (text2).Chars;
								num4 = 5;
								continue;
								IL_0670:
								if ((text2 == "probe_failed"))
								{
									num4 = 35;
									continue;
								}
								goto IL_0381;
								IL_00bb:
								num6 = num7;
								goto IL_00bf;
								IL_0625:
								if (!(text2 == "credential_mismatch"))
								{
									num4 = 19;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
									{
										num4 = 24;
									}
									continue;
								}
								goto case 1;
								IL_00bf:
								num4 = num6;
								continue;
							}
							flag = (byte)num5 != 0;
							num4 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
							{
								num4 = 13;
							}
							continue;
							end_IL_00c3:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num9 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									if (num10 == 989)
									{
										num9 = num10;
										continue;
									}
									break;
								case 1:
									(val).Dispose();
									num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
									{
										num9 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
				catch (JsonException)
				{
					int num11 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							if (num12 == 989)
							{
								num11 = num12;
								continue;
							}
							break;
						case 0:
							result = (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O((string?)null, "stage=credentials state=invalid");
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
							{
								num11 = 4;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? QtdX3OXgIDj(JsonElement root, object name)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		int num = 2;
		JsonElement val = default;
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
					goto case 2;
				case 2:
					if ((root).TryGetProperty((string)name, out val))
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 0;
				case 1:
					if ((int)(val).ValueKind != 3)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
						{
							num2 = 5;
						}
						break;
					}
					return (val).GetString();
				case 0:
					return null;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Mw6X35NS0WP(JsonElement root, object name)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool cIXX36Rh9io(StringBuilder builder)
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						(builder).Append(Phase);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 10;
						}
						continue;
					case 3:
						(builder).Append(", Diagnostic = ");
						num3 = 4;
						continue;
					case 2:
						return true;
					case 4:
						(builder).Append(Diagnostic);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 5;
						}
						continue;
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
			(builder).Append("Phase = ");
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(BMqtYNX3dibE9UCe1e8O? left, BMqtYNX3dibE9UCe1e8O? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(BMqtYNX3dibE9UCe1e8O? left, BMqtYNX3dibE9UCe1e8O? right)
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
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 3:
					return ((BMqtYNX3dibE9UCe1e8O)left).Equals((BMqtYNX3dibE9UCe1e8O?)right);
				case 2:
					return false;
				case 1:
					if (left == right)
					{
						return true;
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
					{
						num2 = 4;
					}
					break;
				case 0:
					if (left == null)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 3;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		return (int)((EqualityContract * -1521134295 + SliX3e00ZYB) * -1521134295 + axrX3PS7Z50);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as BMqtYNX3dibE9UCe1e8O);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(BMqtYNX3dibE9UCe1e8O? other)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public BMqtYNX3dibE9UCe1e8O RxUX3RRA2On()
	{
		return (BMqtYNX3dibE9UCe1e8O)new BMqtYNX3dibE9UCe1e8O(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private BMqtYNX3dibE9UCe1e8O(BMqtYNX3dibE9UCe1e8O original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void w1AX3wKrtl0(out string? Phase, out string Diagnostic)
	{
		//IL_0064: Expected I8, but got O
		//IL_003c: Expected I8, but got O
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
					Phase = default;
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					Diagnostic = default;
					Phase = default;
					return;
				case 1:
					break;
				}
				goto IL_005c;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_005c;
				IL_005c:
				Diagnostic = default;
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return;
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
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool MiF28eZP49GsBXYYIqiL()
	{
		return bD0uUdZPCuL5HfTh5qM2 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BMqtYNX3dibE9UCe1e8O KeV9ClZPh1EOPGoVZF2R()
	{
		return (BMqtYNX3dibE9UCe1e8O)bD0uUdZPCuL5HfTh5qM2;
	}
}

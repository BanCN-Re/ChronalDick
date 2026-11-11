using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using BCXoLCXUvJyBkqc6IRk2;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OJoUjNXoas1ZnYNAbZSE;
using XIxKxbX4yoNlyaTfGFnT;
using fDAldojjppXrctUVYOJn;

namespace RjxJbhXrbm2w7GFft9Yx;

sealed class FccDXYXUz2hreOnMHmMq : global::System.IDisposable
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadVarIntAsync_d__19 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<int?> __t__builder;

		public Stream stream;

		public CancellationToken cancellationToken;

		public FccDXYXUz2hreOnMHmMq __4__this;

		private int _value_5__2;

		private byte[] _single_5__3;

		private int _index_5__4;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1;

		internal static object voNu9L9MPK9aLLWRMtG1;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_052b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0296: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Expected O, but got I4
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Unknown result type (might be due to invalid IL or missing references)
			//IL_051e: Unknown result type (might be due to invalid IL or missing references)
			//IL_045f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0676->IL05dc: Incompatible stack heights: 3 vs 1
			//IL_0062->IL0008: Incompatible stack heights: 3 vs 1
			//IL_052a->IL00fb: Incompatible stack heights: 2 vs 1
			int num3 = default;
			FccDXYXUz2hreOnMHmMq fccDXYXUz2hreOnMHmMq = default;
			ConfiguredValueTaskAwaitable<int> _u__ = default;
			int num5 = default;
			byte b = default;
			ConfiguredValueTaskAwaitable<int> val = default;
			int num8 = default;
			global::System.Threading.Tasks.ValueTask<int> valueTask = default;
			int num10 = default;
			while (true)
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
							if (num != 12)
							{
								if (num == 993)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							return;
						case 5:
							break;
						case 1:
							num3 = __1__state;
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num2 = 0;
							}
							continue;
						case 4:
							__1__state = -2;
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num2 = 7;
							}
							continue;
						case 0:
							fccDXYXUz2hreOnMHmMq = __4__this;
							num2 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num2 = 3;
							}
							continue;
						case 3:
							try
							{
								int num4;
								if (num3 != 0)
								{
									num4 = 18;
									goto IL_00fb;
								}
								goto IL_052a;
								IL_052a:
								_u__ = __u__1;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
								{
									num4 = 34;
								}
								goto IL_00fb;
								IL_00fb:
								while (true)
								{
									int num6;
									switch (num4)
									{
									case 32:
										return;
									default:
										if (num5 != 41)
										{
											if (num5 == 1021)
											{
												goto IL_00f7;
											}
											goto case 26;
										}
										goto case 10;
									case 6:
									case 28:
										b = _single_5__3[0];
										num4 = 15;
										continue;
									case 18:
										_value_5__2 = 0;
										num4 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
										{
											num4 = 29;
										}
										continue;
									case 12:
										goto end_IL_00fb;
									case 14:
									{
										int? num7 = (int?)(object)_value_5__2;
										num4 = 12;
										continue;
									}
									case 8:
									case 17:
										if (_index_5__4 < 5)
										{
											num4 = 16;
											continue;
										}
										goto case 20;
									case 21:
									{
										int? num7 = null;
										num4 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
										{
											num4 = 3;
										}
										continue;
									}
									case 9:
										_u__ = val;
										num4 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
										{
											num4 = 15;
										}
										continue;
									case 22:
										if (&_u__ != null)
										{
											num6 = 4;
											goto IL_00f3;
										}
										goto case 30;
									case 10:
										num8 = _index_5__4;
										num4 = 11;
										continue;
									case 5:
									case 7:
										throw new global::System.Exception("Minecraft VarInt 在传输中被截断");
									case 25:
									{
										K9g5toX48c54q05F6hFX k9g5toX48c54q05F6hFX = Volatile.Read<K9g5toX48c54q05F6hFX>(fccDXYXUz2hreOnMHmMq.pQHXr0VDRG7);
										if (k9g5toX48c54q05F6hFX == null)
										{
											num6 = 28;
											goto IL_00f3;
										}
										k9g5toX48c54q05F6hFX.oGKX4W5IDQ2((global::System.Span<byte>)_single_5__3, encrypting: false);
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
										{
											num4 = 22;
										}
										continue;
									}
									case 29:
										_single_5__3 = new byte[1];
										num4 = 31;
										continue;
									case 3:
										goto end_IL_00fb;
									case 15:
										_value_5__2 |= (b & 0x7F) << 7 * _index_5__4;
										num4 = 13;
										continue;
									case 19:
										__u__1 = _u__;
										num4 = 33;
										continue;
									case 2:
										num3 = (__1__state = -1);
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
										{
											num4 = 31;
										}
										continue;
									case 11:
										_index_5__4 = num8 + 1;
										num4 = 8;
										continue;
									case 33:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter, _ReadVarIntAsync_d__19>(ref _u__, ref this);
										num6 = 32;
										goto IL_00f3;
									case 23:
										if (_index_5__4 != 0)
										{
											num4 = 13;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
											{
												num4 = 5;
											}
											continue;
										}
										goto case 21;
									case 16:
									case 27:
										valueTask = (stream).ReadAsync((global::System.Memory<byte>)_single_5__3, cancellationToken);
										num4 = 26;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
										{
											num4 = 1;
										}
										continue;
									case 13:
										if ((b & 0x80) != 0)
										{
											num6 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 != 0)
											{
												num6 = 41;
											}
											goto IL_00f3;
										}
										goto case 14;
									case 31:
										_index_5__4 = 0;
										num4 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
										{
											num4 = 20;
										}
										continue;
									case 0:
										__u__1 = default;
										num4 = 2;
										continue;
									case 30:
										num3 = (__1__state = 0);
										num4 = 19;
										continue;
									case 26:
										_ = valueTask;
										val = (ConfiguredValueTaskAwaitable<int>)0;
										_ = 9;
										continue;
									case 24:
										break;
									case 1:
									case 4:
										if (&_u__ != null)
										{
											num4 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
											{
												num4 = 25;
											}
											continue;
										}
										goto case 23;
									case 20:
										{
											throw new global::System.Exception("Minecraft VarInt 超过 5 字节限制");
										}
										IL_00f3:
										num5 = num6;
										goto IL_00f7;
										IL_00f7:
										num4 = num5;
										continue;
									}
									goto IL_052a;
									continue;
									end_IL_00fb:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num9 = 1;
								while (true)
								{
									int num11;
									switch (num9)
									{
									case 2:
										return;
									default:
										if (num10 != 10)
										{
											if (num10 != 990)
											{
												return;
											}
											goto IL_05e0;
										}
										_ = __t__builder;
										_ = 2;
										goto IL_05dc;
									case 0:
										_single_5__3 = null;
										num11 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
										{
											num11 = 10;
										}
										goto IL_05dc;
									case 1:
										{
											__1__state = -2;
											num9 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
											{
												num9 = 9;
											}
											break;
										}
										IL_05dc:
										num10 = num11;
										goto IL_05e0;
										IL_05e0:
										num9 = num10;
										break;
									}
								}
							}
							goto case 4;
						case 2:
							_single_5__3 = null;
							num2 = 5;
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
				_ = 12;
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num3 = 2;
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
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool BydIrT9Mxa5cHtHoQe5T()
		{
			return voNu9L9MPK9aLLWRMtG1 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object PgWra89MFJkRt8ak21t6()
		{
			return voNu9L9MPK9aLLWRMtG1;
		}
	}

	private readonly int D4YXrV6sM1d;

	private readonly object hAqXrYLjblq;

	private readonly object UiVXrSLxFDe;

	private readonly object LffXrc36auB;

	private K9g5toX48c54q05F6hFX? pQHXr0VDRG7;

	private K9g5toX48c54q05F6hFX? UdaXr88ItBC;

	private int NvsXryj6GB6;

	private bool dTjXrWx2uB3;

	internal static object rMdAPDZH8LWvWvdvWmCH;

	internal int CompressionThreshold
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.Threading.Volatile.Read(ref NvsXryj6GB6);
		}
	}

	internal bool EncryptionEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal FccDXYXUz2hreOnMHmMq(int maximumPacketBytes)
	{
		//IL_0020: Expected O, but got I4
		//IL_0020: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		//IL_002e: Expected O, but got I4
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		((FccDXYXUz2hreOnMHmMq)1).hAqXrYLjblq = 1;
		((FccDXYXUz2hreOnMHmMq)1).UiVXrSLxFDe = 1;
		LffXrc36auB = this;
		NvsXryj6GB6 = -1;
		int num = 4;
		int num2 = default;
		bool flag = default;
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 16)
				{
					if (num2 == 996)
					{
						goto IL_005d;
					}
					goto case 4;
				}
				_ = "maximumPacketBytes";
				throw new global::System.Exception("代理数据包上限必须为 1 KB 到 64 MB");
			case 4:
				if (maximumPacketBytes < 1024)
				{
					num = 11;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
					{
						num = 0;
					}
					continue;
				}
				goto case 2;
			case 3:
				return;
			case 2:
				if (maximumPacketBytes <= 67108864)
				{
					num = 6;
					continue;
				}
				break;
			case 6:
			case 8:
				flag = false;
				num = 15;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
				{
					num = 1;
				}
				continue;
			case 1:
			case 7:
				if (flag)
				{
					num2 = 16;
					goto IL_005d;
				}
				D4YXrV6sM1d = maximumPacketBytes;
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
				{
					num = 2;
				}
				continue;
			case 0:
			case 5:
				break;
				IL_005d:
				num = num2;
				continue;
			}
			flag = true;
			num = 7;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void HBvXrXXRovf(int threshold)
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
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 1;
					case 1:
						throw new global::System.Exception("服务器返回了无效压缩阈值");
					case 4:
						System.Threading.Volatile.Write(ref NvsXryj6GB6, threshold);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 11;
						}
						continue;
					case 3:
						if (threshold < 0)
						{
							num = 11;
							break;
						}
						goto case 0;
					case 2:
						return;
					case 0:
						if (threshold <= D4YXrV6sM1d)
						{
							num = 4;
							break;
						}
						goto case 1;
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
	internal void CndXrf25Bl7(global::System.ReadOnlySpan<byte> secret)
	{
		int num = 2;
		bool flag = default;
		object lffXrc36auB = default;
		int num5 = default;
		int num7 = default;
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
					goto case 0;
				case 1:
					flag = false;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
					{
						num2 = 5;
					}
					break;
				case 0:
					try
					{
						System.Threading.Monitor.Enter(lffXrc36auB, ref flag);
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num3 = 10;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num5 != 13)
								{
									if (num5 == 993)
									{
										goto IL_0096;
									}
									goto case 0;
								}
								UdaXr88ItBC = (K9g5toX48c54q05F6hFX?)new K9g5toX48c54q05F6hFX(secret);
								num3 = 2;
								break;
							case 5:
								System.ObjectDisposedException.ThrowIf(dTjXrWx2uB3, this);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num3 = 2;
								}
								break;
							case 1:
							case 3:
								throw new global::System.Exception("代理加密状态已经启用");
							case 0:
								if (pQHXr0VDRG7 != null)
								{
									num3 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
									{
										num3 = 1;
									}
									break;
								}
								goto case 4;
							case 4:
								if (UdaXr88ItBC == null)
								{
									pQHXr0VDRG7 = (K9g5toX48c54q05F6hFX?)new K9g5toX48c54q05F6hFX(secret);
									int num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
									{
										num4 = 12;
									}
									num5 = num4;
									goto IL_0096;
								}
								num3 = 3;
								break;
							case 2:
								return;
								IL_0096:
								num3 = num5;
								break;
							}
						}
					}
					finally
					{
						int num6;
						if (!flag)
						{
							num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								num6 = 0;
							}
							goto IL_0206;
						}
						goto IL_022a;
						IL_0206:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0202;
								}
								goto end_IL_0206;
							case 1:
								break;
							case 2:
								goto end_IL_0206;
							case 0:
								goto end_IL_0206;
							}
							goto IL_022a;
							IL_0202:
							num6 = num7;
							continue;
							end_IL_0206:
							break;
						}
						goto end_IL_01ce;
						IL_022a:
						System.Threading.Monitor.Exit(lffXrc36auB);
						num6 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
						{
							num6 = 0;
						}
						goto IL_0206;
						end_IL_01ce:;
					}
				case 2:
					lffXrc36auB = LffXrc36auB;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
					{
						num2 = 7;
					}
					break;
				case 3:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<qAftL0XU3M5I1RIneNTc?> LvxXrL355ew(Stream stream, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task BKPXrjdbSu4(Stream stream, qAftL0XU3M5I1RIneNTc packet, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__16 writeAsync_d__ = default;
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private byte[] dLdXrZimxAF(byte[] frame)
	{
		//IL_00a1: Expected O, but got I4
		//IL_060c: Expected O, but got I4
		//IL_00f4: Expected O, but got I4
		//IL_0616->IL0008: Incompatible stack heights: 4 vs 1
		int num = 8;
		byte[] subArray = default;
		int num6 = default;
		int num4 = default;
		int num8 = default;
		int num10 = default;
		int num12 = default;
		int num11 = default;
		byte[] result = default;
		int num15 = default;
		int num17 = default;
		MemoryStream val = default;
		int num18 = default;
		int bytesRead = default;
		int compressionThreshold = default;
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
						if (num2 != 22)
						{
							if (num2 == 1003)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						return subArray;
					case 6:
						try
						{
							ZLibStream val2 = (ZLibStream)(object)0;
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										goto IL_00ce;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00ce:
								num5 = num6;
							}
							try
							{
								MemoryStream val3 = (MemoryStream)(object)num4;
								int num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
								{
									num7 = 1;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										if (num8 == 988)
										{
											goto IL_0121;
										}
										break;
									case 0:
										break;
									}
									break;
									IL_0121:
									num7 = num8;
								}
								try
								{
									byte[] array = new byte[8192];
									int num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
									{
										num9 = 2;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											if (num10 != 17)
											{
												if (num10 == 997)
												{
													goto IL_017b;
												}
												goto case 1;
											}
											goto case 4;
										case 4:
											if ((val3).Length == num4)
											{
												num9 = 12;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
												{
													num9 = 2;
												}
												continue;
											}
											goto case 0;
										case 0:
											throw new global::System.Exception("Minecraft 压缩数据长度不匹配");
										case 9:
											num12 = (int)System.Math.Min(array.Length, num4 - (val3).Length);
											num9 = 6;
											continue;
										case 3:
											if (num11 == 0)
											{
												int num13 = 17;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
												{
													num13 = 7;
												}
												num10 = num13;
												goto IL_017b;
											}
											goto case 7;
										case 1:
										case 5:
											if ((val3).Length >= num4)
											{
												num9 = 4;
												continue;
											}
											goto case 9;
										case 7:
											(val3).Write(array, 0, num11);
											num9 = 5;
											continue;
										case 6:
											num11 = (val2).Read(array, 0, num12);
											num9 = 3;
											continue;
										case 2:
											if ((val2).ReadByte() == -1)
											{
												result = (val3).ToArray();
												num9 = 8;
												continue;
											}
											num9 = 14;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
											{
												num9 = 0;
											}
											continue;
										case 8:
											break;
											IL_017b:
											num9 = num10;
											continue;
										}
										break;
									}
								}
								finally
								{
									if (val3 != null)
									{
										int num14 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
										{
											num14 = 3;
										}
										while (true)
										{
											switch (num14)
											{
											default:
												if (num15 == 989)
												{
													num14 = num15;
													continue;
												}
												break;
											case 1:
												(val3).Dispose();
												num14 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
												{
													num14 = 1;
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
							finally
							{
								int num16;
								if (val2 == null)
								{
									num16 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
									{
										num16 = 0;
									}
									goto IL_03f3;
								}
								goto IL_0426;
								IL_03f3:
								while (true)
								{
									switch (num16)
									{
									default:
										if (num17 == 990)
										{
											goto IL_03ef;
										}
										break;
									case 0:
										goto end_IL_03f3;
									case 2:
										break;
									case 1:
										goto end_IL_03f3;
									}
									goto IL_0426;
									IL_03ef:
									num16 = num17;
									continue;
									end_IL_03f3:
									break;
								}
								goto end_IL_03bb;
								IL_0426:
								(val2).Dispose();
								num16 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
								{
									num16 = 1;
								}
								goto IL_03f3;
								end_IL_03bb:;
							}
						}
						finally
						{
							if (val == null)
							{
								num18 = 2;
								goto IL_0471;
							}
							goto IL_0499;
							IL_0499:
							(val).Dispose();
							int num19 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
							{
								num19 = 8;
							}
							goto IL_0475;
							IL_0471:
							num19 = num18;
							goto IL_0475;
							IL_0475:
							switch (num19)
							{
							case 1:
								goto IL_0499;
							case 2:
								goto end_IL_0452;
							case 0:
								goto end_IL_0452;
							}
							if (num18 == 990)
							{
								goto IL_0471;
							}
							goto IL_0499;
							end_IL_0452:;
						}
						goto case 10;
					case 5:
						subArray = frame[System.Range.StartAt(((System.Index)bytesRead))];
						num3 = 14;
						continue;
					case 0:
						throw new global::System.Exception("Minecraft 解压长度超出允许范围");
					case 12:
						if (num4 == 0)
						{
							num3 = 5;
							continue;
						}
						if (num4 < compressionThreshold)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						_ = frame.Length - bytesRead;
						val = (MemoryStream)(object)0;
						_ = 6;
						break;
					case 4:
					case 11:
						throw new global::System.Exception("Minecraft 数据包未遵守压缩阈值");
					case 7:
						if (compressionThreshold >= 0)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 9;
					case 1:
						throw new global::System.Exception("Minecraft 压缩数据包小于压缩阈值");
					case 9:
						return frame;
					case 13:
						num4 = YFkFTdXouTMZ2mVrHfvp.xaUXoE6nf9F((global::System.ReadOnlySpan<byte>)frame, out bytesRead);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 1;
						}
						continue;
					case 14:
						if (compressionThreshold == 0)
						{
							num3 = 11;
							continue;
						}
						goto case 15;
					case 10:
						return result;
					case 15:
						if (subArray.Length < compressionThreshold)
						{
							num = 22;
							break;
						}
						goto case 4;
					case 3:
						if (num4 >= 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								num3 = 18;
							}
							continue;
						}
						goto case 0;
					case 8:
						compressionThreshold = CompressionThreshold;
						num3 = 7;
						continue;
					case 2:
						if (num4 <= D4YXrV6sM1d)
						{
							num3 = 12;
							continue;
						}
						goto case 0;
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
	private byte[] brCXr93KhxP(byte[] packetData)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe global::System.Threading.Tasks.Task<int?> tHMXrDmPEFI(Stream stream, CancellationToken cancellationToken)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task nYAXrkSWDR7(object stream, global::System.Memory<byte> destination, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ReadExactlyAsync_d__20 readExactlyAsync_d__ = default;
		readExactlyAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 7;
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
						if (num2 != 15)
						{
							if (num2 == 996)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						dTjXrWx2uB3 = true;
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
						{
							num3 = 6;
						}
						break;
					case 4:
					case 5:
					{
						K9g5toX48c54q05F6hFX? udaXr88ItBC = UdaXr88ItBC;
						if (udaXr88ItBC == null)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num3 = 3;
							}
							break;
						}
						udaXr88ItBC.Dispose();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 10;
						}
						break;
					}
					case 7:
						if (dTjXrWx2uB3)
						{
							return;
						}
						goto end_IL_000c;
					case 1:
						return;
					case 3:
						(UiVXrSLxFDe).Dispose();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 1;
						}
						break;
					case 2:
						return;
					case 0:
					case 8:
						(hAqXrYLjblq).Dispose();
						num3 = 3;
						break;
					case 6:
					{
						K9g5toX48c54q05F6hFX? k9g5toX48c54q05F6hFX = pQHXr0VDRG7;
						if (k9g5toX48c54q05F6hFX == null)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
							{
								num3 = 4;
							}
						}
						else
						{
							k9g5toX48c54q05F6hFX.Dispose();
							num3 = 5;
						}
						break;
					}
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 15;
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
							goto case 0;
						}
						return;
					case 0:
						num3 = 2;
						continue;
					case 2:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							num3 = 4;
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GtkdMLZHywHKSnFNoxC9()
	{
		return rMdAPDZH8LWvWvdvWmCH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static FccDXYXUz2hreOnMHmMq k6Ina4ZHWYO0RKgjJHj7()
	{
		return (FccDXYXUz2hreOnMHmMq)rMdAPDZH8LWvWvdvWmCH;
	}
}

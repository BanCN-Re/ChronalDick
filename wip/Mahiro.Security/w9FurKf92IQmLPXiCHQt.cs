using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace hwr1xAf9qK1NJ7Rf6OIG;

internal class w9FurKf92IQmLPXiCHQt
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadAsync_d__1_1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<byte[]> __t__builder;

		public NetworkStream stream;

		public CancellationToken cancellationToken;

		private byte[] _header_5__2;

		private byte[] _payload_5__3;

		private ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter __u__1;

		internal static object JrT3MhD8Ye5OmkWkMf11;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
		{
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01da: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_040b: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_047b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0480: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b9->IL0584: Incompatible stack heights: 0 vs 2
			//IL_0588->IL0588: Incompatible stack heights: 3 vs 1
			//IL_0657->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0662->IL0010: Incompatible stack heights: 3 vs 1
			//IL_0525->IL00b5: Incompatible stack heights: 1 vs 2
			//IL_0288->IL00b5: Incompatible stack heights: 1 vs 2
			//IL_0417->IL00bd: Incompatible stack heights: 2 vs 1
			//IL_0179->IL00b5: Incompatible stack heights: 1 vs 2
			//IL_0162->IL00b9: Incompatible stack heights: 0 vs 1
			//IL_00bd->IL00bd: Incompatible stack heights: 2 vs 1
			int num = 4;
			int num4 = default;
			ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter _u__ = default;
			int num7 = default;
			ConfiguredTaskAwaitable<bool> val = default;
			ushort num6 = default;
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
							if (num2 != 12)
							{
								if (num2 == 993)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							_header_5__2 = null;
							num3 = 2;
							continue;
						case 5:
							break;
						case 2:
							_payload_5__3 = null;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							num4 = __1__state;
							num3 = 3;
							continue;
						case 1:
							return;
						case 3:
							try
							{
								int num5;
								if (num4 != 0)
								{
									num5 = 18;
									goto IL_00bd;
								}
								goto IL_0382;
								IL_0382:
								_u__ = __u__1;
								num5 = 31;
								goto IL_00bd;
								IL_00bd:
								while (true)
								{
									int num8;
									switch (num5)
									{
									case 16:
										return;
									case 22:
										return;
									default:
										switch (num7)
										{
										case 1020:
											continue;
										case 40:
											_u__ = val;
											num5 = 12;
											continue;
										}
										goto case 1;
									case 15:
										if (&_u__ != null)
										{
											_ = 4;
											goto IL_00b5;
										}
										goto case 25;
									case 10:
										_u__ = val;
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
										{
											num5 = 24;
										}
										continue;
									case 0:
										qFHf9nQN1OW(stream, (global::System.Memory<byte>)_payload_5__3, allowEndOfStream: false, cancellationToken);
										val = (ConfiguredTaskAwaitable<bool>)0;
										num8 = 40;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
										{
											num8 = 24;
										}
										goto IL_00b5;
									case 20:
										__u__1 = _u__;
										num5 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
										{
											num5 = 3;
										}
										continue;
									case 4:
									case 7:
										num6 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian((global::System.ReadOnlySpan<byte>)_header_5__2);
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
										{
											num5 = 1;
										}
										continue;
									case 8:
										__u__1 = _u__;
										num5 = 11;
										continue;
									case 6:
										num4 = (__1__state = 0);
										num5 = 20;
										continue;
									case 11:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ReadAsync_d__1_1>(ref _u__, ref this);
										num5 = 22;
										continue;
									case 9:
										__t__builder.AwaitUnsafeOnCompleted<ConfiguredTaskAwaitable<bool>.ConfiguredTaskAwaiter, _ReadAsync_d__1_1>(ref _u__, ref this);
										_ = 16;
										goto IL_00b5;
									case 18:
										if (num4 != 1)
										{
											num5 = 32;
											continue;
										}
										goto case 30;
									case 25:
									{
										byte[] array = null;
										num5 = 17;
										continue;
									}
									case 3:
										throw new global::System.Exception("基岩版 RPC 帧长度无效");
									case 1:
									case 28:
										_ = _u__;
										num5 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
										{
											num5 = 23;
										}
										continue;
									case 23:
									{
										byte[] array = _payload_5__3;
										num5 = 14;
										continue;
									}
									case 21:
										if (num6 != 0)
										{
											num5 = 13;
											continue;
										}
										goto case 3;
									case 24:
										if (&_u__ == null)
										{
											num5 = 6;
											continue;
										}
										goto case 15;
									case 13:
										if (num6 <= 65535)
										{
											_payload_5__3 = new byte[num6];
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
											{
												num5 = 4;
											}
										}
										else
										{
											num5 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
											{
												num5 = 3;
											}
										}
										continue;
									case 19:
										break;
									case 26:
										num4 = (__1__state = 1);
										num5 = 8;
										continue;
									case 27:
										qFHf9nQN1OW(stream, (global::System.Memory<byte>)_header_5__2, allowEndOfStream: true, cancellationToken);
										val = (ConfiguredTaskAwaitable<bool>)0;
										_ = 10;
										continue;
									case 31:
										__u__1 = default;
										num5 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
										{
											num5 = 2;
										}
										continue;
									case 5:
										num4 = (__1__state = -1);
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
										{
											num5 = 9;
										}
										continue;
									case 30:
										_u__ = __u__1;
										num5 = 32;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num5 = 29;
										}
										continue;
									case 12:
										if (&_u__ != null)
										{
											num5 = 19;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
											{
												num5 = 28;
											}
											continue;
										}
										goto case 26;
									case 29:
										__u__1 = default;
										num5 = 33;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
										{
											num5 = 5;
										}
										continue;
									case 17:
										goto end_IL_00bd;
									case 2:
										num4 = (__1__state = -1);
										_ = 15;
										goto IL_00b5;
									case 32:
										_header_5__2 = new byte[2];
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
										{
											num5 = 27;
										}
										continue;
									case 14:
										goto end_IL_00bd;
										IL_00b5:
										num7 = num8;
										continue;
									}
									goto IL_0382;
									continue;
									end_IL_00bd:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num9 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
								{
									num9 = 11;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										switch (num10)
										{
										case 11:
											return;
										case 991:
											continue;
										}
										break;
									case 2:
										_header_5__2 = null;
										num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
										{
											num9 = 3;
										}
										continue;
									case 1:
										__1__state = -2;
										num9 = 2;
										continue;
									case 0:
										_payload_5__3 = null;
										num9 = 3;
										continue;
									case 3:
										break;
									}
									_ = __t__builder;
									num10 = 11;
								}
							}
							break;
						case 0:
							_ = __t__builder;
							_ = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								_ = 12;
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
				__1__state = -2;
				num = 12;
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
								goto case 2;
							}
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
							{
								num3 = 7;
							}
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
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool efiPCbD8SiBfER4biVfH()
		{
			return JrT3MhD8Ye5OmkWkMf11 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object biCAwLD8ciKlBuEPJtWQ()
		{
			return JrT3MhD8Ye5OmkWkMf11;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadExactlyAsync_d__3_2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public NetworkStream stream;

		public global::System.Memory<byte> buffer;

		public CancellationToken cancellationToken;

		public bool allowEndOfStream;

		private int _offset_5__2;

		private ConfiguredValueTaskAwaitable<int>.ConfiguredValueTaskAwaiter __u__1;

		private static object Ka0grDD801wAo6kmLe3e;

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
							return;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
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
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
				{
					num = 8;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool y1FO3HD88A9u0igXrVxe()
		{
			return Ka0grDD801wAo6kmLe3e == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object mXIpDOD8y5udlmgeYoTF()
		{
			return Ka0grDD801wAo6kmLe3e;
		}
	}

	internal static object iQ7TlWZNgK79ltlKxf3L;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<byte[]?> T3Nf9GQlNhW(object stream, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task M9Qf9iTb0tN(object stream, ReadOnlyMemory<byte> payload, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__2_1 writeAsync_d__2_ = default;
		writeAsync_d__2_.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private unsafe static global::System.Threading.Tasks.Task<bool> qFHf9nQN1OW(object stream, global::System.Memory<byte> buffer, bool allowEndOfStream, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
							return;
						}
						goto end_IL_0012;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 6;
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool e65Ns1ZNlj0Aa7tjm32V()
	{
		return iQ7TlWZNgK79ltlKxf3L == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static w9FurKf92IQmLPXiCHQt n1cDU2ZNd3C2EXm87Ryb()
	{
		return (w9FurKf92IQmLPXiCHQt)iQ7TlWZNgK79ltlKxf3L;
	}
}

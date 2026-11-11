using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace Nf34ZbX0q71bMV7rPDRg;

internal class oE4PmrX022IluaTubmsX
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _ReadAsync_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<byte[]> __t__builder;

		public Stream stream;

		public CancellationToken cancellationToken;

		private byte[] _lengthBytes_5__2;

		private byte[] _payload_5__3;

		private object __u__1;

		private static object OV6hJc9Fde3UVykuVDaT;

		[MethodImpl((MethodImplOptions)8)]
		public void MoveNext()
		{
			//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_027b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_0459: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_042a: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0388: Unknown result type (might be due to invalid IL or missing references)
			//IL_0398: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01af: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_062e->IL057f: Incompatible stack heights: 1 vs 3
			//IL_05b8->IL0583: Incompatible stack heights: 0 vs 2
			//IL_0587->IL0587: Incompatible stack heights: 3 vs 1
			//IL_0088->IL0010: Incompatible stack heights: 3 vs 1
			int num = 2;
			int num4 = default;
			object _u__ = default;
			int num6 = default;
			ushort num8 = default;
			ConfiguredTaskAwaitable val = default;
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
							if (num2 == 12)
							{
								_ = __t__builder;
								_ = 3;
								continue;
							}
							goto IL_003b;
						case 2:
							num4 = __1__state;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num3 = 4;
							}
							continue;
						case 1:
							try
							{
								int num5;
								if (num4 == 0)
								{
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
									{
										num5 = 26;
									}
									goto IL_00c1;
								}
								goto IL_01bb;
								IL_03be:
								_u__ = __u__1;
								num5 = 11;
								goto IL_00c1;
								IL_01bb:
								if (num4 != 1)
								{
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
									{
										num5 = 4;
									}
									goto IL_00c1;
								}
								goto IL_03be;
								IL_00c1:
								while (true)
								{
									int num7;
									switch (num5)
									{
									default:
									{
										if (num6 != 40)
										{
											if (num6 == 1020)
											{
												goto IL_00bd;
											}
											goto case 12;
										}
										byte[] array = _payload_5__3;
										num5 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
										{
											num5 = 1;
										}
										continue;
									}
									case 19:
										num8 = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian((global::System.ReadOnlySpan<byte>)_lengthBytes_5__2);
										num5 = 29;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
										{
											num5 = 17;
										}
										continue;
									case 18:
										_u__ = val;
										num5 = 25;
										continue;
									case 22:
										break;
									case 28:
										_lengthBytes_5__2 = new byte[2];
										num7 = 16;
										goto IL_00b9;
									case 10:
										num4 = (__1__state = 1);
										num5 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
										{
											num5 = 5;
										}
										continue;
									case 21:
										__t__builder.AwaitUnsafeOnCompleted<object, _ReadAsync_d__0>(ref _u__, ref this);
										num5 = 2;
										continue;
									case 14:
										__u__1 = default;
										num5 = 27;
										continue;
									case 17:
										num4 = (__1__state = 0);
										num5 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
										{
											num5 = 17;
										}
										continue;
									case 7:
										_u__ = val;
										num5 = 31;
										continue;
									case 2:
										return;
									case 9:
									case 23:
										(_u__).GetResult();
										num5 = 19;
										continue;
									case 11:
										__u__1 = default;
										num5 = 15;
										continue;
									case 29:
										if (num8 != 0)
										{
											num5 = 5;
											continue;
										}
										goto case 20;
									case 20:
										throw new global::System.Exception("Java 认证响应帧长度无效");
									case 5:
										_payload_5__3 = new byte[num8];
										num5 = 24;
										continue;
									case 32:
										__t__builder.AwaitUnsafeOnCompleted<object, _ReadAsync_d__0>(ref _u__, ref this);
										num5 = 6;
										continue;
									case 0:
									case 30:
										(_u__).GetResult();
										num7 = 40;
										goto IL_00b9;
									case 16:
										val = (YFiX0zFCAPd(stream, (global::System.Memory<byte>)_lengthBytes_5__2, cancellationToken)).ConfigureAwait(false);
										num5 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num5 = 18;
										}
										continue;
									case 3:
										goto IL_03be;
									case 27:
										num4 = (__1__state = -1);
										num5 = 23;
										continue;
									case 13:
										__u__1 = _u__;
										num5 = 32;
										continue;
									case 6:
										return;
									case 12:
									case 26:
										_u__ = __u__1;
										num5 = 14;
										continue;
									case 25:
										if ((_u__).IsCompleted)
										{
											num7 = 9;
											goto IL_00b9;
										}
										goto case 17;
									case 8:
										__u__1 = _u__;
										num5 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
										{
											num5 = 26;
										}
										continue;
									case 4:
										System.ArgumentNullException.ThrowIfNull(stream, "stream");
										num5 = 22;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
										{
											num5 = 28;
										}
										continue;
									case 31:
										if ((_u__).IsCompleted)
										{
											num5 = 32;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
											{
												num5 = 0;
											}
											continue;
										}
										goto case 10;
									case 15:
										num4 = (__1__state = -1);
										num5 = 30;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
										{
											num5 = 21;
										}
										continue;
									case 24:
										val = (YFiX0zFCAPd(stream, (global::System.Memory<byte>)_payload_5__3, cancellationToken)).ConfigureAwait(false);
										num5 = 7;
										continue;
									case 1:
										goto end_IL_0089;
										IL_00bd:
										num5 = num6;
										continue;
										IL_00b9:
										num6 = num7;
										goto IL_00bd;
									}
									break;
								}
								goto IL_01bb;
								end_IL_0089:;
							}
							catch (global::System.Exception)
							{
								int num9 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num9 = 5;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										switch (num10)
										{
										case 991:
											goto end_IL_0587;
										case 11:
											return;
										}
										goto case 2;
									case 0:
										_ = __t__builder;
										goto IL_057f;
									case 2:
										_lengthBytes_5__2 = null;
										num9 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
										{
											num9 = 1;
										}
										break;
									case 1:
										_payload_5__3 = null;
										num9 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
										{
											num9 = 0;
										}
										break;
									case 3:
										{
											__1__state = -2;
											_ = 2;
											goto IL_057f;
										}
										IL_057f:
										num10 = 11;
										break;
										end_IL_0587:
										break;
									}
								}
							}
							goto case 4;
						case 3:
							return;
						case 4:
							__1__state = -2;
							num3 = 5;
							continue;
						case 0:
							goto end_IL_000c;
						case 5:
							break;
						}
						goto IL_0661;
						IL_003b:
						if (num2 == 993)
						{
							break;
						}
						goto IL_0661;
						IL_0661:
						_lengthBytes_5__2 = null;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 0;
						}
					}
					continue;
					end_IL_000c:
					break;
				}
				_payload_5__3 = null;
				num = 12;
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
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto end_IL_0012;
						case 1:
							break;
						case 2:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
							{
								num3 = 1;
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
				while (num2 == 990);
				num = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fAwbSc9FKOnJ5JypdDud()
		{
			return OV6hJc9Fde3UVykuVDaT == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object WE5IUA9FHuYdV33mA8hR()
		{
			return OV6hJc9Fde3UVykuVDaT;
		}
	}

	private static object um71TUZgIwBTnFBSZIo4;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<byte[]> vX8X0GnAefR(object stream, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task n7FX0i1RttM(object stream, ReadOnlyMemory<byte> frame, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__1 writeAsync_d__ = default;
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] Ya0X0nemKu3(global::System.ReadOnlySpan<byte> payload)
	{
		int num = 3;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task YFiX0zFCAPd(object stream, global::System.Memory<byte> buffer, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_ReadExactlyAsync_d__3_1 readExactlyAsync_d__3_ = default;
		readExactlyAsync_d__3_.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
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
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 1:
						break;
					case 2:
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool eGGrXnZgBAWxe4mVxR5X()
	{
		return um71TUZgIwBTnFBSZIo4 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oE4PmrX022IluaTubmsX T6BHvAZggSUeZeydf64F()
	{
		return (oE4PmrX022IluaTubmsX)um71TUZgIwBTnFBSZIo4;
	}
}

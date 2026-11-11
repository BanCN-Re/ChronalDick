using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using uGYGhCXK1nRsID9XQ5mf;

namespace dtsoVGXP7JuGb8t6i0dZ;

internal class c28VJqXPmkrDqFZDI1Oi
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _MatchesMd5Async_d__1 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<bool> __t__builder;

		public string path;

		public CancellationToken cancellationToken;

		public string expected;

		private FileStream _stream_5__2;

		private MD5 _md5_5__3;

		private object __7__wrap3;

		private int __7__wrap4;

		private bool __7__wrap5;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__1;

		private ValueTaskAwaiter __u__2;

		internal static object s5C90b9zGvVcuId7CgnO;

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
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
							{
								num3 = 3;
							}
							continue;
						case 0:
							break;
						case 1:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num3 = 0;
							}
							continue;
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
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool VTdEYH9ziPLggO60J3Vh()
		{
			return s5C90b9zGvVcuId7CgnO == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object MkCFgF9znIIXe87vKak0()
		{
			return s5C90b9zGvVcuId7CgnO;
		}
	}

	internal static object HAScmgZ6qm7MtVJIjQLU;

	[MethodImpl((MethodImplOptions)8)]
	internal static string fAIXPAgJfjv(global::System.ReadOnlySpan<byte> data)
	{
		ulong value = default;
		ulong value2 = default;
		ulong value3 = default;
		ulong value4 = default;
		ulong num = MEdXPHMjZOQ(value, 1) + MEdXPHMjZOQ(value2, 7) + MEdXPHMjZOQ(value3, 12) + MEdXPHMjZOQ(value4, 18);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<bool> sWaXPI2ShQM(object path, object expected, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task jghXPB1YkwQ(object sourcePath, long sourceOffset, object destination, long destinationOffset, int length, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_CopyRangeAsync_d__2 copyRangeAsync_d__ = default;
		copyRangeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong EsRXPgv1SpR(ulong accumulator, ulong input)
	{
		int num = 2;
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
					goto case 0;
				case 2:
					accumulator += (ulong)((long)input * -4417276706812531889L);
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return accumulator * 11400714785074694791uL;
				case 1:
					accumulator = MEdXPHMjZOQ(accumulator, 31);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong VE9XPl8DJnt(ulong accumulator, ulong value)
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
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					accumulator ^= EsRXPgv1SpR(0uL, value);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					return (ulong)((long)accumulator * -7046029288634856825L + -8796714831421723037L);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong tcDXPdjIG4O(global::System.ReadOnlySpan<byte> data, int offset)
	{
		//IL_0012: Expected O, but got I4
		_ = data;
		return System.Buffers.Binary.BinaryPrimitives.ReadUInt64LittleEndian((global::System.ReadOnlySpan<byte>)8);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint NVhXPK2ID1T(global::System.ReadOnlySpan<byte> data, int offset)
	{
		//IL_0012: Expected O, but got I4
		_ = data;
		return System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong MEdXPHMjZOQ(ulong value, int count)
	{
		return (value << count) | (value >> 64 - count);
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
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num3 = 1;
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
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool TIaj94Z6GYBlPXdBsHuK()
	{
		return HAScmgZ6qm7MtVJIjQLU == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static c28VJqXPmkrDqFZDI1Oi XFwGIfZ6ioZobaEJ9Qpn()
	{
		return (c28VJqXPmkrDqFZDI1Oi)HAScmgZ6qm7MtVJIjQLU;
	}
}

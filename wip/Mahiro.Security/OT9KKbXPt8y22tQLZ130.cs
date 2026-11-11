using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using dtsoVGXP7JuGb8t6i0dZ;
using fDAldojjppXrctUVYOJn;

namespace fBuYBxXPOMyUrWSb36Fu;

internal sealed class OT9KKbXPt8y22tQLZ130
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _TryReadAsync_d__2 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<byte[]> __t__builder;

		public OT9KKbXPt8y22tQLZ130 __4__this;

		public string buildCode;

		public string expectedXxh;

		public CancellationToken cancellationToken;

		private string _path_5__2;

		private ConfiguredTaskAwaitable<byte[]>.ConfiguredTaskAwaiter __u__1;

		internal static object hilbih9zzvFqEiAu9ndg;

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
								goto IL_0078;
							}
							break;
						case 2:
							goto end_IL_000e;
						case 1:
							return;
						case 0:
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							IL_0078:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num3 = 9;
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
		internal static bool GC6FIsDbb55H5oPOoBVS()
		{
			return hilbih9zzvFqEiAu9ndg == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object u43uoHDbXXrDxlilcOF5()
		{
			return hilbih9zzvFqEiAu9ndg;
		}
	}

	private readonly string? JbRXPeDpBVg;

	private static object XryaMcZ6nEn9nGivAPvX;

	[MethodImpl((MethodImplOptions)8)]
	internal OT9KKbXPt8y22tQLZ130(string? cachePath)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<byte[]?> qgQXP5jUtkw(string buildCode, string expectedXxh, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task GBCXP6dSq7y(string buildCode, string manifestXxh, byte[] bytes, CancellationToken cancellationToken)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		_WriteAsync_d__3 writeAsync_d__ = default;
		writeAsync_d__.__t__builder = System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string Te5XPRsabBH(string buildCode, string manifestXxh)
	{
		int num = 1;
		string text = default;
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
					text = System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes(string.Concat(buildCode, "\n", manifestXxh))));
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					break;
				}
				goto IL_00a6;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_00a6;
				IL_00a6:
				return System.IO.Path.Combine(JbRXPeDpBVg, string.Concat(text, ".manifest.json"));
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NFWXPwg0qbY(object path)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
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
					case 0:
						return;
					case 2:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 0;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SYRk7LZ6z6GQET5Su9JF()
	{
		return XryaMcZ6nEn9nGivAPvX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static OT9KKbXPt8y22tQLZ130 NKFNUZZRbsIh0MIMnuRT()
	{
		return (OT9KKbXPt8y22tQLZ130)XryaMcZ6nEn9nGivAPvX;
	}
}

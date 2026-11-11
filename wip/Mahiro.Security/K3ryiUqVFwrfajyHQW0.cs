using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using U3xEbuS5FxK76HaUf1b;
using fDAldojjppXrctUVYOJn;
using iFG88Vmb1p0qPpvwBpT;
using kjKrMVStekrkCnZqNlG;
using lMfI1VYvWZBMJNDrPDu;

namespace KjdeU9qYAfdlJ0S23Tv;

internal class K3ryiUqVFwrfajyHQW0
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _SendAsync_d__0 : IAsyncStateMachine
	{
		public int __1__state;

		public AsyncTaskMethodBuilder<k3bme1SOTyIb1sudW4A> __t__builder;

		public kpLhhaSH4f4durtm5lL request;

		public CancellationToken cancellationToken;

		public int hostPid;

		public SafePipeHandle pipe;

		private bool _requiresTicket_5__2;

		private string _authorization_5__3;

		private Process _process_5__4;

		private MemoryStream _stream_5__5;

		private byte[] _frame_5__6;

		private bool _held_5__7;

		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter __u__1;

		private object __u__2;

		private ConfiguredTaskAwaitable<ValueTuple<hM3QRXozIobMSJf4Wde.ltxoruf2ci5IIim8Kb7L, byte[]>>.ConfiguredTaskAwaiter __u__3;

		internal static object Yh9JQ29HCxE3OOoLBPdp;

		[MethodImpl((MethodImplOptions)8)]
		public unsafe void MoveNext()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
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
						default:
							if (num2 == 9)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_0031;
						case 2:
							goto end_IL_000e;
						case 0:
							return;
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
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num3 = 3;
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
		internal static bool w52AOL9H4AX7a4XbSB0Y()
		{
			return Yh9JQ29HCxE3OOoLBPdp == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object EJVS4c9HhCHeecCIw3pK()
		{
			return Yh9JQ29HCxE3OOoLBPdp;
		}
	}

	internal static object mDUZwKZoXJhrjQ2K2rWI;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe static global::System.Threading.Tasks.Task<k3bme1SOTyIb1sudW4A> yCyqSVpB0p(object pipe, int hostPid, object request, CancellationToken cancellationToken)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		_SendAsync_d__0 sendAsync_d__ = default;
		sendAsync_d__.hostPid = hostPid;
		global::System.Runtime.CompilerServices.Unsafe.Write(&((_SendAsync_d__0*)5)->__t__builder, ref sendAsync_d__);
		return null;
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
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						continue;
					case 2:
						return;
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
			while (num2 == 990);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool TxmZPvZofdFV266Py328()
	{
		return mDUZwKZoXJhrjQ2K2rWI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static K3ryiUqVFwrfajyHQW0 cNnGBMZoLMpxGwIxA5V3()
	{
		return (K3ryiUqVFwrfajyHQW0)mDUZwKZoXJhrjQ2K2rWI;
	}
}

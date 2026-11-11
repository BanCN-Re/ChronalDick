using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using StWYIEXu147v3eyuP7W2;
using eSYAGxfZCKRIP3ADeYqn;
using fDAldojjppXrctUVYOJn;
using hK0R8YfLqVPGirfIstVl;
using hrft8OfLNLZ7Z4DpQRng;
using lQs7SmfZ8MofeLgDpWlN;

namespace WajfiyX3u3EyY65rb2i3;

internal class BCTH6OX3p6nEmQbHtant
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass2_0_3
	{
		public VOLhfofLTIqAo1An6PXH log;

		public Process process;

		public CancellationToken cancellationToken;

		public Func<string, bool> __9__2;

		internal static __c__DisplayClass2_0_3 FVgaXJDZloaa8fL4Xi7P;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass2_0_3()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void z0bLD3LExS7(string diagnostic, bool terminal, ref __c__DisplayClass2_1 P_2)
		{
			log.rIOfLu6OO2F("local-lobby-mobile", diagnostic);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void UBZLDv4b5Wh(s2pqjHXuaJFOKmapoTQZ payload, ref __c__DisplayClass2_1 P_1, ref __c__DisplayClass2_2 P_2)
		{
			int num = 1;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool D05LDEAEjnY(string reason)
		{
			return C04X33hcLmT(process, log, reason);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool PNRYpyDZdbPw27WYMqXh()
		{
			return FVgaXJDZloaa8fL4Xi7P == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass2_0_3 VRXGyyDZKD8eA8oVTNoD()
		{
			return FVgaXJDZloaa8fL4Xi7P;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass2_1
	{
		public string previousDiagnostic;

		public int reports;

		public csem2OfL2bf6sKg3F01M executor;

		public V1NV4TfZ0HRmQ56BROEp addresses;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct __c__DisplayClass2_2
	{
		public XvqDWAfZQTQvOVR6KfaV remote;
	}

	internal static readonly TimeSpan vkMX3vK892E;

	internal static readonly TimeSpan U6iX3Ei9uqE;

	internal static object m72Y37ZPmINUtAVP5v8b;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<bool> W3nX3a8TpVA(object process, object session, object device, object deviceSeed, object log, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_PrepareAsync_d__2 prepareAsync_d__ = default(_PrepareAsync_d__2);
		prepareAsync_d__.__t__builder = AsyncTaskMethodBuilder<bool>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool lGuX31wbwHA(object stage, object exception)
	{
		Win32Exception ex = default(Win32Exception);
		int num = (ex).NativeErrorCode;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool C04X33hcLmT(object process, object log, object reason)
	{
		int num = 1;
		int num3 = default(int);
		bool flag = default(bool);
		bool result = default(bool);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					int num2;
					if (!((dynamic)(process)).HasExited)
					{
						num2 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
						{
							num2 = 4;
						}
						goto IL_0075;
					}
					goto IL_01d5;
					IL_0071:
					num2 = num3;
					goto IL_0075;
					IL_01bb:
					int num4 = (((dynamic)(process)).WaitForExit(15000) ? 1 : 0);
					goto IL_01f0;
					IL_0075:
					while (true)
					{
						switch (num2)
						{
						case 2:
						{
							string component = "local-lobby-mobile";
							global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(43, 2);
							(defaultInterpolatedStringHandler).AppendLiteral("stage=thread-termination reason=");
							(defaultInterpolatedStringHandler).AppendFormatted((string)reason);
							(defaultInterpolatedStringHandler).AppendLiteral(" completed=");
							defaultInterpolatedStringHandler.AppendFormatted<bool>(flag);
							((VOLhfofLTIqAo1An6PXH)log).rIOfLu6OO2F(component, (defaultInterpolatedStringHandler).ToStringAndClear());
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num2 = 1;
							}
							continue;
						}
						case 1:
							result = flag;
							num2 = 3;
							continue;
						case 4:
							((dynamic)(process)).Kill(true);
							num2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
							{
								num2 = 0;
							}
							continue;
						case 5:
							goto IL_01bb;
						case 0:
							goto IL_01d5;
						case 3:
							goto end_IL_0034;
						}
						break;
					}
					if (num3 != 13)
					{
						if (num3 == 993)
						{
							goto IL_0071;
						}
						goto IL_01bb;
					}
					num4 = 1;
					goto IL_01f0;
					IL_01d5:
					if (((dynamic)(process)).HasExited)
					{
						num3 = 13;
						goto IL_0071;
					}
					goto IL_01bb;
					IL_01f0:
					flag = (byte)num4 != 0;
					num2 = 2;
					goto IL_0075;
					end_IL_0034:;
				}
				catch (global::System.Exception)
				{
					int num5 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 989)
							{
								num5 = num6;
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							goto end_IL_0233;
						}
						result = false;
						num5 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num5 = 2;
						}
						continue;
						end_IL_0233:
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
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BLbqAeZP7j77QWTiJRgK()
	{
		return m72Y37ZPmINUtAVP5v8b == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static BCTH6OX3p6nEmQbHtant JvB10BZPAcwGHWPi0p1L()
	{
		return (BCTH6OX3p6nEmQbHtant)m72Y37ZPmINUtAVP5v8b;
	}
}

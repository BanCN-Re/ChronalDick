using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using AR0yDHKcbVJbe6i6hLY;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using JvgQTDcbARdEdTAk7GE;
using dcvjfggjMhe2HpqDyUf;
using fDAldojjppXrctUVYOJn;
using fIsVVndaX2MwgYmEEob;
using m5NLKNoWjf2r56bsRv4;

namespace EalDClKBE7R7DfsUjMd;

internal class eDTUdFKIG1IFKQgZTDp
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_147
	{
		public static readonly __c_147 __9;

		public static TimerCallback __9__13_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset> __9__14_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, bool> __9__15_2;

		public static Func<vNIX0hKSxIjAmGCLN6M, bool> __9__15_0;

		public static Func<vNIX0hKSxIjAmGCLN6M, DateTimeOffset> __9__15_1;

		private static __c_147 AZhpdd9rFtn9k1yNTPdQ;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_147()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
			{
				num = 2;
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
		internal void kbtfqOqR3be(object? _)
		{
			_ = U2mKd85i2c();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset bkkfq5BiqLC(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			return x.Event.LastSeenUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool YgNfq6FXINt(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0009: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			DateTimeOffset lastSeenUtc = x.Event.LastSeenUtc;
			DateTimeOffset val = System.DateTimeOffset.UtcNow;
			return (lastSeenUtc < (val).AddDays(-7.0));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool ru2fqRTJPbv(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			return (x.DueUtc <= System.DateTimeOffset.UtcNow);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset HEifqwh9CJi(vNIX0hKSxIjAmGCLN6M x)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return x.DueUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string gaPfqeqHunC()
		{
			return (System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData((System.Text.Encoding.UTF8).GetBytes((((iOp8AQoyRMUnhQ3bGRu)new iOp8AQoyRMUnhQ3bGRu()).CreateMachineRequest().Hash).Trim())))).ToLowerInvariant();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool OnVkGe9rsN2QhytRM2PB()
		{
			return AZhpdd9rFtn9k1yNTPdQ == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_147 KIMYYe9rTErM0Gw1Fcek()
		{
			return AZhpdd9rFtn9k1yNTPdQ;
		}
	}

	private static readonly object f91KKQC3Fo;

	private static readonly object egnKH0KGuw;

	private static readonly Dictionary<string, vNIX0hKSxIjAmGCLN6M> eV9KtFVfZl;

	private static readonly Dictionary<string, GidN49duOY8iHR2nUNC> EdIKOHXKTU;

	private static readonly Dictionary<string, DateTimeOffset> oB3K5D4spL;

	private static readonly object V71K6DgZim;

	private static readonly object WWEKRouoI1;

	private static DateTimeOffset OXrKw0XDSu;

	private static readonly Lazy<string> FqyKeJS4Ql;

	private static WeakReference<v5OiSQSzC8GipXkQ3VG>? dxRKPMl6jC;

	private static Timer? pPaKx3YAOk;

	private static k78QiLgLvQc95QQmDIY? RGxKFMoQKP;

	internal static object siyRQUZWNGuPBT1CSu3o;

	[MethodImpl((MethodImplOptions)8)]
	internal static extern void Bh9KgPM1Vc(object client);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void Start();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern void LipKlx6PVV(object buildId, object layoutId, object decoyId, object symbol);

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static extern global::System.Threading.Tasks.Task U2mKd85i2c();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool BWNa9PZWMYlZdn4NNVGm();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern eDTUdFKIG1IFKQgZTDp VG25N7ZWpYDL3l1ZjS8J();
}

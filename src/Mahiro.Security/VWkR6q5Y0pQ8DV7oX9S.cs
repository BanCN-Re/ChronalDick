using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using PJoWpXB7rwAmXGt51DD;
using fDAldojjppXrctUVYOJn;

namespace SAeQCk5SebpgSgglQCX;

internal class VWkR6q5Y0pQ8DV7oX9S
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass0_0_12
	{
		public List<A228j3Bm0ei4PAS7MF3> checks;

		internal static __c__DisplayClass0_0_12 In9H4O9mUXn9Z1wWIase;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass0_0_12()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
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
		internal void _Capture_b__0(nint buffer)
		{
			List<A228j3Bm0ei4PAS7MF3> obj = checks;
			string id = "environment.kernelDebugger";
			bool flag = System.Runtime.InteropServices.Marshal.ReadByte(buffer) != 0;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(20, 2);
			(defaultInterpolatedStringHandler).AppendLiteral("enabled=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(System.Runtime.InteropServices.Marshal.ReadByte(buffer));
			(defaultInterpolatedStringHandler).AppendLiteral(";notPresent=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(System.Runtime.InteropServices.Marshal.ReadByte(buffer, 1));
			obj.Add(Result(id, flag, (defaultInterpolatedStringHandler).ToStringAndClear(), "系统内核调试配置，不表示 Chronal 已被调试"));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _Capture_b__1(nint buffer)
		{
			uint num = default(uint);
			string value = default(string);
			checks.Add(Result("environment.testSigning", (num & 2) != 0, value, "系统代码完整性是否允许测试签名内容"));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void _Capture_b__2(nint buffer)
		{
			List<A228j3Bm0ei4PAS7MF3> obj = checks;
			string id = "environment.secureBoot";
			bool flag = System.Runtime.InteropServices.Marshal.ReadByte(buffer) != 0;
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(17, 2);
			(defaultInterpolatedStringHandler).AppendLiteral("enabled=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(System.Runtime.InteropServices.Marshal.ReadByte(buffer));
			(defaultInterpolatedStringHandler).AppendLiteral(";capable=");
			defaultInterpolatedStringHandler.AppendFormatted<byte>(System.Runtime.InteropServices.Marshal.ReadByte(buffer, 1));
			obj.Add(Result(id, flag, (defaultInterpolatedStringHandler).ToStringAndClear(), "Secure Boot 系统状态，仅作环境诊断"));
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool rHuW8T9mr3bZxsHOMTkc()
		{
			return In9H4O9mUXn9Z1wWIase == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass0_0_12 NADwBH9moUBVBei80erC()
		{
			return In9H4O9mUXn9Z1wWIase;
		}
	}

	private static object o7rMwGZQC2fbk4kbTQ21;

	[MethodImpl((MethodImplOptions)8)]
	internal static extern global::System.Collections.Generic.IReadOnlyList<A228j3Bm0ei4PAS7MF3> Capture();

	[MethodImpl((MethodImplOptions)8)]
	private static extern A228j3Bm0ei4PAS7MF3 Result(object id, bool flag, object value, object detail);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void ReadSystem(int informationClass, int size, Action<nint> read, List<A228j3Bm0ei4PAS7MF3> checks, object ids, bool initializeLength = false);

	[MethodImpl((MethodImplOptions)8)]
	private static extern A228j3Bm0ei4PAS7MF3 ReadVbs();

	[DllImport("ntdll.dll", ExactSpelling = true)]
	private static extern int NtQuerySystemInformation(int informationClass, nint information, uint length, out uint returnLength);

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool f6MEVtZQ4ciKCgaicXsu();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern VWkR6q5Y0pQ8DV7oX9S JgfhiwZQh3lkmeFCRWLp();
}

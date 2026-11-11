using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace uwRhO8CRVFnAu0aW8Xr;

public class LwmISJC6yaOQNTugLhy
{
	public struct UFRTibfEWKTWmAtv66DI
	{
		internal static object LPehuJ9WwglFPoOoQMHk;

		[field: CompilerGenerated]
		public string Cpu
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		public string Board
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		public string Memory
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		public string Gpu
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		public string Disk
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[field: CompilerGenerated]
		public string Os
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get;
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set;
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool iODX5M9WeqGHA9u7gTYC()
		{
			return LPehuJ9WwglFPoOoQMHk == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static object z2PUNQ9WP9AwvH1WdCfV()
		{
			return LPehuJ9WwglFPoOoQMHk;
		}
	}

	[StructLayout((LayoutKind)0, CharSet = (CharSet)4)]
	private class pWvHcnfEJ1VWyZ8un74Q
	{
		public uint LLTfEQ546g5;

		public uint i9tfECgWbXt;

		public ulong zR1fE4ItMkX;

		public ulong NAvfEhXWdvl;

		public ulong x4JfEU3WXl2;

		public ulong uWlfErUtxNf;

		public ulong BXKfEomEkU7;

		public ulong a2efEmQrq09;

		public ulong jQIfE7qkfdS;

		internal static pWvHcnfEJ1VWyZ8un74Q MR3loI9WxJkWn7EovR2j;

		[MethodImpl((MethodImplOptions)8)]
		public pWvHcnfEJ1VWyZ8un74Q()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
			{
				num = 5;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 == 989)
					{
						num = num2;
						continue;
					}
					break;
				case 1:
					return;
				case 0:
					break;
				}
				LLTfEQ546g5 = (uint)System.Runtime.InteropServices.Marshal.SizeOf(System.Type.GetTypeFromHandle(typeof(pWvHcnfEJ1VWyZ8un74Q).TypeHandle));
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
				{
					num = 3;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool tqUaLh9WFq50DgmWe0XI()
		{
			return MR3loI9WxJkWn7EovR2j == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static pWvHcnfEJ1VWyZ8un74Q wVDQyq9Wse9sglfvhgl9()
		{
			return MR3loI9WxJkWn7EovR2j;
		}
	}

	internal static object l2Yy7kZc0EqYIynmFI2S;

	[MethodImpl((MethodImplOptions)8)]
	public static extern UFRTibfEWKTWmAtv66DI CollectSpecs();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetCpuInfo();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetBoardInfo();

	[DllImport("kernel32.dll", CharSet = (CharSet)4, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GlobalMemoryStatusEx([In][Out] pWvHcnfEJ1VWyZ8un74Q lpBuffer);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetMemoryInfo();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetGpuInfo();

	[DllImport("kernel32.dll", CharSet = (CharSet)4, SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetDiskInfo();

	[MethodImpl((MethodImplOptions)8)]
	private static extern string GetOsInfo();

	[MethodImpl((MethodImplOptions)8)]
	private static extern void _cctor();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern bool IRh4r4Zc85OifHOpqqbo();

	[MethodImpl((MethodImplOptions)8)]
	internal static extern LwmISJC6yaOQNTugLhy Qek1n5ZcyNySWNjsenoN();
}

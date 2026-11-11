using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using A9qCRxfTFcpTmOPevGxU;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using ER0UXRXQN0kQZX5HdtCP;
using fDAldojjppXrctUVYOJn;

namespace MAgI4AXmSwV5xrU6UgxI;

internal sealed class gVdr5aXmYpJ1TRKfNmt8 : OTU6CSXQTVOX7sCtsWu0
{
	private enum nqQI18LXkYoFd4TK31w6
	{
		OwnerPidAll = 5
	}

	private struct WP2YT2LXVd95bSqXIjQD
	{
		internal uint gJjLXYqfhi2;

		internal uint Tk9LXSp5RBT;

		internal uint jlDLXcUI0FY;

		internal uint weyLX0YycKx;

		internal uint JnRLX8A7vIj;

		internal uint yn3LXyqx1WA;
	}

	private struct N4KIHaLXWoB3qwoSg0Rv
	{
		[MarshalAs((UnmanagedType)30, SizeConst = 16)]
		internal byte[] SQNLXJ2P14N;

		internal uint mcPLXQF9X8o;

		internal uint WCELXCjvyXK;

		[MarshalAs((UnmanagedType)30, SizeConst = 16)]
		internal byte[] BMZLX4AjEly;

		internal uint ix9LXhYkSCL;

		internal uint o3ULXU82F3O;

		internal uint T3WLXrpPBX6;

		internal uint FUOLXoOcYQ6;
	}

	sealed class WN5XbtLXmo9A58YcNmMH : global::System.IDisposable
	{
		private nint o8oLX7wNbOW;

		private readonly int qsFLXAGngjH;

		[CompilerGenerated]
		private readonly int f8nLXIJv87q;

		internal static object stYrV29pxqyCOPRuEhkf;

		internal nint Pointer
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return o8oLX7wNbOW;
			}
		}

		internal int Count
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return f8nLXIJv87q;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		private WN5XbtLXmo9A58YcNmMH(nint pointer, int byteLength)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void ValidateRows(int rowSize)
		{
			int num = 4;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static WN5XbtLXmo9A58YcNmMH Load(int addressFamily)
		{
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0309: Unknown result type (might be due to invalid IL or missing references)
			//IL_022b: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			int num11 = default(int);
			int tableSize = default(int);
			uint extendedTcpTable = default(uint);
			nint num4 = default(nint);
			int num7 = default(int);
			int num8 = default(int);
			WN5XbtLXmo9A58YcNmMH result = default(WN5XbtLXmo9A58YcNmMH);
			int num10 = default(int);
			bool flag = default(bool);
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
							if (num2 != 25)
							{
								if (num2 == 1006)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							num11++;
							num3 = 13;
							continue;
						case 15:
							if (tableSize < 4)
							{
								num3 = 14;
								continue;
							}
							num11 = 0;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num3 = 4;
							}
							continue;
						case 4:
							try
							{
								extendedTcpTable = GetExtendedTcpTable(num4, ref tableSize, order: false, addressFamily, nqQI18LXkYoFd4TK31w6.OwnerPidAll, 0u);
								int num5 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
								{
									num5 = 8;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										if (num7 != 14)
										{
											if (num7 == 994)
											{
												goto IL_00d1;
											}
											goto case 0;
										}
										if (tableSize > num8)
										{
											num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
											{
												num5 = 5;
											}
											continue;
										}
										goto case 4;
									case 3:
										if (extendedTcpTable != 0)
										{
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
											{
												num5 = 12;
											}
											continue;
										}
										goto case 2;
									case 5:
										break;
									case 0:
									case 6:
										if (extendedTcpTable == 122)
										{
											int num6 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
											{
												num6 = 14;
											}
											num7 = num6;
											goto IL_00d1;
										}
										goto case 4;
									case 2:
										result = (WN5XbtLXmo9A58YcNmMH)new WN5XbtLXmo9A58YcNmMH(num4, num8);
										num5 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
										{
											num5 = 1;
										}
										continue;
									case 4:
										throw new Win32Exception((int)extendedTcpTable, "无法读取 Windows TCP 所有者表");
									case 1:
										{
											return result;
										}
										IL_00d1:
										num5 = num7;
										continue;
									}
									break;
								}
							}
							catch
							{
								int num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
								{
									num9 = 1;
								}
								while (true)
								{
									switch (num9)
									{
									default:
										if (num10 == 989)
										{
											num9 = num10;
											break;
										}
										goto case 1;
									case 1:
										System.Runtime.InteropServices.Marshal.FreeHGlobal(num4);
										num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
										{
											num9 = 0;
										}
										break;
									case 0:
										throw;
									}
								}
							}
							goto case 7;
						case 6:
							num4 = System.Runtime.InteropServices.Marshal.AllocHGlobal(num8);
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num3 = 25;
							}
							continue;
						case 18:
							throw new Win32Exception(122, "Windows TCP 所有者表持续变化");
						case 17:
							if (extendedTcpTable == 0)
							{
								num = 3;
								break;
							}
							goto case 11;
						case 2:
							tableSize = 0;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 1;
							}
							continue;
						case 8:
							flag = false;
							num3 = 9;
							continue;
						case 14:
							throw new Win32Exception((int)extendedTcpTable, "无法读取 Windows TCP 所有者表大小");
						case 10:
						case 13:
							if (num11 < 3)
							{
								num3 = 16;
								continue;
							}
							goto case 18;
						case 0:
						case 16:
							num8 = tableSize;
							num3 = 6;
							continue;
						case 1:
							extendedTcpTable = GetExtendedTcpTable(global::System.IntPtr.Zero, ref tableSize, order: false, addressFamily, nqQI18LXkYoFd4TK31w6.OwnerPidAll, 0u);
							num3 = 17;
							continue;
						case 11:
							if (extendedTcpTable == 122)
							{
								num = 12;
								break;
							}
							goto case 8;
						case 5:
						case 9:
							if (flag)
							{
								num3 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
								{
									num3 = 22;
								}
								continue;
							}
							goto case 14;
						case 3:
						case 12:
							flag = true;
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num3 = 6;
							}
							continue;
						case 7:
							System.Runtime.InteropServices.Marshal.FreeHGlobal(num4);
							num = 25;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
							{
								num = 24;
							}
							break;
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
		public void Dispose()
		{
			nint num = System.Threading.Interlocked.Exchange(ref o8oLX7wNbOW, global::System.IntPtr.Zero);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Xf7Tij9pF0rJIy4loiFY()
		{
			return stYrV29pxqyCOPRuEhkf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static WN5XbtLXmo9A58YcNmMH v73skc9psVlc1LP8OHvT()
		{
			return (WN5XbtLXmo9A58YcNmMH)stYrV29pxqyCOPRuEhkf;
		}
	}

	private static object NNjaRUZt9I5O2sXFHysE;

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.ValueTask<int?> ResolveSourceProcessIdAsync(wCXHhVfTxU0EHc20TDtH context, CancellationToken cancellationToken)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		AddressFamily val = (NormalizeAddress((context.ClientEndpoint).Address)).AddressFamily;
		return default(global::System.Threading.Tasks.ValueTask<int?>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int? ResolveIpv4(object context, CancellationToken cancellationToken)
	{
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0201: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0203: Expected O, but got Unknown
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		int num = 1;
		int num9 = default(int);
		IPEndPoint local = default(IPEndPoint);
		IPEndPoint remote = default(IPEndPoint);
		int? result = default(int?);
		int? num7 = default(int?);
		WP2YT2LXVd95bSqXIjQD wP2YT2LXVd95bSqXIjQD = default(WP2YT2LXVd95bSqXIjQD);
		int num8 = default(int);
		nint num5 = default(nint);
		WN5XbtLXmo9A58YcNmMH wN5XbtLXmo9A58YcNmMH = default(WN5XbtLXmo9A58YcNmMH);
		int num11 = default(int);
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
						goto end_IL_000d;
					}
					goto case 1;
				case 0:
					try
					{
						int num3 = Marshal.SizeOf<WP2YT2LXVd95bSqXIjQD>();
						int num4 = 8;
						while (true)
						{
							int num6;
							switch (num4)
							{
							default:
								if (num9 != 26)
								{
									if (num9 == 1006)
									{
										goto IL_0051;
									}
									goto case 3;
								}
								if (Matches(context, local, remote))
								{
									num4 = 10;
									continue;
								}
								break;
							case 18:
								result = num7;
								num4 = 5;
								continue;
							case 17:
								local = new IPEndPoint(new IPAddress(System.BitConverter.GetBytes(wP2YT2LXVd95bSqXIjQD.Tk9LXSp5RBT)), DecodePort(wP2YT2LXVd95bSqXIjQD.jlDLXcUI0FY));
								num4 = 14;
								continue;
							case 10:
								if (wP2YT2LXVd95bSqXIjQD.yn3LXyqx1WA == 0)
								{
									num4 = 12;
									continue;
								}
								goto case 6;
							case 16:
								num8 = 0;
								num4 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
								{
									num4 = 26;
								}
								continue;
							case 9:
								num5 = nint.Add(wN5XbtLXmo9A58YcNmMH.Pointer, 4);
								num4 = 16;
								continue;
							case 8:
								wN5XbtLXmo9A58YcNmMH.ValidateRows(num3);
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
								{
									num4 = 9;
								}
								continue;
							case 6:
								result = checked((int)wP2YT2LXVd95bSqXIjQD.yn3LXyqx1WA);
								num4 = 11;
								continue;
							case 1:
								num7 = null;
								num4 = 18;
								continue;
							case 14:
								remote = new IPEndPoint(new IPAddress(System.BitConverter.GetBytes(wP2YT2LXVd95bSqXIjQD.weyLX0YycKx)), DecodePort(wP2YT2LXVd95bSqXIjQD.JnRLX8A7vIj));
								num6 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
								{
									num6 = 3;
								}
								goto IL_004d;
							case 3:
							case 4:
								if (num8 < wN5XbtLXmo9A58YcNmMH.Count)
								{
									num4 = 24;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
									{
										num4 = 13;
									}
									continue;
								}
								goto case 1;
							case 0:
								num8++;
								num4 = 3;
								continue;
							case 2:
							case 13:
								(cancellationToken).ThrowIfCancellationRequested();
								num4 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
								{
									num4 = 17;
								}
								continue;
							case 15:
								wP2YT2LXVd95bSqXIjQD = Marshal.PtrToStructure<WP2YT2LXVd95bSqXIjQD>((global::System.IntPtr)num5);
								num6 = 17;
								goto IL_004d;
							case 7:
							case 12:
								break;
							case 11:
								goto end_IL_0055;
							case 5:
								goto end_IL_0055;
								IL_004d:
								num9 = num6;
								goto IL_0051;
								IL_0051:
								num4 = num9;
								continue;
							}
							num5 = nint.Add(num5, num3);
							num4 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
							{
								num4 = 0;
							}
							continue;
							end_IL_0055:
							break;
						}
					}
					finally
					{
						int num10;
						if (wN5XbtLXmo9A58YcNmMH == null)
						{
							num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num10 = 4;
							}
							goto IL_0360;
						}
						goto IL_0393;
						IL_0360:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_035c;
								}
								goto end_IL_0360;
							case 0:
								goto end_IL_0360;
							case 2:
								break;
							case 1:
								goto end_IL_0360;
							}
							goto IL_0393;
							IL_035c:
							num10 = num11;
							continue;
							end_IL_0360:
							break;
						}
						goto end_IL_0328;
						IL_0393:
						(wN5XbtLXmo9A58YcNmMH).Dispose();
						num10 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num10 = 1;
						}
						goto IL_0360;
						end_IL_0328:;
					}
					break;
				case 1:
					wN5XbtLXmo9A58YcNmMH = WN5XbtLXmo9A58YcNmMH.Load(2);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				}
				return result;
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int? ResolveIpv6(object context, CancellationToken cancellationToken)
	{
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d5: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		int num = 1;
		int? result = default(int?);
		int num7 = default(int);
		int num6 = default(int);
		nint num8 = default(nint);
		N4KIHaLXWoB3qwoSg0Rv n4KIHaLXWoB3qwoSg0Rv = default(N4KIHaLXWoB3qwoSg0Rv);
		IPEndPoint local = default(IPEndPoint);
		IPEndPoint remote = default(IPEndPoint);
		WN5XbtLXmo9A58YcNmMH wN5XbtLXmo9A58YcNmMH = default(WN5XbtLXmo9A58YcNmMH);
		int? num5 = default(int?);
		int num11 = default(int);
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
						goto end_IL_000d;
					}
					goto case 2;
				case 2:
					return result;
				case 0:
					try
					{
						int num3 = Marshal.SizeOf<N4KIHaLXWoB3qwoSg0Rv>();
						int num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num4 = 23;
						}
						while (true)
						{
							int num9;
							switch (num4)
							{
							default:
								if (num7 != 26)
								{
									if (num7 == 1006)
									{
										goto IL_0069;
									}
									goto case 15;
								}
								num6 = 0;
								num4 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num4 = 10;
								}
								continue;
							case 2:
							case 3:
								num8 = nint.Add(num8, num3);
								num4 = 13;
								continue;
							case 4:
								if (n4KIHaLXWoB3qwoSg0Rv.FUOLXoOcYQ6 != 0)
								{
									num4 = 18;
									continue;
								}
								goto case 2;
							case 9:
								if (!Matches(context, local, remote))
								{
									num4 = 3;
									continue;
								}
								goto case 4;
							case 1:
								wN5XbtLXmo9A58YcNmMH.ValidateRows(num3);
								num9 = 17;
								goto IL_0065;
							case 17:
								num8 = nint.Add(wN5XbtLXmo9A58YcNmMH.Pointer, 4);
								num9 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
								{
									num9 = 20;
								}
								goto IL_0065;
							case 5:
								n4KIHaLXWoB3qwoSg0Rv = Marshal.PtrToStructure<N4KIHaLXWoB3qwoSg0Rv>((global::System.IntPtr)num8);
								num4 = 15;
								continue;
							case 18:
								result = checked((int)n4KIHaLXWoB3qwoSg0Rv.FUOLXoOcYQ6);
								num4 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
								{
									num4 = 12;
								}
								continue;
							case 12:
								break;
							case 8:
							case 10:
								if (num6 < wN5XbtLXmo9A58YcNmMH.Count)
								{
									num4 = 16;
									continue;
								}
								goto case 7;
							case 15:
								local = new IPEndPoint(new IPAddress(n4KIHaLXWoB3qwoSg0Rv.SQNLXJ2P14N, (long)n4KIHaLXWoB3qwoSg0Rv.mcPLXQF9X8o), DecodePort(n4KIHaLXWoB3qwoSg0Rv.WCELXCjvyXK));
								num4 = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
								{
									num4 = 0;
								}
								continue;
							case 7:
								num5 = null;
								num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
								{
									num4 = 14;
								}
								continue;
							case 0:
								remote = new IPEndPoint(new IPAddress(n4KIHaLXWoB3qwoSg0Rv.BMZLX4AjEly, (long)n4KIHaLXWoB3qwoSg0Rv.ix9LXhYkSCL), DecodePort(n4KIHaLXWoB3qwoSg0Rv.o3ULXU82F3O));
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num4 = 9;
								}
								continue;
							case 13:
								num6++;
								num4 = 8;
								continue;
							case 6:
							case 16:
								(cancellationToken).ThrowIfCancellationRequested();
								num4 = 5;
								continue;
							case 14:
								result = num5;
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
								{
									num4 = 25;
								}
								continue;
							case 11:
								break;
								IL_0069:
								num4 = num7;
								continue;
								IL_0065:
								num7 = num9;
								goto IL_0069;
							}
							break;
						}
					}
					finally
					{
						int num10;
						if (wN5XbtLXmo9A58YcNmMH == null)
						{
							num10 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
							{
								num10 = 0;
							}
							goto IL_039e;
						}
						goto IL_03e6;
						IL_039e:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_039a;
								}
								goto end_IL_039e;
							case 0:
								goto end_IL_039e;
							case 2:
								break;
							case 1:
								goto end_IL_039e;
							}
							goto IL_03e6;
							IL_039a:
							num10 = num11;
							continue;
							end_IL_039e:
							break;
						}
						goto end_IL_0366;
						IL_03e6:
						(wN5XbtLXmo9A58YcNmMH).Dispose();
						num10 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							num10 = 1;
						}
						goto IL_039e;
						end_IL_0366:;
					}
					goto case 2;
				case 1:
					wN5XbtLXmo9A58YcNmMH = WN5XbtLXmo9A58YcNmMH.Load(23);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool Matches(object context, object local, object remote)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool EndpointEquals(object left, object right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static IPAddress NormalizeAddress(object address)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		return default(IPAddress);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int DecodePort(uint networkPort)
	{
		return (ushort)System.Net.IPAddress.NetworkToHostOrder((short)(networkPort & 0xFFFF));
	}

	[DllImport("iphlpapi.dll", SetLastError = true)]
	private static extern uint GetExtendedTcpTable(nint tcpTable, ref int tableSize, [MarshalAs((UnmanagedType)2)] bool order, int addressFamily, nqQI18LXkYoFd4TK31w6 tableClass, uint reserved);

	[MethodImpl((MethodImplOptions)8)]
	public gVdr5aXmYpJ1TRKfNmt8()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool u06vc0ZtDbXC9aL45hd4()
	{
		return NNjaRUZt9I5O2sXFHysE == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static gVdr5aXmYpJ1TRKfNmt8 UCBtaiZtkRGdcL1Zlird()
	{
		return (gVdr5aXmYpJ1TRKfNmt8)NNjaRUZt9I5O2sXFHysE;
	}
}

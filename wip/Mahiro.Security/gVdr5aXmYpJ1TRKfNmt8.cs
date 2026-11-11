using System;
using System.Collections.Generic;
using System.Linq;
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
using xsbjKUfp9um80Gf8YymA;

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
			f8nLXIJv87q = System.Runtime.InteropServices.Marshal.ReadInt32(pointer);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal void ValidateRows(int rowSize)
		{
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						if (num == 992)
						{
							goto end_IL_0010;
						}
						goto case 2;
					case 4:
						if (rowSize <= 0)
						{
							num2 = 3;
							continue;
						}
						goto case 2;
					case 1:
						return;
					case 2:
						if (Count <= (qsFLXAGngjH - 4) / rowSize)
						{
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
							{
								num2 = 8;
							}
							continue;
						}
						break;
					case 0:
					case 3:
						break;
					}
					throw new global::System.Exception("Windows TCP 所有者表长度无效");
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static WN5XbtLXmo9A58YcNmMH Load(int addressFamily)
		{
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
										throw new global::System.Exception("无法读取 Windows TCP 所有者表");
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
										throw new global::System.Exception();
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
							_ = 122;
							throw new global::System.Exception("Windows TCP 所有者表持续变化");
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
							throw new global::System.Exception("无法读取 Windows TCP 所有者表大小");
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
							extendedTcpTable = GetExtendedTcpTable(global::nint.Zero, ref tableSize, order: false, addressFamily, nqQI18LXkYoFd4TK31w6.OwnerPidAll, 0u);
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
							case 9:
								goto IL_0044;
							default:
								goto end_IL_000e;
							}
							break;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
							{
								num3 = 8;
							}
							continue;
						case 2:
							return;
						case 0:
							goto end_IL_000e;
							IL_0044:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
							{
								num3 = 7;
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
	public unsafe global::System.Threading.Tasks.ValueTask<int?> ResolveSourceProcessIdAsync(wCXHhVfTxU0EHc20TDtH context, CancellationToken cancellationToken)
	{
		//IL_01f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Invalid comparison between Unknown and I4
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		int num = 10;
		AddressFamily val = default(AddressFamily);
		int? num4 = default(int?);
		int? num5 = default(int?);
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
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_000d;
							}
							goto case 5;
						}
						if ((int)val != 23)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num3 = 19;
							}
							continue;
						}
						goto case 7;
					case 1:
						*(@null*)(&num4) = null;
						num = 14;
						break;
					case 10:
						System.ArgumentNullException.ThrowIfNull(context, "context");
						num3 = 9;
						continue;
					case 6:
					case 11:
					case 12:
						return (global::System.Threading.Tasks.ValueTask<int?>)Enumerable.Single<m4wFTFfpZW4pcAqQZC1k>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)num4);
					case 5:
					case 13:
						*(@null*)(&num5) = null;
						num3 = 8;
						continue;
					case 8:
						num4 = num5;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num3 = 12;
						}
						continue;
					case 0:
						if (System.OperatingSystem.IsWindows())
						{
							num3 = 2;
							continue;
						}
						goto case 1;
					case 14:
						return (global::System.Threading.Tasks.ValueTask<int?>)Enumerable.Single<m4wFTFfpZW4pcAqQZC1k>((global::System.Collections.Generic.IEnumerable<m4wFTFfpZW4pcAqQZC1k>)num4);
					case 2:
						val = (NormalizeAddress((context.ClientEndpoint).Address)).AddressFamily;
						num3 = 4;
						continue;
					case 9:
						(cancellationToken).ThrowIfCancellationRequested();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							num3 = 17;
						}
						continue;
					case 4:
						if ((int)val != 2)
						{
							num = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
							{
								num = 21;
							}
							break;
						}
						goto case 3;
					case 7:
						num4 = ResolveIpv6(context, cancellationToken);
						num3 = 11;
						continue;
					case 3:
						num4 = ResolveIpv4(context, cancellationToken);
						num3 = 12;
						continue;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int? ResolveIpv4(object context, CancellationToken cancellationToken)
	{
		//IL_01b2: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_00f6: Expected O, but got I4
		//IL_02ad->IL004d: Incompatible stack heights: 1 vs 2
		//IL_0100->IL0055: Incompatible stack heights: 2 vs 1
		//IL_00c2->IL0051: Incompatible stack heights: 0 vs 1
		//IL_0055->IL0055: Incompatible stack heights: 2 vs 1
		int num = 1;
		int num9 = default(int);
		IPEndPoint local = default(IPEndPoint);
		IPEndPoint remote = default(IPEndPoint);
		int? result = default(int?);
		int? num8 = default(int?);
		WP2YT2LXVd95bSqXIjQD wP2YT2LXVd95bSqXIjQD = default(WP2YT2LXVd95bSqXIjQD);
		int num6 = default(int);
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
							int num7;
							switch (num4)
							{
							default:
								if (num9 != 26)
								{
									if (num9 == 1006)
									{
										continue;
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
								result = num8;
								num4 = 5;
								continue;
							case 17:
								System.BitConverter.GetBytes(wP2YT2LXVd95bSqXIjQD.Tk9LXSp5RBT);
								local = (IPEndPoint)(object)DecodePort(wP2YT2LXVd95bSqXIjQD.jlDLXcUI0FY);
								_ = 14;
								continue;
							case 10:
								if (wP2YT2LXVd95bSqXIjQD.yn3LXyqx1WA == 0)
								{
									num4 = 12;
									continue;
								}
								goto case 6;
							case 16:
								num6 = 0;
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
								result = (int?)(object)checked((int)wP2YT2LXVd95bSqXIjQD.yn3LXyqx1WA);
								num4 = 11;
								continue;
							case 1:
								num8 = null;
								num4 = 18;
								continue;
							case 14:
								System.BitConverter.GetBytes(wP2YT2LXVd95bSqXIjQD.weyLX0YycKx);
								remote = (IPEndPoint)(object)DecodePort(wP2YT2LXVd95bSqXIjQD.JnRLX8A7vIj);
								num7 = 26;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
								{
									num7 = 3;
								}
								goto IL_004d;
							case 3:
							case 4:
								if (num6 < wN5XbtLXmo9A58YcNmMH.Count)
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
								num6++;
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
								wP2YT2LXVd95bSqXIjQD = Marshal.PtrToStructure<WP2YT2LXVd95bSqXIjQD>((global::nint)num5);
								_ = 17;
								goto IL_004d;
							case 7:
							case 12:
								break;
							case 11:
								goto end_IL_0055;
							case 5:
								goto end_IL_0055;
								IL_004d:
								num9 = num7;
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
							goto IL_034c;
						}
						goto IL_037f;
						IL_034c:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_0348;
								}
								goto end_IL_034c;
							case 0:
								goto end_IL_034c;
							case 2:
								break;
							case 1:
								goto end_IL_034c;
							}
							goto IL_037f;
							IL_0348:
							num10 = num11;
							continue;
							end_IL_034c:
							break;
						}
						goto end_IL_0314;
						IL_037f:
						(wN5XbtLXmo9A58YcNmMH).Dispose();
						num10 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num10 = 1;
						}
						goto IL_034c;
						end_IL_0314:;
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
		//IL_02c1: Expected O, but got I4
		//IL_025c: Expected O, but got I4
		//IL_01e2: Expected O, but got I4
		//IL_02d5->IL006d: Incompatible stack heights: 3 vs 1
		//IL_0270->IL006d: Incompatible stack heights: 3 vs 1
		//IL_02e0->IL006d: Incompatible stack heights: 3 vs 1
		//IL_027b->IL006d: Incompatible stack heights: 3 vs 1
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
								n4KIHaLXWoB3qwoSg0Rv = Marshal.PtrToStructure<N4KIHaLXWoB3qwoSg0Rv>((global::nint)num8);
								num4 = 15;
								continue;
							case 18:
								result = (int?)(object)checked((int)n4KIHaLXWoB3qwoSg0Rv.FUOLXoOcYQ6);
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
								_ = n4KIHaLXWoB3qwoSg0Rv.SQNLXJ2P14N;
								_ = n4KIHaLXWoB3qwoSg0Rv.mcPLXQF9X8o;
								local = (IPEndPoint)(object)DecodePort(n4KIHaLXWoB3qwoSg0Rv.WCELXCjvyXK);
								_ = 18;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
								{
									_ = 0;
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
								_ = n4KIHaLXWoB3qwoSg0Rv.BMZLX4AjEly;
								_ = n4KIHaLXWoB3qwoSg0Rv.ix9LXhYkSCL;
								remote = (IPEndPoint)(object)DecodePort(n4KIHaLXWoB3qwoSg0Rv.o3ULXU82F3O);
								_ = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									_ = 9;
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
							goto IL_038a;
						}
						goto IL_03d2;
						IL_038a:
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 990)
								{
									goto IL_0386;
								}
								goto end_IL_038a;
							case 0:
								goto end_IL_038a;
							case 2:
								break;
							case 1:
								goto end_IL_038a;
							}
							goto IL_03d2;
							IL_0386:
							num10 = num11;
							continue;
							end_IL_038a:
							break;
						}
						goto end_IL_0352;
						IL_03d2:
						(wN5XbtLXmo9A58YcNmMH).Dispose();
						num10 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							num10 = 1;
						}
						goto IL_038a;
						end_IL_0352:;
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
				case 1:
					if (!EndpointEquals(local, ((wCXHhVfTxU0EHc20TDtH)context).ClientEndpoint))
					{
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return EndpointEquals(remote, ((wCXHhVfTxU0EHc20TDtH)context).ListenerEndpoint);
				case 0:
					return false;
				}
				continue;
				end_IL_000d:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool EndpointEquals(object left, object right)
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
					goto IL_001a;
				case 0:
					return (NormalizeAddress((left).Address)).Equals(NormalizeAddress((right).Address));
				case 1:
					break;
				}
				goto IL_005a;
				IL_001a:
				if (num == 989)
				{
					break;
				}
				goto IL_005a;
				IL_005a:
				if ((left).Port != (right).Port)
				{
					return false;
				}
				num2 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static IPAddress NormalizeAddress(object address)
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
					if (!(address).IsIPv4MappedToIPv6)
					{
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return (address).MapToIPv4();
				case 0:
					return (IPAddress)address;
				}
				break;
			}
		}
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
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
					case 1:
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						return;
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
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
			{
				num = 9;
			}
		}
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

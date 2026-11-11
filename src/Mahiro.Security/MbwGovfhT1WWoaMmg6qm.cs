using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using ePgxqefhipUwkK39mRLP;
using fDAldojjppXrctUVYOJn;
using xMk5tkfUVNH7XY6TZJsA;

namespace soB36hfhNTZlD1SI65dI;

internal sealed class MbwGovfhT1WWoaMmg6qm
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_96
	{
		public static readonly __c_96 __9;

		public static Comparison<ValueTuple<uint, uint, byte[]>> __9__7_1;

		public static Comparison<ValueTuple<int, uint, byte[]>> __9__7_0;

		internal static __c_96 VNyBjBDCL5l5ojqVqvQK;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_96()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int eQ5L0kMVrhm(ValueTuple<uint, uint, byte[]> left, ValueTuple<uint, uint, byte[]> right)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			return (left.Item1).CompareTo(right.Item1);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int UkfL0VdeWeP(ValueTuple<int, uint, byte[]> left, ValueTuple<int, uint, byte[]> right)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			int num = (left.Item1).CompareTo(right.Item1);
			return default(int);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool TPi01KDCjIrGqcltKAva()
		{
			return VNyBjBDCL5l5ojqVqvQK == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_96 vEpHBvDCZs1M4odKNMtX()
		{
			return VNyBjBDCL5l5ojqVqvQK;
		}
	}

	private readonly object zHCfhEiIUg3;

	private readonly Dictionary<uint, byte[]> HeKfh2dGF3q;

	private readonly Queue<uint> QBWfhq8tU06;

	private static object UB0c4yZuqNZAySYPysbl;

	[MethodImpl((MethodImplOptions)8)]
	public void XHtfhMjbAad(byte[] datagram)
	{
		int num = 1;
		VRTBhBfhGNLMoKgoRIvW packet = default(VRTBhBfhGNLMoKgoRIvW);
		object obj = default(object);
		bool flag = default(bool);
		int num6 = default(int);
		uint num5 = default(uint);
		int num9 = default(int);
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
					case 0:
						return;
					case 2:
						return;
					case 1:
						if (SmeeQEfUk1LOYNogcnC0.JE8fUyiVxvs(datagram, out packet))
						{
							obj = zHCfhEiIUg3;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
							{
								num3 = 3;
							}
						}
						else
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num3 = 10;
							}
						}
						continue;
					case 3:
						goto end_IL_000c;
					}
					break;
				}
				switch (num2)
				{
				case 991:
					break;
				default:
					return;
				case 10:
					try
					{
						System.Threading.Monitor.Enter(obj, ref flag);
						int num4 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num4 = 11;
						}
						while (true)
						{
							switch (num4)
							{
							case 0:
								return;
							case 2:
								return;
							default:
								if (num6 != 17)
								{
									if (num6 == 997)
									{
										goto IL_00d7;
									}
									goto case 1;
								}
								QBWfhq8tU06.Enqueue(packet.SequenceNumber);
								num4 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num4 = 14;
								}
								break;
							case 1:
							case 8:
								if (HeKfh2dGF3q.Count <= 32768)
								{
									return;
								}
								num4 = 3;
								break;
							case 6:
								if (!HeKfh2dGF3q.ContainsKey(packet.SequenceNumber))
								{
									num4 = 4;
									break;
								}
								goto case 7;
							case 7:
								HeKfh2dGF3q[packet.SequenceNumber] = datagram;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
								{
									num4 = 13;
								}
								break;
							case 9:
								HeKfh2dGF3q.Remove(num5);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
								{
									num4 = 7;
								}
								break;
							case 4:
							case 5:
							{
								HeKfh2dGF3q.Add(packet.SequenceNumber, datagram);
								int num7 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
								{
									num7 = 17;
								}
								num6 = num7;
								goto IL_00d7;
							}
							case 3:
								{
									if (!QBWfhq8tU06.TryDequeue(out num5))
									{
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num4 = 2;
										}
										break;
									}
									goto case 9;
								}
								IL_00d7:
								num4 = num6;
								break;
							}
						}
					}
					finally
					{
						if (flag)
						{
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								num8 = 2;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 989)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_02db;
								}
								System.Threading.Monitor.Exit(obj);
								num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num8 = 1;
								}
								continue;
								end_IL_02db:
								break;
							}
						}
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			flag = false;
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public List<byte[]> h2XfhpP3biy(byte[] nack)
	{
		byte[] remainingNack;
		return RQRfhu3ttE1(nack, out remainingNack);
	}

	[MethodImpl((MethodImplOptions)8)]
	public List<byte[]> RQRfhu3ttE1(byte[] nack, out byte[]? remainingNack)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static uint kTafhamP5sX(uint start, uint distance)
	{
		return (start + distance) & 0xFFFFFF;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void HGofh15b2W8()
	{
		int num = 3;
		object obj = default(object);
		bool flag = default(bool);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 3;
				case 1:
					try
					{
						System.Threading.Monitor.Enter(obj, ref flag);
						int num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 990)
								{
									num3 = num4;
									continue;
								}
								break;
							case 1:
								QBWfhq8tU06.Clear();
								num3 = 2;
								continue;
							case 0:
								break;
							case 2:
								return;
							}
							HeKfh2dGF3q.Clear();
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num3 = 1;
							}
						}
					}
					finally
					{
						int num5;
						if (!flag)
						{
							num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
							{
								num5 = 1;
							}
							goto IL_0118;
						}
						goto IL_013c;
						IL_0118:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_0114;
								}
								goto end_IL_0118;
							case 2:
								break;
							case 1:
								goto end_IL_0118;
							case 0:
								goto end_IL_0118;
							}
							goto IL_013c;
							IL_0114:
							num5 = num6;
							continue;
							end_IL_0118:
							break;
						}
						goto end_IL_00e0;
						IL_013c:
						System.Threading.Monitor.Exit(obj);
						num5 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
						{
							num5 = 0;
						}
						goto IL_0118;
						end_IL_00e0:;
					}
				case 3:
					obj = zHCfhEiIUg3;
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
					{
						num2 = 6;
					}
					break;
				case 0:
					return;
				case 2:
					flag = false;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
					{
						num2 = 4;
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
	public MbwGovfhT1WWoaMmg6qm()
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
	internal static bool Gtl82JZuGbkKwZpUkYmZ()
	{
		return UB0c4yZuqNZAySYPysbl == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MbwGovfhT1WWoaMmg6qm oHkSsUZuiVXkbaLMRmm8()
	{
		return (MbwGovfhT1WWoaMmg6qm)UB0c4yZuqNZAySYPysbl;
	}
}

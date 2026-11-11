using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using HTopunXzv3vrQ85LxxXQ;
using Q7QlhnXzpYN0AK3xKtOA;
using fDAldojjppXrctUVYOJn;

namespace RkZ1dxXiv8firyuXKQiD;

internal class Eam1pEXi34xUNOhobEc4
{
	private static object bl9sFMZFO0G0fAZSIiiU;

	internal static ulong SiteRva
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return MMVcRCXz3U5i7hjKBmqb.Active.InputModeSiteRva;
		}
	}

	internal static string OriginalHex
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return MMVcRCXz3U5i7hjKBmqb.Active.InputModeOriginalHex;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void aJQXiEuyHJC(Func<ulong, int, byte[]> read, ulong moduleAddress)
	{
		gTwW2eXzMBEG7xkba7mt active = MMVcRCXz3U5i7hjKBmqb.Active;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void u9NXi2VKrOA(Func<byte[]> read, Action<byte[]> write, object patch)
	{
		//IL_0311: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		byte[] array = default(byte[]);
		int num5 = default(int);
		int num11 = default(int);
		int num8 = default(int);
		int num10 = default(int);
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
						if (num2 == 11)
						{
							goto IL_007b;
						}
						if (num2 == 992)
						{
							goto end_IL_0010;
						}
						goto case 1;
					case 3:
						array = System.Convert.FromHexString(OriginalHex);
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 2;
						}
						continue;
					case 4:
						return;
					case 1:
						try
						{
							write.Invoke((byte[])patch);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num4 = 2;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 1:
									if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke()), ((global::System.ReadOnlySpan<byte>)(byte[])patch)))
									{
										return;
									}
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							throw new InvalidDataException("input_write_readback");
						}
						catch (global::System.Exception ex)
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num6 = 3;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num11 == 989)
									{
										goto IL_01a4;
									}
									break;
								case 1:
									try
									{
										write.Invoke(array);
										int num7 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
										{
											num7 = 0;
										}
										while (true)
										{
											switch (num7)
											{
											default:
												if (num8 == 990)
												{
													num7 = num8;
													continue;
												}
												goto end_IL_0202;
											case 1:
												goto end_IL_0202;
											case 0:
												if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke()), default(global::System.ReadOnlySpan<byte>)))
												{
													num7 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
													{
														num7 = 1;
													}
													continue;
												}
												break;
											case 2:
												break;
											}
											throw new InvalidDataException("input_rollback_readback");
											continue;
											end_IL_0202:
											break;
										}
									}
									catch (global::System.Exception ex2)
									{
										int num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
										{
											num9 = 0;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 988)
												{
													goto IL_02c6;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_02c6:
											num9 = num10;
										}
										throw new AggregateException("Input probe rollback failed", new global::System.Exception[2] { ex, ex2 });
									}
									break;
								case 0:
									break;
								}
								break;
								IL_01a4:
								num6 = num11;
							}
							throw;
						}
					case 0:
						break;
					case 2:
						{
							if (((global::System.Array)patch).Length == array.Length)
							{
								num3 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_007b;
						}
						IL_007b:
						throw new InvalidDataException("input_field_load");
					}
					if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke()), default(global::System.ReadOnlySpan<byte>)))
					{
						goto end_IL_000c;
					}
					num3 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
					{
						num3 = 5;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 8;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] eytXiqov2NI(ulong counter, bool androidTouchEnabled = false)
	{
		string text = "BA02000000";
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string KB6XiGTkEMY(int originalMode, int mode, uint calls)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string atAXiiS09vf(int mode)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GmD8mWZF5re0UZdYGXXb()
	{
		return bl9sFMZFO0G0fAZSIiiU == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Eam1pEXi34xUNOhobEc4 sEgkKKZF6PSZmN2pNLb3()
	{
		return (Eam1pEXi34xUNOhobEc4)bl9sFMZFO0G0fAZSIiiU;
	}
}

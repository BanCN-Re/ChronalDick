using System;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CO34DtGBRQmXHPNZNcn;
using CZUx5njfSrbl1tnMcUCO;
using HTopunXzv3vrQ85LxxXQ;
using Q7QlhnXzpYN0AK3xKtOA;
using fDAldojjppXrctUVYOJn;
using ibqOI7fwdAZ7fB5vumc9;

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
									if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>((byte[])(object)read), (global::System.ReadOnlySpan<byte>)patch))
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
							throw new global::System.Exception("input_write_readback");
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
										goto IL_0190;
									}
									break;
								case 1:
									try
									{
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
												goto end_IL_01ea;
											case 1:
												goto end_IL_01ea;
											case 0:
												if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>((byte[])(object)read), (global::System.ReadOnlySpan<byte>)array))
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
											throw new global::System.Exception("input_rollback_readback");
											continue;
											end_IL_01ea:
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
													goto IL_02a2;
												}
												break;
											case 0:
												break;
											}
											break;
											IL_02a2:
											num9 = num10;
										}
										_ = "Input probe rollback failed";
										throw new global::System.Exception[2] { ex, ex2 };
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0190:
								num6 = num11;
							}
							throw new global::System.Exception();
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
						throw new global::System.Exception("input_field_load");
					}
					if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>((byte[])(object)read), (global::System.ReadOnlySpan<byte>)array))
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
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static string KB6XiGTkEMY(int originalMode, int mode, uint calls)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendLiteral(" input_mode=");
		_ = 3;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db;
		((AsyncTaskMethodBuilder)8).AwaitUnsafeOnCompleted<object, QpE8CgGIjI48WnWx3D1._SuppressObservationCancellationAsync_d__31>(ref defaultInterpolatedStringHandler, ref *(QpE8CgGIjI48WnWx3D1._SuppressObservationCancellationAsync_d__31*)calls);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string atAXiiS09vf(int mode)
	{
		int num = 2;
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
					goto case 0;
				case 0:
					return "other";
				case 3:
					return (mode).ToString((IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture);
				case 1:
					if (mode <= 3)
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 0;
				case 2:
					if (mode >= 0)
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 0;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto end_IL_0012;
					case 0:
						return;
					case 2:
						break;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
						{
							num3 = 6;
						}
						continue;
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
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
			{
				num = 9;
			}
		}
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

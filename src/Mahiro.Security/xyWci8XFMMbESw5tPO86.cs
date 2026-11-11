using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using SrUud9XFNaVqLPy6HvvJ;
using fDAldojjppXrctUVYOJn;
using rn1YlhXFP10VNqYDd1IL;

namespace nrtDJkXFpxEaE2GZwDmU;

internal class xyWci8XFMMbESw5tPO86
{
	internal static object U6wwSRZRT65QHBvMkeXf;

	[MethodImpl((MethodImplOptions)8)]
	internal static void b5hXFu0CNVk(global::System.Collections.Generic.IReadOnlyList<eCHGNqXFe52w9ChNfeQD> patches, Func<eCHGNqXFe52w9ChNfeQD, byte[]> read, Action<eCHGNqXFe52w9ChNfeQD, byte[]> write, CancellationToken cancellationToken)
	{
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_053a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IEnumerator<eCHGNqXFe52w9ChNfeQD> enumerator = default(global::System.Collections.Generic.IEnumerator<eCHGNqXFe52w9ChNfeQD>);
		int num8 = default(int);
		List<eCHGNqXFe52w9ChNfeQD> val = default(List<eCHGNqXFe52w9ChNfeQD>);
		eCHGNqXFe52w9ChNfeQD current2 = default(eCHGNqXFe52w9ChNfeQD);
		int num13 = default(int);
		int num24 = default(int);
		List<global::System.Exception> val2 = default(List<global::System.Exception>);
		eCHGNqXFe52w9ChNfeQD current3 = default(eCHGNqXFe52w9ChNfeQD);
		int num20 = default(int);
		int num17 = default(int);
		int num19 = default(int);
		int num22 = default(int);
		int num3 = default(int);
		eCHGNqXFe52w9ChNfeQD current = default(eCHGNqXFe52w9ChNfeQD);
		int num6 = default(int);
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
					goto case 1;
				case 0:
					try
					{
						enumerator = ((global::System.Collections.Generic.IEnumerable<eCHGNqXFe52w9ChNfeQD>)patches).GetEnumerator();
						int num7 = 2;
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
								goto case 2;
							case 1:
								break;
							case 2:
								try
								{
									while (true)
									{
										IL_0187:
										int num9;
										if (!(enumerator).MoveNext())
										{
											num9 = 2;
											goto IL_00df;
										}
										goto IL_0125;
										IL_00df:
										int num10 = num9;
										while (true)
										{
											int num11 = num10;
											while (true)
											{
												switch (num11)
												{
												default:
													if (num10 == 13)
													{
														(cancellationToken).ThrowIfCancellationRequested();
														num11 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
														{
															num11 = 4;
														}
														continue;
													}
													goto IL_0112;
												case 0:
													break;
												case 3:
													val.Add(current2);
													num11 = 5;
													continue;
												case 1:
													throw new InvalidDataException("device_spoof_readback_failed");
												case 4:
													goto IL_01a2;
												case 5:
													write.Invoke(current2, current2.Replacement);
													num11 = 4;
													continue;
												case 2:
													goto end_IL_00e7;
												}
												goto IL_0125;
												IL_01a2:
												if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke(current2)), current2.Replacement))
												{
													num11 = 8;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
													{
														num11 = 1;
													}
													continue;
												}
												goto IL_0187;
												continue;
												end_IL_00e7:
												break;
											}
											break;
											IL_0112:
											if (num10 == 993)
											{
												continue;
											}
											goto IL_0125;
										}
										break;
										IL_0125:
										current2 = enumerator.Current;
										num9 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num9 = 12;
										}
										goto IL_00df;
									}
								}
								finally
								{
									if (enumerator != null)
									{
										int num12 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
										{
											num12 = 0;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												if (num13 == 989)
												{
													num12 = num13;
													continue;
												}
												break;
											case 0:
												(enumerator).Dispose();
												num12 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
												{
													num12 = 0;
												}
												continue;
											case 1:
												break;
											}
											break;
										}
									}
								}
								break;
							case 0:
								return;
							}
							(cancellationToken).ThrowIfCancellationRequested();
							num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num7 = 5;
							}
						}
					}
					catch (global::System.Exception original)
					{
						int num14 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num14 = 2;
						}
						while (true)
						{
							int num23;
							switch (num14)
							{
							default:
								if (num24 != 11)
								{
									if (num24 == 991)
									{
										goto IL_0304;
									}
									goto case 0;
								}
								enumerator = Enumerable.Reverse<eCHGNqXFe52w9ChNfeQD>(Enumerable.AsEnumerable<eCHGNqXFe52w9ChNfeQD>((global::System.Collections.Generic.IEnumerable<eCHGNqXFe52w9ChNfeQD>)val)).GetEnumerator();
								num23 = 3;
								goto IL_0300;
							case 1:
								if (val2.Count != 0)
								{
									num14 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
									{
										num14 = 4;
									}
									break;
								}
								throw;
							case 2:
								val2 = new List<global::System.Exception>();
								num23 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
								{
									num23 = 10;
								}
								goto IL_0300;
							case 3:
								try
								{
									while (true)
									{
										int num15;
										if (!(enumerator).MoveNext())
										{
											num15 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
											{
												num15 = 0;
											}
											goto IL_03e3;
										}
										goto IL_043b;
										IL_043b:
										current3 = enumerator.Current;
										num15 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num15 = 4;
										}
										goto IL_03e3;
										IL_03e3:
										while (true)
										{
											switch (num15)
											{
											default:
												if (num20 == 991)
												{
													num15 = num20;
													continue;
												}
												goto IL_043b;
											case 1:
												break;
											case 3:
												goto IL_043b;
											case 2:
												try
												{
													write.Invoke(current3, current3.Original);
													int num16 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
													{
														num16 = 5;
													}
													while (true)
													{
														switch (num16)
														{
														default:
															if (num17 == 990)
															{
																num16 = num17;
																continue;
															}
															goto case 0;
														case 0:
															if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke(current3)), current3.Original))
															{
																num16 = 2;
																continue;
															}
															break;
														case 2:
															goto end_IL_04a4;
														case 1:
															break;
														}
														throw new InvalidDataException("device_spoof_rollback_readback_failed");
														continue;
														end_IL_04a4:
														break;
													}
												}
												catch (global::System.Exception ex)
												{
													int num18 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
													{
														num18 = 0;
													}
													while (true)
													{
														switch (num18)
														{
														default:
															if (num19 == 989)
															{
																num18 = num19;
																continue;
															}
															break;
														case 0:
															break;
														case 1:
															goto end_IL_0578;
														}
														val2.Add(ex);
														num18 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
														{
															num18 = 0;
														}
														continue;
														end_IL_0578:
														break;
													}
												}
												break;
											case 0:
												goto end_IL_040b;
											}
											break;
										}
										continue;
										end_IL_040b:
										break;
									}
								}
								finally
								{
									int num21;
									if (enumerator == null)
									{
										num21 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											num21 = 8;
										}
										goto IL_0621;
									}
									goto IL_0669;
									IL_0621:
									while (true)
									{
										switch (num21)
										{
										default:
											if (num22 == 990)
											{
												goto IL_061d;
											}
											break;
										case 0:
											goto end_IL_0621;
										case 2:
											break;
										case 1:
											goto end_IL_0621;
										}
										goto IL_0669;
										IL_061d:
										num21 = num22;
										continue;
										end_IL_0621:
										break;
									}
									goto end_IL_05e9;
									IL_0669:
									(enumerator).Dispose();
									num21 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
									{
										num21 = 1;
									}
									goto IL_0621;
									end_IL_05e9:;
								}
								goto case 1;
							case 0:
								{
									throw new E70eJvXFTQegvZUtnqS2(original, (global::System.Collections.Generic.IReadOnlyList<global::System.Exception>)val2);
								}
								IL_0300:
								num24 = num23;
								goto IL_0304;
								IL_0304:
								num14 = num24;
								break;
							}
						}
					}
				case 2:
					enumerator = ((global::System.Collections.Generic.IEnumerable<eCHGNqXFe52w9ChNfeQD>)patches).GetEnumerator();
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return;
				case 4:
					break;
				case 1:
					try
					{
						while (true)
						{
							IL_0784:
							if (!(enumerator).MoveNext())
							{
								num3 = 13;
								goto IL_0721;
							}
							goto IL_0851;
							IL_0725:
							int num4;
							while (true)
							{
								switch (num4)
								{
								case 2:
									throw new InvalidDataException("device_spoof_original_changed");
								case 0:
									goto IL_0784;
								case 1:
									if (MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(read.Invoke(current)), current.Original))
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
										{
											num4 = 5;
										}
										continue;
									}
									goto case 2;
								case 3:
									(cancellationToken).ThrowIfCancellationRequested();
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
									{
										num4 = 11;
									}
									continue;
								case 5:
									if (current.Original.Length == current.Replacement.Length)
									{
										num4 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
										{
											num4 = 5;
										}
										continue;
									}
									goto case 2;
								case 4:
									goto IL_0851;
								}
								break;
							}
							switch (num3)
							{
							case 993:
								break;
							default:
								continue;
							case 13:
								goto end_IL_0784;
							}
							goto IL_0721;
							IL_0851:
							current = enumerator.Current;
							num4 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num4 = 3;
							}
							goto IL_0725;
							IL_0721:
							num4 = num3;
							goto IL_0725;
							continue;
							end_IL_0784:
							break;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
							{
								num5 = 8;
							}
							goto IL_08b6;
						}
						goto IL_08fe;
						IL_08b6:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_08b2;
								}
								goto end_IL_08b6;
							case 2:
								goto end_IL_08b6;
							case 1:
								break;
							case 0:
								goto end_IL_08b6;
							}
							goto IL_08fe;
							IL_08b2:
							num5 = num6;
							continue;
							end_IL_08b6:
							break;
						}
						goto end_IL_087e;
						IL_08fe:
						(enumerator).Dispose();
						num5 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num5 = 2;
						}
						goto IL_08b6;
						end_IL_087e:;
					}
					break;
				}
				val = new List<eCHGNqXFe52w9ChNfeQD>();
				num2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
				{
					num2 = 0;
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AAxE9KZRNZmf0FROqXIK()
	{
		return U6wwSRZRT65QHBvMkeXf == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static xyWci8XFMMbESw5tPO86 viqgDbZRMaUcyuHX3TCh()
	{
		return (xyWci8XFMMbESw5tPO86)U6wwSRZRT65QHBvMkeXf;
	}
}

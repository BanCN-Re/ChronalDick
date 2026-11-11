using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Sef9I6XiD0OPtFxxu5LU;
using fDAldojjppXrctUVYOJn;
using oiaeLRfZVoDvSB01scrZ;
using wjhhZEXtACFOAtiTJSXC;

namespace j8AoSCXiyIh7VppA4q1a;

internal class mN0WJ9Xi8isgeJOw6g5d
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	internal struct __c__DisplayClass5_0_8
	{
		public ulong moduleAddress;

		public ulong moduleSize;

		public Func<ulong, int, byte[]> read;
	}

	private static readonly object u0mXi4PF3ms;

	private static readonly object IWWXihRpOb2;

	private static readonly object elgXiUgobp9;

	private static readonly object Ho3Xirop1q9;

	private static readonly object J5FXiogegkH;

	internal static object FKFeuCZFQbYYYBo7Yl5h;

	[MethodImpl((MethodImplOptions)8)]
	internal static CejIKKXi9rWtr7x2uMe5 dTlXiWYhIPr(global::System.Collections.Generic.IEnumerable<TIu9nAfZkt3HIeLtaZrq> chunks, Func<ulong, int, byte[]> read, ulong moduleAddress, ulong moduleSize, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0276: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_046e: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		__c__DisplayClass5_0_8 _c__DisplayClass5_0_ = default(__c__DisplayClass5_0_8);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		byte[] array = default(byte[]);
		ulong num5 = default(ulong);
		ulong num4 = default(ulong);
		ulong num6 = default(ulong);
		byte[] array3 = default(byte[]);
		byte[] array2 = default(byte[]);
		HashSet<ulong> val = default(HashSet<ulong>);
		global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq> enumerator = default(global::System.Collections.Generic.IEnumerator<TIu9nAfZkt3HIeLtaZrq>);
		int num14 = default(int);
		byte[] array4 = default(byte[]);
		int num15 = default(int);
		global::System.Collections.Generic.IEnumerator<ulong> enumerator2 = default(global::System.Collections.Generic.IEnumerator<ulong>);
		ulong num12 = default(ulong);
		ulong? num7 = default(ulong?);
		TIu9nAfZkt3HIeLtaZrq current = default(TIu9nAfZkt3HIeLtaZrq);
		ulong address = default(ulong);
		ulong address2 = default(ulong);
		ulong current2 = default(ulong);
		int num17 = default(int);
		int num18 = default(int);
		int num21 = default(int);
		ulong? num11 = default(ulong?);
		int num23 = default(int);
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
						if (num2 != 29)
						{
							if (num2 == 1010)
							{
								goto end_IL_0010;
							}
							goto case 22;
						}
						throw new InvalidDataException("native_engine_version_getter_unrecognized");
					case 10:
						if (_c__DisplayClass5_0_.moduleSize != 0L)
						{
							num3 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 17;
					case 22:
						span = MemoryExtensions.AsSpan<byte>(array, checked((int)(num5 - num4)), 5);
						num3 = 5;
						continue;
					case 2:
						if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(dtwXiCjqGk2(num6, ((global::System.Array)J5FXiogegkH).Length, ref _c__DisplayClass5_0_)), ((global::System.ReadOnlySpan<byte>)(byte[])J5FXiogegkH)))
						{
							num3 = 20;
							continue;
						}
						return (CejIKKXi9rWtr7x2uMe5)new CejIKKXi9rWtr7x2uMe5(num5, num6, array3);
					case 17:
						throw new ArgumentOutOfRangeException("moduleSize");
					case 0:
						array2 = global::System.Array.Empty<byte>();
						num3 = 15;
						continue;
					case 18:
						throw new InvalidDataException("native_engine_version_getter_not_unique");
					case 16:
						(cancellationToken).ThrowIfCancellationRequested();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 7;
						}
						continue;
					case 7:
						if (val.Count == 1)
						{
							num4 = Enumerable.Single<ulong>((global::System.Collections.Generic.IEnumerable<ulong>)val);
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
							{
								num3 = 19;
							}
						}
						else
						{
							num3 = 18;
						}
						continue;
					case 4:
						_c__DisplayClass5_0_.moduleAddress = moduleAddress;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
						{
							num3 = 4;
						}
						continue;
					case 9:
						enumerator = chunks.GetEnumerator();
						num3 = 22;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 1;
						}
						continue;
					case 19:
						array = dtwXiCjqGk2(num4, 256, ref _c__DisplayClass5_0_);
						num = 6;
						break;
					case 20:
						throw new InvalidDataException("native_engine_version_string_factory_unrecognized");
					case 3:
						_c__DisplayClass5_0_.moduleSize = moduleSize;
						num3 = 11;
						continue;
					case 5:
						array3 = span.ToArray();
						num3 = 23;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							num3 = 13;
						}
						continue;
					case 1:
						try
						{
							while (true)
							{
								IL_0849:
								int num8;
								if (!(enumerator).MoveNext())
								{
									num8 = 16;
									goto IL_02f9;
								}
								goto IL_0836;
								IL_02f9:
								while (true)
								{
									long num9;
									int num13;
									switch (num8)
									{
									default:
										if (num14 != 26)
										{
											if (num14 == 1006)
											{
												goto IL_02f5;
											}
											goto case 1;
										}
										span = MemoryExtensions.AsSpan<byte>(array4, array4.Length - num15, num15);
										num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
										{
											num8 = 0;
										}
										continue;
									case 8:
										enumerator2 = ((global::System.Collections.Generic.IEnumerable<ulong>)((CbXEJXXt7ab6InjNuGoW)IWWXihRpOb2).jK7XtBU4Y0X(default(global::System.ReadOnlySpan<byte>), num12)).GetEnumerator();
										num8 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
										{
											num8 = 17;
										}
										continue;
									case 13:
										num7 = checked(current.Address + (ulong)current.Bytes.Length);
										num8 = 15;
										continue;
									case 18:
										System.ArgumentNullException.ThrowIfNull(current, "chunk");
										num8 = 7;
										continue;
									case 14:
										num9 = (long)current.Address;
										goto IL_08d1;
									case 3:
										address = current.Address;
										num8 = 10;
										continue;
									case 5:
									case 9:
										throw new InvalidDataException("native_engine_version_invalid_scan_chunk");
									case 17:
										try
										{
											while (true)
											{
												int num16;
												if (!(enumerator2).MoveNext())
												{
													num16 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
													{
														num16 = 6;
													}
													goto IL_04a4;
												}
												goto IL_05a3;
												IL_04a4:
												while (true)
												{
													switch (num16)
													{
													case 3:
													case 4:
													case 5:
														goto end_IL_04a4;
													case 2:
														if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(dtwXiCjqGk2(address2, ((global::System.Array)u0mXi4PF3ms).Length, ref _c__DisplayClass5_0_)), ((global::System.ReadOnlySpan<byte>)(byte[])u0mXi4PF3ms)))
														{
															num16 = 4;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
															{
																num16 = 4;
															}
															continue;
														}
														goto case 8;
													case 6:
														if (!nEmXiQY5vD9(address2, ((global::System.Array)u0mXi4PF3ms).Length, ref _c__DisplayClass5_0_))
														{
															num16 = 5;
															continue;
														}
														goto case 2;
													case 7:
														goto IL_05a3;
													case 8:
														val.Add(fehXiJR1spI(current2, ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array4, num17, 7)), 3, 7));
														num16 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
														{
															num16 = 1;
														}
														continue;
													case 1:
														address2 = fehXiJR1spI(current2 + 10, ((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array4, num17 + 10, 7)), 3, 7);
														num16 = 11;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
														{
															num16 = 6;
														}
														continue;
													case 0:
														goto end_IL_04ee;
													}
													switch (num18)
													{
													case 996:
														break;
													default:
														goto end_IL_04ee;
													case 16:
														num17 = checked((int)(current2 - num12));
														num16 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
														{
															num16 = 13;
														}
														continue;
													}
													goto IL_04a0;
													continue;
													end_IL_04a4:
													break;
												}
												continue;
												IL_04a0:
												num16 = num18;
												goto IL_04a4;
												IL_05a3:
												current2 = enumerator2.Current;
												int num19 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
												{
													num19 = 16;
												}
												num18 = num19;
												goto IL_04a0;
												continue;
												end_IL_04ee:
												break;
											}
										}
										finally
										{
											if (enumerator2 != null)
											{
												int num20 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
												{
													num20 = 1;
												}
												while (true)
												{
													switch (num20)
													{
													default:
														if (num21 == 989)
														{
															num20 = num21;
															continue;
														}
														break;
													case 0:
														(enumerator2).Dispose();
														num20 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
														{
															num20 = 4;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 2;
									case 2:
										num15 = System.Math.Min(((CbXEJXXt7ab6InjNuGoW)IWWXihRpOb2).Length - 1, array4.Length);
										num13 = 26;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
										{
											num13 = 11;
										}
										goto IL_02f1;
									case 6:
										break;
									case 7:
										System.ArgumentNullException.ThrowIfNull(current.Bytes, "chunk.Bytes");
										num8 = 23;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
										{
											num8 = 1;
										}
										continue;
									case 4:
										(cancellationToken).ThrowIfCancellationRequested();
										num13 = 18;
										goto IL_02f1;
									case 0:
										array2 = span.ToArray();
										num8 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num8 = 2;
										}
										continue;
									case 12:
										goto end_IL_02f9;
									case 15:
										goto IL_0849;
									case 1:
										if (current.Bytes.Length == 0)
										{
											num8 = 5;
											continue;
										}
										break;
									case 10:
									{
										bool num10 = num11 == address;
										array4 = (num10 ? Enumerable.ToArray<byte>(Enumerable.Concat<byte>((global::System.Collections.Generic.IEnumerable<byte>)array2, (global::System.Collections.Generic.IEnumerable<byte>)current.Bytes)) : current.Bytes);
										if (num10)
										{
											num8 = 11;
											continue;
										}
										goto case 14;
									}
									case 11:
										num9 = (long)current.Address - (long)array2.Length;
										goto IL_08d1;
									case 16:
										goto end_IL_0849;
										IL_08d1:
										num12 = (ulong)num9;
										num8 = 8;
										continue;
										IL_02f5:
										num8 = num14;
										continue;
										IL_02f1:
										num14 = num13;
										goto IL_02f5;
									}
									if (nEmXiQY5vD9(current.Address, current.Bytes.Length, ref _c__DisplayClass5_0_))
									{
										num11 = num7;
										num8 = 3;
										continue;
									}
									num8 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										num8 = 25;
									}
									continue;
									end_IL_02f9:
									break;
								}
								goto IL_0836;
								IL_0836:
								current = enumerator.Current;
								num8 = 4;
								goto IL_02f9;
								continue;
								end_IL_0849:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num22 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
								{
									num22 = 1;
								}
								while (true)
								{
									switch (num22)
									{
									default:
										if (num23 == 989)
										{
											num22 = num23;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_091a;
									}
									(enumerator).Dispose();
									num22 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
									{
										num22 = 0;
									}
									continue;
									end_IL_091a:
									break;
								}
							}
						}
						goto case 16;
					case 12:
						System.ArgumentNullException.ThrowIfNull(_c__DisplayClass5_0_.read, "read");
						num3 = 8;
						continue;
					case 13:
						num6 = fehXiJR1spI(num5, default(global::System.ReadOnlySpan<byte>), 1, 5);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 4;
						}
						continue;
					case 15:
						num7 = null;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
						{
							num3 = 8;
						}
						continue;
					case 8:
						if (_c__DisplayClass5_0_.moduleAddress != 0L)
						{
							num3 = 10;
							continue;
						}
						goto case 17;
					case 21:
						System.ArgumentNullException.ThrowIfNull(chunks, "chunks");
						num3 = 12;
						continue;
					case 11:
						_c__DisplayClass5_0_.read = read;
						num3 = 21;
						continue;
					case 14:
						if (_c__DisplayClass5_0_.moduleSize <= (ulong)(-1L - (long)_c__DisplayClass5_0_.moduleAddress))
						{
							val = new HashSet<ulong>();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
							{
								num3 = 29;
							}
							continue;
						}
						num = 17;
						break;
					case 6:
					{
						if (((global::System.Collections.Generic.IReadOnlyCollection<ulong>)((CbXEJXXt7ab6InjNuGoW)elgXiUgobp9).jK7XtBU4Y0X(((global::System.Span<byte>)MemoryExtensions.AsSpan<byte>(array, 0, ((CbXEJXXt7ab6InjNuGoW)elgXiUgobp9).Length)), num4)).Count != 1)
						{
							num = 29;
							break;
						}
						global::System.Collections.Generic.IReadOnlyList<ulong> readOnlyList = ((CbXEJXXt7ab6InjNuGoW)Ho3Xirop1q9).jK7XtBU4Y0X(default(global::System.ReadOnlySpan<byte>), num4);
						if (((global::System.Collections.Generic.IReadOnlyCollection<ulong>)readOnlyList).Count != 1)
						{
							throw new InvalidDataException("native_engine_version_string_call_not_unique");
						}
						num5 = checked(readOnlyList[0] + 22);
						num = 22;
						break;
					}
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
	private static ulong fehXiJR1spI(ulong address, global::System.ReadOnlySpan<byte> code, int displacement, int length)
	{
		checked
		{
			return (ulong)(unchecked((long)address) + unchecked((long)length) + System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian(code.Slice(displacement, 4)));
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
	[CompilerGenerated]
	internal static bool nEmXiQY5vD9(ulong address, int length, ref __c__DisplayClass5_0_8 P_2)
	{
		int num = 2;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	internal static byte[] dtwXiCjqGk2(ulong address, int length, ref __c__DisplayClass5_0_8 P_2)
	{
		byte[] array = P_2.read.Invoke(address, length);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Vwsw39ZFC4OfMBfo9Rfn()
	{
		return FKFeuCZFQbYYYBo7Yl5h == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static mN0WJ9Xi8isgeJOw6g5d SsvcTwZF4J5XqWu42OoM()
	{
		return (mN0WJ9Xi8isgeJOw6g5d)FKFeuCZFQbYYYBo7Yl5h;
	}
}

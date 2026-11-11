using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using mdXrpVf4xrJgmIWAd0EM;

namespace Y5prmHfhzCDwp5CiZMUL;

internal sealed class GSPUnmfhnHvPSJq04TXW
{
	private sealed class WABifbL0YksDdAUHhsfh
	{
		[Serializable]
		[CompilerGenerated]
		private sealed class __c_2
		{
			public static readonly __c_2 __9;

			public static Comparison<ValueTuple<byte[], uint>> __9__13_0;

			internal static __c_2 HZAVDCD7WXhPWd4TiV2v;

			[MethodImpl((MethodImplOptions)8)]
			private static void _cctor()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			public __c_2()
			{
				// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
				// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
				throw new global::System.NotSupportedException();
			}

			[MethodImpl((MethodImplOptions)8)]
			internal int jaYLCa0pNbE(ValueTuple<byte[], uint> a, ValueTuple<byte[], uint> b)
			{
				//IL_000a: Unknown result type (might be due to invalid IL or missing references)
				return (a.Item2).CompareTo(b.Item2);
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static bool Nbt2VcD7JxQaViAm7De4()
			{
				return HZAVDCD7WXhPWd4TiV2v == null;
			}

			[MethodImpl((MethodImplOptions)8)]
			internal static __c_2 kfp0lyD7QT9gAqc6RxFk()
			{
				return HZAVDCD7WXhPWd4TiV2v;
			}
		}

		private readonly Dictionary<uint, l3HoHoL0Jc7JtFYJrNwh> R5fL081yQtc;

		[CompilerGenerated]
		private readonly uint r90L0y4l2TS;

		[CompilerGenerated]
		private global::System.DateTime RkmL0WvsFZv;

		private static object mlOvLxDC9q8UqEyYbQ9s;

		public uint CompoundSize
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return r90L0y4l2TS;
			}
		}

		public global::System.DateTime LastSeenUtc
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return RkmL0WvsFZv;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			private set
			{
				RkmL0WvsFZv = value;
			}
		}

		public int FragmentCount
		{
			[MethodImpl((MethodImplOptions)8)]
			get
			{
				return R5fL081yQtc.Count;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public WABifbL0YksDdAUHhsfh(uint compoundSize)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public void e7DL0Svy5Cx()
		{
			LastSeenUtc = System.DateTime.UtcNow;
		}

		[MethodImpl((MethodImplOptions)8)]
		public void IqsL0cWOdYc(byte[] datagram, List<ValueTuple<byte[], Jgaq6ef4PuO0JxER8Odt?>> frames)
		{
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0298: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
			global::System.Collections.Generic.IEnumerator<ValueTuple<byte[], Jgaq6ef4PuO0JxER8Odt?>> enumerator = default(global::System.Collections.Generic.IEnumerator<ValueTuple<byte[], Jgaq6ef4PuO0JxER8Odt?>>);
			Jgaq6ef4PuO0JxER8Odt? item = default(Jgaq6ef4PuO0JxER8Odt?);
			int num6 = default(int);
			uint fragmentIndex = default(uint);
			uint num3 = default(uint);
			Jgaq6ef4PuO0JxER8Odt value = default(Jgaq6ef4PuO0JxER8Odt);
			int num8 = default(int);
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
					case 3:
						try
						{
							while (true)
							{
								int num4;
								if (!enumerator.MoveNext())
								{
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
									{
										num4 = 16;
									}
									goto IL_005a;
								}
								goto IL_00fe;
								IL_00fe:
								item = enumerator.Current.Item2;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num4 = 3;
								}
								goto IL_005a;
								IL_005a:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num6 != 16)
										{
											if (num6 == 996)
											{
												goto IL_0056;
											}
											goto IL_00fe;
										}
										if (!R5fL081yQtc.ContainsKey(fragmentIndex))
										{
											num4 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
											{
												num4 = 10;
											}
											continue;
										}
										break;
									case 0:
									{
										num3 = System.Math.Min(num3, fragmentIndex);
										int num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
										{
											num5 = 16;
										}
										num6 = num5;
										goto IL_0056;
									}
									case 4:
									case 8:
										break;
									case 5:
										goto IL_00fe;
									case 6:
										fragmentIndex = value.FragmentIndex;
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
										{
											num4 = 0;
										}
										continue;
									case 1:
										R5fL081yQtc[fragmentIndex] = (l3HoHoL0Jc7JtFYJrNwh)new l3HoHoL0Jc7JtFYJrNwh(datagram, fragmentIndex);
										num4 = 4;
										continue;
									case 7:
										value = item.Value;
										num4 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
										{
											num4 = 6;
										}
										continue;
									case 3:
										if (!item.HasValue)
										{
											num4 = 8;
											continue;
										}
										goto case 7;
									case 2:
										return;
										IL_0056:
										num4 = num6;
										continue;
									}
									break;
								}
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num7 = 5;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					case 0:
						return;
					case 2:
						num3 = 4294967295u;
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						enumerator = frames.GetEnumerator();
						num2 = 3;
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public global::System.Collections.Generic.IReadOnlyList<byte[]> WGbL00GC8tx()
		{
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0104: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			int num = 14;
			List<ValueTuple<byte[], uint>> val3 = default(List<ValueTuple<byte[], uint>>);
			Dictionary<byte[], uint> val = default(Dictionary<byte[], uint>);
			uint num10 = default(uint);
			l3HoHoL0Jc7JtFYJrNwh l3HoHoL0Jc7JtFYJrNwh = default(l3HoHoL0Jc7JtFYJrNwh);
			global::System.Collections.Generic.Dictionary<byte[], uint>.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<byte[], uint>.Enumerator);
			uint num15 = default(uint);
			global::System.Collections.Generic.IEnumerator<ValueTuple<byte[], uint>> enumerator2 = default(global::System.Collections.Generic.IEnumerator<ValueTuple<byte[], uint>>);
			int num11 = default(int);
			List<byte[]> val2 = default(List<byte[]>);
			byte[] item = default(byte[]);
			int num14 = default(int);
			int num5 = default(int);
			byte[] array = default(byte[]);
			byte[] array2 = default(byte[]);
			uint num6 = default(uint);
			KeyValuePair<byte[], uint> current = default(KeyValuePair<byte[], uint>);
			uint num7 = default(uint);
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
						default:
							if (num2 != 24)
							{
								if (num2 == 1005)
								{
									goto end_IL_0010;
								}
								goto case 5;
							}
							goto case 11;
						case 8:
							val3 = new List<ValueTuple<byte[], uint>>(val.Count);
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
						case 4:
							if (R5fL081yQtc.TryGetValue(num10, out l3HoHoL0Jc7JtFYJrNwh))
							{
								num3 = 7;
								continue;
							}
							goto case 10;
						case 9:
							val[l3HoHoL0Jc7JtFYJrNwh.Datagram] = l3HoHoL0Jc7JtFYJrNwh.FirstFragmentIndex;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
							{
								num3 = 4;
							}
							continue;
						case 0:
							enumerator = val.GetEnumerator();
							num3 = 6;
							continue;
						case 10:
							return global::System.Array.Empty<byte[]>();
						case 7:
							if (val.TryGetValue(l3HoHoL0Jc7JtFYJrNwh.Datagram, out num15))
							{
								num3 = 5;
								continue;
							}
							goto case 9;
						case 5:
							if (l3HoHoL0Jc7JtFYJrNwh.FirstFragmentIndex < num15)
							{
								num3 = 9;
								continue;
							}
							goto case 2;
						case 12:
							enumerator2 = val3.GetEnumerator();
							num3 = 3;
							continue;
						case 13:
							break;
						case 3:
							try
							{
								while (true)
								{
									IL_0222:
									if (!enumerator2.MoveNext())
									{
										num11 = 10;
										goto IL_01c4;
									}
									goto IL_0238;
									IL_01c8:
									int num12;
									while (true)
									{
										switch (num12)
										{
										case 1:
											val2.Add(item);
											num12 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
											{
												num12 = 0;
											}
											continue;
										case 0:
											goto IL_0222;
										case 2:
											goto IL_0238;
										}
										break;
									}
									switch (num11)
									{
									case 990:
										break;
									default:
										continue;
									case 10:
										goto end_IL_0222;
									}
									goto IL_01c4;
									IL_0238:
									item = enumerator2.Current.Item1;
									num12 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
									{
										num12 = 4;
									}
									goto IL_01c8;
									IL_01c4:
									num12 = num11;
									goto IL_01c8;
									continue;
									end_IL_0222:
									break;
								}
							}
							finally
							{
								((global::System.IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
								int num13 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
								{
									num13 = 1;
								}
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 988)
										{
											num13 = num14;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 16;
						case 11:
							if (num10 < CompoundSize)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto case 8;
						case 2:
							num10++;
							num3 = 11;
							continue;
						case 6:
							try
							{
								while (true)
								{
									IL_0408:
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
										{
											num4 = 0;
										}
										goto IL_0357;
									}
									goto IL_03b1;
									IL_0353:
									num4 = num5;
									goto IL_0357;
									IL_0357:
									while (true)
									{
										switch (num4)
										{
										case 3:
											array = array2;
											num4 = 2;
											continue;
										case 2:
											goto IL_03a3;
										case 1:
											goto end_IL_0357;
										case 5:
											val3.Add(new ValueTuple<byte[], uint>(array, num6));
											num4 = 4;
											continue;
										case 4:
											goto IL_0408;
										case 0:
											goto end_IL_0408;
										}
										if (num5 != 13)
										{
											if (num5 == 993)
											{
												goto IL_0353;
											}
											goto IL_03a3;
										}
										current.Deconstruct(out array2, out num7);
										num4 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num4 = 10;
										}
										continue;
										IL_03a3:
										num6 = num7;
										num4 = 5;
										continue;
										end_IL_0357:
										break;
									}
									goto IL_03b1;
									IL_03b1:
									current = enumerator.Current;
									num5 = 13;
									goto IL_0353;
									continue;
									end_IL_0408:
									break;
								}
							}
							finally
							{
								((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
								int num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
								{
									num8 = 5;
								}
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 988)
										{
											num8 = num9;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							goto case 15;
						case 17:
							val2 = new List<byte[]>(val3.Count);
							num3 = 12;
							continue;
						case 16:
							return (global::System.Collections.Generic.IReadOnlyList<byte[]>)val2;
						case 14:
							val = new Dictionary<byte[], uint>((IEqualityComparer<byte[]>)(object)System.Collections.Generic.ReferenceEqualityComparer.Instance);
							num3 = 13;
							continue;
						case 15:
							val3.Sort((Comparison<ValueTuple<byte[], uint>>)([MethodImpl((MethodImplOptions)8)] (ValueTuple<byte[], uint> a, ValueTuple<byte[], uint> b) => (a.Item2).CompareTo(b.Item2)));
							num3 = 17;
							continue;
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
				num10 = 0u;
				num = 24;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
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
		internal static bool QkaWP6DCDULa0tjWvWf6()
		{
			return mlOvLxDC9q8UqEyYbQ9s == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static WABifbL0YksDdAUHhsfh xxV0QSDCkMfIS5iPAGHX()
		{
			return (WABifbL0YksDdAUHhsfh)mlOvLxDC9q8UqEyYbQ9s;
		}
	}

	private sealed class l3HoHoL0Jc7JtFYJrNwh : IEquatable<l3HoHoL0Jc7JtFYJrNwh>
	{
		[CompilerGenerated]
		private byte[] _Datagram_k__BackingField;

		[CompilerGenerated]
		private uint _FirstFragmentIndex_k__BackingField;

		private static object PL4PhTDCVWZs1Qt7KBM5;

		[CompilerGenerated]
		private global::System.Type EqualityContract
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return System.Type.GetTypeFromHandle(typeof(l3HoHoL0Jc7JtFYJrNwh).TypeHandle);
			}
		}

		public byte[] Datagram
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _Datagram_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_Datagram_k__BackingField = value;
			}
		}

		public uint FirstFragmentIndex
		{
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			get
			{
				return _FirstFragmentIndex_k__BackingField;
			}
			[MethodImpl((MethodImplOptions)8)]
			[CompilerGenerated]
			set
			{
				_FirstFragmentIndex_k__BackingField = value;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public l3HoHoL0Jc7JtFYJrNwh(byte[] Datagram, uint FirstFragmentIndex)
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override string ToString()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Expected O, but got Unknown
			StringBuilder val = new StringBuilder();
			return null;
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private bool q1TL0QkPDjE(StringBuilder builder)
		{
			int num = 2;
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
							case 992:
								break;
							default:
								goto end_IL_000c;
							case 11:
								goto IL_0102;
							}
							break;
						case 0:
							(builder).Append(", FirstFragmentIndex = ");
							num3 = 3;
							continue;
						case 2:
							goto end_IL_000c;
						case 1:
							return true;
						case 3:
							(builder).Append(((object)FirstFragmentIndex/*cast due to .constrained prefix*/).ToString());
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							{
								(builder).Append(Datagram);
								num3 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
								{
									num3 = 0;
								}
								continue;
							}
							IL_0102:
							(builder).Append("Datagram = ");
							num3 = 4;
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
				num = 11;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator !=(l3HoHoL0Jc7JtFYJrNwh? left, l3HoHoL0Jc7JtFYJrNwh? right)
		{
			return !(left == right);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public static bool operator ==(l3HoHoL0Jc7JtFYJrNwh? left, l3HoHoL0Jc7JtFYJrNwh? right)
		{
			int num = 3;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override int GetHashCode()
		{
			return (EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(_Datagram_k__BackingField)) * -1521134295 + EqualityComparer<uint>.Default.GetHashCode(_FirstFragmentIndex_k__BackingField);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public override bool Equals(object? obj)
		{
			return Equals(obj as l3HoHoL0Jc7JtFYJrNwh);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public bool Equals(l3HoHoL0Jc7JtFYJrNwh? other)
		{
			int num = 4;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public l3HoHoL0Jc7JtFYJrNwh d6ZL0Ctbw73()
		{
			return (l3HoHoL0Jc7JtFYJrNwh)new l3HoHoL0Jc7JtFYJrNwh(this);
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		private l3HoHoL0Jc7JtFYJrNwh(l3HoHoL0Jc7JtFYJrNwh original)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
			{
				num = 2;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 == 990)
					{
						num = num2;
						continue;
					}
					break;
				case 2:
					_Datagram_k__BackingField = original._Datagram_k__BackingField;
					num = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
					{
						num = 6;
					}
					continue;
				case 1:
					break;
				case 0:
					return;
				}
				_FirstFragmentIndex_k__BackingField = original._FirstFragmentIndex_k__BackingField;
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		public void p2NL04OmBM3(out byte[] Datagram, out uint FirstFragmentIndex)
		{
		Datagram = default(byte[]);
		FirstFragmentIndex = default(uint);
			//IL_0008: Expected I8, but got O
Datagram = this.Datagram;  // was Unsafe.As<_,long> reinterpret
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool Sc7w5sDCYk4hANT9Nyav()
		{
			return PL4PhTDCVWZs1Qt7KBM5 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static l3HoHoL0Jc7JtFYJrNwh KvsvnjDCS6cjv7RDysga()
		{
			return (l3HoHoL0Jc7JtFYJrNwh)PL4PhTDCVWZs1Qt7KBM5;
		}
	}

	private static readonly TimeSpan nwyfUjga6Kx;

	private readonly Dictionary<ushort, WABifbL0YksDdAUHhsfh> IxUfUZai6jL;

	private static object ojhkbmZaXnoZMVxedBDR;

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Collections.Generic.IReadOnlyList<byte[]> yvkfUbGTuHT(byte[] datagram)
	{
		Jgaq6ef4PuO0JxER8Odt jgaq6ef4PuO0JxER8Odt = default(Jgaq6ef4PuO0JxER8Odt);
		WABifbL0YksDdAUHhsfh wABifbL0YksDdAUHhsfh = (WABifbL0YksDdAUHhsfh)new WABifbL0YksDdAUHhsfh(jgaq6ef4PuO0JxER8Odt.CompoundSize);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool dsffUXUaWkk(Jgaq6ef4PuO0JxER8Odt fragment)
	{
		uint compoundSize = fragment.CompoundSize;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Sv4fUfH1MMY()
	{
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_039c: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		global::System.Collections.Generic.Dictionary<ushort, WABifbL0YksDdAUHhsfh>.Enumerator enumerator2 = default(global::System.Collections.Generic.Dictionary<ushort, WABifbL0YksDdAUHhsfh>.Enumerator);
		int num11 = default(int);
		global::System.DateTime dateTime = default(global::System.DateTime);
		WABifbL0YksDdAUHhsfh wABifbL0YksDdAUHhsfh = default(WABifbL0YksDdAUHhsfh);
		ushort num13 = default(ushort);
		ushort num12 = default(ushort);
		KeyValuePair<ushort, WABifbL0YksDdAUHhsfh> current2 = default(KeyValuePair<ushort, WABifbL0YksDdAUHhsfh>);
		WABifbL0YksDdAUHhsfh wABifbL0YksDdAUHhsfh2 = default(WABifbL0YksDdAUHhsfh);
		List<ushort> val = default(List<ushort>);
		int num15 = default(int);
		global::System.Collections.Generic.IEnumerator<ushort> enumerator = default(global::System.Collections.Generic.IEnumerator<ushort>);
		int num5 = default(int);
		ushort current = default(ushort);
		int num8 = default(int);
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
						if (num2 != 15)
						{
							goto end_IL_0010;
						}
						try
						{
							while (true)
							{
								int num9;
								if (!enumerator2.MoveNext())
								{
									num9 = 10;
									goto IL_0272;
								}
								goto IL_03f8;
								IL_0272:
								while (true)
								{
									switch (num9)
									{
									default:
										if (num11 != 18)
										{
											if (num11 == 998)
											{
												goto IL_026e;
											}
											goto case 3;
										}
										if (((dateTime - wABifbL0YksDdAUHhsfh.LastSeenUtc) <= nwyfUjga6Kx))
										{
											num9 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
											{
												num9 = 13;
											}
											continue;
										}
										goto IL_0345;
									case 1:
										num13 = num12;
										num9 = 8;
										continue;
									case 0:
										current2.Deconstruct(out num12, out wABifbL0YksDdAUHhsfh2);
										num9 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
										{
											num9 = 5;
										}
										continue;
									case 9:
										break;
									case 8:
									{
										wABifbL0YksDdAUHhsfh = wABifbL0YksDdAUHhsfh2;
										int num10 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
										{
											num10 = 18;
										}
										num11 = num10;
										goto IL_026e;
									}
									case 7:
										goto IL_0345;
									case 4:
									case 6:
										goto end_IL_0272;
									case 3:
									case 5:
										val.Add(num13);
										num9 = 6;
										continue;
									case 2:
										goto IL_03f8;
									case 10:
										goto end_IL_03cf;
										IL_026e:
										num9 = num11;
										continue;
									}
									goto IL_02fc;
									IL_0345:
									if (val != null)
									{
										num9 = 3;
										continue;
									}
									goto IL_02fc;
									IL_02fc:
									val = new List<ushort>();
									num9 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
									{
										num9 = 5;
									}
									continue;
									end_IL_0272:
									break;
								}
								continue;
								IL_03f8:
								current2 = enumerator2.Current;
								num9 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
								{
									num9 = 0;
								}
								goto IL_0272;
								continue;
								end_IL_03cf:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator2/*cast due to .constrained prefix*/).Dispose();
							int num14 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								num14 = 0;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 988)
									{
										num14 = num15;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					case 1:
						if (val != null)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						return;
					case 6:
						return;
					case 8:
						return;
					case 2:
						return;
					case 3:
						enumerator = val.GetEnumerator();
						num3 = 5;
						continue;
					case 5:
						try
						{
							while (true)
							{
								IL_0155:
								if (!enumerator.MoveNext())
								{
									int num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
									{
										num4 = 7;
									}
									num5 = num4;
									goto IL_00df;
								}
								goto IL_0142;
								IL_0142:
								current = enumerator.Current;
								int num6 = 2;
								goto IL_00e3;
								IL_00df:
								num6 = num5;
								goto IL_00e3;
								IL_00e3:
								while (true)
								{
									switch (num6)
									{
									default:
										if (num5 == 10)
										{
											return;
										}
										if (num5 == 990)
										{
											goto IL_00df;
										}
										goto case 2;
									case 2:
										IxUfUZai6jL.Remove(current);
										num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
										{
											num6 = 10;
										}
										continue;
									case 1:
										break;
									case 0:
										goto IL_0155;
									}
									break;
								}
								goto IL_0142;
							}
						}
						finally
						{
							((global::System.IDisposable)enumerator/*cast due to .constrained prefix*/).Dispose();
							int num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					case 0:
						val = null;
						num3 = 4;
						continue;
					case 7:
						if (IxUfUZai6jL.Count != 0)
						{
							dateTime = System.DateTime.UtcNow;
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
							{
								num3 = 6;
							}
						}
						continue;
					case 4:
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
			while (num2 == 996);
			enumerator2 = IxUfUZai6jL.GetEnumerator();
			num = 15;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public GSPUnmfhnHvPSJq04TXW()
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
	internal static bool yd7fKfZafWI118yPOeuS()
	{
		return ojhkbmZaXnoZMVxedBDR == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static GSPUnmfhnHvPSJq04TXW ogMgU2ZaLqhfX5C7m8sc()
	{
		return (GSPUnmfhnHvPSJq04TXW)ojhkbmZaXnoZMVxedBDR;
	}
}

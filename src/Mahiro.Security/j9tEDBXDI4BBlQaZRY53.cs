using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CxGdaTfsPXHFJMkSvgfS;
using fDAldojjppXrctUVYOJn;
using taWwShfspvnkAftsyduy;

namespace hEDUNKXDBjGMV0Pg8mqg;

internal class j9tEDBXDI4BBlQaZRY53
{
	[CompilerGenerated]
	private class __O_4
	{
		public static Func<string, CancellationToken, global::System.Threading.Tasks.Task<int?>> _0___ProbeVersionFeatureAsync;

		internal static __O_4 CphNLN9euLP9Yo08O94s;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool ADZi2k9eaWE2TdgSK5kC()
		{
			return CphNLN9euLP9Yo08O94s == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __O_4 dogPeV9e1vfaqurblPvF()
		{
			return CphNLN9euLP9Yo08O94s;
		}
	}

	internal static object wYH3i9ZAGB9fi7wOFMiw;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<YilkAdfsMNIVjttjoUmR> ValidateAsync(object javaPath, object profile, Func<string, CancellationToken, global::System.Threading.Tasks.Task<int?>>? versionProbe, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ValidateAsync_d__2 validateAsync_d__ = default(_ValidateAsync_d__2);
		validateAsync_d__.__t__builder = AsyncTaskMethodBuilder<YilkAdfsMNIVjttjoUmR>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool tHQXDgKxVAu(object path, out YUXTaAfseVyqAZymtKYj architecture)
	{
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		int num = 2;
		int num4 = default(int);
		int num6 = default(int);
		int num9 = default(int);
		bool result = default(bool);
		int num10 = default(int);
		ushort num8 = default(ushort);
		int num13 = default(int);
		int num15 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num16);
		global::System.Exception ex = default(global::System.Exception);
		int num17 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num18);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num20 = default(int);
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
						goto end_IL_0010;
					}
					goto case 2;
				case 2:
					architecture = YUXTaAfseVyqAZymtKYj.X64;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
					{
						num2 = 5;
					}
					continue;
				case 0:
					break;
				case 1:
					try
					{
						FileStream val = new FileStream((string)path, (FileMode)3, (FileAccess)1, (FileShare)7);
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0092;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0092:
							num3 = num4;
						}
						try
						{
							BinaryReader val2 = new BinaryReader((Stream)(object)val);
							int num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num5 = 2;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 == 988)
									{
										goto IL_00e9;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_00e9:
								num5 = num6;
							}
							try
							{
								int num7;
								if ((val).Length < 64)
								{
									num7 = 32;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
									{
										num7 = 20;
									}
									goto IL_014f;
								}
								goto IL_0294;
								IL_0294:
								if ((val2).ReadUInt16() != 23117)
								{
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
									{
										num7 = 0;
									}
									goto IL_014f;
								}
								goto IL_02c9;
								IL_02c9:
								(val).Position = 60L;
								num7 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
								{
									num7 = 24;
								}
								goto IL_014f;
								IL_014f:
								while (true)
								{
									int num11;
									switch (num7)
									{
									default:
										if (num9 != 32)
										{
											if (num9 == 1012)
											{
												goto IL_014b;
											}
											goto case 4;
										}
										if ((val2).ReadUInt32() != 17744)
										{
											num7 = 10;
											continue;
										}
										goto IL_038c;
									case 23:
										break;
									case 24:
										break;
									case 8:
										architecture = YUXTaAfseVyqAZymtKYj.Arm64;
										num11 = 2;
										goto IL_0147;
									case 1:
									case 20:
										result = false;
										num7 = 24;
										continue;
									case 2:
										result = true;
										num7 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
										{
											num7 = 22;
										}
										continue;
									case 14:
										break;
									case 6:
										(val).Position = num10;
										num11 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
										{
											num11 = 32;
										}
										goto IL_0147;
									case 13:
										goto IL_0294;
									case 17:
										goto IL_02c9;
									case 4:
										if (num8 == 43620)
										{
											num7 = 8;
											continue;
										}
										goto case 7;
									case 10:
										result = false;
										num7 = 26;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
										{
											num7 = 0;
										}
										continue;
									case 11:
										if (num10 > (val).Length - 6)
										{
											num11 = 15;
											goto IL_0147;
										}
										goto case 6;
									case 0:
										break;
									case 16:
										num10 = (val2).ReadInt32();
										num7 = 18;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num7 = 26;
										}
										continue;
									case 21:
										goto IL_038c;
									case 7:
										result = false;
										num7 = 3;
										continue;
									case 18:
										if (num10 < 0)
										{
											num7 = 19;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
											{
												num7 = 17;
											}
											continue;
										}
										goto case 11;
									case 5:
										architecture = YUXTaAfseVyqAZymtKYj.X64;
										num7 = 12;
										continue;
									case 12:
										result = true;
										num7 = 23;
										continue;
									case 15:
									case 19:
										result = false;
										num7 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
										{
											num7 = 14;
										}
										continue;
									case 9:
										if (num8 == 34404)
										{
											num7 = 5;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
											{
												num7 = 30;
											}
											continue;
										}
										goto case 4;
									case 22:
										break;
									case 3:
										break;
										IL_014b:
										num7 = num9;
										continue;
										IL_0147:
										num9 = num11;
										goto IL_014b;
									}
									break;
									IL_038c:
									num8 = (val2).ReadUInt16();
									num7 = 9;
								}
							}
							finally
							{
								int num12;
								if (val2 == null)
								{
									num12 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
									{
										num12 = 6;
									}
									goto IL_04cf;
								}
								goto IL_0517;
								IL_04cf:
								while (true)
								{
									switch (num12)
									{
									default:
										if (num13 == 990)
										{
											goto IL_04cb;
										}
										goto end_IL_04cf;
									case 0:
										goto end_IL_04cf;
									case 1:
										break;
									case 2:
										goto end_IL_04cf;
									}
									goto IL_0517;
									IL_04cb:
									num12 = num13;
									continue;
									end_IL_04cf:
									break;
								}
								goto end_IL_0497;
								IL_0517:
								(val2).Dispose();
								num12 = 2;
								goto IL_04cf;
								end_IL_0497:;
							}
						}
						finally
						{
							int num14;
							if (val == null)
							{
								num14 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num14 = 2;
								}
								goto IL_0566;
							}
							goto IL_0599;
							IL_0566:
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 990)
									{
										goto IL_0562;
									}
									goto end_IL_0566;
								case 0:
									goto end_IL_0566;
								case 2:
									break;
								case 1:
									goto end_IL_0566;
								}
								goto IL_0599;
								IL_0562:
								num14 = num15;
								continue;
								end_IL_0566:
								break;
							}
							goto end_IL_052e;
							IL_0599:
							(val).Dispose();
							num14 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
							{
								num14 = 1;
							}
							goto IL_0566;
							end_IL_052e:;
						}
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num16 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num16 = 8;
							}
						}
						else
						{
							ex = obj2;
							num16 = 7;
						}
						while (true)
						{
							switch (num16)
							{
							default:
								if (num17 != 17)
								{
									if (num17 == 997)
									{
										goto IL_0603;
									}
									goto case 2;
								}
								goto case 4;
							case 5:
							case 9:
								flag = false;
								num18 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
								{
									num18 = 16;
								}
								num17 = num18;
								goto IL_0603;
							case 0:
							case 6:
								flag = true;
								num16 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
								{
									num16 = 10;
								}
								continue;
							case 2:
								if (!(ex is NotSupportedException))
								{
									num16 = 5;
									continue;
								}
								goto case 0;
							case 7:
								if (ex is IOException)
								{
									num16 = 6;
									continue;
								}
								goto case 3;
							case 3:
								if (!(ex is UnauthorizedAccessException))
								{
									num16 = 8;
									continue;
								}
								goto case 0;
							case 8:
								if (!(ex is ArgumentException))
								{
									num16 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
									{
										num16 = 8;
									}
									continue;
								}
								goto case 0;
							case 1:
								result2 = 0;
								break;
							case 4:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0603:
								num16 = num17;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num19 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
						{
							num19 = 1;
						}
						while (true)
						{
							switch (num19)
							{
							default:
								if (num20 == 989)
								{
									num19 = num20;
									continue;
								}
								break;
							case 1:
								result = false;
								num19 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
								{
									num19 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					break;
				}
				architecture = default;
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int? mQvXDlInaxt(object value)
	{
		int num2 = default(int);
		int num = num2 + 1;
		int num3 = default(int);
		string text = ((dynamic)(value)).Substring(num, num3 - num);
		char[] array = new char[4];
		System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array, default(RuntimeFieldHandle));
		string[] array2 = (text).Split(array, (StringSplitOptions)1);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<int?> HdVXDdplO3h(object javaPath, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ProbeVersionFeatureAsync_d__5 probeVersionFeatureAsync_d__ = default(_ProbeVersionFeatureAsync_d__5);
		probeVersionFeatureAsync_d__.__t__builder = AsyncTaskMethodBuilder<int?>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void qpnXDK58pjd(object process)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					if (((dynamic)(process)).HasExited)
					{
						return;
					}
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
					{
						num2 = 5;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						((dynamic)(process)).Kill(true);
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
						{
							num2 = 5;
						}
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 2;
						goto IL_00eb;
					}
					ex = obj2;
					num5 = 13;
					goto IL_00e3;
					IL_00e3:
					num6 = num5;
					goto IL_00e7;
					IL_00e7:
					num4 = num6;
					goto IL_00eb;
					IL_00eb:
					while (true)
					{
						switch (num4)
						{
						default:
							if (num6 != 13)
							{
								if (num6 == 993)
								{
									goto IL_00e7;
								}
								goto case 1;
							}
							if (!(ex is InvalidOperationException))
							{
								num4 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num4 = 3;
								}
								continue;
							}
							break;
						case 5:
							break;
						case 0:
							flag = false;
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
							{
								num4 = 8;
							}
							continue;
						case 3:
							if (ex is Win32Exception)
							{
								goto end_IL_00eb;
							}
							goto case 0;
						case 2:
							result = 0;
							goto IL_01d4;
						case 1:
						case 4:
							{
								result = (flag ? 1 : 0);
								goto IL_01d4;
							}
							IL_01d4:
							return (byte)result != 0;
						}
						flag = true;
						num4 = 4;
						continue;
						end_IL_00eb:
						break;
					}
					num5 = 5;
					goto IL_00e3;
				}).Invoke())
				{
					int num7 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						case 0:
							return;
						}
						if (num8 != 988)
						{
							return;
						}
						num7 = num8;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string gG3XDHNijaO(YUXTaAfseVyqAZymtKYj architecture)
	{
		int num = 1;
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
	internal static bool FX16CqZAii27fVprDjZp()
	{
		return wYH3i9ZAGB9fi7wOFMiw == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static j9tEDBXDI4BBlQaZRY53 EFkli9ZAnGsJhnlXaGj1()
	{
		return (j9tEDBXDI4BBlQaZRY53)wYH3i9ZAGB9fi7wOFMiw;
	}
}

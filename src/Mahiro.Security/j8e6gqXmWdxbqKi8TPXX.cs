using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using Microsoft.Win32;
using fDAldojjppXrctUVYOJn;
using xSfwq9Xm7xqMPlEbCmVg;

namespace fovBsgXmJjXaAHnYIpYT;

internal class j8e6gqXmWdxbqKi8TPXX
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass2_0_1
	{
		public string scope;

		public string executablePath;

		public string value;

		private static __c__DisplayClass2_0_1 piFyF19pTKrW9IBdAeya;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass2_0_1()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool teJLXBaLifG(u2wX7OXmm596Kces5hZd item)
		{
			int num = 4;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool rw1qSx9pNGaoEx5QIIYa()
		{
			return piFyF19pTKrW9IBdAeya == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass2_0_1 SImitT9pMagclVtvCPBn()
		{
			return piFyF19pTKrW9IBdAeya;
		}
	}

	internal static object eDUjntZtVBFvFFOXxVmN;

	[MethodImpl((MethodImplOptions)8)]
	internal static List<u2wX7OXmm596Kces5hZd> HquXmQmPPav(object executablePath)
	{
		List<u2wX7OXmm596Kces5hZd> results = default(List<u2wX7OXmm596Kces5hZd>);
		string executablePath2 = default(string);
		iK7XmCKOHiS(results, (RegistryHive)(-2147483646), "HKLM", (RegistryView)256, executablePath2);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void iK7XmCKOHiS(List<u2wX7OXmm596Kces5hZd> results, RegistryHive hive, object scope, RegistryView view, object executablePath)
	{
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Invalid comparison between Unknown and I4
		int num = 2;
		__c__DisplayClass2_0_1 _c__DisplayClass2_0_ = default(__c__DisplayClass2_0_1);
		int num14 = default(int);
		int num11 = default(int);
		int num8 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		int num16 = default(int);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						_c__DisplayClass2_0_.scope = (string)scope;
						num3 = 3;
						continue;
					case 2:
						break;
					case 1:
						return;
					case 0:
						try
						{
							RegistryKey val = Microsoft.Win32.RegistryKey.OpenBaseKey(hive, view);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
							{
								num4 = 7;
							}
							while (true)
							{
								switch (num4)
								{
								case 0:
									return;
								default:
									if (num14 != 989)
									{
										return;
									}
									break;
								case 1:
									try
									{
										RegistryKey val2 = (val).OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", false);
										int num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												return;
											default:
												if (num11 != 989)
												{
													return;
												}
												break;
											case 0:
												try
												{
													__c__DisplayClass2_0_1 _c__DisplayClass2_0_2 = _c__DisplayClass2_0_;
													object value;
													if (val2 == null)
													{
														value = null;
													}
													else
													{
														object obj = (val2).GetValue(_c__DisplayClass2_0_.executablePath, null, (RegistryValueOptions)1);
														value = ((obj != null) ? (obj).ToString() : null);
													}
													_c__DisplayClass2_0_2.value = (string)value;
													int num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
													{
														num6 = 2;
													}
													while (true)
													{
														int num7;
														switch (num6)
														{
														case 2:
															return;
														case 5:
															return;
														default:
															if (num8 == 13 || num8 != 993)
															{
																return;
															}
															goto IL_01c7;
														case 1:
															break;
														case 3:
															if (!string.IsNullOrWhiteSpace(_c__DisplayClass2_0_.value))
															{
																break;
															}
															num7 = 13;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
															{
																num7 = 13;
															}
															goto IL_01c3;
														case 0:
														case 4:
															{
																results.Add((u2wX7OXmm596Kces5hZd)new u2wX7OXmm596Kces5hZd
																{
																	Scope = _c__DisplayClass2_0_.scope,
																	RegistryView = (((int)view == 256) ? "64-bit" : "32-bit"),
																	RegistryPath = string.Concat(_c__DisplayClass2_0_.scope, "\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers"),
																	ExecutablePath = _c__DisplayClass2_0_.executablePath,
																	Value = _c__DisplayClass2_0_.value,
																	ContainsRunAsAdmin = (_c__DisplayClass2_0_.value).Contains("RUNASADMIN", (StringComparison)5)
																});
																num7 = 5;
																goto IL_01c3;
															}
															IL_01c7:
															num6 = num8;
															continue;
															IL_01c3:
															num8 = num7;
															goto IL_01c7;
														}
														if (results.Exists((Predicate<u2wX7OXmm596Kces5hZd>)_c__DisplayClass2_0_.teJLXBaLifG))
														{
															break;
														}
														num6 = 4;
													}
													return;
												}
												finally
												{
													int num9;
													if (val2 == null)
													{
														num9 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
														{
															num9 = 0;
														}
														goto IL_03ee;
													}
													goto IL_0412;
													IL_0412:
													(val2).Dispose();
													num10 = 2;
													goto IL_03ea;
													IL_03ea:
													num9 = num10;
													goto IL_03ee;
													IL_03ee:
													switch (num9)
													{
													case 1:
														goto IL_0412;
													case 0:
														goto end_IL_03b6;
													case 2:
														goto end_IL_03b6;
													}
													if (num10 == 990)
													{
														goto IL_03ea;
													}
													end_IL_03b6:;
												}
											}
											num5 = num11;
										}
									}
									finally
									{
										int num12;
										if (val == null)
										{
											num12 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
											{
												num12 = 2;
											}
											goto IL_04a9;
										}
										goto IL_04f1;
										IL_04a9:
										while (true)
										{
											switch (num12)
											{
											default:
												if (num13 == 990)
												{
													goto IL_04a5;
												}
												goto end_IL_04a9;
											case 2:
												goto end_IL_04a9;
											case 1:
												break;
											case 0:
												goto end_IL_04a9;
											}
											goto IL_04f1;
											IL_04a5:
											num12 = num13;
											continue;
											end_IL_04a9:
											break;
										}
										goto end_IL_0471;
										IL_04f1:
										(val).Dispose();
										num12 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
										{
											num12 = 0;
										}
										goto IL_04a9;
										end_IL_0471:;
									}
								}
								num4 = num14;
							}
						}
						catch
						{
							int num15 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
							{
								num15 = 0;
							}
							while (true)
							{
								switch (num15)
								{
								case 0:
									return;
								}
								if (num16 != 988)
								{
									return;
								}
								num15 = num16;
							}
						}
					case 3:
						_c__DisplayClass2_0_.executablePath = (string)executablePath;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							num3 = 0;
						}
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
			_c__DisplayClass2_0_ = (__c__DisplayClass2_0_1)new __c__DisplayClass2_0_1();
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
			{
				num = 10;
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
	internal static bool M3HGgWZtYUSPfFlE8eB9()
	{
		return eDUjntZtVBFvFFOXxVmN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static j8e6gqXmWdxbqKi8TPXX pcDXR9ZtSA89HxtgryAt()
	{
		return (j8e6gqXmWdxbqKi8TPXX)eDUjntZtVBFvFFOXxVmN;
	}
}

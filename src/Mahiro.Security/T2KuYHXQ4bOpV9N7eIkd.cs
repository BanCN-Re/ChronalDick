using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using L920rlXJE07t7SweCSKe;
using PYtrATXQkleGY8Irsp8C;
using Yh4txuXJnTvW8Kqtdvjl;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using kKgU7oXJe2vOmDo3xdOV;

namespace Aug6yjXQhgUII3q8HB25;

internal class T2KuYHXQ4bOpV9N7eIkd
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_23
	{
		public static readonly __c_23 __9;

		public static Func<string, string> __9__1_0;

		private static __c_23 ebAsax9ssg94ebBNqXUf;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_23()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
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
		internal string MDVLbK5Knvl(string path)
		{
			return path;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool pm9ORu9sTnLoIBnXUDpp()
		{
			return ebAsax9ssg94ebBNqXUf == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_23 cfHkTv9sNdYpMNlobZPr()
		{
			return ebAsax9ssg94ebBNqXUf;
		}
	}

	[CompilerGenerated]
	sealed class _DiscoverRoots_d__2 : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private string __2__current;

		private int __l__initialThreadId;

		private string[] _names_5__2;

		private DriveInfo[] __7__wrap2;

		private int __7__wrap3;

		private DriveInfo _drive_5__5;

		private string[] __7__wrap5;

		private int __7__wrap6;

		private global::System.Environment.SpecialFolder[] __7__wrap7;

		private string _root_5__9;

		internal static _DiscoverRoots_d__2 x7q2ZB9sMQP3MVgKs0nX;

		string System.Collections.Generic.IEnumerator<string>.Current
		{
			[MethodImpl((MethodImplOptions)8)]
			[DebuggerHidden]
			get
			{
				return __2__current;
			}
		}

		object System.Collections.IEnumerator.Current
		{
			[MethodImpl((MethodImplOptions)8)]
			[DebuggerHidden]
			get
			{
				return __2__current;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		public _DiscoverRoots_d__2(int __1__state)
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
			{
				num = 1;
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
						break;
					}
					goto case 2;
				case 2:
					__l__initialThreadId = System.Environment.CurrentManagedThreadId;
					num = 8;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
					{
						num = 0;
					}
					break;
				case 1:
					__1__state = __1__state;
					num = 2;
					break;
				case 0:
					return;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
		{
			__7__wrap2 = null;
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
		{
			string text = default(string);
			__2__current = System.IO.Path.Combine(((_drive_5__5).RootDirectory).FullName, text);
			return default(bool);
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_Collections_IEnumerator_Reset()
		{
			//IL_0003: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException();
		}

		void global::System.Collections.IEnumerator.Reset()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerator_Reset
			this.System_Collections_IEnumerator_Reset();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.Generic.IEnumerator<string> System_Collections_Generic_IEnumerable_System_String__GetEnumerator()
		{
			_DiscoverRoots_d__2 discoverRoots_d__ = (_DiscoverRoots_d__2)new _DiscoverRoots_d__2(0);
			return null;
		}

		global::System.Collections.Generic.IEnumerator<string> global::System.Collections.Generic.IEnumerable<string>.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_Generic_IEnumerable_System_String__GetEnumerator
			return this.System_Collections_Generic_IEnumerable_System_String__GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private global::System.Collections.IEnumerator System_Collections_IEnumerable_GetEnumerator()
		{
			return (global::System.Collections.IEnumerator)System_Collections_Generic_IEnumerable_System_String__GetEnumerator();
		}

		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_Collections_IEnumerable_GetEnumerator
			return this.System_Collections_IEnumerable_GetEnumerator();
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool A8i2jP9spui1UvMS3lIg()
		{
			return x7q2ZB9sMQP3MVgKs0nX == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _DiscoverRoots_d__2 Jrh8mJ9suxhTekk0nNr3()
		{
			return x7q2ZB9sMQP3MVgKs0nX;
		}
	}

	private static readonly HashSet<string> JZ5XQmEy4eD;

	private static object gCsaaJZdRM0cdJ2xASmq;

	[MethodImpl((MethodImplOptions)8)]
	internal static lfXX0hXJiENbR2koEBGi Scan(string? selectedDirectory, CancellationToken token)
	{
		//IL_1286: Unknown result type (might be due to invalid IL or missing references)
		//IL_128b: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		int num = 7;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num28 = default(int);
		string current3 = default(string);
		Queue<ValueTuple<string, int>> val7 = default(Queue<ValueTuple<string, int>>);
		int num31 = default(int);
		HashSet<string> val8 = default(HashSet<string>);
		string item = default(string);
		int num20 = default(int);
		int num16 = default(int);
		string current2 = default(string);
		int item2 = default(int);
		int num19 = default(int);
		HashSet<string> val = default(HashSet<string>);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num22);
		global::System.Exception ex2 = default(global::System.Exception);
		int num24 = default(int);
		bool flag2 = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num23);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num26 = default(int);
		List<string> val3 = default(List<string>);
		Dictionary<string, List<int>> val4 = default(Dictionary<string, List<int>>);
		int num5 = default(int);
		string current = default(string);
		int num7 = default(int);
		ALrkVcXQDsZJ0xckHeBI aLrkVcXQDsZJ0xckHeBI = default(ALrkVcXQDsZJ0xckHeBI);
		List<c2coImXJvwEghB4hbjMJ> val2 = default(List<c2coImXJvwEghB4hbjMJ>);
		string executable = default(string);
		string processSummary = default(string);
		List<int> val5 = default(List<int>);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		global::System.Exception ex = default(global::System.Exception);
		int num9 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num11 = default(int);
		int num13 = default(int);
		global::System.Collections.Generic.IEnumerable<string> enumerable2 = default(global::System.Collections.Generic.IEnumerable<string>);
		while (true)
		{
			int num2 = num;
			global::System.Collections.Generic.IEnumerable<string> enumerable;
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
						try
						{
							while (true)
							{
								IL_1180:
								int num27;
								if (!(enumerator).MoveNext())
								{
									num27 = 3;
									goto IL_10d9;
								}
								goto IL_110f;
								IL_10d5:
								num27 = num28;
								goto IL_10d9;
								IL_110f:
								current3 = enumerator.Current;
								int num29 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
								{
									num29 = 11;
								}
								num28 = num29;
								goto IL_10d5;
								IL_10fc:
								if (num28 != 991)
								{
									break;
								}
								goto IL_10d5;
								IL_10d9:
								while (true)
								{
									switch (num27)
									{
									case 2:
										goto end_IL_10d9;
									case 0:
										val7.Enqueue(new ValueTuple<string, int>(current3, 0));
										num27 = 1;
										continue;
									case 1:
										goto IL_1180;
									case 3:
										goto end_IL_1180;
									}
									if (num28 == 11)
									{
										if (System.IO.Directory.Exists(current3))
										{
											num27 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
											{
												num27 = 6;
											}
											continue;
										}
										goto IL_1180;
									}
									goto IL_10fc;
									continue;
									end_IL_10d9:
									break;
								}
								goto IL_110f;
								continue;
								end_IL_1180:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num30 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
								{
									num30 = 1;
								}
								while (true)
								{
									switch (num30)
									{
									default:
										if (num31 == 989)
										{
											num30 = num31;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_11d8;
									}
									(enumerator).Dispose();
									num30 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
									{
										num30 = 0;
									}
									continue;
									end_IL_11d8:
									break;
								}
							}
						}
						goto case 2;
					case 15:
						try
						{
							if (val8.Add(System.IO.Path.GetFullPath(item)))
							{
								int num14 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
								{
									num14 = 8;
								}
								while (true)
								{
									int num21;
									switch (num14)
									{
									default:
										if (num20 != 21)
										{
											if (num20 == 1001)
											{
												goto IL_00c4;
											}
											goto case 11;
										}
										if (System.IO.File.Exists(System.IO.Path.Combine(item, "chronal-runtime-profile.json")))
										{
											num14 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
											{
												num14 = 7;
											}
											continue;
										}
										goto case 10;
									case 8:
										if (!(System.IO.File.GetAttributes(item)).HasFlag((global::System.Enum)(object)(FileAttributes)1024))
										{
											num14 = 18;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
											{
												num14 = 4;
											}
											continue;
										}
										goto end_IL_00c8;
									case 6:
										if (System.IO.File.Exists(System.IO.Path.Combine(item, "jli.dll")))
										{
											break;
										}
										num21 = 21;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
										{
											num21 = 13;
										}
										goto IL_00c0;
									case 1:
										if (System.IO.File.Exists(System.IO.Path.Combine(item, "java.exe")))
										{
											num14 = 6;
											continue;
										}
										goto case 10;
									case 11:
									case 13:
										enumerator = System.IO.Directory.EnumerateDirectories(item).GetEnumerator();
										num14 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
										{
											num14 = 5;
										}
										continue;
									case 2:
									case 4:
										if (!System.IO.File.Exists(System.IO.Path.Combine(item, "javaw.exe")))
										{
											num14 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
											{
												num14 = 9;
											}
											continue;
										}
										goto case 6;
									case 5:
										try
										{
											while (true)
											{
												IL_03aa:
												if (!(enumerator).MoveNext())
												{
													int num15 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
													{
														num15 = 12;
													}
													num16 = num15;
													goto IL_0320;
												}
												goto IL_035e;
												IL_035e:
												current2 = enumerator.Current;
												int num17 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
												{
													num17 = 1;
												}
												goto IL_0324;
												IL_0324:
												while (true)
												{
													switch (num17)
													{
													default:
														if (num16 != 12)
														{
															if (num16 == 992)
															{
																goto IL_0320;
															}
															goto case 1;
														}
														goto end_IL_03aa;
													case 3:
														break;
													case 2:
													case 4:
														goto IL_03aa;
													case 0:
														val7.Enqueue(new ValueTuple<string, int>(current2, item2 + 1));
														num17 = 2;
														continue;
													case 1:
														if (JZ5XQmEy4eD.Contains(System.IO.Path.GetFileName(current2)))
														{
															num17 = 9;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
															{
																num17 = 4;
															}
															continue;
														}
														goto case 0;
													}
													break;
												}
												goto IL_035e;
												IL_0320:
												num17 = num16;
												goto IL_0324;
												continue;
												end_IL_03aa:
												break;
											}
										}
										finally
										{
											int num18;
											if (enumerator == null)
											{
												num18 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
												{
													num18 = 0;
												}
												goto IL_046d;
											}
											goto IL_0491;
											IL_046d:
											while (true)
											{
												switch (num18)
												{
												default:
													if (num19 == 990)
													{
														goto IL_0469;
													}
													goto end_IL_046d;
												case 1:
													break;
												case 0:
													goto end_IL_046d;
												case 2:
													goto end_IL_046d;
												}
												goto IL_0491;
												IL_0469:
												num18 = num19;
												continue;
												end_IL_046d:
												break;
											}
											goto end_IL_0435;
											IL_0491:
											(enumerator).Dispose();
											num18 = 2;
											goto IL_046d;
											end_IL_0435:;
										}
										goto end_IL_00c8;
									case 7:
										break;
									case 10:
										if (item2 < 8)
										{
											num21 = 13;
											goto IL_00c0;
										}
										goto end_IL_00c8;
									case 0:
										goto end_IL_00c8;
									case 3:
										goto end_IL_00c8;
									case 9:
										goto end_IL_00c8;
									case 12:
										goto end_IL_00c8;
										IL_00c0:
										num20 = num21;
										goto IL_00c4;
										IL_00c4:
										num14 = num20;
										continue;
									}
									val.Add(System.IO.Path.TrimEndingDirectorySeparator(System.IO.Path.GetFullPath(item)));
									num14 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
									{
										num14 = 0;
									}
									continue;
									end_IL_00c8:
									break;
								}
							}
						}
						catch (global::System.Exception obj3) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj4 = obj3 as global::System.Exception;
							if (obj4 == null)
							{
								num22 = 5;
							}
							else
							{
								ex2 = obj4;
								num22 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
								{
									num22 = 5;
								}
							}
							while (true)
							{
								switch (num22)
								{
								default:
									if (num24 != 16)
									{
										if (num24 == 996)
										{
											goto IL_05c9;
										}
										goto case 3;
									}
									goto case 0;
								case 8:
									if (!(ex2 is UnauthorizedAccessException))
									{
										num22 = 3;
										continue;
									}
									goto case 0;
								case 3:
									if (!(ex2 is ArgumentException))
									{
										num22 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
										{
											num22 = 4;
										}
										continue;
									}
									goto case 0;
								case 0:
									flag2 = true;
									num22 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
									{
										num22 = 8;
									}
									continue;
								case 1:
									if (ex2 is IOException)
									{
										num23 = 16;
										goto IL_05c5;
									}
									goto case 8;
								case 4:
								case 6:
									flag2 = false;
									num23 = 2;
									goto IL_05c5;
								case 5:
									result2 = 0;
									break;
								case 2:
								case 7:
									{
										result2 = (flag2 ? 1 : 0);
										break;
									}
									IL_05c5:
									num24 = num23;
									goto IL_05c9;
									IL_05c9:
									num22 = num24;
									continue;
								}
								break;
							}
							return (byte)result2 != 0;
						}).Invoke())
						{
							int num25 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num25 = 1;
							}
							while (true)
							{
								switch (num25)
								{
								default:
									if (num26 != 11)
									{
										if (num26 == 991)
										{
											goto IL_0750;
										}
										goto case 3;
									}
									break;
								case 2:
									break;
								case 3:
									if (val3.Count >= 20)
									{
										num25 = 2;
										continue;
									}
									goto case 0;
								case 0:
									val3.Add(string.Concat("扫描 ", item, "：", (ex2).Message));
									num26 = 11;
									goto IL_0750;
								case 1:
									{
										cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex2, "caught-exception", "Scan", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\RuntimeProfile\\JavaRuntimeProfileScanner.cs", 47);
										num25 = 3;
										continue;
									}
									IL_0750:
									num25 = num26;
									continue;
								}
								break;
							}
						}
						goto case 2;
					case 2:
						if (val7.Count <= 0)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
							{
								num3 = 8;
							}
							break;
						}
						goto case 5;
					case 9:
						if (selectedDirectory != null)
						{
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								num3 = 15;
							}
							break;
						}
						enumerable = Enumerable.Concat<string>(yGuXQUjFJ4y(), (global::System.Collections.Generic.IEnumerable<string>)val4.Keys);
						goto end_IL_000c;
					case 5:
						if (val8.Count >= 10000)
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num3 = 6;
							}
							break;
						}
						goto case 1;
					case 4:
						try
						{
							while (true)
							{
								IL_09b2:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
									{
										num4 = 12;
									}
									goto IL_095d;
								}
								goto IL_099f;
								IL_0959:
								num4 = num5;
								goto IL_095d;
								IL_095d:
								while (true)
								{
									string text;
									switch (num4)
									{
									case 3:
										goto end_IL_095d;
									case 2:
										goto IL_09b2;
									case 1:
										try
										{
											ObJPw4XJwIUTBNwBbypr.R0RXJPUeAyp(current);
											int num6 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
											{
												num6 = 0;
											}
											while (true)
											{
												switch (num6)
												{
												default:
													if (num7 == 990)
													{
														num6 = num7;
														continue;
													}
													goto case 0;
												case 0:
													aLrkVcXQDsZJ0xckHeBI = ObJPw4XJwIUTBNwBbypr.T8CXJsYArSI(current);
													num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
													{
														num6 = 2;
													}
													continue;
												case 2:
													val2.Add((c2coImXJvwEghB4hbjMJ)new c2coImXJvwEghB4hbjMJ(current, executable, aLrkVcXQDsZJ0xckHeBI.Status, processSummary, aLrkVcXQDsZJ0xckHeBI.CanInstall && val5 == null, aLrkVcXQDsZJ0xckHeBI.CanRestore && val5 == null));
													num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
													{
														num6 = 1;
													}
													continue;
												case 1:
													break;
												}
												break;
											}
										}
										catch (global::System.Exception obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num8 = 7;
											}
											else
											{
												ex = obj2;
												num8 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
												{
													num8 = 1;
												}
											}
											while (true)
											{
												switch (num8)
												{
												default:
													if (num9 != 19 && num9 == 999)
													{
														goto IL_0b0d;
													}
													goto case 0;
												case 4:
													if (ex is ArgumentException)
													{
														num8 = 3;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
														{
															num8 = 13;
														}
														continue;
													}
													goto case 9;
												case 3:
												case 6:
												case 8:
												case 11:
													flag = true;
													num9 = 19;
													goto IL_0b0d;
												case 2:
													if (ex is BadImageFormatException)
													{
														num8 = 11;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
														{
															num8 = 13;
														}
														continue;
													}
													goto case 10;
												case 10:
													flag = false;
													num8 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
													{
														num8 = 8;
													}
													continue;
												case 9:
													if (ex is JsonException)
													{
														num8 = 6;
														continue;
													}
													goto case 2;
												case 1:
													if (!(ex is IOException))
													{
														num8 = 5;
														continue;
													}
													goto case 3;
												case 5:
													if (ex is UnauthorizedAccessException)
													{
														num8 = 8;
														continue;
													}
													goto case 4;
												case 7:
													result = 0;
													break;
												case 0:
													{
														result = (flag ? 1 : 0);
														break;
													}
													IL_0b0d:
													num8 = num9;
													continue;
												}
												break;
											}
											return (byte)result != 0;
										}).Invoke())
										{
											int num10 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
											{
												num10 = 7;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 990)
													{
														num10 = num11;
														continue;
													}
													break;
												case 1:
													cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "Scan", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Java\\RuntimeProfile\\JavaRuntimeProfileScanner.cs", 67);
													num10 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
													{
														num10 = 2;
													}
													continue;
												case 2:
													val2.Add((c2coImXJvwEghB4hbjMJ)new c2coImXJvwEghB4hbjMJ(current, executable, string.Concat("不可操作：", (ex).Message), processSummary, CanInstall: false, CanRestore: false));
													num10 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
													{
														num10 = 0;
													}
													continue;
												case 0:
													break;
												}
												break;
											}
										}
										goto IL_09b2;
									case 5:
										if (!val4.TryGetValue(current, out val5))
										{
											num4 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
											{
												num4 = 9;
											}
											continue;
										}
										text = string.Concat("运行中，PID ", string.Join<int>(", ", (global::System.Collections.Generic.IEnumerable<int>)val5));
										goto IL_0e91;
									case 4:
										text = "未发现运行进程";
										goto IL_0e91;
									case 0:
										goto IL_0eb2;
									case 6:
										goto end_IL_09b2;
										IL_0e91:
										processSummary = text;
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
										{
											num4 = 5;
										}
										continue;
									}
									if (num5 != 14)
									{
										if (num5 == 994)
										{
											goto IL_0959;
										}
										goto IL_0eb2;
									}
									(token).ThrowIfCancellationRequested();
									num4 = 5;
									continue;
									IL_0eb2:
									executable = System.IO.Path.Combine(current, System.IO.File.Exists(System.IO.Path.Combine(current, "javaw.exe")) ? "javaw.exe" : "java.exe");
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
									{
										num4 = 11;
									}
									continue;
									end_IL_095d:
									break;
								}
								goto IL_099f;
								IL_099f:
								current = enumerator.Current;
								num5 = 14;
								goto IL_0959;
								continue;
								end_IL_09b2:
								break;
							}
						}
						finally
						{
							int num12;
							if (enumerator == null)
							{
								num12 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
								{
									num12 = 5;
								}
								goto IL_0f9e;
							}
							goto IL_0fd1;
							IL_0f9e:
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 990)
									{
										goto IL_0f9a;
									}
									goto end_IL_0f9e;
								case 1:
									goto end_IL_0f9e;
								case 2:
									break;
								case 0:
									goto end_IL_0f9e;
								}
								goto IL_0fd1;
								IL_0f9a:
								num12 = num13;
								continue;
								end_IL_0f9e:
								break;
							}
							goto end_IL_0f66;
							IL_0fd1:
							(enumerator).Dispose();
							num12 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num12 = 0;
							}
							goto IL_0f9e;
							end_IL_0f66:;
						}
						goto case 11;
					case 0:
					case 12:
						val2 = new List<c2coImXJvwEghB4hbjMJ>();
						num3 = 17;
						break;
					case 8:
					case 16:
						if (val7.Count <= 0)
						{
							num3 = 12;
							break;
						}
						goto case 3;
					case 6:
						val4 = VdoXQowjaSe(val3, failOnUnreadable: false);
						num3 = 17;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 9;
						}
						break;
					case 3:
						val3.Add("扫描已达到目录数量上限，可手动选择 Java bin 目录。");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 6;
						}
						break;
					case 11:
						return (lfXX0hXJiENbR2koEBGi)new lfXX0hXJiENbR2koEBGi((global::System.Collections.Generic.IReadOnlyList<c2coImXJvwEghB4hbjMJ>)val2, (global::System.Collections.Generic.IReadOnlyList<string>)val3);
					case 10:
						enumerable2 = new string[1] { selectedDirectory };
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
						{
							num3 = 9;
						}
						break;
					case 14:
						enumerable = enumerable2;
						goto end_IL_000c;
					case 13:
					{
						ValueTuple<string, int> val6 = val7.Dequeue();
						item = val6.Item1;
						item2 = val6.Item2;
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
						{
							num3 = 15;
						}
						break;
					}
					case 7:
						val3 = new List<string>();
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 19;
						}
						break;
					case 1:
						(token).ThrowIfCancellationRequested();
						num3 = 13;
						break;
					case 17:
						enumerator = ((global::System.Collections.Generic.IEnumerable<string>)Enumerable.OrderBy<string, string>((global::System.Collections.Generic.IEnumerable<string>)val, (Func<string, string>)([MethodImpl((MethodImplOptions)8)] (string path) => path), (IComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase)).GetEnumerator();
						num3 = 4;
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			val = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
			val8 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
			val7 = new Queue<ValueTuple<string, int>>();
			enumerator = Enumerable.Distinct<string>(enumerable, (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase).GetEnumerator();
			num = 24;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<string> yGuXQUjFJ4y()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return (global::System.Collections.Generic.IEnumerable<string>)new _DiscoverRoots_d__2(-2);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void MPgXQrYhnmt(object directory)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static Dictionary<string, List<int>> VdoXQowjaSe(List<string> diagnostics, bool failOnUnreadable)
	{
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int num21 = default(int);
		string[] array3 = default(string[]);
		Process[] array2 = default(Process[]);
		Dictionary<string, List<int>> val = default(Dictionary<string, List<int>>);
		int num15 = default(int);
		Process val2 = default(Process);
		string text = default(string);
		int num6 = default(int);
		List<int> val3 = default(List<int>);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Exception ex2 = default(global::System.Exception);
		int num11 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num13 = default(int);
		int num17 = default(int);
		int num20 = default(int);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						goto case 2;
					case 3:
						num21++;
						num3 = 2;
						continue;
					case 2:
						if (num21 >= array3.Length)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 6;
					case 6:
						array2 = System.Diagnostics.Process.GetProcessesByName(array3[num21]);
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c != 0)
						{
							num3 = 0;
						}
						continue;
					case 7:
						break;
					case 1:
						return val;
					case 4:
						array3 = new string[2]
						{
							"java",
							"javaw"
						};
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						try
						{
							Process[] array = array2;
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
							{
								num4 = 5;
							}
							while (true)
							{
								int num16;
								switch (num4)
								{
								default:
									if (num15 != 13)
									{
										if (num15 == 993)
										{
											goto IL_0180;
										}
										goto case 5;
									}
									goto case 3;
								case 1:
									try
									{
										int num5;
										if ((val2).HasExited)
										{
											num5 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
											{
												num5 = 8;
											}
											goto IL_0205;
										}
										goto IL_0273;
										IL_033a:
										object obj;
										if (string.IsNullOrWhiteSpace((string)obj))
										{
											throw new IOException("无法读取 Java 可执行文件路径。");
										}
										text = System.IO.Path.TrimEndingDirectorySeparator(System.IO.Path.GetDirectoryName(System.IO.Path.GetFullPath((string)obj)));
										num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
										{
											num5 = 2;
										}
										goto IL_0205;
										IL_0273:
										ProcessModule obj2 = (val2).MainModule;
										if (obj2 == null)
										{
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
											{
												num5 = 3;
											}
											goto IL_0205;
										}
										obj = (obj2).FileName;
										goto IL_033a;
										IL_0205:
										while (true)
										{
											switch (num5)
											{
											default:
												if (num6 != 13 && num6 == 993)
												{
													goto IL_0201;
												}
												goto end_IL_01c3;
											case 5:
												val3 = (val[text] = new List<int>());
												num5 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
												{
													num5 = 4;
												}
												continue;
											case 4:
												break;
											case 1:
											{
												val3.Add((val2).Id);
												int num7 = 10;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
												{
													num7 = 13;
												}
												num6 = num7;
												goto IL_0201;
											}
											case 2:
												if (!val.TryGetValue(text, out val3))
												{
													num5 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
													{
														num5 = 5;
													}
													continue;
												}
												goto case 1;
											case 3:
												goto end_IL_01c3;
											case 0:
												goto IL_032a;
												IL_0201:
												num5 = num6;
												continue;
											}
											break;
										}
										goto IL_0273;
										IL_032a:
										obj = null;
										goto IL_033a;
										end_IL_01c3:;
									}
									catch (InvalidOperationException)
									{
										int num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
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
									catch (global::System.Exception obj3) when (((Func<bool>)delegate
									{
										// Could not convert BlockContainer to single expression
										obj4 = obj3 as global::System.Exception;
										if (obj4 == null)
										{
											num10 = 5;
											goto IL_0430;
										}
										ex2 = obj4;
										num11 = 14;
										goto IL_042c;
										IL_042c:
										num10 = num11;
										goto IL_0430;
										IL_0430:
										while (true)
										{
											switch (num10)
											{
											default:
												if (num11 != 14)
												{
													if (num11 == 994)
													{
														break;
													}
													goto case 0;
												}
												if (!(ex2 is Win32Exception))
												{
													num10 = 2;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
													{
														num10 = 14;
													}
													continue;
												}
												goto case 3;
											case 3:
												flag = true;
												num10 = 6;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
												{
													num10 = 1;
												}
												continue;
											case 2:
												if (!(ex2 is IOException))
												{
													num10 = 4;
													continue;
												}
												goto case 3;
											case 4:
												if (ex2 is UnauthorizedAccessException)
												{
													num10 = 3;
													continue;
												}
												goto case 1;
											case 1:
												flag = false;
												num10 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
												{
													num10 = 12;
												}
												continue;
											case 5:
												result = 0;
												goto IL_0548;
											case 0:
											case 6:
												{
													result = (flag ? 1 : 0);
													goto IL_0548;
												}
												IL_0548:
												return (byte)result != 0;
											}
											break;
										}
										goto IL_042c;
									}).Invoke())
									{
										int num12 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
										{
											num12 = 8;
										}
										while (true)
										{
											switch (num12)
											{
											default:
												if (num13 == 11 || num13 != 991)
												{
													break;
												}
												goto IL_0578;
											case 0:
												if (failOnUnreadable)
												{
													num12 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
													{
														num12 = 11;
													}
													continue;
												}
												if (diagnostics.Count >= 20)
												{
													num12 = 5;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
													{
														num12 = 3;
													}
													continue;
												}
												goto case 2;
											case 3:
												break;
											case 2:
											{
												diagnostics.Add(string.Concat("部分 Java 进程不可读取：", (ex2).Message));
												int num14 = 11;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
												{
													num14 = 2;
												}
												num13 = num14;
												goto IL_0578;
											}
											case 1:
												{
													throw new IOException("无法核对某个 Java 进程的运行路径，未执行文件替换。请检查进程访问权限。", ex2);
												}
												IL_0578:
												num12 = num13;
												continue;
											}
											break;
										}
									}
									break;
								case 5:
									num17 = 0;
									num16 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
									{
										num16 = 9;
									}
									goto IL_017c;
								case 4:
									val2 = array[num17];
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
									{
										num4 = 0;
									}
									continue;
								case 3:
									if (num17 >= array.Length)
									{
										num16 = 2;
										goto IL_017c;
									}
									goto case 4;
								case 0:
									break;
								case 2:
									goto end_IL_0184;
									IL_017c:
									num15 = num16;
									goto IL_0180;
									IL_0180:
									num4 = num15;
									continue;
								}
								num17++;
								num4 = 3;
								continue;
								end_IL_0184:
								break;
							}
						}
						finally
						{
							Process[] array = array2;
							int num18 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
							{
								num18 = 3;
							}
							while (true)
							{
								switch (num18)
								{
								default:
									if (num20 != 12)
									{
										if (num20 == 992)
										{
											goto IL_076d;
										}
										goto case 1;
									}
									goto end_IL_0771;
								case 3:
									(array[num17]).Dispose();
									num18 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
									{
										num18 = 4;
									}
									break;
								case 1:
								case 2:
									if (num17 >= array.Length)
									{
										int num19 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
										{
											num19 = 12;
										}
										num20 = num19;
										goto IL_076d;
									}
									goto case 3;
								case 4:
									num17++;
									num18 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
									{
										num18 = 10;
									}
									break;
								case 0:
									{
										num17 = 0;
										num18 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
										{
											num18 = 7;
										}
										break;
									}
									IL_076d:
									num18 = num20;
									break;
								}
								continue;
								end_IL_0771:
								break;
							}
						}
						goto case 3;
					case 5:
						val = new Dictionary<string, List<int>>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
						num3 = 4;
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
			num21 = 0;
			num = 14;
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
	internal static bool mQ2AyKZdwAMmGAHhsvAh()
	{
		return gCsaaJZdRM0cdJ2xASmq == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static T2KuYHXQ4bOpV9N7eIkd RxcRiIZdewe5OG21UoCG()
	{
		return (T2KuYHXQ4bOpV9N7eIkd)gCsaaJZdRM0cdJ2xASmq;
	}
}

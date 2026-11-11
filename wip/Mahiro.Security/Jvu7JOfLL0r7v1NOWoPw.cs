using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using HN5yyEfpz8TLMVS2CfPf;
using fDAldojjppXrctUVYOJn;

namespace PmD8yTfLjwM0m5QodEpn;

internal class Jvu7JOfLL0r7v1NOWoPw
{
	[CompilerGenerated]
	sealed class _EnumerateSearchDirectories_d__8 : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private string __2__current;

		private int __l__initialThreadId;

		private string executableDirectory;

		public string __3__executableDirectory;

		private string _windowsDirectory_5__2;

		private string[] __7__wrap2;

		private int __7__wrap3;

		private static _EnumerateSearchDirectories_d__8 pYTbJxD0Oe5QJU59otRG;

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
		public _EnumerateSearchDirectories_d__8(int __1__state)
		{
			__l__initialThreadId = System.Environment.CurrentManagedThreadId;
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
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
						case 2:
							_windowsDirectory_5__2 = null;
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							goto end_IL_000c;
						case 0:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							__1__state = -2;
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				__7__wrap2 = null;
				num = 9;
			}
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
{
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
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
			// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
			throw new global::System.NotSupportedException();
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
			int num = 2;
			_EnumerateSearchDirectories_d__8 enumerateSearchDirectories_d__ = default(_EnumerateSearchDirectories_d__8);
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
							if (num2 != 13)
							{
								if (num2 == 994)
								{
									goto end_IL_0010;
								}
								goto case 2;
							}
							if (__l__initialThreadId == System.Environment.CurrentManagedThreadId)
							{
								num3 = 5;
								continue;
							}
							goto case 1;
						case 5:
							__1__state = 0;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 12;
							}
							continue;
						case 3:
						case 6:
							enumerateSearchDirectories_d__.executableDirectory = __3__executableDirectory;
							num3 = 4;
							continue;
						case 4:
							return enumerateSearchDirectories_d__;
						case 2:
							if (__1__state == -2)
							{
								num = 13;
								break;
							}
							goto case 1;
						case 0:
							enumerateSearchDirectories_d__ = this;
							num3 = 6;
							continue;
						case 1:
							enumerateSearchDirectories_d__ = (_EnumerateSearchDirectories_d__8)new _EnumerateSearchDirectories_d__8(0);
							num = 3;
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
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num3 = 0;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num3 = 3;
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
		internal static bool w3grS6D05U5qFDiwup51()
		{
			return pYTbJxD0Oe5QJU59otRG == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _EnumerateSearchDirectories_d__8 UKqM5pD06sbySDLDaD2A()
		{
			return pYTbJxD0Oe5QJU59otRG;
		}
	}

	internal static object guw11aZTS5gdAKo7e9AW;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dnQfLZs7QsK(object installation, out string missingModule)
	{
		int num = 3;
		int num4 = default(int);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		string text2 = default(string);
		int num7 = default(int);
		bool result = default(bool);
		int num9 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num12);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num14 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 3:
					System.ArgumentNullException.ThrowIfNull(installation, "installation");
					num2 = 2;
					continue;
				case 1:
					missingModule = default;
					return false;
				case 2:
					break;
				case 0:
					try
					{
						string text = System.IO.Path.GetDirectoryName(((xssD3cfpnxdefR05FuDD)installation).ExecutablePath);
						int num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							switch (num3)
							{
							case 5:
								goto end_IL_00d7;
							default:
								if (num4 == 13)
								{
									goto case 4;
								}
								if (num4 == 993)
								{
									goto IL_00d3;
								}
								goto end_IL_0094;
							case 1:
								try
								{
									while (true)
									{
										IL_01f6:
										int num5;
										if (!(enumerator).MoveNext())
										{
											num5 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
											{
												num5 = 2;
											}
											goto IL_014c;
										}
										goto IL_0226;
										IL_0226:
										text2 = (string)enumerator;
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
										{
											num5 = 0;
										}
										goto IL_014c;
										IL_014c:
										while (true)
										{
											switch (num5)
											{
											case 2:
												break;
											default:
												switch (num7)
												{
												case 993:
													break;
												case 13:
													goto IL_018a;
												default:
													goto IL_01f6;
												}
												goto IL_0148;
											case 1:
											{
												if (QrQfLVnCJ6N(text, text2))
												{
													goto IL_01f6;
												}
												int num6 = 12;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
												{
													num6 = 13;
												}
												num7 = num6;
												goto IL_0148;
											}
											case 3:
												result = true;
												num5 = 4;
												continue;
											case 4:
												goto end_IL_0116;
											case 5:
												goto IL_01f6;
											case 0:
												goto IL_0226;
												IL_0148:
												num5 = num7;
												continue;
												IL_018a:
												missingModule = text2;
												num5 = 3;
												continue;
											}
											break;
										}
										break;
									}
									goto end_IL_00d7;
									end_IL_0116:;
								}
								finally
								{
									if (enumerator != null)
									{
										int num8 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
										{
											num8 = 0;
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
												goto end_IL_0287;
											}
											(enumerator).Dispose();
											num8 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
											{
												num8 = 1;
											}
											continue;
											end_IL_0287:
											break;
										}
									}
								}
								goto end_IL_0094;
							case 2:
								if (string.IsNullOrWhiteSpace(text))
								{
									break;
								}
								num4 = 13;
								goto IL_00d3;
							case 4:
								enumerator = (global::System.Collections.Generic.IEnumerator<string>)KCcfL9keAav(((xssD3cfpnxdefR05FuDD)installation).ExecutablePath);
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
								break;
							case 3:
								goto end_IL_0094;
								IL_00d3:
								num3 = num4;
								continue;
							}
							result = false;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num3 = 3;
							}
							continue;
							end_IL_00d7:
							break;
						}
						goto case 1;
						end_IL_0094:;
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num10 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
							{
								num10 = 17;
							}
						}
						else
						{
							ex = obj2;
							num10 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num10 = 15;
							}
						}
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 != 17)
								{
									if (num11 == 997)
									{
										goto IL_03b8;
									}
									goto case 5;
								}
								goto case 6;
							case 3:
								if (!(ex is NotSupportedException))
								{
									num10 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
									{
										num10 = 1;
									}
									continue;
								}
								goto case 2;
							case 1:
							case 4:
								flag = false;
								num12 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
								{
									num12 = 17;
								}
								num11 = num12;
								goto IL_03b8;
							case 0:
								if (!(ex is ArgumentException))
								{
									num10 = 3;
									continue;
								}
								goto case 2;
							case 9:
								if (!(ex is IOException))
								{
									num10 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
									{
										num10 = 11;
									}
									continue;
								}
								goto case 2;
							case 8:
								if (!(ex is BadImageFormatException))
								{
									num10 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
									{
										num10 = 0;
									}
									continue;
								}
								goto case 2;
							case 7:
								if (!(ex is UnauthorizedAccessException))
								{
									num10 = 8;
									continue;
								}
								goto case 2;
							case 2:
								flag = true;
								num10 = 6;
								continue;
							case 5:
								result2 = 0;
								break;
							case 6:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_03b8:
								num10 = num11;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num13 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
						{
							num13 = 1;
						}
						while (true)
						{
							switch (num13)
							{
							case 0:
								break;
							default:
								if (num14 == 988)
								{
									num13 = num14;
									continue;
								}
								break;
							}
							break;
						}
						goto case 1;
					}
					return result;
				}
				goto IL_006d;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_006d;
				IL_006d:
				missingModule = string.Empty;
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
				{
					num2 = 8;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Collections.Generic.IReadOnlyList<string> KCcfL9keAav(object executablePath)
	{
		//IL_0688: Expected O, but got I4
		//IL_003e: Expected O, but got I4
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0341: Unknown result type (might be due to invalid IL or missing references)
		//IL_069c->IL0010: Incompatible stack heights: 4 vs 1
		//IL_06a7->IL0010: Incompatible stack heights: 4 vs 1
		//IL_0190->IL00cb: Incompatible stack heights: 4 vs 2
		//IL_052c->IL00cb: Incompatible stack heights: 1 vs 2
		//IL_0537->IL00cb: Incompatible stack heights: 1 vs 2
		int num = 2;
		global::System.Collections.Generic.IReadOnlyList<string> result = default(global::System.Collections.Generic.IReadOnlyList<string>);
		FileStream val = default(FileStream);
		int num3 = default(int);
		int num12 = default(int);
		uint num5 = default(uint);
		int num6 = default(int);
		long num10 = default(long);
		byte[] array = default(byte[]);
		PEHeader val4 = default(PEHeader);
		long num11 = default(long);
		List<string> val5 = default(List<string>);
		string text = default(string);
		uint num8 = default(uint);
		int num14 = default(int);
		int num16 = default(int);
		while (true)
		{
			while (true)
			{
				switch (num)
				{
				default:
					goto IL_0021;
				case 0:
					return result;
				case 1:
					try
					{
						FileStream obj = val;
						PEReader val2 = (PEReader)(object)1;
						int num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
						{
							num2 = 6;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								if (num3 == 988)
								{
									goto IL_006b;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_006b:
							num2 = num3;
						}
						try
						{
							PEHeaders val3 = (val2).PEHeaders;
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								int num9;
								switch (num4)
								{
								default:
									if (num12 != 39)
									{
										if (num12 == 1019)
										{
											goto IL_00c7;
										}
										goto case 2;
									}
									if (num5 == 0)
									{
										num4 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 9;
								case 16:
									num6++;
									num9 = 22;
									goto IL_00c3;
								case 11:
									_ = 16;
									continue;
								case 14:
									if (num10 >= 0)
									{
										num4 = 31;
										continue;
									}
									goto case 6;
								case 21:
									result = global::System.Array.Empty<string>();
									num4 = 5;
									continue;
								case 7:
									(val).ReadExactly((global::System.Span<byte>)array);
									num4 = 4;
									continue;
								case 8:
									if ((val4).ImportTableDirectory.Size < 20)
									{
										num4 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
										{
											num4 = 25;
										}
										continue;
									}
									goto case 29;
								case 29:
									num11 = dmefLkfWFle(val3, (val4).ImportTableDirectory.RelativeVirtualAddress, (val).Length);
									num9 = 24;
									goto IL_00c3;
								case 9:
									if (num5 != 0)
									{
										num4 = 27;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
										{
											num4 = 3;
										}
										continue;
									}
									goto case 16;
								case 2:
									if (val4 != null)
									{
										num4 = 30;
										continue;
									}
									goto case 25;
								case 6:
								case 20:
									result = (global::System.Collections.Generic.IReadOnlyList<string>)val5;
									num9 = 12;
									goto IL_00c3;
								case 5:
									goto end_IL_00cb;
								case 19:
									num6 = 0;
									num4 = 15;
									continue;
								case 1:
									val4 = (val3).PEHeader;
									num4 = 2;
									continue;
								case 17:
									text = h1ufLDp4ypY(val, val3, checked((int)num5));
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
									{
										num4 = 33;
									}
									continue;
								case 26:
									goto end_IL_00cb;
								case 23:
									num10 = num11 + num6 * 20;
									num9 = 14;
									goto IL_00c3;
								case 27:
									if (num8 != 0)
									{
										num9 = 9;
										goto IL_00c3;
									}
									goto case 6;
								case 13:
									(val).Position = num10;
									num9 = 7;
									goto IL_00c3;
								case 24:
									if (num11 < 0)
									{
										num4 = 21;
										continue;
									}
									break;
								case 30:
									if ((val4).ImportTableDirectory.RelativeVirtualAddress > 0)
									{
										num4 = 39;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
										{
											num4 = 8;
										}
										continue;
									}
									goto case 25;
								case 0:
									if (!string.IsNullOrWhiteSpace(text))
									{
										num4 = 30;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
										{
											num4 = 18;
										}
										continue;
									}
									goto case 16;
								case 15:
								case 22:
									if (num6 >= 512)
									{
										num4 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
										{
											num4 = 37;
										}
										continue;
									}
									goto case 23;
								case 18:
									if (!Enumerable.Contains<string>((global::System.Collections.Generic.IEnumerable<string>)val5, text, (IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase))
									{
										num4 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
										{
											num4 = 4;
										}
										continue;
									}
									goto case 16;
								case 31:
									if (num10 > (val).Length - array.Length)
									{
										num9 = 20;
										goto IL_00c3;
									}
									goto case 13;
								case 10:
									array = new byte[20];
									num4 = 19;
									continue;
								case 4:
								{
									uint num7 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array, 0, 4));
									num5 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array, 12, 4));
									num8 = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)MemoryExtensions.AsSpan<byte>(array, 16, 4));
									if (num7 == 0)
									{
										num9 = 39;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
										{
											num9 = 14;
										}
										goto IL_00c3;
									}
									goto case 9;
								}
								case 3:
									if (num5 <= 2147483647)
									{
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
										{
											num4 = 17;
										}
										continue;
									}
									goto case 16;
								case 25:
									result = global::System.Array.Empty<string>();
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
									{
										num4 = 26;
									}
									continue;
								case 28:
									break;
								case 12:
									goto end_IL_00cb;
									IL_00c3:
									num12 = num9;
									goto IL_00c7;
									IL_00c7:
									num4 = num12;
									continue;
								}
								val5 = (List<string>)(object)obj;
								_ = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
								{
									_ = 10;
								}
								continue;
								end_IL_00cb:
								break;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num13 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
								{
									num13 = 0;
								}
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 989)
										{
											num13 = num14;
											continue;
										}
										break;
									case 0:
										(val2).Dispose();
										num13 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
										{
											num13 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					}
					finally
					{
						if (val != null)
						{
							int num15 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
							{
								num15 = 1;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 == 989)
									{
										num15 = num16;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0616;
								}
								(val).Dispose();
								num15 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
								{
									num15 = 0;
								}
								continue;
								end_IL_0616:
								break;
							}
						}
					}
					goto case 0;
				case 2:
					break;
				}
				goto IL_0681;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_0681;
				IL_0681:
				_ = 3;
				_ = 1;
				val = (FileStream)(object)7;
				_ = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
				{
					_ = 3;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? h1ufLDp4ypY(object stream, object headers, int nameRva)
	{
		List<byte> val = default(List<byte>);
		string text = (System.Text.Encoding.ASCII).GetString((byte[])(object)val);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static long dmefLkfWFle(object headers, int relativeVirtualAddress, long fileLength)
	{
		SectionHeader val = default(SectionHeader);
		int num = System.Math.Max((val).VirtualSize, (val).SizeOfRawData);
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool QrQfLVnCJ6N(object executableDirectory, object moduleName)
	{
		int num = 1;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		string text = default(string);
		int num12 = default(int);
		bool result = default(bool);
		int num6 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		int num9 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num11 = default(int);
		int num14 = default(int);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						enumerator = (global::System.Collections.Generic.IEnumerator<string>)OugfLYosN6k(executableDirectory);
						num3 = 3;
						continue;
					case 1:
						if (!(moduleName).StartsWith("api-ms-win-", (StringComparison)5))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 2;
					case 0:
						if (!(moduleName).StartsWith("ext-ms-", (StringComparison)5))
						{
							break;
						}
						goto case 2;
					case 4:
						return false;
					case 2:
						return true;
					case 3:
						try
						{
							while (true)
							{
								IL_047a:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
									{
										num4 = 0;
									}
									goto IL_0131;
								}
								goto IL_046b;
								IL_046b:
								text = (string)enumerator;
								num4 = 3;
								goto IL_0131;
								IL_0131:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num12 == 991)
										{
											num4 = num12;
											continue;
										}
										goto end_IL_047a;
									case 3:
										try
										{
											int num5;
											if (string.IsNullOrWhiteSpace(text))
											{
												num5 = 9;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
												{
													num5 = 2;
												}
												goto IL_019c;
											}
											goto IL_01fb;
											IL_019c:
											while (true)
											{
												switch (num5)
												{
												case 1:
													return result;
												default:
													if (num6 == 992)
													{
														num5 = num6;
														continue;
													}
													goto end_IL_019c;
												case 2:
													goto end_IL_019c;
												case 3:
													break;
												case 4:
													result = true;
													num5 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
													{
														num5 = 4;
													}
													continue;
												case 0:
													goto end_IL_019c;
												}
												goto IL_01fb;
												continue;
												end_IL_019c:
												break;
											}
											goto end_IL_015a;
											IL_01fb:
											if (System.IO.File.Exists(System.IO.Path.Combine(text, (string)moduleName)))
											{
												num5 = 4;
												goto IL_019c;
											}
											end_IL_015a:;
										}
										catch (object obj) when (((Func<bool>)delegate
										{
											// Could not convert BlockContainer to single expression
											obj2 = obj as global::System.Exception;
											if (obj2 == null)
											{
												num7 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
												{
													num7 = 5;
												}
												goto IL_028a;
											}
											ex = obj2;
											num8 = 6;
											goto IL_0282;
											IL_0286:
											num7 = num9;
											goto IL_028a;
											IL_028a:
											while (true)
											{
												switch (num7)
												{
												default:
													if (num9 != 17)
													{
														if (num9 == 997)
														{
															goto IL_0286;
														}
														goto case 2;
													}
													goto case 0;
												case 3:
												case 8:
													flag = true;
													num7 = 6;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
													{
														num7 = 0;
													}
													continue;
												case 4:
													if (!(ex is UnauthorizedAccessException))
													{
														num7 = 7;
														continue;
													}
													goto case 3;
												case 7:
													if (ex is ArgumentException)
													{
														num7 = 17;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
														{
															num7 = 3;
														}
														continue;
													}
													goto case 2;
												case 6:
													if (!(ex is IOException))
													{
														num7 = 16;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
														{
															num7 = 4;
														}
														continue;
													}
													goto case 3;
												case 1:
												case 9:
													break;
												case 2:
													if (!(ex is NotSupportedException))
													{
														num7 = 9;
														continue;
													}
													goto case 3;
												case 5:
													result2 = 0;
													goto IL_03f7;
												case 0:
													{
														result2 = (flag ? 1 : 0);
														goto IL_03f7;
													}
													IL_03f7:
													return (byte)result2 != 0;
												}
												break;
											}
											flag = false;
											num8 = 17;
											goto IL_0282;
											IL_0282:
											num9 = num8;
											goto IL_0286;
										}).Invoke())
										{
											int num10 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
											{
												num10 = 6;
											}
											while (true)
											{
												switch (num10)
												{
												default:
													if (num11 == 988)
													{
														num10 = num11;
														continue;
													}
													break;
												case 0:
													break;
												}
												break;
											}
										}
										goto IL_047a;
									case 2:
										break;
									case 1:
										goto IL_047a;
									case 0:
										goto end_IL_047a;
									}
									break;
								}
								goto IL_046b;
								continue;
								end_IL_047a:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num13 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
								{
									num13 = 2;
								}
								while (true)
								{
									switch (num13)
									{
									default:
										if (num14 == 989)
										{
											num13 = num14;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_04e7;
									}
									(enumerator).Dispose();
									num13 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
									{
										num13 = 7;
									}
									continue;
									end_IL_04e7:
									break;
								}
							}
						}
						goto case 4;
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
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<string> OugfLYosN6k(object executableDirectory)
	{
		//yield-return decompiler failed: Could not find stateField
		return (global::System.Collections.Generic.IEnumerable<string>)new _EnumerateSearchDirectories_d__8(-2)
		{
			__3__executableDirectory = (string)executableDirectory
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
						{
							num3 = 1;
						}
						continue;
					case 0:
						return;
					case 2:
						break;
					case 1:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 0;
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
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool plMYotZTcrrShkxq1PYZ()
	{
		return guw11aZTS5gdAKo7e9AW == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Jvu7JOfLL0r7v1NOWoPw IosT9MZT0LI1oC8YFHf5()
	{
		return (Jvu7JOfLL0r7v1NOWoPw)guw11aZTS5gdAKo7e9AW;
	}
}

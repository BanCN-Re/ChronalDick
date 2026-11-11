using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using CZUx5njfSrbl1tnMcUCO;
using JvgQTDcbARdEdTAk7GE;
using KLBJVorbMw4cmIeBpTN;
using PJFIn6fwNw3W82OxkWAg;
using fDAldojjppXrctUVYOJn;

namespace sR58PmrZ71miANppOIt;

internal class CsEGHKrjZSJihT9dx5Z
{
	[CompilerGenerated]
	sealed class _Split_d__3 : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private string __2__current;

		private int __l__initialThreadId;

		private string content;

		public string __3__content;

		private int _offset_5__2;

		private int _length_5__3;

		private static _Split_d__3 aXgR1Y9CDxfkQV0qpK7O;

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
		public _Split_d__3(int __1__state)
		{
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					__1__state = -2;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
					{
						num2 = 1;
					}
				}
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
			int num = 9;
			int num4 = default(int);
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
							if (num2 != 20)
							{
								if (num2 == 1001)
								{
									goto end_IL_0010;
								}
								goto case 3;
							}
							goto case 13;
						case 2:
							return true;
						case 5:
							return false;
						case 11:
							if (num4 == 1)
							{
								__1__state = -1;
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
								{
									num3 = 0;
								}
							}
							else
							{
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
								{
									num3 = 11;
								}
							}
							break;
						case 8:
							if (num4 == 0)
							{
								num3 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
								{
									num3 = 12;
								}
								break;
							}
							goto case 11;
						case 9:
							num4 = __1__state;
							num3 = 8;
							break;
						case 4:
							__2__current = (content).Substring(_offset_5__2, _length_5__3);
							num3 = 7;
							break;
						case 1:
							_offset_5__2 = 0;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
							{
								num3 = 12;
							}
							break;
						case 6:
							return false;
						case 12:
							__1__state = -1;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
							{
								num3 = 13;
							}
							break;
						case 7:
							__1__state = 1;
							num3 = 2;
							break;
						case 13:
							_length_5__3 = GH3rkOt2lZ(content, _offset_5__2);
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
							{
								num3 = 4;
							}
							break;
						case 3:
						case 10:
							if (_offset_5__2 < (content).Length)
							{
								goto end_IL_000c;
							}
							goto case 5;
						case 0:
							_offset_5__2 += _length_5__3;
							num3 = 10;
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
				num = 20;
			}
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
			int num = 4;
			_Split_d__3 split_d__ = default(_Split_d__3);
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
								goto case 4;
							}
							return split_d__;
						case 0:
							split_d__ = this;
							num3 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
							{
								num3 = 6;
							}
							continue;
						case 3:
							if (__l__initialThreadId == System.Environment.CurrentManagedThreadId)
							{
								num3 = 2;
								continue;
							}
							goto case 1;
						case 1:
							split_d__ = (_Split_d__3)new _Split_d__3(0);
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num3 = 5;
							}
							continue;
						case 4:
							if (__1__state == -2)
							{
								num = 3;
								break;
							}
							goto case 1;
						case 2:
							__1__state = 0;
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								num3 = 13;
							}
							continue;
						case 5:
						case 6:
							split_d__.content = __3__content;
							num = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num = 13;
							}
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
			int num = 1;
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
							goto end_IL_000e;
						case 1:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 1;
							}
							continue;
						case 2:
							return;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 2;
							continue;
						}
						break;
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
				{
					num = 9;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool mZVQFQ9Ck0nIwvbpwWk2()
		{
			return aXgR1Y9CDxfkQV0qpK7O == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _Split_d__3 p4A5fx9CVS3Ee9dTIVsZ()
		{
			return aXgR1Y9CDxfkQV0qpK7O;
		}
	}

	private static object ym1NmXZ0dCcQtk6WRvZM;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Collections.Generic.IReadOnlyList<i5oxMaUz1pbK1JqKPEr> yxtr95UIr9(object sourceKey, object content)
	{
		//IL_000c: Expected I4, but got O
		//IL_0028: Expected I4, but got O
		//IL_0028: Expected I4, but got O
		object contentHash = default(object);
		object obj = default(object);
		object obj2 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		new i5oxMaUz1pbK1JqKPEr(zVIrV6FxBe(sourceKey, contentHash, (int)obj), (int)obj2, (string)obj3, aUDrYhDiXR(System.MemoryExtensions.AsSpan((string)obj3)), (int)obj4);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<string> AxYrDiOWPZ(object content)
	{
		//yield-return decompiler failed: Could not find stateField
		return (global::System.Collections.Generic.IEnumerable<string>)new _Split_d__3(-2)
		{
			__3__content = (string)content
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int GH3rkOt2lZ(object content, int offset)
	{
		//IL_000c: Expected O, but got I4
		//IL_0055: Expected I4, but got O
		//IL_01fe: Expected O, but got I4
		//IL_018c: Expected O, but got I4
		//IL_019d: Expected O, but got I4
		//IL_017b: Expected I4, but got O
		//IL_0118: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected I4, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012c: Expected O, but got Unknown
		//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Invalid comparison between Unknown and I4
		//IL_0220: Expected I4, but got O
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected I4, but got Unknown
		//IL_0208->IL0010: Incompatible stack types: I4 vs O
		//IL_01b1->IL0010: Incompatible stack types: I4 vs O
		//IL_0262->IL0010: Incompatible stack types: I4 vs O
		//IL_0126->IL0010: Incompatible stack types: I4 vs O
		//IL_0136->IL0010: Incompatible stack types: I4 vs O
		//IL_0150->IL0010: Incompatible stack types: I4 vs O
		//IL_01bc->IL0010: Incompatible stack types: I4 vs O
		//IL_026d->IL0010: Incompatible stack types: I4 vs O
		//IL_01f0->IL0010: Incompatible stack types: I4 vs O
		//IL_016e->IL0010: Incompatible stack types: I4 vs O
		//IL_00c0->IL0010: Incompatible stack types: I4 vs O
		//IL_023e->IL0010: Incompatible stack types: I4 vs O
		//IL_015b->IL0010: Incompatible stack types: I4 vs O
		//IL_0105->IL0010: Incompatible stack types: I4 vs O
		//IL_01fb->IL0010: Incompatible stack types: I4 vs O
		//IL_0110->IL0010: Incompatible stack types: I4 vs O
		int num = 1;
		object obj6 = default(object);
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 22 && (nint)obj == 1003)
						{
							goto end_IL_0010;
						}
						goto case 9;
					case 6:
						break;
					case 12:
						if (offset + obj6 < (content).Length)
						{
							obj2 = 8;
							continue;
						}
						goto case 3;
					case 15:
						if (char.IsLowSurrogate((content).Chars))
						{
							obj2 = 14;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								obj2 = 11;
							}
							continue;
						}
						goto case 3;
					case 4:
					case 5:
						obj3 = obj4 + (obj5 - obj4) / 2;
						obj2 = 13;
						continue;
					case 7:
					case 11:
						obj5 = obj3 - 1;
						obj2 = 10;
						continue;
					case 14:
						obj6--;
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							obj2 = 13;
						}
						continue;
					case 9:
					case 10:
						if (obj4 <= obj5)
						{
							obj2 = 5;
							continue;
						}
						goto case 12;
					case 3:
						return System.Math.Max(1, (int)obj6);
					case 1:
					{
						int num2 = (content).Length - offset;
						obj4 = 1;
						obj5 = System.Math.Min(num2, 524288);
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							obj2 = 22;
						}
						continue;
					}
					case 8:
						if (char.IsHighSurrogate((content).Chars))
						{
							obj2 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								obj2 = 16;
							}
							continue;
						}
						goto case 3;
					case 0:
						obj6 = 1;
						obj2 = 9;
						continue;
					case 13:
						if ((System.Text.Encoding.UTF8).GetByteCount(System.MemoryExtensions.AsSpan((string)content, offset, (int)obj3)) > 524288)
						{
							obj2 = 7;
							continue;
						}
						goto case 2;
					case 2:
						obj6 = obj3;
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
						{
							obj2 = 21;
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
			obj4 = obj3 + 1;
			num = 22;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string zVIrV6FxBe(object sourceKey, object contentHash, int batchIndex)
	{
		//IL_008b: Expected O, but got I4
		//IL_008b: Expected O, but got I4
		//IL_008b: Expected O, but got Ref
		System.Text.Encoding.UTF8;
		object obj = default(object);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendFormatted((string)sourceKey);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("\n");
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendFormatted((string)contentHash);
		(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).AppendLiteral("\n");
		object obj2 = System.Security.Cryptography.SHA256.HashData((((v5OiSQSzC8GipXkQ3VG)(&obj)).wDn87ymIHB<S9HINnfwTP9GO76XPCkJ>((string)2, (object)3, (byte)(&obj) != 0, (CancellationToken)batchIndex)).GetBytes((*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj)).ToStringAndClear()));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string aUDrYhDiXR(global::System.ReadOnlySpan<char> content)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							return;
						}
						goto end_IL_0012;
					case 1:
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
						break;
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
			while ((nint)obj == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool cQY51aZ0KTSYjs64SBen()
	{
		return ym1NmXZ0dCcQtk6WRvZM == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static CsEGHKrjZSJihT9dx5Z UEPiIdZ0HPHmDPbX3hrs()
	{
		return (CsEGHKrjZSJihT9dx5Z)ym1NmXZ0dCcQtk6WRvZM;
	}
}

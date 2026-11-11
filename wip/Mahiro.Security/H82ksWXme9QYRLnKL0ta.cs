using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using o73NvMXmgl20vqmpuIQ5;
using sHWGLlXmdnY7VPxUGRTP;

namespace GCGrK8XmPXq7DxBecCsU;

internal class H82ksWXme9QYRLnKL0ta
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_29
	{
		public static __c_29 __9;

		public static Func<Q6QWnhXmB8feJrqhLhUB, DateTimeOffset?> __9__6_0;

		public static Func<string, FileInfo> __9__7_0;

		public static Func<FileInfo, bool> __9__7_1;

		public static Func<FileInfo, global::System.DateTime> __9__7_2;

		public static Func<FileInfo, string> __9__7_3;

		public static Func<XElement, bool> __9__9_0;

		public static Func<XElement, bool> __9__9_1;

		public static Func<XElement, bool> __9__9_2;

		public static Func<XAttribute, bool> __9__9_3;

		public static Func<XElement, bool> __9__9_4;

		public static Func<XElement, bool> __9__9_5;

		public static Func<XElement, bool> __9__9_6;

		public static Func<XElement, bool> __9__9_7;

		public static Func<XAttribute, bool> __9__9_8;

		public static Func<XElement, bool> __9__9_9;

		public static Func<XAttribute, bool> __9__9_10;

		private static __c_29 vwOjVX9pE6MG1xrEtFDK;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			int num = 3;
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
									goto end_IL_0012;
								}
								goto case 3;
							}
							return;
						case 2:
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 6;
							}
							continue;
						case 1:
							break;
						case 4:
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num3 = 0;
							}
							continue;
						case 3:
							num3 = 2;
							continue;
						case 0:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 4;
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
				__9 = (__c_29)new __c_29();
				num = 8;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_29()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DateTimeOffset? UZkLXgT5VtY(Q6QWnhXmB8feJrqhLhUB item)
		{
			return item.CreatedAtUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal FileInfo EAtLXlpa33q(string path)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return default(FileInfo);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool QQaLXdX88mK(FileInfo info)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			return ((info).LastWriteTimeUtc >= (System.DateTime.UtcNow - d4AXmv6RC83));
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.DateTime EO6LXKokJba(FileInfo info)
		{
			return (info).LastWriteTimeUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal string LiKLXHIk6ZB(FileInfo info)
		{
			return (info).FullName;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool XpHLXt6hxpf(XElement node)
		{
			return (((node).Name).LocalName == "Event");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool EJ3LXOMZXrr(XElement node)
		{
			return (((node).Name).LocalName == "System");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool S0VLX5XPpRB(XElement node)
		{
			return (((node).Name).LocalName == "Provider");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool L9VLX6qIlXx(XAttribute attribute)
		{
			return (((attribute).Name).LocalName == "Name");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool bAELXRPklip(XElement node)
		{
			return (((node).Name).LocalName == "EventID");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool ukTLXwff9Ms(XElement node)
		{
			return (((node).Name).LocalName == "Level");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool rIKLXeqgUi8(XElement node)
		{
			return (((node).Name).LocalName == "EventRecordID");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool yuCLXPB2guW(XElement node)
		{
			return (((node).Name).LocalName == "TimeCreated");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool wYkLXxSxMlC(XAttribute attribute)
		{
			return (((attribute).Name).LocalName == "SystemTime");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool cUVLXFFOWq5(XElement node)
		{
			return (((node).Name).LocalName == "Data");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool Wf5LXsAlW0e(XAttribute attribute)
		{
			return (((attribute).Name).LocalName == "Name");
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool fva8Li9p2bwOy0tIrymP()
		{
			return vwOjVX9pE6MG1xrEtFDK == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_29 BiD7ef9pqHpusfMKT6UK()
		{
			return vwOjVX9pE6MG1xrEtFDK;
		}
	}

	[CompilerGenerated]
	sealed class _GetWerRoots_d__11 : global::System.Collections.Generic.IEnumerable<string>, global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerator<string>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		private int __1__state;

		private string __2__current;

		private int __l__initialThreadId;

		private string _local_5__2;

		private string _common_5__3;

		internal static _GetWerRoots_d__11 L6n4kA9pGbSNfNWcDhXP;

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
		public _GetWerRoots_d__11(int __1__state)
		{
			__l__initialThreadId = System.Environment.CurrentManagedThreadId;
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
		{
			int num = 1;
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
								_common_5__3 = null;
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto end_IL_0010;
						case 0:
							__1__state = -2;
							num3 = 2;
							continue;
						case 1:
							break;
						case 2:
							return;
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
				while (num2 == 990);
				_local_5__2 = null;
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
				{
					num = 6;
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
			//IL_00a8: Expected O, but got I4
			//IL_00f5: Expected O, but got I4
			int num = 15;
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
							if (num2 != 27)
							{
								if (num2 == 1008)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							return true;
						case 0:
						case 19:
							return false;
						case 2:
							return true;
						case 4:
							_common_5__3 = (string)35;
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num3 = 1;
							}
							continue;
						case 14:
							switch (num4)
							{
							case 4:
								__1__state = -1;
								num3 = 19;
								break;
							default:
								num3 = 5;
								break;
							case 1:
								__1__state = -1;
								num3 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
								{
									num3 = 14;
								}
								break;
							case 3:
								__1__state = -1;
								num3 = 7;
								break;
							case 0:
								__1__state = -1;
								num3 = 13;
								break;
							case 2:
								__1__state = -1;
								num3 = 6;
								break;
							}
							continue;
						case 13:
							_local_5__2 = (string)28;
							num3 = 4;
							continue;
						case 3:
							__1__state = 1;
							num3 = 11;
							continue;
						case 11:
							return true;
						case 1:
							if (string.IsNullOrWhiteSpace(_local_5__2))
							{
								num3 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
								{
									num3 = 20;
								}
								continue;
							}
							goto case 17;
						case 15:
							num4 = __1__state;
							num3 = 14;
							continue;
						case 7:
							__2__current = System.IO.Path.Combine((string[])new object[5]
							{
								(object)_common_5__3,
								(object)"Microsoft",
								(object)"Windows",
								(object)"WER",
								(object)"ReportQueue"
							});
							num3 = 20;
							continue;
						case 20:
							__1__state = 4;
							num3 = 2;
							continue;
						case 5:
							return false;
						case 10:
							return true;
						case 6:
						case 16:
							if (string.IsNullOrWhiteSpace(_common_5__3))
							{
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num3 = 9;
								}
								continue;
							}
							goto case 12;
						case 12:
							__2__current = System.IO.Path.Combine((string[])new object[5]
							{
								(object)_common_5__3,
								(object)"Microsoft",
								(object)"Windows",
								(object)"WER",
								(object)"ReportArchive"
							});
							num = 8;
							break;
						case 17:
							__2__current = System.IO.Path.Combine((string[])new object[5]
							{
								(object)_local_5__2,
								(object)"Microsoft",
								(object)"Windows",
								(object)"WER",
								(object)"ReportArchive"
							});
							num = 3;
							break;
						case 8:
							__1__state = 3;
							num = 27;
							break;
						case 18:
							__1__state = 2;
							num3 = 10;
							continue;
						case 9:
							__2__current = System.IO.Path.Combine((string[])new object[5]
							{
								(object)_local_5__2,
								(object)"Microsoft",
								(object)"Windows",
								(object)"WER",
								(object)"ReportQueue"
							});
							num3 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num3 = 18;
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
			int num = 5;
			_GetWerRoots_d__11 result = default(_GetWerRoots_d__11);
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
							if (num2 != 12 && num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 3;
						case 4:
							if (__l__initialThreadId == System.Environment.CurrentManagedThreadId)
							{
								num3 = 2;
								continue;
							}
							break;
						case 1:
							result = this;
							num3 = 3;
							continue;
						case 2:
							__1__state = 0;
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num3 = 8;
							}
							continue;
						case 3:
							return result;
						case 5:
							if (__1__state == -2)
							{
								num3 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
								{
									num3 = 4;
								}
								continue;
							}
							break;
						case 0:
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
				result = (_GetWerRoots_d__11)new _GetWerRoots_d__11(0);
				num = 12;
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
						default:
							if (num2 == 9)
							{
								xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto IL_0031;
						case 2:
							return;
						case 0:
							goto end_IL_000e;
						case 1:
							break;
						}
						goto IL_0078;
						IL_0031:
						if (num2 == 990)
						{
							break;
						}
						goto IL_0078;
						IL_0078:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 8;
						}
					}
					continue;
					end_IL_000e:
					break;
				}
				num = 9;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool XjeslL9pi7luq8erYfU5()
		{
			return L6n4kA9pGbSNfNWcDhXP == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static _GetWerRoots_d__11 BuB6419pnbCxyyoVtj8V()
		{
			return L6n4kA9pGbSNfNWcDhXP;
		}
	}

	private static readonly TimeSpan d4AXmv6RC83;

	private static object QmDXmEA70Ji;

	private static readonly HashSet<string> qiKXm2nFF0W;

	internal static object zfQ6nAZtK76tyJAU6rFL;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static List<Q6QWnhXmB8feJrqhLhUB> CollectEvents(object executablePath, List<string> notes)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static List<CH6nNdXmlpGaNYNdiUnj> CollectWerReports(object executablePath, List<string> notes)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void K5CXmxgF3uh(object provider, object executablePath, List<Q6QWnhXmB8feJrqhLhUB> events)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void BvyXmFprSPA(object xml, object executablePath, List<Q6QWnhXmB8feJrqhLhUB> events)
	{
		//IL_097d: Expected O, but got I
		//IL_0982: Expected O, but got I
		//IL_0503: Expected O, but got I
		//IL_0835: Expected O, but got I
		//IL_07e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_0378: Expected O, but got I
		//IL_0548: Expected O, but got I
		//IL_054d: Expected O, but got I
		//IL_05e7: Expected O, but got I
		//IL_05ec: Expected O, but got I
		//IL_0582: Expected O, but got I
		//IL_03b3: Expected O, but got I4
		//IL_064a: Expected O, but got I
		//IL_064f: Expected O, but got I
		//IL_06b4: Expected O, but got I
		//IL_06b9: Expected O, but got I
		//IL_0727: Expected O, but got I
		//IL_0780: Expected O, but got I
		//IL_096a->IL097d: Incompatible stack heights: 2 vs 3
		//IL_0999->IL0010: Incompatible stack heights: 2 vs 1
		//IL_09a4->IL0010: Incompatible stack heights: 2 vs 1
		//IL_01cc->IL0056: Incompatible stack heights: 3 vs 1
		//IL_04f0->IL0503: Incompatible stack heights: 2 vs 3
		//IL_0835->IL0835: Incompatible stack heights: 3 vs 2
		//IL_0360->IL0373: Incompatible stack heights: 3 vs 4
		//IL_030e->IL0233: Incompatible stack heights: 4 vs 1
		//IL_0535->IL0548: Incompatible stack heights: 4 vs 5
		//IL_0319->IL0233: Incompatible stack heights: 4 vs 1
		//IL_05d4->IL05e7: Incompatible stack heights: 4 vs 5
		//IL_055a->IL059e: Incompatible stack heights: 4 vs 3
		//IL_0582->IL0582: Incompatible stack heights: 6 vs 5
		//IL_03f5->IL03f5: Incompatible stack heights: 4 vs 3
		//IL_05fe->IL0608: Incompatible stack heights: 4 vs 3
		//IL_0637->IL064a: Incompatible stack heights: 4 vs 5
		//IL_059e->IL059e: Incompatible stack heights: 4 vs 3
		//IL_0594->IL059e: Incompatible stack heights: 4 vs 3
		//IL_022f->IL022f: Incompatible stack heights: 1 vs 0
		//IL_0608->IL0608: Incompatible stack heights: 4 vs 3
		//IL_0666->IL0666: Incompatible stack heights: 4 vs 3
		//IL_065c->IL0666: Incompatible stack heights: 4 vs 3
		//IL_06a1->IL06b4: Incompatible stack heights: 4 vs 5
		//IL_06f9->IL0056: Incompatible stack heights: 2 vs 1
		//IL_06cb->IL06d5: Incompatible stack heights: 4 vs 3
		//IL_0727->IL0727: Incompatible stack heights: 4 vs 3
		//IL_06d5->IL06d5: Incompatible stack heights: 4 vs 3
		//IL_0747->IL0056: Incompatible stack heights: 2 vs 1
		//IL_0780->IL0780: Incompatible stack heights: 4 vs 3
		//IL_0752->IL0056: Incompatible stack heights: 2 vs 1
		//IL_079b->IL0056: Incompatible stack heights: 2 vs 1
		//IL_07ab->IL07ab: Incompatible stack heights: 2 vs 1
		int num = 1;
		global::System.Collections.Generic.IEnumerator<XElement> enumerator = default(global::System.Collections.Generic.IEnumerator<XElement>);
		XElement val = default(XElement);
		int num5 = default(int);
		string executableName = default(string);
		DateTimeOffset? val3 = default(DateTimeOffset?);
		int num4 = default(int);
		string provider = default(string);
		int eventId = default(int);
		string level = default(string);
		string recordId = default(string);
		DateTimeOffset? createdAtUtc = default(DateTimeOffset?);
		Dictionary<string, string> val2 = default(Dictionary<string, string>);
		global::System.Collections.Generic.IEnumerator<XElement> enumerator2 = default(global::System.Collections.Generic.IEnumerator<XElement>);
		int num7 = default(int);
		string text3 = default(string);
		int num9 = default(int);
		DateTimeOffset val4 = default(DateTimeOffset);
		int num11 = default(int);
		do
		{
			while (true)
			{
				switch (num)
				{
				case 0:
					try
					{
						while (true)
						{
							IL_01cc:
							int num2;
							if (!(enumerator).MoveNext())
							{
								num2 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									num2 = 3;
								}
								goto IL_0056;
							}
							goto IL_016f;
							IL_016f:
							val = (XElement)enumerator;
							num2 = 8;
							goto IL_0056;
							IL_0056:
							while (true)
							{
								int num3;
								DateTimeOffset? obj4;
								object obj2;
								switch (num2)
								{
								default:
									if (num5 != 25)
									{
										if (num5 == 1005)
										{
											goto IL_0052;
										}
										goto case 17;
									}
									goto IL_01cc;
								case 8:
									if (!vJuXmNLZBvr((val).Value, executablePath, executableName))
									{
										num3 = 25;
										goto IL_004e;
									}
									goto case 11;
								case 14:
									if ((nint)events < 40)
									{
										num2 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num2 = 5;
										}
										continue;
									}
									return;
								case 15:
									val3 = null;
									num2 = 9;
									continue;
								case 3:
									return;
								case 9:
									obj4 = val3;
									goto IL_07ea;
								case 4:
									break;
								case 17:
									num4 = 0;
									num3 = 16;
									goto IL_004e;
								case 2:
								{
									new Q6QWnhXmB8feJrqhLhUB
									{
										Provider = provider,
										EventId = eventId,
										Level = level,
										RecordId = recordId,
										CreatedAtUtc = createdAtUtc,
										Data = val2
									};
									int num12 = 14;
									continue;
								}
								case 7:
								case 13:
									goto IL_01cc;
								case 10:
									try
									{
										while (true)
										{
											int num6;
											if (!(enumerator2).MoveNext())
											{
												num6 = 5;
												goto IL_0233;
											}
											goto IL_0342;
											IL_0266:
											if (num7 == 995)
											{
												goto IL_022f;
											}
											goto IL_0342;
											IL_0342:
											global::System.Collections.Generic.IEnumerable<XAttribute> enumerable2 = (enumerator2).Attributes();
											__c_29 _2;
											if (__c_29.__9__9_10 == null)
											{
												_2 = __c_29.__9;
												__c_29.__9__9_10 = new Func<XAttribute, bool>(__c_29.Wf5LXsAlW0e);
											}
											XAttribute obj3 = Enumerable.FirstOrDefault<XAttribute>((global::System.Collections.Generic.IEnumerable<XAttribute>)(object)_2, new Func<XAttribute, bool>(__c_29.Wf5LXsAlW0e));
											string text = ((obj3 != null) ? (obj3).Value : null);
											string text2;
											if (!string.IsNullOrWhiteSpace(text))
											{
												text2 = text;
											}
											else
											{
												int num13 = 4;
												global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = (global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler)1;
												(defaultInterpolatedStringHandler).AppendLiteral("Data");
												defaultInterpolatedStringHandler.AppendFormatted<int>(num4);
												(defaultInterpolatedStringHandler).ToStringAndClear();
											}
											text = text2;
											text3 = GjWXmpGBATR((enumerable2).Value, 16384);
											num7 = 15;
											goto IL_022f;
											IL_0233:
											while (true)
											{
												switch (num6)
												{
												case 0:
												case 1:
												case 6:
													num4++;
													num6 = 3;
													continue;
												case 3:
													goto end_IL_0233;
												case 7:
													goto IL_02f3;
												case 2:
													goto IL_0319;
												case 4:
													goto IL_0342;
												case 5:
													goto end_IL_02d8;
												}
												if (num7 != 15)
												{
													goto IL_0266;
												}
												if ((text3).Length <= 0)
												{
													num6 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
													{
														num6 = 6;
													}
													continue;
												}
												goto IL_0319;
												IL_0319:
												if ((nint)val2 >= 40)
												{
													num6 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
													{
														num6 = 9;
													}
													continue;
												}
												goto IL_02f3;
												IL_02f3:
												int num14 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
												{
													int num15 = 0;
												}
												continue;
												end_IL_0233:
												break;
											}
											continue;
											IL_022f:
											num6 = num7;
											goto IL_0233;
											continue;
											end_IL_02d8:
											break;
										}
									}
									finally
									{
										int num8;
										if (enumerator2 == null)
										{
											num8 = 2;
											goto IL_043f;
										}
										goto IL_0487;
										IL_0487:
										(enumerator2).Dispose();
										num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
										{
											num8 = 1;
										}
										goto IL_043f;
										IL_043f:
										while (true)
										{
											switch (num8)
											{
											default:
												if (num9 == 990)
												{
													goto IL_043b;
												}
												break;
											case 2:
												goto end_IL_043f;
											case 0:
												break;
											case 1:
												goto end_IL_043f;
											}
											goto IL_0487;
											IL_043b:
											num8 = num9;
											continue;
											end_IL_043f:
											break;
										}
									}
									goto case 2;
								case 0:
									val2 = (Dictionary<string, string>)(object)System.StringComparer.OrdinalIgnoreCase;
									num2 = 17;
									continue;
								case 11:
								{
									(val).Elements();
									__c_29 _3;
									if (__c_29.__9__9_1 == null)
									{
										_3 = __c_29.__9;
										__c_29.__9__9_1 = new Func<XElement, bool>(__c_29.EJ3LXOMZXrr);
									}
									XElement obj5 = Enumerable.FirstOrDefault<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_3, new Func<XElement, bool>(__c_29.EJ3LXOMZXrr));
									object obj6;
									if (obj5 == null)
									{
										obj6 = null;
									}
									else
									{
										(obj5).Elements();
										__c_29 _4;
										if (__c_29.__9__9_2 == null)
										{
											_4 = __c_29.__9;
											__c_29.__9__9_2 = new Func<XElement, bool>(__c_29.S0VLX5XPpRB);
										}
										XElement obj7 = Enumerable.FirstOrDefault<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_4, new Func<XElement, bool>(__c_29.S0VLX5XPpRB));
										if (obj7 == null)
										{
											@null obj16 = null;
										}
										else
										{
											global::System.Collections.Generic.IEnumerable<XAttribute> enumerable3 = (obj7).Attributes();
											Func<XAttribute, bool> _9__9_2 = __c_29.__9__9_3;
											if (_9__9_2 == null)
											{
												__c_29 _8 = __c_29.__9;
												__c_29.__9__9_3 = new Func<XAttribute, bool>(__c_29.L9VLX6qIlXx);
											}
											XAttribute obj8 = Enumerable.FirstOrDefault<XAttribute>(enumerable3, _9__9_2);
											if (obj8 == null)
											{
												@null obj17 = null;
											}
											else
											{
												(obj8).Value;
											}
										}
									}
									if (obj6 == null)
									{
										obj6 = string.Empty;
									}
									provider = (string)obj6;
									if (obj5 == null)
									{
									}
									else
									{
										(obj5).Elements();
										__c_29 _5;
										if (__c_29.__9__9_4 == null)
										{
											_5 = __c_29.__9;
											__c_29.__9__9_4 = new Func<XElement, bool>(__c_29.bAELXRPklip);
										}
										XElement obj9 = Enumerable.FirstOrDefault<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_5, new Func<XElement, bool>(__c_29.bAELXRPklip));
										if (obj9 == null)
										{
											@null obj18 = null;
										}
										else
										{
											(obj9).Value;
										}
									}
									eventId = MqlXmuUEBa6(null);
									object obj10;
									if (obj5 == null)
									{
										obj10 = null;
									}
									else
									{
										(obj5).Elements();
										__c_29 _6;
										if (__c_29.__9__9_5 == null)
										{
											_6 = __c_29.__9;
											__c_29.__9__9_5 = new Func<XElement, bool>(__c_29.ukTLXwff9Ms);
										}
										XElement obj11 = Enumerable.FirstOrDefault<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_6, new Func<XElement, bool>(__c_29.ukTLXwff9Ms));
										if (obj11 == null)
										{
											@null obj19 = null;
										}
										else
										{
											(obj11).Value;
										}
									}
									if (obj10 == null)
									{
										obj10 = string.Empty;
									}
									level = (string)obj10;
									object obj12;
									if (obj5 == null)
									{
										obj12 = null;
									}
									else
									{
										(obj5).Elements();
										__c_29 _7;
										if (__c_29.__9__9_6 == null)
										{
											_7 = __c_29.__9;
											__c_29.__9__9_6 = new Func<XElement, bool>(__c_29.rIKLXeqgUi8);
										}
										XElement obj13 = Enumerable.FirstOrDefault<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_7, new Func<XElement, bool>(__c_29.rIKLXeqgUi8));
										if (obj13 == null)
										{
											@null obj20 = null;
										}
										else
										{
											(obj13).Value;
										}
									}
									if (obj12 == null)
									{
										obj12 = string.Empty;
									}
									recordId = (string)obj12;
									if (obj5 == null)
									{
										int num16 = 12;
										continue;
									}
									global::System.Collections.Generic.IEnumerable<XElement> enumerable4 = (obj5).Elements();
									Func<XElement, bool> _9__9_3 = __c_29.__9__9_7;
									if (_9__9_3 == null)
									{
										__c_29 _9 = __c_29.__9;
										__c_29.__9__9_7 = new Func<XElement, bool>(__c_29.yuCLXPB2guW);
									}
									XElement obj14 = Enumerable.FirstOrDefault<XElement>(enumerable4, _9__9_3);
									if (obj14 == null)
									{
										int num17 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											int num18 = 6;
										}
										continue;
									}
									global::System.Collections.Generic.IEnumerable<XAttribute> enumerable5 = (obj14).Attributes();
									Func<XAttribute, bool> _9__9_4 = __c_29.__9__9_8;
									if (_9__9_4 == null)
									{
										__c_29 _10 = __c_29.__9;
										__c_29.__9__9_8 = new Func<XAttribute, bool>(__c_29.wYkLXxSxMlC);
									}
									XAttribute obj15 = Enumerable.FirstOrDefault<XAttribute>(enumerable5, _9__9_4);
									if (obj15 == null)
									{
										int num19 = 5;
										continue;
									}
									(obj15).Value;
									goto IL_07ab;
								}
								case 12:
									obj2 = null;
									goto IL_07ab;
								case 6:
									obj2 = null;
									goto IL_07ab;
								case 5:
									obj2 = null;
									goto IL_07ab;
								case 16:
								{
									global::System.Collections.Generic.IEnumerable<XElement> enumerable = (val).Descendants();
									Func<XElement, bool> _9__9_ = __c_29.__9__9_9;
									if (_9__9_ == null)
									{
										__c_29 _11 = __c_29.__9;
										__c_29.__9__9_9 = new Func<XElement, bool>(__c_29.cUVLXFFOWq5);
									}
									enumerator2 = (global::System.Collections.Generic.IEnumerator<XElement>)Enumerable.Where<XElement>(enumerable, _9__9_);
									num3 = 10;
									goto IL_004e;
								}
								case 1:
									return;
									IL_07ab:
									if (!System.DateTimeOffset.TryParse((string)obj2, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, (DateTimeStyles)64, out val4))
									{
										num2 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
										{
											num2 = 15;
										}
										continue;
									}
									obj4 = val4;
									goto IL_07ea;
									IL_07ea:
									createdAtUtc = obj4;
									num2 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num2 = 0;
									}
									continue;
									IL_004e:
									num5 = num3;
									goto IL_0052;
									IL_0052:
									num2 = num5;
									continue;
								}
								break;
							}
							goto IL_016f;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num10 = 1;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 989)
									{
										num10 = num11;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0884;
								}
								(enumerator).Dispose();
								num10 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
								{
									num10 = 0;
								}
								continue;
								end_IL_0884:
								break;
							}
						}
					}
				case 2:
					return;
				case 1:
				{
					XDocument obj = System.Xml.Linq.XDocument.Parse(string.Concat("<Events>", (string)xml, "</Events>"), (LoadOptions)0);
					executableName = System.IO.Path.GetFileName((string)executablePath);
					(obj).Descendants();
					__c_29 _;
					if (__c_29.__9__9_0 == null)
					{
						_ = __c_29.__9;
						__c_29.__9__9_0 = new Func<XElement, bool>(__c_29.XpHLXt6hxpf);
					}
					enumerator = (global::System.Collections.Generic.IEnumerator<XElement>)Enumerable.Where<XElement>((global::System.Collections.Generic.IEnumerable<XElement>)(object)_, new Func<XElement, bool>(__c_29.XpHLXt6hxpf));
					int num20 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
					{
						int num21 = 7;
					}
					continue;
				}
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static CH6nNdXmlpGaNYNdiUnj? vZKXmslXjRT(object path, object executablePath)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got I4
		//IL_039b: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b->IL0078: Incompatible stack heights: 1 vs 4
		//IL_008d->IL00c4: Incompatible stack heights: 3 vs 0
		//IL_0066->IL0078: Incompatible stack heights: 1 vs 4
		//IL_0540->IL02af: Incompatible stack heights: 4 vs 3
		//IL_04bc->IL014d: Incompatible stack heights: 7 vs 4
		//IL_054a->IL014d: Incompatible stack heights: 5 vs 4
		//IL_04c7->IL014d: Incompatible stack heights: 7 vs 4
		int num = 1;
		int num12 = default(int);
		CH6nNdXmlpGaNYNdiUnj result = default(CH6nNdXmlpGaNYNdiUnj);
		FileStream val = default(FileStream);
		int num7 = default(int);
		int num8 = default(int);
		string text3 = default(string);
		int num6 = default(int);
		int num4 = default(int);
		Dictionary<string, string> val2 = default(Dictionary<string, string>);
		string[] array2 = default(string[]);
		string text2 = default(string);
		string text = default(string);
		int num5 = default(int);
		int num11 = default(int);
		int num14 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					if ((System.IO.File.GetAttributes((string)path) & 0x400) != 0)
					{
						_ = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							_ = 3;
						}
						goto IL_0078;
					}
					goto IL_00c4;
					IL_0078:
					int num2;
					while (true)
					{
						switch (num2)
						{
						default:
							if (num12 == 991)
							{
								goto IL_0074;
							}
							goto end_IL_0078;
						case 2:
							goto end_IL_0078;
						case 0:
							break;
						case 3:
							result = null;
							num12 = 2;
							goto IL_0074;
						case 1:
							try
							{
								byte[] array = new byte[checked((int)System.Math.Min((val).Length, 262144L))];
								int num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
								{
									num3 = 11;
								}
								while (true)
								{
									object obj;
									switch (num3)
									{
									default:
										if (num7 != 35)
										{
											if (num7 == 1015)
											{
												goto IL_0149;
											}
											goto case 12;
										}
										if (num8 > 0)
										{
											num3 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num3 = 26;
											}
											continue;
										}
										goto case 1;
									case 5:
									{
										num8 = (text3).IndexOf('=');
										int num9 = 35;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
										{
											num9 = 2;
										}
										num7 = num9;
										goto IL_0149;
									}
									case 24:
										goto end_IL_014d;
									case 16:
									case 22:
										if (num6 < array.Length)
										{
											num3 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
											{
												num3 = 30;
											}
											continue;
										}
										goto case 14;
									case 6:
										num4 = 0;
										num3 = 4;
										continue;
									case 1:
										num4++;
										num3 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
										{
											num3 = 2;
										}
										continue;
									case 7:
										if (val2 == null)
										{
											num3 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
											{
												num3 = 20;
											}
											continue;
										}
										goto case 21;
									case 0:
										num6 = 0;
										num3 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
										{
											num3 = 16;
										}
										continue;
									case 19:
										result = null;
										num3 = 24;
										continue;
									case 4:
									case 17:
										if (num4 < array2.Length)
										{
											num3 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
											{
												num3 = 5;
											}
											continue;
										}
										goto case 7;
									case 2:
									case 15:
										text3 = array2[num4];
										num3 = 5;
										continue;
									case 21:
										obj = (object)new CH6nNdXmlpGaNYNdiUnj
										{
											FileName = System.IO.Path.GetFileName((string)path),
											ModifiedAtUtc = ((System.DateTimeOffset)System.IO.File.GetLastWriteTimeUtc((string)path)),
											Fields = val2
										};
										break;
									case 14:
										text2 = XkJXmMbXoit(array, num6);
										num3 = 25;
										continue;
									case 26:
										text = ((text3).Substring(0, num8)).Trim();
										num3 = 8;
										continue;
									case 10:
										array2 = (text2).Split(new string[2]
										{
											"\r\n",
											"\n"
										}, (StringSplitOptions)1);
										num3 = 6;
										continue;
									case 25:
										if (vJuXmNLZBvr(text2, executablePath, System.IO.Path.GetFileName((string)executablePath)))
										{
											num3 = 18;
											continue;
										}
										goto case 19;
									case 12:
										GjWXmpGBATR((text3).Substring(num8 + 1), 4096);
										_ = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
										{
											_ = 0;
										}
										continue;
									case 11:
									case 18:
										val2 = (Dictionary<string, string>)(object)System.StringComparer.OrdinalIgnoreCase;
										num3 = 10;
										continue;
									case 13:
										num6 += num5;
										num3 = 22;
										continue;
									case 9:
										if (num5 > 0)
										{
											num3 = 13;
											continue;
										}
										goto case 14;
									case 3:
									case 23:
										num5 = (val).Read(array, num6, array.Length - num6);
										num3 = 9;
										continue;
									case 8:
										_ = qiKXm2nFF0W;
										if (text != null)
										{
											_ = 12;
											continue;
										}
										goto case 1;
									case 20:
										obj = null;
										break;
									case 27:
										goto end_IL_014d;
										IL_0149:
										num3 = num7;
										continue;
									}
									result = (CH6nNdXmlpGaNYNdiUnj)obj;
									num3 = 25;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
									{
										num3 = 27;
									}
									continue;
									end_IL_014d:
									break;
								}
							}
							finally
							{
								int num10;
								if (val == null)
								{
									num10 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
									{
										num10 = 0;
									}
									goto IL_05d0;
								}
								goto IL_0618;
								IL_05d0:
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 990)
										{
											goto IL_05cc;
										}
										goto end_IL_05d0;
									case 1:
										goto end_IL_05d0;
									case 0:
										break;
									case 2:
										goto end_IL_05d0;
									}
									goto IL_0618;
									IL_05cc:
									num10 = num11;
									continue;
									end_IL_05d0:
									break;
								}
								goto end_IL_0598;
								IL_0618:
								(val).Dispose();
								num10 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num10 = 5;
								}
								goto IL_05d0;
								end_IL_0598:;
							}
							goto end_IL_0078;
						}
						goto IL_00c4;
						IL_0074:
						num2 = num12;
						continue;
						end_IL_0078:
						break;
					}
					goto end_IL_0031;
					IL_00c4:
					_ = 3;
					_ = 1;
					val = (FileStream)(object)7;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
					{
						num2 = 2;
					}
					goto IL_0078;
					end_IL_0031:;
				}
				catch
				{
					int num13 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
					{
						num13 = 5;
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
							goto end_IL_0676;
						}
						result = null;
						num13 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num13 = 3;
						}
						continue;
						end_IL_0676:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[IteratorStateMachine(typeof(object))]
	private static global::System.Collections.Generic.IEnumerable<string> E4kXmT6IMqd()
	{
		//yield-return decompiler failed: Could not find stateField
		return (global::System.Collections.Generic.IEnumerable<string>)new _GetWerRoots_d__11(-2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool vJuXmNLZBvr(object value, object executablePath, object executableName)
	{
		int num = 5;
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
						goto IL_00c0;
					case 2:
					case 3:
						if (string.IsNullOrWhiteSpace((string)executablePath))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 4;
					case 6:
						if (!(value).Contains((string)executableName, (StringComparison)5))
						{
							num3 = 3;
							continue;
						}
						goto IL_00c0;
					case 4:
						return (value).Contains((string)executablePath, (StringComparison)5);
					case 1:
						return false;
					case 5:
						if ((value).Contains("Chronal", (StringComparison)5))
						{
							break;
						}
						goto case 0;
					case 0:
						{
							if (string.IsNullOrWhiteSpace((string)executableName))
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
								{
									num3 = 2;
								}
								continue;
							}
							goto case 6;
						}
						IL_00c0:
						return true;
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
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string XkJXmMbXoit(object bytes, int length)
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						return (System.Text.Encoding.Unicode).GetString((byte[])bytes, 2, length - 2);
					case 0:
						if (((short[])bytes)[0] == 255)
						{
							num3 = 3;
							continue;
						}
						goto case 1;
					case 2:
						if (length < 2)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 0;
					case 3:
						if (((short[])bytes)[1] == 254)
						{
							break;
						}
						goto case 1;
					case 1:
						return (System.Text.Encoding.UTF8).GetString((byte[])bytes, 0, length);
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
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GjWXmpGBATR(object value, int maxLength)
	{
		int num = 3;
		string text = default(string);
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
					text = ((value).Replace('\0', ' ')).Trim();
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
					{
						num2 = 7;
					}
					break;
				case 1:
					return string.Concat((text).Substring(0, maxLength), " [truncated]");
				case 0:
					return text;
				case 2:
					if ((text).Length <= maxLength)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto case 1;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int MqlXmuUEBa6(object? value)
	{
		int num = 1;
		int result = default(int);
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
					goto case 0;
				case 2:
					return 0;
				case 0:
					return result;
				case 1:
					if (int.TryParse((string)value, (NumberStyles)7, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out result))
					{
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
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
		QmDXmEA70Ji = new object[4]
		{
			(object)"Application Error",
			(object)".NET Runtime",
			(object)"Windows Error Reporting",
			(object)"Application Hang"
		};
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool BBiptdZtHLm7RhiieM1Y()
	{
		return zfQ6nAZtK76tyJAU6rFL == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static H82ksWXme9QYRLnKL0ta pvgA6EZtt4QN7WthIQuC()
	{
		return (H82ksWXme9QYRLnKL0ta)zfQ6nAZtK76tyJAU6rFL;
	}
}

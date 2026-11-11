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
		public static readonly __c_29 __9;

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
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_29()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
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
		internal DateTimeOffset? UZkLXgT5VtY(Q6QWnhXmB8feJrqhLhUB item)
		{
			return item.CreatedAtUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal FileInfo EAtLXlpa33q(string path)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			return new FileInfo(path);
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
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
			{
				num = 1;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				default:
					if (num2 != 990)
					{
						return;
					}
					goto IL_0042;
				case 2:
					return;
				case 0:
					__l__initialThreadId = System.Environment.CurrentManagedThreadId;
					num2 = 2;
					goto IL_0042;
				case 1:
					{
						__1__state = __1__state;
						num = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num = 0;
						}
						break;
					}
					IL_0042:
					num = num2;
					break;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		[DebuggerHidden]
		private void System_IDisposable_Dispose()
		{
			_common_5__3 = null;
		}

		void global::System.IDisposable.Dispose()
		{
			//ILSpy generated this explicit interface implementation from .override directive in System_IDisposable_Dispose
			this.System_IDisposable_Dispose();
		}

		[MethodImpl((MethodImplOptions)8)]
		private bool MoveNext()
		{
			__2__current = System.IO.Path.Combine(new string[5]
			{
				_local_5__2,
				"Microsoft",
				"Windows",
				"WER",
				"ReportArchive"
			});
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
			__1__state = 0;
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

	private static readonly object QmDXmEA70Ji;

	private static readonly HashSet<string> qiKXm2nFF0W;

	internal static object zfQ6nAZtK76tyJAU6rFL;

	[MethodImpl((MethodImplOptions)8)]
	internal static List<Q6QWnhXmB8feJrqhLhUB> CollectEvents(object executablePath, List<string> notes)
	{
		int num = 3;
		string[] qmDXmEA70Ji = default(string[]);
		List<Q6QWnhXmB8feJrqhLhUB> val = default(List<Q6QWnhXmB8feJrqhLhUB>);
		int num8 = default(int);
		string text = default(string);
		int num7 = default(int);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto case 10;
						}
						qmDXmEA70Ji = (string[])QmDXmEA70Ji;
						num3 = 16;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
						{
							num3 = 10;
						}
						continue;
					case 7:
						return val;
					case 2:
						if (System.OperatingSystem.IsWindows())
						{
							break;
						}
						goto case 7;
					case 8:
						num8++;
						num3 = 5;
						continue;
					case 10:
						num8 = 0;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						val = new List<Q6QWnhXmB8feJrqhLhUB>();
						num3 = 2;
						continue;
					case 1:
					case 9:
						text = qmDXmEA70Ji[num8];
						num3 = 6;
						continue;
					case 0:
					case 5:
						if (num8 < qmDXmEA70Ji.Length)
						{
							num3 = 9;
							continue;
						}
						goto case 4;
					case 6:
						try
						{
							K5CXmxgF3uh(text, executablePath, val);
							int num4 = 2;
							while (true)
							{
								IL_0169:
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									case 0:
									case 3:
										goto end_IL_016d;
									default:
										if (num4 == 991)
										{
											break;
										}
										goto end_IL_0147;
									case 1:
										goto end_IL_0147;
									case 2:
										if (val.Count < 40)
										{
											num5 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
											{
												num5 = 1;
											}
											continue;
										}
										goto end_IL_0147;
									}
									goto IL_0169;
									continue;
									end_IL_016d:
									break;
								}
								break;
							}
							goto case 8;
							end_IL_0147:;
						}
						catch (global::System.Exception ex)
						{
							int num6 = 2;
							while (true)
							{
								switch (num6)
								{
								case 1:
									break;
								default:
									if (num7 == 990)
									{
										num6 = num7;
										continue;
									}
									goto case 2;
								case 2:
									cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "CollectEvents", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\CrashDiagnostics\\WindowsCrashEvidenceCollector.cs", 56);
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
									{
										num6 = 7;
									}
									continue;
								case 0:
									notes.Add(string.Concat("读取 Windows 事件提供程序 ", text, " 失败：", ((ex).GetType()).Name));
									num6 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
									{
										num6 = 1;
									}
									continue;
								}
								break;
							}
							goto case 8;
						}
						goto case 4;
					case 4:
						return Enumerable.ToList<Q6QWnhXmB8feJrqhLhUB>(Enumerable.Take<Q6QWnhXmB8feJrqhLhUB>((global::System.Collections.Generic.IEnumerable<Q6QWnhXmB8feJrqhLhUB>)Enumerable.OrderByDescending<Q6QWnhXmB8feJrqhLhUB, DateTimeOffset?>((global::System.Collections.Generic.IEnumerable<Q6QWnhXmB8feJrqhLhUB>)val, (Func<Q6QWnhXmB8feJrqhLhUB, DateTimeOffset?>)([MethodImpl((MethodImplOptions)8)] (Q6QWnhXmB8feJrqhLhUB item) => item.CreatedAtUtc)), 40));
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
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
			{
				num = 17;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static List<CH6nNdXmlpGaNYNdiUnj> CollectWerReports(object executablePath, List<string> notes)
	{
		int num = 1;
		List<CH6nNdXmlpGaNYNdiUnj> val = default(List<CH6nNdXmlpGaNYNdiUnj>);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		string current = default(string);
		int num13 = default(int);
		int num10 = default(int);
		global::System.Collections.Generic.IEnumerator<string> enumerator2 = default(global::System.Collections.Generic.IEnumerator<string>);
		List<CH6nNdXmlpGaNYNdiUnj> result = default(List<CH6nNdXmlpGaNYNdiUnj>);
		int num6 = default(int);
		CH6nNdXmlpGaNYNdiUnj cH6nNdXmlpGaNYNdiUnj = default(CH6nNdXmlpGaNYNdiUnj);
		int num9 = default(int);
		int num12 = default(int);
		int num15 = default(int);
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
				case 1:
					val = new List<CH6nNdXmlpGaNYNdiUnj>();
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
								{
									num3 = 0;
								}
								goto IL_0095;
							}
							goto IL_0620;
							IL_0620:
							current = enumerator.Current;
							num3 = 2;
							goto IL_0095;
							IL_0095:
							while (true)
							{
								switch (num3)
								{
								default:
									if (num13 == 991)
									{
										num3 = num13;
										continue;
									}
									goto end_IL_05f0;
								case 2:
									try
									{
										int num4;
										if (!System.IO.Directory.Exists(current))
										{
											num4 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
											{
												num4 = 3;
											}
											goto IL_0100;
										}
										goto IL_038b;
										IL_0100:
										while (true)
										{
											switch (num4)
											{
											default:
												if (num10 == 991)
												{
													goto IL_00fc;
												}
												break;
											case 1:
												try
												{
													while (true)
													{
														int num5;
														if (!(enumerator2).MoveNext())
														{
															num5 = 3;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
															{
																num5 = 4;
															}
															goto IL_015f;
														}
														goto IL_020b;
														IL_015f:
														while (true)
														{
															switch (num5)
															{
															case 4:
																goto IL_01a5;
															case 0:
																result = val;
																num5 = 4;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
																{
																	num5 = 5;
																}
																continue;
															case 1:
															case 6:
																goto end_IL_015f;
															case 7:
																goto IL_020b;
															case 2:
																if (val.Count >= 12)
																{
																	num5 = 13;
																	if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
																	{
																		num5 = 0;
																	}
																	continue;
																}
																goto end_IL_015f;
															case 3:
																goto end_IL_01db;
															case 5:
																return result;
															}
															if (num6 != 15)
															{
																if (num6 == 995)
																{
																	goto IL_015b;
																}
															}
															else if (cH6nNdXmlpGaNYNdiUnj == null)
															{
																num5 = 15;
																if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
																{
																	num5 = 1;
																}
																continue;
															}
															goto IL_01a5;
															IL_01a5:
															val.Add(cH6nNdXmlpGaNYNdiUnj);
															num5 = 2;
															continue;
															end_IL_015f:
															break;
														}
														continue;
														IL_015b:
														num5 = num6;
														goto IL_015f;
														IL_020b:
														cH6nNdXmlpGaNYNdiUnj = vZKXmslXjRT(enumerator2.Current, executablePath);
														int num7 = 15;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
														{
															num7 = 11;
														}
														num6 = num7;
														goto IL_015b;
														continue;
														end_IL_01db:
														break;
													}
												}
												finally
												{
													if (enumerator2 != null)
													{
														int num8 = 1;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
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
															case 1:
																break;
															case 0:
																goto end_IL_0311;
															}
															(enumerator2).Dispose();
															num8 = 0;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
															{
																num8 = 0;
															}
															continue;
															end_IL_0311:
															break;
														}
													}
												}
												goto end_IL_0100;
											case 3:
												goto end_IL_0100;
											case 0:
												break;
											case 2:
												goto end_IL_0100;
											}
											goto IL_038b;
											IL_00fc:
											num4 = num10;
											continue;
											end_IL_0100:
											break;
										}
										goto end_IL_00be;
										IL_038b:
										enumerator2 = Enumerable.Select<FileInfo, string>(Enumerable.Take<FileInfo>((global::System.Collections.Generic.IEnumerable<FileInfo>)Enumerable.OrderByDescending<FileInfo, global::System.DateTime>(Enumerable.Where<FileInfo>(Enumerable.Select<string, FileInfo>(System.IO.Directory.EnumerateFiles(current, "*.wer", (SearchOption)1), (Func<string, FileInfo>)([MethodImpl((MethodImplOptions)8)] (string path) => new FileInfo(path))), (Func<FileInfo, bool>)([MethodImpl((MethodImplOptions)8)] (FileInfo info) => ((info).LastWriteTimeUtc >= (System.DateTime.UtcNow - d4AXmv6RC83)))), (Func<FileInfo, global::System.DateTime>)([MethodImpl((MethodImplOptions)8)] (FileInfo info) => (info).LastWriteTimeUtc)), 80), (Func<FileInfo, string>)([MethodImpl((MethodImplOptions)8)] (FileInfo info) => (info).FullName)).GetEnumerator();
										num4 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
										{
											num4 = 1;
										}
										goto IL_0100;
										end_IL_00be:;
									}
									catch (global::System.Exception ex)
									{
										int num11 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 != 0)
										{
											num11 = 6;
										}
										while (true)
										{
											switch (num11)
											{
											default:
												if (num12 == 990)
												{
													num11 = num12;
													continue;
												}
												break;
											case 1:
												notes.Add(string.Concat("读取 WER 目录失败：", ((ex).GetType()).Name));
												num11 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
												{
													num11 = 8;
												}
												continue;
											case 2:
												cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "CollectWerReports", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\CrashDiagnostics\\WindowsCrashEvidenceCollector.cs", 102);
												num11 = 1;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
												{
													num11 = 4;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									break;
								case 3:
									break;
								case 1:
									goto IL_0620;
								case 0:
									goto end_IL_05f0;
								}
								break;
							}
							continue;
							end_IL_05f0:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num14 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num14 = 1;
							}
							while (true)
							{
								switch (num14)
								{
								default:
									if (num15 == 989)
									{
										num14 = num15;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0670;
								}
								(enumerator).Dispose();
								num14 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
								{
									num14 = 4;
								}
								continue;
								end_IL_0670:
								break;
							}
						}
					}
					break;
				case 0:
					enumerator = E4kXmT6IMqd().GetEnumerator();
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					break;
				}
				return val;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void K5CXmxgF3uh(object provider, object executablePath, List<Q6QWnhXmB8feJrqhLhUB> events)
	{
		//IL_0387: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_055a: Expected O, but got Unknown
		//IL_055a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_0566: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		//IL_0572: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Expected O, but got Unknown
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_058a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bf: Expected O, but got Unknown
		//IL_05df: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Expected O, but got Unknown
		//IL_0610: Unknown result type (might be due to invalid IL or missing references)
		//IL_061b: Expected O, but got Unknown
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0658: Expected O, but got Unknown
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0683: Expected O, but got Unknown
		//IL_06a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ae: Expected O, but got Unknown
		//IL_06d9: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Process val = default(Process);
		string text2 = default(string);
		int num10 = default(int);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		string text4 = default(string);
		int num7 = default(int);
		int num9 = default(int);
		int num12 = default(int);
		string text5 = default(string);
		string text = default(string);
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
						if (num2 != 10)
						{
							goto end_IL_0010;
						}
						try
						{
							int num4;
							if (val == null)
							{
								num4 = 3;
								goto IL_011f;
							}
							text2 = ((val).StandardOutput).ReadToEnd();
							int num5 = 4;
							goto IL_0127;
							IL_039e:
							num4 = 7;
							goto IL_011f;
							IL_0127:
							while (true)
							{
								string text3;
								switch (num5)
								{
								default:
									if (num10 != 20)
									{
										if (num10 == 1000)
										{
											goto IL_0123;
										}
										goto case 0;
									}
									defaultInterpolatedStringHandler.AppendFormatted<int>((val).ExitCode);
									num5 = 10;
									continue;
								case 9:
									break;
								case 6:
									text3 = (text4).Trim();
									goto IL_0423;
								case 1:
									return;
								case 3:
									throw new InvalidOperationException("无法启动 wevtutil");
								case 2:
									try
									{
										(val).Kill(true);
										int num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												if (num7 == 988)
												{
													num6 = num7;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									catch
									{
										int num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
										{
											num8 = 0;
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
									goto case 0;
								case 5:
								case 12:
									BvyXmFprSPA(text2, executablePath, events);
									num5 = 11;
									continue;
								case 8:
									goto end_IL_0127;
								case 7:
									goto IL_0351;
								case 0:
									throw new TimeoutException("wevtutil 查询超时");
								case 4:
									text4 = ((val).StandardError).ReadToEnd();
									num5 = 9;
									continue;
								case 10:
									text3 = (defaultInterpolatedStringHandler).ToStringAndClear();
									goto IL_0423;
								case 11:
									return;
									IL_0423:
									throw new InvalidOperationException(text3);
								}
								if (!(val).WaitForExit(8000))
								{
									num5 = 2;
									continue;
								}
								if ((val).ExitCode == 0)
								{
									if (string.IsNullOrWhiteSpace(text2))
									{
										return;
									}
									num5 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
									{
										num5 = 5;
									}
									continue;
								}
								goto IL_039e;
								IL_0351:
								if (!string.IsNullOrWhiteSpace(text4))
								{
									num5 = 6;
									continue;
								}
								defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(13, 1);
								num5 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
								{
									num5 = 10;
								}
								continue;
								end_IL_0127:
								break;
							}
							(defaultInterpolatedStringHandler).AppendLiteral("wevtutil 退出码 ");
							num4 = 20;
							goto IL_011f;
							IL_011f:
							num10 = num4;
							goto IL_0123;
							IL_0123:
							num5 = num10;
							goto IL_0127;
						}
						finally
						{
							int num11;
							if (val == null)
							{
								num11 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 != 0)
								{
									num11 = 0;
								}
								goto IL_0496;
							}
							goto IL_04c9;
							IL_0496:
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 990)
									{
										goto IL_0492;
									}
									break;
								case 0:
									goto end_IL_0496;
								case 2:
									break;
								case 1:
									goto end_IL_0496;
								}
								goto IL_04c9;
								IL_0492:
								num11 = num12;
								continue;
								end_IL_0496:
								break;
							}
							goto end_IL_045e;
							IL_04c9:
							(val).Dispose();
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
							{
								num11 = 0;
							}
							goto IL_0496;
							end_IL_045e:;
						}
					case 0:
						text5 = string.Concat("*[System[Provider[@Name='", text, "'] and (EventID=1000 or EventID=1001 or EventID=1002 or EventID=1026) and TimeCreated[timediff(@SystemTime) <= 604800000]]]");
						num3 = 2;
						continue;
					case 1:
						text = ((dynamic)(provider)).Replace("'", "&apos;", (StringComparison)4);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
						{
							num3 = 2;
						}
						continue;
					case 3:
						return;
					case 2:
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
			while (num2 == 991);
			ProcessStartInfo val2 = new ProcessStartInfo();
			((dynamic)((object)val2)).FileName = System.IO.Path.Combine(System.Environment.SystemDirectory, "wevtutil.exe");
			((dynamic)((object)val2)).UseShellExecute = false;
			((dynamic)((object)val2)).RedirectStandardOutput = true;
			((dynamic)((object)val2)).RedirectStandardError = true;
			((dynamic)((object)val2)).CreateNoWindow = true;
			((dynamic)((object)val2)).StandardOutputEncoding = System.Text.Encoding.UTF8;
			((dynamic)((object)val2)).StandardErrorEncoding = System.Text.Encoding.UTF8;
			((dynamic)((object)val2)).ArgumentList.Add("qe");
			((dynamic)((object)val2)).ArgumentList.Add("Application");
			((dynamic)((object)val2)).ArgumentList.Add(string.Concat("/q:", text5));
			((dynamic)((object)val2)).ArgumentList.Add("/f:xml");
			((dynamic)((object)val2)).ArgumentList.Add("/rd:true");
			((dynamic)((object)val2)).ArgumentList.Add("/c:256");
			val = System.Diagnostics.Process.Start(val2);
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void BvyXmFprSPA(object xml, object executablePath, List<Q6QWnhXmB8feJrqhLhUB> events)
	{
		//IL_082b: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		global::System.Collections.Generic.IEnumerator<XElement> enumerator = default(global::System.Collections.Generic.IEnumerator<XElement>);
		XElement current = default(XElement);
		int num6 = default(int);
		string executableName = default(string);
		DateTimeOffset? val3 = default(DateTimeOffset?);
		int num5 = default(int);
		string provider = default(string);
		int eventId = default(int);
		string level = default(string);
		string recordId = default(string);
		DateTimeOffset? createdAtUtc = default(DateTimeOffset?);
		Dictionary<string, string> val = default(Dictionary<string, string>);
		global::System.Collections.Generic.IEnumerator<XElement> enumerator2 = default(global::System.Collections.Generic.IEnumerator<XElement>);
		int num8 = default(int);
		string text = default(string);
		string text3 = default(string);
		int num10 = default(int);
		DateTimeOffset val4 = default(DateTimeOffset);
		int num12 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					try
					{
						while (true)
						{
							IL_01d8:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
								{
									num3 = 3;
								}
								goto IL_0056;
							}
							goto IL_0173;
							IL_0173:
							current = enumerator.Current;
							num3 = 8;
							goto IL_0056;
							IL_0056:
							while (true)
							{
								int num4;
								DateTimeOffset? val2;
								object obj2;
								switch (num3)
								{
								default:
									if (num6 != 25)
									{
										if (num6 == 1005)
										{
											goto IL_0052;
										}
										goto case 17;
									}
									goto IL_01d8;
								case 8:
									if (!vJuXmNLZBvr((current).Value, executablePath, executableName))
									{
										num4 = 25;
										goto IL_004e;
									}
									goto case 11;
								case 14:
									if (events.Count < 40)
									{
										num3 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
										{
											num3 = 5;
										}
										continue;
									}
									return;
								case 15:
									val3 = null;
									num3 = 9;
									continue;
								case 3:
									return;
								case 9:
									val2 = val3;
									goto IL_0832;
								case 4:
									break;
								case 17:
									num5 = 0;
									num4 = 16;
									goto IL_004e;
								case 2:
									events.Add((Q6QWnhXmB8feJrqhLhUB)new Q6QWnhXmB8feJrqhLhUB
									{
										Provider = provider,
										EventId = eventId,
										Level = level,
										RecordId = recordId,
										CreatedAtUtc = createdAtUtc,
										Data = val
									});
									num3 = 14;
									continue;
								case 7:
								case 13:
									goto IL_01d8;
								case 10:
									try
									{
										while (true)
										{
											int num7;
											if (!(enumerator2).MoveNext())
											{
												num7 = 5;
												goto IL_023f;
											}
											goto IL_0356;
											IL_0272:
											if (num8 == 995)
											{
												goto IL_023b;
											}
											goto IL_0356;
											IL_0356:
											XElement current2 = enumerator2.Current;
											XAttribute obj3 = Enumerable.FirstOrDefault<XAttribute>((current2).Attributes(), (Func<XAttribute, bool>)([MethodImpl((MethodImplOptions)8)] (XAttribute attribute) => (((attribute).Name).LocalName == "Name")));
											text = ((obj3 != null) ? (obj3).Value : null);
											string text2;
											if (!string.IsNullOrWhiteSpace(text))
											{
												text2 = text;
											}
											else
											{
												global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
												(defaultInterpolatedStringHandler).AppendLiteral("Data");
												defaultInterpolatedStringHandler.AppendFormatted<int>(num5);
												text2 = (defaultInterpolatedStringHandler).ToStringAndClear();
											}
											text = text2;
											text3 = GjWXmpGBATR((current2).Value, 16384);
											num8 = 15;
											goto IL_023b;
											IL_023f:
											while (true)
											{
												switch (num7)
												{
												case 0:
												case 1:
												case 6:
													num5++;
													num7 = 3;
													continue;
												case 3:
													goto end_IL_023f;
												case 7:
													goto IL_02ff;
												case 2:
													goto IL_0329;
												case 4:
													goto IL_0356;
												case 5:
													goto end_IL_02e4;
												}
												if (num8 != 15)
												{
													goto IL_0272;
												}
												if ((text3).Length <= 0)
												{
													num7 = 4;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
													{
														num7 = 6;
													}
													continue;
												}
												goto IL_0329;
												IL_0329:
												if (val.Count >= 40)
												{
													num7 = 1;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
													{
														num7 = 9;
													}
													continue;
												}
												goto IL_02ff;
												IL_02ff:
												val[text] = text3;
												num7 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
												{
													num7 = 0;
												}
												continue;
												end_IL_023f:
												break;
											}
											continue;
											IL_023b:
											num7 = num8;
											goto IL_023f;
											continue;
											end_IL_02e4:
											break;
										}
									}
									finally
									{
										int num9;
										if (enumerator2 == null)
										{
											num9 = 2;
											goto IL_045f;
										}
										goto IL_04a7;
										IL_04a7:
										(enumerator2).Dispose();
										num9 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
										{
											num9 = 1;
										}
										goto IL_045f;
										IL_045f:
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 990)
												{
													goto IL_045b;
												}
												break;
											case 2:
												goto end_IL_045f;
											case 0:
												break;
											case 1:
												goto end_IL_045f;
											}
											goto IL_04a7;
											IL_045b:
											num9 = num10;
											continue;
											end_IL_045f:
											break;
										}
									}
									goto case 2;
								case 0:
									val = new Dictionary<string, string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
									num3 = 17;
									continue;
								case 11:
								{
									XElement obj4 = Enumerable.FirstOrDefault<XElement>((current).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "System")));
									object obj5;
									if (obj4 == null)
									{
										obj5 = null;
									}
									else
									{
										XElement obj6 = Enumerable.FirstOrDefault<XElement>((obj4).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "Provider")));
										if (obj6 == null)
										{
											obj5 = null;
										}
										else
										{
											XAttribute obj7 = Enumerable.FirstOrDefault<XAttribute>((obj6).Attributes(), (Func<XAttribute, bool>)([MethodImpl((MethodImplOptions)8)] (XAttribute attribute) => (((attribute).Name).LocalName == "Name")));
											obj5 = ((obj7 != null) ? (obj7).Value : null);
										}
									}
									if (obj5 == null)
									{
										obj5 = string.Empty;
									}
									provider = (string)obj5;
									object value;
									if (obj4 == null)
									{
										value = null;
									}
									else
									{
										XElement obj8 = Enumerable.FirstOrDefault<XElement>((obj4).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "EventID")));
										value = ((obj8 != null) ? (obj8).Value : null);
									}
									eventId = MqlXmuUEBa6(value);
									object obj9;
									if (obj4 == null)
									{
										obj9 = null;
									}
									else
									{
										XElement obj10 = Enumerable.FirstOrDefault<XElement>((obj4).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "Level")));
										obj9 = ((obj10 != null) ? (obj10).Value : null);
									}
									if (obj9 == null)
									{
										obj9 = string.Empty;
									}
									level = (string)obj9;
									object obj11;
									if (obj4 == null)
									{
										obj11 = null;
									}
									else
									{
										XElement obj12 = Enumerable.FirstOrDefault<XElement>((obj4).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "EventRecordID")));
										obj11 = ((obj12 != null) ? (obj12).Value : null);
									}
									if (obj11 == null)
									{
										obj11 = string.Empty;
									}
									recordId = (string)obj11;
									if (obj4 == null)
									{
										num3 = 12;
										continue;
									}
									XElement obj13 = Enumerable.FirstOrDefault<XElement>((obj4).Elements(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "TimeCreated")));
									if (obj13 == null)
									{
										num3 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
										{
											num3 = 6;
										}
										continue;
									}
									XAttribute obj14 = Enumerable.FirstOrDefault<XAttribute>((obj13).Attributes(), (Func<XAttribute, bool>)([MethodImpl((MethodImplOptions)8)] (XAttribute attribute) => (((attribute).Name).LocalName == "SystemTime")));
									if (obj14 == null)
									{
										num3 = 5;
										continue;
									}
									obj2 = (obj14).Value;
									goto IL_07ef;
								}
								case 12:
									obj2 = null;
									goto IL_07ef;
								case 6:
									obj2 = null;
									goto IL_07ef;
								case 5:
									obj2 = null;
									goto IL_07ef;
								case 16:
									enumerator2 = Enumerable.Where<XElement>((current).Descendants(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "Data"))).GetEnumerator();
									num4 = 10;
									goto IL_004e;
								case 1:
									return;
									IL_07ef:
									if (!System.DateTimeOffset.TryParse((string)obj2, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, (DateTimeStyles)64, out val4))
									{
										num3 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
										{
											num3 = 15;
										}
										continue;
									}
									val2 = val4;
									goto IL_0832;
									IL_0832:
									createdAtUtc = val2;
									num3 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num3 = 0;
									}
									continue;
									IL_004e:
									num6 = num4;
									goto IL_0052;
									IL_0052:
									num3 = num6;
									continue;
								}
								break;
							}
							goto IL_0173;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 != 0)
							{
								num11 = 1;
							}
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 989)
									{
										num11 = num12;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_08d4;
								}
								(enumerator).Dispose();
								num11 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
								{
									num11 = 0;
								}
								continue;
								end_IL_08d4:
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
					enumerator = Enumerable.Where<XElement>((obj).Descendants(), (Func<XElement, bool>)([MethodImpl((MethodImplOptions)8)] (XElement node) => (((node).Name).LocalName == "Event"))).GetEnumerator();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
					{
						num2 = 7;
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
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
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
					int num2;
					if ((System.IO.File.GetAttributes((string)path) & (FileAttributes)(0x400)) != 0)
					{
						num2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
						{
							num2 = 3;
						}
						goto IL_0078;
					}
					goto IL_00c4;
					IL_0078:
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
												goto IL_014d;
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
										goto IL_014d;
									}
									case 24:
										goto end_IL_0151;
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
										if (val2.Count == 0)
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
										val2[text] = GjWXmpGBATR((text3).Substring(num8 + 1), 4096);
										num3 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
										{
											num3 = 0;
										}
										continue;
									case 11:
									case 18:
										val2 = new Dictionary<string, string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
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
										if (qiKXm2nFF0W.Contains(text))
										{
											num3 = 12;
											continue;
										}
										goto case 1;
									case 20:
										obj = null;
										break;
									case 27:
										goto end_IL_0151;
										IL_014d:
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
									end_IL_0151:
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
									goto IL_05e4;
								}
								goto IL_062c;
								IL_05e4:
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 990)
										{
											goto IL_05e0;
										}
										goto end_IL_05e4;
									case 1:
										goto end_IL_05e4;
									case 0:
										break;
									case 2:
										goto end_IL_05e4;
									}
									goto IL_062c;
									IL_05e0:
									num10 = num11;
									continue;
									end_IL_05e4:
									break;
								}
								goto end_IL_05ac;
								IL_062c:
								(val).Dispose();
								num10 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
								{
									num10 = 5;
								}
								goto IL_05e4;
								end_IL_05ac:;
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
					val = new FileStream((string)path, (FileMode)3, (FileAccess)1, (FileShare)7);
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
							goto end_IL_068a;
						}
						result = null;
						num13 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
						{
							num13 = 3;
						}
						continue;
						end_IL_068a:
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
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return (global::System.Collections.Generic.IEnumerable<string>)new _GetWerRoots_d__11(-2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool vJuXmNLZBvr(object value, object executablePath, object executableName)
	{
		int num = 5;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string XkJXmMbXoit(object bytes, int length)
	{
		int num = 2;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string GjWXmpGBATR(object value, int maxLength)
	{
		string text = (((dynamic)(value)).Replace('\0', ' ')).Trim();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int MqlXmuUEBa6(object? value)
	{
		int num = 1;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

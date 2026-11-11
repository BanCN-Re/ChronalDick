using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QJLKc2XLSrbrDYYC8fHq;
using fDAldojjppXrctUVYOJn;
using lSwbeIiYncqNAPG924P;

namespace L2iMPciJAUUQWujaTvW;

sealed class H9xiuWiW89hL8qcyGK8 : P83acLiVaQYLLKlo2dq, XDHiusXLYNedkNXhvm2U, global::System.IDisposable
{
	private readonly object jNNihRXMXX;

	private int t5YiU4LHQk;

	[CompilerGenerated]
	private readonly int yPWirmXKRh;

	[CompilerGenerated]
	private readonly DateTimeOffset LlKioHe9bX;

	[CompilerGenerated]
	private readonly string U8BimK1NsL;

	[CompilerGenerated]
	private readonly int JPmi70Hr2u;

	internal static object jDIM0WZowtpijjyl00bg;

	public int ProcessId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return yPWirmXKRh;
		}
	}

	public DateTimeOffset StartedAtUtc
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			return LlKioHe9bX;
		}
	}

	public string ExpectedExecutablePath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return U8BimK1NsL;
		}
	}

	public int ExpectedSessionId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return JPmi70Hr2u;
		}
	}

	public bool HasExpectedIdentity
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			int num4 = default(int);
			bool result = default(bool);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
			global::System.Exception ex = default(global::System.Exception);
			int num6 = default(int);
			bool flag = default(bool);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
			int num8 = default(int);
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
						if (System.Threading.Volatile.Read(ref t5YiU4LHQk) == 0)
						{
							num2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num2 = 0;
							}
							goto IL_007a;
						}
						int num3 = 0;
						goto IL_0131;
						IL_007a:
						while (true)
						{
							switch (num2)
							{
							default:
								if (num4 == 989)
								{
									goto IL_0076;
								}
								goto case 0;
							case 0:
							{
								int processId = ProcessId;
								DateTimeOffset startedAtUtc = StartedAtUtc;
								string expectedExecutablePath = ExpectedExecutablePath;
								int expectedSessionId = ExpectedSessionId;
								int actualProcessId = ((dynamic)(jNNihRXMXX)).Id;
								global::System.DateTime dateTime = ((dynamic)(jNNihRXMXX)).StartTime;
								DateTimeOffset actualStartedAtUtc = new DateTimeOffset((dateTime).ToUniversalTime());
								ProcessModule obj = ((dynamic)(jNNihRXMXX)).MainModule;
								num3 = (AHoi4jxSX8(processId, startedAtUtc, expectedExecutablePath, expectedSessionId, actualProcessId, actualStartedAtUtc, (obj != null) ? (obj).FileName : null, ((dynamic)(jNNihRXMXX)).SessionId) ? 1 : 0);
								break;
							}
							case 1:
								goto end_IL_007a;
							}
							goto IL_0131;
							IL_0076:
							num2 = num4;
							continue;
							end_IL_007a:
							break;
						}
						goto end_IL_0034;
						IL_0131:
						result = (byte)num3 != 0;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num2 = 1;
						}
						goto IL_007a;
						end_IL_0034:;
					}
					catch (global::System.Exception obj2) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj3 = obj2 as global::System.Exception;
						if (obj3 == null)
						{
							num5 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
							{
								num5 = 8;
							}
							goto IL_0194;
						}
						ex = obj3;
						num6 = 21;
						goto IL_0190;
						IL_0194:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 != 21)
								{
									if (num6 == 1001)
									{
										break;
									}
									goto case 5;
								}
								if (!(ex is ArgumentException))
								{
									num5 = 13;
									continue;
								}
								goto case 1;
							case 12:
								flag = false;
								num5 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
								{
									num5 = 4;
								}
								continue;
							case 0:
								if (ex is NotSupportedException)
								{
									num5 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
									{
										num5 = 11;
									}
									continue;
								}
								goto case 5;
							case 13:
								if (ex is InvalidOperationException)
								{
									num5 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
									{
										num5 = 1;
									}
									continue;
								}
								goto case 0;
							case 1:
							case 3:
							case 6:
							case 9:
							case 11:
								flag = true;
								num5 = 2;
								continue;
							case 7:
								if (ex is UnauthorizedAccessException)
								{
									num5 = 6;
									continue;
								}
								goto case 12;
							case 10:
								if (ex is IOException)
								{
									num5 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
									{
										num5 = 14;
									}
									continue;
								}
								goto case 7;
							case 5:
								if (ex is Win32Exception)
								{
									num5 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
									{
										num5 = 11;
									}
									continue;
								}
								goto case 10;
							case 8:
								result2 = 0;
								goto IL_039a;
							case 2:
							case 4:
								{
									result2 = (flag ? 1 : 0);
									goto IL_039a;
								}
								IL_039a:
								return (byte)result2 != 0;
							}
							break;
						}
						goto IL_0190;
						IL_0190:
						num5 = num6;
						goto IL_0194;
					}).Invoke())
					{
						int num7 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								if (num8 == 989)
								{
									num7 = num8;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_03ce;
							}
							result = false;
							num7 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num7 = 1;
							}
							continue;
							end_IL_03ce:
							break;
						}
					}
					break;
				}
				break;
			}
			return result;
		}
	}

	public bool HasExited
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref t5YiU4LHQk) != 0, this);
			return default(bool);
		}
	}

	public int? ExitCode
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			int num5 = default(int);
			int? num4 = default(int?);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
			global::System.Exception ex = default(global::System.Exception);
			int num8 = default(int);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
			bool flag = default(bool);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num11 = default(int);
			int? num10 = default(int?);
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
						if (!HasExited)
						{
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num2 = 2;
							}
							goto IL_0070;
						}
						int? num3 = ((dynamic)(jNNihRXMXX)).ExitCode;
						goto IL_00dc;
						IL_0070:
						while (true)
						{
							switch (num2)
							{
							default:
								if (num5 == 990)
								{
									num2 = num5;
									continue;
								}
								goto case 2;
							case 2:
								num4 = null;
								num2 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
								{
									num2 = 0;
								}
								continue;
							case 0:
								num3 = num4;
								break;
							case 1:
								goto end_IL_0070;
							}
							goto IL_00dc;
							continue;
							end_IL_0070:
							break;
						}
						goto end_IL_0034;
						IL_00dc:
						num4 = num3;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num2 = 1;
						}
						goto IL_0070;
						end_IL_0034:;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num6 = 6;
							}
						}
						else
						{
							ex = obj2;
							num6 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num6 = 6;
							}
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num8 != 17)
								{
									if (num8 == 997)
									{
										goto IL_013b;
									}
									goto case 2;
								}
								goto case 0;
							case 7:
								if (ex is NotSupportedException)
								{
									num6 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num6 = 0;
									}
									continue;
								}
								goto case 3;
							case 9:
								if (ex is InvalidOperationException)
								{
									num7 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
									{
										num7 = 17;
									}
									num8 = num7;
									goto IL_013b;
								}
								goto case 7;
							case 0:
							case 8:
								flag = true;
								num6 = 4;
								continue;
							case 3:
								if (!(ex is Win32Exception))
								{
									num6 = 1;
									continue;
								}
								goto case 0;
							case 1:
							case 5:
								flag = false;
								num6 = 2;
								continue;
							case 6:
								result = 0;
								break;
							case 2:
							case 4:
								{
									result = (flag ? 1 : 0);
									break;
								}
								IL_013b:
								num6 = num8;
								continue;
							}
							break;
						}
						return (byte)result != 0;
					}).Invoke())
					{
						int num9 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num11 == 990)
								{
									num9 = num11;
									continue;
								}
								goto case 2;
							case 2:
								num4 = num10;
								num9 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
								{
									num9 = 1;
								}
								continue;
							case 0:
								num10 = null;
								num9 = 2;
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					break;
				}
				break;
			}
			return num4;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal H9xiuWiW89hL8qcyGK8(Process process, int processId, DateTimeOffset startedAtUtc, string expectedExecutablePath, int expectedSessionId)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public bool eTFL4ocFi44()
	{
		V6YiQ9gLwY();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task rwPL4mAFlfT(CancellationToken cancellationToken)
	{
		System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref t5YiU4LHQk) != 0, this);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void FWwL47t3QCh()
	{
		V6YiQ9gLwY();
	}

	[MethodImpl((MethodImplOptions)8)]
	private void V6YiQ9gLwY()
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string U9WiCL0SxC(string? path)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AHoi4jxSX8(int expectedProcessId, DateTimeOffset expectedStartedAtUtc, object expectedExecutablePath, int expectedSessionId, int actualProcessId, DateTimeOffset actualStartedAtUtc, string? actualExecutablePath, int actualSessionId)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		DateTimeOffset val = (expectedStartedAtUtc).ToUniversalTime();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		((dynamic)(jNNihRXMXX)).Dispose();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PLpw6cZoeLfMbebUAuB7()
	{
		return jDIM0WZowtpijjyl00bg == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static H9xiuWiW89hL8qcyGK8 h9IuIUZoPJTJrb5uRTY8()
	{
		return (H9xiuWiW89hL8qcyGK8)jDIM0WZowtpijjyl00bg;
	}
}

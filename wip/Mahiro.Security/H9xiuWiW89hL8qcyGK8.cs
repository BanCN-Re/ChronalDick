using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using QJLKc2XLSrbrDYYC8fHq;
using fDAldojjppXrctUVYOJn;
using lSwbeIiYncqNAPG924P;

namespace L2iMPciJAUUQWujaTvW;

internal sealed class H9xiuWiW89hL8qcyGK8 : P83acLiVaQYLLKlo2dq, XDHiusXLYNedkNXhvm2U, global::System.IDisposable
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
						goto IL_012d;
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
								int actualProcessId = (jNNihRXMXX).Id;
								global::System.DateTime dateTime = (jNNihRXMXX).StartTime;
								global::System.DateTime dateTime2 = (dateTime).ToUniversalTime();
								ProcessModule obj = (jNNihRXMXX).MainModule;
								num3 = (AHoi4jxSX8(processId, startedAtUtc, expectedExecutablePath, expectedSessionId, actualProcessId, (DateTimeOffset)dateTime2, (obj != null) ? (obj).FileName : null, (jNNihRXMXX).SessionId) ? 1 : 0);
								break;
							}
							case 1:
								goto end_IL_007a;
							}
							goto IL_012d;
							IL_0076:
							num2 = num4;
							continue;
							end_IL_007a:
							break;
						}
						goto end_IL_0034;
						IL_012d:
						result = (byte)num3 != 0;
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num2 = 1;
						}
						goto IL_007a;
						end_IL_0034:;
					}
					catch (object obj2) when (((Func<bool>)delegate
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
							goto IL_0190;
						}
						ex = obj3;
						num6 = 21;
						goto IL_018c;
						IL_0190:
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
								goto IL_0396;
							case 2:
							case 4:
								{
									result2 = (flag ? 1 : 0);
									goto IL_0396;
								}
								IL_0396:
								return (byte)result2 != 0;
							}
							break;
						}
						goto IL_018c;
						IL_018c:
						num5 = num6;
						goto IL_0190;
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
								goto end_IL_03ca;
							}
							result = false;
							num7 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
							{
								num7 = 1;
							}
							continue;
							end_IL_03ca:
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
					case 0:
						return (jNNihRXMXX).HasExited;
					case 1:
						break;
					}
					goto IL_0041;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0041;
					IL_0041:
					System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref t5YiU4LHQk) != 0, this);
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	public int? ExitCode
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_00da: Expected O, but got I4
			//IL_00d8->IL00d8: Incompatible stack types: I4 vs O
			int num = 1;
			int num4 = default(int);
			int? num3 = default(int?);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
			global::System.Exception ex = default(global::System.Exception);
			int num7 = default(int);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
			bool flag = default(bool);
			global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
			int num10 = default(int);
			int? num9 = default(int?);
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
						int? obj = (jNNihRXMXX).ExitCode;
						goto IL_00d8;
						IL_0070:
						while (true)
						{
							switch (num2)
							{
							default:
								if (num4 == 990)
								{
									num2 = num4;
									continue;
								}
								goto case 2;
							case 2:
								num3 = null;
								num2 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
								{
									num2 = 0;
								}
								continue;
							case 0:
								obj = num3;
								break;
							case 1:
								goto end_IL_0070;
							}
							goto IL_00d8;
							continue;
							end_IL_0070:
							break;
						}
						goto end_IL_0034;
						IL_00d8:
						num3 = obj;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
						{
							num2 = 1;
						}
						goto IL_0070;
						end_IL_0034:;
					}
					catch (object obj2) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj3 = obj2 as global::System.Exception;
						if (obj3 == null)
						{
							num5 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num5 = 6;
							}
						}
						else
						{
							ex = obj3;
							num5 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num5 = 6;
							}
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (num7 != 17)
								{
									if (num7 == 997)
									{
										goto IL_0137;
									}
									goto case 2;
								}
								goto case 0;
							case 7:
								if (ex is NotSupportedException)
								{
									num5 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num5 = 0;
									}
									continue;
								}
								goto case 3;
							case 9:
								if (ex is InvalidOperationException)
								{
									num6 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
									{
										num6 = 17;
									}
									num7 = num6;
									goto IL_0137;
								}
								goto case 7;
							case 0:
							case 8:
								flag = true;
								num5 = 4;
								continue;
							case 3:
								if (!(ex is Win32Exception))
								{
									num5 = 1;
									continue;
								}
								goto case 0;
							case 1:
							case 5:
								flag = false;
								num5 = 2;
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
								IL_0137:
								num5 = num7;
								continue;
							}
							break;
						}
						return (byte)result != 0;
					}).Invoke())
					{
						int num8 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								if (num10 == 990)
								{
									num8 = num10;
									continue;
								}
								goto case 2;
							case 2:
								num3 = num9;
								num8 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
								{
									num8 = 1;
								}
								continue;
							case 0:
								num9 = null;
								num8 = 2;
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
			return num3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal H9xiuWiW89hL8qcyGK8(Process process, int processId, DateTimeOffset startedAtUtc, string expectedExecutablePath, int expectedSessionId)
	{
		U8BimK1NsL = U9WiCL0SxC(expectedExecutablePath);
	}

	[MethodImpl((MethodImplOptions)8)]
	public bool eTFL4ocFi44()
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
					V6YiQ9gLwY();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					break;
				}
				goto IL_0055;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0055;
				IL_0055:
				return (jNNihRXMXX).CloseMainWindow();
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public global::System.Threading.Tasks.Task rwPL4mAFlfT(CancellationToken cancellationToken)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					System.ObjectDisposedException.ThrowIf(System.Threading.Volatile.Read(ref t5YiU4LHQk) != 0, this);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return (jNNihRXMXX).WaitForExitAsync(cancellationToken);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void FWwL47t3QCh()
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					V6YiQ9gLwY();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					(jNNihRXMXX).Kill(true);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	private void V6YiQ9gLwY()
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
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					if (!HasExpectedIdentity)
					{
						num2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return;
				case 0:
					throw new global::System.Exception("官方游戏进程身份不匹配，已拒绝结束该进程");
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string U9WiCL0SxC(string? path)
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
				case 0:
					return System.IO.Path.GetFullPath(path);
				case 1:
					break;
				}
				goto IL_0037;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_0037;
				IL_0037:
				if (!string.IsNullOrWhiteSpace(path))
				{
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				throw new global::System.Exception("官方游戏进程可执行路径无效");
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool AHoi4jxSX8(int expectedProcessId, DateTimeOffset expectedStartedAtUtc, object expectedExecutablePath, int expectedSessionId, int actualProcessId, DateTimeOffset actualStartedAtUtc, string? actualExecutablePath, int actualSessionId)
	{
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		DateTimeOffset val = default(DateTimeOffset);
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
							goto case 1;
						}
						val = (expectedStartedAtUtc).ToUniversalTime();
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						return string.Equals(U9WiCL0SxC((string?)expectedExecutablePath), U9WiCL0SxC(actualExecutablePath), (StringComparison)5);
					case 0:
						if (expectedSessionId == actualSessionId)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_005f;
					case 1:
					{
						long num4 = (val).UtcTicks;
						val = (actualStartedAtUtc).ToUniversalTime();
						if (num4 == (val).UtcTicks)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto IL_005f;
					}
					case 3:
						{
							if (expectedProcessId == actualProcessId)
							{
								break;
							}
							goto IL_005f;
						}
						IL_005f:
						return false;
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
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
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
					goto IL_0021;
				case 2:
					return;
				case 1:
					if (System.Threading.Interlocked.Exchange(ref t5YiU4LHQk, 1) != 0)
					{
						return;
					}
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
					{
						num2 = 7;
					}
					continue;
				case 0:
					break;
				}
				goto IL_006a;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_006a;
				IL_006a:
				(jNNihRXMXX).Dispose();
				num2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
				{
					num2 = 2;
				}
			}
		}
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
							goto case 2;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						num3 = 1;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
			{
				num = 9;
			}
		}
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

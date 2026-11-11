using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using cTpd1lf54YS57isqnyoi;
using fDAldojjppXrctUVYOJn;

namespace Rs63uZnxHUburFBVigD;

internal sealed class EvVW7qnPXZ2qMbTBjim
{
	[CompilerGenerated]
	private int OBFnM4mYUG;

	[CompilerGenerated]
	private int legnpaujG8;

	[CompilerGenerated]
	private long iGtnuhIBx9;

	[CompilerGenerated]
	private int d9rnaLwH9J;

	[CompilerGenerated]
	private string FFQn1l4ZV6;

	internal static object HD0RnXZmJwnCIe88xOpZ;

	public int Version
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return OBFnM4mYUG;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			OBFnM4mYUG = value;
		}
	}

	public int ProcessId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return legnpaujG8;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			legnpaujG8 = value;
		}
	}

	public long ProcessStartedAtUtcTicks
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return iGtnuhIBx9;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			iGtnuhIBx9 = value;
		}
	}

	public int SessionId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return d9rnaLwH9J;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			d9rnaLwH9J = value;
		}
	}

	public string ExecutablePath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return FFQn1l4ZV6;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			FFQn1l4ZV6 = value;
		}
	}

	internal bool IsValid
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string executablePath = ExecutablePath;
			return default(bool);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal bool I31nFa72dY(NYI398f5COw5dgT3xbBV host)
	{
		int num = 6;
		bool result = default(bool);
		global::System.DateTime? startTime = default(global::System.DateTime?);
		int num7 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num8);
		global::System.Exception ex = default(global::System.Exception);
		int num9 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num11 = default(int);
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
						if (host.SessionId >= 0)
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num3 = 5;
							}
							break;
						}
						goto case 7;
					case 5:
						if (IsValid)
						{
							num3 = 3;
							break;
						}
						goto case 7;
					case 4:
						return result;
					case 6:
						System.ArgumentNullException.ThrowIfNull(host, "host");
						num3 = 5;
						break;
					case 3:
						startTime = host.StartTime;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 2;
						}
						break;
					case 1:
						try
						{
							int num4;
							if (ProcessId == host.ProcessId)
							{
								num4 = 1;
								goto IL_0117;
							}
							goto IL_01ee;
							IL_01ef:
							int num5;
							result = (byte)num5 != 0;
							int num6 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
							{
								num6 = 3;
							}
							goto IL_010f;
							IL_0117:
							while (true)
							{
								switch (num4)
								{
								case 1:
									goto IL_0149;
								case 0:
									goto IL_0189;
								case 2:
									goto IL_01be;
								}
								break;
								IL_01be:
								if (SessionId == host.SessionId)
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
									{
										num4 = 5;
									}
									continue;
								}
								goto IL_01ee;
							}
							if (num7 != 10)
							{
								if (num7 == 990)
								{
									goto IL_0113;
								}
								goto IL_0149;
							}
							goto end_IL_00ea;
							IL_0189:
							num5 = (string.Equals(System.IO.Path.GetFullPath(ExecutablePath), System.IO.Path.GetFullPath(host.ExecutablePath), (StringComparison)5) ? 1 : 0);
							goto IL_01ef;
							IL_0113:
							num4 = num7;
							goto IL_0117;
							IL_010f:
							num7 = num6;
							goto IL_0113;
							IL_0149:
							long processStartedAtUtcTicks = ProcessStartedAtUtcTicks;
							global::System.DateTime value = host.StartTime.Value;
							value = (value).ToUniversalTime();
							if (processStartedAtUtcTicks == (value).Ticks)
							{
								num6 = 2;
								goto IL_010f;
							}
							goto IL_01ee;
							IL_01ee:
							num5 = 0;
							goto IL_01ef;
							end_IL_00ea:;
						}
						catch (global::System.Exception obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num8 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
								{
									num8 = 6;
								}
								goto IL_0252;
							}
							ex = obj2;
							num9 = 16;
							goto IL_024e;
							IL_0252:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 != 16)
									{
										if (num9 == 996)
										{
											break;
										}
										goto case 4;
									}
									if (ex is ArgumentException)
									{
										num8 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
										{
											num8 = 0;
										}
										continue;
									}
									goto case 3;
								case 4:
								case 7:
									flag = false;
									num8 = 5;
									continue;
								case 3:
									if (!(ex is NotSupportedException))
									{
										num8 = 8;
										continue;
									}
									goto case 1;
								case 8:
									if (!(ex is PathTooLongException))
									{
										num8 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
										{
											num8 = 15;
										}
										continue;
									}
									goto case 1;
								case 1:
								case 2:
									flag = true;
									num8 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num8 = 0;
									}
									continue;
								case 6:
									result2 = 0;
									goto IL_0390;
								case 0:
								case 5:
									{
										result2 = (flag ? 1 : 0);
										goto IL_0390;
									}
									IL_0390:
									return (byte)result2 != 0;
								}
								break;
							}
							goto IL_024e;
							IL_024e:
							num8 = num9;
							goto IL_0252;
						}).Invoke())
						{
							int num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num10 = 3;
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
									goto end_IL_03c4;
								}
								result = false;
								num10 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
								{
									num10 = 0;
								}
								continue;
								end_IL_03c4:
								break;
							}
						}
						goto case 4;
					case 0:
						if (startTime.HasValue)
						{
							goto end_IL_000c;
						}
						goto case 7;
					case 7:
						return false;
					case 2:
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 1;
						}
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
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static EvVW7qnPXZ2qMbTBjim koBnsqQpmL(object host)
	{
		System.ArgumentNullException.ThrowIfNull(host, "host");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public EvVW7qnPXZ2qMbTBjim()
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
	internal static bool xIUDrTZmQNWJZWlJrmE6()
	{
		return HD0RnXZmJwnCIe88xOpZ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static EvVW7qnPXZ2qMbTBjim d8HUdhZmCHAuYuwU7B2G()
	{
		return (EvVW7qnPXZ2qMbTBjim)HD0RnXZmJwnCIe88xOpZ;
	}
}

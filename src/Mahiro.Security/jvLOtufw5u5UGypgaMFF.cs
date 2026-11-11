using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace wO3EWmfw6peyoPKxQt8p;

public sealed class jvLOtufw5u5UGypgaMFF
{
	internal static object NPAMcT9Xp6U1Dvua77F0;

	[field: CompilerGenerated]
	public string ServiceCode
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string ServiceName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public string Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool Allowed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool IsLifetime
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool EnforcementEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool AdminBypassEnabled
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public bool Bypassed
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public long RemainingSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.DateTime ServerNow
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public global::System.DateTime? ExpiresAt
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string status = Status;
			return null;
		}
	}

	public string ExpiryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.DateTime? expiresAt = ExpiresAt;
			return null;
		}
	}

	public string RemainingText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	public string SummaryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			string text = string.Concat("原到期时间 ", ExpiryText);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private jvLOtufw5u5UGypgaMFF(JsonElement value, string expectedCode)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jvLOtufw5u5UGypgaMFF YZxfwRIsyYJ(JsonElement value, object expectedCode)
	{
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		jvLOtufw5u5UGypgaMFF result = default(jvLOtufw5u5UGypgaMFF);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					result = (jvLOtufw5u5UGypgaMFF)new jvLOtufw5u5UGypgaMFF(value, (string)expectedCode);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
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
						num4 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num4 = 3;
						}
					}
					else
					{
						ex = obj2;
						num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
						{
							num4 = 6;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 16)
							{
								if (num5 == 996)
								{
									goto IL_00c5;
								}
								goto case 1;
							}
							if (ex is OverflowException)
							{
								num4 = 2;
								continue;
							}
							goto case 5;
						case 8:
							if (!(ex is FormatException))
							{
								num5 = 16;
								goto IL_00c5;
							}
							goto case 1;
						case 4:
							flag = false;
							num4 = 6;
							continue;
						case 1:
						case 2:
							flag = true;
							num4 = 7;
							continue;
						case 5:
							if (ex is KeyNotFoundException)
							{
								num4 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							goto case 4;
						case 0:
							if (!(ex is InvalidOperationException))
							{
								num4 = 8;
								continue;
							}
							goto case 1;
						case 3:
							result2 = 0;
							break;
						case 6:
						case 7:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_00c5:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num6 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
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
								goto IL_0229;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0229:
						num6 = num7;
					}
					throw new InvalidOperationException("服务端返回的访问状态无效，请重试。", ex);
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string po0fwwufgVX(long seconds)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		long num = default(long);
		defaultInterpolatedStringHandler.AppendFormatted<long>(System.Math.Max(1L, (long)System.Math.Ceiling((double)num / 60.0)));
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
	internal static bool nucZhc9XuZVDgZHenOIN()
	{
		return NPAMcT9Xp6U1Dvua77F0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static jvLOtufw5u5UGypgaMFF NKQpZH9XaIxYDYxeuJmC()
	{
		return (jvLOtufw5u5UGypgaMFF)NPAMcT9Xp6U1Dvua77F0;
	}
}

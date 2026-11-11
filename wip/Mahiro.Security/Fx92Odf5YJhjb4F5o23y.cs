using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace fJI2ftf5SouLKttbv85L;

public sealed class Fx92Odf5YJhjb4F5o23y : global::System.Exception
{
	private static object cNpSReZibcwt2CxtxWgj;

	[field: CompilerGenerated]
	public int Status
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	[field: CompilerGenerated]
	public int RetryAfterSeconds
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get;
	}

	public bool IsRateLimited
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Status == 429;
		}
	}

	public bool IsNetworkFailure
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return Status == 0;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public Fx92Odf5YJhjb4F5o23y(int status, int retryAfterSeconds, string message)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		if (string.IsNullOrWhiteSpace(message))
		{
			_ = "请求失败";
		}
		else
			(message).Trim();
		int num = 6;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
		{
			num = 0;
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
				return;
			case 1:
				return;
			case 0:
				_Status_k__BackingField = status;
				num = 2;
				break;
			case 2:
				_RetryAfterSeconds_k__BackingField = ((retryAfterSeconds >= 0) ? retryAfterSeconds : 0);
				num = 7;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public Fx92Odf5YJhjb4F5o23y(int status, int retryAfterSeconds, string message, global::System.Exception? innerException)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		if (string.IsNullOrWhiteSpace(message))
		{
			_ = "请求失败";
		}
		else
			(message).Trim();
		int num = 4;
		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
		{
			num = 2;
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
					continue;
				}
				break;
			case 0:
				return;
			case 2:
				_Status_k__BackingField = status;
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
				{
					num = 5;
				}
				continue;
			case 1:
				break;
			}
			_RetryAfterSeconds_k__BackingField = ((retryAfterSeconds >= 0) ? retryAfterSeconds : 0);
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
			{
				num = 0;
			}
		}
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
						{
							num3 = 4;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 2;
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool gEpHmVZiXHJEcPF0muSu()
	{
		return cNpSReZibcwt2CxtxWgj == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Fx92Odf5YJhjb4F5o23y rtA4ElZifd7AQmXJOchI()
	{
		return (Fx92Odf5YJhjb4F5o23y)cNpSReZibcwt2CxtxWgj;
	}
}

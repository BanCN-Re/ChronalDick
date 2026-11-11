using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using vPsLRWXAKouaS91XjEO3;

namespace PTmBhWXAkOqcMFXeoAHn;

internal sealed class M3qr7lXADxIiM3wM1qRy
{
	private static object ksdXAccDPwN;

	private readonly Dictionary<string, string> dwaXA0u4sQd;

	private readonly long JY8XA8eUPeb;

	[CompilerGenerated]
	private readonly W8UV04XAdpTXOmgNYBMi BQfXAy0SxxM;

	[CompilerGenerated]
	private readonly string EZ3XAW2q260;

	[CompilerGenerated]
	private readonly string fdKXAJ0DCwr;

	[CompilerGenerated]
	private readonly string txGXAQwg03a;

	internal static object TdH59wZtnyAyiqK6v6HR;

	internal W8UV04XAdpTXOmgNYBMi Context
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return BQfXAy0SxxM;
		}
	}

	internal string AccessToken
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return EZ3XAW2q260;
		}
	}

	internal string AccountId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return fdKXAJ0DCwr;
		}
	}

	internal string DeviceId
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return txGXAQwg03a;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal M3qr7lXADxIiM3wM1qRy(W8UV04XAdpTXOmgNYBMi context, string accessToken, string accountId, string deviceId, IReadOnlyDictionary<string, string> platformRequestHeaders)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		JY8XA8eUPeb = System.Diagnostics.Stopwatch.GetTimestamp();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe void zdBXAVC3bPg(HttpRequestHeaders headers)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void YbcXAYQdgUf(W8UV04XAdpTXOmgNYBMi context)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
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
						if (num2 == 11)
						{
							throw new global::System.Exception("发烧平台票据请求快照已过期，请重新获取本次平台请求上下文");
						}
						goto end_IL_0010;
					case 0:
						throw new global::System.Exception("发烧平台会话不属于当前经典版账号或登录代次");
					case 3:
						break;
					case 1:
						context.iAVXAHV6MAL();
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
						{
							num3 = 4;
						}
						continue;
					case 2:
						System.ArgumentNullException.ThrowIfNull(context, "context");
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 3;
						}
						continue;
					case 4:
						if (!(Context != context))
						{
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 0;
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
			while (num2 == 992);
			if (!(System.Diagnostics.Stopwatch.GetElapsedTime(JY8XA8eUPeb) > System.TimeSpan.FromSeconds(20.0)))
			{
				break;
			}
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public string ToString()
	{
		return "FeverTicketSession([redacted])";
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void DA2XASRaav1(object? value, int maximumLength)
	{
		int num = 9;
		int num4 = default(int);
		string text = default(string);
		char c = default(char);
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
							goto case 4;
						}
						goto case 6;
					case 6:
						throw new global::System.Exception("发烧平台票据请求缺少有效的平台会话字段");
					case 0:
						num4 = 0;
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
						{
							num3 = 12;
						}
						continue;
					case 11:
					case 12:
						if (num4 < (text).Length)
						{
							num3 = 7;
							continue;
						}
						return;
					case 8:
					case 10:
						throw new global::System.Exception("发烧平台会话字段含非法字符");
					case 13:
						num4++;
						num3 = 11;
						continue;
					case 4:
					case 7:
						c = (text).Chars;
						num = 3;
						break;
					case 3:
						if (c < '!')
						{
							num3 = 8;
							continue;
						}
						goto case 2;
					case 2:
						if (c <= '~')
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								num3 = 13;
							}
							continue;
						}
						goto case 8;
					case 1:
						if ((value).Length <= maximumLength)
						{
							text = (string)value;
							num3 = 20;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 6;
						}
						continue;
					case 9:
						if (string.IsNullOrWhiteSpace((string)value))
						{
							num = 20;
							break;
						}
						goto case 1;
					case 5:
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
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
						if (num2 == 11)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto end_IL_0012;
					case 0:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
						{
							num3 = 9;
						}
						continue;
					case 2:
						ksdXAccDPwN = new object[5]
						{
							(object)"cv",
							(object)"channel",
							(object)"timestamp",
							(object)"region",
							(object)"locale"
						};
						num3 = 3;
						continue;
					case 3:
						return;
					case 1:
						break;
					case 4:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
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
			while (num2 == 992);
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool tE7tGIZtzmRbL1L78Uec()
	{
		return TdH59wZtnyAyiqK6v6HR == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static M3qr7lXADxIiM3wM1qRy crwcHCZObPxiIfwOx9kX()
	{
		return (M3qr7lXADxIiM3wM1qRy)TdH59wZtnyAyiqK6v6HR;
	}
}

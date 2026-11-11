using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;

namespace QJ21CkfSL8itNSePE2uS;

public sealed class v8S9tafSfKHe7BkHpBrA : InvalidOperationException
{
	private static readonly object AlKfSZ9EcZa;

	private static readonly object sKffS9Cco8x;

	[CompilerGenerated]
	private readonly string gL2fSDdtaVr;

	[CompilerGenerated]
	private readonly string vaBfSkAtJWr;

	[CompilerGenerated]
	private readonly string? uvjfSVPEK9U;

	internal static object yPYbUGZMxDah9SsA0pID;

	public string SmsContent
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return gL2fSDdtaVr;
		}
	}

	public string SmsNumber
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return vaBfSkAtJWr;
		}
	}

	public string? BackupNumber
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return uvjfSVPEK9U;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private v8S9tafSfKHe7BkHpBrA(string smsContent, string smsNumber, string? backupNumber)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		_ = "账号触发上行短信安全验证，请按页面提示发送短信后重试登录";
		int num = 2;
		int num2 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (num2 != 10)
				{
					if (num2 != 990)
					{
						break;
					}
					goto IL_0044;
				}
				return;
			case 0:
				vaBfSkAtJWr = smsNumber;
				num = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
				{
					num = 1;
				}
				continue;
			case 2:
				break;
			case 1:
				{
					uvjfSVPEK9U = backupNumber;
					num2 = 10;
					goto IL_0044;
				}
				IL_0044:
				num = num2;
				continue;
			}
			gL2fSDdtaVr = smsContent;
			num = 5;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
			{
				num = 0;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool DhCfSjXshTa(int code, object? rawMessage, out v8S9tafSfKHe7BkHpBrA? challenge)
	{
		int num = 2;
		bool result = default(bool);
		int num6 = default(int);
		Match val = default(Match);
		Match val2 = default(Match);
		int num8 = default(int);
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
							goto case 4;
						}
						goto IL_0546;
					case 0:
						challenge = default;
						return result;
					case 1:
						if (code == 403)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto IL_0546;
					case 4:
						try
						{
							string text = System.Net.WebUtility.HtmlDecode((rawMessage).Substring(0, System.Math.Min((rawMessage).Length, 4096)));
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								int num5;
								switch (num4)
								{
								default:
									if (num6 != 20)
									{
										if (num6 == 1000)
										{
											goto IL_00d7;
										}
										goto case 12;
									}
									goto case 1;
								case 1:
									challenge = (v8S9tafSfKHe7BkHpBrA?)new v8S9tafSfKHe7BkHpBrA((((val).Groups).Item).Value, (((val).Groups).Item).Value, (string?)null);
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
									{
										num4 = 0;
									}
									continue;
								case 6:
									val2 = (AlKfSZ9EcZa).Match(text);
									num4 = 18;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
									{
										num4 = 7;
									}
									continue;
								case 8:
									goto end_IL_00db;
								case 12:
									result = true;
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
									{
										num4 = 8;
									}
									continue;
								case 4:
									goto end_IL_00db;
								case 2:
									if ((val).Success)
									{
										num5 = 15;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
										{
											num5 = 20;
										}
										goto IL_00d3;
									}
									goto case 5;
								case 5:
									result = false;
									num4 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
									{
										num4 = 4;
									}
									continue;
								case 7:
									if ((val2).Success)
									{
										break;
									}
									num5 = 10;
									goto IL_00d3;
								case 3:
								case 10:
									val = (sKffS9Cco8x).Match(text);
									num4 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
									{
										num4 = 11;
									}
									continue;
								case 0:
									result = true;
									num4 = 11;
									continue;
								case 9:
									break;
								case 11:
									goto end_IL_00db;
									IL_00d7:
									num4 = num6;
									continue;
									IL_00d3:
									num6 = num5;
									goto IL_00d7;
								}
								challenge = (v8S9tafSfKHe7BkHpBrA?)new v8S9tafSfKHe7BkHpBrA((((val2).Groups).Item).Value, (((val2).Groups).Item).Value, (((val2).Groups).Item).Success ? (((val2).Groups).Item).Value : null);
								num4 = 12;
								continue;
								end_IL_00db:
								break;
							}
						}
						catch (RegexMatchTimeoutException)
						{
							int num7 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
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
									goto end_IL_048f;
								}
								result = false;
								num7 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
								{
									num7 = 1;
								}
								continue;
								end_IL_048f:
								break;
							}
						}
						goto case 0;
					case 3:
						break;
					case 2:
						{
							challenge = null;
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								num3 = 1;
							}
							continue;
						}
						IL_0546:
						challenge = default;
						return false;
					}
					if (string.IsNullOrWhiteSpace((string)rawMessage))
					{
						goto end_IL_000c;
					}
					num3 = 4;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
			{
				num = 1;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kSnxUBZMFW5W7HUiLcaq()
	{
		return yPYbUGZMxDah9SsA0pID == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static v8S9tafSfKHe7BkHpBrA aS47XoZMsCSmslZPQCDY()
	{
		return (v8S9tafSfKHe7BkHpBrA)yPYbUGZMxDah9SsA0pID;
	}
}

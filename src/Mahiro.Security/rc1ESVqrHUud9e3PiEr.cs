using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace hWvPvOqoGjt2MsShCjO;

public class rc1ESVqrHUud9e3PiEr
{
	private static object wo9jX6ZoYFSEogU78q3m;

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static bool m7bqm7Xjb2(string? value, out string normalized, out string error)
	{
		normalized = default(string);
		error = default(string);
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_028b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		int num4 = default(int);
		bool flag = default(bool);
		StringRuneEnumerator val = default(StringRuneEnumerator);
		StringRuneEnumerator val2 = default(StringRuneEnumerator);
		Rune val3 = default(Rune);
		int num6 = default(int);
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
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_0010;
							}
							goto case 11;
						}
						if (num4 < 2)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
							{
								num3 = 14;
							}
							continue;
						}
						goto case 13;
					case 12:
					case 14:
						flag = true;
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
						{
							num3 = 15;
						}
						continue;
					case 7:
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(18, 2);
						(defaultInterpolatedStringHandler).AppendLiteral("Java 昵称长度需要为 ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(2);
						(defaultInterpolatedStringHandler).AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted<int>(16);
						(defaultInterpolatedStringHandler).AppendLiteral(" 个字符");
						error = (defaultInterpolatedStringHandler).ToStringAndClear();
						num3 = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							num3 = 11;
						}
						continue;
					}
					case 1:
						error = string.Empty;
						num3 = 2;
						continue;
					case 13:
						if (num4 <= 16)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num3 = 10;
							}
							continue;
						}
						goto case 12;
					case 4:
					case 8:
						if (flag)
						{
							num3 = 7;
							continue;
						}
						val = (normalized).EnumerateRunes();
						num3 = 10;
						continue;
					case 5:
						num4 = (new StringInfo(normalized)).LengthInTextElements;
						num = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num = 10;
						}
						break;
					case 11:
						return false;
					case 2:
						return true;
					case 0:
					case 3:
						flag = false;
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num3 = 8;
						}
						continue;
					case 10:
						val2 = (val).GetEnumerator();
						num = 9;
						break;
					case 9:
						try
						{
							while (true)
							{
								int num5;
								if (!(val2).MoveNext())
								{
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num5 = 1;
									}
									goto IL_02be;
								}
								goto IL_03b8;
								IL_03b8:
								val3 = (val2).Current;
								num5 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
								{
									num5 = 6;
								}
								goto IL_02be;
								IL_02be:
								while (true)
								{
									switch (num5)
									{
									case 4:
										return flag;
									default:
										if (num6 != 14)
										{
											if (num6 == 994)
											{
												goto IL_02ba;
											}
											goto case 6;
										}
										error = "Java 昵称只能包含中文、英文字母、数字和下划线";
										num5 = 3;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
										{
											num5 = 9;
										}
										continue;
									case 0:
										break;
									case 2:
										if (System.Text.Rune.IsLetterOrDigit(val3))
										{
											break;
										}
										num6 = 14;
										goto IL_02ba;
									case 3:
										flag = false;
										num5 = 4;
										continue;
									case 5:
										goto IL_03b8;
									case 6:
										if ((val3).Value != 95)
										{
											num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
											{
												num5 = 7;
											}
											continue;
										}
										break;
									case 1:
										goto end_IL_0300;
										IL_02ba:
										num5 = num6;
										continue;
									}
									break;
								}
								continue;
								end_IL_0300:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(val2)/*cast due to .constrained prefix*/).Dispose();
							int num7 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					case 6:
						normalized = ((value != null) ? (value).Trim() : null) ?? string.Empty;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
						{
							num3 = 19;
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

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool VrWkINZoSkkDjymQ6Xu3()
	{
		return wo9jX6ZoYFSEogU78q3m == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rc1ESVqrHUud9e3PiEr Hc2Hx7ZocMmn0POpxAMm()
	{
		return (rc1ESVqrHUud9e3PiEr)wo9jX6ZoYFSEogU78q3m;
	}
}

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
		//IL_0416: Ignored invalid 'constrained' prefix
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f->IL0010: Incompatible stack heights: 4 vs 1
		//IL_015a->IL0010: Incompatible stack heights: 4 vs 1
		int num = 6;
		int num4 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
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
						_ = defaultInterpolatedStringHandler;
						_ = 18;
						(defaultInterpolatedStringHandler).AppendLiteral("Java 昵称长度需要为 ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(2);
						(defaultInterpolatedStringHandler).AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted<int>(16);
						(defaultInterpolatedStringHandler).AppendLiteral(" 个字符");
						global::System.Runtime.CompilerServices.Unsafe.Write((void*)2, (defaultInterpolatedStringHandler).ToStringAndClear());
						_ = 15;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade == 0)
						{
							_ = 11;
						}
						continue;
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
						num4 = (normalized).LengthInTextElements;
						num = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num = 10;
						}
						break;
					case 11:
						error = default;
						normalized = default;
						return false;
					case 2:
						error = default;
						normalized = default;
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
									goto IL_02b6;
								}
								goto IL_03b0;
								IL_03b0:
								val3 = (val2).Current;
								num5 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
								{
									num5 = 6;
								}
								goto IL_02b6;
								IL_02b6:
								while (true)
								{
									switch (num5)
									{
									case 4:
										error = default;
										normalized = default;
										return flag;
									default:
										if (num6 != 14)
										{
											if (num6 == 994)
											{
												goto IL_02b2;
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
										goto IL_02b2;
									case 3:
										flag = false;
										num5 = 4;
										continue;
									case 5:
										goto IL_03b0;
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
										goto end_IL_02f8;
										IL_02b2:
										num5 = num6;
										continue;
									}
									break;
								}
								continue;
								end_IL_02f8:
								break;
							}
						}
						finally
						{
							_ = val2;
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
							return;
						}
						goto end_IL_0012;
					case 0:
						num3 = 2;
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
			{
				num = 9;
			}
		}
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

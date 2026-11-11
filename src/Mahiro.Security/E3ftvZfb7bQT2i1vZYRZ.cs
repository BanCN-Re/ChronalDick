using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace xuiDphfbABsioOFqT68a;

public class E3ftvZfb7bQT2i1vZYRZ
{
	private static object VCxfW9ZsmWbhqfNSLpej;

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static bool h1rfbIdnD6g(string? input, out string nickname, out string error)
	{
		nickname = default(string);
		error = default(string);
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int num4 = default(int);
		StringRuneEnumerator val2 = default(StringRuneEnumerator);
		StringRuneEnumerator val = default(StringRuneEnumerator);
		int num7 = default(int);
		Rune val3 = default(Rune);
		bool result = default(bool);
		int num9 = default(int);
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto IL_03c2;
						}
						if (num4 >= 2)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 1;
					case 1:
					{
						global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(15, 2);
						(defaultInterpolatedStringHandler).AppendLiteral("基岩昵称长度需要为 ");
						defaultInterpolatedStringHandler.AppendFormatted<int>(2);
						(defaultInterpolatedStringHandler).AppendLiteral("-");
						defaultInterpolatedStringHandler.AppendFormatted<int>(16);
						(defaultInterpolatedStringHandler).AppendLiteral(" 个字符");
						error = (defaultInterpolatedStringHandler).ToStringAndClear();
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 6;
						}
						continue;
					}
					case 4:
						break;
					case 7:
						val2 = (val).GetEnumerator();
						num3 = 3;
						continue;
					case 6:
						return false;
					case 2:
						val = (nickname).EnumerateRunes();
						num3 = 7;
						continue;
					case 0:
						return true;
					case 8:
						if (num4 <= 16)
						{
							num3 = 2;
							continue;
						}
						goto case 1;
					case 3:
						try
						{
							while (true)
							{
								IL_02ef:
								int num5;
								if (!(val2).MoveNext())
								{
									num5 = 2;
									goto IL_0210;
								}
								goto IL_0271;
								IL_0210:
								while (true)
								{
									int num6;
									switch (num5)
									{
									default:
										switch (num7)
										{
										case 995:
											break;
										default:
											goto end_IL_02ef;
										case 15:
											error = "基岩昵称只能包含中文、英文字母、数字和下划线";
											num5 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
											{
												num5 = 4;
											}
											continue;
										}
										goto IL_020c;
									case 1:
										if (System.Text.Rune.IsLetterOrDigit(val3))
										{
											num6 = 3;
											goto IL_0208;
										}
										goto case 5;
									case 6:
										break;
									case 3:
									case 4:
										goto IL_02ef;
									case 0:
										result = false;
										num5 = 7;
										continue;
									case 5:
										if ((val3).Value == 95)
										{
											goto IL_02ef;
										}
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
										{
											num6 = 15;
										}
										goto IL_0208;
									case 7:
										goto end_IL_02ef;
									case 2:
										goto IL_03c2;
										IL_0208:
										num7 = num6;
										goto IL_020c;
										IL_020c:
										num5 = num7;
										continue;
									}
									break;
								}
								goto IL_0271;
								IL_0271:
								val3 = (val2).Current;
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
								{
									num5 = 5;
								}
								goto IL_0210;
								continue;
								end_IL_02ef:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(val2)/*cast due to .constrained prefix*/).Dispose();
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
							{
								num8 = 6;
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
						return result;
					case 9:
						goto IL_03c2;
					case 5:
						{
							nickname = ((input != null) ? (input).Trim() : null) ?? string.Empty;
							num3 = 4;
							continue;
						}
						IL_03c2:
						error = string.Empty;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
						{
							num3 = 4;
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
			num4 = (new StringInfo(nickname)).LengthInTextElements;
			num = 16;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
			{
				num = 13;
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
	internal static bool d5GBv8Zs7uloXntMmIPa()
	{
		return VCxfW9ZsmWbhqfNSLpej == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static E3ftvZfb7bQT2i1vZYRZ Id9LlSZsAItFqR0Rt3Ue()
	{
		return (E3ftvZfb7bQT2i1vZYRZ)VCxfW9ZsmWbhqfNSLpej;
	}
}

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace KBx9lafY6LvYfHSvsVm4;

internal class RjJcojfY55sN0GqYZJag
{
	private static object L4CxiYZMH0t46VN31wys;

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern uint GetShortPathNameW(string longPath, StringBuilder shortPathBuffer, uint shortPathBufferLength);

	[MethodImpl((MethodImplOptions)8)]
	internal static string ToAsciiPath(object path)
	{
		int num = 3;
		string text = default(string);
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
								goto end_IL_000d;
							}
							goto case 1;
						}
						if (!IsAsciiPath(path))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 4;
					case 3:
						if (!string.IsNullOrWhiteSpace((string)path))
						{
							break;
						}
						goto case 4;
					case 1:
						if (text != null)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
							{
								num3 = 2;
							}
							continue;
						}
						return (string)path;
					case 4:
						return (string)path;
					case 0:
						text = TryGetShortPath(path);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						return text;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 7;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? TryGetShortPath(object path)
	{
		//IL_0039: Expected O, but got I4
		int num = 1;
		int num4 = default(int);
		string result = default(string);
		string text = default(string);
		uint shortPathNameW = default(uint);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					StringBuilder val = (StringBuilder)(object)32768;
					int num2 = 11;
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							if (num4 != 24)
							{
								if (num4 != 1004)
								{
									break;
								}
								goto IL_0051;
							}
							goto case 5;
						case 1:
						case 7:
							result = null;
							num2 = 15;
							continue;
						case 16:
							break;
						case 4:
							if (!ContainsNonAsciiSegment(text))
							{
								num2 = 9;
								continue;
							}
							goto case 5;
						case 10:
							if (shortPathNameW <= 32767)
							{
								num2 = 3;
								continue;
							}
							goto case 1;
						case 0:
						case 3:
							text = (val).ToString(0, (int)shortPathNameW);
							num2 = 6;
							continue;
						case 6:
							if (string.IsNullOrWhiteSpace(text))
							{
								num2 = 5;
								continue;
							}
							goto case 13;
						case 11:
							shortPathNameW = GetShortPathNameW((string)path, val, (uint)(val).Capacity);
							num2 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
							{
								num2 = 8;
							}
							continue;
						case 15:
							break;
						case 5:
						case 12:
							result = null;
							num3 = 16;
							goto IL_004d;
						case 9:
						case 14:
							result = text;
							num2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num2 = 10;
							}
							continue;
						case 8:
							if (shortPathNameW == 0)
							{
								num2 = 7;
								continue;
							}
							goto case 10;
						case 13:
							if (!System.IO.Path.IsPathFullyQualified(text))
							{
								num3 = 24;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num3 = 8;
								}
								goto IL_004d;
							}
							goto case 4;
						case 2:
							break;
							IL_004d:
							num4 = num3;
							goto IL_0051;
							IL_0051:
							num2 = num4;
							continue;
						}
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num5 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 989)
							{
								num5 = num6;
								continue;
							}
							break;
						case 1:
							result = null;
							num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
							{
								num5 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool IsAsciiPath(object value)
	{
		int num = 3;
		string text = default(string);
		int num4 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_000d;
							}
							goto case 1;
						}
						return true;
					case 5:
						return false;
					case 0:
						if ((text).Chars <= '\u007f')
						{
							num4++;
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 1;
							}
						}
						else
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
							{
								num3 = 5;
							}
						}
						continue;
					case 2:
						num4 = 0;
						num3 = 4;
						continue;
					case 3:
						text = (string)value;
						num3 = 2;
						continue;
					case 1:
					case 4:
						if (num4 >= (text).Length)
						{
							break;
						}
						goto case 0;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ContainsNonAsciiSegment(object path)
	{
		int num = default(int);
		char c = (path).Chars;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsAsciiSpan(global::System.ReadOnlySpan<char> value)
	{
		int num = 5;
		return default(bool);
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
					case 0:
						return;
					case 1:
						goto end_IL_000e;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
						{
							num3 = 7;
						}
						continue;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
						{
							num3 = 7;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool mRryIQZMtAE8kJRPER63()
	{
		return L4CxiYZMH0t46VN31wys == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RjJcojfY55sN0GqYZJag D809n7ZMORo0A2PFbZG0()
	{
		return (RjJcojfY55sN0GqYZJag)L4CxiYZMH0t46VN31wys;
	}
}

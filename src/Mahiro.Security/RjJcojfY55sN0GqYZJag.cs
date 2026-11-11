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
		string text = TryGetShortPath(path);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string? TryGetShortPath(object path)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
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
					StringBuilder val = new StringBuilder(32768);
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
								goto IL_0055;
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
							goto IL_0051;
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
								goto IL_0051;
							}
							goto case 4;
						case 2:
							break;
							IL_0051:
							num4 = num3;
							goto IL_0055;
							IL_0055:
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
		int num = 0;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ContainsNonAsciiSegment(object path)
	{
		int num = default(int);
		char c = ((dynamic)(path)).Chars;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsAsciiSpan(global::System.ReadOnlySpan<char> value)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

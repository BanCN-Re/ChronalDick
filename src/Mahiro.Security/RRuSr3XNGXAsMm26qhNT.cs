using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace txc8P9XNi3iI0577TRl4;

public class RRuSr3XNGXAsMm26qhNT
{
	internal static object Nb6ZIcZwuOoMLP4uvI2r;

	[MethodImpl((MethodImplOptions)8)]
	public static string ReLXNnF0jBZ(object executablePath, object buildCode)
	{
		int num = 1;
		int num3 = default(int);
		string result = default(string);
		string text = default(string);
		int num6 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					FileVersionInfo val = System.Diagnostics.FileVersionInfo.GetVersionInfo((string)executablePath);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num2 = 8;
					}
					while (true)
					{
						string text2;
						int num4;
						switch (num2)
						{
						default:
							switch (num3)
							{
							case 13:
								return result;
							case 993:
								break;
							default:
								goto end_IL_0079;
							}
							goto IL_0075;
						case 5:
							goto end_IL_0079;
						case 3:
							text2 = (val).ProductVersion;
							break;
						case 1:
							if (!string.IsNullOrWhiteSpace((val).ProductVersion))
							{
								num4 = 3;
								goto IL_0071;
							}
							text2 = (val).FileVersion;
							break;
						case 2:
							result = (text).Trim();
							num4 = 13;
							goto IL_0071;
						case 4:
							if (string.IsNullOrWhiteSpace(text))
							{
								num2 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto case 2;
						case 0:
							goto end_IL_0079;
							IL_0075:
							num2 = num3;
							continue;
							IL_0071:
							num3 = num4;
							goto IL_0075;
						}
						text = text2;
						num2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num2 = 3;
						}
						continue;
						end_IL_0079:
						break;
					}
				}
				catch (global::System.Exception)
				{
					int num5 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 == 988)
							{
								num5 = num6;
								continue;
							}
							break;
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
		return xnLXNzQmVqa(buildCode);
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string xnLXNzQmVqa(object buildCode)
	{
		string[] array = ((dynamic)(buildCode)).Split('_', (StringSplitOptions)1);
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
	internal static bool zEv8JjZwaV5cyxO6qEJv()
	{
		return Nb6ZIcZwuOoMLP4uvI2r == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static RRuSr3XNGXAsMm26qhNT tEcW3VZw149MEJYmrFG2()
	{
		return (RRuSr3XNGXAsMm26qhNT)Nb6ZIcZwuOoMLP4uvI2r;
	}
}

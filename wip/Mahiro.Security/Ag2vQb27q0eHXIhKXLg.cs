using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using c2D37HfsFbaPpJo3F98A;
using fDAldojjppXrctUVYOJn;
using gRbRfCXDGNq0RQfsTO53;

namespace Qv5ats2AjPI5TeC323L;

internal class Ag2vQb27q0eHXIhKXLg
{
	private static object WZJ2lZ0nro;

	private static object GHRxcYZrv3AKWUqTli2w;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Collections.Generic.IReadOnlyList<string> R962IxMBG0(object sourceDirectory, object destinationDirectory, bool overwrite = true)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void xCh2BYmZC1(object paths, object version, object nativeDirectory)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		uKGDFFfsxYJUyNmtk1xA uKGDFFfsxYJUyNmtk1xA = default(uKGDFFfsxYJUyNmtk1xA);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num4 = default(int);
		string text2 = default(string);
		string text = default(string);
		int num6 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					uKGDFFfsxYJUyNmtk1xA = Q0byV3XDqBkO3fA2vDnD.Ky1XDiBEWHb(version, System.Runtime.InteropServices.RuntimeInformation.OSArchitecture);
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					try
					{
						while (true)
						{
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 2;
								goto IL_00a0;
							}
							goto IL_0131;
							IL_00a0:
							while (true)
							{
								switch (num3)
								{
								case 0:
									goto end_IL_00a0;
								case 1:
									goto IL_0131;
								case 2:
									return;
								}
								switch (num4)
								{
								case 990:
									break;
								default:
									goto end_IL_00a0;
								case 10:
									goto IL_00ed;
								}
								goto IL_009c;
								IL_00ed:
								System.IO.File.Copy(text2, System.IO.Path.Combine(text, System.IO.Path.GetFileName(text2)), true);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
								{
									num3 = 4;
								}
								continue;
								end_IL_00a0:
								break;
							}
							continue;
							IL_0131:
							text2 = (string)enumerator;
							num4 = 10;
							goto IL_009c;
							IL_009c:
							num3 = num4;
							goto IL_00a0;
						}
					}
					finally
					{
						int num5;
						if (enumerator == null)
						{
							num5 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								num5 = 8;
							}
							goto IL_017d;
						}
						goto IL_01a1;
						IL_017d:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_0179;
								}
								break;
							case 2:
								break;
							case 0:
								goto end_IL_017d;
							case 1:
								goto end_IL_017d;
							}
							goto IL_01a1;
							IL_0179:
							num5 = num6;
							continue;
							end_IL_017d:
							break;
						}
						goto end_IL_0145;
						IL_01a1:
						(enumerator).Dispose();
						num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							num5 = 3;
						}
						goto IL_017d;
						end_IL_0145:;
					}
				case 1:
				{
					string sourceDirectory = System.IO.Path.Combine(((bnHA9vxvBiUJqO7FLm4)paths).GameBasePath, uKGDFFfsxYJUyNmtk1xA.DirectoryName, "bin");
					text = System.IO.Path.Combine((string)nativeDirectory, "runtime");
					System.IO.Directory.CreateDirectory(text);
					enumerator = (global::System.Collections.Generic.IEnumerator<string>)R962IxMBG0(sourceDirectory, nativeDirectory, overwrite: false);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 3:
					return;
				}
				break;
			}
		}
		while (num == 991);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool oSS2giNaxC(object fileName)
	{
		int num = 4;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 4;
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
						goto end_IL_000e;
					case 2:
						return;
					case 1:
						WZJ2lZ0nro = new object[9]
						{
							(object)"ucrtbase.dll",
							(object)"msvcp100.dll",
							(object)"msvcr100.dll",
							(object)"msvcp120.dll",
							(object)"msvcr120.dll",
							(object)"msvcp140.dll",
							(object)"vcruntime140.dll",
							(object)"vcruntime140_1.dll",
							(object)"concrt140.dll"
						};
						num3 = 2;
						continue;
					case 3:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						num3 = 3;
						continue;
					}
					switch (num2)
					{
					case 992:
						break;
					default:
						return;
					case 11:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
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
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool GijNF1ZrEKhYbcSuJkLO()
	{
		return GHRxcYZrv3AKWUqTli2w == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Ag2vQb27q0eHXIhKXLg YwTRJvZr232E2VL0DIvp()
	{
		return (Ag2vQb27q0eHXIhKXLg)GHRxcYZrv3AKWUqTli2w;
	}
}

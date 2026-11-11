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
	private static readonly object WZJ2lZ0nro;

	private static object GHRxcYZrv3AKWUqTli2w;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Collections.Generic.IReadOnlyList<string> R962IxMBG0(object sourceDirectory, object destinationDirectory, bool overwrite = true)
	{
		int num = 3;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num6 = default(int);
		string current = default(string);
		List<string> val = default(List<string>);
		string text2 = default(string);
		string text = default(string);
		int num8 = default(int);
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
						if (num2 == 12)
						{
							enumerator = System.IO.Directory.EnumerateFiles((string)sourceDirectory, "*.dll", (SearchOption)0).GetEnumerator();
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto end_IL_0010;
					case 1:
						try
						{
							while (true)
							{
								IL_01b5:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
									{
										num4 = 2;
									}
									goto IL_00bd;
								}
								goto IL_01e5;
								IL_0241:
								int num5 = 8;
								goto IL_00b5;
								IL_00f8:
								if (num6 != 997)
								{
									break;
								}
								goto IL_00b9;
								IL_01e5:
								current = enumerator.Current;
								num5 = 9;
								goto IL_00b5;
								IL_00b5:
								num6 = num5;
								goto IL_00b9;
								IL_00b9:
								num4 = num6;
								goto IL_00bd;
								IL_00bd:
								while (true)
								{
									switch (num4)
									{
									case 7:
										val.Add(text2);
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
										{
											num4 = 0;
										}
										continue;
									case 1:
										text2 = System.IO.Path.Combine((string)destinationDirectory, text);
										num4 = 8;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
										{
											num4 = 4;
										}
										continue;
									case 8:
										goto end_IL_00bd;
									case 0:
									case 3:
										goto IL_01b5;
									case 6:
										goto IL_01e5;
									case 9:
										text = System.IO.Path.GetFileName(current);
										num4 = 5;
										continue;
									case 5:
										if (!oSS2giNaxC(text))
										{
											num4 = 3;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
											{
												num4 = 10;
											}
											continue;
										}
										goto case 1;
									case 4:
										goto IL_023b;
									case 2:
										goto end_IL_01b5;
									}
									if (num6 != 17)
									{
										goto IL_00f8;
									}
									goto IL_024b;
									IL_023b:
									if (!overwrite)
									{
										goto IL_0241;
									}
									goto IL_024b;
									IL_024b:
									System.IO.File.Copy(current, text2, true);
									num4 = 7;
									continue;
									end_IL_00bd:
									break;
								}
								if (System.IO.File.Exists(text2))
								{
									continue;
								}
								num5 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
								{
									num5 = 17;
								}
								goto IL_00b5;
								continue;
								end_IL_01b5:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
								{
									num7 = 2;
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
									case 1:
										(enumerator).Dispose();
										num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
										{
											num7 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 0;
					case 5:
						break;
					case 4:
						return global::System.Array.Empty<string>();
					case 2:
						System.IO.Directory.CreateDirectory((string)destinationDirectory);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num3 = 7;
						}
						continue;
					case 0:
						return (global::System.Collections.Generic.IReadOnlyList<string>)val;
					case 3:
						if (System.IO.Directory.Exists((string)sourceDirectory))
						{
							num3 = 2;
							continue;
						}
						goto case 4;
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
			while (num2 == 993);
			val = new List<string>();
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
			{
				num = 12;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void xCh2BYmZC1(object paths, object version, object nativeDirectory)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		uKGDFFfsxYJUyNmtk1xA uKGDFFfsxYJUyNmtk1xA = default(uKGDFFfsxYJUyNmtk1xA);
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num4 = default(int);
		string current = default(string);
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
								System.IO.File.Copy(current, System.IO.Path.Combine(text, System.IO.Path.GetFileName(current)), true);
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
							current = enumerator.Current;
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
							goto IL_0181;
						}
						goto IL_01a5;
						IL_0181:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 990)
								{
									goto IL_017d;
								}
								break;
							case 2:
								break;
							case 0:
								goto end_IL_0181;
							case 1:
								goto end_IL_0181;
							}
							goto IL_01a5;
							IL_017d:
							num5 = num6;
							continue;
							end_IL_0181:
							break;
						}
						goto end_IL_0149;
						IL_01a5:
						(enumerator).Dispose();
						num5 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							num5 = 3;
						}
						goto IL_0181;
						end_IL_0149:;
					}
				case 1:
				{
					string sourceDirectory = System.IO.Path.Combine(((bnHA9vxvBiUJqO7FLm4)paths).GameBasePath, uKGDFFfsxYJUyNmtk1xA.DirectoryName, "bin");
					text = System.IO.Path.Combine((string)nativeDirectory, "runtime");
					System.IO.Directory.CreateDirectory(text);
					enumerator = ((global::System.Collections.Generic.IEnumerable<string>)R962IxMBG0(sourceDirectory, nativeDirectory, overwrite: false)).GetEnumerator();
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

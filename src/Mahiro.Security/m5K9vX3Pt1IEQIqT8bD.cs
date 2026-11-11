using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using fDAldojjppXrctUVYOJn;

namespace Ydk9BK3x5DN9UdFvoyx;

sealed class m5K9vX3Pt1IEQIqT8bD : global::System.IDisposable
{
	private string? ooB3NlpnXi;

	internal static object Yoby37ZrbkwPkHmDOXyp;

	internal string Path
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 1;
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private m5K9vX3Pt1IEQIqT8bD(string path)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static m5K9vX3Pt1IEQIqT8bD k3y3FErNvP(object paths, object instanceId)
	{
		string text = System.IO.Path.GetFullPath(System.IO.Path.Combine(((bnHA9vxvBiUJqO7FLm4)paths).CachePath, "Instances"));
		string target = System.IO.Path.GetFullPath(System.IO.Path.Combine(text, (string)instanceId));
		MEH3Tex5U1(text, target);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool KFo3sShTjw(object root, object target)
	{
		int num = 2;
		bool result = default(bool);
		string text = default(string);
		int num4 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Exception ex = default(global::System.Exception);
		int num7 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num9 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					return result;
				case 2:
				{
					string root2 = System.IO.Path.GetFullPath((string)root);
					text = System.IO.Path.GetFullPath((string)target);
					MEH3Tex5U1(root2, text);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
					{
						num2 = 1;
					}
					break;
				}
				case 1:
					try
					{
						int num3;
						if (!System.IO.Directory.Exists(text))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								num3 = 0;
							}
							goto IL_00b8;
						}
						goto IL_013a;
						IL_00b8:
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 11)
								{
									if (num4 == 991)
									{
										goto IL_00b4;
									}
									goto case 0;
								}
								goto end_IL_00b8;
							case 1:
								result = !System.IO.Directory.Exists(text);
								num3 = 3;
								continue;
							case 0:
							{
								result = true;
								int num5 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
								{
									num5 = 8;
								}
								num4 = num5;
								goto IL_00b4;
							}
							case 2:
								break;
							case 3:
								goto end_IL_00b8;
								IL_00b4:
								num3 = num4;
								continue;
							}
							goto IL_013a;
							continue;
							end_IL_00b8:
							break;
						}
						goto end_IL_0076;
						IL_013a:
						System.IO.Directory.Delete(text, true);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
						{
							num3 = 1;
						}
						goto IL_00b8;
						end_IL_0076:;
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num6 = 5;
						}
						else
						{
							ex = obj2;
							num6 = 3;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 != 13)
								{
									if (num7 == 993)
									{
										goto IL_0194;
									}
									goto case 0;
								}
								goto case 1;
							case 3:
								if (!(ex is IOException))
								{
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f == 0)
									{
										num6 = 12;
									}
									continue;
								}
								goto case 4;
							case 0:
								if (ex is UnauthorizedAccessException)
								{
									num6 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
									{
										num6 = 4;
									}
									continue;
								}
								goto case 2;
							case 2:
								flag = false;
								num6 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num6 = 1;
								}
								continue;
							case 4:
								flag = true;
								num7 = 13;
								goto IL_0194;
							case 5:
								result2 = 0;
								break;
							case 1:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0194:
								num6 = num7;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num8 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
						{
							num8 = 7;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 == 989)
								{
									num8 = num9;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_02b5;
							}
							result = false;
							num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
							{
								num8 = 1;
							}
							continue;
							end_IL_02b5:
							break;
						}
					}
					goto case 0;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void MEH3Tex5U1(object root, object target)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		string text2 = default(string);
		string text = System.IO.Path.GetDirectoryName(text2);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Kg5ciWZrXX1n3AnETwGs()
	{
		return Yoby37ZrbkwPkHmDOXyp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static m5K9vX3Pt1IEQIqT8bD DgteODZrfL30g5pnY1Qk()
	{
		return (m5K9vX3Pt1IEQIqT8bD)Yoby37ZrbkwPkHmDOXyp;
	}
}

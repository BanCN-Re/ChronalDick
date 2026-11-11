using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace RkEBBcxE6uQHIJCVGy1;

public sealed class bnHA9vxvBiUJqO7FLm4
{
	[CompilerGenerated]
	private readonly string y57Ffd26f4;

	internal static object DhEdlhZ4QbXbbBNU6WYh;

	public string RootPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return y57Ffd26f4;
		}
	}

	public string GameBasePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "GameBase");
		}
	}

	public string MinecraftPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(GameBasePath, ".minecraft");
		}
	}

	public string DownloadsPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Downloads");
		}
	}

	public string CachePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Cache");
		}
	}

	public string AuthenticationCachePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(CachePath, "Authentication");
		}
	}

	public string SkinCachePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(CachePath, "Skins");
		}
	}

	public string InstallStatePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(CachePath, "InstallState");
		}
	}

	public string InstallWorkspacePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(CachePath, "InstallWorkspace");
		}
	}

	public string RuntimePath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Runtime");
		}
	}

	public string ConfigurationPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(RootPath, "Configuration");
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public bnHA9vxvBiUJqO7FLm4(string? rootPath = null)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	public void VVhx2N5JK6()
	{
		//IL_000c: Expected O, but got I4
		//IL_003d: Expected I4, but got O
		//IL_00ce->IL0010: Incompatible stack types: I4 vs O
		//IL_0179->IL0010: Incompatible stack types: I4 vs O
		//IL_00fe->IL0010: Incompatible stack types: I4 vs O
		//IL_01df->IL0010: Incompatible stack types: I4 vs O
		//IL_012e->IL0010: Incompatible stack types: I4 vs O
		//IL_019f->IL0010: Incompatible stack types: I4 vs O
		//IL_0083->IL0010: Incompatible stack types: I4 vs O
		//IL_00d9->IL0010: Incompatible stack types: I4 vs O
		//IL_0184->IL0010: Incompatible stack types: I4 vs O
		//IL_0109->IL0010: Incompatible stack types: I4 vs O
		//IL_01ea->IL0010: Incompatible stack types: I4 vs O
		//IL_0139->IL0010: Incompatible stack types: I4 vs O
		//IL_008e->IL0010: Incompatible stack types: I4 vs O
		//IL_00a9->IL0010: Incompatible stack types: I4 vs O
		int num = 3;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 16)
						{
							if ((nint)obj == 997)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						System.IO.Directory.CreateDirectory(GameBasePath);
						obj2 = 9;
						continue;
					case 9:
						System.IO.Directory.CreateDirectory(DownloadsPath);
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
						{
							obj2 = 16;
						}
						continue;
					case 1:
						System.IO.Directory.CreateDirectory(RuntimePath);
						obj2 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							obj2 = 5;
						}
						continue;
					case 4:
						System.IO.Directory.CreateDirectory(InstallWorkspacePath);
						obj2 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 6:
						System.IO.Directory.CreateDirectory(CachePath);
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
						{
							obj2 = 15;
						}
						continue;
					case 3:
						System.IO.Directory.CreateDirectory(RootPath);
						num = 16;
						break;
					case 2:
						System.IO.Directory.CreateDirectory(SkinCachePath);
						obj2 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e != 0)
						{
							obj2 = 11;
						}
						continue;
					case 8:
						System.IO.Directory.CreateDirectory(InstallStatePath);
						obj2 = 4;
						continue;
					case 0:
						System.IO.Directory.CreateDirectory(AuthenticationCachePath);
						num = 2;
						break;
					case 5:
						System.IO.Directory.CreateDirectory(ConfigurationPath);
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							obj2 = 7;
						}
						continue;
					case 7:
						return;
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
	public string WRxxqoBZht(string userId, string serverId, string launcherVersion, string gameVersion)
	{
		return System.IO.Path.Combine((string[])new object[5]
		{
			(object)AuthenticationCachePath,
			(object)Gq9FbYZUXB(launcherVersion),
			(object)Gq9FbYZUXB(gameVersion),
			(object)Gq9FbYZUXB(userId),
			(object)Gq9FbYZUXB(serverId)
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	public string gZixGLA5Jd(string skinId)
	{
		return System.IO.Path.Combine(SkinCachePath, string.Concat(Gq9FbYZUXB(skinId), ".png"));
	}

	[MethodImpl((MethodImplOptions)8)]
	public static string h0gxif60bI()
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_00a9: Expected O, but got I4
		//IL_00e4: Expected O, but got I4
		//IL_0101: Expected I4, but got O
		//IL_004f->IL0010: Incompatible stack types: I4 vs O
		//IL_00d3->IL00e8: Incompatible stack types: I4 vs O
		//IL_005a->IL0010: Incompatible stack types: I4 vs O
		//IL_00de->IL00e8: Incompatible stack types: I4 vs O
		//IL_019a->IL00e8: Incompatible stack types: I4 vs O
		//IL_01a5->IL00e8: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj3 = default(object);
		object obj6 = default(object);
		object result = default(object);
		object obj5 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					obj3 = pHNxz509s5();
					obj2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
					{
						obj2 = 0;
					}
					continue;
				case 2:
					break;
				case 0:
				{
					if (!System.IO.File.Exists((string)obj3))
					{
						break;
					}
					object obj4 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
					{
						obj4 = 10;
					}
					while (true)
					{
						int num;
						switch ((int)obj4)
						{
						case 2:
						case 4:
							break;
						default:
							if ((nint)obj6 == 12)
							{
								return (string)result;
							}
							if ((nint)obj6 != 992)
							{
								break;
							}
							goto IL_00e4;
						case 1:
							result = obj5;
							num = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num = 10;
							}
							goto IL_00e0;
						case 0:
							if (string.IsNullOrWhiteSpace((string)obj5))
							{
								num = 2;
								goto IL_00e0;
							}
							goto case 1;
						case 3:
							{
								obj5 = (System.IO.File.ReadAllText((string)obj3)).Trim();
								obj4 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
								{
									obj4 = 0;
								}
								continue;
							}
							IL_00e0:
							obj6 = num;
							goto IL_00e4;
							IL_00e4:
							obj4 = obj6;
							continue;
						}
						break;
					}
					break;
				}
				}
				return System.IO.Path.Combine((string)28, "Chronal", "Java");
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static void sEZxnjRLUp(object rootPath)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_005e: Expected O, but got I4
		//IL_0072->IL0010: Incompatible stack types: I4 vs O
		//IL_009e->IL0010: Incompatible stack types: I4 vs O
		//IL_007d->IL0010: Incompatible stack types: I4 vs O
		//IL_00a9->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		object obj3 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					return;
				case 1:
				{
					string text = pHNxz509s5();
					System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(text));
					System.IO.File.WriteAllText(text, (string)obj3, (Encoding)(object)0);
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				case 2:
					obj3 = System.IO.Path.GetFullPath((string)rootPath);
					obj2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
					{
						obj2 = 6;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string pHNxz509s5()
	{
		//IL_004c: Expected O, but got I4
		return System.IO.Path.Combine((string)28, "Chronal", "java-root.txt");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Gq9FbYZUXB(object value)
	{
		//IL_000c: Expected O, but got I4
		//IL_005d: Expected I4, but got O
		//IL_0148: Expected O, but got I8
		//IL_00bb: Expected I4, but got O
		//IL_0171: Expected O, but got I4
		//IL_0295: Expected O, but got I4
		//IL_0243: Expected O, but got I4
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_015c->IL0010: Incompatible stack types: I4 vs O
		//IL_01ef->IL0010: Incompatible stack types: I4 vs O
		//IL_00c7->IL0010: Incompatible stack types: I4 vs O
		//IL_0185->IL0010: Incompatible stack types: I4 vs O
		//IL_024d->IL0010: Incompatible stack types: I4 vs O
		//IL_00d7->IL0010: Incompatible stack types: I4 vs O
		//IL_0136->IL0010: Incompatible stack types: I4 vs O
		//IL_02d8->IL0010: Incompatible stack types: I4 vs O
		//IL_0167->IL0010: Incompatible stack types: I4 vs O
		//IL_0099->IL0010: Incompatible stack types: I4 vs O
		//IL_0235->IL0010: Incompatible stack types: I4 vs O
		//IL_02b4->IL0010: Incompatible stack types: I4 vs O
		//IL_01d2->IL0010: Incompatible stack types: I4 vs O
		//IL_0190->IL0010: Incompatible stack types: I4 vs O
		//IL_0141->IL0010: Incompatible stack types: I4 vs O
		//IL_02e3->IL0010: Incompatible stack types: I4 vs O
		//IL_00a4->IL0010: Incompatible stack types: I4 vs O
		//IL_0240->IL0010: Incompatible stack types: I4 vs O
		int num = 2;
		object obj4 = default(object);
		object obj3 = default(object);
		object obj7 = default(object);
		object obj5 = default(object);
		object obj6 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 24)
						{
							if ((nint)obj == 1005)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						goto case 4;
					case 4:
						if (obj4 != null)
						{
							obj2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								obj2 = 15;
							}
							continue;
						}
						goto case 17;
					case 7:
						obj3 = (obj3).Replace((char)(int)obj7, '_');
						obj2 = 16;
						continue;
					case 16:
						obj5++;
						obj2 = 8;
						continue;
					case 12:
						_ = "认证缓存路径字段不能为空";
						throw new global::System.Exception("value");
					case 1:
						obj3 = (value).Trim();
						obj2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
						{
							obj2 = 10;
						}
						continue;
					case 3:
					case 10:
						obj7 = ((long[])obj6)[obj5];
						obj2 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
						{
							obj2 = 5;
						}
						continue;
					case 11:
						obj5 = 0;
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
						{
							obj2 = 12;
						}
						continue;
					case 9:
						if (((string)obj3 == ".."))
						{
							obj2 = 13;
							continue;
						}
						goto case 14;
					case 6:
						obj6 = System.IO.Path.GetInvalidFileNameChars();
						obj2 = 11;
						continue;
					case 5:
						if (!((string)obj3 == "."))
						{
							obj2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
							{
								obj2 = 9;
							}
							continue;
						}
						break;
					case 14:
						obj4 = 0;
						obj2 = 4;
						continue;
					case 17:
						return (string)obj3;
					case 15:
						return string.Concat("_", (obj3).Replace('.', '_'));
					case 13:
						break;
					case 0:
					case 8:
						if ((nint)obj5 < ((global::System.Array)obj6).Length)
						{
							obj2 = 10;
							continue;
						}
						goto case 5;
					case 2:
						if (!string.IsNullOrWhiteSpace((string)value))
						{
							obj2 = 15;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 12;
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
			obj4 = 1;
			num = 24;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0081->IL0012: Incompatible stack types: I4 vs O
		//IL_008c->IL0012: Incompatible stack types: I4 vs O
		//IL_00a5->IL0012: Incompatible stack types: I4 vs O
		//IL_00b0->IL0012: Incompatible stack types: I4 vs O
		int num = 1;
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							obj2 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
							{
								obj2 = 2;
							}
							continue;
						}
						goto end_IL_0012;
					case 0:
						break;
					case 1:
						obj2 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
						{
							obj2 = 0;
						}
						continue;
					case 2:
						return;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				if ((nint)obj != 990)
				{
					return;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PSplP4Z4CtH6JOfGjCRB()
	{
		return DhEdlhZ4QbXbbBNU6WYh == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bnHA9vxvBiUJqO7FLm4 EgdeGEZ44YQWVPXylqHu()
	{
		return (bnHA9vxvBiUJqO7FLm4)DhEdlhZ4QbXbbBNU6WYh;
	}
}

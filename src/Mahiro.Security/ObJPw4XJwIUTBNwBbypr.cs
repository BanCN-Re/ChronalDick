using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using OtrSMlXQ0hqVyriWYgnh;
using PYtrATXQkleGY8Irsp8C;
using fDAldojjppXrctUVYOJn;
using kRfpLkXQLHMfO1jprRLW;

namespace kKgU7oXJe2vOmDo3xdOV;

internal class ObJPw4XJwIUTBNwBbypr
{
	private static object Rx9M4eZdhsUrAwriSIkr;

	[MethodImpl((MethodImplOptions)8)]
	internal static string R0RXJPUeAyp(object directory)
	{
		string[] array = new string[6]
		{
			"jli.dll",
			"jli_real.dll",
			"jli.chronal-original.dll",
			"chronal-runtime-profile.json",
			"java.exe",
			"javaw.exe"
		};
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void fuIXJxKucmq(object path)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				return;
			}
			try
			{
				if (!(System.IO.File.GetAttributes((string)path)).HasFlag((global::System.Enum)(object)(FileAttributes)1024))
				{
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						default:
							if (num3 == 989)
							{
								goto IL_0088;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0088:
						num2 = num3;
					}
				}
				throw new IOException(string.Concat("运行时文件不能是链接：", (string)path));
			}
			catch (FileNotFoundException)
			{
				int num4 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
				{
					num4 = 2;
				}
				while (true)
				{
					switch (num4)
					{
					case 0:
						return;
					}
					if (num5 != 988)
					{
						return;
					}
					num4 = num5;
				}
			}
			catch (DirectoryNotFoundException)
			{
				int num6 = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
				{
					num6 = 0;
				}
				while (true)
				{
					switch (num6)
					{
					case 0:
						return;
					}
					if (num7 != 988)
					{
						return;
					}
					num6 = num7;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static YX8SHUXQfJXpP4uYXk6f? STZXJF1fCVQ(object directory)
	{
		string text = System.IO.Path.Combine((string)directory, "chronal-runtime-profile.json");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ALrkVcXQDsZJ0xckHeBI T8CXJsYArSI(object directory)
	{
		string text = System.IO.Path.Combine((string)directory, "jli_real.dll");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool ah1XJT8vbA6(object directory, object manifest)
	{
		string[] array = new string[2]
		{
			"jli_real.dll",
			"jli.chronal-original.dll"
		};
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string CxRXJN0Fwyd(object directory, object manifest)
	{
		string[] array = new string[2]
		{
			"jli_real.dll",
			"jli.chronal-original.dll"
		};
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void dTkXJMnftUI(object directory, object manifest)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		int num = 1;
		string text = default(string);
		string text4 = default(string);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 991)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 3:
					return;
				case 0:
				{
					string text2 = text;
					string text3 = ".";
					Guid val = System.Guid.NewGuid();
					text4 = string.Concat(text2, text3, (val).ToString("N"), ".tmp");
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 2:
					try
					{
						System.IO.File.WriteAllText(text4, JsonSerializer.Serialize<YX8SHUXQfJXpP4uYXk6f>((YX8SHUXQfJXpP4uYXk6f)manifest, (JsonSerializerOptions)null), (Encoding)new UTF8Encoding(false));
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 4;
						}
						while (true)
						{
							switch (num3)
							{
							case 0:
								return;
							default:
								if (num4 != 989)
								{
									return;
								}
								num3 = num4;
								break;
							case 1:
								System.IO.File.Move(text4, text, false);
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
								{
									num3 = 2;
								}
								break;
							}
						}
					}
					finally
					{
						if (System.IO.File.Exists(text4))
						{
							int num5 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
							{
								num5 = 4;
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
									break;
								case 0:
									goto end_IL_01b6;
								}
								System.IO.File.Delete(text4);
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
								{
									num5 = 0;
								}
								continue;
								end_IL_01b6:
								break;
							}
						}
					}
				case 1:
					text = System.IO.Path.Combine((string)directory, "chronal-runtime-profile.json");
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
					{
						num2 = 1;
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
	internal static void q7KXJp5Mqdi(object source, object destination, object expectedHash)
	{
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string text = default(string);
		int num5 = default(int);
		int num7 = default(int);
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
					{
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						string text2 = ".";
						Guid val = System.Guid.NewGuid();
						text = string.Concat((string)destination, text2, (val).ToString("N"), ".tmp");
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
						{
							num3 = 2;
						}
						continue;
					}
					case 2:
						try
						{
							System.IO.File.Copy((string)source, text, false);
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 990)
									{
										num4 = num5;
										continue;
									}
									goto case 0;
								case 0:
									throw new InvalidDataException("创建备份期间原始文件发生变化，未执行替换。");
								case 1:
									if (!(z1sVglXQcrEox7hxA54W.bp7XQyn99Zp(text) != (string)expectedHash))
									{
										System.IO.File.Move(text, (string)destination, false);
										num4 = 2;
										continue;
									}
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
									{
										num4 = 5;
									}
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						finally
						{
							int num6;
							if (!System.IO.File.Exists(text))
							{
								num6 = 2;
								goto IL_0151;
							}
							goto IL_0199;
							IL_0199:
							System.IO.File.Delete(text);
							num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
							{
								num6 = 5;
							}
							goto IL_0151;
							IL_0151:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 990)
									{
										goto IL_014d;
									}
									break;
								case 2:
									goto end_IL_0151;
								case 1:
									break;
								case 0:
									goto end_IL_0151;
								}
								goto IL_0199;
								IL_014d:
								num6 = num7;
								continue;
								end_IL_0151:
								break;
							}
						}
						goto case 3;
					case 1:
						if (!System.IO.File.Exists((string)destination))
						{
							break;
						}
						goto case 3;
					case 0:
						throw new InvalidDataException(string.Concat("已有备份与原件不一致，未覆盖备份：", (string)destination));
					case 3:
						if (!(z1sVglXQcrEox7hxA54W.bp7XQyn99Zp(destination) != (string)expectedHash))
						{
							return;
						}
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
						{
							num3 = 0;
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
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed != 0)
			{
				num = 10;
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
	internal static bool BrUKF0ZdUy5unifFTJSy()
	{
		return Rx9M4eZdhsUrAwriSIkr == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ObJPw4XJwIUTBNwBbypr ixp31SZdrfOmG418UXIy()
	{
		return (ObJPw4XJwIUTBNwBbypr)Rx9M4eZdhsUrAwriSIkr;
	}
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using EgXnfafZ2mjsaPfJxiCB;
using a7SGhofapyfcs667hqvi;
using bVpm9ofaNkQaQ1BfGtjU;
using fDAldojjppXrctUVYOJn;

namespace vsLPMTfZzATtmubxWfjm;

internal sealed class w8FQMjfZn2G2QIriswIL
{
	private static object iwGf98fkZis;

	private static object ulYf9y7VRc9;

	private readonly object a11f9WM3yrF;

	internal static object DZcgvqZNV4haWpMPIJLb;

	[MethodImpl((MethodImplOptions)8)]
	internal w8FQMjfZn2G2QIriswIL(string? rootPath = null)
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal svXO9wfaM98XKNvcsrMd a1cf9blW0yk(string version, string sourceOptionsPath)
	{
		int num = 4;
		string text3 = default(string);
		bool flag = default(bool);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text2;
					switch (num3)
					{
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						text2 = text3;
						break;
					case 4:
						text3 = P0if9Su1s4K(version);
						num3 = 3;
						continue;
					case 3:
						flag = System.IO.File.Exists(text3);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						text2 = System.IO.Path.GetFullPath(sourceOptionsPath);
						break;
					case 1:
						return (svXO9wfaM98XKNvcsrMd)new svXO9wfaM98XKNvcsrMd(Vhhf9ZtqxqP(text), flag, text);
					case 0:
						if (flag)
						{
							goto end_IL_000c;
						}
						goto case 2;
					}
					text = text2;
					num3 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
					{
						num3 = 1;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 11;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal svXO9wfaM98XKNvcsrMd WZhf9XFV2xv(string version, string sourceOptionsPath, P0AvWCfaT2GZfGOulKXm engine)
	{
		string sourcePath = System.IO.Path.GetFullPath(sourceOptionsPath);
		string profilePath = P0if9Su1s4K(version);
		svBf9DDP3lx(sourcePath, profilePath);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal aH8OktfZE5UfKgZLYDFf? IsIf9ftEoIE(string version)
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						if (System.IO.File.Exists(text))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto case 1;
					case 2:
						return (aH8OktfZE5UfKgZLYDFf?)new aH8OktfZE5UfKgZLYDFf(text);
					case 3:
						break;
					case 1:
						return null;
					case 0:
						FvRf9955gEP(text);
						num3 = 2;
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
			text = P0if9Su1s4K(version);
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal svXO9wfaM98XKNvcsrMd I2Tf9L0pEqA(string version, string sourceOptionsPath)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string text = default(string);
		string text2 = default(string);
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
								goto end_IL_0010;
							}
						}
						else if (System.IO.File.Exists(text))
						{
							num3 = 3;
							continue;
						}
						goto case 2;
					case 2:
						return a1cf9blW0yk(version, sourceOptionsPath);
					case 3:
					{
						object[] obj = new object[5]
						{
							(object)text,
							(object)".disabled-",
							null,
							null,
							null
						};
						DateTimeOffset val = System.DateTimeOffset.UtcNow;
						obj[2] = (object)(val).ToString("yyyyMMddHHmmssfff");
						obj[3] = (object)"-";
						Guid val2 = System.Guid.NewGuid();
						obj[4] = (object)(val2).ToString("N");
						text2 = string.Concat((string[])obj);
						num3 = 4;
						continue;
					}
					case 1:
						break;
					case 0:
						return a1cf9blW0yk(version, sourceOptionsPath);
					case 4:
						System.IO.File.Move(text, text2, false);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
						{
							num3 = 1;
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
			text = P0if9Su1s4K(version);
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string lxyf9jy1SKV(string version)
	{
		return P0if9Su1s4K(version);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static P0AvWCfaT2GZfGOulKXm? Vhhf9ZtqxqP(object path)
	{
		//IL_003d: Expected O, but got I4
		int num = 1;
		P0AvWCfaT2GZfGOulKXm? result = default(P0AvWCfaT2GZfGOulKXm?);
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
		P0AvWCfaT2GZfGOulKXm? p0AvWCfaT2GZfGOulKXm = default(P0AvWCfaT2GZfGOulKXm?);
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
					result = (P0AvWCfaT2GZfGOulKXm?)(object)FvRf9955gEP(path);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
					{
						num2 = 4;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 988)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							break;
						}
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 2;
					}
					else
					{
						ex = obj2;
						num4 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num4 = 6;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 19)
							{
								if (num5 == 999)
								{
									goto IL_00b3;
								}
								goto case 11;
							}
							goto case 4;
						case 6:
							if (!(ex is IOException))
							{
								num4 = 7;
								continue;
							}
							goto case 0;
						case 7:
							if (!(ex is UnauthorizedAccessException))
							{
								num4 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e != 0)
								{
									num4 = 9;
								}
								continue;
							}
							goto case 0;
						case 0:
						case 1:
						case 9:
							flag = true;
							num4 = 4;
							continue;
						case 3:
						case 5:
							flag = false;
							num6 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
							{
								num6 = 19;
							}
							num5 = num6;
							goto IL_00b3;
						case 11:
							if (ex is ArgumentException)
							{
								num4 = 9;
								continue;
							}
							goto case 8;
						case 8:
							if (!(ex is NotSupportedException))
							{
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
								{
									num4 = 11;
								}
								continue;
							}
							goto case 0;
						case 10:
							if (ex is InvalidDataException)
							{
								num4 = 19;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
								{
									num4 = 0;
								}
								continue;
							}
							goto case 11;
						case 2:
							result2 = 0;
							break;
						case 4:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_00b3:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
					{
						num7 = 8;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							if (num8 == 990)
							{
								num7 = num8;
								continue;
							}
							goto case 0;
						case 0:
							p0AvWCfaT2GZfGOulKXm = null;
							num7 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
							{
								num7 = 7;
							}
							continue;
						case 2:
							result = p0AvWCfaT2GZfGOulKXm;
							num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
							{
								num7 = 5;
							}
							continue;
						case 1:
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
	private static P0AvWCfaT2GZfGOulKXm FvRf9955gEP(object path)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		ValueTuple<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Collections.Generic.IReadOnlyList<int>> val = QPQf9V7RFy8(System.IO.File.ReadAllBytes((string)path));
		global::System.Collections.Generic.IReadOnlyList<int> item = val.Item1;
		global::System.Collections.Generic.IReadOnlyList<int> item2 = val.Item2;
		return default(P0AvWCfaT2GZfGOulKXm);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void svBf9DDP3lx(object sourcePath, object profilePath)
	{
		//IL_0216: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string text = default(string);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			string text3;
			while (true)
			{
				IL_000c:
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 3:
						FvRf9955gEP(profilePath);
						num3 = 4;
						continue;
					case 4:
						return;
					case 0:
						FvRf9955gEP(sourcePath);
						num3 = 6;
						continue;
					case 6:
						goto IL_0088;
					case 1:
						if (!System.IO.File.Exists((string)profilePath))
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 3;
					case 7:
						try
						{
							System.IO.File.Copy((string)sourcePath, text, false);
							int num4 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num4 = 5;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 990)
									{
										num4 = num5;
										break;
									}
									return;
								case 2:
									FvRf9955gEP(text);
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
									{
										num4 = 3;
									}
									break;
								case 0:
									System.IO.File.Move(text, (string)profilePath, false);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
									{
										num4 = 0;
									}
									break;
								case 1:
									return;
								}
							}
						}
						finally
						{
							pLnf9c961aV(text);
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
							{
								num6 = 6;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					case 5:
						return;
					case 2:
						throw new global::System.Exception("无法确定版本渲染配置目录");
					}
					switch (num2)
					{
					case 995:
						break;
					default:
						return;
					case 14:
					{
						string text2 = ".staging-";
						Guid val = System.Guid.NewGuid();
						text = string.Concat((string)profilePath, text2, (val).ToString("N"));
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num3 = 10;
						}
						continue;
					}
					}
					goto IL_000c;
					IL_0088:
					text3 = System.IO.Path.GetDirectoryName((string)profilePath);
					if (text3 != null)
					{
						break;
					}
					num3 = 2;
				}
				break;
			}
			System.IO.Directory.CreateDirectory(text3);
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
			{
				num = 14;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void jFFf9kEkRe6(object profilePath, P0AvWCfaT2GZfGOulKXm engine)
	{
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got I4
		//IL_04a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0648->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0653->IL0010: Incompatible stack heights: 2 vs 1
		//IL_0241->IL0182: Incompatible stack heights: 0 vs 5
		int num = 9;
		global::System.Collections.Generic.IReadOnlyList<int> item2 = default(global::System.Collections.Generic.IReadOnlyList<int>);
		global::System.Collections.Generic.IReadOnlyList<int> item = default(global::System.Collections.Generic.IReadOnlyList<int>);
		byte[] array = default(byte[]);
		int num12 = default(int);
		string text2 = default(string);
		int num9 = default(int);
		int num11 = default(int);
		int num16 = default(int);
		int num14 = default(int);
		string text = default(string);
		bool flag = default(bool);
		int num6 = default(int);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					global::System.Collections.Generic.IReadOnlyList<int> readOnlyList;
					int num5;
					switch (num3)
					{
					default:
						if (num2 != 25)
						{
							if (num2 == 1006)
							{
								goto end_IL_0010;
							}
							goto case 16;
						}
						readOnlyList = item2;
						num5 = 0 + ((global::System.Array)ulYf9y7VRc9).Length - 1;
						goto IL_0632;
					case 16:
						if ((nint)((object)item + (object)item2) != 1)
						{
							num3 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
							{
								num3 = 16;
							}
							continue;
						}
						if ((nint)item != 1)
						{
							num = 25;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num = 16;
							}
							break;
						}
						readOnlyList = item;
						num5 = 0 + ((global::System.Array)iwGf98fkZis).Length - 1;
						goto IL_0632;
					case 9:
						array = System.IO.File.ReadAllBytes((string)profilePath);
						num3 = 8;
						continue;
					case 15:
						return;
					case 5:
						try
						{
							_ = 1;
							_ = 2;
							_ = 0;
							_ = 65536;
							FileStream val2 = (FileStream)(object)(-2147483648);
							int num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num7 = 2;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num12 == 991)
									{
										num7 = num12;
										break;
									}
									goto case 3;
								case 1:
									if (FvRf9955gEP(profilePath) == engine)
									{
										return;
									}
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
									{
										num7 = 8;
									}
									break;
								case 2:
									System.IO.File.Move(text2, (string)profilePath, true);
									num7 = 9;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num7 = 1;
									}
									break;
								case 3:
									try
									{
										(val2).Write((global::System.ReadOnlySpan<byte>)array);
										int num8 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
										{
											num8 = 1;
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
											case 1:
												(val2).Flush(true);
												num8 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
												{
													num8 = 1;
												}
												continue;
											case 0:
												break;
											}
											break;
										}
									}
									finally
									{
										int num10;
										if (val2 == null)
										{
											num10 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
											{
												num10 = 5;
											}
											goto IL_0279;
										}
										goto IL_02ac;
										IL_0279:
										while (true)
										{
											switch (num10)
											{
											default:
												if (num11 == 990)
												{
													goto IL_0275;
												}
												goto end_IL_0279;
											case 0:
												goto end_IL_0279;
											case 2:
												break;
											case 1:
												goto end_IL_0279;
											}
											goto IL_02ac;
											IL_0275:
											num10 = num11;
											continue;
											end_IL_0279:
											break;
										}
										goto end_IL_0241;
										IL_02ac:
										(val2).Dispose();
										num10 = 6;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
										{
											num10 = 1;
										}
										goto IL_0279;
										end_IL_0241:;
									}
									goto case 2;
								case 0:
									throw new global::System.Exception("版本渲染配置写入后校验失败");
								}
							}
						}
						catch
						{
							int num13 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 == 0)
							{
								num13 = 1;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num14 == 989)
									{
										num13 = num14;
										break;
									}
									goto case 1;
								case 1:
									System.IO.File.Copy(text, (string)profilePath, true);
									num13 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
									{
										num13 = 3;
									}
									break;
								case 0:
									throw new global::System.Exception();
								}
							}
						}
						finally
						{
							pLnf9c961aV(text2);
							int num15 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
							{
								num15 = 0;
							}
							while (true)
							{
								switch (num15)
								{
								default:
									if (num16 == 988)
									{
										num15 = num16;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					case 12:
						throw new global::System.Exception("版本渲染配置必须且只能包含一个 gfx_renderengine 设置");
					case 4:
					case 18:
						flag = false;
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db != 0)
						{
							num3 = 13;
						}
						continue;
					case 6:
						if (num6 <= 0)
						{
							num3 = 11;
							continue;
						}
						goto case 2;
					case 3:
						throw new global::System.Exception("版本渲染配置大小无效");
					case 1:
					{
						string text3 = ".tmp-";
						Guid val3 = System.Guid.NewGuid();
						text2 = string.Concat((string)profilePath, text3, (val3).ToString("N"));
						num3 = 13;
						continue;
					}
					case 10:
					case 14:
						if (!flag)
						{
							ValueTuple<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Collections.Generic.IReadOnlyList<int>> val = QPQf9V7RFy8(array);
							item = val.Item1;
							item2 = val.Item2;
							num = 16;
						}
						else
						{
							num = 3;
						}
						break;
					case 0:
					case 11:
						flag = true;
						num3 = 14;
						continue;
					case 7:
						text = string.Concat((string)profilePath, ".bak");
						num3 = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						if (num6 <= 2097152)
						{
							num3 = 18;
							continue;
						}
						goto case 0;
					case 13:
						System.IO.File.Copy((string)profilePath, text, true);
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
						{
							num3 = 2;
						}
						continue;
					case 8:
						num6 = array.Length;
						num3 = 6;
						continue;
					case 17:
						{
							array[num4] = (byte)((engine == P0AvWCfaT2GZfGOulKXm.OpenGl) ? 48 : 49);
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						IL_0632:
						num4 = num5;
						_ = 18;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							_ = 17;
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
	private static ValueTuple<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Collections.Generic.IReadOnlyList<int>> QPQf9V7RFy8(object bytes)
	{
		O5Lf9YWbOQC(bytes, iwGf98fkZis);
		return (ValueTuple<global::System.Collections.Generic.IReadOnlyList<int>, global::System.Collections.Generic.IReadOnlyList<int>>)O5Lf9YWbOQC(bytes, ulYf9y7VRc9);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static global::System.Collections.Generic.IReadOnlyList<int> O5Lf9YWbOQC(object bytes, object pattern)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private string P0if9Su1s4K(string version)
	{
		//IL_035a: Expected O, but got I4
		int num = 30;
		bool flag2 = default(bool);
		bool flag = default(bool);
		int num8 = default(int);
		string text4 = default(string);
		byte[] array = default(byte[]);
		int num5 = default(int);
		StringBuilder val = default(StringBuilder);
		int num7 = default(int);
		char[] array2 = default(char[]);
		char c = default(char);
		string text2 = default(string);
		StringBuilder val2 = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text;
					switch (num3)
					{
					default:
						if (num2 == 38)
						{
							goto case 8;
						}
						if (num2 == 1019)
						{
							goto end_IL_0010;
						}
						goto case 9;
					case 26:
						flag2 = false;
						num3 = 11;
						continue;
					case 14:
						flag = false;
						num3 = 13;
						continue;
					case 8:
						if (num8 < (text4).Length)
						{
							num3 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
							{
								num3 = 31;
							}
							continue;
						}
						goto case 24;
					case 3:
						try
						{
							string text3 = ((System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array))).Substring(0, 12)).ToLowerInvariant();
							int num4 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0163;
								}
								object obj = a11f9WM3yrF;
								StringBuilder obj2 = val;
								text4 = System.IO.Path.Combine((string)obj, string.Concat((obj2 != null) ? (obj2).ToString() : null, "-", text3), "options.profile.txt");
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
								{
									num4 = 5;
								}
								continue;
								end_IL_0163:
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
							{
								num6 = 4;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 15;
					case 7:
						if (num8 > 128)
						{
							num3 = 24;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
							{
								num3 = 28;
							}
							continue;
						}
						goto case 18;
					case 9:
						_ = "基岩版本标识无效";
						throw new global::System.Exception("version");
					case 0:
						array2 = System.IO.Path.GetInvalidFileNameChars();
						num3 = 16;
						continue;
					case 6:
						if (c == '\\')
						{
							num3 = 23;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
							{
								num3 = 23;
							}
							continue;
						}
						goto case 14;
					case 16:
						val = (StringBuilder)(object)(text2).Length;
						num = 10;
						break;
					case 23:
						flag = true;
						num3 = 5;
						continue;
					case 4:
						if (!flag2)
						{
							num3 = 22;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
							{
								num3 = 36;
							}
							continue;
						}
						goto case 19;
					case 5:
					case 13:
						flag2 = flag;
						num = 19;
						break;
					case 12:
						flag2 = global::System.Array.IndexOf<char>(array2, c) >= 0;
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 4;
						}
						continue;
					case 10:
						text4 = text2;
						num3 = 20;
						continue;
					case 11:
					case 25:
						if (!flag2)
						{
							num3 = 26;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 9;
					case 22:
						if (c != '/')
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 23;
					case 1:
						val2 = val;
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 12;
						}
						continue;
					case 18:
						if (num8 == 0)
						{
							num3 = 21;
							continue;
						}
						goto case 26;
					case 24:
						array = (System.Text.Encoding.UTF8).GetBytes((text2).ToUpperInvariant());
						num3 = 3;
						continue;
					case 21:
					case 28:
						flag2 = true;
						num3 = 19;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
						{
							num3 = 25;
						}
						continue;
					case 27:
						num8++;
						num = 38;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
						{
							num = 12;
						}
						break;
					case 2:
					case 31:
						c = (text4).Chars;
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
						{
							num3 = 1;
						}
						continue;
					case 15:
						return text4;
					case 20:
						num8 = 0;
						num3 = 8;
						continue;
					case 17:
						num8 = (text2).Length;
						num3 = 7;
						continue;
					case 30:
						text = version;
						if (text != null)
						{
							goto IL_05c0;
						}
						num3 = 29;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 20;
						}
						continue;
					case 29:
						text = string.Empty;
						goto IL_05c0;
					case 19:
						{
							(val2).Append(flag2 ? '_' : c);
							num3 = 27;
							continue;
						}
						IL_05c0:
						text2 = (text).Trim();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 17;
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
	private static void pLnf9c961aV(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			case 1:
				try
				{
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
						{
							num2 = 8;
						}
						goto IL_0072;
					}
					goto IL_00ba;
					IL_0072:
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 990)
							{
								goto IL_006e;
							}
							return;
						case 0:
							return;
						case 1:
							break;
						case 2:
							return;
						}
						break;
						IL_006e:
						num2 = num3;
					}
					goto IL_00ba;
					IL_00ba:
					System.IO.File.Delete((string)path);
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num2 = 3;
					}
					goto IL_0072;
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
						{
							num4 = 9;
						}
					}
					else
					{
						ex = obj2;
						num4 = 3;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 14)
							{
								if (num5 == 994)
								{
									goto IL_0127;
								}
								goto case 3;
							}
							goto case 0;
						case 2:
							flag = true;
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
							{
								num4 = 7;
							}
							continue;
						case 6:
							if (!(ex is UnauthorizedAccessException))
							{
								num5 = 14;
								goto IL_0127;
							}
							goto case 2;
						case 3:
							if (!(ex is IOException))
							{
								num4 = 6;
								continue;
							}
							goto case 2;
						case 0:
							flag = false;
							num4 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
							{
								num4 = 11;
							}
							continue;
						case 4:
							result = 0;
							break;
						case 1:
						case 5:
							{
								result = (flag ? 1 : 0);
								break;
							}
							IL_0127:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num6 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
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
						if (num7 == 988)
						{
							num6 = num7;
							continue;
						}
						return;
					}
				}
			default:
				return;
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
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						switch (num2)
						{
						case 993:
							break;
						case 12:
							goto IL_013e;
						default:
							goto end_IL_000e;
						}
						break;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
						{
							num3 = 5;
						}
						continue;
					case 4:
						iwGf98fkZis = (System.Text.Encoding.ASCII).GetBytes("gfx_renderengine:0");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							num3 = 2;
						}
						continue;
					case 3:
						ulYf9y7VRc9 = (System.Text.Encoding.ASCII).GetBytes("gfx_renderengine:1");
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num3 = 5;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num3 = 7;
						}
						continue;
					case 2:
						goto end_IL_000e;
					case 5:
						return;
						IL_013e:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							num3 = 2;
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
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool TkDFScZNYHD9BtAIX0fy()
	{
		return DZcgvqZNV4haWpMPIJLb == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static w8FQMjfZn2G2QIriswIL APNcHsZNSQ84uI3iuy6n()
	{
		return (w8FQMjfZn2G2QIriswIL)DZcgvqZNV4haWpMPIJLb;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;
using qcIZ8lAjAHfMaUh5fOa;
using r5LWFs73eOlXSX66CSK;

namespace uE73cnXvsTKdLeHSHX3F;

internal sealed class zT2YBYXvFCOQYJ0viLnb
{
	internal static object mWjPZhZPz6nFTVTtT3U9;

	internal string DefaultRootPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return uumXvpM3Vf5(JNVYTu71oRZRpWuML35.BedrockDataRoot);
		}
	}

	internal string RootPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			int num = 3;
			string text = default(string);
			string result = default(string);
			int num5 = default(int);
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
								goto case 3;
							}
							return DefaultRootPath;
						case 3:
							text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.managedRoot");
							num = 2;
							break;
						case 0:
							return result;
						case 1:
							try
							{
								result = uumXvpM3Vf5(text);
								int num4 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num4 = 0;
								}
								while (true)
								{
									switch (num4)
									{
									default:
										if (num5 == 988)
										{
											num4 = num5;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							catch (global::System.Exception obj) when (((Func<bool>)delegate
							{
								// Could not convert BlockContainer to single expression
								obj2 = obj as global::System.Exception;
								if (obj2 == null)
								{
									num6 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
									{
										num6 = 6;
									}
								}
								else
								{
									ex = obj2;
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
									{
										num6 = 3;
									}
								}
								while (true)
								{
									switch (num6)
									{
									default:
										if (num7 != 14)
										{
											if (num7 == 994)
											{
												goto IL_0110;
											}
											goto case 2;
										}
										goto case 0;
									case 5:
										if (ex is PathTooLongException)
										{
											num6 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
											{
												num6 = 3;
											}
											continue;
										}
										goto case 2;
									case 4:
										flag = true;
										num6 = 11;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
										{
											num6 = 0;
										}
										continue;
									case 1:
										if (!(ex is NotSupportedException))
										{
											num6 = 5;
											continue;
										}
										goto case 4;
									case 3:
										if (!(ex is ArgumentException))
										{
											num6 = 8;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
											{
												num6 = 1;
											}
											continue;
										}
										goto case 4;
									case 2:
										flag = false;
										num7 = 14;
										goto IL_0110;
									case 6:
										result2 = 0;
										break;
									case 0:
										{
											result2 = (flag ? 1 : 0);
											break;
										}
										IL_0110:
										num6 = num7;
										continue;
									}
									break;
								}
								return (byte)result2 != 0;
							}).Invoke())
							{
								int num8 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
								{
									num8 = 0;
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
										result = DefaultRootPath;
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
										{
											num8 = 4;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							goto case 0;
						case 2:
							if (!string.IsNullOrWhiteSpace(text))
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
								{
									num3 = 5;
								}
								continue;
							}
							num = 10;
							break;
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
	}

	internal bool IsDefault
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return snoXvMZ95f2(RootPath, DefaultRootPath);
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string PyRXvTlSk0k(string path)
	{
		string text = hJOXb0ALfS6Dke4PZFZ.iIGAZT9dtF("bedrock.client.managedRoot");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string GLjXvNbNLCV()
	{
		hJOXb0ALfS6Dke4PZFZ.LMvA9PbbUQ("bedrock.client.managedRoot", string.Empty);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool snoXvMZ95f2(object left, object right)
	{
		return string.Equals(uumXvpM3Vf5(left), uumXvpM3Vf5(right), (StringComparison)5);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string uumXvpM3Vf5(object path)
	{
		string text = System.IO.Path.GetFullPath(((dynamic)(path)).Trim());
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void PZwXvuSAgYX(object path)
	{
		//IL_02c1: Expected O, but got Unknown
		//IL_0339: Expected O, but got Unknown
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		int num = 1;
		int num8 = default(int);
		FileStream val = default(FileStream);
		int num5 = default(int);
		int num7 = default(int);
		string text = default(string);
		int num18 = default(int);
		int num15 = default(int);
		int num17 = default(int);
		int num10 = default(int);
		int num12 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					try
					{
						System.IO.Directory.CreateDirectory((string)path);
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num8 == 991)
								{
									num3 = num8;
									break;
								}
								goto case 3;
							case 2:
								try
								{
									(val).WriteByte(0);
									int num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
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
											return;
										}
										(val).Flush(true);
										num4 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
										{
											num4 = 1;
										}
									}
								}
								finally
								{
									int num6;
									if (val == null)
									{
										num6 = 2;
										goto IL_014e;
									}
									goto IL_0196;
									IL_0196:
									(val).Dispose();
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
									{
										num6 = 6;
									}
									goto IL_014e;
									IL_014e:
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 990)
											{
												goto IL_014a;
											}
											goto end_IL_014e;
										case 2:
											goto end_IL_014e;
										case 1:
											break;
										case 0:
											goto end_IL_014e;
										}
										goto IL_0196;
										IL_014a:
										num6 = num7;
										continue;
										end_IL_014e:
										break;
									}
								}
							case 3:
								val = new FileStream(text, (FileMode)1, (FileAccess)2, (FileShare)0, 1, (FileOptions)(-2147483648));
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
								{
									num3 = 2;
								}
								break;
							case 1:
							{
								global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(24, 1);
								(defaultInterpolatedStringHandler).AppendLiteral(".chronal-write-test-");
								defaultInterpolatedStringHandler.AppendFormatted<Guid>(System.Guid.NewGuid(), "N");
								(defaultInterpolatedStringHandler).AppendLiteral(".tmp");
								text = System.IO.Path.Combine((string)path, (defaultInterpolatedStringHandler).ToStringAndClear());
								num3 = 3;
								break;
							}
							case 0:
								return;
							}
						}
					}
					catch (UnauthorizedAccessException ex)
					{
						UnauthorizedAccessException ex2 = ex;
						int num9 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 == 988)
								{
									goto IL_02ee;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_02ee:
							num9 = num10;
						}
						throw new InvalidOperationException("所选目录没有写入权限，请选择其他目录", (global::System.Exception)(object)ex2);
					}
					catch (IOException ex3)
					{
						IOException ex4 = ex3;
						int num11 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num11 = 0;
						}
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 988)
								{
									goto IL_0366;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0366:
							num11 = num12;
						}
						throw new InvalidOperationException("所选目录当前不可写，请检查磁盘后重试", (global::System.Exception)(object)ex4);
					}
					finally
					{
						if (!string.IsNullOrWhiteSpace(text))
						{
							int num13 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
							{
								num13 = 3;
							}
							while (true)
							{
								switch (num13)
								{
								default:
									if (num18 == 989)
									{
										goto IL_03e7;
									}
									break;
								case 1:
									try
									{
										System.IO.File.Delete(text);
										int num14 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
										{
											num14 = 0;
										}
										while (true)
										{
											switch (num14)
											{
											default:
												if (num15 == 988)
												{
													num14 = num15;
													continue;
												}
												break;
											case 0:
												break;
											}
											break;
										}
									}
									catch (global::System.Exception)
									{
										int num16 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
										{
											num16 = 4;
										}
										while (true)
										{
											switch (num16)
											{
											default:
												if (num17 == 988)
												{
													num16 = num17;
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
								case 0:
									break;
								}
								break;
								IL_03e7:
								num13 = num18;
							}
						}
					}
				case 1:
					text = null;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	public zT2YBYXvFCOQYJ0viLnb()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool PHbtkPZxbQ61LfDKoXWh()
	{
		return mWjPZhZPz6nFTVTtT3U9 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static zT2YBYXvFCOQYJ0viLnb aPV6h8ZxXxpSEPYanD2C()
	{
		return (zT2YBYXvFCOQYJ0viLnb)mWjPZhZPz6nFTVTtT3U9;
	}
}

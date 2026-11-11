using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using QsfDKWfxJrH6hCJbFZZU;
using fDAldojjppXrctUVYOJn;
using iub6sEfxCXsf5d8ZSnWT;
using ywGnTBpYrmIWeMZ0yUK;

namespace iMuMdHpfJ0pSygeoa4N;

internal sealed class Ywk4YLpX8koXHso253m
{
	internal static object jnYrvAZhHGRh5KXvvEUF;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe bool xZ0pLP2Cqq(string root, string path, Q4IOjafxWEphf5nnWRp5 kind, string displayName, global::System.DateTime? cutoff, out IJS1aApVWgimg5cOQvi evidence)
	{
		//IL_0135: Expected O, but got Ref
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		bool result = default(bool);
		FileInfo val = default(FileInfo);
		byte[] bytes = default(byte[]);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		int num8 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num10 = default(int);
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
					evidence = default;
					return result;
				case 2:
					evidence = null;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
					{
						num2 = 7;
					}
					break;
				case 1:
					try
					{
						int num3;
						if (coFpjXJG9H(root, path))
						{
							num3 = 7;
							goto IL_007c;
						}
						goto IL_0144;
						IL_0144:
						result = false;
						num3 = 19;
						goto IL_007c;
						IL_007c:
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								IL_0080:
								int num5 = num4;
								while (true)
								{
									switch (num5)
									{
									default:
										if (num4 != 19)
										{
											if (num4 == 999)
											{
												goto IL_0080;
											}
											goto case 10;
										}
										goto end_IL_007c;
									case 8:
										if (((val).LastWriteTimeUtc < (global::System.DateTime)(&cutoff)))
										{
											num5 = 5;
											continue;
										}
										goto case 10;
									case 3:
										break;
									case 9:
										goto end_IL_0084;
									case 4:
										result = true;
										num5 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
										{
											num5 = 0;
										}
										continue;
									case 5:
										result = false;
										num5 = 17;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
										{
											num5 = 6;
										}
										continue;
									case 6:
										goto end_IL_007c;
									case 2:
										if (&cutoff == null)
										{
											num5 = 10;
											continue;
										}
										goto case 8;
									case 10:
									case 11:
										bytes = o36p97ZqoS((val).FullName, (val).Length);
										num5 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
										{
											num5 = 6;
										}
										continue;
									case 0:
									case 7:
										val = (FileInfo)(object)path;
										num5 = 2;
										continue;
									case 1:
										goto end_IL_007c;
									}
									goto IL_0144;
									continue;
									end_IL_0084:
									break;
								}
								break;
							}
							evidence = (IJS1aApVWgimg5cOQvi)new IJS1aApVWgimg5cOQvi((dBYthxfxQLmKK6eNAbnX)new dBYthxfxQLmKK6eNAbnX(kind, displayName, (val).FullName, ((System.DateTimeOffset)(val).LastWriteTimeUtc), (val).Length), gmSpDsBeIU(bytes));
							num3 = 4;
							continue;
							end_IL_007c:
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num6 = 2;
							goto IL_027b;
						}
						ex = obj2;
						num7 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num7 = 10;
						}
						goto IL_0283;
						IL_027b:
						num8 = num6;
						goto IL_027f;
						IL_0283:
						while (true)
						{
							switch (num7)
							{
							default:
								if (num8 != 16)
								{
									if (num8 == 996)
									{
										goto IL_027f;
									}
									goto case 5;
								}
								goto case 6;
							case 3:
								if (ex is ArgumentException)
								{
									goto end_IL_0283;
								}
								goto case 8;
							case 1:
								if (!(ex is UnauthorizedAccessException))
								{
									num7 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
									{
										num7 = 3;
									}
									break;
								}
								goto case 6;
							case 0:
								if (!(ex is IOException))
								{
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
									{
										num7 = 3;
									}
									break;
								}
								goto case 6;
							case 4:
								flag = false;
								num7 = 7;
								break;
							case 8:
								if (ex is NotSupportedException)
								{
									num7 = 6;
									break;
								}
								goto case 4;
							case 6:
								flag = true;
								num7 = 5;
								break;
							case 2:
								result2 = 0;
								goto IL_03c8;
							case 5:
							case 7:
								{
									result2 = (flag ? 1 : 0);
									goto IL_03c8;
								}
								IL_03c8:
								return (byte)result2 != 0;
							}
							continue;
							end_IL_0283:
							break;
						}
						num6 = 16;
						goto IL_027b;
						IL_027f:
						num7 = num8;
						goto IL_0283;
					}).Invoke())
					{
						int num9 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
						{
							num9 = 0;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 == 989)
								{
									num9 = num10;
									continue;
								}
								break;
							case 0:
								result = false;
								num9 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
								{
									num9 = 3;
								}
								continue;
							case 1:
								break;
							}
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
	internal unsafe bool coFpjXJG9H(string root, string path)
	{
		//IL_00eb: Expected O, but got Ref
		int num = 1;
		int num4 = default(int);
		string text2 = default(string);
		bool result = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Exception ex = default(global::System.Exception);
		int num8 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num10 = default(int);
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
					string text = System.IO.Path.GetFullPath(path);
					int num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
					{
						num2 = 7;
					}
					while (true)
					{
						int num5;
						int num3;
						switch (num2)
						{
						default:
							if (num4 != 12)
							{
								if (num4 == 992)
								{
									goto IL_006e;
								}
								goto case 2;
							}
							num5 = ((!qjmpZIhQ7Z(text)) ? 1 : 0);
							break;
						case 2:
						{
							global::System.ReadOnlySpan<char> readOnlySpan = ((System.ReadOnlySpan<char>)(root).TrimEnd(new char[2]
							{
								Path.DirectorySeparatorChar,
								Path.AltDirectorySeparatorChar
							}));
							char directorySeparatorChar = Path.DirectorySeparatorChar;
							text2 = string.Concat(readOnlySpan, (global::System.ReadOnlySpan<char>)(&directorySeparatorChar));
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num2 = 1;
							}
							continue;
						}
						case 4:
							if (System.IO.File.Exists(text))
							{
								num3 = 12;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
								{
									num3 = 7;
								}
								goto IL_006a;
							}
							goto case 3;
						case 1:
							if (!(text).StartsWith(text2, (StringComparison)5))
							{
								num3 = 3;
								goto IL_006a;
							}
							goto case 4;
						case 3:
							num5 = 0;
							break;
						case 0:
							goto end_IL_0072;
							IL_006e:
							num2 = num4;
							continue;
							IL_006a:
							num4 = num3;
							goto IL_006e;
						}
						result = (byte)num5 != 0;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
						{
							num2 = 4;
						}
						continue;
						end_IL_0072:
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num6 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num6 = 4;
						}
					}
					else
					{
						ex = obj2;
						num6 = 2;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							if (num8 != 18)
							{
								if (num8 == 998)
								{
									goto IL_01e3;
								}
								goto case 10;
							}
							if (!(ex is NotSupportedException))
							{
								num6 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
								{
									num6 = 0;
								}
								continue;
							}
							goto case 3;
						case 2:
							if (ex is IOException)
							{
								num6 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
								{
									num6 = 3;
								}
								continue;
							}
							goto case 1;
						case 3:
						case 6:
						case 9:
							flag = true;
							num6 = 7;
							continue;
						case 10:
							if (!(ex is ArgumentException))
							{
								num7 = 18;
								goto IL_01df;
							}
							goto case 3;
						case 1:
							if (ex is UnauthorizedAccessException)
							{
								num7 = 9;
								goto IL_01df;
							}
							goto case 10;
						case 0:
						case 5:
							flag = false;
							num6 = 4;
							continue;
						case 8:
							result2 = 0;
							break;
						case 4:
						case 7:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_01df:
							num8 = num7;
							goto IL_01e3;
							IL_01e3:
							num6 = num8;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num9 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						default:
							if (num10 == 989)
							{
								num9 = num10;
								continue;
							}
							break;
						case 0:
							result = false;
							num9 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
							{
								num9 = 1;
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
	internal bool qjmpZIhQ7Z(string path)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		return (System.IO.File.GetAttributes(path) & 0x400) > 0;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] o36p97ZqoS(object path, long length)
	{
		//IL_0293: Expected O, but got I4
		//IL_02a7->IL0010: Incompatible stack heights: 6 vs 1
		//IL_02b2->IL0010: Incompatible stack heights: 6 vs 1
		int num = 2;
		byte[] array = default(byte[]);
		int num4 = default(int);
		byte[] array2 = default(byte[]);
		byte[] result = default(byte[]);
		FileStream val = default(FileStream);
		int num5 = default(int);
		int num7 = default(int);
		while (true)
		{
			while (true)
			{
				switch (num)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 1:
					try
					{
						int num2;
						if (length <= 2097152)
						{
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num2 = 17;
							}
							goto IL_0072;
						}
						goto IL_00fe;
						IL_0171:
						array = new byte[checked((int)length)];
						int num3 = 17;
						goto IL_006a;
						IL_00fe:
						num4 = 1048576;
						num3 = 2;
						goto IL_006a;
						IL_0072:
						while (true)
						{
							switch (num2)
							{
							case 2:
								array2 = new byte[2097152];
								num2 = 5;
								continue;
							case 8:
								goto end_IL_0072;
							case 3:
								goto IL_00fe;
							case 6:
								result = array2;
								num2 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
								{
									num2 = 6;
								}
								continue;
							case 7:
								(val).Seek(-num4, (SeekOrigin)2);
								num2 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
								{
									num2 = 9;
								}
								continue;
							case 9:
								result = array;
								num2 = 8;
								continue;
							case 1:
								goto IL_0171;
							case 0:
								(val).ReadExactly(MemoryExtensions.AsSpan<byte>(array2, num4, num4));
								num2 = 6;
								continue;
							case 5:
								(val).ReadExactly(MemoryExtensions.AsSpan<byte>(array2, 0, num4));
								num2 = 10;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
								{
									num2 = 7;
								}
								continue;
							case 4:
								goto end_IL_0072;
							}
							switch (num5)
							{
							case 997:
								break;
							default:
								goto end_IL_0072;
							case 17:
								(val).ReadExactly((global::System.Span<byte>)array);
								num2 = 9;
								continue;
							}
							goto IL_006e;
							continue;
							end_IL_0072:
							break;
						}
						goto end_IL_0035;
						IL_006a:
						num5 = num3;
						goto IL_006e;
						IL_006e:
						num2 = num5;
						goto IL_0072;
						end_IL_0035:;
					}
					finally
					{
						if (val != null)
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										continue;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0217;
								}
								(val).Dispose();
								num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_0217:
								break;
							}
						}
					}
					break;
				case 2:
					_ = 3;
					_ = 1;
					_ = 7;
					_ = 65536;
					val = (FileStream)(object)134217728;
					_ = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
					{
						_ = 1;
					}
					continue;
				case 0:
					break;
				}
				return result;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string gmSpDsBeIU(object bytes)
	{
		int num = 9;
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
						if (num2 != 16)
						{
							if (num2 == 997)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						return (System.Text.Encoding.UTF8).GetString((byte[])bytes, 3, ((global::System.Array)bytes).Length - 3);
					case 9:
						if (((global::System.Array)bytes).Length >= 2)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto IL_0187;
					case 5:
						if (((short[])bytes)[2] == 191)
						{
							num = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
							{
								num = 15;
							}
							break;
						}
						goto IL_00e5;
					case 2:
						if (((short[])bytes)[1] == 187)
						{
							num3 = 5;
							continue;
						}
						goto IL_00e5;
					case 3:
						if (((short[])bytes)[1] == 254)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_0187;
					case 7:
						return (System.Text.Encoding.BigEndianUnicode).GetString((byte[])bytes, 2, ((global::System.Array)bytes).Length - 2);
					case 0:
						return (System.Text.Encoding.Unicode).GetString((byte[])bytes, 2, ((global::System.Array)bytes).Length - 2);
					case 6:
						if (((short[])bytes)[0] == 254)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto IL_0143;
					case 4:
						if (((short[])bytes)[1] == 255)
						{
							num3 = 7;
							continue;
						}
						goto IL_0143;
					case 1:
						if (((short[])bytes)[0] == 239)
						{
							num = 2;
							break;
						}
						goto IL_00e5;
					case 8:
						{
							if (((short[])bytes)[0] == 255)
							{
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
								{
									num3 = 4;
								}
								continue;
							}
							goto IL_0187;
						}
						IL_0187:
						if (((global::System.Array)bytes).Length >= 2)
						{
							num3 = 6;
							continue;
						}
						goto IL_0143;
						IL_00e5:
						return (System.Text.Encoding.UTF8).GetString((byte[])bytes);
						IL_0143:
						if (((global::System.Array)bytes).Length >= 3)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto IL_00e5;
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
	public Ywk4YLpX8koXHso253m()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
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
					case 2:
						return;
					case 1:
						goto end_IL_000e;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num3 = 8;
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
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
						{
							num3 = 0;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 3;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool kR1DWqZhtAvEyvx0iAfO()
	{
		return jnYrvAZhHGRh5KXvvEUF == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Ywk4YLpX8koXHso253m AituF2ZhOO06jhsUdbk6()
	{
		return (Ywk4YLpX8koXHso253m)jnYrvAZhHGRh5KXvvEUF;
	}
}

using System;
using System.IO;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using fDAldojjppXrctUVYOJn;

namespace CFD1pGXF1c9jWWIUcMKS;

internal class PobfDxXFax0sxTwfPJif
{
	internal static object TO6RUNZRpwjT0ggoxwqO;

	[MethodImpl((MethodImplOptions)8)]
	internal static void Ensure(object junctionPath, object targetPath)
	{
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		int num = 10;
		string text = default(string);
		string text2 = default(string);
		FileAttributes attributes = default(FileAttributes);
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
						if (num2 != 23)
						{
							goto end_IL_000d;
						}
						goto case 4;
					case 16:
						if (!System.IO.Directory.Exists(text))
						{
							num3 = 12;
							continue;
						}
						goto case 11;
					case 11:
						if ((System.IO.Directory.EnumerateFileSystemEntries(text)).MoveNext())
						{
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
							{
								num3 = 1;
							}
							continue;
						}
						System.IO.Directory.Delete(text, false);
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
						{
							num3 = 4;
						}
						continue;
					case 3:
						throw string.Concat("客户端兼容入口目标不存在：", text2);
					case 0:
						if (!TryGetAttributes(text, out attributes))
						{
							num = 23;
							break;
						}
						goto case 7;
					case 8:
						if (!ResolvesTo(text, text2))
						{
							num = 13;
							break;
						}
						return;
					case 14:
						return;
					case 13:
						System.IO.Directory.Delete(text, false);
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
						{
							num3 = 8;
						}
						continue;
					case 15:
						return;
					case 4:
					case 6:
						System.IO.Directory.CreateDirectory(text);
						num3 = 2;
						continue;
					case 1:
					case 12:
						throw new global::System.Exception("客户端兼容入口被其他文件占用");
					case 7:
						if ((attributes & 0x400) != 0)
						{
							num3 = 8;
							continue;
						}
						goto case 16;
					case 9:
						text2 = NormalizePath(targetPath);
						num3 = 5;
						continue;
					case 5:
						if (System.IO.Directory.Exists(text2))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 3;
					case 2:
						try
						{
							CreateMountPoint(text, text2);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
							{
								num4 = 6;
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
									if (ResolvesTo(text, text2))
									{
										return;
									}
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
							throw new global::System.Exception("客户端兼容入口创建后未指向目标目录");
						}
						catch
						{
							int num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
							{
								num6 = 3;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 989)
									{
										num6 = num7;
										break;
									}
									goto case 1;
								case 1:
									TryDeleteJunction(text);
									num6 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
									{
										num6 = 0;
									}
									break;
								case 0:
									throw new global::System.Exception();
								}
							}
						}
					case 10:
						text = NormalizePath(junctionPath);
						num3 = 9;
						continue;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				if (num2 != 1004)
				{
					return;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool TryDeleteIfTargetMissing(object junctionPath)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num3 = default(int);
		FileAttributes attributes = default(FileAttributes);
		bool result = default(bool);
		string text3 = default(string);
		DirectoryInfo val = default(DirectoryInfo);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj4);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default(int);
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
					string text = NormalizePath(junctionPath);
					int num2 = 10;
					while (true)
					{
						string text2;
						object obj;
						switch (num2)
						{
						default:
							if (num3 == 25 || num3 != 1005)
							{
								break;
							}
							goto IL_0051;
						case 2:
							break;
						case 17:
							if ((attributes & 0x400) == 0)
							{
								num2 = 15;
								continue;
							}
							goto case 1;
						case 4:
						case 5:
							System.IO.Directory.Delete(text, false);
							num2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num2 = 10;
							}
							continue;
						case 3:
							break;
						case 7:
							result = true;
							num2 = 6;
							continue;
						case 9:
							text3 = (val).LinkTarget;
							num2 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
							{
								num2 = 8;
							}
							continue;
						case 0:
							result = false;
							num3 = 25;
							goto IL_0051;
						case 13:
							if (string.IsNullOrWhiteSpace(text3))
							{
								num2 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto case 14;
						case 15:
							result = false;
							num2 = 2;
							continue;
						case 1:
							val = (DirectoryInfo)(object)text;
							num2 = 9;
							continue;
						case 16:
							result = false;
							num2 = 3;
							continue;
						case 10:
							if (TryGetAttributes(text, out attributes))
							{
								num2 = 17;
								continue;
							}
							goto case 15;
						case 14:
							if (!System.IO.Path.IsPathRooted(text3))
							{
								num2 = 22;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
								{
									num2 = 8;
								}
								continue;
							}
							text2 = NormalizePath(text3);
							goto IL_02e5;
						case 8:
						{
							DirectoryInfo obj2 = (val).Parent;
							if (obj2 == null)
							{
								num2 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
								{
									num2 = 12;
								}
								continue;
							}
							obj = (obj2).FullName;
							goto IL_02b0;
						}
						case 12:
							obj = null;
							goto IL_02b0;
						case 11:
							obj = text;
							goto IL_02c3;
						case 6:
							break;
							IL_02e5:
							if (!System.IO.Directory.Exists(text2))
							{
								num2 = 15;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
								{
									num2 = 5;
								}
								continue;
							}
							goto case 16;
							IL_02b0:
							if (obj == null)
							{
								num2 = 11;
								continue;
							}
							goto IL_02c3;
							IL_02c3:
							text2 = NormalizePath(System.IO.Path.Combine((string)obj, text3));
							goto IL_02e5;
							IL_0051:
							num2 = num3;
							continue;
						}
						break;
					}
				}
				catch (object obj3) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj4 = obj3 as global::System.Exception;
					if (obj4 == null)
					{
						num4 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
						{
							num4 = 8;
						}
					}
					else
					{
						ex = obj4;
						num4 = 7;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 21 && num5 == 1001)
							{
								goto IL_0356;
							}
							goto case 3;
						case 4:
							if (ex is DirectoryNotFoundException)
							{
								num5 = 21;
								goto IL_0356;
							}
							goto case 1;
						case 11:
							if (ex is ArgumentException)
							{
								num4 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
								{
									num4 = 2;
								}
								continue;
							}
							goto case 8;
						case 1:
							if (ex is IOException)
							{
								num4 = 12;
								continue;
							}
							goto case 10;
						case 8:
							if (ex is NotSupportedException)
							{
								num4 = 3;
								continue;
							}
							goto case 2;
						case 10:
							if (!(ex is UnauthorizedAccessException))
							{
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
								{
									num4 = 16;
								}
								continue;
							}
							goto case 3;
						case 3:
						case 5:
						case 12:
						case 13:
							flag = true;
							num4 = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
							{
								num4 = 0;
							}
							continue;
						case 7:
							if (ex is FileNotFoundException)
							{
								num4 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
								{
									num4 = 3;
								}
								continue;
							}
							goto case 4;
						case 2:
							flag = false;
							num4 = 6;
							continue;
						case 9:
							result2 = 0;
							break;
						case 0:
						case 6:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0356:
							num4 = num5;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num6 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
					{
						num6 = 0;
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
						case 0:
							result = false;
							num6 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num6 = 1;
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
	private static void CreateMountPoint(object junctionPath, object targetPath)
	{
		int num = 10;
		byte[] array = default(byte[]);
		int num8 = default(int);
		byte[] array3 = default(byte[]);
		string text = default(string);
		SafeFileHandle val = default(SafeFileHandle);
		byte[] array2 = default(byte[]);
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
						if (num2 != 21)
						{
							if (num2 == 1002)
							{
								goto end_IL_000d;
							}
							goto case 10;
						}
						array = new byte[16 + num8];
						num = 6;
						break;
					case 13:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 10, 2), checked((ushort)array3.Length));
						num3 = 8;
						continue;
					case 7:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 4, 2), checked((ushort)(8 + num8)));
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
						{
							num3 = 8;
						}
						continue;
					case 4:
						return;
					case 9:
						array3 = (System.Text.Encoding.Unicode).GetBytes(text);
						num3 = 11;
						continue;
					case 8:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 12, 2), checked((ushort)(array3.Length + 2)));
						num3 = 21;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
						{
							num3 = 5;
						}
						continue;
					case 14:
						val = CreateFileW((string)junctionPath, 1073741824u, 7u, global::nint.Zero, 3u, 35651584u, global::nint.Zero);
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd != 0)
						{
							num3 = 13;
						}
						continue;
					case 0:
						(array2).CopyTo(array, 16 + array3.Length + 2);
						num3 = 14;
						continue;
					case 10:
						text = string.Concat("\\??\\", (string)targetPath);
						num3 = 9;
						continue;
					case 3:
						num8 = array3.Length + 2 + array2.Length + 2;
						num = 21;
						break;
					case 2:
						(array3).CopyTo(array, 16);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
						{
							num3 = 7;
						}
						continue;
					case 6:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt32LittleEndian(MemoryExtensions.AsSpan<byte>(array, 0, 4), 2684354563u);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num3 = 1;
						}
						continue;
					case 12:
						try
						{
							if (!(val).IsInvalid)
							{
								int num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4449281a514d4628ace51b6c60d5ea2c == 0)
								{
									num4 = 1;
								}
								while (true)
								{
									switch (num4)
									{
									case 2:
										return;
									default:
										if (num5 == 991)
										{
											num4 = num5;
											continue;
										}
										goto case 1;
									case 3:
										break;
									case 0:
									{
										if (DeviceIoControl(val, 589988u, array, array.Length, global::nint.Zero, 0, out var _, global::nint.Zero))
										{
											num4 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
											{
												num4 = 0;
											}
											continue;
										}
										goto case 1;
									}
									case 1:
										_ = "无法创建客户端兼容入口";
										throw System.Runtime.InteropServices.Marshal.GetLastWin32Error();
									}
									break;
								}
							}
							_ = "无法打开客户端兼容入口";
							throw System.Runtime.InteropServices.Marshal.GetLastWin32Error();
						}
						finally
						{
							if (val != null)
							{
								int num6 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
								{
									num6 = 2;
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
									case 0:
										(val).Dispose();
										num6 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
										{
											num6 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
					case 1:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 8, 2), 0);
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
						{
							num3 = 13;
						}
						continue;
					case 11:
						array2 = (System.Text.Encoding.Unicode).GetBytes((string)targetPath);
						num3 = 3;
						continue;
					case 5:
						System.Buffers.Binary.BinaryPrimitives.WriteUInt16LittleEndian(MemoryExtensions.AsSpan<byte>(array, 14, 2), checked((ushort)array2.Length));
						num3 = 2;
						continue;
					}
					goto end_IL_0009;
					continue;
					end_IL_000d:
					break;
				}
				continue;
				end_IL_0009:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool ResolvesTo(object junctionPath, object targetPath)
	{
		int num = 1;
		int num3 = default(int);
		bool result = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
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
					FileSystemInfo val = System.IO.Directory.ResolveLinkTarget((string)junctionPath, true);
					int num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
					{
						num2 = 3;
					}
					while (true)
					{
						int num4;
						switch (num2)
						{
						default:
							if (num3 == 991)
							{
								num2 = num3;
								continue;
							}
							goto case 0;
						case 1:
							num4 = (string.Equals(NormalizePath((val).FullName), (string)targetPath, (StringComparison)5) ? 1 : 0);
							break;
						case 2:
							if (val == null)
							{
								num2 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
								{
									num2 = 6;
								}
								continue;
							}
							goto case 1;
						case 0:
							num4 = 0;
							break;
						case 3:
							goto end_IL_0070;
						}
						result = (byte)num4 != 0;
						num2 = 3;
						continue;
						end_IL_0070:
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce == 0)
						{
							num5 = 1;
						}
					}
					else
					{
						ex = obj2;
						num5 = 7;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 18 && num6 == 998)
							{
								goto IL_0159;
							}
							goto case 8;
						case 7:
							if (ex is IOException)
							{
								num6 = 18;
								goto IL_0159;
							}
							goto case 5;
						case 5:
							if (!(ex is UnauthorizedAccessException))
							{
								num5 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
								{
									num5 = 2;
								}
								continue;
							}
							goto case 8;
						case 3:
							if (!(ex is NotSupportedException))
							{
								num5 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
								{
									num5 = 6;
								}
								continue;
							}
							goto case 8;
						case 2:
							if (ex is ArgumentException)
							{
								num5 = 8;
								continue;
							}
							goto case 3;
						case 0:
						case 6:
							flag = false;
							num5 = 9;
							continue;
						case 8:
						case 10:
							flag = true;
							num5 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
							{
								num5 = 4;
							}
							continue;
						case 1:
							result2 = 0;
							break;
						case 4:
						case 9:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0159:
							num5 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num7 = 1;
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
							break;
						case 0:
							goto end_IL_0326;
						}
						result = false;
						num7 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num7 = 0;
						}
						continue;
						end_IL_0326:
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
	private static bool TryGetAttributes(object path, out FileAttributes attributes)
	{
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected I4, but got Unknown
		int num = 1;
		int num3 = default(int);
		bool result = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					attributes = (FileAttributes)(int)System.IO.File.GetAttributes((string)path);
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 != 0)
					{
						num2 = 0;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							goto end_IL_006c;
						}
						result = true;
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 != 0)
						{
							num2 = 6;
						}
						continue;
						end_IL_006c:
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num4 = 7;
					}
					else
					{
						ex = obj2;
						num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num4 = 4;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 != 16)
							{
								if (num5 == 996)
								{
									goto IL_00dc;
								}
							}
							else if (!(ex is IOException))
							{
								num4 = 6;
								continue;
							}
							goto case 3;
						case 1:
							if (ex is FileNotFoundException)
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
								{
									num4 = 5;
								}
								continue;
							}
							goto case 0;
						case 0:
							if (!(ex is DirectoryNotFoundException))
							{
								num6 = 16;
								goto IL_00d8;
							}
							goto case 3;
						case 3:
						case 5:
							flag = true;
							num4 = 8;
							continue;
						case 6:
							if (ex is UnauthorizedAccessException)
							{
								num4 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2263e5e2bf224536a787d62e2adc9e0e == 0)
								{
									num4 = 3;
								}
								continue;
							}
							goto case 2;
						case 2:
							flag = false;
							num6 = 4;
							goto IL_00d8;
						case 7:
							result2 = 0;
							break;
						case 4:
						case 8:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_00dc:
							num4 = num5;
							continue;
							IL_00d8:
							num5 = num6;
							goto IL_00dc;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num7 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
					{
						num7 = 7;
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
							goto case 1;
						case 1:
							result = false;
							num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num7 = 4;
							}
							continue;
						case 2:
							attributes = (FileAttributes)0;
							num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
							{
								num7 = 1;
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
		attributes = default;
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void TryDeleteJunction(object path)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num8 = default(int);
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
				int num2;
				if (!TryGetAttributes(path, out var _))
				{
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
					{
						num2 = 0;
					}
					goto IL_006c;
				}
				goto IL_0090;
				IL_006c:
				while (true)
				{
					switch (num2)
					{
					default:
						if (num3 == 990)
						{
							goto IL_0068;
						}
						break;
					case 1:
						break;
					case 0:
						return;
					case 2:
						return;
					}
					break;
					IL_0068:
					num2 = num3;
				}
				goto IL_0090;
				IL_0090:
				System.IO.Directory.Delete((string)path, false);
				num2 = 2;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
				{
					num2 = 2;
				}
				goto IL_006c;
			}
			catch (object obj) when (((Func<bool>)delegate
			{
				// Could not convert BlockContainer to single expression
				obj2 = obj as global::System.Exception;
				if (obj2 == null)
				{
					num4 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
					{
						num4 = 13;
					}
				}
				else
				{
					ex = obj2;
					num4 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
					{
						num4 = 7;
					}
				}
				while (true)
				{
					switch (num4)
					{
					default:
						if (num6 != 13)
						{
							if (num6 == 993)
							{
								goto IL_0122;
							}
							goto case 4;
						}
						goto case 3;
					case 2:
						flag = true;
						num5 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num5 = 2;
						}
						num6 = num5;
						goto IL_0122;
					case 4:
						if (ex is UnauthorizedAccessException)
						{
							num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num4 = 2;
							}
							continue;
						}
						goto case 5;
					case 5:
						flag = false;
						num4 = 3;
						continue;
					case 1:
						if (!(ex is IOException))
						{
							num4 = 4;
							continue;
						}
						goto case 2;
					case 0:
						result = 0;
						break;
					case 3:
						{
							result = (flag ? 1 : 0);
							break;
						}
						IL_0122:
						num4 = num6;
						continue;
					}
					break;
				}
				return (byte)result != 0;
			}).Invoke())
			{
				int num7 = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
				{
					num7 = 0;
				}
				while (true)
				{
					switch (num7)
					{
					case 0:
						return;
					}
					if (num8 == 988)
					{
						num7 = num8;
						continue;
					}
					return;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string NormalizePath(object path)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[DllImport("kernel32.dll", CharSet = (CharSet)3, SetLastError = true)]
	private static extern SafeFileHandle CreateFileW(string fileName, uint desiredAccess, uint shareMode, nint securityAttributes, uint creationDisposition, uint flagsAndAttributes, nint templateFile);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool DeviceIoControl(SafeFileHandle device, uint controlCode, byte[] inputBuffer, int inputBufferSize, nint outputBuffer, int outputBufferSize, out uint bytesReturned, nint overlapped);

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
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
						{
							num3 = 7;
						}
						continue;
					case 2:
						return;
					case 0:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
						{
							num3 = 9;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
			{
				num = 3;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool gL8g5FZRuMpXp8KnjbwS()
	{
		return TO6RUNZRpwjT0ggoxwqO == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PobfDxXFax0sxTwfPJif xApJXEZRagm2ZLbHRRYc()
	{
		return (PobfDxXFax0sxTwfPJif)TO6RUNZRpwjT0ggoxwqO;
	}
}

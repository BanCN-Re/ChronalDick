using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using CZUx5njfSrbl1tnMcUCO;
using Microsoft.Win32.SafeHandles;
using OWRumnXNe7U48tXBXFAY;
using fDAldojjppXrctUVYOJn;

namespace Gl0cCvfXEsOfq189jtn8;

internal class j6Lt1ofXvNtOOahC6qtt
{
	private struct x3YZWhLSZFyXD9JFI8XX
	{
		internal uint lhSLS9FMbIZ;

		internal FILETIME GMCLSDV4pnH;

		internal FILETIME RxMLSk5M5er;

		internal FILETIME YylLSVlyTi8;

		internal uint mgDLSYRcK1v;

		internal uint pJvLSSga9L3;

		internal uint JHHLScuFAQS;

		internal uint QGVLS051oSQ;

		internal uint sd6LS8SSK3d;

		internal uint igxLSyRGAno;
	}

	internal static object Wsj1WnZs1LA4bGafOTSU;

	[DllImport("kernel32.dll", CharSet = (CharSet)3, EntryPoint = "CreateFileW", SetLastError = true)]
	private static extern SafeFileHandle TFJfX2ACPA1(string path, uint access, FileShare share, nint security, uint mode, uint flags, nint template);

	[DllImport("kernel32.dll", EntryPoint = "GetFileInformationByHandle", SetLastError = true)]
	[return: MarshalAs((UnmanagedType)2)]
	private static extern bool hdkfXqgMYiS(SafeFileHandle handle, out x3YZWhLSZFyXD9JFI8XX information);

	[MethodImpl((MethodImplOptions)8)]
	internal static SafeFileHandle cAofXGnGP4E(object path, bool allowRename = false)
	{
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		uint access = default(uint);
		SafeFileHandle result = default(SafeFileHandle);
		SafeFileHandle val = default(SafeFileHandle);
		int num6 = default(int);
		x3YZWhLSZFyXD9JFI8XX information = default(x3YZWhLSZFyXD9JFI8XX);
		int num8 = default(int);
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
								goto end_IL_000d;
							}
							goto case 1;
						}
						access = (uint)(0x80 | (allowRename ? 65536 : 0));
						num3 = 2;
						continue;
					case 1:
						return result;
					case 3:
						break;
					case 0:
						try
						{
							if ((val).IsInvalid)
							{
								goto IL_011c;
							}
							int num4 = 4;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 != 12)
									{
										if (num6 == 992)
										{
											goto IL_0095;
										}
										goto case 1;
									}
									goto case 0;
								case 1:
									if ((information.lhSLS9FMbIZ & 0x400) != 0)
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
										{
											num4 = 11;
										}
									}
									else
									{
										result = val;
										num4 = 2;
									}
									continue;
								case 4:
									if (!hdkfXqgMYiS(val, out information))
									{
										num4 = 3;
										continue;
									}
									if ((information.lhSLS9FMbIZ & 0x10) == 0)
									{
										int num5 = 12;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
										{
											num5 = 1;
										}
										num6 = num5;
										goto IL_0095;
									}
									goto case 1;
								case 3:
									break;
								case 0:
									throw new IOException("缓存目录不能是重解析点或普通文件");
								case 2:
									goto end_IL_0099;
									IL_0095:
									num4 = num6;
									continue;
								}
								goto IL_011c;
								continue;
								end_IL_0099:
								break;
							}
							goto end_IL_006c;
							IL_011c:
							throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error(), "无法锁定缓存目录身份");
							end_IL_006c:;
						}
						catch
						{
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num7 = 7;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										break;
									}
									goto case 0;
								case 0:
									(val).Dispose();
									num7 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
									{
										num7 = 6;
									}
									break;
								case 1:
									throw;
								}
							}
						}
						goto case 1;
					case 2:
						val = TFJfX2ACPA1((string)path, access, (FileShare)(3 | (allowRename ? 4 : 0)), 0, 3u, 35651584u, 0);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
						{
							num3 = 3;
						}
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
			KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(path);
			num = 4;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void d1yfXipNsmt(object original, object path)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num5 = default(int);
		x3YZWhLSZFyXD9JFI8XX information2 = default(x3YZWhLSZFyXD9JFI8XX);
		SafeFileHandle val = default(SafeFileHandle);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_001e;
				case 2:
					return;
				case 0:
					try
					{
						int num3;
						if (!hdkfXqgMYiS((SafeFileHandle)original, out var information))
						{
							num3 = 5;
							goto IL_005c;
						}
						goto IL_00db;
						IL_0110:
						throw new Win32Exception(System.Runtime.InteropServices.Marshal.GetLastWin32Error());
						IL_005c:
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 13)
								{
									if (num5 == 993)
									{
										goto IL_0058;
									}
									goto IL_0110;
								}
								if (information.sd6LS8SSK3d == information2.sd6LS8SSK3d)
								{
									num4 = 4;
									goto IL_0054;
								}
								goto IL_0161;
							case 4:
								if (information.igxLSyRGAno == information2.igxLSyRGAno)
								{
									return;
								}
								num3 = 3;
								continue;
							case 1:
								break;
							case 0:
							case 5:
								goto IL_0110;
							case 2:
								if (information.mgDLSYRcK1v == information2.mgDLSYRcK1v)
								{
									num4 = 13;
									goto IL_0054;
								}
								goto IL_0161;
							case 3:
								goto IL_0161;
								IL_0058:
								num3 = num5;
								continue;
								IL_0054:
								num5 = num4;
								goto IL_0058;
							}
							break;
							IL_0161:
							throw new IOException("缓存目录在清理期间被替换，已停止删除");
						}
						goto IL_00db;
						IL_00db:
						if (hdkfXqgMYiS(val, out information2))
						{
							num3 = 2;
							goto IL_005c;
						}
						goto IL_0110;
					}
					finally
					{
						if (val != null)
						{
							int num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
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
									goto end_IL_01c5;
								}
								(val).Dispose();
								num6 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
								{
									num6 = 0;
								}
								continue;
								end_IL_01c5:
								break;
							}
						}
					}
				case 1:
					break;
				}
				goto IL_0230;
				IL_001e:
				if (num == 990)
				{
					break;
				}
				goto IL_0230;
				IL_0230:
				val = cAofXGnGP4E(path);
				num2 = 6;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void YPufXncPMds(object path, object boundary)
	{
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Unknown result type (might be due to invalid IL or missing references)
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0451: Unknown result type (might be due to invalid IL or missing references)
		int num = 13;
		FileAttributes val = default(FileAttributes);
		SafeFileHandle val2 = default(SafeFileHandle);
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
		int num13 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num14);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		int num16 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num18 = default(int);
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
						if (num2 != 26)
						{
							goto end_IL_000d;
						}
						goto IL_017c;
					case 10:
						throw new IOException("不能将磁盘根目录作为缓存删除边界");
					case 15:
						System.IO.Directory.Delete((string)path, false);
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						if (!((dynamic)(path)).StartsWith(string.Concat(((System.ReadOnlySpan<char>)(string)boundary), new global::System.ReadOnlySpan<char>(new char[] { Path.DirectorySeparatorChar })), (StringComparison)5))
						{
							num3 = 4;
							break;
						}
						goto IL_017c;
					case 1:
						System.IO.Directory.Delete((string)path, false);
						num3 = 14;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
						{
							num3 = 2;
						}
						break;
					case 14:
						return;
					case 4:
						throw new IOException("缓存删除路径越界");
					case 19:
						if ((val & (FileAttributes)(0x400)) != 0)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
							{
								num3 = 8;
							}
						}
						else if ((val & (FileAttributes)(0x10)) == 0)
						{
							num3 = 11;
						}
						else
						{
							val2 = cAofXGnGP4E(path);
							num3 = 9;
						}
						break;
					case 9:
						try
						{
							global::System.Collections.Generic.IEnumerator<string> enumerator = System.IO.Directory.EnumerateFileSystemEntries((string)path).GetEnumerator();
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
							{
								num4 = 4;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										goto IL_01f3;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_01f3:
								num4 = num5;
							}
							try
							{
								while (true)
								{
									int num6;
									if (!(enumerator).MoveNext())
									{
										num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
										{
											num6 = 3;
										}
										goto IL_0235;
									}
									goto IL_0289;
									IL_0289:
									YPufXncPMds(enumerator.Current, boundary);
									num6 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
									{
										num6 = 1;
									}
									goto IL_0235;
									IL_0235:
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 990)
											{
												num6 = num7;
												continue;
											}
											goto IL_0289;
										case 1:
											break;
										case 2:
											goto IL_0289;
										case 0:
											goto end_IL_0259;
										}
										break;
									}
									continue;
									end_IL_0259:
									break;
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num8 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
									{
										num8 = 2;
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
											(enumerator).Dispose();
											num8 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e != 0)
											{
												num8 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num10 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
								{
									num10 = 6;
								}
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 989)
										{
											num10 = num11;
											continue;
										}
										break;
									case 1:
										(val2).Dispose();
										num10 = 7;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
										{
											num10 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 5;
					case 13:
						path = System.IO.Path.GetFullPath((string)path);
						num3 = 12;
						break;
					case 0:
						return;
					case 16:
						System.IO.File.Delete((string)path);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 == 0)
						{
							num3 = 20;
						}
						break;
					case 6:
						if ((val & (FileAttributes)(0x10)) == 0)
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
							{
								num3 = 18;
							}
							break;
						}
						goto case 15;
					case 7:
						return;
					case 3:
						System.IO.File.Delete((string)path);
						num3 = 17;
						break;
					case 18:
						try
						{
							val = System.IO.File.GetAttributes((string)path);
							int num12 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
							{
								num12 = 0;
							}
							while (true)
							{
								switch (num12)
								{
								default:
									if (num13 == 988)
									{
										num12 = num13;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (global::System.Exception obj2) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj3 = obj2 as global::System.Exception;
							if (obj3 == null)
							{
								num14 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
								{
									num14 = 0;
								}
								goto IL_0513;
							}
							ex = obj3;
							num15 = 4;
							goto IL_050b;
							IL_050b:
							num16 = num15;
							goto IL_050f;
							IL_0513:
							while (true)
							{
								switch (num14)
								{
								default:
									if (num16 != 15)
									{
										if (num16 == 995)
										{
											goto IL_050f;
										}
										goto case 6;
									}
									goto case 5;
								case 4:
									if (ex is FileNotFoundException)
									{
										num14 = 6;
										break;
									}
									goto case 1;
								case 1:
									if (!(ex is DirectoryNotFoundException))
									{
										goto end_IL_0513;
									}
									goto case 6;
								case 6:
								case 7:
									flag = true;
									num14 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
									{
										num14 = 3;
									}
									break;
								case 5:
									flag = false;
									num14 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
									{
										num14 = 2;
									}
									break;
								case 0:
									result = 0;
									goto IL_0637;
								case 2:
								case 3:
									{
										result = (flag ? 1 : 0);
										goto IL_0637;
									}
									IL_0637:
									return (byte)result != 0;
								}
								continue;
								end_IL_0513:
								break;
							}
							num15 = 15;
							goto IL_050b;
							IL_050f:
							num14 = num16;
							goto IL_0513;
						}).Invoke())
						{
							int num17 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
							{
								num17 = 6;
							}
							while (true)
							{
								switch (num17)
								{
								case 0:
									return;
								}
								if (num18 != 988)
								{
									return;
								}
								num17 = num18;
							}
						}
						goto case 19;
					case 11:
						System.IO.File.SetAttributes((string)path, (FileAttributes)(val & (FileAttributes)(-2)));
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
						{
							num3 = 0;
						}
						break;
					case 12:
						boundary = (System.IO.Path.GetFullPath((string)boundary)).TrimEnd(Path.DirectorySeparatorChar);
						num3 = 25;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
						{
							num3 = 8;
						}
						break;
					case 5:
						System.IO.File.SetAttributes((string)path, (FileAttributes)(val & (FileAttributes)(-2)));
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
						{
							num3 = 17;
						}
						break;
					case 17:
						return;
					case 8:
						{
							object obj = boundary;
							string text = System.IO.Path.GetPathRoot((string)boundary);
							if (!string.Equals((string)obj, (text != null) ? (text).TrimEnd(Path.DirectorySeparatorChar) : null, (StringComparison)5))
							{
								if (string.Equals((string)path, (string)boundary, (StringComparison)5))
								{
									goto end_IL_0009;
								}
								goto case 2;
							}
							num3 = 10;
							break;
						}
						IL_017c:
						num3 = 18;
						break;
					}
					continue;
					end_IL_000d:
					break;
				}
				if (num2 != 1007)
				{
					return;
				}
				continue;
				end_IL_0009:
				break;
			}
			num = 26;
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
	internal static bool SoduLaZs3exmAPEtUqPf()
	{
		return Wsj1WnZs1LA4bGafOTSU == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static j6Lt1ofXvNtOOahC6qtt gYGBYJZsvxwVPeNQ6UlW()
	{
		return (j6Lt1ofXvNtOOahC6qtt)Wsj1WnZs1LA4bGafOTSU;
	}
}

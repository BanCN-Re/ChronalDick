using System;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace YKuUPlXMvoPCm0jD3Ccj;

internal sealed class Gpxk5JXM3EbpMstYufnt : global::System.IDisposable
{
	private readonly object yKWXMGAhpdX;

	private FileStream? bkmXMibPPyi;

	[CompilerGenerated]
	private readonly string la3XMngURBb;

	internal static object eB1R6TZeVZYrbslnYKP3;

	internal string StagingPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return la3XMngURBb;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private Gpxk5JXM3EbpMstYufnt(string stagingPath, string lockPath, FileStream lockStream)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Gpxk5JXM3EbpMstYufnt N6pXMElrQBT(object stagingPath)
	{
		//IL_0117: Expected O, but got I4
		int num = 4;
		string text2 = default(string);
		string lockPath = default(string);
		FileStream val = default(FileStream);
		int num5 = default(int);
		Gpxk5JXM3EbpMstYufnt result = default(Gpxk5JXM3EbpMstYufnt);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 0;
						}
						string text = System.IO.Path.GetDirectoryName(text2);
						if (text == null)
						{
							num3 = 5;
							continue;
						}
						System.IO.Directory.CreateDirectory(text);
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
						{
							num3 = 0;
						}
						continue;
					}
					case 0:
						lockPath = string.Concat(text2, ".chronal-install.lock");
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
						{
							num3 = 4;
						}
						continue;
					case 1:
						_ = "客户端暂存目录不能为空";
						throw new global::System.Exception("stagingPath");
					case 3:
						break;
					case 7:
						try
						{
							_ = 1;
							_ = 3;
							_ = 0;
							_ = 1;
							val = (FileStream)(object)(-2147483648);
							int num4 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb == 0)
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
									break;
								case 0:
									result = (Gpxk5JXM3EbpMstYufnt)new Gpxk5JXM3EbpMstYufnt(text2, lockPath, val);
									num4 = 2;
									continue;
								case 1:
									break;
								case 2:
									goto end_IL_0148;
								}
								System.IO.Directory.CreateDirectory(text2);
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
								{
									num4 = 7;
								}
								continue;
								end_IL_0148:
								break;
							}
						}
						catch
						{
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num6 = 1;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 != 11)
									{
										if (num7 != 991)
										{
											break;
										}
										goto IL_01e2;
									}
									goto case 0;
								case 1:
									if (val == null)
									{
										num6 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
										{
											num6 = 0;
										}
										continue;
									}
									goto case 2;
								case 2:
									(val).Dispose();
									num7 = 11;
									goto IL_01e2;
								case 0:
									NaeXM2Bof5p(lockPath);
									num6 = 3;
									continue;
								case 3:
									break;
									IL_01e2:
									num6 = num7;
									continue;
								}
								break;
							}
							throw new global::System.Exception();
						}
						goto case 2;
					case 6:
						val = null;
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
						{
							num3 = 7;
						}
						continue;
					case 4:
						if (!string.IsNullOrWhiteSpace((string)stagingPath))
						{
							num3 = 3;
							continue;
						}
						goto case 1;
					case 2:
						return result;
					case 5:
						throw new global::System.Exception("无法定位客户端暂存目录的父目录");
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
			text2 = System.IO.Path.GetFullPath((string)stagingPath);
			num = 14;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
			{
				num = 13;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 1;
		FileStream val = default(FileStream);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						bkmXMibPPyi = null;
						num3 = 2;
						continue;
					case 4:
						return;
					case 1:
						val = bkmXMibPPyi;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						break;
					case 2:
						try
						{
							(val).Dispose();
							int num4 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								case 0:
									return;
								}
								if (num5 == 988)
								{
									num4 = num5;
									continue;
								}
								return;
							}
						}
						finally
						{
							NaeXM2Bof5p(yKWXMGAhpdX);
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
							{
								num6 = 5;
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
					case 3:
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
			if (val == null)
			{
				break;
			}
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe != 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void NaeXM2Bof5p(object lockPath)
	{
		int num = 1;
		int num3 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num4);
		int num5 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num7 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					if (!System.IO.File.Exists((string)lockPath))
					{
						return;
					}
					int num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 1:
							break;
						}
						System.IO.File.Delete((string)lockPath);
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
						{
							num2 = 2;
						}
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					if (!(obj is global::System.Exception))
					{
						num4 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num4 = 1;
						}
					}
					else
					{
						num4 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 != 0)
						{
							num4 = 0;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 989)
							{
								goto IL_0100;
							}
							goto case 0;
						case 1:
							result = 0;
							break;
						case 0:
							result = (System.IO.File.Exists((string)lockPath) ? 1 : 0);
							break;
						}
						break;
						IL_0100:
						num4 = num5;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num6 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
					{
						num6 = 4;
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
						{
							num3 = 3;
						}
						continue;
					case 2:
						break;
					case 0:
						num3 = 2;
						continue;
					}
					goto end_IL_000e;
					continue;
					end_IL_0012:
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool E7s4ZDZeYrgtBOfdCtDH()
	{
		return eB1R6TZeVZYrbslnYKP3 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Gpxk5JXM3EbpMstYufnt YqomwSZeStOdGIGDF9Hn()
	{
		return (Gpxk5JXM3EbpMstYufnt)eB1R6TZeVZYrbslnYKP3;
	}
}

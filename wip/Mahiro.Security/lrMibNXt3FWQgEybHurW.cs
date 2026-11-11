using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using r7Ie1ifM7owYurGstPtD;
using uGYGhCXK1nRsID9XQ5mf;

namespace TLw7DvXtvU7XnuQsHfFC;

sealed class lrMibNXt3FWQgEybHurW : global::System.IDisposable
{
	private static readonly object h0qXObD2yS6;

	private uY2l6VfMmfM34jZlW4GQ? uPXXOXDbLAI;

	private bool dnTXOfm5CyI;

	private static object koLRx6Z52hUUdA3cY4D3;

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<uY2l6VfMmfM34jZlW4GQ> q8OXtEOHPBR(CancellationToken cancellationToken = default(CancellationToken))
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<uY2l6VfMmfM34jZlW4GQ> LucXt2c7h3J(CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void yHZXtqsKZgU(object package)
	{
		int num = 5;
		bool flag = default(bool);
		string text2 = default(string);
		bool flag2 = default(bool);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					int num4;
					switch (num3)
					{
					default:
						if (num2 != 43)
						{
							if (num2 == 1024)
							{
								goto end_IL_0010;
							}
							goto case 22;
						}
						goto case 17;
					case 20:
						throw new global::System.Exception("基岩版游戏包校验值无效");
					case 17:
						flag = (text2).Length == 32;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 != 0)
						{
							num3 = 32;
						}
						continue;
					case 2:
					case 35:
						flag = (text2).Length == 64;
						num = 30;
						break;
					case 16:
						if (!flag2)
						{
							num = 34;
							break;
						}
						goto case 33;
					case 7:
					case 11:
					case 18:
					case 27:
						throw new global::System.Exception("基岩版游戏包清单字段不完整");
					case 15:
						text = ((((uY2l6VfMmfM34jZlW4GQ)package).ChecksumAlgorithm).Trim()).ToUpperInvariant();
						num3 = 43;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num3 = 29;
						}
						continue;
					case 28:
						throw new global::System.Exception("基岩版游戏包补丁清单地址未经允许");
					case 23:
						if (((uY2l6VfMmfM34jZlW4GQ)package).PatchManifestUri != null)
						{
							num3 = 22;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
							{
								num3 = 39;
							}
							continue;
						}
						num4 = 0;
						goto IL_05e5;
					case 24:
						if (string.IsNullOrWhiteSpace(((uY2l6VfMmfM34jZlW4GQ)package).ExecutableRelativePath))
						{
							num3 = 7;
							continue;
						}
						goto case 14;
					case 3:
					case 13:
						flag = false;
						num3 = 8;
						continue;
					case 8:
					case 30:
					case 32:
						if (flag)
						{
							num3 = 25;
							continue;
						}
						goto case 20;
					case 4:
						if (!i5uXtGGN5VG(((uY2l6VfMmfM34jZlW4GQ)package).DownloadUri))
						{
							num3 = 40;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num3 = 9;
							}
							continue;
						}
						if (((uY2l6VfMmfM34jZlW4GQ)package).PatchManifestUri != null)
						{
							num3 = 26;
							continue;
						}
						goto case 23;
					case 12:
						if (!(text == "SHA-256"))
						{
							goto case 3;
						}
						num3 = 34;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
						{
							num3 = 2;
						}
						continue;
					case 31:
						if (!string.IsNullOrWhiteSpace(((uY2l6VfMmfM34jZlW4GQ)package).ArchiveFileName))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 24;
							}
							continue;
						}
						goto case 7;
					case 10:
						if (!(text == "SHA256"))
						{
							num3 = 16;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
							{
								num3 = 12;
							}
							continue;
						}
						goto case 2;
					case 29:
						text2 = YuH7lNXKa7yogRawUHf7.tDnXKvJoEDy(((uY2l6VfMmfM34jZlW4GQ)package).Checksum);
						num3 = 16;
						continue;
					case 5:
						System.ArgumentNullException.ThrowIfNull(package, "package");
						num3 = 4;
						continue;
					case 26:
						if (bNRXtiydvUx(((uY2l6VfMmfM34jZlW4GQ)package).PatchManifestUri))
						{
							num3 = 23;
							continue;
						}
						goto case 28;
					case 25:
						if (CrWXtn3Uwio(text2))
						{
							return;
						}
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
						{
							num3 = 20;
						}
						continue;
					case 19:
						return;
					case 1:
					case 34:
						if ((text == "MD5"))
						{
							num = 43;
							break;
						}
						goto case 10;
					case 14:
						if (string.IsNullOrWhiteSpace(((uY2l6VfMmfM34jZlW4GQ)package).ChecksumAlgorithm))
						{
							num3 = 27;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 36;
					case 22:
						num4 = (((((uY2l6VfMmfM34jZlW4GQ)package).DownloadUri).AbsolutePath).EndsWith(".zip", (StringComparison)5) ? 1 : 0);
						goto IL_05e5;
					case 33:
						if ((text2).Length == 0)
						{
							return;
						}
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
						{
							num3 = 5;
						}
						continue;
					case 36:
						if (!flag2)
						{
							num3 = 40;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto case 21;
					case 9:
						throw new global::System.Exception("基岩版游戏包清单包含未经允许的下载地址");
					case 0:
						if (string.IsNullOrWhiteSpace(((uY2l6VfMmfM34jZlW4GQ)package).Version))
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 31;
					case 6:
						if (!string.IsNullOrWhiteSpace(((uY2l6VfMmfM34jZlW4GQ)package).Checksum))
						{
							num3 = 33;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
							{
								num3 = 21;
							}
							continue;
						}
						goto case 7;
					case 21:
						{
							if (((uY2l6VfMmfM34jZlW4GQ)package).RequiredFreeSpaceBytes > 0)
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num3 = 15;
								}
								continue;
							}
							goto case 7;
						}
						IL_05e5:
						flag2 = (byte)num4 != 0;
						num3 = 29;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool i5uXtGGN5VG(object uri)
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
								goto end_IL_0010;
							}
							goto case 1;
						}
						goto IL_00c7;
					case 1:
						if (bNRXtiydvUx(uri))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto IL_00f9;
					case 0:
						if (!((uri).AbsolutePath).EndsWith(".7z", (StringComparison)5))
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto IL_00c7;
					case 2:
						{
							if (((uri).AbsolutePath).EndsWith(".zip", (StringComparison)5))
							{
								break;
							}
							goto IL_00f9;
						}
						IL_00f9:
						return false;
						IL_00c7:
						return ((uri).AbsoluteUri).Contains("Win64", (StringComparison)5);
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool bNRXtiydvUx(object uri)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool CrWXtn3Uwio(object value)
	{
		int num = 2;
		int num4 = default(int);
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
						if (num2 != 13)
						{
							if (num2 == 994)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						goto case 3;
					case 3:
						if (num4 < (text).Length)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						goto case 6;
					case 2:
						text = (string)value;
						num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num3 = 1;
						}
						continue;
					case 6:
						return true;
					case 1:
						break;
					case 0:
						return false;
					case 4:
					case 5:
						if (System.Uri.IsHexDigit((text).Chars))
						{
							num4++;
							num3 = 3;
							continue;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
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
			num4 = 0;
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		int num = 1;
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					dnTXOfm5CyI = true;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
		while (num == 989);
	}

	[MethodImpl((MethodImplOptions)8)]
	public lrMibNXt3FWQgEybHurW()
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SPnXHsZ5q8qiqT98MUx6()
	{
		return koLRx6Z52hUUdA3cY4D3 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static lrMibNXt3FWQgEybHurW tsOWG2Z5GpIMDSVwji7F()
	{
		return (lrMibNXt3FWQgEybHurW)koLRx6Z52hUUdA3cY4D3;
	}
}

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using r5LWFs73eOlXSX66CSK;

namespace UbT4d0X7l6p1s6ZaoRCQ;

internal sealed class NXD6KYX7gpRrr65ZHRbj : IEquatable<NXD6KYX7gpRrr65ZHRbj>
{
	[CompilerGenerated]
	private string xY7X7HMAqRb;

	[CompilerGenerated]
	private string BxaX7tp5GMT;

	private static object hH4o0UZtRCBQ2PptOFcQ;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(NXD6KYX7gpRrr65ZHRbj).TypeHandle);
		}
	}

	internal static string SettingsPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.Combine(JNVYTu71oRZRpWuML35.LocalDataRoot, "Classic", "settings.json");
		}
	}

	public string DownloadRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return xY7X7HMAqRb;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 0:
						return;
					case 1:
						break;
					}
					goto IL_0031;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					xY7X7HMAqRb = value;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
					{
						num2 = 2;
					}
				}
			}
		}
	}

	public string InstallationPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return BxaX7tp5GMT;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			int num = 1;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						goto IL_001d;
					case 1:
						break;
					case 0:
						return;
					}
					goto IL_0030;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					BxaX7tp5GMT = value;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
					{
						num2 = 0;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static NXD6KYX7gpRrr65ZHRbj Load()
	{
		int num = 1;
		NXD6KYX7gpRrr65ZHRbj result = default(NXD6KYX7gpRrr65ZHRbj);
		int num4 = default(int);
		NXD6KYX7gpRrr65ZHRbj nXD6KYX7gpRrr65ZHRbj2 = default(NXD6KYX7gpRrr65ZHRbj);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num7 = default(int);
		int num9 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					int num2;
					if (System.IO.File.Exists(SettingsPath))
					{
						num2 = 4;
						goto IL_0061;
					}
					goto IL_0131;
					IL_0131:
					result = (NXD6KYX7gpRrr65ZHRbj)new NXD6KYX7gpRrr65ZHRbj();
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
					{
						num2 = 9;
					}
					goto IL_0061;
					IL_0061:
					while (true)
					{
						NXD6KYX7gpRrr65ZHRbj nXD6KYX7gpRrr65ZHRbj3;
						switch (num2)
						{
						default:
							if (num4 != 18)
							{
								if (num4 == 998)
								{
									goto IL_005d;
								}
								goto case 1;
							}
							if (System.IO.Path.IsPathFullyQualified(nXD6KYX7gpRrr65ZHRbj2.DownloadRoot))
							{
								num2 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 != 0)
								{
									num2 = 13;
								}
								continue;
							}
							goto case 8;
						case 6:
							if (!System.IO.Path.IsPathFullyQualified(nXD6KYX7gpRrr65ZHRbj2.InstallationPath))
							{
								num2 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
								{
									num2 = 14;
								}
								continue;
							}
							goto IL_01ed;
						case 3:
						case 4:
							if ((SettingsPath).Length <= 65536)
							{
								num2 = 10;
								continue;
							}
							goto case 0;
						case 2:
							break;
						case 1:
							if (!string.IsNullOrEmpty(nXD6KYX7gpRrr65ZHRbj2.InstallationPath))
							{
								num2 = 6;
								continue;
							}
							goto IL_01ed;
						case 8:
							throw new global::System.Exception("经典版设置路径无效");
						case 0:
							throw new global::System.Exception("经典版设置文件过大");
						case 10:
						{
							NXD6KYX7gpRrr65ZHRbj nXD6KYX7gpRrr65ZHRbj = JsonSerializer.Deserialize<NXD6KYX7gpRrr65ZHRbj>((global::System.ReadOnlySpan<byte>)System.IO.File.ReadAllBytes(SettingsPath), (JsonSerializerOptions)null);
							if ((object)nXD6KYX7gpRrr65ZHRbj == null)
							{
								num2 = 5;
								continue;
							}
							nXD6KYX7gpRrr65ZHRbj2 = nXD6KYX7gpRrr65ZHRbj;
							int num3 = 18;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
							{
								num3 = 18;
							}
							num4 = num3;
							goto IL_005d;
						}
						case 9:
							goto end_IL_0061;
						case 5:
							throw new global::System.Exception("经典版设置为空");
						case 7:
							goto end_IL_0061;
							IL_01ed:
							nXD6KYX7gpRrr65ZHRbj3 = nXD6KYX7gpRrr65ZHRbj2.ub6X7KnmmMA();
							nXD6KYX7gpRrr65ZHRbj3.DownloadRoot = System.IO.Path.GetFullPath(nXD6KYX7gpRrr65ZHRbj2.DownloadRoot);
							result = nXD6KYX7gpRrr65ZHRbj3;
							num2 = 7;
							continue;
							IL_005d:
							num2 = num4;
							continue;
						}
						goto IL_0131;
						continue;
						end_IL_0061:
						break;
					}
				}
				catch (object obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							num5 = 8;
						}
						goto IL_02f5;
					}
					ex = obj2;
					num6 = 16;
					goto IL_02ed;
					IL_02f5:
					while (true)
					{
						switch (num5)
						{
						case 0:
						case 2:
							goto IL_033f;
						case 3:
							if (ex is UnauthorizedAccessException)
							{
								num5 = 2;
								continue;
							}
							goto case 5;
						case 4:
							flag = false;
							num5 = 7;
							continue;
						case 6:
							if (ex is ArgumentException)
							{
								num5 = 8;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
								{
									num5 = 0;
								}
								continue;
							}
							goto case 4;
						case 5:
							if (!(ex is JsonException))
							{
								num5 = 6;
								continue;
							}
							goto IL_033f;
						case 8:
							result2 = 0;
							goto IL_0425;
						case 1:
						case 7:
							{
								result2 = (flag ? 1 : 0);
								goto IL_0425;
							}
							IL_0425:
							return (byte)result2 != 0;
						}
						if (num7 != 16)
						{
							if (num7 == 996)
							{
								break;
							}
						}
						else if (!(ex is IOException))
						{
							goto IL_0404;
						}
						goto IL_033f;
						IL_033f:
						flag = true;
						num5 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 != 0)
						{
							num5 = 1;
						}
					}
					goto IL_02f1;
					IL_0404:
					num6 = 3;
					goto IL_02ed;
					IL_02f1:
					num5 = num7;
					goto IL_02f5;
					IL_02ed:
					num7 = num6;
					goto IL_02f1;
				}).Invoke())
				{
					int num8 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
					{
						num8 = 1;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							if (num9 != 990)
							{
								break;
							}
							goto IL_0455;
						case 2:
							result = (NXD6KYX7gpRrr65ZHRbj)new NXD6KYX7gpRrr65ZHRbj();
							num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
							{
								num8 = 0;
							}
							continue;
						case 1:
							cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "classic-settings-load", "Load", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Classic\\ClassicClientSettings.cs", 29);
							num9 = 2;
							goto IL_0455;
						case 0:
							break;
							IL_0455:
							num8 = num9;
							continue;
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
	internal void Save()
	{
		//IL_0486: Unknown result type (might be due to invalid IL or missing references)
		//IL_048b: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		string text2 = default(string);
		int num4 = default(int);
		int num6 = default(int);
		int num8 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num11 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num10);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result);
		int num13 = default(int);
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
					goto case 3;
				case 0:
					try
					{
						System.IO.File.WriteAllBytes(text2, JsonSerializer.SerializeToUtf8Bytes<NXD6KYX7gpRrr65ZHRbj>(this, (JsonSerializerOptions)null));
						int num3 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 989)
								{
									num3 = num4;
									break;
								}
								return;
							case 0:
								System.IO.File.Move(text2, SettingsPath, true);
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
								{
									num3 = 4;
								}
								break;
							case 1:
								return;
							}
						}
					}
					finally
					{
						int num5 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a5e9576e6ca04343abf5cf6d7e075c04 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 == 989)
								{
									goto IL_0101;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_0105;
							}
							try
							{
								int num7;
								if (!System.IO.File.Exists(text2))
								{
									num7 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
									{
										num7 = 1;
									}
									goto IL_0168;
								}
								goto IL_018c;
								IL_0168:
								while (true)
								{
									switch (num7)
									{
									default:
										if (num8 == 990)
										{
											goto IL_0164;
										}
										break;
									case 0:
										break;
									case 2:
										goto end_IL_0168;
									case 1:
										goto end_IL_0168;
									}
									goto IL_018c;
									IL_0164:
									num7 = num8;
									continue;
									end_IL_0168:
									break;
								}
								goto end_IL_0126;
								IL_018c:
								System.IO.File.Delete(text2);
								num7 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
								{
									num7 = 1;
								}
								goto IL_0168;
								end_IL_0126:;
							}
							catch (object obj) when (((Func<bool>)delegate
							{
								// Could not convert BlockContainer to single expression
								obj2 = obj as global::System.Exception;
								if (obj2 == null)
								{
									num9 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 != 0)
									{
										num9 = 6;
									}
								}
								else
								{
									ex = obj2;
									num9 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 != 0)
									{
										num9 = 3;
									}
								}
								while (true)
								{
									switch (num9)
									{
									default:
										if (num11 != 14)
										{
											if (num11 == 994)
											{
												goto IL_021e;
											}
											goto case 1;
										}
										goto case 2;
									case 1:
									case 4:
										flag = true;
										num10 = 2;
										goto IL_021a;
									case 5:
										if (ex is UnauthorizedAccessException)
										{
											num9 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
											{
												num9 = 11;
											}
											continue;
										}
										goto case 0;
									case 0:
										flag = false;
										num10 = 14;
										goto IL_021a;
									case 3:
										if (ex is IOException)
										{
											num9 = 4;
											continue;
										}
										goto case 5;
									case 6:
										result = 0;
										break;
									case 2:
										{
											result = (flag ? 1 : 0);
											break;
										}
										IL_021a:
										num11 = num10;
										goto IL_021e;
										IL_021e:
										num9 = num11;
										continue;
									}
									break;
								}
								return (byte)result != 0;
							}).Invoke())
							{
								int num12 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
								{
									num12 = 1;
								}
								while (true)
								{
									switch (num12)
									{
									default:
										if (num13 == 989)
										{
											num12 = num13;
											continue;
										}
										break;
									case 1:
										break;
									case 0:
										goto end_IL_0352;
									}
									cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "classic-settings-cleanup", "Save", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Classic\\ClassicClientSettings.cs", 47);
									num12 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
									{
										num12 = 0;
									}
									continue;
									end_IL_0352:
									break;
								}
							}
							break;
							IL_0101:
							num5 = num6;
							continue;
							end_IL_0105:
							break;
						}
					}
				case 3:
					System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(SettingsPath));
					num2 = 2;
					break;
				case 2:
				{
					string settingsPath = SettingsPath;
					string text = ".";
					Guid val = System.Guid.NewGuid();
					text2 = string.Concat(settingsPath, text, (val).ToString("N"), ".tmp");
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
					{
						num2 = 0;
					}
					break;
				}
				case 1:
					return;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool AlrX7d7Dhee(StringBuilder builder)
	{
		int num = 4;
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
							goto case 4;
						}
						return true;
					case 0:
						(builder).Append(DownloadRoot);
						num3 = 2;
						continue;
					case 3:
						(builder).Append("DownloadRoot = ");
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						break;
					case 2:
						(builder).Append(", InstallationPath = ");
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd != 0)
						{
							num3 = 3;
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
			(builder).Append(InstallationPath);
			num = 11;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
			{
				num = 2;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(NXD6KYX7gpRrr65ZHRbj? left, NXD6KYX7gpRrr65ZHRbj? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(NXD6KYX7gpRrr65ZHRbj? left, NXD6KYX7gpRrr65ZHRbj? right)
	{
		int num = 1;
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
					goto case 3;
				case 2:
					return ((NXD6KYX7gpRrr65ZHRbj)left).Equals((NXD6KYX7gpRrr65ZHRbj?)right);
				case 3:
					return false;
				case 0:
					if (left == null)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 1:
					if (left == right)
					{
						return true;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
					{
						num2 = 0;
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
	[CompilerGenerated]
	public override int GetHashCode()
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected I4, but got Unknown
		return (int)((EqualityContract * -1521134295 + xY7X7HMAqRb) * -1521134295 + BxaX7tp5GMT);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as NXD6KYX7gpRrr65ZHRbj);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(NXD6KYX7gpRrr65ZHRbj? other)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public NXD6KYX7gpRrr65ZHRbj ub6X7KnmmMA()
	{
		return (NXD6KYX7gpRrr65ZHRbj)new NXD6KYX7gpRrr65ZHRbj(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private NXD6KYX7gpRrr65ZHRbj(NXD6KYX7gpRrr65ZHRbj original)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	public NXD6KYX7gpRrr65ZHRbj()
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
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
						if (num2 == 9)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto IL_0031;
					case 0:
						return;
					case 1:
						break;
					case 2:
						goto end_IL_000e;
					}
					goto IL_0069;
					IL_0031:
					if (num2 == 990)
					{
						break;
					}
					goto IL_0069;
					IL_0069:
					xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
					num3 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 == 0)
					{
						num3 = 5;
					}
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool jeQBL7ZtwIL1OLlaXLby()
	{
		return hH4o0UZtRCBQ2PptOFcQ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static NXD6KYX7gpRrr65ZHRbj yyfJjlZtepDfP1xZVbM6()
	{
		return (NXD6KYX7gpRrr65ZHRbj)hH4o0UZtRCBQ2PptOFcQ;
	}
}

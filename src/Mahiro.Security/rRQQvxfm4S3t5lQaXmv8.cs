using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using C0kS7qfhOYNUlZK58uV2;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CdEjKjX5XwI8HIEc5VXp;
using bUfedyCg1PBqhqIkB8r;
using fDAldojjppXrctUVYOJn;
using mtlA7efyMYGWkHnY8kS6;

namespace jjD045fmhoOr6LkiHjeo;

internal sealed class rRQQvxfm4S3t5lQaXmv8
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_99
	{
		public static readonly __c_99 __9;

		public static Func<string, DirectoryInfo> __9__40_0;

		public static Func<DirectoryInfo, global::System.DateTime> __9__40_1;

		internal static __c_99 B5xCYhD4C23YYcX6Y6K0;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_99()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal DirectoryInfo moPL8H174rR(string path)
		{
			//IL_0004: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			return new DirectoryInfo(path);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal global::System.DateTime AC5L8toZCDU(DirectoryInfo info)
		{
			return (info).LastWriteTimeUtc;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool GBidZND44n4hKiJufalA()
		{
			return B5xCYhD4C23YYcX6Y6K0 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_99 gnWbOUD4hFc6momEdJ6Z()
		{
			return B5xCYhD4C23YYcX6Y6K0;
		}
	}

	[CompilerGenerated]
	private readonly string AVqfmHdpAk4;

	[CompilerGenerated]
	private readonly string yIMfmtZAw63;

	[CompilerGenerated]
	private readonly int? UnGfmOy2joH;

	[CompilerGenerated]
	private readonly IReadOnlySet<string> Jnsfm5PA8nX;

	[CompilerGenerated]
	private readonly IReadOnlySet<string> Ie6fm6bwHBc;

	[CompilerGenerated]
	private readonly IReadOnlySet<string> c2mfmRvGl9x;

	[CompilerGenerated]
	private readonly string fFNfmwlJVAf;

	internal static object UxUuFRZamGsJbfSaXeCE;

	internal string VersionPath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return AVqfmHdpAk4;
		}
	}

	internal string ClientVersion
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return yIMfmtZAw63;
		}
	}

	internal int? ClientProtocol
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return UnGfmOy2joH;
		}
	}

	internal IReadOnlySet<string> BlockIdentifiers
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return Jnsfm5PA8nX;
		}
	}

	internal IReadOnlySet<string> ItemIdentifiers
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return Ie6fm6bwHBc;
		}
	}

	internal IReadOnlySet<string> BiomeIdentifiers
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return c2mfmRvGl9x;
		}
	}

	internal int BlockDefinitionCount
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((global::System.Collections.Generic.IReadOnlyCollection<string>)BlockIdentifiers).Count;
		}
	}

	internal int ItemDefinitionCount
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((global::System.Collections.Generic.IReadOnlyCollection<string>)ItemIdentifiers).Count;
		}
	}

	internal int BiomeDefinitionCount
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return ((global::System.Collections.Generic.IReadOnlyCollection<string>)BiomeIdentifiers).Count;
		}
	}

	internal long VanillaMcpBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return 0L;
		}
	}

	internal string? VanillaMcpSha256
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return null;
		}
	}

	internal bool VanillaMcpValid
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return false;
		}
	}

	internal string ResourceOrigin
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return fFNfmwlJVAf;
		}
	}

	internal string EvidenceSummary
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
			defaultInterpolatedStringHandler.AppendFormatted<int>(ItemDefinitionCount);
			return null;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private rRQQvxfm4S3t5lQaXmv8(xCtq2DfhtCuwFj77OqHC data, string versionPath = "embedded://netease/3.9.20.298417", string resourceOrigin = "embedded")
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rRQQvxfm4S3t5lQaXmv8? mTyfmUCxj7D()
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rRQQvxfm4S3t5lQaXmv8? prjfmraaq7d(int protocol)
	{
		rRQQvxfm4S3t5lQaXmv8 rRQQvxfm4S3t5lQaXmv9 = default(rRQQvxfm4S3t5lQaXmv8);
		int? clientProtocol = rRQQvxfm4S3t5lQaXmv9.ClientProtocol;
		object obj;
		if (!clientProtocol.HasValue)
		{
			obj = null;
		}
		else
		{
			int valueOrDefault = clientProtocol.GetValueOrDefault();
			obj = (valueOrDefault).ToString();
		}
		if (obj == null)
		{
			obj = "unknown";
		}
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		(defaultInterpolatedStringHandler).AppendFormatted((string)obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rRQQvxfm4S3t5lQaXmv8? eiEfmohBMOT()
	{
		rRQQvxfm4S3t5lQaXmv8 rRQQvxfm4S3t5lQaXmv9 = default(rRQQvxfm4S3t5lQaXmv8);
		WxrTMvfyNwIYq3E6jqT8.HPAfypOI73d(string.Concat("已加载程序集内置网易资源定义：", rRQQvxfm4S3t5lQaXmv9.EvidenceSummary));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static rRQQvxfm4S3t5lQaXmv8? TryLoadInstalled(int? requiredProtocol = null)
	{
		int num = 1;
		int num8 = default(int);
		rRQQvxfm4S3t5lQaXmv8 result = default(rRQQvxfm4S3t5lQaXmv8);
		global::System.Collections.Generic.IEnumerator<DirectoryInfo> enumerator = default(global::System.Collections.Generic.IEnumerator<DirectoryInfo>);
		rRQQvxfm4S3t5lQaXmv8 rRQQvxfm4S3t5lQaXmv9 = default(rRQQvxfm4S3t5lQaXmv8);
		int num4 = default(int);
		int? clientProtocol = default(int?);
		int? num5 = default(int?);
		int num7 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num9);
		global::System.Exception ex = default(global::System.Exception);
		int num10 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num12 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			default:
				return null;
			case 1:
				{
					try
					{
						string versionsPath = ((LixQVCX5bgefMapc3r7K)new LixQVCX5bgefMapc3r7K((string?)null)).VersionsPath;
						int num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num2 = 6;
						}
						while (true)
						{
							switch (num2)
							{
							default:
								switch (num8)
								{
								case 13:
									goto end_IL_0010;
								case 993:
									break;
								default:
									goto end_IL_0074;
								}
								goto IL_0070;
							case 2:
								result = null;
								num8 = 13;
								goto IL_0070;
							case 1:
								if (System.IO.Directory.Exists(versionsPath))
								{
									num2 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
									{
										num2 = 10;
									}
									continue;
								}
								goto case 2;
							case 3:
								try
								{
									while (true)
									{
										IL_024f:
										int num3;
										if (!(enumerator).MoveNext())
										{
											num3 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
											{
												num3 = 9;
											}
											goto IL_0135;
										}
										goto IL_01fa;
										IL_01fa:
										rRQQvxfm4S3t5lQaXmv9 = TryLoadInstalledVersion((enumerator.Current).FullName);
										num3 = 2;
										goto IL_0135;
										IL_0135:
										while (true)
										{
											switch (num3)
											{
											default:
												if (num4 != 17)
												{
													if (num4 != 997)
													{
														goto IL_024f;
													}
													goto IL_0131;
												}
												if (requiredProtocol.HasValue)
												{
													num3 = 8;
													continue;
												}
												goto IL_027f;
											case 3:
												if (clientProtocol != num5)
												{
													num3 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
													{
														num3 = 12;
													}
													continue;
												}
												goto IL_027f;
											case 4:
												num5 = requiredProtocol;
												num3 = 3;
												continue;
											case 5:
												break;
											case 1:
												goto IL_01fa;
											case 2:
												if (rRQQvxfm4S3t5lQaXmv9 == null)
												{
													goto IL_024f;
												}
												num4 = 17;
												goto IL_0131;
											case 8:
												clientProtocol = rRQQvxfm4S3t5lQaXmv9.ClientProtocol;
												num3 = 4;
												continue;
											case 0:
											case 7:
												goto IL_024f;
											case 6:
												goto IL_027f;
											case 9:
												goto end_IL_0074;
												IL_0131:
												num3 = num4;
												continue;
											}
											break;
											IL_027f:
											result = rRQQvxfm4S3t5lQaXmv9;
											num3 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
											{
												num3 = 5;
											}
										}
										break;
									}
								}
								finally
								{
									int num6;
									if (enumerator == null)
									{
										num6 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
										{
											num6 = 8;
										}
										goto IL_02df;
									}
									goto IL_0312;
									IL_02df:
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 990)
											{
												goto IL_02db;
											}
											goto end_IL_02df;
										case 1:
											goto end_IL_02df;
										case 2:
											break;
										case 0:
											goto end_IL_02df;
										}
										goto IL_0312;
										IL_02db:
										num6 = num7;
										continue;
										end_IL_02df:
										break;
									}
									goto end_IL_02a7;
									IL_0312:
									(enumerator).Dispose();
									num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
									{
										num6 = 1;
									}
									goto IL_02df;
									end_IL_02a7:;
								}
								goto end_IL_0010;
							case 4:
							case 5:
								enumerator = ((global::System.Collections.Generic.IEnumerable<DirectoryInfo>)Enumerable.OrderByDescending<DirectoryInfo, global::System.DateTime>(Enumerable.Select<string, DirectoryInfo>(System.IO.Directory.EnumerateDirectories(versionsPath), (Func<string, DirectoryInfo>)([MethodImpl((MethodImplOptions)8)] (string path) => new DirectoryInfo(path))), (Func<DirectoryInfo, global::System.DateTime>)([MethodImpl((MethodImplOptions)8)] (DirectoryInfo info) => (info).LastWriteTimeUtc))).GetEnumerator();
								num2 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
								{
									num2 = 0;
								}
								continue;
							case 0:
								break;
								IL_0070:
								num2 = num8;
								continue;
								end_IL_0074:
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
							num9 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2d1f475b59bd4d67abbeb9acbb22a19e == 0)
							{
								num9 = 1;
							}
						}
						else
						{
							ex = obj2;
							num9 = 6;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								if (num10 != 15)
								{
									if (num10 == 995)
									{
										goto IL_042f;
									}
									goto case 4;
								}
								if (!(ex is ArgumentException))
								{
									num9 = 7;
									continue;
								}
								goto case 3;
							case 2:
								flag = false;
								num9 = 5;
								continue;
							case 6:
								if (!(ex is IOException))
								{
									num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num9 = 0;
									}
									continue;
								}
								goto case 3;
							case 0:
								if (!(ex is UnauthorizedAccessException))
								{
									num10 = 15;
									goto IL_042f;
								}
								goto case 3;
							case 3:
								flag = true;
								num9 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
								{
									num9 = 8;
								}
								continue;
							case 7:
								if (ex is NotSupportedException)
								{
									num9 = 3;
									continue;
								}
								goto case 2;
							case 1:
								result2 = 0;
								break;
							case 4:
							case 5:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_042f:
								num9 = num10;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num11 = 2;
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 990)
								{
									num11 = num12;
									continue;
								}
								break;
							case 2:
								cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryLoadInstalled", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Translation\\BedrockLocalResourceRegistry.cs", 178);
								num11 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_53c7fce2855041d3a084cca979ae0726 == 0)
								{
									num11 = 3;
								}
								continue;
							case 1:
								break;
							case 0:
								goto end_IL_055a;
							}
							WxrTMvfyNwIYq3E6jqT8.zoSfyugkx0O(string.Concat("读取本机网易资源目录失败：", (ex).Message));
							num11 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 == 0)
							{
								num11 = 7;
							}
							continue;
							end_IL_055a:
							break;
						}
					}
					goto default;
				}
				end_IL_0010:
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static rRQQvxfm4S3t5lQaXmv8? TryLoadInstalledVersion(object versionPath)
	{
		int num = 4;
		rRQQvxfm4S3t5lQaXmv8 result = default(rRQQvxfm4S3t5lQaXmv8);
		string text4 = default(string);
		string text = default(string);
		int num5 = default(int);
		HashSet<string> val3 = default(HashSet<string>);
		string text3 = default(string);
		HashSet<string> val2 = default(HashSet<string>);
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
							goto case 0;
						}
						goto case 6;
					case 2:
						return result;
					case 1:
						num3 = (System.IO.File.Exists(text4) ? 5 : 6);
						break;
					case 0:
						if (!System.IO.File.Exists(text))
						{
							goto end_IL_000c;
						}
						goto case 1;
					case 6:
						return null;
					case 3:
						text4 = System.IO.Path.Combine((string)versionPath, "Minecraft.Windows.exe");
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
						{
							num3 = 0;
						}
						break;
					case 5:
						try
						{
							HashSet<string> val = DLLfmmkNDYZ(text);
							int num4 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
							{
								num4 = 7;
							}
							while (true)
							{
								string text2;
								switch (num4)
								{
								default:
									if (num5 != 19)
									{
										if (num5 == 999)
										{
											goto IL_013a;
										}
										goto case 1;
									}
									val3 = NT8fmAUf3Ra(System.IO.Path.Combine(new string[5]
									{
										(string)versionPath,
										"data",
										"resource_packs",
										"vanilla",
										"biomes_client.json"
									}));
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 != 0)
									{
										num4 = 9;
									}
									continue;
								case 11:
									result = null;
									num4 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
									{
										num4 = 8;
									}
									continue;
								case 9:
									val3.UnionWith((global::System.Collections.Generic.IEnumerable<string>)nJEfm7JrFdU(System.IO.Path.Combine(new string[5]
									{
										(string)versionPath,
										"data",
										"behavior_packs",
										"vanilla",
										"biomes"
									})));
									num4 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
									{
										num4 = 3;
									}
									continue;
								case 2:
									if (System.IO.File.Exists(text3))
									{
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
										{
											num4 = 19;
										}
										continue;
									}
									goto case 1;
								case 3:
									text2 = (System.Diagnostics.FileVersionInfo.GetVersionInfo(text4)).ProductVersion;
									if (text2 == null)
									{
										num4 = 9;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									break;
								case 7:
									text3 = System.IO.Path.Combine(new string[5]
									{
										(string)versionPath,
										"data",
										"resource_packs",
										"vanilla_netease",
										"blocks.json"
									});
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
									{
										num4 = 2;
									}
									continue;
								case 5:
									val.UnionWith((global::System.Collections.Generic.IEnumerable<string>)DLLfmmkNDYZ(text3));
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
									{
										num4 = 1;
									}
									continue;
								case 8:
									goto end_IL_013e;
								case 1:
									if (val.Count == 0)
									{
										num4 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
										{
											num4 = 11;
										}
										continue;
									}
									goto case 6;
								case 6:
									val2 = nJEfm7JrFdU(System.IO.Path.Combine(new string[5]
									{
										(string)versionPath,
										"data",
										"behavior_packs",
										"vanilla",
										"items"
									}));
									num4 = 4;
									continue;
								case 4:
									val2.UnionWith((global::System.Collections.Generic.IEnumerable<string>)nJEfm7JrFdU(System.IO.Path.Combine(new string[5]
									{
										(string)versionPath,
										"data",
										"behavior_packs",
										"vanilla_netease",
										"items"
									})));
									num5 = 19;
									goto IL_013a;
								case 0:
									text2 = "unknown";
									break;
								case 10:
									goto end_IL_013e;
									IL_013a:
									num4 = num5;
									continue;
								}
								result = (rRQQvxfm4S3t5lQaXmv8)new rRQQvxfm4S3t5lQaXmv8((xCtq2DfhtCuwFj77OqHC)new xCtq2DfhtCuwFj77OqHC(text2, RW1fmB6Alcd(text2), (IReadOnlySet<string>)(object)val, (IReadOnlySet<string>)(object)val2, (IReadOnlySet<string>)(object)val3), (string)versionPath, "installed");
								num4 = 10;
								continue;
								end_IL_013e:
								break;
							}
						}
						catch (global::System.Exception obj) when (((Func<bool>)delegate
						{
							// Could not convert BlockContainer to single expression
							obj2 = obj as global::System.Exception;
							if (obj2 == null)
							{
								num6 = 4;
								goto IL_069b;
							}
							ex = obj2;
							num7 = 17;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
							{
								num7 = 20;
							}
							num8 = num7;
							goto IL_0697;
							IL_069b:
							while (true)
							{
								switch (num6)
								{
								default:
									if (num8 != 20)
									{
										if (num8 == 1000)
										{
											break;
										}
										goto case 4;
									}
									if (ex is IOException)
									{
										num6 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
										{
											num6 = 1;
										}
										continue;
									}
									goto case 6;
								case 3:
									if (!(ex is ArgumentException))
									{
										num6 = 2;
										continue;
									}
									goto case 0;
								case 7:
									if (!(ex is InvalidDataException))
									{
										num6 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
										{
											num6 = 3;
										}
										continue;
									}
									goto case 0;
								case 8:
									if (ex is JsonException)
									{
										num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num6 = 7;
										}
										continue;
									}
									goto case 7;
								case 5:
								case 9:
									flag = false;
									num6 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
									{
										num6 = 9;
									}
									continue;
								case 6:
									if (!(ex is UnauthorizedAccessException))
									{
										num6 = 8;
										continue;
									}
									goto case 0;
								case 0:
								case 1:
								case 10:
									flag = true;
									num6 = 12;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
									{
										num6 = 14;
									}
									continue;
								case 2:
									if (!(ex is NotSupportedException))
									{
										num6 = 5;
										continue;
									}
									goto case 0;
								case 4:
									result2 = 0;
									goto IL_0879;
								case 11:
								case 12:
									{
										result2 = (flag ? 1 : 0);
										goto IL_0879;
									}
									IL_0879:
									return (byte)result2 != 0;
								}
								break;
							}
							goto IL_0697;
							IL_0697:
							num6 = num8;
							goto IL_069b;
						}).Invoke())
						{
							int num9 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								num9 = 2;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									switch (num10)
									{
									case 990:
										break;
									default:
										goto end_IL_08ad;
									case 10:
										WxrTMvfyNwIYq3E6jqT8.zoSfyugkx0O(string.Concat("跳过无法读取的网易客户端资源目录 ", (string)versionPath, ": ", (ex).Message));
										num9 = 1;
										continue;
									}
									goto IL_08a9;
								case 2:
								{
									cywTmHCBonHBVDeOMyD.TdvClQfWA9(ex, "caught-exception", "TryLoadInstalledVersion", "D:\\Dev\\winui\\ACCOUNT\\Mahiro-Account\\Services\\Bedrock\\Relay\\Translation\\BedrockLocalResourceRegistry.cs", 224);
									int num11 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
									{
										num11 = 10;
									}
									num10 = num11;
									goto IL_08a9;
								}
								case 1:
									result = null;
									num9 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
									{
										num9 = 1;
									}
									continue;
								case 0:
									break;
									IL_08a9:
									num9 = num10;
									continue;
									end_IL_08ad:
									break;
								}
								break;
							}
						}
						goto case 2;
					case 4:
						text = System.IO.Path.Combine(new string[5]
						{
							(string)versionPath,
							"data",
							"resource_packs",
							"vanilla",
							"blocks.json"
						});
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb == 0)
						{
							num3 = 3;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static HashSet<string> DLLfmmkNDYZ(object path)
	{
		//IL_0578: Unknown result type (might be due to invalid IL or missing references)
		//IL_057e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Unknown result type (might be due to invalid IL or missing references)
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Invalid comparison between Unknown and I4
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_044d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		HashSet<string> result = default(HashSet<string>);
		int num5 = default(int);
		ObjectEnumerator enumerator = default(ObjectEnumerator);
		JsonProperty val4 = default(JsonProperty);
		int num7 = default(int);
		int num10 = default(int);
		ObjectEnumerator val5 = default(ObjectEnumerator);
		JsonElement val3 = default(JsonElement);
		JsonDocument val = default(JsonDocument);
		int num12 = default(int);
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
					return result;
				case 2:
					S0sfmIoiX5S(path);
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					try
					{
						HashSet<string> val2 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.Ordinal);
						int num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 16)
								{
									if (num5 == 996)
									{
										goto IL_009f;
									}
									goto case 0;
								}
								break;
							case 0:
								try
								{
									while (true)
									{
										IL_0310:
										int num6;
										if (!(enumerator).MoveNext())
										{
											num6 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
											{
												num6 = 17;
											}
											goto IL_011c;
										}
										goto IL_025d;
										IL_02c7:
										val2.Add(string.Concat("minecraft:", (val4).Name));
										num6 = 2;
										goto IL_011c;
										IL_011c:
										num7 = num6;
										goto IL_0120;
										IL_025d:
										val4 = (enumerator).Current;
										int num8 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04aa3461f2a647c4a801b548dfa646bd == 0)
										{
											num8 = 8;
										}
										goto IL_0124;
										IL_0120:
										num8 = num7;
										goto IL_0124;
										IL_0124:
										while (true)
										{
											switch (num8)
											{
											default:
												if (num7 != 17)
												{
													if (num7 == 997)
													{
														goto IL_0120;
													}
													goto case 6;
												}
												goto end_IL_0310;
											case 8:
												if ((val4).NameEquals("format_version"))
												{
													num8 = 7;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
													{
														num8 = 16;
													}
													continue;
												}
												goto case 4;
											case 3:
												val2.Add((val4).Name);
												num8 = 7;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
												{
													num8 = 6;
												}
												continue;
											case 4:
												if (string.IsNullOrWhiteSpace((val4).Name))
												{
													num8 = 10;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
													{
														num8 = 0;
													}
													continue;
												}
												goto case 3;
											case 9:
												break;
											case 6:
												if (((val4).Name).Contains(':', (StringComparison)4))
												{
													num8 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
													{
														num8 = 1;
													}
													continue;
												}
												goto IL_02c7;
											case 5:
												goto IL_02c7;
											case 0:
											case 1:
											case 2:
											case 7:
												goto IL_0310;
											}
											break;
										}
										goto IL_025d;
										continue;
										end_IL_0310:
										break;
									}
								}
								finally
								{
									((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
									int num9 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
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
												num9 = num10;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								goto case 3;
							case 6:
								val5 = val3.EnumerateObject();
								num4 = 4;
								goto IL_009b;
							case 4:
								enumerator = val5.GetEnumerator();
								num3 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
								{
									num3 = 5;
								}
								continue;
							case 3:
								result = val2;
								num3 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num3 = 1;
								}
								continue;
							case 8:
								val3 = (val).RootElement;
								num3 = 6;
								continue;
							case 2:
								val3 = (val).RootElement;
								num3 = 7;
								continue;
							case 7:
								if ((int)(val3).ValueKind != 1)
								{
									num4 = 5;
									goto IL_009b;
								}
								goto case 8;
							case 5:
								result = val2;
								num4 = 16;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
								{
									num4 = 7;
								}
								goto IL_009b;
							case 1:
								break;
								IL_009f:
								num3 = num5;
								continue;
								IL_009b:
								num5 = num4;
								goto IL_009f;
							}
							break;
						}
					}
					finally
					{
						int num11;
						if (val == null)
						{
							num11 = 2;
							goto IL_04d8;
						}
						goto IL_0520;
						IL_0520:
						(val).Dispose();
						num11 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 != 0)
						{
							num11 = 3;
						}
						goto IL_04d8;
						IL_04d8:
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 990)
								{
									goto IL_04d4;
								}
								break;
							case 2:
								goto end_IL_04d8;
							case 1:
								break;
							case 0:
								goto end_IL_04d8;
							}
							goto IL_0520;
							IL_04d4:
							num11 = num12;
							continue;
							end_IL_04d8:
							break;
						}
					}
					goto case 0;
				case 1:
					val = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText((string)path), default(JsonDocumentOptions));
					num2 = 3;
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static HashSet<string> nJEfm7JrFdU(object directory)
	{
		//IL_063d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0643: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Invalid comparison between Unknown and I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0510: Unknown result type (might be due to invalid IL or missing references)
		//IL_0515: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0384: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04df: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Invalid comparison between Unknown and I4
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Invalid comparison between Unknown and I4
		//IL_034e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Invalid comparison between Unknown and I4
		int num = 2;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		JsonDocument val2 = default(JsonDocument);
		int num15 = default(int);
		int num11 = default(int);
		ObjectEnumerator enumerator2 = default(ObjectEnumerator);
		ObjectEnumerator val7 = default(ObjectEnumerator);
		int num8 = default(int);
		JsonElement val6 = default(JsonElement);
		JsonProperty val5 = default(JsonProperty);
		HashSet<string> val = default(HashSet<string>);
		string text = default(string);
		JsonElement val4 = default(JsonElement);
		int num10 = default(int);
		int num14 = default(int);
		int num17 = default(int);
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
							goto case 0;
						}
						try
						{
							while (true)
							{
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 != 0)
									{
										num4 = 1;
									}
									goto IL_0105;
								}
								goto IL_0624;
								IL_0624:
								string current = enumerator.Current;
								S0sfmIoiX5S(current);
								val2 = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText(current), default(JsonDocumentOptions));
								num4 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
								{
									num4 = 0;
								}
								goto IL_0105;
								IL_0105:
								while (true)
								{
									switch (num4)
									{
									default:
										if (num15 == 991)
										{
											num4 = num15;
											continue;
										}
										goto IL_0624;
									case 2:
										break;
									case 0:
										try
										{
											JsonElement val3 = (val2).RootElement;
											int num5 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 != 0)
											{
												num5 = 2;
											}
											while (true)
											{
												switch (num5)
												{
												default:
													if (num11 != 12)
													{
														if (num11 == 992)
														{
															goto IL_0199;
														}
														goto case 1;
													}
													enumerator2 = val7.GetEnumerator();
													num5 = 3;
													continue;
												case 1:
													val3 = (val2).RootElement;
													num5 = 4;
													continue;
												case 4:
												{
													val7 = val3.EnumerateObject();
													int num12 = 12;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
													{
														num12 = 0;
													}
													num11 = num12;
													goto IL_0199;
												}
												case 2:
													if ((int)(val3).ValueKind != 1)
													{
														num5 = 0;
														if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
														{
															num5 = 12;
														}
														continue;
													}
													goto case 1;
												case 0:
													break;
												case 3:
													{
														try
														{
															while (true)
															{
																int num6;
																if (!(enumerator2).MoveNext())
																{
																	num6 = 3;
																	goto IL_02b6;
																}
																goto IL_0509;
																IL_02b6:
																while (true)
																{
																	int num7;
																	switch (num6)
																	{
																	default:
																		if (num8 != 20)
																		{
																			if (num8 == 1000)
																			{
																				goto IL_02b2;
																			}
																			goto IL_0509;
																		}
																		if ((int)(val3).ValueKind == 1)
																		{
																			num6 = 0;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bcdf45229cde48d2b40e4bace39e2bdb != 0)
																			{
																				num6 = 5;
																			}
																			continue;
																		}
																		break;
																	case 5:
																	case 6:
																		break;
																	case 11:
																		if ((int)(val6).ValueKind == 3)
																		{
																			num6 = 7;
																			continue;
																		}
																		break;
																	case 0:
																		val3 = (val5).Value;
																		num6 = 12;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
																		{
																			num6 = 16;
																		}
																		continue;
																	case 8:
																		val.Add(text);
																		num7 = 6;
																		goto IL_02ae;
																	case 2:
																		val3 = (val5).Value;
																		num7 = 20;
																		if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 != 0)
																		{
																			num7 = 9;
																		}
																		goto IL_02ae;
																	case 9:
																		if (!string.IsNullOrWhiteSpace(text))
																		{
																			num6 = 8;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
																			{
																				num6 = 1;
																			}
																			continue;
																		}
																		break;
																	case 7:
																		text = (val6).GetString();
																		num6 = 9;
																		continue;
																	case 10:
																		if ((val4).TryGetProperty("identifier", out val6))
																		{
																			num6 = 11;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
																			{
																				num6 = 15;
																			}
																			continue;
																		}
																		break;
																	case 12:
																		if (!(val3).TryGetProperty("description", out val4))
																		{
																			num6 = 5;
																			continue;
																		}
																		goto case 4;
																	case 4:
																		if ((int)(val4).ValueKind == 1)
																		{
																			num6 = 9;
																			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
																			{
																				num6 = 10;
																			}
																			continue;
																		}
																		break;
																	case 1:
																		goto IL_0509;
																	case 3:
																		goto end_IL_0310;
																		IL_02b2:
																		num6 = num8;
																		continue;
																		IL_02ae:
																		num8 = num7;
																		goto IL_02b2;
																	}
																	break;
																}
																continue;
																IL_0509:
																val5 = (enumerator2).Current;
																num6 = 2;
																goto IL_02b6;
																continue;
																end_IL_0310:
																break;
															}
														}
														finally
														{
															((global::System.IDisposable)(enumerator2)/*cast due to .constrained prefix*/).Dispose();
															int num9 = 5;
															if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
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
																		num9 = num10;
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
													}
													IL_0199:
													num5 = num11;
													continue;
												}
												break;
											}
										}
										finally
										{
											if (val2 != null)
											{
												int num13 = 4;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
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
															continue;
														}
														break;
													case 1:
														break;
													case 0:
														goto end_IL_05b9;
													}
													(val2).Dispose();
													num13 = 0;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
													{
														num13 = 3;
													}
													continue;
													end_IL_05b9:
													break;
												}
											}
										}
										break;
									case 3:
										goto IL_0624;
									case 1:
										goto end_IL_012d;
									}
									break;
								}
								continue;
								end_IL_012d:
								break;
							}
						}
						finally
						{
							int num16;
							if (enumerator == null)
							{
								num16 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
								{
									num16 = 0;
								}
								goto IL_06ad;
							}
							goto IL_06f5;
							IL_06ad:
							while (true)
							{
								switch (num16)
								{
								default:
									if (num17 == 990)
									{
										goto IL_06a9;
									}
									goto end_IL_06ad;
								case 0:
									goto end_IL_06ad;
								case 1:
									break;
								case 2:
									goto end_IL_06ad;
								}
								goto IL_06f5;
								IL_06a9:
								num16 = num17;
								continue;
								end_IL_06ad:
								break;
							}
							goto end_IL_0675;
							IL_06f5:
							(enumerator).Dispose();
							num16 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
							{
								num16 = 2;
							}
							goto IL_06ad;
							end_IL_0675:;
						}
						goto case 3;
					case 0:
						return val;
					case 3:
						return val;
					case 1:
						if (System.IO.Directory.Exists((string)directory))
						{
							goto end_IL_000c;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						val = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.Ordinal);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num3 = 1;
						}
						break;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			enumerator = System.IO.Directory.EnumerateFiles((string)directory, "*.json", (SearchOption)1).GetEnumerator();
			num = 10;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static HashSet<string> NT8fmAUf3Ra(object path)
	{
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Invalid comparison between Unknown and I4
		//IL_0392: Unknown result type (might be due to invalid IL or missing references)
		//IL_0397: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		HashSet<string> val6 = default(HashSet<string>);
		HashSet<string> result = default(HashSet<string>);
		JsonDocument val2 = default(JsonDocument);
		int num5 = default(int);
		ObjectEnumerator enumerator = default(ObjectEnumerator);
		int num7 = default(int);
		JsonProperty val5 = default(JsonProperty);
		int num10 = default(int);
		JsonElement val4 = default(JsonElement);
		ObjectEnumerator val3 = default(ObjectEnumerator);
		int num12 = default(int);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						S0sfmIoiX5S(path);
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
						{
							num3 = 0;
						}
						break;
					case 3:
						return val6;
					case 1:
						if (System.IO.File.Exists((string)path))
						{
							goto end_IL_000c;
						}
						goto case 3;
					case 4:
						return result;
					case 0:
						val2 = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText((string)path), default(JsonDocumentOptions));
						num3 = 5;
						break;
					case 2:
						val6 = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.Ordinal);
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
						{
							num3 = 2;
						}
						break;
					case 5:
						try
						{
							JsonElement val = (val2).RootElement;
							int num4 = 4;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 != 14)
									{
										if (num5 == 994)
										{
											goto IL_0124;
										}
										goto case 4;
									}
									try
									{
										while (true)
										{
											int num6;
											if (!(enumerator).MoveNext())
											{
												num6 = 1;
												goto IL_01bd;
											}
											goto IL_023d;
											IL_01b9:
											num6 = num7;
											goto IL_01bd;
											IL_023d:
											val5 = (enumerator).Current;
											int num8 = 10;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
											{
												num8 = 3;
											}
											num7 = num8;
											goto IL_01b9;
											IL_01dc:
											if (num7 == 990)
											{
												goto IL_01b9;
											}
											goto IL_023d;
											IL_01bd:
											while (true)
											{
												switch (num6)
												{
												case 0:
													goto end_IL_01bd;
												case 2:
													goto IL_023d;
												case 1:
													goto end_IL_0222;
												}
												if (num7 == 10)
												{
													val6.Add((val5).Name);
													num6 = 3;
													if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
													{
														num6 = 0;
													}
													continue;
												}
												goto IL_01dc;
												continue;
												end_IL_01bd:
												break;
											}
											continue;
											end_IL_0222:
											break;
										}
									}
									finally
									{
										((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
										int num9 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
										{
											num9 = 5;
										}
										while (true)
										{
											switch (num9)
											{
											default:
												if (num10 == 988)
												{
													num9 = num10;
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
									if ((int)(val4).ValueKind == 1)
									{
										num4 = 3;
										continue;
									}
									break;
								case 3:
									val3 = val4.EnumerateObject();
									num4 = 2;
									continue;
								case 4:
									if (!(val).TryGetProperty("biomes", out val4))
									{
										num4 = 14;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 0;
								case 1:
								case 6:
									break;
								case 2:
									enumerator = val3.GetEnumerator();
									num5 = 14;
									goto IL_0124;
								case 5:
									goto end_IL_0128;
									IL_0124:
									num4 = num5;
									continue;
								}
								result = val6;
								num4 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
								{
									num4 = 9;
								}
								continue;
								end_IL_0128:
								break;
							}
						}
						finally
						{
							int num11;
							if (val2 == null)
							{
								num11 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
								{
									num11 = 3;
								}
								goto IL_03e0;
							}
							goto IL_0404;
							IL_03e0:
							while (true)
							{
								switch (num11)
								{
								default:
									if (num12 == 990)
									{
										goto IL_03dc;
									}
									goto end_IL_03e0;
								case 2:
									break;
								case 0:
									goto end_IL_03e0;
								case 1:
									goto end_IL_03e0;
								}
								goto IL_0404;
								IL_03dc:
								num11 = num12;
								continue;
								end_IL_03e0:
								break;
							}
							goto end_IL_03a8;
							IL_0404:
							(val2).Dispose();
							num11 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num11 = 2;
							}
							goto IL_03e0;
							end_IL_03a8:;
						}
						goto case 4;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void S0sfmIoiX5S(object path)
	{
		global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = default(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler);
		defaultInterpolatedStringHandler.AppendFormatted<int>(33554432, "N0");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int RW1fmB6Alcd(object version)
	{
		int num = 2;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal int TN7fmg4JGw6(global::System.Collections.Generic.IEnumerable<string> identifiers)
	{
		return Bq2fmdRIHKQ(identifiers, BlockIdentifiers);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal int vLCfmlTvLYa(global::System.Collections.Generic.IEnumerable<string> identifiers)
	{
		return Bq2fmdRIHKQ(identifiers, ItemIdentifiers);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int Bq2fmdRIHKQ(global::System.Collections.Generic.IEnumerable<string> identifiers, IReadOnlySet<string> known)
	{
		int num = 2;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		int num4 = default(int);
		string current = default(string);
		HashSet<string> val = default(HashSet<string>);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0025;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 12;
								goto IL_0067;
							}
							goto IL_0134;
							IL_0067:
							num4 = num3;
							goto IL_006b;
							IL_0134:
							current = enumerator.Current;
							int num5 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
							{
								num5 = 0;
							}
							goto IL_006f;
							IL_006b:
							num5 = num4;
							goto IL_006f;
							IL_006f:
							while (true)
							{
								switch (num5)
								{
								default:
									if (num4 != 12)
									{
										if (num4 == 992)
										{
											goto IL_006b;
										}
										goto case 4;
									}
									goto end_IL_00a9;
								case 2:
									break;
								case 4:
									if (!known.Contains(current))
									{
										num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
										{
											num5 = 1;
										}
										continue;
									}
									break;
								case 1:
									goto IL_00f0;
								case 0:
									if (!string.IsNullOrWhiteSpace(current))
									{
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 != 0)
										{
											num5 = 3;
										}
										continue;
									}
									break;
								case 3:
									goto IL_0134;
								}
								break;
							}
							continue;
							IL_00f0:
							val.Add(current);
							num3 = 2;
							goto IL_0067;
							continue;
							end_IL_00a9:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num6 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
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
									(enumerator).Dispose();
									num6 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
									{
										num6 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 0;
				case 1:
					enumerator = identifiers.GetEnumerator();
					num2 = 3;
					continue;
				case 0:
					return val.Count;
				case 2:
					break;
				}
				goto IL_021e;
				IL_0025:
				if (num == 991)
				{
					break;
				}
				goto IL_021e;
				IL_021e:
				val = new HashSet<string>((IEqualityComparer<string>)(object)System.StringComparer.Ordinal);
				num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
				{
					num2 = 1;
				}
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
	internal static bool I1hQDZZa7Xubd0tn6BXg()
	{
		return UxUuFRZamGsJbfSaXeCE == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static rRQQvxfm4S3t5lQaXmv8 L1FWeNZaA2jl502Rulyb()
	{
		return (rRQQvxfm4S3t5lQaXmv8)UxUuFRZamGsJbfSaXeCE;
	}
}

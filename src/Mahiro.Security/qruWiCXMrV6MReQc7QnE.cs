using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using TwQ37FXMwVTVVIYlDVYw;
using fDAldojjppXrctUVYOJn;
using jvPZloXMPBIr4Eca68JZ;

namespace tiKUK2XMoOw1a8mUSsmL;

internal sealed class qruWiCXMrV6MReQc7QnE
{
	private static readonly object u5YXMOCUjPN;

	private readonly object QLtXM5erWtM;

	private readonly object BHqXM6eumHU;

	private static object Eg71XfZwiY7bNAYdWBEJ;

	internal string JournalPath
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (string)QLtXM5erWtM;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private qruWiCXMrV6MReQc7QnE(string journalPath, sykG98XMey1uUZdicBi5 state)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qruWiCXMrV6MReQc7QnE HFRXMm3BV8E(object versionsPath, object version, object stagingPath, object backupPath, bool requiresPatchManifest, string installerKind = "archive")
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		string text = System.IO.Path.GetFullPath((string)versionsPath);
		string stagingDirectoryName = NT0XMdfp1vP(text, stagingPath, ".staging-");
		string backupDirectoryName = NT0XMdfp1vP(text, backupPath, ".backup-");
		sykG98XMey1uUZdicBi5 state = (sykG98XMey1uUZdicBi5)new sykG98XMey1uUZdicBi5
		{
			Version = (string)version,
			StagingDirectoryName = stagingDirectoryName,
			BackupDirectoryName = backupDirectoryName,
			RequiresPatchManifest = requiresPatchManifest,
			InstallerKind = installerKind,
			Phase = udsBuZXMRGjs66p5pXHs.Prepared,
			UpdatedAtUtc = System.DateTimeOffset.UtcNow
		};
		string text2 = ".chronal-install-";
		Guid val = System.Guid.NewGuid();
		object obj = (object)new qruWiCXMrV6MReQc7QnE(System.IO.Path.Combine(text, string.Concat(text2, (val).ToString("N"), ".json")), state);
		((qruWiCXMrV6MReQc7QnE)obj).Save();
		return (qruWiCXMrV6MReQc7QnE)obj;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void KQwXM7JL7qJ(string sourceRelativePath, string executableRelativePath)
	{
		Save();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void m9gXMAxNh7c()
	{
		Save();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void inuXMItci0o()
	{
		Save();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void cqtXMBG7Lvn()
	{
		Save();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void hffXMgm8wNf()
	{
		DVTXMK2t20a(string.Concat((string)QLtXM5erWtM, ".tmp"));
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool pLSXMlnGMBL(object journalPath, out sykG98XMey1uUZdicBi5 state)
	{
		state = default(sykG98XMey1uUZdicBi5);
		int num = 1;
		int num4 = default(int);
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
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 1:
					state = (sykG98XMey1uUZdicBi5)new sykG98XMey1uUZdicBi5();
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
					{
						num2 = 1;
					}
					continue;
				case 0:
					try
					{
						sykG98XMey1uUZdicBi5 sykG98XMey1uUZdicBi = JsonSerializer.Deserialize<sykG98XMey1uUZdicBi5>(((global::System.ReadOnlySpan<byte>)System.IO.File.ReadAllBytes((string)journalPath)), (JsonSerializerOptions)u5YXMOCUjPN);
						int num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
						{
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 16)
								{
									if (num4 == 996)
									{
										goto IL_00a4;
									}
									goto case 0;
								}
								break;
							case 1:
								if (sykG98XMey1uUZdicBi != null)
								{
									num3 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
									{
										num3 = 9;
									}
									continue;
								}
								goto case 2;
							case 6:
								if (string.IsNullOrWhiteSpace(sykG98XMey1uUZdicBi.BackupDirectoryName))
								{
									num3 = 5;
									continue;
								}
								goto case 8;
							case 2:
							case 5:
								result = false;
								num3 = 7;
								continue;
							case 4:
								result = true;
								num4 = 16;
								goto IL_00a4;
							case 8:
								state = sykG98XMey1uUZdicBi;
								num3 = 4;
								continue;
							case 3:
								if (string.IsNullOrWhiteSpace(sykG98XMey1uUZdicBi.StagingDirectoryName))
								{
									num3 = 2;
									continue;
								}
								goto case 6;
							case 0:
								if (!string.IsNullOrWhiteSpace(sykG98XMey1uUZdicBi.Version))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 7:
								break;
								IL_00a4:
								num3 = num4;
								continue;
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
							num5 = 2;
							goto IL_01eb;
						}
						ex = obj2;
						num6 = 14;
						goto IL_01e7;
						IL_01e7:
						num5 = num6;
						goto IL_01eb;
						IL_01eb:
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 != 14)
								{
									if (num6 == 994)
									{
										break;
									}
									goto case 0;
								}
								if (!(ex is IOException))
								{
									num5 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 != 0)
									{
										num5 = 3;
									}
									continue;
								}
								goto case 5;
							case 3:
								if (!(ex is UnauthorizedAccessException))
								{
									num5 = 6;
									continue;
								}
								goto case 5;
							case 6:
								if (ex is JsonException)
								{
									num5 = 5;
									continue;
								}
								goto case 4;
							case 5:
								flag = true;
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
								{
									num5 = 13;
								}
								continue;
							case 4:
								flag = false;
								num5 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
								{
									num5 = 0;
								}
								continue;
							case 2:
								result2 = 0;
								goto IL_0303;
							case 0:
							case 1:
								{
									result2 = (flag ? 1 : 0);
									goto IL_0303;
								}
								IL_0303:
								return (byte)result2 != 0;
							}
							break;
						}
						goto IL_01e7;
					}).Invoke())
					{
						int num7 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
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
								goto end_IL_0337;
							}
							result = false;
							num7 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
							{
								num7 = 0;
							}
							continue;
							end_IL_0337:
							break;
						}
					}
					break;
				case 2:
					break;
				}
				goto IL_039d;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_039d;
				IL_039d:
				return result;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void Save()
	{
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		int num = 3;
		string text = default(string);
		int num5 = default(int);
		byte[] array = default(byte[]);
		int num7 = default(int);
		int num8 = default(int);
		int num11 = default(int);
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
					case 3:
						((sykG98XMey1uUZdicBi5)BHqXM6eumHU).UpdatedAtUtc = System.DateTimeOffset.UtcNow;
						num3 = 2;
						continue;
					case 0:
						goto end_IL_000c;
					case 2:
						text = string.Concat((string)QLtXM5erWtM, ".tmp");
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
						{
							num3 = 0;
						}
						continue;
					case 1:
						return;
					}
					break;
				}
				switch (num2)
				{
				case 991:
					break;
				default:
					return;
				case 10:
					try
					{
						FileStream val = new FileStream(text, (FileMode)2, (FileAccess)2, (FileShare)0, 4096, (FileOptions)(-2147483648));
						int num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
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
								goto case 1;
							case 1:
								try
								{
									(val).Write(array, 0, array.Length);
									int num6 = 2;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f != 0)
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
											goto end_IL_00f7;
										}
										(val).Flush(true);
										num6 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
										{
											num6 = 4;
										}
										continue;
										end_IL_00f7:
										break;
									}
								}
								finally
								{
									if (val == null)
									{
										num8 = 2;
										goto IL_0167;
									}
									goto IL_018f;
									IL_018f:
									(val).Dispose();
									int num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 != 0)
									{
										num9 = 3;
									}
									goto IL_016b;
									IL_0167:
									num9 = num8;
									goto IL_016b;
									IL_016b:
									switch (num9)
									{
									case 0:
										goto IL_018f;
									case 2:
										goto end_IL_0148;
									case 1:
										goto end_IL_0148;
									}
									if (num8 == 990)
									{
										goto IL_0167;
									}
									goto IL_018f;
									end_IL_0148:;
								}
								break;
							case 0:
								break;
							case 2:
								return;
							}
							System.IO.File.Move(text, (string)QLtXM5erWtM, true);
							num4 = 2;
						}
					}
					finally
					{
						DVTXMK2t20a(text);
						int num10 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_946375e2adcb44b5aa0c790868262776 == 0)
						{
							num10 = 4;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 988)
								{
									num10 = num11;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			array = JsonSerializer.SerializeToUtf8Bytes<sykG98XMey1uUZdicBi5>((sykG98XMey1uUZdicBi5)BHqXM6eumHU, (JsonSerializerOptions)u5YXMOCUjPN);
			num = 1;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
			{
				num = 10;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string NT0XMdfp1vP(object parentPath, object childPath, object requiredMarker)
	{
		string text = System.IO.Path.GetFullPath((string)childPath);
		string text2 = System.IO.Path.GetDirectoryName(text);
		string text3 = System.IO.Path.GetFileName(text);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void DVTXMK2t20a(object path)
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
					int num2;
					if (!System.IO.File.Exists((string)path))
					{
						num2 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
						{
							num2 = 1;
						}
						goto IL_0073;
					}
					goto IL_0097;
					IL_0073:
					while (true)
					{
						switch (num2)
						{
						case 1:
							return;
						case 2:
							return;
						default:
							if (num3 == 990)
							{
								goto IL_006f;
							}
							return;
						case 0:
							break;
						}
						break;
						IL_006f:
						num2 = num3;
					}
					goto IL_0097;
					IL_0097:
					System.IO.File.Delete((string)path);
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 != 0)
					{
						num2 = 2;
					}
					goto IL_0073;
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					if (!(obj is global::System.Exception))
					{
						num4 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
						{
							num4 = 0;
						}
					}
					else
					{
						num4 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
						{
							num4 = 7;
						}
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 989)
							{
								goto IL_0128;
							}
							goto case 1;
						case 0:
							result = 0;
							break;
						case 1:
							result = (System.IO.File.Exists((string)path) ? 1 : 0);
							break;
						}
						break;
						IL_0128:
						num4 = num5;
					}
					return (byte)result != 0;
				}).Invoke())
				{
					int num6 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
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
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool xTAQGRZwnre4KD4deeQx()
	{
		return Eg71XfZwiY7bNAYdWBEJ == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static qruWiCXMrV6MReQc7QnE SLeyjbZwzcYwSSZmLpPk()
	{
		return (qruWiCXMrV6MReQc7QnE)Eg71XfZwiY7bNAYdWBEJ;
	}
}

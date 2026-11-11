using System;
using System.Runtime.CompilerServices;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Models;

public sealed class McpLocalFile
{
	[CompilerGenerated]
	private readonly string _FilePath_k__BackingField;

	[CompilerGenerated]
	private readonly long _SizeBytes_k__BackingField;

	[CompilerGenerated]
	private bool _IsInjected_k__BackingField;

	[CompilerGenerated]
	private readonly string _EntryModule_k__BackingField;

	[CompilerGenerated]
	private readonly global::System.DateTime _LastWriteTime_k__BackingField;

	internal static McpLocalFile X0UtrKLvFShCfqxFmZkH;

	public string FilePath
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _FilePath_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004c->IL0010: Incompatible stack types: I4 vs O
			//IL_0057->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0031;
					IL_0031:
					_FilePath_k__BackingField = value;
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b == 0)
					{
						obj2 = 1;
					}
				}
			}
		}
	}

	public string FileName
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return System.IO.Path.GetFileName(FilePath);
		}
	}

	public long SizeBytes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _SizeBytes_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_SizeBytes_k__BackingField = value;
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_2b2f512a98d548488e5242742b1ff011 != 0)
					{
						obj2 = 3;
					}
				}
			}
		}
	}

	public bool IsInjected
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _IsInjected_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004c->IL0010: Incompatible stack types: I4 vs O
			//IL_0057->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					case 0:
						return;
					case 1:
						_IsInjected_k__BackingField = value;
						obj2 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc != 0)
						{
							obj2 = 5;
						}
						continue;
					}
					break;
				}
			}
			while ((nint)obj == 989);
		}
	}

	public string StatusText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			//IL_005f->IL0010: Incompatible stack types: I4 vs O
			//IL_006a->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						goto IL_0021;
					case 1:
						if (IsInjected)
						{
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4f82b5c32b3f4f0289c9a252a3907b21 == 0)
							{
								obj2 = 5;
							}
							continue;
						}
						goto case 2;
					case 2:
						return "未注入";
					case 0:
						break;
					}
					goto IL_008c;
					IL_0021:
					if ((nint)obj == 990)
					{
						break;
					}
					goto IL_008c;
					IL_008c:
					return "已发送，等待游戏确认";
				}
			}
		}
	}

	public string ActionText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			//IL_005f->IL0010: Incompatible stack types: I4 vs O
			//IL_006a->IL0010: Incompatible stack types: I4 vs O
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						goto IL_0021;
					case 2:
						if (IsInjected)
						{
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						goto case 0;
					case 0:
						return "注入";
					case 1:
						break;
					}
					goto IL_008c;
					IL_0021:
					if ((nint)obj == 990)
					{
						break;
					}
					goto IL_008c;
					IL_008c:
					return "重新发送";
				}
			}
		}
	}

	public string EntryModule
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _EntryModule_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_EntryModule_k__BackingField = value;
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 != 0)
					{
						obj2 = 6;
					}
				}
			}
		}
	}

	public string EntryText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0021: Expected I4, but got O
			//IL_0092->IL0010: Incompatible stack types: I4 vs O
			//IL_009d->IL0010: Incompatible stack types: I4 vs O
			object obj = 2;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 990)
						{
							break;
						}
						goto case 2;
					case 0:
						return EntryModule;
					case 1:
						return "入口未识别，请填写备用入口";
					case 2:
						if (string.IsNullOrWhiteSpace(EntryModule))
						{
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_36a48f7fc5034120a3fadb53ab2f53cc == 0)
							{
								obj2 = 1;
							}
							continue;
						}
						goto case 0;
					}
					break;
				}
			}
		}
	}

	public unsafe string DetailText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_002d: Expected I4, but got O
			//IL_00e6->IL0010: Incompatible stack types: I4 vs O
			//IL_0127->IL0010: Incompatible stack types: I4 vs O
			//IL_008a->IL0010: Incompatible stack types: I4 vs O
			//IL_0158->IL0010: Incompatible stack types: I4 vs O
			//IL_00b5->IL0010: Incompatible stack types: I4 vs O
			//IL_0132->IL0010: Incompatible stack types: I4 vs O
			//IL_0095->IL0010: Incompatible stack types: I4 vs O
			//IL_0163->IL0010: Incompatible stack types: I4 vs O
			int num = 5;
			object obj3 = default(object);
			while (true)
			{
				object obj = num;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj != 12)
							{
								if ((nint)obj == 993)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							return (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).ToStringAndClear();
						case 3:
							((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3))->AppendFormatted<global::System.DateTime>(LastWriteTime, "yyyy-MM-dd HH:mm");
							obj2 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7d9cb56da18447908e8451f934a19bb2 == 0)
							{
								obj2 = 1;
							}
							continue;
						case 5:
							*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(6, 3);
							obj2 = 4;
							continue;
						case 0:
							(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).AppendLiteral(" · ");
							obj2 = 3;
							continue;
						case 1:
							(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).AppendLiteral(" · ");
							obj2 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4967aebcec78421b855bda2f45c82247 == 0)
							{
								obj2 = 2;
							}
							continue;
						case 4:
							(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).AppendFormatted(SizeText);
							obj2 = 10;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_527dac5507ee46fcb9d22f9ff955c1d0 == 0)
							{
								obj2 = 0;
							}
							continue;
						case 2:
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
				(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).AppendFormatted((FileName).StartsWith("cloud-", (StringComparison)5) ? "云端同步" : "本地文件");
				num = 12;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a == 0)
				{
					num = 8;
				}
			}
		}
	}

	public unsafe string SizeText
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_016e->IL0010: Incompatible stack types: I4 vs O
			//IL_01f0->IL0010: Incompatible stack types: I4 vs O
			//IL_0218->IL0010: Incompatible stack types: I4 vs O
			//IL_0179->IL0010: Incompatible stack types: I4 vs O
			//IL_01fb->IL0010: Incompatible stack types: I4 vs O
			//IL_0223->IL0010: Incompatible stack types: I4 vs O
			//IL_0199->IL0010: Incompatible stack types: I4 vs O
			//IL_0084->IL0010: Incompatible stack types: I4 vs O
			//IL_0128->IL0010: Incompatible stack types: I4 vs O
			//IL_008f->IL0010: Incompatible stack types: I4 vs O
			//IL_0133->IL0010: Incompatible stack types: I4 vs O
			int num = 6;
			object obj3 = default(object);
			object obj4 = default(object);
			while (true)
			{
				object obj = num;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj != 13)
							{
								if ((nint)obj == 994)
								{
									goto end_IL_0010;
								}
								goto case 6;
							}
							(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).AppendLiteral(" KiB");
							obj2 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7880b59a09bf4a2190c2568d83d12e71 != 0)
							{
								obj2 = 6;
							}
							continue;
						case 4:
							return (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj4)).ToStringAndClear();
						case 6:
							if (SizeBytes < 1048576)
							{
								obj2 = 5;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b28f7b3c5e414da9823acaf82070b1eb != 0)
								{
									obj2 = 13;
								}
							}
							else
							{
								*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj4) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
								obj2 = 3;
							}
							continue;
						case 0:
							break;
						case 1:
							(*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj4)).AppendLiteral(" MiB");
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a2042ba402cd4aaf989f075337c5eaf7 == 0)
							{
								obj2 = 4;
							}
							continue;
						case 2:
							return (*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3)).ToStringAndClear();
						case 3:
							((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj4))->AppendFormatted<double>((double)SizeBytes / 1024.0 / 1024.0, "0.##");
							obj2 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
							{
								obj2 = 4;
							}
							continue;
						case 5:
							*(global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3) = new global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler(4, 1);
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5144ebdc507c41fb87d88fdce3dc76e9 == 0)
							{
								obj2 = 11;
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
				((global::System.Runtime.CompilerServices.DefaultInterpolatedStringHandler*)(&obj3))->AppendFormatted<double>((double)SizeBytes / 1024.0, "0.##");
				num = 3;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4ae4de12ce674c26bc2939a5789df8ab == 0)
				{
					num = 13;
				}
			}
		}
	}

	public global::System.DateTime LastWriteTime
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return _LastWriteTime_k__BackingField;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		init
		{
			//IL_000c: Expected O, but got I4
			//IL_001d: Expected I4, but got O
			//IL_004b->IL0010: Incompatible stack types: I4 vs O
			//IL_0056->IL0010: Incompatible stack types: I4 vs O
			object obj = 1;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
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
					if ((nint)obj == 989)
					{
						break;
					}
					goto IL_0030;
					IL_0030:
					_LastWriteTime_k__BackingField = value;
					obj2 = 4;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_dabc6698d5764018a5f86ef3b5a7871e != 0)
					{
						obj2 = 0;
					}
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public McpLocalFile()
	{
		//IL_006c: Expected I4, but got O
		//IL_0051->IL0063: Incompatible stack types: I4 vs O
		//IL_005c->IL0063: Incompatible stack types: I4 vs O
		_FilePath_k__BackingField = string.Empty;
		_EntryModule_k__BackingField = string.Empty;
		object obj = 4;
		if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_70c2a79cb96d4e75a079385f00e7bf58 == 0)
		{
			obj = 0;
		}
		object obj2 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			case 0:
				return;
			}
			if ((nint)obj2 == 988)
			{
				obj = obj2;
				continue;
			}
			return;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool RMZRhCLvsCkaoB97gDS6()
	{
		return X0UtrKLvFShCfqxFmZkH == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpLocalFile CNYm1SLvTtXZ5kVJTxpe()
	{
		return X0UtrKLvFShCfqxFmZkH;
	}
}

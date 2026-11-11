using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace pP8gJUXq52Ip5dHhgodd;

internal sealed class KYxDNCXqOpQF3JF9F6k2 : IEquatable<KYxDNCXqOpQF3JF9F6k2>
{
	[CompilerGenerated]
	private string qdaXqP1QASJ;

	[CompilerGenerated]
	private string lK1XqxPi4Mk;

	[CompilerGenerated]
	private byte[] QvUXqFvmlbO;

	[CompilerGenerated]
	private string? UaKXqs3Q1IX;

	internal static object eNtCbPZxFt9d9guDWrDp;

	[CompilerGenerated]
	private global::System.Type EqualityContract
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return System.Type.GetTypeFromHandle(typeof(KYxDNCXqOpQF3JF9F6k2).TypeHandle);
		}
	}

	public string FileName
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return qdaXqP1QASJ;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			qdaXqP1QASJ = value;
		}
	}

	public string Sha256
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return lK1XqxPi4Mk;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			lK1XqxPi4Mk = value;
		}
	}

	public byte[] Bytes
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return QvUXqFvmlbO;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			QvUXqFvmlbO = value;
		}
	}

	internal string? PreviousSha256
	{
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		get
		{
			return UaKXqs3Q1IX;
		}
		[MethodImpl((MethodImplOptions)8)]
		[CompilerGenerated]
		set
		{
			UaKXqs3Q1IX = value;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public KYxDNCXqOpQF3JF9F6k2(string FileName, string Sha256, byte[] Bytes)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Collections.Generic.IReadOnlyList<KYxDNCXqOpQF3JF9F6k2> nBJXq6DU9vk()
	{
		return new global::__z__ReadOnlyArray_1<KYxDNCXqOpQF3JF9F6k2>(new KYxDNCXqOpQF3JF9F6k2[2]
		{
			Load("Script_PlatformPatcher.mcp", "A393AEB34A7B2BB799503D12C4FD9B916F43E60B035DCB842D04ED3D5964CF75", "5CE5565CED2F578DC55AE266576DFD7615E2F667E0C80406D1DDDC63DBD4A716"),
			Load("xdpatch.mcp", "BDE670FE8F0D02B8A779E540A6F1F6DBFF3A146DFB2C3C6AFEAAA28147CE962C", "0FA852379BC6DF51DEEBD200E302E6756213EF57352EBF54B140899B77ECA851")
		});
	}

	[MethodImpl((MethodImplOptions)8)]
	private static KYxDNCXqOpQF3JF9F6k2 Load(object fileName, object expectedHash, object previousHash)
	{
		//IL_0788: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Stream val = default(Stream);
		int num3 = default(int);
		int num6 = default(int);
		StreamReader val2 = default(StreamReader);
		bool flag = default(bool);
		int num8 = default(int);
		KYxDNCXqOpQF3JF9F6k2 result = default(KYxDNCXqOpQF3JF9F6k2);
		int num10 = default(int);
		int num12 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj3);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num13);
		global::System.Exception ex = default(global::System.Exception);
		int num14 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num15);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num17 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					Stream obj = ((System.Type.GetTypeFromHandle(typeof(KYxDNCXqOpQF3JF9F6k2).TypeHandle)).Assembly).GetManifestResourceStream(string.Concat("Mahiro_Account.Resources.Bedrock.ThirdPartyMcp.", (string)fileName, ".b64"));
					int num2;
					if (obj == null)
					{
						num2 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 != 0)
						{
							num2 = 1;
						}
					}
					else
					{
						val = obj;
						num2 = 6;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 == 0)
						{
							num2 = 0;
						}
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								goto IL_00d2;
							}
							break;
						case 1:
							throw new InvalidDataException(string.Concat("缺少内置MCP 补丁：", (string)fileName));
						case 0:
							break;
						}
						break;
						IL_00d2:
						num2 = num3;
					}
					try
					{
						long num4 = (val).Length;
						int num5 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
						{
							num5 = 7;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (num6 != 16)
								{
									if (num6 != 996)
									{
										break;
									}
									goto IL_017f;
								}
								val2 = new StreamReader(val);
								num5 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
								{
									num5 = 2;
								}
								continue;
							case 5:
								flag = false;
								num5 = 3;
								continue;
							case 4:
								if (num4 <= 0)
								{
									num5 = 6;
									continue;
								}
								goto case 1;
							case 6:
							case 8:
								flag = true;
								num5 = 9;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e939b965ce4f483284ca421b00b7da71 == 0)
								{
									num5 = 7;
								}
								continue;
							case 0:
								throw new InvalidDataException("内置 MCP 补丁资源大小无效");
							case 3:
							case 7:
								if (!flag)
								{
									num6 = 16;
									goto IL_017f;
								}
								goto case 0;
							case 1:
								if (num4 > 65536)
								{
									num5 = 8;
									continue;
								}
								goto case 5;
							case 2:
								break;
								IL_017f:
								num5 = num6;
								continue;
							}
							break;
						}
						try
						{
							byte[] array = System.Convert.FromBase64String((val2).ReadToEnd());
							int num7 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
							{
								num7 = 1;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 != 14)
									{
										if (num8 == 994)
										{
											goto IL_0332;
										}
										goto case 2;
									}
									goto case 3;
								case 1:
									if (array.Length < 24)
									{
										num8 = 14;
										goto IL_0332;
									}
									goto case 6;
								case 3:
								case 5:
									throw new InvalidDataException(string.Concat("内置 MCP 补丁完整性校验失败：", (string)fileName));
								case 2:
									result = (KYxDNCXqOpQF3JF9F6k2)new KYxDNCXqOpQF3JF9F6k2((string)fileName, (string)expectedHash, array)
									{
										PreviousSha256 = (string?)previousHash
									};
									num7 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2a252ce41d574f549182b8db30d3d037 != 0)
									{
										num7 = 14;
									}
									continue;
								case 4:
									if (string.Equals(System.Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(array)), (string)expectedHash, (StringComparison)4))
									{
										num7 = 2;
										continue;
									}
									goto case 3;
								case 6:
									if (!MemoryExtensions.SequenceEqual<byte>(MemoryExtensions.AsSpan<byte>(array, 0, 4), "MCPK"u8))
									{
										num7 = 5;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
										{
											num7 = 7;
										}
										continue;
									}
									goto case 4;
								case 0:
									break;
									IL_0332:
									num7 = num8;
									continue;
								}
								break;
							}
						}
						finally
						{
							if (val2 != null)
							{
								int num9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
								{
									num9 = 6;
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
										break;
									case 1:
										goto end_IL_04ec;
									}
									(val2).Dispose();
									num9 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
									{
										num9 = 6;
									}
									continue;
									end_IL_04ec:
									break;
								}
							}
						}
					}
					finally
					{
						int num11;
						if (val == null)
						{
							num11 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
							{
								num11 = 2;
							}
							goto IL_0570;
						}
						goto IL_0594;
						IL_0570:
						while (true)
						{
							switch (num11)
							{
							default:
								if (num12 == 990)
								{
									goto IL_056c;
								}
								break;
							case 1:
								break;
							case 2:
								goto end_IL_0570;
							case 0:
								goto end_IL_0570;
							}
							goto IL_0594;
							IL_056c:
							num11 = num12;
							continue;
							end_IL_0570:
							break;
						}
						goto end_IL_0538;
						IL_0594:
						(val).Dispose();
						num11 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d == 0)
						{
							num11 = 0;
						}
						goto IL_0570;
						end_IL_0538:;
					}
				}
				catch (global::System.Exception obj2) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj3 = obj2 as global::System.Exception;
					if (obj3 == null)
					{
						num13 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
						{
							num13 = 2;
						}
					}
					else
					{
						ex = obj3;
						num13 = 5;
					}
					while (true)
					{
						switch (num13)
						{
						default:
							if (num14 == 13)
							{
								goto IL_0664;
							}
							if (num14 == 993)
							{
								goto IL_0622;
							}
							goto case 2;
						case 1:
							if (ex is FormatException)
							{
								num15 = 13;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
								{
									num15 = 11;
								}
								num14 = num15;
								goto IL_0622;
							}
							goto case 4;
						case 5:
							if (!(ex is IOException))
							{
								num13 = 1;
								continue;
							}
							goto IL_0664;
						case 4:
							flag = false;
							num13 = 3;
							continue;
						case 2:
							result2 = 0;
							break;
						case 0:
						case 3:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0664:
							flag = true;
							num13 = 12;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
							{
								num13 = 0;
							}
							continue;
							IL_0622:
							num13 = num14;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num16 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
					{
						num16 = 6;
					}
					while (true)
					{
						switch (num16)
						{
						default:
							if (num17 == 988)
							{
								goto IL_073f;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_073f:
						num16 = num17;
					}
					throw new InvalidDataException(string.Concat("读取内置MCP 补丁失败：", (string)fileName), ex);
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override string ToString()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		StringBuilder val = new StringBuilder();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private bool AARXqRnlgyS(StringBuilder builder)
	{
		System.Runtime.CompilerServices.RuntimeHelpers.EnsureSufficientExecutionStack();
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator !=(KYxDNCXqOpQF3JF9F6k2? left, KYxDNCXqOpQF3JF9F6k2? right)
	{
		return !(left == right);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public static bool operator ==(KYxDNCXqOpQF3JF9F6k2? left, KYxDNCXqOpQF3JF9F6k2? right)
	{
		int num = 1;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override int GetHashCode()
	{
		return (((EqualityComparer<global::System.Type>.Default.GetHashCode(EqualityContract) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(qdaXqP1QASJ)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(lK1XqxPi4Mk)) * -1521134295 + EqualityComparer<byte[]>.Default.GetHashCode(QvUXqFvmlbO)) * -1521134295 + EqualityComparer<string>.Default.GetHashCode(UaKXqs3Q1IX);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public override bool Equals(object? obj)
	{
		return Equals(obj as KYxDNCXqOpQF3JF9F6k2);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public bool Equals(KYxDNCXqOpQF3JF9F6k2? other)
	{
		int num = 7;
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public KYxDNCXqOpQF3JF9F6k2 YbNXqwPfIg2()
	{
		return (KYxDNCXqOpQF3JF9F6k2)new KYxDNCXqOpQF3JF9F6k2(this);
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	private KYxDNCXqOpQF3JF9F6k2(KYxDNCXqOpQF3JF9F6k2 original)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[CompilerGenerated]
	public void ardXqeDZ1ej(out string FileName, out string Sha256, out byte[] Bytes)
	{
		FileName = default(string);
		Sha256 = default(string);
		Bytes = default(byte[]);
		//IL_0008: Expected I8, but got O
FileName = this.FileName;  // was Unsafe.As<_,long> reinterpret
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool t7fjChZxsL46HniIBUpU()
	{
		return eNtCbPZxFt9d9guDWrDp == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static KYxDNCXqOpQF3JF9F6k2 uUuc8rZxTHhjTBu18s9C()
	{
		return (KYxDNCXqOpQF3JF9F6k2)eNtCbPZxFt9d9guDWrDp;
	}
}

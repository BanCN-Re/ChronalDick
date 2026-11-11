using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Features.McpStudio.Services;

internal class McpFileMetadata
{
	private static McpFileMetadata POA8KCLvdkTn9Y18Nh0q;

	[MethodImpl((MethodImplOptions)8)]
	public unsafe static string ReadEntry(string path)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_0359: Expected I4, but got O
		//IL_03d6: Expected I4, but got O
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_02cc: Expected I4, but got O
		//IL_0076: Expected I4, but got O
		//IL_00b0: Expected O, but got I4
		//IL_00d5: Expected I4, but got O
		//IL_032f->IL034c: Incompatible stack types: I4 vs O
		//IL_03ac->IL03c9: Incompatible stack types: I4 vs O
		//IL_02f5->IL02bb: Incompatible stack types: I4 vs O
		//IL_029e->IL02bb: Incompatible stack types: I4 vs O
		//IL_033a->IL034c: Incompatible stack types: I4 vs O
		//IL_03b7->IL03c9: Incompatible stack types: I4 vs O
		//IL_02a9->IL02bb: Incompatible stack types: I4 vs O
		//IL_0387->IL034c: Incompatible stack types: I4 vs O
		//IL_0404->IL03c9: Incompatible stack types: I4 vs O
		//IL_0392->IL034c: Incompatible stack types: I4 vs O
		//IL_040f->IL03c9: Incompatible stack types: I4 vs O
		//IL_0050->IL006d: Incompatible stack types: I4 vs O
		//IL_005b->IL006d: Incompatible stack types: I4 vs O
		//IL_00a2->IL00b4: Incompatible stack types: I4 vs O
		//IL_01c5->IL00b4: Incompatible stack types: I4 vs O
		//IL_0198->IL00b4: Incompatible stack types: I4 vs O
		//IL_0120->IL00b4: Incompatible stack types: I4 vs O
		//IL_0153->IL00b4: Incompatible stack types: I4 vs O
		//IL_01d0->IL00b4: Incompatible stack types: I4 vs O
		//IL_0225->IL00b4: Incompatible stack types: I4 vs O
		//IL_01a3->IL00b4: Incompatible stack types: I4 vs O
		//IL_012b->IL00b4: Incompatible stack types: I4 vs O
		//IL_0230->IL00b4: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj4 = default(object);
		object obj8 = default(object);
		object result = default(object);
		object obj7 = default(object);
		object obj10 = default(object);
		object obj12 = default(object);
		object obj14 = default(object);
		while (true)
		{
			switch ((int)obj)
			{
			default:
				if ((nint)obj == 989)
				{
					continue;
				}
				goto case 1;
			case 1:
				try
				{
					System.IO.FileStream obj2 = new FileStream(path, (FileMode)3, (FileAccess)1, (FileShare)3);
					object obj3 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_5d72748c192f4bab9e19ca961e9277d1 == 0)
					{
						obj3 = 0;
					}
					while (true)
					{
						switch ((int)obj3)
						{
						default:
							if ((nint)obj4 == 988)
							{
								goto IL_0069;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0069:
						obj3 = obj4;
					}
					try
					{
						byte* obj5 = stackalloc byte[57];
						object obj6 = 2;
						while (true)
						{
							string text;
							int num;
							switch ((int)obj6)
							{
							default:
								if ((nint)obj8 != 14)
								{
									if ((nint)obj8 == 994)
									{
										goto IL_00b0;
									}
									goto case 4;
								}
								break;
							case 0:
								text = string.Empty;
								goto IL_025d;
							case 5:
								result = string.Empty;
								obj6 = 6;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cb74c857a9564cc0b30907ecfe1e0cdf == 0)
								{
									obj6 = 7;
								}
								continue;
							case 1:
								if (!MemoryExtensions.SequenceEqual<byte>(new global::System.ReadOnlySpan<byte>(obj5, 4), "MCPK"u8))
								{
									obj6 = 5;
									continue;
								}
								goto case 4;
							case 4:
								obj7 = ((System.Text.Encoding.ASCII).GetString(new global::System.ReadOnlySpan<byte>(obj5 + 24, 33)));
								obj6 = 3;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 != 0)
								{
									obj6 = 13;
								}
								continue;
							case 2:
								obj2.ReadExactly(new global::System.Span<byte>(obj5, 57));
								obj6 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_499faaea7a6445f1af0f623e48ebbb18 == 0)
								{
									obj6 = 4;
								}
								continue;
							case 6:
								break;
							case 3:
								{
									if (!System.Text.RegularExpressions.Regex.IsMatch((string)obj7, "^[A-Za-z_][A-Za-z0-9_]{0,31}$", (RegexOptions)512))
									{
										obj6 = 11;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b84585b58c384b95b0e0b94c466ccc55 != 0)
										{
											obj6 = 0;
										}
										continue;
									}
									text = string.Concat((string)obj7, ".modMain");
									goto IL_025d;
								}
								IL_025d:
								result = text;
								num = 14;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1545a17218a245d6823c855e6a4a65cd != 0)
								{
									num = 9;
								}
								obj8 = num;
								goto IL_00b0;
								IL_00b0:
								obj6 = obj8;
								continue;
							}
							break;
						}
					}
					finally
					{
						object obj9;
						if (obj2 == null)
						{
							obj9 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4fafd75e484e4b31a74460f9f0d54951 != 0)
							{
								obj9 = 1;
							}
							goto IL_02bb;
						}
						goto IL_02df;
						IL_02bb:
						while (true)
						{
							switch ((int)obj9)
							{
							default:
								if ((nint)obj10 == 990)
								{
									goto IL_02b7;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_02bb;
							case 2:
								goto end_IL_02bb;
							}
							goto IL_02df;
							IL_02b7:
							obj9 = obj10;
							continue;
							end_IL_02bb:
							break;
						}
						goto end_IL_0283;
						IL_02df:
						((dynamic)obj2).Dispose();
						obj9 = 2;
						goto IL_02bb;
						end_IL_0283:;
					}
				}
				catch (global::System.Exception)
				{
					object obj11 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6d6b99fc4578413f8bc3bdf9db0e7260 == 0)
					{
						obj11 = 7;
					}
					while (true)
					{
						switch ((int)obj11)
						{
						default:
							if ((nint)obj12 == 989)
							{
								obj11 = obj12;
								continue;
							}
							break;
						case 0:
							break;
						case 1:
							goto end_IL_034c;
						}
						result = string.Empty;
						obj11 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f102566966284916b14bc7efa63c0f5e == 0)
						{
							obj11 = 4;
						}
						continue;
						end_IL_034c:
						break;
					}
				}

				break;
			case 0:
				break;
			}
			break;
		}
		return (string)result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool JlrHU7LvKVurMTDHOtJw()
	{
		return POA8KCLvdkTn9Y18Nh0q == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static McpFileMetadata fykXHbLvHVcjmJLIVfEw()
	{
		return POA8KCLvdkTn9Y18Nh0q;
	}
}

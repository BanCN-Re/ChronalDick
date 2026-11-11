using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace F6Jv7fIHwQafwwIjX2a;

internal class NPfZKrIKwrtjW4M4W9S
{
	private static object It1i0GZyUxlE8jSRZfPG;

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] hmtItqLHkR(object deviceKey)
	{
		_ = 3;
		object obj = default(object);
		System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)obj);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string QU4IONGDLJ(object code, object deviceKey)
	{
		//IL_000c: Expected O, but got I4
		//IL_0041: Expected I4, but got O
		//IL_00b9: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_00ac: Expected O, but got I4
		//IL_013d: Expected I4, but got O
		//IL_0191: Expected I4, but got O
		//IL_00cd->IL0010: Incompatible stack types: I4 vs O
		//IL_0122->IL0134: Incompatible stack types: I4 vs O
		//IL_02cd->IL0010: Incompatible stack types: I4 vs O
		//IL_0075->IL0010: Incompatible stack types: I4 vs O
		//IL_00d8->IL0010: Incompatible stack types: I4 vs O
		//IL_00f5->IL0010: Incompatible stack types: I4 vs O
		//IL_02b5->IL0010: Incompatible stack types: I4 vs O
		//IL_012d->IL0134: Incompatible stack types: I4 vs O
		//IL_031b->IL0010: Incompatible stack types: I4 vs O
		//IL_0286->IL0010: Incompatible stack types: I4 vs O
		//IL_0100->IL0010: Incompatible stack types: I4 vs O
		//IL_02c0->IL0010: Incompatible stack types: I4 vs O
		//IL_0172->IL0184: Incompatible stack types: I4 vs O
		//IL_0326->IL0010: Incompatible stack types: I4 vs O
		//IL_0291->IL0010: Incompatible stack types: I4 vs O
		//IL_0260->IL0010: Incompatible stack types: I4 vs O
		//IL_017d->IL0184: Incompatible stack types: I4 vs O
		//IL_026b->IL0010: Incompatible stack types: I4 vs O
		//IL_01dd->IL0184: Incompatible stack types: I4 vs O
		//IL_01e8->IL0184: Incompatible stack types: I4 vs O
		int num = 5;
		object obj5 = default(object);
		object result = default(object);
		object obj3 = default(object);
		object obj8 = default(object);
		object obj10 = default(object);
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
						if ((nint)obj != 17)
						{
							if ((nint)obj == 998)
							{
								goto end_IL_0010;
							}
							goto case 8;
						}
						if ((nint)obj5 != 16)
						{
							obj2 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								obj2 = 3;
							}
							continue;
						}
						goto case 10;
					case 0:
						if ((nint)obj5 == 32)
						{
							obj2 = 10;
							continue;
						}
						goto case 2;
					case 1:
						return (string)result;
					case 4:
						throw new global::System.Exception("扫码确认票据为空，请刷新二维码");
					case 2:
						obj3 = 0;
						obj2 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 == 0)
						{
							obj2 = 17;
						}
						continue;
					case 3:
						if ((nint)obj5 != 24)
						{
							obj2 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 10;
					case 8:
					{
						object obj6 = System.Security.Cryptography.Aes.Create();
						object obj7 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
						{
							obj7 = 4;
						}
						while (true)
						{
							switch ((int)obj7)
							{
							default:
								if ((nint)obj8 == 988)
								{
									goto IL_0130;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0130:
							obj7 = obj8;
						}
						(obj6).Key = (byte[])deviceKey;
						object obj9 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 == 0)
						{
							obj9 = 1;
						}
						while (true)
						{
							switch ((int)obj9)
							{
							case 0:
								break;
							default:
								if ((nint)obj10 == 989)
								{
									obj9 = obj10;
									continue;
								}
								goto case 1;
							case 1:
								result = (System.Convert.ToHexString((obj6).EncryptEcb((byte[])obj4, (PaddingMode)2))).ToLowerInvariant();
								obj9 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
								{
									obj9 = 4;
								}
								continue;
							}
							break;
						}
						goto case 1;
					}
					case 6:
					case 9:
						if (obj3 == null)
						{
							obj2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
							{
								obj2 = 7;
							}
							continue;
						}
						obj4 = (System.Text.Encoding.UTF8).GetBytes((string)code);
						obj2 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							obj2 = 8;
						}
						continue;
					case 5:
						if (string.IsNullOrWhiteSpace((string)code))
						{
							obj2 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
							{
								obj2 = 4;
							}
							continue;
						}
						break;
					case 10:
						obj3 = 1;
						obj2 = 6;
						continue;
					case 7:
						throw new global::System.Exception("扫码设备密钥无效，请刷新二维码");
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
			obj5 = ((global::System.Array)deviceKey).Length;
			num = 17;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_0090->IL0012: Incompatible stack types: I4 vs O
		//IL_009b->IL0012: Incompatible stack types: I4 vs O
		//IL_006c->IL0012: Incompatible stack types: I4 vs O
		//IL_0077->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
		while (true)
		{
			object obj = num;
			do
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj == 9)
						{
							obj2 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
							{
								obj2 = 5;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						break;
					case 0:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						obj2 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							obj2 = 1;
						}
						continue;
					case 1:
						return;
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
			while ((nint)obj == 990);
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool HvcSoAZyrAsVXbR4Lp5g()
	{
		return It1i0GZyUxlE8jSRZfPG == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static NPfZKrIKwrtjW4M4W9S AmDysRZyogAcZMqJYKIa()
	{
		return (NPfZKrIKwrtjW4M4W9S)It1i0GZyUxlE8jSRZfPG;
	}
}

using System;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using DA13y7xHUtQiwdGNt7U;
using fDAldojjppXrctUVYOJn;
using rMkIZlXyJT7Lr8FeHxg2;

namespace sZGBXiX0rghqRUfae1R0;

internal sealed class mqwGTJX0UyTeCkIn2cxf : global::System.IDisposable
{
	private readonly Wtxhn7xKZiMM9ABDupm UxHX0gudTrN;

	private readonly Wtxhn7xKZiMM9ABDupm eETX0l3dVIt;

	private bool I3QX0dxIrn8;

	private static object oij74rZgW1ftsxgTWCLR;

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe mqwGTJX0UyTeCkIn2cxf(global::System.ReadOnlySpan<byte> token, global::System.ReadOnlySpan<byte> seed)
	{
		//IL_0134->IL02a9: Incompatible stack heights: 0 vs 1
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		int num = 1;
		int num2 = default(int);
		byte[] array = default(byte[]);
		byte[] nonce = default(byte[]);
		int num5 = default(int);
		byte[] array2 = default(byte[]);
		int num7 = default(int);
		while (true)
		{
			int num3;
			switch (num)
			{
			default:
				if (num2 != 13)
				{
					if (num2 == 993)
					{
						goto IL_0031;
					}
					goto case 3;
				}
				_ = "Java 认证 Token 长度无效";
				throw new global::System.Exception("token");
			case 1:
				if (&token != (global::System.ReadOnlySpan<byte>*)16)
				{
					num3 = 12;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
					{
						num3 = 13;
					}
					goto IL_002d;
				}
				oov9t2XyW3hlO08SkVYQ.zrEXyhtvWL1(seed);
				num = 3;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
				{
					num = 3;
				}
				break;
			case 0:
				try
				{
					UxHX0gudTrN = (Wtxhn7xKZiMM9ABDupm)new Wtxhn7xKZiMM9ABDupm((global::System.ReadOnlySpan<byte>)array, (global::System.ReadOnlySpan<byte>)nonce);
					int num4 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							if (num5 == 989)
							{
								num4 = num5;
								continue;
							}
							break;
						case 1:
							break;
						case 0:
							return;
						}
						eETX0l3dVIt = (Wtxhn7xKZiMM9ABDupm)new Wtxhn7xKZiMM9ABDupm((global::System.ReadOnlySpan<byte>)array2, (global::System.ReadOnlySpan<byte>)nonce);
						num4 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							num4 = 0;
						}
					}
				}
				finally
				{
					System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array);
					int num6 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
					{
						num6 = 5;
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
							System.Security.Cryptography.CryptographicOperations.ZeroMemory((global::System.Span<byte>)array2);
							num6 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c != 0)
							{
								num6 = 7;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			case 2:
				array2 = U0bX0IW6txx(seed, token);
				num = 10;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				nonce = (System.Text.Encoding.ASCII).GetBytes("163 NetEase\n");
				num3 = 4;
				goto IL_002d;
			case 4:
				array = U0bX0IW6txx(token, seed);
				num = 2;
				break;
			case 5:
				return;
				IL_002d:
				num2 = num3;
				goto IL_0031;
				IL_0031:
				num = num2;
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal byte[] AtwX0od2yOx(byte type, global::System.ReadOnlySpan<byte> payload)
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
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					System.ObjectDisposedException.ThrowIf(I3QX0dxIrn8, this);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return uxlX07Id0su(UxHX0gudTrN, type, payload);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ValueTuple<byte, byte[]> guYX0m9SHAv(global::System.Span<byte> encryptedBody)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 989)
					{
						break;
					}
					goto case 1;
				case 1:
					System.ObjectDisposedException.ThrowIf(I3QX0dxIrn8, this);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 == 0)
					{
						num2 = 6;
					}
					continue;
				case 0:
					return GavX0ALQqle(eETX0l3dVIt, encryptedBody);
				}
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] uxlX07Id0su(object cipher, byte type, global::System.ReadOnlySpan<byte> payload)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ValueTuple<byte, byte[]> GavX0ALQqle(Wtxhn7xKZiMM9ABDupm cipher, global::System.Span<byte> encryptedBody)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		return default(ValueTuple<byte, byte[]>);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] U0bX0IW6txx(global::System.ReadOnlySpan<byte> first, global::System.ReadOnlySpan<byte> second)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
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
						if (num2 == 11)
						{
							return;
						}
						goto IL_0037;
					case 4:
						UxHX0gudTrN.Dispose();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						goto end_IL_000c;
					case 2:
						return;
					case 0:
						I3QX0dxIrn8 = true;
						num3 = 4;
						continue;
					case 1:
						break;
					}
					goto IL_00a8;
					IL_0037:
					if (num2 == 992)
					{
						break;
					}
					goto IL_00a8;
					IL_00a8:
					if (I3QX0dxIrn8)
					{
						return;
					}
					num3 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 != 0)
					{
						num3 = 0;
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			eETX0l3dVIt.Dispose();
			num = 11;
		}
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
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 0:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 1;
						}
						continue;
					case 2:
						num3 = 1;
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SokUyTZgJUm3rKNce2Lb()
	{
		return oij74rZgW1ftsxgTWCLR == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static mqwGTJX0UyTeCkIn2cxf v4YiVFZgQONWPZQO399Q()
	{
		return (mqwGTJX0UyTeCkIn2cxf)oij74rZgW1ftsxgTWCLR;
	}
}

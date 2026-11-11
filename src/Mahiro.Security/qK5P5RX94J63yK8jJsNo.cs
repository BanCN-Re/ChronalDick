using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace FNZYemX9hTsCS2mHgSne;

internal ref struct qK5P5RX94J63yK8jJsNo
{
	private readonly global::System.ReadOnlySpan<byte> HSuX9g84IeS;

	private readonly Encoding SdAX9llYFrQ;

	private int PEcX9dqXeIf;

	internal static object a7ssHIZAwTO2U6iocnZi;

	internal int Remaining
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return HSuX9g84IeS.Length - PEcX9dqXeIf;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal qK5P5RX94J63yK8jJsNo(global::System.ReadOnlySpan<byte> payload, Encoding encoding)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal short AnCX9Up5NK8(string fieldName)
	{
		JUoX9BK6yn1(2, fieldName);
		return default(short);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ushort j6rX9rPJ0Ch(string fieldName)
	{
		JUoX9BK6yn1(2, fieldName);
		return default(ushort);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal int jlqX9ovv2tE(string fieldName)
	{
		JUoX9BK6yn1(4, fieldName);
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal uint HqxX9mS8a4f(string fieldName)
	{
		JUoX9BK6yn1(4, fieldName);
		return default(uint);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal string PrvX97LRNgd(string fieldName)
	{
		//IL_013f: Expected O, but got Unknown
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		ushort num3 = default(ushort);
		string result = default(string);
		int num5 = default(int);
		int num7 = default(int);
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
					goto case 0;
				case 2:
					JUoX9BK6yn1(num3, fieldName);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
					{
						num2 = 3;
					}
					break;
				case 0:
					return result;
				case 3:
					num3 = j6rX9rPJ0Ch(string.Concat(fieldName, "长度"));
					num2 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					try
					{
						string text = (SdAX9llYFrQ).GetString(HSuX9g84IeS.Slice(PEcX9dqXeIf, (int)num3));
						PEcX9dqXeIf += num3;
						result = text;
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
						{
							num4 = 5;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								if (num5 == 988)
								{
									num4 = num5;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					catch (DecoderFallbackException ex)
					{
						DecoderFallbackException ex2 = ex;
						int num6 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 988)
								{
									goto IL_016c;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_016c:
							num6 = num7;
						}
						throw new InvalidDataException(string.Concat("Java RPC 的", fieldName, "编码无效"), (global::System.Exception)(object)ex2);
					}
					goto case 0;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Collections.Generic.IReadOnlyList<ulong> FpiX9A2bNqE(string fieldName)
	{
		ushort num = j6rX9rPJ0Ch(string.Concat(fieldName, "长度"));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void xqTX9IJgno1()
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	private void JUoX9BK6yn1(int byteCount, string fieldName)
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SURh0qZAeX81RSClU4Hx()
	{
		return a7ssHIZAwTO2U6iocnZi == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object aEHrn9ZAPp1A5RZEB5Ye()
	{
		return a7ssHIZAwTO2U6iocnZi;
	}
}

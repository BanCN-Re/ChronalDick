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

	internal unsafe int Remaining
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (int)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref HSuX9g84IeS, PEcX9dqXeIf));
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal qK5P5RX94J63yK8jJsNo(global::System.ReadOnlySpan<byte> payload, Encoding encoding)
	{
		int num = 11;
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
					case 2:
						PEcX9dqXeIf = 0;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 != 0)
						{
							num3 = 4;
						}
						continue;
					case 1:
						goto end_IL_000d;
					case 0:
						return;
					case 3:
						SdAX9llYFrQ = encoding ?? throw "encoding";
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 != 0)
						{
							num3 = 8;
						}
						continue;
					}
					switch (num2)
					{
					case 991:
						break;
					default:
						return;
					case 11:
						HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 == 0)
						{
							num3 = 2;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000d:
				break;
			}
			HSuX9g84IeS = payload;
			num = 3;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal short AnCX9Up5NK8(string fieldName)
	{
		//IL_0047: Expected O, but got I4
		int num = 1;
		global::System.ReadOnlySpan<byte> hSuX9g84IeS = default(global::System.ReadOnlySpan<byte>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 2:
				{
					_ = hSuX9g84IeS;
					short result = System.Buffers.Binary.BinaryPrimitives.ReadInt16LittleEndian((global::System.ReadOnlySpan<byte>)PEcX9dqXeIf);
					PEcX9dqXeIf += 2;
					return result;
				}
				case 1:
					JUoX9BK6yn1(2, fieldName);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 == 0)
					{
						num2 = 5;
					}
					continue;
				case 0:
					break;
				}
				goto IL_007d;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_007d;
				IL_007d:
				hSuX9g84IeS = HSuX9g84IeS;
				num2 = 5;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal ushort j6rX9rPJ0Ch(string fieldName)
	{
		//IL_0095: Expected O, but got I4
		int num = 2;
		global::System.ReadOnlySpan<byte> hSuX9g84IeS = default(global::System.ReadOnlySpan<byte>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 2:
					JUoX9BK6yn1(2, fieldName);
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					hSuX9g84IeS = HSuX9g84IeS;
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0f66b3fd30a44939d479a38aedaf5c6 != 0)
					{
						num2 = 5;
					}
					break;
				case 0:
				{
					_ = hSuX9g84IeS;
					ushort result = System.Buffers.Binary.BinaryPrimitives.ReadUInt16LittleEndian((global::System.ReadOnlySpan<byte>)PEcX9dqXeIf);
					PEcX9dqXeIf += 2;
					return result;
				}
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal int jlqX9ovv2tE(string fieldName)
	{
		//IL_006e: Expected O, but got I4
		int num = 1;
		global::System.ReadOnlySpan<byte> hSuX9g84IeS = default(global::System.ReadOnlySpan<byte>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					goto IL_0021;
				case 0:
					hSuX9g84IeS = HSuX9g84IeS;
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
				{
					_ = hSuX9g84IeS;
					int result = System.Buffers.Binary.BinaryPrimitives.ReadInt32LittleEndian((global::System.ReadOnlySpan<byte>)PEcX9dqXeIf);
					PEcX9dqXeIf += 4;
					return result;
				}
				case 1:
					break;
				}
				goto IL_007d;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_007d;
				IL_007d:
				JUoX9BK6yn1(4, fieldName);
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal uint HqxX9mS8a4f(string fieldName)
	{
		//IL_0047: Expected O, but got I4
		int num = 2;
		global::System.ReadOnlySpan<byte> hSuX9g84IeS = default(global::System.ReadOnlySpan<byte>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
				{
					_ = hSuX9g84IeS;
					uint result = System.Buffers.Binary.BinaryPrimitives.ReadUInt32LittleEndian((global::System.ReadOnlySpan<byte>)PEcX9dqXeIf);
					PEcX9dqXeIf += 4;
					return result;
				}
				case 2:
					JUoX9BK6yn1(4, fieldName);
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					hSuX9g84IeS = HSuX9g84IeS;
					num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b177bdff0daa412994bbb49432a68b86 != 0)
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
	internal string PrvX97LRNgd(string fieldName)
	{
		//IL_013b: Expected O, but got Unknown
		//IL_00d6: Expected O, but got I4
		//IL_00d6: Expected O, but got I4
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
						_ = SdAX9llYFrQ;
						_ = HSuX9g84IeS;
						string text = (PEcX9dqXeIf).GetString((global::System.ReadOnlySpan<byte>)num3);
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
									goto IL_0168;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0168:
							num6 = num7;
						}
						string.Concat("Java RPC 的", fieldName, "编码无效");
						throw ex2;
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
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void xqTX9IJgno1()
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
					throw new global::System.Exception("Java RPC 事件包含未识别的尾部数据");
				case 1:
					break;
				}
				goto IL_004f;
				IL_001d:
				if (num == 989)
				{
					break;
				}
				goto IL_004f;
				IL_004f:
				if (Remaining == 0)
				{
					return;
				}
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
				{
					num2 = 0;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private void JUoX9BK6yn1(int byteCount, string fieldName)
	{
		int num = 2;
		while (true)
		{
		// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
		// semantics of this body (see MAHIRO-V2-BUILD.md).
		throw new global::System.NotSupportedException();
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
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
								goto end_IL_0012;
							}
							goto case 1;
						}
						return;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
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
			num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209 == 0)
			{
				num = 9;
			}
		}
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

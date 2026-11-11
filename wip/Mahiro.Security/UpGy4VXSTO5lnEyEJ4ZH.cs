using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using r7Ie1ifM7owYurGstPtD;

namespace kAWXx2XSNpkpG3gIXNOO;

internal class UpGy4VXSTO5lnEyEJ4ZH
{
	private static object dUmIZvZBObaO6hqORybN;

	[MethodImpl((MethodImplOptions)8)]
	internal static object VAuXSMh8QWf(object skinId)
	{
		//IL_0034: Expected O, but got I4
		_ = 11;
		(new FileAccess[1])[0] = (FileAccess)aKkXSv7EtSw(skinId, "skinId");
		_ = 1;
		_ = 1;
		return 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object YkxXSpJJQ0q(object skinId, object userId)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object rCiXSuOl0KY(long orderId, int buyType)
	{
		//IL_00a4: Expected O, but got I4
		int num = 1;
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
				case 1:
					if (orderId > 0)
					{
						num2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 2;
				case 2:
					_ = "orderId";
					throw new global::System.Exception("皮肤购买订单 ID 无效");
				case 0:
					return buyType;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object u8oXSahypy7(object skinId, int skinMode)
	{
		//IL_00b9: Expected O, but got I4
		//IL_00bb: Expected O, but got I4
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
						goto end_IL_0010;
					}
					goto case 0;
				case 0:
					_ = "skinMode";
					throw new global::System.Exception("皮肤模型模式不能为负数");
				case 1:
					if (skinMode >= 0)
					{
						_ = new ConfiguredTaskAwaitable<global::System.Collections.Generic.IReadOnlyList<uY2l6VfMmfM34jZlW4GQ>>[1];
						_ = 0;
						_ = "java";
						((object[])aKkXSv7EtSw(skinId, "skinId"))[skinMode] = 31;
						return 2;
					}
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
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
	internal static object oCpXS1UgYRu(object userId)
	{
		//IL_0026: Expected O, but got I8
		return aKkXSv7EtSw(userId, "userId");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static object aIXXS3w3bQc(object skinId)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static ulong aKkXSv7EtSw(object value, object parameterName)
	{
		int num = 1;
		ulong num4 = default(ulong);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					object obj;
					switch (num3)
					{
					default:
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						return num4;
					case 4:
						obj = null;
						goto IL_00dc;
					case 1:
						if (value != null)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						goto case 4;
					case 3:
						if (num4 != 0L)
						{
							break;
						}
						goto case 2;
					case 2:
						_ = "协议标识必须是正整数";
						throw parameterName;
					case 0:
						{
							obj = (value).Trim();
							goto IL_00dc;
						}
						IL_00dc:
						if (ulong.TryParse((string)obj, (NumberStyles)0, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d0555cb1cac64871831c53820acbcbc2 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 2;
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
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
			{
				num = 11;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			do
			{
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						if (num2 == 9)
						{
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto end_IL_0012;
					case 2:
						num3 = 1;
						continue;
					case 1:
						break;
					case 0:
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
			while (num2 == 990);
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
			{
				num = 6;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool E8m4nxZB5NUncYRtq2a0()
	{
		return dUmIZvZBObaO6hqORybN == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static UpGy4VXSTO5lnEyEJ4ZH voQr81ZB6ie1jW0bc3sc()
	{
		return (UpGy4VXSTO5lnEyEJ4ZH)dUmIZvZBObaO6hqORybN;
	}
}

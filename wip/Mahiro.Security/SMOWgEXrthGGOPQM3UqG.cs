using System;
using System.IO;
using System.Runtime.CompilerServices;
using BCXoLCXUvJyBkqc6IRk2;
using CZUx5njfSrbl1tnMcUCO;
using K48WkOXrQUD3xl2yuwa3;
using WFnhKyXrlFylPfUY2cRp;
using fDAldojjppXrctUVYOJn;

namespace CunBSaXrO51xPU1EwI3x;

internal class SMOWgEXrthGGOPQM3UqG
{
	private static object CH4FUKZHrxCphKp94LMd;

	[MethodImpl((MethodImplOptions)8)]
	internal static bool SBUXr5HDKj5(object packet, out z2ypj2XrgrQmJkmrSi5Q? message)
	{
		int num = 2;
		bool result = default(bool);
		int num4 = default(int);
		string text = default(string);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		int num7 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num9 = default(int);
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
					goto case 1;
				case 0:
					message = default;
					return result;
				case 1:
					try
					{
						int offset = 0;
						int num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee != 0)
						{
							num3 = 5;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 != 15)
								{
									if (num4 == 995)
									{
										goto IL_0068;
									}
									goto case 1;
								}
								break;
							case 4:
								break;
							case 5:
								text = LDmKkaXrJsoQ9MJDZJvB.nTbXr4FpagV((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)packet).Payload, ref offset);
								num3 = 3;
								continue;
							case 0:
								result = false;
								num3 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
								{
									num3 = 3;
								}
								continue;
							case 3:
								if (!string.IsNullOrWhiteSpace(text))
								{
									num3 = 6;
									continue;
								}
								goto case 0;
							case 6:
								if (offset <= ((qAftL0XU3M5I1RIneNTc)packet).Payload.Length)
								{
									num3 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
									{
										num3 = 7;
									}
									continue;
								}
								goto case 0;
							case 1:
								result = true;
								num4 = 15;
								goto IL_0068;
							case 2:
							case 7:
								{
									message = (z2ypj2XrgrQmJkmrSi5Q?)new z2ypj2XrgrQmJkmrSi5Q(text, Q89Xr66AtZS(text), ((qAftL0XU3M5I1RIneNTc)packet).Payload[System.Range.StartAt(((System.Index)offset))]);
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								IL_0068:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					catch (object obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num5 = 5;
							goto IL_0206;
						}
						ex = obj2;
						num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num6 = 2;
						}
						goto IL_020e;
						IL_020a:
						num6 = num7;
						goto IL_020e;
						IL_020e:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 != 15)
								{
									if (num7 == 995)
									{
										goto IL_020a;
									}
									goto case 2;
								}
								if (ex is InvalidOperationException)
								{
									num6 = 4;
									continue;
								}
								break;
							case 4:
							case 7:
								flag = true;
								num6 = 3;
								continue;
							case 0:
								if (!(ex is InvalidDataException))
								{
									goto end_IL_020e;
								}
								goto case 4;
							case 1:
								break;
							case 6:
								goto IL_02eb;
							case 5:
								result2 = 0;
								goto IL_0324;
							case 2:
							case 3:
								{
									result2 = (flag ? 1 : 0);
									goto IL_0324;
								}
								IL_0324:
								return (byte)result2 != 0;
							}
							if (ex is ArgumentException)
							{
								num6 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
								{
									num6 = 7;
								}
								continue;
							}
							goto IL_02eb;
							IL_02eb:
							flag = false;
							num6 = 2;
							continue;
							end_IL_020e:
							break;
						}
						num5 = 15;
						goto IL_0206;
						IL_0206:
						num7 = num5;
						goto IL_020a;
					}).Invoke())
					{
						int num8 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num8 = 7;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 == 989)
								{
									num8 = num9;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_0358;
							}
							result = false;
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num8 = 0;
							}
							continue;
							end_IL_0358:
							break;
						}
					}
					goto case 0;
				case 2:
					message = null;
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 != 0)
					{
						num2 = 1;
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
	internal static bool Q89Xr66AtZS(object channel)
	{
		int num = 3;
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
							goto case 3;
						}
						goto case 2;
					case 6:
						if (!(channel).StartsWith("fml:", (StringComparison)5))
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
							{
								num3 = 6;
							}
							break;
						}
						goto case 2;
					case 0:
						if (!(channel).Equals("FORGE", (StringComparison)5))
						{
							num3 = 6;
							break;
						}
						goto case 2;
					case 1:
						return (channel).StartsWith("forge:", (StringComparison)5);
					case 2:
						return true;
					case 4:
						if (!(channel).Equals("FML|MP", (StringComparison)5))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num3 = 12;
							}
							break;
						}
						goto case 2;
					case 5:
						if ((channel).Equals("FML|HS", (StringComparison)5))
						{
							num3 = 2;
							break;
						}
						goto case 4;
					case 3:
						if ((channel).Equals("FML", (StringComparison)5))
						{
							goto end_IL_000c;
						}
						goto case 5;
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
					case 2:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						goto end_IL_000e;
					case 0:
						return;
					}
					switch (num2)
					{
					case 990:
						break;
					default:
						return;
					case 9:
						xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num3 = 4;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 9;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool iov65wZHoC9SlSYXMm94()
	{
		return CH4FUKZHrxCphKp94LMd == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static SMOWgEXrthGGOPQM3UqG TOrw0xZHmfjTrlCYYABF()
	{
		return (SMOWgEXrthGGOPQM3UqG)CH4FUKZHrxCphKp94LMd;
	}
}

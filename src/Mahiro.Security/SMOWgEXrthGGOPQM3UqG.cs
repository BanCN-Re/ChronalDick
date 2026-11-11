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
		message = default(z2ypj2XrgrQmJkmrSi5Q?);
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
								text = LDmKkaXrJsoQ9MJDZJvB.nTbXr4FpagV(((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)packet).Payload), ref offset);
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
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num5 = 5;
							goto IL_020a;
						}
						ex = obj2;
						num6 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
						{
							num6 = 2;
						}
						goto IL_0212;
						IL_020e:
						num6 = num7;
						goto IL_0212;
						IL_0212:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 != 15)
								{
									if (num7 == 995)
									{
										goto IL_020e;
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
									goto end_IL_0212;
								}
								goto case 4;
							case 1:
								break;
							case 6:
								goto IL_02ef;
							case 5:
								result2 = 0;
								goto IL_0328;
							case 2:
							case 3:
								{
									result2 = (flag ? 1 : 0);
									goto IL_0328;
								}
								IL_0328:
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
							goto IL_02ef;
							IL_02ef:
							flag = false;
							num6 = 2;
							continue;
							end_IL_0212:
							break;
						}
						num5 = 15;
						goto IL_020a;
						IL_020a:
						num7 = num5;
						goto IL_020e;
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
								goto end_IL_035c;
							}
							result = false;
							num8 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
							{
								num8 = 0;
							}
							continue;
							end_IL_035c:
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
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

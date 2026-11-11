using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;

namespace rMkIZlXyJT7Lr8FeHxg2;

internal class oov9t2XyW3hlO08SkVYQ
{
	internal static object rr2WCcZlSc8cQJtIAQI0;

	[MethodImpl((MethodImplOptions)8)]
	internal static long LAyXyQWp8QR(object value)
	{
		edqXy7sn8XA(value, 1, 19, "游戏 ID");
		return default(long);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int neMXyCQm7X6(object value)
	{
		edqXy7sn8XA(value, 1, 10, "认证 ID");
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void B08Xy4xROug(object value)
	{
		edqXy7sn8XA(value, 1, 41, "ServerId");
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void zrEXyhtvWL1(global::System.ReadOnlySpan<byte> seed)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static byte[] JFqXyUciw4U(object value)
	{
		edqXy7sn8XA(value, 16, 16, "Token");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void MPoXyrjrOL4(global::System.ReadOnlySpan<byte> hash)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string MANXyoL2BHj(object value)
	{
		//IL_02d8: Expected O, but got Unknown
		//IL_0342: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Invalid comparison between Unknown and I4
		int num = 1;
		int num5 = default(int);
		int num7 = default(int);
		int num9 = default(int);
		int num11 = default(int);
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
						if (num2 != 11)
						{
							if (num2 == 992)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						try
						{
							JsonDocument val = System.Text.Json.JsonDocument.Parse((string)value, default(JsonDocumentOptions));
							int num4 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 != 0)
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
										goto IL_013f;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_0143;
								}
								try
								{
									JsonElement val2 = (val).RootElement;
									int num6 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
									{
										num6 = 1;
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
											goto case 1;
										case 1:
											if ((int)(val2).ValueKind != 1)
											{
												num6 = 0;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b == 0)
												{
													num6 = 7;
												}
												continue;
											}
											break;
										case 0:
											throw new InvalidDataException("Java 认证模组清单格式无效");
										}
										break;
									}
								}
								finally
								{
									int num8;
									if (val == null)
									{
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
										{
											num8 = 0;
										}
										goto IL_0253;
									}
									goto IL_029b;
									IL_0253:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_024f;
											}
											goto end_IL_0253;
										case 0:
											goto end_IL_0253;
										case 1:
											break;
										case 2:
											goto end_IL_0253;
										}
										goto IL_029b;
										IL_024f:
										num8 = num9;
										continue;
										end_IL_0253:
										break;
									}
									goto end_IL_021b;
									IL_029b:
									(val).Dispose();
									num8 = 2;
									goto IL_0253;
									end_IL_021b:;
								}
								break;
								IL_013f:
								num4 = num5;
								continue;
								end_IL_0143:
								break;
							}
						}
						catch (JsonException ex)
						{
							JsonException ex2 = ex;
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 != 0)
							{
								num10 = 3;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										goto IL_0305;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0305:
								num10 = num11;
							}
							throw new InvalidDataException("Java 认证模组清单格式无效", (global::System.Exception)(object)ex2);
						}
						goto case 3;
					case 4:
						throw new InvalidDataException("Java 认证模组清单过长");
					case 1:
						if (!string.IsNullOrWhiteSpace((string)value))
						{
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
							{
								num3 = 0;
							}
							continue;
						}
						goto case 2;
					case 2:
						return string.Empty;
					case 0:
						break;
					case 3:
						return (string)value;
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
			if ((System.Text.Encoding.UTF8).GetByteCount((string)value) <= 65535)
			{
				num = 11;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
				{
					num = 10;
				}
			}
			else
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void C5OXymquDHS(object value, object fieldName)
	{
		System.ArgumentException.ThrowIfNullOrWhiteSpace((string)fieldName, "fieldName");
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void edqXy7sn8XA(object value, int minimumBytes, int maximumBytes, object fieldName)
	{
		int num = (System.Text.Encoding.UTF8).GetByteCount((string)value);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool UJb0vZZlcjJ0M4HQvYpj()
	{
		return rr2WCcZlSc8cQJtIAQI0 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oov9t2XyW3hlO08SkVYQ zVHAp5Zl0AyZcADFJDns()
	{
		return (oov9t2XyW3hlO08SkVYQ)rr2WCcZlSc8cQJtIAQI0;
	}
}

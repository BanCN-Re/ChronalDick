using System;
using System.IO;
using System.Runtime.CompilerServices;
using BCXoLCXUvJyBkqc6IRk2;
using CZUx5njfSrbl1tnMcUCO;
using K48WkOXrQUD3xl2yuwa3;
using fDAldojjppXrctUVYOJn;

namespace Y70vrlXUPYNUIZUKW309;

internal class MVL2KXXUejx66HhAppah
{
	internal static object tb4YBcZHZO5ThSuZoE20;

	[MethodImpl((MethodImplOptions)8)]
	internal static qAftL0XU3M5I1RIneNTc vvrXUxhGtZD(object packet, int protocolVersion, object roleName)
	{
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f9: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int offset = default(int);
		MemoryStream val = default(MemoryStream);
		int num6 = default(int);
		global::System.Span<byte> span = default(global::System.Span<byte>);
		qAftL0XU3M5I1RIneNTc result = default(qAftL0XU3M5I1RIneNTc);
		int num8 = default(int);
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
							goto case 1;
						}
						if (((qAftL0XU3M5I1RIneNTc)packet).Id != 0)
						{
							num3 = 5;
							continue;
						}
						offset = 0;
						num = 6;
						break;
					case 0:
						System.ArgumentException.ThrowIfNullOrWhiteSpace((string)roleName, "roleName");
						num = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
						{
							num = 11;
						}
						break;
					case 6:
						LDmKkaXrJsoQ9MJDZJvB.nTbXr4FpagV(((global::System.ReadOnlySpan<byte>)((qAftL0XU3M5I1RIneNTc)packet).Payload), ref offset);
						num3 = 2;
						continue;
					case 1:
						System.ArgumentNullException.ThrowIfNull(packet, "packet");
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 != 0)
						{
							num3 = 0;
						}
						continue;
					case 4:
						try
						{
							LDmKkaXrJsoQ9MJDZJvB.N60XroTd6fJ(val, ((dynamic)(roleName)).Trim());
							int num4 = 2;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num6 != 20)
									{
										if (num6 == 1000)
										{
											goto IL_013f;
										}
										goto case 4;
									}
									goto case 1;
								case 4:
								{
									(val).WriteByte(0);
									int num5 = 20;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
									{
										num5 = 7;
									}
									num6 = num5;
									goto IL_013f;
								}
								case 11:
									(val).WriteByte(0);
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
									{
										num4 = 10;
									}
									continue;
								case 5:
									(val).WriteByte(0);
									num4 = 11;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
									{
										num4 = 7;
									}
									continue;
								case 6:
									(val).Write(span);
									num4 = 7;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 != 0)
									{
										num4 = 3;
									}
									continue;
								case 0:
									if (protocolVersion >= 761)
									{
										num4 = 7;
										continue;
									}
									goto case 8;
								case 1:
								case 3:
								case 10:
									result = ((qAftL0XU3M5I1RIneNTc)packet).DwUXUEGBPTq((val).ToArray());
									num4 = 12;
									continue;
								case 2:
									if (protocolVersion == 760)
									{
										num4 = 5;
										continue;
									}
									goto case 0;
								case 9:
									span = new byte[16];
									num4 = 6;
									continue;
								case 7:
									if (protocolVersion < 764)
									{
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 == 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto case 8;
								case 8:
									if (protocolVersion < 764)
									{
										num4 = 10;
										continue;
									}
									goto case 9;
								case 12:
									break;
									IL_013f:
									num4 = num6;
									continue;
								}
								break;
							}
						}
						finally
						{
							int num7;
							if (val == null)
							{
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
								{
									num7 = 6;
								}
								goto IL_0386;
							}
							goto IL_03aa;
							IL_0386:
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 990)
									{
										goto IL_0382;
									}
									goto end_IL_0386;
								case 2:
									break;
								case 0:
									goto end_IL_0386;
								case 1:
									goto end_IL_0386;
								}
								goto IL_03aa;
								IL_0382:
								num7 = num8;
								continue;
								end_IL_0386:
								break;
							}
							goto end_IL_034e;
							IL_03aa:
							(val).Dispose();
							num7 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e641198d086c46ee872ff738601e5bf8 == 0)
							{
								num7 = 1;
							}
							goto IL_0386;
							end_IL_034e:;
						}
						goto case 3;
					case 3:
						return result;
					case 2:
						val = new MemoryStream();
						num3 = 4;
						continue;
					case 5:
						throw new InvalidDataException("Minecraft Login Start 数据包编号无效");
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool zb5jADZH9Qds9Cq2gy8d()
	{
		return tb4YBcZHZO5ThSuZoE20 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static MVL2KXXUejx66HhAppah thOvRIZHD6khPwg9OBGh()
	{
		return (MVL2KXXUejx66HhAppah)tb4YBcZHZO5ThSuZoE20;
	}
}

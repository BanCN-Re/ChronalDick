using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using B1sMsHfszr8btKuT8Q1f;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using E8lvgpXkaerTjm5gLXSY;
using GJFHuMfF9Tsu20PjaEve;
using Js9E2uX86QVGkGw8OX9L;
using RkEBBcxE6uQHIJCVGy1;
using fDAldojjppXrctUVYOJn;
using rMkIZlXyJT7Lr8FeHxg2;

namespace XQwLpPX8X2gLJv9RM0na;

internal sealed class Eyhp5FX8b3BcPN3DvvXR
{
	private readonly object RwHX89iM7pd;

	private readonly object cA4X8D4QG78;

	private readonly object u97X8keIXAl;

	private readonly long ryNX8VWXyfx;

	private static object JtGn6sZglqIc3gHOfIj2;

	[MethodImpl((MethodImplOptions)8)]
	internal Eyhp5FX8b3BcPN3DvvXR(bnHA9vxvBiUJqO7FLm4 paths, HDDHYcfFZMJBwyk4WxDY request, string modListJson)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<byte[]> u69X8f9qEM5(byte[] loginSeed, byte[] signedChallenge, GE50SffsnGnn7g3lMZHE session, YCeVntX85joRdPpQTTuN signatureClient, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_CreateInitializeAsync_d__5 createInitializeAsync_d__ = default(_CreateInitializeAsync_d__5);
		createInitializeAsync_d__.__t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static int saeX8L4w2ne(object session)
	{
		System.ArgumentNullException.ThrowIfNull(session, "session");
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal global::System.Threading.Tasks.Task<byte[]> cjlX8js71Bd(string serverId, byte[] loginSeed, GE50SffsnGnn7g3lMZHE session, DateTimeOffset timestamp, YCeVntX85joRdPpQTTuN signatureClient, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_CreateJoinAsync_d__7 createJoinAsync_d__ = default(_CreateJoinAsync_d__7);
		createJoinAsync_d__.__t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] YEZX8Zi53SP(global::System.ReadOnlySpan<byte> token, global::System.ReadOnlySpan<byte> loginSeed)
	{
		int num = 1;
		byte[] array2 = default(byte[]);
		byte[] array = default(byte[]);
		int num4 = default(int);
		int num7 = default(int);
		byte[] result = default(byte[]);
		int num9 = default(int);
		int num11 = default(int);
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
					goto case 1;
				case 0:
					array2 = loginSeed.ToArray();
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					array = token.ToArray();
					num2 = 4;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					try
					{
						Aes val = System.Security.Cryptography.Aes.Create();
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_00c2;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_00c2:
							num3 = num4;
						}
						try
						{
							(val).Key = array;
							int num5 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								int num6;
								switch (num5)
								{
								default:
									if (num7 != 10)
									{
										if (num7 == 990)
										{
											goto IL_011e;
										}
										goto case 0;
									}
									goto end_IL_0122;
								case 2:
									(val).Padding = (PaddingMode)1;
									num5 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_699ea0606d084c998e3be062cf867074 != 0)
									{
										num5 = 8;
									}
									break;
								case 0:
									result = ((val).CreateEncryptor()).TransformFinalBlock(array2, 0, array2.Length);
									num6 = 10;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5a9a88f210c445fda7f0a8a31ff8fd06 == 0)
									{
										num6 = 0;
									}
									goto IL_011a;
								case 1:
									{
										(val).Mode = (CipherMode)2;
										num6 = 2;
										goto IL_011a;
									}
									IL_011e:
									num5 = num7;
									break;
									IL_011a:
									num7 = num6;
									goto IL_011e;
								}
								continue;
								end_IL_0122:
								break;
							}
						}
						finally
						{
							int num8;
							if (val == null)
							{
								num8 = 4;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 == 0)
								{
									num8 = 1;
								}
								goto IL_0212;
							}
							goto IL_025a;
							IL_0212:
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 990)
									{
										goto IL_020e;
									}
									goto end_IL_0212;
								case 1:
									goto end_IL_0212;
								case 0:
									break;
								case 2:
									goto end_IL_0212;
								}
								goto IL_025a;
								IL_020e:
								num8 = num9;
								continue;
								end_IL_0212:
								break;
							}
							goto end_IL_01da;
							IL_025a:
							(val).Dispose();
							num8 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 != 0)
							{
								num8 = 3;
							}
							goto IL_0212;
							end_IL_01da:;
						}
					}
					finally
					{
						System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
						int num10 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a != 0)
						{
							num10 = 7;
						}
						while (true)
						{
							switch (num10)
							{
							default:
								if (num11 == 989)
								{
									num10 = num11;
									continue;
								}
								break;
							case 0:
								break;
							case 1:
								goto end_IL_02c8;
							}
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							num10 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
							{
								num10 = 7;
							}
							continue;
							end_IL_02c8:
							break;
						}
					}
					break;
				case 2:
					break;
				}
				return result;
				continue;
				end_IL_0010:
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
	internal static bool xlMEhlZgdDLgwmCmu0tI()
	{
		return JtGn6sZglqIc3gHOfIj2 == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static Eyhp5FX8b3BcPN3DvvXR BLLEUwZgKsTXhcxmJvDI()
	{
		return (Eyhp5FX8b3BcPN3DvvXR)JtGn6sZglqIc3gHOfIj2;
	}
}

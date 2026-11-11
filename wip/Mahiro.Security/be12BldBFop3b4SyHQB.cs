using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using CqdO33gf8Z9AAC52CV4;
using apX549d5RUYrf4hSQnl;
using b8XQAHXkRaygfYIQvFEC;
using fDAldojjppXrctUVYOJn;
using sIIqaHfsvUMJoArTBa4b;

namespace Fbw9wjdg3U8V9a1IaXt;

public class be12BldBFop3b4SyHQB
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_144
	{
		public static __c_144 __9;

		public static Func<X509ChainStatus, string> __9__2_0;

		internal static __c_144 xtVlhQ9r73ABI4iZHFa2;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
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
							if (num2 != 11)
							{
								if (num2 == 992)
								{
									goto end_IL_0012;
								}
								goto case 0;
							}
							HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
							{
								num3 = 0;
							}
							continue;
						case 2:
							num3 = 1;
							continue;
						case 1:
							break;
						case 0:
							__9 = (__c_144)new __c_144();
							num3 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6fcf26dea68f4c0e85b95c9af2975636 == 0)
							{
								num3 = 4;
							}
							continue;
						case 3:
							num3 = 2;
							continue;
						case 4:
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
				xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
				num = 1;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
				{
					num = 11;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_144()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal unsafe string HcYfqAkaddZ(X509ChainStatus status)
		{
			//IL_0032: Ignored invalid 'constrained' prefix
			//IL_003a: Expected O, but got Ref
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = 1;
			X509ChainStatusFlags val = default(X509ChainStatusFlags);
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
						return (string)(&val);
					case 1:
						break;
					}
					goto IL_003a;
					IL_001d:
					if (num == 989)
					{
						break;
					}
					goto IL_003a;
					IL_003a:
					val = (status).Status;
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
					{
						num2 = 0;
					}
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool LctkRf9rANWiyjwJspuF()
		{
			return xtVlhQ9r73ABI4iZHFa2 == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_144 R1V4YF9rIUI2YlU1ITEf()
		{
			return xtVlhQ9r73ABI4iZHFa2;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass1_0_14
	{
		public TOEJM3dOdJLn5K9AlWe options;

		internal static __c__DisplayClass1_0_14 C9jxly9rBSwFhVe13hmM;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass1_0_14()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool HuvfqIehXr6(object _, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors errors)
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			int num = 2;
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
						return true;
					case 1:
						throw new lL1ac4gXt0kBTX1HOLq("TLS 证书信任或固定值校验失败。");
					case 2:
						if (!tI1dKRJOVV(certificate, chain, errors, options.TlsSpkiSha256Pins))
						{
							num2 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 != 0)
							{
								num2 = 4;
							}
							break;
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
							goto end_IL_000e;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
							{
								num3 = 0;
							}
							continue;
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
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
							{
								num3 = 1;
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
		internal static bool Cr82MB9rg4ArNigG5ijl()
		{
			return C9jxly9rBSwFhVe13hmM == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass1_0_14 zNZiwG9rlQsDQHNlnU6g()
		{
			return C9jxly9rBSwFhVe13hmM;
		}
	}

	[CompilerGenerated]
	private sealed class __c__DisplayClass4_0_14
	{
		public byte[] actualPin;

		internal static __c__DisplayClass4_0_14 rGv2NK9rdRa7li2bebTO;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass4_0_14()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool PAyfqBJl2VK(byte[] expected)
		{
			int num = 1;
			return default(bool);
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
						case 0:
							return;
						case 2:
							goto end_IL_000e;
						case 1:
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						switch (num2)
						{
						case 990:
							break;
						default:
							return;
						case 9:
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
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
		internal static bool vVsFwl9rKVnN7eqsKmdi()
		{
			return rGv2NK9rdRa7li2bebTO == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass4_0_14 buDMaG9rHsEqRZ4d0uXS()
		{
			return rGv2NK9rdRa7li2bebTO;
		}
	}

	private static object evCWG8ZWrZiaKjr1A6JW;

	[MethodImpl((MethodImplOptions)8)]
	public static HttpClient gkOdleq4BC(object options)
	{
		//IL_000c: Expected O, but got I4
		//IL_001d: Expected I4, but got O
		//IL_007d->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					goto IL_001d;
				case 0:
					return aUxddiK3c0(((TOEJM3dOdJLn5K9AlWe)options).ApiBaseUri, options);
				case 1:
					break;
				}
				goto IL_003d;
				IL_001d:
				if ((nint)obj == 989)
				{
					break;
				}
				goto IL_003d;
				IL_003d:
				System.ArgumentNullException.ThrowIfNull(options, "options");
				obj2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
				{
					obj2 = 2;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	public static HttpClient aUxddiK3c0(object apiBaseUri, object options)
	{
		//IL_002b: Expected O, but got I4
		//IL_0037: Expected O, but got I4
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got I4
		//IL_0098: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_00ae: Expected O, but got I4
		//IL_00b0: Expected O, but got I4
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		object obj = (object)new __c__DisplayClass1_0_14();
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962;
		(4).AllowAutoRedirect = false;
		(4).AutomaticDecompression = (DecompressionMethods)0;
		(4).ConnectTimeout = ((__c__DisplayClass1_0_14)obj).options.ConnectTimeout;
		(4).PooledConnectionLifetime = System.TimeSpan.FromMinutes(2.0);
		(4).PooledConnectionIdleTimeout = System.TimeSpan.FromMinutes(1.0);
		(4).CertificateRevocationCheckMode = (X509RevocationMode)0;
		(4).SslOptions = (SslClientAuthenticationOptions)(object)4;
		(1).UseCookies = false;
		object obj2 = 1;
		return default(HttpClient);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool tI1dKRJOVV(object? certificate, object? chain, SslPolicyErrors errors, global::System.Collections.Generic.IReadOnlyList<byte[]> pins)
	{
		return default(bool);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Ba3dHbPeon(object certificate)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static bool VRwdt1VxHE(object certificate, global::System.Collections.Generic.IReadOnlyList<byte[]> pins)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		//IL_000e: Expected O, but got I4
		//IL_0023: Expected I4, but got O
		//IL_00a6->IL0012: Incompatible stack types: I4 vs O
		//IL_005d->IL0012: Incompatible stack types: I4 vs O
		//IL_00b1->IL0012: Incompatible stack types: I4 vs O
		//IL_0068->IL0012: Incompatible stack types: I4 vs O
		int num = 2;
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
						if ((nint)obj != 9)
						{
							if ((nint)obj == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						return;
					case 2:
						obj2 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
						{
							obj2 = 1;
						}
						continue;
					case 0:
						break;
					case 1:
						obj2 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 == 0)
						{
							obj2 = 3;
						}
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
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
			{
				num = 5;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool YlcvodZWo92OmTnyaSoD()
	{
		return evCWG8ZWrZiaKjr1A6JW == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static be12BldBFop3b4SyHQB MoVnetZWmYAmdd2xgZrq()
	{
		return (be12BldBFop3b4SyHQB)evCWG8ZWrZiaKjr1A6JW;
	}
}

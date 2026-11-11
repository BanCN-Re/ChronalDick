using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using HO0SI0Xqz5i4QqnPUjTj;
using QJ21CkfSL8itNSePE2uS;
using R2PdoCXB02FAdCljtHb2;
using ScULqvXq3TjcWivXagrC;
using dDZeghfkcJHyjpQYG0bq;
using fYjvfFf1p8udxK21D6pd;
using jQtc8sXGR31bMSWlwIh3;

namespace WoLkW1XH2k3lmZybHOSy;

sealed class B9ESpHXHE45La6yUlebP : global::System.IDisposable
{
	private static readonly object IbxXtf56C1K;

	private readonly object MFAXtLOf7tu;

	private readonly object qXMXtjBp7Vq;

	private readonly object AN7XtZeNcfU;

	private bool tCfXt9Hsf4H;

	private static object MFio2TZ5BxKk4m0Zl8QI;

	[MethodImpl((MethodImplOptions)8)]
	internal B9ESpHXHE45La6yUlebP(string authorizationServiceCode = "bedrock_launch")
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
		qXMXtjBp7Vq = (object)new u1lLwgXq1FLYtLiTx61U();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal unsafe global::System.Threading.Tasks.Task<c7lEmkf1MoB1jUf1XEF1> AuthenticateAsync(string sauthInput, CancellationToken cancellationToken)
	{
		//IL_0028: Expected O, but got Ref
		_AuthenticateAsync_d__6 authenticateAsync_d__ = default(_AuthenticateAsync_d__6);
		authenticateAsync_d__.__1__state = -1;
		_ = 1;
		_ = _Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b00fe29885d540c8adcde6d3551e8209;
		_ = 0;
		return (global::System.Threading.Tasks.Task<c7lEmkf1MoB1jUf1XEF1>)(&authenticateAsync_d__.__t__builder);
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private global::System.Threading.Tasks.Task<c7lEmkf1MoB1jUf1XEF1> AuthenticateAsync(StDSbnfkSH7fjEfMgMeT credential, dggus7XqnjHG4gsjlEgg profile, CancellationToken cancellationToken)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string FZAXHqFINn2(object credential, object profile)
	{
		vJHp2SXBc1bWEKoxdDKg vJHp2SXBc1bWEKoxdDKg = vJHp2SXBc1bWEKoxdDKg.mcOXB8pit6O(((StDSbnfkSH7fjEfMgMeT)credential).UniqueDeviceId);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string kWTXHGaKLZt(object credential, object profile)
	{
		return FZAXHqFINn2(credential, profile);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonElement CIYXHicAcbF(JsonElement root, object fallback)
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Invalid comparison between Unknown and I4
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		int num4 = default(int);
		JsonElement result = default(JsonElement);
		v8S9tafSfKHe7BkHpBrA challenge = default(v8S9tafSfKHe7BkHpBrA);
		string text = default(string);
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
						if (num2 != 14)
						{
							if (num2 == 995)
							{
								goto end_IL_0010;
							}
							goto case 6;
						}
						if (num4 == 0)
						{
							if (!(root).TryGetProperty("entity", out result))
							{
								num3 = 2;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
						{
							num3 = 6;
						}
						continue;
					case 6:
						throw challenge;
					case 7:
						throw text;
					case 0:
						text = fjoXtXFGVbG(root, "message", fjoXtXFGVbG(root, "msg", fallback));
						num3 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
						{
							num3 = 4;
						}
						continue;
					case 4:
						if (!v8S9tafSfKHe7BkHpBrA.DhCfSjXshTa(num4, text, out challenge))
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 6;
					case 1:
					case 5:
						throw string.Concat((string)fallback, "：服务端未返回实体");
					case 3:
						goto end_IL_000c;
					case 2:
						break;
					}
					if ((int)(result).ValueKind == 1)
					{
						return result;
					}
					num3 = 5;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num4 = dgBXHnnZqF0(root);
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int dgBXHnnZqF0(JsonElement root)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Invalid comparison between Unknown and I4
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Invalid comparison between Unknown and I4
		int num = 9;
		JsonValueKind val = default(JsonValueKind);
		int result = default(int);
		int num5 = default(int);
		JsonElement val2 = default(JsonElement);
		int num4 = default(int);
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
						if (num2 != 19)
						{
							if (num2 == 1000)
							{
								goto end_IL_0010;
							}
							goto case 3;
						}
						if ((int)val == 4)
						{
							num3 = 12;
							continue;
						}
						goto case 7;
					case 4:
						result = num5;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
						{
							num3 = 5;
						}
						continue;
					case 3:
						return -2147483648;
					case 8:
						val = (val2).ValueKind;
						num = 11;
						break;
					case 9:
						if ((root).TryGetProperty("code", out val2))
						{
							num3 = 8;
							continue;
						}
						goto case 3;
					case 12:
						if (!(val2).TryGetInt32(out num5))
						{
							num3 = 7;
							continue;
						}
						goto case 4;
					case 11:
						if ((int)val != 3)
						{
							num = 19;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f == 0)
							{
								num = 12;
							}
							break;
						}
						goto case 5;
					case 0:
					case 1:
					case 6:
						return result;
					case 7:
					case 10:
						result = -2147483648;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 != 0)
						{
							num3 = 10;
						}
						continue;
					case 5:
						if (int.TryParse((val2).GetString(), out num4))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf == 0)
							{
								num3 = 2;
							}
							continue;
						}
						goto case 7;
					case 2:
						result = num4;
						num = 6;
						break;
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
	private static string pv0XHzj2yZV(JsonElement element, object propertyName, object message)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string ObfXtbuHo0M(string? responseAccount, object fallbackAccount)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string fjoXtXFGVbG(JsonElement element, object propertyName, object fallback)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Invalid comparison between Unknown and I4
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_00e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = default(JsonValueKind);
		string result = default(string);
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
						if (num2 != 17 && num2 == 998)
						{
							goto end_IL_0010;
						}
						goto case 3;
					case 1:
						if (!(element).TryGetProperty((string)propertyName, out val2))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						val = (val2).ValueKind;
						num = 5;
						break;
					case 5:
						if ((int)val != 3)
						{
							num3 = 10;
							continue;
						}
						goto case 2;
					case 6:
					case 7:
						result = (string)fallback;
						num3 = 8;
						continue;
					case 4:
						result = (val2).GetRawText();
						num3 = 3;
						continue;
					case 3:
					case 8:
						return result;
					case 0:
						return (string)fallback;
					case 10:
						if ((int)val != 4)
						{
							num3 = 6;
							continue;
						}
						goto case 4;
					case 2:
						obj = (val2).GetString();
						if (obj != null)
						{
							goto IL_0138;
						}
						num3 = 9;
						continue;
					case 9:
						{
							obj = fallback;
							goto IL_0138;
						}
						IL_0138:
						result = (string)obj;
						num = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
						{
							num = 17;
						}
						break;
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
	public void Dispose()
	{
		int num = 4;
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
						if (num2 == 12)
						{
							return;
						}
						goto end_IL_0010;
					case 2:
						((u1lLwgXq1FLYtLiTx61U)qXMXtjBp7Vq).Dispose();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
						{
							num3 = 11;
						}
						continue;
					case 5:
						return;
					case 3:
						tCfXt9Hsf4H = true;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
						{
							num3 = 1;
						}
						continue;
					case 4:
						if (tCfXt9Hsf4H)
						{
							return;
						}
						num3 = 3;
						continue;
					case 1:
						break;
					case 0:
						((Wr7eDkXG68SK2Y4qCpTK)AN7XtZeNcfU).Dispose();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b0bbdd440acc434dbe0e85e6657c3180 == 0)
						{
							num3 = 1;
						}
						continue;
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
			while (num2 == 993);
			(MFAXtLOf7tu).Dispose();
			num = 12;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 == 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 2;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool qunAuRZ5gk4t2BQgkNSp()
	{
		return MFio2TZ5BxKk4m0Zl8QI == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static B9ESpHXHE45La6yUlebP HQT1y6Z5lNtf7jmeFdVA()
	{
		return (B9ESpHXHE45La6yUlebP)MFio2TZ5BxKk4m0Zl8QI;
	}
}

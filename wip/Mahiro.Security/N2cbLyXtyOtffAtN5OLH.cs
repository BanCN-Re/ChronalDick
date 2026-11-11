using System;
using System.Globalization;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using VosCXQXt8PsSy4DNrnHT;
using fDAldojjppXrctUVYOJn;
using q8fJvyXtkQ0c1IAXxKHt;
using w3VOPWXtcAV3rw2ENW0f;

namespace YNmAdkXtWdqCX5luaOfN;

sealed class N2cbLyXtyOtffAtN5OLH : JRZqwpXt0n0uknbAS6P5, global::System.IDisposable
{
	private readonly object MIOXtoccW1a;

	private bool PKbXtmX66OJ;

	private static object es1KavZ5eSiCPsfl6BLn;

	[MethodImpl((MethodImplOptions)8)]
	internal N2cbLyXtyOtffAtN5OLH(HttpMessageHandler? handler = null)
	{
		HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<axd2C7XtDpNVEVQfFqEe> malL4R6cLJD(string userId, string currentToken, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<byte[]> eRNXtJP2KrM(object response, CancellationToken cancellationToken)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static axd2C7XtDpNVEVQfFqEe BxxXtQbnfD2(global::System.ReadOnlySpan<byte> plaintext, string expectedUserId)
	{
		//IL_03df: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Invalid comparison between Unknown and I4
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Utf8JsonReader val = default(Utf8JsonReader);
		int num3 = default(int);
		JsonDocument val3 = default(JsonDocument);
		int num7 = default(int);
		JsonElement element2 = default(JsonElement);
		axd2C7XtDpNVEVQfFqEe result = default(axd2C7XtDpNVEVQfFqEe);
		string message = default(string);
		int num5 = default(int);
		int num9 = default(int);
		int num11 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					_ = val;
					_ = 1;
					JsonReaderState val2 = default(JsonReaderState);
					int num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
					{
						num2 = 3;
					}
					while (true)
					{
						switch (num2)
						{
						default:
							if (num3 == 989)
							{
								num2 = num3;
								continue;
							}
							break;
						case 0:
							val3 = System.Text.Json.JsonDocument.ParseValue(ref val);
							num2 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
							{
								num2 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
					try
					{
						JsonElement element = (val3).RootElement;
						int num4 = 2;
						while (true)
						{
							int num6;
							switch (num4)
							{
							default:
								if (num7 != 14)
								{
									if (num7 == 994)
									{
										goto IL_00e5;
									}
									goto case 4;
								}
								goto IL_0276;
							case 6:
							{
								if ((int)(element2).ValueKind != 1)
								{
									num6 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
									{
										num6 = 12;
									}
									goto IL_00e1;
								}
								string text = TddXtC1wuTA(element2, "entity_id", expectedUserId);
								string text2 = TddXtC1wuTA(element2, "token");
								if (!string.Equals(text, expectedUserId, (StringComparison)4) || string.IsNullOrWhiteSpace(text2))
								{
									throw new global::System.Exception("网易会话续期响应身份无效");
								}
								result = (axd2C7XtDpNVEVQfFqEe)new axd2C7XtDpNVEVQfFqEe(text, text2);
								num4 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 == 0)
								{
									num4 = 1;
								}
								continue;
							}
							case 0:
								message = TddXtC1wuTA(element, "message", "网易会话续期失败");
								num4 = 3;
								continue;
							case 4:
								if (num5 == 0)
								{
									num4 = 5;
									continue;
								}
								goto case 0;
							case 2:
								num5 = yNCXt4JNsPF(element, "code", -2147483648);
								num6 = 4;
								goto IL_00e1;
							case 3:
								throw new MAKjAdXtSNCWSP3DOneV(num5, message);
							case 5:
								if ((element).TryGetProperty("entity", out element2))
								{
									num4 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c77df44372f54cc39796e9a92cb16c12 == 0)
									{
										num4 = 6;
									}
									continue;
								}
								goto IL_0276;
							case 1:
								break;
								IL_0276:
								throw new global::System.Exception("网易会话续期响应缺少 entity");
								IL_00e1:
								num7 = num6;
								goto IL_00e5;
								IL_00e5:
								num4 = num7;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (val3 != null)
						{
							int num8 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
							{
								num8 = 1;
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
								case 1:
									break;
								case 0:
									goto end_IL_0391;
								}
								(val3).Dispose();
								num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
								{
									num8 = 4;
								}
								continue;
								end_IL_0391:
								break;
							}
						}
					}
				}
				catch (JsonException ex)
				{
					JsonException ex2 = ex;
					int num10 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2fcbc5e07b8d44818d88900802598ab1 == 0)
					{
						num10 = 4;
					}
					while (true)
					{
						switch (num10)
						{
						default:
							if (num11 == 988)
							{
								goto IL_040c;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_040c:
						num10 = num11;
					}
					_ = "网易会话续期响应格式无效";
					throw ex2;
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string TddXtC1wuTA(JsonElement element, object name, string fallback = "")
	{
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Invalid comparison between Unknown and I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		string result = default(string);
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = default(JsonValueKind);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3 = num2;
				while (true)
				{
					string text;
					switch (num3)
					{
					default:
						if (num2 != 18)
						{
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 4;
						}
						text = fallback;
						break;
					case 1:
					case 2:
					case 10:
						return result;
					case 4:
					case 11:
						result = fallback;
						num3 = 2;
						continue;
					case 8:
						text = (val2).GetString();
						if (text != null)
						{
							break;
						}
						goto end_IL_000c;
					case 0:
						return fallback;
					case 5:
						val = (val2).ValueKind;
						num3 = 9;
						continue;
					case 9:
						if ((int)val != 3)
						{
							num3 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 8;
					case 6:
						if ((element).TryGetProperty((string)name, out val2))
						{
							num3 = 5;
							continue;
						}
						goto case 0;
					case 7:
						if ((int)val != 4)
						{
							num3 = 4;
							continue;
						}
						goto case 3;
					case 3:
						result = (val2).GetRawText();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 != 0)
						{
							num3 = 1;
						}
						continue;
					}
					result = text;
					num3 = 10;
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 18;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int yNCXt4JNsPF(JsonElement element, object name, int fallback)
	{
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Invalid comparison between Unknown and I4
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		int num = 8;
		JsonValueKind val2 = default(JsonValueKind);
		JsonElement val = default(JsonElement);
		int result = default(int);
		int num5 = default(int);
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
						if (num2 != 18)
						{
							if (num2 == 999)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						if ((int)val2 == 4)
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto case 6;
					case 8:
						if ((element).TryGetProperty((string)name, out val))
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 == 0)
							{
								num3 = 7;
							}
							continue;
						}
						goto case 4;
					case 10:
						result = num5;
						num3 = 5;
						continue;
					case 4:
						return fallback;
					case 7:
						val2 = (val).ValueKind;
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 != 0)
						{
							num3 = 9;
						}
						continue;
					case 0:
						if ((val).TryGetInt32(out num5))
						{
							num3 = 10;
							continue;
						}
						goto case 6;
					case 6:
						result = fallback;
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_197221457fa14214a2061b2843b2ff41 == 0)
						{
							num3 = 2;
						}
						continue;
					case 9:
						if ((int)val2 != 3)
						{
							num = 18;
							break;
						}
						goto case 3;
					case 11:
						result = num4;
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a369f71b5445446991b0734960fce8b9 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
					case 2:
					case 5:
						return result;
					case 3:
						if (int.TryParse((val).GetString(), (NumberStyles)7, (IFormatProvider)(object)System.Globalization.CultureInfo.InvariantCulture, out num4))
						{
							num = 11;
							break;
						}
						goto case 6;
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
								goto end_IL_0010;
							}
							goto case 2;
						}
						return;
					case 0:
						return;
					case 1:
						break;
					case 2:
						(MIOXtoccW1a).Dispose();
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
						{
							num3 = 0;
						}
						continue;
					}
					if (PKbXtmX66OJ)
					{
						goto end_IL_000c;
					}
					PKbXtmX66OJ = true;
					num3 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e == 0)
					{
						num3 = 7;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 6;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		int num = 1;
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
							return;
						}
						goto end_IL_0012;
					case 0:
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 != 0)
						{
							num3 = 2;
						}
						continue;
					case 2:
						break;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
						{
							num3 = 9;
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
			while (num2 == 990);
			xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d8ebed588c3644e9bccc3de84775c962 == 0)
			{
				num = 9;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool gt9rWeZ5PQnClcqBrVZt()
	{
		return es1KavZ5eSiCPsfl6BLn == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static N2cbLyXtyOtffAtN5OLH RLnRT4Z5xOOCaTu9XdQG()
	{
		return (N2cbLyXtyOtffAtN5OLH)es1KavZ5eSiCPsfl6BLn;
	}
}

using System;
using System.IO;
using System.Net;
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
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	public global::System.Threading.Tasks.Task<axd2C7XtDpNVEVQfFqEe> malL4R6cLJD(string userId, string currentToken, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_UpdateAsync_d__6 updateAsync_d__ = default(_UpdateAsync_d__6);
		updateAsync_d__.__t__builder = AsyncTaskMethodBuilder<axd2C7XtDpNVEVQfFqEe>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	private static global::System.Threading.Tasks.Task<byte[]> eRNXtJP2KrM(object response, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ReadResponseAsync_d__7 readResponseAsync_d__ = default(_ReadResponseAsync_d__7);
		readResponseAsync_d__.__t__builder = AsyncTaskMethodBuilder<byte[]>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static axd2C7XtDpNVEVQfFqEe BxxXtQbnfD2(global::System.ReadOnlySpan<byte> plaintext, string expectedUserId)
	{
		//IL_03eb: Expected O, but got Unknown
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Invalid comparison between Unknown and I4
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		Utf8JsonReader val = default(Utf8JsonReader);
		int num3 = default(int);
		JsonDocument val2 = default(JsonDocument);
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
					val = new Utf8JsonReader(plaintext, true, default(JsonReaderState));
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
							val2 = System.Text.Json.JsonDocument.ParseValue(ref val);
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
						JsonElement element = (val2).RootElement;
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
										goto IL_00e9;
									}
									goto case 4;
								}
								goto IL_027a;
							case 6:
							{
								if ((int)(element2).ValueKind != 1)
								{
									num6 = 14;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
									{
										num6 = 12;
									}
									goto IL_00e5;
								}
								string text = TddXtC1wuTA(element2, "entity_id", expectedUserId);
								string text2 = TddXtC1wuTA(element2, "token");
								if (!string.Equals(text, expectedUserId, (StringComparison)4) || string.IsNullOrWhiteSpace(text2))
								{
									throw new InvalidDataException("网易会话续期响应身份无效");
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
								goto IL_00e5;
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
								goto IL_027a;
							case 1:
								break;
								IL_027a:
								throw new InvalidDataException("网易会话续期响应缺少 entity");
								IL_00e5:
								num7 = num6;
								goto IL_00e9;
								IL_00e9:
								num4 = num7;
								continue;
							}
							break;
						}
					}
					finally
					{
						if (val2 != null)
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
									goto end_IL_039d;
								}
								(val2).Dispose();
								num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bc497a43465d42dc8e19c4557008f465 == 0)
								{
									num8 = 4;
								}
								continue;
								end_IL_039d:
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
								goto IL_0418;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_0418:
						num10 = num11;
					}
					throw new InvalidDataException("网易会话续期响应格式无效", (global::System.Exception)(object)ex2);
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
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = (val2).ValueKind;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int yNCXt4JNsPF(JsonElement element, object name, int fallback)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		JsonElement val2 = default(JsonElement);
		JsonValueKind val = (val2).ValueKind;
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	public void Dispose()
	{
		PKbXtmX66OJ = true;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
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

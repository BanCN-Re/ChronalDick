using System;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace WREoxkfy2BpdTWOuUftE;

internal class yatvTGfyE6WkjVXwPep9
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_94
	{
		public static readonly __c_94 __9;

		public static Func<ValueTuple<string, string>, bool> __9__12_0;

		private static __c_94 wfHclqDQShYuhrkW46IH;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_94()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
			{
				num = 0;
			}
			int num2 = default(int);
			while (true)
			{
				switch (num)
				{
				case 0:
					return;
				}
				if (num2 == 988)
				{
					num = num2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool h4yLclMbYW9(ValueTuple<string, string> candidate)
		{
			int num = 1;
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool nbTdE0DQcIcrsBinxs3Q()
		{
			return wfHclqDQShYuhrkW46IH == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_94 Edh8A7DQ0NLtwtuve202()
		{
			return wfHclqDQShYuhrkW46IH;
		}
	}

	private static readonly object iskfWy5fuVP;

	private static readonly object j75fWW6X5oW;

	private static readonly object L4LfWJg0Pgt;

	internal static object ppocFpZubrJ3vwaLc3hg;

	[MethodImpl((MethodImplOptions)8)]
	internal static global::System.Threading.Tasks.Task<string> TjyfyqONql4(object accountId, object serverItemId, bool isRental, long uid, object displayName, object proxyPublicKeyB64, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	[AsyncStateMachine(typeof(object))]
	internal static global::System.Threading.Tasks.Task<string> By8fyGn0Ihn(object session, object accountId, object serverItemId, bool isRental, long uid, object displayName, object proxyPublicKeyB64, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_CreateEnvelopeAsync_d__12 createEnvelopeAsync_d__ = default(_CreateEnvelopeAsync_d__12);
		createEnvelopeAsync_d__.__t__builder = AsyncTaskMethodBuilder<string>.Create();
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static HttpClient FQJfyibJ3i8()
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0019: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_008a: Expected O, but got Unknown
		HttpClientHandler val = new HttpClientHandler();
		((dynamic)((object)val)).AutomaticDecompression = (DecompressionMethods)3;
		HttpClient val2 = new HttpClient((HttpMessageHandler)val);
		((dynamic)((object)val2)).Timeout = System.TimeSpan.FromSeconds(30.0);
		(((dynamic)((object)val2)).DefaultRequestHeaders).TryAddWithoutValidation("Accept", "application/json");
		return val2;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string iu4fynsYORI(object responseText)
	{
		//IL_0127: Expected O, but got Unknown
		//IL_0191: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		string text = default(string);
		byte[] array = default(byte[]);
		int num9 = default(int);
		int num11 = default(int);
		string result = default(string);
		int num5 = default(int);
		int num7 = default(int);
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
							goto case 1;
						}
						return text;
					case 4:
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b == 0)
						{
							num3 = 0;
						}
						break;
					case 7:
						throw new InvalidOperationException("网易 AuthV2 返回为空");
					case 2:
						if (((dynamic)(text)).Chars != '{')
						{
							num3 = 3;
							break;
						}
						goto end_IL_000c;
					case 3:
						try
						{
							array = System.Convert.FromHexString(text);
							int num8 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3db824b4e8954f92b2f0e9dde1b89310 == 0)
							{
								num8 = 0;
							}
							while (true)
							{
								switch (num8)
								{
								default:
									if (num9 == 988)
									{
										num8 = num9;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						catch (FormatException ex)
						{
							FormatException ex2 = ex;
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 != 0)
							{
								num10 = 6;
							}
							while (true)
							{
								switch (num10)
								{
								default:
									if (num11 == 988)
									{
										goto IL_0154;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0154:
								num10 = num11;
							}
							throw new InvalidOperationException("网易 AuthV2 返回不是有效密文", (global::System.Exception)(object)ex2);
						}
						goto case 4;
					case 6:
						text = ((dynamic)(responseText)).Trim();
						num3 = 5;
						break;
					case 0:
						try
						{
							result = lB9fWLhVu5j(default(global::System.ReadOnlySpan<byte>));
							int num4 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 988)
									{
										num4 = num5;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num6 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_7a3c857d491d4aed96ed0b003a4ea42f != 0)
							{
								num6 = 0;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										num6 = num7;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 1;
					case 1:
						return result;
					case 5:
						if ((text).Length != 0)
						{
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fb8e5582a1a348129bd2310554756df3 == 0)
							{
								num3 = 2;
							}
							break;
						}
						goto case 7;
					}
					continue;
					end_IL_0010:
					break;
				}
				continue;
				end_IL_000c:
				break;
			}
			num = 14;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void secfyz2YHqg(object envelope)
	{
		//IL_03b5: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Invalid comparison between Unknown and I4
		//IL_0300: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Invalid comparison between Unknown and I4
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Invalid comparison between Unknown and I4
		int num = 1;
		int num3 = default(int);
		int num5 = default(int);
		JsonElement val3 = default(JsonElement);
		bool flag = default(bool);
		JsonElement val4 = default(JsonElement);
		int num8 = default(int);
		int num10 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				break;
			default:
				return;
			case 1:
				try
				{
					JsonDocument val = System.Text.Json.JsonDocument.Parse((string)envelope, default(JsonDocumentOptions));
					int num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
					{
						num2 = 1;
					}
					while (true)
					{
						switch (num2)
						{
						case 0:
							return;
						default:
							if (num3 == 989)
							{
								goto IL_0076;
							}
							break;
						case 1:
							break;
						}
						break;
						IL_0076:
						num2 = num3;
					}
					try
					{
						JsonElement val2 = (val).RootElement;
						int num4 = 8;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							int num6;
							switch (num4)
							{
							case 0:
								return;
							case 6:
								return;
							default:
								if (num5 != 15)
								{
									if (num5 == 995)
									{
										goto IL_00d6;
									}
									goto case 4;
								}
								num6 = ((!string.IsNullOrWhiteSpace((val3).GetString())) ? 1 : 0);
								goto IL_025e;
							case 7:
								throw new InvalidOperationException("网易 AuthV2 返回不是 JSON 对象");
							case 4:
								if ((int)(val3).ValueKind == 3)
								{
									num5 = 15;
									goto IL_00d6;
								}
								goto case 5;
							case 1:
								if ((int)(val2).ValueKind == 1)
								{
									if (!(val2).TryGetProperty("Certificate", out val3))
									{
										num4 = 5;
										continue;
									}
									goto case 4;
								}
								num4 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
								{
									num4 = 7;
								}
								continue;
							case 3:
								if (flag)
								{
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 == 0)
									{
										num4 = 6;
									}
									continue;
								}
								break;
							case 5:
								num6 = 0;
								goto IL_025e;
							case 2:
								break;
								IL_00d6:
								num4 = num5;
								continue;
								IL_025e:
								flag = (val2).TryGetProperty("chain", out val4) && (int)(val4).ValueKind == 2 && (val4).GetArrayLength() > 0;
								if (num6 != 0)
								{
									num4 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e18cbe403dff46caa4f364fa1a45cf32 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								goto case 3;
							}
							break;
						}
						throw new InvalidOperationException("网易 AuthV2 返回缺少证书链");
					}
					finally
					{
						if (val != null)
						{
							int num7 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
							{
								num7 = 0;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 989)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								case 1:
									goto end_IL_0343;
								}
								(val).Dispose();
								num7 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
								{
									num7 = 1;
								}
								continue;
								end_IL_0343:
								break;
							}
						}
					}
				}
				catch (JsonException ex)
				{
					JsonException ex2 = ex;
					int num9 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num9 = 0;
					}
					while (true)
					{
						switch (num9)
						{
						default:
							if (num10 == 988)
							{
								goto IL_03e2;
							}
							break;
						case 0:
							break;
						}
						break;
						IL_03e2:
						num9 = num10;
					}
					throw new InvalidOperationException("网易 AuthV2 返回 JSON 无效", (global::System.Exception)(object)ex2);
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] QTafWbmi3EL(global::System.ReadOnlySpan<byte> plaintext, int tailLength = 16)
	{
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		byte b = default(byte);
		int num4 = default(int);
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		byte[] array2 = default(byte[]);
		int num6 = default(int);
		byte[] array4 = default(byte[]);
		int num9 = default(int);
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
						if (num2 != 17)
						{
							if (num2 == 998)
							{
								goto end_IL_0010;
							}
							goto case 5;
						}
						b = (byte)((num4 << 4) | 0xC);
						num = 4;
						break;
					case 6:
						return result;
					case 4:
						array = new byte[16];
						num3 = 10;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
						{
							num3 = 10;
						}
						continue;
					case 10:
						F1WfWZwygP9(default(global::System.Span<byte>));
						num3 = 5;
						continue;
					case 7:
						F1WfWZwygP9(MemoryExtensions.AsSpan<byte>(array2, plaintext.Length, System.Math.Min(tailLength, array2.Length - plaintext.Length)));
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num3 = 12;
						}
						continue;
					case 5:
						try
						{
							byte[] array3 = iYKfWjyd5AG(((object[])j75fWW6X5oW)[num4], array, array2, encrypt: true);
							int num5 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
							{
								num5 = 1;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									if (num6 != 13)
									{
										if (num6 == 993)
										{
											goto IL_012e;
										}
										goto case 5;
									}
									goto end_IL_0132;
								case 5:
									System.Buffer.BlockCopy(array, 0, array4, 0, array.Length);
									num5 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
									{
										num5 = 2;
									}
									break;
								case 0:
								{
									byte[] array5 = array4;
									array5[array5.Length - 1] = b;
									num5 = 4;
									break;
								}
								case 3:
									array4 = new byte[16 + array3.Length + 1];
									num5 = 5;
									break;
								case 1:
								{
									result = array4;
									int num7 = 13;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 == 0)
									{
										num7 = 1;
									}
									num6 = num7;
									goto IL_012e;
								}
								case 4:
									System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
									num5 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 == 0)
									{
										num5 = 1;
									}
									break;
								case 2:
									{
										System.Buffer.BlockCopy(array3, 0, array4, array.Length, array3.Length);
										num5 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 != 0)
										{
											num5 = 0;
										}
										break;
									}
									IL_012e:
									num5 = num6;
									break;
								}
								continue;
								end_IL_0132:
								break;
							}
						}
						finally
						{
							System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
							int num8 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
							{
								num8 = 0;
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
									goto end_IL_02a1;
								}
								System.Security.Cryptography.CryptographicOperations.ZeroMemory(default(global::System.Span<byte>));
								num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
								{
									num8 = 1;
								}
								continue;
								end_IL_02a1:
								break;
							}
						}
						goto case 6;
					case 1:
					case 9:
						num4 = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, 15);
						num = 17;
						break;
					case 8:
						plaintext.CopyTo(default(global::System.Span<byte>));
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
						{
							num3 = 10;
						}
						continue;
					case 3:
						if (tailLength < 0)
						{
							num3 = 2;
							continue;
						}
						checked
						{
							array2 = new byte[unchecked(checked(plaintext.Length + tailLength + 15) / 16) * 16];
							num3 = 8;
							continue;
						}
					case 2:
						throw new ArgumentOutOfRangeException("tailLength");
					case 0:
						if (tailLength <= 0)
						{
							num3 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
							{
								num3 = 9;
							}
							continue;
						}
						goto case 7;
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
	internal static byte[] yQLfWXlg6Co(global::System.ReadOnlySpan<byte> plaintext, int tailLength = 16)
	{
		return QTafWbmi3EL(plaintext, tailLength);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string CTYfWfBYchB(global::System.ReadOnlySpan<byte> ciphertext)
	{
		return lB9fWLhVu5j(ciphertext);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string lB9fWLhVu5j(global::System.ReadOnlySpan<byte> body)
	{
	// body stubbed by _fix/fix_e2_restub_members.py: the export lost the
	// semantics of this body (see MAHIRO-V2-BUILD.md).
	throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static byte[] iYKfWjyd5AG(object key, object iv, object input, bool encrypt)
	{
		int num = 1;
		byte[] result = default(byte[]);
		Aes val = default(Aes);
		int num5 = default(int);
		ICryptoTransform val2 = default(ICryptoTransform);
		int num7 = default(int);
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
					goto IL_0021;
				case 2:
					return result;
				case 0:
					try
					{
						(val).Key = (byte[])key;
						int num3 = 2;
						while (true)
						{
							ICryptoTransform obj;
							int num4;
							switch (num3)
							{
							default:
								if (num5 != 12)
								{
									if (num5 == 992)
									{
										goto IL_005d;
									}
									goto case 4;
								}
								try
								{
									result = (val2).TransformFinalBlock((byte[])input, 0, ((global::System.Array)input).Length);
									int num6 = 0;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af27c3ff348c40e0aa017ed75e0fb093 != 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										default:
											if (num7 == 988)
											{
												num6 = num7;
												continue;
											}
											break;
										case 0:
											break;
										}
										break;
									}
								}
								finally
								{
									int num8;
									if (val2 == null)
									{
										num8 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 != 0)
										{
											num8 = 6;
										}
										goto IL_01fb;
									}
									goto IL_021f;
									IL_01fb:
									while (true)
									{
										switch (num8)
										{
										default:
											if (num9 == 990)
											{
												goto IL_01f7;
											}
											goto end_IL_01fb;
										case 2:
											break;
										case 1:
											goto end_IL_01fb;
										case 0:
											goto end_IL_01fb;
										}
										goto IL_021f;
										IL_01f7:
										num8 = num9;
										continue;
										end_IL_01fb:
										break;
									}
									goto end_IL_01c3;
									IL_021f:
									(val2).Dispose();
									num8 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_14d00401161e4925b9d0d24c8d4afc10 == 0)
									{
										num8 = 0;
									}
									goto IL_01fb;
									end_IL_01c3:;
								}
								goto end_IL_0061;
							case 2:
								(val).IV = (byte[])iv;
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
								{
									num3 = 10;
								}
								break;
							case 0:
								if (!encrypt)
								{
									num3 = 3;
									break;
								}
								obj = (val).CreateEncryptor();
								goto IL_013c;
							case 4:
								(val).Padding = (PaddingMode)1;
								num3 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
								{
									num3 = 0;
								}
								break;
							case 3:
								obj = (val).CreateDecryptor();
								goto IL_013c;
							case 1:
								{
									(val).Mode = (CipherMode)1;
									num4 = 4;
									goto IL_0059;
								}
								IL_013c:
								val2 = obj;
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_92b2bbadd29d474e8956912c16dfac55 == 0)
								{
									num4 = 12;
								}
								goto IL_0059;
								IL_005d:
								num3 = num5;
								break;
								IL_0059:
								num5 = num4;
								goto IL_005d;
							}
							continue;
							end_IL_0061:
							break;
						}
					}
					finally
					{
						if (val != null)
						{
							int num10 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 == 0)
							{
								num10 = 0;
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
									(val).Dispose();
									num10 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
									{
										num10 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 1:
					break;
				}
				goto IL_02fd;
				IL_0021:
				if (num == 990)
				{
					break;
				}
				goto IL_02fd;
				IL_02fd:
				val = System.Security.Cryptography.Aes.Create();
				num2 = 0;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9d37a8a985534ccfa8deee32973e9b3b != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void F1WfWZwygP9(global::System.Span<byte> destination)
	{
		//IL_006b: Expected F4, but got I4
		int num = default(int);
		global::System.Runtime.CompilerServices.Unsafe.As<byte, float>(ref destination[num]) = (int)(byte)((dynamic)("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789")).Chars;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string EgyfW9vS7rA(string? value, object parameterName)
	{
		int num = 1;
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Ghr7Z1ZuX9sMAADTFvhd()
	{
		return ppocFpZubrJ3vwaLc3hg == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static yatvTGfyE6WkjVXwPep9 SRiuIDZufhj3CrJAi98r()
	{
		return (yatvTGfyE6WkjVXwPep9)ppocFpZubrJ3vwaLc3hg;
	}
}

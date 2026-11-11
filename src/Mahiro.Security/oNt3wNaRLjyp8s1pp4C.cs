using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using RkEBBcxE6uQHIJCVGy1;
using XqoLwmfxKZ22pXoXD9rh;
using bm713PXSW9wl0Pu4IkPO;
using fDAldojjppXrctUVYOJn;

namespace kmByBaawZTGRvvsN6B1;

internal sealed class oNt3wNaRLjyp8s1pp4C
{
	private static readonly object A49aed2esY;

	private static readonly object I8OaPK2n4n;

	private readonly object UH7axtfWBe;

	internal static object hQ1haXZU7AjtZWAB4S5i;

	[MethodImpl((MethodImplOptions)8)]
	internal oNt3wNaRLjyp8s1pp4C(bnHA9vxvBiUJqO7FLm4 paths)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal tkF3LRfxdkiPD0dqhesT Load()
	{
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		int num = 3;
		byte[] array = default(byte[]);
		tkF3LRfxdkiPD0dqhesT result = default(tkF3LRfxdkiPD0dqhesT);
		int num4 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num7 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num6);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num9 = default(int);
		tkF3LRfxdkiPD0dqhesT tkF3LRfxdkiPD0dqhesT2 = default(tkF3LRfxdkiPD0dqhesT);
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
				case 3:
					if (!System.IO.File.Exists((string)UH7axtfWBe))
					{
						num2 = 2;
						continue;
					}
					array = System.IO.File.ReadAllBytes((string)UH7axtfWBe);
					num2 = 0;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return (tkF3LRfxdkiPD0dqhesT)new tkF3LRfxdkiPD0dqhesT();
				case 1:
					try
					{
						tkF3LRfxdkiPD0dqhesT tkF3LRfxdkiPD0dqhesT = JsonSerializer.Deserialize<tkF3LRfxdkiPD0dqhesT>(((dynamic)(A49aed2esY)).GetString(array), (JsonSerializerOptions)I8OaPK2n4n);
						int num3;
						if ((object)tkF3LRfxdkiPD0dqhesT == null)
						{
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
							{
								num3 = 1;
							}
						}
						else
						{
							result = tkF3LRfxdkiPD0dqhesT.EoMfxHxm9I9();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
							{
								num3 = 4;
							}
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 989)
								{
									goto IL_00e3;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_00e7;
							}
							throw new InvalidDataException("Java 游戏设置为空");
							IL_00e3:
							num3 = num4;
							continue;
							end_IL_00e7:
							break;
						}
					}
					catch (global::System.Exception obj) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						obj2 = obj as global::System.Exception;
						if (obj2 == null)
						{
							num5 = 2;
						}
						else
						{
							ex = obj2;
							num5 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_69a66568c7f244168e068b7dbb47c853 != 0)
							{
								num5 = 7;
							}
						}
						while (true)
						{
							switch (num5)
							{
							default:
								if (num7 != 17)
								{
									if (num7 == 997)
									{
										goto IL_017c;
									}
									goto case 2;
								}
								goto case 8;
							case 1:
							case 3:
							case 9:
								flag = true;
								num6 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 != 0)
								{
									num6 = 17;
								}
								goto IL_0178;
							case 0:
								if (!(ex is InvalidDataException))
								{
									num5 = 4;
									continue;
								}
								goto case 1;
							case 6:
								if (ex is DecoderFallbackException)
								{
									num5 = 3;
									continue;
								}
								goto case 0;
							case 7:
								if (ex is JsonException)
								{
									num5 = 15;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
									{
										num5 = 1;
									}
									continue;
								}
								goto case 6;
							case 4:
							case 5:
								flag = false;
								num6 = 8;
								goto IL_0178;
							case 2:
								result2 = 0;
								break;
							case 8:
								{
									result2 = (flag ? 1 : 0);
									break;
								}
								IL_0178:
								num7 = num6;
								goto IL_017c;
								IL_017c:
								num5 = num7;
								continue;
							}
							break;
						}
						return (byte)result2 != 0;
					}).Invoke())
					{
						int num8 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea == 0)
						{
							num8 = 7;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								if (num9 != 11)
								{
									if (num9 == 991)
									{
										goto IL_032b;
									}
									goto case 2;
								}
								goto end_IL_032f;
							case 0:
							{
								result = tkF3LRfxdkiPD0dqhesT2;
								int num10 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
								{
									num10 = 11;
								}
								num9 = num10;
								goto IL_032b;
							}
							case 2:
								tkF3LRfxdkiPD0dqhesT2 = (tkF3LRfxdkiPD0dqhesT)new tkF3LRfxdkiPD0dqhesT();
								num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be != 0)
								{
									num8 = 3;
								}
								break;
							case 3:
								Save(tkF3LRfxdkiPD0dqhesT2);
								num8 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
								{
									num8 = 0;
								}
								break;
							case 1:
								{
									JYAXK1XSywgmWQ5Pnpka.VyNXSJ0tSil(UH7axtfWBe, default(global::System.ReadOnlySpan<byte>));
									num8 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
									{
										num8 = 2;
									}
									break;
								}
								IL_032b:
								num8 = num9;
								break;
							}
							continue;
							end_IL_032f:
							break;
						}
					}
					break;
				case 0:
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
	internal void Save(tkF3LRfxdkiPD0dqhesT settings)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016f: Expected O, but got Unknown
		int num = 4;
		tkF3LRfxdkiPD0dqhesT tkF3LRfxdkiPD0dqhesT = default(tkF3LRfxdkiPD0dqhesT);
		string text = default(string);
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
					case 2:
						return;
					case 0:
						goto end_IL_000c;
					case 4:
						System.ArgumentNullException.ThrowIfNull(settings, "settings");
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
						{
							num3 = 3;
						}
						continue;
					case 1:
						System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName((string)UH7axtfWBe));
						num3 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 != 0)
						{
							num3 = 0;
						}
						continue;
					case 3:
						tkF3LRfxdkiPD0dqhesT = settings.EoMfxHxm9I9();
						num3 = 9;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 == 0)
						{
							num3 = 1;
						}
						continue;
					}
					break;
				}
				switch (num2)
				{
				case 992:
					break;
				default:
					return;
				case 11:
					try
					{
						System.IO.File.WriteAllText(text, JsonSerializer.Serialize<tkF3LRfxdkiPD0dqhesT>(tkF3LRfxdkiPD0dqhesT, (JsonSerializerOptions)I8OaPK2n4n), (Encoding)new UTF8Encoding(false));
						int num4 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8d0068b615184ecaa3626f08b2be49d6 != 0)
						{
							num4 = 3;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							default:
								if (num5 != 989)
								{
									return;
								}
								num4 = num5;
								break;
							case 0:
								System.IO.File.Move(text, (string)UH7axtfWBe, true);
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6c0aab0749d4fe6ad43888318e42d91 != 0)
								{
									num4 = 1;
								}
								break;
							}
						}
					}
					finally
					{
						int num6 = 4;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 != 0)
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
									goto IL_0225;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_0229;
							}
							try
							{
								int num8;
								if (!System.IO.File.Exists(text))
								{
									num8 = 2;
									goto IL_0277;
								}
								goto IL_02bf;
								IL_02bf:
								System.IO.File.Delete(text);
								num8 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4537f25ff4f644a4a6c4706fe70c9ddf != 0)
								{
									num8 = 4;
								}
								goto IL_0277;
								IL_0277:
								while (true)
								{
									switch (num8)
									{
									default:
										if (num9 == 990)
										{
											goto IL_0273;
										}
										goto end_IL_0277;
									case 2:
										goto end_IL_0277;
									case 1:
										break;
									case 0:
										goto end_IL_0277;
									}
									goto IL_02bf;
									IL_0273:
									num8 = num9;
									continue;
									end_IL_0277:
									break;
								}
							}
							catch (global::System.Exception)
							{
								int num10 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
								{
									num10 = 0;
								}
								while (true)
								{
									switch (num10)
									{
									default:
										if (num11 == 988)
										{
											num10 = num11;
											continue;
										}
										break;
									case 0:
										break;
									}
									break;
								}
							}
							break;
							IL_0225:
							num6 = num7;
							continue;
							end_IL_0229:
							break;
						}
					}
				}
				continue;
				end_IL_000c:
				break;
			}
			object uH7axtfWBe = UH7axtfWBe;
			string text2 = ".";
			Guid val = System.Guid.NewGuid();
			text = string.Concat((string)uH7axtfWBe, text2, (val).ToString("N"), ".tmp");
			num = 11;
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
	internal static bool LXQbUdZUAZVmMm35tG3Q()
	{
		return hQ1haXZU7AjtZWAB4S5i == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static oNt3wNaRLjyp8s1pp4C HkpUIKZUIFe2JGRfOTDI()
	{
		return (oNt3wNaRLjyp8s1pp4C)hQ1haXZU7AjtZWAB4S5i;
	}
}

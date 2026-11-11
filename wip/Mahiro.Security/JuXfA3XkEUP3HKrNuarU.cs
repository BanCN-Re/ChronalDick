using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using TJOmfWXkniYvllFT6k4N;
using fDAldojjppXrctUVYOJn;

namespace eK4TKHXk21B46lcybabn;

internal class JuXfA3XkEUP3HKrNuarU
{
	internal static object ub9FRyZIdjoBchttUDFX;

	[MethodImpl((MethodImplOptions)8)]
	internal static string KZkXkqmidDH(JsonElement item, object fallback)
	{
		//IL_02ea: Ignored invalid 'constrained' prefix
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Invalid comparison between Unknown and I4
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Invalid comparison between Unknown and I4
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		int num = 8;
		string text3 = default(string);
		string[] array = default(string[]);
		int num8 = default(int);
		JsonElement value = default(JsonElement);
		ArrayEnumerator val = default(ArrayEnumerator);
		string text = default(string);
		string result = default(string);
		int num5 = default(int);
		JsonElement item2 = default(JsonElement);
		int num7 = default(int);
		ArrayEnumerator val2 = default(ArrayEnumerator);
		string propertyName = default(string);
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
						if (num2 != 20)
						{
							if (num2 == 1001)
							{
								goto end_IL_0010;
							}
							goto case 8;
						}
						if ((text3).Length <= 0)
						{
							array = new string[3]
							{
								"pic_url_list",
								"image_list",
								"pictures"
							};
							num = 6;
							break;
						}
						num3 = 7;
						continue;
					case 0:
					case 2:
						num8++;
						num3 = 10;
						continue;
					case 9:
						if ((int)(value).ValueKind == 2)
						{
							num3 = 4;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 != 0)
							{
								num3 = 8;
							}
							continue;
						}
						goto case 0;
					case 6:
						num8 = 0;
						num3 = 20;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_314b5d375de147f5b07aba2867d610a9 == 0)
						{
							num3 = 1;
						}
						continue;
					case 12:
						try
						{
							while (true)
							{
								IL_0220:
								int num4;
								if (!(val).MoveNext())
								{
									num4 = 3;
									goto IL_00f3;
								}
								goto IL_01b3;
								IL_00f3:
								while (true)
								{
									switch (num4)
									{
									case 4:
										goto end_IL_00f3;
									case 6:
										if ((text).Length > 0)
										{
											num4 = 5;
											continue;
										}
										goto IL_0220;
									case 7:
										goto IL_0220;
									case 1:
										goto IL_023b;
									case 5:
										result = text;
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f22e3d87017e434aaed1ac17a192eb77 != 0)
										{
											num4 = 0;
										}
										continue;
									case 8:
										goto IL_029c;
									case 2:
										goto IL_02bd;
									case 3:
										goto end_IL_0220;
									case 0:
										return result;
									}
									if (num5 != 16)
									{
										if (num5 == 996)
										{
											goto IL_00ef;
										}
										goto IL_029c;
									}
									object obj = s04VLvXkiAKsAsa1LtpS.PY0XVfGZk9p(item2, string.Empty, "url", "image_url", "pic_url");
									goto IL_02c2;
									IL_02bd:
									obj = string.Empty;
									goto IL_02c2;
									IL_023b:
									if ((int)(item2).ValueKind != 3)
									{
										num5 = 16;
										goto IL_00ef;
									}
									string text2 = (item2).GetString();
									if (text2 == null)
									{
										num4 = 8;
										continue;
									}
									obj = (text2).Trim();
									goto IL_02ac;
									IL_02ac:
									if (obj == null)
									{
										num4 = 2;
										continue;
									}
									goto IL_02c2;
									IL_02c2:
									text = (string)obj;
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
									{
										num4 = 4;
									}
									continue;
									IL_00ef:
									num4 = num5;
									continue;
									IL_029c:
									obj = null;
									goto IL_02ac;
									continue;
									end_IL_00f3:
									break;
								}
								goto IL_01b3;
								IL_01b3:
								item2 = (val).Current;
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6caa84935b0c4056bb9fc514ef088076 == 0)
								{
									num4 = 9;
								}
								goto IL_00f3;
								continue;
								end_IL_0220:
								break;
							}
						}
						finally
						{
							_ = val;
							int num6 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_892fa08b94d44a18ba22d395219656a3 != 0)
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
						goto case 0;
					case 13:
						return (string)fallback;
					case 1:
					case 10:
						if (num8 >= array.Length)
						{
							num3 = 13;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e == 0)
							{
								num3 = 20;
							}
							continue;
						}
						goto case 5;
					case 4:
						val2 = value;
						num3 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
						{
							num3 = 3;
						}
						continue;
					case 7:
						return text3;
					case 11:
						if (!s04VLvXkiAKsAsa1LtpS.VDJXVLv9apm(item, propertyName, out value))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
							{
								num3 = 16;
							}
							continue;
						}
						goto case 9;
					case 8:
						text3 = s04VLvXkiAKsAsa1LtpS.PY0XVfGZk9p(item, string.Empty, "title_image_url", "cover_url", "image_url", "icon_url");
						num = 20;
						break;
					case 3:
						val = val2;
						num3 = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9a057186b9a54e66a5015a96229657cb != 0)
						{
							num3 = 7;
						}
						continue;
					case 5:
						propertyName = array[num8];
						num3 = 11;
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
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string J9oXkGRePxD(JsonElement item, object fallback)
{
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
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
					default:
						if (num2 != 9)
						{
							if (num2 == 990)
							{
								goto end_IL_0012;
							}
							goto case 2;
						}
						return;
					case 2:
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 == 0)
						{
							num3 = 4;
						}
						continue;
					case 0:
						break;
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
				num = 7;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool FVybZEZIKKhajUvpSeT9()
	{
		return ub9FRyZIdjoBchttUDFX == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static JuXfA3XkEUP3HKrNuarU OBGwZ6ZIHYsjPTtugeG7()
	{
		return (JuXfA3XkEUP3HKrNuarU)ub9FRyZIdjoBchttUDFX;
	}
}

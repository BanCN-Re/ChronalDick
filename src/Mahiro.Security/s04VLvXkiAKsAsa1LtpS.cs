using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using fDAldojjppXrctUVYOJn;
using m51cv9XLIUYEihAmJGyd;
using sIIqaHfsvUMJoArTBa4b;

namespace TJOmfWXkniYvllFT6k4N;

internal class s04VLvXkiAKsAsa1LtpS
{
	private static object LtgKkdZIt2OrSxDSmgWe;

	[MethodImpl((MethodImplOptions)8)]
	internal static YlErsbfs35V4xTUvrlXK PABXkzTqcKc(JsonElement item, YlErsbfs35V4xTUvrlXK? fallback = null)
	{
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string jwFXVb3Gy9k(JsonElement item, YlErsbfs35V4xTUvrlXK? fallback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string text = PY0XVfGZk9p(item, string.Empty, "entity_id");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static int B3kXVXlBMVq(JsonElement item, int fallback)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		int num = mI9Xo5XLAV8Bv6eR7ZG2.CklXLKIVygJ(item, "port");
		return default(int);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string PY0XVfGZk9p(JsonElement item, object fallback, params string[] propertyNames)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		string name = default(string);
		string text = mI9Xo5XLAV8Bv6eR7ZG2.a38XLdd3Dbh(item, name);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal unsafe static bool VDJXVLv9apm(JsonElement item, object propertyName, out JsonElement value)
	{
		value = default(JsonElement);
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Invalid comparison between Unknown and I4
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_021f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Invalid comparison between Unknown and I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		ObjectEnumerator enumerator = default(ObjectEnumerator);
		int num5 = default(int);
		JsonProperty val2 = default(JsonProperty);
		bool result = default(bool);
		int num8 = default(int);
		ObjectEnumerator val = default(ObjectEnumerator);
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
							goto case 6;
						}
						if ((item).TryGetProperty((string)propertyName, out value))
						{
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
							{
								num3 = 6;
							}
							continue;
						}
						goto IL_0242;
					case 5:
						try
						{
							while (true)
							{
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 5;
									goto IL_0081;
								}
								goto IL_00f3;
								IL_00b8:
								if (num5 == 994)
								{
									goto IL_0085;
								}
								goto IL_00f3;
								IL_00f3:
								val2 = (enumerator).Current;
								int num6 = 6;
								goto IL_0089;
								IL_0089:
								while (true)
								{
									switch (num6)
									{
									case 1:
									case 4:
										goto end_IL_0089;
									case 0:
										goto IL_00f3;
									case 6:
										if (!string.Equals((val2).Name, (string)propertyName, (StringComparison)5))
										{
											num6 = 1;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e63ddecad9e841ca90daf28662acf624 != 0)
											{
												num6 = 0;
											}
											continue;
										}
										goto IL_0165;
									case 2:
										goto IL_0165;
									case 5:
										goto end_IL_00cb;
									case 3:
										return result;
									}
									if (num5 == 14)
									{
										result = true;
										num6 = 3;
										continue;
									}
									goto IL_00b8;
									continue;
									end_IL_0089:
									break;
								}
								continue;
								IL_0165:
								value = (val2).Value;
								num4 = 14;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 == 0)
								{
									num4 = 1;
								}
								goto IL_0081;
								IL_0085:
								num6 = num5;
								goto IL_0089;
								IL_0081:
								num5 = num4;
								goto IL_0085;
								continue;
								end_IL_00cb:
								break;
							}
						}
						finally
						{
							((global::System.IDisposable)(enumerator)/*cast due to .constrained prefix*/).Dispose();
							int num7 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1060b054d02b4841b5c4af69d9c43c72 == 0)
							{
								num7 = 5;
							}
							while (true)
							{
								switch (num7)
								{
								default:
									if (num8 == 988)
									{
										num7 = num8;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
						goto case 4;
					case 3:
						return false;
					case 1:
						val = item.EnumerateObject();
						num3 = 6;
						continue;
					case 6:
						enumerator = val.GetEnumerator();
						num3 = 5;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
						{
							num3 = 0;
						}
						continue;
					case 0:
						return true;
					case 2:
						if ((int)(item).ValueKind == 1)
						{
							break;
						}
						goto IL_0242;
					case 4:
						{
							value = default(JsonElement);
							num3 = 11;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_af21df3cfe0147a89c49c07a97458d25 != 0)
							{
								num3 = 3;
							}
							continue;
						}
						IL_0242:
						if ((int)(item).ValueKind == 1)
						{
							num3 = 1;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a358d3959f2444fba3e69cf1466f79f == 0)
							{
								num3 = 11;
							}
							continue;
						}
						goto case 4;
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
			num = 9;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
			{
				num = 13;
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
	internal static bool xJBLlbZIOW0oWKUGOMyM()
	{
		return LtgKkdZIt2OrSxDSmgWe == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static s04VLvXkiAKsAsa1LtpS PtxLQwZI5DwbvBe6qjio()
	{
		return (s04VLvXkiAKsAsa1LtpS)LtgKkdZIt2OrSxDSmgWe;
	}
}

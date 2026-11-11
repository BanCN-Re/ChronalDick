using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using SRwlNQf9OPT4S1ITMMiQ;
using fDAldojjppXrctUVYOJn;

namespace pWMcGsXNNayYY5O9E3ZW;

internal class r3h9EyXNTZbakWZnRZIE
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass5_0_5
	{
		public JsonNode modification;

		internal static __c__DisplayClass5_0_5 NQoKsuDf5evG5S3smf1P;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass5_0_5()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 0;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_28ac7525e51d489c9ab6e9362cf7991d != 0)
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
		internal bool aZfL9AaxlHf(JsonNode existing)
		{
			return System.Text.Json.Nodes.JsonNode.DeepEquals(existing, modification);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KFoAwZDf6mVjm0m4oBdh()
		{
			return NQoKsuDf5evG5S3smf1P == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass5_0_5 i2jPdhDfRS1dudlfR5XC()
		{
			return NQoKsuDf5evG5S3smf1P;
		}
	}

	private static readonly object zHJXNvhJvT4;

	private static readonly object qGVXNEaZA8F;

	internal static object YrlYIHZwFAdN0QX1Df0t;

	[MethodImpl((MethodImplOptions)8)]
	internal static void UwWXNMakCcn(object targetResourcePackRoot, object overlayResourcePackRoot)
	{
		string text = default(string);
		JsonObject val = default(JsonObject);
		System.IO.File.WriteAllText(text, (val).ToJsonString((JsonSerializerOptions)qGVXNEaZA8F), (Encoding)zHJXNvhJvT4);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void yArXNpaVjAR(object target, object overlay)
	{
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		global::System.Collections.Generic.IEnumerator<KeyValuePair<string, JsonNode>> enumerator = default(global::System.Collections.Generic.IEnumerator<KeyValuePair<string, JsonNode>>);
		KeyValuePair<string, JsonNode> current = default(KeyValuePair<string, JsonNode>);
		int num4 = default(int);
		JsonArray val3 = default(JsonArray);
		JsonArray val4 = default(JsonArray);
		JsonObject val = default(JsonObject);
		JsonObject val2 = default(JsonObject);
		int num7 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					enumerator = ((dynamic)(overlay)).GetEnumerator();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
					{
						num2 = 2;
					}
					continue;
				case 0:
					return;
				case 1:
					try
					{
						while (true)
						{
							IL_02bc:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 24;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4321d0a946984495aefabb9341d85928 == 0)
								{
									num3 = 0;
								}
								goto IL_0098;
							}
							goto IL_0248;
							IL_0248:
							current = enumerator.Current;
							num3 = 7;
							goto IL_0098;
							IL_0098:
							while (true)
							{
								int num5;
								switch (num3)
								{
								case 0:
									return;
								default:
									if (num4 == 25)
									{
										goto IL_02bc;
									}
									if (num4 == 1005)
									{
										goto IL_0094;
									}
									goto case 13;
								case 2:
									if (val3 != null)
									{
										num3 = 13;
										continue;
									}
									goto case 6;
								case 3:
								case 9:
									if (!(current.Key).Equals("modifications", (StringComparison)5))
									{
										num3 = 6;
										continue;
									}
									goto case 14;
								case 1:
									if (val4 != null)
									{
										num3 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_000d98691e5a4cbea4fe886aaea99c26 != 0)
										{
											num3 = 25;
										}
										continue;
									}
									goto case 6;
								case 17:
								{
									JsonNode obj2 = ((dynamic)(target)).Item;
									val = (JsonObject)(object)((obj2 is JsonObject) ? obj2 : null);
									num3 = 16;
									continue;
								}
								case 7:
								{
									JsonNode value = current.Value;
									val2 = (JsonObject)(object)((value is JsonObject) ? value : null);
									num3 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
									{
										num3 = 12;
									}
									continue;
								}
								case 13:
									HoeXNu4o26R(val3, val4);
									num3 = 11;
									continue;
								case 4:
									break;
								case 10:
								{
									JsonNode obj = ((dynamic)(target)).Item;
									val3 = (JsonArray)(object)((obj is JsonArray) ? obj : null);
									num5 = 2;
									goto IL_0090;
								}
								case 14:
								{
									JsonNode value3 = current.Value;
									val4 = (JsonArray)(object)((value3 is JsonArray) ? value3 : null);
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
									{
										num3 = 23;
									}
									continue;
								}
								case 12:
									if (val2 != null)
									{
										num3 = 17;
										continue;
									}
									goto case 3;
								case 11:
								case 15:
									goto IL_02bc;
								case 16:
									if (val == null)
									{
										num3 = 3;
										continue;
									}
									goto case 5;
								case 5:
									yArXNpaVjAR(val, val2);
									num3 = 15;
									continue;
								case 6:
								case 8:
									{
										string key = current.Key;
										JsonNode value2 = current.Value;
										((dynamic)(target)).Item = key;
										num5 = 25;
										goto IL_0090;
									}
									IL_0090:
									num4 = num5;
									goto IL_0094;
									IL_0094:
									num3 = num4;
									continue;
								}
								break;
							}
							goto IL_0248;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 8;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_91e054342e5c4131a05fe403392c0053 != 0)
							{
								num6 = 1;
							}
							goto IL_0387;
						}
						goto IL_03ab;
						IL_0387:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0383;
								}
								goto end_IL_0387;
							case 0:
								break;
							case 1:
								goto end_IL_0387;
							case 2:
								goto end_IL_0387;
							}
							goto IL_03ab;
							IL_0383:
							num6 = num7;
							continue;
							end_IL_0387:
							break;
						}
						goto end_IL_034f;
						IL_03ab:
						(enumerator).Dispose();
						num6 = 2;
						goto IL_0387;
						end_IL_034f:;
					}
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void HoeXNu4o26R(object target, object overlay)
	{
		int num = 1;
		global::System.Collections.Generic.IEnumerator<JsonNode> enumerator = default(global::System.Collections.Generic.IEnumerator<JsonNode>);
		__c__DisplayClass5_0_5 _c__DisplayClass5_0_ = default(__c__DisplayClass5_0_5);
		int num5 = default(int);
		int num7 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					enumerator = ((dynamic)(overlay)).GetEnumerator();
					num2 = 3;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					try
					{
						while (true)
						{
							IL_013e:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 != 0)
								{
									num3 = 15;
								}
								goto IL_0083;
							}
							goto IL_00c9;
							IL_00c9:
							_c__DisplayClass5_0_ = (__c__DisplayClass5_0_5)new __c__DisplayClass5_0_5();
							num3 = 6;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e4fd2e10e6f94ff6b1cba9acd8e6f122 != 0)
							{
								num3 = 2;
							}
							goto IL_0083;
							IL_0083:
							while (true)
							{
								switch (num3)
								{
								case 1:
									return;
								default:
									if (num5 == 15)
									{
										goto IL_013e;
									}
									if (num5 == 995)
									{
										goto IL_007f;
									}
									goto case 5;
								case 4:
									break;
								case 6:
									_c__DisplayClass5_0_.modification = enumerator.Current;
									num3 = 7;
									continue;
								case 5:
									if (Enumerable.Any<JsonNode>((global::System.Collections.Generic.IEnumerable<JsonNode>)target, (Func<JsonNode, bool>)_c__DisplayClass5_0_.aZfL9AaxlHf))
									{
										num3 = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 2;
								case 0:
								case 3:
									goto IL_013e;
								case 2:
								{
									((dynamic)(target)).Add((_c__DisplayClass5_0_.modification).DeepClone());
									int num4 = 8;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8a80f401571c4c6a9b4b20ed98134421 != 0)
									{
										num4 = 15;
									}
									num5 = num4;
									goto IL_007f;
								}
								case 7:
									{
										if (_c__DisplayClass5_0_.modification == null)
										{
											num3 = 2;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a1caaffa8e254109aa8f064efa57d0db == 0)
											{
												num3 = 0;
											}
											continue;
										}
										goto case 5;
									}
									IL_007f:
									num3 = num5;
									continue;
								}
								break;
							}
							goto IL_00c9;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
							{
								num6 = 0;
							}
							goto IL_0244;
						}
						goto IL_0277;
						IL_0244:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0240;
								}
								break;
							case 0:
								goto end_IL_0244;
							case 2:
								break;
							case 1:
								goto end_IL_0244;
							}
							goto IL_0277;
							IL_0240:
							num6 = num7;
							continue;
							end_IL_0244:
							break;
						}
						goto end_IL_020c;
						IL_0277:
						(enumerator).Dispose();
						num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num6 = 0;
						}
						goto IL_0244;
						end_IL_020c:;
					}
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string dhkXNaUPjxC(object resourcePackRoot)
	{
		return System.IO.Path.Combine(System.IO.Path.GetFullPath((string)resourcePackRoot), ("ui/hud_screen.json").Replace('/', Path.DirectorySeparatorChar));
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonObject ORxXN1aDLcY(object path, bool allowMissing)
	{
		//IL_0123: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0213: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		JsonNodeOptions? val = default(JsonNodeOptions?);
		JsonObject result = default(JsonObject);
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
						if (num2 != 12)
						{
							if (num2 == 993)
							{
								goto end_IL_0010;
							}
							goto case 2;
						}
						val = null;
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df01f03b6bcc4a9c9e351e793f71f6ce != 0)
						{
							num3 = 5;
						}
						continue;
					case 2:
						try
						{
							string text = uhJLCZf9tccNtoSWw6mU.BdTf96BUDHq(path);
							JsonDocumentOptions options = uhJLCZf9tccNtoSWw6mU.Options;
							JsonNode obj = System.Text.Json.Nodes.JsonNode.Parse(text, null, options);
							JsonNode obj2 = ((obj is JsonObject) ? obj : null);
							int num4;
							if (obj2 == null)
							{
								num4 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b35bdc0764b54cee97755e23601c7b35 != 0)
								{
									num4 = 3;
								}
							}
							else
							{
								result = (JsonObject)(object)obj2;
								num4 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 != 0)
								{
									num4 = 0;
								}
							}
							while (true)
							{
								switch (num4)
								{
								default:
									if (num5 == 989)
									{
										goto IL_00b0;
									}
									break;
								case 1:
									break;
								case 0:
									goto end_IL_00b4;
								}
								throw new InvalidDataException("HUD 定义根节点必须是 JSON 对象");
								IL_00b0:
								num4 = num5;
								continue;
								end_IL_00b4:
								break;
							}
						}
						catch (JsonException ex)
						{
							JsonException ex2 = ex;
							int num6 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c0c90db096e14d5bb2505954d77983d5 == 0)
							{
								num6 = 6;
							}
							while (true)
							{
								switch (num6)
								{
								default:
									if (num7 == 988)
									{
										goto IL_0150;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_0150:
								num6 = num7;
							}
							throw new InvalidDataException(string.Concat("HUD 定义文件格式无效：", (string)path), (global::System.Exception)(object)ex2);
						}
						goto case 1;
					case 5:
						if (System.IO.File.Exists((string)path))
						{
							num3 = 4;
							continue;
						}
						goto case 3;
					case 1:
						return result;
					case 0:
						return new JsonObject(val);
					case 4:
						num = 2;
						break;
					case 3:
						if (!allowMissing)
						{
							throw new FileNotFoundException("HUD 定义文件不存在", (string)path);
						}
						num = 12;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_07b15dd9b08a43cdbce0e2e9d9235c4f == 0)
						{
							num = 0;
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
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool Sutr6XZwsmHVO8wo647r()
	{
		return YrlYIHZwFAdN0QX1Df0t == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static r3h9EyXNTZbakWZnRZIE EoxR6iZwTghybLUUOTpw()
	{
		return (r3h9EyXNTZbakWZnRZIE)YrlYIHZwFAdN0QX1Df0t;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
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
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool aZfL9AaxlHf(JsonNode existing)
		{
			return System.Text.Json.Nodes.JsonNode.DeepEquals(existing, modification);
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
							xeuj1gjjMxLGvaBvo1lH.tZtDll322LP();
							num3 = 0;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 != 0)
							{
								num3 = 7;
							}
							continue;
						case 1:
							break;
						case 0:
							return;
						case 2:
							num3 = 1;
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
				num = 9;
				if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_df1e958ed5da494bb4193eb90da2cb28 == 0)
				{
					num = 5;
				}
			}
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
		int num = 6;
		string text2 = default(string);
		string text = default(string);
		JsonObject val = default(JsonObject);
		JsonObject overlay = default(JsonObject);
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
					{
						if (num2 != 15)
						{
							goto end_IL_0010;
						}
						if (!System.IO.File.Exists(text2))
						{
							num = 3;
							break;
						}
						string text3 = System.IO.Path.GetDirectoryName(text);
						if (text3 == null)
						{
							num3 = 7;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_272b03c748a0400b8a2b25694e2c3683 == 0)
							{
								num3 = 0;
							}
							continue;
						}
						System.IO.Directory.CreateDirectory(text3);
						num3 = 7;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6c07fa75b868423baeb07539d4fc8994 == 0)
						{
							num3 = 10;
						}
						continue;
					}
					case 8:
						yArXNpaVjAR(val, overlay);
						num3 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_656d5ca0e72248a097dc6256aeab21de != 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						System.IO.File.WriteAllText(text, (val).ToJsonString((JsonSerializerOptions)qGVXNEaZA8F), (Encoding)zHJXNvhJvT4);
						num3 = 4;
						continue;
					case 2:
						overlay = ORxXN1aDLcY(text2, allowMissing: false);
						num3 = 8;
						continue;
					case 5:
						text2 = dhkXNaUPjxC(overlayResourcePackRoot);
						num = 15;
						break;
					case 4:
						return;
					case 7:
						val = ORxXN1aDLcY(text, allowMissing: true);
						num = 2;
						break;
					case 6:
						text = dhkXNaUPjxC(targetResourcePackRoot);
						num3 = 13;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5fa06d008c734fbdaa61be59e2e96b3f != 0)
						{
							num3 = 5;
						}
						continue;
					case 3:
						return;
					case 0:
						throw new global::System.Exception("无法确定 HUD 定义目录");
					}
					goto end_IL_000c;
					continue;
					end_IL_0010:
					break;
				}
				if (num2 != 996)
				{
					return;
				}
				continue;
				end_IL_000c:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void yArXNpaVjAR(object target, object overlay)
	{
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Ref
		//IL_0146: Expected O, but got Ref
		//IL_0259: Expected O, but got Ref
		//IL_026e: Expected O, but got Ref
		//IL_0198: Expected O, but got Ref
		//IL_0316: Expected O, but got Ref
		//IL_0320: Expected O, but got Ref
		int num = 2;
		global::System.Collections.Generic.IEnumerator<KeyValuePair<string, JsonNode>> enumerator = default(global::System.Collections.Generic.IEnumerator<KeyValuePair<string, JsonNode>>);
		KeyValuePair<string, JsonNode> val = default(KeyValuePair<string, JsonNode>);
		int num4 = default(int);
		JsonArray val4 = default(JsonArray);
		JsonArray val5 = default(JsonArray);
		JsonObject val2 = default(JsonObject);
		JsonObject val3 = default(JsonObject);
		int num7 = default(int);
		do
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					enumerator = (overlay).GetEnumerator();
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
							IL_02a4:
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
							goto IL_023c;
							IL_023c:
							val = (KeyValuePair<string, JsonNode>)enumerator;
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
										goto IL_02a4;
									}
									if (num4 == 1005)
									{
										goto IL_0094;
									}
									goto case 13;
								case 2:
									if (val4 != null)
									{
										num3 = 13;
										continue;
									}
									goto case 6;
								case 3:
								case 9:
									if (!((object)(&val)).Equals("modifications", (StringComparison)5))
									{
										num3 = 6;
										continue;
									}
									goto case 14;
								case 1:
									if (val5 != null)
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
									JsonNode obj2 = (target).Item;
									val2 = (JsonObject)(object)((obj2 is JsonObject) ? obj2 : null);
									num3 = 16;
									continue;
								}
								case 7:
									val3 = (JsonObject)((((object)(&val)) is JsonObject) ? ((object)(&val)) : null);
									num3 = 17;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd == 0)
									{
										num3 = 12;
									}
									continue;
								case 13:
									HoeXNu4o26R(val4, val5);
									num3 = 11;
									continue;
								case 4:
									break;
								case 10:
								{
									JsonNode obj = (target).Item;
									val4 = (JsonArray)(object)((obj is JsonArray) ? obj : null);
									num5 = 2;
									goto IL_0090;
								}
								case 14:
									val5 = (JsonArray)((((object)(&val)) is JsonArray) ? ((object)(&val)) : null);
									num3 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
									{
										num3 = 23;
									}
									continue;
								case 12:
									if (val3 != null)
									{
										num3 = 17;
										continue;
									}
									goto case 3;
								case 11:
								case 15:
									goto IL_02a4;
								case 16:
									if (val2 == null)
									{
										num3 = 3;
										continue;
									}
									goto case 5;
								case 5:
									yArXNpaVjAR(val2, val3);
									num3 = 15;
									continue;
								case 6:
								case 8:
									{
										(target).Item = (string)(&val);
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
							goto IL_023c;
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
							goto IL_0367;
						}
						goto IL_038b;
						IL_0367:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0363;
								}
								goto end_IL_0367;
							case 0:
								break;
							case 1:
								goto end_IL_0367;
							case 2:
								goto end_IL_0367;
							}
							goto IL_038b;
							IL_0363:
							num6 = num7;
							continue;
							end_IL_0367:
							break;
						}
						goto end_IL_032f;
						IL_038b:
						(enumerator).Dispose();
						num6 = 2;
						goto IL_0367;
						end_IL_032f:;
					}
				}
				break;
			}
		}
		while (num == 990);
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static void HoeXNu4o26R(object target, object overlay)
	{
		//IL_0112: Expected O, but got I
		//IL_0117->IL0166: Incompatible stack heights: 1 vs 0
		//IL_012b->IL0083: Incompatible stack heights: 2 vs 1
		//IL_0136->IL0083: Incompatible stack heights: 2 vs 1
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
					enumerator = (overlay).GetEnumerator();
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
							IL_0136:
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
										goto IL_0136;
									}
									if (num5 == 995)
									{
										goto IL_007f;
									}
									goto case 5;
								case 4:
									break;
								case 6:
									_c__DisplayClass5_0_.modification = (JsonNode)enumerator;
									num3 = 7;
									continue;
								case 5:
									if (Enumerable.Any<JsonNode>((global::System.Collections.Generic.IEnumerable<JsonNode>)(object)_c__DisplayClass5_0_, new Func<JsonNode, bool>(__c__DisplayClass5_0_5.aZfL9AaxlHf)))
									{
										_ = 2;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 == 0)
										{
											_ = 3;
										}
										continue;
									}
									goto case 2;
								case 0:
								case 3:
									goto IL_0136;
								case 2:
								{
									(target).Add((_c__DisplayClass5_0_.modification).DeepClone());
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
							goto IL_023c;
						}
						goto IL_026f;
						IL_023c:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_0238;
								}
								break;
							case 0:
								goto end_IL_023c;
							case 2:
								break;
							case 1:
								goto end_IL_023c;
							}
							goto IL_026f;
							IL_0238:
							num6 = num7;
							continue;
							end_IL_023c:
							break;
						}
						goto end_IL_0204;
						IL_026f:
						(enumerator).Dispose();
						num6 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 == 0)
						{
							num6 = 0;
						}
						goto IL_023c;
						end_IL_0204:;
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
		// UNDECRYPTED: the decompiled body contained ILSpy error placeholders.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonObject ORxXN1aDLcY(object path, bool allowMissing)
	{
		//IL_011f: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		JsonNodeOptions? result = default(JsonNodeOptions?);
		JsonObject result2 = default(JsonObject);
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
						result = null;
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
								result2 = (JsonObject)(object)obj2;
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
								throw new global::System.Exception("HUD 定义根节点必须是 JSON 对象");
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
										goto IL_014c;
									}
									break;
								case 0:
									break;
								}
								break;
								IL_014c:
								num6 = num7;
							}
							string.Concat("HUD 定义文件格式无效：", (string)path);
							throw ex2;
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
						return result2;
					case 0:
						return (JsonObject)result;
					case 4:
						num = 2;
						break;
					case 3:
						if (!allowMissing)
						{
							_ = "HUD 定义文件不存在";
							throw path;
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

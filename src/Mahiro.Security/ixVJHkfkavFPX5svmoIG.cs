using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using OWRumnXNe7U48tXBXFAY;
using QRgJ6Vf1lrdpBGToI64w;
using SRwlNQf9OPT4S1ITMMiQ;
using fDAldojjppXrctUVYOJn;

namespace RRqahNfk15PQWoUZSIZc;

internal class ixVJHkfkavFPX5svmoIG
{
	[CompilerGenerated]
	private sealed class __c__DisplayClass4_0_8
	{
		public KJlRUyf1gXDQ3gU9B09h pack;

		private static __c__DisplayClass4_0_8 NoBMmSD8TM7ELUqL4qFN;

		[MethodImpl((MethodImplOptions)8)]
		public __c__DisplayClass4_0_8()
		{
			HoP9ICjZCDYHN95uHuq9.DoBDBEwiSQG();
			int num = 2;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
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
		internal bool wxlLSMItcbk(JsonElement module)
		{
			JsonElement val = default(JsonElement);
			bool flag = ((val).GetString() == "resources");
			return default(bool);
		}

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool KdMMQJD8NUIDs4aZyn3Q()
		{
			return NoBMmSD8TM7ELUqL4qFN == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c__DisplayClass4_0_8 qLDcSxD8Mn2YfM2CGv28()
		{
			return NoBMmSD8TM7ELUqL4qFN;
		}
	}

	internal static object fIQ1HQZMjvCrXnQMmnDY;

	[MethodImpl((MethodImplOptions)8)]
	internal static string zocfk3v7I20(object pack)
	{
		string text2 = default(string);
		string text = string.Join("\n", new string[5]
		{
			"server-resource-v1",
			System.IO.Path.GetFullPath(((KJlRUyf1gXDQ3gU9B09h)pack).Path),
			((KJlRUyf1gXDQ3gU9B09h)pack).ItemId,
			((KJlRUyf1gXDQ3gU9B09h)pack).ResourceUuid,
			text2
		});
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool rUXfkvRvJtm(object directory, object pack, object identity)
	{
		//IL_019b: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		int num = 1;
		int num4 = default(int);
		bool result = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num7);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num9 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 0:
				break;
			default:
				try
				{
					string text = System.IO.Path.Combine((string)directory, ".chronal-server-resource");
					int num2 = 7;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2eb318c54136440fb35a4565aef07a31 != 0)
					{
						num2 = 1;
					}
					while (true)
					{
						int num3;
						switch (num2)
						{
						default:
							if (num4 != 17)
							{
								if (num4 == 997)
								{
									goto IL_008f;
								}
								goto case 1;
							}
							result = false;
							num2 = 6;
							continue;
						case 4:
							result = false;
							num2 = 5;
							continue;
						case 3:
							KxxYYwXNwodeMw0HASFS.q42XNxRA7U5(text);
							num3 = 2;
							goto IL_008b;
						case 1:
							if (!System.IO.File.Exists(text))
							{
								num3 = 17;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
								{
									num3 = 17;
								}
								goto IL_008b;
							}
							goto case 3;
						case 5:
							break;
						case 8:
							if (string.Equals(System.IO.File.ReadAllText(text, System.Text.Encoding.UTF8), (string)identity, (StringComparison)4))
							{
								num2 = 5;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e9c75f551b5546a984ccda19afde4ef2 == 0)
								{
									num2 = 7;
								}
								continue;
							}
							goto case 4;
						case 2:
							if ((new FileInfo(text)).Length == 64)
							{
								num2 = 8;
								continue;
							}
							goto case 4;
						case 6:
							break;
						case 0:
						case 7:
							result = eMIfk2hEPVX(K5gfkE6LgVd(directory), pack);
							num2 = 3;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bd34db6d49714aa2bb251a4e3295cd54 != 0)
							{
								num2 = 9;
							}
							continue;
						case 9:
							break;
							IL_008f:
							num2 = num4;
							continue;
							IL_008b:
							num4 = num3;
							goto IL_008f;
						}
						break;
					}
				}
				catch (global::System.Exception obj) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					obj2 = obj as global::System.Exception;
					if (obj2 == null)
					{
						num5 = 6;
					}
					else
					{
						ex = obj2;
						num5 = 11;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_edba5e6f3218484f870272d5f53ff393 == 0)
						{
							num5 = 0;
						}
					}
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 15)
							{
								if (num6 == 995)
								{
									goto IL_023d;
								}
								goto case 0;
							}
							if (ex is JsonException)
							{
								num7 = 5;
								goto IL_0239;
							}
							goto case 4;
						case 4:
							flag = false;
							num5 = 3;
							continue;
						case 5:
						case 7:
							flag = true;
							num5 = 2;
							continue;
						case 0:
							if (ex is IOException)
							{
								num5 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_66b1ecca45f145bca43919729b74cb85 == 0)
								{
									num5 = 9;
								}
								continue;
							}
							goto case 1;
						case 1:
							if (!(ex is UnauthorizedAccessException))
							{
								num7 = 15;
								goto IL_0239;
							}
							goto case 5;
						case 6:
							result2 = 0;
							break;
						case 2:
						case 3:
							{
								result2 = (flag ? 1 : 0);
								break;
							}
							IL_0239:
							num6 = num7;
							goto IL_023d;
							IL_023d:
							num5 = num6;
							continue;
						}
						break;
					}
					return (byte)result2 != 0;
				}).Invoke())
				{
					int num8 = 2;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3d3b33b2e9544f29a086e8579a9858d3 == 0)
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
							goto end_IL_038b;
						}
						result = false;
						num8 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 == 0)
						{
							num8 = 3;
						}
						continue;
						end_IL_038b:
						break;
					}
				}
				break;
			}
			break;
		}
		return result;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string K5gfkE6LgVd(object directory)
	{
		string text = System.IO.Path.Combine((string)directory, "pack_manifest.json");
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool eMIfk2hEPVX(object json, object pack)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Invalid comparison between Unknown and I4
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Invalid comparison between Unknown and I4
		//IL_049d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Invalid comparison between Unknown and I4
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Invalid comparison between Unknown and I4
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Invalid comparison between Unknown and I4
		//IL_0338: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Invalid comparison between Unknown and I4
		int num = 2;
		JsonDocument val2 = default(JsonDocument);
		int num8 = default(int);
		JsonElement[] array = default(JsonElement[]);
		int num5 = default(int);
		int num7 = default(int);
		JsonElement val5 = default(JsonElement);
		__c__DisplayClass4_0_8 _c__DisplayClass4_0_ = default(__c__DisplayClass4_0_8);
		JsonElement val6 = default(JsonElement);
		JsonElement val4 = default(JsonElement);
		bool result = default(bool);
		JsonElement val3 = default(JsonElement);
		int num10 = default(int);
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
						if (num2 != 10)
						{
							if (num2 == 991)
							{
								goto end_IL_0010;
							}
						}
						else
						{
							try
							{
								JsonElement val = (val2).RootElement;
								int num4 = 23;
								while (true)
								{
									int num6;
									switch (num4)
									{
									default:
										if (num8 != 37)
										{
											if (num8 == 1017)
											{
												goto IL_00d6;
											}
											goto case 5;
										}
										goto case 25;
									case 13:
										if (!(array[num5]).TryGetInt32(out num7))
										{
											num4 = 8;
											continue;
										}
										goto case 10;
									case 28:
										if (string.Equals((val5).GetString(), _c__DisplayClass4_0_.pack.PackId, (StringComparison)5))
										{
											num4 = 17;
											continue;
										}
										goto case 15;
									case 29:
										if ((int)(val6).ValueKind != 2)
										{
											num4 = 18;
											continue;
										}
										goto case 26;
									case 20:
										if ((int)(val4).ValueKind == 1)
										{
											num4 = 11;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4b42c4d37c4841809b92808162551ee8 == 0)
											{
												num4 = 29;
											}
											continue;
										}
										goto case 15;
									case 25:
										if ((int)(array[num5]).ValueKind == 4)
										{
											num4 = 13;
											continue;
										}
										goto case 6;
									case 4:
										break;
									case 5:
										if (array.Length != ((global::System.Collections.Generic.IReadOnlyCollection<int>)_c__DisplayClass4_0_.pack.Version).Count)
										{
											num4 = 7;
											continue;
										}
										goto case 9;
									case 7:
										result = false;
										num4 = 3;
										continue;
									case 6:
									case 8:
										result = false;
										num4 = 4;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
										{
											num4 = 5;
										}
										continue;
									case 17:
										if ((val4).TryGetProperty("version", out val3))
										{
											num4 = 24;
											continue;
										}
										goto case 15;
									case 19:
										if ((val).TryGetProperty("modules", out val6))
										{
											num4 = 29;
											continue;
										}
										goto case 15;
									case 0:
										num5++;
										num4 = 12;
										continue;
									case 26:
										array = Enumerable.ToArray<JsonElement>((global::System.Collections.Generic.IEnumerable<JsonElement>)(object)val3.EnumerateArray());
										num4 = 5;
										continue;
									case 23:
										if ((int)(val).ValueKind == 1)
										{
											num4 = 27;
											continue;
										}
										goto case 15;
									case 10:
										if (num7 != _c__DisplayClass4_0_.pack.Version[num5])
										{
											num4 = 6;
											continue;
										}
										goto case 0;
									case 12:
									case 22:
										if (num5 < array.Length)
										{
											num6 = 37;
											goto IL_00d2;
										}
										goto case 21;
									case 15:
									case 16:
									case 18:
										result = false;
										num4 = 20;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
										{
											num4 = 14;
										}
										continue;
									case 11:
										if (!(val4).TryGetProperty("uuid", out val5))
										{
											num4 = 16;
											continue;
										}
										goto case 1;
									case 14:
										break;
									case 3:
										break;
									case 21:
										result = Enumerable.Any<JsonElement>((global::System.Collections.Generic.IEnumerable<JsonElement>)(object)val6.EnumerateArray(), (Func<JsonElement, bool>)_c__DisplayClass4_0_.wxlLSMItcbk);
										num6 = 2;
										goto IL_00d2;
									case 27:
										if (!(val).TryGetProperty("header", out val4))
										{
											num4 = 15;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
											{
												num4 = 5;
											}
											continue;
										}
										goto case 20;
									case 24:
										if ((int)(val3).ValueKind == 2)
										{
											num4 = 19;
											continue;
										}
										goto case 15;
									case 9:
										num5 = 0;
										num4 = 22;
										continue;
									case 1:
										if ((int)(val5).ValueKind == 3)
										{
											num4 = 28;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f0cef1f68c884901a752ccfbf999fcf7 != 0)
											{
												num4 = 6;
											}
											continue;
										}
										goto case 15;
									case 2:
										break;
										IL_00d2:
										num8 = num6;
										goto IL_00d6;
										IL_00d6:
										num4 = num8;
										continue;
									}
									break;
								}
							}
							finally
							{
								if (val2 != null)
								{
									int num9 = 3;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
									{
										num9 = 0;
									}
									while (true)
									{
										switch (num9)
										{
										default:
											if (num10 == 989)
											{
												num9 = num10;
												continue;
											}
											break;
										case 0:
											(val2).Dispose();
											num9 = 7;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_926e29e139084e15a636e4b6faf69dee == 0)
											{
												num9 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						}
						goto case 0;
					case 1:
						_c__DisplayClass4_0_.pack = (KJlRUyf1gXDQ3gU9B09h)pack;
						num3 = 3;
						continue;
					case 2:
						_c__DisplayClass4_0_ = (__c__DisplayClass4_0_8)new __c__DisplayClass4_0_8();
						num3 = 1;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fc70b9ab3f6a443689911f6020e88e48 != 0)
						{
							num3 = 3;
						}
						continue;
					case 3:
						break;
					case 0:
						return result;
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
			val2 = System.Text.Json.JsonDocument.Parse((string)json, uhJLCZf9tccNtoSWw6mU.Options);
			num = 10;
			if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc != 0)
			{
				num = 6;
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
	internal static bool FqcsUQZMZ3G4wwu5AjBc()
	{
		return fIQ1HQZMjvCrXnQMmnDY == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ixVJHkfkavFPX5svmoIG mA7VjJZM9CrcfOGTTfIF()
	{
		return (ixVJHkfkavFPX5svmoIG)fIQ1HQZMjvCrXnQMmnDY;
	}
}

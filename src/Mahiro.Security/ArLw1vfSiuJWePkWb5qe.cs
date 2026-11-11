using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization.Metadata;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using fDAldojjppXrctUVYOJn;

namespace JVi5OJfSnFN8jVV1LrDR;

internal class ArLw1vfSiuJWePkWb5qe
{
	private static readonly object YVEfcZ5elYk;

	private static readonly object HiEfc9DW5iT;

	internal static object nkg49OZMzgBdcgAfDiDn;

	[MethodImpl((MethodImplOptions)8)]
	internal static void nHCfSz7syTa(object definitionListPath, object definitionPath)
	{
		JsonObject val = FPpfcX65vX3(definitionListPath, allowMissing: true);
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static void SVwfcbKXJtW(object targetPath, object overlayPath)
	{
		//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
		int num = 6;
		JsonObject root = default(JsonObject);
		JsonArray val2 = default(JsonArray);
		bool flag = default(bool);
		global::System.Collections.Generic.IEnumerator<JsonNode> enumerator = default(global::System.Collections.Generic.IEnumerator<JsonNode>);
		JsonValue val = default(JsonValue);
		int num6 = default(int);
		string text = default(string);
		int num8 = default(int);
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
						if (num2 == 13)
						{
							return;
						}
						goto IL_003f;
					case 2:
						return;
					case 3:
						return;
					case 5:
					{
						JsonArray obj = P6afcfenhHN(FPpfcX65vX3(overlayPath, allowMissing: false), overlayPath, createWhenMissing: false);
						root = FPpfcX65vX3(targetPath, allowMissing: true);
						val2 = P6afcfenhHN(root, targetPath, createWhenMissing: true);
						flag = !System.IO.File.Exists((string)targetPath);
						enumerator = (obj).GetEnumerator();
						num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b == 0)
						{
							num3 = 13;
						}
						continue;
					}
					case 0:
						try
						{
							while (true)
							{
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 4;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4eb17ff7928b458088fd741c15f170d6 == 0)
									{
										num4 = 0;
									}
									goto IL_010c;
								}
								goto IL_0245;
								IL_0245:
								JsonNode current = enumerator.Current;
								val = (JsonValue)(object)((current is JsonValue) ? current : null);
								num4 = 3;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cabd341e1e0f4d078661ff79dc927388 == 0)
								{
									num4 = 11;
								}
								goto IL_010c;
								IL_010c:
								while (true)
								{
									int num5;
									switch (num4)
									{
									default:
										if (num6 == 16)
										{
											goto case 4;
										}
										if (num6 == 996)
										{
											goto IL_0108;
										}
										goto case 6;
									case 2:
										flag = true;
										num4 = 16;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e527ac8ae3ac44a386a58f4d22e66d86 != 0)
										{
											num4 = 5;
										}
										continue;
									case 3:
										if (val == null)
										{
											num5 = 4;
											goto IL_0104;
										}
										goto case 8;
									case 7:
										if (string.IsNullOrWhiteSpace(text))
										{
											num5 = 16;
											goto IL_0104;
										}
										if (!M7nfcLsyP5F(val2, text))
										{
											num4 = 6;
											continue;
										}
										break;
									case 5:
										break;
									case 4:
										throw new InvalidDataException(string.Concat("资源包 UI 定义项格式无效：", (string)overlayPath));
									case 8:
										if (val.TryGetValue<string>(out text))
										{
											num4 = 6;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_514bfdb9e1954317af4017183c51ee76 == 0)
											{
												num4 = 7;
											}
											continue;
										}
										goto case 4;
									case 1:
										goto IL_0245;
									case 6:
										val2.Add<string>(text);
										num4 = 2;
										continue;
									case 0:
										goto end_IL_01a4;
										IL_0108:
										num4 = num6;
										continue;
										IL_0104:
										num6 = num5;
										goto IL_0108;
									}
									break;
								}
								continue;
								end_IL_01a4:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a94f9e8110b340d7887337cb51d068cd == 0)
								{
									num7 = 3;
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
									case 1:
										(enumerator).Dispose();
										num7 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0525cb59c48e4cefbd4f54ca736c8b94 == 0)
										{
											num7 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
						goto case 4;
					case 4:
						if (!flag)
						{
							num3 = 2;
							continue;
						}
						goto end_IL_000c;
					case 6:
						break;
					case 1:
						goto end_IL_000c;
					}
					goto IL_0362;
					IL_003f:
					if (num2 == 994)
					{
						break;
					}
					goto IL_0362;
					IL_0362:
					if (!System.IO.File.Exists((string)overlayPath))
					{
						return;
					}
					num3 = 5;
				}
				continue;
				end_IL_000c:
				break;
			}
			RXKfcjgJsJL(targetPath, root);
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonObject FPpfcX65vX3(object path, bool allowMissing)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		int num = 4;
		return default(JsonObject);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static JsonArray P6afcfenhHN(object root, object path, bool createWhenMissing)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		JsonNode obj = ((dynamic)(root)).Item;
		JsonArray val = (JsonArray)(object)((obj is JsonArray) ? obj : null);
		return default(JsonArray);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool M7nfcLsyP5F(object definitions, object definitionPath)
	{
		int num = 2;
		global::System.Collections.Generic.IEnumerator<JsonNode> enumerator = default(global::System.Collections.Generic.IEnumerator<JsonNode>);
		JsonValue val = default(JsonValue);
		bool result = default(bool);
		int num5 = default(int);
		string text = default(string);
		int num7 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (num == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					return false;
				case 2:
					enumerator = ((dynamic)(definitions)).GetEnumerator();
					num2 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_3b30691109cf433bacd3ed09064b7525 == 0)
					{
						num2 = 5;
					}
					break;
				case 1:
					try
					{
						while (true)
						{
							IL_0195:
							int num3;
							if (!(enumerator).MoveNext())
							{
								num3 = 11;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_64b68a9073c5462fad6b588de485f4e3 != 0)
								{
									num3 = 1;
								}
								goto IL_009c;
							}
							goto IL_017d;
							IL_017d:
							JsonNode current = enumerator.Current;
							val = (JsonValue)(object)((current is JsonValue) ? current : null);
							num3 = 3;
							goto IL_009c;
							IL_009c:
							while (true)
							{
								int num4;
								switch (num3)
								{
								case 7:
									return result;
								default:
									if (num5 != 15)
									{
										if (num5 == 995)
										{
											goto IL_0098;
										}
										goto case 3;
									}
									goto IL_0195;
								case 4:
									if (string.Equals(text, (string)definitionPath, (StringComparison)5))
									{
										num3 = 2;
										continue;
									}
									goto IL_0195;
								case 5:
									if (!val.TryGetValue<string>(out text))
									{
										num4 = 15;
										goto IL_0094;
									}
									goto case 4;
								case 2:
									result = true;
									num4 = 7;
									goto IL_0094;
								case 3:
									if (val != null)
									{
										num3 = 5;
										continue;
									}
									goto IL_0195;
								case 6:
									break;
								case 0:
									goto IL_0195;
								case 1:
									goto end_IL_0195;
									IL_0094:
									num5 = num4;
									goto IL_0098;
									IL_0098:
									num3 = num5;
									continue;
								}
								break;
							}
							goto IL_017d;
							continue;
							end_IL_0195:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator == null)
						{
							num6 = 2;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_2187a34611da4635a5f05690d7cc60dc == 0)
							{
								num6 = 0;
							}
							goto IL_0202;
						}
						goto IL_0226;
						IL_0202:
						while (true)
						{
							switch (num6)
							{
							default:
								if (num7 == 990)
								{
									goto IL_01fe;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_0202;
							case 2:
								goto end_IL_0202;
							}
							goto IL_0226;
							IL_01fe:
							num6 = num7;
							continue;
							end_IL_0202:
							break;
						}
						goto end_IL_01ca;
						IL_0226:
						(enumerator).Dispose();
						num6 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_fcff77dfc1ff426f9f9c0bf74dc791be == 0)
						{
							num6 = 6;
						}
						goto IL_0202;
						end_IL_01ca:;
					}
					goto case 0;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void RXKfcjgJsJL(object path, object root)
	{
		System.IO.File.WriteAllText((string)path, ((dynamic)(root)).ToJsonString((JsonSerializerOptions)HiEfc9DW5iT), (Encoding)YVEfcZ5elYk);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool YUrfsXZpbrLhkDeu7g5v()
	{
		return nkg49OZMzgBdcgAfDiDn == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static ArLw1vfSiuJWePkWb5qe xQtAQbZpXSHaysFswgeA()
	{
		return (ArLw1vfSiuJWePkWb5qe)nkg49OZMzgBdcgAfDiDn;
	}
}

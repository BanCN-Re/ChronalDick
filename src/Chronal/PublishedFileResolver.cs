using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using By1SFsLobKQOZCdh5qRg;
using qS8vkpL43FlTMgcj0rgs;

namespace Mahiro_Account.Services;

internal class PublishedFileResolver
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_16
	{
		public static readonly __c_16 __9;

		public static Func<string, bool> __9__8_0;

		internal static __c_16 aZGHTrLGAmP8UKBbHgSt;

		static __c_16()
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
							if (num2 != 10)
							{
								if (num2 == 991)
								{
									goto end_IL_0012;
								}
								goto case 1;
							}
							return;
						case 3:
							break;
						case 1:
							num3 = 8;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_cc5bd43d70674cf481f40e84bf27aa89 == 0)
							{
								num3 = 0;
							}
							continue;
						case 0:
							num3 = 7;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0cbd4cb78159400b923bd185c17f634c == 0)
							{
								num3 = 2;
							}
							continue;
						case 2:
							num3 = 3;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_efa7845a846a43508e861e510ac5e1d2 != 0)
							{
								num3 = 6;
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
				__9 = (__c_16)new __c_16();
				num = 10;
				if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ff96c054b9a547fc83bea3daf4a435ff == 0)
				{
					num = 4;
				}
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_16()
		{
			//IL_004c: Expected I4, but got O
			//IL_0031->IL0043: Incompatible stack types: I4 vs O
			//IL_003c->IL0043: Incompatible stack types: I4 vs O
			object obj = 4;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1df8e086d5ed471cbc378d2545a921c6 == 0)
			{
				obj = 0;
			}
			object obj2 = default(object);
			while (true)
			{
				switch ((int)obj)
				{
				case 0:
					return;
				}
				if ((nint)obj2 == 988)
				{
					obj = obj2;
					continue;
				}
				return;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal bool _IsSafeRelativePath_b__8_0(string segment)
		{
			//IL_000c: Expected O, but got I4
			//IL_0031: Expected I4, but got O
			//IL_00a1: Expected O, but got I4
			//IL_00c3: Expected O, but got I4
			//IL_005c: Expected I4, but got O
			//IL_00b5->IL0010: Incompatible stack types: I4 vs O
			//IL_00cd->IL0010: Incompatible stack types: I4 vs O
			//IL_0119->IL0010: Incompatible stack types: I4 vs O
			//IL_00c0->IL0010: Incompatible stack types: I4 vs O
			//IL_0124->IL0010: Incompatible stack types: I4 vs O
			int num = 2;
			dynamic obj3 = default(object);
			while (true)
			{
				object obj = num;
				while (true)
				{
					object obj2 = obj;
					while (true)
					{
						switch ((int)obj2)
						{
						default:
							if ((nint)obj != 13)
							{
								if ((nint)obj == 994)
								{
									goto end_IL_0010;
								}
								goto case 0;
							}
							goto case 5;
						case 0:
						case 6:
							return (byte)(int)obj3 != 0;
						case 3:
							if (!(segment == ".."))
							{
								goto end_IL_000c;
							}
							goto case 1;
						case 1:
						case 4:
							obj3 = 1;
							obj2 = 0;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 == 0)
							{
								obj2 = 2;
							}
							break;
						case 5:
							obj3 = 0;
							obj2 = 6;
							break;
						case 2:
							if ((segment == "."))
							{
								obj2 = 1;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
								{
									obj2 = 0;
								}
								break;
							}
							goto case 3;
						}
						continue;
						end_IL_0010:
						break;
					}
					continue;
					end_IL_000c:
					break;
				}
				num = 13;
			}
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool aeYVwELGIjxvyCIHqhmW()
		{
			return aZGHTrLGAmP8UKBbHgSt == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_16 bHf9eILGBUcAGKI0tuLf()
		{
			return aZGHTrLGAmP8UKBbHgSt;
		}
	}

	private const string ManifestFileName = ".chronal-files.json";

	private static readonly Lazy<IReadOnlyDictionary<string, string>> Mapping;

	private static PublishedFileResolver i0YmC2LEASqaPm4aymRb;

	[MethodImpl((MethodImplOptions)8)]
	internal static string Resolve(string relativePath)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0055->IL0010: Incompatible stack types: I4 vs O
		//IL_00c8->IL0010: Incompatible stack types: I4 vs O
		//IL_0060->IL0010: Incompatible stack types: I4 vs O
		//IL_00d3->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		string obj3 = default(string);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 0:
					obj3 = ResolveMappedRelativePath(Normalize(relativePath));
					obj2 = 2;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d == 0)
					{
						obj2 = 5;
					}
					break;
				case 2:
					return System.IO.Path.Combine(System.AppContext.BaseDirectory, (obj3).Replace('/', Path.DirectorySeparatorChar));
				case 1:
					System.ArgumentException.ThrowIfNullOrWhiteSpace(relativePath, "relativePath");
					obj2 = 3;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a1a3680c38d4488598afb1defd71e635 == 0)
					{
						obj2 = 0;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string ResolveDirectory(string relativePath)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_007d->IL0010: Incompatible stack types: I4 vs O
		//IL_00c2->IL0010: Incompatible stack types: I4 vs O
		//IL_0088->IL0010: Incompatible stack types: I4 vs O
		//IL_00cd->IL0010: Incompatible stack types: I4 vs O
		object obj = 2;
		string obj3 = default(string);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 1;
				case 0:
					return System.IO.Path.Combine(System.AppContext.BaseDirectory, (obj3).Replace('/', Path.DirectorySeparatorChar));
				case 1:
					obj3 = ResolveMappedRelativePath(Normalize(relativePath));
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd754e211a3740b7abeee191b9ceae68 == 0)
					{
						obj2 = 3;
					}
					break;
				case 2:
					System.ArgumentException.ThrowIfNullOrWhiteSpace(relativePath, "relativePath");
					obj2 = 1;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e1a4b1278f5749c28fff394e2932a022 == 0)
					{
						obj2 = 7;
					}
					break;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static string ResolveFileName(string relativePath)
	{
		return System.IO.Path.GetFileName(Resolve(relativePath));
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static IReadOnlyDictionary<string, string> LoadMapping()
	{
		//IL_000c: Expected O, but got I4
		//IL_0025: Expected I4, but got O
		//IL_0454: Expected I4, but got O
		//IL_0597: Expected I4, but got O
		//IL_04f5: Expected I4, but got O
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_00c8: Expected I4, but got O
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0265: Expected O, but got Unknown
		//IL_0199: Expected O, but got I4
		//IL_0494: Unknown result type (might be due to invalid IL or missing references)
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		//IL_01c2: Expected I4, but got O
		//IL_02d4: Expected O, but got I4
		//IL_02f9: Expected I4, but got O
		//IL_042e->IL044b: Incompatible stack types: I4 vs O
		//IL_056d->IL058a: Incompatible stack types: I4 vs O
		//IL_0439->IL044b: Incompatible stack types: I4 vs O
		//IL_04cb->IL04e8: Incompatible stack types: I4 vs O
		//IL_0578->IL058a: Incompatible stack types: I4 vs O
		//IL_04d6->IL04e8: Incompatible stack types: I4 vs O
		//IL_05cf->IL058a: Incompatible stack types: I4 vs O
		//IL_0528->IL04e8: Incompatible stack types: I4 vs O
		//IL_05da->IL058a: Incompatible stack types: I4 vs O
		//IL_064f->IL0010: Incompatible stack types: I4 vs O
		//IL_005d->IL0010: Incompatible stack types: I4 vs O
		//IL_0533->IL04e8: Incompatible stack types: I4 vs O
		//IL_065a->IL0010: Incompatible stack types: I4 vs O
		//IL_0068->IL0010: Incompatible stack types: I4 vs O
		//IL_012a->IL00ab: Incompatible stack types: I4 vs O
		//IL_008e->IL00ab: Incompatible stack types: I4 vs O
		//IL_0099->IL00ab: Incompatible stack types: I4 vs O
		//IL_0111->IL00ab: Incompatible stack types: I4 vs O
		//IL_0180->IL019d: Incompatible stack types: I4 vs O
		//IL_011c->IL00ab: Incompatible stack types: I4 vs O
		//IL_018b->IL019d: Incompatible stack types: I4 vs O
		//IL_026f->IL019d: Incompatible stack types: I4 vs O
		//IL_01f1->IL019d: Incompatible stack types: I4 vs O
		//IL_04ab->IL019d: Incompatible stack types: I4 vs O
		//IL_028a->IL019d: Incompatible stack types: I4 vs O
		//IL_0295->IL019d: Incompatible stack types: I4 vs O
		//IL_0392->IL02d8: Incompatible stack types: I4 vs O
		//IL_0408->IL02d8: Incompatible stack types: I4 vs O
		//IL_039d->IL02d8: Incompatible stack types: I4 vs O
		//IL_033c->IL02d8: Incompatible stack types: I4 vs O
		//IL_035f->IL02d8: Incompatible stack types: I4 vs O
		//IL_0375->IL02d8: Incompatible stack types: I4 vs O
		//IL_0347->IL02d8: Incompatible stack types: I4 vs O
		//IL_03e7->IL02d8: Incompatible stack types: I4 vs O
		//IL_03f2->IL02d8: Incompatible stack types: I4 vs O
		object obj = 1;
		object obj13 = default(object);
		object obj3 = default(object);
		object obj23 = default(object);
		dynamic obj6 = default(object);
		object obj18 = default(object);
		object result = default(object);
		object obj20 = default(object);
		dynamic obj8 = default(object);
		object obj17 = default(object);
		object obj11 = default(object);
		object obj14 = default(object);
		dynamic obj12 = default(object);
		object obj10 = default(object);
		object obj16 = default(object);
		object obj22 = default(object);
		object obj25 = default(object);
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 991)
					{
						goto end_IL_0010;
					}
					goto case 3;
				case 1:
					obj13 = new Dictionary<string, string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
					obj2 = 0;
					if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd95bcb31f2a40c89aee1548651426a0 != 0)
					{
						obj2 = 0;
					}
					break;
				case 3:
					try
					{
						object obj4;
						if (System.IO.File.Exists((string)obj3))
						{
							obj4 = 2;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e041d974da614bb9aad5f28559bec3d0 == 0)
							{
								obj4 = 5;
							}
							goto IL_00ab;
						}
						goto IL_011c;
						IL_00ab:
						while (true)
						{
							switch ((int)obj4)
							{
							default:
								if ((nint)obj23 == 993)
								{
									obj4 = obj23;
									continue;
								}
								goto IL_05fe;
							case 2:
							case 5:
								obj6 = System.Text.Json.JsonDocument.Parse(System.IO.File.ReadAllText((string)obj3), default(JsonDocumentOptions));
								obj4 = 2;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_20242fceb1c648009846fc096f5b9270 != 0)
								{
									obj4 = 1;
								}
								continue;
							case 4:
								break;
							case 3:
								goto end_IL_00ab;
							case 1:
								try
								{
									dynamic obj5 = ((dynamic)obj6).RootElement;
									dynamic obj7 = 9;
									if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_35f00f496d71423193427920cdcc22f1 != 0)
									{
										obj7 = 1;
									}
									while (true)
									{
										object obj19;
										switch ((int)obj7)
										{
										default:
											if ((nint)obj18 != 15)
											{
												if ((nint)obj18 == 995)
												{
													goto IL_0199;
												}
												goto IL_05fe;
											}
											obj19 = ((dynamic)obj5).GetProperty("mappings");
											break;
										case 6:
											result = obj13;
											obj7 = 3;
											continue;
										case 1:
											if (((dynamic)obj5).TryGetProperty("schema", ref obj20))
											{
												obj18 = 15;
												goto IL_0199;
											}
											goto case 5;
										case 3:
											goto end_IL_019d;
										case 0:
											obj8 = ((Dictionary<string, string>)obj17).GetEnumerator();
											obj7 = 2;
											continue;
										case 7:
											if (obj17 == null)
											{
												obj7 = 11;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 != 0)
												{
													obj7 = 6;
												}
												continue;
											}
											goto case 0;
										case 5:
											obj19 = obj5;
											break;
										case 2:
											try
											{
												while (true)
												{
													IL_03f2:
													object obj9;
													if (!((dynamic)obj8).MoveNext())
													{
														obj9 = 5;
														goto IL_02d8;
													}
													goto IL_0375;
													IL_02d8:
													while (true)
													{
														switch ((int)obj9)
														{
														default:
															if ((nint)obj11 == 14)
															{
																goto IL_03f2;
															}
															if ((nint)obj11 != 994)
															{
																goto end_IL_03f2;
															}
															goto IL_02d4;
														case 1:
															obj14 = Normalize(((dynamic)obj12).Value);
															obj9 = 1;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
															{
																obj9 = 6;
															}
															continue;
														case 2:
															obj10 = Normalize(((dynamic)obj12).Key);
															obj9 = 1;
															continue;
														case 0:
															if (IsSafeRelativePath((string)obj14))
															{
																obj9 = 3;
																continue;
															}
															goto IL_03f2;
														case 4:
															break;
														case 3:
														{
															((Dictionary<string, string>)obj13)[(string)obj10] = (string)obj14;
															int num = 14;
															if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_86f85a596c344fa79bc760622a9efe43 != 0)
															{
																num = 5;
															}
															obj11 = num;
															goto IL_02d4;
														}
														case 6:
															if (IsSafeRelativePath((string)obj10))
															{
																obj9 = 7;
																if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
																{
																	obj9 = 0;
																}
																continue;
															}
															goto IL_03f2;
														case 5:
															goto end_IL_03f2;
															IL_02d4:
															obj9 = obj11;
															continue;
														}
														break;
													}
													goto IL_0375;
													IL_0375:
													obj12 = ((dynamic)obj8).Current;
													obj9 = 1;
													if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_481dc375f7e24d3cb0e875f941fcda75 == 0)
													{
														obj9 = 2;
													}
													goto IL_02d8;
													continue;
													end_IL_03f2:
													break;
												}
											}
											finally
											{
												((global::System.IDisposable)((dynamic)obj8)).Dispose();
												object obj15 = 4;
												if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_db2c7dd1aabc4c9a97a36e710c0128ab != 0)
												{
													obj15 = 0;
												}
												while (true)
												{
													switch ((int)obj15)
													{
													default:
														if ((nint)obj16 == 988)
														{
															obj15 = obj16;
															continue;
														}
														break;
													case 0:
														break;
													}
													break;
												}
											}
											goto IL_05fe;
										case 4:
											goto IL_05fe;
											IL_0199:
											obj7 = obj18;
											continue;
										}
										obj17 = JsonSerializer.Deserialize<Dictionary<string, string>>((JsonElement)obj19, (JsonSerializerOptions)null);
										obj7 = 7;
										continue;
										end_IL_019d:
										break;
									}
								}
								finally
								{
									if (obj6 != null)
									{
										object obj21 = 4;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_07c1f539d4f94d95bde09a0fba07dbbc != 0)
										{
											obj21 = 1;
										}
										while (true)
										{
											switch ((int)obj21)
											{
											default:
												if ((nint)obj22 == 989)
												{
													obj21 = obj22;
													continue;
												}
												break;
											case 1:
												break;
											case 0:
												goto end_IL_04e8;
											}
											((dynamic)obj6).Dispose();
											obj21 = 0;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9201b2a1b9374af3a02f4d68ff67dfea != 0)
											{
												obj21 = 2;
											}
											continue;
											end_IL_04e8:
											break;
										}
									}
								}
								goto end_IL_00ab;
							case 0:
								goto IL_05fe;
							}
							goto IL_011c;
							continue;
							end_IL_00ab:
							break;
						}
						goto end_IL_0069;
						IL_011c:
						result = obj13;
						obj4 = 3;
						goto IL_00ab;
						end_IL_0069:;
					}
					catch (global::System.Exception)
					{
						object obj24 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f1dd9923a6bd42d5867c8e2e591d3e3b != 0)
						{
							obj24 = 1;
						}
						while (true)
						{
							switch ((int)obj24)
							{
							default:
								if ((nint)obj25 == 989)
								{
									obj24 = obj25;
									continue;
								}
								break;
							case 1:
								break;
							case 0:
								goto end_IL_058a;
							}
							result = new Dictionary<string, string>((IEqualityComparer<string>)(object)System.StringComparer.OrdinalIgnoreCase);
							obj24 = 1;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_4abb095abaf846009b4cca8873b94957 == 0)
							{
								obj24 = 0;
							}
							continue;
							end_IL_058a:
							break;
						}
					}
					return (IReadOnlyDictionary<string, string>)result;
				case 2:
					goto IL_05fe;
				case 0:
					{
						obj3 = System.IO.Path.Combine(System.AppContext.BaseDirectory, ".chronal-files.json");
						obj2 = 5;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9608fe64d13146acb5eaea30e653fb87 == 0)
						{
							obj2 = 3;
						}
						break;
					}
					IL_05fe:
					return (IReadOnlyDictionary<string, string>)obj13;
				}
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private unsafe static string ResolveMappedRelativePath(string normalizedPath)
	{
		//IL_000c: Expected O, but got I4
		//IL_0031: Expected I4, but got O
		//IL_02d4: Expected I4, but got O
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_011a: Expected O, but got I4
		//IL_013f: Expected I4, but got O
		//IL_02aa->IL02c7: Incompatible stack types: I4 vs O
		//IL_02b5->IL02c7: Incompatible stack types: I4 vs O
		//IL_0307->IL02c7: Incompatible stack types: I4 vs O
		//IL_0312->IL02c7: Incompatible stack types: I4 vs O
		//IL_00dc->IL0010: Incompatible stack types: I4 vs O
		//IL_0387->IL0010: Incompatible stack types: I4 vs O
		//IL_00b3->IL0010: Incompatible stack types: I4 vs O
		//IL_0342->IL0010: Incompatible stack types: I4 vs O
		//IL_00e7->IL0010: Incompatible stack types: I4 vs O
		//IL_0392->IL0010: Incompatible stack types: I4 vs O
		//IL_00be->IL0010: Incompatible stack types: I4 vs O
		//IL_034d->IL0010: Incompatible stack types: I4 vs O
		//IL_0229->IL011e: Incompatible stack types: I4 vs O
		//IL_0234->IL011e: Incompatible stack types: I4 vs O
		//IL_028a->IL011e: Incompatible stack types: I4 vs O
		//IL_0251->IL011e: Incompatible stack types: I4 vs O
		//IL_01f2->IL011e: Incompatible stack types: I4 vs O
		//IL_025c->IL011e: Incompatible stack types: I4 vs O
		//IL_01fd->IL011e: Incompatible stack types: I4 vs O
		int num = 2;
		dynamic enumerator = default(object);
		dynamic obj4 = default(object);
		object obj3 = default(object);
		string result = default(string);
		object obj6 = default(object);
		dynamic obj7 = default(object);
		object obj9 = default(object);
		while (true)
		{
			object obj = num;
			while (true)
			{
				object obj2 = obj;
				while (true)
				{
					switch ((int)obj2)
					{
					default:
						if ((nint)obj != 13)
						{
							if ((nint)obj == 994)
							{
								goto end_IL_0010;
							}
							goto case 1;
						}
						enumerator = ((global::System.Collections.Generic.IEnumerable<KeyValuePair<string, string>>)Mapping.Value).GetEnumerator();
						obj2 = 4;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_6143552ba66645398402f7404618079f == 0)
						{
							obj2 = 0;
						}
						continue;
					case 6:
						break;
					case 3:
						return normalizedPath;
					case 0:
						return Normalize(string.Concat((string)obj4, (normalizedPath).Substring(((string)obj3).Length)));
					case 5:
						if (((string)obj3).Length != 0)
						{
							obj2 = 5;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 != 0)
							{
								obj2 = 0;
							}
							continue;
						}
						goto case 3;
					case 1:
						return (string)result;
					case 4:
						try
						{
							while (true)
							{
								IL_025c:
								int num2;
								if (!((dynamic)enumerator).MoveNext())
								{
									num2 = 3;
									goto IL_0116;
								}
								goto IL_020c;
								IL_011a:
								dynamic obj5 = obj6;
								goto IL_011e;
								IL_020c:
								obj7 = ((global::System.Collections.Generic.IEnumerator<KeyValuePair<string, string>>)enumerator).Current;
								obj5 = 2;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_a4b5b9d8fe0344d0a0d0c6ee7728050b != 0)
								{
									obj5 = 1;
								}
								goto IL_011e;
								IL_0116:
								obj6 = num2;
								goto IL_011a;
								IL_011e:
								while (true)
								{
									switch ((int)obj5)
									{
									case 4:
										if (!(normalizedPath).StartsWith(string.Concat(((dynamic)obj7).Key, "/"), (StringComparison)5))
										{
											goto IL_019d;
										}
										goto case 5;
									case 2:
										if ((((dynamic)obj7).Key).Length > ((string)obj3).Length)
										{
											obj5 = 5;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_0d16903d89da4928a5d60c2843281188 == 0)
											{
												obj5 = 4;
											}
											continue;
										}
										goto IL_025c;
									case 0:
										goto IL_020c;
									case 6:
										obj4 = ((dynamic)obj7).Value;
										obj5 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_e8864409e70b4d87b4c6598763ad15be == 0)
										{
											obj5 = 5;
										}
										continue;
									case 1:
										goto IL_025c;
									case 5:
										obj3 = ((dynamic)obj7).Key;
										obj5 = 6;
										continue;
									case 3:
										goto end_IL_025c;
									}
									break;
								}
								if ((nint)obj6 != 14)
								{
									if ((nint)obj6 == 994)
									{
										goto IL_011a;
									}
									goto IL_020c;
								}
								continue;
								IL_019d:
								num2 = 14;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_8cd7f54b623a4d42b1a5e008c75a22ed == 0)
								{
									num2 = 2;
								}
								goto IL_0116;
								continue;
								end_IL_025c:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								object obj8 = 0;
								if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7bc84b0f9b2d4d968eda9f4e194ba82d == 0)
								{
									obj8 = 3;
								}
								while (true)
								{
									switch ((int)obj8)
									{
									default:
										if ((nint)obj9 == 989)
										{
											obj8 = obj9;
											continue;
										}
										break;
									case 0:
										((dynamic)enumerator).Dispose();
										obj8 = 1;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_b8376d7b20c44b95a06e50039002465d == 0)
										{
											obj8 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 5;
					case 2:
						if (!Mapping.Value.TryGetValue(normalizedPath, out result))
						{
							obj3 = string.Empty;
							obj2 = 6;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_7965c0cf8c924e228a4010c08420db19 != 0)
							{
								obj2 = 4;
							}
						}
						else
						{
							obj2 = 4;
							if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_1545a17218a245d6823c855e6a4a65cd == 0)
							{
								obj2 = 1;
							}
						}
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
			obj4 = string.Empty;
			num = 13;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Normalize(string path)
	{
		return ((path).Replace('\\', '/')).TrimStart('/');
	}

	[MethodImpl((MethodImplOptions)8)]
	private static bool IsSafeRelativePath(string path)
	{
		//IL_000c: Expected O, but got I4
		//IL_0021: Expected I4, but got O
		//IL_0087->IL0010: Incompatible stack types: I4 vs O
		//IL_0058->IL0010: Incompatible stack types: I4 vs O
		//IL_0092->IL0010: Incompatible stack types: I4 vs O
		//IL_0063->IL0010: Incompatible stack types: I4 vs O
		object obj = 1;
		while (true)
		{
			object obj2 = obj;
			while (true)
			{
				switch ((int)obj2)
				{
				default:
					if ((nint)obj == 990)
					{
						goto end_IL_0010;
					}
					goto case 2;
				case 1:
					if (!string.IsNullOrWhiteSpace(path))
					{
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_f3d80f367d504e3d9064e4cfb99ce343 == 0)
						{
							obj2 = 0;
						}
						continue;
					}
					break;
				case 0:
					if (!System.IO.Path.IsPathRooted(path))
					{
						obj2 = 6;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_3054c4fc69b94a37b21ac42c2099175a != 0)
						{
							obj2 = 2;
						}
						continue;
					}
					break;
				case 2:
					return !Enumerable.Any<string>((global::System.Collections.Generic.IEnumerable<string>)(path).Split('/', (StringSplitOptions)1), (Func<string, bool>)([MethodImpl((MethodImplOptions)8)] (string segment) =>
					{
						//IL_000c: Expected O, but got I4
						//IL_0031: Expected I4, but got O
						//IL_00a1: Expected O, but got I4
						//IL_00c3: Expected O, but got I4
						//IL_005c: Expected I4, but got O
						//IL_00b5->IL0010: Incompatible stack types: I4 vs O
						//IL_00cd->IL0010: Incompatible stack types: I4 vs O
						//IL_0119->IL0010: Incompatible stack types: I4 vs O
						//IL_00c0->IL0010: Incompatible stack types: I4 vs O
						//IL_0124->IL0010: Incompatible stack types: I4 vs O
						int num = 2;
						dynamic obj5 = default(object);
						while (true)
						{
							object obj3 = num;
							while (true)
							{
								object obj4 = obj3;
								while (true)
								{
									switch ((int)obj4)
									{
									default:
										if ((nint)obj3 != 13)
										{
											if ((nint)obj3 == 994)
											{
												goto end_IL_0010_l;
											}
											goto case 0;
										}
										goto case 5;
									case 0:
									case 6:
										return (byte)(int)obj5 != 0;
									case 3:
										if (!(segment == ".."))
										{
											goto end_IL_000c;
										}
										goto case 1;
									case 1:
									case 4:
										obj5 = 1;
										obj4 = 0;
										if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_06501b7bae1743aa8336fe70312492d7 == 0)
										{
											obj4 = 2;
										}
										break;
									case 5:
										obj5 = 0;
										obj4 = 6;
										break;
									case 2:
										if ((segment == "."))
										{
											obj4 = 1;
											if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_9c15dc17ae4e48a5bd629d141b0ebe29 == 0)
											{
												obj4 = 0;
											}
											break;
										}
										goto case 3;
									}
									continue;
									end_IL_0010_l:
									break;
								}
								continue;
								end_IL_000c:
								break;
							}
							num = 13;
						}
					}));
				}
				return false;
				continue;
				end_IL_0010:
				break;
			}
		}
	}

	static PublishedFileResolver()
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
					case 2:
						num3 = 1;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_d2995c01469b4ef28b5784f7cbf606e2 == 0)
						{
							num3 = 1;
						}
						continue;
					case 3:
						return;
					case 0:
						Mapping = new Lazy<IReadOnlyDictionary<string, string>>((Func<IReadOnlyDictionary<string, string>>)LoadMapping);
						num3 = 3;
						continue;
					case 1:
						goto end_IL_000e;
					}
					switch (num2)
					{
					case 991:
						break;
					default:
						return;
					case 10:
						num3 = 0;
						if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_bd754e211a3740b7abeee191b9ceae68 == 0)
						{
							num3 = 8;
						}
						continue;
					}
					break;
				}
				continue;
				end_IL_000e:
				break;
			}
			num = 10;
			if (_Module__71380637_e598_4a57_acca_ae77afe4f1b2_.m_14bf68bee48c42698f3c6606c230b1db.m_ef04e2823b234f2aa7c3630bcaafe597 != 0)
			{
				num = 4;
			}
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool dmgqggLEIiTDL5r2Cl17()
	{
		return i0YmC2LEASqaPm4aymRb == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static PublishedFileResolver YAxCHjLEBeQBDSJAly59()
	{
		return i0YmC2LEASqaPm4aymRb;
	}
}

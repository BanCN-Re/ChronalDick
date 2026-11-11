using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using CZUx5njfSrbl1tnMcUCO;
using CbOMUrjZ4UEBbXFQjxfm;
using E3rtuYf3hKgKIPSbYth8;
using KvbiMlf3gwoQ1cpM2EDk;
using fDAldojjppXrctUVYOJn;
using rSrNDuf3mE35XoBDTuIX;

namespace y7ogWYfcgR1MVbKkctW3;

internal sealed class aCGyNsfcBIGnTe0qW9Ei
{
	[Serializable]
	[CompilerGenerated]
	private sealed class __c_90
	{
		public static readonly __c_90 __9;

		public static Comparison<wjj6nVf3ogsWdVdSQAAy> __9__7_0;

		internal static __c_90 y36jarDWsC5iJr61yIrP;

		[MethodImpl((MethodImplOptions)8)]
		private static void _cctor()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		public __c_90()
		{
			// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
			// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
			throw new global::System.NotSupportedException();
		}

		[MethodImpl((MethodImplOptions)8)]
		internal int svRLcXDhZMa(wjj6nVf3ogsWdVdSQAAy left, wjj6nVf3ogsWdVdSQAAy right)
		{
			return string.Compare(left.Name, right.Name, (StringComparison)5);
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static bool BADwx8DWTNPROvKRDyI8()
		{
			return y36jarDWsC5iJr61yIrP == null;
		}

		[MethodImpl((MethodImplOptions)8)]
		internal static __c_90 hVkZWQDWNcSl7bSV0O56()
		{
			return y36jarDWsC5iJr61yIrP;
		}
	}

	private static readonly object eUjfcwnS8Jt;

	private readonly object niJfceVfp5F;

	private static object iUyPyRZpkdDqNjtXmYII;

	internal string WorldsRoot
	{
		[MethodImpl((MethodImplOptions)8)]
		get
		{
			return (string)niJfceVfp5F;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal aCGyNsfcBIGnTe0qW9Ei(string dataRoot)
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal global::System.Collections.Generic.IReadOnlyList<wjj6nVf3ogsWdVdSQAAy> w2cfcld1M0y()
	{
		int num = 3;
		global::System.Collections.Generic.IEnumerator<string> enumerator = default(global::System.Collections.Generic.IEnumerator<string>);
		List<wjj6nVf3ogsWdVdSQAAy> val = default(List<wjj6nVf3ogsWdVdSQAAy>);
		string current = default(string);
		int num6 = default(int);
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
						if (num2 == 12)
						{
							enumerator = System.IO.Directory.EnumerateDirectories((string)niJfceVfp5F).GetEnumerator();
							num3 = 5;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_0d895297aed94afda41aaa76cf3137b6 != 0)
							{
								num3 = 1;
							}
							continue;
						}
						goto IL_003b;
					case 4:
						return (global::System.Collections.Generic.IReadOnlyList<wjj6nVf3ogsWdVdSQAAy>)val;
					case 0:
						return global::System.Array.Empty<wjj6nVf3ogsWdVdSQAAy>();
					case 2:
						goto end_IL_000c;
					case 3:
						if (System.IO.Directory.Exists((string)niJfceVfp5F))
						{
							num3 = 2;
							continue;
						}
						goto case 0;
					case 1:
						try
						{
							while (true)
							{
								IL_014a:
								int num4;
								if (!(enumerator).MoveNext())
								{
									num4 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe != 0)
									{
										num4 = 1;
									}
									goto IL_0118;
								}
								goto IL_017a;
								IL_017a:
								current = enumerator.Current;
								num4 = 2;
								goto IL_0118;
								IL_0118:
								while (true)
								{
									switch (num4)
									{
									default:
										switch (num6)
										{
										case 990:
											goto IL_0114;
										default:
											goto end_IL_014a;
										case 10:
											break;
										}
										goto IL_014a;
									case 0:
										break;
									case 2:
									{
										val.Add((wjj6nVf3ogsWdVdSQAAy)new wjj6nVf3ogsWdVdSQAAy(System.IO.Path.GetFileName(current), Y08fc5nHemS(current), current, System.IO.File.Exists(System.IO.Path.Combine(current, "chronal-world.json"))));
										int num5 = 10;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_61a44db6a0fb4ae58a5e07428a997db7 != 0)
										{
											num5 = 0;
										}
										num6 = num5;
										goto IL_0114;
									}
									case 1:
										goto end_IL_014a;
										IL_0114:
										num4 = num6;
										continue;
									}
									break;
								}
								goto IL_017a;
								continue;
								end_IL_014a:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c39439f4e61c460489a19388628355b5 == 0)
								{
									num7 = 6;
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
										break;
									case 0:
										goto end_IL_0241;
									}
									(enumerator).Dispose();
									num7 = 5;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b == 0)
									{
										num7 = 0;
									}
									continue;
									end_IL_0241:
									break;
								}
							}
						}
						break;
					case 5:
						break;
					}
					goto IL_0297;
					IL_003b:
					if (num2 == 993)
					{
						break;
					}
					goto IL_0297;
					IL_0297:
					val.Sort((Comparison<wjj6nVf3ogsWdVdSQAAy>)([MethodImpl((MethodImplOptions)8)] (wjj6nVf3ogsWdVdSQAAy left, wjj6nVf3ogsWdVdSQAAy right) => string.Compare(left.Name, right.Name, (StringComparison)5)));
					num3 = 4;
				}
				continue;
				end_IL_000c:
				break;
			}
			val = new List<wjj6nVf3ogsWdVdSQAAy>();
			num = 12;
		}
	}

	[MethodImpl((MethodImplOptions)8)]
	internal wjj6nVf3ogsWdVdSQAAy PIjfcdHsssB(Y7XDAnf34PXxEUue3XLL options)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string text = default(string);
		Dw6GWNf3Bc1hwbOQdTkG dw6GWNf3Bc1hwbOQdTkG = default(Dw6GWNf3Bc1hwbOQdTkG);
		System.IO.File.WriteAllText(System.IO.Path.Combine(text, "chronal-world.json"), JsonSerializer.Serialize<Dw6GWNf3Bc1hwbOQdTkG>(dw6GWNf3Bc1hwbOQdTkG, (JsonSerializerOptions)eUjfcwnS8Jt), (Encoding)new UTF8Encoding(false));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal wjj6nVf3ogsWdVdSQAAy? BGrfcKTs2eF(string worldId)
	{
		string text = K87fcODg6Y3(worldId);
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal void jtVfcHA7cOZ(string worldId)
	{
		int num = 1;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal Dw6GWNf3Bc1hwbOQdTkG? RK7fctHQHGH(wjj6nVf3ogsWdVdSQAAy world)
	{
		//IL_0994: Expected O, but got Unknown
		//IL_0a37: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		string text = default(string);
		int num4 = default(int);
		int num9 = default(int);
		bool flag5 = default(bool);
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool flag6 = default(bool);
		bool flag4 = default(bool);
		Dw6GWNf3Bc1hwbOQdTkG result = default(Dw6GWNf3Bc1hwbOQdTkG);
		int num11 = default(int);
		int num13 = default(int);
		int num15 = default(int);
		int num17 = default(int);
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
				case 1:
					System.ArgumentNullException.ThrowIfNull(world, "world");
					num2 = 5;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_524f5ad13c4d4446a85a1792c6d83312 != 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					text = System.IO.Path.Combine(world.DirectoryPath, "chronal-world.json");
					num2 = 6;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9b483289fd2d419e96745c4d6c05fcfe == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					try
					{
						FileStream val = System.IO.File.OpenRead(text);
						int num3 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 != 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								if (num4 == 988)
								{
									goto IL_0105;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_0105:
							num3 = num4;
						}
						try
						{
							Dw6GWNf3Bc1hwbOQdTkG dw6GWNf3Bc1hwbOQdTkG = JsonSerializer.Deserialize<Dw6GWNf3Bc1hwbOQdTkG>((Stream)(object)val, (JsonSerializerOptions)eUjfcwnS8Jt);
							int num5 = 47;
							while (true)
							{
								IL_0148:
								int num6 = num5;
								while (true)
								{
									IL_014c:
									int num7 = num6;
									while (true)
									{
										int num8;
										switch (num7)
										{
										default:
											if (num6 != 68)
											{
												if (num6 == 1048)
												{
													goto IL_014c;
												}
												goto case 45;
											}
											goto case 0;
										case 32:
											num9 = dw6GWNf3Bc1hwbOQdTkG.Difficulty;
											num7 = 7;
											continue;
										case 17:
										case 36:
											flag5 = flag2;
											num7 = 43;
											continue;
										case 43:
											flag = flag5;
											num7 = 24;
											continue;
										case 28:
											num9 = dw6GWNf3Bc1hwbOQdTkG.WorldType;
											num7 = 9;
											continue;
										case 45:
										case 48:
											flag2 = false;
											num7 = 17;
											continue;
										case 20:
											flag2 = false;
											num7 = 38;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_5c224e01297545848690412c4456a00b != 0)
											{
												num7 = 1;
											}
											continue;
										case 34:
										case 60:
											flag2 = true;
											num7 = 0;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_44db6b597e6a4c5ba136dabe919799ed == 0)
											{
												num7 = 9;
											}
											continue;
										case 8:
											if (num9 < 0)
											{
												num7 = 13;
												continue;
											}
											goto case 41;
										case 59:
											if (num9 >= 0)
											{
												num7 = 52;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_d80d15e024c0452d9f7f2823e8f90604 == 0)
												{
													num7 = 25;
												}
												continue;
											}
											goto case 11;
										case 51:
											if (num9 <= 2)
											{
												num7 = 14;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
												{
													num7 = 10;
												}
												continue;
											}
											goto case 34;
										case 31:
										case 40:
											flag3 = flag2;
											num7 = 6;
											continue;
										case 9:
											if (num9 < 0)
											{
												num7 = 5;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9af2cb9dcf5e45419344679d8e8c8972 != 0)
												{
													num7 = 60;
												}
												continue;
											}
											goto case 51;
										case 27:
											if (num9 < 0)
											{
												num7 = 21;
												continue;
											}
											goto case 44;
										case 22:
											if (num9 > 3)
											{
												num5 = 5;
												break;
											}
											goto case 20;
										case 57:
											num9 = dw6GWNf3Bc1hwbOQdTkG.GameType;
											num7 = 27;
											continue;
										case 44:
											if (num9 > 2)
											{
												num7 = 55;
												continue;
											}
											goto case 54;
										case 6:
										case 46:
											if (!flag3)
											{
												num7 = 58;
												continue;
											}
											goto case 10;
										case 37:
											num9 = dw6GWNf3Bc1hwbOQdTkG.CheatInfo.RandomTickSpeed;
											num7 = 60;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_9e67050f6408481fbc380a5e1bca0cea != 0)
											{
												num7 = 8;
											}
											continue;
										case 15:
											if (!flag5)
											{
												num7 = 22;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_e2dfab2d12d4423f878df7f6a94dcb82 == 0)
												{
													num7 = 3;
												}
												continue;
											}
											goto case 43;
										case 38:
											if (flag6)
											{
												num7 = 49;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_aa19045d8cc04881bdd027a20527f49b != 0)
												{
													num7 = 0;
												}
												continue;
											}
											goto case 32;
										case 11:
											flag2 = true;
											num7 = 36;
											continue;
										case 18:
										case 39:
											flag6 = flag4;
											num7 = 38;
											continue;
										case 21:
										case 55:
											flag2 = true;
											num7 = 23;
											continue;
										case 5:
										case 50:
											flag2 = true;
											num7 = 25;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4d82189af7174ac29de2d729baeb58e3 != 0)
											{
												num7 = 24;
											}
											continue;
										case 7:
											if (num9 < 0)
											{
												num7 = 50;
												continue;
											}
											goto case 22;
										case 52:
											if (num9 <= 2)
											{
												num7 = 45;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8b4281af0d8146f391be79c270708234 == 0)
												{
													num7 = 68;
												}
												continue;
											}
											goto case 11;
										case 54:
											flag2 = false;
											num7 = 19;
											continue;
										case 19:
										case 23:
											flag4 = flag2;
											num7 = 39;
											continue;
										case 0:
											flag = flag2;
											num7 = 33;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_68f88339a3f94a80900b6123f937270e != 0)
											{
												num7 = 4;
											}
											continue;
										case 3:
											num9 = dw6GWNf3Bc1hwbOQdTkG.PermissionLevel;
											num7 = 56;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_1c6972194d6c4f46bf57f27de61ff8b5 == 0)
											{
												num7 = 59;
											}
											continue;
										case 4:
										case 30:
											flag3 = flag;
											num7 = 2;
											continue;
										case 1:
										case 25:
											flag6 = flag2;
											num7 = 56;
											continue;
										case 49:
										case 56:
											flag5 = flag6;
											num7 = 15;
											continue;
										case 12:
											if (flag4)
											{
												num7 = 18;
												continue;
											}
											goto case 57;
										case 35:
											num8 = (((object)dw6GWNf3Bc1hwbOQdTkG.CheatInfo == null) ? 1 : 0);
											goto IL_080b;
										case 14:
										case 53:
											flag2 = false;
											num5 = 68;
											break;
										case 10:
											throw new InvalidDataException(string.Concat("世界“", world.Name, "”的创建配置无效，请检查 ", text));
										case 58:
											result = dw6GWNf3Bc1hwbOQdTkG;
											num5 = 16;
											break;
										case 2:
											if (flag3)
											{
												num7 = 46;
												if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8e6739a90535403985d371d7de1b9636 == 0)
												{
													num7 = 43;
												}
												continue;
											}
											goto case 37;
										case 41:
											if (num9 <= 4096)
											{
												num7 = 26;
												continue;
											}
											goto case 13;
										case 13:
										case 42:
											flag2 = true;
											num7 = 47;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_dce85267daf04bfcb40fac484440d500 == 0)
											{
												num7 = 31;
											}
											continue;
										case 26:
										case 29:
											flag2 = false;
											num7 = 4;
											if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_ebd75b17fa8b4c4f9060864173f39921 == 0)
											{
												num7 = 40;
											}
											continue;
										case 47:
											if ((object)dw6GWNf3Bc1hwbOQdTkG == null)
											{
												num7 = 33;
												continue;
											}
											goto case 35;
										case 24:
											if (flag)
											{
												num7 = 30;
												continue;
											}
											goto case 28;
										case 33:
											num8 = 1;
											goto IL_080b;
										case 16:
											goto end_IL_0150;
											IL_080b:
											flag4 = (byte)num8 != 0;
											num7 = 12;
											continue;
										}
										goto IL_0148;
										continue;
										end_IL_0150:
										break;
									}
									break;
								}
								break;
							}
						}
						finally
						{
							if (val != null)
							{
								int num10 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_4349f91e6b9848aa860dd9953f01776e != 0)
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
										num10 = 1;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_798ffcbb29594c49b91a3c5fc2644e96 == 0)
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
					}
					catch (FileNotFoundException)
					{
						int num12 = 0;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_bf95579c348c46228a07fcfd8338fdd7 != 0)
						{
							num12 = 7;
						}
						while (true)
						{
							switch (num12)
							{
							default:
								if (num13 == 989)
								{
									num12 = num13;
									continue;
								}
								break;
							case 0:
								result = null;
								num12 = 1;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8ffb9ca7aaaf4b3dad8eb7d136d516cd != 0)
								{
									num12 = 7;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (DirectoryNotFoundException)
					{
						int num14 = 2;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_a89dd6bf5b6b475b8b3ccfab1dee855c == 0)
						{
							num14 = 0;
						}
						while (true)
						{
							switch (num14)
							{
							default:
								if (num15 == 989)
								{
									num14 = num15;
									continue;
								}
								break;
							case 0:
								result = null;
								num14 = 7;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_54777ff855264ed9be41c84b5b1f7943 == 0)
								{
									num14 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					catch (JsonException ex3)
					{
						JsonException ex4 = ex3;
						int num16 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_6432c74318da42529eece19c167b3f7b != 0)
						{
							num16 = 0;
						}
						while (true)
						{
							switch (num16)
							{
							default:
								if (num17 == 988)
								{
									goto IL_09c1;
								}
								break;
							case 0:
								break;
							}
							break;
							IL_09c1:
							num16 = num17;
						}
						throw new InvalidDataException(string.Concat("世界“", world.Name, "”的创建配置已损坏，无法按所选设置启动。请检查 ", text), (global::System.Exception)(object)ex4);
					}
					break;
				case 3:
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
	private string K87fcODg6Y3(string worldId)
	{
		string text = string.Concat(((System.ReadOnlySpan<char>)(System.IO.Path.GetFullPath((string)niJfceVfp5F)).TrimEnd(new char[2]
		{
			Path.DirectorySeparatorChar,
			Path.AltDirectorySeparatorChar
		})), new global::System.ReadOnlySpan<char>(new char[] { Path.DirectorySeparatorChar }));
		return null;
	}

	[MethodImpl((MethodImplOptions)8)]
	private static string Y08fc5nHemS(object worldDirectory)
	{
		int num = 1;
		string text2 = default(string);
		string result = default(string);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out global::System.Exception obj2);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int num5);
		global::System.Exception ex = default(global::System.Exception);
		int num6 = default(int);
		bool flag = default(bool);
		global::System.Runtime.CompilerServices.Unsafe.SkipInit(out int result2);
		int num8 = default(int);
		while (true)
		{
			switch (num)
			{
			case 989:
				continue;
			case 1:
				try
				{
					string text = System.IO.Path.Combine((string)worldDirectory, "levelname.txt");
					int num2 = 4;
					while (true)
					{
						IL_0073:
						int num3 = num2;
						while (true)
						{
							IL_0077:
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								default:
									if (num3 != 13)
									{
										if (num3 == 993)
										{
											goto IL_0077;
										}
										goto case 4;
									}
									text2 = (System.IO.File.ReadAllText(text)).Trim();
									num4 = 6;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_37ffa5b0c72d40eb8de946892a34dfd9 == 0)
									{
										num4 = 2;
									}
									continue;
								case 5:
									result = text2;
									num4 = 1;
									if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_04958cf3a953477a985e4ec09b4b5538 != 0)
									{
										num4 = 1;
									}
									continue;
								case 2:
									if ((text2).Length <= 0)
									{
										num4 = 0;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_8615aaf938cf4570af0889f972d683ea == 0)
										{
											num4 = 3;
										}
										continue;
									}
									goto case 5;
								case 4:
									if (System.IO.File.Exists(text))
									{
										num2 = 13;
										if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_34a5db7426d74a488b6b8caf3d9472fe == 0)
										{
											num2 = 6;
										}
										break;
									}
									goto end_IL_007b;
								case 0:
									goto end_IL_007b;
								case 3:
									goto end_IL_007b;
								case 1:
									return result;
								}
								goto IL_0073;
								continue;
								end_IL_007b:
								break;
							}
							break;
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
						num5 = 3;
						if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4b7f4811f5943a686096473256b200e == 0)
						{
							num5 = 10;
						}
						goto IL_01e9;
					}
					ex = obj2;
					num6 = 14;
					goto IL_01e5;
					IL_01e9:
					while (true)
					{
						switch (num5)
						{
						default:
							if (num6 != 14)
							{
								if (num6 == 994)
								{
									break;
								}
								goto case 4;
							}
							if (ex is IOException)
							{
								num5 = 0;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_c4502d1aed634d8ab4a26f527c9c2b62 == 0)
								{
									num5 = 14;
								}
								continue;
							}
							goto case 2;
						case 4:
							flag = false;
							num5 = 10;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f860bc9bc09245d1bf1bcd734da9baf3 == 0)
							{
								num5 = 1;
							}
							continue;
						case 2:
							if (ex is UnauthorizedAccessException)
							{
								num5 = 6;
								if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_cde2cc81af854e24a048011447f5cade != 0)
								{
									num5 = 0;
								}
								continue;
							}
							goto case 4;
						case 0:
						case 6:
							flag = true;
							num5 = 9;
							if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_f6e254b07c27473c8f0701143d4d3ff0 == 0)
							{
								num5 = 5;
							}
							continue;
						case 3:
							result2 = 0;
							goto IL_02fa;
						case 1:
						case 5:
							{
								result2 = (flag ? 1 : 0);
								goto IL_02fa;
							}
							IL_02fa:
							return (byte)result2 != 0;
						}
						break;
					}
					goto IL_01e5;
					IL_01e5:
					num5 = num6;
					goto IL_01e9;
				}).Invoke())
				{
					int num7 = 1;
					if (_Module__abc899df_385b_47dd_9d1a_5f083f4653c0_.m_e6fbaaf306504e1eb6792fe8d1ae4641.m_b3af7d01b4714600ad02861eb522850a == 0)
					{
						num7 = 0;
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
				break;
			}
			break;
		}
		return System.IO.Path.GetFileName((string)worldDirectory);
	}

	[MethodImpl((MethodImplOptions)8)]
	private static void _cctor()
	{
		// UNDECRYPTED: Reactor never decrypted this body (Bad IL range in the original
		// metadata). Re-harvest with vmrun to recover it -- see HANDOFF.md section 6.
		throw new global::System.NotSupportedException();
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static bool YOfJ4BZpVAsEPxBZcMQl()
	{
		return iUyPyRZpkdDqNjtXmYII == null;
	}

	[MethodImpl((MethodImplOptions)8)]
	internal static aCGyNsfcBIGnTe0qW9Ei OL0Oy6ZpY1k4EqACEJRI()
	{
		return (aCGyNsfcBIGnTe0qW9Ei)iUyPyRZpkdDqNjtXmYII;
	}
}
